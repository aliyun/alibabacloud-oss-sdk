<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS;

use AlibabaCloud\Tea\Model;

class PutObjectResponse extends Model
{
    public $requestId;

    public $hashCrc64ecma;

    public $serverTime;

    public $bucketVersion;
    protected $_name = [
        'requestId'     => 'x-oss-request-id',
        'hashCrc64ecma' => 'x-oss-hash-crc64ecma',
        'serverTime'    => 'x-oss-server-time',
        'bucketVersion' => 'x-oss-bucket-version',
    ];
}
