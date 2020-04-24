<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS\GetServiceRequest;

use AlibabaCloud\Tea\Model;

class filter extends Model
{
    /**
     * @description prefix
     *
     * @var string
     */
    public $prefix;

    /**
     * @description marker
     *
     * @var string
     */
    public $marker;

    /**
     * @description max-keys
     *
     * @var string
     */
    public $maxKeys;
    protected $_name = [
        'prefix'  => 'prefix',
        'marker'  => 'marker',
        'maxKeys' => 'max-keys',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res             = [];
        $res['prefix']   = $this->prefix;
        $res['marker']   = $this->marker;
        $res['max-keys'] = $this->maxKeys;

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
        if (isset($map['prefix'])) {
            $model->prefix = $map['prefix'];
        }
        if (isset($map['marker'])) {
            $model->marker = $map['marker'];
        }
        if (isset($map['max-keys'])) {
            $model->maxKeys = $map['max-keys'];
        }

        return $model;
    }
}
