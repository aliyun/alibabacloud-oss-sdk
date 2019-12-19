'use strict';

import Client, { 
    PutBucketRefererRequestBodyRefererConfigurationRefererList,
    PutBucketRefererRequestBodyRefererConfiguration,
    PutBucketRefererRequestBody,
    PutBucketRefererRequest,
    GetBucketRefererRequest,
    Config, 
    GetBucketRequest, 
    RuntimeObject, 
    PutObjectRequest, 
    PutObjectRequestHeader, 
    GetObjectRequest } from "../src/client";
import 'mocha';
import assert from 'assert';
import { Readable } from "stream";

function read(readable: Readable): Promise<Buffer> {
    return new Promise(function (resolve, reject) {
        let chunks = [];
        readable.on('data', function (chunk) {
            chunks.push(chunk);
        });
        readable.on('end', function () {
            resolve(Buffer.concat(chunks));
        });
        readable.on('error', reject);
    });
}

export class BytesReadable extends Readable {
    value: Buffer

    constructor(value: string | Buffer) {
        super();
        if (typeof value === 'string') {
            this.value = Buffer.from(value);
        } else if (Buffer.isBuffer(value)) {
            this.value = value;
        }
    }

    _read() {
        this.push(this.value);
        this.push(null);
    }
}

const BUCKET_NAME = "sdk-oss-test";

describe('OSS Client', function () {
    describe('getHost', function () {
        it('should ok', async function () {
            let config = new Config({
                accessKeyId: 'fake accesskey id',
                accessKeySecret: 'fake accesskey secret',
            });
            let client = new Client(config);
            assert.strictEqual(client.getHost(BUCKET_NAME), 'sdk-oss-test.oss-cn-hangzhou.aliyuncs.com');
            assert.strictEqual(client.getHost(undefined), 'oss-cn-hangzhou.aliyuncs.com');
        });

        it('ip mode should ok', async function () {
            let config = new Config({
                accessKeyId: 'fake accesskey id',
                accessKeySecret: 'fake accesskey secret',
            });
            config.hostModel = 'ip';
            let client = new Client(config);
            assert.strictEqual(client.getHost('sdk-oss-test'), 'oss-cn-hangzhou.aliyuncs.com/sdk-oss-test');
        });

        it('cname mode should ok', async function () {
            let config = new Config({
                accessKeyId: 'fake accesskey id',
                accessKeySecret: 'fake accesskey secret',
            });
            config.hostModel = 'cname';
            let client = new Client(config);
            assert.strictEqual(client.getHost('sdk-oss-test'), 'oss-cn-hangzhou.aliyuncs.com');
        });
    });

    describe('Bucket', function () {
        let config = new Config({
            accessKeyId: process.env.ACCESS_KEY_ID,
            accessKeySecret: process.env.ACCESS_KEY_SECRET,
        });
        let client = new Client(config);

        it('getBucketInfo should ok', async function () {
            let request = new GetBucketRequest({});
            request.bucketName = BUCKET_NAME;
            let runtime = new RuntimeObject({});
            let response = await client.getBucket(request, runtime);
            assert.strictEqual(response.requestId.length, 24);
            assert.ok(response.listBucketResult);
        });

        it('PutBucketReferer should ok', async function () {
            let refererList = new PutBucketRefererRequestBodyRefererConfigurationRefererList({
                referer: ['oss sdk']
            });
            let conf = new PutBucketRefererRequestBodyRefererConfiguration({
                allowEmptyReferer: true,
                refererList
            });
            let body = new PutBucketRefererRequestBody({
                refererConfiguration: conf
            });
            let request = new PutBucketRefererRequest({
                bucketName: BUCKET_NAME,
                body
            });
            let runtime = new RuntimeObject({});
            let response = await client.putBucketReferer(request, runtime);
            assert.strictEqual(response.requestId.length, 24);
        });

        it('getBucketReferer should ok', async function () {
            let request = new GetBucketRefererRequest({
                bucketName: BUCKET_NAME
            });
            let runtime = new RuntimeObject({});
            let response = await client.getBucketReferer(request, runtime);
            assert.strictEqual(response.requestId.length, 24);
            assert.ok(response.refererConfiguration.allowEmptyReferer);
        });
    });

    describe('Object', function () {
        let config = new Config({
            accessKeyId: process.env.ACCESS_KEY_ID,
            accessKeySecret: process.env.ACCESS_KEY_SECRET,
        });
        let client = new Client(config);

        it('putObject/getObject should ok', async function () {
            this.timeout(10000);
            const objectName = "test.txt";
            const header = new PutObjectRequestHeader({
                storageClass: 'Standard'
            });
            let request = new PutObjectRequest({
                header
            });
            request.bucketName = BUCKET_NAME;
            request.objectName = objectName;
            let content = "just for test";
            request.body = new BytesReadable(content);
            let runtime = new RuntimeObject({});
            let response = await client.putObject(request, runtime);
            assert.strictEqual(response.requestId.length, 24);
            let getObjectRequest = new GetObjectRequest({});
            getObjectRequest.bucketName = BUCKET_NAME;
            getObjectRequest.objectName = objectName;
            let res = await client.getObject(getObjectRequest, runtime);
            let buff = await read(res.body);
            assert.strictEqual(buff.toString(), content);
        });
    });
});