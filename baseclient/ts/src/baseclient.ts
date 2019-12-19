import * as $tea from '@alicloud/tea-typescript';
import Creadential from '@alicloud/credentials';
import { Parser, Builder } from 'xml2js';
import kitx from 'kitx';
import { platform, arch } from 'os';
import { getType } from 'mime';
import { Readable } from 'stream';
import { createHash } from 'crypto';
import Crc64 from './crc';
import { getSignatureV2, getSignatureV1 } from './signature';

function parseXML(body: string): any {
  let parser = new Parser({ explicitArray: false });
  let result: {[key: string]: any} = {};
  // parseString 实际上是一个同步方法
  parser.parseString(body, function (err: any, output: any) {
    result.err = err;
    result.output = output;
  });

  if (result.err) {
    throw result.err;
  }

  return result.output;
}

export default class BaseClient {

  _endpoint: string
  _regionId: string
  _autoretry: boolean
  _protocol: string
  _userAgent: string
  _readTimeout: number
  _connectTimeout: number
  _localAddr: string
  _httpProxy: string
  _httpsProxy: string
  _hostModel: string
  _noProxy: string
  _socks5Proxy: string
  _socks5NetWork: string
  _isEnableMD5: boolean
  _isEnableCrc: boolean
  _signatureVersion: string
  _addtionalHeaders: string[]
  _maxIdleConns: number
  _logger: any
  _creadentials: Creadential
  _contentMd5: string
  _contentLength: number

  constructor(config: { [key: string]: any }) {
    this._protocol = config['protocol'];
    this._endpoint = config['endpoint'];
    this._regionId = config['regionId'] || 'cn-hangzhou';
    this._signatureVersion = 'v1';
    this._isEnableMD5 = config['isEnableMD5'] || false;
    this._isEnableCrc = config['isEnableCrc'] || false;
    this._userAgent = `AlibabaCloud (${platform()}; ${arch()}) Node.js/${process.version} Core/1.0.1`
    this._hostModel = config['hostModel'] || 'domain';

    this._addtionalHeaders = [];
    if (!config['type']) {
      config['type'] = 'access_key';
    }

    this._creadentials = new Creadential({
      accessKeyId: config['accessKeyId'],
      accessKeySecret: config['accessKeySecret'],
      securityToken: config['securityToken'],
      type: config['type'],
    }, {});
  }

  _addAddtionalHeaders(header: string): void {
    this._addtionalHeaders.push(header);
  }

  _setAddtionalHeaders(headers: string[]): void {
    if (!headers) {
      return;
    }
    this._addtionalHeaders = headers;
  }

  _getAddtionalHeaders(): string[] {
    return this._addtionalHeaders;
  }
  _setSignatureVersion(version: string): void {
    if (!version) {
      return;
    }
    this._signatureVersion = version.toLocaleLowerCase();
  }

  _setHostModel(model: string) {
    if (!model) {
      return;
    }
    this._hostModel = model.toLocaleLowerCase();
  }

  _setRegionId(regionId: string) {
    this._regionId = regionId || 'cn-hangzhou';
  }

  _getDate(): string {
    let now = new Date();
    return now.toUTCString();
  }

  _xmlCast<T>(obj: any, clazz: T): { [key: string]: any } {
    obj = obj || {};
    let ret: { [key: string]: any } = {};
    let clz = clazz as any;
    let names: { [key: string]: string } = clz.names();
    let types: { [key: string]: any } = clz.types();

    Object.keys(names).forEach((key) => {
      let originName = names[key];
      let value = obj[originName];
      let type = types[key];
      switch (type) {
        case 'boolean':
          if (!value) {
            ret[originName] = false;
            return;
          }
          ret[originName] = value === 'false' ? false : true;
          return;
        case 'number':
          if (value != 0 && !value) {
            ret[originName] = NaN;
            return;
          }
          ret[originName] = +value;
          return;
        case 'string':
          if (!value) {
            ret[originName] = '';
            return;
          }
          ret[originName] = value.toString();
          return;
        default:
          if (type.type === 'array') {
            if (!value) {
              ret[originName] = [];
              return;
            }
            if (!Array.isArray(value)) {
              value = [value];
            }
            if (typeof type.itemType === 'function') {
              ret[originName] = value.map((d: any) => {
                return this._xmlCast(d, type.itemType);
              });
            } else {
              ret[originName] = value;
            }
          } else if (typeof type === 'function') {
            if (!value) {
              value = {}
            }
            ret[originName] = this._xmlCast(value, type);
          } else {
            ret[originName] = value;
          }
      }
    })
    return ret;
  }

  async _readAsString(response: $tea.Response): Promise<string> {
    let bytes = await response.readBytes();
    return bytes.toString();
  }

  _parseXml<T>(body: string, clazz: T): { [key: string]: any } {
    let ret: { [key: string]: any } = parseXML(body);
    if (typeof clazz !== 'undefined') {
      ret = this._xmlCast(ret, clazz);
    }
    return ret;
  }

  _equal(a: string, b: string): boolean {
    return a === b;
  }

  _empty(input: string): boolean {
    return !input;
  }

  _ifListEmpty(list: string[]): boolean {
    return !list || list.length === 0
  }

  _listToString(list: string[], separator: string) : string {
    return list.join(separator);
  }

  _getSignatureV1(request: $tea.Request, bucketName: string, accessKeySecret: string): string {
    let result = getSignatureV1(request, bucketName, accessKeySecret);
    return result.signature;
  }

  _getSignatureV2(request: $tea.Request, bucketName: string, accessKeySecret: string, addtionalHeaders: string[]): string {
    let result = getSignatureV2(request, bucketName, accessKeySecret, addtionalHeaders);
    return result.signature;
  }

  _default(value: string, defaultVal: string): string {
    if (!value) {
      return defaultVal;
    }
    return value;
  }

  _defaultNumber(number: number, defaultNum: number): number {
    if (!number) {
      return defaultNum;
    }
    return number;
  }

  _isFail(response: { [key: string]: any }): boolean {
    if (!response) {
      return true;
    }
    if (response.statusCode >= 200 && response.statusCode < 300) {
      return false;
    }
    return true;
  }

  _toQuery(query: { [key: string]: any }): { [key: string]: string } {
    let ret: { [key: string]: string } = {};
    if (!query) {
      return ret;
    }
    for (let [key, value] of Object.entries(query)) {
      if (typeof value === 'undefined' || value == null) {
        ret[key] = '';
        continue;
      }
      ret[key] = value.toString();
    }
    return ret;
  }

  _toMeta(meta: { [key: string]: any }, prefix: string): { [key: string]: string } {
    let ret: { [key: string]: string } = {};
    if (!meta) {
      return ret;
    }
    Object.keys(meta).forEach((key) => {
      if (typeof meta[key] === 'undefined' || meta[key] == null){
        meta[key] = '';
      }
      if (!key.startsWith(prefix)) {
        ret[prefix + key] = meta[key].toString();
        return;
      }
      ret[key] = meta[key].toString();
    });
    return ret;
  }

  _parseMeta(meta: { [key: string]: any }, prefix: string): { [key: string]: string } {
    let ret: { [key: string]: string } = {};
    if (!meta) {
      return ret;
    }
    Object.keys(meta).forEach((key) => {
      if (key.startsWith(prefix)) {
        ret[key.replace(prefix, '')] = meta[key];
        return;
      }
      ret[key] = meta[key];
    });
    return ret;
  }

  _getContentMD5(body: string): string {
    return kitx.md5(body, 'hex');
  }

  _getContentType(name: string): string {
    return getType(name) || 'text/plain';
  }

  _isNotCrcMatched(calCrc: Buffer, respCrc: string): boolean {
    if (this._isEnableCrc && calCrc.toString() !== respCrc) {
      return true;
    }
    return false;
  }

  _encode(value: string, type: string): string {
    if (!value) {
      return '';
    }
    let strs = value.split('/');
    let str = strs[strs.length - 1];
    switch (type) {
      case 'UrlEncode':
        str = encodeURIComponent(str);
        strs[strs.length - 1] = str;
        return strs.join('/');
      case 'Base64':
        str = Buffer.from(str).toString('base64');
        strs[strs.length - 1] = str;
        return strs.join('/');
    }
  }

  _base64Decode(value: string): string {
    if (!value) {
      return '';
    }
    const strs = value.split('/');
    const result = Buffer.from(strs[strs.length - 1], 'base64').toString('utf8');
    strs[strs.length - 1] = result
    return strs.join('/');
  }

  _getCrc(a: $tea.Request, b: string, c: any, d: any): Buffer {
    throw new Error('the method is un-implemented!');
  }

  _getRespCrc(response: $tea.Response, b: boolean, c: any, d: any): Buffer {
    throw new Error('the method is un-implemented!');
  }

  _getUserAgent(userAgent: string = ''): string {
    if (userAgent) {
      return this._userAgent + ' ' + userAgent;
    }
    return this._userAgent;
  }

  _isUploadSpeedLimit(body: Readable, limit: number): Readable {
    if (limit == 0) {
      return body;
    }
    //Todo: finish speed limit readstream
    return body;
  }

  _ifRange(header: any): boolean {
    if (header && header['Range']) {
      return true;
    }
    return false;
  }

  _headerCast<T>(obj: any, clazz: T): { [key: string]: string } {
    let ret: { [key: string]: string } = {};
    let clz = clazz as any;
    let names: { [key: string]: string } = clz.names();
    Object.keys(names).forEach((key) => {
      let targetName = names[key];
      let value = obj[key];
      if (typeof value === 'undefined' || value == null) {
        ret[targetName] = '';
        return;
      }
      ret[targetName] = value.toString();
    });
    return ret;
  }

  _toHeader(header: any): { [key: string]: string } {
    let ret: { [key: string]: string } = {};
    if (!header) {
      return ret;
    }
    if (header.constructor && typeof header.constructor.names == 'function') {
      return this._headerCast(header, header.constructor);
    }
    for (let [key, value] of Object.entries(header)) {
      if (typeof value === 'undefined' || value == null) {
        ret[key] = '';
        continue;
      }
      ret[key] = value.toString();
    }
    return ret;
  }

  _readAsStream(response: $tea.Response): Readable {
    return response.body;
  }

  _getTracker(): any {
    throw new Error('the method is un-implemented!');
  }

  async _getAccessKeyID(): Promise<string> {
    return await this._creadentials.getAccessKeyId();
  }

  async _getAccessKeySecret(): Promise<string> {
    return await this._creadentials.getAccessKeySecret();
  }

  async _getSecurityToken(): Promise<string> {
    return await this._creadentials.getSecurityToken();
  }

  _getErrMessage(xml: string): { [key: string]: any } {
    let body: { [key: string]: any } = parseXML(xml);
    return body.Error || {};
  }

  _toXML(body: any): string {
    const builder = new Builder();
    return builder.buildObject(body);
  }

  _notNull(obj: {[key: string]: any}): boolean {
    return !!obj;
  }

  _inject(readable: Readable, ref: { [key: string]: string }): Readable {
    let shasum = createHash('md5');
    let crc64 = new Crc64();
    readable.on('data', function (chunk: Buffer) {
      shasum.update(chunk);
      crc64.update(chunk);
    });
    readable.on('end', function () {
      ref['md5'] = shasum.digest('base64');
      ref['crc'] = crc64.sum();
    });
    readable.pause();
    return readable;
  }
}
