// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.OSS.Models;

namespace AlibabaCloud.OSS
{
    public class Client 
    {
        protected string _endpoint;
        protected string _regionId;
        protected string _hostModel;
        protected string _protocol;
        protected int? _readTimeout;
        protected int? _connectTimeout;
        protected string _signatureVersion;
        protected List<string> _addtionalHeaders;
        protected string _localAddr;
        protected string _httpProxy;
        protected string _httpsProxy;
        protected string _noProxy;
        protected string _userAgent;
        protected string _socks5Proxy;
        protected bool? _isEnableCrc;
        protected bool? _isEnableMD5;
        protected string _socks5NetWork;
        protected int? _maxIdleConns;
        protected Aliyun.Credentials.Client _credential;

        public Client(Config config)
        {
            if (AlibabaCloud.TeaUtil.Common.IsUnset(config.ToMap()))
            {
                throw new TeaException(new Dictionary<string, string>
                {
                    {"name", "ParameterMissing"},
                    {"message", "'config' can not be unset"},
                });
            }
            if (AlibabaCloud.TeaUtil.Common.Empty(config.Type))
            {
                config.Type = "access_key";
            }
            Aliyun.Credentials.Models.Config credentialConfig = new Aliyun.Credentials.Models.Config
            {
                AccessKeyId = config.AccessKeyId,
                Type = config.Type,
                AccessKeySecret = config.AccessKeySecret,
                SecurityToken = config.SecurityToken,
            };
            this._credential = new Aliyun.Credentials.Client(credentialConfig);
            if (AlibabaCloud.TeaUtil.Common.IsUnset(config.IsEnableMD5))
            {
                config.IsEnableMD5 = false;
            }
            if (AlibabaCloud.TeaUtil.Common.IsUnset(config.IsEnableCrc))
            {
                config.IsEnableCrc = false;
            }
            this._endpoint = config.Endpoint;
            this._protocol = config.Protocol;
            this._regionId = config.RegionId;
            this._userAgent = config.UserAgent;
            this._readTimeout = config.ReadTimeout;
            this._connectTimeout = config.ConnectTimeout;
            this._localAddr = config.LocalAddr;
            this._httpProxy = config.HttpProxy;
            this._httpsProxy = config.HttpsProxy;
            this._noProxy = config.NoProxy;
            this._socks5Proxy = config.Socks5Proxy;
            this._socks5NetWork = config.Socks5NetWork;
            this._maxIdleConns = config.MaxIdleConns;
            this._signatureVersion = config.SignatureVersion;
            this._addtionalHeaders = config.AddtionalHeaders;
            this._hostModel = config.HostModel;
            this._isEnableMD5 = config.IsEnableMD5;
            this._isEnableCrc = config.IsEnableCrc;
        }

        public PutBucketLifecycleResponse PutBucketLifecycle(PutBucketLifecycleRequest request, AlibabaCloud.OSSUtil.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
                {"timeouted", "retry"},
                {"readTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.LocalAddr, _localAddr)},
                {"httpProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accessKeyId = this._credential.GetAccessKeyId();
                    string accessKeySecret = this._credential.GetAccessKeySecret();
                    string token = this._credential.GetSecurityToken();
                    string reqBody = AlibabaCloud.TeaXML.Client.ToXML(request.Body.ToMap());
                    request_.Protocol = _protocol;
                    request_.Method = "PUT";
                    request_.Pathname = "/?lifecycle";
                    request_.Headers = new Dictionary<string, string>
                    {
                        {"host", AlibabaCloud.OSSUtil.Common.GetHost(request.BucketName, _regionId, _endpoint, _hostModel)},
                        {"date", AlibabaCloud.TeaUtil.Common.GetDateUTCString()},
                        {"user-agent", GetUserAgent()},
                    };
                    if (!AlibabaCloud.TeaUtil.Common.Empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Body = TeaCore.BytesReadable(reqBody);
                    request_.Headers["authorization"] = AlibabaCloud.OSSUtil.Common.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (AlibabaCloud.TeaUtil.Common.Is4xx(response_.StatusCode) || AlibabaCloud.TeaUtil.Common.Is5xx(response_.StatusCode))
                    {
                        bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                        respMap = AlibabaCloud.OSSUtil.Common.GetErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", respMap.Get("Code")},
                            {"message", respMap.Get("Message")},
                            {"data", new Dictionary<string, object>
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap.Get("RequestId")},
                                {"hostId", respMap.Get("HostId")},
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

        public async Task<PutBucketLifecycleResponse> PutBucketLifecycleAsync(PutBucketLifecycleRequest request, AlibabaCloud.OSSUtil.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
                {"timeouted", "retry"},
                {"readTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.LocalAddr, _localAddr)},
                {"httpProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accessKeyId = await this._credential.GetAccessKeyIdAsync();
                    string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
                    string token = await this._credential.GetSecurityTokenAsync();
                    string reqBody = AlibabaCloud.TeaXML.Client.ToXML(request.Body.ToMap());
                    request_.Protocol = _protocol;
                    request_.Method = "PUT";
                    request_.Pathname = "/?lifecycle";
                    request_.Headers = new Dictionary<string, string>
                    {
                        {"host", AlibabaCloud.OSSUtil.Common.GetHost(request.BucketName, _regionId, _endpoint, _hostModel)},
                        {"date", AlibabaCloud.TeaUtil.Common.GetDateUTCString()},
                        {"user-agent", GetUserAgent()},
                    };
                    if (!AlibabaCloud.TeaUtil.Common.Empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Body = TeaCore.BytesReadable(reqBody);
                    request_.Headers["authorization"] = AlibabaCloud.OSSUtil.Common.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders);
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (AlibabaCloud.TeaUtil.Common.Is4xx(response_.StatusCode) || AlibabaCloud.TeaUtil.Common.Is5xx(response_.StatusCode))
                    {
                        bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                        respMap = AlibabaCloud.OSSUtil.Common.GetErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", respMap.Get("Code")},
                            {"message", respMap.Get("Message")},
                            {"data", new Dictionary<string, object>
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap.Get("RequestId")},
                                {"hostId", respMap.Get("HostId")},
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

        public DeleteMultipleObjectsResponse DeleteMultipleObjects(DeleteMultipleObjectsRequest request, AlibabaCloud.OSSUtil.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
                {"timeouted", "retry"},
                {"readTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.LocalAddr, _localAddr)},
                {"httpProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accessKeyId = this._credential.GetAccessKeyId();
                    string accessKeySecret = this._credential.GetAccessKeySecret();
                    string token = this._credential.GetSecurityToken();
                    string reqBody = AlibabaCloud.TeaXML.Client.ToXML(request.Body.ToMap());
                    request_.Protocol = _protocol;
                    request_.Method = "POST";
                    request_.Pathname = "/?delete";
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"host", AlibabaCloud.OSSUtil.Common.GetHost(request.BucketName, _regionId, _endpoint, _hostModel)},
                            {"date", AlibabaCloud.TeaUtil.Common.GetDateUTCString()},
                            {"user-agent", GetUserAgent()},
                        },
                        AlibabaCloud.TeaUtil.Common.StringifyMapValue(request.Header.ToMap())
                    );
                    if (!AlibabaCloud.TeaUtil.Common.Empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Body = TeaCore.BytesReadable(reqBody);
                    if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Header.ToMap()) && !AlibabaCloud.TeaUtil.Common.Empty(request.Header.ContentMD5))
                    {
                        request_.Headers["content-md5"] = request.Header.ContentMD5;
                    }
                    else
                    {
                        request_.Headers["content-md5"] = AlibabaCloud.OSSUtil.Common.GetContentMD5(reqBody, _isEnableMD5.Value);
                    }
                    request_.Headers["authorization"] = AlibabaCloud.OSSUtil.Common.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (AlibabaCloud.TeaUtil.Common.Is4xx(response_.StatusCode) || AlibabaCloud.TeaUtil.Common.Is5xx(response_.StatusCode))
                    {
                        bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                        respMap = AlibabaCloud.OSSUtil.Common.GetErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", respMap.Get("Code")},
                            {"message", respMap.Get("Message")},
                            {"data", new Dictionary<string, object>
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap.Get("RequestId")},
                                {"hostId", respMap.Get("HostId")},
                            }},
                        });
                    }
                    bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                    respMap = AlibabaCloud.TeaXML.Client.ParseXml(bodyStr, typeof(DeleteMultipleObjectsResponse));
                    return TeaModel.ToObject<DeleteMultipleObjectsResponse>(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"DeleteResult", respMap.Get("DeleteResult")},
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

        public async Task<DeleteMultipleObjectsResponse> DeleteMultipleObjectsAsync(DeleteMultipleObjectsRequest request, AlibabaCloud.OSSUtil.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
                {"timeouted", "retry"},
                {"readTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.LocalAddr, _localAddr)},
                {"httpProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accessKeyId = await this._credential.GetAccessKeyIdAsync();
                    string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
                    string token = await this._credential.GetSecurityTokenAsync();
                    string reqBody = AlibabaCloud.TeaXML.Client.ToXML(request.Body.ToMap());
                    request_.Protocol = _protocol;
                    request_.Method = "POST";
                    request_.Pathname = "/?delete";
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"host", AlibabaCloud.OSSUtil.Common.GetHost(request.BucketName, _regionId, _endpoint, _hostModel)},
                            {"date", AlibabaCloud.TeaUtil.Common.GetDateUTCString()},
                            {"user-agent", GetUserAgent()},
                        },
                        AlibabaCloud.TeaUtil.Common.StringifyMapValue(request.Header.ToMap())
                    );
                    if (!AlibabaCloud.TeaUtil.Common.Empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Body = TeaCore.BytesReadable(reqBody);
                    if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Header.ToMap()) && !AlibabaCloud.TeaUtil.Common.Empty(request.Header.ContentMD5))
                    {
                        request_.Headers["content-md5"] = request.Header.ContentMD5;
                    }
                    else
                    {
                        request_.Headers["content-md5"] = AlibabaCloud.OSSUtil.Common.GetContentMD5(reqBody, _isEnableMD5.Value);
                    }
                    request_.Headers["authorization"] = AlibabaCloud.OSSUtil.Common.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders);
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (AlibabaCloud.TeaUtil.Common.Is4xx(response_.StatusCode) || AlibabaCloud.TeaUtil.Common.Is5xx(response_.StatusCode))
                    {
                        bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                        respMap = AlibabaCloud.OSSUtil.Common.GetErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", respMap.Get("Code")},
                            {"message", respMap.Get("Message")},
                            {"data", new Dictionary<string, object>
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap.Get("RequestId")},
                                {"hostId", respMap.Get("HostId")},
                            }},
                        });
                    }
                    bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                    respMap = AlibabaCloud.TeaXML.Client.ParseXml(bodyStr, typeof(DeleteMultipleObjectsResponse));
                    return TeaModel.ToObject<DeleteMultipleObjectsResponse>(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"DeleteResult", respMap.Get("DeleteResult")},
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

        public PutBucketRefererResponse PutBucketReferer(PutBucketRefererRequest request, AlibabaCloud.OSSUtil.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
                {"timeouted", "retry"},
                {"readTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.LocalAddr, _localAddr)},
                {"httpProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accessKeyId = this._credential.GetAccessKeyId();
                    string accessKeySecret = this._credential.GetAccessKeySecret();
                    string token = this._credential.GetSecurityToken();
                    string reqBody = AlibabaCloud.TeaXML.Client.ToXML(request.Body.ToMap());
                    request_.Protocol = _protocol;
                    request_.Method = "PUT";
                    request_.Pathname = "/?referer";
                    request_.Headers = new Dictionary<string, string>
                    {
                        {"host", AlibabaCloud.OSSUtil.Common.GetHost(request.BucketName, _regionId, _endpoint, _hostModel)},
                        {"date", AlibabaCloud.TeaUtil.Common.GetDateUTCString()},
                        {"user-agent", GetUserAgent()},
                    };
                    if (!AlibabaCloud.TeaUtil.Common.Empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Body = TeaCore.BytesReadable(reqBody);
                    request_.Headers["authorization"] = AlibabaCloud.OSSUtil.Common.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (AlibabaCloud.TeaUtil.Common.Is4xx(response_.StatusCode) || AlibabaCloud.TeaUtil.Common.Is5xx(response_.StatusCode))
                    {
                        bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                        respMap = AlibabaCloud.OSSUtil.Common.GetErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", respMap.Get("Code")},
                            {"message", respMap.Get("Message")},
                            {"data", new Dictionary<string, object>
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap.Get("RequestId")},
                                {"hostId", respMap.Get("HostId")},
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

        public async Task<PutBucketRefererResponse> PutBucketRefererAsync(PutBucketRefererRequest request, AlibabaCloud.OSSUtil.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
                {"timeouted", "retry"},
                {"readTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.LocalAddr, _localAddr)},
                {"httpProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accessKeyId = await this._credential.GetAccessKeyIdAsync();
                    string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
                    string token = await this._credential.GetSecurityTokenAsync();
                    string reqBody = AlibabaCloud.TeaXML.Client.ToXML(request.Body.ToMap());
                    request_.Protocol = _protocol;
                    request_.Method = "PUT";
                    request_.Pathname = "/?referer";
                    request_.Headers = new Dictionary<string, string>
                    {
                        {"host", AlibabaCloud.OSSUtil.Common.GetHost(request.BucketName, _regionId, _endpoint, _hostModel)},
                        {"date", AlibabaCloud.TeaUtil.Common.GetDateUTCString()},
                        {"user-agent", GetUserAgent()},
                    };
                    if (!AlibabaCloud.TeaUtil.Common.Empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Body = TeaCore.BytesReadable(reqBody);
                    request_.Headers["authorization"] = AlibabaCloud.OSSUtil.Common.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders);
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (AlibabaCloud.TeaUtil.Common.Is4xx(response_.StatusCode) || AlibabaCloud.TeaUtil.Common.Is5xx(response_.StatusCode))
                    {
                        bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                        respMap = AlibabaCloud.OSSUtil.Common.GetErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", respMap.Get("Code")},
                            {"message", respMap.Get("Message")},
                            {"data", new Dictionary<string, object>
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap.Get("RequestId")},
                                {"hostId", respMap.Get("HostId")},
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

        public PutBucketWebsiteResponse PutBucketWebsite(PutBucketWebsiteRequest request, AlibabaCloud.OSSUtil.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
                {"timeouted", "retry"},
                {"readTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.LocalAddr, _localAddr)},
                {"httpProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accessKeyId = this._credential.GetAccessKeyId();
                    string accessKeySecret = this._credential.GetAccessKeySecret();
                    string token = this._credential.GetSecurityToken();
                    string reqBody = AlibabaCloud.TeaXML.Client.ToXML(request.Body.ToMap());
                    request_.Protocol = _protocol;
                    request_.Method = "PUT";
                    request_.Pathname = "/?website";
                    request_.Headers = new Dictionary<string, string>
                    {
                        {"host", AlibabaCloud.OSSUtil.Common.GetHost(request.BucketName, _regionId, _endpoint, _hostModel)},
                        {"date", AlibabaCloud.TeaUtil.Common.GetDateUTCString()},
                        {"user-agent", GetUserAgent()},
                    };
                    if (!AlibabaCloud.TeaUtil.Common.Empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Body = TeaCore.BytesReadable(reqBody);
                    request_.Headers["authorization"] = AlibabaCloud.OSSUtil.Common.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (AlibabaCloud.TeaUtil.Common.Is4xx(response_.StatusCode) || AlibabaCloud.TeaUtil.Common.Is5xx(response_.StatusCode))
                    {
                        bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                        respMap = AlibabaCloud.OSSUtil.Common.GetErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", respMap.Get("Code")},
                            {"message", respMap.Get("Message")},
                            {"data", new Dictionary<string, object>
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap.Get("RequestId")},
                                {"hostId", respMap.Get("HostId")},
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

        public async Task<PutBucketWebsiteResponse> PutBucketWebsiteAsync(PutBucketWebsiteRequest request, AlibabaCloud.OSSUtil.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
                {"timeouted", "retry"},
                {"readTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.LocalAddr, _localAddr)},
                {"httpProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accessKeyId = await this._credential.GetAccessKeyIdAsync();
                    string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
                    string token = await this._credential.GetSecurityTokenAsync();
                    string reqBody = AlibabaCloud.TeaXML.Client.ToXML(request.Body.ToMap());
                    request_.Protocol = _protocol;
                    request_.Method = "PUT";
                    request_.Pathname = "/?website";
                    request_.Headers = new Dictionary<string, string>
                    {
                        {"host", AlibabaCloud.OSSUtil.Common.GetHost(request.BucketName, _regionId, _endpoint, _hostModel)},
                        {"date", AlibabaCloud.TeaUtil.Common.GetDateUTCString()},
                        {"user-agent", GetUserAgent()},
                    };
                    if (!AlibabaCloud.TeaUtil.Common.Empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Body = TeaCore.BytesReadable(reqBody);
                    request_.Headers["authorization"] = AlibabaCloud.OSSUtil.Common.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders);
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (AlibabaCloud.TeaUtil.Common.Is4xx(response_.StatusCode) || AlibabaCloud.TeaUtil.Common.Is5xx(response_.StatusCode))
                    {
                        bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                        respMap = AlibabaCloud.OSSUtil.Common.GetErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", respMap.Get("Code")},
                            {"message", respMap.Get("Message")},
                            {"data", new Dictionary<string, object>
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap.Get("RequestId")},
                                {"hostId", respMap.Get("HostId")},
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

        public CompleteMultipartUploadResponse CompleteMultipartUpload(CompleteMultipartUploadRequest request, AlibabaCloud.OSSUtil.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
                {"timeouted", "retry"},
                {"readTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.LocalAddr, _localAddr)},
                {"httpProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accessKeyId = this._credential.GetAccessKeyId();
                    string accessKeySecret = this._credential.GetAccessKeySecret();
                    string token = this._credential.GetSecurityToken();
                    string reqBody = AlibabaCloud.TeaXML.Client.ToXML(request.Body.ToMap());
                    request_.Protocol = _protocol;
                    request_.Method = "POST";
                    request_.Pathname = "/" + request.ObjectName;
                    request_.Headers = new Dictionary<string, string>
                    {
                        {"host", AlibabaCloud.OSSUtil.Common.GetHost(request.BucketName, _regionId, _endpoint, _hostModel)},
                        {"date", AlibabaCloud.TeaUtil.Common.GetDateUTCString()},
                        {"user-agent", GetUserAgent()},
                    };
                    if (!AlibabaCloud.TeaUtil.Common.Empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Query = AlibabaCloud.TeaUtil.Common.StringifyMapValue(request.Filter.ToMap());
                    request_.Body = TeaCore.BytesReadable(reqBody);
                    request_.Headers["authorization"] = AlibabaCloud.OSSUtil.Common.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (AlibabaCloud.TeaUtil.Common.Is4xx(response_.StatusCode) || AlibabaCloud.TeaUtil.Common.Is5xx(response_.StatusCode))
                    {
                        bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                        respMap = AlibabaCloud.OSSUtil.Common.GetErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", respMap.Get("Code")},
                            {"message", respMap.Get("Message")},
                            {"data", new Dictionary<string, object>
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap.Get("RequestId")},
                                {"hostId", respMap.Get("HostId")},
                            }},
                        });
                    }
                    bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                    respMap = AlibabaCloud.TeaXML.Client.ParseXml(bodyStr, typeof(CompleteMultipartUploadResponse));
                    return TeaModel.ToObject<CompleteMultipartUploadResponse>(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"CompleteMultipartUploadResult", respMap.Get("CompleteMultipartUploadResult")},
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

        public async Task<CompleteMultipartUploadResponse> CompleteMultipartUploadAsync(CompleteMultipartUploadRequest request, AlibabaCloud.OSSUtil.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
                {"timeouted", "retry"},
                {"readTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.LocalAddr, _localAddr)},
                {"httpProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accessKeyId = await this._credential.GetAccessKeyIdAsync();
                    string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
                    string token = await this._credential.GetSecurityTokenAsync();
                    string reqBody = AlibabaCloud.TeaXML.Client.ToXML(request.Body.ToMap());
                    request_.Protocol = _protocol;
                    request_.Method = "POST";
                    request_.Pathname = "/" + request.ObjectName;
                    request_.Headers = new Dictionary<string, string>
                    {
                        {"host", AlibabaCloud.OSSUtil.Common.GetHost(request.BucketName, _regionId, _endpoint, _hostModel)},
                        {"date", AlibabaCloud.TeaUtil.Common.GetDateUTCString()},
                        {"user-agent", GetUserAgent()},
                    };
                    if (!AlibabaCloud.TeaUtil.Common.Empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Query = AlibabaCloud.TeaUtil.Common.StringifyMapValue(request.Filter.ToMap());
                    request_.Body = TeaCore.BytesReadable(reqBody);
                    request_.Headers["authorization"] = AlibabaCloud.OSSUtil.Common.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders);
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (AlibabaCloud.TeaUtil.Common.Is4xx(response_.StatusCode) || AlibabaCloud.TeaUtil.Common.Is5xx(response_.StatusCode))
                    {
                        bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                        respMap = AlibabaCloud.OSSUtil.Common.GetErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", respMap.Get("Code")},
                            {"message", respMap.Get("Message")},
                            {"data", new Dictionary<string, object>
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap.Get("RequestId")},
                                {"hostId", respMap.Get("HostId")},
                            }},
                        });
                    }
                    bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                    respMap = AlibabaCloud.TeaXML.Client.ParseXml(bodyStr, typeof(CompleteMultipartUploadResponse));
                    return TeaModel.ToObject<CompleteMultipartUploadResponse>(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"CompleteMultipartUploadResult", respMap.Get("CompleteMultipartUploadResult")},
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

        public PutBucketLoggingResponse PutBucketLogging(PutBucketLoggingRequest request, AlibabaCloud.OSSUtil.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
                {"timeouted", "retry"},
                {"readTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.LocalAddr, _localAddr)},
                {"httpProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accessKeyId = this._credential.GetAccessKeyId();
                    string accessKeySecret = this._credential.GetAccessKeySecret();
                    string token = this._credential.GetSecurityToken();
                    string reqBody = AlibabaCloud.TeaXML.Client.ToXML(request.Body.ToMap());
                    request_.Protocol = _protocol;
                    request_.Method = "PUT";
                    request_.Pathname = "/?logging";
                    request_.Headers = new Dictionary<string, string>
                    {
                        {"host", AlibabaCloud.OSSUtil.Common.GetHost(request.BucketName, _regionId, _endpoint, _hostModel)},
                        {"date", AlibabaCloud.TeaUtil.Common.GetDateUTCString()},
                        {"user-agent", GetUserAgent()},
                    };
                    if (!AlibabaCloud.TeaUtil.Common.Empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Body = TeaCore.BytesReadable(reqBody);
                    request_.Headers["authorization"] = AlibabaCloud.OSSUtil.Common.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (AlibabaCloud.TeaUtil.Common.Is4xx(response_.StatusCode) || AlibabaCloud.TeaUtil.Common.Is5xx(response_.StatusCode))
                    {
                        bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                        respMap = AlibabaCloud.OSSUtil.Common.GetErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", respMap.Get("Code")},
                            {"message", respMap.Get("Message")},
                            {"data", new Dictionary<string, object>
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap.Get("RequestId")},
                                {"hostId", respMap.Get("HostId")},
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

        public async Task<PutBucketLoggingResponse> PutBucketLoggingAsync(PutBucketLoggingRequest request, AlibabaCloud.OSSUtil.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
                {"timeouted", "retry"},
                {"readTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.LocalAddr, _localAddr)},
                {"httpProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accessKeyId = await this._credential.GetAccessKeyIdAsync();
                    string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
                    string token = await this._credential.GetSecurityTokenAsync();
                    string reqBody = AlibabaCloud.TeaXML.Client.ToXML(request.Body.ToMap());
                    request_.Protocol = _protocol;
                    request_.Method = "PUT";
                    request_.Pathname = "/?logging";
                    request_.Headers = new Dictionary<string, string>
                    {
                        {"host", AlibabaCloud.OSSUtil.Common.GetHost(request.BucketName, _regionId, _endpoint, _hostModel)},
                        {"date", AlibabaCloud.TeaUtil.Common.GetDateUTCString()},
                        {"user-agent", GetUserAgent()},
                    };
                    if (!AlibabaCloud.TeaUtil.Common.Empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Body = TeaCore.BytesReadable(reqBody);
                    request_.Headers["authorization"] = AlibabaCloud.OSSUtil.Common.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders);
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (AlibabaCloud.TeaUtil.Common.Is4xx(response_.StatusCode) || AlibabaCloud.TeaUtil.Common.Is5xx(response_.StatusCode))
                    {
                        bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                        respMap = AlibabaCloud.OSSUtil.Common.GetErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", respMap.Get("Code")},
                            {"message", respMap.Get("Message")},
                            {"data", new Dictionary<string, object>
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap.Get("RequestId")},
                                {"hostId", respMap.Get("HostId")},
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

        public PutBucketRequestPaymentResponse PutBucketRequestPayment(PutBucketRequestPaymentRequest request, AlibabaCloud.OSSUtil.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
                {"timeouted", "retry"},
                {"readTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.LocalAddr, _localAddr)},
                {"httpProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accessKeyId = this._credential.GetAccessKeyId();
                    string accessKeySecret = this._credential.GetAccessKeySecret();
                    string token = this._credential.GetSecurityToken();
                    string reqBody = AlibabaCloud.TeaXML.Client.ToXML(request.Body.ToMap());
                    request_.Protocol = _protocol;
                    request_.Method = "PUT";
                    request_.Pathname = "/?requestPayment";
                    request_.Headers = new Dictionary<string, string>
                    {
                        {"host", AlibabaCloud.OSSUtil.Common.GetHost(request.BucketName, _regionId, _endpoint, _hostModel)},
                        {"date", AlibabaCloud.TeaUtil.Common.GetDateUTCString()},
                        {"user-agent", GetUserAgent()},
                    };
                    if (!AlibabaCloud.TeaUtil.Common.Empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Body = TeaCore.BytesReadable(reqBody);
                    request_.Headers["authorization"] = AlibabaCloud.OSSUtil.Common.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (AlibabaCloud.TeaUtil.Common.Is4xx(response_.StatusCode) || AlibabaCloud.TeaUtil.Common.Is5xx(response_.StatusCode))
                    {
                        bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                        respMap = AlibabaCloud.OSSUtil.Common.GetErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", respMap.Get("Code")},
                            {"message", respMap.Get("Message")},
                            {"data", new Dictionary<string, object>
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap.Get("RequestId")},
                                {"hostId", respMap.Get("HostId")},
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

        public async Task<PutBucketRequestPaymentResponse> PutBucketRequestPaymentAsync(PutBucketRequestPaymentRequest request, AlibabaCloud.OSSUtil.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
                {"timeouted", "retry"},
                {"readTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.LocalAddr, _localAddr)},
                {"httpProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accessKeyId = await this._credential.GetAccessKeyIdAsync();
                    string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
                    string token = await this._credential.GetSecurityTokenAsync();
                    string reqBody = AlibabaCloud.TeaXML.Client.ToXML(request.Body.ToMap());
                    request_.Protocol = _protocol;
                    request_.Method = "PUT";
                    request_.Pathname = "/?requestPayment";
                    request_.Headers = new Dictionary<string, string>
                    {
                        {"host", AlibabaCloud.OSSUtil.Common.GetHost(request.BucketName, _regionId, _endpoint, _hostModel)},
                        {"date", AlibabaCloud.TeaUtil.Common.GetDateUTCString()},
                        {"user-agent", GetUserAgent()},
                    };
                    if (!AlibabaCloud.TeaUtil.Common.Empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Body = TeaCore.BytesReadable(reqBody);
                    request_.Headers["authorization"] = AlibabaCloud.OSSUtil.Common.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders);
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (AlibabaCloud.TeaUtil.Common.Is4xx(response_.StatusCode) || AlibabaCloud.TeaUtil.Common.Is5xx(response_.StatusCode))
                    {
                        bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                        respMap = AlibabaCloud.OSSUtil.Common.GetErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", respMap.Get("Code")},
                            {"message", respMap.Get("Message")},
                            {"data", new Dictionary<string, object>
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap.Get("RequestId")},
                                {"hostId", respMap.Get("HostId")},
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

        public PutBucketEncryptionResponse PutBucketEncryption(PutBucketEncryptionRequest request, AlibabaCloud.OSSUtil.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
                {"timeouted", "retry"},
                {"readTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.LocalAddr, _localAddr)},
                {"httpProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accessKeyId = this._credential.GetAccessKeyId();
                    string accessKeySecret = this._credential.GetAccessKeySecret();
                    string token = this._credential.GetSecurityToken();
                    string reqBody = AlibabaCloud.TeaXML.Client.ToXML(request.Body.ToMap());
                    request_.Protocol = _protocol;
                    request_.Method = "PUT";
                    request_.Pathname = "/?encryption";
                    request_.Headers = new Dictionary<string, string>
                    {
                        {"host", AlibabaCloud.OSSUtil.Common.GetHost(request.BucketName, _regionId, _endpoint, _hostModel)},
                        {"date", AlibabaCloud.TeaUtil.Common.GetDateUTCString()},
                        {"user-agent", GetUserAgent()},
                    };
                    if (!AlibabaCloud.TeaUtil.Common.Empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Body = TeaCore.BytesReadable(reqBody);
                    request_.Headers["authorization"] = AlibabaCloud.OSSUtil.Common.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (AlibabaCloud.TeaUtil.Common.Is4xx(response_.StatusCode) || AlibabaCloud.TeaUtil.Common.Is5xx(response_.StatusCode))
                    {
                        bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                        respMap = AlibabaCloud.OSSUtil.Common.GetErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", respMap.Get("Code")},
                            {"message", respMap.Get("Message")},
                            {"data", new Dictionary<string, object>
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap.Get("RequestId")},
                                {"hostId", respMap.Get("HostId")},
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

        public async Task<PutBucketEncryptionResponse> PutBucketEncryptionAsync(PutBucketEncryptionRequest request, AlibabaCloud.OSSUtil.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
                {"timeouted", "retry"},
                {"readTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.LocalAddr, _localAddr)},
                {"httpProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accessKeyId = await this._credential.GetAccessKeyIdAsync();
                    string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
                    string token = await this._credential.GetSecurityTokenAsync();
                    string reqBody = AlibabaCloud.TeaXML.Client.ToXML(request.Body.ToMap());
                    request_.Protocol = _protocol;
                    request_.Method = "PUT";
                    request_.Pathname = "/?encryption";
                    request_.Headers = new Dictionary<string, string>
                    {
                        {"host", AlibabaCloud.OSSUtil.Common.GetHost(request.BucketName, _regionId, _endpoint, _hostModel)},
                        {"date", AlibabaCloud.TeaUtil.Common.GetDateUTCString()},
                        {"user-agent", GetUserAgent()},
                    };
                    if (!AlibabaCloud.TeaUtil.Common.Empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Body = TeaCore.BytesReadable(reqBody);
                    request_.Headers["authorization"] = AlibabaCloud.OSSUtil.Common.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders);
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (AlibabaCloud.TeaUtil.Common.Is4xx(response_.StatusCode) || AlibabaCloud.TeaUtil.Common.Is5xx(response_.StatusCode))
                    {
                        bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                        respMap = AlibabaCloud.OSSUtil.Common.GetErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", respMap.Get("Code")},
                            {"message", respMap.Get("Message")},
                            {"data", new Dictionary<string, object>
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap.Get("RequestId")},
                                {"hostId", respMap.Get("HostId")},
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

        public PutLiveChannelResponse PutLiveChannel(PutLiveChannelRequest request, AlibabaCloud.OSSUtil.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
                {"timeouted", "retry"},
                {"readTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.LocalAddr, _localAddr)},
                {"httpProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accessKeyId = this._credential.GetAccessKeyId();
                    string accessKeySecret = this._credential.GetAccessKeySecret();
                    string token = this._credential.GetSecurityToken();
                    string reqBody = AlibabaCloud.TeaXML.Client.ToXML(request.Body.ToMap());
                    request_.Protocol = _protocol;
                    request_.Method = "PUT";
                    request_.Pathname = "/" + request.ChannelName + "?live";
                    request_.Headers = new Dictionary<string, string>
                    {
                        {"host", AlibabaCloud.OSSUtil.Common.GetHost(request.BucketName, _regionId, _endpoint, _hostModel)},
                        {"date", AlibabaCloud.TeaUtil.Common.GetDateUTCString()},
                        {"user-agent", GetUserAgent()},
                    };
                    if (!AlibabaCloud.TeaUtil.Common.Empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Body = TeaCore.BytesReadable(reqBody);
                    request_.Headers["authorization"] = AlibabaCloud.OSSUtil.Common.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (AlibabaCloud.TeaUtil.Common.Is4xx(response_.StatusCode) || AlibabaCloud.TeaUtil.Common.Is5xx(response_.StatusCode))
                    {
                        bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                        respMap = AlibabaCloud.OSSUtil.Common.GetErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", respMap.Get("Code")},
                            {"message", respMap.Get("Message")},
                            {"data", new Dictionary<string, object>
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap.Get("RequestId")},
                                {"hostId", respMap.Get("HostId")},
                            }},
                        });
                    }
                    bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                    respMap = AlibabaCloud.TeaXML.Client.ParseXml(bodyStr, typeof(PutLiveChannelResponse));
                    return TeaModel.ToObject<PutLiveChannelResponse>(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"CreateLiveChannelResult", respMap.Get("CreateLiveChannelResult")},
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

        public async Task<PutLiveChannelResponse> PutLiveChannelAsync(PutLiveChannelRequest request, AlibabaCloud.OSSUtil.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
                {"timeouted", "retry"},
                {"readTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.LocalAddr, _localAddr)},
                {"httpProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accessKeyId = await this._credential.GetAccessKeyIdAsync();
                    string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
                    string token = await this._credential.GetSecurityTokenAsync();
                    string reqBody = AlibabaCloud.TeaXML.Client.ToXML(request.Body.ToMap());
                    request_.Protocol = _protocol;
                    request_.Method = "PUT";
                    request_.Pathname = "/" + request.ChannelName + "?live";
                    request_.Headers = new Dictionary<string, string>
                    {
                        {"host", AlibabaCloud.OSSUtil.Common.GetHost(request.BucketName, _regionId, _endpoint, _hostModel)},
                        {"date", AlibabaCloud.TeaUtil.Common.GetDateUTCString()},
                        {"user-agent", GetUserAgent()},
                    };
                    if (!AlibabaCloud.TeaUtil.Common.Empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Body = TeaCore.BytesReadable(reqBody);
                    request_.Headers["authorization"] = AlibabaCloud.OSSUtil.Common.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders);
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (AlibabaCloud.TeaUtil.Common.Is4xx(response_.StatusCode) || AlibabaCloud.TeaUtil.Common.Is5xx(response_.StatusCode))
                    {
                        bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                        respMap = AlibabaCloud.OSSUtil.Common.GetErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", respMap.Get("Code")},
                            {"message", respMap.Get("Message")},
                            {"data", new Dictionary<string, object>
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap.Get("RequestId")},
                                {"hostId", respMap.Get("HostId")},
                            }},
                        });
                    }
                    bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                    respMap = AlibabaCloud.TeaXML.Client.ParseXml(bodyStr, typeof(PutLiveChannelResponse));
                    return TeaModel.ToObject<PutLiveChannelResponse>(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"CreateLiveChannelResult", respMap.Get("CreateLiveChannelResult")},
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

        public PutBucketTagsResponse PutBucketTags(PutBucketTagsRequest request, AlibabaCloud.OSSUtil.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
                {"timeouted", "retry"},
                {"readTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.LocalAddr, _localAddr)},
                {"httpProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accessKeyId = this._credential.GetAccessKeyId();
                    string accessKeySecret = this._credential.GetAccessKeySecret();
                    string token = this._credential.GetSecurityToken();
                    string reqBody = AlibabaCloud.TeaXML.Client.ToXML(request.Body.ToMap());
                    request_.Protocol = _protocol;
                    request_.Method = "PUT";
                    request_.Pathname = "/?tagging";
                    request_.Headers = new Dictionary<string, string>
                    {
                        {"host", AlibabaCloud.OSSUtil.Common.GetHost(request.BucketName, _regionId, _endpoint, _hostModel)},
                        {"date", AlibabaCloud.TeaUtil.Common.GetDateUTCString()},
                        {"user-agent", GetUserAgent()},
                    };
                    if (!AlibabaCloud.TeaUtil.Common.Empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Body = TeaCore.BytesReadable(reqBody);
                    request_.Headers["authorization"] = AlibabaCloud.OSSUtil.Common.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (AlibabaCloud.TeaUtil.Common.Is4xx(response_.StatusCode) || AlibabaCloud.TeaUtil.Common.Is5xx(response_.StatusCode))
                    {
                        bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                        respMap = AlibabaCloud.OSSUtil.Common.GetErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", respMap.Get("Code")},
                            {"message", respMap.Get("Message")},
                            {"data", new Dictionary<string, object>
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap.Get("RequestId")},
                                {"hostId", respMap.Get("HostId")},
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

        public async Task<PutBucketTagsResponse> PutBucketTagsAsync(PutBucketTagsRequest request, AlibabaCloud.OSSUtil.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
                {"timeouted", "retry"},
                {"readTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.LocalAddr, _localAddr)},
                {"httpProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accessKeyId = await this._credential.GetAccessKeyIdAsync();
                    string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
                    string token = await this._credential.GetSecurityTokenAsync();
                    string reqBody = AlibabaCloud.TeaXML.Client.ToXML(request.Body.ToMap());
                    request_.Protocol = _protocol;
                    request_.Method = "PUT";
                    request_.Pathname = "/?tagging";
                    request_.Headers = new Dictionary<string, string>
                    {
                        {"host", AlibabaCloud.OSSUtil.Common.GetHost(request.BucketName, _regionId, _endpoint, _hostModel)},
                        {"date", AlibabaCloud.TeaUtil.Common.GetDateUTCString()},
                        {"user-agent", GetUserAgent()},
                    };
                    if (!AlibabaCloud.TeaUtil.Common.Empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Body = TeaCore.BytesReadable(reqBody);
                    request_.Headers["authorization"] = AlibabaCloud.OSSUtil.Common.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders);
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (AlibabaCloud.TeaUtil.Common.Is4xx(response_.StatusCode) || AlibabaCloud.TeaUtil.Common.Is5xx(response_.StatusCode))
                    {
                        bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                        respMap = AlibabaCloud.OSSUtil.Common.GetErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", respMap.Get("Code")},
                            {"message", respMap.Get("Message")},
                            {"data", new Dictionary<string, object>
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap.Get("RequestId")},
                                {"hostId", respMap.Get("HostId")},
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

        public PutObjectTaggingResponse PutObjectTagging(PutObjectTaggingRequest request, AlibabaCloud.OSSUtil.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
                {"timeouted", "retry"},
                {"readTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.LocalAddr, _localAddr)},
                {"httpProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accessKeyId = this._credential.GetAccessKeyId();
                    string accessKeySecret = this._credential.GetAccessKeySecret();
                    string token = this._credential.GetSecurityToken();
                    string reqBody = AlibabaCloud.TeaXML.Client.ToXML(request.Body.ToMap());
                    request_.Protocol = _protocol;
                    request_.Method = "PUT";
                    request_.Pathname = "/" + request.ObjectName + "?tagging";
                    request_.Headers = new Dictionary<string, string>
                    {
                        {"host", AlibabaCloud.OSSUtil.Common.GetHost(request.BucketName, _regionId, _endpoint, _hostModel)},
                        {"date", AlibabaCloud.TeaUtil.Common.GetDateUTCString()},
                        {"user-agent", GetUserAgent()},
                    };
                    if (!AlibabaCloud.TeaUtil.Common.Empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Body = TeaCore.BytesReadable(reqBody);
                    request_.Headers["authorization"] = AlibabaCloud.OSSUtil.Common.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (AlibabaCloud.TeaUtil.Common.Is4xx(response_.StatusCode) || AlibabaCloud.TeaUtil.Common.Is5xx(response_.StatusCode))
                    {
                        bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                        respMap = AlibabaCloud.OSSUtil.Common.GetErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", respMap.Get("Code")},
                            {"message", respMap.Get("Message")},
                            {"data", new Dictionary<string, object>
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap.Get("RequestId")},
                                {"hostId", respMap.Get("HostId")},
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

        public async Task<PutObjectTaggingResponse> PutObjectTaggingAsync(PutObjectTaggingRequest request, AlibabaCloud.OSSUtil.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
                {"timeouted", "retry"},
                {"readTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.LocalAddr, _localAddr)},
                {"httpProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accessKeyId = await this._credential.GetAccessKeyIdAsync();
                    string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
                    string token = await this._credential.GetSecurityTokenAsync();
                    string reqBody = AlibabaCloud.TeaXML.Client.ToXML(request.Body.ToMap());
                    request_.Protocol = _protocol;
                    request_.Method = "PUT";
                    request_.Pathname = "/" + request.ObjectName + "?tagging";
                    request_.Headers = new Dictionary<string, string>
                    {
                        {"host", AlibabaCloud.OSSUtil.Common.GetHost(request.BucketName, _regionId, _endpoint, _hostModel)},
                        {"date", AlibabaCloud.TeaUtil.Common.GetDateUTCString()},
                        {"user-agent", GetUserAgent()},
                    };
                    if (!AlibabaCloud.TeaUtil.Common.Empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Body = TeaCore.BytesReadable(reqBody);
                    request_.Headers["authorization"] = AlibabaCloud.OSSUtil.Common.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders);
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (AlibabaCloud.TeaUtil.Common.Is4xx(response_.StatusCode) || AlibabaCloud.TeaUtil.Common.Is5xx(response_.StatusCode))
                    {
                        bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                        respMap = AlibabaCloud.OSSUtil.Common.GetErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", respMap.Get("Code")},
                            {"message", respMap.Get("Message")},
                            {"data", new Dictionary<string, object>
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap.Get("RequestId")},
                                {"hostId", respMap.Get("HostId")},
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

        public SelectObjectResponse SelectObject(SelectObjectRequest request, AlibabaCloud.OSSUtil.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
                {"timeouted", "retry"},
                {"readTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.LocalAddr, _localAddr)},
                {"httpProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accessKeyId = this._credential.GetAccessKeyId();
                    string accessKeySecret = this._credential.GetAccessKeySecret();
                    string token = this._credential.GetSecurityToken();
                    string reqBody = AlibabaCloud.TeaXML.Client.ToXML(request.Body.ToMap());
                    request_.Protocol = _protocol;
                    request_.Method = "POST";
                    request_.Pathname = "/" + request.ObjectName;
                    request_.Headers = new Dictionary<string, string>
                    {
                        {"host", AlibabaCloud.OSSUtil.Common.GetHost(request.BucketName, _regionId, _endpoint, _hostModel)},
                        {"date", AlibabaCloud.TeaUtil.Common.GetDateUTCString()},
                        {"user-agent", GetUserAgent()},
                    };
                    if (!AlibabaCloud.TeaUtil.Common.Empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Query = AlibabaCloud.TeaUtil.Common.StringifyMapValue(request.Filter.ToMap());
                    request_.Body = TeaCore.BytesReadable(reqBody);
                    request_.Headers["authorization"] = AlibabaCloud.OSSUtil.Common.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (AlibabaCloud.TeaUtil.Common.Is4xx(response_.StatusCode) || AlibabaCloud.TeaUtil.Common.Is5xx(response_.StatusCode))
                    {
                        bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                        respMap = AlibabaCloud.OSSUtil.Common.GetErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", respMap.Get("Code")},
                            {"message", respMap.Get("Message")},
                            {"data", new Dictionary<string, object>
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap.Get("RequestId")},
                                {"hostId", respMap.Get("HostId")},
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

        public async Task<SelectObjectResponse> SelectObjectAsync(SelectObjectRequest request, AlibabaCloud.OSSUtil.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
                {"timeouted", "retry"},
                {"readTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.LocalAddr, _localAddr)},
                {"httpProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accessKeyId = await this._credential.GetAccessKeyIdAsync();
                    string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
                    string token = await this._credential.GetSecurityTokenAsync();
                    string reqBody = AlibabaCloud.TeaXML.Client.ToXML(request.Body.ToMap());
                    request_.Protocol = _protocol;
                    request_.Method = "POST";
                    request_.Pathname = "/" + request.ObjectName;
                    request_.Headers = new Dictionary<string, string>
                    {
                        {"host", AlibabaCloud.OSSUtil.Common.GetHost(request.BucketName, _regionId, _endpoint, _hostModel)},
                        {"date", AlibabaCloud.TeaUtil.Common.GetDateUTCString()},
                        {"user-agent", GetUserAgent()},
                    };
                    if (!AlibabaCloud.TeaUtil.Common.Empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Query = AlibabaCloud.TeaUtil.Common.StringifyMapValue(request.Filter.ToMap());
                    request_.Body = TeaCore.BytesReadable(reqBody);
                    request_.Headers["authorization"] = AlibabaCloud.OSSUtil.Common.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders);
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (AlibabaCloud.TeaUtil.Common.Is4xx(response_.StatusCode) || AlibabaCloud.TeaUtil.Common.Is5xx(response_.StatusCode))
                    {
                        bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                        respMap = AlibabaCloud.OSSUtil.Common.GetErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", respMap.Get("Code")},
                            {"message", respMap.Get("Message")},
                            {"data", new Dictionary<string, object>
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap.Get("RequestId")},
                                {"hostId", respMap.Get("HostId")},
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

        public PutBucketCORSResponse PutBucketCORS(PutBucketCORSRequest request, AlibabaCloud.OSSUtil.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
                {"timeouted", "retry"},
                {"readTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.LocalAddr, _localAddr)},
                {"httpProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accessKeyId = this._credential.GetAccessKeyId();
                    string accessKeySecret = this._credential.GetAccessKeySecret();
                    string token = this._credential.GetSecurityToken();
                    string reqBody = AlibabaCloud.TeaXML.Client.ToXML(request.Body.ToMap());
                    request_.Protocol = _protocol;
                    request_.Method = "PUT";
                    request_.Pathname = "/?cors";
                    request_.Headers = new Dictionary<string, string>
                    {
                        {"host", AlibabaCloud.OSSUtil.Common.GetHost(request.BucketName, _regionId, _endpoint, _hostModel)},
                        {"date", AlibabaCloud.TeaUtil.Common.GetDateUTCString()},
                        {"user-agent", GetUserAgent()},
                    };
                    if (!AlibabaCloud.TeaUtil.Common.Empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Body = TeaCore.BytesReadable(reqBody);
                    request_.Headers["authorization"] = AlibabaCloud.OSSUtil.Common.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (AlibabaCloud.TeaUtil.Common.Is4xx(response_.StatusCode) || AlibabaCloud.TeaUtil.Common.Is5xx(response_.StatusCode))
                    {
                        bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                        respMap = AlibabaCloud.OSSUtil.Common.GetErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", respMap.Get("Code")},
                            {"message", respMap.Get("Message")},
                            {"data", new Dictionary<string, object>
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap.Get("RequestId")},
                                {"hostId", respMap.Get("HostId")},
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

        public async Task<PutBucketCORSResponse> PutBucketCORSAsync(PutBucketCORSRequest request, AlibabaCloud.OSSUtil.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
                {"timeouted", "retry"},
                {"readTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.LocalAddr, _localAddr)},
                {"httpProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accessKeyId = await this._credential.GetAccessKeyIdAsync();
                    string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
                    string token = await this._credential.GetSecurityTokenAsync();
                    string reqBody = AlibabaCloud.TeaXML.Client.ToXML(request.Body.ToMap());
                    request_.Protocol = _protocol;
                    request_.Method = "PUT";
                    request_.Pathname = "/?cors";
                    request_.Headers = new Dictionary<string, string>
                    {
                        {"host", AlibabaCloud.OSSUtil.Common.GetHost(request.BucketName, _regionId, _endpoint, _hostModel)},
                        {"date", AlibabaCloud.TeaUtil.Common.GetDateUTCString()},
                        {"user-agent", GetUserAgent()},
                    };
                    if (!AlibabaCloud.TeaUtil.Common.Empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Body = TeaCore.BytesReadable(reqBody);
                    request_.Headers["authorization"] = AlibabaCloud.OSSUtil.Common.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders);
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (AlibabaCloud.TeaUtil.Common.Is4xx(response_.StatusCode) || AlibabaCloud.TeaUtil.Common.Is5xx(response_.StatusCode))
                    {
                        bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                        respMap = AlibabaCloud.OSSUtil.Common.GetErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", respMap.Get("Code")},
                            {"message", respMap.Get("Message")},
                            {"data", new Dictionary<string, object>
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap.Get("RequestId")},
                                {"hostId", respMap.Get("HostId")},
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

        public PutBucketResponse PutBucket(PutBucketRequest request, AlibabaCloud.OSSUtil.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
                {"timeouted", "retry"},
                {"readTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.LocalAddr, _localAddr)},
                {"httpProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accessKeyId = this._credential.GetAccessKeyId();
                    string accessKeySecret = this._credential.GetAccessKeySecret();
                    string token = this._credential.GetSecurityToken();
                    string reqBody = AlibabaCloud.TeaXML.Client.ToXML(request.Body.ToMap());
                    request_.Protocol = _protocol;
                    request_.Method = "PUT";
                    request_.Pathname = "/";
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"host", AlibabaCloud.OSSUtil.Common.GetHost(request.BucketName, _regionId, _endpoint, _hostModel)},
                            {"date", AlibabaCloud.TeaUtil.Common.GetDateUTCString()},
                            {"user-agent", GetUserAgent()},
                        },
                        AlibabaCloud.TeaUtil.Common.StringifyMapValue(request.Header.ToMap())
                    );
                    if (!AlibabaCloud.TeaUtil.Common.Empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Body = TeaCore.BytesReadable(reqBody);
                    request_.Headers["authorization"] = AlibabaCloud.OSSUtil.Common.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (AlibabaCloud.TeaUtil.Common.Is4xx(response_.StatusCode) || AlibabaCloud.TeaUtil.Common.Is5xx(response_.StatusCode))
                    {
                        bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                        respMap = AlibabaCloud.OSSUtil.Common.GetErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", respMap.Get("Code")},
                            {"message", respMap.Get("Message")},
                            {"data", new Dictionary<string, object>
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap.Get("RequestId")},
                                {"hostId", respMap.Get("HostId")},
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

        public async Task<PutBucketResponse> PutBucketAsync(PutBucketRequest request, AlibabaCloud.OSSUtil.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
                {"timeouted", "retry"},
                {"readTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.LocalAddr, _localAddr)},
                {"httpProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accessKeyId = await this._credential.GetAccessKeyIdAsync();
                    string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
                    string token = await this._credential.GetSecurityTokenAsync();
                    string reqBody = AlibabaCloud.TeaXML.Client.ToXML(request.Body.ToMap());
                    request_.Protocol = _protocol;
                    request_.Method = "PUT";
                    request_.Pathname = "/";
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"host", AlibabaCloud.OSSUtil.Common.GetHost(request.BucketName, _regionId, _endpoint, _hostModel)},
                            {"date", AlibabaCloud.TeaUtil.Common.GetDateUTCString()},
                            {"user-agent", GetUserAgent()},
                        },
                        AlibabaCloud.TeaUtil.Common.StringifyMapValue(request.Header.ToMap())
                    );
                    if (!AlibabaCloud.TeaUtil.Common.Empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Body = TeaCore.BytesReadable(reqBody);
                    request_.Headers["authorization"] = AlibabaCloud.OSSUtil.Common.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders);
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (AlibabaCloud.TeaUtil.Common.Is4xx(response_.StatusCode) || AlibabaCloud.TeaUtil.Common.Is5xx(response_.StatusCode))
                    {
                        bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                        respMap = AlibabaCloud.OSSUtil.Common.GetErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", respMap.Get("Code")},
                            {"message", respMap.Get("Message")},
                            {"data", new Dictionary<string, object>
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap.Get("RequestId")},
                                {"hostId", respMap.Get("HostId")},
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

        public ListMultipartUploadsResponse ListMultipartUploads(ListMultipartUploadsRequest request, AlibabaCloud.OSSUtil.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
                {"timeouted", "retry"},
                {"readTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.LocalAddr, _localAddr)},
                {"httpProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accessKeyId = this._credential.GetAccessKeyId();
                    string accessKeySecret = this._credential.GetAccessKeySecret();
                    string token = this._credential.GetSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/?uploads";
                    request_.Headers = new Dictionary<string, string>
                    {
                        {"host", AlibabaCloud.OSSUtil.Common.GetHost(request.BucketName, _regionId, _endpoint, _hostModel)},
                        {"date", AlibabaCloud.TeaUtil.Common.GetDateUTCString()},
                        {"user-agent", GetUserAgent()},
                    };
                    if (!AlibabaCloud.TeaUtil.Common.Empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Query = AlibabaCloud.TeaUtil.Common.StringifyMapValue(request.Filter.ToMap());
                    request_.Headers["authorization"] = AlibabaCloud.OSSUtil.Common.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (AlibabaCloud.TeaUtil.Common.Is4xx(response_.StatusCode) || AlibabaCloud.TeaUtil.Common.Is5xx(response_.StatusCode))
                    {
                        bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                        respMap = AlibabaCloud.OSSUtil.Common.GetErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", respMap.Get("Code")},
                            {"message", respMap.Get("Message")},
                            {"data", new Dictionary<string, object>
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap.Get("RequestId")},
                                {"hostId", respMap.Get("HostId")},
                            }},
                        });
                    }
                    bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                    respMap = AlibabaCloud.TeaXML.Client.ParseXml(bodyStr, typeof(ListMultipartUploadsResponse));
                    return TeaModel.ToObject<ListMultipartUploadsResponse>(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"ListMultipartUploadsResult", respMap.Get("ListMultipartUploadsResult")},
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

        public async Task<ListMultipartUploadsResponse> ListMultipartUploadsAsync(ListMultipartUploadsRequest request, AlibabaCloud.OSSUtil.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
                {"timeouted", "retry"},
                {"readTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.LocalAddr, _localAddr)},
                {"httpProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accessKeyId = await this._credential.GetAccessKeyIdAsync();
                    string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
                    string token = await this._credential.GetSecurityTokenAsync();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/?uploads";
                    request_.Headers = new Dictionary<string, string>
                    {
                        {"host", AlibabaCloud.OSSUtil.Common.GetHost(request.BucketName, _regionId, _endpoint, _hostModel)},
                        {"date", AlibabaCloud.TeaUtil.Common.GetDateUTCString()},
                        {"user-agent", GetUserAgent()},
                    };
                    if (!AlibabaCloud.TeaUtil.Common.Empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Query = AlibabaCloud.TeaUtil.Common.StringifyMapValue(request.Filter.ToMap());
                    request_.Headers["authorization"] = AlibabaCloud.OSSUtil.Common.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders);
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (AlibabaCloud.TeaUtil.Common.Is4xx(response_.StatusCode) || AlibabaCloud.TeaUtil.Common.Is5xx(response_.StatusCode))
                    {
                        bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                        respMap = AlibabaCloud.OSSUtil.Common.GetErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", respMap.Get("Code")},
                            {"message", respMap.Get("Message")},
                            {"data", new Dictionary<string, object>
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap.Get("RequestId")},
                                {"hostId", respMap.Get("HostId")},
                            }},
                        });
                    }
                    bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                    respMap = AlibabaCloud.TeaXML.Client.ParseXml(bodyStr, typeof(ListMultipartUploadsResponse));
                    return TeaModel.ToObject<ListMultipartUploadsResponse>(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"ListMultipartUploadsResult", respMap.Get("ListMultipartUploadsResult")},
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

        public GetBucketRequestPaymentResponse GetBucketRequestPayment(GetBucketRequestPaymentRequest request, AlibabaCloud.OSSUtil.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
                {"timeouted", "retry"},
                {"readTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.LocalAddr, _localAddr)},
                {"httpProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accessKeyId = this._credential.GetAccessKeyId();
                    string accessKeySecret = this._credential.GetAccessKeySecret();
                    string token = this._credential.GetSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/?requestPayment";
                    request_.Headers = new Dictionary<string, string>
                    {
                        {"host", AlibabaCloud.OSSUtil.Common.GetHost(request.BucketName, _regionId, _endpoint, _hostModel)},
                        {"date", AlibabaCloud.TeaUtil.Common.GetDateUTCString()},
                        {"user-agent", GetUserAgent()},
                    };
                    if (!AlibabaCloud.TeaUtil.Common.Empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = AlibabaCloud.OSSUtil.Common.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (AlibabaCloud.TeaUtil.Common.Is4xx(response_.StatusCode) || AlibabaCloud.TeaUtil.Common.Is5xx(response_.StatusCode))
                    {
                        bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                        respMap = AlibabaCloud.OSSUtil.Common.GetErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", respMap.Get("Code")},
                            {"message", respMap.Get("Message")},
                            {"data", new Dictionary<string, object>
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap.Get("RequestId")},
                                {"hostId", respMap.Get("HostId")},
                            }},
                        });
                    }
                    bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                    respMap = AlibabaCloud.TeaXML.Client.ParseXml(bodyStr, typeof(GetBucketRequestPaymentResponse));
                    return TeaModel.ToObject<GetBucketRequestPaymentResponse>(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"RequestPaymentConfiguration", respMap.Get("RequestPaymentConfiguration")},
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

        public async Task<GetBucketRequestPaymentResponse> GetBucketRequestPaymentAsync(GetBucketRequestPaymentRequest request, AlibabaCloud.OSSUtil.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
                {"timeouted", "retry"},
                {"readTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.LocalAddr, _localAddr)},
                {"httpProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accessKeyId = await this._credential.GetAccessKeyIdAsync();
                    string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
                    string token = await this._credential.GetSecurityTokenAsync();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/?requestPayment";
                    request_.Headers = new Dictionary<string, string>
                    {
                        {"host", AlibabaCloud.OSSUtil.Common.GetHost(request.BucketName, _regionId, _endpoint, _hostModel)},
                        {"date", AlibabaCloud.TeaUtil.Common.GetDateUTCString()},
                        {"user-agent", GetUserAgent()},
                    };
                    if (!AlibabaCloud.TeaUtil.Common.Empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = AlibabaCloud.OSSUtil.Common.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders);
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (AlibabaCloud.TeaUtil.Common.Is4xx(response_.StatusCode) || AlibabaCloud.TeaUtil.Common.Is5xx(response_.StatusCode))
                    {
                        bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                        respMap = AlibabaCloud.OSSUtil.Common.GetErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", respMap.Get("Code")},
                            {"message", respMap.Get("Message")},
                            {"data", new Dictionary<string, object>
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap.Get("RequestId")},
                                {"hostId", respMap.Get("HostId")},
                            }},
                        });
                    }
                    bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                    respMap = AlibabaCloud.TeaXML.Client.ParseXml(bodyStr, typeof(GetBucketRequestPaymentResponse));
                    return TeaModel.ToObject<GetBucketRequestPaymentResponse>(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"RequestPaymentConfiguration", respMap.Get("RequestPaymentConfiguration")},
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

        public GetBucketEncryptionResponse GetBucketEncryption(GetBucketEncryptionRequest request, AlibabaCloud.OSSUtil.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
                {"timeouted", "retry"},
                {"readTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.LocalAddr, _localAddr)},
                {"httpProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accessKeyId = this._credential.GetAccessKeyId();
                    string accessKeySecret = this._credential.GetAccessKeySecret();
                    string token = this._credential.GetSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/?encryption";
                    request_.Headers = new Dictionary<string, string>
                    {
                        {"host", AlibabaCloud.OSSUtil.Common.GetHost(request.BucketName, _regionId, _endpoint, _hostModel)},
                        {"date", AlibabaCloud.TeaUtil.Common.GetDateUTCString()},
                        {"user-agent", GetUserAgent()},
                    };
                    if (!AlibabaCloud.TeaUtil.Common.Empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = AlibabaCloud.OSSUtil.Common.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (AlibabaCloud.TeaUtil.Common.Is4xx(response_.StatusCode) || AlibabaCloud.TeaUtil.Common.Is5xx(response_.StatusCode))
                    {
                        bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                        respMap = AlibabaCloud.OSSUtil.Common.GetErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", respMap.Get("Code")},
                            {"message", respMap.Get("Message")},
                            {"data", new Dictionary<string, object>
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap.Get("RequestId")},
                                {"hostId", respMap.Get("HostId")},
                            }},
                        });
                    }
                    bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                    respMap = AlibabaCloud.TeaXML.Client.ParseXml(bodyStr, typeof(GetBucketEncryptionResponse));
                    return TeaModel.ToObject<GetBucketEncryptionResponse>(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"ServerSideEncryptionRule", respMap.Get("ServerSideEncryptionRule")},
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

        public async Task<GetBucketEncryptionResponse> GetBucketEncryptionAsync(GetBucketEncryptionRequest request, AlibabaCloud.OSSUtil.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
                {"timeouted", "retry"},
                {"readTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.LocalAddr, _localAddr)},
                {"httpProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accessKeyId = await this._credential.GetAccessKeyIdAsync();
                    string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
                    string token = await this._credential.GetSecurityTokenAsync();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/?encryption";
                    request_.Headers = new Dictionary<string, string>
                    {
                        {"host", AlibabaCloud.OSSUtil.Common.GetHost(request.BucketName, _regionId, _endpoint, _hostModel)},
                        {"date", AlibabaCloud.TeaUtil.Common.GetDateUTCString()},
                        {"user-agent", GetUserAgent()},
                    };
                    if (!AlibabaCloud.TeaUtil.Common.Empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = AlibabaCloud.OSSUtil.Common.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders);
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (AlibabaCloud.TeaUtil.Common.Is4xx(response_.StatusCode) || AlibabaCloud.TeaUtil.Common.Is5xx(response_.StatusCode))
                    {
                        bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                        respMap = AlibabaCloud.OSSUtil.Common.GetErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", respMap.Get("Code")},
                            {"message", respMap.Get("Message")},
                            {"data", new Dictionary<string, object>
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap.Get("RequestId")},
                                {"hostId", respMap.Get("HostId")},
                            }},
                        });
                    }
                    bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                    respMap = AlibabaCloud.TeaXML.Client.ParseXml(bodyStr, typeof(GetBucketEncryptionResponse));
                    return TeaModel.ToObject<GetBucketEncryptionResponse>(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"ServerSideEncryptionRule", respMap.Get("ServerSideEncryptionRule")},
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

        public GetBucketTagsResponse GetBucketTags(GetBucketTagsRequest request, AlibabaCloud.OSSUtil.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
                {"timeouted", "retry"},
                {"readTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.LocalAddr, _localAddr)},
                {"httpProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accessKeyId = this._credential.GetAccessKeyId();
                    string accessKeySecret = this._credential.GetAccessKeySecret();
                    string token = this._credential.GetSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/?tagging";
                    request_.Headers = new Dictionary<string, string>
                    {
                        {"host", AlibabaCloud.OSSUtil.Common.GetHost(request.BucketName, _regionId, _endpoint, _hostModel)},
                        {"date", AlibabaCloud.TeaUtil.Common.GetDateUTCString()},
                        {"user-agent", GetUserAgent()},
                    };
                    if (!AlibabaCloud.TeaUtil.Common.Empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = AlibabaCloud.OSSUtil.Common.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (AlibabaCloud.TeaUtil.Common.Is4xx(response_.StatusCode) || AlibabaCloud.TeaUtil.Common.Is5xx(response_.StatusCode))
                    {
                        bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                        respMap = AlibabaCloud.OSSUtil.Common.GetErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", respMap.Get("Code")},
                            {"message", respMap.Get("Message")},
                            {"data", new Dictionary<string, object>
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap.Get("RequestId")},
                                {"hostId", respMap.Get("HostId")},
                            }},
                        });
                    }
                    bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                    respMap = AlibabaCloud.TeaXML.Client.ParseXml(bodyStr, typeof(GetBucketTagsResponse));
                    return TeaModel.ToObject<GetBucketTagsResponse>(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"Tagging", respMap.Get("Tagging")},
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

        public async Task<GetBucketTagsResponse> GetBucketTagsAsync(GetBucketTagsRequest request, AlibabaCloud.OSSUtil.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
                {"timeouted", "retry"},
                {"readTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.LocalAddr, _localAddr)},
                {"httpProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accessKeyId = await this._credential.GetAccessKeyIdAsync();
                    string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
                    string token = await this._credential.GetSecurityTokenAsync();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/?tagging";
                    request_.Headers = new Dictionary<string, string>
                    {
                        {"host", AlibabaCloud.OSSUtil.Common.GetHost(request.BucketName, _regionId, _endpoint, _hostModel)},
                        {"date", AlibabaCloud.TeaUtil.Common.GetDateUTCString()},
                        {"user-agent", GetUserAgent()},
                    };
                    if (!AlibabaCloud.TeaUtil.Common.Empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = AlibabaCloud.OSSUtil.Common.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders);
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (AlibabaCloud.TeaUtil.Common.Is4xx(response_.StatusCode) || AlibabaCloud.TeaUtil.Common.Is5xx(response_.StatusCode))
                    {
                        bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                        respMap = AlibabaCloud.OSSUtil.Common.GetErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", respMap.Get("Code")},
                            {"message", respMap.Get("Message")},
                            {"data", new Dictionary<string, object>
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap.Get("RequestId")},
                                {"hostId", respMap.Get("HostId")},
                            }},
                        });
                    }
                    bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                    respMap = AlibabaCloud.TeaXML.Client.ParseXml(bodyStr, typeof(GetBucketTagsResponse));
                    return TeaModel.ToObject<GetBucketTagsResponse>(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"Tagging", respMap.Get("Tagging")},
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

        public GetServiceResponse GetService(GetServiceRequest request, AlibabaCloud.OSSUtil.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
                {"timeouted", "retry"},
                {"readTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.LocalAddr, _localAddr)},
                {"httpProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accessKeyId = this._credential.GetAccessKeyId();
                    string accessKeySecret = this._credential.GetAccessKeySecret();
                    string token = this._credential.GetSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/";
                    request_.Headers = new Dictionary<string, string>
                    {
                        {"host", AlibabaCloud.OSSUtil.Common.GetHost("", _regionId, _endpoint, _hostModel)},
                        {"date", AlibabaCloud.TeaUtil.Common.GetDateUTCString()},
                        {"user-agent", GetUserAgent()},
                    };
                    if (!AlibabaCloud.TeaUtil.Common.Empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Query = AlibabaCloud.TeaUtil.Common.StringifyMapValue(request.Filter.ToMap());
                    request_.Headers["authorization"] = AlibabaCloud.OSSUtil.Common.GetSignature(request_, "", accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (AlibabaCloud.TeaUtil.Common.Is4xx(response_.StatusCode) || AlibabaCloud.TeaUtil.Common.Is5xx(response_.StatusCode))
                    {
                        bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                        respMap = AlibabaCloud.OSSUtil.Common.GetErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", respMap.Get("Code")},
                            {"message", respMap.Get("Message")},
                            {"data", new Dictionary<string, object>
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap.Get("RequestId")},
                                {"hostId", respMap.Get("HostId")},
                            }},
                        });
                    }
                    bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                    respMap = AlibabaCloud.TeaXML.Client.ParseXml(bodyStr, typeof(GetServiceResponse));
                    return TeaModel.ToObject<GetServiceResponse>(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"ListAllMyBucketsResult", respMap.Get("ListAllMyBucketsResult")},
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

        public async Task<GetServiceResponse> GetServiceAsync(GetServiceRequest request, AlibabaCloud.OSSUtil.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
                {"timeouted", "retry"},
                {"readTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.LocalAddr, _localAddr)},
                {"httpProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accessKeyId = await this._credential.GetAccessKeyIdAsync();
                    string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
                    string token = await this._credential.GetSecurityTokenAsync();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/";
                    request_.Headers = new Dictionary<string, string>
                    {
                        {"host", AlibabaCloud.OSSUtil.Common.GetHost("", _regionId, _endpoint, _hostModel)},
                        {"date", AlibabaCloud.TeaUtil.Common.GetDateUTCString()},
                        {"user-agent", GetUserAgent()},
                    };
                    if (!AlibabaCloud.TeaUtil.Common.Empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Query = AlibabaCloud.TeaUtil.Common.StringifyMapValue(request.Filter.ToMap());
                    request_.Headers["authorization"] = AlibabaCloud.OSSUtil.Common.GetSignature(request_, "", accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders);
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (AlibabaCloud.TeaUtil.Common.Is4xx(response_.StatusCode) || AlibabaCloud.TeaUtil.Common.Is5xx(response_.StatusCode))
                    {
                        bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                        respMap = AlibabaCloud.OSSUtil.Common.GetErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", respMap.Get("Code")},
                            {"message", respMap.Get("Message")},
                            {"data", new Dictionary<string, object>
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap.Get("RequestId")},
                                {"hostId", respMap.Get("HostId")},
                            }},
                        });
                    }
                    bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                    respMap = AlibabaCloud.TeaXML.Client.ParseXml(bodyStr, typeof(GetServiceResponse));
                    return TeaModel.ToObject<GetServiceResponse>(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"ListAllMyBucketsResult", respMap.Get("ListAllMyBucketsResult")},
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

        public DeleteBucketEncryptionResponse DeleteBucketEncryption(DeleteBucketEncryptionRequest request, AlibabaCloud.OSSUtil.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
                {"timeouted", "retry"},
                {"readTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.LocalAddr, _localAddr)},
                {"httpProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accessKeyId = this._credential.GetAccessKeyId();
                    string accessKeySecret = this._credential.GetAccessKeySecret();
                    string token = this._credential.GetSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "DELETE";
                    request_.Pathname = "/?encryption";
                    request_.Headers = new Dictionary<string, string>
                    {
                        {"host", AlibabaCloud.OSSUtil.Common.GetHost(request.BucketName, _regionId, _endpoint, _hostModel)},
                        {"date", AlibabaCloud.TeaUtil.Common.GetDateUTCString()},
                        {"user-agent", GetUserAgent()},
                    };
                    if (!AlibabaCloud.TeaUtil.Common.Empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = AlibabaCloud.OSSUtil.Common.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (AlibabaCloud.TeaUtil.Common.Is4xx(response_.StatusCode) || AlibabaCloud.TeaUtil.Common.Is5xx(response_.StatusCode))
                    {
                        bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                        respMap = AlibabaCloud.OSSUtil.Common.GetErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", respMap.Get("Code")},
                            {"message", respMap.Get("Message")},
                            {"data", new Dictionary<string, object>
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap.Get("RequestId")},
                                {"hostId", respMap.Get("HostId")},
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

        public async Task<DeleteBucketEncryptionResponse> DeleteBucketEncryptionAsync(DeleteBucketEncryptionRequest request, AlibabaCloud.OSSUtil.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
                {"timeouted", "retry"},
                {"readTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.LocalAddr, _localAddr)},
                {"httpProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accessKeyId = await this._credential.GetAccessKeyIdAsync();
                    string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
                    string token = await this._credential.GetSecurityTokenAsync();
                    request_.Protocol = _protocol;
                    request_.Method = "DELETE";
                    request_.Pathname = "/?encryption";
                    request_.Headers = new Dictionary<string, string>
                    {
                        {"host", AlibabaCloud.OSSUtil.Common.GetHost(request.BucketName, _regionId, _endpoint, _hostModel)},
                        {"date", AlibabaCloud.TeaUtil.Common.GetDateUTCString()},
                        {"user-agent", GetUserAgent()},
                    };
                    if (!AlibabaCloud.TeaUtil.Common.Empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = AlibabaCloud.OSSUtil.Common.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders);
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (AlibabaCloud.TeaUtil.Common.Is4xx(response_.StatusCode) || AlibabaCloud.TeaUtil.Common.Is5xx(response_.StatusCode))
                    {
                        bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                        respMap = AlibabaCloud.OSSUtil.Common.GetErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", respMap.Get("Code")},
                            {"message", respMap.Get("Message")},
                            {"data", new Dictionary<string, object>
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap.Get("RequestId")},
                                {"hostId", respMap.Get("HostId")},
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

        public DeleteBucketTagsResponse DeleteBucketTags(DeleteBucketTagsRequest request, AlibabaCloud.OSSUtil.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
                {"timeouted", "retry"},
                {"readTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.LocalAddr, _localAddr)},
                {"httpProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accessKeyId = this._credential.GetAccessKeyId();
                    string accessKeySecret = this._credential.GetAccessKeySecret();
                    string token = this._credential.GetSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "DELETE";
                    request_.Pathname = "/";
                    request_.Headers = new Dictionary<string, string>
                    {
                        {"host", AlibabaCloud.OSSUtil.Common.GetHost(request.BucketName, _regionId, _endpoint, _hostModel)},
                        {"date", AlibabaCloud.TeaUtil.Common.GetDateUTCString()},
                        {"user-agent", GetUserAgent()},
                    };
                    if (!AlibabaCloud.TeaUtil.Common.Empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Query = AlibabaCloud.TeaUtil.Common.StringifyMapValue(request.Filter.ToMap());
                    request_.Headers["authorization"] = AlibabaCloud.OSSUtil.Common.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (AlibabaCloud.TeaUtil.Common.Is4xx(response_.StatusCode) || AlibabaCloud.TeaUtil.Common.Is5xx(response_.StatusCode))
                    {
                        bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                        respMap = AlibabaCloud.OSSUtil.Common.GetErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", respMap.Get("Code")},
                            {"message", respMap.Get("Message")},
                            {"data", new Dictionary<string, object>
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap.Get("RequestId")},
                                {"hostId", respMap.Get("HostId")},
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

        public async Task<DeleteBucketTagsResponse> DeleteBucketTagsAsync(DeleteBucketTagsRequest request, AlibabaCloud.OSSUtil.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
                {"timeouted", "retry"},
                {"readTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.LocalAddr, _localAddr)},
                {"httpProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accessKeyId = await this._credential.GetAccessKeyIdAsync();
                    string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
                    string token = await this._credential.GetSecurityTokenAsync();
                    request_.Protocol = _protocol;
                    request_.Method = "DELETE";
                    request_.Pathname = "/";
                    request_.Headers = new Dictionary<string, string>
                    {
                        {"host", AlibabaCloud.OSSUtil.Common.GetHost(request.BucketName, _regionId, _endpoint, _hostModel)},
                        {"date", AlibabaCloud.TeaUtil.Common.GetDateUTCString()},
                        {"user-agent", GetUserAgent()},
                    };
                    if (!AlibabaCloud.TeaUtil.Common.Empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Query = AlibabaCloud.TeaUtil.Common.StringifyMapValue(request.Filter.ToMap());
                    request_.Headers["authorization"] = AlibabaCloud.OSSUtil.Common.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders);
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (AlibabaCloud.TeaUtil.Common.Is4xx(response_.StatusCode) || AlibabaCloud.TeaUtil.Common.Is5xx(response_.StatusCode))
                    {
                        bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                        respMap = AlibabaCloud.OSSUtil.Common.GetErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", respMap.Get("Code")},
                            {"message", respMap.Get("Message")},
                            {"data", new Dictionary<string, object>
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap.Get("RequestId")},
                                {"hostId", respMap.Get("HostId")},
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

        public GetBucketWebsiteResponse GetBucketWebsite(GetBucketWebsiteRequest request, AlibabaCloud.OSSUtil.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
                {"timeouted", "retry"},
                {"readTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.LocalAddr, _localAddr)},
                {"httpProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accessKeyId = this._credential.GetAccessKeyId();
                    string accessKeySecret = this._credential.GetAccessKeySecret();
                    string token = this._credential.GetSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/?website";
                    request_.Headers = new Dictionary<string, string>
                    {
                        {"host", AlibabaCloud.OSSUtil.Common.GetHost(request.BucketName, _regionId, _endpoint, _hostModel)},
                        {"date", AlibabaCloud.TeaUtil.Common.GetDateUTCString()},
                        {"user-agent", GetUserAgent()},
                    };
                    if (!AlibabaCloud.TeaUtil.Common.Empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = AlibabaCloud.OSSUtil.Common.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (AlibabaCloud.TeaUtil.Common.Is4xx(response_.StatusCode) || AlibabaCloud.TeaUtil.Common.Is5xx(response_.StatusCode))
                    {
                        bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                        respMap = AlibabaCloud.OSSUtil.Common.GetErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", respMap.Get("Code")},
                            {"message", respMap.Get("Message")},
                            {"data", new Dictionary<string, object>
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap.Get("RequestId")},
                                {"hostId", respMap.Get("HostId")},
                            }},
                        });
                    }
                    bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                    respMap = AlibabaCloud.TeaXML.Client.ParseXml(bodyStr, typeof(GetBucketWebsiteResponse));
                    return TeaModel.ToObject<GetBucketWebsiteResponse>(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"WebsiteConfiguration", respMap.Get("WebsiteConfiguration")},
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

        public async Task<GetBucketWebsiteResponse> GetBucketWebsiteAsync(GetBucketWebsiteRequest request, AlibabaCloud.OSSUtil.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
                {"timeouted", "retry"},
                {"readTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.LocalAddr, _localAddr)},
                {"httpProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accessKeyId = await this._credential.GetAccessKeyIdAsync();
                    string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
                    string token = await this._credential.GetSecurityTokenAsync();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/?website";
                    request_.Headers = new Dictionary<string, string>
                    {
                        {"host", AlibabaCloud.OSSUtil.Common.GetHost(request.BucketName, _regionId, _endpoint, _hostModel)},
                        {"date", AlibabaCloud.TeaUtil.Common.GetDateUTCString()},
                        {"user-agent", GetUserAgent()},
                    };
                    if (!AlibabaCloud.TeaUtil.Common.Empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = AlibabaCloud.OSSUtil.Common.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders);
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (AlibabaCloud.TeaUtil.Common.Is4xx(response_.StatusCode) || AlibabaCloud.TeaUtil.Common.Is5xx(response_.StatusCode))
                    {
                        bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                        respMap = AlibabaCloud.OSSUtil.Common.GetErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", respMap.Get("Code")},
                            {"message", respMap.Get("Message")},
                            {"data", new Dictionary<string, object>
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap.Get("RequestId")},
                                {"hostId", respMap.Get("HostId")},
                            }},
                        });
                    }
                    bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                    respMap = AlibabaCloud.TeaXML.Client.ParseXml(bodyStr, typeof(GetBucketWebsiteResponse));
                    return TeaModel.ToObject<GetBucketWebsiteResponse>(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"WebsiteConfiguration", respMap.Get("WebsiteConfiguration")},
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

        public DeleteLiveChannelResponse DeleteLiveChannel(DeleteLiveChannelRequest request, AlibabaCloud.OSSUtil.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
                {"timeouted", "retry"},
                {"readTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.LocalAddr, _localAddr)},
                {"httpProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accessKeyId = this._credential.GetAccessKeyId();
                    string accessKeySecret = this._credential.GetAccessKeySecret();
                    string token = this._credential.GetSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "DELETE";
                    request_.Pathname = "/" + request.ChannelName + "?live";
                    request_.Headers = new Dictionary<string, string>
                    {
                        {"host", AlibabaCloud.OSSUtil.Common.GetHost(request.BucketName, _regionId, _endpoint, _hostModel)},
                        {"date", AlibabaCloud.TeaUtil.Common.GetDateUTCString()},
                        {"user-agent", GetUserAgent()},
                    };
                    if (!AlibabaCloud.TeaUtil.Common.Empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = AlibabaCloud.OSSUtil.Common.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (AlibabaCloud.TeaUtil.Common.Is4xx(response_.StatusCode) || AlibabaCloud.TeaUtil.Common.Is5xx(response_.StatusCode))
                    {
                        bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                        respMap = AlibabaCloud.OSSUtil.Common.GetErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", respMap.Get("Code")},
                            {"message", respMap.Get("Message")},
                            {"data", new Dictionary<string, object>
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap.Get("RequestId")},
                                {"hostId", respMap.Get("HostId")},
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

        public async Task<DeleteLiveChannelResponse> DeleteLiveChannelAsync(DeleteLiveChannelRequest request, AlibabaCloud.OSSUtil.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
                {"timeouted", "retry"},
                {"readTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.LocalAddr, _localAddr)},
                {"httpProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accessKeyId = await this._credential.GetAccessKeyIdAsync();
                    string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
                    string token = await this._credential.GetSecurityTokenAsync();
                    request_.Protocol = _protocol;
                    request_.Method = "DELETE";
                    request_.Pathname = "/" + request.ChannelName + "?live";
                    request_.Headers = new Dictionary<string, string>
                    {
                        {"host", AlibabaCloud.OSSUtil.Common.GetHost(request.BucketName, _regionId, _endpoint, _hostModel)},
                        {"date", AlibabaCloud.TeaUtil.Common.GetDateUTCString()},
                        {"user-agent", GetUserAgent()},
                    };
                    if (!AlibabaCloud.TeaUtil.Common.Empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = AlibabaCloud.OSSUtil.Common.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders);
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (AlibabaCloud.TeaUtil.Common.Is4xx(response_.StatusCode) || AlibabaCloud.TeaUtil.Common.Is5xx(response_.StatusCode))
                    {
                        bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                        respMap = AlibabaCloud.OSSUtil.Common.GetErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", respMap.Get("Code")},
                            {"message", respMap.Get("Message")},
                            {"data", new Dictionary<string, object>
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap.Get("RequestId")},
                                {"hostId", respMap.Get("HostId")},
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

        public GetBucketLocationResponse GetBucketLocation(GetBucketLocationRequest request, AlibabaCloud.OSSUtil.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
                {"timeouted", "retry"},
                {"readTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.LocalAddr, _localAddr)},
                {"httpProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accessKeyId = this._credential.GetAccessKeyId();
                    string accessKeySecret = this._credential.GetAccessKeySecret();
                    string token = this._credential.GetSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/?location";
                    request_.Headers = new Dictionary<string, string>
                    {
                        {"host", AlibabaCloud.OSSUtil.Common.GetHost(request.BucketName, _regionId, _endpoint, _hostModel)},
                        {"date", AlibabaCloud.TeaUtil.Common.GetDateUTCString()},
                        {"user-agent", GetUserAgent()},
                    };
                    if (!AlibabaCloud.TeaUtil.Common.Empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = AlibabaCloud.OSSUtil.Common.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (AlibabaCloud.TeaUtil.Common.Is4xx(response_.StatusCode) || AlibabaCloud.TeaUtil.Common.Is5xx(response_.StatusCode))
                    {
                        bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                        respMap = AlibabaCloud.OSSUtil.Common.GetErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", respMap.Get("Code")},
                            {"message", respMap.Get("Message")},
                            {"data", new Dictionary<string, object>
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap.Get("RequestId")},
                                {"hostId", respMap.Get("HostId")},
                            }},
                        });
                    }
                    bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                    respMap = AlibabaCloud.TeaXML.Client.ParseXml(bodyStr, typeof(GetBucketLocationResponse));
                    return TeaModel.ToObject<GetBucketLocationResponse>(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"LocationConstraint", respMap.Get("LocationConstraint")},
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

        public async Task<GetBucketLocationResponse> GetBucketLocationAsync(GetBucketLocationRequest request, AlibabaCloud.OSSUtil.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
                {"timeouted", "retry"},
                {"readTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.LocalAddr, _localAddr)},
                {"httpProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accessKeyId = await this._credential.GetAccessKeyIdAsync();
                    string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
                    string token = await this._credential.GetSecurityTokenAsync();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/?location";
                    request_.Headers = new Dictionary<string, string>
                    {
                        {"host", AlibabaCloud.OSSUtil.Common.GetHost(request.BucketName, _regionId, _endpoint, _hostModel)},
                        {"date", AlibabaCloud.TeaUtil.Common.GetDateUTCString()},
                        {"user-agent", GetUserAgent()},
                    };
                    if (!AlibabaCloud.TeaUtil.Common.Empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = AlibabaCloud.OSSUtil.Common.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders);
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (AlibabaCloud.TeaUtil.Common.Is4xx(response_.StatusCode) || AlibabaCloud.TeaUtil.Common.Is5xx(response_.StatusCode))
                    {
                        bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                        respMap = AlibabaCloud.OSSUtil.Common.GetErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", respMap.Get("Code")},
                            {"message", respMap.Get("Message")},
                            {"data", new Dictionary<string, object>
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap.Get("RequestId")},
                                {"hostId", respMap.Get("HostId")},
                            }},
                        });
                    }
                    bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                    respMap = AlibabaCloud.TeaXML.Client.ParseXml(bodyStr, typeof(GetBucketLocationResponse));
                    return TeaModel.ToObject<GetBucketLocationResponse>(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"LocationConstraint", respMap.Get("LocationConstraint")},
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

        public ListLiveChannelResponse ListLiveChannel(ListLiveChannelRequest request, AlibabaCloud.OSSUtil.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
                {"timeouted", "retry"},
                {"readTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.LocalAddr, _localAddr)},
                {"httpProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accessKeyId = this._credential.GetAccessKeyId();
                    string accessKeySecret = this._credential.GetAccessKeySecret();
                    string token = this._credential.GetSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/?live";
                    request_.Headers = new Dictionary<string, string>
                    {
                        {"host", AlibabaCloud.OSSUtil.Common.GetHost(request.BucketName, _regionId, _endpoint, _hostModel)},
                        {"date", AlibabaCloud.TeaUtil.Common.GetDateUTCString()},
                        {"user-agent", GetUserAgent()},
                    };
                    if (!AlibabaCloud.TeaUtil.Common.Empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Query = AlibabaCloud.TeaUtil.Common.StringifyMapValue(request.Filter.ToMap());
                    request_.Headers["authorization"] = AlibabaCloud.OSSUtil.Common.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (AlibabaCloud.TeaUtil.Common.Is4xx(response_.StatusCode) || AlibabaCloud.TeaUtil.Common.Is5xx(response_.StatusCode))
                    {
                        bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                        respMap = AlibabaCloud.OSSUtil.Common.GetErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", respMap.Get("Code")},
                            {"message", respMap.Get("Message")},
                            {"data", new Dictionary<string, object>
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap.Get("RequestId")},
                                {"hostId", respMap.Get("HostId")},
                            }},
                        });
                    }
                    bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                    respMap = AlibabaCloud.TeaXML.Client.ParseXml(bodyStr, typeof(ListLiveChannelResponse));
                    return TeaModel.ToObject<ListLiveChannelResponse>(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"ListLiveChannelResult", respMap.Get("ListLiveChannelResult")},
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

        public async Task<ListLiveChannelResponse> ListLiveChannelAsync(ListLiveChannelRequest request, AlibabaCloud.OSSUtil.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
                {"timeouted", "retry"},
                {"readTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.LocalAddr, _localAddr)},
                {"httpProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accessKeyId = await this._credential.GetAccessKeyIdAsync();
                    string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
                    string token = await this._credential.GetSecurityTokenAsync();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/?live";
                    request_.Headers = new Dictionary<string, string>
                    {
                        {"host", AlibabaCloud.OSSUtil.Common.GetHost(request.BucketName, _regionId, _endpoint, _hostModel)},
                        {"date", AlibabaCloud.TeaUtil.Common.GetDateUTCString()},
                        {"user-agent", GetUserAgent()},
                    };
                    if (!AlibabaCloud.TeaUtil.Common.Empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Query = AlibabaCloud.TeaUtil.Common.StringifyMapValue(request.Filter.ToMap());
                    request_.Headers["authorization"] = AlibabaCloud.OSSUtil.Common.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders);
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (AlibabaCloud.TeaUtil.Common.Is4xx(response_.StatusCode) || AlibabaCloud.TeaUtil.Common.Is5xx(response_.StatusCode))
                    {
                        bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                        respMap = AlibabaCloud.OSSUtil.Common.GetErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", respMap.Get("Code")},
                            {"message", respMap.Get("Message")},
                            {"data", new Dictionary<string, object>
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap.Get("RequestId")},
                                {"hostId", respMap.Get("HostId")},
                            }},
                        });
                    }
                    bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                    respMap = AlibabaCloud.TeaXML.Client.ParseXml(bodyStr, typeof(ListLiveChannelResponse));
                    return TeaModel.ToObject<ListLiveChannelResponse>(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"ListLiveChannelResult", respMap.Get("ListLiveChannelResult")},
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

        public GetObjectMetaResponse GetObjectMeta(GetObjectMetaRequest request, AlibabaCloud.OSSUtil.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
                {"timeouted", "retry"},
                {"readTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.LocalAddr, _localAddr)},
                {"httpProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accessKeyId = this._credential.GetAccessKeyId();
                    string accessKeySecret = this._credential.GetAccessKeySecret();
                    string token = this._credential.GetSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "HEAD";
                    request_.Pathname = "/" + request.ObjectName + "?objectMeta";
                    request_.Headers = new Dictionary<string, string>
                    {
                        {"host", AlibabaCloud.OSSUtil.Common.GetHost(request.BucketName, _regionId, _endpoint, _hostModel)},
                        {"date", AlibabaCloud.TeaUtil.Common.GetDateUTCString()},
                        {"user-agent", GetUserAgent()},
                    };
                    if (!AlibabaCloud.TeaUtil.Common.Empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = AlibabaCloud.OSSUtil.Common.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (AlibabaCloud.TeaUtil.Common.Is4xx(response_.StatusCode) || AlibabaCloud.TeaUtil.Common.Is5xx(response_.StatusCode))
                    {
                        bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                        respMap = AlibabaCloud.OSSUtil.Common.GetErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", respMap.Get("Code")},
                            {"message", respMap.Get("Message")},
                            {"data", new Dictionary<string, object>
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap.Get("RequestId")},
                                {"hostId", respMap.Get("HostId")},
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

        public async Task<GetObjectMetaResponse> GetObjectMetaAsync(GetObjectMetaRequest request, AlibabaCloud.OSSUtil.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
                {"timeouted", "retry"},
                {"readTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.LocalAddr, _localAddr)},
                {"httpProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accessKeyId = await this._credential.GetAccessKeyIdAsync();
                    string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
                    string token = await this._credential.GetSecurityTokenAsync();
                    request_.Protocol = _protocol;
                    request_.Method = "HEAD";
                    request_.Pathname = "/" + request.ObjectName + "?objectMeta";
                    request_.Headers = new Dictionary<string, string>
                    {
                        {"host", AlibabaCloud.OSSUtil.Common.GetHost(request.BucketName, _regionId, _endpoint, _hostModel)},
                        {"date", AlibabaCloud.TeaUtil.Common.GetDateUTCString()},
                        {"user-agent", GetUserAgent()},
                    };
                    if (!AlibabaCloud.TeaUtil.Common.Empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = AlibabaCloud.OSSUtil.Common.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders);
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (AlibabaCloud.TeaUtil.Common.Is4xx(response_.StatusCode) || AlibabaCloud.TeaUtil.Common.Is5xx(response_.StatusCode))
                    {
                        bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                        respMap = AlibabaCloud.OSSUtil.Common.GetErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", respMap.Get("Code")},
                            {"message", respMap.Get("Message")},
                            {"data", new Dictionary<string, object>
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap.Get("RequestId")},
                                {"hostId", respMap.Get("HostId")},
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

        public GetBucketAclResponse GetBucketAcl(GetBucketAclRequest request, AlibabaCloud.OSSUtil.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
                {"timeouted", "retry"},
                {"readTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.LocalAddr, _localAddr)},
                {"httpProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accessKeyId = this._credential.GetAccessKeyId();
                    string accessKeySecret = this._credential.GetAccessKeySecret();
                    string token = this._credential.GetSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/?acl";
                    request_.Headers = new Dictionary<string, string>
                    {
                        {"host", AlibabaCloud.OSSUtil.Common.GetHost(request.BucketName, _regionId, _endpoint, _hostModel)},
                        {"date", AlibabaCloud.TeaUtil.Common.GetDateUTCString()},
                        {"user-agent", GetUserAgent()},
                    };
                    if (!AlibabaCloud.TeaUtil.Common.Empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = AlibabaCloud.OSSUtil.Common.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (AlibabaCloud.TeaUtil.Common.Is4xx(response_.StatusCode) || AlibabaCloud.TeaUtil.Common.Is5xx(response_.StatusCode))
                    {
                        bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                        respMap = AlibabaCloud.OSSUtil.Common.GetErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", respMap.Get("Code")},
                            {"message", respMap.Get("Message")},
                            {"data", new Dictionary<string, object>
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap.Get("RequestId")},
                                {"hostId", respMap.Get("HostId")},
                            }},
                        });
                    }
                    bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                    respMap = AlibabaCloud.TeaXML.Client.ParseXml(bodyStr, typeof(GetBucketAclResponse));
                    return TeaModel.ToObject<GetBucketAclResponse>(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"AccessControlPolicy", respMap.Get("AccessControlPolicy")},
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

        public async Task<GetBucketAclResponse> GetBucketAclAsync(GetBucketAclRequest request, AlibabaCloud.OSSUtil.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
                {"timeouted", "retry"},
                {"readTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.LocalAddr, _localAddr)},
                {"httpProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accessKeyId = await this._credential.GetAccessKeyIdAsync();
                    string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
                    string token = await this._credential.GetSecurityTokenAsync();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/?acl";
                    request_.Headers = new Dictionary<string, string>
                    {
                        {"host", AlibabaCloud.OSSUtil.Common.GetHost(request.BucketName, _regionId, _endpoint, _hostModel)},
                        {"date", AlibabaCloud.TeaUtil.Common.GetDateUTCString()},
                        {"user-agent", GetUserAgent()},
                    };
                    if (!AlibabaCloud.TeaUtil.Common.Empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = AlibabaCloud.OSSUtil.Common.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders);
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (AlibabaCloud.TeaUtil.Common.Is4xx(response_.StatusCode) || AlibabaCloud.TeaUtil.Common.Is5xx(response_.StatusCode))
                    {
                        bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                        respMap = AlibabaCloud.OSSUtil.Common.GetErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", respMap.Get("Code")},
                            {"message", respMap.Get("Message")},
                            {"data", new Dictionary<string, object>
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap.Get("RequestId")},
                                {"hostId", respMap.Get("HostId")},
                            }},
                        });
                    }
                    bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                    respMap = AlibabaCloud.TeaXML.Client.ParseXml(bodyStr, typeof(GetBucketAclResponse));
                    return TeaModel.ToObject<GetBucketAclResponse>(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"AccessControlPolicy", respMap.Get("AccessControlPolicy")},
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

        public ListPartsResponse ListParts(ListPartsRequest request, AlibabaCloud.OSSUtil.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
                {"timeouted", "retry"},
                {"readTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.LocalAddr, _localAddr)},
                {"httpProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accessKeyId = this._credential.GetAccessKeyId();
                    string accessKeySecret = this._credential.GetAccessKeySecret();
                    string token = this._credential.GetSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/" + request.ObjectName;
                    request_.Headers = new Dictionary<string, string>
                    {
                        {"host", AlibabaCloud.OSSUtil.Common.GetHost(request.BucketName, _regionId, _endpoint, _hostModel)},
                        {"date", AlibabaCloud.TeaUtil.Common.GetDateUTCString()},
                        {"user-agent", GetUserAgent()},
                    };
                    if (!AlibabaCloud.TeaUtil.Common.Empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Query = AlibabaCloud.TeaUtil.Common.StringifyMapValue(request.Filter.ToMap());
                    request_.Headers["authorization"] = AlibabaCloud.OSSUtil.Common.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (AlibabaCloud.TeaUtil.Common.Is4xx(response_.StatusCode) || AlibabaCloud.TeaUtil.Common.Is5xx(response_.StatusCode))
                    {
                        bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                        respMap = AlibabaCloud.OSSUtil.Common.GetErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", respMap.Get("Code")},
                            {"message", respMap.Get("Message")},
                            {"data", new Dictionary<string, object>
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap.Get("RequestId")},
                                {"hostId", respMap.Get("HostId")},
                            }},
                        });
                    }
                    bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                    respMap = AlibabaCloud.TeaXML.Client.ParseXml(bodyStr, typeof(ListPartsResponse));
                    return TeaModel.ToObject<ListPartsResponse>(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"ListPartsResult", respMap.Get("ListPartsResult")},
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

        public async Task<ListPartsResponse> ListPartsAsync(ListPartsRequest request, AlibabaCloud.OSSUtil.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
                {"timeouted", "retry"},
                {"readTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.LocalAddr, _localAddr)},
                {"httpProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accessKeyId = await this._credential.GetAccessKeyIdAsync();
                    string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
                    string token = await this._credential.GetSecurityTokenAsync();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/" + request.ObjectName;
                    request_.Headers = new Dictionary<string, string>
                    {
                        {"host", AlibabaCloud.OSSUtil.Common.GetHost(request.BucketName, _regionId, _endpoint, _hostModel)},
                        {"date", AlibabaCloud.TeaUtil.Common.GetDateUTCString()},
                        {"user-agent", GetUserAgent()},
                    };
                    if (!AlibabaCloud.TeaUtil.Common.Empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Query = AlibabaCloud.TeaUtil.Common.StringifyMapValue(request.Filter.ToMap());
                    request_.Headers["authorization"] = AlibabaCloud.OSSUtil.Common.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders);
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (AlibabaCloud.TeaUtil.Common.Is4xx(response_.StatusCode) || AlibabaCloud.TeaUtil.Common.Is5xx(response_.StatusCode))
                    {
                        bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                        respMap = AlibabaCloud.OSSUtil.Common.GetErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", respMap.Get("Code")},
                            {"message", respMap.Get("Message")},
                            {"data", new Dictionary<string, object>
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap.Get("RequestId")},
                                {"hostId", respMap.Get("HostId")},
                            }},
                        });
                    }
                    bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                    respMap = AlibabaCloud.TeaXML.Client.ParseXml(bodyStr, typeof(ListPartsResponse));
                    return TeaModel.ToObject<ListPartsResponse>(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"ListPartsResult", respMap.Get("ListPartsResult")},
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

        public GetLiveChannelHistoryResponse GetLiveChannelHistory(GetLiveChannelHistoryRequest request, AlibabaCloud.OSSUtil.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
                {"timeouted", "retry"},
                {"readTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.LocalAddr, _localAddr)},
                {"httpProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accessKeyId = this._credential.GetAccessKeyId();
                    string accessKeySecret = this._credential.GetAccessKeySecret();
                    string token = this._credential.GetSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/" + request.ChannelName + "?live";
                    request_.Headers = new Dictionary<string, string>
                    {
                        {"host", AlibabaCloud.OSSUtil.Common.GetHost(request.BucketName, _regionId, _endpoint, _hostModel)},
                        {"date", AlibabaCloud.TeaUtil.Common.GetDateUTCString()},
                        {"user-agent", GetUserAgent()},
                    };
                    if (!AlibabaCloud.TeaUtil.Common.Empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Query = AlibabaCloud.TeaUtil.Common.StringifyMapValue(request.Filter.ToMap());
                    request_.Headers["authorization"] = AlibabaCloud.OSSUtil.Common.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (AlibabaCloud.TeaUtil.Common.Is4xx(response_.StatusCode) || AlibabaCloud.TeaUtil.Common.Is5xx(response_.StatusCode))
                    {
                        bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                        respMap = AlibabaCloud.OSSUtil.Common.GetErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", respMap.Get("Code")},
                            {"message", respMap.Get("Message")},
                            {"data", new Dictionary<string, object>
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap.Get("RequestId")},
                                {"hostId", respMap.Get("HostId")},
                            }},
                        });
                    }
                    bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                    respMap = AlibabaCloud.TeaXML.Client.ParseXml(bodyStr, typeof(GetLiveChannelHistoryResponse));
                    return TeaModel.ToObject<GetLiveChannelHistoryResponse>(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"LiveChannelHistory", respMap.Get("LiveChannelHistory")},
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

        public async Task<GetLiveChannelHistoryResponse> GetLiveChannelHistoryAsync(GetLiveChannelHistoryRequest request, AlibabaCloud.OSSUtil.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
                {"timeouted", "retry"},
                {"readTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.LocalAddr, _localAddr)},
                {"httpProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accessKeyId = await this._credential.GetAccessKeyIdAsync();
                    string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
                    string token = await this._credential.GetSecurityTokenAsync();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/" + request.ChannelName + "?live";
                    request_.Headers = new Dictionary<string, string>
                    {
                        {"host", AlibabaCloud.OSSUtil.Common.GetHost(request.BucketName, _regionId, _endpoint, _hostModel)},
                        {"date", AlibabaCloud.TeaUtil.Common.GetDateUTCString()},
                        {"user-agent", GetUserAgent()},
                    };
                    if (!AlibabaCloud.TeaUtil.Common.Empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Query = AlibabaCloud.TeaUtil.Common.StringifyMapValue(request.Filter.ToMap());
                    request_.Headers["authorization"] = AlibabaCloud.OSSUtil.Common.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders);
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (AlibabaCloud.TeaUtil.Common.Is4xx(response_.StatusCode) || AlibabaCloud.TeaUtil.Common.Is5xx(response_.StatusCode))
                    {
                        bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                        respMap = AlibabaCloud.OSSUtil.Common.GetErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", respMap.Get("Code")},
                            {"message", respMap.Get("Message")},
                            {"data", new Dictionary<string, object>
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap.Get("RequestId")},
                                {"hostId", respMap.Get("HostId")},
                            }},
                        });
                    }
                    bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                    respMap = AlibabaCloud.TeaXML.Client.ParseXml(bodyStr, typeof(GetLiveChannelHistoryResponse));
                    return TeaModel.ToObject<GetLiveChannelHistoryResponse>(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"LiveChannelHistory", respMap.Get("LiveChannelHistory")},
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

        public GetBucketResponse GetBucket(GetBucketRequest request, AlibabaCloud.OSSUtil.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
                {"timeouted", "retry"},
                {"readTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.LocalAddr, _localAddr)},
                {"httpProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accessKeyId = this._credential.GetAccessKeyId();
                    string accessKeySecret = this._credential.GetAccessKeySecret();
                    string token = this._credential.GetSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/";
                    request_.Headers = new Dictionary<string, string>
                    {
                        {"host", AlibabaCloud.OSSUtil.Common.GetHost(request.BucketName, _regionId, _endpoint, _hostModel)},
                        {"date", AlibabaCloud.TeaUtil.Common.GetDateUTCString()},
                        {"user-agent", GetUserAgent()},
                    };
                    if (!AlibabaCloud.TeaUtil.Common.Empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Query = AlibabaCloud.TeaUtil.Common.StringifyMapValue(request.Filter.ToMap());
                    request_.Headers["authorization"] = AlibabaCloud.OSSUtil.Common.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (AlibabaCloud.TeaUtil.Common.Is4xx(response_.StatusCode) || AlibabaCloud.TeaUtil.Common.Is5xx(response_.StatusCode))
                    {
                        bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                        respMap = AlibabaCloud.OSSUtil.Common.GetErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", respMap.Get("Code")},
                            {"message", respMap.Get("Message")},
                            {"data", new Dictionary<string, object>
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap.Get("RequestId")},
                                {"hostId", respMap.Get("HostId")},
                            }},
                        });
                    }
                    bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                    respMap = AlibabaCloud.TeaXML.Client.ParseXml(bodyStr, typeof(GetBucketResponse));
                    return TeaModel.ToObject<GetBucketResponse>(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"ListBucketResult", respMap.Get("ListBucketResult")},
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

        public async Task<GetBucketResponse> GetBucketAsync(GetBucketRequest request, AlibabaCloud.OSSUtil.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
                {"timeouted", "retry"},
                {"readTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.LocalAddr, _localAddr)},
                {"httpProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accessKeyId = await this._credential.GetAccessKeyIdAsync();
                    string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
                    string token = await this._credential.GetSecurityTokenAsync();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/";
                    request_.Headers = new Dictionary<string, string>
                    {
                        {"host", AlibabaCloud.OSSUtil.Common.GetHost(request.BucketName, _regionId, _endpoint, _hostModel)},
                        {"date", AlibabaCloud.TeaUtil.Common.GetDateUTCString()},
                        {"user-agent", GetUserAgent()},
                    };
                    if (!AlibabaCloud.TeaUtil.Common.Empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Query = AlibabaCloud.TeaUtil.Common.StringifyMapValue(request.Filter.ToMap());
                    request_.Headers["authorization"] = AlibabaCloud.OSSUtil.Common.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders);
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (AlibabaCloud.TeaUtil.Common.Is4xx(response_.StatusCode) || AlibabaCloud.TeaUtil.Common.Is5xx(response_.StatusCode))
                    {
                        bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                        respMap = AlibabaCloud.OSSUtil.Common.GetErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", respMap.Get("Code")},
                            {"message", respMap.Get("Message")},
                            {"data", new Dictionary<string, object>
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap.Get("RequestId")},
                                {"hostId", respMap.Get("HostId")},
                            }},
                        });
                    }
                    bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                    respMap = AlibabaCloud.TeaXML.Client.ParseXml(bodyStr, typeof(GetBucketResponse));
                    return TeaModel.ToObject<GetBucketResponse>(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"ListBucketResult", respMap.Get("ListBucketResult")},
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

        public GetLiveChannelInfoResponse GetLiveChannelInfo(GetLiveChannelInfoRequest request, AlibabaCloud.OSSUtil.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
                {"timeouted", "retry"},
                {"readTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.LocalAddr, _localAddr)},
                {"httpProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accessKeyId = this._credential.GetAccessKeyId();
                    string accessKeySecret = this._credential.GetAccessKeySecret();
                    string token = this._credential.GetSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/" + request.ChannelName + "?live";
                    request_.Headers = new Dictionary<string, string>
                    {
                        {"host", AlibabaCloud.OSSUtil.Common.GetHost(request.BucketName, _regionId, _endpoint, _hostModel)},
                        {"date", AlibabaCloud.TeaUtil.Common.GetDateUTCString()},
                        {"user-agent", GetUserAgent()},
                    };
                    if (!AlibabaCloud.TeaUtil.Common.Empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = AlibabaCloud.OSSUtil.Common.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (AlibabaCloud.TeaUtil.Common.Is4xx(response_.StatusCode) || AlibabaCloud.TeaUtil.Common.Is5xx(response_.StatusCode))
                    {
                        bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                        respMap = AlibabaCloud.OSSUtil.Common.GetErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", respMap.Get("Code")},
                            {"message", respMap.Get("Message")},
                            {"data", new Dictionary<string, object>
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap.Get("RequestId")},
                                {"hostId", respMap.Get("HostId")},
                            }},
                        });
                    }
                    bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                    respMap = AlibabaCloud.TeaXML.Client.ParseXml(bodyStr, typeof(GetLiveChannelInfoResponse));
                    return TeaModel.ToObject<GetLiveChannelInfoResponse>(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"LiveChannelConfiguration", respMap.Get("LiveChannelConfiguration")},
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

        public async Task<GetLiveChannelInfoResponse> GetLiveChannelInfoAsync(GetLiveChannelInfoRequest request, AlibabaCloud.OSSUtil.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
                {"timeouted", "retry"},
                {"readTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.LocalAddr, _localAddr)},
                {"httpProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accessKeyId = await this._credential.GetAccessKeyIdAsync();
                    string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
                    string token = await this._credential.GetSecurityTokenAsync();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/" + request.ChannelName + "?live";
                    request_.Headers = new Dictionary<string, string>
                    {
                        {"host", AlibabaCloud.OSSUtil.Common.GetHost(request.BucketName, _regionId, _endpoint, _hostModel)},
                        {"date", AlibabaCloud.TeaUtil.Common.GetDateUTCString()},
                        {"user-agent", GetUserAgent()},
                    };
                    if (!AlibabaCloud.TeaUtil.Common.Empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = AlibabaCloud.OSSUtil.Common.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders);
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (AlibabaCloud.TeaUtil.Common.Is4xx(response_.StatusCode) || AlibabaCloud.TeaUtil.Common.Is5xx(response_.StatusCode))
                    {
                        bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                        respMap = AlibabaCloud.OSSUtil.Common.GetErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", respMap.Get("Code")},
                            {"message", respMap.Get("Message")},
                            {"data", new Dictionary<string, object>
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap.Get("RequestId")},
                                {"hostId", respMap.Get("HostId")},
                            }},
                        });
                    }
                    bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                    respMap = AlibabaCloud.TeaXML.Client.ParseXml(bodyStr, typeof(GetLiveChannelInfoResponse));
                    return TeaModel.ToObject<GetLiveChannelInfoResponse>(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"LiveChannelConfiguration", respMap.Get("LiveChannelConfiguration")},
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

        public GetLiveChannelStatResponse GetLiveChannelStat(GetLiveChannelStatRequest request, AlibabaCloud.OSSUtil.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
                {"timeouted", "retry"},
                {"readTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.LocalAddr, _localAddr)},
                {"httpProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accessKeyId = this._credential.GetAccessKeyId();
                    string accessKeySecret = this._credential.GetAccessKeySecret();
                    string token = this._credential.GetSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/" + request.ChannelName + "?live";
                    request_.Headers = new Dictionary<string, string>
                    {
                        {"host", AlibabaCloud.OSSUtil.Common.GetHost(request.BucketName, _regionId, _endpoint, _hostModel)},
                        {"date", AlibabaCloud.TeaUtil.Common.GetDateUTCString()},
                        {"user-agent", GetUserAgent()},
                    };
                    if (!AlibabaCloud.TeaUtil.Common.Empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Query = AlibabaCloud.TeaUtil.Common.StringifyMapValue(request.Filter.ToMap());
                    request_.Headers["authorization"] = AlibabaCloud.OSSUtil.Common.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (AlibabaCloud.TeaUtil.Common.Is4xx(response_.StatusCode) || AlibabaCloud.TeaUtil.Common.Is5xx(response_.StatusCode))
                    {
                        bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                        respMap = AlibabaCloud.OSSUtil.Common.GetErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", respMap.Get("Code")},
                            {"message", respMap.Get("Message")},
                            {"data", new Dictionary<string, object>
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap.Get("RequestId")},
                                {"hostId", respMap.Get("HostId")},
                            }},
                        });
                    }
                    bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                    respMap = AlibabaCloud.TeaXML.Client.ParseXml(bodyStr, typeof(GetLiveChannelStatResponse));
                    return TeaModel.ToObject<GetLiveChannelStatResponse>(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"LiveChannelStat", respMap.Get("LiveChannelStat")},
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

        public async Task<GetLiveChannelStatResponse> GetLiveChannelStatAsync(GetLiveChannelStatRequest request, AlibabaCloud.OSSUtil.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
                {"timeouted", "retry"},
                {"readTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.LocalAddr, _localAddr)},
                {"httpProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accessKeyId = await this._credential.GetAccessKeyIdAsync();
                    string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
                    string token = await this._credential.GetSecurityTokenAsync();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/" + request.ChannelName + "?live";
                    request_.Headers = new Dictionary<string, string>
                    {
                        {"host", AlibabaCloud.OSSUtil.Common.GetHost(request.BucketName, _regionId, _endpoint, _hostModel)},
                        {"date", AlibabaCloud.TeaUtil.Common.GetDateUTCString()},
                        {"user-agent", GetUserAgent()},
                    };
                    if (!AlibabaCloud.TeaUtil.Common.Empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Query = AlibabaCloud.TeaUtil.Common.StringifyMapValue(request.Filter.ToMap());
                    request_.Headers["authorization"] = AlibabaCloud.OSSUtil.Common.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders);
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (AlibabaCloud.TeaUtil.Common.Is4xx(response_.StatusCode) || AlibabaCloud.TeaUtil.Common.Is5xx(response_.StatusCode))
                    {
                        bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                        respMap = AlibabaCloud.OSSUtil.Common.GetErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", respMap.Get("Code")},
                            {"message", respMap.Get("Message")},
                            {"data", new Dictionary<string, object>
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap.Get("RequestId")},
                                {"hostId", respMap.Get("HostId")},
                            }},
                        });
                    }
                    bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                    respMap = AlibabaCloud.TeaXML.Client.ParseXml(bodyStr, typeof(GetLiveChannelStatResponse));
                    return TeaModel.ToObject<GetLiveChannelStatResponse>(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"LiveChannelStat", respMap.Get("LiveChannelStat")},
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

        public DeleteObjectResponse DeleteObject(DeleteObjectRequest request, AlibabaCloud.OSSUtil.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
                {"timeouted", "retry"},
                {"readTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.LocalAddr, _localAddr)},
                {"httpProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accessKeyId = this._credential.GetAccessKeyId();
                    string accessKeySecret = this._credential.GetAccessKeySecret();
                    string token = this._credential.GetSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "DELETE";
                    request_.Pathname = "/" + request.ObjectName;
                    request_.Headers = new Dictionary<string, string>
                    {
                        {"host", AlibabaCloud.OSSUtil.Common.GetHost(request.BucketName, _regionId, _endpoint, _hostModel)},
                        {"date", AlibabaCloud.TeaUtil.Common.GetDateUTCString()},
                        {"user-agent", GetUserAgent()},
                    };
                    if (!AlibabaCloud.TeaUtil.Common.Empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = AlibabaCloud.OSSUtil.Common.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (AlibabaCloud.TeaUtil.Common.Is4xx(response_.StatusCode) || AlibabaCloud.TeaUtil.Common.Is5xx(response_.StatusCode))
                    {
                        bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                        respMap = AlibabaCloud.OSSUtil.Common.GetErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", respMap.Get("Code")},
                            {"message", respMap.Get("Message")},
                            {"data", new Dictionary<string, object>
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap.Get("RequestId")},
                                {"hostId", respMap.Get("HostId")},
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

        public async Task<DeleteObjectResponse> DeleteObjectAsync(DeleteObjectRequest request, AlibabaCloud.OSSUtil.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
                {"timeouted", "retry"},
                {"readTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.LocalAddr, _localAddr)},
                {"httpProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accessKeyId = await this._credential.GetAccessKeyIdAsync();
                    string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
                    string token = await this._credential.GetSecurityTokenAsync();
                    request_.Protocol = _protocol;
                    request_.Method = "DELETE";
                    request_.Pathname = "/" + request.ObjectName;
                    request_.Headers = new Dictionary<string, string>
                    {
                        {"host", AlibabaCloud.OSSUtil.Common.GetHost(request.BucketName, _regionId, _endpoint, _hostModel)},
                        {"date", AlibabaCloud.TeaUtil.Common.GetDateUTCString()},
                        {"user-agent", GetUserAgent()},
                    };
                    if (!AlibabaCloud.TeaUtil.Common.Empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = AlibabaCloud.OSSUtil.Common.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders);
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (AlibabaCloud.TeaUtil.Common.Is4xx(response_.StatusCode) || AlibabaCloud.TeaUtil.Common.Is5xx(response_.StatusCode))
                    {
                        bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                        respMap = AlibabaCloud.OSSUtil.Common.GetErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", respMap.Get("Code")},
                            {"message", respMap.Get("Message")},
                            {"data", new Dictionary<string, object>
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap.Get("RequestId")},
                                {"hostId", respMap.Get("HostId")},
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

        public AbortMultipartUploadResponse AbortMultipartUpload(AbortMultipartUploadRequest request, AlibabaCloud.OSSUtil.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
                {"timeouted", "retry"},
                {"readTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.LocalAddr, _localAddr)},
                {"httpProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accessKeyId = this._credential.GetAccessKeyId();
                    string accessKeySecret = this._credential.GetAccessKeySecret();
                    string token = this._credential.GetSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "DELETE";
                    request_.Pathname = "/" + request.ObjectName;
                    request_.Headers = new Dictionary<string, string>
                    {
                        {"host", AlibabaCloud.OSSUtil.Common.GetHost(request.BucketName, _regionId, _endpoint, _hostModel)},
                        {"date", AlibabaCloud.TeaUtil.Common.GetDateUTCString()},
                        {"user-agent", GetUserAgent()},
                    };
                    if (!AlibabaCloud.TeaUtil.Common.Empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Query = AlibabaCloud.TeaUtil.Common.StringifyMapValue(request.Filter.ToMap());
                    request_.Headers["authorization"] = AlibabaCloud.OSSUtil.Common.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (AlibabaCloud.TeaUtil.Common.Is4xx(response_.StatusCode) || AlibabaCloud.TeaUtil.Common.Is5xx(response_.StatusCode))
                    {
                        bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                        respMap = AlibabaCloud.OSSUtil.Common.GetErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", respMap.Get("Code")},
                            {"message", respMap.Get("Message")},
                            {"data", new Dictionary<string, object>
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap.Get("RequestId")},
                                {"hostId", respMap.Get("HostId")},
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

        public async Task<AbortMultipartUploadResponse> AbortMultipartUploadAsync(AbortMultipartUploadRequest request, AlibabaCloud.OSSUtil.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
                {"timeouted", "retry"},
                {"readTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.LocalAddr, _localAddr)},
                {"httpProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accessKeyId = await this._credential.GetAccessKeyIdAsync();
                    string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
                    string token = await this._credential.GetSecurityTokenAsync();
                    request_.Protocol = _protocol;
                    request_.Method = "DELETE";
                    request_.Pathname = "/" + request.ObjectName;
                    request_.Headers = new Dictionary<string, string>
                    {
                        {"host", AlibabaCloud.OSSUtil.Common.GetHost(request.BucketName, _regionId, _endpoint, _hostModel)},
                        {"date", AlibabaCloud.TeaUtil.Common.GetDateUTCString()},
                        {"user-agent", GetUserAgent()},
                    };
                    if (!AlibabaCloud.TeaUtil.Common.Empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Query = AlibabaCloud.TeaUtil.Common.StringifyMapValue(request.Filter.ToMap());
                    request_.Headers["authorization"] = AlibabaCloud.OSSUtil.Common.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders);
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (AlibabaCloud.TeaUtil.Common.Is4xx(response_.StatusCode) || AlibabaCloud.TeaUtil.Common.Is5xx(response_.StatusCode))
                    {
                        bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                        respMap = AlibabaCloud.OSSUtil.Common.GetErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", respMap.Get("Code")},
                            {"message", respMap.Get("Message")},
                            {"data", new Dictionary<string, object>
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap.Get("RequestId")},
                                {"hostId", respMap.Get("HostId")},
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

        public AppendObjectResponse AppendObject(AppendObjectRequest request, AlibabaCloud.OSSUtil.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
                {"timeouted", "retry"},
                {"readTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.LocalAddr, _localAddr)},
                {"httpProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
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
                    Dictionary<string, string> ctx = new Dictionary<string, string>(){};
                    string accessKeyId = this._credential.GetAccessKeyId();
                    string accessKeySecret = this._credential.GetAccessKeySecret();
                    string token = this._credential.GetSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "POST";
                    request_.Pathname = "/" + request.ObjectName + "?append";
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"host", AlibabaCloud.OSSUtil.Common.GetHost(request.BucketName, _regionId, _endpoint, _hostModel)},
                            {"date", AlibabaCloud.TeaUtil.Common.GetDateUTCString()},
                            {"user-agent", GetUserAgent()},
                        },
                        AlibabaCloud.TeaUtil.Common.StringifyMapValue(request.Header.ToMap()),
                        AlibabaCloud.OSSUtil.Common.ParseMeta(request.UserMeta, "x-oss-meta-")
                    );
                    if (!AlibabaCloud.TeaUtil.Common.Empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Query = AlibabaCloud.TeaUtil.Common.StringifyMapValue(request.Filter.ToMap());
                    request_.Body = AlibabaCloud.OSSUtil.Common.Inject(request.Body, ctx);
                    if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Header.ToMap()) && !AlibabaCloud.TeaUtil.Common.Empty(request.Header.ContentType))
                    {
                        request_.Headers["content-type"] = request.Header.ContentType;
                    }
                    else
                    {
                        request_.Headers["content-type"] = AlibabaCloud.OSSUtil.Common.GetContentType(request.ObjectName);
                    }
                    request_.Headers["authorization"] = AlibabaCloud.OSSUtil.Common.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (AlibabaCloud.TeaUtil.Common.Is4xx(response_.StatusCode) || AlibabaCloud.TeaUtil.Common.Is5xx(response_.StatusCode))
                    {
                        bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                        respMap = AlibabaCloud.OSSUtil.Common.GetErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", respMap.Get("Code")},
                            {"message", respMap.Get("Message")},
                            {"data", new Dictionary<string, object>
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap.Get("RequestId")},
                                {"hostId", respMap.Get("HostId")},
                            }},
                        });
                    }
                    if (_isEnableCrc.Value && !AlibabaCloud.TeaUtil.Common.EqualString(ctx.Get("crc"), response_.Headers.Get("x-oss-hash-crc64ecma")))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", "CrcNotMatched"},
                            {"data", new Dictionary<string, string>
                            {
                                {"clientCrc", ctx.Get("crc")},
                                {"serverCrc", response_.Headers.Get("x-oss-hash-crc64ecma")},
                            }},
                        });
                    }
                    if (_isEnableMD5.Value && !AlibabaCloud.TeaUtil.Common.EqualString(ctx.Get("md5"), response_.Headers.Get("content-md5")))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", "MD5NotMatched"},
                            {"data", new Dictionary<string, string>
                            {
                                {"clientMD5", ctx.Get("md5")},
                                {"serverMD5", response_.Headers.Get("content-md5")},
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

        public async Task<AppendObjectResponse> AppendObjectAsync(AppendObjectRequest request, AlibabaCloud.OSSUtil.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
                {"timeouted", "retry"},
                {"readTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.LocalAddr, _localAddr)},
                {"httpProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
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
                    Dictionary<string, string> ctx = new Dictionary<string, string>(){};
                    string accessKeyId = await this._credential.GetAccessKeyIdAsync();
                    string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
                    string token = await this._credential.GetSecurityTokenAsync();
                    request_.Protocol = _protocol;
                    request_.Method = "POST";
                    request_.Pathname = "/" + request.ObjectName + "?append";
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"host", AlibabaCloud.OSSUtil.Common.GetHost(request.BucketName, _regionId, _endpoint, _hostModel)},
                            {"date", AlibabaCloud.TeaUtil.Common.GetDateUTCString()},
                            {"user-agent", GetUserAgent()},
                        },
                        AlibabaCloud.TeaUtil.Common.StringifyMapValue(request.Header.ToMap()),
                        AlibabaCloud.OSSUtil.Common.ParseMeta(request.UserMeta, "x-oss-meta-")
                    );
                    if (!AlibabaCloud.TeaUtil.Common.Empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Query = AlibabaCloud.TeaUtil.Common.StringifyMapValue(request.Filter.ToMap());
                    request_.Body = AlibabaCloud.OSSUtil.Common.Inject(request.Body, ctx);
                    if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Header.ToMap()) && !AlibabaCloud.TeaUtil.Common.Empty(request.Header.ContentType))
                    {
                        request_.Headers["content-type"] = request.Header.ContentType;
                    }
                    else
                    {
                        request_.Headers["content-type"] = AlibabaCloud.OSSUtil.Common.GetContentType(request.ObjectName);
                    }
                    request_.Headers["authorization"] = AlibabaCloud.OSSUtil.Common.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders);
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (AlibabaCloud.TeaUtil.Common.Is4xx(response_.StatusCode) || AlibabaCloud.TeaUtil.Common.Is5xx(response_.StatusCode))
                    {
                        bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                        respMap = AlibabaCloud.OSSUtil.Common.GetErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", respMap.Get("Code")},
                            {"message", respMap.Get("Message")},
                            {"data", new Dictionary<string, object>
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap.Get("RequestId")},
                                {"hostId", respMap.Get("HostId")},
                            }},
                        });
                    }
                    if (_isEnableCrc.Value && !AlibabaCloud.TeaUtil.Common.EqualString(ctx.Get("crc"), response_.Headers.Get("x-oss-hash-crc64ecma")))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", "CrcNotMatched"},
                            {"data", new Dictionary<string, string>
                            {
                                {"clientCrc", ctx.Get("crc")},
                                {"serverCrc", response_.Headers.Get("x-oss-hash-crc64ecma")},
                            }},
                        });
                    }
                    if (_isEnableMD5.Value && !AlibabaCloud.TeaUtil.Common.EqualString(ctx.Get("md5"), response_.Headers.Get("content-md5")))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", "MD5NotMatched"},
                            {"data", new Dictionary<string, string>
                            {
                                {"clientMD5", ctx.Get("md5")},
                                {"serverMD5", response_.Headers.Get("content-md5")},
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

        public UploadPartCopyResponse UploadPartCopy(UploadPartCopyRequest request, AlibabaCloud.OSSUtil.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
                {"timeouted", "retry"},
                {"readTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.LocalAddr, _localAddr)},
                {"httpProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accessKeyId = this._credential.GetAccessKeyId();
                    string accessKeySecret = this._credential.GetAccessKeySecret();
                    string token = this._credential.GetSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "PUT";
                    request_.Pathname = "/" + request.ObjectName;
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"host", AlibabaCloud.OSSUtil.Common.GetHost(request.BucketName, _regionId, _endpoint, _hostModel)},
                            {"date", AlibabaCloud.TeaUtil.Common.GetDateUTCString()},
                            {"user-agent", GetUserAgent()},
                        },
                        AlibabaCloud.TeaUtil.Common.StringifyMapValue(request.Header.ToMap())
                    );
                    if (!AlibabaCloud.TeaUtil.Common.Empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Query = AlibabaCloud.TeaUtil.Common.StringifyMapValue(request.Filter.ToMap());
                    request_.Headers["authorization"] = AlibabaCloud.OSSUtil.Common.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (AlibabaCloud.TeaUtil.Common.Is4xx(response_.StatusCode) || AlibabaCloud.TeaUtil.Common.Is5xx(response_.StatusCode))
                    {
                        bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                        respMap = AlibabaCloud.OSSUtil.Common.GetErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", respMap.Get("Code")},
                            {"message", respMap.Get("Message")},
                            {"data", new Dictionary<string, object>
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap.Get("RequestId")},
                                {"hostId", respMap.Get("HostId")},
                            }},
                        });
                    }
                    bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                    respMap = AlibabaCloud.TeaXML.Client.ParseXml(bodyStr, typeof(UploadPartCopyResponse));
                    return TeaModel.ToObject<UploadPartCopyResponse>(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"CopyPartResult", respMap.Get("CopyPartResult")},
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

        public async Task<UploadPartCopyResponse> UploadPartCopyAsync(UploadPartCopyRequest request, AlibabaCloud.OSSUtil.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
                {"timeouted", "retry"},
                {"readTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.LocalAddr, _localAddr)},
                {"httpProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accessKeyId = await this._credential.GetAccessKeyIdAsync();
                    string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
                    string token = await this._credential.GetSecurityTokenAsync();
                    request_.Protocol = _protocol;
                    request_.Method = "PUT";
                    request_.Pathname = "/" + request.ObjectName;
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"host", AlibabaCloud.OSSUtil.Common.GetHost(request.BucketName, _regionId, _endpoint, _hostModel)},
                            {"date", AlibabaCloud.TeaUtil.Common.GetDateUTCString()},
                            {"user-agent", GetUserAgent()},
                        },
                        AlibabaCloud.TeaUtil.Common.StringifyMapValue(request.Header.ToMap())
                    );
                    if (!AlibabaCloud.TeaUtil.Common.Empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Query = AlibabaCloud.TeaUtil.Common.StringifyMapValue(request.Filter.ToMap());
                    request_.Headers["authorization"] = AlibabaCloud.OSSUtil.Common.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders);
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (AlibabaCloud.TeaUtil.Common.Is4xx(response_.StatusCode) || AlibabaCloud.TeaUtil.Common.Is5xx(response_.StatusCode))
                    {
                        bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                        respMap = AlibabaCloud.OSSUtil.Common.GetErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", respMap.Get("Code")},
                            {"message", respMap.Get("Message")},
                            {"data", new Dictionary<string, object>
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap.Get("RequestId")},
                                {"hostId", respMap.Get("HostId")},
                            }},
                        });
                    }
                    bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                    respMap = AlibabaCloud.TeaXML.Client.ParseXml(bodyStr, typeof(UploadPartCopyResponse));
                    return TeaModel.ToObject<UploadPartCopyResponse>(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"CopyPartResult", respMap.Get("CopyPartResult")},
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

        public GetVodPlaylistResponse GetVodPlaylist(GetVodPlaylistRequest request, AlibabaCloud.OSSUtil.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
                {"timeouted", "retry"},
                {"readTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.LocalAddr, _localAddr)},
                {"httpProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accessKeyId = this._credential.GetAccessKeyId();
                    string accessKeySecret = this._credential.GetAccessKeySecret();
                    string token = this._credential.GetSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/" + request.ChannelName + "?vod";
                    request_.Headers = new Dictionary<string, string>
                    {
                        {"host", AlibabaCloud.OSSUtil.Common.GetHost(request.BucketName, _regionId, _endpoint, _hostModel)},
                        {"date", AlibabaCloud.TeaUtil.Common.GetDateUTCString()},
                        {"user-agent", GetUserAgent()},
                    };
                    if (!AlibabaCloud.TeaUtil.Common.Empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Query = AlibabaCloud.TeaUtil.Common.StringifyMapValue(request.Filter.ToMap());
                    request_.Headers["authorization"] = AlibabaCloud.OSSUtil.Common.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (AlibabaCloud.TeaUtil.Common.Is4xx(response_.StatusCode) || AlibabaCloud.TeaUtil.Common.Is5xx(response_.StatusCode))
                    {
                        bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                        respMap = AlibabaCloud.OSSUtil.Common.GetErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", respMap.Get("Code")},
                            {"message", respMap.Get("Message")},
                            {"data", new Dictionary<string, object>
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap.Get("RequestId")},
                                {"hostId", respMap.Get("HostId")},
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

        public async Task<GetVodPlaylistResponse> GetVodPlaylistAsync(GetVodPlaylistRequest request, AlibabaCloud.OSSUtil.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
                {"timeouted", "retry"},
                {"readTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.LocalAddr, _localAddr)},
                {"httpProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accessKeyId = await this._credential.GetAccessKeyIdAsync();
                    string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
                    string token = await this._credential.GetSecurityTokenAsync();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/" + request.ChannelName + "?vod";
                    request_.Headers = new Dictionary<string, string>
                    {
                        {"host", AlibabaCloud.OSSUtil.Common.GetHost(request.BucketName, _regionId, _endpoint, _hostModel)},
                        {"date", AlibabaCloud.TeaUtil.Common.GetDateUTCString()},
                        {"user-agent", GetUserAgent()},
                    };
                    if (!AlibabaCloud.TeaUtil.Common.Empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Query = AlibabaCloud.TeaUtil.Common.StringifyMapValue(request.Filter.ToMap());
                    request_.Headers["authorization"] = AlibabaCloud.OSSUtil.Common.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders);
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (AlibabaCloud.TeaUtil.Common.Is4xx(response_.StatusCode) || AlibabaCloud.TeaUtil.Common.Is5xx(response_.StatusCode))
                    {
                        bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                        respMap = AlibabaCloud.OSSUtil.Common.GetErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", respMap.Get("Code")},
                            {"message", respMap.Get("Message")},
                            {"data", new Dictionary<string, object>
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap.Get("RequestId")},
                                {"hostId", respMap.Get("HostId")},
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

        public DeleteBucketCORSResponse DeleteBucketCORS(DeleteBucketCORSRequest request, AlibabaCloud.OSSUtil.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
                {"timeouted", "retry"},
                {"readTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.LocalAddr, _localAddr)},
                {"httpProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accessKeyId = this._credential.GetAccessKeyId();
                    string accessKeySecret = this._credential.GetAccessKeySecret();
                    string token = this._credential.GetSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "DELETE";
                    request_.Pathname = "/?cors";
                    request_.Headers = new Dictionary<string, string>
                    {
                        {"host", AlibabaCloud.OSSUtil.Common.GetHost(request.BucketName, _regionId, _endpoint, _hostModel)},
                        {"date", AlibabaCloud.TeaUtil.Common.GetDateUTCString()},
                        {"user-agent", GetUserAgent()},
                    };
                    if (!AlibabaCloud.TeaUtil.Common.Empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = AlibabaCloud.OSSUtil.Common.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (AlibabaCloud.TeaUtil.Common.Is4xx(response_.StatusCode) || AlibabaCloud.TeaUtil.Common.Is5xx(response_.StatusCode))
                    {
                        bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                        respMap = AlibabaCloud.OSSUtil.Common.GetErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", respMap.Get("Code")},
                            {"message", respMap.Get("Message")},
                            {"data", new Dictionary<string, object>
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap.Get("RequestId")},
                                {"hostId", respMap.Get("HostId")},
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

        public async Task<DeleteBucketCORSResponse> DeleteBucketCORSAsync(DeleteBucketCORSRequest request, AlibabaCloud.OSSUtil.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
                {"timeouted", "retry"},
                {"readTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.LocalAddr, _localAddr)},
                {"httpProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accessKeyId = await this._credential.GetAccessKeyIdAsync();
                    string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
                    string token = await this._credential.GetSecurityTokenAsync();
                    request_.Protocol = _protocol;
                    request_.Method = "DELETE";
                    request_.Pathname = "/?cors";
                    request_.Headers = new Dictionary<string, string>
                    {
                        {"host", AlibabaCloud.OSSUtil.Common.GetHost(request.BucketName, _regionId, _endpoint, _hostModel)},
                        {"date", AlibabaCloud.TeaUtil.Common.GetDateUTCString()},
                        {"user-agent", GetUserAgent()},
                    };
                    if (!AlibabaCloud.TeaUtil.Common.Empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = AlibabaCloud.OSSUtil.Common.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders);
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (AlibabaCloud.TeaUtil.Common.Is4xx(response_.StatusCode) || AlibabaCloud.TeaUtil.Common.Is5xx(response_.StatusCode))
                    {
                        bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                        respMap = AlibabaCloud.OSSUtil.Common.GetErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", respMap.Get("Code")},
                            {"message", respMap.Get("Message")},
                            {"data", new Dictionary<string, object>
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap.Get("RequestId")},
                                {"hostId", respMap.Get("HostId")},
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

        public GetObjectResponse GetObject(GetObjectRequest request, AlibabaCloud.OSSUtil.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
                {"timeouted", "retry"},
                {"readTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.LocalAddr, _localAddr)},
                {"httpProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accessKeyId = this._credential.GetAccessKeyId();
                    string accessKeySecret = this._credential.GetAccessKeySecret();
                    string token = this._credential.GetSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/" + request.ObjectName;
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"host", AlibabaCloud.OSSUtil.Common.GetHost(request.BucketName, _regionId, _endpoint, _hostModel)},
                            {"date", AlibabaCloud.TeaUtil.Common.GetDateUTCString()},
                            {"user-agent", GetUserAgent()},
                        },
                        AlibabaCloud.TeaUtil.Common.StringifyMapValue(request.Header.ToMap())
                    );
                    if (!AlibabaCloud.TeaUtil.Common.Empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = AlibabaCloud.OSSUtil.Common.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (AlibabaCloud.TeaUtil.Common.Is4xx(response_.StatusCode) || AlibabaCloud.TeaUtil.Common.Is5xx(response_.StatusCode))
                    {
                        bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                        respMap = AlibabaCloud.OSSUtil.Common.GetErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", respMap.Get("Code")},
                            {"message", respMap.Get("Message")},
                            {"data", new Dictionary<string, object>
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap.Get("RequestId")},
                                {"hostId", respMap.Get("HostId")},
                            }},
                        });
                    }
                    return TeaModel.ToObject<GetObjectResponse>(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"body", response_.Body},
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

        public async Task<GetObjectResponse> GetObjectAsync(GetObjectRequest request, AlibabaCloud.OSSUtil.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
                {"timeouted", "retry"},
                {"readTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.LocalAddr, _localAddr)},
                {"httpProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accessKeyId = await this._credential.GetAccessKeyIdAsync();
                    string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
                    string token = await this._credential.GetSecurityTokenAsync();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/" + request.ObjectName;
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"host", AlibabaCloud.OSSUtil.Common.GetHost(request.BucketName, _regionId, _endpoint, _hostModel)},
                            {"date", AlibabaCloud.TeaUtil.Common.GetDateUTCString()},
                            {"user-agent", GetUserAgent()},
                        },
                        AlibabaCloud.TeaUtil.Common.StringifyMapValue(request.Header.ToMap())
                    );
                    if (!AlibabaCloud.TeaUtil.Common.Empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = AlibabaCloud.OSSUtil.Common.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders);
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (AlibabaCloud.TeaUtil.Common.Is4xx(response_.StatusCode) || AlibabaCloud.TeaUtil.Common.Is5xx(response_.StatusCode))
                    {
                        bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                        respMap = AlibabaCloud.OSSUtil.Common.GetErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", respMap.Get("Code")},
                            {"message", respMap.Get("Message")},
                            {"data", new Dictionary<string, object>
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap.Get("RequestId")},
                                {"hostId", respMap.Get("HostId")},
                            }},
                        });
                    }
                    return TeaModel.ToObject<GetObjectResponse>(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"body", response_.Body},
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

        public UploadPartResponse UploadPart(UploadPartRequest request, AlibabaCloud.OSSUtil.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
                {"timeouted", "retry"},
                {"readTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.LocalAddr, _localAddr)},
                {"httpProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
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
                    Dictionary<string, string> ctx = new Dictionary<string, string>(){};
                    string accessKeyId = this._credential.GetAccessKeyId();
                    string accessKeySecret = this._credential.GetAccessKeySecret();
                    string token = this._credential.GetSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "PUT";
                    request_.Pathname = "/" + request.ObjectName;
                    request_.Headers = new Dictionary<string, string>
                    {
                        {"host", AlibabaCloud.OSSUtil.Common.GetHost(request.BucketName, _regionId, _endpoint, _hostModel)},
                        {"date", AlibabaCloud.TeaUtil.Common.GetDateUTCString()},
                        {"user-agent", GetUserAgent()},
                    };
                    if (!AlibabaCloud.TeaUtil.Common.Empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Query = AlibabaCloud.TeaUtil.Common.StringifyMapValue(request.Filter.ToMap());
                    request_.Body = AlibabaCloud.OSSUtil.Common.Inject(request.Body, ctx);
                    request_.Headers["authorization"] = AlibabaCloud.OSSUtil.Common.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (AlibabaCloud.TeaUtil.Common.Is4xx(response_.StatusCode) || AlibabaCloud.TeaUtil.Common.Is5xx(response_.StatusCode))
                    {
                        bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                        respMap = AlibabaCloud.OSSUtil.Common.GetErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", respMap.Get("Code")},
                            {"message", respMap.Get("Message")},
                            {"data", new Dictionary<string, object>
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap.Get("RequestId")},
                                {"hostId", respMap.Get("HostId")},
                            }},
                        });
                    }
                    if (_isEnableCrc.Value && !AlibabaCloud.TeaUtil.Common.EqualString(ctx.Get("crc"), response_.Headers.Get("x-oss-hash-crc64ecma")))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", "CrcNotMatched"},
                            {"data", new Dictionary<string, string>
                            {
                                {"clientCrc", ctx.Get("crc")},
                                {"serverCrc", response_.Headers.Get("x-oss-hash-crc64ecma")},
                            }},
                        });
                    }
                    if (_isEnableMD5.Value && !AlibabaCloud.TeaUtil.Common.EqualString(ctx.Get("md5"), response_.Headers.Get("content-md5")))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", "MD5NotMatched"},
                            {"data", new Dictionary<string, string>
                            {
                                {"clientMD5", ctx.Get("md5")},
                                {"serverMD5", response_.Headers.Get("content-md5")},
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

        public async Task<UploadPartResponse> UploadPartAsync(UploadPartRequest request, AlibabaCloud.OSSUtil.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
                {"timeouted", "retry"},
                {"readTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.LocalAddr, _localAddr)},
                {"httpProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
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
                    Dictionary<string, string> ctx = new Dictionary<string, string>(){};
                    string accessKeyId = await this._credential.GetAccessKeyIdAsync();
                    string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
                    string token = await this._credential.GetSecurityTokenAsync();
                    request_.Protocol = _protocol;
                    request_.Method = "PUT";
                    request_.Pathname = "/" + request.ObjectName;
                    request_.Headers = new Dictionary<string, string>
                    {
                        {"host", AlibabaCloud.OSSUtil.Common.GetHost(request.BucketName, _regionId, _endpoint, _hostModel)},
                        {"date", AlibabaCloud.TeaUtil.Common.GetDateUTCString()},
                        {"user-agent", GetUserAgent()},
                    };
                    if (!AlibabaCloud.TeaUtil.Common.Empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Query = AlibabaCloud.TeaUtil.Common.StringifyMapValue(request.Filter.ToMap());
                    request_.Body = AlibabaCloud.OSSUtil.Common.Inject(request.Body, ctx);
                    request_.Headers["authorization"] = AlibabaCloud.OSSUtil.Common.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders);
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (AlibabaCloud.TeaUtil.Common.Is4xx(response_.StatusCode) || AlibabaCloud.TeaUtil.Common.Is5xx(response_.StatusCode))
                    {
                        bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                        respMap = AlibabaCloud.OSSUtil.Common.GetErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", respMap.Get("Code")},
                            {"message", respMap.Get("Message")},
                            {"data", new Dictionary<string, object>
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap.Get("RequestId")},
                                {"hostId", respMap.Get("HostId")},
                            }},
                        });
                    }
                    if (_isEnableCrc.Value && !AlibabaCloud.TeaUtil.Common.EqualString(ctx.Get("crc"), response_.Headers.Get("x-oss-hash-crc64ecma")))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", "CrcNotMatched"},
                            {"data", new Dictionary<string, string>
                            {
                                {"clientCrc", ctx.Get("crc")},
                                {"serverCrc", response_.Headers.Get("x-oss-hash-crc64ecma")},
                            }},
                        });
                    }
                    if (_isEnableMD5.Value && !AlibabaCloud.TeaUtil.Common.EqualString(ctx.Get("md5"), response_.Headers.Get("content-md5")))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", "MD5NotMatched"},
                            {"data", new Dictionary<string, string>
                            {
                                {"clientMD5", ctx.Get("md5")},
                                {"serverMD5", response_.Headers.Get("content-md5")},
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

        public GetBucketCORSResponse GetBucketCORS(GetBucketCORSRequest request, AlibabaCloud.OSSUtil.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
                {"timeouted", "retry"},
                {"readTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.LocalAddr, _localAddr)},
                {"httpProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accessKeyId = this._credential.GetAccessKeyId();
                    string accessKeySecret = this._credential.GetAccessKeySecret();
                    string token = this._credential.GetSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/?cors";
                    request_.Headers = new Dictionary<string, string>
                    {
                        {"host", AlibabaCloud.OSSUtil.Common.GetHost(request.BucketName, _regionId, _endpoint, _hostModel)},
                        {"date", AlibabaCloud.TeaUtil.Common.GetDateUTCString()},
                        {"user-agent", GetUserAgent()},
                    };
                    if (!AlibabaCloud.TeaUtil.Common.Empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = AlibabaCloud.OSSUtil.Common.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (AlibabaCloud.TeaUtil.Common.Is4xx(response_.StatusCode) || AlibabaCloud.TeaUtil.Common.Is5xx(response_.StatusCode))
                    {
                        bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                        respMap = AlibabaCloud.OSSUtil.Common.GetErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", respMap.Get("Code")},
                            {"message", respMap.Get("Message")},
                            {"data", new Dictionary<string, object>
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap.Get("RequestId")},
                                {"hostId", respMap.Get("HostId")},
                            }},
                        });
                    }
                    bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                    respMap = AlibabaCloud.TeaXML.Client.ParseXml(bodyStr, typeof(GetBucketCORSResponse));
                    return TeaModel.ToObject<GetBucketCORSResponse>(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"CORSConfiguration", respMap.Get("CORSConfiguration")},
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

        public async Task<GetBucketCORSResponse> GetBucketCORSAsync(GetBucketCORSRequest request, AlibabaCloud.OSSUtil.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
                {"timeouted", "retry"},
                {"readTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.LocalAddr, _localAddr)},
                {"httpProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accessKeyId = await this._credential.GetAccessKeyIdAsync();
                    string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
                    string token = await this._credential.GetSecurityTokenAsync();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/?cors";
                    request_.Headers = new Dictionary<string, string>
                    {
                        {"host", AlibabaCloud.OSSUtil.Common.GetHost(request.BucketName, _regionId, _endpoint, _hostModel)},
                        {"date", AlibabaCloud.TeaUtil.Common.GetDateUTCString()},
                        {"user-agent", GetUserAgent()},
                    };
                    if (!AlibabaCloud.TeaUtil.Common.Empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = AlibabaCloud.OSSUtil.Common.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders);
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (AlibabaCloud.TeaUtil.Common.Is4xx(response_.StatusCode) || AlibabaCloud.TeaUtil.Common.Is5xx(response_.StatusCode))
                    {
                        bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                        respMap = AlibabaCloud.OSSUtil.Common.GetErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", respMap.Get("Code")},
                            {"message", respMap.Get("Message")},
                            {"data", new Dictionary<string, object>
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap.Get("RequestId")},
                                {"hostId", respMap.Get("HostId")},
                            }},
                        });
                    }
                    bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                    respMap = AlibabaCloud.TeaXML.Client.ParseXml(bodyStr, typeof(GetBucketCORSResponse));
                    return TeaModel.ToObject<GetBucketCORSResponse>(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"CORSConfiguration", respMap.Get("CORSConfiguration")},
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

        public CopyObjectResponse CopyObject(CopyObjectRequest request, AlibabaCloud.OSSUtil.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
                {"timeouted", "retry"},
                {"readTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.LocalAddr, _localAddr)},
                {"httpProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accessKeyId = this._credential.GetAccessKeyId();
                    string accessKeySecret = this._credential.GetAccessKeySecret();
                    string token = this._credential.GetSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "PUT";
                    request_.Pathname = "/" + request.DestObjectName;
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"host", AlibabaCloud.OSSUtil.Common.GetHost(request.BucketName, _regionId, _endpoint, _hostModel)},
                            {"date", AlibabaCloud.TeaUtil.Common.GetDateUTCString()},
                            {"user-agent", GetUserAgent()},
                        },
                        AlibabaCloud.TeaUtil.Common.StringifyMapValue(request.Header.ToMap())
                    );
                    if (!AlibabaCloud.TeaUtil.Common.Empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["x-oss-copy-source"] = AlibabaCloud.OSSUtil.Common.Encode(request_.Headers.Get("x-oss-copy-source"), "UrlEncode");
                    request_.Headers["authorization"] = AlibabaCloud.OSSUtil.Common.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (AlibabaCloud.TeaUtil.Common.Is4xx(response_.StatusCode) || AlibabaCloud.TeaUtil.Common.Is5xx(response_.StatusCode))
                    {
                        bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                        respMap = AlibabaCloud.OSSUtil.Common.GetErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", respMap.Get("Code")},
                            {"message", respMap.Get("Message")},
                            {"data", new Dictionary<string, object>
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap.Get("RequestId")},
                                {"hostId", respMap.Get("HostId")},
                            }},
                        });
                    }
                    bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                    respMap = AlibabaCloud.TeaXML.Client.ParseXml(bodyStr, typeof(CopyObjectResponse));
                    return TeaModel.ToObject<CopyObjectResponse>(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"CopyObjectResult", respMap.Get("CopyObjectResult")},
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

        public async Task<CopyObjectResponse> CopyObjectAsync(CopyObjectRequest request, AlibabaCloud.OSSUtil.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
                {"timeouted", "retry"},
                {"readTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.LocalAddr, _localAddr)},
                {"httpProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accessKeyId = await this._credential.GetAccessKeyIdAsync();
                    string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
                    string token = await this._credential.GetSecurityTokenAsync();
                    request_.Protocol = _protocol;
                    request_.Method = "PUT";
                    request_.Pathname = "/" + request.DestObjectName;
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"host", AlibabaCloud.OSSUtil.Common.GetHost(request.BucketName, _regionId, _endpoint, _hostModel)},
                            {"date", AlibabaCloud.TeaUtil.Common.GetDateUTCString()},
                            {"user-agent", GetUserAgent()},
                        },
                        AlibabaCloud.TeaUtil.Common.StringifyMapValue(request.Header.ToMap())
                    );
                    if (!AlibabaCloud.TeaUtil.Common.Empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["x-oss-copy-source"] = AlibabaCloud.OSSUtil.Common.Encode(request_.Headers.Get("x-oss-copy-source"), "UrlEncode");
                    request_.Headers["authorization"] = AlibabaCloud.OSSUtil.Common.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders);
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (AlibabaCloud.TeaUtil.Common.Is4xx(response_.StatusCode) || AlibabaCloud.TeaUtil.Common.Is5xx(response_.StatusCode))
                    {
                        bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                        respMap = AlibabaCloud.OSSUtil.Common.GetErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", respMap.Get("Code")},
                            {"message", respMap.Get("Message")},
                            {"data", new Dictionary<string, object>
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap.Get("RequestId")},
                                {"hostId", respMap.Get("HostId")},
                            }},
                        });
                    }
                    bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                    respMap = AlibabaCloud.TeaXML.Client.ParseXml(bodyStr, typeof(CopyObjectResponse));
                    return TeaModel.ToObject<CopyObjectResponse>(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"CopyObjectResult", respMap.Get("CopyObjectResult")},
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

        public GetObjectTaggingResponse GetObjectTagging(GetObjectTaggingRequest request, AlibabaCloud.OSSUtil.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
                {"timeouted", "retry"},
                {"readTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.LocalAddr, _localAddr)},
                {"httpProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accessKeyId = this._credential.GetAccessKeyId();
                    string accessKeySecret = this._credential.GetAccessKeySecret();
                    string token = this._credential.GetSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/" + request.ObjectName + "?tagging";
                    request_.Headers = new Dictionary<string, string>
                    {
                        {"host", AlibabaCloud.OSSUtil.Common.GetHost(request.BucketName, _regionId, _endpoint, _hostModel)},
                        {"date", AlibabaCloud.TeaUtil.Common.GetDateUTCString()},
                        {"user-agent", GetUserAgent()},
                    };
                    if (!AlibabaCloud.TeaUtil.Common.Empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = AlibabaCloud.OSSUtil.Common.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (AlibabaCloud.TeaUtil.Common.Is4xx(response_.StatusCode) || AlibabaCloud.TeaUtil.Common.Is5xx(response_.StatusCode))
                    {
                        bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                        respMap = AlibabaCloud.OSSUtil.Common.GetErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", respMap.Get("Code")},
                            {"message", respMap.Get("Message")},
                            {"data", new Dictionary<string, object>
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap.Get("RequestId")},
                                {"hostId", respMap.Get("HostId")},
                            }},
                        });
                    }
                    bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                    respMap = AlibabaCloud.TeaXML.Client.ParseXml(bodyStr, typeof(GetObjectTaggingResponse));
                    return TeaModel.ToObject<GetObjectTaggingResponse>(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"Tagging", respMap.Get("Tagging")},
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

        public async Task<GetObjectTaggingResponse> GetObjectTaggingAsync(GetObjectTaggingRequest request, AlibabaCloud.OSSUtil.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
                {"timeouted", "retry"},
                {"readTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.LocalAddr, _localAddr)},
                {"httpProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accessKeyId = await this._credential.GetAccessKeyIdAsync();
                    string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
                    string token = await this._credential.GetSecurityTokenAsync();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/" + request.ObjectName + "?tagging";
                    request_.Headers = new Dictionary<string, string>
                    {
                        {"host", AlibabaCloud.OSSUtil.Common.GetHost(request.BucketName, _regionId, _endpoint, _hostModel)},
                        {"date", AlibabaCloud.TeaUtil.Common.GetDateUTCString()},
                        {"user-agent", GetUserAgent()},
                    };
                    if (!AlibabaCloud.TeaUtil.Common.Empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = AlibabaCloud.OSSUtil.Common.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders);
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (AlibabaCloud.TeaUtil.Common.Is4xx(response_.StatusCode) || AlibabaCloud.TeaUtil.Common.Is5xx(response_.StatusCode))
                    {
                        bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                        respMap = AlibabaCloud.OSSUtil.Common.GetErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", respMap.Get("Code")},
                            {"message", respMap.Get("Message")},
                            {"data", new Dictionary<string, object>
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap.Get("RequestId")},
                                {"hostId", respMap.Get("HostId")},
                            }},
                        });
                    }
                    bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                    respMap = AlibabaCloud.TeaXML.Client.ParseXml(bodyStr, typeof(GetObjectTaggingResponse));
                    return TeaModel.ToObject<GetObjectTaggingResponse>(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"Tagging", respMap.Get("Tagging")},
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

        public DeleteBucketLifecycleResponse DeleteBucketLifecycle(DeleteBucketLifecycleRequest request, AlibabaCloud.OSSUtil.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
                {"timeouted", "retry"},
                {"readTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.LocalAddr, _localAddr)},
                {"httpProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accessKeyId = this._credential.GetAccessKeyId();
                    string accessKeySecret = this._credential.GetAccessKeySecret();
                    string token = this._credential.GetSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "DELETE";
                    request_.Pathname = "/?lifecycle";
                    request_.Headers = new Dictionary<string, string>
                    {
                        {"host", AlibabaCloud.OSSUtil.Common.GetHost(request.BucketName, _regionId, _endpoint, _hostModel)},
                        {"date", AlibabaCloud.TeaUtil.Common.GetDateUTCString()},
                        {"user-agent", GetUserAgent()},
                    };
                    if (!AlibabaCloud.TeaUtil.Common.Empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = AlibabaCloud.OSSUtil.Common.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (AlibabaCloud.TeaUtil.Common.Is4xx(response_.StatusCode) || AlibabaCloud.TeaUtil.Common.Is5xx(response_.StatusCode))
                    {
                        bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                        respMap = AlibabaCloud.OSSUtil.Common.GetErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", respMap.Get("Code")},
                            {"message", respMap.Get("Message")},
                            {"data", new Dictionary<string, object>
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap.Get("RequestId")},
                                {"hostId", respMap.Get("HostId")},
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

        public async Task<DeleteBucketLifecycleResponse> DeleteBucketLifecycleAsync(DeleteBucketLifecycleRequest request, AlibabaCloud.OSSUtil.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
                {"timeouted", "retry"},
                {"readTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.LocalAddr, _localAddr)},
                {"httpProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accessKeyId = await this._credential.GetAccessKeyIdAsync();
                    string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
                    string token = await this._credential.GetSecurityTokenAsync();
                    request_.Protocol = _protocol;
                    request_.Method = "DELETE";
                    request_.Pathname = "/?lifecycle";
                    request_.Headers = new Dictionary<string, string>
                    {
                        {"host", AlibabaCloud.OSSUtil.Common.GetHost(request.BucketName, _regionId, _endpoint, _hostModel)},
                        {"date", AlibabaCloud.TeaUtil.Common.GetDateUTCString()},
                        {"user-agent", GetUserAgent()},
                    };
                    if (!AlibabaCloud.TeaUtil.Common.Empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = AlibabaCloud.OSSUtil.Common.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders);
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (AlibabaCloud.TeaUtil.Common.Is4xx(response_.StatusCode) || AlibabaCloud.TeaUtil.Common.Is5xx(response_.StatusCode))
                    {
                        bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                        respMap = AlibabaCloud.OSSUtil.Common.GetErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", respMap.Get("Code")},
                            {"message", respMap.Get("Message")},
                            {"data", new Dictionary<string, object>
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap.Get("RequestId")},
                                {"hostId", respMap.Get("HostId")},
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

        public DeleteBucketLoggingResponse DeleteBucketLogging(DeleteBucketLoggingRequest request, AlibabaCloud.OSSUtil.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
                {"timeouted", "retry"},
                {"readTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.LocalAddr, _localAddr)},
                {"httpProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accessKeyId = this._credential.GetAccessKeyId();
                    string accessKeySecret = this._credential.GetAccessKeySecret();
                    string token = this._credential.GetSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "DELETE";
                    request_.Pathname = "/?logging";
                    request_.Headers = new Dictionary<string, string>
                    {
                        {"host", AlibabaCloud.OSSUtil.Common.GetHost(request.BucketName, _regionId, _endpoint, _hostModel)},
                        {"date", AlibabaCloud.TeaUtil.Common.GetDateUTCString()},
                        {"user-agent", GetUserAgent()},
                    };
                    if (!AlibabaCloud.TeaUtil.Common.Empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = AlibabaCloud.OSSUtil.Common.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (AlibabaCloud.TeaUtil.Common.Is4xx(response_.StatusCode) || AlibabaCloud.TeaUtil.Common.Is5xx(response_.StatusCode))
                    {
                        bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                        respMap = AlibabaCloud.OSSUtil.Common.GetErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", respMap.Get("Code")},
                            {"message", respMap.Get("Message")},
                            {"data", new Dictionary<string, object>
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap.Get("RequestId")},
                                {"hostId", respMap.Get("HostId")},
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

        public async Task<DeleteBucketLoggingResponse> DeleteBucketLoggingAsync(DeleteBucketLoggingRequest request, AlibabaCloud.OSSUtil.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
                {"timeouted", "retry"},
                {"readTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.LocalAddr, _localAddr)},
                {"httpProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accessKeyId = await this._credential.GetAccessKeyIdAsync();
                    string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
                    string token = await this._credential.GetSecurityTokenAsync();
                    request_.Protocol = _protocol;
                    request_.Method = "DELETE";
                    request_.Pathname = "/?logging";
                    request_.Headers = new Dictionary<string, string>
                    {
                        {"host", AlibabaCloud.OSSUtil.Common.GetHost(request.BucketName, _regionId, _endpoint, _hostModel)},
                        {"date", AlibabaCloud.TeaUtil.Common.GetDateUTCString()},
                        {"user-agent", GetUserAgent()},
                    };
                    if (!AlibabaCloud.TeaUtil.Common.Empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = AlibabaCloud.OSSUtil.Common.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders);
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (AlibabaCloud.TeaUtil.Common.Is4xx(response_.StatusCode) || AlibabaCloud.TeaUtil.Common.Is5xx(response_.StatusCode))
                    {
                        bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                        respMap = AlibabaCloud.OSSUtil.Common.GetErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", respMap.Get("Code")},
                            {"message", respMap.Get("Message")},
                            {"data", new Dictionary<string, object>
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap.Get("RequestId")},
                                {"hostId", respMap.Get("HostId")},
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

        public DeleteBucketWebsiteResponse DeleteBucketWebsite(DeleteBucketWebsiteRequest request, AlibabaCloud.OSSUtil.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
                {"timeouted", "retry"},
                {"readTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.LocalAddr, _localAddr)},
                {"httpProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accessKeyId = this._credential.GetAccessKeyId();
                    string accessKeySecret = this._credential.GetAccessKeySecret();
                    string token = this._credential.GetSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "DELETE";
                    request_.Pathname = "/?website";
                    request_.Headers = new Dictionary<string, string>
                    {
                        {"host", AlibabaCloud.OSSUtil.Common.GetHost(request.BucketName, _regionId, _endpoint, _hostModel)},
                        {"date", AlibabaCloud.TeaUtil.Common.GetDateUTCString()},
                        {"user-agent", GetUserAgent()},
                    };
                    if (!AlibabaCloud.TeaUtil.Common.Empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = AlibabaCloud.OSSUtil.Common.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (AlibabaCloud.TeaUtil.Common.Is4xx(response_.StatusCode) || AlibabaCloud.TeaUtil.Common.Is5xx(response_.StatusCode))
                    {
                        bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                        respMap = AlibabaCloud.OSSUtil.Common.GetErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", respMap.Get("Code")},
                            {"message", respMap.Get("Message")},
                            {"data", new Dictionary<string, object>
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap.Get("RequestId")},
                                {"hostId", respMap.Get("HostId")},
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

        public async Task<DeleteBucketWebsiteResponse> DeleteBucketWebsiteAsync(DeleteBucketWebsiteRequest request, AlibabaCloud.OSSUtil.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
                {"timeouted", "retry"},
                {"readTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.LocalAddr, _localAddr)},
                {"httpProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accessKeyId = await this._credential.GetAccessKeyIdAsync();
                    string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
                    string token = await this._credential.GetSecurityTokenAsync();
                    request_.Protocol = _protocol;
                    request_.Method = "DELETE";
                    request_.Pathname = "/?website";
                    request_.Headers = new Dictionary<string, string>
                    {
                        {"host", AlibabaCloud.OSSUtil.Common.GetHost(request.BucketName, _regionId, _endpoint, _hostModel)},
                        {"date", AlibabaCloud.TeaUtil.Common.GetDateUTCString()},
                        {"user-agent", GetUserAgent()},
                    };
                    if (!AlibabaCloud.TeaUtil.Common.Empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = AlibabaCloud.OSSUtil.Common.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders);
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (AlibabaCloud.TeaUtil.Common.Is4xx(response_.StatusCode) || AlibabaCloud.TeaUtil.Common.Is5xx(response_.StatusCode))
                    {
                        bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                        respMap = AlibabaCloud.OSSUtil.Common.GetErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", respMap.Get("Code")},
                            {"message", respMap.Get("Message")},
                            {"data", new Dictionary<string, object>
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap.Get("RequestId")},
                                {"hostId", respMap.Get("HostId")},
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

        public GetSymlinkResponse GetSymlink(GetSymlinkRequest request, AlibabaCloud.OSSUtil.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
                {"timeouted", "retry"},
                {"readTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.LocalAddr, _localAddr)},
                {"httpProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accessKeyId = this._credential.GetAccessKeyId();
                    string accessKeySecret = this._credential.GetAccessKeySecret();
                    string token = this._credential.GetSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/" + request.ObjectName + "?symlink";
                    request_.Headers = new Dictionary<string, string>
                    {
                        {"host", AlibabaCloud.OSSUtil.Common.GetHost(request.BucketName, _regionId, _endpoint, _hostModel)},
                        {"date", AlibabaCloud.TeaUtil.Common.GetDateUTCString()},
                        {"user-agent", GetUserAgent()},
                    };
                    if (!AlibabaCloud.TeaUtil.Common.Empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = AlibabaCloud.OSSUtil.Common.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (AlibabaCloud.TeaUtil.Common.Is4xx(response_.StatusCode) || AlibabaCloud.TeaUtil.Common.Is5xx(response_.StatusCode))
                    {
                        bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                        respMap = AlibabaCloud.OSSUtil.Common.GetErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", respMap.Get("Code")},
                            {"message", respMap.Get("Message")},
                            {"data", new Dictionary<string, object>
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap.Get("RequestId")},
                                {"hostId", respMap.Get("HostId")},
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

        public async Task<GetSymlinkResponse> GetSymlinkAsync(GetSymlinkRequest request, AlibabaCloud.OSSUtil.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
                {"timeouted", "retry"},
                {"readTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.LocalAddr, _localAddr)},
                {"httpProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accessKeyId = await this._credential.GetAccessKeyIdAsync();
                    string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
                    string token = await this._credential.GetSecurityTokenAsync();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/" + request.ObjectName + "?symlink";
                    request_.Headers = new Dictionary<string, string>
                    {
                        {"host", AlibabaCloud.OSSUtil.Common.GetHost(request.BucketName, _regionId, _endpoint, _hostModel)},
                        {"date", AlibabaCloud.TeaUtil.Common.GetDateUTCString()},
                        {"user-agent", GetUserAgent()},
                    };
                    if (!AlibabaCloud.TeaUtil.Common.Empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = AlibabaCloud.OSSUtil.Common.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders);
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (AlibabaCloud.TeaUtil.Common.Is4xx(response_.StatusCode) || AlibabaCloud.TeaUtil.Common.Is5xx(response_.StatusCode))
                    {
                        bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                        respMap = AlibabaCloud.OSSUtil.Common.GetErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", respMap.Get("Code")},
                            {"message", respMap.Get("Message")},
                            {"data", new Dictionary<string, object>
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap.Get("RequestId")},
                                {"hostId", respMap.Get("HostId")},
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

        public GetBucketLifecycleResponse GetBucketLifecycle(GetBucketLifecycleRequest request, AlibabaCloud.OSSUtil.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
                {"timeouted", "retry"},
                {"readTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.LocalAddr, _localAddr)},
                {"httpProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accessKeyId = this._credential.GetAccessKeyId();
                    string accessKeySecret = this._credential.GetAccessKeySecret();
                    string token = this._credential.GetSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/?lifecycle";
                    request_.Headers = new Dictionary<string, string>
                    {
                        {"host", AlibabaCloud.OSSUtil.Common.GetHost(request.BucketName, _regionId, _endpoint, _hostModel)},
                        {"date", AlibabaCloud.TeaUtil.Common.GetDateUTCString()},
                        {"user-agent", GetUserAgent()},
                    };
                    if (!AlibabaCloud.TeaUtil.Common.Empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = AlibabaCloud.OSSUtil.Common.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (AlibabaCloud.TeaUtil.Common.Is4xx(response_.StatusCode) || AlibabaCloud.TeaUtil.Common.Is5xx(response_.StatusCode))
                    {
                        bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                        respMap = AlibabaCloud.OSSUtil.Common.GetErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", respMap.Get("Code")},
                            {"message", respMap.Get("Message")},
                            {"data", new Dictionary<string, object>
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap.Get("RequestId")},
                                {"hostId", respMap.Get("HostId")},
                            }},
                        });
                    }
                    bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                    respMap = AlibabaCloud.TeaXML.Client.ParseXml(bodyStr, typeof(GetBucketLifecycleResponse));
                    return TeaModel.ToObject<GetBucketLifecycleResponse>(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"LifecycleConfiguration", respMap.Get("LifecycleConfiguration")},
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

        public async Task<GetBucketLifecycleResponse> GetBucketLifecycleAsync(GetBucketLifecycleRequest request, AlibabaCloud.OSSUtil.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
                {"timeouted", "retry"},
                {"readTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.LocalAddr, _localAddr)},
                {"httpProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accessKeyId = await this._credential.GetAccessKeyIdAsync();
                    string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
                    string token = await this._credential.GetSecurityTokenAsync();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/?lifecycle";
                    request_.Headers = new Dictionary<string, string>
                    {
                        {"host", AlibabaCloud.OSSUtil.Common.GetHost(request.BucketName, _regionId, _endpoint, _hostModel)},
                        {"date", AlibabaCloud.TeaUtil.Common.GetDateUTCString()},
                        {"user-agent", GetUserAgent()},
                    };
                    if (!AlibabaCloud.TeaUtil.Common.Empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = AlibabaCloud.OSSUtil.Common.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders);
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (AlibabaCloud.TeaUtil.Common.Is4xx(response_.StatusCode) || AlibabaCloud.TeaUtil.Common.Is5xx(response_.StatusCode))
                    {
                        bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                        respMap = AlibabaCloud.OSSUtil.Common.GetErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", respMap.Get("Code")},
                            {"message", respMap.Get("Message")},
                            {"data", new Dictionary<string, object>
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap.Get("RequestId")},
                                {"hostId", respMap.Get("HostId")},
                            }},
                        });
                    }
                    bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                    respMap = AlibabaCloud.TeaXML.Client.ParseXml(bodyStr, typeof(GetBucketLifecycleResponse));
                    return TeaModel.ToObject<GetBucketLifecycleResponse>(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"LifecycleConfiguration", respMap.Get("LifecycleConfiguration")},
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

        public PutSymlinkResponse PutSymlink(PutSymlinkRequest request, AlibabaCloud.OSSUtil.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
                {"timeouted", "retry"},
                {"readTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.LocalAddr, _localAddr)},
                {"httpProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accessKeyId = this._credential.GetAccessKeyId();
                    string accessKeySecret = this._credential.GetAccessKeySecret();
                    string token = this._credential.GetSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "PUT";
                    request_.Pathname = "/" + request.ObjectName + "?symlink";
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"host", AlibabaCloud.OSSUtil.Common.GetHost(request.BucketName, _regionId, _endpoint, _hostModel)},
                            {"date", AlibabaCloud.TeaUtil.Common.GetDateUTCString()},
                            {"user-agent", GetUserAgent()},
                        },
                        AlibabaCloud.TeaUtil.Common.StringifyMapValue(request.Header.ToMap())
                    );
                    if (!AlibabaCloud.TeaUtil.Common.Empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = AlibabaCloud.OSSUtil.Common.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (AlibabaCloud.TeaUtil.Common.Is4xx(response_.StatusCode) || AlibabaCloud.TeaUtil.Common.Is5xx(response_.StatusCode))
                    {
                        bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                        respMap = AlibabaCloud.OSSUtil.Common.GetErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", respMap.Get("Code")},
                            {"message", respMap.Get("Message")},
                            {"data", new Dictionary<string, object>
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap.Get("RequestId")},
                                {"hostId", respMap.Get("HostId")},
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

        public async Task<PutSymlinkResponse> PutSymlinkAsync(PutSymlinkRequest request, AlibabaCloud.OSSUtil.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
                {"timeouted", "retry"},
                {"readTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.LocalAddr, _localAddr)},
                {"httpProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accessKeyId = await this._credential.GetAccessKeyIdAsync();
                    string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
                    string token = await this._credential.GetSecurityTokenAsync();
                    request_.Protocol = _protocol;
                    request_.Method = "PUT";
                    request_.Pathname = "/" + request.ObjectName + "?symlink";
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"host", AlibabaCloud.OSSUtil.Common.GetHost(request.BucketName, _regionId, _endpoint, _hostModel)},
                            {"date", AlibabaCloud.TeaUtil.Common.GetDateUTCString()},
                            {"user-agent", GetUserAgent()},
                        },
                        AlibabaCloud.TeaUtil.Common.StringifyMapValue(request.Header.ToMap())
                    );
                    if (!AlibabaCloud.TeaUtil.Common.Empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = AlibabaCloud.OSSUtil.Common.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders);
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (AlibabaCloud.TeaUtil.Common.Is4xx(response_.StatusCode) || AlibabaCloud.TeaUtil.Common.Is5xx(response_.StatusCode))
                    {
                        bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                        respMap = AlibabaCloud.OSSUtil.Common.GetErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", respMap.Get("Code")},
                            {"message", respMap.Get("Message")},
                            {"data", new Dictionary<string, object>
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap.Get("RequestId")},
                                {"hostId", respMap.Get("HostId")},
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

        public GetBucketRefererResponse GetBucketReferer(GetBucketRefererRequest request, AlibabaCloud.OSSUtil.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
                {"timeouted", "retry"},
                {"readTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.LocalAddr, _localAddr)},
                {"httpProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accessKeyId = this._credential.GetAccessKeyId();
                    string accessKeySecret = this._credential.GetAccessKeySecret();
                    string token = this._credential.GetSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/?referer";
                    request_.Headers = new Dictionary<string, string>
                    {
                        {"host", AlibabaCloud.OSSUtil.Common.GetHost(request.BucketName, _regionId, _endpoint, _hostModel)},
                        {"date", AlibabaCloud.TeaUtil.Common.GetDateUTCString()},
                        {"user-agent", GetUserAgent()},
                    };
                    if (!AlibabaCloud.TeaUtil.Common.Empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = AlibabaCloud.OSSUtil.Common.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (AlibabaCloud.TeaUtil.Common.Is4xx(response_.StatusCode) || AlibabaCloud.TeaUtil.Common.Is5xx(response_.StatusCode))
                    {
                        bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                        respMap = AlibabaCloud.OSSUtil.Common.GetErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", respMap.Get("Code")},
                            {"message", respMap.Get("Message")},
                            {"data", new Dictionary<string, object>
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap.Get("RequestId")},
                                {"hostId", respMap.Get("HostId")},
                            }},
                        });
                    }
                    bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                    respMap = AlibabaCloud.TeaXML.Client.ParseXml(bodyStr, typeof(GetBucketRefererResponse));
                    return TeaModel.ToObject<GetBucketRefererResponse>(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"RefererConfiguration", respMap.Get("RefererConfiguration")},
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

        public async Task<GetBucketRefererResponse> GetBucketRefererAsync(GetBucketRefererRequest request, AlibabaCloud.OSSUtil.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
                {"timeouted", "retry"},
                {"readTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.LocalAddr, _localAddr)},
                {"httpProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accessKeyId = await this._credential.GetAccessKeyIdAsync();
                    string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
                    string token = await this._credential.GetSecurityTokenAsync();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/?referer";
                    request_.Headers = new Dictionary<string, string>
                    {
                        {"host", AlibabaCloud.OSSUtil.Common.GetHost(request.BucketName, _regionId, _endpoint, _hostModel)},
                        {"date", AlibabaCloud.TeaUtil.Common.GetDateUTCString()},
                        {"user-agent", GetUserAgent()},
                    };
                    if (!AlibabaCloud.TeaUtil.Common.Empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = AlibabaCloud.OSSUtil.Common.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders);
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (AlibabaCloud.TeaUtil.Common.Is4xx(response_.StatusCode) || AlibabaCloud.TeaUtil.Common.Is5xx(response_.StatusCode))
                    {
                        bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                        respMap = AlibabaCloud.OSSUtil.Common.GetErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", respMap.Get("Code")},
                            {"message", respMap.Get("Message")},
                            {"data", new Dictionary<string, object>
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap.Get("RequestId")},
                                {"hostId", respMap.Get("HostId")},
                            }},
                        });
                    }
                    bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                    respMap = AlibabaCloud.TeaXML.Client.ParseXml(bodyStr, typeof(GetBucketRefererResponse));
                    return TeaModel.ToObject<GetBucketRefererResponse>(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"RefererConfiguration", respMap.Get("RefererConfiguration")},
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

        public CallbackResponse Callback(CallbackRequest request, AlibabaCloud.OSSUtil.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
                {"timeouted", "retry"},
                {"readTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.LocalAddr, _localAddr)},
                {"httpProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accessKeyId = this._credential.GetAccessKeyId();
                    string accessKeySecret = this._credential.GetAccessKeySecret();
                    string token = this._credential.GetSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/";
                    request_.Headers = new Dictionary<string, string>
                    {
                        {"host", AlibabaCloud.OSSUtil.Common.GetHost(request.BucketName, _regionId, _endpoint, _hostModel)},
                        {"date", AlibabaCloud.TeaUtil.Common.GetDateUTCString()},
                        {"user-agent", GetUserAgent()},
                    };
                    if (!AlibabaCloud.TeaUtil.Common.Empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = AlibabaCloud.OSSUtil.Common.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (AlibabaCloud.TeaUtil.Common.Is4xx(response_.StatusCode) || AlibabaCloud.TeaUtil.Common.Is5xx(response_.StatusCode))
                    {
                        bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                        respMap = AlibabaCloud.OSSUtil.Common.GetErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", respMap.Get("Code")},
                            {"message", respMap.Get("Message")},
                            {"data", new Dictionary<string, object>
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap.Get("RequestId")},
                                {"hostId", respMap.Get("HostId")},
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

        public async Task<CallbackResponse> CallbackAsync(CallbackRequest request, AlibabaCloud.OSSUtil.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
                {"timeouted", "retry"},
                {"readTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.LocalAddr, _localAddr)},
                {"httpProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accessKeyId = await this._credential.GetAccessKeyIdAsync();
                    string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
                    string token = await this._credential.GetSecurityTokenAsync();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/";
                    request_.Headers = new Dictionary<string, string>
                    {
                        {"host", AlibabaCloud.OSSUtil.Common.GetHost(request.BucketName, _regionId, _endpoint, _hostModel)},
                        {"date", AlibabaCloud.TeaUtil.Common.GetDateUTCString()},
                        {"user-agent", GetUserAgent()},
                    };
                    if (!AlibabaCloud.TeaUtil.Common.Empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = AlibabaCloud.OSSUtil.Common.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders);
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (AlibabaCloud.TeaUtil.Common.Is4xx(response_.StatusCode) || AlibabaCloud.TeaUtil.Common.Is5xx(response_.StatusCode))
                    {
                        bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                        respMap = AlibabaCloud.OSSUtil.Common.GetErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", respMap.Get("Code")},
                            {"message", respMap.Get("Message")},
                            {"data", new Dictionary<string, object>
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap.Get("RequestId")},
                                {"hostId", respMap.Get("HostId")},
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

        public GetBucketLoggingResponse GetBucketLogging(GetBucketLoggingRequest request, AlibabaCloud.OSSUtil.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
                {"timeouted", "retry"},
                {"readTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.LocalAddr, _localAddr)},
                {"httpProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accessKeyId = this._credential.GetAccessKeyId();
                    string accessKeySecret = this._credential.GetAccessKeySecret();
                    string token = this._credential.GetSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/?logging";
                    request_.Headers = new Dictionary<string, string>
                    {
                        {"host", AlibabaCloud.OSSUtil.Common.GetHost(request.BucketName, _regionId, _endpoint, _hostModel)},
                        {"date", AlibabaCloud.TeaUtil.Common.GetDateUTCString()},
                        {"user-agent", GetUserAgent()},
                    };
                    if (!AlibabaCloud.TeaUtil.Common.Empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = AlibabaCloud.OSSUtil.Common.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (AlibabaCloud.TeaUtil.Common.Is4xx(response_.StatusCode) || AlibabaCloud.TeaUtil.Common.Is5xx(response_.StatusCode))
                    {
                        bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                        respMap = AlibabaCloud.OSSUtil.Common.GetErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", respMap.Get("Code")},
                            {"message", respMap.Get("Message")},
                            {"data", new Dictionary<string, object>
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap.Get("RequestId")},
                                {"hostId", respMap.Get("HostId")},
                            }},
                        });
                    }
                    bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                    respMap = AlibabaCloud.TeaXML.Client.ParseXml(bodyStr, typeof(GetBucketLoggingResponse));
                    return TeaModel.ToObject<GetBucketLoggingResponse>(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"BucketLoggingStatus", respMap.Get("BucketLoggingStatus")},
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

        public async Task<GetBucketLoggingResponse> GetBucketLoggingAsync(GetBucketLoggingRequest request, AlibabaCloud.OSSUtil.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
                {"timeouted", "retry"},
                {"readTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.LocalAddr, _localAddr)},
                {"httpProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accessKeyId = await this._credential.GetAccessKeyIdAsync();
                    string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
                    string token = await this._credential.GetSecurityTokenAsync();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/?logging";
                    request_.Headers = new Dictionary<string, string>
                    {
                        {"host", AlibabaCloud.OSSUtil.Common.GetHost(request.BucketName, _regionId, _endpoint, _hostModel)},
                        {"date", AlibabaCloud.TeaUtil.Common.GetDateUTCString()},
                        {"user-agent", GetUserAgent()},
                    };
                    if (!AlibabaCloud.TeaUtil.Common.Empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = AlibabaCloud.OSSUtil.Common.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders);
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (AlibabaCloud.TeaUtil.Common.Is4xx(response_.StatusCode) || AlibabaCloud.TeaUtil.Common.Is5xx(response_.StatusCode))
                    {
                        bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                        respMap = AlibabaCloud.OSSUtil.Common.GetErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", respMap.Get("Code")},
                            {"message", respMap.Get("Message")},
                            {"data", new Dictionary<string, object>
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap.Get("RequestId")},
                                {"hostId", respMap.Get("HostId")},
                            }},
                        });
                    }
                    bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                    respMap = AlibabaCloud.TeaXML.Client.ParseXml(bodyStr, typeof(GetBucketLoggingResponse));
                    return TeaModel.ToObject<GetBucketLoggingResponse>(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"BucketLoggingStatus", respMap.Get("BucketLoggingStatus")},
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

        public PutObjectAclResponse PutObjectAcl(PutObjectAclRequest request, AlibabaCloud.OSSUtil.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
                {"timeouted", "retry"},
                {"readTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.LocalAddr, _localAddr)},
                {"httpProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accessKeyId = this._credential.GetAccessKeyId();
                    string accessKeySecret = this._credential.GetAccessKeySecret();
                    string token = this._credential.GetSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "PUT";
                    request_.Pathname = "/" + request.ObjectName + "?acl";
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"host", AlibabaCloud.OSSUtil.Common.GetHost(request.BucketName, _regionId, _endpoint, _hostModel)},
                            {"date", AlibabaCloud.TeaUtil.Common.GetDateUTCString()},
                            {"user-agent", GetUserAgent()},
                        },
                        AlibabaCloud.TeaUtil.Common.StringifyMapValue(request.Header.ToMap())
                    );
                    if (!AlibabaCloud.TeaUtil.Common.Empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = AlibabaCloud.OSSUtil.Common.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (AlibabaCloud.TeaUtil.Common.Is4xx(response_.StatusCode) || AlibabaCloud.TeaUtil.Common.Is5xx(response_.StatusCode))
                    {
                        bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                        respMap = AlibabaCloud.OSSUtil.Common.GetErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", respMap.Get("Code")},
                            {"message", respMap.Get("Message")},
                            {"data", new Dictionary<string, object>
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap.Get("RequestId")},
                                {"hostId", respMap.Get("HostId")},
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

        public async Task<PutObjectAclResponse> PutObjectAclAsync(PutObjectAclRequest request, AlibabaCloud.OSSUtil.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
                {"timeouted", "retry"},
                {"readTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.LocalAddr, _localAddr)},
                {"httpProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accessKeyId = await this._credential.GetAccessKeyIdAsync();
                    string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
                    string token = await this._credential.GetSecurityTokenAsync();
                    request_.Protocol = _protocol;
                    request_.Method = "PUT";
                    request_.Pathname = "/" + request.ObjectName + "?acl";
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"host", AlibabaCloud.OSSUtil.Common.GetHost(request.BucketName, _regionId, _endpoint, _hostModel)},
                            {"date", AlibabaCloud.TeaUtil.Common.GetDateUTCString()},
                            {"user-agent", GetUserAgent()},
                        },
                        AlibabaCloud.TeaUtil.Common.StringifyMapValue(request.Header.ToMap())
                    );
                    if (!AlibabaCloud.TeaUtil.Common.Empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = AlibabaCloud.OSSUtil.Common.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders);
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (AlibabaCloud.TeaUtil.Common.Is4xx(response_.StatusCode) || AlibabaCloud.TeaUtil.Common.Is5xx(response_.StatusCode))
                    {
                        bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                        respMap = AlibabaCloud.OSSUtil.Common.GetErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", respMap.Get("Code")},
                            {"message", respMap.Get("Message")},
                            {"data", new Dictionary<string, object>
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap.Get("RequestId")},
                                {"hostId", respMap.Get("HostId")},
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

        public GetBucketInfoResponse GetBucketInfo(GetBucketInfoRequest request, AlibabaCloud.OSSUtil.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
                {"timeouted", "retry"},
                {"readTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.LocalAddr, _localAddr)},
                {"httpProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accessKeyId = this._credential.GetAccessKeyId();
                    string accessKeySecret = this._credential.GetAccessKeySecret();
                    string token = this._credential.GetSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/?bucketInfo";
                    request_.Headers = new Dictionary<string, string>
                    {
                        {"host", AlibabaCloud.OSSUtil.Common.GetHost(request.BucketName, _regionId, _endpoint, _hostModel)},
                        {"date", AlibabaCloud.TeaUtil.Common.GetDateUTCString()},
                        {"user-agent", GetUserAgent()},
                    };
                    if (!AlibabaCloud.TeaUtil.Common.Empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = AlibabaCloud.OSSUtil.Common.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (AlibabaCloud.TeaUtil.Common.Is4xx(response_.StatusCode) || AlibabaCloud.TeaUtil.Common.Is5xx(response_.StatusCode))
                    {
                        bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                        respMap = AlibabaCloud.OSSUtil.Common.GetErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", respMap.Get("Code")},
                            {"message", respMap.Get("Message")},
                            {"data", new Dictionary<string, object>
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap.Get("RequestId")},
                                {"hostId", respMap.Get("HostId")},
                            }},
                        });
                    }
                    bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                    respMap = AlibabaCloud.TeaXML.Client.ParseXml(bodyStr, typeof(GetBucketInfoResponse));
                    return TeaModel.ToObject<GetBucketInfoResponse>(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"BucketInfo", respMap.Get("BucketInfo")},
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

        public async Task<GetBucketInfoResponse> GetBucketInfoAsync(GetBucketInfoRequest request, AlibabaCloud.OSSUtil.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
                {"timeouted", "retry"},
                {"readTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.LocalAddr, _localAddr)},
                {"httpProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accessKeyId = await this._credential.GetAccessKeyIdAsync();
                    string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
                    string token = await this._credential.GetSecurityTokenAsync();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/?bucketInfo";
                    request_.Headers = new Dictionary<string, string>
                    {
                        {"host", AlibabaCloud.OSSUtil.Common.GetHost(request.BucketName, _regionId, _endpoint, _hostModel)},
                        {"date", AlibabaCloud.TeaUtil.Common.GetDateUTCString()},
                        {"user-agent", GetUserAgent()},
                    };
                    if (!AlibabaCloud.TeaUtil.Common.Empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = AlibabaCloud.OSSUtil.Common.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders);
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (AlibabaCloud.TeaUtil.Common.Is4xx(response_.StatusCode) || AlibabaCloud.TeaUtil.Common.Is5xx(response_.StatusCode))
                    {
                        bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                        respMap = AlibabaCloud.OSSUtil.Common.GetErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", respMap.Get("Code")},
                            {"message", respMap.Get("Message")},
                            {"data", new Dictionary<string, object>
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap.Get("RequestId")},
                                {"hostId", respMap.Get("HostId")},
                            }},
                        });
                    }
                    bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                    respMap = AlibabaCloud.TeaXML.Client.ParseXml(bodyStr, typeof(GetBucketInfoResponse));
                    return TeaModel.ToObject<GetBucketInfoResponse>(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"BucketInfo", respMap.Get("BucketInfo")},
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

        public PutLiveChannelStatusResponse PutLiveChannelStatus(PutLiveChannelStatusRequest request, AlibabaCloud.OSSUtil.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
                {"timeouted", "retry"},
                {"readTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.LocalAddr, _localAddr)},
                {"httpProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accessKeyId = this._credential.GetAccessKeyId();
                    string accessKeySecret = this._credential.GetAccessKeySecret();
                    string token = this._credential.GetSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "PUT";
                    request_.Pathname = "/" + request.ChannelName + "?live";
                    request_.Headers = new Dictionary<string, string>
                    {
                        {"host", AlibabaCloud.OSSUtil.Common.GetHost(request.BucketName, _regionId, _endpoint, _hostModel)},
                        {"date", AlibabaCloud.TeaUtil.Common.GetDateUTCString()},
                        {"user-agent", GetUserAgent()},
                    };
                    if (!AlibabaCloud.TeaUtil.Common.Empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Query = AlibabaCloud.TeaUtil.Common.StringifyMapValue(request.Filter.ToMap());
                    request_.Headers["authorization"] = AlibabaCloud.OSSUtil.Common.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (AlibabaCloud.TeaUtil.Common.Is4xx(response_.StatusCode) || AlibabaCloud.TeaUtil.Common.Is5xx(response_.StatusCode))
                    {
                        bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                        respMap = AlibabaCloud.OSSUtil.Common.GetErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", respMap.Get("Code")},
                            {"message", respMap.Get("Message")},
                            {"data", new Dictionary<string, object>
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap.Get("RequestId")},
                                {"hostId", respMap.Get("HostId")},
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

        public async Task<PutLiveChannelStatusResponse> PutLiveChannelStatusAsync(PutLiveChannelStatusRequest request, AlibabaCloud.OSSUtil.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
                {"timeouted", "retry"},
                {"readTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.LocalAddr, _localAddr)},
                {"httpProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accessKeyId = await this._credential.GetAccessKeyIdAsync();
                    string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
                    string token = await this._credential.GetSecurityTokenAsync();
                    request_.Protocol = _protocol;
                    request_.Method = "PUT";
                    request_.Pathname = "/" + request.ChannelName + "?live";
                    request_.Headers = new Dictionary<string, string>
                    {
                        {"host", AlibabaCloud.OSSUtil.Common.GetHost(request.BucketName, _regionId, _endpoint, _hostModel)},
                        {"date", AlibabaCloud.TeaUtil.Common.GetDateUTCString()},
                        {"user-agent", GetUserAgent()},
                    };
                    if (!AlibabaCloud.TeaUtil.Common.Empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Query = AlibabaCloud.TeaUtil.Common.StringifyMapValue(request.Filter.ToMap());
                    request_.Headers["authorization"] = AlibabaCloud.OSSUtil.Common.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders);
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (AlibabaCloud.TeaUtil.Common.Is4xx(response_.StatusCode) || AlibabaCloud.TeaUtil.Common.Is5xx(response_.StatusCode))
                    {
                        bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                        respMap = AlibabaCloud.OSSUtil.Common.GetErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", respMap.Get("Code")},
                            {"message", respMap.Get("Message")},
                            {"data", new Dictionary<string, object>
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap.Get("RequestId")},
                                {"hostId", respMap.Get("HostId")},
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

        public InitiateMultipartUploadResponse InitiateMultipartUpload(InitiateMultipartUploadRequest request, AlibabaCloud.OSSUtil.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
                {"timeouted", "retry"},
                {"readTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.LocalAddr, _localAddr)},
                {"httpProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accessKeyId = this._credential.GetAccessKeyId();
                    string accessKeySecret = this._credential.GetAccessKeySecret();
                    string token = this._credential.GetSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "POST";
                    request_.Pathname = "/" + request.ObjectName + "?uploads";
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"host", AlibabaCloud.OSSUtil.Common.GetHost(request.BucketName, _regionId, _endpoint, _hostModel)},
                            {"date", AlibabaCloud.TeaUtil.Common.GetDateUTCString()},
                            {"user-agent", GetUserAgent()},
                        },
                        AlibabaCloud.TeaUtil.Common.StringifyMapValue(request.Header.ToMap())
                    );
                    if (!AlibabaCloud.TeaUtil.Common.Empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Query = AlibabaCloud.TeaUtil.Common.StringifyMapValue(request.Filter.ToMap());
                    if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Header.ToMap()) && !AlibabaCloud.TeaUtil.Common.Empty(request.Header.ContentType))
                    {
                        request_.Headers["content-type"] = request.Header.ContentType;
                    }
                    else
                    {
                        request_.Headers["content-type"] = AlibabaCloud.OSSUtil.Common.GetContentType(request.ObjectName);
                    }
                    request_.Headers["authorization"] = AlibabaCloud.OSSUtil.Common.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (AlibabaCloud.TeaUtil.Common.Is4xx(response_.StatusCode) || AlibabaCloud.TeaUtil.Common.Is5xx(response_.StatusCode))
                    {
                        bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                        respMap = AlibabaCloud.OSSUtil.Common.GetErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", respMap.Get("Code")},
                            {"message", respMap.Get("Message")},
                            {"data", new Dictionary<string, object>
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap.Get("RequestId")},
                                {"hostId", respMap.Get("HostId")},
                            }},
                        });
                    }
                    bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                    respMap = AlibabaCloud.TeaXML.Client.ParseXml(bodyStr, typeof(InitiateMultipartUploadResponse));
                    return TeaModel.ToObject<InitiateMultipartUploadResponse>(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"InitiateMultipartUploadResult", respMap.Get("InitiateMultipartUploadResult")},
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

        public async Task<InitiateMultipartUploadResponse> InitiateMultipartUploadAsync(InitiateMultipartUploadRequest request, AlibabaCloud.OSSUtil.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
                {"timeouted", "retry"},
                {"readTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.LocalAddr, _localAddr)},
                {"httpProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accessKeyId = await this._credential.GetAccessKeyIdAsync();
                    string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
                    string token = await this._credential.GetSecurityTokenAsync();
                    request_.Protocol = _protocol;
                    request_.Method = "POST";
                    request_.Pathname = "/" + request.ObjectName + "?uploads";
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"host", AlibabaCloud.OSSUtil.Common.GetHost(request.BucketName, _regionId, _endpoint, _hostModel)},
                            {"date", AlibabaCloud.TeaUtil.Common.GetDateUTCString()},
                            {"user-agent", GetUserAgent()},
                        },
                        AlibabaCloud.TeaUtil.Common.StringifyMapValue(request.Header.ToMap())
                    );
                    if (!AlibabaCloud.TeaUtil.Common.Empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Query = AlibabaCloud.TeaUtil.Common.StringifyMapValue(request.Filter.ToMap());
                    if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Header.ToMap()) && !AlibabaCloud.TeaUtil.Common.Empty(request.Header.ContentType))
                    {
                        request_.Headers["content-type"] = request.Header.ContentType;
                    }
                    else
                    {
                        request_.Headers["content-type"] = AlibabaCloud.OSSUtil.Common.GetContentType(request.ObjectName);
                    }
                    request_.Headers["authorization"] = AlibabaCloud.OSSUtil.Common.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders);
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (AlibabaCloud.TeaUtil.Common.Is4xx(response_.StatusCode) || AlibabaCloud.TeaUtil.Common.Is5xx(response_.StatusCode))
                    {
                        bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                        respMap = AlibabaCloud.OSSUtil.Common.GetErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", respMap.Get("Code")},
                            {"message", respMap.Get("Message")},
                            {"data", new Dictionary<string, object>
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap.Get("RequestId")},
                                {"hostId", respMap.Get("HostId")},
                            }},
                        });
                    }
                    bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                    respMap = AlibabaCloud.TeaXML.Client.ParseXml(bodyStr, typeof(InitiateMultipartUploadResponse));
                    return TeaModel.ToObject<InitiateMultipartUploadResponse>(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"InitiateMultipartUploadResult", respMap.Get("InitiateMultipartUploadResult")},
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

        public OptionObjectResponse OptionObject(OptionObjectRequest request, AlibabaCloud.OSSUtil.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
                {"timeouted", "retry"},
                {"readTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.LocalAddr, _localAddr)},
                {"httpProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accessKeyId = this._credential.GetAccessKeyId();
                    string accessKeySecret = this._credential.GetAccessKeySecret();
                    string token = this._credential.GetSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "OPTIONS";
                    request_.Pathname = "/" + request.ObjectName;
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"host", AlibabaCloud.OSSUtil.Common.GetHost(request.BucketName, _regionId, _endpoint, _hostModel)},
                            {"date", AlibabaCloud.TeaUtil.Common.GetDateUTCString()},
                            {"user-agent", GetUserAgent()},
                        },
                        AlibabaCloud.TeaUtil.Common.StringifyMapValue(request.Header.ToMap())
                    );
                    if (!AlibabaCloud.TeaUtil.Common.Empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = AlibabaCloud.OSSUtil.Common.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (AlibabaCloud.TeaUtil.Common.Is4xx(response_.StatusCode) || AlibabaCloud.TeaUtil.Common.Is5xx(response_.StatusCode))
                    {
                        bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                        respMap = AlibabaCloud.OSSUtil.Common.GetErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", respMap.Get("Code")},
                            {"message", respMap.Get("Message")},
                            {"data", new Dictionary<string, object>
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap.Get("RequestId")},
                                {"hostId", respMap.Get("HostId")},
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

        public async Task<OptionObjectResponse> OptionObjectAsync(OptionObjectRequest request, AlibabaCloud.OSSUtil.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
                {"timeouted", "retry"},
                {"readTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.LocalAddr, _localAddr)},
                {"httpProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accessKeyId = await this._credential.GetAccessKeyIdAsync();
                    string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
                    string token = await this._credential.GetSecurityTokenAsync();
                    request_.Protocol = _protocol;
                    request_.Method = "OPTIONS";
                    request_.Pathname = "/" + request.ObjectName;
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"host", AlibabaCloud.OSSUtil.Common.GetHost(request.BucketName, _regionId, _endpoint, _hostModel)},
                            {"date", AlibabaCloud.TeaUtil.Common.GetDateUTCString()},
                            {"user-agent", GetUserAgent()},
                        },
                        AlibabaCloud.TeaUtil.Common.StringifyMapValue(request.Header.ToMap())
                    );
                    if (!AlibabaCloud.TeaUtil.Common.Empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = AlibabaCloud.OSSUtil.Common.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders);
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (AlibabaCloud.TeaUtil.Common.Is4xx(response_.StatusCode) || AlibabaCloud.TeaUtil.Common.Is5xx(response_.StatusCode))
                    {
                        bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                        respMap = AlibabaCloud.OSSUtil.Common.GetErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", respMap.Get("Code")},
                            {"message", respMap.Get("Message")},
                            {"data", new Dictionary<string, object>
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap.Get("RequestId")},
                                {"hostId", respMap.Get("HostId")},
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

        public PostVodPlaylistResponse PostVodPlaylist(PostVodPlaylistRequest request, AlibabaCloud.OSSUtil.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
                {"timeouted", "retry"},
                {"readTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.LocalAddr, _localAddr)},
                {"httpProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accessKeyId = this._credential.GetAccessKeyId();
                    string accessKeySecret = this._credential.GetAccessKeySecret();
                    string token = this._credential.GetSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "POST";
                    request_.Pathname = "/" + request.ChannelName + "/" + request.PlaylistName + "?vod";
                    request_.Headers = new Dictionary<string, string>
                    {
                        {"host", AlibabaCloud.OSSUtil.Common.GetHost(request.BucketName, _regionId, _endpoint, _hostModel)},
                        {"date", AlibabaCloud.TeaUtil.Common.GetDateUTCString()},
                        {"user-agent", GetUserAgent()},
                    };
                    if (!AlibabaCloud.TeaUtil.Common.Empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Query = AlibabaCloud.TeaUtil.Common.StringifyMapValue(request.Filter.ToMap());
                    request_.Headers["authorization"] = AlibabaCloud.OSSUtil.Common.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (AlibabaCloud.TeaUtil.Common.Is4xx(response_.StatusCode) || AlibabaCloud.TeaUtil.Common.Is5xx(response_.StatusCode))
                    {
                        bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                        respMap = AlibabaCloud.OSSUtil.Common.GetErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", respMap.Get("Code")},
                            {"message", respMap.Get("Message")},
                            {"data", new Dictionary<string, object>
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap.Get("RequestId")},
                                {"hostId", respMap.Get("HostId")},
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

        public async Task<PostVodPlaylistResponse> PostVodPlaylistAsync(PostVodPlaylistRequest request, AlibabaCloud.OSSUtil.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
                {"timeouted", "retry"},
                {"readTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.LocalAddr, _localAddr)},
                {"httpProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accessKeyId = await this._credential.GetAccessKeyIdAsync();
                    string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
                    string token = await this._credential.GetSecurityTokenAsync();
                    request_.Protocol = _protocol;
                    request_.Method = "POST";
                    request_.Pathname = "/" + request.ChannelName + "/" + request.PlaylistName + "?vod";
                    request_.Headers = new Dictionary<string, string>
                    {
                        {"host", AlibabaCloud.OSSUtil.Common.GetHost(request.BucketName, _regionId, _endpoint, _hostModel)},
                        {"date", AlibabaCloud.TeaUtil.Common.GetDateUTCString()},
                        {"user-agent", GetUserAgent()},
                    };
                    if (!AlibabaCloud.TeaUtil.Common.Empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Query = AlibabaCloud.TeaUtil.Common.StringifyMapValue(request.Filter.ToMap());
                    request_.Headers["authorization"] = AlibabaCloud.OSSUtil.Common.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders);
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (AlibabaCloud.TeaUtil.Common.Is4xx(response_.StatusCode) || AlibabaCloud.TeaUtil.Common.Is5xx(response_.StatusCode))
                    {
                        bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                        respMap = AlibabaCloud.OSSUtil.Common.GetErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", respMap.Get("Code")},
                            {"message", respMap.Get("Message")},
                            {"data", new Dictionary<string, object>
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap.Get("RequestId")},
                                {"hostId", respMap.Get("HostId")},
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

        public PostObjectResponse PostObject(PostObjectRequest request, AlibabaCloud.OSSUtil.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
                {"timeouted", "retry"},
                {"readTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"httpProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.NoProxy, _noProxy)},
                {"maxIdleConns", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
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
                    string boundary = AlibabaCloud.SDK.TeaFileform.Client.GetBoundary();
                    request_.Protocol = _protocol;
                    request_.Method = "POST";
                    request_.Pathname = "/";
                    request_.Headers = new Dictionary<string, string>
                    {
                        {"host", AlibabaCloud.OSSUtil.Common.GetHost(request.BucketName, _regionId, _endpoint, _hostModel)},
                        {"date", AlibabaCloud.TeaUtil.Common.GetDateUTCString()},
                        {"user-agent", GetUserAgent()},
                    };
                    request_.Headers["content-type"] = "multipart/form-data; boundary=" + boundary;
                    Dictionary<string, object> form = TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"OSSAccessKeyId", request.Header.AccessKeyId},
                            {"policy", request.Header.Policy},
                            {"Signature", request.Header.Signature},
                            {"key", request.Header.Key},
                            {"success_action_status", request.Header.SuccessActionStatus},
                            {"file", request.Header.File},
                        },
                        AlibabaCloud.OSSUtil.Common.ToMeta(request.Header.UserMeta, "x-oss-meta-")
                    );
                    request_.Body = AlibabaCloud.SDK.TeaFileform.Client.ToFileForm(form, boundary);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                    if (AlibabaCloud.TeaUtil.Common.Is4xx(response_.StatusCode) || AlibabaCloud.TeaUtil.Common.Is5xx(response_.StatusCode))
                    {
                        respMap = AlibabaCloud.OSSUtil.Common.GetErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", respMap.Get("Code")},
                            {"message", respMap.Get("Message")},
                            {"data", new Dictionary<string, object>
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap.Get("RequestId")},
                                {"hostId", respMap.Get("HostId")},
                            }},
                        });
                    }
                    respMap = AlibabaCloud.TeaXML.Client.ParseXml(bodyStr, typeof(PostObjectResponse));
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

        public async Task<PostObjectResponse> PostObjectAsync(PostObjectRequest request, AlibabaCloud.OSSUtil.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
                {"timeouted", "retry"},
                {"readTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"httpProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.NoProxy, _noProxy)},
                {"maxIdleConns", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
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
                    string boundary = AlibabaCloud.SDK.TeaFileform.Client.GetBoundary();
                    request_.Protocol = _protocol;
                    request_.Method = "POST";
                    request_.Pathname = "/";
                    request_.Headers = new Dictionary<string, string>
                    {
                        {"host", AlibabaCloud.OSSUtil.Common.GetHost(request.BucketName, _regionId, _endpoint, _hostModel)},
                        {"date", AlibabaCloud.TeaUtil.Common.GetDateUTCString()},
                        {"user-agent", GetUserAgent()},
                    };
                    request_.Headers["content-type"] = "multipart/form-data; boundary=" + boundary;
                    Dictionary<string, object> form = TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"OSSAccessKeyId", request.Header.AccessKeyId},
                            {"policy", request.Header.Policy},
                            {"Signature", request.Header.Signature},
                            {"key", request.Header.Key},
                            {"success_action_status", request.Header.SuccessActionStatus},
                            {"file", request.Header.File},
                        },
                        AlibabaCloud.OSSUtil.Common.ToMeta(request.Header.UserMeta, "x-oss-meta-")
                    );
                    request_.Body = AlibabaCloud.SDK.TeaFileform.Client.ToFileForm(form, boundary);
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                    if (AlibabaCloud.TeaUtil.Common.Is4xx(response_.StatusCode) || AlibabaCloud.TeaUtil.Common.Is5xx(response_.StatusCode))
                    {
                        respMap = AlibabaCloud.OSSUtil.Common.GetErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", respMap.Get("Code")},
                            {"message", respMap.Get("Message")},
                            {"data", new Dictionary<string, object>
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap.Get("RequestId")},
                                {"hostId", respMap.Get("HostId")},
                            }},
                        });
                    }
                    respMap = AlibabaCloud.TeaXML.Client.ParseXml(bodyStr, typeof(PostObjectResponse));
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

        public HeadObjectResponse HeadObject(HeadObjectRequest request, AlibabaCloud.OSSUtil.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
                {"timeouted", "retry"},
                {"readTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.LocalAddr, _localAddr)},
                {"httpProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accessKeyId = this._credential.GetAccessKeyId();
                    string accessKeySecret = this._credential.GetAccessKeySecret();
                    string token = this._credential.GetSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "HEAD";
                    request_.Pathname = "/" + request.ObjectName;
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"host", AlibabaCloud.OSSUtil.Common.GetHost(request.BucketName, _regionId, _endpoint, _hostModel)},
                            {"date", AlibabaCloud.TeaUtil.Common.GetDateUTCString()},
                            {"user-agent", GetUserAgent()},
                        },
                        AlibabaCloud.TeaUtil.Common.StringifyMapValue(request.Header.ToMap())
                    );
                    if (!AlibabaCloud.TeaUtil.Common.Empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = AlibabaCloud.OSSUtil.Common.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (AlibabaCloud.TeaUtil.Common.Is4xx(response_.StatusCode) || AlibabaCloud.TeaUtil.Common.Is5xx(response_.StatusCode))
                    {
                        bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                        respMap = AlibabaCloud.OSSUtil.Common.GetErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", respMap.Get("Code")},
                            {"message", respMap.Get("Message")},
                            {"data", new Dictionary<string, object>
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap.Get("RequestId")},
                                {"hostId", respMap.Get("HostId")},
                            }},
                        });
                    }
                    return TeaModel.ToObject<HeadObjectResponse>(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"usermeta", AlibabaCloud.OSSUtil.Common.ToMeta(response_.Headers, "x-oss-meta-")},
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

        public async Task<HeadObjectResponse> HeadObjectAsync(HeadObjectRequest request, AlibabaCloud.OSSUtil.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
                {"timeouted", "retry"},
                {"readTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.LocalAddr, _localAddr)},
                {"httpProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accessKeyId = await this._credential.GetAccessKeyIdAsync();
                    string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
                    string token = await this._credential.GetSecurityTokenAsync();
                    request_.Protocol = _protocol;
                    request_.Method = "HEAD";
                    request_.Pathname = "/" + request.ObjectName;
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"host", AlibabaCloud.OSSUtil.Common.GetHost(request.BucketName, _regionId, _endpoint, _hostModel)},
                            {"date", AlibabaCloud.TeaUtil.Common.GetDateUTCString()},
                            {"user-agent", GetUserAgent()},
                        },
                        AlibabaCloud.TeaUtil.Common.StringifyMapValue(request.Header.ToMap())
                    );
                    if (!AlibabaCloud.TeaUtil.Common.Empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = AlibabaCloud.OSSUtil.Common.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders);
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (AlibabaCloud.TeaUtil.Common.Is4xx(response_.StatusCode) || AlibabaCloud.TeaUtil.Common.Is5xx(response_.StatusCode))
                    {
                        bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                        respMap = AlibabaCloud.OSSUtil.Common.GetErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", respMap.Get("Code")},
                            {"message", respMap.Get("Message")},
                            {"data", new Dictionary<string, object>
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap.Get("RequestId")},
                                {"hostId", respMap.Get("HostId")},
                            }},
                        });
                    }
                    return TeaModel.ToObject<HeadObjectResponse>(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"usermeta", AlibabaCloud.OSSUtil.Common.ToMeta(response_.Headers, "x-oss-meta-")},
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

        public DeleteObjectTaggingResponse DeleteObjectTagging(DeleteObjectTaggingRequest request, AlibabaCloud.OSSUtil.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
                {"timeouted", "retry"},
                {"readTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.LocalAddr, _localAddr)},
                {"httpProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accessKeyId = this._credential.GetAccessKeyId();
                    string accessKeySecret = this._credential.GetAccessKeySecret();
                    string token = this._credential.GetSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "DELETE";
                    request_.Pathname = "/" + request.ObjectName + "?tagging";
                    request_.Headers = new Dictionary<string, string>
                    {
                        {"host", AlibabaCloud.OSSUtil.Common.GetHost(request.BucketName, _regionId, _endpoint, _hostModel)},
                        {"date", AlibabaCloud.TeaUtil.Common.GetDateUTCString()},
                        {"user-agent", GetUserAgent()},
                    };
                    if (!AlibabaCloud.TeaUtil.Common.Empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = AlibabaCloud.OSSUtil.Common.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (AlibabaCloud.TeaUtil.Common.Is4xx(response_.StatusCode) || AlibabaCloud.TeaUtil.Common.Is5xx(response_.StatusCode))
                    {
                        bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                        respMap = AlibabaCloud.OSSUtil.Common.GetErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", respMap.Get("Code")},
                            {"message", respMap.Get("Message")},
                            {"data", new Dictionary<string, object>
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap.Get("RequestId")},
                                {"hostId", respMap.Get("HostId")},
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

        public async Task<DeleteObjectTaggingResponse> DeleteObjectTaggingAsync(DeleteObjectTaggingRequest request, AlibabaCloud.OSSUtil.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
                {"timeouted", "retry"},
                {"readTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.LocalAddr, _localAddr)},
                {"httpProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accessKeyId = await this._credential.GetAccessKeyIdAsync();
                    string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
                    string token = await this._credential.GetSecurityTokenAsync();
                    request_.Protocol = _protocol;
                    request_.Method = "DELETE";
                    request_.Pathname = "/" + request.ObjectName + "?tagging";
                    request_.Headers = new Dictionary<string, string>
                    {
                        {"host", AlibabaCloud.OSSUtil.Common.GetHost(request.BucketName, _regionId, _endpoint, _hostModel)},
                        {"date", AlibabaCloud.TeaUtil.Common.GetDateUTCString()},
                        {"user-agent", GetUserAgent()},
                    };
                    if (!AlibabaCloud.TeaUtil.Common.Empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = AlibabaCloud.OSSUtil.Common.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders);
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (AlibabaCloud.TeaUtil.Common.Is4xx(response_.StatusCode) || AlibabaCloud.TeaUtil.Common.Is5xx(response_.StatusCode))
                    {
                        bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                        respMap = AlibabaCloud.OSSUtil.Common.GetErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", respMap.Get("Code")},
                            {"message", respMap.Get("Message")},
                            {"data", new Dictionary<string, object>
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap.Get("RequestId")},
                                {"hostId", respMap.Get("HostId")},
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

        public RestoreObjectResponse RestoreObject(RestoreObjectRequest request, AlibabaCloud.OSSUtil.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
                {"timeouted", "retry"},
                {"readTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.LocalAddr, _localAddr)},
                {"httpProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accessKeyId = this._credential.GetAccessKeyId();
                    string accessKeySecret = this._credential.GetAccessKeySecret();
                    string token = this._credential.GetSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "POST";
                    request_.Pathname = "/" + request.ObjectName + "?restore";
                    request_.Headers = new Dictionary<string, string>
                    {
                        {"host", AlibabaCloud.OSSUtil.Common.GetHost(request.BucketName, _regionId, _endpoint, _hostModel)},
                        {"date", AlibabaCloud.TeaUtil.Common.GetDateUTCString()},
                        {"user-agent", GetUserAgent()},
                    };
                    if (!AlibabaCloud.TeaUtil.Common.Empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = AlibabaCloud.OSSUtil.Common.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (AlibabaCloud.TeaUtil.Common.Is4xx(response_.StatusCode) || AlibabaCloud.TeaUtil.Common.Is5xx(response_.StatusCode))
                    {
                        bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                        respMap = AlibabaCloud.OSSUtil.Common.GetErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", respMap.Get("Code")},
                            {"message", respMap.Get("Message")},
                            {"data", new Dictionary<string, object>
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap.Get("RequestId")},
                                {"hostId", respMap.Get("HostId")},
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

        public async Task<RestoreObjectResponse> RestoreObjectAsync(RestoreObjectRequest request, AlibabaCloud.OSSUtil.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
                {"timeouted", "retry"},
                {"readTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.LocalAddr, _localAddr)},
                {"httpProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accessKeyId = await this._credential.GetAccessKeyIdAsync();
                    string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
                    string token = await this._credential.GetSecurityTokenAsync();
                    request_.Protocol = _protocol;
                    request_.Method = "POST";
                    request_.Pathname = "/" + request.ObjectName + "?restore";
                    request_.Headers = new Dictionary<string, string>
                    {
                        {"host", AlibabaCloud.OSSUtil.Common.GetHost(request.BucketName, _regionId, _endpoint, _hostModel)},
                        {"date", AlibabaCloud.TeaUtil.Common.GetDateUTCString()},
                        {"user-agent", GetUserAgent()},
                    };
                    if (!AlibabaCloud.TeaUtil.Common.Empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = AlibabaCloud.OSSUtil.Common.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders);
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (AlibabaCloud.TeaUtil.Common.Is4xx(response_.StatusCode) || AlibabaCloud.TeaUtil.Common.Is5xx(response_.StatusCode))
                    {
                        bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                        respMap = AlibabaCloud.OSSUtil.Common.GetErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", respMap.Get("Code")},
                            {"message", respMap.Get("Message")},
                            {"data", new Dictionary<string, object>
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap.Get("RequestId")},
                                {"hostId", respMap.Get("HostId")},
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

        public GetObjectAclResponse GetObjectAcl(GetObjectAclRequest request, AlibabaCloud.OSSUtil.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
                {"timeouted", "retry"},
                {"readTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.LocalAddr, _localAddr)},
                {"httpProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accessKeyId = this._credential.GetAccessKeyId();
                    string accessKeySecret = this._credential.GetAccessKeySecret();
                    string token = this._credential.GetSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/" + request.ObjectName + "?acl";
                    request_.Headers = new Dictionary<string, string>
                    {
                        {"host", AlibabaCloud.OSSUtil.Common.GetHost(request.BucketName, _regionId, _endpoint, _hostModel)},
                        {"date", AlibabaCloud.TeaUtil.Common.GetDateUTCString()},
                        {"user-agent", GetUserAgent()},
                    };
                    if (!AlibabaCloud.TeaUtil.Common.Empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = AlibabaCloud.OSSUtil.Common.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (AlibabaCloud.TeaUtil.Common.Is4xx(response_.StatusCode) || AlibabaCloud.TeaUtil.Common.Is5xx(response_.StatusCode))
                    {
                        bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                        respMap = AlibabaCloud.OSSUtil.Common.GetErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", respMap.Get("Code")},
                            {"message", respMap.Get("Message")},
                            {"data", new Dictionary<string, object>
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap.Get("RequestId")},
                                {"hostId", respMap.Get("HostId")},
                            }},
                        });
                    }
                    bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                    respMap = AlibabaCloud.TeaXML.Client.ParseXml(bodyStr, typeof(GetObjectAclResponse));
                    return TeaModel.ToObject<GetObjectAclResponse>(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"AccessControlPolicy", respMap.Get("AccessControlPolicy")},
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

        public async Task<GetObjectAclResponse> GetObjectAclAsync(GetObjectAclRequest request, AlibabaCloud.OSSUtil.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
                {"timeouted", "retry"},
                {"readTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.LocalAddr, _localAddr)},
                {"httpProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accessKeyId = await this._credential.GetAccessKeyIdAsync();
                    string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
                    string token = await this._credential.GetSecurityTokenAsync();
                    request_.Protocol = _protocol;
                    request_.Method = "GET";
                    request_.Pathname = "/" + request.ObjectName + "?acl";
                    request_.Headers = new Dictionary<string, string>
                    {
                        {"host", AlibabaCloud.OSSUtil.Common.GetHost(request.BucketName, _regionId, _endpoint, _hostModel)},
                        {"date", AlibabaCloud.TeaUtil.Common.GetDateUTCString()},
                        {"user-agent", GetUserAgent()},
                    };
                    if (!AlibabaCloud.TeaUtil.Common.Empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = AlibabaCloud.OSSUtil.Common.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders);
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (AlibabaCloud.TeaUtil.Common.Is4xx(response_.StatusCode) || AlibabaCloud.TeaUtil.Common.Is5xx(response_.StatusCode))
                    {
                        bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                        respMap = AlibabaCloud.OSSUtil.Common.GetErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", respMap.Get("Code")},
                            {"message", respMap.Get("Message")},
                            {"data", new Dictionary<string, object>
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap.Get("RequestId")},
                                {"hostId", respMap.Get("HostId")},
                            }},
                        });
                    }
                    bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                    respMap = AlibabaCloud.TeaXML.Client.ParseXml(bodyStr, typeof(GetObjectAclResponse));
                    return TeaModel.ToObject<GetObjectAclResponse>(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"AccessControlPolicy", respMap.Get("AccessControlPolicy")},
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

        public PutBucketAclResponse PutBucketAcl(PutBucketAclRequest request, AlibabaCloud.OSSUtil.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
                {"timeouted", "retry"},
                {"readTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.LocalAddr, _localAddr)},
                {"httpProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accessKeyId = this._credential.GetAccessKeyId();
                    string accessKeySecret = this._credential.GetAccessKeySecret();
                    string token = this._credential.GetSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "PUT";
                    request_.Pathname = "/?acl";
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"host", AlibabaCloud.OSSUtil.Common.GetHost(request.BucketName, _regionId, _endpoint, _hostModel)},
                            {"date", AlibabaCloud.TeaUtil.Common.GetDateUTCString()},
                            {"user-agent", GetUserAgent()},
                        },
                        AlibabaCloud.TeaUtil.Common.StringifyMapValue(request.Header.ToMap())
                    );
                    if (!AlibabaCloud.TeaUtil.Common.Empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = AlibabaCloud.OSSUtil.Common.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (AlibabaCloud.TeaUtil.Common.Is4xx(response_.StatusCode) || AlibabaCloud.TeaUtil.Common.Is5xx(response_.StatusCode))
                    {
                        bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                        respMap = AlibabaCloud.OSSUtil.Common.GetErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", respMap.Get("Code")},
                            {"message", respMap.Get("Message")},
                            {"data", new Dictionary<string, object>
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap.Get("RequestId")},
                                {"hostId", respMap.Get("HostId")},
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

        public async Task<PutBucketAclResponse> PutBucketAclAsync(PutBucketAclRequest request, AlibabaCloud.OSSUtil.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
                {"timeouted", "retry"},
                {"readTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.LocalAddr, _localAddr)},
                {"httpProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accessKeyId = await this._credential.GetAccessKeyIdAsync();
                    string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
                    string token = await this._credential.GetSecurityTokenAsync();
                    request_.Protocol = _protocol;
                    request_.Method = "PUT";
                    request_.Pathname = "/?acl";
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"host", AlibabaCloud.OSSUtil.Common.GetHost(request.BucketName, _regionId, _endpoint, _hostModel)},
                            {"date", AlibabaCloud.TeaUtil.Common.GetDateUTCString()},
                            {"user-agent", GetUserAgent()},
                        },
                        AlibabaCloud.TeaUtil.Common.StringifyMapValue(request.Header.ToMap())
                    );
                    if (!AlibabaCloud.TeaUtil.Common.Empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = AlibabaCloud.OSSUtil.Common.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders);
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (AlibabaCloud.TeaUtil.Common.Is4xx(response_.StatusCode) || AlibabaCloud.TeaUtil.Common.Is5xx(response_.StatusCode))
                    {
                        bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                        respMap = AlibabaCloud.OSSUtil.Common.GetErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", respMap.Get("Code")},
                            {"message", respMap.Get("Message")},
                            {"data", new Dictionary<string, object>
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap.Get("RequestId")},
                                {"hostId", respMap.Get("HostId")},
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

        public DeleteBucketResponse DeleteBucket(DeleteBucketRequest request, AlibabaCloud.OSSUtil.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
                {"timeouted", "retry"},
                {"readTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.LocalAddr, _localAddr)},
                {"httpProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accessKeyId = this._credential.GetAccessKeyId();
                    string accessKeySecret = this._credential.GetAccessKeySecret();
                    string token = this._credential.GetSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "DELETE";
                    request_.Pathname = "/";
                    request_.Headers = new Dictionary<string, string>
                    {
                        {"host", AlibabaCloud.OSSUtil.Common.GetHost(request.BucketName, _regionId, _endpoint, _hostModel)},
                        {"date", AlibabaCloud.TeaUtil.Common.GetDateUTCString()},
                        {"user-agent", GetUserAgent()},
                    };
                    if (!AlibabaCloud.TeaUtil.Common.Empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = AlibabaCloud.OSSUtil.Common.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (AlibabaCloud.TeaUtil.Common.Is4xx(response_.StatusCode) || AlibabaCloud.TeaUtil.Common.Is5xx(response_.StatusCode))
                    {
                        bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                        respMap = AlibabaCloud.OSSUtil.Common.GetErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", respMap.Get("Code")},
                            {"message", respMap.Get("Message")},
                            {"data", new Dictionary<string, object>
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap.Get("RequestId")},
                                {"hostId", respMap.Get("HostId")},
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

        public async Task<DeleteBucketResponse> DeleteBucketAsync(DeleteBucketRequest request, AlibabaCloud.OSSUtil.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
                {"timeouted", "retry"},
                {"readTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.LocalAddr, _localAddr)},
                {"httpProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accessKeyId = await this._credential.GetAccessKeyIdAsync();
                    string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
                    string token = await this._credential.GetSecurityTokenAsync();
                    request_.Protocol = _protocol;
                    request_.Method = "DELETE";
                    request_.Pathname = "/";
                    request_.Headers = new Dictionary<string, string>
                    {
                        {"host", AlibabaCloud.OSSUtil.Common.GetHost(request.BucketName, _regionId, _endpoint, _hostModel)},
                        {"date", AlibabaCloud.TeaUtil.Common.GetDateUTCString()},
                        {"user-agent", GetUserAgent()},
                    };
                    if (!AlibabaCloud.TeaUtil.Common.Empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Headers["authorization"] = AlibabaCloud.OSSUtil.Common.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders);
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (AlibabaCloud.TeaUtil.Common.Is4xx(response_.StatusCode) || AlibabaCloud.TeaUtil.Common.Is5xx(response_.StatusCode))
                    {
                        bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                        respMap = AlibabaCloud.OSSUtil.Common.GetErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", respMap.Get("Code")},
                            {"message", respMap.Get("Message")},
                            {"data", new Dictionary<string, object>
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap.Get("RequestId")},
                                {"hostId", respMap.Get("HostId")},
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

        public PutObjectResponse PutObject(PutObjectRequest request, AlibabaCloud.OSSUtil.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
                {"timeouted", "retry"},
                {"readTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.LocalAddr, _localAddr)},
                {"httpProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
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
                    Dictionary<string, string> ctx = new Dictionary<string, string>(){};
                    string accessKeyId = this._credential.GetAccessKeyId();
                    string accessKeySecret = this._credential.GetAccessKeySecret();
                    string token = this._credential.GetSecurityToken();
                    request_.Protocol = _protocol;
                    request_.Method = "PUT";
                    request_.Pathname = "/" + request.ObjectName;
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"host", AlibabaCloud.OSSUtil.Common.GetHost(request.BucketName, _regionId, _endpoint, _hostModel)},
                            {"date", AlibabaCloud.TeaUtil.Common.GetDateUTCString()},
                            {"user-agent", GetUserAgent()},
                        },
                        AlibabaCloud.TeaUtil.Common.StringifyMapValue(request.Header.ToMap()),
                        AlibabaCloud.OSSUtil.Common.ParseMeta(request.UserMeta, "x-oss-meta-")
                    );
                    if (!AlibabaCloud.TeaUtil.Common.Empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Body = AlibabaCloud.OSSUtil.Common.Inject(request.Body, ctx);
                    if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Header.ToMap()) && !AlibabaCloud.TeaUtil.Common.Empty(request.Header.ContentType))
                    {
                        request_.Headers["content-type"] = request.Header.ContentType;
                    }
                    else
                    {
                        request_.Headers["content-type"] = AlibabaCloud.OSSUtil.Common.GetContentType(request.ObjectName);
                    }
                    request_.Headers["authorization"] = AlibabaCloud.OSSUtil.Common.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (AlibabaCloud.TeaUtil.Common.Is4xx(response_.StatusCode) || AlibabaCloud.TeaUtil.Common.Is5xx(response_.StatusCode))
                    {
                        bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                        respMap = AlibabaCloud.OSSUtil.Common.GetErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", respMap.Get("Code")},
                            {"message", respMap.Get("Message")},
                            {"data", new Dictionary<string, object>
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap.Get("RequestId")},
                                {"hostId", respMap.Get("HostId")},
                            }},
                        });
                    }
                    if (_isEnableCrc.Value && !AlibabaCloud.TeaUtil.Common.EqualString(ctx.Get("crc"), response_.Headers.Get("x-oss-hash-crc64ecma")))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", "CrcNotMatched"},
                            {"data", new Dictionary<string, string>
                            {
                                {"clientCrc", ctx.Get("crc")},
                                {"serverCrc", response_.Headers.Get("x-oss-hash-crc64ecma")},
                            }},
                        });
                    }
                    if (_isEnableMD5.Value && !AlibabaCloud.TeaUtil.Common.EqualString(ctx.Get("md5"), response_.Headers.Get("content-md5")))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", "MD5NotMatched"},
                            {"data", new Dictionary<string, string>
                            {
                                {"clientMD5", ctx.Get("md5")},
                                {"serverMD5", response_.Headers.Get("content-md5")},
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

        public async Task<PutObjectResponse> PutObjectAsync(PutObjectRequest request, AlibabaCloud.OSSUtil.Models.RuntimeOptions runtime)
        {
            request.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
                {"timeouted", "retry"},
                {"readTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"localAddr", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.LocalAddr, _localAddr)},
                {"httpProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
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
                    Dictionary<string, string> ctx = new Dictionary<string, string>(){};
                    string accessKeyId = await this._credential.GetAccessKeyIdAsync();
                    string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
                    string token = await this._credential.GetSecurityTokenAsync();
                    request_.Protocol = _protocol;
                    request_.Method = "PUT";
                    request_.Pathname = "/" + request.ObjectName;
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"host", AlibabaCloud.OSSUtil.Common.GetHost(request.BucketName, _regionId, _endpoint, _hostModel)},
                            {"date", AlibabaCloud.TeaUtil.Common.GetDateUTCString()},
                            {"user-agent", GetUserAgent()},
                        },
                        AlibabaCloud.TeaUtil.Common.StringifyMapValue(request.Header.ToMap()),
                        AlibabaCloud.OSSUtil.Common.ParseMeta(request.UserMeta, "x-oss-meta-")
                    );
                    if (!AlibabaCloud.TeaUtil.Common.Empty(token))
                    {
                        request_.Headers["x-oss-security-token"] = token;
                    }
                    request_.Body = AlibabaCloud.OSSUtil.Common.Inject(request.Body, ctx);
                    if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Header.ToMap()) && !AlibabaCloud.TeaUtil.Common.Empty(request.Header.ContentType))
                    {
                        request_.Headers["content-type"] = request.Header.ContentType;
                    }
                    else
                    {
                        request_.Headers["content-type"] = AlibabaCloud.OSSUtil.Common.GetContentType(request.ObjectName);
                    }
                    request_.Headers["authorization"] = AlibabaCloud.OSSUtil.Common.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, _signatureVersion, _addtionalHeaders);
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = null;
                    if (AlibabaCloud.TeaUtil.Common.Is4xx(response_.StatusCode) || AlibabaCloud.TeaUtil.Common.Is5xx(response_.StatusCode))
                    {
                        bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                        respMap = AlibabaCloud.OSSUtil.Common.GetErrMessage(bodyStr);
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", respMap.Get("Code")},
                            {"message", respMap.Get("Message")},
                            {"data", new Dictionary<string, object>
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap.Get("RequestId")},
                                {"hostId", respMap.Get("HostId")},
                            }},
                        });
                    }
                    if (_isEnableCrc.Value && !AlibabaCloud.TeaUtil.Common.EqualString(ctx.Get("crc"), response_.Headers.Get("x-oss-hash-crc64ecma")))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", "CrcNotMatched"},
                            {"data", new Dictionary<string, string>
                            {
                                {"clientCrc", ctx.Get("crc")},
                                {"serverCrc", response_.Headers.Get("x-oss-hash-crc64ecma")},
                            }},
                        });
                    }
                    if (_isEnableMD5.Value && !AlibabaCloud.TeaUtil.Common.EqualString(ctx.Get("md5"), response_.Headers.Get("content-md5")))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", "MD5NotMatched"},
                            {"data", new Dictionary<string, string>
                            {
                                {"clientMD5", ctx.Get("md5")},
                                {"serverMD5", response_.Headers.Get("content-md5")},
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

        public void SetUserAgent(string userAgent)
        {
            this._userAgent = userAgent;
        }

        public void AppendUserAgent(string userAgent)
        {
            this._userAgent = _userAgent + " " + userAgent;
        }

        public string GetUserAgent()
        {
            string userAgent = AlibabaCloud.TeaUtil.Common.GetUserAgent(_userAgent);
            return userAgent;
        }

        public string GetAccessKeyId()
        {
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_credential))
            {
                return "";
            }
            string accessKeyId = this._credential.GetAccessKeyId();
            return accessKeyId;
        }

        public async Task<string> GetAccessKeyIdAsync()
        {
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_credential))
            {
                return "";
            }
            string accessKeyId = await this._credential.GetAccessKeyIdAsync();
            return accessKeyId;
        }

        public string GetAccessKeySecret()
        {
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_credential))
            {
                return "";
            }
            string secret = this._credential.GetAccessKeySecret();
            return secret;
        }

        public async Task<string> GetAccessKeySecretAsync()
        {
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_credential))
            {
                return "";
            }
            string secret = await this._credential.GetAccessKeySecretAsync();
            return secret;
        }

    }
}
