<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS\DeleteMultipleObjectsResponse\deleteResult;

use AlibabaCloud\Tea\Model;

class deleted extends Model
{
    /**
     * @description Key
     *
     * @var string
     */
    public $key;
    protected $_name = [
        'key' => 'Key',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res        = [];
        $res['Key'] = $this->key;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return deleted
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['Key'])) {
            $model->key = $map['Key'];
        }

        return $model;
    }
}
