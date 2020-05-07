<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS;

use AlibabaCloud\SDK\OSS\OSS\CompleteMultipartUploadResponse\completeMultipartUploadResult;
use AlibabaCloud\Tea\Model;

class CompleteMultipartUploadResponse extends Model
{
    /**
     * @description x-oss-request-id
     *
     * @var string
     */
    public $requestId;

    /**
     * @description CompleteMultipartUploadResult
     *
     * @var CompleteMultipartUploadResponse.completeMultipartUploadResult
     */
    public $completeMultipartUploadResult;
    protected $_name = [
        'requestId'                     => 'x-oss-request-id',
        'completeMultipartUploadResult' => 'CompleteMultipartUploadResult',
    ];

    public function validate()
    {
        Model::validateRequired('requestId', $this->requestId, true);
        Model::validateRequired('completeMultipartUploadResult', $this->completeMultipartUploadResult, true);
    }

    public function toMap()
    {
        $res                                  = [];
        $res['x-oss-request-id']              = $this->requestId;
        $res['CompleteMultipartUploadResult'] = null !== $this->completeMultipartUploadResult ? $this->completeMultipartUploadResult->toMap() : null;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CompleteMultipartUploadResponse
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['x-oss-request-id'])) {
            $model->requestId = $map['x-oss-request-id'];
        }
        if (isset($map['CompleteMultipartUploadResult'])) {
            $model->completeMultipartUploadResult = completeMultipartUploadResult::fromMap($map['CompleteMultipartUploadResult']);
        }

        return $model;
    }
}
