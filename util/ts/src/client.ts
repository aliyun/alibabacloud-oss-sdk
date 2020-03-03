// This file is auto-generated, don't edit it
import { Readable } from 'stream';
import * as $tea from '@alicloud/tea-typescript';
import { Parser } from 'xml2js';
import kitx from 'kitx';
import { getType } from 'mime';
import { createHash } from 'crypto';
import Crc64 from './crc';
import { platform, arch } from 'os';
import { getSignatureV2, getSignatureV1 } from './signature';

const DEFAULT_AGENT = `AlibabaCloud (${platform()}; ${arch()}) Node.js/${process.version} Core/1.0.1`

function parseXML(body: string): any {
  let parser = new Parser({ explicitArray: false });
  let result: { [key: string]: any } = {};
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

function base64Decode(value: string): string {
  if (!value) {
    return '';
  }
  const strs = value.split('/');
  const result = Buffer.from(strs[strs.length - 1], 'base64').toString('utf8');
  strs[strs.length - 1] = result
  return strs.join('/');
}

export class RuntimeOptions extends $tea.Model {
  autoretry?: boolean;
  ignoreSSL?: boolean;
  maxAttempts?: number;
  backoffPolicy?: string;
  backoffPeriod?: number;
  readTimeout?: number;
  connectTimeout?: number;
  localAddr?: string;
  httpProxy?: string;
  httpsProxy?: string;
  noProxy?: string;
  maxIdleConns?: number;
  socks5Proxy?: string;
  socks5NetWork?: string;
  uploadLimitSpeed?: number;
  listener?: any;
  static names(): { [key: string]: string } {
    return {
      autoretry: 'autoretry',
      ignoreSSL: 'ignoreSSL',
      maxAttempts: 'maxAttempts',
      backoffPolicy: 'backoffPolicy',
      backoffPeriod: 'backoffPeriod',
      readTimeout: 'readTimeout',
      connectTimeout: 'connectTimeout',
      localAddr: 'localAddr',
      httpProxy: 'httpProxy',
      httpsProxy: 'httpsProxy',
      noProxy: 'noProxy',
      maxIdleConns: 'maxIdleConns',
      socks5Proxy: 'socks5Proxy',
      socks5NetWork: 'socks5NetWork',
      uploadLimitSpeed: 'uploadLimitSpeed',
      listener: 'listener',
    };
  }

  static types(): { [key: string]: any } {
    return {
      autoretry: 'boolean',
      ignoreSSL: 'boolean',
      maxAttempts: 'number',
      backoffPolicy: 'string',
      backoffPeriod: 'number',
      readTimeout: 'number',
      connectTimeout: 'number',
      localAddr: 'string',
      httpProxy: 'string',
      httpsProxy: 'string',
      noProxy: 'string',
      maxIdleConns: 'number',
      socks5Proxy: 'string',
      socks5NetWork: 'string',
      uploadLimitSpeed: 'number',
      listener: 'any',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}


export default class Client {

  static getErrMessage(msg: string): { [key: string]: any } {
    let body: { [key: string]: any } = parseXML(msg);
    return body.Error || {};
  }

  static toMeta(val: { [key: string]: any }, prefix: string): { [key: string]: string } {
    let ret: { [key: string]: string } = {};
    if (!val) {
      return ret;
    }
    Object.keys(val).forEach((key) => {
      if (typeof val[key] === 'undefined' || val[key] == null) {
        val[key] = '';
      }
      if (!key.startsWith(prefix)) {
        ret[prefix + key] = val[key].toString();
        return;
      }
      ret[key] = val[key].toString();
    });
    return ret;
  }

  static parseMeta(val: { [key: string]: any }, prefix: string): { [key: string]: string } {
    let ret: { [key: string]: string } = {};
    if (!val) {
      return ret;
    }
    Object.keys(val).forEach((key) => {
      if (key.startsWith(prefix)) {
        ret[key.replace(prefix, '')] = val[key];
        return;
      }
      ret[key] = val[key];
    });
    return ret;
  }

  static getContentType(fileName: string): string {
    return getType(fileName) || 'text/plain';
  }

  static getContentMD5(body: string, isEnableMD5: boolean): string {
    return kitx.md5(body, 'hex');
  }

  static encode(val: string, encodeType: string): string {
    if (!val) {
      return '';
    }
    let strs = val.split('/');
    let str = strs[strs.length - 1];
    switch (encodeType) {
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

  static getUserAgent(val: string): string {
    if (val && val.length) {
      return DEFAULT_AGENT + ' ' + val;
    }
    return DEFAULT_AGENT;
  }

  static getHost(bucketName: string, regionId: string, endpoint: string, hostModel: string): string {
    if (!regionId || !regionId.length) {
      regionId = `cn-hangzhou`;
    }

    if (!endpoint || !endpoint.length) {
      endpoint = `oss-${regionId}.aliyuncs.com`;
    }

    if (!bucketName || !bucketName.length) {
      return endpoint;
    }

    let host: string = null;
    if (hostModel === 'ip') {
      host = `${endpoint}/${bucketName}`;
    } else if (hostModel === 'cname') {
      host = endpoint;
    } else {
      host = `${bucketName}.${endpoint}`;
    }

    return host;
  }

  static inject(body: Readable, res: { [key: string]: string }): Readable {
    let shasum = createHash('md5');
    let crc64 = new Crc64();
    body.on('data', function (chunk: Buffer) {
      shasum.update(chunk);
      crc64.update(chunk);
    });
    body.on('end', function () {
      res['md5'] = shasum.digest('base64');
      res['crc'] = crc64.sum();
    });
    body.pause();
    return body;
  }

  static getSignature(request: $tea.Request, bucketName: string, accessKeySecret: string, signatureVersion: string, addtionalHeaders?: string[]): string {
    let result;
    if (signatureVersion.toUpperCase() === 'V2') {
      result = getSignatureV2(request, bucketName, accessKeySecret, addtionalHeaders);
    } else {
      result = getSignatureV1(request, bucketName, accessKeySecret);
    }
    return result.signature;
  }

  static decode(val: string, decodeType: string): string {
    if (decodeType == 'Base64Decode') {
      return base64Decode(val)
    } else if (decodeType == 'UrlDecode') {
      return decodeURIComponent(val)
    }
    return val
  }

}
