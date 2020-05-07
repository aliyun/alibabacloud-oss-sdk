<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS\PutBucketWebsiteRequest\body\websiteConfiguration\routingRules\routingRule\redirect;

use AlibabaCloud\SDK\OSS\OSS\mirrorHeaders\set;
use AlibabaCloud\Tea\Model;

class mirrorHeaders extends Model
{
    /**
     * @description Set
     *
     * @var mirrorHeaders.set
     */
    public $set;

    /**
     * @description PassAll
     *
     * @var bool
     */
    public $passAll;

    /**
     * @description Pass
     *
     * @var string
     */
    public $pass;

    /**
     * @description Remove
     *
     * @var string
     */
    public $remove;
    protected $_name = [
        'set'     => 'Set',
        'passAll' => 'PassAll',
        'pass'    => 'Pass',
        'remove'  => 'Remove',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res            = [];
        $res['Set']     = null !== $this->set ? $this->set->toMap() : null;
        $res['PassAll'] = $this->passAll;
        $res['Pass']    = $this->pass;
        $res['Remove']  = $this->remove;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return mirrorHeaders
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['Set'])) {
            $model->set = set::fromMap($map['Set']);
        }
        if (isset($map['PassAll'])) {
            $model->passAll = $map['PassAll'];
        }
        if (isset($map['Pass'])) {
            $model->pass = $map['Pass'];
        }
        if (isset($map['Remove'])) {
            $model->remove = $map['Remove'];
        }

        return $model;
    }
}
