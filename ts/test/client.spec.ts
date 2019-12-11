'use strict';

import Client, { Config, GetBucketRequest, RuntimeObject, PutObjectRequest, GetObjectRequest } from "../src/client";
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
            request.bucketName = "sdk-oss-test";
            let runtime = new RuntimeObject({});
            let response = await client.getBucket(request, runtime);
            assert.strictEqual(response.requestId.length, 24);
            assert.ok(response.listBucketResult);
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
            let request = new PutObjectRequest({});
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