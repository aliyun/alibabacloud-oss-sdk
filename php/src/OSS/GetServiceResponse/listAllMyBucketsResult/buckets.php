<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS\GetServiceResponse\listAllMyBucketsResult;

use AlibabaCloud\SDK\OSS\OSS\GetServiceResponse\listAllMyBucketsResult\buckets\bucket;
use AlibabaCloud\Tea\Model;

class buckets extends Model
{
    /**
     * @description Bucket
     *
     * @var array
     */
    public $bucket;
    protected $_name = [
        'bucket' => 'Bucket',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res           = [];
        $res['Bucket'] = [];
        if (null !== $this->bucket && \is_array($this->bucket)) {
            $n = 0;
            foreach ($this->bucket as $item) {
                $res['Bucket'][$n++] = null !== $item ? $item->toMap() : $item;
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return buckets
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['Bucket'])) {
            if (!empty($map['Bucket'])) {
                $model->bucket = [];
                $n             = 0;
                foreach ($map['Bucket'] as $item) {
                    $model->bucket[$n++] = null !== $item ? bucket::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
