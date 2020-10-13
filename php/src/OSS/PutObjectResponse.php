<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS;

use AlibabaCloud\Tea\Model;

class PutObjectResponse extends Model
{
    /**
     * @description x-oss-request-id
     *
     * @var string
     */
    public $requestId;

    /**
     * @description x-oss-hash-crc64ecma
     *
     * @var string
     */
    public $hashCrc64ecma;

    /**
     * @description x-oss-server-time
     *
     * @var string
     */
    public $serverTime;

    /**
     * @description x-oss-bucket-version
     *
     * @var string
     */
    public $bucketVersion;
    protected $_name = [
        'requestId'     => 'x-oss-request-id',
        'hashCrc64ecma' => 'x-oss-hash-crc64ecma',
        'serverTime'    => 'x-oss-server-time',
        'bucketVersion' => 'x-oss-bucket-version',
    ];

    public function validate()
    {
        Model::validateRequired('requestId', $this->requestId, true);
        Model::validateRequired('hashCrc64ecma', $this->hashCrc64ecma, true);
        Model::validateRequired('serverTime', $this->serverTime, true);
        Model::validateRequired('bucketVersion', $this->bucketVersion, true);
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->requestId) {
            $res['x-oss-request-id'] = $this->requestId;
        }
        if (null !== $this->hashCrc64ecma) {
            $res['x-oss-hash-crc64ecma'] = $this->hashCrc64ecma;
        }
        if (null !== $this->serverTime) {
            $res['x-oss-server-time'] = $this->serverTime;
        }
        if (null !== $this->bucketVersion) {
            $res['x-oss-bucket-version'] = $this->bucketVersion;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return PutObjectResponse
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['x-oss-request-id'])) {
            $model->requestId = $map['x-oss-request-id'];
        }
        if (isset($map['x-oss-hash-crc64ecma'])) {
            $model->hashCrc64ecma = $map['x-oss-hash-crc64ecma'];
        }
        if (isset($map['x-oss-server-time'])) {
            $model->serverTime = $map['x-oss-server-time'];
        }
        if (isset($map['x-oss-bucket-version'])) {
            $model->bucketVersion = $map['x-oss-bucket-version'];
        }

        return $model;
    }
}
