<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS\CompleteMultipartUploadRequest;

use AlibabaCloud\Tea\Model;

class filter extends Model
{
    /**
     * @description uploadId
     *
     * @var string
     */
    public $uploadId;

    /**
     * @description Encoding-type
     *
     * @var string
     */
    public $encodingType;
    protected $_name = [
        'uploadId'     => 'uploadId',
        'encodingType' => 'Encoding-type',
    ];

    public function validate()
    {
        Model::validateRequired('uploadId', $this->uploadId, true);
    }

    public function toMap()
    {
        $res                  = [];
        $res['uploadId']      = $this->uploadId;
        $res['Encoding-type'] = $this->encodingType;

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
        if (isset($map['Encoding-type'])) {
            $model->encodingType = $map['Encoding-type'];
        }

        return $model;
    }
}
