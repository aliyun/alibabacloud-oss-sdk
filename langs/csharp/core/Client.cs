// This file is auto-generated, don't edit it. Thanks.
using System;
using System.Collections.Generic;

using Tea;

using AlibabaCloud.OSS.Models;

namespace AlibabaCloud.OSS
{
    public class Client : BaseClient
    {

        public Client(Config config): base(config.ToMap())
        { }

        public DeleteLiveChannelResponse DeleteLiveChannel(DeleteLiveChannelRequest request, RuntimeObject runtime) {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>(){
                {"timeouted", "retry"},
                {"readTimeout", this._defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", this._defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", this._default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", this._default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", this._default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", this._default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", this._default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", this._default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", this._defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>(){
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", this._defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", this._default(runtime.BackoffPolicy, "no")},
                    {"period", this._defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((Dictionary<string, object>) runtime_["retry"], _retryTimes, _now)) {
                if (_retryTimes > 0) {
                    int backoffTime = TeaCore.GetBackoffTime((Dictionary<string, object>)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0) {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try {
                    TeaRequest request_ = new TeaRequest();
                    request_.Protocol = _protocol;
                    request_.Method = "DELETE";
                    request_.Pathname = "/" + request.ChannelName + "?live";
                    request_.Headers = new Dictionary<string, string>(){
                        {"host", this._getHost(request.BucketName)},
                        {"date", this._getDate()},
                        {"user-agent", this._getUserAgent()},
                    };
                    request_.Headers["authorization"] = this._getAuth(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    if (this._isFail(response_)) {
                        respMap = this._getErrMessage(response_);
                        throw new TeaException(new Dictionary<string, object>(){
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>(){
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    return TeaModel.ToObject<DeleteLiveChannelResponse>(TeaConverter.merge<object>(
                        response_.Headers
                    ));
                } catch (Exception e) {
                    if (TeaCore.IsRetryable(e)) {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public GetBucketLocationResponse GetBucketLocation(GetBucketLocationRequest request, RuntimeObject runtime) {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>(){
                {"timeouted", "retry"},
                {"readTimeout", this._defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", this._defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", this._default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", this._default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", this._default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", this._default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", this._default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", this._default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", this._defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>(){
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", this._defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", this._default(runtime.BackoffPolicy, "no")},
                    {"period", this._defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((Dictionary<string, object>) runtime_["retry"], _retryTimes, _now)) {
                if (_retryTimes > 0) {
                    int backoffTime = TeaCore.GetBackoffTime((Dictionary<string, object>)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0) {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try {
                    TeaRequest request_ = new TeaRequest();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/?location";
                    request_.Headers = new Dictionary<string, string>(){
                        {"host", this._getHost(request.BucketName)},
                        {"date", this._getDate()},
                        {"user-agent", this._getUserAgent()},
                    };
                    request_.Headers["authorization"] = this._getAuth(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    if (this._isFail(response_)) {
                        respMap = this._getErrMessage(response_);
                        throw new TeaException(new Dictionary<string, object>(){
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>(){
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    respMap = this._parseXml(response_, typeof(GetBucketLocationResponse));
                    return TeaModel.ToObject<GetBucketLocationResponse>(TeaConverter.merge<object>(
                        new Dictionary<string, object>(){
                            {"LocationConstraint", respMap["LocationConstraint"]},
                        },
                        response_.Headers
                    ));
                } catch (Exception e) {
                    if (TeaCore.IsRetryable(e)) {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public ListLiveChannelResponse ListLiveChannel(ListLiveChannelRequest request, RuntimeObject runtime) {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>(){
                {"timeouted", "retry"},
                {"readTimeout", this._defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", this._defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", this._default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", this._default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", this._default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", this._default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", this._default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", this._default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", this._defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>(){
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", this._defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", this._default(runtime.BackoffPolicy, "no")},
                    {"period", this._defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((Dictionary<string, object>) runtime_["retry"], _retryTimes, _now)) {
                if (_retryTimes > 0) {
                    int backoffTime = TeaCore.GetBackoffTime((Dictionary<string, object>)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0) {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try {
                    TeaRequest request_ = new TeaRequest();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/?live";
                    request_.Headers = new Dictionary<string, string>(){
                        {"host", this._getHost(request.BucketName)},
                        {"date", this._getDate()},
                        {"user-agent", this._getUserAgent()},
                    };
                    request_.Query = this._toQuery(TeaModel.BuildMap(request.Filter));
                    request_.Headers["authorization"] = this._getAuth(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    if (this._isFail(response_)) {
                        respMap = this._getErrMessage(response_);
                        throw new TeaException(new Dictionary<string, object>(){
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>(){
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    respMap = this._parseXml(response_, typeof(ListLiveChannelResponse));
                    return TeaModel.ToObject<ListLiveChannelResponse>(TeaConverter.merge<object>(
                        new Dictionary<string, object>(){
                            {"ListLiveChannelResult", respMap["ListLiveChannelResult"]},
                        },
                        response_.Headers
                    ));
                } catch (Exception e) {
                    if (TeaCore.IsRetryable(e)) {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public GetObjectMetaResponse GetObjectMeta(GetObjectMetaRequest request, RuntimeObject runtime) {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>(){
                {"timeouted", "retry"},
                {"readTimeout", this._defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", this._defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", this._default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", this._default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", this._default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", this._default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", this._default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", this._default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", this._defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>(){
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", this._defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", this._default(runtime.BackoffPolicy, "no")},
                    {"period", this._defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((Dictionary<string, object>) runtime_["retry"], _retryTimes, _now)) {
                if (_retryTimes > 0) {
                    int backoffTime = TeaCore.GetBackoffTime((Dictionary<string, object>)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0) {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try {
                    TeaRequest request_ = new TeaRequest();
                    request_.Protocol = _protocol;
                    request_.Method = "HEAD";
                    request_.Pathname = "/" + request.ObjectName + "?objectMeta";
                    request_.Headers = new Dictionary<string, string>(){
                        {"host", this._getHost(request.BucketName)},
                        {"date", this._getDate()},
                        {"user-agent", this._getUserAgent()},
                    };
                    request_.Headers["authorization"] = this._getAuth(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    if (this._isFail(response_)) {
                        respMap = this._getErrMessage(response_);
                        throw new TeaException(new Dictionary<string, object>(){
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>(){
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    return TeaModel.ToObject<GetObjectMetaResponse>(TeaConverter.merge<object>(
                        response_.Headers
                    ));
                } catch (Exception e) {
                    if (TeaCore.IsRetryable(e)) {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public GetBucketAclResponse GetBucketAcl(GetBucketAclRequest request, RuntimeObject runtime) {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>(){
                {"timeouted", "retry"},
                {"readTimeout", this._defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", this._defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", this._default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", this._default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", this._default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", this._default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", this._default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", this._default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", this._defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>(){
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", this._defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", this._default(runtime.BackoffPolicy, "no")},
                    {"period", this._defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((Dictionary<string, object>) runtime_["retry"], _retryTimes, _now)) {
                if (_retryTimes > 0) {
                    int backoffTime = TeaCore.GetBackoffTime((Dictionary<string, object>)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0) {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try {
                    TeaRequest request_ = new TeaRequest();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/?acl";
                    request_.Headers = new Dictionary<string, string>(){
                        {"host", this._getHost(request.BucketName)},
                        {"date", this._getDate()},
                        {"user-agent", this._getUserAgent()},
                    };
                    request_.Headers["authorization"] = this._getAuth(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    if (this._isFail(response_)) {
                        respMap = this._getErrMessage(response_);
                        throw new TeaException(new Dictionary<string, object>(){
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>(){
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    respMap = this._parseXml(response_, typeof(GetBucketAclResponse));
                    return TeaModel.ToObject<GetBucketAclResponse>(TeaConverter.merge<object>(
                        new Dictionary<string, object>(){
                            {"AccessControlPolicy", respMap["AccessControlPolicy"]},
                        },
                        response_.Headers
                    ));
                } catch (Exception e) {
                    if (TeaCore.IsRetryable(e)) {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public ListPartsResponse ListParts(ListPartsRequest request, RuntimeObject runtime) {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>(){
                {"timeouted", "retry"},
                {"readTimeout", this._defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", this._defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", this._default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", this._default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", this._default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", this._default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", this._default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", this._default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", this._defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>(){
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", this._defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", this._default(runtime.BackoffPolicy, "no")},
                    {"period", this._defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((Dictionary<string, object>) runtime_["retry"], _retryTimes, _now)) {
                if (_retryTimes > 0) {
                    int backoffTime = TeaCore.GetBackoffTime((Dictionary<string, object>)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0) {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try {
                    TeaRequest request_ = new TeaRequest();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/" + request.ObjectName;
                    request_.Headers = new Dictionary<string, string>(){
                        {"host", this._getHost(request.BucketName)},
                        {"date", this._getDate()},
                        {"user-agent", this._getUserAgent()},
                    };
                    request_.Query = this._toQuery(TeaModel.BuildMap(request.Filter));
                    request_.Headers["authorization"] = this._getAuth(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    if (this._isFail(response_)) {
                        respMap = this._getErrMessage(response_);
                        throw new TeaException(new Dictionary<string, object>(){
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>(){
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    respMap = this._parseXml(response_, typeof(ListPartsResponse));
                    return TeaModel.ToObject<ListPartsResponse>(TeaConverter.merge<object>(
                        new Dictionary<string, object>(){
                            {"ListPartsResult", respMap["ListPartsResult"]},
                        },
                        response_.Headers
                    ));
                } catch (Exception e) {
                    if (TeaCore.IsRetryable(e)) {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public GetLiveChannelHistoryResponse GetLiveChannelHistory(GetLiveChannelHistoryRequest request, RuntimeObject runtime) {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>(){
                {"timeouted", "retry"},
                {"readTimeout", this._defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", this._defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", this._default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", this._default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", this._default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", this._default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", this._default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", this._default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", this._defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>(){
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", this._defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", this._default(runtime.BackoffPolicy, "no")},
                    {"period", this._defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((Dictionary<string, object>) runtime_["retry"], _retryTimes, _now)) {
                if (_retryTimes > 0) {
                    int backoffTime = TeaCore.GetBackoffTime((Dictionary<string, object>)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0) {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try {
                    TeaRequest request_ = new TeaRequest();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/" + request.ChannelName + "?live";
                    request_.Headers = new Dictionary<string, string>(){
                        {"host", this._getHost(request.BucketName)},
                        {"date", this._getDate()},
                        {"user-agent", this._getUserAgent()},
                    };
                    request_.Query = this._toQuery(TeaModel.BuildMap(request.Filter));
                    request_.Headers["authorization"] = this._getAuth(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    if (this._isFail(response_)) {
                        respMap = this._getErrMessage(response_);
                        throw new TeaException(new Dictionary<string, object>(){
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>(){
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    respMap = this._parseXml(response_, typeof(GetLiveChannelHistoryResponse));
                    return TeaModel.ToObject<GetLiveChannelHistoryResponse>(TeaConverter.merge<object>(
                        new Dictionary<string, object>(){
                            {"LiveChannelHistory", respMap["LiveChannelHistory"]},
                        },
                        response_.Headers
                    ));
                } catch (Exception e) {
                    if (TeaCore.IsRetryable(e)) {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public GetBucketResponse GetBucket(GetBucketRequest request, RuntimeObject runtime) {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>(){
                {"timeouted", "retry"},
                {"readTimeout", this._defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", this._defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", this._default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", this._default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", this._default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", this._default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", this._default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", this._default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", this._defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>(){
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", this._defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", this._default(runtime.BackoffPolicy, "no")},
                    {"period", this._defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((Dictionary<string, object>) runtime_["retry"], _retryTimes, _now)) {
                if (_retryTimes > 0) {
                    int backoffTime = TeaCore.GetBackoffTime((Dictionary<string, object>)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0) {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try {
                    TeaRequest request_ = new TeaRequest();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/";
                    request_.Headers = new Dictionary<string, string>(){
                        {"host", this._getHost(request.BucketName)},
                        {"date", this._getDate()},
                        {"user-agent", this._getUserAgent()},
                    };
                    request_.Query = this._toQuery(TeaModel.BuildMap(request.Filter));
                    request_.Headers["authorization"] = this._getAuth(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    if (this._isFail(response_)) {
                        respMap = this._getErrMessage(response_);
                        throw new TeaException(new Dictionary<string, object>(){
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>(){
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    respMap = this._parseXml(response_, typeof(GetBucketResponse));
                    return TeaModel.ToObject<GetBucketResponse>(TeaConverter.merge<object>(
                        new Dictionary<string, object>(){
                            {"ListBucketResult", respMap["ListBucketResult"]},
                        },
                        response_.Headers
                    ));
                } catch (Exception e) {
                    if (TeaCore.IsRetryable(e)) {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public GetLiveChannelInfoResponse GetLiveChannelInfo(GetLiveChannelInfoRequest request, RuntimeObject runtime) {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>(){
                {"timeouted", "retry"},
                {"readTimeout", this._defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", this._defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", this._default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", this._default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", this._default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", this._default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", this._default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", this._default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", this._defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>(){
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", this._defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", this._default(runtime.BackoffPolicy, "no")},
                    {"period", this._defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((Dictionary<string, object>) runtime_["retry"], _retryTimes, _now)) {
                if (_retryTimes > 0) {
                    int backoffTime = TeaCore.GetBackoffTime((Dictionary<string, object>)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0) {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try {
                    TeaRequest request_ = new TeaRequest();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/" + request.ChannelName + "?live";
                    request_.Headers = new Dictionary<string, string>(){
                        {"host", this._getHost(request.BucketName)},
                        {"date", this._getDate()},
                        {"user-agent", this._getUserAgent()},
                    };
                    request_.Headers["authorization"] = this._getAuth(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    if (this._isFail(response_)) {
                        respMap = this._getErrMessage(response_);
                        throw new TeaException(new Dictionary<string, object>(){
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>(){
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    respMap = this._parseXml(response_, typeof(GetLiveChannelInfoResponse));
                    return TeaModel.ToObject<GetLiveChannelInfoResponse>(TeaConverter.merge<object>(
                        new Dictionary<string, object>(){
                            {"LiveChannelConfiguration", respMap["LiveChannelConfiguration"]},
                        },
                        response_.Headers
                    ));
                } catch (Exception e) {
                    if (TeaCore.IsRetryable(e)) {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public GetLiveChannelStatResponse GetLiveChannelStat(GetLiveChannelStatRequest request, RuntimeObject runtime) {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>(){
                {"timeouted", "retry"},
                {"readTimeout", this._defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", this._defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", this._default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", this._default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", this._default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", this._default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", this._default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", this._default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", this._defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>(){
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", this._defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", this._default(runtime.BackoffPolicy, "no")},
                    {"period", this._defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((Dictionary<string, object>) runtime_["retry"], _retryTimes, _now)) {
                if (_retryTimes > 0) {
                    int backoffTime = TeaCore.GetBackoffTime((Dictionary<string, object>)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0) {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try {
                    TeaRequest request_ = new TeaRequest();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/" + request.ChannelName + "?live";
                    request_.Headers = new Dictionary<string, string>(){
                        {"host", this._getHost(request.BucketName)},
                        {"date", this._getDate()},
                        {"user-agent", this._getUserAgent()},
                    };
                    request_.Query = this._toQuery(TeaModel.BuildMap(request.Filter));
                    request_.Headers["authorization"] = this._getAuth(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    if (this._isFail(response_)) {
                        respMap = this._getErrMessage(response_);
                        throw new TeaException(new Dictionary<string, object>(){
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>(){
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    respMap = this._parseXml(response_, typeof(GetLiveChannelStatResponse));
                    return TeaModel.ToObject<GetLiveChannelStatResponse>(TeaConverter.merge<object>(
                        new Dictionary<string, object>(){
                            {"LiveChannelStat", respMap["LiveChannelStat"]},
                        },
                        response_.Headers
                    ));
                } catch (Exception e) {
                    if (TeaCore.IsRetryable(e)) {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public DeleteObjectResponse DeleteObject(DeleteObjectRequest request, RuntimeObject runtime) {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>(){
                {"timeouted", "retry"},
                {"readTimeout", this._defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", this._defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", this._default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", this._default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", this._default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", this._default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", this._default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", this._default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", this._defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>(){
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", this._defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", this._default(runtime.BackoffPolicy, "no")},
                    {"period", this._defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((Dictionary<string, object>) runtime_["retry"], _retryTimes, _now)) {
                if (_retryTimes > 0) {
                    int backoffTime = TeaCore.GetBackoffTime((Dictionary<string, object>)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0) {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try {
                    TeaRequest request_ = new TeaRequest();
                    request_.Protocol = _protocol;
                    request_.Method = "DELETE";
                    request_.Pathname = "/" + request.ObjectName;
                    request_.Headers = new Dictionary<string, string>(){
                        {"host", this._getHost(request.BucketName)},
                        {"date", this._getDate()},
                        {"user-agent", this._getUserAgent()},
                    };
                    request_.Headers["authorization"] = this._getAuth(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    if (this._isFail(response_)) {
                        respMap = this._getErrMessage(response_);
                        throw new TeaException(new Dictionary<string, object>(){
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>(){
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    return TeaModel.ToObject<DeleteObjectResponse>(TeaConverter.merge<object>(
                        response_.Headers
                    ));
                } catch (Exception e) {
                    if (TeaCore.IsRetryable(e)) {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public AbortMultipartUploadResponse AbortMultipartUpload(AbortMultipartUploadRequest request, RuntimeObject runtime) {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>(){
                {"timeouted", "retry"},
                {"readTimeout", this._defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", this._defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", this._default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", this._default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", this._default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", this._default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", this._default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", this._default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", this._defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>(){
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", this._defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", this._default(runtime.BackoffPolicy, "no")},
                    {"period", this._defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((Dictionary<string, object>) runtime_["retry"], _retryTimes, _now)) {
                if (_retryTimes > 0) {
                    int backoffTime = TeaCore.GetBackoffTime((Dictionary<string, object>)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0) {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try {
                    TeaRequest request_ = new TeaRequest();
                    request_.Protocol = _protocol;
                    request_.Method = "DELETE";
                    request_.Pathname = "/" + request.ObjectName;
                    request_.Headers = new Dictionary<string, string>(){
                        {"host", this._getHost(request.BucketName)},
                        {"date", this._getDate()},
                        {"user-agent", this._getUserAgent()},
                    };
                    request_.Query = this._toQuery(TeaModel.BuildMap(request.Filter));
                    request_.Headers["authorization"] = this._getAuth(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    if (this._isFail(response_)) {
                        respMap = this._getErrMessage(response_);
                        throw new TeaException(new Dictionary<string, object>(){
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>(){
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    return TeaModel.ToObject<AbortMultipartUploadResponse>(TeaConverter.merge<object>(
                        response_.Headers
                    ));
                } catch (Exception e) {
                    if (TeaCore.IsRetryable(e)) {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public AppendObjectResponse AppendObject(AppendObjectRequest request, RuntimeObject runtime) {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>(){
                {"timeouted", "retry"},
                {"readTimeout", this._defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", this._defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", this._default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", this._default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", this._default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", this._default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", this._default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", this._default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", this._defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>(){
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", this._defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", this._default(runtime.BackoffPolicy, "no")},
                    {"period", this._defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((Dictionary<string, object>) runtime_["retry"], _retryTimes, _now)) {
                if (_retryTimes > 0) {
                    int backoffTime = TeaCore.GetBackoffTime((Dictionary<string, object>)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0) {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try {
                    TeaRequest request_ = new TeaRequest();
                    request_.Protocol = _protocol;
                    request_.Method = "POST";
                    request_.Pathname = "/" + request.ObjectName + "?append";
                    request_.Headers = TeaConverter.merge<string>(
                        new Dictionary<string, string>(){
                            {"host", this._getHost(request.BucketName)},
                            {"date", this._getDate()},
                            {"user-agent", this._getUserAgent()},
                        },
                        this._toHeader(TeaModel.BuildMap(request.Header)),
                        this._parseMeta(request.UserMeta, "x-oss-meta-")
                    );
                    request_.Query = this._toQuery(TeaModel.BuildMap(request.Filter));
                    request_.Body = request.Body;
                    request_.Headers["content-type"] = this._default(this._getSpecialValue(TeaModel.BuildMap(request.Header), "content-type"), this._getContentType(request.ObjectName));
                    request_.Headers["authorization"] = this._getAuth(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    if (this._isFail(response_)) {
                        respMap = this._getErrMessage(response_);
                        throw new TeaException(new Dictionary<string, object>(){
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>(){
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    return TeaModel.ToObject<AppendObjectResponse>(TeaConverter.merge<object>(
                        response_.Headers
                    ));
                } catch (Exception e) {
                    if (TeaCore.IsRetryable(e)) {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public UploadPartCopyResponse UploadPartCopy(UploadPartCopyRequest request, RuntimeObject runtime) {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>(){
                {"timeouted", "retry"},
                {"readTimeout", this._defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", this._defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", this._default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", this._default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", this._default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", this._default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", this._default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", this._default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", this._defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>(){
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", this._defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", this._default(runtime.BackoffPolicy, "no")},
                    {"period", this._defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((Dictionary<string, object>) runtime_["retry"], _retryTimes, _now)) {
                if (_retryTimes > 0) {
                    int backoffTime = TeaCore.GetBackoffTime((Dictionary<string, object>)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0) {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try {
                    TeaRequest request_ = new TeaRequest();
                    request_.Protocol = _protocol;
                    request_.Method = "PUT";
                    request_.Pathname = "/" + request.ObjectName;
                    request_.Headers = TeaConverter.merge<string>(
                        new Dictionary<string, string>(){
                            {"host", this._getHost(request.BucketName)},
                            {"date", this._getDate()},
                            {"user-agent", this._getUserAgent()},
                        },
                        this._toHeader(TeaModel.BuildMap(request.Header))
                    );
                    request_.Query = this._toQuery(TeaModel.BuildMap(request.Filter));
                    request_.Headers["authorization"] = this._getAuth(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    if (this._isFail(response_)) {
                        respMap = this._getErrMessage(response_);
                        throw new TeaException(new Dictionary<string, object>(){
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>(){
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    respMap = this._parseXml(response_, typeof(UploadPartCopyResponse));
                    return TeaModel.ToObject<UploadPartCopyResponse>(TeaConverter.merge<object>(
                        new Dictionary<string, object>(){
                            {"CopyPartResult", respMap["CopyPartResult"]},
                        },
                        response_.Headers
                    ));
                } catch (Exception e) {
                    if (TeaCore.IsRetryable(e)) {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public GetVodPlaylistResponse GetVodPlaylist(GetVodPlaylistRequest request, RuntimeObject runtime) {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>(){
                {"timeouted", "retry"},
                {"readTimeout", this._defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", this._defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", this._default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", this._default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", this._default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", this._default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", this._default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", this._default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", this._defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>(){
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", this._defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", this._default(runtime.BackoffPolicy, "no")},
                    {"period", this._defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((Dictionary<string, object>) runtime_["retry"], _retryTimes, _now)) {
                if (_retryTimes > 0) {
                    int backoffTime = TeaCore.GetBackoffTime((Dictionary<string, object>)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0) {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try {
                    TeaRequest request_ = new TeaRequest();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/" + request.ChannelName + "?vod";
                    request_.Headers = new Dictionary<string, string>(){
                        {"host", this._getHost(request.BucketName)},
                        {"date", this._getDate()},
                        {"user-agent", this._getUserAgent()},
                    };
                    request_.Query = this._toQuery(TeaModel.BuildMap(request.Filter));
                    request_.Headers["authorization"] = this._getAuth(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    if (this._isFail(response_)) {
                        respMap = this._getErrMessage(response_);
                        throw new TeaException(new Dictionary<string, object>(){
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>(){
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    return TeaModel.ToObject<GetVodPlaylistResponse>(TeaConverter.merge<object>(
                        response_.Headers
                    ));
                } catch (Exception e) {
                    if (TeaCore.IsRetryable(e)) {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public DeleteBucketCORSResponse DeleteBucketCORS(DeleteBucketCORSRequest request, RuntimeObject runtime) {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>(){
                {"timeouted", "retry"},
                {"readTimeout", this._defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", this._defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", this._default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", this._default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", this._default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", this._default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", this._default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", this._default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", this._defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>(){
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", this._defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", this._default(runtime.BackoffPolicy, "no")},
                    {"period", this._defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((Dictionary<string, object>) runtime_["retry"], _retryTimes, _now)) {
                if (_retryTimes > 0) {
                    int backoffTime = TeaCore.GetBackoffTime((Dictionary<string, object>)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0) {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try {
                    TeaRequest request_ = new TeaRequest();
                    request_.Protocol = _protocol;
                    request_.Method = "DELETE";
                    request_.Pathname = "/?cors";
                    request_.Headers = new Dictionary<string, string>(){
                        {"host", this._getHost(request.BucketName)},
                        {"date", this._getDate()},
                        {"user-agent", this._getUserAgent()},
                    };
                    request_.Headers["authorization"] = this._getAuth(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    if (this._isFail(response_)) {
                        respMap = this._getErrMessage(response_);
                        throw new TeaException(new Dictionary<string, object>(){
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>(){
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    return TeaModel.ToObject<DeleteBucketCORSResponse>(TeaConverter.merge<object>(
                        response_.Headers
                    ));
                } catch (Exception e) {
                    if (TeaCore.IsRetryable(e)) {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public GetObjectResponse GetObject(GetObjectRequest request, RuntimeObject runtime) {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>(){
                {"timeouted", "retry"},
                {"readTimeout", this._defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", this._defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", this._default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", this._default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", this._default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", this._default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", this._default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", this._default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", this._defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>(){
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", this._defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", this._default(runtime.BackoffPolicy, "no")},
                    {"period", this._defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((Dictionary<string, object>) runtime_["retry"], _retryTimes, _now)) {
                if (_retryTimes > 0) {
                    int backoffTime = TeaCore.GetBackoffTime((Dictionary<string, object>)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0) {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try {
                    TeaRequest request_ = new TeaRequest();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/" + request.ObjectName;
                    request_.Headers = TeaConverter.merge<string>(
                        new Dictionary<string, string>(){
                            {"host", this._getHost(request.BucketName)},
                            {"date", this._getDate()},
                            {"user-agent", this._getUserAgent()},
                        },
                        this._toHeader(TeaModel.BuildMap(request.Header))
                    );
                    request_.Headers["authorization"] = this._getAuth(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    if (this._isFail(response_)) {
                        respMap = this._getErrMessage(response_);
                        throw new TeaException(new Dictionary<string, object>(){
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>(){
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    return TeaModel.ToObject<GetObjectResponse>(TeaConverter.merge<object>(
                        new Dictionary<string, object>(){
                            {"body", this._readAsStream(response_)},
                        },
                        response_.Headers
                    ));
                } catch (Exception e) {
                    if (TeaCore.IsRetryable(e)) {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public UploadPartResponse UploadPart(UploadPartRequest request, RuntimeObject runtime) {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>(){
                {"timeouted", "retry"},
                {"readTimeout", this._defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", this._defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", this._default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", this._default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", this._default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", this._default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", this._default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", this._default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", this._defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>(){
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", this._defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", this._default(runtime.BackoffPolicy, "no")},
                    {"period", this._defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((Dictionary<string, object>) runtime_["retry"], _retryTimes, _now)) {
                if (_retryTimes > 0) {
                    int backoffTime = TeaCore.GetBackoffTime((Dictionary<string, object>)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0) {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try {
                    TeaRequest request_ = new TeaRequest();
                    request_.Protocol = _protocol;
                    request_.Method = "PUT";
                    request_.Pathname = "/" + request.ObjectName;
                    request_.Headers = new Dictionary<string, string>(){
                        {"host", this._getHost(request.BucketName)},
                        {"date", this._getDate()},
                        {"user-agent", this._getUserAgent()},
                    };
                    request_.Query = this._toQuery(TeaModel.BuildMap(request.Filter));
                    request_.Body = request.Body;
                    request_.Headers["authorization"] = this._getAuth(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    if (this._isFail(response_)) {
                        respMap = this._getErrMessage(response_);
                        throw new TeaException(new Dictionary<string, object>(){
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>(){
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    return TeaModel.ToObject<UploadPartResponse>(TeaConverter.merge<object>(
                        response_.Headers
                    ));
                } catch (Exception e) {
                    if (TeaCore.IsRetryable(e)) {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public GetBucketCORSResponse GetBucketCORS(GetBucketCORSRequest request, RuntimeObject runtime) {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>(){
                {"timeouted", "retry"},
                {"readTimeout", this._defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", this._defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", this._default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", this._default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", this._default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", this._default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", this._default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", this._default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", this._defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>(){
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", this._defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", this._default(runtime.BackoffPolicy, "no")},
                    {"period", this._defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((Dictionary<string, object>) runtime_["retry"], _retryTimes, _now)) {
                if (_retryTimes > 0) {
                    int backoffTime = TeaCore.GetBackoffTime((Dictionary<string, object>)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0) {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try {
                    TeaRequest request_ = new TeaRequest();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/?cors";
                    request_.Headers = new Dictionary<string, string>(){
                        {"host", this._getHost(request.BucketName)},
                        {"date", this._getDate()},
                        {"user-agent", this._getUserAgent()},
                    };
                    request_.Headers["authorization"] = this._getAuth(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    if (this._isFail(response_)) {
                        respMap = this._getErrMessage(response_);
                        throw new TeaException(new Dictionary<string, object>(){
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>(){
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    respMap = this._parseXml(response_, typeof(GetBucketCORSResponse));
                    return TeaModel.ToObject<GetBucketCORSResponse>(TeaConverter.merge<object>(
                        new Dictionary<string, object>(){
                            {"CORSConfiguration", respMap["CORSConfiguration"]},
                        },
                        response_.Headers
                    ));
                } catch (Exception e) {
                    if (TeaCore.IsRetryable(e)) {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public CopyObjectResponse CopyObject(CopyObjectRequest request, RuntimeObject runtime) {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>(){
                {"timeouted", "retry"},
                {"readTimeout", this._defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", this._defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", this._default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", this._default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", this._default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", this._default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", this._default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", this._default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", this._defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>(){
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", this._defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", this._default(runtime.BackoffPolicy, "no")},
                    {"period", this._defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((Dictionary<string, object>) runtime_["retry"], _retryTimes, _now)) {
                if (_retryTimes > 0) {
                    int backoffTime = TeaCore.GetBackoffTime((Dictionary<string, object>)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0) {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try {
                    TeaRequest request_ = new TeaRequest();
                    request_.Protocol = _protocol;
                    request_.Method = "PUT";
                    request_.Pathname = "/" + request.DestObjectName;
                    request_.Headers = TeaConverter.merge<string>(
                        new Dictionary<string, string>(){
                            {"host", this._getHost(request.BucketName)},
                            {"date", this._getDate()},
                            {"user-agent", this._getUserAgent()},
                        },
                        this._toHeader(TeaModel.BuildMap(request.Header))
                    );
                    request_.Headers["x-oss-copy-source"] = this._encode(request_.Headers["x-oss-copy-source"], "UrlEncode");
                    request_.Headers["authorization"] = this._getAuth(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    if (this._isFail(response_)) {
                        respMap = this._getErrMessage(response_);
                        throw new TeaException(new Dictionary<string, object>(){
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>(){
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    respMap = this._parseXml(response_, typeof(CopyObjectResponse));
                    return TeaModel.ToObject<CopyObjectResponse>(TeaConverter.merge<object>(
                        new Dictionary<string, object>(){
                            {"CopyObjectResult", respMap["CopyObjectResult"]},
                        },
                        response_.Headers
                    ));
                } catch (Exception e) {
                    if (TeaCore.IsRetryable(e)) {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public GetObjectTaggingResponse GetObjectTagging(GetObjectTaggingRequest request, RuntimeObject runtime) {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>(){
                {"timeouted", "retry"},
                {"readTimeout", this._defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", this._defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", this._default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", this._default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", this._default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", this._default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", this._default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", this._default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", this._defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>(){
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", this._defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", this._default(runtime.BackoffPolicy, "no")},
                    {"period", this._defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((Dictionary<string, object>) runtime_["retry"], _retryTimes, _now)) {
                if (_retryTimes > 0) {
                    int backoffTime = TeaCore.GetBackoffTime((Dictionary<string, object>)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0) {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try {
                    TeaRequest request_ = new TeaRequest();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/" + request.ObjectName + "?tagging";
                    request_.Headers = new Dictionary<string, string>(){
                        {"host", this._getHost(request.BucketName)},
                        {"date", this._getDate()},
                        {"user-agent", this._getUserAgent()},
                    };
                    request_.Headers["authorization"] = this._getAuth(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    if (this._isFail(response_)) {
                        respMap = this._getErrMessage(response_);
                        throw new TeaException(new Dictionary<string, object>(){
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>(){
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    respMap = this._parseXml(response_, typeof(GetObjectTaggingResponse));
                    return TeaModel.ToObject<GetObjectTaggingResponse>(TeaConverter.merge<object>(
                        new Dictionary<string, object>(){
                            {"Tagging", respMap["Tagging"]},
                        },
                        response_.Headers
                    ));
                } catch (Exception e) {
                    if (TeaCore.IsRetryable(e)) {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public DeleteBucketLifecycleResponse DeleteBucketLifecycle(DeleteBucketLifecycleRequest request, RuntimeObject runtime) {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>(){
                {"timeouted", "retry"},
                {"readTimeout", this._defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", this._defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", this._default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", this._default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", this._default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", this._default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", this._default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", this._default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", this._defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>(){
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", this._defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", this._default(runtime.BackoffPolicy, "no")},
                    {"period", this._defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((Dictionary<string, object>) runtime_["retry"], _retryTimes, _now)) {
                if (_retryTimes > 0) {
                    int backoffTime = TeaCore.GetBackoffTime((Dictionary<string, object>)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0) {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try {
                    TeaRequest request_ = new TeaRequest();
                    request_.Protocol = _protocol;
                    request_.Method = "DELETE";
                    request_.Pathname = "/?lifecycle";
                    request_.Headers = new Dictionary<string, string>(){
                        {"host", this._getHost(request.BucketName)},
                        {"date", this._getDate()},
                        {"user-agent", this._getUserAgent()},
                    };
                    request_.Headers["authorization"] = this._getAuth(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    if (this._isFail(response_)) {
                        respMap = this._getErrMessage(response_);
                        throw new TeaException(new Dictionary<string, object>(){
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>(){
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    return TeaModel.ToObject<DeleteBucketLifecycleResponse>(TeaConverter.merge<object>(
                        response_.Headers
                    ));
                } catch (Exception e) {
                    if (TeaCore.IsRetryable(e)) {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public DeleteBucketLoggingResponse DeleteBucketLogging(DeleteBucketLoggingRequest request, RuntimeObject runtime) {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>(){
                {"timeouted", "retry"},
                {"readTimeout", this._defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", this._defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", this._default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", this._default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", this._default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", this._default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", this._default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", this._default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", this._defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>(){
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", this._defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", this._default(runtime.BackoffPolicy, "no")},
                    {"period", this._defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((Dictionary<string, object>) runtime_["retry"], _retryTimes, _now)) {
                if (_retryTimes > 0) {
                    int backoffTime = TeaCore.GetBackoffTime((Dictionary<string, object>)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0) {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try {
                    TeaRequest request_ = new TeaRequest();
                    request_.Protocol = _protocol;
                    request_.Method = "DELETE";
                    request_.Pathname = "/?logging";
                    request_.Headers = new Dictionary<string, string>(){
                        {"host", this._getHost(request.BucketName)},
                        {"date", this._getDate()},
                        {"user-agent", this._getUserAgent()},
                    };
                    request_.Headers["authorization"] = this._getAuth(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    if (this._isFail(response_)) {
                        respMap = this._getErrMessage(response_);
                        throw new TeaException(new Dictionary<string, object>(){
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>(){
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    return TeaModel.ToObject<DeleteBucketLoggingResponse>(TeaConverter.merge<object>(
                        response_.Headers
                    ));
                } catch (Exception e) {
                    if (TeaCore.IsRetryable(e)) {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public DeleteBucketWebsiteResponse DeleteBucketWebsite(DeleteBucketWebsiteRequest request, RuntimeObject runtime) {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>(){
                {"timeouted", "retry"},
                {"readTimeout", this._defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", this._defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", this._default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", this._default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", this._default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", this._default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", this._default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", this._default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", this._defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>(){
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", this._defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", this._default(runtime.BackoffPolicy, "no")},
                    {"period", this._defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((Dictionary<string, object>) runtime_["retry"], _retryTimes, _now)) {
                if (_retryTimes > 0) {
                    int backoffTime = TeaCore.GetBackoffTime((Dictionary<string, object>)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0) {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try {
                    TeaRequest request_ = new TeaRequest();
                    request_.Protocol = _protocol;
                    request_.Method = "DELETE";
                    request_.Pathname = "/?website";
                    request_.Headers = new Dictionary<string, string>(){
                        {"host", this._getHost(request.BucketName)},
                        {"date", this._getDate()},
                        {"user-agent", this._getUserAgent()},
                    };
                    request_.Headers["authorization"] = this._getAuth(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    if (this._isFail(response_)) {
                        respMap = this._getErrMessage(response_);
                        throw new TeaException(new Dictionary<string, object>(){
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>(){
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    return TeaModel.ToObject<DeleteBucketWebsiteResponse>(TeaConverter.merge<object>(
                        response_.Headers
                    ));
                } catch (Exception e) {
                    if (TeaCore.IsRetryable(e)) {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public GetSymlinkResponse GetSymlink(GetSymlinkRequest request, RuntimeObject runtime) {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>(){
                {"timeouted", "retry"},
                {"readTimeout", this._defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", this._defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", this._default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", this._default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", this._default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", this._default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", this._default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", this._default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", this._defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>(){
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", this._defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", this._default(runtime.BackoffPolicy, "no")},
                    {"period", this._defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((Dictionary<string, object>) runtime_["retry"], _retryTimes, _now)) {
                if (_retryTimes > 0) {
                    int backoffTime = TeaCore.GetBackoffTime((Dictionary<string, object>)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0) {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try {
                    TeaRequest request_ = new TeaRequest();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/" + request.ObjectName + "?symlink";
                    request_.Headers = new Dictionary<string, string>(){
                        {"host", this._getHost(request.BucketName)},
                        {"date", this._getDate()},
                        {"user-agent", this._getUserAgent()},
                    };
                    request_.Headers["authorization"] = this._getAuth(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    if (this._isFail(response_)) {
                        respMap = this._getErrMessage(response_);
                        throw new TeaException(new Dictionary<string, object>(){
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>(){
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    return TeaModel.ToObject<GetSymlinkResponse>(TeaConverter.merge<object>(
                        response_.Headers
                    ));
                } catch (Exception e) {
                    if (TeaCore.IsRetryable(e)) {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public GetBucketLifecycleResponse GetBucketLifecycle(GetBucketLifecycleRequest request, RuntimeObject runtime) {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>(){
                {"timeouted", "retry"},
                {"readTimeout", this._defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", this._defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", this._default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", this._default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", this._default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", this._default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", this._default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", this._default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", this._defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>(){
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", this._defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", this._default(runtime.BackoffPolicy, "no")},
                    {"period", this._defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((Dictionary<string, object>) runtime_["retry"], _retryTimes, _now)) {
                if (_retryTimes > 0) {
                    int backoffTime = TeaCore.GetBackoffTime((Dictionary<string, object>)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0) {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try {
                    TeaRequest request_ = new TeaRequest();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/?lifecycle";
                    request_.Headers = new Dictionary<string, string>(){
                        {"host", this._getHost(request.BucketName)},
                        {"date", this._getDate()},
                        {"user-agent", this._getUserAgent()},
                    };
                    request_.Headers["authorization"] = this._getAuth(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    if (this._isFail(response_)) {
                        respMap = this._getErrMessage(response_);
                        throw new TeaException(new Dictionary<string, object>(){
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>(){
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    respMap = this._parseXml(response_, typeof(GetBucketLifecycleResponse));
                    return TeaModel.ToObject<GetBucketLifecycleResponse>(TeaConverter.merge<object>(
                        new Dictionary<string, object>(){
                            {"LifecycleConfiguration", respMap["LifecycleConfiguration"]},
                        },
                        response_.Headers
                    ));
                } catch (Exception e) {
                    if (TeaCore.IsRetryable(e)) {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public PutSymlinkResponse PutSymlink(PutSymlinkRequest request, RuntimeObject runtime) {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>(){
                {"timeouted", "retry"},
                {"readTimeout", this._defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", this._defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", this._default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", this._default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", this._default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", this._default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", this._default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", this._default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", this._defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>(){
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", this._defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", this._default(runtime.BackoffPolicy, "no")},
                    {"period", this._defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((Dictionary<string, object>) runtime_["retry"], _retryTimes, _now)) {
                if (_retryTimes > 0) {
                    int backoffTime = TeaCore.GetBackoffTime((Dictionary<string, object>)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0) {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try {
                    TeaRequest request_ = new TeaRequest();
                    request_.Protocol = _protocol;
                    request_.Method = "PUT";
                    request_.Pathname = "/" + request.ObjectName + "?symlink";
                    request_.Headers = TeaConverter.merge<string>(
                        new Dictionary<string, string>(){
                            {"host", this._getHost(request.BucketName)},
                            {"date", this._getDate()},
                            {"user-agent", this._getUserAgent()},
                        },
                        this._toHeader(TeaModel.BuildMap(request.Header))
                    );
                    request_.Headers["authorization"] = this._getAuth(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    if (this._isFail(response_)) {
                        respMap = this._getErrMessage(response_);
                        throw new TeaException(new Dictionary<string, object>(){
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>(){
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    return TeaModel.ToObject<PutSymlinkResponse>(TeaConverter.merge<object>(
                        response_.Headers
                    ));
                } catch (Exception e) {
                    if (TeaCore.IsRetryable(e)) {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public GetBucketRefererResponse GetBucketReferer(GetBucketRefererRequest request, RuntimeObject runtime) {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>(){
                {"timeouted", "retry"},
                {"readTimeout", this._defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", this._defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", this._default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", this._default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", this._default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", this._default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", this._default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", this._default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", this._defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>(){
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", this._defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", this._default(runtime.BackoffPolicy, "no")},
                    {"period", this._defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((Dictionary<string, object>) runtime_["retry"], _retryTimes, _now)) {
                if (_retryTimes > 0) {
                    int backoffTime = TeaCore.GetBackoffTime((Dictionary<string, object>)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0) {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try {
                    TeaRequest request_ = new TeaRequest();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/?referer";
                    request_.Headers = new Dictionary<string, string>(){
                        {"host", this._getHost(request.BucketName)},
                        {"date", this._getDate()},
                        {"user-agent", this._getUserAgent()},
                    };
                    request_.Headers["authorization"] = this._getAuth(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    if (this._isFail(response_)) {
                        respMap = this._getErrMessage(response_);
                        throw new TeaException(new Dictionary<string, object>(){
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>(){
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    respMap = this._parseXml(response_, typeof(GetBucketRefererResponse));
                    return TeaModel.ToObject<GetBucketRefererResponse>(TeaConverter.merge<object>(
                        new Dictionary<string, object>(){
                            {"RefererConfiguration", respMap["RefererConfiguration"]},
                        },
                        response_.Headers
                    ));
                } catch (Exception e) {
                    if (TeaCore.IsRetryable(e)) {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public CallbackResponse Callback(CallbackRequest request, RuntimeObject runtime) {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>(){
                {"timeouted", "retry"},
                {"readTimeout", this._defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", this._defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", this._default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", this._default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", this._default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", this._default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", this._default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", this._default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", this._defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>(){
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", this._defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", this._default(runtime.BackoffPolicy, "no")},
                    {"period", this._defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((Dictionary<string, object>) runtime_["retry"], _retryTimes, _now)) {
                if (_retryTimes > 0) {
                    int backoffTime = TeaCore.GetBackoffTime((Dictionary<string, object>)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0) {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try {
                    TeaRequest request_ = new TeaRequest();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/";
                    request_.Headers = new Dictionary<string, string>(){
                        {"host", this._getHost(request.BucketName)},
                        {"date", this._getDate()},
                        {"user-agent", this._getUserAgent()},
                    };
                    request_.Headers["authorization"] = this._getAuth(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    if (this._isFail(response_)) {
                        respMap = this._getErrMessage(response_);
                        throw new TeaException(new Dictionary<string, object>(){
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>(){
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    return TeaModel.ToObject<CallbackResponse>(TeaConverter.merge<object>(
                        response_.Headers
                    ));
                } catch (Exception e) {
                    if (TeaCore.IsRetryable(e)) {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public GetBucketLoggingResponse GetBucketLogging(GetBucketLoggingRequest request, RuntimeObject runtime) {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>(){
                {"timeouted", "retry"},
                {"readTimeout", this._defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", this._defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", this._default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", this._default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", this._default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", this._default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", this._default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", this._default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", this._defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>(){
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", this._defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", this._default(runtime.BackoffPolicy, "no")},
                    {"period", this._defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((Dictionary<string, object>) runtime_["retry"], _retryTimes, _now)) {
                if (_retryTimes > 0) {
                    int backoffTime = TeaCore.GetBackoffTime((Dictionary<string, object>)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0) {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try {
                    TeaRequest request_ = new TeaRequest();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/?logging";
                    request_.Headers = new Dictionary<string, string>(){
                        {"host", this._getHost(request.BucketName)},
                        {"date", this._getDate()},
                        {"user-agent", this._getUserAgent()},
                    };
                    request_.Headers["authorization"] = this._getAuth(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    if (this._isFail(response_)) {
                        respMap = this._getErrMessage(response_);
                        throw new TeaException(new Dictionary<string, object>(){
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>(){
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    respMap = this._parseXml(response_, typeof(GetBucketLoggingResponse));
                    return TeaModel.ToObject<GetBucketLoggingResponse>(TeaConverter.merge<object>(
                        new Dictionary<string, object>(){
                            {"BucketLoggingStatus", respMap["BucketLoggingStatus"]},
                        },
                        response_.Headers
                    ));
                } catch (Exception e) {
                    if (TeaCore.IsRetryable(e)) {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public PutObjectAclResponse PutObjectAcl(PutObjectAclRequest request, RuntimeObject runtime) {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>(){
                {"timeouted", "retry"},
                {"readTimeout", this._defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", this._defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", this._default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", this._default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", this._default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", this._default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", this._default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", this._default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", this._defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>(){
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", this._defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", this._default(runtime.BackoffPolicy, "no")},
                    {"period", this._defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((Dictionary<string, object>) runtime_["retry"], _retryTimes, _now)) {
                if (_retryTimes > 0) {
                    int backoffTime = TeaCore.GetBackoffTime((Dictionary<string, object>)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0) {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try {
                    TeaRequest request_ = new TeaRequest();
                    request_.Protocol = _protocol;
                    request_.Method = "PUT";
                    request_.Pathname = "/" + request.ObjectName + "?acl";
                    request_.Headers = TeaConverter.merge<string>(
                        new Dictionary<string, string>(){
                            {"host", this._getHost(request.BucketName)},
                            {"date", this._getDate()},
                            {"user-agent", this._getUserAgent()},
                        },
                        this._toHeader(TeaModel.BuildMap(request.Header))
                    );
                    request_.Headers["authorization"] = this._getAuth(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    if (this._isFail(response_)) {
                        respMap = this._getErrMessage(response_);
                        throw new TeaException(new Dictionary<string, object>(){
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>(){
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    return TeaModel.ToObject<PutObjectAclResponse>(TeaConverter.merge<object>(
                        response_.Headers
                    ));
                } catch (Exception e) {
                    if (TeaCore.IsRetryable(e)) {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public GetBucketInfoResponse GetBucketInfo(GetBucketInfoRequest request, RuntimeObject runtime) {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>(){
                {"timeouted", "retry"},
                {"readTimeout", this._defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", this._defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", this._default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", this._default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", this._default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", this._default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", this._default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", this._default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", this._defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>(){
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", this._defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", this._default(runtime.BackoffPolicy, "no")},
                    {"period", this._defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((Dictionary<string, object>) runtime_["retry"], _retryTimes, _now)) {
                if (_retryTimes > 0) {
                    int backoffTime = TeaCore.GetBackoffTime((Dictionary<string, object>)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0) {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try {
                    TeaRequest request_ = new TeaRequest();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/?bucketInfo";
                    request_.Headers = new Dictionary<string, string>(){
                        {"host", this._getHost(request.BucketName)},
                        {"date", this._getDate()},
                        {"user-agent", this._getUserAgent()},
                    };
                    request_.Headers["authorization"] = this._getAuth(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    if (this._isFail(response_)) {
                        respMap = this._getErrMessage(response_);
                        throw new TeaException(new Dictionary<string, object>(){
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>(){
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    respMap = this._parseXml(response_, typeof(GetBucketInfoResponse));
                    return TeaModel.ToObject<GetBucketInfoResponse>(TeaConverter.merge<object>(
                        new Dictionary<string, object>(){
                            {"BucketInfo", respMap["BucketInfo"]},
                        },
                        response_.Headers
                    ));
                } catch (Exception e) {
                    if (TeaCore.IsRetryable(e)) {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public PutLiveChannelStatusResponse PutLiveChannelStatus(PutLiveChannelStatusRequest request, RuntimeObject runtime) {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>(){
                {"timeouted", "retry"},
                {"readTimeout", this._defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", this._defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", this._default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", this._default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", this._default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", this._default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", this._default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", this._default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", this._defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>(){
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", this._defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", this._default(runtime.BackoffPolicy, "no")},
                    {"period", this._defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((Dictionary<string, object>) runtime_["retry"], _retryTimes, _now)) {
                if (_retryTimes > 0) {
                    int backoffTime = TeaCore.GetBackoffTime((Dictionary<string, object>)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0) {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try {
                    TeaRequest request_ = new TeaRequest();
                    request_.Protocol = _protocol;
                    request_.Method = "PUT";
                    request_.Pathname = "/" + request.ChannelName + "?live";
                    request_.Headers = new Dictionary<string, string>(){
                        {"host", this._getHost(request.BucketName)},
                        {"date", this._getDate()},
                        {"user-agent", this._getUserAgent()},
                    };
                    request_.Query = this._toQuery(TeaModel.BuildMap(request.Filter));
                    request_.Headers["authorization"] = this._getAuth(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    if (this._isFail(response_)) {
                        respMap = this._getErrMessage(response_);
                        throw new TeaException(new Dictionary<string, object>(){
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>(){
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    return TeaModel.ToObject<PutLiveChannelStatusResponse>(TeaConverter.merge<object>(
                        response_.Headers
                    ));
                } catch (Exception e) {
                    if (TeaCore.IsRetryable(e)) {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public InitiateMultipartUploadResponse InitiateMultipartUpload(InitiateMultipartUploadRequest request, RuntimeObject runtime) {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>(){
                {"timeouted", "retry"},
                {"readTimeout", this._defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", this._defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", this._default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", this._default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", this._default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", this._default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", this._default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", this._default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", this._defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>(){
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", this._defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", this._default(runtime.BackoffPolicy, "no")},
                    {"period", this._defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((Dictionary<string, object>) runtime_["retry"], _retryTimes, _now)) {
                if (_retryTimes > 0) {
                    int backoffTime = TeaCore.GetBackoffTime((Dictionary<string, object>)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0) {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try {
                    TeaRequest request_ = new TeaRequest();
                    request_.Protocol = _protocol;
                    request_.Method = "POST";
                    request_.Pathname = "/" + request.ObjectName + "?uploads";
                    request_.Headers = TeaConverter.merge<string>(
                        new Dictionary<string, string>(){
                            {"host", this._getHost(request.BucketName)},
                            {"date", this._getDate()},
                            {"user-agent", this._getUserAgent()},
                        },
                        this._toHeader(TeaModel.BuildMap(request.Header))
                    );
                    request_.Query = this._toQuery(TeaModel.BuildMap(request.Filter));
                    request_.Headers["content-type"] = this._default(this._getSpecialValue(TeaModel.BuildMap(request.Header), "content-type"), this._getContentType(request.ObjectName));
                    request_.Headers["authorization"] = this._getAuth(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    if (this._isFail(response_)) {
                        respMap = this._getErrMessage(response_);
                        throw new TeaException(new Dictionary<string, object>(){
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>(){
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    respMap = this._parseXml(response_, typeof(InitiateMultipartUploadResponse));
                    return TeaModel.ToObject<InitiateMultipartUploadResponse>(TeaConverter.merge<object>(
                        new Dictionary<string, object>(){
                            {"InitiateMultipartUploadResult", respMap["InitiateMultipartUploadResult"]},
                        },
                        response_.Headers
                    ));
                } catch (Exception e) {
                    if (TeaCore.IsRetryable(e)) {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public OptionObjectResponse OptionObject(OptionObjectRequest request, RuntimeObject runtime) {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>(){
                {"timeouted", "retry"},
                {"readTimeout", this._defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", this._defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", this._default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", this._default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", this._default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", this._default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", this._default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", this._default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", this._defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>(){
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", this._defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", this._default(runtime.BackoffPolicy, "no")},
                    {"period", this._defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((Dictionary<string, object>) runtime_["retry"], _retryTimes, _now)) {
                if (_retryTimes > 0) {
                    int backoffTime = TeaCore.GetBackoffTime((Dictionary<string, object>)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0) {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try {
                    TeaRequest request_ = new TeaRequest();
                    request_.Protocol = _protocol;
                    request_.Method = "OPTIONS";
                    request_.Pathname = "/" + request.ObjectName;
                    request_.Headers = TeaConverter.merge<string>(
                        new Dictionary<string, string>(){
                            {"host", this._getHost(request.BucketName)},
                            {"date", this._getDate()},
                            {"user-agent", this._getUserAgent()},
                        },
                        this._toHeader(TeaModel.BuildMap(request.Header))
                    );
                    request_.Headers["authorization"] = this._getAuth(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    if (this._isFail(response_)) {
                        respMap = this._getErrMessage(response_);
                        throw new TeaException(new Dictionary<string, object>(){
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>(){
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    return TeaModel.ToObject<OptionObjectResponse>(TeaConverter.merge<object>(
                        response_.Headers
                    ));
                } catch (Exception e) {
                    if (TeaCore.IsRetryable(e)) {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public PostVodPlaylistResponse PostVodPlaylist(PostVodPlaylistRequest request, RuntimeObject runtime) {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>(){
                {"timeouted", "retry"},
                {"readTimeout", this._defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", this._defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", this._default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", this._default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", this._default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", this._default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", this._default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", this._default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", this._defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>(){
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", this._defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", this._default(runtime.BackoffPolicy, "no")},
                    {"period", this._defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((Dictionary<string, object>) runtime_["retry"], _retryTimes, _now)) {
                if (_retryTimes > 0) {
                    int backoffTime = TeaCore.GetBackoffTime((Dictionary<string, object>)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0) {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try {
                    TeaRequest request_ = new TeaRequest();
                    request_.Protocol = _protocol;
                    request_.Method = "POST";
                    request_.Pathname = "/" + request.ChannelName + "/" + request.PlaylistName + "?vod";
                    request_.Headers = new Dictionary<string, string>(){
                        {"host", this._getHost(request.BucketName)},
                        {"date", this._getDate()},
                        {"user-agent", this._getUserAgent()},
                    };
                    request_.Query = this._toQuery(TeaModel.BuildMap(request.Filter));
                    request_.Headers["authorization"] = this._getAuth(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    if (this._isFail(response_)) {
                        respMap = this._getErrMessage(response_);
                        throw new TeaException(new Dictionary<string, object>(){
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>(){
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    return TeaModel.ToObject<PostVodPlaylistResponse>(TeaConverter.merge<object>(
                        response_.Headers
                    ));
                } catch (Exception e) {
                    if (TeaCore.IsRetryable(e)) {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public PostObjectResponse PostObject(PostObjectRequest request, RuntimeObject runtime) {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>(){
                {"timeouted", "retry"},
                {"readTimeout", this._defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", this._defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", this._default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", this._default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", this._default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", this._default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", this._default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", this._default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", this._defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>(){
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", this._defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", this._default(runtime.BackoffPolicy, "no")},
                    {"period", this._defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((Dictionary<string, object>) runtime_["retry"], _retryTimes, _now)) {
                if (_retryTimes > 0) {
                    int backoffTime = TeaCore.GetBackoffTime((Dictionary<string, object>)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0) {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try {
                    TeaRequest request_ = new TeaRequest();
                    request_.Protocol = _protocol;
                    request_.Method = "POST";
                    request_.Pathname = "/";
                    request_.Headers = new Dictionary<string, string>(){
                        {"host", this._getHost(request.BucketName)},
                        {"date", this._getDate()},
                        {"user-agent", this._getUserAgent()},
                    };
                    request_.Headers["authorization"] = this._getAuth(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    if (this._isFail(response_)) {
                        respMap = this._getErrMessage(response_);
                        throw new TeaException(new Dictionary<string, object>(){
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>(){
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    return TeaModel.ToObject<PostObjectResponse>(TeaConverter.merge<object>(
                        response_.Headers
                    ));
                } catch (Exception e) {
                    if (TeaCore.IsRetryable(e)) {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public HeadObjectResponse HeadObject(HeadObjectRequest request, RuntimeObject runtime) {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>(){
                {"timeouted", "retry"},
                {"readTimeout", this._defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", this._defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", this._default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", this._default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", this._default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", this._default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", this._default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", this._default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", this._defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>(){
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", this._defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", this._default(runtime.BackoffPolicy, "no")},
                    {"period", this._defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((Dictionary<string, object>) runtime_["retry"], _retryTimes, _now)) {
                if (_retryTimes > 0) {
                    int backoffTime = TeaCore.GetBackoffTime((Dictionary<string, object>)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0) {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try {
                    TeaRequest request_ = new TeaRequest();
                    request_.Protocol = _protocol;
                    request_.Method = "HEAD";
                    request_.Pathname = "/" + request.ObjectName;
                    request_.Headers = TeaConverter.merge<string>(
                        new Dictionary<string, string>(){
                            {"host", this._getHost(request.BucketName)},
                            {"date", this._getDate()},
                            {"user-agent", this._getUserAgent()},
                        },
                        this._toHeader(TeaModel.BuildMap(request.Header))
                    );
                    request_.Headers["authorization"] = this._getAuth(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    if (this._isFail(response_)) {
                        respMap = this._getErrMessage(response_);
                        throw new TeaException(new Dictionary<string, object>(){
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>(){
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    return TeaModel.ToObject<HeadObjectResponse>(TeaConverter.merge<object>(
                        new Dictionary<string, object>(){
                            {"usermeta", this._toMeta(response_.Headers, "x-oss-meta-")},
                        },
                        response_.Headers
                    ));
                } catch (Exception e) {
                    if (TeaCore.IsRetryable(e)) {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public DeleteObjectTaggingResponse DeleteObjectTagging(DeleteObjectTaggingRequest request, RuntimeObject runtime) {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>(){
                {"timeouted", "retry"},
                {"readTimeout", this._defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", this._defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", this._default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", this._default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", this._default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", this._default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", this._default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", this._default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", this._defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>(){
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", this._defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", this._default(runtime.BackoffPolicy, "no")},
                    {"period", this._defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((Dictionary<string, object>) runtime_["retry"], _retryTimes, _now)) {
                if (_retryTimes > 0) {
                    int backoffTime = TeaCore.GetBackoffTime((Dictionary<string, object>)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0) {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try {
                    TeaRequest request_ = new TeaRequest();
                    request_.Protocol = _protocol;
                    request_.Method = "DELETE";
                    request_.Pathname = "/" + request.ObjectName + "?tagging";
                    request_.Headers = new Dictionary<string, string>(){
                        {"host", this._getHost(request.BucketName)},
                        {"date", this._getDate()},
                        {"user-agent", this._getUserAgent()},
                    };
                    request_.Headers["authorization"] = this._getAuth(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    if (this._isFail(response_)) {
                        respMap = this._getErrMessage(response_);
                        throw new TeaException(new Dictionary<string, object>(){
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>(){
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    return TeaModel.ToObject<DeleteObjectTaggingResponse>(TeaConverter.merge<object>(
                        response_.Headers
                    ));
                } catch (Exception e) {
                    if (TeaCore.IsRetryable(e)) {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public RestoreObjectResponse RestoreObject(RestoreObjectRequest request, RuntimeObject runtime) {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>(){
                {"timeouted", "retry"},
                {"readTimeout", this._defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", this._defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", this._default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", this._default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", this._default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", this._default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", this._default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", this._default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", this._defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>(){
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", this._defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", this._default(runtime.BackoffPolicy, "no")},
                    {"period", this._defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((Dictionary<string, object>) runtime_["retry"], _retryTimes, _now)) {
                if (_retryTimes > 0) {
                    int backoffTime = TeaCore.GetBackoffTime((Dictionary<string, object>)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0) {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try {
                    TeaRequest request_ = new TeaRequest();
                    request_.Protocol = _protocol;
                    request_.Method = "POST";
                    request_.Pathname = "/" + request.ObjectName + "?restore";
                    request_.Headers = new Dictionary<string, string>(){
                        {"host", this._getHost(request.BucketName)},
                        {"date", this._getDate()},
                        {"user-agent", this._getUserAgent()},
                    };
                    request_.Headers["authorization"] = this._getAuth(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    if (this._isFail(response_)) {
                        respMap = this._getErrMessage(response_);
                        throw new TeaException(new Dictionary<string, object>(){
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>(){
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    return TeaModel.ToObject<RestoreObjectResponse>(TeaConverter.merge<object>(
                        response_.Headers
                    ));
                } catch (Exception e) {
                    if (TeaCore.IsRetryable(e)) {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public GetObjectAclResponse GetObjectAcl(GetObjectAclRequest request, RuntimeObject runtime) {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>(){
                {"timeouted", "retry"},
                {"readTimeout", this._defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", this._defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", this._default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", this._default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", this._default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", this._default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", this._default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", this._default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", this._defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>(){
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", this._defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", this._default(runtime.BackoffPolicy, "no")},
                    {"period", this._defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((Dictionary<string, object>) runtime_["retry"], _retryTimes, _now)) {
                if (_retryTimes > 0) {
                    int backoffTime = TeaCore.GetBackoffTime((Dictionary<string, object>)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0) {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try {
                    TeaRequest request_ = new TeaRequest();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/" + request.ObjectName + "?acl";
                    request_.Headers = new Dictionary<string, string>(){
                        {"host", this._getHost(request.BucketName)},
                        {"date", this._getDate()},
                        {"user-agent", this._getUserAgent()},
                    };
                    request_.Headers["authorization"] = this._getAuth(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    if (this._isFail(response_)) {
                        respMap = this._getErrMessage(response_);
                        throw new TeaException(new Dictionary<string, object>(){
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>(){
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    respMap = this._parseXml(response_, typeof(GetObjectAclResponse));
                    return TeaModel.ToObject<GetObjectAclResponse>(TeaConverter.merge<object>(
                        new Dictionary<string, object>(){
                            {"AccessControlPolicy", respMap["AccessControlPolicy"]},
                        },
                        response_.Headers
                    ));
                } catch (Exception e) {
                    if (TeaCore.IsRetryable(e)) {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public PutBucketAclResponse PutBucketAcl(PutBucketAclRequest request, RuntimeObject runtime) {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>(){
                {"timeouted", "retry"},
                {"readTimeout", this._defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", this._defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", this._default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", this._default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", this._default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", this._default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", this._default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", this._default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", this._defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>(){
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", this._defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", this._default(runtime.BackoffPolicy, "no")},
                    {"period", this._defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((Dictionary<string, object>) runtime_["retry"], _retryTimes, _now)) {
                if (_retryTimes > 0) {
                    int backoffTime = TeaCore.GetBackoffTime((Dictionary<string, object>)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0) {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try {
                    TeaRequest request_ = new TeaRequest();
                    request_.Protocol = _protocol;
                    request_.Method = "PUT";
                    request_.Pathname = "/?acl";
                    request_.Headers = TeaConverter.merge<string>(
                        new Dictionary<string, string>(){
                            {"host", this._getHost(request.BucketName)},
                            {"date", this._getDate()},
                            {"user-agent", this._getUserAgent()},
                        },
                        this._toHeader(TeaModel.BuildMap(request.Header))
                    );
                    request_.Headers["authorization"] = this._getAuth(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    if (this._isFail(response_)) {
                        respMap = this._getErrMessage(response_);
                        throw new TeaException(new Dictionary<string, object>(){
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>(){
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    return TeaModel.ToObject<PutBucketAclResponse>(TeaConverter.merge<object>(
                        response_.Headers
                    ));
                } catch (Exception e) {
                    if (TeaCore.IsRetryable(e)) {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public DeleteBucketResponse DeleteBucket(DeleteBucketRequest request, RuntimeObject runtime) {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>(){
                {"timeouted", "retry"},
                {"readTimeout", this._defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", this._defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", this._default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", this._default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", this._default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", this._default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", this._default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", this._default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", this._defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>(){
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", this._defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", this._default(runtime.BackoffPolicy, "no")},
                    {"period", this._defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((Dictionary<string, object>) runtime_["retry"], _retryTimes, _now)) {
                if (_retryTimes > 0) {
                    int backoffTime = TeaCore.GetBackoffTime((Dictionary<string, object>)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0) {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try {
                    TeaRequest request_ = new TeaRequest();
                    request_.Protocol = _protocol;
                    request_.Method = "DELETE";
                    request_.Pathname = "/";
                    request_.Headers = new Dictionary<string, string>(){
                        {"host", this._getHost(request.BucketName)},
                        {"date", this._getDate()},
                        {"user-agent", this._getUserAgent()},
                    };
                    request_.Headers["authorization"] = this._getAuth(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    if (this._isFail(response_)) {
                        respMap = this._getErrMessage(response_);
                        throw new TeaException(new Dictionary<string, object>(){
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>(){
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    return TeaModel.ToObject<DeleteBucketResponse>(TeaConverter.merge<object>(
                        response_.Headers
                    ));
                } catch (Exception e) {
                    if (TeaCore.IsRetryable(e)) {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public PutObjectResponse PutObject(PutObjectRequest request, RuntimeObject runtime) {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>(){
                {"timeouted", "retry"},
                {"readTimeout", this._defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", this._defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", this._default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", this._default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", this._default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", this._default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", this._default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", this._default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", this._defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>(){
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", this._defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", this._default(runtime.BackoffPolicy, "no")},
                    {"period", this._defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((Dictionary<string, object>) runtime_["retry"], _retryTimes, _now)) {
                if (_retryTimes > 0) {
                    int backoffTime = TeaCore.GetBackoffTime((Dictionary<string, object>)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0) {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try {
                    TeaRequest request_ = new TeaRequest();
                    request_.Protocol = _protocol;
                    request_.Method = "PUT";
                    request_.Pathname = "/" + request.ObjectName;
                    request_.Headers = TeaConverter.merge<string>(
                        new Dictionary<string, string>(){
                            {"host", this._getHost(request.BucketName)},
                            {"date", this._getDate()},
                            {"user-agent", this._getUserAgent()},
                        },
                        this._toHeader(TeaModel.BuildMap(request.Header)),
                        this._parseMeta(request.UserMeta, "x-oss-meta-")
                    );
                    request_.Body = request.Body;
                    request_.Headers["content-type"] = this._default(this._getSpecialValue(TeaModel.BuildMap(request.Header), "content-type"), this._getContentType(request.ObjectName));
                    request_.Headers["authorization"] = this._getAuth(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    if (this._isFail(response_)) {
                        respMap = this._getErrMessage(response_);
                        throw new TeaException(new Dictionary<string, object>(){
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>(){
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    return TeaModel.ToObject<PutObjectResponse>(TeaConverter.merge<object>(
                        response_.Headers
                    ));
                } catch (Exception e) {
                    if (TeaCore.IsRetryable(e)) {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

    }
}
