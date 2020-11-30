<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS;

use AlibabaCloud\SDK\OSS\OSS\GetObjectRequest\header;
use AlibabaCloud\Tea\Model;

class GetObjectRequest extends Model
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

    /**
     * @description Header
     *
     * @var header
     */
    public $header;
    protected $_name = [
        'bucketName' => 'BucketName',
        'objectName' => 'ObjectName',
        'header'     => 'Header',
    ];

    public function validate()
    {
        Model::validateRequired('bucketName', $this->bucketName, true);
        Model::validateRequired('objectName', $this->objectName, true);
        Model::validatePattern('bucketName', $this->bucketName, '[a-zA-Z0-9-_]+');
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->bucketName) {
            $res['BucketName'] = $this->bucketName;
        }
        if (null !== $this->objectName) {
            $res['ObjectName'] = $this->objectName;
        }
        if (null !== $this->header) {
            $res['Header'] = null !== $this->header ? $this->header->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetObjectRequest
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
        if (isset($map['Header'])) {
            $model->header = header::fromMap($map['Header']);
        }

        return $model;
    }
}
