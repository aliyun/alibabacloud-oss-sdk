<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS\PutBucketAclRequest;

use AlibabaCloud\Tea\Model;

class header extends Model
{
    /**
     * @description x-oss-acl
     *
     * @var string
     */
    public $acl;
    protected $_name = [
        'acl' => 'x-oss-acl',
    ];

    public function validate()
    {
        Model::validateRequired('acl', $this->acl, true);
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->acl) {
            $res['x-oss-acl'] = $this->acl;
        }

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
        if (isset($map['x-oss-acl'])) {
            $model->acl = $map['x-oss-acl'];
        }

        return $model;
    }
}
