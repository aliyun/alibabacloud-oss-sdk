'use strict';

import client, { RuntimeOptions } from "../src/client";
import * as $tea from "@alicloud/tea-typescript";
import { createServer, Server } from 'http';
import { Readable } from 'stream';
import { platform, arch } from 'os';
import { request } from 'httpx';
import 'mocha';
import assert from 'assert';

async function _readAsString(response: $tea.Response): Promise<string> {
  let bytes = await response.readBytes();
  return bytes.toString();
}

describe('client', function () {
  let server: Server;
  const testXml = '<?xml version="1.0" encoding="UTF-8" standalone="yes"?>\n' +
    '<root>\n' +
    '  <Owner>\n' +
    '    <ID>1325847523475998</ID>\n' +
    '    <DisplayName>1325847523475998</DisplayName>\n' +
    '  </Owner>\n' +
    '  <AccessControlList>\n' +
    '    <Grant>public-read</Grant>\n' +
    '  </AccessControlList>\n' +
    '</root>';
  const errorXml = '<Error>\
    <Code>AccessForbidden</Code>\
    <Message>CORSResponse: CORS is not enabled for this bucket.</Message>\
    <RequestId>5DECB1F6F3150D373335D8D2</RequestId>\
    <HostId>sdk-oss-test.oss-cn-hangzhou.aliyuncs.com</HostId>\
  </Error>';
  before((done) => {
    server = createServer((req, res) => {
      res.writeHead(200, { 'Content-Type': 'application/xml' });
      if (req.method == 'POST') {
        res.end(errorXml);
      } else {
        res.end(testXml);
      }
    }).listen(8848, () => {
      done();
    });
  });

  let req = new $tea.Request();

  class TestHeader extends $tea.Model {
    authorization?: string;
    cacheControl?: string;
    contentDisposition?: string;
    contentEncoding?: string;
    contentMD5?: string;
    contentLength?: string;
    eTag?: string;
    expires?: string;
    serverSideEncryption?: string;
    serverSideEncryptionKeyId?: string;
    objectAcl?: string;
    storageClass?: string;
    tagging?: string;
    contentType?: string;
    static names(): { [key: string]: string } {
      return {
        tagging: 'x-oss-tagging',
        contentLength: 'content-length',
        storageClass: 'x-oss-storage-class',
        contentType: 'content-type',
      };
    }

    static types(): { [key: string]: any } {
      return {
        tagging: 'string',
        contentLength: 'string',
        storageClass: 'string',
        contentType: 'string',
      };
    }

    constructor(map: { [key: string]: any }) {
      super(map);
    }
  }


  it('getErrMessage should ok', async function () {
    const res = await request('http://127.0.0.1:8848', { method: 'POST' });
    const teaRes = new $tea.Response(res);
    const xml = await _readAsString(teaRes);
    assert.deepStrictEqual(await client.getErrMessage(xml), {
      Code: 'AccessForbidden',
      Message: 'CORSResponse: CORS is not enabled for this bucket.',
      RequestId: '5DECB1F6F3150D373335D8D2',
      HostId: 'sdk-oss-test.oss-cn-hangzhou.aliyuncs.com',
    });
  });

  it('toMeta should ok', async function () {
    const data: { [key: string]: any } = {
      number: 1,
      boolean: true,
      string: '1234',
      value: undefined,
      'x-test': 'string',
    };
    assert.deepStrictEqual(client.toMeta(data, 'x-'), {
      'x-number': '1',
      'x-boolean': 'true',
      'x-string': '1234',
      'x-value': '',
      'x-test': 'string',
    });
    assert.deepStrictEqual(client.toMeta(null, 'x-'), {});
  });

  it('parseMeta should ok', async function () {
    const data = {
      'x-number': '1',
      "x-boolean": 'true',
      "x-string": '1234',
      'value': 'string',
    };
    assert.deepStrictEqual(client.parseMeta(data, 'x-'), {
      number: '1',
      boolean: 'true',
      string: '1234',
      value: 'string',
    });
    assert.deepStrictEqual(client.parseMeta(undefined, 'x-'), {});
  });

  it('getContentType should ok', async function () {
    assert.strictEqual(client.getContentType('test.xml'), 'application/xml');
    assert.strictEqual(client.getContentType('test'), 'text/plain');
  });
  //
  it('getContentMD5 should ok', async function () {
    assert.strictEqual(client.getContentMD5('a', true), '0cc175b9c0f1b6a831c399e269772661');
  });

  it('encode should ok', async function () {
    assert.strictEqual(client.encode(undefined, 'UrlEncode'), '');
    assert.strictEqual(client.encode('&2b', 'UrlEncode'), '%262b');
    assert.strictEqual(client.encode('path/&2b', 'UrlEncode'), 'path/%262b');
    assert.strictEqual(client.encode('&2b', 'Base64'), 'JjJi');
    assert.strictEqual(client.encode('path/&2b', 'Base64'), 'path/JjJi');
  });

  it('getUserAgent should ok', async function () {
    assert.strictEqual(client.getUserAgent(undefined), `AlibabaCloud (${platform()}; ${arch()}) Node.js/${process.version} Core/1.0.1`);
    assert.strictEqual(client.getUserAgent('2019'), `AlibabaCloud (${platform()}; ${arch()}) Node.js/${process.version} Core/1.0.1 2019`);
  });

  it('getHost should ok', async function () {
    assert.strictEqual(client.getHost('sdk-oss-test', undefined, undefined, undefined), 'sdk-oss-test.oss-cn-hangzhou.aliyuncs.com');
    assert.strictEqual(client.getHost(undefined, undefined, undefined, undefined), 'oss-cn-hangzhou.aliyuncs.com');
    assert.strictEqual(client.getHost('sdk-oss-test', undefined, undefined, 'ip'), 'oss-cn-hangzhou.aliyuncs.com/sdk-oss-test');
    assert.strictEqual(client.getHost('sdk-oss-test', undefined, undefined, 'cname'), 'oss-cn-hangzhou.aliyuncs.com');
  });

  it('inject should ok', async function () {
    class Counter extends Readable {
      _max: number;
      _index: number;
      constructor() {
        super();
        this._max = 1000;
        this._index = 1;
      }

      _read() {
        const i = this._index++;
        if (i > this._max)
          this.push(null);
        else {
          const str = String(i) + 'test test';
          const buf = Buffer.from(str, 'ascii');
          this.push(buf);
        }
      }
    }
    let ref: { [key: string]: string } = {};
    let reader: Readable = new Counter();
    reader = client.inject(reader, ref);
    ref = await new Promise((resolve, reject) => {
      reader.resume().on('end', () => {
        resolve(ref);
      });
    });
    assert.deepStrictEqual(ref, {
      md5: 'VNtOPWYrOOq68/+E0bDeLw==',
      crc: '9572577374999009327'
    });
  });

  it('decode should ok', async function () {
    assert.strictEqual(client.decode("JjJi", "Base64Decode"), '&2b');
    assert.strictEqual(client.decode("path/%262b", "UrlDecode"), 'path/&2b');
    assert.strictEqual("afff", client.decode("afff", null));
  });

  it('getSignature should ok', async function () {
    let req = new $tea.Request();
    req.method = 'GET';
    req.headers['date'] = 'Wed, 11 Dec 2019 10:33:08 GMT';
    req.headers['x-oss-test'] = 'test';
    req.pathname = '/';
    req.query = {
      location: 'hangzhou',
    };
    let sign = client.getSignature(req, 'sdk-oss-test', 'accessKeyId', 'accessKeySecret', 'v1');
    assert.strictEqual(sign, '6CXQEydyX4SlqhgI3WK8NZwuSNs=');

    let req_2 = new $tea.Request();
    req_2.method = 'GET';
    req_2.headers['date'] = 'Wed, 11 Dec 2019 10:33:08 GMT';
    req_2.headers['x-oss-test'] = 'test';
    req_2.headers['test'] = 'test';
    req_2.query = {
      key1: 'string',
      key2: undefined,
    };
    req_2.pathname = '/?putObject';
    let sign_2 = client.getSignature(req_2, 'sdk-oss-test', 'accessKeyId' , 'accessKeySecret', 'v2', ['test']);
    assert.strictEqual(sign_2, '3TKXBGVJwa6szBjUDsy453upQ40BN5198kLeZ9ZgET0=');
  });

  describe('RuntimeOptions', function () {
    it('it should ok', async function () {
      assert.ok(new RuntimeOptions());
      assert.ok(RuntimeOptions.names());
      assert.ok(RuntimeOptions.types());
    });
  });


  after(() => {
    server.close();
  });
});
