<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS\PutBucketLifecycleRequest;

use AlibabaCloud\SDK\OSS\OSS\PutBucketLifecycleRequest\body\lifecycleConfiguration;
use AlibabaCloud\Tea\Model;

class body extends Model
{
    /**
     * @description LifecycleConfiguration
     *
     * @var lifecycleConfiguration
     */
    public $lifecycleConfiguration;
    protected $_name = [
        'lifecycleConfiguration' => 'LifecycleConfiguration',
    ];

    public function validate()
    {
        Model::validateRequired('lifecycleConfiguration', $this->lifecycleConfiguration, true);
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->lifecycleConfiguration) {
            $res['LifecycleConfiguration'] = null !== $this->lifecycleConfiguration ? $this->lifecycleConfiguration->toMap() : null;
        }

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
        if (isset($map['LifecycleConfiguration'])) {
            $model->lifecycleConfiguration = lifecycleConfiguration::fromMap($map['LifecycleConfiguration']);
        }

        return $model;
    }
}
