<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS;

use AlibabaCloud\SDK\OSS\OSS\DeleteMultipleObjectsResponse\deleteResult;
use AlibabaCloud\Tea\Model;

class DeleteMultipleObjectsResponse extends Model
{
    /**
     * @description x-oss-request-id
     *
     * @var string
     */
    public $requestId;

    /**
     * @description DeleteResult
     *
     * @var DeleteMultipleObjectsResponse.deleteResult
     */
    public $deleteResult;
    protected $_name = [
        'requestId'    => 'x-oss-request-id',
        'deleteResult' => 'DeleteResult',
    ];

    public function validate()
    {
        Model::validateRequired('requestId', $this->requestId, true);
        Model::validateRequired('deleteResult', $this->deleteResult, true);
    }

    public function toMap()
    {
        $res                     = [];
        $res['x-oss-request-id'] = $this->requestId;
        $res['DeleteResult']     = null !== $this->deleteResult ? $this->deleteResult->toMap() : null;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return DeleteMultipleObjectsResponse
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['x-oss-request-id'])) {
            $model->requestId = $map['x-oss-request-id'];
        }
        if (isset($map['DeleteResult'])) {
            $model->deleteResult = DeleteMultipleObjectsResponse\deleteResult::fromMap($map['DeleteResult']);
        }

        return $model;
    }
}
