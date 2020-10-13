<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS\PutBucketLifecycleRequest\body\lifecycleConfiguration;

use AlibabaCloud\SDK\OSS\OSS\PutBucketLifecycleRequest\body\lifecycleConfiguration\rule\abortMultipartUpload;
use AlibabaCloud\SDK\OSS\OSS\PutBucketLifecycleRequest\body\lifecycleConfiguration\rule\expiration;
use AlibabaCloud\SDK\OSS\OSS\PutBucketLifecycleRequest\body\lifecycleConfiguration\rule\tag;
use AlibabaCloud\SDK\OSS\OSS\PutBucketLifecycleRequest\body\lifecycleConfiguration\rule\transition;
use AlibabaCloud\Tea\Model;

class rule extends Model
{
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
    protected $_name = [
        'expiration'           => 'Expiration',
        'transition'           => 'Transition',
        'abortMultipartUpload' => 'AbortMultipartUpload',
        'tag'                  => 'Tag',
        'iD'                   => 'ID',
        'prefix'               => 'Prefix',
        'status'               => 'Status',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
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
        if (null !== $this->iD) {
            $res['ID'] = $this->iD;
        }
        if (null !== $this->prefix) {
            $res['Prefix'] = $this->prefix;
        }
        if (null !== $this->status) {
            $res['Status'] = $this->status;
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
        if (isset($map['ID'])) {
            $model->iD = $map['ID'];
        }
        if (isset($map['Prefix'])) {
            $model->prefix = $map['Prefix'];
        }
        if (isset($map['Status'])) {
            $model->status = $map['Status'];
        }

        return $model;
    }
}
