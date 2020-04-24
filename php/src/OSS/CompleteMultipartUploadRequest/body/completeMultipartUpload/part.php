<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS\CompleteMultipartUploadRequest\body\completeMultipartUpload;

use AlibabaCloud\Tea\Model;

class part extends Model
{
    /**
     * @description PartNumber
     *
     * @var string
     */
    public $partNumber;

    /**
     * @description ETag
     *
     * @var string
     */
    public $eTag;
    protected $_name = [
        'partNumber' => 'PartNumber',
        'eTag'       => 'ETag',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res               = [];
        $res['PartNumber'] = $this->partNumber;
        $res['ETag']       = $this->eTag;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return part
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['PartNumber'])) {
            $model->partNumber = $map['PartNumber'];
        }
        if (isset($map['ETag'])) {
            $model->eTag = $map['ETag'];
        }

        return $model;
    }
}
