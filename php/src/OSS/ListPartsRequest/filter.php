<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS\ListPartsRequest;

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
     * @description max-parts
     *
     * @var int
     */
    public $maxParts;

    /**
     * @description part-number-marker
     *
     * @var int
     */
    public $partNumberMarker;

    /**
     * @description Encoding-type
     *
     * @var string
     */
    public $encodingType;
    protected $_name = [
        'uploadId'         => 'uploadId',
        'maxParts'         => 'max-parts',
        'partNumberMarker' => 'part-number-marker',
        'encodingType'     => 'Encoding-type',
    ];

    public function validate()
    {
        Model::validateRequired('uploadId', $this->uploadId, true);
    }

    public function toMap()
    {
        $res                       = [];
        $res['uploadId']           = $this->uploadId;
        $res['max-parts']          = $this->maxParts;
        $res['part-number-marker'] = $this->partNumberMarker;
        $res['Encoding-type']      = $this->encodingType;

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
        if (isset($map['max-parts'])) {
            $model->maxParts = $map['max-parts'];
        }
        if (isset($map['part-number-marker'])) {
            $model->partNumberMarker = $map['part-number-marker'];
        }
        if (isset($map['Encoding-type'])) {
            $model->encodingType = $map['Encoding-type'];
        }

        return $model;
    }
}
