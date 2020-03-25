<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS\CopyObjectRequest;

use AlibabaCloud\Tea\Model;

class header extends Model
{
    public $copySource;

    public $copySourceIfMatch;

    public $copySourceIfNoneMatch;

    public $copySourceIfUnmodifiedSince;

    public $copySourceIfModifiedSince;

    public $metadataDirective;

    public $serverSideEncryption;

    public $serverSideEncryptionKeyId;

    public $objectAcl;

    public $storageClass;

    public $tagging;

    public $taggingDirective;
    protected $_name = [
        'copySource'                  => 'x-oss-copy-source',
        'copySourceIfMatch'           => 'x-oss-copy-source-if-match',
        'copySourceIfNoneMatch'       => 'x-oss-copy-source-if-none-match',
        'copySourceIfUnmodifiedSince' => 'x-oss-copy-source-if-unmodified-since',
        'copySourceIfModifiedSince'   => 'x-oss-copy-source-if-modified-since',
        'metadataDirective'           => 'x-oss-metadata-directive',
        'serverSideEncryption'        => 'x-oss-server-side-encryption',
        'serverSideEncryptionKeyId'   => 'x-oss-server-side-encryption-key-id',
        'objectAcl'                   => 'x-oss-object-acl',
        'storageClass'                => 'x-oss-storage-class',
        'tagging'                     => 'x-oss-tagging',
        'taggingDirective'            => 'x-oss-tagging-directive',
    ];
}
