<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS\SelectObjectRequest;

use AlibabaCloud\Tea\Model;

class filter extends Model
{
    /**
     * @description x-oss-process
     *
     * @var string
     */
    public $porcess;
    protected $_name = [
        'porcess' => 'x-oss-process',
    ];

    public function validate()
    {
        Model::validateRequired('porcess', $this->porcess, true);
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->porcess) {
            $res['x-oss-process'] = $this->porcess;
        }

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
        if (isset($map['x-oss-process'])) {
            $model->porcess = $map['x-oss-process'];
        }

        return $model;
    }
}
