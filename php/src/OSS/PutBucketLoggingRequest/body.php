<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS\PutBucketLoggingRequest;

use AlibabaCloud\SDK\OSS\OSS\body\bucketLoggingStatus;
use AlibabaCloud\Tea\Model;

class body extends Model
{
    /**
     * @description BucketLoggingStatus
     *
     * @var body.bucketLoggingStatus
     */
    public $bucketLoggingStatus;
    protected $_name = [
        'bucketLoggingStatus' => 'BucketLoggingStatus',
    ];

    public function validate()
    {
        Model::validateRequired('bucketLoggingStatus', $this->bucketLoggingStatus, true);
    }

    public function toMap()
    {
        $res                        = [];
        $res['BucketLoggingStatus'] = null !== $this->bucketLoggingStatus ? $this->bucketLoggingStatus->toMap() : null;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return body
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['BucketLoggingStatus'])) {
            $model->bucketLoggingStatus = bucketLoggingStatus::fromMap($map['BucketLoggingStatus']);
        }

        return $model;
    }
}
