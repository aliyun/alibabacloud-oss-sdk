<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS\DeleteMultipleObjectsRequest;

use AlibabaCloud\SDK\OSS\OSS\DeleteMultipleObjectsRequest\body\delete;
use AlibabaCloud\Tea\Model;

class body extends Model
{
    /**
     * @description Delete
     *
     * @var delete
     */
    public $delete;
    protected $_name = [
        'delete' => 'Delete',
    ];

    public function validate()
    {
        Model::validateRequired('delete', $this->delete, true);
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->delete) {
            $res['Delete'] = null !== $this->delete ? $this->delete->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return body
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['Delete'])) {
            $model->delete = delete::fromMap($map['Delete']);
        }

        return $model;
    }
}
