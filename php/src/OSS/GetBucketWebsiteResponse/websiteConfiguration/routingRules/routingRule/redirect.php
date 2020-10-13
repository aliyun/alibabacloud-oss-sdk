<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS\GetBucketWebsiteResponse\websiteConfiguration\routingRules\routingRule;

use AlibabaCloud\SDK\OSS\OSS\GetBucketWebsiteResponse\websiteConfiguration\routingRules\routingRule\redirect\mirrorHeaders;
use AlibabaCloud\Tea\Model;

class redirect extends Model
{
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

    /**
     * @description MirrorHeaders
     *
     * @var mirrorHeaders
     */
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

    public function validate()
    {
        Model::validateRequired('mirrorHeaders', $this->mirrorHeaders, true);
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->redirectType) {
            $res['RedirectType'] = $this->redirectType;
        }
        if (null !== $this->passQueryString) {
            $res['PassQueryString'] = $this->passQueryString;
        }
        if (null !== $this->mirrorURL) {
            $res['MirrorURL'] = $this->mirrorURL;
        }
        if (null !== $this->mirrorPassQueryString) {
            $res['MirrorPassQueryString'] = $this->mirrorPassQueryString;
        }
        if (null !== $this->mirrorFollowRedirect) {
            $res['MirrorFollowRedirect'] = $this->mirrorFollowRedirect;
        }
        if (null !== $this->mirrorCheckMd5) {
            $res['MirrorCheckMd5'] = $this->mirrorCheckMd5;
        }
        if (null !== $this->protocol) {
            $res['Protocol'] = $this->protocol;
        }
        if (null !== $this->hostName) {
            $res['HostName'] = $this->hostName;
        }
        if (null !== $this->httpRedirectCode) {
            $res['HttpRedirectCode'] = $this->httpRedirectCode;
        }
        if (null !== $this->replaceKeyPrefixWith) {
            $res['ReplaceKeyPrefixWith'] = $this->replaceKeyPrefixWith;
        }
        if (null !== $this->replaceKeyWith) {
            $res['ReplaceKeyWith'] = $this->replaceKeyWith;
        }
        if (null !== $this->mirrorHeaders) {
            $res['MirrorHeaders'] = null !== $this->mirrorHeaders ? $this->mirrorHeaders->toMap() : null;
        }

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
        if (isset($map['MirrorHeaders'])) {
            $model->mirrorHeaders = mirrorHeaders::fromMap($map['MirrorHeaders']);
        }

        return $model;
    }
}
