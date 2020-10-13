<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS\GetBucketRequestPaymentResponse;

use AlibabaCloud\Tea\Model;

class requestPaymentConfiguration extends Model
{
    /**
     * @description Payer
     *
     * @var string
     */
    public $payer;
    protected $_name = [
        'payer' => 'Payer',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->payer) {
            $res['Payer'] = $this->payer;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return requestPaymentConfiguration
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['Payer'])) {
            $model->payer = $map['Payer'];
        }

        return $model;
    }
}
