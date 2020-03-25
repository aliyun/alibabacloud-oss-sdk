<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS;

use AlibabaCloud\Tea\Model;

class AppendObjectResponse extends Model
{
    public $requestId;

    public $nextAppendPosition;

    public $hashCrc64ecma;
    protected $_name = [
        'requestId'          => 'x-oss-request-id',
        'nextAppendPosition' => 'x-oss-next-append-position',
        'hashCrc64ecma'      => 'x-oss-hash-crc64ecma',
    ];
}
