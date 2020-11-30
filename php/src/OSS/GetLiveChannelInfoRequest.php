<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS;

use AlibabaCloud\Tea\Model;

class GetLiveChannelInfoRequest extends Model
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
    protected $_name = [
        'bucketName'  => 'BucketName',
        'channelName' => 'ChannelName',
    ];

    public function validate()
    {
        Model::validateRequired('bucketName', $this->bucketName, true);
        Model::validateRequired('channelName', $this->channelName, true);
        Model::validatePattern('bucketName', $this->bucketName, '[a-zA-Z0-9-_]+');
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->bucketName) {
            $res['BucketName'] = $this->bucketName;
        }
        if (null !== $this->channelName) {
            $res['ChannelName'] = $this->channelName;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetLiveChannelInfoRequest
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

        return $model;
    }
}
