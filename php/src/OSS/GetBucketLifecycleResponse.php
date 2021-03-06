<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS;

use AlibabaCloud\SDK\OSS\OSS\GetBucketLifecycleResponse\lifecycleConfiguration;
use AlibabaCloud\Tea\Model;

class GetBucketLifecycleResponse extends Model
{
    /**
     * @description x-oss-request-id
     *
     * @var string
     */
    public $requestId;

    /**
     * @description LifecycleConfiguration
     *
     * @var lifecycleConfiguration
     */
    public $lifecycleConfiguration;
    protected $_name = [
        'requestId'              => 'x-oss-request-id',
        'lifecycleConfiguration' => 'LifecycleConfiguration',
    ];

    public function validate()
    {
        Model::validateRequired('requestId', $this->requestId, true);
        Model::validateRequired('lifecycleConfiguration', $this->lifecycleConfiguration, true);
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->requestId) {
            $res['x-oss-request-id'] = $this->requestId;
        }
        if (null !== $this->lifecycleConfiguration) {
            $res['LifecycleConfiguration'] = null !== $this->lifecycleConfiguration ? $this->lifecycleConfiguration->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetBucketLifecycleResponse
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['x-oss-request-id'])) {
            $model->requestId = $map['x-oss-request-id'];
        }
        if (isset($map['LifecycleConfiguration'])) {
            $model->lifecycleConfiguration = lifecycleConfiguration::fromMap($map['LifecycleConfiguration']);
        }

        return $model;
    }
}
