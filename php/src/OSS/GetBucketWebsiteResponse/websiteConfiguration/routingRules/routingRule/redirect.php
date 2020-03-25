<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS\GetBucketWebsiteResponse\websiteConfiguration\routingRules\routingRule;

use AlibabaCloud\Tea\Model;

class redirect extends Model
{
    public $redirectType;

    public $passQueryString;

    public $mirrorURL;

    public $mirrorPassQueryString;

    public $mirrorFollowRedirect;

    public $mirrorCheckMd5;

    public $protocol;

    public $hostName;

    public $httpRedirectCode;

    public $replaceKeyPrefixWith;

    public $replaceKeyWith;

    public $mirrorHeaders;
    protected $_name = [
        'redirectType'          => 'RedirectType',
        'passQueryString'       => 'PassQueryString',
        'mirrorURL'             => 'MirrorURL',
        'mirrorPassQueryString' => 'MirrorPassQueryString',
        'mirrorFollowRedirect'  => 'MirrorFollowRedirect',
        'mirrorCheckMd5'        => 'MirrorCheckMd5',
        'protocol'              => 'Protocol',
        'hostName'              => 'HostName',
        'httpRedirectCode'      => 'HttpRedirectCode',
        'replaceKeyPrefixWith'  => 'ReplaceKeyPrefixWith',
        'replaceKeyWith'        => 'ReplaceKeyWith',
        'mirrorHeaders'         => 'MirrorHeaders',
    ];
}
