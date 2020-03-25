<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS\GetBucketWebsiteResponse\websiteConfiguration\routingRules\routingRule;

use AlibabaCloud\Tea\Model;

class condition extends Model
{
    public $keyPrefixEquals;

    public $httpErrorCodeReturnedEquals;

    public $includeHeader;
    protected $_name = [
        'keyPrefixEquals'             => 'KeyPrefixEquals',
        'httpErrorCodeReturnedEquals' => 'HttpErrorCodeReturnedEquals',
        'includeHeader'               => 'IncludeHeader',
    ];
}
