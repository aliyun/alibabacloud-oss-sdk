<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS\UploadPartCopyRequest;

use AlibabaCloud\Tea\Model;

class header extends Model
{
    /**
     * @description x-oss-copy-source
     *
     * @var string
     */
    public $copySource;

    /**
     * @description x-oss-copy-source-range
     *
     * @var string
     */
    public $copySourceRange;

    /**
     * @description x-oss-copy-source-if-match
     *
     * @var string
     */
    public $copySourceIfMatch;

    /**
     * @description x-oss-copy-source-if-none-match
     *
     * @var string
     */
    public $copySourceIfNoneMatch;

    /**
     * @description x-oss-copy-source-if-unmodified-since
     *
     * @var string
     */
    public $copySourceIfUnmodifiedSince;

    /**
     * @description x-oss-copy-source-if-modified-since
     *
     * @var string
     */
    public $copySourceIfModifiedSince;
    protected $_name = [
        'copySource'                  => 'x-oss-copy-source',
        'copySourceRange'             => 'x-oss-copy-source-range',
        'copySourceIfMatch'           => 'x-oss-copy-source-if-match',
        'copySourceIfNoneMatch'       => 'x-oss-copy-source-if-none-match',
        'copySourceIfUnmodifiedSince' => 'x-oss-copy-source-if-unmodified-since',
        'copySourceIfModifiedSince'   => 'x-oss-copy-source-if-modified-since',
    ];

    public function validate()
    {
        Model::validateRequired('copySource', $this->copySource, true);
        Model::validateRequired('copySourceRange', $this->copySourceRange, true);
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->copySource) {
            $res['x-oss-copy-source'] = $this->copySource;
        }
        if (null !== $this->copySourceRange) {
            $res['x-oss-copy-source-range'] = $this->copySourceRange;
        }
        if (null !== $this->copySourceIfMatch) {
            $res['x-oss-copy-source-if-match'] = $this->copySourceIfMatch;
        }
        if (null !== $this->copySourceIfNoneMatch) {
            $res['x-oss-copy-source-if-none-match'] = $this->copySourceIfNoneMatch;
        }
        if (null !== $this->copySourceIfUnmodifiedSince) {
            $res['x-oss-copy-source-if-unmodified-since'] = $this->copySourceIfUnmodifiedSince;
        }
        if (null !== $this->copySourceIfModifiedSince) {
            $res['x-oss-copy-source-if-modified-since'] = $this->copySourceIfModifiedSince;
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
        if (isset($map['x-oss-copy-source'])) {
            $model->copySource = $map['x-oss-copy-source'];
        }
        if (isset($map['x-oss-copy-source-range'])) {
            $model->copySourceRange = $map['x-oss-copy-source-range'];
        }
        if (isset($map['x-oss-copy-source-if-match'])) {
            $model->copySourceIfMatch = $map['x-oss-copy-source-if-match'];
        }
        if (isset($map['x-oss-copy-source-if-none-match'])) {
            $model->copySourceIfNoneMatch = $map['x-oss-copy-source-if-none-match'];
        }
        if (isset($map['x-oss-copy-source-if-unmodified-since'])) {
            $model->copySourceIfUnmodifiedSince = $map['x-oss-copy-source-if-unmodified-since'];
        }
        if (isset($map['x-oss-copy-source-if-modified-since'])) {
            $model->copySourceIfModifiedSince = $map['x-oss-copy-source-if-modified-since'];
        }

        return $model;
    }
}
