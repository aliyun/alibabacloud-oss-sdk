<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS\PutLiveChannelRequest\body\liveChannelConfiguration;

use AlibabaCloud\Tea\Model;

class target extends Model
{
    /**
     * @description Type
     *
     * @var string
     */
    public $type;

    /**
     * @description FragDuration
     *
     * @var string
     */
    public $fragDuration;

    /**
     * @description FragCount
     *
     * @var string
     */
    public $fragCount;

    /**
     * @description PlaylistName
     *
     * @var string
     */
    public $playlistName;
    protected $_name = [
        'type'         => 'Type',
        'fragDuration' => 'FragDuration',
        'fragCount'    => 'FragCount',
        'playlistName' => 'PlaylistName',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->type) {
            $res['Type'] = $this->type;
        }
        if (null !== $this->fragDuration) {
            $res['FragDuration'] = $this->fragDuration;
        }
        if (null !== $this->fragCount) {
            $res['FragCount'] = $this->fragCount;
        }
        if (null !== $this->playlistName) {
            $res['PlaylistName'] = $this->playlistName;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return target
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['Type'])) {
            $model->type = $map['Type'];
        }
        if (isset($map['FragDuration'])) {
            $model->fragDuration = $map['FragDuration'];
        }
        if (isset($map['FragCount'])) {
            $model->fragCount = $map['FragCount'];
        }
        if (isset($map['PlaylistName'])) {
            $model->playlistName = $map['PlaylistName'];
        }

        return $model;
    }
}
