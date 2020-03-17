<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS\PutBucketWebsiteRequest\body\websiteConfiguration\routingRules;

use AlibabaCloud\Tea\Model;

use AlibabaCloud\SDK\OSS\OSS\routingRule\condition;
use AlibabaCloud\SDK\OSS\OSS\routingRule\condition\includeHeader;
use AlibabaCloud\SDK\OSS\OSS\routingRule\redirect;
use AlibabaCloud\SDK\OSS\OSS\routingRule\redirect\mirrorHeaders;
use AlibabaCloud\SDK\OSS\OSS\routingRule\redirect\mirrorHeaders\set;

class routingRule extends Model{
    protected $_name = [];

    public $condition;

    public $redirect;

    public $ruleNumber;

}
