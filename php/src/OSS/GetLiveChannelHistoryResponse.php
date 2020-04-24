<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS;

use AlibabaCloud\SDK\OSS\OSS\GetLiveChannelHistoryResponse\liveChannelHistory;
use AlibabaCloud\Tea\Model;

class GetLiveChannelHistoryResponse extends Model
{
    /**
     * @description x-oss-request-id
     *
     * @var string
     */
    public $requestId;

    /**
     * @description LiveChannelHistory
     *
     * @var GetLiveChannelHistoryResponse.liveChannelHistory
     */
    public $liveChannelHistory;
    protected $_name = [
        'requestId'          => 'x-oss-request-id',
        'liveChannelHistory' => 'LiveChannelHistory',
    ];

    public function validate()
    {
        Model::validateRequired('requestId', $this->requestId, true);
        Model::validateRequired('liveChannelHistory', $this->liveChannelHistory, true);
    }

    public function toMap()
    {
        $res                       = [];
        $res['x-oss-request-id']   = $this->requestId;
        $res['LiveChannelHistory'] = null !== $this->liveChannelHistory ? $this->liveChannelHistory->toMap() : null;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetLiveChannelHistoryResponse
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['x-oss-request-id'])) {
            $model->requestId = $map['x-oss-request-id'];
        }
        if (isset($map['LiveChannelHistory'])) {
            $model->liveChannelHistory = GetLiveChannelHistoryResponse\liveChannelHistory::fromMap($map['LiveChannelHistory']);
        }

        return $model;
    }
}
