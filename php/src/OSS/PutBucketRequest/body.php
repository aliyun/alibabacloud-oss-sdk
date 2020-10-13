<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS\PutBucketRequest;

use AlibabaCloud\SDK\OSS\OSS\PutBucketRequest\body\createBucketConfiguration;
use AlibabaCloud\Tea\Model;

class body extends Model
{
    /**
     * @description CreateBucketConfiguration
     *
     * @var createBucketConfiguration
     */
    public $createBucketConfiguration;
    protected $_name = [
        'createBucketConfiguration' => 'CreateBucketConfiguration',
    ];

    public function validate()
    {
        Model::validateRequired('createBucketConfiguration', $this->createBucketConfiguration, true);
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->createBucketConfiguration) {
            $res['CreateBucketConfiguration'] = null !== $this->createBucketConfiguration ? $this->createBucketConfiguration->toMap() : null;
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
        if (isset($map['CreateBucketConfiguration'])) {
            $model->createBucketConfiguration = createBucketConfiguration::fromMap($map['CreateBucketConfiguration']);
        }

        return $model;
    }
}
