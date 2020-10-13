<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS\InitiateMultipartUploadRequest;

use AlibabaCloud\Tea\Model;

class filter extends Model
{
    /**
     * @description encoding-type
     *
     * @var string
     */
    public $encodingType;
    protected $_name = [
        'encodingType' => 'encoding-type',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->encodingType) {
            $res['encoding-type'] = $this->encodingType;
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
        if (isset($map['encoding-type'])) {
            $model->encodingType = $map['encoding-type'];
        }

        return $model;
    }
}
