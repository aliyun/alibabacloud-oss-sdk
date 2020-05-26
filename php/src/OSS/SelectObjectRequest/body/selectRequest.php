<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS\SelectObjectRequest\body;

use AlibabaCloud\SDK\OSS\OSS\SelectObjectRequest\body\selectRequest\inputSerialization;
use AlibabaCloud\SDK\OSS\OSS\SelectObjectRequest\body\selectRequest\options;
use AlibabaCloud\SDK\OSS\OSS\SelectObjectRequest\body\selectRequest\outputSerialization;
use AlibabaCloud\Tea\Model;

class selectRequest extends Model
{
    /**
     * @description InputSerialization
     *
     * @var inputSerialization
     */
    public $inputSerialization;

    /**
     * @description OutputSerialization
     *
     * @var outputSerialization
     */
    public $outputSerialization;

    /**
     * @description Options
     *
     * @var options
     */
    public $options;

    /**
     * @description Expression
     *
     * @var string
     */
    public $expression;
    protected $_name = [
        'inputSerialization'  => 'InputSerialization',
        'outputSerialization' => 'OutputSerialization',
        'options'             => 'Options',
        'expression'          => 'Expression',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res                        = [];
        $res['InputSerialization']  = null !== $this->inputSerialization ? $this->inputSerialization->toMap() : null;
        $res['OutputSerialization'] = null !== $this->outputSerialization ? $this->outputSerialization->toMap() : null;
        $res['Options']             = null !== $this->options ? $this->options->toMap() : null;
        $res['Expression']          = $this->expression;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return selectRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['InputSerialization'])) {
            $model->inputSerialization = inputSerialization::fromMap($map['InputSerialization']);
        }
        if (isset($map['OutputSerialization'])) {
            $model->outputSerialization = outputSerialization::fromMap($map['OutputSerialization']);
        }
        if (isset($map['Options'])) {
            $model->options = options::fromMap($map['Options']);
        }
        if (isset($map['Expression'])) {
            $model->expression = $map['Expression'];
        }

        return $model;
    }
}
