<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS;

use AlibabaCloud\Tea\Model;

class DeleteLiveChannelRequest extends Model
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
    }

    public function toMap()
    {
        $res                = [];
        $res['BucketName']  = $this->bucketName;
        $res['ChannelName'] = $this->channelName;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return DeleteLiveChannelRequest
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
