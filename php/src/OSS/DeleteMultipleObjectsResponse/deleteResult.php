<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS\DeleteMultipleObjectsResponse;

use AlibabaCloud\Tea\Model;

class deleteResult extends Model
{
    /**
     * @description Quiet
     *
     * @var string
     */
    public $quiet;

    /**
     * @description EncodingType
     *
     * @var string
     */
    public $encodingType;

    /**
     * @description Deleted
     *
     * @var array
     */
    public $deleted;
    protected $_name = [
        'quiet'        => 'Quiet',
        'encodingType' => 'EncodingType',
        'deleted'      => 'Deleted',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res                 = [];
        $res['Quiet']        = $this->quiet;
        $res['EncodingType'] = $this->encodingType;
        $res['Deleted']      = [];
        if (null !== $this->deleted && \is_array($this->deleted)) {
            $n = 0;
            foreach ($this->deleted as $item) {
                $res['Deleted'][$n++] = null !== $item ? $item->toMap() : $item;
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return deleteResult
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['Quiet'])) {
            $model->quiet = $map['Quiet'];
        }
        if (isset($map['EncodingType'])) {
            $model->encodingType = $map['EncodingType'];
        }
        if (isset($map['Deleted'])) {
            if (!empty($map['Deleted'])) {
                $model->deleted = [];
                $n              = 0;
                foreach ($map['Deleted'] as $item) {
                    $model->deleted[$n++] = null !== $item ? DeleteMultipleObjectsResponse\deleteResult\deleted::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
