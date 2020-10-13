<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS\GetLiveChannelStatResponse;

use AlibabaCloud\SDK\OSS\OSS\GetLiveChannelStatResponse\liveChannelStat\audio;
use AlibabaCloud\SDK\OSS\OSS\GetLiveChannelStatResponse\liveChannelStat\video;
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
     * @var video
     */
    public $video;

    /**
     * @description Audio
     *
     * @var audio
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
        $res = [];
        if (null !== $this->status) {
            $res['Status'] = $this->status;
        }
        if (null !== $this->connectedTime) {
            $res['ConnectedTime'] = $this->connectedTime;
        }
        if (null !== $this->remoteAddr) {
            $res['RemoteAddr'] = $this->remoteAddr;
        }
        if (null !== $this->video) {
            $res['Video'] = null !== $this->video ? $this->video->toMap() : null;
        }
        if (null !== $this->audio) {
            $res['Audio'] = null !== $this->audio ? $this->audio->toMap() : null;
        }

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
            $model->video = video::fromMap($map['Video']);
        }
        if (isset($map['Audio'])) {
            $model->audio = audio::fromMap($map['Audio']);
        }

        return $model;
    }
}
