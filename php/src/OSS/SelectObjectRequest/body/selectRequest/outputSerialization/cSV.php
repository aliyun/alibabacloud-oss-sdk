<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS\SelectObjectRequest\body\selectRequest\outputSerialization;

use AlibabaCloud\Tea\Model;

class cSV extends Model
{
    /**
     * @description RecordDelimiter
     *
     * @var string
     */
    public $recordDelimiter;

    /**
     * @description FieldDelimiter
     *
     * @var string
     */
    public $fieldDelimiter;
    protected $_name = [
        'recordDelimiter' => 'RecordDelimiter',
        'fieldDelimiter'  => 'FieldDelimiter',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res                    = [];
        $res['RecordDelimiter'] = $this->recordDelimiter;
        $res['FieldDelimiter']  = $this->fieldDelimiter;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return cSV
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['RecordDelimiter'])) {
            $model->recordDelimiter = $map['RecordDelimiter'];
        }
        if (isset($map['FieldDelimiter'])) {
            $model->fieldDelimiter = $map['FieldDelimiter'];
        }

        return $model;
    }
}
