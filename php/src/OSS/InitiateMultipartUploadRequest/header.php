<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS\InitiateMultipartUploadRequest;

use AlibabaCloud\Tea\Model;

class header extends Model
{
    public $cacheControl;

    public $contentDisposition;

    public $contentEncoding;

    public $expires;

    public $serverSideEncryption;

    public $serverSideEncryptionKeyId;

    public $storageClass;

    public $tagging;

    public $contentType;
    protected $_name = [
        'cacheControl'              => 'Cache-Control',
        'contentDisposition'        => 'Content-Disposition',
        'contentEncoding'           => 'Content-Encoding',
        'expires'                   => 'Expires',
        'serverSideEncryption'      => 'x-oss-server-side-encryption',
        'serverSideEncryptionKeyId' => 'x-oss-server-side-encryption-key-id',
        'storageClass'              => 'x-oss-storage-class',
        'tagging'                   => 'x-oss-tagging',
        'contentType'               => 'content-type',
    ];
}
