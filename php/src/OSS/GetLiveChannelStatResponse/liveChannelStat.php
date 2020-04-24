<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS\GetLiveChannelStatResponse;

use AlibabaCloud\SDK\OSS\OSS\liveChannelStat\audio;
use AlibabaCloud\SDK\OSS\OSS\liveChannelStat\video;
use AlibabaCloud\Tea\Model;

class liveChannelStat extends Model
{
    /**
     * @description Status
     *
     * @var string
     */
    public $status;

    /**
     * @description ConnectedTime
     *
     * @var string
     */
    public $connectedTime;

    /**
     * @description RemoteAddr
     *
     * @var string
     */
    public $remoteAddr;

    /**
     * @description Video
     *
     * @var liveChannelStat.video
     */
    public $video;

    /**
     * @description Audio
     *
     * @var liveChannelStat.audio
     */
    public $audio;
    protected $_name = [
        'status'        => 'Status',
        'connectedTime' => 'ConnectedTime',
        'remoteAddr'    => 'RemoteAddr',
        'video'         => 'Video',
        'audio'         => 'Audio',
    ];

    public function validate()
    {
        Model::validateRequired('video', $this->video, true);
        Model::validateRequired('audio', $this->audio, true);
    }

    public function toMap()
    {
        $res                  = [];
        $res['Status']        = $this->status;
        $res['ConnectedTime'] = $this->connectedTime;
        $res['RemoteAddr']    = $this->remoteAddr;
        $res['Video']         = null !== $this->video ? $this->video->toMap() : null;
        $res['Audio']         = null !== $this->audio ? $this->audio->toMap() : null;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return liveChannelStat
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['Status'])) {
            $model->status = $map['Status'];
        }
        if (isset($map['ConnectedTime'])) {
            $model->connectedTime = $map['ConnectedTime'];
        }
        if (isset($map['RemoteAddr'])) {
            $model->remoteAddr = $map['RemoteAddr'];
        }
        if (isset($map['Video'])) {
            $model->video = liveChannelStat\video::fromMap($map['Video']);
        }
        if (isset($map['Audio'])) {
            $model->audio = liveChannelStat\audio::fromMap($map['Audio']);
        }

        return $model;
    }
}
