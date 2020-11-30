<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS;

use AlibabaCloud\Tea\Model;

class Config extends Model
{
    public $type;

    public $securityToken;

    /**
     * @var string
     */
    public $accessKeyId;

    /**
     * @var string
     */
    public $accessKeySecret;

    public $endpoint;

    public $protocol;

    /**
     * @var string
     */
    public $regionId;

    public $userAgent;

    public $hostModel;

    public $signatureVersion;

    public $isEnableMD5;

    public $isEnableCrc;

    public $readTimeout;

    public $connectTimeout;

    public $localAddr;

    public $httpProxy;

    public $httpsProxy;

    public $noProxy;

    public $socks5Proxy;

    public $socks5NetWork;

    public $maxIdleConns;

    public $addtionalHeaders;

    public function validate()
    {
        Model::validateRequired('accessKeyId', $this->accessKeyId, true);
        Model::validateRequired('accessKeySecret', $this->accessKeySecret, true);
        Model::validatePattern('regionId', $this->regionId, '[a-zA-Z0-9-_]+');
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->type) {
            $res['type'] = $this->type;
        }
        if (null !== $this->securityToken) {
            $res['securityToken'] = $this->securityToken;
        }
        if (null !== $this->accessKeyId) {
            $res['accessKeyId'] = $this->accessKeyId;
        }
        if (null !== $this->accessKeySecret) {
            $res['accessKeySecret'] = $this->accessKeySecret;
        }
        if (null !== $this->endpoint) {
            $res['endpoint'] = $this->endpoint;
        }
        if (null !== $this->protocol) {
            $res['protocol'] = $this->protocol;
        }
        if (null !== $this->regionId) {
            $res['regionId'] = $this->regionId;
        }
        if (null !== $this->userAgent) {
            $res['userAgent'] = $this->userAgent;
        }
        if (null !== $this->hostModel) {
            $res['hostModel'] = $this->hostModel;
        }
        if (null !== $this->signatureVersion) {
            $res['signatureVersion'] = $this->signatureVersion;
        }
        if (null !== $this->isEnableMD5) {
            $res['isEnableMD5'] = $this->isEnableMD5;
        }
        if (null !== $this->isEnableCrc) {
            $res['isEnableCrc'] = $this->isEnableCrc;
        }
        if (null !== $this->readTimeout) {
            $res['readTimeout'] = $this->readTimeout;
        }
        if (null !== $this->connectTimeout) {
            $res['connectTimeout'] = $this->connectTimeout;
        }
        if (null !== $this->localAddr) {
            $res['localAddr'] = $this->localAddr;
        }
        if (null !== $this->httpProxy) {
            $res['httpProxy'] = $this->httpProxy;
        }
        if (null !== $this->httpsProxy) {
            $res['httpsProxy'] = $this->httpsProxy;
        }
        if (null !== $this->noProxy) {
            $res['noProxy'] = $this->noProxy;
        }
        if (null !== $this->socks5Proxy) {
            $res['socks5Proxy'] = $this->socks5Proxy;
        }
        if (null !== $this->socks5NetWork) {
            $res['socks5NetWork'] = $this->socks5NetWork;
        }
        if (null !== $this->maxIdleConns) {
            $res['maxIdleConns'] = $this->maxIdleConns;
        }
        if (null !== $this->addtionalHeaders) {
            $res['addtionalHeaders'] = $this->addtionalHeaders;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return Config
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }
        if (isset($map['securityToken'])) {
            $model->securityToken = $map['securityToken'];
        }
        if (isset($map['accessKeyId'])) {
            $model->accessKeyId = $map['accessKeyId'];
        }
        if (isset($map['accessKeySecret'])) {
            $model->accessKeySecret = $map['accessKeySecret'];
        }
        if (isset($map['endpoint'])) {
            $model->endpoint = $map['endpoint'];
        }
        if (isset($map['protocol'])) {
            $model->protocol = $map['protocol'];
        }
        if (isset($map['regionId'])) {
            $model->regionId = $map['regionId'];
        }
        if (isset($map['userAgent'])) {
            $model->userAgent = $map['userAgent'];
        }
        if (isset($map['hostModel'])) {
            $model->hostModel = $map['hostModel'];
        }
        if (isset($map['signatureVersion'])) {
            $model->signatureVersion = $map['signatureVersion'];
        }
        if (isset($map['isEnableMD5'])) {
            $model->isEnableMD5 = $map['isEnableMD5'];
        }
        if (isset($map['isEnableCrc'])) {
            $model->isEnableCrc = $map['isEnableCrc'];
        }
        if (isset($map['readTimeout'])) {
            $model->readTimeout = $map['readTimeout'];
        }
        if (isset($map['connectTimeout'])) {
            $model->connectTimeout = $map['connectTimeout'];
        }
        if (isset($map['localAddr'])) {
            $model->localAddr = $map['localAddr'];
        }
        if (isset($map['httpProxy'])) {
            $model->httpProxy = $map['httpProxy'];
        }
        if (isset($map['httpsProxy'])) {
            $model->httpsProxy = $map['httpsProxy'];
        }
        if (isset($map['noProxy'])) {
            $model->noProxy = $map['noProxy'];
        }
        if (isset($map['socks5Proxy'])) {
            $model->socks5Proxy = $map['socks5Proxy'];
        }
        if (isset($map['socks5NetWork'])) {
            $model->socks5NetWork = $map['socks5NetWork'];
        }
        if (isset($map['maxIdleConns'])) {
            $model->maxIdleConns = $map['maxIdleConns'];
        }
        if (isset($map['addtionalHeaders'])) {
            if (!empty($map['addtionalHeaders'])) {
                $model->addtionalHeaders = $map['addtionalHeaders'];
            }
        }

        return $model;
    }
}
