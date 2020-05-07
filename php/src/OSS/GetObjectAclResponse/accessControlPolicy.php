<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS\GetObjectAclResponse;

use AlibabaCloud\SDK\OSS\OSS\accessControlPolicy\accessControlList;
use AlibabaCloud\SDK\OSS\OSS\accessControlPolicy\owner;
use AlibabaCloud\Tea\Model;

class accessControlPolicy extends Model
{
    /**
     * @description Owner
     *
     * @var accessControlPolicy.owner
     */
    public $owner;

    /**
     * @description AccessControlList
     *
     * @var accessControlPolicy.accessControlList
     */
    public $accessControlList;
    protected $_name = [
        'owner'             => 'Owner',
        'accessControlList' => 'AccessControlList',
    ];

    public function validate()
    {
        Model::validateRequired('owner', $this->owner, true);
        Model::validateRequired('accessControlList', $this->accessControlList, true);
    }

    public function toMap()
    {
        $res                      = [];
        $res['Owner']             = null !== $this->owner ? $this->owner->toMap() : null;
        $res['AccessControlList'] = null !== $this->accessControlList ? $this->accessControlList->toMap() : null;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return accessControlPolicy
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['Owner'])) {
            $model->owner = owner::fromMap($map['Owner']);
        }
        if (isset($map['AccessControlList'])) {
            $model->accessControlList = accessControlList::fromMap($map['AccessControlList']);
        }

        return $model;
    }
}
