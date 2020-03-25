<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS;

use AlibabaCloud\Tea\Model;

class HeadObjectResponse extends Model
{
    public $requestId;

    public $userMeta;

    public $serverSideEncryption;

    public $serverSideEncryptionKeyId;

    public $storageClass;

    public $objectType;

    public $nextAppendPosition;

    public $hashCrc64ecma;

    public $expiration;

    public $restore;

    public $processStatus;

    public $requestCharged;

    public $contentMd5;

    public $lastModified;

    public $accessControlAllowOrigin;

    public $accessControlAllowMethods;

    public $accessControlMaxAge;

    public $accessControlAllowHeaders;

    public $accessControlExposeHeaders;

    public $taggingCount;
    protected $_name = [
        'requestId'                  => 'x-oss-request-id',
        'userMeta'                   => 'usermeta',
        'serverSideEncryption'       => 'x-oss-server-side-encryption',
        'serverSideEncryptionKeyId'  => 'x-oss-server-side-encryption-key-id',
        'storageClass'               => 'x-oss-storage-class',
        'objectType'                 => 'x-oss-object-type',
        'nextAppendPosition'         => 'x-oss-next-append-position',
        'hashCrc64ecma'              => 'x-oss-hash-crc64ecma',
        'expiration'                 => 'x-oss-expiration',
        'restore'                    => 'x-oss-restore',
        'processStatus'              => 'x-oss-process-status',
        'requestCharged'             => 'x-oss-request-charged',
        'contentMd5'                 => 'content-md5',
        'lastModified'               => 'last-modified',
        'accessControlAllowOrigin'   => 'access-control-allow-origin',
        'accessControlAllowMethods'  => 'access-control-allow-methods',
        'accessControlMaxAge'        => 'access-control-max-age',
        'accessControlAllowHeaders'  => 'access-control-allow-headers',
        'accessControlExposeHeaders' => 'access-control-expose-headers',
        'taggingCount'               => 'x-oss-tagging-count',
    ];
}
