<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS\PutBucketWebsiteRequest\body\websiteConfiguration\routingRules\routingRule;

use AlibabaCloud\SDK\OSS\OSS\redirect\mirrorHeaders;
use AlibabaCloud\Tea\Model;

class redirect extends Model
{
    /**
     * @description MirrorHeaders
     *
     * @var redirect.mirrorHeaders
     */
    public $mirrorHeaders;

    /**
     * @description RedirectType
     *
     * @var string
     */
    public $redirectType;

    /**
     * @description PassQueryString
     *
     * @var bool
     */
    public $passQueryString;

    /**
     * @description MirrorURL
     *
     * @var string
     */
    public $mirrorURL;

    /**
     * @description MirrorPassQueryString
     *
     * @var bool
     */
    public $mirrorPassQueryString;

    /**
     * @description MirrorFollowRedirect
     *
     * @var bool
     */
    public $mirrorFollowRedirect;

    /**
     * @description MirrorCheckMd5
     *
     * @var bool
     */
    public $mirrorCheckMd5;

    /**
     * @description Protocol
     *
     * @var string
     */
    public $protocol;

    /**
     * @description HostName
     *
     * @var string
     */
    public $hostName;

    /**
     * @description HttpRedirectCode
     *
     * @var string
     */
    public $httpRedirectCode;

    /**
     * @description ReplaceKeyPrefixWith
     *
     * @var string
     */
    public $replaceKeyPrefixWith;

    /**
     * @description ReplaceKeyWith
     *
     * @var string
     */
    public $replaceKeyWith;
    protected $_name = [
        'mirrorHeaders'         => 'MirrorHeaders',
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
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res                          = [];
        $res['MirrorHeaders']         = null !== $this->mirrorHeaders ? $this->mirrorHeaders->toMap() : null;
        $res['RedirectType']          = $this->redirectType;
        $res['PassQueryString']       = $this->passQueryString;
        $res['MirrorURL']             = $this->mirrorURL;
        $res['MirrorPassQueryString'] = $this->mirrorPassQueryString;
        $res['MirrorFollowRedirect']  = $this->mirrorFollowRedirect;
        $res['MirrorCheckMd5']        = $this->mirrorCheckMd5;
        $res['Protocol']              = $this->protocol;
        $res['HostName']              = $this->hostName;
        $res['HttpRedirectCode']      = $this->httpRedirectCode;
        $res['ReplaceKeyPrefixWith']  = $this->replaceKeyPrefixWith;
        $res['ReplaceKeyWith']        = $this->replaceKeyWith;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return redirect
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['MirrorHeaders'])) {
            $model->mirrorHeaders = redirect\mirrorHeaders::fromMap($map['MirrorHeaders']);
        }
        if (isset($map['RedirectType'])) {
            $model->redirectType = $map['RedirectType'];
        }
        if (isset($map['PassQueryString'])) {
            $model->passQueryString = $map['PassQueryString'];
        }
        if (isset($map['MirrorURL'])) {
            $model->mirrorURL = $map['MirrorURL'];
        }
        if (isset($map['MirrorPassQueryString'])) {
            $model->mirrorPassQueryString = $map['MirrorPassQueryString'];
        }
        if (isset($map['MirrorFollowRedirect'])) {
            $model->mirrorFollowRedirect = $map['MirrorFollowRedirect'];
        }
        if (isset($map['MirrorCheckMd5'])) {
            $model->mirrorCheckMd5 = $map['MirrorCheckMd5'];
        }
        if (isset($map['Protocol'])) {
            $model->protocol = $map['Protocol'];
        }
        if (isset($map['HostName'])) {
            $model->hostName = $map['HostName'];
        }
        if (isset($map['HttpRedirectCode'])) {
            $model->httpRedirectCode = $map['HttpRedirectCode'];
        }
        if (isset($map['ReplaceKeyPrefixWith'])) {
            $model->replaceKeyPrefixWith = $map['ReplaceKeyPrefixWith'];
        }
        if (isset($map['ReplaceKeyWith'])) {
            $model->replaceKeyWith = $map['ReplaceKeyWith'];
        }

        return $model;
    }
}
