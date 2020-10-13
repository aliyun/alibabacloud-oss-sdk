<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS;

use AlibabaCloud\Credentials\Credential;
use AlibabaCloud\SDK\OSS\OSS\AbortMultipartUploadRequest;
use AlibabaCloud\SDK\OSS\OSS\AbortMultipartUploadResponse;
use AlibabaCloud\SDK\OSS\OSS\AppendObjectRequest;
use AlibabaCloud\SDK\OSS\OSS\AppendObjectResponse;
use AlibabaCloud\SDK\OSS\OSS\CallbackRequest;
use AlibabaCloud\SDK\OSS\OSS\CallbackResponse;
use AlibabaCloud\SDK\OSS\OSS\CompleteMultipartUploadRequest;
use AlibabaCloud\SDK\OSS\OSS\CompleteMultipartUploadResponse;
use AlibabaCloud\SDK\OSS\OSS\CopyObjectRequest;
use AlibabaCloud\SDK\OSS\OSS\CopyObjectResponse;
use AlibabaCloud\SDK\OSS\OSS\DeleteBucketCORSRequest;
use AlibabaCloud\SDK\OSS\OSS\DeleteBucketCORSResponse;
use AlibabaCloud\SDK\OSS\OSS\DeleteBucketEncryptionRequest;
use AlibabaCloud\SDK\OSS\OSS\DeleteBucketEncryptionResponse;
use AlibabaCloud\SDK\OSS\OSS\DeleteBucketLifecycleRequest;
use AlibabaCloud\SDK\OSS\OSS\DeleteBucketLifecycleResponse;
use AlibabaCloud\SDK\OSS\OSS\DeleteBucketLoggingRequest;
use AlibabaCloud\SDK\OSS\OSS\DeleteBucketLoggingResponse;
use AlibabaCloud\SDK\OSS\OSS\DeleteBucketRequest;
use AlibabaCloud\SDK\OSS\OSS\DeleteBucketResponse;
use AlibabaCloud\SDK\OSS\OSS\DeleteBucketTagsRequest;
use AlibabaCloud\SDK\OSS\OSS\DeleteBucketTagsResponse;
use AlibabaCloud\SDK\OSS\OSS\DeleteBucketWebsiteRequest;
use AlibabaCloud\SDK\OSS\OSS\DeleteBucketWebsiteResponse;
use AlibabaCloud\SDK\OSS\OSS\DeleteLiveChannelRequest;
use AlibabaCloud\SDK\OSS\OSS\DeleteLiveChannelResponse;
use AlibabaCloud\SDK\OSS\OSS\DeleteMultipleObjectsRequest;
use AlibabaCloud\SDK\OSS\OSS\DeleteMultipleObjectsResponse;
use AlibabaCloud\SDK\OSS\OSS\DeleteObjectRequest;
use AlibabaCloud\SDK\OSS\OSS\DeleteObjectResponse;
use AlibabaCloud\SDK\OSS\OSS\DeleteObjectTaggingRequest;
use AlibabaCloud\SDK\OSS\OSS\DeleteObjectTaggingResponse;
use AlibabaCloud\SDK\OSS\OSS\GetBucketAclRequest;
use AlibabaCloud\SDK\OSS\OSS\GetBucketAclResponse;
use AlibabaCloud\SDK\OSS\OSS\GetBucketCORSRequest;
use AlibabaCloud\SDK\OSS\OSS\GetBucketCORSResponse;
use AlibabaCloud\SDK\OSS\OSS\GetBucketEncryptionRequest;
use AlibabaCloud\SDK\OSS\OSS\GetBucketEncryptionResponse;
use AlibabaCloud\SDK\OSS\OSS\GetBucketInfoRequest;
use AlibabaCloud\SDK\OSS\OSS\GetBucketInfoResponse;
use AlibabaCloud\SDK\OSS\OSS\GetBucketLifecycleRequest;
use AlibabaCloud\SDK\OSS\OSS\GetBucketLifecycleResponse;
use AlibabaCloud\SDK\OSS\OSS\GetBucketLocationRequest;
use AlibabaCloud\SDK\OSS\OSS\GetBucketLocationResponse;
use AlibabaCloud\SDK\OSS\OSS\GetBucketLoggingRequest;
use AlibabaCloud\SDK\OSS\OSS\GetBucketLoggingResponse;
use AlibabaCloud\SDK\OSS\OSS\GetBucketRefererRequest;
use AlibabaCloud\SDK\OSS\OSS\GetBucketRefererResponse;
use AlibabaCloud\SDK\OSS\OSS\GetBucketRequest;
use AlibabaCloud\SDK\OSS\OSS\GetBucketRequestPaymentRequest;
use AlibabaCloud\SDK\OSS\OSS\GetBucketRequestPaymentResponse;
use AlibabaCloud\SDK\OSS\OSS\GetBucketResponse;
use AlibabaCloud\SDK\OSS\OSS\GetBucketTagsRequest;
use AlibabaCloud\SDK\OSS\OSS\GetBucketTagsResponse;
use AlibabaCloud\SDK\OSS\OSS\GetBucketWebsiteRequest;
use AlibabaCloud\SDK\OSS\OSS\GetBucketWebsiteResponse;
use AlibabaCloud\SDK\OSS\OSS\GetLiveChannelHistoryRequest;
use AlibabaCloud\SDK\OSS\OSS\GetLiveChannelHistoryResponse;
use AlibabaCloud\SDK\OSS\OSS\GetLiveChannelInfoRequest;
use AlibabaCloud\SDK\OSS\OSS\GetLiveChannelInfoResponse;
use AlibabaCloud\SDK\OSS\OSS\GetLiveChannelStatRequest;
use AlibabaCloud\SDK\OSS\OSS\GetLiveChannelStatResponse;
use AlibabaCloud\SDK\OSS\OSS\GetObjectAclRequest;
use AlibabaCloud\SDK\OSS\OSS\GetObjectAclResponse;
use AlibabaCloud\SDK\OSS\OSS\GetObjectMetaRequest;
use AlibabaCloud\SDK\OSS\OSS\GetObjectMetaResponse;
use AlibabaCloud\SDK\OSS\OSS\GetObjectRequest;
use AlibabaCloud\SDK\OSS\OSS\GetObjectResponse;
use AlibabaCloud\SDK\OSS\OSS\GetObjectTaggingRequest;
use AlibabaCloud\SDK\OSS\OSS\GetObjectTaggingResponse;
use AlibabaCloud\SDK\OSS\OSS\GetServiceRequest;
use AlibabaCloud\SDK\OSS\OSS\GetServiceResponse;
use AlibabaCloud\SDK\OSS\OSS\GetSymlinkRequest;
use AlibabaCloud\SDK\OSS\OSS\GetSymlinkResponse;
use AlibabaCloud\SDK\OSS\OSS\GetVodPlaylistRequest;
use AlibabaCloud\SDK\OSS\OSS\GetVodPlaylistResponse;
use AlibabaCloud\SDK\OSS\OSS\HeadObjectRequest;
use AlibabaCloud\SDK\OSS\OSS\HeadObjectResponse;
use AlibabaCloud\SDK\OSS\OSS\InitiateMultipartUploadRequest;
use AlibabaCloud\SDK\OSS\OSS\InitiateMultipartUploadResponse;
use AlibabaCloud\SDK\OSS\OSS\ListLiveChannelRequest;
use AlibabaCloud\SDK\OSS\OSS\ListLiveChannelResponse;
use AlibabaCloud\SDK\OSS\OSS\ListMultipartUploadsRequest;
use AlibabaCloud\SDK\OSS\OSS\ListMultipartUploadsResponse;
use AlibabaCloud\SDK\OSS\OSS\ListPartsRequest;
use AlibabaCloud\SDK\OSS\OSS\ListPartsResponse;
use AlibabaCloud\SDK\OSS\OSS\OptionObjectRequest;
use AlibabaCloud\SDK\OSS\OSS\OptionObjectResponse;
use AlibabaCloud\SDK\OSS\OSS\PostObjectRequest;
use AlibabaCloud\SDK\OSS\OSS\PostObjectResponse;
use AlibabaCloud\SDK\OSS\OSS\PostVodPlaylistRequest;
use AlibabaCloud\SDK\OSS\OSS\PostVodPlaylistResponse;
use AlibabaCloud\SDK\OSS\OSS\PutBucketAclRequest;
use AlibabaCloud\SDK\OSS\OSS\PutBucketAclResponse;
use AlibabaCloud\SDK\OSS\OSS\PutBucketCORSRequest;
use AlibabaCloud\SDK\OSS\OSS\PutBucketCORSResponse;
use AlibabaCloud\SDK\OSS\OSS\PutBucketEncryptionRequest;
use AlibabaCloud\SDK\OSS\OSS\PutBucketEncryptionResponse;
use AlibabaCloud\SDK\OSS\OSS\PutBucketLifecycleRequest;
use AlibabaCloud\SDK\OSS\OSS\PutBucketLifecycleResponse;
use AlibabaCloud\SDK\OSS\OSS\PutBucketLoggingRequest;
use AlibabaCloud\SDK\OSS\OSS\PutBucketLoggingResponse;
use AlibabaCloud\SDK\OSS\OSS\PutBucketRefererRequest;
use AlibabaCloud\SDK\OSS\OSS\PutBucketRefererResponse;
use AlibabaCloud\SDK\OSS\OSS\PutBucketRequest;
use AlibabaCloud\SDK\OSS\OSS\PutBucketRequestPaymentRequest;
use AlibabaCloud\SDK\OSS\OSS\PutBucketRequestPaymentResponse;
use AlibabaCloud\SDK\OSS\OSS\PutBucketResponse;
use AlibabaCloud\SDK\OSS\OSS\PutBucketTagsRequest;
use AlibabaCloud\SDK\OSS\OSS\PutBucketTagsResponse;
use AlibabaCloud\SDK\OSS\OSS\PutBucketWebsiteRequest;
use AlibabaCloud\SDK\OSS\OSS\PutBucketWebsiteResponse;
use AlibabaCloud\SDK\OSS\OSS\PutLiveChannelRequest;
use AlibabaCloud\SDK\OSS\OSS\PutLiveChannelResponse;
use AlibabaCloud\SDK\OSS\OSS\PutLiveChannelStatusRequest;
use AlibabaCloud\SDK\OSS\OSS\PutLiveChannelStatusResponse;
use AlibabaCloud\SDK\OSS\OSS\PutObjectAclRequest;
use AlibabaCloud\SDK\OSS\OSS\PutObjectAclResponse;
use AlibabaCloud\SDK\OSS\OSS\PutObjectRequest;
use AlibabaCloud\SDK\OSS\OSS\PutObjectResponse;
use AlibabaCloud\SDK\OSS\OSS\PutObjectTaggingRequest;
use AlibabaCloud\SDK\OSS\OSS\PutObjectTaggingResponse;
use AlibabaCloud\SDK\OSS\OSS\PutSymlinkRequest;
use AlibabaCloud\SDK\OSS\OSS\PutSymlinkResponse;
use AlibabaCloud\SDK\OSS\OSS\RestoreObjectRequest;
use AlibabaCloud\SDK\OSS\OSS\RestoreObjectResponse;
use AlibabaCloud\SDK\OSS\OSS\SelectObjectRequest;
use AlibabaCloud\SDK\OSS\OSS\SelectObjectResponse;
use AlibabaCloud\SDK\OSS\OSS\UploadPartCopyRequest;
use AlibabaCloud\SDK\OSS\OSS\UploadPartCopyResponse;
use AlibabaCloud\SDK\OSS\OSS\UploadPartRequest;
use AlibabaCloud\SDK\OSS\OSS\UploadPartResponse;
use AlibabaCloud\Tea\Exception\TeaError;
use AlibabaCloud\Tea\Exception\TeaUnableRetryError;
use AlibabaCloud\Tea\FileForm\FileForm;
use AlibabaCloud\Tea\OSSUtils\OSSUtils;
use AlibabaCloud\Tea\OSSUtils\OSSUtils\RuntimeOptions;
use AlibabaCloud\Tea\Request;
use AlibabaCloud\Tea\Tea;
use AlibabaCloud\Tea\Utils\Utils;
use AlibabaCloud\Tea\XML\XML;
use Exception;

class OSS
{
    protected $_endpoint;

    protected $_regionId;

    protected $_hostModel;

    protected $_protocol;

    protected $_readTimeout;

    protected $_connectTimeout;

    protected $_signatureVersion;

    protected $_addtionalHeaders;

    protected $_localAddr;

    protected $_httpProxy;

    protected $_httpsProxy;

    protected $_noProxy;

    protected $_userAgent;

    protected $_socks5Proxy;

    protected $_isEnableCrc;

    protected $_isEnableMD5;

    protected $_socks5NetWork;

    protected $_maxIdleConns;

    protected $_credential;

    public function __construct($config)
    {
        if (Utils::isUnset($config)) {
            throw new TeaError([
                'name'    => 'ParameterMissing',
                'message' => "'config' can not be unset",
            ]);
        }
        if (Utils::empty_($config->type)) {
            $config->type = 'access_key';
        }
        $credentialConfig = new \AlibabaCloud\Credentials\Credential\Config([
            'accessKeyId'     => $config->accessKeyId,
            'type'            => $config->type,
            'accessKeySecret' => $config->accessKeySecret,
            'securityToken'   => $config->securityToken,
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

    /**
     * @param PutBucketLifecycleRequest $request
     * @param RuntimeOptions            $runtime
     *
     * @throws TeaError
     * @throws Exception
     * @throws TeaUnableRetryError
     *
     * @return PutBucketLifecycleResponse
     */
    public function putBucketLifecycle($request, $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime = [
            'timeouted'      => 'retry',
            'readTimeout'    => Utils::defaultNumber($runtime->readTimeout, $this->_readTimeout),
            'connectTimeout' => Utils::defaultNumber($runtime->connectTimeout, $this->_connectTimeout),
            'localAddr'      => Utils::defaultString($runtime->localAddr, $this->_localAddr),
            'httpProxy'      => Utils::defaultString($runtime->httpProxy, $this->_httpProxy),
            'httpsProxy'     => Utils::defaultString($runtime->httpsProxy, $this->_httpsProxy),
            'noProxy'        => Utils::defaultString($runtime->noProxy, $this->_noProxy),
            'socks5Proxy'    => Utils::defaultString($runtime->socks5Proxy, $this->_socks5Proxy),
            'socks5NetWork'  => Utils::defaultString($runtime->socks5NetWork, $this->_socks5NetWork),
            'maxIdleConns'   => Utils::defaultNumber($runtime->maxIdleConns, $this->_maxIdleConns),
            'retry'          => [
                'retryable'   => $runtime->autoretry,
                'maxAttempts' => Utils::defaultNumber($runtime->maxAttempts, 3),
            ],
            'backoff' => [
                'policy' => Utils::defaultString($runtime->backoffPolicy, 'no'),
                'period' => Utils::defaultNumber($runtime->backoffPeriod, 1),
            ],
            'ignoreSSL' => $runtime->ignoreSSL,
        ];
        $_lastRequest   = null;
        $_lastException = null;
        $_now           = time();
        $_retryTimes    = 0;
        while (Tea::allowRetry(@$_runtime['retry'], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime(@$_runtime['backoff'], $_retryTimes);
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
                $reqBody            = XML::toXML($request->body->toMap());
                $_request->protocol = $this->_protocol;
                $_request->method   = 'PUT';
                $_request->pathname = '/?lifecycle';
                $_request->headers  = [
                    'host'       => OSSUtils::getHost($request->bucketName, $this->_regionId, $this->_endpoint, $this->_hostModel),
                    'date'       => Utils::getDateUTCString(),
                    'user-agent' => $this->getUserAgent(),
                ];
                if (!Utils::empty_($token)) {
                    $_request->headers['x-oss-security-token'] = $token;
                }
                $_request->body                     = $reqBody;
                $_request->headers['authorization'] = OSSUtils::getSignature($_request, $request->bucketName, $accessKeyId, $accessKeySecret, $this->_signatureVersion, $this->_addtionalHeaders);
                $_lastRequest                       = $_request;
                $_response                          = Tea::send($_request, $_runtime);
                $respMap                            = null;
                $bodyStr                            = null;
                if (Utils::is4xx($_response->statusCode) || Utils::is5xx($_response->statusCode)) {
                    $bodyStr = Utils::readAsString($_response->body);
                    $respMap = OSSUtils::getErrMessage($bodyStr);

                    throw new TeaError([
                        'code'    => @$respMap['Code'],
                        'message' => @$respMap['Message'],
                        'data'    => [
                            'httpCode'  => $_response->statusCode,
                            'requestId' => @$respMap['RequestId'],
                            'hostId'    => @$respMap['HostId'],
                        ],
                    ]);
                }

                return PutBucketLifecycleResponse::fromMap(Tea::merge($_response->headers));
            } catch (Exception $e) {
                if (!($e instanceof TeaError)) {
                    $e = new TeaError([], $e->getMessage(), $e->getCode(), $e);
                }
                if (Tea::isRetryable($e)) {
                    $_lastException = $e;

                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest, $_lastException);
    }

    /**
     * @param DeleteMultipleObjectsRequest $request
     * @param RuntimeOptions               $runtime
     *
     * @throws TeaError
     * @throws Exception
     * @throws TeaUnableRetryError
     *
     * @return DeleteMultipleObjectsResponse
     */
    public function deleteMultipleObjects($request, $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime = [
            'timeouted'      => 'retry',
            'readTimeout'    => Utils::defaultNumber($runtime->readTimeout, $this->_readTimeout),
            'connectTimeout' => Utils::defaultNumber($runtime->connectTimeout, $this->_connectTimeout),
            'localAddr'      => Utils::defaultString($runtime->localAddr, $this->_localAddr),
            'httpProxy'      => Utils::defaultString($runtime->httpProxy, $this->_httpProxy),
            'httpsProxy'     => Utils::defaultString($runtime->httpsProxy, $this->_httpsProxy),
            'noProxy'        => Utils::defaultString($runtime->noProxy, $this->_noProxy),
            'socks5Proxy'    => Utils::defaultString($runtime->socks5Proxy, $this->_socks5Proxy),
            'socks5NetWork'  => Utils::defaultString($runtime->socks5NetWork, $this->_socks5NetWork),
            'maxIdleConns'   => Utils::defaultNumber($runtime->maxIdleConns, $this->_maxIdleConns),
            'retry'          => [
                'retryable'   => $runtime->autoretry,
                'maxAttempts' => Utils::defaultNumber($runtime->maxAttempts, 3),
            ],
            'backoff' => [
                'policy' => Utils::defaultString($runtime->backoffPolicy, 'no'),
                'period' => Utils::defaultNumber($runtime->backoffPeriod, 1),
            ],
            'ignoreSSL' => $runtime->ignoreSSL,
        ];
        $_lastRequest   = null;
        $_lastException = null;
        $_now           = time();
        $_retryTimes    = 0;
        while (Tea::allowRetry(@$_runtime['retry'], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime(@$_runtime['backoff'], $_retryTimes);
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
                $reqBody            = XML::toXML($request->body->toMap());
                $_request->protocol = $this->_protocol;
                $_request->method   = 'POST';
                $_request->pathname = '/?delete';
                $_request->headers  = Tea::merge([
                    'host'       => OSSUtils::getHost($request->bucketName, $this->_regionId, $this->_endpoint, $this->_hostModel),
                    'date'       => Utils::getDateUTCString(),
                    'user-agent' => $this->getUserAgent(),
                ], Utils::stringifyMapValue($request->header->toMap()));
                if (!Utils::empty_($token)) {
                    $_request->headers['x-oss-security-token'] = $token;
                }
                $_request->body = $reqBody;
                if (!Utils::isUnset($request->header) && !Utils::empty_($request->header->contentMD5)) {
                    $_request->headers['content-md5'] = $request->header->contentMD5;
                } else {
                    $_request->headers['content-md5'] = OSSUtils::getContentMD5($reqBody, $this->_isEnableMD5);
                }
                $_request->headers['authorization'] = OSSUtils::getSignature($_request, $request->bucketName, $accessKeyId, $accessKeySecret, $this->_signatureVersion, $this->_addtionalHeaders);
                $_lastRequest                       = $_request;
                $_response                          = Tea::send($_request, $_runtime);
                $respMap                            = null;
                $bodyStr                            = null;
                if (Utils::is4xx($_response->statusCode) || Utils::is5xx($_response->statusCode)) {
                    $bodyStr = Utils::readAsString($_response->body);
                    $respMap = OSSUtils::getErrMessage($bodyStr);

                    throw new TeaError([
                        'code'    => @$respMap['Code'],
                        'message' => @$respMap['Message'],
                        'data'    => [
                            'httpCode'  => $_response->statusCode,
                            'requestId' => @$respMap['RequestId'],
                            'hostId'    => @$respMap['HostId'],
                        ],
                    ]);
                }
                $bodyStr = Utils::readAsString($_response->body);
                $respMap = XML::parseXml($bodyStr, DeleteMultipleObjectsResponse::class);

                return DeleteMultipleObjectsResponse::fromMap(Tea::merge([
                    'DeleteResult' => @$respMap['DeleteResult'],
                ], $_response->headers));
            } catch (Exception $e) {
                if (!($e instanceof TeaError)) {
                    $e = new TeaError([], $e->getMessage(), $e->getCode(), $e);
                }
                if (Tea::isRetryable($e)) {
                    $_lastException = $e;

                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest, $_lastException);
    }

    /**
     * @param PutBucketRefererRequest $request
     * @param RuntimeOptions          $runtime
     *
     * @throws TeaError
     * @throws Exception
     * @throws TeaUnableRetryError
     *
     * @return PutBucketRefererResponse
     */
    public function putBucketReferer($request, $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime = [
            'timeouted'      => 'retry',
            'readTimeout'    => Utils::defaultNumber($runtime->readTimeout, $this->_readTimeout),
            'connectTimeout' => Utils::defaultNumber($runtime->connectTimeout, $this->_connectTimeout),
            'localAddr'      => Utils::defaultString($runtime->localAddr, $this->_localAddr),
            'httpProxy'      => Utils::defaultString($runtime->httpProxy, $this->_httpProxy),
            'httpsProxy'     => Utils::defaultString($runtime->httpsProxy, $this->_httpsProxy),
            'noProxy'        => Utils::defaultString($runtime->noProxy, $this->_noProxy),
            'socks5Proxy'    => Utils::defaultString($runtime->socks5Proxy, $this->_socks5Proxy),
            'socks5NetWork'  => Utils::defaultString($runtime->socks5NetWork, $this->_socks5NetWork),
            'maxIdleConns'   => Utils::defaultNumber($runtime->maxIdleConns, $this->_maxIdleConns),
            'retry'          => [
                'retryable'   => $runtime->autoretry,
                'maxAttempts' => Utils::defaultNumber($runtime->maxAttempts, 3),
            ],
            'backoff' => [
                'policy' => Utils::defaultString($runtime->backoffPolicy, 'no'),
                'period' => Utils::defaultNumber($runtime->backoffPeriod, 1),
            ],
            'ignoreSSL' => $runtime->ignoreSSL,
        ];
        $_lastRequest   = null;
        $_lastException = null;
        $_now           = time();
        $_retryTimes    = 0;
        while (Tea::allowRetry(@$_runtime['retry'], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime(@$_runtime['backoff'], $_retryTimes);
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
                $reqBody            = XML::toXML($request->body->toMap());
                $_request->protocol = $this->_protocol;
                $_request->method   = 'PUT';
                $_request->pathname = '/?referer';
                $_request->headers  = [
                    'host'       => OSSUtils::getHost($request->bucketName, $this->_regionId, $this->_endpoint, $this->_hostModel),
                    'date'       => Utils::getDateUTCString(),
                    'user-agent' => $this->getUserAgent(),
                ];
                if (!Utils::empty_($token)) {
                    $_request->headers['x-oss-security-token'] = $token;
                }
                $_request->body                     = $reqBody;
                $_request->headers['authorization'] = OSSUtils::getSignature($_request, $request->bucketName, $accessKeyId, $accessKeySecret, $this->_signatureVersion, $this->_addtionalHeaders);
                $_lastRequest                       = $_request;
                $_response                          = Tea::send($_request, $_runtime);
                $respMap                            = null;
                $bodyStr                            = null;
                if (Utils::is4xx($_response->statusCode) || Utils::is5xx($_response->statusCode)) {
                    $bodyStr = Utils::readAsString($_response->body);
                    $respMap = OSSUtils::getErrMessage($bodyStr);

                    throw new TeaError([
                        'code'    => @$respMap['Code'],
                        'message' => @$respMap['Message'],
                        'data'    => [
                            'httpCode'  => $_response->statusCode,
                            'requestId' => @$respMap['RequestId'],
                            'hostId'    => @$respMap['HostId'],
                        ],
                    ]);
                }

                return PutBucketRefererResponse::fromMap(Tea::merge($_response->headers));
            } catch (Exception $e) {
                if (!($e instanceof TeaError)) {
                    $e = new TeaError([], $e->getMessage(), $e->getCode(), $e);
                }
                if (Tea::isRetryable($e)) {
                    $_lastException = $e;

                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest, $_lastException);
    }

    /**
     * @param PutBucketWebsiteRequest $request
     * @param RuntimeOptions          $runtime
     *
     * @throws TeaError
     * @throws Exception
     * @throws TeaUnableRetryError
     *
     * @return PutBucketWebsiteResponse
     */
    public function putBucketWebsite($request, $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime = [
            'timeouted'      => 'retry',
            'readTimeout'    => Utils::defaultNumber($runtime->readTimeout, $this->_readTimeout),
            'connectTimeout' => Utils::defaultNumber($runtime->connectTimeout, $this->_connectTimeout),
            'localAddr'      => Utils::defaultString($runtime->localAddr, $this->_localAddr),
            'httpProxy'      => Utils::defaultString($runtime->httpProxy, $this->_httpProxy),
            'httpsProxy'     => Utils::defaultString($runtime->httpsProxy, $this->_httpsProxy),
            'noProxy'        => Utils::defaultString($runtime->noProxy, $this->_noProxy),
            'socks5Proxy'    => Utils::defaultString($runtime->socks5Proxy, $this->_socks5Proxy),
            'socks5NetWork'  => Utils::defaultString($runtime->socks5NetWork, $this->_socks5NetWork),
            'maxIdleConns'   => Utils::defaultNumber($runtime->maxIdleConns, $this->_maxIdleConns),
            'retry'          => [
                'retryable'   => $runtime->autoretry,
                'maxAttempts' => Utils::defaultNumber($runtime->maxAttempts, 3),
            ],
            'backoff' => [
                'policy' => Utils::defaultString($runtime->backoffPolicy, 'no'),
                'period' => Utils::defaultNumber($runtime->backoffPeriod, 1),
            ],
            'ignoreSSL' => $runtime->ignoreSSL,
        ];
        $_lastRequest   = null;
        $_lastException = null;
        $_now           = time();
        $_retryTimes    = 0;
        while (Tea::allowRetry(@$_runtime['retry'], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime(@$_runtime['backoff'], $_retryTimes);
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
                $reqBody            = XML::toXML($request->body->toMap());
                $_request->protocol = $this->_protocol;
                $_request->method   = 'PUT';
                $_request->pathname = '/?website';
                $_request->headers  = [
                    'host'       => OSSUtils::getHost($request->bucketName, $this->_regionId, $this->_endpoint, $this->_hostModel),
                    'date'       => Utils::getDateUTCString(),
                    'user-agent' => $this->getUserAgent(),
                ];
                if (!Utils::empty_($token)) {
                    $_request->headers['x-oss-security-token'] = $token;
                }
                $_request->body                     = $reqBody;
                $_request->headers['authorization'] = OSSUtils::getSignature($_request, $request->bucketName, $accessKeyId, $accessKeySecret, $this->_signatureVersion, $this->_addtionalHeaders);
                $_lastRequest                       = $_request;
                $_response                          = Tea::send($_request, $_runtime);
                $respMap                            = null;
                $bodyStr                            = null;
                if (Utils::is4xx($_response->statusCode) || Utils::is5xx($_response->statusCode)) {
                    $bodyStr = Utils::readAsString($_response->body);
                    $respMap = OSSUtils::getErrMessage($bodyStr);

                    throw new TeaError([
                        'code'    => @$respMap['Code'],
                        'message' => @$respMap['Message'],
                        'data'    => [
                            'httpCode'  => $_response->statusCode,
                            'requestId' => @$respMap['RequestId'],
                            'hostId'    => @$respMap['HostId'],
                        ],
                    ]);
                }

                return PutBucketWebsiteResponse::fromMap(Tea::merge($_response->headers));
            } catch (Exception $e) {
                if (!($e instanceof TeaError)) {
                    $e = new TeaError([], $e->getMessage(), $e->getCode(), $e);
                }
                if (Tea::isRetryable($e)) {
                    $_lastException = $e;

                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest, $_lastException);
    }

    /**
     * @param CompleteMultipartUploadRequest $request
     * @param RuntimeOptions                 $runtime
     *
     * @throws TeaError
     * @throws Exception
     * @throws TeaUnableRetryError
     *
     * @return CompleteMultipartUploadResponse
     */
    public function completeMultipartUpload($request, $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime = [
            'timeouted'      => 'retry',
            'readTimeout'    => Utils::defaultNumber($runtime->readTimeout, $this->_readTimeout),
            'connectTimeout' => Utils::defaultNumber($runtime->connectTimeout, $this->_connectTimeout),
            'localAddr'      => Utils::defaultString($runtime->localAddr, $this->_localAddr),
            'httpProxy'      => Utils::defaultString($runtime->httpProxy, $this->_httpProxy),
            'httpsProxy'     => Utils::defaultString($runtime->httpsProxy, $this->_httpsProxy),
            'noProxy'        => Utils::defaultString($runtime->noProxy, $this->_noProxy),
            'socks5Proxy'    => Utils::defaultString($runtime->socks5Proxy, $this->_socks5Proxy),
            'socks5NetWork'  => Utils::defaultString($runtime->socks5NetWork, $this->_socks5NetWork),
            'maxIdleConns'   => Utils::defaultNumber($runtime->maxIdleConns, $this->_maxIdleConns),
            'retry'          => [
                'retryable'   => $runtime->autoretry,
                'maxAttempts' => Utils::defaultNumber($runtime->maxAttempts, 3),
            ],
            'backoff' => [
                'policy' => Utils::defaultString($runtime->backoffPolicy, 'no'),
                'period' => Utils::defaultNumber($runtime->backoffPeriod, 1),
            ],
            'ignoreSSL' => $runtime->ignoreSSL,
        ];
        $_lastRequest   = null;
        $_lastException = null;
        $_now           = time();
        $_retryTimes    = 0;
        while (Tea::allowRetry(@$_runtime['retry'], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime(@$_runtime['backoff'], $_retryTimes);
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
                $reqBody            = XML::toXML($request->body->toMap());
                $_request->protocol = $this->_protocol;
                $_request->method   = 'POST';
                $_request->pathname = '/' . $request->objectName . '';
                $_request->headers  = [
                    'host'       => OSSUtils::getHost($request->bucketName, $this->_regionId, $this->_endpoint, $this->_hostModel),
                    'date'       => Utils::getDateUTCString(),
                    'user-agent' => $this->getUserAgent(),
                ];
                if (!Utils::empty_($token)) {
                    $_request->headers['x-oss-security-token'] = $token;
                }
                $_request->query                    = Utils::stringifyMapValue($request->filter->toMap());
                $_request->body                     = $reqBody;
                $_request->headers['authorization'] = OSSUtils::getSignature($_request, $request->bucketName, $accessKeyId, $accessKeySecret, $this->_signatureVersion, $this->_addtionalHeaders);
                $_lastRequest                       = $_request;
                $_response                          = Tea::send($_request, $_runtime);
                $respMap                            = null;
                $bodyStr                            = null;
                if (Utils::is4xx($_response->statusCode) || Utils::is5xx($_response->statusCode)) {
                    $bodyStr = Utils::readAsString($_response->body);
                    $respMap = OSSUtils::getErrMessage($bodyStr);

                    throw new TeaError([
                        'code'    => @$respMap['Code'],
                        'message' => @$respMap['Message'],
                        'data'    => [
                            'httpCode'  => $_response->statusCode,
                            'requestId' => @$respMap['RequestId'],
                            'hostId'    => @$respMap['HostId'],
                        ],
                    ]);
                }
                $bodyStr = Utils::readAsString($_response->body);
                $respMap = XML::parseXml($bodyStr, CompleteMultipartUploadResponse::class);

                return CompleteMultipartUploadResponse::fromMap(Tea::merge([
                    'CompleteMultipartUploadResult' => @$respMap['CompleteMultipartUploadResult'],
                ], $_response->headers));
            } catch (Exception $e) {
                if (!($e instanceof TeaError)) {
                    $e = new TeaError([], $e->getMessage(), $e->getCode(), $e);
                }
                if (Tea::isRetryable($e)) {
                    $_lastException = $e;

                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest, $_lastException);
    }

    /**
     * @param PutBucketLoggingRequest $request
     * @param RuntimeOptions          $runtime
     *
     * @throws TeaError
     * @throws Exception
     * @throws TeaUnableRetryError
     *
     * @return PutBucketLoggingResponse
     */
    public function putBucketLogging($request, $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime = [
            'timeouted'      => 'retry',
            'readTimeout'    => Utils::defaultNumber($runtime->readTimeout, $this->_readTimeout),
            'connectTimeout' => Utils::defaultNumber($runtime->connectTimeout, $this->_connectTimeout),
            'localAddr'      => Utils::defaultString($runtime->localAddr, $this->_localAddr),
            'httpProxy'      => Utils::defaultString($runtime->httpProxy, $this->_httpProxy),
            'httpsProxy'     => Utils::defaultString($runtime->httpsProxy, $this->_httpsProxy),
            'noProxy'        => Utils::defaultString($runtime->noProxy, $this->_noProxy),
            'socks5Proxy'    => Utils::defaultString($runtime->socks5Proxy, $this->_socks5Proxy),
            'socks5NetWork'  => Utils::defaultString($runtime->socks5NetWork, $this->_socks5NetWork),
            'maxIdleConns'   => Utils::defaultNumber($runtime->maxIdleConns, $this->_maxIdleConns),
            'retry'          => [
                'retryable'   => $runtime->autoretry,
                'maxAttempts' => Utils::defaultNumber($runtime->maxAttempts, 3),
            ],
            'backoff' => [
                'policy' => Utils::defaultString($runtime->backoffPolicy, 'no'),
                'period' => Utils::defaultNumber($runtime->backoffPeriod, 1),
            ],
            'ignoreSSL' => $runtime->ignoreSSL,
        ];
        $_lastRequest   = null;
        $_lastException = null;
        $_now           = time();
        $_retryTimes    = 0;
        while (Tea::allowRetry(@$_runtime['retry'], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime(@$_runtime['backoff'], $_retryTimes);
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
                $reqBody            = XML::toXML($request->body->toMap());
                $_request->protocol = $this->_protocol;
                $_request->method   = 'PUT';
                $_request->pathname = '/?logging';
                $_request->headers  = [
                    'host'       => OSSUtils::getHost($request->bucketName, $this->_regionId, $this->_endpoint, $this->_hostModel),
                    'date'       => Utils::getDateUTCString(),
                    'user-agent' => $this->getUserAgent(),
                ];
                if (!Utils::empty_($token)) {
                    $_request->headers['x-oss-security-token'] = $token;
                }
                $_request->body                     = $reqBody;
                $_request->headers['authorization'] = OSSUtils::getSignature($_request, $request->bucketName, $accessKeyId, $accessKeySecret, $this->_signatureVersion, $this->_addtionalHeaders);
                $_lastRequest                       = $_request;
                $_response                          = Tea::send($_request, $_runtime);
                $respMap                            = null;
                $bodyStr                            = null;
                if (Utils::is4xx($_response->statusCode) || Utils::is5xx($_response->statusCode)) {
                    $bodyStr = Utils::readAsString($_response->body);
                    $respMap = OSSUtils::getErrMessage($bodyStr);

                    throw new TeaError([
                        'code'    => @$respMap['Code'],
                        'message' => @$respMap['Message'],
                        'data'    => [
                            'httpCode'  => $_response->statusCode,
                            'requestId' => @$respMap['RequestId'],
                            'hostId'    => @$respMap['HostId'],
                        ],
                    ]);
                }

                return PutBucketLoggingResponse::fromMap(Tea::merge($_response->headers));
            } catch (Exception $e) {
                if (!($e instanceof TeaError)) {
                    $e = new TeaError([], $e->getMessage(), $e->getCode(), $e);
                }
                if (Tea::isRetryable($e)) {
                    $_lastException = $e;

                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest, $_lastException);
    }

    /**
     * @param PutBucketRequestPaymentRequest $request
     * @param RuntimeOptions                 $runtime
     *
     * @throws TeaError
     * @throws Exception
     * @throws TeaUnableRetryError
     *
     * @return PutBucketRequestPaymentResponse
     */
    public function putBucketRequestPayment($request, $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime = [
            'timeouted'      => 'retry',
            'readTimeout'    => Utils::defaultNumber($runtime->readTimeout, $this->_readTimeout),
            'connectTimeout' => Utils::defaultNumber($runtime->connectTimeout, $this->_connectTimeout),
            'localAddr'      => Utils::defaultString($runtime->localAddr, $this->_localAddr),
            'httpProxy'      => Utils::defaultString($runtime->httpProxy, $this->_httpProxy),
            'httpsProxy'     => Utils::defaultString($runtime->httpsProxy, $this->_httpsProxy),
            'noProxy'        => Utils::defaultString($runtime->noProxy, $this->_noProxy),
            'socks5Proxy'    => Utils::defaultString($runtime->socks5Proxy, $this->_socks5Proxy),
            'socks5NetWork'  => Utils::defaultString($runtime->socks5NetWork, $this->_socks5NetWork),
            'maxIdleConns'   => Utils::defaultNumber($runtime->maxIdleConns, $this->_maxIdleConns),
            'retry'          => [
                'retryable'   => $runtime->autoretry,
                'maxAttempts' => Utils::defaultNumber($runtime->maxAttempts, 3),
            ],
            'backoff' => [
                'policy' => Utils::defaultString($runtime->backoffPolicy, 'no'),
                'period' => Utils::defaultNumber($runtime->backoffPeriod, 1),
            ],
            'ignoreSSL' => $runtime->ignoreSSL,
        ];
        $_lastRequest   = null;
        $_lastException = null;
        $_now           = time();
        $_retryTimes    = 0;
        while (Tea::allowRetry(@$_runtime['retry'], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime(@$_runtime['backoff'], $_retryTimes);
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
                $reqBody            = XML::toXML($request->body->toMap());
                $_request->protocol = $this->_protocol;
                $_request->method   = 'PUT';
                $_request->pathname = '/?requestPayment';
                $_request->headers  = [
                    'host'       => OSSUtils::getHost($request->bucketName, $this->_regionId, $this->_endpoint, $this->_hostModel),
                    'date'       => Utils::getDateUTCString(),
                    'user-agent' => $this->getUserAgent(),
                ];
                if (!Utils::empty_($token)) {
                    $_request->headers['x-oss-security-token'] = $token;
                }
                $_request->body                     = $reqBody;
                $_request->headers['authorization'] = OSSUtils::getSignature($_request, $request->bucketName, $accessKeyId, $accessKeySecret, $this->_signatureVersion, $this->_addtionalHeaders);
                $_lastRequest                       = $_request;
                $_response                          = Tea::send($_request, $_runtime);
                $respMap                            = null;
                $bodyStr                            = null;
                if (Utils::is4xx($_response->statusCode) || Utils::is5xx($_response->statusCode)) {
                    $bodyStr = Utils::readAsString($_response->body);
                    $respMap = OSSUtils::getErrMessage($bodyStr);

                    throw new TeaError([
                        'code'    => @$respMap['Code'],
                        'message' => @$respMap['Message'],
                        'data'    => [
                            'httpCode'  => $_response->statusCode,
                            'requestId' => @$respMap['RequestId'],
                            'hostId'    => @$respMap['HostId'],
                        ],
                    ]);
                }

                return PutBucketRequestPaymentResponse::fromMap(Tea::merge($_response->headers));
            } catch (Exception $e) {
                if (!($e instanceof TeaError)) {
                    $e = new TeaError([], $e->getMessage(), $e->getCode(), $e);
                }
                if (Tea::isRetryable($e)) {
                    $_lastException = $e;

                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest, $_lastException);
    }

    /**
     * @param PutBucketEncryptionRequest $request
     * @param RuntimeOptions             $runtime
     *
     * @throws TeaError
     * @throws Exception
     * @throws TeaUnableRetryError
     *
     * @return PutBucketEncryptionResponse
     */
    public function putBucketEncryption($request, $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime = [
            'timeouted'      => 'retry',
            'readTimeout'    => Utils::defaultNumber($runtime->readTimeout, $this->_readTimeout),
            'connectTimeout' => Utils::defaultNumber($runtime->connectTimeout, $this->_connectTimeout),
            'localAddr'      => Utils::defaultString($runtime->localAddr, $this->_localAddr),
            'httpProxy'      => Utils::defaultString($runtime->httpProxy, $this->_httpProxy),
            'httpsProxy'     => Utils::defaultString($runtime->httpsProxy, $this->_httpsProxy),
            'noProxy'        => Utils::defaultString($runtime->noProxy, $this->_noProxy),
            'socks5Proxy'    => Utils::defaultString($runtime->socks5Proxy, $this->_socks5Proxy),
            'socks5NetWork'  => Utils::defaultString($runtime->socks5NetWork, $this->_socks5NetWork),
            'maxIdleConns'   => Utils::defaultNumber($runtime->maxIdleConns, $this->_maxIdleConns),
            'retry'          => [
                'retryable'   => $runtime->autoretry,
                'maxAttempts' => Utils::defaultNumber($runtime->maxAttempts, 3),
            ],
            'backoff' => [
                'policy' => Utils::defaultString($runtime->backoffPolicy, 'no'),
                'period' => Utils::defaultNumber($runtime->backoffPeriod, 1),
            ],
            'ignoreSSL' => $runtime->ignoreSSL,
        ];
        $_lastRequest   = null;
        $_lastException = null;
        $_now           = time();
        $_retryTimes    = 0;
        while (Tea::allowRetry(@$_runtime['retry'], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime(@$_runtime['backoff'], $_retryTimes);
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
                $reqBody            = XML::toXML($request->body->toMap());
                $_request->protocol = $this->_protocol;
                $_request->method   = 'PUT';
                $_request->pathname = '/?encryption';
                $_request->headers  = [
                    'host'       => OSSUtils::getHost($request->bucketName, $this->_regionId, $this->_endpoint, $this->_hostModel),
                    'date'       => Utils::getDateUTCString(),
                    'user-agent' => $this->getUserAgent(),
                ];
                if (!Utils::empty_($token)) {
                    $_request->headers['x-oss-security-token'] = $token;
                }
                $_request->body                     = $reqBody;
                $_request->headers['authorization'] = OSSUtils::getSignature($_request, $request->bucketName, $accessKeyId, $accessKeySecret, $this->_signatureVersion, $this->_addtionalHeaders);
                $_lastRequest                       = $_request;
                $_response                          = Tea::send($_request, $_runtime);
                $respMap                            = null;
                $bodyStr                            = null;
                if (Utils::is4xx($_response->statusCode) || Utils::is5xx($_response->statusCode)) {
                    $bodyStr = Utils::readAsString($_response->body);
                    $respMap = OSSUtils::getErrMessage($bodyStr);

                    throw new TeaError([
                        'code'    => @$respMap['Code'],
                        'message' => @$respMap['Message'],
                        'data'    => [
                            'httpCode'  => $_response->statusCode,
                            'requestId' => @$respMap['RequestId'],
                            'hostId'    => @$respMap['HostId'],
                        ],
                    ]);
                }

                return PutBucketEncryptionResponse::fromMap(Tea::merge($_response->headers));
            } catch (Exception $e) {
                if (!($e instanceof TeaError)) {
                    $e = new TeaError([], $e->getMessage(), $e->getCode(), $e);
                }
                if (Tea::isRetryable($e)) {
                    $_lastException = $e;

                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest, $_lastException);
    }

    /**
     * @param PutLiveChannelRequest $request
     * @param RuntimeOptions        $runtime
     *
     * @throws TeaError
     * @throws Exception
     * @throws TeaUnableRetryError
     *
     * @return PutLiveChannelResponse
     */
    public function putLiveChannel($request, $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime = [
            'timeouted'      => 'retry',
            'readTimeout'    => Utils::defaultNumber($runtime->readTimeout, $this->_readTimeout),
            'connectTimeout' => Utils::defaultNumber($runtime->connectTimeout, $this->_connectTimeout),
            'localAddr'      => Utils::defaultString($runtime->localAddr, $this->_localAddr),
            'httpProxy'      => Utils::defaultString($runtime->httpProxy, $this->_httpProxy),
            'httpsProxy'     => Utils::defaultString($runtime->httpsProxy, $this->_httpsProxy),
            'noProxy'        => Utils::defaultString($runtime->noProxy, $this->_noProxy),
            'socks5Proxy'    => Utils::defaultString($runtime->socks5Proxy, $this->_socks5Proxy),
            'socks5NetWork'  => Utils::defaultString($runtime->socks5NetWork, $this->_socks5NetWork),
            'maxIdleConns'   => Utils::defaultNumber($runtime->maxIdleConns, $this->_maxIdleConns),
            'retry'          => [
                'retryable'   => $runtime->autoretry,
                'maxAttempts' => Utils::defaultNumber($runtime->maxAttempts, 3),
            ],
            'backoff' => [
                'policy' => Utils::defaultString($runtime->backoffPolicy, 'no'),
                'period' => Utils::defaultNumber($runtime->backoffPeriod, 1),
            ],
            'ignoreSSL' => $runtime->ignoreSSL,
        ];
        $_lastRequest   = null;
        $_lastException = null;
        $_now           = time();
        $_retryTimes    = 0;
        while (Tea::allowRetry(@$_runtime['retry'], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime(@$_runtime['backoff'], $_retryTimes);
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
                $reqBody            = XML::toXML($request->body->toMap());
                $_request->protocol = $this->_protocol;
                $_request->method   = 'PUT';
                $_request->pathname = '/' . $request->channelName . '?live';
                $_request->headers  = [
                    'host'       => OSSUtils::getHost($request->bucketName, $this->_regionId, $this->_endpoint, $this->_hostModel),
                    'date'       => Utils::getDateUTCString(),
                    'user-agent' => $this->getUserAgent(),
                ];
                if (!Utils::empty_($token)) {
                    $_request->headers['x-oss-security-token'] = $token;
                }
                $_request->body                     = $reqBody;
                $_request->headers['authorization'] = OSSUtils::getSignature($_request, $request->bucketName, $accessKeyId, $accessKeySecret, $this->_signatureVersion, $this->_addtionalHeaders);
                $_lastRequest                       = $_request;
                $_response                          = Tea::send($_request, $_runtime);
                $respMap                            = null;
                $bodyStr                            = null;
                if (Utils::is4xx($_response->statusCode) || Utils::is5xx($_response->statusCode)) {
                    $bodyStr = Utils::readAsString($_response->body);
                    $respMap = OSSUtils::getErrMessage($bodyStr);

                    throw new TeaError([
                        'code'    => @$respMap['Code'],
                        'message' => @$respMap['Message'],
                        'data'    => [
                            'httpCode'  => $_response->statusCode,
                            'requestId' => @$respMap['RequestId'],
                            'hostId'    => @$respMap['HostId'],
                        ],
                    ]);
                }
                $bodyStr = Utils::readAsString($_response->body);
                $respMap = XML::parseXml($bodyStr, PutLiveChannelResponse::class);

                return PutLiveChannelResponse::fromMap(Tea::merge([
                    'CreateLiveChannelResult' => @$respMap['CreateLiveChannelResult'],
                ], $_response->headers));
            } catch (Exception $e) {
                if (!($e instanceof TeaError)) {
                    $e = new TeaError([], $e->getMessage(), $e->getCode(), $e);
                }
                if (Tea::isRetryable($e)) {
                    $_lastException = $e;

                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest, $_lastException);
    }

    /**
     * @param PutBucketTagsRequest $request
     * @param RuntimeOptions       $runtime
     *
     * @throws TeaError
     * @throws Exception
     * @throws TeaUnableRetryError
     *
     * @return PutBucketTagsResponse
     */
    public function putBucketTags($request, $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime = [
            'timeouted'      => 'retry',
            'readTimeout'    => Utils::defaultNumber($runtime->readTimeout, $this->_readTimeout),
            'connectTimeout' => Utils::defaultNumber($runtime->connectTimeout, $this->_connectTimeout),
            'localAddr'      => Utils::defaultString($runtime->localAddr, $this->_localAddr),
            'httpProxy'      => Utils::defaultString($runtime->httpProxy, $this->_httpProxy),
            'httpsProxy'     => Utils::defaultString($runtime->httpsProxy, $this->_httpsProxy),
            'noProxy'        => Utils::defaultString($runtime->noProxy, $this->_noProxy),
            'socks5Proxy'    => Utils::defaultString($runtime->socks5Proxy, $this->_socks5Proxy),
            'socks5NetWork'  => Utils::defaultString($runtime->socks5NetWork, $this->_socks5NetWork),
            'maxIdleConns'   => Utils::defaultNumber($runtime->maxIdleConns, $this->_maxIdleConns),
            'retry'          => [
                'retryable'   => $runtime->autoretry,
                'maxAttempts' => Utils::defaultNumber($runtime->maxAttempts, 3),
            ],
            'backoff' => [
                'policy' => Utils::defaultString($runtime->backoffPolicy, 'no'),
                'period' => Utils::defaultNumber($runtime->backoffPeriod, 1),
            ],
            'ignoreSSL' => $runtime->ignoreSSL,
        ];
        $_lastRequest   = null;
        $_lastException = null;
        $_now           = time();
        $_retryTimes    = 0;
        while (Tea::allowRetry(@$_runtime['retry'], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime(@$_runtime['backoff'], $_retryTimes);
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
                $reqBody            = XML::toXML($request->body->toMap());
                $_request->protocol = $this->_protocol;
                $_request->method   = 'PUT';
                $_request->pathname = '/?tagging';
                $_request->headers  = [
                    'host'       => OSSUtils::getHost($request->bucketName, $this->_regionId, $this->_endpoint, $this->_hostModel),
                    'date'       => Utils::getDateUTCString(),
                    'user-agent' => $this->getUserAgent(),
                ];
                if (!Utils::empty_($token)) {
                    $_request->headers['x-oss-security-token'] = $token;
                }
                $_request->body                     = $reqBody;
                $_request->headers['authorization'] = OSSUtils::getSignature($_request, $request->bucketName, $accessKeyId, $accessKeySecret, $this->_signatureVersion, $this->_addtionalHeaders);
                $_lastRequest                       = $_request;
                $_response                          = Tea::send($_request, $_runtime);
                $respMap                            = null;
                $bodyStr                            = null;
                if (Utils::is4xx($_response->statusCode) || Utils::is5xx($_response->statusCode)) {
                    $bodyStr = Utils::readAsString($_response->body);
                    $respMap = OSSUtils::getErrMessage($bodyStr);

                    throw new TeaError([
                        'code'    => @$respMap['Code'],
                        'message' => @$respMap['Message'],
                        'data'    => [
                            'httpCode'  => $_response->statusCode,
                            'requestId' => @$respMap['RequestId'],
                            'hostId'    => @$respMap['HostId'],
                        ],
                    ]);
                }

                return PutBucketTagsResponse::fromMap(Tea::merge($_response->headers));
            } catch (Exception $e) {
                if (!($e instanceof TeaError)) {
                    $e = new TeaError([], $e->getMessage(), $e->getCode(), $e);
                }
                if (Tea::isRetryable($e)) {
                    $_lastException = $e;

                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest, $_lastException);
    }

    /**
     * @param PutObjectTaggingRequest $request
     * @param RuntimeOptions          $runtime
     *
     * @throws TeaError
     * @throws Exception
     * @throws TeaUnableRetryError
     *
     * @return PutObjectTaggingResponse
     */
    public function putObjectTagging($request, $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime = [
            'timeouted'      => 'retry',
            'readTimeout'    => Utils::defaultNumber($runtime->readTimeout, $this->_readTimeout),
            'connectTimeout' => Utils::defaultNumber($runtime->connectTimeout, $this->_connectTimeout),
            'localAddr'      => Utils::defaultString($runtime->localAddr, $this->_localAddr),
            'httpProxy'      => Utils::defaultString($runtime->httpProxy, $this->_httpProxy),
            'httpsProxy'     => Utils::defaultString($runtime->httpsProxy, $this->_httpsProxy),
            'noProxy'        => Utils::defaultString($runtime->noProxy, $this->_noProxy),
            'socks5Proxy'    => Utils::defaultString($runtime->socks5Proxy, $this->_socks5Proxy),
            'socks5NetWork'  => Utils::defaultString($runtime->socks5NetWork, $this->_socks5NetWork),
            'maxIdleConns'   => Utils::defaultNumber($runtime->maxIdleConns, $this->_maxIdleConns),
            'retry'          => [
                'retryable'   => $runtime->autoretry,
                'maxAttempts' => Utils::defaultNumber($runtime->maxAttempts, 3),
            ],
            'backoff' => [
                'policy' => Utils::defaultString($runtime->backoffPolicy, 'no'),
                'period' => Utils::defaultNumber($runtime->backoffPeriod, 1),
            ],
            'ignoreSSL' => $runtime->ignoreSSL,
        ];
        $_lastRequest   = null;
        $_lastException = null;
        $_now           = time();
        $_retryTimes    = 0;
        while (Tea::allowRetry(@$_runtime['retry'], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime(@$_runtime['backoff'], $_retryTimes);
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
                $reqBody            = XML::toXML($request->body->toMap());
                $_request->protocol = $this->_protocol;
                $_request->method   = 'PUT';
                $_request->pathname = '/' . $request->objectName . '?tagging';
                $_request->headers  = [
                    'host'       => OSSUtils::getHost($request->bucketName, $this->_regionId, $this->_endpoint, $this->_hostModel),
                    'date'       => Utils::getDateUTCString(),
                    'user-agent' => $this->getUserAgent(),
                ];
                if (!Utils::empty_($token)) {
                    $_request->headers['x-oss-security-token'] = $token;
                }
                $_request->body                     = $reqBody;
                $_request->headers['authorization'] = OSSUtils::getSignature($_request, $request->bucketName, $accessKeyId, $accessKeySecret, $this->_signatureVersion, $this->_addtionalHeaders);
                $_lastRequest                       = $_request;
                $_response                          = Tea::send($_request, $_runtime);
                $respMap                            = null;
                $bodyStr                            = null;
                if (Utils::is4xx($_response->statusCode) || Utils::is5xx($_response->statusCode)) {
                    $bodyStr = Utils::readAsString($_response->body);
                    $respMap = OSSUtils::getErrMessage($bodyStr);

                    throw new TeaError([
                        'code'    => @$respMap['Code'],
                        'message' => @$respMap['Message'],
                        'data'    => [
                            'httpCode'  => $_response->statusCode,
                            'requestId' => @$respMap['RequestId'],
                            'hostId'    => @$respMap['HostId'],
                        ],
                    ]);
                }

                return PutObjectTaggingResponse::fromMap(Tea::merge($_response->headers));
            } catch (Exception $e) {
                if (!($e instanceof TeaError)) {
                    $e = new TeaError([], $e->getMessage(), $e->getCode(), $e);
                }
                if (Tea::isRetryable($e)) {
                    $_lastException = $e;

                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest, $_lastException);
    }

    /**
     * @param SelectObjectRequest $request
     * @param RuntimeOptions      $runtime
     *
     * @throws TeaError
     * @throws Exception
     * @throws TeaUnableRetryError
     *
     * @return SelectObjectResponse
     */
    public function selectObject($request, $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime = [
            'timeouted'      => 'retry',
            'readTimeout'    => Utils::defaultNumber($runtime->readTimeout, $this->_readTimeout),
            'connectTimeout' => Utils::defaultNumber($runtime->connectTimeout, $this->_connectTimeout),
            'localAddr'      => Utils::defaultString($runtime->localAddr, $this->_localAddr),
            'httpProxy'      => Utils::defaultString($runtime->httpProxy, $this->_httpProxy),
            'httpsProxy'     => Utils::defaultString($runtime->httpsProxy, $this->_httpsProxy),
            'noProxy'        => Utils::defaultString($runtime->noProxy, $this->_noProxy),
            'socks5Proxy'    => Utils::defaultString($runtime->socks5Proxy, $this->_socks5Proxy),
            'socks5NetWork'  => Utils::defaultString($runtime->socks5NetWork, $this->_socks5NetWork),
            'maxIdleConns'   => Utils::defaultNumber($runtime->maxIdleConns, $this->_maxIdleConns),
            'retry'          => [
                'retryable'   => $runtime->autoretry,
                'maxAttempts' => Utils::defaultNumber($runtime->maxAttempts, 3),
            ],
            'backoff' => [
                'policy' => Utils::defaultString($runtime->backoffPolicy, 'no'),
                'period' => Utils::defaultNumber($runtime->backoffPeriod, 1),
            ],
            'ignoreSSL' => $runtime->ignoreSSL,
        ];
        $_lastRequest   = null;
        $_lastException = null;
        $_now           = time();
        $_retryTimes    = 0;
        while (Tea::allowRetry(@$_runtime['retry'], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime(@$_runtime['backoff'], $_retryTimes);
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
                $reqBody            = XML::toXML($request->body->toMap());
                $_request->protocol = $this->_protocol;
                $_request->method   = 'POST';
                $_request->pathname = '/' . $request->objectName . '';
                $_request->headers  = [
                    'host'       => OSSUtils::getHost($request->bucketName, $this->_regionId, $this->_endpoint, $this->_hostModel),
                    'date'       => Utils::getDateUTCString(),
                    'user-agent' => $this->getUserAgent(),
                ];
                if (!Utils::empty_($token)) {
                    $_request->headers['x-oss-security-token'] = $token;
                }
                $_request->query                    = Utils::stringifyMapValue($request->filter->toMap());
                $_request->body                     = $reqBody;
                $_request->headers['authorization'] = OSSUtils::getSignature($_request, $request->bucketName, $accessKeyId, $accessKeySecret, $this->_signatureVersion, $this->_addtionalHeaders);
                $_lastRequest                       = $_request;
                $_response                          = Tea::send($_request, $_runtime);
                $respMap                            = null;
                $bodyStr                            = null;
                if (Utils::is4xx($_response->statusCode) || Utils::is5xx($_response->statusCode)) {
                    $bodyStr = Utils::readAsString($_response->body);
                    $respMap = OSSUtils::getErrMessage($bodyStr);

                    throw new TeaError([
                        'code'    => @$respMap['Code'],
                        'message' => @$respMap['Message'],
                        'data'    => [
                            'httpCode'  => $_response->statusCode,
                            'requestId' => @$respMap['RequestId'],
                            'hostId'    => @$respMap['HostId'],
                        ],
                    ]);
                }

                return SelectObjectResponse::fromMap(Tea::merge($_response->headers));
            } catch (Exception $e) {
                if (!($e instanceof TeaError)) {
                    $e = new TeaError([], $e->getMessage(), $e->getCode(), $e);
                }
                if (Tea::isRetryable($e)) {
                    $_lastException = $e;

                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest, $_lastException);
    }

    /**
     * @param PutBucketCORSRequest $request
     * @param RuntimeOptions       $runtime
     *
     * @throws TeaError
     * @throws Exception
     * @throws TeaUnableRetryError
     *
     * @return PutBucketCORSResponse
     */
    public function putBucketCORS($request, $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime = [
            'timeouted'      => 'retry',
            'readTimeout'    => Utils::defaultNumber($runtime->readTimeout, $this->_readTimeout),
            'connectTimeout' => Utils::defaultNumber($runtime->connectTimeout, $this->_connectTimeout),
            'localAddr'      => Utils::defaultString($runtime->localAddr, $this->_localAddr),
            'httpProxy'      => Utils::defaultString($runtime->httpProxy, $this->_httpProxy),
            'httpsProxy'     => Utils::defaultString($runtime->httpsProxy, $this->_httpsProxy),
            'noProxy'        => Utils::defaultString($runtime->noProxy, $this->_noProxy),
            'socks5Proxy'    => Utils::defaultString($runtime->socks5Proxy, $this->_socks5Proxy),
            'socks5NetWork'  => Utils::defaultString($runtime->socks5NetWork, $this->_socks5NetWork),
            'maxIdleConns'   => Utils::defaultNumber($runtime->maxIdleConns, $this->_maxIdleConns),
            'retry'          => [
                'retryable'   => $runtime->autoretry,
                'maxAttempts' => Utils::defaultNumber($runtime->maxAttempts, 3),
            ],
            'backoff' => [
                'policy' => Utils::defaultString($runtime->backoffPolicy, 'no'),
                'period' => Utils::defaultNumber($runtime->backoffPeriod, 1),
            ],
            'ignoreSSL' => $runtime->ignoreSSL,
        ];
        $_lastRequest   = null;
        $_lastException = null;
        $_now           = time();
        $_retryTimes    = 0;
        while (Tea::allowRetry(@$_runtime['retry'], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime(@$_runtime['backoff'], $_retryTimes);
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
                $reqBody            = XML::toXML($request->body->toMap());
                $_request->protocol = $this->_protocol;
                $_request->method   = 'PUT';
                $_request->pathname = '/?cors';
                $_request->headers  = [
                    'host'       => OSSUtils::getHost($request->bucketName, $this->_regionId, $this->_endpoint, $this->_hostModel),
                    'date'       => Utils::getDateUTCString(),
                    'user-agent' => $this->getUserAgent(),
                ];
                if (!Utils::empty_($token)) {
                    $_request->headers['x-oss-security-token'] = $token;
                }
                $_request->body                     = $reqBody;
                $_request->headers['authorization'] = OSSUtils::getSignature($_request, $request->bucketName, $accessKeyId, $accessKeySecret, $this->_signatureVersion, $this->_addtionalHeaders);
                $_lastRequest                       = $_request;
                $_response                          = Tea::send($_request, $_runtime);
                $respMap                            = null;
                $bodyStr                            = null;
                if (Utils::is4xx($_response->statusCode) || Utils::is5xx($_response->statusCode)) {
                    $bodyStr = Utils::readAsString($_response->body);
                    $respMap = OSSUtils::getErrMessage($bodyStr);

                    throw new TeaError([
                        'code'    => @$respMap['Code'],
                        'message' => @$respMap['Message'],
                        'data'    => [
                            'httpCode'  => $_response->statusCode,
                            'requestId' => @$respMap['RequestId'],
                            'hostId'    => @$respMap['HostId'],
                        ],
                    ]);
                }

                return PutBucketCORSResponse::fromMap(Tea::merge($_response->headers));
            } catch (Exception $e) {
                if (!($e instanceof TeaError)) {
                    $e = new TeaError([], $e->getMessage(), $e->getCode(), $e);
                }
                if (Tea::isRetryable($e)) {
                    $_lastException = $e;

                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest, $_lastException);
    }

    /**
     * @param PutBucketRequest $request
     * @param RuntimeOptions   $runtime
     *
     * @throws TeaError
     * @throws Exception
     * @throws TeaUnableRetryError
     *
     * @return PutBucketResponse
     */
    public function putBucket($request, $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime = [
            'timeouted'      => 'retry',
            'readTimeout'    => Utils::defaultNumber($runtime->readTimeout, $this->_readTimeout),
            'connectTimeout' => Utils::defaultNumber($runtime->connectTimeout, $this->_connectTimeout),
            'localAddr'      => Utils::defaultString($runtime->localAddr, $this->_localAddr),
            'httpProxy'      => Utils::defaultString($runtime->httpProxy, $this->_httpProxy),
            'httpsProxy'     => Utils::defaultString($runtime->httpsProxy, $this->_httpsProxy),
            'noProxy'        => Utils::defaultString($runtime->noProxy, $this->_noProxy),
            'socks5Proxy'    => Utils::defaultString($runtime->socks5Proxy, $this->_socks5Proxy),
            'socks5NetWork'  => Utils::defaultString($runtime->socks5NetWork, $this->_socks5NetWork),
            'maxIdleConns'   => Utils::defaultNumber($runtime->maxIdleConns, $this->_maxIdleConns),
            'retry'          => [
                'retryable'   => $runtime->autoretry,
                'maxAttempts' => Utils::defaultNumber($runtime->maxAttempts, 3),
            ],
            'backoff' => [
                'policy' => Utils::defaultString($runtime->backoffPolicy, 'no'),
                'period' => Utils::defaultNumber($runtime->backoffPeriod, 1),
            ],
            'ignoreSSL' => $runtime->ignoreSSL,
        ];
        $_lastRequest   = null;
        $_lastException = null;
        $_now           = time();
        $_retryTimes    = 0;
        while (Tea::allowRetry(@$_runtime['retry'], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime(@$_runtime['backoff'], $_retryTimes);
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
                $reqBody            = XML::toXML($request->body->toMap());
                $_request->protocol = $this->_protocol;
                $_request->method   = 'PUT';
                $_request->pathname = '/';
                $_request->headers  = Tea::merge([
                    'host'       => OSSUtils::getHost($request->bucketName, $this->_regionId, $this->_endpoint, $this->_hostModel),
                    'date'       => Utils::getDateUTCString(),
                    'user-agent' => $this->getUserAgent(),
                ], Utils::stringifyMapValue($request->header->toMap()));
                if (!Utils::empty_($token)) {
                    $_request->headers['x-oss-security-token'] = $token;
                }
                $_request->body                     = $reqBody;
                $_request->headers['authorization'] = OSSUtils::getSignature($_request, $request->bucketName, $accessKeyId, $accessKeySecret, $this->_signatureVersion, $this->_addtionalHeaders);
                $_lastRequest                       = $_request;
                $_response                          = Tea::send($_request, $_runtime);
                $respMap                            = null;
                $bodyStr                            = null;
                if (Utils::is4xx($_response->statusCode) || Utils::is5xx($_response->statusCode)) {
                    $bodyStr = Utils::readAsString($_response->body);
                    $respMap = OSSUtils::getErrMessage($bodyStr);

                    throw new TeaError([
                        'code'    => @$respMap['Code'],
                        'message' => @$respMap['Message'],
                        'data'    => [
                            'httpCode'  => $_response->statusCode,
                            'requestId' => @$respMap['RequestId'],
                            'hostId'    => @$respMap['HostId'],
                        ],
                    ]);
                }

                return PutBucketResponse::fromMap(Tea::merge($_response->headers));
            } catch (Exception $e) {
                if (!($e instanceof TeaError)) {
                    $e = new TeaError([], $e->getMessage(), $e->getCode(), $e);
                }
                if (Tea::isRetryable($e)) {
                    $_lastException = $e;

                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest, $_lastException);
    }

    /**
     * @param ListMultipartUploadsRequest $request
     * @param RuntimeOptions              $runtime
     *
     * @throws TeaError
     * @throws Exception
     * @throws TeaUnableRetryError
     *
     * @return ListMultipartUploadsResponse
     */
    public function listMultipartUploads($request, $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime = [
            'timeouted'      => 'retry',
            'readTimeout'    => Utils::defaultNumber($runtime->readTimeout, $this->_readTimeout),
            'connectTimeout' => Utils::defaultNumber($runtime->connectTimeout, $this->_connectTimeout),
            'localAddr'      => Utils::defaultString($runtime->localAddr, $this->_localAddr),
            'httpProxy'      => Utils::defaultString($runtime->httpProxy, $this->_httpProxy),
            'httpsProxy'     => Utils::defaultString($runtime->httpsProxy, $this->_httpsProxy),
            'noProxy'        => Utils::defaultString($runtime->noProxy, $this->_noProxy),
            'socks5Proxy'    => Utils::defaultString($runtime->socks5Proxy, $this->_socks5Proxy),
            'socks5NetWork'  => Utils::defaultString($runtime->socks5NetWork, $this->_socks5NetWork),
            'maxIdleConns'   => Utils::defaultNumber($runtime->maxIdleConns, $this->_maxIdleConns),
            'retry'          => [
                'retryable'   => $runtime->autoretry,
                'maxAttempts' => Utils::defaultNumber($runtime->maxAttempts, 3),
            ],
            'backoff' => [
                'policy' => Utils::defaultString($runtime->backoffPolicy, 'no'),
                'period' => Utils::defaultNumber($runtime->backoffPeriod, 1),
            ],
            'ignoreSSL' => $runtime->ignoreSSL,
        ];
        $_lastRequest   = null;
        $_lastException = null;
        $_now           = time();
        $_retryTimes    = 0;
        while (Tea::allowRetry(@$_runtime['retry'], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime(@$_runtime['backoff'], $_retryTimes);
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
                $_request->method   = 'GET';
                $_request->pathname = '/?uploads';
                $_request->headers  = [
                    'host'       => OSSUtils::getHost($request->bucketName, $this->_regionId, $this->_endpoint, $this->_hostModel),
                    'date'       => Utils::getDateUTCString(),
                    'user-agent' => $this->getUserAgent(),
                ];
                if (!Utils::empty_($token)) {
                    $_request->headers['x-oss-security-token'] = $token;
                }
                $_request->query                    = Utils::stringifyMapValue($request->filter->toMap());
                $_request->headers['authorization'] = OSSUtils::getSignature($_request, $request->bucketName, $accessKeyId, $accessKeySecret, $this->_signatureVersion, $this->_addtionalHeaders);
                $_lastRequest                       = $_request;
                $_response                          = Tea::send($_request, $_runtime);
                $respMap                            = null;
                $bodyStr                            = null;
                if (Utils::is4xx($_response->statusCode) || Utils::is5xx($_response->statusCode)) {
                    $bodyStr = Utils::readAsString($_response->body);
                    $respMap = OSSUtils::getErrMessage($bodyStr);

                    throw new TeaError([
                        'code'    => @$respMap['Code'],
                        'message' => @$respMap['Message'],
                        'data'    => [
                            'httpCode'  => $_response->statusCode,
                            'requestId' => @$respMap['RequestId'],
                            'hostId'    => @$respMap['HostId'],
                        ],
                    ]);
                }
                $bodyStr = Utils::readAsString($_response->body);
                $respMap = XML::parseXml($bodyStr, ListMultipartUploadsResponse::class);

                return ListMultipartUploadsResponse::fromMap(Tea::merge([
                    'ListMultipartUploadsResult' => @$respMap['ListMultipartUploadsResult'],
                ], $_response->headers));
            } catch (Exception $e) {
                if (!($e instanceof TeaError)) {
                    $e = new TeaError([], $e->getMessage(), $e->getCode(), $e);
                }
                if (Tea::isRetryable($e)) {
                    $_lastException = $e;

                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest, $_lastException);
    }

    /**
     * @param GetBucketRequestPaymentRequest $request
     * @param RuntimeOptions                 $runtime
     *
     * @throws TeaError
     * @throws Exception
     * @throws TeaUnableRetryError
     *
     * @return GetBucketRequestPaymentResponse
     */
    public function getBucketRequestPayment($request, $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime = [
            'timeouted'      => 'retry',
            'readTimeout'    => Utils::defaultNumber($runtime->readTimeout, $this->_readTimeout),
            'connectTimeout' => Utils::defaultNumber($runtime->connectTimeout, $this->_connectTimeout),
            'localAddr'      => Utils::defaultString($runtime->localAddr, $this->_localAddr),
            'httpProxy'      => Utils::defaultString($runtime->httpProxy, $this->_httpProxy),
            'httpsProxy'     => Utils::defaultString($runtime->httpsProxy, $this->_httpsProxy),
            'noProxy'        => Utils::defaultString($runtime->noProxy, $this->_noProxy),
            'socks5Proxy'    => Utils::defaultString($runtime->socks5Proxy, $this->_socks5Proxy),
            'socks5NetWork'  => Utils::defaultString($runtime->socks5NetWork, $this->_socks5NetWork),
            'maxIdleConns'   => Utils::defaultNumber($runtime->maxIdleConns, $this->_maxIdleConns),
            'retry'          => [
                'retryable'   => $runtime->autoretry,
                'maxAttempts' => Utils::defaultNumber($runtime->maxAttempts, 3),
            ],
            'backoff' => [
                'policy' => Utils::defaultString($runtime->backoffPolicy, 'no'),
                'period' => Utils::defaultNumber($runtime->backoffPeriod, 1),
            ],
            'ignoreSSL' => $runtime->ignoreSSL,
        ];
        $_lastRequest   = null;
        $_lastException = null;
        $_now           = time();
        $_retryTimes    = 0;
        while (Tea::allowRetry(@$_runtime['retry'], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime(@$_runtime['backoff'], $_retryTimes);
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
                $_request->method   = 'GET';
                $_request->pathname = '/?requestPayment';
                $_request->headers  = [
                    'host'       => OSSUtils::getHost($request->bucketName, $this->_regionId, $this->_endpoint, $this->_hostModel),
                    'date'       => Utils::getDateUTCString(),
                    'user-agent' => $this->getUserAgent(),
                ];
                if (!Utils::empty_($token)) {
                    $_request->headers['x-oss-security-token'] = $token;
                }
                $_request->headers['authorization'] = OSSUtils::getSignature($_request, $request->bucketName, $accessKeyId, $accessKeySecret, $this->_signatureVersion, $this->_addtionalHeaders);
                $_lastRequest                       = $_request;
                $_response                          = Tea::send($_request, $_runtime);
                $respMap                            = null;
                $bodyStr                            = null;
                if (Utils::is4xx($_response->statusCode) || Utils::is5xx($_response->statusCode)) {
                    $bodyStr = Utils::readAsString($_response->body);
                    $respMap = OSSUtils::getErrMessage($bodyStr);

                    throw new TeaError([
                        'code'    => @$respMap['Code'],
                        'message' => @$respMap['Message'],
                        'data'    => [
                            'httpCode'  => $_response->statusCode,
                            'requestId' => @$respMap['RequestId'],
                            'hostId'    => @$respMap['HostId'],
                        ],
                    ]);
                }
                $bodyStr = Utils::readAsString($_response->body);
                $respMap = XML::parseXml($bodyStr, GetBucketRequestPaymentResponse::class);

                return GetBucketRequestPaymentResponse::fromMap(Tea::merge([
                    'RequestPaymentConfiguration' => @$respMap['RequestPaymentConfiguration'],
                ], $_response->headers));
            } catch (Exception $e) {
                if (!($e instanceof TeaError)) {
                    $e = new TeaError([], $e->getMessage(), $e->getCode(), $e);
                }
                if (Tea::isRetryable($e)) {
                    $_lastException = $e;

                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest, $_lastException);
    }

    /**
     * @param GetBucketEncryptionRequest $request
     * @param RuntimeOptions             $runtime
     *
     * @throws TeaError
     * @throws Exception
     * @throws TeaUnableRetryError
     *
     * @return GetBucketEncryptionResponse
     */
    public function getBucketEncryption($request, $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime = [
            'timeouted'      => 'retry',
            'readTimeout'    => Utils::defaultNumber($runtime->readTimeout, $this->_readTimeout),
            'connectTimeout' => Utils::defaultNumber($runtime->connectTimeout, $this->_connectTimeout),
            'localAddr'      => Utils::defaultString($runtime->localAddr, $this->_localAddr),
            'httpProxy'      => Utils::defaultString($runtime->httpProxy, $this->_httpProxy),
            'httpsProxy'     => Utils::defaultString($runtime->httpsProxy, $this->_httpsProxy),
            'noProxy'        => Utils::defaultString($runtime->noProxy, $this->_noProxy),
            'socks5Proxy'    => Utils::defaultString($runtime->socks5Proxy, $this->_socks5Proxy),
            'socks5NetWork'  => Utils::defaultString($runtime->socks5NetWork, $this->_socks5NetWork),
            'maxIdleConns'   => Utils::defaultNumber($runtime->maxIdleConns, $this->_maxIdleConns),
            'retry'          => [
                'retryable'   => $runtime->autoretry,
                'maxAttempts' => Utils::defaultNumber($runtime->maxAttempts, 3),
            ],
            'backoff' => [
                'policy' => Utils::defaultString($runtime->backoffPolicy, 'no'),
                'period' => Utils::defaultNumber($runtime->backoffPeriod, 1),
            ],
            'ignoreSSL' => $runtime->ignoreSSL,
        ];
        $_lastRequest   = null;
        $_lastException = null;
        $_now           = time();
        $_retryTimes    = 0;
        while (Tea::allowRetry(@$_runtime['retry'], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime(@$_runtime['backoff'], $_retryTimes);
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
                $_request->method   = 'GET';
                $_request->pathname = '/?encryption';
                $_request->headers  = [
                    'host'       => OSSUtils::getHost($request->bucketName, $this->_regionId, $this->_endpoint, $this->_hostModel),
                    'date'       => Utils::getDateUTCString(),
                    'user-agent' => $this->getUserAgent(),
                ];
                if (!Utils::empty_($token)) {
                    $_request->headers['x-oss-security-token'] = $token;
                }
                $_request->headers['authorization'] = OSSUtils::getSignature($_request, $request->bucketName, $accessKeyId, $accessKeySecret, $this->_signatureVersion, $this->_addtionalHeaders);
                $_lastRequest                       = $_request;
                $_response                          = Tea::send($_request, $_runtime);
                $respMap                            = null;
                $bodyStr                            = null;
                if (Utils::is4xx($_response->statusCode) || Utils::is5xx($_response->statusCode)) {
                    $bodyStr = Utils::readAsString($_response->body);
                    $respMap = OSSUtils::getErrMessage($bodyStr);

                    throw new TeaError([
                        'code'    => @$respMap['Code'],
                        'message' => @$respMap['Message'],
                        'data'    => [
                            'httpCode'  => $_response->statusCode,
                            'requestId' => @$respMap['RequestId'],
                            'hostId'    => @$respMap['HostId'],
                        ],
                    ]);
                }
                $bodyStr = Utils::readAsString($_response->body);
                $respMap = XML::parseXml($bodyStr, GetBucketEncryptionResponse::class);

                return GetBucketEncryptionResponse::fromMap(Tea::merge([
                    'ServerSideEncryptionRule' => @$respMap['ServerSideEncryptionRule'],
                ], $_response->headers));
            } catch (Exception $e) {
                if (!($e instanceof TeaError)) {
                    $e = new TeaError([], $e->getMessage(), $e->getCode(), $e);
                }
                if (Tea::isRetryable($e)) {
                    $_lastException = $e;

                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest, $_lastException);
    }

    /**
     * @param GetBucketTagsRequest $request
     * @param RuntimeOptions       $runtime
     *
     * @throws TeaError
     * @throws Exception
     * @throws TeaUnableRetryError
     *
     * @return GetBucketTagsResponse
     */
    public function getBucketTags($request, $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime = [
            'timeouted'      => 'retry',
            'readTimeout'    => Utils::defaultNumber($runtime->readTimeout, $this->_readTimeout),
            'connectTimeout' => Utils::defaultNumber($runtime->connectTimeout, $this->_connectTimeout),
            'localAddr'      => Utils::defaultString($runtime->localAddr, $this->_localAddr),
            'httpProxy'      => Utils::defaultString($runtime->httpProxy, $this->_httpProxy),
            'httpsProxy'     => Utils::defaultString($runtime->httpsProxy, $this->_httpsProxy),
            'noProxy'        => Utils::defaultString($runtime->noProxy, $this->_noProxy),
            'socks5Proxy'    => Utils::defaultString($runtime->socks5Proxy, $this->_socks5Proxy),
            'socks5NetWork'  => Utils::defaultString($runtime->socks5NetWork, $this->_socks5NetWork),
            'maxIdleConns'   => Utils::defaultNumber($runtime->maxIdleConns, $this->_maxIdleConns),
            'retry'          => [
                'retryable'   => $runtime->autoretry,
                'maxAttempts' => Utils::defaultNumber($runtime->maxAttempts, 3),
            ],
            'backoff' => [
                'policy' => Utils::defaultString($runtime->backoffPolicy, 'no'),
                'period' => Utils::defaultNumber($runtime->backoffPeriod, 1),
            ],
            'ignoreSSL' => $runtime->ignoreSSL,
        ];
        $_lastRequest   = null;
        $_lastException = null;
        $_now           = time();
        $_retryTimes    = 0;
        while (Tea::allowRetry(@$_runtime['retry'], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime(@$_runtime['backoff'], $_retryTimes);
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
                $_request->method   = 'GET';
                $_request->pathname = '/?tagging';
                $_request->headers  = [
                    'host'       => OSSUtils::getHost($request->bucketName, $this->_regionId, $this->_endpoint, $this->_hostModel),
                    'date'       => Utils::getDateUTCString(),
                    'user-agent' => $this->getUserAgent(),
                ];
                if (!Utils::empty_($token)) {
                    $_request->headers['x-oss-security-token'] = $token;
                }
                $_request->headers['authorization'] = OSSUtils::getSignature($_request, $request->bucketName, $accessKeyId, $accessKeySecret, $this->_signatureVersion, $this->_addtionalHeaders);
                $_lastRequest                       = $_request;
                $_response                          = Tea::send($_request, $_runtime);
                $respMap                            = null;
                $bodyStr                            = null;
                if (Utils::is4xx($_response->statusCode) || Utils::is5xx($_response->statusCode)) {
                    $bodyStr = Utils::readAsString($_response->body);
                    $respMap = OSSUtils::getErrMessage($bodyStr);

                    throw new TeaError([
                        'code'    => @$respMap['Code'],
                        'message' => @$respMap['Message'],
                        'data'    => [
                            'httpCode'  => $_response->statusCode,
                            'requestId' => @$respMap['RequestId'],
                            'hostId'    => @$respMap['HostId'],
                        ],
                    ]);
                }
                $bodyStr = Utils::readAsString($_response->body);
                $respMap = XML::parseXml($bodyStr, GetBucketTagsResponse::class);

                return GetBucketTagsResponse::fromMap(Tea::merge([
                    'Tagging' => @$respMap['Tagging'],
                ], $_response->headers));
            } catch (Exception $e) {
                if (!($e instanceof TeaError)) {
                    $e = new TeaError([], $e->getMessage(), $e->getCode(), $e);
                }
                if (Tea::isRetryable($e)) {
                    $_lastException = $e;

                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest, $_lastException);
    }

    /**
     * @param GetServiceRequest $request
     * @param RuntimeOptions    $runtime
     *
     * @throws TeaError
     * @throws Exception
     * @throws TeaUnableRetryError
     *
     * @return GetServiceResponse
     */
    public function getService($request, $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime = [
            'timeouted'      => 'retry',
            'readTimeout'    => Utils::defaultNumber($runtime->readTimeout, $this->_readTimeout),
            'connectTimeout' => Utils::defaultNumber($runtime->connectTimeout, $this->_connectTimeout),
            'localAddr'      => Utils::defaultString($runtime->localAddr, $this->_localAddr),
            'httpProxy'      => Utils::defaultString($runtime->httpProxy, $this->_httpProxy),
            'httpsProxy'     => Utils::defaultString($runtime->httpsProxy, $this->_httpsProxy),
            'noProxy'        => Utils::defaultString($runtime->noProxy, $this->_noProxy),
            'socks5Proxy'    => Utils::defaultString($runtime->socks5Proxy, $this->_socks5Proxy),
            'socks5NetWork'  => Utils::defaultString($runtime->socks5NetWork, $this->_socks5NetWork),
            'maxIdleConns'   => Utils::defaultNumber($runtime->maxIdleConns, $this->_maxIdleConns),
            'retry'          => [
                'retryable'   => $runtime->autoretry,
                'maxAttempts' => Utils::defaultNumber($runtime->maxAttempts, 3),
            ],
            'backoff' => [
                'policy' => Utils::defaultString($runtime->backoffPolicy, 'no'),
                'period' => Utils::defaultNumber($runtime->backoffPeriod, 1),
            ],
            'ignoreSSL' => $runtime->ignoreSSL,
        ];
        $_lastRequest   = null;
        $_lastException = null;
        $_now           = time();
        $_retryTimes    = 0;
        while (Tea::allowRetry(@$_runtime['retry'], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime(@$_runtime['backoff'], $_retryTimes);
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
                $_request->method   = 'GET';
                $_request->pathname = '/';
                $_request->headers  = [
                    'host'       => OSSUtils::getHost('', $this->_regionId, $this->_endpoint, $this->_hostModel),
                    'date'       => Utils::getDateUTCString(),
                    'user-agent' => $this->getUserAgent(),
                ];
                if (!Utils::empty_($token)) {
                    $_request->headers['x-oss-security-token'] = $token;
                }
                $_request->query                    = Utils::stringifyMapValue($request->filter->toMap());
                $_request->headers['authorization'] = OSSUtils::getSignature($_request, '', $accessKeyId, $accessKeySecret, $this->_signatureVersion, $this->_addtionalHeaders);
                $_lastRequest                       = $_request;
                $_response                          = Tea::send($_request, $_runtime);
                $respMap                            = null;
                $bodyStr                            = null;
                if (Utils::is4xx($_response->statusCode) || Utils::is5xx($_response->statusCode)) {
                    $bodyStr = Utils::readAsString($_response->body);
                    $respMap = OSSUtils::getErrMessage($bodyStr);

                    throw new TeaError([
                        'code'    => @$respMap['Code'],
                        'message' => @$respMap['Message'],
                        'data'    => [
                            'httpCode'  => $_response->statusCode,
                            'requestId' => @$respMap['RequestId'],
                            'hostId'    => @$respMap['HostId'],
                        ],
                    ]);
                }
                $bodyStr = Utils::readAsString($_response->body);
                $respMap = XML::parseXml($bodyStr, GetServiceResponse::class);

                return GetServiceResponse::fromMap(Tea::merge([
                    'ListAllMyBucketsResult' => @$respMap['ListAllMyBucketsResult'],
                ], $_response->headers));
            } catch (Exception $e) {
                if (!($e instanceof TeaError)) {
                    $e = new TeaError([], $e->getMessage(), $e->getCode(), $e);
                }
                if (Tea::isRetryable($e)) {
                    $_lastException = $e;

                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest, $_lastException);
    }

    /**
     * @param DeleteBucketEncryptionRequest $request
     * @param RuntimeOptions                $runtime
     *
     * @throws TeaError
     * @throws Exception
     * @throws TeaUnableRetryError
     *
     * @return DeleteBucketEncryptionResponse
     */
    public function deleteBucketEncryption($request, $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime = [
            'timeouted'      => 'retry',
            'readTimeout'    => Utils::defaultNumber($runtime->readTimeout, $this->_readTimeout),
            'connectTimeout' => Utils::defaultNumber($runtime->connectTimeout, $this->_connectTimeout),
            'localAddr'      => Utils::defaultString($runtime->localAddr, $this->_localAddr),
            'httpProxy'      => Utils::defaultString($runtime->httpProxy, $this->_httpProxy),
            'httpsProxy'     => Utils::defaultString($runtime->httpsProxy, $this->_httpsProxy),
            'noProxy'        => Utils::defaultString($runtime->noProxy, $this->_noProxy),
            'socks5Proxy'    => Utils::defaultString($runtime->socks5Proxy, $this->_socks5Proxy),
            'socks5NetWork'  => Utils::defaultString($runtime->socks5NetWork, $this->_socks5NetWork),
            'maxIdleConns'   => Utils::defaultNumber($runtime->maxIdleConns, $this->_maxIdleConns),
            'retry'          => [
                'retryable'   => $runtime->autoretry,
                'maxAttempts' => Utils::defaultNumber($runtime->maxAttempts, 3),
            ],
            'backoff' => [
                'policy' => Utils::defaultString($runtime->backoffPolicy, 'no'),
                'period' => Utils::defaultNumber($runtime->backoffPeriod, 1),
            ],
            'ignoreSSL' => $runtime->ignoreSSL,
        ];
        $_lastRequest   = null;
        $_lastException = null;
        $_now           = time();
        $_retryTimes    = 0;
        while (Tea::allowRetry(@$_runtime['retry'], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime(@$_runtime['backoff'], $_retryTimes);
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
                $_request->method   = 'DELETE';
                $_request->pathname = '/?encryption';
                $_request->headers  = [
                    'host'       => OSSUtils::getHost($request->bucketName, $this->_regionId, $this->_endpoint, $this->_hostModel),
                    'date'       => Utils::getDateUTCString(),
                    'user-agent' => $this->getUserAgent(),
                ];
                if (!Utils::empty_($token)) {
                    $_request->headers['x-oss-security-token'] = $token;
                }
                $_request->headers['authorization'] = OSSUtils::getSignature($_request, $request->bucketName, $accessKeyId, $accessKeySecret, $this->_signatureVersion, $this->_addtionalHeaders);
                $_lastRequest                       = $_request;
                $_response                          = Tea::send($_request, $_runtime);
                $respMap                            = null;
                $bodyStr                            = null;
                if (Utils::is4xx($_response->statusCode) || Utils::is5xx($_response->statusCode)) {
                    $bodyStr = Utils::readAsString($_response->body);
                    $respMap = OSSUtils::getErrMessage($bodyStr);

                    throw new TeaError([
                        'code'    => @$respMap['Code'],
                        'message' => @$respMap['Message'],
                        'data'    => [
                            'httpCode'  => $_response->statusCode,
                            'requestId' => @$respMap['RequestId'],
                            'hostId'    => @$respMap['HostId'],
                        ],
                    ]);
                }

                return DeleteBucketEncryptionResponse::fromMap(Tea::merge($_response->headers));
            } catch (Exception $e) {
                if (!($e instanceof TeaError)) {
                    $e = new TeaError([], $e->getMessage(), $e->getCode(), $e);
                }
                if (Tea::isRetryable($e)) {
                    $_lastException = $e;

                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest, $_lastException);
    }

    /**
     * @param DeleteBucketTagsRequest $request
     * @param RuntimeOptions          $runtime
     *
     * @throws TeaError
     * @throws Exception
     * @throws TeaUnableRetryError
     *
     * @return DeleteBucketTagsResponse
     */
    public function deleteBucketTags($request, $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime = [
            'timeouted'      => 'retry',
            'readTimeout'    => Utils::defaultNumber($runtime->readTimeout, $this->_readTimeout),
            'connectTimeout' => Utils::defaultNumber($runtime->connectTimeout, $this->_connectTimeout),
            'localAddr'      => Utils::defaultString($runtime->localAddr, $this->_localAddr),
            'httpProxy'      => Utils::defaultString($runtime->httpProxy, $this->_httpProxy),
            'httpsProxy'     => Utils::defaultString($runtime->httpsProxy, $this->_httpsProxy),
            'noProxy'        => Utils::defaultString($runtime->noProxy, $this->_noProxy),
            'socks5Proxy'    => Utils::defaultString($runtime->socks5Proxy, $this->_socks5Proxy),
            'socks5NetWork'  => Utils::defaultString($runtime->socks5NetWork, $this->_socks5NetWork),
            'maxIdleConns'   => Utils::defaultNumber($runtime->maxIdleConns, $this->_maxIdleConns),
            'retry'          => [
                'retryable'   => $runtime->autoretry,
                'maxAttempts' => Utils::defaultNumber($runtime->maxAttempts, 3),
            ],
            'backoff' => [
                'policy' => Utils::defaultString($runtime->backoffPolicy, 'no'),
                'period' => Utils::defaultNumber($runtime->backoffPeriod, 1),
            ],
            'ignoreSSL' => $runtime->ignoreSSL,
        ];
        $_lastRequest   = null;
        $_lastException = null;
        $_now           = time();
        $_retryTimes    = 0;
        while (Tea::allowRetry(@$_runtime['retry'], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime(@$_runtime['backoff'], $_retryTimes);
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
                $_request->method   = 'DELETE';
                $_request->pathname = '/';
                $_request->headers  = [
                    'host'       => OSSUtils::getHost($request->bucketName, $this->_regionId, $this->_endpoint, $this->_hostModel),
                    'date'       => Utils::getDateUTCString(),
                    'user-agent' => $this->getUserAgent(),
                ];
                if (!Utils::empty_($token)) {
                    $_request->headers['x-oss-security-token'] = $token;
                }
                $_request->query                    = Utils::stringifyMapValue($request->filter->toMap());
                $_request->headers['authorization'] = OSSUtils::getSignature($_request, $request->bucketName, $accessKeyId, $accessKeySecret, $this->_signatureVersion, $this->_addtionalHeaders);
                $_lastRequest                       = $_request;
                $_response                          = Tea::send($_request, $_runtime);
                $respMap                            = null;
                $bodyStr                            = null;
                if (Utils::is4xx($_response->statusCode) || Utils::is5xx($_response->statusCode)) {
                    $bodyStr = Utils::readAsString($_response->body);
                    $respMap = OSSUtils::getErrMessage($bodyStr);

                    throw new TeaError([
                        'code'    => @$respMap['Code'],
                        'message' => @$respMap['Message'],
                        'data'    => [
                            'httpCode'  => $_response->statusCode,
                            'requestId' => @$respMap['RequestId'],
                            'hostId'    => @$respMap['HostId'],
                        ],
                    ]);
                }

                return DeleteBucketTagsResponse::fromMap(Tea::merge($_response->headers));
            } catch (Exception $e) {
                if (!($e instanceof TeaError)) {
                    $e = new TeaError([], $e->getMessage(), $e->getCode(), $e);
                }
                if (Tea::isRetryable($e)) {
                    $_lastException = $e;

                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest, $_lastException);
    }

    /**
     * @param GetBucketWebsiteRequest $request
     * @param RuntimeOptions          $runtime
     *
     * @throws TeaError
     * @throws Exception
     * @throws TeaUnableRetryError
     *
     * @return GetBucketWebsiteResponse
     */
    public function getBucketWebsite($request, $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime = [
            'timeouted'      => 'retry',
            'readTimeout'    => Utils::defaultNumber($runtime->readTimeout, $this->_readTimeout),
            'connectTimeout' => Utils::defaultNumber($runtime->connectTimeout, $this->_connectTimeout),
            'localAddr'      => Utils::defaultString($runtime->localAddr, $this->_localAddr),
            'httpProxy'      => Utils::defaultString($runtime->httpProxy, $this->_httpProxy),
            'httpsProxy'     => Utils::defaultString($runtime->httpsProxy, $this->_httpsProxy),
            'noProxy'        => Utils::defaultString($runtime->noProxy, $this->_noProxy),
            'socks5Proxy'    => Utils::defaultString($runtime->socks5Proxy, $this->_socks5Proxy),
            'socks5NetWork'  => Utils::defaultString($runtime->socks5NetWork, $this->_socks5NetWork),
            'maxIdleConns'   => Utils::defaultNumber($runtime->maxIdleConns, $this->_maxIdleConns),
            'retry'          => [
                'retryable'   => $runtime->autoretry,
                'maxAttempts' => Utils::defaultNumber($runtime->maxAttempts, 3),
            ],
            'backoff' => [
                'policy' => Utils::defaultString($runtime->backoffPolicy, 'no'),
                'period' => Utils::defaultNumber($runtime->backoffPeriod, 1),
            ],
            'ignoreSSL' => $runtime->ignoreSSL,
        ];
        $_lastRequest   = null;
        $_lastException = null;
        $_now           = time();
        $_retryTimes    = 0;
        while (Tea::allowRetry(@$_runtime['retry'], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime(@$_runtime['backoff'], $_retryTimes);
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
                $_request->method   = 'GET';
                $_request->pathname = '/?website';
                $_request->headers  = [
                    'host'       => OSSUtils::getHost($request->bucketName, $this->_regionId, $this->_endpoint, $this->_hostModel),
                    'date'       => Utils::getDateUTCString(),
                    'user-agent' => $this->getUserAgent(),
                ];
                if (!Utils::empty_($token)) {
                    $_request->headers['x-oss-security-token'] = $token;
                }
                $_request->headers['authorization'] = OSSUtils::getSignature($_request, $request->bucketName, $accessKeyId, $accessKeySecret, $this->_signatureVersion, $this->_addtionalHeaders);
                $_lastRequest                       = $_request;
                $_response                          = Tea::send($_request, $_runtime);
                $respMap                            = null;
                $bodyStr                            = null;
                if (Utils::is4xx($_response->statusCode) || Utils::is5xx($_response->statusCode)) {
                    $bodyStr = Utils::readAsString($_response->body);
                    $respMap = OSSUtils::getErrMessage($bodyStr);

                    throw new TeaError([
                        'code'    => @$respMap['Code'],
                        'message' => @$respMap['Message'],
                        'data'    => [
                            'httpCode'  => $_response->statusCode,
                            'requestId' => @$respMap['RequestId'],
                            'hostId'    => @$respMap['HostId'],
                        ],
                    ]);
                }
                $bodyStr = Utils::readAsString($_response->body);
                $respMap = XML::parseXml($bodyStr, GetBucketWebsiteResponse::class);

                return GetBucketWebsiteResponse::fromMap(Tea::merge([
                    'WebsiteConfiguration' => @$respMap['WebsiteConfiguration'],
                ], $_response->headers));
            } catch (Exception $e) {
                if (!($e instanceof TeaError)) {
                    $e = new TeaError([], $e->getMessage(), $e->getCode(), $e);
                }
                if (Tea::isRetryable($e)) {
                    $_lastException = $e;

                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest, $_lastException);
    }

    /**
     * @param DeleteLiveChannelRequest $request
     * @param RuntimeOptions           $runtime
     *
     * @throws TeaError
     * @throws Exception
     * @throws TeaUnableRetryError
     *
     * @return DeleteLiveChannelResponse
     */
    public function deleteLiveChannel($request, $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime = [
            'timeouted'      => 'retry',
            'readTimeout'    => Utils::defaultNumber($runtime->readTimeout, $this->_readTimeout),
            'connectTimeout' => Utils::defaultNumber($runtime->connectTimeout, $this->_connectTimeout),
            'localAddr'      => Utils::defaultString($runtime->localAddr, $this->_localAddr),
            'httpProxy'      => Utils::defaultString($runtime->httpProxy, $this->_httpProxy),
            'httpsProxy'     => Utils::defaultString($runtime->httpsProxy, $this->_httpsProxy),
            'noProxy'        => Utils::defaultString($runtime->noProxy, $this->_noProxy),
            'socks5Proxy'    => Utils::defaultString($runtime->socks5Proxy, $this->_socks5Proxy),
            'socks5NetWork'  => Utils::defaultString($runtime->socks5NetWork, $this->_socks5NetWork),
            'maxIdleConns'   => Utils::defaultNumber($runtime->maxIdleConns, $this->_maxIdleConns),
            'retry'          => [
                'retryable'   => $runtime->autoretry,
                'maxAttempts' => Utils::defaultNumber($runtime->maxAttempts, 3),
            ],
            'backoff' => [
                'policy' => Utils::defaultString($runtime->backoffPolicy, 'no'),
                'period' => Utils::defaultNumber($runtime->backoffPeriod, 1),
            ],
            'ignoreSSL' => $runtime->ignoreSSL,
        ];
        $_lastRequest   = null;
        $_lastException = null;
        $_now           = time();
        $_retryTimes    = 0;
        while (Tea::allowRetry(@$_runtime['retry'], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime(@$_runtime['backoff'], $_retryTimes);
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
                $_request->method   = 'DELETE';
                $_request->pathname = '/' . $request->channelName . '?live';
                $_request->headers  = [
                    'host'       => OSSUtils::getHost($request->bucketName, $this->_regionId, $this->_endpoint, $this->_hostModel),
                    'date'       => Utils::getDateUTCString(),
                    'user-agent' => $this->getUserAgent(),
                ];
                if (!Utils::empty_($token)) {
                    $_request->headers['x-oss-security-token'] = $token;
                }
                $_request->headers['authorization'] = OSSUtils::getSignature($_request, $request->bucketName, $accessKeyId, $accessKeySecret, $this->_signatureVersion, $this->_addtionalHeaders);
                $_lastRequest                       = $_request;
                $_response                          = Tea::send($_request, $_runtime);
                $respMap                            = null;
                $bodyStr                            = null;
                if (Utils::is4xx($_response->statusCode) || Utils::is5xx($_response->statusCode)) {
                    $bodyStr = Utils::readAsString($_response->body);
                    $respMap = OSSUtils::getErrMessage($bodyStr);

                    throw new TeaError([
                        'code'    => @$respMap['Code'],
                        'message' => @$respMap['Message'],
                        'data'    => [
                            'httpCode'  => $_response->statusCode,
                            'requestId' => @$respMap['RequestId'],
                            'hostId'    => @$respMap['HostId'],
                        ],
                    ]);
                }

                return DeleteLiveChannelResponse::fromMap(Tea::merge($_response->headers));
            } catch (Exception $e) {
                if (!($e instanceof TeaError)) {
                    $e = new TeaError([], $e->getMessage(), $e->getCode(), $e);
                }
                if (Tea::isRetryable($e)) {
                    $_lastException = $e;

                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest, $_lastException);
    }

    /**
     * @param GetBucketLocationRequest $request
     * @param RuntimeOptions           $runtime
     *
     * @throws TeaError
     * @throws Exception
     * @throws TeaUnableRetryError
     *
     * @return GetBucketLocationResponse
     */
    public function getBucketLocation($request, $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime = [
            'timeouted'      => 'retry',
            'readTimeout'    => Utils::defaultNumber($runtime->readTimeout, $this->_readTimeout),
            'connectTimeout' => Utils::defaultNumber($runtime->connectTimeout, $this->_connectTimeout),
            'localAddr'      => Utils::defaultString($runtime->localAddr, $this->_localAddr),
            'httpProxy'      => Utils::defaultString($runtime->httpProxy, $this->_httpProxy),
            'httpsProxy'     => Utils::defaultString($runtime->httpsProxy, $this->_httpsProxy),
            'noProxy'        => Utils::defaultString($runtime->noProxy, $this->_noProxy),
            'socks5Proxy'    => Utils::defaultString($runtime->socks5Proxy, $this->_socks5Proxy),
            'socks5NetWork'  => Utils::defaultString($runtime->socks5NetWork, $this->_socks5NetWork),
            'maxIdleConns'   => Utils::defaultNumber($runtime->maxIdleConns, $this->_maxIdleConns),
            'retry'          => [
                'retryable'   => $runtime->autoretry,
                'maxAttempts' => Utils::defaultNumber($runtime->maxAttempts, 3),
            ],
            'backoff' => [
                'policy' => Utils::defaultString($runtime->backoffPolicy, 'no'),
                'period' => Utils::defaultNumber($runtime->backoffPeriod, 1),
            ],
            'ignoreSSL' => $runtime->ignoreSSL,
        ];
        $_lastRequest   = null;
        $_lastException = null;
        $_now           = time();
        $_retryTimes    = 0;
        while (Tea::allowRetry(@$_runtime['retry'], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime(@$_runtime['backoff'], $_retryTimes);
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
                $_request->method   = 'GET';
                $_request->pathname = '/?location';
                $_request->headers  = [
                    'host'       => OSSUtils::getHost($request->bucketName, $this->_regionId, $this->_endpoint, $this->_hostModel),
                    'date'       => Utils::getDateUTCString(),
                    'user-agent' => $this->getUserAgent(),
                ];
                if (!Utils::empty_($token)) {
                    $_request->headers['x-oss-security-token'] = $token;
                }
                $_request->headers['authorization'] = OSSUtils::getSignature($_request, $request->bucketName, $accessKeyId, $accessKeySecret, $this->_signatureVersion, $this->_addtionalHeaders);
                $_lastRequest                       = $_request;
                $_response                          = Tea::send($_request, $_runtime);
                $respMap                            = null;
                $bodyStr                            = null;
                if (Utils::is4xx($_response->statusCode) || Utils::is5xx($_response->statusCode)) {
                    $bodyStr = Utils::readAsString($_response->body);
                    $respMap = OSSUtils::getErrMessage($bodyStr);

                    throw new TeaError([
                        'code'    => @$respMap['Code'],
                        'message' => @$respMap['Message'],
                        'data'    => [
                            'httpCode'  => $_response->statusCode,
                            'requestId' => @$respMap['RequestId'],
                            'hostId'    => @$respMap['HostId'],
                        ],
                    ]);
                }
                $bodyStr = Utils::readAsString($_response->body);
                $respMap = XML::parseXml($bodyStr, GetBucketLocationResponse::class);

                return GetBucketLocationResponse::fromMap(Tea::merge([
                    'LocationConstraint' => @$respMap['LocationConstraint'],
                ], $_response->headers));
            } catch (Exception $e) {
                if (!($e instanceof TeaError)) {
                    $e = new TeaError([], $e->getMessage(), $e->getCode(), $e);
                }
                if (Tea::isRetryable($e)) {
                    $_lastException = $e;

                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest, $_lastException);
    }

    /**
     * @param ListLiveChannelRequest $request
     * @param RuntimeOptions         $runtime
     *
     * @throws TeaError
     * @throws Exception
     * @throws TeaUnableRetryError
     *
     * @return ListLiveChannelResponse
     */
    public function listLiveChannel($request, $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime = [
            'timeouted'      => 'retry',
            'readTimeout'    => Utils::defaultNumber($runtime->readTimeout, $this->_readTimeout),
            'connectTimeout' => Utils::defaultNumber($runtime->connectTimeout, $this->_connectTimeout),
            'localAddr'      => Utils::defaultString($runtime->localAddr, $this->_localAddr),
            'httpProxy'      => Utils::defaultString($runtime->httpProxy, $this->_httpProxy),
            'httpsProxy'     => Utils::defaultString($runtime->httpsProxy, $this->_httpsProxy),
            'noProxy'        => Utils::defaultString($runtime->noProxy, $this->_noProxy),
            'socks5Proxy'    => Utils::defaultString($runtime->socks5Proxy, $this->_socks5Proxy),
            'socks5NetWork'  => Utils::defaultString($runtime->socks5NetWork, $this->_socks5NetWork),
            'maxIdleConns'   => Utils::defaultNumber($runtime->maxIdleConns, $this->_maxIdleConns),
            'retry'          => [
                'retryable'   => $runtime->autoretry,
                'maxAttempts' => Utils::defaultNumber($runtime->maxAttempts, 3),
            ],
            'backoff' => [
                'policy' => Utils::defaultString($runtime->backoffPolicy, 'no'),
                'period' => Utils::defaultNumber($runtime->backoffPeriod, 1),
            ],
            'ignoreSSL' => $runtime->ignoreSSL,
        ];
        $_lastRequest   = null;
        $_lastException = null;
        $_now           = time();
        $_retryTimes    = 0;
        while (Tea::allowRetry(@$_runtime['retry'], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime(@$_runtime['backoff'], $_retryTimes);
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
                $_request->method   = 'GET';
                $_request->pathname = '/?live';
                $_request->headers  = [
                    'host'       => OSSUtils::getHost($request->bucketName, $this->_regionId, $this->_endpoint, $this->_hostModel),
                    'date'       => Utils::getDateUTCString(),
                    'user-agent' => $this->getUserAgent(),
                ];
                if (!Utils::empty_($token)) {
                    $_request->headers['x-oss-security-token'] = $token;
                }
                $_request->query                    = Utils::stringifyMapValue($request->filter->toMap());
                $_request->headers['authorization'] = OSSUtils::getSignature($_request, $request->bucketName, $accessKeyId, $accessKeySecret, $this->_signatureVersion, $this->_addtionalHeaders);
                $_lastRequest                       = $_request;
                $_response                          = Tea::send($_request, $_runtime);
                $respMap                            = null;
                $bodyStr                            = null;
                if (Utils::is4xx($_response->statusCode) || Utils::is5xx($_response->statusCode)) {
                    $bodyStr = Utils::readAsString($_response->body);
                    $respMap = OSSUtils::getErrMessage($bodyStr);

                    throw new TeaError([
                        'code'    => @$respMap['Code'],
                        'message' => @$respMap['Message'],
                        'data'    => [
                            'httpCode'  => $_response->statusCode,
                            'requestId' => @$respMap['RequestId'],
                            'hostId'    => @$respMap['HostId'],
                        ],
                    ]);
                }
                $bodyStr = Utils::readAsString($_response->body);
                $respMap = XML::parseXml($bodyStr, ListLiveChannelResponse::class);

                return ListLiveChannelResponse::fromMap(Tea::merge([
                    'ListLiveChannelResult' => @$respMap['ListLiveChannelResult'],
                ], $_response->headers));
            } catch (Exception $e) {
                if (!($e instanceof TeaError)) {
                    $e = new TeaError([], $e->getMessage(), $e->getCode(), $e);
                }
                if (Tea::isRetryable($e)) {
                    $_lastException = $e;

                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest, $_lastException);
    }

    /**
     * @param GetObjectMetaRequest $request
     * @param RuntimeOptions       $runtime
     *
     * @throws TeaError
     * @throws Exception
     * @throws TeaUnableRetryError
     *
     * @return GetObjectMetaResponse
     */
    public function getObjectMeta($request, $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime = [
            'timeouted'      => 'retry',
            'readTimeout'    => Utils::defaultNumber($runtime->readTimeout, $this->_readTimeout),
            'connectTimeout' => Utils::defaultNumber($runtime->connectTimeout, $this->_connectTimeout),
            'localAddr'      => Utils::defaultString($runtime->localAddr, $this->_localAddr),
            'httpProxy'      => Utils::defaultString($runtime->httpProxy, $this->_httpProxy),
            'httpsProxy'     => Utils::defaultString($runtime->httpsProxy, $this->_httpsProxy),
            'noProxy'        => Utils::defaultString($runtime->noProxy, $this->_noProxy),
            'socks5Proxy'    => Utils::defaultString($runtime->socks5Proxy, $this->_socks5Proxy),
            'socks5NetWork'  => Utils::defaultString($runtime->socks5NetWork, $this->_socks5NetWork),
            'maxIdleConns'   => Utils::defaultNumber($runtime->maxIdleConns, $this->_maxIdleConns),
            'retry'          => [
                'retryable'   => $runtime->autoretry,
                'maxAttempts' => Utils::defaultNumber($runtime->maxAttempts, 3),
            ],
            'backoff' => [
                'policy' => Utils::defaultString($runtime->backoffPolicy, 'no'),
                'period' => Utils::defaultNumber($runtime->backoffPeriod, 1),
            ],
            'ignoreSSL' => $runtime->ignoreSSL,
        ];
        $_lastRequest   = null;
        $_lastException = null;
        $_now           = time();
        $_retryTimes    = 0;
        while (Tea::allowRetry(@$_runtime['retry'], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime(@$_runtime['backoff'], $_retryTimes);
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
                $_request->method   = 'HEAD';
                $_request->pathname = '/' . $request->objectName . '?objectMeta';
                $_request->headers  = [
                    'host'       => OSSUtils::getHost($request->bucketName, $this->_regionId, $this->_endpoint, $this->_hostModel),
                    'date'       => Utils::getDateUTCString(),
                    'user-agent' => $this->getUserAgent(),
                ];
                if (!Utils::empty_($token)) {
                    $_request->headers['x-oss-security-token'] = $token;
                }
                $_request->headers['authorization'] = OSSUtils::getSignature($_request, $request->bucketName, $accessKeyId, $accessKeySecret, $this->_signatureVersion, $this->_addtionalHeaders);
                $_lastRequest                       = $_request;
                $_response                          = Tea::send($_request, $_runtime);
                $respMap                            = null;
                $bodyStr                            = null;
                if (Utils::is4xx($_response->statusCode) || Utils::is5xx($_response->statusCode)) {
                    $bodyStr = Utils::readAsString($_response->body);
                    $respMap = OSSUtils::getErrMessage($bodyStr);

                    throw new TeaError([
                        'code'    => @$respMap['Code'],
                        'message' => @$respMap['Message'],
                        'data'    => [
                            'httpCode'  => $_response->statusCode,
                            'requestId' => @$respMap['RequestId'],
                            'hostId'    => @$respMap['HostId'],
                        ],
                    ]);
                }

                return GetObjectMetaResponse::fromMap(Tea::merge($_response->headers));
            } catch (Exception $e) {
                if (!($e instanceof TeaError)) {
                    $e = new TeaError([], $e->getMessage(), $e->getCode(), $e);
                }
                if (Tea::isRetryable($e)) {
                    $_lastException = $e;

                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest, $_lastException);
    }

    /**
     * @param GetBucketAclRequest $request
     * @param RuntimeOptions      $runtime
     *
     * @throws TeaError
     * @throws Exception
     * @throws TeaUnableRetryError
     *
     * @return GetBucketAclResponse
     */
    public function getBucketAcl($request, $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime = [
            'timeouted'      => 'retry',
            'readTimeout'    => Utils::defaultNumber($runtime->readTimeout, $this->_readTimeout),
            'connectTimeout' => Utils::defaultNumber($runtime->connectTimeout, $this->_connectTimeout),
            'localAddr'      => Utils::defaultString($runtime->localAddr, $this->_localAddr),
            'httpProxy'      => Utils::defaultString($runtime->httpProxy, $this->_httpProxy),
            'httpsProxy'     => Utils::defaultString($runtime->httpsProxy, $this->_httpsProxy),
            'noProxy'        => Utils::defaultString($runtime->noProxy, $this->_noProxy),
            'socks5Proxy'    => Utils::defaultString($runtime->socks5Proxy, $this->_socks5Proxy),
            'socks5NetWork'  => Utils::defaultString($runtime->socks5NetWork, $this->_socks5NetWork),
            'maxIdleConns'   => Utils::defaultNumber($runtime->maxIdleConns, $this->_maxIdleConns),
            'retry'          => [
                'retryable'   => $runtime->autoretry,
                'maxAttempts' => Utils::defaultNumber($runtime->maxAttempts, 3),
            ],
            'backoff' => [
                'policy' => Utils::defaultString($runtime->backoffPolicy, 'no'),
                'period' => Utils::defaultNumber($runtime->backoffPeriod, 1),
            ],
            'ignoreSSL' => $runtime->ignoreSSL,
        ];
        $_lastRequest   = null;
        $_lastException = null;
        $_now           = time();
        $_retryTimes    = 0;
        while (Tea::allowRetry(@$_runtime['retry'], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime(@$_runtime['backoff'], $_retryTimes);
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
                $_request->method   = 'GET';
                $_request->pathname = '/?acl';
                $_request->headers  = [
                    'host'       => OSSUtils::getHost($request->bucketName, $this->_regionId, $this->_endpoint, $this->_hostModel),
                    'date'       => Utils::getDateUTCString(),
                    'user-agent' => $this->getUserAgent(),
                ];
                if (!Utils::empty_($token)) {
                    $_request->headers['x-oss-security-token'] = $token;
                }
                $_request->headers['authorization'] = OSSUtils::getSignature($_request, $request->bucketName, $accessKeyId, $accessKeySecret, $this->_signatureVersion, $this->_addtionalHeaders);
                $_lastRequest                       = $_request;
                $_response                          = Tea::send($_request, $_runtime);
                $respMap                            = null;
                $bodyStr                            = null;
                if (Utils::is4xx($_response->statusCode) || Utils::is5xx($_response->statusCode)) {
                    $bodyStr = Utils::readAsString($_response->body);
                    $respMap = OSSUtils::getErrMessage($bodyStr);

                    throw new TeaError([
                        'code'    => @$respMap['Code'],
                        'message' => @$respMap['Message'],
                        'data'    => [
                            'httpCode'  => $_response->statusCode,
                            'requestId' => @$respMap['RequestId'],
                            'hostId'    => @$respMap['HostId'],
                        ],
                    ]);
                }
                $bodyStr = Utils::readAsString($_response->body);
                $respMap = XML::parseXml($bodyStr, GetBucketAclResponse::class);

                return GetBucketAclResponse::fromMap(Tea::merge([
                    'AccessControlPolicy' => @$respMap['AccessControlPolicy'],
                ], $_response->headers));
            } catch (Exception $e) {
                if (!($e instanceof TeaError)) {
                    $e = new TeaError([], $e->getMessage(), $e->getCode(), $e);
                }
                if (Tea::isRetryable($e)) {
                    $_lastException = $e;

                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest, $_lastException);
    }

    /**
     * @param ListPartsRequest $request
     * @param RuntimeOptions   $runtime
     *
     * @throws TeaError
     * @throws Exception
     * @throws TeaUnableRetryError
     *
     * @return ListPartsResponse
     */
    public function listParts($request, $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime = [
            'timeouted'      => 'retry',
            'readTimeout'    => Utils::defaultNumber($runtime->readTimeout, $this->_readTimeout),
            'connectTimeout' => Utils::defaultNumber($runtime->connectTimeout, $this->_connectTimeout),
            'localAddr'      => Utils::defaultString($runtime->localAddr, $this->_localAddr),
            'httpProxy'      => Utils::defaultString($runtime->httpProxy, $this->_httpProxy),
            'httpsProxy'     => Utils::defaultString($runtime->httpsProxy, $this->_httpsProxy),
            'noProxy'        => Utils::defaultString($runtime->noProxy, $this->_noProxy),
            'socks5Proxy'    => Utils::defaultString($runtime->socks5Proxy, $this->_socks5Proxy),
            'socks5NetWork'  => Utils::defaultString($runtime->socks5NetWork, $this->_socks5NetWork),
            'maxIdleConns'   => Utils::defaultNumber($runtime->maxIdleConns, $this->_maxIdleConns),
            'retry'          => [
                'retryable'   => $runtime->autoretry,
                'maxAttempts' => Utils::defaultNumber($runtime->maxAttempts, 3),
            ],
            'backoff' => [
                'policy' => Utils::defaultString($runtime->backoffPolicy, 'no'),
                'period' => Utils::defaultNumber($runtime->backoffPeriod, 1),
            ],
            'ignoreSSL' => $runtime->ignoreSSL,
        ];
        $_lastRequest   = null;
        $_lastException = null;
        $_now           = time();
        $_retryTimes    = 0;
        while (Tea::allowRetry(@$_runtime['retry'], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime(@$_runtime['backoff'], $_retryTimes);
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
                $_request->method   = 'GET';
                $_request->pathname = '/' . $request->objectName . '';
                $_request->headers  = [
                    'host'       => OSSUtils::getHost($request->bucketName, $this->_regionId, $this->_endpoint, $this->_hostModel),
                    'date'       => Utils::getDateUTCString(),
                    'user-agent' => $this->getUserAgent(),
                ];
                if (!Utils::empty_($token)) {
                    $_request->headers['x-oss-security-token'] = $token;
                }
                $_request->query                    = Utils::stringifyMapValue($request->filter->toMap());
                $_request->headers['authorization'] = OSSUtils::getSignature($_request, $request->bucketName, $accessKeyId, $accessKeySecret, $this->_signatureVersion, $this->_addtionalHeaders);
                $_lastRequest                       = $_request;
                $_response                          = Tea::send($_request, $_runtime);
                $respMap                            = null;
                $bodyStr                            = null;
                if (Utils::is4xx($_response->statusCode) || Utils::is5xx($_response->statusCode)) {
                    $bodyStr = Utils::readAsString($_response->body);
                    $respMap = OSSUtils::getErrMessage($bodyStr);

                    throw new TeaError([
                        'code'    => @$respMap['Code'],
                        'message' => @$respMap['Message'],
                        'data'    => [
                            'httpCode'  => $_response->statusCode,
                            'requestId' => @$respMap['RequestId'],
                            'hostId'    => @$respMap['HostId'],
                        ],
                    ]);
                }
                $bodyStr = Utils::readAsString($_response->body);
                $respMap = XML::parseXml($bodyStr, ListPartsResponse::class);

                return ListPartsResponse::fromMap(Tea::merge([
                    'ListPartsResult' => @$respMap['ListPartsResult'],
                ], $_response->headers));
            } catch (Exception $e) {
                if (!($e instanceof TeaError)) {
                    $e = new TeaError([], $e->getMessage(), $e->getCode(), $e);
                }
                if (Tea::isRetryable($e)) {
                    $_lastException = $e;

                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest, $_lastException);
    }

    /**
     * @param GetLiveChannelHistoryRequest $request
     * @param RuntimeOptions               $runtime
     *
     * @throws TeaError
     * @throws Exception
     * @throws TeaUnableRetryError
     *
     * @return GetLiveChannelHistoryResponse
     */
    public function getLiveChannelHistory($request, $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime = [
            'timeouted'      => 'retry',
            'readTimeout'    => Utils::defaultNumber($runtime->readTimeout, $this->_readTimeout),
            'connectTimeout' => Utils::defaultNumber($runtime->connectTimeout, $this->_connectTimeout),
            'localAddr'      => Utils::defaultString($runtime->localAddr, $this->_localAddr),
            'httpProxy'      => Utils::defaultString($runtime->httpProxy, $this->_httpProxy),
            'httpsProxy'     => Utils::defaultString($runtime->httpsProxy, $this->_httpsProxy),
            'noProxy'        => Utils::defaultString($runtime->noProxy, $this->_noProxy),
            'socks5Proxy'    => Utils::defaultString($runtime->socks5Proxy, $this->_socks5Proxy),
            'socks5NetWork'  => Utils::defaultString($runtime->socks5NetWork, $this->_socks5NetWork),
            'maxIdleConns'   => Utils::defaultNumber($runtime->maxIdleConns, $this->_maxIdleConns),
            'retry'          => [
                'retryable'   => $runtime->autoretry,
                'maxAttempts' => Utils::defaultNumber($runtime->maxAttempts, 3),
            ],
            'backoff' => [
                'policy' => Utils::defaultString($runtime->backoffPolicy, 'no'),
                'period' => Utils::defaultNumber($runtime->backoffPeriod, 1),
            ],
            'ignoreSSL' => $runtime->ignoreSSL,
        ];
        $_lastRequest   = null;
        $_lastException = null;
        $_now           = time();
        $_retryTimes    = 0;
        while (Tea::allowRetry(@$_runtime['retry'], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime(@$_runtime['backoff'], $_retryTimes);
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
                $_request->method   = 'GET';
                $_request->pathname = '/' . $request->channelName . '?live';
                $_request->headers  = [
                    'host'       => OSSUtils::getHost($request->bucketName, $this->_regionId, $this->_endpoint, $this->_hostModel),
                    'date'       => Utils::getDateUTCString(),
                    'user-agent' => $this->getUserAgent(),
                ];
                if (!Utils::empty_($token)) {
                    $_request->headers['x-oss-security-token'] = $token;
                }
                $_request->query                    = Utils::stringifyMapValue($request->filter->toMap());
                $_request->headers['authorization'] = OSSUtils::getSignature($_request, $request->bucketName, $accessKeyId, $accessKeySecret, $this->_signatureVersion, $this->_addtionalHeaders);
                $_lastRequest                       = $_request;
                $_response                          = Tea::send($_request, $_runtime);
                $respMap                            = null;
                $bodyStr                            = null;
                if (Utils::is4xx($_response->statusCode) || Utils::is5xx($_response->statusCode)) {
                    $bodyStr = Utils::readAsString($_response->body);
                    $respMap = OSSUtils::getErrMessage($bodyStr);

                    throw new TeaError([
                        'code'    => @$respMap['Code'],
                        'message' => @$respMap['Message'],
                        'data'    => [
                            'httpCode'  => $_response->statusCode,
                            'requestId' => @$respMap['RequestId'],
                            'hostId'    => @$respMap['HostId'],
                        ],
                    ]);
                }
                $bodyStr = Utils::readAsString($_response->body);
                $respMap = XML::parseXml($bodyStr, GetLiveChannelHistoryResponse::class);

                return GetLiveChannelHistoryResponse::fromMap(Tea::merge([
                    'LiveChannelHistory' => @$respMap['LiveChannelHistory'],
                ], $_response->headers));
            } catch (Exception $e) {
                if (!($e instanceof TeaError)) {
                    $e = new TeaError([], $e->getMessage(), $e->getCode(), $e);
                }
                if (Tea::isRetryable($e)) {
                    $_lastException = $e;

                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest, $_lastException);
    }

    /**
     * @param GetBucketRequest $request
     * @param RuntimeOptions   $runtime
     *
     * @throws TeaError
     * @throws Exception
     * @throws TeaUnableRetryError
     *
     * @return GetBucketResponse
     */
    public function getBucket($request, $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime = [
            'timeouted'      => 'retry',
            'readTimeout'    => Utils::defaultNumber($runtime->readTimeout, $this->_readTimeout),
            'connectTimeout' => Utils::defaultNumber($runtime->connectTimeout, $this->_connectTimeout),
            'localAddr'      => Utils::defaultString($runtime->localAddr, $this->_localAddr),
            'httpProxy'      => Utils::defaultString($runtime->httpProxy, $this->_httpProxy),
            'httpsProxy'     => Utils::defaultString($runtime->httpsProxy, $this->_httpsProxy),
            'noProxy'        => Utils::defaultString($runtime->noProxy, $this->_noProxy),
            'socks5Proxy'    => Utils::defaultString($runtime->socks5Proxy, $this->_socks5Proxy),
            'socks5NetWork'  => Utils::defaultString($runtime->socks5NetWork, $this->_socks5NetWork),
            'maxIdleConns'   => Utils::defaultNumber($runtime->maxIdleConns, $this->_maxIdleConns),
            'retry'          => [
                'retryable'   => $runtime->autoretry,
                'maxAttempts' => Utils::defaultNumber($runtime->maxAttempts, 3),
            ],
            'backoff' => [
                'policy' => Utils::defaultString($runtime->backoffPolicy, 'no'),
                'period' => Utils::defaultNumber($runtime->backoffPeriod, 1),
            ],
            'ignoreSSL' => $runtime->ignoreSSL,
        ];
        $_lastRequest   = null;
        $_lastException = null;
        $_now           = time();
        $_retryTimes    = 0;
        while (Tea::allowRetry(@$_runtime['retry'], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime(@$_runtime['backoff'], $_retryTimes);
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
                $_request->method   = 'GET';
                $_request->pathname = '/';
                $_request->headers  = [
                    'host'       => OSSUtils::getHost($request->bucketName, $this->_regionId, $this->_endpoint, $this->_hostModel),
                    'date'       => Utils::getDateUTCString(),
                    'user-agent' => $this->getUserAgent(),
                ];
                if (!Utils::empty_($token)) {
                    $_request->headers['x-oss-security-token'] = $token;
                }
                $_request->query                    = Utils::stringifyMapValue($request->filter->toMap());
                $_request->headers['authorization'] = OSSUtils::getSignature($_request, $request->bucketName, $accessKeyId, $accessKeySecret, $this->_signatureVersion, $this->_addtionalHeaders);
                $_lastRequest                       = $_request;
                $_response                          = Tea::send($_request, $_runtime);
                $respMap                            = null;
                $bodyStr                            = null;
                if (Utils::is4xx($_response->statusCode) || Utils::is5xx($_response->statusCode)) {
                    $bodyStr = Utils::readAsString($_response->body);
                    $respMap = OSSUtils::getErrMessage($bodyStr);

                    throw new TeaError([
                        'code'    => @$respMap['Code'],
                        'message' => @$respMap['Message'],
                        'data'    => [
                            'httpCode'  => $_response->statusCode,
                            'requestId' => @$respMap['RequestId'],
                            'hostId'    => @$respMap['HostId'],
                        ],
                    ]);
                }
                $bodyStr = Utils::readAsString($_response->body);
                $respMap = XML::parseXml($bodyStr, GetBucketResponse::class);

                return GetBucketResponse::fromMap(Tea::merge([
                    'ListBucketResult' => @$respMap['ListBucketResult'],
                ], $_response->headers));
            } catch (Exception $e) {
                if (!($e instanceof TeaError)) {
                    $e = new TeaError([], $e->getMessage(), $e->getCode(), $e);
                }
                if (Tea::isRetryable($e)) {
                    $_lastException = $e;

                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest, $_lastException);
    }

    /**
     * @param GetLiveChannelInfoRequest $request
     * @param RuntimeOptions            $runtime
     *
     * @throws TeaError
     * @throws Exception
     * @throws TeaUnableRetryError
     *
     * @return GetLiveChannelInfoResponse
     */
    public function getLiveChannelInfo($request, $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime = [
            'timeouted'      => 'retry',
            'readTimeout'    => Utils::defaultNumber($runtime->readTimeout, $this->_readTimeout),
            'connectTimeout' => Utils::defaultNumber($runtime->connectTimeout, $this->_connectTimeout),
            'localAddr'      => Utils::defaultString($runtime->localAddr, $this->_localAddr),
            'httpProxy'      => Utils::defaultString($runtime->httpProxy, $this->_httpProxy),
            'httpsProxy'     => Utils::defaultString($runtime->httpsProxy, $this->_httpsProxy),
            'noProxy'        => Utils::defaultString($runtime->noProxy, $this->_noProxy),
            'socks5Proxy'    => Utils::defaultString($runtime->socks5Proxy, $this->_socks5Proxy),
            'socks5NetWork'  => Utils::defaultString($runtime->socks5NetWork, $this->_socks5NetWork),
            'maxIdleConns'   => Utils::defaultNumber($runtime->maxIdleConns, $this->_maxIdleConns),
            'retry'          => [
                'retryable'   => $runtime->autoretry,
                'maxAttempts' => Utils::defaultNumber($runtime->maxAttempts, 3),
            ],
            'backoff' => [
                'policy' => Utils::defaultString($runtime->backoffPolicy, 'no'),
                'period' => Utils::defaultNumber($runtime->backoffPeriod, 1),
            ],
            'ignoreSSL' => $runtime->ignoreSSL,
        ];
        $_lastRequest   = null;
        $_lastException = null;
        $_now           = time();
        $_retryTimes    = 0;
        while (Tea::allowRetry(@$_runtime['retry'], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime(@$_runtime['backoff'], $_retryTimes);
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
                $_request->method   = 'GET';
                $_request->pathname = '/' . $request->channelName . '?live';
                $_request->headers  = [
                    'host'       => OSSUtils::getHost($request->bucketName, $this->_regionId, $this->_endpoint, $this->_hostModel),
                    'date'       => Utils::getDateUTCString(),
                    'user-agent' => $this->getUserAgent(),
                ];
                if (!Utils::empty_($token)) {
                    $_request->headers['x-oss-security-token'] = $token;
                }
                $_request->headers['authorization'] = OSSUtils::getSignature($_request, $request->bucketName, $accessKeyId, $accessKeySecret, $this->_signatureVersion, $this->_addtionalHeaders);
                $_lastRequest                       = $_request;
                $_response                          = Tea::send($_request, $_runtime);
                $respMap                            = null;
                $bodyStr                            = null;
                if (Utils::is4xx($_response->statusCode) || Utils::is5xx($_response->statusCode)) {
                    $bodyStr = Utils::readAsString($_response->body);
                    $respMap = OSSUtils::getErrMessage($bodyStr);

                    throw new TeaError([
                        'code'    => @$respMap['Code'],
                        'message' => @$respMap['Message'],
                        'data'    => [
                            'httpCode'  => $_response->statusCode,
                            'requestId' => @$respMap['RequestId'],
                            'hostId'    => @$respMap['HostId'],
                        ],
                    ]);
                }
                $bodyStr = Utils::readAsString($_response->body);
                $respMap = XML::parseXml($bodyStr, GetLiveChannelInfoResponse::class);

                return GetLiveChannelInfoResponse::fromMap(Tea::merge([
                    'LiveChannelConfiguration' => @$respMap['LiveChannelConfiguration'],
                ], $_response->headers));
            } catch (Exception $e) {
                if (!($e instanceof TeaError)) {
                    $e = new TeaError([], $e->getMessage(), $e->getCode(), $e);
                }
                if (Tea::isRetryable($e)) {
                    $_lastException = $e;

                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest, $_lastException);
    }

    /**
     * @param GetLiveChannelStatRequest $request
     * @param RuntimeOptions            $runtime
     *
     * @throws TeaError
     * @throws Exception
     * @throws TeaUnableRetryError
     *
     * @return GetLiveChannelStatResponse
     */
    public function getLiveChannelStat($request, $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime = [
            'timeouted'      => 'retry',
            'readTimeout'    => Utils::defaultNumber($runtime->readTimeout, $this->_readTimeout),
            'connectTimeout' => Utils::defaultNumber($runtime->connectTimeout, $this->_connectTimeout),
            'localAddr'      => Utils::defaultString($runtime->localAddr, $this->_localAddr),
            'httpProxy'      => Utils::defaultString($runtime->httpProxy, $this->_httpProxy),
            'httpsProxy'     => Utils::defaultString($runtime->httpsProxy, $this->_httpsProxy),
            'noProxy'        => Utils::defaultString($runtime->noProxy, $this->_noProxy),
            'socks5Proxy'    => Utils::defaultString($runtime->socks5Proxy, $this->_socks5Proxy),
            'socks5NetWork'  => Utils::defaultString($runtime->socks5NetWork, $this->_socks5NetWork),
            'maxIdleConns'   => Utils::defaultNumber($runtime->maxIdleConns, $this->_maxIdleConns),
            'retry'          => [
                'retryable'   => $runtime->autoretry,
                'maxAttempts' => Utils::defaultNumber($runtime->maxAttempts, 3),
            ],
            'backoff' => [
                'policy' => Utils::defaultString($runtime->backoffPolicy, 'no'),
                'period' => Utils::defaultNumber($runtime->backoffPeriod, 1),
            ],
            'ignoreSSL' => $runtime->ignoreSSL,
        ];
        $_lastRequest   = null;
        $_lastException = null;
        $_now           = time();
        $_retryTimes    = 0;
        while (Tea::allowRetry(@$_runtime['retry'], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime(@$_runtime['backoff'], $_retryTimes);
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
                $_request->method   = 'GET';
                $_request->pathname = '/' . $request->channelName . '?live';
                $_request->headers  = [
                    'host'       => OSSUtils::getHost($request->bucketName, $this->_regionId, $this->_endpoint, $this->_hostModel),
                    'date'       => Utils::getDateUTCString(),
                    'user-agent' => $this->getUserAgent(),
                ];
                if (!Utils::empty_($token)) {
                    $_request->headers['x-oss-security-token'] = $token;
                }
                $_request->query                    = Utils::stringifyMapValue($request->filter->toMap());
                $_request->headers['authorization'] = OSSUtils::getSignature($_request, $request->bucketName, $accessKeyId, $accessKeySecret, $this->_signatureVersion, $this->_addtionalHeaders);
                $_lastRequest                       = $_request;
                $_response                          = Tea::send($_request, $_runtime);
                $respMap                            = null;
                $bodyStr                            = null;
                if (Utils::is4xx($_response->statusCode) || Utils::is5xx($_response->statusCode)) {
                    $bodyStr = Utils::readAsString($_response->body);
                    $respMap = OSSUtils::getErrMessage($bodyStr);

                    throw new TeaError([
                        'code'    => @$respMap['Code'],
                        'message' => @$respMap['Message'],
                        'data'    => [
                            'httpCode'  => $_response->statusCode,
                            'requestId' => @$respMap['RequestId'],
                            'hostId'    => @$respMap['HostId'],
                        ],
                    ]);
                }
                $bodyStr = Utils::readAsString($_response->body);
                $respMap = XML::parseXml($bodyStr, GetLiveChannelStatResponse::class);

                return GetLiveChannelStatResponse::fromMap(Tea::merge([
                    'LiveChannelStat' => @$respMap['LiveChannelStat'],
                ], $_response->headers));
            } catch (Exception $e) {
                if (!($e instanceof TeaError)) {
                    $e = new TeaError([], $e->getMessage(), $e->getCode(), $e);
                }
                if (Tea::isRetryable($e)) {
                    $_lastException = $e;

                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest, $_lastException);
    }

    /**
     * @param DeleteObjectRequest $request
     * @param RuntimeOptions      $runtime
     *
     * @throws TeaError
     * @throws Exception
     * @throws TeaUnableRetryError
     *
     * @return DeleteObjectResponse
     */
    public function deleteObject($request, $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime = [
            'timeouted'      => 'retry',
            'readTimeout'    => Utils::defaultNumber($runtime->readTimeout, $this->_readTimeout),
            'connectTimeout' => Utils::defaultNumber($runtime->connectTimeout, $this->_connectTimeout),
            'localAddr'      => Utils::defaultString($runtime->localAddr, $this->_localAddr),
            'httpProxy'      => Utils::defaultString($runtime->httpProxy, $this->_httpProxy),
            'httpsProxy'     => Utils::defaultString($runtime->httpsProxy, $this->_httpsProxy),
            'noProxy'        => Utils::defaultString($runtime->noProxy, $this->_noProxy),
            'socks5Proxy'    => Utils::defaultString($runtime->socks5Proxy, $this->_socks5Proxy),
            'socks5NetWork'  => Utils::defaultString($runtime->socks5NetWork, $this->_socks5NetWork),
            'maxIdleConns'   => Utils::defaultNumber($runtime->maxIdleConns, $this->_maxIdleConns),
            'retry'          => [
                'retryable'   => $runtime->autoretry,
                'maxAttempts' => Utils::defaultNumber($runtime->maxAttempts, 3),
            ],
            'backoff' => [
                'policy' => Utils::defaultString($runtime->backoffPolicy, 'no'),
                'period' => Utils::defaultNumber($runtime->backoffPeriod, 1),
            ],
            'ignoreSSL' => $runtime->ignoreSSL,
        ];
        $_lastRequest   = null;
        $_lastException = null;
        $_now           = time();
        $_retryTimes    = 0;
        while (Tea::allowRetry(@$_runtime['retry'], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime(@$_runtime['backoff'], $_retryTimes);
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
                $_request->method   = 'DELETE';
                $_request->pathname = '/' . $request->objectName . '';
                $_request->headers  = [
                    'host'       => OSSUtils::getHost($request->bucketName, $this->_regionId, $this->_endpoint, $this->_hostModel),
                    'date'       => Utils::getDateUTCString(),
                    'user-agent' => $this->getUserAgent(),
                ];
                if (!Utils::empty_($token)) {
                    $_request->headers['x-oss-security-token'] = $token;
                }
                $_request->headers['authorization'] = OSSUtils::getSignature($_request, $request->bucketName, $accessKeyId, $accessKeySecret, $this->_signatureVersion, $this->_addtionalHeaders);
                $_lastRequest                       = $_request;
                $_response                          = Tea::send($_request, $_runtime);
                $respMap                            = null;
                $bodyStr                            = null;
                if (Utils::is4xx($_response->statusCode) || Utils::is5xx($_response->statusCode)) {
                    $bodyStr = Utils::readAsString($_response->body);
                    $respMap = OSSUtils::getErrMessage($bodyStr);

                    throw new TeaError([
                        'code'    => @$respMap['Code'],
                        'message' => @$respMap['Message'],
                        'data'    => [
                            'httpCode'  => $_response->statusCode,
                            'requestId' => @$respMap['RequestId'],
                            'hostId'    => @$respMap['HostId'],
                        ],
                    ]);
                }

                return DeleteObjectResponse::fromMap(Tea::merge($_response->headers));
            } catch (Exception $e) {
                if (!($e instanceof TeaError)) {
                    $e = new TeaError([], $e->getMessage(), $e->getCode(), $e);
                }
                if (Tea::isRetryable($e)) {
                    $_lastException = $e;

                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest, $_lastException);
    }

    /**
     * @param AbortMultipartUploadRequest $request
     * @param RuntimeOptions              $runtime
     *
     * @throws TeaError
     * @throws Exception
     * @throws TeaUnableRetryError
     *
     * @return AbortMultipartUploadResponse
     */
    public function abortMultipartUpload($request, $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime = [
            'timeouted'      => 'retry',
            'readTimeout'    => Utils::defaultNumber($runtime->readTimeout, $this->_readTimeout),
            'connectTimeout' => Utils::defaultNumber($runtime->connectTimeout, $this->_connectTimeout),
            'localAddr'      => Utils::defaultString($runtime->localAddr, $this->_localAddr),
            'httpProxy'      => Utils::defaultString($runtime->httpProxy, $this->_httpProxy),
            'httpsProxy'     => Utils::defaultString($runtime->httpsProxy, $this->_httpsProxy),
            'noProxy'        => Utils::defaultString($runtime->noProxy, $this->_noProxy),
            'socks5Proxy'    => Utils::defaultString($runtime->socks5Proxy, $this->_socks5Proxy),
            'socks5NetWork'  => Utils::defaultString($runtime->socks5NetWork, $this->_socks5NetWork),
            'maxIdleConns'   => Utils::defaultNumber($runtime->maxIdleConns, $this->_maxIdleConns),
            'retry'          => [
                'retryable'   => $runtime->autoretry,
                'maxAttempts' => Utils::defaultNumber($runtime->maxAttempts, 3),
            ],
            'backoff' => [
                'policy' => Utils::defaultString($runtime->backoffPolicy, 'no'),
                'period' => Utils::defaultNumber($runtime->backoffPeriod, 1),
            ],
            'ignoreSSL' => $runtime->ignoreSSL,
        ];
        $_lastRequest   = null;
        $_lastException = null;
        $_now           = time();
        $_retryTimes    = 0;
        while (Tea::allowRetry(@$_runtime['retry'], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime(@$_runtime['backoff'], $_retryTimes);
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
                $_request->method   = 'DELETE';
                $_request->pathname = '/' . $request->objectName . '';
                $_request->headers  = [
                    'host'       => OSSUtils::getHost($request->bucketName, $this->_regionId, $this->_endpoint, $this->_hostModel),
                    'date'       => Utils::getDateUTCString(),
                    'user-agent' => $this->getUserAgent(),
                ];
                if (!Utils::empty_($token)) {
                    $_request->headers['x-oss-security-token'] = $token;
                }
                $_request->query                    = Utils::stringifyMapValue($request->filter->toMap());
                $_request->headers['authorization'] = OSSUtils::getSignature($_request, $request->bucketName, $accessKeyId, $accessKeySecret, $this->_signatureVersion, $this->_addtionalHeaders);
                $_lastRequest                       = $_request;
                $_response                          = Tea::send($_request, $_runtime);
                $respMap                            = null;
                $bodyStr                            = null;
                if (Utils::is4xx($_response->statusCode) || Utils::is5xx($_response->statusCode)) {
                    $bodyStr = Utils::readAsString($_response->body);
                    $respMap = OSSUtils::getErrMessage($bodyStr);

                    throw new TeaError([
                        'code'    => @$respMap['Code'],
                        'message' => @$respMap['Message'],
                        'data'    => [
                            'httpCode'  => $_response->statusCode,
                            'requestId' => @$respMap['RequestId'],
                            'hostId'    => @$respMap['HostId'],
                        ],
                    ]);
                }

                return AbortMultipartUploadResponse::fromMap(Tea::merge($_response->headers));
            } catch (Exception $e) {
                if (!($e instanceof TeaError)) {
                    $e = new TeaError([], $e->getMessage(), $e->getCode(), $e);
                }
                if (Tea::isRetryable($e)) {
                    $_lastException = $e;

                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest, $_lastException);
    }

    /**
     * @param AppendObjectRequest $request
     * @param RuntimeOptions      $runtime
     *
     * @throws TeaError
     * @throws Exception
     * @throws TeaUnableRetryError
     *
     * @return AppendObjectResponse
     */
    public function appendObject($request, $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime = [
            'timeouted'      => 'retry',
            'readTimeout'    => Utils::defaultNumber($runtime->readTimeout, $this->_readTimeout),
            'connectTimeout' => Utils::defaultNumber($runtime->connectTimeout, $this->_connectTimeout),
            'localAddr'      => Utils::defaultString($runtime->localAddr, $this->_localAddr),
            'httpProxy'      => Utils::defaultString($runtime->httpProxy, $this->_httpProxy),
            'httpsProxy'     => Utils::defaultString($runtime->httpsProxy, $this->_httpsProxy),
            'noProxy'        => Utils::defaultString($runtime->noProxy, $this->_noProxy),
            'socks5Proxy'    => Utils::defaultString($runtime->socks5Proxy, $this->_socks5Proxy),
            'socks5NetWork'  => Utils::defaultString($runtime->socks5NetWork, $this->_socks5NetWork),
            'maxIdleConns'   => Utils::defaultNumber($runtime->maxIdleConns, $this->_maxIdleConns),
            'retry'          => [
                'retryable'   => $runtime->autoretry,
                'maxAttempts' => Utils::defaultNumber($runtime->maxAttempts, 3),
            ],
            'backoff' => [
                'policy' => Utils::defaultString($runtime->backoffPolicy, 'no'),
                'period' => Utils::defaultNumber($runtime->backoffPeriod, 1),
            ],
            'ignoreSSL' => $runtime->ignoreSSL,
        ];
        $_lastRequest   = null;
        $_lastException = null;
        $_now           = time();
        $_retryTimes    = 0;
        while (Tea::allowRetry(@$_runtime['retry'], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime(@$_runtime['backoff'], $_retryTimes);
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
                $_request->method   = 'POST';
                $_request->pathname = '/' . $request->objectName . '?append';
                $_request->headers  = Tea::merge([
                    'host'       => OSSUtils::getHost($request->bucketName, $this->_regionId, $this->_endpoint, $this->_hostModel),
                    'date'       => Utils::getDateUTCString(),
                    'user-agent' => $this->getUserAgent(),
                ], Utils::stringifyMapValue($request->header->toMap()), OSSUtils::parseMeta($request->userMeta, 'x-oss-meta-'));
                if (!Utils::empty_($token)) {
                    $_request->headers['x-oss-security-token'] = $token;
                }
                $_request->query = Utils::stringifyMapValue($request->filter->toMap());
                $_request->body  = OSSUtils::inject($request->body, $ctx);
                if (!Utils::isUnset($request->header) && !Utils::empty_($request->header->contentType)) {
                    $_request->headers['content-type'] = $request->header->contentType;
                } else {
                    $_request->headers['content-type'] = OSSUtils::getContentType($request->objectName);
                }
                $_request->headers['authorization'] = OSSUtils::getSignature($_request, $request->bucketName, $accessKeyId, $accessKeySecret, $this->_signatureVersion, $this->_addtionalHeaders);
                $_lastRequest                       = $_request;
                $_response                          = Tea::send($_request, $_runtime);
                $respMap                            = null;
                $bodyStr                            = null;
                if (Utils::is4xx($_response->statusCode) || Utils::is5xx($_response->statusCode)) {
                    $bodyStr = Utils::readAsString($_response->body);
                    $respMap = OSSUtils::getErrMessage($bodyStr);

                    throw new TeaError([
                        'code'    => @$respMap['Code'],
                        'message' => @$respMap['Message'],
                        'data'    => [
                            'httpCode'  => $_response->statusCode,
                            'requestId' => @$respMap['RequestId'],
                            'hostId'    => @$respMap['HostId'],
                        ],
                    ]);
                }
                if ($this->_isEnableCrc && !Utils::equalString(@$ctx['crc'], $_response->headers['x-oss-hash-crc64ecma'])) {
                    throw new TeaError([
                        'code' => 'CrcNotMatched',
                        'data' => [
                            'clientCrc' => @$ctx['crc'],
                            'serverCrc' => $_response->headers['x-oss-hash-crc64ecma'],
                        ],
                    ]);
                }
                if ($this->_isEnableMD5 && !Utils::equalString(@$ctx['md5'], $_response->headers['content-md5'])) {
                    throw new TeaError([
                        'code' => 'MD5NotMatched',
                        'data' => [
                            'clientMD5' => @$ctx['md5'],
                            'serverMD5' => $_response->headers['content-md5'],
                        ],
                    ]);
                }

                return AppendObjectResponse::fromMap(Tea::merge($_response->headers));
            } catch (Exception $e) {
                if (!($e instanceof TeaError)) {
                    $e = new TeaError([], $e->getMessage(), $e->getCode(), $e);
                }
                if (Tea::isRetryable($e)) {
                    $_lastException = $e;

                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest, $_lastException);
    }

    /**
     * @param UploadPartCopyRequest $request
     * @param RuntimeOptions        $runtime
     *
     * @throws TeaError
     * @throws Exception
     * @throws TeaUnableRetryError
     *
     * @return UploadPartCopyResponse
     */
    public function uploadPartCopy($request, $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime = [
            'timeouted'      => 'retry',
            'readTimeout'    => Utils::defaultNumber($runtime->readTimeout, $this->_readTimeout),
            'connectTimeout' => Utils::defaultNumber($runtime->connectTimeout, $this->_connectTimeout),
            'localAddr'      => Utils::defaultString($runtime->localAddr, $this->_localAddr),
            'httpProxy'      => Utils::defaultString($runtime->httpProxy, $this->_httpProxy),
            'httpsProxy'     => Utils::defaultString($runtime->httpsProxy, $this->_httpsProxy),
            'noProxy'        => Utils::defaultString($runtime->noProxy, $this->_noProxy),
            'socks5Proxy'    => Utils::defaultString($runtime->socks5Proxy, $this->_socks5Proxy),
            'socks5NetWork'  => Utils::defaultString($runtime->socks5NetWork, $this->_socks5NetWork),
            'maxIdleConns'   => Utils::defaultNumber($runtime->maxIdleConns, $this->_maxIdleConns),
            'retry'          => [
                'retryable'   => $runtime->autoretry,
                'maxAttempts' => Utils::defaultNumber($runtime->maxAttempts, 3),
            ],
            'backoff' => [
                'policy' => Utils::defaultString($runtime->backoffPolicy, 'no'),
                'period' => Utils::defaultNumber($runtime->backoffPeriod, 1),
            ],
            'ignoreSSL' => $runtime->ignoreSSL,
        ];
        $_lastRequest   = null;
        $_lastException = null;
        $_now           = time();
        $_retryTimes    = 0;
        while (Tea::allowRetry(@$_runtime['retry'], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime(@$_runtime['backoff'], $_retryTimes);
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
                $_request->method   = 'PUT';
                $_request->pathname = '/' . $request->objectName . '';
                $_request->headers  = Tea::merge([
                    'host'       => OSSUtils::getHost($request->bucketName, $this->_regionId, $this->_endpoint, $this->_hostModel),
                    'date'       => Utils::getDateUTCString(),
                    'user-agent' => $this->getUserAgent(),
                ], Utils::stringifyMapValue($request->header->toMap()));
                if (!Utils::empty_($token)) {
                    $_request->headers['x-oss-security-token'] = $token;
                }
                $_request->query                    = Utils::stringifyMapValue($request->filter->toMap());
                $_request->headers['authorization'] = OSSUtils::getSignature($_request, $request->bucketName, $accessKeyId, $accessKeySecret, $this->_signatureVersion, $this->_addtionalHeaders);
                $_lastRequest                       = $_request;
                $_response                          = Tea::send($_request, $_runtime);
                $respMap                            = null;
                $bodyStr                            = null;
                if (Utils::is4xx($_response->statusCode) || Utils::is5xx($_response->statusCode)) {
                    $bodyStr = Utils::readAsString($_response->body);
                    $respMap = OSSUtils::getErrMessage($bodyStr);

                    throw new TeaError([
                        'code'    => @$respMap['Code'],
                        'message' => @$respMap['Message'],
                        'data'    => [
                            'httpCode'  => $_response->statusCode,
                            'requestId' => @$respMap['RequestId'],
                            'hostId'    => @$respMap['HostId'],
                        ],
                    ]);
                }
                $bodyStr = Utils::readAsString($_response->body);
                $respMap = XML::parseXml($bodyStr, UploadPartCopyResponse::class);

                return UploadPartCopyResponse::fromMap(Tea::merge([
                    'CopyPartResult' => @$respMap['CopyPartResult'],
                ], $_response->headers));
            } catch (Exception $e) {
                if (!($e instanceof TeaError)) {
                    $e = new TeaError([], $e->getMessage(), $e->getCode(), $e);
                }
                if (Tea::isRetryable($e)) {
                    $_lastException = $e;

                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest, $_lastException);
    }

    /**
     * @param GetVodPlaylistRequest $request
     * @param RuntimeOptions        $runtime
     *
     * @throws TeaError
     * @throws Exception
     * @throws TeaUnableRetryError
     *
     * @return GetVodPlaylistResponse
     */
    public function getVodPlaylist($request, $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime = [
            'timeouted'      => 'retry',
            'readTimeout'    => Utils::defaultNumber($runtime->readTimeout, $this->_readTimeout),
            'connectTimeout' => Utils::defaultNumber($runtime->connectTimeout, $this->_connectTimeout),
            'localAddr'      => Utils::defaultString($runtime->localAddr, $this->_localAddr),
            'httpProxy'      => Utils::defaultString($runtime->httpProxy, $this->_httpProxy),
            'httpsProxy'     => Utils::defaultString($runtime->httpsProxy, $this->_httpsProxy),
            'noProxy'        => Utils::defaultString($runtime->noProxy, $this->_noProxy),
            'socks5Proxy'    => Utils::defaultString($runtime->socks5Proxy, $this->_socks5Proxy),
            'socks5NetWork'  => Utils::defaultString($runtime->socks5NetWork, $this->_socks5NetWork),
            'maxIdleConns'   => Utils::defaultNumber($runtime->maxIdleConns, $this->_maxIdleConns),
            'retry'          => [
                'retryable'   => $runtime->autoretry,
                'maxAttempts' => Utils::defaultNumber($runtime->maxAttempts, 3),
            ],
            'backoff' => [
                'policy' => Utils::defaultString($runtime->backoffPolicy, 'no'),
                'period' => Utils::defaultNumber($runtime->backoffPeriod, 1),
            ],
            'ignoreSSL' => $runtime->ignoreSSL,
        ];
        $_lastRequest   = null;
        $_lastException = null;
        $_now           = time();
        $_retryTimes    = 0;
        while (Tea::allowRetry(@$_runtime['retry'], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime(@$_runtime['backoff'], $_retryTimes);
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
                $_request->method   = 'GET';
                $_request->pathname = '/' . $request->channelName . '?vod';
                $_request->headers  = [
                    'host'       => OSSUtils::getHost($request->bucketName, $this->_regionId, $this->_endpoint, $this->_hostModel),
                    'date'       => Utils::getDateUTCString(),
                    'user-agent' => $this->getUserAgent(),
                ];
                if (!Utils::empty_($token)) {
                    $_request->headers['x-oss-security-token'] = $token;
                }
                $_request->query                    = Utils::stringifyMapValue($request->filter->toMap());
                $_request->headers['authorization'] = OSSUtils::getSignature($_request, $request->bucketName, $accessKeyId, $accessKeySecret, $this->_signatureVersion, $this->_addtionalHeaders);
                $_lastRequest                       = $_request;
                $_response                          = Tea::send($_request, $_runtime);
                $respMap                            = null;
                $bodyStr                            = null;
                if (Utils::is4xx($_response->statusCode) || Utils::is5xx($_response->statusCode)) {
                    $bodyStr = Utils::readAsString($_response->body);
                    $respMap = OSSUtils::getErrMessage($bodyStr);

                    throw new TeaError([
                        'code'    => @$respMap['Code'],
                        'message' => @$respMap['Message'],
                        'data'    => [
                            'httpCode'  => $_response->statusCode,
                            'requestId' => @$respMap['RequestId'],
                            'hostId'    => @$respMap['HostId'],
                        ],
                    ]);
                }

                return GetVodPlaylistResponse::fromMap(Tea::merge($_response->headers));
            } catch (Exception $e) {
                if (!($e instanceof TeaError)) {
                    $e = new TeaError([], $e->getMessage(), $e->getCode(), $e);
                }
                if (Tea::isRetryable($e)) {
                    $_lastException = $e;

                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest, $_lastException);
    }

    /**
     * @param DeleteBucketCORSRequest $request
     * @param RuntimeOptions          $runtime
     *
     * @throws TeaError
     * @throws Exception
     * @throws TeaUnableRetryError
     *
     * @return DeleteBucketCORSResponse
     */
    public function deleteBucketCORS($request, $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime = [
            'timeouted'      => 'retry',
            'readTimeout'    => Utils::defaultNumber($runtime->readTimeout, $this->_readTimeout),
            'connectTimeout' => Utils::defaultNumber($runtime->connectTimeout, $this->_connectTimeout),
            'localAddr'      => Utils::defaultString($runtime->localAddr, $this->_localAddr),
            'httpProxy'      => Utils::defaultString($runtime->httpProxy, $this->_httpProxy),
            'httpsProxy'     => Utils::defaultString($runtime->httpsProxy, $this->_httpsProxy),
            'noProxy'        => Utils::defaultString($runtime->noProxy, $this->_noProxy),
            'socks5Proxy'    => Utils::defaultString($runtime->socks5Proxy, $this->_socks5Proxy),
            'socks5NetWork'  => Utils::defaultString($runtime->socks5NetWork, $this->_socks5NetWork),
            'maxIdleConns'   => Utils::defaultNumber($runtime->maxIdleConns, $this->_maxIdleConns),
            'retry'          => [
                'retryable'   => $runtime->autoretry,
                'maxAttempts' => Utils::defaultNumber($runtime->maxAttempts, 3),
            ],
            'backoff' => [
                'policy' => Utils::defaultString($runtime->backoffPolicy, 'no'),
                'period' => Utils::defaultNumber($runtime->backoffPeriod, 1),
            ],
            'ignoreSSL' => $runtime->ignoreSSL,
        ];
        $_lastRequest   = null;
        $_lastException = null;
        $_now           = time();
        $_retryTimes    = 0;
        while (Tea::allowRetry(@$_runtime['retry'], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime(@$_runtime['backoff'], $_retryTimes);
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
                $_request->method   = 'DELETE';
                $_request->pathname = '/?cors';
                $_request->headers  = [
                    'host'       => OSSUtils::getHost($request->bucketName, $this->_regionId, $this->_endpoint, $this->_hostModel),
                    'date'       => Utils::getDateUTCString(),
                    'user-agent' => $this->getUserAgent(),
                ];
                if (!Utils::empty_($token)) {
                    $_request->headers['x-oss-security-token'] = $token;
                }
                $_request->headers['authorization'] = OSSUtils::getSignature($_request, $request->bucketName, $accessKeyId, $accessKeySecret, $this->_signatureVersion, $this->_addtionalHeaders);
                $_lastRequest                       = $_request;
                $_response                          = Tea::send($_request, $_runtime);
                $respMap                            = null;
                $bodyStr                            = null;
                if (Utils::is4xx($_response->statusCode) || Utils::is5xx($_response->statusCode)) {
                    $bodyStr = Utils::readAsString($_response->body);
                    $respMap = OSSUtils::getErrMessage($bodyStr);

                    throw new TeaError([
                        'code'    => @$respMap['Code'],
                        'message' => @$respMap['Message'],
                        'data'    => [
                            'httpCode'  => $_response->statusCode,
                            'requestId' => @$respMap['RequestId'],
                            'hostId'    => @$respMap['HostId'],
                        ],
                    ]);
                }

                return DeleteBucketCORSResponse::fromMap(Tea::merge($_response->headers));
            } catch (Exception $e) {
                if (!($e instanceof TeaError)) {
                    $e = new TeaError([], $e->getMessage(), $e->getCode(), $e);
                }
                if (Tea::isRetryable($e)) {
                    $_lastException = $e;

                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest, $_lastException);
    }

    /**
     * @param GetObjectRequest $request
     * @param RuntimeOptions   $runtime
     *
     * @throws TeaError
     * @throws Exception
     * @throws TeaUnableRetryError
     *
     * @return GetObjectResponse
     */
    public function getObject($request, $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime = [
            'timeouted'      => 'retry',
            'readTimeout'    => Utils::defaultNumber($runtime->readTimeout, $this->_readTimeout),
            'connectTimeout' => Utils::defaultNumber($runtime->connectTimeout, $this->_connectTimeout),
            'localAddr'      => Utils::defaultString($runtime->localAddr, $this->_localAddr),
            'httpProxy'      => Utils::defaultString($runtime->httpProxy, $this->_httpProxy),
            'httpsProxy'     => Utils::defaultString($runtime->httpsProxy, $this->_httpsProxy),
            'noProxy'        => Utils::defaultString($runtime->noProxy, $this->_noProxy),
            'socks5Proxy'    => Utils::defaultString($runtime->socks5Proxy, $this->_socks5Proxy),
            'socks5NetWork'  => Utils::defaultString($runtime->socks5NetWork, $this->_socks5NetWork),
            'maxIdleConns'   => Utils::defaultNumber($runtime->maxIdleConns, $this->_maxIdleConns),
            'retry'          => [
                'retryable'   => $runtime->autoretry,
                'maxAttempts' => Utils::defaultNumber($runtime->maxAttempts, 3),
            ],
            'backoff' => [
                'policy' => Utils::defaultString($runtime->backoffPolicy, 'no'),
                'period' => Utils::defaultNumber($runtime->backoffPeriod, 1),
            ],
            'ignoreSSL' => $runtime->ignoreSSL,
        ];
        $_lastRequest   = null;
        $_lastException = null;
        $_now           = time();
        $_retryTimes    = 0;
        while (Tea::allowRetry(@$_runtime['retry'], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime(@$_runtime['backoff'], $_retryTimes);
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
                $_request->method   = 'GET';
                $_request->pathname = '/' . $request->objectName . '';
                $_request->headers  = Tea::merge([
                    'host'       => OSSUtils::getHost($request->bucketName, $this->_regionId, $this->_endpoint, $this->_hostModel),
                    'date'       => Utils::getDateUTCString(),
                    'user-agent' => $this->getUserAgent(),
                ], Utils::stringifyMapValue($request->header->toMap()));
                if (!Utils::empty_($token)) {
                    $_request->headers['x-oss-security-token'] = $token;
                }
                $_request->headers['authorization'] = OSSUtils::getSignature($_request, $request->bucketName, $accessKeyId, $accessKeySecret, $this->_signatureVersion, $this->_addtionalHeaders);
                $_lastRequest                       = $_request;
                $_response                          = Tea::send($_request, $_runtime);
                $respMap                            = null;
                $bodyStr                            = null;
                if (Utils::is4xx($_response->statusCode) || Utils::is5xx($_response->statusCode)) {
                    $bodyStr = Utils::readAsString($_response->body);
                    $respMap = OSSUtils::getErrMessage($bodyStr);

                    throw new TeaError([
                        'code'    => @$respMap['Code'],
                        'message' => @$respMap['Message'],
                        'data'    => [
                            'httpCode'  => $_response->statusCode,
                            'requestId' => @$respMap['RequestId'],
                            'hostId'    => @$respMap['HostId'],
                        ],
                    ]);
                }

                return GetObjectResponse::fromMap(Tea::merge([
                    'body' => $_response->body,
                ], $_response->headers));
            } catch (Exception $e) {
                if (!($e instanceof TeaError)) {
                    $e = new TeaError([], $e->getMessage(), $e->getCode(), $e);
                }
                if (Tea::isRetryable($e)) {
                    $_lastException = $e;

                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest, $_lastException);
    }

    /**
     * @param UploadPartRequest $request
     * @param RuntimeOptions    $runtime
     *
     * @throws TeaError
     * @throws Exception
     * @throws TeaUnableRetryError
     *
     * @return UploadPartResponse
     */
    public function uploadPart($request, $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime = [
            'timeouted'      => 'retry',
            'readTimeout'    => Utils::defaultNumber($runtime->readTimeout, $this->_readTimeout),
            'connectTimeout' => Utils::defaultNumber($runtime->connectTimeout, $this->_connectTimeout),
            'localAddr'      => Utils::defaultString($runtime->localAddr, $this->_localAddr),
            'httpProxy'      => Utils::defaultString($runtime->httpProxy, $this->_httpProxy),
            'httpsProxy'     => Utils::defaultString($runtime->httpsProxy, $this->_httpsProxy),
            'noProxy'        => Utils::defaultString($runtime->noProxy, $this->_noProxy),
            'socks5Proxy'    => Utils::defaultString($runtime->socks5Proxy, $this->_socks5Proxy),
            'socks5NetWork'  => Utils::defaultString($runtime->socks5NetWork, $this->_socks5NetWork),
            'maxIdleConns'   => Utils::defaultNumber($runtime->maxIdleConns, $this->_maxIdleConns),
            'retry'          => [
                'retryable'   => $runtime->autoretry,
                'maxAttempts' => Utils::defaultNumber($runtime->maxAttempts, 3),
            ],
            'backoff' => [
                'policy' => Utils::defaultString($runtime->backoffPolicy, 'no'),
                'period' => Utils::defaultNumber($runtime->backoffPeriod, 1),
            ],
            'ignoreSSL' => $runtime->ignoreSSL,
        ];
        $_lastRequest   = null;
        $_lastException = null;
        $_now           = time();
        $_retryTimes    = 0;
        while (Tea::allowRetry(@$_runtime['retry'], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime(@$_runtime['backoff'], $_retryTimes);
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
                $_request->method   = 'PUT';
                $_request->pathname = '/' . $request->objectName . '';
                $_request->headers  = [
                    'host'       => OSSUtils::getHost($request->bucketName, $this->_regionId, $this->_endpoint, $this->_hostModel),
                    'date'       => Utils::getDateUTCString(),
                    'user-agent' => $this->getUserAgent(),
                ];
                if (!Utils::empty_($token)) {
                    $_request->headers['x-oss-security-token'] = $token;
                }
                $_request->query                    = Utils::stringifyMapValue($request->filter->toMap());
                $_request->body                     = OSSUtils::inject($request->body, $ctx);
                $_request->headers['authorization'] = OSSUtils::getSignature($_request, $request->bucketName, $accessKeyId, $accessKeySecret, $this->_signatureVersion, $this->_addtionalHeaders);
                $_lastRequest                       = $_request;
                $_response                          = Tea::send($_request, $_runtime);
                $respMap                            = null;
                $bodyStr                            = null;
                if (Utils::is4xx($_response->statusCode) || Utils::is5xx($_response->statusCode)) {
                    $bodyStr = Utils::readAsString($_response->body);
                    $respMap = OSSUtils::getErrMessage($bodyStr);

                    throw new TeaError([
                        'code'    => @$respMap['Code'],
                        'message' => @$respMap['Message'],
                        'data'    => [
                            'httpCode'  => $_response->statusCode,
                            'requestId' => @$respMap['RequestId'],
                            'hostId'    => @$respMap['HostId'],
                        ],
                    ]);
                }
                if ($this->_isEnableCrc && !Utils::equalString(@$ctx['crc'], $_response->headers['x-oss-hash-crc64ecma'])) {
                    throw new TeaError([
                        'code' => 'CrcNotMatched',
                        'data' => [
                            'clientCrc' => @$ctx['crc'],
                            'serverCrc' => $_response->headers['x-oss-hash-crc64ecma'],
                        ],
                    ]);
                }
                if ($this->_isEnableMD5 && !Utils::equalString(@$ctx['md5'], $_response->headers['content-md5'])) {
                    throw new TeaError([
                        'code' => 'MD5NotMatched',
                        'data' => [
                            'clientMD5' => @$ctx['md5'],
                            'serverMD5' => $_response->headers['content-md5'],
                        ],
                    ]);
                }

                return UploadPartResponse::fromMap(Tea::merge($_response->headers));
            } catch (Exception $e) {
                if (!($e instanceof TeaError)) {
                    $e = new TeaError([], $e->getMessage(), $e->getCode(), $e);
                }
                if (Tea::isRetryable($e)) {
                    $_lastException = $e;

                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest, $_lastException);
    }

    /**
     * @param GetBucketCORSRequest $request
     * @param RuntimeOptions       $runtime
     *
     * @throws TeaError
     * @throws Exception
     * @throws TeaUnableRetryError
     *
     * @return GetBucketCORSResponse
     */
    public function getBucketCORS($request, $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime = [
            'timeouted'      => 'retry',
            'readTimeout'    => Utils::defaultNumber($runtime->readTimeout, $this->_readTimeout),
            'connectTimeout' => Utils::defaultNumber($runtime->connectTimeout, $this->_connectTimeout),
            'localAddr'      => Utils::defaultString($runtime->localAddr, $this->_localAddr),
            'httpProxy'      => Utils::defaultString($runtime->httpProxy, $this->_httpProxy),
            'httpsProxy'     => Utils::defaultString($runtime->httpsProxy, $this->_httpsProxy),
            'noProxy'        => Utils::defaultString($runtime->noProxy, $this->_noProxy),
            'socks5Proxy'    => Utils::defaultString($runtime->socks5Proxy, $this->_socks5Proxy),
            'socks5NetWork'  => Utils::defaultString($runtime->socks5NetWork, $this->_socks5NetWork),
            'maxIdleConns'   => Utils::defaultNumber($runtime->maxIdleConns, $this->_maxIdleConns),
            'retry'          => [
                'retryable'   => $runtime->autoretry,
                'maxAttempts' => Utils::defaultNumber($runtime->maxAttempts, 3),
            ],
            'backoff' => [
                'policy' => Utils::defaultString($runtime->backoffPolicy, 'no'),
                'period' => Utils::defaultNumber($runtime->backoffPeriod, 1),
            ],
            'ignoreSSL' => $runtime->ignoreSSL,
        ];
        $_lastRequest   = null;
        $_lastException = null;
        $_now           = time();
        $_retryTimes    = 0;
        while (Tea::allowRetry(@$_runtime['retry'], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime(@$_runtime['backoff'], $_retryTimes);
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
                $_request->method   = 'GET';
                $_request->pathname = '/?cors';
                $_request->headers  = [
                    'host'       => OSSUtils::getHost($request->bucketName, $this->_regionId, $this->_endpoint, $this->_hostModel),
                    'date'       => Utils::getDateUTCString(),
                    'user-agent' => $this->getUserAgent(),
                ];
                if (!Utils::empty_($token)) {
                    $_request->headers['x-oss-security-token'] = $token;
                }
                $_request->headers['authorization'] = OSSUtils::getSignature($_request, $request->bucketName, $accessKeyId, $accessKeySecret, $this->_signatureVersion, $this->_addtionalHeaders);
                $_lastRequest                       = $_request;
                $_response                          = Tea::send($_request, $_runtime);
                $respMap                            = null;
                $bodyStr                            = null;
                if (Utils::is4xx($_response->statusCode) || Utils::is5xx($_response->statusCode)) {
                    $bodyStr = Utils::readAsString($_response->body);
                    $respMap = OSSUtils::getErrMessage($bodyStr);

                    throw new TeaError([
                        'code'    => @$respMap['Code'],
                        'message' => @$respMap['Message'],
                        'data'    => [
                            'httpCode'  => $_response->statusCode,
                            'requestId' => @$respMap['RequestId'],
                            'hostId'    => @$respMap['HostId'],
                        ],
                    ]);
                }
                $bodyStr = Utils::readAsString($_response->body);
                $respMap = XML::parseXml($bodyStr, GetBucketCORSResponse::class);

                return GetBucketCORSResponse::fromMap(Tea::merge([
                    'CORSConfiguration' => @$respMap['CORSConfiguration'],
                ], $_response->headers));
            } catch (Exception $e) {
                if (!($e instanceof TeaError)) {
                    $e = new TeaError([], $e->getMessage(), $e->getCode(), $e);
                }
                if (Tea::isRetryable($e)) {
                    $_lastException = $e;

                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest, $_lastException);
    }

    /**
     * @param CopyObjectRequest $request
     * @param RuntimeOptions    $runtime
     *
     * @throws TeaError
     * @throws Exception
     * @throws TeaUnableRetryError
     *
     * @return CopyObjectResponse
     */
    public function copyObject($request, $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime = [
            'timeouted'      => 'retry',
            'readTimeout'    => Utils::defaultNumber($runtime->readTimeout, $this->_readTimeout),
            'connectTimeout' => Utils::defaultNumber($runtime->connectTimeout, $this->_connectTimeout),
            'localAddr'      => Utils::defaultString($runtime->localAddr, $this->_localAddr),
            'httpProxy'      => Utils::defaultString($runtime->httpProxy, $this->_httpProxy),
            'httpsProxy'     => Utils::defaultString($runtime->httpsProxy, $this->_httpsProxy),
            'noProxy'        => Utils::defaultString($runtime->noProxy, $this->_noProxy),
            'socks5Proxy'    => Utils::defaultString($runtime->socks5Proxy, $this->_socks5Proxy),
            'socks5NetWork'  => Utils::defaultString($runtime->socks5NetWork, $this->_socks5NetWork),
            'maxIdleConns'   => Utils::defaultNumber($runtime->maxIdleConns, $this->_maxIdleConns),
            'retry'          => [
                'retryable'   => $runtime->autoretry,
                'maxAttempts' => Utils::defaultNumber($runtime->maxAttempts, 3),
            ],
            'backoff' => [
                'policy' => Utils::defaultString($runtime->backoffPolicy, 'no'),
                'period' => Utils::defaultNumber($runtime->backoffPeriod, 1),
            ],
            'ignoreSSL' => $runtime->ignoreSSL,
        ];
        $_lastRequest   = null;
        $_lastException = null;
        $_now           = time();
        $_retryTimes    = 0;
        while (Tea::allowRetry(@$_runtime['retry'], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime(@$_runtime['backoff'], $_retryTimes);
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
                $_request->method   = 'PUT';
                $_request->pathname = '/' . $request->destObjectName . '';
                $_request->headers  = Tea::merge([
                    'host'       => OSSUtils::getHost($request->bucketName, $this->_regionId, $this->_endpoint, $this->_hostModel),
                    'date'       => Utils::getDateUTCString(),
                    'user-agent' => $this->getUserAgent(),
                ], Utils::stringifyMapValue($request->header->toMap()));
                if (!Utils::empty_($token)) {
                    $_request->headers['x-oss-security-token'] = $token;
                }
                $_request->headers['x-oss-copy-source'] = OSSUtils::encode($_request->headers['x-oss-copy-source'], 'UrlEncode');
                $_request->headers['authorization']     = OSSUtils::getSignature($_request, $request->bucketName, $accessKeyId, $accessKeySecret, $this->_signatureVersion, $this->_addtionalHeaders);
                $_lastRequest                           = $_request;
                $_response                              = Tea::send($_request, $_runtime);
                $respMap                                = null;
                $bodyStr                                = null;
                if (Utils::is4xx($_response->statusCode) || Utils::is5xx($_response->statusCode)) {
                    $bodyStr = Utils::readAsString($_response->body);
                    $respMap = OSSUtils::getErrMessage($bodyStr);

                    throw new TeaError([
                        'code'    => @$respMap['Code'],
                        'message' => @$respMap['Message'],
                        'data'    => [
                            'httpCode'  => $_response->statusCode,
                            'requestId' => @$respMap['RequestId'],
                            'hostId'    => @$respMap['HostId'],
                        ],
                    ]);
                }
                $bodyStr = Utils::readAsString($_response->body);
                $respMap = XML::parseXml($bodyStr, CopyObjectResponse::class);

                return CopyObjectResponse::fromMap(Tea::merge([
                    'CopyObjectResult' => @$respMap['CopyObjectResult'],
                ], $_response->headers));
            } catch (Exception $e) {
                if (!($e instanceof TeaError)) {
                    $e = new TeaError([], $e->getMessage(), $e->getCode(), $e);
                }
                if (Tea::isRetryable($e)) {
                    $_lastException = $e;

                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest, $_lastException);
    }

    /**
     * @param GetObjectTaggingRequest $request
     * @param RuntimeOptions          $runtime
     *
     * @throws TeaError
     * @throws Exception
     * @throws TeaUnableRetryError
     *
     * @return GetObjectTaggingResponse
     */
    public function getObjectTagging($request, $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime = [
            'timeouted'      => 'retry',
            'readTimeout'    => Utils::defaultNumber($runtime->readTimeout, $this->_readTimeout),
            'connectTimeout' => Utils::defaultNumber($runtime->connectTimeout, $this->_connectTimeout),
            'localAddr'      => Utils::defaultString($runtime->localAddr, $this->_localAddr),
            'httpProxy'      => Utils::defaultString($runtime->httpProxy, $this->_httpProxy),
            'httpsProxy'     => Utils::defaultString($runtime->httpsProxy, $this->_httpsProxy),
            'noProxy'        => Utils::defaultString($runtime->noProxy, $this->_noProxy),
            'socks5Proxy'    => Utils::defaultString($runtime->socks5Proxy, $this->_socks5Proxy),
            'socks5NetWork'  => Utils::defaultString($runtime->socks5NetWork, $this->_socks5NetWork),
            'maxIdleConns'   => Utils::defaultNumber($runtime->maxIdleConns, $this->_maxIdleConns),
            'retry'          => [
                'retryable'   => $runtime->autoretry,
                'maxAttempts' => Utils::defaultNumber($runtime->maxAttempts, 3),
            ],
            'backoff' => [
                'policy' => Utils::defaultString($runtime->backoffPolicy, 'no'),
                'period' => Utils::defaultNumber($runtime->backoffPeriod, 1),
            ],
            'ignoreSSL' => $runtime->ignoreSSL,
        ];
        $_lastRequest   = null;
        $_lastException = null;
        $_now           = time();
        $_retryTimes    = 0;
        while (Tea::allowRetry(@$_runtime['retry'], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime(@$_runtime['backoff'], $_retryTimes);
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
                $_request->method   = 'GET';
                $_request->pathname = '/' . $request->objectName . '?tagging';
                $_request->headers  = [
                    'host'       => OSSUtils::getHost($request->bucketName, $this->_regionId, $this->_endpoint, $this->_hostModel),
                    'date'       => Utils::getDateUTCString(),
                    'user-agent' => $this->getUserAgent(),
                ];
                if (!Utils::empty_($token)) {
                    $_request->headers['x-oss-security-token'] = $token;
                }
                $_request->headers['authorization'] = OSSUtils::getSignature($_request, $request->bucketName, $accessKeyId, $accessKeySecret, $this->_signatureVersion, $this->_addtionalHeaders);
                $_lastRequest                       = $_request;
                $_response                          = Tea::send($_request, $_runtime);
                $respMap                            = null;
                $bodyStr                            = null;
                if (Utils::is4xx($_response->statusCode) || Utils::is5xx($_response->statusCode)) {
                    $bodyStr = Utils::readAsString($_response->body);
                    $respMap = OSSUtils::getErrMessage($bodyStr);

                    throw new TeaError([
                        'code'    => @$respMap['Code'],
                        'message' => @$respMap['Message'],
                        'data'    => [
                            'httpCode'  => $_response->statusCode,
                            'requestId' => @$respMap['RequestId'],
                            'hostId'    => @$respMap['HostId'],
                        ],
                    ]);
                }
                $bodyStr = Utils::readAsString($_response->body);
                $respMap = XML::parseXml($bodyStr, GetObjectTaggingResponse::class);

                return GetObjectTaggingResponse::fromMap(Tea::merge([
                    'Tagging' => @$respMap['Tagging'],
                ], $_response->headers));
            } catch (Exception $e) {
                if (!($e instanceof TeaError)) {
                    $e = new TeaError([], $e->getMessage(), $e->getCode(), $e);
                }
                if (Tea::isRetryable($e)) {
                    $_lastException = $e;

                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest, $_lastException);
    }

    /**
     * @param DeleteBucketLifecycleRequest $request
     * @param RuntimeOptions               $runtime
     *
     * @throws TeaError
     * @throws Exception
     * @throws TeaUnableRetryError
     *
     * @return DeleteBucketLifecycleResponse
     */
    public function deleteBucketLifecycle($request, $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime = [
            'timeouted'      => 'retry',
            'readTimeout'    => Utils::defaultNumber($runtime->readTimeout, $this->_readTimeout),
            'connectTimeout' => Utils::defaultNumber($runtime->connectTimeout, $this->_connectTimeout),
            'localAddr'      => Utils::defaultString($runtime->localAddr, $this->_localAddr),
            'httpProxy'      => Utils::defaultString($runtime->httpProxy, $this->_httpProxy),
            'httpsProxy'     => Utils::defaultString($runtime->httpsProxy, $this->_httpsProxy),
            'noProxy'        => Utils::defaultString($runtime->noProxy, $this->_noProxy),
            'socks5Proxy'    => Utils::defaultString($runtime->socks5Proxy, $this->_socks5Proxy),
            'socks5NetWork'  => Utils::defaultString($runtime->socks5NetWork, $this->_socks5NetWork),
            'maxIdleConns'   => Utils::defaultNumber($runtime->maxIdleConns, $this->_maxIdleConns),
            'retry'          => [
                'retryable'   => $runtime->autoretry,
                'maxAttempts' => Utils::defaultNumber($runtime->maxAttempts, 3),
            ],
            'backoff' => [
                'policy' => Utils::defaultString($runtime->backoffPolicy, 'no'),
                'period' => Utils::defaultNumber($runtime->backoffPeriod, 1),
            ],
            'ignoreSSL' => $runtime->ignoreSSL,
        ];
        $_lastRequest   = null;
        $_lastException = null;
        $_now           = time();
        $_retryTimes    = 0;
        while (Tea::allowRetry(@$_runtime['retry'], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime(@$_runtime['backoff'], $_retryTimes);
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
                $_request->method   = 'DELETE';
                $_request->pathname = '/?lifecycle';
                $_request->headers  = [
                    'host'       => OSSUtils::getHost($request->bucketName, $this->_regionId, $this->_endpoint, $this->_hostModel),
                    'date'       => Utils::getDateUTCString(),
                    'user-agent' => $this->getUserAgent(),
                ];
                if (!Utils::empty_($token)) {
                    $_request->headers['x-oss-security-token'] = $token;
                }
                $_request->headers['authorization'] = OSSUtils::getSignature($_request, $request->bucketName, $accessKeyId, $accessKeySecret, $this->_signatureVersion, $this->_addtionalHeaders);
                $_lastRequest                       = $_request;
                $_response                          = Tea::send($_request, $_runtime);
                $respMap                            = null;
                $bodyStr                            = null;
                if (Utils::is4xx($_response->statusCode) || Utils::is5xx($_response->statusCode)) {
                    $bodyStr = Utils::readAsString($_response->body);
                    $respMap = OSSUtils::getErrMessage($bodyStr);

                    throw new TeaError([
                        'code'    => @$respMap['Code'],
                        'message' => @$respMap['Message'],
                        'data'    => [
                            'httpCode'  => $_response->statusCode,
                            'requestId' => @$respMap['RequestId'],
                            'hostId'    => @$respMap['HostId'],
                        ],
                    ]);
                }

                return DeleteBucketLifecycleResponse::fromMap(Tea::merge($_response->headers));
            } catch (Exception $e) {
                if (!($e instanceof TeaError)) {
                    $e = new TeaError([], $e->getMessage(), $e->getCode(), $e);
                }
                if (Tea::isRetryable($e)) {
                    $_lastException = $e;

                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest, $_lastException);
    }

    /**
     * @param DeleteBucketLoggingRequest $request
     * @param RuntimeOptions             $runtime
     *
     * @throws TeaError
     * @throws Exception
     * @throws TeaUnableRetryError
     *
     * @return DeleteBucketLoggingResponse
     */
    public function deleteBucketLogging($request, $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime = [
            'timeouted'      => 'retry',
            'readTimeout'    => Utils::defaultNumber($runtime->readTimeout, $this->_readTimeout),
            'connectTimeout' => Utils::defaultNumber($runtime->connectTimeout, $this->_connectTimeout),
            'localAddr'      => Utils::defaultString($runtime->localAddr, $this->_localAddr),
            'httpProxy'      => Utils::defaultString($runtime->httpProxy, $this->_httpProxy),
            'httpsProxy'     => Utils::defaultString($runtime->httpsProxy, $this->_httpsProxy),
            'noProxy'        => Utils::defaultString($runtime->noProxy, $this->_noProxy),
            'socks5Proxy'    => Utils::defaultString($runtime->socks5Proxy, $this->_socks5Proxy),
            'socks5NetWork'  => Utils::defaultString($runtime->socks5NetWork, $this->_socks5NetWork),
            'maxIdleConns'   => Utils::defaultNumber($runtime->maxIdleConns, $this->_maxIdleConns),
            'retry'          => [
                'retryable'   => $runtime->autoretry,
                'maxAttempts' => Utils::defaultNumber($runtime->maxAttempts, 3),
            ],
            'backoff' => [
                'policy' => Utils::defaultString($runtime->backoffPolicy, 'no'),
                'period' => Utils::defaultNumber($runtime->backoffPeriod, 1),
            ],
            'ignoreSSL' => $runtime->ignoreSSL,
        ];
        $_lastRequest   = null;
        $_lastException = null;
        $_now           = time();
        $_retryTimes    = 0;
        while (Tea::allowRetry(@$_runtime['retry'], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime(@$_runtime['backoff'], $_retryTimes);
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
                $_request->method   = 'DELETE';
                $_request->pathname = '/?logging';
                $_request->headers  = [
                    'host'       => OSSUtils::getHost($request->bucketName, $this->_regionId, $this->_endpoint, $this->_hostModel),
                    'date'       => Utils::getDateUTCString(),
                    'user-agent' => $this->getUserAgent(),
                ];
                if (!Utils::empty_($token)) {
                    $_request->headers['x-oss-security-token'] = $token;
                }
                $_request->headers['authorization'] = OSSUtils::getSignature($_request, $request->bucketName, $accessKeyId, $accessKeySecret, $this->_signatureVersion, $this->_addtionalHeaders);
                $_lastRequest                       = $_request;
                $_response                          = Tea::send($_request, $_runtime);
                $respMap                            = null;
                $bodyStr                            = null;
                if (Utils::is4xx($_response->statusCode) || Utils::is5xx($_response->statusCode)) {
                    $bodyStr = Utils::readAsString($_response->body);
                    $respMap = OSSUtils::getErrMessage($bodyStr);

                    throw new TeaError([
                        'code'    => @$respMap['Code'],
                        'message' => @$respMap['Message'],
                        'data'    => [
                            'httpCode'  => $_response->statusCode,
                            'requestId' => @$respMap['RequestId'],
                            'hostId'    => @$respMap['HostId'],
                        ],
                    ]);
                }

                return DeleteBucketLoggingResponse::fromMap(Tea::merge($_response->headers));
            } catch (Exception $e) {
                if (!($e instanceof TeaError)) {
                    $e = new TeaError([], $e->getMessage(), $e->getCode(), $e);
                }
                if (Tea::isRetryable($e)) {
                    $_lastException = $e;

                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest, $_lastException);
    }

    /**
     * @param DeleteBucketWebsiteRequest $request
     * @param RuntimeOptions             $runtime
     *
     * @throws TeaError
     * @throws Exception
     * @throws TeaUnableRetryError
     *
     * @return DeleteBucketWebsiteResponse
     */
    public function deleteBucketWebsite($request, $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime = [
            'timeouted'      => 'retry',
            'readTimeout'    => Utils::defaultNumber($runtime->readTimeout, $this->_readTimeout),
            'connectTimeout' => Utils::defaultNumber($runtime->connectTimeout, $this->_connectTimeout),
            'localAddr'      => Utils::defaultString($runtime->localAddr, $this->_localAddr),
            'httpProxy'      => Utils::defaultString($runtime->httpProxy, $this->_httpProxy),
            'httpsProxy'     => Utils::defaultString($runtime->httpsProxy, $this->_httpsProxy),
            'noProxy'        => Utils::defaultString($runtime->noProxy, $this->_noProxy),
            'socks5Proxy'    => Utils::defaultString($runtime->socks5Proxy, $this->_socks5Proxy),
            'socks5NetWork'  => Utils::defaultString($runtime->socks5NetWork, $this->_socks5NetWork),
            'maxIdleConns'   => Utils::defaultNumber($runtime->maxIdleConns, $this->_maxIdleConns),
            'retry'          => [
                'retryable'   => $runtime->autoretry,
                'maxAttempts' => Utils::defaultNumber($runtime->maxAttempts, 3),
            ],
            'backoff' => [
                'policy' => Utils::defaultString($runtime->backoffPolicy, 'no'),
                'period' => Utils::defaultNumber($runtime->backoffPeriod, 1),
            ],
            'ignoreSSL' => $runtime->ignoreSSL,
        ];
        $_lastRequest   = null;
        $_lastException = null;
        $_now           = time();
        $_retryTimes    = 0;
        while (Tea::allowRetry(@$_runtime['retry'], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime(@$_runtime['backoff'], $_retryTimes);
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
                $_request->method   = 'DELETE';
                $_request->pathname = '/?website';
                $_request->headers  = [
                    'host'       => OSSUtils::getHost($request->bucketName, $this->_regionId, $this->_endpoint, $this->_hostModel),
                    'date'       => Utils::getDateUTCString(),
                    'user-agent' => $this->getUserAgent(),
                ];
                if (!Utils::empty_($token)) {
                    $_request->headers['x-oss-security-token'] = $token;
                }
                $_request->headers['authorization'] = OSSUtils::getSignature($_request, $request->bucketName, $accessKeyId, $accessKeySecret, $this->_signatureVersion, $this->_addtionalHeaders);
                $_lastRequest                       = $_request;
                $_response                          = Tea::send($_request, $_runtime);
                $respMap                            = null;
                $bodyStr                            = null;
                if (Utils::is4xx($_response->statusCode) || Utils::is5xx($_response->statusCode)) {
                    $bodyStr = Utils::readAsString($_response->body);
                    $respMap = OSSUtils::getErrMessage($bodyStr);

                    throw new TeaError([
                        'code'    => @$respMap['Code'],
                        'message' => @$respMap['Message'],
                        'data'    => [
                            'httpCode'  => $_response->statusCode,
                            'requestId' => @$respMap['RequestId'],
                            'hostId'    => @$respMap['HostId'],
                        ],
                    ]);
                }

                return DeleteBucketWebsiteResponse::fromMap(Tea::merge($_response->headers));
            } catch (Exception $e) {
                if (!($e instanceof TeaError)) {
                    $e = new TeaError([], $e->getMessage(), $e->getCode(), $e);
                }
                if (Tea::isRetryable($e)) {
                    $_lastException = $e;

                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest, $_lastException);
    }

    /**
     * @param GetSymlinkRequest $request
     * @param RuntimeOptions    $runtime
     *
     * @throws TeaError
     * @throws Exception
     * @throws TeaUnableRetryError
     *
     * @return GetSymlinkResponse
     */
    public function getSymlink($request, $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime = [
            'timeouted'      => 'retry',
            'readTimeout'    => Utils::defaultNumber($runtime->readTimeout, $this->_readTimeout),
            'connectTimeout' => Utils::defaultNumber($runtime->connectTimeout, $this->_connectTimeout),
            'localAddr'      => Utils::defaultString($runtime->localAddr, $this->_localAddr),
            'httpProxy'      => Utils::defaultString($runtime->httpProxy, $this->_httpProxy),
            'httpsProxy'     => Utils::defaultString($runtime->httpsProxy, $this->_httpsProxy),
            'noProxy'        => Utils::defaultString($runtime->noProxy, $this->_noProxy),
            'socks5Proxy'    => Utils::defaultString($runtime->socks5Proxy, $this->_socks5Proxy),
            'socks5NetWork'  => Utils::defaultString($runtime->socks5NetWork, $this->_socks5NetWork),
            'maxIdleConns'   => Utils::defaultNumber($runtime->maxIdleConns, $this->_maxIdleConns),
            'retry'          => [
                'retryable'   => $runtime->autoretry,
                'maxAttempts' => Utils::defaultNumber($runtime->maxAttempts, 3),
            ],
            'backoff' => [
                'policy' => Utils::defaultString($runtime->backoffPolicy, 'no'),
                'period' => Utils::defaultNumber($runtime->backoffPeriod, 1),
            ],
            'ignoreSSL' => $runtime->ignoreSSL,
        ];
        $_lastRequest   = null;
        $_lastException = null;
        $_now           = time();
        $_retryTimes    = 0;
        while (Tea::allowRetry(@$_runtime['retry'], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime(@$_runtime['backoff'], $_retryTimes);
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
                $_request->method   = 'GET';
                $_request->pathname = '/' . $request->objectName . '?symlink';
                $_request->headers  = [
                    'host'       => OSSUtils::getHost($request->bucketName, $this->_regionId, $this->_endpoint, $this->_hostModel),
                    'date'       => Utils::getDateUTCString(),
                    'user-agent' => $this->getUserAgent(),
                ];
                if (!Utils::empty_($token)) {
                    $_request->headers['x-oss-security-token'] = $token;
                }
                $_request->headers['authorization'] = OSSUtils::getSignature($_request, $request->bucketName, $accessKeyId, $accessKeySecret, $this->_signatureVersion, $this->_addtionalHeaders);
                $_lastRequest                       = $_request;
                $_response                          = Tea::send($_request, $_runtime);
                $respMap                            = null;
                $bodyStr                            = null;
                if (Utils::is4xx($_response->statusCode) || Utils::is5xx($_response->statusCode)) {
                    $bodyStr = Utils::readAsString($_response->body);
                    $respMap = OSSUtils::getErrMessage($bodyStr);

                    throw new TeaError([
                        'code'    => @$respMap['Code'],
                        'message' => @$respMap['Message'],
                        'data'    => [
                            'httpCode'  => $_response->statusCode,
                            'requestId' => @$respMap['RequestId'],
                            'hostId'    => @$respMap['HostId'],
                        ],
                    ]);
                }

                return GetSymlinkResponse::fromMap(Tea::merge($_response->headers));
            } catch (Exception $e) {
                if (!($e instanceof TeaError)) {
                    $e = new TeaError([], $e->getMessage(), $e->getCode(), $e);
                }
                if (Tea::isRetryable($e)) {
                    $_lastException = $e;

                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest, $_lastException);
    }

    /**
     * @param GetBucketLifecycleRequest $request
     * @param RuntimeOptions            $runtime
     *
     * @throws TeaError
     * @throws Exception
     * @throws TeaUnableRetryError
     *
     * @return GetBucketLifecycleResponse
     */
    public function getBucketLifecycle($request, $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime = [
            'timeouted'      => 'retry',
            'readTimeout'    => Utils::defaultNumber($runtime->readTimeout, $this->_readTimeout),
            'connectTimeout' => Utils::defaultNumber($runtime->connectTimeout, $this->_connectTimeout),
            'localAddr'      => Utils::defaultString($runtime->localAddr, $this->_localAddr),
            'httpProxy'      => Utils::defaultString($runtime->httpProxy, $this->_httpProxy),
            'httpsProxy'     => Utils::defaultString($runtime->httpsProxy, $this->_httpsProxy),
            'noProxy'        => Utils::defaultString($runtime->noProxy, $this->_noProxy),
            'socks5Proxy'    => Utils::defaultString($runtime->socks5Proxy, $this->_socks5Proxy),
            'socks5NetWork'  => Utils::defaultString($runtime->socks5NetWork, $this->_socks5NetWork),
            'maxIdleConns'   => Utils::defaultNumber($runtime->maxIdleConns, $this->_maxIdleConns),
            'retry'          => [
                'retryable'   => $runtime->autoretry,
                'maxAttempts' => Utils::defaultNumber($runtime->maxAttempts, 3),
            ],
            'backoff' => [
                'policy' => Utils::defaultString($runtime->backoffPolicy, 'no'),
                'period' => Utils::defaultNumber($runtime->backoffPeriod, 1),
            ],
            'ignoreSSL' => $runtime->ignoreSSL,
        ];
        $_lastRequest   = null;
        $_lastException = null;
        $_now           = time();
        $_retryTimes    = 0;
        while (Tea::allowRetry(@$_runtime['retry'], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime(@$_runtime['backoff'], $_retryTimes);
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
                $_request->method   = 'GET';
                $_request->pathname = '/?lifecycle';
                $_request->headers  = [
                    'host'       => OSSUtils::getHost($request->bucketName, $this->_regionId, $this->_endpoint, $this->_hostModel),
                    'date'       => Utils::getDateUTCString(),
                    'user-agent' => $this->getUserAgent(),
                ];
                if (!Utils::empty_($token)) {
                    $_request->headers['x-oss-security-token'] = $token;
                }
                $_request->headers['authorization'] = OSSUtils::getSignature($_request, $request->bucketName, $accessKeyId, $accessKeySecret, $this->_signatureVersion, $this->_addtionalHeaders);
                $_lastRequest                       = $_request;
                $_response                          = Tea::send($_request, $_runtime);
                $respMap                            = null;
                $bodyStr                            = null;
                if (Utils::is4xx($_response->statusCode) || Utils::is5xx($_response->statusCode)) {
                    $bodyStr = Utils::readAsString($_response->body);
                    $respMap = OSSUtils::getErrMessage($bodyStr);

                    throw new TeaError([
                        'code'    => @$respMap['Code'],
                        'message' => @$respMap['Message'],
                        'data'    => [
                            'httpCode'  => $_response->statusCode,
                            'requestId' => @$respMap['RequestId'],
                            'hostId'    => @$respMap['HostId'],
                        ],
                    ]);
                }
                $bodyStr = Utils::readAsString($_response->body);
                $respMap = XML::parseXml($bodyStr, GetBucketLifecycleResponse::class);

                return GetBucketLifecycleResponse::fromMap(Tea::merge([
                    'LifecycleConfiguration' => @$respMap['LifecycleConfiguration'],
                ], $_response->headers));
            } catch (Exception $e) {
                if (!($e instanceof TeaError)) {
                    $e = new TeaError([], $e->getMessage(), $e->getCode(), $e);
                }
                if (Tea::isRetryable($e)) {
                    $_lastException = $e;

                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest, $_lastException);
    }

    /**
     * @param PutSymlinkRequest $request
     * @param RuntimeOptions    $runtime
     *
     * @throws TeaError
     * @throws Exception
     * @throws TeaUnableRetryError
     *
     * @return PutSymlinkResponse
     */
    public function putSymlink($request, $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime = [
            'timeouted'      => 'retry',
            'readTimeout'    => Utils::defaultNumber($runtime->readTimeout, $this->_readTimeout),
            'connectTimeout' => Utils::defaultNumber($runtime->connectTimeout, $this->_connectTimeout),
            'localAddr'      => Utils::defaultString($runtime->localAddr, $this->_localAddr),
            'httpProxy'      => Utils::defaultString($runtime->httpProxy, $this->_httpProxy),
            'httpsProxy'     => Utils::defaultString($runtime->httpsProxy, $this->_httpsProxy),
            'noProxy'        => Utils::defaultString($runtime->noProxy, $this->_noProxy),
            'socks5Proxy'    => Utils::defaultString($runtime->socks5Proxy, $this->_socks5Proxy),
            'socks5NetWork'  => Utils::defaultString($runtime->socks5NetWork, $this->_socks5NetWork),
            'maxIdleConns'   => Utils::defaultNumber($runtime->maxIdleConns, $this->_maxIdleConns),
            'retry'          => [
                'retryable'   => $runtime->autoretry,
                'maxAttempts' => Utils::defaultNumber($runtime->maxAttempts, 3),
            ],
            'backoff' => [
                'policy' => Utils::defaultString($runtime->backoffPolicy, 'no'),
                'period' => Utils::defaultNumber($runtime->backoffPeriod, 1),
            ],
            'ignoreSSL' => $runtime->ignoreSSL,
        ];
        $_lastRequest   = null;
        $_lastException = null;
        $_now           = time();
        $_retryTimes    = 0;
        while (Tea::allowRetry(@$_runtime['retry'], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime(@$_runtime['backoff'], $_retryTimes);
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
                $_request->method   = 'PUT';
                $_request->pathname = '/' . $request->objectName . '?symlink';
                $_request->headers  = Tea::merge([
                    'host'       => OSSUtils::getHost($request->bucketName, $this->_regionId, $this->_endpoint, $this->_hostModel),
                    'date'       => Utils::getDateUTCString(),
                    'user-agent' => $this->getUserAgent(),
                ], Utils::stringifyMapValue($request->header->toMap()));
                if (!Utils::empty_($token)) {
                    $_request->headers['x-oss-security-token'] = $token;
                }
                $_request->headers['authorization'] = OSSUtils::getSignature($_request, $request->bucketName, $accessKeyId, $accessKeySecret, $this->_signatureVersion, $this->_addtionalHeaders);
                $_lastRequest                       = $_request;
                $_response                          = Tea::send($_request, $_runtime);
                $respMap                            = null;
                $bodyStr                            = null;
                if (Utils::is4xx($_response->statusCode) || Utils::is5xx($_response->statusCode)) {
                    $bodyStr = Utils::readAsString($_response->body);
                    $respMap = OSSUtils::getErrMessage($bodyStr);

                    throw new TeaError([
                        'code'    => @$respMap['Code'],
                        'message' => @$respMap['Message'],
                        'data'    => [
                            'httpCode'  => $_response->statusCode,
                            'requestId' => @$respMap['RequestId'],
                            'hostId'    => @$respMap['HostId'],
                        ],
                    ]);
                }

                return PutSymlinkResponse::fromMap(Tea::merge($_response->headers));
            } catch (Exception $e) {
                if (!($e instanceof TeaError)) {
                    $e = new TeaError([], $e->getMessage(), $e->getCode(), $e);
                }
                if (Tea::isRetryable($e)) {
                    $_lastException = $e;

                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest, $_lastException);
    }

    /**
     * @param GetBucketRefererRequest $request
     * @param RuntimeOptions          $runtime
     *
     * @throws TeaError
     * @throws Exception
     * @throws TeaUnableRetryError
     *
     * @return GetBucketRefererResponse
     */
    public function getBucketReferer($request, $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime = [
            'timeouted'      => 'retry',
            'readTimeout'    => Utils::defaultNumber($runtime->readTimeout, $this->_readTimeout),
            'connectTimeout' => Utils::defaultNumber($runtime->connectTimeout, $this->_connectTimeout),
            'localAddr'      => Utils::defaultString($runtime->localAddr, $this->_localAddr),
            'httpProxy'      => Utils::defaultString($runtime->httpProxy, $this->_httpProxy),
            'httpsProxy'     => Utils::defaultString($runtime->httpsProxy, $this->_httpsProxy),
            'noProxy'        => Utils::defaultString($runtime->noProxy, $this->_noProxy),
            'socks5Proxy'    => Utils::defaultString($runtime->socks5Proxy, $this->_socks5Proxy),
            'socks5NetWork'  => Utils::defaultString($runtime->socks5NetWork, $this->_socks5NetWork),
            'maxIdleConns'   => Utils::defaultNumber($runtime->maxIdleConns, $this->_maxIdleConns),
            'retry'          => [
                'retryable'   => $runtime->autoretry,
                'maxAttempts' => Utils::defaultNumber($runtime->maxAttempts, 3),
            ],
            'backoff' => [
                'policy' => Utils::defaultString($runtime->backoffPolicy, 'no'),
                'period' => Utils::defaultNumber($runtime->backoffPeriod, 1),
            ],
            'ignoreSSL' => $runtime->ignoreSSL,
        ];
        $_lastRequest   = null;
        $_lastException = null;
        $_now           = time();
        $_retryTimes    = 0;
        while (Tea::allowRetry(@$_runtime['retry'], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime(@$_runtime['backoff'], $_retryTimes);
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
                $_request->method   = 'GET';
                $_request->pathname = '/?referer';
                $_request->headers  = [
                    'host'       => OSSUtils::getHost($request->bucketName, $this->_regionId, $this->_endpoint, $this->_hostModel),
                    'date'       => Utils::getDateUTCString(),
                    'user-agent' => $this->getUserAgent(),
                ];
                if (!Utils::empty_($token)) {
                    $_request->headers['x-oss-security-token'] = $token;
                }
                $_request->headers['authorization'] = OSSUtils::getSignature($_request, $request->bucketName, $accessKeyId, $accessKeySecret, $this->_signatureVersion, $this->_addtionalHeaders);
                $_lastRequest                       = $_request;
                $_response                          = Tea::send($_request, $_runtime);
                $respMap                            = null;
                $bodyStr                            = null;
                if (Utils::is4xx($_response->statusCode) || Utils::is5xx($_response->statusCode)) {
                    $bodyStr = Utils::readAsString($_response->body);
                    $respMap = OSSUtils::getErrMessage($bodyStr);

                    throw new TeaError([
                        'code'    => @$respMap['Code'],
                        'message' => @$respMap['Message'],
                        'data'    => [
                            'httpCode'  => $_response->statusCode,
                            'requestId' => @$respMap['RequestId'],
                            'hostId'    => @$respMap['HostId'],
                        ],
                    ]);
                }
                $bodyStr = Utils::readAsString($_response->body);
                $respMap = XML::parseXml($bodyStr, GetBucketRefererResponse::class);

                return GetBucketRefererResponse::fromMap(Tea::merge([
                    'RefererConfiguration' => @$respMap['RefererConfiguration'],
                ], $_response->headers));
            } catch (Exception $e) {
                if (!($e instanceof TeaError)) {
                    $e = new TeaError([], $e->getMessage(), $e->getCode(), $e);
                }
                if (Tea::isRetryable($e)) {
                    $_lastException = $e;

                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest, $_lastException);
    }

    /**
     * @param CallbackRequest $request
     * @param RuntimeOptions  $runtime
     *
     * @throws TeaError
     * @throws Exception
     * @throws TeaUnableRetryError
     *
     * @return CallbackResponse
     */
    public function callback($request, $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime = [
            'timeouted'      => 'retry',
            'readTimeout'    => Utils::defaultNumber($runtime->readTimeout, $this->_readTimeout),
            'connectTimeout' => Utils::defaultNumber($runtime->connectTimeout, $this->_connectTimeout),
            'localAddr'      => Utils::defaultString($runtime->localAddr, $this->_localAddr),
            'httpProxy'      => Utils::defaultString($runtime->httpProxy, $this->_httpProxy),
            'httpsProxy'     => Utils::defaultString($runtime->httpsProxy, $this->_httpsProxy),
            'noProxy'        => Utils::defaultString($runtime->noProxy, $this->_noProxy),
            'socks5Proxy'    => Utils::defaultString($runtime->socks5Proxy, $this->_socks5Proxy),
            'socks5NetWork'  => Utils::defaultString($runtime->socks5NetWork, $this->_socks5NetWork),
            'maxIdleConns'   => Utils::defaultNumber($runtime->maxIdleConns, $this->_maxIdleConns),
            'retry'          => [
                'retryable'   => $runtime->autoretry,
                'maxAttempts' => Utils::defaultNumber($runtime->maxAttempts, 3),
            ],
            'backoff' => [
                'policy' => Utils::defaultString($runtime->backoffPolicy, 'no'),
                'period' => Utils::defaultNumber($runtime->backoffPeriod, 1),
            ],
            'ignoreSSL' => $runtime->ignoreSSL,
        ];
        $_lastRequest   = null;
        $_lastException = null;
        $_now           = time();
        $_retryTimes    = 0;
        while (Tea::allowRetry(@$_runtime['retry'], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime(@$_runtime['backoff'], $_retryTimes);
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
                $_request->method   = 'GET';
                $_request->pathname = '/';
                $_request->headers  = [
                    'host'       => OSSUtils::getHost($request->bucketName, $this->_regionId, $this->_endpoint, $this->_hostModel),
                    'date'       => Utils::getDateUTCString(),
                    'user-agent' => $this->getUserAgent(),
                ];
                if (!Utils::empty_($token)) {
                    $_request->headers['x-oss-security-token'] = $token;
                }
                $_request->headers['authorization'] = OSSUtils::getSignature($_request, $request->bucketName, $accessKeyId, $accessKeySecret, $this->_signatureVersion, $this->_addtionalHeaders);
                $_lastRequest                       = $_request;
                $_response                          = Tea::send($_request, $_runtime);
                $respMap                            = null;
                $bodyStr                            = null;
                if (Utils::is4xx($_response->statusCode) || Utils::is5xx($_response->statusCode)) {
                    $bodyStr = Utils::readAsString($_response->body);
                    $respMap = OSSUtils::getErrMessage($bodyStr);

                    throw new TeaError([
                        'code'    => @$respMap['Code'],
                        'message' => @$respMap['Message'],
                        'data'    => [
                            'httpCode'  => $_response->statusCode,
                            'requestId' => @$respMap['RequestId'],
                            'hostId'    => @$respMap['HostId'],
                        ],
                    ]);
                }

                return CallbackResponse::fromMap(Tea::merge($_response->headers));
            } catch (Exception $e) {
                if (!($e instanceof TeaError)) {
                    $e = new TeaError([], $e->getMessage(), $e->getCode(), $e);
                }
                if (Tea::isRetryable($e)) {
                    $_lastException = $e;

                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest, $_lastException);
    }

    /**
     * @param GetBucketLoggingRequest $request
     * @param RuntimeOptions          $runtime
     *
     * @throws TeaError
     * @throws Exception
     * @throws TeaUnableRetryError
     *
     * @return GetBucketLoggingResponse
     */
    public function getBucketLogging($request, $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime = [
            'timeouted'      => 'retry',
            'readTimeout'    => Utils::defaultNumber($runtime->readTimeout, $this->_readTimeout),
            'connectTimeout' => Utils::defaultNumber($runtime->connectTimeout, $this->_connectTimeout),
            'localAddr'      => Utils::defaultString($runtime->localAddr, $this->_localAddr),
            'httpProxy'      => Utils::defaultString($runtime->httpProxy, $this->_httpProxy),
            'httpsProxy'     => Utils::defaultString($runtime->httpsProxy, $this->_httpsProxy),
            'noProxy'        => Utils::defaultString($runtime->noProxy, $this->_noProxy),
            'socks5Proxy'    => Utils::defaultString($runtime->socks5Proxy, $this->_socks5Proxy),
            'socks5NetWork'  => Utils::defaultString($runtime->socks5NetWork, $this->_socks5NetWork),
            'maxIdleConns'   => Utils::defaultNumber($runtime->maxIdleConns, $this->_maxIdleConns),
            'retry'          => [
                'retryable'   => $runtime->autoretry,
                'maxAttempts' => Utils::defaultNumber($runtime->maxAttempts, 3),
            ],
            'backoff' => [
                'policy' => Utils::defaultString($runtime->backoffPolicy, 'no'),
                'period' => Utils::defaultNumber($runtime->backoffPeriod, 1),
            ],
            'ignoreSSL' => $runtime->ignoreSSL,
        ];
        $_lastRequest   = null;
        $_lastException = null;
        $_now           = time();
        $_retryTimes    = 0;
        while (Tea::allowRetry(@$_runtime['retry'], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime(@$_runtime['backoff'], $_retryTimes);
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
                $_request->method   = 'GET';
                $_request->pathname = '/?logging';
                $_request->headers  = [
                    'host'       => OSSUtils::getHost($request->bucketName, $this->_regionId, $this->_endpoint, $this->_hostModel),
                    'date'       => Utils::getDateUTCString(),
                    'user-agent' => $this->getUserAgent(),
                ];
                if (!Utils::empty_($token)) {
                    $_request->headers['x-oss-security-token'] = $token;
                }
                $_request->headers['authorization'] = OSSUtils::getSignature($_request, $request->bucketName, $accessKeyId, $accessKeySecret, $this->_signatureVersion, $this->_addtionalHeaders);
                $_lastRequest                       = $_request;
                $_response                          = Tea::send($_request, $_runtime);
                $respMap                            = null;
                $bodyStr                            = null;
                if (Utils::is4xx($_response->statusCode) || Utils::is5xx($_response->statusCode)) {
                    $bodyStr = Utils::readAsString($_response->body);
                    $respMap = OSSUtils::getErrMessage($bodyStr);

                    throw new TeaError([
                        'code'    => @$respMap['Code'],
                        'message' => @$respMap['Message'],
                        'data'    => [
                            'httpCode'  => $_response->statusCode,
                            'requestId' => @$respMap['RequestId'],
                            'hostId'    => @$respMap['HostId'],
                        ],
                    ]);
                }
                $bodyStr = Utils::readAsString($_response->body);
                $respMap = XML::parseXml($bodyStr, GetBucketLoggingResponse::class);

                return GetBucketLoggingResponse::fromMap(Tea::merge([
                    'BucketLoggingStatus' => @$respMap['BucketLoggingStatus'],
                ], $_response->headers));
            } catch (Exception $e) {
                if (!($e instanceof TeaError)) {
                    $e = new TeaError([], $e->getMessage(), $e->getCode(), $e);
                }
                if (Tea::isRetryable($e)) {
                    $_lastException = $e;

                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest, $_lastException);
    }

    /**
     * @param PutObjectAclRequest $request
     * @param RuntimeOptions      $runtime
     *
     * @throws TeaError
     * @throws Exception
     * @throws TeaUnableRetryError
     *
     * @return PutObjectAclResponse
     */
    public function putObjectAcl($request, $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime = [
            'timeouted'      => 'retry',
            'readTimeout'    => Utils::defaultNumber($runtime->readTimeout, $this->_readTimeout),
            'connectTimeout' => Utils::defaultNumber($runtime->connectTimeout, $this->_connectTimeout),
            'localAddr'      => Utils::defaultString($runtime->localAddr, $this->_localAddr),
            'httpProxy'      => Utils::defaultString($runtime->httpProxy, $this->_httpProxy),
            'httpsProxy'     => Utils::defaultString($runtime->httpsProxy, $this->_httpsProxy),
            'noProxy'        => Utils::defaultString($runtime->noProxy, $this->_noProxy),
            'socks5Proxy'    => Utils::defaultString($runtime->socks5Proxy, $this->_socks5Proxy),
            'socks5NetWork'  => Utils::defaultString($runtime->socks5NetWork, $this->_socks5NetWork),
            'maxIdleConns'   => Utils::defaultNumber($runtime->maxIdleConns, $this->_maxIdleConns),
            'retry'          => [
                'retryable'   => $runtime->autoretry,
                'maxAttempts' => Utils::defaultNumber($runtime->maxAttempts, 3),
            ],
            'backoff' => [
                'policy' => Utils::defaultString($runtime->backoffPolicy, 'no'),
                'period' => Utils::defaultNumber($runtime->backoffPeriod, 1),
            ],
            'ignoreSSL' => $runtime->ignoreSSL,
        ];
        $_lastRequest   = null;
        $_lastException = null;
        $_now           = time();
        $_retryTimes    = 0;
        while (Tea::allowRetry(@$_runtime['retry'], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime(@$_runtime['backoff'], $_retryTimes);
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
                $_request->method   = 'PUT';
                $_request->pathname = '/' . $request->objectName . '?acl';
                $_request->headers  = Tea::merge([
                    'host'       => OSSUtils::getHost($request->bucketName, $this->_regionId, $this->_endpoint, $this->_hostModel),
                    'date'       => Utils::getDateUTCString(),
                    'user-agent' => $this->getUserAgent(),
                ], Utils::stringifyMapValue($request->header->toMap()));
                if (!Utils::empty_($token)) {
                    $_request->headers['x-oss-security-token'] = $token;
                }
                $_request->headers['authorization'] = OSSUtils::getSignature($_request, $request->bucketName, $accessKeyId, $accessKeySecret, $this->_signatureVersion, $this->_addtionalHeaders);
                $_lastRequest                       = $_request;
                $_response                          = Tea::send($_request, $_runtime);
                $respMap                            = null;
                $bodyStr                            = null;
                if (Utils::is4xx($_response->statusCode) || Utils::is5xx($_response->statusCode)) {
                    $bodyStr = Utils::readAsString($_response->body);
                    $respMap = OSSUtils::getErrMessage($bodyStr);

                    throw new TeaError([
                        'code'    => @$respMap['Code'],
                        'message' => @$respMap['Message'],
                        'data'    => [
                            'httpCode'  => $_response->statusCode,
                            'requestId' => @$respMap['RequestId'],
                            'hostId'    => @$respMap['HostId'],
                        ],
                    ]);
                }

                return PutObjectAclResponse::fromMap(Tea::merge($_response->headers));
            } catch (Exception $e) {
                if (!($e instanceof TeaError)) {
                    $e = new TeaError([], $e->getMessage(), $e->getCode(), $e);
                }
                if (Tea::isRetryable($e)) {
                    $_lastException = $e;

                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest, $_lastException);
    }

    /**
     * @param GetBucketInfoRequest $request
     * @param RuntimeOptions       $runtime
     *
     * @throws TeaError
     * @throws Exception
     * @throws TeaUnableRetryError
     *
     * @return GetBucketInfoResponse
     */
    public function getBucketInfo($request, $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime = [
            'timeouted'      => 'retry',
            'readTimeout'    => Utils::defaultNumber($runtime->readTimeout, $this->_readTimeout),
            'connectTimeout' => Utils::defaultNumber($runtime->connectTimeout, $this->_connectTimeout),
            'localAddr'      => Utils::defaultString($runtime->localAddr, $this->_localAddr),
            'httpProxy'      => Utils::defaultString($runtime->httpProxy, $this->_httpProxy),
            'httpsProxy'     => Utils::defaultString($runtime->httpsProxy, $this->_httpsProxy),
            'noProxy'        => Utils::defaultString($runtime->noProxy, $this->_noProxy),
            'socks5Proxy'    => Utils::defaultString($runtime->socks5Proxy, $this->_socks5Proxy),
            'socks5NetWork'  => Utils::defaultString($runtime->socks5NetWork, $this->_socks5NetWork),
            'maxIdleConns'   => Utils::defaultNumber($runtime->maxIdleConns, $this->_maxIdleConns),
            'retry'          => [
                'retryable'   => $runtime->autoretry,
                'maxAttempts' => Utils::defaultNumber($runtime->maxAttempts, 3),
            ],
            'backoff' => [
                'policy' => Utils::defaultString($runtime->backoffPolicy, 'no'),
                'period' => Utils::defaultNumber($runtime->backoffPeriod, 1),
            ],
            'ignoreSSL' => $runtime->ignoreSSL,
        ];
        $_lastRequest   = null;
        $_lastException = null;
        $_now           = time();
        $_retryTimes    = 0;
        while (Tea::allowRetry(@$_runtime['retry'], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime(@$_runtime['backoff'], $_retryTimes);
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
                $_request->method   = 'GET';
                $_request->pathname = '/?bucketInfo';
                $_request->headers  = [
                    'host'       => OSSUtils::getHost($request->bucketName, $this->_regionId, $this->_endpoint, $this->_hostModel),
                    'date'       => Utils::getDateUTCString(),
                    'user-agent' => $this->getUserAgent(),
                ];
                if (!Utils::empty_($token)) {
                    $_request->headers['x-oss-security-token'] = $token;
                }
                $_request->headers['authorization'] = OSSUtils::getSignature($_request, $request->bucketName, $accessKeyId, $accessKeySecret, $this->_signatureVersion, $this->_addtionalHeaders);
                $_lastRequest                       = $_request;
                $_response                          = Tea::send($_request, $_runtime);
                $respMap                            = null;
                $bodyStr                            = null;
                if (Utils::is4xx($_response->statusCode) || Utils::is5xx($_response->statusCode)) {
                    $bodyStr = Utils::readAsString($_response->body);
                    $respMap = OSSUtils::getErrMessage($bodyStr);

                    throw new TeaError([
                        'code'    => @$respMap['Code'],
                        'message' => @$respMap['Message'],
                        'data'    => [
                            'httpCode'  => $_response->statusCode,
                            'requestId' => @$respMap['RequestId'],
                            'hostId'    => @$respMap['HostId'],
                        ],
                    ]);
                }
                $bodyStr = Utils::readAsString($_response->body);
                $respMap = XML::parseXml($bodyStr, GetBucketInfoResponse::class);

                return GetBucketInfoResponse::fromMap(Tea::merge([
                    'BucketInfo' => @$respMap['BucketInfo'],
                ], $_response->headers));
            } catch (Exception $e) {
                if (!($e instanceof TeaError)) {
                    $e = new TeaError([], $e->getMessage(), $e->getCode(), $e);
                }
                if (Tea::isRetryable($e)) {
                    $_lastException = $e;

                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest, $_lastException);
    }

    /**
     * @param PutLiveChannelStatusRequest $request
     * @param RuntimeOptions              $runtime
     *
     * @throws TeaError
     * @throws Exception
     * @throws TeaUnableRetryError
     *
     * @return PutLiveChannelStatusResponse
     */
    public function putLiveChannelStatus($request, $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime = [
            'timeouted'      => 'retry',
            'readTimeout'    => Utils::defaultNumber($runtime->readTimeout, $this->_readTimeout),
            'connectTimeout' => Utils::defaultNumber($runtime->connectTimeout, $this->_connectTimeout),
            'localAddr'      => Utils::defaultString($runtime->localAddr, $this->_localAddr),
            'httpProxy'      => Utils::defaultString($runtime->httpProxy, $this->_httpProxy),
            'httpsProxy'     => Utils::defaultString($runtime->httpsProxy, $this->_httpsProxy),
            'noProxy'        => Utils::defaultString($runtime->noProxy, $this->_noProxy),
            'socks5Proxy'    => Utils::defaultString($runtime->socks5Proxy, $this->_socks5Proxy),
            'socks5NetWork'  => Utils::defaultString($runtime->socks5NetWork, $this->_socks5NetWork),
            'maxIdleConns'   => Utils::defaultNumber($runtime->maxIdleConns, $this->_maxIdleConns),
            'retry'          => [
                'retryable'   => $runtime->autoretry,
                'maxAttempts' => Utils::defaultNumber($runtime->maxAttempts, 3),
            ],
            'backoff' => [
                'policy' => Utils::defaultString($runtime->backoffPolicy, 'no'),
                'period' => Utils::defaultNumber($runtime->backoffPeriod, 1),
            ],
            'ignoreSSL' => $runtime->ignoreSSL,
        ];
        $_lastRequest   = null;
        $_lastException = null;
        $_now           = time();
        $_retryTimes    = 0;
        while (Tea::allowRetry(@$_runtime['retry'], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime(@$_runtime['backoff'], $_retryTimes);
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
                $_request->method   = 'PUT';
                $_request->pathname = '/' . $request->channelName . '?live';
                $_request->headers  = [
                    'host'       => OSSUtils::getHost($request->bucketName, $this->_regionId, $this->_endpoint, $this->_hostModel),
                    'date'       => Utils::getDateUTCString(),
                    'user-agent' => $this->getUserAgent(),
                ];
                if (!Utils::empty_($token)) {
                    $_request->headers['x-oss-security-token'] = $token;
                }
                $_request->query                    = Utils::stringifyMapValue($request->filter->toMap());
                $_request->headers['authorization'] = OSSUtils::getSignature($_request, $request->bucketName, $accessKeyId, $accessKeySecret, $this->_signatureVersion, $this->_addtionalHeaders);
                $_lastRequest                       = $_request;
                $_response                          = Tea::send($_request, $_runtime);
                $respMap                            = null;
                $bodyStr                            = null;
                if (Utils::is4xx($_response->statusCode) || Utils::is5xx($_response->statusCode)) {
                    $bodyStr = Utils::readAsString($_response->body);
                    $respMap = OSSUtils::getErrMessage($bodyStr);

                    throw new TeaError([
                        'code'    => @$respMap['Code'],
                        'message' => @$respMap['Message'],
                        'data'    => [
                            'httpCode'  => $_response->statusCode,
                            'requestId' => @$respMap['RequestId'],
                            'hostId'    => @$respMap['HostId'],
                        ],
                    ]);
                }

                return PutLiveChannelStatusResponse::fromMap(Tea::merge($_response->headers));
            } catch (Exception $e) {
                if (!($e instanceof TeaError)) {
                    $e = new TeaError([], $e->getMessage(), $e->getCode(), $e);
                }
                if (Tea::isRetryable($e)) {
                    $_lastException = $e;

                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest, $_lastException);
    }

    /**
     * @param InitiateMultipartUploadRequest $request
     * @param RuntimeOptions                 $runtime
     *
     * @throws TeaError
     * @throws Exception
     * @throws TeaUnableRetryError
     *
     * @return InitiateMultipartUploadResponse
     */
    public function initiateMultipartUpload($request, $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime = [
            'timeouted'      => 'retry',
            'readTimeout'    => Utils::defaultNumber($runtime->readTimeout, $this->_readTimeout),
            'connectTimeout' => Utils::defaultNumber($runtime->connectTimeout, $this->_connectTimeout),
            'localAddr'      => Utils::defaultString($runtime->localAddr, $this->_localAddr),
            'httpProxy'      => Utils::defaultString($runtime->httpProxy, $this->_httpProxy),
            'httpsProxy'     => Utils::defaultString($runtime->httpsProxy, $this->_httpsProxy),
            'noProxy'        => Utils::defaultString($runtime->noProxy, $this->_noProxy),
            'socks5Proxy'    => Utils::defaultString($runtime->socks5Proxy, $this->_socks5Proxy),
            'socks5NetWork'  => Utils::defaultString($runtime->socks5NetWork, $this->_socks5NetWork),
            'maxIdleConns'   => Utils::defaultNumber($runtime->maxIdleConns, $this->_maxIdleConns),
            'retry'          => [
                'retryable'   => $runtime->autoretry,
                'maxAttempts' => Utils::defaultNumber($runtime->maxAttempts, 3),
            ],
            'backoff' => [
                'policy' => Utils::defaultString($runtime->backoffPolicy, 'no'),
                'period' => Utils::defaultNumber($runtime->backoffPeriod, 1),
            ],
            'ignoreSSL' => $runtime->ignoreSSL,
        ];
        $_lastRequest   = null;
        $_lastException = null;
        $_now           = time();
        $_retryTimes    = 0;
        while (Tea::allowRetry(@$_runtime['retry'], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime(@$_runtime['backoff'], $_retryTimes);
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
                $_request->method   = 'POST';
                $_request->pathname = '/' . $request->objectName . '?uploads';
                $_request->headers  = Tea::merge([
                    'host'       => OSSUtils::getHost($request->bucketName, $this->_regionId, $this->_endpoint, $this->_hostModel),
                    'date'       => Utils::getDateUTCString(),
                    'user-agent' => $this->getUserAgent(),
                ], Utils::stringifyMapValue($request->header->toMap()));
                if (!Utils::empty_($token)) {
                    $_request->headers['x-oss-security-token'] = $token;
                }
                $_request->query = Utils::stringifyMapValue($request->filter->toMap());
                if (!Utils::isUnset($request->header) && !Utils::empty_($request->header->contentType)) {
                    $_request->headers['content-type'] = $request->header->contentType;
                } else {
                    $_request->headers['content-type'] = OSSUtils::getContentType($request->objectName);
                }
                $_request->headers['authorization'] = OSSUtils::getSignature($_request, $request->bucketName, $accessKeyId, $accessKeySecret, $this->_signatureVersion, $this->_addtionalHeaders);
                $_lastRequest                       = $_request;
                $_response                          = Tea::send($_request, $_runtime);
                $respMap                            = null;
                $bodyStr                            = null;
                if (Utils::is4xx($_response->statusCode) || Utils::is5xx($_response->statusCode)) {
                    $bodyStr = Utils::readAsString($_response->body);
                    $respMap = OSSUtils::getErrMessage($bodyStr);

                    throw new TeaError([
                        'code'    => @$respMap['Code'],
                        'message' => @$respMap['Message'],
                        'data'    => [
                            'httpCode'  => $_response->statusCode,
                            'requestId' => @$respMap['RequestId'],
                            'hostId'    => @$respMap['HostId'],
                        ],
                    ]);
                }
                $bodyStr = Utils::readAsString($_response->body);
                $respMap = XML::parseXml($bodyStr, InitiateMultipartUploadResponse::class);

                return InitiateMultipartUploadResponse::fromMap(Tea::merge([
                    'InitiateMultipartUploadResult' => @$respMap['InitiateMultipartUploadResult'],
                ], $_response->headers));
            } catch (Exception $e) {
                if (!($e instanceof TeaError)) {
                    $e = new TeaError([], $e->getMessage(), $e->getCode(), $e);
                }
                if (Tea::isRetryable($e)) {
                    $_lastException = $e;

                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest, $_lastException);
    }

    /**
     * @param OptionObjectRequest $request
     * @param RuntimeOptions      $runtime
     *
     * @throws TeaError
     * @throws Exception
     * @throws TeaUnableRetryError
     *
     * @return OptionObjectResponse
     */
    public function optionObject($request, $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime = [
            'timeouted'      => 'retry',
            'readTimeout'    => Utils::defaultNumber($runtime->readTimeout, $this->_readTimeout),
            'connectTimeout' => Utils::defaultNumber($runtime->connectTimeout, $this->_connectTimeout),
            'localAddr'      => Utils::defaultString($runtime->localAddr, $this->_localAddr),
            'httpProxy'      => Utils::defaultString($runtime->httpProxy, $this->_httpProxy),
            'httpsProxy'     => Utils::defaultString($runtime->httpsProxy, $this->_httpsProxy),
            'noProxy'        => Utils::defaultString($runtime->noProxy, $this->_noProxy),
            'socks5Proxy'    => Utils::defaultString($runtime->socks5Proxy, $this->_socks5Proxy),
            'socks5NetWork'  => Utils::defaultString($runtime->socks5NetWork, $this->_socks5NetWork),
            'maxIdleConns'   => Utils::defaultNumber($runtime->maxIdleConns, $this->_maxIdleConns),
            'retry'          => [
                'retryable'   => $runtime->autoretry,
                'maxAttempts' => Utils::defaultNumber($runtime->maxAttempts, 3),
            ],
            'backoff' => [
                'policy' => Utils::defaultString($runtime->backoffPolicy, 'no'),
                'period' => Utils::defaultNumber($runtime->backoffPeriod, 1),
            ],
            'ignoreSSL' => $runtime->ignoreSSL,
        ];
        $_lastRequest   = null;
        $_lastException = null;
        $_now           = time();
        $_retryTimes    = 0;
        while (Tea::allowRetry(@$_runtime['retry'], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime(@$_runtime['backoff'], $_retryTimes);
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
                $_request->method   = 'OPTIONS';
                $_request->pathname = '/' . $request->objectName . '';
                $_request->headers  = Tea::merge([
                    'host'       => OSSUtils::getHost($request->bucketName, $this->_regionId, $this->_endpoint, $this->_hostModel),
                    'date'       => Utils::getDateUTCString(),
                    'user-agent' => $this->getUserAgent(),
                ], Utils::stringifyMapValue($request->header->toMap()));
                if (!Utils::empty_($token)) {
                    $_request->headers['x-oss-security-token'] = $token;
                }
                $_request->headers['authorization'] = OSSUtils::getSignature($_request, $request->bucketName, $accessKeyId, $accessKeySecret, $this->_signatureVersion, $this->_addtionalHeaders);
                $_lastRequest                       = $_request;
                $_response                          = Tea::send($_request, $_runtime);
                $respMap                            = null;
                $bodyStr                            = null;
                if (Utils::is4xx($_response->statusCode) || Utils::is5xx($_response->statusCode)) {
                    $bodyStr = Utils::readAsString($_response->body);
                    $respMap = OSSUtils::getErrMessage($bodyStr);

                    throw new TeaError([
                        'code'    => @$respMap['Code'],
                        'message' => @$respMap['Message'],
                        'data'    => [
                            'httpCode'  => $_response->statusCode,
                            'requestId' => @$respMap['RequestId'],
                            'hostId'    => @$respMap['HostId'],
                        ],
                    ]);
                }

                return OptionObjectResponse::fromMap(Tea::merge($_response->headers));
            } catch (Exception $e) {
                if (!($e instanceof TeaError)) {
                    $e = new TeaError([], $e->getMessage(), $e->getCode(), $e);
                }
                if (Tea::isRetryable($e)) {
                    $_lastException = $e;

                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest, $_lastException);
    }

    /**
     * @param PostVodPlaylistRequest $request
     * @param RuntimeOptions         $runtime
     *
     * @throws TeaError
     * @throws Exception
     * @throws TeaUnableRetryError
     *
     * @return PostVodPlaylistResponse
     */
    public function postVodPlaylist($request, $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime = [
            'timeouted'      => 'retry',
            'readTimeout'    => Utils::defaultNumber($runtime->readTimeout, $this->_readTimeout),
            'connectTimeout' => Utils::defaultNumber($runtime->connectTimeout, $this->_connectTimeout),
            'localAddr'      => Utils::defaultString($runtime->localAddr, $this->_localAddr),
            'httpProxy'      => Utils::defaultString($runtime->httpProxy, $this->_httpProxy),
            'httpsProxy'     => Utils::defaultString($runtime->httpsProxy, $this->_httpsProxy),
            'noProxy'        => Utils::defaultString($runtime->noProxy, $this->_noProxy),
            'socks5Proxy'    => Utils::defaultString($runtime->socks5Proxy, $this->_socks5Proxy),
            'socks5NetWork'  => Utils::defaultString($runtime->socks5NetWork, $this->_socks5NetWork),
            'maxIdleConns'   => Utils::defaultNumber($runtime->maxIdleConns, $this->_maxIdleConns),
            'retry'          => [
                'retryable'   => $runtime->autoretry,
                'maxAttempts' => Utils::defaultNumber($runtime->maxAttempts, 3),
            ],
            'backoff' => [
                'policy' => Utils::defaultString($runtime->backoffPolicy, 'no'),
                'period' => Utils::defaultNumber($runtime->backoffPeriod, 1),
            ],
            'ignoreSSL' => $runtime->ignoreSSL,
        ];
        $_lastRequest   = null;
        $_lastException = null;
        $_now           = time();
        $_retryTimes    = 0;
        while (Tea::allowRetry(@$_runtime['retry'], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime(@$_runtime['backoff'], $_retryTimes);
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
                $_request->method   = 'POST';
                $_request->pathname = '/' . $request->channelName . '/' . $request->playlistName . '?vod';
                $_request->headers  = [
                    'host'       => OSSUtils::getHost($request->bucketName, $this->_regionId, $this->_endpoint, $this->_hostModel),
                    'date'       => Utils::getDateUTCString(),
                    'user-agent' => $this->getUserAgent(),
                ];
                if (!Utils::empty_($token)) {
                    $_request->headers['x-oss-security-token'] = $token;
                }
                $_request->query                    = Utils::stringifyMapValue($request->filter->toMap());
                $_request->headers['authorization'] = OSSUtils::getSignature($_request, $request->bucketName, $accessKeyId, $accessKeySecret, $this->_signatureVersion, $this->_addtionalHeaders);
                $_lastRequest                       = $_request;
                $_response                          = Tea::send($_request, $_runtime);
                $respMap                            = null;
                $bodyStr                            = null;
                if (Utils::is4xx($_response->statusCode) || Utils::is5xx($_response->statusCode)) {
                    $bodyStr = Utils::readAsString($_response->body);
                    $respMap = OSSUtils::getErrMessage($bodyStr);

                    throw new TeaError([
                        'code'    => @$respMap['Code'],
                        'message' => @$respMap['Message'],
                        'data'    => [
                            'httpCode'  => $_response->statusCode,
                            'requestId' => @$respMap['RequestId'],
                            'hostId'    => @$respMap['HostId'],
                        ],
                    ]);
                }

                return PostVodPlaylistResponse::fromMap(Tea::merge($_response->headers));
            } catch (Exception $e) {
                if (!($e instanceof TeaError)) {
                    $e = new TeaError([], $e->getMessage(), $e->getCode(), $e);
                }
                if (Tea::isRetryable($e)) {
                    $_lastException = $e;

                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest, $_lastException);
    }

    /**
     * @param PostObjectRequest $request
     * @param RuntimeOptions    $runtime
     *
     * @throws TeaError
     * @throws Exception
     * @throws TeaUnableRetryError
     *
     * @return PostObjectResponse
     */
    public function postObject($request, $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime = [
            'timeouted'      => 'retry',
            'readTimeout'    => Utils::defaultNumber($runtime->readTimeout, $this->_readTimeout),
            'connectTimeout' => Utils::defaultNumber($runtime->connectTimeout, $this->_connectTimeout),
            'httpProxy'      => Utils::defaultString($runtime->httpProxy, $this->_httpProxy),
            'httpsProxy'     => Utils::defaultString($runtime->httpsProxy, $this->_httpsProxy),
            'noProxy'        => Utils::defaultString($runtime->noProxy, $this->_noProxy),
            'maxIdleConns'   => Utils::defaultNumber($runtime->maxIdleConns, $this->_maxIdleConns),
            'retry'          => [
                'retryable'   => $runtime->autoretry,
                'maxAttempts' => Utils::defaultNumber($runtime->maxAttempts, 3),
            ],
            'backoff' => [
                'policy' => Utils::defaultString($runtime->backoffPolicy, 'no'),
                'period' => Utils::defaultNumber($runtime->backoffPeriod, 1),
            ],
            'ignoreSSL' => $runtime->ignoreSSL,
        ];
        $_lastRequest   = null;
        $_lastException = null;
        $_now           = time();
        $_retryTimes    = 0;
        while (Tea::allowRetry(@$_runtime['retry'], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime(@$_runtime['backoff'], $_retryTimes);
                if ($_backoffTime > 0) {
                    Tea::sleep($_backoffTime);
                }
            }
            $_retryTimes = $_retryTimes + 1;

            try {
                $_request           = new Request();
                $boundary           = FileForm::getBoundary();
                $_request->protocol = $this->_protocol;
                $_request->method   = 'POST';
                $_request->pathname = '/';
                $_request->headers  = [
                    'host'       => OSSUtils::getHost($request->bucketName, $this->_regionId, $this->_endpoint, $this->_hostModel),
                    'date'       => Utils::getDateUTCString(),
                    'user-agent' => $this->getUserAgent(),
                ];
                $_request->headers['content-type'] = 'multipart/form-data; boundary=' . $boundary . '';
                $form                              = Tea::merge([
                    'OSSAccessKeyId'        => $request->header->accessKeyId,
                    'policy'                => $request->header->policy,
                    'Signature'             => $request->header->signature,
                    'key'                   => $request->header->key,
                    'success_action_status' => $request->header->successActionStatus,
                    'file'                  => $request->header->file,
                ], OSSUtils::toMeta($request->header->userMeta, 'x-oss-meta-'));
                $_request->body = FileForm::toFileForm($form, $boundary);
                $_lastRequest   = $_request;
                $_response      = Tea::send($_request, $_runtime);
                $respMap        = null;
                $bodyStr        = Utils::readAsString($_response->body);
                if (Utils::is4xx($_response->statusCode) || Utils::is5xx($_response->statusCode)) {
                    $respMap = OSSUtils::getErrMessage($bodyStr);

                    throw new TeaError([
                        'code'    => @$respMap['Code'],
                        'message' => @$respMap['Message'],
                        'data'    => [
                            'httpCode'  => $_response->statusCode,
                            'requestId' => @$respMap['RequestId'],
                            'hostId'    => @$respMap['HostId'],
                        ],
                    ]);
                }
                $respMap = XML::parseXml($bodyStr, PostObjectResponse::class);

                return PostObjectResponse::fromMap(Tea::merge($respMap));
            } catch (Exception $e) {
                if (!($e instanceof TeaError)) {
                    $e = new TeaError([], $e->getMessage(), $e->getCode(), $e);
                }
                if (Tea::isRetryable($e)) {
                    $_lastException = $e;

                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest, $_lastException);
    }

    /**
     * @param HeadObjectRequest $request
     * @param RuntimeOptions    $runtime
     *
     * @throws TeaError
     * @throws Exception
     * @throws TeaUnableRetryError
     *
     * @return HeadObjectResponse
     */
    public function headObject($request, $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime = [
            'timeouted'      => 'retry',
            'readTimeout'    => Utils::defaultNumber($runtime->readTimeout, $this->_readTimeout),
            'connectTimeout' => Utils::defaultNumber($runtime->connectTimeout, $this->_connectTimeout),
            'localAddr'      => Utils::defaultString($runtime->localAddr, $this->_localAddr),
            'httpProxy'      => Utils::defaultString($runtime->httpProxy, $this->_httpProxy),
            'httpsProxy'     => Utils::defaultString($runtime->httpsProxy, $this->_httpsProxy),
            'noProxy'        => Utils::defaultString($runtime->noProxy, $this->_noProxy),
            'socks5Proxy'    => Utils::defaultString($runtime->socks5Proxy, $this->_socks5Proxy),
            'socks5NetWork'  => Utils::defaultString($runtime->socks5NetWork, $this->_socks5NetWork),
            'maxIdleConns'   => Utils::defaultNumber($runtime->maxIdleConns, $this->_maxIdleConns),
            'retry'          => [
                'retryable'   => $runtime->autoretry,
                'maxAttempts' => Utils::defaultNumber($runtime->maxAttempts, 3),
            ],
            'backoff' => [
                'policy' => Utils::defaultString($runtime->backoffPolicy, 'no'),
                'period' => Utils::defaultNumber($runtime->backoffPeriod, 1),
            ],
            'ignoreSSL' => $runtime->ignoreSSL,
        ];
        $_lastRequest   = null;
        $_lastException = null;
        $_now           = time();
        $_retryTimes    = 0;
        while (Tea::allowRetry(@$_runtime['retry'], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime(@$_runtime['backoff'], $_retryTimes);
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
                $_request->method   = 'HEAD';
                $_request->pathname = '/' . $request->objectName . '';
                $_request->headers  = Tea::merge([
                    'host'       => OSSUtils::getHost($request->bucketName, $this->_regionId, $this->_endpoint, $this->_hostModel),
                    'date'       => Utils::getDateUTCString(),
                    'user-agent' => $this->getUserAgent(),
                ], Utils::stringifyMapValue($request->header->toMap()));
                if (!Utils::empty_($token)) {
                    $_request->headers['x-oss-security-token'] = $token;
                }
                $_request->headers['authorization'] = OSSUtils::getSignature($_request, $request->bucketName, $accessKeyId, $accessKeySecret, $this->_signatureVersion, $this->_addtionalHeaders);
                $_lastRequest                       = $_request;
                $_response                          = Tea::send($_request, $_runtime);
                $respMap                            = null;
                $bodyStr                            = null;
                if (Utils::is4xx($_response->statusCode) || Utils::is5xx($_response->statusCode)) {
                    $bodyStr = Utils::readAsString($_response->body);
                    $respMap = OSSUtils::getErrMessage($bodyStr);

                    throw new TeaError([
                        'code'    => @$respMap['Code'],
                        'message' => @$respMap['Message'],
                        'data'    => [
                            'httpCode'  => $_response->statusCode,
                            'requestId' => @$respMap['RequestId'],
                            'hostId'    => @$respMap['HostId'],
                        ],
                    ]);
                }

                return HeadObjectResponse::fromMap(Tea::merge([
                    'usermeta' => OSSUtils::toMeta($_response->headers, 'x-oss-meta-'),
                ], $_response->headers));
            } catch (Exception $e) {
                if (!($e instanceof TeaError)) {
                    $e = new TeaError([], $e->getMessage(), $e->getCode(), $e);
                }
                if (Tea::isRetryable($e)) {
                    $_lastException = $e;

                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest, $_lastException);
    }

    /**
     * @param DeleteObjectTaggingRequest $request
     * @param RuntimeOptions             $runtime
     *
     * @throws TeaError
     * @throws Exception
     * @throws TeaUnableRetryError
     *
     * @return DeleteObjectTaggingResponse
     */
    public function deleteObjectTagging($request, $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime = [
            'timeouted'      => 'retry',
            'readTimeout'    => Utils::defaultNumber($runtime->readTimeout, $this->_readTimeout),
            'connectTimeout' => Utils::defaultNumber($runtime->connectTimeout, $this->_connectTimeout),
            'localAddr'      => Utils::defaultString($runtime->localAddr, $this->_localAddr),
            'httpProxy'      => Utils::defaultString($runtime->httpProxy, $this->_httpProxy),
            'httpsProxy'     => Utils::defaultString($runtime->httpsProxy, $this->_httpsProxy),
            'noProxy'        => Utils::defaultString($runtime->noProxy, $this->_noProxy),
            'socks5Proxy'    => Utils::defaultString($runtime->socks5Proxy, $this->_socks5Proxy),
            'socks5NetWork'  => Utils::defaultString($runtime->socks5NetWork, $this->_socks5NetWork),
            'maxIdleConns'   => Utils::defaultNumber($runtime->maxIdleConns, $this->_maxIdleConns),
            'retry'          => [
                'retryable'   => $runtime->autoretry,
                'maxAttempts' => Utils::defaultNumber($runtime->maxAttempts, 3),
            ],
            'backoff' => [
                'policy' => Utils::defaultString($runtime->backoffPolicy, 'no'),
                'period' => Utils::defaultNumber($runtime->backoffPeriod, 1),
            ],
            'ignoreSSL' => $runtime->ignoreSSL,
        ];
        $_lastRequest   = null;
        $_lastException = null;
        $_now           = time();
        $_retryTimes    = 0;
        while (Tea::allowRetry(@$_runtime['retry'], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime(@$_runtime['backoff'], $_retryTimes);
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
                $_request->method   = 'DELETE';
                $_request->pathname = '/' . $request->objectName . '?tagging';
                $_request->headers  = [
                    'host'       => OSSUtils::getHost($request->bucketName, $this->_regionId, $this->_endpoint, $this->_hostModel),
                    'date'       => Utils::getDateUTCString(),
                    'user-agent' => $this->getUserAgent(),
                ];
                if (!Utils::empty_($token)) {
                    $_request->headers['x-oss-security-token'] = $token;
                }
                $_request->headers['authorization'] = OSSUtils::getSignature($_request, $request->bucketName, $accessKeyId, $accessKeySecret, $this->_signatureVersion, $this->_addtionalHeaders);
                $_lastRequest                       = $_request;
                $_response                          = Tea::send($_request, $_runtime);
                $respMap                            = null;
                $bodyStr                            = null;
                if (Utils::is4xx($_response->statusCode) || Utils::is5xx($_response->statusCode)) {
                    $bodyStr = Utils::readAsString($_response->body);
                    $respMap = OSSUtils::getErrMessage($bodyStr);

                    throw new TeaError([
                        'code'    => @$respMap['Code'],
                        'message' => @$respMap['Message'],
                        'data'    => [
                            'httpCode'  => $_response->statusCode,
                            'requestId' => @$respMap['RequestId'],
                            'hostId'    => @$respMap['HostId'],
                        ],
                    ]);
                }

                return DeleteObjectTaggingResponse::fromMap(Tea::merge($_response->headers));
            } catch (Exception $e) {
                if (!($e instanceof TeaError)) {
                    $e = new TeaError([], $e->getMessage(), $e->getCode(), $e);
                }
                if (Tea::isRetryable($e)) {
                    $_lastException = $e;

                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest, $_lastException);
    }

    /**
     * @param RestoreObjectRequest $request
     * @param RuntimeOptions       $runtime
     *
     * @throws TeaError
     * @throws Exception
     * @throws TeaUnableRetryError
     *
     * @return RestoreObjectResponse
     */
    public function restoreObject($request, $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime = [
            'timeouted'      => 'retry',
            'readTimeout'    => Utils::defaultNumber($runtime->readTimeout, $this->_readTimeout),
            'connectTimeout' => Utils::defaultNumber($runtime->connectTimeout, $this->_connectTimeout),
            'localAddr'      => Utils::defaultString($runtime->localAddr, $this->_localAddr),
            'httpProxy'      => Utils::defaultString($runtime->httpProxy, $this->_httpProxy),
            'httpsProxy'     => Utils::defaultString($runtime->httpsProxy, $this->_httpsProxy),
            'noProxy'        => Utils::defaultString($runtime->noProxy, $this->_noProxy),
            'socks5Proxy'    => Utils::defaultString($runtime->socks5Proxy, $this->_socks5Proxy),
            'socks5NetWork'  => Utils::defaultString($runtime->socks5NetWork, $this->_socks5NetWork),
            'maxIdleConns'   => Utils::defaultNumber($runtime->maxIdleConns, $this->_maxIdleConns),
            'retry'          => [
                'retryable'   => $runtime->autoretry,
                'maxAttempts' => Utils::defaultNumber($runtime->maxAttempts, 3),
            ],
            'backoff' => [
                'policy' => Utils::defaultString($runtime->backoffPolicy, 'no'),
                'period' => Utils::defaultNumber($runtime->backoffPeriod, 1),
            ],
            'ignoreSSL' => $runtime->ignoreSSL,
        ];
        $_lastRequest   = null;
        $_lastException = null;
        $_now           = time();
        $_retryTimes    = 0;
        while (Tea::allowRetry(@$_runtime['retry'], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime(@$_runtime['backoff'], $_retryTimes);
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
                $_request->method   = 'POST';
                $_request->pathname = '/' . $request->objectName . '?restore';
                $_request->headers  = [
                    'host'       => OSSUtils::getHost($request->bucketName, $this->_regionId, $this->_endpoint, $this->_hostModel),
                    'date'       => Utils::getDateUTCString(),
                    'user-agent' => $this->getUserAgent(),
                ];
                if (!Utils::empty_($token)) {
                    $_request->headers['x-oss-security-token'] = $token;
                }
                $_request->headers['authorization'] = OSSUtils::getSignature($_request, $request->bucketName, $accessKeyId, $accessKeySecret, $this->_signatureVersion, $this->_addtionalHeaders);
                $_lastRequest                       = $_request;
                $_response                          = Tea::send($_request, $_runtime);
                $respMap                            = null;
                $bodyStr                            = null;
                if (Utils::is4xx($_response->statusCode) || Utils::is5xx($_response->statusCode)) {
                    $bodyStr = Utils::readAsString($_response->body);
                    $respMap = OSSUtils::getErrMessage($bodyStr);

                    throw new TeaError([
                        'code'    => @$respMap['Code'],
                        'message' => @$respMap['Message'],
                        'data'    => [
                            'httpCode'  => $_response->statusCode,
                            'requestId' => @$respMap['RequestId'],
                            'hostId'    => @$respMap['HostId'],
                        ],
                    ]);
                }

                return RestoreObjectResponse::fromMap(Tea::merge($_response->headers));
            } catch (Exception $e) {
                if (!($e instanceof TeaError)) {
                    $e = new TeaError([], $e->getMessage(), $e->getCode(), $e);
                }
                if (Tea::isRetryable($e)) {
                    $_lastException = $e;

                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest, $_lastException);
    }

    /**
     * @param GetObjectAclRequest $request
     * @param RuntimeOptions      $runtime
     *
     * @throws TeaError
     * @throws Exception
     * @throws TeaUnableRetryError
     *
     * @return GetObjectAclResponse
     */
    public function getObjectAcl($request, $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime = [
            'timeouted'      => 'retry',
            'readTimeout'    => Utils::defaultNumber($runtime->readTimeout, $this->_readTimeout),
            'connectTimeout' => Utils::defaultNumber($runtime->connectTimeout, $this->_connectTimeout),
            'localAddr'      => Utils::defaultString($runtime->localAddr, $this->_localAddr),
            'httpProxy'      => Utils::defaultString($runtime->httpProxy, $this->_httpProxy),
            'httpsProxy'     => Utils::defaultString($runtime->httpsProxy, $this->_httpsProxy),
            'noProxy'        => Utils::defaultString($runtime->noProxy, $this->_noProxy),
            'socks5Proxy'    => Utils::defaultString($runtime->socks5Proxy, $this->_socks5Proxy),
            'socks5NetWork'  => Utils::defaultString($runtime->socks5NetWork, $this->_socks5NetWork),
            'maxIdleConns'   => Utils::defaultNumber($runtime->maxIdleConns, $this->_maxIdleConns),
            'retry'          => [
                'retryable'   => $runtime->autoretry,
                'maxAttempts' => Utils::defaultNumber($runtime->maxAttempts, 3),
            ],
            'backoff' => [
                'policy' => Utils::defaultString($runtime->backoffPolicy, 'no'),
                'period' => Utils::defaultNumber($runtime->backoffPeriod, 1),
            ],
            'ignoreSSL' => $runtime->ignoreSSL,
        ];
        $_lastRequest   = null;
        $_lastException = null;
        $_now           = time();
        $_retryTimes    = 0;
        while (Tea::allowRetry(@$_runtime['retry'], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime(@$_runtime['backoff'], $_retryTimes);
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
                $_request->method   = 'GET';
                $_request->pathname = '/' . $request->objectName . '?acl';
                $_request->headers  = [
                    'host'       => OSSUtils::getHost($request->bucketName, $this->_regionId, $this->_endpoint, $this->_hostModel),
                    'date'       => Utils::getDateUTCString(),
                    'user-agent' => $this->getUserAgent(),
                ];
                if (!Utils::empty_($token)) {
                    $_request->headers['x-oss-security-token'] = $token;
                }
                $_request->headers['authorization'] = OSSUtils::getSignature($_request, $request->bucketName, $accessKeyId, $accessKeySecret, $this->_signatureVersion, $this->_addtionalHeaders);
                $_lastRequest                       = $_request;
                $_response                          = Tea::send($_request, $_runtime);
                $respMap                            = null;
                $bodyStr                            = null;
                if (Utils::is4xx($_response->statusCode) || Utils::is5xx($_response->statusCode)) {
                    $bodyStr = Utils::readAsString($_response->body);
                    $respMap = OSSUtils::getErrMessage($bodyStr);

                    throw new TeaError([
                        'code'    => @$respMap['Code'],
                        'message' => @$respMap['Message'],
                        'data'    => [
                            'httpCode'  => $_response->statusCode,
                            'requestId' => @$respMap['RequestId'],
                            'hostId'    => @$respMap['HostId'],
                        ],
                    ]);
                }
                $bodyStr = Utils::readAsString($_response->body);
                $respMap = XML::parseXml($bodyStr, GetObjectAclResponse::class);

                return GetObjectAclResponse::fromMap(Tea::merge([
                    'AccessControlPolicy' => @$respMap['AccessControlPolicy'],
                ], $_response->headers));
            } catch (Exception $e) {
                if (!($e instanceof TeaError)) {
                    $e = new TeaError([], $e->getMessage(), $e->getCode(), $e);
                }
                if (Tea::isRetryable($e)) {
                    $_lastException = $e;

                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest, $_lastException);
    }

    /**
     * @param PutBucketAclRequest $request
     * @param RuntimeOptions      $runtime
     *
     * @throws TeaError
     * @throws Exception
     * @throws TeaUnableRetryError
     *
     * @return PutBucketAclResponse
     */
    public function putBucketAcl($request, $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime = [
            'timeouted'      => 'retry',
            'readTimeout'    => Utils::defaultNumber($runtime->readTimeout, $this->_readTimeout),
            'connectTimeout' => Utils::defaultNumber($runtime->connectTimeout, $this->_connectTimeout),
            'localAddr'      => Utils::defaultString($runtime->localAddr, $this->_localAddr),
            'httpProxy'      => Utils::defaultString($runtime->httpProxy, $this->_httpProxy),
            'httpsProxy'     => Utils::defaultString($runtime->httpsProxy, $this->_httpsProxy),
            'noProxy'        => Utils::defaultString($runtime->noProxy, $this->_noProxy),
            'socks5Proxy'    => Utils::defaultString($runtime->socks5Proxy, $this->_socks5Proxy),
            'socks5NetWork'  => Utils::defaultString($runtime->socks5NetWork, $this->_socks5NetWork),
            'maxIdleConns'   => Utils::defaultNumber($runtime->maxIdleConns, $this->_maxIdleConns),
            'retry'          => [
                'retryable'   => $runtime->autoretry,
                'maxAttempts' => Utils::defaultNumber($runtime->maxAttempts, 3),
            ],
            'backoff' => [
                'policy' => Utils::defaultString($runtime->backoffPolicy, 'no'),
                'period' => Utils::defaultNumber($runtime->backoffPeriod, 1),
            ],
            'ignoreSSL' => $runtime->ignoreSSL,
        ];
        $_lastRequest   = null;
        $_lastException = null;
        $_now           = time();
        $_retryTimes    = 0;
        while (Tea::allowRetry(@$_runtime['retry'], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime(@$_runtime['backoff'], $_retryTimes);
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
                $_request->method   = 'PUT';
                $_request->pathname = '/?acl';
                $_request->headers  = Tea::merge([
                    'host'       => OSSUtils::getHost($request->bucketName, $this->_regionId, $this->_endpoint, $this->_hostModel),
                    'date'       => Utils::getDateUTCString(),
                    'user-agent' => $this->getUserAgent(),
                ], Utils::stringifyMapValue($request->header->toMap()));
                if (!Utils::empty_($token)) {
                    $_request->headers['x-oss-security-token'] = $token;
                }
                $_request->headers['authorization'] = OSSUtils::getSignature($_request, $request->bucketName, $accessKeyId, $accessKeySecret, $this->_signatureVersion, $this->_addtionalHeaders);
                $_lastRequest                       = $_request;
                $_response                          = Tea::send($_request, $_runtime);
                $respMap                            = null;
                $bodyStr                            = null;
                if (Utils::is4xx($_response->statusCode) || Utils::is5xx($_response->statusCode)) {
                    $bodyStr = Utils::readAsString($_response->body);
                    $respMap = OSSUtils::getErrMessage($bodyStr);

                    throw new TeaError([
                        'code'    => @$respMap['Code'],
                        'message' => @$respMap['Message'],
                        'data'    => [
                            'httpCode'  => $_response->statusCode,
                            'requestId' => @$respMap['RequestId'],
                            'hostId'    => @$respMap['HostId'],
                        ],
                    ]);
                }

                return PutBucketAclResponse::fromMap(Tea::merge($_response->headers));
            } catch (Exception $e) {
                if (!($e instanceof TeaError)) {
                    $e = new TeaError([], $e->getMessage(), $e->getCode(), $e);
                }
                if (Tea::isRetryable($e)) {
                    $_lastException = $e;

                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest, $_lastException);
    }

    /**
     * @param DeleteBucketRequest $request
     * @param RuntimeOptions      $runtime
     *
     * @throws TeaError
     * @throws Exception
     * @throws TeaUnableRetryError
     *
     * @return DeleteBucketResponse
     */
    public function deleteBucket($request, $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime = [
            'timeouted'      => 'retry',
            'readTimeout'    => Utils::defaultNumber($runtime->readTimeout, $this->_readTimeout),
            'connectTimeout' => Utils::defaultNumber($runtime->connectTimeout, $this->_connectTimeout),
            'localAddr'      => Utils::defaultString($runtime->localAddr, $this->_localAddr),
            'httpProxy'      => Utils::defaultString($runtime->httpProxy, $this->_httpProxy),
            'httpsProxy'     => Utils::defaultString($runtime->httpsProxy, $this->_httpsProxy),
            'noProxy'        => Utils::defaultString($runtime->noProxy, $this->_noProxy),
            'socks5Proxy'    => Utils::defaultString($runtime->socks5Proxy, $this->_socks5Proxy),
            'socks5NetWork'  => Utils::defaultString($runtime->socks5NetWork, $this->_socks5NetWork),
            'maxIdleConns'   => Utils::defaultNumber($runtime->maxIdleConns, $this->_maxIdleConns),
            'retry'          => [
                'retryable'   => $runtime->autoretry,
                'maxAttempts' => Utils::defaultNumber($runtime->maxAttempts, 3),
            ],
            'backoff' => [
                'policy' => Utils::defaultString($runtime->backoffPolicy, 'no'),
                'period' => Utils::defaultNumber($runtime->backoffPeriod, 1),
            ],
            'ignoreSSL' => $runtime->ignoreSSL,
        ];
        $_lastRequest   = null;
        $_lastException = null;
        $_now           = time();
        $_retryTimes    = 0;
        while (Tea::allowRetry(@$_runtime['retry'], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime(@$_runtime['backoff'], $_retryTimes);
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
                $_request->method   = 'DELETE';
                $_request->pathname = '/';
                $_request->headers  = [
                    'host'       => OSSUtils::getHost($request->bucketName, $this->_regionId, $this->_endpoint, $this->_hostModel),
                    'date'       => Utils::getDateUTCString(),
                    'user-agent' => $this->getUserAgent(),
                ];
                if (!Utils::empty_($token)) {
                    $_request->headers['x-oss-security-token'] = $token;
                }
                $_request->headers['authorization'] = OSSUtils::getSignature($_request, $request->bucketName, $accessKeyId, $accessKeySecret, $this->_signatureVersion, $this->_addtionalHeaders);
                $_lastRequest                       = $_request;
                $_response                          = Tea::send($_request, $_runtime);
                $respMap                            = null;
                $bodyStr                            = null;
                if (Utils::is4xx($_response->statusCode) || Utils::is5xx($_response->statusCode)) {
                    $bodyStr = Utils::readAsString($_response->body);
                    $respMap = OSSUtils::getErrMessage($bodyStr);

                    throw new TeaError([
                        'code'    => @$respMap['Code'],
                        'message' => @$respMap['Message'],
                        'data'    => [
                            'httpCode'  => $_response->statusCode,
                            'requestId' => @$respMap['RequestId'],
                            'hostId'    => @$respMap['HostId'],
                        ],
                    ]);
                }

                return DeleteBucketResponse::fromMap(Tea::merge($_response->headers));
            } catch (Exception $e) {
                if (!($e instanceof TeaError)) {
                    $e = new TeaError([], $e->getMessage(), $e->getCode(), $e);
                }
                if (Tea::isRetryable($e)) {
                    $_lastException = $e;

                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest, $_lastException);
    }

    /**
     * @param PutObjectRequest $request
     * @param RuntimeOptions   $runtime
     *
     * @throws TeaError
     * @throws Exception
     * @throws TeaUnableRetryError
     *
     * @return PutObjectResponse
     */
    public function putObject($request, $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime = [
            'timeouted'      => 'retry',
            'readTimeout'    => Utils::defaultNumber($runtime->readTimeout, $this->_readTimeout),
            'connectTimeout' => Utils::defaultNumber($runtime->connectTimeout, $this->_connectTimeout),
            'localAddr'      => Utils::defaultString($runtime->localAddr, $this->_localAddr),
            'httpProxy'      => Utils::defaultString($runtime->httpProxy, $this->_httpProxy),
            'httpsProxy'     => Utils::defaultString($runtime->httpsProxy, $this->_httpsProxy),
            'noProxy'        => Utils::defaultString($runtime->noProxy, $this->_noProxy),
            'socks5Proxy'    => Utils::defaultString($runtime->socks5Proxy, $this->_socks5Proxy),
            'socks5NetWork'  => Utils::defaultString($runtime->socks5NetWork, $this->_socks5NetWork),
            'maxIdleConns'   => Utils::defaultNumber($runtime->maxIdleConns, $this->_maxIdleConns),
            'retry'          => [
                'retryable'   => $runtime->autoretry,
                'maxAttempts' => Utils::defaultNumber($runtime->maxAttempts, 3),
            ],
            'backoff' => [
                'policy' => Utils::defaultString($runtime->backoffPolicy, 'no'),
                'period' => Utils::defaultNumber($runtime->backoffPeriod, 1),
            ],
            'ignoreSSL' => $runtime->ignoreSSL,
        ];
        $_lastRequest   = null;
        $_lastException = null;
        $_now           = time();
        $_retryTimes    = 0;
        while (Tea::allowRetry(@$_runtime['retry'], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime(@$_runtime['backoff'], $_retryTimes);
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
                $_request->method   = 'PUT';
                $_request->pathname = '/' . $request->objectName . '';
                $_request->headers  = Tea::merge([
                    'host'       => OSSUtils::getHost($request->bucketName, $this->_regionId, $this->_endpoint, $this->_hostModel),
                    'date'       => Utils::getDateUTCString(),
                    'user-agent' => $this->getUserAgent(),
                ], Utils::stringifyMapValue($request->header->toMap()), OSSUtils::parseMeta($request->userMeta, 'x-oss-meta-'));
                if (!Utils::empty_($token)) {
                    $_request->headers['x-oss-security-token'] = $token;
                }
                $_request->body = OSSUtils::inject($request->body, $ctx);
                if (!Utils::isUnset($request->header) && !Utils::empty_($request->header->contentType)) {
                    $_request->headers['content-type'] = $request->header->contentType;
                } else {
                    $_request->headers['content-type'] = OSSUtils::getContentType($request->objectName);
                }
                $_request->headers['authorization'] = OSSUtils::getSignature($_request, $request->bucketName, $accessKeyId, $accessKeySecret, $this->_signatureVersion, $this->_addtionalHeaders);
                $_lastRequest                       = $_request;
                $_response                          = Tea::send($_request, $_runtime);
                $respMap                            = null;
                $bodyStr                            = null;
                if (Utils::is4xx($_response->statusCode) || Utils::is5xx($_response->statusCode)) {
                    $bodyStr = Utils::readAsString($_response->body);
                    $respMap = OSSUtils::getErrMessage($bodyStr);

                    throw new TeaError([
                        'code'    => @$respMap['Code'],
                        'message' => @$respMap['Message'],
                        'data'    => [
                            'httpCode'  => $_response->statusCode,
                            'requestId' => @$respMap['RequestId'],
                            'hostId'    => @$respMap['HostId'],
                        ],
                    ]);
                }
                if ($this->_isEnableCrc && !Utils::equalString(@$ctx['crc'], $_response->headers['x-oss-hash-crc64ecma'])) {
                    throw new TeaError([
                        'code' => 'CrcNotMatched',
                        'data' => [
                            'clientCrc' => @$ctx['crc'],
                            'serverCrc' => $_response->headers['x-oss-hash-crc64ecma'],
                        ],
                    ]);
                }
                if ($this->_isEnableMD5 && !Utils::equalString(@$ctx['md5'], $_response->headers['content-md5'])) {
                    throw new TeaError([
                        'code' => 'MD5NotMatched',
                        'data' => [
                            'clientMD5' => @$ctx['md5'],
                            'serverMD5' => $_response->headers['content-md5'],
                        ],
                    ]);
                }

                return PutObjectResponse::fromMap(Tea::merge($_response->headers));
            } catch (Exception $e) {
                if (!($e instanceof TeaError)) {
                    $e = new TeaError([], $e->getMessage(), $e->getCode(), $e);
                }
                if (Tea::isRetryable($e)) {
                    $_lastException = $e;

                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest, $_lastException);
    }

    /**
     * @param string $userAgent
     */
    public function setUserAgent($userAgent)
    {
        $this->_userAgent = $userAgent;
    }

    /**
     * @param string $userAgent
     */
    public function appendUserAgent($userAgent)
    {
        $this->_userAgent = '' . $this->_userAgent . ' ' . $userAgent . '';
    }

    /**
     * @return string
     */
    public function getUserAgent()
    {
        return Utils::getUserAgent($this->_userAgent);
    }

    /**
     * @return string
     */
    public function getAccessKeyId()
    {
        if (Utils::isUnset($this->_credential)) {
            return '';
        }

        return $this->_credential->getAccessKeyId();
    }

    /**
     * @return string
     */
    public function getAccessKeySecret()
    {
        if (Utils::isUnset($this->_credential)) {
            return '';
        }

        return $this->_credential->getAccessKeySecret();
    }
}
