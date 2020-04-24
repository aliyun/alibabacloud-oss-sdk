<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS;

use AlibabaCloud\Tea\Model;

class GetBucketLocationResponse extends Model
{
    /**
     * @description x-oss-request-id
     *
     * @var string
     */
    public $requestId;

    /**
     * @description LocationConstraint
     *
     * @var string
     */
    public $locationConstraint;
    protected $_name = [
        'requestId'          => 'x-oss-request-id',
        'locationConstraint' => 'LocationConstraint',
    ];

    public function validate()
    {
        Model::validateRequired('requestId', $this->requestId, true);
        Model::validateRequired('locationConstraint', $this->locationConstraint, true);
    }

    public function toMap()
    {
        $res                       = [];
        $res['x-oss-request-id']   = $this->requestId;
        $res['LocationConstraint'] = $this->locationConstraint;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetBucketLocationResponse
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['x-oss-request-id'])) {
            $model->requestId = $map['x-oss-request-id'];
        }
        if (isset($map['LocationConstraint'])) {
            $model->locationConstraint = $map['LocationConstraint'];
        }

        return $model;
    }
}
