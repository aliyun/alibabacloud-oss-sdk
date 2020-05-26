<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS\GetBucketWebsiteResponse;

use AlibabaCloud\SDK\OSS\OSS\GetBucketWebsiteResponse\websiteConfiguration\errorDocument;
use AlibabaCloud\SDK\OSS\OSS\GetBucketWebsiteResponse\websiteConfiguration\indexDocument;
use AlibabaCloud\SDK\OSS\OSS\GetBucketWebsiteResponse\websiteConfiguration\routingRules;
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
        Model::validateRequired('indexDocument', $this->indexDocument, true);
        Model::validateRequired('errorDocument', $this->errorDocument, true);
        Model::validateRequired('routingRules', $this->routingRules, true);
    }

    public function toMap()
    {
        $res                  = [];
        $res['IndexDocument'] = null !== $this->indexDocument ? $this->indexDocument->toMap() : null;
        $res['ErrorDocument'] = null !== $this->errorDocument ? $this->errorDocument->toMap() : null;
        $res['RoutingRules']  = null !== $this->routingRules ? $this->routingRules->toMap() : null;

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
