<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\Models\PutBucketWebsiteRequest\body\websiteConfiguration\routingRules\routingRule;

use AlibabaCloud\Tea\Model;

use AlibabaCloud\SDK\OSS\Models\condition\includeHeader;

class condition extends Model{
    protected $_name = [];

    public $IncludeHeader;

    public $KeyPrefixEquals;

    public $HttpErrorCodeReturnedEquals;

}
