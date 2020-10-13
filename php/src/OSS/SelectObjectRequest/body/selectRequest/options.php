<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS\SelectObjectRequest\body\selectRequest;

use AlibabaCloud\Tea\Model;

class options extends Model
{
    /**
     * @description SkipPartialDataRecord
     *
     * @var string
     */
    public $skipPartialDataRecord;

    /**
     * @description MaxSkippedRecordsAllowed
     *
     * @var string
     */
    public $maxSkippedRecordsAllowed;
    protected $_name = [
        'skipPartialDataRecord'    => 'SkipPartialDataRecord',
        'maxSkippedRecordsAllowed' => 'MaxSkippedRecordsAllowed',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->skipPartialDataRecord) {
            $res['SkipPartialDataRecord'] = $this->skipPartialDataRecord;
        }
        if (null !== $this->maxSkippedRecordsAllowed) {
            $res['MaxSkippedRecordsAllowed'] = $this->maxSkippedRecordsAllowed;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return options
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['SkipPartialDataRecord'])) {
            $model->skipPartialDataRecord = $map['SkipPartialDataRecord'];
        }
        if (isset($map['MaxSkippedRecordsAllowed'])) {
            $model->maxSkippedRecordsAllowed = $map['MaxSkippedRecordsAllowed'];
        }

        return $model;
    }
}
