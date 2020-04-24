<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS;

use AlibabaCloud\Tea\Model;

class DeleteBucketLifecycleResponse extends Model
{
    /**
     * @description x-oss-request-id
     *
     * @var string
     */
    public $requestId;
    protected $_name = [
        'requestId' => 'x-oss-request-id',
    ];

    public function validate()
    {
        Model::validateRequired('requestId', $this->requestId, true);
    }

    public function toMap()
    {
        $res                     = [];
        $res['x-oss-request-id'] = $this->requestId;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return DeleteBucketLifecycleResponse
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['x-oss-request-id'])) {
            $model->requestId = $map['x-oss-request-id'];
        }

        return $model;
    }
}
