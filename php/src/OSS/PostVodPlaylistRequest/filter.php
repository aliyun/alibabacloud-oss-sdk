<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS\PostVodPlaylistRequest;

use AlibabaCloud\Tea\Model;

class filter extends Model
{
    /**
     * @description endTime
     *
     * @var string
     */
    public $endTime;

    /**
     * @description startTime
     *
     * @var string
     */
    public $startTime;
    protected $_name = [
        'endTime'   => 'endTime',
        'startTime' => 'startTime',
    ];

    public function validate()
    {
        Model::validateRequired('endTime', $this->endTime, true);
        Model::validateRequired('startTime', $this->startTime, true);
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->endTime) {
            $res['endTime'] = $this->endTime;
        }
        if (null !== $this->startTime) {
            $res['startTime'] = $this->startTime;
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
        if (isset($map['endTime'])) {
            $model->endTime = $map['endTime'];
        }
        if (isset($map['startTime'])) {
            $model->startTime = $map['startTime'];
        }

        return $model;
    }
}
