<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS;

use AlibabaCloud\SDK\OSS\OSS\PostVodPlaylistRequest\filter;
use AlibabaCloud\Tea\Model;

class PostVodPlaylistRequest extends Model
{
    /**
     * @description BucketName
     *
     * @var string
     */
    public $bucketName;

    /**
     * @description ChannelName
     *
     * @var string
     */
    public $channelName;

    /**
     * @description PlaylistName
     *
     * @var string
     */
    public $playlistName;

    /**
     * @description Filter
     *
     * @var PostVodPlaylistRequest.filter
     */
    public $filter;
    protected $_name = [
        'bucketName'   => 'BucketName',
        'channelName'  => 'ChannelName',
        'playlistName' => 'PlaylistName',
        'filter'       => 'Filter',
    ];

    public function validate()
    {
        Model::validateRequired('bucketName', $this->bucketName, true);
        Model::validateRequired('channelName', $this->channelName, true);
        Model::validateRequired('playlistName', $this->playlistName, true);
        Model::validateRequired('filter', $this->filter, true);
    }

    public function toMap()
    {
        $res                 = [];
        $res['BucketName']   = $this->bucketName;
        $res['ChannelName']  = $this->channelName;
        $res['PlaylistName'] = $this->playlistName;
        $res['Filter']       = null !== $this->filter ? $this->filter->toMap() : null;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return PostVodPlaylistRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['BucketName'])) {
            $model->bucketName = $map['BucketName'];
        }
        if (isset($map['ChannelName'])) {
            $model->channelName = $map['ChannelName'];
        }
        if (isset($map['PlaylistName'])) {
            $model->playlistName = $map['PlaylistName'];
        }
        if (isset($map['Filter'])) {
            $model->filter = filter::fromMap($map['Filter']);
        }

        return $model;
    }
}
