import * as $tea from '@alicloud/tea-typescript';
import { createHmac } from 'crypto';

const signKeyList = ['location', 'cors', 'objectMeta',
  'uploadId', 'partNumber', 'security-token',
  'position', 'img', 'style', 'styleName',
  'replication', 'replicationProgress',
  'replicationLocation', 'cname', 'qos',
  'startTime', 'endTime', 'symlink',
  'x-oss-process', 'response-content-type',
  'response-content-language', 'response-expires',
  'response-cache-control', 'response-content-disposition',
  'response-content-encoding', 'udf', 'udfName', 'udfImage',
  'udfId', 'udfImageDesc', 'udfApplication',
  'udfApplicationLog', 'restore', 'callback', 'callback-var',
  'policy', 'encryption', 'versions', 'versioning', 'versionId'];


export function getSignatureV1(request: $tea.Request, bucketName: string, accessKeySecret: string): {
  string2sign: string,
  signature: string
} {
  let resource = '/';
  if (bucketName) {
    resource += bucketName;
  }
  resource += request.pathname;
  for (const [key, value] of Object.entries(request.query || {})) {
    if (~signKeyList.indexOf(key) && value) {
      resource += '&' + key + '=' + value;
    }
  }
  let headerKeys = [];
  for (let [key, value] of Object.entries(request.headers || {})) {
    const lowerKey = key.toLocaleLowerCase();
    if (lowerKey.startsWith('x-oss-')) {
      headerKeys.push(key);
    }
  }
  let headers = '';
  headerKeys = headerKeys.sort();
  headerKeys.forEach(key => {
    headers += key.toLocaleLowerCase() + ':' + request.headers[key] + '\n';
  });

  let string2sign = request.method + '\n'
    + (request.headers['content-md5'] || '') + '\n'
    + (request.headers['content-type'] || '') + '\n'
    + request.headers['date'] + '\n'
    + headers
    + resource;

  const hmac = createHmac('sha1', accessKeySecret);
  hmac.update(string2sign);
  const signature = hmac.digest('base64');
  return {
    string2sign,
    signature
  }
};

export function getSignatureV2(request: $tea.Request, bucketName: string, accessKeySecret: string, addtionalHeaders: string[] = []): {
  string2sign: string,
  signature: string
} {
  let resource = '';
  let pathname = '';
  if (bucketName) {
    pathname += '/' + bucketName + request.pathname;
  }
  let queryKeys = Object.keys(request.query || {});
  const [major, minor] = pathname.split('?');
  resource = encodeURIComponent(major);
  if (minor) {
    queryKeys.push(minor);
  }
  queryKeys.sort();
  if (queryKeys.length > 0 && !resource.endsWith('?')) {
    resource += '?';
  }
  queryKeys.forEach((key) => {
    if (!resource.endsWith('?')) {
      resource += '&';
    }
    if (typeof request.query[key] === 'undefined') {
      resource += encodeURIComponent(key);
    } else {
      resource += `${encodeURIComponent(key)}=${encodeURIComponent(request.query[key])}`;
    }
  })
  let addtionalHeaderMap = new Map();
  addtionalHeaders.forEach(header => {
    addtionalHeaderMap.set(header.toLocaleLowerCase(), 1);
  })
  let headerKeys = [];
  for (let [key] of Object.entries(request.headers || {})) {
    const lowerKey = key.toLocaleLowerCase();
    if (addtionalHeaderMap.get(lowerKey)) {
      headerKeys.push(key);
    }
    if (lowerKey.startsWith('x-oss-')) {
      headerKeys.push(key);
    }
  }
  let headers = '';
  headerKeys = headerKeys.sort();
  headerKeys.forEach(key => {
    headers += key.toLocaleLowerCase() + ':' + request.headers[key] + '\n';
  })
  let string2sign = request.method + '\n'
    + (request.headers['content-md5'] || '') + '\n'
    + (request.headers['content-type'] || '') + '\n'
    + request.headers['date'] + '\n'
    + headers
    + addtionalHeaders.join(';') + '\n'
    + resource;
  const hmac = createHmac('sha256', accessKeySecret);
  hmac.update(string2sign);
  let signature = hmac.digest('base64');
  return {
    string2sign,
    signature
  };
}