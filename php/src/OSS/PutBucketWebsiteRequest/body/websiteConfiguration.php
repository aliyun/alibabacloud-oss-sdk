<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS\PutBucketWebsiteRequest\body;

use AlibabaCloud\SDK\OSS\OSS\PutBucketWebsiteRequest\body\websiteConfiguration\errorDocument;
use AlibabaCloud\SDK\OSS\OSS\PutBucketWebsiteRequest\body\websiteConfiguration\indexDocument;
use AlibabaCloud\SDK\OSS\OSS\PutBucketWebsiteRequest\body\websiteConfiguration\routingRules;
use AlibabaCloud\Tea\Model;

class websiteConfiguration extends Model
{
    /**
     * @description IndexDocument
     *
     * @var indexDocument
     */
    public $indexDocument;

    /**
     * @description ErrorDocument
     *
     * @var errorDocument
     */
    public $errorDocument;

    /**
     * @description RoutingRules
     *
     * @var routingRules
     */
    public $routingRules;
    protected $_name = [
        'indexDocument' => 'IndexDocument',
        'errorDocument' => 'ErrorDocument',
        'routingRules'  => 'RoutingRules',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->indexDocument) {
            $res['IndexDocument'] = null !== $this->indexDocument ? $this->indexDocument->toMap() : null;
        }
        if (null !== $this->errorDocument) {
            $res['ErrorDocument'] = null !== $this->errorDocument ? $this->errorDocument->toMap() : null;
        }
        if (null !== $this->routingRules) {
            $res['RoutingRules'] = null !== $this->routingRules ? $this->routingRules->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return websiteConfiguration
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['IndexDocument'])) {
            $model->indexDocument = indexDocument::fromMap($map['IndexDocument']);
        }
        if (isset($map['ErrorDocument'])) {
            $model->errorDocument = errorDocument::fromMap($map['ErrorDocument']);
        }
        if (isset($map['RoutingRules'])) {
            $model->routingRules = routingRules::fromMap($map['RoutingRules']);
        }

        return $model;
    }
}
