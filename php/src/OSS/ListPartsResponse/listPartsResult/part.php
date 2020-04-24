<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS\ListPartsResponse\listPartsResult;

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
     * @description LastModified
     *
     * @var string
     */
    public $lastModified;

    /**
     * @description ETag
     *
     * @var string
     */
    public $eTag;

    /**
     * @description Size
     *
     * @var string
     */
    public $size;
    protected $_name = [
        'partNumber'   => 'PartNumber',
        'lastModified' => 'LastModified',
        'eTag'         => 'ETag',
        'size'         => 'Size',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res                 = [];
        $res['PartNumber']   = $this->partNumber;
        $res['LastModified'] = $this->lastModified;
        $res['ETag']         = $this->eTag;
        $res['Size']         = $this->size;

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
        if (isset($map['LastModified'])) {
            $model->lastModified = $map['LastModified'];
        }
        if (isset($map['ETag'])) {
            $model->eTag = $map['ETag'];
        }
        if (isset($map['Size'])) {
            $model->size = $map['Size'];
        }

        return $model;
    }
}
