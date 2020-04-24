<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS;

use AlibabaCloud\SDK\OSS\OSS\PutBucketRequest\body;
use AlibabaCloud\SDK\OSS\OSS\PutBucketRequest\header;
use AlibabaCloud\Tea\Model;

class PutBucketRequest extends Model
{
    /**
     * @description BucketName
     *
     * @var string
     */
    public $bucketName;

    /**
     * @description Body
     *
     * @var PutBucketRequest.body
     */
    public $body;

    /**
     * @description Header
     *
     * @var PutBucketRequest.header
     */
    public $header;
    protected $_name = [
        'bucketName' => 'BucketName',
        'body'       => 'Body',
        'header'     => 'Header',
    ];

    public function validate()
    {
        Model::validateRequired('bucketName', $this->bucketName, true);
    }

    public function toMap()
    {
        $res               = [];
        $res['BucketName'] = $this->bucketName;
        $res['Body']       = null !== $this->body ? $this->body->toMap() : null;
        $res['Header']     = null !== $this->header ? $this->header->toMap() : null;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return PutBucketRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['BucketName'])) {
            $model->bucketName = $map['BucketName'];
        }
        if (isset($map['Body'])) {
            $model->body = PutBucketRequest\body::fromMap($map['Body']);
        }
        if (isset($map['Header'])) {
            $model->header = PutBucketRequest\header::fromMap($map['Header']);
        }

        return $model;
    }
}
