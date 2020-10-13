<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS\SelectObjectRequest\body\selectRequest\inputSerialization;

use AlibabaCloud\Tea\Model;

class cSV extends Model
{
    /**
     * @description FileHeaderInfo
     *
     * @var string
     */
    public $fileHeaderInfo;

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

    /**
     * @description QuoteCharacter
     *
     * @var string
     */
    public $quoteCharacter;

    /**
     * @description CommentCharacter
     *
     * @var string
     */
    public $commentCharacter;

    /**
     * @description Range
     *
     * @var string
     */
    public $range;
    protected $_name = [
        'fileHeaderInfo'   => 'FileHeaderInfo',
        'recordDelimiter'  => 'RecordDelimiter',
        'fieldDelimiter'   => 'FieldDelimiter',
        'quoteCharacter'   => 'QuoteCharacter',
        'commentCharacter' => 'CommentCharacter',
        'range'            => 'Range',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->fileHeaderInfo) {
            $res['FileHeaderInfo'] = $this->fileHeaderInfo;
        }
        if (null !== $this->recordDelimiter) {
            $res['RecordDelimiter'] = $this->recordDelimiter;
        }
        if (null !== $this->fieldDelimiter) {
            $res['FieldDelimiter'] = $this->fieldDelimiter;
        }
        if (null !== $this->quoteCharacter) {
            $res['QuoteCharacter'] = $this->quoteCharacter;
        }
        if (null !== $this->commentCharacter) {
            $res['CommentCharacter'] = $this->commentCharacter;
        }
        if (null !== $this->range) {
            $res['Range'] = $this->range;
        }

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
        if (isset($map['FileHeaderInfo'])) {
            $model->fileHeaderInfo = $map['FileHeaderInfo'];
        }
        if (isset($map['RecordDelimiter'])) {
            $model->recordDelimiter = $map['RecordDelimiter'];
        }
        if (isset($map['FieldDelimiter'])) {
            $model->fieldDelimiter = $map['FieldDelimiter'];
        }
        if (isset($map['QuoteCharacter'])) {
            $model->quoteCharacter = $map['QuoteCharacter'];
        }
        if (isset($map['CommentCharacter'])) {
            $model->commentCharacter = $map['CommentCharacter'];
        }
        if (isset($map['Range'])) {
            $model->range = $map['Range'];
        }

        return $model;
    }
}
