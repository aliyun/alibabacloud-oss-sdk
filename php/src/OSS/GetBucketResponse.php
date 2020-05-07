<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS;

use AlibabaCloud\SDK\OSS\OSS\GetBucketResponse\listBucketResult;
use AlibabaCloud\Tea\Model;

class GetBucketResponse extends Model
{
    /**
     * @description x-oss-request-id
     *
     * @var string
     */
    public $requestId;

    /**
     * @description ListBucketResult
     *
     * @var GetBucketResponse.listBucketResult
     */
    public $listBucketResult;
    protected $_name = [
        'requestId'        => 'x-oss-request-id',
        'listBucketResult' => 'ListBucketResult',
    ];

    public function validate()
    {
        Model::validateRequired('requestId', $this->requestId, true);
        Model::validateRequired('listBucketResult', $this->listBucketResult, true);
    }

    public function toMap()
    {
        $res                     = [];
        $res['x-oss-request-id'] = $this->requestId;
        $res['ListBucketResult'] = null !== $this->listBucketResult ? $this->listBucketResult->toMap() : null;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetBucketResponse
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['x-oss-request-id'])) {
            $model->requestId = $map['x-oss-request-id'];
        }
        if (isset($map['ListBucketResult'])) {
            $model->listBucketResult = listBucketResult::fromMap($map['ListBucketResult']);
        }

        return $model;
    }
}
