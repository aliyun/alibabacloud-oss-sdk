<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS\PutBucketRefererRequest;

use AlibabaCloud\SDK\OSS\OSS\body\refererConfiguration;
use AlibabaCloud\Tea\Model;

class body extends Model
{
    /**
     * @description RefererConfiguration
     *
     * @var body.refererConfiguration
     */
    public $refererConfiguration;
    protected $_name = [
        'refererConfiguration' => 'RefererConfiguration',
    ];

    public function validate()
    {
        Model::validateRequired('refererConfiguration', $this->refererConfiguration, true);
    }

    public function toMap()
    {
        $res                         = [];
        $res['RefererConfiguration'] = null !== $this->refererConfiguration ? $this->refererConfiguration->toMap() : null;

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
        if (isset($map['RefererConfiguration'])) {
            $model->refererConfiguration = body\refererConfiguration::fromMap($map['RefererConfiguration']);
        }

        return $model;
    }
}
