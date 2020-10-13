<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS;

use AlibabaCloud\SDK\OSS\OSS\GetLiveChannelInfoResponse\liveChannelConfiguration;
use AlibabaCloud\Tea\Model;

class GetLiveChannelInfoResponse extends Model
{
    /**
     * @description x-oss-request-id
     *
     * @var string
     */
    public $requestId;

    /**
     * @description LiveChannelConfiguration
     *
     * @var liveChannelConfiguration
     */
    public $liveChannelConfiguration;
    protected $_name = [
        'requestId'                => 'x-oss-request-id',
        'liveChannelConfiguration' => 'LiveChannelConfiguration',
    ];

    public function validate()
    {
        Model::validateRequired('requestId', $this->requestId, true);
        Model::validateRequired('liveChannelConfiguration', $this->liveChannelConfiguration, true);
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->requestId) {
            $res['x-oss-request-id'] = $this->requestId;
        }
        if (null !== $this->liveChannelConfiguration) {
            $res['LiveChannelConfiguration'] = null !== $this->liveChannelConfiguration ? $this->liveChannelConfiguration->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetLiveChannelInfoResponse
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['x-oss-request-id'])) {
            $model->requestId = $map['x-oss-request-id'];
        }
        if (isset($map['LiveChannelConfiguration'])) {
            $model->liveChannelConfiguration = liveChannelConfiguration::fromMap($map['LiveChannelConfiguration']);
        }

        return $model;
    }
}
