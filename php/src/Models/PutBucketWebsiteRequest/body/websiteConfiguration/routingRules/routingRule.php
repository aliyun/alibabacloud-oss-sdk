<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\Models\PutBucketWebsiteRequest\body\websiteConfiguration\routingRules;

use AlibabaCloud\Tea\Model;

use AlibabaCloud\SDK\OSS\Models\routingRule\condition;
use AlibabaCloud\SDK\OSS\Models\routingRule\routingRule\condition\includeHeader;
use AlibabaCloud\SDK\OSS\Models\routingRule\redirect;
use AlibabaCloud\SDK\OSS\Models\routingRule\routingRule\redirect\mirrorHeaders;
use AlibabaCloud\SDK\OSS\Models\routingRule\routingRule\redirect\routingRule\routingRule\redirect\mirrorHeaders\set;

class routingRule extends Model{
    protected $_name = [];

    public $condition;

    public $redirect;

    public $ruleNumber;

}
