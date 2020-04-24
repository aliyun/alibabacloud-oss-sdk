<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS;

use AlibabaCloud\Tea\Model;

class CallbackRequest extends Model
{
    /**
     * @description BucketName
     *
     * @var string
     */
    public $bucketName;
    protected $_name = [
        'bucketName' => 'BucketName',
    ];

    public function validate()
    {
        Model::validateRequired('bucketName', $this->bucketName, true);
    }

    public function toMap()
    {
        $res               = [];
        $res['BucketName'] = $this->bucketName;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CallbackRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['BucketName'])) {
            $model->bucketName = $map['BucketName'];
        }

        return $model;
    }
}
