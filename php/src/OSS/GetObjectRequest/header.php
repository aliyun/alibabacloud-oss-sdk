<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS\GetObjectRequest;

use AlibabaCloud\Tea\Model;

class header extends Model
{
    public $responseContentType;

    public $responseContentLanguage;

    public $responseExpires;

    public $responseCacheControl;

    public $responseContentDisposition;

    public $responseContentEncoding;

    public $range;

    public $ifModifiedSince;

    public $ifUnmodifiedSince;

    public $ifMatch;

    public $ifNoneMatch;

    public $acceptEncoding;
    protected $_name = [
        'responseContentType'        => 'response-content-type',
        'responseContentLanguage'    => 'response-content-language',
        'responseExpires'            => 'response-expires',
        'responseCacheControl'       => 'response-cache-control',
        'responseContentDisposition' => 'response-content-disposition',
        'responseContentEncoding'    => 'response-content-encoding',
        'range'                      => 'Range',
        'ifModifiedSince'            => 'If-Modified-Since',
        'ifUnmodifiedSince'          => 'If-Unmodified-Since',
        'ifMatch'                    => 'If-Match',
        'ifNoneMatch'                => 'If-None-Match',
        'acceptEncoding'             => 'Accept-Encoding',
    ];
}
