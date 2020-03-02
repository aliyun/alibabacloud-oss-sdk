// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss;

import com.aliyun.tea.*;
import com.aliyun.oss.models.*;

public class Client {

    public String _endpoint;
    public String _regionId;
    public String _hostModel;
    public String _protocol;
    public Integer _readTimeout;
    public Integer _connectTimeout;
    public String _signatureVersion;
    public java.util.List<String> _addtionalHeaders;
    public String _localAddr;
    public String _httpProxy;
    public String _httpsProxy;
    public String _noProxy;
    public String _userAgent;
    public String _socks5Proxy;
    public Boolean _isEnableCrc;
    public Boolean _isEnableMD5;
    public String _socks5NetWork;
    public Integer _maxIdleConns;
    public com.aliyun.credentials.Client _credential;
    public Client(Config config) throws Exception {
        if (com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(config))) {
            throw new TeaException(TeaConverter.buildMap(
                new TeaPair("name", "ParameterMissing"),
                new TeaPair("message", "'config' can not be unset")
            ));
        }

        if (com.aliyun.teautil.Common.empty(config.type)) {
            config.type = "access_key";
        }

        com.aliyun.credentials.models.Config credentialConfig = com.aliyun.credentials.models.Config.build(TeaConverter.buildMap(
            new TeaPair("accessKeyId", config.accessKeyId),
            new TeaPair("type", config.type),
            new TeaPair("accessKeySecret", config.accessKeySecret),
            new TeaPair("securityToken", config.securityToken)
        ));
        this._credential = new com.aliyun.credentials.Client(credentialConfig);
        if (com.aliyun.teautil.Common.isUnset(config.isEnableMD5)) {
            config.isEnableMD5 = false;
        }

        if (com.aliyun.teautil.Common.isUnset(config.isEnableCrc)) {
            config.isEnableCrc = false;
        }

        this._endpoint = config.endpoint;
        this._protocol = config.protocol;
        this._regionId = config.regionId;
        this._userAgent = config.userAgent;
        this._readTimeout = config.readTimeout;
        this._connectTimeout = config.connectTimeout;
        this._localAddr = config.localAddr;
        this._httpProxy = config.httpProxy;
        this._httpsProxy = config.httpsProxy;
        this._noProxy = config.noProxy;
        this._socks5Proxy = config.socks5Proxy;
        this._socks5NetWork = config.socks5NetWork;
        this._maxIdleConns = config.maxIdleConns;
        this._signatureVersion = config.signatureVersion;
        this._addtionalHeaders = config.addtionalHeaders;
        this._hostModel = config.hostModel;
        this._isEnableMD5 = config.isEnableMD5;
        this._isEnableCrc = config.isEnableCrc;
    }

    public PutBucketLifecycleResponse putBucketLifecycle(PutBucketLifecycleRequest request, com.aliyun.ossutil.models.RuntimeOptions runtime) throws Exception {
        TeaModel.validateParams(request, "request");
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", com.aliyun.teautil.Common.defaultNumber(runtime.readTimeout, _readTimeout)),
            new TeaPair("connectTimeout", com.aliyun.teautil.Common.defaultNumber(runtime.connectTimeout, _connectTimeout)),
            new TeaPair("localAddr", com.aliyun.teautil.Common.defaultString(runtime.localAddr, _localAddr)),
            new TeaPair("httpProxy", com.aliyun.teautil.Common.defaultString(runtime.httpProxy, _httpProxy)),
            new TeaPair("httpsProxy", com.aliyun.teautil.Common.defaultString(runtime.httpsProxy, _httpsProxy)),
            new TeaPair("noProxy", com.aliyun.teautil.Common.defaultString(runtime.noProxy, _noProxy)),
            new TeaPair("socks5Proxy", com.aliyun.teautil.Common.defaultString(runtime.socks5Proxy, _socks5Proxy)),
            new TeaPair("socks5NetWork", com.aliyun.teautil.Common.defaultString(runtime.socks5NetWork, _socks5NetWork)),
            new TeaPair("maxIdleConns", com.aliyun.teautil.Common.defaultNumber(runtime.maxIdleConns, _maxIdleConns)),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", com.aliyun.teautil.Common.defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", com.aliyun.teautil.Common.defaultString(runtime.backoffPolicy, "no")),
                new TeaPair("period", com.aliyun.teautil.Common.defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL)
        );

        TeaRequest _lastRequest = null;
        long _now = System.currentTimeMillis();
        int _retryTimes = 0;
        while (Tea.allowRetry((java.util.Map<String, Object>) runtime_.get("retry"), _retryTimes, _now)) {
            if (_retryTimes > 0) {
                int backoffTime = Tea.getBackoffTime(runtime_.get("backoff"), _retryTimes);
                if (backoffTime > 0) {
                    Tea.sleep(backoffTime);
                }
            }
            _retryTimes = _retryTimes + 1;
            try {
                TeaRequest request_ = new TeaRequest();
                String accessKeyId = _credential.getAccessKeyId();
                String accessKeySecret = _credential.getAccessKeySecret();
                String token = _credential.getSecurityToken();
                String reqBody = com.aliyun.teaxml.Client.toXML(TeaModel.buildMap(request.body));
                request_.protocol = _protocol;
                request_.method = "PUT";
                request_.pathname = "/?lifecycle";
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("host", com.aliyun.ossutil.Client.getHost(request.bucketName, _regionId, _endpoint, _hostModel)),
                    new TeaPair("date", com.aliyun.teautil.Common.getDateUTCString()),
                    new TeaPair("user-agent", this.getUserAgent())
                );
                if (!com.aliyun.teautil.Common.empty(token)) {
                    request_.headers.put("x-oss-security-token", token);
                }

                request_.body = Tea.toReadable(reqBody);
                request_.headers.put("authorization", com.aliyun.ossutil.Client.getSignature(request_, request.bucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                String bodyStr = null;
                if (com.aliyun.teautil.Common.is4xx(response_.statusCode) || com.aliyun.teautil.Common.is5xx(response_.statusCode)) {
                    bodyStr = com.aliyun.teautil.Common.readAsString(response_.body);
                    respMap = com.aliyun.ossutil.Client.getErrMessage(bodyStr);
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("code", respMap.get("Code")),
                        new TeaPair("message", respMap.get("Message")),
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("httpCode", response_.statusCode),
                            new TeaPair("requestId", respMap.get("RequestId")),
                            new TeaPair("hostId", respMap.get("HostId"))
                        ))
                    ));
                }

                return TeaModel.toModel(TeaConverter.merge(String.class,
                    response_.headers
                ), new PutBucketLifecycleResponse());
            } catch (Exception e) {
                if (Tea.isRetryable(e)) {
                    continue;
                }
                throw e;
            }
        }

        throw new TeaUnretryableException(_lastRequest);
    }

    public DeleteMultipleObjectsResponse deleteMultipleObjects(DeleteMultipleObjectsRequest request, com.aliyun.ossutil.models.RuntimeOptions runtime) throws Exception {
        TeaModel.validateParams(request, "request");
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", com.aliyun.teautil.Common.defaultNumber(runtime.readTimeout, _readTimeout)),
            new TeaPair("connectTimeout", com.aliyun.teautil.Common.defaultNumber(runtime.connectTimeout, _connectTimeout)),
            new TeaPair("localAddr", com.aliyun.teautil.Common.defaultString(runtime.localAddr, _localAddr)),
            new TeaPair("httpProxy", com.aliyun.teautil.Common.defaultString(runtime.httpProxy, _httpProxy)),
            new TeaPair("httpsProxy", com.aliyun.teautil.Common.defaultString(runtime.httpsProxy, _httpsProxy)),
            new TeaPair("noProxy", com.aliyun.teautil.Common.defaultString(runtime.noProxy, _noProxy)),
            new TeaPair("socks5Proxy", com.aliyun.teautil.Common.defaultString(runtime.socks5Proxy, _socks5Proxy)),
            new TeaPair("socks5NetWork", com.aliyun.teautil.Common.defaultString(runtime.socks5NetWork, _socks5NetWork)),
            new TeaPair("maxIdleConns", com.aliyun.teautil.Common.defaultNumber(runtime.maxIdleConns, _maxIdleConns)),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", com.aliyun.teautil.Common.defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", com.aliyun.teautil.Common.defaultString(runtime.backoffPolicy, "no")),
                new TeaPair("period", com.aliyun.teautil.Common.defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL)
        );

        TeaRequest _lastRequest = null;
        long _now = System.currentTimeMillis();
        int _retryTimes = 0;
        while (Tea.allowRetry((java.util.Map<String, Object>) runtime_.get("retry"), _retryTimes, _now)) {
            if (_retryTimes > 0) {
                int backoffTime = Tea.getBackoffTime(runtime_.get("backoff"), _retryTimes);
                if (backoffTime > 0) {
                    Tea.sleep(backoffTime);
                }
            }
            _retryTimes = _retryTimes + 1;
            try {
                TeaRequest request_ = new TeaRequest();
                String accessKeyId = _credential.getAccessKeyId();
                String accessKeySecret = _credential.getAccessKeySecret();
                String token = _credential.getSecurityToken();
                String reqBody = com.aliyun.teaxml.Client.toXML(TeaModel.buildMap(request.body));
                request_.protocol = _protocol;
                request_.method = "POST";
                request_.pathname = "/?delete";
                request_.headers = TeaConverter.merge(String.class,
                    TeaConverter.buildMap(
                        new TeaPair("host", com.aliyun.ossutil.Client.getHost(request.bucketName, _regionId, _endpoint, _hostModel)),
                        new TeaPair("date", com.aliyun.teautil.Common.getDateUTCString()),
                        new TeaPair("user-agent", this.getUserAgent())
                    ),
                    com.aliyun.teautil.Common.stringifyMapValue(TeaModel.buildMap(request.header))
                );
                if (!com.aliyun.teautil.Common.empty(token)) {
                    request_.headers.put("x-oss-security-token", token);
                }

                request_.body = Tea.toReadable(reqBody);
                if (com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.header)) && !com.aliyun.teautil.Common.empty(request.header.contentMD5)) {
                    request_.headers.put("content-md5", request.header.contentMD5);
                } else {
                    request_.headers.put("content-md5", com.aliyun.ossutil.Client.getContentMD5(reqBody, _isEnableMD5));
                }

                request_.headers.put("authorization", com.aliyun.ossutil.Client.getSignature(request_, request.bucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                String bodyStr = null;
                if (com.aliyun.teautil.Common.is4xx(response_.statusCode) || com.aliyun.teautil.Common.is5xx(response_.statusCode)) {
                    bodyStr = com.aliyun.teautil.Common.readAsString(response_.body);
                    respMap = com.aliyun.ossutil.Client.getErrMessage(bodyStr);
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("code", respMap.get("Code")),
                        new TeaPair("message", respMap.get("Message")),
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("httpCode", response_.statusCode),
                            new TeaPair("requestId", respMap.get("RequestId")),
                            new TeaPair("hostId", respMap.get("HostId"))
                        ))
                    ));
                }

                bodyStr = com.aliyun.teautil.Common.readAsString(response_.body);
                respMap = com.aliyun.teaxml.Client.parseXml(bodyStr, DeleteMultipleObjectsResponse.class);
                return TeaModel.toModel(TeaConverter.merge(Object.class,
                    TeaConverter.buildMap(
                        new TeaPair("DeleteResult", respMap.get("DeleteResult"))
                    ),
                    response_.headers
                ), new DeleteMultipleObjectsResponse());
            } catch (Exception e) {
                if (Tea.isRetryable(e)) {
                    continue;
                }
                throw e;
            }
        }

        throw new TeaUnretryableException(_lastRequest);
    }

    public PutBucketRefererResponse putBucketReferer(PutBucketRefererRequest request, com.aliyun.ossutil.models.RuntimeOptions runtime) throws Exception {
        TeaModel.validateParams(request, "request");
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", com.aliyun.teautil.Common.defaultNumber(runtime.readTimeout, _readTimeout)),
            new TeaPair("connectTimeout", com.aliyun.teautil.Common.defaultNumber(runtime.connectTimeout, _connectTimeout)),
            new TeaPair("localAddr", com.aliyun.teautil.Common.defaultString(runtime.localAddr, _localAddr)),
            new TeaPair("httpProxy", com.aliyun.teautil.Common.defaultString(runtime.httpProxy, _httpProxy)),
            new TeaPair("httpsProxy", com.aliyun.teautil.Common.defaultString(runtime.httpsProxy, _httpsProxy)),
            new TeaPair("noProxy", com.aliyun.teautil.Common.defaultString(runtime.noProxy, _noProxy)),
            new TeaPair("socks5Proxy", com.aliyun.teautil.Common.defaultString(runtime.socks5Proxy, _socks5Proxy)),
            new TeaPair("socks5NetWork", com.aliyun.teautil.Common.defaultString(runtime.socks5NetWork, _socks5NetWork)),
            new TeaPair("maxIdleConns", com.aliyun.teautil.Common.defaultNumber(runtime.maxIdleConns, _maxIdleConns)),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", com.aliyun.teautil.Common.defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", com.aliyun.teautil.Common.defaultString(runtime.backoffPolicy, "no")),
                new TeaPair("period", com.aliyun.teautil.Common.defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL)
        );

        TeaRequest _lastRequest = null;
        long _now = System.currentTimeMillis();
        int _retryTimes = 0;
        while (Tea.allowRetry((java.util.Map<String, Object>) runtime_.get("retry"), _retryTimes, _now)) {
            if (_retryTimes > 0) {
                int backoffTime = Tea.getBackoffTime(runtime_.get("backoff"), _retryTimes);
                if (backoffTime > 0) {
                    Tea.sleep(backoffTime);
                }
            }
            _retryTimes = _retryTimes + 1;
            try {
                TeaRequest request_ = new TeaRequest();
                String accessKeyId = _credential.getAccessKeyId();
                String accessKeySecret = _credential.getAccessKeySecret();
                String token = _credential.getSecurityToken();
                String reqBody = com.aliyun.teaxml.Client.toXML(TeaModel.buildMap(request.body));
                request_.protocol = _protocol;
                request_.method = "PUT";
                request_.pathname = "/?referer";
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("host", com.aliyun.ossutil.Client.getHost(request.bucketName, _regionId, _endpoint, _hostModel)),
                    new TeaPair("date", com.aliyun.teautil.Common.getDateUTCString()),
                    new TeaPair("user-agent", this.getUserAgent())
                );
                if (!com.aliyun.teautil.Common.empty(token)) {
                    request_.headers.put("x-oss-security-token", token);
                }

                request_.body = Tea.toReadable(reqBody);
                request_.headers.put("authorization", com.aliyun.ossutil.Client.getSignature(request_, request.bucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                String bodyStr = null;
                if (com.aliyun.teautil.Common.is4xx(response_.statusCode) || com.aliyun.teautil.Common.is5xx(response_.statusCode)) {
                    bodyStr = com.aliyun.teautil.Common.readAsString(response_.body);
                    respMap = com.aliyun.ossutil.Client.getErrMessage(bodyStr);
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("code", respMap.get("Code")),
                        new TeaPair("message", respMap.get("Message")),
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("httpCode", response_.statusCode),
                            new TeaPair("requestId", respMap.get("RequestId")),
                            new TeaPair("hostId", respMap.get("HostId"))
                        ))
                    ));
                }

                return TeaModel.toModel(TeaConverter.merge(String.class,
                    response_.headers
                ), new PutBucketRefererResponse());
            } catch (Exception e) {
                if (Tea.isRetryable(e)) {
                    continue;
                }
                throw e;
            }
        }

        throw new TeaUnretryableException(_lastRequest);
    }

    public PutBucketWebsiteResponse putBucketWebsite(PutBucketWebsiteRequest request, com.aliyun.ossutil.models.RuntimeOptions runtime) throws Exception {
        TeaModel.validateParams(request, "request");
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", com.aliyun.teautil.Common.defaultNumber(runtime.readTimeout, _readTimeout)),
            new TeaPair("connectTimeout", com.aliyun.teautil.Common.defaultNumber(runtime.connectTimeout, _connectTimeout)),
            new TeaPair("localAddr", com.aliyun.teautil.Common.defaultString(runtime.localAddr, _localAddr)),
            new TeaPair("httpProxy", com.aliyun.teautil.Common.defaultString(runtime.httpProxy, _httpProxy)),
            new TeaPair("httpsProxy", com.aliyun.teautil.Common.defaultString(runtime.httpsProxy, _httpsProxy)),
            new TeaPair("noProxy", com.aliyun.teautil.Common.defaultString(runtime.noProxy, _noProxy)),
            new TeaPair("socks5Proxy", com.aliyun.teautil.Common.defaultString(runtime.socks5Proxy, _socks5Proxy)),
            new TeaPair("socks5NetWork", com.aliyun.teautil.Common.defaultString(runtime.socks5NetWork, _socks5NetWork)),
            new TeaPair("maxIdleConns", com.aliyun.teautil.Common.defaultNumber(runtime.maxIdleConns, _maxIdleConns)),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", com.aliyun.teautil.Common.defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", com.aliyun.teautil.Common.defaultString(runtime.backoffPolicy, "no")),
                new TeaPair("period", com.aliyun.teautil.Common.defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL)
        );

        TeaRequest _lastRequest = null;
        long _now = System.currentTimeMillis();
        int _retryTimes = 0;
        while (Tea.allowRetry((java.util.Map<String, Object>) runtime_.get("retry"), _retryTimes, _now)) {
            if (_retryTimes > 0) {
                int backoffTime = Tea.getBackoffTime(runtime_.get("backoff"), _retryTimes);
                if (backoffTime > 0) {
                    Tea.sleep(backoffTime);
                }
            }
            _retryTimes = _retryTimes + 1;
            try {
                TeaRequest request_ = new TeaRequest();
                String accessKeyId = _credential.getAccessKeyId();
                String accessKeySecret = _credential.getAccessKeySecret();
                String token = _credential.getSecurityToken();
                String reqBody = com.aliyun.teaxml.Client.toXML(TeaModel.buildMap(request.body));
                request_.protocol = _protocol;
                request_.method = "PUT";
                request_.pathname = "/?website";
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("host", com.aliyun.ossutil.Client.getHost(request.bucketName, _regionId, _endpoint, _hostModel)),
                    new TeaPair("date", com.aliyun.teautil.Common.getDateUTCString()),
                    new TeaPair("user-agent", this.getUserAgent())
                );
                if (!com.aliyun.teautil.Common.empty(token)) {
                    request_.headers.put("x-oss-security-token", token);
                }

                request_.body = Tea.toReadable(reqBody);
                request_.headers.put("authorization", com.aliyun.ossutil.Client.getSignature(request_, request.bucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                String bodyStr = null;
                if (com.aliyun.teautil.Common.is4xx(response_.statusCode) || com.aliyun.teautil.Common.is5xx(response_.statusCode)) {
                    bodyStr = com.aliyun.teautil.Common.readAsString(response_.body);
                    respMap = com.aliyun.ossutil.Client.getErrMessage(bodyStr);
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("code", respMap.get("Code")),
                        new TeaPair("message", respMap.get("Message")),
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("httpCode", response_.statusCode),
                            new TeaPair("requestId", respMap.get("RequestId")),
                            new TeaPair("hostId", respMap.get("HostId"))
                        ))
                    ));
                }

                return TeaModel.toModel(TeaConverter.merge(String.class,
                    response_.headers
                ), new PutBucketWebsiteResponse());
            } catch (Exception e) {
                if (Tea.isRetryable(e)) {
                    continue;
                }
                throw e;
            }
        }

        throw new TeaUnretryableException(_lastRequest);
    }

    public CompleteMultipartUploadResponse completeMultipartUpload(CompleteMultipartUploadRequest request, com.aliyun.ossutil.models.RuntimeOptions runtime) throws Exception {
        TeaModel.validateParams(request, "request");
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", com.aliyun.teautil.Common.defaultNumber(runtime.readTimeout, _readTimeout)),
            new TeaPair("connectTimeout", com.aliyun.teautil.Common.defaultNumber(runtime.connectTimeout, _connectTimeout)),
            new TeaPair("localAddr", com.aliyun.teautil.Common.defaultString(runtime.localAddr, _localAddr)),
            new TeaPair("httpProxy", com.aliyun.teautil.Common.defaultString(runtime.httpProxy, _httpProxy)),
            new TeaPair("httpsProxy", com.aliyun.teautil.Common.defaultString(runtime.httpsProxy, _httpsProxy)),
            new TeaPair("noProxy", com.aliyun.teautil.Common.defaultString(runtime.noProxy, _noProxy)),
            new TeaPair("socks5Proxy", com.aliyun.teautil.Common.defaultString(runtime.socks5Proxy, _socks5Proxy)),
            new TeaPair("socks5NetWork", com.aliyun.teautil.Common.defaultString(runtime.socks5NetWork, _socks5NetWork)),
            new TeaPair("maxIdleConns", com.aliyun.teautil.Common.defaultNumber(runtime.maxIdleConns, _maxIdleConns)),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", com.aliyun.teautil.Common.defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", com.aliyun.teautil.Common.defaultString(runtime.backoffPolicy, "no")),
                new TeaPair("period", com.aliyun.teautil.Common.defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL)
        );

        TeaRequest _lastRequest = null;
        long _now = System.currentTimeMillis();
        int _retryTimes = 0;
        while (Tea.allowRetry((java.util.Map<String, Object>) runtime_.get("retry"), _retryTimes, _now)) {
            if (_retryTimes > 0) {
                int backoffTime = Tea.getBackoffTime(runtime_.get("backoff"), _retryTimes);
                if (backoffTime > 0) {
                    Tea.sleep(backoffTime);
                }
            }
            _retryTimes = _retryTimes + 1;
            try {
                TeaRequest request_ = new TeaRequest();
                String accessKeyId = _credential.getAccessKeyId();
                String accessKeySecret = _credential.getAccessKeySecret();
                String token = _credential.getSecurityToken();
                String reqBody = com.aliyun.teaxml.Client.toXML(TeaModel.buildMap(request.body));
                request_.protocol = _protocol;
                request_.method = "POST";
                request_.pathname = "/" + request.objectName + "";
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("host", com.aliyun.ossutil.Client.getHost(request.bucketName, _regionId, _endpoint, _hostModel)),
                    new TeaPair("date", com.aliyun.teautil.Common.getDateUTCString()),
                    new TeaPair("user-agent", this.getUserAgent())
                );
                if (!com.aliyun.teautil.Common.empty(token)) {
                    request_.headers.put("x-oss-security-token", token);
                }

                request_.query = com.aliyun.teautil.Common.stringifyMapValue(TeaModel.buildMap(request.filter));
                request_.body = Tea.toReadable(reqBody);
                request_.headers.put("authorization", com.aliyun.ossutil.Client.getSignature(request_, request.bucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                String bodyStr = null;
                if (com.aliyun.teautil.Common.is4xx(response_.statusCode) || com.aliyun.teautil.Common.is5xx(response_.statusCode)) {
                    bodyStr = com.aliyun.teautil.Common.readAsString(response_.body);
                    respMap = com.aliyun.ossutil.Client.getErrMessage(bodyStr);
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("code", respMap.get("Code")),
                        new TeaPair("message", respMap.get("Message")),
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("httpCode", response_.statusCode),
                            new TeaPair("requestId", respMap.get("RequestId")),
                            new TeaPair("hostId", respMap.get("HostId"))
                        ))
                    ));
                }

                bodyStr = com.aliyun.teautil.Common.readAsString(response_.body);
                respMap = com.aliyun.teaxml.Client.parseXml(bodyStr, CompleteMultipartUploadResponse.class);
                return TeaModel.toModel(TeaConverter.merge(Object.class,
                    TeaConverter.buildMap(
                        new TeaPair("CompleteMultipartUploadResult", respMap.get("CompleteMultipartUploadResult"))
                    ),
                    response_.headers
                ), new CompleteMultipartUploadResponse());
            } catch (Exception e) {
                if (Tea.isRetryable(e)) {
                    continue;
                }
                throw e;
            }
        }

        throw new TeaUnretryableException(_lastRequest);
    }

    public PutBucketLoggingResponse putBucketLogging(PutBucketLoggingRequest request, com.aliyun.ossutil.models.RuntimeOptions runtime) throws Exception {
        TeaModel.validateParams(request, "request");
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", com.aliyun.teautil.Common.defaultNumber(runtime.readTimeout, _readTimeout)),
            new TeaPair("connectTimeout", com.aliyun.teautil.Common.defaultNumber(runtime.connectTimeout, _connectTimeout)),
            new TeaPair("localAddr", com.aliyun.teautil.Common.defaultString(runtime.localAddr, _localAddr)),
            new TeaPair("httpProxy", com.aliyun.teautil.Common.defaultString(runtime.httpProxy, _httpProxy)),
            new TeaPair("httpsProxy", com.aliyun.teautil.Common.defaultString(runtime.httpsProxy, _httpsProxy)),
            new TeaPair("noProxy", com.aliyun.teautil.Common.defaultString(runtime.noProxy, _noProxy)),
            new TeaPair("socks5Proxy", com.aliyun.teautil.Common.defaultString(runtime.socks5Proxy, _socks5Proxy)),
            new TeaPair("socks5NetWork", com.aliyun.teautil.Common.defaultString(runtime.socks5NetWork, _socks5NetWork)),
            new TeaPair("maxIdleConns", com.aliyun.teautil.Common.defaultNumber(runtime.maxIdleConns, _maxIdleConns)),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", com.aliyun.teautil.Common.defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", com.aliyun.teautil.Common.defaultString(runtime.backoffPolicy, "no")),
                new TeaPair("period", com.aliyun.teautil.Common.defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL)
        );

        TeaRequest _lastRequest = null;
        long _now = System.currentTimeMillis();
        int _retryTimes = 0;
        while (Tea.allowRetry((java.util.Map<String, Object>) runtime_.get("retry"), _retryTimes, _now)) {
            if (_retryTimes > 0) {
                int backoffTime = Tea.getBackoffTime(runtime_.get("backoff"), _retryTimes);
                if (backoffTime > 0) {
                    Tea.sleep(backoffTime);
                }
            }
            _retryTimes = _retryTimes + 1;
            try {
                TeaRequest request_ = new TeaRequest();
                String accessKeyId = _credential.getAccessKeyId();
                String accessKeySecret = _credential.getAccessKeySecret();
                String token = _credential.getSecurityToken();
                String reqBody = com.aliyun.teaxml.Client.toXML(TeaModel.buildMap(request.body));
                request_.protocol = _protocol;
                request_.method = "PUT";
                request_.pathname = "/?logging";
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("host", com.aliyun.ossutil.Client.getHost(request.bucketName, _regionId, _endpoint, _hostModel)),
                    new TeaPair("date", com.aliyun.teautil.Common.getDateUTCString()),
                    new TeaPair("user-agent", this.getUserAgent())
                );
                if (!com.aliyun.teautil.Common.empty(token)) {
                    request_.headers.put("x-oss-security-token", token);
                }

                request_.body = Tea.toReadable(reqBody);
                request_.headers.put("authorization", com.aliyun.ossutil.Client.getSignature(request_, request.bucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                String bodyStr = null;
                if (com.aliyun.teautil.Common.is4xx(response_.statusCode) || com.aliyun.teautil.Common.is5xx(response_.statusCode)) {
                    bodyStr = com.aliyun.teautil.Common.readAsString(response_.body);
                    respMap = com.aliyun.ossutil.Client.getErrMessage(bodyStr);
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("code", respMap.get("Code")),
                        new TeaPair("message", respMap.get("Message")),
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("httpCode", response_.statusCode),
                            new TeaPair("requestId", respMap.get("RequestId")),
                            new TeaPair("hostId", respMap.get("HostId"))
                        ))
                    ));
                }

                return TeaModel.toModel(TeaConverter.merge(String.class,
                    response_.headers
                ), new PutBucketLoggingResponse());
            } catch (Exception e) {
                if (Tea.isRetryable(e)) {
                    continue;
                }
                throw e;
            }
        }

        throw new TeaUnretryableException(_lastRequest);
    }

    public PutBucketRequestPaymentResponse putBucketRequestPayment(PutBucketRequestPaymentRequest request, com.aliyun.ossutil.models.RuntimeOptions runtime) throws Exception {
        TeaModel.validateParams(request, "request");
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", com.aliyun.teautil.Common.defaultNumber(runtime.readTimeout, _readTimeout)),
            new TeaPair("connectTimeout", com.aliyun.teautil.Common.defaultNumber(runtime.connectTimeout, _connectTimeout)),
            new TeaPair("localAddr", com.aliyun.teautil.Common.defaultString(runtime.localAddr, _localAddr)),
            new TeaPair("httpProxy", com.aliyun.teautil.Common.defaultString(runtime.httpProxy, _httpProxy)),
            new TeaPair("httpsProxy", com.aliyun.teautil.Common.defaultString(runtime.httpsProxy, _httpsProxy)),
            new TeaPair("noProxy", com.aliyun.teautil.Common.defaultString(runtime.noProxy, _noProxy)),
            new TeaPair("socks5Proxy", com.aliyun.teautil.Common.defaultString(runtime.socks5Proxy, _socks5Proxy)),
            new TeaPair("socks5NetWork", com.aliyun.teautil.Common.defaultString(runtime.socks5NetWork, _socks5NetWork)),
            new TeaPair("maxIdleConns", com.aliyun.teautil.Common.defaultNumber(runtime.maxIdleConns, _maxIdleConns)),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", com.aliyun.teautil.Common.defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", com.aliyun.teautil.Common.defaultString(runtime.backoffPolicy, "no")),
                new TeaPair("period", com.aliyun.teautil.Common.defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL)
        );

        TeaRequest _lastRequest = null;
        long _now = System.currentTimeMillis();
        int _retryTimes = 0;
        while (Tea.allowRetry((java.util.Map<String, Object>) runtime_.get("retry"), _retryTimes, _now)) {
            if (_retryTimes > 0) {
                int backoffTime = Tea.getBackoffTime(runtime_.get("backoff"), _retryTimes);
                if (backoffTime > 0) {
                    Tea.sleep(backoffTime);
                }
            }
            _retryTimes = _retryTimes + 1;
            try {
                TeaRequest request_ = new TeaRequest();
                String accessKeyId = _credential.getAccessKeyId();
                String accessKeySecret = _credential.getAccessKeySecret();
                String token = _credential.getSecurityToken();
                String reqBody = com.aliyun.teaxml.Client.toXML(TeaModel.buildMap(request.body));
                request_.protocol = _protocol;
                request_.method = "PUT";
                request_.pathname = "/?requestPayment";
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("host", com.aliyun.ossutil.Client.getHost(request.bucketName, _regionId, _endpoint, _hostModel)),
                    new TeaPair("date", com.aliyun.teautil.Common.getDateUTCString()),
                    new TeaPair("user-agent", this.getUserAgent())
                );
                if (!com.aliyun.teautil.Common.empty(token)) {
                    request_.headers.put("x-oss-security-token", token);
                }

                request_.body = Tea.toReadable(reqBody);
                request_.headers.put("authorization", com.aliyun.ossutil.Client.getSignature(request_, request.bucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                String bodyStr = null;
                if (com.aliyun.teautil.Common.is4xx(response_.statusCode) || com.aliyun.teautil.Common.is5xx(response_.statusCode)) {
                    bodyStr = com.aliyun.teautil.Common.readAsString(response_.body);
                    respMap = com.aliyun.ossutil.Client.getErrMessage(bodyStr);
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("code", respMap.get("Code")),
                        new TeaPair("message", respMap.get("Message")),
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("httpCode", response_.statusCode),
                            new TeaPair("requestId", respMap.get("RequestId")),
                            new TeaPair("hostId", respMap.get("HostId"))
                        ))
                    ));
                }

                return TeaModel.toModel(TeaConverter.merge(String.class,
                    response_.headers
                ), new PutBucketRequestPaymentResponse());
            } catch (Exception e) {
                if (Tea.isRetryable(e)) {
                    continue;
                }
                throw e;
            }
        }

        throw new TeaUnretryableException(_lastRequest);
    }

    public PutBucketEncryptionResponse putBucketEncryption(PutBucketEncryptionRequest request, com.aliyun.ossutil.models.RuntimeOptions runtime) throws Exception {
        TeaModel.validateParams(request, "request");
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", com.aliyun.teautil.Common.defaultNumber(runtime.readTimeout, _readTimeout)),
            new TeaPair("connectTimeout", com.aliyun.teautil.Common.defaultNumber(runtime.connectTimeout, _connectTimeout)),
            new TeaPair("localAddr", com.aliyun.teautil.Common.defaultString(runtime.localAddr, _localAddr)),
            new TeaPair("httpProxy", com.aliyun.teautil.Common.defaultString(runtime.httpProxy, _httpProxy)),
            new TeaPair("httpsProxy", com.aliyun.teautil.Common.defaultString(runtime.httpsProxy, _httpsProxy)),
            new TeaPair("noProxy", com.aliyun.teautil.Common.defaultString(runtime.noProxy, _noProxy)),
            new TeaPair("socks5Proxy", com.aliyun.teautil.Common.defaultString(runtime.socks5Proxy, _socks5Proxy)),
            new TeaPair("socks5NetWork", com.aliyun.teautil.Common.defaultString(runtime.socks5NetWork, _socks5NetWork)),
            new TeaPair("maxIdleConns", com.aliyun.teautil.Common.defaultNumber(runtime.maxIdleConns, _maxIdleConns)),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", com.aliyun.teautil.Common.defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", com.aliyun.teautil.Common.defaultString(runtime.backoffPolicy, "no")),
                new TeaPair("period", com.aliyun.teautil.Common.defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL)
        );

        TeaRequest _lastRequest = null;
        long _now = System.currentTimeMillis();
        int _retryTimes = 0;
        while (Tea.allowRetry((java.util.Map<String, Object>) runtime_.get("retry"), _retryTimes, _now)) {
            if (_retryTimes > 0) {
                int backoffTime = Tea.getBackoffTime(runtime_.get("backoff"), _retryTimes);
                if (backoffTime > 0) {
                    Tea.sleep(backoffTime);
                }
            }
            _retryTimes = _retryTimes + 1;
            try {
                TeaRequest request_ = new TeaRequest();
                String accessKeyId = _credential.getAccessKeyId();
                String accessKeySecret = _credential.getAccessKeySecret();
                String token = _credential.getSecurityToken();
                String reqBody = com.aliyun.teaxml.Client.toXML(TeaModel.buildMap(request.body));
                request_.protocol = _protocol;
                request_.method = "PUT";
                request_.pathname = "/?encryption";
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("host", com.aliyun.ossutil.Client.getHost(request.bucketName, _regionId, _endpoint, _hostModel)),
                    new TeaPair("date", com.aliyun.teautil.Common.getDateUTCString()),
                    new TeaPair("user-agent", this.getUserAgent())
                );
                if (!com.aliyun.teautil.Common.empty(token)) {
                    request_.headers.put("x-oss-security-token", token);
                }

                request_.body = Tea.toReadable(reqBody);
                request_.headers.put("authorization", com.aliyun.ossutil.Client.getSignature(request_, request.bucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                String bodyStr = null;
                if (com.aliyun.teautil.Common.is4xx(response_.statusCode) || com.aliyun.teautil.Common.is5xx(response_.statusCode)) {
                    bodyStr = com.aliyun.teautil.Common.readAsString(response_.body);
                    respMap = com.aliyun.ossutil.Client.getErrMessage(bodyStr);
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("code", respMap.get("Code")),
                        new TeaPair("message", respMap.get("Message")),
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("httpCode", response_.statusCode),
                            new TeaPair("requestId", respMap.get("RequestId")),
                            new TeaPair("hostId", respMap.get("HostId"))
                        ))
                    ));
                }

                return TeaModel.toModel(TeaConverter.merge(String.class,
                    response_.headers
                ), new PutBucketEncryptionResponse());
            } catch (Exception e) {
                if (Tea.isRetryable(e)) {
                    continue;
                }
                throw e;
            }
        }

        throw new TeaUnretryableException(_lastRequest);
    }

    public PutLiveChannelResponse putLiveChannel(PutLiveChannelRequest request, com.aliyun.ossutil.models.RuntimeOptions runtime) throws Exception {
        TeaModel.validateParams(request, "request");
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", com.aliyun.teautil.Common.defaultNumber(runtime.readTimeout, _readTimeout)),
            new TeaPair("connectTimeout", com.aliyun.teautil.Common.defaultNumber(runtime.connectTimeout, _connectTimeout)),
            new TeaPair("localAddr", com.aliyun.teautil.Common.defaultString(runtime.localAddr, _localAddr)),
            new TeaPair("httpProxy", com.aliyun.teautil.Common.defaultString(runtime.httpProxy, _httpProxy)),
            new TeaPair("httpsProxy", com.aliyun.teautil.Common.defaultString(runtime.httpsProxy, _httpsProxy)),
            new TeaPair("noProxy", com.aliyun.teautil.Common.defaultString(runtime.noProxy, _noProxy)),
            new TeaPair("socks5Proxy", com.aliyun.teautil.Common.defaultString(runtime.socks5Proxy, _socks5Proxy)),
            new TeaPair("socks5NetWork", com.aliyun.teautil.Common.defaultString(runtime.socks5NetWork, _socks5NetWork)),
            new TeaPair("maxIdleConns", com.aliyun.teautil.Common.defaultNumber(runtime.maxIdleConns, _maxIdleConns)),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", com.aliyun.teautil.Common.defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", com.aliyun.teautil.Common.defaultString(runtime.backoffPolicy, "no")),
                new TeaPair("period", com.aliyun.teautil.Common.defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL)
        );

        TeaRequest _lastRequest = null;
        long _now = System.currentTimeMillis();
        int _retryTimes = 0;
        while (Tea.allowRetry((java.util.Map<String, Object>) runtime_.get("retry"), _retryTimes, _now)) {
            if (_retryTimes > 0) {
                int backoffTime = Tea.getBackoffTime(runtime_.get("backoff"), _retryTimes);
                if (backoffTime > 0) {
                    Tea.sleep(backoffTime);
                }
            }
            _retryTimes = _retryTimes + 1;
            try {
                TeaRequest request_ = new TeaRequest();
                String accessKeyId = _credential.getAccessKeyId();
                String accessKeySecret = _credential.getAccessKeySecret();
                String token = _credential.getSecurityToken();
                String reqBody = com.aliyun.teaxml.Client.toXML(TeaModel.buildMap(request.body));
                request_.protocol = _protocol;
                request_.method = "PUT";
                request_.pathname = "/" + request.channelName + "?live";
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("host", com.aliyun.ossutil.Client.getHost(request.bucketName, _regionId, _endpoint, _hostModel)),
                    new TeaPair("date", com.aliyun.teautil.Common.getDateUTCString()),
                    new TeaPair("user-agent", this.getUserAgent())
                );
                if (!com.aliyun.teautil.Common.empty(token)) {
                    request_.headers.put("x-oss-security-token", token);
                }

                request_.body = Tea.toReadable(reqBody);
                request_.headers.put("authorization", com.aliyun.ossutil.Client.getSignature(request_, request.bucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                String bodyStr = null;
                if (com.aliyun.teautil.Common.is4xx(response_.statusCode) || com.aliyun.teautil.Common.is5xx(response_.statusCode)) {
                    bodyStr = com.aliyun.teautil.Common.readAsString(response_.body);
                    respMap = com.aliyun.ossutil.Client.getErrMessage(bodyStr);
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("code", respMap.get("Code")),
                        new TeaPair("message", respMap.get("Message")),
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("httpCode", response_.statusCode),
                            new TeaPair("requestId", respMap.get("RequestId")),
                            new TeaPair("hostId", respMap.get("HostId"))
                        ))
                    ));
                }

                bodyStr = com.aliyun.teautil.Common.readAsString(response_.body);
                respMap = com.aliyun.teaxml.Client.parseXml(bodyStr, PutLiveChannelResponse.class);
                return TeaModel.toModel(TeaConverter.merge(Object.class,
                    TeaConverter.buildMap(
                        new TeaPair("CreateLiveChannelResult", respMap.get("CreateLiveChannelResult"))
                    ),
                    response_.headers
                ), new PutLiveChannelResponse());
            } catch (Exception e) {
                if (Tea.isRetryable(e)) {
                    continue;
                }
                throw e;
            }
        }

        throw new TeaUnretryableException(_lastRequest);
    }

    public PutBucketTagsResponse putBucketTags(PutBucketTagsRequest request, com.aliyun.ossutil.models.RuntimeOptions runtime) throws Exception {
        TeaModel.validateParams(request, "request");
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", com.aliyun.teautil.Common.defaultNumber(runtime.readTimeout, _readTimeout)),
            new TeaPair("connectTimeout", com.aliyun.teautil.Common.defaultNumber(runtime.connectTimeout, _connectTimeout)),
            new TeaPair("localAddr", com.aliyun.teautil.Common.defaultString(runtime.localAddr, _localAddr)),
            new TeaPair("httpProxy", com.aliyun.teautil.Common.defaultString(runtime.httpProxy, _httpProxy)),
            new TeaPair("httpsProxy", com.aliyun.teautil.Common.defaultString(runtime.httpsProxy, _httpsProxy)),
            new TeaPair("noProxy", com.aliyun.teautil.Common.defaultString(runtime.noProxy, _noProxy)),
            new TeaPair("socks5Proxy", com.aliyun.teautil.Common.defaultString(runtime.socks5Proxy, _socks5Proxy)),
            new TeaPair("socks5NetWork", com.aliyun.teautil.Common.defaultString(runtime.socks5NetWork, _socks5NetWork)),
            new TeaPair("maxIdleConns", com.aliyun.teautil.Common.defaultNumber(runtime.maxIdleConns, _maxIdleConns)),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", com.aliyun.teautil.Common.defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", com.aliyun.teautil.Common.defaultString(runtime.backoffPolicy, "no")),
                new TeaPair("period", com.aliyun.teautil.Common.defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL)
        );

        TeaRequest _lastRequest = null;
        long _now = System.currentTimeMillis();
        int _retryTimes = 0;
        while (Tea.allowRetry((java.util.Map<String, Object>) runtime_.get("retry"), _retryTimes, _now)) {
            if (_retryTimes > 0) {
                int backoffTime = Tea.getBackoffTime(runtime_.get("backoff"), _retryTimes);
                if (backoffTime > 0) {
                    Tea.sleep(backoffTime);
                }
            }
            _retryTimes = _retryTimes + 1;
            try {
                TeaRequest request_ = new TeaRequest();
                String accessKeyId = _credential.getAccessKeyId();
                String accessKeySecret = _credential.getAccessKeySecret();
                String token = _credential.getSecurityToken();
                String reqBody = com.aliyun.teaxml.Client.toXML(TeaModel.buildMap(request.body));
                request_.protocol = _protocol;
                request_.method = "PUT";
                request_.pathname = "/?tagging";
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("host", com.aliyun.ossutil.Client.getHost(request.bucketName, _regionId, _endpoint, _hostModel)),
                    new TeaPair("date", com.aliyun.teautil.Common.getDateUTCString()),
                    new TeaPair("user-agent", this.getUserAgent())
                );
                if (!com.aliyun.teautil.Common.empty(token)) {
                    request_.headers.put("x-oss-security-token", token);
                }

                request_.body = Tea.toReadable(reqBody);
                request_.headers.put("authorization", com.aliyun.ossutil.Client.getSignature(request_, request.bucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                String bodyStr = null;
                if (com.aliyun.teautil.Common.is4xx(response_.statusCode) || com.aliyun.teautil.Common.is5xx(response_.statusCode)) {
                    bodyStr = com.aliyun.teautil.Common.readAsString(response_.body);
                    respMap = com.aliyun.ossutil.Client.getErrMessage(bodyStr);
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("code", respMap.get("Code")),
                        new TeaPair("message", respMap.get("Message")),
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("httpCode", response_.statusCode),
                            new TeaPair("requestId", respMap.get("RequestId")),
                            new TeaPair("hostId", respMap.get("HostId"))
                        ))
                    ));
                }

                return TeaModel.toModel(TeaConverter.merge(String.class,
                    response_.headers
                ), new PutBucketTagsResponse());
            } catch (Exception e) {
                if (Tea.isRetryable(e)) {
                    continue;
                }
                throw e;
            }
        }

        throw new TeaUnretryableException(_lastRequest);
    }

    public PutObjectTaggingResponse putObjectTagging(PutObjectTaggingRequest request, com.aliyun.ossutil.models.RuntimeOptions runtime) throws Exception {
        TeaModel.validateParams(request, "request");
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", com.aliyun.teautil.Common.defaultNumber(runtime.readTimeout, _readTimeout)),
            new TeaPair("connectTimeout", com.aliyun.teautil.Common.defaultNumber(runtime.connectTimeout, _connectTimeout)),
            new TeaPair("localAddr", com.aliyun.teautil.Common.defaultString(runtime.localAddr, _localAddr)),
            new TeaPair("httpProxy", com.aliyun.teautil.Common.defaultString(runtime.httpProxy, _httpProxy)),
            new TeaPair("httpsProxy", com.aliyun.teautil.Common.defaultString(runtime.httpsProxy, _httpsProxy)),
            new TeaPair("noProxy", com.aliyun.teautil.Common.defaultString(runtime.noProxy, _noProxy)),
            new TeaPair("socks5Proxy", com.aliyun.teautil.Common.defaultString(runtime.socks5Proxy, _socks5Proxy)),
            new TeaPair("socks5NetWork", com.aliyun.teautil.Common.defaultString(runtime.socks5NetWork, _socks5NetWork)),
            new TeaPair("maxIdleConns", com.aliyun.teautil.Common.defaultNumber(runtime.maxIdleConns, _maxIdleConns)),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", com.aliyun.teautil.Common.defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", com.aliyun.teautil.Common.defaultString(runtime.backoffPolicy, "no")),
                new TeaPair("period", com.aliyun.teautil.Common.defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL)
        );

        TeaRequest _lastRequest = null;
        long _now = System.currentTimeMillis();
        int _retryTimes = 0;
        while (Tea.allowRetry((java.util.Map<String, Object>) runtime_.get("retry"), _retryTimes, _now)) {
            if (_retryTimes > 0) {
                int backoffTime = Tea.getBackoffTime(runtime_.get("backoff"), _retryTimes);
                if (backoffTime > 0) {
                    Tea.sleep(backoffTime);
                }
            }
            _retryTimes = _retryTimes + 1;
            try {
                TeaRequest request_ = new TeaRequest();
                String accessKeyId = _credential.getAccessKeyId();
                String accessKeySecret = _credential.getAccessKeySecret();
                String token = _credential.getSecurityToken();
                String reqBody = com.aliyun.teaxml.Client.toXML(TeaModel.buildMap(request.body));
                request_.protocol = _protocol;
                request_.method = "PUT";
                request_.pathname = "/" + request.objectName + "?tagging";
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("host", com.aliyun.ossutil.Client.getHost(request.bucketName, _regionId, _endpoint, _hostModel)),
                    new TeaPair("date", com.aliyun.teautil.Common.getDateUTCString()),
                    new TeaPair("user-agent", this.getUserAgent())
                );
                if (!com.aliyun.teautil.Common.empty(token)) {
                    request_.headers.put("x-oss-security-token", token);
                }

                request_.body = Tea.toReadable(reqBody);
                request_.headers.put("authorization", com.aliyun.ossutil.Client.getSignature(request_, request.bucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                String bodyStr = null;
                if (com.aliyun.teautil.Common.is4xx(response_.statusCode) || com.aliyun.teautil.Common.is5xx(response_.statusCode)) {
                    bodyStr = com.aliyun.teautil.Common.readAsString(response_.body);
                    respMap = com.aliyun.ossutil.Client.getErrMessage(bodyStr);
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("code", respMap.get("Code")),
                        new TeaPair("message", respMap.get("Message")),
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("httpCode", response_.statusCode),
                            new TeaPair("requestId", respMap.get("RequestId")),
                            new TeaPair("hostId", respMap.get("HostId"))
                        ))
                    ));
                }

                return TeaModel.toModel(TeaConverter.merge(String.class,
                    response_.headers
                ), new PutObjectTaggingResponse());
            } catch (Exception e) {
                if (Tea.isRetryable(e)) {
                    continue;
                }
                throw e;
            }
        }

        throw new TeaUnretryableException(_lastRequest);
    }

    public SelectObjectResponse selectObject(SelectObjectRequest request, com.aliyun.ossutil.models.RuntimeOptions runtime) throws Exception {
        TeaModel.validateParams(request, "request");
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", com.aliyun.teautil.Common.defaultNumber(runtime.readTimeout, _readTimeout)),
            new TeaPair("connectTimeout", com.aliyun.teautil.Common.defaultNumber(runtime.connectTimeout, _connectTimeout)),
            new TeaPair("localAddr", com.aliyun.teautil.Common.defaultString(runtime.localAddr, _localAddr)),
            new TeaPair("httpProxy", com.aliyun.teautil.Common.defaultString(runtime.httpProxy, _httpProxy)),
            new TeaPair("httpsProxy", com.aliyun.teautil.Common.defaultString(runtime.httpsProxy, _httpsProxy)),
            new TeaPair("noProxy", com.aliyun.teautil.Common.defaultString(runtime.noProxy, _noProxy)),
            new TeaPair("socks5Proxy", com.aliyun.teautil.Common.defaultString(runtime.socks5Proxy, _socks5Proxy)),
            new TeaPair("socks5NetWork", com.aliyun.teautil.Common.defaultString(runtime.socks5NetWork, _socks5NetWork)),
            new TeaPair("maxIdleConns", com.aliyun.teautil.Common.defaultNumber(runtime.maxIdleConns, _maxIdleConns)),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", com.aliyun.teautil.Common.defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", com.aliyun.teautil.Common.defaultString(runtime.backoffPolicy, "no")),
                new TeaPair("period", com.aliyun.teautil.Common.defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL)
        );

        TeaRequest _lastRequest = null;
        long _now = System.currentTimeMillis();
        int _retryTimes = 0;
        while (Tea.allowRetry((java.util.Map<String, Object>) runtime_.get("retry"), _retryTimes, _now)) {
            if (_retryTimes > 0) {
                int backoffTime = Tea.getBackoffTime(runtime_.get("backoff"), _retryTimes);
                if (backoffTime > 0) {
                    Tea.sleep(backoffTime);
                }
            }
            _retryTimes = _retryTimes + 1;
            try {
                TeaRequest request_ = new TeaRequest();
                String accessKeyId = _credential.getAccessKeyId();
                String accessKeySecret = _credential.getAccessKeySecret();
                String token = _credential.getSecurityToken();
                String reqBody = com.aliyun.teaxml.Client.toXML(TeaModel.buildMap(request.body));
                request_.protocol = _protocol;
                request_.method = "POST";
                request_.pathname = "/" + request.objectName + "";
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("host", com.aliyun.ossutil.Client.getHost(request.bucketName, _regionId, _endpoint, _hostModel)),
                    new TeaPair("date", com.aliyun.teautil.Common.getDateUTCString()),
                    new TeaPair("user-agent", this.getUserAgent())
                );
                if (!com.aliyun.teautil.Common.empty(token)) {
                    request_.headers.put("x-oss-security-token", token);
                }

                request_.query = com.aliyun.teautil.Common.stringifyMapValue(TeaModel.buildMap(request.filter));
                request_.body = Tea.toReadable(reqBody);
                request_.headers.put("authorization", com.aliyun.ossutil.Client.getSignature(request_, request.bucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                String bodyStr = null;
                if (com.aliyun.teautil.Common.is4xx(response_.statusCode) || com.aliyun.teautil.Common.is5xx(response_.statusCode)) {
                    bodyStr = com.aliyun.teautil.Common.readAsString(response_.body);
                    respMap = com.aliyun.ossutil.Client.getErrMessage(bodyStr);
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("code", respMap.get("Code")),
                        new TeaPair("message", respMap.get("Message")),
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("httpCode", response_.statusCode),
                            new TeaPair("requestId", respMap.get("RequestId")),
                            new TeaPair("hostId", respMap.get("HostId"))
                        ))
                    ));
                }

                return TeaModel.toModel(TeaConverter.merge(String.class,
                    response_.headers
                ), new SelectObjectResponse());
            } catch (Exception e) {
                if (Tea.isRetryable(e)) {
                    continue;
                }
                throw e;
            }
        }

        throw new TeaUnretryableException(_lastRequest);
    }

    public PutBucketCORSResponse putBucketCORS(PutBucketCORSRequest request, com.aliyun.ossutil.models.RuntimeOptions runtime) throws Exception {
        TeaModel.validateParams(request, "request");
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", com.aliyun.teautil.Common.defaultNumber(runtime.readTimeout, _readTimeout)),
            new TeaPair("connectTimeout", com.aliyun.teautil.Common.defaultNumber(runtime.connectTimeout, _connectTimeout)),
            new TeaPair("localAddr", com.aliyun.teautil.Common.defaultString(runtime.localAddr, _localAddr)),
            new TeaPair("httpProxy", com.aliyun.teautil.Common.defaultString(runtime.httpProxy, _httpProxy)),
            new TeaPair("httpsProxy", com.aliyun.teautil.Common.defaultString(runtime.httpsProxy, _httpsProxy)),
            new TeaPair("noProxy", com.aliyun.teautil.Common.defaultString(runtime.noProxy, _noProxy)),
            new TeaPair("socks5Proxy", com.aliyun.teautil.Common.defaultString(runtime.socks5Proxy, _socks5Proxy)),
            new TeaPair("socks5NetWork", com.aliyun.teautil.Common.defaultString(runtime.socks5NetWork, _socks5NetWork)),
            new TeaPair("maxIdleConns", com.aliyun.teautil.Common.defaultNumber(runtime.maxIdleConns, _maxIdleConns)),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", com.aliyun.teautil.Common.defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", com.aliyun.teautil.Common.defaultString(runtime.backoffPolicy, "no")),
                new TeaPair("period", com.aliyun.teautil.Common.defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL)
        );

        TeaRequest _lastRequest = null;
        long _now = System.currentTimeMillis();
        int _retryTimes = 0;
        while (Tea.allowRetry((java.util.Map<String, Object>) runtime_.get("retry"), _retryTimes, _now)) {
            if (_retryTimes > 0) {
                int backoffTime = Tea.getBackoffTime(runtime_.get("backoff"), _retryTimes);
                if (backoffTime > 0) {
                    Tea.sleep(backoffTime);
                }
            }
            _retryTimes = _retryTimes + 1;
            try {
                TeaRequest request_ = new TeaRequest();
                String accessKeyId = _credential.getAccessKeyId();
                String accessKeySecret = _credential.getAccessKeySecret();
                String token = _credential.getSecurityToken();
                String reqBody = com.aliyun.teaxml.Client.toXML(TeaModel.buildMap(request.body));
                request_.protocol = _protocol;
                request_.method = "PUT";
                request_.pathname = "/?cors";
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("host", com.aliyun.ossutil.Client.getHost(request.bucketName, _regionId, _endpoint, _hostModel)),
                    new TeaPair("date", com.aliyun.teautil.Common.getDateUTCString()),
                    new TeaPair("user-agent", this.getUserAgent())
                );
                if (!com.aliyun.teautil.Common.empty(token)) {
                    request_.headers.put("x-oss-security-token", token);
                }

                request_.body = Tea.toReadable(reqBody);
                request_.headers.put("authorization", com.aliyun.ossutil.Client.getSignature(request_, request.bucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                String bodyStr = null;
                if (com.aliyun.teautil.Common.is4xx(response_.statusCode) || com.aliyun.teautil.Common.is5xx(response_.statusCode)) {
                    bodyStr = com.aliyun.teautil.Common.readAsString(response_.body);
                    respMap = com.aliyun.ossutil.Client.getErrMessage(bodyStr);
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("code", respMap.get("Code")),
                        new TeaPair("message", respMap.get("Message")),
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("httpCode", response_.statusCode),
                            new TeaPair("requestId", respMap.get("RequestId")),
                            new TeaPair("hostId", respMap.get("HostId"))
                        ))
                    ));
                }

                return TeaModel.toModel(TeaConverter.merge(String.class,
                    response_.headers
                ), new PutBucketCORSResponse());
            } catch (Exception e) {
                if (Tea.isRetryable(e)) {
                    continue;
                }
                throw e;
            }
        }

        throw new TeaUnretryableException(_lastRequest);
    }

    public PutBucketResponse putBucket(PutBucketRequest request, com.aliyun.ossutil.models.RuntimeOptions runtime) throws Exception {
        TeaModel.validateParams(request, "request");
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", com.aliyun.teautil.Common.defaultNumber(runtime.readTimeout, _readTimeout)),
            new TeaPair("connectTimeout", com.aliyun.teautil.Common.defaultNumber(runtime.connectTimeout, _connectTimeout)),
            new TeaPair("localAddr", com.aliyun.teautil.Common.defaultString(runtime.localAddr, _localAddr)),
            new TeaPair("httpProxy", com.aliyun.teautil.Common.defaultString(runtime.httpProxy, _httpProxy)),
            new TeaPair("httpsProxy", com.aliyun.teautil.Common.defaultString(runtime.httpsProxy, _httpsProxy)),
            new TeaPair("noProxy", com.aliyun.teautil.Common.defaultString(runtime.noProxy, _noProxy)),
            new TeaPair("socks5Proxy", com.aliyun.teautil.Common.defaultString(runtime.socks5Proxy, _socks5Proxy)),
            new TeaPair("socks5NetWork", com.aliyun.teautil.Common.defaultString(runtime.socks5NetWork, _socks5NetWork)),
            new TeaPair("maxIdleConns", com.aliyun.teautil.Common.defaultNumber(runtime.maxIdleConns, _maxIdleConns)),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", com.aliyun.teautil.Common.defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", com.aliyun.teautil.Common.defaultString(runtime.backoffPolicy, "no")),
                new TeaPair("period", com.aliyun.teautil.Common.defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL)
        );

        TeaRequest _lastRequest = null;
        long _now = System.currentTimeMillis();
        int _retryTimes = 0;
        while (Tea.allowRetry((java.util.Map<String, Object>) runtime_.get("retry"), _retryTimes, _now)) {
            if (_retryTimes > 0) {
                int backoffTime = Tea.getBackoffTime(runtime_.get("backoff"), _retryTimes);
                if (backoffTime > 0) {
                    Tea.sleep(backoffTime);
                }
            }
            _retryTimes = _retryTimes + 1;
            try {
                TeaRequest request_ = new TeaRequest();
                String accessKeyId = _credential.getAccessKeyId();
                String accessKeySecret = _credential.getAccessKeySecret();
                String token = _credential.getSecurityToken();
                String reqBody = com.aliyun.teaxml.Client.toXML(TeaModel.buildMap(request.body));
                request_.protocol = _protocol;
                request_.method = "PUT";
                request_.pathname = "/";
                request_.headers = TeaConverter.merge(String.class,
                    TeaConverter.buildMap(
                        new TeaPair("host", com.aliyun.ossutil.Client.getHost(request.bucketName, _regionId, _endpoint, _hostModel)),
                        new TeaPair("date", com.aliyun.teautil.Common.getDateUTCString()),
                        new TeaPair("user-agent", this.getUserAgent())
                    ),
                    com.aliyun.teautil.Common.stringifyMapValue(TeaModel.buildMap(request.header))
                );
                if (!com.aliyun.teautil.Common.empty(token)) {
                    request_.headers.put("x-oss-security-token", token);
                }

                request_.body = Tea.toReadable(reqBody);
                request_.headers.put("authorization", com.aliyun.ossutil.Client.getSignature(request_, request.bucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                String bodyStr = null;
                if (com.aliyun.teautil.Common.is4xx(response_.statusCode) || com.aliyun.teautil.Common.is5xx(response_.statusCode)) {
                    bodyStr = com.aliyun.teautil.Common.readAsString(response_.body);
                    respMap = com.aliyun.ossutil.Client.getErrMessage(bodyStr);
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("code", respMap.get("Code")),
                        new TeaPair("message", respMap.get("Message")),
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("httpCode", response_.statusCode),
                            new TeaPair("requestId", respMap.get("RequestId")),
                            new TeaPair("hostId", respMap.get("HostId"))
                        ))
                    ));
                }

                return TeaModel.toModel(TeaConverter.merge(String.class,
                    response_.headers
                ), new PutBucketResponse());
            } catch (Exception e) {
                if (Tea.isRetryable(e)) {
                    continue;
                }
                throw e;
            }
        }

        throw new TeaUnretryableException(_lastRequest);
    }

    public ListMultipartUploadsResponse listMultipartUploads(ListMultipartUploadsRequest request, com.aliyun.ossutil.models.RuntimeOptions runtime) throws Exception {
        TeaModel.validateParams(request, "request");
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", com.aliyun.teautil.Common.defaultNumber(runtime.readTimeout, _readTimeout)),
            new TeaPair("connectTimeout", com.aliyun.teautil.Common.defaultNumber(runtime.connectTimeout, _connectTimeout)),
            new TeaPair("localAddr", com.aliyun.teautil.Common.defaultString(runtime.localAddr, _localAddr)),
            new TeaPair("httpProxy", com.aliyun.teautil.Common.defaultString(runtime.httpProxy, _httpProxy)),
            new TeaPair("httpsProxy", com.aliyun.teautil.Common.defaultString(runtime.httpsProxy, _httpsProxy)),
            new TeaPair("noProxy", com.aliyun.teautil.Common.defaultString(runtime.noProxy, _noProxy)),
            new TeaPair("socks5Proxy", com.aliyun.teautil.Common.defaultString(runtime.socks5Proxy, _socks5Proxy)),
            new TeaPair("socks5NetWork", com.aliyun.teautil.Common.defaultString(runtime.socks5NetWork, _socks5NetWork)),
            new TeaPair("maxIdleConns", com.aliyun.teautil.Common.defaultNumber(runtime.maxIdleConns, _maxIdleConns)),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", com.aliyun.teautil.Common.defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", com.aliyun.teautil.Common.defaultString(runtime.backoffPolicy, "no")),
                new TeaPair("period", com.aliyun.teautil.Common.defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL)
        );

        TeaRequest _lastRequest = null;
        long _now = System.currentTimeMillis();
        int _retryTimes = 0;
        while (Tea.allowRetry((java.util.Map<String, Object>) runtime_.get("retry"), _retryTimes, _now)) {
            if (_retryTimes > 0) {
                int backoffTime = Tea.getBackoffTime(runtime_.get("backoff"), _retryTimes);
                if (backoffTime > 0) {
                    Tea.sleep(backoffTime);
                }
            }
            _retryTimes = _retryTimes + 1;
            try {
                TeaRequest request_ = new TeaRequest();
                String accessKeyId = _credential.getAccessKeyId();
                String accessKeySecret = _credential.getAccessKeySecret();
                String token = _credential.getSecurityToken();
                request_.protocol = _protocol;
                request_.method = "GET";
                request_.pathname = "/?uploads";
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("host", com.aliyun.ossutil.Client.getHost(request.bucketName, _regionId, _endpoint, _hostModel)),
                    new TeaPair("date", com.aliyun.teautil.Common.getDateUTCString()),
                    new TeaPair("user-agent", this.getUserAgent())
                );
                if (!com.aliyun.teautil.Common.empty(token)) {
                    request_.headers.put("x-oss-security-token", token);
                }

                request_.query = com.aliyun.teautil.Common.stringifyMapValue(TeaModel.buildMap(request.filter));
                request_.headers.put("authorization", com.aliyun.ossutil.Client.getSignature(request_, request.bucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                String bodyStr = null;
                if (com.aliyun.teautil.Common.is4xx(response_.statusCode) || com.aliyun.teautil.Common.is5xx(response_.statusCode)) {
                    bodyStr = com.aliyun.teautil.Common.readAsString(response_.body);
                    respMap = com.aliyun.ossutil.Client.getErrMessage(bodyStr);
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("code", respMap.get("Code")),
                        new TeaPair("message", respMap.get("Message")),
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("httpCode", response_.statusCode),
                            new TeaPair("requestId", respMap.get("RequestId")),
                            new TeaPair("hostId", respMap.get("HostId"))
                        ))
                    ));
                }

                bodyStr = com.aliyun.teautil.Common.readAsString(response_.body);
                respMap = com.aliyun.teaxml.Client.parseXml(bodyStr, ListMultipartUploadsResponse.class);
                return TeaModel.toModel(TeaConverter.merge(Object.class,
                    TeaConverter.buildMap(
                        new TeaPair("ListMultipartUploadsResult", respMap.get("ListMultipartUploadsResult"))
                    ),
                    response_.headers
                ), new ListMultipartUploadsResponse());
            } catch (Exception e) {
                if (Tea.isRetryable(e)) {
                    continue;
                }
                throw e;
            }
        }

        throw new TeaUnretryableException(_lastRequest);
    }

    public GetBucketRequestPaymentResponse getBucketRequestPayment(GetBucketRequestPaymentRequest request, com.aliyun.ossutil.models.RuntimeOptions runtime) throws Exception {
        TeaModel.validateParams(request, "request");
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", com.aliyun.teautil.Common.defaultNumber(runtime.readTimeout, _readTimeout)),
            new TeaPair("connectTimeout", com.aliyun.teautil.Common.defaultNumber(runtime.connectTimeout, _connectTimeout)),
            new TeaPair("localAddr", com.aliyun.teautil.Common.defaultString(runtime.localAddr, _localAddr)),
            new TeaPair("httpProxy", com.aliyun.teautil.Common.defaultString(runtime.httpProxy, _httpProxy)),
            new TeaPair("httpsProxy", com.aliyun.teautil.Common.defaultString(runtime.httpsProxy, _httpsProxy)),
            new TeaPair("noProxy", com.aliyun.teautil.Common.defaultString(runtime.noProxy, _noProxy)),
            new TeaPair("socks5Proxy", com.aliyun.teautil.Common.defaultString(runtime.socks5Proxy, _socks5Proxy)),
            new TeaPair("socks5NetWork", com.aliyun.teautil.Common.defaultString(runtime.socks5NetWork, _socks5NetWork)),
            new TeaPair("maxIdleConns", com.aliyun.teautil.Common.defaultNumber(runtime.maxIdleConns, _maxIdleConns)),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", com.aliyun.teautil.Common.defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", com.aliyun.teautil.Common.defaultString(runtime.backoffPolicy, "no")),
                new TeaPair("period", com.aliyun.teautil.Common.defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL)
        );

        TeaRequest _lastRequest = null;
        long _now = System.currentTimeMillis();
        int _retryTimes = 0;
        while (Tea.allowRetry((java.util.Map<String, Object>) runtime_.get("retry"), _retryTimes, _now)) {
            if (_retryTimes > 0) {
                int backoffTime = Tea.getBackoffTime(runtime_.get("backoff"), _retryTimes);
                if (backoffTime > 0) {
                    Tea.sleep(backoffTime);
                }
            }
            _retryTimes = _retryTimes + 1;
            try {
                TeaRequest request_ = new TeaRequest();
                String accessKeyId = _credential.getAccessKeyId();
                String accessKeySecret = _credential.getAccessKeySecret();
                String token = _credential.getSecurityToken();
                request_.protocol = _protocol;
                request_.method = "GET";
                request_.pathname = "/?requestPayment";
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("host", com.aliyun.ossutil.Client.getHost(request.bucketName, _regionId, _endpoint, _hostModel)),
                    new TeaPair("date", com.aliyun.teautil.Common.getDateUTCString()),
                    new TeaPair("user-agent", this.getUserAgent())
                );
                if (!com.aliyun.teautil.Common.empty(token)) {
                    request_.headers.put("x-oss-security-token", token);
                }

                request_.headers.put("authorization", com.aliyun.ossutil.Client.getSignature(request_, request.bucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                String bodyStr = null;
                if (com.aliyun.teautil.Common.is4xx(response_.statusCode) || com.aliyun.teautil.Common.is5xx(response_.statusCode)) {
                    bodyStr = com.aliyun.teautil.Common.readAsString(response_.body);
                    respMap = com.aliyun.ossutil.Client.getErrMessage(bodyStr);
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("code", respMap.get("Code")),
                        new TeaPair("message", respMap.get("Message")),
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("httpCode", response_.statusCode),
                            new TeaPair("requestId", respMap.get("RequestId")),
                            new TeaPair("hostId", respMap.get("HostId"))
                        ))
                    ));
                }

                bodyStr = com.aliyun.teautil.Common.readAsString(response_.body);
                respMap = com.aliyun.teaxml.Client.parseXml(bodyStr, GetBucketRequestPaymentResponse.class);
                return TeaModel.toModel(TeaConverter.merge(Object.class,
                    TeaConverter.buildMap(
                        new TeaPair("RequestPaymentConfiguration", respMap.get("RequestPaymentConfiguration"))
                    ),
                    response_.headers
                ), new GetBucketRequestPaymentResponse());
            } catch (Exception e) {
                if (Tea.isRetryable(e)) {
                    continue;
                }
                throw e;
            }
        }

        throw new TeaUnretryableException(_lastRequest);
    }

    public GetBucketEncryptionResponse getBucketEncryption(GetBucketEncryptionRequest request, com.aliyun.ossutil.models.RuntimeOptions runtime) throws Exception {
        TeaModel.validateParams(request, "request");
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", com.aliyun.teautil.Common.defaultNumber(runtime.readTimeout, _readTimeout)),
            new TeaPair("connectTimeout", com.aliyun.teautil.Common.defaultNumber(runtime.connectTimeout, _connectTimeout)),
            new TeaPair("localAddr", com.aliyun.teautil.Common.defaultString(runtime.localAddr, _localAddr)),
            new TeaPair("httpProxy", com.aliyun.teautil.Common.defaultString(runtime.httpProxy, _httpProxy)),
            new TeaPair("httpsProxy", com.aliyun.teautil.Common.defaultString(runtime.httpsProxy, _httpsProxy)),
            new TeaPair("noProxy", com.aliyun.teautil.Common.defaultString(runtime.noProxy, _noProxy)),
            new TeaPair("socks5Proxy", com.aliyun.teautil.Common.defaultString(runtime.socks5Proxy, _socks5Proxy)),
            new TeaPair("socks5NetWork", com.aliyun.teautil.Common.defaultString(runtime.socks5NetWork, _socks5NetWork)),
            new TeaPair("maxIdleConns", com.aliyun.teautil.Common.defaultNumber(runtime.maxIdleConns, _maxIdleConns)),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", com.aliyun.teautil.Common.defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", com.aliyun.teautil.Common.defaultString(runtime.backoffPolicy, "no")),
                new TeaPair("period", com.aliyun.teautil.Common.defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL)
        );

        TeaRequest _lastRequest = null;
        long _now = System.currentTimeMillis();
        int _retryTimes = 0;
        while (Tea.allowRetry((java.util.Map<String, Object>) runtime_.get("retry"), _retryTimes, _now)) {
            if (_retryTimes > 0) {
                int backoffTime = Tea.getBackoffTime(runtime_.get("backoff"), _retryTimes);
                if (backoffTime > 0) {
                    Tea.sleep(backoffTime);
                }
            }
            _retryTimes = _retryTimes + 1;
            try {
                TeaRequest request_ = new TeaRequest();
                String accessKeyId = _credential.getAccessKeyId();
                String accessKeySecret = _credential.getAccessKeySecret();
                String token = _credential.getSecurityToken();
                request_.protocol = _protocol;
                request_.method = "GET";
                request_.pathname = "/?encryption";
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("host", com.aliyun.ossutil.Client.getHost(request.bucketName, _regionId, _endpoint, _hostModel)),
                    new TeaPair("date", com.aliyun.teautil.Common.getDateUTCString()),
                    new TeaPair("user-agent", this.getUserAgent())
                );
                if (!com.aliyun.teautil.Common.empty(token)) {
                    request_.headers.put("x-oss-security-token", token);
                }

                request_.headers.put("authorization", com.aliyun.ossutil.Client.getSignature(request_, request.bucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                String bodyStr = null;
                if (com.aliyun.teautil.Common.is4xx(response_.statusCode) || com.aliyun.teautil.Common.is5xx(response_.statusCode)) {
                    bodyStr = com.aliyun.teautil.Common.readAsString(response_.body);
                    respMap = com.aliyun.ossutil.Client.getErrMessage(bodyStr);
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("code", respMap.get("Code")),
                        new TeaPair("message", respMap.get("Message")),
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("httpCode", response_.statusCode),
                            new TeaPair("requestId", respMap.get("RequestId")),
                            new TeaPair("hostId", respMap.get("HostId"))
                        ))
                    ));
                }

                bodyStr = com.aliyun.teautil.Common.readAsString(response_.body);
                respMap = com.aliyun.teaxml.Client.parseXml(bodyStr, GetBucketEncryptionResponse.class);
                return TeaModel.toModel(TeaConverter.merge(Object.class,
                    TeaConverter.buildMap(
                        new TeaPair("ServerSideEncryptionRule", respMap.get("ServerSideEncryptionRule"))
                    ),
                    response_.headers
                ), new GetBucketEncryptionResponse());
            } catch (Exception e) {
                if (Tea.isRetryable(e)) {
                    continue;
                }
                throw e;
            }
        }

        throw new TeaUnretryableException(_lastRequest);
    }

    public GetBucketTagsResponse getBucketTags(GetBucketTagsRequest request, com.aliyun.ossutil.models.RuntimeOptions runtime) throws Exception {
        TeaModel.validateParams(request, "request");
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", com.aliyun.teautil.Common.defaultNumber(runtime.readTimeout, _readTimeout)),
            new TeaPair("connectTimeout", com.aliyun.teautil.Common.defaultNumber(runtime.connectTimeout, _connectTimeout)),
            new TeaPair("localAddr", com.aliyun.teautil.Common.defaultString(runtime.localAddr, _localAddr)),
            new TeaPair("httpProxy", com.aliyun.teautil.Common.defaultString(runtime.httpProxy, _httpProxy)),
            new TeaPair("httpsProxy", com.aliyun.teautil.Common.defaultString(runtime.httpsProxy, _httpsProxy)),
            new TeaPair("noProxy", com.aliyun.teautil.Common.defaultString(runtime.noProxy, _noProxy)),
            new TeaPair("socks5Proxy", com.aliyun.teautil.Common.defaultString(runtime.socks5Proxy, _socks5Proxy)),
            new TeaPair("socks5NetWork", com.aliyun.teautil.Common.defaultString(runtime.socks5NetWork, _socks5NetWork)),
            new TeaPair("maxIdleConns", com.aliyun.teautil.Common.defaultNumber(runtime.maxIdleConns, _maxIdleConns)),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", com.aliyun.teautil.Common.defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", com.aliyun.teautil.Common.defaultString(runtime.backoffPolicy, "no")),
                new TeaPair("period", com.aliyun.teautil.Common.defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL)
        );

        TeaRequest _lastRequest = null;
        long _now = System.currentTimeMillis();
        int _retryTimes = 0;
        while (Tea.allowRetry((java.util.Map<String, Object>) runtime_.get("retry"), _retryTimes, _now)) {
            if (_retryTimes > 0) {
                int backoffTime = Tea.getBackoffTime(runtime_.get("backoff"), _retryTimes);
                if (backoffTime > 0) {
                    Tea.sleep(backoffTime);
                }
            }
            _retryTimes = _retryTimes + 1;
            try {
                TeaRequest request_ = new TeaRequest();
                String accessKeyId = _credential.getAccessKeyId();
                String accessKeySecret = _credential.getAccessKeySecret();
                String token = _credential.getSecurityToken();
                request_.protocol = _protocol;
                request_.method = "GET";
                request_.pathname = "/?tagging";
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("host", com.aliyun.ossutil.Client.getHost(request.bucketName, _regionId, _endpoint, _hostModel)),
                    new TeaPair("date", com.aliyun.teautil.Common.getDateUTCString()),
                    new TeaPair("user-agent", this.getUserAgent())
                );
                if (!com.aliyun.teautil.Common.empty(token)) {
                    request_.headers.put("x-oss-security-token", token);
                }

                request_.headers.put("authorization", com.aliyun.ossutil.Client.getSignature(request_, request.bucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                String bodyStr = null;
                if (com.aliyun.teautil.Common.is4xx(response_.statusCode) || com.aliyun.teautil.Common.is5xx(response_.statusCode)) {
                    bodyStr = com.aliyun.teautil.Common.readAsString(response_.body);
                    respMap = com.aliyun.ossutil.Client.getErrMessage(bodyStr);
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("code", respMap.get("Code")),
                        new TeaPair("message", respMap.get("Message")),
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("httpCode", response_.statusCode),
                            new TeaPair("requestId", respMap.get("RequestId")),
                            new TeaPair("hostId", respMap.get("HostId"))
                        ))
                    ));
                }

                bodyStr = com.aliyun.teautil.Common.readAsString(response_.body);
                respMap = com.aliyun.teaxml.Client.parseXml(bodyStr, GetBucketTagsResponse.class);
                return TeaModel.toModel(TeaConverter.merge(Object.class,
                    TeaConverter.buildMap(
                        new TeaPair("Tagging", respMap.get("Tagging"))
                    ),
                    response_.headers
                ), new GetBucketTagsResponse());
            } catch (Exception e) {
                if (Tea.isRetryable(e)) {
                    continue;
                }
                throw e;
            }
        }

        throw new TeaUnretryableException(_lastRequest);
    }

    public GetServiceResponse getService(GetServiceRequest request, com.aliyun.ossutil.models.RuntimeOptions runtime) throws Exception {
        TeaModel.validateParams(request, "request");
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", com.aliyun.teautil.Common.defaultNumber(runtime.readTimeout, _readTimeout)),
            new TeaPair("connectTimeout", com.aliyun.teautil.Common.defaultNumber(runtime.connectTimeout, _connectTimeout)),
            new TeaPair("localAddr", com.aliyun.teautil.Common.defaultString(runtime.localAddr, _localAddr)),
            new TeaPair("httpProxy", com.aliyun.teautil.Common.defaultString(runtime.httpProxy, _httpProxy)),
            new TeaPair("httpsProxy", com.aliyun.teautil.Common.defaultString(runtime.httpsProxy, _httpsProxy)),
            new TeaPair("noProxy", com.aliyun.teautil.Common.defaultString(runtime.noProxy, _noProxy)),
            new TeaPair("socks5Proxy", com.aliyun.teautil.Common.defaultString(runtime.socks5Proxy, _socks5Proxy)),
            new TeaPair("socks5NetWork", com.aliyun.teautil.Common.defaultString(runtime.socks5NetWork, _socks5NetWork)),
            new TeaPair("maxIdleConns", com.aliyun.teautil.Common.defaultNumber(runtime.maxIdleConns, _maxIdleConns)),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", com.aliyun.teautil.Common.defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", com.aliyun.teautil.Common.defaultString(runtime.backoffPolicy, "no")),
                new TeaPair("period", com.aliyun.teautil.Common.defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL)
        );

        TeaRequest _lastRequest = null;
        long _now = System.currentTimeMillis();
        int _retryTimes = 0;
        while (Tea.allowRetry((java.util.Map<String, Object>) runtime_.get("retry"), _retryTimes, _now)) {
            if (_retryTimes > 0) {
                int backoffTime = Tea.getBackoffTime(runtime_.get("backoff"), _retryTimes);
                if (backoffTime > 0) {
                    Tea.sleep(backoffTime);
                }
            }
            _retryTimes = _retryTimes + 1;
            try {
                TeaRequest request_ = new TeaRequest();
                String accessKeyId = _credential.getAccessKeyId();
                String accessKeySecret = _credential.getAccessKeySecret();
                String token = _credential.getSecurityToken();
                request_.protocol = _protocol;
                request_.method = "GET";
                request_.pathname = "/";
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("host", com.aliyun.ossutil.Client.getHost("", _regionId, _endpoint, _hostModel)),
                    new TeaPair("date", com.aliyun.teautil.Common.getDateUTCString()),
                    new TeaPair("user-agent", this.getUserAgent())
                );
                if (!com.aliyun.teautil.Common.empty(token)) {
                    request_.headers.put("x-oss-security-token", token);
                }

                request_.query = com.aliyun.teautil.Common.stringifyMapValue(TeaModel.buildMap(request.filter));
                request_.headers.put("authorization", com.aliyun.ossutil.Client.getSignature(request_, "", accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                String bodyStr = null;
                if (com.aliyun.teautil.Common.is4xx(response_.statusCode) || com.aliyun.teautil.Common.is5xx(response_.statusCode)) {
                    bodyStr = com.aliyun.teautil.Common.readAsString(response_.body);
                    respMap = com.aliyun.ossutil.Client.getErrMessage(bodyStr);
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("code", respMap.get("Code")),
                        new TeaPair("message", respMap.get("Message")),
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("httpCode", response_.statusCode),
                            new TeaPair("requestId", respMap.get("RequestId")),
                            new TeaPair("hostId", respMap.get("HostId"))
                        ))
                    ));
                }

                bodyStr = com.aliyun.teautil.Common.readAsString(response_.body);
                respMap = com.aliyun.teaxml.Client.parseXml(bodyStr, GetServiceResponse.class);
                return TeaModel.toModel(TeaConverter.merge(Object.class,
                    TeaConverter.buildMap(
                        new TeaPair("ListAllMyBucketsResult", respMap.get("ListAllMyBucketsResult"))
                    ),
                    response_.headers
                ), new GetServiceResponse());
            } catch (Exception e) {
                if (Tea.isRetryable(e)) {
                    continue;
                }
                throw e;
            }
        }

        throw new TeaUnretryableException(_lastRequest);
    }

    public DeleteBucketEncryptionResponse deleteBucketEncryption(DeleteBucketEncryptionRequest request, com.aliyun.ossutil.models.RuntimeOptions runtime) throws Exception {
        TeaModel.validateParams(request, "request");
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", com.aliyun.teautil.Common.defaultNumber(runtime.readTimeout, _readTimeout)),
            new TeaPair("connectTimeout", com.aliyun.teautil.Common.defaultNumber(runtime.connectTimeout, _connectTimeout)),
            new TeaPair("localAddr", com.aliyun.teautil.Common.defaultString(runtime.localAddr, _localAddr)),
            new TeaPair("httpProxy", com.aliyun.teautil.Common.defaultString(runtime.httpProxy, _httpProxy)),
            new TeaPair("httpsProxy", com.aliyun.teautil.Common.defaultString(runtime.httpsProxy, _httpsProxy)),
            new TeaPair("noProxy", com.aliyun.teautil.Common.defaultString(runtime.noProxy, _noProxy)),
            new TeaPair("socks5Proxy", com.aliyun.teautil.Common.defaultString(runtime.socks5Proxy, _socks5Proxy)),
            new TeaPair("socks5NetWork", com.aliyun.teautil.Common.defaultString(runtime.socks5NetWork, _socks5NetWork)),
            new TeaPair("maxIdleConns", com.aliyun.teautil.Common.defaultNumber(runtime.maxIdleConns, _maxIdleConns)),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", com.aliyun.teautil.Common.defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", com.aliyun.teautil.Common.defaultString(runtime.backoffPolicy, "no")),
                new TeaPair("period", com.aliyun.teautil.Common.defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL)
        );

        TeaRequest _lastRequest = null;
        long _now = System.currentTimeMillis();
        int _retryTimes = 0;
        while (Tea.allowRetry((java.util.Map<String, Object>) runtime_.get("retry"), _retryTimes, _now)) {
            if (_retryTimes > 0) {
                int backoffTime = Tea.getBackoffTime(runtime_.get("backoff"), _retryTimes);
                if (backoffTime > 0) {
                    Tea.sleep(backoffTime);
                }
            }
            _retryTimes = _retryTimes + 1;
            try {
                TeaRequest request_ = new TeaRequest();
                String accessKeyId = _credential.getAccessKeyId();
                String accessKeySecret = _credential.getAccessKeySecret();
                String token = _credential.getSecurityToken();
                request_.protocol = _protocol;
                request_.method = "DELETE";
                request_.pathname = "/?encryption";
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("host", com.aliyun.ossutil.Client.getHost(request.bucketName, _regionId, _endpoint, _hostModel)),
                    new TeaPair("date", com.aliyun.teautil.Common.getDateUTCString()),
                    new TeaPair("user-agent", this.getUserAgent())
                );
                if (!com.aliyun.teautil.Common.empty(token)) {
                    request_.headers.put("x-oss-security-token", token);
                }

                request_.headers.put("authorization", com.aliyun.ossutil.Client.getSignature(request_, request.bucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                String bodyStr = null;
                if (com.aliyun.teautil.Common.is4xx(response_.statusCode) || com.aliyun.teautil.Common.is5xx(response_.statusCode)) {
                    bodyStr = com.aliyun.teautil.Common.readAsString(response_.body);
                    respMap = com.aliyun.ossutil.Client.getErrMessage(bodyStr);
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("code", respMap.get("Code")),
                        new TeaPair("message", respMap.get("Message")),
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("httpCode", response_.statusCode),
                            new TeaPair("requestId", respMap.get("RequestId")),
                            new TeaPair("hostId", respMap.get("HostId"))
                        ))
                    ));
                }

                return TeaModel.toModel(TeaConverter.merge(String.class,
                    response_.headers
                ), new DeleteBucketEncryptionResponse());
            } catch (Exception e) {
                if (Tea.isRetryable(e)) {
                    continue;
                }
                throw e;
            }
        }

        throw new TeaUnretryableException(_lastRequest);
    }

    public DeleteBucketTagsResponse deleteBucketTags(DeleteBucketTagsRequest request, com.aliyun.ossutil.models.RuntimeOptions runtime) throws Exception {
        TeaModel.validateParams(request, "request");
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", com.aliyun.teautil.Common.defaultNumber(runtime.readTimeout, _readTimeout)),
            new TeaPair("connectTimeout", com.aliyun.teautil.Common.defaultNumber(runtime.connectTimeout, _connectTimeout)),
            new TeaPair("localAddr", com.aliyun.teautil.Common.defaultString(runtime.localAddr, _localAddr)),
            new TeaPair("httpProxy", com.aliyun.teautil.Common.defaultString(runtime.httpProxy, _httpProxy)),
            new TeaPair("httpsProxy", com.aliyun.teautil.Common.defaultString(runtime.httpsProxy, _httpsProxy)),
            new TeaPair("noProxy", com.aliyun.teautil.Common.defaultString(runtime.noProxy, _noProxy)),
            new TeaPair("socks5Proxy", com.aliyun.teautil.Common.defaultString(runtime.socks5Proxy, _socks5Proxy)),
            new TeaPair("socks5NetWork", com.aliyun.teautil.Common.defaultString(runtime.socks5NetWork, _socks5NetWork)),
            new TeaPair("maxIdleConns", com.aliyun.teautil.Common.defaultNumber(runtime.maxIdleConns, _maxIdleConns)),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", com.aliyun.teautil.Common.defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", com.aliyun.teautil.Common.defaultString(runtime.backoffPolicy, "no")),
                new TeaPair("period", com.aliyun.teautil.Common.defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL)
        );

        TeaRequest _lastRequest = null;
        long _now = System.currentTimeMillis();
        int _retryTimes = 0;
        while (Tea.allowRetry((java.util.Map<String, Object>) runtime_.get("retry"), _retryTimes, _now)) {
            if (_retryTimes > 0) {
                int backoffTime = Tea.getBackoffTime(runtime_.get("backoff"), _retryTimes);
                if (backoffTime > 0) {
                    Tea.sleep(backoffTime);
                }
            }
            _retryTimes = _retryTimes + 1;
            try {
                TeaRequest request_ = new TeaRequest();
                String accessKeyId = _credential.getAccessKeyId();
                String accessKeySecret = _credential.getAccessKeySecret();
                String token = _credential.getSecurityToken();
                request_.protocol = _protocol;
                request_.method = "DELETE";
                request_.pathname = "/";
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("host", com.aliyun.ossutil.Client.getHost(request.bucketName, _regionId, _endpoint, _hostModel)),
                    new TeaPair("date", com.aliyun.teautil.Common.getDateUTCString()),
                    new TeaPair("user-agent", this.getUserAgent())
                );
                if (!com.aliyun.teautil.Common.empty(token)) {
                    request_.headers.put("x-oss-security-token", token);
                }

                request_.query = com.aliyun.teautil.Common.stringifyMapValue(TeaModel.buildMap(request.filter));
                request_.headers.put("authorization", com.aliyun.ossutil.Client.getSignature(request_, request.bucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                String bodyStr = null;
                if (com.aliyun.teautil.Common.is4xx(response_.statusCode) || com.aliyun.teautil.Common.is5xx(response_.statusCode)) {
                    bodyStr = com.aliyun.teautil.Common.readAsString(response_.body);
                    respMap = com.aliyun.ossutil.Client.getErrMessage(bodyStr);
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("code", respMap.get("Code")),
                        new TeaPair("message", respMap.get("Message")),
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("httpCode", response_.statusCode),
                            new TeaPair("requestId", respMap.get("RequestId")),
                            new TeaPair("hostId", respMap.get("HostId"))
                        ))
                    ));
                }

                return TeaModel.toModel(TeaConverter.merge(String.class,
                    response_.headers
                ), new DeleteBucketTagsResponse());
            } catch (Exception e) {
                if (Tea.isRetryable(e)) {
                    continue;
                }
                throw e;
            }
        }

        throw new TeaUnretryableException(_lastRequest);
    }

    public GetBucketWebsiteResponse getBucketWebsite(GetBucketWebsiteRequest request, com.aliyun.ossutil.models.RuntimeOptions runtime) throws Exception {
        TeaModel.validateParams(request, "request");
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", com.aliyun.teautil.Common.defaultNumber(runtime.readTimeout, _readTimeout)),
            new TeaPair("connectTimeout", com.aliyun.teautil.Common.defaultNumber(runtime.connectTimeout, _connectTimeout)),
            new TeaPair("localAddr", com.aliyun.teautil.Common.defaultString(runtime.localAddr, _localAddr)),
            new TeaPair("httpProxy", com.aliyun.teautil.Common.defaultString(runtime.httpProxy, _httpProxy)),
            new TeaPair("httpsProxy", com.aliyun.teautil.Common.defaultString(runtime.httpsProxy, _httpsProxy)),
            new TeaPair("noProxy", com.aliyun.teautil.Common.defaultString(runtime.noProxy, _noProxy)),
            new TeaPair("socks5Proxy", com.aliyun.teautil.Common.defaultString(runtime.socks5Proxy, _socks5Proxy)),
            new TeaPair("socks5NetWork", com.aliyun.teautil.Common.defaultString(runtime.socks5NetWork, _socks5NetWork)),
            new TeaPair("maxIdleConns", com.aliyun.teautil.Common.defaultNumber(runtime.maxIdleConns, _maxIdleConns)),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", com.aliyun.teautil.Common.defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", com.aliyun.teautil.Common.defaultString(runtime.backoffPolicy, "no")),
                new TeaPair("period", com.aliyun.teautil.Common.defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL)
        );

        TeaRequest _lastRequest = null;
        long _now = System.currentTimeMillis();
        int _retryTimes = 0;
        while (Tea.allowRetry((java.util.Map<String, Object>) runtime_.get("retry"), _retryTimes, _now)) {
            if (_retryTimes > 0) {
                int backoffTime = Tea.getBackoffTime(runtime_.get("backoff"), _retryTimes);
                if (backoffTime > 0) {
                    Tea.sleep(backoffTime);
                }
            }
            _retryTimes = _retryTimes + 1;
            try {
                TeaRequest request_ = new TeaRequest();
                String accessKeyId = _credential.getAccessKeyId();
                String accessKeySecret = _credential.getAccessKeySecret();
                String token = _credential.getSecurityToken();
                request_.protocol = _protocol;
                request_.method = "GET";
                request_.pathname = "/?website";
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("host", com.aliyun.ossutil.Client.getHost(request.bucketName, _regionId, _endpoint, _hostModel)),
                    new TeaPair("date", com.aliyun.teautil.Common.getDateUTCString()),
                    new TeaPair("user-agent", this.getUserAgent())
                );
                if (!com.aliyun.teautil.Common.empty(token)) {
                    request_.headers.put("x-oss-security-token", token);
                }

                request_.headers.put("authorization", com.aliyun.ossutil.Client.getSignature(request_, request.bucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                String bodyStr = null;
                if (com.aliyun.teautil.Common.is4xx(response_.statusCode) || com.aliyun.teautil.Common.is5xx(response_.statusCode)) {
                    bodyStr = com.aliyun.teautil.Common.readAsString(response_.body);
                    respMap = com.aliyun.ossutil.Client.getErrMessage(bodyStr);
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("code", respMap.get("Code")),
                        new TeaPair("message", respMap.get("Message")),
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("httpCode", response_.statusCode),
                            new TeaPair("requestId", respMap.get("RequestId")),
                            new TeaPair("hostId", respMap.get("HostId"))
                        ))
                    ));
                }

                bodyStr = com.aliyun.teautil.Common.readAsString(response_.body);
                respMap = com.aliyun.teaxml.Client.parseXml(bodyStr, GetBucketWebsiteResponse.class);
                return TeaModel.toModel(TeaConverter.merge(Object.class,
                    TeaConverter.buildMap(
                        new TeaPair("WebsiteConfiguration", respMap.get("WebsiteConfiguration"))
                    ),
                    response_.headers
                ), new GetBucketWebsiteResponse());
            } catch (Exception e) {
                if (Tea.isRetryable(e)) {
                    continue;
                }
                throw e;
            }
        }

        throw new TeaUnretryableException(_lastRequest);
    }

    public DeleteLiveChannelResponse deleteLiveChannel(DeleteLiveChannelRequest request, com.aliyun.ossutil.models.RuntimeOptions runtime) throws Exception {
        TeaModel.validateParams(request, "request");
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", com.aliyun.teautil.Common.defaultNumber(runtime.readTimeout, _readTimeout)),
            new TeaPair("connectTimeout", com.aliyun.teautil.Common.defaultNumber(runtime.connectTimeout, _connectTimeout)),
            new TeaPair("localAddr", com.aliyun.teautil.Common.defaultString(runtime.localAddr, _localAddr)),
            new TeaPair("httpProxy", com.aliyun.teautil.Common.defaultString(runtime.httpProxy, _httpProxy)),
            new TeaPair("httpsProxy", com.aliyun.teautil.Common.defaultString(runtime.httpsProxy, _httpsProxy)),
            new TeaPair("noProxy", com.aliyun.teautil.Common.defaultString(runtime.noProxy, _noProxy)),
            new TeaPair("socks5Proxy", com.aliyun.teautil.Common.defaultString(runtime.socks5Proxy, _socks5Proxy)),
            new TeaPair("socks5NetWork", com.aliyun.teautil.Common.defaultString(runtime.socks5NetWork, _socks5NetWork)),
            new TeaPair("maxIdleConns", com.aliyun.teautil.Common.defaultNumber(runtime.maxIdleConns, _maxIdleConns)),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", com.aliyun.teautil.Common.defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", com.aliyun.teautil.Common.defaultString(runtime.backoffPolicy, "no")),
                new TeaPair("period", com.aliyun.teautil.Common.defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL)
        );

        TeaRequest _lastRequest = null;
        long _now = System.currentTimeMillis();
        int _retryTimes = 0;
        while (Tea.allowRetry((java.util.Map<String, Object>) runtime_.get("retry"), _retryTimes, _now)) {
            if (_retryTimes > 0) {
                int backoffTime = Tea.getBackoffTime(runtime_.get("backoff"), _retryTimes);
                if (backoffTime > 0) {
                    Tea.sleep(backoffTime);
                }
            }
            _retryTimes = _retryTimes + 1;
            try {
                TeaRequest request_ = new TeaRequest();
                String accessKeyId = _credential.getAccessKeyId();
                String accessKeySecret = _credential.getAccessKeySecret();
                String token = _credential.getSecurityToken();
                request_.protocol = _protocol;
                request_.method = "DELETE";
                request_.pathname = "/" + request.channelName + "?live";
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("host", com.aliyun.ossutil.Client.getHost(request.bucketName, _regionId, _endpoint, _hostModel)),
                    new TeaPair("date", com.aliyun.teautil.Common.getDateUTCString()),
                    new TeaPair("user-agent", this.getUserAgent())
                );
                if (!com.aliyun.teautil.Common.empty(token)) {
                    request_.headers.put("x-oss-security-token", token);
                }

                request_.headers.put("authorization", com.aliyun.ossutil.Client.getSignature(request_, request.bucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                String bodyStr = null;
                if (com.aliyun.teautil.Common.is4xx(response_.statusCode) || com.aliyun.teautil.Common.is5xx(response_.statusCode)) {
                    bodyStr = com.aliyun.teautil.Common.readAsString(response_.body);
                    respMap = com.aliyun.ossutil.Client.getErrMessage(bodyStr);
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("code", respMap.get("Code")),
                        new TeaPair("message", respMap.get("Message")),
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("httpCode", response_.statusCode),
                            new TeaPair("requestId", respMap.get("RequestId")),
                            new TeaPair("hostId", respMap.get("HostId"))
                        ))
                    ));
                }

                return TeaModel.toModel(TeaConverter.merge(String.class,
                    response_.headers
                ), new DeleteLiveChannelResponse());
            } catch (Exception e) {
                if (Tea.isRetryable(e)) {
                    continue;
                }
                throw e;
            }
        }

        throw new TeaUnretryableException(_lastRequest);
    }

    public GetBucketLocationResponse getBucketLocation(GetBucketLocationRequest request, com.aliyun.ossutil.models.RuntimeOptions runtime) throws Exception {
        TeaModel.validateParams(request, "request");
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", com.aliyun.teautil.Common.defaultNumber(runtime.readTimeout, _readTimeout)),
            new TeaPair("connectTimeout", com.aliyun.teautil.Common.defaultNumber(runtime.connectTimeout, _connectTimeout)),
            new TeaPair("localAddr", com.aliyun.teautil.Common.defaultString(runtime.localAddr, _localAddr)),
            new TeaPair("httpProxy", com.aliyun.teautil.Common.defaultString(runtime.httpProxy, _httpProxy)),
            new TeaPair("httpsProxy", com.aliyun.teautil.Common.defaultString(runtime.httpsProxy, _httpsProxy)),
            new TeaPair("noProxy", com.aliyun.teautil.Common.defaultString(runtime.noProxy, _noProxy)),
            new TeaPair("socks5Proxy", com.aliyun.teautil.Common.defaultString(runtime.socks5Proxy, _socks5Proxy)),
            new TeaPair("socks5NetWork", com.aliyun.teautil.Common.defaultString(runtime.socks5NetWork, _socks5NetWork)),
            new TeaPair("maxIdleConns", com.aliyun.teautil.Common.defaultNumber(runtime.maxIdleConns, _maxIdleConns)),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", com.aliyun.teautil.Common.defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", com.aliyun.teautil.Common.defaultString(runtime.backoffPolicy, "no")),
                new TeaPair("period", com.aliyun.teautil.Common.defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL)
        );

        TeaRequest _lastRequest = null;
        long _now = System.currentTimeMillis();
        int _retryTimes = 0;
        while (Tea.allowRetry((java.util.Map<String, Object>) runtime_.get("retry"), _retryTimes, _now)) {
            if (_retryTimes > 0) {
                int backoffTime = Tea.getBackoffTime(runtime_.get("backoff"), _retryTimes);
                if (backoffTime > 0) {
                    Tea.sleep(backoffTime);
                }
            }
            _retryTimes = _retryTimes + 1;
            try {
                TeaRequest request_ = new TeaRequest();
                String accessKeyId = _credential.getAccessKeyId();
                String accessKeySecret = _credential.getAccessKeySecret();
                String token = _credential.getSecurityToken();
                request_.protocol = _protocol;
                request_.method = "GET";
                request_.pathname = "/?location";
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("host", com.aliyun.ossutil.Client.getHost(request.bucketName, _regionId, _endpoint, _hostModel)),
                    new TeaPair("date", com.aliyun.teautil.Common.getDateUTCString()),
                    new TeaPair("user-agent", this.getUserAgent())
                );
                if (!com.aliyun.teautil.Common.empty(token)) {
                    request_.headers.put("x-oss-security-token", token);
                }

                request_.headers.put("authorization", com.aliyun.ossutil.Client.getSignature(request_, request.bucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                String bodyStr = null;
                if (com.aliyun.teautil.Common.is4xx(response_.statusCode) || com.aliyun.teautil.Common.is5xx(response_.statusCode)) {
                    bodyStr = com.aliyun.teautil.Common.readAsString(response_.body);
                    respMap = com.aliyun.ossutil.Client.getErrMessage(bodyStr);
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("code", respMap.get("Code")),
                        new TeaPair("message", respMap.get("Message")),
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("httpCode", response_.statusCode),
                            new TeaPair("requestId", respMap.get("RequestId")),
                            new TeaPair("hostId", respMap.get("HostId"))
                        ))
                    ));
                }

                bodyStr = com.aliyun.teautil.Common.readAsString(response_.body);
                respMap = com.aliyun.teaxml.Client.parseXml(bodyStr, GetBucketLocationResponse.class);
                return TeaModel.toModel(TeaConverter.merge(Object.class,
                    TeaConverter.buildMap(
                        new TeaPair("LocationConstraint", respMap.get("LocationConstraint"))
                    ),
                    response_.headers
                ), new GetBucketLocationResponse());
            } catch (Exception e) {
                if (Tea.isRetryable(e)) {
                    continue;
                }
                throw e;
            }
        }

        throw new TeaUnretryableException(_lastRequest);
    }

    public ListLiveChannelResponse listLiveChannel(ListLiveChannelRequest request, com.aliyun.ossutil.models.RuntimeOptions runtime) throws Exception {
        TeaModel.validateParams(request, "request");
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", com.aliyun.teautil.Common.defaultNumber(runtime.readTimeout, _readTimeout)),
            new TeaPair("connectTimeout", com.aliyun.teautil.Common.defaultNumber(runtime.connectTimeout, _connectTimeout)),
            new TeaPair("localAddr", com.aliyun.teautil.Common.defaultString(runtime.localAddr, _localAddr)),
            new TeaPair("httpProxy", com.aliyun.teautil.Common.defaultString(runtime.httpProxy, _httpProxy)),
            new TeaPair("httpsProxy", com.aliyun.teautil.Common.defaultString(runtime.httpsProxy, _httpsProxy)),
            new TeaPair("noProxy", com.aliyun.teautil.Common.defaultString(runtime.noProxy, _noProxy)),
            new TeaPair("socks5Proxy", com.aliyun.teautil.Common.defaultString(runtime.socks5Proxy, _socks5Proxy)),
            new TeaPair("socks5NetWork", com.aliyun.teautil.Common.defaultString(runtime.socks5NetWork, _socks5NetWork)),
            new TeaPair("maxIdleConns", com.aliyun.teautil.Common.defaultNumber(runtime.maxIdleConns, _maxIdleConns)),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", com.aliyun.teautil.Common.defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", com.aliyun.teautil.Common.defaultString(runtime.backoffPolicy, "no")),
                new TeaPair("period", com.aliyun.teautil.Common.defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL)
        );

        TeaRequest _lastRequest = null;
        long _now = System.currentTimeMillis();
        int _retryTimes = 0;
        while (Tea.allowRetry((java.util.Map<String, Object>) runtime_.get("retry"), _retryTimes, _now)) {
            if (_retryTimes > 0) {
                int backoffTime = Tea.getBackoffTime(runtime_.get("backoff"), _retryTimes);
                if (backoffTime > 0) {
                    Tea.sleep(backoffTime);
                }
            }
            _retryTimes = _retryTimes + 1;
            try {
                TeaRequest request_ = new TeaRequest();
                String accessKeyId = _credential.getAccessKeyId();
                String accessKeySecret = _credential.getAccessKeySecret();
                String token = _credential.getSecurityToken();
                request_.protocol = _protocol;
                request_.method = "GET";
                request_.pathname = "/?live";
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("host", com.aliyun.ossutil.Client.getHost(request.bucketName, _regionId, _endpoint, _hostModel)),
                    new TeaPair("date", com.aliyun.teautil.Common.getDateUTCString()),
                    new TeaPair("user-agent", this.getUserAgent())
                );
                if (!com.aliyun.teautil.Common.empty(token)) {
                    request_.headers.put("x-oss-security-token", token);
                }

                request_.query = com.aliyun.teautil.Common.stringifyMapValue(TeaModel.buildMap(request.filter));
                request_.headers.put("authorization", com.aliyun.ossutil.Client.getSignature(request_, request.bucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                String bodyStr = null;
                if (com.aliyun.teautil.Common.is4xx(response_.statusCode) || com.aliyun.teautil.Common.is5xx(response_.statusCode)) {
                    bodyStr = com.aliyun.teautil.Common.readAsString(response_.body);
                    respMap = com.aliyun.ossutil.Client.getErrMessage(bodyStr);
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("code", respMap.get("Code")),
                        new TeaPair("message", respMap.get("Message")),
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("httpCode", response_.statusCode),
                            new TeaPair("requestId", respMap.get("RequestId")),
                            new TeaPair("hostId", respMap.get("HostId"))
                        ))
                    ));
                }

                bodyStr = com.aliyun.teautil.Common.readAsString(response_.body);
                respMap = com.aliyun.teaxml.Client.parseXml(bodyStr, ListLiveChannelResponse.class);
                return TeaModel.toModel(TeaConverter.merge(Object.class,
                    TeaConverter.buildMap(
                        new TeaPair("ListLiveChannelResult", respMap.get("ListLiveChannelResult"))
                    ),
                    response_.headers
                ), new ListLiveChannelResponse());
            } catch (Exception e) {
                if (Tea.isRetryable(e)) {
                    continue;
                }
                throw e;
            }
        }

        throw new TeaUnretryableException(_lastRequest);
    }

    public GetObjectMetaResponse getObjectMeta(GetObjectMetaRequest request, com.aliyun.ossutil.models.RuntimeOptions runtime) throws Exception {
        TeaModel.validateParams(request, "request");
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", com.aliyun.teautil.Common.defaultNumber(runtime.readTimeout, _readTimeout)),
            new TeaPair("connectTimeout", com.aliyun.teautil.Common.defaultNumber(runtime.connectTimeout, _connectTimeout)),
            new TeaPair("localAddr", com.aliyun.teautil.Common.defaultString(runtime.localAddr, _localAddr)),
            new TeaPair("httpProxy", com.aliyun.teautil.Common.defaultString(runtime.httpProxy, _httpProxy)),
            new TeaPair("httpsProxy", com.aliyun.teautil.Common.defaultString(runtime.httpsProxy, _httpsProxy)),
            new TeaPair("noProxy", com.aliyun.teautil.Common.defaultString(runtime.noProxy, _noProxy)),
            new TeaPair("socks5Proxy", com.aliyun.teautil.Common.defaultString(runtime.socks5Proxy, _socks5Proxy)),
            new TeaPair("socks5NetWork", com.aliyun.teautil.Common.defaultString(runtime.socks5NetWork, _socks5NetWork)),
            new TeaPair("maxIdleConns", com.aliyun.teautil.Common.defaultNumber(runtime.maxIdleConns, _maxIdleConns)),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", com.aliyun.teautil.Common.defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", com.aliyun.teautil.Common.defaultString(runtime.backoffPolicy, "no")),
                new TeaPair("period", com.aliyun.teautil.Common.defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL)
        );

        TeaRequest _lastRequest = null;
        long _now = System.currentTimeMillis();
        int _retryTimes = 0;
        while (Tea.allowRetry((java.util.Map<String, Object>) runtime_.get("retry"), _retryTimes, _now)) {
            if (_retryTimes > 0) {
                int backoffTime = Tea.getBackoffTime(runtime_.get("backoff"), _retryTimes);
                if (backoffTime > 0) {
                    Tea.sleep(backoffTime);
                }
            }
            _retryTimes = _retryTimes + 1;
            try {
                TeaRequest request_ = new TeaRequest();
                String accessKeyId = _credential.getAccessKeyId();
                String accessKeySecret = _credential.getAccessKeySecret();
                String token = _credential.getSecurityToken();
                request_.protocol = _protocol;
                request_.method = "HEAD";
                request_.pathname = "/" + request.objectName + "?objectMeta";
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("host", com.aliyun.ossutil.Client.getHost(request.bucketName, _regionId, _endpoint, _hostModel)),
                    new TeaPair("date", com.aliyun.teautil.Common.getDateUTCString()),
                    new TeaPair("user-agent", this.getUserAgent())
                );
                if (!com.aliyun.teautil.Common.empty(token)) {
                    request_.headers.put("x-oss-security-token", token);
                }

                request_.headers.put("authorization", com.aliyun.ossutil.Client.getSignature(request_, request.bucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                String bodyStr = null;
                if (com.aliyun.teautil.Common.is4xx(response_.statusCode) || com.aliyun.teautil.Common.is5xx(response_.statusCode)) {
                    bodyStr = com.aliyun.teautil.Common.readAsString(response_.body);
                    respMap = com.aliyun.ossutil.Client.getErrMessage(bodyStr);
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("code", respMap.get("Code")),
                        new TeaPair("message", respMap.get("Message")),
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("httpCode", response_.statusCode),
                            new TeaPair("requestId", respMap.get("RequestId")),
                            new TeaPair("hostId", respMap.get("HostId"))
                        ))
                    ));
                }

                return TeaModel.toModel(TeaConverter.merge(String.class,
                    response_.headers
                ), new GetObjectMetaResponse());
            } catch (Exception e) {
                if (Tea.isRetryable(e)) {
                    continue;
                }
                throw e;
            }
        }

        throw new TeaUnretryableException(_lastRequest);
    }

    public GetBucketAclResponse getBucketAcl(GetBucketAclRequest request, com.aliyun.ossutil.models.RuntimeOptions runtime) throws Exception {
        TeaModel.validateParams(request, "request");
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", com.aliyun.teautil.Common.defaultNumber(runtime.readTimeout, _readTimeout)),
            new TeaPair("connectTimeout", com.aliyun.teautil.Common.defaultNumber(runtime.connectTimeout, _connectTimeout)),
            new TeaPair("localAddr", com.aliyun.teautil.Common.defaultString(runtime.localAddr, _localAddr)),
            new TeaPair("httpProxy", com.aliyun.teautil.Common.defaultString(runtime.httpProxy, _httpProxy)),
            new TeaPair("httpsProxy", com.aliyun.teautil.Common.defaultString(runtime.httpsProxy, _httpsProxy)),
            new TeaPair("noProxy", com.aliyun.teautil.Common.defaultString(runtime.noProxy, _noProxy)),
            new TeaPair("socks5Proxy", com.aliyun.teautil.Common.defaultString(runtime.socks5Proxy, _socks5Proxy)),
            new TeaPair("socks5NetWork", com.aliyun.teautil.Common.defaultString(runtime.socks5NetWork, _socks5NetWork)),
            new TeaPair("maxIdleConns", com.aliyun.teautil.Common.defaultNumber(runtime.maxIdleConns, _maxIdleConns)),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", com.aliyun.teautil.Common.defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", com.aliyun.teautil.Common.defaultString(runtime.backoffPolicy, "no")),
                new TeaPair("period", com.aliyun.teautil.Common.defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL)
        );

        TeaRequest _lastRequest = null;
        long _now = System.currentTimeMillis();
        int _retryTimes = 0;
        while (Tea.allowRetry((java.util.Map<String, Object>) runtime_.get("retry"), _retryTimes, _now)) {
            if (_retryTimes > 0) {
                int backoffTime = Tea.getBackoffTime(runtime_.get("backoff"), _retryTimes);
                if (backoffTime > 0) {
                    Tea.sleep(backoffTime);
                }
            }
            _retryTimes = _retryTimes + 1;
            try {
                TeaRequest request_ = new TeaRequest();
                String accessKeyId = _credential.getAccessKeyId();
                String accessKeySecret = _credential.getAccessKeySecret();
                String token = _credential.getSecurityToken();
                request_.protocol = _protocol;
                request_.method = "GET";
                request_.pathname = "/?acl";
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("host", com.aliyun.ossutil.Client.getHost(request.bucketName, _regionId, _endpoint, _hostModel)),
                    new TeaPair("date", com.aliyun.teautil.Common.getDateUTCString()),
                    new TeaPair("user-agent", this.getUserAgent())
                );
                if (!com.aliyun.teautil.Common.empty(token)) {
                    request_.headers.put("x-oss-security-token", token);
                }

                request_.headers.put("authorization", com.aliyun.ossutil.Client.getSignature(request_, request.bucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                String bodyStr = null;
                if (com.aliyun.teautil.Common.is4xx(response_.statusCode) || com.aliyun.teautil.Common.is5xx(response_.statusCode)) {
                    bodyStr = com.aliyun.teautil.Common.readAsString(response_.body);
                    respMap = com.aliyun.ossutil.Client.getErrMessage(bodyStr);
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("code", respMap.get("Code")),
                        new TeaPair("message", respMap.get("Message")),
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("httpCode", response_.statusCode),
                            new TeaPair("requestId", respMap.get("RequestId")),
                            new TeaPair("hostId", respMap.get("HostId"))
                        ))
                    ));
                }

                bodyStr = com.aliyun.teautil.Common.readAsString(response_.body);
                respMap = com.aliyun.teaxml.Client.parseXml(bodyStr, GetBucketAclResponse.class);
                return TeaModel.toModel(TeaConverter.merge(Object.class,
                    TeaConverter.buildMap(
                        new TeaPair("AccessControlPolicy", respMap.get("AccessControlPolicy"))
                    ),
                    response_.headers
                ), new GetBucketAclResponse());
            } catch (Exception e) {
                if (Tea.isRetryable(e)) {
                    continue;
                }
                throw e;
            }
        }

        throw new TeaUnretryableException(_lastRequest);
    }

    public ListPartsResponse listParts(ListPartsRequest request, com.aliyun.ossutil.models.RuntimeOptions runtime) throws Exception {
        TeaModel.validateParams(request, "request");
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", com.aliyun.teautil.Common.defaultNumber(runtime.readTimeout, _readTimeout)),
            new TeaPair("connectTimeout", com.aliyun.teautil.Common.defaultNumber(runtime.connectTimeout, _connectTimeout)),
            new TeaPair("localAddr", com.aliyun.teautil.Common.defaultString(runtime.localAddr, _localAddr)),
            new TeaPair("httpProxy", com.aliyun.teautil.Common.defaultString(runtime.httpProxy, _httpProxy)),
            new TeaPair("httpsProxy", com.aliyun.teautil.Common.defaultString(runtime.httpsProxy, _httpsProxy)),
            new TeaPair("noProxy", com.aliyun.teautil.Common.defaultString(runtime.noProxy, _noProxy)),
            new TeaPair("socks5Proxy", com.aliyun.teautil.Common.defaultString(runtime.socks5Proxy, _socks5Proxy)),
            new TeaPair("socks5NetWork", com.aliyun.teautil.Common.defaultString(runtime.socks5NetWork, _socks5NetWork)),
            new TeaPair("maxIdleConns", com.aliyun.teautil.Common.defaultNumber(runtime.maxIdleConns, _maxIdleConns)),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", com.aliyun.teautil.Common.defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", com.aliyun.teautil.Common.defaultString(runtime.backoffPolicy, "no")),
                new TeaPair("period", com.aliyun.teautil.Common.defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL)
        );

        TeaRequest _lastRequest = null;
        long _now = System.currentTimeMillis();
        int _retryTimes = 0;
        while (Tea.allowRetry((java.util.Map<String, Object>) runtime_.get("retry"), _retryTimes, _now)) {
            if (_retryTimes > 0) {
                int backoffTime = Tea.getBackoffTime(runtime_.get("backoff"), _retryTimes);
                if (backoffTime > 0) {
                    Tea.sleep(backoffTime);
                }
            }
            _retryTimes = _retryTimes + 1;
            try {
                TeaRequest request_ = new TeaRequest();
                String accessKeyId = _credential.getAccessKeyId();
                String accessKeySecret = _credential.getAccessKeySecret();
                String token = _credential.getSecurityToken();
                request_.protocol = _protocol;
                request_.method = "GET";
                request_.pathname = "/" + request.objectName + "";
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("host", com.aliyun.ossutil.Client.getHost(request.bucketName, _regionId, _endpoint, _hostModel)),
                    new TeaPair("date", com.aliyun.teautil.Common.getDateUTCString()),
                    new TeaPair("user-agent", this.getUserAgent())
                );
                if (!com.aliyun.teautil.Common.empty(token)) {
                    request_.headers.put("x-oss-security-token", token);
                }

                request_.query = com.aliyun.teautil.Common.stringifyMapValue(TeaModel.buildMap(request.filter));
                request_.headers.put("authorization", com.aliyun.ossutil.Client.getSignature(request_, request.bucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                String bodyStr = null;
                if (com.aliyun.teautil.Common.is4xx(response_.statusCode) || com.aliyun.teautil.Common.is5xx(response_.statusCode)) {
                    bodyStr = com.aliyun.teautil.Common.readAsString(response_.body);
                    respMap = com.aliyun.ossutil.Client.getErrMessage(bodyStr);
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("code", respMap.get("Code")),
                        new TeaPair("message", respMap.get("Message")),
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("httpCode", response_.statusCode),
                            new TeaPair("requestId", respMap.get("RequestId")),
                            new TeaPair("hostId", respMap.get("HostId"))
                        ))
                    ));
                }

                bodyStr = com.aliyun.teautil.Common.readAsString(response_.body);
                respMap = com.aliyun.teaxml.Client.parseXml(bodyStr, ListPartsResponse.class);
                return TeaModel.toModel(TeaConverter.merge(Object.class,
                    TeaConverter.buildMap(
                        new TeaPair("ListPartsResult", respMap.get("ListPartsResult"))
                    ),
                    response_.headers
                ), new ListPartsResponse());
            } catch (Exception e) {
                if (Tea.isRetryable(e)) {
                    continue;
                }
                throw e;
            }
        }

        throw new TeaUnretryableException(_lastRequest);
    }

    public GetLiveChannelHistoryResponse getLiveChannelHistory(GetLiveChannelHistoryRequest request, com.aliyun.ossutil.models.RuntimeOptions runtime) throws Exception {
        TeaModel.validateParams(request, "request");
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", com.aliyun.teautil.Common.defaultNumber(runtime.readTimeout, _readTimeout)),
            new TeaPair("connectTimeout", com.aliyun.teautil.Common.defaultNumber(runtime.connectTimeout, _connectTimeout)),
            new TeaPair("localAddr", com.aliyun.teautil.Common.defaultString(runtime.localAddr, _localAddr)),
            new TeaPair("httpProxy", com.aliyun.teautil.Common.defaultString(runtime.httpProxy, _httpProxy)),
            new TeaPair("httpsProxy", com.aliyun.teautil.Common.defaultString(runtime.httpsProxy, _httpsProxy)),
            new TeaPair("noProxy", com.aliyun.teautil.Common.defaultString(runtime.noProxy, _noProxy)),
            new TeaPair("socks5Proxy", com.aliyun.teautil.Common.defaultString(runtime.socks5Proxy, _socks5Proxy)),
            new TeaPair("socks5NetWork", com.aliyun.teautil.Common.defaultString(runtime.socks5NetWork, _socks5NetWork)),
            new TeaPair("maxIdleConns", com.aliyun.teautil.Common.defaultNumber(runtime.maxIdleConns, _maxIdleConns)),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", com.aliyun.teautil.Common.defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", com.aliyun.teautil.Common.defaultString(runtime.backoffPolicy, "no")),
                new TeaPair("period", com.aliyun.teautil.Common.defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL)
        );

        TeaRequest _lastRequest = null;
        long _now = System.currentTimeMillis();
        int _retryTimes = 0;
        while (Tea.allowRetry((java.util.Map<String, Object>) runtime_.get("retry"), _retryTimes, _now)) {
            if (_retryTimes > 0) {
                int backoffTime = Tea.getBackoffTime(runtime_.get("backoff"), _retryTimes);
                if (backoffTime > 0) {
                    Tea.sleep(backoffTime);
                }
            }
            _retryTimes = _retryTimes + 1;
            try {
                TeaRequest request_ = new TeaRequest();
                String accessKeyId = _credential.getAccessKeyId();
                String accessKeySecret = _credential.getAccessKeySecret();
                String token = _credential.getSecurityToken();
                request_.protocol = _protocol;
                request_.method = "GET";
                request_.pathname = "/" + request.channelName + "?live";
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("host", com.aliyun.ossutil.Client.getHost(request.bucketName, _regionId, _endpoint, _hostModel)),
                    new TeaPair("date", com.aliyun.teautil.Common.getDateUTCString()),
                    new TeaPair("user-agent", this.getUserAgent())
                );
                if (!com.aliyun.teautil.Common.empty(token)) {
                    request_.headers.put("x-oss-security-token", token);
                }

                request_.query = com.aliyun.teautil.Common.stringifyMapValue(TeaModel.buildMap(request.filter));
                request_.headers.put("authorization", com.aliyun.ossutil.Client.getSignature(request_, request.bucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                String bodyStr = null;
                if (com.aliyun.teautil.Common.is4xx(response_.statusCode) || com.aliyun.teautil.Common.is5xx(response_.statusCode)) {
                    bodyStr = com.aliyun.teautil.Common.readAsString(response_.body);
                    respMap = com.aliyun.ossutil.Client.getErrMessage(bodyStr);
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("code", respMap.get("Code")),
                        new TeaPair("message", respMap.get("Message")),
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("httpCode", response_.statusCode),
                            new TeaPair("requestId", respMap.get("RequestId")),
                            new TeaPair("hostId", respMap.get("HostId"))
                        ))
                    ));
                }

                bodyStr = com.aliyun.teautil.Common.readAsString(response_.body);
                respMap = com.aliyun.teaxml.Client.parseXml(bodyStr, GetLiveChannelHistoryResponse.class);
                return TeaModel.toModel(TeaConverter.merge(Object.class,
                    TeaConverter.buildMap(
                        new TeaPair("LiveChannelHistory", respMap.get("LiveChannelHistory"))
                    ),
                    response_.headers
                ), new GetLiveChannelHistoryResponse());
            } catch (Exception e) {
                if (Tea.isRetryable(e)) {
                    continue;
                }
                throw e;
            }
        }

        throw new TeaUnretryableException(_lastRequest);
    }

    public GetBucketResponse getBucket(GetBucketRequest request, com.aliyun.ossutil.models.RuntimeOptions runtime) throws Exception {
        TeaModel.validateParams(request, "request");
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", com.aliyun.teautil.Common.defaultNumber(runtime.readTimeout, _readTimeout)),
            new TeaPair("connectTimeout", com.aliyun.teautil.Common.defaultNumber(runtime.connectTimeout, _connectTimeout)),
            new TeaPair("localAddr", com.aliyun.teautil.Common.defaultString(runtime.localAddr, _localAddr)),
            new TeaPair("httpProxy", com.aliyun.teautil.Common.defaultString(runtime.httpProxy, _httpProxy)),
            new TeaPair("httpsProxy", com.aliyun.teautil.Common.defaultString(runtime.httpsProxy, _httpsProxy)),
            new TeaPair("noProxy", com.aliyun.teautil.Common.defaultString(runtime.noProxy, _noProxy)),
            new TeaPair("socks5Proxy", com.aliyun.teautil.Common.defaultString(runtime.socks5Proxy, _socks5Proxy)),
            new TeaPair("socks5NetWork", com.aliyun.teautil.Common.defaultString(runtime.socks5NetWork, _socks5NetWork)),
            new TeaPair("maxIdleConns", com.aliyun.teautil.Common.defaultNumber(runtime.maxIdleConns, _maxIdleConns)),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", com.aliyun.teautil.Common.defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", com.aliyun.teautil.Common.defaultString(runtime.backoffPolicy, "no")),
                new TeaPair("period", com.aliyun.teautil.Common.defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL)
        );

        TeaRequest _lastRequest = null;
        long _now = System.currentTimeMillis();
        int _retryTimes = 0;
        while (Tea.allowRetry((java.util.Map<String, Object>) runtime_.get("retry"), _retryTimes, _now)) {
            if (_retryTimes > 0) {
                int backoffTime = Tea.getBackoffTime(runtime_.get("backoff"), _retryTimes);
                if (backoffTime > 0) {
                    Tea.sleep(backoffTime);
                }
            }
            _retryTimes = _retryTimes + 1;
            try {
                TeaRequest request_ = new TeaRequest();
                String accessKeyId = _credential.getAccessKeyId();
                String accessKeySecret = _credential.getAccessKeySecret();
                String token = _credential.getSecurityToken();
                request_.protocol = _protocol;
                request_.method = "GET";
                request_.pathname = "/";
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("host", com.aliyun.ossutil.Client.getHost(request.bucketName, _regionId, _endpoint, _hostModel)),
                    new TeaPair("date", com.aliyun.teautil.Common.getDateUTCString()),
                    new TeaPair("user-agent", this.getUserAgent())
                );
                if (!com.aliyun.teautil.Common.empty(token)) {
                    request_.headers.put("x-oss-security-token", token);
                }

                request_.query = com.aliyun.teautil.Common.stringifyMapValue(TeaModel.buildMap(request.filter));
                request_.headers.put("authorization", com.aliyun.ossutil.Client.getSignature(request_, request.bucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                String bodyStr = null;
                if (com.aliyun.teautil.Common.is4xx(response_.statusCode) || com.aliyun.teautil.Common.is5xx(response_.statusCode)) {
                    bodyStr = com.aliyun.teautil.Common.readAsString(response_.body);
                    respMap = com.aliyun.ossutil.Client.getErrMessage(bodyStr);
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("code", respMap.get("Code")),
                        new TeaPair("message", respMap.get("Message")),
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("httpCode", response_.statusCode),
                            new TeaPair("requestId", respMap.get("RequestId")),
                            new TeaPair("hostId", respMap.get("HostId"))
                        ))
                    ));
                }

                bodyStr = com.aliyun.teautil.Common.readAsString(response_.body);
                respMap = com.aliyun.teaxml.Client.parseXml(bodyStr, GetBucketResponse.class);
                return TeaModel.toModel(TeaConverter.merge(Object.class,
                    TeaConverter.buildMap(
                        new TeaPair("ListBucketResult", respMap.get("ListBucketResult"))
                    ),
                    response_.headers
                ), new GetBucketResponse());
            } catch (Exception e) {
                if (Tea.isRetryable(e)) {
                    continue;
                }
                throw e;
            }
        }

        throw new TeaUnretryableException(_lastRequest);
    }

    public GetLiveChannelInfoResponse getLiveChannelInfo(GetLiveChannelInfoRequest request, com.aliyun.ossutil.models.RuntimeOptions runtime) throws Exception {
        TeaModel.validateParams(request, "request");
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", com.aliyun.teautil.Common.defaultNumber(runtime.readTimeout, _readTimeout)),
            new TeaPair("connectTimeout", com.aliyun.teautil.Common.defaultNumber(runtime.connectTimeout, _connectTimeout)),
            new TeaPair("localAddr", com.aliyun.teautil.Common.defaultString(runtime.localAddr, _localAddr)),
            new TeaPair("httpProxy", com.aliyun.teautil.Common.defaultString(runtime.httpProxy, _httpProxy)),
            new TeaPair("httpsProxy", com.aliyun.teautil.Common.defaultString(runtime.httpsProxy, _httpsProxy)),
            new TeaPair("noProxy", com.aliyun.teautil.Common.defaultString(runtime.noProxy, _noProxy)),
            new TeaPair("socks5Proxy", com.aliyun.teautil.Common.defaultString(runtime.socks5Proxy, _socks5Proxy)),
            new TeaPair("socks5NetWork", com.aliyun.teautil.Common.defaultString(runtime.socks5NetWork, _socks5NetWork)),
            new TeaPair("maxIdleConns", com.aliyun.teautil.Common.defaultNumber(runtime.maxIdleConns, _maxIdleConns)),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", com.aliyun.teautil.Common.defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", com.aliyun.teautil.Common.defaultString(runtime.backoffPolicy, "no")),
                new TeaPair("period", com.aliyun.teautil.Common.defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL)
        );

        TeaRequest _lastRequest = null;
        long _now = System.currentTimeMillis();
        int _retryTimes = 0;
        while (Tea.allowRetry((java.util.Map<String, Object>) runtime_.get("retry"), _retryTimes, _now)) {
            if (_retryTimes > 0) {
                int backoffTime = Tea.getBackoffTime(runtime_.get("backoff"), _retryTimes);
                if (backoffTime > 0) {
                    Tea.sleep(backoffTime);
                }
            }
            _retryTimes = _retryTimes + 1;
            try {
                TeaRequest request_ = new TeaRequest();
                String accessKeyId = _credential.getAccessKeyId();
                String accessKeySecret = _credential.getAccessKeySecret();
                String token = _credential.getSecurityToken();
                request_.protocol = _protocol;
                request_.method = "GET";
                request_.pathname = "/" + request.channelName + "?live";
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("host", com.aliyun.ossutil.Client.getHost(request.bucketName, _regionId, _endpoint, _hostModel)),
                    new TeaPair("date", com.aliyun.teautil.Common.getDateUTCString()),
                    new TeaPair("user-agent", this.getUserAgent())
                );
                if (!com.aliyun.teautil.Common.empty(token)) {
                    request_.headers.put("x-oss-security-token", token);
                }

                request_.headers.put("authorization", com.aliyun.ossutil.Client.getSignature(request_, request.bucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                String bodyStr = null;
                if (com.aliyun.teautil.Common.is4xx(response_.statusCode) || com.aliyun.teautil.Common.is5xx(response_.statusCode)) {
                    bodyStr = com.aliyun.teautil.Common.readAsString(response_.body);
                    respMap = com.aliyun.ossutil.Client.getErrMessage(bodyStr);
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("code", respMap.get("Code")),
                        new TeaPair("message", respMap.get("Message")),
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("httpCode", response_.statusCode),
                            new TeaPair("requestId", respMap.get("RequestId")),
                            new TeaPair("hostId", respMap.get("HostId"))
                        ))
                    ));
                }

                bodyStr = com.aliyun.teautil.Common.readAsString(response_.body);
                respMap = com.aliyun.teaxml.Client.parseXml(bodyStr, GetLiveChannelInfoResponse.class);
                return TeaModel.toModel(TeaConverter.merge(Object.class,
                    TeaConverter.buildMap(
                        new TeaPair("LiveChannelConfiguration", respMap.get("LiveChannelConfiguration"))
                    ),
                    response_.headers
                ), new GetLiveChannelInfoResponse());
            } catch (Exception e) {
                if (Tea.isRetryable(e)) {
                    continue;
                }
                throw e;
            }
        }

        throw new TeaUnretryableException(_lastRequest);
    }

    public GetLiveChannelStatResponse getLiveChannelStat(GetLiveChannelStatRequest request, com.aliyun.ossutil.models.RuntimeOptions runtime) throws Exception {
        TeaModel.validateParams(request, "request");
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", com.aliyun.teautil.Common.defaultNumber(runtime.readTimeout, _readTimeout)),
            new TeaPair("connectTimeout", com.aliyun.teautil.Common.defaultNumber(runtime.connectTimeout, _connectTimeout)),
            new TeaPair("localAddr", com.aliyun.teautil.Common.defaultString(runtime.localAddr, _localAddr)),
            new TeaPair("httpProxy", com.aliyun.teautil.Common.defaultString(runtime.httpProxy, _httpProxy)),
            new TeaPair("httpsProxy", com.aliyun.teautil.Common.defaultString(runtime.httpsProxy, _httpsProxy)),
            new TeaPair("noProxy", com.aliyun.teautil.Common.defaultString(runtime.noProxy, _noProxy)),
            new TeaPair("socks5Proxy", com.aliyun.teautil.Common.defaultString(runtime.socks5Proxy, _socks5Proxy)),
            new TeaPair("socks5NetWork", com.aliyun.teautil.Common.defaultString(runtime.socks5NetWork, _socks5NetWork)),
            new TeaPair("maxIdleConns", com.aliyun.teautil.Common.defaultNumber(runtime.maxIdleConns, _maxIdleConns)),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", com.aliyun.teautil.Common.defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", com.aliyun.teautil.Common.defaultString(runtime.backoffPolicy, "no")),
                new TeaPair("period", com.aliyun.teautil.Common.defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL)
        );

        TeaRequest _lastRequest = null;
        long _now = System.currentTimeMillis();
        int _retryTimes = 0;
        while (Tea.allowRetry((java.util.Map<String, Object>) runtime_.get("retry"), _retryTimes, _now)) {
            if (_retryTimes > 0) {
                int backoffTime = Tea.getBackoffTime(runtime_.get("backoff"), _retryTimes);
                if (backoffTime > 0) {
                    Tea.sleep(backoffTime);
                }
            }
            _retryTimes = _retryTimes + 1;
            try {
                TeaRequest request_ = new TeaRequest();
                String accessKeyId = _credential.getAccessKeyId();
                String accessKeySecret = _credential.getAccessKeySecret();
                String token = _credential.getSecurityToken();
                request_.protocol = _protocol;
                request_.method = "GET";
                request_.pathname = "/" + request.channelName + "?live";
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("host", com.aliyun.ossutil.Client.getHost(request.bucketName, _regionId, _endpoint, _hostModel)),
                    new TeaPair("date", com.aliyun.teautil.Common.getDateUTCString()),
                    new TeaPair("user-agent", this.getUserAgent())
                );
                if (!com.aliyun.teautil.Common.empty(token)) {
                    request_.headers.put("x-oss-security-token", token);
                }

                request_.query = com.aliyun.teautil.Common.stringifyMapValue(TeaModel.buildMap(request.filter));
                request_.headers.put("authorization", com.aliyun.ossutil.Client.getSignature(request_, request.bucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                String bodyStr = null;
                if (com.aliyun.teautil.Common.is4xx(response_.statusCode) || com.aliyun.teautil.Common.is5xx(response_.statusCode)) {
                    bodyStr = com.aliyun.teautil.Common.readAsString(response_.body);
                    respMap = com.aliyun.ossutil.Client.getErrMessage(bodyStr);
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("code", respMap.get("Code")),
                        new TeaPair("message", respMap.get("Message")),
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("httpCode", response_.statusCode),
                            new TeaPair("requestId", respMap.get("RequestId")),
                            new TeaPair("hostId", respMap.get("HostId"))
                        ))
                    ));
                }

                bodyStr = com.aliyun.teautil.Common.readAsString(response_.body);
                respMap = com.aliyun.teaxml.Client.parseXml(bodyStr, GetLiveChannelStatResponse.class);
                return TeaModel.toModel(TeaConverter.merge(Object.class,
                    TeaConverter.buildMap(
                        new TeaPair("LiveChannelStat", respMap.get("LiveChannelStat"))
                    ),
                    response_.headers
                ), new GetLiveChannelStatResponse());
            } catch (Exception e) {
                if (Tea.isRetryable(e)) {
                    continue;
                }
                throw e;
            }
        }

        throw new TeaUnretryableException(_lastRequest);
    }

    public DeleteObjectResponse deleteObject(DeleteObjectRequest request, com.aliyun.ossutil.models.RuntimeOptions runtime) throws Exception {
        TeaModel.validateParams(request, "request");
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", com.aliyun.teautil.Common.defaultNumber(runtime.readTimeout, _readTimeout)),
            new TeaPair("connectTimeout", com.aliyun.teautil.Common.defaultNumber(runtime.connectTimeout, _connectTimeout)),
            new TeaPair("localAddr", com.aliyun.teautil.Common.defaultString(runtime.localAddr, _localAddr)),
            new TeaPair("httpProxy", com.aliyun.teautil.Common.defaultString(runtime.httpProxy, _httpProxy)),
            new TeaPair("httpsProxy", com.aliyun.teautil.Common.defaultString(runtime.httpsProxy, _httpsProxy)),
            new TeaPair("noProxy", com.aliyun.teautil.Common.defaultString(runtime.noProxy, _noProxy)),
            new TeaPair("socks5Proxy", com.aliyun.teautil.Common.defaultString(runtime.socks5Proxy, _socks5Proxy)),
            new TeaPair("socks5NetWork", com.aliyun.teautil.Common.defaultString(runtime.socks5NetWork, _socks5NetWork)),
            new TeaPair("maxIdleConns", com.aliyun.teautil.Common.defaultNumber(runtime.maxIdleConns, _maxIdleConns)),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", com.aliyun.teautil.Common.defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", com.aliyun.teautil.Common.defaultString(runtime.backoffPolicy, "no")),
                new TeaPair("period", com.aliyun.teautil.Common.defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL)
        );

        TeaRequest _lastRequest = null;
        long _now = System.currentTimeMillis();
        int _retryTimes = 0;
        while (Tea.allowRetry((java.util.Map<String, Object>) runtime_.get("retry"), _retryTimes, _now)) {
            if (_retryTimes > 0) {
                int backoffTime = Tea.getBackoffTime(runtime_.get("backoff"), _retryTimes);
                if (backoffTime > 0) {
                    Tea.sleep(backoffTime);
                }
            }
            _retryTimes = _retryTimes + 1;
            try {
                TeaRequest request_ = new TeaRequest();
                String accessKeyId = _credential.getAccessKeyId();
                String accessKeySecret = _credential.getAccessKeySecret();
                String token = _credential.getSecurityToken();
                request_.protocol = _protocol;
                request_.method = "DELETE";
                request_.pathname = "/" + request.objectName + "";
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("host", com.aliyun.ossutil.Client.getHost(request.bucketName, _regionId, _endpoint, _hostModel)),
                    new TeaPair("date", com.aliyun.teautil.Common.getDateUTCString()),
                    new TeaPair("user-agent", this.getUserAgent())
                );
                if (!com.aliyun.teautil.Common.empty(token)) {
                    request_.headers.put("x-oss-security-token", token);
                }

                request_.headers.put("authorization", com.aliyun.ossutil.Client.getSignature(request_, request.bucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                String bodyStr = null;
                if (com.aliyun.teautil.Common.is4xx(response_.statusCode) || com.aliyun.teautil.Common.is5xx(response_.statusCode)) {
                    bodyStr = com.aliyun.teautil.Common.readAsString(response_.body);
                    respMap = com.aliyun.ossutil.Client.getErrMessage(bodyStr);
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("code", respMap.get("Code")),
                        new TeaPair("message", respMap.get("Message")),
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("httpCode", response_.statusCode),
                            new TeaPair("requestId", respMap.get("RequestId")),
                            new TeaPair("hostId", respMap.get("HostId"))
                        ))
                    ));
                }

                return TeaModel.toModel(TeaConverter.merge(String.class,
                    response_.headers
                ), new DeleteObjectResponse());
            } catch (Exception e) {
                if (Tea.isRetryable(e)) {
                    continue;
                }
                throw e;
            }
        }

        throw new TeaUnretryableException(_lastRequest);
    }

    public AbortMultipartUploadResponse abortMultipartUpload(AbortMultipartUploadRequest request, com.aliyun.ossutil.models.RuntimeOptions runtime) throws Exception {
        TeaModel.validateParams(request, "request");
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", com.aliyun.teautil.Common.defaultNumber(runtime.readTimeout, _readTimeout)),
            new TeaPair("connectTimeout", com.aliyun.teautil.Common.defaultNumber(runtime.connectTimeout, _connectTimeout)),
            new TeaPair("localAddr", com.aliyun.teautil.Common.defaultString(runtime.localAddr, _localAddr)),
            new TeaPair("httpProxy", com.aliyun.teautil.Common.defaultString(runtime.httpProxy, _httpProxy)),
            new TeaPair("httpsProxy", com.aliyun.teautil.Common.defaultString(runtime.httpsProxy, _httpsProxy)),
            new TeaPair("noProxy", com.aliyun.teautil.Common.defaultString(runtime.noProxy, _noProxy)),
            new TeaPair("socks5Proxy", com.aliyun.teautil.Common.defaultString(runtime.socks5Proxy, _socks5Proxy)),
            new TeaPair("socks5NetWork", com.aliyun.teautil.Common.defaultString(runtime.socks5NetWork, _socks5NetWork)),
            new TeaPair("maxIdleConns", com.aliyun.teautil.Common.defaultNumber(runtime.maxIdleConns, _maxIdleConns)),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", com.aliyun.teautil.Common.defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", com.aliyun.teautil.Common.defaultString(runtime.backoffPolicy, "no")),
                new TeaPair("period", com.aliyun.teautil.Common.defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL)
        );

        TeaRequest _lastRequest = null;
        long _now = System.currentTimeMillis();
        int _retryTimes = 0;
        while (Tea.allowRetry((java.util.Map<String, Object>) runtime_.get("retry"), _retryTimes, _now)) {
            if (_retryTimes > 0) {
                int backoffTime = Tea.getBackoffTime(runtime_.get("backoff"), _retryTimes);
                if (backoffTime > 0) {
                    Tea.sleep(backoffTime);
                }
            }
            _retryTimes = _retryTimes + 1;
            try {
                TeaRequest request_ = new TeaRequest();
                String accessKeyId = _credential.getAccessKeyId();
                String accessKeySecret = _credential.getAccessKeySecret();
                String token = _credential.getSecurityToken();
                request_.protocol = _protocol;
                request_.method = "DELETE";
                request_.pathname = "/" + request.objectName + "";
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("host", com.aliyun.ossutil.Client.getHost(request.bucketName, _regionId, _endpoint, _hostModel)),
                    new TeaPair("date", com.aliyun.teautil.Common.getDateUTCString()),
                    new TeaPair("user-agent", this.getUserAgent())
                );
                if (!com.aliyun.teautil.Common.empty(token)) {
                    request_.headers.put("x-oss-security-token", token);
                }

                request_.query = com.aliyun.teautil.Common.stringifyMapValue(TeaModel.buildMap(request.filter));
                request_.headers.put("authorization", com.aliyun.ossutil.Client.getSignature(request_, request.bucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                String bodyStr = null;
                if (com.aliyun.teautil.Common.is4xx(response_.statusCode) || com.aliyun.teautil.Common.is5xx(response_.statusCode)) {
                    bodyStr = com.aliyun.teautil.Common.readAsString(response_.body);
                    respMap = com.aliyun.ossutil.Client.getErrMessage(bodyStr);
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("code", respMap.get("Code")),
                        new TeaPair("message", respMap.get("Message")),
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("httpCode", response_.statusCode),
                            new TeaPair("requestId", respMap.get("RequestId")),
                            new TeaPair("hostId", respMap.get("HostId"))
                        ))
                    ));
                }

                return TeaModel.toModel(TeaConverter.merge(String.class,
                    response_.headers
                ), new AbortMultipartUploadResponse());
            } catch (Exception e) {
                if (Tea.isRetryable(e)) {
                    continue;
                }
                throw e;
            }
        }

        throw new TeaUnretryableException(_lastRequest);
    }

    public AppendObjectResponse appendObject(AppendObjectRequest request, com.aliyun.ossutil.models.RuntimeOptions runtime) throws Exception {
        TeaModel.validateParams(request, "request");
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", com.aliyun.teautil.Common.defaultNumber(runtime.readTimeout, _readTimeout)),
            new TeaPair("connectTimeout", com.aliyun.teautil.Common.defaultNumber(runtime.connectTimeout, _connectTimeout)),
            new TeaPair("localAddr", com.aliyun.teautil.Common.defaultString(runtime.localAddr, _localAddr)),
            new TeaPair("httpProxy", com.aliyun.teautil.Common.defaultString(runtime.httpProxy, _httpProxy)),
            new TeaPair("httpsProxy", com.aliyun.teautil.Common.defaultString(runtime.httpsProxy, _httpsProxy)),
            new TeaPair("noProxy", com.aliyun.teautil.Common.defaultString(runtime.noProxy, _noProxy)),
            new TeaPair("socks5Proxy", com.aliyun.teautil.Common.defaultString(runtime.socks5Proxy, _socks5Proxy)),
            new TeaPair("socks5NetWork", com.aliyun.teautil.Common.defaultString(runtime.socks5NetWork, _socks5NetWork)),
            new TeaPair("maxIdleConns", com.aliyun.teautil.Common.defaultNumber(runtime.maxIdleConns, _maxIdleConns)),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", com.aliyun.teautil.Common.defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", com.aliyun.teautil.Common.defaultString(runtime.backoffPolicy, "no")),
                new TeaPair("period", com.aliyun.teautil.Common.defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL)
        );

        TeaRequest _lastRequest = null;
        long _now = System.currentTimeMillis();
        int _retryTimes = 0;
        while (Tea.allowRetry((java.util.Map<String, Object>) runtime_.get("retry"), _retryTimes, _now)) {
            if (_retryTimes > 0) {
                int backoffTime = Tea.getBackoffTime(runtime_.get("backoff"), _retryTimes);
                if (backoffTime > 0) {
                    Tea.sleep(backoffTime);
                }
            }
            _retryTimes = _retryTimes + 1;
            try {
                TeaRequest request_ = new TeaRequest();
                java.util.Map<String, String> ctx = new java.util.HashMap<>();
                String accessKeyId = _credential.getAccessKeyId();
                String accessKeySecret = _credential.getAccessKeySecret();
                String token = _credential.getSecurityToken();
                request_.protocol = _protocol;
                request_.method = "POST";
                request_.pathname = "/" + request.objectName + "?append";
                request_.headers = TeaConverter.merge(String.class,
                    TeaConverter.buildMap(
                        new TeaPair("host", com.aliyun.ossutil.Client.getHost(request.bucketName, _regionId, _endpoint, _hostModel)),
                        new TeaPair("date", com.aliyun.teautil.Common.getDateUTCString()),
                        new TeaPair("user-agent", this.getUserAgent())
                    ),
                    com.aliyun.teautil.Common.stringifyMapValue(TeaModel.buildMap(request.header)),
                    com.aliyun.ossutil.Client.parseMeta(request.userMeta, "x-oss-meta-")
                );
                if (!com.aliyun.teautil.Common.empty(token)) {
                    request_.headers.put("x-oss-security-token", token);
                }

                request_.query = com.aliyun.teautil.Common.stringifyMapValue(TeaModel.buildMap(request.filter));
                request_.body = com.aliyun.ossutil.Client.inject(request.body, ctx);
                if (com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.header)) && !com.aliyun.teautil.Common.empty(request.header.contentType)) {
                    request_.headers.put("content-type", request.header.contentType);
                } else {
                    request_.headers.put("content-type", com.aliyun.ossutil.Client.getContentType(request.objectName));
                }

                request_.headers.put("authorization", com.aliyun.ossutil.Client.getSignature(request_, request.bucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                String bodyStr = null;
                if (com.aliyun.teautil.Common.is4xx(response_.statusCode) || com.aliyun.teautil.Common.is5xx(response_.statusCode)) {
                    bodyStr = com.aliyun.teautil.Common.readAsString(response_.body);
                    respMap = com.aliyun.ossutil.Client.getErrMessage(bodyStr);
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("code", respMap.get("Code")),
                        new TeaPair("message", respMap.get("Message")),
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("httpCode", response_.statusCode),
                            new TeaPair("requestId", respMap.get("RequestId")),
                            new TeaPair("hostId", respMap.get("HostId"))
                        ))
                    ));
                }

                if (_isEnableCrc && !com.aliyun.teautil.Common.equalString(ctx.get("crc"), response_.headers.get("x-oss-hash-crc64ecma"))) {
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("code", "CrcNotMatched"),
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("clientCrc", ctx.get("crc")),
                            new TeaPair("serverCrc", response_.headers.get("x-oss-hash-crc64ecma"))
                        ))
                    ));
                }

                if (_isEnableMD5 && !com.aliyun.teautil.Common.equalString(ctx.get("md5"), response_.headers.get("content-md5"))) {
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("code", "MD5NotMatched"),
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("clientMD5", ctx.get("md5")),
                            new TeaPair("serverMD5", response_.headers.get("content-md5"))
                        ))
                    ));
                }

                return TeaModel.toModel(TeaConverter.merge(String.class,
                    response_.headers
                ), new AppendObjectResponse());
            } catch (Exception e) {
                if (Tea.isRetryable(e)) {
                    continue;
                }
                throw e;
            }
        }

        throw new TeaUnretryableException(_lastRequest);
    }

    public UploadPartCopyResponse uploadPartCopy(UploadPartCopyRequest request, com.aliyun.ossutil.models.RuntimeOptions runtime) throws Exception {
        TeaModel.validateParams(request, "request");
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", com.aliyun.teautil.Common.defaultNumber(runtime.readTimeout, _readTimeout)),
            new TeaPair("connectTimeout", com.aliyun.teautil.Common.defaultNumber(runtime.connectTimeout, _connectTimeout)),
            new TeaPair("localAddr", com.aliyun.teautil.Common.defaultString(runtime.localAddr, _localAddr)),
            new TeaPair("httpProxy", com.aliyun.teautil.Common.defaultString(runtime.httpProxy, _httpProxy)),
            new TeaPair("httpsProxy", com.aliyun.teautil.Common.defaultString(runtime.httpsProxy, _httpsProxy)),
            new TeaPair("noProxy", com.aliyun.teautil.Common.defaultString(runtime.noProxy, _noProxy)),
            new TeaPair("socks5Proxy", com.aliyun.teautil.Common.defaultString(runtime.socks5Proxy, _socks5Proxy)),
            new TeaPair("socks5NetWork", com.aliyun.teautil.Common.defaultString(runtime.socks5NetWork, _socks5NetWork)),
            new TeaPair("maxIdleConns", com.aliyun.teautil.Common.defaultNumber(runtime.maxIdleConns, _maxIdleConns)),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", com.aliyun.teautil.Common.defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", com.aliyun.teautil.Common.defaultString(runtime.backoffPolicy, "no")),
                new TeaPair("period", com.aliyun.teautil.Common.defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL)
        );

        TeaRequest _lastRequest = null;
        long _now = System.currentTimeMillis();
        int _retryTimes = 0;
        while (Tea.allowRetry((java.util.Map<String, Object>) runtime_.get("retry"), _retryTimes, _now)) {
            if (_retryTimes > 0) {
                int backoffTime = Tea.getBackoffTime(runtime_.get("backoff"), _retryTimes);
                if (backoffTime > 0) {
                    Tea.sleep(backoffTime);
                }
            }
            _retryTimes = _retryTimes + 1;
            try {
                TeaRequest request_ = new TeaRequest();
                String accessKeyId = _credential.getAccessKeyId();
                String accessKeySecret = _credential.getAccessKeySecret();
                String token = _credential.getSecurityToken();
                request_.protocol = _protocol;
                request_.method = "PUT";
                request_.pathname = "/" + request.objectName + "";
                request_.headers = TeaConverter.merge(String.class,
                    TeaConverter.buildMap(
                        new TeaPair("host", com.aliyun.ossutil.Client.getHost(request.bucketName, _regionId, _endpoint, _hostModel)),
                        new TeaPair("date", com.aliyun.teautil.Common.getDateUTCString()),
                        new TeaPair("user-agent", this.getUserAgent())
                    ),
                    com.aliyun.teautil.Common.stringifyMapValue(TeaModel.buildMap(request.header))
                );
                if (!com.aliyun.teautil.Common.empty(token)) {
                    request_.headers.put("x-oss-security-token", token);
                }

                request_.query = com.aliyun.teautil.Common.stringifyMapValue(TeaModel.buildMap(request.filter));
                request_.headers.put("authorization", com.aliyun.ossutil.Client.getSignature(request_, request.bucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                String bodyStr = null;
                if (com.aliyun.teautil.Common.is4xx(response_.statusCode) || com.aliyun.teautil.Common.is5xx(response_.statusCode)) {
                    bodyStr = com.aliyun.teautil.Common.readAsString(response_.body);
                    respMap = com.aliyun.ossutil.Client.getErrMessage(bodyStr);
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("code", respMap.get("Code")),
                        new TeaPair("message", respMap.get("Message")),
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("httpCode", response_.statusCode),
                            new TeaPair("requestId", respMap.get("RequestId")),
                            new TeaPair("hostId", respMap.get("HostId"))
                        ))
                    ));
                }

                bodyStr = com.aliyun.teautil.Common.readAsString(response_.body);
                respMap = com.aliyun.teaxml.Client.parseXml(bodyStr, UploadPartCopyResponse.class);
                return TeaModel.toModel(TeaConverter.merge(Object.class,
                    TeaConverter.buildMap(
                        new TeaPair("CopyPartResult", respMap.get("CopyPartResult"))
                    ),
                    response_.headers
                ), new UploadPartCopyResponse());
            } catch (Exception e) {
                if (Tea.isRetryable(e)) {
                    continue;
                }
                throw e;
            }
        }

        throw new TeaUnretryableException(_lastRequest);
    }

    public GetVodPlaylistResponse getVodPlaylist(GetVodPlaylistRequest request, com.aliyun.ossutil.models.RuntimeOptions runtime) throws Exception {
        TeaModel.validateParams(request, "request");
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", com.aliyun.teautil.Common.defaultNumber(runtime.readTimeout, _readTimeout)),
            new TeaPair("connectTimeout", com.aliyun.teautil.Common.defaultNumber(runtime.connectTimeout, _connectTimeout)),
            new TeaPair("localAddr", com.aliyun.teautil.Common.defaultString(runtime.localAddr, _localAddr)),
            new TeaPair("httpProxy", com.aliyun.teautil.Common.defaultString(runtime.httpProxy, _httpProxy)),
            new TeaPair("httpsProxy", com.aliyun.teautil.Common.defaultString(runtime.httpsProxy, _httpsProxy)),
            new TeaPair("noProxy", com.aliyun.teautil.Common.defaultString(runtime.noProxy, _noProxy)),
            new TeaPair("socks5Proxy", com.aliyun.teautil.Common.defaultString(runtime.socks5Proxy, _socks5Proxy)),
            new TeaPair("socks5NetWork", com.aliyun.teautil.Common.defaultString(runtime.socks5NetWork, _socks5NetWork)),
            new TeaPair("maxIdleConns", com.aliyun.teautil.Common.defaultNumber(runtime.maxIdleConns, _maxIdleConns)),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", com.aliyun.teautil.Common.defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", com.aliyun.teautil.Common.defaultString(runtime.backoffPolicy, "no")),
                new TeaPair("period", com.aliyun.teautil.Common.defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL)
        );

        TeaRequest _lastRequest = null;
        long _now = System.currentTimeMillis();
        int _retryTimes = 0;
        while (Tea.allowRetry((java.util.Map<String, Object>) runtime_.get("retry"), _retryTimes, _now)) {
            if (_retryTimes > 0) {
                int backoffTime = Tea.getBackoffTime(runtime_.get("backoff"), _retryTimes);
                if (backoffTime > 0) {
                    Tea.sleep(backoffTime);
                }
            }
            _retryTimes = _retryTimes + 1;
            try {
                TeaRequest request_ = new TeaRequest();
                String accessKeyId = _credential.getAccessKeyId();
                String accessKeySecret = _credential.getAccessKeySecret();
                String token = _credential.getSecurityToken();
                request_.protocol = _protocol;
                request_.method = "GET";
                request_.pathname = "/" + request.channelName + "?vod";
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("host", com.aliyun.ossutil.Client.getHost(request.bucketName, _regionId, _endpoint, _hostModel)),
                    new TeaPair("date", com.aliyun.teautil.Common.getDateUTCString()),
                    new TeaPair("user-agent", this.getUserAgent())
                );
                if (!com.aliyun.teautil.Common.empty(token)) {
                    request_.headers.put("x-oss-security-token", token);
                }

                request_.query = com.aliyun.teautil.Common.stringifyMapValue(TeaModel.buildMap(request.filter));
                request_.headers.put("authorization", com.aliyun.ossutil.Client.getSignature(request_, request.bucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                String bodyStr = null;
                if (com.aliyun.teautil.Common.is4xx(response_.statusCode) || com.aliyun.teautil.Common.is5xx(response_.statusCode)) {
                    bodyStr = com.aliyun.teautil.Common.readAsString(response_.body);
                    respMap = com.aliyun.ossutil.Client.getErrMessage(bodyStr);
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("code", respMap.get("Code")),
                        new TeaPair("message", respMap.get("Message")),
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("httpCode", response_.statusCode),
                            new TeaPair("requestId", respMap.get("RequestId")),
                            new TeaPair("hostId", respMap.get("HostId"))
                        ))
                    ));
                }

                return TeaModel.toModel(TeaConverter.merge(String.class,
                    response_.headers
                ), new GetVodPlaylistResponse());
            } catch (Exception e) {
                if (Tea.isRetryable(e)) {
                    continue;
                }
                throw e;
            }
        }

        throw new TeaUnretryableException(_lastRequest);
    }

    public DeleteBucketCORSResponse deleteBucketCORS(DeleteBucketCORSRequest request, com.aliyun.ossutil.models.RuntimeOptions runtime) throws Exception {
        TeaModel.validateParams(request, "request");
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", com.aliyun.teautil.Common.defaultNumber(runtime.readTimeout, _readTimeout)),
            new TeaPair("connectTimeout", com.aliyun.teautil.Common.defaultNumber(runtime.connectTimeout, _connectTimeout)),
            new TeaPair("localAddr", com.aliyun.teautil.Common.defaultString(runtime.localAddr, _localAddr)),
            new TeaPair("httpProxy", com.aliyun.teautil.Common.defaultString(runtime.httpProxy, _httpProxy)),
            new TeaPair("httpsProxy", com.aliyun.teautil.Common.defaultString(runtime.httpsProxy, _httpsProxy)),
            new TeaPair("noProxy", com.aliyun.teautil.Common.defaultString(runtime.noProxy, _noProxy)),
            new TeaPair("socks5Proxy", com.aliyun.teautil.Common.defaultString(runtime.socks5Proxy, _socks5Proxy)),
            new TeaPair("socks5NetWork", com.aliyun.teautil.Common.defaultString(runtime.socks5NetWork, _socks5NetWork)),
            new TeaPair("maxIdleConns", com.aliyun.teautil.Common.defaultNumber(runtime.maxIdleConns, _maxIdleConns)),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", com.aliyun.teautil.Common.defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", com.aliyun.teautil.Common.defaultString(runtime.backoffPolicy, "no")),
                new TeaPair("period", com.aliyun.teautil.Common.defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL)
        );

        TeaRequest _lastRequest = null;
        long _now = System.currentTimeMillis();
        int _retryTimes = 0;
        while (Tea.allowRetry((java.util.Map<String, Object>) runtime_.get("retry"), _retryTimes, _now)) {
            if (_retryTimes > 0) {
                int backoffTime = Tea.getBackoffTime(runtime_.get("backoff"), _retryTimes);
                if (backoffTime > 0) {
                    Tea.sleep(backoffTime);
                }
            }
            _retryTimes = _retryTimes + 1;
            try {
                TeaRequest request_ = new TeaRequest();
                String accessKeyId = _credential.getAccessKeyId();
                String accessKeySecret = _credential.getAccessKeySecret();
                String token = _credential.getSecurityToken();
                request_.protocol = _protocol;
                request_.method = "DELETE";
                request_.pathname = "/?cors";
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("host", com.aliyun.ossutil.Client.getHost(request.bucketName, _regionId, _endpoint, _hostModel)),
                    new TeaPair("date", com.aliyun.teautil.Common.getDateUTCString()),
                    new TeaPair("user-agent", this.getUserAgent())
                );
                if (!com.aliyun.teautil.Common.empty(token)) {
                    request_.headers.put("x-oss-security-token", token);
                }

                request_.headers.put("authorization", com.aliyun.ossutil.Client.getSignature(request_, request.bucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                String bodyStr = null;
                if (com.aliyun.teautil.Common.is4xx(response_.statusCode) || com.aliyun.teautil.Common.is5xx(response_.statusCode)) {
                    bodyStr = com.aliyun.teautil.Common.readAsString(response_.body);
                    respMap = com.aliyun.ossutil.Client.getErrMessage(bodyStr);
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("code", respMap.get("Code")),
                        new TeaPair("message", respMap.get("Message")),
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("httpCode", response_.statusCode),
                            new TeaPair("requestId", respMap.get("RequestId")),
                            new TeaPair("hostId", respMap.get("HostId"))
                        ))
                    ));
                }

                return TeaModel.toModel(TeaConverter.merge(String.class,
                    response_.headers
                ), new DeleteBucketCORSResponse());
            } catch (Exception e) {
                if (Tea.isRetryable(e)) {
                    continue;
                }
                throw e;
            }
        }

        throw new TeaUnretryableException(_lastRequest);
    }

    public GetObjectResponse getObject(GetObjectRequest request, com.aliyun.ossutil.models.RuntimeOptions runtime) throws Exception {
        TeaModel.validateParams(request, "request");
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", com.aliyun.teautil.Common.defaultNumber(runtime.readTimeout, _readTimeout)),
            new TeaPair("connectTimeout", com.aliyun.teautil.Common.defaultNumber(runtime.connectTimeout, _connectTimeout)),
            new TeaPair("localAddr", com.aliyun.teautil.Common.defaultString(runtime.localAddr, _localAddr)),
            new TeaPair("httpProxy", com.aliyun.teautil.Common.defaultString(runtime.httpProxy, _httpProxy)),
            new TeaPair("httpsProxy", com.aliyun.teautil.Common.defaultString(runtime.httpsProxy, _httpsProxy)),
            new TeaPair("noProxy", com.aliyun.teautil.Common.defaultString(runtime.noProxy, _noProxy)),
            new TeaPair("socks5Proxy", com.aliyun.teautil.Common.defaultString(runtime.socks5Proxy, _socks5Proxy)),
            new TeaPair("socks5NetWork", com.aliyun.teautil.Common.defaultString(runtime.socks5NetWork, _socks5NetWork)),
            new TeaPair("maxIdleConns", com.aliyun.teautil.Common.defaultNumber(runtime.maxIdleConns, _maxIdleConns)),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", com.aliyun.teautil.Common.defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", com.aliyun.teautil.Common.defaultString(runtime.backoffPolicy, "no")),
                new TeaPair("period", com.aliyun.teautil.Common.defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL)
        );

        TeaRequest _lastRequest = null;
        long _now = System.currentTimeMillis();
        int _retryTimes = 0;
        while (Tea.allowRetry((java.util.Map<String, Object>) runtime_.get("retry"), _retryTimes, _now)) {
            if (_retryTimes > 0) {
                int backoffTime = Tea.getBackoffTime(runtime_.get("backoff"), _retryTimes);
                if (backoffTime > 0) {
                    Tea.sleep(backoffTime);
                }
            }
            _retryTimes = _retryTimes + 1;
            try {
                TeaRequest request_ = new TeaRequest();
                String accessKeyId = _credential.getAccessKeyId();
                String accessKeySecret = _credential.getAccessKeySecret();
                String token = _credential.getSecurityToken();
                request_.protocol = _protocol;
                request_.method = "GET";
                request_.pathname = "/" + request.objectName + "";
                request_.headers = TeaConverter.merge(String.class,
                    TeaConverter.buildMap(
                        new TeaPair("host", com.aliyun.ossutil.Client.getHost(request.bucketName, _regionId, _endpoint, _hostModel)),
                        new TeaPair("date", com.aliyun.teautil.Common.getDateUTCString()),
                        new TeaPair("user-agent", this.getUserAgent())
                    ),
                    com.aliyun.teautil.Common.stringifyMapValue(TeaModel.buildMap(request.header))
                );
                if (!com.aliyun.teautil.Common.empty(token)) {
                    request_.headers.put("x-oss-security-token", token);
                }

                request_.headers.put("authorization", com.aliyun.ossutil.Client.getSignature(request_, request.bucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                String bodyStr = null;
                if (com.aliyun.teautil.Common.is4xx(response_.statusCode) || com.aliyun.teautil.Common.is5xx(response_.statusCode)) {
                    bodyStr = com.aliyun.teautil.Common.readAsString(response_.body);
                    respMap = com.aliyun.ossutil.Client.getErrMessage(bodyStr);
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("code", respMap.get("Code")),
                        new TeaPair("message", respMap.get("Message")),
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("httpCode", response_.statusCode),
                            new TeaPair("requestId", respMap.get("RequestId")),
                            new TeaPair("hostId", respMap.get("HostId"))
                        ))
                    ));
                }

                return TeaModel.toModel(TeaConverter.merge(Object.class,
                    TeaConverter.buildMap(
                        new TeaPair("body", response_.body)
                    ),
                    response_.headers
                ), new GetObjectResponse());
            } catch (Exception e) {
                if (Tea.isRetryable(e)) {
                    continue;
                }
                throw e;
            }
        }

        throw new TeaUnretryableException(_lastRequest);
    }

    public UploadPartResponse uploadPart(UploadPartRequest request, com.aliyun.ossutil.models.RuntimeOptions runtime) throws Exception {
        TeaModel.validateParams(request, "request");
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", com.aliyun.teautil.Common.defaultNumber(runtime.readTimeout, _readTimeout)),
            new TeaPair("connectTimeout", com.aliyun.teautil.Common.defaultNumber(runtime.connectTimeout, _connectTimeout)),
            new TeaPair("localAddr", com.aliyun.teautil.Common.defaultString(runtime.localAddr, _localAddr)),
            new TeaPair("httpProxy", com.aliyun.teautil.Common.defaultString(runtime.httpProxy, _httpProxy)),
            new TeaPair("httpsProxy", com.aliyun.teautil.Common.defaultString(runtime.httpsProxy, _httpsProxy)),
            new TeaPair("noProxy", com.aliyun.teautil.Common.defaultString(runtime.noProxy, _noProxy)),
            new TeaPair("socks5Proxy", com.aliyun.teautil.Common.defaultString(runtime.socks5Proxy, _socks5Proxy)),
            new TeaPair("socks5NetWork", com.aliyun.teautil.Common.defaultString(runtime.socks5NetWork, _socks5NetWork)),
            new TeaPair("maxIdleConns", com.aliyun.teautil.Common.defaultNumber(runtime.maxIdleConns, _maxIdleConns)),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", com.aliyun.teautil.Common.defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", com.aliyun.teautil.Common.defaultString(runtime.backoffPolicy, "no")),
                new TeaPair("period", com.aliyun.teautil.Common.defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL)
        );

        TeaRequest _lastRequest = null;
        long _now = System.currentTimeMillis();
        int _retryTimes = 0;
        while (Tea.allowRetry((java.util.Map<String, Object>) runtime_.get("retry"), _retryTimes, _now)) {
            if (_retryTimes > 0) {
                int backoffTime = Tea.getBackoffTime(runtime_.get("backoff"), _retryTimes);
                if (backoffTime > 0) {
                    Tea.sleep(backoffTime);
                }
            }
            _retryTimes = _retryTimes + 1;
            try {
                TeaRequest request_ = new TeaRequest();
                java.util.Map<String, String> ctx = new java.util.HashMap<>();
                String accessKeyId = _credential.getAccessKeyId();
                String accessKeySecret = _credential.getAccessKeySecret();
                String token = _credential.getSecurityToken();
                request_.protocol = _protocol;
                request_.method = "PUT";
                request_.pathname = "/" + request.objectName + "";
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("host", com.aliyun.ossutil.Client.getHost(request.bucketName, _regionId, _endpoint, _hostModel)),
                    new TeaPair("date", com.aliyun.teautil.Common.getDateUTCString()),
                    new TeaPair("user-agent", this.getUserAgent())
                );
                if (!com.aliyun.teautil.Common.empty(token)) {
                    request_.headers.put("x-oss-security-token", token);
                }

                request_.query = com.aliyun.teautil.Common.stringifyMapValue(TeaModel.buildMap(request.filter));
                request_.body = com.aliyun.ossutil.Client.inject(request.body, ctx);
                request_.headers.put("authorization", com.aliyun.ossutil.Client.getSignature(request_, request.bucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                String bodyStr = null;
                if (com.aliyun.teautil.Common.is4xx(response_.statusCode) || com.aliyun.teautil.Common.is5xx(response_.statusCode)) {
                    bodyStr = com.aliyun.teautil.Common.readAsString(response_.body);
                    respMap = com.aliyun.ossutil.Client.getErrMessage(bodyStr);
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("code", respMap.get("Code")),
                        new TeaPair("message", respMap.get("Message")),
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("httpCode", response_.statusCode),
                            new TeaPair("requestId", respMap.get("RequestId")),
                            new TeaPair("hostId", respMap.get("HostId"))
                        ))
                    ));
                }

                if (_isEnableCrc && !com.aliyun.teautil.Common.equalString(ctx.get("crc"), response_.headers.get("x-oss-hash-crc64ecma"))) {
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("code", "CrcNotMatched"),
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("clientCrc", ctx.get("crc")),
                            new TeaPair("serverCrc", response_.headers.get("x-oss-hash-crc64ecma"))
                        ))
                    ));
                }

                if (_isEnableMD5 && !com.aliyun.teautil.Common.equalString(ctx.get("md5"), response_.headers.get("content-md5"))) {
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("code", "MD5NotMatched"),
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("clientMD5", ctx.get("md5")),
                            new TeaPair("serverMD5", response_.headers.get("content-md5"))
                        ))
                    ));
                }

                return TeaModel.toModel(TeaConverter.merge(String.class,
                    response_.headers
                ), new UploadPartResponse());
            } catch (Exception e) {
                if (Tea.isRetryable(e)) {
                    continue;
                }
                throw e;
            }
        }

        throw new TeaUnretryableException(_lastRequest);
    }

    public GetBucketCORSResponse getBucketCORS(GetBucketCORSRequest request, com.aliyun.ossutil.models.RuntimeOptions runtime) throws Exception {
        TeaModel.validateParams(request, "request");
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", com.aliyun.teautil.Common.defaultNumber(runtime.readTimeout, _readTimeout)),
            new TeaPair("connectTimeout", com.aliyun.teautil.Common.defaultNumber(runtime.connectTimeout, _connectTimeout)),
            new TeaPair("localAddr", com.aliyun.teautil.Common.defaultString(runtime.localAddr, _localAddr)),
            new TeaPair("httpProxy", com.aliyun.teautil.Common.defaultString(runtime.httpProxy, _httpProxy)),
            new TeaPair("httpsProxy", com.aliyun.teautil.Common.defaultString(runtime.httpsProxy, _httpsProxy)),
            new TeaPair("noProxy", com.aliyun.teautil.Common.defaultString(runtime.noProxy, _noProxy)),
            new TeaPair("socks5Proxy", com.aliyun.teautil.Common.defaultString(runtime.socks5Proxy, _socks5Proxy)),
            new TeaPair("socks5NetWork", com.aliyun.teautil.Common.defaultString(runtime.socks5NetWork, _socks5NetWork)),
            new TeaPair("maxIdleConns", com.aliyun.teautil.Common.defaultNumber(runtime.maxIdleConns, _maxIdleConns)),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", com.aliyun.teautil.Common.defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", com.aliyun.teautil.Common.defaultString(runtime.backoffPolicy, "no")),
                new TeaPair("period", com.aliyun.teautil.Common.defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL)
        );

        TeaRequest _lastRequest = null;
        long _now = System.currentTimeMillis();
        int _retryTimes = 0;
        while (Tea.allowRetry((java.util.Map<String, Object>) runtime_.get("retry"), _retryTimes, _now)) {
            if (_retryTimes > 0) {
                int backoffTime = Tea.getBackoffTime(runtime_.get("backoff"), _retryTimes);
                if (backoffTime > 0) {
                    Tea.sleep(backoffTime);
                }
            }
            _retryTimes = _retryTimes + 1;
            try {
                TeaRequest request_ = new TeaRequest();
                String accessKeyId = _credential.getAccessKeyId();
                String accessKeySecret = _credential.getAccessKeySecret();
                String token = _credential.getSecurityToken();
                request_.protocol = _protocol;
                request_.method = "GET";
                request_.pathname = "/?cors";
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("host", com.aliyun.ossutil.Client.getHost(request.bucketName, _regionId, _endpoint, _hostModel)),
                    new TeaPair("date", com.aliyun.teautil.Common.getDateUTCString()),
                    new TeaPair("user-agent", this.getUserAgent())
                );
                if (!com.aliyun.teautil.Common.empty(token)) {
                    request_.headers.put("x-oss-security-token", token);
                }

                request_.headers.put("authorization", com.aliyun.ossutil.Client.getSignature(request_, request.bucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                String bodyStr = null;
                if (com.aliyun.teautil.Common.is4xx(response_.statusCode) || com.aliyun.teautil.Common.is5xx(response_.statusCode)) {
                    bodyStr = com.aliyun.teautil.Common.readAsString(response_.body);
                    respMap = com.aliyun.ossutil.Client.getErrMessage(bodyStr);
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("code", respMap.get("Code")),
                        new TeaPair("message", respMap.get("Message")),
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("httpCode", response_.statusCode),
                            new TeaPair("requestId", respMap.get("RequestId")),
                            new TeaPair("hostId", respMap.get("HostId"))
                        ))
                    ));
                }

                bodyStr = com.aliyun.teautil.Common.readAsString(response_.body);
                respMap = com.aliyun.teaxml.Client.parseXml(bodyStr, GetBucketCORSResponse.class);
                return TeaModel.toModel(TeaConverter.merge(Object.class,
                    TeaConverter.buildMap(
                        new TeaPair("CORSConfiguration", respMap.get("CORSConfiguration"))
                    ),
                    response_.headers
                ), new GetBucketCORSResponse());
            } catch (Exception e) {
                if (Tea.isRetryable(e)) {
                    continue;
                }
                throw e;
            }
        }

        throw new TeaUnretryableException(_lastRequest);
    }

    public CopyObjectResponse copyObject(CopyObjectRequest request, com.aliyun.ossutil.models.RuntimeOptions runtime) throws Exception {
        TeaModel.validateParams(request, "request");
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", com.aliyun.teautil.Common.defaultNumber(runtime.readTimeout, _readTimeout)),
            new TeaPair("connectTimeout", com.aliyun.teautil.Common.defaultNumber(runtime.connectTimeout, _connectTimeout)),
            new TeaPair("localAddr", com.aliyun.teautil.Common.defaultString(runtime.localAddr, _localAddr)),
            new TeaPair("httpProxy", com.aliyun.teautil.Common.defaultString(runtime.httpProxy, _httpProxy)),
            new TeaPair("httpsProxy", com.aliyun.teautil.Common.defaultString(runtime.httpsProxy, _httpsProxy)),
            new TeaPair("noProxy", com.aliyun.teautil.Common.defaultString(runtime.noProxy, _noProxy)),
            new TeaPair("socks5Proxy", com.aliyun.teautil.Common.defaultString(runtime.socks5Proxy, _socks5Proxy)),
            new TeaPair("socks5NetWork", com.aliyun.teautil.Common.defaultString(runtime.socks5NetWork, _socks5NetWork)),
            new TeaPair("maxIdleConns", com.aliyun.teautil.Common.defaultNumber(runtime.maxIdleConns, _maxIdleConns)),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", com.aliyun.teautil.Common.defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", com.aliyun.teautil.Common.defaultString(runtime.backoffPolicy, "no")),
                new TeaPair("period", com.aliyun.teautil.Common.defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL)
        );

        TeaRequest _lastRequest = null;
        long _now = System.currentTimeMillis();
        int _retryTimes = 0;
        while (Tea.allowRetry((java.util.Map<String, Object>) runtime_.get("retry"), _retryTimes, _now)) {
            if (_retryTimes > 0) {
                int backoffTime = Tea.getBackoffTime(runtime_.get("backoff"), _retryTimes);
                if (backoffTime > 0) {
                    Tea.sleep(backoffTime);
                }
            }
            _retryTimes = _retryTimes + 1;
            try {
                TeaRequest request_ = new TeaRequest();
                String accessKeyId = _credential.getAccessKeyId();
                String accessKeySecret = _credential.getAccessKeySecret();
                String token = _credential.getSecurityToken();
                request_.protocol = _protocol;
                request_.method = "PUT";
                request_.pathname = "/" + request.destObjectName + "";
                request_.headers = TeaConverter.merge(String.class,
                    TeaConverter.buildMap(
                        new TeaPair("host", com.aliyun.ossutil.Client.getHost(request.bucketName, _regionId, _endpoint, _hostModel)),
                        new TeaPair("date", com.aliyun.teautil.Common.getDateUTCString()),
                        new TeaPair("user-agent", this.getUserAgent())
                    ),
                    com.aliyun.teautil.Common.stringifyMapValue(TeaModel.buildMap(request.header))
                );
                if (!com.aliyun.teautil.Common.empty(token)) {
                    request_.headers.put("x-oss-security-token", token);
                }

                request_.headers.put("x-oss-copy-source", com.aliyun.ossutil.Client.encode(request_.headers.get("x-oss-copy-source"), "UrlEncode"));
                request_.headers.put("authorization", com.aliyun.ossutil.Client.getSignature(request_, request.bucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                String bodyStr = null;
                if (com.aliyun.teautil.Common.is4xx(response_.statusCode) || com.aliyun.teautil.Common.is5xx(response_.statusCode)) {
                    bodyStr = com.aliyun.teautil.Common.readAsString(response_.body);
                    respMap = com.aliyun.ossutil.Client.getErrMessage(bodyStr);
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("code", respMap.get("Code")),
                        new TeaPair("message", respMap.get("Message")),
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("httpCode", response_.statusCode),
                            new TeaPair("requestId", respMap.get("RequestId")),
                            new TeaPair("hostId", respMap.get("HostId"))
                        ))
                    ));
                }

                bodyStr = com.aliyun.teautil.Common.readAsString(response_.body);
                respMap = com.aliyun.teaxml.Client.parseXml(bodyStr, CopyObjectResponse.class);
                return TeaModel.toModel(TeaConverter.merge(Object.class,
                    TeaConverter.buildMap(
                        new TeaPair("CopyObjectResult", respMap.get("CopyObjectResult"))
                    ),
                    response_.headers
                ), new CopyObjectResponse());
            } catch (Exception e) {
                if (Tea.isRetryable(e)) {
                    continue;
                }
                throw e;
            }
        }

        throw new TeaUnretryableException(_lastRequest);
    }

    public GetObjectTaggingResponse getObjectTagging(GetObjectTaggingRequest request, com.aliyun.ossutil.models.RuntimeOptions runtime) throws Exception {
        TeaModel.validateParams(request, "request");
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", com.aliyun.teautil.Common.defaultNumber(runtime.readTimeout, _readTimeout)),
            new TeaPair("connectTimeout", com.aliyun.teautil.Common.defaultNumber(runtime.connectTimeout, _connectTimeout)),
            new TeaPair("localAddr", com.aliyun.teautil.Common.defaultString(runtime.localAddr, _localAddr)),
            new TeaPair("httpProxy", com.aliyun.teautil.Common.defaultString(runtime.httpProxy, _httpProxy)),
            new TeaPair("httpsProxy", com.aliyun.teautil.Common.defaultString(runtime.httpsProxy, _httpsProxy)),
            new TeaPair("noProxy", com.aliyun.teautil.Common.defaultString(runtime.noProxy, _noProxy)),
            new TeaPair("socks5Proxy", com.aliyun.teautil.Common.defaultString(runtime.socks5Proxy, _socks5Proxy)),
            new TeaPair("socks5NetWork", com.aliyun.teautil.Common.defaultString(runtime.socks5NetWork, _socks5NetWork)),
            new TeaPair("maxIdleConns", com.aliyun.teautil.Common.defaultNumber(runtime.maxIdleConns, _maxIdleConns)),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", com.aliyun.teautil.Common.defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", com.aliyun.teautil.Common.defaultString(runtime.backoffPolicy, "no")),
                new TeaPair("period", com.aliyun.teautil.Common.defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL)
        );

        TeaRequest _lastRequest = null;
        long _now = System.currentTimeMillis();
        int _retryTimes = 0;
        while (Tea.allowRetry((java.util.Map<String, Object>) runtime_.get("retry"), _retryTimes, _now)) {
            if (_retryTimes > 0) {
                int backoffTime = Tea.getBackoffTime(runtime_.get("backoff"), _retryTimes);
                if (backoffTime > 0) {
                    Tea.sleep(backoffTime);
                }
            }
            _retryTimes = _retryTimes + 1;
            try {
                TeaRequest request_ = new TeaRequest();
                String accessKeyId = _credential.getAccessKeyId();
                String accessKeySecret = _credential.getAccessKeySecret();
                String token = _credential.getSecurityToken();
                request_.protocol = _protocol;
                request_.method = "GET";
                request_.pathname = "/" + request.objectName + "?tagging";
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("host", com.aliyun.ossutil.Client.getHost(request.bucketName, _regionId, _endpoint, _hostModel)),
                    new TeaPair("date", com.aliyun.teautil.Common.getDateUTCString()),
                    new TeaPair("user-agent", this.getUserAgent())
                );
                if (!com.aliyun.teautil.Common.empty(token)) {
                    request_.headers.put("x-oss-security-token", token);
                }

                request_.headers.put("authorization", com.aliyun.ossutil.Client.getSignature(request_, request.bucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                String bodyStr = null;
                if (com.aliyun.teautil.Common.is4xx(response_.statusCode) || com.aliyun.teautil.Common.is5xx(response_.statusCode)) {
                    bodyStr = com.aliyun.teautil.Common.readAsString(response_.body);
                    respMap = com.aliyun.ossutil.Client.getErrMessage(bodyStr);
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("code", respMap.get("Code")),
                        new TeaPair("message", respMap.get("Message")),
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("httpCode", response_.statusCode),
                            new TeaPair("requestId", respMap.get("RequestId")),
                            new TeaPair("hostId", respMap.get("HostId"))
                        ))
                    ));
                }

                bodyStr = com.aliyun.teautil.Common.readAsString(response_.body);
                respMap = com.aliyun.teaxml.Client.parseXml(bodyStr, GetObjectTaggingResponse.class);
                return TeaModel.toModel(TeaConverter.merge(Object.class,
                    TeaConverter.buildMap(
                        new TeaPair("Tagging", respMap.get("Tagging"))
                    ),
                    response_.headers
                ), new GetObjectTaggingResponse());
            } catch (Exception e) {
                if (Tea.isRetryable(e)) {
                    continue;
                }
                throw e;
            }
        }

        throw new TeaUnretryableException(_lastRequest);
    }

    public DeleteBucketLifecycleResponse deleteBucketLifecycle(DeleteBucketLifecycleRequest request, com.aliyun.ossutil.models.RuntimeOptions runtime) throws Exception {
        TeaModel.validateParams(request, "request");
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", com.aliyun.teautil.Common.defaultNumber(runtime.readTimeout, _readTimeout)),
            new TeaPair("connectTimeout", com.aliyun.teautil.Common.defaultNumber(runtime.connectTimeout, _connectTimeout)),
            new TeaPair("localAddr", com.aliyun.teautil.Common.defaultString(runtime.localAddr, _localAddr)),
            new TeaPair("httpProxy", com.aliyun.teautil.Common.defaultString(runtime.httpProxy, _httpProxy)),
            new TeaPair("httpsProxy", com.aliyun.teautil.Common.defaultString(runtime.httpsProxy, _httpsProxy)),
            new TeaPair("noProxy", com.aliyun.teautil.Common.defaultString(runtime.noProxy, _noProxy)),
            new TeaPair("socks5Proxy", com.aliyun.teautil.Common.defaultString(runtime.socks5Proxy, _socks5Proxy)),
            new TeaPair("socks5NetWork", com.aliyun.teautil.Common.defaultString(runtime.socks5NetWork, _socks5NetWork)),
            new TeaPair("maxIdleConns", com.aliyun.teautil.Common.defaultNumber(runtime.maxIdleConns, _maxIdleConns)),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", com.aliyun.teautil.Common.defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", com.aliyun.teautil.Common.defaultString(runtime.backoffPolicy, "no")),
                new TeaPair("period", com.aliyun.teautil.Common.defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL)
        );

        TeaRequest _lastRequest = null;
        long _now = System.currentTimeMillis();
        int _retryTimes = 0;
        while (Tea.allowRetry((java.util.Map<String, Object>) runtime_.get("retry"), _retryTimes, _now)) {
            if (_retryTimes > 0) {
                int backoffTime = Tea.getBackoffTime(runtime_.get("backoff"), _retryTimes);
                if (backoffTime > 0) {
                    Tea.sleep(backoffTime);
                }
            }
            _retryTimes = _retryTimes + 1;
            try {
                TeaRequest request_ = new TeaRequest();
                String accessKeyId = _credential.getAccessKeyId();
                String accessKeySecret = _credential.getAccessKeySecret();
                String token = _credential.getSecurityToken();
                request_.protocol = _protocol;
                request_.method = "DELETE";
                request_.pathname = "/?lifecycle";
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("host", com.aliyun.ossutil.Client.getHost(request.bucketName, _regionId, _endpoint, _hostModel)),
                    new TeaPair("date", com.aliyun.teautil.Common.getDateUTCString()),
                    new TeaPair("user-agent", this.getUserAgent())
                );
                if (!com.aliyun.teautil.Common.empty(token)) {
                    request_.headers.put("x-oss-security-token", token);
                }

                request_.headers.put("authorization", com.aliyun.ossutil.Client.getSignature(request_, request.bucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                String bodyStr = null;
                if (com.aliyun.teautil.Common.is4xx(response_.statusCode) || com.aliyun.teautil.Common.is5xx(response_.statusCode)) {
                    bodyStr = com.aliyun.teautil.Common.readAsString(response_.body);
                    respMap = com.aliyun.ossutil.Client.getErrMessage(bodyStr);
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("code", respMap.get("Code")),
                        new TeaPair("message", respMap.get("Message")),
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("httpCode", response_.statusCode),
                            new TeaPair("requestId", respMap.get("RequestId")),
                            new TeaPair("hostId", respMap.get("HostId"))
                        ))
                    ));
                }

                return TeaModel.toModel(TeaConverter.merge(String.class,
                    response_.headers
                ), new DeleteBucketLifecycleResponse());
            } catch (Exception e) {
                if (Tea.isRetryable(e)) {
                    continue;
                }
                throw e;
            }
        }

        throw new TeaUnretryableException(_lastRequest);
    }

    public DeleteBucketLoggingResponse deleteBucketLogging(DeleteBucketLoggingRequest request, com.aliyun.ossutil.models.RuntimeOptions runtime) throws Exception {
        TeaModel.validateParams(request, "request");
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", com.aliyun.teautil.Common.defaultNumber(runtime.readTimeout, _readTimeout)),
            new TeaPair("connectTimeout", com.aliyun.teautil.Common.defaultNumber(runtime.connectTimeout, _connectTimeout)),
            new TeaPair("localAddr", com.aliyun.teautil.Common.defaultString(runtime.localAddr, _localAddr)),
            new TeaPair("httpProxy", com.aliyun.teautil.Common.defaultString(runtime.httpProxy, _httpProxy)),
            new TeaPair("httpsProxy", com.aliyun.teautil.Common.defaultString(runtime.httpsProxy, _httpsProxy)),
            new TeaPair("noProxy", com.aliyun.teautil.Common.defaultString(runtime.noProxy, _noProxy)),
            new TeaPair("socks5Proxy", com.aliyun.teautil.Common.defaultString(runtime.socks5Proxy, _socks5Proxy)),
            new TeaPair("socks5NetWork", com.aliyun.teautil.Common.defaultString(runtime.socks5NetWork, _socks5NetWork)),
            new TeaPair("maxIdleConns", com.aliyun.teautil.Common.defaultNumber(runtime.maxIdleConns, _maxIdleConns)),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", com.aliyun.teautil.Common.defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", com.aliyun.teautil.Common.defaultString(runtime.backoffPolicy, "no")),
                new TeaPair("period", com.aliyun.teautil.Common.defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL)
        );

        TeaRequest _lastRequest = null;
        long _now = System.currentTimeMillis();
        int _retryTimes = 0;
        while (Tea.allowRetry((java.util.Map<String, Object>) runtime_.get("retry"), _retryTimes, _now)) {
            if (_retryTimes > 0) {
                int backoffTime = Tea.getBackoffTime(runtime_.get("backoff"), _retryTimes);
                if (backoffTime > 0) {
                    Tea.sleep(backoffTime);
                }
            }
            _retryTimes = _retryTimes + 1;
            try {
                TeaRequest request_ = new TeaRequest();
                String accessKeyId = _credential.getAccessKeyId();
                String accessKeySecret = _credential.getAccessKeySecret();
                String token = _credential.getSecurityToken();
                request_.protocol = _protocol;
                request_.method = "DELETE";
                request_.pathname = "/?logging";
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("host", com.aliyun.ossutil.Client.getHost(request.bucketName, _regionId, _endpoint, _hostModel)),
                    new TeaPair("date", com.aliyun.teautil.Common.getDateUTCString()),
                    new TeaPair("user-agent", this.getUserAgent())
                );
                if (!com.aliyun.teautil.Common.empty(token)) {
                    request_.headers.put("x-oss-security-token", token);
                }

                request_.headers.put("authorization", com.aliyun.ossutil.Client.getSignature(request_, request.bucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                String bodyStr = null;
                if (com.aliyun.teautil.Common.is4xx(response_.statusCode) || com.aliyun.teautil.Common.is5xx(response_.statusCode)) {
                    bodyStr = com.aliyun.teautil.Common.readAsString(response_.body);
                    respMap = com.aliyun.ossutil.Client.getErrMessage(bodyStr);
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("code", respMap.get("Code")),
                        new TeaPair("message", respMap.get("Message")),
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("httpCode", response_.statusCode),
                            new TeaPair("requestId", respMap.get("RequestId")),
                            new TeaPair("hostId", respMap.get("HostId"))
                        ))
                    ));
                }

                return TeaModel.toModel(TeaConverter.merge(String.class,
                    response_.headers
                ), new DeleteBucketLoggingResponse());
            } catch (Exception e) {
                if (Tea.isRetryable(e)) {
                    continue;
                }
                throw e;
            }
        }

        throw new TeaUnretryableException(_lastRequest);
    }

    public DeleteBucketWebsiteResponse deleteBucketWebsite(DeleteBucketWebsiteRequest request, com.aliyun.ossutil.models.RuntimeOptions runtime) throws Exception {
        TeaModel.validateParams(request, "request");
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", com.aliyun.teautil.Common.defaultNumber(runtime.readTimeout, _readTimeout)),
            new TeaPair("connectTimeout", com.aliyun.teautil.Common.defaultNumber(runtime.connectTimeout, _connectTimeout)),
            new TeaPair("localAddr", com.aliyun.teautil.Common.defaultString(runtime.localAddr, _localAddr)),
            new TeaPair("httpProxy", com.aliyun.teautil.Common.defaultString(runtime.httpProxy, _httpProxy)),
            new TeaPair("httpsProxy", com.aliyun.teautil.Common.defaultString(runtime.httpsProxy, _httpsProxy)),
            new TeaPair("noProxy", com.aliyun.teautil.Common.defaultString(runtime.noProxy, _noProxy)),
            new TeaPair("socks5Proxy", com.aliyun.teautil.Common.defaultString(runtime.socks5Proxy, _socks5Proxy)),
            new TeaPair("socks5NetWork", com.aliyun.teautil.Common.defaultString(runtime.socks5NetWork, _socks5NetWork)),
            new TeaPair("maxIdleConns", com.aliyun.teautil.Common.defaultNumber(runtime.maxIdleConns, _maxIdleConns)),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", com.aliyun.teautil.Common.defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", com.aliyun.teautil.Common.defaultString(runtime.backoffPolicy, "no")),
                new TeaPair("period", com.aliyun.teautil.Common.defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL)
        );

        TeaRequest _lastRequest = null;
        long _now = System.currentTimeMillis();
        int _retryTimes = 0;
        while (Tea.allowRetry((java.util.Map<String, Object>) runtime_.get("retry"), _retryTimes, _now)) {
            if (_retryTimes > 0) {
                int backoffTime = Tea.getBackoffTime(runtime_.get("backoff"), _retryTimes);
                if (backoffTime > 0) {
                    Tea.sleep(backoffTime);
                }
            }
            _retryTimes = _retryTimes + 1;
            try {
                TeaRequest request_ = new TeaRequest();
                String accessKeyId = _credential.getAccessKeyId();
                String accessKeySecret = _credential.getAccessKeySecret();
                String token = _credential.getSecurityToken();
                request_.protocol = _protocol;
                request_.method = "DELETE";
                request_.pathname = "/?website";
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("host", com.aliyun.ossutil.Client.getHost(request.bucketName, _regionId, _endpoint, _hostModel)),
                    new TeaPair("date", com.aliyun.teautil.Common.getDateUTCString()),
                    new TeaPair("user-agent", this.getUserAgent())
                );
                if (!com.aliyun.teautil.Common.empty(token)) {
                    request_.headers.put("x-oss-security-token", token);
                }

                request_.headers.put("authorization", com.aliyun.ossutil.Client.getSignature(request_, request.bucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                String bodyStr = null;
                if (com.aliyun.teautil.Common.is4xx(response_.statusCode) || com.aliyun.teautil.Common.is5xx(response_.statusCode)) {
                    bodyStr = com.aliyun.teautil.Common.readAsString(response_.body);
                    respMap = com.aliyun.ossutil.Client.getErrMessage(bodyStr);
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("code", respMap.get("Code")),
                        new TeaPair("message", respMap.get("Message")),
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("httpCode", response_.statusCode),
                            new TeaPair("requestId", respMap.get("RequestId")),
                            new TeaPair("hostId", respMap.get("HostId"))
                        ))
                    ));
                }

                return TeaModel.toModel(TeaConverter.merge(String.class,
                    response_.headers
                ), new DeleteBucketWebsiteResponse());
            } catch (Exception e) {
                if (Tea.isRetryable(e)) {
                    continue;
                }
                throw e;
            }
        }

        throw new TeaUnretryableException(_lastRequest);
    }

    public GetSymlinkResponse getSymlink(GetSymlinkRequest request, com.aliyun.ossutil.models.RuntimeOptions runtime) throws Exception {
        TeaModel.validateParams(request, "request");
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", com.aliyun.teautil.Common.defaultNumber(runtime.readTimeout, _readTimeout)),
            new TeaPair("connectTimeout", com.aliyun.teautil.Common.defaultNumber(runtime.connectTimeout, _connectTimeout)),
            new TeaPair("localAddr", com.aliyun.teautil.Common.defaultString(runtime.localAddr, _localAddr)),
            new TeaPair("httpProxy", com.aliyun.teautil.Common.defaultString(runtime.httpProxy, _httpProxy)),
            new TeaPair("httpsProxy", com.aliyun.teautil.Common.defaultString(runtime.httpsProxy, _httpsProxy)),
            new TeaPair("noProxy", com.aliyun.teautil.Common.defaultString(runtime.noProxy, _noProxy)),
            new TeaPair("socks5Proxy", com.aliyun.teautil.Common.defaultString(runtime.socks5Proxy, _socks5Proxy)),
            new TeaPair("socks5NetWork", com.aliyun.teautil.Common.defaultString(runtime.socks5NetWork, _socks5NetWork)),
            new TeaPair("maxIdleConns", com.aliyun.teautil.Common.defaultNumber(runtime.maxIdleConns, _maxIdleConns)),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", com.aliyun.teautil.Common.defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", com.aliyun.teautil.Common.defaultString(runtime.backoffPolicy, "no")),
                new TeaPair("period", com.aliyun.teautil.Common.defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL)
        );

        TeaRequest _lastRequest = null;
        long _now = System.currentTimeMillis();
        int _retryTimes = 0;
        while (Tea.allowRetry((java.util.Map<String, Object>) runtime_.get("retry"), _retryTimes, _now)) {
            if (_retryTimes > 0) {
                int backoffTime = Tea.getBackoffTime(runtime_.get("backoff"), _retryTimes);
                if (backoffTime > 0) {
                    Tea.sleep(backoffTime);
                }
            }
            _retryTimes = _retryTimes + 1;
            try {
                TeaRequest request_ = new TeaRequest();
                String accessKeyId = _credential.getAccessKeyId();
                String accessKeySecret = _credential.getAccessKeySecret();
                String token = _credential.getSecurityToken();
                request_.protocol = _protocol;
                request_.method = "GET";
                request_.pathname = "/" + request.objectName + "?symlink";
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("host", com.aliyun.ossutil.Client.getHost(request.bucketName, _regionId, _endpoint, _hostModel)),
                    new TeaPair("date", com.aliyun.teautil.Common.getDateUTCString()),
                    new TeaPair("user-agent", this.getUserAgent())
                );
                if (!com.aliyun.teautil.Common.empty(token)) {
                    request_.headers.put("x-oss-security-token", token);
                }

                request_.headers.put("authorization", com.aliyun.ossutil.Client.getSignature(request_, request.bucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                String bodyStr = null;
                if (com.aliyun.teautil.Common.is4xx(response_.statusCode) || com.aliyun.teautil.Common.is5xx(response_.statusCode)) {
                    bodyStr = com.aliyun.teautil.Common.readAsString(response_.body);
                    respMap = com.aliyun.ossutil.Client.getErrMessage(bodyStr);
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("code", respMap.get("Code")),
                        new TeaPair("message", respMap.get("Message")),
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("httpCode", response_.statusCode),
                            new TeaPair("requestId", respMap.get("RequestId")),
                            new TeaPair("hostId", respMap.get("HostId"))
                        ))
                    ));
                }

                return TeaModel.toModel(TeaConverter.merge(String.class,
                    response_.headers
                ), new GetSymlinkResponse());
            } catch (Exception e) {
                if (Tea.isRetryable(e)) {
                    continue;
                }
                throw e;
            }
        }

        throw new TeaUnretryableException(_lastRequest);
    }

    public GetBucketLifecycleResponse getBucketLifecycle(GetBucketLifecycleRequest request, com.aliyun.ossutil.models.RuntimeOptions runtime) throws Exception {
        TeaModel.validateParams(request, "request");
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", com.aliyun.teautil.Common.defaultNumber(runtime.readTimeout, _readTimeout)),
            new TeaPair("connectTimeout", com.aliyun.teautil.Common.defaultNumber(runtime.connectTimeout, _connectTimeout)),
            new TeaPair("localAddr", com.aliyun.teautil.Common.defaultString(runtime.localAddr, _localAddr)),
            new TeaPair("httpProxy", com.aliyun.teautil.Common.defaultString(runtime.httpProxy, _httpProxy)),
            new TeaPair("httpsProxy", com.aliyun.teautil.Common.defaultString(runtime.httpsProxy, _httpsProxy)),
            new TeaPair("noProxy", com.aliyun.teautil.Common.defaultString(runtime.noProxy, _noProxy)),
            new TeaPair("socks5Proxy", com.aliyun.teautil.Common.defaultString(runtime.socks5Proxy, _socks5Proxy)),
            new TeaPair("socks5NetWork", com.aliyun.teautil.Common.defaultString(runtime.socks5NetWork, _socks5NetWork)),
            new TeaPair("maxIdleConns", com.aliyun.teautil.Common.defaultNumber(runtime.maxIdleConns, _maxIdleConns)),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", com.aliyun.teautil.Common.defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", com.aliyun.teautil.Common.defaultString(runtime.backoffPolicy, "no")),
                new TeaPair("period", com.aliyun.teautil.Common.defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL)
        );

        TeaRequest _lastRequest = null;
        long _now = System.currentTimeMillis();
        int _retryTimes = 0;
        while (Tea.allowRetry((java.util.Map<String, Object>) runtime_.get("retry"), _retryTimes, _now)) {
            if (_retryTimes > 0) {
                int backoffTime = Tea.getBackoffTime(runtime_.get("backoff"), _retryTimes);
                if (backoffTime > 0) {
                    Tea.sleep(backoffTime);
                }
            }
            _retryTimes = _retryTimes + 1;
            try {
                TeaRequest request_ = new TeaRequest();
                String accessKeyId = _credential.getAccessKeyId();
                String accessKeySecret = _credential.getAccessKeySecret();
                String token = _credential.getSecurityToken();
                request_.protocol = _protocol;
                request_.method = "GET";
                request_.pathname = "/?lifecycle";
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("host", com.aliyun.ossutil.Client.getHost(request.bucketName, _regionId, _endpoint, _hostModel)),
                    new TeaPair("date", com.aliyun.teautil.Common.getDateUTCString()),
                    new TeaPair("user-agent", this.getUserAgent())
                );
                if (!com.aliyun.teautil.Common.empty(token)) {
                    request_.headers.put("x-oss-security-token", token);
                }

                request_.headers.put("authorization", com.aliyun.ossutil.Client.getSignature(request_, request.bucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                String bodyStr = null;
                if (com.aliyun.teautil.Common.is4xx(response_.statusCode) || com.aliyun.teautil.Common.is5xx(response_.statusCode)) {
                    bodyStr = com.aliyun.teautil.Common.readAsString(response_.body);
                    respMap = com.aliyun.ossutil.Client.getErrMessage(bodyStr);
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("code", respMap.get("Code")),
                        new TeaPair("message", respMap.get("Message")),
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("httpCode", response_.statusCode),
                            new TeaPair("requestId", respMap.get("RequestId")),
                            new TeaPair("hostId", respMap.get("HostId"))
                        ))
                    ));
                }

                bodyStr = com.aliyun.teautil.Common.readAsString(response_.body);
                respMap = com.aliyun.teaxml.Client.parseXml(bodyStr, GetBucketLifecycleResponse.class);
                return TeaModel.toModel(TeaConverter.merge(Object.class,
                    TeaConverter.buildMap(
                        new TeaPair("LifecycleConfiguration", respMap.get("LifecycleConfiguration"))
                    ),
                    response_.headers
                ), new GetBucketLifecycleResponse());
            } catch (Exception e) {
                if (Tea.isRetryable(e)) {
                    continue;
                }
                throw e;
            }
        }

        throw new TeaUnretryableException(_lastRequest);
    }

    public PutSymlinkResponse putSymlink(PutSymlinkRequest request, com.aliyun.ossutil.models.RuntimeOptions runtime) throws Exception {
        TeaModel.validateParams(request, "request");
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", com.aliyun.teautil.Common.defaultNumber(runtime.readTimeout, _readTimeout)),
            new TeaPair("connectTimeout", com.aliyun.teautil.Common.defaultNumber(runtime.connectTimeout, _connectTimeout)),
            new TeaPair("localAddr", com.aliyun.teautil.Common.defaultString(runtime.localAddr, _localAddr)),
            new TeaPair("httpProxy", com.aliyun.teautil.Common.defaultString(runtime.httpProxy, _httpProxy)),
            new TeaPair("httpsProxy", com.aliyun.teautil.Common.defaultString(runtime.httpsProxy, _httpsProxy)),
            new TeaPair("noProxy", com.aliyun.teautil.Common.defaultString(runtime.noProxy, _noProxy)),
            new TeaPair("socks5Proxy", com.aliyun.teautil.Common.defaultString(runtime.socks5Proxy, _socks5Proxy)),
            new TeaPair("socks5NetWork", com.aliyun.teautil.Common.defaultString(runtime.socks5NetWork, _socks5NetWork)),
            new TeaPair("maxIdleConns", com.aliyun.teautil.Common.defaultNumber(runtime.maxIdleConns, _maxIdleConns)),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", com.aliyun.teautil.Common.defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", com.aliyun.teautil.Common.defaultString(runtime.backoffPolicy, "no")),
                new TeaPair("period", com.aliyun.teautil.Common.defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL)
        );

        TeaRequest _lastRequest = null;
        long _now = System.currentTimeMillis();
        int _retryTimes = 0;
        while (Tea.allowRetry((java.util.Map<String, Object>) runtime_.get("retry"), _retryTimes, _now)) {
            if (_retryTimes > 0) {
                int backoffTime = Tea.getBackoffTime(runtime_.get("backoff"), _retryTimes);
                if (backoffTime > 0) {
                    Tea.sleep(backoffTime);
                }
            }
            _retryTimes = _retryTimes + 1;
            try {
                TeaRequest request_ = new TeaRequest();
                String accessKeyId = _credential.getAccessKeyId();
                String accessKeySecret = _credential.getAccessKeySecret();
                String token = _credential.getSecurityToken();
                request_.protocol = _protocol;
                request_.method = "PUT";
                request_.pathname = "/" + request.objectName + "?symlink";
                request_.headers = TeaConverter.merge(String.class,
                    TeaConverter.buildMap(
                        new TeaPair("host", com.aliyun.ossutil.Client.getHost(request.bucketName, _regionId, _endpoint, _hostModel)),
                        new TeaPair("date", com.aliyun.teautil.Common.getDateUTCString()),
                        new TeaPair("user-agent", this.getUserAgent())
                    ),
                    com.aliyun.teautil.Common.stringifyMapValue(TeaModel.buildMap(request.header))
                );
                if (!com.aliyun.teautil.Common.empty(token)) {
                    request_.headers.put("x-oss-security-token", token);
                }

                request_.headers.put("authorization", com.aliyun.ossutil.Client.getSignature(request_, request.bucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                String bodyStr = null;
                if (com.aliyun.teautil.Common.is4xx(response_.statusCode) || com.aliyun.teautil.Common.is5xx(response_.statusCode)) {
                    bodyStr = com.aliyun.teautil.Common.readAsString(response_.body);
                    respMap = com.aliyun.ossutil.Client.getErrMessage(bodyStr);
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("code", respMap.get("Code")),
                        new TeaPair("message", respMap.get("Message")),
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("httpCode", response_.statusCode),
                            new TeaPair("requestId", respMap.get("RequestId")),
                            new TeaPair("hostId", respMap.get("HostId"))
                        ))
                    ));
                }

                return TeaModel.toModel(TeaConverter.merge(String.class,
                    response_.headers
                ), new PutSymlinkResponse());
            } catch (Exception e) {
                if (Tea.isRetryable(e)) {
                    continue;
                }
                throw e;
            }
        }

        throw new TeaUnretryableException(_lastRequest);
    }

    public GetBucketRefererResponse getBucketReferer(GetBucketRefererRequest request, com.aliyun.ossutil.models.RuntimeOptions runtime) throws Exception {
        TeaModel.validateParams(request, "request");
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", com.aliyun.teautil.Common.defaultNumber(runtime.readTimeout, _readTimeout)),
            new TeaPair("connectTimeout", com.aliyun.teautil.Common.defaultNumber(runtime.connectTimeout, _connectTimeout)),
            new TeaPair("localAddr", com.aliyun.teautil.Common.defaultString(runtime.localAddr, _localAddr)),
            new TeaPair("httpProxy", com.aliyun.teautil.Common.defaultString(runtime.httpProxy, _httpProxy)),
            new TeaPair("httpsProxy", com.aliyun.teautil.Common.defaultString(runtime.httpsProxy, _httpsProxy)),
            new TeaPair("noProxy", com.aliyun.teautil.Common.defaultString(runtime.noProxy, _noProxy)),
            new TeaPair("socks5Proxy", com.aliyun.teautil.Common.defaultString(runtime.socks5Proxy, _socks5Proxy)),
            new TeaPair("socks5NetWork", com.aliyun.teautil.Common.defaultString(runtime.socks5NetWork, _socks5NetWork)),
            new TeaPair("maxIdleConns", com.aliyun.teautil.Common.defaultNumber(runtime.maxIdleConns, _maxIdleConns)),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", com.aliyun.teautil.Common.defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", com.aliyun.teautil.Common.defaultString(runtime.backoffPolicy, "no")),
                new TeaPair("period", com.aliyun.teautil.Common.defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL)
        );

        TeaRequest _lastRequest = null;
        long _now = System.currentTimeMillis();
        int _retryTimes = 0;
        while (Tea.allowRetry((java.util.Map<String, Object>) runtime_.get("retry"), _retryTimes, _now)) {
            if (_retryTimes > 0) {
                int backoffTime = Tea.getBackoffTime(runtime_.get("backoff"), _retryTimes);
                if (backoffTime > 0) {
                    Tea.sleep(backoffTime);
                }
            }
            _retryTimes = _retryTimes + 1;
            try {
                TeaRequest request_ = new TeaRequest();
                String accessKeyId = _credential.getAccessKeyId();
                String accessKeySecret = _credential.getAccessKeySecret();
                String token = _credential.getSecurityToken();
                request_.protocol = _protocol;
                request_.method = "GET";
                request_.pathname = "/?referer";
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("host", com.aliyun.ossutil.Client.getHost(request.bucketName, _regionId, _endpoint, _hostModel)),
                    new TeaPair("date", com.aliyun.teautil.Common.getDateUTCString()),
                    new TeaPair("user-agent", this.getUserAgent())
                );
                if (!com.aliyun.teautil.Common.empty(token)) {
                    request_.headers.put("x-oss-security-token", token);
                }

                request_.headers.put("authorization", com.aliyun.ossutil.Client.getSignature(request_, request.bucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                String bodyStr = null;
                if (com.aliyun.teautil.Common.is4xx(response_.statusCode) || com.aliyun.teautil.Common.is5xx(response_.statusCode)) {
                    bodyStr = com.aliyun.teautil.Common.readAsString(response_.body);
                    respMap = com.aliyun.ossutil.Client.getErrMessage(bodyStr);
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("code", respMap.get("Code")),
                        new TeaPair("message", respMap.get("Message")),
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("httpCode", response_.statusCode),
                            new TeaPair("requestId", respMap.get("RequestId")),
                            new TeaPair("hostId", respMap.get("HostId"))
                        ))
                    ));
                }

                bodyStr = com.aliyun.teautil.Common.readAsString(response_.body);
                respMap = com.aliyun.teaxml.Client.parseXml(bodyStr, GetBucketRefererResponse.class);
                return TeaModel.toModel(TeaConverter.merge(Object.class,
                    TeaConverter.buildMap(
                        new TeaPair("RefererConfiguration", respMap.get("RefererConfiguration"))
                    ),
                    response_.headers
                ), new GetBucketRefererResponse());
            } catch (Exception e) {
                if (Tea.isRetryable(e)) {
                    continue;
                }
                throw e;
            }
        }

        throw new TeaUnretryableException(_lastRequest);
    }

    public CallbackResponse callback(CallbackRequest request, com.aliyun.ossutil.models.RuntimeOptions runtime) throws Exception {
        TeaModel.validateParams(request, "request");
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", com.aliyun.teautil.Common.defaultNumber(runtime.readTimeout, _readTimeout)),
            new TeaPair("connectTimeout", com.aliyun.teautil.Common.defaultNumber(runtime.connectTimeout, _connectTimeout)),
            new TeaPair("localAddr", com.aliyun.teautil.Common.defaultString(runtime.localAddr, _localAddr)),
            new TeaPair("httpProxy", com.aliyun.teautil.Common.defaultString(runtime.httpProxy, _httpProxy)),
            new TeaPair("httpsProxy", com.aliyun.teautil.Common.defaultString(runtime.httpsProxy, _httpsProxy)),
            new TeaPair("noProxy", com.aliyun.teautil.Common.defaultString(runtime.noProxy, _noProxy)),
            new TeaPair("socks5Proxy", com.aliyun.teautil.Common.defaultString(runtime.socks5Proxy, _socks5Proxy)),
            new TeaPair("socks5NetWork", com.aliyun.teautil.Common.defaultString(runtime.socks5NetWork, _socks5NetWork)),
            new TeaPair("maxIdleConns", com.aliyun.teautil.Common.defaultNumber(runtime.maxIdleConns, _maxIdleConns)),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", com.aliyun.teautil.Common.defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", com.aliyun.teautil.Common.defaultString(runtime.backoffPolicy, "no")),
                new TeaPair("period", com.aliyun.teautil.Common.defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL)
        );

        TeaRequest _lastRequest = null;
        long _now = System.currentTimeMillis();
        int _retryTimes = 0;
        while (Tea.allowRetry((java.util.Map<String, Object>) runtime_.get("retry"), _retryTimes, _now)) {
            if (_retryTimes > 0) {
                int backoffTime = Tea.getBackoffTime(runtime_.get("backoff"), _retryTimes);
                if (backoffTime > 0) {
                    Tea.sleep(backoffTime);
                }
            }
            _retryTimes = _retryTimes + 1;
            try {
                TeaRequest request_ = new TeaRequest();
                String accessKeyId = _credential.getAccessKeyId();
                String accessKeySecret = _credential.getAccessKeySecret();
                String token = _credential.getSecurityToken();
                request_.protocol = _protocol;
                request_.method = "GET";
                request_.pathname = "/";
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("host", com.aliyun.ossutil.Client.getHost(request.bucketName, _regionId, _endpoint, _hostModel)),
                    new TeaPair("date", com.aliyun.teautil.Common.getDateUTCString()),
                    new TeaPair("user-agent", this.getUserAgent())
                );
                if (!com.aliyun.teautil.Common.empty(token)) {
                    request_.headers.put("x-oss-security-token", token);
                }

                request_.headers.put("authorization", com.aliyun.ossutil.Client.getSignature(request_, request.bucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                String bodyStr = null;
                if (com.aliyun.teautil.Common.is4xx(response_.statusCode) || com.aliyun.teautil.Common.is5xx(response_.statusCode)) {
                    bodyStr = com.aliyun.teautil.Common.readAsString(response_.body);
                    respMap = com.aliyun.ossutil.Client.getErrMessage(bodyStr);
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("code", respMap.get("Code")),
                        new TeaPair("message", respMap.get("Message")),
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("httpCode", response_.statusCode),
                            new TeaPair("requestId", respMap.get("RequestId")),
                            new TeaPair("hostId", respMap.get("HostId"))
                        ))
                    ));
                }

                return TeaModel.toModel(TeaConverter.merge(String.class,
                    response_.headers
                ), new CallbackResponse());
            } catch (Exception e) {
                if (Tea.isRetryable(e)) {
                    continue;
                }
                throw e;
            }
        }

        throw new TeaUnretryableException(_lastRequest);
    }

    public GetBucketLoggingResponse getBucketLogging(GetBucketLoggingRequest request, com.aliyun.ossutil.models.RuntimeOptions runtime) throws Exception {
        TeaModel.validateParams(request, "request");
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", com.aliyun.teautil.Common.defaultNumber(runtime.readTimeout, _readTimeout)),
            new TeaPair("connectTimeout", com.aliyun.teautil.Common.defaultNumber(runtime.connectTimeout, _connectTimeout)),
            new TeaPair("localAddr", com.aliyun.teautil.Common.defaultString(runtime.localAddr, _localAddr)),
            new TeaPair("httpProxy", com.aliyun.teautil.Common.defaultString(runtime.httpProxy, _httpProxy)),
            new TeaPair("httpsProxy", com.aliyun.teautil.Common.defaultString(runtime.httpsProxy, _httpsProxy)),
            new TeaPair("noProxy", com.aliyun.teautil.Common.defaultString(runtime.noProxy, _noProxy)),
            new TeaPair("socks5Proxy", com.aliyun.teautil.Common.defaultString(runtime.socks5Proxy, _socks5Proxy)),
            new TeaPair("socks5NetWork", com.aliyun.teautil.Common.defaultString(runtime.socks5NetWork, _socks5NetWork)),
            new TeaPair("maxIdleConns", com.aliyun.teautil.Common.defaultNumber(runtime.maxIdleConns, _maxIdleConns)),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", com.aliyun.teautil.Common.defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", com.aliyun.teautil.Common.defaultString(runtime.backoffPolicy, "no")),
                new TeaPair("period", com.aliyun.teautil.Common.defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL)
        );

        TeaRequest _lastRequest = null;
        long _now = System.currentTimeMillis();
        int _retryTimes = 0;
        while (Tea.allowRetry((java.util.Map<String, Object>) runtime_.get("retry"), _retryTimes, _now)) {
            if (_retryTimes > 0) {
                int backoffTime = Tea.getBackoffTime(runtime_.get("backoff"), _retryTimes);
                if (backoffTime > 0) {
                    Tea.sleep(backoffTime);
                }
            }
            _retryTimes = _retryTimes + 1;
            try {
                TeaRequest request_ = new TeaRequest();
                String accessKeyId = _credential.getAccessKeyId();
                String accessKeySecret = _credential.getAccessKeySecret();
                String token = _credential.getSecurityToken();
                request_.protocol = _protocol;
                request_.method = "GET";
                request_.pathname = "/?logging";
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("host", com.aliyun.ossutil.Client.getHost(request.bucketName, _regionId, _endpoint, _hostModel)),
                    new TeaPair("date", com.aliyun.teautil.Common.getDateUTCString()),
                    new TeaPair("user-agent", this.getUserAgent())
                );
                if (!com.aliyun.teautil.Common.empty(token)) {
                    request_.headers.put("x-oss-security-token", token);
                }

                request_.headers.put("authorization", com.aliyun.ossutil.Client.getSignature(request_, request.bucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                String bodyStr = null;
                if (com.aliyun.teautil.Common.is4xx(response_.statusCode) || com.aliyun.teautil.Common.is5xx(response_.statusCode)) {
                    bodyStr = com.aliyun.teautil.Common.readAsString(response_.body);
                    respMap = com.aliyun.ossutil.Client.getErrMessage(bodyStr);
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("code", respMap.get("Code")),
                        new TeaPair("message", respMap.get("Message")),
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("httpCode", response_.statusCode),
                            new TeaPair("requestId", respMap.get("RequestId")),
                            new TeaPair("hostId", respMap.get("HostId"))
                        ))
                    ));
                }

                bodyStr = com.aliyun.teautil.Common.readAsString(response_.body);
                respMap = com.aliyun.teaxml.Client.parseXml(bodyStr, GetBucketLoggingResponse.class);
                return TeaModel.toModel(TeaConverter.merge(Object.class,
                    TeaConverter.buildMap(
                        new TeaPair("BucketLoggingStatus", respMap.get("BucketLoggingStatus"))
                    ),
                    response_.headers
                ), new GetBucketLoggingResponse());
            } catch (Exception e) {
                if (Tea.isRetryable(e)) {
                    continue;
                }
                throw e;
            }
        }

        throw new TeaUnretryableException(_lastRequest);
    }

    public PutObjectAclResponse putObjectAcl(PutObjectAclRequest request, com.aliyun.ossutil.models.RuntimeOptions runtime) throws Exception {
        TeaModel.validateParams(request, "request");
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", com.aliyun.teautil.Common.defaultNumber(runtime.readTimeout, _readTimeout)),
            new TeaPair("connectTimeout", com.aliyun.teautil.Common.defaultNumber(runtime.connectTimeout, _connectTimeout)),
            new TeaPair("localAddr", com.aliyun.teautil.Common.defaultString(runtime.localAddr, _localAddr)),
            new TeaPair("httpProxy", com.aliyun.teautil.Common.defaultString(runtime.httpProxy, _httpProxy)),
            new TeaPair("httpsProxy", com.aliyun.teautil.Common.defaultString(runtime.httpsProxy, _httpsProxy)),
            new TeaPair("noProxy", com.aliyun.teautil.Common.defaultString(runtime.noProxy, _noProxy)),
            new TeaPair("socks5Proxy", com.aliyun.teautil.Common.defaultString(runtime.socks5Proxy, _socks5Proxy)),
            new TeaPair("socks5NetWork", com.aliyun.teautil.Common.defaultString(runtime.socks5NetWork, _socks5NetWork)),
            new TeaPair("maxIdleConns", com.aliyun.teautil.Common.defaultNumber(runtime.maxIdleConns, _maxIdleConns)),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", com.aliyun.teautil.Common.defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", com.aliyun.teautil.Common.defaultString(runtime.backoffPolicy, "no")),
                new TeaPair("period", com.aliyun.teautil.Common.defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL)
        );

        TeaRequest _lastRequest = null;
        long _now = System.currentTimeMillis();
        int _retryTimes = 0;
        while (Tea.allowRetry((java.util.Map<String, Object>) runtime_.get("retry"), _retryTimes, _now)) {
            if (_retryTimes > 0) {
                int backoffTime = Tea.getBackoffTime(runtime_.get("backoff"), _retryTimes);
                if (backoffTime > 0) {
                    Tea.sleep(backoffTime);
                }
            }
            _retryTimes = _retryTimes + 1;
            try {
                TeaRequest request_ = new TeaRequest();
                String accessKeyId = _credential.getAccessKeyId();
                String accessKeySecret = _credential.getAccessKeySecret();
                String token = _credential.getSecurityToken();
                request_.protocol = _protocol;
                request_.method = "PUT";
                request_.pathname = "/" + request.objectName + "?acl";
                request_.headers = TeaConverter.merge(String.class,
                    TeaConverter.buildMap(
                        new TeaPair("host", com.aliyun.ossutil.Client.getHost(request.bucketName, _regionId, _endpoint, _hostModel)),
                        new TeaPair("date", com.aliyun.teautil.Common.getDateUTCString()),
                        new TeaPair("user-agent", this.getUserAgent())
                    ),
                    com.aliyun.teautil.Common.stringifyMapValue(TeaModel.buildMap(request.header))
                );
                if (!com.aliyun.teautil.Common.empty(token)) {
                    request_.headers.put("x-oss-security-token", token);
                }

                request_.headers.put("authorization", com.aliyun.ossutil.Client.getSignature(request_, request.bucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                String bodyStr = null;
                if (com.aliyun.teautil.Common.is4xx(response_.statusCode) || com.aliyun.teautil.Common.is5xx(response_.statusCode)) {
                    bodyStr = com.aliyun.teautil.Common.readAsString(response_.body);
                    respMap = com.aliyun.ossutil.Client.getErrMessage(bodyStr);
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("code", respMap.get("Code")),
                        new TeaPair("message", respMap.get("Message")),
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("httpCode", response_.statusCode),
                            new TeaPair("requestId", respMap.get("RequestId")),
                            new TeaPair("hostId", respMap.get("HostId"))
                        ))
                    ));
                }

                return TeaModel.toModel(TeaConverter.merge(String.class,
                    response_.headers
                ), new PutObjectAclResponse());
            } catch (Exception e) {
                if (Tea.isRetryable(e)) {
                    continue;
                }
                throw e;
            }
        }

        throw new TeaUnretryableException(_lastRequest);
    }

    public GetBucketInfoResponse getBucketInfo(GetBucketInfoRequest request, com.aliyun.ossutil.models.RuntimeOptions runtime) throws Exception {
        TeaModel.validateParams(request, "request");
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", com.aliyun.teautil.Common.defaultNumber(runtime.readTimeout, _readTimeout)),
            new TeaPair("connectTimeout", com.aliyun.teautil.Common.defaultNumber(runtime.connectTimeout, _connectTimeout)),
            new TeaPair("localAddr", com.aliyun.teautil.Common.defaultString(runtime.localAddr, _localAddr)),
            new TeaPair("httpProxy", com.aliyun.teautil.Common.defaultString(runtime.httpProxy, _httpProxy)),
            new TeaPair("httpsProxy", com.aliyun.teautil.Common.defaultString(runtime.httpsProxy, _httpsProxy)),
            new TeaPair("noProxy", com.aliyun.teautil.Common.defaultString(runtime.noProxy, _noProxy)),
            new TeaPair("socks5Proxy", com.aliyun.teautil.Common.defaultString(runtime.socks5Proxy, _socks5Proxy)),
            new TeaPair("socks5NetWork", com.aliyun.teautil.Common.defaultString(runtime.socks5NetWork, _socks5NetWork)),
            new TeaPair("maxIdleConns", com.aliyun.teautil.Common.defaultNumber(runtime.maxIdleConns, _maxIdleConns)),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", com.aliyun.teautil.Common.defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", com.aliyun.teautil.Common.defaultString(runtime.backoffPolicy, "no")),
                new TeaPair("period", com.aliyun.teautil.Common.defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL)
        );

        TeaRequest _lastRequest = null;
        long _now = System.currentTimeMillis();
        int _retryTimes = 0;
        while (Tea.allowRetry((java.util.Map<String, Object>) runtime_.get("retry"), _retryTimes, _now)) {
            if (_retryTimes > 0) {
                int backoffTime = Tea.getBackoffTime(runtime_.get("backoff"), _retryTimes);
                if (backoffTime > 0) {
                    Tea.sleep(backoffTime);
                }
            }
            _retryTimes = _retryTimes + 1;
            try {
                TeaRequest request_ = new TeaRequest();
                String accessKeyId = _credential.getAccessKeyId();
                String accessKeySecret = _credential.getAccessKeySecret();
                String token = _credential.getSecurityToken();
                request_.protocol = _protocol;
                request_.method = "GET";
                request_.pathname = "/?bucketInfo";
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("host", com.aliyun.ossutil.Client.getHost(request.bucketName, _regionId, _endpoint, _hostModel)),
                    new TeaPair("date", com.aliyun.teautil.Common.getDateUTCString()),
                    new TeaPair("user-agent", this.getUserAgent())
                );
                if (!com.aliyun.teautil.Common.empty(token)) {
                    request_.headers.put("x-oss-security-token", token);
                }

                request_.headers.put("authorization", com.aliyun.ossutil.Client.getSignature(request_, request.bucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                String bodyStr = null;
                if (com.aliyun.teautil.Common.is4xx(response_.statusCode) || com.aliyun.teautil.Common.is5xx(response_.statusCode)) {
                    bodyStr = com.aliyun.teautil.Common.readAsString(response_.body);
                    respMap = com.aliyun.ossutil.Client.getErrMessage(bodyStr);
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("code", respMap.get("Code")),
                        new TeaPair("message", respMap.get("Message")),
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("httpCode", response_.statusCode),
                            new TeaPair("requestId", respMap.get("RequestId")),
                            new TeaPair("hostId", respMap.get("HostId"))
                        ))
                    ));
                }

                bodyStr = com.aliyun.teautil.Common.readAsString(response_.body);
                respMap = com.aliyun.teaxml.Client.parseXml(bodyStr, GetBucketInfoResponse.class);
                return TeaModel.toModel(TeaConverter.merge(Object.class,
                    TeaConverter.buildMap(
                        new TeaPair("BucketInfo", respMap.get("BucketInfo"))
                    ),
                    response_.headers
                ), new GetBucketInfoResponse());
            } catch (Exception e) {
                if (Tea.isRetryable(e)) {
                    continue;
                }
                throw e;
            }
        }

        throw new TeaUnretryableException(_lastRequest);
    }

    public PutLiveChannelStatusResponse putLiveChannelStatus(PutLiveChannelStatusRequest request, com.aliyun.ossutil.models.RuntimeOptions runtime) throws Exception {
        TeaModel.validateParams(request, "request");
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", com.aliyun.teautil.Common.defaultNumber(runtime.readTimeout, _readTimeout)),
            new TeaPair("connectTimeout", com.aliyun.teautil.Common.defaultNumber(runtime.connectTimeout, _connectTimeout)),
            new TeaPair("localAddr", com.aliyun.teautil.Common.defaultString(runtime.localAddr, _localAddr)),
            new TeaPair("httpProxy", com.aliyun.teautil.Common.defaultString(runtime.httpProxy, _httpProxy)),
            new TeaPair("httpsProxy", com.aliyun.teautil.Common.defaultString(runtime.httpsProxy, _httpsProxy)),
            new TeaPair("noProxy", com.aliyun.teautil.Common.defaultString(runtime.noProxy, _noProxy)),
            new TeaPair("socks5Proxy", com.aliyun.teautil.Common.defaultString(runtime.socks5Proxy, _socks5Proxy)),
            new TeaPair("socks5NetWork", com.aliyun.teautil.Common.defaultString(runtime.socks5NetWork, _socks5NetWork)),
            new TeaPair("maxIdleConns", com.aliyun.teautil.Common.defaultNumber(runtime.maxIdleConns, _maxIdleConns)),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", com.aliyun.teautil.Common.defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", com.aliyun.teautil.Common.defaultString(runtime.backoffPolicy, "no")),
                new TeaPair("period", com.aliyun.teautil.Common.defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL)
        );

        TeaRequest _lastRequest = null;
        long _now = System.currentTimeMillis();
        int _retryTimes = 0;
        while (Tea.allowRetry((java.util.Map<String, Object>) runtime_.get("retry"), _retryTimes, _now)) {
            if (_retryTimes > 0) {
                int backoffTime = Tea.getBackoffTime(runtime_.get("backoff"), _retryTimes);
                if (backoffTime > 0) {
                    Tea.sleep(backoffTime);
                }
            }
            _retryTimes = _retryTimes + 1;
            try {
                TeaRequest request_ = new TeaRequest();
                String accessKeyId = _credential.getAccessKeyId();
                String accessKeySecret = _credential.getAccessKeySecret();
                String token = _credential.getSecurityToken();
                request_.protocol = _protocol;
                request_.method = "PUT";
                request_.pathname = "/" + request.channelName + "?live";
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("host", com.aliyun.ossutil.Client.getHost(request.bucketName, _regionId, _endpoint, _hostModel)),
                    new TeaPair("date", com.aliyun.teautil.Common.getDateUTCString()),
                    new TeaPair("user-agent", this.getUserAgent())
                );
                if (!com.aliyun.teautil.Common.empty(token)) {
                    request_.headers.put("x-oss-security-token", token);
                }

                request_.query = com.aliyun.teautil.Common.stringifyMapValue(TeaModel.buildMap(request.filter));
                request_.headers.put("authorization", com.aliyun.ossutil.Client.getSignature(request_, request.bucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                String bodyStr = null;
                if (com.aliyun.teautil.Common.is4xx(response_.statusCode) || com.aliyun.teautil.Common.is5xx(response_.statusCode)) {
                    bodyStr = com.aliyun.teautil.Common.readAsString(response_.body);
                    respMap = com.aliyun.ossutil.Client.getErrMessage(bodyStr);
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("code", respMap.get("Code")),
                        new TeaPair("message", respMap.get("Message")),
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("httpCode", response_.statusCode),
                            new TeaPair("requestId", respMap.get("RequestId")),
                            new TeaPair("hostId", respMap.get("HostId"))
                        ))
                    ));
                }

                return TeaModel.toModel(TeaConverter.merge(String.class,
                    response_.headers
                ), new PutLiveChannelStatusResponse());
            } catch (Exception e) {
                if (Tea.isRetryable(e)) {
                    continue;
                }
                throw e;
            }
        }

        throw new TeaUnretryableException(_lastRequest);
    }

    public InitiateMultipartUploadResponse initiateMultipartUpload(InitiateMultipartUploadRequest request, com.aliyun.ossutil.models.RuntimeOptions runtime) throws Exception {
        TeaModel.validateParams(request, "request");
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", com.aliyun.teautil.Common.defaultNumber(runtime.readTimeout, _readTimeout)),
            new TeaPair("connectTimeout", com.aliyun.teautil.Common.defaultNumber(runtime.connectTimeout, _connectTimeout)),
            new TeaPair("localAddr", com.aliyun.teautil.Common.defaultString(runtime.localAddr, _localAddr)),
            new TeaPair("httpProxy", com.aliyun.teautil.Common.defaultString(runtime.httpProxy, _httpProxy)),
            new TeaPair("httpsProxy", com.aliyun.teautil.Common.defaultString(runtime.httpsProxy, _httpsProxy)),
            new TeaPair("noProxy", com.aliyun.teautil.Common.defaultString(runtime.noProxy, _noProxy)),
            new TeaPair("socks5Proxy", com.aliyun.teautil.Common.defaultString(runtime.socks5Proxy, _socks5Proxy)),
            new TeaPair("socks5NetWork", com.aliyun.teautil.Common.defaultString(runtime.socks5NetWork, _socks5NetWork)),
            new TeaPair("maxIdleConns", com.aliyun.teautil.Common.defaultNumber(runtime.maxIdleConns, _maxIdleConns)),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", com.aliyun.teautil.Common.defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", com.aliyun.teautil.Common.defaultString(runtime.backoffPolicy, "no")),
                new TeaPair("period", com.aliyun.teautil.Common.defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL)
        );

        TeaRequest _lastRequest = null;
        long _now = System.currentTimeMillis();
        int _retryTimes = 0;
        while (Tea.allowRetry((java.util.Map<String, Object>) runtime_.get("retry"), _retryTimes, _now)) {
            if (_retryTimes > 0) {
                int backoffTime = Tea.getBackoffTime(runtime_.get("backoff"), _retryTimes);
                if (backoffTime > 0) {
                    Tea.sleep(backoffTime);
                }
            }
            _retryTimes = _retryTimes + 1;
            try {
                TeaRequest request_ = new TeaRequest();
                String accessKeyId = _credential.getAccessKeyId();
                String accessKeySecret = _credential.getAccessKeySecret();
                String token = _credential.getSecurityToken();
                request_.protocol = _protocol;
                request_.method = "POST";
                request_.pathname = "/" + request.objectName + "?uploads";
                request_.headers = TeaConverter.merge(String.class,
                    TeaConverter.buildMap(
                        new TeaPair("host", com.aliyun.ossutil.Client.getHost(request.bucketName, _regionId, _endpoint, _hostModel)),
                        new TeaPair("date", com.aliyun.teautil.Common.getDateUTCString()),
                        new TeaPair("user-agent", this.getUserAgent())
                    ),
                    com.aliyun.teautil.Common.stringifyMapValue(TeaModel.buildMap(request.header))
                );
                if (!com.aliyun.teautil.Common.empty(token)) {
                    request_.headers.put("x-oss-security-token", token);
                }

                request_.query = com.aliyun.teautil.Common.stringifyMapValue(TeaModel.buildMap(request.filter));
                if (com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.header)) && !com.aliyun.teautil.Common.empty(request.header.contentType)) {
                    request_.headers.put("content-type", request.header.contentType);
                } else {
                    request_.headers.put("content-type", com.aliyun.ossutil.Client.getContentType(request.objectName));
                }

                request_.headers.put("authorization", com.aliyun.ossutil.Client.getSignature(request_, request.bucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                String bodyStr = null;
                if (com.aliyun.teautil.Common.is4xx(response_.statusCode) || com.aliyun.teautil.Common.is5xx(response_.statusCode)) {
                    bodyStr = com.aliyun.teautil.Common.readAsString(response_.body);
                    respMap = com.aliyun.ossutil.Client.getErrMessage(bodyStr);
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("code", respMap.get("Code")),
                        new TeaPair("message", respMap.get("Message")),
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("httpCode", response_.statusCode),
                            new TeaPair("requestId", respMap.get("RequestId")),
                            new TeaPair("hostId", respMap.get("HostId"))
                        ))
                    ));
                }

                bodyStr = com.aliyun.teautil.Common.readAsString(response_.body);
                respMap = com.aliyun.teaxml.Client.parseXml(bodyStr, InitiateMultipartUploadResponse.class);
                return TeaModel.toModel(TeaConverter.merge(Object.class,
                    TeaConverter.buildMap(
                        new TeaPair("InitiateMultipartUploadResult", respMap.get("InitiateMultipartUploadResult"))
                    ),
                    response_.headers
                ), new InitiateMultipartUploadResponse());
            } catch (Exception e) {
                if (Tea.isRetryable(e)) {
                    continue;
                }
                throw e;
            }
        }

        throw new TeaUnretryableException(_lastRequest);
    }

    public OptionObjectResponse optionObject(OptionObjectRequest request, com.aliyun.ossutil.models.RuntimeOptions runtime) throws Exception {
        TeaModel.validateParams(request, "request");
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", com.aliyun.teautil.Common.defaultNumber(runtime.readTimeout, _readTimeout)),
            new TeaPair("connectTimeout", com.aliyun.teautil.Common.defaultNumber(runtime.connectTimeout, _connectTimeout)),
            new TeaPair("localAddr", com.aliyun.teautil.Common.defaultString(runtime.localAddr, _localAddr)),
            new TeaPair("httpProxy", com.aliyun.teautil.Common.defaultString(runtime.httpProxy, _httpProxy)),
            new TeaPair("httpsProxy", com.aliyun.teautil.Common.defaultString(runtime.httpsProxy, _httpsProxy)),
            new TeaPair("noProxy", com.aliyun.teautil.Common.defaultString(runtime.noProxy, _noProxy)),
            new TeaPair("socks5Proxy", com.aliyun.teautil.Common.defaultString(runtime.socks5Proxy, _socks5Proxy)),
            new TeaPair("socks5NetWork", com.aliyun.teautil.Common.defaultString(runtime.socks5NetWork, _socks5NetWork)),
            new TeaPair("maxIdleConns", com.aliyun.teautil.Common.defaultNumber(runtime.maxIdleConns, _maxIdleConns)),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", com.aliyun.teautil.Common.defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", com.aliyun.teautil.Common.defaultString(runtime.backoffPolicy, "no")),
                new TeaPair("period", com.aliyun.teautil.Common.defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL)
        );

        TeaRequest _lastRequest = null;
        long _now = System.currentTimeMillis();
        int _retryTimes = 0;
        while (Tea.allowRetry((java.util.Map<String, Object>) runtime_.get("retry"), _retryTimes, _now)) {
            if (_retryTimes > 0) {
                int backoffTime = Tea.getBackoffTime(runtime_.get("backoff"), _retryTimes);
                if (backoffTime > 0) {
                    Tea.sleep(backoffTime);
                }
            }
            _retryTimes = _retryTimes + 1;
            try {
                TeaRequest request_ = new TeaRequest();
                String accessKeyId = _credential.getAccessKeyId();
                String accessKeySecret = _credential.getAccessKeySecret();
                String token = _credential.getSecurityToken();
                request_.protocol = _protocol;
                request_.method = "OPTIONS";
                request_.pathname = "/" + request.objectName + "";
                request_.headers = TeaConverter.merge(String.class,
                    TeaConverter.buildMap(
                        new TeaPair("host", com.aliyun.ossutil.Client.getHost(request.bucketName, _regionId, _endpoint, _hostModel)),
                        new TeaPair("date", com.aliyun.teautil.Common.getDateUTCString()),
                        new TeaPair("user-agent", this.getUserAgent())
                    ),
                    com.aliyun.teautil.Common.stringifyMapValue(TeaModel.buildMap(request.header))
                );
                if (!com.aliyun.teautil.Common.empty(token)) {
                    request_.headers.put("x-oss-security-token", token);
                }

                request_.headers.put("authorization", com.aliyun.ossutil.Client.getSignature(request_, request.bucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                String bodyStr = null;
                if (com.aliyun.teautil.Common.is4xx(response_.statusCode) || com.aliyun.teautil.Common.is5xx(response_.statusCode)) {
                    bodyStr = com.aliyun.teautil.Common.readAsString(response_.body);
                    respMap = com.aliyun.ossutil.Client.getErrMessage(bodyStr);
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("code", respMap.get("Code")),
                        new TeaPair("message", respMap.get("Message")),
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("httpCode", response_.statusCode),
                            new TeaPair("requestId", respMap.get("RequestId")),
                            new TeaPair("hostId", respMap.get("HostId"))
                        ))
                    ));
                }

                return TeaModel.toModel(TeaConverter.merge(String.class,
                    response_.headers
                ), new OptionObjectResponse());
            } catch (Exception e) {
                if (Tea.isRetryable(e)) {
                    continue;
                }
                throw e;
            }
        }

        throw new TeaUnretryableException(_lastRequest);
    }

    public PostVodPlaylistResponse postVodPlaylist(PostVodPlaylistRequest request, com.aliyun.ossutil.models.RuntimeOptions runtime) throws Exception {
        TeaModel.validateParams(request, "request");
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", com.aliyun.teautil.Common.defaultNumber(runtime.readTimeout, _readTimeout)),
            new TeaPair("connectTimeout", com.aliyun.teautil.Common.defaultNumber(runtime.connectTimeout, _connectTimeout)),
            new TeaPair("localAddr", com.aliyun.teautil.Common.defaultString(runtime.localAddr, _localAddr)),
            new TeaPair("httpProxy", com.aliyun.teautil.Common.defaultString(runtime.httpProxy, _httpProxy)),
            new TeaPair("httpsProxy", com.aliyun.teautil.Common.defaultString(runtime.httpsProxy, _httpsProxy)),
            new TeaPair("noProxy", com.aliyun.teautil.Common.defaultString(runtime.noProxy, _noProxy)),
            new TeaPair("socks5Proxy", com.aliyun.teautil.Common.defaultString(runtime.socks5Proxy, _socks5Proxy)),
            new TeaPair("socks5NetWork", com.aliyun.teautil.Common.defaultString(runtime.socks5NetWork, _socks5NetWork)),
            new TeaPair("maxIdleConns", com.aliyun.teautil.Common.defaultNumber(runtime.maxIdleConns, _maxIdleConns)),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", com.aliyun.teautil.Common.defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", com.aliyun.teautil.Common.defaultString(runtime.backoffPolicy, "no")),
                new TeaPair("period", com.aliyun.teautil.Common.defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL)
        );

        TeaRequest _lastRequest = null;
        long _now = System.currentTimeMillis();
        int _retryTimes = 0;
        while (Tea.allowRetry((java.util.Map<String, Object>) runtime_.get("retry"), _retryTimes, _now)) {
            if (_retryTimes > 0) {
                int backoffTime = Tea.getBackoffTime(runtime_.get("backoff"), _retryTimes);
                if (backoffTime > 0) {
                    Tea.sleep(backoffTime);
                }
            }
            _retryTimes = _retryTimes + 1;
            try {
                TeaRequest request_ = new TeaRequest();
                String accessKeyId = _credential.getAccessKeyId();
                String accessKeySecret = _credential.getAccessKeySecret();
                String token = _credential.getSecurityToken();
                request_.protocol = _protocol;
                request_.method = "POST";
                request_.pathname = "/" + request.channelName + "/" + request.playlistName + "?vod";
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("host", com.aliyun.ossutil.Client.getHost(request.bucketName, _regionId, _endpoint, _hostModel)),
                    new TeaPair("date", com.aliyun.teautil.Common.getDateUTCString()),
                    new TeaPair("user-agent", this.getUserAgent())
                );
                if (!com.aliyun.teautil.Common.empty(token)) {
                    request_.headers.put("x-oss-security-token", token);
                }

                request_.query = com.aliyun.teautil.Common.stringifyMapValue(TeaModel.buildMap(request.filter));
                request_.headers.put("authorization", com.aliyun.ossutil.Client.getSignature(request_, request.bucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                String bodyStr = null;
                if (com.aliyun.teautil.Common.is4xx(response_.statusCode) || com.aliyun.teautil.Common.is5xx(response_.statusCode)) {
                    bodyStr = com.aliyun.teautil.Common.readAsString(response_.body);
                    respMap = com.aliyun.ossutil.Client.getErrMessage(bodyStr);
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("code", respMap.get("Code")),
                        new TeaPair("message", respMap.get("Message")),
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("httpCode", response_.statusCode),
                            new TeaPair("requestId", respMap.get("RequestId")),
                            new TeaPair("hostId", respMap.get("HostId"))
                        ))
                    ));
                }

                return TeaModel.toModel(TeaConverter.merge(String.class,
                    response_.headers
                ), new PostVodPlaylistResponse());
            } catch (Exception e) {
                if (Tea.isRetryable(e)) {
                    continue;
                }
                throw e;
            }
        }

        throw new TeaUnretryableException(_lastRequest);
    }

    public PostObjectResponse postObject(PostObjectRequest request, com.aliyun.ossutil.models.RuntimeOptions runtime) throws Exception {
        TeaModel.validateParams(request, "request");
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", com.aliyun.teautil.Common.defaultNumber(runtime.readTimeout, _readTimeout)),
            new TeaPair("connectTimeout", com.aliyun.teautil.Common.defaultNumber(runtime.connectTimeout, _connectTimeout)),
            new TeaPair("httpProxy", com.aliyun.teautil.Common.defaultString(runtime.httpProxy, _httpProxy)),
            new TeaPair("httpsProxy", com.aliyun.teautil.Common.defaultString(runtime.httpsProxy, _httpsProxy)),
            new TeaPair("noProxy", com.aliyun.teautil.Common.defaultString(runtime.noProxy, _noProxy)),
            new TeaPair("maxIdleConns", com.aliyun.teautil.Common.defaultNumber(runtime.maxIdleConns, _maxIdleConns)),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("max-attempts", com.aliyun.teautil.Common.defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", com.aliyun.teautil.Common.defaultString(runtime.backoffPolicy, "no")),
                new TeaPair("period", com.aliyun.teautil.Common.defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL)
        );

        TeaRequest _lastRequest = null;
        long _now = System.currentTimeMillis();
        int _retryTimes = 0;
        while (Tea.allowRetry((java.util.Map<String, Object>) runtime_.get("retry"), _retryTimes, _now)) {
            if (_retryTimes > 0) {
                int backoffTime = Tea.getBackoffTime(runtime_.get("backoff"), _retryTimes);
                if (backoffTime > 0) {
                    Tea.sleep(backoffTime);
                }
            }
            _retryTimes = _retryTimes + 1;
            try {
                TeaRequest request_ = new TeaRequest();
                String boundary = com.aliyun.fileform.Client.getBoundary();
                request_.protocol = _protocol;
                request_.method = "POST";
                request_.pathname = "/";
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("host", com.aliyun.ossutil.Client.getHost("", _regionId, _endpoint, _hostModel)),
                    new TeaPair("date", com.aliyun.teautil.Common.getDateUTCString()),
                    new TeaPair("user-agent", this.getUserAgent())
                );
                request_.headers.put("content-type", "multipart/form-data; boundary=" + boundary + "");
                java.util.Map<String, Object> form = TeaConverter.merge(Object.class,
                    TeaConverter.buildMap(
                        new TeaPair("OSSAccessKeyId", request.header.accessKeyId),
                        new TeaPair("policy", request.header.policy),
                        new TeaPair("Signature", request.header.signature),
                        new TeaPair("key", request.header.key),
                        new TeaPair("success_action_status", request.header.successActionStatus),
                        new TeaPair("file", request.header.file)
                    ),
                    com.aliyun.ossutil.Client.toMeta(request.header.userMeta, "x-oss-meta-")
                );
                request_.body = com.aliyun.fileform.Client.toFileForm(form, boundary);
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                String bodyStr = com.aliyun.teautil.Common.readAsString(response_.body);
                if (com.aliyun.teautil.Common.is4xx(response_.statusCode) || com.aliyun.teautil.Common.is5xx(response_.statusCode)) {
                    respMap = com.aliyun.ossutil.Client.getErrMessage(bodyStr);
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("code", respMap.get("Code")),
                        new TeaPair("message", respMap.get("Message")),
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("httpCode", response_.statusCode),
                            new TeaPair("requestId", respMap.get("RequestId")),
                            new TeaPair("hostId", respMap.get("HostId"))
                        ))
                    ));
                }

                respMap = com.aliyun.teaxml.Client.parseXml(bodyStr, PostObjectResponse.class);
                return TeaModel.toModel(TeaConverter.merge(Object.class,
                    respMap
                ), new PostObjectResponse());
            } catch (Exception e) {
                if (Tea.isRetryable(e)) {
                    continue;
                }
                throw e;
            }
        }

        throw new TeaUnretryableException(_lastRequest);
    }

    public HeadObjectResponse headObject(HeadObjectRequest request, com.aliyun.ossutil.models.RuntimeOptions runtime) throws Exception {
        TeaModel.validateParams(request, "request");
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", com.aliyun.teautil.Common.defaultNumber(runtime.readTimeout, _readTimeout)),
            new TeaPair("connectTimeout", com.aliyun.teautil.Common.defaultNumber(runtime.connectTimeout, _connectTimeout)),
            new TeaPair("localAddr", com.aliyun.teautil.Common.defaultString(runtime.localAddr, _localAddr)),
            new TeaPair("httpProxy", com.aliyun.teautil.Common.defaultString(runtime.httpProxy, _httpProxy)),
            new TeaPair("httpsProxy", com.aliyun.teautil.Common.defaultString(runtime.httpsProxy, _httpsProxy)),
            new TeaPair("noProxy", com.aliyun.teautil.Common.defaultString(runtime.noProxy, _noProxy)),
            new TeaPair("socks5Proxy", com.aliyun.teautil.Common.defaultString(runtime.socks5Proxy, _socks5Proxy)),
            new TeaPair("socks5NetWork", com.aliyun.teautil.Common.defaultString(runtime.socks5NetWork, _socks5NetWork)),
            new TeaPair("maxIdleConns", com.aliyun.teautil.Common.defaultNumber(runtime.maxIdleConns, _maxIdleConns)),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", com.aliyun.teautil.Common.defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", com.aliyun.teautil.Common.defaultString(runtime.backoffPolicy, "no")),
                new TeaPair("period", com.aliyun.teautil.Common.defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL)
        );

        TeaRequest _lastRequest = null;
        long _now = System.currentTimeMillis();
        int _retryTimes = 0;
        while (Tea.allowRetry((java.util.Map<String, Object>) runtime_.get("retry"), _retryTimes, _now)) {
            if (_retryTimes > 0) {
                int backoffTime = Tea.getBackoffTime(runtime_.get("backoff"), _retryTimes);
                if (backoffTime > 0) {
                    Tea.sleep(backoffTime);
                }
            }
            _retryTimes = _retryTimes + 1;
            try {
                TeaRequest request_ = new TeaRequest();
                String accessKeyId = _credential.getAccessKeyId();
                String accessKeySecret = _credential.getAccessKeySecret();
                String token = _credential.getSecurityToken();
                request_.protocol = _protocol;
                request_.method = "HEAD";
                request_.pathname = "/" + request.objectName + "";
                request_.headers = TeaConverter.merge(String.class,
                    TeaConverter.buildMap(
                        new TeaPair("host", com.aliyun.ossutil.Client.getHost(request.bucketName, _regionId, _endpoint, _hostModel)),
                        new TeaPair("date", com.aliyun.teautil.Common.getDateUTCString()),
                        new TeaPair("user-agent", this.getUserAgent())
                    ),
                    com.aliyun.teautil.Common.stringifyMapValue(TeaModel.buildMap(request.header))
                );
                if (!com.aliyun.teautil.Common.empty(token)) {
                    request_.headers.put("x-oss-security-token", token);
                }

                request_.headers.put("authorization", com.aliyun.ossutil.Client.getSignature(request_, request.bucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                String bodyStr = null;
                if (com.aliyun.teautil.Common.is4xx(response_.statusCode) || com.aliyun.teautil.Common.is5xx(response_.statusCode)) {
                    bodyStr = com.aliyun.teautil.Common.readAsString(response_.body);
                    respMap = com.aliyun.ossutil.Client.getErrMessage(bodyStr);
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("code", respMap.get("Code")),
                        new TeaPair("message", respMap.get("Message")),
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("httpCode", response_.statusCode),
                            new TeaPair("requestId", respMap.get("RequestId")),
                            new TeaPair("hostId", respMap.get("HostId"))
                        ))
                    ));
                }

                return TeaModel.toModel(TeaConverter.merge(Object.class,
                    TeaConverter.buildMap(
                        new TeaPair("usermeta", com.aliyun.ossutil.Client.toMeta(response_.headers, "x-oss-meta-"))
                    ),
                    response_.headers
                ), new HeadObjectResponse());
            } catch (Exception e) {
                if (Tea.isRetryable(e)) {
                    continue;
                }
                throw e;
            }
        }

        throw new TeaUnretryableException(_lastRequest);
    }

    public DeleteObjectTaggingResponse deleteObjectTagging(DeleteObjectTaggingRequest request, com.aliyun.ossutil.models.RuntimeOptions runtime) throws Exception {
        TeaModel.validateParams(request, "request");
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", com.aliyun.teautil.Common.defaultNumber(runtime.readTimeout, _readTimeout)),
            new TeaPair("connectTimeout", com.aliyun.teautil.Common.defaultNumber(runtime.connectTimeout, _connectTimeout)),
            new TeaPair("localAddr", com.aliyun.teautil.Common.defaultString(runtime.localAddr, _localAddr)),
            new TeaPair("httpProxy", com.aliyun.teautil.Common.defaultString(runtime.httpProxy, _httpProxy)),
            new TeaPair("httpsProxy", com.aliyun.teautil.Common.defaultString(runtime.httpsProxy, _httpsProxy)),
            new TeaPair("noProxy", com.aliyun.teautil.Common.defaultString(runtime.noProxy, _noProxy)),
            new TeaPair("socks5Proxy", com.aliyun.teautil.Common.defaultString(runtime.socks5Proxy, _socks5Proxy)),
            new TeaPair("socks5NetWork", com.aliyun.teautil.Common.defaultString(runtime.socks5NetWork, _socks5NetWork)),
            new TeaPair("maxIdleConns", com.aliyun.teautil.Common.defaultNumber(runtime.maxIdleConns, _maxIdleConns)),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", com.aliyun.teautil.Common.defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", com.aliyun.teautil.Common.defaultString(runtime.backoffPolicy, "no")),
                new TeaPair("period", com.aliyun.teautil.Common.defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL)
        );

        TeaRequest _lastRequest = null;
        long _now = System.currentTimeMillis();
        int _retryTimes = 0;
        while (Tea.allowRetry((java.util.Map<String, Object>) runtime_.get("retry"), _retryTimes, _now)) {
            if (_retryTimes > 0) {
                int backoffTime = Tea.getBackoffTime(runtime_.get("backoff"), _retryTimes);
                if (backoffTime > 0) {
                    Tea.sleep(backoffTime);
                }
            }
            _retryTimes = _retryTimes + 1;
            try {
                TeaRequest request_ = new TeaRequest();
                String accessKeyId = _credential.getAccessKeyId();
                String accessKeySecret = _credential.getAccessKeySecret();
                String token = _credential.getSecurityToken();
                request_.protocol = _protocol;
                request_.method = "DELETE";
                request_.pathname = "/" + request.objectName + "?tagging";
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("host", com.aliyun.ossutil.Client.getHost(request.bucketName, _regionId, _endpoint, _hostModel)),
                    new TeaPair("date", com.aliyun.teautil.Common.getDateUTCString()),
                    new TeaPair("user-agent", this.getUserAgent())
                );
                if (!com.aliyun.teautil.Common.empty(token)) {
                    request_.headers.put("x-oss-security-token", token);
                }

                request_.headers.put("authorization", com.aliyun.ossutil.Client.getSignature(request_, request.bucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                String bodyStr = null;
                if (com.aliyun.teautil.Common.is4xx(response_.statusCode) || com.aliyun.teautil.Common.is5xx(response_.statusCode)) {
                    bodyStr = com.aliyun.teautil.Common.readAsString(response_.body);
                    respMap = com.aliyun.ossutil.Client.getErrMessage(bodyStr);
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("code", respMap.get("Code")),
                        new TeaPair("message", respMap.get("Message")),
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("httpCode", response_.statusCode),
                            new TeaPair("requestId", respMap.get("RequestId")),
                            new TeaPair("hostId", respMap.get("HostId"))
                        ))
                    ));
                }

                return TeaModel.toModel(TeaConverter.merge(String.class,
                    response_.headers
                ), new DeleteObjectTaggingResponse());
            } catch (Exception e) {
                if (Tea.isRetryable(e)) {
                    continue;
                }
                throw e;
            }
        }

        throw new TeaUnretryableException(_lastRequest);
    }

    public RestoreObjectResponse restoreObject(RestoreObjectRequest request, com.aliyun.ossutil.models.RuntimeOptions runtime) throws Exception {
        TeaModel.validateParams(request, "request");
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", com.aliyun.teautil.Common.defaultNumber(runtime.readTimeout, _readTimeout)),
            new TeaPair("connectTimeout", com.aliyun.teautil.Common.defaultNumber(runtime.connectTimeout, _connectTimeout)),
            new TeaPair("localAddr", com.aliyun.teautil.Common.defaultString(runtime.localAddr, _localAddr)),
            new TeaPair("httpProxy", com.aliyun.teautil.Common.defaultString(runtime.httpProxy, _httpProxy)),
            new TeaPair("httpsProxy", com.aliyun.teautil.Common.defaultString(runtime.httpsProxy, _httpsProxy)),
            new TeaPair("noProxy", com.aliyun.teautil.Common.defaultString(runtime.noProxy, _noProxy)),
            new TeaPair("socks5Proxy", com.aliyun.teautil.Common.defaultString(runtime.socks5Proxy, _socks5Proxy)),
            new TeaPair("socks5NetWork", com.aliyun.teautil.Common.defaultString(runtime.socks5NetWork, _socks5NetWork)),
            new TeaPair("maxIdleConns", com.aliyun.teautil.Common.defaultNumber(runtime.maxIdleConns, _maxIdleConns)),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", com.aliyun.teautil.Common.defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", com.aliyun.teautil.Common.defaultString(runtime.backoffPolicy, "no")),
                new TeaPair("period", com.aliyun.teautil.Common.defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL)
        );

        TeaRequest _lastRequest = null;
        long _now = System.currentTimeMillis();
        int _retryTimes = 0;
        while (Tea.allowRetry((java.util.Map<String, Object>) runtime_.get("retry"), _retryTimes, _now)) {
            if (_retryTimes > 0) {
                int backoffTime = Tea.getBackoffTime(runtime_.get("backoff"), _retryTimes);
                if (backoffTime > 0) {
                    Tea.sleep(backoffTime);
                }
            }
            _retryTimes = _retryTimes + 1;
            try {
                TeaRequest request_ = new TeaRequest();
                String accessKeyId = _credential.getAccessKeyId();
                String accessKeySecret = _credential.getAccessKeySecret();
                String token = _credential.getSecurityToken();
                request_.protocol = _protocol;
                request_.method = "POST";
                request_.pathname = "/" + request.objectName + "?restore";
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("host", com.aliyun.ossutil.Client.getHost(request.bucketName, _regionId, _endpoint, _hostModel)),
                    new TeaPair("date", com.aliyun.teautil.Common.getDateUTCString()),
                    new TeaPair("user-agent", this.getUserAgent())
                );
                if (!com.aliyun.teautil.Common.empty(token)) {
                    request_.headers.put("x-oss-security-token", token);
                }

                request_.headers.put("authorization", com.aliyun.ossutil.Client.getSignature(request_, request.bucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                String bodyStr = null;
                if (com.aliyun.teautil.Common.is4xx(response_.statusCode) || com.aliyun.teautil.Common.is5xx(response_.statusCode)) {
                    bodyStr = com.aliyun.teautil.Common.readAsString(response_.body);
                    respMap = com.aliyun.ossutil.Client.getErrMessage(bodyStr);
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("code", respMap.get("Code")),
                        new TeaPair("message", respMap.get("Message")),
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("httpCode", response_.statusCode),
                            new TeaPair("requestId", respMap.get("RequestId")),
                            new TeaPair("hostId", respMap.get("HostId"))
                        ))
                    ));
                }

                return TeaModel.toModel(TeaConverter.merge(String.class,
                    response_.headers
                ), new RestoreObjectResponse());
            } catch (Exception e) {
                if (Tea.isRetryable(e)) {
                    continue;
                }
                throw e;
            }
        }

        throw new TeaUnretryableException(_lastRequest);
    }

    public GetObjectAclResponse getObjectAcl(GetObjectAclRequest request, com.aliyun.ossutil.models.RuntimeOptions runtime) throws Exception {
        TeaModel.validateParams(request, "request");
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", com.aliyun.teautil.Common.defaultNumber(runtime.readTimeout, _readTimeout)),
            new TeaPair("connectTimeout", com.aliyun.teautil.Common.defaultNumber(runtime.connectTimeout, _connectTimeout)),
            new TeaPair("localAddr", com.aliyun.teautil.Common.defaultString(runtime.localAddr, _localAddr)),
            new TeaPair("httpProxy", com.aliyun.teautil.Common.defaultString(runtime.httpProxy, _httpProxy)),
            new TeaPair("httpsProxy", com.aliyun.teautil.Common.defaultString(runtime.httpsProxy, _httpsProxy)),
            new TeaPair("noProxy", com.aliyun.teautil.Common.defaultString(runtime.noProxy, _noProxy)),
            new TeaPair("socks5Proxy", com.aliyun.teautil.Common.defaultString(runtime.socks5Proxy, _socks5Proxy)),
            new TeaPair("socks5NetWork", com.aliyun.teautil.Common.defaultString(runtime.socks5NetWork, _socks5NetWork)),
            new TeaPair("maxIdleConns", com.aliyun.teautil.Common.defaultNumber(runtime.maxIdleConns, _maxIdleConns)),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", com.aliyun.teautil.Common.defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", com.aliyun.teautil.Common.defaultString(runtime.backoffPolicy, "no")),
                new TeaPair("period", com.aliyun.teautil.Common.defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL)
        );

        TeaRequest _lastRequest = null;
        long _now = System.currentTimeMillis();
        int _retryTimes = 0;
        while (Tea.allowRetry((java.util.Map<String, Object>) runtime_.get("retry"), _retryTimes, _now)) {
            if (_retryTimes > 0) {
                int backoffTime = Tea.getBackoffTime(runtime_.get("backoff"), _retryTimes);
                if (backoffTime > 0) {
                    Tea.sleep(backoffTime);
                }
            }
            _retryTimes = _retryTimes + 1;
            try {
                TeaRequest request_ = new TeaRequest();
                String accessKeyId = _credential.getAccessKeyId();
                String accessKeySecret = _credential.getAccessKeySecret();
                String token = _credential.getSecurityToken();
                request_.protocol = _protocol;
                request_.method = "GET";
                request_.pathname = "/" + request.objectName + "?acl";
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("host", com.aliyun.ossutil.Client.getHost(request.bucketName, _regionId, _endpoint, _hostModel)),
                    new TeaPair("date", com.aliyun.teautil.Common.getDateUTCString()),
                    new TeaPair("user-agent", this.getUserAgent())
                );
                if (!com.aliyun.teautil.Common.empty(token)) {
                    request_.headers.put("x-oss-security-token", token);
                }

                request_.headers.put("authorization", com.aliyun.ossutil.Client.getSignature(request_, request.bucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                String bodyStr = null;
                if (com.aliyun.teautil.Common.is4xx(response_.statusCode) || com.aliyun.teautil.Common.is5xx(response_.statusCode)) {
                    bodyStr = com.aliyun.teautil.Common.readAsString(response_.body);
                    respMap = com.aliyun.ossutil.Client.getErrMessage(bodyStr);
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("code", respMap.get("Code")),
                        new TeaPair("message", respMap.get("Message")),
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("httpCode", response_.statusCode),
                            new TeaPair("requestId", respMap.get("RequestId")),
                            new TeaPair("hostId", respMap.get("HostId"))
                        ))
                    ));
                }

                bodyStr = com.aliyun.teautil.Common.readAsString(response_.body);
                respMap = com.aliyun.teaxml.Client.parseXml(bodyStr, GetObjectAclResponse.class);
                return TeaModel.toModel(TeaConverter.merge(Object.class,
                    TeaConverter.buildMap(
                        new TeaPair("AccessControlPolicy", respMap.get("AccessControlPolicy"))
                    ),
                    response_.headers
                ), new GetObjectAclResponse());
            } catch (Exception e) {
                if (Tea.isRetryable(e)) {
                    continue;
                }
                throw e;
            }
        }

        throw new TeaUnretryableException(_lastRequest);
    }

    public PutBucketAclResponse putBucketAcl(PutBucketAclRequest request, com.aliyun.ossutil.models.RuntimeOptions runtime) throws Exception {
        TeaModel.validateParams(request, "request");
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", com.aliyun.teautil.Common.defaultNumber(runtime.readTimeout, _readTimeout)),
            new TeaPair("connectTimeout", com.aliyun.teautil.Common.defaultNumber(runtime.connectTimeout, _connectTimeout)),
            new TeaPair("localAddr", com.aliyun.teautil.Common.defaultString(runtime.localAddr, _localAddr)),
            new TeaPair("httpProxy", com.aliyun.teautil.Common.defaultString(runtime.httpProxy, _httpProxy)),
            new TeaPair("httpsProxy", com.aliyun.teautil.Common.defaultString(runtime.httpsProxy, _httpsProxy)),
            new TeaPair("noProxy", com.aliyun.teautil.Common.defaultString(runtime.noProxy, _noProxy)),
            new TeaPair("socks5Proxy", com.aliyun.teautil.Common.defaultString(runtime.socks5Proxy, _socks5Proxy)),
            new TeaPair("socks5NetWork", com.aliyun.teautil.Common.defaultString(runtime.socks5NetWork, _socks5NetWork)),
            new TeaPair("maxIdleConns", com.aliyun.teautil.Common.defaultNumber(runtime.maxIdleConns, _maxIdleConns)),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", com.aliyun.teautil.Common.defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", com.aliyun.teautil.Common.defaultString(runtime.backoffPolicy, "no")),
                new TeaPair("period", com.aliyun.teautil.Common.defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL)
        );

        TeaRequest _lastRequest = null;
        long _now = System.currentTimeMillis();
        int _retryTimes = 0;
        while (Tea.allowRetry((java.util.Map<String, Object>) runtime_.get("retry"), _retryTimes, _now)) {
            if (_retryTimes > 0) {
                int backoffTime = Tea.getBackoffTime(runtime_.get("backoff"), _retryTimes);
                if (backoffTime > 0) {
                    Tea.sleep(backoffTime);
                }
            }
            _retryTimes = _retryTimes + 1;
            try {
                TeaRequest request_ = new TeaRequest();
                String accessKeyId = _credential.getAccessKeyId();
                String accessKeySecret = _credential.getAccessKeySecret();
                String token = _credential.getSecurityToken();
                request_.protocol = _protocol;
                request_.method = "PUT";
                request_.pathname = "/?acl";
                request_.headers = TeaConverter.merge(String.class,
                    TeaConverter.buildMap(
                        new TeaPair("host", com.aliyun.ossutil.Client.getHost(request.bucketName, _regionId, _endpoint, _hostModel)),
                        new TeaPair("date", com.aliyun.teautil.Common.getDateUTCString()),
                        new TeaPair("user-agent", this.getUserAgent())
                    ),
                    com.aliyun.teautil.Common.stringifyMapValue(TeaModel.buildMap(request.header))
                );
                if (!com.aliyun.teautil.Common.empty(token)) {
                    request_.headers.put("x-oss-security-token", token);
                }

                request_.headers.put("authorization", com.aliyun.ossutil.Client.getSignature(request_, request.bucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                String bodyStr = null;
                if (com.aliyun.teautil.Common.is4xx(response_.statusCode) || com.aliyun.teautil.Common.is5xx(response_.statusCode)) {
                    bodyStr = com.aliyun.teautil.Common.readAsString(response_.body);
                    respMap = com.aliyun.ossutil.Client.getErrMessage(bodyStr);
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("code", respMap.get("Code")),
                        new TeaPair("message", respMap.get("Message")),
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("httpCode", response_.statusCode),
                            new TeaPair("requestId", respMap.get("RequestId")),
                            new TeaPair("hostId", respMap.get("HostId"))
                        ))
                    ));
                }

                return TeaModel.toModel(TeaConverter.merge(String.class,
                    response_.headers
                ), new PutBucketAclResponse());
            } catch (Exception e) {
                if (Tea.isRetryable(e)) {
                    continue;
                }
                throw e;
            }
        }

        throw new TeaUnretryableException(_lastRequest);
    }

    public DeleteBucketResponse deleteBucket(DeleteBucketRequest request, com.aliyun.ossutil.models.RuntimeOptions runtime) throws Exception {
        TeaModel.validateParams(request, "request");
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", com.aliyun.teautil.Common.defaultNumber(runtime.readTimeout, _readTimeout)),
            new TeaPair("connectTimeout", com.aliyun.teautil.Common.defaultNumber(runtime.connectTimeout, _connectTimeout)),
            new TeaPair("localAddr", com.aliyun.teautil.Common.defaultString(runtime.localAddr, _localAddr)),
            new TeaPair("httpProxy", com.aliyun.teautil.Common.defaultString(runtime.httpProxy, _httpProxy)),
            new TeaPair("httpsProxy", com.aliyun.teautil.Common.defaultString(runtime.httpsProxy, _httpsProxy)),
            new TeaPair("noProxy", com.aliyun.teautil.Common.defaultString(runtime.noProxy, _noProxy)),
            new TeaPair("socks5Proxy", com.aliyun.teautil.Common.defaultString(runtime.socks5Proxy, _socks5Proxy)),
            new TeaPair("socks5NetWork", com.aliyun.teautil.Common.defaultString(runtime.socks5NetWork, _socks5NetWork)),
            new TeaPair("maxIdleConns", com.aliyun.teautil.Common.defaultNumber(runtime.maxIdleConns, _maxIdleConns)),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", com.aliyun.teautil.Common.defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", com.aliyun.teautil.Common.defaultString(runtime.backoffPolicy, "no")),
                new TeaPair("period", com.aliyun.teautil.Common.defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL)
        );

        TeaRequest _lastRequest = null;
        long _now = System.currentTimeMillis();
        int _retryTimes = 0;
        while (Tea.allowRetry((java.util.Map<String, Object>) runtime_.get("retry"), _retryTimes, _now)) {
            if (_retryTimes > 0) {
                int backoffTime = Tea.getBackoffTime(runtime_.get("backoff"), _retryTimes);
                if (backoffTime > 0) {
                    Tea.sleep(backoffTime);
                }
            }
            _retryTimes = _retryTimes + 1;
            try {
                TeaRequest request_ = new TeaRequest();
                String accessKeyId = _credential.getAccessKeyId();
                String accessKeySecret = _credential.getAccessKeySecret();
                String token = _credential.getSecurityToken();
                request_.protocol = _protocol;
                request_.method = "DELETE";
                request_.pathname = "/";
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("host", com.aliyun.ossutil.Client.getHost(request.bucketName, _regionId, _endpoint, _hostModel)),
                    new TeaPair("date", com.aliyun.teautil.Common.getDateUTCString()),
                    new TeaPair("user-agent", this.getUserAgent())
                );
                if (!com.aliyun.teautil.Common.empty(token)) {
                    request_.headers.put("x-oss-security-token", token);
                }

                request_.headers.put("authorization", com.aliyun.ossutil.Client.getSignature(request_, request.bucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                String bodyStr = null;
                if (com.aliyun.teautil.Common.is4xx(response_.statusCode) || com.aliyun.teautil.Common.is5xx(response_.statusCode)) {
                    bodyStr = com.aliyun.teautil.Common.readAsString(response_.body);
                    respMap = com.aliyun.ossutil.Client.getErrMessage(bodyStr);
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("code", respMap.get("Code")),
                        new TeaPair("message", respMap.get("Message")),
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("httpCode", response_.statusCode),
                            new TeaPair("requestId", respMap.get("RequestId")),
                            new TeaPair("hostId", respMap.get("HostId"))
                        ))
                    ));
                }

                return TeaModel.toModel(TeaConverter.merge(String.class,
                    response_.headers
                ), new DeleteBucketResponse());
            } catch (Exception e) {
                if (Tea.isRetryable(e)) {
                    continue;
                }
                throw e;
            }
        }

        throw new TeaUnretryableException(_lastRequest);
    }

    public PutObjectResponse putObject(PutObjectRequest request, com.aliyun.ossutil.models.RuntimeOptions runtime) throws Exception {
        TeaModel.validateParams(request, "request");
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", com.aliyun.teautil.Common.defaultNumber(runtime.readTimeout, _readTimeout)),
            new TeaPair("connectTimeout", com.aliyun.teautil.Common.defaultNumber(runtime.connectTimeout, _connectTimeout)),
            new TeaPair("localAddr", com.aliyun.teautil.Common.defaultString(runtime.localAddr, _localAddr)),
            new TeaPair("httpProxy", com.aliyun.teautil.Common.defaultString(runtime.httpProxy, _httpProxy)),
            new TeaPair("httpsProxy", com.aliyun.teautil.Common.defaultString(runtime.httpsProxy, _httpsProxy)),
            new TeaPair("noProxy", com.aliyun.teautil.Common.defaultString(runtime.noProxy, _noProxy)),
            new TeaPair("socks5Proxy", com.aliyun.teautil.Common.defaultString(runtime.socks5Proxy, _socks5Proxy)),
            new TeaPair("socks5NetWork", com.aliyun.teautil.Common.defaultString(runtime.socks5NetWork, _socks5NetWork)),
            new TeaPair("maxIdleConns", com.aliyun.teautil.Common.defaultNumber(runtime.maxIdleConns, _maxIdleConns)),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", com.aliyun.teautil.Common.defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", com.aliyun.teautil.Common.defaultString(runtime.backoffPolicy, "no")),
                new TeaPair("period", com.aliyun.teautil.Common.defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL)
        );

        TeaRequest _lastRequest = null;
        long _now = System.currentTimeMillis();
        int _retryTimes = 0;
        while (Tea.allowRetry((java.util.Map<String, Object>) runtime_.get("retry"), _retryTimes, _now)) {
            if (_retryTimes > 0) {
                int backoffTime = Tea.getBackoffTime(runtime_.get("backoff"), _retryTimes);
                if (backoffTime > 0) {
                    Tea.sleep(backoffTime);
                }
            }
            _retryTimes = _retryTimes + 1;
            try {
                TeaRequest request_ = new TeaRequest();
                java.util.Map<String, String> ctx = new java.util.HashMap<>();
                String accessKeyId = _credential.getAccessKeyId();
                String accessKeySecret = _credential.getAccessKeySecret();
                String token = _credential.getSecurityToken();
                request_.protocol = _protocol;
                request_.method = "PUT";
                request_.pathname = "/" + request.objectName + "";
                request_.headers = TeaConverter.merge(String.class,
                    TeaConverter.buildMap(
                        new TeaPair("host", com.aliyun.ossutil.Client.getHost(request.bucketName, _regionId, _endpoint, _hostModel)),
                        new TeaPair("date", com.aliyun.teautil.Common.getDateUTCString()),
                        new TeaPair("user-agent", this.getUserAgent())
                    ),
                    com.aliyun.teautil.Common.stringifyMapValue(TeaModel.buildMap(request.header)),
                    com.aliyun.ossutil.Client.parseMeta(request.userMeta, "x-oss-meta-")
                );
                if (!com.aliyun.teautil.Common.empty(token)) {
                    request_.headers.put("x-oss-security-token", token);
                }

                request_.body = com.aliyun.ossutil.Client.inject(request.body, ctx);
                if (com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.header)) && !com.aliyun.teautil.Common.empty(request.header.contentType)) {
                    request_.headers.put("content-type", request.header.contentType);
                } else {
                    request_.headers.put("content-type", com.aliyun.ossutil.Client.getContentType(request.objectName));
                }

                request_.headers.put("authorization", com.aliyun.ossutil.Client.getSignature(request_, request.bucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                String bodyStr = null;
                if (com.aliyun.teautil.Common.is4xx(response_.statusCode) || com.aliyun.teautil.Common.is5xx(response_.statusCode)) {
                    bodyStr = com.aliyun.teautil.Common.readAsString(response_.body);
                    respMap = com.aliyun.ossutil.Client.getErrMessage(bodyStr);
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("code", respMap.get("Code")),
                        new TeaPair("message", respMap.get("Message")),
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("httpCode", response_.statusCode),
                            new TeaPair("requestId", respMap.get("RequestId")),
                            new TeaPair("hostId", respMap.get("HostId"))
                        ))
                    ));
                }

                if (_isEnableCrc && !com.aliyun.teautil.Common.equalString(ctx.get("crc"), response_.headers.get("x-oss-hash-crc64ecma"))) {
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("code", "CrcNotMatched"),
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("clientCrc", ctx.get("crc")),
                            new TeaPair("serverCrc", response_.headers.get("x-oss-hash-crc64ecma"))
                        ))
                    ));
                }

                if (_isEnableMD5 && !com.aliyun.teautil.Common.equalString(ctx.get("md5"), response_.headers.get("content-md5"))) {
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("code", "MD5NotMatched"),
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("clientMD5", ctx.get("md5")),
                            new TeaPair("serverMD5", response_.headers.get("content-md5"))
                        ))
                    ));
                }

                return TeaModel.toModel(TeaConverter.merge(String.class,
                    response_.headers
                ), new PutObjectResponse());
            } catch (Exception e) {
                if (Tea.isRetryable(e)) {
                    continue;
                }
                throw e;
            }
        }

        throw new TeaUnretryableException(_lastRequest);
    }

    public void setUserAgent(String userAgent) throws Exception {
        this._userAgent = userAgent;
    }

    public void appendUserAgent(String userAgent) throws Exception {
        this._userAgent = "" + _userAgent + " " + userAgent + "";
    }

    public String getUserAgent() throws Exception {
        String userAgent = com.aliyun.teautil.Common.getUserAgent(_userAgent);
        return userAgent;
    }

    public String getAccessKeyId() throws Exception {
        if (com.aliyun.teautil.Common.isUnset(_credential)) {
            return "";
        }

        String accessKeyId = _credential.getAccessKeyId();
        return accessKeyId;
    }

    public String getAccessKeySecret() throws Exception {
        if (com.aliyun.teautil.Common.isUnset(_credential)) {
            return "";
        }

        String secret = _credential.getAccessKeySecret();
        return secret;
    }
}
