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
public:
  RuntimeOptions() {}
  explicit RuntimeOptions(const std::map<string, boost::any> &config) : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {}

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (autoretry) {
      res["autoretry"] = boost::any(*autoretry);
    }
    if (ignoreSSL) {
      res["ignoreSSL"] = boost::any(*ignoreSSL);
    }
    if (maxAttempts) {
      res["maxAttempts"] = boost::any(*maxAttempts);
    }
    if (backoffPolicy) {
      res["backoffPolicy"] = boost::any(*backoffPolicy);
    }
    if (backoffPeriod) {
      res["backoffPeriod"] = boost::any(*backoffPeriod);
    }
    if (readTimeout) {
      res["readTimeout"] = boost::any(*readTimeout);
    }
    if (connectTimeout) {
      res["connectTimeout"] = boost::any(*connectTimeout);
    }
    if (localAddr) {
      res["localAddr"] = boost::any(*localAddr);
    }
    if (httpProxy) {
      res["httpProxy"] = boost::any(*httpProxy);
    }
    if (httpsProxy) {
      res["httpsProxy"] = boost::any(*httpsProxy);
    }
    if (noProxy) {
      res["noProxy"] = boost::any(*noProxy);
    }
    if (maxIdleConns) {
      res["maxIdleConns"] = boost::any(*maxIdleConns);
    }
    if (socks5Proxy) {
      res["socks5Proxy"] = boost::any(*socks5Proxy);
    }
    if (socks5NetWork) {
      res["socks5NetWork"] = boost::any(*socks5NetWork);
    }
    if (uploadLimitSpeed) {
      res["uploadLimitSpeed"] = boost::any(*uploadLimitSpeed);
    }
    if (listener) {
      res["listener"] = boost::any(*listener);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("autoretry") != m.end()) {
      autoretry = make_shared<bool>(boost::any_cast<bool>(m["autoretry"]));
    }
    if (m.find("ignoreSSL") != m.end()) {
      ignoreSSL = make_shared<bool>(boost::any_cast<bool>(m["ignoreSSL"]));
    }
    if (m.find("maxAttempts") != m.end()) {
      maxAttempts = make_shared<int>(boost::any_cast<int>(m["maxAttempts"]));
    }
    if (m.find("backoffPolicy") != m.end()) {
      backoffPolicy = make_shared<string>(boost::any_cast<string>(m["backoffPolicy"]));
    }
    if (m.find("backoffPeriod") != m.end()) {
      backoffPeriod = make_shared<int>(boost::any_cast<int>(m["backoffPeriod"]));
    }
    if (m.find("readTimeout") != m.end()) {
      readTimeout = make_shared<int>(boost::any_cast<int>(m["readTimeout"]));
    }
    if (m.find("connectTimeout") != m.end()) {
      connectTimeout = make_shared<int>(boost::any_cast<int>(m["connectTimeout"]));
    }
    if (m.find("localAddr") != m.end()) {
      localAddr = make_shared<string>(boost::any_cast<string>(m["localAddr"]));
    }
    if (m.find("httpProxy") != m.end()) {
      httpProxy = make_shared<string>(boost::any_cast<string>(m["httpProxy"]));
    }
    if (m.find("httpsProxy") != m.end()) {
      httpsProxy = make_shared<string>(boost::any_cast<string>(m["httpsProxy"]));
    }
    if (m.find("noProxy") != m.end()) {
      noProxy = make_shared<string>(boost::any_cast<string>(m["noProxy"]));
    }
    if (m.find("maxIdleConns") != m.end()) {
      maxIdleConns = make_shared<int>(boost::any_cast<int>(m["maxIdleConns"]));
    }
    if (m.find("socks5Proxy") != m.end()) {
      socks5Proxy = make_shared<string>(boost::any_cast<string>(m["socks5Proxy"]));
    }
    if (m.find("socks5NetWork") != m.end()) {
      socks5NetWork = make_shared<string>(boost::any_cast<string>(m["socks5NetWork"]));
    }
    if (m.find("uploadLimitSpeed") != m.end()) {
      uploadLimitSpeed = make_shared<int>(boost::any_cast<int>(m["uploadLimitSpeed"]));
    }
    if (m.find("listener") != m.end()) {
      listener = make_shared<boost::any>(boost::any_cast<boost::any>(m["listener"]));
    }
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

  ~RuntimeOptions() = default;
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

  bool empty() override;
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
