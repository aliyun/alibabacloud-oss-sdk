<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS\GetBucketInfoResponse;

use AlibabaCloud\SDK\OSS\OSS\GetBucketInfoResponse\bucketInfo\bucket;
use AlibabaCloud\Tea\Model;

class bucketInfo extends Model
{
    /**
     * @description Bucket
     *
     * @var bucket
     */
    public $bucket;
    protected $_name = [
        'bucket' => 'Bucket',
    ];

    public function validate()
    {
        Model::validateRequired('bucket', $this->bucket, true);
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->bucket) {
            $res['Bucket'] = null !== $this->bucket ? $this->bucket->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return bucketInfo
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['Bucket'])) {
            $model->bucket = bucket::fromMap($map['Bucket']);
        }

        return $model;
    }
}
