<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS\DeleteMultipleObjectsRequest\body;

use AlibabaCloud\SDK\OSS\OSS\DeleteMultipleObjectsRequest\body\delete\object;
use AlibabaCloud\Tea\Model;

class delete extends Model
{
    /**
     * @description Object
     *
     * @var object[]
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
        $res = [];
        if (null !== $this->object) {
            $res['Object'] = [];
            if (null !== $this->object && \is_array($this->object)) {
                $n = 0;
                foreach ($this->object as $item) {
                    $res['Object'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->quiet) {
            $res['Quiet'] = $this->quiet;
        }

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
                    $model->object[$n++] = null !== $item ? object::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['Quiet'])) {
            $model->quiet = $map['Quiet'];
        }

        return $model;
    }
}
