<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS\HeadObjectRequest;

use AlibabaCloud\Tea\Model;

class header extends Model
{
    /**
     * @description If-Modified-Since
     *
     * @var string
     */
    public $ifModifiedSince;

    /**
     * @description If-Unmodified-Since
     *
     * @var string
     */
    public $ifUnmodifiedSince;

    /**
     * @description If-Match
     *
     * @var string
     */
    public $ifMatch;

    /**
     * @description If-None-Match
     *
     * @var string
     */
    public $ifNoneMatch;
    protected $_name = [
        'ifModifiedSince'   => 'If-Modified-Since',
        'ifUnmodifiedSince' => 'If-Unmodified-Since',
        'ifMatch'           => 'If-Match',
        'ifNoneMatch'       => 'If-None-Match',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->ifModifiedSince) {
            $res['If-Modified-Since'] = $this->ifModifiedSince;
        }
        if (null !== $this->ifUnmodifiedSince) {
            $res['If-Unmodified-Since'] = $this->ifUnmodifiedSince;
        }
        if (null !== $this->ifMatch) {
            $res['If-Match'] = $this->ifMatch;
        }
        if (null !== $this->ifNoneMatch) {
            $res['If-None-Match'] = $this->ifNoneMatch;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return header
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['If-Modified-Since'])) {
            $model->ifModifiedSince = $map['If-Modified-Since'];
        }
        if (isset($map['If-Unmodified-Since'])) {
            $model->ifUnmodifiedSince = $map['If-Unmodified-Since'];
        }
        if (isset($map['If-Match'])) {
            $model->ifMatch = $map['If-Match'];
        }
        if (isset($map['If-None-Match'])) {
            $model->ifNoneMatch = $map['If-None-Match'];
        }

        return $model;
    }
}
