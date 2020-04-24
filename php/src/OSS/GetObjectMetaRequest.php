<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS;

use AlibabaCloud\Tea\Model;

class GetObjectMetaRequest extends Model
{
    /**
     * @description BucketName
     *
     * @var string
     */
    public $bucketName;

    /**
     * @description ObjectName
     *
     * @var string
     */
    public $objectName;
    protected $_name = [
        'bucketName' => 'BucketName',
        'objectName' => 'ObjectName',
    ];

    public function validate()
    {
        Model::validateRequired('bucketName', $this->bucketName, true);
        Model::validateRequired('objectName', $this->objectName, true);
    }

    public function toMap()
    {
        $res               = [];
        $res['BucketName'] = $this->bucketName;
        $res['ObjectName'] = $this->objectName;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetObjectMetaRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['BucketName'])) {
            $model->bucketName = $map['BucketName'];
        }
        if (isset($map['ObjectName'])) {
            $model->objectName = $map['ObjectName'];
        }

        return $model;
    }
}
