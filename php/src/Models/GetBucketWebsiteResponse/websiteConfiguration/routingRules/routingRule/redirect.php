<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\Models\GetBucketWebsiteResponse\websiteConfiguration\routingRules\routingRule;

use AlibabaCloud\Tea\Model;

use AlibabaCloud\SDK\OSS\Models\redirect\mirrorHeaders;
use AlibabaCloud\SDK\OSS\Models\redirect\redirect\mirrorHeaders\set;

class redirect extends Model{
    protected $_name = [];

    public $RedirectType;

    public $PassQueryString;

    public $MirrorURL;

    public $MirrorPassQueryString;

    public $MirrorFollowRedirect;

    public $MirrorCheckMd5;

    public $Protocol;

    public $HostName;

    public $HttpRedirectCode;

    public $ReplaceKeyPrefixWith;

    public $ReplaceKeyWith;

    public $MirrorHeaders;

}
