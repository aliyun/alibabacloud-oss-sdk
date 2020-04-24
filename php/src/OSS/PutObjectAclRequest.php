<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS;

use AlibabaCloud\SDK\OSS\OSS\PutObjectAclRequest\header;
use AlibabaCloud\Tea\Model;

class PutObjectAclRequest extends Model
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
     * @var PutObjectAclRequest.header
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
        Model::validateRequired('header', $this->header, true);
    }

    public function toMap()
    {
        $res               = [];
        $res['BucketName'] = $this->bucketName;
        $res['ObjectName'] = $this->objectName;
        $res['Header']     = null !== $this->header ? $this->header->toMap() : null;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return PutObjectAclRequest
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
            $model->header = PutObjectAclRequest\header::fromMap($map['Header']);
        }

        return $model;
    }
}
