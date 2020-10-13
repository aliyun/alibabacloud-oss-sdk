<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS;

use AlibabaCloud\SDK\OSS\OSS\GetServiceResponse\listAllMyBucketsResult;
use AlibabaCloud\Tea\Model;

class GetServiceResponse extends Model
{
    /**
     * @description x-oss-request-id
     *
     * @var string
     */
    public $requestId;

    /**
     * @description ListAllMyBucketsResult
     *
     * @var listAllMyBucketsResult
     */
    public $listAllMyBucketsResult;
    protected $_name = [
        'requestId'              => 'x-oss-request-id',
        'listAllMyBucketsResult' => 'ListAllMyBucketsResult',
    ];

    public function validate()
    {
        Model::validateRequired('requestId', $this->requestId, true);
        Model::validateRequired('listAllMyBucketsResult', $this->listAllMyBucketsResult, true);
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->requestId) {
            $res['x-oss-request-id'] = $this->requestId;
        }
        if (null !== $this->listAllMyBucketsResult) {
            $res['ListAllMyBucketsResult'] = null !== $this->listAllMyBucketsResult ? $this->listAllMyBucketsResult->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetServiceResponse
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['x-oss-request-id'])) {
            $model->requestId = $map['x-oss-request-id'];
        }
        if (isset($map['ListAllMyBucketsResult'])) {
            $model->listAllMyBucketsResult = listAllMyBucketsResult::fromMap($map['ListAllMyBucketsResult']);
        }

        return $model;
    }
}
