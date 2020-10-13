<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS;

use AlibabaCloud\SDK\OSS\OSS\GetBucketEncryptionResponse\serverSideEncryptionRule;
use AlibabaCloud\Tea\Model;

class GetBucketEncryptionResponse extends Model
{
    /**
     * @description x-oss-request-id
     *
     * @var string
     */
    public $requestId;

    /**
     * @description ServerSideEncryptionRule
     *
     * @var serverSideEncryptionRule
     */
    public $serverSideEncryptionRule;
    protected $_name = [
        'requestId'                => 'x-oss-request-id',
        'serverSideEncryptionRule' => 'ServerSideEncryptionRule',
    ];

    public function validate()
    {
        Model::validateRequired('requestId', $this->requestId, true);
        Model::validateRequired('serverSideEncryptionRule', $this->serverSideEncryptionRule, true);
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->requestId) {
            $res['x-oss-request-id'] = $this->requestId;
        }
        if (null !== $this->serverSideEncryptionRule) {
            $res['ServerSideEncryptionRule'] = null !== $this->serverSideEncryptionRule ? $this->serverSideEncryptionRule->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetBucketEncryptionResponse
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['x-oss-request-id'])) {
            $model->requestId = $map['x-oss-request-id'];
        }
        if (isset($map['ServerSideEncryptionRule'])) {
            $model->serverSideEncryptionRule = serverSideEncryptionRule::fromMap($map['ServerSideEncryptionRule']);
        }

        return $model;
    }
}
