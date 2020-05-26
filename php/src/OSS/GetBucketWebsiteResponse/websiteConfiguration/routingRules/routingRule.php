<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS\GetBucketWebsiteResponse\websiteConfiguration\routingRules;

use AlibabaCloud\SDK\OSS\OSS\GetBucketWebsiteResponse\websiteConfiguration\routingRules\routingRule\condition;
use AlibabaCloud\SDK\OSS\OSS\GetBucketWebsiteResponse\websiteConfiguration\routingRules\routingRule\redirect;
use AlibabaCloud\Tea\Model;

class routingRule extends Model
{
    /**
     * @description RuleNumber
     *
     * @var int
     */
    public $ruleNumber;

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
    protected $_name = [
        'ruleNumber' => 'RuleNumber',
        'condition'  => 'Condition',
        'redirect'   => 'Redirect',
    ];

    public function validate()
    {
        Model::validateRequired('condition', $this->condition, true);
        Model::validateRequired('redirect', $this->redirect, true);
    }

    public function toMap()
    {
        $res               = [];
        $res['RuleNumber'] = $this->ruleNumber;
        $res['Condition']  = null !== $this->condition ? $this->condition->toMap() : null;
        $res['Redirect']   = null !== $this->redirect ? $this->redirect->toMap() : null;

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
        if (isset($map['RuleNumber'])) {
            $model->ruleNumber = $map['RuleNumber'];
        }
        if (isset($map['Condition'])) {
            $model->condition = condition::fromMap($map['Condition']);
        }
        if (isset($map['Redirect'])) {
            $model->redirect = redirect::fromMap($map['Redirect']);
        }

        return $model;
    }
}
