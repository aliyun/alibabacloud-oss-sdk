<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS\PutBucketWebsiteRequest\body\websiteConfiguration\routingRules;

use AlibabaCloud\SDK\OSS\OSS\PutBucketWebsiteRequest\body\websiteConfiguration\routingRules\routingRule\condition;
use AlibabaCloud\SDK\OSS\OSS\PutBucketWebsiteRequest\body\websiteConfiguration\routingRules\routingRule\redirect;
use AlibabaCloud\Tea\Model;

class routingRule extends Model
{
    /**
     * @description Condition
     *
     * @var condition
     */
    public $condition;

    /**
     * @description Redirect
     *
     * @var redirect
     */
    public $redirect;

    /**
     * @description RuleNumber
     *
     * @var int
     */
    public $ruleNumber;
    protected $_name = [
        'condition'  => 'Condition',
        'redirect'   => 'Redirect',
        'ruleNumber' => 'RuleNumber',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->condition) {
            $res['Condition'] = null !== $this->condition ? $this->condition->toMap() : null;
        }
        if (null !== $this->redirect) {
            $res['Redirect'] = null !== $this->redirect ? $this->redirect->toMap() : null;
        }
        if (null !== $this->ruleNumber) {
            $res['RuleNumber'] = $this->ruleNumber;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return routingRule
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['Condition'])) {
            $model->condition = condition::fromMap($map['Condition']);
        }
        if (isset($map['Redirect'])) {
            $model->redirect = redirect::fromMap($map['Redirect']);
        }
        if (isset($map['RuleNumber'])) {
            $model->ruleNumber = $map['RuleNumber'];
        }

        return $model;
    }
}
