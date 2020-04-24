<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS\CompleteMultipartUploadResponse;

use AlibabaCloud\Tea\Model;

class completeMultipartUploadResult extends Model
{
    /**
     * @description Bucket
     *
     * @var string
     */
    public $bucket;

    /**
     * @description ETag
     *
     * @var string
     */
    public $eTag;

    /**
     * @description Location
     *
     * @var string
     */
    public $location;

    /**
     * @description Key
     *
     * @var string
     */
    public $key;

    /**
     * @description EncodingType
     *
     * @var string
     */
    public $encodingType;
    protected $_name = [
        'bucket'       => 'Bucket',
        'eTag'         => 'ETag',
        'location'     => 'Location',
        'key'          => 'Key',
        'encodingType' => 'EncodingType',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res                 = [];
        $res['Bucket']       = $this->bucket;
        $res['ETag']         = $this->eTag;
        $res['Location']     = $this->location;
        $res['Key']          = $this->key;
        $res['EncodingType'] = $this->encodingType;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return completeMultipartUploadResult
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['Bucket'])) {
            $model->bucket = $map['Bucket'];
        }
        if (isset($map['ETag'])) {
            $model->eTag = $map['ETag'];
        }
        if (isset($map['Location'])) {
            $model->location = $map['Location'];
        }
        if (isset($map['Key'])) {
            $model->key = $map['Key'];
        }
        if (isset($map['EncodingType'])) {
            $model->encodingType = $map['EncodingType'];
        }

        return $model;
    }
}
