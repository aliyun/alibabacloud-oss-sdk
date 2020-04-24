<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS\ListMultipartUploadsRequest;

use AlibabaCloud\Tea\Model;

class filter extends Model
{
    /**
     * @description delimiter
     *
     * @var string
     */
    public $delimiter;

    /**
     * @description max-uploads
     *
     * @var string
     */
    public $maxUploads;

    /**
     * @description key-marker
     *
     * @var string
     */
    public $keyMarker;

    /**
     * @description prefix
     *
     * @var string
     */
    public $prefix;

    /**
     * @description upload-id-marker
     *
     * @var string
     */
    public $uploadIdMarker;

    /**
     * @description encoding-type
     *
     * @var string
     */
    public $encodingType;
    protected $_name = [
        'delimiter'      => 'delimiter',
        'maxUploads'     => 'max-uploads',
        'keyMarker'      => 'key-marker',
        'prefix'         => 'prefix',
        'uploadIdMarker' => 'upload-id-marker',
        'encodingType'   => 'encoding-type',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res                     = [];
        $res['delimiter']        = $this->delimiter;
        $res['max-uploads']      = $this->maxUploads;
        $res['key-marker']       = $this->keyMarker;
        $res['prefix']           = $this->prefix;
        $res['upload-id-marker'] = $this->uploadIdMarker;
        $res['encoding-type']    = $this->encodingType;

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
        if (isset($map['delimiter'])) {
            $model->delimiter = $map['delimiter'];
        }
        if (isset($map['max-uploads'])) {
            $model->maxUploads = $map['max-uploads'];
        }
        if (isset($map['key-marker'])) {
            $model->keyMarker = $map['key-marker'];
        }
        if (isset($map['prefix'])) {
            $model->prefix = $map['prefix'];
        }
        if (isset($map['upload-id-marker'])) {
            $model->uploadIdMarker = $map['upload-id-marker'];
        }
        if (isset($map['encoding-type'])) {
            $model->encodingType = $map['encoding-type'];
        }

        return $model;
    }
}
