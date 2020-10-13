<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS\GetBucketWebsiteResponse\websiteConfiguration\routingRules\routingRule;

use AlibabaCloud\SDK\OSS\OSS\GetBucketWebsiteResponse\websiteConfiguration\routingRules\routingRule\condition\includeHeader;
use AlibabaCloud\Tea\Model;

class condition extends Model
{
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

    /**
     * @description IncludeHeader
     *
     * @var includeHeader
     */
    public $includeHeader;
    protected $_name = [
        'keyPrefixEquals'             => 'KeyPrefixEquals',
        'httpErrorCodeReturnedEquals' => 'HttpErrorCodeReturnedEquals',
        'includeHeader'               => 'IncludeHeader',
    ];

    public function validate()
    {
        Model::validateRequired('includeHeader', $this->includeHeader, true);
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->keyPrefixEquals) {
            $res['KeyPrefixEquals'] = $this->keyPrefixEquals;
        }
        if (null !== $this->httpErrorCodeReturnedEquals) {
            $res['HttpErrorCodeReturnedEquals'] = $this->httpErrorCodeReturnedEquals;
        }
        if (null !== $this->includeHeader) {
            $res['IncludeHeader'] = null !== $this->includeHeader ? $this->includeHeader->toMap() : null;
        }

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
        if (isset($map['KeyPrefixEquals'])) {
            $model->keyPrefixEquals = $map['KeyPrefixEquals'];
        }
        if (isset($map['HttpErrorCodeReturnedEquals'])) {
            $model->httpErrorCodeReturnedEquals = $map['HttpErrorCodeReturnedEquals'];
        }
        if (isset($map['IncludeHeader'])) {
            $model->includeHeader = includeHeader::fromMap($map['IncludeHeader']);
        }

        return $model;
    }
}
