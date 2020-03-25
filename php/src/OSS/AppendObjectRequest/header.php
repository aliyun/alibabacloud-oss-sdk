<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS\AppendObjectRequest;

use AlibabaCloud\Tea\Model;

class header extends Model
{
    public $cacheControl;

    public $contentDisposition;

    public $contentEncoding;

    public $contentMD5;

    public $expires;

    public $serverSideEncryption;

    public $objectAcl;

    public $storageClass;

    public $contentType;
    protected $_name = [
        'cacheControl'         => 'Cache-Control',
        'contentDisposition'   => 'Content-Disposition',
        'contentEncoding'      => 'Content-Encoding',
        'contentMD5'           => 'Content-MD5',
        'expires'              => 'Expires',
        'serverSideEncryption' => 'x-oss-server-side-encryption',
        'objectAcl'            => 'x-oss-object-acl',
        'storageClass'         => 'x-oss-storage-class',
        'contentType'          => 'content-type',
    ];
}
