<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS\GetBucketLifecycleResponse\lifecycleConfiguration;

use AlibabaCloud\SDK\OSS\OSS\GetBucketLifecycleResponse\lifecycleConfiguration\rule\abortMultipartUpload;
use AlibabaCloud\SDK\OSS\OSS\GetBucketLifecycleResponse\lifecycleConfiguration\rule\expiration;
use AlibabaCloud\SDK\OSS\OSS\GetBucketLifecycleResponse\lifecycleConfiguration\rule\tag;
use AlibabaCloud\SDK\OSS\OSS\GetBucketLifecycleResponse\lifecycleConfiguration\rule\transition;
use AlibabaCloud\Tea\Model;

class rule extends Model
{
    /**
     * @description ID
     *
     * @var string
     */
    public $iD;

    /**
     * @description Prefix
     *
     * @var string
     */
    public $prefix;

    /**
     * @description Status
     *
     * @var string
     */
    public $status;

    /**
     * @description Expiration
     *
     * @var expiration
     */
    public $expiration;

    /**
     * @description Transition
     *
     * @var transition
     */
    public $transition;

    /**
     * @description AbortMultipartUpload
     *
     * @var abortMultipartUpload
     */
    public $abortMultipartUpload;

    /**
     * @description Tag
     *
     * @var tag
     */
    public $tag;
    protected $_name = [
        'iD'                   => 'ID',
        'prefix'               => 'Prefix',
        'status'               => 'Status',
        'expiration'           => 'Expiration',
        'transition'           => 'Transition',
        'abortMultipartUpload' => 'AbortMultipartUpload',
        'tag'                  => 'Tag',
    ];

    public function validate()
    {
        Model::validateRequired('expiration', $this->expiration, true);
        Model::validateRequired('transition', $this->transition, true);
        Model::validateRequired('abortMultipartUpload', $this->abortMultipartUpload, true);
        Model::validateRequired('tag', $this->tag, true);
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->iD) {
            $res['ID'] = $this->iD;
        }
        if (null !== $this->prefix) {
            $res['Prefix'] = $this->prefix;
        }
        if (null !== $this->status) {
            $res['Status'] = $this->status;
        }
        if (null !== $this->expiration) {
            $res['Expiration'] = null !== $this->expiration ? $this->expiration->toMap() : null;
        }
        if (null !== $this->transition) {
            $res['Transition'] = null !== $this->transition ? $this->transition->toMap() : null;
        }
        if (null !== $this->abortMultipartUpload) {
            $res['AbortMultipartUpload'] = null !== $this->abortMultipartUpload ? $this->abortMultipartUpload->toMap() : null;
        }
        if (null !== $this->tag) {
            $res['Tag'] = null !== $this->tag ? $this->tag->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return rule
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['ID'])) {
            $model->iD = $map['ID'];
        }
        if (isset($map['Prefix'])) {
            $model->prefix = $map['Prefix'];
        }
        if (isset($map['Status'])) {
            $model->status = $map['Status'];
        }
        if (isset($map['Expiration'])) {
            $model->expiration = expiration::fromMap($map['Expiration']);
        }
        if (isset($map['Transition'])) {
            $model->transition = transition::fromMap($map['Transition']);
        }
        if (isset($map['AbortMultipartUpload'])) {
            $model->abortMultipartUpload = abortMultipartUpload::fromMap($map['AbortMultipartUpload']);
        }
        if (isset($map['Tag'])) {
            $model->tag = tag::fromMap($map['Tag']);
        }

        return $model;
    }
}
