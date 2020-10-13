<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS;

use AlibabaCloud\SDK\OSS\OSS\GetBucketAclResponse\accessControlPolicy;
use AlibabaCloud\Tea\Model;

class GetBucketAclResponse extends Model
{
    /**
     * @description x-oss-request-id
     *
     * @var string
     */
    public $requestId;

    /**
     * @description AccessControlPolicy
     *
     * @var accessControlPolicy
     */
    public $accessControlPolicy;
    protected $_name = [
        'requestId'           => 'x-oss-request-id',
        'accessControlPolicy' => 'AccessControlPolicy',
    ];

    public function validate()
    {
        Model::validateRequired('requestId', $this->requestId, true);
        Model::validateRequired('accessControlPolicy', $this->accessControlPolicy, true);
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->requestId) {
            $res['x-oss-request-id'] = $this->requestId;
        }
        if (null !== $this->accessControlPolicy) {
            $res['AccessControlPolicy'] = null !== $this->accessControlPolicy ? $this->accessControlPolicy->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetBucketAclResponse
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['x-oss-request-id'])) {
            $model->requestId = $map['x-oss-request-id'];
        }
        if (isset($map['AccessControlPolicy'])) {
            $model->accessControlPolicy = accessControlPolicy::fromMap($map['AccessControlPolicy']);
        }

        return $model;
    }
}
