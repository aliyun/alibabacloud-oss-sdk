import * as $tea from '@alicloud/tea-typescript';
import Creadential from '@alicloud/credentials';
import { parseStringPromise, Builder } from 'xml2js';
import { platform, arch } from 'os';
import { getType } from 'mime';
import { Readable } from 'stream';
import { getSignatureV2, getSignatureV1 } from './signature';

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
  _creadentials: any
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
    this._hostModel = 'domain';

    this._addtionalHeaders = [];
    if (!config['type']) {
      config['type'] = 'access_key'
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

  _getAuth(request: $tea.Request, bucketName: string): string {
    let auth = '';
    if (!this._creadentials) {
      return '';
    }
    const accessKeyId = this._creadentials.accessKeyId;

    const accessKeySecret = this._creadentials.accessKeySecret;
    const securityToken = this._creadentials.securityToken;

    if (!!securityToken) {
      request.headers['X-Oss-Security-Token'] = securityToken;
    }
    if (this._signatureVersion === 'v1') {
      const sign = getSignatureV1(request, bucketName, accessKeySecret);
      auth = `OSS ${accessKeyId}:${sign}`;
    } else {
      const sign = getSignatureV2(request, bucketName, accessKeySecret, this._addtionalHeaders);
      let addtinalHeaders = '';
      if (this._addtionalHeaders.length) {
        addtinalHeaders = `,AdditionalHeaders:${this._addtionalHeaders.join(';')}`
      }
      auth = `OSS2 AccessKeyId: ${accessKeyId}${addtinalHeaders},Signature:${sign}`;
    }
    return auth
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

  async _parseXml<T>(response: $tea.Response, clazz: T): Promise<{ [key: string]: any }> {
    let ret: { [key: string]: any } = {};
    let body = await response.readBytes();
    ret = await parseStringPromise(body, { explicitArray: false });
    if (typeof clazz !== 'undefined') {
      ret = this._xmlCast(ret, clazz);
    }
    return ret;
  }

  _getHost(bucketName: string): string {
    let host = '';
    if (!this._endpoint) {
      this._endpoint = "oss-" + this._regionId + ".aliyuncs.com"
    }
    if (!bucketName) {
      return this._endpoint;
    } else {
      if (this._hostModel === 'ip') {
        host = this._endpoint + '/' + bucketName;
      } else if (this._hostModel === 'cname') {
        host = this._endpoint;
      } else {
        host = bucketName + '.' + this._endpoint;
      }
    }
    return host
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

  _toBody(body: any): string {
    const builder = new Builder();
    const xml = builder.buildObject(body);
    return xml;
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

  _getContentMD5(request: $tea.Request, md5Value: string, md5Threshold: Buffer): string {
    if (!this._isEnableMD5) {
      return '';
    }
    if (md5Value) {
      return md5Value;
    }
  }

  _getContentLength(request: $tea.Request, length: string): string {
    if (length) {
      return length;
    }
    return '0';
  }

  _getSpecialValue(obj: any, key: string): string {
    if (!obj) {
      return '';
    }
    let ret = obj[key];
    if (!ret) {
      return '';
    }
    return ret.toString();
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

  _urlDecode(value: string): string {
    if (!value) {
      return '';
    }
    const strs = value.split('/');
    const result = decodeURIComponent(strs[strs.length - 1]);
    strs[strs.length - 1] = result
    return strs.join('/');
  }

  _parseUint(respCrc: string, hasRange: boolean): number {
    if (hasRange) {
      return 0;
    }
    return parseInt(respCrc);
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
    return response._response;
  }

  _getTracker(): any {
    throw new Error('the method is un-implemented!');
  }

  async _getErrMessage(response: $tea.Response): Promise<{ [key: string]: any }> {
    let body = await this._parseXml(response, undefined);
    let erorr = body.Error || {};
    return {
      Code: erorr['Code'],
      Message: erorr['Message'],
      RequestId: erorr['RequestId'],
      HostId: erorr['HostId']
    };
  }
}
