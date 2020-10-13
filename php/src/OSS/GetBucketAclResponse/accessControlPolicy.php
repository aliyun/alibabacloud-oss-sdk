<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS\GetBucketAclResponse;

use AlibabaCloud\SDK\OSS\OSS\GetBucketAclResponse\accessControlPolicy\accessControlList;
use AlibabaCloud\SDK\OSS\OSS\GetBucketAclResponse\accessControlPolicy\owner;
use AlibabaCloud\Tea\Model;

class accessControlPolicy extends Model
{
    /**
     * @description Owner
     *
     * @var owner
     */
    public $owner;

    /**
     * @description AccessControlList
     *
     * @var accessControlList
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
        $res = [];
        if (null !== $this->owner) {
            $res['Owner'] = null !== $this->owner ? $this->owner->toMap() : null;
        }
        if (null !== $this->accessControlList) {
            $res['AccessControlList'] = null !== $this->accessControlList ? $this->accessControlList->toMap() : null;
        }

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
