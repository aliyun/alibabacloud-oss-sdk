<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS;

use AlibabaCloud\SDK\OSS\OSS\GetBucketInfoResponse\bucketInfo;
use AlibabaCloud\Tea\Model;

class GetBucketInfoResponse extends Model
{
    /**
     * @description x-oss-request-id
     *
     * @var string
     */
    public $requestId;

    /**
     * @description BucketInfo
     *
     * @var bucketInfo
     */
    public $bucketInfo;
    protected $_name = [
        'requestId'  => 'x-oss-request-id',
        'bucketInfo' => 'BucketInfo',
    ];

    public function validate()
    {
        Model::validateRequired('requestId', $this->requestId, true);
        Model::validateRequired('bucketInfo', $this->bucketInfo, true);
    }

    public function toMap()
    {
        $res                     = [];
        $res['x-oss-request-id'] = $this->requestId;
        $res['BucketInfo']       = null !== $this->bucketInfo ? $this->bucketInfo->toMap() : null;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetBucketInfoResponse
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['x-oss-request-id'])) {
            $model->requestId = $map['x-oss-request-id'];
        }
        if (isset($map['BucketInfo'])) {
            $model->bucketInfo = bucketInfo::fromMap($map['BucketInfo']);
        }

        return $model;
    }
}
