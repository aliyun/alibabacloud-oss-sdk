<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS\GetBucketRefererResponse;

use AlibabaCloud\SDK\OSS\OSS\GetBucketRefererResponse\refererConfiguration\refererList;
use AlibabaCloud\Tea\Model;

class refererConfiguration extends Model
{
    /**
     * @description AllowEmptyReferer
     *
     * @var bool
     */
    public $allowEmptyReferer;

    /**
     * @description RefererList
     *
     * @var refererList
     */
    public $refererList;
    protected $_name = [
        'allowEmptyReferer' => 'AllowEmptyReferer',
        'refererList'       => 'RefererList',
    ];

    public function validate()
    {
        Model::validateRequired('refererList', $this->refererList, true);
    }

    public function toMap()
    {
        $res                      = [];
        $res['AllowEmptyReferer'] = $this->allowEmptyReferer;
        $res['RefererList']       = null !== $this->refererList ? $this->refererList->toMap() : null;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return refererConfiguration
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['AllowEmptyReferer'])) {
            $model->allowEmptyReferer = $map['AllowEmptyReferer'];
        }
        if (isset($map['RefererList'])) {
            $model->refererList = refererList::fromMap($map['RefererList']);
        }

        return $model;
    }
}
