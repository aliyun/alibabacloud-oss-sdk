<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS\PutBucketCORSRequest\body;

use AlibabaCloud\SDK\OSS\OSS\PutBucketCORSRequest\body\cORSConfiguration\cORSRule;
use AlibabaCloud\Tea\Model;

class cORSConfiguration extends Model
{
    /**
     * @description CORSRule
     *
     * @var cORSRule[]
     */
    public $cORSRule;
    protected $_name = [
        'cORSRule' => 'CORSRule',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->cORSRule) {
            $res['CORSRule'] = [];
            if (null !== $this->cORSRule && \is_array($this->cORSRule)) {
                $n = 0;
                foreach ($this->cORSRule as $item) {
                    $res['CORSRule'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return cORSConfiguration
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['CORSRule'])) {
            if (!empty($map['CORSRule'])) {
                $model->cORSRule = [];
                $n               = 0;
                foreach ($map['CORSRule'] as $item) {
                    $model->cORSRule[$n++] = null !== $item ? cORSRule::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
