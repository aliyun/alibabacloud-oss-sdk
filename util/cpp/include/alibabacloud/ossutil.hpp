// This file is auto-generated, don't edit it. Thanks.

#ifndef ALIBABACLOUD_OSSUTIL_H_
#define ALIBABACLOUD_OSSUTIL_H_

#include <boost/any.hpp>
#include <darabonba/core.hpp>
#include <iostream>
#include <map>
#include <vector>

using namespace std;

namespace Alibabacloud_OSSUtil {
class RuntimeOptions : public Darabonba::Model {
protected:
  void _init(){
    _name = map<string, string>({
      {"autoretry" , "autoretry"},
      {"ignoreSSL" , "ignoreSSL"},
      {"maxAttempts" , "maxAttempts"},
      {"backoffPolicy" , "backoffPolicy"},
      {"backoffPeriod" , "backoffPeriod"},
      {"readTimeout" , "readTimeout"},
      {"connectTimeout" , "connectTimeout"},
      {"localAddr" , "localAddr"},
      {"httpProxy" , "httpProxy"},
      {"httpsProxy" , "httpsProxy"},
      {"noProxy" , "noProxy"},
      {"maxIdleConns" , "maxIdleConns"},
      {"socks5Proxy" , "socks5Proxy"},
      {"socks5NetWork" , "socks5NetWork"},
      {"uploadLimitSpeed" , "uploadLimitSpeed"},
      {"listener" , "listener"},
    });
  }
public:
  RuntimeOptions() {_init();};
  explicit RuntimeOptions(const std::map<string, boost::any> &config) : Darabonba::Model(config) {_init();};


  map<string, boost::any> toMap() {
    map<string, boost::any> res;
    if (nullptr != autoretry) {
      res["autoretry"] = boost::any(*autoretry);
    }
    if (nullptr != ignoreSSL) {
      res["ignoreSSL"] = boost::any(*ignoreSSL);
    }
    if (nullptr != maxAttempts) {
      res["maxAttempts"] = boost::any(*maxAttempts);
    }
    if (nullptr != backoffPolicy) {
      res["backoffPolicy"] = boost::any(*backoffPolicy);
    }
    if (nullptr != backoffPeriod) {
      res["backoffPeriod"] = boost::any(*backoffPeriod);
    }
    if (nullptr != readTimeout) {
      res["readTimeout"] = boost::any(*readTimeout);
    }
    if (nullptr != connectTimeout) {
      res["connectTimeout"] = boost::any(*connectTimeout);
    }
    if (nullptr != localAddr) {
      res["localAddr"] = boost::any(*localAddr);
    }
    if (nullptr != httpProxy) {
      res["httpProxy"] = boost::any(*httpProxy);
    }
    if (nullptr != httpsProxy) {
      res["httpsProxy"] = boost::any(*httpsProxy);
    }
    if (nullptr != noProxy) {
      res["noProxy"] = boost::any(*noProxy);
    }
    if (nullptr != maxIdleConns) {
      res["maxIdleConns"] = boost::any(*maxIdleConns);
    }
    if (nullptr != socks5Proxy) {
      res["socks5Proxy"] = boost::any(*socks5Proxy);
    }
    if (nullptr != socks5NetWork) {
      res["socks5NetWork"] = boost::any(*socks5NetWork);
    }
    if (nullptr != uploadLimitSpeed) {
      res["uploadLimitSpeed"] = boost::any(*uploadLimitSpeed);
    }
    if (nullptr != listener) {
      res["listener"] = boost::any(*listener);
    }
    return res;
  }

  shared_ptr<bool> autoretry{};
  shared_ptr<bool> ignoreSSL{};
  shared_ptr<int> maxAttempts{};
  shared_ptr<string> backoffPolicy{};
  shared_ptr<int> backoffPeriod{};
  shared_ptr<int> readTimeout{};
  shared_ptr<int> connectTimeout{};
  shared_ptr<string> localAddr{};
  shared_ptr<string> httpProxy{};
  shared_ptr<string> httpsProxy{};
  shared_ptr<string> noProxy{};
  shared_ptr<int> maxIdleConns{};
  shared_ptr<string> socks5Proxy{};
  shared_ptr<string> socks5NetWork{};
  shared_ptr<int> uploadLimitSpeed{};
  shared_ptr<boost::any> listener{};

  ~RuntimeOptions() {};
};

/////////////////////////////

class VerifyStream: public Darabonba::Stream{
public:
  VerifyStream()= default;
  VerifyStream(shared_ptr<Darabonba::Stream> stream,
               shared_ptr<map<string, string>> ctx) {
    _stream = stream;
    _ctx = ctx;
  }

  string read() override;

private:
  shared_ptr<Darabonba::Stream> _stream;
  shared_ptr<map<string, string>> _ctx;
};

/////////////////////////////

class Client {
public:
  static map<string, boost::any> getErrMessage(shared_ptr<string> msg);
  static map<string, string> toMeta(const shared_ptr<map<string, string>>& val, const shared_ptr<string>& prefix);
  static map<string, string> parseMeta(const shared_ptr<map<string, string>>& val, const shared_ptr<string>& prefix);
  static string getContentType(const shared_ptr<string>& fileName);
  static string getContentMD5(const shared_ptr<string>& body, const shared_ptr<bool>& isEnableMD5);
  static string encode(const shared_ptr<string>& val, const shared_ptr<string>& encodeType);
  static string getHost(const shared_ptr<string>& bucketName,
                        shared_ptr<string> regionId,
                        shared_ptr<string> endpoint,
                        const shared_ptr<string>& hostModel);
  static shared_ptr<VerifyStream> inject(const shared_ptr<Darabonba::Stream>& body,
                             const shared_ptr<map<string, string>>& res);
  static string getSignature(const shared_ptr<Darabonba::Request>& request,
                             const shared_ptr<string>& bucketName,
                             const shared_ptr<string>& accessKeyId,
                             const shared_ptr<string>& accessKeySecret,
                             const shared_ptr<string>& signatureVersion,
                             const shared_ptr<vector<string>>& addtionalHeaders);
  static string decode(const shared_ptr<string>& val, shared_ptr<string> decodeType);

  Client() {};
  ~Client() {};
};
} // namespace Alibabacloud_OSSUtil

#endif
