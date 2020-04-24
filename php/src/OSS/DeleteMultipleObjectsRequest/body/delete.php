<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS\DeleteMultipleObjectsRequest\body;

use AlibabaCloud\Tea\Model;

class delete extends Model
{
    /**
     * @description Object
     *
     * @var array
     */
    public $object;

    /**
     * @description Quiet
     *
     * @var string
     */
    public $quiet;
    protected $_name = [
        'object' => 'Object',
        'quiet'  => 'Quiet',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res           = [];
        $res['Object'] = [];
        if (null !== $this->object && \is_array($this->object)) {
            $n = 0;
            foreach ($this->object as $item) {
                $res['Object'][$n++] = null !== $item ? $item->toMap() : $item;
            }
        }
        $res['Quiet'] = $this->quiet;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return delete
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['Object'])) {
            if (!empty($map['Object'])) {
                $model->object = [];
                $n             = 0;
                foreach ($map['Object'] as $item) {
                    $model->object[$n++] = null !== $item ? DeleteMultipleObjectsRequest\body\delete\object::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['Quiet'])) {
            $model->quiet = $map['Quiet'];
        }

        return $model;
    }
}
