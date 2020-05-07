<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS;

use AlibabaCloud\SDK\OSS\OSS\UploadPartCopyResponse\copyPartResult;
use AlibabaCloud\Tea\Model;

class UploadPartCopyResponse extends Model
{
    /**
     * @description x-oss-request-id
     *
     * @var string
     */
    public $requestId;

    /**
     * @description CopyPartResult
     *
     * @var UploadPartCopyResponse.copyPartResult
     */
    public $copyPartResult;
    protected $_name = [
        'requestId'      => 'x-oss-request-id',
        'copyPartResult' => 'CopyPartResult',
    ];

    public function validate()
    {
        Model::validateRequired('requestId', $this->requestId, true);
        Model::validateRequired('copyPartResult', $this->copyPartResult, true);
    }

    public function toMap()
    {
        $res                     = [];
        $res['x-oss-request-id'] = $this->requestId;
        $res['CopyPartResult']   = null !== $this->copyPartResult ? $this->copyPartResult->toMap() : null;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UploadPartCopyResponse
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['x-oss-request-id'])) {
            $model->requestId = $map['x-oss-request-id'];
        }
        if (isset($map['CopyPartResult'])) {
            $model->copyPartResult = copyPartResult::fromMap($map['CopyPartResult']);
        }

        return $model;
    }
}
