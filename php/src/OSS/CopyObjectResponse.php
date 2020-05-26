<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS;

use AlibabaCloud\SDK\OSS\OSS\CopyObjectResponse\copyObjectResult;
use AlibabaCloud\Tea\Model;

class CopyObjectResponse extends Model
{
    /**
     * @description x-oss-request-id
     *
     * @var string
     */
    public $requestId;

    /**
     * @description CopyObjectResult
     *
     * @var copyObjectResult
     */
    public $copyObjectResult;
    protected $_name = [
        'requestId'        => 'x-oss-request-id',
        'copyObjectResult' => 'CopyObjectResult',
    ];

    public function validate()
    {
        Model::validateRequired('requestId', $this->requestId, true);
        Model::validateRequired('copyObjectResult', $this->copyObjectResult, true);
    }

    public function toMap()
    {
        $res                     = [];
        $res['x-oss-request-id'] = $this->requestId;
        $res['CopyObjectResult'] = null !== $this->copyObjectResult ? $this->copyObjectResult->toMap() : null;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CopyObjectResponse
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['x-oss-request-id'])) {
            $model->requestId = $map['x-oss-request-id'];
        }
        if (isset($map['CopyObjectResult'])) {
            $model->copyObjectResult = copyObjectResult::fromMap($map['CopyObjectResult']);
        }

        return $model;
    }
}
