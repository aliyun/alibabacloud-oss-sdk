<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS\PutLiveChannelRequest\body\liveChannelConfiguration;

use AlibabaCloud\Tea\Model;

class snapshot extends Model
{
    /**
     * @description RoleName
     *
     * @var string
     */
    public $roleName;

    /**
     * @description DestBucket
     *
     * @var string
     */
    public $destBucket;

    /**
     * @description NotifyTopic
     *
     * @var string
     */
    public $notifyTopic;

    /**
     * @description Interval
     *
     * @var string
     */
    public $interval;
    protected $_name = [
        'roleName'    => 'RoleName',
        'destBucket'  => 'DestBucket',
        'notifyTopic' => 'NotifyTopic',
        'interval'    => 'Interval',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->roleName) {
            $res['RoleName'] = $this->roleName;
        }
        if (null !== $this->destBucket) {
            $res['DestBucket'] = $this->destBucket;
        }
        if (null !== $this->notifyTopic) {
            $res['NotifyTopic'] = $this->notifyTopic;
        }
        if (null !== $this->interval) {
            $res['Interval'] = $this->interval;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return snapshot
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['RoleName'])) {
            $model->roleName = $map['RoleName'];
        }
        if (isset($map['DestBucket'])) {
            $model->destBucket = $map['DestBucket'];
        }
        if (isset($map['NotifyTopic'])) {
            $model->notifyTopic = $map['NotifyTopic'];
        }
        if (isset($map['Interval'])) {
            $model->interval = $map['Interval'];
        }

        return $model;
    }
}
