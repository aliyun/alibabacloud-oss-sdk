<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS;

use AlibabaCloud\Tea\Model;

class GetObjectMetaResponse extends Model
{
    public $requestId;

    public $eTag;

    public $contentLength;

    public $lastModified;
    protected $_name = [
        'requestId'     => 'x-oss-request-id',
        'eTag'          => 'etag',
        'contentLength' => 'content-length',
        'lastModified'  => 'last-modified',
    ];
}
