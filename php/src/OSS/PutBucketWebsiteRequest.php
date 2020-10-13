<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS;

use AlibabaCloud\SDK\OSS\OSS\PutBucketWebsiteRequest\body;
use AlibabaCloud\Tea\Model;

class PutBucketWebsiteRequest extends Model
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
     * @var body
     */
    public $body;
    protected $_name = [
        'bucketName' => 'BucketName',
        'body'       => 'Body',
    ];

    public function validate()
    {
        Model::validateRequired('bucketName', $this->bucketName, true);
        Model::validatePattern('bucketName', $this->bucketName, '[a-zA-Z0-9\\-\\_]+');
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->bucketName) {
            $res['BucketName'] = $this->bucketName;
        }
        if (null !== $this->body) {
            $res['Body'] = null !== $this->body ? $this->body->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return PutBucketWebsiteRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['BucketName'])) {
            $model->bucketName = $map['BucketName'];
        }
        if (isset($map['Body'])) {
            $model->body = body::fromMap($map['Body']);
        }

        return $model;
    }
}
