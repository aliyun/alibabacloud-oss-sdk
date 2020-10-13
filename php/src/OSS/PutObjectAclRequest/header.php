<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS\PutObjectAclRequest;

use AlibabaCloud\Tea\Model;

class header extends Model
{
    /**
     * @description x-oss-object-acl
     *
     * @var string
     */
    public $objectAcl;
    protected $_name = [
        'objectAcl' => 'x-oss-object-acl',
    ];

    public function validate()
    {
        Model::validateRequired('objectAcl', $this->objectAcl, true);
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->objectAcl) {
            $res['x-oss-object-acl'] = $this->objectAcl;
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
        if (isset($map['x-oss-object-acl'])) {
            $model->objectAcl = $map['x-oss-object-acl'];
        }

        return $model;
    }
}
