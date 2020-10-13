<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS\UploadPartCopyRequest;

use AlibabaCloud\Tea\Model;

class filter extends Model
{
    /**
     * @description partNumber
     *
     * @var string
     */
    public $partNumber;

    /**
     * @description uploadId
     *
     * @var string
     */
    public $uploadId;
    protected $_name = [
        'partNumber' => 'partNumber',
        'uploadId'   => 'uploadId',
    ];

    public function validate()
    {
        Model::validateRequired('partNumber', $this->partNumber, true);
        Model::validateRequired('uploadId', $this->uploadId, true);
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->partNumber) {
            $res['partNumber'] = $this->partNumber;
        }
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
        if (isset($map['partNumber'])) {
            $model->partNumber = $map['partNumber'];
        }
        if (isset($map['uploadId'])) {
            $model->uploadId = $map['uploadId'];
        }

        return $model;
    }
}
