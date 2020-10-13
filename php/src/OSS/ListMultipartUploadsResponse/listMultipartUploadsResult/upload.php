<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS\ListMultipartUploadsResponse\listMultipartUploadsResult;

use AlibabaCloud\Tea\Model;

class upload extends Model
{
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

    /**
     * @description Initiated
     *
     * @var string
     */
    public $initiated;
    protected $_name = [
        'key'       => 'Key',
        'uploadId'  => 'UploadId',
        'initiated' => 'Initiated',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->key) {
            $res['Key'] = $this->key;
        }
        if (null !== $this->uploadId) {
            $res['UploadId'] = $this->uploadId;
        }
        if (null !== $this->initiated) {
            $res['Initiated'] = $this->initiated;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return upload
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['Key'])) {
            $model->key = $map['Key'];
        }
        if (isset($map['UploadId'])) {
            $model->uploadId = $map['UploadId'];
        }
        if (isset($map['Initiated'])) {
            $model->initiated = $map['Initiated'];
        }

        return $model;
    }
}
