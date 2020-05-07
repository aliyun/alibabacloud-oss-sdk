<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS\SelectObjectRequest\body\selectRequest;

use AlibabaCloud\SDK\OSS\OSS\inputSerialization\cSV;
use AlibabaCloud\Tea\Model;

class inputSerialization extends Model
{
    /**
     * @description CSV
     *
     * @var inputSerialization.cSV
     */
    public $cSV;

    /**
     * @description CompressionType
     *
     * @var string
     */
    public $compressionType;
    protected $_name = [
        'cSV'             => 'CSV',
        'compressionType' => 'CompressionType',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res                    = [];
        $res['CSV']             = null !== $this->cSV ? $this->cSV->toMap() : null;
        $res['CompressionType'] = $this->compressionType;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return inputSerialization
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['CSV'])) {
            $model->cSV = cSV::fromMap($map['CSV']);
        }
        if (isset($map['CompressionType'])) {
            $model->compressionType = $map['CompressionType'];
        }

        return $model;
    }
}
