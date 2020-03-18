<?php

namespace AlibabaCloud\SDK\OSS\Tests;

use AlibabaCloud\SDK\OSS\OSS as Client;
use AlibabaCloud\SDK\OSS\OSS\Config;
use AlibabaCloud\SDK\OSS\OSS\PutBucketLifecycleRequest;
use AlibabaCloud\Tea\Exception\TeaUnableRetryError;
use AlibabaCloud\Tea\OSSUtils\OSSUtils\RuntimeOptions;
use PHPUnit\Framework\TestCase;

/**
 * @internal
 * @coversNothing
 */
class OSSClientTest extends TestCase
{
    public function testOssSDkRequest()
    {
        $config  = new Config();
        $runtime = new RuntimeOptions();
        $request = new PutBucketLifecycleRequest();

        $config->type             = 'sts';
        $config->accessKeyId      = $this->getEnv('ACCESS_KEY_ID');
        $config->accessKeySecret  = $this->getEnv('ACCESS_KEY_SECRET');
        $config->securityToken    = $this->getEnv('SECURITY_TOKEN');
        $config->signatureVersion = 'V2';

        $runtime->maxIdleConns = 1;

        $client     = new Client($config);
        $bucketName = 'sdk-oss-test';

        $request->bucketName = $bucketName;
        $expiration          = new PutBucketLifecycleRequest\body\lifecycleConfiguration\rule\expiration();
        $expiration->days    = 1;
        $rule                = new PutBucketLifecycleRequest\body\lifecycleConfiguration\rule();
        $rule->iD            = '1';
        $rule->prefix        = 'Prefix';
        $rule->status        = 'Disabled';
        $rule->expiration    = $expiration;
        $configuration       = new PutBucketLifecycleRequest\body\lifecycleConfiguration();
        $configuration->rule = $rule;
        $body                = new PutBucketLifecycleRequest\body();

        $body->lifecycleConfiguration = $configuration;
        $request->body                = $body;

        $this->expectException(TeaUnableRetryError::class);
        $client->putBucketLifecycle($request, $runtime);
    }

    public function getEnv($name, $default = '')
    {
        $value = getenv($name);
        if (empty($value)) {
            return $default;
        }

        return $value;
    }
}
