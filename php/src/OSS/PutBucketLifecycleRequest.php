<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS;

use AlibabaCloud\SDK\OSS\OSS\PutBucketLifecycleRequest\body;
use AlibabaCloud\Tea\Model;

class PutBucketLifecycleRequest extends Model
{
    /**
     * @description BucketName
     *
     * @var string
     */
    public $bucketName;

    /**
     * @description Body
     *
     * @var PutBucketLifecycleRequest.body
     */
    public $body;
    protected $_name = [
        'bucketName' => 'BucketName',
        'body'       => 'Body',
    ];

    public function validate()
    {
        Model::validateRequired('bucketName', $this->bucketName, true);
    }

    public function toMap()
    {
        $res               = [];
        $res['BucketName'] = $this->bucketName;
        $res['Body']       = null !== $this->body ? $this->body->toMap() : null;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return PutBucketLifecycleRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['BucketName'])) {
            $model->bucketName = $map['BucketName'];
        }
        if (isset($map['Body'])) {
            $model->body = PutBucketLifecycleRequest\body::fromMap($map['Body']);
        }

        return $model;
    }
}
