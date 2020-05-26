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
        if (null !== $this->object) {
            $res['Object'] = $this->object;
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
                $model->object = $map['Object'];
            }
        }
        if (isset($map['Quiet'])) {
            $model->quiet = $map['Quiet'];
        }

        return $model;
    }
}
