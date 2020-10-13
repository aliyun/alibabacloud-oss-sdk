<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS;

use AlibabaCloud\SDK\OSS\OSS\GetLiveChannelStatResponse\liveChannelStat;
use AlibabaCloud\Tea\Model;

class GetLiveChannelStatResponse extends Model
{
    /**
     * @description x-oss-request-id
     *
     * @var string
     */
    public $requestId;

    /**
     * @description LiveChannelStat
     *
     * @var liveChannelStat
     */
    public $liveChannelStat;
    protected $_name = [
        'requestId'       => 'x-oss-request-id',
        'liveChannelStat' => 'LiveChannelStat',
    ];

    public function validate()
    {
        Model::validateRequired('requestId', $this->requestId, true);
        Model::validateRequired('liveChannelStat', $this->liveChannelStat, true);
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->requestId) {
            $res['x-oss-request-id'] = $this->requestId;
        }
        if (null !== $this->liveChannelStat) {
            $res['LiveChannelStat'] = null !== $this->liveChannelStat ? $this->liveChannelStat->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetLiveChannelStatResponse
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['x-oss-request-id'])) {
            $model->requestId = $map['x-oss-request-id'];
        }
        if (isset($map['LiveChannelStat'])) {
            $model->liveChannelStat = liveChannelStat::fromMap($map['LiveChannelStat']);
        }

        return $model;
    }
}
