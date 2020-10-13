<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS\SelectObjectRequest\body\selectRequest;

use AlibabaCloud\SDK\OSS\OSS\SelectObjectRequest\body\selectRequest\outputSerialization\cSV;
use AlibabaCloud\Tea\Model;

class outputSerialization extends Model
{
    /**
     * @description CSV
     *
     * @var cSV
     */
    public $cSV;

    /**
     * @description KeepAllColumns
     *
     * @var string
     */
    public $keepAllColumns;

    /**
     * @description OutputRawData
     *
     * @var string
     */
    public $outputRawData;

    /**
     * @description EnablePayloadCrc
     *
     * @var string
     */
    public $enablePayloadCrc;

    /**
     * @description OutputHeader
     *
     * @var string
     */
    public $outputHeader;
    protected $_name = [
        'cSV'              => 'CSV',
        'keepAllColumns'   => 'KeepAllColumns',
        'outputRawData'    => 'OutputRawData',
        'enablePayloadCrc' => 'EnablePayloadCrc',
        'outputHeader'     => 'OutputHeader',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->cSV) {
            $res['CSV'] = null !== $this->cSV ? $this->cSV->toMap() : null;
        }
        if (null !== $this->keepAllColumns) {
            $res['KeepAllColumns'] = $this->keepAllColumns;
        }
        if (null !== $this->outputRawData) {
            $res['OutputRawData'] = $this->outputRawData;
        }
        if (null !== $this->enablePayloadCrc) {
            $res['EnablePayloadCrc'] = $this->enablePayloadCrc;
        }
        if (null !== $this->outputHeader) {
            $res['OutputHeader'] = $this->outputHeader;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return outputSerialization
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['CSV'])) {
            $model->cSV = cSV::fromMap($map['CSV']);
        }
        if (isset($map['KeepAllColumns'])) {
            $model->keepAllColumns = $map['KeepAllColumns'];
        }
        if (isset($map['OutputRawData'])) {
            $model->outputRawData = $map['OutputRawData'];
        }
        if (isset($map['EnablePayloadCrc'])) {
            $model->enablePayloadCrc = $map['EnablePayloadCrc'];
        }
        if (isset($map['OutputHeader'])) {
            $model->outputHeader = $map['OutputHeader'];
        }

        return $model;
    }
}
