// This file is auto-generated, don't edit it. Thanks.
package com.oss;

import com.aliyun.tea.*;
import com.oss.models.*;
import com.oss.baseclient.BaseClient;

public class Client extends BaseClient {

    public Client(Config config) throws Exception {
        super(config.toMap());
    }

    public DeleteLiveChannelResponse DeleteLiveChannel(DeleteLiveChannelRequest request, RuntimeObject runtime) throws Exception {
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
                request_.protocol = _protocol;
                request_.method = "DELETE";
                request_.pathname = "/" + request.channelName + "?live";
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("host", this._getHost(request.bucketName)),
                    new TeaPair("date", this._getDate()),
                    new TeaPair("user-agent", this._getUserAgent())
                );
                request_.headers.put("authorization", this._getAuth(request_, request.bucketName));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                if (this._isFail(response_)) {
                    respMap = this._getErrMessage(response_);
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

    public GetBucketLocationResponse GetBucketLocation(GetBucketLocationRequest request, RuntimeObject runtime) throws Exception {
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
                request_.protocol = _protocol;
                request_.method = "GET";
                request_.pathname = "/?location";
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("host", this._getHost(request.bucketName)),
                    new TeaPair("date", this._getDate()),
                    new TeaPair("user-agent", this._getUserAgent())
                );
                request_.headers.put("authorization", this._getAuth(request_, request.bucketName));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                if (this._isFail(response_)) {
                    respMap = this._getErrMessage(response_);
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

                respMap = this._parseXml(response_, GetBucketLocationResponse.class);
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

    public ListLiveChannelResponse ListLiveChannel(ListLiveChannelRequest request, RuntimeObject runtime) throws Exception {
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
                request_.protocol = _protocol;
                request_.method = "GET";
                request_.pathname = "/?live";
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("host", this._getHost(request.bucketName)),
                    new TeaPair("date", this._getDate()),
                    new TeaPair("user-agent", this._getUserAgent())
                );
                request_.query = this._toQuery(TeaModel.buildMap(request.filter));
                request_.headers.put("authorization", this._getAuth(request_, request.bucketName));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                if (this._isFail(response_)) {
                    respMap = this._getErrMessage(response_);
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

                respMap = this._parseXml(response_, ListLiveChannelResponse.class);
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

    public GetObjectMetaResponse GetObjectMeta(GetObjectMetaRequest request, RuntimeObject runtime) throws Exception {
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
                request_.protocol = _protocol;
                request_.method = "HEAD";
                request_.pathname = "/" + request.objectName + "?objectMeta";
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("host", this._getHost(request.bucketName)),
                    new TeaPair("date", this._getDate()),
                    new TeaPair("user-agent", this._getUserAgent())
                );
                request_.headers.put("authorization", this._getAuth(request_, request.bucketName));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                if (this._isFail(response_)) {
                    respMap = this._getErrMessage(response_);
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

    public GetBucketAclResponse GetBucketAcl(GetBucketAclRequest request, RuntimeObject runtime) throws Exception {
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
                request_.protocol = _protocol;
                request_.method = "GET";
                request_.pathname = "/?acl";
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("host", this._getHost(request.bucketName)),
                    new TeaPair("date", this._getDate()),
                    new TeaPair("user-agent", this._getUserAgent())
                );
                request_.headers.put("authorization", this._getAuth(request_, request.bucketName));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                if (this._isFail(response_)) {
                    respMap = this._getErrMessage(response_);
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

                respMap = this._parseXml(response_, GetBucketAclResponse.class);
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

    public ListPartsResponse ListParts(ListPartsRequest request, RuntimeObject runtime) throws Exception {
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
                request_.protocol = _protocol;
                request_.method = "GET";
                request_.pathname = "/" + request.objectName + "";
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("host", this._getHost(request.bucketName)),
                    new TeaPair("date", this._getDate()),
                    new TeaPair("user-agent", this._getUserAgent())
                );
                request_.query = this._toQuery(TeaModel.buildMap(request.filter));
                request_.headers.put("authorization", this._getAuth(request_, request.bucketName));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                if (this._isFail(response_)) {
                    respMap = this._getErrMessage(response_);
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

                respMap = this._parseXml(response_, ListPartsResponse.class);
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

    public GetLiveChannelHistoryResponse GetLiveChannelHistory(GetLiveChannelHistoryRequest request, RuntimeObject runtime) throws Exception {
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
                request_.protocol = _protocol;
                request_.method = "GET";
                request_.pathname = "/" + request.channelName + "?live";
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("host", this._getHost(request.bucketName)),
                    new TeaPair("date", this._getDate()),
                    new TeaPair("user-agent", this._getUserAgent())
                );
                request_.query = this._toQuery(TeaModel.buildMap(request.filter));
                request_.headers.put("authorization", this._getAuth(request_, request.bucketName));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                if (this._isFail(response_)) {
                    respMap = this._getErrMessage(response_);
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

                respMap = this._parseXml(response_, GetLiveChannelHistoryResponse.class);
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

    public GetBucketResponse GetBucket(GetBucketRequest request, RuntimeObject runtime) throws Exception {
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
                request_.protocol = _protocol;
                request_.method = "GET";
                request_.pathname = "/";
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("host", this._getHost(request.bucketName)),
                    new TeaPair("date", this._getDate()),
                    new TeaPair("user-agent", this._getUserAgent())
                );
                request_.query = this._toQuery(TeaModel.buildMap(request.filter));
                request_.headers.put("authorization", this._getAuth(request_, request.bucketName));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                if (this._isFail(response_)) {
                    respMap = this._getErrMessage(response_);
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

                respMap = this._parseXml(response_, GetBucketResponse.class);
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

    public GetLiveChannelInfoResponse GetLiveChannelInfo(GetLiveChannelInfoRequest request, RuntimeObject runtime) throws Exception {
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
                request_.protocol = _protocol;
                request_.method = "GET";
                request_.pathname = "/" + request.channelName + "?live";
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("host", this._getHost(request.bucketName)),
                    new TeaPair("date", this._getDate()),
                    new TeaPair("user-agent", this._getUserAgent())
                );
                request_.headers.put("authorization", this._getAuth(request_, request.bucketName));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                if (this._isFail(response_)) {
                    respMap = this._getErrMessage(response_);
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

                respMap = this._parseXml(response_, GetLiveChannelInfoResponse.class);
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

    public GetLiveChannelStatResponse GetLiveChannelStat(GetLiveChannelStatRequest request, RuntimeObject runtime) throws Exception {
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
                request_.protocol = _protocol;
                request_.method = "GET";
                request_.pathname = "/" + request.channelName + "?live";
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("host", this._getHost(request.bucketName)),
                    new TeaPair("date", this._getDate()),
                    new TeaPair("user-agent", this._getUserAgent())
                );
                request_.query = this._toQuery(TeaModel.buildMap(request.filter));
                request_.headers.put("authorization", this._getAuth(request_, request.bucketName));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                if (this._isFail(response_)) {
                    respMap = this._getErrMessage(response_);
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

                respMap = this._parseXml(response_, GetLiveChannelStatResponse.class);
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

    public DeleteObjectResponse DeleteObject(DeleteObjectRequest request, RuntimeObject runtime) throws Exception {
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
                request_.protocol = _protocol;
                request_.method = "DELETE";
                request_.pathname = "/" + request.objectName + "";
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("host", this._getHost(request.bucketName)),
                    new TeaPair("date", this._getDate()),
                    new TeaPair("user-agent", this._getUserAgent())
                );
                request_.headers.put("authorization", this._getAuth(request_, request.bucketName));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                if (this._isFail(response_)) {
                    respMap = this._getErrMessage(response_);
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

    public AbortMultipartUploadResponse AbortMultipartUpload(AbortMultipartUploadRequest request, RuntimeObject runtime) throws Exception {
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
                request_.protocol = _protocol;
                request_.method = "DELETE";
                request_.pathname = "/" + request.objectName + "";
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("host", this._getHost(request.bucketName)),
                    new TeaPair("date", this._getDate()),
                    new TeaPair("user-agent", this._getUserAgent())
                );
                request_.query = this._toQuery(TeaModel.buildMap(request.filter));
                request_.headers.put("authorization", this._getAuth(request_, request.bucketName));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                if (this._isFail(response_)) {
                    respMap = this._getErrMessage(response_);
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

    public AppendObjectResponse AppendObject(AppendObjectRequest request, RuntimeObject runtime) throws Exception {
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
                request_.protocol = _protocol;
                request_.method = "POST";
                request_.pathname = "/" + request.objectName + "?append";
                request_.headers = TeaConverter.merge(String.class, 
                    TeaConverter.buildMap(
                        new TeaPair("host", this._getHost(request.bucketName)),
                        new TeaPair("date", this._getDate()),
                        new TeaPair("user-agent", this._getUserAgent())
                    ),
                    this._toHeader(TeaModel.buildMap(request.header)),
                    this._parseMeta(request.userMeta, "x-oss-meta-")
                );
                request_.query = this._toQuery(TeaModel.buildMap(request.filter));
                request_.body = request.body;
                request_.headers.put("content-type", this._default(this._getSpecialValue(TeaModel.buildMap(request.header), "content-type"), this._getContentType(request.objectName)));
                request_.headers.put("authorization", this._getAuth(request_, request.bucketName));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                if (this._isFail(response_)) {
                    respMap = this._getErrMessage(response_);
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

    public UploadPartCopyResponse UploadPartCopy(UploadPartCopyRequest request, RuntimeObject runtime) throws Exception {
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
                request_.protocol = _protocol;
                request_.method = "PUT";
                request_.pathname = "/" + request.objectName + "";
                request_.headers = TeaConverter.merge(String.class, 
                    TeaConverter.buildMap(
                        new TeaPair("host", this._getHost(request.bucketName)),
                        new TeaPair("date", this._getDate()),
                        new TeaPair("user-agent", this._getUserAgent())
                    ),
                    this._toHeader(TeaModel.buildMap(request.header))
                );
                request_.query = this._toQuery(TeaModel.buildMap(request.filter));
                request_.headers.put("authorization", this._getAuth(request_, request.bucketName));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                if (this._isFail(response_)) {
                    respMap = this._getErrMessage(response_);
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

                respMap = this._parseXml(response_, UploadPartCopyResponse.class);
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

    public GetVodPlaylistResponse GetVodPlaylist(GetVodPlaylistRequest request, RuntimeObject runtime) throws Exception {
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
                request_.protocol = _protocol;
                request_.method = "GET";
                request_.pathname = "/" + request.channelName + "?vod";
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("host", this._getHost(request.bucketName)),
                    new TeaPair("date", this._getDate()),
                    new TeaPair("user-agent", this._getUserAgent())
                );
                request_.query = this._toQuery(TeaModel.buildMap(request.filter));
                request_.headers.put("authorization", this._getAuth(request_, request.bucketName));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                if (this._isFail(response_)) {
                    respMap = this._getErrMessage(response_);
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

    public DeleteBucketCORSResponse DeleteBucketCORS(DeleteBucketCORSRequest request, RuntimeObject runtime) throws Exception {
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
                request_.protocol = _protocol;
                request_.method = "DELETE";
                request_.pathname = "/?cors";
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("host", this._getHost(request.bucketName)),
                    new TeaPair("date", this._getDate()),
                    new TeaPair("user-agent", this._getUserAgent())
                );
                request_.headers.put("authorization", this._getAuth(request_, request.bucketName));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                if (this._isFail(response_)) {
                    respMap = this._getErrMessage(response_);
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

    public GetObjectResponse GetObject(GetObjectRequest request, RuntimeObject runtime) throws Exception {
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
                request_.protocol = _protocol;
                request_.method = "GET";
                request_.pathname = "/" + request.objectName + "";
                request_.headers = TeaConverter.merge(String.class, 
                    TeaConverter.buildMap(
                        new TeaPair("host", this._getHost(request.bucketName)),
                        new TeaPair("date", this._getDate()),
                        new TeaPair("user-agent", this._getUserAgent())
                    ),
                    this._toHeader(TeaModel.buildMap(request.header))
                );
                request_.headers.put("authorization", this._getAuth(request_, request.bucketName));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                if (this._isFail(response_)) {
                    respMap = this._getErrMessage(response_);
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

    public UploadPartResponse UploadPart(UploadPartRequest request, RuntimeObject runtime) throws Exception {
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
                request_.protocol = _protocol;
                request_.method = "PUT";
                request_.pathname = "/" + request.objectName + "";
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("host", this._getHost(request.bucketName)),
                    new TeaPair("date", this._getDate()),
                    new TeaPair("user-agent", this._getUserAgent())
                );
                request_.query = this._toQuery(TeaModel.buildMap(request.filter));
                request_.body = request.body;
                request_.headers.put("authorization", this._getAuth(request_, request.bucketName));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                if (this._isFail(response_)) {
                    respMap = this._getErrMessage(response_);
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

    public GetBucketCORSResponse GetBucketCORS(GetBucketCORSRequest request, RuntimeObject runtime) throws Exception {
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
                request_.protocol = _protocol;
                request_.method = "GET";
                request_.pathname = "/?cors";
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("host", this._getHost(request.bucketName)),
                    new TeaPair("date", this._getDate()),
                    new TeaPair("user-agent", this._getUserAgent())
                );
                request_.headers.put("authorization", this._getAuth(request_, request.bucketName));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                if (this._isFail(response_)) {
                    respMap = this._getErrMessage(response_);
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

                respMap = this._parseXml(response_, GetBucketCORSResponse.class);
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

    public CopyObjectResponse CopyObject(CopyObjectRequest request, RuntimeObject runtime) throws Exception {
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
                request_.protocol = _protocol;
                request_.method = "PUT";
                request_.pathname = "/" + request.destObjectName + "";
                request_.headers = TeaConverter.merge(String.class, 
                    TeaConverter.buildMap(
                        new TeaPair("host", this._getHost(request.bucketName)),
                        new TeaPair("date", this._getDate()),
                        new TeaPair("user-agent", this._getUserAgent())
                    ),
                    this._toHeader(TeaModel.buildMap(request.header))
                );
                request_.headers.put("x-oss-copy-source", this._encode(request_.headers.get("x-oss-copy-source"), "UrlEncode"));
                request_.headers.put("authorization", this._getAuth(request_, request.bucketName));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                if (this._isFail(response_)) {
                    respMap = this._getErrMessage(response_);
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

                respMap = this._parseXml(response_, CopyObjectResponse.class);
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

    public GetObjectTaggingResponse GetObjectTagging(GetObjectTaggingRequest request, RuntimeObject runtime) throws Exception {
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
                request_.protocol = _protocol;
                request_.method = "GET";
                request_.pathname = "/" + request.objectName + "?tagging";
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("host", this._getHost(request.bucketName)),
                    new TeaPair("date", this._getDate()),
                    new TeaPair("user-agent", this._getUserAgent())
                );
                request_.headers.put("authorization", this._getAuth(request_, request.bucketName));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                if (this._isFail(response_)) {
                    respMap = this._getErrMessage(response_);
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

                respMap = this._parseXml(response_, GetObjectTaggingResponse.class);
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

    public DeleteBucketLifecycleResponse DeleteBucketLifecycle(DeleteBucketLifecycleRequest request, RuntimeObject runtime) throws Exception {
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
                request_.protocol = _protocol;
                request_.method = "DELETE";
                request_.pathname = "/?lifecycle";
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("host", this._getHost(request.bucketName)),
                    new TeaPair("date", this._getDate()),
                    new TeaPair("user-agent", this._getUserAgent())
                );
                request_.headers.put("authorization", this._getAuth(request_, request.bucketName));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                if (this._isFail(response_)) {
                    respMap = this._getErrMessage(response_);
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

    public DeleteBucketLoggingResponse DeleteBucketLogging(DeleteBucketLoggingRequest request, RuntimeObject runtime) throws Exception {
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
                request_.protocol = _protocol;
                request_.method = "DELETE";
                request_.pathname = "/?logging";
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("host", this._getHost(request.bucketName)),
                    new TeaPair("date", this._getDate()),
                    new TeaPair("user-agent", this._getUserAgent())
                );
                request_.headers.put("authorization", this._getAuth(request_, request.bucketName));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                if (this._isFail(response_)) {
                    respMap = this._getErrMessage(response_);
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

    public DeleteBucketWebsiteResponse DeleteBucketWebsite(DeleteBucketWebsiteRequest request, RuntimeObject runtime) throws Exception {
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
                request_.protocol = _protocol;
                request_.method = "DELETE";
                request_.pathname = "/?website";
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("host", this._getHost(request.bucketName)),
                    new TeaPair("date", this._getDate()),
                    new TeaPair("user-agent", this._getUserAgent())
                );
                request_.headers.put("authorization", this._getAuth(request_, request.bucketName));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                if (this._isFail(response_)) {
                    respMap = this._getErrMessage(response_);
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

    public GetSymlinkResponse GetSymlink(GetSymlinkRequest request, RuntimeObject runtime) throws Exception {
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
                request_.protocol = _protocol;
                request_.method = "GET";
                request_.pathname = "/" + request.objectName + "?symlink";
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("host", this._getHost(request.bucketName)),
                    new TeaPair("date", this._getDate()),
                    new TeaPair("user-agent", this._getUserAgent())
                );
                request_.headers.put("authorization", this._getAuth(request_, request.bucketName));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                if (this._isFail(response_)) {
                    respMap = this._getErrMessage(response_);
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

    public GetBucketLifecycleResponse GetBucketLifecycle(GetBucketLifecycleRequest request, RuntimeObject runtime) throws Exception {
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
                request_.protocol = _protocol;
                request_.method = "GET";
                request_.pathname = "/?lifecycle";
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("host", this._getHost(request.bucketName)),
                    new TeaPair("date", this._getDate()),
                    new TeaPair("user-agent", this._getUserAgent())
                );
                request_.headers.put("authorization", this._getAuth(request_, request.bucketName));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                if (this._isFail(response_)) {
                    respMap = this._getErrMessage(response_);
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

                respMap = this._parseXml(response_, GetBucketLifecycleResponse.class);
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

    public PutSymlinkResponse PutSymlink(PutSymlinkRequest request, RuntimeObject runtime) throws Exception {
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
                request_.protocol = _protocol;
                request_.method = "PUT";
                request_.pathname = "/" + request.objectName + "?symlink";
                request_.headers = TeaConverter.merge(String.class, 
                    TeaConverter.buildMap(
                        new TeaPair("host", this._getHost(request.bucketName)),
                        new TeaPair("date", this._getDate()),
                        new TeaPair("user-agent", this._getUserAgent())
                    ),
                    this._toHeader(TeaModel.buildMap(request.header))
                );
                request_.headers.put("authorization", this._getAuth(request_, request.bucketName));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                if (this._isFail(response_)) {
                    respMap = this._getErrMessage(response_);
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

    public GetBucketRefererResponse GetBucketReferer(GetBucketRefererRequest request, RuntimeObject runtime) throws Exception {
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
                request_.protocol = _protocol;
                request_.method = "GET";
                request_.pathname = "/?referer";
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("host", this._getHost(request.bucketName)),
                    new TeaPair("date", this._getDate()),
                    new TeaPair("user-agent", this._getUserAgent())
                );
                request_.headers.put("authorization", this._getAuth(request_, request.bucketName));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                if (this._isFail(response_)) {
                    respMap = this._getErrMessage(response_);
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

                respMap = this._parseXml(response_, GetBucketRefererResponse.class);
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

    public CallbackResponse Callback(CallbackRequest request, RuntimeObject runtime) throws Exception {
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
                request_.protocol = _protocol;
                request_.method = "GET";
                request_.pathname = "/";
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("host", this._getHost(request.bucketName)),
                    new TeaPair("date", this._getDate()),
                    new TeaPair("user-agent", this._getUserAgent())
                );
                request_.headers.put("authorization", this._getAuth(request_, request.bucketName));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                if (this._isFail(response_)) {
                    respMap = this._getErrMessage(response_);
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

    public GetBucketLoggingResponse GetBucketLogging(GetBucketLoggingRequest request, RuntimeObject runtime) throws Exception {
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
                request_.protocol = _protocol;
                request_.method = "GET";
                request_.pathname = "/?logging";
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("host", this._getHost(request.bucketName)),
                    new TeaPair("date", this._getDate()),
                    new TeaPair("user-agent", this._getUserAgent())
                );
                request_.headers.put("authorization", this._getAuth(request_, request.bucketName));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                if (this._isFail(response_)) {
                    respMap = this._getErrMessage(response_);
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

                respMap = this._parseXml(response_, GetBucketLoggingResponse.class);
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

    public PutObjectAclResponse PutObjectAcl(PutObjectAclRequest request, RuntimeObject runtime) throws Exception {
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
                request_.protocol = _protocol;
                request_.method = "PUT";
                request_.pathname = "/" + request.objectName + "?acl";
                request_.headers = TeaConverter.merge(String.class, 
                    TeaConverter.buildMap(
                        new TeaPair("host", this._getHost(request.bucketName)),
                        new TeaPair("date", this._getDate()),
                        new TeaPair("user-agent", this._getUserAgent())
                    ),
                    this._toHeader(TeaModel.buildMap(request.header))
                );
                request_.headers.put("authorization", this._getAuth(request_, request.bucketName));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                if (this._isFail(response_)) {
                    respMap = this._getErrMessage(response_);
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

    public GetBucketInfoResponse GetBucketInfo(GetBucketInfoRequest request, RuntimeObject runtime) throws Exception {
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
                request_.protocol = _protocol;
                request_.method = "GET";
                request_.pathname = "/?bucketInfo";
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("host", this._getHost(request.bucketName)),
                    new TeaPair("date", this._getDate()),
                    new TeaPair("user-agent", this._getUserAgent())
                );
                request_.headers.put("authorization", this._getAuth(request_, request.bucketName));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                if (this._isFail(response_)) {
                    respMap = this._getErrMessage(response_);
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

                respMap = this._parseXml(response_, GetBucketInfoResponse.class);
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

    public PutLiveChannelStatusResponse PutLiveChannelStatus(PutLiveChannelStatusRequest request, RuntimeObject runtime) throws Exception {
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
                request_.protocol = _protocol;
                request_.method = "PUT";
                request_.pathname = "/" + request.channelName + "?live";
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("host", this._getHost(request.bucketName)),
                    new TeaPair("date", this._getDate()),
                    new TeaPair("user-agent", this._getUserAgent())
                );
                request_.query = this._toQuery(TeaModel.buildMap(request.filter));
                request_.headers.put("authorization", this._getAuth(request_, request.bucketName));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                if (this._isFail(response_)) {
                    respMap = this._getErrMessage(response_);
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

    public InitiateMultipartUploadResponse InitiateMultipartUpload(InitiateMultipartUploadRequest request, RuntimeObject runtime) throws Exception {
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
                request_.protocol = _protocol;
                request_.method = "POST";
                request_.pathname = "/" + request.objectName + "?uploads";
                request_.headers = TeaConverter.merge(String.class, 
                    TeaConverter.buildMap(
                        new TeaPair("host", this._getHost(request.bucketName)),
                        new TeaPair("date", this._getDate()),
                        new TeaPair("user-agent", this._getUserAgent())
                    ),
                    this._toHeader(TeaModel.buildMap(request.header))
                );
                request_.query = this._toQuery(TeaModel.buildMap(request.filter));
                request_.headers.put("content-type", this._default(this._getSpecialValue(TeaModel.buildMap(request.header), "content-type"), this._getContentType(request.objectName)));
                request_.headers.put("authorization", this._getAuth(request_, request.bucketName));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                if (this._isFail(response_)) {
                    respMap = this._getErrMessage(response_);
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

                respMap = this._parseXml(response_, InitiateMultipartUploadResponse.class);
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

    public OptionObjectResponse OptionObject(OptionObjectRequest request, RuntimeObject runtime) throws Exception {
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
                request_.protocol = _protocol;
                request_.method = "OPTIONS";
                request_.pathname = "/" + request.objectName + "";
                request_.headers = TeaConverter.merge(String.class, 
                    TeaConverter.buildMap(
                        new TeaPair("host", this._getHost(request.bucketName)),
                        new TeaPair("date", this._getDate()),
                        new TeaPair("user-agent", this._getUserAgent())
                    ),
                    this._toHeader(TeaModel.buildMap(request.header))
                );
                request_.headers.put("authorization", this._getAuth(request_, request.bucketName));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                if (this._isFail(response_)) {
                    respMap = this._getErrMessage(response_);
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

    public PostVodPlaylistResponse PostVodPlaylist(PostVodPlaylistRequest request, RuntimeObject runtime) throws Exception {
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
                request_.protocol = _protocol;
                request_.method = "POST";
                request_.pathname = "/" + request.channelName + "/" + request.playlistName + "?vod";
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("host", this._getHost(request.bucketName)),
                    new TeaPair("date", this._getDate()),
                    new TeaPair("user-agent", this._getUserAgent())
                );
                request_.query = this._toQuery(TeaModel.buildMap(request.filter));
                request_.headers.put("authorization", this._getAuth(request_, request.bucketName));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                if (this._isFail(response_)) {
                    respMap = this._getErrMessage(response_);
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

    public PostObjectResponse PostObject(PostObjectRequest request, RuntimeObject runtime) throws Exception {
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
                request_.protocol = _protocol;
                request_.method = "POST";
                request_.pathname = "/";
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("host", this._getHost(request.bucketName)),
                    new TeaPair("date", this._getDate()),
                    new TeaPair("user-agent", this._getUserAgent())
                );
                request_.headers.put("authorization", this._getAuth(request_, request.bucketName));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                if (this._isFail(response_)) {
                    respMap = this._getErrMessage(response_);
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

    public HeadObjectResponse HeadObject(HeadObjectRequest request, RuntimeObject runtime) throws Exception {
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
                request_.protocol = _protocol;
                request_.method = "HEAD";
                request_.pathname = "/" + request.objectName + "";
                request_.headers = TeaConverter.merge(String.class, 
                    TeaConverter.buildMap(
                        new TeaPair("host", this._getHost(request.bucketName)),
                        new TeaPair("date", this._getDate()),
                        new TeaPair("user-agent", this._getUserAgent())
                    ),
                    this._toHeader(TeaModel.buildMap(request.header))
                );
                request_.headers.put("authorization", this._getAuth(request_, request.bucketName));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                if (this._isFail(response_)) {
                    respMap = this._getErrMessage(response_);
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

    public DeleteObjectTaggingResponse DeleteObjectTagging(DeleteObjectTaggingRequest request, RuntimeObject runtime) throws Exception {
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
                request_.protocol = _protocol;
                request_.method = "DELETE";
                request_.pathname = "/" + request.objectName + "?tagging";
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("host", this._getHost(request.bucketName)),
                    new TeaPair("date", this._getDate()),
                    new TeaPair("user-agent", this._getUserAgent())
                );
                request_.headers.put("authorization", this._getAuth(request_, request.bucketName));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                if (this._isFail(response_)) {
                    respMap = this._getErrMessage(response_);
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

    public RestoreObjectResponse RestoreObject(RestoreObjectRequest request, RuntimeObject runtime) throws Exception {
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
                request_.protocol = _protocol;
                request_.method = "POST";
                request_.pathname = "/" + request.objectName + "?restore";
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("host", this._getHost(request.bucketName)),
                    new TeaPair("date", this._getDate()),
                    new TeaPair("user-agent", this._getUserAgent())
                );
                request_.headers.put("authorization", this._getAuth(request_, request.bucketName));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                if (this._isFail(response_)) {
                    respMap = this._getErrMessage(response_);
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

    public GetObjectAclResponse GetObjectAcl(GetObjectAclRequest request, RuntimeObject runtime) throws Exception {
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
                request_.protocol = _protocol;
                request_.method = "GET";
                request_.pathname = "/" + request.objectName + "?acl";
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("host", this._getHost(request.bucketName)),
                    new TeaPair("date", this._getDate()),
                    new TeaPair("user-agent", this._getUserAgent())
                );
                request_.headers.put("authorization", this._getAuth(request_, request.bucketName));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                if (this._isFail(response_)) {
                    respMap = this._getErrMessage(response_);
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

                respMap = this._parseXml(response_, GetObjectAclResponse.class);
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

    public PutBucketAclResponse PutBucketAcl(PutBucketAclRequest request, RuntimeObject runtime) throws Exception {
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
                request_.protocol = _protocol;
                request_.method = "PUT";
                request_.pathname = "/?acl";
                request_.headers = TeaConverter.merge(String.class, 
                    TeaConverter.buildMap(
                        new TeaPair("host", this._getHost(request.bucketName)),
                        new TeaPair("date", this._getDate()),
                        new TeaPair("user-agent", this._getUserAgent())
                    ),
                    this._toHeader(TeaModel.buildMap(request.header))
                );
                request_.headers.put("authorization", this._getAuth(request_, request.bucketName));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                if (this._isFail(response_)) {
                    respMap = this._getErrMessage(response_);
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

    public DeleteBucketResponse DeleteBucket(DeleteBucketRequest request, RuntimeObject runtime) throws Exception {
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
                request_.protocol = _protocol;
                request_.method = "DELETE";
                request_.pathname = "/";
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("host", this._getHost(request.bucketName)),
                    new TeaPair("date", this._getDate()),
                    new TeaPair("user-agent", this._getUserAgent())
                );
                request_.headers.put("authorization", this._getAuth(request_, request.bucketName));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                if (this._isFail(response_)) {
                    respMap = this._getErrMessage(response_);
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

    public PutObjectResponse PutObject(PutObjectRequest request, RuntimeObject runtime) throws Exception {
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
                request_.protocol = _protocol;
                request_.method = "PUT";
                request_.pathname = "/" + request.objectName + "";
                request_.headers = TeaConverter.merge(String.class, 
                    TeaConverter.buildMap(
                        new TeaPair("host", this._getHost(request.bucketName)),
                        new TeaPair("date", this._getDate()),
                        new TeaPair("user-agent", this._getUserAgent())
                    ),
                    this._toHeader(TeaModel.buildMap(request.header)),
                    this._parseMeta(request.userMeta, "x-oss-meta-")
                );
                request_.body = request.body;
                request_.headers.put("content-type", this._default(this._getSpecialValue(TeaModel.buildMap(request.header), "content-type"), this._getContentType(request.objectName)));
                request_.headers.put("authorization", this._getAuth(request_, request.bucketName));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                if (this._isFail(response_)) {
                    respMap = this._getErrMessage(response_);
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
}

