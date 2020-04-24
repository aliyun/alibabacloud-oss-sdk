<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS\AppendObjectRequest;

use AlibabaCloud\Tea\Model;

class filter extends Model
{
    /**
     * @description position
     *
     * @var string
     */
    public $position;
    protected $_name = [
        'position' => 'position',
    ];

    public function validate()
    {
        Model::validateRequired('position', $this->position, true);
    }

    public function toMap()
    {
        $res             = [];
        $res['position'] = $this->position;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return filter
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['position'])) {
            $model->position = $map['position'];
        }

        return $model;
    }
}
