<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS;

use AlibabaCloud\SDK\OSS\OSS\PutLiveChannelResponse\createLiveChannelResult;
use AlibabaCloud\Tea\Model;

class PutLiveChannelResponse extends Model
{
    /**
     * @description x-oss-request-id
     *
     * @var string
     */
    public $requestId;

    /**
     * @description CreateLiveChannelResult
     *
     * @var createLiveChannelResult
     */
    public $createLiveChannelResult;
    protected $_name = [
        'requestId'               => 'x-oss-request-id',
        'createLiveChannelResult' => 'CreateLiveChannelResult',
    ];

    public function validate()
    {
        Model::validateRequired('requestId', $this->requestId, true);
        Model::validateRequired('createLiveChannelResult', $this->createLiveChannelResult, true);
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->requestId) {
            $res['x-oss-request-id'] = $this->requestId;
        }
        if (null !== $this->createLiveChannelResult) {
            $res['CreateLiveChannelResult'] = null !== $this->createLiveChannelResult ? $this->createLiveChannelResult->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return PutLiveChannelResponse
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['x-oss-request-id'])) {
            $model->requestId = $map['x-oss-request-id'];
        }
        if (isset($map['CreateLiveChannelResult'])) {
            $model->createLiveChannelResult = createLiveChannelResult::fromMap($map['CreateLiveChannelResult']);
        }

        return $model;
    }
}
