<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS\ListMultipartUploadsResponse;

use AlibabaCloud\Tea\Model;

class listMultipartUploadsResult extends Model
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
     * @description KeyMarker
     *
     * @var string
     */
    public $keyMarker;

    /**
     * @description UploadIdMarker
     *
     * @var string
     */
    public $uploadIdMarker;

    /**
     * @description NextKeyMarker
     *
     * @var string
     */
    public $nextKeyMarker;

    /**
     * @description NextUploadIdMarker
     *
     * @var string
     */
    public $nextUploadIdMarker;

    /**
     * @description Delimiter
     *
     * @var string
     */
    public $delimiter;

    /**
     * @description MaxUploads
     *
     * @var string
     */
    public $maxUploads;

    /**
     * @description IsTruncated
     *
     * @var string
     */
    public $isTruncated;

    /**
     * @description Upload
     *
     * @var array
     */
    public $upload;
    protected $_name = [
        'bucket'             => 'Bucket',
        'encodingType'       => 'EncodingType',
        'keyMarker'          => 'KeyMarker',
        'uploadIdMarker'     => 'UploadIdMarker',
        'nextKeyMarker'      => 'NextKeyMarker',
        'nextUploadIdMarker' => 'NextUploadIdMarker',
        'delimiter'          => 'Delimiter',
        'maxUploads'         => 'MaxUploads',
        'isTruncated'        => 'IsTruncated',
        'upload'             => 'Upload',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res                       = [];
        $res['Bucket']             = $this->bucket;
        $res['EncodingType']       = $this->encodingType;
        $res['KeyMarker']          = $this->keyMarker;
        $res['UploadIdMarker']     = $this->uploadIdMarker;
        $res['NextKeyMarker']      = $this->nextKeyMarker;
        $res['NextUploadIdMarker'] = $this->nextUploadIdMarker;
        $res['Delimiter']          = $this->delimiter;
        $res['MaxUploads']         = $this->maxUploads;
        $res['IsTruncated']        = $this->isTruncated;
        $res['Upload']             = [];
        if (null !== $this->upload && \is_array($this->upload)) {
            $n = 0;
            foreach ($this->upload as $item) {
                $res['Upload'][$n++] = null !== $item ? $item->toMap() : $item;
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return listMultipartUploadsResult
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
        if (isset($map['KeyMarker'])) {
            $model->keyMarker = $map['KeyMarker'];
        }
        if (isset($map['UploadIdMarker'])) {
            $model->uploadIdMarker = $map['UploadIdMarker'];
        }
        if (isset($map['NextKeyMarker'])) {
            $model->nextKeyMarker = $map['NextKeyMarker'];
        }
        if (isset($map['NextUploadIdMarker'])) {
            $model->nextUploadIdMarker = $map['NextUploadIdMarker'];
        }
        if (isset($map['Delimiter'])) {
            $model->delimiter = $map['Delimiter'];
        }
        if (isset($map['MaxUploads'])) {
            $model->maxUploads = $map['MaxUploads'];
        }
        if (isset($map['IsTruncated'])) {
            $model->isTruncated = $map['IsTruncated'];
        }
        if (isset($map['Upload'])) {
            if (!empty($map['Upload'])) {
                $model->upload = [];
                $n             = 0;
                foreach ($map['Upload'] as $item) {
                    $model->upload[$n++] = null !== $item ? ListMultipartUploadsResponse\listMultipartUploadsResult\upload::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
