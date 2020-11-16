// This file is auto-generated, don't edit it. Thanks.

#include <alibabacloud/credential.hpp>
#include <alibabacloud/oss.hpp>
#include <alibabacloud/ossutil.hpp>
#include <boost/any.hpp>
#include <boost/lexical_cast.hpp>
#include <boost/throw_exception.hpp>
#include <darabonba/core.hpp>
#include <darabonba/file_form.hpp>
#include <darabonba/util.hpp>
#include <darabonba/xml.hpp>
#include <iostream>
#include <map>
#include <vector>

using namespace std;

using namespace Alibabacloud_OSS;

Alibabacloud_OSS::Client::Client(const shared_ptr<Config> &config) {
  if (Darabonba_Util::Client::isUnset<Config>(config)) {
    BOOST_THROW_EXCEPTION(Darabonba::Error(
        map<string, string>({{"name", "ParameterMissing"},
                             {"message", "'config' can not be unset"}})));
  }
  if (Darabonba_Util::Client::empty(config->type)) {
    config->type = make_shared<string>("access_key");
  }
  shared_ptr<Alibabacloud_Credential::Config> credentialConfig =
      make_shared<Alibabacloud_Credential::Config>(map<string, boost::any>(
          {{"accessKeyId", !config->accessKeyId
                               ? boost::any()
                               : boost::any(*config->accessKeyId)},
           {"type", !config->type ? boost::any() : boost::any(*config->type)},
           {"accessKeySecret", !config->accessKeySecret
                                   ? boost::any()
                                   : boost::any(*config->accessKeySecret)},
           {"securityToken", !config->securityToken
                                 ? boost::any()
                                 : boost::any(*config->securityToken)}}));
  _credential = make_shared<Alibabacloud_Credential::Client>(credentialConfig);
  if (Darabonba_Util::Client::isUnset<bool>(config->isEnableMD5)) {
    config->isEnableMD5 = make_shared<bool>(false);
  }
  if (Darabonba_Util::Client::isUnset<bool>(config->isEnableCrc)) {
    config->isEnableCrc = make_shared<bool>(false);
  }
  _endpoint = config->endpoint;
  _protocol = config->protocol;
  _regionId = config->regionId;
  _userAgent = config->userAgent;
  _readTimeout = config->readTimeout;
  _connectTimeout = config->connectTimeout;
  _localAddr = config->localAddr;
  _httpProxy = config->httpProxy;
  _httpsProxy = config->httpsProxy;
  _noProxy = config->noProxy;
  _socks5Proxy = config->socks5Proxy;
  _socks5NetWork = config->socks5NetWork;
  _maxIdleConns = config->maxIdleConns;
  _signatureVersion = config->signatureVersion;
  _addtionalHeaders = config->addtionalHeaders;
  _hostModel = config->hostModel;
  _isEnableMD5 = config->isEnableMD5;
  _isEnableCrc = config->isEnableCrc;
};

PutBucketLifecycleResponse Alibabacloud_OSS::Client::putBucketLifecycle(
    shared_ptr<PutBucketLifecycleRequest> request,
    shared_ptr<Alibabacloud_OSSUtil::RuntimeOptions> runtime) {
  request->validate();
  runtime->validate();
  shared_ptr<map<string, boost::any>> runtime_ = make_shared<
      map<string, boost::any>>(map<string, boost::any>(
      {{"timeouted", boost::any(string("retry"))},
       {"readTimeout", boost::any(Darabonba_Util::Client::defaultNumber(
                           runtime->readTimeout, _readTimeout))},
       {"connectTimeout", boost::any(Darabonba_Util::Client::defaultNumber(
                              runtime->connectTimeout, _connectTimeout))},
       {"localAddr", boost::any(string(Darabonba_Util::Client::defaultString(
                         runtime->localAddr, _localAddr)))},
       {"httpProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                         runtime->httpProxy, _httpProxy)))},
       {"httpsProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                          runtime->httpsProxy, _httpsProxy)))},
       {"noProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                       runtime->noProxy, _noProxy)))},
       {"socks5Proxy", boost::any(string(Darabonba_Util::Client::defaultString(
                           runtime->socks5Proxy, _socks5Proxy)))},
       {"socks5NetWork",
        boost::any(string(Darabonba_Util::Client::defaultString(
            runtime->socks5NetWork, _socks5NetWork)))},
       {"maxIdleConns", boost::any(Darabonba_Util::Client::defaultNumber(
                            runtime->maxIdleConns, _maxIdleConns))},
       {"retry", boost::any(map<string, boost::any>(
                     {{"retryable", !runtime->autoretry
                                        ? boost::any()
                                        : boost::any(*runtime->autoretry)},
                      {"maxAttempts",
                       boost::any(Darabonba_Util::Client::defaultNumber(
                           runtime->maxAttempts, make_shared<int>(3)))}}))},
       {"backoff",
        boost::any(map<string, boost::any>(
            {{"policy",
              boost::any(string(Darabonba_Util::Client::defaultString(
                  runtime->backoffPolicy, make_shared<string>("no"))))},
             {"period", boost::any(Darabonba_Util::Client::defaultNumber(
                            runtime->backoffPeriod, make_shared<int>(1)))}}))},
       {"ignoreSSL", !runtime->ignoreSSL ? boost::any()
                                         : boost::any(*runtime->ignoreSSL)}}));
  shared_ptr<Darabonba::Request> _lastRequest;
  shared_ptr<std::exception> _lastException;
  shared_ptr<int> _now = make_shared<int>(0);
  shared_ptr<int> _retryTimes = make_shared<int>(0);
  while (Darabonba::Core::allowRetry(
      make_shared<boost::any>((*runtime_)["retry"]), _retryTimes, _now)) {
    if (*_retryTimes > 0) {
      shared_ptr<int> _backoffTime =
          make_shared<int>(Darabonba::Core::getBackoffTime(
              make_shared<boost::any>((*runtime_)["backoff"]), _retryTimes));
      if (*_backoffTime > 0) {
        Darabonba::Core::sleep(_backoffTime);
      }
    }
    _retryTimes = make_shared<int>(*_retryTimes + 1);
    try {
      shared_ptr<Darabonba::Request> request_ =
          make_shared<Darabonba::Request>();
      shared_ptr<string> accessKeyId =
          make_shared<string>(_credential->getAccessKeyId());
      shared_ptr<string> accessKeySecret =
          make_shared<string>(_credential->getAccessKeySecret());
      shared_ptr<string> token =
          make_shared<string>(_credential->getSecurityToken());
      shared_ptr<string> reqBody =
          make_shared<string>(Darabonba_XML::Client::toXML(
              make_shared<map<string, boost::any>>(request->body->toMap())));
      request_->protocol = *_protocol;
      request_->method = "PUT";
      request_->pathname = string("/?lifecycle");
      request_->headers = {
          {"host", Alibabacloud_OSSUtil::Client::getHost(
                       request->bucketName, _regionId, _endpoint, _hostModel)},
          {"date", Darabonba_Util::Client::getDateUTCString()},
          {"user-agent", getUserAgent()}};
      if (!Darabonba_Util::Client::empty(token)) {
        request_->headers.insert(
            pair<string, string>("x-oss-security-token", *token));
      }
      request_->body = Darabonba::Converter::toStream(*reqBody);
      request_->headers.insert(pair<string, string>(
          "authorization",
          Alibabacloud_OSSUtil::Client::getSignature(
              request_, request->bucketName, accessKeyId, accessKeySecret,
              _signatureVersion, _addtionalHeaders)));
      _lastRequest = request_;
      shared_ptr<Darabonba::Response> response_ =
          make_shared<Darabonba::Response>(
              Darabonba::Core::doAction(request_, runtime_));
      shared_ptr<map<string, boost::any>> respMap;
      shared_ptr<string> bodyStr;
      if (Darabonba_Util::Client::is4xx(
              make_shared<int>(response_->statusCode)) ||
          Darabonba_Util::Client::is5xx(
              make_shared<int>(response_->statusCode))) {
        bodyStr = make_shared<string>(
            Darabonba_Util::Client::readAsString(response_->body));
        respMap = make_shared<map<string, boost::any>>(
            Alibabacloud_OSSUtil::Client::getErrMessage(bodyStr));
        BOOST_THROW_EXCEPTION(Darabonba::Error(map<string, boost::any>(
            {{"code", (*respMap)["Code"]},
             {"message", (*respMap)["Message"]},
             {"data", boost::any(map<string, boost::any>(
                          {{"httpCode", boost::any(response_->statusCode)},
                           {"requestId", (*respMap)["RequestId"]},
                           {"hostId", (*respMap)["HostId"]}}))}})));
      }
      return PutBucketLifecycleResponse(
          Darabonba::Converter::toGenericMap(Darabonba::Converter::merge(
              map<string, string>(), response_->headers)));
    } catch (std::exception &e) {
      if (Darabonba::Core::isRetryable(e)) {
        _lastException = make_shared<std::exception>(e);
        continue;
      }
      BOOST_THROW_EXCEPTION(e);
    }
  }
  BOOST_THROW_EXCEPTION(
      Darabonba::UnretryableError(_lastRequest, _lastException));
}

DeleteMultipleObjectsResponse Alibabacloud_OSS::Client::deleteMultipleObjects(
    shared_ptr<DeleteMultipleObjectsRequest> request,
    shared_ptr<Alibabacloud_OSSUtil::RuntimeOptions> runtime) {
  request->validate();
  runtime->validate();
  shared_ptr<map<string, boost::any>> runtime_ = make_shared<
      map<string, boost::any>>(map<string, boost::any>(
      {{"timeouted", boost::any(string("retry"))},
       {"readTimeout", boost::any(Darabonba_Util::Client::defaultNumber(
                           runtime->readTimeout, _readTimeout))},
       {"connectTimeout", boost::any(Darabonba_Util::Client::defaultNumber(
                              runtime->connectTimeout, _connectTimeout))},
       {"localAddr", boost::any(string(Darabonba_Util::Client::defaultString(
                         runtime->localAddr, _localAddr)))},
       {"httpProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                         runtime->httpProxy, _httpProxy)))},
       {"httpsProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                          runtime->httpsProxy, _httpsProxy)))},
       {"noProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                       runtime->noProxy, _noProxy)))},
       {"socks5Proxy", boost::any(string(Darabonba_Util::Client::defaultString(
                           runtime->socks5Proxy, _socks5Proxy)))},
       {"socks5NetWork",
        boost::any(string(Darabonba_Util::Client::defaultString(
            runtime->socks5NetWork, _socks5NetWork)))},
       {"maxIdleConns", boost::any(Darabonba_Util::Client::defaultNumber(
                            runtime->maxIdleConns, _maxIdleConns))},
       {"retry", boost::any(map<string, boost::any>(
                     {{"retryable", !runtime->autoretry
                                        ? boost::any()
                                        : boost::any(*runtime->autoretry)},
                      {"maxAttempts",
                       boost::any(Darabonba_Util::Client::defaultNumber(
                           runtime->maxAttempts, make_shared<int>(3)))}}))},
       {"backoff",
        boost::any(map<string, boost::any>(
            {{"policy",
              boost::any(string(Darabonba_Util::Client::defaultString(
                  runtime->backoffPolicy, make_shared<string>("no"))))},
             {"period", boost::any(Darabonba_Util::Client::defaultNumber(
                            runtime->backoffPeriod, make_shared<int>(1)))}}))},
       {"ignoreSSL", !runtime->ignoreSSL ? boost::any()
                                         : boost::any(*runtime->ignoreSSL)}}));
  shared_ptr<Darabonba::Request> _lastRequest;
  shared_ptr<std::exception> _lastException;
  shared_ptr<int> _now = make_shared<int>(0);
  shared_ptr<int> _retryTimes = make_shared<int>(0);
  while (Darabonba::Core::allowRetry(
      make_shared<boost::any>((*runtime_)["retry"]), _retryTimes, _now)) {
    if (*_retryTimes > 0) {
      shared_ptr<int> _backoffTime =
          make_shared<int>(Darabonba::Core::getBackoffTime(
              make_shared<boost::any>((*runtime_)["backoff"]), _retryTimes));
      if (*_backoffTime > 0) {
        Darabonba::Core::sleep(_backoffTime);
      }
    }
    _retryTimes = make_shared<int>(*_retryTimes + 1);
    try {
      shared_ptr<Darabonba::Request> request_ =
          make_shared<Darabonba::Request>();
      shared_ptr<string> accessKeyId =
          make_shared<string>(_credential->getAccessKeyId());
      shared_ptr<string> accessKeySecret =
          make_shared<string>(_credential->getAccessKeySecret());
      shared_ptr<string> token =
          make_shared<string>(_credential->getSecurityToken());
      shared_ptr<string> reqBody =
          make_shared<string>(Darabonba_XML::Client::toXML(
              make_shared<map<string, boost::any>>(request->body->toMap())));
      request_->protocol = *_protocol;
      request_->method = "POST";
      request_->pathname = string("/?delete");
      request_->headers = Darabonba::Converter::merge(
          map<string, string>(
              {{"host",
                Alibabacloud_OSSUtil::Client::getHost(
                    request->bucketName, _regionId, _endpoint, _hostModel)},
               {"date", Darabonba_Util::Client::getDateUTCString()},
               {"user-agent", getUserAgent()}}),
          Darabonba_Util::Client::stringifyMapValue(
              make_shared<map<string, boost::any>>(request->header->toMap())));
      if (!Darabonba_Util::Client::empty(token)) {
        request_->headers.insert(
            pair<string, string>("x-oss-security-token", *token));
      }
      request_->body = Darabonba::Converter::toStream(*reqBody);
      if (!Darabonba_Util::Client::isUnset<DeleteMultipleObjectsRequestHeader>(
              request->header) &&
          !Darabonba_Util::Client::empty(request->header->contentMD5)) {
        request_->headers.insert(
            pair<string, string>("content-md5", *request->header->contentMD5));
      } else {
        request_->headers.insert(pair<string, string>(
            "content-md5", Alibabacloud_OSSUtil::Client::getContentMD5(
                               reqBody, _isEnableMD5)));
      }
      request_->headers.insert(pair<string, string>(
          "authorization",
          Alibabacloud_OSSUtil::Client::getSignature(
              request_, request->bucketName, accessKeyId, accessKeySecret,
              _signatureVersion, _addtionalHeaders)));
      _lastRequest = request_;
      shared_ptr<Darabonba::Response> response_ =
          make_shared<Darabonba::Response>(
              Darabonba::Core::doAction(request_, runtime_));
      shared_ptr<map<string, boost::any>> respMap;
      shared_ptr<string> bodyStr;
      if (Darabonba_Util::Client::is4xx(
              make_shared<int>(response_->statusCode)) ||
          Darabonba_Util::Client::is5xx(
              make_shared<int>(response_->statusCode))) {
        bodyStr = make_shared<string>(
            Darabonba_Util::Client::readAsString(response_->body));
        respMap = make_shared<map<string, boost::any>>(
            Alibabacloud_OSSUtil::Client::getErrMessage(bodyStr));
        BOOST_THROW_EXCEPTION(Darabonba::Error(map<string, boost::any>(
            {{"code", (*respMap)["Code"]},
             {"message", (*respMap)["Message"]},
             {"data", boost::any(map<string, boost::any>(
                          {{"httpCode", boost::any(response_->statusCode)},
                           {"requestId", (*respMap)["RequestId"]},
                           {"hostId", (*respMap)["HostId"]}}))}})));
      }
      bodyStr = make_shared<string>(
          Darabonba_Util::Client::readAsString(response_->body));
      respMap = make_shared<map<string, boost::any>>(
          Darabonba_XML::Client::parseXml(bodyStr, nullptr));
      return DeleteMultipleObjectsResponse(Darabonba::Converter::merge(
          map<string, boost::any>(
              {{"DeleteResult", (*respMap)["DeleteResult"]}}),
          Darabonba::Converter::toGenericMap(response_->headers)));
    } catch (std::exception &e) {
      if (Darabonba::Core::isRetryable(e)) {
        _lastException = make_shared<std::exception>(e);
        continue;
      }
      BOOST_THROW_EXCEPTION(e);
    }
  }
  BOOST_THROW_EXCEPTION(
      Darabonba::UnretryableError(_lastRequest, _lastException));
}

PutBucketRefererResponse Alibabacloud_OSS::Client::putBucketReferer(
    shared_ptr<PutBucketRefererRequest> request,
    shared_ptr<Alibabacloud_OSSUtil::RuntimeOptions> runtime) {
  request->validate();
  runtime->validate();
  shared_ptr<map<string, boost::any>> runtime_ = make_shared<
      map<string, boost::any>>(map<string, boost::any>(
      {{"timeouted", boost::any(string("retry"))},
       {"readTimeout", boost::any(Darabonba_Util::Client::defaultNumber(
                           runtime->readTimeout, _readTimeout))},
       {"connectTimeout", boost::any(Darabonba_Util::Client::defaultNumber(
                              runtime->connectTimeout, _connectTimeout))},
       {"localAddr", boost::any(string(Darabonba_Util::Client::defaultString(
                         runtime->localAddr, _localAddr)))},
       {"httpProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                         runtime->httpProxy, _httpProxy)))},
       {"httpsProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                          runtime->httpsProxy, _httpsProxy)))},
       {"noProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                       runtime->noProxy, _noProxy)))},
       {"socks5Proxy", boost::any(string(Darabonba_Util::Client::defaultString(
                           runtime->socks5Proxy, _socks5Proxy)))},
       {"socks5NetWork",
        boost::any(string(Darabonba_Util::Client::defaultString(
            runtime->socks5NetWork, _socks5NetWork)))},
       {"maxIdleConns", boost::any(Darabonba_Util::Client::defaultNumber(
                            runtime->maxIdleConns, _maxIdleConns))},
       {"retry", boost::any(map<string, boost::any>(
                     {{"retryable", !runtime->autoretry
                                        ? boost::any()
                                        : boost::any(*runtime->autoretry)},
                      {"maxAttempts",
                       boost::any(Darabonba_Util::Client::defaultNumber(
                           runtime->maxAttempts, make_shared<int>(3)))}}))},
       {"backoff",
        boost::any(map<string, boost::any>(
            {{"policy",
              boost::any(string(Darabonba_Util::Client::defaultString(
                  runtime->backoffPolicy, make_shared<string>("no"))))},
             {"period", boost::any(Darabonba_Util::Client::defaultNumber(
                            runtime->backoffPeriod, make_shared<int>(1)))}}))},
       {"ignoreSSL", !runtime->ignoreSSL ? boost::any()
                                         : boost::any(*runtime->ignoreSSL)}}));
  shared_ptr<Darabonba::Request> _lastRequest;
  shared_ptr<std::exception> _lastException;
  shared_ptr<int> _now = make_shared<int>(0);
  shared_ptr<int> _retryTimes = make_shared<int>(0);
  while (Darabonba::Core::allowRetry(
      make_shared<boost::any>((*runtime_)["retry"]), _retryTimes, _now)) {
    if (*_retryTimes > 0) {
      shared_ptr<int> _backoffTime =
          make_shared<int>(Darabonba::Core::getBackoffTime(
              make_shared<boost::any>((*runtime_)["backoff"]), _retryTimes));
      if (*_backoffTime > 0) {
        Darabonba::Core::sleep(_backoffTime);
      }
    }
    _retryTimes = make_shared<int>(*_retryTimes + 1);
    try {
      shared_ptr<Darabonba::Request> request_ =
          make_shared<Darabonba::Request>();
      shared_ptr<string> accessKeyId =
          make_shared<string>(_credential->getAccessKeyId());
      shared_ptr<string> accessKeySecret =
          make_shared<string>(_credential->getAccessKeySecret());
      shared_ptr<string> token =
          make_shared<string>(_credential->getSecurityToken());
      shared_ptr<string> reqBody =
          make_shared<string>(Darabonba_XML::Client::toXML(
              make_shared<map<string, boost::any>>(request->body->toMap())));
      request_->protocol = *_protocol;
      request_->method = "PUT";
      request_->pathname = string("/?referer");
      request_->headers = {
          {"host", Alibabacloud_OSSUtil::Client::getHost(
                       request->bucketName, _regionId, _endpoint, _hostModel)},
          {"date", Darabonba_Util::Client::getDateUTCString()},
          {"user-agent", getUserAgent()}};
      if (!Darabonba_Util::Client::empty(token)) {
        request_->headers.insert(
            pair<string, string>("x-oss-security-token", *token));
      }
      request_->body = Darabonba::Converter::toStream(*reqBody);
      request_->headers.insert(pair<string, string>(
          "authorization",
          Alibabacloud_OSSUtil::Client::getSignature(
              request_, request->bucketName, accessKeyId, accessKeySecret,
              _signatureVersion, _addtionalHeaders)));
      _lastRequest = request_;
      shared_ptr<Darabonba::Response> response_ =
          make_shared<Darabonba::Response>(
              Darabonba::Core::doAction(request_, runtime_));
      shared_ptr<map<string, boost::any>> respMap;
      shared_ptr<string> bodyStr;
      if (Darabonba_Util::Client::is4xx(
              make_shared<int>(response_->statusCode)) ||
          Darabonba_Util::Client::is5xx(
              make_shared<int>(response_->statusCode))) {
        bodyStr = make_shared<string>(
            Darabonba_Util::Client::readAsString(response_->body));
        respMap = make_shared<map<string, boost::any>>(
            Alibabacloud_OSSUtil::Client::getErrMessage(bodyStr));
        BOOST_THROW_EXCEPTION(Darabonba::Error(map<string, boost::any>(
            {{"code", (*respMap)["Code"]},
             {"message", (*respMap)["Message"]},
             {"data", boost::any(map<string, boost::any>(
                          {{"httpCode", boost::any(response_->statusCode)},
                           {"requestId", (*respMap)["RequestId"]},
                           {"hostId", (*respMap)["HostId"]}}))}})));
      }
      return PutBucketRefererResponse(
          Darabonba::Converter::toGenericMap(Darabonba::Converter::merge(
              map<string, string>(), response_->headers)));
    } catch (std::exception &e) {
      if (Darabonba::Core::isRetryable(e)) {
        _lastException = make_shared<std::exception>(e);
        continue;
      }
      BOOST_THROW_EXCEPTION(e);
    }
  }
  BOOST_THROW_EXCEPTION(
      Darabonba::UnretryableError(_lastRequest, _lastException));
}

PutBucketWebsiteResponse Alibabacloud_OSS::Client::putBucketWebsite(
    shared_ptr<PutBucketWebsiteRequest> request,
    shared_ptr<Alibabacloud_OSSUtil::RuntimeOptions> runtime) {
  request->validate();
  runtime->validate();
  shared_ptr<map<string, boost::any>> runtime_ = make_shared<
      map<string, boost::any>>(map<string, boost::any>(
      {{"timeouted", boost::any(string("retry"))},
       {"readTimeout", boost::any(Darabonba_Util::Client::defaultNumber(
                           runtime->readTimeout, _readTimeout))},
       {"connectTimeout", boost::any(Darabonba_Util::Client::defaultNumber(
                              runtime->connectTimeout, _connectTimeout))},
       {"localAddr", boost::any(string(Darabonba_Util::Client::defaultString(
                         runtime->localAddr, _localAddr)))},
       {"httpProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                         runtime->httpProxy, _httpProxy)))},
       {"httpsProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                          runtime->httpsProxy, _httpsProxy)))},
       {"noProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                       runtime->noProxy, _noProxy)))},
       {"socks5Proxy", boost::any(string(Darabonba_Util::Client::defaultString(
                           runtime->socks5Proxy, _socks5Proxy)))},
       {"socks5NetWork",
        boost::any(string(Darabonba_Util::Client::defaultString(
            runtime->socks5NetWork, _socks5NetWork)))},
       {"maxIdleConns", boost::any(Darabonba_Util::Client::defaultNumber(
                            runtime->maxIdleConns, _maxIdleConns))},
       {"retry", boost::any(map<string, boost::any>(
                     {{"retryable", !runtime->autoretry
                                        ? boost::any()
                                        : boost::any(*runtime->autoretry)},
                      {"maxAttempts",
                       boost::any(Darabonba_Util::Client::defaultNumber(
                           runtime->maxAttempts, make_shared<int>(3)))}}))},
       {"backoff",
        boost::any(map<string, boost::any>(
            {{"policy",
              boost::any(string(Darabonba_Util::Client::defaultString(
                  runtime->backoffPolicy, make_shared<string>("no"))))},
             {"period", boost::any(Darabonba_Util::Client::defaultNumber(
                            runtime->backoffPeriod, make_shared<int>(1)))}}))},
       {"ignoreSSL", !runtime->ignoreSSL ? boost::any()
                                         : boost::any(*runtime->ignoreSSL)}}));
  shared_ptr<Darabonba::Request> _lastRequest;
  shared_ptr<std::exception> _lastException;
  shared_ptr<int> _now = make_shared<int>(0);
  shared_ptr<int> _retryTimes = make_shared<int>(0);
  while (Darabonba::Core::allowRetry(
      make_shared<boost::any>((*runtime_)["retry"]), _retryTimes, _now)) {
    if (*_retryTimes > 0) {
      shared_ptr<int> _backoffTime =
          make_shared<int>(Darabonba::Core::getBackoffTime(
              make_shared<boost::any>((*runtime_)["backoff"]), _retryTimes));
      if (*_backoffTime > 0) {
        Darabonba::Core::sleep(_backoffTime);
      }
    }
    _retryTimes = make_shared<int>(*_retryTimes + 1);
    try {
      shared_ptr<Darabonba::Request> request_ =
          make_shared<Darabonba::Request>();
      shared_ptr<string> accessKeyId =
          make_shared<string>(_credential->getAccessKeyId());
      shared_ptr<string> accessKeySecret =
          make_shared<string>(_credential->getAccessKeySecret());
      shared_ptr<string> token =
          make_shared<string>(_credential->getSecurityToken());
      shared_ptr<string> reqBody =
          make_shared<string>(Darabonba_XML::Client::toXML(
              make_shared<map<string, boost::any>>(request->body->toMap())));
      request_->protocol = *_protocol;
      request_->method = "PUT";
      request_->pathname = string("/?website");
      request_->headers = {
          {"host", Alibabacloud_OSSUtil::Client::getHost(
                       request->bucketName, _regionId, _endpoint, _hostModel)},
          {"date", Darabonba_Util::Client::getDateUTCString()},
          {"user-agent", getUserAgent()}};
      if (!Darabonba_Util::Client::empty(token)) {
        request_->headers.insert(
            pair<string, string>("x-oss-security-token", *token));
      }
      request_->body = Darabonba::Converter::toStream(*reqBody);
      request_->headers.insert(pair<string, string>(
          "authorization",
          Alibabacloud_OSSUtil::Client::getSignature(
              request_, request->bucketName, accessKeyId, accessKeySecret,
              _signatureVersion, _addtionalHeaders)));
      _lastRequest = request_;
      shared_ptr<Darabonba::Response> response_ =
          make_shared<Darabonba::Response>(
              Darabonba::Core::doAction(request_, runtime_));
      shared_ptr<map<string, boost::any>> respMap;
      shared_ptr<string> bodyStr;
      if (Darabonba_Util::Client::is4xx(
              make_shared<int>(response_->statusCode)) ||
          Darabonba_Util::Client::is5xx(
              make_shared<int>(response_->statusCode))) {
        bodyStr = make_shared<string>(
            Darabonba_Util::Client::readAsString(response_->body));
        respMap = make_shared<map<string, boost::any>>(
            Alibabacloud_OSSUtil::Client::getErrMessage(bodyStr));
        BOOST_THROW_EXCEPTION(Darabonba::Error(map<string, boost::any>(
            {{"code", (*respMap)["Code"]},
             {"message", (*respMap)["Message"]},
             {"data", boost::any(map<string, boost::any>(
                          {{"httpCode", boost::any(response_->statusCode)},
                           {"requestId", (*respMap)["RequestId"]},
                           {"hostId", (*respMap)["HostId"]}}))}})));
      }
      return PutBucketWebsiteResponse(
          Darabonba::Converter::toGenericMap(Darabonba::Converter::merge(
              map<string, string>(), response_->headers)));
    } catch (std::exception &e) {
      if (Darabonba::Core::isRetryable(e)) {
        _lastException = make_shared<std::exception>(e);
        continue;
      }
      BOOST_THROW_EXCEPTION(e);
    }
  }
  BOOST_THROW_EXCEPTION(
      Darabonba::UnretryableError(_lastRequest, _lastException));
}

CompleteMultipartUploadResponse
Alibabacloud_OSS::Client::completeMultipartUpload(
    shared_ptr<CompleteMultipartUploadRequest> request,
    shared_ptr<Alibabacloud_OSSUtil::RuntimeOptions> runtime) {
  request->validate();
  runtime->validate();
  shared_ptr<map<string, boost::any>> runtime_ = make_shared<
      map<string, boost::any>>(map<string, boost::any>(
      {{"timeouted", boost::any(string("retry"))},
       {"readTimeout", boost::any(Darabonba_Util::Client::defaultNumber(
                           runtime->readTimeout, _readTimeout))},
       {"connectTimeout", boost::any(Darabonba_Util::Client::defaultNumber(
                              runtime->connectTimeout, _connectTimeout))},
       {"localAddr", boost::any(string(Darabonba_Util::Client::defaultString(
                         runtime->localAddr, _localAddr)))},
       {"httpProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                         runtime->httpProxy, _httpProxy)))},
       {"httpsProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                          runtime->httpsProxy, _httpsProxy)))},
       {"noProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                       runtime->noProxy, _noProxy)))},
       {"socks5Proxy", boost::any(string(Darabonba_Util::Client::defaultString(
                           runtime->socks5Proxy, _socks5Proxy)))},
       {"socks5NetWork",
        boost::any(string(Darabonba_Util::Client::defaultString(
            runtime->socks5NetWork, _socks5NetWork)))},
       {"maxIdleConns", boost::any(Darabonba_Util::Client::defaultNumber(
                            runtime->maxIdleConns, _maxIdleConns))},
       {"retry", boost::any(map<string, boost::any>(
                     {{"retryable", !runtime->autoretry
                                        ? boost::any()
                                        : boost::any(*runtime->autoretry)},
                      {"maxAttempts",
                       boost::any(Darabonba_Util::Client::defaultNumber(
                           runtime->maxAttempts, make_shared<int>(3)))}}))},
       {"backoff",
        boost::any(map<string, boost::any>(
            {{"policy",
              boost::any(string(Darabonba_Util::Client::defaultString(
                  runtime->backoffPolicy, make_shared<string>("no"))))},
             {"period", boost::any(Darabonba_Util::Client::defaultNumber(
                            runtime->backoffPeriod, make_shared<int>(1)))}}))},
       {"ignoreSSL", !runtime->ignoreSSL ? boost::any()
                                         : boost::any(*runtime->ignoreSSL)}}));
  shared_ptr<Darabonba::Request> _lastRequest;
  shared_ptr<std::exception> _lastException;
  shared_ptr<int> _now = make_shared<int>(0);
  shared_ptr<int> _retryTimes = make_shared<int>(0);
  while (Darabonba::Core::allowRetry(
      make_shared<boost::any>((*runtime_)["retry"]), _retryTimes, _now)) {
    if (*_retryTimes > 0) {
      shared_ptr<int> _backoffTime =
          make_shared<int>(Darabonba::Core::getBackoffTime(
              make_shared<boost::any>((*runtime_)["backoff"]), _retryTimes));
      if (*_backoffTime > 0) {
        Darabonba::Core::sleep(_backoffTime);
      }
    }
    _retryTimes = make_shared<int>(*_retryTimes + 1);
    try {
      shared_ptr<Darabonba::Request> request_ =
          make_shared<Darabonba::Request>();
      shared_ptr<string> accessKeyId =
          make_shared<string>(_credential->getAccessKeyId());
      shared_ptr<string> accessKeySecret =
          make_shared<string>(_credential->getAccessKeySecret());
      shared_ptr<string> token =
          make_shared<string>(_credential->getSecurityToken());
      shared_ptr<string> reqBody =
          make_shared<string>(Darabonba_XML::Client::toXML(
              make_shared<map<string, boost::any>>(request->body->toMap())));
      request_->protocol = *_protocol;
      request_->method = "POST";
      request_->pathname = string("/" + *request->objectName + "");
      request_->headers = {
          {"host", Alibabacloud_OSSUtil::Client::getHost(
                       request->bucketName, _regionId, _endpoint, _hostModel)},
          {"date", Darabonba_Util::Client::getDateUTCString()},
          {"user-agent", getUserAgent()}};
      if (!Darabonba_Util::Client::empty(token)) {
        request_->headers.insert(
            pair<string, string>("x-oss-security-token", *token));
      }
      request_->query = Darabonba_Util::Client::stringifyMapValue(
          make_shared<map<string, boost::any>>(request->filter->toMap()));
      request_->body = Darabonba::Converter::toStream(*reqBody);
      request_->headers.insert(pair<string, string>(
          "authorization",
          Alibabacloud_OSSUtil::Client::getSignature(
              request_, request->bucketName, accessKeyId, accessKeySecret,
              _signatureVersion, _addtionalHeaders)));
      _lastRequest = request_;
      shared_ptr<Darabonba::Response> response_ =
          make_shared<Darabonba::Response>(
              Darabonba::Core::doAction(request_, runtime_));
      shared_ptr<map<string, boost::any>> respMap;
      shared_ptr<string> bodyStr;
      if (Darabonba_Util::Client::is4xx(
              make_shared<int>(response_->statusCode)) ||
          Darabonba_Util::Client::is5xx(
              make_shared<int>(response_->statusCode))) {
        bodyStr = make_shared<string>(
            Darabonba_Util::Client::readAsString(response_->body));
        respMap = make_shared<map<string, boost::any>>(
            Alibabacloud_OSSUtil::Client::getErrMessage(bodyStr));
        BOOST_THROW_EXCEPTION(Darabonba::Error(map<string, boost::any>(
            {{"code", (*respMap)["Code"]},
             {"message", (*respMap)["Message"]},
             {"data", boost::any(map<string, boost::any>(
                          {{"httpCode", boost::any(response_->statusCode)},
                           {"requestId", (*respMap)["RequestId"]},
                           {"hostId", (*respMap)["HostId"]}}))}})));
      }
      bodyStr = make_shared<string>(
          Darabonba_Util::Client::readAsString(response_->body));
      respMap = make_shared<map<string, boost::any>>(
          Darabonba_XML::Client::parseXml(bodyStr, nullptr));
      return CompleteMultipartUploadResponse(Darabonba::Converter::merge(
          map<string, boost::any>(
              {{"CompleteMultipartUploadResult",
                (*respMap)["CompleteMultipartUploadResult"]}}),
          Darabonba::Converter::toGenericMap(response_->headers)));
    } catch (std::exception &e) {
      if (Darabonba::Core::isRetryable(e)) {
        _lastException = make_shared<std::exception>(e);
        continue;
      }
      BOOST_THROW_EXCEPTION(e);
    }
  }
  BOOST_THROW_EXCEPTION(
      Darabonba::UnretryableError(_lastRequest, _lastException));
}

PutBucketLoggingResponse Alibabacloud_OSS::Client::putBucketLogging(
    shared_ptr<PutBucketLoggingRequest> request,
    shared_ptr<Alibabacloud_OSSUtil::RuntimeOptions> runtime) {
  request->validate();
  runtime->validate();
  shared_ptr<map<string, boost::any>> runtime_ = make_shared<
      map<string, boost::any>>(map<string, boost::any>(
      {{"timeouted", boost::any(string("retry"))},
       {"readTimeout", boost::any(Darabonba_Util::Client::defaultNumber(
                           runtime->readTimeout, _readTimeout))},
       {"connectTimeout", boost::any(Darabonba_Util::Client::defaultNumber(
                              runtime->connectTimeout, _connectTimeout))},
       {"localAddr", boost::any(string(Darabonba_Util::Client::defaultString(
                         runtime->localAddr, _localAddr)))},
       {"httpProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                         runtime->httpProxy, _httpProxy)))},
       {"httpsProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                          runtime->httpsProxy, _httpsProxy)))},
       {"noProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                       runtime->noProxy, _noProxy)))},
       {"socks5Proxy", boost::any(string(Darabonba_Util::Client::defaultString(
                           runtime->socks5Proxy, _socks5Proxy)))},
       {"socks5NetWork",
        boost::any(string(Darabonba_Util::Client::defaultString(
            runtime->socks5NetWork, _socks5NetWork)))},
       {"maxIdleConns", boost::any(Darabonba_Util::Client::defaultNumber(
                            runtime->maxIdleConns, _maxIdleConns))},
       {"retry", boost::any(map<string, boost::any>(
                     {{"retryable", !runtime->autoretry
                                        ? boost::any()
                                        : boost::any(*runtime->autoretry)},
                      {"maxAttempts",
                       boost::any(Darabonba_Util::Client::defaultNumber(
                           runtime->maxAttempts, make_shared<int>(3)))}}))},
       {"backoff",
        boost::any(map<string, boost::any>(
            {{"policy",
              boost::any(string(Darabonba_Util::Client::defaultString(
                  runtime->backoffPolicy, make_shared<string>("no"))))},
             {"period", boost::any(Darabonba_Util::Client::defaultNumber(
                            runtime->backoffPeriod, make_shared<int>(1)))}}))},
       {"ignoreSSL", !runtime->ignoreSSL ? boost::any()
                                         : boost::any(*runtime->ignoreSSL)}}));
  shared_ptr<Darabonba::Request> _lastRequest;
  shared_ptr<std::exception> _lastException;
  shared_ptr<int> _now = make_shared<int>(0);
  shared_ptr<int> _retryTimes = make_shared<int>(0);
  while (Darabonba::Core::allowRetry(
      make_shared<boost::any>((*runtime_)["retry"]), _retryTimes, _now)) {
    if (*_retryTimes > 0) {
      shared_ptr<int> _backoffTime =
          make_shared<int>(Darabonba::Core::getBackoffTime(
              make_shared<boost::any>((*runtime_)["backoff"]), _retryTimes));
      if (*_backoffTime > 0) {
        Darabonba::Core::sleep(_backoffTime);
      }
    }
    _retryTimes = make_shared<int>(*_retryTimes + 1);
    try {
      shared_ptr<Darabonba::Request> request_ =
          make_shared<Darabonba::Request>();
      shared_ptr<string> accessKeyId =
          make_shared<string>(_credential->getAccessKeyId());
      shared_ptr<string> accessKeySecret =
          make_shared<string>(_credential->getAccessKeySecret());
      shared_ptr<string> token =
          make_shared<string>(_credential->getSecurityToken());
      shared_ptr<string> reqBody =
          make_shared<string>(Darabonba_XML::Client::toXML(
              make_shared<map<string, boost::any>>(request->body->toMap())));
      request_->protocol = *_protocol;
      request_->method = "PUT";
      request_->pathname = string("/?logging");
      request_->headers = {
          {"host", Alibabacloud_OSSUtil::Client::getHost(
                       request->bucketName, _regionId, _endpoint, _hostModel)},
          {"date", Darabonba_Util::Client::getDateUTCString()},
          {"user-agent", getUserAgent()}};
      if (!Darabonba_Util::Client::empty(token)) {
        request_->headers.insert(
            pair<string, string>("x-oss-security-token", *token));
      }
      request_->body = Darabonba::Converter::toStream(*reqBody);
      request_->headers.insert(pair<string, string>(
          "authorization",
          Alibabacloud_OSSUtil::Client::getSignature(
              request_, request->bucketName, accessKeyId, accessKeySecret,
              _signatureVersion, _addtionalHeaders)));
      _lastRequest = request_;
      shared_ptr<Darabonba::Response> response_ =
          make_shared<Darabonba::Response>(
              Darabonba::Core::doAction(request_, runtime_));
      shared_ptr<map<string, boost::any>> respMap;
      shared_ptr<string> bodyStr;
      if (Darabonba_Util::Client::is4xx(
              make_shared<int>(response_->statusCode)) ||
          Darabonba_Util::Client::is5xx(
              make_shared<int>(response_->statusCode))) {
        bodyStr = make_shared<string>(
            Darabonba_Util::Client::readAsString(response_->body));
        respMap = make_shared<map<string, boost::any>>(
            Alibabacloud_OSSUtil::Client::getErrMessage(bodyStr));
        BOOST_THROW_EXCEPTION(Darabonba::Error(map<string, boost::any>(
            {{"code", (*respMap)["Code"]},
             {"message", (*respMap)["Message"]},
             {"data", boost::any(map<string, boost::any>(
                          {{"httpCode", boost::any(response_->statusCode)},
                           {"requestId", (*respMap)["RequestId"]},
                           {"hostId", (*respMap)["HostId"]}}))}})));
      }
      return PutBucketLoggingResponse(
          Darabonba::Converter::toGenericMap(Darabonba::Converter::merge(
              map<string, string>(), response_->headers)));
    } catch (std::exception &e) {
      if (Darabonba::Core::isRetryable(e)) {
        _lastException = make_shared<std::exception>(e);
        continue;
      }
      BOOST_THROW_EXCEPTION(e);
    }
  }
  BOOST_THROW_EXCEPTION(
      Darabonba::UnretryableError(_lastRequest, _lastException));
}

PutBucketRequestPaymentResponse
Alibabacloud_OSS::Client::putBucketRequestPayment(
    shared_ptr<PutBucketRequestPaymentRequest> request,
    shared_ptr<Alibabacloud_OSSUtil::RuntimeOptions> runtime) {
  request->validate();
  runtime->validate();
  shared_ptr<map<string, boost::any>> runtime_ = make_shared<
      map<string, boost::any>>(map<string, boost::any>(
      {{"timeouted", boost::any(string("retry"))},
       {"readTimeout", boost::any(Darabonba_Util::Client::defaultNumber(
                           runtime->readTimeout, _readTimeout))},
       {"connectTimeout", boost::any(Darabonba_Util::Client::defaultNumber(
                              runtime->connectTimeout, _connectTimeout))},
       {"localAddr", boost::any(string(Darabonba_Util::Client::defaultString(
                         runtime->localAddr, _localAddr)))},
       {"httpProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                         runtime->httpProxy, _httpProxy)))},
       {"httpsProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                          runtime->httpsProxy, _httpsProxy)))},
       {"noProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                       runtime->noProxy, _noProxy)))},
       {"socks5Proxy", boost::any(string(Darabonba_Util::Client::defaultString(
                           runtime->socks5Proxy, _socks5Proxy)))},
       {"socks5NetWork",
        boost::any(string(Darabonba_Util::Client::defaultString(
            runtime->socks5NetWork, _socks5NetWork)))},
       {"maxIdleConns", boost::any(Darabonba_Util::Client::defaultNumber(
                            runtime->maxIdleConns, _maxIdleConns))},
       {"retry", boost::any(map<string, boost::any>(
                     {{"retryable", !runtime->autoretry
                                        ? boost::any()
                                        : boost::any(*runtime->autoretry)},
                      {"maxAttempts",
                       boost::any(Darabonba_Util::Client::defaultNumber(
                           runtime->maxAttempts, make_shared<int>(3)))}}))},
       {"backoff",
        boost::any(map<string, boost::any>(
            {{"policy",
              boost::any(string(Darabonba_Util::Client::defaultString(
                  runtime->backoffPolicy, make_shared<string>("no"))))},
             {"period", boost::any(Darabonba_Util::Client::defaultNumber(
                            runtime->backoffPeriod, make_shared<int>(1)))}}))},
       {"ignoreSSL", !runtime->ignoreSSL ? boost::any()
                                         : boost::any(*runtime->ignoreSSL)}}));
  shared_ptr<Darabonba::Request> _lastRequest;
  shared_ptr<std::exception> _lastException;
  shared_ptr<int> _now = make_shared<int>(0);
  shared_ptr<int> _retryTimes = make_shared<int>(0);
  while (Darabonba::Core::allowRetry(
      make_shared<boost::any>((*runtime_)["retry"]), _retryTimes, _now)) {
    if (*_retryTimes > 0) {
      shared_ptr<int> _backoffTime =
          make_shared<int>(Darabonba::Core::getBackoffTime(
              make_shared<boost::any>((*runtime_)["backoff"]), _retryTimes));
      if (*_backoffTime > 0) {
        Darabonba::Core::sleep(_backoffTime);
      }
    }
    _retryTimes = make_shared<int>(*_retryTimes + 1);
    try {
      shared_ptr<Darabonba::Request> request_ =
          make_shared<Darabonba::Request>();
      shared_ptr<string> accessKeyId =
          make_shared<string>(_credential->getAccessKeyId());
      shared_ptr<string> accessKeySecret =
          make_shared<string>(_credential->getAccessKeySecret());
      shared_ptr<string> token =
          make_shared<string>(_credential->getSecurityToken());
      shared_ptr<string> reqBody =
          make_shared<string>(Darabonba_XML::Client::toXML(
              make_shared<map<string, boost::any>>(request->body->toMap())));
      request_->protocol = *_protocol;
      request_->method = "PUT";
      request_->pathname = string("/?requestPayment");
      request_->headers = {
          {"host", Alibabacloud_OSSUtil::Client::getHost(
                       request->bucketName, _regionId, _endpoint, _hostModel)},
          {"date", Darabonba_Util::Client::getDateUTCString()},
          {"user-agent", getUserAgent()}};
      if (!Darabonba_Util::Client::empty(token)) {
        request_->headers.insert(
            pair<string, string>("x-oss-security-token", *token));
      }
      request_->body = Darabonba::Converter::toStream(*reqBody);
      request_->headers.insert(pair<string, string>(
          "authorization",
          Alibabacloud_OSSUtil::Client::getSignature(
              request_, request->bucketName, accessKeyId, accessKeySecret,
              _signatureVersion, _addtionalHeaders)));
      _lastRequest = request_;
      shared_ptr<Darabonba::Response> response_ =
          make_shared<Darabonba::Response>(
              Darabonba::Core::doAction(request_, runtime_));
      shared_ptr<map<string, boost::any>> respMap;
      shared_ptr<string> bodyStr;
      if (Darabonba_Util::Client::is4xx(
              make_shared<int>(response_->statusCode)) ||
          Darabonba_Util::Client::is5xx(
              make_shared<int>(response_->statusCode))) {
        bodyStr = make_shared<string>(
            Darabonba_Util::Client::readAsString(response_->body));
        respMap = make_shared<map<string, boost::any>>(
            Alibabacloud_OSSUtil::Client::getErrMessage(bodyStr));
        BOOST_THROW_EXCEPTION(Darabonba::Error(map<string, boost::any>(
            {{"code", (*respMap)["Code"]},
             {"message", (*respMap)["Message"]},
             {"data", boost::any(map<string, boost::any>(
                          {{"httpCode", boost::any(response_->statusCode)},
                           {"requestId", (*respMap)["RequestId"]},
                           {"hostId", (*respMap)["HostId"]}}))}})));
      }
      return PutBucketRequestPaymentResponse(
          Darabonba::Converter::toGenericMap(Darabonba::Converter::merge(
              map<string, string>(), response_->headers)));
    } catch (std::exception &e) {
      if (Darabonba::Core::isRetryable(e)) {
        _lastException = make_shared<std::exception>(e);
        continue;
      }
      BOOST_THROW_EXCEPTION(e);
    }
  }
  BOOST_THROW_EXCEPTION(
      Darabonba::UnretryableError(_lastRequest, _lastException));
}

PutBucketEncryptionResponse Alibabacloud_OSS::Client::putBucketEncryption(
    shared_ptr<PutBucketEncryptionRequest> request,
    shared_ptr<Alibabacloud_OSSUtil::RuntimeOptions> runtime) {
  request->validate();
  runtime->validate();
  shared_ptr<map<string, boost::any>> runtime_ = make_shared<
      map<string, boost::any>>(map<string, boost::any>(
      {{"timeouted", boost::any(string("retry"))},
       {"readTimeout", boost::any(Darabonba_Util::Client::defaultNumber(
                           runtime->readTimeout, _readTimeout))},
       {"connectTimeout", boost::any(Darabonba_Util::Client::defaultNumber(
                              runtime->connectTimeout, _connectTimeout))},
       {"localAddr", boost::any(string(Darabonba_Util::Client::defaultString(
                         runtime->localAddr, _localAddr)))},
       {"httpProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                         runtime->httpProxy, _httpProxy)))},
       {"httpsProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                          runtime->httpsProxy, _httpsProxy)))},
       {"noProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                       runtime->noProxy, _noProxy)))},
       {"socks5Proxy", boost::any(string(Darabonba_Util::Client::defaultString(
                           runtime->socks5Proxy, _socks5Proxy)))},
       {"socks5NetWork",
        boost::any(string(Darabonba_Util::Client::defaultString(
            runtime->socks5NetWork, _socks5NetWork)))},
       {"maxIdleConns", boost::any(Darabonba_Util::Client::defaultNumber(
                            runtime->maxIdleConns, _maxIdleConns))},
       {"retry", boost::any(map<string, boost::any>(
                     {{"retryable", !runtime->autoretry
                                        ? boost::any()
                                        : boost::any(*runtime->autoretry)},
                      {"maxAttempts",
                       boost::any(Darabonba_Util::Client::defaultNumber(
                           runtime->maxAttempts, make_shared<int>(3)))}}))},
       {"backoff",
        boost::any(map<string, boost::any>(
            {{"policy",
              boost::any(string(Darabonba_Util::Client::defaultString(
                  runtime->backoffPolicy, make_shared<string>("no"))))},
             {"period", boost::any(Darabonba_Util::Client::defaultNumber(
                            runtime->backoffPeriod, make_shared<int>(1)))}}))},
       {"ignoreSSL", !runtime->ignoreSSL ? boost::any()
                                         : boost::any(*runtime->ignoreSSL)}}));
  shared_ptr<Darabonba::Request> _lastRequest;
  shared_ptr<std::exception> _lastException;
  shared_ptr<int> _now = make_shared<int>(0);
  shared_ptr<int> _retryTimes = make_shared<int>(0);
  while (Darabonba::Core::allowRetry(
      make_shared<boost::any>((*runtime_)["retry"]), _retryTimes, _now)) {
    if (*_retryTimes > 0) {
      shared_ptr<int> _backoffTime =
          make_shared<int>(Darabonba::Core::getBackoffTime(
              make_shared<boost::any>((*runtime_)["backoff"]), _retryTimes));
      if (*_backoffTime > 0) {
        Darabonba::Core::sleep(_backoffTime);
      }
    }
    _retryTimes = make_shared<int>(*_retryTimes + 1);
    try {
      shared_ptr<Darabonba::Request> request_ =
          make_shared<Darabonba::Request>();
      shared_ptr<string> accessKeyId =
          make_shared<string>(_credential->getAccessKeyId());
      shared_ptr<string> accessKeySecret =
          make_shared<string>(_credential->getAccessKeySecret());
      shared_ptr<string> token =
          make_shared<string>(_credential->getSecurityToken());
      shared_ptr<string> reqBody =
          make_shared<string>(Darabonba_XML::Client::toXML(
              make_shared<map<string, boost::any>>(request->body->toMap())));
      request_->protocol = *_protocol;
      request_->method = "PUT";
      request_->pathname = string("/?encryption");
      request_->headers = {
          {"host", Alibabacloud_OSSUtil::Client::getHost(
                       request->bucketName, _regionId, _endpoint, _hostModel)},
          {"date", Darabonba_Util::Client::getDateUTCString()},
          {"user-agent", getUserAgent()}};
      if (!Darabonba_Util::Client::empty(token)) {
        request_->headers.insert(
            pair<string, string>("x-oss-security-token", *token));
      }
      request_->body = Darabonba::Converter::toStream(*reqBody);
      request_->headers.insert(pair<string, string>(
          "authorization",
          Alibabacloud_OSSUtil::Client::getSignature(
              request_, request->bucketName, accessKeyId, accessKeySecret,
              _signatureVersion, _addtionalHeaders)));
      _lastRequest = request_;
      shared_ptr<Darabonba::Response> response_ =
          make_shared<Darabonba::Response>(
              Darabonba::Core::doAction(request_, runtime_));
      shared_ptr<map<string, boost::any>> respMap;
      shared_ptr<string> bodyStr;
      if (Darabonba_Util::Client::is4xx(
              make_shared<int>(response_->statusCode)) ||
          Darabonba_Util::Client::is5xx(
              make_shared<int>(response_->statusCode))) {
        bodyStr = make_shared<string>(
            Darabonba_Util::Client::readAsString(response_->body));
        respMap = make_shared<map<string, boost::any>>(
            Alibabacloud_OSSUtil::Client::getErrMessage(bodyStr));
        BOOST_THROW_EXCEPTION(Darabonba::Error(map<string, boost::any>(
            {{"code", (*respMap)["Code"]},
             {"message", (*respMap)["Message"]},
             {"data", boost::any(map<string, boost::any>(
                          {{"httpCode", boost::any(response_->statusCode)},
                           {"requestId", (*respMap)["RequestId"]},
                           {"hostId", (*respMap)["HostId"]}}))}})));
      }
      return PutBucketEncryptionResponse(
          Darabonba::Converter::toGenericMap(Darabonba::Converter::merge(
              map<string, string>(), response_->headers)));
    } catch (std::exception &e) {
      if (Darabonba::Core::isRetryable(e)) {
        _lastException = make_shared<std::exception>(e);
        continue;
      }
      BOOST_THROW_EXCEPTION(e);
    }
  }
  BOOST_THROW_EXCEPTION(
      Darabonba::UnretryableError(_lastRequest, _lastException));
}

PutLiveChannelResponse Alibabacloud_OSS::Client::putLiveChannel(
    shared_ptr<PutLiveChannelRequest> request,
    shared_ptr<Alibabacloud_OSSUtil::RuntimeOptions> runtime) {
  request->validate();
  runtime->validate();
  shared_ptr<map<string, boost::any>> runtime_ = make_shared<
      map<string, boost::any>>(map<string, boost::any>(
      {{"timeouted", boost::any(string("retry"))},
       {"readTimeout", boost::any(Darabonba_Util::Client::defaultNumber(
                           runtime->readTimeout, _readTimeout))},
       {"connectTimeout", boost::any(Darabonba_Util::Client::defaultNumber(
                              runtime->connectTimeout, _connectTimeout))},
       {"localAddr", boost::any(string(Darabonba_Util::Client::defaultString(
                         runtime->localAddr, _localAddr)))},
       {"httpProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                         runtime->httpProxy, _httpProxy)))},
       {"httpsProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                          runtime->httpsProxy, _httpsProxy)))},
       {"noProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                       runtime->noProxy, _noProxy)))},
       {"socks5Proxy", boost::any(string(Darabonba_Util::Client::defaultString(
                           runtime->socks5Proxy, _socks5Proxy)))},
       {"socks5NetWork",
        boost::any(string(Darabonba_Util::Client::defaultString(
            runtime->socks5NetWork, _socks5NetWork)))},
       {"maxIdleConns", boost::any(Darabonba_Util::Client::defaultNumber(
                            runtime->maxIdleConns, _maxIdleConns))},
       {"retry", boost::any(map<string, boost::any>(
                     {{"retryable", !runtime->autoretry
                                        ? boost::any()
                                        : boost::any(*runtime->autoretry)},
                      {"maxAttempts",
                       boost::any(Darabonba_Util::Client::defaultNumber(
                           runtime->maxAttempts, make_shared<int>(3)))}}))},
       {"backoff",
        boost::any(map<string, boost::any>(
            {{"policy",
              boost::any(string(Darabonba_Util::Client::defaultString(
                  runtime->backoffPolicy, make_shared<string>("no"))))},
             {"period", boost::any(Darabonba_Util::Client::defaultNumber(
                            runtime->backoffPeriod, make_shared<int>(1)))}}))},
       {"ignoreSSL", !runtime->ignoreSSL ? boost::any()
                                         : boost::any(*runtime->ignoreSSL)}}));
  shared_ptr<Darabonba::Request> _lastRequest;
  shared_ptr<std::exception> _lastException;
  shared_ptr<int> _now = make_shared<int>(0);
  shared_ptr<int> _retryTimes = make_shared<int>(0);
  while (Darabonba::Core::allowRetry(
      make_shared<boost::any>((*runtime_)["retry"]), _retryTimes, _now)) {
    if (*_retryTimes > 0) {
      shared_ptr<int> _backoffTime =
          make_shared<int>(Darabonba::Core::getBackoffTime(
              make_shared<boost::any>((*runtime_)["backoff"]), _retryTimes));
      if (*_backoffTime > 0) {
        Darabonba::Core::sleep(_backoffTime);
      }
    }
    _retryTimes = make_shared<int>(*_retryTimes + 1);
    try {
      shared_ptr<Darabonba::Request> request_ =
          make_shared<Darabonba::Request>();
      shared_ptr<string> accessKeyId =
          make_shared<string>(_credential->getAccessKeyId());
      shared_ptr<string> accessKeySecret =
          make_shared<string>(_credential->getAccessKeySecret());
      shared_ptr<string> token =
          make_shared<string>(_credential->getSecurityToken());
      shared_ptr<string> reqBody =
          make_shared<string>(Darabonba_XML::Client::toXML(
              make_shared<map<string, boost::any>>(request->body->toMap())));
      request_->protocol = *_protocol;
      request_->method = "PUT";
      request_->pathname = string("/" + *request->channelName + "?live");
      request_->headers = {
          {"host", Alibabacloud_OSSUtil::Client::getHost(
                       request->bucketName, _regionId, _endpoint, _hostModel)},
          {"date", Darabonba_Util::Client::getDateUTCString()},
          {"user-agent", getUserAgent()}};
      if (!Darabonba_Util::Client::empty(token)) {
        request_->headers.insert(
            pair<string, string>("x-oss-security-token", *token));
      }
      request_->body = Darabonba::Converter::toStream(*reqBody);
      request_->headers.insert(pair<string, string>(
          "authorization",
          Alibabacloud_OSSUtil::Client::getSignature(
              request_, request->bucketName, accessKeyId, accessKeySecret,
              _signatureVersion, _addtionalHeaders)));
      _lastRequest = request_;
      shared_ptr<Darabonba::Response> response_ =
          make_shared<Darabonba::Response>(
              Darabonba::Core::doAction(request_, runtime_));
      shared_ptr<map<string, boost::any>> respMap;
      shared_ptr<string> bodyStr;
      if (Darabonba_Util::Client::is4xx(
              make_shared<int>(response_->statusCode)) ||
          Darabonba_Util::Client::is5xx(
              make_shared<int>(response_->statusCode))) {
        bodyStr = make_shared<string>(
            Darabonba_Util::Client::readAsString(response_->body));
        respMap = make_shared<map<string, boost::any>>(
            Alibabacloud_OSSUtil::Client::getErrMessage(bodyStr));
        BOOST_THROW_EXCEPTION(Darabonba::Error(map<string, boost::any>(
            {{"code", (*respMap)["Code"]},
             {"message", (*respMap)["Message"]},
             {"data", boost::any(map<string, boost::any>(
                          {{"httpCode", boost::any(response_->statusCode)},
                           {"requestId", (*respMap)["RequestId"]},
                           {"hostId", (*respMap)["HostId"]}}))}})));
      }
      bodyStr = make_shared<string>(
          Darabonba_Util::Client::readAsString(response_->body));
      respMap = make_shared<map<string, boost::any>>(
          Darabonba_XML::Client::parseXml(bodyStr, nullptr));
      return PutLiveChannelResponse(Darabonba::Converter::merge(
          map<string, boost::any>({{"CreateLiveChannelResult",
                                    (*respMap)["CreateLiveChannelResult"]}}),
          Darabonba::Converter::toGenericMap(response_->headers)));
    } catch (std::exception &e) {
      if (Darabonba::Core::isRetryable(e)) {
        _lastException = make_shared<std::exception>(e);
        continue;
      }
      BOOST_THROW_EXCEPTION(e);
    }
  }
  BOOST_THROW_EXCEPTION(
      Darabonba::UnretryableError(_lastRequest, _lastException));
}

PutBucketTagsResponse Alibabacloud_OSS::Client::putBucketTags(
    shared_ptr<PutBucketTagsRequest> request,
    shared_ptr<Alibabacloud_OSSUtil::RuntimeOptions> runtime) {
  request->validate();
  runtime->validate();
  shared_ptr<map<string, boost::any>> runtime_ = make_shared<
      map<string, boost::any>>(map<string, boost::any>(
      {{"timeouted", boost::any(string("retry"))},
       {"readTimeout", boost::any(Darabonba_Util::Client::defaultNumber(
                           runtime->readTimeout, _readTimeout))},
       {"connectTimeout", boost::any(Darabonba_Util::Client::defaultNumber(
                              runtime->connectTimeout, _connectTimeout))},
       {"localAddr", boost::any(string(Darabonba_Util::Client::defaultString(
                         runtime->localAddr, _localAddr)))},
       {"httpProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                         runtime->httpProxy, _httpProxy)))},
       {"httpsProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                          runtime->httpsProxy, _httpsProxy)))},
       {"noProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                       runtime->noProxy, _noProxy)))},
       {"socks5Proxy", boost::any(string(Darabonba_Util::Client::defaultString(
                           runtime->socks5Proxy, _socks5Proxy)))},
       {"socks5NetWork",
        boost::any(string(Darabonba_Util::Client::defaultString(
            runtime->socks5NetWork, _socks5NetWork)))},
       {"maxIdleConns", boost::any(Darabonba_Util::Client::defaultNumber(
                            runtime->maxIdleConns, _maxIdleConns))},
       {"retry", boost::any(map<string, boost::any>(
                     {{"retryable", !runtime->autoretry
                                        ? boost::any()
                                        : boost::any(*runtime->autoretry)},
                      {"maxAttempts",
                       boost::any(Darabonba_Util::Client::defaultNumber(
                           runtime->maxAttempts, make_shared<int>(3)))}}))},
       {"backoff",
        boost::any(map<string, boost::any>(
            {{"policy",
              boost::any(string(Darabonba_Util::Client::defaultString(
                  runtime->backoffPolicy, make_shared<string>("no"))))},
             {"period", boost::any(Darabonba_Util::Client::defaultNumber(
                            runtime->backoffPeriod, make_shared<int>(1)))}}))},
       {"ignoreSSL", !runtime->ignoreSSL ? boost::any()
                                         : boost::any(*runtime->ignoreSSL)}}));
  shared_ptr<Darabonba::Request> _lastRequest;
  shared_ptr<std::exception> _lastException;
  shared_ptr<int> _now = make_shared<int>(0);
  shared_ptr<int> _retryTimes = make_shared<int>(0);
  while (Darabonba::Core::allowRetry(
      make_shared<boost::any>((*runtime_)["retry"]), _retryTimes, _now)) {
    if (*_retryTimes > 0) {
      shared_ptr<int> _backoffTime =
          make_shared<int>(Darabonba::Core::getBackoffTime(
              make_shared<boost::any>((*runtime_)["backoff"]), _retryTimes));
      if (*_backoffTime > 0) {
        Darabonba::Core::sleep(_backoffTime);
      }
    }
    _retryTimes = make_shared<int>(*_retryTimes + 1);
    try {
      shared_ptr<Darabonba::Request> request_ =
          make_shared<Darabonba::Request>();
      shared_ptr<string> accessKeyId =
          make_shared<string>(_credential->getAccessKeyId());
      shared_ptr<string> accessKeySecret =
          make_shared<string>(_credential->getAccessKeySecret());
      shared_ptr<string> token =
          make_shared<string>(_credential->getSecurityToken());
      shared_ptr<string> reqBody =
          make_shared<string>(Darabonba_XML::Client::toXML(
              make_shared<map<string, boost::any>>(request->body->toMap())));
      request_->protocol = *_protocol;
      request_->method = "PUT";
      request_->pathname = string("/?tagging");
      request_->headers = {
          {"host", Alibabacloud_OSSUtil::Client::getHost(
                       request->bucketName, _regionId, _endpoint, _hostModel)},
          {"date", Darabonba_Util::Client::getDateUTCString()},
          {"user-agent", getUserAgent()}};
      if (!Darabonba_Util::Client::empty(token)) {
        request_->headers.insert(
            pair<string, string>("x-oss-security-token", *token));
      }
      request_->body = Darabonba::Converter::toStream(*reqBody);
      request_->headers.insert(pair<string, string>(
          "authorization",
          Alibabacloud_OSSUtil::Client::getSignature(
              request_, request->bucketName, accessKeyId, accessKeySecret,
              _signatureVersion, _addtionalHeaders)));
      _lastRequest = request_;
      shared_ptr<Darabonba::Response> response_ =
          make_shared<Darabonba::Response>(
              Darabonba::Core::doAction(request_, runtime_));
      shared_ptr<map<string, boost::any>> respMap;
      shared_ptr<string> bodyStr;
      if (Darabonba_Util::Client::is4xx(
              make_shared<int>(response_->statusCode)) ||
          Darabonba_Util::Client::is5xx(
              make_shared<int>(response_->statusCode))) {
        bodyStr = make_shared<string>(
            Darabonba_Util::Client::readAsString(response_->body));
        respMap = make_shared<map<string, boost::any>>(
            Alibabacloud_OSSUtil::Client::getErrMessage(bodyStr));
        BOOST_THROW_EXCEPTION(Darabonba::Error(map<string, boost::any>(
            {{"code", (*respMap)["Code"]},
             {"message", (*respMap)["Message"]},
             {"data", boost::any(map<string, boost::any>(
                          {{"httpCode", boost::any(response_->statusCode)},
                           {"requestId", (*respMap)["RequestId"]},
                           {"hostId", (*respMap)["HostId"]}}))}})));
      }
      return PutBucketTagsResponse(
          Darabonba::Converter::toGenericMap(Darabonba::Converter::merge(
              map<string, string>(), response_->headers)));
    } catch (std::exception &e) {
      if (Darabonba::Core::isRetryable(e)) {
        _lastException = make_shared<std::exception>(e);
        continue;
      }
      BOOST_THROW_EXCEPTION(e);
    }
  }
  BOOST_THROW_EXCEPTION(
      Darabonba::UnretryableError(_lastRequest, _lastException));
}

PutObjectTaggingResponse Alibabacloud_OSS::Client::putObjectTagging(
    shared_ptr<PutObjectTaggingRequest> request,
    shared_ptr<Alibabacloud_OSSUtil::RuntimeOptions> runtime) {
  request->validate();
  runtime->validate();
  shared_ptr<map<string, boost::any>> runtime_ = make_shared<
      map<string, boost::any>>(map<string, boost::any>(
      {{"timeouted", boost::any(string("retry"))},
       {"readTimeout", boost::any(Darabonba_Util::Client::defaultNumber(
                           runtime->readTimeout, _readTimeout))},
       {"connectTimeout", boost::any(Darabonba_Util::Client::defaultNumber(
                              runtime->connectTimeout, _connectTimeout))},
       {"localAddr", boost::any(string(Darabonba_Util::Client::defaultString(
                         runtime->localAddr, _localAddr)))},
       {"httpProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                         runtime->httpProxy, _httpProxy)))},
       {"httpsProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                          runtime->httpsProxy, _httpsProxy)))},
       {"noProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                       runtime->noProxy, _noProxy)))},
       {"socks5Proxy", boost::any(string(Darabonba_Util::Client::defaultString(
                           runtime->socks5Proxy, _socks5Proxy)))},
       {"socks5NetWork",
        boost::any(string(Darabonba_Util::Client::defaultString(
            runtime->socks5NetWork, _socks5NetWork)))},
       {"maxIdleConns", boost::any(Darabonba_Util::Client::defaultNumber(
                            runtime->maxIdleConns, _maxIdleConns))},
       {"retry", boost::any(map<string, boost::any>(
                     {{"retryable", !runtime->autoretry
                                        ? boost::any()
                                        : boost::any(*runtime->autoretry)},
                      {"maxAttempts",
                       boost::any(Darabonba_Util::Client::defaultNumber(
                           runtime->maxAttempts, make_shared<int>(3)))}}))},
       {"backoff",
        boost::any(map<string, boost::any>(
            {{"policy",
              boost::any(string(Darabonba_Util::Client::defaultString(
                  runtime->backoffPolicy, make_shared<string>("no"))))},
             {"period", boost::any(Darabonba_Util::Client::defaultNumber(
                            runtime->backoffPeriod, make_shared<int>(1)))}}))},
       {"ignoreSSL", !runtime->ignoreSSL ? boost::any()
                                         : boost::any(*runtime->ignoreSSL)}}));
  shared_ptr<Darabonba::Request> _lastRequest;
  shared_ptr<std::exception> _lastException;
  shared_ptr<int> _now = make_shared<int>(0);
  shared_ptr<int> _retryTimes = make_shared<int>(0);
  while (Darabonba::Core::allowRetry(
      make_shared<boost::any>((*runtime_)["retry"]), _retryTimes, _now)) {
    if (*_retryTimes > 0) {
      shared_ptr<int> _backoffTime =
          make_shared<int>(Darabonba::Core::getBackoffTime(
              make_shared<boost::any>((*runtime_)["backoff"]), _retryTimes));
      if (*_backoffTime > 0) {
        Darabonba::Core::sleep(_backoffTime);
      }
    }
    _retryTimes = make_shared<int>(*_retryTimes + 1);
    try {
      shared_ptr<Darabonba::Request> request_ =
          make_shared<Darabonba::Request>();
      shared_ptr<string> accessKeyId =
          make_shared<string>(_credential->getAccessKeyId());
      shared_ptr<string> accessKeySecret =
          make_shared<string>(_credential->getAccessKeySecret());
      shared_ptr<string> token =
          make_shared<string>(_credential->getSecurityToken());
      shared_ptr<string> reqBody =
          make_shared<string>(Darabonba_XML::Client::toXML(
              make_shared<map<string, boost::any>>(request->body->toMap())));
      request_->protocol = *_protocol;
      request_->method = "PUT";
      request_->pathname = string("/" + *request->objectName + "?tagging");
      request_->headers = {
          {"host", Alibabacloud_OSSUtil::Client::getHost(
                       request->bucketName, _regionId, _endpoint, _hostModel)},
          {"date", Darabonba_Util::Client::getDateUTCString()},
          {"user-agent", getUserAgent()}};
      if (!Darabonba_Util::Client::empty(token)) {
        request_->headers.insert(
            pair<string, string>("x-oss-security-token", *token));
      }
      request_->body = Darabonba::Converter::toStream(*reqBody);
      request_->headers.insert(pair<string, string>(
          "authorization",
          Alibabacloud_OSSUtil::Client::getSignature(
              request_, request->bucketName, accessKeyId, accessKeySecret,
              _signatureVersion, _addtionalHeaders)));
      _lastRequest = request_;
      shared_ptr<Darabonba::Response> response_ =
          make_shared<Darabonba::Response>(
              Darabonba::Core::doAction(request_, runtime_));
      shared_ptr<map<string, boost::any>> respMap;
      shared_ptr<string> bodyStr;
      if (Darabonba_Util::Client::is4xx(
              make_shared<int>(response_->statusCode)) ||
          Darabonba_Util::Client::is5xx(
              make_shared<int>(response_->statusCode))) {
        bodyStr = make_shared<string>(
            Darabonba_Util::Client::readAsString(response_->body));
        respMap = make_shared<map<string, boost::any>>(
            Alibabacloud_OSSUtil::Client::getErrMessage(bodyStr));
        BOOST_THROW_EXCEPTION(Darabonba::Error(map<string, boost::any>(
            {{"code", (*respMap)["Code"]},
             {"message", (*respMap)["Message"]},
             {"data", boost::any(map<string, boost::any>(
                          {{"httpCode", boost::any(response_->statusCode)},
                           {"requestId", (*respMap)["RequestId"]},
                           {"hostId", (*respMap)["HostId"]}}))}})));
      }
      return PutObjectTaggingResponse(
          Darabonba::Converter::toGenericMap(Darabonba::Converter::merge(
              map<string, string>(), response_->headers)));
    } catch (std::exception &e) {
      if (Darabonba::Core::isRetryable(e)) {
        _lastException = make_shared<std::exception>(e);
        continue;
      }
      BOOST_THROW_EXCEPTION(e);
    }
  }
  BOOST_THROW_EXCEPTION(
      Darabonba::UnretryableError(_lastRequest, _lastException));
}

SelectObjectResponse Alibabacloud_OSS::Client::selectObject(
    shared_ptr<SelectObjectRequest> request,
    shared_ptr<Alibabacloud_OSSUtil::RuntimeOptions> runtime) {
  request->validate();
  runtime->validate();
  shared_ptr<map<string, boost::any>> runtime_ = make_shared<
      map<string, boost::any>>(map<string, boost::any>(
      {{"timeouted", boost::any(string("retry"))},
       {"readTimeout", boost::any(Darabonba_Util::Client::defaultNumber(
                           runtime->readTimeout, _readTimeout))},
       {"connectTimeout", boost::any(Darabonba_Util::Client::defaultNumber(
                              runtime->connectTimeout, _connectTimeout))},
       {"localAddr", boost::any(string(Darabonba_Util::Client::defaultString(
                         runtime->localAddr, _localAddr)))},
       {"httpProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                         runtime->httpProxy, _httpProxy)))},
       {"httpsProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                          runtime->httpsProxy, _httpsProxy)))},
       {"noProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                       runtime->noProxy, _noProxy)))},
       {"socks5Proxy", boost::any(string(Darabonba_Util::Client::defaultString(
                           runtime->socks5Proxy, _socks5Proxy)))},
       {"socks5NetWork",
        boost::any(string(Darabonba_Util::Client::defaultString(
            runtime->socks5NetWork, _socks5NetWork)))},
       {"maxIdleConns", boost::any(Darabonba_Util::Client::defaultNumber(
                            runtime->maxIdleConns, _maxIdleConns))},
       {"retry", boost::any(map<string, boost::any>(
                     {{"retryable", !runtime->autoretry
                                        ? boost::any()
                                        : boost::any(*runtime->autoretry)},
                      {"maxAttempts",
                       boost::any(Darabonba_Util::Client::defaultNumber(
                           runtime->maxAttempts, make_shared<int>(3)))}}))},
       {"backoff",
        boost::any(map<string, boost::any>(
            {{"policy",
              boost::any(string(Darabonba_Util::Client::defaultString(
                  runtime->backoffPolicy, make_shared<string>("no"))))},
             {"period", boost::any(Darabonba_Util::Client::defaultNumber(
                            runtime->backoffPeriod, make_shared<int>(1)))}}))},
       {"ignoreSSL", !runtime->ignoreSSL ? boost::any()
                                         : boost::any(*runtime->ignoreSSL)}}));
  shared_ptr<Darabonba::Request> _lastRequest;
  shared_ptr<std::exception> _lastException;
  shared_ptr<int> _now = make_shared<int>(0);
  shared_ptr<int> _retryTimes = make_shared<int>(0);
  while (Darabonba::Core::allowRetry(
      make_shared<boost::any>((*runtime_)["retry"]), _retryTimes, _now)) {
    if (*_retryTimes > 0) {
      shared_ptr<int> _backoffTime =
          make_shared<int>(Darabonba::Core::getBackoffTime(
              make_shared<boost::any>((*runtime_)["backoff"]), _retryTimes));
      if (*_backoffTime > 0) {
        Darabonba::Core::sleep(_backoffTime);
      }
    }
    _retryTimes = make_shared<int>(*_retryTimes + 1);
    try {
      shared_ptr<Darabonba::Request> request_ =
          make_shared<Darabonba::Request>();
      shared_ptr<string> accessKeyId =
          make_shared<string>(_credential->getAccessKeyId());
      shared_ptr<string> accessKeySecret =
          make_shared<string>(_credential->getAccessKeySecret());
      shared_ptr<string> token =
          make_shared<string>(_credential->getSecurityToken());
      shared_ptr<string> reqBody =
          make_shared<string>(Darabonba_XML::Client::toXML(
              make_shared<map<string, boost::any>>(request->body->toMap())));
      request_->protocol = *_protocol;
      request_->method = "POST";
      request_->pathname = string("/" + *request->objectName + "");
      request_->headers = {
          {"host", Alibabacloud_OSSUtil::Client::getHost(
                       request->bucketName, _regionId, _endpoint, _hostModel)},
          {"date", Darabonba_Util::Client::getDateUTCString()},
          {"user-agent", getUserAgent()}};
      if (!Darabonba_Util::Client::empty(token)) {
        request_->headers.insert(
            pair<string, string>("x-oss-security-token", *token));
      }
      request_->query = Darabonba_Util::Client::stringifyMapValue(
          make_shared<map<string, boost::any>>(request->filter->toMap()));
      request_->body = Darabonba::Converter::toStream(*reqBody);
      request_->headers.insert(pair<string, string>(
          "authorization",
          Alibabacloud_OSSUtil::Client::getSignature(
              request_, request->bucketName, accessKeyId, accessKeySecret,
              _signatureVersion, _addtionalHeaders)));
      _lastRequest = request_;
      shared_ptr<Darabonba::Response> response_ =
          make_shared<Darabonba::Response>(
              Darabonba::Core::doAction(request_, runtime_));
      shared_ptr<map<string, boost::any>> respMap;
      shared_ptr<string> bodyStr;
      if (Darabonba_Util::Client::is4xx(
              make_shared<int>(response_->statusCode)) ||
          Darabonba_Util::Client::is5xx(
              make_shared<int>(response_->statusCode))) {
        bodyStr = make_shared<string>(
            Darabonba_Util::Client::readAsString(response_->body));
        respMap = make_shared<map<string, boost::any>>(
            Alibabacloud_OSSUtil::Client::getErrMessage(bodyStr));
        BOOST_THROW_EXCEPTION(Darabonba::Error(map<string, boost::any>(
            {{"code", (*respMap)["Code"]},
             {"message", (*respMap)["Message"]},
             {"data", boost::any(map<string, boost::any>(
                          {{"httpCode", boost::any(response_->statusCode)},
                           {"requestId", (*respMap)["RequestId"]},
                           {"hostId", (*respMap)["HostId"]}}))}})));
      }
      return SelectObjectResponse(
          Darabonba::Converter::toGenericMap(Darabonba::Converter::merge(
              map<string, string>(), response_->headers)));
    } catch (std::exception &e) {
      if (Darabonba::Core::isRetryable(e)) {
        _lastException = make_shared<std::exception>(e);
        continue;
      }
      BOOST_THROW_EXCEPTION(e);
    }
  }
  BOOST_THROW_EXCEPTION(
      Darabonba::UnretryableError(_lastRequest, _lastException));
}

PutBucketCORSResponse Alibabacloud_OSS::Client::putBucketCORS(
    shared_ptr<PutBucketCORSRequest> request,
    shared_ptr<Alibabacloud_OSSUtil::RuntimeOptions> runtime) {
  request->validate();
  runtime->validate();
  shared_ptr<map<string, boost::any>> runtime_ = make_shared<
      map<string, boost::any>>(map<string, boost::any>(
      {{"timeouted", boost::any(string("retry"))},
       {"readTimeout", boost::any(Darabonba_Util::Client::defaultNumber(
                           runtime->readTimeout, _readTimeout))},
       {"connectTimeout", boost::any(Darabonba_Util::Client::defaultNumber(
                              runtime->connectTimeout, _connectTimeout))},
       {"localAddr", boost::any(string(Darabonba_Util::Client::defaultString(
                         runtime->localAddr, _localAddr)))},
       {"httpProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                         runtime->httpProxy, _httpProxy)))},
       {"httpsProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                          runtime->httpsProxy, _httpsProxy)))},
       {"noProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                       runtime->noProxy, _noProxy)))},
       {"socks5Proxy", boost::any(string(Darabonba_Util::Client::defaultString(
                           runtime->socks5Proxy, _socks5Proxy)))},
       {"socks5NetWork",
        boost::any(string(Darabonba_Util::Client::defaultString(
            runtime->socks5NetWork, _socks5NetWork)))},
       {"maxIdleConns", boost::any(Darabonba_Util::Client::defaultNumber(
                            runtime->maxIdleConns, _maxIdleConns))},
       {"retry", boost::any(map<string, boost::any>(
                     {{"retryable", !runtime->autoretry
                                        ? boost::any()
                                        : boost::any(*runtime->autoretry)},
                      {"maxAttempts",
                       boost::any(Darabonba_Util::Client::defaultNumber(
                           runtime->maxAttempts, make_shared<int>(3)))}}))},
       {"backoff",
        boost::any(map<string, boost::any>(
            {{"policy",
              boost::any(string(Darabonba_Util::Client::defaultString(
                  runtime->backoffPolicy, make_shared<string>("no"))))},
             {"period", boost::any(Darabonba_Util::Client::defaultNumber(
                            runtime->backoffPeriod, make_shared<int>(1)))}}))},
       {"ignoreSSL", !runtime->ignoreSSL ? boost::any()
                                         : boost::any(*runtime->ignoreSSL)}}));
  shared_ptr<Darabonba::Request> _lastRequest;
  shared_ptr<std::exception> _lastException;
  shared_ptr<int> _now = make_shared<int>(0);
  shared_ptr<int> _retryTimes = make_shared<int>(0);
  while (Darabonba::Core::allowRetry(
      make_shared<boost::any>((*runtime_)["retry"]), _retryTimes, _now)) {
    if (*_retryTimes > 0) {
      shared_ptr<int> _backoffTime =
          make_shared<int>(Darabonba::Core::getBackoffTime(
              make_shared<boost::any>((*runtime_)["backoff"]), _retryTimes));
      if (*_backoffTime > 0) {
        Darabonba::Core::sleep(_backoffTime);
      }
    }
    _retryTimes = make_shared<int>(*_retryTimes + 1);
    try {
      shared_ptr<Darabonba::Request> request_ =
          make_shared<Darabonba::Request>();
      shared_ptr<string> accessKeyId =
          make_shared<string>(_credential->getAccessKeyId());
      shared_ptr<string> accessKeySecret =
          make_shared<string>(_credential->getAccessKeySecret());
      shared_ptr<string> token =
          make_shared<string>(_credential->getSecurityToken());
      shared_ptr<string> reqBody =
          make_shared<string>(Darabonba_XML::Client::toXML(
              make_shared<map<string, boost::any>>(request->body->toMap())));
      request_->protocol = *_protocol;
      request_->method = "PUT";
      request_->pathname = string("/?cors");
      request_->headers = {
          {"host", Alibabacloud_OSSUtil::Client::getHost(
                       request->bucketName, _regionId, _endpoint, _hostModel)},
          {"date", Darabonba_Util::Client::getDateUTCString()},
          {"user-agent", getUserAgent()}};
      if (!Darabonba_Util::Client::empty(token)) {
        request_->headers.insert(
            pair<string, string>("x-oss-security-token", *token));
      }
      request_->body = Darabonba::Converter::toStream(*reqBody);
      request_->headers.insert(pair<string, string>(
          "authorization",
          Alibabacloud_OSSUtil::Client::getSignature(
              request_, request->bucketName, accessKeyId, accessKeySecret,
              _signatureVersion, _addtionalHeaders)));
      _lastRequest = request_;
      shared_ptr<Darabonba::Response> response_ =
          make_shared<Darabonba::Response>(
              Darabonba::Core::doAction(request_, runtime_));
      shared_ptr<map<string, boost::any>> respMap;
      shared_ptr<string> bodyStr;
      if (Darabonba_Util::Client::is4xx(
              make_shared<int>(response_->statusCode)) ||
          Darabonba_Util::Client::is5xx(
              make_shared<int>(response_->statusCode))) {
        bodyStr = make_shared<string>(
            Darabonba_Util::Client::readAsString(response_->body));
        respMap = make_shared<map<string, boost::any>>(
            Alibabacloud_OSSUtil::Client::getErrMessage(bodyStr));
        BOOST_THROW_EXCEPTION(Darabonba::Error(map<string, boost::any>(
            {{"code", (*respMap)["Code"]},
             {"message", (*respMap)["Message"]},
             {"data", boost::any(map<string, boost::any>(
                          {{"httpCode", boost::any(response_->statusCode)},
                           {"requestId", (*respMap)["RequestId"]},
                           {"hostId", (*respMap)["HostId"]}}))}})));
      }
      return PutBucketCORSResponse(
          Darabonba::Converter::toGenericMap(Darabonba::Converter::merge(
              map<string, string>(), response_->headers)));
    } catch (std::exception &e) {
      if (Darabonba::Core::isRetryable(e)) {
        _lastException = make_shared<std::exception>(e);
        continue;
      }
      BOOST_THROW_EXCEPTION(e);
    }
  }
  BOOST_THROW_EXCEPTION(
      Darabonba::UnretryableError(_lastRequest, _lastException));
}

PutBucketResponse Alibabacloud_OSS::Client::putBucket(
    shared_ptr<PutBucketRequest> request,
    shared_ptr<Alibabacloud_OSSUtil::RuntimeOptions> runtime) {
  request->validate();
  runtime->validate();
  shared_ptr<map<string, boost::any>> runtime_ = make_shared<
      map<string, boost::any>>(map<string, boost::any>(
      {{"timeouted", boost::any(string("retry"))},
       {"readTimeout", boost::any(Darabonba_Util::Client::defaultNumber(
                           runtime->readTimeout, _readTimeout))},
       {"connectTimeout", boost::any(Darabonba_Util::Client::defaultNumber(
                              runtime->connectTimeout, _connectTimeout))},
       {"localAddr", boost::any(string(Darabonba_Util::Client::defaultString(
                         runtime->localAddr, _localAddr)))},
       {"httpProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                         runtime->httpProxy, _httpProxy)))},
       {"httpsProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                          runtime->httpsProxy, _httpsProxy)))},
       {"noProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                       runtime->noProxy, _noProxy)))},
       {"socks5Proxy", boost::any(string(Darabonba_Util::Client::defaultString(
                           runtime->socks5Proxy, _socks5Proxy)))},
       {"socks5NetWork",
        boost::any(string(Darabonba_Util::Client::defaultString(
            runtime->socks5NetWork, _socks5NetWork)))},
       {"maxIdleConns", boost::any(Darabonba_Util::Client::defaultNumber(
                            runtime->maxIdleConns, _maxIdleConns))},
       {"retry", boost::any(map<string, boost::any>(
                     {{"retryable", !runtime->autoretry
                                        ? boost::any()
                                        : boost::any(*runtime->autoretry)},
                      {"maxAttempts",
                       boost::any(Darabonba_Util::Client::defaultNumber(
                           runtime->maxAttempts, make_shared<int>(3)))}}))},
       {"backoff",
        boost::any(map<string, boost::any>(
            {{"policy",
              boost::any(string(Darabonba_Util::Client::defaultString(
                  runtime->backoffPolicy, make_shared<string>("no"))))},
             {"period", boost::any(Darabonba_Util::Client::defaultNumber(
                            runtime->backoffPeriod, make_shared<int>(1)))}}))},
       {"ignoreSSL", !runtime->ignoreSSL ? boost::any()
                                         : boost::any(*runtime->ignoreSSL)}}));
  shared_ptr<Darabonba::Request> _lastRequest;
  shared_ptr<std::exception> _lastException;
  shared_ptr<int> _now = make_shared<int>(0);
  shared_ptr<int> _retryTimes = make_shared<int>(0);
  while (Darabonba::Core::allowRetry(
      make_shared<boost::any>((*runtime_)["retry"]), _retryTimes, _now)) {
    if (*_retryTimes > 0) {
      shared_ptr<int> _backoffTime =
          make_shared<int>(Darabonba::Core::getBackoffTime(
              make_shared<boost::any>((*runtime_)["backoff"]), _retryTimes));
      if (*_backoffTime > 0) {
        Darabonba::Core::sleep(_backoffTime);
      }
    }
    _retryTimes = make_shared<int>(*_retryTimes + 1);
    try {
      shared_ptr<Darabonba::Request> request_ =
          make_shared<Darabonba::Request>();
      shared_ptr<string> accessKeyId =
          make_shared<string>(_credential->getAccessKeyId());
      shared_ptr<string> accessKeySecret =
          make_shared<string>(_credential->getAccessKeySecret());
      shared_ptr<string> token =
          make_shared<string>(_credential->getSecurityToken());
      shared_ptr<string> reqBody =
          make_shared<string>(Darabonba_XML::Client::toXML(
              make_shared<map<string, boost::any>>(request->body->toMap())));
      request_->protocol = *_protocol;
      request_->method = "PUT";
      request_->pathname = string("/");
      request_->headers = Darabonba::Converter::merge(
          map<string, string>(
              {{"host",
                Alibabacloud_OSSUtil::Client::getHost(
                    request->bucketName, _regionId, _endpoint, _hostModel)},
               {"date", Darabonba_Util::Client::getDateUTCString()},
               {"user-agent", getUserAgent()}}),
          Darabonba_Util::Client::stringifyMapValue(
              make_shared<map<string, boost::any>>(request->header->toMap())));
      if (!Darabonba_Util::Client::empty(token)) {
        request_->headers.insert(
            pair<string, string>("x-oss-security-token", *token));
      }
      request_->body = Darabonba::Converter::toStream(*reqBody);
      request_->headers.insert(pair<string, string>(
          "authorization",
          Alibabacloud_OSSUtil::Client::getSignature(
              request_, request->bucketName, accessKeyId, accessKeySecret,
              _signatureVersion, _addtionalHeaders)));
      _lastRequest = request_;
      shared_ptr<Darabonba::Response> response_ =
          make_shared<Darabonba::Response>(
              Darabonba::Core::doAction(request_, runtime_));
      shared_ptr<map<string, boost::any>> respMap;
      shared_ptr<string> bodyStr;
      if (Darabonba_Util::Client::is4xx(
              make_shared<int>(response_->statusCode)) ||
          Darabonba_Util::Client::is5xx(
              make_shared<int>(response_->statusCode))) {
        bodyStr = make_shared<string>(
            Darabonba_Util::Client::readAsString(response_->body));
        respMap = make_shared<map<string, boost::any>>(
            Alibabacloud_OSSUtil::Client::getErrMessage(bodyStr));
        BOOST_THROW_EXCEPTION(Darabonba::Error(map<string, boost::any>(
            {{"code", (*respMap)["Code"]},
             {"message", (*respMap)["Message"]},
             {"data", boost::any(map<string, boost::any>(
                          {{"httpCode", boost::any(response_->statusCode)},
                           {"requestId", (*respMap)["RequestId"]},
                           {"hostId", (*respMap)["HostId"]}}))}})));
      }
      return PutBucketResponse(
          Darabonba::Converter::toGenericMap(Darabonba::Converter::merge(
              map<string, string>(), response_->headers)));
    } catch (std::exception &e) {
      if (Darabonba::Core::isRetryable(e)) {
        _lastException = make_shared<std::exception>(e);
        continue;
      }
      BOOST_THROW_EXCEPTION(e);
    }
  }
  BOOST_THROW_EXCEPTION(
      Darabonba::UnretryableError(_lastRequest, _lastException));
}

ListMultipartUploadsResponse Alibabacloud_OSS::Client::listMultipartUploads(
    shared_ptr<ListMultipartUploadsRequest> request,
    shared_ptr<Alibabacloud_OSSUtil::RuntimeOptions> runtime) {
  request->validate();
  runtime->validate();
  shared_ptr<map<string, boost::any>> runtime_ = make_shared<
      map<string, boost::any>>(map<string, boost::any>(
      {{"timeouted", boost::any(string("retry"))},
       {"readTimeout", boost::any(Darabonba_Util::Client::defaultNumber(
                           runtime->readTimeout, _readTimeout))},
       {"connectTimeout", boost::any(Darabonba_Util::Client::defaultNumber(
                              runtime->connectTimeout, _connectTimeout))},
       {"localAddr", boost::any(string(Darabonba_Util::Client::defaultString(
                         runtime->localAddr, _localAddr)))},
       {"httpProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                         runtime->httpProxy, _httpProxy)))},
       {"httpsProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                          runtime->httpsProxy, _httpsProxy)))},
       {"noProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                       runtime->noProxy, _noProxy)))},
       {"socks5Proxy", boost::any(string(Darabonba_Util::Client::defaultString(
                           runtime->socks5Proxy, _socks5Proxy)))},
       {"socks5NetWork",
        boost::any(string(Darabonba_Util::Client::defaultString(
            runtime->socks5NetWork, _socks5NetWork)))},
       {"maxIdleConns", boost::any(Darabonba_Util::Client::defaultNumber(
                            runtime->maxIdleConns, _maxIdleConns))},
       {"retry", boost::any(map<string, boost::any>(
                     {{"retryable", !runtime->autoretry
                                        ? boost::any()
                                        : boost::any(*runtime->autoretry)},
                      {"maxAttempts",
                       boost::any(Darabonba_Util::Client::defaultNumber(
                           runtime->maxAttempts, make_shared<int>(3)))}}))},
       {"backoff",
        boost::any(map<string, boost::any>(
            {{"policy",
              boost::any(string(Darabonba_Util::Client::defaultString(
                  runtime->backoffPolicy, make_shared<string>("no"))))},
             {"period", boost::any(Darabonba_Util::Client::defaultNumber(
                            runtime->backoffPeriod, make_shared<int>(1)))}}))},
       {"ignoreSSL", !runtime->ignoreSSL ? boost::any()
                                         : boost::any(*runtime->ignoreSSL)}}));
  shared_ptr<Darabonba::Request> _lastRequest;
  shared_ptr<std::exception> _lastException;
  shared_ptr<int> _now = make_shared<int>(0);
  shared_ptr<int> _retryTimes = make_shared<int>(0);
  while (Darabonba::Core::allowRetry(
      make_shared<boost::any>((*runtime_)["retry"]), _retryTimes, _now)) {
    if (*_retryTimes > 0) {
      shared_ptr<int> _backoffTime =
          make_shared<int>(Darabonba::Core::getBackoffTime(
              make_shared<boost::any>((*runtime_)["backoff"]), _retryTimes));
      if (*_backoffTime > 0) {
        Darabonba::Core::sleep(_backoffTime);
      }
    }
    _retryTimes = make_shared<int>(*_retryTimes + 1);
    try {
      shared_ptr<Darabonba::Request> request_ =
          make_shared<Darabonba::Request>();
      shared_ptr<string> accessKeyId =
          make_shared<string>(_credential->getAccessKeyId());
      shared_ptr<string> accessKeySecret =
          make_shared<string>(_credential->getAccessKeySecret());
      shared_ptr<string> token =
          make_shared<string>(_credential->getSecurityToken());
      request_->protocol = *_protocol;
      request_->method = "GET";
      request_->pathname = string("/?uploads");
      request_->headers = {
          {"host", Alibabacloud_OSSUtil::Client::getHost(
                       request->bucketName, _regionId, _endpoint, _hostModel)},
          {"date", Darabonba_Util::Client::getDateUTCString()},
          {"user-agent", getUserAgent()}};
      if (!Darabonba_Util::Client::empty(token)) {
        request_->headers.insert(
            pair<string, string>("x-oss-security-token", *token));
      }
      request_->query = Darabonba_Util::Client::stringifyMapValue(
          make_shared<map<string, boost::any>>(request->filter->toMap()));
      request_->headers.insert(pair<string, string>(
          "authorization",
          Alibabacloud_OSSUtil::Client::getSignature(
              request_, request->bucketName, accessKeyId, accessKeySecret,
              _signatureVersion, _addtionalHeaders)));
      _lastRequest = request_;
      shared_ptr<Darabonba::Response> response_ =
          make_shared<Darabonba::Response>(
              Darabonba::Core::doAction(request_, runtime_));
      shared_ptr<map<string, boost::any>> respMap;
      shared_ptr<string> bodyStr;
      if (Darabonba_Util::Client::is4xx(
              make_shared<int>(response_->statusCode)) ||
          Darabonba_Util::Client::is5xx(
              make_shared<int>(response_->statusCode))) {
        bodyStr = make_shared<string>(
            Darabonba_Util::Client::readAsString(response_->body));
        respMap = make_shared<map<string, boost::any>>(
            Alibabacloud_OSSUtil::Client::getErrMessage(bodyStr));
        BOOST_THROW_EXCEPTION(Darabonba::Error(map<string, boost::any>(
            {{"code", (*respMap)["Code"]},
             {"message", (*respMap)["Message"]},
             {"data", boost::any(map<string, boost::any>(
                          {{"httpCode", boost::any(response_->statusCode)},
                           {"requestId", (*respMap)["RequestId"]},
                           {"hostId", (*respMap)["HostId"]}}))}})));
      }
      bodyStr = make_shared<string>(
          Darabonba_Util::Client::readAsString(response_->body));
      respMap = make_shared<map<string, boost::any>>(
          Darabonba_XML::Client::parseXml(bodyStr, nullptr));
      return ListMultipartUploadsResponse(Darabonba::Converter::merge(
          map<string, boost::any>({{"ListMultipartUploadsResult",
                                    (*respMap)["ListMultipartUploadsResult"]}}),
          Darabonba::Converter::toGenericMap(response_->headers)));
    } catch (std::exception &e) {
      if (Darabonba::Core::isRetryable(e)) {
        _lastException = make_shared<std::exception>(e);
        continue;
      }
      BOOST_THROW_EXCEPTION(e);
    }
  }
  BOOST_THROW_EXCEPTION(
      Darabonba::UnretryableError(_lastRequest, _lastException));
}

GetBucketRequestPaymentResponse
Alibabacloud_OSS::Client::getBucketRequestPayment(
    shared_ptr<GetBucketRequestPaymentRequest> request,
    shared_ptr<Alibabacloud_OSSUtil::RuntimeOptions> runtime) {
  request->validate();
  runtime->validate();
  shared_ptr<map<string, boost::any>> runtime_ = make_shared<
      map<string, boost::any>>(map<string, boost::any>(
      {{"timeouted", boost::any(string("retry"))},
       {"readTimeout", boost::any(Darabonba_Util::Client::defaultNumber(
                           runtime->readTimeout, _readTimeout))},
       {"connectTimeout", boost::any(Darabonba_Util::Client::defaultNumber(
                              runtime->connectTimeout, _connectTimeout))},
       {"localAddr", boost::any(string(Darabonba_Util::Client::defaultString(
                         runtime->localAddr, _localAddr)))},
       {"httpProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                         runtime->httpProxy, _httpProxy)))},
       {"httpsProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                          runtime->httpsProxy, _httpsProxy)))},
       {"noProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                       runtime->noProxy, _noProxy)))},
       {"socks5Proxy", boost::any(string(Darabonba_Util::Client::defaultString(
                           runtime->socks5Proxy, _socks5Proxy)))},
       {"socks5NetWork",
        boost::any(string(Darabonba_Util::Client::defaultString(
            runtime->socks5NetWork, _socks5NetWork)))},
       {"maxIdleConns", boost::any(Darabonba_Util::Client::defaultNumber(
                            runtime->maxIdleConns, _maxIdleConns))},
       {"retry", boost::any(map<string, boost::any>(
                     {{"retryable", !runtime->autoretry
                                        ? boost::any()
                                        : boost::any(*runtime->autoretry)},
                      {"maxAttempts",
                       boost::any(Darabonba_Util::Client::defaultNumber(
                           runtime->maxAttempts, make_shared<int>(3)))}}))},
       {"backoff",
        boost::any(map<string, boost::any>(
            {{"policy",
              boost::any(string(Darabonba_Util::Client::defaultString(
                  runtime->backoffPolicy, make_shared<string>("no"))))},
             {"period", boost::any(Darabonba_Util::Client::defaultNumber(
                            runtime->backoffPeriod, make_shared<int>(1)))}}))},
       {"ignoreSSL", !runtime->ignoreSSL ? boost::any()
                                         : boost::any(*runtime->ignoreSSL)}}));
  shared_ptr<Darabonba::Request> _lastRequest;
  shared_ptr<std::exception> _lastException;
  shared_ptr<int> _now = make_shared<int>(0);
  shared_ptr<int> _retryTimes = make_shared<int>(0);
  while (Darabonba::Core::allowRetry(
      make_shared<boost::any>((*runtime_)["retry"]), _retryTimes, _now)) {
    if (*_retryTimes > 0) {
      shared_ptr<int> _backoffTime =
          make_shared<int>(Darabonba::Core::getBackoffTime(
              make_shared<boost::any>((*runtime_)["backoff"]), _retryTimes));
      if (*_backoffTime > 0) {
        Darabonba::Core::sleep(_backoffTime);
      }
    }
    _retryTimes = make_shared<int>(*_retryTimes + 1);
    try {
      shared_ptr<Darabonba::Request> request_ =
          make_shared<Darabonba::Request>();
      shared_ptr<string> accessKeyId =
          make_shared<string>(_credential->getAccessKeyId());
      shared_ptr<string> accessKeySecret =
          make_shared<string>(_credential->getAccessKeySecret());
      shared_ptr<string> token =
          make_shared<string>(_credential->getSecurityToken());
      request_->protocol = *_protocol;
      request_->method = "GET";
      request_->pathname = string("/?requestPayment");
      request_->headers = {
          {"host", Alibabacloud_OSSUtil::Client::getHost(
                       request->bucketName, _regionId, _endpoint, _hostModel)},
          {"date", Darabonba_Util::Client::getDateUTCString()},
          {"user-agent", getUserAgent()}};
      if (!Darabonba_Util::Client::empty(token)) {
        request_->headers.insert(
            pair<string, string>("x-oss-security-token", *token));
      }
      request_->headers.insert(pair<string, string>(
          "authorization",
          Alibabacloud_OSSUtil::Client::getSignature(
              request_, request->bucketName, accessKeyId, accessKeySecret,
              _signatureVersion, _addtionalHeaders)));
      _lastRequest = request_;
      shared_ptr<Darabonba::Response> response_ =
          make_shared<Darabonba::Response>(
              Darabonba::Core::doAction(request_, runtime_));
      shared_ptr<map<string, boost::any>> respMap;
      shared_ptr<string> bodyStr;
      if (Darabonba_Util::Client::is4xx(
              make_shared<int>(response_->statusCode)) ||
          Darabonba_Util::Client::is5xx(
              make_shared<int>(response_->statusCode))) {
        bodyStr = make_shared<string>(
            Darabonba_Util::Client::readAsString(response_->body));
        respMap = make_shared<map<string, boost::any>>(
            Alibabacloud_OSSUtil::Client::getErrMessage(bodyStr));
        BOOST_THROW_EXCEPTION(Darabonba::Error(map<string, boost::any>(
            {{"code", (*respMap)["Code"]},
             {"message", (*respMap)["Message"]},
             {"data", boost::any(map<string, boost::any>(
                          {{"httpCode", boost::any(response_->statusCode)},
                           {"requestId", (*respMap)["RequestId"]},
                           {"hostId", (*respMap)["HostId"]}}))}})));
      }
      bodyStr = make_shared<string>(
          Darabonba_Util::Client::readAsString(response_->body));
      respMap = make_shared<map<string, boost::any>>(
          Darabonba_XML::Client::parseXml(bodyStr, nullptr));
      return GetBucketRequestPaymentResponse(Darabonba::Converter::merge(
          map<string, boost::any>(
              {{"RequestPaymentConfiguration",
                (*respMap)["RequestPaymentConfiguration"]}}),
          Darabonba::Converter::toGenericMap(response_->headers)));
    } catch (std::exception &e) {
      if (Darabonba::Core::isRetryable(e)) {
        _lastException = make_shared<std::exception>(e);
        continue;
      }
      BOOST_THROW_EXCEPTION(e);
    }
  }
  BOOST_THROW_EXCEPTION(
      Darabonba::UnretryableError(_lastRequest, _lastException));
}

GetBucketEncryptionResponse Alibabacloud_OSS::Client::getBucketEncryption(
    shared_ptr<GetBucketEncryptionRequest> request,
    shared_ptr<Alibabacloud_OSSUtil::RuntimeOptions> runtime) {
  request->validate();
  runtime->validate();
  shared_ptr<map<string, boost::any>> runtime_ = make_shared<
      map<string, boost::any>>(map<string, boost::any>(
      {{"timeouted", boost::any(string("retry"))},
       {"readTimeout", boost::any(Darabonba_Util::Client::defaultNumber(
                           runtime->readTimeout, _readTimeout))},
       {"connectTimeout", boost::any(Darabonba_Util::Client::defaultNumber(
                              runtime->connectTimeout, _connectTimeout))},
       {"localAddr", boost::any(string(Darabonba_Util::Client::defaultString(
                         runtime->localAddr, _localAddr)))},
       {"httpProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                         runtime->httpProxy, _httpProxy)))},
       {"httpsProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                          runtime->httpsProxy, _httpsProxy)))},
       {"noProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                       runtime->noProxy, _noProxy)))},
       {"socks5Proxy", boost::any(string(Darabonba_Util::Client::defaultString(
                           runtime->socks5Proxy, _socks5Proxy)))},
       {"socks5NetWork",
        boost::any(string(Darabonba_Util::Client::defaultString(
            runtime->socks5NetWork, _socks5NetWork)))},
       {"maxIdleConns", boost::any(Darabonba_Util::Client::defaultNumber(
                            runtime->maxIdleConns, _maxIdleConns))},
       {"retry", boost::any(map<string, boost::any>(
                     {{"retryable", !runtime->autoretry
                                        ? boost::any()
                                        : boost::any(*runtime->autoretry)},
                      {"maxAttempts",
                       boost::any(Darabonba_Util::Client::defaultNumber(
                           runtime->maxAttempts, make_shared<int>(3)))}}))},
       {"backoff",
        boost::any(map<string, boost::any>(
            {{"policy",
              boost::any(string(Darabonba_Util::Client::defaultString(
                  runtime->backoffPolicy, make_shared<string>("no"))))},
             {"period", boost::any(Darabonba_Util::Client::defaultNumber(
                            runtime->backoffPeriod, make_shared<int>(1)))}}))},
       {"ignoreSSL", !runtime->ignoreSSL ? boost::any()
                                         : boost::any(*runtime->ignoreSSL)}}));
  shared_ptr<Darabonba::Request> _lastRequest;
  shared_ptr<std::exception> _lastException;
  shared_ptr<int> _now = make_shared<int>(0);
  shared_ptr<int> _retryTimes = make_shared<int>(0);
  while (Darabonba::Core::allowRetry(
      make_shared<boost::any>((*runtime_)["retry"]), _retryTimes, _now)) {
    if (*_retryTimes > 0) {
      shared_ptr<int> _backoffTime =
          make_shared<int>(Darabonba::Core::getBackoffTime(
              make_shared<boost::any>((*runtime_)["backoff"]), _retryTimes));
      if (*_backoffTime > 0) {
        Darabonba::Core::sleep(_backoffTime);
      }
    }
    _retryTimes = make_shared<int>(*_retryTimes + 1);
    try {
      shared_ptr<Darabonba::Request> request_ =
          make_shared<Darabonba::Request>();
      shared_ptr<string> accessKeyId =
          make_shared<string>(_credential->getAccessKeyId());
      shared_ptr<string> accessKeySecret =
          make_shared<string>(_credential->getAccessKeySecret());
      shared_ptr<string> token =
          make_shared<string>(_credential->getSecurityToken());
      request_->protocol = *_protocol;
      request_->method = "GET";
      request_->pathname = string("/?encryption");
      request_->headers = {
          {"host", Alibabacloud_OSSUtil::Client::getHost(
                       request->bucketName, _regionId, _endpoint, _hostModel)},
          {"date", Darabonba_Util::Client::getDateUTCString()},
          {"user-agent", getUserAgent()}};
      if (!Darabonba_Util::Client::empty(token)) {
        request_->headers.insert(
            pair<string, string>("x-oss-security-token", *token));
      }
      request_->headers.insert(pair<string, string>(
          "authorization",
          Alibabacloud_OSSUtil::Client::getSignature(
              request_, request->bucketName, accessKeyId, accessKeySecret,
              _signatureVersion, _addtionalHeaders)));
      _lastRequest = request_;
      shared_ptr<Darabonba::Response> response_ =
          make_shared<Darabonba::Response>(
              Darabonba::Core::doAction(request_, runtime_));
      shared_ptr<map<string, boost::any>> respMap;
      shared_ptr<string> bodyStr;
      if (Darabonba_Util::Client::is4xx(
              make_shared<int>(response_->statusCode)) ||
          Darabonba_Util::Client::is5xx(
              make_shared<int>(response_->statusCode))) {
        bodyStr = make_shared<string>(
            Darabonba_Util::Client::readAsString(response_->body));
        respMap = make_shared<map<string, boost::any>>(
            Alibabacloud_OSSUtil::Client::getErrMessage(bodyStr));
        BOOST_THROW_EXCEPTION(Darabonba::Error(map<string, boost::any>(
            {{"code", (*respMap)["Code"]},
             {"message", (*respMap)["Message"]},
             {"data", boost::any(map<string, boost::any>(
                          {{"httpCode", boost::any(response_->statusCode)},
                           {"requestId", (*respMap)["RequestId"]},
                           {"hostId", (*respMap)["HostId"]}}))}})));
      }
      bodyStr = make_shared<string>(
          Darabonba_Util::Client::readAsString(response_->body));
      respMap = make_shared<map<string, boost::any>>(
          Darabonba_XML::Client::parseXml(bodyStr, nullptr));
      return GetBucketEncryptionResponse(Darabonba::Converter::merge(
          map<string, boost::any>({{"ServerSideEncryptionRule",
                                    (*respMap)["ServerSideEncryptionRule"]}}),
          Darabonba::Converter::toGenericMap(response_->headers)));
    } catch (std::exception &e) {
      if (Darabonba::Core::isRetryable(e)) {
        _lastException = make_shared<std::exception>(e);
        continue;
      }
      BOOST_THROW_EXCEPTION(e);
    }
  }
  BOOST_THROW_EXCEPTION(
      Darabonba::UnretryableError(_lastRequest, _lastException));
}

GetBucketTagsResponse Alibabacloud_OSS::Client::getBucketTags(
    shared_ptr<GetBucketTagsRequest> request,
    shared_ptr<Alibabacloud_OSSUtil::RuntimeOptions> runtime) {
  request->validate();
  runtime->validate();
  shared_ptr<map<string, boost::any>> runtime_ = make_shared<
      map<string, boost::any>>(map<string, boost::any>(
      {{"timeouted", boost::any(string("retry"))},
       {"readTimeout", boost::any(Darabonba_Util::Client::defaultNumber(
                           runtime->readTimeout, _readTimeout))},
       {"connectTimeout", boost::any(Darabonba_Util::Client::defaultNumber(
                              runtime->connectTimeout, _connectTimeout))},
       {"localAddr", boost::any(string(Darabonba_Util::Client::defaultString(
                         runtime->localAddr, _localAddr)))},
       {"httpProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                         runtime->httpProxy, _httpProxy)))},
       {"httpsProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                          runtime->httpsProxy, _httpsProxy)))},
       {"noProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                       runtime->noProxy, _noProxy)))},
       {"socks5Proxy", boost::any(string(Darabonba_Util::Client::defaultString(
                           runtime->socks5Proxy, _socks5Proxy)))},
       {"socks5NetWork",
        boost::any(string(Darabonba_Util::Client::defaultString(
            runtime->socks5NetWork, _socks5NetWork)))},
       {"maxIdleConns", boost::any(Darabonba_Util::Client::defaultNumber(
                            runtime->maxIdleConns, _maxIdleConns))},
       {"retry", boost::any(map<string, boost::any>(
                     {{"retryable", !runtime->autoretry
                                        ? boost::any()
                                        : boost::any(*runtime->autoretry)},
                      {"maxAttempts",
                       boost::any(Darabonba_Util::Client::defaultNumber(
                           runtime->maxAttempts, make_shared<int>(3)))}}))},
       {"backoff",
        boost::any(map<string, boost::any>(
            {{"policy",
              boost::any(string(Darabonba_Util::Client::defaultString(
                  runtime->backoffPolicy, make_shared<string>("no"))))},
             {"period", boost::any(Darabonba_Util::Client::defaultNumber(
                            runtime->backoffPeriod, make_shared<int>(1)))}}))},
       {"ignoreSSL", !runtime->ignoreSSL ? boost::any()
                                         : boost::any(*runtime->ignoreSSL)}}));
  shared_ptr<Darabonba::Request> _lastRequest;
  shared_ptr<std::exception> _lastException;
  shared_ptr<int> _now = make_shared<int>(0);
  shared_ptr<int> _retryTimes = make_shared<int>(0);
  while (Darabonba::Core::allowRetry(
      make_shared<boost::any>((*runtime_)["retry"]), _retryTimes, _now)) {
    if (*_retryTimes > 0) {
      shared_ptr<int> _backoffTime =
          make_shared<int>(Darabonba::Core::getBackoffTime(
              make_shared<boost::any>((*runtime_)["backoff"]), _retryTimes));
      if (*_backoffTime > 0) {
        Darabonba::Core::sleep(_backoffTime);
      }
    }
    _retryTimes = make_shared<int>(*_retryTimes + 1);
    try {
      shared_ptr<Darabonba::Request> request_ =
          make_shared<Darabonba::Request>();
      shared_ptr<string> accessKeyId =
          make_shared<string>(_credential->getAccessKeyId());
      shared_ptr<string> accessKeySecret =
          make_shared<string>(_credential->getAccessKeySecret());
      shared_ptr<string> token =
          make_shared<string>(_credential->getSecurityToken());
      request_->protocol = *_protocol;
      request_->method = "GET";
      request_->pathname = string("/?tagging");
      request_->headers = {
          {"host", Alibabacloud_OSSUtil::Client::getHost(
                       request->bucketName, _regionId, _endpoint, _hostModel)},
          {"date", Darabonba_Util::Client::getDateUTCString()},
          {"user-agent", getUserAgent()}};
      if (!Darabonba_Util::Client::empty(token)) {
        request_->headers.insert(
            pair<string, string>("x-oss-security-token", *token));
      }
      request_->headers.insert(pair<string, string>(
          "authorization",
          Alibabacloud_OSSUtil::Client::getSignature(
              request_, request->bucketName, accessKeyId, accessKeySecret,
              _signatureVersion, _addtionalHeaders)));
      _lastRequest = request_;
      shared_ptr<Darabonba::Response> response_ =
          make_shared<Darabonba::Response>(
              Darabonba::Core::doAction(request_, runtime_));
      shared_ptr<map<string, boost::any>> respMap;
      shared_ptr<string> bodyStr;
      if (Darabonba_Util::Client::is4xx(
              make_shared<int>(response_->statusCode)) ||
          Darabonba_Util::Client::is5xx(
              make_shared<int>(response_->statusCode))) {
        bodyStr = make_shared<string>(
            Darabonba_Util::Client::readAsString(response_->body));
        respMap = make_shared<map<string, boost::any>>(
            Alibabacloud_OSSUtil::Client::getErrMessage(bodyStr));
        BOOST_THROW_EXCEPTION(Darabonba::Error(map<string, boost::any>(
            {{"code", (*respMap)["Code"]},
             {"message", (*respMap)["Message"]},
             {"data", boost::any(map<string, boost::any>(
                          {{"httpCode", boost::any(response_->statusCode)},
                           {"requestId", (*respMap)["RequestId"]},
                           {"hostId", (*respMap)["HostId"]}}))}})));
      }
      bodyStr = make_shared<string>(
          Darabonba_Util::Client::readAsString(response_->body));
      respMap = make_shared<map<string, boost::any>>(
          Darabonba_XML::Client::parseXml(bodyStr, nullptr));
      return GetBucketTagsResponse(Darabonba::Converter::merge(
          map<string, boost::any>({{"Tagging", (*respMap)["Tagging"]}}),
          Darabonba::Converter::toGenericMap(response_->headers)));
    } catch (std::exception &e) {
      if (Darabonba::Core::isRetryable(e)) {
        _lastException = make_shared<std::exception>(e);
        continue;
      }
      BOOST_THROW_EXCEPTION(e);
    }
  }
  BOOST_THROW_EXCEPTION(
      Darabonba::UnretryableError(_lastRequest, _lastException));
}

GetServiceResponse Alibabacloud_OSS::Client::getService(
    shared_ptr<GetServiceRequest> request,
    shared_ptr<Alibabacloud_OSSUtil::RuntimeOptions> runtime) {
  request->validate();
  runtime->validate();
  shared_ptr<map<string, boost::any>> runtime_ = make_shared<
      map<string, boost::any>>(map<string, boost::any>(
      {{"timeouted", boost::any(string("retry"))},
       {"readTimeout", boost::any(Darabonba_Util::Client::defaultNumber(
                           runtime->readTimeout, _readTimeout))},
       {"connectTimeout", boost::any(Darabonba_Util::Client::defaultNumber(
                              runtime->connectTimeout, _connectTimeout))},
       {"localAddr", boost::any(string(Darabonba_Util::Client::defaultString(
                         runtime->localAddr, _localAddr)))},
       {"httpProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                         runtime->httpProxy, _httpProxy)))},
       {"httpsProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                          runtime->httpsProxy, _httpsProxy)))},
       {"noProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                       runtime->noProxy, _noProxy)))},
       {"socks5Proxy", boost::any(string(Darabonba_Util::Client::defaultString(
                           runtime->socks5Proxy, _socks5Proxy)))},
       {"socks5NetWork",
        boost::any(string(Darabonba_Util::Client::defaultString(
            runtime->socks5NetWork, _socks5NetWork)))},
       {"maxIdleConns", boost::any(Darabonba_Util::Client::defaultNumber(
                            runtime->maxIdleConns, _maxIdleConns))},
       {"retry", boost::any(map<string, boost::any>(
                     {{"retryable", !runtime->autoretry
                                        ? boost::any()
                                        : boost::any(*runtime->autoretry)},
                      {"maxAttempts",
                       boost::any(Darabonba_Util::Client::defaultNumber(
                           runtime->maxAttempts, make_shared<int>(3)))}}))},
       {"backoff",
        boost::any(map<string, boost::any>(
            {{"policy",
              boost::any(string(Darabonba_Util::Client::defaultString(
                  runtime->backoffPolicy, make_shared<string>("no"))))},
             {"period", boost::any(Darabonba_Util::Client::defaultNumber(
                            runtime->backoffPeriod, make_shared<int>(1)))}}))},
       {"ignoreSSL", !runtime->ignoreSSL ? boost::any()
                                         : boost::any(*runtime->ignoreSSL)}}));
  shared_ptr<Darabonba::Request> _lastRequest;
  shared_ptr<std::exception> _lastException;
  shared_ptr<int> _now = make_shared<int>(0);
  shared_ptr<int> _retryTimes = make_shared<int>(0);
  while (Darabonba::Core::allowRetry(
      make_shared<boost::any>((*runtime_)["retry"]), _retryTimes, _now)) {
    if (*_retryTimes > 0) {
      shared_ptr<int> _backoffTime =
          make_shared<int>(Darabonba::Core::getBackoffTime(
              make_shared<boost::any>((*runtime_)["backoff"]), _retryTimes));
      if (*_backoffTime > 0) {
        Darabonba::Core::sleep(_backoffTime);
      }
    }
    _retryTimes = make_shared<int>(*_retryTimes + 1);
    try {
      shared_ptr<Darabonba::Request> request_ =
          make_shared<Darabonba::Request>();
      shared_ptr<string> accessKeyId =
          make_shared<string>(_credential->getAccessKeyId());
      shared_ptr<string> accessKeySecret =
          make_shared<string>(_credential->getAccessKeySecret());
      shared_ptr<string> token =
          make_shared<string>(_credential->getSecurityToken());
      request_->protocol = *_protocol;
      request_->method = "GET";
      request_->pathname = string("/");
      request_->headers = {{"host", Alibabacloud_OSSUtil::Client::getHost(
                                        make_shared<string>(""), _regionId,
                                        _endpoint, _hostModel)},
                           {"date", Darabonba_Util::Client::getDateUTCString()},
                           {"user-agent", getUserAgent()}};
      if (!Darabonba_Util::Client::empty(token)) {
        request_->headers.insert(
            pair<string, string>("x-oss-security-token", *token));
      }
      request_->query = Darabonba_Util::Client::stringifyMapValue(
          make_shared<map<string, boost::any>>(request->filter->toMap()));
      request_->headers.insert(pair<string, string>(
          "authorization",
          Alibabacloud_OSSUtil::Client::getSignature(
              request_, make_shared<string>(""), accessKeyId, accessKeySecret,
              _signatureVersion, _addtionalHeaders)));
      _lastRequest = request_;
      shared_ptr<Darabonba::Response> response_ =
          make_shared<Darabonba::Response>(
              Darabonba::Core::doAction(request_, runtime_));
      shared_ptr<map<string, boost::any>> respMap;
      shared_ptr<string> bodyStr;
      if (Darabonba_Util::Client::is4xx(
              make_shared<int>(response_->statusCode)) ||
          Darabonba_Util::Client::is5xx(
              make_shared<int>(response_->statusCode))) {
        bodyStr = make_shared<string>(
            Darabonba_Util::Client::readAsString(response_->body));
        respMap = make_shared<map<string, boost::any>>(
            Alibabacloud_OSSUtil::Client::getErrMessage(bodyStr));
        BOOST_THROW_EXCEPTION(Darabonba::Error(map<string, boost::any>(
            {{"code", (*respMap)["Code"]},
             {"message", (*respMap)["Message"]},
             {"data", boost::any(map<string, boost::any>(
                          {{"httpCode", boost::any(response_->statusCode)},
                           {"requestId", (*respMap)["RequestId"]},
                           {"hostId", (*respMap)["HostId"]}}))}})));
      }
      bodyStr = make_shared<string>(
          Darabonba_Util::Client::readAsString(response_->body));
      respMap = make_shared<map<string, boost::any>>(
          Darabonba_XML::Client::parseXml(bodyStr, nullptr));
      return GetServiceResponse(Darabonba::Converter::merge(
          map<string, boost::any>({{"ListAllMyBucketsResult",
                                    (*respMap)["ListAllMyBucketsResult"]}}),
          Darabonba::Converter::toGenericMap(response_->headers)));
    } catch (std::exception &e) {
      if (Darabonba::Core::isRetryable(e)) {
        _lastException = make_shared<std::exception>(e);
        continue;
      }
      BOOST_THROW_EXCEPTION(e);
    }
  }
  BOOST_THROW_EXCEPTION(
      Darabonba::UnretryableError(_lastRequest, _lastException));
}

DeleteBucketEncryptionResponse Alibabacloud_OSS::Client::deleteBucketEncryption(
    shared_ptr<DeleteBucketEncryptionRequest> request,
    shared_ptr<Alibabacloud_OSSUtil::RuntimeOptions> runtime) {
  request->validate();
  runtime->validate();
  shared_ptr<map<string, boost::any>> runtime_ = make_shared<
      map<string, boost::any>>(map<string, boost::any>(
      {{"timeouted", boost::any(string("retry"))},
       {"readTimeout", boost::any(Darabonba_Util::Client::defaultNumber(
                           runtime->readTimeout, _readTimeout))},
       {"connectTimeout", boost::any(Darabonba_Util::Client::defaultNumber(
                              runtime->connectTimeout, _connectTimeout))},
       {"localAddr", boost::any(string(Darabonba_Util::Client::defaultString(
                         runtime->localAddr, _localAddr)))},
       {"httpProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                         runtime->httpProxy, _httpProxy)))},
       {"httpsProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                          runtime->httpsProxy, _httpsProxy)))},
       {"noProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                       runtime->noProxy, _noProxy)))},
       {"socks5Proxy", boost::any(string(Darabonba_Util::Client::defaultString(
                           runtime->socks5Proxy, _socks5Proxy)))},
       {"socks5NetWork",
        boost::any(string(Darabonba_Util::Client::defaultString(
            runtime->socks5NetWork, _socks5NetWork)))},
       {"maxIdleConns", boost::any(Darabonba_Util::Client::defaultNumber(
                            runtime->maxIdleConns, _maxIdleConns))},
       {"retry", boost::any(map<string, boost::any>(
                     {{"retryable", !runtime->autoretry
                                        ? boost::any()
                                        : boost::any(*runtime->autoretry)},
                      {"maxAttempts",
                       boost::any(Darabonba_Util::Client::defaultNumber(
                           runtime->maxAttempts, make_shared<int>(3)))}}))},
       {"backoff",
        boost::any(map<string, boost::any>(
            {{"policy",
              boost::any(string(Darabonba_Util::Client::defaultString(
                  runtime->backoffPolicy, make_shared<string>("no"))))},
             {"period", boost::any(Darabonba_Util::Client::defaultNumber(
                            runtime->backoffPeriod, make_shared<int>(1)))}}))},
       {"ignoreSSL", !runtime->ignoreSSL ? boost::any()
                                         : boost::any(*runtime->ignoreSSL)}}));
  shared_ptr<Darabonba::Request> _lastRequest;
  shared_ptr<std::exception> _lastException;
  shared_ptr<int> _now = make_shared<int>(0);
  shared_ptr<int> _retryTimes = make_shared<int>(0);
  while (Darabonba::Core::allowRetry(
      make_shared<boost::any>((*runtime_)["retry"]), _retryTimes, _now)) {
    if (*_retryTimes > 0) {
      shared_ptr<int> _backoffTime =
          make_shared<int>(Darabonba::Core::getBackoffTime(
              make_shared<boost::any>((*runtime_)["backoff"]), _retryTimes));
      if (*_backoffTime > 0) {
        Darabonba::Core::sleep(_backoffTime);
      }
    }
    _retryTimes = make_shared<int>(*_retryTimes + 1);
    try {
      shared_ptr<Darabonba::Request> request_ =
          make_shared<Darabonba::Request>();
      shared_ptr<string> accessKeyId =
          make_shared<string>(_credential->getAccessKeyId());
      shared_ptr<string> accessKeySecret =
          make_shared<string>(_credential->getAccessKeySecret());
      shared_ptr<string> token =
          make_shared<string>(_credential->getSecurityToken());
      request_->protocol = *_protocol;
      request_->method = "DELETE";
      request_->pathname = string("/?encryption");
      request_->headers = {
          {"host", Alibabacloud_OSSUtil::Client::getHost(
                       request->bucketName, _regionId, _endpoint, _hostModel)},
          {"date", Darabonba_Util::Client::getDateUTCString()},
          {"user-agent", getUserAgent()}};
      if (!Darabonba_Util::Client::empty(token)) {
        request_->headers.insert(
            pair<string, string>("x-oss-security-token", *token));
      }
      request_->headers.insert(pair<string, string>(
          "authorization",
          Alibabacloud_OSSUtil::Client::getSignature(
              request_, request->bucketName, accessKeyId, accessKeySecret,
              _signatureVersion, _addtionalHeaders)));
      _lastRequest = request_;
      shared_ptr<Darabonba::Response> response_ =
          make_shared<Darabonba::Response>(
              Darabonba::Core::doAction(request_, runtime_));
      shared_ptr<map<string, boost::any>> respMap;
      shared_ptr<string> bodyStr;
      if (Darabonba_Util::Client::is4xx(
              make_shared<int>(response_->statusCode)) ||
          Darabonba_Util::Client::is5xx(
              make_shared<int>(response_->statusCode))) {
        bodyStr = make_shared<string>(
            Darabonba_Util::Client::readAsString(response_->body));
        respMap = make_shared<map<string, boost::any>>(
            Alibabacloud_OSSUtil::Client::getErrMessage(bodyStr));
        BOOST_THROW_EXCEPTION(Darabonba::Error(map<string, boost::any>(
            {{"code", (*respMap)["Code"]},
             {"message", (*respMap)["Message"]},
             {"data", boost::any(map<string, boost::any>(
                          {{"httpCode", boost::any(response_->statusCode)},
                           {"requestId", (*respMap)["RequestId"]},
                           {"hostId", (*respMap)["HostId"]}}))}})));
      }
      return DeleteBucketEncryptionResponse(
          Darabonba::Converter::toGenericMap(Darabonba::Converter::merge(
              map<string, string>(), response_->headers)));
    } catch (std::exception &e) {
      if (Darabonba::Core::isRetryable(e)) {
        _lastException = make_shared<std::exception>(e);
        continue;
      }
      BOOST_THROW_EXCEPTION(e);
    }
  }
  BOOST_THROW_EXCEPTION(
      Darabonba::UnretryableError(_lastRequest, _lastException));
}

DeleteBucketTagsResponse Alibabacloud_OSS::Client::deleteBucketTags(
    shared_ptr<DeleteBucketTagsRequest> request,
    shared_ptr<Alibabacloud_OSSUtil::RuntimeOptions> runtime) {
  request->validate();
  runtime->validate();
  shared_ptr<map<string, boost::any>> runtime_ = make_shared<
      map<string, boost::any>>(map<string, boost::any>(
      {{"timeouted", boost::any(string("retry"))},
       {"readTimeout", boost::any(Darabonba_Util::Client::defaultNumber(
                           runtime->readTimeout, _readTimeout))},
       {"connectTimeout", boost::any(Darabonba_Util::Client::defaultNumber(
                              runtime->connectTimeout, _connectTimeout))},
       {"localAddr", boost::any(string(Darabonba_Util::Client::defaultString(
                         runtime->localAddr, _localAddr)))},
       {"httpProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                         runtime->httpProxy, _httpProxy)))},
       {"httpsProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                          runtime->httpsProxy, _httpsProxy)))},
       {"noProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                       runtime->noProxy, _noProxy)))},
       {"socks5Proxy", boost::any(string(Darabonba_Util::Client::defaultString(
                           runtime->socks5Proxy, _socks5Proxy)))},
       {"socks5NetWork",
        boost::any(string(Darabonba_Util::Client::defaultString(
            runtime->socks5NetWork, _socks5NetWork)))},
       {"maxIdleConns", boost::any(Darabonba_Util::Client::defaultNumber(
                            runtime->maxIdleConns, _maxIdleConns))},
       {"retry", boost::any(map<string, boost::any>(
                     {{"retryable", !runtime->autoretry
                                        ? boost::any()
                                        : boost::any(*runtime->autoretry)},
                      {"maxAttempts",
                       boost::any(Darabonba_Util::Client::defaultNumber(
                           runtime->maxAttempts, make_shared<int>(3)))}}))},
       {"backoff",
        boost::any(map<string, boost::any>(
            {{"policy",
              boost::any(string(Darabonba_Util::Client::defaultString(
                  runtime->backoffPolicy, make_shared<string>("no"))))},
             {"period", boost::any(Darabonba_Util::Client::defaultNumber(
                            runtime->backoffPeriod, make_shared<int>(1)))}}))},
       {"ignoreSSL", !runtime->ignoreSSL ? boost::any()
                                         : boost::any(*runtime->ignoreSSL)}}));
  shared_ptr<Darabonba::Request> _lastRequest;
  shared_ptr<std::exception> _lastException;
  shared_ptr<int> _now = make_shared<int>(0);
  shared_ptr<int> _retryTimes = make_shared<int>(0);
  while (Darabonba::Core::allowRetry(
      make_shared<boost::any>((*runtime_)["retry"]), _retryTimes, _now)) {
    if (*_retryTimes > 0) {
      shared_ptr<int> _backoffTime =
          make_shared<int>(Darabonba::Core::getBackoffTime(
              make_shared<boost::any>((*runtime_)["backoff"]), _retryTimes));
      if (*_backoffTime > 0) {
        Darabonba::Core::sleep(_backoffTime);
      }
    }
    _retryTimes = make_shared<int>(*_retryTimes + 1);
    try {
      shared_ptr<Darabonba::Request> request_ =
          make_shared<Darabonba::Request>();
      shared_ptr<string> accessKeyId =
          make_shared<string>(_credential->getAccessKeyId());
      shared_ptr<string> accessKeySecret =
          make_shared<string>(_credential->getAccessKeySecret());
      shared_ptr<string> token =
          make_shared<string>(_credential->getSecurityToken());
      request_->protocol = *_protocol;
      request_->method = "DELETE";
      request_->pathname = string("/");
      request_->headers = {
          {"host", Alibabacloud_OSSUtil::Client::getHost(
                       request->bucketName, _regionId, _endpoint, _hostModel)},
          {"date", Darabonba_Util::Client::getDateUTCString()},
          {"user-agent", getUserAgent()}};
      if (!Darabonba_Util::Client::empty(token)) {
        request_->headers.insert(
            pair<string, string>("x-oss-security-token", *token));
      }
      request_->query = Darabonba_Util::Client::stringifyMapValue(
          make_shared<map<string, boost::any>>(request->filter->toMap()));
      request_->headers.insert(pair<string, string>(
          "authorization",
          Alibabacloud_OSSUtil::Client::getSignature(
              request_, request->bucketName, accessKeyId, accessKeySecret,
              _signatureVersion, _addtionalHeaders)));
      _lastRequest = request_;
      shared_ptr<Darabonba::Response> response_ =
          make_shared<Darabonba::Response>(
              Darabonba::Core::doAction(request_, runtime_));
      shared_ptr<map<string, boost::any>> respMap;
      shared_ptr<string> bodyStr;
      if (Darabonba_Util::Client::is4xx(
              make_shared<int>(response_->statusCode)) ||
          Darabonba_Util::Client::is5xx(
              make_shared<int>(response_->statusCode))) {
        bodyStr = make_shared<string>(
            Darabonba_Util::Client::readAsString(response_->body));
        respMap = make_shared<map<string, boost::any>>(
            Alibabacloud_OSSUtil::Client::getErrMessage(bodyStr));
        BOOST_THROW_EXCEPTION(Darabonba::Error(map<string, boost::any>(
            {{"code", (*respMap)["Code"]},
             {"message", (*respMap)["Message"]},
             {"data", boost::any(map<string, boost::any>(
                          {{"httpCode", boost::any(response_->statusCode)},
                           {"requestId", (*respMap)["RequestId"]},
                           {"hostId", (*respMap)["HostId"]}}))}})));
      }
      return DeleteBucketTagsResponse(
          Darabonba::Converter::toGenericMap(Darabonba::Converter::merge(
              map<string, string>(), response_->headers)));
    } catch (std::exception &e) {
      if (Darabonba::Core::isRetryable(e)) {
        _lastException = make_shared<std::exception>(e);
        continue;
      }
      BOOST_THROW_EXCEPTION(e);
    }
  }
  BOOST_THROW_EXCEPTION(
      Darabonba::UnretryableError(_lastRequest, _lastException));
}

GetBucketWebsiteResponse Alibabacloud_OSS::Client::getBucketWebsite(
    shared_ptr<GetBucketWebsiteRequest> request,
    shared_ptr<Alibabacloud_OSSUtil::RuntimeOptions> runtime) {
  request->validate();
  runtime->validate();
  shared_ptr<map<string, boost::any>> runtime_ = make_shared<
      map<string, boost::any>>(map<string, boost::any>(
      {{"timeouted", boost::any(string("retry"))},
       {"readTimeout", boost::any(Darabonba_Util::Client::defaultNumber(
                           runtime->readTimeout, _readTimeout))},
       {"connectTimeout", boost::any(Darabonba_Util::Client::defaultNumber(
                              runtime->connectTimeout, _connectTimeout))},
       {"localAddr", boost::any(string(Darabonba_Util::Client::defaultString(
                         runtime->localAddr, _localAddr)))},
       {"httpProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                         runtime->httpProxy, _httpProxy)))},
       {"httpsProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                          runtime->httpsProxy, _httpsProxy)))},
       {"noProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                       runtime->noProxy, _noProxy)))},
       {"socks5Proxy", boost::any(string(Darabonba_Util::Client::defaultString(
                           runtime->socks5Proxy, _socks5Proxy)))},
       {"socks5NetWork",
        boost::any(string(Darabonba_Util::Client::defaultString(
            runtime->socks5NetWork, _socks5NetWork)))},
       {"maxIdleConns", boost::any(Darabonba_Util::Client::defaultNumber(
                            runtime->maxIdleConns, _maxIdleConns))},
       {"retry", boost::any(map<string, boost::any>(
                     {{"retryable", !runtime->autoretry
                                        ? boost::any()
                                        : boost::any(*runtime->autoretry)},
                      {"maxAttempts",
                       boost::any(Darabonba_Util::Client::defaultNumber(
                           runtime->maxAttempts, make_shared<int>(3)))}}))},
       {"backoff",
        boost::any(map<string, boost::any>(
            {{"policy",
              boost::any(string(Darabonba_Util::Client::defaultString(
                  runtime->backoffPolicy, make_shared<string>("no"))))},
             {"period", boost::any(Darabonba_Util::Client::defaultNumber(
                            runtime->backoffPeriod, make_shared<int>(1)))}}))},
       {"ignoreSSL", !runtime->ignoreSSL ? boost::any()
                                         : boost::any(*runtime->ignoreSSL)}}));
  shared_ptr<Darabonba::Request> _lastRequest;
  shared_ptr<std::exception> _lastException;
  shared_ptr<int> _now = make_shared<int>(0);
  shared_ptr<int> _retryTimes = make_shared<int>(0);
  while (Darabonba::Core::allowRetry(
      make_shared<boost::any>((*runtime_)["retry"]), _retryTimes, _now)) {
    if (*_retryTimes > 0) {
      shared_ptr<int> _backoffTime =
          make_shared<int>(Darabonba::Core::getBackoffTime(
              make_shared<boost::any>((*runtime_)["backoff"]), _retryTimes));
      if (*_backoffTime > 0) {
        Darabonba::Core::sleep(_backoffTime);
      }
    }
    _retryTimes = make_shared<int>(*_retryTimes + 1);
    try {
      shared_ptr<Darabonba::Request> request_ =
          make_shared<Darabonba::Request>();
      shared_ptr<string> accessKeyId =
          make_shared<string>(_credential->getAccessKeyId());
      shared_ptr<string> accessKeySecret =
          make_shared<string>(_credential->getAccessKeySecret());
      shared_ptr<string> token =
          make_shared<string>(_credential->getSecurityToken());
      request_->protocol = *_protocol;
      request_->method = "GET";
      request_->pathname = string("/?website");
      request_->headers = {
          {"host", Alibabacloud_OSSUtil::Client::getHost(
                       request->bucketName, _regionId, _endpoint, _hostModel)},
          {"date", Darabonba_Util::Client::getDateUTCString()},
          {"user-agent", getUserAgent()}};
      if (!Darabonba_Util::Client::empty(token)) {
        request_->headers.insert(
            pair<string, string>("x-oss-security-token", *token));
      }
      request_->headers.insert(pair<string, string>(
          "authorization",
          Alibabacloud_OSSUtil::Client::getSignature(
              request_, request->bucketName, accessKeyId, accessKeySecret,
              _signatureVersion, _addtionalHeaders)));
      _lastRequest = request_;
      shared_ptr<Darabonba::Response> response_ =
          make_shared<Darabonba::Response>(
              Darabonba::Core::doAction(request_, runtime_));
      shared_ptr<map<string, boost::any>> respMap;
      shared_ptr<string> bodyStr;
      if (Darabonba_Util::Client::is4xx(
              make_shared<int>(response_->statusCode)) ||
          Darabonba_Util::Client::is5xx(
              make_shared<int>(response_->statusCode))) {
        bodyStr = make_shared<string>(
            Darabonba_Util::Client::readAsString(response_->body));
        respMap = make_shared<map<string, boost::any>>(
            Alibabacloud_OSSUtil::Client::getErrMessage(bodyStr));
        BOOST_THROW_EXCEPTION(Darabonba::Error(map<string, boost::any>(
            {{"code", (*respMap)["Code"]},
             {"message", (*respMap)["Message"]},
             {"data", boost::any(map<string, boost::any>(
                          {{"httpCode", boost::any(response_->statusCode)},
                           {"requestId", (*respMap)["RequestId"]},
                           {"hostId", (*respMap)["HostId"]}}))}})));
      }
      bodyStr = make_shared<string>(
          Darabonba_Util::Client::readAsString(response_->body));
      respMap = make_shared<map<string, boost::any>>(
          Darabonba_XML::Client::parseXml(bodyStr, nullptr));
      return GetBucketWebsiteResponse(Darabonba::Converter::merge(
          map<string, boost::any>(
              {{"WebsiteConfiguration", (*respMap)["WebsiteConfiguration"]}}),
          Darabonba::Converter::toGenericMap(response_->headers)));
    } catch (std::exception &e) {
      if (Darabonba::Core::isRetryable(e)) {
        _lastException = make_shared<std::exception>(e);
        continue;
      }
      BOOST_THROW_EXCEPTION(e);
    }
  }
  BOOST_THROW_EXCEPTION(
      Darabonba::UnretryableError(_lastRequest, _lastException));
}

DeleteLiveChannelResponse Alibabacloud_OSS::Client::deleteLiveChannel(
    shared_ptr<DeleteLiveChannelRequest> request,
    shared_ptr<Alibabacloud_OSSUtil::RuntimeOptions> runtime) {
  request->validate();
  runtime->validate();
  shared_ptr<map<string, boost::any>> runtime_ = make_shared<
      map<string, boost::any>>(map<string, boost::any>(
      {{"timeouted", boost::any(string("retry"))},
       {"readTimeout", boost::any(Darabonba_Util::Client::defaultNumber(
                           runtime->readTimeout, _readTimeout))},
       {"connectTimeout", boost::any(Darabonba_Util::Client::defaultNumber(
                              runtime->connectTimeout, _connectTimeout))},
       {"localAddr", boost::any(string(Darabonba_Util::Client::defaultString(
                         runtime->localAddr, _localAddr)))},
       {"httpProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                         runtime->httpProxy, _httpProxy)))},
       {"httpsProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                          runtime->httpsProxy, _httpsProxy)))},
       {"noProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                       runtime->noProxy, _noProxy)))},
       {"socks5Proxy", boost::any(string(Darabonba_Util::Client::defaultString(
                           runtime->socks5Proxy, _socks5Proxy)))},
       {"socks5NetWork",
        boost::any(string(Darabonba_Util::Client::defaultString(
            runtime->socks5NetWork, _socks5NetWork)))},
       {"maxIdleConns", boost::any(Darabonba_Util::Client::defaultNumber(
                            runtime->maxIdleConns, _maxIdleConns))},
       {"retry", boost::any(map<string, boost::any>(
                     {{"retryable", !runtime->autoretry
                                        ? boost::any()
                                        : boost::any(*runtime->autoretry)},
                      {"maxAttempts",
                       boost::any(Darabonba_Util::Client::defaultNumber(
                           runtime->maxAttempts, make_shared<int>(3)))}}))},
       {"backoff",
        boost::any(map<string, boost::any>(
            {{"policy",
              boost::any(string(Darabonba_Util::Client::defaultString(
                  runtime->backoffPolicy, make_shared<string>("no"))))},
             {"period", boost::any(Darabonba_Util::Client::defaultNumber(
                            runtime->backoffPeriod, make_shared<int>(1)))}}))},
       {"ignoreSSL", !runtime->ignoreSSL ? boost::any()
                                         : boost::any(*runtime->ignoreSSL)}}));
  shared_ptr<Darabonba::Request> _lastRequest;
  shared_ptr<std::exception> _lastException;
  shared_ptr<int> _now = make_shared<int>(0);
  shared_ptr<int> _retryTimes = make_shared<int>(0);
  while (Darabonba::Core::allowRetry(
      make_shared<boost::any>((*runtime_)["retry"]), _retryTimes, _now)) {
    if (*_retryTimes > 0) {
      shared_ptr<int> _backoffTime =
          make_shared<int>(Darabonba::Core::getBackoffTime(
              make_shared<boost::any>((*runtime_)["backoff"]), _retryTimes));
      if (*_backoffTime > 0) {
        Darabonba::Core::sleep(_backoffTime);
      }
    }
    _retryTimes = make_shared<int>(*_retryTimes + 1);
    try {
      shared_ptr<Darabonba::Request> request_ =
          make_shared<Darabonba::Request>();
      shared_ptr<string> accessKeyId =
          make_shared<string>(_credential->getAccessKeyId());
      shared_ptr<string> accessKeySecret =
          make_shared<string>(_credential->getAccessKeySecret());
      shared_ptr<string> token =
          make_shared<string>(_credential->getSecurityToken());
      request_->protocol = *_protocol;
      request_->method = "DELETE";
      request_->pathname = string("/" + *request->channelName + "?live");
      request_->headers = {
          {"host", Alibabacloud_OSSUtil::Client::getHost(
                       request->bucketName, _regionId, _endpoint, _hostModel)},
          {"date", Darabonba_Util::Client::getDateUTCString()},
          {"user-agent", getUserAgent()}};
      if (!Darabonba_Util::Client::empty(token)) {
        request_->headers.insert(
            pair<string, string>("x-oss-security-token", *token));
      }
      request_->headers.insert(pair<string, string>(
          "authorization",
          Alibabacloud_OSSUtil::Client::getSignature(
              request_, request->bucketName, accessKeyId, accessKeySecret,
              _signatureVersion, _addtionalHeaders)));
      _lastRequest = request_;
      shared_ptr<Darabonba::Response> response_ =
          make_shared<Darabonba::Response>(
              Darabonba::Core::doAction(request_, runtime_));
      shared_ptr<map<string, boost::any>> respMap;
      shared_ptr<string> bodyStr;
      if (Darabonba_Util::Client::is4xx(
              make_shared<int>(response_->statusCode)) ||
          Darabonba_Util::Client::is5xx(
              make_shared<int>(response_->statusCode))) {
        bodyStr = make_shared<string>(
            Darabonba_Util::Client::readAsString(response_->body));
        respMap = make_shared<map<string, boost::any>>(
            Alibabacloud_OSSUtil::Client::getErrMessage(bodyStr));
        BOOST_THROW_EXCEPTION(Darabonba::Error(map<string, boost::any>(
            {{"code", (*respMap)["Code"]},
             {"message", (*respMap)["Message"]},
             {"data", boost::any(map<string, boost::any>(
                          {{"httpCode", boost::any(response_->statusCode)},
                           {"requestId", (*respMap)["RequestId"]},
                           {"hostId", (*respMap)["HostId"]}}))}})));
      }
      return DeleteLiveChannelResponse(
          Darabonba::Converter::toGenericMap(Darabonba::Converter::merge(
              map<string, string>(), response_->headers)));
    } catch (std::exception &e) {
      if (Darabonba::Core::isRetryable(e)) {
        _lastException = make_shared<std::exception>(e);
        continue;
      }
      BOOST_THROW_EXCEPTION(e);
    }
  }
  BOOST_THROW_EXCEPTION(
      Darabonba::UnretryableError(_lastRequest, _lastException));
}

GetBucketLocationResponse Alibabacloud_OSS::Client::getBucketLocation(
    shared_ptr<GetBucketLocationRequest> request,
    shared_ptr<Alibabacloud_OSSUtil::RuntimeOptions> runtime) {
  request->validate();
  runtime->validate();
  shared_ptr<map<string, boost::any>> runtime_ = make_shared<
      map<string, boost::any>>(map<string, boost::any>(
      {{"timeouted", boost::any(string("retry"))},
       {"readTimeout", boost::any(Darabonba_Util::Client::defaultNumber(
                           runtime->readTimeout, _readTimeout))},
       {"connectTimeout", boost::any(Darabonba_Util::Client::defaultNumber(
                              runtime->connectTimeout, _connectTimeout))},
       {"localAddr", boost::any(string(Darabonba_Util::Client::defaultString(
                         runtime->localAddr, _localAddr)))},
       {"httpProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                         runtime->httpProxy, _httpProxy)))},
       {"httpsProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                          runtime->httpsProxy, _httpsProxy)))},
       {"noProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                       runtime->noProxy, _noProxy)))},
       {"socks5Proxy", boost::any(string(Darabonba_Util::Client::defaultString(
                           runtime->socks5Proxy, _socks5Proxy)))},
       {"socks5NetWork",
        boost::any(string(Darabonba_Util::Client::defaultString(
            runtime->socks5NetWork, _socks5NetWork)))},
       {"maxIdleConns", boost::any(Darabonba_Util::Client::defaultNumber(
                            runtime->maxIdleConns, _maxIdleConns))},
       {"retry", boost::any(map<string, boost::any>(
                     {{"retryable", !runtime->autoretry
                                        ? boost::any()
                                        : boost::any(*runtime->autoretry)},
                      {"maxAttempts",
                       boost::any(Darabonba_Util::Client::defaultNumber(
                           runtime->maxAttempts, make_shared<int>(3)))}}))},
       {"backoff",
        boost::any(map<string, boost::any>(
            {{"policy",
              boost::any(string(Darabonba_Util::Client::defaultString(
                  runtime->backoffPolicy, make_shared<string>("no"))))},
             {"period", boost::any(Darabonba_Util::Client::defaultNumber(
                            runtime->backoffPeriod, make_shared<int>(1)))}}))},
       {"ignoreSSL", !runtime->ignoreSSL ? boost::any()
                                         : boost::any(*runtime->ignoreSSL)}}));
  shared_ptr<Darabonba::Request> _lastRequest;
  shared_ptr<std::exception> _lastException;
  shared_ptr<int> _now = make_shared<int>(0);
  shared_ptr<int> _retryTimes = make_shared<int>(0);
  while (Darabonba::Core::allowRetry(
      make_shared<boost::any>((*runtime_)["retry"]), _retryTimes, _now)) {
    if (*_retryTimes > 0) {
      shared_ptr<int> _backoffTime =
          make_shared<int>(Darabonba::Core::getBackoffTime(
              make_shared<boost::any>((*runtime_)["backoff"]), _retryTimes));
      if (*_backoffTime > 0) {
        Darabonba::Core::sleep(_backoffTime);
      }
    }
    _retryTimes = make_shared<int>(*_retryTimes + 1);
    try {
      shared_ptr<Darabonba::Request> request_ =
          make_shared<Darabonba::Request>();
      shared_ptr<string> accessKeyId =
          make_shared<string>(_credential->getAccessKeyId());
      shared_ptr<string> accessKeySecret =
          make_shared<string>(_credential->getAccessKeySecret());
      shared_ptr<string> token =
          make_shared<string>(_credential->getSecurityToken());
      request_->protocol = *_protocol;
      request_->method = "GET";
      request_->pathname = string("/?location");
      request_->headers = {
          {"host", Alibabacloud_OSSUtil::Client::getHost(
                       request->bucketName, _regionId, _endpoint, _hostModel)},
          {"date", Darabonba_Util::Client::getDateUTCString()},
          {"user-agent", getUserAgent()}};
      if (!Darabonba_Util::Client::empty(token)) {
        request_->headers.insert(
            pair<string, string>("x-oss-security-token", *token));
      }
      request_->headers.insert(pair<string, string>(
          "authorization",
          Alibabacloud_OSSUtil::Client::getSignature(
              request_, request->bucketName, accessKeyId, accessKeySecret,
              _signatureVersion, _addtionalHeaders)));
      _lastRequest = request_;
      shared_ptr<Darabonba::Response> response_ =
          make_shared<Darabonba::Response>(
              Darabonba::Core::doAction(request_, runtime_));
      shared_ptr<map<string, boost::any>> respMap;
      shared_ptr<string> bodyStr;
      if (Darabonba_Util::Client::is4xx(
              make_shared<int>(response_->statusCode)) ||
          Darabonba_Util::Client::is5xx(
              make_shared<int>(response_->statusCode))) {
        bodyStr = make_shared<string>(
            Darabonba_Util::Client::readAsString(response_->body));
        respMap = make_shared<map<string, boost::any>>(
            Alibabacloud_OSSUtil::Client::getErrMessage(bodyStr));
        BOOST_THROW_EXCEPTION(Darabonba::Error(map<string, boost::any>(
            {{"code", (*respMap)["Code"]},
             {"message", (*respMap)["Message"]},
             {"data", boost::any(map<string, boost::any>(
                          {{"httpCode", boost::any(response_->statusCode)},
                           {"requestId", (*respMap)["RequestId"]},
                           {"hostId", (*respMap)["HostId"]}}))}})));
      }
      bodyStr = make_shared<string>(
          Darabonba_Util::Client::readAsString(response_->body));
      respMap = make_shared<map<string, boost::any>>(
          Darabonba_XML::Client::parseXml(bodyStr, nullptr));
      return GetBucketLocationResponse(Darabonba::Converter::merge(
          map<string, boost::any>(
              {{"LocationConstraint", (*respMap)["LocationConstraint"]}}),
          Darabonba::Converter::toGenericMap(response_->headers)));
    } catch (std::exception &e) {
      if (Darabonba::Core::isRetryable(e)) {
        _lastException = make_shared<std::exception>(e);
        continue;
      }
      BOOST_THROW_EXCEPTION(e);
    }
  }
  BOOST_THROW_EXCEPTION(
      Darabonba::UnretryableError(_lastRequest, _lastException));
}

ListLiveChannelResponse Alibabacloud_OSS::Client::listLiveChannel(
    shared_ptr<ListLiveChannelRequest> request,
    shared_ptr<Alibabacloud_OSSUtil::RuntimeOptions> runtime) {
  request->validate();
  runtime->validate();
  shared_ptr<map<string, boost::any>> runtime_ = make_shared<
      map<string, boost::any>>(map<string, boost::any>(
      {{"timeouted", boost::any(string("retry"))},
       {"readTimeout", boost::any(Darabonba_Util::Client::defaultNumber(
                           runtime->readTimeout, _readTimeout))},
       {"connectTimeout", boost::any(Darabonba_Util::Client::defaultNumber(
                              runtime->connectTimeout, _connectTimeout))},
       {"localAddr", boost::any(string(Darabonba_Util::Client::defaultString(
                         runtime->localAddr, _localAddr)))},
       {"httpProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                         runtime->httpProxy, _httpProxy)))},
       {"httpsProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                          runtime->httpsProxy, _httpsProxy)))},
       {"noProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                       runtime->noProxy, _noProxy)))},
       {"socks5Proxy", boost::any(string(Darabonba_Util::Client::defaultString(
                           runtime->socks5Proxy, _socks5Proxy)))},
       {"socks5NetWork",
        boost::any(string(Darabonba_Util::Client::defaultString(
            runtime->socks5NetWork, _socks5NetWork)))},
       {"maxIdleConns", boost::any(Darabonba_Util::Client::defaultNumber(
                            runtime->maxIdleConns, _maxIdleConns))},
       {"retry", boost::any(map<string, boost::any>(
                     {{"retryable", !runtime->autoretry
                                        ? boost::any()
                                        : boost::any(*runtime->autoretry)},
                      {"maxAttempts",
                       boost::any(Darabonba_Util::Client::defaultNumber(
                           runtime->maxAttempts, make_shared<int>(3)))}}))},
       {"backoff",
        boost::any(map<string, boost::any>(
            {{"policy",
              boost::any(string(Darabonba_Util::Client::defaultString(
                  runtime->backoffPolicy, make_shared<string>("no"))))},
             {"period", boost::any(Darabonba_Util::Client::defaultNumber(
                            runtime->backoffPeriod, make_shared<int>(1)))}}))},
       {"ignoreSSL", !runtime->ignoreSSL ? boost::any()
                                         : boost::any(*runtime->ignoreSSL)}}));
  shared_ptr<Darabonba::Request> _lastRequest;
  shared_ptr<std::exception> _lastException;
  shared_ptr<int> _now = make_shared<int>(0);
  shared_ptr<int> _retryTimes = make_shared<int>(0);
  while (Darabonba::Core::allowRetry(
      make_shared<boost::any>((*runtime_)["retry"]), _retryTimes, _now)) {
    if (*_retryTimes > 0) {
      shared_ptr<int> _backoffTime =
          make_shared<int>(Darabonba::Core::getBackoffTime(
              make_shared<boost::any>((*runtime_)["backoff"]), _retryTimes));
      if (*_backoffTime > 0) {
        Darabonba::Core::sleep(_backoffTime);
      }
    }
    _retryTimes = make_shared<int>(*_retryTimes + 1);
    try {
      shared_ptr<Darabonba::Request> request_ =
          make_shared<Darabonba::Request>();
      shared_ptr<string> accessKeyId =
          make_shared<string>(_credential->getAccessKeyId());
      shared_ptr<string> accessKeySecret =
          make_shared<string>(_credential->getAccessKeySecret());
      shared_ptr<string> token =
          make_shared<string>(_credential->getSecurityToken());
      request_->protocol = *_protocol;
      request_->method = "GET";
      request_->pathname = string("/?live");
      request_->headers = {
          {"host", Alibabacloud_OSSUtil::Client::getHost(
                       request->bucketName, _regionId, _endpoint, _hostModel)},
          {"date", Darabonba_Util::Client::getDateUTCString()},
          {"user-agent", getUserAgent()}};
      if (!Darabonba_Util::Client::empty(token)) {
        request_->headers.insert(
            pair<string, string>("x-oss-security-token", *token));
      }
      request_->query = Darabonba_Util::Client::stringifyMapValue(
          make_shared<map<string, boost::any>>(request->filter->toMap()));
      request_->headers.insert(pair<string, string>(
          "authorization",
          Alibabacloud_OSSUtil::Client::getSignature(
              request_, request->bucketName, accessKeyId, accessKeySecret,
              _signatureVersion, _addtionalHeaders)));
      _lastRequest = request_;
      shared_ptr<Darabonba::Response> response_ =
          make_shared<Darabonba::Response>(
              Darabonba::Core::doAction(request_, runtime_));
      shared_ptr<map<string, boost::any>> respMap;
      shared_ptr<string> bodyStr;
      if (Darabonba_Util::Client::is4xx(
              make_shared<int>(response_->statusCode)) ||
          Darabonba_Util::Client::is5xx(
              make_shared<int>(response_->statusCode))) {
        bodyStr = make_shared<string>(
            Darabonba_Util::Client::readAsString(response_->body));
        respMap = make_shared<map<string, boost::any>>(
            Alibabacloud_OSSUtil::Client::getErrMessage(bodyStr));
        BOOST_THROW_EXCEPTION(Darabonba::Error(map<string, boost::any>(
            {{"code", (*respMap)["Code"]},
             {"message", (*respMap)["Message"]},
             {"data", boost::any(map<string, boost::any>(
                          {{"httpCode", boost::any(response_->statusCode)},
                           {"requestId", (*respMap)["RequestId"]},
                           {"hostId", (*respMap)["HostId"]}}))}})));
      }
      bodyStr = make_shared<string>(
          Darabonba_Util::Client::readAsString(response_->body));
      respMap = make_shared<map<string, boost::any>>(
          Darabonba_XML::Client::parseXml(bodyStr, nullptr));
      return ListLiveChannelResponse(Darabonba::Converter::merge(
          map<string, boost::any>(
              {{"ListLiveChannelResult", (*respMap)["ListLiveChannelResult"]}}),
          Darabonba::Converter::toGenericMap(response_->headers)));
    } catch (std::exception &e) {
      if (Darabonba::Core::isRetryable(e)) {
        _lastException = make_shared<std::exception>(e);
        continue;
      }
      BOOST_THROW_EXCEPTION(e);
    }
  }
  BOOST_THROW_EXCEPTION(
      Darabonba::UnretryableError(_lastRequest, _lastException));
}

GetObjectMetaResponse Alibabacloud_OSS::Client::getObjectMeta(
    shared_ptr<GetObjectMetaRequest> request,
    shared_ptr<Alibabacloud_OSSUtil::RuntimeOptions> runtime) {
  request->validate();
  runtime->validate();
  shared_ptr<map<string, boost::any>> runtime_ = make_shared<
      map<string, boost::any>>(map<string, boost::any>(
      {{"timeouted", boost::any(string("retry"))},
       {"readTimeout", boost::any(Darabonba_Util::Client::defaultNumber(
                           runtime->readTimeout, _readTimeout))},
       {"connectTimeout", boost::any(Darabonba_Util::Client::defaultNumber(
                              runtime->connectTimeout, _connectTimeout))},
       {"localAddr", boost::any(string(Darabonba_Util::Client::defaultString(
                         runtime->localAddr, _localAddr)))},
       {"httpProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                         runtime->httpProxy, _httpProxy)))},
       {"httpsProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                          runtime->httpsProxy, _httpsProxy)))},
       {"noProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                       runtime->noProxy, _noProxy)))},
       {"socks5Proxy", boost::any(string(Darabonba_Util::Client::defaultString(
                           runtime->socks5Proxy, _socks5Proxy)))},
       {"socks5NetWork",
        boost::any(string(Darabonba_Util::Client::defaultString(
            runtime->socks5NetWork, _socks5NetWork)))},
       {"maxIdleConns", boost::any(Darabonba_Util::Client::defaultNumber(
                            runtime->maxIdleConns, _maxIdleConns))},
       {"retry", boost::any(map<string, boost::any>(
                     {{"retryable", !runtime->autoretry
                                        ? boost::any()
                                        : boost::any(*runtime->autoretry)},
                      {"maxAttempts",
                       boost::any(Darabonba_Util::Client::defaultNumber(
                           runtime->maxAttempts, make_shared<int>(3)))}}))},
       {"backoff",
        boost::any(map<string, boost::any>(
            {{"policy",
              boost::any(string(Darabonba_Util::Client::defaultString(
                  runtime->backoffPolicy, make_shared<string>("no"))))},
             {"period", boost::any(Darabonba_Util::Client::defaultNumber(
                            runtime->backoffPeriod, make_shared<int>(1)))}}))},
       {"ignoreSSL", !runtime->ignoreSSL ? boost::any()
                                         : boost::any(*runtime->ignoreSSL)}}));
  shared_ptr<Darabonba::Request> _lastRequest;
  shared_ptr<std::exception> _lastException;
  shared_ptr<int> _now = make_shared<int>(0);
  shared_ptr<int> _retryTimes = make_shared<int>(0);
  while (Darabonba::Core::allowRetry(
      make_shared<boost::any>((*runtime_)["retry"]), _retryTimes, _now)) {
    if (*_retryTimes > 0) {
      shared_ptr<int> _backoffTime =
          make_shared<int>(Darabonba::Core::getBackoffTime(
              make_shared<boost::any>((*runtime_)["backoff"]), _retryTimes));
      if (*_backoffTime > 0) {
        Darabonba::Core::sleep(_backoffTime);
      }
    }
    _retryTimes = make_shared<int>(*_retryTimes + 1);
    try {
      shared_ptr<Darabonba::Request> request_ =
          make_shared<Darabonba::Request>();
      shared_ptr<string> accessKeyId =
          make_shared<string>(_credential->getAccessKeyId());
      shared_ptr<string> accessKeySecret =
          make_shared<string>(_credential->getAccessKeySecret());
      shared_ptr<string> token =
          make_shared<string>(_credential->getSecurityToken());
      request_->protocol = *_protocol;
      request_->method = "HEAD";
      request_->pathname = string("/" + *request->objectName + "?objectMeta");
      request_->headers = {
          {"host", Alibabacloud_OSSUtil::Client::getHost(
                       request->bucketName, _regionId, _endpoint, _hostModel)},
          {"date", Darabonba_Util::Client::getDateUTCString()},
          {"user-agent", getUserAgent()}};
      if (!Darabonba_Util::Client::empty(token)) {
        request_->headers.insert(
            pair<string, string>("x-oss-security-token", *token));
      }
      request_->headers.insert(pair<string, string>(
          "authorization",
          Alibabacloud_OSSUtil::Client::getSignature(
              request_, request->bucketName, accessKeyId, accessKeySecret,
              _signatureVersion, _addtionalHeaders)));
      _lastRequest = request_;
      shared_ptr<Darabonba::Response> response_ =
          make_shared<Darabonba::Response>(
              Darabonba::Core::doAction(request_, runtime_));
      shared_ptr<map<string, boost::any>> respMap;
      shared_ptr<string> bodyStr;
      if (Darabonba_Util::Client::is4xx(
              make_shared<int>(response_->statusCode)) ||
          Darabonba_Util::Client::is5xx(
              make_shared<int>(response_->statusCode))) {
        bodyStr = make_shared<string>(
            Darabonba_Util::Client::readAsString(response_->body));
        respMap = make_shared<map<string, boost::any>>(
            Alibabacloud_OSSUtil::Client::getErrMessage(bodyStr));
        BOOST_THROW_EXCEPTION(Darabonba::Error(map<string, boost::any>(
            {{"code", (*respMap)["Code"]},
             {"message", (*respMap)["Message"]},
             {"data", boost::any(map<string, boost::any>(
                          {{"httpCode", boost::any(response_->statusCode)},
                           {"requestId", (*respMap)["RequestId"]},
                           {"hostId", (*respMap)["HostId"]}}))}})));
      }
      return GetObjectMetaResponse(
          Darabonba::Converter::toGenericMap(Darabonba::Converter::merge(
              map<string, string>(), response_->headers)));
    } catch (std::exception &e) {
      if (Darabonba::Core::isRetryable(e)) {
        _lastException = make_shared<std::exception>(e);
        continue;
      }
      BOOST_THROW_EXCEPTION(e);
    }
  }
  BOOST_THROW_EXCEPTION(
      Darabonba::UnretryableError(_lastRequest, _lastException));
}

GetBucketAclResponse Alibabacloud_OSS::Client::getBucketAcl(
    shared_ptr<GetBucketAclRequest> request,
    shared_ptr<Alibabacloud_OSSUtil::RuntimeOptions> runtime) {
  request->validate();
  runtime->validate();
  shared_ptr<map<string, boost::any>> runtime_ = make_shared<
      map<string, boost::any>>(map<string, boost::any>(
      {{"timeouted", boost::any(string("retry"))},
       {"readTimeout", boost::any(Darabonba_Util::Client::defaultNumber(
                           runtime->readTimeout, _readTimeout))},
       {"connectTimeout", boost::any(Darabonba_Util::Client::defaultNumber(
                              runtime->connectTimeout, _connectTimeout))},
       {"localAddr", boost::any(string(Darabonba_Util::Client::defaultString(
                         runtime->localAddr, _localAddr)))},
       {"httpProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                         runtime->httpProxy, _httpProxy)))},
       {"httpsProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                          runtime->httpsProxy, _httpsProxy)))},
       {"noProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                       runtime->noProxy, _noProxy)))},
       {"socks5Proxy", boost::any(string(Darabonba_Util::Client::defaultString(
                           runtime->socks5Proxy, _socks5Proxy)))},
       {"socks5NetWork",
        boost::any(string(Darabonba_Util::Client::defaultString(
            runtime->socks5NetWork, _socks5NetWork)))},
       {"maxIdleConns", boost::any(Darabonba_Util::Client::defaultNumber(
                            runtime->maxIdleConns, _maxIdleConns))},
       {"retry", boost::any(map<string, boost::any>(
                     {{"retryable", !runtime->autoretry
                                        ? boost::any()
                                        : boost::any(*runtime->autoretry)},
                      {"maxAttempts",
                       boost::any(Darabonba_Util::Client::defaultNumber(
                           runtime->maxAttempts, make_shared<int>(3)))}}))},
       {"backoff",
        boost::any(map<string, boost::any>(
            {{"policy",
              boost::any(string(Darabonba_Util::Client::defaultString(
                  runtime->backoffPolicy, make_shared<string>("no"))))},
             {"period", boost::any(Darabonba_Util::Client::defaultNumber(
                            runtime->backoffPeriod, make_shared<int>(1)))}}))},
       {"ignoreSSL", !runtime->ignoreSSL ? boost::any()
                                         : boost::any(*runtime->ignoreSSL)}}));
  shared_ptr<Darabonba::Request> _lastRequest;
  shared_ptr<std::exception> _lastException;
  shared_ptr<int> _now = make_shared<int>(0);
  shared_ptr<int> _retryTimes = make_shared<int>(0);
  while (Darabonba::Core::allowRetry(
      make_shared<boost::any>((*runtime_)["retry"]), _retryTimes, _now)) {
    if (*_retryTimes > 0) {
      shared_ptr<int> _backoffTime =
          make_shared<int>(Darabonba::Core::getBackoffTime(
              make_shared<boost::any>((*runtime_)["backoff"]), _retryTimes));
      if (*_backoffTime > 0) {
        Darabonba::Core::sleep(_backoffTime);
      }
    }
    _retryTimes = make_shared<int>(*_retryTimes + 1);
    try {
      shared_ptr<Darabonba::Request> request_ =
          make_shared<Darabonba::Request>();
      shared_ptr<string> accessKeyId =
          make_shared<string>(_credential->getAccessKeyId());
      shared_ptr<string> accessKeySecret =
          make_shared<string>(_credential->getAccessKeySecret());
      shared_ptr<string> token =
          make_shared<string>(_credential->getSecurityToken());
      request_->protocol = *_protocol;
      request_->method = "GET";
      request_->pathname = string("/?acl");
      request_->headers = {
          {"host", Alibabacloud_OSSUtil::Client::getHost(
                       request->bucketName, _regionId, _endpoint, _hostModel)},
          {"date", Darabonba_Util::Client::getDateUTCString()},
          {"user-agent", getUserAgent()}};
      if (!Darabonba_Util::Client::empty(token)) {
        request_->headers.insert(
            pair<string, string>("x-oss-security-token", *token));
      }
      request_->headers.insert(pair<string, string>(
          "authorization",
          Alibabacloud_OSSUtil::Client::getSignature(
              request_, request->bucketName, accessKeyId, accessKeySecret,
              _signatureVersion, _addtionalHeaders)));
      _lastRequest = request_;
      shared_ptr<Darabonba::Response> response_ =
          make_shared<Darabonba::Response>(
              Darabonba::Core::doAction(request_, runtime_));
      shared_ptr<map<string, boost::any>> respMap;
      shared_ptr<string> bodyStr;
      if (Darabonba_Util::Client::is4xx(
              make_shared<int>(response_->statusCode)) ||
          Darabonba_Util::Client::is5xx(
              make_shared<int>(response_->statusCode))) {
        bodyStr = make_shared<string>(
            Darabonba_Util::Client::readAsString(response_->body));
        respMap = make_shared<map<string, boost::any>>(
            Alibabacloud_OSSUtil::Client::getErrMessage(bodyStr));
        BOOST_THROW_EXCEPTION(Darabonba::Error(map<string, boost::any>(
            {{"code", (*respMap)["Code"]},
             {"message", (*respMap)["Message"]},
             {"data", boost::any(map<string, boost::any>(
                          {{"httpCode", boost::any(response_->statusCode)},
                           {"requestId", (*respMap)["RequestId"]},
                           {"hostId", (*respMap)["HostId"]}}))}})));
      }
      bodyStr = make_shared<string>(
          Darabonba_Util::Client::readAsString(response_->body));
      respMap = make_shared<map<string, boost::any>>(
          Darabonba_XML::Client::parseXml(bodyStr, nullptr));
      return GetBucketAclResponse(Darabonba::Converter::merge(
          map<string, boost::any>(
              {{"AccessControlPolicy", (*respMap)["AccessControlPolicy"]}}),
          Darabonba::Converter::toGenericMap(response_->headers)));
    } catch (std::exception &e) {
      if (Darabonba::Core::isRetryable(e)) {
        _lastException = make_shared<std::exception>(e);
        continue;
      }
      BOOST_THROW_EXCEPTION(e);
    }
  }
  BOOST_THROW_EXCEPTION(
      Darabonba::UnretryableError(_lastRequest, _lastException));
}

ListPartsResponse Alibabacloud_OSS::Client::listParts(
    shared_ptr<ListPartsRequest> request,
    shared_ptr<Alibabacloud_OSSUtil::RuntimeOptions> runtime) {
  request->validate();
  runtime->validate();
  shared_ptr<map<string, boost::any>> runtime_ = make_shared<
      map<string, boost::any>>(map<string, boost::any>(
      {{"timeouted", boost::any(string("retry"))},
       {"readTimeout", boost::any(Darabonba_Util::Client::defaultNumber(
                           runtime->readTimeout, _readTimeout))},
       {"connectTimeout", boost::any(Darabonba_Util::Client::defaultNumber(
                              runtime->connectTimeout, _connectTimeout))},
       {"localAddr", boost::any(string(Darabonba_Util::Client::defaultString(
                         runtime->localAddr, _localAddr)))},
       {"httpProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                         runtime->httpProxy, _httpProxy)))},
       {"httpsProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                          runtime->httpsProxy, _httpsProxy)))},
       {"noProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                       runtime->noProxy, _noProxy)))},
       {"socks5Proxy", boost::any(string(Darabonba_Util::Client::defaultString(
                           runtime->socks5Proxy, _socks5Proxy)))},
       {"socks5NetWork",
        boost::any(string(Darabonba_Util::Client::defaultString(
            runtime->socks5NetWork, _socks5NetWork)))},
       {"maxIdleConns", boost::any(Darabonba_Util::Client::defaultNumber(
                            runtime->maxIdleConns, _maxIdleConns))},
       {"retry", boost::any(map<string, boost::any>(
                     {{"retryable", !runtime->autoretry
                                        ? boost::any()
                                        : boost::any(*runtime->autoretry)},
                      {"maxAttempts",
                       boost::any(Darabonba_Util::Client::defaultNumber(
                           runtime->maxAttempts, make_shared<int>(3)))}}))},
       {"backoff",
        boost::any(map<string, boost::any>(
            {{"policy",
              boost::any(string(Darabonba_Util::Client::defaultString(
                  runtime->backoffPolicy, make_shared<string>("no"))))},
             {"period", boost::any(Darabonba_Util::Client::defaultNumber(
                            runtime->backoffPeriod, make_shared<int>(1)))}}))},
       {"ignoreSSL", !runtime->ignoreSSL ? boost::any()
                                         : boost::any(*runtime->ignoreSSL)}}));
  shared_ptr<Darabonba::Request> _lastRequest;
  shared_ptr<std::exception> _lastException;
  shared_ptr<int> _now = make_shared<int>(0);
  shared_ptr<int> _retryTimes = make_shared<int>(0);
  while (Darabonba::Core::allowRetry(
      make_shared<boost::any>((*runtime_)["retry"]), _retryTimes, _now)) {
    if (*_retryTimes > 0) {
      shared_ptr<int> _backoffTime =
          make_shared<int>(Darabonba::Core::getBackoffTime(
              make_shared<boost::any>((*runtime_)["backoff"]), _retryTimes));
      if (*_backoffTime > 0) {
        Darabonba::Core::sleep(_backoffTime);
      }
    }
    _retryTimes = make_shared<int>(*_retryTimes + 1);
    try {
      shared_ptr<Darabonba::Request> request_ =
          make_shared<Darabonba::Request>();
      shared_ptr<string> accessKeyId =
          make_shared<string>(_credential->getAccessKeyId());
      shared_ptr<string> accessKeySecret =
          make_shared<string>(_credential->getAccessKeySecret());
      shared_ptr<string> token =
          make_shared<string>(_credential->getSecurityToken());
      request_->protocol = *_protocol;
      request_->method = "GET";
      request_->pathname = string("/" + *request->objectName + "");
      request_->headers = {
          {"host", Alibabacloud_OSSUtil::Client::getHost(
                       request->bucketName, _regionId, _endpoint, _hostModel)},
          {"date", Darabonba_Util::Client::getDateUTCString()},
          {"user-agent", getUserAgent()}};
      if (!Darabonba_Util::Client::empty(token)) {
        request_->headers.insert(
            pair<string, string>("x-oss-security-token", *token));
      }
      request_->query = Darabonba_Util::Client::stringifyMapValue(
          make_shared<map<string, boost::any>>(request->filter->toMap()));
      request_->headers.insert(pair<string, string>(
          "authorization",
          Alibabacloud_OSSUtil::Client::getSignature(
              request_, request->bucketName, accessKeyId, accessKeySecret,
              _signatureVersion, _addtionalHeaders)));
      _lastRequest = request_;
      shared_ptr<Darabonba::Response> response_ =
          make_shared<Darabonba::Response>(
              Darabonba::Core::doAction(request_, runtime_));
      shared_ptr<map<string, boost::any>> respMap;
      shared_ptr<string> bodyStr;
      if (Darabonba_Util::Client::is4xx(
              make_shared<int>(response_->statusCode)) ||
          Darabonba_Util::Client::is5xx(
              make_shared<int>(response_->statusCode))) {
        bodyStr = make_shared<string>(
            Darabonba_Util::Client::readAsString(response_->body));
        respMap = make_shared<map<string, boost::any>>(
            Alibabacloud_OSSUtil::Client::getErrMessage(bodyStr));
        BOOST_THROW_EXCEPTION(Darabonba::Error(map<string, boost::any>(
            {{"code", (*respMap)["Code"]},
             {"message", (*respMap)["Message"]},
             {"data", boost::any(map<string, boost::any>(
                          {{"httpCode", boost::any(response_->statusCode)},
                           {"requestId", (*respMap)["RequestId"]},
                           {"hostId", (*respMap)["HostId"]}}))}})));
      }
      bodyStr = make_shared<string>(
          Darabonba_Util::Client::readAsString(response_->body));
      respMap = make_shared<map<string, boost::any>>(
          Darabonba_XML::Client::parseXml(bodyStr, nullptr));
      return ListPartsResponse(Darabonba::Converter::merge(
          map<string, boost::any>(
              {{"ListPartsResult", (*respMap)["ListPartsResult"]}}),
          Darabonba::Converter::toGenericMap(response_->headers)));
    } catch (std::exception &e) {
      if (Darabonba::Core::isRetryable(e)) {
        _lastException = make_shared<std::exception>(e);
        continue;
      }
      BOOST_THROW_EXCEPTION(e);
    }
  }
  BOOST_THROW_EXCEPTION(
      Darabonba::UnretryableError(_lastRequest, _lastException));
}

GetLiveChannelHistoryResponse Alibabacloud_OSS::Client::getLiveChannelHistory(
    shared_ptr<GetLiveChannelHistoryRequest> request,
    shared_ptr<Alibabacloud_OSSUtil::RuntimeOptions> runtime) {
  request->validate();
  runtime->validate();
  shared_ptr<map<string, boost::any>> runtime_ = make_shared<
      map<string, boost::any>>(map<string, boost::any>(
      {{"timeouted", boost::any(string("retry"))},
       {"readTimeout", boost::any(Darabonba_Util::Client::defaultNumber(
                           runtime->readTimeout, _readTimeout))},
       {"connectTimeout", boost::any(Darabonba_Util::Client::defaultNumber(
                              runtime->connectTimeout, _connectTimeout))},
       {"localAddr", boost::any(string(Darabonba_Util::Client::defaultString(
                         runtime->localAddr, _localAddr)))},
       {"httpProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                         runtime->httpProxy, _httpProxy)))},
       {"httpsProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                          runtime->httpsProxy, _httpsProxy)))},
       {"noProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                       runtime->noProxy, _noProxy)))},
       {"socks5Proxy", boost::any(string(Darabonba_Util::Client::defaultString(
                           runtime->socks5Proxy, _socks5Proxy)))},
       {"socks5NetWork",
        boost::any(string(Darabonba_Util::Client::defaultString(
            runtime->socks5NetWork, _socks5NetWork)))},
       {"maxIdleConns", boost::any(Darabonba_Util::Client::defaultNumber(
                            runtime->maxIdleConns, _maxIdleConns))},
       {"retry", boost::any(map<string, boost::any>(
                     {{"retryable", !runtime->autoretry
                                        ? boost::any()
                                        : boost::any(*runtime->autoretry)},
                      {"maxAttempts",
                       boost::any(Darabonba_Util::Client::defaultNumber(
                           runtime->maxAttempts, make_shared<int>(3)))}}))},
       {"backoff",
        boost::any(map<string, boost::any>(
            {{"policy",
              boost::any(string(Darabonba_Util::Client::defaultString(
                  runtime->backoffPolicy, make_shared<string>("no"))))},
             {"period", boost::any(Darabonba_Util::Client::defaultNumber(
                            runtime->backoffPeriod, make_shared<int>(1)))}}))},
       {"ignoreSSL", !runtime->ignoreSSL ? boost::any()
                                         : boost::any(*runtime->ignoreSSL)}}));
  shared_ptr<Darabonba::Request> _lastRequest;
  shared_ptr<std::exception> _lastException;
  shared_ptr<int> _now = make_shared<int>(0);
  shared_ptr<int> _retryTimes = make_shared<int>(0);
  while (Darabonba::Core::allowRetry(
      make_shared<boost::any>((*runtime_)["retry"]), _retryTimes, _now)) {
    if (*_retryTimes > 0) {
      shared_ptr<int> _backoffTime =
          make_shared<int>(Darabonba::Core::getBackoffTime(
              make_shared<boost::any>((*runtime_)["backoff"]), _retryTimes));
      if (*_backoffTime > 0) {
        Darabonba::Core::sleep(_backoffTime);
      }
    }
    _retryTimes = make_shared<int>(*_retryTimes + 1);
    try {
      shared_ptr<Darabonba::Request> request_ =
          make_shared<Darabonba::Request>();
      shared_ptr<string> accessKeyId =
          make_shared<string>(_credential->getAccessKeyId());
      shared_ptr<string> accessKeySecret =
          make_shared<string>(_credential->getAccessKeySecret());
      shared_ptr<string> token =
          make_shared<string>(_credential->getSecurityToken());
      request_->protocol = *_protocol;
      request_->method = "GET";
      request_->pathname = string("/" + *request->channelName + "?live");
      request_->headers = {
          {"host", Alibabacloud_OSSUtil::Client::getHost(
                       request->bucketName, _regionId, _endpoint, _hostModel)},
          {"date", Darabonba_Util::Client::getDateUTCString()},
          {"user-agent", getUserAgent()}};
      if (!Darabonba_Util::Client::empty(token)) {
        request_->headers.insert(
            pair<string, string>("x-oss-security-token", *token));
      }
      request_->query = Darabonba_Util::Client::stringifyMapValue(
          make_shared<map<string, boost::any>>(request->filter->toMap()));
      request_->headers.insert(pair<string, string>(
          "authorization",
          Alibabacloud_OSSUtil::Client::getSignature(
              request_, request->bucketName, accessKeyId, accessKeySecret,
              _signatureVersion, _addtionalHeaders)));
      _lastRequest = request_;
      shared_ptr<Darabonba::Response> response_ =
          make_shared<Darabonba::Response>(
              Darabonba::Core::doAction(request_, runtime_));
      shared_ptr<map<string, boost::any>> respMap;
      shared_ptr<string> bodyStr;
      if (Darabonba_Util::Client::is4xx(
              make_shared<int>(response_->statusCode)) ||
          Darabonba_Util::Client::is5xx(
              make_shared<int>(response_->statusCode))) {
        bodyStr = make_shared<string>(
            Darabonba_Util::Client::readAsString(response_->body));
        respMap = make_shared<map<string, boost::any>>(
            Alibabacloud_OSSUtil::Client::getErrMessage(bodyStr));
        BOOST_THROW_EXCEPTION(Darabonba::Error(map<string, boost::any>(
            {{"code", (*respMap)["Code"]},
             {"message", (*respMap)["Message"]},
             {"data", boost::any(map<string, boost::any>(
                          {{"httpCode", boost::any(response_->statusCode)},
                           {"requestId", (*respMap)["RequestId"]},
                           {"hostId", (*respMap)["HostId"]}}))}})));
      }
      bodyStr = make_shared<string>(
          Darabonba_Util::Client::readAsString(response_->body));
      respMap = make_shared<map<string, boost::any>>(
          Darabonba_XML::Client::parseXml(bodyStr, nullptr));
      return GetLiveChannelHistoryResponse(Darabonba::Converter::merge(
          map<string, boost::any>(
              {{"LiveChannelHistory", (*respMap)["LiveChannelHistory"]}}),
          Darabonba::Converter::toGenericMap(response_->headers)));
    } catch (std::exception &e) {
      if (Darabonba::Core::isRetryable(e)) {
        _lastException = make_shared<std::exception>(e);
        continue;
      }
      BOOST_THROW_EXCEPTION(e);
    }
  }
  BOOST_THROW_EXCEPTION(
      Darabonba::UnretryableError(_lastRequest, _lastException));
}

GetBucketResponse Alibabacloud_OSS::Client::getBucket(
    shared_ptr<GetBucketRequest> request,
    shared_ptr<Alibabacloud_OSSUtil::RuntimeOptions> runtime) {
  request->validate();
  runtime->validate();
  shared_ptr<map<string, boost::any>> runtime_ = make_shared<
      map<string, boost::any>>(map<string, boost::any>(
      {{"timeouted", boost::any(string("retry"))},
       {"readTimeout", boost::any(Darabonba_Util::Client::defaultNumber(
                           runtime->readTimeout, _readTimeout))},
       {"connectTimeout", boost::any(Darabonba_Util::Client::defaultNumber(
                              runtime->connectTimeout, _connectTimeout))},
       {"localAddr", boost::any(string(Darabonba_Util::Client::defaultString(
                         runtime->localAddr, _localAddr)))},
       {"httpProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                         runtime->httpProxy, _httpProxy)))},
       {"httpsProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                          runtime->httpsProxy, _httpsProxy)))},
       {"noProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                       runtime->noProxy, _noProxy)))},
       {"socks5Proxy", boost::any(string(Darabonba_Util::Client::defaultString(
                           runtime->socks5Proxy, _socks5Proxy)))},
       {"socks5NetWork",
        boost::any(string(Darabonba_Util::Client::defaultString(
            runtime->socks5NetWork, _socks5NetWork)))},
       {"maxIdleConns", boost::any(Darabonba_Util::Client::defaultNumber(
                            runtime->maxIdleConns, _maxIdleConns))},
       {"retry", boost::any(map<string, boost::any>(
                     {{"retryable", !runtime->autoretry
                                        ? boost::any()
                                        : boost::any(*runtime->autoretry)},
                      {"maxAttempts",
                       boost::any(Darabonba_Util::Client::defaultNumber(
                           runtime->maxAttempts, make_shared<int>(3)))}}))},
       {"backoff",
        boost::any(map<string, boost::any>(
            {{"policy",
              boost::any(string(Darabonba_Util::Client::defaultString(
                  runtime->backoffPolicy, make_shared<string>("no"))))},
             {"period", boost::any(Darabonba_Util::Client::defaultNumber(
                            runtime->backoffPeriod, make_shared<int>(1)))}}))},
       {"ignoreSSL", !runtime->ignoreSSL ? boost::any()
                                         : boost::any(*runtime->ignoreSSL)}}));
  shared_ptr<Darabonba::Request> _lastRequest;
  shared_ptr<std::exception> _lastException;
  shared_ptr<int> _now = make_shared<int>(0);
  shared_ptr<int> _retryTimes = make_shared<int>(0);
  while (Darabonba::Core::allowRetry(
      make_shared<boost::any>((*runtime_)["retry"]), _retryTimes, _now)) {
    if (*_retryTimes > 0) {
      shared_ptr<int> _backoffTime =
          make_shared<int>(Darabonba::Core::getBackoffTime(
              make_shared<boost::any>((*runtime_)["backoff"]), _retryTimes));
      if (*_backoffTime > 0) {
        Darabonba::Core::sleep(_backoffTime);
      }
    }
    _retryTimes = make_shared<int>(*_retryTimes + 1);
    try {
      shared_ptr<Darabonba::Request> request_ =
          make_shared<Darabonba::Request>();
      shared_ptr<string> accessKeyId =
          make_shared<string>(_credential->getAccessKeyId());
      shared_ptr<string> accessKeySecret =
          make_shared<string>(_credential->getAccessKeySecret());
      shared_ptr<string> token =
          make_shared<string>(_credential->getSecurityToken());
      request_->protocol = *_protocol;
      request_->method = "GET";
      request_->pathname = string("/");
      request_->headers = {
          {"host", Alibabacloud_OSSUtil::Client::getHost(
                       request->bucketName, _regionId, _endpoint, _hostModel)},
          {"date", Darabonba_Util::Client::getDateUTCString()},
          {"user-agent", getUserAgent()}};
      if (!Darabonba_Util::Client::empty(token)) {
        request_->headers.insert(
            pair<string, string>("x-oss-security-token", *token));
      }
      request_->query = Darabonba_Util::Client::stringifyMapValue(
          make_shared<map<string, boost::any>>(request->filter->toMap()));
      request_->headers.insert(pair<string, string>(
          "authorization",
          Alibabacloud_OSSUtil::Client::getSignature(
              request_, request->bucketName, accessKeyId, accessKeySecret,
              _signatureVersion, _addtionalHeaders)));
      _lastRequest = request_;
      shared_ptr<Darabonba::Response> response_ =
          make_shared<Darabonba::Response>(
              Darabonba::Core::doAction(request_, runtime_));
      shared_ptr<map<string, boost::any>> respMap;
      shared_ptr<string> bodyStr;
      if (Darabonba_Util::Client::is4xx(
              make_shared<int>(response_->statusCode)) ||
          Darabonba_Util::Client::is5xx(
              make_shared<int>(response_->statusCode))) {
        bodyStr = make_shared<string>(
            Darabonba_Util::Client::readAsString(response_->body));
        respMap = make_shared<map<string, boost::any>>(
            Alibabacloud_OSSUtil::Client::getErrMessage(bodyStr));
        BOOST_THROW_EXCEPTION(Darabonba::Error(map<string, boost::any>(
            {{"code", (*respMap)["Code"]},
             {"message", (*respMap)["Message"]},
             {"data", boost::any(map<string, boost::any>(
                          {{"httpCode", boost::any(response_->statusCode)},
                           {"requestId", (*respMap)["RequestId"]},
                           {"hostId", (*respMap)["HostId"]}}))}})));
      }
      bodyStr = make_shared<string>(
          Darabonba_Util::Client::readAsString(response_->body));
      respMap = make_shared<map<string, boost::any>>(
          Darabonba_XML::Client::parseXml(bodyStr, nullptr));
      return GetBucketResponse(Darabonba::Converter::merge(
          map<string, boost::any>(
              {{"ListBucketResult", (*respMap)["ListBucketResult"]}}),
          Darabonba::Converter::toGenericMap(response_->headers)));
    } catch (std::exception &e) {
      if (Darabonba::Core::isRetryable(e)) {
        _lastException = make_shared<std::exception>(e);
        continue;
      }
      BOOST_THROW_EXCEPTION(e);
    }
  }
  BOOST_THROW_EXCEPTION(
      Darabonba::UnretryableError(_lastRequest, _lastException));
}

GetLiveChannelInfoResponse Alibabacloud_OSS::Client::getLiveChannelInfo(
    shared_ptr<GetLiveChannelInfoRequest> request,
    shared_ptr<Alibabacloud_OSSUtil::RuntimeOptions> runtime) {
  request->validate();
  runtime->validate();
  shared_ptr<map<string, boost::any>> runtime_ = make_shared<
      map<string, boost::any>>(map<string, boost::any>(
      {{"timeouted", boost::any(string("retry"))},
       {"readTimeout", boost::any(Darabonba_Util::Client::defaultNumber(
                           runtime->readTimeout, _readTimeout))},
       {"connectTimeout", boost::any(Darabonba_Util::Client::defaultNumber(
                              runtime->connectTimeout, _connectTimeout))},
       {"localAddr", boost::any(string(Darabonba_Util::Client::defaultString(
                         runtime->localAddr, _localAddr)))},
       {"httpProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                         runtime->httpProxy, _httpProxy)))},
       {"httpsProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                          runtime->httpsProxy, _httpsProxy)))},
       {"noProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                       runtime->noProxy, _noProxy)))},
       {"socks5Proxy", boost::any(string(Darabonba_Util::Client::defaultString(
                           runtime->socks5Proxy, _socks5Proxy)))},
       {"socks5NetWork",
        boost::any(string(Darabonba_Util::Client::defaultString(
            runtime->socks5NetWork, _socks5NetWork)))},
       {"maxIdleConns", boost::any(Darabonba_Util::Client::defaultNumber(
                            runtime->maxIdleConns, _maxIdleConns))},
       {"retry", boost::any(map<string, boost::any>(
                     {{"retryable", !runtime->autoretry
                                        ? boost::any()
                                        : boost::any(*runtime->autoretry)},
                      {"maxAttempts",
                       boost::any(Darabonba_Util::Client::defaultNumber(
                           runtime->maxAttempts, make_shared<int>(3)))}}))},
       {"backoff",
        boost::any(map<string, boost::any>(
            {{"policy",
              boost::any(string(Darabonba_Util::Client::defaultString(
                  runtime->backoffPolicy, make_shared<string>("no"))))},
             {"period", boost::any(Darabonba_Util::Client::defaultNumber(
                            runtime->backoffPeriod, make_shared<int>(1)))}}))},
       {"ignoreSSL", !runtime->ignoreSSL ? boost::any()
                                         : boost::any(*runtime->ignoreSSL)}}));
  shared_ptr<Darabonba::Request> _lastRequest;
  shared_ptr<std::exception> _lastException;
  shared_ptr<int> _now = make_shared<int>(0);
  shared_ptr<int> _retryTimes = make_shared<int>(0);
  while (Darabonba::Core::allowRetry(
      make_shared<boost::any>((*runtime_)["retry"]), _retryTimes, _now)) {
    if (*_retryTimes > 0) {
      shared_ptr<int> _backoffTime =
          make_shared<int>(Darabonba::Core::getBackoffTime(
              make_shared<boost::any>((*runtime_)["backoff"]), _retryTimes));
      if (*_backoffTime > 0) {
        Darabonba::Core::sleep(_backoffTime);
      }
    }
    _retryTimes = make_shared<int>(*_retryTimes + 1);
    try {
      shared_ptr<Darabonba::Request> request_ =
          make_shared<Darabonba::Request>();
      shared_ptr<string> accessKeyId =
          make_shared<string>(_credential->getAccessKeyId());
      shared_ptr<string> accessKeySecret =
          make_shared<string>(_credential->getAccessKeySecret());
      shared_ptr<string> token =
          make_shared<string>(_credential->getSecurityToken());
      request_->protocol = *_protocol;
      request_->method = "GET";
      request_->pathname = string("/" + *request->channelName + "?live");
      request_->headers = {
          {"host", Alibabacloud_OSSUtil::Client::getHost(
                       request->bucketName, _regionId, _endpoint, _hostModel)},
          {"date", Darabonba_Util::Client::getDateUTCString()},
          {"user-agent", getUserAgent()}};
      if (!Darabonba_Util::Client::empty(token)) {
        request_->headers.insert(
            pair<string, string>("x-oss-security-token", *token));
      }
      request_->headers.insert(pair<string, string>(
          "authorization",
          Alibabacloud_OSSUtil::Client::getSignature(
              request_, request->bucketName, accessKeyId, accessKeySecret,
              _signatureVersion, _addtionalHeaders)));
      _lastRequest = request_;
      shared_ptr<Darabonba::Response> response_ =
          make_shared<Darabonba::Response>(
              Darabonba::Core::doAction(request_, runtime_));
      shared_ptr<map<string, boost::any>> respMap;
      shared_ptr<string> bodyStr;
      if (Darabonba_Util::Client::is4xx(
              make_shared<int>(response_->statusCode)) ||
          Darabonba_Util::Client::is5xx(
              make_shared<int>(response_->statusCode))) {
        bodyStr = make_shared<string>(
            Darabonba_Util::Client::readAsString(response_->body));
        respMap = make_shared<map<string, boost::any>>(
            Alibabacloud_OSSUtil::Client::getErrMessage(bodyStr));
        BOOST_THROW_EXCEPTION(Darabonba::Error(map<string, boost::any>(
            {{"code", (*respMap)["Code"]},
             {"message", (*respMap)["Message"]},
             {"data", boost::any(map<string, boost::any>(
                          {{"httpCode", boost::any(response_->statusCode)},
                           {"requestId", (*respMap)["RequestId"]},
                           {"hostId", (*respMap)["HostId"]}}))}})));
      }
      bodyStr = make_shared<string>(
          Darabonba_Util::Client::readAsString(response_->body));
      respMap = make_shared<map<string, boost::any>>(
          Darabonba_XML::Client::parseXml(bodyStr, nullptr));
      return GetLiveChannelInfoResponse(Darabonba::Converter::merge(
          map<string, boost::any>({{"LiveChannelConfiguration",
                                    (*respMap)["LiveChannelConfiguration"]}}),
          Darabonba::Converter::toGenericMap(response_->headers)));
    } catch (std::exception &e) {
      if (Darabonba::Core::isRetryable(e)) {
        _lastException = make_shared<std::exception>(e);
        continue;
      }
      BOOST_THROW_EXCEPTION(e);
    }
  }
  BOOST_THROW_EXCEPTION(
      Darabonba::UnretryableError(_lastRequest, _lastException));
}

GetLiveChannelStatResponse Alibabacloud_OSS::Client::getLiveChannelStat(
    shared_ptr<GetLiveChannelStatRequest> request,
    shared_ptr<Alibabacloud_OSSUtil::RuntimeOptions> runtime) {
  request->validate();
  runtime->validate();
  shared_ptr<map<string, boost::any>> runtime_ = make_shared<
      map<string, boost::any>>(map<string, boost::any>(
      {{"timeouted", boost::any(string("retry"))},
       {"readTimeout", boost::any(Darabonba_Util::Client::defaultNumber(
                           runtime->readTimeout, _readTimeout))},
       {"connectTimeout", boost::any(Darabonba_Util::Client::defaultNumber(
                              runtime->connectTimeout, _connectTimeout))},
       {"localAddr", boost::any(string(Darabonba_Util::Client::defaultString(
                         runtime->localAddr, _localAddr)))},
       {"httpProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                         runtime->httpProxy, _httpProxy)))},
       {"httpsProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                          runtime->httpsProxy, _httpsProxy)))},
       {"noProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                       runtime->noProxy, _noProxy)))},
       {"socks5Proxy", boost::any(string(Darabonba_Util::Client::defaultString(
                           runtime->socks5Proxy, _socks5Proxy)))},
       {"socks5NetWork",
        boost::any(string(Darabonba_Util::Client::defaultString(
            runtime->socks5NetWork, _socks5NetWork)))},
       {"maxIdleConns", boost::any(Darabonba_Util::Client::defaultNumber(
                            runtime->maxIdleConns, _maxIdleConns))},
       {"retry", boost::any(map<string, boost::any>(
                     {{"retryable", !runtime->autoretry
                                        ? boost::any()
                                        : boost::any(*runtime->autoretry)},
                      {"maxAttempts",
                       boost::any(Darabonba_Util::Client::defaultNumber(
                           runtime->maxAttempts, make_shared<int>(3)))}}))},
       {"backoff",
        boost::any(map<string, boost::any>(
            {{"policy",
              boost::any(string(Darabonba_Util::Client::defaultString(
                  runtime->backoffPolicy, make_shared<string>("no"))))},
             {"period", boost::any(Darabonba_Util::Client::defaultNumber(
                            runtime->backoffPeriod, make_shared<int>(1)))}}))},
       {"ignoreSSL", !runtime->ignoreSSL ? boost::any()
                                         : boost::any(*runtime->ignoreSSL)}}));
  shared_ptr<Darabonba::Request> _lastRequest;
  shared_ptr<std::exception> _lastException;
  shared_ptr<int> _now = make_shared<int>(0);
  shared_ptr<int> _retryTimes = make_shared<int>(0);
  while (Darabonba::Core::allowRetry(
      make_shared<boost::any>((*runtime_)["retry"]), _retryTimes, _now)) {
    if (*_retryTimes > 0) {
      shared_ptr<int> _backoffTime =
          make_shared<int>(Darabonba::Core::getBackoffTime(
              make_shared<boost::any>((*runtime_)["backoff"]), _retryTimes));
      if (*_backoffTime > 0) {
        Darabonba::Core::sleep(_backoffTime);
      }
    }
    _retryTimes = make_shared<int>(*_retryTimes + 1);
    try {
      shared_ptr<Darabonba::Request> request_ =
          make_shared<Darabonba::Request>();
      shared_ptr<string> accessKeyId =
          make_shared<string>(_credential->getAccessKeyId());
      shared_ptr<string> accessKeySecret =
          make_shared<string>(_credential->getAccessKeySecret());
      shared_ptr<string> token =
          make_shared<string>(_credential->getSecurityToken());
      request_->protocol = *_protocol;
      request_->method = "GET";
      request_->pathname = string("/" + *request->channelName + "?live");
      request_->headers = {
          {"host", Alibabacloud_OSSUtil::Client::getHost(
                       request->bucketName, _regionId, _endpoint, _hostModel)},
          {"date", Darabonba_Util::Client::getDateUTCString()},
          {"user-agent", getUserAgent()}};
      if (!Darabonba_Util::Client::empty(token)) {
        request_->headers.insert(
            pair<string, string>("x-oss-security-token", *token));
      }
      request_->query = Darabonba_Util::Client::stringifyMapValue(
          make_shared<map<string, boost::any>>(request->filter->toMap()));
      request_->headers.insert(pair<string, string>(
          "authorization",
          Alibabacloud_OSSUtil::Client::getSignature(
              request_, request->bucketName, accessKeyId, accessKeySecret,
              _signatureVersion, _addtionalHeaders)));
      _lastRequest = request_;
      shared_ptr<Darabonba::Response> response_ =
          make_shared<Darabonba::Response>(
              Darabonba::Core::doAction(request_, runtime_));
      shared_ptr<map<string, boost::any>> respMap;
      shared_ptr<string> bodyStr;
      if (Darabonba_Util::Client::is4xx(
              make_shared<int>(response_->statusCode)) ||
          Darabonba_Util::Client::is5xx(
              make_shared<int>(response_->statusCode))) {
        bodyStr = make_shared<string>(
            Darabonba_Util::Client::readAsString(response_->body));
        respMap = make_shared<map<string, boost::any>>(
            Alibabacloud_OSSUtil::Client::getErrMessage(bodyStr));
        BOOST_THROW_EXCEPTION(Darabonba::Error(map<string, boost::any>(
            {{"code", (*respMap)["Code"]},
             {"message", (*respMap)["Message"]},
             {"data", boost::any(map<string, boost::any>(
                          {{"httpCode", boost::any(response_->statusCode)},
                           {"requestId", (*respMap)["RequestId"]},
                           {"hostId", (*respMap)["HostId"]}}))}})));
      }
      bodyStr = make_shared<string>(
          Darabonba_Util::Client::readAsString(response_->body));
      respMap = make_shared<map<string, boost::any>>(
          Darabonba_XML::Client::parseXml(bodyStr, nullptr));
      return GetLiveChannelStatResponse(Darabonba::Converter::merge(
          map<string, boost::any>(
              {{"LiveChannelStat", (*respMap)["LiveChannelStat"]}}),
          Darabonba::Converter::toGenericMap(response_->headers)));
    } catch (std::exception &e) {
      if (Darabonba::Core::isRetryable(e)) {
        _lastException = make_shared<std::exception>(e);
        continue;
      }
      BOOST_THROW_EXCEPTION(e);
    }
  }
  BOOST_THROW_EXCEPTION(
      Darabonba::UnretryableError(_lastRequest, _lastException));
}

DeleteObjectResponse Alibabacloud_OSS::Client::deleteObject(
    shared_ptr<DeleteObjectRequest> request,
    shared_ptr<Alibabacloud_OSSUtil::RuntimeOptions> runtime) {
  request->validate();
  runtime->validate();
  shared_ptr<map<string, boost::any>> runtime_ = make_shared<
      map<string, boost::any>>(map<string, boost::any>(
      {{"timeouted", boost::any(string("retry"))},
       {"readTimeout", boost::any(Darabonba_Util::Client::defaultNumber(
                           runtime->readTimeout, _readTimeout))},
       {"connectTimeout", boost::any(Darabonba_Util::Client::defaultNumber(
                              runtime->connectTimeout, _connectTimeout))},
       {"localAddr", boost::any(string(Darabonba_Util::Client::defaultString(
                         runtime->localAddr, _localAddr)))},
       {"httpProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                         runtime->httpProxy, _httpProxy)))},
       {"httpsProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                          runtime->httpsProxy, _httpsProxy)))},
       {"noProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                       runtime->noProxy, _noProxy)))},
       {"socks5Proxy", boost::any(string(Darabonba_Util::Client::defaultString(
                           runtime->socks5Proxy, _socks5Proxy)))},
       {"socks5NetWork",
        boost::any(string(Darabonba_Util::Client::defaultString(
            runtime->socks5NetWork, _socks5NetWork)))},
       {"maxIdleConns", boost::any(Darabonba_Util::Client::defaultNumber(
                            runtime->maxIdleConns, _maxIdleConns))},
       {"retry", boost::any(map<string, boost::any>(
                     {{"retryable", !runtime->autoretry
                                        ? boost::any()
                                        : boost::any(*runtime->autoretry)},
                      {"maxAttempts",
                       boost::any(Darabonba_Util::Client::defaultNumber(
                           runtime->maxAttempts, make_shared<int>(3)))}}))},
       {"backoff",
        boost::any(map<string, boost::any>(
            {{"policy",
              boost::any(string(Darabonba_Util::Client::defaultString(
                  runtime->backoffPolicy, make_shared<string>("no"))))},
             {"period", boost::any(Darabonba_Util::Client::defaultNumber(
                            runtime->backoffPeriod, make_shared<int>(1)))}}))},
       {"ignoreSSL", !runtime->ignoreSSL ? boost::any()
                                         : boost::any(*runtime->ignoreSSL)}}));
  shared_ptr<Darabonba::Request> _lastRequest;
  shared_ptr<std::exception> _lastException;
  shared_ptr<int> _now = make_shared<int>(0);
  shared_ptr<int> _retryTimes = make_shared<int>(0);
  while (Darabonba::Core::allowRetry(
      make_shared<boost::any>((*runtime_)["retry"]), _retryTimes, _now)) {
    if (*_retryTimes > 0) {
      shared_ptr<int> _backoffTime =
          make_shared<int>(Darabonba::Core::getBackoffTime(
              make_shared<boost::any>((*runtime_)["backoff"]), _retryTimes));
      if (*_backoffTime > 0) {
        Darabonba::Core::sleep(_backoffTime);
      }
    }
    _retryTimes = make_shared<int>(*_retryTimes + 1);
    try {
      shared_ptr<Darabonba::Request> request_ =
          make_shared<Darabonba::Request>();
      shared_ptr<string> accessKeyId =
          make_shared<string>(_credential->getAccessKeyId());
      shared_ptr<string> accessKeySecret =
          make_shared<string>(_credential->getAccessKeySecret());
      shared_ptr<string> token =
          make_shared<string>(_credential->getSecurityToken());
      request_->protocol = *_protocol;
      request_->method = "DELETE";
      request_->pathname = string("/" + *request->objectName + "");
      request_->headers = {
          {"host", Alibabacloud_OSSUtil::Client::getHost(
                       request->bucketName, _regionId, _endpoint, _hostModel)},
          {"date", Darabonba_Util::Client::getDateUTCString()},
          {"user-agent", getUserAgent()}};
      if (!Darabonba_Util::Client::empty(token)) {
        request_->headers.insert(
            pair<string, string>("x-oss-security-token", *token));
      }
      request_->headers.insert(pair<string, string>(
          "authorization",
          Alibabacloud_OSSUtil::Client::getSignature(
              request_, request->bucketName, accessKeyId, accessKeySecret,
              _signatureVersion, _addtionalHeaders)));
      _lastRequest = request_;
      shared_ptr<Darabonba::Response> response_ =
          make_shared<Darabonba::Response>(
              Darabonba::Core::doAction(request_, runtime_));
      shared_ptr<map<string, boost::any>> respMap;
      shared_ptr<string> bodyStr;
      if (Darabonba_Util::Client::is4xx(
              make_shared<int>(response_->statusCode)) ||
          Darabonba_Util::Client::is5xx(
              make_shared<int>(response_->statusCode))) {
        bodyStr = make_shared<string>(
            Darabonba_Util::Client::readAsString(response_->body));
        respMap = make_shared<map<string, boost::any>>(
            Alibabacloud_OSSUtil::Client::getErrMessage(bodyStr));
        BOOST_THROW_EXCEPTION(Darabonba::Error(map<string, boost::any>(
            {{"code", (*respMap)["Code"]},
             {"message", (*respMap)["Message"]},
             {"data", boost::any(map<string, boost::any>(
                          {{"httpCode", boost::any(response_->statusCode)},
                           {"requestId", (*respMap)["RequestId"]},
                           {"hostId", (*respMap)["HostId"]}}))}})));
      }
      return DeleteObjectResponse(
          Darabonba::Converter::toGenericMap(Darabonba::Converter::merge(
              map<string, string>(), response_->headers)));
    } catch (std::exception &e) {
      if (Darabonba::Core::isRetryable(e)) {
        _lastException = make_shared<std::exception>(e);
        continue;
      }
      BOOST_THROW_EXCEPTION(e);
    }
  }
  BOOST_THROW_EXCEPTION(
      Darabonba::UnretryableError(_lastRequest, _lastException));
}

AbortMultipartUploadResponse Alibabacloud_OSS::Client::abortMultipartUpload(
    shared_ptr<AbortMultipartUploadRequest> request,
    shared_ptr<Alibabacloud_OSSUtil::RuntimeOptions> runtime) {
  request->validate();
  runtime->validate();
  shared_ptr<map<string, boost::any>> runtime_ = make_shared<
      map<string, boost::any>>(map<string, boost::any>(
      {{"timeouted", boost::any(string("retry"))},
       {"readTimeout", boost::any(Darabonba_Util::Client::defaultNumber(
                           runtime->readTimeout, _readTimeout))},
       {"connectTimeout", boost::any(Darabonba_Util::Client::defaultNumber(
                              runtime->connectTimeout, _connectTimeout))},
       {"localAddr", boost::any(string(Darabonba_Util::Client::defaultString(
                         runtime->localAddr, _localAddr)))},
       {"httpProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                         runtime->httpProxy, _httpProxy)))},
       {"httpsProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                          runtime->httpsProxy, _httpsProxy)))},
       {"noProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                       runtime->noProxy, _noProxy)))},
       {"socks5Proxy", boost::any(string(Darabonba_Util::Client::defaultString(
                           runtime->socks5Proxy, _socks5Proxy)))},
       {"socks5NetWork",
        boost::any(string(Darabonba_Util::Client::defaultString(
            runtime->socks5NetWork, _socks5NetWork)))},
       {"maxIdleConns", boost::any(Darabonba_Util::Client::defaultNumber(
                            runtime->maxIdleConns, _maxIdleConns))},
       {"retry", boost::any(map<string, boost::any>(
                     {{"retryable", !runtime->autoretry
                                        ? boost::any()
                                        : boost::any(*runtime->autoretry)},
                      {"maxAttempts",
                       boost::any(Darabonba_Util::Client::defaultNumber(
                           runtime->maxAttempts, make_shared<int>(3)))}}))},
       {"backoff",
        boost::any(map<string, boost::any>(
            {{"policy",
              boost::any(string(Darabonba_Util::Client::defaultString(
                  runtime->backoffPolicy, make_shared<string>("no"))))},
             {"period", boost::any(Darabonba_Util::Client::defaultNumber(
                            runtime->backoffPeriod, make_shared<int>(1)))}}))},
       {"ignoreSSL", !runtime->ignoreSSL ? boost::any()
                                         : boost::any(*runtime->ignoreSSL)}}));
  shared_ptr<Darabonba::Request> _lastRequest;
  shared_ptr<std::exception> _lastException;
  shared_ptr<int> _now = make_shared<int>(0);
  shared_ptr<int> _retryTimes = make_shared<int>(0);
  while (Darabonba::Core::allowRetry(
      make_shared<boost::any>((*runtime_)["retry"]), _retryTimes, _now)) {
    if (*_retryTimes > 0) {
      shared_ptr<int> _backoffTime =
          make_shared<int>(Darabonba::Core::getBackoffTime(
              make_shared<boost::any>((*runtime_)["backoff"]), _retryTimes));
      if (*_backoffTime > 0) {
        Darabonba::Core::sleep(_backoffTime);
      }
    }
    _retryTimes = make_shared<int>(*_retryTimes + 1);
    try {
      shared_ptr<Darabonba::Request> request_ =
          make_shared<Darabonba::Request>();
      shared_ptr<string> accessKeyId =
          make_shared<string>(_credential->getAccessKeyId());
      shared_ptr<string> accessKeySecret =
          make_shared<string>(_credential->getAccessKeySecret());
      shared_ptr<string> token =
          make_shared<string>(_credential->getSecurityToken());
      request_->protocol = *_protocol;
      request_->method = "DELETE";
      request_->pathname = string("/" + *request->objectName + "");
      request_->headers = {
          {"host", Alibabacloud_OSSUtil::Client::getHost(
                       request->bucketName, _regionId, _endpoint, _hostModel)},
          {"date", Darabonba_Util::Client::getDateUTCString()},
          {"user-agent", getUserAgent()}};
      if (!Darabonba_Util::Client::empty(token)) {
        request_->headers.insert(
            pair<string, string>("x-oss-security-token", *token));
      }
      request_->query = Darabonba_Util::Client::stringifyMapValue(
          make_shared<map<string, boost::any>>(request->filter->toMap()));
      request_->headers.insert(pair<string, string>(
          "authorization",
          Alibabacloud_OSSUtil::Client::getSignature(
              request_, request->bucketName, accessKeyId, accessKeySecret,
              _signatureVersion, _addtionalHeaders)));
      _lastRequest = request_;
      shared_ptr<Darabonba::Response> response_ =
          make_shared<Darabonba::Response>(
              Darabonba::Core::doAction(request_, runtime_));
      shared_ptr<map<string, boost::any>> respMap;
      shared_ptr<string> bodyStr;
      if (Darabonba_Util::Client::is4xx(
              make_shared<int>(response_->statusCode)) ||
          Darabonba_Util::Client::is5xx(
              make_shared<int>(response_->statusCode))) {
        bodyStr = make_shared<string>(
            Darabonba_Util::Client::readAsString(response_->body));
        respMap = make_shared<map<string, boost::any>>(
            Alibabacloud_OSSUtil::Client::getErrMessage(bodyStr));
        BOOST_THROW_EXCEPTION(Darabonba::Error(map<string, boost::any>(
            {{"code", (*respMap)["Code"]},
             {"message", (*respMap)["Message"]},
             {"data", boost::any(map<string, boost::any>(
                          {{"httpCode", boost::any(response_->statusCode)},
                           {"requestId", (*respMap)["RequestId"]},
                           {"hostId", (*respMap)["HostId"]}}))}})));
      }
      return AbortMultipartUploadResponse(
          Darabonba::Converter::toGenericMap(Darabonba::Converter::merge(
              map<string, string>(), response_->headers)));
    } catch (std::exception &e) {
      if (Darabonba::Core::isRetryable(e)) {
        _lastException = make_shared<std::exception>(e);
        continue;
      }
      BOOST_THROW_EXCEPTION(e);
    }
  }
  BOOST_THROW_EXCEPTION(
      Darabonba::UnretryableError(_lastRequest, _lastException));
}

AppendObjectResponse Alibabacloud_OSS::Client::appendObject(
    shared_ptr<AppendObjectRequest> request,
    shared_ptr<Alibabacloud_OSSUtil::RuntimeOptions> runtime) {
  request->validate();
  runtime->validate();
  shared_ptr<map<string, boost::any>> runtime_ = make_shared<
      map<string, boost::any>>(map<string, boost::any>(
      {{"timeouted", boost::any(string("retry"))},
       {"readTimeout", boost::any(Darabonba_Util::Client::defaultNumber(
                           runtime->readTimeout, _readTimeout))},
       {"connectTimeout", boost::any(Darabonba_Util::Client::defaultNumber(
                              runtime->connectTimeout, _connectTimeout))},
       {"localAddr", boost::any(string(Darabonba_Util::Client::defaultString(
                         runtime->localAddr, _localAddr)))},
       {"httpProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                         runtime->httpProxy, _httpProxy)))},
       {"httpsProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                          runtime->httpsProxy, _httpsProxy)))},
       {"noProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                       runtime->noProxy, _noProxy)))},
       {"socks5Proxy", boost::any(string(Darabonba_Util::Client::defaultString(
                           runtime->socks5Proxy, _socks5Proxy)))},
       {"socks5NetWork",
        boost::any(string(Darabonba_Util::Client::defaultString(
            runtime->socks5NetWork, _socks5NetWork)))},
       {"maxIdleConns", boost::any(Darabonba_Util::Client::defaultNumber(
                            runtime->maxIdleConns, _maxIdleConns))},
       {"retry", boost::any(map<string, boost::any>(
                     {{"retryable", !runtime->autoretry
                                        ? boost::any()
                                        : boost::any(*runtime->autoretry)},
                      {"maxAttempts",
                       boost::any(Darabonba_Util::Client::defaultNumber(
                           runtime->maxAttempts, make_shared<int>(3)))}}))},
       {"backoff",
        boost::any(map<string, boost::any>(
            {{"policy",
              boost::any(string(Darabonba_Util::Client::defaultString(
                  runtime->backoffPolicy, make_shared<string>("no"))))},
             {"period", boost::any(Darabonba_Util::Client::defaultNumber(
                            runtime->backoffPeriod, make_shared<int>(1)))}}))},
       {"ignoreSSL", !runtime->ignoreSSL ? boost::any()
                                         : boost::any(*runtime->ignoreSSL)}}));
  shared_ptr<Darabonba::Request> _lastRequest;
  shared_ptr<std::exception> _lastException;
  shared_ptr<int> _now = make_shared<int>(0);
  shared_ptr<int> _retryTimes = make_shared<int>(0);
  while (Darabonba::Core::allowRetry(
      make_shared<boost::any>((*runtime_)["retry"]), _retryTimes, _now)) {
    if (*_retryTimes > 0) {
      shared_ptr<int> _backoffTime =
          make_shared<int>(Darabonba::Core::getBackoffTime(
              make_shared<boost::any>((*runtime_)["backoff"]), _retryTimes));
      if (*_backoffTime > 0) {
        Darabonba::Core::sleep(_backoffTime);
      }
    }
    _retryTimes = make_shared<int>(*_retryTimes + 1);
    try {
      shared_ptr<Darabonba::Request> request_ =
          make_shared<Darabonba::Request>();
      shared_ptr<map<string, string>> ctx =
          make_shared<map<string, string>>(map<string, string>());
      shared_ptr<string> accessKeyId =
          make_shared<string>(_credential->getAccessKeyId());
      shared_ptr<string> accessKeySecret =
          make_shared<string>(_credential->getAccessKeySecret());
      shared_ptr<string> token =
          make_shared<string>(_credential->getSecurityToken());
      request_->protocol = *_protocol;
      request_->method = "POST";
      request_->pathname = string("/" + *request->objectName + "?append");
      request_->headers = Darabonba::Converter::merge(
          map<string, string>(
              {{"host",
                Alibabacloud_OSSUtil::Client::getHost(
                    request->bucketName, _regionId, _endpoint, _hostModel)},
               {"date", Darabonba_Util::Client::getDateUTCString()},
               {"user-agent", getUserAgent()}}),
          Darabonba_Util::Client::stringifyMapValue(
              make_shared<map<string, boost::any>>(request->header->toMap())),
          Alibabacloud_OSSUtil::Client::parseMeta(
              request->userMeta, make_shared<string>("x-oss-meta-")));
      if (!Darabonba_Util::Client::empty(token)) {
        request_->headers.insert(
            pair<string, string>("x-oss-security-token", *token));
      }
      request_->query = Darabonba_Util::Client::stringifyMapValue(
          make_shared<map<string, boost::any>>(request->filter->toMap()));
      request_->body = Alibabacloud_OSSUtil::Client::inject(request->body, ctx);
      if (!Darabonba_Util::Client::isUnset<AppendObjectRequestHeader>(
              request->header) &&
          !Darabonba_Util::Client::empty(request->header->contentType)) {
        request_->headers.insert(pair<string, string>(
            "content-type", *request->header->contentType));
      } else {
        request_->headers.insert(pair<string, string>(
            "content-type",
            Alibabacloud_OSSUtil::Client::getContentType(request->objectName)));
      }
      request_->headers.insert(pair<string, string>(
          "authorization",
          Alibabacloud_OSSUtil::Client::getSignature(
              request_, request->bucketName, accessKeyId, accessKeySecret,
              _signatureVersion, _addtionalHeaders)));
      _lastRequest = request_;
      shared_ptr<Darabonba::Response> response_ =
          make_shared<Darabonba::Response>(
              Darabonba::Core::doAction(request_, runtime_));
      shared_ptr<map<string, boost::any>> respMap;
      shared_ptr<string> bodyStr;
      if (Darabonba_Util::Client::is4xx(
              make_shared<int>(response_->statusCode)) ||
          Darabonba_Util::Client::is5xx(
              make_shared<int>(response_->statusCode))) {
        bodyStr = make_shared<string>(
            Darabonba_Util::Client::readAsString(response_->body));
        respMap = make_shared<map<string, boost::any>>(
            Alibabacloud_OSSUtil::Client::getErrMessage(bodyStr));
        BOOST_THROW_EXCEPTION(Darabonba::Error(map<string, boost::any>(
            {{"code", (*respMap)["Code"]},
             {"message", (*respMap)["Message"]},
             {"data", boost::any(map<string, boost::any>(
                          {{"httpCode", boost::any(response_->statusCode)},
                           {"requestId", (*respMap)["RequestId"]},
                           {"hostId", (*respMap)["HostId"]}}))}})));
      }
      if (*_isEnableCrc &&
          !Darabonba_Util::Client::equalString(
              make_shared<string>((*ctx)["crc"]),
              make_shared<string>(
                  response_->headers["x-oss-hash-crc64ecma"]))) {
        BOOST_THROW_EXCEPTION(Darabonba::Error(map<string, boost::any>(
            {{"code", boost::any(string("CrcNotMatched"))},
             {"data", boost::any(map<string, string>(
                          {{"clientCrc", (*ctx)["crc"]},
                           {"serverCrc",
                            response_->headers["x-oss-hash-crc64ecma"]}}))}})));
      }
      if (*_isEnableMD5 &&
          !Darabonba_Util::Client::equalString(
              make_shared<string>((*ctx)["md5"]),
              make_shared<string>(response_->headers["content-md5"]))) {
        BOOST_THROW_EXCEPTION(Darabonba::Error(map<string, boost::any>(
            {{"code", boost::any(string("MD5NotMatched"))},
             {"data",
              boost::any(map<string, string>(
                  {{"clientMD5", (*ctx)["md5"]},
                   {"serverMD5", response_->headers["content-md5"]}}))}})));
      }
      return AppendObjectResponse(
          Darabonba::Converter::toGenericMap(Darabonba::Converter::merge(
              map<string, string>(), response_->headers)));
    } catch (std::exception &e) {
      if (Darabonba::Core::isRetryable(e)) {
        _lastException = make_shared<std::exception>(e);
        continue;
      }
      BOOST_THROW_EXCEPTION(e);
    }
  }
  BOOST_THROW_EXCEPTION(
      Darabonba::UnretryableError(_lastRequest, _lastException));
}

UploadPartCopyResponse Alibabacloud_OSS::Client::uploadPartCopy(
    shared_ptr<UploadPartCopyRequest> request,
    shared_ptr<Alibabacloud_OSSUtil::RuntimeOptions> runtime) {
  request->validate();
  runtime->validate();
  shared_ptr<map<string, boost::any>> runtime_ = make_shared<
      map<string, boost::any>>(map<string, boost::any>(
      {{"timeouted", boost::any(string("retry"))},
       {"readTimeout", boost::any(Darabonba_Util::Client::defaultNumber(
                           runtime->readTimeout, _readTimeout))},
       {"connectTimeout", boost::any(Darabonba_Util::Client::defaultNumber(
                              runtime->connectTimeout, _connectTimeout))},
       {"localAddr", boost::any(string(Darabonba_Util::Client::defaultString(
                         runtime->localAddr, _localAddr)))},
       {"httpProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                         runtime->httpProxy, _httpProxy)))},
       {"httpsProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                          runtime->httpsProxy, _httpsProxy)))},
       {"noProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                       runtime->noProxy, _noProxy)))},
       {"socks5Proxy", boost::any(string(Darabonba_Util::Client::defaultString(
                           runtime->socks5Proxy, _socks5Proxy)))},
       {"socks5NetWork",
        boost::any(string(Darabonba_Util::Client::defaultString(
            runtime->socks5NetWork, _socks5NetWork)))},
       {"maxIdleConns", boost::any(Darabonba_Util::Client::defaultNumber(
                            runtime->maxIdleConns, _maxIdleConns))},
       {"retry", boost::any(map<string, boost::any>(
                     {{"retryable", !runtime->autoretry
                                        ? boost::any()
                                        : boost::any(*runtime->autoretry)},
                      {"maxAttempts",
                       boost::any(Darabonba_Util::Client::defaultNumber(
                           runtime->maxAttempts, make_shared<int>(3)))}}))},
       {"backoff",
        boost::any(map<string, boost::any>(
            {{"policy",
              boost::any(string(Darabonba_Util::Client::defaultString(
                  runtime->backoffPolicy, make_shared<string>("no"))))},
             {"period", boost::any(Darabonba_Util::Client::defaultNumber(
                            runtime->backoffPeriod, make_shared<int>(1)))}}))},
       {"ignoreSSL", !runtime->ignoreSSL ? boost::any()
                                         : boost::any(*runtime->ignoreSSL)}}));
  shared_ptr<Darabonba::Request> _lastRequest;
  shared_ptr<std::exception> _lastException;
  shared_ptr<int> _now = make_shared<int>(0);
  shared_ptr<int> _retryTimes = make_shared<int>(0);
  while (Darabonba::Core::allowRetry(
      make_shared<boost::any>((*runtime_)["retry"]), _retryTimes, _now)) {
    if (*_retryTimes > 0) {
      shared_ptr<int> _backoffTime =
          make_shared<int>(Darabonba::Core::getBackoffTime(
              make_shared<boost::any>((*runtime_)["backoff"]), _retryTimes));
      if (*_backoffTime > 0) {
        Darabonba::Core::sleep(_backoffTime);
      }
    }
    _retryTimes = make_shared<int>(*_retryTimes + 1);
    try {
      shared_ptr<Darabonba::Request> request_ =
          make_shared<Darabonba::Request>();
      shared_ptr<string> accessKeyId =
          make_shared<string>(_credential->getAccessKeyId());
      shared_ptr<string> accessKeySecret =
          make_shared<string>(_credential->getAccessKeySecret());
      shared_ptr<string> token =
          make_shared<string>(_credential->getSecurityToken());
      request_->protocol = *_protocol;
      request_->method = "PUT";
      request_->pathname = string("/" + *request->objectName + "");
      request_->headers = Darabonba::Converter::merge(
          map<string, string>(
              {{"host",
                Alibabacloud_OSSUtil::Client::getHost(
                    request->bucketName, _regionId, _endpoint, _hostModel)},
               {"date", Darabonba_Util::Client::getDateUTCString()},
               {"user-agent", getUserAgent()}}),
          Darabonba_Util::Client::stringifyMapValue(
              make_shared<map<string, boost::any>>(request->header->toMap())));
      if (!Darabonba_Util::Client::empty(token)) {
        request_->headers.insert(
            pair<string, string>("x-oss-security-token", *token));
      }
      request_->query = Darabonba_Util::Client::stringifyMapValue(
          make_shared<map<string, boost::any>>(request->filter->toMap()));
      request_->headers.insert(pair<string, string>(
          "authorization",
          Alibabacloud_OSSUtil::Client::getSignature(
              request_, request->bucketName, accessKeyId, accessKeySecret,
              _signatureVersion, _addtionalHeaders)));
      _lastRequest = request_;
      shared_ptr<Darabonba::Response> response_ =
          make_shared<Darabonba::Response>(
              Darabonba::Core::doAction(request_, runtime_));
      shared_ptr<map<string, boost::any>> respMap;
      shared_ptr<string> bodyStr;
      if (Darabonba_Util::Client::is4xx(
              make_shared<int>(response_->statusCode)) ||
          Darabonba_Util::Client::is5xx(
              make_shared<int>(response_->statusCode))) {
        bodyStr = make_shared<string>(
            Darabonba_Util::Client::readAsString(response_->body));
        respMap = make_shared<map<string, boost::any>>(
            Alibabacloud_OSSUtil::Client::getErrMessage(bodyStr));
        BOOST_THROW_EXCEPTION(Darabonba::Error(map<string, boost::any>(
            {{"code", (*respMap)["Code"]},
             {"message", (*respMap)["Message"]},
             {"data", boost::any(map<string, boost::any>(
                          {{"httpCode", boost::any(response_->statusCode)},
                           {"requestId", (*respMap)["RequestId"]},
                           {"hostId", (*respMap)["HostId"]}}))}})));
      }
      bodyStr = make_shared<string>(
          Darabonba_Util::Client::readAsString(response_->body));
      respMap = make_shared<map<string, boost::any>>(
          Darabonba_XML::Client::parseXml(bodyStr, nullptr));
      return UploadPartCopyResponse(Darabonba::Converter::merge(
          map<string, boost::any>(
              {{"CopyPartResult", (*respMap)["CopyPartResult"]}}),
          Darabonba::Converter::toGenericMap(response_->headers)));
    } catch (std::exception &e) {
      if (Darabonba::Core::isRetryable(e)) {
        _lastException = make_shared<std::exception>(e);
        continue;
      }
      BOOST_THROW_EXCEPTION(e);
    }
  }
  BOOST_THROW_EXCEPTION(
      Darabonba::UnretryableError(_lastRequest, _lastException));
}

GetVodPlaylistResponse Alibabacloud_OSS::Client::getVodPlaylist(
    shared_ptr<GetVodPlaylistRequest> request,
    shared_ptr<Alibabacloud_OSSUtil::RuntimeOptions> runtime) {
  request->validate();
  runtime->validate();
  shared_ptr<map<string, boost::any>> runtime_ = make_shared<
      map<string, boost::any>>(map<string, boost::any>(
      {{"timeouted", boost::any(string("retry"))},
       {"readTimeout", boost::any(Darabonba_Util::Client::defaultNumber(
                           runtime->readTimeout, _readTimeout))},
       {"connectTimeout", boost::any(Darabonba_Util::Client::defaultNumber(
                              runtime->connectTimeout, _connectTimeout))},
       {"localAddr", boost::any(string(Darabonba_Util::Client::defaultString(
                         runtime->localAddr, _localAddr)))},
       {"httpProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                         runtime->httpProxy, _httpProxy)))},
       {"httpsProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                          runtime->httpsProxy, _httpsProxy)))},
       {"noProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                       runtime->noProxy, _noProxy)))},
       {"socks5Proxy", boost::any(string(Darabonba_Util::Client::defaultString(
                           runtime->socks5Proxy, _socks5Proxy)))},
       {"socks5NetWork",
        boost::any(string(Darabonba_Util::Client::defaultString(
            runtime->socks5NetWork, _socks5NetWork)))},
       {"maxIdleConns", boost::any(Darabonba_Util::Client::defaultNumber(
                            runtime->maxIdleConns, _maxIdleConns))},
       {"retry", boost::any(map<string, boost::any>(
                     {{"retryable", !runtime->autoretry
                                        ? boost::any()
                                        : boost::any(*runtime->autoretry)},
                      {"maxAttempts",
                       boost::any(Darabonba_Util::Client::defaultNumber(
                           runtime->maxAttempts, make_shared<int>(3)))}}))},
       {"backoff",
        boost::any(map<string, boost::any>(
            {{"policy",
              boost::any(string(Darabonba_Util::Client::defaultString(
                  runtime->backoffPolicy, make_shared<string>("no"))))},
             {"period", boost::any(Darabonba_Util::Client::defaultNumber(
                            runtime->backoffPeriod, make_shared<int>(1)))}}))},
       {"ignoreSSL", !runtime->ignoreSSL ? boost::any()
                                         : boost::any(*runtime->ignoreSSL)}}));
  shared_ptr<Darabonba::Request> _lastRequest;
  shared_ptr<std::exception> _lastException;
  shared_ptr<int> _now = make_shared<int>(0);
  shared_ptr<int> _retryTimes = make_shared<int>(0);
  while (Darabonba::Core::allowRetry(
      make_shared<boost::any>((*runtime_)["retry"]), _retryTimes, _now)) {
    if (*_retryTimes > 0) {
      shared_ptr<int> _backoffTime =
          make_shared<int>(Darabonba::Core::getBackoffTime(
              make_shared<boost::any>((*runtime_)["backoff"]), _retryTimes));
      if (*_backoffTime > 0) {
        Darabonba::Core::sleep(_backoffTime);
      }
    }
    _retryTimes = make_shared<int>(*_retryTimes + 1);
    try {
      shared_ptr<Darabonba::Request> request_ =
          make_shared<Darabonba::Request>();
      shared_ptr<string> accessKeyId =
          make_shared<string>(_credential->getAccessKeyId());
      shared_ptr<string> accessKeySecret =
          make_shared<string>(_credential->getAccessKeySecret());
      shared_ptr<string> token =
          make_shared<string>(_credential->getSecurityToken());
      request_->protocol = *_protocol;
      request_->method = "GET";
      request_->pathname = string("/" + *request->channelName + "?vod");
      request_->headers = {
          {"host", Alibabacloud_OSSUtil::Client::getHost(
                       request->bucketName, _regionId, _endpoint, _hostModel)},
          {"date", Darabonba_Util::Client::getDateUTCString()},
          {"user-agent", getUserAgent()}};
      if (!Darabonba_Util::Client::empty(token)) {
        request_->headers.insert(
            pair<string, string>("x-oss-security-token", *token));
      }
      request_->query = Darabonba_Util::Client::stringifyMapValue(
          make_shared<map<string, boost::any>>(request->filter->toMap()));
      request_->headers.insert(pair<string, string>(
          "authorization",
          Alibabacloud_OSSUtil::Client::getSignature(
              request_, request->bucketName, accessKeyId, accessKeySecret,
              _signatureVersion, _addtionalHeaders)));
      _lastRequest = request_;
      shared_ptr<Darabonba::Response> response_ =
          make_shared<Darabonba::Response>(
              Darabonba::Core::doAction(request_, runtime_));
      shared_ptr<map<string, boost::any>> respMap;
      shared_ptr<string> bodyStr;
      if (Darabonba_Util::Client::is4xx(
              make_shared<int>(response_->statusCode)) ||
          Darabonba_Util::Client::is5xx(
              make_shared<int>(response_->statusCode))) {
        bodyStr = make_shared<string>(
            Darabonba_Util::Client::readAsString(response_->body));
        respMap = make_shared<map<string, boost::any>>(
            Alibabacloud_OSSUtil::Client::getErrMessage(bodyStr));
        BOOST_THROW_EXCEPTION(Darabonba::Error(map<string, boost::any>(
            {{"code", (*respMap)["Code"]},
             {"message", (*respMap)["Message"]},
             {"data", boost::any(map<string, boost::any>(
                          {{"httpCode", boost::any(response_->statusCode)},
                           {"requestId", (*respMap)["RequestId"]},
                           {"hostId", (*respMap)["HostId"]}}))}})));
      }
      return GetVodPlaylistResponse(
          Darabonba::Converter::toGenericMap(Darabonba::Converter::merge(
              map<string, string>(), response_->headers)));
    } catch (std::exception &e) {
      if (Darabonba::Core::isRetryable(e)) {
        _lastException = make_shared<std::exception>(e);
        continue;
      }
      BOOST_THROW_EXCEPTION(e);
    }
  }
  BOOST_THROW_EXCEPTION(
      Darabonba::UnretryableError(_lastRequest, _lastException));
}

DeleteBucketCORSResponse Alibabacloud_OSS::Client::deleteBucketCORS(
    shared_ptr<DeleteBucketCORSRequest> request,
    shared_ptr<Alibabacloud_OSSUtil::RuntimeOptions> runtime) {
  request->validate();
  runtime->validate();
  shared_ptr<map<string, boost::any>> runtime_ = make_shared<
      map<string, boost::any>>(map<string, boost::any>(
      {{"timeouted", boost::any(string("retry"))},
       {"readTimeout", boost::any(Darabonba_Util::Client::defaultNumber(
                           runtime->readTimeout, _readTimeout))},
       {"connectTimeout", boost::any(Darabonba_Util::Client::defaultNumber(
                              runtime->connectTimeout, _connectTimeout))},
       {"localAddr", boost::any(string(Darabonba_Util::Client::defaultString(
                         runtime->localAddr, _localAddr)))},
       {"httpProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                         runtime->httpProxy, _httpProxy)))},
       {"httpsProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                          runtime->httpsProxy, _httpsProxy)))},
       {"noProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                       runtime->noProxy, _noProxy)))},
       {"socks5Proxy", boost::any(string(Darabonba_Util::Client::defaultString(
                           runtime->socks5Proxy, _socks5Proxy)))},
       {"socks5NetWork",
        boost::any(string(Darabonba_Util::Client::defaultString(
            runtime->socks5NetWork, _socks5NetWork)))},
       {"maxIdleConns", boost::any(Darabonba_Util::Client::defaultNumber(
                            runtime->maxIdleConns, _maxIdleConns))},
       {"retry", boost::any(map<string, boost::any>(
                     {{"retryable", !runtime->autoretry
                                        ? boost::any()
                                        : boost::any(*runtime->autoretry)},
                      {"maxAttempts",
                       boost::any(Darabonba_Util::Client::defaultNumber(
                           runtime->maxAttempts, make_shared<int>(3)))}}))},
       {"backoff",
        boost::any(map<string, boost::any>(
            {{"policy",
              boost::any(string(Darabonba_Util::Client::defaultString(
                  runtime->backoffPolicy, make_shared<string>("no"))))},
             {"period", boost::any(Darabonba_Util::Client::defaultNumber(
                            runtime->backoffPeriod, make_shared<int>(1)))}}))},
       {"ignoreSSL", !runtime->ignoreSSL ? boost::any()
                                         : boost::any(*runtime->ignoreSSL)}}));
  shared_ptr<Darabonba::Request> _lastRequest;
  shared_ptr<std::exception> _lastException;
  shared_ptr<int> _now = make_shared<int>(0);
  shared_ptr<int> _retryTimes = make_shared<int>(0);
  while (Darabonba::Core::allowRetry(
      make_shared<boost::any>((*runtime_)["retry"]), _retryTimes, _now)) {
    if (*_retryTimes > 0) {
      shared_ptr<int> _backoffTime =
          make_shared<int>(Darabonba::Core::getBackoffTime(
              make_shared<boost::any>((*runtime_)["backoff"]), _retryTimes));
      if (*_backoffTime > 0) {
        Darabonba::Core::sleep(_backoffTime);
      }
    }
    _retryTimes = make_shared<int>(*_retryTimes + 1);
    try {
      shared_ptr<Darabonba::Request> request_ =
          make_shared<Darabonba::Request>();
      shared_ptr<string> accessKeyId =
          make_shared<string>(_credential->getAccessKeyId());
      shared_ptr<string> accessKeySecret =
          make_shared<string>(_credential->getAccessKeySecret());
      shared_ptr<string> token =
          make_shared<string>(_credential->getSecurityToken());
      request_->protocol = *_protocol;
      request_->method = "DELETE";
      request_->pathname = string("/?cors");
      request_->headers = {
          {"host", Alibabacloud_OSSUtil::Client::getHost(
                       request->bucketName, _regionId, _endpoint, _hostModel)},
          {"date", Darabonba_Util::Client::getDateUTCString()},
          {"user-agent", getUserAgent()}};
      if (!Darabonba_Util::Client::empty(token)) {
        request_->headers.insert(
            pair<string, string>("x-oss-security-token", *token));
      }
      request_->headers.insert(pair<string, string>(
          "authorization",
          Alibabacloud_OSSUtil::Client::getSignature(
              request_, request->bucketName, accessKeyId, accessKeySecret,
              _signatureVersion, _addtionalHeaders)));
      _lastRequest = request_;
      shared_ptr<Darabonba::Response> response_ =
          make_shared<Darabonba::Response>(
              Darabonba::Core::doAction(request_, runtime_));
      shared_ptr<map<string, boost::any>> respMap;
      shared_ptr<string> bodyStr;
      if (Darabonba_Util::Client::is4xx(
              make_shared<int>(response_->statusCode)) ||
          Darabonba_Util::Client::is5xx(
              make_shared<int>(response_->statusCode))) {
        bodyStr = make_shared<string>(
            Darabonba_Util::Client::readAsString(response_->body));
        respMap = make_shared<map<string, boost::any>>(
            Alibabacloud_OSSUtil::Client::getErrMessage(bodyStr));
        BOOST_THROW_EXCEPTION(Darabonba::Error(map<string, boost::any>(
            {{"code", (*respMap)["Code"]},
             {"message", (*respMap)["Message"]},
             {"data", boost::any(map<string, boost::any>(
                          {{"httpCode", boost::any(response_->statusCode)},
                           {"requestId", (*respMap)["RequestId"]},
                           {"hostId", (*respMap)["HostId"]}}))}})));
      }
      return DeleteBucketCORSResponse(
          Darabonba::Converter::toGenericMap(Darabonba::Converter::merge(
              map<string, string>(), response_->headers)));
    } catch (std::exception &e) {
      if (Darabonba::Core::isRetryable(e)) {
        _lastException = make_shared<std::exception>(e);
        continue;
      }
      BOOST_THROW_EXCEPTION(e);
    }
  }
  BOOST_THROW_EXCEPTION(
      Darabonba::UnretryableError(_lastRequest, _lastException));
}

GetObjectResponse Alibabacloud_OSS::Client::getObject(
    shared_ptr<GetObjectRequest> request,
    shared_ptr<Alibabacloud_OSSUtil::RuntimeOptions> runtime) {
  request->validate();
  runtime->validate();
  shared_ptr<map<string, boost::any>> runtime_ = make_shared<
      map<string, boost::any>>(map<string, boost::any>(
      {{"timeouted", boost::any(string("retry"))},
       {"readTimeout", boost::any(Darabonba_Util::Client::defaultNumber(
                           runtime->readTimeout, _readTimeout))},
       {"connectTimeout", boost::any(Darabonba_Util::Client::defaultNumber(
                              runtime->connectTimeout, _connectTimeout))},
       {"localAddr", boost::any(string(Darabonba_Util::Client::defaultString(
                         runtime->localAddr, _localAddr)))},
       {"httpProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                         runtime->httpProxy, _httpProxy)))},
       {"httpsProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                          runtime->httpsProxy, _httpsProxy)))},
       {"noProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                       runtime->noProxy, _noProxy)))},
       {"socks5Proxy", boost::any(string(Darabonba_Util::Client::defaultString(
                           runtime->socks5Proxy, _socks5Proxy)))},
       {"socks5NetWork",
        boost::any(string(Darabonba_Util::Client::defaultString(
            runtime->socks5NetWork, _socks5NetWork)))},
       {"maxIdleConns", boost::any(Darabonba_Util::Client::defaultNumber(
                            runtime->maxIdleConns, _maxIdleConns))},
       {"retry", boost::any(map<string, boost::any>(
                     {{"retryable", !runtime->autoretry
                                        ? boost::any()
                                        : boost::any(*runtime->autoretry)},
                      {"maxAttempts",
                       boost::any(Darabonba_Util::Client::defaultNumber(
                           runtime->maxAttempts, make_shared<int>(3)))}}))},
       {"backoff",
        boost::any(map<string, boost::any>(
            {{"policy",
              boost::any(string(Darabonba_Util::Client::defaultString(
                  runtime->backoffPolicy, make_shared<string>("no"))))},
             {"period", boost::any(Darabonba_Util::Client::defaultNumber(
                            runtime->backoffPeriod, make_shared<int>(1)))}}))},
       {"ignoreSSL", !runtime->ignoreSSL ? boost::any()
                                         : boost::any(*runtime->ignoreSSL)}}));
  shared_ptr<Darabonba::Request> _lastRequest;
  shared_ptr<std::exception> _lastException;
  shared_ptr<int> _now = make_shared<int>(0);
  shared_ptr<int> _retryTimes = make_shared<int>(0);
  while (Darabonba::Core::allowRetry(
      make_shared<boost::any>((*runtime_)["retry"]), _retryTimes, _now)) {
    if (*_retryTimes > 0) {
      shared_ptr<int> _backoffTime =
          make_shared<int>(Darabonba::Core::getBackoffTime(
              make_shared<boost::any>((*runtime_)["backoff"]), _retryTimes));
      if (*_backoffTime > 0) {
        Darabonba::Core::sleep(_backoffTime);
      }
    }
    _retryTimes = make_shared<int>(*_retryTimes + 1);
    try {
      shared_ptr<Darabonba::Request> request_ =
          make_shared<Darabonba::Request>();
      shared_ptr<string> accessKeyId =
          make_shared<string>(_credential->getAccessKeyId());
      shared_ptr<string> accessKeySecret =
          make_shared<string>(_credential->getAccessKeySecret());
      shared_ptr<string> token =
          make_shared<string>(_credential->getSecurityToken());
      request_->protocol = *_protocol;
      request_->method = "GET";
      request_->pathname = string("/" + *request->objectName + "");
      request_->headers = Darabonba::Converter::merge(
          map<string, string>(
              {{"host",
                Alibabacloud_OSSUtil::Client::getHost(
                    request->bucketName, _regionId, _endpoint, _hostModel)},
               {"date", Darabonba_Util::Client::getDateUTCString()},
               {"user-agent", getUserAgent()}}),
          Darabonba_Util::Client::stringifyMapValue(
              make_shared<map<string, boost::any>>(request->header->toMap())));
      if (!Darabonba_Util::Client::empty(token)) {
        request_->headers.insert(
            pair<string, string>("x-oss-security-token", *token));
      }
      request_->headers.insert(pair<string, string>(
          "authorization",
          Alibabacloud_OSSUtil::Client::getSignature(
              request_, request->bucketName, accessKeyId, accessKeySecret,
              _signatureVersion, _addtionalHeaders)));
      _lastRequest = request_;
      shared_ptr<Darabonba::Response> response_ =
          make_shared<Darabonba::Response>(
              Darabonba::Core::doAction(request_, runtime_));
      shared_ptr<map<string, boost::any>> respMap;
      shared_ptr<string> bodyStr;
      if (Darabonba_Util::Client::is4xx(
              make_shared<int>(response_->statusCode)) ||
          Darabonba_Util::Client::is5xx(
              make_shared<int>(response_->statusCode))) {
        bodyStr = make_shared<string>(
            Darabonba_Util::Client::readAsString(response_->body));
        respMap = make_shared<map<string, boost::any>>(
            Alibabacloud_OSSUtil::Client::getErrMessage(bodyStr));
        BOOST_THROW_EXCEPTION(Darabonba::Error(map<string, boost::any>(
            {{"code", (*respMap)["Code"]},
             {"message", (*respMap)["Message"]},
             {"data", boost::any(map<string, boost::any>(
                          {{"httpCode", boost::any(response_->statusCode)},
                           {"requestId", (*respMap)["RequestId"]},
                           {"hostId", (*respMap)["HostId"]}}))}})));
      }
      return GetObjectResponse(Darabonba::Converter::merge(
          map<string, boost::any>(
              {{"body", !response_->body ? boost::any()
                                         : boost::any(*response_->body)}}),
          Darabonba::Converter::toGenericMap(response_->headers)));
    } catch (std::exception &e) {
      if (Darabonba::Core::isRetryable(e)) {
        _lastException = make_shared<std::exception>(e);
        continue;
      }
      BOOST_THROW_EXCEPTION(e);
    }
  }
  BOOST_THROW_EXCEPTION(
      Darabonba::UnretryableError(_lastRequest, _lastException));
}

UploadPartResponse Alibabacloud_OSS::Client::uploadPart(
    shared_ptr<UploadPartRequest> request,
    shared_ptr<Alibabacloud_OSSUtil::RuntimeOptions> runtime) {
  request->validate();
  runtime->validate();
  shared_ptr<map<string, boost::any>> runtime_ = make_shared<
      map<string, boost::any>>(map<string, boost::any>(
      {{"timeouted", boost::any(string("retry"))},
       {"readTimeout", boost::any(Darabonba_Util::Client::defaultNumber(
                           runtime->readTimeout, _readTimeout))},
       {"connectTimeout", boost::any(Darabonba_Util::Client::defaultNumber(
                              runtime->connectTimeout, _connectTimeout))},
       {"localAddr", boost::any(string(Darabonba_Util::Client::defaultString(
                         runtime->localAddr, _localAddr)))},
       {"httpProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                         runtime->httpProxy, _httpProxy)))},
       {"httpsProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                          runtime->httpsProxy, _httpsProxy)))},
       {"noProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                       runtime->noProxy, _noProxy)))},
       {"socks5Proxy", boost::any(string(Darabonba_Util::Client::defaultString(
                           runtime->socks5Proxy, _socks5Proxy)))},
       {"socks5NetWork",
        boost::any(string(Darabonba_Util::Client::defaultString(
            runtime->socks5NetWork, _socks5NetWork)))},
       {"maxIdleConns", boost::any(Darabonba_Util::Client::defaultNumber(
                            runtime->maxIdleConns, _maxIdleConns))},
       {"retry", boost::any(map<string, boost::any>(
                     {{"retryable", !runtime->autoretry
                                        ? boost::any()
                                        : boost::any(*runtime->autoretry)},
                      {"maxAttempts",
                       boost::any(Darabonba_Util::Client::defaultNumber(
                           runtime->maxAttempts, make_shared<int>(3)))}}))},
       {"backoff",
        boost::any(map<string, boost::any>(
            {{"policy",
              boost::any(string(Darabonba_Util::Client::defaultString(
                  runtime->backoffPolicy, make_shared<string>("no"))))},
             {"period", boost::any(Darabonba_Util::Client::defaultNumber(
                            runtime->backoffPeriod, make_shared<int>(1)))}}))},
       {"ignoreSSL", !runtime->ignoreSSL ? boost::any()
                                         : boost::any(*runtime->ignoreSSL)}}));
  shared_ptr<Darabonba::Request> _lastRequest;
  shared_ptr<std::exception> _lastException;
  shared_ptr<int> _now = make_shared<int>(0);
  shared_ptr<int> _retryTimes = make_shared<int>(0);
  while (Darabonba::Core::allowRetry(
      make_shared<boost::any>((*runtime_)["retry"]), _retryTimes, _now)) {
    if (*_retryTimes > 0) {
      shared_ptr<int> _backoffTime =
          make_shared<int>(Darabonba::Core::getBackoffTime(
              make_shared<boost::any>((*runtime_)["backoff"]), _retryTimes));
      if (*_backoffTime > 0) {
        Darabonba::Core::sleep(_backoffTime);
      }
    }
    _retryTimes = make_shared<int>(*_retryTimes + 1);
    try {
      shared_ptr<Darabonba::Request> request_ =
          make_shared<Darabonba::Request>();
      shared_ptr<map<string, string>> ctx =
          make_shared<map<string, string>>(map<string, string>());
      shared_ptr<string> accessKeyId =
          make_shared<string>(_credential->getAccessKeyId());
      shared_ptr<string> accessKeySecret =
          make_shared<string>(_credential->getAccessKeySecret());
      shared_ptr<string> token =
          make_shared<string>(_credential->getSecurityToken());
      request_->protocol = *_protocol;
      request_->method = "PUT";
      request_->pathname = string("/" + *request->objectName + "");
      request_->headers = {
          {"host", Alibabacloud_OSSUtil::Client::getHost(
                       request->bucketName, _regionId, _endpoint, _hostModel)},
          {"date", Darabonba_Util::Client::getDateUTCString()},
          {"user-agent", getUserAgent()}};
      if (!Darabonba_Util::Client::empty(token)) {
        request_->headers.insert(
            pair<string, string>("x-oss-security-token", *token));
      }
      request_->query = Darabonba_Util::Client::stringifyMapValue(
          make_shared<map<string, boost::any>>(request->filter->toMap()));
      request_->body = Alibabacloud_OSSUtil::Client::inject(request->body, ctx);
      request_->headers.insert(pair<string, string>(
          "authorization",
          Alibabacloud_OSSUtil::Client::getSignature(
              request_, request->bucketName, accessKeyId, accessKeySecret,
              _signatureVersion, _addtionalHeaders)));
      _lastRequest = request_;
      shared_ptr<Darabonba::Response> response_ =
          make_shared<Darabonba::Response>(
              Darabonba::Core::doAction(request_, runtime_));
      shared_ptr<map<string, boost::any>> respMap;
      shared_ptr<string> bodyStr;
      if (Darabonba_Util::Client::is4xx(
              make_shared<int>(response_->statusCode)) ||
          Darabonba_Util::Client::is5xx(
              make_shared<int>(response_->statusCode))) {
        bodyStr = make_shared<string>(
            Darabonba_Util::Client::readAsString(response_->body));
        respMap = make_shared<map<string, boost::any>>(
            Alibabacloud_OSSUtil::Client::getErrMessage(bodyStr));
        BOOST_THROW_EXCEPTION(Darabonba::Error(map<string, boost::any>(
            {{"code", (*respMap)["Code"]},
             {"message", (*respMap)["Message"]},
             {"data", boost::any(map<string, boost::any>(
                          {{"httpCode", boost::any(response_->statusCode)},
                           {"requestId", (*respMap)["RequestId"]},
                           {"hostId", (*respMap)["HostId"]}}))}})));
      }
      if (*_isEnableCrc &&
          !Darabonba_Util::Client::equalString(
              make_shared<string>((*ctx)["crc"]),
              make_shared<string>(
                  response_->headers["x-oss-hash-crc64ecma"]))) {
        BOOST_THROW_EXCEPTION(Darabonba::Error(map<string, boost::any>(
            {{"code", boost::any(string("CrcNotMatched"))},
             {"data", boost::any(map<string, string>(
                          {{"clientCrc", (*ctx)["crc"]},
                           {"serverCrc",
                            response_->headers["x-oss-hash-crc64ecma"]}}))}})));
      }
      if (*_isEnableMD5 &&
          !Darabonba_Util::Client::equalString(
              make_shared<string>((*ctx)["md5"]),
              make_shared<string>(response_->headers["content-md5"]))) {
        BOOST_THROW_EXCEPTION(Darabonba::Error(map<string, boost::any>(
            {{"code", boost::any(string("MD5NotMatched"))},
             {"data",
              boost::any(map<string, string>(
                  {{"clientMD5", (*ctx)["md5"]},
                   {"serverMD5", response_->headers["content-md5"]}}))}})));
      }
      return UploadPartResponse(
          Darabonba::Converter::toGenericMap(Darabonba::Converter::merge(
              map<string, string>(), response_->headers)));
    } catch (std::exception &e) {
      if (Darabonba::Core::isRetryable(e)) {
        _lastException = make_shared<std::exception>(e);
        continue;
      }
      BOOST_THROW_EXCEPTION(e);
    }
  }
  BOOST_THROW_EXCEPTION(
      Darabonba::UnretryableError(_lastRequest, _lastException));
}

GetBucketCORSResponse Alibabacloud_OSS::Client::getBucketCORS(
    shared_ptr<GetBucketCORSRequest> request,
    shared_ptr<Alibabacloud_OSSUtil::RuntimeOptions> runtime) {
  request->validate();
  runtime->validate();
  shared_ptr<map<string, boost::any>> runtime_ = make_shared<
      map<string, boost::any>>(map<string, boost::any>(
      {{"timeouted", boost::any(string("retry"))},
       {"readTimeout", boost::any(Darabonba_Util::Client::defaultNumber(
                           runtime->readTimeout, _readTimeout))},
       {"connectTimeout", boost::any(Darabonba_Util::Client::defaultNumber(
                              runtime->connectTimeout, _connectTimeout))},
       {"localAddr", boost::any(string(Darabonba_Util::Client::defaultString(
                         runtime->localAddr, _localAddr)))},
       {"httpProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                         runtime->httpProxy, _httpProxy)))},
       {"httpsProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                          runtime->httpsProxy, _httpsProxy)))},
       {"noProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                       runtime->noProxy, _noProxy)))},
       {"socks5Proxy", boost::any(string(Darabonba_Util::Client::defaultString(
                           runtime->socks5Proxy, _socks5Proxy)))},
       {"socks5NetWork",
        boost::any(string(Darabonba_Util::Client::defaultString(
            runtime->socks5NetWork, _socks5NetWork)))},
       {"maxIdleConns", boost::any(Darabonba_Util::Client::defaultNumber(
                            runtime->maxIdleConns, _maxIdleConns))},
       {"retry", boost::any(map<string, boost::any>(
                     {{"retryable", !runtime->autoretry
                                        ? boost::any()
                                        : boost::any(*runtime->autoretry)},
                      {"maxAttempts",
                       boost::any(Darabonba_Util::Client::defaultNumber(
                           runtime->maxAttempts, make_shared<int>(3)))}}))},
       {"backoff",
        boost::any(map<string, boost::any>(
            {{"policy",
              boost::any(string(Darabonba_Util::Client::defaultString(
                  runtime->backoffPolicy, make_shared<string>("no"))))},
             {"period", boost::any(Darabonba_Util::Client::defaultNumber(
                            runtime->backoffPeriod, make_shared<int>(1)))}}))},
       {"ignoreSSL", !runtime->ignoreSSL ? boost::any()
                                         : boost::any(*runtime->ignoreSSL)}}));
  shared_ptr<Darabonba::Request> _lastRequest;
  shared_ptr<std::exception> _lastException;
  shared_ptr<int> _now = make_shared<int>(0);
  shared_ptr<int> _retryTimes = make_shared<int>(0);
  while (Darabonba::Core::allowRetry(
      make_shared<boost::any>((*runtime_)["retry"]), _retryTimes, _now)) {
    if (*_retryTimes > 0) {
      shared_ptr<int> _backoffTime =
          make_shared<int>(Darabonba::Core::getBackoffTime(
              make_shared<boost::any>((*runtime_)["backoff"]), _retryTimes));
      if (*_backoffTime > 0) {
        Darabonba::Core::sleep(_backoffTime);
      }
    }
    _retryTimes = make_shared<int>(*_retryTimes + 1);
    try {
      shared_ptr<Darabonba::Request> request_ =
          make_shared<Darabonba::Request>();
      shared_ptr<string> accessKeyId =
          make_shared<string>(_credential->getAccessKeyId());
      shared_ptr<string> accessKeySecret =
          make_shared<string>(_credential->getAccessKeySecret());
      shared_ptr<string> token =
          make_shared<string>(_credential->getSecurityToken());
      request_->protocol = *_protocol;
      request_->method = "GET";
      request_->pathname = string("/?cors");
      request_->headers = {
          {"host", Alibabacloud_OSSUtil::Client::getHost(
                       request->bucketName, _regionId, _endpoint, _hostModel)},
          {"date", Darabonba_Util::Client::getDateUTCString()},
          {"user-agent", getUserAgent()}};
      if (!Darabonba_Util::Client::empty(token)) {
        request_->headers.insert(
            pair<string, string>("x-oss-security-token", *token));
      }
      request_->headers.insert(pair<string, string>(
          "authorization",
          Alibabacloud_OSSUtil::Client::getSignature(
              request_, request->bucketName, accessKeyId, accessKeySecret,
              _signatureVersion, _addtionalHeaders)));
      _lastRequest = request_;
      shared_ptr<Darabonba::Response> response_ =
          make_shared<Darabonba::Response>(
              Darabonba::Core::doAction(request_, runtime_));
      shared_ptr<map<string, boost::any>> respMap;
      shared_ptr<string> bodyStr;
      if (Darabonba_Util::Client::is4xx(
              make_shared<int>(response_->statusCode)) ||
          Darabonba_Util::Client::is5xx(
              make_shared<int>(response_->statusCode))) {
        bodyStr = make_shared<string>(
            Darabonba_Util::Client::readAsString(response_->body));
        respMap = make_shared<map<string, boost::any>>(
            Alibabacloud_OSSUtil::Client::getErrMessage(bodyStr));
        BOOST_THROW_EXCEPTION(Darabonba::Error(map<string, boost::any>(
            {{"code", (*respMap)["Code"]},
             {"message", (*respMap)["Message"]},
             {"data", boost::any(map<string, boost::any>(
                          {{"httpCode", boost::any(response_->statusCode)},
                           {"requestId", (*respMap)["RequestId"]},
                           {"hostId", (*respMap)["HostId"]}}))}})));
      }
      bodyStr = make_shared<string>(
          Darabonba_Util::Client::readAsString(response_->body));
      respMap = make_shared<map<string, boost::any>>(
          Darabonba_XML::Client::parseXml(bodyStr, nullptr));
      return GetBucketCORSResponse(Darabonba::Converter::merge(
          map<string, boost::any>(
              {{"CORSConfiguration", (*respMap)["CORSConfiguration"]}}),
          Darabonba::Converter::toGenericMap(response_->headers)));
    } catch (std::exception &e) {
      if (Darabonba::Core::isRetryable(e)) {
        _lastException = make_shared<std::exception>(e);
        continue;
      }
      BOOST_THROW_EXCEPTION(e);
    }
  }
  BOOST_THROW_EXCEPTION(
      Darabonba::UnretryableError(_lastRequest, _lastException));
}

CopyObjectResponse Alibabacloud_OSS::Client::copyObject(
    shared_ptr<CopyObjectRequest> request,
    shared_ptr<Alibabacloud_OSSUtil::RuntimeOptions> runtime) {
  request->validate();
  runtime->validate();
  shared_ptr<map<string, boost::any>> runtime_ = make_shared<
      map<string, boost::any>>(map<string, boost::any>(
      {{"timeouted", boost::any(string("retry"))},
       {"readTimeout", boost::any(Darabonba_Util::Client::defaultNumber(
                           runtime->readTimeout, _readTimeout))},
       {"connectTimeout", boost::any(Darabonba_Util::Client::defaultNumber(
                              runtime->connectTimeout, _connectTimeout))},
       {"localAddr", boost::any(string(Darabonba_Util::Client::defaultString(
                         runtime->localAddr, _localAddr)))},
       {"httpProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                         runtime->httpProxy, _httpProxy)))},
       {"httpsProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                          runtime->httpsProxy, _httpsProxy)))},
       {"noProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                       runtime->noProxy, _noProxy)))},
       {"socks5Proxy", boost::any(string(Darabonba_Util::Client::defaultString(
                           runtime->socks5Proxy, _socks5Proxy)))},
       {"socks5NetWork",
        boost::any(string(Darabonba_Util::Client::defaultString(
            runtime->socks5NetWork, _socks5NetWork)))},
       {"maxIdleConns", boost::any(Darabonba_Util::Client::defaultNumber(
                            runtime->maxIdleConns, _maxIdleConns))},
       {"retry", boost::any(map<string, boost::any>(
                     {{"retryable", !runtime->autoretry
                                        ? boost::any()
                                        : boost::any(*runtime->autoretry)},
                      {"maxAttempts",
                       boost::any(Darabonba_Util::Client::defaultNumber(
                           runtime->maxAttempts, make_shared<int>(3)))}}))},
       {"backoff",
        boost::any(map<string, boost::any>(
            {{"policy",
              boost::any(string(Darabonba_Util::Client::defaultString(
                  runtime->backoffPolicy, make_shared<string>("no"))))},
             {"period", boost::any(Darabonba_Util::Client::defaultNumber(
                            runtime->backoffPeriod, make_shared<int>(1)))}}))},
       {"ignoreSSL", !runtime->ignoreSSL ? boost::any()
                                         : boost::any(*runtime->ignoreSSL)}}));
  shared_ptr<Darabonba::Request> _lastRequest;
  shared_ptr<std::exception> _lastException;
  shared_ptr<int> _now = make_shared<int>(0);
  shared_ptr<int> _retryTimes = make_shared<int>(0);
  while (Darabonba::Core::allowRetry(
      make_shared<boost::any>((*runtime_)["retry"]), _retryTimes, _now)) {
    if (*_retryTimes > 0) {
      shared_ptr<int> _backoffTime =
          make_shared<int>(Darabonba::Core::getBackoffTime(
              make_shared<boost::any>((*runtime_)["backoff"]), _retryTimes));
      if (*_backoffTime > 0) {
        Darabonba::Core::sleep(_backoffTime);
      }
    }
    _retryTimes = make_shared<int>(*_retryTimes + 1);
    try {
      shared_ptr<Darabonba::Request> request_ =
          make_shared<Darabonba::Request>();
      shared_ptr<string> accessKeyId =
          make_shared<string>(_credential->getAccessKeyId());
      shared_ptr<string> accessKeySecret =
          make_shared<string>(_credential->getAccessKeySecret());
      shared_ptr<string> token =
          make_shared<string>(_credential->getSecurityToken());
      request_->protocol = *_protocol;
      request_->method = "PUT";
      request_->pathname = string("/" + *request->destObjectName + "");
      request_->headers = Darabonba::Converter::merge(
          map<string, string>(
              {{"host",
                Alibabacloud_OSSUtil::Client::getHost(
                    request->bucketName, _regionId, _endpoint, _hostModel)},
               {"date", Darabonba_Util::Client::getDateUTCString()},
               {"user-agent", getUserAgent()}}),
          Darabonba_Util::Client::stringifyMapValue(
              make_shared<map<string, boost::any>>(request->header->toMap())));
      if (!Darabonba_Util::Client::empty(token)) {
        request_->headers.insert(
            pair<string, string>("x-oss-security-token", *token));
      }
      request_->headers.insert(pair<string, string>(
          "x-oss-copy-source",
          Alibabacloud_OSSUtil::Client::encode(
              make_shared<string>(request_->headers["x-oss-copy-source"]),
              make_shared<string>("UrlEncode"))));
      request_->headers.insert(pair<string, string>(
          "authorization",
          Alibabacloud_OSSUtil::Client::getSignature(
              request_, request->bucketName, accessKeyId, accessKeySecret,
              _signatureVersion, _addtionalHeaders)));
      _lastRequest = request_;
      shared_ptr<Darabonba::Response> response_ =
          make_shared<Darabonba::Response>(
              Darabonba::Core::doAction(request_, runtime_));
      shared_ptr<map<string, boost::any>> respMap;
      shared_ptr<string> bodyStr;
      if (Darabonba_Util::Client::is4xx(
              make_shared<int>(response_->statusCode)) ||
          Darabonba_Util::Client::is5xx(
              make_shared<int>(response_->statusCode))) {
        bodyStr = make_shared<string>(
            Darabonba_Util::Client::readAsString(response_->body));
        respMap = make_shared<map<string, boost::any>>(
            Alibabacloud_OSSUtil::Client::getErrMessage(bodyStr));
        BOOST_THROW_EXCEPTION(Darabonba::Error(map<string, boost::any>(
            {{"code", (*respMap)["Code"]},
             {"message", (*respMap)["Message"]},
             {"data", boost::any(map<string, boost::any>(
                          {{"httpCode", boost::any(response_->statusCode)},
                           {"requestId", (*respMap)["RequestId"]},
                           {"hostId", (*respMap)["HostId"]}}))}})));
      }
      bodyStr = make_shared<string>(
          Darabonba_Util::Client::readAsString(response_->body));
      respMap = make_shared<map<string, boost::any>>(
          Darabonba_XML::Client::parseXml(bodyStr, nullptr));
      return CopyObjectResponse(Darabonba::Converter::merge(
          map<string, boost::any>(
              {{"CopyObjectResult", (*respMap)["CopyObjectResult"]}}),
          Darabonba::Converter::toGenericMap(response_->headers)));
    } catch (std::exception &e) {
      if (Darabonba::Core::isRetryable(e)) {
        _lastException = make_shared<std::exception>(e);
        continue;
      }
      BOOST_THROW_EXCEPTION(e);
    }
  }
  BOOST_THROW_EXCEPTION(
      Darabonba::UnretryableError(_lastRequest, _lastException));
}

GetObjectTaggingResponse Alibabacloud_OSS::Client::getObjectTagging(
    shared_ptr<GetObjectTaggingRequest> request,
    shared_ptr<Alibabacloud_OSSUtil::RuntimeOptions> runtime) {
  request->validate();
  runtime->validate();
  shared_ptr<map<string, boost::any>> runtime_ = make_shared<
      map<string, boost::any>>(map<string, boost::any>(
      {{"timeouted", boost::any(string("retry"))},
       {"readTimeout", boost::any(Darabonba_Util::Client::defaultNumber(
                           runtime->readTimeout, _readTimeout))},
       {"connectTimeout", boost::any(Darabonba_Util::Client::defaultNumber(
                              runtime->connectTimeout, _connectTimeout))},
       {"localAddr", boost::any(string(Darabonba_Util::Client::defaultString(
                         runtime->localAddr, _localAddr)))},
       {"httpProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                         runtime->httpProxy, _httpProxy)))},
       {"httpsProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                          runtime->httpsProxy, _httpsProxy)))},
       {"noProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                       runtime->noProxy, _noProxy)))},
       {"socks5Proxy", boost::any(string(Darabonba_Util::Client::defaultString(
                           runtime->socks5Proxy, _socks5Proxy)))},
       {"socks5NetWork",
        boost::any(string(Darabonba_Util::Client::defaultString(
            runtime->socks5NetWork, _socks5NetWork)))},
       {"maxIdleConns", boost::any(Darabonba_Util::Client::defaultNumber(
                            runtime->maxIdleConns, _maxIdleConns))},
       {"retry", boost::any(map<string, boost::any>(
                     {{"retryable", !runtime->autoretry
                                        ? boost::any()
                                        : boost::any(*runtime->autoretry)},
                      {"maxAttempts",
                       boost::any(Darabonba_Util::Client::defaultNumber(
                           runtime->maxAttempts, make_shared<int>(3)))}}))},
       {"backoff",
        boost::any(map<string, boost::any>(
            {{"policy",
              boost::any(string(Darabonba_Util::Client::defaultString(
                  runtime->backoffPolicy, make_shared<string>("no"))))},
             {"period", boost::any(Darabonba_Util::Client::defaultNumber(
                            runtime->backoffPeriod, make_shared<int>(1)))}}))},
       {"ignoreSSL", !runtime->ignoreSSL ? boost::any()
                                         : boost::any(*runtime->ignoreSSL)}}));
  shared_ptr<Darabonba::Request> _lastRequest;
  shared_ptr<std::exception> _lastException;
  shared_ptr<int> _now = make_shared<int>(0);
  shared_ptr<int> _retryTimes = make_shared<int>(0);
  while (Darabonba::Core::allowRetry(
      make_shared<boost::any>((*runtime_)["retry"]), _retryTimes, _now)) {
    if (*_retryTimes > 0) {
      shared_ptr<int> _backoffTime =
          make_shared<int>(Darabonba::Core::getBackoffTime(
              make_shared<boost::any>((*runtime_)["backoff"]), _retryTimes));
      if (*_backoffTime > 0) {
        Darabonba::Core::sleep(_backoffTime);
      }
    }
    _retryTimes = make_shared<int>(*_retryTimes + 1);
    try {
      shared_ptr<Darabonba::Request> request_ =
          make_shared<Darabonba::Request>();
      shared_ptr<string> accessKeyId =
          make_shared<string>(_credential->getAccessKeyId());
      shared_ptr<string> accessKeySecret =
          make_shared<string>(_credential->getAccessKeySecret());
      shared_ptr<string> token =
          make_shared<string>(_credential->getSecurityToken());
      request_->protocol = *_protocol;
      request_->method = "GET";
      request_->pathname = string("/" + *request->objectName + "?tagging");
      request_->headers = {
          {"host", Alibabacloud_OSSUtil::Client::getHost(
                       request->bucketName, _regionId, _endpoint, _hostModel)},
          {"date", Darabonba_Util::Client::getDateUTCString()},
          {"user-agent", getUserAgent()}};
      if (!Darabonba_Util::Client::empty(token)) {
        request_->headers.insert(
            pair<string, string>("x-oss-security-token", *token));
      }
      request_->headers.insert(pair<string, string>(
          "authorization",
          Alibabacloud_OSSUtil::Client::getSignature(
              request_, request->bucketName, accessKeyId, accessKeySecret,
              _signatureVersion, _addtionalHeaders)));
      _lastRequest = request_;
      shared_ptr<Darabonba::Response> response_ =
          make_shared<Darabonba::Response>(
              Darabonba::Core::doAction(request_, runtime_));
      shared_ptr<map<string, boost::any>> respMap;
      shared_ptr<string> bodyStr;
      if (Darabonba_Util::Client::is4xx(
              make_shared<int>(response_->statusCode)) ||
          Darabonba_Util::Client::is5xx(
              make_shared<int>(response_->statusCode))) {
        bodyStr = make_shared<string>(
            Darabonba_Util::Client::readAsString(response_->body));
        respMap = make_shared<map<string, boost::any>>(
            Alibabacloud_OSSUtil::Client::getErrMessage(bodyStr));
        BOOST_THROW_EXCEPTION(Darabonba::Error(map<string, boost::any>(
            {{"code", (*respMap)["Code"]},
             {"message", (*respMap)["Message"]},
             {"data", boost::any(map<string, boost::any>(
                          {{"httpCode", boost::any(response_->statusCode)},
                           {"requestId", (*respMap)["RequestId"]},
                           {"hostId", (*respMap)["HostId"]}}))}})));
      }
      bodyStr = make_shared<string>(
          Darabonba_Util::Client::readAsString(response_->body));
      respMap = make_shared<map<string, boost::any>>(
          Darabonba_XML::Client::parseXml(bodyStr, nullptr));
      return GetObjectTaggingResponse(Darabonba::Converter::merge(
          map<string, boost::any>({{"Tagging", (*respMap)["Tagging"]}}),
          Darabonba::Converter::toGenericMap(response_->headers)));
    } catch (std::exception &e) {
      if (Darabonba::Core::isRetryable(e)) {
        _lastException = make_shared<std::exception>(e);
        continue;
      }
      BOOST_THROW_EXCEPTION(e);
    }
  }
  BOOST_THROW_EXCEPTION(
      Darabonba::UnretryableError(_lastRequest, _lastException));
}

DeleteBucketLifecycleResponse Alibabacloud_OSS::Client::deleteBucketLifecycle(
    shared_ptr<DeleteBucketLifecycleRequest> request,
    shared_ptr<Alibabacloud_OSSUtil::RuntimeOptions> runtime) {
  request->validate();
  runtime->validate();
  shared_ptr<map<string, boost::any>> runtime_ = make_shared<
      map<string, boost::any>>(map<string, boost::any>(
      {{"timeouted", boost::any(string("retry"))},
       {"readTimeout", boost::any(Darabonba_Util::Client::defaultNumber(
                           runtime->readTimeout, _readTimeout))},
       {"connectTimeout", boost::any(Darabonba_Util::Client::defaultNumber(
                              runtime->connectTimeout, _connectTimeout))},
       {"localAddr", boost::any(string(Darabonba_Util::Client::defaultString(
                         runtime->localAddr, _localAddr)))},
       {"httpProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                         runtime->httpProxy, _httpProxy)))},
       {"httpsProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                          runtime->httpsProxy, _httpsProxy)))},
       {"noProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                       runtime->noProxy, _noProxy)))},
       {"socks5Proxy", boost::any(string(Darabonba_Util::Client::defaultString(
                           runtime->socks5Proxy, _socks5Proxy)))},
       {"socks5NetWork",
        boost::any(string(Darabonba_Util::Client::defaultString(
            runtime->socks5NetWork, _socks5NetWork)))},
       {"maxIdleConns", boost::any(Darabonba_Util::Client::defaultNumber(
                            runtime->maxIdleConns, _maxIdleConns))},
       {"retry", boost::any(map<string, boost::any>(
                     {{"retryable", !runtime->autoretry
                                        ? boost::any()
                                        : boost::any(*runtime->autoretry)},
                      {"maxAttempts",
                       boost::any(Darabonba_Util::Client::defaultNumber(
                           runtime->maxAttempts, make_shared<int>(3)))}}))},
       {"backoff",
        boost::any(map<string, boost::any>(
            {{"policy",
              boost::any(string(Darabonba_Util::Client::defaultString(
                  runtime->backoffPolicy, make_shared<string>("no"))))},
             {"period", boost::any(Darabonba_Util::Client::defaultNumber(
                            runtime->backoffPeriod, make_shared<int>(1)))}}))},
       {"ignoreSSL", !runtime->ignoreSSL ? boost::any()
                                         : boost::any(*runtime->ignoreSSL)}}));
  shared_ptr<Darabonba::Request> _lastRequest;
  shared_ptr<std::exception> _lastException;
  shared_ptr<int> _now = make_shared<int>(0);
  shared_ptr<int> _retryTimes = make_shared<int>(0);
  while (Darabonba::Core::allowRetry(
      make_shared<boost::any>((*runtime_)["retry"]), _retryTimes, _now)) {
    if (*_retryTimes > 0) {
      shared_ptr<int> _backoffTime =
          make_shared<int>(Darabonba::Core::getBackoffTime(
              make_shared<boost::any>((*runtime_)["backoff"]), _retryTimes));
      if (*_backoffTime > 0) {
        Darabonba::Core::sleep(_backoffTime);
      }
    }
    _retryTimes = make_shared<int>(*_retryTimes + 1);
    try {
      shared_ptr<Darabonba::Request> request_ =
          make_shared<Darabonba::Request>();
      shared_ptr<string> accessKeyId =
          make_shared<string>(_credential->getAccessKeyId());
      shared_ptr<string> accessKeySecret =
          make_shared<string>(_credential->getAccessKeySecret());
      shared_ptr<string> token =
          make_shared<string>(_credential->getSecurityToken());
      request_->protocol = *_protocol;
      request_->method = "DELETE";
      request_->pathname = string("/?lifecycle");
      request_->headers = {
          {"host", Alibabacloud_OSSUtil::Client::getHost(
                       request->bucketName, _regionId, _endpoint, _hostModel)},
          {"date", Darabonba_Util::Client::getDateUTCString()},
          {"user-agent", getUserAgent()}};
      if (!Darabonba_Util::Client::empty(token)) {
        request_->headers.insert(
            pair<string, string>("x-oss-security-token", *token));
      }
      request_->headers.insert(pair<string, string>(
          "authorization",
          Alibabacloud_OSSUtil::Client::getSignature(
              request_, request->bucketName, accessKeyId, accessKeySecret,
              _signatureVersion, _addtionalHeaders)));
      _lastRequest = request_;
      shared_ptr<Darabonba::Response> response_ =
          make_shared<Darabonba::Response>(
              Darabonba::Core::doAction(request_, runtime_));
      shared_ptr<map<string, boost::any>> respMap;
      shared_ptr<string> bodyStr;
      if (Darabonba_Util::Client::is4xx(
              make_shared<int>(response_->statusCode)) ||
          Darabonba_Util::Client::is5xx(
              make_shared<int>(response_->statusCode))) {
        bodyStr = make_shared<string>(
            Darabonba_Util::Client::readAsString(response_->body));
        respMap = make_shared<map<string, boost::any>>(
            Alibabacloud_OSSUtil::Client::getErrMessage(bodyStr));
        BOOST_THROW_EXCEPTION(Darabonba::Error(map<string, boost::any>(
            {{"code", (*respMap)["Code"]},
             {"message", (*respMap)["Message"]},
             {"data", boost::any(map<string, boost::any>(
                          {{"httpCode", boost::any(response_->statusCode)},
                           {"requestId", (*respMap)["RequestId"]},
                           {"hostId", (*respMap)["HostId"]}}))}})));
      }
      return DeleteBucketLifecycleResponse(
          Darabonba::Converter::toGenericMap(Darabonba::Converter::merge(
              map<string, string>(), response_->headers)));
    } catch (std::exception &e) {
      if (Darabonba::Core::isRetryable(e)) {
        _lastException = make_shared<std::exception>(e);
        continue;
      }
      BOOST_THROW_EXCEPTION(e);
    }
  }
  BOOST_THROW_EXCEPTION(
      Darabonba::UnretryableError(_lastRequest, _lastException));
}

DeleteBucketLoggingResponse Alibabacloud_OSS::Client::deleteBucketLogging(
    shared_ptr<DeleteBucketLoggingRequest> request,
    shared_ptr<Alibabacloud_OSSUtil::RuntimeOptions> runtime) {
  request->validate();
  runtime->validate();
  shared_ptr<map<string, boost::any>> runtime_ = make_shared<
      map<string, boost::any>>(map<string, boost::any>(
      {{"timeouted", boost::any(string("retry"))},
       {"readTimeout", boost::any(Darabonba_Util::Client::defaultNumber(
                           runtime->readTimeout, _readTimeout))},
       {"connectTimeout", boost::any(Darabonba_Util::Client::defaultNumber(
                              runtime->connectTimeout, _connectTimeout))},
       {"localAddr", boost::any(string(Darabonba_Util::Client::defaultString(
                         runtime->localAddr, _localAddr)))},
       {"httpProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                         runtime->httpProxy, _httpProxy)))},
       {"httpsProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                          runtime->httpsProxy, _httpsProxy)))},
       {"noProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                       runtime->noProxy, _noProxy)))},
       {"socks5Proxy", boost::any(string(Darabonba_Util::Client::defaultString(
                           runtime->socks5Proxy, _socks5Proxy)))},
       {"socks5NetWork",
        boost::any(string(Darabonba_Util::Client::defaultString(
            runtime->socks5NetWork, _socks5NetWork)))},
       {"maxIdleConns", boost::any(Darabonba_Util::Client::defaultNumber(
                            runtime->maxIdleConns, _maxIdleConns))},
       {"retry", boost::any(map<string, boost::any>(
                     {{"retryable", !runtime->autoretry
                                        ? boost::any()
                                        : boost::any(*runtime->autoretry)},
                      {"maxAttempts",
                       boost::any(Darabonba_Util::Client::defaultNumber(
                           runtime->maxAttempts, make_shared<int>(3)))}}))},
       {"backoff",
        boost::any(map<string, boost::any>(
            {{"policy",
              boost::any(string(Darabonba_Util::Client::defaultString(
                  runtime->backoffPolicy, make_shared<string>("no"))))},
             {"period", boost::any(Darabonba_Util::Client::defaultNumber(
                            runtime->backoffPeriod, make_shared<int>(1)))}}))},
       {"ignoreSSL", !runtime->ignoreSSL ? boost::any()
                                         : boost::any(*runtime->ignoreSSL)}}));
  shared_ptr<Darabonba::Request> _lastRequest;
  shared_ptr<std::exception> _lastException;
  shared_ptr<int> _now = make_shared<int>(0);
  shared_ptr<int> _retryTimes = make_shared<int>(0);
  while (Darabonba::Core::allowRetry(
      make_shared<boost::any>((*runtime_)["retry"]), _retryTimes, _now)) {
    if (*_retryTimes > 0) {
      shared_ptr<int> _backoffTime =
          make_shared<int>(Darabonba::Core::getBackoffTime(
              make_shared<boost::any>((*runtime_)["backoff"]), _retryTimes));
      if (*_backoffTime > 0) {
        Darabonba::Core::sleep(_backoffTime);
      }
    }
    _retryTimes = make_shared<int>(*_retryTimes + 1);
    try {
      shared_ptr<Darabonba::Request> request_ =
          make_shared<Darabonba::Request>();
      shared_ptr<string> accessKeyId =
          make_shared<string>(_credential->getAccessKeyId());
      shared_ptr<string> accessKeySecret =
          make_shared<string>(_credential->getAccessKeySecret());
      shared_ptr<string> token =
          make_shared<string>(_credential->getSecurityToken());
      request_->protocol = *_protocol;
      request_->method = "DELETE";
      request_->pathname = string("/?logging");
      request_->headers = {
          {"host", Alibabacloud_OSSUtil::Client::getHost(
                       request->bucketName, _regionId, _endpoint, _hostModel)},
          {"date", Darabonba_Util::Client::getDateUTCString()},
          {"user-agent", getUserAgent()}};
      if (!Darabonba_Util::Client::empty(token)) {
        request_->headers.insert(
            pair<string, string>("x-oss-security-token", *token));
      }
      request_->headers.insert(pair<string, string>(
          "authorization",
          Alibabacloud_OSSUtil::Client::getSignature(
              request_, request->bucketName, accessKeyId, accessKeySecret,
              _signatureVersion, _addtionalHeaders)));
      _lastRequest = request_;
      shared_ptr<Darabonba::Response> response_ =
          make_shared<Darabonba::Response>(
              Darabonba::Core::doAction(request_, runtime_));
      shared_ptr<map<string, boost::any>> respMap;
      shared_ptr<string> bodyStr;
      if (Darabonba_Util::Client::is4xx(
              make_shared<int>(response_->statusCode)) ||
          Darabonba_Util::Client::is5xx(
              make_shared<int>(response_->statusCode))) {
        bodyStr = make_shared<string>(
            Darabonba_Util::Client::readAsString(response_->body));
        respMap = make_shared<map<string, boost::any>>(
            Alibabacloud_OSSUtil::Client::getErrMessage(bodyStr));
        BOOST_THROW_EXCEPTION(Darabonba::Error(map<string, boost::any>(
            {{"code", (*respMap)["Code"]},
             {"message", (*respMap)["Message"]},
             {"data", boost::any(map<string, boost::any>(
                          {{"httpCode", boost::any(response_->statusCode)},
                           {"requestId", (*respMap)["RequestId"]},
                           {"hostId", (*respMap)["HostId"]}}))}})));
      }
      return DeleteBucketLoggingResponse(
          Darabonba::Converter::toGenericMap(Darabonba::Converter::merge(
              map<string, string>(), response_->headers)));
    } catch (std::exception &e) {
      if (Darabonba::Core::isRetryable(e)) {
        _lastException = make_shared<std::exception>(e);
        continue;
      }
      BOOST_THROW_EXCEPTION(e);
    }
  }
  BOOST_THROW_EXCEPTION(
      Darabonba::UnretryableError(_lastRequest, _lastException));
}

DeleteBucketWebsiteResponse Alibabacloud_OSS::Client::deleteBucketWebsite(
    shared_ptr<DeleteBucketWebsiteRequest> request,
    shared_ptr<Alibabacloud_OSSUtil::RuntimeOptions> runtime) {
  request->validate();
  runtime->validate();
  shared_ptr<map<string, boost::any>> runtime_ = make_shared<
      map<string, boost::any>>(map<string, boost::any>(
      {{"timeouted", boost::any(string("retry"))},
       {"readTimeout", boost::any(Darabonba_Util::Client::defaultNumber(
                           runtime->readTimeout, _readTimeout))},
       {"connectTimeout", boost::any(Darabonba_Util::Client::defaultNumber(
                              runtime->connectTimeout, _connectTimeout))},
       {"localAddr", boost::any(string(Darabonba_Util::Client::defaultString(
                         runtime->localAddr, _localAddr)))},
       {"httpProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                         runtime->httpProxy, _httpProxy)))},
       {"httpsProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                          runtime->httpsProxy, _httpsProxy)))},
       {"noProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                       runtime->noProxy, _noProxy)))},
       {"socks5Proxy", boost::any(string(Darabonba_Util::Client::defaultString(
                           runtime->socks5Proxy, _socks5Proxy)))},
       {"socks5NetWork",
        boost::any(string(Darabonba_Util::Client::defaultString(
            runtime->socks5NetWork, _socks5NetWork)))},
       {"maxIdleConns", boost::any(Darabonba_Util::Client::defaultNumber(
                            runtime->maxIdleConns, _maxIdleConns))},
       {"retry", boost::any(map<string, boost::any>(
                     {{"retryable", !runtime->autoretry
                                        ? boost::any()
                                        : boost::any(*runtime->autoretry)},
                      {"maxAttempts",
                       boost::any(Darabonba_Util::Client::defaultNumber(
                           runtime->maxAttempts, make_shared<int>(3)))}}))},
       {"backoff",
        boost::any(map<string, boost::any>(
            {{"policy",
              boost::any(string(Darabonba_Util::Client::defaultString(
                  runtime->backoffPolicy, make_shared<string>("no"))))},
             {"period", boost::any(Darabonba_Util::Client::defaultNumber(
                            runtime->backoffPeriod, make_shared<int>(1)))}}))},
       {"ignoreSSL", !runtime->ignoreSSL ? boost::any()
                                         : boost::any(*runtime->ignoreSSL)}}));
  shared_ptr<Darabonba::Request> _lastRequest;
  shared_ptr<std::exception> _lastException;
  shared_ptr<int> _now = make_shared<int>(0);
  shared_ptr<int> _retryTimes = make_shared<int>(0);
  while (Darabonba::Core::allowRetry(
      make_shared<boost::any>((*runtime_)["retry"]), _retryTimes, _now)) {
    if (*_retryTimes > 0) {
      shared_ptr<int> _backoffTime =
          make_shared<int>(Darabonba::Core::getBackoffTime(
              make_shared<boost::any>((*runtime_)["backoff"]), _retryTimes));
      if (*_backoffTime > 0) {
        Darabonba::Core::sleep(_backoffTime);
      }
    }
    _retryTimes = make_shared<int>(*_retryTimes + 1);
    try {
      shared_ptr<Darabonba::Request> request_ =
          make_shared<Darabonba::Request>();
      shared_ptr<string> accessKeyId =
          make_shared<string>(_credential->getAccessKeyId());
      shared_ptr<string> accessKeySecret =
          make_shared<string>(_credential->getAccessKeySecret());
      shared_ptr<string> token =
          make_shared<string>(_credential->getSecurityToken());
      request_->protocol = *_protocol;
      request_->method = "DELETE";
      request_->pathname = string("/?website");
      request_->headers = {
          {"host", Alibabacloud_OSSUtil::Client::getHost(
                       request->bucketName, _regionId, _endpoint, _hostModel)},
          {"date", Darabonba_Util::Client::getDateUTCString()},
          {"user-agent", getUserAgent()}};
      if (!Darabonba_Util::Client::empty(token)) {
        request_->headers.insert(
            pair<string, string>("x-oss-security-token", *token));
      }
      request_->headers.insert(pair<string, string>(
          "authorization",
          Alibabacloud_OSSUtil::Client::getSignature(
              request_, request->bucketName, accessKeyId, accessKeySecret,
              _signatureVersion, _addtionalHeaders)));
      _lastRequest = request_;
      shared_ptr<Darabonba::Response> response_ =
          make_shared<Darabonba::Response>(
              Darabonba::Core::doAction(request_, runtime_));
      shared_ptr<map<string, boost::any>> respMap;
      shared_ptr<string> bodyStr;
      if (Darabonba_Util::Client::is4xx(
              make_shared<int>(response_->statusCode)) ||
          Darabonba_Util::Client::is5xx(
              make_shared<int>(response_->statusCode))) {
        bodyStr = make_shared<string>(
            Darabonba_Util::Client::readAsString(response_->body));
        respMap = make_shared<map<string, boost::any>>(
            Alibabacloud_OSSUtil::Client::getErrMessage(bodyStr));
        BOOST_THROW_EXCEPTION(Darabonba::Error(map<string, boost::any>(
            {{"code", (*respMap)["Code"]},
             {"message", (*respMap)["Message"]},
             {"data", boost::any(map<string, boost::any>(
                          {{"httpCode", boost::any(response_->statusCode)},
                           {"requestId", (*respMap)["RequestId"]},
                           {"hostId", (*respMap)["HostId"]}}))}})));
      }
      return DeleteBucketWebsiteResponse(
          Darabonba::Converter::toGenericMap(Darabonba::Converter::merge(
              map<string, string>(), response_->headers)));
    } catch (std::exception &e) {
      if (Darabonba::Core::isRetryable(e)) {
        _lastException = make_shared<std::exception>(e);
        continue;
      }
      BOOST_THROW_EXCEPTION(e);
    }
  }
  BOOST_THROW_EXCEPTION(
      Darabonba::UnretryableError(_lastRequest, _lastException));
}

GetSymlinkResponse Alibabacloud_OSS::Client::getSymlink(
    shared_ptr<GetSymlinkRequest> request,
    shared_ptr<Alibabacloud_OSSUtil::RuntimeOptions> runtime) {
  request->validate();
  runtime->validate();
  shared_ptr<map<string, boost::any>> runtime_ = make_shared<
      map<string, boost::any>>(map<string, boost::any>(
      {{"timeouted", boost::any(string("retry"))},
       {"readTimeout", boost::any(Darabonba_Util::Client::defaultNumber(
                           runtime->readTimeout, _readTimeout))},
       {"connectTimeout", boost::any(Darabonba_Util::Client::defaultNumber(
                              runtime->connectTimeout, _connectTimeout))},
       {"localAddr", boost::any(string(Darabonba_Util::Client::defaultString(
                         runtime->localAddr, _localAddr)))},
       {"httpProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                         runtime->httpProxy, _httpProxy)))},
       {"httpsProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                          runtime->httpsProxy, _httpsProxy)))},
       {"noProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                       runtime->noProxy, _noProxy)))},
       {"socks5Proxy", boost::any(string(Darabonba_Util::Client::defaultString(
                           runtime->socks5Proxy, _socks5Proxy)))},
       {"socks5NetWork",
        boost::any(string(Darabonba_Util::Client::defaultString(
            runtime->socks5NetWork, _socks5NetWork)))},
       {"maxIdleConns", boost::any(Darabonba_Util::Client::defaultNumber(
                            runtime->maxIdleConns, _maxIdleConns))},
       {"retry", boost::any(map<string, boost::any>(
                     {{"retryable", !runtime->autoretry
                                        ? boost::any()
                                        : boost::any(*runtime->autoretry)},
                      {"maxAttempts",
                       boost::any(Darabonba_Util::Client::defaultNumber(
                           runtime->maxAttempts, make_shared<int>(3)))}}))},
       {"backoff",
        boost::any(map<string, boost::any>(
            {{"policy",
              boost::any(string(Darabonba_Util::Client::defaultString(
                  runtime->backoffPolicy, make_shared<string>("no"))))},
             {"period", boost::any(Darabonba_Util::Client::defaultNumber(
                            runtime->backoffPeriod, make_shared<int>(1)))}}))},
       {"ignoreSSL", !runtime->ignoreSSL ? boost::any()
                                         : boost::any(*runtime->ignoreSSL)}}));
  shared_ptr<Darabonba::Request> _lastRequest;
  shared_ptr<std::exception> _lastException;
  shared_ptr<int> _now = make_shared<int>(0);
  shared_ptr<int> _retryTimes = make_shared<int>(0);
  while (Darabonba::Core::allowRetry(
      make_shared<boost::any>((*runtime_)["retry"]), _retryTimes, _now)) {
    if (*_retryTimes > 0) {
      shared_ptr<int> _backoffTime =
          make_shared<int>(Darabonba::Core::getBackoffTime(
              make_shared<boost::any>((*runtime_)["backoff"]), _retryTimes));
      if (*_backoffTime > 0) {
        Darabonba::Core::sleep(_backoffTime);
      }
    }
    _retryTimes = make_shared<int>(*_retryTimes + 1);
    try {
      shared_ptr<Darabonba::Request> request_ =
          make_shared<Darabonba::Request>();
      shared_ptr<string> accessKeyId =
          make_shared<string>(_credential->getAccessKeyId());
      shared_ptr<string> accessKeySecret =
          make_shared<string>(_credential->getAccessKeySecret());
      shared_ptr<string> token =
          make_shared<string>(_credential->getSecurityToken());
      request_->protocol = *_protocol;
      request_->method = "GET";
      request_->pathname = string("/" + *request->objectName + "?symlink");
      request_->headers = {
          {"host", Alibabacloud_OSSUtil::Client::getHost(
                       request->bucketName, _regionId, _endpoint, _hostModel)},
          {"date", Darabonba_Util::Client::getDateUTCString()},
          {"user-agent", getUserAgent()}};
      if (!Darabonba_Util::Client::empty(token)) {
        request_->headers.insert(
            pair<string, string>("x-oss-security-token", *token));
      }
      request_->headers.insert(pair<string, string>(
          "authorization",
          Alibabacloud_OSSUtil::Client::getSignature(
              request_, request->bucketName, accessKeyId, accessKeySecret,
              _signatureVersion, _addtionalHeaders)));
      _lastRequest = request_;
      shared_ptr<Darabonba::Response> response_ =
          make_shared<Darabonba::Response>(
              Darabonba::Core::doAction(request_, runtime_));
      shared_ptr<map<string, boost::any>> respMap;
      shared_ptr<string> bodyStr;
      if (Darabonba_Util::Client::is4xx(
              make_shared<int>(response_->statusCode)) ||
          Darabonba_Util::Client::is5xx(
              make_shared<int>(response_->statusCode))) {
        bodyStr = make_shared<string>(
            Darabonba_Util::Client::readAsString(response_->body));
        respMap = make_shared<map<string, boost::any>>(
            Alibabacloud_OSSUtil::Client::getErrMessage(bodyStr));
        BOOST_THROW_EXCEPTION(Darabonba::Error(map<string, boost::any>(
            {{"code", (*respMap)["Code"]},
             {"message", (*respMap)["Message"]},
             {"data", boost::any(map<string, boost::any>(
                          {{"httpCode", boost::any(response_->statusCode)},
                           {"requestId", (*respMap)["RequestId"]},
                           {"hostId", (*respMap)["HostId"]}}))}})));
      }
      return GetSymlinkResponse(
          Darabonba::Converter::toGenericMap(Darabonba::Converter::merge(
              map<string, string>(), response_->headers)));
    } catch (std::exception &e) {
      if (Darabonba::Core::isRetryable(e)) {
        _lastException = make_shared<std::exception>(e);
        continue;
      }
      BOOST_THROW_EXCEPTION(e);
    }
  }
  BOOST_THROW_EXCEPTION(
      Darabonba::UnretryableError(_lastRequest, _lastException));
}

GetBucketLifecycleResponse Alibabacloud_OSS::Client::getBucketLifecycle(
    shared_ptr<GetBucketLifecycleRequest> request,
    shared_ptr<Alibabacloud_OSSUtil::RuntimeOptions> runtime) {
  request->validate();
  runtime->validate();
  shared_ptr<map<string, boost::any>> runtime_ = make_shared<
      map<string, boost::any>>(map<string, boost::any>(
      {{"timeouted", boost::any(string("retry"))},
       {"readTimeout", boost::any(Darabonba_Util::Client::defaultNumber(
                           runtime->readTimeout, _readTimeout))},
       {"connectTimeout", boost::any(Darabonba_Util::Client::defaultNumber(
                              runtime->connectTimeout, _connectTimeout))},
       {"localAddr", boost::any(string(Darabonba_Util::Client::defaultString(
                         runtime->localAddr, _localAddr)))},
       {"httpProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                         runtime->httpProxy, _httpProxy)))},
       {"httpsProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                          runtime->httpsProxy, _httpsProxy)))},
       {"noProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                       runtime->noProxy, _noProxy)))},
       {"socks5Proxy", boost::any(string(Darabonba_Util::Client::defaultString(
                           runtime->socks5Proxy, _socks5Proxy)))},
       {"socks5NetWork",
        boost::any(string(Darabonba_Util::Client::defaultString(
            runtime->socks5NetWork, _socks5NetWork)))},
       {"maxIdleConns", boost::any(Darabonba_Util::Client::defaultNumber(
                            runtime->maxIdleConns, _maxIdleConns))},
       {"retry", boost::any(map<string, boost::any>(
                     {{"retryable", !runtime->autoretry
                                        ? boost::any()
                                        : boost::any(*runtime->autoretry)},
                      {"maxAttempts",
                       boost::any(Darabonba_Util::Client::defaultNumber(
                           runtime->maxAttempts, make_shared<int>(3)))}}))},
       {"backoff",
        boost::any(map<string, boost::any>(
            {{"policy",
              boost::any(string(Darabonba_Util::Client::defaultString(
                  runtime->backoffPolicy, make_shared<string>("no"))))},
             {"period", boost::any(Darabonba_Util::Client::defaultNumber(
                            runtime->backoffPeriod, make_shared<int>(1)))}}))},
       {"ignoreSSL", !runtime->ignoreSSL ? boost::any()
                                         : boost::any(*runtime->ignoreSSL)}}));
  shared_ptr<Darabonba::Request> _lastRequest;
  shared_ptr<std::exception> _lastException;
  shared_ptr<int> _now = make_shared<int>(0);
  shared_ptr<int> _retryTimes = make_shared<int>(0);
  while (Darabonba::Core::allowRetry(
      make_shared<boost::any>((*runtime_)["retry"]), _retryTimes, _now)) {
    if (*_retryTimes > 0) {
      shared_ptr<int> _backoffTime =
          make_shared<int>(Darabonba::Core::getBackoffTime(
              make_shared<boost::any>((*runtime_)["backoff"]), _retryTimes));
      if (*_backoffTime > 0) {
        Darabonba::Core::sleep(_backoffTime);
      }
    }
    _retryTimes = make_shared<int>(*_retryTimes + 1);
    try {
      shared_ptr<Darabonba::Request> request_ =
          make_shared<Darabonba::Request>();
      shared_ptr<string> accessKeyId =
          make_shared<string>(_credential->getAccessKeyId());
      shared_ptr<string> accessKeySecret =
          make_shared<string>(_credential->getAccessKeySecret());
      shared_ptr<string> token =
          make_shared<string>(_credential->getSecurityToken());
      request_->protocol = *_protocol;
      request_->method = "GET";
      request_->pathname = string("/?lifecycle");
      request_->headers = {
          {"host", Alibabacloud_OSSUtil::Client::getHost(
                       request->bucketName, _regionId, _endpoint, _hostModel)},
          {"date", Darabonba_Util::Client::getDateUTCString()},
          {"user-agent", getUserAgent()}};
      if (!Darabonba_Util::Client::empty(token)) {
        request_->headers.insert(
            pair<string, string>("x-oss-security-token", *token));
      }
      request_->headers.insert(pair<string, string>(
          "authorization",
          Alibabacloud_OSSUtil::Client::getSignature(
              request_, request->bucketName, accessKeyId, accessKeySecret,
              _signatureVersion, _addtionalHeaders)));
      _lastRequest = request_;
      shared_ptr<Darabonba::Response> response_ =
          make_shared<Darabonba::Response>(
              Darabonba::Core::doAction(request_, runtime_));
      shared_ptr<map<string, boost::any>> respMap;
      shared_ptr<string> bodyStr;
      if (Darabonba_Util::Client::is4xx(
              make_shared<int>(response_->statusCode)) ||
          Darabonba_Util::Client::is5xx(
              make_shared<int>(response_->statusCode))) {
        bodyStr = make_shared<string>(
            Darabonba_Util::Client::readAsString(response_->body));
        respMap = make_shared<map<string, boost::any>>(
            Alibabacloud_OSSUtil::Client::getErrMessage(bodyStr));
        BOOST_THROW_EXCEPTION(Darabonba::Error(map<string, boost::any>(
            {{"code", (*respMap)["Code"]},
             {"message", (*respMap)["Message"]},
             {"data", boost::any(map<string, boost::any>(
                          {{"httpCode", boost::any(response_->statusCode)},
                           {"requestId", (*respMap)["RequestId"]},
                           {"hostId", (*respMap)["HostId"]}}))}})));
      }
      bodyStr = make_shared<string>(
          Darabonba_Util::Client::readAsString(response_->body));
      respMap = make_shared<map<string, boost::any>>(
          Darabonba_XML::Client::parseXml(bodyStr, nullptr));
      return GetBucketLifecycleResponse(Darabonba::Converter::merge(
          map<string, boost::any>({{"LifecycleConfiguration",
                                    (*respMap)["LifecycleConfiguration"]}}),
          Darabonba::Converter::toGenericMap(response_->headers)));
    } catch (std::exception &e) {
      if (Darabonba::Core::isRetryable(e)) {
        _lastException = make_shared<std::exception>(e);
        continue;
      }
      BOOST_THROW_EXCEPTION(e);
    }
  }
  BOOST_THROW_EXCEPTION(
      Darabonba::UnretryableError(_lastRequest, _lastException));
}

PutSymlinkResponse Alibabacloud_OSS::Client::putSymlink(
    shared_ptr<PutSymlinkRequest> request,
    shared_ptr<Alibabacloud_OSSUtil::RuntimeOptions> runtime) {
  request->validate();
  runtime->validate();
  shared_ptr<map<string, boost::any>> runtime_ = make_shared<
      map<string, boost::any>>(map<string, boost::any>(
      {{"timeouted", boost::any(string("retry"))},
       {"readTimeout", boost::any(Darabonba_Util::Client::defaultNumber(
                           runtime->readTimeout, _readTimeout))},
       {"connectTimeout", boost::any(Darabonba_Util::Client::defaultNumber(
                              runtime->connectTimeout, _connectTimeout))},
       {"localAddr", boost::any(string(Darabonba_Util::Client::defaultString(
                         runtime->localAddr, _localAddr)))},
       {"httpProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                         runtime->httpProxy, _httpProxy)))},
       {"httpsProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                          runtime->httpsProxy, _httpsProxy)))},
       {"noProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                       runtime->noProxy, _noProxy)))},
       {"socks5Proxy", boost::any(string(Darabonba_Util::Client::defaultString(
                           runtime->socks5Proxy, _socks5Proxy)))},
       {"socks5NetWork",
        boost::any(string(Darabonba_Util::Client::defaultString(
            runtime->socks5NetWork, _socks5NetWork)))},
       {"maxIdleConns", boost::any(Darabonba_Util::Client::defaultNumber(
                            runtime->maxIdleConns, _maxIdleConns))},
       {"retry", boost::any(map<string, boost::any>(
                     {{"retryable", !runtime->autoretry
                                        ? boost::any()
                                        : boost::any(*runtime->autoretry)},
                      {"maxAttempts",
                       boost::any(Darabonba_Util::Client::defaultNumber(
                           runtime->maxAttempts, make_shared<int>(3)))}}))},
       {"backoff",
        boost::any(map<string, boost::any>(
            {{"policy",
              boost::any(string(Darabonba_Util::Client::defaultString(
                  runtime->backoffPolicy, make_shared<string>("no"))))},
             {"period", boost::any(Darabonba_Util::Client::defaultNumber(
                            runtime->backoffPeriod, make_shared<int>(1)))}}))},
       {"ignoreSSL", !runtime->ignoreSSL ? boost::any()
                                         : boost::any(*runtime->ignoreSSL)}}));
  shared_ptr<Darabonba::Request> _lastRequest;
  shared_ptr<std::exception> _lastException;
  shared_ptr<int> _now = make_shared<int>(0);
  shared_ptr<int> _retryTimes = make_shared<int>(0);
  while (Darabonba::Core::allowRetry(
      make_shared<boost::any>((*runtime_)["retry"]), _retryTimes, _now)) {
    if (*_retryTimes > 0) {
      shared_ptr<int> _backoffTime =
          make_shared<int>(Darabonba::Core::getBackoffTime(
              make_shared<boost::any>((*runtime_)["backoff"]), _retryTimes));
      if (*_backoffTime > 0) {
        Darabonba::Core::sleep(_backoffTime);
      }
    }
    _retryTimes = make_shared<int>(*_retryTimes + 1);
    try {
      shared_ptr<Darabonba::Request> request_ =
          make_shared<Darabonba::Request>();
      shared_ptr<string> accessKeyId =
          make_shared<string>(_credential->getAccessKeyId());
      shared_ptr<string> accessKeySecret =
          make_shared<string>(_credential->getAccessKeySecret());
      shared_ptr<string> token =
          make_shared<string>(_credential->getSecurityToken());
      request_->protocol = *_protocol;
      request_->method = "PUT";
      request_->pathname = string("/" + *request->objectName + "?symlink");
      request_->headers = Darabonba::Converter::merge(
          map<string, string>(
              {{"host",
                Alibabacloud_OSSUtil::Client::getHost(
                    request->bucketName, _regionId, _endpoint, _hostModel)},
               {"date", Darabonba_Util::Client::getDateUTCString()},
               {"user-agent", getUserAgent()}}),
          Darabonba_Util::Client::stringifyMapValue(
              make_shared<map<string, boost::any>>(request->header->toMap())));
      if (!Darabonba_Util::Client::empty(token)) {
        request_->headers.insert(
            pair<string, string>("x-oss-security-token", *token));
      }
      request_->headers.insert(pair<string, string>(
          "authorization",
          Alibabacloud_OSSUtil::Client::getSignature(
              request_, request->bucketName, accessKeyId, accessKeySecret,
              _signatureVersion, _addtionalHeaders)));
      _lastRequest = request_;
      shared_ptr<Darabonba::Response> response_ =
          make_shared<Darabonba::Response>(
              Darabonba::Core::doAction(request_, runtime_));
      shared_ptr<map<string, boost::any>> respMap;
      shared_ptr<string> bodyStr;
      if (Darabonba_Util::Client::is4xx(
              make_shared<int>(response_->statusCode)) ||
          Darabonba_Util::Client::is5xx(
              make_shared<int>(response_->statusCode))) {
        bodyStr = make_shared<string>(
            Darabonba_Util::Client::readAsString(response_->body));
        respMap = make_shared<map<string, boost::any>>(
            Alibabacloud_OSSUtil::Client::getErrMessage(bodyStr));
        BOOST_THROW_EXCEPTION(Darabonba::Error(map<string, boost::any>(
            {{"code", (*respMap)["Code"]},
             {"message", (*respMap)["Message"]},
             {"data", boost::any(map<string, boost::any>(
                          {{"httpCode", boost::any(response_->statusCode)},
                           {"requestId", (*respMap)["RequestId"]},
                           {"hostId", (*respMap)["HostId"]}}))}})));
      }
      return PutSymlinkResponse(
          Darabonba::Converter::toGenericMap(Darabonba::Converter::merge(
              map<string, string>(), response_->headers)));
    } catch (std::exception &e) {
      if (Darabonba::Core::isRetryable(e)) {
        _lastException = make_shared<std::exception>(e);
        continue;
      }
      BOOST_THROW_EXCEPTION(e);
    }
  }
  BOOST_THROW_EXCEPTION(
      Darabonba::UnretryableError(_lastRequest, _lastException));
}

GetBucketRefererResponse Alibabacloud_OSS::Client::getBucketReferer(
    shared_ptr<GetBucketRefererRequest> request,
    shared_ptr<Alibabacloud_OSSUtil::RuntimeOptions> runtime) {
  request->validate();
  runtime->validate();
  shared_ptr<map<string, boost::any>> runtime_ = make_shared<
      map<string, boost::any>>(map<string, boost::any>(
      {{"timeouted", boost::any(string("retry"))},
       {"readTimeout", boost::any(Darabonba_Util::Client::defaultNumber(
                           runtime->readTimeout, _readTimeout))},
       {"connectTimeout", boost::any(Darabonba_Util::Client::defaultNumber(
                              runtime->connectTimeout, _connectTimeout))},
       {"localAddr", boost::any(string(Darabonba_Util::Client::defaultString(
                         runtime->localAddr, _localAddr)))},
       {"httpProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                         runtime->httpProxy, _httpProxy)))},
       {"httpsProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                          runtime->httpsProxy, _httpsProxy)))},
       {"noProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                       runtime->noProxy, _noProxy)))},
       {"socks5Proxy", boost::any(string(Darabonba_Util::Client::defaultString(
                           runtime->socks5Proxy, _socks5Proxy)))},
       {"socks5NetWork",
        boost::any(string(Darabonba_Util::Client::defaultString(
            runtime->socks5NetWork, _socks5NetWork)))},
       {"maxIdleConns", boost::any(Darabonba_Util::Client::defaultNumber(
                            runtime->maxIdleConns, _maxIdleConns))},
       {"retry", boost::any(map<string, boost::any>(
                     {{"retryable", !runtime->autoretry
                                        ? boost::any()
                                        : boost::any(*runtime->autoretry)},
                      {"maxAttempts",
                       boost::any(Darabonba_Util::Client::defaultNumber(
                           runtime->maxAttempts, make_shared<int>(3)))}}))},
       {"backoff",
        boost::any(map<string, boost::any>(
            {{"policy",
              boost::any(string(Darabonba_Util::Client::defaultString(
                  runtime->backoffPolicy, make_shared<string>("no"))))},
             {"period", boost::any(Darabonba_Util::Client::defaultNumber(
                            runtime->backoffPeriod, make_shared<int>(1)))}}))},
       {"ignoreSSL", !runtime->ignoreSSL ? boost::any()
                                         : boost::any(*runtime->ignoreSSL)}}));
  shared_ptr<Darabonba::Request> _lastRequest;
  shared_ptr<std::exception> _lastException;
  shared_ptr<int> _now = make_shared<int>(0);
  shared_ptr<int> _retryTimes = make_shared<int>(0);
  while (Darabonba::Core::allowRetry(
      make_shared<boost::any>((*runtime_)["retry"]), _retryTimes, _now)) {
    if (*_retryTimes > 0) {
      shared_ptr<int> _backoffTime =
          make_shared<int>(Darabonba::Core::getBackoffTime(
              make_shared<boost::any>((*runtime_)["backoff"]), _retryTimes));
      if (*_backoffTime > 0) {
        Darabonba::Core::sleep(_backoffTime);
      }
    }
    _retryTimes = make_shared<int>(*_retryTimes + 1);
    try {
      shared_ptr<Darabonba::Request> request_ =
          make_shared<Darabonba::Request>();
      shared_ptr<string> accessKeyId =
          make_shared<string>(_credential->getAccessKeyId());
      shared_ptr<string> accessKeySecret =
          make_shared<string>(_credential->getAccessKeySecret());
      shared_ptr<string> token =
          make_shared<string>(_credential->getSecurityToken());
      request_->protocol = *_protocol;
      request_->method = "GET";
      request_->pathname = string("/?referer");
      request_->headers = {
          {"host", Alibabacloud_OSSUtil::Client::getHost(
                       request->bucketName, _regionId, _endpoint, _hostModel)},
          {"date", Darabonba_Util::Client::getDateUTCString()},
          {"user-agent", getUserAgent()}};
      if (!Darabonba_Util::Client::empty(token)) {
        request_->headers.insert(
            pair<string, string>("x-oss-security-token", *token));
      }
      request_->headers.insert(pair<string, string>(
          "authorization",
          Alibabacloud_OSSUtil::Client::getSignature(
              request_, request->bucketName, accessKeyId, accessKeySecret,
              _signatureVersion, _addtionalHeaders)));
      _lastRequest = request_;
      shared_ptr<Darabonba::Response> response_ =
          make_shared<Darabonba::Response>(
              Darabonba::Core::doAction(request_, runtime_));
      shared_ptr<map<string, boost::any>> respMap;
      shared_ptr<string> bodyStr;
      if (Darabonba_Util::Client::is4xx(
              make_shared<int>(response_->statusCode)) ||
          Darabonba_Util::Client::is5xx(
              make_shared<int>(response_->statusCode))) {
        bodyStr = make_shared<string>(
            Darabonba_Util::Client::readAsString(response_->body));
        respMap = make_shared<map<string, boost::any>>(
            Alibabacloud_OSSUtil::Client::getErrMessage(bodyStr));
        BOOST_THROW_EXCEPTION(Darabonba::Error(map<string, boost::any>(
            {{"code", (*respMap)["Code"]},
             {"message", (*respMap)["Message"]},
             {"data", boost::any(map<string, boost::any>(
                          {{"httpCode", boost::any(response_->statusCode)},
                           {"requestId", (*respMap)["RequestId"]},
                           {"hostId", (*respMap)["HostId"]}}))}})));
      }
      bodyStr = make_shared<string>(
          Darabonba_Util::Client::readAsString(response_->body));
      respMap = make_shared<map<string, boost::any>>(
          Darabonba_XML::Client::parseXml(bodyStr, nullptr));
      return GetBucketRefererResponse(Darabonba::Converter::merge(
          map<string, boost::any>(
              {{"RefererConfiguration", (*respMap)["RefererConfiguration"]}}),
          Darabonba::Converter::toGenericMap(response_->headers)));
    } catch (std::exception &e) {
      if (Darabonba::Core::isRetryable(e)) {
        _lastException = make_shared<std::exception>(e);
        continue;
      }
      BOOST_THROW_EXCEPTION(e);
    }
  }
  BOOST_THROW_EXCEPTION(
      Darabonba::UnretryableError(_lastRequest, _lastException));
}

CallbackResponse Alibabacloud_OSS::Client::callback(
    shared_ptr<CallbackRequest> request,
    shared_ptr<Alibabacloud_OSSUtil::RuntimeOptions> runtime) {
  request->validate();
  runtime->validate();
  shared_ptr<map<string, boost::any>> runtime_ = make_shared<
      map<string, boost::any>>(map<string, boost::any>(
      {{"timeouted", boost::any(string("retry"))},
       {"readTimeout", boost::any(Darabonba_Util::Client::defaultNumber(
                           runtime->readTimeout, _readTimeout))},
       {"connectTimeout", boost::any(Darabonba_Util::Client::defaultNumber(
                              runtime->connectTimeout, _connectTimeout))},
       {"localAddr", boost::any(string(Darabonba_Util::Client::defaultString(
                         runtime->localAddr, _localAddr)))},
       {"httpProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                         runtime->httpProxy, _httpProxy)))},
       {"httpsProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                          runtime->httpsProxy, _httpsProxy)))},
       {"noProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                       runtime->noProxy, _noProxy)))},
       {"socks5Proxy", boost::any(string(Darabonba_Util::Client::defaultString(
                           runtime->socks5Proxy, _socks5Proxy)))},
       {"socks5NetWork",
        boost::any(string(Darabonba_Util::Client::defaultString(
            runtime->socks5NetWork, _socks5NetWork)))},
       {"maxIdleConns", boost::any(Darabonba_Util::Client::defaultNumber(
                            runtime->maxIdleConns, _maxIdleConns))},
       {"retry", boost::any(map<string, boost::any>(
                     {{"retryable", !runtime->autoretry
                                        ? boost::any()
                                        : boost::any(*runtime->autoretry)},
                      {"maxAttempts",
                       boost::any(Darabonba_Util::Client::defaultNumber(
                           runtime->maxAttempts, make_shared<int>(3)))}}))},
       {"backoff",
        boost::any(map<string, boost::any>(
            {{"policy",
              boost::any(string(Darabonba_Util::Client::defaultString(
                  runtime->backoffPolicy, make_shared<string>("no"))))},
             {"period", boost::any(Darabonba_Util::Client::defaultNumber(
                            runtime->backoffPeriod, make_shared<int>(1)))}}))},
       {"ignoreSSL", !runtime->ignoreSSL ? boost::any()
                                         : boost::any(*runtime->ignoreSSL)}}));
  shared_ptr<Darabonba::Request> _lastRequest;
  shared_ptr<std::exception> _lastException;
  shared_ptr<int> _now = make_shared<int>(0);
  shared_ptr<int> _retryTimes = make_shared<int>(0);
  while (Darabonba::Core::allowRetry(
      make_shared<boost::any>((*runtime_)["retry"]), _retryTimes, _now)) {
    if (*_retryTimes > 0) {
      shared_ptr<int> _backoffTime =
          make_shared<int>(Darabonba::Core::getBackoffTime(
              make_shared<boost::any>((*runtime_)["backoff"]), _retryTimes));
      if (*_backoffTime > 0) {
        Darabonba::Core::sleep(_backoffTime);
      }
    }
    _retryTimes = make_shared<int>(*_retryTimes + 1);
    try {
      shared_ptr<Darabonba::Request> request_ =
          make_shared<Darabonba::Request>();
      shared_ptr<string> accessKeyId =
          make_shared<string>(_credential->getAccessKeyId());
      shared_ptr<string> accessKeySecret =
          make_shared<string>(_credential->getAccessKeySecret());
      shared_ptr<string> token =
          make_shared<string>(_credential->getSecurityToken());
      request_->protocol = *_protocol;
      request_->method = "GET";
      request_->pathname = string("/");
      request_->headers = {
          {"host", Alibabacloud_OSSUtil::Client::getHost(
                       request->bucketName, _regionId, _endpoint, _hostModel)},
          {"date", Darabonba_Util::Client::getDateUTCString()},
          {"user-agent", getUserAgent()}};
      if (!Darabonba_Util::Client::empty(token)) {
        request_->headers.insert(
            pair<string, string>("x-oss-security-token", *token));
      }
      request_->headers.insert(pair<string, string>(
          "authorization",
          Alibabacloud_OSSUtil::Client::getSignature(
              request_, request->bucketName, accessKeyId, accessKeySecret,
              _signatureVersion, _addtionalHeaders)));
      _lastRequest = request_;
      shared_ptr<Darabonba::Response> response_ =
          make_shared<Darabonba::Response>(
              Darabonba::Core::doAction(request_, runtime_));
      shared_ptr<map<string, boost::any>> respMap;
      shared_ptr<string> bodyStr;
      if (Darabonba_Util::Client::is4xx(
              make_shared<int>(response_->statusCode)) ||
          Darabonba_Util::Client::is5xx(
              make_shared<int>(response_->statusCode))) {
        bodyStr = make_shared<string>(
            Darabonba_Util::Client::readAsString(response_->body));
        respMap = make_shared<map<string, boost::any>>(
            Alibabacloud_OSSUtil::Client::getErrMessage(bodyStr));
        BOOST_THROW_EXCEPTION(Darabonba::Error(map<string, boost::any>(
            {{"code", (*respMap)["Code"]},
             {"message", (*respMap)["Message"]},
             {"data", boost::any(map<string, boost::any>(
                          {{"httpCode", boost::any(response_->statusCode)},
                           {"requestId", (*respMap)["RequestId"]},
                           {"hostId", (*respMap)["HostId"]}}))}})));
      }
      return CallbackResponse(
          Darabonba::Converter::toGenericMap(Darabonba::Converter::merge(
              map<string, string>(), response_->headers)));
    } catch (std::exception &e) {
      if (Darabonba::Core::isRetryable(e)) {
        _lastException = make_shared<std::exception>(e);
        continue;
      }
      BOOST_THROW_EXCEPTION(e);
    }
  }
  BOOST_THROW_EXCEPTION(
      Darabonba::UnretryableError(_lastRequest, _lastException));
}

GetBucketLoggingResponse Alibabacloud_OSS::Client::getBucketLogging(
    shared_ptr<GetBucketLoggingRequest> request,
    shared_ptr<Alibabacloud_OSSUtil::RuntimeOptions> runtime) {
  request->validate();
  runtime->validate();
  shared_ptr<map<string, boost::any>> runtime_ = make_shared<
      map<string, boost::any>>(map<string, boost::any>(
      {{"timeouted", boost::any(string("retry"))},
       {"readTimeout", boost::any(Darabonba_Util::Client::defaultNumber(
                           runtime->readTimeout, _readTimeout))},
       {"connectTimeout", boost::any(Darabonba_Util::Client::defaultNumber(
                              runtime->connectTimeout, _connectTimeout))},
       {"localAddr", boost::any(string(Darabonba_Util::Client::defaultString(
                         runtime->localAddr, _localAddr)))},
       {"httpProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                         runtime->httpProxy, _httpProxy)))},
       {"httpsProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                          runtime->httpsProxy, _httpsProxy)))},
       {"noProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                       runtime->noProxy, _noProxy)))},
       {"socks5Proxy", boost::any(string(Darabonba_Util::Client::defaultString(
                           runtime->socks5Proxy, _socks5Proxy)))},
       {"socks5NetWork",
        boost::any(string(Darabonba_Util::Client::defaultString(
            runtime->socks5NetWork, _socks5NetWork)))},
       {"maxIdleConns", boost::any(Darabonba_Util::Client::defaultNumber(
                            runtime->maxIdleConns, _maxIdleConns))},
       {"retry", boost::any(map<string, boost::any>(
                     {{"retryable", !runtime->autoretry
                                        ? boost::any()
                                        : boost::any(*runtime->autoretry)},
                      {"maxAttempts",
                       boost::any(Darabonba_Util::Client::defaultNumber(
                           runtime->maxAttempts, make_shared<int>(3)))}}))},
       {"backoff",
        boost::any(map<string, boost::any>(
            {{"policy",
              boost::any(string(Darabonba_Util::Client::defaultString(
                  runtime->backoffPolicy, make_shared<string>("no"))))},
             {"period", boost::any(Darabonba_Util::Client::defaultNumber(
                            runtime->backoffPeriod, make_shared<int>(1)))}}))},
       {"ignoreSSL", !runtime->ignoreSSL ? boost::any()
                                         : boost::any(*runtime->ignoreSSL)}}));
  shared_ptr<Darabonba::Request> _lastRequest;
  shared_ptr<std::exception> _lastException;
  shared_ptr<int> _now = make_shared<int>(0);
  shared_ptr<int> _retryTimes = make_shared<int>(0);
  while (Darabonba::Core::allowRetry(
      make_shared<boost::any>((*runtime_)["retry"]), _retryTimes, _now)) {
    if (*_retryTimes > 0) {
      shared_ptr<int> _backoffTime =
          make_shared<int>(Darabonba::Core::getBackoffTime(
              make_shared<boost::any>((*runtime_)["backoff"]), _retryTimes));
      if (*_backoffTime > 0) {
        Darabonba::Core::sleep(_backoffTime);
      }
    }
    _retryTimes = make_shared<int>(*_retryTimes + 1);
    try {
      shared_ptr<Darabonba::Request> request_ =
          make_shared<Darabonba::Request>();
      shared_ptr<string> accessKeyId =
          make_shared<string>(_credential->getAccessKeyId());
      shared_ptr<string> accessKeySecret =
          make_shared<string>(_credential->getAccessKeySecret());
      shared_ptr<string> token =
          make_shared<string>(_credential->getSecurityToken());
      request_->protocol = *_protocol;
      request_->method = "GET";
      request_->pathname = string("/?logging");
      request_->headers = {
          {"host", Alibabacloud_OSSUtil::Client::getHost(
                       request->bucketName, _regionId, _endpoint, _hostModel)},
          {"date", Darabonba_Util::Client::getDateUTCString()},
          {"user-agent", getUserAgent()}};
      if (!Darabonba_Util::Client::empty(token)) {
        request_->headers.insert(
            pair<string, string>("x-oss-security-token", *token));
      }
      request_->headers.insert(pair<string, string>(
          "authorization",
          Alibabacloud_OSSUtil::Client::getSignature(
              request_, request->bucketName, accessKeyId, accessKeySecret,
              _signatureVersion, _addtionalHeaders)));
      _lastRequest = request_;
      shared_ptr<Darabonba::Response> response_ =
          make_shared<Darabonba::Response>(
              Darabonba::Core::doAction(request_, runtime_));
      shared_ptr<map<string, boost::any>> respMap;
      shared_ptr<string> bodyStr;
      if (Darabonba_Util::Client::is4xx(
              make_shared<int>(response_->statusCode)) ||
          Darabonba_Util::Client::is5xx(
              make_shared<int>(response_->statusCode))) {
        bodyStr = make_shared<string>(
            Darabonba_Util::Client::readAsString(response_->body));
        respMap = make_shared<map<string, boost::any>>(
            Alibabacloud_OSSUtil::Client::getErrMessage(bodyStr));
        BOOST_THROW_EXCEPTION(Darabonba::Error(map<string, boost::any>(
            {{"code", (*respMap)["Code"]},
             {"message", (*respMap)["Message"]},
             {"data", boost::any(map<string, boost::any>(
                          {{"httpCode", boost::any(response_->statusCode)},
                           {"requestId", (*respMap)["RequestId"]},
                           {"hostId", (*respMap)["HostId"]}}))}})));
      }
      bodyStr = make_shared<string>(
          Darabonba_Util::Client::readAsString(response_->body));
      respMap = make_shared<map<string, boost::any>>(
          Darabonba_XML::Client::parseXml(bodyStr, nullptr));
      return GetBucketLoggingResponse(Darabonba::Converter::merge(
          map<string, boost::any>(
              {{"BucketLoggingStatus", (*respMap)["BucketLoggingStatus"]}}),
          Darabonba::Converter::toGenericMap(response_->headers)));
    } catch (std::exception &e) {
      if (Darabonba::Core::isRetryable(e)) {
        _lastException = make_shared<std::exception>(e);
        continue;
      }
      BOOST_THROW_EXCEPTION(e);
    }
  }
  BOOST_THROW_EXCEPTION(
      Darabonba::UnretryableError(_lastRequest, _lastException));
}

PutObjectAclResponse Alibabacloud_OSS::Client::putObjectAcl(
    shared_ptr<PutObjectAclRequest> request,
    shared_ptr<Alibabacloud_OSSUtil::RuntimeOptions> runtime) {
  request->validate();
  runtime->validate();
  shared_ptr<map<string, boost::any>> runtime_ = make_shared<
      map<string, boost::any>>(map<string, boost::any>(
      {{"timeouted", boost::any(string("retry"))},
       {"readTimeout", boost::any(Darabonba_Util::Client::defaultNumber(
                           runtime->readTimeout, _readTimeout))},
       {"connectTimeout", boost::any(Darabonba_Util::Client::defaultNumber(
                              runtime->connectTimeout, _connectTimeout))},
       {"localAddr", boost::any(string(Darabonba_Util::Client::defaultString(
                         runtime->localAddr, _localAddr)))},
       {"httpProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                         runtime->httpProxy, _httpProxy)))},
       {"httpsProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                          runtime->httpsProxy, _httpsProxy)))},
       {"noProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                       runtime->noProxy, _noProxy)))},
       {"socks5Proxy", boost::any(string(Darabonba_Util::Client::defaultString(
                           runtime->socks5Proxy, _socks5Proxy)))},
       {"socks5NetWork",
        boost::any(string(Darabonba_Util::Client::defaultString(
            runtime->socks5NetWork, _socks5NetWork)))},
       {"maxIdleConns", boost::any(Darabonba_Util::Client::defaultNumber(
                            runtime->maxIdleConns, _maxIdleConns))},
       {"retry", boost::any(map<string, boost::any>(
                     {{"retryable", !runtime->autoretry
                                        ? boost::any()
                                        : boost::any(*runtime->autoretry)},
                      {"maxAttempts",
                       boost::any(Darabonba_Util::Client::defaultNumber(
                           runtime->maxAttempts, make_shared<int>(3)))}}))},
       {"backoff",
        boost::any(map<string, boost::any>(
            {{"policy",
              boost::any(string(Darabonba_Util::Client::defaultString(
                  runtime->backoffPolicy, make_shared<string>("no"))))},
             {"period", boost::any(Darabonba_Util::Client::defaultNumber(
                            runtime->backoffPeriod, make_shared<int>(1)))}}))},
       {"ignoreSSL", !runtime->ignoreSSL ? boost::any()
                                         : boost::any(*runtime->ignoreSSL)}}));
  shared_ptr<Darabonba::Request> _lastRequest;
  shared_ptr<std::exception> _lastException;
  shared_ptr<int> _now = make_shared<int>(0);
  shared_ptr<int> _retryTimes = make_shared<int>(0);
  while (Darabonba::Core::allowRetry(
      make_shared<boost::any>((*runtime_)["retry"]), _retryTimes, _now)) {
    if (*_retryTimes > 0) {
      shared_ptr<int> _backoffTime =
          make_shared<int>(Darabonba::Core::getBackoffTime(
              make_shared<boost::any>((*runtime_)["backoff"]), _retryTimes));
      if (*_backoffTime > 0) {
        Darabonba::Core::sleep(_backoffTime);
      }
    }
    _retryTimes = make_shared<int>(*_retryTimes + 1);
    try {
      shared_ptr<Darabonba::Request> request_ =
          make_shared<Darabonba::Request>();
      shared_ptr<string> accessKeyId =
          make_shared<string>(_credential->getAccessKeyId());
      shared_ptr<string> accessKeySecret =
          make_shared<string>(_credential->getAccessKeySecret());
      shared_ptr<string> token =
          make_shared<string>(_credential->getSecurityToken());
      request_->protocol = *_protocol;
      request_->method = "PUT";
      request_->pathname = string("/" + *request->objectName + "?acl");
      request_->headers = Darabonba::Converter::merge(
          map<string, string>(
              {{"host",
                Alibabacloud_OSSUtil::Client::getHost(
                    request->bucketName, _regionId, _endpoint, _hostModel)},
               {"date", Darabonba_Util::Client::getDateUTCString()},
               {"user-agent", getUserAgent()}}),
          Darabonba_Util::Client::stringifyMapValue(
              make_shared<map<string, boost::any>>(request->header->toMap())));
      if (!Darabonba_Util::Client::empty(token)) {
        request_->headers.insert(
            pair<string, string>("x-oss-security-token", *token));
      }
      request_->headers.insert(pair<string, string>(
          "authorization",
          Alibabacloud_OSSUtil::Client::getSignature(
              request_, request->bucketName, accessKeyId, accessKeySecret,
              _signatureVersion, _addtionalHeaders)));
      _lastRequest = request_;
      shared_ptr<Darabonba::Response> response_ =
          make_shared<Darabonba::Response>(
              Darabonba::Core::doAction(request_, runtime_));
      shared_ptr<map<string, boost::any>> respMap;
      shared_ptr<string> bodyStr;
      if (Darabonba_Util::Client::is4xx(
              make_shared<int>(response_->statusCode)) ||
          Darabonba_Util::Client::is5xx(
              make_shared<int>(response_->statusCode))) {
        bodyStr = make_shared<string>(
            Darabonba_Util::Client::readAsString(response_->body));
        respMap = make_shared<map<string, boost::any>>(
            Alibabacloud_OSSUtil::Client::getErrMessage(bodyStr));
        BOOST_THROW_EXCEPTION(Darabonba::Error(map<string, boost::any>(
            {{"code", (*respMap)["Code"]},
             {"message", (*respMap)["Message"]},
             {"data", boost::any(map<string, boost::any>(
                          {{"httpCode", boost::any(response_->statusCode)},
                           {"requestId", (*respMap)["RequestId"]},
                           {"hostId", (*respMap)["HostId"]}}))}})));
      }
      return PutObjectAclResponse(
          Darabonba::Converter::toGenericMap(Darabonba::Converter::merge(
              map<string, string>(), response_->headers)));
    } catch (std::exception &e) {
      if (Darabonba::Core::isRetryable(e)) {
        _lastException = make_shared<std::exception>(e);
        continue;
      }
      BOOST_THROW_EXCEPTION(e);
    }
  }
  BOOST_THROW_EXCEPTION(
      Darabonba::UnretryableError(_lastRequest, _lastException));
}

GetBucketInfoResponse Alibabacloud_OSS::Client::getBucketInfo(
    shared_ptr<GetBucketInfoRequest> request,
    shared_ptr<Alibabacloud_OSSUtil::RuntimeOptions> runtime) {
  request->validate();
  runtime->validate();
  shared_ptr<map<string, boost::any>> runtime_ = make_shared<
      map<string, boost::any>>(map<string, boost::any>(
      {{"timeouted", boost::any(string("retry"))},
       {"readTimeout", boost::any(Darabonba_Util::Client::defaultNumber(
                           runtime->readTimeout, _readTimeout))},
       {"connectTimeout", boost::any(Darabonba_Util::Client::defaultNumber(
                              runtime->connectTimeout, _connectTimeout))},
       {"localAddr", boost::any(string(Darabonba_Util::Client::defaultString(
                         runtime->localAddr, _localAddr)))},
       {"httpProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                         runtime->httpProxy, _httpProxy)))},
       {"httpsProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                          runtime->httpsProxy, _httpsProxy)))},
       {"noProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                       runtime->noProxy, _noProxy)))},
       {"socks5Proxy", boost::any(string(Darabonba_Util::Client::defaultString(
                           runtime->socks5Proxy, _socks5Proxy)))},
       {"socks5NetWork",
        boost::any(string(Darabonba_Util::Client::defaultString(
            runtime->socks5NetWork, _socks5NetWork)))},
       {"maxIdleConns", boost::any(Darabonba_Util::Client::defaultNumber(
                            runtime->maxIdleConns, _maxIdleConns))},
       {"retry", boost::any(map<string, boost::any>(
                     {{"retryable", !runtime->autoretry
                                        ? boost::any()
                                        : boost::any(*runtime->autoretry)},
                      {"maxAttempts",
                       boost::any(Darabonba_Util::Client::defaultNumber(
                           runtime->maxAttempts, make_shared<int>(3)))}}))},
       {"backoff",
        boost::any(map<string, boost::any>(
            {{"policy",
              boost::any(string(Darabonba_Util::Client::defaultString(
                  runtime->backoffPolicy, make_shared<string>("no"))))},
             {"period", boost::any(Darabonba_Util::Client::defaultNumber(
                            runtime->backoffPeriod, make_shared<int>(1)))}}))},
       {"ignoreSSL", !runtime->ignoreSSL ? boost::any()
                                         : boost::any(*runtime->ignoreSSL)}}));
  shared_ptr<Darabonba::Request> _lastRequest;
  shared_ptr<std::exception> _lastException;
  shared_ptr<int> _now = make_shared<int>(0);
  shared_ptr<int> _retryTimes = make_shared<int>(0);
  while (Darabonba::Core::allowRetry(
      make_shared<boost::any>((*runtime_)["retry"]), _retryTimes, _now)) {
    if (*_retryTimes > 0) {
      shared_ptr<int> _backoffTime =
          make_shared<int>(Darabonba::Core::getBackoffTime(
              make_shared<boost::any>((*runtime_)["backoff"]), _retryTimes));
      if (*_backoffTime > 0) {
        Darabonba::Core::sleep(_backoffTime);
      }
    }
    _retryTimes = make_shared<int>(*_retryTimes + 1);
    try {
      shared_ptr<Darabonba::Request> request_ =
          make_shared<Darabonba::Request>();
      shared_ptr<string> accessKeyId =
          make_shared<string>(_credential->getAccessKeyId());
      shared_ptr<string> accessKeySecret =
          make_shared<string>(_credential->getAccessKeySecret());
      shared_ptr<string> token =
          make_shared<string>(_credential->getSecurityToken());
      request_->protocol = *_protocol;
      request_->method = "GET";
      request_->pathname = string("/?bucketInfo");
      request_->headers = {
          {"host", Alibabacloud_OSSUtil::Client::getHost(
                       request->bucketName, _regionId, _endpoint, _hostModel)},
          {"date", Darabonba_Util::Client::getDateUTCString()},
          {"user-agent", getUserAgent()}};
      if (!Darabonba_Util::Client::empty(token)) {
        request_->headers.insert(
            pair<string, string>("x-oss-security-token", *token));
      }
      request_->headers.insert(pair<string, string>(
          "authorization",
          Alibabacloud_OSSUtil::Client::getSignature(
              request_, request->bucketName, accessKeyId, accessKeySecret,
              _signatureVersion, _addtionalHeaders)));
      _lastRequest = request_;
      shared_ptr<Darabonba::Response> response_ =
          make_shared<Darabonba::Response>(
              Darabonba::Core::doAction(request_, runtime_));
      shared_ptr<map<string, boost::any>> respMap;
      shared_ptr<string> bodyStr;
      if (Darabonba_Util::Client::is4xx(
              make_shared<int>(response_->statusCode)) ||
          Darabonba_Util::Client::is5xx(
              make_shared<int>(response_->statusCode))) {
        bodyStr = make_shared<string>(
            Darabonba_Util::Client::readAsString(response_->body));
        respMap = make_shared<map<string, boost::any>>(
            Alibabacloud_OSSUtil::Client::getErrMessage(bodyStr));
        BOOST_THROW_EXCEPTION(Darabonba::Error(map<string, boost::any>(
            {{"code", (*respMap)["Code"]},
             {"message", (*respMap)["Message"]},
             {"data", boost::any(map<string, boost::any>(
                          {{"httpCode", boost::any(response_->statusCode)},
                           {"requestId", (*respMap)["RequestId"]},
                           {"hostId", (*respMap)["HostId"]}}))}})));
      }
      bodyStr = make_shared<string>(
          Darabonba_Util::Client::readAsString(response_->body));
      respMap = make_shared<map<string, boost::any>>(
          Darabonba_XML::Client::parseXml(bodyStr, nullptr));
      return GetBucketInfoResponse(Darabonba::Converter::merge(
          map<string, boost::any>({{"BucketInfo", (*respMap)["BucketInfo"]}}),
          Darabonba::Converter::toGenericMap(response_->headers)));
    } catch (std::exception &e) {
      if (Darabonba::Core::isRetryable(e)) {
        _lastException = make_shared<std::exception>(e);
        continue;
      }
      BOOST_THROW_EXCEPTION(e);
    }
  }
  BOOST_THROW_EXCEPTION(
      Darabonba::UnretryableError(_lastRequest, _lastException));
}

PutLiveChannelStatusResponse Alibabacloud_OSS::Client::putLiveChannelStatus(
    shared_ptr<PutLiveChannelStatusRequest> request,
    shared_ptr<Alibabacloud_OSSUtil::RuntimeOptions> runtime) {
  request->validate();
  runtime->validate();
  shared_ptr<map<string, boost::any>> runtime_ = make_shared<
      map<string, boost::any>>(map<string, boost::any>(
      {{"timeouted", boost::any(string("retry"))},
       {"readTimeout", boost::any(Darabonba_Util::Client::defaultNumber(
                           runtime->readTimeout, _readTimeout))},
       {"connectTimeout", boost::any(Darabonba_Util::Client::defaultNumber(
                              runtime->connectTimeout, _connectTimeout))},
       {"localAddr", boost::any(string(Darabonba_Util::Client::defaultString(
                         runtime->localAddr, _localAddr)))},
       {"httpProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                         runtime->httpProxy, _httpProxy)))},
       {"httpsProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                          runtime->httpsProxy, _httpsProxy)))},
       {"noProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                       runtime->noProxy, _noProxy)))},
       {"socks5Proxy", boost::any(string(Darabonba_Util::Client::defaultString(
                           runtime->socks5Proxy, _socks5Proxy)))},
       {"socks5NetWork",
        boost::any(string(Darabonba_Util::Client::defaultString(
            runtime->socks5NetWork, _socks5NetWork)))},
       {"maxIdleConns", boost::any(Darabonba_Util::Client::defaultNumber(
                            runtime->maxIdleConns, _maxIdleConns))},
       {"retry", boost::any(map<string, boost::any>(
                     {{"retryable", !runtime->autoretry
                                        ? boost::any()
                                        : boost::any(*runtime->autoretry)},
                      {"maxAttempts",
                       boost::any(Darabonba_Util::Client::defaultNumber(
                           runtime->maxAttempts, make_shared<int>(3)))}}))},
       {"backoff",
        boost::any(map<string, boost::any>(
            {{"policy",
              boost::any(string(Darabonba_Util::Client::defaultString(
                  runtime->backoffPolicy, make_shared<string>("no"))))},
             {"period", boost::any(Darabonba_Util::Client::defaultNumber(
                            runtime->backoffPeriod, make_shared<int>(1)))}}))},
       {"ignoreSSL", !runtime->ignoreSSL ? boost::any()
                                         : boost::any(*runtime->ignoreSSL)}}));
  shared_ptr<Darabonba::Request> _lastRequest;
  shared_ptr<std::exception> _lastException;
  shared_ptr<int> _now = make_shared<int>(0);
  shared_ptr<int> _retryTimes = make_shared<int>(0);
  while (Darabonba::Core::allowRetry(
      make_shared<boost::any>((*runtime_)["retry"]), _retryTimes, _now)) {
    if (*_retryTimes > 0) {
      shared_ptr<int> _backoffTime =
          make_shared<int>(Darabonba::Core::getBackoffTime(
              make_shared<boost::any>((*runtime_)["backoff"]), _retryTimes));
      if (*_backoffTime > 0) {
        Darabonba::Core::sleep(_backoffTime);
      }
    }
    _retryTimes = make_shared<int>(*_retryTimes + 1);
    try {
      shared_ptr<Darabonba::Request> request_ =
          make_shared<Darabonba::Request>();
      shared_ptr<string> accessKeyId =
          make_shared<string>(_credential->getAccessKeyId());
      shared_ptr<string> accessKeySecret =
          make_shared<string>(_credential->getAccessKeySecret());
      shared_ptr<string> token =
          make_shared<string>(_credential->getSecurityToken());
      request_->protocol = *_protocol;
      request_->method = "PUT";
      request_->pathname = string("/" + *request->channelName + "?live");
      request_->headers = {
          {"host", Alibabacloud_OSSUtil::Client::getHost(
                       request->bucketName, _regionId, _endpoint, _hostModel)},
          {"date", Darabonba_Util::Client::getDateUTCString()},
          {"user-agent", getUserAgent()}};
      if (!Darabonba_Util::Client::empty(token)) {
        request_->headers.insert(
            pair<string, string>("x-oss-security-token", *token));
      }
      request_->query = Darabonba_Util::Client::stringifyMapValue(
          make_shared<map<string, boost::any>>(request->filter->toMap()));
      request_->headers.insert(pair<string, string>(
          "authorization",
          Alibabacloud_OSSUtil::Client::getSignature(
              request_, request->bucketName, accessKeyId, accessKeySecret,
              _signatureVersion, _addtionalHeaders)));
      _lastRequest = request_;
      shared_ptr<Darabonba::Response> response_ =
          make_shared<Darabonba::Response>(
              Darabonba::Core::doAction(request_, runtime_));
      shared_ptr<map<string, boost::any>> respMap;
      shared_ptr<string> bodyStr;
      if (Darabonba_Util::Client::is4xx(
              make_shared<int>(response_->statusCode)) ||
          Darabonba_Util::Client::is5xx(
              make_shared<int>(response_->statusCode))) {
        bodyStr = make_shared<string>(
            Darabonba_Util::Client::readAsString(response_->body));
        respMap = make_shared<map<string, boost::any>>(
            Alibabacloud_OSSUtil::Client::getErrMessage(bodyStr));
        BOOST_THROW_EXCEPTION(Darabonba::Error(map<string, boost::any>(
            {{"code", (*respMap)["Code"]},
             {"message", (*respMap)["Message"]},
             {"data", boost::any(map<string, boost::any>(
                          {{"httpCode", boost::any(response_->statusCode)},
                           {"requestId", (*respMap)["RequestId"]},
                           {"hostId", (*respMap)["HostId"]}}))}})));
      }
      return PutLiveChannelStatusResponse(
          Darabonba::Converter::toGenericMap(Darabonba::Converter::merge(
              map<string, string>(), response_->headers)));
    } catch (std::exception &e) {
      if (Darabonba::Core::isRetryable(e)) {
        _lastException = make_shared<std::exception>(e);
        continue;
      }
      BOOST_THROW_EXCEPTION(e);
    }
  }
  BOOST_THROW_EXCEPTION(
      Darabonba::UnretryableError(_lastRequest, _lastException));
}

InitiateMultipartUploadResponse
Alibabacloud_OSS::Client::initiateMultipartUpload(
    shared_ptr<InitiateMultipartUploadRequest> request,
    shared_ptr<Alibabacloud_OSSUtil::RuntimeOptions> runtime) {
  request->validate();
  runtime->validate();
  shared_ptr<map<string, boost::any>> runtime_ = make_shared<
      map<string, boost::any>>(map<string, boost::any>(
      {{"timeouted", boost::any(string("retry"))},
       {"readTimeout", boost::any(Darabonba_Util::Client::defaultNumber(
                           runtime->readTimeout, _readTimeout))},
       {"connectTimeout", boost::any(Darabonba_Util::Client::defaultNumber(
                              runtime->connectTimeout, _connectTimeout))},
       {"localAddr", boost::any(string(Darabonba_Util::Client::defaultString(
                         runtime->localAddr, _localAddr)))},
       {"httpProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                         runtime->httpProxy, _httpProxy)))},
       {"httpsProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                          runtime->httpsProxy, _httpsProxy)))},
       {"noProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                       runtime->noProxy, _noProxy)))},
       {"socks5Proxy", boost::any(string(Darabonba_Util::Client::defaultString(
                           runtime->socks5Proxy, _socks5Proxy)))},
       {"socks5NetWork",
        boost::any(string(Darabonba_Util::Client::defaultString(
            runtime->socks5NetWork, _socks5NetWork)))},
       {"maxIdleConns", boost::any(Darabonba_Util::Client::defaultNumber(
                            runtime->maxIdleConns, _maxIdleConns))},
       {"retry", boost::any(map<string, boost::any>(
                     {{"retryable", !runtime->autoretry
                                        ? boost::any()
                                        : boost::any(*runtime->autoretry)},
                      {"maxAttempts",
                       boost::any(Darabonba_Util::Client::defaultNumber(
                           runtime->maxAttempts, make_shared<int>(3)))}}))},
       {"backoff",
        boost::any(map<string, boost::any>(
            {{"policy",
              boost::any(string(Darabonba_Util::Client::defaultString(
                  runtime->backoffPolicy, make_shared<string>("no"))))},
             {"period", boost::any(Darabonba_Util::Client::defaultNumber(
                            runtime->backoffPeriod, make_shared<int>(1)))}}))},
       {"ignoreSSL", !runtime->ignoreSSL ? boost::any()
                                         : boost::any(*runtime->ignoreSSL)}}));
  shared_ptr<Darabonba::Request> _lastRequest;
  shared_ptr<std::exception> _lastException;
  shared_ptr<int> _now = make_shared<int>(0);
  shared_ptr<int> _retryTimes = make_shared<int>(0);
  while (Darabonba::Core::allowRetry(
      make_shared<boost::any>((*runtime_)["retry"]), _retryTimes, _now)) {
    if (*_retryTimes > 0) {
      shared_ptr<int> _backoffTime =
          make_shared<int>(Darabonba::Core::getBackoffTime(
              make_shared<boost::any>((*runtime_)["backoff"]), _retryTimes));
      if (*_backoffTime > 0) {
        Darabonba::Core::sleep(_backoffTime);
      }
    }
    _retryTimes = make_shared<int>(*_retryTimes + 1);
    try {
      shared_ptr<Darabonba::Request> request_ =
          make_shared<Darabonba::Request>();
      shared_ptr<string> accessKeyId =
          make_shared<string>(_credential->getAccessKeyId());
      shared_ptr<string> accessKeySecret =
          make_shared<string>(_credential->getAccessKeySecret());
      shared_ptr<string> token =
          make_shared<string>(_credential->getSecurityToken());
      request_->protocol = *_protocol;
      request_->method = "POST";
      request_->pathname = string("/" + *request->objectName + "?uploads");
      request_->headers = Darabonba::Converter::merge(
          map<string, string>(
              {{"host",
                Alibabacloud_OSSUtil::Client::getHost(
                    request->bucketName, _regionId, _endpoint, _hostModel)},
               {"date", Darabonba_Util::Client::getDateUTCString()},
               {"user-agent", getUserAgent()}}),
          Darabonba_Util::Client::stringifyMapValue(
              make_shared<map<string, boost::any>>(request->header->toMap())));
      if (!Darabonba_Util::Client::empty(token)) {
        request_->headers.insert(
            pair<string, string>("x-oss-security-token", *token));
      }
      request_->query = Darabonba_Util::Client::stringifyMapValue(
          make_shared<map<string, boost::any>>(request->filter->toMap()));
      if (!Darabonba_Util::Client::isUnset<
              InitiateMultipartUploadRequestHeader>(request->header) &&
          !Darabonba_Util::Client::empty(request->header->contentType)) {
        request_->headers.insert(pair<string, string>(
            "content-type", *request->header->contentType));
      } else {
        request_->headers.insert(pair<string, string>(
            "content-type",
            Alibabacloud_OSSUtil::Client::getContentType(request->objectName)));
      }
      request_->headers.insert(pair<string, string>(
          "authorization",
          Alibabacloud_OSSUtil::Client::getSignature(
              request_, request->bucketName, accessKeyId, accessKeySecret,
              _signatureVersion, _addtionalHeaders)));
      _lastRequest = request_;
      shared_ptr<Darabonba::Response> response_ =
          make_shared<Darabonba::Response>(
              Darabonba::Core::doAction(request_, runtime_));
      shared_ptr<map<string, boost::any>> respMap;
      shared_ptr<string> bodyStr;
      if (Darabonba_Util::Client::is4xx(
              make_shared<int>(response_->statusCode)) ||
          Darabonba_Util::Client::is5xx(
              make_shared<int>(response_->statusCode))) {
        bodyStr = make_shared<string>(
            Darabonba_Util::Client::readAsString(response_->body));
        respMap = make_shared<map<string, boost::any>>(
            Alibabacloud_OSSUtil::Client::getErrMessage(bodyStr));
        BOOST_THROW_EXCEPTION(Darabonba::Error(map<string, boost::any>(
            {{"code", (*respMap)["Code"]},
             {"message", (*respMap)["Message"]},
             {"data", boost::any(map<string, boost::any>(
                          {{"httpCode", boost::any(response_->statusCode)},
                           {"requestId", (*respMap)["RequestId"]},
                           {"hostId", (*respMap)["HostId"]}}))}})));
      }
      bodyStr = make_shared<string>(
          Darabonba_Util::Client::readAsString(response_->body));
      respMap = make_shared<map<string, boost::any>>(
          Darabonba_XML::Client::parseXml(bodyStr, nullptr));
      return InitiateMultipartUploadResponse(Darabonba::Converter::merge(
          map<string, boost::any>(
              {{"InitiateMultipartUploadResult",
                (*respMap)["InitiateMultipartUploadResult"]}}),
          Darabonba::Converter::toGenericMap(response_->headers)));
    } catch (std::exception &e) {
      if (Darabonba::Core::isRetryable(e)) {
        _lastException = make_shared<std::exception>(e);
        continue;
      }
      BOOST_THROW_EXCEPTION(e);
    }
  }
  BOOST_THROW_EXCEPTION(
      Darabonba::UnretryableError(_lastRequest, _lastException));
}

OptionObjectResponse Alibabacloud_OSS::Client::optionObject(
    shared_ptr<OptionObjectRequest> request,
    shared_ptr<Alibabacloud_OSSUtil::RuntimeOptions> runtime) {
  request->validate();
  runtime->validate();
  shared_ptr<map<string, boost::any>> runtime_ = make_shared<
      map<string, boost::any>>(map<string, boost::any>(
      {{"timeouted", boost::any(string("retry"))},
       {"readTimeout", boost::any(Darabonba_Util::Client::defaultNumber(
                           runtime->readTimeout, _readTimeout))},
       {"connectTimeout", boost::any(Darabonba_Util::Client::defaultNumber(
                              runtime->connectTimeout, _connectTimeout))},
       {"localAddr", boost::any(string(Darabonba_Util::Client::defaultString(
                         runtime->localAddr, _localAddr)))},
       {"httpProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                         runtime->httpProxy, _httpProxy)))},
       {"httpsProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                          runtime->httpsProxy, _httpsProxy)))},
       {"noProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                       runtime->noProxy, _noProxy)))},
       {"socks5Proxy", boost::any(string(Darabonba_Util::Client::defaultString(
                           runtime->socks5Proxy, _socks5Proxy)))},
       {"socks5NetWork",
        boost::any(string(Darabonba_Util::Client::defaultString(
            runtime->socks5NetWork, _socks5NetWork)))},
       {"maxIdleConns", boost::any(Darabonba_Util::Client::defaultNumber(
                            runtime->maxIdleConns, _maxIdleConns))},
       {"retry", boost::any(map<string, boost::any>(
                     {{"retryable", !runtime->autoretry
                                        ? boost::any()
                                        : boost::any(*runtime->autoretry)},
                      {"maxAttempts",
                       boost::any(Darabonba_Util::Client::defaultNumber(
                           runtime->maxAttempts, make_shared<int>(3)))}}))},
       {"backoff",
        boost::any(map<string, boost::any>(
            {{"policy",
              boost::any(string(Darabonba_Util::Client::defaultString(
                  runtime->backoffPolicy, make_shared<string>("no"))))},
             {"period", boost::any(Darabonba_Util::Client::defaultNumber(
                            runtime->backoffPeriod, make_shared<int>(1)))}}))},
       {"ignoreSSL", !runtime->ignoreSSL ? boost::any()
                                         : boost::any(*runtime->ignoreSSL)}}));
  shared_ptr<Darabonba::Request> _lastRequest;
  shared_ptr<std::exception> _lastException;
  shared_ptr<int> _now = make_shared<int>(0);
  shared_ptr<int> _retryTimes = make_shared<int>(0);
  while (Darabonba::Core::allowRetry(
      make_shared<boost::any>((*runtime_)["retry"]), _retryTimes, _now)) {
    if (*_retryTimes > 0) {
      shared_ptr<int> _backoffTime =
          make_shared<int>(Darabonba::Core::getBackoffTime(
              make_shared<boost::any>((*runtime_)["backoff"]), _retryTimes));
      if (*_backoffTime > 0) {
        Darabonba::Core::sleep(_backoffTime);
      }
    }
    _retryTimes = make_shared<int>(*_retryTimes + 1);
    try {
      shared_ptr<Darabonba::Request> request_ =
          make_shared<Darabonba::Request>();
      shared_ptr<string> accessKeyId =
          make_shared<string>(_credential->getAccessKeyId());
      shared_ptr<string> accessKeySecret =
          make_shared<string>(_credential->getAccessKeySecret());
      shared_ptr<string> token =
          make_shared<string>(_credential->getSecurityToken());
      request_->protocol = *_protocol;
      request_->method = "OPTIONS";
      request_->pathname = string("/" + *request->objectName + "");
      request_->headers = Darabonba::Converter::merge(
          map<string, string>(
              {{"host",
                Alibabacloud_OSSUtil::Client::getHost(
                    request->bucketName, _regionId, _endpoint, _hostModel)},
               {"date", Darabonba_Util::Client::getDateUTCString()},
               {"user-agent", getUserAgent()}}),
          Darabonba_Util::Client::stringifyMapValue(
              make_shared<map<string, boost::any>>(request->header->toMap())));
      if (!Darabonba_Util::Client::empty(token)) {
        request_->headers.insert(
            pair<string, string>("x-oss-security-token", *token));
      }
      request_->headers.insert(pair<string, string>(
          "authorization",
          Alibabacloud_OSSUtil::Client::getSignature(
              request_, request->bucketName, accessKeyId, accessKeySecret,
              _signatureVersion, _addtionalHeaders)));
      _lastRequest = request_;
      shared_ptr<Darabonba::Response> response_ =
          make_shared<Darabonba::Response>(
              Darabonba::Core::doAction(request_, runtime_));
      shared_ptr<map<string, boost::any>> respMap;
      shared_ptr<string> bodyStr;
      if (Darabonba_Util::Client::is4xx(
              make_shared<int>(response_->statusCode)) ||
          Darabonba_Util::Client::is5xx(
              make_shared<int>(response_->statusCode))) {
        bodyStr = make_shared<string>(
            Darabonba_Util::Client::readAsString(response_->body));
        respMap = make_shared<map<string, boost::any>>(
            Alibabacloud_OSSUtil::Client::getErrMessage(bodyStr));
        BOOST_THROW_EXCEPTION(Darabonba::Error(map<string, boost::any>(
            {{"code", (*respMap)["Code"]},
             {"message", (*respMap)["Message"]},
             {"data", boost::any(map<string, boost::any>(
                          {{"httpCode", boost::any(response_->statusCode)},
                           {"requestId", (*respMap)["RequestId"]},
                           {"hostId", (*respMap)["HostId"]}}))}})));
      }
      return OptionObjectResponse(
          Darabonba::Converter::toGenericMap(Darabonba::Converter::merge(
              map<string, string>(), response_->headers)));
    } catch (std::exception &e) {
      if (Darabonba::Core::isRetryable(e)) {
        _lastException = make_shared<std::exception>(e);
        continue;
      }
      BOOST_THROW_EXCEPTION(e);
    }
  }
  BOOST_THROW_EXCEPTION(
      Darabonba::UnretryableError(_lastRequest, _lastException));
}

PostVodPlaylistResponse Alibabacloud_OSS::Client::postVodPlaylist(
    shared_ptr<PostVodPlaylistRequest> request,
    shared_ptr<Alibabacloud_OSSUtil::RuntimeOptions> runtime) {
  request->validate();
  runtime->validate();
  shared_ptr<map<string, boost::any>> runtime_ = make_shared<
      map<string, boost::any>>(map<string, boost::any>(
      {{"timeouted", boost::any(string("retry"))},
       {"readTimeout", boost::any(Darabonba_Util::Client::defaultNumber(
                           runtime->readTimeout, _readTimeout))},
       {"connectTimeout", boost::any(Darabonba_Util::Client::defaultNumber(
                              runtime->connectTimeout, _connectTimeout))},
       {"localAddr", boost::any(string(Darabonba_Util::Client::defaultString(
                         runtime->localAddr, _localAddr)))},
       {"httpProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                         runtime->httpProxy, _httpProxy)))},
       {"httpsProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                          runtime->httpsProxy, _httpsProxy)))},
       {"noProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                       runtime->noProxy, _noProxy)))},
       {"socks5Proxy", boost::any(string(Darabonba_Util::Client::defaultString(
                           runtime->socks5Proxy, _socks5Proxy)))},
       {"socks5NetWork",
        boost::any(string(Darabonba_Util::Client::defaultString(
            runtime->socks5NetWork, _socks5NetWork)))},
       {"maxIdleConns", boost::any(Darabonba_Util::Client::defaultNumber(
                            runtime->maxIdleConns, _maxIdleConns))},
       {"retry", boost::any(map<string, boost::any>(
                     {{"retryable", !runtime->autoretry
                                        ? boost::any()
                                        : boost::any(*runtime->autoretry)},
                      {"maxAttempts",
                       boost::any(Darabonba_Util::Client::defaultNumber(
                           runtime->maxAttempts, make_shared<int>(3)))}}))},
       {"backoff",
        boost::any(map<string, boost::any>(
            {{"policy",
              boost::any(string(Darabonba_Util::Client::defaultString(
                  runtime->backoffPolicy, make_shared<string>("no"))))},
             {"period", boost::any(Darabonba_Util::Client::defaultNumber(
                            runtime->backoffPeriod, make_shared<int>(1)))}}))},
       {"ignoreSSL", !runtime->ignoreSSL ? boost::any()
                                         : boost::any(*runtime->ignoreSSL)}}));
  shared_ptr<Darabonba::Request> _lastRequest;
  shared_ptr<std::exception> _lastException;
  shared_ptr<int> _now = make_shared<int>(0);
  shared_ptr<int> _retryTimes = make_shared<int>(0);
  while (Darabonba::Core::allowRetry(
      make_shared<boost::any>((*runtime_)["retry"]), _retryTimes, _now)) {
    if (*_retryTimes > 0) {
      shared_ptr<int> _backoffTime =
          make_shared<int>(Darabonba::Core::getBackoffTime(
              make_shared<boost::any>((*runtime_)["backoff"]), _retryTimes));
      if (*_backoffTime > 0) {
        Darabonba::Core::sleep(_backoffTime);
      }
    }
    _retryTimes = make_shared<int>(*_retryTimes + 1);
    try {
      shared_ptr<Darabonba::Request> request_ =
          make_shared<Darabonba::Request>();
      shared_ptr<string> accessKeyId =
          make_shared<string>(_credential->getAccessKeyId());
      shared_ptr<string> accessKeySecret =
          make_shared<string>(_credential->getAccessKeySecret());
      shared_ptr<string> token =
          make_shared<string>(_credential->getSecurityToken());
      request_->protocol = *_protocol;
      request_->method = "POST";
      request_->pathname = string("/" + *request->channelName + "/" +
                                  *request->playlistName + "?vod");
      request_->headers = {
          {"host", Alibabacloud_OSSUtil::Client::getHost(
                       request->bucketName, _regionId, _endpoint, _hostModel)},
          {"date", Darabonba_Util::Client::getDateUTCString()},
          {"user-agent", getUserAgent()}};
      if (!Darabonba_Util::Client::empty(token)) {
        request_->headers.insert(
            pair<string, string>("x-oss-security-token", *token));
      }
      request_->query = Darabonba_Util::Client::stringifyMapValue(
          make_shared<map<string, boost::any>>(request->filter->toMap()));
      request_->headers.insert(pair<string, string>(
          "authorization",
          Alibabacloud_OSSUtil::Client::getSignature(
              request_, request->bucketName, accessKeyId, accessKeySecret,
              _signatureVersion, _addtionalHeaders)));
      _lastRequest = request_;
      shared_ptr<Darabonba::Response> response_ =
          make_shared<Darabonba::Response>(
              Darabonba::Core::doAction(request_, runtime_));
      shared_ptr<map<string, boost::any>> respMap;
      shared_ptr<string> bodyStr;
      if (Darabonba_Util::Client::is4xx(
              make_shared<int>(response_->statusCode)) ||
          Darabonba_Util::Client::is5xx(
              make_shared<int>(response_->statusCode))) {
        bodyStr = make_shared<string>(
            Darabonba_Util::Client::readAsString(response_->body));
        respMap = make_shared<map<string, boost::any>>(
            Alibabacloud_OSSUtil::Client::getErrMessage(bodyStr));
        BOOST_THROW_EXCEPTION(Darabonba::Error(map<string, boost::any>(
            {{"code", (*respMap)["Code"]},
             {"message", (*respMap)["Message"]},
             {"data", boost::any(map<string, boost::any>(
                          {{"httpCode", boost::any(response_->statusCode)},
                           {"requestId", (*respMap)["RequestId"]},
                           {"hostId", (*respMap)["HostId"]}}))}})));
      }
      return PostVodPlaylistResponse(
          Darabonba::Converter::toGenericMap(Darabonba::Converter::merge(
              map<string, string>(), response_->headers)));
    } catch (std::exception &e) {
      if (Darabonba::Core::isRetryable(e)) {
        _lastException = make_shared<std::exception>(e);
        continue;
      }
      BOOST_THROW_EXCEPTION(e);
    }
  }
  BOOST_THROW_EXCEPTION(
      Darabonba::UnretryableError(_lastRequest, _lastException));
}

PostObjectResponse Alibabacloud_OSS::Client::postObject(
    shared_ptr<PostObjectRequest> request,
    shared_ptr<Alibabacloud_OSSUtil::RuntimeOptions> runtime) {
  request->validate();
  runtime->validate();
  shared_ptr<map<string, boost::any>> runtime_ = make_shared<
      map<string, boost::any>>(map<string, boost::any>(
      {{"timeouted", boost::any(string("retry"))},
       {"readTimeout", boost::any(Darabonba_Util::Client::defaultNumber(
                           runtime->readTimeout, _readTimeout))},
       {"connectTimeout", boost::any(Darabonba_Util::Client::defaultNumber(
                              runtime->connectTimeout, _connectTimeout))},
       {"httpProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                         runtime->httpProxy, _httpProxy)))},
       {"httpsProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                          runtime->httpsProxy, _httpsProxy)))},
       {"noProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                       runtime->noProxy, _noProxy)))},
       {"maxIdleConns", boost::any(Darabonba_Util::Client::defaultNumber(
                            runtime->maxIdleConns, _maxIdleConns))},
       {"retry", boost::any(map<string, boost::any>(
                     {{"retryable", !runtime->autoretry
                                        ? boost::any()
                                        : boost::any(*runtime->autoretry)},
                      {"maxAttempts",
                       boost::any(Darabonba_Util::Client::defaultNumber(
                           runtime->maxAttempts, make_shared<int>(3)))}}))},
       {"backoff",
        boost::any(map<string, boost::any>(
            {{"policy",
              boost::any(string(Darabonba_Util::Client::defaultString(
                  runtime->backoffPolicy, make_shared<string>("no"))))},
             {"period", boost::any(Darabonba_Util::Client::defaultNumber(
                            runtime->backoffPeriod, make_shared<int>(1)))}}))},
       {"ignoreSSL", !runtime->ignoreSSL ? boost::any()
                                         : boost::any(*runtime->ignoreSSL)}}));
  shared_ptr<Darabonba::Request> _lastRequest;
  shared_ptr<std::exception> _lastException;
  shared_ptr<int> _now = make_shared<int>(0);
  shared_ptr<int> _retryTimes = make_shared<int>(0);
  while (Darabonba::Core::allowRetry(
      make_shared<boost::any>((*runtime_)["retry"]), _retryTimes, _now)) {
    if (*_retryTimes > 0) {
      shared_ptr<int> _backoffTime =
          make_shared<int>(Darabonba::Core::getBackoffTime(
              make_shared<boost::any>((*runtime_)["backoff"]), _retryTimes));
      if (*_backoffTime > 0) {
        Darabonba::Core::sleep(_backoffTime);
      }
    }
    _retryTimes = make_shared<int>(*_retryTimes + 1);
    try {
      shared_ptr<Darabonba::Request> request_ =
          make_shared<Darabonba::Request>();
      shared_ptr<string> boundary =
          make_shared<string>(Darabonba_FileForm::Client::getBoundary());
      request_->protocol = *_protocol;
      request_->method = "POST";
      request_->pathname = string("/");
      request_->headers = {
          {"host", Alibabacloud_OSSUtil::Client::getHost(
                       request->bucketName, _regionId, _endpoint, _hostModel)},
          {"date", Darabonba_Util::Client::getDateUTCString()},
          {"user-agent", getUserAgent()}};
      request_->headers.insert(pair<string, string>(
          "content-type",
          string("multipart/form-data; boundary=" + *boundary + "")));
      shared_ptr<map<string, boost::any>> form =
          make_shared<map<string, boost::any>>(Darabonba::Converter::merge(
              map<string, boost::any>(
                  {{"OSSAccessKeyId",
                    !request->header->accessKeyId
                        ? boost::any()
                        : boost::any(*request->header->accessKeyId)},
                   {"policy", !request->header->policy
                                  ? boost::any()
                                  : boost::any(*request->header->policy)},
                   {"Signature", !request->header->signature
                                     ? boost::any()
                                     : boost::any(*request->header->signature)},
                   {"key", !request->header->key
                               ? boost::any()
                               : boost::any(*request->header->key)},
                   {"success_action_status",
                    !request->header->successActionStatus
                        ? boost::any()
                        : boost::any(*request->header->successActionStatus)},
                   {"file", !request->header->file
                                ? boost::any()
                                : boost::any(*request->header->file)}}),
              Darabonba::Converter::toGenericMap(
                  Alibabacloud_OSSUtil::Client::toMeta(
                      request->header->userMeta,
                      make_shared<string>("x-oss-meta-")))));
      request_->body = Darabonba_FileForm::Client::toFileForm(form, boundary);
      _lastRequest = request_;
      shared_ptr<Darabonba::Response> response_ =
          make_shared<Darabonba::Response>(
              Darabonba::Core::doAction(request_, runtime_));
      shared_ptr<map<string, boost::any>> respMap;
      shared_ptr<string> bodyStr = make_shared<string>(
          Darabonba_Util::Client::readAsString(response_->body));
      if (Darabonba_Util::Client::is4xx(
              make_shared<int>(response_->statusCode)) ||
          Darabonba_Util::Client::is5xx(
              make_shared<int>(response_->statusCode))) {
        respMap = make_shared<map<string, boost::any>>(
            Alibabacloud_OSSUtil::Client::getErrMessage(bodyStr));
        BOOST_THROW_EXCEPTION(Darabonba::Error(map<string, boost::any>(
            {{"code", (*respMap)["Code"]},
             {"message", (*respMap)["Message"]},
             {"data", boost::any(map<string, boost::any>(
                          {{"httpCode", boost::any(response_->statusCode)},
                           {"requestId", (*respMap)["RequestId"]},
                           {"hostId", (*respMap)["HostId"]}}))}})));
      }
      respMap = make_shared<map<string, boost::any>>(
          Darabonba_XML::Client::parseXml(bodyStr, nullptr));
      return PostObjectResponse(Darabonba::Converter::merge(
          map<string, boost::any>(),
          !respMap ? map<string, boost::any>() : *respMap));
    } catch (std::exception &e) {
      if (Darabonba::Core::isRetryable(e)) {
        _lastException = make_shared<std::exception>(e);
        continue;
      }
      BOOST_THROW_EXCEPTION(e);
    }
  }
  BOOST_THROW_EXCEPTION(
      Darabonba::UnretryableError(_lastRequest, _lastException));
}

HeadObjectResponse Alibabacloud_OSS::Client::headObject(
    shared_ptr<HeadObjectRequest> request,
    shared_ptr<Alibabacloud_OSSUtil::RuntimeOptions> runtime) {
  request->validate();
  runtime->validate();
  shared_ptr<map<string, boost::any>> runtime_ = make_shared<
      map<string, boost::any>>(map<string, boost::any>(
      {{"timeouted", boost::any(string("retry"))},
       {"readTimeout", boost::any(Darabonba_Util::Client::defaultNumber(
                           runtime->readTimeout, _readTimeout))},
       {"connectTimeout", boost::any(Darabonba_Util::Client::defaultNumber(
                              runtime->connectTimeout, _connectTimeout))},
       {"localAddr", boost::any(string(Darabonba_Util::Client::defaultString(
                         runtime->localAddr, _localAddr)))},
       {"httpProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                         runtime->httpProxy, _httpProxy)))},
       {"httpsProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                          runtime->httpsProxy, _httpsProxy)))},
       {"noProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                       runtime->noProxy, _noProxy)))},
       {"socks5Proxy", boost::any(string(Darabonba_Util::Client::defaultString(
                           runtime->socks5Proxy, _socks5Proxy)))},
       {"socks5NetWork",
        boost::any(string(Darabonba_Util::Client::defaultString(
            runtime->socks5NetWork, _socks5NetWork)))},
       {"maxIdleConns", boost::any(Darabonba_Util::Client::defaultNumber(
                            runtime->maxIdleConns, _maxIdleConns))},
       {"retry", boost::any(map<string, boost::any>(
                     {{"retryable", !runtime->autoretry
                                        ? boost::any()
                                        : boost::any(*runtime->autoretry)},
                      {"maxAttempts",
                       boost::any(Darabonba_Util::Client::defaultNumber(
                           runtime->maxAttempts, make_shared<int>(3)))}}))},
       {"backoff",
        boost::any(map<string, boost::any>(
            {{"policy",
              boost::any(string(Darabonba_Util::Client::defaultString(
                  runtime->backoffPolicy, make_shared<string>("no"))))},
             {"period", boost::any(Darabonba_Util::Client::defaultNumber(
                            runtime->backoffPeriod, make_shared<int>(1)))}}))},
       {"ignoreSSL", !runtime->ignoreSSL ? boost::any()
                                         : boost::any(*runtime->ignoreSSL)}}));
  shared_ptr<Darabonba::Request> _lastRequest;
  shared_ptr<std::exception> _lastException;
  shared_ptr<int> _now = make_shared<int>(0);
  shared_ptr<int> _retryTimes = make_shared<int>(0);
  while (Darabonba::Core::allowRetry(
      make_shared<boost::any>((*runtime_)["retry"]), _retryTimes, _now)) {
    if (*_retryTimes > 0) {
      shared_ptr<int> _backoffTime =
          make_shared<int>(Darabonba::Core::getBackoffTime(
              make_shared<boost::any>((*runtime_)["backoff"]), _retryTimes));
      if (*_backoffTime > 0) {
        Darabonba::Core::sleep(_backoffTime);
      }
    }
    _retryTimes = make_shared<int>(*_retryTimes + 1);
    try {
      shared_ptr<Darabonba::Request> request_ =
          make_shared<Darabonba::Request>();
      shared_ptr<string> accessKeyId =
          make_shared<string>(_credential->getAccessKeyId());
      shared_ptr<string> accessKeySecret =
          make_shared<string>(_credential->getAccessKeySecret());
      shared_ptr<string> token =
          make_shared<string>(_credential->getSecurityToken());
      request_->protocol = *_protocol;
      request_->method = "HEAD";
      request_->pathname = string("/" + *request->objectName + "");
      request_->headers = Darabonba::Converter::merge(
          map<string, string>(
              {{"host",
                Alibabacloud_OSSUtil::Client::getHost(
                    request->bucketName, _regionId, _endpoint, _hostModel)},
               {"date", Darabonba_Util::Client::getDateUTCString()},
               {"user-agent", getUserAgent()}}),
          Darabonba_Util::Client::stringifyMapValue(
              make_shared<map<string, boost::any>>(request->header->toMap())));
      if (!Darabonba_Util::Client::empty(token)) {
        request_->headers.insert(
            pair<string, string>("x-oss-security-token", *token));
      }
      request_->headers.insert(pair<string, string>(
          "authorization",
          Alibabacloud_OSSUtil::Client::getSignature(
              request_, request->bucketName, accessKeyId, accessKeySecret,
              _signatureVersion, _addtionalHeaders)));
      _lastRequest = request_;
      shared_ptr<Darabonba::Response> response_ =
          make_shared<Darabonba::Response>(
              Darabonba::Core::doAction(request_, runtime_));
      shared_ptr<map<string, boost::any>> respMap;
      shared_ptr<string> bodyStr;
      if (Darabonba_Util::Client::is4xx(
              make_shared<int>(response_->statusCode)) ||
          Darabonba_Util::Client::is5xx(
              make_shared<int>(response_->statusCode))) {
        bodyStr = make_shared<string>(
            Darabonba_Util::Client::readAsString(response_->body));
        respMap = make_shared<map<string, boost::any>>(
            Alibabacloud_OSSUtil::Client::getErrMessage(bodyStr));
        BOOST_THROW_EXCEPTION(Darabonba::Error(map<string, boost::any>(
            {{"code", (*respMap)["Code"]},
             {"message", (*respMap)["Message"]},
             {"data", boost::any(map<string, boost::any>(
                          {{"httpCode", boost::any(response_->statusCode)},
                           {"requestId", (*respMap)["RequestId"]},
                           {"hostId", (*respMap)["HostId"]}}))}})));
      }
      return HeadObjectResponse(Darabonba::Converter::merge(
          map<string, boost::any>(
              {{"usermeta",
                boost::any(Alibabacloud_OSSUtil::Client::toMeta(
                    make_shared<map<string, string>>(response_->headers),
                    make_shared<string>("x-oss-meta-")))}}),
          Darabonba::Converter::toGenericMap(response_->headers)));
    } catch (std::exception &e) {
      if (Darabonba::Core::isRetryable(e)) {
        _lastException = make_shared<std::exception>(e);
        continue;
      }
      BOOST_THROW_EXCEPTION(e);
    }
  }
  BOOST_THROW_EXCEPTION(
      Darabonba::UnretryableError(_lastRequest, _lastException));
}

DeleteObjectTaggingResponse Alibabacloud_OSS::Client::deleteObjectTagging(
    shared_ptr<DeleteObjectTaggingRequest> request,
    shared_ptr<Alibabacloud_OSSUtil::RuntimeOptions> runtime) {
  request->validate();
  runtime->validate();
  shared_ptr<map<string, boost::any>> runtime_ = make_shared<
      map<string, boost::any>>(map<string, boost::any>(
      {{"timeouted", boost::any(string("retry"))},
       {"readTimeout", boost::any(Darabonba_Util::Client::defaultNumber(
                           runtime->readTimeout, _readTimeout))},
       {"connectTimeout", boost::any(Darabonba_Util::Client::defaultNumber(
                              runtime->connectTimeout, _connectTimeout))},
       {"localAddr", boost::any(string(Darabonba_Util::Client::defaultString(
                         runtime->localAddr, _localAddr)))},
       {"httpProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                         runtime->httpProxy, _httpProxy)))},
       {"httpsProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                          runtime->httpsProxy, _httpsProxy)))},
       {"noProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                       runtime->noProxy, _noProxy)))},
       {"socks5Proxy", boost::any(string(Darabonba_Util::Client::defaultString(
                           runtime->socks5Proxy, _socks5Proxy)))},
       {"socks5NetWork",
        boost::any(string(Darabonba_Util::Client::defaultString(
            runtime->socks5NetWork, _socks5NetWork)))},
       {"maxIdleConns", boost::any(Darabonba_Util::Client::defaultNumber(
                            runtime->maxIdleConns, _maxIdleConns))},
       {"retry", boost::any(map<string, boost::any>(
                     {{"retryable", !runtime->autoretry
                                        ? boost::any()
                                        : boost::any(*runtime->autoretry)},
                      {"maxAttempts",
                       boost::any(Darabonba_Util::Client::defaultNumber(
                           runtime->maxAttempts, make_shared<int>(3)))}}))},
       {"backoff",
        boost::any(map<string, boost::any>(
            {{"policy",
              boost::any(string(Darabonba_Util::Client::defaultString(
                  runtime->backoffPolicy, make_shared<string>("no"))))},
             {"period", boost::any(Darabonba_Util::Client::defaultNumber(
                            runtime->backoffPeriod, make_shared<int>(1)))}}))},
       {"ignoreSSL", !runtime->ignoreSSL ? boost::any()
                                         : boost::any(*runtime->ignoreSSL)}}));
  shared_ptr<Darabonba::Request> _lastRequest;
  shared_ptr<std::exception> _lastException;
  shared_ptr<int> _now = make_shared<int>(0);
  shared_ptr<int> _retryTimes = make_shared<int>(0);
  while (Darabonba::Core::allowRetry(
      make_shared<boost::any>((*runtime_)["retry"]), _retryTimes, _now)) {
    if (*_retryTimes > 0) {
      shared_ptr<int> _backoffTime =
          make_shared<int>(Darabonba::Core::getBackoffTime(
              make_shared<boost::any>((*runtime_)["backoff"]), _retryTimes));
      if (*_backoffTime > 0) {
        Darabonba::Core::sleep(_backoffTime);
      }
    }
    _retryTimes = make_shared<int>(*_retryTimes + 1);
    try {
      shared_ptr<Darabonba::Request> request_ =
          make_shared<Darabonba::Request>();
      shared_ptr<string> accessKeyId =
          make_shared<string>(_credential->getAccessKeyId());
      shared_ptr<string> accessKeySecret =
          make_shared<string>(_credential->getAccessKeySecret());
      shared_ptr<string> token =
          make_shared<string>(_credential->getSecurityToken());
      request_->protocol = *_protocol;
      request_->method = "DELETE";
      request_->pathname = string("/" + *request->objectName + "?tagging");
      request_->headers = {
          {"host", Alibabacloud_OSSUtil::Client::getHost(
                       request->bucketName, _regionId, _endpoint, _hostModel)},
          {"date", Darabonba_Util::Client::getDateUTCString()},
          {"user-agent", getUserAgent()}};
      if (!Darabonba_Util::Client::empty(token)) {
        request_->headers.insert(
            pair<string, string>("x-oss-security-token", *token));
      }
      request_->headers.insert(pair<string, string>(
          "authorization",
          Alibabacloud_OSSUtil::Client::getSignature(
              request_, request->bucketName, accessKeyId, accessKeySecret,
              _signatureVersion, _addtionalHeaders)));
      _lastRequest = request_;
      shared_ptr<Darabonba::Response> response_ =
          make_shared<Darabonba::Response>(
              Darabonba::Core::doAction(request_, runtime_));
      shared_ptr<map<string, boost::any>> respMap;
      shared_ptr<string> bodyStr;
      if (Darabonba_Util::Client::is4xx(
              make_shared<int>(response_->statusCode)) ||
          Darabonba_Util::Client::is5xx(
              make_shared<int>(response_->statusCode))) {
        bodyStr = make_shared<string>(
            Darabonba_Util::Client::readAsString(response_->body));
        respMap = make_shared<map<string, boost::any>>(
            Alibabacloud_OSSUtil::Client::getErrMessage(bodyStr));
        BOOST_THROW_EXCEPTION(Darabonba::Error(map<string, boost::any>(
            {{"code", (*respMap)["Code"]},
             {"message", (*respMap)["Message"]},
             {"data", boost::any(map<string, boost::any>(
                          {{"httpCode", boost::any(response_->statusCode)},
                           {"requestId", (*respMap)["RequestId"]},
                           {"hostId", (*respMap)["HostId"]}}))}})));
      }
      return DeleteObjectTaggingResponse(
          Darabonba::Converter::toGenericMap(Darabonba::Converter::merge(
              map<string, string>(), response_->headers)));
    } catch (std::exception &e) {
      if (Darabonba::Core::isRetryable(e)) {
        _lastException = make_shared<std::exception>(e);
        continue;
      }
      BOOST_THROW_EXCEPTION(e);
    }
  }
  BOOST_THROW_EXCEPTION(
      Darabonba::UnretryableError(_lastRequest, _lastException));
}

RestoreObjectResponse Alibabacloud_OSS::Client::restoreObject(
    shared_ptr<RestoreObjectRequest> request,
    shared_ptr<Alibabacloud_OSSUtil::RuntimeOptions> runtime) {
  request->validate();
  runtime->validate();
  shared_ptr<map<string, boost::any>> runtime_ = make_shared<
      map<string, boost::any>>(map<string, boost::any>(
      {{"timeouted", boost::any(string("retry"))},
       {"readTimeout", boost::any(Darabonba_Util::Client::defaultNumber(
                           runtime->readTimeout, _readTimeout))},
       {"connectTimeout", boost::any(Darabonba_Util::Client::defaultNumber(
                              runtime->connectTimeout, _connectTimeout))},
       {"localAddr", boost::any(string(Darabonba_Util::Client::defaultString(
                         runtime->localAddr, _localAddr)))},
       {"httpProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                         runtime->httpProxy, _httpProxy)))},
       {"httpsProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                          runtime->httpsProxy, _httpsProxy)))},
       {"noProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                       runtime->noProxy, _noProxy)))},
       {"socks5Proxy", boost::any(string(Darabonba_Util::Client::defaultString(
                           runtime->socks5Proxy, _socks5Proxy)))},
       {"socks5NetWork",
        boost::any(string(Darabonba_Util::Client::defaultString(
            runtime->socks5NetWork, _socks5NetWork)))},
       {"maxIdleConns", boost::any(Darabonba_Util::Client::defaultNumber(
                            runtime->maxIdleConns, _maxIdleConns))},
       {"retry", boost::any(map<string, boost::any>(
                     {{"retryable", !runtime->autoretry
                                        ? boost::any()
                                        : boost::any(*runtime->autoretry)},
                      {"maxAttempts",
                       boost::any(Darabonba_Util::Client::defaultNumber(
                           runtime->maxAttempts, make_shared<int>(3)))}}))},
       {"backoff",
        boost::any(map<string, boost::any>(
            {{"policy",
              boost::any(string(Darabonba_Util::Client::defaultString(
                  runtime->backoffPolicy, make_shared<string>("no"))))},
             {"period", boost::any(Darabonba_Util::Client::defaultNumber(
                            runtime->backoffPeriod, make_shared<int>(1)))}}))},
       {"ignoreSSL", !runtime->ignoreSSL ? boost::any()
                                         : boost::any(*runtime->ignoreSSL)}}));
  shared_ptr<Darabonba::Request> _lastRequest;
  shared_ptr<std::exception> _lastException;
  shared_ptr<int> _now = make_shared<int>(0);
  shared_ptr<int> _retryTimes = make_shared<int>(0);
  while (Darabonba::Core::allowRetry(
      make_shared<boost::any>((*runtime_)["retry"]), _retryTimes, _now)) {
    if (*_retryTimes > 0) {
      shared_ptr<int> _backoffTime =
          make_shared<int>(Darabonba::Core::getBackoffTime(
              make_shared<boost::any>((*runtime_)["backoff"]), _retryTimes));
      if (*_backoffTime > 0) {
        Darabonba::Core::sleep(_backoffTime);
      }
    }
    _retryTimes = make_shared<int>(*_retryTimes + 1);
    try {
      shared_ptr<Darabonba::Request> request_ =
          make_shared<Darabonba::Request>();
      shared_ptr<string> accessKeyId =
          make_shared<string>(_credential->getAccessKeyId());
      shared_ptr<string> accessKeySecret =
          make_shared<string>(_credential->getAccessKeySecret());
      shared_ptr<string> token =
          make_shared<string>(_credential->getSecurityToken());
      request_->protocol = *_protocol;
      request_->method = "POST";
      request_->pathname = string("/" + *request->objectName + "?restore");
      request_->headers = {
          {"host", Alibabacloud_OSSUtil::Client::getHost(
                       request->bucketName, _regionId, _endpoint, _hostModel)},
          {"date", Darabonba_Util::Client::getDateUTCString()},
          {"user-agent", getUserAgent()}};
      if (!Darabonba_Util::Client::empty(token)) {
        request_->headers.insert(
            pair<string, string>("x-oss-security-token", *token));
      }
      request_->headers.insert(pair<string, string>(
          "authorization",
          Alibabacloud_OSSUtil::Client::getSignature(
              request_, request->bucketName, accessKeyId, accessKeySecret,
              _signatureVersion, _addtionalHeaders)));
      _lastRequest = request_;
      shared_ptr<Darabonba::Response> response_ =
          make_shared<Darabonba::Response>(
              Darabonba::Core::doAction(request_, runtime_));
      shared_ptr<map<string, boost::any>> respMap;
      shared_ptr<string> bodyStr;
      if (Darabonba_Util::Client::is4xx(
              make_shared<int>(response_->statusCode)) ||
          Darabonba_Util::Client::is5xx(
              make_shared<int>(response_->statusCode))) {
        bodyStr = make_shared<string>(
            Darabonba_Util::Client::readAsString(response_->body));
        respMap = make_shared<map<string, boost::any>>(
            Alibabacloud_OSSUtil::Client::getErrMessage(bodyStr));
        BOOST_THROW_EXCEPTION(Darabonba::Error(map<string, boost::any>(
            {{"code", (*respMap)["Code"]},
             {"message", (*respMap)["Message"]},
             {"data", boost::any(map<string, boost::any>(
                          {{"httpCode", boost::any(response_->statusCode)},
                           {"requestId", (*respMap)["RequestId"]},
                           {"hostId", (*respMap)["HostId"]}}))}})));
      }
      return RestoreObjectResponse(
          Darabonba::Converter::toGenericMap(Darabonba::Converter::merge(
              map<string, string>(), response_->headers)));
    } catch (std::exception &e) {
      if (Darabonba::Core::isRetryable(e)) {
        _lastException = make_shared<std::exception>(e);
        continue;
      }
      BOOST_THROW_EXCEPTION(e);
    }
  }
  BOOST_THROW_EXCEPTION(
      Darabonba::UnretryableError(_lastRequest, _lastException));
}

GetObjectAclResponse Alibabacloud_OSS::Client::getObjectAcl(
    shared_ptr<GetObjectAclRequest> request,
    shared_ptr<Alibabacloud_OSSUtil::RuntimeOptions> runtime) {
  request->validate();
  runtime->validate();
  shared_ptr<map<string, boost::any>> runtime_ = make_shared<
      map<string, boost::any>>(map<string, boost::any>(
      {{"timeouted", boost::any(string("retry"))},
       {"readTimeout", boost::any(Darabonba_Util::Client::defaultNumber(
                           runtime->readTimeout, _readTimeout))},
       {"connectTimeout", boost::any(Darabonba_Util::Client::defaultNumber(
                              runtime->connectTimeout, _connectTimeout))},
       {"localAddr", boost::any(string(Darabonba_Util::Client::defaultString(
                         runtime->localAddr, _localAddr)))},
       {"httpProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                         runtime->httpProxy, _httpProxy)))},
       {"httpsProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                          runtime->httpsProxy, _httpsProxy)))},
       {"noProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                       runtime->noProxy, _noProxy)))},
       {"socks5Proxy", boost::any(string(Darabonba_Util::Client::defaultString(
                           runtime->socks5Proxy, _socks5Proxy)))},
       {"socks5NetWork",
        boost::any(string(Darabonba_Util::Client::defaultString(
            runtime->socks5NetWork, _socks5NetWork)))},
       {"maxIdleConns", boost::any(Darabonba_Util::Client::defaultNumber(
                            runtime->maxIdleConns, _maxIdleConns))},
       {"retry", boost::any(map<string, boost::any>(
                     {{"retryable", !runtime->autoretry
                                        ? boost::any()
                                        : boost::any(*runtime->autoretry)},
                      {"maxAttempts",
                       boost::any(Darabonba_Util::Client::defaultNumber(
                           runtime->maxAttempts, make_shared<int>(3)))}}))},
       {"backoff",
        boost::any(map<string, boost::any>(
            {{"policy",
              boost::any(string(Darabonba_Util::Client::defaultString(
                  runtime->backoffPolicy, make_shared<string>("no"))))},
             {"period", boost::any(Darabonba_Util::Client::defaultNumber(
                            runtime->backoffPeriod, make_shared<int>(1)))}}))},
       {"ignoreSSL", !runtime->ignoreSSL ? boost::any()
                                         : boost::any(*runtime->ignoreSSL)}}));
  shared_ptr<Darabonba::Request> _lastRequest;
  shared_ptr<std::exception> _lastException;
  shared_ptr<int> _now = make_shared<int>(0);
  shared_ptr<int> _retryTimes = make_shared<int>(0);
  while (Darabonba::Core::allowRetry(
      make_shared<boost::any>((*runtime_)["retry"]), _retryTimes, _now)) {
    if (*_retryTimes > 0) {
      shared_ptr<int> _backoffTime =
          make_shared<int>(Darabonba::Core::getBackoffTime(
              make_shared<boost::any>((*runtime_)["backoff"]), _retryTimes));
      if (*_backoffTime > 0) {
        Darabonba::Core::sleep(_backoffTime);
      }
    }
    _retryTimes = make_shared<int>(*_retryTimes + 1);
    try {
      shared_ptr<Darabonba::Request> request_ =
          make_shared<Darabonba::Request>();
      shared_ptr<string> accessKeyId =
          make_shared<string>(_credential->getAccessKeyId());
      shared_ptr<string> accessKeySecret =
          make_shared<string>(_credential->getAccessKeySecret());
      shared_ptr<string> token =
          make_shared<string>(_credential->getSecurityToken());
      request_->protocol = *_protocol;
      request_->method = "GET";
      request_->pathname = string("/" + *request->objectName + "?acl");
      request_->headers = {
          {"host", Alibabacloud_OSSUtil::Client::getHost(
                       request->bucketName, _regionId, _endpoint, _hostModel)},
          {"date", Darabonba_Util::Client::getDateUTCString()},
          {"user-agent", getUserAgent()}};
      if (!Darabonba_Util::Client::empty(token)) {
        request_->headers.insert(
            pair<string, string>("x-oss-security-token", *token));
      }
      request_->headers.insert(pair<string, string>(
          "authorization",
          Alibabacloud_OSSUtil::Client::getSignature(
              request_, request->bucketName, accessKeyId, accessKeySecret,
              _signatureVersion, _addtionalHeaders)));
      _lastRequest = request_;
      shared_ptr<Darabonba::Response> response_ =
          make_shared<Darabonba::Response>(
              Darabonba::Core::doAction(request_, runtime_));
      shared_ptr<map<string, boost::any>> respMap;
      shared_ptr<string> bodyStr;
      if (Darabonba_Util::Client::is4xx(
              make_shared<int>(response_->statusCode)) ||
          Darabonba_Util::Client::is5xx(
              make_shared<int>(response_->statusCode))) {
        bodyStr = make_shared<string>(
            Darabonba_Util::Client::readAsString(response_->body));
        respMap = make_shared<map<string, boost::any>>(
            Alibabacloud_OSSUtil::Client::getErrMessage(bodyStr));
        BOOST_THROW_EXCEPTION(Darabonba::Error(map<string, boost::any>(
            {{"code", (*respMap)["Code"]},
             {"message", (*respMap)["Message"]},
             {"data", boost::any(map<string, boost::any>(
                          {{"httpCode", boost::any(response_->statusCode)},
                           {"requestId", (*respMap)["RequestId"]},
                           {"hostId", (*respMap)["HostId"]}}))}})));
      }
      bodyStr = make_shared<string>(
          Darabonba_Util::Client::readAsString(response_->body));
      respMap = make_shared<map<string, boost::any>>(
          Darabonba_XML::Client::parseXml(bodyStr, nullptr));
      return GetObjectAclResponse(Darabonba::Converter::merge(
          map<string, boost::any>(
              {{"AccessControlPolicy", (*respMap)["AccessControlPolicy"]}}),
          Darabonba::Converter::toGenericMap(response_->headers)));
    } catch (std::exception &e) {
      if (Darabonba::Core::isRetryable(e)) {
        _lastException = make_shared<std::exception>(e);
        continue;
      }
      BOOST_THROW_EXCEPTION(e);
    }
  }
  BOOST_THROW_EXCEPTION(
      Darabonba::UnretryableError(_lastRequest, _lastException));
}

PutBucketAclResponse Alibabacloud_OSS::Client::putBucketAcl(
    shared_ptr<PutBucketAclRequest> request,
    shared_ptr<Alibabacloud_OSSUtil::RuntimeOptions> runtime) {
  request->validate();
  runtime->validate();
  shared_ptr<map<string, boost::any>> runtime_ = make_shared<
      map<string, boost::any>>(map<string, boost::any>(
      {{"timeouted", boost::any(string("retry"))},
       {"readTimeout", boost::any(Darabonba_Util::Client::defaultNumber(
                           runtime->readTimeout, _readTimeout))},
       {"connectTimeout", boost::any(Darabonba_Util::Client::defaultNumber(
                              runtime->connectTimeout, _connectTimeout))},
       {"localAddr", boost::any(string(Darabonba_Util::Client::defaultString(
                         runtime->localAddr, _localAddr)))},
       {"httpProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                         runtime->httpProxy, _httpProxy)))},
       {"httpsProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                          runtime->httpsProxy, _httpsProxy)))},
       {"noProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                       runtime->noProxy, _noProxy)))},
       {"socks5Proxy", boost::any(string(Darabonba_Util::Client::defaultString(
                           runtime->socks5Proxy, _socks5Proxy)))},
       {"socks5NetWork",
        boost::any(string(Darabonba_Util::Client::defaultString(
            runtime->socks5NetWork, _socks5NetWork)))},
       {"maxIdleConns", boost::any(Darabonba_Util::Client::defaultNumber(
                            runtime->maxIdleConns, _maxIdleConns))},
       {"retry", boost::any(map<string, boost::any>(
                     {{"retryable", !runtime->autoretry
                                        ? boost::any()
                                        : boost::any(*runtime->autoretry)},
                      {"maxAttempts",
                       boost::any(Darabonba_Util::Client::defaultNumber(
                           runtime->maxAttempts, make_shared<int>(3)))}}))},
       {"backoff",
        boost::any(map<string, boost::any>(
            {{"policy",
              boost::any(string(Darabonba_Util::Client::defaultString(
                  runtime->backoffPolicy, make_shared<string>("no"))))},
             {"period", boost::any(Darabonba_Util::Client::defaultNumber(
                            runtime->backoffPeriod, make_shared<int>(1)))}}))},
       {"ignoreSSL", !runtime->ignoreSSL ? boost::any()
                                         : boost::any(*runtime->ignoreSSL)}}));
  shared_ptr<Darabonba::Request> _lastRequest;
  shared_ptr<std::exception> _lastException;
  shared_ptr<int> _now = make_shared<int>(0);
  shared_ptr<int> _retryTimes = make_shared<int>(0);
  while (Darabonba::Core::allowRetry(
      make_shared<boost::any>((*runtime_)["retry"]), _retryTimes, _now)) {
    if (*_retryTimes > 0) {
      shared_ptr<int> _backoffTime =
          make_shared<int>(Darabonba::Core::getBackoffTime(
              make_shared<boost::any>((*runtime_)["backoff"]), _retryTimes));
      if (*_backoffTime > 0) {
        Darabonba::Core::sleep(_backoffTime);
      }
    }
    _retryTimes = make_shared<int>(*_retryTimes + 1);
    try {
      shared_ptr<Darabonba::Request> request_ =
          make_shared<Darabonba::Request>();
      shared_ptr<string> accessKeyId =
          make_shared<string>(_credential->getAccessKeyId());
      shared_ptr<string> accessKeySecret =
          make_shared<string>(_credential->getAccessKeySecret());
      shared_ptr<string> token =
          make_shared<string>(_credential->getSecurityToken());
      request_->protocol = *_protocol;
      request_->method = "PUT";
      request_->pathname = string("/?acl");
      request_->headers = Darabonba::Converter::merge(
          map<string, string>(
              {{"host",
                Alibabacloud_OSSUtil::Client::getHost(
                    request->bucketName, _regionId, _endpoint, _hostModel)},
               {"date", Darabonba_Util::Client::getDateUTCString()},
               {"user-agent", getUserAgent()}}),
          Darabonba_Util::Client::stringifyMapValue(
              make_shared<map<string, boost::any>>(request->header->toMap())));
      if (!Darabonba_Util::Client::empty(token)) {
        request_->headers.insert(
            pair<string, string>("x-oss-security-token", *token));
      }
      request_->headers.insert(pair<string, string>(
          "authorization",
          Alibabacloud_OSSUtil::Client::getSignature(
              request_, request->bucketName, accessKeyId, accessKeySecret,
              _signatureVersion, _addtionalHeaders)));
      _lastRequest = request_;
      shared_ptr<Darabonba::Response> response_ =
          make_shared<Darabonba::Response>(
              Darabonba::Core::doAction(request_, runtime_));
      shared_ptr<map<string, boost::any>> respMap;
      shared_ptr<string> bodyStr;
      if (Darabonba_Util::Client::is4xx(
              make_shared<int>(response_->statusCode)) ||
          Darabonba_Util::Client::is5xx(
              make_shared<int>(response_->statusCode))) {
        bodyStr = make_shared<string>(
            Darabonba_Util::Client::readAsString(response_->body));
        respMap = make_shared<map<string, boost::any>>(
            Alibabacloud_OSSUtil::Client::getErrMessage(bodyStr));
        BOOST_THROW_EXCEPTION(Darabonba::Error(map<string, boost::any>(
            {{"code", (*respMap)["Code"]},
             {"message", (*respMap)["Message"]},
             {"data", boost::any(map<string, boost::any>(
                          {{"httpCode", boost::any(response_->statusCode)},
                           {"requestId", (*respMap)["RequestId"]},
                           {"hostId", (*respMap)["HostId"]}}))}})));
      }
      return PutBucketAclResponse(
          Darabonba::Converter::toGenericMap(Darabonba::Converter::merge(
              map<string, string>(), response_->headers)));
    } catch (std::exception &e) {
      if (Darabonba::Core::isRetryable(e)) {
        _lastException = make_shared<std::exception>(e);
        continue;
      }
      BOOST_THROW_EXCEPTION(e);
    }
  }
  BOOST_THROW_EXCEPTION(
      Darabonba::UnretryableError(_lastRequest, _lastException));
}

DeleteBucketResponse Alibabacloud_OSS::Client::deleteBucket(
    shared_ptr<DeleteBucketRequest> request,
    shared_ptr<Alibabacloud_OSSUtil::RuntimeOptions> runtime) {
  request->validate();
  runtime->validate();
  shared_ptr<map<string, boost::any>> runtime_ = make_shared<
      map<string, boost::any>>(map<string, boost::any>(
      {{"timeouted", boost::any(string("retry"))},
       {"readTimeout", boost::any(Darabonba_Util::Client::defaultNumber(
                           runtime->readTimeout, _readTimeout))},
       {"connectTimeout", boost::any(Darabonba_Util::Client::defaultNumber(
                              runtime->connectTimeout, _connectTimeout))},
       {"localAddr", boost::any(string(Darabonba_Util::Client::defaultString(
                         runtime->localAddr, _localAddr)))},
       {"httpProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                         runtime->httpProxy, _httpProxy)))},
       {"httpsProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                          runtime->httpsProxy, _httpsProxy)))},
       {"noProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                       runtime->noProxy, _noProxy)))},
       {"socks5Proxy", boost::any(string(Darabonba_Util::Client::defaultString(
                           runtime->socks5Proxy, _socks5Proxy)))},
       {"socks5NetWork",
        boost::any(string(Darabonba_Util::Client::defaultString(
            runtime->socks5NetWork, _socks5NetWork)))},
       {"maxIdleConns", boost::any(Darabonba_Util::Client::defaultNumber(
                            runtime->maxIdleConns, _maxIdleConns))},
       {"retry", boost::any(map<string, boost::any>(
                     {{"retryable", !runtime->autoretry
                                        ? boost::any()
                                        : boost::any(*runtime->autoretry)},
                      {"maxAttempts",
                       boost::any(Darabonba_Util::Client::defaultNumber(
                           runtime->maxAttempts, make_shared<int>(3)))}}))},
       {"backoff",
        boost::any(map<string, boost::any>(
            {{"policy",
              boost::any(string(Darabonba_Util::Client::defaultString(
                  runtime->backoffPolicy, make_shared<string>("no"))))},
             {"period", boost::any(Darabonba_Util::Client::defaultNumber(
                            runtime->backoffPeriod, make_shared<int>(1)))}}))},
       {"ignoreSSL", !runtime->ignoreSSL ? boost::any()
                                         : boost::any(*runtime->ignoreSSL)}}));
  shared_ptr<Darabonba::Request> _lastRequest;
  shared_ptr<std::exception> _lastException;
  shared_ptr<int> _now = make_shared<int>(0);
  shared_ptr<int> _retryTimes = make_shared<int>(0);
  while (Darabonba::Core::allowRetry(
      make_shared<boost::any>((*runtime_)["retry"]), _retryTimes, _now)) {
    if (*_retryTimes > 0) {
      shared_ptr<int> _backoffTime =
          make_shared<int>(Darabonba::Core::getBackoffTime(
              make_shared<boost::any>((*runtime_)["backoff"]), _retryTimes));
      if (*_backoffTime > 0) {
        Darabonba::Core::sleep(_backoffTime);
      }
    }
    _retryTimes = make_shared<int>(*_retryTimes + 1);
    try {
      shared_ptr<Darabonba::Request> request_ =
          make_shared<Darabonba::Request>();
      shared_ptr<string> accessKeyId =
          make_shared<string>(_credential->getAccessKeyId());
      shared_ptr<string> accessKeySecret =
          make_shared<string>(_credential->getAccessKeySecret());
      shared_ptr<string> token =
          make_shared<string>(_credential->getSecurityToken());
      request_->protocol = *_protocol;
      request_->method = "DELETE";
      request_->pathname = string("/");
      request_->headers = {
          {"host", Alibabacloud_OSSUtil::Client::getHost(
                       request->bucketName, _regionId, _endpoint, _hostModel)},
          {"date", Darabonba_Util::Client::getDateUTCString()},
          {"user-agent", getUserAgent()}};
      if (!Darabonba_Util::Client::empty(token)) {
        request_->headers.insert(
            pair<string, string>("x-oss-security-token", *token));
      }
      request_->headers.insert(pair<string, string>(
          "authorization",
          Alibabacloud_OSSUtil::Client::getSignature(
              request_, request->bucketName, accessKeyId, accessKeySecret,
              _signatureVersion, _addtionalHeaders)));
      _lastRequest = request_;
      shared_ptr<Darabonba::Response> response_ =
          make_shared<Darabonba::Response>(
              Darabonba::Core::doAction(request_, runtime_));
      shared_ptr<map<string, boost::any>> respMap;
      shared_ptr<string> bodyStr;
      if (Darabonba_Util::Client::is4xx(
              make_shared<int>(response_->statusCode)) ||
          Darabonba_Util::Client::is5xx(
              make_shared<int>(response_->statusCode))) {
        bodyStr = make_shared<string>(
            Darabonba_Util::Client::readAsString(response_->body));
        respMap = make_shared<map<string, boost::any>>(
            Alibabacloud_OSSUtil::Client::getErrMessage(bodyStr));
        BOOST_THROW_EXCEPTION(Darabonba::Error(map<string, boost::any>(
            {{"code", (*respMap)["Code"]},
             {"message", (*respMap)["Message"]},
             {"data", boost::any(map<string, boost::any>(
                          {{"httpCode", boost::any(response_->statusCode)},
                           {"requestId", (*respMap)["RequestId"]},
                           {"hostId", (*respMap)["HostId"]}}))}})));
      }
      return DeleteBucketResponse(
          Darabonba::Converter::toGenericMap(Darabonba::Converter::merge(
              map<string, string>(), response_->headers)));
    } catch (std::exception &e) {
      if (Darabonba::Core::isRetryable(e)) {
        _lastException = make_shared<std::exception>(e);
        continue;
      }
      BOOST_THROW_EXCEPTION(e);
    }
  }
  BOOST_THROW_EXCEPTION(
      Darabonba::UnretryableError(_lastRequest, _lastException));
}

PutObjectResponse Alibabacloud_OSS::Client::putObject(
    shared_ptr<PutObjectRequest> request,
    shared_ptr<Alibabacloud_OSSUtil::RuntimeOptions> runtime) {
  request->validate();
  runtime->validate();
  shared_ptr<map<string, boost::any>> runtime_ = make_shared<
      map<string, boost::any>>(map<string, boost::any>(
      {{"timeouted", boost::any(string("retry"))},
       {"readTimeout", boost::any(Darabonba_Util::Client::defaultNumber(
                           runtime->readTimeout, _readTimeout))},
       {"connectTimeout", boost::any(Darabonba_Util::Client::defaultNumber(
                              runtime->connectTimeout, _connectTimeout))},
       {"localAddr", boost::any(string(Darabonba_Util::Client::defaultString(
                         runtime->localAddr, _localAddr)))},
       {"httpProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                         runtime->httpProxy, _httpProxy)))},
       {"httpsProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                          runtime->httpsProxy, _httpsProxy)))},
       {"noProxy", boost::any(string(Darabonba_Util::Client::defaultString(
                       runtime->noProxy, _noProxy)))},
       {"socks5Proxy", boost::any(string(Darabonba_Util::Client::defaultString(
                           runtime->socks5Proxy, _socks5Proxy)))},
       {"socks5NetWork",
        boost::any(string(Darabonba_Util::Client::defaultString(
            runtime->socks5NetWork, _socks5NetWork)))},
       {"maxIdleConns", boost::any(Darabonba_Util::Client::defaultNumber(
                            runtime->maxIdleConns, _maxIdleConns))},
       {"retry", boost::any(map<string, boost::any>(
                     {{"retryable", !runtime->autoretry
                                        ? boost::any()
                                        : boost::any(*runtime->autoretry)},
                      {"maxAttempts",
                       boost::any(Darabonba_Util::Client::defaultNumber(
                           runtime->maxAttempts, make_shared<int>(3)))}}))},
       {"backoff",
        boost::any(map<string, boost::any>(
            {{"policy",
              boost::any(string(Darabonba_Util::Client::defaultString(
                  runtime->backoffPolicy, make_shared<string>("no"))))},
             {"period", boost::any(Darabonba_Util::Client::defaultNumber(
                            runtime->backoffPeriod, make_shared<int>(1)))}}))},
       {"ignoreSSL", !runtime->ignoreSSL ? boost::any()
                                         : boost::any(*runtime->ignoreSSL)}}));
  shared_ptr<Darabonba::Request> _lastRequest;
  shared_ptr<std::exception> _lastException;
  shared_ptr<int> _now = make_shared<int>(0);
  shared_ptr<int> _retryTimes = make_shared<int>(0);
  while (Darabonba::Core::allowRetry(
      make_shared<boost::any>((*runtime_)["retry"]), _retryTimes, _now)) {
    if (*_retryTimes > 0) {
      shared_ptr<int> _backoffTime =
          make_shared<int>(Darabonba::Core::getBackoffTime(
              make_shared<boost::any>((*runtime_)["backoff"]), _retryTimes));
      if (*_backoffTime > 0) {
        Darabonba::Core::sleep(_backoffTime);
      }
    }
    _retryTimes = make_shared<int>(*_retryTimes + 1);
    try {
      shared_ptr<Darabonba::Request> request_ =
          make_shared<Darabonba::Request>();
      shared_ptr<map<string, string>> ctx =
          make_shared<map<string, string>>(map<string, string>());
      shared_ptr<string> accessKeyId =
          make_shared<string>(_credential->getAccessKeyId());
      shared_ptr<string> accessKeySecret =
          make_shared<string>(_credential->getAccessKeySecret());
      shared_ptr<string> token =
          make_shared<string>(_credential->getSecurityToken());
      request_->protocol = *_protocol;
      request_->method = "PUT";
      request_->pathname = string("/" + *request->objectName + "");
      request_->headers = Darabonba::Converter::merge(
          map<string, string>(
              {{"host",
                Alibabacloud_OSSUtil::Client::getHost(
                    request->bucketName, _regionId, _endpoint, _hostModel)},
               {"date", Darabonba_Util::Client::getDateUTCString()},
               {"user-agent", getUserAgent()}}),
          Darabonba_Util::Client::stringifyMapValue(
              make_shared<map<string, boost::any>>(request->header->toMap())),
          Alibabacloud_OSSUtil::Client::parseMeta(
              request->userMeta, make_shared<string>("x-oss-meta-")));
      if (!Darabonba_Util::Client::empty(token)) {
        request_->headers.insert(
            pair<string, string>("x-oss-security-token", *token));
      }
      request_->body = Alibabacloud_OSSUtil::Client::inject(request->body, ctx);
      if (!Darabonba_Util::Client::isUnset<PutObjectRequestHeader>(
              request->header) &&
          !Darabonba_Util::Client::empty(request->header->contentType)) {
        request_->headers.insert(pair<string, string>(
            "content-type", *request->header->contentType));
      } else {
        request_->headers.insert(pair<string, string>(
            "content-type",
            Alibabacloud_OSSUtil::Client::getContentType(request->objectName)));
      }
      request_->headers.insert(pair<string, string>(
          "authorization",
          Alibabacloud_OSSUtil::Client::getSignature(
              request_, request->bucketName, accessKeyId, accessKeySecret,
              _signatureVersion, _addtionalHeaders)));
      _lastRequest = request_;
      shared_ptr<Darabonba::Response> response_ =
          make_shared<Darabonba::Response>(
              Darabonba::Core::doAction(request_, runtime_));
      shared_ptr<map<string, boost::any>> respMap;
      shared_ptr<string> bodyStr;
      if (Darabonba_Util::Client::is4xx(
              make_shared<int>(response_->statusCode)) ||
          Darabonba_Util::Client::is5xx(
              make_shared<int>(response_->statusCode))) {
        bodyStr = make_shared<string>(
            Darabonba_Util::Client::readAsString(response_->body));
        respMap = make_shared<map<string, boost::any>>(
            Alibabacloud_OSSUtil::Client::getErrMessage(bodyStr));
        BOOST_THROW_EXCEPTION(Darabonba::Error(map<string, boost::any>(
            {{"code", (*respMap)["Code"]},
             {"message", (*respMap)["Message"]},
             {"data", boost::any(map<string, boost::any>(
                          {{"httpCode", boost::any(response_->statusCode)},
                           {"requestId", (*respMap)["RequestId"]},
                           {"hostId", (*respMap)["HostId"]}}))}})));
      }
      if (*_isEnableCrc &&
          !Darabonba_Util::Client::equalString(
              make_shared<string>((*ctx)["crc"]),
              make_shared<string>(
                  response_->headers["x-oss-hash-crc64ecma"]))) {
        BOOST_THROW_EXCEPTION(Darabonba::Error(map<string, boost::any>(
            {{"code", boost::any(string("CrcNotMatched"))},
             {"data", boost::any(map<string, string>(
                          {{"clientCrc", (*ctx)["crc"]},
                           {"serverCrc",
                            response_->headers["x-oss-hash-crc64ecma"]}}))}})));
      }
      if (*_isEnableMD5 &&
          !Darabonba_Util::Client::equalString(
              make_shared<string>((*ctx)["md5"]),
              make_shared<string>(response_->headers["content-md5"]))) {
        BOOST_THROW_EXCEPTION(Darabonba::Error(map<string, boost::any>(
            {{"code", boost::any(string("MD5NotMatched"))},
             {"data",
              boost::any(map<string, string>(
                  {{"clientMD5", (*ctx)["md5"]},
                   {"serverMD5", response_->headers["content-md5"]}}))}})));
      }
      return PutObjectResponse(
          Darabonba::Converter::toGenericMap(Darabonba::Converter::merge(
              map<string, string>(), response_->headers)));
    } catch (std::exception &e) {
      if (Darabonba::Core::isRetryable(e)) {
        _lastException = make_shared<std::exception>(e);
        continue;
      }
      BOOST_THROW_EXCEPTION(e);
    }
  }
  BOOST_THROW_EXCEPTION(
      Darabonba::UnretryableError(_lastRequest, _lastException));
}

void Alibabacloud_OSS::Client::setUserAgent(shared_ptr<string> userAgent) {
  _userAgent = userAgent;
}

void Alibabacloud_OSS::Client::appendUserAgent(shared_ptr<string> userAgent) {
  _userAgent =
      make_shared<string>(string("" + *_userAgent + " " + *userAgent + ""));
}

string Alibabacloud_OSS::Client::getUserAgent() {
  shared_ptr<string> userAgent =
      make_shared<string>(Darabonba_Util::Client::getUserAgent(_userAgent));
  return *userAgent;
}

string Alibabacloud_OSS::Client::getAccessKeyId() {
  if (Darabonba_Util::Client::isUnset<Alibabacloud_Credential::Client>(
          _credential)) {
    return string("");
  }
  shared_ptr<string> accessKeyId =
      make_shared<string>(_credential->getAccessKeyId());
  return *accessKeyId;
}

string Alibabacloud_OSS::Client::getAccessKeySecret() {
  if (Darabonba_Util::Client::isUnset<Alibabacloud_Credential::Client>(
          _credential)) {
    return string("");
  }
  shared_ptr<string> secret =
      make_shared<string>(_credential->getAccessKeySecret());
  return *secret;
}
