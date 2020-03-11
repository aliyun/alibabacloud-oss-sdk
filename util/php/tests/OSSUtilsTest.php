<?php

namespace AlibabaCloud\Tea\OSSUtils\Tests;

use AlibabaCloud\Tea\OSSUtils\OSSUtils;
use AlibabaCloud\Tea\Request;
use PHPUnit\Framework\TestCase;

/**
 * @internal
 * @coversNothing
 */
class OSSUtilsTest extends TestCase
{
    public function testGetErrmessage()
    {
        $message = "<?xml version='1.0' encoding='UTF-8'?><Error><Code>401</Code></Error>";
        $res     = OSSUtils::getErrMessage($message);
        $this->assertEquals('401', $res['Code']);
    }

    public function testToMeta()
    {
        $map = [
            'size'        => '1',
            'test.key.id' => '9527',
        ];
        $res = OSSUtils::toMeta($map, 'test.key.');
        $this->assertEquals([
            'test.key.size' => '1',
            'test.key.id'   => '9527',
        ], $res);
    }

    public function testParseMeta()
    {
        $map = [
            'size'        => '1',
            'test.key.id' => '9527',
        ];
        $res = OSSUtils::parseMeta($map, 'test.key.');
        $this->assertEquals([
            'size' => '1',
            'id'   => '9527',
        ], $res);
    }

    public function testGetContentType()
    {
        $this->assertEquals('image/webp', OSSUtils::getContentType('test.webp'));
        $this->assertEquals('audio/mpeg', OSSUtils::getContentType('test.mp3'));
    }

    public function testGetContentMD5()
    {
        $this->assertEquals('CY9rzUYh03PK3k6DJie09g==', OSSUtils::getContentMD5('test', true));
    }

    public function testEncode()
    {
        $value = 'test/encode/h%f';
        $this->assertEquals($value, OSSUtils::encode($value, null));
        $this->assertEquals($value, OSSUtils::encode($value, ''));
        $this->assertEquals('test/encode/aCVm', OSSUtils::encode($value, 'Base64'));
        $this->assertEquals('test/encode/h%25f', OSSUtils::encode($value, 'UrlEncode'));
    }

    public function testGetUserAgent()
    {
        $userAgent = 'Custom UserAgent';
        $res       = OSSUtils::getUserAgent($userAgent);
        $this->assertTrue(false !== strpos($res, $userAgent));
    }

    public function testGetHost()
    {
        $host = OSSUtils::getHost(null, null, null, null);
        $this->assertEquals('oss-cn-hangzhou.aliyuncs.com', $host);

        $host = OSSUtils::getHost('testBucket', 'region', 'endpoint', 'ip');
        $this->assertEquals('endpoint/testBucket', $host);

        $host = OSSUtils::getHost('testBucket', 'region', 'endpoint', 'cname');
        $this->assertEquals('endpoint', $host);

        $host = OSSUtils::getHost('testBucket', 'region', 'endpoint', 'test');
        $this->assertEquals('testBucket.endpoint', $host);
    }

    public function testInject()
    {
        $stream       = fopen('data://text/plain;base64,' . base64_encode('test'), 'r+');
        $verifyStream = OSSUtils::inject($stream, $res);
        $verifyStream->read(4);
        $verifyStream->getVerify();
        $this->assertEquals('CY9rzUYh03PK3k6DJie09g==', $res['md5']);
        $this->assertEquals('18020588380933092773', $res['crc']);
    }

    public function testGetSignatureV1()
    {
        $request           = new Request();
        $request->pathname = '';
        $request->method   = 'GET';
        $request->headers  = [
            'x-oss-test'   => 'test',
            'content-type' => 'type',
            'content-md5'  => 'md5',
        ];
        $request->query    = [
            'testQuery'     => 'testQuery',
            'querykey'      => 'queryValue',
            'x-oss-process' => 'value',
        ];

        $sign = OSSUtils::getSignature($request, 'test', 'ak', 'sk', 'v1', null);
        $this->assertEquals('OSS ak:q9lSDGVH1VmpjMTGSwUZn3tg3J4=', $sign);
    }

    public function testGetSignatureV2()
    {
        $request           = new Request();
        $request->method   = 'GET';
        $request->pathname = 'test?aa';
        $request->headers  = [
            'x-oss-test'   => 'test',
            'content-type' => 'type',
            'content-md5'  => 'md5',
        ];
        $request->query    = [
            'testQuery'  => 'testQuery',
            'querykey'   => 'queryValue',
            'x-oss-test' => 'test',
        ];
        $signature         = OSSUtils::getSignature(
            $request,
            'test',
            'accessKeyId',
            'sk',
            'v2',
            ['querykey']
        );
        $this->assertEquals('OSS2 AccessKeyId:accessKeyId,AdditionalHeaders:querykey,Signature:NTrErwnblTk2y8h/NJKCcPCr73iRTfcl99PEc1fCgZY=', $signature);
    }

    public function testDecode()
    {
        $this->assertEquals('h%f', OSSUtils::decode('aCVm', 'Base64Decode'));
        $this->assertEquals('h%f', OSSUtils::decode('h%25f', 'UrlDecode'));
    }
}
