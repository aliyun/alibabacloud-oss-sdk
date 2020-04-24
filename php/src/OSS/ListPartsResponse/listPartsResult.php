<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS\ListPartsResponse;

use AlibabaCloud\Tea\Model;

class listPartsResult extends Model
{
    /**
     * @description Bucket
     *
     * @var string
     */
    public $bucket;

    /**
     * @description EncodingType
     *
     * @var string
     */
    public $encodingType;

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
     * @description PartNumberMarker
     *
     * @var string
     */
    public $partNumberMarker;

    /**
     * @description NextPartNumberMarker
     *
     * @var string
     */
    public $nextPartNumberMarker;

    /**
     * @description MaxParts
     *
     * @var string
     */
    public $maxParts;

    /**
     * @description IsTruncated
     *
     * @var string
     */
    public $isTruncated;

    /**
     * @description Part
     *
     * @var array
     */
    public $part;
    protected $_name = [
        'bucket'               => 'Bucket',
        'encodingType'         => 'EncodingType',
        'key'                  => 'Key',
        'uploadId'             => 'UploadId',
        'partNumberMarker'     => 'PartNumberMarker',
        'nextPartNumberMarker' => 'NextPartNumberMarker',
        'maxParts'             => 'MaxParts',
        'isTruncated'          => 'IsTruncated',
        'part'                 => 'Part',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res                         = [];
        $res['Bucket']               = $this->bucket;
        $res['EncodingType']         = $this->encodingType;
        $res['Key']                  = $this->key;
        $res['UploadId']             = $this->uploadId;
        $res['PartNumberMarker']     = $this->partNumberMarker;
        $res['NextPartNumberMarker'] = $this->nextPartNumberMarker;
        $res['MaxParts']             = $this->maxParts;
        $res['IsTruncated']          = $this->isTruncated;
        $res['Part']                 = [];
        if (null !== $this->part && \is_array($this->part)) {
            $n = 0;
            foreach ($this->part as $item) {
                $res['Part'][$n++] = null !== $item ? $item->toMap() : $item;
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return listPartsResult
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['Bucket'])) {
            $model->bucket = $map['Bucket'];
        }
        if (isset($map['EncodingType'])) {
            $model->encodingType = $map['EncodingType'];
        }
        if (isset($map['Key'])) {
            $model->key = $map['Key'];
        }
        if (isset($map['UploadId'])) {
            $model->uploadId = $map['UploadId'];
        }
        if (isset($map['PartNumberMarker'])) {
            $model->partNumberMarker = $map['PartNumberMarker'];
        }
        if (isset($map['NextPartNumberMarker'])) {
            $model->nextPartNumberMarker = $map['NextPartNumberMarker'];
        }
        if (isset($map['MaxParts'])) {
            $model->maxParts = $map['MaxParts'];
        }
        if (isset($map['IsTruncated'])) {
            $model->isTruncated = $map['IsTruncated'];
        }
        if (isset($map['Part'])) {
            if (!empty($map['Part'])) {
                $model->part = [];
                $n           = 0;
                foreach ($map['Part'] as $item) {
                    $model->part[$n++] = null !== $item ? ListPartsResponse\listPartsResult\part::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
