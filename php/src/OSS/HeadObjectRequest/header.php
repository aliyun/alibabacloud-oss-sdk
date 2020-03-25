<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS\HeadObjectRequest;

use AlibabaCloud\Tea\Model;

class header extends Model
{
    public $ifModifiedSince;

    public $ifUnmodifiedSince;

    public $ifMatch;

    public $ifNoneMatch;
    protected $_name = [
        'ifModifiedSince'   => 'If-Modified-Since',
        'ifUnmodifiedSince' => 'If-Unmodified-Since',
        'ifMatch'           => 'If-Match',
        'ifNoneMatch'       => 'If-None-Match',
    ];
}
