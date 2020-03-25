<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS;

use AlibabaCloud\Tea\Model;

class GetObjectResponse extends Model
{
    public $requestId;

    public $objectType;

    public $serverSideEncryption;

    public $taggingCount;

    public $restore;

    public $body;
    protected $_name = [
        'requestId'            => 'x-oss-request-id',
        'objectType'           => 'x-oss-object-type',
        'serverSideEncryption' => 'x-oss-server-side-encryption',
        'taggingCount'         => 'x-oss-tagging-count',
        'restore'              => 'x-oss-restore',
        'body'                 => 'body',
    ];
}
