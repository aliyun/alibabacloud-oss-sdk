<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS;

use AlibabaCloud\SDK\OSS\OSS\ListPartsResponse\listPartsResult;
use AlibabaCloud\Tea\Model;

class ListPartsResponse extends Model
{
    /**
     * @description x-oss-request-id
     *
     * @var string
     */
    public $requestId;

    /**
     * @description ListPartsResult
     *
     * @var listPartsResult
     */
    public $listPartsResult;
    protected $_name = [
        'requestId'       => 'x-oss-request-id',
        'listPartsResult' => 'ListPartsResult',
    ];

    public function validate()
    {
        Model::validateRequired('requestId', $this->requestId, true);
        Model::validateRequired('listPartsResult', $this->listPartsResult, true);
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->requestId) {
            $res['x-oss-request-id'] = $this->requestId;
        }
        if (null !== $this->listPartsResult) {
            $res['ListPartsResult'] = null !== $this->listPartsResult ? $this->listPartsResult->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListPartsResponse
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['x-oss-request-id'])) {
            $model->requestId = $map['x-oss-request-id'];
        }
        if (isset($map['ListPartsResult'])) {
            $model->listPartsResult = listPartsResult::fromMap($map['ListPartsResult']);
        }

        return $model;
    }
}
