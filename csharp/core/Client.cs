// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;

using AlibabaCloud.OSS;
using AlibabaCloud.OSS.Models;

namespace AlibabaCloud.OSS
{
    public class Client : BaseClient
    {

        public Client(Config config): base(config.ToMap())
        { }

        public PutBucketLifecycleResponse PutBucketLifecycle(PutBucketLifecycleRequest request, RuntimeObject runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>()
            {
                {"timeouted", "retry"},
                {"readTimeout", _defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", _defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", _default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", _default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", _default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", _default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", _default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", _default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", _defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>()
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>()
                {
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string token = _getSecurityToken();
                    string reqBody = _toXML(request.Body.ToMap());
                    request_.Protocol = _protocol;
                    request_.Method = "PUT";
                    request_.Pathname = "/?lifecycle";
                    request_.Headers = new Dictionary<string, string>()
                    {
                        {"host", GetHost(request.BucketName)},
                        {"date", _getDate()},
                        {"user-agent", _getUserAgent()},
                    };
                    if (!_empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Body = TeaCore.BytesReadable(reqBody);
                    request_.Headers["authorization"] = GetSignature(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (_isFail(response_))
                    {
                        bodyStr = _readAsString(response_);
                        respMap = _getErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>()
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    return TeaModel.ToObject<PutBucketLifecycleResponse>(TeaConverter.merge<string>
                    (
                        response_.Headers
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public async Task<PutBucketLifecycleResponse> PutBucketLifecycleAsync(PutBucketLifecycleRequest request, RuntimeObject runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>()
            {
                {"timeouted", "retry"},
                {"readTimeout", _defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", _defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", _default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", _default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", _default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", _default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", _default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", _default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", _defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>()
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>()
                {
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string token = _getSecurityToken();
                    string reqBody = _toXML(request.Body.ToMap());
                    request_.Protocol = _protocol;
                    request_.Method = "PUT";
                    request_.Pathname = "/?lifecycle";
                    request_.Headers = new Dictionary<string, string>()
                    {
                        {"host", GetHost(request.BucketName)},
                        {"date", _getDate()},
                        {"user-agent", _getUserAgent()},
                    };
                    if (!_empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Body = TeaCore.BytesReadable(reqBody);
                    request_.Headers["authorization"] = await GetSignatureAsync(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (_isFail(response_))
                    {
                        bodyStr = _readAsString(response_);
                        respMap = _getErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>()
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    return TeaModel.ToObject<PutBucketLifecycleResponse>(TeaConverter.merge<string>
                    (
                        response_.Headers
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public DeleteMultipleObjectsResponse DeleteMultipleObjects(DeleteMultipleObjectsRequest request, RuntimeObject runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>()
            {
                {"timeouted", "retry"},
                {"readTimeout", _defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", _defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", _default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", _default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", _default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", _default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", _default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", _default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", _defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>()
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>()
                {
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string token = _getSecurityToken();
                    string reqBody = _toXML(request.Body.ToMap());
                    request_.Protocol = _protocol;
                    request_.Method = "POST";
                    request_.Pathname = "/?delete";
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"host", GetHost(request.BucketName)},
                            {"date", _getDate()},
                            {"user-agent", _getUserAgent()},
                        },
                        _toHeader(request.Header.ToMap())
                    );
                    if (!_empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Body = TeaCore.BytesReadable(reqBody);
                    if (_notNull(request.Header.ToMap()) && !_empty(request.Header.ContentMD5))
                    {
                        request_.Headers["content-md5"] = request.Header.ContentMD5;
                    }
else
                    {
                        request_.Headers["content-md5"] = _getContentMD5(reqBody);
                    }
                    request_.Headers["authorization"] = GetSignature(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (_isFail(response_))
                    {
                        bodyStr = _readAsString(response_);
                        respMap = _getErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>()
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    bodyStr = _readAsString(response_);
                    respMap = _parseXml(bodyStr, typeof(DeleteMultipleObjectsResponse));
                    return TeaModel.ToObject<DeleteMultipleObjectsResponse>(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"DeleteResult", respMap["DeleteResult"]},
                        },
                        response_.Headers
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public async Task<DeleteMultipleObjectsResponse> DeleteMultipleObjectsAsync(DeleteMultipleObjectsRequest request, RuntimeObject runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>()
            {
                {"timeouted", "retry"},
                {"readTimeout", _defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", _defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", _default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", _default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", _default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", _default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", _default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", _default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", _defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>()
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>()
                {
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string token = _getSecurityToken();
                    string reqBody = _toXML(request.Body.ToMap());
                    request_.Protocol = _protocol;
                    request_.Method = "POST";
                    request_.Pathname = "/?delete";
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"host", GetHost(request.BucketName)},
                            {"date", _getDate()},
                            {"user-agent", _getUserAgent()},
                        },
                        _toHeader(request.Header.ToMap())
                    );
                    if (!_empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Body = TeaCore.BytesReadable(reqBody);
                    if (_notNull(request.Header.ToMap()) && !_empty(request.Header.ContentMD5))
                    {
                        request_.Headers["content-md5"] = request.Header.ContentMD5;
                    }
else
                    {
                        request_.Headers["content-md5"] = _getContentMD5(reqBody);
                    }
                    request_.Headers["authorization"] = await GetSignatureAsync(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (_isFail(response_))
                    {
                        bodyStr = _readAsString(response_);
                        respMap = _getErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>()
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    bodyStr = _readAsString(response_);
                    respMap = _parseXml(bodyStr, typeof(DeleteMultipleObjectsResponse));
                    return TeaModel.ToObject<DeleteMultipleObjectsResponse>(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"DeleteResult", respMap["DeleteResult"]},
                        },
                        response_.Headers
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public PutBucketRefererResponse PutBucketReferer(PutBucketRefererRequest request, RuntimeObject runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>()
            {
                {"timeouted", "retry"},
                {"readTimeout", _defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", _defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", _default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", _default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", _default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", _default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", _default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", _default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", _defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>()
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>()
                {
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string token = _getSecurityToken();
                    string reqBody = _toXML(request.Body.ToMap());
                    request_.Protocol = _protocol;
                    request_.Method = "PUT";
                    request_.Pathname = "/?referer";
                    request_.Headers = new Dictionary<string, string>()
                    {
                        {"host", GetHost(request.BucketName)},
                        {"date", _getDate()},
                        {"user-agent", _getUserAgent()},
                    };
                    if (!_empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Body = TeaCore.BytesReadable(reqBody);
                    request_.Headers["authorization"] = GetSignature(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (_isFail(response_))
                    {
                        bodyStr = _readAsString(response_);
                        respMap = _getErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>()
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    return TeaModel.ToObject<PutBucketRefererResponse>(TeaConverter.merge<string>
                    (
                        response_.Headers
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public async Task<PutBucketRefererResponse> PutBucketRefererAsync(PutBucketRefererRequest request, RuntimeObject runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>()
            {
                {"timeouted", "retry"},
                {"readTimeout", _defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", _defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", _default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", _default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", _default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", _default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", _default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", _default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", _defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>()
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>()
                {
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string token = _getSecurityToken();
                    string reqBody = _toXML(request.Body.ToMap());
                    request_.Protocol = _protocol;
                    request_.Method = "PUT";
                    request_.Pathname = "/?referer";
                    request_.Headers = new Dictionary<string, string>()
                    {
                        {"host", GetHost(request.BucketName)},
                        {"date", _getDate()},
                        {"user-agent", _getUserAgent()},
                    };
                    if (!_empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Body = TeaCore.BytesReadable(reqBody);
                    request_.Headers["authorization"] = await GetSignatureAsync(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (_isFail(response_))
                    {
                        bodyStr = _readAsString(response_);
                        respMap = _getErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>()
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    return TeaModel.ToObject<PutBucketRefererResponse>(TeaConverter.merge<string>
                    (
                        response_.Headers
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public PutBucketWebsiteResponse PutBucketWebsite(PutBucketWebsiteRequest request, RuntimeObject runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>()
            {
                {"timeouted", "retry"},
                {"readTimeout", _defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", _defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", _default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", _default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", _default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", _default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", _default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", _default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", _defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>()
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>()
                {
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string token = _getSecurityToken();
                    string reqBody = _toXML(request.Body.ToMap());
                    request_.Protocol = _protocol;
                    request_.Method = "PUT";
                    request_.Pathname = "/?website";
                    request_.Headers = new Dictionary<string, string>()
                    {
                        {"host", GetHost(request.BucketName)},
                        {"date", _getDate()},
                        {"user-agent", _getUserAgent()},
                    };
                    if (!_empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Body = TeaCore.BytesReadable(reqBody);
                    request_.Headers["authorization"] = GetSignature(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (_isFail(response_))
                    {
                        bodyStr = _readAsString(response_);
                        respMap = _getErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>()
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    return TeaModel.ToObject<PutBucketWebsiteResponse>(TeaConverter.merge<string>
                    (
                        response_.Headers
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public async Task<PutBucketWebsiteResponse> PutBucketWebsiteAsync(PutBucketWebsiteRequest request, RuntimeObject runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>()
            {
                {"timeouted", "retry"},
                {"readTimeout", _defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", _defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", _default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", _default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", _default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", _default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", _default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", _default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", _defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>()
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>()
                {
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string token = _getSecurityToken();
                    string reqBody = _toXML(request.Body.ToMap());
                    request_.Protocol = _protocol;
                    request_.Method = "PUT";
                    request_.Pathname = "/?website";
                    request_.Headers = new Dictionary<string, string>()
                    {
                        {"host", GetHost(request.BucketName)},
                        {"date", _getDate()},
                        {"user-agent", _getUserAgent()},
                    };
                    if (!_empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Body = TeaCore.BytesReadable(reqBody);
                    request_.Headers["authorization"] = await GetSignatureAsync(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (_isFail(response_))
                    {
                        bodyStr = _readAsString(response_);
                        respMap = _getErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>()
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    return TeaModel.ToObject<PutBucketWebsiteResponse>(TeaConverter.merge<string>
                    (
                        response_.Headers
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public CompleteMultipartUploadResponse CompleteMultipartUpload(CompleteMultipartUploadRequest request, RuntimeObject runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>()
            {
                {"timeouted", "retry"},
                {"readTimeout", _defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", _defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", _default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", _default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", _default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", _default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", _default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", _default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", _defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>()
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>()
                {
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string token = _getSecurityToken();
                    string reqBody = _toXML(request.Body.ToMap());
                    request_.Protocol = _protocol;
                    request_.Method = "POST";
                    request_.Pathname = "/" + request.ObjectName;
                    request_.Headers = new Dictionary<string, string>()
                    {
                        {"host", GetHost(request.BucketName)},
                        {"date", _getDate()},
                        {"user-agent", _getUserAgent()},
                    };
                    if (!_empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Query = _toQuery(request.Filter.ToMap());
                    request_.Body = TeaCore.BytesReadable(reqBody);
                    request_.Headers["authorization"] = GetSignature(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (_isFail(response_))
                    {
                        bodyStr = _readAsString(response_);
                        respMap = _getErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>()
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    bodyStr = _readAsString(response_);
                    respMap = _parseXml(bodyStr, typeof(CompleteMultipartUploadResponse));
                    return TeaModel.ToObject<CompleteMultipartUploadResponse>(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"CompleteMultipartUploadResult", respMap["CompleteMultipartUploadResult"]},
                        },
                        response_.Headers
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public async Task<CompleteMultipartUploadResponse> CompleteMultipartUploadAsync(CompleteMultipartUploadRequest request, RuntimeObject runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>()
            {
                {"timeouted", "retry"},
                {"readTimeout", _defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", _defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", _default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", _default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", _default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", _default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", _default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", _default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", _defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>()
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>()
                {
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string token = _getSecurityToken();
                    string reqBody = _toXML(request.Body.ToMap());
                    request_.Protocol = _protocol;
                    request_.Method = "POST";
                    request_.Pathname = "/" + request.ObjectName;
                    request_.Headers = new Dictionary<string, string>()
                    {
                        {"host", GetHost(request.BucketName)},
                        {"date", _getDate()},
                        {"user-agent", _getUserAgent()},
                    };
                    if (!_empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Query = _toQuery(request.Filter.ToMap());
                    request_.Body = TeaCore.BytesReadable(reqBody);
                    request_.Headers["authorization"] = await GetSignatureAsync(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (_isFail(response_))
                    {
                        bodyStr = _readAsString(response_);
                        respMap = _getErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>()
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    bodyStr = _readAsString(response_);
                    respMap = _parseXml(bodyStr, typeof(CompleteMultipartUploadResponse));
                    return TeaModel.ToObject<CompleteMultipartUploadResponse>(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"CompleteMultipartUploadResult", respMap["CompleteMultipartUploadResult"]},
                        },
                        response_.Headers
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public PutBucketLoggingResponse PutBucketLogging(PutBucketLoggingRequest request, RuntimeObject runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>()
            {
                {"timeouted", "retry"},
                {"readTimeout", _defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", _defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", _default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", _default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", _default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", _default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", _default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", _default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", _defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>()
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>()
                {
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string token = _getSecurityToken();
                    string reqBody = _toXML(request.Body.ToMap());
                    request_.Protocol = _protocol;
                    request_.Method = "PUT";
                    request_.Pathname = "/?logging";
                    request_.Headers = new Dictionary<string, string>()
                    {
                        {"host", GetHost(request.BucketName)},
                        {"date", _getDate()},
                        {"user-agent", _getUserAgent()},
                    };
                    if (!_empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Body = TeaCore.BytesReadable(reqBody);
                    request_.Headers["authorization"] = GetSignature(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (_isFail(response_))
                    {
                        bodyStr = _readAsString(response_);
                        respMap = _getErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>()
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    return TeaModel.ToObject<PutBucketLoggingResponse>(TeaConverter.merge<string>
                    (
                        response_.Headers
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public async Task<PutBucketLoggingResponse> PutBucketLoggingAsync(PutBucketLoggingRequest request, RuntimeObject runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>()
            {
                {"timeouted", "retry"},
                {"readTimeout", _defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", _defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", _default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", _default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", _default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", _default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", _default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", _default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", _defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>()
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>()
                {
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string token = _getSecurityToken();
                    string reqBody = _toXML(request.Body.ToMap());
                    request_.Protocol = _protocol;
                    request_.Method = "PUT";
                    request_.Pathname = "/?logging";
                    request_.Headers = new Dictionary<string, string>()
                    {
                        {"host", GetHost(request.BucketName)},
                        {"date", _getDate()},
                        {"user-agent", _getUserAgent()},
                    };
                    if (!_empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Body = TeaCore.BytesReadable(reqBody);
                    request_.Headers["authorization"] = await GetSignatureAsync(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (_isFail(response_))
                    {
                        bodyStr = _readAsString(response_);
                        respMap = _getErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>()
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    return TeaModel.ToObject<PutBucketLoggingResponse>(TeaConverter.merge<string>
                    (
                        response_.Headers
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public PutBucketRequestPaymentResponse PutBucketRequestPayment(PutBucketRequestPaymentRequest request, RuntimeObject runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>()
            {
                {"timeouted", "retry"},
                {"readTimeout", _defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", _defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", _default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", _default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", _default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", _default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", _default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", _default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", _defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>()
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>()
                {
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string token = _getSecurityToken();
                    string reqBody = _toXML(request.Body.ToMap());
                    request_.Protocol = _protocol;
                    request_.Method = "PUT";
                    request_.Pathname = "/?requestPayment";
                    request_.Headers = new Dictionary<string, string>()
                    {
                        {"host", GetHost(request.BucketName)},
                        {"date", _getDate()},
                        {"user-agent", _getUserAgent()},
                    };
                    if (!_empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Body = TeaCore.BytesReadable(reqBody);
                    request_.Headers["authorization"] = GetSignature(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (_isFail(response_))
                    {
                        bodyStr = _readAsString(response_);
                        respMap = _getErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>()
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    return TeaModel.ToObject<PutBucketRequestPaymentResponse>(TeaConverter.merge<string>
                    (
                        response_.Headers
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public async Task<PutBucketRequestPaymentResponse> PutBucketRequestPaymentAsync(PutBucketRequestPaymentRequest request, RuntimeObject runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>()
            {
                {"timeouted", "retry"},
                {"readTimeout", _defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", _defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", _default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", _default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", _default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", _default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", _default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", _default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", _defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>()
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>()
                {
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string token = _getSecurityToken();
                    string reqBody = _toXML(request.Body.ToMap());
                    request_.Protocol = _protocol;
                    request_.Method = "PUT";
                    request_.Pathname = "/?requestPayment";
                    request_.Headers = new Dictionary<string, string>()
                    {
                        {"host", GetHost(request.BucketName)},
                        {"date", _getDate()},
                        {"user-agent", _getUserAgent()},
                    };
                    if (!_empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Body = TeaCore.BytesReadable(reqBody);
                    request_.Headers["authorization"] = await GetSignatureAsync(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (_isFail(response_))
                    {
                        bodyStr = _readAsString(response_);
                        respMap = _getErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>()
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    return TeaModel.ToObject<PutBucketRequestPaymentResponse>(TeaConverter.merge<string>
                    (
                        response_.Headers
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public PutBucketEncryptionResponse PutBucketEncryption(PutBucketEncryptionRequest request, RuntimeObject runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>()
            {
                {"timeouted", "retry"},
                {"readTimeout", _defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", _defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", _default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", _default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", _default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", _default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", _default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", _default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", _defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>()
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>()
                {
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string token = _getSecurityToken();
                    string reqBody = _toXML(request.Body.ToMap());
                    request_.Protocol = _protocol;
                    request_.Method = "PUT";
                    request_.Pathname = "/?encryption";
                    request_.Headers = new Dictionary<string, string>()
                    {
                        {"host", GetHost(request.BucketName)},
                        {"date", _getDate()},
                        {"user-agent", _getUserAgent()},
                    };
                    if (!_empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Body = TeaCore.BytesReadable(reqBody);
                    request_.Headers["authorization"] = GetSignature(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (_isFail(response_))
                    {
                        bodyStr = _readAsString(response_);
                        respMap = _getErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>()
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    return TeaModel.ToObject<PutBucketEncryptionResponse>(TeaConverter.merge<string>
                    (
                        response_.Headers
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public async Task<PutBucketEncryptionResponse> PutBucketEncryptionAsync(PutBucketEncryptionRequest request, RuntimeObject runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>()
            {
                {"timeouted", "retry"},
                {"readTimeout", _defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", _defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", _default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", _default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", _default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", _default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", _default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", _default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", _defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>()
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>()
                {
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string token = _getSecurityToken();
                    string reqBody = _toXML(request.Body.ToMap());
                    request_.Protocol = _protocol;
                    request_.Method = "PUT";
                    request_.Pathname = "/?encryption";
                    request_.Headers = new Dictionary<string, string>()
                    {
                        {"host", GetHost(request.BucketName)},
                        {"date", _getDate()},
                        {"user-agent", _getUserAgent()},
                    };
                    if (!_empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Body = TeaCore.BytesReadable(reqBody);
                    request_.Headers["authorization"] = await GetSignatureAsync(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (_isFail(response_))
                    {
                        bodyStr = _readAsString(response_);
                        respMap = _getErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>()
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    return TeaModel.ToObject<PutBucketEncryptionResponse>(TeaConverter.merge<string>
                    (
                        response_.Headers
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public PutLiveChannelResponse PutLiveChannel(PutLiveChannelRequest request, RuntimeObject runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>()
            {
                {"timeouted", "retry"},
                {"readTimeout", _defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", _defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", _default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", _default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", _default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", _default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", _default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", _default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", _defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>()
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>()
                {
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string token = _getSecurityToken();
                    string reqBody = _toXML(request.Body.ToMap());
                    request_.Protocol = _protocol;
                    request_.Method = "PUT";
                    request_.Pathname = "/" + request.ChannelName + "?live";
                    request_.Headers = new Dictionary<string, string>()
                    {
                        {"host", GetHost(request.BucketName)},
                        {"date", _getDate()},
                        {"user-agent", _getUserAgent()},
                    };
                    if (!_empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Body = TeaCore.BytesReadable(reqBody);
                    request_.Headers["authorization"] = GetSignature(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (_isFail(response_))
                    {
                        bodyStr = _readAsString(response_);
                        respMap = _getErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>()
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    bodyStr = _readAsString(response_);
                    respMap = _parseXml(bodyStr, typeof(PutLiveChannelResponse));
                    return TeaModel.ToObject<PutLiveChannelResponse>(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"CreateLiveChannelResult", respMap["CreateLiveChannelResult"]},
                        },
                        response_.Headers
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public async Task<PutLiveChannelResponse> PutLiveChannelAsync(PutLiveChannelRequest request, RuntimeObject runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>()
            {
                {"timeouted", "retry"},
                {"readTimeout", _defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", _defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", _default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", _default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", _default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", _default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", _default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", _default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", _defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>()
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>()
                {
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string token = _getSecurityToken();
                    string reqBody = _toXML(request.Body.ToMap());
                    request_.Protocol = _protocol;
                    request_.Method = "PUT";
                    request_.Pathname = "/" + request.ChannelName + "?live";
                    request_.Headers = new Dictionary<string, string>()
                    {
                        {"host", GetHost(request.BucketName)},
                        {"date", _getDate()},
                        {"user-agent", _getUserAgent()},
                    };
                    if (!_empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Body = TeaCore.BytesReadable(reqBody);
                    request_.Headers["authorization"] = await GetSignatureAsync(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (_isFail(response_))
                    {
                        bodyStr = _readAsString(response_);
                        respMap = _getErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>()
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    bodyStr = _readAsString(response_);
                    respMap = _parseXml(bodyStr, typeof(PutLiveChannelResponse));
                    return TeaModel.ToObject<PutLiveChannelResponse>(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"CreateLiveChannelResult", respMap["CreateLiveChannelResult"]},
                        },
                        response_.Headers
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public PutBucketTagsResponse PutBucketTags(PutBucketTagsRequest request, RuntimeObject runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>()
            {
                {"timeouted", "retry"},
                {"readTimeout", _defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", _defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", _default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", _default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", _default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", _default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", _default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", _default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", _defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>()
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>()
                {
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string token = _getSecurityToken();
                    string reqBody = _toXML(request.Body.ToMap());
                    request_.Protocol = _protocol;
                    request_.Method = "PUT";
                    request_.Pathname = "/?tagging";
                    request_.Headers = new Dictionary<string, string>()
                    {
                        {"host", GetHost(request.BucketName)},
                        {"date", _getDate()},
                        {"user-agent", _getUserAgent()},
                    };
                    if (!_empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Body = TeaCore.BytesReadable(reqBody);
                    request_.Headers["authorization"] = GetSignature(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (_isFail(response_))
                    {
                        bodyStr = _readAsString(response_);
                        respMap = _getErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>()
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    return TeaModel.ToObject<PutBucketTagsResponse>(TeaConverter.merge<string>
                    (
                        response_.Headers
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public async Task<PutBucketTagsResponse> PutBucketTagsAsync(PutBucketTagsRequest request, RuntimeObject runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>()
            {
                {"timeouted", "retry"},
                {"readTimeout", _defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", _defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", _default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", _default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", _default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", _default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", _default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", _default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", _defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>()
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>()
                {
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string token = _getSecurityToken();
                    string reqBody = _toXML(request.Body.ToMap());
                    request_.Protocol = _protocol;
                    request_.Method = "PUT";
                    request_.Pathname = "/?tagging";
                    request_.Headers = new Dictionary<string, string>()
                    {
                        {"host", GetHost(request.BucketName)},
                        {"date", _getDate()},
                        {"user-agent", _getUserAgent()},
                    };
                    if (!_empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Body = TeaCore.BytesReadable(reqBody);
                    request_.Headers["authorization"] = await GetSignatureAsync(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (_isFail(response_))
                    {
                        bodyStr = _readAsString(response_);
                        respMap = _getErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>()
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    return TeaModel.ToObject<PutBucketTagsResponse>(TeaConverter.merge<string>
                    (
                        response_.Headers
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public PutObjectTaggingResponse PutObjectTagging(PutObjectTaggingRequest request, RuntimeObject runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>()
            {
                {"timeouted", "retry"},
                {"readTimeout", _defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", _defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", _default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", _default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", _default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", _default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", _default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", _default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", _defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>()
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>()
                {
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string token = _getSecurityToken();
                    string reqBody = _toXML(request.Body.ToMap());
                    request_.Protocol = _protocol;
                    request_.Method = "PUT";
                    request_.Pathname = "/" + request.ObjectName + "?tagging";
                    request_.Headers = new Dictionary<string, string>()
                    {
                        {"host", GetHost(request.BucketName)},
                        {"date", _getDate()},
                        {"user-agent", _getUserAgent()},
                    };
                    if (!_empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Body = TeaCore.BytesReadable(reqBody);
                    request_.Headers["authorization"] = GetSignature(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (_isFail(response_))
                    {
                        bodyStr = _readAsString(response_);
                        respMap = _getErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>()
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    return TeaModel.ToObject<PutObjectTaggingResponse>(TeaConverter.merge<string>
                    (
                        response_.Headers
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public async Task<PutObjectTaggingResponse> PutObjectTaggingAsync(PutObjectTaggingRequest request, RuntimeObject runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>()
            {
                {"timeouted", "retry"},
                {"readTimeout", _defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", _defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", _default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", _default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", _default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", _default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", _default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", _default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", _defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>()
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>()
                {
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string token = _getSecurityToken();
                    string reqBody = _toXML(request.Body.ToMap());
                    request_.Protocol = _protocol;
                    request_.Method = "PUT";
                    request_.Pathname = "/" + request.ObjectName + "?tagging";
                    request_.Headers = new Dictionary<string, string>()
                    {
                        {"host", GetHost(request.BucketName)},
                        {"date", _getDate()},
                        {"user-agent", _getUserAgent()},
                    };
                    if (!_empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Body = TeaCore.BytesReadable(reqBody);
                    request_.Headers["authorization"] = await GetSignatureAsync(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (_isFail(response_))
                    {
                        bodyStr = _readAsString(response_);
                        respMap = _getErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>()
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    return TeaModel.ToObject<PutObjectTaggingResponse>(TeaConverter.merge<string>
                    (
                        response_.Headers
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public SelectObjectResponse SelectObject(SelectObjectRequest request, RuntimeObject runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>()
            {
                {"timeouted", "retry"},
                {"readTimeout", _defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", _defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", _default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", _default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", _default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", _default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", _default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", _default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", _defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>()
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>()
                {
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string token = _getSecurityToken();
                    string reqBody = _toXML(request.Body.ToMap());
                    request_.Protocol = _protocol;
                    request_.Method = "POST";
                    request_.Pathname = "/" + request.ObjectName;
                    request_.Headers = new Dictionary<string, string>()
                    {
                        {"host", GetHost(request.BucketName)},
                        {"date", _getDate()},
                        {"user-agent", _getUserAgent()},
                    };
                    if (!_empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Query = _toQuery(request.Filter.ToMap());
                    request_.Body = TeaCore.BytesReadable(reqBody);
                    request_.Headers["authorization"] = GetSignature(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (_isFail(response_))
                    {
                        bodyStr = _readAsString(response_);
                        respMap = _getErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>()
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    return TeaModel.ToObject<SelectObjectResponse>(TeaConverter.merge<string>
                    (
                        response_.Headers
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public async Task<SelectObjectResponse> SelectObjectAsync(SelectObjectRequest request, RuntimeObject runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>()
            {
                {"timeouted", "retry"},
                {"readTimeout", _defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", _defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", _default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", _default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", _default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", _default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", _default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", _default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", _defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>()
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>()
                {
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string token = _getSecurityToken();
                    string reqBody = _toXML(request.Body.ToMap());
                    request_.Protocol = _protocol;
                    request_.Method = "POST";
                    request_.Pathname = "/" + request.ObjectName;
                    request_.Headers = new Dictionary<string, string>()
                    {
                        {"host", GetHost(request.BucketName)},
                        {"date", _getDate()},
                        {"user-agent", _getUserAgent()},
                    };
                    if (!_empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Query = _toQuery(request.Filter.ToMap());
                    request_.Body = TeaCore.BytesReadable(reqBody);
                    request_.Headers["authorization"] = await GetSignatureAsync(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (_isFail(response_))
                    {
                        bodyStr = _readAsString(response_);
                        respMap = _getErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>()
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    return TeaModel.ToObject<SelectObjectResponse>(TeaConverter.merge<string>
                    (
                        response_.Headers
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public PutBucketCORSResponse PutBucketCORS(PutBucketCORSRequest request, RuntimeObject runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>()
            {
                {"timeouted", "retry"},
                {"readTimeout", _defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", _defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", _default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", _default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", _default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", _default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", _default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", _default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", _defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>()
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>()
                {
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string token = _getSecurityToken();
                    string reqBody = _toXML(request.Body.ToMap());
                    request_.Protocol = _protocol;
                    request_.Method = "PUT";
                    request_.Pathname = "/?cors";
                    request_.Headers = new Dictionary<string, string>()
                    {
                        {"host", GetHost(request.BucketName)},
                        {"date", _getDate()},
                        {"user-agent", _getUserAgent()},
                    };
                    if (!_empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Body = TeaCore.BytesReadable(reqBody);
                    request_.Headers["authorization"] = GetSignature(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (_isFail(response_))
                    {
                        bodyStr = _readAsString(response_);
                        respMap = _getErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>()
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    return TeaModel.ToObject<PutBucketCORSResponse>(TeaConverter.merge<string>
                    (
                        response_.Headers
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public async Task<PutBucketCORSResponse> PutBucketCORSAsync(PutBucketCORSRequest request, RuntimeObject runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>()
            {
                {"timeouted", "retry"},
                {"readTimeout", _defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", _defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", _default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", _default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", _default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", _default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", _default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", _default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", _defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>()
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>()
                {
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string token = _getSecurityToken();
                    string reqBody = _toXML(request.Body.ToMap());
                    request_.Protocol = _protocol;
                    request_.Method = "PUT";
                    request_.Pathname = "/?cors";
                    request_.Headers = new Dictionary<string, string>()
                    {
                        {"host", GetHost(request.BucketName)},
                        {"date", _getDate()},
                        {"user-agent", _getUserAgent()},
                    };
                    if (!_empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Body = TeaCore.BytesReadable(reqBody);
                    request_.Headers["authorization"] = await GetSignatureAsync(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (_isFail(response_))
                    {
                        bodyStr = _readAsString(response_);
                        respMap = _getErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>()
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    return TeaModel.ToObject<PutBucketCORSResponse>(TeaConverter.merge<string>
                    (
                        response_.Headers
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public PutBucketResponse PutBucket(PutBucketRequest request, RuntimeObject runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>()
            {
                {"timeouted", "retry"},
                {"readTimeout", _defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", _defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", _default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", _default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", _default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", _default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", _default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", _default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", _defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>()
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>()
                {
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string token = _getSecurityToken();
                    string reqBody = _toXML(request.Body.ToMap());
                    request_.Protocol = _protocol;
                    request_.Method = "PUT";
                    request_.Pathname = "/";
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"host", GetHost(request.BucketName)},
                            {"date", _getDate()},
                            {"user-agent", _getUserAgent()},
                        },
                        _toHeader(request.Header.ToMap())
                    );
                    if (!_empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Body = TeaCore.BytesReadable(reqBody);
                    request_.Headers["authorization"] = GetSignature(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (_isFail(response_))
                    {
                        bodyStr = _readAsString(response_);
                        respMap = _getErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>()
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    return TeaModel.ToObject<PutBucketResponse>(TeaConverter.merge<string>
                    (
                        response_.Headers
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public async Task<PutBucketResponse> PutBucketAsync(PutBucketRequest request, RuntimeObject runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>()
            {
                {"timeouted", "retry"},
                {"readTimeout", _defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", _defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", _default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", _default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", _default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", _default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", _default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", _default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", _defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>()
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>()
                {
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string token = _getSecurityToken();
                    string reqBody = _toXML(request.Body.ToMap());
                    request_.Protocol = _protocol;
                    request_.Method = "PUT";
                    request_.Pathname = "/";
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"host", GetHost(request.BucketName)},
                            {"date", _getDate()},
                            {"user-agent", _getUserAgent()},
                        },
                        _toHeader(request.Header.ToMap())
                    );
                    if (!_empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Body = TeaCore.BytesReadable(reqBody);
                    request_.Headers["authorization"] = await GetSignatureAsync(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (_isFail(response_))
                    {
                        bodyStr = _readAsString(response_);
                        respMap = _getErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>()
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    return TeaModel.ToObject<PutBucketResponse>(TeaConverter.merge<string>
                    (
                        response_.Headers
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public ListMultipartUploadsResponse ListMultipartUploads(ListMultipartUploadsRequest request, RuntimeObject runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>()
            {
                {"timeouted", "retry"},
                {"readTimeout", _defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", _defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", _default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", _default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", _default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", _default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", _default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", _default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", _defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>()
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>()
                {
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string token = _getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/?uploads";
                    request_.Headers = new Dictionary<string, string>()
                    {
                        {"host", GetHost(request.BucketName)},
                        {"date", _getDate()},
                        {"user-agent", _getUserAgent()},
                    };
                    if (!_empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Query = _toQuery(request.Filter.ToMap());
                    request_.Headers["authorization"] = GetSignature(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (_isFail(response_))
                    {
                        bodyStr = _readAsString(response_);
                        respMap = _getErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>()
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    bodyStr = _readAsString(response_);
                    respMap = _parseXml(bodyStr, typeof(ListMultipartUploadsResponse));
                    return TeaModel.ToObject<ListMultipartUploadsResponse>(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"ListMultipartUploadsResult", respMap["ListMultipartUploadsResult"]},
                        },
                        response_.Headers
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public async Task<ListMultipartUploadsResponse> ListMultipartUploadsAsync(ListMultipartUploadsRequest request, RuntimeObject runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>()
            {
                {"timeouted", "retry"},
                {"readTimeout", _defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", _defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", _default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", _default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", _default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", _default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", _default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", _default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", _defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>()
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>()
                {
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string token = _getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/?uploads";
                    request_.Headers = new Dictionary<string, string>()
                    {
                        {"host", GetHost(request.BucketName)},
                        {"date", _getDate()},
                        {"user-agent", _getUserAgent()},
                    };
                    if (!_empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Query = _toQuery(request.Filter.ToMap());
                    request_.Headers["authorization"] = await GetSignatureAsync(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (_isFail(response_))
                    {
                        bodyStr = _readAsString(response_);
                        respMap = _getErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>()
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    bodyStr = _readAsString(response_);
                    respMap = _parseXml(bodyStr, typeof(ListMultipartUploadsResponse));
                    return TeaModel.ToObject<ListMultipartUploadsResponse>(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"ListMultipartUploadsResult", respMap["ListMultipartUploadsResult"]},
                        },
                        response_.Headers
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public GetBucketRequestPaymentResponse GetBucketRequestPayment(GetBucketRequestPaymentRequest request, RuntimeObject runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>()
            {
                {"timeouted", "retry"},
                {"readTimeout", _defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", _defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", _default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", _default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", _default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", _default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", _default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", _default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", _defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>()
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>()
                {
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string token = _getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/?requestPayment";
                    request_.Headers = new Dictionary<string, string>()
                    {
                        {"host", GetHost(request.BucketName)},
                        {"date", _getDate()},
                        {"user-agent", _getUserAgent()},
                    };
                    if (!_empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = GetSignature(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (_isFail(response_))
                    {
                        bodyStr = _readAsString(response_);
                        respMap = _getErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>()
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    bodyStr = _readAsString(response_);
                    respMap = _parseXml(bodyStr, typeof(GetBucketRequestPaymentResponse));
                    return TeaModel.ToObject<GetBucketRequestPaymentResponse>(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"RequestPaymentConfiguration", respMap["RequestPaymentConfiguration"]},
                        },
                        response_.Headers
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public async Task<GetBucketRequestPaymentResponse> GetBucketRequestPaymentAsync(GetBucketRequestPaymentRequest request, RuntimeObject runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>()
            {
                {"timeouted", "retry"},
                {"readTimeout", _defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", _defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", _default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", _default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", _default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", _default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", _default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", _default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", _defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>()
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>()
                {
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string token = _getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/?requestPayment";
                    request_.Headers = new Dictionary<string, string>()
                    {
                        {"host", GetHost(request.BucketName)},
                        {"date", _getDate()},
                        {"user-agent", _getUserAgent()},
                    };
                    if (!_empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = await GetSignatureAsync(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (_isFail(response_))
                    {
                        bodyStr = _readAsString(response_);
                        respMap = _getErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>()
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    bodyStr = _readAsString(response_);
                    respMap = _parseXml(bodyStr, typeof(GetBucketRequestPaymentResponse));
                    return TeaModel.ToObject<GetBucketRequestPaymentResponse>(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"RequestPaymentConfiguration", respMap["RequestPaymentConfiguration"]},
                        },
                        response_.Headers
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public GetBucketEncryptionResponse GetBucketEncryption(GetBucketEncryptionRequest request, RuntimeObject runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>()
            {
                {"timeouted", "retry"},
                {"readTimeout", _defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", _defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", _default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", _default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", _default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", _default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", _default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", _default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", _defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>()
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>()
                {
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string token = _getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/?encryption";
                    request_.Headers = new Dictionary<string, string>()
                    {
                        {"host", GetHost(request.BucketName)},
                        {"date", _getDate()},
                        {"user-agent", _getUserAgent()},
                    };
                    if (!_empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = GetSignature(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (_isFail(response_))
                    {
                        bodyStr = _readAsString(response_);
                        respMap = _getErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>()
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    bodyStr = _readAsString(response_);
                    respMap = _parseXml(bodyStr, typeof(GetBucketEncryptionResponse));
                    return TeaModel.ToObject<GetBucketEncryptionResponse>(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"ServerSideEncryptionRule", respMap["ServerSideEncryptionRule"]},
                        },
                        response_.Headers
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public async Task<GetBucketEncryptionResponse> GetBucketEncryptionAsync(GetBucketEncryptionRequest request, RuntimeObject runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>()
            {
                {"timeouted", "retry"},
                {"readTimeout", _defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", _defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", _default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", _default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", _default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", _default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", _default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", _default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", _defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>()
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>()
                {
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string token = _getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/?encryption";
                    request_.Headers = new Dictionary<string, string>()
                    {
                        {"host", GetHost(request.BucketName)},
                        {"date", _getDate()},
                        {"user-agent", _getUserAgent()},
                    };
                    if (!_empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = await GetSignatureAsync(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (_isFail(response_))
                    {
                        bodyStr = _readAsString(response_);
                        respMap = _getErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>()
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    bodyStr = _readAsString(response_);
                    respMap = _parseXml(bodyStr, typeof(GetBucketEncryptionResponse));
                    return TeaModel.ToObject<GetBucketEncryptionResponse>(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"ServerSideEncryptionRule", respMap["ServerSideEncryptionRule"]},
                        },
                        response_.Headers
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public GetBucketTagsResponse GetBucketTags(GetBucketTagsRequest request, RuntimeObject runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>()
            {
                {"timeouted", "retry"},
                {"readTimeout", _defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", _defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", _default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", _default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", _default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", _default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", _default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", _default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", _defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>()
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>()
                {
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string token = _getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/?tagging";
                    request_.Headers = new Dictionary<string, string>()
                    {
                        {"host", GetHost(request.BucketName)},
                        {"date", _getDate()},
                        {"user-agent", _getUserAgent()},
                    };
                    if (!_empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = GetSignature(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (_isFail(response_))
                    {
                        bodyStr = _readAsString(response_);
                        respMap = _getErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>()
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    bodyStr = _readAsString(response_);
                    respMap = _parseXml(bodyStr, typeof(GetBucketTagsResponse));
                    return TeaModel.ToObject<GetBucketTagsResponse>(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"Tagging", respMap["Tagging"]},
                        },
                        response_.Headers
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public async Task<GetBucketTagsResponse> GetBucketTagsAsync(GetBucketTagsRequest request, RuntimeObject runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>()
            {
                {"timeouted", "retry"},
                {"readTimeout", _defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", _defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", _default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", _default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", _default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", _default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", _default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", _default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", _defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>()
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>()
                {
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string token = _getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/?tagging";
                    request_.Headers = new Dictionary<string, string>()
                    {
                        {"host", GetHost(request.BucketName)},
                        {"date", _getDate()},
                        {"user-agent", _getUserAgent()},
                    };
                    if (!_empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = await GetSignatureAsync(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (_isFail(response_))
                    {
                        bodyStr = _readAsString(response_);
                        respMap = _getErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>()
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    bodyStr = _readAsString(response_);
                    respMap = _parseXml(bodyStr, typeof(GetBucketTagsResponse));
                    return TeaModel.ToObject<GetBucketTagsResponse>(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"Tagging", respMap["Tagging"]},
                        },
                        response_.Headers
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public GetServiceResponse GetService(GetServiceRequest request, RuntimeObject runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>()
            {
                {"timeouted", "retry"},
                {"readTimeout", _defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", _defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", _default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", _default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", _default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", _default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", _default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", _default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", _defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>()
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>()
                {
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string token = _getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/";
                    request_.Headers = new Dictionary<string, string>()
                    {
                        {"host", GetHost("")},
                        {"date", _getDate()},
                        {"user-agent", _getUserAgent()},
                    };
                    if (!_empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Query = _toQuery(request.Filter.ToMap());
                    request_.Headers["authorization"] = GetSignature(request_, "");
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (_isFail(response_))
                    {
                        bodyStr = _readAsString(response_);
                        respMap = _getErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>()
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    bodyStr = _readAsString(response_);
                    respMap = _parseXml(bodyStr, typeof(GetServiceResponse));
                    return TeaModel.ToObject<GetServiceResponse>(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"ListAllMyBucketsResult", respMap["ListAllMyBucketsResult"]},
                        },
                        response_.Headers
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public async Task<GetServiceResponse> GetServiceAsync(GetServiceRequest request, RuntimeObject runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>()
            {
                {"timeouted", "retry"},
                {"readTimeout", _defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", _defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", _default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", _default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", _default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", _default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", _default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", _default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", _defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>()
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>()
                {
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string token = _getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/";
                    request_.Headers = new Dictionary<string, string>()
                    {
                        {"host", GetHost("")},
                        {"date", _getDate()},
                        {"user-agent", _getUserAgent()},
                    };
                    if (!_empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Query = _toQuery(request.Filter.ToMap());
                    request_.Headers["authorization"] = await GetSignatureAsync(request_, "");
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (_isFail(response_))
                    {
                        bodyStr = _readAsString(response_);
                        respMap = _getErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>()
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    bodyStr = _readAsString(response_);
                    respMap = _parseXml(bodyStr, typeof(GetServiceResponse));
                    return TeaModel.ToObject<GetServiceResponse>(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"ListAllMyBucketsResult", respMap["ListAllMyBucketsResult"]},
                        },
                        response_.Headers
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public DeleteBucketEncryptionResponse DeleteBucketEncryption(DeleteBucketEncryptionRequest request, RuntimeObject runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>()
            {
                {"timeouted", "retry"},
                {"readTimeout", _defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", _defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", _default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", _default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", _default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", _default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", _default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", _default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", _defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>()
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>()
                {
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string token = _getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "DELETE";
                    request_.Pathname = "/?encryption";
                    request_.Headers = new Dictionary<string, string>()
                    {
                        {"host", GetHost(request.BucketName)},
                        {"date", _getDate()},
                        {"user-agent", _getUserAgent()},
                    };
                    if (!_empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = GetSignature(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (_isFail(response_))
                    {
                        bodyStr = _readAsString(response_);
                        respMap = _getErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>()
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    return TeaModel.ToObject<DeleteBucketEncryptionResponse>(TeaConverter.merge<string>
                    (
                        response_.Headers
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public async Task<DeleteBucketEncryptionResponse> DeleteBucketEncryptionAsync(DeleteBucketEncryptionRequest request, RuntimeObject runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>()
            {
                {"timeouted", "retry"},
                {"readTimeout", _defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", _defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", _default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", _default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", _default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", _default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", _default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", _default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", _defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>()
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>()
                {
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string token = _getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "DELETE";
                    request_.Pathname = "/?encryption";
                    request_.Headers = new Dictionary<string, string>()
                    {
                        {"host", GetHost(request.BucketName)},
                        {"date", _getDate()},
                        {"user-agent", _getUserAgent()},
                    };
                    if (!_empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = await GetSignatureAsync(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (_isFail(response_))
                    {
                        bodyStr = _readAsString(response_);
                        respMap = _getErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>()
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    return TeaModel.ToObject<DeleteBucketEncryptionResponse>(TeaConverter.merge<string>
                    (
                        response_.Headers
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public DeleteBucketTagsResponse DeleteBucketTags(DeleteBucketTagsRequest request, RuntimeObject runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>()
            {
                {"timeouted", "retry"},
                {"readTimeout", _defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", _defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", _default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", _default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", _default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", _default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", _default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", _default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", _defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>()
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>()
                {
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string token = _getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "DELETE";
                    request_.Pathname = "/";
                    request_.Headers = new Dictionary<string, string>()
                    {
                        {"host", GetHost(request.BucketName)},
                        {"date", _getDate()},
                        {"user-agent", _getUserAgent()},
                    };
                    if (!_empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Query = _toQuery(request.Filter.ToMap());
                    request_.Headers["authorization"] = GetSignature(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (_isFail(response_))
                    {
                        bodyStr = _readAsString(response_);
                        respMap = _getErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>()
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    return TeaModel.ToObject<DeleteBucketTagsResponse>(TeaConverter.merge<string>
                    (
                        response_.Headers
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public async Task<DeleteBucketTagsResponse> DeleteBucketTagsAsync(DeleteBucketTagsRequest request, RuntimeObject runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>()
            {
                {"timeouted", "retry"},
                {"readTimeout", _defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", _defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", _default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", _default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", _default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", _default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", _default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", _default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", _defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>()
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>()
                {
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string token = _getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "DELETE";
                    request_.Pathname = "/";
                    request_.Headers = new Dictionary<string, string>()
                    {
                        {"host", GetHost(request.BucketName)},
                        {"date", _getDate()},
                        {"user-agent", _getUserAgent()},
                    };
                    if (!_empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Query = _toQuery(request.Filter.ToMap());
                    request_.Headers["authorization"] = await GetSignatureAsync(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (_isFail(response_))
                    {
                        bodyStr = _readAsString(response_);
                        respMap = _getErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>()
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    return TeaModel.ToObject<DeleteBucketTagsResponse>(TeaConverter.merge<string>
                    (
                        response_.Headers
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public GetBucketWebsiteResponse GetBucketWebsite(GetBucketWebsiteRequest request, RuntimeObject runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>()
            {
                {"timeouted", "retry"},
                {"readTimeout", _defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", _defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", _default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", _default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", _default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", _default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", _default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", _default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", _defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>()
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>()
                {
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string token = _getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/?website";
                    request_.Headers = new Dictionary<string, string>()
                    {
                        {"host", GetHost(request.BucketName)},
                        {"date", _getDate()},
                        {"user-agent", _getUserAgent()},
                    };
                    if (!_empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = GetSignature(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (_isFail(response_))
                    {
                        bodyStr = _readAsString(response_);
                        respMap = _getErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>()
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    bodyStr = _readAsString(response_);
                    respMap = _parseXml(bodyStr, typeof(GetBucketWebsiteResponse));
                    return TeaModel.ToObject<GetBucketWebsiteResponse>(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"WebsiteConfiguration", respMap["WebsiteConfiguration"]},
                        },
                        response_.Headers
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public async Task<GetBucketWebsiteResponse> GetBucketWebsiteAsync(GetBucketWebsiteRequest request, RuntimeObject runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>()
            {
                {"timeouted", "retry"},
                {"readTimeout", _defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", _defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", _default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", _default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", _default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", _default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", _default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", _default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", _defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>()
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>()
                {
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string token = _getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/?website";
                    request_.Headers = new Dictionary<string, string>()
                    {
                        {"host", GetHost(request.BucketName)},
                        {"date", _getDate()},
                        {"user-agent", _getUserAgent()},
                    };
                    if (!_empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = await GetSignatureAsync(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (_isFail(response_))
                    {
                        bodyStr = _readAsString(response_);
                        respMap = _getErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>()
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    bodyStr = _readAsString(response_);
                    respMap = _parseXml(bodyStr, typeof(GetBucketWebsiteResponse));
                    return TeaModel.ToObject<GetBucketWebsiteResponse>(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"WebsiteConfiguration", respMap["WebsiteConfiguration"]},
                        },
                        response_.Headers
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public DeleteLiveChannelResponse DeleteLiveChannel(DeleteLiveChannelRequest request, RuntimeObject runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>()
            {
                {"timeouted", "retry"},
                {"readTimeout", _defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", _defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", _default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", _default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", _default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", _default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", _default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", _default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", _defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>()
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>()
                {
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string token = _getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "DELETE";
                    request_.Pathname = "/" + request.ChannelName + "?live";
                    request_.Headers = new Dictionary<string, string>()
                    {
                        {"host", GetHost(request.BucketName)},
                        {"date", _getDate()},
                        {"user-agent", _getUserAgent()},
                    };
                    if (!_empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = GetSignature(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (_isFail(response_))
                    {
                        bodyStr = _readAsString(response_);
                        respMap = _getErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>()
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    return TeaModel.ToObject<DeleteLiveChannelResponse>(TeaConverter.merge<string>
                    (
                        response_.Headers
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public async Task<DeleteLiveChannelResponse> DeleteLiveChannelAsync(DeleteLiveChannelRequest request, RuntimeObject runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>()
            {
                {"timeouted", "retry"},
                {"readTimeout", _defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", _defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", _default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", _default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", _default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", _default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", _default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", _default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", _defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>()
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>()
                {
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string token = _getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "DELETE";
                    request_.Pathname = "/" + request.ChannelName + "?live";
                    request_.Headers = new Dictionary<string, string>()
                    {
                        {"host", GetHost(request.BucketName)},
                        {"date", _getDate()},
                        {"user-agent", _getUserAgent()},
                    };
                    if (!_empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = await GetSignatureAsync(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (_isFail(response_))
                    {
                        bodyStr = _readAsString(response_);
                        respMap = _getErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>()
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    return TeaModel.ToObject<DeleteLiveChannelResponse>(TeaConverter.merge<string>
                    (
                        response_.Headers
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public GetBucketLocationResponse GetBucketLocation(GetBucketLocationRequest request, RuntimeObject runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>()
            {
                {"timeouted", "retry"},
                {"readTimeout", _defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", _defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", _default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", _default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", _default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", _default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", _default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", _default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", _defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>()
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>()
                {
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string token = _getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/?location";
                    request_.Headers = new Dictionary<string, string>()
                    {
                        {"host", GetHost(request.BucketName)},
                        {"date", _getDate()},
                        {"user-agent", _getUserAgent()},
                    };
                    if (!_empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = GetSignature(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (_isFail(response_))
                    {
                        bodyStr = _readAsString(response_);
                        respMap = _getErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>()
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    bodyStr = _readAsString(response_);
                    respMap = _parseXml(bodyStr, typeof(GetBucketLocationResponse));
                    return TeaModel.ToObject<GetBucketLocationResponse>(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"LocationConstraint", respMap["LocationConstraint"]},
                        },
                        response_.Headers
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public async Task<GetBucketLocationResponse> GetBucketLocationAsync(GetBucketLocationRequest request, RuntimeObject runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>()
            {
                {"timeouted", "retry"},
                {"readTimeout", _defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", _defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", _default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", _default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", _default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", _default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", _default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", _default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", _defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>()
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>()
                {
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string token = _getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/?location";
                    request_.Headers = new Dictionary<string, string>()
                    {
                        {"host", GetHost(request.BucketName)},
                        {"date", _getDate()},
                        {"user-agent", _getUserAgent()},
                    };
                    if (!_empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = await GetSignatureAsync(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (_isFail(response_))
                    {
                        bodyStr = _readAsString(response_);
                        respMap = _getErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>()
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    bodyStr = _readAsString(response_);
                    respMap = _parseXml(bodyStr, typeof(GetBucketLocationResponse));
                    return TeaModel.ToObject<GetBucketLocationResponse>(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"LocationConstraint", respMap["LocationConstraint"]},
                        },
                        response_.Headers
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public ListLiveChannelResponse ListLiveChannel(ListLiveChannelRequest request, RuntimeObject runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>()
            {
                {"timeouted", "retry"},
                {"readTimeout", _defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", _defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", _default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", _default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", _default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", _default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", _default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", _default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", _defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>()
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>()
                {
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string token = _getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/?live";
                    request_.Headers = new Dictionary<string, string>()
                    {
                        {"host", GetHost(request.BucketName)},
                        {"date", _getDate()},
                        {"user-agent", _getUserAgent()},
                    };
                    if (!_empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Query = _toQuery(request.Filter.ToMap());
                    request_.Headers["authorization"] = GetSignature(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (_isFail(response_))
                    {
                        bodyStr = _readAsString(response_);
                        respMap = _getErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>()
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    bodyStr = _readAsString(response_);
                    respMap = _parseXml(bodyStr, typeof(ListLiveChannelResponse));
                    return TeaModel.ToObject<ListLiveChannelResponse>(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"ListLiveChannelResult", respMap["ListLiveChannelResult"]},
                        },
                        response_.Headers
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public async Task<ListLiveChannelResponse> ListLiveChannelAsync(ListLiveChannelRequest request, RuntimeObject runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>()
            {
                {"timeouted", "retry"},
                {"readTimeout", _defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", _defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", _default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", _default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", _default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", _default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", _default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", _default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", _defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>()
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>()
                {
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string token = _getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/?live";
                    request_.Headers = new Dictionary<string, string>()
                    {
                        {"host", GetHost(request.BucketName)},
                        {"date", _getDate()},
                        {"user-agent", _getUserAgent()},
                    };
                    if (!_empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Query = _toQuery(request.Filter.ToMap());
                    request_.Headers["authorization"] = await GetSignatureAsync(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (_isFail(response_))
                    {
                        bodyStr = _readAsString(response_);
                        respMap = _getErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>()
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    bodyStr = _readAsString(response_);
                    respMap = _parseXml(bodyStr, typeof(ListLiveChannelResponse));
                    return TeaModel.ToObject<ListLiveChannelResponse>(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"ListLiveChannelResult", respMap["ListLiveChannelResult"]},
                        },
                        response_.Headers
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public GetObjectMetaResponse GetObjectMeta(GetObjectMetaRequest request, RuntimeObject runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>()
            {
                {"timeouted", "retry"},
                {"readTimeout", _defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", _defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", _default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", _default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", _default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", _default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", _default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", _default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", _defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>()
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>()
                {
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string token = _getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "HEAD";
                    request_.Pathname = "/" + request.ObjectName + "?objectMeta";
                    request_.Headers = new Dictionary<string, string>()
                    {
                        {"host", GetHost(request.BucketName)},
                        {"date", _getDate()},
                        {"user-agent", _getUserAgent()},
                    };
                    if (!_empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = GetSignature(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (_isFail(response_))
                    {
                        bodyStr = _readAsString(response_);
                        respMap = _getErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>()
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    return TeaModel.ToObject<GetObjectMetaResponse>(TeaConverter.merge<string>
                    (
                        response_.Headers
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public async Task<GetObjectMetaResponse> GetObjectMetaAsync(GetObjectMetaRequest request, RuntimeObject runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>()
            {
                {"timeouted", "retry"},
                {"readTimeout", _defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", _defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", _default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", _default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", _default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", _default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", _default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", _default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", _defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>()
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>()
                {
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string token = _getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "HEAD";
                    request_.Pathname = "/" + request.ObjectName + "?objectMeta";
                    request_.Headers = new Dictionary<string, string>()
                    {
                        {"host", GetHost(request.BucketName)},
                        {"date", _getDate()},
                        {"user-agent", _getUserAgent()},
                    };
                    if (!_empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = await GetSignatureAsync(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (_isFail(response_))
                    {
                        bodyStr = _readAsString(response_);
                        respMap = _getErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>()
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    return TeaModel.ToObject<GetObjectMetaResponse>(TeaConverter.merge<string>
                    (
                        response_.Headers
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public GetBucketAclResponse GetBucketAcl(GetBucketAclRequest request, RuntimeObject runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>()
            {
                {"timeouted", "retry"},
                {"readTimeout", _defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", _defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", _default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", _default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", _default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", _default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", _default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", _default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", _defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>()
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>()
                {
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string token = _getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/?acl";
                    request_.Headers = new Dictionary<string, string>()
                    {
                        {"host", GetHost(request.BucketName)},
                        {"date", _getDate()},
                        {"user-agent", _getUserAgent()},
                    };
                    if (!_empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = GetSignature(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (_isFail(response_))
                    {
                        bodyStr = _readAsString(response_);
                        respMap = _getErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>()
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    bodyStr = _readAsString(response_);
                    respMap = _parseXml(bodyStr, typeof(GetBucketAclResponse));
                    return TeaModel.ToObject<GetBucketAclResponse>(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"AccessControlPolicy", respMap["AccessControlPolicy"]},
                        },
                        response_.Headers
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public async Task<GetBucketAclResponse> GetBucketAclAsync(GetBucketAclRequest request, RuntimeObject runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>()
            {
                {"timeouted", "retry"},
                {"readTimeout", _defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", _defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", _default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", _default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", _default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", _default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", _default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", _default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", _defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>()
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>()
                {
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string token = _getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/?acl";
                    request_.Headers = new Dictionary<string, string>()
                    {
                        {"host", GetHost(request.BucketName)},
                        {"date", _getDate()},
                        {"user-agent", _getUserAgent()},
                    };
                    if (!_empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = await GetSignatureAsync(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (_isFail(response_))
                    {
                        bodyStr = _readAsString(response_);
                        respMap = _getErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>()
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    bodyStr = _readAsString(response_);
                    respMap = _parseXml(bodyStr, typeof(GetBucketAclResponse));
                    return TeaModel.ToObject<GetBucketAclResponse>(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"AccessControlPolicy", respMap["AccessControlPolicy"]},
                        },
                        response_.Headers
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public ListPartsResponse ListParts(ListPartsRequest request, RuntimeObject runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>()
            {
                {"timeouted", "retry"},
                {"readTimeout", _defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", _defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", _default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", _default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", _default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", _default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", _default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", _default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", _defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>()
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>()
                {
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string token = _getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/" + request.ObjectName;
                    request_.Headers = new Dictionary<string, string>()
                    {
                        {"host", GetHost(request.BucketName)},
                        {"date", _getDate()},
                        {"user-agent", _getUserAgent()},
                    };
                    if (!_empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Query = _toQuery(request.Filter.ToMap());
                    request_.Headers["authorization"] = GetSignature(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (_isFail(response_))
                    {
                        bodyStr = _readAsString(response_);
                        respMap = _getErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>()
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    bodyStr = _readAsString(response_);
                    respMap = _parseXml(bodyStr, typeof(ListPartsResponse));
                    return TeaModel.ToObject<ListPartsResponse>(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"ListPartsResult", respMap["ListPartsResult"]},
                        },
                        response_.Headers
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public async Task<ListPartsResponse> ListPartsAsync(ListPartsRequest request, RuntimeObject runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>()
            {
                {"timeouted", "retry"},
                {"readTimeout", _defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", _defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", _default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", _default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", _default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", _default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", _default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", _default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", _defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>()
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>()
                {
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string token = _getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/" + request.ObjectName;
                    request_.Headers = new Dictionary<string, string>()
                    {
                        {"host", GetHost(request.BucketName)},
                        {"date", _getDate()},
                        {"user-agent", _getUserAgent()},
                    };
                    if (!_empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Query = _toQuery(request.Filter.ToMap());
                    request_.Headers["authorization"] = await GetSignatureAsync(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (_isFail(response_))
                    {
                        bodyStr = _readAsString(response_);
                        respMap = _getErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>()
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    bodyStr = _readAsString(response_);
                    respMap = _parseXml(bodyStr, typeof(ListPartsResponse));
                    return TeaModel.ToObject<ListPartsResponse>(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"ListPartsResult", respMap["ListPartsResult"]},
                        },
                        response_.Headers
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public GetLiveChannelHistoryResponse GetLiveChannelHistory(GetLiveChannelHistoryRequest request, RuntimeObject runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>()
            {
                {"timeouted", "retry"},
                {"readTimeout", _defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", _defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", _default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", _default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", _default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", _default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", _default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", _default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", _defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>()
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>()
                {
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string token = _getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/" + request.ChannelName + "?live";
                    request_.Headers = new Dictionary<string, string>()
                    {
                        {"host", GetHost(request.BucketName)},
                        {"date", _getDate()},
                        {"user-agent", _getUserAgent()},
                    };
                    if (!_empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Query = _toQuery(request.Filter.ToMap());
                    request_.Headers["authorization"] = GetSignature(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (_isFail(response_))
                    {
                        bodyStr = _readAsString(response_);
                        respMap = _getErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>()
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    bodyStr = _readAsString(response_);
                    respMap = _parseXml(bodyStr, typeof(GetLiveChannelHistoryResponse));
                    return TeaModel.ToObject<GetLiveChannelHistoryResponse>(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"LiveChannelHistory", respMap["LiveChannelHistory"]},
                        },
                        response_.Headers
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public async Task<GetLiveChannelHistoryResponse> GetLiveChannelHistoryAsync(GetLiveChannelHistoryRequest request, RuntimeObject runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>()
            {
                {"timeouted", "retry"},
                {"readTimeout", _defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", _defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", _default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", _default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", _default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", _default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", _default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", _default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", _defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>()
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>()
                {
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string token = _getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/" + request.ChannelName + "?live";
                    request_.Headers = new Dictionary<string, string>()
                    {
                        {"host", GetHost(request.BucketName)},
                        {"date", _getDate()},
                        {"user-agent", _getUserAgent()},
                    };
                    if (!_empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Query = _toQuery(request.Filter.ToMap());
                    request_.Headers["authorization"] = await GetSignatureAsync(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (_isFail(response_))
                    {
                        bodyStr = _readAsString(response_);
                        respMap = _getErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>()
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    bodyStr = _readAsString(response_);
                    respMap = _parseXml(bodyStr, typeof(GetLiveChannelHistoryResponse));
                    return TeaModel.ToObject<GetLiveChannelHistoryResponse>(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"LiveChannelHistory", respMap["LiveChannelHistory"]},
                        },
                        response_.Headers
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public GetBucketResponse GetBucket(GetBucketRequest request, RuntimeObject runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>()
            {
                {"timeouted", "retry"},
                {"readTimeout", _defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", _defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", _default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", _default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", _default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", _default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", _default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", _default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", _defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>()
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>()
                {
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string token = _getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/";
                    request_.Headers = new Dictionary<string, string>()
                    {
                        {"host", GetHost(request.BucketName)},
                        {"date", _getDate()},
                        {"user-agent", _getUserAgent()},
                    };
                    if (!_empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Query = _toQuery(request.Filter.ToMap());
                    request_.Headers["authorization"] = GetSignature(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (_isFail(response_))
                    {
                        bodyStr = _readAsString(response_);
                        respMap = _getErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>()
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    bodyStr = _readAsString(response_);
                    respMap = _parseXml(bodyStr, typeof(GetBucketResponse));
                    return TeaModel.ToObject<GetBucketResponse>(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"ListBucketResult", respMap["ListBucketResult"]},
                        },
                        response_.Headers
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public async Task<GetBucketResponse> GetBucketAsync(GetBucketRequest request, RuntimeObject runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>()
            {
                {"timeouted", "retry"},
                {"readTimeout", _defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", _defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", _default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", _default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", _default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", _default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", _default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", _default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", _defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>()
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>()
                {
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string token = _getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/";
                    request_.Headers = new Dictionary<string, string>()
                    {
                        {"host", GetHost(request.BucketName)},
                        {"date", _getDate()},
                        {"user-agent", _getUserAgent()},
                    };
                    if (!_empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Query = _toQuery(request.Filter.ToMap());
                    request_.Headers["authorization"] = await GetSignatureAsync(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (_isFail(response_))
                    {
                        bodyStr = _readAsString(response_);
                        respMap = _getErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>()
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    bodyStr = _readAsString(response_);
                    respMap = _parseXml(bodyStr, typeof(GetBucketResponse));
                    return TeaModel.ToObject<GetBucketResponse>(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"ListBucketResult", respMap["ListBucketResult"]},
                        },
                        response_.Headers
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public GetLiveChannelInfoResponse GetLiveChannelInfo(GetLiveChannelInfoRequest request, RuntimeObject runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>()
            {
                {"timeouted", "retry"},
                {"readTimeout", _defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", _defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", _default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", _default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", _default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", _default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", _default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", _default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", _defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>()
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>()
                {
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string token = _getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/" + request.ChannelName + "?live";
                    request_.Headers = new Dictionary<string, string>()
                    {
                        {"host", GetHost(request.BucketName)},
                        {"date", _getDate()},
                        {"user-agent", _getUserAgent()},
                    };
                    if (!_empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = GetSignature(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (_isFail(response_))
                    {
                        bodyStr = _readAsString(response_);
                        respMap = _getErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>()
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    bodyStr = _readAsString(response_);
                    respMap = _parseXml(bodyStr, typeof(GetLiveChannelInfoResponse));
                    return TeaModel.ToObject<GetLiveChannelInfoResponse>(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"LiveChannelConfiguration", respMap["LiveChannelConfiguration"]},
                        },
                        response_.Headers
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public async Task<GetLiveChannelInfoResponse> GetLiveChannelInfoAsync(GetLiveChannelInfoRequest request, RuntimeObject runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>()
            {
                {"timeouted", "retry"},
                {"readTimeout", _defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", _defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", _default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", _default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", _default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", _default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", _default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", _default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", _defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>()
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>()
                {
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string token = _getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/" + request.ChannelName + "?live";
                    request_.Headers = new Dictionary<string, string>()
                    {
                        {"host", GetHost(request.BucketName)},
                        {"date", _getDate()},
                        {"user-agent", _getUserAgent()},
                    };
                    if (!_empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = await GetSignatureAsync(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (_isFail(response_))
                    {
                        bodyStr = _readAsString(response_);
                        respMap = _getErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>()
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    bodyStr = _readAsString(response_);
                    respMap = _parseXml(bodyStr, typeof(GetLiveChannelInfoResponse));
                    return TeaModel.ToObject<GetLiveChannelInfoResponse>(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"LiveChannelConfiguration", respMap["LiveChannelConfiguration"]},
                        },
                        response_.Headers
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public GetLiveChannelStatResponse GetLiveChannelStat(GetLiveChannelStatRequest request, RuntimeObject runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>()
            {
                {"timeouted", "retry"},
                {"readTimeout", _defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", _defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", _default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", _default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", _default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", _default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", _default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", _default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", _defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>()
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>()
                {
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string token = _getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/" + request.ChannelName + "?live";
                    request_.Headers = new Dictionary<string, string>()
                    {
                        {"host", GetHost(request.BucketName)},
                        {"date", _getDate()},
                        {"user-agent", _getUserAgent()},
                    };
                    if (!_empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Query = _toQuery(request.Filter.ToMap());
                    request_.Headers["authorization"] = GetSignature(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (_isFail(response_))
                    {
                        bodyStr = _readAsString(response_);
                        respMap = _getErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>()
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    bodyStr = _readAsString(response_);
                    respMap = _parseXml(bodyStr, typeof(GetLiveChannelStatResponse));
                    return TeaModel.ToObject<GetLiveChannelStatResponse>(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"LiveChannelStat", respMap["LiveChannelStat"]},
                        },
                        response_.Headers
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public async Task<GetLiveChannelStatResponse> GetLiveChannelStatAsync(GetLiveChannelStatRequest request, RuntimeObject runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>()
            {
                {"timeouted", "retry"},
                {"readTimeout", _defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", _defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", _default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", _default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", _default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", _default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", _default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", _default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", _defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>()
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>()
                {
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string token = _getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/" + request.ChannelName + "?live";
                    request_.Headers = new Dictionary<string, string>()
                    {
                        {"host", GetHost(request.BucketName)},
                        {"date", _getDate()},
                        {"user-agent", _getUserAgent()},
                    };
                    if (!_empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Query = _toQuery(request.Filter.ToMap());
                    request_.Headers["authorization"] = await GetSignatureAsync(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (_isFail(response_))
                    {
                        bodyStr = _readAsString(response_);
                        respMap = _getErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>()
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    bodyStr = _readAsString(response_);
                    respMap = _parseXml(bodyStr, typeof(GetLiveChannelStatResponse));
                    return TeaModel.ToObject<GetLiveChannelStatResponse>(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"LiveChannelStat", respMap["LiveChannelStat"]},
                        },
                        response_.Headers
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public DeleteObjectResponse DeleteObject(DeleteObjectRequest request, RuntimeObject runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>()
            {
                {"timeouted", "retry"},
                {"readTimeout", _defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", _defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", _default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", _default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", _default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", _default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", _default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", _default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", _defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>()
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>()
                {
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string token = _getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "DELETE";
                    request_.Pathname = "/" + request.ObjectName;
                    request_.Headers = new Dictionary<string, string>()
                    {
                        {"host", GetHost(request.BucketName)},
                        {"date", _getDate()},
                        {"user-agent", _getUserAgent()},
                    };
                    if (!_empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = GetSignature(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (_isFail(response_))
                    {
                        bodyStr = _readAsString(response_);
                        respMap = _getErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>()
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    return TeaModel.ToObject<DeleteObjectResponse>(TeaConverter.merge<string>
                    (
                        response_.Headers
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public async Task<DeleteObjectResponse> DeleteObjectAsync(DeleteObjectRequest request, RuntimeObject runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>()
            {
                {"timeouted", "retry"},
                {"readTimeout", _defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", _defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", _default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", _default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", _default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", _default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", _default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", _default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", _defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>()
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>()
                {
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string token = _getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "DELETE";
                    request_.Pathname = "/" + request.ObjectName;
                    request_.Headers = new Dictionary<string, string>()
                    {
                        {"host", GetHost(request.BucketName)},
                        {"date", _getDate()},
                        {"user-agent", _getUserAgent()},
                    };
                    if (!_empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = await GetSignatureAsync(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (_isFail(response_))
                    {
                        bodyStr = _readAsString(response_);
                        respMap = _getErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>()
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    return TeaModel.ToObject<DeleteObjectResponse>(TeaConverter.merge<string>
                    (
                        response_.Headers
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public AbortMultipartUploadResponse AbortMultipartUpload(AbortMultipartUploadRequest request, RuntimeObject runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>()
            {
                {"timeouted", "retry"},
                {"readTimeout", _defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", _defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", _default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", _default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", _default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", _default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", _default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", _default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", _defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>()
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>()
                {
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string token = _getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "DELETE";
                    request_.Pathname = "/" + request.ObjectName;
                    request_.Headers = new Dictionary<string, string>()
                    {
                        {"host", GetHost(request.BucketName)},
                        {"date", _getDate()},
                        {"user-agent", _getUserAgent()},
                    };
                    if (!_empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Query = _toQuery(request.Filter.ToMap());
                    request_.Headers["authorization"] = GetSignature(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (_isFail(response_))
                    {
                        bodyStr = _readAsString(response_);
                        respMap = _getErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>()
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    return TeaModel.ToObject<AbortMultipartUploadResponse>(TeaConverter.merge<string>
                    (
                        response_.Headers
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public async Task<AbortMultipartUploadResponse> AbortMultipartUploadAsync(AbortMultipartUploadRequest request, RuntimeObject runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>()
            {
                {"timeouted", "retry"},
                {"readTimeout", _defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", _defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", _default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", _default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", _default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", _default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", _default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", _default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", _defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>()
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>()
                {
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string token = _getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "DELETE";
                    request_.Pathname = "/" + request.ObjectName;
                    request_.Headers = new Dictionary<string, string>()
                    {
                        {"host", GetHost(request.BucketName)},
                        {"date", _getDate()},
                        {"user-agent", _getUserAgent()},
                    };
                    if (!_empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Query = _toQuery(request.Filter.ToMap());
                    request_.Headers["authorization"] = await GetSignatureAsync(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (_isFail(response_))
                    {
                        bodyStr = _readAsString(response_);
                        respMap = _getErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>()
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    return TeaModel.ToObject<AbortMultipartUploadResponse>(TeaConverter.merge<string>
                    (
                        response_.Headers
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public AppendObjectResponse AppendObject(AppendObjectRequest request, RuntimeObject runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>()
            {
                {"timeouted", "retry"},
                {"readTimeout", _defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", _defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", _default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", _default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", _default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", _default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", _default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", _default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", _defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>()
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>()
                {
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    Dictionary<string, string> ctx = new Dictionary<string, string>(){};
                    string token = _getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "POST";
                    request_.Pathname = "/" + request.ObjectName + "?append";
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"host", GetHost(request.BucketName)},
                            {"date", _getDate()},
                            {"user-agent", _getUserAgent()},
                        },
                        _toHeader(request.Header.ToMap()),
                        _parseMeta(request.UserMeta, "x-oss-meta-")
                    );
                    if (!_empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Query = _toQuery(request.Filter.ToMap());
                    request_.Body = _inject(request.Body, ctx);
                    if (_notNull(request.Header.ToMap()) && !_empty(request.Header.ContentType))
                    {
                        request_.Headers["content-type"] = request.Header.ContentType;
                    }
else
                    {
                        request_.Headers["content-type"] = _getContentType(request.ObjectName);
                    }
                    request_.Headers["authorization"] = GetSignature(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (_isFail(response_))
                    {
                        bodyStr = _readAsString(response_);
                        respMap = _getErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>()
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    if (_isEnableCrc && !_equal(ctx["crc"], response_.Headers["x-oss-hash-crc64ecma"]))
                    {
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", "CrcNotMatched"},
                            {"data", new Dictionary<string, string>()
                            {
                                {"clientCrc", ctx["crc"]},
                                {"serverCrc", response_.Headers["x-oss-hash-crc64ecma"]},
                            }},
                        });
                    }
                    if (_isEnableMD5 && !_equal(ctx["md5"], response_.Headers["content-md5"]))
                    {
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", "MD5NotMatched"},
                            {"data", new Dictionary<string, string>()
                            {
                                {"clientMD5", ctx["md5"]},
                                {"serverMD5", response_.Headers["content-md5"]},
                            }},
                        });
                    }
                    return TeaModel.ToObject<AppendObjectResponse>(TeaConverter.merge<string>
                    (
                        response_.Headers
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public async Task<AppendObjectResponse> AppendObjectAsync(AppendObjectRequest request, RuntimeObject runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>()
            {
                {"timeouted", "retry"},
                {"readTimeout", _defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", _defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", _default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", _default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", _default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", _default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", _default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", _default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", _defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>()
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>()
                {
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    Dictionary<string, string> ctx = new Dictionary<string, string>(){};
                    string token = _getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "POST";
                    request_.Pathname = "/" + request.ObjectName + "?append";
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"host", GetHost(request.BucketName)},
                            {"date", _getDate()},
                            {"user-agent", _getUserAgent()},
                        },
                        _toHeader(request.Header.ToMap()),
                        _parseMeta(request.UserMeta, "x-oss-meta-")
                    );
                    if (!_empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Query = _toQuery(request.Filter.ToMap());
                    request_.Body = _inject(request.Body, ctx);
                    if (_notNull(request.Header.ToMap()) && !_empty(request.Header.ContentType))
                    {
                        request_.Headers["content-type"] = request.Header.ContentType;
                    }
else
                    {
                        request_.Headers["content-type"] = _getContentType(request.ObjectName);
                    }
                    request_.Headers["authorization"] = await GetSignatureAsync(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (_isFail(response_))
                    {
                        bodyStr = _readAsString(response_);
                        respMap = _getErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>()
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    if (_isEnableCrc && !_equal(ctx["crc"], response_.Headers["x-oss-hash-crc64ecma"]))
                    {
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", "CrcNotMatched"},
                            {"data", new Dictionary<string, string>()
                            {
                                {"clientCrc", ctx["crc"]},
                                {"serverCrc", response_.Headers["x-oss-hash-crc64ecma"]},
                            }},
                        });
                    }
                    if (_isEnableMD5 && !_equal(ctx["md5"], response_.Headers["content-md5"]))
                    {
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", "MD5NotMatched"},
                            {"data", new Dictionary<string, string>()
                            {
                                {"clientMD5", ctx["md5"]},
                                {"serverMD5", response_.Headers["content-md5"]},
                            }},
                        });
                    }
                    return TeaModel.ToObject<AppendObjectResponse>(TeaConverter.merge<string>
                    (
                        response_.Headers
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public UploadPartCopyResponse UploadPartCopy(UploadPartCopyRequest request, RuntimeObject runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>()
            {
                {"timeouted", "retry"},
                {"readTimeout", _defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", _defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", _default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", _default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", _default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", _default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", _default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", _default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", _defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>()
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>()
                {
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string token = _getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "PUT";
                    request_.Pathname = "/" + request.ObjectName;
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"host", GetHost(request.BucketName)},
                            {"date", _getDate()},
                            {"user-agent", _getUserAgent()},
                        },
                        _toHeader(request.Header.ToMap())
                    );
                    if (!_empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Query = _toQuery(request.Filter.ToMap());
                    request_.Headers["authorization"] = GetSignature(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (_isFail(response_))
                    {
                        bodyStr = _readAsString(response_);
                        respMap = _getErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>()
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    bodyStr = _readAsString(response_);
                    respMap = _parseXml(bodyStr, typeof(UploadPartCopyResponse));
                    return TeaModel.ToObject<UploadPartCopyResponse>(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"CopyPartResult", respMap["CopyPartResult"]},
                        },
                        response_.Headers
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public async Task<UploadPartCopyResponse> UploadPartCopyAsync(UploadPartCopyRequest request, RuntimeObject runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>()
            {
                {"timeouted", "retry"},
                {"readTimeout", _defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", _defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", _default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", _default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", _default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", _default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", _default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", _default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", _defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>()
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>()
                {
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string token = _getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "PUT";
                    request_.Pathname = "/" + request.ObjectName;
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"host", GetHost(request.BucketName)},
                            {"date", _getDate()},
                            {"user-agent", _getUserAgent()},
                        },
                        _toHeader(request.Header.ToMap())
                    );
                    if (!_empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Query = _toQuery(request.Filter.ToMap());
                    request_.Headers["authorization"] = await GetSignatureAsync(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (_isFail(response_))
                    {
                        bodyStr = _readAsString(response_);
                        respMap = _getErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>()
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    bodyStr = _readAsString(response_);
                    respMap = _parseXml(bodyStr, typeof(UploadPartCopyResponse));
                    return TeaModel.ToObject<UploadPartCopyResponse>(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"CopyPartResult", respMap["CopyPartResult"]},
                        },
                        response_.Headers
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public GetVodPlaylistResponse GetVodPlaylist(GetVodPlaylistRequest request, RuntimeObject runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>()
            {
                {"timeouted", "retry"},
                {"readTimeout", _defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", _defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", _default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", _default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", _default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", _default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", _default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", _default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", _defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>()
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>()
                {
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string token = _getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/" + request.ChannelName + "?vod";
                    request_.Headers = new Dictionary<string, string>()
                    {
                        {"host", GetHost(request.BucketName)},
                        {"date", _getDate()},
                        {"user-agent", _getUserAgent()},
                    };
                    if (!_empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Query = _toQuery(request.Filter.ToMap());
                    request_.Headers["authorization"] = GetSignature(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (_isFail(response_))
                    {
                        bodyStr = _readAsString(response_);
                        respMap = _getErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>()
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    return TeaModel.ToObject<GetVodPlaylistResponse>(TeaConverter.merge<string>
                    (
                        response_.Headers
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public async Task<GetVodPlaylistResponse> GetVodPlaylistAsync(GetVodPlaylistRequest request, RuntimeObject runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>()
            {
                {"timeouted", "retry"},
                {"readTimeout", _defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", _defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", _default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", _default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", _default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", _default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", _default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", _default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", _defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>()
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>()
                {
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string token = _getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/" + request.ChannelName + "?vod";
                    request_.Headers = new Dictionary<string, string>()
                    {
                        {"host", GetHost(request.BucketName)},
                        {"date", _getDate()},
                        {"user-agent", _getUserAgent()},
                    };
                    if (!_empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Query = _toQuery(request.Filter.ToMap());
                    request_.Headers["authorization"] = await GetSignatureAsync(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (_isFail(response_))
                    {
                        bodyStr = _readAsString(response_);
                        respMap = _getErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>()
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    return TeaModel.ToObject<GetVodPlaylistResponse>(TeaConverter.merge<string>
                    (
                        response_.Headers
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public DeleteBucketCORSResponse DeleteBucketCORS(DeleteBucketCORSRequest request, RuntimeObject runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>()
            {
                {"timeouted", "retry"},
                {"readTimeout", _defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", _defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", _default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", _default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", _default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", _default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", _default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", _default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", _defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>()
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>()
                {
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string token = _getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "DELETE";
                    request_.Pathname = "/?cors";
                    request_.Headers = new Dictionary<string, string>()
                    {
                        {"host", GetHost(request.BucketName)},
                        {"date", _getDate()},
                        {"user-agent", _getUserAgent()},
                    };
                    if (!_empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = GetSignature(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (_isFail(response_))
                    {
                        bodyStr = _readAsString(response_);
                        respMap = _getErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>()
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    return TeaModel.ToObject<DeleteBucketCORSResponse>(TeaConverter.merge<string>
                    (
                        response_.Headers
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public async Task<DeleteBucketCORSResponse> DeleteBucketCORSAsync(DeleteBucketCORSRequest request, RuntimeObject runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>()
            {
                {"timeouted", "retry"},
                {"readTimeout", _defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", _defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", _default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", _default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", _default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", _default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", _default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", _default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", _defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>()
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>()
                {
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string token = _getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "DELETE";
                    request_.Pathname = "/?cors";
                    request_.Headers = new Dictionary<string, string>()
                    {
                        {"host", GetHost(request.BucketName)},
                        {"date", _getDate()},
                        {"user-agent", _getUserAgent()},
                    };
                    if (!_empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = await GetSignatureAsync(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (_isFail(response_))
                    {
                        bodyStr = _readAsString(response_);
                        respMap = _getErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>()
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    return TeaModel.ToObject<DeleteBucketCORSResponse>(TeaConverter.merge<string>
                    (
                        response_.Headers
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public GetObjectResponse GetObject(GetObjectRequest request, RuntimeObject runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>()
            {
                {"timeouted", "retry"},
                {"readTimeout", _defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", _defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", _default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", _default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", _default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", _default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", _default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", _default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", _defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>()
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>()
                {
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string token = _getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/" + request.ObjectName;
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"host", GetHost(request.BucketName)},
                            {"date", _getDate()},
                            {"user-agent", _getUserAgent()},
                        },
                        _toHeader(request.Header.ToMap())
                    );
                    if (!_empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = GetSignature(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (_isFail(response_))
                    {
                        bodyStr = _readAsString(response_);
                        respMap = _getErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>()
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    return TeaModel.ToObject<GetObjectResponse>(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"body", _readAsStream(response_)},
                        },
                        response_.Headers
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public async Task<GetObjectResponse> GetObjectAsync(GetObjectRequest request, RuntimeObject runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>()
            {
                {"timeouted", "retry"},
                {"readTimeout", _defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", _defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", _default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", _default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", _default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", _default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", _default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", _default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", _defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>()
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>()
                {
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string token = _getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/" + request.ObjectName;
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"host", GetHost(request.BucketName)},
                            {"date", _getDate()},
                            {"user-agent", _getUserAgent()},
                        },
                        _toHeader(request.Header.ToMap())
                    );
                    if (!_empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = await GetSignatureAsync(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (_isFail(response_))
                    {
                        bodyStr = _readAsString(response_);
                        respMap = _getErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>()
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    return TeaModel.ToObject<GetObjectResponse>(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"body", _readAsStream(response_)},
                        },
                        response_.Headers
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public UploadPartResponse UploadPart(UploadPartRequest request, RuntimeObject runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>()
            {
                {"timeouted", "retry"},
                {"readTimeout", _defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", _defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", _default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", _default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", _default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", _default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", _default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", _default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", _defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>()
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>()
                {
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    Dictionary<string, string> ctx = new Dictionary<string, string>(){};
                    string token = _getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "PUT";
                    request_.Pathname = "/" + request.ObjectName;
                    request_.Headers = new Dictionary<string, string>()
                    {
                        {"host", GetHost(request.BucketName)},
                        {"date", _getDate()},
                        {"user-agent", _getUserAgent()},
                    };
                    if (!_empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Query = _toQuery(request.Filter.ToMap());
                    request_.Body = _inject(request.Body, ctx);
                    request_.Headers["authorization"] = GetSignature(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (_isFail(response_))
                    {
                        bodyStr = _readAsString(response_);
                        respMap = _getErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>()
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    if (_isEnableCrc && !_equal(ctx["crc"], response_.Headers["x-oss-hash-crc64ecma"]))
                    {
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", "CrcNotMatched"},
                            {"data", new Dictionary<string, string>()
                            {
                                {"clientCrc", ctx["crc"]},
                                {"serverCrc", response_.Headers["x-oss-hash-crc64ecma"]},
                            }},
                        });
                    }
                    if (_isEnableMD5 && !_equal(ctx["md5"], response_.Headers["content-md5"]))
                    {
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", "MD5NotMatched"},
                            {"data", new Dictionary<string, string>()
                            {
                                {"clientMD5", ctx["md5"]},
                                {"serverMD5", response_.Headers["content-md5"]},
                            }},
                        });
                    }
                    return TeaModel.ToObject<UploadPartResponse>(TeaConverter.merge<string>
                    (
                        response_.Headers
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public async Task<UploadPartResponse> UploadPartAsync(UploadPartRequest request, RuntimeObject runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>()
            {
                {"timeouted", "retry"},
                {"readTimeout", _defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", _defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", _default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", _default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", _default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", _default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", _default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", _default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", _defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>()
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>()
                {
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    Dictionary<string, string> ctx = new Dictionary<string, string>(){};
                    string token = _getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "PUT";
                    request_.Pathname = "/" + request.ObjectName;
                    request_.Headers = new Dictionary<string, string>()
                    {
                        {"host", GetHost(request.BucketName)},
                        {"date", _getDate()},
                        {"user-agent", _getUserAgent()},
                    };
                    if (!_empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Query = _toQuery(request.Filter.ToMap());
                    request_.Body = _inject(request.Body, ctx);
                    request_.Headers["authorization"] = await GetSignatureAsync(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (_isFail(response_))
                    {
                        bodyStr = _readAsString(response_);
                        respMap = _getErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>()
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    if (_isEnableCrc && !_equal(ctx["crc"], response_.Headers["x-oss-hash-crc64ecma"]))
                    {
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", "CrcNotMatched"},
                            {"data", new Dictionary<string, string>()
                            {
                                {"clientCrc", ctx["crc"]},
                                {"serverCrc", response_.Headers["x-oss-hash-crc64ecma"]},
                            }},
                        });
                    }
                    if (_isEnableMD5 && !_equal(ctx["md5"], response_.Headers["content-md5"]))
                    {
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", "MD5NotMatched"},
                            {"data", new Dictionary<string, string>()
                            {
                                {"clientMD5", ctx["md5"]},
                                {"serverMD5", response_.Headers["content-md5"]},
                            }},
                        });
                    }
                    return TeaModel.ToObject<UploadPartResponse>(TeaConverter.merge<string>
                    (
                        response_.Headers
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public GetBucketCORSResponse GetBucketCORS(GetBucketCORSRequest request, RuntimeObject runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>()
            {
                {"timeouted", "retry"},
                {"readTimeout", _defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", _defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", _default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", _default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", _default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", _default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", _default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", _default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", _defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>()
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>()
                {
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string token = _getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/?cors";
                    request_.Headers = new Dictionary<string, string>()
                    {
                        {"host", GetHost(request.BucketName)},
                        {"date", _getDate()},
                        {"user-agent", _getUserAgent()},
                    };
                    if (!_empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = GetSignature(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (_isFail(response_))
                    {
                        bodyStr = _readAsString(response_);
                        respMap = _getErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>()
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    bodyStr = _readAsString(response_);
                    respMap = _parseXml(bodyStr, typeof(GetBucketCORSResponse));
                    return TeaModel.ToObject<GetBucketCORSResponse>(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"CORSConfiguration", respMap["CORSConfiguration"]},
                        },
                        response_.Headers
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public async Task<GetBucketCORSResponse> GetBucketCORSAsync(GetBucketCORSRequest request, RuntimeObject runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>()
            {
                {"timeouted", "retry"},
                {"readTimeout", _defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", _defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", _default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", _default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", _default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", _default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", _default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", _default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", _defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>()
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>()
                {
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string token = _getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/?cors";
                    request_.Headers = new Dictionary<string, string>()
                    {
                        {"host", GetHost(request.BucketName)},
                        {"date", _getDate()},
                        {"user-agent", _getUserAgent()},
                    };
                    if (!_empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = await GetSignatureAsync(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (_isFail(response_))
                    {
                        bodyStr = _readAsString(response_);
                        respMap = _getErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>()
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    bodyStr = _readAsString(response_);
                    respMap = _parseXml(bodyStr, typeof(GetBucketCORSResponse));
                    return TeaModel.ToObject<GetBucketCORSResponse>(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"CORSConfiguration", respMap["CORSConfiguration"]},
                        },
                        response_.Headers
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public CopyObjectResponse CopyObject(CopyObjectRequest request, RuntimeObject runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>()
            {
                {"timeouted", "retry"},
                {"readTimeout", _defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", _defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", _default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", _default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", _default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", _default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", _default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", _default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", _defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>()
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>()
                {
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string token = _getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "PUT";
                    request_.Pathname = "/" + request.DestObjectName;
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"host", GetHost(request.BucketName)},
                            {"date", _getDate()},
                            {"user-agent", _getUserAgent()},
                        },
                        _toHeader(request.Header.ToMap())
                    );
                    if (!_empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["x-oss-copy-source"] = _encode(request_.Headers["x-oss-copy-source"], "UrlEncode");
                    request_.Headers["authorization"] = GetSignature(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (_isFail(response_))
                    {
                        bodyStr = _readAsString(response_);
                        respMap = _getErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>()
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    bodyStr = _readAsString(response_);
                    respMap = _parseXml(bodyStr, typeof(CopyObjectResponse));
                    return TeaModel.ToObject<CopyObjectResponse>(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"CopyObjectResult", respMap["CopyObjectResult"]},
                        },
                        response_.Headers
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public async Task<CopyObjectResponse> CopyObjectAsync(CopyObjectRequest request, RuntimeObject runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>()
            {
                {"timeouted", "retry"},
                {"readTimeout", _defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", _defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", _default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", _default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", _default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", _default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", _default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", _default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", _defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>()
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>()
                {
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string token = _getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "PUT";
                    request_.Pathname = "/" + request.DestObjectName;
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"host", GetHost(request.BucketName)},
                            {"date", _getDate()},
                            {"user-agent", _getUserAgent()},
                        },
                        _toHeader(request.Header.ToMap())
                    );
                    if (!_empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["x-oss-copy-source"] = _encode(request_.Headers["x-oss-copy-source"], "UrlEncode");
                    request_.Headers["authorization"] = await GetSignatureAsync(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (_isFail(response_))
                    {
                        bodyStr = _readAsString(response_);
                        respMap = _getErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>()
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    bodyStr = _readAsString(response_);
                    respMap = _parseXml(bodyStr, typeof(CopyObjectResponse));
                    return TeaModel.ToObject<CopyObjectResponse>(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"CopyObjectResult", respMap["CopyObjectResult"]},
                        },
                        response_.Headers
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public GetObjectTaggingResponse GetObjectTagging(GetObjectTaggingRequest request, RuntimeObject runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>()
            {
                {"timeouted", "retry"},
                {"readTimeout", _defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", _defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", _default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", _default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", _default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", _default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", _default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", _default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", _defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>()
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>()
                {
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string token = _getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/" + request.ObjectName + "?tagging";
                    request_.Headers = new Dictionary<string, string>()
                    {
                        {"host", GetHost(request.BucketName)},
                        {"date", _getDate()},
                        {"user-agent", _getUserAgent()},
                    };
                    if (!_empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = GetSignature(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (_isFail(response_))
                    {
                        bodyStr = _readAsString(response_);
                        respMap = _getErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>()
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    bodyStr = _readAsString(response_);
                    respMap = _parseXml(bodyStr, typeof(GetObjectTaggingResponse));
                    return TeaModel.ToObject<GetObjectTaggingResponse>(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"Tagging", respMap["Tagging"]},
                        },
                        response_.Headers
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public async Task<GetObjectTaggingResponse> GetObjectTaggingAsync(GetObjectTaggingRequest request, RuntimeObject runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>()
            {
                {"timeouted", "retry"},
                {"readTimeout", _defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", _defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", _default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", _default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", _default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", _default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", _default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", _default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", _defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>()
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>()
                {
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string token = _getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/" + request.ObjectName + "?tagging";
                    request_.Headers = new Dictionary<string, string>()
                    {
                        {"host", GetHost(request.BucketName)},
                        {"date", _getDate()},
                        {"user-agent", _getUserAgent()},
                    };
                    if (!_empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = await GetSignatureAsync(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (_isFail(response_))
                    {
                        bodyStr = _readAsString(response_);
                        respMap = _getErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>()
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    bodyStr = _readAsString(response_);
                    respMap = _parseXml(bodyStr, typeof(GetObjectTaggingResponse));
                    return TeaModel.ToObject<GetObjectTaggingResponse>(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"Tagging", respMap["Tagging"]},
                        },
                        response_.Headers
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public DeleteBucketLifecycleResponse DeleteBucketLifecycle(DeleteBucketLifecycleRequest request, RuntimeObject runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>()
            {
                {"timeouted", "retry"},
                {"readTimeout", _defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", _defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", _default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", _default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", _default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", _default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", _default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", _default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", _defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>()
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>()
                {
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string token = _getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "DELETE";
                    request_.Pathname = "/?lifecycle";
                    request_.Headers = new Dictionary<string, string>()
                    {
                        {"host", GetHost(request.BucketName)},
                        {"date", _getDate()},
                        {"user-agent", _getUserAgent()},
                    };
                    if (!_empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = GetSignature(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (_isFail(response_))
                    {
                        bodyStr = _readAsString(response_);
                        respMap = _getErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>()
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    return TeaModel.ToObject<DeleteBucketLifecycleResponse>(TeaConverter.merge<string>
                    (
                        response_.Headers
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public async Task<DeleteBucketLifecycleResponse> DeleteBucketLifecycleAsync(DeleteBucketLifecycleRequest request, RuntimeObject runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>()
            {
                {"timeouted", "retry"},
                {"readTimeout", _defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", _defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", _default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", _default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", _default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", _default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", _default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", _default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", _defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>()
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>()
                {
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string token = _getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "DELETE";
                    request_.Pathname = "/?lifecycle";
                    request_.Headers = new Dictionary<string, string>()
                    {
                        {"host", GetHost(request.BucketName)},
                        {"date", _getDate()},
                        {"user-agent", _getUserAgent()},
                    };
                    if (!_empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = await GetSignatureAsync(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (_isFail(response_))
                    {
                        bodyStr = _readAsString(response_);
                        respMap = _getErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>()
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    return TeaModel.ToObject<DeleteBucketLifecycleResponse>(TeaConverter.merge<string>
                    (
                        response_.Headers
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public DeleteBucketLoggingResponse DeleteBucketLogging(DeleteBucketLoggingRequest request, RuntimeObject runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>()
            {
                {"timeouted", "retry"},
                {"readTimeout", _defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", _defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", _default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", _default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", _default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", _default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", _default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", _default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", _defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>()
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>()
                {
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string token = _getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "DELETE";
                    request_.Pathname = "/?logging";
                    request_.Headers = new Dictionary<string, string>()
                    {
                        {"host", GetHost(request.BucketName)},
                        {"date", _getDate()},
                        {"user-agent", _getUserAgent()},
                    };
                    if (!_empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = GetSignature(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (_isFail(response_))
                    {
                        bodyStr = _readAsString(response_);
                        respMap = _getErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>()
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    return TeaModel.ToObject<DeleteBucketLoggingResponse>(TeaConverter.merge<string>
                    (
                        response_.Headers
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public async Task<DeleteBucketLoggingResponse> DeleteBucketLoggingAsync(DeleteBucketLoggingRequest request, RuntimeObject runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>()
            {
                {"timeouted", "retry"},
                {"readTimeout", _defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", _defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", _default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", _default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", _default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", _default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", _default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", _default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", _defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>()
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>()
                {
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string token = _getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "DELETE";
                    request_.Pathname = "/?logging";
                    request_.Headers = new Dictionary<string, string>()
                    {
                        {"host", GetHost(request.BucketName)},
                        {"date", _getDate()},
                        {"user-agent", _getUserAgent()},
                    };
                    if (!_empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = await GetSignatureAsync(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (_isFail(response_))
                    {
                        bodyStr = _readAsString(response_);
                        respMap = _getErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>()
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    return TeaModel.ToObject<DeleteBucketLoggingResponse>(TeaConverter.merge<string>
                    (
                        response_.Headers
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public DeleteBucketWebsiteResponse DeleteBucketWebsite(DeleteBucketWebsiteRequest request, RuntimeObject runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>()
            {
                {"timeouted", "retry"},
                {"readTimeout", _defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", _defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", _default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", _default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", _default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", _default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", _default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", _default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", _defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>()
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>()
                {
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string token = _getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "DELETE";
                    request_.Pathname = "/?website";
                    request_.Headers = new Dictionary<string, string>()
                    {
                        {"host", GetHost(request.BucketName)},
                        {"date", _getDate()},
                        {"user-agent", _getUserAgent()},
                    };
                    if (!_empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = GetSignature(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (_isFail(response_))
                    {
                        bodyStr = _readAsString(response_);
                        respMap = _getErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>()
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    return TeaModel.ToObject<DeleteBucketWebsiteResponse>(TeaConverter.merge<string>
                    (
                        response_.Headers
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public async Task<DeleteBucketWebsiteResponse> DeleteBucketWebsiteAsync(DeleteBucketWebsiteRequest request, RuntimeObject runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>()
            {
                {"timeouted", "retry"},
                {"readTimeout", _defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", _defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", _default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", _default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", _default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", _default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", _default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", _default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", _defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>()
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>()
                {
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string token = _getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "DELETE";
                    request_.Pathname = "/?website";
                    request_.Headers = new Dictionary<string, string>()
                    {
                        {"host", GetHost(request.BucketName)},
                        {"date", _getDate()},
                        {"user-agent", _getUserAgent()},
                    };
                    if (!_empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = await GetSignatureAsync(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (_isFail(response_))
                    {
                        bodyStr = _readAsString(response_);
                        respMap = _getErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>()
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    return TeaModel.ToObject<DeleteBucketWebsiteResponse>(TeaConverter.merge<string>
                    (
                        response_.Headers
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public GetSymlinkResponse GetSymlink(GetSymlinkRequest request, RuntimeObject runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>()
            {
                {"timeouted", "retry"},
                {"readTimeout", _defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", _defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", _default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", _default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", _default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", _default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", _default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", _default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", _defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>()
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>()
                {
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string token = _getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/" + request.ObjectName + "?symlink";
                    request_.Headers = new Dictionary<string, string>()
                    {
                        {"host", GetHost(request.BucketName)},
                        {"date", _getDate()},
                        {"user-agent", _getUserAgent()},
                    };
                    if (!_empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = GetSignature(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (_isFail(response_))
                    {
                        bodyStr = _readAsString(response_);
                        respMap = _getErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>()
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    return TeaModel.ToObject<GetSymlinkResponse>(TeaConverter.merge<string>
                    (
                        response_.Headers
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public async Task<GetSymlinkResponse> GetSymlinkAsync(GetSymlinkRequest request, RuntimeObject runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>()
            {
                {"timeouted", "retry"},
                {"readTimeout", _defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", _defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", _default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", _default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", _default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", _default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", _default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", _default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", _defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>()
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>()
                {
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string token = _getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/" + request.ObjectName + "?symlink";
                    request_.Headers = new Dictionary<string, string>()
                    {
                        {"host", GetHost(request.BucketName)},
                        {"date", _getDate()},
                        {"user-agent", _getUserAgent()},
                    };
                    if (!_empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = await GetSignatureAsync(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (_isFail(response_))
                    {
                        bodyStr = _readAsString(response_);
                        respMap = _getErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>()
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    return TeaModel.ToObject<GetSymlinkResponse>(TeaConverter.merge<string>
                    (
                        response_.Headers
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public GetBucketLifecycleResponse GetBucketLifecycle(GetBucketLifecycleRequest request, RuntimeObject runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>()
            {
                {"timeouted", "retry"},
                {"readTimeout", _defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", _defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", _default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", _default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", _default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", _default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", _default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", _default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", _defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>()
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>()
                {
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string token = _getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/?lifecycle";
                    request_.Headers = new Dictionary<string, string>()
                    {
                        {"host", GetHost(request.BucketName)},
                        {"date", _getDate()},
                        {"user-agent", _getUserAgent()},
                    };
                    if (!_empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = GetSignature(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (_isFail(response_))
                    {
                        bodyStr = _readAsString(response_);
                        respMap = _getErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>()
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    bodyStr = _readAsString(response_);
                    respMap = _parseXml(bodyStr, typeof(GetBucketLifecycleResponse));
                    return TeaModel.ToObject<GetBucketLifecycleResponse>(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"LifecycleConfiguration", respMap["LifecycleConfiguration"]},
                        },
                        response_.Headers
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public async Task<GetBucketLifecycleResponse> GetBucketLifecycleAsync(GetBucketLifecycleRequest request, RuntimeObject runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>()
            {
                {"timeouted", "retry"},
                {"readTimeout", _defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", _defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", _default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", _default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", _default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", _default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", _default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", _default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", _defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>()
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>()
                {
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string token = _getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/?lifecycle";
                    request_.Headers = new Dictionary<string, string>()
                    {
                        {"host", GetHost(request.BucketName)},
                        {"date", _getDate()},
                        {"user-agent", _getUserAgent()},
                    };
                    if (!_empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = await GetSignatureAsync(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (_isFail(response_))
                    {
                        bodyStr = _readAsString(response_);
                        respMap = _getErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>()
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    bodyStr = _readAsString(response_);
                    respMap = _parseXml(bodyStr, typeof(GetBucketLifecycleResponse));
                    return TeaModel.ToObject<GetBucketLifecycleResponse>(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"LifecycleConfiguration", respMap["LifecycleConfiguration"]},
                        },
                        response_.Headers
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public PutSymlinkResponse PutSymlink(PutSymlinkRequest request, RuntimeObject runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>()
            {
                {"timeouted", "retry"},
                {"readTimeout", _defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", _defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", _default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", _default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", _default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", _default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", _default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", _default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", _defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>()
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>()
                {
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string token = _getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "PUT";
                    request_.Pathname = "/" + request.ObjectName + "?symlink";
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"host", GetHost(request.BucketName)},
                            {"date", _getDate()},
                            {"user-agent", _getUserAgent()},
                        },
                        _toHeader(request.Header.ToMap())
                    );
                    if (!_empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = GetSignature(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (_isFail(response_))
                    {
                        bodyStr = _readAsString(response_);
                        respMap = _getErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>()
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    return TeaModel.ToObject<PutSymlinkResponse>(TeaConverter.merge<string>
                    (
                        response_.Headers
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public async Task<PutSymlinkResponse> PutSymlinkAsync(PutSymlinkRequest request, RuntimeObject runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>()
            {
                {"timeouted", "retry"},
                {"readTimeout", _defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", _defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", _default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", _default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", _default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", _default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", _default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", _default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", _defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>()
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>()
                {
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string token = _getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "PUT";
                    request_.Pathname = "/" + request.ObjectName + "?symlink";
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"host", GetHost(request.BucketName)},
                            {"date", _getDate()},
                            {"user-agent", _getUserAgent()},
                        },
                        _toHeader(request.Header.ToMap())
                    );
                    if (!_empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = await GetSignatureAsync(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (_isFail(response_))
                    {
                        bodyStr = _readAsString(response_);
                        respMap = _getErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>()
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    return TeaModel.ToObject<PutSymlinkResponse>(TeaConverter.merge<string>
                    (
                        response_.Headers
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public GetBucketRefererResponse GetBucketReferer(GetBucketRefererRequest request, RuntimeObject runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>()
            {
                {"timeouted", "retry"},
                {"readTimeout", _defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", _defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", _default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", _default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", _default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", _default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", _default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", _default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", _defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>()
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>()
                {
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string token = _getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/?referer";
                    request_.Headers = new Dictionary<string, string>()
                    {
                        {"host", GetHost(request.BucketName)},
                        {"date", _getDate()},
                        {"user-agent", _getUserAgent()},
                    };
                    if (!_empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = GetSignature(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (_isFail(response_))
                    {
                        bodyStr = _readAsString(response_);
                        respMap = _getErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>()
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    bodyStr = _readAsString(response_);
                    respMap = _parseXml(bodyStr, typeof(GetBucketRefererResponse));
                    return TeaModel.ToObject<GetBucketRefererResponse>(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"RefererConfiguration", respMap["RefererConfiguration"]},
                        },
                        response_.Headers
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public async Task<GetBucketRefererResponse> GetBucketRefererAsync(GetBucketRefererRequest request, RuntimeObject runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>()
            {
                {"timeouted", "retry"},
                {"readTimeout", _defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", _defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", _default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", _default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", _default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", _default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", _default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", _default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", _defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>()
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>()
                {
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string token = _getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/?referer";
                    request_.Headers = new Dictionary<string, string>()
                    {
                        {"host", GetHost(request.BucketName)},
                        {"date", _getDate()},
                        {"user-agent", _getUserAgent()},
                    };
                    if (!_empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = await GetSignatureAsync(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (_isFail(response_))
                    {
                        bodyStr = _readAsString(response_);
                        respMap = _getErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>()
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    bodyStr = _readAsString(response_);
                    respMap = _parseXml(bodyStr, typeof(GetBucketRefererResponse));
                    return TeaModel.ToObject<GetBucketRefererResponse>(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"RefererConfiguration", respMap["RefererConfiguration"]},
                        },
                        response_.Headers
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public CallbackResponse Callback(CallbackRequest request, RuntimeObject runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>()
            {
                {"timeouted", "retry"},
                {"readTimeout", _defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", _defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", _default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", _default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", _default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", _default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", _default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", _default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", _defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>()
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>()
                {
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string token = _getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/";
                    request_.Headers = new Dictionary<string, string>()
                    {
                        {"host", GetHost(request.BucketName)},
                        {"date", _getDate()},
                        {"user-agent", _getUserAgent()},
                    };
                    if (!_empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = GetSignature(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (_isFail(response_))
                    {
                        bodyStr = _readAsString(response_);
                        respMap = _getErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>()
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    return TeaModel.ToObject<CallbackResponse>(TeaConverter.merge<string>
                    (
                        response_.Headers
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public async Task<CallbackResponse> CallbackAsync(CallbackRequest request, RuntimeObject runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>()
            {
                {"timeouted", "retry"},
                {"readTimeout", _defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", _defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", _default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", _default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", _default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", _default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", _default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", _default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", _defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>()
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>()
                {
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string token = _getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/";
                    request_.Headers = new Dictionary<string, string>()
                    {
                        {"host", GetHost(request.BucketName)},
                        {"date", _getDate()},
                        {"user-agent", _getUserAgent()},
                    };
                    if (!_empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = await GetSignatureAsync(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (_isFail(response_))
                    {
                        bodyStr = _readAsString(response_);
                        respMap = _getErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>()
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    return TeaModel.ToObject<CallbackResponse>(TeaConverter.merge<string>
                    (
                        response_.Headers
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public GetBucketLoggingResponse GetBucketLogging(GetBucketLoggingRequest request, RuntimeObject runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>()
            {
                {"timeouted", "retry"},
                {"readTimeout", _defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", _defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", _default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", _default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", _default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", _default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", _default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", _default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", _defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>()
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>()
                {
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string token = _getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/?logging";
                    request_.Headers = new Dictionary<string, string>()
                    {
                        {"host", GetHost(request.BucketName)},
                        {"date", _getDate()},
                        {"user-agent", _getUserAgent()},
                    };
                    if (!_empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = GetSignature(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (_isFail(response_))
                    {
                        bodyStr = _readAsString(response_);
                        respMap = _getErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>()
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    bodyStr = _readAsString(response_);
                    respMap = _parseXml(bodyStr, typeof(GetBucketLoggingResponse));
                    return TeaModel.ToObject<GetBucketLoggingResponse>(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"BucketLoggingStatus", respMap["BucketLoggingStatus"]},
                        },
                        response_.Headers
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public async Task<GetBucketLoggingResponse> GetBucketLoggingAsync(GetBucketLoggingRequest request, RuntimeObject runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>()
            {
                {"timeouted", "retry"},
                {"readTimeout", _defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", _defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", _default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", _default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", _default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", _default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", _default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", _default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", _defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>()
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>()
                {
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string token = _getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/?logging";
                    request_.Headers = new Dictionary<string, string>()
                    {
                        {"host", GetHost(request.BucketName)},
                        {"date", _getDate()},
                        {"user-agent", _getUserAgent()},
                    };
                    if (!_empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = await GetSignatureAsync(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (_isFail(response_))
                    {
                        bodyStr = _readAsString(response_);
                        respMap = _getErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>()
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    bodyStr = _readAsString(response_);
                    respMap = _parseXml(bodyStr, typeof(GetBucketLoggingResponse));
                    return TeaModel.ToObject<GetBucketLoggingResponse>(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"BucketLoggingStatus", respMap["BucketLoggingStatus"]},
                        },
                        response_.Headers
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public PutObjectAclResponse PutObjectAcl(PutObjectAclRequest request, RuntimeObject runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>()
            {
                {"timeouted", "retry"},
                {"readTimeout", _defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", _defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", _default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", _default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", _default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", _default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", _default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", _default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", _defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>()
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>()
                {
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string token = _getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "PUT";
                    request_.Pathname = "/" + request.ObjectName + "?acl";
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"host", GetHost(request.BucketName)},
                            {"date", _getDate()},
                            {"user-agent", _getUserAgent()},
                        },
                        _toHeader(request.Header.ToMap())
                    );
                    if (!_empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = GetSignature(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (_isFail(response_))
                    {
                        bodyStr = _readAsString(response_);
                        respMap = _getErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>()
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    return TeaModel.ToObject<PutObjectAclResponse>(TeaConverter.merge<string>
                    (
                        response_.Headers
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public async Task<PutObjectAclResponse> PutObjectAclAsync(PutObjectAclRequest request, RuntimeObject runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>()
            {
                {"timeouted", "retry"},
                {"readTimeout", _defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", _defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", _default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", _default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", _default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", _default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", _default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", _default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", _defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>()
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>()
                {
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string token = _getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "PUT";
                    request_.Pathname = "/" + request.ObjectName + "?acl";
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"host", GetHost(request.BucketName)},
                            {"date", _getDate()},
                            {"user-agent", _getUserAgent()},
                        },
                        _toHeader(request.Header.ToMap())
                    );
                    if (!_empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = await GetSignatureAsync(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (_isFail(response_))
                    {
                        bodyStr = _readAsString(response_);
                        respMap = _getErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>()
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    return TeaModel.ToObject<PutObjectAclResponse>(TeaConverter.merge<string>
                    (
                        response_.Headers
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public GetBucketInfoResponse GetBucketInfo(GetBucketInfoRequest request, RuntimeObject runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>()
            {
                {"timeouted", "retry"},
                {"readTimeout", _defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", _defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", _default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", _default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", _default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", _default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", _default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", _default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", _defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>()
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>()
                {
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string token = _getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/?bucketInfo";
                    request_.Headers = new Dictionary<string, string>()
                    {
                        {"host", GetHost(request.BucketName)},
                        {"date", _getDate()},
                        {"user-agent", _getUserAgent()},
                    };
                    if (!_empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = GetSignature(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (_isFail(response_))
                    {
                        bodyStr = _readAsString(response_);
                        respMap = _getErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>()
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    bodyStr = _readAsString(response_);
                    respMap = _parseXml(bodyStr, typeof(GetBucketInfoResponse));
                    return TeaModel.ToObject<GetBucketInfoResponse>(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"BucketInfo", respMap["BucketInfo"]},
                        },
                        response_.Headers
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public async Task<GetBucketInfoResponse> GetBucketInfoAsync(GetBucketInfoRequest request, RuntimeObject runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>()
            {
                {"timeouted", "retry"},
                {"readTimeout", _defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", _defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", _default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", _default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", _default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", _default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", _default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", _default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", _defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>()
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>()
                {
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string token = _getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/?bucketInfo";
                    request_.Headers = new Dictionary<string, string>()
                    {
                        {"host", GetHost(request.BucketName)},
                        {"date", _getDate()},
                        {"user-agent", _getUserAgent()},
                    };
                    if (!_empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = await GetSignatureAsync(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (_isFail(response_))
                    {
                        bodyStr = _readAsString(response_);
                        respMap = _getErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>()
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    bodyStr = _readAsString(response_);
                    respMap = _parseXml(bodyStr, typeof(GetBucketInfoResponse));
                    return TeaModel.ToObject<GetBucketInfoResponse>(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"BucketInfo", respMap["BucketInfo"]},
                        },
                        response_.Headers
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public PutLiveChannelStatusResponse PutLiveChannelStatus(PutLiveChannelStatusRequest request, RuntimeObject runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>()
            {
                {"timeouted", "retry"},
                {"readTimeout", _defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", _defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", _default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", _default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", _default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", _default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", _default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", _default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", _defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>()
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>()
                {
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string token = _getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "PUT";
                    request_.Pathname = "/" + request.ChannelName + "?live";
                    request_.Headers = new Dictionary<string, string>()
                    {
                        {"host", GetHost(request.BucketName)},
                        {"date", _getDate()},
                        {"user-agent", _getUserAgent()},
                    };
                    if (!_empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Query = _toQuery(request.Filter.ToMap());
                    request_.Headers["authorization"] = GetSignature(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (_isFail(response_))
                    {
                        bodyStr = _readAsString(response_);
                        respMap = _getErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>()
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    return TeaModel.ToObject<PutLiveChannelStatusResponse>(TeaConverter.merge<string>
                    (
                        response_.Headers
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public async Task<PutLiveChannelStatusResponse> PutLiveChannelStatusAsync(PutLiveChannelStatusRequest request, RuntimeObject runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>()
            {
                {"timeouted", "retry"},
                {"readTimeout", _defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", _defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", _default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", _default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", _default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", _default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", _default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", _default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", _defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>()
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>()
                {
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string token = _getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "PUT";
                    request_.Pathname = "/" + request.ChannelName + "?live";
                    request_.Headers = new Dictionary<string, string>()
                    {
                        {"host", GetHost(request.BucketName)},
                        {"date", _getDate()},
                        {"user-agent", _getUserAgent()},
                    };
                    if (!_empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Query = _toQuery(request.Filter.ToMap());
                    request_.Headers["authorization"] = await GetSignatureAsync(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (_isFail(response_))
                    {
                        bodyStr = _readAsString(response_);
                        respMap = _getErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>()
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    return TeaModel.ToObject<PutLiveChannelStatusResponse>(TeaConverter.merge<string>
                    (
                        response_.Headers
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public InitiateMultipartUploadResponse InitiateMultipartUpload(InitiateMultipartUploadRequest request, RuntimeObject runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>()
            {
                {"timeouted", "retry"},
                {"readTimeout", _defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", _defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", _default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", _default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", _default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", _default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", _default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", _default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", _defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>()
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>()
                {
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string token = _getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "POST";
                    request_.Pathname = "/" + request.ObjectName + "?uploads";
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"host", GetHost(request.BucketName)},
                            {"date", _getDate()},
                            {"user-agent", _getUserAgent()},
                        },
                        _toHeader(request.Header.ToMap())
                    );
                    if (!_empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Query = _toQuery(request.Filter.ToMap());
                    if (_notNull(request.Header.ToMap()) && !_empty(request.Header.ContentType))
                    {
                        request_.Headers["content-type"] = request.Header.ContentType;
                    }
else
                    {
                        request_.Headers["content-type"] = _getContentType(request.ObjectName);
                    }
                    request_.Headers["authorization"] = GetSignature(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (_isFail(response_))
                    {
                        bodyStr = _readAsString(response_);
                        respMap = _getErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>()
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    bodyStr = _readAsString(response_);
                    respMap = _parseXml(bodyStr, typeof(InitiateMultipartUploadResponse));
                    return TeaModel.ToObject<InitiateMultipartUploadResponse>(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"InitiateMultipartUploadResult", respMap["InitiateMultipartUploadResult"]},
                        },
                        response_.Headers
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public async Task<InitiateMultipartUploadResponse> InitiateMultipartUploadAsync(InitiateMultipartUploadRequest request, RuntimeObject runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>()
            {
                {"timeouted", "retry"},
                {"readTimeout", _defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", _defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", _default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", _default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", _default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", _default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", _default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", _default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", _defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>()
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>()
                {
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string token = _getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "POST";
                    request_.Pathname = "/" + request.ObjectName + "?uploads";
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"host", GetHost(request.BucketName)},
                            {"date", _getDate()},
                            {"user-agent", _getUserAgent()},
                        },
                        _toHeader(request.Header.ToMap())
                    );
                    if (!_empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Query = _toQuery(request.Filter.ToMap());
                    if (_notNull(request.Header.ToMap()) && !_empty(request.Header.ContentType))
                    {
                        request_.Headers["content-type"] = request.Header.ContentType;
                    }
else
                    {
                        request_.Headers["content-type"] = _getContentType(request.ObjectName);
                    }
                    request_.Headers["authorization"] = await GetSignatureAsync(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (_isFail(response_))
                    {
                        bodyStr = _readAsString(response_);
                        respMap = _getErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>()
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    bodyStr = _readAsString(response_);
                    respMap = _parseXml(bodyStr, typeof(InitiateMultipartUploadResponse));
                    return TeaModel.ToObject<InitiateMultipartUploadResponse>(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"InitiateMultipartUploadResult", respMap["InitiateMultipartUploadResult"]},
                        },
                        response_.Headers
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public OptionObjectResponse OptionObject(OptionObjectRequest request, RuntimeObject runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>()
            {
                {"timeouted", "retry"},
                {"readTimeout", _defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", _defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", _default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", _default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", _default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", _default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", _default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", _default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", _defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>()
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>()
                {
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string token = _getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "OPTIONS";
                    request_.Pathname = "/" + request.ObjectName;
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"host", GetHost(request.BucketName)},
                            {"date", _getDate()},
                            {"user-agent", _getUserAgent()},
                        },
                        _toHeader(request.Header.ToMap())
                    );
                    if (!_empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = GetSignature(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (_isFail(response_))
                    {
                        bodyStr = _readAsString(response_);
                        respMap = _getErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>()
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    return TeaModel.ToObject<OptionObjectResponse>(TeaConverter.merge<string>
                    (
                        response_.Headers
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public async Task<OptionObjectResponse> OptionObjectAsync(OptionObjectRequest request, RuntimeObject runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>()
            {
                {"timeouted", "retry"},
                {"readTimeout", _defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", _defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", _default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", _default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", _default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", _default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", _default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", _default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", _defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>()
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>()
                {
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string token = _getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "OPTIONS";
                    request_.Pathname = "/" + request.ObjectName;
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"host", GetHost(request.BucketName)},
                            {"date", _getDate()},
                            {"user-agent", _getUserAgent()},
                        },
                        _toHeader(request.Header.ToMap())
                    );
                    if (!_empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = await GetSignatureAsync(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (_isFail(response_))
                    {
                        bodyStr = _readAsString(response_);
                        respMap = _getErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>()
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    return TeaModel.ToObject<OptionObjectResponse>(TeaConverter.merge<string>
                    (
                        response_.Headers
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public PostVodPlaylistResponse PostVodPlaylist(PostVodPlaylistRequest request, RuntimeObject runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>()
            {
                {"timeouted", "retry"},
                {"readTimeout", _defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", _defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", _default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", _default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", _default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", _default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", _default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", _default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", _defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>()
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>()
                {
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string token = _getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "POST";
                    request_.Pathname = "/" + request.ChannelName + "/" + request.PlaylistName + "?vod";
                    request_.Headers = new Dictionary<string, string>()
                    {
                        {"host", GetHost(request.BucketName)},
                        {"date", _getDate()},
                        {"user-agent", _getUserAgent()},
                    };
                    if (!_empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Query = _toQuery(request.Filter.ToMap());
                    request_.Headers["authorization"] = GetSignature(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (_isFail(response_))
                    {
                        bodyStr = _readAsString(response_);
                        respMap = _getErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>()
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    return TeaModel.ToObject<PostVodPlaylistResponse>(TeaConverter.merge<string>
                    (
                        response_.Headers
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public async Task<PostVodPlaylistResponse> PostVodPlaylistAsync(PostVodPlaylistRequest request, RuntimeObject runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>()
            {
                {"timeouted", "retry"},
                {"readTimeout", _defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", _defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", _default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", _default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", _default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", _default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", _default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", _default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", _defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>()
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>()
                {
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string token = _getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "POST";
                    request_.Pathname = "/" + request.ChannelName + "/" + request.PlaylistName + "?vod";
                    request_.Headers = new Dictionary<string, string>()
                    {
                        {"host", GetHost(request.BucketName)},
                        {"date", _getDate()},
                        {"user-agent", _getUserAgent()},
                    };
                    if (!_empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Query = _toQuery(request.Filter.ToMap());
                    request_.Headers["authorization"] = await GetSignatureAsync(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (_isFail(response_))
                    {
                        bodyStr = _readAsString(response_);
                        respMap = _getErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>()
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    return TeaModel.ToObject<PostVodPlaylistResponse>(TeaConverter.merge<string>
                    (
                        response_.Headers
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public PostObjectResponse PostObject(PostObjectRequest request, AlibabaCloud.Commons.Models.RuntimeObject runtime)
        {
            request.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>()
            {
                {"timeouted", "retry"},
                {"readTimeout", AlibabaCloud.Common.DefaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", AlibabaCloud.Common.DefaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"httpProxy", AlibabaCloud.Common.Default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", AlibabaCloud.Common.Default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", AlibabaCloud.Common.Default(runtime.NoProxy, _noProxy)},
                {"maxIdleConns", AlibabaCloud.Common.DefaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>()
                {
                    {"retryable", runtime.Autoretry},
                    {"max-attempts", AlibabaCloud.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>()
                {
                    {"policy", AlibabaCloud.Common.Default(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string boundary = AlibabaCloud.Common.GetBoundary();
                    request_.Protocol = _protocol;
                    request_.Method = "POST";
                    request_.Pathname = "/";
                    request_.Headers = new Dictionary<string, string>()
                    {
                        {"host", GetHost(request.BucketName)},
                        {"date", AlibabaCloud.Common.GetDate()},
                    };
                    request_.Headers["content-type"] = "multipart/form-data; boundary=" + boundary;
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.Common.ToForm(request.Header.ToMap(), boundary));
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = AlibabaCloud.Common.ReadAsString(response_.Body);
                    if (AlibabaCloud.Common.IsFail(response_))
                    {
                        respMap = AlibabaCloud.Common.GetErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>()
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    respMap = AlibabaCloud.Common.ParseXml(bodyStr, typeof(PostObjectResponse));
                    return TeaModel.ToObject<PostObjectResponse>(TeaConverter.merge<object>
                    (
                        respMap
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public async Task<PostObjectResponse> PostObjectAsync(PostObjectRequest request, AlibabaCloud.Commons.Models.RuntimeObject runtime)
        {
            request.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>()
            {
                {"timeouted", "retry"},
                {"readTimeout", AlibabaCloud.Common.DefaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", AlibabaCloud.Common.DefaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"httpProxy", AlibabaCloud.Common.Default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", AlibabaCloud.Common.Default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", AlibabaCloud.Common.Default(runtime.NoProxy, _noProxy)},
                {"maxIdleConns", AlibabaCloud.Common.DefaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>()
                {
                    {"retryable", runtime.Autoretry},
                    {"max-attempts", AlibabaCloud.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>()
                {
                    {"policy", AlibabaCloud.Common.Default(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string boundary = AlibabaCloud.Common.GetBoundary();
                    request_.Protocol = _protocol;
                    request_.Method = "POST";
                    request_.Pathname = "/";
                    request_.Headers = new Dictionary<string, string>()
                    {
                        {"host", GetHost(request.BucketName)},
                        {"date", AlibabaCloud.Common.GetDate()},
                    };
                    request_.Headers["content-type"] = "multipart/form-data; boundary=" + boundary;
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.Common.ToForm(request.Header.ToMap(), boundary));
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = AlibabaCloud.Common.ReadAsString(response_.Body);
                    if (AlibabaCloud.Common.IsFail(response_))
                    {
                        respMap = AlibabaCloud.Common.GetErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>()
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    respMap = AlibabaCloud.Common.ParseXml(bodyStr, typeof(PostObjectResponse));
                    return TeaModel.ToObject<PostObjectResponse>(TeaConverter.merge<object>
                    (
                        respMap
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public HeadObjectResponse HeadObject(HeadObjectRequest request, RuntimeObject runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>()
            {
                {"timeouted", "retry"},
                {"readTimeout", _defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", _defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", _default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", _default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", _default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", _default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", _default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", _default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", _defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>()
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>()
                {
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string token = _getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "HEAD";
                    request_.Pathname = "/" + request.ObjectName;
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"host", GetHost(request.BucketName)},
                            {"date", _getDate()},
                            {"user-agent", _getUserAgent()},
                        },
                        _toHeader(request.Header.ToMap())
                    );
                    if (!_empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = GetSignature(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (_isFail(response_))
                    {
                        bodyStr = _readAsString(response_);
                        respMap = _getErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>()
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    return TeaModel.ToObject<HeadObjectResponse>(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"usermeta", _toMeta(response_.Headers, "x-oss-meta-")},
                        },
                        response_.Headers
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public async Task<HeadObjectResponse> HeadObjectAsync(HeadObjectRequest request, RuntimeObject runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>()
            {
                {"timeouted", "retry"},
                {"readTimeout", _defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", _defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", _default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", _default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", _default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", _default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", _default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", _default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", _defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>()
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>()
                {
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string token = _getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "HEAD";
                    request_.Pathname = "/" + request.ObjectName;
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"host", GetHost(request.BucketName)},
                            {"date", _getDate()},
                            {"user-agent", _getUserAgent()},
                        },
                        _toHeader(request.Header.ToMap())
                    );
                    if (!_empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = await GetSignatureAsync(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (_isFail(response_))
                    {
                        bodyStr = _readAsString(response_);
                        respMap = _getErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>()
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    return TeaModel.ToObject<HeadObjectResponse>(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"usermeta", _toMeta(response_.Headers, "x-oss-meta-")},
                        },
                        response_.Headers
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public DeleteObjectTaggingResponse DeleteObjectTagging(DeleteObjectTaggingRequest request, RuntimeObject runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>()
            {
                {"timeouted", "retry"},
                {"readTimeout", _defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", _defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", _default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", _default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", _default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", _default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", _default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", _default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", _defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>()
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>()
                {
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string token = _getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "DELETE";
                    request_.Pathname = "/" + request.ObjectName + "?tagging";
                    request_.Headers = new Dictionary<string, string>()
                    {
                        {"host", GetHost(request.BucketName)},
                        {"date", _getDate()},
                        {"user-agent", _getUserAgent()},
                    };
                    if (!_empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = GetSignature(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (_isFail(response_))
                    {
                        bodyStr = _readAsString(response_);
                        respMap = _getErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>()
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    return TeaModel.ToObject<DeleteObjectTaggingResponse>(TeaConverter.merge<string>
                    (
                        response_.Headers
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public async Task<DeleteObjectTaggingResponse> DeleteObjectTaggingAsync(DeleteObjectTaggingRequest request, RuntimeObject runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>()
            {
                {"timeouted", "retry"},
                {"readTimeout", _defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", _defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", _default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", _default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", _default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", _default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", _default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", _default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", _defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>()
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>()
                {
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string token = _getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "DELETE";
                    request_.Pathname = "/" + request.ObjectName + "?tagging";
                    request_.Headers = new Dictionary<string, string>()
                    {
                        {"host", GetHost(request.BucketName)},
                        {"date", _getDate()},
                        {"user-agent", _getUserAgent()},
                    };
                    if (!_empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = await GetSignatureAsync(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (_isFail(response_))
                    {
                        bodyStr = _readAsString(response_);
                        respMap = _getErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>()
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    return TeaModel.ToObject<DeleteObjectTaggingResponse>(TeaConverter.merge<string>
                    (
                        response_.Headers
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public RestoreObjectResponse RestoreObject(RestoreObjectRequest request, RuntimeObject runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>()
            {
                {"timeouted", "retry"},
                {"readTimeout", _defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", _defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", _default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", _default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", _default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", _default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", _default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", _default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", _defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>()
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>()
                {
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string token = _getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "POST";
                    request_.Pathname = "/" + request.ObjectName + "?restore";
                    request_.Headers = new Dictionary<string, string>()
                    {
                        {"host", GetHost(request.BucketName)},
                        {"date", _getDate()},
                        {"user-agent", _getUserAgent()},
                    };
                    if (!_empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = GetSignature(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (_isFail(response_))
                    {
                        bodyStr = _readAsString(response_);
                        respMap = _getErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>()
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    return TeaModel.ToObject<RestoreObjectResponse>(TeaConverter.merge<string>
                    (
                        response_.Headers
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public async Task<RestoreObjectResponse> RestoreObjectAsync(RestoreObjectRequest request, RuntimeObject runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>()
            {
                {"timeouted", "retry"},
                {"readTimeout", _defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", _defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", _default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", _default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", _default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", _default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", _default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", _default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", _defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>()
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>()
                {
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string token = _getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "POST";
                    request_.Pathname = "/" + request.ObjectName + "?restore";
                    request_.Headers = new Dictionary<string, string>()
                    {
                        {"host", GetHost(request.BucketName)},
                        {"date", _getDate()},
                        {"user-agent", _getUserAgent()},
                    };
                    if (!_empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = await GetSignatureAsync(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (_isFail(response_))
                    {
                        bodyStr = _readAsString(response_);
                        respMap = _getErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>()
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    return TeaModel.ToObject<RestoreObjectResponse>(TeaConverter.merge<string>
                    (
                        response_.Headers
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public GetObjectAclResponse GetObjectAcl(GetObjectAclRequest request, RuntimeObject runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>()
            {
                {"timeouted", "retry"},
                {"readTimeout", _defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", _defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", _default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", _default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", _default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", _default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", _default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", _default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", _defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>()
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>()
                {
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string token = _getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/" + request.ObjectName + "?acl";
                    request_.Headers = new Dictionary<string, string>()
                    {
                        {"host", GetHost(request.BucketName)},
                        {"date", _getDate()},
                        {"user-agent", _getUserAgent()},
                    };
                    if (!_empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = GetSignature(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (_isFail(response_))
                    {
                        bodyStr = _readAsString(response_);
                        respMap = _getErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>()
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    bodyStr = _readAsString(response_);
                    respMap = _parseXml(bodyStr, typeof(GetObjectAclResponse));
                    return TeaModel.ToObject<GetObjectAclResponse>(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"AccessControlPolicy", respMap["AccessControlPolicy"]},
                        },
                        response_.Headers
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public async Task<GetObjectAclResponse> GetObjectAclAsync(GetObjectAclRequest request, RuntimeObject runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>()
            {
                {"timeouted", "retry"},
                {"readTimeout", _defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", _defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", _default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", _default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", _default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", _default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", _default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", _default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", _defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>()
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>()
                {
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string token = _getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/" + request.ObjectName + "?acl";
                    request_.Headers = new Dictionary<string, string>()
                    {
                        {"host", GetHost(request.BucketName)},
                        {"date", _getDate()},
                        {"user-agent", _getUserAgent()},
                    };
                    if (!_empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = await GetSignatureAsync(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (_isFail(response_))
                    {
                        bodyStr = _readAsString(response_);
                        respMap = _getErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>()
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    bodyStr = _readAsString(response_);
                    respMap = _parseXml(bodyStr, typeof(GetObjectAclResponse));
                    return TeaModel.ToObject<GetObjectAclResponse>(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"AccessControlPolicy", respMap["AccessControlPolicy"]},
                        },
                        response_.Headers
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public PutBucketAclResponse PutBucketAcl(PutBucketAclRequest request, RuntimeObject runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>()
            {
                {"timeouted", "retry"},
                {"readTimeout", _defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", _defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", _default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", _default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", _default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", _default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", _default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", _default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", _defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>()
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>()
                {
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string token = _getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "PUT";
                    request_.Pathname = "/?acl";
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"host", GetHost(request.BucketName)},
                            {"date", _getDate()},
                            {"user-agent", _getUserAgent()},
                        },
                        _toHeader(request.Header.ToMap())
                    );
                    if (!_empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = GetSignature(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (_isFail(response_))
                    {
                        bodyStr = _readAsString(response_);
                        respMap = _getErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>()
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    return TeaModel.ToObject<PutBucketAclResponse>(TeaConverter.merge<string>
                    (
                        response_.Headers
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public async Task<PutBucketAclResponse> PutBucketAclAsync(PutBucketAclRequest request, RuntimeObject runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>()
            {
                {"timeouted", "retry"},
                {"readTimeout", _defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", _defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", _default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", _default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", _default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", _default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", _default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", _default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", _defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>()
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>()
                {
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string token = _getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "PUT";
                    request_.Pathname = "/?acl";
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"host", GetHost(request.BucketName)},
                            {"date", _getDate()},
                            {"user-agent", _getUserAgent()},
                        },
                        _toHeader(request.Header.ToMap())
                    );
                    if (!_empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = await GetSignatureAsync(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (_isFail(response_))
                    {
                        bodyStr = _readAsString(response_);
                        respMap = _getErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>()
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    return TeaModel.ToObject<PutBucketAclResponse>(TeaConverter.merge<string>
                    (
                        response_.Headers
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public DeleteBucketResponse DeleteBucket(DeleteBucketRequest request, RuntimeObject runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>()
            {
                {"timeouted", "retry"},
                {"readTimeout", _defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", _defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", _default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", _default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", _default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", _default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", _default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", _default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", _defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>()
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>()
                {
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string token = _getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "DELETE";
                    request_.Pathname = "/";
                    request_.Headers = new Dictionary<string, string>()
                    {
                        {"host", GetHost(request.BucketName)},
                        {"date", _getDate()},
                        {"user-agent", _getUserAgent()},
                    };
                    if (!_empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = GetSignature(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (_isFail(response_))
                    {
                        bodyStr = _readAsString(response_);
                        respMap = _getErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>()
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    return TeaModel.ToObject<DeleteBucketResponse>(TeaConverter.merge<string>
                    (
                        response_.Headers
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public async Task<DeleteBucketResponse> DeleteBucketAsync(DeleteBucketRequest request, RuntimeObject runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>()
            {
                {"timeouted", "retry"},
                {"readTimeout", _defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", _defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", _default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", _default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", _default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", _default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", _default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", _default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", _defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>()
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>()
                {
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string token = _getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "DELETE";
                    request_.Pathname = "/";
                    request_.Headers = new Dictionary<string, string>()
                    {
                        {"host", GetHost(request.BucketName)},
                        {"date", _getDate()},
                        {"user-agent", _getUserAgent()},
                    };
                    if (!_empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = await GetSignatureAsync(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (_isFail(response_))
                    {
                        bodyStr = _readAsString(response_);
                        respMap = _getErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>()
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    return TeaModel.ToObject<DeleteBucketResponse>(TeaConverter.merge<string>
                    (
                        response_.Headers
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public PutObjectResponse PutObject(PutObjectRequest request, RuntimeObject runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>()
            {
                {"timeouted", "retry"},
                {"readTimeout", _defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", _defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", _default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", _default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", _default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", _default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", _default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", _default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", _defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>()
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>()
                {
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    Dictionary<string, string> ctx = new Dictionary<string, string>(){};
                    string token = _getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "PUT";
                    request_.Pathname = "/" + request.ObjectName;
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"host", GetHost(request.BucketName)},
                            {"date", _getDate()},
                            {"user-agent", _getUserAgent()},
                        },
                        _toHeader(request.Header.ToMap()),
                        _parseMeta(request.UserMeta, "x-oss-meta-")
                    );
                    if (!_empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Body = _inject(request.Body, ctx);
                    if (_notNull(request.Header.ToMap()) && !_empty(request.Header.ContentType))
                    {
                        request_.Headers["content-type"] = request.Header.ContentType;
                    }
else
                    {
                        request_.Headers["content-type"] = _getContentType(request.ObjectName);
                    }
                    request_.Headers["authorization"] = GetSignature(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (_isFail(response_))
                    {
                        bodyStr = _readAsString(response_);
                        respMap = _getErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>()
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    if (_isEnableCrc && !_equal(ctx["crc"], response_.Headers["x-oss-hash-crc64ecma"]))
                    {
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", "CrcNotMatched"},
                            {"data", new Dictionary<string, string>()
                            {
                                {"clientCrc", ctx["crc"]},
                                {"serverCrc", response_.Headers["x-oss-hash-crc64ecma"]},
                            }},
                        });
                    }
                    if (_isEnableMD5 && !_equal(ctx["md5"], response_.Headers["content-md5"]))
                    {
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", "MD5NotMatched"},
                            {"data", new Dictionary<string, string>()
                            {
                                {"clientMD5", ctx["md5"]},
                                {"serverMD5", response_.Headers["content-md5"]},
                            }},
                        });
                    }
                    return TeaModel.ToObject<PutObjectResponse>(TeaConverter.merge<string>
                    (
                        response_.Headers
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public async Task<PutObjectResponse> PutObjectAsync(PutObjectRequest request, RuntimeObject runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>()
            {
                {"timeouted", "retry"},
                {"readTimeout", _defaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", _defaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", _default(runtime.LocalAddr, _localAddr)},
                {"httpProxy", _default(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", _default(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", _default(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", _default(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", _default(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", _defaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>()
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>()
                {
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"logger", _logger},
                {"listener", runtime.Listener},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    Dictionary<string, string> ctx = new Dictionary<string, string>(){};
                    string token = _getSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "PUT";
                    request_.Pathname = "/" + request.ObjectName;
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"host", GetHost(request.BucketName)},
                            {"date", _getDate()},
                            {"user-agent", _getUserAgent()},
                        },
                        _toHeader(request.Header.ToMap()),
                        _parseMeta(request.UserMeta, "x-oss-meta-")
                    );
                    if (!_empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Body = _inject(request.Body, ctx);
                    if (_notNull(request.Header.ToMap()) && !_empty(request.Header.ContentType))
                    {
                        request_.Headers["content-type"] = request.Header.ContentType;
                    }
else
                    {
                        request_.Headers["content-type"] = _getContentType(request.ObjectName);
                    }
                    request_.Headers["authorization"] = await GetSignatureAsync(request_, request.BucketName);
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (_isFail(response_))
                    {
                        bodyStr = _readAsString(response_);
                        respMap = _getErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", respMap["Code"]},
                            {"message", respMap["Message"]},
                            {"data", new Dictionary<string, object>()
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap["RequestId"]},
                                {"hostId", respMap["HostId"]},
                            }},
                        });
                    }
                    if (_isEnableCrc && !_equal(ctx["crc"], response_.Headers["x-oss-hash-crc64ecma"]))
                    {
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", "CrcNotMatched"},
                            {"data", new Dictionary<string, string>()
                            {
                                {"clientCrc", ctx["crc"]},
                                {"serverCrc", response_.Headers["x-oss-hash-crc64ecma"]},
                            }},
                        });
                    }
                    if (_isEnableMD5 && !_equal(ctx["md5"], response_.Headers["content-md5"]))
                    {
                        throw new TeaException(new Dictionary<string, object>()
                        {
                            {"code", "MD5NotMatched"},
                            {"data", new Dictionary<string, string>()
                            {
                                {"clientMD5", ctx["md5"]},
                                {"serverMD5", response_.Headers["content-md5"]},
                            }},
                        });
                    }
                    return TeaModel.ToObject<PutObjectResponse>(TeaConverter.merge<string>
                    (
                        response_.Headers
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public string GetHost(string bucketName)
        {
            if (_empty(_regionId))
            {
                this._regionId = "cn-hangzhou";
            }
            if (_empty(_endpoint))
            {
                this._endpoint = "oss-" + _regionId + ".aliyuncs.com";
            }
            if (_empty(bucketName))
            {
                return _endpoint;
            }
            string host = null;
            if (_equal(_hostModel, "ip"))
            {
                host = _endpoint + "/" + bucketName;
            }
            else if (_equal(_hostModel, "cname"))
            {
                host = _endpoint;
            }
            else
            {
                host = bucketName + "." + _endpoint;
            }
            return host;
        }

        public string GetSignature(TeaRequest request, string bucketName)
        {
            string accessKeyId = _getAccessKeyID();
            string accessKeySecret = _getAccessKeySecret();
            if (_equal(_signatureVersion, "V2"))
            {
                if (_ifListEmpty(_addtionalHeaders))
                {
                    return "OSS2 AccessKeyId:" + accessKeyId + ",Signature:" + _getSignatureV2(request, bucketName, accessKeySecret, _addtionalHeaders);
                }
                else
                {
                    return "OSS2 AccessKeyId:" + accessKeyId + ",AdditionalHeaders:" + _listToString(_addtionalHeaders, ";") + ",Signature:" + _getSignatureV2(request, bucketName, accessKeySecret, _addtionalHeaders);
                }
            }
            else
            {
                return "OSS " + accessKeyId + ":" + _getSignatureV1(request, bucketName, accessKeySecret);
            }
        }

        public async Task<string> GetSignatureAsync(TeaRequest request, string bucketName)
        {
            string accessKeyId = _getAccessKeyID();
            string accessKeySecret = _getAccessKeySecret();
            if (_equal(_signatureVersion, "V2"))
            {
                if (_ifListEmpty(_addtionalHeaders))
                {
                    return "OSS2 AccessKeyId:" + accessKeyId + ",Signature:" + _getSignatureV2(request, bucketName, accessKeySecret, _addtionalHeaders);
                }
                else
                {
                    return "OSS2 AccessKeyId:" + accessKeyId + ",AdditionalHeaders:" + _listToString(_addtionalHeaders, ";") + ",Signature:" + _getSignatureV2(request, bucketName, accessKeySecret, _addtionalHeaders);
                }
            }
            else
            {
                return "OSS " + accessKeyId + ":" + _getSignatureV1(request, bucketName, accessKeySecret);
            }
        }

    }
}
