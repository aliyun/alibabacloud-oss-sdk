<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS\PutLiveChannelStatusRequest;

use AlibabaCloud\Tea\Model;

class filter extends Model
{
    /**
     * @description status
     *
     * @var string
     */
    public $status;
    protected $_name = [
        'status' => 'status',
    ];

    public function validate()
    {
        Model::validateRequired('status', $this->status, true);
    }

    public function toMap()
    {
        $res           = [];
        $res['status'] = $this->status;

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
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }

        return $model;
    }
}
