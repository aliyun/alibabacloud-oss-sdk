<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS;

use AlibabaCloud\SDK\OSS\OSS\ListMultipartUploadsResponse\listMultipartUploadsResult;
use AlibabaCloud\Tea\Model;

class ListMultipartUploadsResponse extends Model
{
    /**
     * @description x-oss-request-id
     *
     * @var string
     */
    public $requestId;

    /**
     * @description ListMultipartUploadsResult
     *
     * @var ListMultipartUploadsResponse.listMultipartUploadsResult
     */
    public $listMultipartUploadsResult;
    protected $_name = [
        'requestId'                  => 'x-oss-request-id',
        'listMultipartUploadsResult' => 'ListMultipartUploadsResult',
    ];

    public function validate()
    {
        Model::validateRequired('requestId', $this->requestId, true);
        Model::validateRequired('listMultipartUploadsResult', $this->listMultipartUploadsResult, true);
    }

    public function toMap()
    {
        $res                               = [];
        $res['x-oss-request-id']           = $this->requestId;
        $res['ListMultipartUploadsResult'] = null !== $this->listMultipartUploadsResult ? $this->listMultipartUploadsResult->toMap() : null;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListMultipartUploadsResponse
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['x-oss-request-id'])) {
            $model->requestId = $map['x-oss-request-id'];
        }
        if (isset($map['ListMultipartUploadsResult'])) {
            $model->listMultipartUploadsResult = listMultipartUploadsResult::fromMap($map['ListMultipartUploadsResult']);
        }

        return $model;
    }
}
