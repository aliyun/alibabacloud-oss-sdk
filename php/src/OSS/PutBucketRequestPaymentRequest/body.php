<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS\PutBucketRequestPaymentRequest;

use AlibabaCloud\SDK\OSS\OSS\PutBucketRequestPaymentRequest\body\requestPaymentConfiguration;
use AlibabaCloud\Tea\Model;

class body extends Model
{
    /**
     * @description RequestPaymentConfiguration
     *
     * @var requestPaymentConfiguration
     */
    public $requestPaymentConfiguration;
    protected $_name = [
        'requestPaymentConfiguration' => 'RequestPaymentConfiguration',
    ];

    public function validate()
    {
        Model::validateRequired('requestPaymentConfiguration', $this->requestPaymentConfiguration, true);
    }

    public function toMap()
    {
        $res                                = [];
        $res['RequestPaymentConfiguration'] = null !== $this->requestPaymentConfiguration ? $this->requestPaymentConfiguration->toMap() : null;

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
        if (isset($map['RequestPaymentConfiguration'])) {
            $model->requestPaymentConfiguration = requestPaymentConfiguration::fromMap($map['RequestPaymentConfiguration']);
        }

        return $model;
    }
}
