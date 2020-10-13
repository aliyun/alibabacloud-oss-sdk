<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS\UploadPartCopyResponse;

use AlibabaCloud\Tea\Model;

class copyPartResult extends Model
{
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
    protected $_name = [
        'lastModified' => 'LastModified',
        'eTag'         => 'ETag',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->lastModified) {
            $res['LastModified'] = $this->lastModified;
        }
        if (null !== $this->eTag) {
            $res['ETag'] = $this->eTag;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return copyPartResult
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['LastModified'])) {
            $model->lastModified = $map['LastModified'];
        }
        if (isset($map['ETag'])) {
            $model->eTag = $map['ETag'];
        }

        return $model;
    }
}
