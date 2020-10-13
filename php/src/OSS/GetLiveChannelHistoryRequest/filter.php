<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS\GetLiveChannelHistoryRequest;

use AlibabaCloud\Tea\Model;

class filter extends Model
{
    /**
     * @description comp
     *
     * @var string
     */
    public $comp;
    protected $_name = [
        'comp' => 'comp',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->comp) {
            $res['comp'] = $this->comp;
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
        if (isset($map['comp'])) {
            $model->comp = $map['comp'];
        }

        return $model;
    }
}
