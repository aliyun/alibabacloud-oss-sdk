<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS\PutObjectRequest;

use AlibabaCloud\Tea\Model;

class header extends Model
{
    public $authorization;

    public $cacheControl;

    public $contentDisposition;

    public $contentEncoding;

    public $contentMD5;

    public $contentLength;

    public $eTag;

    public $expires;

    public $serverSideEncryption;

    public $serverSideEncryptionKeyId;

    public $objectAcl;

    public $storageClass;

    public $tagging;

    public $contentType;
    protected $_name = [
        'authorization'             => 'Authorization',
        'cacheControl'              => 'Cache-Control',
        'contentDisposition'        => 'Content-Disposition',
        'contentEncoding'           => 'Content-Encoding',
        'contentMD5'                => 'Content-MD5',
        'contentLength'             => 'Content-Length',
        'eTag'                      => 'CETag',
        'expires'                   => 'Expires',
        'serverSideEncryption'      => 'x-oss-server-side-encryption',
        'serverSideEncryptionKeyId' => 'x-oss-server-side-encryption-key-id',
        'objectAcl'                 => 'x-oss-object-acl',
        'storageClass'              => 'x-oss-storage-class',
        'tagging'                   => 'x-oss-tagging',
        'contentType'               => 'content-type',
    ];
}
