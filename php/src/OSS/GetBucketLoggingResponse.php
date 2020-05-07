<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS;

use AlibabaCloud\SDK\OSS\OSS\GetBucketLoggingResponse\bucketLoggingStatus;
use AlibabaCloud\Tea\Model;

class GetBucketLoggingResponse extends Model
{
    /**
     * @description x-oss-request-id
     *
     * @var string
     */
    public $requestId;

    /**
     * @description BucketLoggingStatus
     *
     * @var GetBucketLoggingResponse.bucketLoggingStatus
     */
    public $bucketLoggingStatus;
    protected $_name = [
        'requestId'           => 'x-oss-request-id',
        'bucketLoggingStatus' => 'BucketLoggingStatus',
    ];

    public function validate()
    {
        Model::validateRequired('requestId', $this->requestId, true);
        Model::validateRequired('bucketLoggingStatus', $this->bucketLoggingStatus, true);
    }

    public function toMap()
    {
        $res                        = [];
        $res['x-oss-request-id']    = $this->requestId;
        $res['BucketLoggingStatus'] = null !== $this->bucketLoggingStatus ? $this->bucketLoggingStatus->toMap() : null;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetBucketLoggingResponse
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['x-oss-request-id'])) {
            $model->requestId = $map['x-oss-request-id'];
        }
        if (isset($map['BucketLoggingStatus'])) {
            $model->bucketLoggingStatus = bucketLoggingStatus::fromMap($map['BucketLoggingStatus']);
        }

        return $model;
    }
}
