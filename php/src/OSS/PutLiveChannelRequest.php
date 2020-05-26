<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS;

use AlibabaCloud\SDK\OSS\OSS\PutLiveChannelRequest\body;
use AlibabaCloud\Tea\Model;

class PutLiveChannelRequest extends Model
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
     * @description Body
     *
     * @var body
     */
    public $body;
    protected $_name = [
        'bucketName'  => 'BucketName',
        'channelName' => 'ChannelName',
        'body'        => 'Body',
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
        $res['Body']        = null !== $this->body ? $this->body->toMap() : null;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return PutLiveChannelRequest
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
        if (isset($map['Body'])) {
            $model->body = body::fromMap($map['Body']);
        }

        return $model;
    }
}
