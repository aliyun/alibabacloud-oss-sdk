// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss;

import com.aliyun.tea.*;
import com.aliyun.oss.models.*;
import com.aliyun.oss.baseclient.BaseClient;

public class Client extends BaseClient {

    public Client(Config config) throws Exception {
        super(config.toMap());
    }

    public PutBucketLifecycleResponse putBucketLifecycle(PutBucketLifecycleRequest request, RuntimeObject runtime) throws Exception {
        request.validate();
        runtime.validate();
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", this._defaultNumber(runtime.readTimeout, _readTimeout)),
            new TeaPair("connectTimeout", this._defaultNumber(runtime.connectTimeout, _connectTimeout)),
            new TeaPair("localAddr", this._default(runtime.localAddr, _localAddr)),
            new TeaPair("httpProxy", this._default(runtime.httpProxy, _httpProxy)),
            new TeaPair("httpsProxy", this._default(runtime.httpsProxy, _httpsProxy)),
            new TeaPair("noProxy", this._default(runtime.noProxy, _noProxy)),
            new TeaPair("socks5Proxy", this._default(runtime.socks5Proxy, _socks5Proxy)),
            new TeaPair("socks5NetWork", this._default(runtime.socks5NetWork, _socks5NetWork)),
            new TeaPair("maxIdleConns", this._defaultNumber(runtime.maxIdleConns, _maxIdleConns)),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", this._defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", this._default(runtime.backoffPolicy, "no")),
                new TeaPair("period", this._defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL),
            new TeaPair("logger", _logger),
            new TeaPair("listener", runtime.listener)
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
                String token = this._getSecurityToken();
                String reqBody = this._toXML(TeaModel.buildMap(request.body));
                request_.protocol = _protocol;
                request_.method = "PUT";
                request_.pathname = "/?lifecycle";
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("host", this.getHost(request.bucketName)),
                    new TeaPair("date", this._getDate()),
                    new TeaPair("user-agent", this._getUserAgent())
                );
                if (!this._empty(token)) {
                    request_.headers.put("x-oss-security-token", token);
                }

                request_.body = Tea.toReadable(reqBody);
                request_.headers.put("authorization", this.getSignature(request_, request.bucketName));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                String bodyStr = null;
                if (this._isFail(response_)) {
                    bodyStr = this._readAsString(response_);
                    respMap = this._getErrMessage(bodyStr);
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

    public DeleteMultipleObjectsResponse deleteMultipleObjects(DeleteMultipleObjectsRequest request, RuntimeObject runtime) throws Exception {
        request.validate();
        runtime.validate();
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", this._defaultNumber(runtime.readTimeout, _readTimeout)),
            new TeaPair("connectTimeout", this._defaultNumber(runtime.connectTimeout, _connectTimeout)),
            new TeaPair("localAddr", this._default(runtime.localAddr, _localAddr)),
            new TeaPair("httpProxy", this._default(runtime.httpProxy, _httpProxy)),
            new TeaPair("httpsProxy", this._default(runtime.httpsProxy, _httpsProxy)),
            new TeaPair("noProxy", this._default(runtime.noProxy, _noProxy)),
            new TeaPair("socks5Proxy", this._default(runtime.socks5Proxy, _socks5Proxy)),
            new TeaPair("socks5NetWork", this._default(runtime.socks5NetWork, _socks5NetWork)),
            new TeaPair("maxIdleConns", this._defaultNumber(runtime.maxIdleConns, _maxIdleConns)),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", this._defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", this._default(runtime.backoffPolicy, "no")),
                new TeaPair("period", this._defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL),
            new TeaPair("logger", _logger),
            new TeaPair("listener", runtime.listener)
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
                String token = this._getSecurityToken();
                String reqBody = this._toXML(TeaModel.buildMap(request.body));
                request_.protocol = _protocol;
                request_.method = "POST";
                request_.pathname = "/?delete";
                request_.headers = TeaConverter.merge(String.class, 
                    TeaConverter.buildMap(
                        new TeaPair("host", this.getHost(request.bucketName)),
                        new TeaPair("date", this._getDate()),
                        new TeaPair("user-agent", this._getUserAgent())
                    ),
                    this._toHeader(TeaModel.buildMap(request.header))
                );
                if (!this._empty(token)) {
                    request_.headers.put("x-oss-security-token", token);
                }

                request_.body = Tea.toReadable(reqBody);
                if (this._notNull(TeaModel.buildMap(request.header)) && !this._empty(request.header.contentMD5)) {
                    request_.headers.put("content-md5", request.header.contentMD5);
                } else {
                    request_.headers.put("content-md5", this._getContentMD5(reqBody));
                }

                request_.headers.put("authorization", this.getSignature(request_, request.bucketName));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                String bodyStr = null;
                if (this._isFail(response_)) {
                    bodyStr = this._readAsString(response_);
                    respMap = this._getErrMessage(bodyStr);
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

                bodyStr = this._readAsString(response_);
                respMap = this._parseXml(bodyStr, DeleteMultipleObjectsResponse.class);
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

    public PutBucketRefererResponse putBucketReferer(PutBucketRefererRequest request, RuntimeObject runtime) throws Exception {
        request.validate();
        runtime.validate();
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", this._defaultNumber(runtime.readTimeout, _readTimeout)),
            new TeaPair("connectTimeout", this._defaultNumber(runtime.connectTimeout, _connectTimeout)),
            new TeaPair("localAddr", this._default(runtime.localAddr, _localAddr)),
            new TeaPair("httpProxy", this._default(runtime.httpProxy, _httpProxy)),
            new TeaPair("httpsProxy", this._default(runtime.httpsProxy, _httpsProxy)),
            new TeaPair("noProxy", this._default(runtime.noProxy, _noProxy)),
            new TeaPair("socks5Proxy", this._default(runtime.socks5Proxy, _socks5Proxy)),
            new TeaPair("socks5NetWork", this._default(runtime.socks5NetWork, _socks5NetWork)),
            new TeaPair("maxIdleConns", this._defaultNumber(runtime.maxIdleConns, _maxIdleConns)),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", this._defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", this._default(runtime.backoffPolicy, "no")),
                new TeaPair("period", this._defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL),
            new TeaPair("logger", _logger),
            new TeaPair("listener", runtime.listener)
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
                String token = this._getSecurityToken();
                String reqBody = this._toXML(TeaModel.buildMap(request.body));
                request_.protocol = _protocol;
                request_.method = "PUT";
                request_.pathname = "/?referer";
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("host", this.getHost(request.bucketName)),
                    new TeaPair("date", this._getDate()),
                    new TeaPair("user-agent", this._getUserAgent())
                );
                if (!this._empty(token)) {
                    request_.headers.put("x-oss-security-token", token);
                }

                request_.body = Tea.toReadable(reqBody);
                request_.headers.put("authorization", this.getSignature(request_, request.bucketName));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                String bodyStr = null;
                if (this._isFail(response_)) {
                    bodyStr = this._readAsString(response_);
                    respMap = this._getErrMessage(bodyStr);
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

    public PutBucketWebsiteResponse putBucketWebsite(PutBucketWebsiteRequest request, RuntimeObject runtime) throws Exception {
        request.validate();
        runtime.validate();
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", this._defaultNumber(runtime.readTimeout, _readTimeout)),
            new TeaPair("connectTimeout", this._defaultNumber(runtime.connectTimeout, _connectTimeout)),
            new TeaPair("localAddr", this._default(runtime.localAddr, _localAddr)),
            new TeaPair("httpProxy", this._default(runtime.httpProxy, _httpProxy)),
            new TeaPair("httpsProxy", this._default(runtime.httpsProxy, _httpsProxy)),
            new TeaPair("noProxy", this._default(runtime.noProxy, _noProxy)),
            new TeaPair("socks5Proxy", this._default(runtime.socks5Proxy, _socks5Proxy)),
            new TeaPair("socks5NetWork", this._default(runtime.socks5NetWork, _socks5NetWork)),
            new TeaPair("maxIdleConns", this._defaultNumber(runtime.maxIdleConns, _maxIdleConns)),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", this._defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", this._default(runtime.backoffPolicy, "no")),
                new TeaPair("period", this._defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL),
            new TeaPair("logger", _logger),
            new TeaPair("listener", runtime.listener)
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
                String token = this._getSecurityToken();
                String reqBody = this._toXML(TeaModel.buildMap(request.body));
                request_.protocol = _protocol;
                request_.method = "PUT";
                request_.pathname = "/?website";
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("host", this.getHost(request.bucketName)),
                    new TeaPair("date", this._getDate()),
                    new TeaPair("user-agent", this._getUserAgent())
                );
                if (!this._empty(token)) {
                    request_.headers.put("x-oss-security-token", token);
                }

                request_.body = Tea.toReadable(reqBody);
                request_.headers.put("authorization", this.getSignature(request_, request.bucketName));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                String bodyStr = null;
                if (this._isFail(response_)) {
                    bodyStr = this._readAsString(response_);
                    respMap = this._getErrMessage(bodyStr);
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

    public CompleteMultipartUploadResponse completeMultipartUpload(CompleteMultipartUploadRequest request, RuntimeObject runtime) throws Exception {
        request.validate();
        runtime.validate();
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", this._defaultNumber(runtime.readTimeout, _readTimeout)),
            new TeaPair("connectTimeout", this._defaultNumber(runtime.connectTimeout, _connectTimeout)),
            new TeaPair("localAddr", this._default(runtime.localAddr, _localAddr)),
            new TeaPair("httpProxy", this._default(runtime.httpProxy, _httpProxy)),
            new TeaPair("httpsProxy", this._default(runtime.httpsProxy, _httpsProxy)),
            new TeaPair("noProxy", this._default(runtime.noProxy, _noProxy)),
            new TeaPair("socks5Proxy", this._default(runtime.socks5Proxy, _socks5Proxy)),
            new TeaPair("socks5NetWork", this._default(runtime.socks5NetWork, _socks5NetWork)),
            new TeaPair("maxIdleConns", this._defaultNumber(runtime.maxIdleConns, _maxIdleConns)),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", this._defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", this._default(runtime.backoffPolicy, "no")),
                new TeaPair("period", this._defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL),
            new TeaPair("logger", _logger),
            new TeaPair("listener", runtime.listener)
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
                String token = this._getSecurityToken();
                String reqBody = this._toXML(TeaModel.buildMap(request.body));
                request_.protocol = _protocol;
                request_.method = "POST";
                request_.pathname = "/" + request.objectName + "";
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("host", this.getHost(request.bucketName)),
                    new TeaPair("date", this._getDate()),
                    new TeaPair("user-agent", this._getUserAgent())
                );
                if (!this._empty(token)) {
                    request_.headers.put("x-oss-security-token", token);
                }

                request_.query = this._toQuery(TeaModel.buildMap(request.filter));
                request_.body = Tea.toReadable(reqBody);
                request_.headers.put("authorization", this.getSignature(request_, request.bucketName));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                String bodyStr = null;
                if (this._isFail(response_)) {
                    bodyStr = this._readAsString(response_);
                    respMap = this._getErrMessage(bodyStr);
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

                bodyStr = this._readAsString(response_);
                respMap = this._parseXml(bodyStr, CompleteMultipartUploadResponse.class);
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

    public PutBucketLoggingResponse putBucketLogging(PutBucketLoggingRequest request, RuntimeObject runtime) throws Exception {
        request.validate();
        runtime.validate();
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", this._defaultNumber(runtime.readTimeout, _readTimeout)),
            new TeaPair("connectTimeout", this._defaultNumber(runtime.connectTimeout, _connectTimeout)),
            new TeaPair("localAddr", this._default(runtime.localAddr, _localAddr)),
            new TeaPair("httpProxy", this._default(runtime.httpProxy, _httpProxy)),
            new TeaPair("httpsProxy", this._default(runtime.httpsProxy, _httpsProxy)),
            new TeaPair("noProxy", this._default(runtime.noProxy, _noProxy)),
            new TeaPair("socks5Proxy", this._default(runtime.socks5Proxy, _socks5Proxy)),
            new TeaPair("socks5NetWork", this._default(runtime.socks5NetWork, _socks5NetWork)),
            new TeaPair("maxIdleConns", this._defaultNumber(runtime.maxIdleConns, _maxIdleConns)),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", this._defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", this._default(runtime.backoffPolicy, "no")),
                new TeaPair("period", this._defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL),
            new TeaPair("logger", _logger),
            new TeaPair("listener", runtime.listener)
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
                String token = this._getSecurityToken();
                String reqBody = this._toXML(TeaModel.buildMap(request.body));
                request_.protocol = _protocol;
                request_.method = "PUT";
                request_.pathname = "/?logging";
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("host", this.getHost(request.bucketName)),
                    new TeaPair("date", this._getDate()),
                    new TeaPair("user-agent", this._getUserAgent())
                );
                if (!this._empty(token)) {
                    request_.headers.put("x-oss-security-token", token);
                }

                request_.body = Tea.toReadable(reqBody);
                request_.headers.put("authorization", this.getSignature(request_, request.bucketName));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                String bodyStr = null;
                if (this._isFail(response_)) {
                    bodyStr = this._readAsString(response_);
                    respMap = this._getErrMessage(bodyStr);
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

    public PutBucketRequestPaymentResponse putBucketRequestPayment(PutBucketRequestPaymentRequest request, RuntimeObject runtime) throws Exception {
        request.validate();
        runtime.validate();
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", this._defaultNumber(runtime.readTimeout, _readTimeout)),
            new TeaPair("connectTimeout", this._defaultNumber(runtime.connectTimeout, _connectTimeout)),
            new TeaPair("localAddr", this._default(runtime.localAddr, _localAddr)),
            new TeaPair("httpProxy", this._default(runtime.httpProxy, _httpProxy)),
            new TeaPair("httpsProxy", this._default(runtime.httpsProxy, _httpsProxy)),
            new TeaPair("noProxy", this._default(runtime.noProxy, _noProxy)),
            new TeaPair("socks5Proxy", this._default(runtime.socks5Proxy, _socks5Proxy)),
            new TeaPair("socks5NetWork", this._default(runtime.socks5NetWork, _socks5NetWork)),
            new TeaPair("maxIdleConns", this._defaultNumber(runtime.maxIdleConns, _maxIdleConns)),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", this._defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", this._default(runtime.backoffPolicy, "no")),
                new TeaPair("period", this._defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL),
            new TeaPair("logger", _logger),
            new TeaPair("listener", runtime.listener)
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
                String token = this._getSecurityToken();
                String reqBody = this._toXML(TeaModel.buildMap(request.body));
                request_.protocol = _protocol;
                request_.method = "PUT";
                request_.pathname = "/?requestPayment";
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("host", this.getHost(request.bucketName)),
                    new TeaPair("date", this._getDate()),
                    new TeaPair("user-agent", this._getUserAgent())
                );
                if (!this._empty(token)) {
                    request_.headers.put("x-oss-security-token", token);
                }

                request_.body = Tea.toReadable(reqBody);
                request_.headers.put("authorization", this.getSignature(request_, request.bucketName));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                String bodyStr = null;
                if (this._isFail(response_)) {
                    bodyStr = this._readAsString(response_);
                    respMap = this._getErrMessage(bodyStr);
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

    public PutBucketEncryptionResponse putBucketEncryption(PutBucketEncryptionRequest request, RuntimeObject runtime) throws Exception {
        request.validate();
        runtime.validate();
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", this._defaultNumber(runtime.readTimeout, _readTimeout)),
            new TeaPair("connectTimeout", this._defaultNumber(runtime.connectTimeout, _connectTimeout)),
            new TeaPair("localAddr", this._default(runtime.localAddr, _localAddr)),
            new TeaPair("httpProxy", this._default(runtime.httpProxy, _httpProxy)),
            new TeaPair("httpsProxy", this._default(runtime.httpsProxy, _httpsProxy)),
            new TeaPair("noProxy", this._default(runtime.noProxy, _noProxy)),
            new TeaPair("socks5Proxy", this._default(runtime.socks5Proxy, _socks5Proxy)),
            new TeaPair("socks5NetWork", this._default(runtime.socks5NetWork, _socks5NetWork)),
            new TeaPair("maxIdleConns", this._defaultNumber(runtime.maxIdleConns, _maxIdleConns)),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", this._defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", this._default(runtime.backoffPolicy, "no")),
                new TeaPair("period", this._defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL),
            new TeaPair("logger", _logger),
            new TeaPair("listener", runtime.listener)
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
                String token = this._getSecurityToken();
                String reqBody = this._toXML(TeaModel.buildMap(request.body));
                request_.protocol = _protocol;
                request_.method = "PUT";
                request_.pathname = "/?encryption";
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("host", this.getHost(request.bucketName)),
                    new TeaPair("date", this._getDate()),
                    new TeaPair("user-agent", this._getUserAgent())
                );
                if (!this._empty(token)) {
                    request_.headers.put("x-oss-security-token", token);
                }

                request_.body = Tea.toReadable(reqBody);
                request_.headers.put("authorization", this.getSignature(request_, request.bucketName));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                String bodyStr = null;
                if (this._isFail(response_)) {
                    bodyStr = this._readAsString(response_);
                    respMap = this._getErrMessage(bodyStr);
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

    public PutLiveChannelResponse putLiveChannel(PutLiveChannelRequest request, RuntimeObject runtime) throws Exception {
        request.validate();
        runtime.validate();
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", this._defaultNumber(runtime.readTimeout, _readTimeout)),
            new TeaPair("connectTimeout", this._defaultNumber(runtime.connectTimeout, _connectTimeout)),
            new TeaPair("localAddr", this._default(runtime.localAddr, _localAddr)),
            new TeaPair("httpProxy", this._default(runtime.httpProxy, _httpProxy)),
            new TeaPair("httpsProxy", this._default(runtime.httpsProxy, _httpsProxy)),
            new TeaPair("noProxy", this._default(runtime.noProxy, _noProxy)),
            new TeaPair("socks5Proxy", this._default(runtime.socks5Proxy, _socks5Proxy)),
            new TeaPair("socks5NetWork", this._default(runtime.socks5NetWork, _socks5NetWork)),
            new TeaPair("maxIdleConns", this._defaultNumber(runtime.maxIdleConns, _maxIdleConns)),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", this._defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", this._default(runtime.backoffPolicy, "no")),
                new TeaPair("period", this._defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL),
            new TeaPair("logger", _logger),
            new TeaPair("listener", runtime.listener)
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
                String token = this._getSecurityToken();
                String reqBody = this._toXML(TeaModel.buildMap(request.body));
                request_.protocol = _protocol;
                request_.method = "PUT";
                request_.pathname = "/" + request.channelName + "?live";
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("host", this.getHost(request.bucketName)),
                    new TeaPair("date", this._getDate()),
                    new TeaPair("user-agent", this._getUserAgent())
                );
                if (!this._empty(token)) {
                    request_.headers.put("x-oss-security-token", token);
                }

                request_.body = Tea.toReadable(reqBody);
                request_.headers.put("authorization", this.getSignature(request_, request.bucketName));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                String bodyStr = null;
                if (this._isFail(response_)) {
                    bodyStr = this._readAsString(response_);
                    respMap = this._getErrMessage(bodyStr);
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

                bodyStr = this._readAsString(response_);
                respMap = this._parseXml(bodyStr, PutLiveChannelResponse.class);
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

    public PutBucketTagsResponse putBucketTags(PutBucketTagsRequest request, RuntimeObject runtime) throws Exception {
        request.validate();
        runtime.validate();
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", this._defaultNumber(runtime.readTimeout, _readTimeout)),
            new TeaPair("connectTimeout", this._defaultNumber(runtime.connectTimeout, _connectTimeout)),
            new TeaPair("localAddr", this._default(runtime.localAddr, _localAddr)),
            new TeaPair("httpProxy", this._default(runtime.httpProxy, _httpProxy)),
            new TeaPair("httpsProxy", this._default(runtime.httpsProxy, _httpsProxy)),
            new TeaPair("noProxy", this._default(runtime.noProxy, _noProxy)),
            new TeaPair("socks5Proxy", this._default(runtime.socks5Proxy, _socks5Proxy)),
            new TeaPair("socks5NetWork", this._default(runtime.socks5NetWork, _socks5NetWork)),
            new TeaPair("maxIdleConns", this._defaultNumber(runtime.maxIdleConns, _maxIdleConns)),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", this._defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", this._default(runtime.backoffPolicy, "no")),
                new TeaPair("period", this._defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL),
            new TeaPair("logger", _logger),
            new TeaPair("listener", runtime.listener)
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
                String token = this._getSecurityToken();
                String reqBody = this._toXML(TeaModel.buildMap(request.body));
                request_.protocol = _protocol;
                request_.method = "PUT";
                request_.pathname = "/?tagging";
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("host", this.getHost(request.bucketName)),
                    new TeaPair("date", this._getDate()),
                    new TeaPair("user-agent", this._getUserAgent())
                );
                if (!this._empty(token)) {
                    request_.headers.put("x-oss-security-token", token);
                }

                request_.body = Tea.toReadable(reqBody);
                request_.headers.put("authorization", this.getSignature(request_, request.bucketName));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                String bodyStr = null;
                if (this._isFail(response_)) {
                    bodyStr = this._readAsString(response_);
                    respMap = this._getErrMessage(bodyStr);
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

    public PutObjectTaggingResponse putObjectTagging(PutObjectTaggingRequest request, RuntimeObject runtime) throws Exception {
        request.validate();
        runtime.validate();
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", this._defaultNumber(runtime.readTimeout, _readTimeout)),
            new TeaPair("connectTimeout", this._defaultNumber(runtime.connectTimeout, _connectTimeout)),
            new TeaPair("localAddr", this._default(runtime.localAddr, _localAddr)),
            new TeaPair("httpProxy", this._default(runtime.httpProxy, _httpProxy)),
            new TeaPair("httpsProxy", this._default(runtime.httpsProxy, _httpsProxy)),
            new TeaPair("noProxy", this._default(runtime.noProxy, _noProxy)),
            new TeaPair("socks5Proxy", this._default(runtime.socks5Proxy, _socks5Proxy)),
            new TeaPair("socks5NetWork", this._default(runtime.socks5NetWork, _socks5NetWork)),
            new TeaPair("maxIdleConns", this._defaultNumber(runtime.maxIdleConns, _maxIdleConns)),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", this._defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", this._default(runtime.backoffPolicy, "no")),
                new TeaPair("period", this._defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL),
            new TeaPair("logger", _logger),
            new TeaPair("listener", runtime.listener)
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
                String token = this._getSecurityToken();
                String reqBody = this._toXML(TeaModel.buildMap(request.body));
                request_.protocol = _protocol;
                request_.method = "PUT";
                request_.pathname = "/" + request.objectName + "?tagging";
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("host", this.getHost(request.bucketName)),
                    new TeaPair("date", this._getDate()),
                    new TeaPair("user-agent", this._getUserAgent())
                );
                if (!this._empty(token)) {
                    request_.headers.put("x-oss-security-token", token);
                }

                request_.body = Tea.toReadable(reqBody);
                request_.headers.put("authorization", this.getSignature(request_, request.bucketName));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                String bodyStr = null;
                if (this._isFail(response_)) {
                    bodyStr = this._readAsString(response_);
                    respMap = this._getErrMessage(bodyStr);
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

    public SelectObjectResponse selectObject(SelectObjectRequest request, RuntimeObject runtime) throws Exception {
        request.validate();
        runtime.validate();
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", this._defaultNumber(runtime.readTimeout, _readTimeout)),
            new TeaPair("connectTimeout", this._defaultNumber(runtime.connectTimeout, _connectTimeout)),
            new TeaPair("localAddr", this._default(runtime.localAddr, _localAddr)),
            new TeaPair("httpProxy", this._default(runtime.httpProxy, _httpProxy)),
            new TeaPair("httpsProxy", this._default(runtime.httpsProxy, _httpsProxy)),
            new TeaPair("noProxy", this._default(runtime.noProxy, _noProxy)),
            new TeaPair("socks5Proxy", this._default(runtime.socks5Proxy, _socks5Proxy)),
            new TeaPair("socks5NetWork", this._default(runtime.socks5NetWork, _socks5NetWork)),
            new TeaPair("maxIdleConns", this._defaultNumber(runtime.maxIdleConns, _maxIdleConns)),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", this._defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", this._default(runtime.backoffPolicy, "no")),
                new TeaPair("period", this._defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL),
            new TeaPair("logger", _logger),
            new TeaPair("listener", runtime.listener)
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
                String token = this._getSecurityToken();
                String reqBody = this._toXML(TeaModel.buildMap(request.body));
                request_.protocol = _protocol;
                request_.method = "POST";
                request_.pathname = "/" + request.objectName + "";
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("host", this.getHost(request.bucketName)),
                    new TeaPair("date", this._getDate()),
                    new TeaPair("user-agent", this._getUserAgent())
                );
                if (!this._empty(token)) {
                    request_.headers.put("x-oss-security-token", token);
                }

                request_.query = this._toQuery(TeaModel.buildMap(request.filter));
                request_.body = Tea.toReadable(reqBody);
                request_.headers.put("authorization", this.getSignature(request_, request.bucketName));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                String bodyStr = null;
                if (this._isFail(response_)) {
                    bodyStr = this._readAsString(response_);
                    respMap = this._getErrMessage(bodyStr);
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

    public PutBucketCORSResponse putBucketCORS(PutBucketCORSRequest request, RuntimeObject runtime) throws Exception {
        request.validate();
        runtime.validate();
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", this._defaultNumber(runtime.readTimeout, _readTimeout)),
            new TeaPair("connectTimeout", this._defaultNumber(runtime.connectTimeout, _connectTimeout)),
            new TeaPair("localAddr", this._default(runtime.localAddr, _localAddr)),
            new TeaPair("httpProxy", this._default(runtime.httpProxy, _httpProxy)),
            new TeaPair("httpsProxy", this._default(runtime.httpsProxy, _httpsProxy)),
            new TeaPair("noProxy", this._default(runtime.noProxy, _noProxy)),
            new TeaPair("socks5Proxy", this._default(runtime.socks5Proxy, _socks5Proxy)),
            new TeaPair("socks5NetWork", this._default(runtime.socks5NetWork, _socks5NetWork)),
            new TeaPair("maxIdleConns", this._defaultNumber(runtime.maxIdleConns, _maxIdleConns)),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", this._defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", this._default(runtime.backoffPolicy, "no")),
                new TeaPair("period", this._defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL),
            new TeaPair("logger", _logger),
            new TeaPair("listener", runtime.listener)
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
                String token = this._getSecurityToken();
                String reqBody = this._toXML(TeaModel.buildMap(request.body));
                request_.protocol = _protocol;
                request_.method = "PUT";
                request_.pathname = "/?cors";
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("host", this.getHost(request.bucketName)),
                    new TeaPair("date", this._getDate()),
                    new TeaPair("user-agent", this._getUserAgent())
                );
                if (!this._empty(token)) {
                    request_.headers.put("x-oss-security-token", token);
                }

                request_.body = Tea.toReadable(reqBody);
                request_.headers.put("authorization", this.getSignature(request_, request.bucketName));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                String bodyStr = null;
                if (this._isFail(response_)) {
                    bodyStr = this._readAsString(response_);
                    respMap = this._getErrMessage(bodyStr);
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

    public PutBucketResponse putBucket(PutBucketRequest request, RuntimeObject runtime) throws Exception {
        request.validate();
        runtime.validate();
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", this._defaultNumber(runtime.readTimeout, _readTimeout)),
            new TeaPair("connectTimeout", this._defaultNumber(runtime.connectTimeout, _connectTimeout)),
            new TeaPair("localAddr", this._default(runtime.localAddr, _localAddr)),
            new TeaPair("httpProxy", this._default(runtime.httpProxy, _httpProxy)),
            new TeaPair("httpsProxy", this._default(runtime.httpsProxy, _httpsProxy)),
            new TeaPair("noProxy", this._default(runtime.noProxy, _noProxy)),
            new TeaPair("socks5Proxy", this._default(runtime.socks5Proxy, _socks5Proxy)),
            new TeaPair("socks5NetWork", this._default(runtime.socks5NetWork, _socks5NetWork)),
            new TeaPair("maxIdleConns", this._defaultNumber(runtime.maxIdleConns, _maxIdleConns)),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", this._defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", this._default(runtime.backoffPolicy, "no")),
                new TeaPair("period", this._defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL),
            new TeaPair("logger", _logger),
            new TeaPair("listener", runtime.listener)
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
                String token = this._getSecurityToken();
                String reqBody = this._toXML(TeaModel.buildMap(request.body));
                request_.protocol = _protocol;
                request_.method = "PUT";
                request_.pathname = "/";
                request_.headers = TeaConverter.merge(String.class, 
                    TeaConverter.buildMap(
                        new TeaPair("host", this.getHost(request.bucketName)),
                        new TeaPair("date", this._getDate()),
                        new TeaPair("user-agent", this._getUserAgent())
                    ),
                    this._toHeader(TeaModel.buildMap(request.header))
                );
                if (!this._empty(token)) {
                    request_.headers.put("x-oss-security-token", token);
                }

                request_.body = Tea.toReadable(reqBody);
                request_.headers.put("authorization", this.getSignature(request_, request.bucketName));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                String bodyStr = null;
                if (this._isFail(response_)) {
                    bodyStr = this._readAsString(response_);
                    respMap = this._getErrMessage(bodyStr);
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

    public ListMultipartUploadsResponse listMultipartUploads(ListMultipartUploadsRequest request, RuntimeObject runtime) throws Exception {
        request.validate();
        runtime.validate();
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", this._defaultNumber(runtime.readTimeout, _readTimeout)),
            new TeaPair("connectTimeout", this._defaultNumber(runtime.connectTimeout, _connectTimeout)),
            new TeaPair("localAddr", this._default(runtime.localAddr, _localAddr)),
            new TeaPair("httpProxy", this._default(runtime.httpProxy, _httpProxy)),
            new TeaPair("httpsProxy", this._default(runtime.httpsProxy, _httpsProxy)),
            new TeaPair("noProxy", this._default(runtime.noProxy, _noProxy)),
            new TeaPair("socks5Proxy", this._default(runtime.socks5Proxy, _socks5Proxy)),
            new TeaPair("socks5NetWork", this._default(runtime.socks5NetWork, _socks5NetWork)),
            new TeaPair("maxIdleConns", this._defaultNumber(runtime.maxIdleConns, _maxIdleConns)),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", this._defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", this._default(runtime.backoffPolicy, "no")),
                new TeaPair("period", this._defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL),
            new TeaPair("logger", _logger),
            new TeaPair("listener", runtime.listener)
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
                String token = this._getSecurityToken();
                request_.protocol = _protocol;
                request_.method = "GET";
                request_.pathname = "/?uploads";
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("host", this.getHost(request.bucketName)),
                    new TeaPair("date", this._getDate()),
                    new TeaPair("user-agent", this._getUserAgent())
                );
                if (!this._empty(token)) {
                    request_.headers.put("x-oss-security-token", token);
                }

                request_.query = this._toQuery(TeaModel.buildMap(request.filter));
                request_.headers.put("authorization", this.getSignature(request_, request.bucketName));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                String bodyStr = null;
                if (this._isFail(response_)) {
                    bodyStr = this._readAsString(response_);
                    respMap = this._getErrMessage(bodyStr);
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

                bodyStr = this._readAsString(response_);
                respMap = this._parseXml(bodyStr, ListMultipartUploadsResponse.class);
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

    public GetBucketRequestPaymentResponse getBucketRequestPayment(GetBucketRequestPaymentRequest request, RuntimeObject runtime) throws Exception {
        request.validate();
        runtime.validate();
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", this._defaultNumber(runtime.readTimeout, _readTimeout)),
            new TeaPair("connectTimeout", this._defaultNumber(runtime.connectTimeout, _connectTimeout)),
            new TeaPair("localAddr", this._default(runtime.localAddr, _localAddr)),
            new TeaPair("httpProxy", this._default(runtime.httpProxy, _httpProxy)),
            new TeaPair("httpsProxy", this._default(runtime.httpsProxy, _httpsProxy)),
            new TeaPair("noProxy", this._default(runtime.noProxy, _noProxy)),
            new TeaPair("socks5Proxy", this._default(runtime.socks5Proxy, _socks5Proxy)),
            new TeaPair("socks5NetWork", this._default(runtime.socks5NetWork, _socks5NetWork)),
            new TeaPair("maxIdleConns", this._defaultNumber(runtime.maxIdleConns, _maxIdleConns)),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", this._defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", this._default(runtime.backoffPolicy, "no")),
                new TeaPair("period", this._defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL),
            new TeaPair("logger", _logger),
            new TeaPair("listener", runtime.listener)
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
                String token = this._getSecurityToken();
                request_.protocol = _protocol;
                request_.method = "GET";
                request_.pathname = "/?requestPayment";
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("host", this.getHost(request.bucketName)),
                    new TeaPair("date", this._getDate()),
                    new TeaPair("user-agent", this._getUserAgent())
                );
                if (!this._empty(token)) {
                    request_.headers.put("x-oss-security-token", token);
                }

                request_.headers.put("authorization", this.getSignature(request_, request.bucketName));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                String bodyStr = null;
                if (this._isFail(response_)) {
                    bodyStr = this._readAsString(response_);
                    respMap = this._getErrMessage(bodyStr);
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

                bodyStr = this._readAsString(response_);
                respMap = this._parseXml(bodyStr, GetBucketRequestPaymentResponse.class);
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

    public GetBucketEncryptionResponse getBucketEncryption(GetBucketEncryptionRequest request, RuntimeObject runtime) throws Exception {
        request.validate();
        runtime.validate();
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", this._defaultNumber(runtime.readTimeout, _readTimeout)),
            new TeaPair("connectTimeout", this._defaultNumber(runtime.connectTimeout, _connectTimeout)),
            new TeaPair("localAddr", this._default(runtime.localAddr, _localAddr)),
            new TeaPair("httpProxy", this._default(runtime.httpProxy, _httpProxy)),
            new TeaPair("httpsProxy", this._default(runtime.httpsProxy, _httpsProxy)),
            new TeaPair("noProxy", this._default(runtime.noProxy, _noProxy)),
            new TeaPair("socks5Proxy", this._default(runtime.socks5Proxy, _socks5Proxy)),
            new TeaPair("socks5NetWork", this._default(runtime.socks5NetWork, _socks5NetWork)),
            new TeaPair("maxIdleConns", this._defaultNumber(runtime.maxIdleConns, _maxIdleConns)),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", this._defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", this._default(runtime.backoffPolicy, "no")),
                new TeaPair("period", this._defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL),
            new TeaPair("logger", _logger),
            new TeaPair("listener", runtime.listener)
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
                String token = this._getSecurityToken();
                request_.protocol = _protocol;
                request_.method = "GET";
                request_.pathname = "/?encryption";
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("host", this.getHost(request.bucketName)),
                    new TeaPair("date", this._getDate()),
                    new TeaPair("user-agent", this._getUserAgent())
                );
                if (!this._empty(token)) {
                    request_.headers.put("x-oss-security-token", token);
                }

                request_.headers.put("authorization", this.getSignature(request_, request.bucketName));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                String bodyStr = null;
                if (this._isFail(response_)) {
                    bodyStr = this._readAsString(response_);
                    respMap = this._getErrMessage(bodyStr);
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

                bodyStr = this._readAsString(response_);
                respMap = this._parseXml(bodyStr, GetBucketEncryptionResponse.class);
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

    public GetBucketTagsResponse getBucketTags(GetBucketTagsRequest request, RuntimeObject runtime) throws Exception {
        request.validate();
        runtime.validate();
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", this._defaultNumber(runtime.readTimeout, _readTimeout)),
            new TeaPair("connectTimeout", this._defaultNumber(runtime.connectTimeout, _connectTimeout)),
            new TeaPair("localAddr", this._default(runtime.localAddr, _localAddr)),
            new TeaPair("httpProxy", this._default(runtime.httpProxy, _httpProxy)),
            new TeaPair("httpsProxy", this._default(runtime.httpsProxy, _httpsProxy)),
            new TeaPair("noProxy", this._default(runtime.noProxy, _noProxy)),
            new TeaPair("socks5Proxy", this._default(runtime.socks5Proxy, _socks5Proxy)),
            new TeaPair("socks5NetWork", this._default(runtime.socks5NetWork, _socks5NetWork)),
            new TeaPair("maxIdleConns", this._defaultNumber(runtime.maxIdleConns, _maxIdleConns)),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", this._defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", this._default(runtime.backoffPolicy, "no")),
                new TeaPair("period", this._defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL),
            new TeaPair("logger", _logger),
            new TeaPair("listener", runtime.listener)
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
                String token = this._getSecurityToken();
                request_.protocol = _protocol;
                request_.method = "GET";
                request_.pathname = "/?tagging";
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("host", this.getHost(request.bucketName)),
                    new TeaPair("date", this._getDate()),
                    new TeaPair("user-agent", this._getUserAgent())
                );
                if (!this._empty(token)) {
                    request_.headers.put("x-oss-security-token", token);
                }

                request_.headers.put("authorization", this.getSignature(request_, request.bucketName));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                String bodyStr = null;
                if (this._isFail(response_)) {
                    bodyStr = this._readAsString(response_);
                    respMap = this._getErrMessage(bodyStr);
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

                bodyStr = this._readAsString(response_);
                respMap = this._parseXml(bodyStr, GetBucketTagsResponse.class);
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

    public GetServiceResponse getService(GetServiceRequest request, RuntimeObject runtime) throws Exception {
        request.validate();
        runtime.validate();
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", this._defaultNumber(runtime.readTimeout, _readTimeout)),
            new TeaPair("connectTimeout", this._defaultNumber(runtime.connectTimeout, _connectTimeout)),
            new TeaPair("localAddr", this._default(runtime.localAddr, _localAddr)),
            new TeaPair("httpProxy", this._default(runtime.httpProxy, _httpProxy)),
            new TeaPair("httpsProxy", this._default(runtime.httpsProxy, _httpsProxy)),
            new TeaPair("noProxy", this._default(runtime.noProxy, _noProxy)),
            new TeaPair("socks5Proxy", this._default(runtime.socks5Proxy, _socks5Proxy)),
            new TeaPair("socks5NetWork", this._default(runtime.socks5NetWork, _socks5NetWork)),
            new TeaPair("maxIdleConns", this._defaultNumber(runtime.maxIdleConns, _maxIdleConns)),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", this._defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", this._default(runtime.backoffPolicy, "no")),
                new TeaPair("period", this._defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL),
            new TeaPair("logger", _logger),
            new TeaPair("listener", runtime.listener)
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
                String token = this._getSecurityToken();
                request_.protocol = _protocol;
                request_.method = "GET";
                request_.pathname = "/";
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("host", this.getHost("")),
                    new TeaPair("date", this._getDate()),
                    new TeaPair("user-agent", this._getUserAgent())
                );
                if (!this._empty(token)) {
                    request_.headers.put("x-oss-security-token", token);
                }

                request_.query = this._toQuery(TeaModel.buildMap(request.filter));
                request_.headers.put("authorization", this.getSignature(request_, ""));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                String bodyStr = null;
                if (this._isFail(response_)) {
                    bodyStr = this._readAsString(response_);
                    respMap = this._getErrMessage(bodyStr);
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

                bodyStr = this._readAsString(response_);
                respMap = this._parseXml(bodyStr, GetServiceResponse.class);
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

    public DeleteBucketEncryptionResponse deleteBucketEncryption(DeleteBucketEncryptionRequest request, RuntimeObject runtime) throws Exception {
        request.validate();
        runtime.validate();
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", this._defaultNumber(runtime.readTimeout, _readTimeout)),
            new TeaPair("connectTimeout", this._defaultNumber(runtime.connectTimeout, _connectTimeout)),
            new TeaPair("localAddr", this._default(runtime.localAddr, _localAddr)),
            new TeaPair("httpProxy", this._default(runtime.httpProxy, _httpProxy)),
            new TeaPair("httpsProxy", this._default(runtime.httpsProxy, _httpsProxy)),
            new TeaPair("noProxy", this._default(runtime.noProxy, _noProxy)),
            new TeaPair("socks5Proxy", this._default(runtime.socks5Proxy, _socks5Proxy)),
            new TeaPair("socks5NetWork", this._default(runtime.socks5NetWork, _socks5NetWork)),
            new TeaPair("maxIdleConns", this._defaultNumber(runtime.maxIdleConns, _maxIdleConns)),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", this._defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", this._default(runtime.backoffPolicy, "no")),
                new TeaPair("period", this._defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL),
            new TeaPair("logger", _logger),
            new TeaPair("listener", runtime.listener)
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
                String token = this._getSecurityToken();
                request_.protocol = _protocol;
                request_.method = "DELETE";
                request_.pathname = "/?encryption";
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("host", this.getHost(request.bucketName)),
                    new TeaPair("date", this._getDate()),
                    new TeaPair("user-agent", this._getUserAgent())
                );
                if (!this._empty(token)) {
                    request_.headers.put("x-oss-security-token", token);
                }

                request_.headers.put("authorization", this.getSignature(request_, request.bucketName));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                String bodyStr = null;
                if (this._isFail(response_)) {
                    bodyStr = this._readAsString(response_);
                    respMap = this._getErrMessage(bodyStr);
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

    public DeleteBucketTagsResponse deleteBucketTags(DeleteBucketTagsRequest request, RuntimeObject runtime) throws Exception {
        request.validate();
        runtime.validate();
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", this._defaultNumber(runtime.readTimeout, _readTimeout)),
            new TeaPair("connectTimeout", this._defaultNumber(runtime.connectTimeout, _connectTimeout)),
            new TeaPair("localAddr", this._default(runtime.localAddr, _localAddr)),
            new TeaPair("httpProxy", this._default(runtime.httpProxy, _httpProxy)),
            new TeaPair("httpsProxy", this._default(runtime.httpsProxy, _httpsProxy)),
            new TeaPair("noProxy", this._default(runtime.noProxy, _noProxy)),
            new TeaPair("socks5Proxy", this._default(runtime.socks5Proxy, _socks5Proxy)),
            new TeaPair("socks5NetWork", this._default(runtime.socks5NetWork, _socks5NetWork)),
            new TeaPair("maxIdleConns", this._defaultNumber(runtime.maxIdleConns, _maxIdleConns)),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", this._defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", this._default(runtime.backoffPolicy, "no")),
                new TeaPair("period", this._defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL),
            new TeaPair("logger", _logger),
            new TeaPair("listener", runtime.listener)
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
                String token = this._getSecurityToken();
                request_.protocol = _protocol;
                request_.method = "DELETE";
                request_.pathname = "/";
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("host", this.getHost(request.bucketName)),
                    new TeaPair("date", this._getDate()),
                    new TeaPair("user-agent", this._getUserAgent())
                );
                if (!this._empty(token)) {
                    request_.headers.put("x-oss-security-token", token);
                }

                request_.query = this._toQuery(TeaModel.buildMap(request.filter));
                request_.headers.put("authorization", this.getSignature(request_, request.bucketName));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                String bodyStr = null;
                if (this._isFail(response_)) {
                    bodyStr = this._readAsString(response_);
                    respMap = this._getErrMessage(bodyStr);
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

    public GetBucketWebsiteResponse getBucketWebsite(GetBucketWebsiteRequest request, RuntimeObject runtime) throws Exception {
        request.validate();
        runtime.validate();
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", this._defaultNumber(runtime.readTimeout, _readTimeout)),
            new TeaPair("connectTimeout", this._defaultNumber(runtime.connectTimeout, _connectTimeout)),
            new TeaPair("localAddr", this._default(runtime.localAddr, _localAddr)),
            new TeaPair("httpProxy", this._default(runtime.httpProxy, _httpProxy)),
            new TeaPair("httpsProxy", this._default(runtime.httpsProxy, _httpsProxy)),
            new TeaPair("noProxy", this._default(runtime.noProxy, _noProxy)),
            new TeaPair("socks5Proxy", this._default(runtime.socks5Proxy, _socks5Proxy)),
            new TeaPair("socks5NetWork", this._default(runtime.socks5NetWork, _socks5NetWork)),
            new TeaPair("maxIdleConns", this._defaultNumber(runtime.maxIdleConns, _maxIdleConns)),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", this._defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", this._default(runtime.backoffPolicy, "no")),
                new TeaPair("period", this._defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL),
            new TeaPair("logger", _logger),
            new TeaPair("listener", runtime.listener)
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
                String token = this._getSecurityToken();
                request_.protocol = _protocol;
                request_.method = "GET";
                request_.pathname = "/?website";
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("host", this.getHost(request.bucketName)),
                    new TeaPair("date", this._getDate()),
                    new TeaPair("user-agent", this._getUserAgent())
                );
                if (!this._empty(token)) {
                    request_.headers.put("x-oss-security-token", token);
                }

                request_.headers.put("authorization", this.getSignature(request_, request.bucketName));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                String bodyStr = null;
                if (this._isFail(response_)) {
                    bodyStr = this._readAsString(response_);
                    respMap = this._getErrMessage(bodyStr);
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

                bodyStr = this._readAsString(response_);
                respMap = this._parseXml(bodyStr, GetBucketWebsiteResponse.class);
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

    public DeleteLiveChannelResponse deleteLiveChannel(DeleteLiveChannelRequest request, RuntimeObject runtime) throws Exception {
        request.validate();
        runtime.validate();
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", this._defaultNumber(runtime.readTimeout, _readTimeout)),
            new TeaPair("connectTimeout", this._defaultNumber(runtime.connectTimeout, _connectTimeout)),
            new TeaPair("localAddr", this._default(runtime.localAddr, _localAddr)),
            new TeaPair("httpProxy", this._default(runtime.httpProxy, _httpProxy)),
            new TeaPair("httpsProxy", this._default(runtime.httpsProxy, _httpsProxy)),
            new TeaPair("noProxy", this._default(runtime.noProxy, _noProxy)),
            new TeaPair("socks5Proxy", this._default(runtime.socks5Proxy, _socks5Proxy)),
            new TeaPair("socks5NetWork", this._default(runtime.socks5NetWork, _socks5NetWork)),
            new TeaPair("maxIdleConns", this._defaultNumber(runtime.maxIdleConns, _maxIdleConns)),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", this._defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", this._default(runtime.backoffPolicy, "no")),
                new TeaPair("period", this._defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL),
            new TeaPair("logger", _logger),
            new TeaPair("listener", runtime.listener)
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
                String token = this._getSecurityToken();
                request_.protocol = _protocol;
                request_.method = "DELETE";
                request_.pathname = "/" + request.channelName + "?live";
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("host", this.getHost(request.bucketName)),
                    new TeaPair("date", this._getDate()),
                    new TeaPair("user-agent", this._getUserAgent())
                );
                if (!this._empty(token)) {
                    request_.headers.put("x-oss-security-token", token);
                }

                request_.headers.put("authorization", this.getSignature(request_, request.bucketName));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                String bodyStr = null;
                if (this._isFail(response_)) {
                    bodyStr = this._readAsString(response_);
                    respMap = this._getErrMessage(bodyStr);
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

    public GetBucketLocationResponse getBucketLocation(GetBucketLocationRequest request, RuntimeObject runtime) throws Exception {
        request.validate();
        runtime.validate();
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", this._defaultNumber(runtime.readTimeout, _readTimeout)),
            new TeaPair("connectTimeout", this._defaultNumber(runtime.connectTimeout, _connectTimeout)),
            new TeaPair("localAddr", this._default(runtime.localAddr, _localAddr)),
            new TeaPair("httpProxy", this._default(runtime.httpProxy, _httpProxy)),
            new TeaPair("httpsProxy", this._default(runtime.httpsProxy, _httpsProxy)),
            new TeaPair("noProxy", this._default(runtime.noProxy, _noProxy)),
            new TeaPair("socks5Proxy", this._default(runtime.socks5Proxy, _socks5Proxy)),
            new TeaPair("socks5NetWork", this._default(runtime.socks5NetWork, _socks5NetWork)),
            new TeaPair("maxIdleConns", this._defaultNumber(runtime.maxIdleConns, _maxIdleConns)),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", this._defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", this._default(runtime.backoffPolicy, "no")),
                new TeaPair("period", this._defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL),
            new TeaPair("logger", _logger),
            new TeaPair("listener", runtime.listener)
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
                String token = this._getSecurityToken();
                request_.protocol = _protocol;
                request_.method = "GET";
                request_.pathname = "/?location";
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("host", this.getHost(request.bucketName)),
                    new TeaPair("date", this._getDate()),
                    new TeaPair("user-agent", this._getUserAgent())
                );
                if (!this._empty(token)) {
                    request_.headers.put("x-oss-security-token", token);
                }

                request_.headers.put("authorization", this.getSignature(request_, request.bucketName));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                String bodyStr = null;
                if (this._isFail(response_)) {
                    bodyStr = this._readAsString(response_);
                    respMap = this._getErrMessage(bodyStr);
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

                bodyStr = this._readAsString(response_);
                respMap = this._parseXml(bodyStr, GetBucketLocationResponse.class);
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

    public ListLiveChannelResponse listLiveChannel(ListLiveChannelRequest request, RuntimeObject runtime) throws Exception {
        request.validate();
        runtime.validate();
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", this._defaultNumber(runtime.readTimeout, _readTimeout)),
            new TeaPair("connectTimeout", this._defaultNumber(runtime.connectTimeout, _connectTimeout)),
            new TeaPair("localAddr", this._default(runtime.localAddr, _localAddr)),
            new TeaPair("httpProxy", this._default(runtime.httpProxy, _httpProxy)),
            new TeaPair("httpsProxy", this._default(runtime.httpsProxy, _httpsProxy)),
            new TeaPair("noProxy", this._default(runtime.noProxy, _noProxy)),
            new TeaPair("socks5Proxy", this._default(runtime.socks5Proxy, _socks5Proxy)),
            new TeaPair("socks5NetWork", this._default(runtime.socks5NetWork, _socks5NetWork)),
            new TeaPair("maxIdleConns", this._defaultNumber(runtime.maxIdleConns, _maxIdleConns)),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", this._defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", this._default(runtime.backoffPolicy, "no")),
                new TeaPair("period", this._defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL),
            new TeaPair("logger", _logger),
            new TeaPair("listener", runtime.listener)
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
                String token = this._getSecurityToken();
                request_.protocol = _protocol;
                request_.method = "GET";
                request_.pathname = "/?live";
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("host", this.getHost(request.bucketName)),
                    new TeaPair("date", this._getDate()),
                    new TeaPair("user-agent", this._getUserAgent())
                );
                if (!this._empty(token)) {
                    request_.headers.put("x-oss-security-token", token);
                }

                request_.query = this._toQuery(TeaModel.buildMap(request.filter));
                request_.headers.put("authorization", this.getSignature(request_, request.bucketName));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                String bodyStr = null;
                if (this._isFail(response_)) {
                    bodyStr = this._readAsString(response_);
                    respMap = this._getErrMessage(bodyStr);
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

                bodyStr = this._readAsString(response_);
                respMap = this._parseXml(bodyStr, ListLiveChannelResponse.class);
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

    public GetObjectMetaResponse getObjectMeta(GetObjectMetaRequest request, RuntimeObject runtime) throws Exception {
        request.validate();
        runtime.validate();
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", this._defaultNumber(runtime.readTimeout, _readTimeout)),
            new TeaPair("connectTimeout", this._defaultNumber(runtime.connectTimeout, _connectTimeout)),
            new TeaPair("localAddr", this._default(runtime.localAddr, _localAddr)),
            new TeaPair("httpProxy", this._default(runtime.httpProxy, _httpProxy)),
            new TeaPair("httpsProxy", this._default(runtime.httpsProxy, _httpsProxy)),
            new TeaPair("noProxy", this._default(runtime.noProxy, _noProxy)),
            new TeaPair("socks5Proxy", this._default(runtime.socks5Proxy, _socks5Proxy)),
            new TeaPair("socks5NetWork", this._default(runtime.socks5NetWork, _socks5NetWork)),
            new TeaPair("maxIdleConns", this._defaultNumber(runtime.maxIdleConns, _maxIdleConns)),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", this._defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", this._default(runtime.backoffPolicy, "no")),
                new TeaPair("period", this._defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL),
            new TeaPair("logger", _logger),
            new TeaPair("listener", runtime.listener)
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
                String token = this._getSecurityToken();
                request_.protocol = _protocol;
                request_.method = "HEAD";
                request_.pathname = "/" + request.objectName + "?objectMeta";
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("host", this.getHost(request.bucketName)),
                    new TeaPair("date", this._getDate()),
                    new TeaPair("user-agent", this._getUserAgent())
                );
                if (!this._empty(token)) {
                    request_.headers.put("x-oss-security-token", token);
                }

                request_.headers.put("authorization", this.getSignature(request_, request.bucketName));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                String bodyStr = null;
                if (this._isFail(response_)) {
                    bodyStr = this._readAsString(response_);
                    respMap = this._getErrMessage(bodyStr);
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

    public GetBucketAclResponse getBucketAcl(GetBucketAclRequest request, RuntimeObject runtime) throws Exception {
        request.validate();
        runtime.validate();
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", this._defaultNumber(runtime.readTimeout, _readTimeout)),
            new TeaPair("connectTimeout", this._defaultNumber(runtime.connectTimeout, _connectTimeout)),
            new TeaPair("localAddr", this._default(runtime.localAddr, _localAddr)),
            new TeaPair("httpProxy", this._default(runtime.httpProxy, _httpProxy)),
            new TeaPair("httpsProxy", this._default(runtime.httpsProxy, _httpsProxy)),
            new TeaPair("noProxy", this._default(runtime.noProxy, _noProxy)),
            new TeaPair("socks5Proxy", this._default(runtime.socks5Proxy, _socks5Proxy)),
            new TeaPair("socks5NetWork", this._default(runtime.socks5NetWork, _socks5NetWork)),
            new TeaPair("maxIdleConns", this._defaultNumber(runtime.maxIdleConns, _maxIdleConns)),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", this._defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", this._default(runtime.backoffPolicy, "no")),
                new TeaPair("period", this._defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL),
            new TeaPair("logger", _logger),
            new TeaPair("listener", runtime.listener)
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
                String token = this._getSecurityToken();
                request_.protocol = _protocol;
                request_.method = "GET";
                request_.pathname = "/?acl";
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("host", this.getHost(request.bucketName)),
                    new TeaPair("date", this._getDate()),
                    new TeaPair("user-agent", this._getUserAgent())
                );
                if (!this._empty(token)) {
                    request_.headers.put("x-oss-security-token", token);
                }

                request_.headers.put("authorization", this.getSignature(request_, request.bucketName));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                String bodyStr = null;
                if (this._isFail(response_)) {
                    bodyStr = this._readAsString(response_);
                    respMap = this._getErrMessage(bodyStr);
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

                bodyStr = this._readAsString(response_);
                respMap = this._parseXml(bodyStr, GetBucketAclResponse.class);
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

    public ListPartsResponse listParts(ListPartsRequest request, RuntimeObject runtime) throws Exception {
        request.validate();
        runtime.validate();
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", this._defaultNumber(runtime.readTimeout, _readTimeout)),
            new TeaPair("connectTimeout", this._defaultNumber(runtime.connectTimeout, _connectTimeout)),
            new TeaPair("localAddr", this._default(runtime.localAddr, _localAddr)),
            new TeaPair("httpProxy", this._default(runtime.httpProxy, _httpProxy)),
            new TeaPair("httpsProxy", this._default(runtime.httpsProxy, _httpsProxy)),
            new TeaPair("noProxy", this._default(runtime.noProxy, _noProxy)),
            new TeaPair("socks5Proxy", this._default(runtime.socks5Proxy, _socks5Proxy)),
            new TeaPair("socks5NetWork", this._default(runtime.socks5NetWork, _socks5NetWork)),
            new TeaPair("maxIdleConns", this._defaultNumber(runtime.maxIdleConns, _maxIdleConns)),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", this._defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", this._default(runtime.backoffPolicy, "no")),
                new TeaPair("period", this._defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL),
            new TeaPair("logger", _logger),
            new TeaPair("listener", runtime.listener)
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
                String token = this._getSecurityToken();
                request_.protocol = _protocol;
                request_.method = "GET";
                request_.pathname = "/" + request.objectName + "";
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("host", this.getHost(request.bucketName)),
                    new TeaPair("date", this._getDate()),
                    new TeaPair("user-agent", this._getUserAgent())
                );
                if (!this._empty(token)) {
                    request_.headers.put("x-oss-security-token", token);
                }

                request_.query = this._toQuery(TeaModel.buildMap(request.filter));
                request_.headers.put("authorization", this.getSignature(request_, request.bucketName));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                String bodyStr = null;
                if (this._isFail(response_)) {
                    bodyStr = this._readAsString(response_);
                    respMap = this._getErrMessage(bodyStr);
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

                bodyStr = this._readAsString(response_);
                respMap = this._parseXml(bodyStr, ListPartsResponse.class);
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

    public GetLiveChannelHistoryResponse getLiveChannelHistory(GetLiveChannelHistoryRequest request, RuntimeObject runtime) throws Exception {
        request.validate();
        runtime.validate();
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", this._defaultNumber(runtime.readTimeout, _readTimeout)),
            new TeaPair("connectTimeout", this._defaultNumber(runtime.connectTimeout, _connectTimeout)),
            new TeaPair("localAddr", this._default(runtime.localAddr, _localAddr)),
            new TeaPair("httpProxy", this._default(runtime.httpProxy, _httpProxy)),
            new TeaPair("httpsProxy", this._default(runtime.httpsProxy, _httpsProxy)),
            new TeaPair("noProxy", this._default(runtime.noProxy, _noProxy)),
            new TeaPair("socks5Proxy", this._default(runtime.socks5Proxy, _socks5Proxy)),
            new TeaPair("socks5NetWork", this._default(runtime.socks5NetWork, _socks5NetWork)),
            new TeaPair("maxIdleConns", this._defaultNumber(runtime.maxIdleConns, _maxIdleConns)),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", this._defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", this._default(runtime.backoffPolicy, "no")),
                new TeaPair("period", this._defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL),
            new TeaPair("logger", _logger),
            new TeaPair("listener", runtime.listener)
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
                String token = this._getSecurityToken();
                request_.protocol = _protocol;
                request_.method = "GET";
                request_.pathname = "/" + request.channelName + "?live";
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("host", this.getHost(request.bucketName)),
                    new TeaPair("date", this._getDate()),
                    new TeaPair("user-agent", this._getUserAgent())
                );
                if (!this._empty(token)) {
                    request_.headers.put("x-oss-security-token", token);
                }

                request_.query = this._toQuery(TeaModel.buildMap(request.filter));
                request_.headers.put("authorization", this.getSignature(request_, request.bucketName));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                String bodyStr = null;
                if (this._isFail(response_)) {
                    bodyStr = this._readAsString(response_);
                    respMap = this._getErrMessage(bodyStr);
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

                bodyStr = this._readAsString(response_);
                respMap = this._parseXml(bodyStr, GetLiveChannelHistoryResponse.class);
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

    public GetBucketResponse getBucket(GetBucketRequest request, RuntimeObject runtime) throws Exception {
        request.validate();
        runtime.validate();
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", this._defaultNumber(runtime.readTimeout, _readTimeout)),
            new TeaPair("connectTimeout", this._defaultNumber(runtime.connectTimeout, _connectTimeout)),
            new TeaPair("localAddr", this._default(runtime.localAddr, _localAddr)),
            new TeaPair("httpProxy", this._default(runtime.httpProxy, _httpProxy)),
            new TeaPair("httpsProxy", this._default(runtime.httpsProxy, _httpsProxy)),
            new TeaPair("noProxy", this._default(runtime.noProxy, _noProxy)),
            new TeaPair("socks5Proxy", this._default(runtime.socks5Proxy, _socks5Proxy)),
            new TeaPair("socks5NetWork", this._default(runtime.socks5NetWork, _socks5NetWork)),
            new TeaPair("maxIdleConns", this._defaultNumber(runtime.maxIdleConns, _maxIdleConns)),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", this._defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", this._default(runtime.backoffPolicy, "no")),
                new TeaPair("period", this._defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL),
            new TeaPair("logger", _logger),
            new TeaPair("listener", runtime.listener)
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
                String token = this._getSecurityToken();
                request_.protocol = _protocol;
                request_.method = "GET";
                request_.pathname = "/";
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("host", this.getHost(request.bucketName)),
                    new TeaPair("date", this._getDate()),
                    new TeaPair("user-agent", this._getUserAgent())
                );
                if (!this._empty(token)) {
                    request_.headers.put("x-oss-security-token", token);
                }

                request_.query = this._toQuery(TeaModel.buildMap(request.filter));
                request_.headers.put("authorization", this.getSignature(request_, request.bucketName));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                String bodyStr = null;
                if (this._isFail(response_)) {
                    bodyStr = this._readAsString(response_);
                    respMap = this._getErrMessage(bodyStr);
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

                bodyStr = this._readAsString(response_);
                respMap = this._parseXml(bodyStr, GetBucketResponse.class);
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

    public GetLiveChannelInfoResponse getLiveChannelInfo(GetLiveChannelInfoRequest request, RuntimeObject runtime) throws Exception {
        request.validate();
        runtime.validate();
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", this._defaultNumber(runtime.readTimeout, _readTimeout)),
            new TeaPair("connectTimeout", this._defaultNumber(runtime.connectTimeout, _connectTimeout)),
            new TeaPair("localAddr", this._default(runtime.localAddr, _localAddr)),
            new TeaPair("httpProxy", this._default(runtime.httpProxy, _httpProxy)),
            new TeaPair("httpsProxy", this._default(runtime.httpsProxy, _httpsProxy)),
            new TeaPair("noProxy", this._default(runtime.noProxy, _noProxy)),
            new TeaPair("socks5Proxy", this._default(runtime.socks5Proxy, _socks5Proxy)),
            new TeaPair("socks5NetWork", this._default(runtime.socks5NetWork, _socks5NetWork)),
            new TeaPair("maxIdleConns", this._defaultNumber(runtime.maxIdleConns, _maxIdleConns)),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", this._defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", this._default(runtime.backoffPolicy, "no")),
                new TeaPair("period", this._defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL),
            new TeaPair("logger", _logger),
            new TeaPair("listener", runtime.listener)
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
                String token = this._getSecurityToken();
                request_.protocol = _protocol;
                request_.method = "GET";
                request_.pathname = "/" + request.channelName + "?live";
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("host", this.getHost(request.bucketName)),
                    new TeaPair("date", this._getDate()),
                    new TeaPair("user-agent", this._getUserAgent())
                );
                if (!this._empty(token)) {
                    request_.headers.put("x-oss-security-token", token);
                }

                request_.headers.put("authorization", this.getSignature(request_, request.bucketName));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                String bodyStr = null;
                if (this._isFail(response_)) {
                    bodyStr = this._readAsString(response_);
                    respMap = this._getErrMessage(bodyStr);
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

                bodyStr = this._readAsString(response_);
                respMap = this._parseXml(bodyStr, GetLiveChannelInfoResponse.class);
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

    public GetLiveChannelStatResponse getLiveChannelStat(GetLiveChannelStatRequest request, RuntimeObject runtime) throws Exception {
        request.validate();
        runtime.validate();
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", this._defaultNumber(runtime.readTimeout, _readTimeout)),
            new TeaPair("connectTimeout", this._defaultNumber(runtime.connectTimeout, _connectTimeout)),
            new TeaPair("localAddr", this._default(runtime.localAddr, _localAddr)),
            new TeaPair("httpProxy", this._default(runtime.httpProxy, _httpProxy)),
            new TeaPair("httpsProxy", this._default(runtime.httpsProxy, _httpsProxy)),
            new TeaPair("noProxy", this._default(runtime.noProxy, _noProxy)),
            new TeaPair("socks5Proxy", this._default(runtime.socks5Proxy, _socks5Proxy)),
            new TeaPair("socks5NetWork", this._default(runtime.socks5NetWork, _socks5NetWork)),
            new TeaPair("maxIdleConns", this._defaultNumber(runtime.maxIdleConns, _maxIdleConns)),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", this._defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", this._default(runtime.backoffPolicy, "no")),
                new TeaPair("period", this._defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL),
            new TeaPair("logger", _logger),
            new TeaPair("listener", runtime.listener)
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
                String token = this._getSecurityToken();
                request_.protocol = _protocol;
                request_.method = "GET";
                request_.pathname = "/" + request.channelName + "?live";
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("host", this.getHost(request.bucketName)),
                    new TeaPair("date", this._getDate()),
                    new TeaPair("user-agent", this._getUserAgent())
                );
                if (!this._empty(token)) {
                    request_.headers.put("x-oss-security-token", token);
                }

                request_.query = this._toQuery(TeaModel.buildMap(request.filter));
                request_.headers.put("authorization", this.getSignature(request_, request.bucketName));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                String bodyStr = null;
                if (this._isFail(response_)) {
                    bodyStr = this._readAsString(response_);
                    respMap = this._getErrMessage(bodyStr);
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

                bodyStr = this._readAsString(response_);
                respMap = this._parseXml(bodyStr, GetLiveChannelStatResponse.class);
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

    public DeleteObjectResponse deleteObject(DeleteObjectRequest request, RuntimeObject runtime) throws Exception {
        request.validate();
        runtime.validate();
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", this._defaultNumber(runtime.readTimeout, _readTimeout)),
            new TeaPair("connectTimeout", this._defaultNumber(runtime.connectTimeout, _connectTimeout)),
            new TeaPair("localAddr", this._default(runtime.localAddr, _localAddr)),
            new TeaPair("httpProxy", this._default(runtime.httpProxy, _httpProxy)),
            new TeaPair("httpsProxy", this._default(runtime.httpsProxy, _httpsProxy)),
            new TeaPair("noProxy", this._default(runtime.noProxy, _noProxy)),
            new TeaPair("socks5Proxy", this._default(runtime.socks5Proxy, _socks5Proxy)),
            new TeaPair("socks5NetWork", this._default(runtime.socks5NetWork, _socks5NetWork)),
            new TeaPair("maxIdleConns", this._defaultNumber(runtime.maxIdleConns, _maxIdleConns)),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", this._defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", this._default(runtime.backoffPolicy, "no")),
                new TeaPair("period", this._defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL),
            new TeaPair("logger", _logger),
            new TeaPair("listener", runtime.listener)
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
                String token = this._getSecurityToken();
                request_.protocol = _protocol;
                request_.method = "DELETE";
                request_.pathname = "/" + request.objectName + "";
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("host", this.getHost(request.bucketName)),
                    new TeaPair("date", this._getDate()),
                    new TeaPair("user-agent", this._getUserAgent())
                );
                if (!this._empty(token)) {
                    request_.headers.put("x-oss-security-token", token);
                }

                request_.headers.put("authorization", this.getSignature(request_, request.bucketName));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                String bodyStr = null;
                if (this._isFail(response_)) {
                    bodyStr = this._readAsString(response_);
                    respMap = this._getErrMessage(bodyStr);
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

    public AbortMultipartUploadResponse abortMultipartUpload(AbortMultipartUploadRequest request, RuntimeObject runtime) throws Exception {
        request.validate();
        runtime.validate();
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", this._defaultNumber(runtime.readTimeout, _readTimeout)),
            new TeaPair("connectTimeout", this._defaultNumber(runtime.connectTimeout, _connectTimeout)),
            new TeaPair("localAddr", this._default(runtime.localAddr, _localAddr)),
            new TeaPair("httpProxy", this._default(runtime.httpProxy, _httpProxy)),
            new TeaPair("httpsProxy", this._default(runtime.httpsProxy, _httpsProxy)),
            new TeaPair("noProxy", this._default(runtime.noProxy, _noProxy)),
            new TeaPair("socks5Proxy", this._default(runtime.socks5Proxy, _socks5Proxy)),
            new TeaPair("socks5NetWork", this._default(runtime.socks5NetWork, _socks5NetWork)),
            new TeaPair("maxIdleConns", this._defaultNumber(runtime.maxIdleConns, _maxIdleConns)),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", this._defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", this._default(runtime.backoffPolicy, "no")),
                new TeaPair("period", this._defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL),
            new TeaPair("logger", _logger),
            new TeaPair("listener", runtime.listener)
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
                String token = this._getSecurityToken();
                request_.protocol = _protocol;
                request_.method = "DELETE";
                request_.pathname = "/" + request.objectName + "";
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("host", this.getHost(request.bucketName)),
                    new TeaPair("date", this._getDate()),
                    new TeaPair("user-agent", this._getUserAgent())
                );
                if (!this._empty(token)) {
                    request_.headers.put("x-oss-security-token", token);
                }

                request_.query = this._toQuery(TeaModel.buildMap(request.filter));
                request_.headers.put("authorization", this.getSignature(request_, request.bucketName));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                String bodyStr = null;
                if (this._isFail(response_)) {
                    bodyStr = this._readAsString(response_);
                    respMap = this._getErrMessage(bodyStr);
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

    public AppendObjectResponse appendObject(AppendObjectRequest request, RuntimeObject runtime) throws Exception {
        request.validate();
        runtime.validate();
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", this._defaultNumber(runtime.readTimeout, _readTimeout)),
            new TeaPair("connectTimeout", this._defaultNumber(runtime.connectTimeout, _connectTimeout)),
            new TeaPair("localAddr", this._default(runtime.localAddr, _localAddr)),
            new TeaPair("httpProxy", this._default(runtime.httpProxy, _httpProxy)),
            new TeaPair("httpsProxy", this._default(runtime.httpsProxy, _httpsProxy)),
            new TeaPair("noProxy", this._default(runtime.noProxy, _noProxy)),
            new TeaPair("socks5Proxy", this._default(runtime.socks5Proxy, _socks5Proxy)),
            new TeaPair("socks5NetWork", this._default(runtime.socks5NetWork, _socks5NetWork)),
            new TeaPair("maxIdleConns", this._defaultNumber(runtime.maxIdleConns, _maxIdleConns)),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", this._defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", this._default(runtime.backoffPolicy, "no")),
                new TeaPair("period", this._defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL),
            new TeaPair("logger", _logger),
            new TeaPair("listener", runtime.listener)
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
                String token = this._getSecurityToken();
                request_.protocol = _protocol;
                request_.method = "POST";
                request_.pathname = "/" + request.objectName + "?append";
                request_.headers = TeaConverter.merge(String.class, 
                    TeaConverter.buildMap(
                        new TeaPair("host", this.getHost(request.bucketName)),
                        new TeaPair("date", this._getDate()),
                        new TeaPair("user-agent", this._getUserAgent())
                    ),
                    this._toHeader(TeaModel.buildMap(request.header)),
                    this._parseMeta(request.userMeta, "x-oss-meta-")
                );
                if (!this._empty(token)) {
                    request_.headers.put("x-oss-security-token", token);
                }

                request_.query = this._toQuery(TeaModel.buildMap(request.filter));
                request_.body = this._inject(request.body, ctx);
                if (this._notNull(TeaModel.buildMap(request.header)) && !this._empty(request.header.contentType)) {
                    request_.headers.put("content-type", request.header.contentType);
                } else {
                    request_.headers.put("content-type", this._getContentType(request.objectName));
                }

                request_.headers.put("authorization", this.getSignature(request_, request.bucketName));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                String bodyStr = null;
                if (this._isFail(response_)) {
                    bodyStr = this._readAsString(response_);
                    respMap = this._getErrMessage(bodyStr);
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

                if (_isEnableCrc && !this._equal(ctx.get("crc"), response_.headers.get("x-oss-hash-crc64ecma"))) {
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("code", "CrcNotMatched"),
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("clientCrc", ctx.get("crc")),
                            new TeaPair("serverCrc", response_.headers.get("x-oss-hash-crc64ecma"))
                        ))
                    ));
                }

                if (_isEnableMD5 && !this._equal(ctx.get("md5"), response_.headers.get("content-md5"))) {
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("code", "MD5NotMatched"),
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("clientMD5", ctx.get("md5")),
                            new TeaPair("serverMD5", response_.headers.get("content-md5"))
                        ))
                    ));
                }

                return TeaModel.toModel(TeaConverter.merge(Object.class, 
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

    public UploadPartCopyResponse uploadPartCopy(UploadPartCopyRequest request, RuntimeObject runtime) throws Exception {
        request.validate();
        runtime.validate();
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", this._defaultNumber(runtime.readTimeout, _readTimeout)),
            new TeaPair("connectTimeout", this._defaultNumber(runtime.connectTimeout, _connectTimeout)),
            new TeaPair("localAddr", this._default(runtime.localAddr, _localAddr)),
            new TeaPair("httpProxy", this._default(runtime.httpProxy, _httpProxy)),
            new TeaPair("httpsProxy", this._default(runtime.httpsProxy, _httpsProxy)),
            new TeaPair("noProxy", this._default(runtime.noProxy, _noProxy)),
            new TeaPair("socks5Proxy", this._default(runtime.socks5Proxy, _socks5Proxy)),
            new TeaPair("socks5NetWork", this._default(runtime.socks5NetWork, _socks5NetWork)),
            new TeaPair("maxIdleConns", this._defaultNumber(runtime.maxIdleConns, _maxIdleConns)),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", this._defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", this._default(runtime.backoffPolicy, "no")),
                new TeaPair("period", this._defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL),
            new TeaPair("logger", _logger),
            new TeaPair("listener", runtime.listener)
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
                String token = this._getSecurityToken();
                request_.protocol = _protocol;
                request_.method = "PUT";
                request_.pathname = "/" + request.objectName + "";
                request_.headers = TeaConverter.merge(String.class, 
                    TeaConverter.buildMap(
                        new TeaPair("host", this.getHost(request.bucketName)),
                        new TeaPair("date", this._getDate()),
                        new TeaPair("user-agent", this._getUserAgent())
                    ),
                    this._toHeader(TeaModel.buildMap(request.header))
                );
                if (!this._empty(token)) {
                    request_.headers.put("x-oss-security-token", token);
                }

                request_.query = this._toQuery(TeaModel.buildMap(request.filter));
                request_.headers.put("authorization", this.getSignature(request_, request.bucketName));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                String bodyStr = null;
                if (this._isFail(response_)) {
                    bodyStr = this._readAsString(response_);
                    respMap = this._getErrMessage(bodyStr);
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

                bodyStr = this._readAsString(response_);
                respMap = this._parseXml(bodyStr, UploadPartCopyResponse.class);
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

    public GetVodPlaylistResponse getVodPlaylist(GetVodPlaylistRequest request, RuntimeObject runtime) throws Exception {
        request.validate();
        runtime.validate();
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", this._defaultNumber(runtime.readTimeout, _readTimeout)),
            new TeaPair("connectTimeout", this._defaultNumber(runtime.connectTimeout, _connectTimeout)),
            new TeaPair("localAddr", this._default(runtime.localAddr, _localAddr)),
            new TeaPair("httpProxy", this._default(runtime.httpProxy, _httpProxy)),
            new TeaPair("httpsProxy", this._default(runtime.httpsProxy, _httpsProxy)),
            new TeaPair("noProxy", this._default(runtime.noProxy, _noProxy)),
            new TeaPair("socks5Proxy", this._default(runtime.socks5Proxy, _socks5Proxy)),
            new TeaPair("socks5NetWork", this._default(runtime.socks5NetWork, _socks5NetWork)),
            new TeaPair("maxIdleConns", this._defaultNumber(runtime.maxIdleConns, _maxIdleConns)),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", this._defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", this._default(runtime.backoffPolicy, "no")),
                new TeaPair("period", this._defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL),
            new TeaPair("logger", _logger),
            new TeaPair("listener", runtime.listener)
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
                String token = this._getSecurityToken();
                request_.protocol = _protocol;
                request_.method = "GET";
                request_.pathname = "/" + request.channelName + "?vod";
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("host", this.getHost(request.bucketName)),
                    new TeaPair("date", this._getDate()),
                    new TeaPair("user-agent", this._getUserAgent())
                );
                if (!this._empty(token)) {
                    request_.headers.put("x-oss-security-token", token);
                }

                request_.query = this._toQuery(TeaModel.buildMap(request.filter));
                request_.headers.put("authorization", this.getSignature(request_, request.bucketName));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                String bodyStr = null;
                if (this._isFail(response_)) {
                    bodyStr = this._readAsString(response_);
                    respMap = this._getErrMessage(bodyStr);
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

    public DeleteBucketCORSResponse deleteBucketCORS(DeleteBucketCORSRequest request, RuntimeObject runtime) throws Exception {
        request.validate();
        runtime.validate();
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", this._defaultNumber(runtime.readTimeout, _readTimeout)),
            new TeaPair("connectTimeout", this._defaultNumber(runtime.connectTimeout, _connectTimeout)),
            new TeaPair("localAddr", this._default(runtime.localAddr, _localAddr)),
            new TeaPair("httpProxy", this._default(runtime.httpProxy, _httpProxy)),
            new TeaPair("httpsProxy", this._default(runtime.httpsProxy, _httpsProxy)),
            new TeaPair("noProxy", this._default(runtime.noProxy, _noProxy)),
            new TeaPair("socks5Proxy", this._default(runtime.socks5Proxy, _socks5Proxy)),
            new TeaPair("socks5NetWork", this._default(runtime.socks5NetWork, _socks5NetWork)),
            new TeaPair("maxIdleConns", this._defaultNumber(runtime.maxIdleConns, _maxIdleConns)),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", this._defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", this._default(runtime.backoffPolicy, "no")),
                new TeaPair("period", this._defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL),
            new TeaPair("logger", _logger),
            new TeaPair("listener", runtime.listener)
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
                String token = this._getSecurityToken();
                request_.protocol = _protocol;
                request_.method = "DELETE";
                request_.pathname = "/?cors";
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("host", this.getHost(request.bucketName)),
                    new TeaPair("date", this._getDate()),
                    new TeaPair("user-agent", this._getUserAgent())
                );
                if (!this._empty(token)) {
                    request_.headers.put("x-oss-security-token", token);
                }

                request_.headers.put("authorization", this.getSignature(request_, request.bucketName));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                String bodyStr = null;
                if (this._isFail(response_)) {
                    bodyStr = this._readAsString(response_);
                    respMap = this._getErrMessage(bodyStr);
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

    public GetObjectResponse getObject(GetObjectRequest request, RuntimeObject runtime) throws Exception {
        request.validate();
        runtime.validate();
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", this._defaultNumber(runtime.readTimeout, _readTimeout)),
            new TeaPair("connectTimeout", this._defaultNumber(runtime.connectTimeout, _connectTimeout)),
            new TeaPair("localAddr", this._default(runtime.localAddr, _localAddr)),
            new TeaPair("httpProxy", this._default(runtime.httpProxy, _httpProxy)),
            new TeaPair("httpsProxy", this._default(runtime.httpsProxy, _httpsProxy)),
            new TeaPair("noProxy", this._default(runtime.noProxy, _noProxy)),
            new TeaPair("socks5Proxy", this._default(runtime.socks5Proxy, _socks5Proxy)),
            new TeaPair("socks5NetWork", this._default(runtime.socks5NetWork, _socks5NetWork)),
            new TeaPair("maxIdleConns", this._defaultNumber(runtime.maxIdleConns, _maxIdleConns)),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", this._defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", this._default(runtime.backoffPolicy, "no")),
                new TeaPair("period", this._defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL),
            new TeaPair("logger", _logger),
            new TeaPair("listener", runtime.listener)
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
                String token = this._getSecurityToken();
                request_.protocol = _protocol;
                request_.method = "GET";
                request_.pathname = "/" + request.objectName + "";
                request_.headers = TeaConverter.merge(String.class, 
                    TeaConverter.buildMap(
                        new TeaPair("host", this.getHost(request.bucketName)),
                        new TeaPair("date", this._getDate()),
                        new TeaPair("user-agent", this._getUserAgent())
                    ),
                    this._toHeader(TeaModel.buildMap(request.header))
                );
                if (!this._empty(token)) {
                    request_.headers.put("x-oss-security-token", token);
                }

                request_.headers.put("authorization", this.getSignature(request_, request.bucketName));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                String bodyStr = null;
                if (this._isFail(response_)) {
                    bodyStr = this._readAsString(response_);
                    respMap = this._getErrMessage(bodyStr);
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
                        new TeaPair("body", this._readAsStream(response_))
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

    public UploadPartResponse uploadPart(UploadPartRequest request, RuntimeObject runtime) throws Exception {
        request.validate();
        runtime.validate();
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", this._defaultNumber(runtime.readTimeout, _readTimeout)),
            new TeaPair("connectTimeout", this._defaultNumber(runtime.connectTimeout, _connectTimeout)),
            new TeaPair("localAddr", this._default(runtime.localAddr, _localAddr)),
            new TeaPair("httpProxy", this._default(runtime.httpProxy, _httpProxy)),
            new TeaPair("httpsProxy", this._default(runtime.httpsProxy, _httpsProxy)),
            new TeaPair("noProxy", this._default(runtime.noProxy, _noProxy)),
            new TeaPair("socks5Proxy", this._default(runtime.socks5Proxy, _socks5Proxy)),
            new TeaPair("socks5NetWork", this._default(runtime.socks5NetWork, _socks5NetWork)),
            new TeaPair("maxIdleConns", this._defaultNumber(runtime.maxIdleConns, _maxIdleConns)),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", this._defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", this._default(runtime.backoffPolicy, "no")),
                new TeaPair("period", this._defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL),
            new TeaPair("logger", _logger),
            new TeaPair("listener", runtime.listener)
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
                String token = this._getSecurityToken();
                request_.protocol = _protocol;
                request_.method = "PUT";
                request_.pathname = "/" + request.objectName + "";
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("host", this.getHost(request.bucketName)),
                    new TeaPair("date", this._getDate()),
                    new TeaPair("user-agent", this._getUserAgent())
                );
                if (!this._empty(token)) {
                    request_.headers.put("x-oss-security-token", token);
                }

                request_.query = this._toQuery(TeaModel.buildMap(request.filter));
                request_.body = this._inject(request.body, ctx);
                request_.headers.put("authorization", this.getSignature(request_, request.bucketName));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                String bodyStr = null;
                if (this._isFail(response_)) {
                    bodyStr = this._readAsString(response_);
                    respMap = this._getErrMessage(bodyStr);
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

                if (_isEnableCrc && !this._equal(ctx.get("crc"), response_.headers.get("x-oss-hash-crc64ecma"))) {
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("code", "CrcNotMatched"),
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("clientCrc", ctx.get("crc")),
                            new TeaPair("serverCrc", response_.headers.get("x-oss-hash-crc64ecma"))
                        ))
                    ));
                }

                if (_isEnableMD5 && !this._equal(ctx.get("md5"), response_.headers.get("content-md5"))) {
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("code", "MD5NotMatched"),
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("clientMD5", ctx.get("md5")),
                            new TeaPair("serverMD5", response_.headers.get("content-md5"))
                        ))
                    ));
                }

                return TeaModel.toModel(TeaConverter.merge(Object.class, 
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

    public GetBucketCORSResponse getBucketCORS(GetBucketCORSRequest request, RuntimeObject runtime) throws Exception {
        request.validate();
        runtime.validate();
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", this._defaultNumber(runtime.readTimeout, _readTimeout)),
            new TeaPair("connectTimeout", this._defaultNumber(runtime.connectTimeout, _connectTimeout)),
            new TeaPair("localAddr", this._default(runtime.localAddr, _localAddr)),
            new TeaPair("httpProxy", this._default(runtime.httpProxy, _httpProxy)),
            new TeaPair("httpsProxy", this._default(runtime.httpsProxy, _httpsProxy)),
            new TeaPair("noProxy", this._default(runtime.noProxy, _noProxy)),
            new TeaPair("socks5Proxy", this._default(runtime.socks5Proxy, _socks5Proxy)),
            new TeaPair("socks5NetWork", this._default(runtime.socks5NetWork, _socks5NetWork)),
            new TeaPair("maxIdleConns", this._defaultNumber(runtime.maxIdleConns, _maxIdleConns)),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", this._defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", this._default(runtime.backoffPolicy, "no")),
                new TeaPair("period", this._defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL),
            new TeaPair("logger", _logger),
            new TeaPair("listener", runtime.listener)
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
                String token = this._getSecurityToken();
                request_.protocol = _protocol;
                request_.method = "GET";
                request_.pathname = "/?cors";
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("host", this.getHost(request.bucketName)),
                    new TeaPair("date", this._getDate()),
                    new TeaPair("user-agent", this._getUserAgent())
                );
                if (!this._empty(token)) {
                    request_.headers.put("x-oss-security-token", token);
                }

                request_.headers.put("authorization", this.getSignature(request_, request.bucketName));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                String bodyStr = null;
                if (this._isFail(response_)) {
                    bodyStr = this._readAsString(response_);
                    respMap = this._getErrMessage(bodyStr);
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

                bodyStr = this._readAsString(response_);
                respMap = this._parseXml(bodyStr, GetBucketCORSResponse.class);
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

    public CopyObjectResponse copyObject(CopyObjectRequest request, RuntimeObject runtime) throws Exception {
        request.validate();
        runtime.validate();
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", this._defaultNumber(runtime.readTimeout, _readTimeout)),
            new TeaPair("connectTimeout", this._defaultNumber(runtime.connectTimeout, _connectTimeout)),
            new TeaPair("localAddr", this._default(runtime.localAddr, _localAddr)),
            new TeaPair("httpProxy", this._default(runtime.httpProxy, _httpProxy)),
            new TeaPair("httpsProxy", this._default(runtime.httpsProxy, _httpsProxy)),
            new TeaPair("noProxy", this._default(runtime.noProxy, _noProxy)),
            new TeaPair("socks5Proxy", this._default(runtime.socks5Proxy, _socks5Proxy)),
            new TeaPair("socks5NetWork", this._default(runtime.socks5NetWork, _socks5NetWork)),
            new TeaPair("maxIdleConns", this._defaultNumber(runtime.maxIdleConns, _maxIdleConns)),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", this._defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", this._default(runtime.backoffPolicy, "no")),
                new TeaPair("period", this._defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL),
            new TeaPair("logger", _logger),
            new TeaPair("listener", runtime.listener)
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
                String token = this._getSecurityToken();
                request_.protocol = _protocol;
                request_.method = "PUT";
                request_.pathname = "/" + request.destObjectName + "";
                request_.headers = TeaConverter.merge(String.class, 
                    TeaConverter.buildMap(
                        new TeaPair("host", this.getHost(request.bucketName)),
                        new TeaPair("date", this._getDate()),
                        new TeaPair("user-agent", this._getUserAgent())
                    ),
                    this._toHeader(TeaModel.buildMap(request.header))
                );
                if (!this._empty(token)) {
                    request_.headers.put("x-oss-security-token", token);
                }

                request_.headers.put("x-oss-copy-source", this._encode(request_.headers.get("x-oss-copy-source"), "UrlEncode"));
                request_.headers.put("authorization", this.getSignature(request_, request.bucketName));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                String bodyStr = null;
                if (this._isFail(response_)) {
                    bodyStr = this._readAsString(response_);
                    respMap = this._getErrMessage(bodyStr);
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

                bodyStr = this._readAsString(response_);
                respMap = this._parseXml(bodyStr, CopyObjectResponse.class);
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

    public GetObjectTaggingResponse getObjectTagging(GetObjectTaggingRequest request, RuntimeObject runtime) throws Exception {
        request.validate();
        runtime.validate();
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", this._defaultNumber(runtime.readTimeout, _readTimeout)),
            new TeaPair("connectTimeout", this._defaultNumber(runtime.connectTimeout, _connectTimeout)),
            new TeaPair("localAddr", this._default(runtime.localAddr, _localAddr)),
            new TeaPair("httpProxy", this._default(runtime.httpProxy, _httpProxy)),
            new TeaPair("httpsProxy", this._default(runtime.httpsProxy, _httpsProxy)),
            new TeaPair("noProxy", this._default(runtime.noProxy, _noProxy)),
            new TeaPair("socks5Proxy", this._default(runtime.socks5Proxy, _socks5Proxy)),
            new TeaPair("socks5NetWork", this._default(runtime.socks5NetWork, _socks5NetWork)),
            new TeaPair("maxIdleConns", this._defaultNumber(runtime.maxIdleConns, _maxIdleConns)),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", this._defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", this._default(runtime.backoffPolicy, "no")),
                new TeaPair("period", this._defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL),
            new TeaPair("logger", _logger),
            new TeaPair("listener", runtime.listener)
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
                String token = this._getSecurityToken();
                request_.protocol = _protocol;
                request_.method = "GET";
                request_.pathname = "/" + request.objectName + "?tagging";
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("host", this.getHost(request.bucketName)),
                    new TeaPair("date", this._getDate()),
                    new TeaPair("user-agent", this._getUserAgent())
                );
                if (!this._empty(token)) {
                    request_.headers.put("x-oss-security-token", token);
                }

                request_.headers.put("authorization", this.getSignature(request_, request.bucketName));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                String bodyStr = null;
                if (this._isFail(response_)) {
                    bodyStr = this._readAsString(response_);
                    respMap = this._getErrMessage(bodyStr);
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

                bodyStr = this._readAsString(response_);
                respMap = this._parseXml(bodyStr, GetObjectTaggingResponse.class);
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

    public DeleteBucketLifecycleResponse deleteBucketLifecycle(DeleteBucketLifecycleRequest request, RuntimeObject runtime) throws Exception {
        request.validate();
        runtime.validate();
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", this._defaultNumber(runtime.readTimeout, _readTimeout)),
            new TeaPair("connectTimeout", this._defaultNumber(runtime.connectTimeout, _connectTimeout)),
            new TeaPair("localAddr", this._default(runtime.localAddr, _localAddr)),
            new TeaPair("httpProxy", this._default(runtime.httpProxy, _httpProxy)),
            new TeaPair("httpsProxy", this._default(runtime.httpsProxy, _httpsProxy)),
            new TeaPair("noProxy", this._default(runtime.noProxy, _noProxy)),
            new TeaPair("socks5Proxy", this._default(runtime.socks5Proxy, _socks5Proxy)),
            new TeaPair("socks5NetWork", this._default(runtime.socks5NetWork, _socks5NetWork)),
            new TeaPair("maxIdleConns", this._defaultNumber(runtime.maxIdleConns, _maxIdleConns)),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", this._defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", this._default(runtime.backoffPolicy, "no")),
                new TeaPair("period", this._defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL),
            new TeaPair("logger", _logger),
            new TeaPair("listener", runtime.listener)
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
                String token = this._getSecurityToken();
                request_.protocol = _protocol;
                request_.method = "DELETE";
                request_.pathname = "/?lifecycle";
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("host", this.getHost(request.bucketName)),
                    new TeaPair("date", this._getDate()),
                    new TeaPair("user-agent", this._getUserAgent())
                );
                if (!this._empty(token)) {
                    request_.headers.put("x-oss-security-token", token);
                }

                request_.headers.put("authorization", this.getSignature(request_, request.bucketName));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                String bodyStr = null;
                if (this._isFail(response_)) {
                    bodyStr = this._readAsString(response_);
                    respMap = this._getErrMessage(bodyStr);
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

    public DeleteBucketLoggingResponse deleteBucketLogging(DeleteBucketLoggingRequest request, RuntimeObject runtime) throws Exception {
        request.validate();
        runtime.validate();
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", this._defaultNumber(runtime.readTimeout, _readTimeout)),
            new TeaPair("connectTimeout", this._defaultNumber(runtime.connectTimeout, _connectTimeout)),
            new TeaPair("localAddr", this._default(runtime.localAddr, _localAddr)),
            new TeaPair("httpProxy", this._default(runtime.httpProxy, _httpProxy)),
            new TeaPair("httpsProxy", this._default(runtime.httpsProxy, _httpsProxy)),
            new TeaPair("noProxy", this._default(runtime.noProxy, _noProxy)),
            new TeaPair("socks5Proxy", this._default(runtime.socks5Proxy, _socks5Proxy)),
            new TeaPair("socks5NetWork", this._default(runtime.socks5NetWork, _socks5NetWork)),
            new TeaPair("maxIdleConns", this._defaultNumber(runtime.maxIdleConns, _maxIdleConns)),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", this._defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", this._default(runtime.backoffPolicy, "no")),
                new TeaPair("period", this._defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL),
            new TeaPair("logger", _logger),
            new TeaPair("listener", runtime.listener)
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
                String token = this._getSecurityToken();
                request_.protocol = _protocol;
                request_.method = "DELETE";
                request_.pathname = "/?logging";
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("host", this.getHost(request.bucketName)),
                    new TeaPair("date", this._getDate()),
                    new TeaPair("user-agent", this._getUserAgent())
                );
                if (!this._empty(token)) {
                    request_.headers.put("x-oss-security-token", token);
                }

                request_.headers.put("authorization", this.getSignature(request_, request.bucketName));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                String bodyStr = null;
                if (this._isFail(response_)) {
                    bodyStr = this._readAsString(response_);
                    respMap = this._getErrMessage(bodyStr);
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

    public DeleteBucketWebsiteResponse deleteBucketWebsite(DeleteBucketWebsiteRequest request, RuntimeObject runtime) throws Exception {
        request.validate();
        runtime.validate();
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", this._defaultNumber(runtime.readTimeout, _readTimeout)),
            new TeaPair("connectTimeout", this._defaultNumber(runtime.connectTimeout, _connectTimeout)),
            new TeaPair("localAddr", this._default(runtime.localAddr, _localAddr)),
            new TeaPair("httpProxy", this._default(runtime.httpProxy, _httpProxy)),
            new TeaPair("httpsProxy", this._default(runtime.httpsProxy, _httpsProxy)),
            new TeaPair("noProxy", this._default(runtime.noProxy, _noProxy)),
            new TeaPair("socks5Proxy", this._default(runtime.socks5Proxy, _socks5Proxy)),
            new TeaPair("socks5NetWork", this._default(runtime.socks5NetWork, _socks5NetWork)),
            new TeaPair("maxIdleConns", this._defaultNumber(runtime.maxIdleConns, _maxIdleConns)),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", this._defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", this._default(runtime.backoffPolicy, "no")),
                new TeaPair("period", this._defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL),
            new TeaPair("logger", _logger),
            new TeaPair("listener", runtime.listener)
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
                String token = this._getSecurityToken();
                request_.protocol = _protocol;
                request_.method = "DELETE";
                request_.pathname = "/?website";
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("host", this.getHost(request.bucketName)),
                    new TeaPair("date", this._getDate()),
                    new TeaPair("user-agent", this._getUserAgent())
                );
                if (!this._empty(token)) {
                    request_.headers.put("x-oss-security-token", token);
                }

                request_.headers.put("authorization", this.getSignature(request_, request.bucketName));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                String bodyStr = null;
                if (this._isFail(response_)) {
                    bodyStr = this._readAsString(response_);
                    respMap = this._getErrMessage(bodyStr);
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

    public GetSymlinkResponse getSymlink(GetSymlinkRequest request, RuntimeObject runtime) throws Exception {
        request.validate();
        runtime.validate();
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", this._defaultNumber(runtime.readTimeout, _readTimeout)),
            new TeaPair("connectTimeout", this._defaultNumber(runtime.connectTimeout, _connectTimeout)),
            new TeaPair("localAddr", this._default(runtime.localAddr, _localAddr)),
            new TeaPair("httpProxy", this._default(runtime.httpProxy, _httpProxy)),
            new TeaPair("httpsProxy", this._default(runtime.httpsProxy, _httpsProxy)),
            new TeaPair("noProxy", this._default(runtime.noProxy, _noProxy)),
            new TeaPair("socks5Proxy", this._default(runtime.socks5Proxy, _socks5Proxy)),
            new TeaPair("socks5NetWork", this._default(runtime.socks5NetWork, _socks5NetWork)),
            new TeaPair("maxIdleConns", this._defaultNumber(runtime.maxIdleConns, _maxIdleConns)),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", this._defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", this._default(runtime.backoffPolicy, "no")),
                new TeaPair("period", this._defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL),
            new TeaPair("logger", _logger),
            new TeaPair("listener", runtime.listener)
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
                String token = this._getSecurityToken();
                request_.protocol = _protocol;
                request_.method = "GET";
                request_.pathname = "/" + request.objectName + "?symlink";
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("host", this.getHost(request.bucketName)),
                    new TeaPair("date", this._getDate()),
                    new TeaPair("user-agent", this._getUserAgent())
                );
                if (!this._empty(token)) {
                    request_.headers.put("x-oss-security-token", token);
                }

                request_.headers.put("authorization", this.getSignature(request_, request.bucketName));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                String bodyStr = null;
                if (this._isFail(response_)) {
                    bodyStr = this._readAsString(response_);
                    respMap = this._getErrMessage(bodyStr);
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

    public GetBucketLifecycleResponse getBucketLifecycle(GetBucketLifecycleRequest request, RuntimeObject runtime) throws Exception {
        request.validate();
        runtime.validate();
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", this._defaultNumber(runtime.readTimeout, _readTimeout)),
            new TeaPair("connectTimeout", this._defaultNumber(runtime.connectTimeout, _connectTimeout)),
            new TeaPair("localAddr", this._default(runtime.localAddr, _localAddr)),
            new TeaPair("httpProxy", this._default(runtime.httpProxy, _httpProxy)),
            new TeaPair("httpsProxy", this._default(runtime.httpsProxy, _httpsProxy)),
            new TeaPair("noProxy", this._default(runtime.noProxy, _noProxy)),
            new TeaPair("socks5Proxy", this._default(runtime.socks5Proxy, _socks5Proxy)),
            new TeaPair("socks5NetWork", this._default(runtime.socks5NetWork, _socks5NetWork)),
            new TeaPair("maxIdleConns", this._defaultNumber(runtime.maxIdleConns, _maxIdleConns)),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", this._defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", this._default(runtime.backoffPolicy, "no")),
                new TeaPair("period", this._defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL),
            new TeaPair("logger", _logger),
            new TeaPair("listener", runtime.listener)
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
                String token = this._getSecurityToken();
                request_.protocol = _protocol;
                request_.method = "GET";
                request_.pathname = "/?lifecycle";
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("host", this.getHost(request.bucketName)),
                    new TeaPair("date", this._getDate()),
                    new TeaPair("user-agent", this._getUserAgent())
                );
                if (!this._empty(token)) {
                    request_.headers.put("x-oss-security-token", token);
                }

                request_.headers.put("authorization", this.getSignature(request_, request.bucketName));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                String bodyStr = null;
                if (this._isFail(response_)) {
                    bodyStr = this._readAsString(response_);
                    respMap = this._getErrMessage(bodyStr);
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

                bodyStr = this._readAsString(response_);
                respMap = this._parseXml(bodyStr, GetBucketLifecycleResponse.class);
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

    public PutSymlinkResponse putSymlink(PutSymlinkRequest request, RuntimeObject runtime) throws Exception {
        request.validate();
        runtime.validate();
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", this._defaultNumber(runtime.readTimeout, _readTimeout)),
            new TeaPair("connectTimeout", this._defaultNumber(runtime.connectTimeout, _connectTimeout)),
            new TeaPair("localAddr", this._default(runtime.localAddr, _localAddr)),
            new TeaPair("httpProxy", this._default(runtime.httpProxy, _httpProxy)),
            new TeaPair("httpsProxy", this._default(runtime.httpsProxy, _httpsProxy)),
            new TeaPair("noProxy", this._default(runtime.noProxy, _noProxy)),
            new TeaPair("socks5Proxy", this._default(runtime.socks5Proxy, _socks5Proxy)),
            new TeaPair("socks5NetWork", this._default(runtime.socks5NetWork, _socks5NetWork)),
            new TeaPair("maxIdleConns", this._defaultNumber(runtime.maxIdleConns, _maxIdleConns)),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", this._defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", this._default(runtime.backoffPolicy, "no")),
                new TeaPair("period", this._defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL),
            new TeaPair("logger", _logger),
            new TeaPair("listener", runtime.listener)
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
                String token = this._getSecurityToken();
                request_.protocol = _protocol;
                request_.method = "PUT";
                request_.pathname = "/" + request.objectName + "?symlink";
                request_.headers = TeaConverter.merge(String.class, 
                    TeaConverter.buildMap(
                        new TeaPair("host", this.getHost(request.bucketName)),
                        new TeaPair("date", this._getDate()),
                        new TeaPair("user-agent", this._getUserAgent())
                    ),
                    this._toHeader(TeaModel.buildMap(request.header))
                );
                if (!this._empty(token)) {
                    request_.headers.put("x-oss-security-token", token);
                }

                request_.headers.put("authorization", this.getSignature(request_, request.bucketName));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                String bodyStr = null;
                if (this._isFail(response_)) {
                    bodyStr = this._readAsString(response_);
                    respMap = this._getErrMessage(bodyStr);
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

    public GetBucketRefererResponse getBucketReferer(GetBucketRefererRequest request, RuntimeObject runtime) throws Exception {
        request.validate();
        runtime.validate();
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", this._defaultNumber(runtime.readTimeout, _readTimeout)),
            new TeaPair("connectTimeout", this._defaultNumber(runtime.connectTimeout, _connectTimeout)),
            new TeaPair("localAddr", this._default(runtime.localAddr, _localAddr)),
            new TeaPair("httpProxy", this._default(runtime.httpProxy, _httpProxy)),
            new TeaPair("httpsProxy", this._default(runtime.httpsProxy, _httpsProxy)),
            new TeaPair("noProxy", this._default(runtime.noProxy, _noProxy)),
            new TeaPair("socks5Proxy", this._default(runtime.socks5Proxy, _socks5Proxy)),
            new TeaPair("socks5NetWork", this._default(runtime.socks5NetWork, _socks5NetWork)),
            new TeaPair("maxIdleConns", this._defaultNumber(runtime.maxIdleConns, _maxIdleConns)),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", this._defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", this._default(runtime.backoffPolicy, "no")),
                new TeaPair("period", this._defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL),
            new TeaPair("logger", _logger),
            new TeaPair("listener", runtime.listener)
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
                String token = this._getSecurityToken();
                request_.protocol = _protocol;
                request_.method = "GET";
                request_.pathname = "/?referer";
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("host", this.getHost(request.bucketName)),
                    new TeaPair("date", this._getDate()),
                    new TeaPair("user-agent", this._getUserAgent())
                );
                if (!this._empty(token)) {
                    request_.headers.put("x-oss-security-token", token);
                }

                request_.headers.put("authorization", this.getSignature(request_, request.bucketName));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                String bodyStr = null;
                if (this._isFail(response_)) {
                    bodyStr = this._readAsString(response_);
                    respMap = this._getErrMessage(bodyStr);
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

                bodyStr = this._readAsString(response_);
                respMap = this._parseXml(bodyStr, GetBucketRefererResponse.class);
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

    public CallbackResponse callback(CallbackRequest request, RuntimeObject runtime) throws Exception {
        request.validate();
        runtime.validate();
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", this._defaultNumber(runtime.readTimeout, _readTimeout)),
            new TeaPair("connectTimeout", this._defaultNumber(runtime.connectTimeout, _connectTimeout)),
            new TeaPair("localAddr", this._default(runtime.localAddr, _localAddr)),
            new TeaPair("httpProxy", this._default(runtime.httpProxy, _httpProxy)),
            new TeaPair("httpsProxy", this._default(runtime.httpsProxy, _httpsProxy)),
            new TeaPair("noProxy", this._default(runtime.noProxy, _noProxy)),
            new TeaPair("socks5Proxy", this._default(runtime.socks5Proxy, _socks5Proxy)),
            new TeaPair("socks5NetWork", this._default(runtime.socks5NetWork, _socks5NetWork)),
            new TeaPair("maxIdleConns", this._defaultNumber(runtime.maxIdleConns, _maxIdleConns)),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", this._defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", this._default(runtime.backoffPolicy, "no")),
                new TeaPair("period", this._defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL),
            new TeaPair("logger", _logger),
            new TeaPair("listener", runtime.listener)
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
                String token = this._getSecurityToken();
                request_.protocol = _protocol;
                request_.method = "GET";
                request_.pathname = "/";
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("host", this.getHost(request.bucketName)),
                    new TeaPair("date", this._getDate()),
                    new TeaPair("user-agent", this._getUserAgent())
                );
                if (!this._empty(token)) {
                    request_.headers.put("x-oss-security-token", token);
                }

                request_.headers.put("authorization", this.getSignature(request_, request.bucketName));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                String bodyStr = null;
                if (this._isFail(response_)) {
                    bodyStr = this._readAsString(response_);
                    respMap = this._getErrMessage(bodyStr);
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

    public GetBucketLoggingResponse getBucketLogging(GetBucketLoggingRequest request, RuntimeObject runtime) throws Exception {
        request.validate();
        runtime.validate();
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", this._defaultNumber(runtime.readTimeout, _readTimeout)),
            new TeaPair("connectTimeout", this._defaultNumber(runtime.connectTimeout, _connectTimeout)),
            new TeaPair("localAddr", this._default(runtime.localAddr, _localAddr)),
            new TeaPair("httpProxy", this._default(runtime.httpProxy, _httpProxy)),
            new TeaPair("httpsProxy", this._default(runtime.httpsProxy, _httpsProxy)),
            new TeaPair("noProxy", this._default(runtime.noProxy, _noProxy)),
            new TeaPair("socks5Proxy", this._default(runtime.socks5Proxy, _socks5Proxy)),
            new TeaPair("socks5NetWork", this._default(runtime.socks5NetWork, _socks5NetWork)),
            new TeaPair("maxIdleConns", this._defaultNumber(runtime.maxIdleConns, _maxIdleConns)),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", this._defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", this._default(runtime.backoffPolicy, "no")),
                new TeaPair("period", this._defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL),
            new TeaPair("logger", _logger),
            new TeaPair("listener", runtime.listener)
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
                String token = this._getSecurityToken();
                request_.protocol = _protocol;
                request_.method = "GET";
                request_.pathname = "/?logging";
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("host", this.getHost(request.bucketName)),
                    new TeaPair("date", this._getDate()),
                    new TeaPair("user-agent", this._getUserAgent())
                );
                if (!this._empty(token)) {
                    request_.headers.put("x-oss-security-token", token);
                }

                request_.headers.put("authorization", this.getSignature(request_, request.bucketName));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                String bodyStr = null;
                if (this._isFail(response_)) {
                    bodyStr = this._readAsString(response_);
                    respMap = this._getErrMessage(bodyStr);
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

                bodyStr = this._readAsString(response_);
                respMap = this._parseXml(bodyStr, GetBucketLoggingResponse.class);
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

    public PutObjectAclResponse putObjectAcl(PutObjectAclRequest request, RuntimeObject runtime) throws Exception {
        request.validate();
        runtime.validate();
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", this._defaultNumber(runtime.readTimeout, _readTimeout)),
            new TeaPair("connectTimeout", this._defaultNumber(runtime.connectTimeout, _connectTimeout)),
            new TeaPair("localAddr", this._default(runtime.localAddr, _localAddr)),
            new TeaPair("httpProxy", this._default(runtime.httpProxy, _httpProxy)),
            new TeaPair("httpsProxy", this._default(runtime.httpsProxy, _httpsProxy)),
            new TeaPair("noProxy", this._default(runtime.noProxy, _noProxy)),
            new TeaPair("socks5Proxy", this._default(runtime.socks5Proxy, _socks5Proxy)),
            new TeaPair("socks5NetWork", this._default(runtime.socks5NetWork, _socks5NetWork)),
            new TeaPair("maxIdleConns", this._defaultNumber(runtime.maxIdleConns, _maxIdleConns)),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", this._defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", this._default(runtime.backoffPolicy, "no")),
                new TeaPair("period", this._defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL),
            new TeaPair("logger", _logger),
            new TeaPair("listener", runtime.listener)
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
                String token = this._getSecurityToken();
                request_.protocol = _protocol;
                request_.method = "PUT";
                request_.pathname = "/" + request.objectName + "?acl";
                request_.headers = TeaConverter.merge(String.class, 
                    TeaConverter.buildMap(
                        new TeaPair("host", this.getHost(request.bucketName)),
                        new TeaPair("date", this._getDate()),
                        new TeaPair("user-agent", this._getUserAgent())
                    ),
                    this._toHeader(TeaModel.buildMap(request.header))
                );
                if (!this._empty(token)) {
                    request_.headers.put("x-oss-security-token", token);
                }

                request_.headers.put("authorization", this.getSignature(request_, request.bucketName));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                String bodyStr = null;
                if (this._isFail(response_)) {
                    bodyStr = this._readAsString(response_);
                    respMap = this._getErrMessage(bodyStr);
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

    public GetBucketInfoResponse getBucketInfo(GetBucketInfoRequest request, RuntimeObject runtime) throws Exception {
        request.validate();
        runtime.validate();
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", this._defaultNumber(runtime.readTimeout, _readTimeout)),
            new TeaPair("connectTimeout", this._defaultNumber(runtime.connectTimeout, _connectTimeout)),
            new TeaPair("localAddr", this._default(runtime.localAddr, _localAddr)),
            new TeaPair("httpProxy", this._default(runtime.httpProxy, _httpProxy)),
            new TeaPair("httpsProxy", this._default(runtime.httpsProxy, _httpsProxy)),
            new TeaPair("noProxy", this._default(runtime.noProxy, _noProxy)),
            new TeaPair("socks5Proxy", this._default(runtime.socks5Proxy, _socks5Proxy)),
            new TeaPair("socks5NetWork", this._default(runtime.socks5NetWork, _socks5NetWork)),
            new TeaPair("maxIdleConns", this._defaultNumber(runtime.maxIdleConns, _maxIdleConns)),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", this._defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", this._default(runtime.backoffPolicy, "no")),
                new TeaPair("period", this._defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL),
            new TeaPair("logger", _logger),
            new TeaPair("listener", runtime.listener)
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
                String token = this._getSecurityToken();
                request_.protocol = _protocol;
                request_.method = "GET";
                request_.pathname = "/?bucketInfo";
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("host", this.getHost(request.bucketName)),
                    new TeaPair("date", this._getDate()),
                    new TeaPair("user-agent", this._getUserAgent())
                );
                if (!this._empty(token)) {
                    request_.headers.put("x-oss-security-token", token);
                }

                request_.headers.put("authorization", this.getSignature(request_, request.bucketName));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                String bodyStr = null;
                if (this._isFail(response_)) {
                    bodyStr = this._readAsString(response_);
                    respMap = this._getErrMessage(bodyStr);
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

                bodyStr = this._readAsString(response_);
                respMap = this._parseXml(bodyStr, GetBucketInfoResponse.class);
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

    public PutLiveChannelStatusResponse putLiveChannelStatus(PutLiveChannelStatusRequest request, RuntimeObject runtime) throws Exception {
        request.validate();
        runtime.validate();
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", this._defaultNumber(runtime.readTimeout, _readTimeout)),
            new TeaPair("connectTimeout", this._defaultNumber(runtime.connectTimeout, _connectTimeout)),
            new TeaPair("localAddr", this._default(runtime.localAddr, _localAddr)),
            new TeaPair("httpProxy", this._default(runtime.httpProxy, _httpProxy)),
            new TeaPair("httpsProxy", this._default(runtime.httpsProxy, _httpsProxy)),
            new TeaPair("noProxy", this._default(runtime.noProxy, _noProxy)),
            new TeaPair("socks5Proxy", this._default(runtime.socks5Proxy, _socks5Proxy)),
            new TeaPair("socks5NetWork", this._default(runtime.socks5NetWork, _socks5NetWork)),
            new TeaPair("maxIdleConns", this._defaultNumber(runtime.maxIdleConns, _maxIdleConns)),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", this._defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", this._default(runtime.backoffPolicy, "no")),
                new TeaPair("period", this._defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL),
            new TeaPair("logger", _logger),
            new TeaPair("listener", runtime.listener)
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
                String token = this._getSecurityToken();
                request_.protocol = _protocol;
                request_.method = "PUT";
                request_.pathname = "/" + request.channelName + "?live";
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("host", this.getHost(request.bucketName)),
                    new TeaPair("date", this._getDate()),
                    new TeaPair("user-agent", this._getUserAgent())
                );
                if (!this._empty(token)) {
                    request_.headers.put("x-oss-security-token", token);
                }

                request_.query = this._toQuery(TeaModel.buildMap(request.filter));
                request_.headers.put("authorization", this.getSignature(request_, request.bucketName));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                String bodyStr = null;
                if (this._isFail(response_)) {
                    bodyStr = this._readAsString(response_);
                    respMap = this._getErrMessage(bodyStr);
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

    public InitiateMultipartUploadResponse initiateMultipartUpload(InitiateMultipartUploadRequest request, RuntimeObject runtime) throws Exception {
        request.validate();
        runtime.validate();
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", this._defaultNumber(runtime.readTimeout, _readTimeout)),
            new TeaPair("connectTimeout", this._defaultNumber(runtime.connectTimeout, _connectTimeout)),
            new TeaPair("localAddr", this._default(runtime.localAddr, _localAddr)),
            new TeaPair("httpProxy", this._default(runtime.httpProxy, _httpProxy)),
            new TeaPair("httpsProxy", this._default(runtime.httpsProxy, _httpsProxy)),
            new TeaPair("noProxy", this._default(runtime.noProxy, _noProxy)),
            new TeaPair("socks5Proxy", this._default(runtime.socks5Proxy, _socks5Proxy)),
            new TeaPair("socks5NetWork", this._default(runtime.socks5NetWork, _socks5NetWork)),
            new TeaPair("maxIdleConns", this._defaultNumber(runtime.maxIdleConns, _maxIdleConns)),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", this._defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", this._default(runtime.backoffPolicy, "no")),
                new TeaPair("period", this._defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL),
            new TeaPair("logger", _logger),
            new TeaPair("listener", runtime.listener)
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
                String token = this._getSecurityToken();
                request_.protocol = _protocol;
                request_.method = "POST";
                request_.pathname = "/" + request.objectName + "?uploads";
                request_.headers = TeaConverter.merge(String.class, 
                    TeaConverter.buildMap(
                        new TeaPair("host", this.getHost(request.bucketName)),
                        new TeaPair("date", this._getDate()),
                        new TeaPair("user-agent", this._getUserAgent())
                    ),
                    this._toHeader(TeaModel.buildMap(request.header))
                );
                if (!this._empty(token)) {
                    request_.headers.put("x-oss-security-token", token);
                }

                request_.query = this._toQuery(TeaModel.buildMap(request.filter));
                if (this._notNull(TeaModel.buildMap(request.header)) && !this._empty(request.header.contentType)) {
                    request_.headers.put("content-type", request.header.contentType);
                } else {
                    request_.headers.put("content-type", this._getContentType(request.objectName));
                }

                request_.headers.put("authorization", this.getSignature(request_, request.bucketName));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                String bodyStr = null;
                if (this._isFail(response_)) {
                    bodyStr = this._readAsString(response_);
                    respMap = this._getErrMessage(bodyStr);
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

                bodyStr = this._readAsString(response_);
                respMap = this._parseXml(bodyStr, InitiateMultipartUploadResponse.class);
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

    public OptionObjectResponse optionObject(OptionObjectRequest request, RuntimeObject runtime) throws Exception {
        request.validate();
        runtime.validate();
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", this._defaultNumber(runtime.readTimeout, _readTimeout)),
            new TeaPair("connectTimeout", this._defaultNumber(runtime.connectTimeout, _connectTimeout)),
            new TeaPair("localAddr", this._default(runtime.localAddr, _localAddr)),
            new TeaPair("httpProxy", this._default(runtime.httpProxy, _httpProxy)),
            new TeaPair("httpsProxy", this._default(runtime.httpsProxy, _httpsProxy)),
            new TeaPair("noProxy", this._default(runtime.noProxy, _noProxy)),
            new TeaPair("socks5Proxy", this._default(runtime.socks5Proxy, _socks5Proxy)),
            new TeaPair("socks5NetWork", this._default(runtime.socks5NetWork, _socks5NetWork)),
            new TeaPair("maxIdleConns", this._defaultNumber(runtime.maxIdleConns, _maxIdleConns)),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", this._defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", this._default(runtime.backoffPolicy, "no")),
                new TeaPair("period", this._defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL),
            new TeaPair("logger", _logger),
            new TeaPair("listener", runtime.listener)
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
                String token = this._getSecurityToken();
                request_.protocol = _protocol;
                request_.method = "OPTIONS";
                request_.pathname = "/" + request.objectName + "";
                request_.headers = TeaConverter.merge(String.class, 
                    TeaConverter.buildMap(
                        new TeaPair("host", this.getHost(request.bucketName)),
                        new TeaPair("date", this._getDate()),
                        new TeaPair("user-agent", this._getUserAgent())
                    ),
                    this._toHeader(TeaModel.buildMap(request.header))
                );
                if (!this._empty(token)) {
                    request_.headers.put("x-oss-security-token", token);
                }

                request_.headers.put("authorization", this.getSignature(request_, request.bucketName));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                String bodyStr = null;
                if (this._isFail(response_)) {
                    bodyStr = this._readAsString(response_);
                    respMap = this._getErrMessage(bodyStr);
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

    public PostVodPlaylistResponse postVodPlaylist(PostVodPlaylistRequest request, RuntimeObject runtime) throws Exception {
        request.validate();
        runtime.validate();
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", this._defaultNumber(runtime.readTimeout, _readTimeout)),
            new TeaPair("connectTimeout", this._defaultNumber(runtime.connectTimeout, _connectTimeout)),
            new TeaPair("localAddr", this._default(runtime.localAddr, _localAddr)),
            new TeaPair("httpProxy", this._default(runtime.httpProxy, _httpProxy)),
            new TeaPair("httpsProxy", this._default(runtime.httpsProxy, _httpsProxy)),
            new TeaPair("noProxy", this._default(runtime.noProxy, _noProxy)),
            new TeaPair("socks5Proxy", this._default(runtime.socks5Proxy, _socks5Proxy)),
            new TeaPair("socks5NetWork", this._default(runtime.socks5NetWork, _socks5NetWork)),
            new TeaPair("maxIdleConns", this._defaultNumber(runtime.maxIdleConns, _maxIdleConns)),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", this._defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", this._default(runtime.backoffPolicy, "no")),
                new TeaPair("period", this._defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL),
            new TeaPair("logger", _logger),
            new TeaPair("listener", runtime.listener)
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
                String token = this._getSecurityToken();
                request_.protocol = _protocol;
                request_.method = "POST";
                request_.pathname = "/" + request.channelName + "/" + request.playlistName + "?vod";
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("host", this.getHost(request.bucketName)),
                    new TeaPair("date", this._getDate()),
                    new TeaPair("user-agent", this._getUserAgent())
                );
                if (!this._empty(token)) {
                    request_.headers.put("x-oss-security-token", token);
                }

                request_.query = this._toQuery(TeaModel.buildMap(request.filter));
                request_.headers.put("authorization", this.getSignature(request_, request.bucketName));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                String bodyStr = null;
                if (this._isFail(response_)) {
                    bodyStr = this._readAsString(response_);
                    respMap = this._getErrMessage(bodyStr);
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

    public PostObjectResponse postObject(PostObjectRequest request, RuntimeObject runtime) throws Exception {
        request.validate();
        runtime.validate();
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", this._defaultNumber(runtime.readTimeout, _readTimeout)),
            new TeaPair("connectTimeout", this._defaultNumber(runtime.connectTimeout, _connectTimeout)),
            new TeaPair("localAddr", this._default(runtime.localAddr, _localAddr)),
            new TeaPair("httpProxy", this._default(runtime.httpProxy, _httpProxy)),
            new TeaPair("httpsProxy", this._default(runtime.httpsProxy, _httpsProxy)),
            new TeaPair("noProxy", this._default(runtime.noProxy, _noProxy)),
            new TeaPair("socks5Proxy", this._default(runtime.socks5Proxy, _socks5Proxy)),
            new TeaPair("socks5NetWork", this._default(runtime.socks5NetWork, _socks5NetWork)),
            new TeaPair("maxIdleConns", this._defaultNumber(runtime.maxIdleConns, _maxIdleConns)),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", this._defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", this._default(runtime.backoffPolicy, "no")),
                new TeaPair("period", this._defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL),
            new TeaPair("logger", _logger),
            new TeaPair("listener", runtime.listener)
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
                String token = this._getSecurityToken();
                request_.protocol = _protocol;
                request_.method = "POST";
                request_.pathname = "/";
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("host", this.getHost(request.bucketName)),
                    new TeaPair("date", this._getDate()),
                    new TeaPair("user-agent", this._getUserAgent())
                );
                if (!this._empty(token)) {
                    request_.headers.put("x-oss-security-token", token);
                }

                request_.headers.put("authorization", this.getSignature(request_, request.bucketName));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                String bodyStr = null;
                if (this._isFail(response_)) {
                    bodyStr = this._readAsString(response_);
                    respMap = this._getErrMessage(bodyStr);
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
                    response_.headers
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

    public HeadObjectResponse headObject(HeadObjectRequest request, RuntimeObject runtime) throws Exception {
        request.validate();
        runtime.validate();
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", this._defaultNumber(runtime.readTimeout, _readTimeout)),
            new TeaPair("connectTimeout", this._defaultNumber(runtime.connectTimeout, _connectTimeout)),
            new TeaPair("localAddr", this._default(runtime.localAddr, _localAddr)),
            new TeaPair("httpProxy", this._default(runtime.httpProxy, _httpProxy)),
            new TeaPair("httpsProxy", this._default(runtime.httpsProxy, _httpsProxy)),
            new TeaPair("noProxy", this._default(runtime.noProxy, _noProxy)),
            new TeaPair("socks5Proxy", this._default(runtime.socks5Proxy, _socks5Proxy)),
            new TeaPair("socks5NetWork", this._default(runtime.socks5NetWork, _socks5NetWork)),
            new TeaPair("maxIdleConns", this._defaultNumber(runtime.maxIdleConns, _maxIdleConns)),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", this._defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", this._default(runtime.backoffPolicy, "no")),
                new TeaPair("period", this._defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL),
            new TeaPair("logger", _logger),
            new TeaPair("listener", runtime.listener)
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
                String token = this._getSecurityToken();
                request_.protocol = _protocol;
                request_.method = "HEAD";
                request_.pathname = "/" + request.objectName + "";
                request_.headers = TeaConverter.merge(String.class, 
                    TeaConverter.buildMap(
                        new TeaPair("host", this.getHost(request.bucketName)),
                        new TeaPair("date", this._getDate()),
                        new TeaPair("user-agent", this._getUserAgent())
                    ),
                    this._toHeader(TeaModel.buildMap(request.header))
                );
                if (!this._empty(token)) {
                    request_.headers.put("x-oss-security-token", token);
                }

                request_.headers.put("authorization", this.getSignature(request_, request.bucketName));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                String bodyStr = null;
                if (this._isFail(response_)) {
                    bodyStr = this._readAsString(response_);
                    respMap = this._getErrMessage(bodyStr);
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
                        new TeaPair("usermeta", this._toMeta(response_.headers, "x-oss-meta-"))
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

    public DeleteObjectTaggingResponse deleteObjectTagging(DeleteObjectTaggingRequest request, RuntimeObject runtime) throws Exception {
        request.validate();
        runtime.validate();
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", this._defaultNumber(runtime.readTimeout, _readTimeout)),
            new TeaPair("connectTimeout", this._defaultNumber(runtime.connectTimeout, _connectTimeout)),
            new TeaPair("localAddr", this._default(runtime.localAddr, _localAddr)),
            new TeaPair("httpProxy", this._default(runtime.httpProxy, _httpProxy)),
            new TeaPair("httpsProxy", this._default(runtime.httpsProxy, _httpsProxy)),
            new TeaPair("noProxy", this._default(runtime.noProxy, _noProxy)),
            new TeaPair("socks5Proxy", this._default(runtime.socks5Proxy, _socks5Proxy)),
            new TeaPair("socks5NetWork", this._default(runtime.socks5NetWork, _socks5NetWork)),
            new TeaPair("maxIdleConns", this._defaultNumber(runtime.maxIdleConns, _maxIdleConns)),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", this._defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", this._default(runtime.backoffPolicy, "no")),
                new TeaPair("period", this._defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL),
            new TeaPair("logger", _logger),
            new TeaPair("listener", runtime.listener)
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
                String token = this._getSecurityToken();
                request_.protocol = _protocol;
                request_.method = "DELETE";
                request_.pathname = "/" + request.objectName + "?tagging";
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("host", this.getHost(request.bucketName)),
                    new TeaPair("date", this._getDate()),
                    new TeaPair("user-agent", this._getUserAgent())
                );
                if (!this._empty(token)) {
                    request_.headers.put("x-oss-security-token", token);
                }

                request_.headers.put("authorization", this.getSignature(request_, request.bucketName));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                String bodyStr = null;
                if (this._isFail(response_)) {
                    bodyStr = this._readAsString(response_);
                    respMap = this._getErrMessage(bodyStr);
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

    public RestoreObjectResponse restoreObject(RestoreObjectRequest request, RuntimeObject runtime) throws Exception {
        request.validate();
        runtime.validate();
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", this._defaultNumber(runtime.readTimeout, _readTimeout)),
            new TeaPair("connectTimeout", this._defaultNumber(runtime.connectTimeout, _connectTimeout)),
            new TeaPair("localAddr", this._default(runtime.localAddr, _localAddr)),
            new TeaPair("httpProxy", this._default(runtime.httpProxy, _httpProxy)),
            new TeaPair("httpsProxy", this._default(runtime.httpsProxy, _httpsProxy)),
            new TeaPair("noProxy", this._default(runtime.noProxy, _noProxy)),
            new TeaPair("socks5Proxy", this._default(runtime.socks5Proxy, _socks5Proxy)),
            new TeaPair("socks5NetWork", this._default(runtime.socks5NetWork, _socks5NetWork)),
            new TeaPair("maxIdleConns", this._defaultNumber(runtime.maxIdleConns, _maxIdleConns)),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", this._defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", this._default(runtime.backoffPolicy, "no")),
                new TeaPair("period", this._defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL),
            new TeaPair("logger", _logger),
            new TeaPair("listener", runtime.listener)
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
                String token = this._getSecurityToken();
                request_.protocol = _protocol;
                request_.method = "POST";
                request_.pathname = "/" + request.objectName + "?restore";
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("host", this.getHost(request.bucketName)),
                    new TeaPair("date", this._getDate()),
                    new TeaPair("user-agent", this._getUserAgent())
                );
                if (!this._empty(token)) {
                    request_.headers.put("x-oss-security-token", token);
                }

                request_.headers.put("authorization", this.getSignature(request_, request.bucketName));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                String bodyStr = null;
                if (this._isFail(response_)) {
                    bodyStr = this._readAsString(response_);
                    respMap = this._getErrMessage(bodyStr);
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

    public GetObjectAclResponse getObjectAcl(GetObjectAclRequest request, RuntimeObject runtime) throws Exception {
        request.validate();
        runtime.validate();
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", this._defaultNumber(runtime.readTimeout, _readTimeout)),
            new TeaPair("connectTimeout", this._defaultNumber(runtime.connectTimeout, _connectTimeout)),
            new TeaPair("localAddr", this._default(runtime.localAddr, _localAddr)),
            new TeaPair("httpProxy", this._default(runtime.httpProxy, _httpProxy)),
            new TeaPair("httpsProxy", this._default(runtime.httpsProxy, _httpsProxy)),
            new TeaPair("noProxy", this._default(runtime.noProxy, _noProxy)),
            new TeaPair("socks5Proxy", this._default(runtime.socks5Proxy, _socks5Proxy)),
            new TeaPair("socks5NetWork", this._default(runtime.socks5NetWork, _socks5NetWork)),
            new TeaPair("maxIdleConns", this._defaultNumber(runtime.maxIdleConns, _maxIdleConns)),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", this._defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", this._default(runtime.backoffPolicy, "no")),
                new TeaPair("period", this._defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL),
            new TeaPair("logger", _logger),
            new TeaPair("listener", runtime.listener)
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
                String token = this._getSecurityToken();
                request_.protocol = _protocol;
                request_.method = "GET";
                request_.pathname = "/" + request.objectName + "?acl";
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("host", this.getHost(request.bucketName)),
                    new TeaPair("date", this._getDate()),
                    new TeaPair("user-agent", this._getUserAgent())
                );
                if (!this._empty(token)) {
                    request_.headers.put("x-oss-security-token", token);
                }

                request_.headers.put("authorization", this.getSignature(request_, request.bucketName));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                String bodyStr = null;
                if (this._isFail(response_)) {
                    bodyStr = this._readAsString(response_);
                    respMap = this._getErrMessage(bodyStr);
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

                bodyStr = this._readAsString(response_);
                respMap = this._parseXml(bodyStr, GetObjectAclResponse.class);
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

    public PutBucketAclResponse putBucketAcl(PutBucketAclRequest request, RuntimeObject runtime) throws Exception {
        request.validate();
        runtime.validate();
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", this._defaultNumber(runtime.readTimeout, _readTimeout)),
            new TeaPair("connectTimeout", this._defaultNumber(runtime.connectTimeout, _connectTimeout)),
            new TeaPair("localAddr", this._default(runtime.localAddr, _localAddr)),
            new TeaPair("httpProxy", this._default(runtime.httpProxy, _httpProxy)),
            new TeaPair("httpsProxy", this._default(runtime.httpsProxy, _httpsProxy)),
            new TeaPair("noProxy", this._default(runtime.noProxy, _noProxy)),
            new TeaPair("socks5Proxy", this._default(runtime.socks5Proxy, _socks5Proxy)),
            new TeaPair("socks5NetWork", this._default(runtime.socks5NetWork, _socks5NetWork)),
            new TeaPair("maxIdleConns", this._defaultNumber(runtime.maxIdleConns, _maxIdleConns)),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", this._defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", this._default(runtime.backoffPolicy, "no")),
                new TeaPair("period", this._defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL),
            new TeaPair("logger", _logger),
            new TeaPair("listener", runtime.listener)
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
                String token = this._getSecurityToken();
                request_.protocol = _protocol;
                request_.method = "PUT";
                request_.pathname = "/?acl";
                request_.headers = TeaConverter.merge(String.class, 
                    TeaConverter.buildMap(
                        new TeaPair("host", this.getHost(request.bucketName)),
                        new TeaPair("date", this._getDate()),
                        new TeaPair("user-agent", this._getUserAgent())
                    ),
                    this._toHeader(TeaModel.buildMap(request.header))
                );
                if (!this._empty(token)) {
                    request_.headers.put("x-oss-security-token", token);
                }

                request_.headers.put("authorization", this.getSignature(request_, request.bucketName));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                String bodyStr = null;
                if (this._isFail(response_)) {
                    bodyStr = this._readAsString(response_);
                    respMap = this._getErrMessage(bodyStr);
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

    public DeleteBucketResponse deleteBucket(DeleteBucketRequest request, RuntimeObject runtime) throws Exception {
        request.validate();
        runtime.validate();
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", this._defaultNumber(runtime.readTimeout, _readTimeout)),
            new TeaPair("connectTimeout", this._defaultNumber(runtime.connectTimeout, _connectTimeout)),
            new TeaPair("localAddr", this._default(runtime.localAddr, _localAddr)),
            new TeaPair("httpProxy", this._default(runtime.httpProxy, _httpProxy)),
            new TeaPair("httpsProxy", this._default(runtime.httpsProxy, _httpsProxy)),
            new TeaPair("noProxy", this._default(runtime.noProxy, _noProxy)),
            new TeaPair("socks5Proxy", this._default(runtime.socks5Proxy, _socks5Proxy)),
            new TeaPair("socks5NetWork", this._default(runtime.socks5NetWork, _socks5NetWork)),
            new TeaPair("maxIdleConns", this._defaultNumber(runtime.maxIdleConns, _maxIdleConns)),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", this._defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", this._default(runtime.backoffPolicy, "no")),
                new TeaPair("period", this._defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL),
            new TeaPair("logger", _logger),
            new TeaPair("listener", runtime.listener)
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
                String token = this._getSecurityToken();
                request_.protocol = _protocol;
                request_.method = "DELETE";
                request_.pathname = "/";
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("host", this.getHost(request.bucketName)),
                    new TeaPair("date", this._getDate()),
                    new TeaPair("user-agent", this._getUserAgent())
                );
                if (!this._empty(token)) {
                    request_.headers.put("x-oss-security-token", token);
                }

                request_.headers.put("authorization", this.getSignature(request_, request.bucketName));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                String bodyStr = null;
                if (this._isFail(response_)) {
                    bodyStr = this._readAsString(response_);
                    respMap = this._getErrMessage(bodyStr);
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

    public PutObjectResponse putObject(PutObjectRequest request, RuntimeObject runtime) throws Exception {
        request.validate();
        runtime.validate();
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", this._defaultNumber(runtime.readTimeout, _readTimeout)),
            new TeaPair("connectTimeout", this._defaultNumber(runtime.connectTimeout, _connectTimeout)),
            new TeaPair("localAddr", this._default(runtime.localAddr, _localAddr)),
            new TeaPair("httpProxy", this._default(runtime.httpProxy, _httpProxy)),
            new TeaPair("httpsProxy", this._default(runtime.httpsProxy, _httpsProxy)),
            new TeaPair("noProxy", this._default(runtime.noProxy, _noProxy)),
            new TeaPair("socks5Proxy", this._default(runtime.socks5Proxy, _socks5Proxy)),
            new TeaPair("socks5NetWork", this._default(runtime.socks5NetWork, _socks5NetWork)),
            new TeaPair("maxIdleConns", this._defaultNumber(runtime.maxIdleConns, _maxIdleConns)),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", this._defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", this._default(runtime.backoffPolicy, "no")),
                new TeaPair("period", this._defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL),
            new TeaPair("logger", _logger),
            new TeaPair("listener", runtime.listener)
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
                String token = this._getSecurityToken();
                request_.protocol = _protocol;
                request_.method = "PUT";
                request_.pathname = "/" + request.objectName + "";
                request_.headers = TeaConverter.merge(String.class, 
                    TeaConverter.buildMap(
                        new TeaPair("host", this.getHost(request.bucketName)),
                        new TeaPair("date", this._getDate()),
                        new TeaPair("user-agent", this._getUserAgent())
                    ),
                    this._toHeader(TeaModel.buildMap(request.header)),
                    this._parseMeta(request.userMeta, "x-oss-meta-")
                );
                if (!this._empty(token)) {
                    request_.headers.put("x-oss-security-token", token);
                }

                request_.body = this._inject(request.body, ctx);
                if (this._notNull(TeaModel.buildMap(request.header)) && !this._empty(request.header.contentType)) {
                    request_.headers.put("content-type", request.header.contentType);
                } else {
                    request_.headers.put("content-type", this._getContentType(request.objectName));
                }

                request_.headers.put("authorization", this.getSignature(request_, request.bucketName));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                String bodyStr = null;
                if (this._isFail(response_)) {
                    bodyStr = this._readAsString(response_);
                    respMap = this._getErrMessage(bodyStr);
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

                if (_isEnableCrc && !this._equal(ctx.get("crc"), response_.headers.get("x-oss-hash-crc64ecma"))) {
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("code", "CrcNotMatched"),
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("clientCrc", ctx.get("crc")),
                            new TeaPair("serverCrc", response_.headers.get("x-oss-hash-crc64ecma"))
                        ))
                    ));
                }

                if (_isEnableMD5 && !this._equal(ctx.get("md5"), response_.headers.get("content-md5"))) {
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("code", "MD5NotMatched"),
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("clientMD5", ctx.get("md5")),
                            new TeaPair("serverMD5", response_.headers.get("content-md5"))
                        ))
                    ));
                }

                return TeaModel.toModel(TeaConverter.merge(Object.class, 
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

    public String getHost(String bucketName) throws Exception {
        if (this._empty(_regionId)) {
            this._regionId = "cn-hangzhou";
        }

        if (this._empty(_endpoint)) {
            this._endpoint = "oss-" + _regionId + ".aliyuncs.com";
        }

        if (this._empty(bucketName)) {
            return _endpoint;
        }

        String host = null;
        if (this._equal(_hostModel, "ip")) {
            host = "" + _endpoint + "/" + bucketName + "";
        } else if (this._equal(_hostModel, "cname")) {
            host = _endpoint;
        } else {
            host = "" + bucketName + "." + _endpoint + "";
        }

        return host;
    }

    public String getSignature(TeaRequest  request, String bucketName) throws Exception {
        String accessKeyId = this._getAccessKeyID();
        String accessKeySecret = this._getAccessKeySecret();
        if (this._equal(_signatureVersion, "V2")) {
            if (this._ifListEmpty(_addtionalHeaders)) {
                return "OSS2 AccessKeyId:" + accessKeyId + ",Signature:" + this._getSignatureV2(request, bucketName, accessKeySecret, _addtionalHeaders) + "";
            } else {
                return "OSS2 AccessKeyId:" + accessKeyId + ",AdditionalHeaders:" + this._listToString(_addtionalHeaders, ";") + ",Signature:" + this._getSignatureV2(request, bucketName, accessKeySecret, _addtionalHeaders) + "";
            }

        } else {
            return "OSS " + accessKeyId + ":" + this._getSignatureV1(request, bucketName, accessKeySecret) + "";
        }

    }
}
