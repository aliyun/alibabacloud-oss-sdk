<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS\PutBucketWebsiteRequest\body\websiteConfiguration\routingRules\routingRule;

use AlibabaCloud\SDK\OSS\OSS\condition\includeHeader;
use AlibabaCloud\Tea\Model;

class condition extends Model
{
    /**
     * @description IncludeHeader
     *
     * @var condition.includeHeader
     */
    public $includeHeader;

    /**
     * @description KeyPrefixEquals
     *
     * @var string
     */
    public $keyPrefixEquals;

    /**
     * @description HttpErrorCodeReturnedEquals
     *
     * @var string
     */
    public $httpErrorCodeReturnedEquals;
    protected $_name = [
        'includeHeader'               => 'IncludeHeader',
        'keyPrefixEquals'             => 'KeyPrefixEquals',
        'httpErrorCodeReturnedEquals' => 'HttpErrorCodeReturnedEquals',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res                                = [];
        $res['IncludeHeader']               = null !== $this->includeHeader ? $this->includeHeader->toMap() : null;
        $res['KeyPrefixEquals']             = $this->keyPrefixEquals;
        $res['HttpErrorCodeReturnedEquals'] = $this->httpErrorCodeReturnedEquals;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return condition
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['IncludeHeader'])) {
            $model->includeHeader = condition\includeHeader::fromMap($map['IncludeHeader']);
        }
        if (isset($map['KeyPrefixEquals'])) {
            $model->keyPrefixEquals = $map['KeyPrefixEquals'];
        }
        if (isset($map['HttpErrorCodeReturnedEquals'])) {
            $model->httpErrorCodeReturnedEquals = $map['HttpErrorCodeReturnedEquals'];
        }

        return $model;
    }
}
