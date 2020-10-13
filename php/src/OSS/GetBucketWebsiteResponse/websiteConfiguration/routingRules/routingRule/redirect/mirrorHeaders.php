<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS\GetBucketWebsiteResponse\websiteConfiguration\routingRules\routingRule\redirect;

use AlibabaCloud\SDK\OSS\OSS\GetBucketWebsiteResponse\websiteConfiguration\routingRules\routingRule\redirect\mirrorHeaders\set;
use AlibabaCloud\Tea\Model;

class mirrorHeaders extends Model
{
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

    /**
     * @description Set
     *
     * @var set
     */
    public $set;
    protected $_name = [
        'passAll' => 'PassAll',
        'pass'    => 'Pass',
        'remove'  => 'Remove',
        'set'     => 'Set',
    ];

    public function validate()
    {
        Model::validateRequired('set', $this->set, true);
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->passAll) {
            $res['PassAll'] = $this->passAll;
        }
        if (null !== $this->pass) {
            $res['Pass'] = $this->pass;
        }
        if (null !== $this->remove) {
            $res['Remove'] = $this->remove;
        }
        if (null !== $this->set) {
            $res['Set'] = null !== $this->set ? $this->set->toMap() : null;
        }

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
        if (isset($map['PassAll'])) {
            $model->passAll = $map['PassAll'];
        }
        if (isset($map['Pass'])) {
            $model->pass = $map['Pass'];
        }
        if (isset($map['Remove'])) {
            $model->remove = $map['Remove'];
        }
        if (isset($map['Set'])) {
            $model->set = set::fromMap($map['Set']);
        }

        return $model;
    }
}
