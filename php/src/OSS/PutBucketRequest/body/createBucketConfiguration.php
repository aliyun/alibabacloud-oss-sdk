<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS\PutBucketRequest\body;

use AlibabaCloud\Tea\Model;

class createBucketConfiguration extends Model
{
    /**
     * @description StorageClass
     *
     * @var string
     */
    public $storageClass;

    /**
     * @description DataRedundancyType
     *
     * @var string
     */
    public $dataRedundancyType;
    protected $_name = [
        'storageClass'       => 'StorageClass',
        'dataRedundancyType' => 'DataRedundancyType',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->storageClass) {
            $res['StorageClass'] = $this->storageClass;
        }
        if (null !== $this->dataRedundancyType) {
            $res['DataRedundancyType'] = $this->dataRedundancyType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return createBucketConfiguration
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['StorageClass'])) {
            $model->storageClass = $map['StorageClass'];
        }
        if (isset($map['DataRedundancyType'])) {
            $model->dataRedundancyType = $map['DataRedundancyType'];
        }

        return $model;
    }
}
