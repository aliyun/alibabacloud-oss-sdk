<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS\UploadPartCopyRequest;

use AlibabaCloud\Tea\Model;

class header extends Model
{
    public $copySource;

    public $copySourceRange;

    public $copySourceIfMatch;

    public $copySourceIfNoneMatch;

    public $copySourceIfUnmodifiedSince;

    public $copySourceIfModifiedSince;
    protected $_name = [
        'copySource'                  => 'x-oss-copy-source',
        'copySourceRange'             => 'x-oss-copy-source-range',
        'copySourceIfMatch'           => 'x-oss-copy-source-if-match',
        'copySourceIfNoneMatch'       => 'x-oss-copy-source-if-none-match',
        'copySourceIfUnmodifiedSince' => 'x-oss-copy-source-if-unmodified-since',
        'copySourceIfModifiedSince'   => 'x-oss-copy-source-if-modified-since',
    ];
}
