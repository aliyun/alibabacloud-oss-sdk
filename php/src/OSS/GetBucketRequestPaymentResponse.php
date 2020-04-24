<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS;

use AlibabaCloud\SDK\OSS\OSS\GetBucketRequestPaymentResponse\requestPaymentConfiguration;
use AlibabaCloud\Tea\Model;

class GetBucketRequestPaymentResponse extends Model
{
    /**
     * @description x-oss-request-id
     *
     * @var string
     */
    public $requestId;

    /**
     * @description RequestPaymentConfiguration
     *
     * @var GetBucketRequestPaymentResponse.requestPaymentConfiguration
     */
    public $requestPaymentConfiguration;
    protected $_name = [
        'requestId'                   => 'x-oss-request-id',
        'requestPaymentConfiguration' => 'RequestPaymentConfiguration',
    ];

    public function validate()
    {
        Model::validateRequired('requestId', $this->requestId, true);
        Model::validateRequired('requestPaymentConfiguration', $this->requestPaymentConfiguration, true);
    }

    public function toMap()
    {
        $res                                = [];
        $res['x-oss-request-id']            = $this->requestId;
        $res['RequestPaymentConfiguration'] = null !== $this->requestPaymentConfiguration ? $this->requestPaymentConfiguration->toMap() : null;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetBucketRequestPaymentResponse
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['x-oss-request-id'])) {
            $model->requestId = $map['x-oss-request-id'];
        }
        if (isset($map['RequestPaymentConfiguration'])) {
            $model->requestPaymentConfiguration = GetBucketRequestPaymentResponse\requestPaymentConfiguration::fromMap($map['RequestPaymentConfiguration']);
        }

        return $model;
    }
}
