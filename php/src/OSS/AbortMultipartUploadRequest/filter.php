<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS\AbortMultipartUploadRequest;

use AlibabaCloud\Tea\Model;

class filter extends Model
{
    /**
     * @description uploadId
     *
     * @var string
     */
    public $uploadId;
    protected $_name = [
        'uploadId' => 'uploadId',
    ];

    public function validate()
    {
        Model::validateRequired('uploadId', $this->uploadId, true);
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->uploadId) {
            $res['uploadId'] = $this->uploadId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return filter
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['uploadId'])) {
            $model->uploadId = $map['uploadId'];
        }

        return $model;
    }
}
