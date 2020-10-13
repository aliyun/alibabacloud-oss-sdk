<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS\PutBucketWebsiteRequest\body\websiteConfiguration;

use AlibabaCloud\SDK\OSS\OSS\PutBucketWebsiteRequest\body\websiteConfiguration\routingRules\routingRule;
use AlibabaCloud\Tea\Model;

class routingRules extends Model
{
    /**
     * @description RoutingRule
     *
     * @var routingRule[]
     */
    public $routingRule;
    protected $_name = [
        'routingRule' => 'RoutingRule',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->routingRule) {
            $res['RoutingRule'] = [];
            if (null !== $this->routingRule && \is_array($this->routingRule)) {
                $n = 0;
                foreach ($this->routingRule as $item) {
                    $res['RoutingRule'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return routingRules
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['RoutingRule'])) {
            if (!empty($map['RoutingRule'])) {
                $model->routingRule = [];
                $n                  = 0;
                foreach ($map['RoutingRule'] as $item) {
                    $model->routingRule[$n++] = null !== $item ? routingRule::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
