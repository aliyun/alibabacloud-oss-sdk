<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS;

use AlibabaCloud\SDK\OSS\OSS\CopyObjectRequest\header;
use AlibabaCloud\Tea\Model;

class CopyObjectRequest extends Model
{
    /**
     * @description BucketName
     *
     * @var string
     */
    public $bucketName;

    /**
     * @description DestObjectName
     *
     * @var string
     */
    public $destObjectName;

    /**
     * @description Header
     *
     * @var header
     */
    public $header;
    protected $_name = [
        'bucketName'     => 'BucketName',
        'destObjectName' => 'DestObjectName',
        'header'         => 'Header',
    ];

    public function validate()
    {
        Model::validateRequired('bucketName', $this->bucketName, true);
        Model::validateRequired('destObjectName', $this->destObjectName, true);
        Model::validateRequired('header', $this->header, true);
        Model::validatePattern('bucketName', $this->bucketName, '[a-zA-Z0-9-_]+');
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->bucketName) {
            $res['BucketName'] = $this->bucketName;
        }
        if (null !== $this->destObjectName) {
            $res['DestObjectName'] = $this->destObjectName;
        }
        if (null !== $this->header) {
            $res['Header'] = null !== $this->header ? $this->header->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CopyObjectRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['BucketName'])) {
            $model->bucketName = $map['BucketName'];
        }
        if (isset($map['DestObjectName'])) {
            $model->destObjectName = $map['DestObjectName'];
        }
        if (isset($map['Header'])) {
            $model->header = header::fromMap($map['Header']);
        }

        return $model;
    }
}
