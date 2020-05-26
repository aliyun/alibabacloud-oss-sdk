<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS;

use AlibabaCloud\SDK\OSS\OSS\InitiateMultipartUploadResponse\initiateMultipartUploadResult;
use AlibabaCloud\Tea\Model;

class InitiateMultipartUploadResponse extends Model
{
    /**
     * @description x-oss-request-id
     *
     * @var string
     */
    public $requestId;

    /**
     * @description InitiateMultipartUploadResult
     *
     * @var initiateMultipartUploadResult
     */
    public $initiateMultipartUploadResult;
    protected $_name = [
        'requestId'                     => 'x-oss-request-id',
        'initiateMultipartUploadResult' => 'InitiateMultipartUploadResult',
    ];

    public function validate()
    {
        Model::validateRequired('requestId', $this->requestId, true);
        Model::validateRequired('initiateMultipartUploadResult', $this->initiateMultipartUploadResult, true);
    }

    public function toMap()
    {
        $res                                  = [];
        $res['x-oss-request-id']              = $this->requestId;
        $res['InitiateMultipartUploadResult'] = null !== $this->initiateMultipartUploadResult ? $this->initiateMultipartUploadResult->toMap() : null;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return InitiateMultipartUploadResponse
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['x-oss-request-id'])) {
            $model->requestId = $map['x-oss-request-id'];
        }
        if (isset($map['InitiateMultipartUploadResult'])) {
            $model->initiateMultipartUploadResult = initiateMultipartUploadResult::fromMap($map['InitiateMultipartUploadResult']);
        }

        return $model;
    }
}
