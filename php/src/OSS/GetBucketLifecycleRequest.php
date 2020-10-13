<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS;

use AlibabaCloud\Tea\Model;

class GetBucketLifecycleRequest extends Model
{
    /**
     * @description BucketName
     *
     * @var string
     */
    public $bucketName;
    protected $_name = [
        'bucketName' => 'BucketName',
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

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetBucketLifecycleRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['BucketName'])) {
            $model->bucketName = $map['BucketName'];
        }

        return $model;
    }
}
