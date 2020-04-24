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
     * @var ListPartsResponse.listPartsResult
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
        $res                     = [];
        $res['x-oss-request-id'] = $this->requestId;
        $res['ListPartsResult']  = null !== $this->listPartsResult ? $this->listPartsResult->toMap() : null;

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
            $model->listPartsResult = ListPartsResponse\listPartsResult::fromMap($map['ListPartsResult']);
        }

        return $model;
    }
}
