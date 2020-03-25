<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS\PutBucketWebsiteRequest\body\websiteConfiguration\routingRules\routingRule;

use AlibabaCloud\Tea\Model;

class condition extends Model
{
    public $includeHeader;

    public $keyPrefixEquals;

    public $httpErrorCodeReturnedEquals;
    protected $_name = [
        'includeHeader'               => 'IncludeHeader',
        'keyPrefixEquals'             => 'KeyPrefixEquals',
        'httpErrorCodeReturnedEquals' => 'HttpErrorCodeReturnedEquals',
    ];
}
