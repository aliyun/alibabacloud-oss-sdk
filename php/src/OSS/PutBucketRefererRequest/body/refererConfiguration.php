<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS\PutBucketRefererRequest\body;

use AlibabaCloud\SDK\OSS\OSS\refererConfiguration\refererList;
use AlibabaCloud\Tea\Model;

class refererConfiguration extends Model
{
    /**
     * @description RefererList
     *
     * @var refererConfiguration.refererList
     */
    public $refererList;

    /**
     * @description AllowEmptyReferer
     *
     * @var bool
     */
    public $allowEmptyReferer;
    protected $_name = [
        'refererList'       => 'RefererList',
        'allowEmptyReferer' => 'AllowEmptyReferer',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res                      = [];
        $res['RefererList']       = null !== $this->refererList ? $this->refererList->toMap() : null;
        $res['AllowEmptyReferer'] = $this->allowEmptyReferer;

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
        if (isset($map['RefererList'])) {
            $model->refererList = refererConfiguration\refererList::fromMap($map['RefererList']);
        }
        if (isset($map['AllowEmptyReferer'])) {
            $model->allowEmptyReferer = $map['AllowEmptyReferer'];
        }

        return $model;
    }
}
