
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using Tea;

using AlibabaCloud.OSS.Models;

namespace AlibabaCloud.OSS
{
    public class Client : BaseClient
    {

        public Client(Config config): base(config.ToMap())
        { }

        public PutBucketLifecycleResponse putBucketLifecycle(PutBucketLifecycleRequest request, RuntimeObject runtime) {
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
                    string token = this._getSecurityToken();
                    string reqBody = this._toXML(TeaModel.BuildMap(request.Body));
                    request_.Protocol = _protocol;
                    request_.Method = "PUT";
                    request_.Pathname = "/?lifecycle";
                    request_.Headers = new Dictionary<string, string>(){
                        {"host", this.getHost(request.BucketName)},
                        {"date", this._getDate()},
                        {"user-agent", this._getUserAgent()},
                    };
                    if (!this._empty(token)) {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Body = TeaCore.BytesReadable(reqBody);
                    request_.Headers["authorization"] = this.getSignature(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (this._isFail(response_)) {
                        bodyStr = this._readAsString(response_);
                        respMap = this._getErrMessage(bodyStr);
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
                    return TeaModel.ToObject<PutBucketLifecycleResponse>(TeaConverter.merge<object>(
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

        public DeleteMultipleObjectsResponse deleteMultipleObjects(DeleteMultipleObjectsRequest request, RuntimeObject runtime) {
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
                    string token = this._getSecurityToken();
                    string reqBody = this._toXML(TeaModel.BuildMap(request.Body));
                    request_.Protocol = _protocol;
                    request_.Method = "POST";
                    request_.Pathname = "/?delete";
                    request_.Headers = TeaConverter.merge<string>(
                        new Dictionary<string, string>(){
                            {"host", this.getHost(request.BucketName)},
                            {"date", this._getDate()},
                            {"user-agent", this._getUserAgent()},
                        },
                        this._toHeader(TeaModel.BuildMap(request.Header))
                    );
                    if (!this._empty(token)) {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Body = TeaCore.BytesReadable(reqBody);
                    if (this._notNull(TeaModel.BuildMap(request.Header)) && !this._empty(request.Header.ContentMD5)) {
                        request_.Headers["content-md5"] = request.Header.ContentMD5;
                    } else {
                        request_.Headers["content-md5"] = this._getContentMD5(reqBody);
                    }
                    request_.Headers["authorization"] = this.getSignature(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (this._isFail(response_)) {
                        bodyStr = this._readAsString(response_);
                        respMap = this._getErrMessage(bodyStr);
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
                    bodyStr = this._readAsString(response_);
                    respMap = this._parseXml(bodyStr, typeof(DeleteMultipleObjectsResponse));
                    return TeaModel.ToObject<DeleteMultipleObjectsResponse>(TeaConverter.merge<object>(
                        new Dictionary<string, object>(){
                            {"DeleteResult", respMap["DeleteResult"]},
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

        public PutBucketRefererResponse putBucketReferer(PutBucketRefererRequest request, RuntimeObject runtime) {
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
                    string token = this._getSecurityToken();
                    string reqBody = this._toXML(TeaModel.BuildMap(request.Body));
                    request_.Protocol = _protocol;
                    request_.Method = "PUT";
                    request_.Pathname = "/?referer";
                    request_.Headers = new Dictionary<string, string>(){
                        {"host", this.getHost(request.BucketName)},
                        {"date", this._getDate()},
                        {"user-agent", this._getUserAgent()},
                    };
                    if (!this._empty(token)) {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Body = TeaCore.BytesReadable(reqBody);
                    request_.Headers["authorization"] = this.getSignature(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (this._isFail(response_)) {
                        bodyStr = this._readAsString(response_);
                        respMap = this._getErrMessage(bodyStr);
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
                    return TeaModel.ToObject<PutBucketRefererResponse>(TeaConverter.merge<object>(
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

        public PutBucketWebsiteResponse putBucketWebsite(PutBucketWebsiteRequest request, RuntimeObject runtime) {
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
                    string token = this._getSecurityToken();
                    string reqBody = this._toXML(TeaModel.BuildMap(request.Body));
                    request_.Protocol = _protocol;
                    request_.Method = "PUT";
                    request_.Pathname = "/?website";
                    request_.Headers = new Dictionary<string, string>(){
                        {"host", this.getHost(request.BucketName)},
                        {"date", this._getDate()},
                        {"user-agent", this._getUserAgent()},
                    };
                    if (!this._empty(token)) {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Body = TeaCore.BytesReadable(reqBody);
                    request_.Headers["authorization"] = this.getSignature(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (this._isFail(response_)) {
                        bodyStr = this._readAsString(response_);
                        respMap = this._getErrMessage(bodyStr);
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
                    return TeaModel.ToObject<PutBucketWebsiteResponse>(TeaConverter.merge<object>(
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

        public CompleteMultipartUploadResponse completeMultipartUpload(CompleteMultipartUploadRequest request, RuntimeObject runtime) {
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
                    string token = this._getSecurityToken();
                    string reqBody = this._toXML(TeaModel.BuildMap(request.Body));
                    request_.Protocol = _protocol;
                    request_.Method = "POST";
                    request_.Pathname = "/" + request.ObjectName;
                    request_.Headers = new Dictionary<string, string>(){
                        {"host", this.getHost(request.BucketName)},
                        {"date", this._getDate()},
                        {"user-agent", this._getUserAgent()},
                    };
                    if (!this._empty(token)) {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Query = this._toQuery(TeaModel.BuildMap(request.Filter));
                    request_.Body = TeaCore.BytesReadable(reqBody);
                    request_.Headers["authorization"] = this.getSignature(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (this._isFail(response_)) {
                        bodyStr = this._readAsString(response_);
                        respMap = this._getErrMessage(bodyStr);
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
                    bodyStr = this._readAsString(response_);
                    respMap = this._parseXml(bodyStr, typeof(CompleteMultipartUploadResponse));
                    return TeaModel.ToObject<CompleteMultipartUploadResponse>(TeaConverter.merge<object>(
                        new Dictionary<string, object>(){
                            {"CompleteMultipartUploadResult", respMap["CompleteMultipartUploadResult"]},
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

        public PutBucketLoggingResponse putBucketLogging(PutBucketLoggingRequest request, RuntimeObject runtime) {
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
                    string token = this._getSecurityToken();
                    string reqBody = this._toXML(TeaModel.BuildMap(request.Body));
                    request_.Protocol = _protocol;
                    request_.Method = "PUT";
                    request_.Pathname = "/?logging";
                    request_.Headers = new Dictionary<string, string>(){
                        {"host", this.getHost(request.BucketName)},
                        {"date", this._getDate()},
                        {"user-agent", this._getUserAgent()},
                    };
                    if (!this._empty(token)) {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Body = TeaCore.BytesReadable(reqBody);
                    request_.Headers["authorization"] = this.getSignature(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (this._isFail(response_)) {
                        bodyStr = this._readAsString(response_);
                        respMap = this._getErrMessage(bodyStr);
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
                    return TeaModel.ToObject<PutBucketLoggingResponse>(TeaConverter.merge<object>(
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

        public PutBucketRequestPaymentResponse putBucketRequestPayment(PutBucketRequestPaymentRequest request, RuntimeObject runtime) {
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
                    string token = this._getSecurityToken();
                    string reqBody = this._toXML(TeaModel.BuildMap(request.Body));
                    request_.Protocol = _protocol;
                    request_.Method = "PUT";
                    request_.Pathname = "/?requestPayment";
                    request_.Headers = new Dictionary<string, string>(){
                        {"host", this.getHost(request.BucketName)},
                        {"date", this._getDate()},
                        {"user-agent", this._getUserAgent()},
                    };
                    if (!this._empty(token)) {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Body = TeaCore.BytesReadable(reqBody);
                    request_.Headers["authorization"] = this.getSignature(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (this._isFail(response_)) {
                        bodyStr = this._readAsString(response_);
                        respMap = this._getErrMessage(bodyStr);
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
                    return TeaModel.ToObject<PutBucketRequestPaymentResponse>(TeaConverter.merge<object>(
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

        public PutBucketEncryptionResponse putBucketEncryption(PutBucketEncryptionRequest request, RuntimeObject runtime) {
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
                    string token = this._getSecurityToken();
                    string reqBody = this._toXML(TeaModel.BuildMap(request.Body));
                    request_.Protocol = _protocol;
                    request_.Method = "PUT";
                    request_.Pathname = "/?encryption";
                    request_.Headers = new Dictionary<string, string>(){
                        {"host", this.getHost(request.BucketName)},
                        {"date", this._getDate()},
                        {"user-agent", this._getUserAgent()},
                    };
                    if (!this._empty(token)) {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Body = TeaCore.BytesReadable(reqBody);
                    request_.Headers["authorization"] = this.getSignature(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (this._isFail(response_)) {
                        bodyStr = this._readAsString(response_);
                        respMap = this._getErrMessage(bodyStr);
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
                    return TeaModel.ToObject<PutBucketEncryptionResponse>(TeaConverter.merge<object>(
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

        public PutLiveChannelResponse putLiveChannel(PutLiveChannelRequest request, RuntimeObject runtime) {
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
                    string token = this._getSecurityToken();
                    string reqBody = this._toXML(TeaModel.BuildMap(request.Body));
                    request_.Protocol = _protocol;
                    request_.Method = "PUT";
                    request_.Pathname = "/" + request.ChannelName + "?live";
                    request_.Headers = new Dictionary<string, string>(){
                        {"host", this.getHost(request.BucketName)},
                        {"date", this._getDate()},
                        {"user-agent", this._getUserAgent()},
                    };
                    if (!this._empty(token)) {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Body = TeaCore.BytesReadable(reqBody);
                    request_.Headers["authorization"] = this.getSignature(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (this._isFail(response_)) {
                        bodyStr = this._readAsString(response_);
                        respMap = this._getErrMessage(bodyStr);
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
                    bodyStr = this._readAsString(response_);
                    respMap = this._parseXml(bodyStr, typeof(PutLiveChannelResponse));
                    return TeaModel.ToObject<PutLiveChannelResponse>(TeaConverter.merge<object>(
                        new Dictionary<string, object>(){
                            {"CreateLiveChannelResult", respMap["CreateLiveChannelResult"]},
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

        public PutBucketTagsResponse putBucketTags(PutBucketTagsRequest request, RuntimeObject runtime) {
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
                    string token = this._getSecurityToken();
                    string reqBody = this._toXML(TeaModel.BuildMap(request.Body));
                    request_.Protocol = _protocol;
                    request_.Method = "PUT";
                    request_.Pathname = "/?tagging";
                    request_.Headers = new Dictionary<string, string>(){
                        {"host", this.getHost(request.BucketName)},
                        {"date", this._getDate()},
                        {"user-agent", this._getUserAgent()},
                    };
                    if (!this._empty(token)) {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Body = TeaCore.BytesReadable(reqBody);
                    request_.Headers["authorization"] = this.getSignature(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (this._isFail(response_)) {
                        bodyStr = this._readAsString(response_);
                        respMap = this._getErrMessage(bodyStr);
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
                    return TeaModel.ToObject<PutBucketTagsResponse>(TeaConverter.merge<object>(
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

        public PutObjectTaggingResponse putObjectTagging(PutObjectTaggingRequest request, RuntimeObject runtime) {
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
                    string token = this._getSecurityToken();
                    string reqBody = this._toXML(TeaModel.BuildMap(request.Body));
                    request_.Protocol = _protocol;
                    request_.Method = "PUT";
                    request_.Pathname = "/" + request.ObjectName + "?tagging";
                    request_.Headers = new Dictionary<string, string>(){
                        {"host", this.getHost(request.BucketName)},
                        {"date", this._getDate()},
                        {"user-agent", this._getUserAgent()},
                    };
                    if (!this._empty(token)) {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Body = TeaCore.BytesReadable(reqBody);
                    request_.Headers["authorization"] = this.getSignature(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (this._isFail(response_)) {
                        bodyStr = this._readAsString(response_);
                        respMap = this._getErrMessage(bodyStr);
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
                    return TeaModel.ToObject<PutObjectTaggingResponse>(TeaConverter.merge<object>(
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

        public SelectObjectResponse selectObject(SelectObjectRequest request, RuntimeObject runtime) {
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
                    string token = this._getSecurityToken();
                    string reqBody = this._toXML(TeaModel.BuildMap(request.Body));
                    request_.Protocol = _protocol;
                    request_.Method = "POST";
                    request_.Pathname = "/" + request.ObjectName;
                    request_.Headers = new Dictionary<string, string>(){
                        {"host", this.getHost(request.BucketName)},
                        {"date", this._getDate()},
                        {"user-agent", this._getUserAgent()},
                    };
                    if (!this._empty(token)) {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Query = this._toQuery(TeaModel.BuildMap(request.Filter));
                    request_.Body = TeaCore.BytesReadable(reqBody);
                    request_.Headers["authorization"] = this.getSignature(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (this._isFail(response_)) {
                        bodyStr = this._readAsString(response_);
                        respMap = this._getErrMessage(bodyStr);
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
                    return TeaModel.ToObject<SelectObjectResponse>(TeaConverter.merge<object>(
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

        public PutBucketCORSResponse putBucketCORS(PutBucketCORSRequest request, RuntimeObject runtime) {
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
                    string token = this._getSecurityToken();
                    string reqBody = this._toXML(TeaModel.BuildMap(request.Body));
                    request_.Protocol = _protocol;
                    request_.Method = "PUT";
                    request_.Pathname = "/?cors";
                    request_.Headers = new Dictionary<string, string>(){
                        {"host", this.getHost(request.BucketName)},
                        {"date", this._getDate()},
                        {"user-agent", this._getUserAgent()},
                    };
                    if (!this._empty(token)) {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Body = TeaCore.BytesReadable(reqBody);
                    request_.Headers["authorization"] = this.getSignature(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (this._isFail(response_)) {
                        bodyStr = this._readAsString(response_);
                        respMap = this._getErrMessage(bodyStr);
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
                    return TeaModel.ToObject<PutBucketCORSResponse>(TeaConverter.merge<object>(
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

        public PutBucketResponse putBucket(PutBucketRequest request, RuntimeObject runtime) {
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
                    string token = this._getSecurityToken();
                    string reqBody = this._toXML(TeaModel.BuildMap(request.Body));
                    request_.Protocol = _protocol;
                    request_.Method = "PUT";
                    request_.Pathname = "/";
                    request_.Headers = TeaConverter.merge<string>(
                        new Dictionary<string, string>(){
                            {"host", this.getHost(request.BucketName)},
                            {"date", this._getDate()},
                            {"user-agent", this._getUserAgent()},
                        },
                        this._toHeader(TeaModel.BuildMap(request.Header))
                    );
                    if (!this._empty(token)) {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Body = TeaCore.BytesReadable(reqBody);
                    request_.Headers["authorization"] = this.getSignature(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (this._isFail(response_)) {
                        bodyStr = this._readAsString(response_);
                        respMap = this._getErrMessage(bodyStr);
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
                    return TeaModel.ToObject<PutBucketResponse>(TeaConverter.merge<object>(
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

        public ListMultipartUploadsResponse listMultipartUploads(ListMultipartUploadsRequest request, RuntimeObject runtime) {
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
                    string token = this._getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/?uploads";
                    request_.Headers = new Dictionary<string, string>(){
                        {"host", this.getHost(request.BucketName)},
                        {"date", this._getDate()},
                        {"user-agent", this._getUserAgent()},
                    };
                    if (!this._empty(token)) {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Query = this._toQuery(TeaModel.BuildMap(request.Filter));
                    request_.Headers["authorization"] = this.getSignature(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (this._isFail(response_)) {
                        bodyStr = this._readAsString(response_);
                        respMap = this._getErrMessage(bodyStr);
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
                    bodyStr = this._readAsString(response_);
                    respMap = this._parseXml(bodyStr, typeof(ListMultipartUploadsResponse));
                    return TeaModel.ToObject<ListMultipartUploadsResponse>(TeaConverter.merge<object>(
                        new Dictionary<string, object>(){
                            {"ListMultipartUploadsResult", respMap["ListMultipartUploadsResult"]},
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

        public GetBucketRequestPaymentResponse getBucketRequestPayment(GetBucketRequestPaymentRequest request, RuntimeObject runtime) {
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
                    string token = this._getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/?requestPayment";
                    request_.Headers = new Dictionary<string, string>(){
                        {"host", this.getHost(request.BucketName)},
                        {"date", this._getDate()},
                        {"user-agent", this._getUserAgent()},
                    };
                    if (!this._empty(token)) {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = this.getSignature(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (this._isFail(response_)) {
                        bodyStr = this._readAsString(response_);
                        respMap = this._getErrMessage(bodyStr);
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
                    bodyStr = this._readAsString(response_);
                    respMap = this._parseXml(bodyStr, typeof(GetBucketRequestPaymentResponse));
                    return TeaModel.ToObject<GetBucketRequestPaymentResponse>(TeaConverter.merge<object>(
                        new Dictionary<string, object>(){
                            {"RequestPaymentConfiguration", respMap["RequestPaymentConfiguration"]},
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

        public GetBucketEncryptionResponse getBucketEncryption(GetBucketEncryptionRequest request, RuntimeObject runtime) {
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
                    string token = this._getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/?encryption";
                    request_.Headers = new Dictionary<string, string>(){
                        {"host", this.getHost(request.BucketName)},
                        {"date", this._getDate()},
                        {"user-agent", this._getUserAgent()},
                    };
                    if (!this._empty(token)) {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = this.getSignature(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (this._isFail(response_)) {
                        bodyStr = this._readAsString(response_);
                        respMap = this._getErrMessage(bodyStr);
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
                    bodyStr = this._readAsString(response_);
                    respMap = this._parseXml(bodyStr, typeof(GetBucketEncryptionResponse));
                    return TeaModel.ToObject<GetBucketEncryptionResponse>(TeaConverter.merge<object>(
                        new Dictionary<string, object>(){
                            {"ServerSideEncryptionRule", respMap["ServerSideEncryptionRule"]},
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

        public GetBucketTagsResponse getBucketTags(GetBucketTagsRequest request, RuntimeObject runtime) {
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
                    string token = this._getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/?tagging";
                    request_.Headers = new Dictionary<string, string>(){
                        {"host", this.getHost(request.BucketName)},
                        {"date", this._getDate()},
                        {"user-agent", this._getUserAgent()},
                    };
                    if (!this._empty(token)) {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = this.getSignature(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (this._isFail(response_)) {
                        bodyStr = this._readAsString(response_);
                        respMap = this._getErrMessage(bodyStr);
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
                    bodyStr = this._readAsString(response_);
                    respMap = this._parseXml(bodyStr, typeof(GetBucketTagsResponse));
                    return TeaModel.ToObject<GetBucketTagsResponse>(TeaConverter.merge<object>(
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

        public GetServiceResponse getService(GetServiceRequest request, RuntimeObject runtime) {
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
                    string token = this._getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/";
                    request_.Headers = new Dictionary<string, string>(){
                        {"host", this.getHost("")},
                        {"date", this._getDate()},
                        {"user-agent", this._getUserAgent()},
                    };
                    if (!this._empty(token)) {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Query = this._toQuery(TeaModel.BuildMap(request.Filter));
                    request_.Headers["authorization"] = this.getSignature(request_, "");
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (this._isFail(response_)) {
                        bodyStr = this._readAsString(response_);
                        respMap = this._getErrMessage(bodyStr);
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
                    bodyStr = this._readAsString(response_);
                    respMap = this._parseXml(bodyStr, typeof(GetServiceResponse));
                    return TeaModel.ToObject<GetServiceResponse>(TeaConverter.merge<object>(
                        new Dictionary<string, object>(){
                            {"ListAllMyBucketsResult", respMap["ListAllMyBucketsResult"]},
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

        public DeleteBucketEncryptionResponse deleteBucketEncryption(DeleteBucketEncryptionRequest request, RuntimeObject runtime) {
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
                    string token = this._getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "DELETE";
                    request_.Pathname = "/?encryption";
                    request_.Headers = new Dictionary<string, string>(){
                        {"host", this.getHost(request.BucketName)},
                        {"date", this._getDate()},
                        {"user-agent", this._getUserAgent()},
                    };
                    if (!this._empty(token)) {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = this.getSignature(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (this._isFail(response_)) {
                        bodyStr = this._readAsString(response_);
                        respMap = this._getErrMessage(bodyStr);
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
                    return TeaModel.ToObject<DeleteBucketEncryptionResponse>(TeaConverter.merge<object>(
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

        public DeleteBucketTagsResponse deleteBucketTags(DeleteBucketTagsRequest request, RuntimeObject runtime) {
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
                    string token = this._getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "DELETE";
                    request_.Pathname = "/";
                    request_.Headers = new Dictionary<string, string>(){
                        {"host", this.getHost(request.BucketName)},
                        {"date", this._getDate()},
                        {"user-agent", this._getUserAgent()},
                    };
                    if (!this._empty(token)) {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Query = this._toQuery(TeaModel.BuildMap(request.Filter));
                    request_.Headers["authorization"] = this.getSignature(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (this._isFail(response_)) {
                        bodyStr = this._readAsString(response_);
                        respMap = this._getErrMessage(bodyStr);
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
                    return TeaModel.ToObject<DeleteBucketTagsResponse>(TeaConverter.merge<object>(
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

        public GetBucketWebsiteResponse getBucketWebsite(GetBucketWebsiteRequest request, RuntimeObject runtime) {
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
                    string token = this._getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/?website";
                    request_.Headers = new Dictionary<string, string>(){
                        {"host", this.getHost(request.BucketName)},
                        {"date", this._getDate()},
                        {"user-agent", this._getUserAgent()},
                    };
                    if (!this._empty(token)) {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = this.getSignature(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (this._isFail(response_)) {
                        bodyStr = this._readAsString(response_);
                        respMap = this._getErrMessage(bodyStr);
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
                    bodyStr = this._readAsString(response_);
                    respMap = this._parseXml(bodyStr, typeof(GetBucketWebsiteResponse));
                    return TeaModel.ToObject<GetBucketWebsiteResponse>(TeaConverter.merge<object>(
                        new Dictionary<string, object>(){
                            {"WebsiteConfiguration", respMap["WebsiteConfiguration"]},
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

        public DeleteLiveChannelResponse deleteLiveChannel(DeleteLiveChannelRequest request, RuntimeObject runtime) {
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
                    string token = this._getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "DELETE";
                    request_.Pathname = "/" + request.ChannelName + "?live";
                    request_.Headers = new Dictionary<string, string>(){
                        {"host", this.getHost(request.BucketName)},
                        {"date", this._getDate()},
                        {"user-agent", this._getUserAgent()},
                    };
                    if (!this._empty(token)) {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = this.getSignature(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (this._isFail(response_)) {
                        bodyStr = this._readAsString(response_);
                        respMap = this._getErrMessage(bodyStr);
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

        public GetBucketLocationResponse getBucketLocation(GetBucketLocationRequest request, RuntimeObject runtime) {
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
                    string token = this._getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/?location";
                    request_.Headers = new Dictionary<string, string>(){
                        {"host", this.getHost(request.BucketName)},
                        {"date", this._getDate()},
                        {"user-agent", this._getUserAgent()},
                    };
                    if (!this._empty(token)) {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = this.getSignature(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (this._isFail(response_)) {
                        bodyStr = this._readAsString(response_);
                        respMap = this._getErrMessage(bodyStr);
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
                    bodyStr = this._readAsString(response_);
                    respMap = this._parseXml(bodyStr, typeof(GetBucketLocationResponse));
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

        public ListLiveChannelResponse listLiveChannel(ListLiveChannelRequest request, RuntimeObject runtime) {
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
                    string token = this._getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/?live";
                    request_.Headers = new Dictionary<string, string>(){
                        {"host", this.getHost(request.BucketName)},
                        {"date", this._getDate()},
                        {"user-agent", this._getUserAgent()},
                    };
                    if (!this._empty(token)) {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Query = this._toQuery(TeaModel.BuildMap(request.Filter));
                    request_.Headers["authorization"] = this.getSignature(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (this._isFail(response_)) {
                        bodyStr = this._readAsString(response_);
                        respMap = this._getErrMessage(bodyStr);
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
                    bodyStr = this._readAsString(response_);
                    respMap = this._parseXml(bodyStr, typeof(ListLiveChannelResponse));
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

        public GetObjectMetaResponse getObjectMeta(GetObjectMetaRequest request, RuntimeObject runtime) {
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
                    string token = this._getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "HEAD";
                    request_.Pathname = "/" + request.ObjectName + "?objectMeta";
                    request_.Headers = new Dictionary<string, string>(){
                        {"host", this.getHost(request.BucketName)},
                        {"date", this._getDate()},
                        {"user-agent", this._getUserAgent()},
                    };
                    if (!this._empty(token)) {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = this.getSignature(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (this._isFail(response_)) {
                        bodyStr = this._readAsString(response_);
                        respMap = this._getErrMessage(bodyStr);
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

        public GetBucketAclResponse getBucketAcl(GetBucketAclRequest request, RuntimeObject runtime) {
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
                    string token = this._getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/?acl";
                    request_.Headers = new Dictionary<string, string>(){
                        {"host", this.getHost(request.BucketName)},
                        {"date", this._getDate()},
                        {"user-agent", this._getUserAgent()},
                    };
                    if (!this._empty(token)) {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = this.getSignature(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (this._isFail(response_)) {
                        bodyStr = this._readAsString(response_);
                        respMap = this._getErrMessage(bodyStr);
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
                    bodyStr = this._readAsString(response_);
                    respMap = this._parseXml(bodyStr, typeof(GetBucketAclResponse));
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

        public ListPartsResponse listParts(ListPartsRequest request, RuntimeObject runtime) {
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
                    string token = this._getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/" + request.ObjectName;
                    request_.Headers = new Dictionary<string, string>(){
                        {"host", this.getHost(request.BucketName)},
                        {"date", this._getDate()},
                        {"user-agent", this._getUserAgent()},
                    };
                    if (!this._empty(token)) {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Query = this._toQuery(TeaModel.BuildMap(request.Filter));
                    request_.Headers["authorization"] = this.getSignature(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (this._isFail(response_)) {
                        bodyStr = this._readAsString(response_);
                        respMap = this._getErrMessage(bodyStr);
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
                    bodyStr = this._readAsString(response_);
                    respMap = this._parseXml(bodyStr, typeof(ListPartsResponse));
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

        public GetLiveChannelHistoryResponse getLiveChannelHistory(GetLiveChannelHistoryRequest request, RuntimeObject runtime) {
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
                    string token = this._getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/" + request.ChannelName + "?live";
                    request_.Headers = new Dictionary<string, string>(){
                        {"host", this.getHost(request.BucketName)},
                        {"date", this._getDate()},
                        {"user-agent", this._getUserAgent()},
                    };
                    if (!this._empty(token)) {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Query = this._toQuery(TeaModel.BuildMap(request.Filter));
                    request_.Headers["authorization"] = this.getSignature(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (this._isFail(response_)) {
                        bodyStr = this._readAsString(response_);
                        respMap = this._getErrMessage(bodyStr);
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
                    bodyStr = this._readAsString(response_);
                    respMap = this._parseXml(bodyStr, typeof(GetLiveChannelHistoryResponse));
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

        public GetBucketResponse getBucket(GetBucketRequest request, RuntimeObject runtime) {
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
                    string token = this._getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/";
                    request_.Headers = new Dictionary<string, string>(){
                        {"host", this.getHost(request.BucketName)},
                        {"date", this._getDate()},
                        {"user-agent", this._getUserAgent()},
                    };
                    if (!this._empty(token)) {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Query = this._toQuery(TeaModel.BuildMap(request.Filter));
                    request_.Headers["authorization"] = this.getSignature(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (this._isFail(response_)) {
                        bodyStr = this._readAsString(response_);
                        respMap = this._getErrMessage(bodyStr);
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
                    bodyStr = this._readAsString(response_);
                    respMap = this._parseXml(bodyStr, typeof(GetBucketResponse));
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

        public GetLiveChannelInfoResponse getLiveChannelInfo(GetLiveChannelInfoRequest request, RuntimeObject runtime) {
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
                    string token = this._getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/" + request.ChannelName + "?live";
                    request_.Headers = new Dictionary<string, string>(){
                        {"host", this.getHost(request.BucketName)},
                        {"date", this._getDate()},
                        {"user-agent", this._getUserAgent()},
                    };
                    if (!this._empty(token)) {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = this.getSignature(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (this._isFail(response_)) {
                        bodyStr = this._readAsString(response_);
                        respMap = this._getErrMessage(bodyStr);
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
                    bodyStr = this._readAsString(response_);
                    respMap = this._parseXml(bodyStr, typeof(GetLiveChannelInfoResponse));
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

        public GetLiveChannelStatResponse getLiveChannelStat(GetLiveChannelStatRequest request, RuntimeObject runtime) {
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
                    string token = this._getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/" + request.ChannelName + "?live";
                    request_.Headers = new Dictionary<string, string>(){
                        {"host", this.getHost(request.BucketName)},
                        {"date", this._getDate()},
                        {"user-agent", this._getUserAgent()},
                    };
                    if (!this._empty(token)) {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Query = this._toQuery(TeaModel.BuildMap(request.Filter));
                    request_.Headers["authorization"] = this.getSignature(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (this._isFail(response_)) {
                        bodyStr = this._readAsString(response_);
                        respMap = this._getErrMessage(bodyStr);
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
                    bodyStr = this._readAsString(response_);
                    respMap = this._parseXml(bodyStr, typeof(GetLiveChannelStatResponse));
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

        public DeleteObjectResponse deleteObject(DeleteObjectRequest request, RuntimeObject runtime) {
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
                    string token = this._getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "DELETE";
                    request_.Pathname = "/" + request.ObjectName;
                    request_.Headers = new Dictionary<string, string>(){
                        {"host", this.getHost(request.BucketName)},
                        {"date", this._getDate()},
                        {"user-agent", this._getUserAgent()},
                    };
                    if (!this._empty(token)) {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = this.getSignature(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (this._isFail(response_)) {
                        bodyStr = this._readAsString(response_);
                        respMap = this._getErrMessage(bodyStr);
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

        public AbortMultipartUploadResponse abortMultipartUpload(AbortMultipartUploadRequest request, RuntimeObject runtime) {
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
                    string token = this._getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "DELETE";
                    request_.Pathname = "/" + request.ObjectName;
                    request_.Headers = new Dictionary<string, string>(){
                        {"host", this.getHost(request.BucketName)},
                        {"date", this._getDate()},
                        {"user-agent", this._getUserAgent()},
                    };
                    if (!this._empty(token)) {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Query = this._toQuery(TeaModel.BuildMap(request.Filter));
                    request_.Headers["authorization"] = this.getSignature(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (this._isFail(response_)) {
                        bodyStr = this._readAsString(response_);
                        respMap = this._getErrMessage(bodyStr);
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

        public AppendObjectResponse appendObject(AppendObjectRequest request, RuntimeObject runtime) {
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
                    Dictionary<string, string> ctx = new Dictionary<string, string>(){};
                    string token = this._getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "POST";
                    request_.Pathname = "/" + request.ObjectName + "?append";
                    request_.Headers = TeaConverter.merge<string>(
                        new Dictionary<string, string>(){
                            {"host", this.getHost(request.BucketName)},
                            {"date", this._getDate()},
                            {"user-agent", this._getUserAgent()},
                        },
                        this._toHeader(TeaModel.BuildMap(request.Header)),
                        this._parseMeta(request.UserMeta, "x-oss-meta-")
                    );
                    if (!this._empty(token)) {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Query = this._toQuery(TeaModel.BuildMap(request.Filter));
                    request_.Body = this._inject(request.Body, ctx);
                    if (this._notNull(TeaModel.BuildMap(request.Header)) && !this._empty(request.Header.ContentType)) {
                        request_.Headers["content-type"] = request.Header.ContentType;
                    } else {
                        request_.Headers["content-type"] = this._getContentType(request.ObjectName);
                    }
                    request_.Headers["authorization"] = this.getSignature(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (this._isFail(response_)) {
                        bodyStr = this._readAsString(response_);
                        respMap = this._getErrMessage(bodyStr);
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
                    if (_isEnableCrc && !this._equal(ctx["crc"], response_.Headers["x-oss-hash-crc64ecma"])) {
                        throw new TeaException(new Dictionary<string, object>(){
                            {"code", "CrcNotMatched"},
                            {"data", new Dictionary<string, object>(){
                                {"clientCrc", ctx["crc"]},
                                {"serverCrc", response_.Headers["x-oss-hash-crc64ecma"]},
                            }},
                        });
                    }                    
                    if (_isEnableMD5 && !this._equal(ctx["md5"], response_.Headers["content-md5"])) {
                        throw new TeaException(new Dictionary<string, object>(){
                            {"code", "MD5NotMatched"},
                            {"data", new Dictionary<string, object>(){
                                {"clientMD5", ctx["md5"]},
                                {"serverMD5", response_.Headers["content-md5"]},
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

        public UploadPartCopyResponse uploadPartCopy(UploadPartCopyRequest request, RuntimeObject runtime) {
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
                    string token = this._getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "PUT";
                    request_.Pathname = "/" + request.ObjectName;
                    request_.Headers = TeaConverter.merge<string>(
                        new Dictionary<string, string>(){
                            {"host", this.getHost(request.BucketName)},
                            {"date", this._getDate()},
                            {"user-agent", this._getUserAgent()},
                        },
                        this._toHeader(TeaModel.BuildMap(request.Header))
                    );
                    if (!this._empty(token)) {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Query = this._toQuery(TeaModel.BuildMap(request.Filter));
                    request_.Headers["authorization"] = this.getSignature(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (this._isFail(response_)) {
                        bodyStr = this._readAsString(response_);
                        respMap = this._getErrMessage(bodyStr);
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
                    bodyStr = this._readAsString(response_);
                    respMap = this._parseXml(bodyStr, typeof(UploadPartCopyResponse));
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

        public GetVodPlaylistResponse getVodPlaylist(GetVodPlaylistRequest request, RuntimeObject runtime) {
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
                    string token = this._getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/" + request.ChannelName + "?vod";
                    request_.Headers = new Dictionary<string, string>(){
                        {"host", this.getHost(request.BucketName)},
                        {"date", this._getDate()},
                        {"user-agent", this._getUserAgent()},
                    };
                    if (!this._empty(token)) {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Query = this._toQuery(TeaModel.BuildMap(request.Filter));
                    request_.Headers["authorization"] = this.getSignature(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (this._isFail(response_)) {
                        bodyStr = this._readAsString(response_);
                        respMap = this._getErrMessage(bodyStr);
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

        public DeleteBucketCORSResponse deleteBucketCORS(DeleteBucketCORSRequest request, RuntimeObject runtime) {
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
                    string token = this._getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "DELETE";
                    request_.Pathname = "/?cors";
                    request_.Headers = new Dictionary<string, string>(){
                        {"host", this.getHost(request.BucketName)},
                        {"date", this._getDate()},
                        {"user-agent", this._getUserAgent()},
                    };
                    if (!this._empty(token)) {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = this.getSignature(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (this._isFail(response_)) {
                        bodyStr = this._readAsString(response_);
                        respMap = this._getErrMessage(bodyStr);
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

        public GetObjectResponse getObject(GetObjectRequest request, RuntimeObject runtime) {
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
                    string token = this._getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/" + request.ObjectName;
                    request_.Headers = TeaConverter.merge<string>(
                        new Dictionary<string, string>(){
                            {"host", this.getHost(request.BucketName)},
                            {"date", this._getDate()},
                            {"user-agent", this._getUserAgent()},
                        },
                        this._toHeader(TeaModel.BuildMap(request.Header))
                    );
                    if (!this._empty(token)) {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = this.getSignature(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (this._isFail(response_)) {
                        bodyStr = this._readAsString(response_);
                        respMap = this._getErrMessage(bodyStr);
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

        public UploadPartResponse uploadPart(UploadPartRequest request, RuntimeObject runtime) {
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
                    Dictionary<string, string> ctx = new Dictionary<string, string>(){};
                    string token = this._getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "PUT";
                    request_.Pathname = "/" + request.ObjectName;
                    request_.Headers = new Dictionary<string, string>(){
                        {"host", this.getHost(request.BucketName)},
                        {"date", this._getDate()},
                        {"user-agent", this._getUserAgent()},
                    };
                    if (!this._empty(token)) {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Query = this._toQuery(TeaModel.BuildMap(request.Filter));
                    request_.Body = this._inject(request.Body, ctx);
                    request_.Headers["authorization"] = this.getSignature(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (this._isFail(response_)) {
                        bodyStr = this._readAsString(response_);
                        respMap = this._getErrMessage(bodyStr);
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
                    if (_isEnableCrc && !this._equal(ctx["crc"], response_.Headers["x-oss-hash-crc64ecma"])) {
                        throw new TeaException(new Dictionary<string, object>(){
                            {"code", "CrcNotMatched"},
                            {"data", new Dictionary<string, object>(){
                                {"clientCrc", ctx["crc"]},
                                {"serverCrc", response_.Headers["x-oss-hash-crc64ecma"]},
                            }},
                        });
                    }                    
                    if (_isEnableMD5 && !this._equal(ctx["md5"], response_.Headers["content-md5"])) {
                        throw new TeaException(new Dictionary<string, object>(){
                            {"code", "MD5NotMatched"},
                            {"data", new Dictionary<string, object>(){
                                {"clientMD5", ctx["md5"]},
                                {"serverMD5", response_.Headers["content-md5"]},
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

        public GetBucketCORSResponse getBucketCORS(GetBucketCORSRequest request, RuntimeObject runtime) {
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
                    string token = this._getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/?cors";
                    request_.Headers = new Dictionary<string, string>(){
                        {"host", this.getHost(request.BucketName)},
                        {"date", this._getDate()},
                        {"user-agent", this._getUserAgent()},
                    };
                    if (!this._empty(token)) {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = this.getSignature(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (this._isFail(response_)) {
                        bodyStr = this._readAsString(response_);
                        respMap = this._getErrMessage(bodyStr);
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
                    bodyStr = this._readAsString(response_);
                    respMap = this._parseXml(bodyStr, typeof(GetBucketCORSResponse));
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

        public CopyObjectResponse copyObject(CopyObjectRequest request, RuntimeObject runtime) {
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
                    string token = this._getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "PUT";
                    request_.Pathname = "/" + request.DestObjectName;
                    request_.Headers = TeaConverter.merge<string>(
                        new Dictionary<string, string>(){
                            {"host", this.getHost(request.BucketName)},
                            {"date", this._getDate()},
                            {"user-agent", this._getUserAgent()},
                        },
                        this._toHeader(TeaModel.BuildMap(request.Header))
                    );
                    if (!this._empty(token)) {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["x-oss-copy-source"] = this._encode(request_.Headers["x-oss-copy-source"], "UrlEncode");
                    request_.Headers["authorization"] = this.getSignature(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (this._isFail(response_)) {
                        bodyStr = this._readAsString(response_);
                        respMap = this._getErrMessage(bodyStr);
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
                    bodyStr = this._readAsString(response_);
                    respMap = this._parseXml(bodyStr, typeof(CopyObjectResponse));
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

        public GetObjectTaggingResponse getObjectTagging(GetObjectTaggingRequest request, RuntimeObject runtime) {
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
                    string token = this._getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/" + request.ObjectName + "?tagging";
                    request_.Headers = new Dictionary<string, string>(){
                        {"host", this.getHost(request.BucketName)},
                        {"date", this._getDate()},
                        {"user-agent", this._getUserAgent()},
                    };
                    if (!this._empty(token)) {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = this.getSignature(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (this._isFail(response_)) {
                        bodyStr = this._readAsString(response_);
                        respMap = this._getErrMessage(bodyStr);
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
                    bodyStr = this._readAsString(response_);
                    respMap = this._parseXml(bodyStr, typeof(GetObjectTaggingResponse));
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

        public DeleteBucketLifecycleResponse deleteBucketLifecycle(DeleteBucketLifecycleRequest request, RuntimeObject runtime) {
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
                    string token = this._getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "DELETE";
                    request_.Pathname = "/?lifecycle";
                    request_.Headers = new Dictionary<string, string>(){
                        {"host", this.getHost(request.BucketName)},
                        {"date", this._getDate()},
                        {"user-agent", this._getUserAgent()},
                    };
                    if (!this._empty(token)) {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = this.getSignature(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (this._isFail(response_)) {
                        bodyStr = this._readAsString(response_);
                        respMap = this._getErrMessage(bodyStr);
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

        public DeleteBucketLoggingResponse deleteBucketLogging(DeleteBucketLoggingRequest request, RuntimeObject runtime) {
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
                    string token = this._getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "DELETE";
                    request_.Pathname = "/?logging";
                    request_.Headers = new Dictionary<string, string>(){
                        {"host", this.getHost(request.BucketName)},
                        {"date", this._getDate()},
                        {"user-agent", this._getUserAgent()},
                    };
                    if (!this._empty(token)) {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = this.getSignature(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (this._isFail(response_)) {
                        bodyStr = this._readAsString(response_);
                        respMap = this._getErrMessage(bodyStr);
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

        public DeleteBucketWebsiteResponse deleteBucketWebsite(DeleteBucketWebsiteRequest request, RuntimeObject runtime) {
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
                    string token = this._getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "DELETE";
                    request_.Pathname = "/?website";
                    request_.Headers = new Dictionary<string, string>(){
                        {"host", this.getHost(request.BucketName)},
                        {"date", this._getDate()},
                        {"user-agent", this._getUserAgent()},
                    };
                    if (!this._empty(token)) {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = this.getSignature(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (this._isFail(response_)) {
                        bodyStr = this._readAsString(response_);
                        respMap = this._getErrMessage(bodyStr);
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

        public GetSymlinkResponse getSymlink(GetSymlinkRequest request, RuntimeObject runtime) {
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
                    string token = this._getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/" + request.ObjectName + "?symlink";
                    request_.Headers = new Dictionary<string, string>(){
                        {"host", this.getHost(request.BucketName)},
                        {"date", this._getDate()},
                        {"user-agent", this._getUserAgent()},
                    };
                    if (!this._empty(token)) {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = this.getSignature(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (this._isFail(response_)) {
                        bodyStr = this._readAsString(response_);
                        respMap = this._getErrMessage(bodyStr);
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

        public GetBucketLifecycleResponse getBucketLifecycle(GetBucketLifecycleRequest request, RuntimeObject runtime) {
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
                    string token = this._getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/?lifecycle";
                    request_.Headers = new Dictionary<string, string>(){
                        {"host", this.getHost(request.BucketName)},
                        {"date", this._getDate()},
                        {"user-agent", this._getUserAgent()},
                    };
                    if (!this._empty(token)) {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = this.getSignature(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (this._isFail(response_)) {
                        bodyStr = this._readAsString(response_);
                        respMap = this._getErrMessage(bodyStr);
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
                    bodyStr = this._readAsString(response_);
                    respMap = this._parseXml(bodyStr, typeof(GetBucketLifecycleResponse));
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

        public PutSymlinkResponse putSymlink(PutSymlinkRequest request, RuntimeObject runtime) {
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
                    string token = this._getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "PUT";
                    request_.Pathname = "/" + request.ObjectName + "?symlink";
                    request_.Headers = TeaConverter.merge<string>(
                        new Dictionary<string, string>(){
                            {"host", this.getHost(request.BucketName)},
                            {"date", this._getDate()},
                            {"user-agent", this._getUserAgent()},
                        },
                        this._toHeader(TeaModel.BuildMap(request.Header))
                    );
                    if (!this._empty(token)) {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = this.getSignature(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (this._isFail(response_)) {
                        bodyStr = this._readAsString(response_);
                        respMap = this._getErrMessage(bodyStr);
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

        public GetBucketRefererResponse getBucketReferer(GetBucketRefererRequest request, RuntimeObject runtime) {
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
                    string token = this._getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/?referer";
                    request_.Headers = new Dictionary<string, string>(){
                        {"host", this.getHost(request.BucketName)},
                        {"date", this._getDate()},
                        {"user-agent", this._getUserAgent()},
                    };
                    if (!this._empty(token)) {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = this.getSignature(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (this._isFail(response_)) {
                        bodyStr = this._readAsString(response_);
                        respMap = this._getErrMessage(bodyStr);
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
                    bodyStr = this._readAsString(response_);
                    respMap = this._parseXml(bodyStr, typeof(GetBucketRefererResponse));
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

        public CallbackResponse callback(CallbackRequest request, RuntimeObject runtime) {
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
                    string token = this._getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/";
                    request_.Headers = new Dictionary<string, string>(){
                        {"host", this.getHost(request.BucketName)},
                        {"date", this._getDate()},
                        {"user-agent", this._getUserAgent()},
                    };
                    if (!this._empty(token)) {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = this.getSignature(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (this._isFail(response_)) {
                        bodyStr = this._readAsString(response_);
                        respMap = this._getErrMessage(bodyStr);
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

        public GetBucketLoggingResponse getBucketLogging(GetBucketLoggingRequest request, RuntimeObject runtime) {
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
                    string token = this._getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/?logging";
                    request_.Headers = new Dictionary<string, string>(){
                        {"host", this.getHost(request.BucketName)},
                        {"date", this._getDate()},
                        {"user-agent", this._getUserAgent()},
                    };
                    if (!this._empty(token)) {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = this.getSignature(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (this._isFail(response_)) {
                        bodyStr = this._readAsString(response_);
                        respMap = this._getErrMessage(bodyStr);
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
                    bodyStr = this._readAsString(response_);
                    respMap = this._parseXml(bodyStr, typeof(GetBucketLoggingResponse));
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

        public PutObjectAclResponse putObjectAcl(PutObjectAclRequest request, RuntimeObject runtime) {
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
                    string token = this._getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "PUT";
                    request_.Pathname = "/" + request.ObjectName + "?acl";
                    request_.Headers = TeaConverter.merge<string>(
                        new Dictionary<string, string>(){
                            {"host", this.getHost(request.BucketName)},
                            {"date", this._getDate()},
                            {"user-agent", this._getUserAgent()},
                        },
                        this._toHeader(TeaModel.BuildMap(request.Header))
                    );
                    if (!this._empty(token)) {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = this.getSignature(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (this._isFail(response_)) {
                        bodyStr = this._readAsString(response_);
                        respMap = this._getErrMessage(bodyStr);
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

        public GetBucketInfoResponse getBucketInfo(GetBucketInfoRequest request, RuntimeObject runtime) {
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
                    string token = this._getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/?bucketInfo";
                    request_.Headers = new Dictionary<string, string>(){
                        {"host", this.getHost(request.BucketName)},
                        {"date", this._getDate()},
                        {"user-agent", this._getUserAgent()},
                    };
                    if (!this._empty(token)) {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = this.getSignature(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (this._isFail(response_)) {
                        bodyStr = this._readAsString(response_);
                        respMap = this._getErrMessage(bodyStr);
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
                    bodyStr = this._readAsString(response_);
                    respMap = this._parseXml(bodyStr, typeof(GetBucketInfoResponse));
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

        public PutLiveChannelStatusResponse putLiveChannelStatus(PutLiveChannelStatusRequest request, RuntimeObject runtime) {
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
                    string token = this._getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "PUT";
                    request_.Pathname = "/" + request.ChannelName + "?live";
                    request_.Headers = new Dictionary<string, string>(){
                        {"host", this.getHost(request.BucketName)},
                        {"date", this._getDate()},
                        {"user-agent", this._getUserAgent()},
                    };
                    if (!this._empty(token)) {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Query = this._toQuery(TeaModel.BuildMap(request.Filter));
                    request_.Headers["authorization"] = this.getSignature(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (this._isFail(response_)) {
                        bodyStr = this._readAsString(response_);
                        respMap = this._getErrMessage(bodyStr);
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

        public InitiateMultipartUploadResponse initiateMultipartUpload(InitiateMultipartUploadRequest request, RuntimeObject runtime) {
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
                    string token = this._getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "POST";
                    request_.Pathname = "/" + request.ObjectName + "?uploads";
                    request_.Headers = TeaConverter.merge<string>(
                        new Dictionary<string, string>(){
                            {"host", this.getHost(request.BucketName)},
                            {"date", this._getDate()},
                            {"user-agent", this._getUserAgent()},
                        },
                        this._toHeader(TeaModel.BuildMap(request.Header))
                    );
                    if (!this._empty(token)) {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Query = this._toQuery(TeaModel.BuildMap(request.Filter));
                    if (this._notNull(TeaModel.BuildMap(request.Header)) && !this._empty(request.Header.ContentType)) {
                        request_.Headers["content-type"] = request.Header.ContentType;
                    } else {
                        request_.Headers["content-type"] = this._getContentType(request.ObjectName);
                    }
                    request_.Headers["authorization"] = this.getSignature(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (this._isFail(response_)) {
                        bodyStr = this._readAsString(response_);
                        respMap = this._getErrMessage(bodyStr);
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
                    bodyStr = this._readAsString(response_);
                    respMap = this._parseXml(bodyStr, typeof(InitiateMultipartUploadResponse));
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

        public OptionObjectResponse optionObject(OptionObjectRequest request, RuntimeObject runtime) {
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
                    string token = this._getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "OPTIONS";
                    request_.Pathname = "/" + request.ObjectName;
                    request_.Headers = TeaConverter.merge<string>(
                        new Dictionary<string, string>(){
                            {"host", this.getHost(request.BucketName)},
                            {"date", this._getDate()},
                            {"user-agent", this._getUserAgent()},
                        },
                        this._toHeader(TeaModel.BuildMap(request.Header))
                    );
                    if (!this._empty(token)) {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = this.getSignature(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (this._isFail(response_)) {
                        bodyStr = this._readAsString(response_);
                        respMap = this._getErrMessage(bodyStr);
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

        public PostVodPlaylistResponse postVodPlaylist(PostVodPlaylistRequest request, RuntimeObject runtime) {
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
                    string token = this._getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "POST";
                    request_.Pathname = "/" + request.ChannelName + "/" + request.PlaylistName + "?vod";
                    request_.Headers = new Dictionary<string, string>(){
                        {"host", this.getHost(request.BucketName)},
                        {"date", this._getDate()},
                        {"user-agent", this._getUserAgent()},
                    };
                    if (!this._empty(token)) {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Query = this._toQuery(TeaModel.BuildMap(request.Filter));
                    request_.Headers["authorization"] = this.getSignature(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (this._isFail(response_)) {
                        bodyStr = this._readAsString(response_);
                        respMap = this._getErrMessage(bodyStr);
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

        public PostObjectResponse postObject(PostObjectRequest request, RuntimeObject runtime) {
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
                    string token = this._getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "POST";
                    request_.Pathname = "/";
                    request_.Headers = new Dictionary<string, string>(){
                        {"host", this.getHost(request.BucketName)},
                        {"date", this._getDate()},
                        {"user-agent", this._getUserAgent()},
                    };
                    if (!this._empty(token)) {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = this.getSignature(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (this._isFail(response_)) {
                        bodyStr = this._readAsString(response_);
                        respMap = this._getErrMessage(bodyStr);
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

        public HeadObjectResponse headObject(HeadObjectRequest request, RuntimeObject runtime) {
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
                    string token = this._getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "HEAD";
                    request_.Pathname = "/" + request.ObjectName;
                    request_.Headers = TeaConverter.merge<string>(
                        new Dictionary<string, string>(){
                            {"host", this.getHost(request.BucketName)},
                            {"date", this._getDate()},
                            {"user-agent", this._getUserAgent()},
                        },
                        this._toHeader(TeaModel.BuildMap(request.Header))
                    );
                    if (!this._empty(token)) {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = this.getSignature(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (this._isFail(response_)) {
                        bodyStr = this._readAsString(response_);
                        respMap = this._getErrMessage(bodyStr);
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

        public DeleteObjectTaggingResponse deleteObjectTagging(DeleteObjectTaggingRequest request, RuntimeObject runtime) {
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
                    string token = this._getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "DELETE";
                    request_.Pathname = "/" + request.ObjectName + "?tagging";
                    request_.Headers = new Dictionary<string, string>(){
                        {"host", this.getHost(request.BucketName)},
                        {"date", this._getDate()},
                        {"user-agent", this._getUserAgent()},
                    };
                    if (!this._empty(token)) {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = this.getSignature(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (this._isFail(response_)) {
                        bodyStr = this._readAsString(response_);
                        respMap = this._getErrMessage(bodyStr);
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

        public RestoreObjectResponse restoreObject(RestoreObjectRequest request, RuntimeObject runtime) {
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
                    string token = this._getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "POST";
                    request_.Pathname = "/" + request.ObjectName + "?restore";
                    request_.Headers = new Dictionary<string, string>(){
                        {"host", this.getHost(request.BucketName)},
                        {"date", this._getDate()},
                        {"user-agent", this._getUserAgent()},
                    };
                    if (!this._empty(token)) {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = this.getSignature(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (this._isFail(response_)) {
                        bodyStr = this._readAsString(response_);
                        respMap = this._getErrMessage(bodyStr);
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

        public GetObjectAclResponse getObjectAcl(GetObjectAclRequest request, RuntimeObject runtime) {
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
                    string token = this._getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/" + request.ObjectName + "?acl";
                    request_.Headers = new Dictionary<string, string>(){
                        {"host", this.getHost(request.BucketName)},
                        {"date", this._getDate()},
                        {"user-agent", this._getUserAgent()},
                    };
                    if (!this._empty(token)) {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = this.getSignature(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (this._isFail(response_)) {
                        bodyStr = this._readAsString(response_);
                        respMap = this._getErrMessage(bodyStr);
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
                    bodyStr = this._readAsString(response_);
                    respMap = this._parseXml(bodyStr, typeof(GetObjectAclResponse));
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

        public PutBucketAclResponse putBucketAcl(PutBucketAclRequest request, RuntimeObject runtime) {
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
                    string token = this._getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "PUT";
                    request_.Pathname = "/?acl";
                    request_.Headers = TeaConverter.merge<string>(
                        new Dictionary<string, string>(){
                            {"host", this.getHost(request.BucketName)},
                            {"date", this._getDate()},
                            {"user-agent", this._getUserAgent()},
                        },
                        this._toHeader(TeaModel.BuildMap(request.Header))
                    );
                    if (!this._empty(token)) {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = this.getSignature(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (this._isFail(response_)) {
                        bodyStr = this._readAsString(response_);
                        respMap = this._getErrMessage(bodyStr);
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

        public DeleteBucketResponse deleteBucket(DeleteBucketRequest request, RuntimeObject runtime) {
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
                    string token = this._getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "DELETE";
                    request_.Pathname = "/";
                    request_.Headers = new Dictionary<string, string>(){
                        {"host", this.getHost(request.BucketName)},
                        {"date", this._getDate()},
                        {"user-agent", this._getUserAgent()},
                    };
                    if (!this._empty(token)) {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = this.getSignature(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (this._isFail(response_)) {
                        bodyStr = this._readAsString(response_);
                        respMap = this._getErrMessage(bodyStr);
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

        public PutObjectResponse putObject(PutObjectRequest request, RuntimeObject runtime) {
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
                    Dictionary<string, string> ctx = new Dictionary<string, string>(){};
                    string token = this._getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "PUT";
                    request_.Pathname = "/" + request.ObjectName;
                    request_.Headers = TeaConverter.merge<string>(
                        new Dictionary<string, string>(){
                            {"host", this.getHost(request.BucketName)},
                            {"date", this._getDate()},
                            {"user-agent", this._getUserAgent()},
                        },
                        this._toHeader(TeaModel.BuildMap(request.Header)),
                        this._parseMeta(request.UserMeta, "x-oss-meta-")
                    );
                    if (!this._empty(token)) {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Body = this._inject(request.Body, ctx);
                    if (this._notNull(TeaModel.BuildMap(request.Header)) && !this._empty(request.Header.ContentType)) {
                        request_.Headers["content-type"] = request.Header.ContentType;
                    } else {
                        request_.Headers["content-type"] = this._getContentType(request.ObjectName);
                    }
                    request_.Headers["authorization"] = this.getSignature(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (this._isFail(response_)) {
                        bodyStr = this._readAsString(response_);
                        respMap = this._getErrMessage(bodyStr);
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
                    if (_isEnableCrc && !this._equal(ctx["crc"], response_.Headers["x-oss-hash-crc64ecma"])) {
                        throw new TeaException(new Dictionary<string, object>(){
                            {"code", "CrcNotMatched"},
                            {"data", new Dictionary<string, object>(){
                                {"clientCrc", ctx["crc"]},
                                {"serverCrc", response_.Headers["x-oss-hash-crc64ecma"]},
                            }},
                        });
                    }                    
                    if (_isEnableMD5 && !this._equal(ctx["md5"], response_.Headers["content-md5"])) {
                        throw new TeaException(new Dictionary<string, object>(){
                            {"code", "MD5NotMatched"},
                            {"data", new Dictionary<string, object>(){
                                {"clientMD5", ctx["md5"]},
                                {"serverMD5", response_.Headers["content-md5"]},
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

    string getHost(string bucketName){
        if (this._empty(_regionId)) {
            this._regionId = "cn-hangzhou";
        }        
        if (this._empty(_endpoint)) {
            this._endpoint = "oss-" + _regionId + ".aliyuncs.com";
        }        
        if (this._empty(bucketName)) {
            return _endpoint;
        }        
        string host = null;
        if (this._equal(_hostModel, "ip")) {
            host = _endpoint + "/" + bucketName;
        }         else if (this._equal(_hostModel, "cname")) {
            host = _endpoint;
        } else {
            host = bucketName + "." + _endpoint;
        }        
        return host;
    }

    string getSignature(TeaRequest request, string bucketName){
        string accessKeyId = this._getAccessKeyID();
        string accessKeySecret = this._getAccessKeySecret();
        if (this._equal(_signatureVersion, "V2")) {
            if (this._ifListEmpty(_addtionalHeaders)) {
                return "OSS2 AccessKeyId:" + accessKeyId + ",Signature:" + this._getSignatureV2(request, bucketName, accessKeySecret, _addtionalHeaders);
            } else {
                return "OSS2 AccessKeyId:" + accessKeyId + ",AdditionalHeaders:" + this._listToString(_addtionalHeaders, ";") + ",Signature:" + this._getSignatureV2(request, bucketName, accessKeySecret, _addtionalHeaders);
            }            
        } else {
            return "OSS " + accessKeyId + ":" + this._getSignatureV1(request, bucketName, accessKeySecret);
        }        
    }

  }
}
