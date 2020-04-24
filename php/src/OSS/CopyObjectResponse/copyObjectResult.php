<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS\CopyObjectResponse;

use AlibabaCloud\Tea\Model;

class copyObjectResult extends Model
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
        $res                 = [];
        $res['LastModified'] = $this->lastModified;
        $res['ETag']         = $this->eTag;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return copyObjectResult
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
