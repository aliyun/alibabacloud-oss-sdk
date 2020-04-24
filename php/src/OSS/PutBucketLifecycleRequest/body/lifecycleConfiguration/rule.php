<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS\PutBucketLifecycleRequest\body\lifecycleConfiguration;

use AlibabaCloud\SDK\OSS\OSS\rule\abortMultipartUpload;
use AlibabaCloud\SDK\OSS\OSS\rule\expiration;
use AlibabaCloud\SDK\OSS\OSS\rule\tag;
use AlibabaCloud\SDK\OSS\OSS\rule\transition;
use AlibabaCloud\Tea\Model;

class rule extends Model
{
    /**
     * @description Expiration
     *
     * @var rule.expiration
     */
    public $expiration;

    /**
     * @description Transition
     *
     * @var rule.transition
     */
    public $transition;

    /**
     * @description AbortMultipartUpload
     *
     * @var rule.abortMultipartUpload
     */
    public $abortMultipartUpload;

    /**
     * @description Tag
     *
     * @var rule.tag
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
        $res                         = [];
        $res['Expiration']           = null !== $this->expiration ? $this->expiration->toMap() : null;
        $res['Transition']           = null !== $this->transition ? $this->transition->toMap() : null;
        $res['AbortMultipartUpload'] = null !== $this->abortMultipartUpload ? $this->abortMultipartUpload->toMap() : null;
        $res['Tag']                  = null !== $this->tag ? $this->tag->toMap() : null;
        $res['ID']                   = $this->iD;
        $res['Prefix']               = $this->prefix;
        $res['Status']               = $this->status;

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
            $model->expiration = rule\expiration::fromMap($map['Expiration']);
        }
        if (isset($map['Transition'])) {
            $model->transition = rule\transition::fromMap($map['Transition']);
        }
        if (isset($map['AbortMultipartUpload'])) {
            $model->abortMultipartUpload = rule\abortMultipartUpload::fromMap($map['AbortMultipartUpload']);
        }
        if (isset($map['Tag'])) {
            $model->tag = rule\tag::fromMap($map['Tag']);
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
