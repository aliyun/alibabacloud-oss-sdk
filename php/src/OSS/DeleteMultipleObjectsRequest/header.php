<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS\DeleteMultipleObjectsRequest;

use AlibabaCloud\Tea\Model;

class header extends Model
{
    /**
     * @description Encoding-type
     *
     * @var string
     */
    public $encodingType;

    /**
     * @description Content-Length
     *
     * @var string
     */
    public $contentLength;

    /**
     * @description Content-MD5
     *
     * @var string
     */
    public $contentMD5;
    protected $_name = [
        'encodingType'  => 'Encoding-type',
        'contentLength' => 'Content-Length',
        'contentMD5'    => 'Content-MD5',
    ];

    public function validate()
    {
        Model::validateRequired('contentLength', $this->contentLength, true);
        Model::validateRequired('contentMD5', $this->contentMD5, true);
    }

    public function toMap()
    {
        $res                   = [];
        $res['Encoding-type']  = $this->encodingType;
        $res['Content-Length'] = $this->contentLength;
        $res['Content-MD5']    = $this->contentMD5;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return header
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['Encoding-type'])) {
            $model->encodingType = $map['Encoding-type'];
        }
        if (isset($map['Content-Length'])) {
            $model->contentLength = $map['Content-Length'];
        }
        if (isset($map['Content-MD5'])) {
            $model->contentMD5 = $map['Content-MD5'];
        }

        return $model;
    }
}
