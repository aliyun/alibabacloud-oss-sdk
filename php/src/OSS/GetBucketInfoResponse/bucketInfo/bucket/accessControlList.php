<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS\GetBucketInfoResponse\bucketInfo\bucket;

use AlibabaCloud\Tea\Model;

class accessControlList extends Model
{
    /**
     * @description Grant
     *
     * @var string
     */
    public $grant;
    protected $_name = [
        'grant' => 'Grant',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->grant) {
            $res['Grant'] = $this->grant;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return accessControlList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['Grant'])) {
            $model->grant = $map['Grant'];
        }

        return $model;
    }
}
