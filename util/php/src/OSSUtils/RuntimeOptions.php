<?php

// This file is auto-generated, don't edit it. Thanks.
namespace AlibabaCloud\Tea\OSSUtils\OSSUtils;

use AlibabaCloud\Tea\Model;

/**
 * The OSS runtime options model
 */
class RuntimeOptions extends Model
{
    protected $_name = [
        'autoretry' => 'autoretry',
        'ignoreSSL' => 'ignoreSSL',
        'maxAttempts' => 'maxAttempts',
        'backoffPolicy' => 'backoffPolicy',
        'backoffPeriod' => 'backoffPeriod',
        'readTimeout' => 'readTimeout',
        'connectTimeout' => 'connectTimeout',
        'localAddr' => 'localAddr',
        'httpProxy' => 'httpProxy',
        'httpsProxy' => 'httpsProxy',
        'noProxy' => 'noProxy',
        'maxIdleConns' => 'maxIdleConns',
        'socks5Proxy' => 'socks5Proxy',
        'socks5NetWork' => 'socks5NetWork',
        'uploadLimitSpeed' => 'uploadLimitSpeed',
        'listener' => 'listener',
    ];
    public function validate()
    {
    }
    public function toMap()
    {
        $res = [];
        if (null !== $this->autoretry) {
            $res['autoretry'] = $this->autoretry;
        }
        if (null !== $this->ignoreSSL) {
            $res['ignoreSSL'] = $this->ignoreSSL;
        }
        if (null !== $this->maxAttempts) {
            $res['maxAttempts'] = $this->maxAttempts;
        }
        if (null !== $this->backoffPolicy) {
            $res['backoffPolicy'] = $this->backoffPolicy;
        }
        if (null !== $this->backoffPeriod) {
            $res['backoffPeriod'] = $this->backoffPeriod;
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
        if (null !== $this->maxIdleConns) {
            $res['maxIdleConns'] = $this->maxIdleConns;
        }
        if (null !== $this->socks5Proxy) {
            $res['socks5Proxy'] = $this->socks5Proxy;
        }
        if (null !== $this->socks5NetWork) {
            $res['socks5NetWork'] = $this->socks5NetWork;
        }
        if (null !== $this->uploadLimitSpeed) {
            $res['uploadLimitSpeed'] = $this->uploadLimitSpeed;
        }
        if (null !== $this->listener) {
            $res['listener'] = $this->listener;
        }
        return $res;
    }
    /**
     * @param array $map
     * @return RuntimeOptions
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['autoretry'])) {
            $model->autoretry = $map['autoretry'];
        }
        if (isset($map['ignoreSSL'])) {
            $model->ignoreSSL = $map['ignoreSSL'];
        }
        if (isset($map['maxAttempts'])) {
            $model->maxAttempts = $map['maxAttempts'];
        }
        if (isset($map['backoffPolicy'])) {
            $model->backoffPolicy = $map['backoffPolicy'];
        }
        if (isset($map['backoffPeriod'])) {
            $model->backoffPeriod = $map['backoffPeriod'];
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
        if (isset($map['maxIdleConns'])) {
            $model->maxIdleConns = $map['maxIdleConns'];
        }
        if (isset($map['socks5Proxy'])) {
            $model->socks5Proxy = $map['socks5Proxy'];
        }
        if (isset($map['socks5NetWork'])) {
            $model->socks5NetWork = $map['socks5NetWork'];
        }
        if (isset($map['uploadLimitSpeed'])) {
            $model->uploadLimitSpeed = $map['uploadLimitSpeed'];
        }
        if (isset($map['listener'])) {
            $model->listener = $map['listener'];
        }
        return $model;
    }
    /**
     * @description autoretry
     * @var bool
     */
    public $autoretry;

    /**
     * @description ignoreSSL
     * @var bool
     */
    public $ignoreSSL;

    /**
     * @description max attempts
     * @var int
     */
    public $maxAttempts;

    /**
     * @description backoff policy
     * @var string
     */
    public $backoffPolicy;

    /**
     * @description backoff period
     * @var int
     */
    public $backoffPeriod;

    /**
     * @description read timeout
     * @var int
     */
    public $readTimeout;

    /**
     * @description connect timeout
     * @var int
     */
    public $connectTimeout;

    /**
     * @description local addr
     * @var string
     */
    public $localAddr;

    /**
     * @description http proxy
     * @var string
     */
    public $httpProxy;

    /**
     * @description https proxy
     * @var string
     */
    public $httpsProxy;

    /**
     * @description no proxy
     * @var string
     */
    public $noProxy;

    /**
     * @description max idle conns
     * @var int
     */
    public $maxIdleConns;

    /**
     * @description socks5 proxy
     * @var string
     */
    public $socks5Proxy;

    /**
     * @description socks5 NetWork
     * @var string
     */
    public $socks5NetWork;

    /**
     * @description upload limit speed
     * @var int
     */
    public $uploadLimitSpeed;

    /**
     * @description listener
     * @var mixed
     */
    public $listener;
}
