<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS\GetBucketLifecycleResponse\lifecycleConfiguration\rule;

use AlibabaCloud\Tea\Model;

class transition extends Model
{
    /**
     * @description Days
     *
     * @var int
     */
    public $days;

    /**
     * @description StorageClass
     *
     * @var string
     */
    public $storageClass;
    protected $_name = [
        'days'         => 'Days',
        'storageClass' => 'StorageClass',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->days) {
            $res['Days'] = $this->days;
        }
        if (null !== $this->storageClass) {
            $res['StorageClass'] = $this->storageClass;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return transition
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['Days'])) {
            $model->days = $map['Days'];
        }
        if (isset($map['StorageClass'])) {
            $model->storageClass = $map['StorageClass'];
        }

        return $model;
    }
}
