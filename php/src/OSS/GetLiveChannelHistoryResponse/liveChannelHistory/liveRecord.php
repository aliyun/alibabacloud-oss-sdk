<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS\GetLiveChannelHistoryResponse\liveChannelHistory;

use AlibabaCloud\Tea\Model;

class liveRecord extends Model
{
    /**
     * @description StartTime
     *
     * @var string
     */
    public $startTime;

    /**
     * @description EndTime
     *
     * @var string
     */
    public $endTime;

    /**
     * @description RemoteAddr
     *
     * @var string
     */
    public $remoteAddr;
    protected $_name = [
        'startTime'  => 'StartTime',
        'endTime'    => 'EndTime',
        'remoteAddr' => 'RemoteAddr',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res               = [];
        $res['StartTime']  = $this->startTime;
        $res['EndTime']    = $this->endTime;
        $res['RemoteAddr'] = $this->remoteAddr;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return liveRecord
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['StartTime'])) {
            $model->startTime = $map['StartTime'];
        }
        if (isset($map['EndTime'])) {
            $model->endTime = $map['EndTime'];
        }
        if (isset($map['RemoteAddr'])) {
            $model->remoteAddr = $map['RemoteAddr'];
        }

        return $model;
    }
}
