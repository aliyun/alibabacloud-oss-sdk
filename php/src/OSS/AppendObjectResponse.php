<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS;

use AlibabaCloud\Tea\Model;

class AppendObjectResponse extends Model
{
    /**
     * @description x-oss-request-id
     *
     * @var string
     */
    public $requestId;

    /**
     * @description x-oss-next-append-position
     *
     * @var string
     */
    public $nextAppendPosition;

    /**
     * @description x-oss-hash-crc64ecma
     *
     * @var string
     */
    public $hashCrc64ecma;
    protected $_name = [
        'requestId'          => 'x-oss-request-id',
        'nextAppendPosition' => 'x-oss-next-append-position',
        'hashCrc64ecma'      => 'x-oss-hash-crc64ecma',
    ];

    public function validate()
    {
        Model::validateRequired('requestId', $this->requestId, true);
        Model::validateRequired('nextAppendPosition', $this->nextAppendPosition, true);
        Model::validateRequired('hashCrc64ecma', $this->hashCrc64ecma, true);
    }

    public function toMap()
    {
        $res                               = [];
        $res['x-oss-request-id']           = $this->requestId;
        $res['x-oss-next-append-position'] = $this->nextAppendPosition;
        $res['x-oss-hash-crc64ecma']       = $this->hashCrc64ecma;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return AppendObjectResponse
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['x-oss-request-id'])) {
            $model->requestId = $map['x-oss-request-id'];
        }
        if (isset($map['x-oss-next-append-position'])) {
            $model->nextAppendPosition = $map['x-oss-next-append-position'];
        }
        if (isset($map['x-oss-hash-crc64ecma'])) {
            $model->hashCrc64ecma = $map['x-oss-hash-crc64ecma'];
        }

        return $model;
    }
}
