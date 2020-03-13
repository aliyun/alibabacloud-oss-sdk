<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS;

use AlibabaCloud\Tea\Tea;
use AlibabaCloud\Tea\Request;
use AlibabaCloud\Tea\Exception\TeaError;
use AlibabaCloud\Tea\Exception\TeaUnableRetryError;
use AlibabaCloud\Tea\Utils\Utils;
use AlibabaCloud\Tea\OSSUtils\OSSUtils;
use AlibabaCloud\Tea\XML\XML;
use AlibabaCloud\Credentials\Credential;
use AlibabaCloud\Tea\FileForm\FileForm;
use AlibabaCloud\Tea\OSSUtils\OSSUtils\RuntimeOptions;

use AlibabaCloud\SDK\OSS\Models\PutBucketLifecycleRequest;
use AlibabaCloud\SDK\OSS\Models\DeleteMultipleObjectsRequest;
use AlibabaCloud\SDK\OSS\Models\DeleteMultipleObjectsResponse;
use AlibabaCloud\SDK\OSS\Models\PutBucketRefererRequest;
use AlibabaCloud\SDK\OSS\Models\PutBucketWebsiteRequest;
use AlibabaCloud\SDK\OSS\Models\CompleteMultipartUploadRequest;
use AlibabaCloud\SDK\OSS\Models\CompleteMultipartUploadResponse;
use AlibabaCloud\SDK\OSS\Models\PutBucketLoggingRequest;
use AlibabaCloud\SDK\OSS\Models\PutBucketRequestPaymentRequest;
use AlibabaCloud\SDK\OSS\Models\PutBucketEncryptionRequest;
use AlibabaCloud\SDK\OSS\Models\PutLiveChannelRequest;
use AlibabaCloud\SDK\OSS\Models\PutLiveChannelResponse;
use AlibabaCloud\SDK\OSS\Models\PutBucketTagsRequest;
use AlibabaCloud\SDK\OSS\Models\PutObjectTaggingRequest;
use AlibabaCloud\SDK\OSS\Models\SelectObjectRequest;
use AlibabaCloud\SDK\OSS\Models\PutBucketCORSRequest;
use AlibabaCloud\SDK\OSS\Models\PutBucketRequest;
use AlibabaCloud\SDK\OSS\Models\ListMultipartUploadsRequest;
use AlibabaCloud\SDK\OSS\Models\ListMultipartUploadsResponse;
use AlibabaCloud\SDK\OSS\Models\GetBucketRequestPaymentRequest;
use AlibabaCloud\SDK\OSS\Models\GetBucketRequestPaymentResponse;
use AlibabaCloud\SDK\OSS\Models\GetBucketEncryptionRequest;
use AlibabaCloud\SDK\OSS\Models\GetBucketEncryptionResponse;
use AlibabaCloud\SDK\OSS\Models\GetBucketTagsRequest;
use AlibabaCloud\SDK\OSS\Models\GetBucketTagsResponse;
use AlibabaCloud\SDK\OSS\Models\GetServiceRequest;
use AlibabaCloud\SDK\OSS\Models\GetServiceResponse;
use AlibabaCloud\SDK\OSS\Models\DeleteBucketEncryptionRequest;
use AlibabaCloud\SDK\OSS\Models\DeleteBucketTagsRequest;
use AlibabaCloud\SDK\OSS\Models\GetBucketWebsiteRequest;
use AlibabaCloud\SDK\OSS\Models\GetBucketWebsiteResponse;
use AlibabaCloud\SDK\OSS\Models\DeleteLiveChannelRequest;
use AlibabaCloud\SDK\OSS\Models\GetBucketLocationRequest;
use AlibabaCloud\SDK\OSS\Models\GetBucketLocationResponse;
use AlibabaCloud\SDK\OSS\Models\ListLiveChannelRequest;
use AlibabaCloud\SDK\OSS\Models\ListLiveChannelResponse;
use AlibabaCloud\SDK\OSS\Models\GetObjectMetaRequest;
use AlibabaCloud\SDK\OSS\Models\GetBucketAclRequest;
use AlibabaCloud\SDK\OSS\Models\GetBucketAclResponse;
use AlibabaCloud\SDK\OSS\Models\ListPartsRequest;
use AlibabaCloud\SDK\OSS\Models\ListPartsResponse;
use AlibabaCloud\SDK\OSS\Models\GetLiveChannelHistoryRequest;
use AlibabaCloud\SDK\OSS\Models\GetLiveChannelHistoryResponse;
use AlibabaCloud\SDK\OSS\Models\GetBucketRequest;
use AlibabaCloud\SDK\OSS\Models\GetBucketResponse;
use AlibabaCloud\SDK\OSS\Models\GetLiveChannelInfoRequest;
use AlibabaCloud\SDK\OSS\Models\GetLiveChannelInfoResponse;
use AlibabaCloud\SDK\OSS\Models\GetLiveChannelStatRequest;
use AlibabaCloud\SDK\OSS\Models\GetLiveChannelStatResponse;
use AlibabaCloud\SDK\OSS\Models\DeleteObjectRequest;
use AlibabaCloud\SDK\OSS\Models\AbortMultipartUploadRequest;
use AlibabaCloud\SDK\OSS\Models\AppendObjectRequest;
use AlibabaCloud\SDK\OSS\Models\UploadPartCopyRequest;
use AlibabaCloud\SDK\OSS\Models\UploadPartCopyResponse;
use AlibabaCloud\SDK\OSS\Models\GetVodPlaylistRequest;
use AlibabaCloud\SDK\OSS\Models\DeleteBucketCORSRequest;
use AlibabaCloud\SDK\OSS\Models\GetObjectRequest;
use AlibabaCloud\SDK\OSS\Models\UploadPartRequest;
use AlibabaCloud\SDK\OSS\Models\GetBucketCORSRequest;
use AlibabaCloud\SDK\OSS\Models\GetBucketCORSResponse;
use AlibabaCloud\SDK\OSS\Models\CopyObjectRequest;
use AlibabaCloud\SDK\OSS\Models\CopyObjectResponse;
use AlibabaCloud\SDK\OSS\Models\GetObjectTaggingRequest;
use AlibabaCloud\SDK\OSS\Models\GetObjectTaggingResponse;
use AlibabaCloud\SDK\OSS\Models\DeleteBucketLifecycleRequest;
use AlibabaCloud\SDK\OSS\Models\DeleteBucketLoggingRequest;
use AlibabaCloud\SDK\OSS\Models\DeleteBucketWebsiteRequest;
use AlibabaCloud\SDK\OSS\Models\GetSymlinkRequest;
use AlibabaCloud\SDK\OSS\Models\GetBucketLifecycleRequest;
use AlibabaCloud\SDK\OSS\Models\GetBucketLifecycleResponse;
use AlibabaCloud\SDK\OSS\Models\PutSymlinkRequest;
use AlibabaCloud\SDK\OSS\Models\GetBucketRefererRequest;
use AlibabaCloud\SDK\OSS\Models\GetBucketRefererResponse;
use AlibabaCloud\SDK\OSS\Models\CallbackRequest;
use AlibabaCloud\SDK\OSS\Models\GetBucketLoggingRequest;
use AlibabaCloud\SDK\OSS\Models\GetBucketLoggingResponse;
use AlibabaCloud\SDK\OSS\Models\PutObjectAclRequest;
use AlibabaCloud\SDK\OSS\Models\GetBucketInfoRequest;
use AlibabaCloud\SDK\OSS\Models\GetBucketInfoResponse;
use AlibabaCloud\SDK\OSS\Models\PutLiveChannelStatusRequest;
use AlibabaCloud\SDK\OSS\Models\InitiateMultipartUploadRequest;
use AlibabaCloud\SDK\OSS\Models\InitiateMultipartUploadResponse;
use AlibabaCloud\SDK\OSS\Models\OptionObjectRequest;
use AlibabaCloud\SDK\OSS\Models\PostVodPlaylistRequest;
use AlibabaCloud\SDK\OSS\Models\PostObjectRequest;
use AlibabaCloud\SDK\OSS\Models\PostObjectResponse;
use AlibabaCloud\SDK\OSS\Models\HeadObjectRequest;
use AlibabaCloud\SDK\OSS\Models\DeleteObjectTaggingRequest;
use AlibabaCloud\SDK\OSS\Models\RestoreObjectRequest;
use AlibabaCloud\SDK\OSS\Models\GetObjectAclRequest;
use AlibabaCloud\SDK\OSS\Models\GetObjectAclResponse;
use AlibabaCloud\SDK\OSS\Models\PutBucketAclRequest;
use AlibabaCloud\SDK\OSS\Models\DeleteBucketRequest;
use AlibabaCloud\SDK\OSS\Models\PutObjectRequest;
use AlibabaCloud\SDK\OSS\Models\Config;

class Client
{
    protected $_name = [];

    private $_endpoint;

    private $_regionId;

    private $_hostModel;

    private $_protocol;

    private $_readTimeout;

    private $_connectTimeout;

    private $_signatureVersion;

    private $_addtionalHeaders;

    private $_localAddr;

    private $_httpProxy;

    private $_httpsProxy;

    private $_noProxy;

    private $_userAgent;

    private $_socks5Proxy;

    private $_isEnableCrc;

    private $_isEnableMD5;

    private $_socks5NetWork;

    private $_maxIdleConns;

    private $_credential;

    public function __construct(Config $config)
    {
        if (Utils::isUnset($config)) {
            throw new TeaError([
                "name"    => "ParameterMissing",
                "message" => "'config' can not be unset"
            ]);
        }
        if (Utils::_empty($config->type)) {
            $config->type = "access_key";
        }
        $credentialConfig  = new \AlibabaCloud\Credentials\Credential\Config([
            "accessKeyId"     => $config->accessKeyId,
            "type"            => $config->type,
            "accessKeySecret" => $config->accessKeySecret,
            "securityToken"   => $config->securityToken
        ]);
        $this->_credential = new Credential($credentialConfig);
        if (Utils::isUnset($config->isEnableMD5)) {
            $config->isEnableMD5 = false;
        }
        if (Utils::isUnset($config->isEnableCrc)) {
            $config->isEnableCrc = false;
        }
        $this->_endpoint         = $config->endpoint;
        $this->_protocol         = $config->protocol;
        $this->_regionId         = $config->regionId;
        $this->_userAgent        = $config->userAgent;
        $this->_readTimeout      = $config->readTimeout;
        $this->_connectTimeout   = $config->connectTimeout;
        $this->_localAddr        = $config->localAddr;
        $this->_httpProxy        = $config->httpProxy;
        $this->_httpsProxy       = $config->httpsProxy;
        $this->_noProxy          = $config->noProxy;
        $this->_socks5Proxy      = $config->socks5Proxy;
        $this->_socks5NetWork    = $config->socks5NetWork;
        $this->_maxIdleConns     = $config->maxIdleConns;
        $this->_signatureVersion = $config->signatureVersion;
        $this->_addtionalHeaders = $config->addtionalHeaders;
        $this->_hostModel        = $config->hostModel;
        $this->_isEnableMD5      = $config->isEnableMD5;
        $this->_isEnableCrc      = $config->isEnableCrc;
    }

    public function putBucketLifecycle(PutBucketLifecycleRequest $request, RuntimeOptions $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime     = [
            "timeouted"      => "retry",
            "readTimeout"    => Utils::defaultNumber($runtime->readTimeout, $this->_readTimeout),
            "connectTimeout" => Utils::defaultNumber($runtime->connectTimeout, $this->_connectTimeout),
            "localAddr"      => Utils::defaultString($runtime->localAddr, $this->_localAddr),
            "httpProxy"      => Utils::defaultString($runtime->httpProxy, $this->_httpProxy),
            "httpsProxy"     => Utils::defaultString($runtime->httpsProxy, $this->_httpsProxy),
            "noProxy"        => Utils::defaultString($runtime->noProxy, $this->_noProxy),
            "socks5Proxy"    => Utils::defaultString($runtime->socks5Proxy, $this->_socks5Proxy),
            "socks5NetWork"  => Utils::defaultString($runtime->socks5NetWork, $this->_socks5NetWork),
            "maxIdleConns"   => Utils::defaultNumber($runtime->maxIdleConns, $this->_maxIdleConns),
            "retry"          => [
                "retryable"   => $runtime->autoretry,
                "maxAttempts" => Utils::defaultNumber($runtime->maxAttempts, 3)
            ],
            "backoff"        => [
                "policy" => Utils::defaultString($runtime->backoffPolicy, "no"),
                "period" => Utils::defaultNumber($runtime->backoffPeriod, 1)
            ],
            "ignoreSSL"      => $runtime->ignoreSSL
        ];
        $_lastRequest = null;
        $_now         = time();
        $_retryTimes  = 0;

        while (Tea::allowRetry($_runtime["retry"], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime($_runtime["backoff"], $_retryTimes);
                if ($_backoffTime > 0) {
                    Tea::sleep($_backoffTime);
                }
            }
            $_retryTimes = $_retryTimes + 1;
            try {
                $_request           = new Request();
                $accessKeyId        = $this->_credential->getAccessKeyId();
                $accessKeySecret    = $this->_credential->getAccessKeySecret();
                $token              = $this->_credential->getSecurityToken();
                $reqBody            = XML::toXML($request->body);
                $_request->protocol = $this->_protocol;
                $_request->method   = "PUT";
                $_request->pathname = "/?lifecycle";
                $_request->headers  = [
                    "host"       => OSSUtils::getHost($request->bucketName, $this->_regionId, $this->_endpoint, $this->_hostModel),
                    "date"       => Utils::getDateUTCString(),
                    "user-agent" => $this->getUserAgent()
                ];
                if (!Utils::_empty($token)) {
                    $_request->headers["x-oss-security-token"] = $token;
                }
                $_request->body                     = $reqBody;
                $_request->headers["authorization"] = OSSUtils::getSignature($_request, $request->bucketName, $accessKeyId, $accessKeySecret, $this->_signatureVersion, $this->_addtionalHeaders);
                $_lastRequest                       = $_request;
                $_response                          = Tea::send($_request, $_runtime);
                $respMap                            = null;
                $bodyStr                            = null;
                if (Utils::is4xx($_response->statusCode) || Utils::is5xx($_response->statusCode)) {
                    $bodyStr = Utils::readAsString($_response->body);
                    $respMap = OSSUtils::getErrMessage($bodyStr);
                    throw new TeaError([
                        "code"    => $respMap["Code"],
                        "message" => $respMap["Message"],
                        "data"    => [
                            "httpCode"  => $_response->statusCode,
                            "requestId" => $respMap["RequestId"],
                            "hostId"    => $respMap["HostId"]
                        ]
                    ]);
                }
                return $_response->headers;
            } catch (\Exception $e) {
                if (Tea::isRetryable($e)) {
                    continue;
                }
                throw $e;
            }
        }
        throw new TeaUnableRetryError($_lastRequest);
    }

    public function deleteMultipleObjects(DeleteMultipleObjectsRequest $request, RuntimeOptions $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime     = [
            "timeouted"      => "retry",
            "readTimeout"    => Utils::defaultNumber($runtime->readTimeout, $this->_readTimeout),
            "connectTimeout" => Utils::defaultNumber($runtime->connectTimeout, $this->_connectTimeout),
            "localAddr"      => Utils::defaultString($runtime->localAddr, $this->_localAddr),
            "httpProxy"      => Utils::defaultString($runtime->httpProxy, $this->_httpProxy),
            "httpsProxy"     => Utils::defaultString($runtime->httpsProxy, $this->_httpsProxy),
            "noProxy"        => Utils::defaultString($runtime->noProxy, $this->_noProxy),
            "socks5Proxy"    => Utils::defaultString($runtime->socks5Proxy, $this->_socks5Proxy),
            "socks5NetWork"  => Utils::defaultString($runtime->socks5NetWork, $this->_socks5NetWork),
            "maxIdleConns"   => Utils::defaultNumber($runtime->maxIdleConns, $this->_maxIdleConns),
            "retry"          => [
                "retryable"   => $runtime->autoretry,
                "maxAttempts" => Utils::defaultNumber($runtime->maxAttempts, 3)
            ],
            "backoff"        => [
                "policy" => Utils::defaultString($runtime->backoffPolicy, "no"),
                "period" => Utils::defaultNumber($runtime->backoffPeriod, 1)
            ],
            "ignoreSSL"      => $runtime->ignoreSSL
        ];
        $_lastRequest = null;
        $_now         = time();
        $_retryTimes  = 0;
        while (Tea::allowRetry($_runtime["retry"], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime($_runtime["backoff"], $_retryTimes);
                if ($_backoffTime > 0) {
                    Tea::sleep($_backoffTime);
                }
            }
            $_retryTimes = $_retryTimes + 1;
            try {
                $_request           = new Request();
                $accessKeyId        = $this->_credential->getAccessKeyId();
                $accessKeySecret    = $this->_credential->getAccessKeySecret();
                $token              = $this->_credential->getSecurityToken();
                $reqBody            = XML::toXML($request->body);
                $_request->protocol = $this->_protocol;
                $_request->method   = "POST";
                $_request->pathname = "/?delete";
                $_request->headers  = [
                    "host"       => OSSUtils::getHost($request->bucketName, $this->_regionId, $this->_endpoint, $this->_hostModel),
                    "date"       => Utils::getDateUTCString(),
                    "user-agent" => $this->getUserAgent(),
                    Utils::stringifyMapValue($request->header)
                ];
                if (!Utils::_empty($token)) {
                    $_request->headers["x-oss-security-token"] = $token;
                }
                $_request->body = $reqBody;
                if (Utils::isUnset($request->header) && !Utils::_empty($request->header->contentMD5)) {
                    $_request->headers["content-md5"] = $request->header->contentMD5;
                } else {
                    $_request->headers["content-md5"] = OSSUtils::getContentMD5($reqBody, $this->_isEnableMD5);
                }
                $_request->headers["authorization"] = OSSUtils::getSignature($_request, $request->bucketName, $accessKeyId, $accessKeySecret, $this->_signatureVersion, $this->_addtionalHeaders);
                $_lastRequest                       = $_request;
                $_response                          = Tea::send($_request, $_runtime);
                $respMap                            = null;
                $bodyStr                            = null;
                if (Utils::is4xx($_response->statusCode) || Utils::is5xx($_response->statusCode)) {
                    $bodyStr = Utils::readAsString($_response->body);
                    $respMap = OSSUtils::getErrMessage($bodyStr);
                    throw new TeaError([
                        "code"    => $respMap["Code"],
                        "message" => $respMap["Message"],
                        "data"    => [
                            "httpCode"  => $_response->statusCode,
                            "requestId" => $respMap["RequestId"],
                            "hostId"    => $respMap["HostId"]
                        ]
                    ]);
                }
                $bodyStr = Utils::readAsString($_response->body);
                $respMap = XML::parseXml($bodyStr, DeleteMultipleObjectsResponse::class);
                return [
                    [
                        "DeleteResult" => $respMap["DeleteResult"],
                    ],
                    $_response->headers
                ];
            } catch (\Exception $e) {
                if (Tea::isRetryable($e)) {
                    continue;
                }
                throw $e;
            }
        }
        throw new TeaUnableRetryError($_lastRequest);
    }

    public function putBucketReferer(PutBucketRefererRequest $request, RuntimeOptions $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime     = [
            "timeouted"      => "retry",
            "readTimeout"    => Utils::defaultNumber($runtime->readTimeout, $this->_readTimeout),
            "connectTimeout" => Utils::defaultNumber($runtime->connectTimeout, $this->_connectTimeout),
            "localAddr"      => Utils::defaultString($runtime->localAddr, $this->_localAddr),
            "httpProxy"      => Utils::defaultString($runtime->httpProxy, $this->_httpProxy),
            "httpsProxy"     => Utils::defaultString($runtime->httpsProxy, $this->_httpsProxy),
            "noProxy"        => Utils::defaultString($runtime->noProxy, $this->_noProxy),
            "socks5Proxy"    => Utils::defaultString($runtime->socks5Proxy, $this->_socks5Proxy),
            "socks5NetWork"  => Utils::defaultString($runtime->socks5NetWork, $this->_socks5NetWork),
            "maxIdleConns"   => Utils::defaultNumber($runtime->maxIdleConns, $this->_maxIdleConns),
            "retry"          => [
                "retryable"   => $runtime->autoretry,
                "maxAttempts" => Utils::defaultNumber($runtime->maxAttempts, 3)
            ],
            "backoff"        => [
                "policy" => Utils::defaultString($runtime->backoffPolicy, "no"),
                "period" => Utils::defaultNumber($runtime->backoffPeriod, 1)
            ],
            "ignoreSSL"      => $runtime->ignoreSSL
        ];
        $_lastRequest = null;
        $_now         = time();
        $_retryTimes  = 0;
        while (Tea::allowRetry($_runtime["retry"], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime($_runtime["backoff"], $_retryTimes);
                if ($_backoffTime > 0) {
                    Tea::sleep($_backoffTime);
                }
            }
            $_retryTimes = $_retryTimes + 1;
            try {
                $_request           = new Request();
                $accessKeyId        = $this->_credential->getAccessKeyId();
                $accessKeySecret    = $this->_credential->getAccessKeySecret();
                $token              = $this->_credential->getSecurityToken();
                $reqBody            = XML::toXML($request->body);
                $_request->protocol = $this->_protocol;
                $_request->method   = "PUT";
                $_request->pathname = "/?referer";
                $_request->headers  = [
                    "host"       => OSSUtils::getHost($request->bucketName, $this->_regionId, $this->_endpoint, $this->_hostModel),
                    "date"       => Utils::getDateUTCString(),
                    "user-agent" => $this->getUserAgent()
                ];
                if (!Utils::_empty($token)) {
                    $_request->headers["x-oss-security-token"] = $token;
                }
                $_request->body                     = $reqBody;
                $_request->headers["authorization"] = OSSUtils::getSignature($_request, $request->bucketName, $accessKeyId, $accessKeySecret, $this->_signatureVersion, $this->_addtionalHeaders);
                $_lastRequest                       = $_request;
                $_response                          = Tea::send($_request, $_runtime);
                $respMap                            = null;
                $bodyStr                            = null;
                if (Utils::is4xx($_response->statusCode) || Utils::is5xx($_response->statusCode)) {
                    $bodyStr = Utils::readAsString($_response->body);
                    $respMap = OSSUtils::getErrMessage($bodyStr);
                    throw new TeaError([
                        "code"    => $respMap["Code"],
                        "message" => $respMap["Message"],
                        "data"    => [
                            "httpCode"  => $_response->statusCode,
                            "requestId" => $respMap["RequestId"],
                            "hostId"    => $respMap["HostId"]
                        ]
                    ]);
                }
                return $_response->headers;
            } catch (\Exception $e) {
                if (Tea::isRetryable($e)) {
                    continue;
                }
                throw $e;
            }
        }
        throw new TeaUnableRetryError($_lastRequest);
    }

    public function putBucketWebsite(PutBucketWebsiteRequest $request, RuntimeOptions $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime     = [
            "timeouted"      => "retry",
            "readTimeout"    => Utils::defaultNumber($runtime->readTimeout, $this->_readTimeout),
            "connectTimeout" => Utils::defaultNumber($runtime->connectTimeout, $this->_connectTimeout),
            "localAddr"      => Utils::defaultString($runtime->localAddr, $this->_localAddr),
            "httpProxy"      => Utils::defaultString($runtime->httpProxy, $this->_httpProxy),
            "httpsProxy"     => Utils::defaultString($runtime->httpsProxy, $this->_httpsProxy),
            "noProxy"        => Utils::defaultString($runtime->noProxy, $this->_noProxy),
            "socks5Proxy"    => Utils::defaultString($runtime->socks5Proxy, $this->_socks5Proxy),
            "socks5NetWork"  => Utils::defaultString($runtime->socks5NetWork, $this->_socks5NetWork),
            "maxIdleConns"   => Utils::defaultNumber($runtime->maxIdleConns, $this->_maxIdleConns),
            "retry"          => [
                "retryable"   => $runtime->autoretry,
                "maxAttempts" => Utils::defaultNumber($runtime->maxAttempts, 3)
            ],
            "backoff"        => [
                "policy" => Utils::defaultString($runtime->backoffPolicy, "no"),
                "period" => Utils::defaultNumber($runtime->backoffPeriod, 1)
            ],
            "ignoreSSL"      => $runtime->ignoreSSL
        ];
        $_lastRequest = null;
        $_now         = time();
        $_retryTimes  = 0;
        while (Tea::allowRetry($_runtime["retry"], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime($_runtime["backoff"], $_retryTimes);
                if ($_backoffTime > 0) {
                    Tea::sleep($_backoffTime);
                }
            }
            $_retryTimes = $_retryTimes + 1;
            try {
                $_request           = new Request();
                $accessKeyId        = $this->_credential->getAccessKeyId();
                $accessKeySecret    = $this->_credential->getAccessKeySecret();
                $token              = $this->_credential->getSecurityToken();
                $reqBody            = XML::toXML($request->body);
                $_request->protocol = $this->_protocol;
                $_request->method   = "PUT";
                $_request->pathname = "/?website";
                $_request->headers  = [
                    "host"       => OSSUtils::getHost($request->bucketName, $this->_regionId, $this->_endpoint, $this->_hostModel),
                    "date"       => Utils::getDateUTCString(),
                    "user-agent" => $this->getUserAgent()
                ];
                if (!Utils::_empty($token)) {
                    $_request->headers["x-oss-security-token"] = $token;
                }
                $_request->body                     = $reqBody;
                $_request->headers["authorization"] = OSSUtils::getSignature($_request, $request->bucketName, $accessKeyId, $accessKeySecret, $this->_signatureVersion, $this->_addtionalHeaders);
                $_lastRequest                       = $_request;
                $_response                          = Tea::send($_request, $_runtime);
                $respMap                            = null;
                $bodyStr                            = null;
                if (Utils::is4xx($_response->statusCode) || Utils::is5xx($_response->statusCode)) {
                    $bodyStr = Utils::readAsString($_response->body);
                    $respMap = OSSUtils::getErrMessage($bodyStr);
                    throw new TeaError([
                        "code"    => $respMap["Code"],
                        "message" => $respMap["Message"],
                        "data"    => [
                            "httpCode"  => $_response->statusCode,
                            "requestId" => $respMap["RequestId"],
                            "hostId"    => $respMap["HostId"]
                        ]
                    ]);
                }
                return $_response->headers;
            } catch (\Exception $e) {
                if (Tea::isRetryable($e)) {
                    continue;
                }
                throw $e;
            }
        }
        throw new TeaUnableRetryError($_lastRequest);
    }

    public function completeMultipartUpload(CompleteMultipartUploadRequest $request, RuntimeOptions $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime     = [
            "timeouted"      => "retry",
            "readTimeout"    => Utils::defaultNumber($runtime->readTimeout, $this->_readTimeout),
            "connectTimeout" => Utils::defaultNumber($runtime->connectTimeout, $this->_connectTimeout),
            "localAddr"      => Utils::defaultString($runtime->localAddr, $this->_localAddr),
            "httpProxy"      => Utils::defaultString($runtime->httpProxy, $this->_httpProxy),
            "httpsProxy"     => Utils::defaultString($runtime->httpsProxy, $this->_httpsProxy),
            "noProxy"        => Utils::defaultString($runtime->noProxy, $this->_noProxy),
            "socks5Proxy"    => Utils::defaultString($runtime->socks5Proxy, $this->_socks5Proxy),
            "socks5NetWork"  => Utils::defaultString($runtime->socks5NetWork, $this->_socks5NetWork),
            "maxIdleConns"   => Utils::defaultNumber($runtime->maxIdleConns, $this->_maxIdleConns),
            "retry"          => [
                "retryable"   => $runtime->autoretry,
                "maxAttempts" => Utils::defaultNumber($runtime->maxAttempts, 3)
            ],
            "backoff"        => [
                "policy" => Utils::defaultString($runtime->backoffPolicy, "no"),
                "period" => Utils::defaultNumber($runtime->backoffPeriod, 1)
            ],
            "ignoreSSL"      => $runtime->ignoreSSL
        ];
        $_lastRequest = null;
        $_now         = time();
        $_retryTimes  = 0;
        while (Tea::allowRetry($_runtime["retry"], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime($_runtime["backoff"], $_retryTimes);
                if ($_backoffTime > 0) {
                    Tea::sleep($_backoffTime);
                }
            }
            $_retryTimes = $_retryTimes + 1;
            try {
                $_request           = new Request();
                $accessKeyId        = $this->_credential->getAccessKeyId();
                $accessKeySecret    = $this->_credential->getAccessKeySecret();
                $token              = $this->_credential->getSecurityToken();
                $reqBody            = XML::toXML($request->body);
                $_request->protocol = $this->_protocol;
                $_request->method   = "POST";
                $_request->pathname = "/" . $request->objectName . "";
                $_request->headers  = [
                    "host"       => OSSUtils::getHost($request->bucketName, $this->_regionId, $this->_endpoint, $this->_hostModel),
                    "date"       => Utils::getDateUTCString(),
                    "user-agent" => $this->getUserAgent()
                ];
                if (!Utils::_empty($token)) {
                    $_request->headers["x-oss-security-token"] = $token;
                }
                $_request->query                    = Utils::stringifyMapValue($request->filter);
                $_request->body                     = $reqBody;
                $_request->headers["authorization"] = OSSUtils::getSignature($_request, $request->bucketName, $accessKeyId, $accessKeySecret, $this->_signatureVersion, $this->_addtionalHeaders);
                $_lastRequest                       = $_request;
                $_response                          = Tea::send($_request, $_runtime);
                $respMap                            = null;
                $bodyStr                            = null;
                if (Utils::is4xx($_response->statusCode) || Utils::is5xx($_response->statusCode)) {
                    $bodyStr = Utils::readAsString($_response->body);
                    $respMap = OSSUtils::getErrMessage($bodyStr);
                    throw new TeaError([
                        "code"    => $respMap["Code"],
                        "message" => $respMap["Message"],
                        "data"    => [
                            "httpCode"  => $_response->statusCode,
                            "requestId" => $respMap["RequestId"],
                            "hostId"    => $respMap["HostId"]
                        ]
                    ]);
                }
                $bodyStr = Utils::readAsString($_response->body);
                $respMap = XML::parseXml($bodyStr, CompleteMultipartUploadResponse::class);
                return [
                    [
                        "CompleteMultipartUploadResult" => $respMap["CompleteMultipartUploadResult"],
                    ],
                    $_response->headers
                ];
            } catch (\Exception $e) {
                if (Tea::isRetryable($e)) {
                    continue;
                }
                throw $e;
            }
        }
        throw new TeaUnableRetryError($_lastRequest);
    }

    public function putBucketLogging(PutBucketLoggingRequest $request, RuntimeOptions $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime     = [
            "timeouted"      => "retry",
            "readTimeout"    => Utils::defaultNumber($runtime->readTimeout, $this->_readTimeout),
            "connectTimeout" => Utils::defaultNumber($runtime->connectTimeout, $this->_connectTimeout),
            "localAddr"      => Utils::defaultString($runtime->localAddr, $this->_localAddr),
            "httpProxy"      => Utils::defaultString($runtime->httpProxy, $this->_httpProxy),
            "httpsProxy"     => Utils::defaultString($runtime->httpsProxy, $this->_httpsProxy),
            "noProxy"        => Utils::defaultString($runtime->noProxy, $this->_noProxy),
            "socks5Proxy"    => Utils::defaultString($runtime->socks5Proxy, $this->_socks5Proxy),
            "socks5NetWork"  => Utils::defaultString($runtime->socks5NetWork, $this->_socks5NetWork),
            "maxIdleConns"   => Utils::defaultNumber($runtime->maxIdleConns, $this->_maxIdleConns),
            "retry"          => [
                "retryable"   => $runtime->autoretry,
                "maxAttempts" => Utils::defaultNumber($runtime->maxAttempts, 3)
            ],
            "backoff"        => [
                "policy" => Utils::defaultString($runtime->backoffPolicy, "no"),
                "period" => Utils::defaultNumber($runtime->backoffPeriod, 1)
            ],
            "ignoreSSL"      => $runtime->ignoreSSL
        ];
        $_lastRequest = null;
        $_now         = time();
        $_retryTimes  = 0;
        while (Tea::allowRetry($_runtime["retry"], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime($_runtime["backoff"], $_retryTimes);
                if ($_backoffTime > 0) {
                    Tea::sleep($_backoffTime);
                }
            }
            $_retryTimes = $_retryTimes + 1;
            try {
                $_request           = new Request();
                $accessKeyId        = $this->_credential->getAccessKeyId();
                $accessKeySecret    = $this->_credential->getAccessKeySecret();
                $token              = $this->_credential->getSecurityToken();
                $reqBody            = XML::toXML($request->body);
                $_request->protocol = $this->_protocol;
                $_request->method   = "PUT";
                $_request->pathname = "/?logging";
                $_request->headers  = [
                    "host"       => OSSUtils::getHost($request->bucketName, $this->_regionId, $this->_endpoint, $this->_hostModel),
                    "date"       => Utils::getDateUTCString(),
                    "user-agent" => $this->getUserAgent()
                ];
                if (!Utils::_empty($token)) {
                    $_request->headers["x-oss-security-token"] = $token;
                }
                $_request->body                     = $reqBody;
                $_request->headers["authorization"] = OSSUtils::getSignature($_request, $request->bucketName, $accessKeyId, $accessKeySecret, $this->_signatureVersion, $this->_addtionalHeaders);
                $_lastRequest                       = $_request;
                $_response                          = Tea::send($_request, $_runtime);
                $respMap                            = null;
                $bodyStr                            = null;
                if (Utils::is4xx($_response->statusCode) || Utils::is5xx($_response->statusCode)) {
                    $bodyStr = Utils::readAsString($_response->body);
                    $respMap = OSSUtils::getErrMessage($bodyStr);
                    throw new TeaError([
                        "code"    => $respMap["Code"],
                        "message" => $respMap["Message"],
                        "data"    => [
                            "httpCode"  => $_response->statusCode,
                            "requestId" => $respMap["RequestId"],
                            "hostId"    => $respMap["HostId"]
                        ]
                    ]);
                }
                return $_response->headers;
            } catch (\Exception $e) {
                if (Tea::isRetryable($e)) {
                    continue;
                }
                throw $e;
            }
        }
        throw new TeaUnableRetryError($_lastRequest);
    }

    public function putBucketRequestPayment(PutBucketRequestPaymentRequest $request, RuntimeOptions $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime     = [
            "timeouted"      => "retry",
            "readTimeout"    => Utils::defaultNumber($runtime->readTimeout, $this->_readTimeout),
            "connectTimeout" => Utils::defaultNumber($runtime->connectTimeout, $this->_connectTimeout),
            "localAddr"      => Utils::defaultString($runtime->localAddr, $this->_localAddr),
            "httpProxy"      => Utils::defaultString($runtime->httpProxy, $this->_httpProxy),
            "httpsProxy"     => Utils::defaultString($runtime->httpsProxy, $this->_httpsProxy),
            "noProxy"        => Utils::defaultString($runtime->noProxy, $this->_noProxy),
            "socks5Proxy"    => Utils::defaultString($runtime->socks5Proxy, $this->_socks5Proxy),
            "socks5NetWork"  => Utils::defaultString($runtime->socks5NetWork, $this->_socks5NetWork),
            "maxIdleConns"   => Utils::defaultNumber($runtime->maxIdleConns, $this->_maxIdleConns),
            "retry"          => [
                "retryable"   => $runtime->autoretry,
                "maxAttempts" => Utils::defaultNumber($runtime->maxAttempts, 3)
            ],
            "backoff"        => [
                "policy" => Utils::defaultString($runtime->backoffPolicy, "no"),
                "period" => Utils::defaultNumber($runtime->backoffPeriod, 1)
            ],
            "ignoreSSL"      => $runtime->ignoreSSL
        ];
        $_lastRequest = null;
        $_now         = time();
        $_retryTimes  = 0;
        while (Tea::allowRetry($_runtime["retry"], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime($_runtime["backoff"], $_retryTimes);
                if ($_backoffTime > 0) {
                    Tea::sleep($_backoffTime);
                }
            }
            $_retryTimes = $_retryTimes + 1;
            try {
                $_request           = new Request();
                $accessKeyId        = $this->_credential->getAccessKeyId();
                $accessKeySecret    = $this->_credential->getAccessKeySecret();
                $token              = $this->_credential->getSecurityToken();
                $reqBody            = XML::toXML($request->body);
                $_request->protocol = $this->_protocol;
                $_request->method   = "PUT";
                $_request->pathname = "/?requestPayment";
                $_request->headers  = [
                    "host"       => OSSUtils::getHost($request->bucketName, $this->_regionId, $this->_endpoint, $this->_hostModel),
                    "date"       => Utils::getDateUTCString(),
                    "user-agent" => $this->getUserAgent()
                ];
                if (!Utils::_empty($token)) {
                    $_request->headers["x-oss-security-token"] = $token;
                }
                $_request->body                     = $reqBody;
                $_request->headers["authorization"] = OSSUtils::getSignature($_request, $request->bucketName, $accessKeyId, $accessKeySecret, $this->_signatureVersion, $this->_addtionalHeaders);
                $_lastRequest                       = $_request;
                $_response                          = Tea::send($_request, $_runtime);
                $respMap                            = null;
                $bodyStr                            = null;
                if (Utils::is4xx($_response->statusCode) || Utils::is5xx($_response->statusCode)) {
                    $bodyStr = Utils::readAsString($_response->body);
                    $respMap = OSSUtils::getErrMessage($bodyStr);
                    throw new TeaError([
                        "code"    => $respMap["Code"],
                        "message" => $respMap["Message"],
                        "data"    => [
                            "httpCode"  => $_response->statusCode,
                            "requestId" => $respMap["RequestId"],
                            "hostId"    => $respMap["HostId"]
                        ]
                    ]);
                }
                return $_response->headers;
            } catch (\Exception $e) {
                if (Tea::isRetryable($e)) {
                    continue;
                }
                throw $e;
            }
        }
        throw new TeaUnableRetryError($_lastRequest);
    }

    public function putBucketEncryption(PutBucketEncryptionRequest $request, RuntimeOptions $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime     = [
            "timeouted"      => "retry",
            "readTimeout"    => Utils::defaultNumber($runtime->readTimeout, $this->_readTimeout),
            "connectTimeout" => Utils::defaultNumber($runtime->connectTimeout, $this->_connectTimeout),
            "localAddr"      => Utils::defaultString($runtime->localAddr, $this->_localAddr),
            "httpProxy"      => Utils::defaultString($runtime->httpProxy, $this->_httpProxy),
            "httpsProxy"     => Utils::defaultString($runtime->httpsProxy, $this->_httpsProxy),
            "noProxy"        => Utils::defaultString($runtime->noProxy, $this->_noProxy),
            "socks5Proxy"    => Utils::defaultString($runtime->socks5Proxy, $this->_socks5Proxy),
            "socks5NetWork"  => Utils::defaultString($runtime->socks5NetWork, $this->_socks5NetWork),
            "maxIdleConns"   => Utils::defaultNumber($runtime->maxIdleConns, $this->_maxIdleConns),
            "retry"          => [
                "retryable"   => $runtime->autoretry,
                "maxAttempts" => Utils::defaultNumber($runtime->maxAttempts, 3)
            ],
            "backoff"        => [
                "policy" => Utils::defaultString($runtime->backoffPolicy, "no"),
                "period" => Utils::defaultNumber($runtime->backoffPeriod, 1)
            ],
            "ignoreSSL"      => $runtime->ignoreSSL
        ];
        $_lastRequest = null;
        $_now         = time();
        $_retryTimes  = 0;
        while (Tea::allowRetry($_runtime["retry"], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime($_runtime["backoff"], $_retryTimes);
                if ($_backoffTime > 0) {
                    Tea::sleep($_backoffTime);
                }
            }
            $_retryTimes = $_retryTimes + 1;
            try {
                $_request           = new Request();
                $accessKeyId        = $this->_credential->getAccessKeyId();
                $accessKeySecret    = $this->_credential->getAccessKeySecret();
                $token              = $this->_credential->getSecurityToken();
                $reqBody            = XML::toXML($request->body);
                $_request->protocol = $this->_protocol;
                $_request->method   = "PUT";
                $_request->pathname = "/?encryption";
                $_request->headers  = [
                    "host"       => OSSUtils::getHost($request->bucketName, $this->_regionId, $this->_endpoint, $this->_hostModel),
                    "date"       => Utils::getDateUTCString(),
                    "user-agent" => $this->getUserAgent()
                ];
                if (!Utils::_empty($token)) {
                    $_request->headers["x-oss-security-token"] = $token;
                }
                $_request->body                     = $reqBody;
                $_request->headers["authorization"] = OSSUtils::getSignature($_request, $request->bucketName, $accessKeyId, $accessKeySecret, $this->_signatureVersion, $this->_addtionalHeaders);
                $_lastRequest                       = $_request;
                $_response                          = Tea::send($_request, $_runtime);
                $respMap                            = null;
                $bodyStr                            = null;
                if (Utils::is4xx($_response->statusCode) || Utils::is5xx($_response->statusCode)) {
                    $bodyStr = Utils::readAsString($_response->body);
                    $respMap = OSSUtils::getErrMessage($bodyStr);
                    throw new TeaError([
                        "code"    => $respMap["Code"],
                        "message" => $respMap["Message"],
                        "data"    => [
                            "httpCode"  => $_response->statusCode,
                            "requestId" => $respMap["RequestId"],
                            "hostId"    => $respMap["HostId"]
                        ]
                    ]);
                }
                return $_response->headers;
            } catch (\Exception $e) {
                if (Tea::isRetryable($e)) {
                    continue;
                }
                throw $e;
            }
        }
        throw new TeaUnableRetryError($_lastRequest);
    }

    public function putLiveChannel(PutLiveChannelRequest $request, RuntimeOptions $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime     = [
            "timeouted"      => "retry",
            "readTimeout"    => Utils::defaultNumber($runtime->readTimeout, $this->_readTimeout),
            "connectTimeout" => Utils::defaultNumber($runtime->connectTimeout, $this->_connectTimeout),
            "localAddr"      => Utils::defaultString($runtime->localAddr, $this->_localAddr),
            "httpProxy"      => Utils::defaultString($runtime->httpProxy, $this->_httpProxy),
            "httpsProxy"     => Utils::defaultString($runtime->httpsProxy, $this->_httpsProxy),
            "noProxy"        => Utils::defaultString($runtime->noProxy, $this->_noProxy),
            "socks5Proxy"    => Utils::defaultString($runtime->socks5Proxy, $this->_socks5Proxy),
            "socks5NetWork"  => Utils::defaultString($runtime->socks5NetWork, $this->_socks5NetWork),
            "maxIdleConns"   => Utils::defaultNumber($runtime->maxIdleConns, $this->_maxIdleConns),
            "retry"          => [
                "retryable"   => $runtime->autoretry,
                "maxAttempts" => Utils::defaultNumber($runtime->maxAttempts, 3)
            ],
            "backoff"        => [
                "policy" => Utils::defaultString($runtime->backoffPolicy, "no"),
                "period" => Utils::defaultNumber($runtime->backoffPeriod, 1)
            ],
            "ignoreSSL"      => $runtime->ignoreSSL
        ];
        $_lastRequest = null;
        $_now         = time();
        $_retryTimes  = 0;
        while (Tea::allowRetry($_runtime["retry"], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime($_runtime["backoff"], $_retryTimes);
                if ($_backoffTime > 0) {
                    Tea::sleep($_backoffTime);
                }
            }
            $_retryTimes = $_retryTimes + 1;
            try {
                $_request           = new Request();
                $accessKeyId        = $this->_credential->getAccessKeyId();
                $accessKeySecret    = $this->_credential->getAccessKeySecret();
                $token              = $this->_credential->getSecurityToken();
                $reqBody            = XML::toXML($request->body);
                $_request->protocol = $this->_protocol;
                $_request->method   = "PUT";
                $_request->pathname = "/" . $request->channelName . "?live";
                $_request->headers  = [
                    "host"       => OSSUtils::getHost($request->bucketName, $this->_regionId, $this->_endpoint, $this->_hostModel),
                    "date"       => Utils::getDateUTCString(),
                    "user-agent" => $this->getUserAgent()
                ];
                if (!Utils::_empty($token)) {
                    $_request->headers["x-oss-security-token"] = $token;
                }
                $_request->body                     = $reqBody;
                $_request->headers["authorization"] = OSSUtils::getSignature($_request, $request->bucketName, $accessKeyId, $accessKeySecret, $this->_signatureVersion, $this->_addtionalHeaders);
                $_lastRequest                       = $_request;
                $_response                          = Tea::send($_request, $_runtime);
                $respMap                            = null;
                $bodyStr                            = null;
                if (Utils::is4xx($_response->statusCode) || Utils::is5xx($_response->statusCode)) {
                    $bodyStr = Utils::readAsString($_response->body);
                    $respMap = OSSUtils::getErrMessage($bodyStr);
                    throw new TeaError([
                        "code"    => $respMap["Code"],
                        "message" => $respMap["Message"],
                        "data"    => [
                            "httpCode"  => $_response->statusCode,
                            "requestId" => $respMap["RequestId"],
                            "hostId"    => $respMap["HostId"]
                        ]
                    ]);
                }
                $bodyStr = Utils::readAsString($_response->body);
                $respMap = XML::parseXml($bodyStr, PutLiveChannelResponse::class);
                return [
                    [
                        "CreateLiveChannelResult" => $respMap["CreateLiveChannelResult"],
                    ],
                    $_response->headers
                ];
            } catch (\Exception $e) {
                if (Tea::isRetryable($e)) {
                    continue;
                }
                throw $e;
            }
        }
        throw new TeaUnableRetryError($_lastRequest);
    }

    public function putBucketTags(PutBucketTagsRequest $request, RuntimeOptions $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime     = [
            "timeouted"      => "retry",
            "readTimeout"    => Utils::defaultNumber($runtime->readTimeout, $this->_readTimeout),
            "connectTimeout" => Utils::defaultNumber($runtime->connectTimeout, $this->_connectTimeout),
            "localAddr"      => Utils::defaultString($runtime->localAddr, $this->_localAddr),
            "httpProxy"      => Utils::defaultString($runtime->httpProxy, $this->_httpProxy),
            "httpsProxy"     => Utils::defaultString($runtime->httpsProxy, $this->_httpsProxy),
            "noProxy"        => Utils::defaultString($runtime->noProxy, $this->_noProxy),
            "socks5Proxy"    => Utils::defaultString($runtime->socks5Proxy, $this->_socks5Proxy),
            "socks5NetWork"  => Utils::defaultString($runtime->socks5NetWork, $this->_socks5NetWork),
            "maxIdleConns"   => Utils::defaultNumber($runtime->maxIdleConns, $this->_maxIdleConns),
            "retry"          => [
                "retryable"   => $runtime->autoretry,
                "maxAttempts" => Utils::defaultNumber($runtime->maxAttempts, 3)
            ],
            "backoff"        => [
                "policy" => Utils::defaultString($runtime->backoffPolicy, "no"),
                "period" => Utils::defaultNumber($runtime->backoffPeriod, 1)
            ],
            "ignoreSSL"      => $runtime->ignoreSSL
        ];
        $_lastRequest = null;
        $_now         = time();
        $_retryTimes  = 0;
        while (Tea::allowRetry($_runtime["retry"], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime($_runtime["backoff"], $_retryTimes);
                if ($_backoffTime > 0) {
                    Tea::sleep($_backoffTime);
                }
            }
            $_retryTimes = $_retryTimes + 1;
            try {
                $_request           = new Request();
                $accessKeyId        = $this->_credential->getAccessKeyId();
                $accessKeySecret    = $this->_credential->getAccessKeySecret();
                $token              = $this->_credential->getSecurityToken();
                $reqBody            = XML::toXML($request->body);
                $_request->protocol = $this->_protocol;
                $_request->method   = "PUT";
                $_request->pathname = "/?tagging";
                $_request->headers  = [
                    "host"       => OSSUtils::getHost($request->bucketName, $this->_regionId, $this->_endpoint, $this->_hostModel),
                    "date"       => Utils::getDateUTCString(),
                    "user-agent" => $this->getUserAgent()
                ];
                if (!Utils::_empty($token)) {
                    $_request->headers["x-oss-security-token"] = $token;
                }
                $_request->body                     = $reqBody;
                $_request->headers["authorization"] = OSSUtils::getSignature($_request, $request->bucketName, $accessKeyId, $accessKeySecret, $this->_signatureVersion, $this->_addtionalHeaders);
                $_lastRequest                       = $_request;
                $_response                          = Tea::send($_request, $_runtime);
                $respMap                            = null;
                $bodyStr                            = null;
                if (Utils::is4xx($_response->statusCode) || Utils::is5xx($_response->statusCode)) {
                    $bodyStr = Utils::readAsString($_response->body);
                    $respMap = OSSUtils::getErrMessage($bodyStr);
                    throw new TeaError([
                        "code"    => $respMap["Code"],
                        "message" => $respMap["Message"],
                        "data"    => [
                            "httpCode"  => $_response->statusCode,
                            "requestId" => $respMap["RequestId"],
                            "hostId"    => $respMap["HostId"]
                        ]
                    ]);
                }
                return $_response->headers;
            } catch (\Exception $e) {
                if (Tea::isRetryable($e)) {
                    continue;
                }
                throw $e;
            }
        }
        throw new TeaUnableRetryError($_lastRequest);
    }

    public function putObjectTagging(PutObjectTaggingRequest $request, RuntimeOptions $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime     = [
            "timeouted"      => "retry",
            "readTimeout"    => Utils::defaultNumber($runtime->readTimeout, $this->_readTimeout),
            "connectTimeout" => Utils::defaultNumber($runtime->connectTimeout, $this->_connectTimeout),
            "localAddr"      => Utils::defaultString($runtime->localAddr, $this->_localAddr),
            "httpProxy"      => Utils::defaultString($runtime->httpProxy, $this->_httpProxy),
            "httpsProxy"     => Utils::defaultString($runtime->httpsProxy, $this->_httpsProxy),
            "noProxy"        => Utils::defaultString($runtime->noProxy, $this->_noProxy),
            "socks5Proxy"    => Utils::defaultString($runtime->socks5Proxy, $this->_socks5Proxy),
            "socks5NetWork"  => Utils::defaultString($runtime->socks5NetWork, $this->_socks5NetWork),
            "maxIdleConns"   => Utils::defaultNumber($runtime->maxIdleConns, $this->_maxIdleConns),
            "retry"          => [
                "retryable"   => $runtime->autoretry,
                "maxAttempts" => Utils::defaultNumber($runtime->maxAttempts, 3)
            ],
            "backoff"        => [
                "policy" => Utils::defaultString($runtime->backoffPolicy, "no"),
                "period" => Utils::defaultNumber($runtime->backoffPeriod, 1)
            ],
            "ignoreSSL"      => $runtime->ignoreSSL
        ];
        $_lastRequest = null;
        $_now         = time();
        $_retryTimes  = 0;
        while (Tea::allowRetry($_runtime["retry"], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime($_runtime["backoff"], $_retryTimes);
                if ($_backoffTime > 0) {
                    Tea::sleep($_backoffTime);
                }
            }
            $_retryTimes = $_retryTimes + 1;
            try {
                $_request           = new Request();
                $accessKeyId        = $this->_credential->getAccessKeyId();
                $accessKeySecret    = $this->_credential->getAccessKeySecret();
                $token              = $this->_credential->getSecurityToken();
                $reqBody            = XML::toXML($request->body);
                $_request->protocol = $this->_protocol;
                $_request->method   = "PUT";
                $_request->pathname = "/" . $request->objectName . "?tagging";
                $_request->headers  = [
                    "host"       => OSSUtils::getHost($request->bucketName, $this->_regionId, $this->_endpoint, $this->_hostModel),
                    "date"       => Utils::getDateUTCString(),
                    "user-agent" => $this->getUserAgent()
                ];
                if (!Utils::_empty($token)) {
                    $_request->headers["x-oss-security-token"] = $token;
                }
                $_request->body                     = $reqBody;
                $_request->headers["authorization"] = OSSUtils::getSignature($_request, $request->bucketName, $accessKeyId, $accessKeySecret, $this->_signatureVersion, $this->_addtionalHeaders);
                $_lastRequest                       = $_request;
                $_response                          = Tea::send($_request, $_runtime);
                $respMap                            = null;
                $bodyStr                            = null;
                if (Utils::is4xx($_response->statusCode) || Utils::is5xx($_response->statusCode)) {
                    $bodyStr = Utils::readAsString($_response->body);
                    $respMap = OSSUtils::getErrMessage($bodyStr);
                    throw new TeaError([
                        "code"    => $respMap["Code"],
                        "message" => $respMap["Message"],
                        "data"    => [
                            "httpCode"  => $_response->statusCode,
                            "requestId" => $respMap["RequestId"],
                            "hostId"    => $respMap["HostId"]
                        ]
                    ]);
                }
                return $_response->headers;
            } catch (\Exception $e) {
                if (Tea::isRetryable($e)) {
                    continue;
                }
                throw $e;
            }
        }
        throw new TeaUnableRetryError($_lastRequest);
    }

    public function selectObject(SelectObjectRequest $request, RuntimeOptions $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime     = [
            "timeouted"      => "retry",
            "readTimeout"    => Utils::defaultNumber($runtime->readTimeout, $this->_readTimeout),
            "connectTimeout" => Utils::defaultNumber($runtime->connectTimeout, $this->_connectTimeout),
            "localAddr"      => Utils::defaultString($runtime->localAddr, $this->_localAddr),
            "httpProxy"      => Utils::defaultString($runtime->httpProxy, $this->_httpProxy),
            "httpsProxy"     => Utils::defaultString($runtime->httpsProxy, $this->_httpsProxy),
            "noProxy"        => Utils::defaultString($runtime->noProxy, $this->_noProxy),
            "socks5Proxy"    => Utils::defaultString($runtime->socks5Proxy, $this->_socks5Proxy),
            "socks5NetWork"  => Utils::defaultString($runtime->socks5NetWork, $this->_socks5NetWork),
            "maxIdleConns"   => Utils::defaultNumber($runtime->maxIdleConns, $this->_maxIdleConns),
            "retry"          => [
                "retryable"   => $runtime->autoretry,
                "maxAttempts" => Utils::defaultNumber($runtime->maxAttempts, 3)
            ],
            "backoff"        => [
                "policy" => Utils::defaultString($runtime->backoffPolicy, "no"),
                "period" => Utils::defaultNumber($runtime->backoffPeriod, 1)
            ],
            "ignoreSSL"      => $runtime->ignoreSSL
        ];
        $_lastRequest = null;
        $_now         = time();
        $_retryTimes  = 0;
        while (Tea::allowRetry($_runtime["retry"], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime($_runtime["backoff"], $_retryTimes);
                if ($_backoffTime > 0) {
                    Tea::sleep($_backoffTime);
                }
            }
            $_retryTimes = $_retryTimes + 1;
            try {
                $_request           = new Request();
                $accessKeyId        = $this->_credential->getAccessKeyId();
                $accessKeySecret    = $this->_credential->getAccessKeySecret();
                $token              = $this->_credential->getSecurityToken();
                $reqBody            = XML::toXML($request->body);
                $_request->protocol = $this->_protocol;
                $_request->method   = "POST";
                $_request->pathname = "/" . $request->objectName . "";
                $_request->headers  = [
                    "host"       => OSSUtils::getHost($request->bucketName, $this->_regionId, $this->_endpoint, $this->_hostModel),
                    "date"       => Utils::getDateUTCString(),
                    "user-agent" => $this->getUserAgent()
                ];
                if (!Utils::_empty($token)) {
                    $_request->headers["x-oss-security-token"] = $token;
                }
                $_request->query                    = Utils::stringifyMapValue($request->filter);
                $_request->body                     = $reqBody;
                $_request->headers["authorization"] = OSSUtils::getSignature($_request, $request->bucketName, $accessKeyId, $accessKeySecret, $this->_signatureVersion, $this->_addtionalHeaders);
                $_lastRequest                       = $_request;
                $_response                          = Tea::send($_request, $_runtime);
                $respMap                            = null;
                $bodyStr                            = null;
                if (Utils::is4xx($_response->statusCode) || Utils::is5xx($_response->statusCode)) {
                    $bodyStr = Utils::readAsString($_response->body);
                    $respMap = OSSUtils::getErrMessage($bodyStr);
                    throw new TeaError([
                        "code"    => $respMap["Code"],
                        "message" => $respMap["Message"],
                        "data"    => [
                            "httpCode"  => $_response->statusCode,
                            "requestId" => $respMap["RequestId"],
                            "hostId"    => $respMap["HostId"]
                        ]
                    ]);
                }
                return $_response->headers;
            } catch (\Exception $e) {
                if (Tea::isRetryable($e)) {
                    continue;
                }
                throw $e;
            }
        }
        throw new TeaUnableRetryError($_lastRequest);
    }

    public function putBucketCORS(PutBucketCORSRequest $request, RuntimeOptions $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime     = [
            "timeouted"      => "retry",
            "readTimeout"    => Utils::defaultNumber($runtime->readTimeout, $this->_readTimeout),
            "connectTimeout" => Utils::defaultNumber($runtime->connectTimeout, $this->_connectTimeout),
            "localAddr"      => Utils::defaultString($runtime->localAddr, $this->_localAddr),
            "httpProxy"      => Utils::defaultString($runtime->httpProxy, $this->_httpProxy),
            "httpsProxy"     => Utils::defaultString($runtime->httpsProxy, $this->_httpsProxy),
            "noProxy"        => Utils::defaultString($runtime->noProxy, $this->_noProxy),
            "socks5Proxy"    => Utils::defaultString($runtime->socks5Proxy, $this->_socks5Proxy),
            "socks5NetWork"  => Utils::defaultString($runtime->socks5NetWork, $this->_socks5NetWork),
            "maxIdleConns"   => Utils::defaultNumber($runtime->maxIdleConns, $this->_maxIdleConns),
            "retry"          => [
                "retryable"   => $runtime->autoretry,
                "maxAttempts" => Utils::defaultNumber($runtime->maxAttempts, 3)
            ],
            "backoff"        => [
                "policy" => Utils::defaultString($runtime->backoffPolicy, "no"),
                "period" => Utils::defaultNumber($runtime->backoffPeriod, 1)
            ],
            "ignoreSSL"      => $runtime->ignoreSSL
        ];
        $_lastRequest = null;
        $_now         = time();
        $_retryTimes  = 0;
        while (Tea::allowRetry($_runtime["retry"], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime($_runtime["backoff"], $_retryTimes);
                if ($_backoffTime > 0) {
                    Tea::sleep($_backoffTime);
                }
            }
            $_retryTimes = $_retryTimes + 1;
            try {
                $_request           = new Request();
                $accessKeyId        = $this->_credential->getAccessKeyId();
                $accessKeySecret    = $this->_credential->getAccessKeySecret();
                $token              = $this->_credential->getSecurityToken();
                $reqBody            = XML::toXML($request->body);
                $_request->protocol = $this->_protocol;
                $_request->method   = "PUT";
                $_request->pathname = "/?cors";
                $_request->headers  = [
                    "host"       => OSSUtils::getHost($request->bucketName, $this->_regionId, $this->_endpoint, $this->_hostModel),
                    "date"       => Utils::getDateUTCString(),
                    "user-agent" => $this->getUserAgent()
                ];
                if (!Utils::_empty($token)) {
                    $_request->headers["x-oss-security-token"] = $token;
                }
                $_request->body                     = $reqBody;
                $_request->headers["authorization"] = OSSUtils::getSignature($_request, $request->bucketName, $accessKeyId, $accessKeySecret, $this->_signatureVersion, $this->_addtionalHeaders);
                $_lastRequest                       = $_request;
                $_response                          = Tea::send($_request, $_runtime);
                $respMap                            = null;
                $bodyStr                            = null;
                if (Utils::is4xx($_response->statusCode) || Utils::is5xx($_response->statusCode)) {
                    $bodyStr = Utils::readAsString($_response->body);
                    $respMap = OSSUtils::getErrMessage($bodyStr);
                    throw new TeaError([
                        "code"    => $respMap["Code"],
                        "message" => $respMap["Message"],
                        "data"    => [
                            "httpCode"  => $_response->statusCode,
                            "requestId" => $respMap["RequestId"],
                            "hostId"    => $respMap["HostId"]
                        ]
                    ]);
                }
                return $_response->headers;
            } catch (\Exception $e) {
                if (Tea::isRetryable($e)) {
                    continue;
                }
                throw $e;
            }
        }
        throw new TeaUnableRetryError($_lastRequest);
    }

    public function putBucket(PutBucketRequest $request, RuntimeOptions $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime     = [
            "timeouted"      => "retry",
            "readTimeout"    => Utils::defaultNumber($runtime->readTimeout, $this->_readTimeout),
            "connectTimeout" => Utils::defaultNumber($runtime->connectTimeout, $this->_connectTimeout),
            "localAddr"      => Utils::defaultString($runtime->localAddr, $this->_localAddr),
            "httpProxy"      => Utils::defaultString($runtime->httpProxy, $this->_httpProxy),
            "httpsProxy"     => Utils::defaultString($runtime->httpsProxy, $this->_httpsProxy),
            "noProxy"        => Utils::defaultString($runtime->noProxy, $this->_noProxy),
            "socks5Proxy"    => Utils::defaultString($runtime->socks5Proxy, $this->_socks5Proxy),
            "socks5NetWork"  => Utils::defaultString($runtime->socks5NetWork, $this->_socks5NetWork),
            "maxIdleConns"   => Utils::defaultNumber($runtime->maxIdleConns, $this->_maxIdleConns),
            "retry"          => [
                "retryable"   => $runtime->autoretry,
                "maxAttempts" => Utils::defaultNumber($runtime->maxAttempts, 3)
            ],
            "backoff"        => [
                "policy" => Utils::defaultString($runtime->backoffPolicy, "no"),
                "period" => Utils::defaultNumber($runtime->backoffPeriod, 1)
            ],
            "ignoreSSL"      => $runtime->ignoreSSL
        ];
        $_lastRequest = null;
        $_now         = time();
        $_retryTimes  = 0;
        while (Tea::allowRetry($_runtime["retry"], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime($_runtime["backoff"], $_retryTimes);
                if ($_backoffTime > 0) {
                    Tea::sleep($_backoffTime);
                }
            }
            $_retryTimes = $_retryTimes + 1;
            try {
                $_request           = new Request();
                $accessKeyId        = $this->_credential->getAccessKeyId();
                $accessKeySecret    = $this->_credential->getAccessKeySecret();
                $token              = $this->_credential->getSecurityToken();
                $reqBody            = XML::toXML($request->body);
                $_request->protocol = $this->_protocol;
                $_request->method   = "PUT";
                $_request->pathname = "/";
                $_request->headers  = [
                    "host"       => OSSUtils::getHost($request->bucketName, $this->_regionId, $this->_endpoint, $this->_hostModel),
                    "date"       => Utils::getDateUTCString(),
                    "user-agent" => $this->getUserAgent(),
                    Utils::stringifyMapValue($request->header)
                ];
                if (!Utils::_empty($token)) {
                    $_request->headers["x-oss-security-token"] = $token;
                }
                $_request->body                     = $reqBody;
                $_request->headers["authorization"] = OSSUtils::getSignature($_request, $request->bucketName, $accessKeyId, $accessKeySecret, $this->_signatureVersion, $this->_addtionalHeaders);
                $_lastRequest                       = $_request;
                $_response                          = Tea::send($_request, $_runtime);
                $respMap                            = null;
                $bodyStr                            = null;
                if (Utils::is4xx($_response->statusCode) || Utils::is5xx($_response->statusCode)) {
                    $bodyStr = Utils::readAsString($_response->body);
                    $respMap = OSSUtils::getErrMessage($bodyStr);
                    throw new TeaError([
                        "code"    => $respMap["Code"],
                        "message" => $respMap["Message"],
                        "data"    => [
                            "httpCode"  => $_response->statusCode,
                            "requestId" => $respMap["RequestId"],
                            "hostId"    => $respMap["HostId"]
                        ]
                    ]);
                }
                return $_response->headers;
            } catch (\Exception $e) {
                if (Tea::isRetryable($e)) {
                    continue;
                }
                throw $e;
            }
        }
        throw new TeaUnableRetryError($_lastRequest);
    }

    public function listMultipartUploads(ListMultipartUploadsRequest $request, RuntimeOptions $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime     = [
            "timeouted"      => "retry",
            "readTimeout"    => Utils::defaultNumber($runtime->readTimeout, $this->_readTimeout),
            "connectTimeout" => Utils::defaultNumber($runtime->connectTimeout, $this->_connectTimeout),
            "localAddr"      => Utils::defaultString($runtime->localAddr, $this->_localAddr),
            "httpProxy"      => Utils::defaultString($runtime->httpProxy, $this->_httpProxy),
            "httpsProxy"     => Utils::defaultString($runtime->httpsProxy, $this->_httpsProxy),
            "noProxy"        => Utils::defaultString($runtime->noProxy, $this->_noProxy),
            "socks5Proxy"    => Utils::defaultString($runtime->socks5Proxy, $this->_socks5Proxy),
            "socks5NetWork"  => Utils::defaultString($runtime->socks5NetWork, $this->_socks5NetWork),
            "maxIdleConns"   => Utils::defaultNumber($runtime->maxIdleConns, $this->_maxIdleConns),
            "retry"          => [
                "retryable"   => $runtime->autoretry,
                "maxAttempts" => Utils::defaultNumber($runtime->maxAttempts, 3)
            ],
            "backoff"        => [
                "policy" => Utils::defaultString($runtime->backoffPolicy, "no"),
                "period" => Utils::defaultNumber($runtime->backoffPeriod, 1)
            ],
            "ignoreSSL"      => $runtime->ignoreSSL
        ];
        $_lastRequest = null;
        $_now         = time();
        $_retryTimes  = 0;
        while (Tea::allowRetry($_runtime["retry"], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime($_runtime["backoff"], $_retryTimes);
                if ($_backoffTime > 0) {
                    Tea::sleep($_backoffTime);
                }
            }
            $_retryTimes = $_retryTimes + 1;
            try {
                $_request           = new Request();
                $accessKeyId        = $this->_credential->getAccessKeyId();
                $accessKeySecret    = $this->_credential->getAccessKeySecret();
                $token              = $this->_credential->getSecurityToken();
                $_request->protocol = $this->_protocol;
                $_request->method   = "GET";
                $_request->pathname = "/?uploads";
                $_request->headers  = [
                    "host"       => OSSUtils::getHost($request->bucketName, $this->_regionId, $this->_endpoint, $this->_hostModel),
                    "date"       => Utils::getDateUTCString(),
                    "user-agent" => $this->getUserAgent()
                ];
                if (!Utils::_empty($token)) {
                    $_request->headers["x-oss-security-token"] = $token;
                }
                $_request->query                    = Utils::stringifyMapValue($request->filter);
                $_request->headers["authorization"] = OSSUtils::getSignature($_request, $request->bucketName, $accessKeyId, $accessKeySecret, $this->_signatureVersion, $this->_addtionalHeaders);
                $_lastRequest                       = $_request;
                $_response                          = Tea::send($_request, $_runtime);
                $respMap                            = null;
                $bodyStr                            = null;
                if (Utils::is4xx($_response->statusCode) || Utils::is5xx($_response->statusCode)) {
                    $bodyStr = Utils::readAsString($_response->body);
                    $respMap = OSSUtils::getErrMessage($bodyStr);
                    throw new TeaError([
                        "code"    => $respMap["Code"],
                        "message" => $respMap["Message"],
                        "data"    => [
                            "httpCode"  => $_response->statusCode,
                            "requestId" => $respMap["RequestId"],
                            "hostId"    => $respMap["HostId"]
                        ]
                    ]);
                }
                $bodyStr = Utils::readAsString($_response->body);
                $respMap = XML::parseXml($bodyStr, ListMultipartUploadsResponse::class);
                return [
                    [
                        "ListMultipartUploadsResult" => $respMap["ListMultipartUploadsResult"],
                    ],
                    $_response->headers
                ];
            } catch (\Exception $e) {
                if (Tea::isRetryable($e)) {
                    continue;
                }
                throw $e;
            }
        }
        throw new TeaUnableRetryError($_lastRequest);
    }

    public function getBucketRequestPayment(GetBucketRequestPaymentRequest $request, RuntimeOptions $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime     = [
            "timeouted"      => "retry",
            "readTimeout"    => Utils::defaultNumber($runtime->readTimeout, $this->_readTimeout),
            "connectTimeout" => Utils::defaultNumber($runtime->connectTimeout, $this->_connectTimeout),
            "localAddr"      => Utils::defaultString($runtime->localAddr, $this->_localAddr),
            "httpProxy"      => Utils::defaultString($runtime->httpProxy, $this->_httpProxy),
            "httpsProxy"     => Utils::defaultString($runtime->httpsProxy, $this->_httpsProxy),
            "noProxy"        => Utils::defaultString($runtime->noProxy, $this->_noProxy),
            "socks5Proxy"    => Utils::defaultString($runtime->socks5Proxy, $this->_socks5Proxy),
            "socks5NetWork"  => Utils::defaultString($runtime->socks5NetWork, $this->_socks5NetWork),
            "maxIdleConns"   => Utils::defaultNumber($runtime->maxIdleConns, $this->_maxIdleConns),
            "retry"          => [
                "retryable"   => $runtime->autoretry,
                "maxAttempts" => Utils::defaultNumber($runtime->maxAttempts, 3)
            ],
            "backoff"        => [
                "policy" => Utils::defaultString($runtime->backoffPolicy, "no"),
                "period" => Utils::defaultNumber($runtime->backoffPeriod, 1)
            ],
            "ignoreSSL"      => $runtime->ignoreSSL
        ];
        $_lastRequest = null;
        $_now         = time();
        $_retryTimes  = 0;
        while (Tea::allowRetry($_runtime["retry"], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime($_runtime["backoff"], $_retryTimes);
                if ($_backoffTime > 0) {
                    Tea::sleep($_backoffTime);
                }
            }
            $_retryTimes = $_retryTimes + 1;
            try {
                $_request           = new Request();
                $accessKeyId        = $this->_credential->getAccessKeyId();
                $accessKeySecret    = $this->_credential->getAccessKeySecret();
                $token              = $this->_credential->getSecurityToken();
                $_request->protocol = $this->_protocol;
                $_request->method   = "GET";
                $_request->pathname = "/?requestPayment";
                $_request->headers  = [
                    "host"       => OSSUtils::getHost($request->bucketName, $this->_regionId, $this->_endpoint, $this->_hostModel),
                    "date"       => Utils::getDateUTCString(),
                    "user-agent" => $this->getUserAgent()
                ];
                if (!Utils::_empty($token)) {
                    $_request->headers["x-oss-security-token"] = $token;
                }
                $_request->headers["authorization"] = OSSUtils::getSignature($_request, $request->bucketName, $accessKeyId, $accessKeySecret, $this->_signatureVersion, $this->_addtionalHeaders);
                $_lastRequest                       = $_request;
                $_response                          = Tea::send($_request, $_runtime);
                $respMap                            = null;
                $bodyStr                            = null;
                if (Utils::is4xx($_response->statusCode) || Utils::is5xx($_response->statusCode)) {
                    $bodyStr = Utils::readAsString($_response->body);
                    $respMap = OSSUtils::getErrMessage($bodyStr);
                    throw new TeaError([
                        "code"    => $respMap["Code"],
                        "message" => $respMap["Message"],
                        "data"    => [
                            "httpCode"  => $_response->statusCode,
                            "requestId" => $respMap["RequestId"],
                            "hostId"    => $respMap["HostId"]
                        ]
                    ]);
                }
                $bodyStr = Utils::readAsString($_response->body);
                $respMap = XML::parseXml($bodyStr, GetBucketRequestPaymentResponse::class);
                return [
                    [
                        "RequestPaymentConfiguration" => $respMap["RequestPaymentConfiguration"],
                    ],
                    $_response->headers
                ];
            } catch (\Exception $e) {
                if (Tea::isRetryable($e)) {
                    continue;
                }
                throw $e;
            }
        }
        throw new TeaUnableRetryError($_lastRequest);
    }

    public function getBucketEncryption(GetBucketEncryptionRequest $request, RuntimeOptions $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime     = [
            "timeouted"      => "retry",
            "readTimeout"    => Utils::defaultNumber($runtime->readTimeout, $this->_readTimeout),
            "connectTimeout" => Utils::defaultNumber($runtime->connectTimeout, $this->_connectTimeout),
            "localAddr"      => Utils::defaultString($runtime->localAddr, $this->_localAddr),
            "httpProxy"      => Utils::defaultString($runtime->httpProxy, $this->_httpProxy),
            "httpsProxy"     => Utils::defaultString($runtime->httpsProxy, $this->_httpsProxy),
            "noProxy"        => Utils::defaultString($runtime->noProxy, $this->_noProxy),
            "socks5Proxy"    => Utils::defaultString($runtime->socks5Proxy, $this->_socks5Proxy),
            "socks5NetWork"  => Utils::defaultString($runtime->socks5NetWork, $this->_socks5NetWork),
            "maxIdleConns"   => Utils::defaultNumber($runtime->maxIdleConns, $this->_maxIdleConns),
            "retry"          => [
                "retryable"   => $runtime->autoretry,
                "maxAttempts" => Utils::defaultNumber($runtime->maxAttempts, 3)
            ],
            "backoff"        => [
                "policy" => Utils::defaultString($runtime->backoffPolicy, "no"),
                "period" => Utils::defaultNumber($runtime->backoffPeriod, 1)
            ],
            "ignoreSSL"      => $runtime->ignoreSSL
        ];
        $_lastRequest = null;
        $_now         = time();
        $_retryTimes  = 0;
        while (Tea::allowRetry($_runtime["retry"], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime($_runtime["backoff"], $_retryTimes);
                if ($_backoffTime > 0) {
                    Tea::sleep($_backoffTime);
                }
            }
            $_retryTimes = $_retryTimes + 1;
            try {
                $_request           = new Request();
                $accessKeyId        = $this->_credential->getAccessKeyId();
                $accessKeySecret    = $this->_credential->getAccessKeySecret();
                $token              = $this->_credential->getSecurityToken();
                $_request->protocol = $this->_protocol;
                $_request->method   = "GET";
                $_request->pathname = "/?encryption";
                $_request->headers  = [
                    "host"       => OSSUtils::getHost($request->bucketName, $this->_regionId, $this->_endpoint, $this->_hostModel),
                    "date"       => Utils::getDateUTCString(),
                    "user-agent" => $this->getUserAgent()
                ];
                if (!Utils::_empty($token)) {
                    $_request->headers["x-oss-security-token"] = $token;
                }
                $_request->headers["authorization"] = OSSUtils::getSignature($_request, $request->bucketName, $accessKeyId, $accessKeySecret, $this->_signatureVersion, $this->_addtionalHeaders);
                $_lastRequest                       = $_request;
                $_response                          = Tea::send($_request, $_runtime);
                $respMap                            = null;
                $bodyStr                            = null;
                if (Utils::is4xx($_response->statusCode) || Utils::is5xx($_response->statusCode)) {
                    $bodyStr = Utils::readAsString($_response->body);
                    $respMap = OSSUtils::getErrMessage($bodyStr);
                    throw new TeaError([
                        "code"    => $respMap["Code"],
                        "message" => $respMap["Message"],
                        "data"    => [
                            "httpCode"  => $_response->statusCode,
                            "requestId" => $respMap["RequestId"],
                            "hostId"    => $respMap["HostId"]
                        ]
                    ]);
                }
                $bodyStr = Utils::readAsString($_response->body);
                $respMap = XML::parseXml($bodyStr, GetBucketEncryptionResponse::class);
                return [
                    [
                        "ServerSideEncryptionRule" => $respMap["ServerSideEncryptionRule"],
                    ],
                    $_response->headers
                ];
            } catch (\Exception $e) {
                if (Tea::isRetryable($e)) {
                    continue;
                }
                throw $e;
            }
        }
        throw new TeaUnableRetryError($_lastRequest);
    }

    public function getBucketTags(GetBucketTagsRequest $request, RuntimeOptions $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime     = [
            "timeouted"      => "retry",
            "readTimeout"    => Utils::defaultNumber($runtime->readTimeout, $this->_readTimeout),
            "connectTimeout" => Utils::defaultNumber($runtime->connectTimeout, $this->_connectTimeout),
            "localAddr"      => Utils::defaultString($runtime->localAddr, $this->_localAddr),
            "httpProxy"      => Utils::defaultString($runtime->httpProxy, $this->_httpProxy),
            "httpsProxy"     => Utils::defaultString($runtime->httpsProxy, $this->_httpsProxy),
            "noProxy"        => Utils::defaultString($runtime->noProxy, $this->_noProxy),
            "socks5Proxy"    => Utils::defaultString($runtime->socks5Proxy, $this->_socks5Proxy),
            "socks5NetWork"  => Utils::defaultString($runtime->socks5NetWork, $this->_socks5NetWork),
            "maxIdleConns"   => Utils::defaultNumber($runtime->maxIdleConns, $this->_maxIdleConns),
            "retry"          => [
                "retryable"   => $runtime->autoretry,
                "maxAttempts" => Utils::defaultNumber($runtime->maxAttempts, 3)
            ],
            "backoff"        => [
                "policy" => Utils::defaultString($runtime->backoffPolicy, "no"),
                "period" => Utils::defaultNumber($runtime->backoffPeriod, 1)
            ],
            "ignoreSSL"      => $runtime->ignoreSSL
        ];
        $_lastRequest = null;
        $_now         = time();
        $_retryTimes  = 0;
        while (Tea::allowRetry($_runtime["retry"], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime($_runtime["backoff"], $_retryTimes);
                if ($_backoffTime > 0) {
                    Tea::sleep($_backoffTime);
                }
            }
            $_retryTimes = $_retryTimes + 1;
            try {
                $_request           = new Request();
                $accessKeyId        = $this->_credential->getAccessKeyId();
                $accessKeySecret    = $this->_credential->getAccessKeySecret();
                $token              = $this->_credential->getSecurityToken();
                $_request->protocol = $this->_protocol;
                $_request->method   = "GET";
                $_request->pathname = "/?tagging";
                $_request->headers  = [
                    "host"       => OSSUtils::getHost($request->bucketName, $this->_regionId, $this->_endpoint, $this->_hostModel),
                    "date"       => Utils::getDateUTCString(),
                    "user-agent" => $this->getUserAgent()
                ];
                if (!Utils::_empty($token)) {
                    $_request->headers["x-oss-security-token"] = $token;
                }
                $_request->headers["authorization"] = OSSUtils::getSignature($_request, $request->bucketName, $accessKeyId, $accessKeySecret, $this->_signatureVersion, $this->_addtionalHeaders);
                $_lastRequest                       = $_request;
                $_response                          = Tea::send($_request, $_runtime);
                $respMap                            = null;
                $bodyStr                            = null;
                if (Utils::is4xx($_response->statusCode) || Utils::is5xx($_response->statusCode)) {
                    $bodyStr = Utils::readAsString($_response->body);
                    $respMap = OSSUtils::getErrMessage($bodyStr);
                    throw new TeaError([
                        "code"    => $respMap["Code"],
                        "message" => $respMap["Message"],
                        "data"    => [
                            "httpCode"  => $_response->statusCode,
                            "requestId" => $respMap["RequestId"],
                            "hostId"    => $respMap["HostId"]
                        ]
                    ]);
                }
                $bodyStr = Utils::readAsString($_response->body);
                $respMap = XML::parseXml($bodyStr, GetBucketTagsResponse::class);
                return [
                    [
                        "Tagging" => $respMap["Tagging"],
                    ],
                    $_response->headers
                ];
            } catch (\Exception $e) {
                if (Tea::isRetryable($e)) {
                    continue;
                }
                throw $e;
            }
        }
        throw new TeaUnableRetryError($_lastRequest);
    }

    public function getService(GetServiceRequest $request, RuntimeOptions $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime     = [
            "timeouted"      => "retry",
            "readTimeout"    => Utils::defaultNumber($runtime->readTimeout, $this->_readTimeout),
            "connectTimeout" => Utils::defaultNumber($runtime->connectTimeout, $this->_connectTimeout),
            "localAddr"      => Utils::defaultString($runtime->localAddr, $this->_localAddr),
            "httpProxy"      => Utils::defaultString($runtime->httpProxy, $this->_httpProxy),
            "httpsProxy"     => Utils::defaultString($runtime->httpsProxy, $this->_httpsProxy),
            "noProxy"        => Utils::defaultString($runtime->noProxy, $this->_noProxy),
            "socks5Proxy"    => Utils::defaultString($runtime->socks5Proxy, $this->_socks5Proxy),
            "socks5NetWork"  => Utils::defaultString($runtime->socks5NetWork, $this->_socks5NetWork),
            "maxIdleConns"   => Utils::defaultNumber($runtime->maxIdleConns, $this->_maxIdleConns),
            "retry"          => [
                "retryable"   => $runtime->autoretry,
                "maxAttempts" => Utils::defaultNumber($runtime->maxAttempts, 3)
            ],
            "backoff"        => [
                "policy" => Utils::defaultString($runtime->backoffPolicy, "no"),
                "period" => Utils::defaultNumber($runtime->backoffPeriod, 1)
            ],
            "ignoreSSL"      => $runtime->ignoreSSL
        ];
        $_lastRequest = null;
        $_now         = time();
        $_retryTimes  = 0;
        while (Tea::allowRetry($_runtime["retry"], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime($_runtime["backoff"], $_retryTimes);
                if ($_backoffTime > 0) {
                    Tea::sleep($_backoffTime);
                }
            }
            $_retryTimes = $_retryTimes + 1;
            try {
                $_request           = new Request();
                $accessKeyId        = $this->_credential->getAccessKeyId();
                $accessKeySecret    = $this->_credential->getAccessKeySecret();
                $token              = $this->_credential->getSecurityToken();
                $_request->protocol = $this->_protocol;
                $_request->method   = "GET";
                $_request->pathname = "/";
                $_request->headers  = [
                    "host"       => OSSUtils::getHost("", $this->_regionId, $this->_endpoint, $this->_hostModel),
                    "date"       => Utils::getDateUTCString(),
                    "user-agent" => $this->getUserAgent()
                ];
                if (!Utils::_empty($token)) {
                    $_request->headers["x-oss-security-token"] = $token;
                }
                $_request->query                    = Utils::stringifyMapValue($request->filter);
                $_request->headers["authorization"] = OSSUtils::getSignature($_request, "", $accessKeyId, $accessKeySecret, $this->_signatureVersion, $this->_addtionalHeaders);
                $_lastRequest                       = $_request;
                $_response                          = Tea::send($_request, $_runtime);
                $respMap                            = null;
                $bodyStr                            = null;
                if (Utils::is4xx($_response->statusCode) || Utils::is5xx($_response->statusCode)) {
                    $bodyStr = Utils::readAsString($_response->body);
                    $respMap = OSSUtils::getErrMessage($bodyStr);
                    throw new TeaError([
                        "code"    => $respMap["Code"],
                        "message" => $respMap["Message"],
                        "data"    => [
                            "httpCode"  => $_response->statusCode,
                            "requestId" => $respMap["RequestId"],
                            "hostId"    => $respMap["HostId"]
                        ]
                    ]);
                }
                $bodyStr = Utils::readAsString($_response->body);
                $respMap = XML::parseXml($bodyStr, GetServiceResponse::class);
                return [
                    [
                        "ListAllMyBucketsResult" => $respMap["ListAllMyBucketsResult"],
                    ],
                    $_response->headers
                ];
            } catch (\Exception $e) {
                if (Tea::isRetryable($e)) {
                    continue;
                }
                throw $e;
            }
        }
        throw new TeaUnableRetryError($_lastRequest);
    }

    public function deleteBucketEncryption(DeleteBucketEncryptionRequest $request, RuntimeOptions $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime     = [
            "timeouted"      => "retry",
            "readTimeout"    => Utils::defaultNumber($runtime->readTimeout, $this->_readTimeout),
            "connectTimeout" => Utils::defaultNumber($runtime->connectTimeout, $this->_connectTimeout),
            "localAddr"      => Utils::defaultString($runtime->localAddr, $this->_localAddr),
            "httpProxy"      => Utils::defaultString($runtime->httpProxy, $this->_httpProxy),
            "httpsProxy"     => Utils::defaultString($runtime->httpsProxy, $this->_httpsProxy),
            "noProxy"        => Utils::defaultString($runtime->noProxy, $this->_noProxy),
            "socks5Proxy"    => Utils::defaultString($runtime->socks5Proxy, $this->_socks5Proxy),
            "socks5NetWork"  => Utils::defaultString($runtime->socks5NetWork, $this->_socks5NetWork),
            "maxIdleConns"   => Utils::defaultNumber($runtime->maxIdleConns, $this->_maxIdleConns),
            "retry"          => [
                "retryable"   => $runtime->autoretry,
                "maxAttempts" => Utils::defaultNumber($runtime->maxAttempts, 3)
            ],
            "backoff"        => [
                "policy" => Utils::defaultString($runtime->backoffPolicy, "no"),
                "period" => Utils::defaultNumber($runtime->backoffPeriod, 1)
            ],
            "ignoreSSL"      => $runtime->ignoreSSL
        ];
        $_lastRequest = null;
        $_now         = time();
        $_retryTimes  = 0;
        while (Tea::allowRetry($_runtime["retry"], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime($_runtime["backoff"], $_retryTimes);
                if ($_backoffTime > 0) {
                    Tea::sleep($_backoffTime);
                }
            }
            $_retryTimes = $_retryTimes + 1;
            try {
                $_request           = new Request();
                $accessKeyId        = $this->_credential->getAccessKeyId();
                $accessKeySecret    = $this->_credential->getAccessKeySecret();
                $token              = $this->_credential->getSecurityToken();
                $_request->protocol = $this->_protocol;
                $_request->method   = "DELETE";
                $_request->pathname = "/?encryption";
                $_request->headers  = [
                    "host"       => OSSUtils::getHost($request->bucketName, $this->_regionId, $this->_endpoint, $this->_hostModel),
                    "date"       => Utils::getDateUTCString(),
                    "user-agent" => $this->getUserAgent()
                ];
                if (!Utils::_empty($token)) {
                    $_request->headers["x-oss-security-token"] = $token;
                }
                $_request->headers["authorization"] = OSSUtils::getSignature($_request, $request->bucketName, $accessKeyId, $accessKeySecret, $this->_signatureVersion, $this->_addtionalHeaders);
                $_lastRequest                       = $_request;
                $_response                          = Tea::send($_request, $_runtime);
                $respMap                            = null;
                $bodyStr                            = null;
                if (Utils::is4xx($_response->statusCode) || Utils::is5xx($_response->statusCode)) {
                    $bodyStr = Utils::readAsString($_response->body);
                    $respMap = OSSUtils::getErrMessage($bodyStr);
                    throw new TeaError([
                        "code"    => $respMap["Code"],
                        "message" => $respMap["Message"],
                        "data"    => [
                            "httpCode"  => $_response->statusCode,
                            "requestId" => $respMap["RequestId"],
                            "hostId"    => $respMap["HostId"]
                        ]
                    ]);
                }
                return $_response->headers;
            } catch (\Exception $e) {
                if (Tea::isRetryable($e)) {
                    continue;
                }
                throw $e;
            }
        }
        throw new TeaUnableRetryError($_lastRequest);
    }

    public function deleteBucketTags(DeleteBucketTagsRequest $request, RuntimeOptions $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime     = [
            "timeouted"      => "retry",
            "readTimeout"    => Utils::defaultNumber($runtime->readTimeout, $this->_readTimeout),
            "connectTimeout" => Utils::defaultNumber($runtime->connectTimeout, $this->_connectTimeout),
            "localAddr"      => Utils::defaultString($runtime->localAddr, $this->_localAddr),
            "httpProxy"      => Utils::defaultString($runtime->httpProxy, $this->_httpProxy),
            "httpsProxy"     => Utils::defaultString($runtime->httpsProxy, $this->_httpsProxy),
            "noProxy"        => Utils::defaultString($runtime->noProxy, $this->_noProxy),
            "socks5Proxy"    => Utils::defaultString($runtime->socks5Proxy, $this->_socks5Proxy),
            "socks5NetWork"  => Utils::defaultString($runtime->socks5NetWork, $this->_socks5NetWork),
            "maxIdleConns"   => Utils::defaultNumber($runtime->maxIdleConns, $this->_maxIdleConns),
            "retry"          => [
                "retryable"   => $runtime->autoretry,
                "maxAttempts" => Utils::defaultNumber($runtime->maxAttempts, 3)
            ],
            "backoff"        => [
                "policy" => Utils::defaultString($runtime->backoffPolicy, "no"),
                "period" => Utils::defaultNumber($runtime->backoffPeriod, 1)
            ],
            "ignoreSSL"      => $runtime->ignoreSSL
        ];
        $_lastRequest = null;
        $_now         = time();
        $_retryTimes  = 0;
        while (Tea::allowRetry($_runtime["retry"], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime($_runtime["backoff"], $_retryTimes);
                if ($_backoffTime > 0) {
                    Tea::sleep($_backoffTime);
                }
            }
            $_retryTimes = $_retryTimes + 1;
            try {
                $_request           = new Request();
                $accessKeyId        = $this->_credential->getAccessKeyId();
                $accessKeySecret    = $this->_credential->getAccessKeySecret();
                $token              = $this->_credential->getSecurityToken();
                $_request->protocol = $this->_protocol;
                $_request->method   = "DELETE";
                $_request->pathname = "/";
                $_request->headers  = [
                    "host"       => OSSUtils::getHost($request->bucketName, $this->_regionId, $this->_endpoint, $this->_hostModel),
                    "date"       => Utils::getDateUTCString(),
                    "user-agent" => $this->getUserAgent()
                ];
                if (!Utils::_empty($token)) {
                    $_request->headers["x-oss-security-token"] = $token;
                }
                $_request->query                    = Utils::stringifyMapValue($request->filter);
                $_request->headers["authorization"] = OSSUtils::getSignature($_request, $request->bucketName, $accessKeyId, $accessKeySecret, $this->_signatureVersion, $this->_addtionalHeaders);
                $_lastRequest                       = $_request;
                $_response                          = Tea::send($_request, $_runtime);
                $respMap                            = null;
                $bodyStr                            = null;
                if (Utils::is4xx($_response->statusCode) || Utils::is5xx($_response->statusCode)) {
                    $bodyStr = Utils::readAsString($_response->body);
                    $respMap = OSSUtils::getErrMessage($bodyStr);
                    throw new TeaError([
                        "code"    => $respMap["Code"],
                        "message" => $respMap["Message"],
                        "data"    => [
                            "httpCode"  => $_response->statusCode,
                            "requestId" => $respMap["RequestId"],
                            "hostId"    => $respMap["HostId"]
                        ]
                    ]);
                }
                return $_response->headers;
            } catch (\Exception $e) {
                if (Tea::isRetryable($e)) {
                    continue;
                }
                throw $e;
            }
        }
        throw new TeaUnableRetryError($_lastRequest);
    }

    public function getBucketWebsite(GetBucketWebsiteRequest $request, RuntimeOptions $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime     = [
            "timeouted"      => "retry",
            "readTimeout"    => Utils::defaultNumber($runtime->readTimeout, $this->_readTimeout),
            "connectTimeout" => Utils::defaultNumber($runtime->connectTimeout, $this->_connectTimeout),
            "localAddr"      => Utils::defaultString($runtime->localAddr, $this->_localAddr),
            "httpProxy"      => Utils::defaultString($runtime->httpProxy, $this->_httpProxy),
            "httpsProxy"     => Utils::defaultString($runtime->httpsProxy, $this->_httpsProxy),
            "noProxy"        => Utils::defaultString($runtime->noProxy, $this->_noProxy),
            "socks5Proxy"    => Utils::defaultString($runtime->socks5Proxy, $this->_socks5Proxy),
            "socks5NetWork"  => Utils::defaultString($runtime->socks5NetWork, $this->_socks5NetWork),
            "maxIdleConns"   => Utils::defaultNumber($runtime->maxIdleConns, $this->_maxIdleConns),
            "retry"          => [
                "retryable"   => $runtime->autoretry,
                "maxAttempts" => Utils::defaultNumber($runtime->maxAttempts, 3)
            ],
            "backoff"        => [
                "policy" => Utils::defaultString($runtime->backoffPolicy, "no"),
                "period" => Utils::defaultNumber($runtime->backoffPeriod, 1)
            ],
            "ignoreSSL"      => $runtime->ignoreSSL
        ];
        $_lastRequest = null;
        $_now         = time();
        $_retryTimes  = 0;
        while (Tea::allowRetry($_runtime["retry"], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime($_runtime["backoff"], $_retryTimes);
                if ($_backoffTime > 0) {
                    Tea::sleep($_backoffTime);
                }
            }
            $_retryTimes = $_retryTimes + 1;
            try {
                $_request           = new Request();
                $accessKeyId        = $this->_credential->getAccessKeyId();
                $accessKeySecret    = $this->_credential->getAccessKeySecret();
                $token              = $this->_credential->getSecurityToken();
                $_request->protocol = $this->_protocol;
                $_request->method   = "GET";
                $_request->pathname = "/?website";
                $_request->headers  = [
                    "host"       => OSSUtils::getHost($request->bucketName, $this->_regionId, $this->_endpoint, $this->_hostModel),
                    "date"       => Utils::getDateUTCString(),
                    "user-agent" => $this->getUserAgent()
                ];
                if (!Utils::_empty($token)) {
                    $_request->headers["x-oss-security-token"] = $token;
                }
                $_request->headers["authorization"] = OSSUtils::getSignature($_request, $request->bucketName, $accessKeyId, $accessKeySecret, $this->_signatureVersion, $this->_addtionalHeaders);
                $_lastRequest                       = $_request;
                $_response                          = Tea::send($_request, $_runtime);
                $respMap                            = null;
                $bodyStr                            = null;
                if (Utils::is4xx($_response->statusCode) || Utils::is5xx($_response->statusCode)) {
                    $bodyStr = Utils::readAsString($_response->body);
                    $respMap = OSSUtils::getErrMessage($bodyStr);
                    throw new TeaError([
                        "code"    => $respMap["Code"],
                        "message" => $respMap["Message"],
                        "data"    => [
                            "httpCode"  => $_response->statusCode,
                            "requestId" => $respMap["RequestId"],
                            "hostId"    => $respMap["HostId"]
                        ]
                    ]);
                }
                $bodyStr = Utils::readAsString($_response->body);
                $respMap = XML::parseXml($bodyStr, GetBucketWebsiteResponse::class);
                return [
                    [
                        "WebsiteConfiguration" => $respMap["WebsiteConfiguration"],
                    ],
                    $_response->headers
                ];
            } catch (\Exception $e) {
                if (Tea::isRetryable($e)) {
                    continue;
                }
                throw $e;
            }
        }
        throw new TeaUnableRetryError($_lastRequest);
    }

    public function deleteLiveChannel(DeleteLiveChannelRequest $request, RuntimeOptions $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime     = [
            "timeouted"      => "retry",
            "readTimeout"    => Utils::defaultNumber($runtime->readTimeout, $this->_readTimeout),
            "connectTimeout" => Utils::defaultNumber($runtime->connectTimeout, $this->_connectTimeout),
            "localAddr"      => Utils::defaultString($runtime->localAddr, $this->_localAddr),
            "httpProxy"      => Utils::defaultString($runtime->httpProxy, $this->_httpProxy),
            "httpsProxy"     => Utils::defaultString($runtime->httpsProxy, $this->_httpsProxy),
            "noProxy"        => Utils::defaultString($runtime->noProxy, $this->_noProxy),
            "socks5Proxy"    => Utils::defaultString($runtime->socks5Proxy, $this->_socks5Proxy),
            "socks5NetWork"  => Utils::defaultString($runtime->socks5NetWork, $this->_socks5NetWork),
            "maxIdleConns"   => Utils::defaultNumber($runtime->maxIdleConns, $this->_maxIdleConns),
            "retry"          => [
                "retryable"   => $runtime->autoretry,
                "maxAttempts" => Utils::defaultNumber($runtime->maxAttempts, 3)
            ],
            "backoff"        => [
                "policy" => Utils::defaultString($runtime->backoffPolicy, "no"),
                "period" => Utils::defaultNumber($runtime->backoffPeriod, 1)
            ],
            "ignoreSSL"      => $runtime->ignoreSSL
        ];
        $_lastRequest = null;
        $_now         = time();
        $_retryTimes  = 0;
        while (Tea::allowRetry($_runtime["retry"], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime($_runtime["backoff"], $_retryTimes);
                if ($_backoffTime > 0) {
                    Tea::sleep($_backoffTime);
                }
            }
            $_retryTimes = $_retryTimes + 1;
            try {
                $_request           = new Request();
                $accessKeyId        = $this->_credential->getAccessKeyId();
                $accessKeySecret    = $this->_credential->getAccessKeySecret();
                $token              = $this->_credential->getSecurityToken();
                $_request->protocol = $this->_protocol;
                $_request->method   = "DELETE";
                $_request->pathname = "/" . $request->channelName . "?live";
                $_request->headers  = [
                    "host"       => OSSUtils::getHost($request->bucketName, $this->_regionId, $this->_endpoint, $this->_hostModel),
                    "date"       => Utils::getDateUTCString(),
                    "user-agent" => $this->getUserAgent()
                ];
                if (!Utils::_empty($token)) {
                    $_request->headers["x-oss-security-token"] = $token;
                }
                $_request->headers["authorization"] = OSSUtils::getSignature($_request, $request->bucketName, $accessKeyId, $accessKeySecret, $this->_signatureVersion, $this->_addtionalHeaders);
                $_lastRequest                       = $_request;
                $_response                          = Tea::send($_request, $_runtime);
                $respMap                            = null;
                $bodyStr                            = null;
                if (Utils::is4xx($_response->statusCode) || Utils::is5xx($_response->statusCode)) {
                    $bodyStr = Utils::readAsString($_response->body);
                    $respMap = OSSUtils::getErrMessage($bodyStr);
                    throw new TeaError([
                        "code"    => $respMap["Code"],
                        "message" => $respMap["Message"],
                        "data"    => [
                            "httpCode"  => $_response->statusCode,
                            "requestId" => $respMap["RequestId"],
                            "hostId"    => $respMap["HostId"]
                        ]
                    ]);
                }
                return $_response->headers;
            } catch (\Exception $e) {
                if (Tea::isRetryable($e)) {
                    continue;
                }
                throw $e;
            }
        }
        throw new TeaUnableRetryError($_lastRequest);
    }

    public function getBucketLocation(GetBucketLocationRequest $request, RuntimeOptions $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime     = [
            "timeouted"      => "retry",
            "readTimeout"    => Utils::defaultNumber($runtime->readTimeout, $this->_readTimeout),
            "connectTimeout" => Utils::defaultNumber($runtime->connectTimeout, $this->_connectTimeout),
            "localAddr"      => Utils::defaultString($runtime->localAddr, $this->_localAddr),
            "httpProxy"      => Utils::defaultString($runtime->httpProxy, $this->_httpProxy),
            "httpsProxy"     => Utils::defaultString($runtime->httpsProxy, $this->_httpsProxy),
            "noProxy"        => Utils::defaultString($runtime->noProxy, $this->_noProxy),
            "socks5Proxy"    => Utils::defaultString($runtime->socks5Proxy, $this->_socks5Proxy),
            "socks5NetWork"  => Utils::defaultString($runtime->socks5NetWork, $this->_socks5NetWork),
            "maxIdleConns"   => Utils::defaultNumber($runtime->maxIdleConns, $this->_maxIdleConns),
            "retry"          => [
                "retryable"   => $runtime->autoretry,
                "maxAttempts" => Utils::defaultNumber($runtime->maxAttempts, 3)
            ],
            "backoff"        => [
                "policy" => Utils::defaultString($runtime->backoffPolicy, "no"),
                "period" => Utils::defaultNumber($runtime->backoffPeriod, 1)
            ],
            "ignoreSSL"      => $runtime->ignoreSSL
        ];
        $_lastRequest = null;
        $_now         = time();
        $_retryTimes  = 0;
        while (Tea::allowRetry($_runtime["retry"], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime($_runtime["backoff"], $_retryTimes);
                if ($_backoffTime > 0) {
                    Tea::sleep($_backoffTime);
                }
            }
            $_retryTimes = $_retryTimes + 1;
            try {
                $_request           = new Request();
                $accessKeyId        = $this->_credential->getAccessKeyId();
                $accessKeySecret    = $this->_credential->getAccessKeySecret();
                $token              = $this->_credential->getSecurityToken();
                $_request->protocol = $this->_protocol;
                $_request->method   = "GET";
                $_request->pathname = "/?location";
                $_request->headers  = [
                    "host"       => OSSUtils::getHost($request->bucketName, $this->_regionId, $this->_endpoint, $this->_hostModel),
                    "date"       => Utils::getDateUTCString(),
                    "user-agent" => $this->getUserAgent()
                ];
                if (!Utils::_empty($token)) {
                    $_request->headers["x-oss-security-token"] = $token;
                }
                $_request->headers["authorization"] = OSSUtils::getSignature($_request, $request->bucketName, $accessKeyId, $accessKeySecret, $this->_signatureVersion, $this->_addtionalHeaders);
                $_lastRequest                       = $_request;
                $_response                          = Tea::send($_request, $_runtime);
                $respMap                            = null;
                $bodyStr                            = null;
                if (Utils::is4xx($_response->statusCode) || Utils::is5xx($_response->statusCode)) {
                    $bodyStr = Utils::readAsString($_response->body);
                    $respMap = OSSUtils::getErrMessage($bodyStr);
                    throw new TeaError([
                        "code"    => $respMap["Code"],
                        "message" => $respMap["Message"],
                        "data"    => [
                            "httpCode"  => $_response->statusCode,
                            "requestId" => $respMap["RequestId"],
                            "hostId"    => $respMap["HostId"]
                        ]
                    ]);
                }
                $bodyStr = Utils::readAsString($_response->body);
                $respMap = XML::parseXml($bodyStr, GetBucketLocationResponse::class);
                return [
                    [
                        "LocationConstraint" => $respMap["LocationConstraint"],
                    ],
                    $_response->headers
                ];
            } catch (\Exception $e) {
                if (Tea::isRetryable($e)) {
                    continue;
                }
                throw $e;
            }
        }
        throw new TeaUnableRetryError($_lastRequest);
    }

    public function listLiveChannel(ListLiveChannelRequest $request, RuntimeOptions $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime     = [
            "timeouted"      => "retry",
            "readTimeout"    => Utils::defaultNumber($runtime->readTimeout, $this->_readTimeout),
            "connectTimeout" => Utils::defaultNumber($runtime->connectTimeout, $this->_connectTimeout),
            "localAddr"      => Utils::defaultString($runtime->localAddr, $this->_localAddr),
            "httpProxy"      => Utils::defaultString($runtime->httpProxy, $this->_httpProxy),
            "httpsProxy"     => Utils::defaultString($runtime->httpsProxy, $this->_httpsProxy),
            "noProxy"        => Utils::defaultString($runtime->noProxy, $this->_noProxy),
            "socks5Proxy"    => Utils::defaultString($runtime->socks5Proxy, $this->_socks5Proxy),
            "socks5NetWork"  => Utils::defaultString($runtime->socks5NetWork, $this->_socks5NetWork),
            "maxIdleConns"   => Utils::defaultNumber($runtime->maxIdleConns, $this->_maxIdleConns),
            "retry"          => [
                "retryable"   => $runtime->autoretry,
                "maxAttempts" => Utils::defaultNumber($runtime->maxAttempts, 3)
            ],
            "backoff"        => [
                "policy" => Utils::defaultString($runtime->backoffPolicy, "no"),
                "period" => Utils::defaultNumber($runtime->backoffPeriod, 1)
            ],
            "ignoreSSL"      => $runtime->ignoreSSL
        ];
        $_lastRequest = null;
        $_now         = time();
        $_retryTimes  = 0;
        while (Tea::allowRetry($_runtime["retry"], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime($_runtime["backoff"], $_retryTimes);
                if ($_backoffTime > 0) {
                    Tea::sleep($_backoffTime);
                }
            }
            $_retryTimes = $_retryTimes + 1;
            try {
                $_request           = new Request();
                $accessKeyId        = $this->_credential->getAccessKeyId();
                $accessKeySecret    = $this->_credential->getAccessKeySecret();
                $token              = $this->_credential->getSecurityToken();
                $_request->protocol = $this->_protocol;
                $_request->method   = "GET";
                $_request->pathname = "/?live";
                $_request->headers  = [
                    "host"       => OSSUtils::getHost($request->bucketName, $this->_regionId, $this->_endpoint, $this->_hostModel),
                    "date"       => Utils::getDateUTCString(),
                    "user-agent" => $this->getUserAgent()
                ];
                if (!Utils::_empty($token)) {
                    $_request->headers["x-oss-security-token"] = $token;
                }
                $_request->query                    = Utils::stringifyMapValue($request->filter);
                $_request->headers["authorization"] = OSSUtils::getSignature($_request, $request->bucketName, $accessKeyId, $accessKeySecret, $this->_signatureVersion, $this->_addtionalHeaders);
                $_lastRequest                       = $_request;
                $_response                          = Tea::send($_request, $_runtime);
                $respMap                            = null;
                $bodyStr                            = null;
                if (Utils::is4xx($_response->statusCode) || Utils::is5xx($_response->statusCode)) {
                    $bodyStr = Utils::readAsString($_response->body);
                    $respMap = OSSUtils::getErrMessage($bodyStr);
                    throw new TeaError([
                        "code"    => $respMap["Code"],
                        "message" => $respMap["Message"],
                        "data"    => [
                            "httpCode"  => $_response->statusCode,
                            "requestId" => $respMap["RequestId"],
                            "hostId"    => $respMap["HostId"]
                        ]
                    ]);
                }
                $bodyStr = Utils::readAsString($_response->body);
                $respMap = XML::parseXml($bodyStr, ListLiveChannelResponse::class);
                return [
                    [
                        "ListLiveChannelResult" => $respMap["ListLiveChannelResult"],
                    ],
                    $_response->headers
                ];
            } catch (\Exception $e) {
                if (Tea::isRetryable($e)) {
                    continue;
                }
                throw $e;
            }
        }
        throw new TeaUnableRetryError($_lastRequest);
    }

    public function getObjectMeta(GetObjectMetaRequest $request, RuntimeOptions $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime     = [
            "timeouted"      => "retry",
            "readTimeout"    => Utils::defaultNumber($runtime->readTimeout, $this->_readTimeout),
            "connectTimeout" => Utils::defaultNumber($runtime->connectTimeout, $this->_connectTimeout),
            "localAddr"      => Utils::defaultString($runtime->localAddr, $this->_localAddr),
            "httpProxy"      => Utils::defaultString($runtime->httpProxy, $this->_httpProxy),
            "httpsProxy"     => Utils::defaultString($runtime->httpsProxy, $this->_httpsProxy),
            "noProxy"        => Utils::defaultString($runtime->noProxy, $this->_noProxy),
            "socks5Proxy"    => Utils::defaultString($runtime->socks5Proxy, $this->_socks5Proxy),
            "socks5NetWork"  => Utils::defaultString($runtime->socks5NetWork, $this->_socks5NetWork),
            "maxIdleConns"   => Utils::defaultNumber($runtime->maxIdleConns, $this->_maxIdleConns),
            "retry"          => [
                "retryable"   => $runtime->autoretry,
                "maxAttempts" => Utils::defaultNumber($runtime->maxAttempts, 3)
            ],
            "backoff"        => [
                "policy" => Utils::defaultString($runtime->backoffPolicy, "no"),
                "period" => Utils::defaultNumber($runtime->backoffPeriod, 1)
            ],
            "ignoreSSL"      => $runtime->ignoreSSL
        ];
        $_lastRequest = null;
        $_now         = time();
        $_retryTimes  = 0;
        while (Tea::allowRetry($_runtime["retry"], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime($_runtime["backoff"], $_retryTimes);
                if ($_backoffTime > 0) {
                    Tea::sleep($_backoffTime);
                }
            }
            $_retryTimes = $_retryTimes + 1;
            try {
                $_request           = new Request();
                $accessKeyId        = $this->_credential->getAccessKeyId();
                $accessKeySecret    = $this->_credential->getAccessKeySecret();
                $token              = $this->_credential->getSecurityToken();
                $_request->protocol = $this->_protocol;
                $_request->method   = "HEAD";
                $_request->pathname = "/" . $request->objectName . "?objectMeta";
                $_request->headers  = [
                    "host"       => OSSUtils::getHost($request->bucketName, $this->_regionId, $this->_endpoint, $this->_hostModel),
                    "date"       => Utils::getDateUTCString(),
                    "user-agent" => $this->getUserAgent()
                ];
                if (!Utils::_empty($token)) {
                    $_request->headers["x-oss-security-token"] = $token;
                }
                $_request->headers["authorization"] = OSSUtils::getSignature($_request, $request->bucketName, $accessKeyId, $accessKeySecret, $this->_signatureVersion, $this->_addtionalHeaders);
                $_lastRequest                       = $_request;
                $_response                          = Tea::send($_request, $_runtime);
                $respMap                            = null;
                $bodyStr                            = null;
                if (Utils::is4xx($_response->statusCode) || Utils::is5xx($_response->statusCode)) {
                    $bodyStr = Utils::readAsString($_response->body);
                    $respMap = OSSUtils::getErrMessage($bodyStr);
                    throw new TeaError([
                        "code"    => $respMap["Code"],
                        "message" => $respMap["Message"],
                        "data"    => [
                            "httpCode"  => $_response->statusCode,
                            "requestId" => $respMap["RequestId"],
                            "hostId"    => $respMap["HostId"]
                        ]
                    ]);
                }
                return $_response->headers;
            } catch (\Exception $e) {
                if (Tea::isRetryable($e)) {
                    continue;
                }
                throw $e;
            }
        }
        throw new TeaUnableRetryError($_lastRequest);
    }

    public function getBucketAcl(GetBucketAclRequest $request, RuntimeOptions $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime     = [
            "timeouted"      => "retry",
            "readTimeout"    => Utils::defaultNumber($runtime->readTimeout, $this->_readTimeout),
            "connectTimeout" => Utils::defaultNumber($runtime->connectTimeout, $this->_connectTimeout),
            "localAddr"      => Utils::defaultString($runtime->localAddr, $this->_localAddr),
            "httpProxy"      => Utils::defaultString($runtime->httpProxy, $this->_httpProxy),
            "httpsProxy"     => Utils::defaultString($runtime->httpsProxy, $this->_httpsProxy),
            "noProxy"        => Utils::defaultString($runtime->noProxy, $this->_noProxy),
            "socks5Proxy"    => Utils::defaultString($runtime->socks5Proxy, $this->_socks5Proxy),
            "socks5NetWork"  => Utils::defaultString($runtime->socks5NetWork, $this->_socks5NetWork),
            "maxIdleConns"   => Utils::defaultNumber($runtime->maxIdleConns, $this->_maxIdleConns),
            "retry"          => [
                "retryable"   => $runtime->autoretry,
                "maxAttempts" => Utils::defaultNumber($runtime->maxAttempts, 3)
            ],
            "backoff"        => [
                "policy" => Utils::defaultString($runtime->backoffPolicy, "no"),
                "period" => Utils::defaultNumber($runtime->backoffPeriod, 1)
            ],
            "ignoreSSL"      => $runtime->ignoreSSL
        ];
        $_lastRequest = null;
        $_now         = time();
        $_retryTimes  = 0;
        while (Tea::allowRetry($_runtime["retry"], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime($_runtime["backoff"], $_retryTimes);
                if ($_backoffTime > 0) {
                    Tea::sleep($_backoffTime);
                }
            }
            $_retryTimes = $_retryTimes + 1;
            try {
                $_request           = new Request();
                $accessKeyId        = $this->_credential->getAccessKeyId();
                $accessKeySecret    = $this->_credential->getAccessKeySecret();
                $token              = $this->_credential->getSecurityToken();
                $_request->protocol = $this->_protocol;
                $_request->method   = "GET";
                $_request->pathname = "/?acl";
                $_request->headers  = [
                    "host"       => OSSUtils::getHost($request->bucketName, $this->_regionId, $this->_endpoint, $this->_hostModel),
                    "date"       => Utils::getDateUTCString(),
                    "user-agent" => $this->getUserAgent()
                ];
                if (!Utils::_empty($token)) {
                    $_request->headers["x-oss-security-token"] = $token;
                }
                $_request->headers["authorization"] = OSSUtils::getSignature($_request, $request->bucketName, $accessKeyId, $accessKeySecret, $this->_signatureVersion, $this->_addtionalHeaders);
                $_lastRequest                       = $_request;
                $_response                          = Tea::send($_request, $_runtime);
                $respMap                            = null;
                $bodyStr                            = null;
                if (Utils::is4xx($_response->statusCode) || Utils::is5xx($_response->statusCode)) {
                    $bodyStr = Utils::readAsString($_response->body);
                    $respMap = OSSUtils::getErrMessage($bodyStr);
                    throw new TeaError([
                        "code"    => $respMap["Code"],
                        "message" => $respMap["Message"],
                        "data"    => [
                            "httpCode"  => $_response->statusCode,
                            "requestId" => $respMap["RequestId"],
                            "hostId"    => $respMap["HostId"]
                        ]
                    ]);
                }
                $bodyStr = Utils::readAsString($_response->body);
                $respMap = XML::parseXml($bodyStr, GetBucketAclResponse::class);
                return [
                    [
                        "AccessControlPolicy" => $respMap["AccessControlPolicy"],
                    ],
                    $_response->headers
                ];
            } catch (\Exception $e) {
                if (Tea::isRetryable($e)) {
                    continue;
                }
                throw $e;
            }
        }
        throw new TeaUnableRetryError($_lastRequest);
    }

    public function listParts(ListPartsRequest $request, RuntimeOptions $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime     = [
            "timeouted"      => "retry",
            "readTimeout"    => Utils::defaultNumber($runtime->readTimeout, $this->_readTimeout),
            "connectTimeout" => Utils::defaultNumber($runtime->connectTimeout, $this->_connectTimeout),
            "localAddr"      => Utils::defaultString($runtime->localAddr, $this->_localAddr),
            "httpProxy"      => Utils::defaultString($runtime->httpProxy, $this->_httpProxy),
            "httpsProxy"     => Utils::defaultString($runtime->httpsProxy, $this->_httpsProxy),
            "noProxy"        => Utils::defaultString($runtime->noProxy, $this->_noProxy),
            "socks5Proxy"    => Utils::defaultString($runtime->socks5Proxy, $this->_socks5Proxy),
            "socks5NetWork"  => Utils::defaultString($runtime->socks5NetWork, $this->_socks5NetWork),
            "maxIdleConns"   => Utils::defaultNumber($runtime->maxIdleConns, $this->_maxIdleConns),
            "retry"          => [
                "retryable"   => $runtime->autoretry,
                "maxAttempts" => Utils::defaultNumber($runtime->maxAttempts, 3)
            ],
            "backoff"        => [
                "policy" => Utils::defaultString($runtime->backoffPolicy, "no"),
                "period" => Utils::defaultNumber($runtime->backoffPeriod, 1)
            ],
            "ignoreSSL"      => $runtime->ignoreSSL
        ];
        $_lastRequest = null;
        $_now         = time();
        $_retryTimes  = 0;
        while (Tea::allowRetry($_runtime["retry"], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime($_runtime["backoff"], $_retryTimes);
                if ($_backoffTime > 0) {
                    Tea::sleep($_backoffTime);
                }
            }
            $_retryTimes = $_retryTimes + 1;
            try {
                $_request           = new Request();
                $accessKeyId        = $this->_credential->getAccessKeyId();
                $accessKeySecret    = $this->_credential->getAccessKeySecret();
                $token              = $this->_credential->getSecurityToken();
                $_request->protocol = $this->_protocol;
                $_request->method   = "GET";
                $_request->pathname = "/" . $request->objectName . "";
                $_request->headers  = [
                    "host"       => OSSUtils::getHost($request->bucketName, $this->_regionId, $this->_endpoint, $this->_hostModel),
                    "date"       => Utils::getDateUTCString(),
                    "user-agent" => $this->getUserAgent()
                ];
                if (!Utils::_empty($token)) {
                    $_request->headers["x-oss-security-token"] = $token;
                }
                $_request->query                    = Utils::stringifyMapValue($request->filter);
                $_request->headers["authorization"] = OSSUtils::getSignature($_request, $request->bucketName, $accessKeyId, $accessKeySecret, $this->_signatureVersion, $this->_addtionalHeaders);
                $_lastRequest                       = $_request;
                $_response                          = Tea::send($_request, $_runtime);
                $respMap                            = null;
                $bodyStr                            = null;
                if (Utils::is4xx($_response->statusCode) || Utils::is5xx($_response->statusCode)) {
                    $bodyStr = Utils::readAsString($_response->body);
                    $respMap = OSSUtils::getErrMessage($bodyStr);
                    throw new TeaError([
                        "code"    => $respMap["Code"],
                        "message" => $respMap["Message"],
                        "data"    => [
                            "httpCode"  => $_response->statusCode,
                            "requestId" => $respMap["RequestId"],
                            "hostId"    => $respMap["HostId"]
                        ]
                    ]);
                }
                $bodyStr = Utils::readAsString($_response->body);
                $respMap = XML::parseXml($bodyStr, ListPartsResponse::class);
                return [
                    [
                        "ListPartsResult" => $respMap["ListPartsResult"],
                    ],
                    $_response->headers
                ];
            } catch (\Exception $e) {
                if (Tea::isRetryable($e)) {
                    continue;
                }
                throw $e;
            }
        }
        throw new TeaUnableRetryError($_lastRequest);
    }

    public function getLiveChannelHistory(GetLiveChannelHistoryRequest $request, RuntimeOptions $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime     = [
            "timeouted"      => "retry",
            "readTimeout"    => Utils::defaultNumber($runtime->readTimeout, $this->_readTimeout),
            "connectTimeout" => Utils::defaultNumber($runtime->connectTimeout, $this->_connectTimeout),
            "localAddr"      => Utils::defaultString($runtime->localAddr, $this->_localAddr),
            "httpProxy"      => Utils::defaultString($runtime->httpProxy, $this->_httpProxy),
            "httpsProxy"     => Utils::defaultString($runtime->httpsProxy, $this->_httpsProxy),
            "noProxy"        => Utils::defaultString($runtime->noProxy, $this->_noProxy),
            "socks5Proxy"    => Utils::defaultString($runtime->socks5Proxy, $this->_socks5Proxy),
            "socks5NetWork"  => Utils::defaultString($runtime->socks5NetWork, $this->_socks5NetWork),
            "maxIdleConns"   => Utils::defaultNumber($runtime->maxIdleConns, $this->_maxIdleConns),
            "retry"          => [
                "retryable"   => $runtime->autoretry,
                "maxAttempts" => Utils::defaultNumber($runtime->maxAttempts, 3)
            ],
            "backoff"        => [
                "policy" => Utils::defaultString($runtime->backoffPolicy, "no"),
                "period" => Utils::defaultNumber($runtime->backoffPeriod, 1)
            ],
            "ignoreSSL"      => $runtime->ignoreSSL
        ];
        $_lastRequest = null;
        $_now         = time();
        $_retryTimes  = 0;
        while (Tea::allowRetry($_runtime["retry"], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime($_runtime["backoff"], $_retryTimes);
                if ($_backoffTime > 0) {
                    Tea::sleep($_backoffTime);
                }
            }
            $_retryTimes = $_retryTimes + 1;
            try {
                $_request           = new Request();
                $accessKeyId        = $this->_credential->getAccessKeyId();
                $accessKeySecret    = $this->_credential->getAccessKeySecret();
                $token              = $this->_credential->getSecurityToken();
                $_request->protocol = $this->_protocol;
                $_request->method   = "GET";
                $_request->pathname = "/" . $request->channelName . "?live";
                $_request->headers  = [
                    "host"       => OSSUtils::getHost($request->bucketName, $this->_regionId, $this->_endpoint, $this->_hostModel),
                    "date"       => Utils::getDateUTCString(),
                    "user-agent" => $this->getUserAgent()
                ];
                if (!Utils::_empty($token)) {
                    $_request->headers["x-oss-security-token"] = $token;
                }
                $_request->query                    = Utils::stringifyMapValue($request->filter);
                $_request->headers["authorization"] = OSSUtils::getSignature($_request, $request->bucketName, $accessKeyId, $accessKeySecret, $this->_signatureVersion, $this->_addtionalHeaders);
                $_lastRequest                       = $_request;
                $_response                          = Tea::send($_request, $_runtime);
                $respMap                            = null;
                $bodyStr                            = null;
                if (Utils::is4xx($_response->statusCode) || Utils::is5xx($_response->statusCode)) {
                    $bodyStr = Utils::readAsString($_response->body);
                    $respMap = OSSUtils::getErrMessage($bodyStr);
                    throw new TeaError([
                        "code"    => $respMap["Code"],
                        "message" => $respMap["Message"],
                        "data"    => [
                            "httpCode"  => $_response->statusCode,
                            "requestId" => $respMap["RequestId"],
                            "hostId"    => $respMap["HostId"]
                        ]
                    ]);
                }
                $bodyStr = Utils::readAsString($_response->body);
                $respMap = XML::parseXml($bodyStr, GetLiveChannelHistoryResponse::class);
                return [
                    [
                        "LiveChannelHistory" => $respMap["LiveChannelHistory"],
                    ],
                    $_response->headers
                ];
            } catch (\Exception $e) {
                if (Tea::isRetryable($e)) {
                    continue;
                }
                throw $e;
            }
        }
        throw new TeaUnableRetryError($_lastRequest);
    }

    public function getBucket(GetBucketRequest $request, RuntimeOptions $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime     = [
            "timeouted"      => "retry",
            "readTimeout"    => Utils::defaultNumber($runtime->readTimeout, $this->_readTimeout),
            "connectTimeout" => Utils::defaultNumber($runtime->connectTimeout, $this->_connectTimeout),
            "localAddr"      => Utils::defaultString($runtime->localAddr, $this->_localAddr),
            "httpProxy"      => Utils::defaultString($runtime->httpProxy, $this->_httpProxy),
            "httpsProxy"     => Utils::defaultString($runtime->httpsProxy, $this->_httpsProxy),
            "noProxy"        => Utils::defaultString($runtime->noProxy, $this->_noProxy),
            "socks5Proxy"    => Utils::defaultString($runtime->socks5Proxy, $this->_socks5Proxy),
            "socks5NetWork"  => Utils::defaultString($runtime->socks5NetWork, $this->_socks5NetWork),
            "maxIdleConns"   => Utils::defaultNumber($runtime->maxIdleConns, $this->_maxIdleConns),
            "retry"          => [
                "retryable"   => $runtime->autoretry,
                "maxAttempts" => Utils::defaultNumber($runtime->maxAttempts, 3)
            ],
            "backoff"        => [
                "policy" => Utils::defaultString($runtime->backoffPolicy, "no"),
                "period" => Utils::defaultNumber($runtime->backoffPeriod, 1)
            ],
            "ignoreSSL"      => $runtime->ignoreSSL
        ];
        $_lastRequest = null;
        $_now         = time();
        $_retryTimes  = 0;
        while (Tea::allowRetry($_runtime["retry"], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime($_runtime["backoff"], $_retryTimes);
                if ($_backoffTime > 0) {
                    Tea::sleep($_backoffTime);
                }
            }
            $_retryTimes = $_retryTimes + 1;
            try {
                $_request           = new Request();
                $accessKeyId        = $this->_credential->getAccessKeyId();
                $accessKeySecret    = $this->_credential->getAccessKeySecret();
                $token              = $this->_credential->getSecurityToken();
                $_request->protocol = $this->_protocol;
                $_request->method   = "GET";
                $_request->pathname = "/";
                $_request->headers  = [
                    "host"       => OSSUtils::getHost($request->bucketName, $this->_regionId, $this->_endpoint, $this->_hostModel),
                    "date"       => Utils::getDateUTCString(),
                    "user-agent" => $this->getUserAgent()
                ];
                if (!Utils::_empty($token)) {
                    $_request->headers["x-oss-security-token"] = $token;
                }
                $_request->query                    = Utils::stringifyMapValue($request->filter);
                $_request->headers["authorization"] = OSSUtils::getSignature($_request, $request->bucketName, $accessKeyId, $accessKeySecret, $this->_signatureVersion, $this->_addtionalHeaders);
                $_lastRequest                       = $_request;
                $_response                          = Tea::send($_request, $_runtime);
                $respMap                            = null;
                $bodyStr                            = null;
                if (Utils::is4xx($_response->statusCode) || Utils::is5xx($_response->statusCode)) {
                    $bodyStr = Utils::readAsString($_response->body);
                    $respMap = OSSUtils::getErrMessage($bodyStr);
                    throw new TeaError([
                        "code"    => $respMap["Code"],
                        "message" => $respMap["Message"],
                        "data"    => [
                            "httpCode"  => $_response->statusCode,
                            "requestId" => $respMap["RequestId"],
                            "hostId"    => $respMap["HostId"]
                        ]
                    ]);
                }
                $bodyStr = Utils::readAsString($_response->body);
                $respMap = XML::parseXml($bodyStr, GetBucketResponse::class);
                return [
                    [
                        "ListBucketResult" => $respMap["ListBucketResult"],
                    ],
                    $_response->headers
                ];
            } catch (\Exception $e) {
                if (Tea::isRetryable($e)) {
                    continue;
                }
                throw $e;
            }
        }
        throw new TeaUnableRetryError($_lastRequest);
    }

    public function getLiveChannelInfo(GetLiveChannelInfoRequest $request, RuntimeOptions $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime     = [
            "timeouted"      => "retry",
            "readTimeout"    => Utils::defaultNumber($runtime->readTimeout, $this->_readTimeout),
            "connectTimeout" => Utils::defaultNumber($runtime->connectTimeout, $this->_connectTimeout),
            "localAddr"      => Utils::defaultString($runtime->localAddr, $this->_localAddr),
            "httpProxy"      => Utils::defaultString($runtime->httpProxy, $this->_httpProxy),
            "httpsProxy"     => Utils::defaultString($runtime->httpsProxy, $this->_httpsProxy),
            "noProxy"        => Utils::defaultString($runtime->noProxy, $this->_noProxy),
            "socks5Proxy"    => Utils::defaultString($runtime->socks5Proxy, $this->_socks5Proxy),
            "socks5NetWork"  => Utils::defaultString($runtime->socks5NetWork, $this->_socks5NetWork),
            "maxIdleConns"   => Utils::defaultNumber($runtime->maxIdleConns, $this->_maxIdleConns),
            "retry"          => [
                "retryable"   => $runtime->autoretry,
                "maxAttempts" => Utils::defaultNumber($runtime->maxAttempts, 3)
            ],
            "backoff"        => [
                "policy" => Utils::defaultString($runtime->backoffPolicy, "no"),
                "period" => Utils::defaultNumber($runtime->backoffPeriod, 1)
            ],
            "ignoreSSL"      => $runtime->ignoreSSL
        ];
        $_lastRequest = null;
        $_now         = time();
        $_retryTimes  = 0;
        while (Tea::allowRetry($_runtime["retry"], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime($_runtime["backoff"], $_retryTimes);
                if ($_backoffTime > 0) {
                    Tea::sleep($_backoffTime);
                }
            }
            $_retryTimes = $_retryTimes + 1;
            try {
                $_request           = new Request();
                $accessKeyId        = $this->_credential->getAccessKeyId();
                $accessKeySecret    = $this->_credential->getAccessKeySecret();
                $token              = $this->_credential->getSecurityToken();
                $_request->protocol = $this->_protocol;
                $_request->method   = "GET";
                $_request->pathname = "/" . $request->channelName . "?live";
                $_request->headers  = [
                    "host"       => OSSUtils::getHost($request->bucketName, $this->_regionId, $this->_endpoint, $this->_hostModel),
                    "date"       => Utils::getDateUTCString(),
                    "user-agent" => $this->getUserAgent()
                ];
                if (!Utils::_empty($token)) {
                    $_request->headers["x-oss-security-token"] = $token;
                }
                $_request->headers["authorization"] = OSSUtils::getSignature($_request, $request->bucketName, $accessKeyId, $accessKeySecret, $this->_signatureVersion, $this->_addtionalHeaders);
                $_lastRequest                       = $_request;
                $_response                          = Tea::send($_request, $_runtime);
                $respMap                            = null;
                $bodyStr                            = null;
                if (Utils::is4xx($_response->statusCode) || Utils::is5xx($_response->statusCode)) {
                    $bodyStr = Utils::readAsString($_response->body);
                    $respMap = OSSUtils::getErrMessage($bodyStr);
                    throw new TeaError([
                        "code"    => $respMap["Code"],
                        "message" => $respMap["Message"],
                        "data"    => [
                            "httpCode"  => $_response->statusCode,
                            "requestId" => $respMap["RequestId"],
                            "hostId"    => $respMap["HostId"]
                        ]
                    ]);
                }
                $bodyStr = Utils::readAsString($_response->body);
                $respMap = XML::parseXml($bodyStr, GetLiveChannelInfoResponse::class);
                return [
                    [
                        "LiveChannelConfiguration" => $respMap["LiveChannelConfiguration"],
                    ],
                    $_response->headers
                ];
            } catch (\Exception $e) {
                if (Tea::isRetryable($e)) {
                    continue;
                }
                throw $e;
            }
        }
        throw new TeaUnableRetryError($_lastRequest);
    }

    public function getLiveChannelStat(GetLiveChannelStatRequest $request, RuntimeOptions $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime     = [
            "timeouted"      => "retry",
            "readTimeout"    => Utils::defaultNumber($runtime->readTimeout, $this->_readTimeout),
            "connectTimeout" => Utils::defaultNumber($runtime->connectTimeout, $this->_connectTimeout),
            "localAddr"      => Utils::defaultString($runtime->localAddr, $this->_localAddr),
            "httpProxy"      => Utils::defaultString($runtime->httpProxy, $this->_httpProxy),
            "httpsProxy"     => Utils::defaultString($runtime->httpsProxy, $this->_httpsProxy),
            "noProxy"        => Utils::defaultString($runtime->noProxy, $this->_noProxy),
            "socks5Proxy"    => Utils::defaultString($runtime->socks5Proxy, $this->_socks5Proxy),
            "socks5NetWork"  => Utils::defaultString($runtime->socks5NetWork, $this->_socks5NetWork),
            "maxIdleConns"   => Utils::defaultNumber($runtime->maxIdleConns, $this->_maxIdleConns),
            "retry"          => [
                "retryable"   => $runtime->autoretry,
                "maxAttempts" => Utils::defaultNumber($runtime->maxAttempts, 3)
            ],
            "backoff"        => [
                "policy" => Utils::defaultString($runtime->backoffPolicy, "no"),
                "period" => Utils::defaultNumber($runtime->backoffPeriod, 1)
            ],
            "ignoreSSL"      => $runtime->ignoreSSL
        ];
        $_lastRequest = null;
        $_now         = time();
        $_retryTimes  = 0;
        while (Tea::allowRetry($_runtime["retry"], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime($_runtime["backoff"], $_retryTimes);
                if ($_backoffTime > 0) {
                    Tea::sleep($_backoffTime);
                }
            }
            $_retryTimes = $_retryTimes + 1;
            try {
                $_request           = new Request();
                $accessKeyId        = $this->_credential->getAccessKeyId();
                $accessKeySecret    = $this->_credential->getAccessKeySecret();
                $token              = $this->_credential->getSecurityToken();
                $_request->protocol = $this->_protocol;
                $_request->method   = "GET";
                $_request->pathname = "/" . $request->channelName . "?live";
                $_request->headers  = [
                    "host"       => OSSUtils::getHost($request->bucketName, $this->_regionId, $this->_endpoint, $this->_hostModel),
                    "date"       => Utils::getDateUTCString(),
                    "user-agent" => $this->getUserAgent()
                ];
                if (!Utils::_empty($token)) {
                    $_request->headers["x-oss-security-token"] = $token;
                }
                $_request->query                    = Utils::stringifyMapValue($request->filter);
                $_request->headers["authorization"] = OSSUtils::getSignature($_request, $request->bucketName, $accessKeyId, $accessKeySecret, $this->_signatureVersion, $this->_addtionalHeaders);
                $_lastRequest                       = $_request;
                $_response                          = Tea::send($_request, $_runtime);
                $respMap                            = null;
                $bodyStr                            = null;
                if (Utils::is4xx($_response->statusCode) || Utils::is5xx($_response->statusCode)) {
                    $bodyStr = Utils::readAsString($_response->body);
                    $respMap = OSSUtils::getErrMessage($bodyStr);
                    throw new TeaError([
                        "code"    => $respMap["Code"],
                        "message" => $respMap["Message"],
                        "data"    => [
                            "httpCode"  => $_response->statusCode,
                            "requestId" => $respMap["RequestId"],
                            "hostId"    => $respMap["HostId"]
                        ]
                    ]);
                }
                $bodyStr = Utils::readAsString($_response->body);
                $respMap = XML::parseXml($bodyStr, GetLiveChannelStatResponse::class);
                return [
                    [
                        "LiveChannelStat" => $respMap["LiveChannelStat"],
                    ],
                    $_response->headers
                ];
            } catch (\Exception $e) {
                if (Tea::isRetryable($e)) {
                    continue;
                }
                throw $e;
            }
        }
        throw new TeaUnableRetryError($_lastRequest);
    }

    public function deleteObject(DeleteObjectRequest $request, RuntimeOptions $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime     = [
            "timeouted"      => "retry",
            "readTimeout"    => Utils::defaultNumber($runtime->readTimeout, $this->_readTimeout),
            "connectTimeout" => Utils::defaultNumber($runtime->connectTimeout, $this->_connectTimeout),
            "localAddr"      => Utils::defaultString($runtime->localAddr, $this->_localAddr),
            "httpProxy"      => Utils::defaultString($runtime->httpProxy, $this->_httpProxy),
            "httpsProxy"     => Utils::defaultString($runtime->httpsProxy, $this->_httpsProxy),
            "noProxy"        => Utils::defaultString($runtime->noProxy, $this->_noProxy),
            "socks5Proxy"    => Utils::defaultString($runtime->socks5Proxy, $this->_socks5Proxy),
            "socks5NetWork"  => Utils::defaultString($runtime->socks5NetWork, $this->_socks5NetWork),
            "maxIdleConns"   => Utils::defaultNumber($runtime->maxIdleConns, $this->_maxIdleConns),
            "retry"          => [
                "retryable"   => $runtime->autoretry,
                "maxAttempts" => Utils::defaultNumber($runtime->maxAttempts, 3)
            ],
            "backoff"        => [
                "policy" => Utils::defaultString($runtime->backoffPolicy, "no"),
                "period" => Utils::defaultNumber($runtime->backoffPeriod, 1)
            ],
            "ignoreSSL"      => $runtime->ignoreSSL
        ];
        $_lastRequest = null;
        $_now         = time();
        $_retryTimes  = 0;
        while (Tea::allowRetry($_runtime["retry"], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime($_runtime["backoff"], $_retryTimes);
                if ($_backoffTime > 0) {
                    Tea::sleep($_backoffTime);
                }
            }
            $_retryTimes = $_retryTimes + 1;
            try {
                $_request           = new Request();
                $accessKeyId        = $this->_credential->getAccessKeyId();
                $accessKeySecret    = $this->_credential->getAccessKeySecret();
                $token              = $this->_credential->getSecurityToken();
                $_request->protocol = $this->_protocol;
                $_request->method   = "DELETE";
                $_request->pathname = "/" . $request->objectName . "";
                $_request->headers  = [
                    "host"       => OSSUtils::getHost($request->bucketName, $this->_regionId, $this->_endpoint, $this->_hostModel),
                    "date"       => Utils::getDateUTCString(),
                    "user-agent" => $this->getUserAgent()
                ];
                if (!Utils::_empty($token)) {
                    $_request->headers["x-oss-security-token"] = $token;
                }
                $_request->headers["authorization"] = OSSUtils::getSignature($_request, $request->bucketName, $accessKeyId, $accessKeySecret, $this->_signatureVersion, $this->_addtionalHeaders);
                $_lastRequest                       = $_request;
                $_response                          = Tea::send($_request, $_runtime);
                $respMap                            = null;
                $bodyStr                            = null;
                if (Utils::is4xx($_response->statusCode) || Utils::is5xx($_response->statusCode)) {
                    $bodyStr = Utils::readAsString($_response->body);
                    $respMap = OSSUtils::getErrMessage($bodyStr);
                    throw new TeaError([
                        "code"    => $respMap["Code"],
                        "message" => $respMap["Message"],
                        "data"    => [
                            "httpCode"  => $_response->statusCode,
                            "requestId" => $respMap["RequestId"],
                            "hostId"    => $respMap["HostId"]
                        ]
                    ]);
                }
                return $_response->headers;
            } catch (\Exception $e) {
                if (Tea::isRetryable($e)) {
                    continue;
                }
                throw $e;
            }
        }
        throw new TeaUnableRetryError($_lastRequest);
    }

    public function abortMultipartUpload(AbortMultipartUploadRequest $request, RuntimeOptions $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime     = [
            "timeouted"      => "retry",
            "readTimeout"    => Utils::defaultNumber($runtime->readTimeout, $this->_readTimeout),
            "connectTimeout" => Utils::defaultNumber($runtime->connectTimeout, $this->_connectTimeout),
            "localAddr"      => Utils::defaultString($runtime->localAddr, $this->_localAddr),
            "httpProxy"      => Utils::defaultString($runtime->httpProxy, $this->_httpProxy),
            "httpsProxy"     => Utils::defaultString($runtime->httpsProxy, $this->_httpsProxy),
            "noProxy"        => Utils::defaultString($runtime->noProxy, $this->_noProxy),
            "socks5Proxy"    => Utils::defaultString($runtime->socks5Proxy, $this->_socks5Proxy),
            "socks5NetWork"  => Utils::defaultString($runtime->socks5NetWork, $this->_socks5NetWork),
            "maxIdleConns"   => Utils::defaultNumber($runtime->maxIdleConns, $this->_maxIdleConns),
            "retry"          => [
                "retryable"   => $runtime->autoretry,
                "maxAttempts" => Utils::defaultNumber($runtime->maxAttempts, 3)
            ],
            "backoff"        => [
                "policy" => Utils::defaultString($runtime->backoffPolicy, "no"),
                "period" => Utils::defaultNumber($runtime->backoffPeriod, 1)
            ],
            "ignoreSSL"      => $runtime->ignoreSSL
        ];
        $_lastRequest = null;
        $_now         = time();
        $_retryTimes  = 0;
        while (Tea::allowRetry($_runtime["retry"], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime($_runtime["backoff"], $_retryTimes);
                if ($_backoffTime > 0) {
                    Tea::sleep($_backoffTime);
                }
            }
            $_retryTimes = $_retryTimes + 1;
            try {
                $_request           = new Request();
                $accessKeyId        = $this->_credential->getAccessKeyId();
                $accessKeySecret    = $this->_credential->getAccessKeySecret();
                $token              = $this->_credential->getSecurityToken();
                $_request->protocol = $this->_protocol;
                $_request->method   = "DELETE";
                $_request->pathname = "/" . $request->objectName . "";
                $_request->headers  = [
                    "host"       => OSSUtils::getHost($request->bucketName, $this->_regionId, $this->_endpoint, $this->_hostModel),
                    "date"       => Utils::getDateUTCString(),
                    "user-agent" => $this->getUserAgent()
                ];
                if (!Utils::_empty($token)) {
                    $_request->headers["x-oss-security-token"] = $token;
                }
                $_request->query                    = Utils::stringifyMapValue($request->filter);
                $_request->headers["authorization"] = OSSUtils::getSignature($_request, $request->bucketName, $accessKeyId, $accessKeySecret, $this->_signatureVersion, $this->_addtionalHeaders);
                $_lastRequest                       = $_request;
                $_response                          = Tea::send($_request, $_runtime);
                $respMap                            = null;
                $bodyStr                            = null;
                if (Utils::is4xx($_response->statusCode) || Utils::is5xx($_response->statusCode)) {
                    $bodyStr = Utils::readAsString($_response->body);
                    $respMap = OSSUtils::getErrMessage($bodyStr);
                    throw new TeaError([
                        "code"    => $respMap["Code"],
                        "message" => $respMap["Message"],
                        "data"    => [
                            "httpCode"  => $_response->statusCode,
                            "requestId" => $respMap["RequestId"],
                            "hostId"    => $respMap["HostId"]
                        ]
                    ]);
                }
                return $_response->headers;
            } catch (\Exception $e) {
                if (Tea::isRetryable($e)) {
                    continue;
                }
                throw $e;
            }
        }
        throw new TeaUnableRetryError($_lastRequest);
    }

    public function appendObject(AppendObjectRequest $request, RuntimeOptions $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime     = [
            "timeouted"      => "retry",
            "readTimeout"    => Utils::defaultNumber($runtime->readTimeout, $this->_readTimeout),
            "connectTimeout" => Utils::defaultNumber($runtime->connectTimeout, $this->_connectTimeout),
            "localAddr"      => Utils::defaultString($runtime->localAddr, $this->_localAddr),
            "httpProxy"      => Utils::defaultString($runtime->httpProxy, $this->_httpProxy),
            "httpsProxy"     => Utils::defaultString($runtime->httpsProxy, $this->_httpsProxy),
            "noProxy"        => Utils::defaultString($runtime->noProxy, $this->_noProxy),
            "socks5Proxy"    => Utils::defaultString($runtime->socks5Proxy, $this->_socks5Proxy),
            "socks5NetWork"  => Utils::defaultString($runtime->socks5NetWork, $this->_socks5NetWork),
            "maxIdleConns"   => Utils::defaultNumber($runtime->maxIdleConns, $this->_maxIdleConns),
            "retry"          => [
                "retryable"   => $runtime->autoretry,
                "maxAttempts" => Utils::defaultNumber($runtime->maxAttempts, 3)
            ],
            "backoff"        => [
                "policy" => Utils::defaultString($runtime->backoffPolicy, "no"),
                "period" => Utils::defaultNumber($runtime->backoffPeriod, 1)
            ],
            "ignoreSSL"      => $runtime->ignoreSSL
        ];
        $_lastRequest = null;
        $_now         = time();
        $_retryTimes  = 0;
        while (Tea::allowRetry($_runtime["retry"], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime($_runtime["backoff"], $_retryTimes);
                if ($_backoffTime > 0) {
                    Tea::sleep($_backoffTime);
                }
            }
            $_retryTimes = $_retryTimes + 1;
            try {
                $_request           = new Request();
                $ctx                = [];
                $accessKeyId        = $this->_credential->getAccessKeyId();
                $accessKeySecret    = $this->_credential->getAccessKeySecret();
                $token              = $this->_credential->getSecurityToken();
                $_request->protocol = $this->_protocol;
                $_request->method   = "POST";
                $_request->pathname = "/" . $request->objectName . "?append";
                $_request->headers  = [
                    "host"       => OSSUtils::getHost($request->bucketName, $this->_regionId, $this->_endpoint, $this->_hostModel),
                    "date"       => Utils::getDateUTCString(),
                    "user-agent" => $this->getUserAgent(),
                    Utils::stringifyMapValue($request->header),
                    OSSUtils::parseMeta($request->userMeta, "x-oss-meta-")
                ];
                if (!Utils::_empty($token)) {
                    $_request->headers["x-oss-security-token"] = $token;
                }
                $_request->query = Utils::stringifyMapValue($request->filter);
                $_request->body  = OSSUtils::inject($request->body, $ctx);
                if (Utils::isUnset($request->header) && !Utils::_empty($request->header->contentType)) {
                    $_request->headers["content-type"] = $request->header->contentType;
                } else {
                    $_request->headers["content-type"] = OSSUtils::getContentType($request->objectName);
                }
                $_request->headers["authorization"] = OSSUtils::getSignature($_request, $request->bucketName, $accessKeyId, $accessKeySecret, $this->_signatureVersion, $this->_addtionalHeaders);
                $_lastRequest                       = $_request;
                $_response                          = Tea::send($_request, $_runtime);
                $respMap                            = null;
                $bodyStr                            = null;
                if (Utils::is4xx($_response->statusCode) || Utils::is5xx($_response->statusCode)) {
                    $bodyStr = Utils::readAsString($_response->body);
                    $respMap = OSSUtils::getErrMessage($bodyStr);
                    throw new TeaError([
                        "code"    => $respMap["Code"],
                        "message" => $respMap["Message"],
                        "data"    => [
                            "httpCode"  => $_response->statusCode,
                            "requestId" => $respMap["RequestId"],
                            "hostId"    => $respMap["HostId"]
                        ]
                    ]);
                }
                if ($this->_isEnableCrc && !Utils::equalString($ctx["crc"], $_response->headers["x-oss-hash-crc64ecma"])) {
                    throw new TeaError([
                        "code" => "CrcNotMatched",
                        "data" => [
                            "clientCrc" => $ctx["crc"],
                            "serverCrc" => $_response->headers["x-oss-hash-crc64ecma"]
                        ]
                    ]);
                }
                if ($this->_isEnableMD5 && !Utils::equalString($ctx["md5"], $_response->headers["content-md5"])) {
                    throw new TeaError([
                        "code" => "MD5NotMatched",
                        "data" => [
                            "clientMD5" => $ctx["md5"],
                            "serverMD5" => $_response->headers["content-md5"]
                        ]
                    ]);
                }
                return $_response->headers;
            } catch (\Exception $e) {
                if (Tea::isRetryable($e)) {
                    continue;
                }
                throw $e;
            }
        }
        throw new TeaUnableRetryError($_lastRequest);
    }

    public function uploadPartCopy(UploadPartCopyRequest $request, RuntimeOptions $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime     = [
            "timeouted"      => "retry",
            "readTimeout"    => Utils::defaultNumber($runtime->readTimeout, $this->_readTimeout),
            "connectTimeout" => Utils::defaultNumber($runtime->connectTimeout, $this->_connectTimeout),
            "localAddr"      => Utils::defaultString($runtime->localAddr, $this->_localAddr),
            "httpProxy"      => Utils::defaultString($runtime->httpProxy, $this->_httpProxy),
            "httpsProxy"     => Utils::defaultString($runtime->httpsProxy, $this->_httpsProxy),
            "noProxy"        => Utils::defaultString($runtime->noProxy, $this->_noProxy),
            "socks5Proxy"    => Utils::defaultString($runtime->socks5Proxy, $this->_socks5Proxy),
            "socks5NetWork"  => Utils::defaultString($runtime->socks5NetWork, $this->_socks5NetWork),
            "maxIdleConns"   => Utils::defaultNumber($runtime->maxIdleConns, $this->_maxIdleConns),
            "retry"          => [
                "retryable"   => $runtime->autoretry,
                "maxAttempts" => Utils::defaultNumber($runtime->maxAttempts, 3)
            ],
            "backoff"        => [
                "policy" => Utils::defaultString($runtime->backoffPolicy, "no"),
                "period" => Utils::defaultNumber($runtime->backoffPeriod, 1)
            ],
            "ignoreSSL"      => $runtime->ignoreSSL
        ];
        $_lastRequest = null;
        $_now         = time();
        $_retryTimes  = 0;
        while (Tea::allowRetry($_runtime["retry"], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime($_runtime["backoff"], $_retryTimes);
                if ($_backoffTime > 0) {
                    Tea::sleep($_backoffTime);
                }
            }
            $_retryTimes = $_retryTimes + 1;
            try {
                $_request           = new Request();
                $accessKeyId        = $this->_credential->getAccessKeyId();
                $accessKeySecret    = $this->_credential->getAccessKeySecret();
                $token              = $this->_credential->getSecurityToken();
                $_request->protocol = $this->_protocol;
                $_request->method   = "PUT";
                $_request->pathname = "/" . $request->objectName . "";
                $_request->headers  = [
                    "host"       => OSSUtils::getHost($request->bucketName, $this->_regionId, $this->_endpoint, $this->_hostModel),
                    "date"       => Utils::getDateUTCString(),
                    "user-agent" => $this->getUserAgent(),
                    Utils::stringifyMapValue($request->header)
                ];
                if (!Utils::_empty($token)) {
                    $_request->headers["x-oss-security-token"] = $token;
                }
                $_request->query                    = Utils::stringifyMapValue($request->filter);
                $_request->headers["authorization"] = OSSUtils::getSignature($_request, $request->bucketName, $accessKeyId, $accessKeySecret, $this->_signatureVersion, $this->_addtionalHeaders);
                $_lastRequest                       = $_request;
                $_response                          = Tea::send($_request, $_runtime);
                $respMap                            = null;
                $bodyStr                            = null;
                if (Utils::is4xx($_response->statusCode) || Utils::is5xx($_response->statusCode)) {
                    $bodyStr = Utils::readAsString($_response->body);
                    $respMap = OSSUtils::getErrMessage($bodyStr);
                    throw new TeaError([
                        "code"    => $respMap["Code"],
                        "message" => $respMap["Message"],
                        "data"    => [
                            "httpCode"  => $_response->statusCode,
                            "requestId" => $respMap["RequestId"],
                            "hostId"    => $respMap["HostId"]
                        ]
                    ]);
                }
                $bodyStr = Utils::readAsString($_response->body);
                $respMap = XML::parseXml($bodyStr, UploadPartCopyResponse::class);
                return [
                    [
                        "CopyPartResult" => $respMap["CopyPartResult"],
                    ],
                    $_response->headers
                ];
            } catch (\Exception $e) {
                if (Tea::isRetryable($e)) {
                    continue;
                }
                throw $e;
            }
        }
        throw new TeaUnableRetryError($_lastRequest);
    }

    public function getVodPlaylist(GetVodPlaylistRequest $request, RuntimeOptions $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime     = [
            "timeouted"      => "retry",
            "readTimeout"    => Utils::defaultNumber($runtime->readTimeout, $this->_readTimeout),
            "connectTimeout" => Utils::defaultNumber($runtime->connectTimeout, $this->_connectTimeout),
            "localAddr"      => Utils::defaultString($runtime->localAddr, $this->_localAddr),
            "httpProxy"      => Utils::defaultString($runtime->httpProxy, $this->_httpProxy),
            "httpsProxy"     => Utils::defaultString($runtime->httpsProxy, $this->_httpsProxy),
            "noProxy"        => Utils::defaultString($runtime->noProxy, $this->_noProxy),
            "socks5Proxy"    => Utils::defaultString($runtime->socks5Proxy, $this->_socks5Proxy),
            "socks5NetWork"  => Utils::defaultString($runtime->socks5NetWork, $this->_socks5NetWork),
            "maxIdleConns"   => Utils::defaultNumber($runtime->maxIdleConns, $this->_maxIdleConns),
            "retry"          => [
                "retryable"   => $runtime->autoretry,
                "maxAttempts" => Utils::defaultNumber($runtime->maxAttempts, 3)
            ],
            "backoff"        => [
                "policy" => Utils::defaultString($runtime->backoffPolicy, "no"),
                "period" => Utils::defaultNumber($runtime->backoffPeriod, 1)
            ],
            "ignoreSSL"      => $runtime->ignoreSSL
        ];
        $_lastRequest = null;
        $_now         = time();
        $_retryTimes  = 0;
        while (Tea::allowRetry($_runtime["retry"], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime($_runtime["backoff"], $_retryTimes);
                if ($_backoffTime > 0) {
                    Tea::sleep($_backoffTime);
                }
            }
            $_retryTimes = $_retryTimes + 1;
            try {
                $_request           = new Request();
                $accessKeyId        = $this->_credential->getAccessKeyId();
                $accessKeySecret    = $this->_credential->getAccessKeySecret();
                $token              = $this->_credential->getSecurityToken();
                $_request->protocol = $this->_protocol;
                $_request->method   = "GET";
                $_request->pathname = "/" . $request->channelName . "?vod";
                $_request->headers  = [
                    "host"       => OSSUtils::getHost($request->bucketName, $this->_regionId, $this->_endpoint, $this->_hostModel),
                    "date"       => Utils::getDateUTCString(),
                    "user-agent" => $this->getUserAgent()
                ];
                if (!Utils::_empty($token)) {
                    $_request->headers["x-oss-security-token"] = $token;
                }
                $_request->query                    = Utils::stringifyMapValue($request->filter);
                $_request->headers["authorization"] = OSSUtils::getSignature($_request, $request->bucketName, $accessKeyId, $accessKeySecret, $this->_signatureVersion, $this->_addtionalHeaders);
                $_lastRequest                       = $_request;
                $_response                          = Tea::send($_request, $_runtime);
                $respMap                            = null;
                $bodyStr                            = null;
                if (Utils::is4xx($_response->statusCode) || Utils::is5xx($_response->statusCode)) {
                    $bodyStr = Utils::readAsString($_response->body);
                    $respMap = OSSUtils::getErrMessage($bodyStr);
                    throw new TeaError([
                        "code"    => $respMap["Code"],
                        "message" => $respMap["Message"],
                        "data"    => [
                            "httpCode"  => $_response->statusCode,
                            "requestId" => $respMap["RequestId"],
                            "hostId"    => $respMap["HostId"]
                        ]
                    ]);
                }
                return $_response->headers;
            } catch (\Exception $e) {
                if (Tea::isRetryable($e)) {
                    continue;
                }
                throw $e;
            }
        }
        throw new TeaUnableRetryError($_lastRequest);
    }

    public function deleteBucketCORS(DeleteBucketCORSRequest $request, RuntimeOptions $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime     = [
            "timeouted"      => "retry",
            "readTimeout"    => Utils::defaultNumber($runtime->readTimeout, $this->_readTimeout),
            "connectTimeout" => Utils::defaultNumber($runtime->connectTimeout, $this->_connectTimeout),
            "localAddr"      => Utils::defaultString($runtime->localAddr, $this->_localAddr),
            "httpProxy"      => Utils::defaultString($runtime->httpProxy, $this->_httpProxy),
            "httpsProxy"     => Utils::defaultString($runtime->httpsProxy, $this->_httpsProxy),
            "noProxy"        => Utils::defaultString($runtime->noProxy, $this->_noProxy),
            "socks5Proxy"    => Utils::defaultString($runtime->socks5Proxy, $this->_socks5Proxy),
            "socks5NetWork"  => Utils::defaultString($runtime->socks5NetWork, $this->_socks5NetWork),
            "maxIdleConns"   => Utils::defaultNumber($runtime->maxIdleConns, $this->_maxIdleConns),
            "retry"          => [
                "retryable"   => $runtime->autoretry,
                "maxAttempts" => Utils::defaultNumber($runtime->maxAttempts, 3)
            ],
            "backoff"        => [
                "policy" => Utils::defaultString($runtime->backoffPolicy, "no"),
                "period" => Utils::defaultNumber($runtime->backoffPeriod, 1)
            ],
            "ignoreSSL"      => $runtime->ignoreSSL
        ];
        $_lastRequest = null;
        $_now         = time();
        $_retryTimes  = 0;
        while (Tea::allowRetry($_runtime["retry"], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime($_runtime["backoff"], $_retryTimes);
                if ($_backoffTime > 0) {
                    Tea::sleep($_backoffTime);
                }
            }
            $_retryTimes = $_retryTimes + 1;
            try {
                $_request           = new Request();
                $accessKeyId        = $this->_credential->getAccessKeyId();
                $accessKeySecret    = $this->_credential->getAccessKeySecret();
                $token              = $this->_credential->getSecurityToken();
                $_request->protocol = $this->_protocol;
                $_request->method   = "DELETE";
                $_request->pathname = "/?cors";
                $_request->headers  = [
                    "host"       => OSSUtils::getHost($request->bucketName, $this->_regionId, $this->_endpoint, $this->_hostModel),
                    "date"       => Utils::getDateUTCString(),
                    "user-agent" => $this->getUserAgent()
                ];
                if (!Utils::_empty($token)) {
                    $_request->headers["x-oss-security-token"] = $token;
                }
                $_request->headers["authorization"] = OSSUtils::getSignature($_request, $request->bucketName, $accessKeyId, $accessKeySecret, $this->_signatureVersion, $this->_addtionalHeaders);
                $_lastRequest                       = $_request;
                $_response                          = Tea::send($_request, $_runtime);
                $respMap                            = null;
                $bodyStr                            = null;
                if (Utils::is4xx($_response->statusCode) || Utils::is5xx($_response->statusCode)) {
                    $bodyStr = Utils::readAsString($_response->body);
                    $respMap = OSSUtils::getErrMessage($bodyStr);
                    throw new TeaError([
                        "code"    => $respMap["Code"],
                        "message" => $respMap["Message"],
                        "data"    => [
                            "httpCode"  => $_response->statusCode,
                            "requestId" => $respMap["RequestId"],
                            "hostId"    => $respMap["HostId"]
                        ]
                    ]);
                }
                return $_response->headers;
            } catch (\Exception $e) {
                if (Tea::isRetryable($e)) {
                    continue;
                }
                throw $e;
            }
        }
        throw new TeaUnableRetryError($_lastRequest);
    }

    public function getObject(GetObjectRequest $request, RuntimeOptions $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime     = [
            "timeouted"      => "retry",
            "readTimeout"    => Utils::defaultNumber($runtime->readTimeout, $this->_readTimeout),
            "connectTimeout" => Utils::defaultNumber($runtime->connectTimeout, $this->_connectTimeout),
            "localAddr"      => Utils::defaultString($runtime->localAddr, $this->_localAddr),
            "httpProxy"      => Utils::defaultString($runtime->httpProxy, $this->_httpProxy),
            "httpsProxy"     => Utils::defaultString($runtime->httpsProxy, $this->_httpsProxy),
            "noProxy"        => Utils::defaultString($runtime->noProxy, $this->_noProxy),
            "socks5Proxy"    => Utils::defaultString($runtime->socks5Proxy, $this->_socks5Proxy),
            "socks5NetWork"  => Utils::defaultString($runtime->socks5NetWork, $this->_socks5NetWork),
            "maxIdleConns"   => Utils::defaultNumber($runtime->maxIdleConns, $this->_maxIdleConns),
            "retry"          => [
                "retryable"   => $runtime->autoretry,
                "maxAttempts" => Utils::defaultNumber($runtime->maxAttempts, 3)
            ],
            "backoff"        => [
                "policy" => Utils::defaultString($runtime->backoffPolicy, "no"),
                "period" => Utils::defaultNumber($runtime->backoffPeriod, 1)
            ],
            "ignoreSSL"      => $runtime->ignoreSSL
        ];
        $_lastRequest = null;
        $_now         = time();
        $_retryTimes  = 0;
        while (Tea::allowRetry($_runtime["retry"], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime($_runtime["backoff"], $_retryTimes);
                if ($_backoffTime > 0) {
                    Tea::sleep($_backoffTime);
                }
            }
            $_retryTimes = $_retryTimes + 1;
            try {
                $_request           = new Request();
                $accessKeyId        = $this->_credential->getAccessKeyId();
                $accessKeySecret    = $this->_credential->getAccessKeySecret();
                $token              = $this->_credential->getSecurityToken();
                $_request->protocol = $this->_protocol;
                $_request->method   = "GET";
                $_request->pathname = "/" . $request->objectName . "";
                $_request->headers  = [
                    "host"       => OSSUtils::getHost($request->bucketName, $this->_regionId, $this->_endpoint, $this->_hostModel),
                    "date"       => Utils::getDateUTCString(),
                    "user-agent" => $this->getUserAgent(),
                    Utils::stringifyMapValue($request->header)
                ];
                if (!Utils::_empty($token)) {
                    $_request->headers["x-oss-security-token"] = $token;
                }
                $_request->headers["authorization"] = OSSUtils::getSignature($_request, $request->bucketName, $accessKeyId, $accessKeySecret, $this->_signatureVersion, $this->_addtionalHeaders);
                $_lastRequest                       = $_request;
                $_response                          = Tea::send($_request, $_runtime);
                $respMap                            = null;
                $bodyStr                            = null;
                if (Utils::is4xx($_response->statusCode) || Utils::is5xx($_response->statusCode)) {
                    $bodyStr = Utils::readAsString($_response->body);
                    $respMap = OSSUtils::getErrMessage($bodyStr);
                    throw new TeaError([
                        "code"    => $respMap["Code"],
                        "message" => $respMap["Message"],
                        "data"    => [
                            "httpCode"  => $_response->statusCode,
                            "requestId" => $respMap["RequestId"],
                            "hostId"    => $respMap["HostId"]
                        ]
                    ]);
                }
                return [
                    [
                        "body" => $_response->body,
                    ],
                    $_response->headers
                ];
            } catch (\Exception $e) {
                if (Tea::isRetryable($e)) {
                    continue;
                }
                throw $e;
            }
        }
        throw new TeaUnableRetryError($_lastRequest);
    }

    public function uploadPart(UploadPartRequest $request, RuntimeOptions $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime     = [
            "timeouted"      => "retry",
            "readTimeout"    => Utils::defaultNumber($runtime->readTimeout, $this->_readTimeout),
            "connectTimeout" => Utils::defaultNumber($runtime->connectTimeout, $this->_connectTimeout),
            "localAddr"      => Utils::defaultString($runtime->localAddr, $this->_localAddr),
            "httpProxy"      => Utils::defaultString($runtime->httpProxy, $this->_httpProxy),
            "httpsProxy"     => Utils::defaultString($runtime->httpsProxy, $this->_httpsProxy),
            "noProxy"        => Utils::defaultString($runtime->noProxy, $this->_noProxy),
            "socks5Proxy"    => Utils::defaultString($runtime->socks5Proxy, $this->_socks5Proxy),
            "socks5NetWork"  => Utils::defaultString($runtime->socks5NetWork, $this->_socks5NetWork),
            "maxIdleConns"   => Utils::defaultNumber($runtime->maxIdleConns, $this->_maxIdleConns),
            "retry"          => [
                "retryable"   => $runtime->autoretry,
                "maxAttempts" => Utils::defaultNumber($runtime->maxAttempts, 3)
            ],
            "backoff"        => [
                "policy" => Utils::defaultString($runtime->backoffPolicy, "no"),
                "period" => Utils::defaultNumber($runtime->backoffPeriod, 1)
            ],
            "ignoreSSL"      => $runtime->ignoreSSL
        ];
        $_lastRequest = null;
        $_now         = time();
        $_retryTimes  = 0;
        while (Tea::allowRetry($_runtime["retry"], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime($_runtime["backoff"], $_retryTimes);
                if ($_backoffTime > 0) {
                    Tea::sleep($_backoffTime);
                }
            }
            $_retryTimes = $_retryTimes + 1;
            try {
                $_request           = new Request();
                $ctx                = [];
                $accessKeyId        = $this->_credential->getAccessKeyId();
                $accessKeySecret    = $this->_credential->getAccessKeySecret();
                $token              = $this->_credential->getSecurityToken();
                $_request->protocol = $this->_protocol;
                $_request->method   = "PUT";
                $_request->pathname = "/" . $request->objectName . "";
                $_request->headers  = [
                    "host"       => OSSUtils::getHost($request->bucketName, $this->_regionId, $this->_endpoint, $this->_hostModel),
                    "date"       => Utils::getDateUTCString(),
                    "user-agent" => $this->getUserAgent()
                ];
                if (!Utils::_empty($token)) {
                    $_request->headers["x-oss-security-token"] = $token;
                }
                $_request->query                    = Utils::stringifyMapValue($request->filter);
                $_request->body                     = OSSUtils::inject($request->body, $ctx);
                $_request->headers["authorization"] = OSSUtils::getSignature($_request, $request->bucketName, $accessKeyId, $accessKeySecret, $this->_signatureVersion, $this->_addtionalHeaders);
                $_lastRequest                       = $_request;
                $_response                          = Tea::send($_request, $_runtime);
                $respMap                            = null;
                $bodyStr                            = null;
                if (Utils::is4xx($_response->statusCode) || Utils::is5xx($_response->statusCode)) {
                    $bodyStr = Utils::readAsString($_response->body);
                    $respMap = OSSUtils::getErrMessage($bodyStr);
                    throw new TeaError([
                        "code"    => $respMap["Code"],
                        "message" => $respMap["Message"],
                        "data"    => [
                            "httpCode"  => $_response->statusCode,
                            "requestId" => $respMap["RequestId"],
                            "hostId"    => $respMap["HostId"]
                        ]
                    ]);
                }
                if ($this->_isEnableCrc && !Utils::equalString($ctx["crc"], $_response->headers["x-oss-hash-crc64ecma"])) {
                    throw new TeaError([
                        "code" => "CrcNotMatched",
                        "data" => [
                            "clientCrc" => $ctx["crc"],
                            "serverCrc" => $_response->headers["x-oss-hash-crc64ecma"]
                        ]
                    ]);
                }
                if ($this->_isEnableMD5 && !Utils::equalString($ctx["md5"], $_response->headers["content-md5"])) {
                    throw new TeaError([
                        "code" => "MD5NotMatched",
                        "data" => [
                            "clientMD5" => $ctx["md5"],
                            "serverMD5" => $_response->headers["content-md5"]
                        ]
                    ]);
                }
                return $_response->headers;
            } catch (\Exception $e) {
                if (Tea::isRetryable($e)) {
                    continue;
                }
                throw $e;
            }
        }
        throw new TeaUnableRetryError($_lastRequest);
    }

    public function getBucketCORS(GetBucketCORSRequest $request, RuntimeOptions $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime     = [
            "timeouted"      => "retry",
            "readTimeout"    => Utils::defaultNumber($runtime->readTimeout, $this->_readTimeout),
            "connectTimeout" => Utils::defaultNumber($runtime->connectTimeout, $this->_connectTimeout),
            "localAddr"      => Utils::defaultString($runtime->localAddr, $this->_localAddr),
            "httpProxy"      => Utils::defaultString($runtime->httpProxy, $this->_httpProxy),
            "httpsProxy"     => Utils::defaultString($runtime->httpsProxy, $this->_httpsProxy),
            "noProxy"        => Utils::defaultString($runtime->noProxy, $this->_noProxy),
            "socks5Proxy"    => Utils::defaultString($runtime->socks5Proxy, $this->_socks5Proxy),
            "socks5NetWork"  => Utils::defaultString($runtime->socks5NetWork, $this->_socks5NetWork),
            "maxIdleConns"   => Utils::defaultNumber($runtime->maxIdleConns, $this->_maxIdleConns),
            "retry"          => [
                "retryable"   => $runtime->autoretry,
                "maxAttempts" => Utils::defaultNumber($runtime->maxAttempts, 3)
            ],
            "backoff"        => [
                "policy" => Utils::defaultString($runtime->backoffPolicy, "no"),
                "period" => Utils::defaultNumber($runtime->backoffPeriod, 1)
            ],
            "ignoreSSL"      => $runtime->ignoreSSL
        ];
        $_lastRequest = null;
        $_now         = time();
        $_retryTimes  = 0;
        while (Tea::allowRetry($_runtime["retry"], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime($_runtime["backoff"], $_retryTimes);
                if ($_backoffTime > 0) {
                    Tea::sleep($_backoffTime);
                }
            }
            $_retryTimes = $_retryTimes + 1;
            try {
                $_request           = new Request();
                $accessKeyId        = $this->_credential->getAccessKeyId();
                $accessKeySecret    = $this->_credential->getAccessKeySecret();
                $token              = $this->_credential->getSecurityToken();
                $_request->protocol = $this->_protocol;
                $_request->method   = "GET";
                $_request->pathname = "/?cors";
                $_request->headers  = [
                    "host"       => OSSUtils::getHost($request->bucketName, $this->_regionId, $this->_endpoint, $this->_hostModel),
                    "date"       => Utils::getDateUTCString(),
                    "user-agent" => $this->getUserAgent()
                ];
                if (!Utils::_empty($token)) {
                    $_request->headers["x-oss-security-token"] = $token;
                }
                $_request->headers["authorization"] = OSSUtils::getSignature($_request, $request->bucketName, $accessKeyId, $accessKeySecret, $this->_signatureVersion, $this->_addtionalHeaders);
                $_lastRequest                       = $_request;
                $_response                          = Tea::send($_request, $_runtime);
                $respMap                            = null;
                $bodyStr                            = null;
                if (Utils::is4xx($_response->statusCode) || Utils::is5xx($_response->statusCode)) {
                    $bodyStr = Utils::readAsString($_response->body);
                    $respMap = OSSUtils::getErrMessage($bodyStr);
                    throw new TeaError([
                        "code"    => $respMap["Code"],
                        "message" => $respMap["Message"],
                        "data"    => [
                            "httpCode"  => $_response->statusCode,
                            "requestId" => $respMap["RequestId"],
                            "hostId"    => $respMap["HostId"]
                        ]
                    ]);
                }
                $bodyStr = Utils::readAsString($_response->body);
                $respMap = XML::parseXml($bodyStr, GetBucketCORSResponse::class);
                return [
                    [
                        "CORSConfiguration" => $respMap["CORSConfiguration"],
                    ],
                    $_response->headers
                ];
            } catch (\Exception $e) {
                if (Tea::isRetryable($e)) {
                    continue;
                }
                throw $e;
            }
        }
        throw new TeaUnableRetryError($_lastRequest);
    }

    public function copyObject(CopyObjectRequest $request, RuntimeOptions $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime     = [
            "timeouted"      => "retry",
            "readTimeout"    => Utils::defaultNumber($runtime->readTimeout, $this->_readTimeout),
            "connectTimeout" => Utils::defaultNumber($runtime->connectTimeout, $this->_connectTimeout),
            "localAddr"      => Utils::defaultString($runtime->localAddr, $this->_localAddr),
            "httpProxy"      => Utils::defaultString($runtime->httpProxy, $this->_httpProxy),
            "httpsProxy"     => Utils::defaultString($runtime->httpsProxy, $this->_httpsProxy),
            "noProxy"        => Utils::defaultString($runtime->noProxy, $this->_noProxy),
            "socks5Proxy"    => Utils::defaultString($runtime->socks5Proxy, $this->_socks5Proxy),
            "socks5NetWork"  => Utils::defaultString($runtime->socks5NetWork, $this->_socks5NetWork),
            "maxIdleConns"   => Utils::defaultNumber($runtime->maxIdleConns, $this->_maxIdleConns),
            "retry"          => [
                "retryable"   => $runtime->autoretry,
                "maxAttempts" => Utils::defaultNumber($runtime->maxAttempts, 3)
            ],
            "backoff"        => [
                "policy" => Utils::defaultString($runtime->backoffPolicy, "no"),
                "period" => Utils::defaultNumber($runtime->backoffPeriod, 1)
            ],
            "ignoreSSL"      => $runtime->ignoreSSL
        ];
        $_lastRequest = null;
        $_now         = time();
        $_retryTimes  = 0;
        while (Tea::allowRetry($_runtime["retry"], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime($_runtime["backoff"], $_retryTimes);
                if ($_backoffTime > 0) {
                    Tea::sleep($_backoffTime);
                }
            }
            $_retryTimes = $_retryTimes + 1;
            try {
                $_request           = new Request();
                $accessKeyId        = $this->_credential->getAccessKeyId();
                $accessKeySecret    = $this->_credential->getAccessKeySecret();
                $token              = $this->_credential->getSecurityToken();
                $_request->protocol = $this->_protocol;
                $_request->method   = "PUT";
                $_request->pathname = "/" . $request->destObjectName . "";
                $_request->headers  = [
                    "host"       => OSSUtils::getHost($request->bucketName, $this->_regionId, $this->_endpoint, $this->_hostModel),
                    "date"       => Utils::getDateUTCString(),
                    "user-agent" => $this->getUserAgent(),
                    Utils::stringifyMapValue($request->header)
                ];
                if (!Utils::_empty($token)) {
                    $_request->headers["x-oss-security-token"] = $token;
                }
                $_request->headers["x-oss-copy-source"] = OSSUtils::encode($_request->headers["x-oss-copy-source"], "UrlEncode");
                $_request->headers["authorization"]     = OSSUtils::getSignature($_request, $request->bucketName, $accessKeyId, $accessKeySecret, $this->_signatureVersion, $this->_addtionalHeaders);
                $_lastRequest                           = $_request;
                $_response                              = Tea::send($_request, $_runtime);
                $respMap                                = null;
                $bodyStr                                = null;
                if (Utils::is4xx($_response->statusCode) || Utils::is5xx($_response->statusCode)) {
                    $bodyStr = Utils::readAsString($_response->body);
                    $respMap = OSSUtils::getErrMessage($bodyStr);
                    throw new TeaError([
                        "code"    => $respMap["Code"],
                        "message" => $respMap["Message"],
                        "data"    => [
                            "httpCode"  => $_response->statusCode,
                            "requestId" => $respMap["RequestId"],
                            "hostId"    => $respMap["HostId"]
                        ]
                    ]);
                }
                $bodyStr = Utils::readAsString($_response->body);
                $respMap = XML::parseXml($bodyStr, CopyObjectResponse::class);
                return [
                    [
                        "CopyObjectResult" => $respMap["CopyObjectResult"],
                    ],
                    $_response->headers
                ];
            } catch (\Exception $e) {
                if (Tea::isRetryable($e)) {
                    continue;
                }
                throw $e;
            }
        }
        throw new TeaUnableRetryError($_lastRequest);
    }

    public function getObjectTagging(GetObjectTaggingRequest $request, RuntimeOptions $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime     = [
            "timeouted"      => "retry",
            "readTimeout"    => Utils::defaultNumber($runtime->readTimeout, $this->_readTimeout),
            "connectTimeout" => Utils::defaultNumber($runtime->connectTimeout, $this->_connectTimeout),
            "localAddr"      => Utils::defaultString($runtime->localAddr, $this->_localAddr),
            "httpProxy"      => Utils::defaultString($runtime->httpProxy, $this->_httpProxy),
            "httpsProxy"     => Utils::defaultString($runtime->httpsProxy, $this->_httpsProxy),
            "noProxy"        => Utils::defaultString($runtime->noProxy, $this->_noProxy),
            "socks5Proxy"    => Utils::defaultString($runtime->socks5Proxy, $this->_socks5Proxy),
            "socks5NetWork"  => Utils::defaultString($runtime->socks5NetWork, $this->_socks5NetWork),
            "maxIdleConns"   => Utils::defaultNumber($runtime->maxIdleConns, $this->_maxIdleConns),
            "retry"          => [
                "retryable"   => $runtime->autoretry,
                "maxAttempts" => Utils::defaultNumber($runtime->maxAttempts, 3)
            ],
            "backoff"        => [
                "policy" => Utils::defaultString($runtime->backoffPolicy, "no"),
                "period" => Utils::defaultNumber($runtime->backoffPeriod, 1)
            ],
            "ignoreSSL"      => $runtime->ignoreSSL
        ];
        $_lastRequest = null;
        $_now         = time();
        $_retryTimes  = 0;
        while (Tea::allowRetry($_runtime["retry"], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime($_runtime["backoff"], $_retryTimes);
                if ($_backoffTime > 0) {
                    Tea::sleep($_backoffTime);
                }
            }
            $_retryTimes = $_retryTimes + 1;
            try {
                $_request           = new Request();
                $accessKeyId        = $this->_credential->getAccessKeyId();
                $accessKeySecret    = $this->_credential->getAccessKeySecret();
                $token              = $this->_credential->getSecurityToken();
                $_request->protocol = $this->_protocol;
                $_request->method   = "GET";
                $_request->pathname = "/" . $request->objectName . "?tagging";
                $_request->headers  = [
                    "host"       => OSSUtils::getHost($request->bucketName, $this->_regionId, $this->_endpoint, $this->_hostModel),
                    "date"       => Utils::getDateUTCString(),
                    "user-agent" => $this->getUserAgent()
                ];
                if (!Utils::_empty($token)) {
                    $_request->headers["x-oss-security-token"] = $token;
                }
                $_request->headers["authorization"] = OSSUtils::getSignature($_request, $request->bucketName, $accessKeyId, $accessKeySecret, $this->_signatureVersion, $this->_addtionalHeaders);
                $_lastRequest                       = $_request;
                $_response                          = Tea::send($_request, $_runtime);
                $respMap                            = null;
                $bodyStr                            = null;
                if (Utils::is4xx($_response->statusCode) || Utils::is5xx($_response->statusCode)) {
                    $bodyStr = Utils::readAsString($_response->body);
                    $respMap = OSSUtils::getErrMessage($bodyStr);
                    throw new TeaError([
                        "code"    => $respMap["Code"],
                        "message" => $respMap["Message"],
                        "data"    => [
                            "httpCode"  => $_response->statusCode,
                            "requestId" => $respMap["RequestId"],
                            "hostId"    => $respMap["HostId"]
                        ]
                    ]);
                }
                $bodyStr = Utils::readAsString($_response->body);
                $respMap = XML::parseXml($bodyStr, GetObjectTaggingResponse::class);
                return [
                    [
                        "Tagging" => $respMap["Tagging"],
                    ],
                    $_response->headers
                ];
            } catch (\Exception $e) {
                if (Tea::isRetryable($e)) {
                    continue;
                }
                throw $e;
            }
        }
        throw new TeaUnableRetryError($_lastRequest);
    }

    public function deleteBucketLifecycle(DeleteBucketLifecycleRequest $request, RuntimeOptions $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime     = [
            "timeouted"      => "retry",
            "readTimeout"    => Utils::defaultNumber($runtime->readTimeout, $this->_readTimeout),
            "connectTimeout" => Utils::defaultNumber($runtime->connectTimeout, $this->_connectTimeout),
            "localAddr"      => Utils::defaultString($runtime->localAddr, $this->_localAddr),
            "httpProxy"      => Utils::defaultString($runtime->httpProxy, $this->_httpProxy),
            "httpsProxy"     => Utils::defaultString($runtime->httpsProxy, $this->_httpsProxy),
            "noProxy"        => Utils::defaultString($runtime->noProxy, $this->_noProxy),
            "socks5Proxy"    => Utils::defaultString($runtime->socks5Proxy, $this->_socks5Proxy),
            "socks5NetWork"  => Utils::defaultString($runtime->socks5NetWork, $this->_socks5NetWork),
            "maxIdleConns"   => Utils::defaultNumber($runtime->maxIdleConns, $this->_maxIdleConns),
            "retry"          => [
                "retryable"   => $runtime->autoretry,
                "maxAttempts" => Utils::defaultNumber($runtime->maxAttempts, 3)
            ],
            "backoff"        => [
                "policy" => Utils::defaultString($runtime->backoffPolicy, "no"),
                "period" => Utils::defaultNumber($runtime->backoffPeriod, 1)
            ],
            "ignoreSSL"      => $runtime->ignoreSSL
        ];
        $_lastRequest = null;
        $_now         = time();
        $_retryTimes  = 0;
        while (Tea::allowRetry($_runtime["retry"], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime($_runtime["backoff"], $_retryTimes);
                if ($_backoffTime > 0) {
                    Tea::sleep($_backoffTime);
                }
            }
            $_retryTimes = $_retryTimes + 1;
            try {
                $_request           = new Request();
                $accessKeyId        = $this->_credential->getAccessKeyId();
                $accessKeySecret    = $this->_credential->getAccessKeySecret();
                $token              = $this->_credential->getSecurityToken();
                $_request->protocol = $this->_protocol;
                $_request->method   = "DELETE";
                $_request->pathname = "/?lifecycle";
                $_request->headers  = [
                    "host"       => OSSUtils::getHost($request->bucketName, $this->_regionId, $this->_endpoint, $this->_hostModel),
                    "date"       => Utils::getDateUTCString(),
                    "user-agent" => $this->getUserAgent()
                ];
                if (!Utils::_empty($token)) {
                    $_request->headers["x-oss-security-token"] = $token;
                }
                $_request->headers["authorization"] = OSSUtils::getSignature($_request, $request->bucketName, $accessKeyId, $accessKeySecret, $this->_signatureVersion, $this->_addtionalHeaders);
                $_lastRequest                       = $_request;
                $_response                          = Tea::send($_request, $_runtime);
                $respMap                            = null;
                $bodyStr                            = null;
                if (Utils::is4xx($_response->statusCode) || Utils::is5xx($_response->statusCode)) {
                    $bodyStr = Utils::readAsString($_response->body);
                    $respMap = OSSUtils::getErrMessage($bodyStr);
                    throw new TeaError([
                        "code"    => $respMap["Code"],
                        "message" => $respMap["Message"],
                        "data"    => [
                            "httpCode"  => $_response->statusCode,
                            "requestId" => $respMap["RequestId"],
                            "hostId"    => $respMap["HostId"]
                        ]
                    ]);
                }
                return $_response->headers;
            } catch (\Exception $e) {
                if (Tea::isRetryable($e)) {
                    continue;
                }
                throw $e;
            }
        }
        throw new TeaUnableRetryError($_lastRequest);
    }

    public function deleteBucketLogging(DeleteBucketLoggingRequest $request, RuntimeOptions $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime     = [
            "timeouted"      => "retry",
            "readTimeout"    => Utils::defaultNumber($runtime->readTimeout, $this->_readTimeout),
            "connectTimeout" => Utils::defaultNumber($runtime->connectTimeout, $this->_connectTimeout),
            "localAddr"      => Utils::defaultString($runtime->localAddr, $this->_localAddr),
            "httpProxy"      => Utils::defaultString($runtime->httpProxy, $this->_httpProxy),
            "httpsProxy"     => Utils::defaultString($runtime->httpsProxy, $this->_httpsProxy),
            "noProxy"        => Utils::defaultString($runtime->noProxy, $this->_noProxy),
            "socks5Proxy"    => Utils::defaultString($runtime->socks5Proxy, $this->_socks5Proxy),
            "socks5NetWork"  => Utils::defaultString($runtime->socks5NetWork, $this->_socks5NetWork),
            "maxIdleConns"   => Utils::defaultNumber($runtime->maxIdleConns, $this->_maxIdleConns),
            "retry"          => [
                "retryable"   => $runtime->autoretry,
                "maxAttempts" => Utils::defaultNumber($runtime->maxAttempts, 3)
            ],
            "backoff"        => [
                "policy" => Utils::defaultString($runtime->backoffPolicy, "no"),
                "period" => Utils::defaultNumber($runtime->backoffPeriod, 1)
            ],
            "ignoreSSL"      => $runtime->ignoreSSL
        ];
        $_lastRequest = null;
        $_now         = time();
        $_retryTimes  = 0;
        while (Tea::allowRetry($_runtime["retry"], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime($_runtime["backoff"], $_retryTimes);
                if ($_backoffTime > 0) {
                    Tea::sleep($_backoffTime);
                }
            }
            $_retryTimes = $_retryTimes + 1;
            try {
                $_request           = new Request();
                $accessKeyId        = $this->_credential->getAccessKeyId();
                $accessKeySecret    = $this->_credential->getAccessKeySecret();
                $token              = $this->_credential->getSecurityToken();
                $_request->protocol = $this->_protocol;
                $_request->method   = "DELETE";
                $_request->pathname = "/?logging";
                $_request->headers  = [
                    "host"       => OSSUtils::getHost($request->bucketName, $this->_regionId, $this->_endpoint, $this->_hostModel),
                    "date"       => Utils::getDateUTCString(),
                    "user-agent" => $this->getUserAgent()
                ];
                if (!Utils::_empty($token)) {
                    $_request->headers["x-oss-security-token"] = $token;
                }
                $_request->headers["authorization"] = OSSUtils::getSignature($_request, $request->bucketName, $accessKeyId, $accessKeySecret, $this->_signatureVersion, $this->_addtionalHeaders);
                $_lastRequest                       = $_request;
                $_response                          = Tea::send($_request, $_runtime);
                $respMap                            = null;
                $bodyStr                            = null;
                if (Utils::is4xx($_response->statusCode) || Utils::is5xx($_response->statusCode)) {
                    $bodyStr = Utils::readAsString($_response->body);
                    $respMap = OSSUtils::getErrMessage($bodyStr);
                    throw new TeaError([
                        "code"    => $respMap["Code"],
                        "message" => $respMap["Message"],
                        "data"    => [
                            "httpCode"  => $_response->statusCode,
                            "requestId" => $respMap["RequestId"],
                            "hostId"    => $respMap["HostId"]
                        ]
                    ]);
                }
                return $_response->headers;
            } catch (\Exception $e) {
                if (Tea::isRetryable($e)) {
                    continue;
                }
                throw $e;
            }
        }
        throw new TeaUnableRetryError($_lastRequest);
    }

    public function deleteBucketWebsite(DeleteBucketWebsiteRequest $request, RuntimeOptions $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime     = [
            "timeouted"      => "retry",
            "readTimeout"    => Utils::defaultNumber($runtime->readTimeout, $this->_readTimeout),
            "connectTimeout" => Utils::defaultNumber($runtime->connectTimeout, $this->_connectTimeout),
            "localAddr"      => Utils::defaultString($runtime->localAddr, $this->_localAddr),
            "httpProxy"      => Utils::defaultString($runtime->httpProxy, $this->_httpProxy),
            "httpsProxy"     => Utils::defaultString($runtime->httpsProxy, $this->_httpsProxy),
            "noProxy"        => Utils::defaultString($runtime->noProxy, $this->_noProxy),
            "socks5Proxy"    => Utils::defaultString($runtime->socks5Proxy, $this->_socks5Proxy),
            "socks5NetWork"  => Utils::defaultString($runtime->socks5NetWork, $this->_socks5NetWork),
            "maxIdleConns"   => Utils::defaultNumber($runtime->maxIdleConns, $this->_maxIdleConns),
            "retry"          => [
                "retryable"   => $runtime->autoretry,
                "maxAttempts" => Utils::defaultNumber($runtime->maxAttempts, 3)
            ],
            "backoff"        => [
                "policy" => Utils::defaultString($runtime->backoffPolicy, "no"),
                "period" => Utils::defaultNumber($runtime->backoffPeriod, 1)
            ],
            "ignoreSSL"      => $runtime->ignoreSSL
        ];
        $_lastRequest = null;
        $_now         = time();
        $_retryTimes  = 0;
        while (Tea::allowRetry($_runtime["retry"], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime($_runtime["backoff"], $_retryTimes);
                if ($_backoffTime > 0) {
                    Tea::sleep($_backoffTime);
                }
            }
            $_retryTimes = $_retryTimes + 1;
            try {
                $_request           = new Request();
                $accessKeyId        = $this->_credential->getAccessKeyId();
                $accessKeySecret    = $this->_credential->getAccessKeySecret();
                $token              = $this->_credential->getSecurityToken();
                $_request->protocol = $this->_protocol;
                $_request->method   = "DELETE";
                $_request->pathname = "/?website";
                $_request->headers  = [
                    "host"       => OSSUtils::getHost($request->bucketName, $this->_regionId, $this->_endpoint, $this->_hostModel),
                    "date"       => Utils::getDateUTCString(),
                    "user-agent" => $this->getUserAgent()
                ];
                if (!Utils::_empty($token)) {
                    $_request->headers["x-oss-security-token"] = $token;
                }
                $_request->headers["authorization"] = OSSUtils::getSignature($_request, $request->bucketName, $accessKeyId, $accessKeySecret, $this->_signatureVersion, $this->_addtionalHeaders);
                $_lastRequest                       = $_request;
                $_response                          = Tea::send($_request, $_runtime);
                $respMap                            = null;
                $bodyStr                            = null;
                if (Utils::is4xx($_response->statusCode) || Utils::is5xx($_response->statusCode)) {
                    $bodyStr = Utils::readAsString($_response->body);
                    $respMap = OSSUtils::getErrMessage($bodyStr);
                    throw new TeaError([
                        "code"    => $respMap["Code"],
                        "message" => $respMap["Message"],
                        "data"    => [
                            "httpCode"  => $_response->statusCode,
                            "requestId" => $respMap["RequestId"],
                            "hostId"    => $respMap["HostId"]
                        ]
                    ]);
                }
                return $_response->headers;
            } catch (\Exception $e) {
                if (Tea::isRetryable($e)) {
                    continue;
                }
                throw $e;
            }
        }
        throw new TeaUnableRetryError($_lastRequest);
    }

    public function getSymlink(GetSymlinkRequest $request, RuntimeOptions $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime     = [
            "timeouted"      => "retry",
            "readTimeout"    => Utils::defaultNumber($runtime->readTimeout, $this->_readTimeout),
            "connectTimeout" => Utils::defaultNumber($runtime->connectTimeout, $this->_connectTimeout),
            "localAddr"      => Utils::defaultString($runtime->localAddr, $this->_localAddr),
            "httpProxy"      => Utils::defaultString($runtime->httpProxy, $this->_httpProxy),
            "httpsProxy"     => Utils::defaultString($runtime->httpsProxy, $this->_httpsProxy),
            "noProxy"        => Utils::defaultString($runtime->noProxy, $this->_noProxy),
            "socks5Proxy"    => Utils::defaultString($runtime->socks5Proxy, $this->_socks5Proxy),
            "socks5NetWork"  => Utils::defaultString($runtime->socks5NetWork, $this->_socks5NetWork),
            "maxIdleConns"   => Utils::defaultNumber($runtime->maxIdleConns, $this->_maxIdleConns),
            "retry"          => [
                "retryable"   => $runtime->autoretry,
                "maxAttempts" => Utils::defaultNumber($runtime->maxAttempts, 3)
            ],
            "backoff"        => [
                "policy" => Utils::defaultString($runtime->backoffPolicy, "no"),
                "period" => Utils::defaultNumber($runtime->backoffPeriod, 1)
            ],
            "ignoreSSL"      => $runtime->ignoreSSL
        ];
        $_lastRequest = null;
        $_now         = time();
        $_retryTimes  = 0;
        while (Tea::allowRetry($_runtime["retry"], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime($_runtime["backoff"], $_retryTimes);
                if ($_backoffTime > 0) {
                    Tea::sleep($_backoffTime);
                }
            }
            $_retryTimes = $_retryTimes + 1;
            try {
                $_request           = new Request();
                $accessKeyId        = $this->_credential->getAccessKeyId();
                $accessKeySecret    = $this->_credential->getAccessKeySecret();
                $token              = $this->_credential->getSecurityToken();
                $_request->protocol = $this->_protocol;
                $_request->method   = "GET";
                $_request->pathname = "/" . $request->objectName . "?symlink";
                $_request->headers  = [
                    "host"       => OSSUtils::getHost($request->bucketName, $this->_regionId, $this->_endpoint, $this->_hostModel),
                    "date"       => Utils::getDateUTCString(),
                    "user-agent" => $this->getUserAgent()
                ];
                if (!Utils::_empty($token)) {
                    $_request->headers["x-oss-security-token"] = $token;
                }
                $_request->headers["authorization"] = OSSUtils::getSignature($_request, $request->bucketName, $accessKeyId, $accessKeySecret, $this->_signatureVersion, $this->_addtionalHeaders);
                $_lastRequest                       = $_request;
                $_response                          = Tea::send($_request, $_runtime);
                $respMap                            = null;
                $bodyStr                            = null;
                if (Utils::is4xx($_response->statusCode) || Utils::is5xx($_response->statusCode)) {
                    $bodyStr = Utils::readAsString($_response->body);
                    $respMap = OSSUtils::getErrMessage($bodyStr);
                    throw new TeaError([
                        "code"    => $respMap["Code"],
                        "message" => $respMap["Message"],
                        "data"    => [
                            "httpCode"  => $_response->statusCode,
                            "requestId" => $respMap["RequestId"],
                            "hostId"    => $respMap["HostId"]
                        ]
                    ]);
                }
                return $_response->headers;
            } catch (\Exception $e) {
                if (Tea::isRetryable($e)) {
                    continue;
                }
                throw $e;
            }
        }
        throw new TeaUnableRetryError($_lastRequest);
    }

    public function getBucketLifecycle(GetBucketLifecycleRequest $request, RuntimeOptions $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime     = [
            "timeouted"      => "retry",
            "readTimeout"    => Utils::defaultNumber($runtime->readTimeout, $this->_readTimeout),
            "connectTimeout" => Utils::defaultNumber($runtime->connectTimeout, $this->_connectTimeout),
            "localAddr"      => Utils::defaultString($runtime->localAddr, $this->_localAddr),
            "httpProxy"      => Utils::defaultString($runtime->httpProxy, $this->_httpProxy),
            "httpsProxy"     => Utils::defaultString($runtime->httpsProxy, $this->_httpsProxy),
            "noProxy"        => Utils::defaultString($runtime->noProxy, $this->_noProxy),
            "socks5Proxy"    => Utils::defaultString($runtime->socks5Proxy, $this->_socks5Proxy),
            "socks5NetWork"  => Utils::defaultString($runtime->socks5NetWork, $this->_socks5NetWork),
            "maxIdleConns"   => Utils::defaultNumber($runtime->maxIdleConns, $this->_maxIdleConns),
            "retry"          => [
                "retryable"   => $runtime->autoretry,
                "maxAttempts" => Utils::defaultNumber($runtime->maxAttempts, 3)
            ],
            "backoff"        => [
                "policy" => Utils::defaultString($runtime->backoffPolicy, "no"),
                "period" => Utils::defaultNumber($runtime->backoffPeriod, 1)
            ],
            "ignoreSSL"      => $runtime->ignoreSSL
        ];
        $_lastRequest = null;
        $_now         = time();
        $_retryTimes  = 0;
        while (Tea::allowRetry($_runtime["retry"], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime($_runtime["backoff"], $_retryTimes);
                if ($_backoffTime > 0) {
                    Tea::sleep($_backoffTime);
                }
            }
            $_retryTimes = $_retryTimes + 1;
            try {
                $_request           = new Request();
                $accessKeyId        = $this->_credential->getAccessKeyId();
                $accessKeySecret    = $this->_credential->getAccessKeySecret();
                $token              = $this->_credential->getSecurityToken();
                $_request->protocol = $this->_protocol;
                $_request->method   = "GET";
                $_request->pathname = "/?lifecycle";
                $_request->headers  = [
                    "host"       => OSSUtils::getHost($request->bucketName, $this->_regionId, $this->_endpoint, $this->_hostModel),
                    "date"       => Utils::getDateUTCString(),
                    "user-agent" => $this->getUserAgent()
                ];
                if (!Utils::_empty($token)) {
                    $_request->headers["x-oss-security-token"] = $token;
                }
                $_request->headers["authorization"] = OSSUtils::getSignature($_request, $request->bucketName, $accessKeyId, $accessKeySecret, $this->_signatureVersion, $this->_addtionalHeaders);
                $_lastRequest                       = $_request;
                $_response                          = Tea::send($_request, $_runtime);
                $respMap                            = null;
                $bodyStr                            = null;
                if (Utils::is4xx($_response->statusCode) || Utils::is5xx($_response->statusCode)) {
                    $bodyStr = Utils::readAsString($_response->body);
                    $respMap = OSSUtils::getErrMessage($bodyStr);
                    throw new TeaError([
                        "code"    => $respMap["Code"],
                        "message" => $respMap["Message"],
                        "data"    => [
                            "httpCode"  => $_response->statusCode,
                            "requestId" => $respMap["RequestId"],
                            "hostId"    => $respMap["HostId"]
                        ]
                    ]);
                }
                $bodyStr = Utils::readAsString($_response->body);
                $respMap = XML::parseXml($bodyStr, GetBucketLifecycleResponse::class);
                return [
                    [
                        "LifecycleConfiguration" => $respMap["LifecycleConfiguration"],
                    ],
                    $_response->headers
                ];
            } catch (\Exception $e) {
                if (Tea::isRetryable($e)) {
                    continue;
                }
                throw $e;
            }
        }
        throw new TeaUnableRetryError($_lastRequest);
    }

    public function putSymlink(PutSymlinkRequest $request, RuntimeOptions $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime     = [
            "timeouted"      => "retry",
            "readTimeout"    => Utils::defaultNumber($runtime->readTimeout, $this->_readTimeout),
            "connectTimeout" => Utils::defaultNumber($runtime->connectTimeout, $this->_connectTimeout),
            "localAddr"      => Utils::defaultString($runtime->localAddr, $this->_localAddr),
            "httpProxy"      => Utils::defaultString($runtime->httpProxy, $this->_httpProxy),
            "httpsProxy"     => Utils::defaultString($runtime->httpsProxy, $this->_httpsProxy),
            "noProxy"        => Utils::defaultString($runtime->noProxy, $this->_noProxy),
            "socks5Proxy"    => Utils::defaultString($runtime->socks5Proxy, $this->_socks5Proxy),
            "socks5NetWork"  => Utils::defaultString($runtime->socks5NetWork, $this->_socks5NetWork),
            "maxIdleConns"   => Utils::defaultNumber($runtime->maxIdleConns, $this->_maxIdleConns),
            "retry"          => [
                "retryable"   => $runtime->autoretry,
                "maxAttempts" => Utils::defaultNumber($runtime->maxAttempts, 3)
            ],
            "backoff"        => [
                "policy" => Utils::defaultString($runtime->backoffPolicy, "no"),
                "period" => Utils::defaultNumber($runtime->backoffPeriod, 1)
            ],
            "ignoreSSL"      => $runtime->ignoreSSL
        ];
        $_lastRequest = null;
        $_now         = time();
        $_retryTimes  = 0;
        while (Tea::allowRetry($_runtime["retry"], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime($_runtime["backoff"], $_retryTimes);
                if ($_backoffTime > 0) {
                    Tea::sleep($_backoffTime);
                }
            }
            $_retryTimes = $_retryTimes + 1;
            try {
                $_request           = new Request();
                $accessKeyId        = $this->_credential->getAccessKeyId();
                $accessKeySecret    = $this->_credential->getAccessKeySecret();
                $token              = $this->_credential->getSecurityToken();
                $_request->protocol = $this->_protocol;
                $_request->method   = "PUT";
                $_request->pathname = "/" . $request->objectName . "?symlink";
                $_request->headers  = [
                    "host"       => OSSUtils::getHost($request->bucketName, $this->_regionId, $this->_endpoint, $this->_hostModel),
                    "date"       => Utils::getDateUTCString(),
                    "user-agent" => $this->getUserAgent(),
                    Utils::stringifyMapValue($request->header)
                ];
                if (!Utils::_empty($token)) {
                    $_request->headers["x-oss-security-token"] = $token;
                }
                $_request->headers["authorization"] = OSSUtils::getSignature($_request, $request->bucketName, $accessKeyId, $accessKeySecret, $this->_signatureVersion, $this->_addtionalHeaders);
                $_lastRequest                       = $_request;
                $_response                          = Tea::send($_request, $_runtime);
                $respMap                            = null;
                $bodyStr                            = null;
                if (Utils::is4xx($_response->statusCode) || Utils::is5xx($_response->statusCode)) {
                    $bodyStr = Utils::readAsString($_response->body);
                    $respMap = OSSUtils::getErrMessage($bodyStr);
                    throw new TeaError([
                        "code"    => $respMap["Code"],
                        "message" => $respMap["Message"],
                        "data"    => [
                            "httpCode"  => $_response->statusCode,
                            "requestId" => $respMap["RequestId"],
                            "hostId"    => $respMap["HostId"]
                        ]
                    ]);
                }
                return $_response->headers;
            } catch (\Exception $e) {
                if (Tea::isRetryable($e)) {
                    continue;
                }
                throw $e;
            }
        }
        throw new TeaUnableRetryError($_lastRequest);
    }

    public function getBucketReferer(GetBucketRefererRequest $request, RuntimeOptions $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime     = [
            "timeouted"      => "retry",
            "readTimeout"    => Utils::defaultNumber($runtime->readTimeout, $this->_readTimeout),
            "connectTimeout" => Utils::defaultNumber($runtime->connectTimeout, $this->_connectTimeout),
            "localAddr"      => Utils::defaultString($runtime->localAddr, $this->_localAddr),
            "httpProxy"      => Utils::defaultString($runtime->httpProxy, $this->_httpProxy),
            "httpsProxy"     => Utils::defaultString($runtime->httpsProxy, $this->_httpsProxy),
            "noProxy"        => Utils::defaultString($runtime->noProxy, $this->_noProxy),
            "socks5Proxy"    => Utils::defaultString($runtime->socks5Proxy, $this->_socks5Proxy),
            "socks5NetWork"  => Utils::defaultString($runtime->socks5NetWork, $this->_socks5NetWork),
            "maxIdleConns"   => Utils::defaultNumber($runtime->maxIdleConns, $this->_maxIdleConns),
            "retry"          => [
                "retryable"   => $runtime->autoretry,
                "maxAttempts" => Utils::defaultNumber($runtime->maxAttempts, 3)
            ],
            "backoff"        => [
                "policy" => Utils::defaultString($runtime->backoffPolicy, "no"),
                "period" => Utils::defaultNumber($runtime->backoffPeriod, 1)
            ],
            "ignoreSSL"      => $runtime->ignoreSSL
        ];
        $_lastRequest = null;
        $_now         = time();
        $_retryTimes  = 0;
        while (Tea::allowRetry($_runtime["retry"], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime($_runtime["backoff"], $_retryTimes);
                if ($_backoffTime > 0) {
                    Tea::sleep($_backoffTime);
                }
            }
            $_retryTimes = $_retryTimes + 1;
            try {
                $_request           = new Request();
                $accessKeyId        = $this->_credential->getAccessKeyId();
                $accessKeySecret    = $this->_credential->getAccessKeySecret();
                $token              = $this->_credential->getSecurityToken();
                $_request->protocol = $this->_protocol;
                $_request->method   = "GET";
                $_request->pathname = "/?referer";
                $_request->headers  = [
                    "host"       => OSSUtils::getHost($request->bucketName, $this->_regionId, $this->_endpoint, $this->_hostModel),
                    "date"       => Utils::getDateUTCString(),
                    "user-agent" => $this->getUserAgent()
                ];
                if (!Utils::_empty($token)) {
                    $_request->headers["x-oss-security-token"] = $token;
                }
                $_request->headers["authorization"] = OSSUtils::getSignature($_request, $request->bucketName, $accessKeyId, $accessKeySecret, $this->_signatureVersion, $this->_addtionalHeaders);
                $_lastRequest                       = $_request;
                $_response                          = Tea::send($_request, $_runtime);
                $respMap                            = null;
                $bodyStr                            = null;
                if (Utils::is4xx($_response->statusCode) || Utils::is5xx($_response->statusCode)) {
                    $bodyStr = Utils::readAsString($_response->body);
                    $respMap = OSSUtils::getErrMessage($bodyStr);
                    throw new TeaError([
                        "code"    => $respMap["Code"],
                        "message" => $respMap["Message"],
                        "data"    => [
                            "httpCode"  => $_response->statusCode,
                            "requestId" => $respMap["RequestId"],
                            "hostId"    => $respMap["HostId"]
                        ]
                    ]);
                }
                $bodyStr = Utils::readAsString($_response->body);
                $respMap = XML::parseXml($bodyStr, GetBucketRefererResponse::class);
                return [
                    [
                        "RefererConfiguration" => $respMap["RefererConfiguration"],
                    ],
                    $_response->headers
                ];
            } catch (\Exception $e) {
                if (Tea::isRetryable($e)) {
                    continue;
                }
                throw $e;
            }
        }
        throw new TeaUnableRetryError($_lastRequest);
    }

    public function callback(CallbackRequest $request, RuntimeOptions $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime     = [
            "timeouted"      => "retry",
            "readTimeout"    => Utils::defaultNumber($runtime->readTimeout, $this->_readTimeout),
            "connectTimeout" => Utils::defaultNumber($runtime->connectTimeout, $this->_connectTimeout),
            "localAddr"      => Utils::defaultString($runtime->localAddr, $this->_localAddr),
            "httpProxy"      => Utils::defaultString($runtime->httpProxy, $this->_httpProxy),
            "httpsProxy"     => Utils::defaultString($runtime->httpsProxy, $this->_httpsProxy),
            "noProxy"        => Utils::defaultString($runtime->noProxy, $this->_noProxy),
            "socks5Proxy"    => Utils::defaultString($runtime->socks5Proxy, $this->_socks5Proxy),
            "socks5NetWork"  => Utils::defaultString($runtime->socks5NetWork, $this->_socks5NetWork),
            "maxIdleConns"   => Utils::defaultNumber($runtime->maxIdleConns, $this->_maxIdleConns),
            "retry"          => [
                "retryable"   => $runtime->autoretry,
                "maxAttempts" => Utils::defaultNumber($runtime->maxAttempts, 3)
            ],
            "backoff"        => [
                "policy" => Utils::defaultString($runtime->backoffPolicy, "no"),
                "period" => Utils::defaultNumber($runtime->backoffPeriod, 1)
            ],
            "ignoreSSL"      => $runtime->ignoreSSL
        ];
        $_lastRequest = null;
        $_now         = time();
        $_retryTimes  = 0;
        while (Tea::allowRetry($_runtime["retry"], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime($_runtime["backoff"], $_retryTimes);
                if ($_backoffTime > 0) {
                    Tea::sleep($_backoffTime);
                }
            }
            $_retryTimes = $_retryTimes + 1;
            try {
                $_request           = new Request();
                $accessKeyId        = $this->_credential->getAccessKeyId();
                $accessKeySecret    = $this->_credential->getAccessKeySecret();
                $token              = $this->_credential->getSecurityToken();
                $_request->protocol = $this->_protocol;
                $_request->method   = "GET";
                $_request->pathname = "/";
                $_request->headers  = [
                    "host"       => OSSUtils::getHost($request->bucketName, $this->_regionId, $this->_endpoint, $this->_hostModel),
                    "date"       => Utils::getDateUTCString(),
                    "user-agent" => $this->getUserAgent()
                ];
                if (!Utils::_empty($token)) {
                    $_request->headers["x-oss-security-token"] = $token;
                }
                $_request->headers["authorization"] = OSSUtils::getSignature($_request, $request->bucketName, $accessKeyId, $accessKeySecret, $this->_signatureVersion, $this->_addtionalHeaders);
                $_lastRequest                       = $_request;
                $_response                          = Tea::send($_request, $_runtime);
                $respMap                            = null;
                $bodyStr                            = null;
                if (Utils::is4xx($_response->statusCode) || Utils::is5xx($_response->statusCode)) {
                    $bodyStr = Utils::readAsString($_response->body);
                    $respMap = OSSUtils::getErrMessage($bodyStr);
                    throw new TeaError([
                        "code"    => $respMap["Code"],
                        "message" => $respMap["Message"],
                        "data"    => [
                            "httpCode"  => $_response->statusCode,
                            "requestId" => $respMap["RequestId"],
                            "hostId"    => $respMap["HostId"]
                        ]
                    ]);
                }
                return $_response->headers;
            } catch (\Exception $e) {
                if (Tea::isRetryable($e)) {
                    continue;
                }
                throw $e;
            }
        }
        throw new TeaUnableRetryError($_lastRequest);
    }

    public function getBucketLogging(GetBucketLoggingRequest $request, RuntimeOptions $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime     = [
            "timeouted"      => "retry",
            "readTimeout"    => Utils::defaultNumber($runtime->readTimeout, $this->_readTimeout),
            "connectTimeout" => Utils::defaultNumber($runtime->connectTimeout, $this->_connectTimeout),
            "localAddr"      => Utils::defaultString($runtime->localAddr, $this->_localAddr),
            "httpProxy"      => Utils::defaultString($runtime->httpProxy, $this->_httpProxy),
            "httpsProxy"     => Utils::defaultString($runtime->httpsProxy, $this->_httpsProxy),
            "noProxy"        => Utils::defaultString($runtime->noProxy, $this->_noProxy),
            "socks5Proxy"    => Utils::defaultString($runtime->socks5Proxy, $this->_socks5Proxy),
            "socks5NetWork"  => Utils::defaultString($runtime->socks5NetWork, $this->_socks5NetWork),
            "maxIdleConns"   => Utils::defaultNumber($runtime->maxIdleConns, $this->_maxIdleConns),
            "retry"          => [
                "retryable"   => $runtime->autoretry,
                "maxAttempts" => Utils::defaultNumber($runtime->maxAttempts, 3)
            ],
            "backoff"        => [
                "policy" => Utils::defaultString($runtime->backoffPolicy, "no"),
                "period" => Utils::defaultNumber($runtime->backoffPeriod, 1)
            ],
            "ignoreSSL"      => $runtime->ignoreSSL
        ];
        $_lastRequest = null;
        $_now         = time();
        $_retryTimes  = 0;
        while (Tea::allowRetry($_runtime["retry"], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime($_runtime["backoff"], $_retryTimes);
                if ($_backoffTime > 0) {
                    Tea::sleep($_backoffTime);
                }
            }
            $_retryTimes = $_retryTimes + 1;
            try {
                $_request           = new Request();
                $accessKeyId        = $this->_credential->getAccessKeyId();
                $accessKeySecret    = $this->_credential->getAccessKeySecret();
                $token              = $this->_credential->getSecurityToken();
                $_request->protocol = $this->_protocol;
                $_request->method   = "GET";
                $_request->pathname = "/?logging";
                $_request->headers  = [
                    "host"       => OSSUtils::getHost($request->bucketName, $this->_regionId, $this->_endpoint, $this->_hostModel),
                    "date"       => Utils::getDateUTCString(),
                    "user-agent" => $this->getUserAgent()
                ];
                if (!Utils::_empty($token)) {
                    $_request->headers["x-oss-security-token"] = $token;
                }
                $_request->headers["authorization"] = OSSUtils::getSignature($_request, $request->bucketName, $accessKeyId, $accessKeySecret, $this->_signatureVersion, $this->_addtionalHeaders);
                $_lastRequest                       = $_request;
                $_response                          = Tea::send($_request, $_runtime);
                $respMap                            = null;
                $bodyStr                            = null;
                if (Utils::is4xx($_response->statusCode) || Utils::is5xx($_response->statusCode)) {
                    $bodyStr = Utils::readAsString($_response->body);
                    $respMap = OSSUtils::getErrMessage($bodyStr);
                    throw new TeaError([
                        "code"    => $respMap["Code"],
                        "message" => $respMap["Message"],
                        "data"    => [
                            "httpCode"  => $_response->statusCode,
                            "requestId" => $respMap["RequestId"],
                            "hostId"    => $respMap["HostId"]
                        ]
                    ]);
                }
                $bodyStr = Utils::readAsString($_response->body);
                $respMap = XML::parseXml($bodyStr, GetBucketLoggingResponse::class);
                return [
                    [
                        "BucketLoggingStatus" => $respMap["BucketLoggingStatus"],
                    ],
                    $_response->headers
                ];
            } catch (\Exception $e) {
                if (Tea::isRetryable($e)) {
                    continue;
                }
                throw $e;
            }
        }
        throw new TeaUnableRetryError($_lastRequest);
    }

    public function putObjectAcl(PutObjectAclRequest $request, RuntimeOptions $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime     = [
            "timeouted"      => "retry",
            "readTimeout"    => Utils::defaultNumber($runtime->readTimeout, $this->_readTimeout),
            "connectTimeout" => Utils::defaultNumber($runtime->connectTimeout, $this->_connectTimeout),
            "localAddr"      => Utils::defaultString($runtime->localAddr, $this->_localAddr),
            "httpProxy"      => Utils::defaultString($runtime->httpProxy, $this->_httpProxy),
            "httpsProxy"     => Utils::defaultString($runtime->httpsProxy, $this->_httpsProxy),
            "noProxy"        => Utils::defaultString($runtime->noProxy, $this->_noProxy),
            "socks5Proxy"    => Utils::defaultString($runtime->socks5Proxy, $this->_socks5Proxy),
            "socks5NetWork"  => Utils::defaultString($runtime->socks5NetWork, $this->_socks5NetWork),
            "maxIdleConns"   => Utils::defaultNumber($runtime->maxIdleConns, $this->_maxIdleConns),
            "retry"          => [
                "retryable"   => $runtime->autoretry,
                "maxAttempts" => Utils::defaultNumber($runtime->maxAttempts, 3)
            ],
            "backoff"        => [
                "policy" => Utils::defaultString($runtime->backoffPolicy, "no"),
                "period" => Utils::defaultNumber($runtime->backoffPeriod, 1)
            ],
            "ignoreSSL"      => $runtime->ignoreSSL
        ];
        $_lastRequest = null;
        $_now         = time();
        $_retryTimes  = 0;
        while (Tea::allowRetry($_runtime["retry"], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime($_runtime["backoff"], $_retryTimes);
                if ($_backoffTime > 0) {
                    Tea::sleep($_backoffTime);
                }
            }
            $_retryTimes = $_retryTimes + 1;
            try {
                $_request           = new Request();
                $accessKeyId        = $this->_credential->getAccessKeyId();
                $accessKeySecret    = $this->_credential->getAccessKeySecret();
                $token              = $this->_credential->getSecurityToken();
                $_request->protocol = $this->_protocol;
                $_request->method   = "PUT";
                $_request->pathname = "/" . $request->objectName . "?acl";
                $_request->headers  = [
                    "host"       => OSSUtils::getHost($request->bucketName, $this->_regionId, $this->_endpoint, $this->_hostModel),
                    "date"       => Utils::getDateUTCString(),
                    "user-agent" => $this->getUserAgent(),
                    Utils::stringifyMapValue($request->header)
                ];
                if (!Utils::_empty($token)) {
                    $_request->headers["x-oss-security-token"] = $token;
                }
                $_request->headers["authorization"] = OSSUtils::getSignature($_request, $request->bucketName, $accessKeyId, $accessKeySecret, $this->_signatureVersion, $this->_addtionalHeaders);
                $_lastRequest                       = $_request;
                $_response                          = Tea::send($_request, $_runtime);
                $respMap                            = null;
                $bodyStr                            = null;
                if (Utils::is4xx($_response->statusCode) || Utils::is5xx($_response->statusCode)) {
                    $bodyStr = Utils::readAsString($_response->body);
                    $respMap = OSSUtils::getErrMessage($bodyStr);
                    throw new TeaError([
                        "code"    => $respMap["Code"],
                        "message" => $respMap["Message"],
                        "data"    => [
                            "httpCode"  => $_response->statusCode,
                            "requestId" => $respMap["RequestId"],
                            "hostId"    => $respMap["HostId"]
                        ]
                    ]);
                }
                return $_response->headers;
            } catch (\Exception $e) {
                if (Tea::isRetryable($e)) {
                    continue;
                }
                throw $e;
            }
        }
        throw new TeaUnableRetryError($_lastRequest);
    }

    public function getBucketInfo(GetBucketInfoRequest $request, RuntimeOptions $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime     = [
            "timeouted"      => "retry",
            "readTimeout"    => Utils::defaultNumber($runtime->readTimeout, $this->_readTimeout),
            "connectTimeout" => Utils::defaultNumber($runtime->connectTimeout, $this->_connectTimeout),
            "localAddr"      => Utils::defaultString($runtime->localAddr, $this->_localAddr),
            "httpProxy"      => Utils::defaultString($runtime->httpProxy, $this->_httpProxy),
            "httpsProxy"     => Utils::defaultString($runtime->httpsProxy, $this->_httpsProxy),
            "noProxy"        => Utils::defaultString($runtime->noProxy, $this->_noProxy),
            "socks5Proxy"    => Utils::defaultString($runtime->socks5Proxy, $this->_socks5Proxy),
            "socks5NetWork"  => Utils::defaultString($runtime->socks5NetWork, $this->_socks5NetWork),
            "maxIdleConns"   => Utils::defaultNumber($runtime->maxIdleConns, $this->_maxIdleConns),
            "retry"          => [
                "retryable"   => $runtime->autoretry,
                "maxAttempts" => Utils::defaultNumber($runtime->maxAttempts, 3)
            ],
            "backoff"        => [
                "policy" => Utils::defaultString($runtime->backoffPolicy, "no"),
                "period" => Utils::defaultNumber($runtime->backoffPeriod, 1)
            ],
            "ignoreSSL"      => $runtime->ignoreSSL
        ];
        $_lastRequest = null;
        $_now         = time();
        $_retryTimes  = 0;
        while (Tea::allowRetry($_runtime["retry"], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime($_runtime["backoff"], $_retryTimes);
                if ($_backoffTime > 0) {
                    Tea::sleep($_backoffTime);
                }
            }
            $_retryTimes = $_retryTimes + 1;
            try {
                $_request           = new Request();
                $accessKeyId        = $this->_credential->getAccessKeyId();
                $accessKeySecret    = $this->_credential->getAccessKeySecret();
                $token              = $this->_credential->getSecurityToken();
                $_request->protocol = $this->_protocol;
                $_request->method   = "GET";
                $_request->pathname = "/?bucketInfo";
                $_request->headers  = [
                    "host"       => OSSUtils::getHost($request->bucketName, $this->_regionId, $this->_endpoint, $this->_hostModel),
                    "date"       => Utils::getDateUTCString(),
                    "user-agent" => $this->getUserAgent()
                ];
                if (!Utils::_empty($token)) {
                    $_request->headers["x-oss-security-token"] = $token;
                }
                $_request->headers["authorization"] = OSSUtils::getSignature($_request, $request->bucketName, $accessKeyId, $accessKeySecret, $this->_signatureVersion, $this->_addtionalHeaders);
                $_lastRequest                       = $_request;
                $_response                          = Tea::send($_request, $_runtime);
                $respMap                            = null;
                $bodyStr                            = null;
                if (Utils::is4xx($_response->statusCode) || Utils::is5xx($_response->statusCode)) {
                    $bodyStr = Utils::readAsString($_response->body);
                    $respMap = OSSUtils::getErrMessage($bodyStr);
                    throw new TeaError([
                        "code"    => $respMap["Code"],
                        "message" => $respMap["Message"],
                        "data"    => [
                            "httpCode"  => $_response->statusCode,
                            "requestId" => $respMap["RequestId"],
                            "hostId"    => $respMap["HostId"]
                        ]
                    ]);
                }
                $bodyStr = Utils::readAsString($_response->body);
                $respMap = XML::parseXml($bodyStr, GetBucketInfoResponse::class);
                return [
                    [
                        "BucketInfo" => $respMap["BucketInfo"],
                    ],
                    $_response->headers
                ];
            } catch (\Exception $e) {
                if (Tea::isRetryable($e)) {
                    continue;
                }
                throw $e;
            }
        }
        throw new TeaUnableRetryError($_lastRequest);
    }

    public function putLiveChannelStatus(PutLiveChannelStatusRequest $request, RuntimeOptions $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime     = [
            "timeouted"      => "retry",
            "readTimeout"    => Utils::defaultNumber($runtime->readTimeout, $this->_readTimeout),
            "connectTimeout" => Utils::defaultNumber($runtime->connectTimeout, $this->_connectTimeout),
            "localAddr"      => Utils::defaultString($runtime->localAddr, $this->_localAddr),
            "httpProxy"      => Utils::defaultString($runtime->httpProxy, $this->_httpProxy),
            "httpsProxy"     => Utils::defaultString($runtime->httpsProxy, $this->_httpsProxy),
            "noProxy"        => Utils::defaultString($runtime->noProxy, $this->_noProxy),
            "socks5Proxy"    => Utils::defaultString($runtime->socks5Proxy, $this->_socks5Proxy),
            "socks5NetWork"  => Utils::defaultString($runtime->socks5NetWork, $this->_socks5NetWork),
            "maxIdleConns"   => Utils::defaultNumber($runtime->maxIdleConns, $this->_maxIdleConns),
            "retry"          => [
                "retryable"   => $runtime->autoretry,
                "maxAttempts" => Utils::defaultNumber($runtime->maxAttempts, 3)
            ],
            "backoff"        => [
                "policy" => Utils::defaultString($runtime->backoffPolicy, "no"),
                "period" => Utils::defaultNumber($runtime->backoffPeriod, 1)
            ],
            "ignoreSSL"      => $runtime->ignoreSSL
        ];
        $_lastRequest = null;
        $_now         = time();
        $_retryTimes  = 0;
        while (Tea::allowRetry($_runtime["retry"], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime($_runtime["backoff"], $_retryTimes);
                if ($_backoffTime > 0) {
                    Tea::sleep($_backoffTime);
                }
            }
            $_retryTimes = $_retryTimes + 1;
            try {
                $_request           = new Request();
                $accessKeyId        = $this->_credential->getAccessKeyId();
                $accessKeySecret    = $this->_credential->getAccessKeySecret();
                $token              = $this->_credential->getSecurityToken();
                $_request->protocol = $this->_protocol;
                $_request->method   = "PUT";
                $_request->pathname = "/" . $request->channelName . "?live";
                $_request->headers  = [
                    "host"       => OSSUtils::getHost($request->bucketName, $this->_regionId, $this->_endpoint, $this->_hostModel),
                    "date"       => Utils::getDateUTCString(),
                    "user-agent" => $this->getUserAgent()
                ];
                if (!Utils::_empty($token)) {
                    $_request->headers["x-oss-security-token"] = $token;
                }
                $_request->query                    = Utils::stringifyMapValue($request->filter);
                $_request->headers["authorization"] = OSSUtils::getSignature($_request, $request->bucketName, $accessKeyId, $accessKeySecret, $this->_signatureVersion, $this->_addtionalHeaders);
                $_lastRequest                       = $_request;
                $_response                          = Tea::send($_request, $_runtime);
                $respMap                            = null;
                $bodyStr                            = null;
                if (Utils::is4xx($_response->statusCode) || Utils::is5xx($_response->statusCode)) {
                    $bodyStr = Utils::readAsString($_response->body);
                    $respMap = OSSUtils::getErrMessage($bodyStr);
                    throw new TeaError([
                        "code"    => $respMap["Code"],
                        "message" => $respMap["Message"],
                        "data"    => [
                            "httpCode"  => $_response->statusCode,
                            "requestId" => $respMap["RequestId"],
                            "hostId"    => $respMap["HostId"]
                        ]
                    ]);
                }
                return $_response->headers;
            } catch (\Exception $e) {
                if (Tea::isRetryable($e)) {
                    continue;
                }
                throw $e;
            }
        }
        throw new TeaUnableRetryError($_lastRequest);
    }

    public function initiateMultipartUpload(InitiateMultipartUploadRequest $request, RuntimeOptions $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime     = [
            "timeouted"      => "retry",
            "readTimeout"    => Utils::defaultNumber($runtime->readTimeout, $this->_readTimeout),
            "connectTimeout" => Utils::defaultNumber($runtime->connectTimeout, $this->_connectTimeout),
            "localAddr"      => Utils::defaultString($runtime->localAddr, $this->_localAddr),
            "httpProxy"      => Utils::defaultString($runtime->httpProxy, $this->_httpProxy),
            "httpsProxy"     => Utils::defaultString($runtime->httpsProxy, $this->_httpsProxy),
            "noProxy"        => Utils::defaultString($runtime->noProxy, $this->_noProxy),
            "socks5Proxy"    => Utils::defaultString($runtime->socks5Proxy, $this->_socks5Proxy),
            "socks5NetWork"  => Utils::defaultString($runtime->socks5NetWork, $this->_socks5NetWork),
            "maxIdleConns"   => Utils::defaultNumber($runtime->maxIdleConns, $this->_maxIdleConns),
            "retry"          => [
                "retryable"   => $runtime->autoretry,
                "maxAttempts" => Utils::defaultNumber($runtime->maxAttempts, 3)
            ],
            "backoff"        => [
                "policy" => Utils::defaultString($runtime->backoffPolicy, "no"),
                "period" => Utils::defaultNumber($runtime->backoffPeriod, 1)
            ],
            "ignoreSSL"      => $runtime->ignoreSSL
        ];
        $_lastRequest = null;
        $_now         = time();
        $_retryTimes  = 0;
        while (Tea::allowRetry($_runtime["retry"], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime($_runtime["backoff"], $_retryTimes);
                if ($_backoffTime > 0) {
                    Tea::sleep($_backoffTime);
                }
            }
            $_retryTimes = $_retryTimes + 1;
            try {
                $_request           = new Request();
                $accessKeyId        = $this->_credential->getAccessKeyId();
                $accessKeySecret    = $this->_credential->getAccessKeySecret();
                $token              = $this->_credential->getSecurityToken();
                $_request->protocol = $this->_protocol;
                $_request->method   = "POST";
                $_request->pathname = "/" . $request->objectName . "?uploads";
                $_request->headers  = [
                    "host"       => OSSUtils::getHost($request->bucketName, $this->_regionId, $this->_endpoint, $this->_hostModel),
                    "date"       => Utils::getDateUTCString(),
                    "user-agent" => $this->getUserAgent(),
                    Utils::stringifyMapValue($request->header)
                ];
                if (!Utils::_empty($token)) {
                    $_request->headers["x-oss-security-token"] = $token;
                }
                $_request->query = Utils::stringifyMapValue($request->filter);
                if (Utils::isUnset($request->header) && !Utils::_empty($request->header->contentType)) {
                    $_request->headers["content-type"] = $request->header->contentType;
                } else {
                    $_request->headers["content-type"] = OSSUtils::getContentType($request->objectName);
                }
                $_request->headers["authorization"] = OSSUtils::getSignature($_request, $request->bucketName, $accessKeyId, $accessKeySecret, $this->_signatureVersion, $this->_addtionalHeaders);
                $_lastRequest                       = $_request;
                $_response                          = Tea::send($_request, $_runtime);
                $respMap                            = null;
                $bodyStr                            = null;
                if (Utils::is4xx($_response->statusCode) || Utils::is5xx($_response->statusCode)) {
                    $bodyStr = Utils::readAsString($_response->body);
                    $respMap = OSSUtils::getErrMessage($bodyStr);
                    throw new TeaError([
                        "code"    => $respMap["Code"],
                        "message" => $respMap["Message"],
                        "data"    => [
                            "httpCode"  => $_response->statusCode,
                            "requestId" => $respMap["RequestId"],
                            "hostId"    => $respMap["HostId"]
                        ]
                    ]);
                }
                $bodyStr = Utils::readAsString($_response->body);
                $respMap = XML::parseXml($bodyStr, InitiateMultipartUploadResponse::class);
                return [
                    [
                        "InitiateMultipartUploadResult" => $respMap["InitiateMultipartUploadResult"],
                    ],
                    $_response->headers
                ];
            } catch (\Exception $e) {
                if (Tea::isRetryable($e)) {
                    continue;
                }
                throw $e;
            }
        }
        throw new TeaUnableRetryError($_lastRequest);
    }

    public function optionObject(OptionObjectRequest $request, RuntimeOptions $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime     = [
            "timeouted"      => "retry",
            "readTimeout"    => Utils::defaultNumber($runtime->readTimeout, $this->_readTimeout),
            "connectTimeout" => Utils::defaultNumber($runtime->connectTimeout, $this->_connectTimeout),
            "localAddr"      => Utils::defaultString($runtime->localAddr, $this->_localAddr),
            "httpProxy"      => Utils::defaultString($runtime->httpProxy, $this->_httpProxy),
            "httpsProxy"     => Utils::defaultString($runtime->httpsProxy, $this->_httpsProxy),
            "noProxy"        => Utils::defaultString($runtime->noProxy, $this->_noProxy),
            "socks5Proxy"    => Utils::defaultString($runtime->socks5Proxy, $this->_socks5Proxy),
            "socks5NetWork"  => Utils::defaultString($runtime->socks5NetWork, $this->_socks5NetWork),
            "maxIdleConns"   => Utils::defaultNumber($runtime->maxIdleConns, $this->_maxIdleConns),
            "retry"          => [
                "retryable"   => $runtime->autoretry,
                "maxAttempts" => Utils::defaultNumber($runtime->maxAttempts, 3)
            ],
            "backoff"        => [
                "policy" => Utils::defaultString($runtime->backoffPolicy, "no"),
                "period" => Utils::defaultNumber($runtime->backoffPeriod, 1)
            ],
            "ignoreSSL"      => $runtime->ignoreSSL
        ];
        $_lastRequest = null;
        $_now         = time();
        $_retryTimes  = 0;
        while (Tea::allowRetry($_runtime["retry"], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime($_runtime["backoff"], $_retryTimes);
                if ($_backoffTime > 0) {
                    Tea::sleep($_backoffTime);
                }
            }
            $_retryTimes = $_retryTimes + 1;
            try {
                $_request           = new Request();
                $accessKeyId        = $this->_credential->getAccessKeyId();
                $accessKeySecret    = $this->_credential->getAccessKeySecret();
                $token              = $this->_credential->getSecurityToken();
                $_request->protocol = $this->_protocol;
                $_request->method   = "OPTIONS";
                $_request->pathname = "/" . $request->objectName . "";
                $_request->headers  = [
                    "host"       => OSSUtils::getHost($request->bucketName, $this->_regionId, $this->_endpoint, $this->_hostModel),
                    "date"       => Utils::getDateUTCString(),
                    "user-agent" => $this->getUserAgent(),
                    Utils::stringifyMapValue($request->header)
                ];
                if (!Utils::_empty($token)) {
                    $_request->headers["x-oss-security-token"] = $token;
                }
                $_request->headers["authorization"] = OSSUtils::getSignature($_request, $request->bucketName, $accessKeyId, $accessKeySecret, $this->_signatureVersion, $this->_addtionalHeaders);
                $_lastRequest                       = $_request;
                $_response                          = Tea::send($_request, $_runtime);
                $respMap                            = null;
                $bodyStr                            = null;
                if (Utils::is4xx($_response->statusCode) || Utils::is5xx($_response->statusCode)) {
                    $bodyStr = Utils::readAsString($_response->body);
                    $respMap = OSSUtils::getErrMessage($bodyStr);
                    throw new TeaError([
                        "code"    => $respMap["Code"],
                        "message" => $respMap["Message"],
                        "data"    => [
                            "httpCode"  => $_response->statusCode,
                            "requestId" => $respMap["RequestId"],
                            "hostId"    => $respMap["HostId"]
                        ]
                    ]);
                }
                return $_response->headers;
            } catch (\Exception $e) {
                if (Tea::isRetryable($e)) {
                    continue;
                }
                throw $e;
            }
        }
        throw new TeaUnableRetryError($_lastRequest);
    }

    public function postVodPlaylist(PostVodPlaylistRequest $request, RuntimeOptions $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime     = [
            "timeouted"      => "retry",
            "readTimeout"    => Utils::defaultNumber($runtime->readTimeout, $this->_readTimeout),
            "connectTimeout" => Utils::defaultNumber($runtime->connectTimeout, $this->_connectTimeout),
            "localAddr"      => Utils::defaultString($runtime->localAddr, $this->_localAddr),
            "httpProxy"      => Utils::defaultString($runtime->httpProxy, $this->_httpProxy),
            "httpsProxy"     => Utils::defaultString($runtime->httpsProxy, $this->_httpsProxy),
            "noProxy"        => Utils::defaultString($runtime->noProxy, $this->_noProxy),
            "socks5Proxy"    => Utils::defaultString($runtime->socks5Proxy, $this->_socks5Proxy),
            "socks5NetWork"  => Utils::defaultString($runtime->socks5NetWork, $this->_socks5NetWork),
            "maxIdleConns"   => Utils::defaultNumber($runtime->maxIdleConns, $this->_maxIdleConns),
            "retry"          => [
                "retryable"   => $runtime->autoretry,
                "maxAttempts" => Utils::defaultNumber($runtime->maxAttempts, 3)
            ],
            "backoff"        => [
                "policy" => Utils::defaultString($runtime->backoffPolicy, "no"),
                "period" => Utils::defaultNumber($runtime->backoffPeriod, 1)
            ],
            "ignoreSSL"      => $runtime->ignoreSSL
        ];
        $_lastRequest = null;
        $_now         = time();
        $_retryTimes  = 0;
        while (Tea::allowRetry($_runtime["retry"], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime($_runtime["backoff"], $_retryTimes);
                if ($_backoffTime > 0) {
                    Tea::sleep($_backoffTime);
                }
            }
            $_retryTimes = $_retryTimes + 1;
            try {
                $_request           = new Request();
                $accessKeyId        = $this->_credential->getAccessKeyId();
                $accessKeySecret    = $this->_credential->getAccessKeySecret();
                $token              = $this->_credential->getSecurityToken();
                $_request->protocol = $this->_protocol;
                $_request->method   = "POST";
                $_request->pathname = "/" . $request->channelName . "/" . $request->playlistName . "?vod";
                $_request->headers  = [
                    "host"       => OSSUtils::getHost($request->bucketName, $this->_regionId, $this->_endpoint, $this->_hostModel),
                    "date"       => Utils::getDateUTCString(),
                    "user-agent" => $this->getUserAgent()
                ];
                if (!Utils::_empty($token)) {
                    $_request->headers["x-oss-security-token"] = $token;
                }
                $_request->query                    = Utils::stringifyMapValue($request->filter);
                $_request->headers["authorization"] = OSSUtils::getSignature($_request, $request->bucketName, $accessKeyId, $accessKeySecret, $this->_signatureVersion, $this->_addtionalHeaders);
                $_lastRequest                       = $_request;
                $_response                          = Tea::send($_request, $_runtime);
                $respMap                            = null;
                $bodyStr                            = null;
                if (Utils::is4xx($_response->statusCode) || Utils::is5xx($_response->statusCode)) {
                    $bodyStr = Utils::readAsString($_response->body);
                    $respMap = OSSUtils::getErrMessage($bodyStr);
                    throw new TeaError([
                        "code"    => $respMap["Code"],
                        "message" => $respMap["Message"],
                        "data"    => [
                            "httpCode"  => $_response->statusCode,
                            "requestId" => $respMap["RequestId"],
                            "hostId"    => $respMap["HostId"]
                        ]
                    ]);
                }
                return $_response->headers;
            } catch (\Exception $e) {
                if (Tea::isRetryable($e)) {
                    continue;
                }
                throw $e;
            }
        }
        throw new TeaUnableRetryError($_lastRequest);
    }

    public function postObject(PostObjectRequest $request, RuntimeOptions $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime     = [
            "timeouted"      => "retry",
            "readTimeout"    => Utils::defaultNumber($runtime->readTimeout, $this->_readTimeout),
            "connectTimeout" => Utils::defaultNumber($runtime->connectTimeout, $this->_connectTimeout),
            "httpProxy"      => Utils::defaultString($runtime->httpProxy, $this->_httpProxy),
            "httpsProxy"     => Utils::defaultString($runtime->httpsProxy, $this->_httpsProxy),
            "noProxy"        => Utils::defaultString($runtime->noProxy, $this->_noProxy),
            "maxIdleConns"   => Utils::defaultNumber($runtime->maxIdleConns, $this->_maxIdleConns),
            "retry"          => [
                "retryable"   => $runtime->autoretry,
                "maxAttempts" => Utils::defaultNumber($runtime->maxAttempts, 3)
            ],
            "backoff"        => [
                "policy" => Utils::defaultString($runtime->backoffPolicy, "no"),
                "period" => Utils::defaultNumber($runtime->backoffPeriod, 1)
            ],
            "ignoreSSL"      => $runtime->ignoreSSL
        ];
        $_lastRequest = null;
        $_now         = time();
        $_retryTimes  = 0;
        while (Tea::allowRetry($_runtime["retry"], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime($_runtime["backoff"], $_retryTimes);
                if ($_backoffTime > 0) {
                    Tea::sleep($_backoffTime);
                }
            }
            $_retryTimes = $_retryTimes + 1;
            try {
                $_request                          = new Request();
                $boundary                          = FileForm::getBoundary();
                $_request->protocol                = $this->_protocol;
                $_request->method                  = "POST";
                $_request->pathname                = "/";
                $_request->headers                 = [
                    "host"       => OSSUtils::getHost($request->bucketName, $this->_regionId, $this->_endpoint, $this->_hostModel),
                    "date"       => Utils::getDateUTCString(),
                    "user-agent" => $this->getUserAgent()
                ];
                $_request->headers["content-type"] = "multipart/form-data; boundary=" . $boundary . "";
                $form                              = [
                    "OSSAccessKeyId"        => $request->header->accessKeyId,
                    "policy"                => $request->header->policy,
                    "Signature"             => $request->header->signature,
                    "key"                   => $request->header->key,
                    "success_action_status" => $request->header->successActionStatus,
                    "file"                  => $request->header->file,
                    OSSUtils::toMeta($request->header->userMeta, "x-oss-meta-")
                ];
                $_request->body                    = FileForm::toFileForm($form, $boundary);
                $_lastRequest                      = $_request;
                $_response                         = Tea::send($_request, $_runtime);
                $respMap                           = null;
                $bodyStr                           = Utils::readAsString($_response->body);
                if (Utils::is4xx($_response->statusCode) || Utils::is5xx($_response->statusCode)) {
                    $respMap = OSSUtils::getErrMessage($bodyStr);
                    throw new TeaError([
                        "code"    => $respMap["Code"],
                        "message" => $respMap["Message"],
                        "data"    => [
                            "httpCode"  => $_response->statusCode,
                            "requestId" => $respMap["RequestId"],
                            "hostId"    => $respMap["HostId"]
                        ]
                    ]);
                }
                $respMap = XML::parseXml($bodyStr, PostObjectResponse::class);
                return $respMap;
            } catch (\Exception $e) {
                if (Tea::isRetryable($e)) {
                    continue;
                }
                throw $e;
            }
        }
        throw new TeaUnableRetryError($_lastRequest);
    }

    public function headObject(HeadObjectRequest $request, RuntimeOptions $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime     = [
            "timeouted"      => "retry",
            "readTimeout"    => Utils::defaultNumber($runtime->readTimeout, $this->_readTimeout),
            "connectTimeout" => Utils::defaultNumber($runtime->connectTimeout, $this->_connectTimeout),
            "localAddr"      => Utils::defaultString($runtime->localAddr, $this->_localAddr),
            "httpProxy"      => Utils::defaultString($runtime->httpProxy, $this->_httpProxy),
            "httpsProxy"     => Utils::defaultString($runtime->httpsProxy, $this->_httpsProxy),
            "noProxy"        => Utils::defaultString($runtime->noProxy, $this->_noProxy),
            "socks5Proxy"    => Utils::defaultString($runtime->socks5Proxy, $this->_socks5Proxy),
            "socks5NetWork"  => Utils::defaultString($runtime->socks5NetWork, $this->_socks5NetWork),
            "maxIdleConns"   => Utils::defaultNumber($runtime->maxIdleConns, $this->_maxIdleConns),
            "retry"          => [
                "retryable"   => $runtime->autoretry,
                "maxAttempts" => Utils::defaultNumber($runtime->maxAttempts, 3)
            ],
            "backoff"        => [
                "policy" => Utils::defaultString($runtime->backoffPolicy, "no"),
                "period" => Utils::defaultNumber($runtime->backoffPeriod, 1)
            ],
            "ignoreSSL"      => $runtime->ignoreSSL
        ];
        $_lastRequest = null;
        $_now         = time();
        $_retryTimes  = 0;
        while (Tea::allowRetry($_runtime["retry"], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime($_runtime["backoff"], $_retryTimes);
                if ($_backoffTime > 0) {
                    Tea::sleep($_backoffTime);
                }
            }
            $_retryTimes = $_retryTimes + 1;
            try {
                $_request           = new Request();
                $accessKeyId        = $this->_credential->getAccessKeyId();
                $accessKeySecret    = $this->_credential->getAccessKeySecret();
                $token              = $this->_credential->getSecurityToken();
                $_request->protocol = $this->_protocol;
                $_request->method   = "HEAD";
                $_request->pathname = "/" . $request->objectName . "";
                $_request->headers  = [
                    "host"       => OSSUtils::getHost($request->bucketName, $this->_regionId, $this->_endpoint, $this->_hostModel),
                    "date"       => Utils::getDateUTCString(),
                    "user-agent" => $this->getUserAgent(),
                    Utils::stringifyMapValue($request->header)
                ];
                if (!Utils::_empty($token)) {
                    $_request->headers["x-oss-security-token"] = $token;
                }
                $_request->headers["authorization"] = OSSUtils::getSignature($_request, $request->bucketName, $accessKeyId, $accessKeySecret, $this->_signatureVersion, $this->_addtionalHeaders);
                $_lastRequest                       = $_request;
                $_response                          = Tea::send($_request, $_runtime);
                $respMap                            = null;
                $bodyStr                            = null;
                if (Utils::is4xx($_response->statusCode) || Utils::is5xx($_response->statusCode)) {
                    $bodyStr = Utils::readAsString($_response->body);
                    $respMap = OSSUtils::getErrMessage($bodyStr);
                    throw new TeaError([
                        "code"    => $respMap["Code"],
                        "message" => $respMap["Message"],
                        "data"    => [
                            "httpCode"  => $_response->statusCode,
                            "requestId" => $respMap["RequestId"],
                            "hostId"    => $respMap["HostId"]
                        ]
                    ]);
                }
                return [
                    [
                        "usermeta" => OSSUtils::toMeta($_response->headers, "x-oss-meta-"),
                    ],
                    $_response->headers
                ];
            } catch (\Exception $e) {
                if (Tea::isRetryable($e)) {
                    continue;
                }
                throw $e;
            }
        }
        throw new TeaUnableRetryError($_lastRequest);
    }

    public function deleteObjectTagging(DeleteObjectTaggingRequest $request, RuntimeOptions $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime     = [
            "timeouted"      => "retry",
            "readTimeout"    => Utils::defaultNumber($runtime->readTimeout, $this->_readTimeout),
            "connectTimeout" => Utils::defaultNumber($runtime->connectTimeout, $this->_connectTimeout),
            "localAddr"      => Utils::defaultString($runtime->localAddr, $this->_localAddr),
            "httpProxy"      => Utils::defaultString($runtime->httpProxy, $this->_httpProxy),
            "httpsProxy"     => Utils::defaultString($runtime->httpsProxy, $this->_httpsProxy),
            "noProxy"        => Utils::defaultString($runtime->noProxy, $this->_noProxy),
            "socks5Proxy"    => Utils::defaultString($runtime->socks5Proxy, $this->_socks5Proxy),
            "socks5NetWork"  => Utils::defaultString($runtime->socks5NetWork, $this->_socks5NetWork),
            "maxIdleConns"   => Utils::defaultNumber($runtime->maxIdleConns, $this->_maxIdleConns),
            "retry"          => [
                "retryable"   => $runtime->autoretry,
                "maxAttempts" => Utils::defaultNumber($runtime->maxAttempts, 3)
            ],
            "backoff"        => [
                "policy" => Utils::defaultString($runtime->backoffPolicy, "no"),
                "period" => Utils::defaultNumber($runtime->backoffPeriod, 1)
            ],
            "ignoreSSL"      => $runtime->ignoreSSL
        ];
        $_lastRequest = null;
        $_now         = time();
        $_retryTimes  = 0;
        while (Tea::allowRetry($_runtime["retry"], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime($_runtime["backoff"], $_retryTimes);
                if ($_backoffTime > 0) {
                    Tea::sleep($_backoffTime);
                }
            }
            $_retryTimes = $_retryTimes + 1;
            try {
                $_request           = new Request();
                $accessKeyId        = $this->_credential->getAccessKeyId();
                $accessKeySecret    = $this->_credential->getAccessKeySecret();
                $token              = $this->_credential->getSecurityToken();
                $_request->protocol = $this->_protocol;
                $_request->method   = "DELETE";
                $_request->pathname = "/" . $request->objectName . "?tagging";
                $_request->headers  = [
                    "host"       => OSSUtils::getHost($request->bucketName, $this->_regionId, $this->_endpoint, $this->_hostModel),
                    "date"       => Utils::getDateUTCString(),
                    "user-agent" => $this->getUserAgent()
                ];
                if (!Utils::_empty($token)) {
                    $_request->headers["x-oss-security-token"] = $token;
                }
                $_request->headers["authorization"] = OSSUtils::getSignature($_request, $request->bucketName, $accessKeyId, $accessKeySecret, $this->_signatureVersion, $this->_addtionalHeaders);
                $_lastRequest                       = $_request;
                $_response                          = Tea::send($_request, $_runtime);
                $respMap                            = null;
                $bodyStr                            = null;
                if (Utils::is4xx($_response->statusCode) || Utils::is5xx($_response->statusCode)) {
                    $bodyStr = Utils::readAsString($_response->body);
                    $respMap = OSSUtils::getErrMessage($bodyStr);
                    throw new TeaError([
                        "code"    => $respMap["Code"],
                        "message" => $respMap["Message"],
                        "data"    => [
                            "httpCode"  => $_response->statusCode,
                            "requestId" => $respMap["RequestId"],
                            "hostId"    => $respMap["HostId"]
                        ]
                    ]);
                }
                return $_response->headers;
            } catch (\Exception $e) {
                if (Tea::isRetryable($e)) {
                    continue;
                }
                throw $e;
            }
        }
        throw new TeaUnableRetryError($_lastRequest);
    }

    public function restoreObject(RestoreObjectRequest $request, RuntimeOptions $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime     = [
            "timeouted"      => "retry",
            "readTimeout"    => Utils::defaultNumber($runtime->readTimeout, $this->_readTimeout),
            "connectTimeout" => Utils::defaultNumber($runtime->connectTimeout, $this->_connectTimeout),
            "localAddr"      => Utils::defaultString($runtime->localAddr, $this->_localAddr),
            "httpProxy"      => Utils::defaultString($runtime->httpProxy, $this->_httpProxy),
            "httpsProxy"     => Utils::defaultString($runtime->httpsProxy, $this->_httpsProxy),
            "noProxy"        => Utils::defaultString($runtime->noProxy, $this->_noProxy),
            "socks5Proxy"    => Utils::defaultString($runtime->socks5Proxy, $this->_socks5Proxy),
            "socks5NetWork"  => Utils::defaultString($runtime->socks5NetWork, $this->_socks5NetWork),
            "maxIdleConns"   => Utils::defaultNumber($runtime->maxIdleConns, $this->_maxIdleConns),
            "retry"          => [
                "retryable"   => $runtime->autoretry,
                "maxAttempts" => Utils::defaultNumber($runtime->maxAttempts, 3)
            ],
            "backoff"        => [
                "policy" => Utils::defaultString($runtime->backoffPolicy, "no"),
                "period" => Utils::defaultNumber($runtime->backoffPeriod, 1)
            ],
            "ignoreSSL"      => $runtime->ignoreSSL
        ];
        $_lastRequest = null;
        $_now         = time();
        $_retryTimes  = 0;
        while (Tea::allowRetry($_runtime["retry"], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime($_runtime["backoff"], $_retryTimes);
                if ($_backoffTime > 0) {
                    Tea::sleep($_backoffTime);
                }
            }
            $_retryTimes = $_retryTimes + 1;
            try {
                $_request           = new Request();
                $accessKeyId        = $this->_credential->getAccessKeyId();
                $accessKeySecret    = $this->_credential->getAccessKeySecret();
                $token              = $this->_credential->getSecurityToken();
                $_request->protocol = $this->_protocol;
                $_request->method   = "POST";
                $_request->pathname = "/" . $request->objectName . "?restore";
                $_request->headers  = [
                    "host"       => OSSUtils::getHost($request->bucketName, $this->_regionId, $this->_endpoint, $this->_hostModel),
                    "date"       => Utils::getDateUTCString(),
                    "user-agent" => $this->getUserAgent()
                ];
                if (!Utils::_empty($token)) {
                    $_request->headers["x-oss-security-token"] = $token;
                }
                $_request->headers["authorization"] = OSSUtils::getSignature($_request, $request->bucketName, $accessKeyId, $accessKeySecret, $this->_signatureVersion, $this->_addtionalHeaders);
                $_lastRequest                       = $_request;
                $_response                          = Tea::send($_request, $_runtime);
                $respMap                            = null;
                $bodyStr                            = null;
                if (Utils::is4xx($_response->statusCode) || Utils::is5xx($_response->statusCode)) {
                    $bodyStr = Utils::readAsString($_response->body);
                    $respMap = OSSUtils::getErrMessage($bodyStr);
                    throw new TeaError([
                        "code"    => $respMap["Code"],
                        "message" => $respMap["Message"],
                        "data"    => [
                            "httpCode"  => $_response->statusCode,
                            "requestId" => $respMap["RequestId"],
                            "hostId"    => $respMap["HostId"]
                        ]
                    ]);
                }
                return $_response->headers;
            } catch (\Exception $e) {
                if (Tea::isRetryable($e)) {
                    continue;
                }
                throw $e;
            }
        }
        throw new TeaUnableRetryError($_lastRequest);
    }

    public function getObjectAcl(GetObjectAclRequest $request, RuntimeOptions $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime     = [
            "timeouted"      => "retry",
            "readTimeout"    => Utils::defaultNumber($runtime->readTimeout, $this->_readTimeout),
            "connectTimeout" => Utils::defaultNumber($runtime->connectTimeout, $this->_connectTimeout),
            "localAddr"      => Utils::defaultString($runtime->localAddr, $this->_localAddr),
            "httpProxy"      => Utils::defaultString($runtime->httpProxy, $this->_httpProxy),
            "httpsProxy"     => Utils::defaultString($runtime->httpsProxy, $this->_httpsProxy),
            "noProxy"        => Utils::defaultString($runtime->noProxy, $this->_noProxy),
            "socks5Proxy"    => Utils::defaultString($runtime->socks5Proxy, $this->_socks5Proxy),
            "socks5NetWork"  => Utils::defaultString($runtime->socks5NetWork, $this->_socks5NetWork),
            "maxIdleConns"   => Utils::defaultNumber($runtime->maxIdleConns, $this->_maxIdleConns),
            "retry"          => [
                "retryable"   => $runtime->autoretry,
                "maxAttempts" => Utils::defaultNumber($runtime->maxAttempts, 3)
            ],
            "backoff"        => [
                "policy" => Utils::defaultString($runtime->backoffPolicy, "no"),
                "period" => Utils::defaultNumber($runtime->backoffPeriod, 1)
            ],
            "ignoreSSL"      => $runtime->ignoreSSL
        ];
        $_lastRequest = null;
        $_now         = time();
        $_retryTimes  = 0;
        while (Tea::allowRetry($_runtime["retry"], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime($_runtime["backoff"], $_retryTimes);
                if ($_backoffTime > 0) {
                    Tea::sleep($_backoffTime);
                }
            }
            $_retryTimes = $_retryTimes + 1;
            try {
                $_request           = new Request();
                $accessKeyId        = $this->_credential->getAccessKeyId();
                $accessKeySecret    = $this->_credential->getAccessKeySecret();
                $token              = $this->_credential->getSecurityToken();
                $_request->protocol = $this->_protocol;
                $_request->method   = "GET";
                $_request->pathname = "/" . $request->objectName . "?acl";
                $_request->headers  = [
                    "host"       => OSSUtils::getHost($request->bucketName, $this->_regionId, $this->_endpoint, $this->_hostModel),
                    "date"       => Utils::getDateUTCString(),
                    "user-agent" => $this->getUserAgent()
                ];
                if (!Utils::_empty($token)) {
                    $_request->headers["x-oss-security-token"] = $token;
                }
                $_request->headers["authorization"] = OSSUtils::getSignature($_request, $request->bucketName, $accessKeyId, $accessKeySecret, $this->_signatureVersion, $this->_addtionalHeaders);
                $_lastRequest                       = $_request;
                $_response                          = Tea::send($_request, $_runtime);
                $respMap                            = null;
                $bodyStr                            = null;
                if (Utils::is4xx($_response->statusCode) || Utils::is5xx($_response->statusCode)) {
                    $bodyStr = Utils::readAsString($_response->body);
                    $respMap = OSSUtils::getErrMessage($bodyStr);
                    throw new TeaError([
                        "code"    => $respMap["Code"],
                        "message" => $respMap["Message"],
                        "data"    => [
                            "httpCode"  => $_response->statusCode,
                            "requestId" => $respMap["RequestId"],
                            "hostId"    => $respMap["HostId"]
                        ]
                    ]);
                }
                $bodyStr = Utils::readAsString($_response->body);
                $respMap = XML::parseXml($bodyStr, GetObjectAclResponse::class);
                return [
                    [
                        "AccessControlPolicy" => $respMap["AccessControlPolicy"],
                    ],
                    $_response->headers
                ];
            } catch (\Exception $e) {
                if (Tea::isRetryable($e)) {
                    continue;
                }
                throw $e;
            }
        }
        throw new TeaUnableRetryError($_lastRequest);
    }

    public function putBucketAcl(PutBucketAclRequest $request, RuntimeOptions $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime     = [
            "timeouted"      => "retry",
            "readTimeout"    => Utils::defaultNumber($runtime->readTimeout, $this->_readTimeout),
            "connectTimeout" => Utils::defaultNumber($runtime->connectTimeout, $this->_connectTimeout),
            "localAddr"      => Utils::defaultString($runtime->localAddr, $this->_localAddr),
            "httpProxy"      => Utils::defaultString($runtime->httpProxy, $this->_httpProxy),
            "httpsProxy"     => Utils::defaultString($runtime->httpsProxy, $this->_httpsProxy),
            "noProxy"        => Utils::defaultString($runtime->noProxy, $this->_noProxy),
            "socks5Proxy"    => Utils::defaultString($runtime->socks5Proxy, $this->_socks5Proxy),
            "socks5NetWork"  => Utils::defaultString($runtime->socks5NetWork, $this->_socks5NetWork),
            "maxIdleConns"   => Utils::defaultNumber($runtime->maxIdleConns, $this->_maxIdleConns),
            "retry"          => [
                "retryable"   => $runtime->autoretry,
                "maxAttempts" => Utils::defaultNumber($runtime->maxAttempts, 3)
            ],
            "backoff"        => [
                "policy" => Utils::defaultString($runtime->backoffPolicy, "no"),
                "period" => Utils::defaultNumber($runtime->backoffPeriod, 1)
            ],
            "ignoreSSL"      => $runtime->ignoreSSL
        ];
        $_lastRequest = null;
        $_now         = time();
        $_retryTimes  = 0;
        while (Tea::allowRetry($_runtime["retry"], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime($_runtime["backoff"], $_retryTimes);
                if ($_backoffTime > 0) {
                    Tea::sleep($_backoffTime);
                }
            }
            $_retryTimes = $_retryTimes + 1;
            try {
                $_request           = new Request();
                $accessKeyId        = $this->_credential->getAccessKeyId();
                $accessKeySecret    = $this->_credential->getAccessKeySecret();
                $token              = $this->_credential->getSecurityToken();
                $_request->protocol = $this->_protocol;
                $_request->method   = "PUT";
                $_request->pathname = "/?acl";
                $_request->headers  = [
                    "host"       => OSSUtils::getHost($request->bucketName, $this->_regionId, $this->_endpoint, $this->_hostModel),
                    "date"       => Utils::getDateUTCString(),
                    "user-agent" => $this->getUserAgent(),
                    Utils::stringifyMapValue($request->header)
                ];
                if (!Utils::_empty($token)) {
                    $_request->headers["x-oss-security-token"] = $token;
                }
                $_request->headers["authorization"] = OSSUtils::getSignature($_request, $request->bucketName, $accessKeyId, $accessKeySecret, $this->_signatureVersion, $this->_addtionalHeaders);
                $_lastRequest                       = $_request;
                $_response                          = Tea::send($_request, $_runtime);
                $respMap                            = null;
                $bodyStr                            = null;
                if (Utils::is4xx($_response->statusCode) || Utils::is5xx($_response->statusCode)) {
                    $bodyStr = Utils::readAsString($_response->body);
                    $respMap = OSSUtils::getErrMessage($bodyStr);
                    throw new TeaError([
                        "code"    => $respMap["Code"],
                        "message" => $respMap["Message"],
                        "data"    => [
                            "httpCode"  => $_response->statusCode,
                            "requestId" => $respMap["RequestId"],
                            "hostId"    => $respMap["HostId"]
                        ]
                    ]);
                }
                return $_response->headers;
            } catch (\Exception $e) {
                if (Tea::isRetryable($e)) {
                    continue;
                }
                throw $e;
            }
        }
        throw new TeaUnableRetryError($_lastRequest);
    }

    public function deleteBucket(DeleteBucketRequest $request, RuntimeOptions $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime     = [
            "timeouted"      => "retry",
            "readTimeout"    => Utils::defaultNumber($runtime->readTimeout, $this->_readTimeout),
            "connectTimeout" => Utils::defaultNumber($runtime->connectTimeout, $this->_connectTimeout),
            "localAddr"      => Utils::defaultString($runtime->localAddr, $this->_localAddr),
            "httpProxy"      => Utils::defaultString($runtime->httpProxy, $this->_httpProxy),
            "httpsProxy"     => Utils::defaultString($runtime->httpsProxy, $this->_httpsProxy),
            "noProxy"        => Utils::defaultString($runtime->noProxy, $this->_noProxy),
            "socks5Proxy"    => Utils::defaultString($runtime->socks5Proxy, $this->_socks5Proxy),
            "socks5NetWork"  => Utils::defaultString($runtime->socks5NetWork, $this->_socks5NetWork),
            "maxIdleConns"   => Utils::defaultNumber($runtime->maxIdleConns, $this->_maxIdleConns),
            "retry"          => [
                "retryable"   => $runtime->autoretry,
                "maxAttempts" => Utils::defaultNumber($runtime->maxAttempts, 3)
            ],
            "backoff"        => [
                "policy" => Utils::defaultString($runtime->backoffPolicy, "no"),
                "period" => Utils::defaultNumber($runtime->backoffPeriod, 1)
            ],
            "ignoreSSL"      => $runtime->ignoreSSL
        ];
        $_lastRequest = null;
        $_now         = time();
        $_retryTimes  = 0;
        while (Tea::allowRetry($_runtime["retry"], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime($_runtime["backoff"], $_retryTimes);
                if ($_backoffTime > 0) {
                    Tea::sleep($_backoffTime);
                }
            }
            $_retryTimes = $_retryTimes + 1;
            try {
                $_request           = new Request();
                $accessKeyId        = $this->_credential->getAccessKeyId();
                $accessKeySecret    = $this->_credential->getAccessKeySecret();
                $token              = $this->_credential->getSecurityToken();
                $_request->protocol = $this->_protocol;
                $_request->method   = "DELETE";
                $_request->pathname = "/";
                $_request->headers  = [
                    "host"       => OSSUtils::getHost($request->bucketName, $this->_regionId, $this->_endpoint, $this->_hostModel),
                    "date"       => Utils::getDateUTCString(),
                    "user-agent" => $this->getUserAgent()
                ];
                if (!Utils::_empty($token)) {
                    $_request->headers["x-oss-security-token"] = $token;
                }
                $_request->headers["authorization"] = OSSUtils::getSignature($_request, $request->bucketName, $accessKeyId, $accessKeySecret, $this->_signatureVersion, $this->_addtionalHeaders);
                $_lastRequest                       = $_request;
                $_response                          = Tea::send($_request, $_runtime);
                $respMap                            = null;
                $bodyStr                            = null;
                if (Utils::is4xx($_response->statusCode) || Utils::is5xx($_response->statusCode)) {
                    $bodyStr = Utils::readAsString($_response->body);
                    $respMap = OSSUtils::getErrMessage($bodyStr);
                    throw new TeaError([
                        "code"    => $respMap["Code"],
                        "message" => $respMap["Message"],
                        "data"    => [
                            "httpCode"  => $_response->statusCode,
                            "requestId" => $respMap["RequestId"],
                            "hostId"    => $respMap["HostId"]
                        ]
                    ]);
                }
                return $_response->headers;
            } catch (\Exception $e) {
                if (Tea::isRetryable($e)) {
                    continue;
                }
                throw $e;
            }
        }
        throw new TeaUnableRetryError($_lastRequest);
    }

    public function putObject(PutObjectRequest $request, RuntimeOptions $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime     = [
            "timeouted"      => "retry",
            "readTimeout"    => Utils::defaultNumber($runtime->readTimeout, $this->_readTimeout),
            "connectTimeout" => Utils::defaultNumber($runtime->connectTimeout, $this->_connectTimeout),
            "localAddr"      => Utils::defaultString($runtime->localAddr, $this->_localAddr),
            "httpProxy"      => Utils::defaultString($runtime->httpProxy, $this->_httpProxy),
            "httpsProxy"     => Utils::defaultString($runtime->httpsProxy, $this->_httpsProxy),
            "noProxy"        => Utils::defaultString($runtime->noProxy, $this->_noProxy),
            "socks5Proxy"    => Utils::defaultString($runtime->socks5Proxy, $this->_socks5Proxy),
            "socks5NetWork"  => Utils::defaultString($runtime->socks5NetWork, $this->_socks5NetWork),
            "maxIdleConns"   => Utils::defaultNumber($runtime->maxIdleConns, $this->_maxIdleConns),
            "retry"          => [
                "retryable"   => $runtime->autoretry,
                "maxAttempts" => Utils::defaultNumber($runtime->maxAttempts, 3)
            ],
            "backoff"        => [
                "policy" => Utils::defaultString($runtime->backoffPolicy, "no"),
                "period" => Utils::defaultNumber($runtime->backoffPeriod, 1)
            ],
            "ignoreSSL"      => $runtime->ignoreSSL
        ];
        $_lastRequest = null;
        $_now         = time();
        $_retryTimes  = 0;
        while (Tea::allowRetry($_runtime["retry"], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime($_runtime["backoff"], $_retryTimes);
                if ($_backoffTime > 0) {
                    Tea::sleep($_backoffTime);
                }
            }
            $_retryTimes = $_retryTimes + 1;
            try {
                $_request           = new Request();
                $ctx                = [];
                $accessKeyId        = $this->_credential->getAccessKeyId();
                $accessKeySecret    = $this->_credential->getAccessKeySecret();
                $token              = $this->_credential->getSecurityToken();
                $_request->protocol = $this->_protocol;
                $_request->method   = "PUT";
                $_request->pathname = "/" . $request->objectName . "";
                $_request->headers  = [
                    "host"       => OSSUtils::getHost($request->bucketName, $this->_regionId, $this->_endpoint, $this->_hostModel),
                    "date"       => Utils::getDateUTCString(),
                    "user-agent" => $this->getUserAgent(),
                    Utils::stringifyMapValue($request->header),
                    OSSUtils::parseMeta($request->userMeta, "x-oss-meta-")
                ];
                if (!Utils::_empty($token)) {
                    $_request->headers["x-oss-security-token"] = $token;
                }
                $_request->body = OSSUtils::inject($request->body, $ctx);
                if (Utils::isUnset($request->header) && !Utils::_empty($request->header->contentType)) {
                    $_request->headers["content-type"] = $request->header->contentType;
                } else {
                    $_request->headers["content-type"] = OSSUtils::getContentType($request->objectName);
                }
                $_request->headers["authorization"] = OSSUtils::getSignature($_request, $request->bucketName, $accessKeyId, $accessKeySecret, $this->_signatureVersion, $this->_addtionalHeaders);
                $_lastRequest                       = $_request;
                $_response                          = Tea::send($_request, $_runtime);
                $respMap                            = null;
                $bodyStr                            = null;
                if (Utils::is4xx($_response->statusCode) || Utils::is5xx($_response->statusCode)) {
                    $bodyStr = Utils::readAsString($_response->body);
                    $respMap = OSSUtils::getErrMessage($bodyStr);
                    throw new TeaError([
                        "code"    => $respMap["Code"],
                        "message" => $respMap["Message"],
                        "data"    => [
                            "httpCode"  => $_response->statusCode,
                            "requestId" => $respMap["RequestId"],
                            "hostId"    => $respMap["HostId"]
                        ]
                    ]);
                }
                if ($this->_isEnableCrc && !Utils::equalString($ctx["crc"], $_response->headers["x-oss-hash-crc64ecma"])) {
                    throw new TeaError([
                        "code" => "CrcNotMatched",
                        "data" => [
                            "clientCrc" => $ctx["crc"],
                            "serverCrc" => $_response->headers["x-oss-hash-crc64ecma"]
                        ]
                    ]);
                }
                if ($this->_isEnableMD5 && !Utils::equalString($ctx["md5"], $_response->headers["content-md5"])) {
                    throw new TeaError([
                        "code" => "MD5NotMatched",
                        "data" => [
                            "clientMD5" => $ctx["md5"],
                            "serverMD5" => $_response->headers["content-md5"]
                        ]
                    ]);
                }
                return $_response->headers;
            } catch (\Exception $e) {
                if (Tea::isRetryable($e)) {
                    continue;
                }
                throw $e;
            }
        }
        throw new TeaUnableRetryError($_lastRequest);
    }

    public function setUserAgent($userAgent)
    {
        $this->_userAgent = $userAgent;
    }

    public function appendUserAgent($userAgent)
    {
        $this->_userAgent = "" . $this->_userAgent . " " . $userAgent . "";
    }

    public function getUserAgent()
    {
        $userAgent = Utils::getUserAgent($this->_userAgent);
        return $userAgent;
    }

    public function getAccessKeyId()
    {
        if (Utils::isUnset($this->_credential)) {
            return "";
        }
        $accessKeyId = $this->_credential->getAccessKeyId();
        return $accessKeyId;
    }

    public function getAccessKeySecret()
    {
        if (Utils::isUnset($this->_credential)) {
            return "";
        }
        $secret = $this->_credential->getAccessKeySecret();
        return $secret;
    }
}
