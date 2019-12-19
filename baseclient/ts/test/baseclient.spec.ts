'use strict';

import BaseClient from "../src/baseclient";
import * as $tea from "@alicloud/tea-typescript";
import { createServer, Server } from 'http';
import { Readable } from 'stream';
import { platform, arch } from 'os';
import { request } from 'httpx';
import 'mocha';
import assert from 'assert';

describe('base client', function () {
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
      if(req.method == 'POST'){
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

  it('new client should ok', async function () {
    const config = {
      endpoint: 'aliyuncs.com',
      protocol: 'http',
      regionId: 'zhangbei',
      isEnableMD5: true,
      isEnableCrc: true,
      accessKeySecret: 'accessKeySecret',
      accessKeyId: 'accessKeyId',
      type: 'access_key',
    };
    const client = new BaseClient(config);
    assert.strictEqual(client._protocol, config.protocol);
    assert.strictEqual(client._endpoint, config.endpoint);
    assert.strictEqual(client._regionId, config.regionId);
    assert.strictEqual(client._isEnableMD5, config.isEnableMD5);
    assert.strictEqual(client._isEnableCrc, config.isEnableCrc);
    let accessKeyId = await client._getAccessKeyID();
    let accessKeySecret = await client._getAccessKeySecret();
    assert.strictEqual(accessKeyId, config.accessKeyId);
    assert.strictEqual(accessKeySecret, config.accessKeySecret);
  });

  it('_addAddtionalHeaders  and _getAddtionalHeaders  should ok', async function () {
    const client = new BaseClient({
      accessKeySecret:'accessKeySecret',
      accessKeyId: 'accessKeyId',
    });
    client._addAddtionalHeaders('test');
    const headers = client._getAddtionalHeaders();
    assert.strictEqual(headers[0], 'test');
  });

  it('_setAccessKeySecret should ok', async function () {
    const client = new BaseClient({
      accessKeySecret:'accessKeySecret',
      accessKeyId: 'accessKeyId',
     });
    const headers = ['test'];
    client._setAddtionalHeaders(headers);
    assert.strictEqual(await client._getAddtionalHeaders(), headers);
    client._setAddtionalHeaders(undefined);
    assert.strictEqual(await client._getAddtionalHeaders(), headers);
  });


  it('_setSignatureVersion should ok', async function () {
    const client = new BaseClient({
      accessKeySecret:'accessKeySecret',
      accessKeyId: 'accessKeyId',
    });
    client._setSignatureVersion('V2');
    assert.strictEqual(client._signatureVersion, 'v2');
    client._setSignatureVersion(undefined)
    assert.strictEqual(client._signatureVersion, 'v2');
  });

  it('_setHostModel should ok', async function () {
    const client = new BaseClient({
      accessKeySecret:'accessKeySecret',
      accessKeyId: 'accessKeyId',
    });
    client._setHostModel('IP')
    assert.strictEqual(client._hostModel, 'ip');
    client._setHostModel(undefined)
    assert.strictEqual(client._hostModel, 'ip');
  });

  it('_setRegionId should ok', async function () {
    const client = new BaseClient({
      accessKeySecret:'accessKeySecret',
      accessKeyId: 'accessKeyId',
    });
    client._setRegionId('cn-zhangbei')
    assert.strictEqual(client._regionId, 'cn-zhangbei');
    client._setRegionId(undefined)
    assert.strictEqual(client._regionId, 'cn-hangzhou');
  });

  it('_getDate should ok', async function () {
    const client = new BaseClient({
      accessKeySecret:'accessKeySecret',
      accessKeyId: 'accessKeyId',
    });
    assert.strictEqual(client._getDate(), (new Date()).toUTCString());
  }); 

  it('_ifListEmpty should ok', async function () {
    const client = new BaseClient({
      accessKeySecret: 'accessKeySecret',
      accessKeyId: 'accessKeyId',
    });
    assert.strictEqual(client._ifListEmpty(['test1', 'test2']), false);
    assert.strictEqual(client._ifListEmpty([]), true);
    assert.strictEqual(client._ifListEmpty(undefined), true);
  });

  it('_listToString should ok', async function () {
    const client = new BaseClient({
      accessKeySecret: 'accessKeySecret',
      accessKeyId: 'accessKeyId',
    });
    assert.strictEqual(client._listToString(['test1','test2'],'/'), 'test1/test2');
  });

  it('_getSignatureV1 should ok', async function () {
    const client = new BaseClient({
      accessKeySecret: 'accessKeySecret',
      accessKeyId: 'accessKeyId'
    });
    let req = new $tea.Request();
    req.method = 'GET';
    req.headers['date'] = 'Wed, 11 Dec 2019 10:33:08 GMT';
    req.headers['x-oss-test'] = 'test';
    req.pathname = '/';
    req.query = {
      location: 'hangzhou',
    };
    let sign = client._getSignatureV1(req, 'sdk-oss-test', 'accessKeySecret');
    assert.strictEqual(sign, '6CXQEydyX4SlqhgI3WK8NZwuSNs=');
  });

  it('_getSignatureV2 should ok', async function () {
    const client = new BaseClient({
      accessKeySecret: 'accessKeySecret',
      accessKeyId: 'accessKeyId'
    });
    let req = new $tea.Request();
    req.method = 'GET';
    req.headers['date'] = 'Wed, 11 Dec 2019 10:33:08 GMT';
    req.headers['x-oss-test'] = 'test';
    req.headers['test'] = 'test';
    req.query = {
      key1: 'string',
      key2: undefined,
    };
    req.pathname = '/?putObject';
    let sign = client._getSignatureV2(req, 'sdk-oss-test', 'accessKeySecret', ['test']);
    assert.strictEqual(sign, '3TKXBGVJwa6szBjUDsy453upQ40BN5198kLeZ9ZgET0=');
  });

  it('_xmlCast should ok', async function () {
    const client = new BaseClient({
      accessKeySecret:'accessKeySecret',
      accessKeyId: 'accessKeyId',
    });
    const data: { [key: string]: any } = {
      boolean: false,
      boolStr: 'true',
      number: 1,
      NaN: undefined,
      string: 'string',
      array: ['string1', 'string2'],
      notArray: 'string',
      emptyArray: undefined,
      classArray: [{
        string: 'string',
      }, {
        string: 'string'
      }],
      classMap: '',
      map: {
        string: 'string',
      }
    };

    class TestSubModel extends $tea.Model { 
      string: string;
      static names(): { [key: string]: string } {
        return {
          string: 'string',
        };
      }

      static types(): { [key: string]: any } {
        return {
          string: 'string',
        };
      }

      constructor(map: { [key: string]: any }) {
        super(map);
      }
    }

    class TestModel extends $tea.Model {
      boolean: boolean;
      boolStr: boolean;
      string: string;
      number: number;
      array: string[];
      emptyArray: string[];
      notArray: string[];
      map: { [key: string]: any };
      classArray: TestSubModel[];
      classMap: TestSubModel;
      static names(): { [key: string]: string } {
        return {
          boolean: 'boolean',
          boolStr: 'boolStr',
          string: 'string',
          number: 'number',
          array: 'array',
          emptyArray: 'emptyArray',
          notArray: 'notArray',
          map: 'map',
          classArray: 'classArray',
          classMap: 'classMap',
        };
      }

      static types(): { [key: string]: any } {
        return {
          boolean: 'boolean',
          boolStr: 'boolean',
          string: 'string',
          number: 'number',
          array: { type: 'array', itemType: 'string' },
          emptyArray: { type: 'array', itemType: 'string' },
          notArray: { type: 'array', itemType: 'string' },
          map: 'map',
          classArray: { type: 'array', itemType: TestSubModel},
          classMap: TestSubModel,
        };
      }

      constructor(map: { [key: string]: any }) {
        super(map);
      }
    }
    
    assert.deepStrictEqual(client._xmlCast(data, TestModel), {
      "boolean": false,
      "boolStr": true,
      "number": 1,
      "string": 'string',
      "array": ['string1', 'string2'],
      "classArray": [{
        "string": 'string',
      }, {
        "string": 'string'
      }],
      "notArray": ['string'],
      "emptyArray": [],
      "classMap": {
        "string": ''
      },
      "map": {
        "string": 'string',
      }
    });
  });

  it('_parseXml should ok', async function () {
    class GetBucketAclResponseAccessControlPolicyAccessControlList extends $tea.Model {
      grant: string;
      static names(): { [key: string]: string } {
        return {
          grant: 'Grant',
        };
      }

      static types(): { [key: string]: any } {
        return {
          grant: 'string',
        };
      }

      constructor(map: { [key: string]: any }) {
        super(map);
      }

    }

    class GetBucketAclResponseAccessControlPolicyOwner extends $tea.Model {
      iD: string;
      displayName: string;
      static names(): { [key: string]: string } {
        return {
          iD: 'ID',
          displayName: 'DisplayName',
        };
      }

      static types(): { [key: string]: any } {
        return {
          iD: 'string',
          displayName: 'string',
        };
      }

      constructor(map: { [key: string]: any }) {
        super(map);
      }

    }

    class GetBucketAclResponseAccessControlPolicy extends $tea.Model {
      owner: GetBucketAclResponseAccessControlPolicyOwner;
      accessControlList: GetBucketAclResponseAccessControlPolicyAccessControlList;
      static names(): { [key: string]: string } {
        return {
          owner: 'Owner',
          accessControlList: 'AccessControlList',
        };
      }

      static types(): { [key: string]: any } {
        return {
          owner: GetBucketAclResponseAccessControlPolicyOwner,
          accessControlList: GetBucketAclResponseAccessControlPolicyAccessControlList,
        };
      }

      constructor(map: { [key: string]: any }) {
        super(map);
      }

    }

    class GetBucketAclResponse extends $tea.Model {
      accessControlPolicy: GetBucketAclResponseAccessControlPolicy;
      static names(): { [key: string]: string } {
        return {
          accessControlPolicy: 'root',
        };
      }

      static types(): { [key: string]: any } {
        return {
          accessControlPolicy: GetBucketAclResponseAccessControlPolicy,
        };
      }

      constructor(map: { [key: string]: any }) {
        super(map);
      }
    }

    const client = new BaseClient({
      accessKeySecret:'accessKeySecret',
      accessKeyId: 'accessKeyId',
    });
    const data = {
      root: {
        Owner: { ID: '1325847523475998', DisplayName: '1325847523475998' },
        AccessControlList: { Grant: 'public-read' },
      },
    };
    assert.deepStrictEqual(client._parseXml(testXml, GetBucketAclResponse), data);
    try {
      client._parseXml('ddsfadf', GetBucketAclResponse)
    } catch (err) {
      assert.ok(err);
      return;
    }
    assert.ok(false);
    
  });

  it('_default should ok', async function () {
    const client = new BaseClient({
      accessKeySecret:'accessKeySecret',
      accessKeyId: 'accessKeyId',
    });
    assert.strictEqual(client._default('sdk-oss-test', 'sdk-oss-test2'), 'sdk-oss-test');
    assert.strictEqual(client._default(undefined, 'sdk-oss-test2'), 'sdk-oss-test2');
  });

  it('_defaultNumber should ok', async function () {
    const client = new BaseClient({
      accessKeySecret:'accessKeySecret',
      accessKeyId: 'accessKeyId',
    });
    assert.strictEqual(client._defaultNumber(2019, 2020), 2019);
    assert.strictEqual(client._defaultNumber(undefined, 2020), 2020);
  });

  it('_isFail should ok', async function () {
    const client = new BaseClient({
      accessKeySecret:'accessKeySecret',
      accessKeyId: 'accessKeyId',
    });
    let res = await request('http://127.0.0.1:8848', { method: 'GET' });
    let teaRes = new $tea.Response(res);
    assert.strictEqual(client._isFail(teaRes), false);
    teaRes.statusCode = 404;
    assert.strictEqual(client._isFail(teaRes), true);
    assert.strictEqual(client._isFail(null), true);
  });

  it('_toQuery should ok', async function () {
    const client = new BaseClient({
      accessKeySecret:'accessKeySecret',
      accessKeyId: 'accessKeyId',
    });

    const data: { [key: string]: any } = {
      val1: 'string',
      val2: undefined,
      val3: null,
      val4: 1,
      val5: true
    };
    assert.deepStrictEqual(client._toQuery(data), {
      val1: 'string',
      val2: '',
      val3: '',
      val4: '1',
      val5: 'true'
    });
    assert.deepStrictEqual(client._toQuery(undefined), {});
  });

  it('_toMeta should ok', async function () {
    const client = new BaseClient({
      accessKeySecret:'accessKeySecret',
      accessKeyId: 'accessKeyId',
    });
    const data: { [key: string]: any } = {
      number: 1,
      boolean: true,
      string: '1234',
      value: undefined,
      'x-test': 'string',
    };
    assert.deepStrictEqual(client._toMeta(data,'x-'), {
      'x-number': '1',
      'x-boolean': 'true',
      'x-string': '1234',
      'x-value': '',
      'x-test': 'string',
    });
    assert.deepStrictEqual(client._toMeta(null, 'x-'), {});
  });

  it('_parseMeta should ok', async function () {
    const client = new BaseClient({
      accessKeySecret:'accessKeySecret',
      accessKeyId: 'accessKeyId',
    });
    const data = {
      'x-number': '1',
      "x-boolean": 'true',
      "x-string": '1234',
      'value': 'string',
    };
    assert.deepStrictEqual(client._parseMeta(data, 'x-'), {
      number: '1',
      boolean: 'true',
      string: '1234',
      value: 'string',
    });
    assert.deepStrictEqual(client._parseMeta(undefined, 'x-'), {});
  });

  it('_getContentMD5 should ok', async function () {
    let client = new BaseClient({
      accessKeySecret:'accessKeySecret',
      accessKeyId: 'accessKeyId',
    });
    assert.strictEqual(client._getContentMD5('a'), '0cc175b9c0f1b6a831c399e269772661');
  });

  it('_defaultNumber should ok', async function () {
    const client = new BaseClient({
      accessKeySecret:'accessKeySecret',
      accessKeyId: 'accessKeyId',
    });
    assert.strictEqual(client._defaultNumber(undefined, 2019), 2019);
    assert.strictEqual(client._defaultNumber(2020, 2019), 2020);
  });

  it('_getContentType should ok', async function () {
    const client = new BaseClient({
      accessKeySecret:'accessKeySecret',
      accessKeyId: 'accessKeyId',
    });
    assert.strictEqual(client._getContentType('test.xml'), 'application/xml');
    assert.strictEqual(client._getContentType('test'), 'text/plain');
  });

  it('_isNotCrcMatched should ok', async function () {
    let client = new BaseClient({
      accessKeySecret:'accessKeySecret',
      accessKeyId: 'accessKeyId',
    });
    assert.strictEqual(client._isNotCrcMatched(Buffer.from('crc'), 'crc'), false);
    client = new BaseClient({
      isEnableCrc: true,
      accessKeySecret:'accessKeySecret',
      accessKeyId: 'accessKeyId',
    });
    assert.strictEqual(client._isNotCrcMatched(Buffer.from('crc'), 'crc'), false);
    assert.strictEqual(client._isNotCrcMatched(Buffer.from('crc'), 'crc32'), true);
  });

  it('_encode should ok', async function () {
    const client = new BaseClient({
      accessKeySecret:'accessKeySecret',
      accessKeyId: 'accessKeyId',
    });
    assert.strictEqual(client._encode(undefined, 'UrlEncode'), '');
    assert.strictEqual(client._encode('&2b', 'UrlEncode'), '%262b');
    assert.strictEqual(client._encode('path/&2b', 'UrlEncode'), 'path/%262b');
    assert.strictEqual(client._encode('&2b', 'Base64'), 'JjJi');
    assert.strictEqual(client._encode('path/&2b', 'Base64'), 'path/JjJi');
  });

  it('_base64Decode should ok', async function () {
    const client = new BaseClient({
      accessKeySecret:'accessKeySecret',
      accessKeyId: 'accessKeyId',
    });
    assert.strictEqual(client._base64Decode(undefined), '');
    assert.strictEqual(client._base64Decode('JjJi'), '&2b');
    assert.strictEqual(client._base64Decode('path/JjJi'), 'path/&2b');
  });

  it('_getCrc should ok', async function () {
    const client = new BaseClient({
      accessKeySecret:'accessKeySecret',
      accessKeyId: 'accessKeyId',
    });
    try{
      client._getCrc(undefined,undefined,undefined,undefined)
    } catch (err) {
      assert.ok(err);
      return;
    }
    assert.ok(false);
  });

  it('_getRespCrc should ok', async function () {
    const client = new BaseClient({
      accessKeySecret:'accessKeySecret',
      accessKeyId: 'accessKeyId',
    });
    try{
      client._getRespCrc(undefined,undefined,undefined,undefined)
    }catch(err){
      assert.ok(err);
      return;
    }
    assert.ok(false);
  });

  it('_getUserAgent should ok', async function () {
    const client = new BaseClient({
      accessKeySecret:'accessKeySecret',
      accessKeyId: 'accessKeyId',
    });
    assert.strictEqual(client._getUserAgent(), `AlibabaCloud (${platform()}; ${arch()}) Node.js/${process.version} Core/1.0.1`);
    assert.strictEqual(client._getUserAgent('2019'), `AlibabaCloud (${platform()}; ${arch()}) Node.js/${process.version} Core/1.0.1 2019`);
  });

  it('_isUploadSpeedLimit should ok', async function () {
    const client = new BaseClient({
      accessKeySecret:'accessKeySecret',
      accessKeyId: 'accessKeyId',
    });
    assert.strictEqual(client._isUploadSpeedLimit(req.body,0), req.body);
    assert.strictEqual(client._isUploadSpeedLimit(req.body, 100), req.body);
  });

  it('_ifRange should ok', async function () {
    const client = new BaseClient({
      accessKeySecret:'accessKeySecret',
      accessKeyId: 'accessKeyId',
    });
    assert.strictEqual(client._ifRange(req.headers), false);
    req.headers['Range'] = 'true';
    assert.strictEqual(client._ifRange(req.headers), true);
  });

  it('_headerCast should ok', async function () {
    const client = new BaseClient({
      accessKeySecret:'accessKeySecret',
      accessKeyId: 'accessKeyId',
    });
    const header = new TestHeader({
      tagging: 'test',
      contentLength: '1024',
      storageClass: 'Standard',
      contentType: 'application/xml',
    })
    assert.deepStrictEqual(client._headerCast(header, TestHeader), {
      "x-oss-tagging": 'test',
      "content-length": '1024',
      "x-oss-storage-class": 'Standard',
      'content-type': 'application/xml'
    });
  });

  it('_toHeader should ok', async function () {
   
    const client = new BaseClient({
      accessKeySecret:'accessKeySecret',
      accessKeyId: 'accessKeyId',
    });
    const header = new TestHeader({
      tagging: null,
      contentLength: undefined,
      storageClass: 'Standard',
      contentType: 'application/xml',
    });
    assert.deepStrictEqual(client._toHeader(header), {
      "x-oss-tagging": '',
      "content-length": '',
      "x-oss-storage-class": 'Standard',
      'content-type': 'application/xml',
    });
    assert.deepStrictEqual(client._toHeader(undefined), {});
    const map:{ [key: string]: any } = {
      "x-oss-tagging": 'test',
      "content-length": 1024,
      "x-oss-storage-class": undefined,
      'content-type': null,
    };
    assert.deepStrictEqual(client._toHeader(map), {
      "x-oss-tagging": 'test',
      "content-length": '1024',
      "x-oss-storage-class": '',
      'content-type': '',
    });
  });
  
  it('_readAsStream should ok', async function () {
    const client = new BaseClient({
      accessKeySecret:'accessKeySecret',
      accessKeyId: 'accessKeyId',
    });
    const res = await request('http://127.0.0.1:8848', { method: 'GET' });
    const teaRes = new $tea.Response(res);
    assert.strictEqual(client._readAsStream(teaRes), res);
  });

  it('_empty should ok', async function () {
    const client = new BaseClient({
      accessKeySecret:'accessKeySecret',
      accessKeyId: 'accessKeyId',
    });
    assert.deepStrictEqual(client._empty(''), true);
    assert.deepStrictEqual(client._empty('hehe'), false);
    assert.deepStrictEqual(client._empty(undefined), true);
  });

  it('_equal should ok', async function () {
    const client = new BaseClient({
      accessKeySecret:'accessKeySecret',
      accessKeyId: 'accessKeyId',
    });
    assert.deepStrictEqual(client._equal('', ''), true);
    assert.deepStrictEqual(client._equal('hehe', 'ip'), false);
    assert.deepStrictEqual(client._equal('hehe', 'hehe'), true);
  });

  it('_getTracker should ok', async function () {
    const client = new BaseClient({
      accessKeySecret:'accessKeySecret',
      accessKeyId: 'accessKeyId',
    });
    try {
      client._getTracker();
    } catch(err) {
      assert.ok(err);
      return;
    }
    assert.ok(false);
  });

  it('_readAsString should ok', async function () {
    const client = new BaseClient({
      accessKeySecret: 'accessKeySecret',
      accessKeyId: 'accessKeyId',
    });
    const res = await request('http://127.0.0.1:8848', { method: 'POST' });
    const teaRes = new $tea.Response(res);
    assert.deepStrictEqual(await client._readAsString(teaRes), errorXml);
  });

  it('_getSecurityToken should ok', async function () {
    const client = new BaseClient({
      accessKeySecret:'accessKeySecret',
      accessKeyId: 'accessKeyId',
      securityToken: 'securityToken',
      type: 'sts',
    });
    assert.strictEqual(await client._getSecurityToken(), 'securityToken');
  });

  it('_getErrMessage should ok', async function () {
    const client = new BaseClient({
      accessKeySecret: 'accessKeySecret',
      accessKeyId: 'accessKeyId',
    });
    const res = await request('http://127.0.0.1:8848', { method: 'POST' });
    const teaRes = new $tea.Response(res);
    const xml = await client._readAsString(teaRes);
    assert.deepStrictEqual(await client._getErrMessage(xml), {
      Code: 'AccessForbidden',
      Message: 'CORSResponse: CORS is not enabled for this bucket.',
      RequestId: '5DECB1F6F3150D373335D8D2',
      HostId: 'sdk-oss-test.oss-cn-hangzhou.aliyuncs.com',
    });
  });

  it('_inject should ok', async function () {
    const client = new BaseClient({
      accessKeySecret:'accessKeySecret',
      accessKeyId: 'accessKeyId',
    });
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
          const str = String(i);
          const buf = Buffer.from(str, 'ascii');
          this.push(buf);
        }
      }
    }
    let ref:{ [key: string]: string } = {};
    let reader:Readable = new Counter();
    reader = client._inject(reader, ref);
    ref = await new Promise((resolve,reject) => {
      reader.resume().on('end',() => {
        resolve(ref);
      });
    });
    assert.deepStrictEqual(ref, {
      md5: 'Jx2gJpEVLI2XLN0ggKcY/g==',
      crc: '1558505285304425618'
    });
  });

  after(() => {
    server.close();
  });
});
