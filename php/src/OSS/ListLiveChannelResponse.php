<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS;

use AlibabaCloud\SDK\OSS\OSS\ListLiveChannelResponse\listLiveChannelResult;
use AlibabaCloud\Tea\Model;

class ListLiveChannelResponse extends Model
{
    /**
     * @description x-oss-request-id
     *
     * @var string
     */
    public $requestId;

    /**
     * @description ListLiveChannelResult
     *
     * @var ListLiveChannelResponse.listLiveChannelResult
     */
    public $listLiveChannelResult;
    protected $_name = [
        'requestId'             => 'x-oss-request-id',
        'listLiveChannelResult' => 'ListLiveChannelResult',
    ];

    public function validate()
    {
        Model::validateRequired('requestId', $this->requestId, true);
        Model::validateRequired('listLiveChannelResult', $this->listLiveChannelResult, true);
    }

    public function toMap()
    {
        $res                          = [];
        $res['x-oss-request-id']      = $this->requestId;
        $res['ListLiveChannelResult'] = null !== $this->listLiveChannelResult ? $this->listLiveChannelResult->toMap() : null;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListLiveChannelResponse
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['x-oss-request-id'])) {
            $model->requestId = $map['x-oss-request-id'];
        }
        if (isset($map['ListLiveChannelResult'])) {
            $model->listLiveChannelResult = listLiveChannelResult::fromMap($map['ListLiveChannelResult']);
        }

        return $model;
    }
}
