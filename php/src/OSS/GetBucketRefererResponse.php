<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS;

use AlibabaCloud\SDK\OSS\OSS\GetBucketRefererResponse\refererConfiguration;
use AlibabaCloud\Tea\Model;

class GetBucketRefererResponse extends Model
{
    /**
     * @description x-oss-request-id
     *
     * @var string
     */
    public $requestId;

    /**
     * @description RefererConfiguration
     *
     * @var GetBucketRefererResponse.refererConfiguration
     */
    public $refererConfiguration;
    protected $_name = [
        'requestId'            => 'x-oss-request-id',
        'refererConfiguration' => 'RefererConfiguration',
    ];

    public function validate()
    {
        Model::validateRequired('requestId', $this->requestId, true);
        Model::validateRequired('refererConfiguration', $this->refererConfiguration, true);
    }

    public function toMap()
    {
        $res                         = [];
        $res['x-oss-request-id']     = $this->requestId;
        $res['RefererConfiguration'] = null !== $this->refererConfiguration ? $this->refererConfiguration->toMap() : null;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetBucketRefererResponse
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['x-oss-request-id'])) {
            $model->requestId = $map['x-oss-request-id'];
        }
        if (isset($map['RefererConfiguration'])) {
            $model->refererConfiguration = refererConfiguration::fromMap($map['RefererConfiguration']);
        }

        return $model;
    }
}
