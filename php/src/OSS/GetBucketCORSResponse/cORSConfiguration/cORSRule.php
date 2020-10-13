<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS\GetBucketCORSResponse\cORSConfiguration;

use AlibabaCloud\Tea\Model;

class cORSRule extends Model
{
    /**
     * @description MaxAgeSeconds
     *
     * @var string
     */
    public $maxAgeSeconds;
    protected $_name = [
        'maxAgeSeconds' => 'MaxAgeSeconds',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->maxAgeSeconds) {
            $res['MaxAgeSeconds'] = $this->maxAgeSeconds;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return cORSRule
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['MaxAgeSeconds'])) {
            $model->maxAgeSeconds = $map['MaxAgeSeconds'];
        }

        return $model;
    }
}
