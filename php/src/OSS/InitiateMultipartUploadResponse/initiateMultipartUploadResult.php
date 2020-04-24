<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS\InitiateMultipartUploadResponse;

use AlibabaCloud\Tea\Model;

class initiateMultipartUploadResult extends Model
{
    /**
     * @description Bucket
     *
     * @var string
     */
    public $bucket;

    /**
     * @description Key
     *
     * @var string
     */
    public $key;

    /**
     * @description UploadId
     *
     * @var string
     */
    public $uploadId;
    protected $_name = [
        'bucket'   => 'Bucket',
        'key'      => 'Key',
        'uploadId' => 'UploadId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res             = [];
        $res['Bucket']   = $this->bucket;
        $res['Key']      = $this->key;
        $res['UploadId'] = $this->uploadId;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return initiateMultipartUploadResult
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['Bucket'])) {
            $model->bucket = $map['Bucket'];
        }
        if (isset($map['Key'])) {
            $model->key = $map['Key'];
        }
        if (isset($map['UploadId'])) {
            $model->uploadId = $map['UploadId'];
        }

        return $model;
    }
}
