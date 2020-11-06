// This file is auto-generated, don't edit it. Thanks.

#ifndef ALIBABACLOUD_OSS_H_
#define ALIBABACLOUD_OSS_H_

#include <alibabacloud/credential.hpp>
#include <alibabacloud/ossutil.hpp>
#include <boost/throw_exception.hpp>
#include <darabonba/core.hpp>
#include <darabonba/file_form.hpp>
#include <darabonba/util.hpp>
#include <darabonba/xml.hpp>
#include <iostream>
#include <map>
#include <vector>

using namespace std;

namespace Alibabacloud_OSS {
class Config : public Darabonba::Model {
public:
  Config() {}
  explicit Config(const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!accessKeyId) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("accessKeyId is required.")));
    }
    if (!accessKeySecret) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("accessKeySecret is required.")));
    }
    Darabonba::Model::validatePattern("regionId", regionId,
                                      "[a-zA-Z0-9\\\\-\\\\_]+");
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (type) {
      res["type"] = boost::any(*type);
    }
    if (securityToken) {
      res["securityToken"] = boost::any(*securityToken);
    }
    if (accessKeyId) {
      res["accessKeyId"] = boost::any(*accessKeyId);
    }
    if (accessKeySecret) {
      res["accessKeySecret"] = boost::any(*accessKeySecret);
    }
    if (endpoint) {
      res["endpoint"] = boost::any(*endpoint);
    }
    if (protocol) {
      res["protocol"] = boost::any(*protocol);
    }
    if (regionId) {
      res["regionId"] = boost::any(*regionId);
    }
    if (userAgent) {
      res["userAgent"] = boost::any(*userAgent);
    }
    if (hostModel) {
      res["hostModel"] = boost::any(*hostModel);
    }
    if (signatureVersion) {
      res["signatureVersion"] = boost::any(*signatureVersion);
    }
    if (isEnableMD5) {
      res["isEnableMD5"] = boost::any(*isEnableMD5);
    }
    if (isEnableCrc) {
      res["isEnableCrc"] = boost::any(*isEnableCrc);
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
    if (socks5Proxy) {
      res["socks5Proxy"] = boost::any(*socks5Proxy);
    }
    if (socks5NetWork) {
      res["socks5NetWork"] = boost::any(*socks5NetWork);
    }
    if (maxIdleConns) {
      res["maxIdleConns"] = boost::any(*maxIdleConns);
    }
    if (addtionalHeaders) {
      res["addtionalHeaders"] = boost::any(*addtionalHeaders);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("type") != m.end()) {
      type = make_shared<string>(boost::any_cast<string>(m["type"]));
    }
    if (m.find("securityToken") != m.end()) {
      securityToken =
          make_shared<string>(boost::any_cast<string>(m["securityToken"]));
    }
    if (m.find("accessKeyId") != m.end()) {
      accessKeyId =
          make_shared<string>(boost::any_cast<string>(m["accessKeyId"]));
    }
    if (m.find("accessKeySecret") != m.end()) {
      accessKeySecret =
          make_shared<string>(boost::any_cast<string>(m["accessKeySecret"]));
    }
    if (m.find("endpoint") != m.end()) {
      endpoint = make_shared<string>(boost::any_cast<string>(m["endpoint"]));
    }
    if (m.find("protocol") != m.end()) {
      protocol = make_shared<string>(boost::any_cast<string>(m["protocol"]));
    }
    if (m.find("regionId") != m.end()) {
      regionId = make_shared<string>(boost::any_cast<string>(m["regionId"]));
    }
    if (m.find("userAgent") != m.end()) {
      userAgent = make_shared<string>(boost::any_cast<string>(m["userAgent"]));
    }
    if (m.find("hostModel") != m.end()) {
      hostModel = make_shared<string>(boost::any_cast<string>(m["hostModel"]));
    }
    if (m.find("signatureVersion") != m.end()) {
      signatureVersion =
          make_shared<string>(boost::any_cast<string>(m["signatureVersion"]));
    }
    if (m.find("isEnableMD5") != m.end()) {
      isEnableMD5 = make_shared<bool>(boost::any_cast<bool>(m["isEnableMD5"]));
    }
    if (m.find("isEnableCrc") != m.end()) {
      isEnableCrc = make_shared<bool>(boost::any_cast<bool>(m["isEnableCrc"]));
    }
    if (m.find("readTimeout") != m.end()) {
      readTimeout = make_shared<int>(boost::any_cast<int>(m["readTimeout"]));
    }
    if (m.find("connectTimeout") != m.end()) {
      connectTimeout =
          make_shared<int>(boost::any_cast<int>(m["connectTimeout"]));
    }
    if (m.find("localAddr") != m.end()) {
      localAddr = make_shared<string>(boost::any_cast<string>(m["localAddr"]));
    }
    if (m.find("httpProxy") != m.end()) {
      httpProxy = make_shared<string>(boost::any_cast<string>(m["httpProxy"]));
    }
    if (m.find("httpsProxy") != m.end()) {
      httpsProxy =
          make_shared<string>(boost::any_cast<string>(m["httpsProxy"]));
    }
    if (m.find("noProxy") != m.end()) {
      noProxy = make_shared<string>(boost::any_cast<string>(m["noProxy"]));
    }
    if (m.find("socks5Proxy") != m.end()) {
      socks5Proxy =
          make_shared<string>(boost::any_cast<string>(m["socks5Proxy"]));
    }
    if (m.find("socks5NetWork") != m.end()) {
      socks5NetWork =
          make_shared<string>(boost::any_cast<string>(m["socks5NetWork"]));
    }
    if (m.find("maxIdleConns") != m.end()) {
      maxIdleConns = make_shared<int>(boost::any_cast<int>(m["maxIdleConns"]));
    }
    if (m.find("addtionalHeaders") != m.end()) {
      vector<string> toVec1;
      if (typeid(vector<boost::any>).name() ==
          m["addtionalHeaders"].type().name()) {
        vector<boost::any> vec1 =
            boost::any_cast<vector<boost::any>>(m["addtionalHeaders"]);
        for (auto item : vec1) {
          toVec1.push_back(boost::any_cast<string>(item));
        }
      }
      addtionalHeaders = make_shared<vector<string>>(toVec1);
    }
  }

  shared_ptr<string> type{};
  shared_ptr<string> securityToken{};
  shared_ptr<string> accessKeyId{};
  shared_ptr<string> accessKeySecret{};
  shared_ptr<string> endpoint{};
  shared_ptr<string> protocol{};
  shared_ptr<string> regionId{};
  shared_ptr<string> userAgent{};
  shared_ptr<string> hostModel{};
  shared_ptr<string> signatureVersion{};
  shared_ptr<bool> isEnableMD5{};
  shared_ptr<bool> isEnableCrc{};
  shared_ptr<int> readTimeout{};
  shared_ptr<int> connectTimeout{};
  shared_ptr<string> localAddr{};
  shared_ptr<string> httpProxy{};
  shared_ptr<string> httpsProxy{};
  shared_ptr<string> noProxy{};
  shared_ptr<string> socks5Proxy{};
  shared_ptr<string> socks5NetWork{};
  shared_ptr<int> maxIdleConns{};
  shared_ptr<vector<string>> addtionalHeaders{};

  ~Config() = default;
};
class PutBucketLifecycleRequestBodyLifecycleConfigurationRuleExpiration
    : public Darabonba::Model {
public:
  PutBucketLifecycleRequestBodyLifecycleConfigurationRuleExpiration() {}
  explicit PutBucketLifecycleRequestBodyLifecycleConfigurationRuleExpiration(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {}

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (days) {
      res["Days"] = boost::any(*days);
    }
    if (createdBeforeDate) {
      res["CreatedBeforeDate"] = boost::any(*createdBeforeDate);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("Days") != m.end()) {
      days = make_shared<int>(boost::any_cast<int>(m["Days"]));
    }
    if (m.find("CreatedBeforeDate") != m.end()) {
      createdBeforeDate =
          make_shared<string>(boost::any_cast<string>(m["CreatedBeforeDate"]));
    }
  }

  shared_ptr<int> days{};
  shared_ptr<string> createdBeforeDate{};

  ~PutBucketLifecycleRequestBodyLifecycleConfigurationRuleExpiration() =
      default;
};
class PutBucketLifecycleRequestBodyLifecycleConfigurationRuleTransition
    : public Darabonba::Model {
public:
  PutBucketLifecycleRequestBodyLifecycleConfigurationRuleTransition() {}
  explicit PutBucketLifecycleRequestBodyLifecycleConfigurationRuleTransition(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {}

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (days) {
      res["Days"] = boost::any(*days);
    }
    if (storageClass) {
      res["StorageClass"] = boost::any(*storageClass);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("Days") != m.end()) {
      days = make_shared<int>(boost::any_cast<int>(m["Days"]));
    }
    if (m.find("StorageClass") != m.end()) {
      storageClass =
          make_shared<string>(boost::any_cast<string>(m["StorageClass"]));
    }
  }

  shared_ptr<int> days{};
  shared_ptr<string> storageClass{};

  ~PutBucketLifecycleRequestBodyLifecycleConfigurationRuleTransition() =
      default;
};
class
    PutBucketLifecycleRequestBodyLifecycleConfigurationRuleAbortMultipartUpload
    : public Darabonba::Model {
public:
  PutBucketLifecycleRequestBodyLifecycleConfigurationRuleAbortMultipartUpload() {
  }
  explicit PutBucketLifecycleRequestBodyLifecycleConfigurationRuleAbortMultipartUpload(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {}

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (days) {
      res["Days"] = boost::any(*days);
    }
    if (createdBeforeDate) {
      res["CreatedBeforeDate"] = boost::any(*createdBeforeDate);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("Days") != m.end()) {
      days = make_shared<int>(boost::any_cast<int>(m["Days"]));
    }
    if (m.find("CreatedBeforeDate") != m.end()) {
      createdBeforeDate =
          make_shared<string>(boost::any_cast<string>(m["CreatedBeforeDate"]));
    }
  }

  shared_ptr<int> days{};
  shared_ptr<string> createdBeforeDate{};

  ~PutBucketLifecycleRequestBodyLifecycleConfigurationRuleAbortMultipartUpload() =
      default;
};
class PutBucketLifecycleRequestBodyLifecycleConfigurationRuleTag
    : public Darabonba::Model {
public:
  PutBucketLifecycleRequestBodyLifecycleConfigurationRuleTag() {}
  explicit PutBucketLifecycleRequestBodyLifecycleConfigurationRuleTag(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {}

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (key) {
      res["Key"] = boost::any(*key);
    }
    if (value) {
      res["Value"] = boost::any(*value);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("Key") != m.end()) {
      key = make_shared<string>(boost::any_cast<string>(m["Key"]));
    }
    if (m.find("Value") != m.end()) {
      value = make_shared<string>(boost::any_cast<string>(m["Value"]));
    }
  }

  shared_ptr<string> key{};
  shared_ptr<string> value{};

  ~PutBucketLifecycleRequestBodyLifecycleConfigurationRuleTag() = default;
};
class PutBucketLifecycleRequestBodyLifecycleConfigurationRule
    : public Darabonba::Model {
public:
  PutBucketLifecycleRequestBodyLifecycleConfigurationRule() {}
  explicit PutBucketLifecycleRequestBodyLifecycleConfigurationRule(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {}

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (expiration) {
      res["Expiration"] = expiration ? boost::any(expiration->toMap())
                                     : boost::any(map<string, boost::any>({}));
    }
    if (transition) {
      res["Transition"] = transition ? boost::any(transition->toMap())
                                     : boost::any(map<string, boost::any>({}));
    }
    if (abortMultipartUpload) {
      res["AbortMultipartUpload"] =
          abortMultipartUpload ? boost::any(abortMultipartUpload->toMap())
                               : boost::any(map<string, boost::any>({}));
    }
    if (tag) {
      res["Tag"] = tag ? boost::any(tag->toMap())
                       : boost::any(map<string, boost::any>({}));
    }
    if (iD) {
      res["ID"] = boost::any(*iD);
    }
    if (prefix) {
      res["Prefix"] = boost::any(*prefix);
    }
    if (status) {
      res["Status"] = boost::any(*status);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("Expiration") != m.end()) {
      if (typeid(map<string, boost::any>).name() ==
          m["Expiration"].type().name()) {
        PutBucketLifecycleRequestBodyLifecycleConfigurationRuleExpiration
            model1;
        model1.fromMap(
            boost::any_cast<map<string, boost::any>>(m["Expiration"]));
        expiration = make_shared<
            PutBucketLifecycleRequestBodyLifecycleConfigurationRuleExpiration>(
            model1);
      }
    }
    if (m.find("Transition") != m.end()) {
      if (typeid(map<string, boost::any>).name() ==
          m["Transition"].type().name()) {
        PutBucketLifecycleRequestBodyLifecycleConfigurationRuleTransition
            model1;
        model1.fromMap(
            boost::any_cast<map<string, boost::any>>(m["Transition"]));
        transition = make_shared<
            PutBucketLifecycleRequestBodyLifecycleConfigurationRuleTransition>(
            model1);
      }
    }
    if (m.find("AbortMultipartUpload") != m.end()) {
      if (typeid(map<string, boost::any>).name() ==
          m["AbortMultipartUpload"].type().name()) {
        PutBucketLifecycleRequestBodyLifecycleConfigurationRuleAbortMultipartUpload
            model1;
        model1.fromMap(boost::any_cast<map<string, boost::any>>(
            m["AbortMultipartUpload"]));
        abortMultipartUpload = make_shared<
            PutBucketLifecycleRequestBodyLifecycleConfigurationRuleAbortMultipartUpload>(
            model1);
      }
    }
    if (m.find("Tag") != m.end()) {
      if (typeid(map<string, boost::any>).name() == m["Tag"].type().name()) {
        PutBucketLifecycleRequestBodyLifecycleConfigurationRuleTag model1;
        model1.fromMap(boost::any_cast<map<string, boost::any>>(m["Tag"]));
        tag = make_shared<
            PutBucketLifecycleRequestBodyLifecycleConfigurationRuleTag>(model1);
      }
    }
    if (m.find("ID") != m.end()) {
      iD = make_shared<string>(boost::any_cast<string>(m["ID"]));
    }
    if (m.find("Prefix") != m.end()) {
      prefix = make_shared<string>(boost::any_cast<string>(m["Prefix"]));
    }
    if (m.find("Status") != m.end()) {
      status = make_shared<string>(boost::any_cast<string>(m["Status"]));
    }
  }

  shared_ptr<PutBucketLifecycleRequestBodyLifecycleConfigurationRuleExpiration>
      expiration{};
  shared_ptr<PutBucketLifecycleRequestBodyLifecycleConfigurationRuleTransition>
      transition{};
  shared_ptr<
      PutBucketLifecycleRequestBodyLifecycleConfigurationRuleAbortMultipartUpload>
      abortMultipartUpload{};
  shared_ptr<PutBucketLifecycleRequestBodyLifecycleConfigurationRuleTag> tag{};
  shared_ptr<string> iD{};
  shared_ptr<string> prefix{};
  shared_ptr<string> status{};

  ~PutBucketLifecycleRequestBodyLifecycleConfigurationRule() = default;
};
class PutBucketLifecycleRequestBodyLifecycleConfiguration
    : public Darabonba::Model {
public:
  PutBucketLifecycleRequestBodyLifecycleConfiguration() {}
  explicit PutBucketLifecycleRequestBodyLifecycleConfiguration(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {}

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (rule) {
      vector<boost::any> temp1;
      for (auto item1 : *rule) {
        temp1.push_back(boost::any(item1.toMap()));
      }
      res["Rule"] = boost::any(temp1);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("Rule") != m.end()) {
      if (typeid(vector<boost::any>).name() == m["Rule"].type().name()) {
        vector<PutBucketLifecycleRequestBodyLifecycleConfigurationRule> expect1;
        for (auto item1 : boost::any_cast<vector<boost::any>>(m["Rule"])) {
          if (typeid(map<string, boost::any>).name() == item1.type().name()) {
            PutBucketLifecycleRequestBodyLifecycleConfigurationRule model2;
            model2.fromMap(boost::any_cast<map<string, boost::any>>(item1));
            expect1.push_back(model2);
          }
        }
        rule = make_shared<
            vector<PutBucketLifecycleRequestBodyLifecycleConfigurationRule>>(
            expect1);
      }
    }
  }

  shared_ptr<vector<PutBucketLifecycleRequestBodyLifecycleConfigurationRule>>
      rule{};

  ~PutBucketLifecycleRequestBodyLifecycleConfiguration() = default;
};
class PutBucketLifecycleRequestBody : public Darabonba::Model {
public:
  PutBucketLifecycleRequestBody() {}
  explicit PutBucketLifecycleRequestBody(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!lifecycleConfiguration) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("lifecycleConfiguration is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (lifecycleConfiguration) {
      res["LifecycleConfiguration"] =
          lifecycleConfiguration ? boost::any(lifecycleConfiguration->toMap())
                                 : boost::any(map<string, boost::any>({}));
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("LifecycleConfiguration") != m.end()) {
      if (typeid(map<string, boost::any>).name() ==
          m["LifecycleConfiguration"].type().name()) {
        PutBucketLifecycleRequestBodyLifecycleConfiguration model1;
        model1.fromMap(boost::any_cast<map<string, boost::any>>(
            m["LifecycleConfiguration"]));
        lifecycleConfiguration =
            make_shared<PutBucketLifecycleRequestBodyLifecycleConfiguration>(
                model1);
      }
    }
  }

  shared_ptr<PutBucketLifecycleRequestBodyLifecycleConfiguration>
      lifecycleConfiguration{};

  ~PutBucketLifecycleRequestBody() = default;
};
class PutBucketLifecycleRequest : public Darabonba::Model {
public:
  PutBucketLifecycleRequest() {}
  explicit PutBucketLifecycleRequest(const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!bucketName) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("bucketName is required.")));
    }
    Darabonba::Model::validatePattern("bucketName", bucketName,
                                      "[a-zA-Z0-9\\\\-\\\\_]+");
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (bucketName) {
      res["BucketName"] = boost::any(*bucketName);
    }
    if (body) {
      res["Body"] = body ? boost::any(body->toMap())
                         : boost::any(map<string, boost::any>({}));
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("BucketName") != m.end()) {
      bucketName =
          make_shared<string>(boost::any_cast<string>(m["BucketName"]));
    }
    if (m.find("Body") != m.end()) {
      if (typeid(map<string, boost::any>).name() == m["Body"].type().name()) {
        PutBucketLifecycleRequestBody model1;
        model1.fromMap(boost::any_cast<map<string, boost::any>>(m["Body"]));
        body = make_shared<PutBucketLifecycleRequestBody>(model1);
      }
    }
  }

  shared_ptr<string> bucketName{};
  shared_ptr<PutBucketLifecycleRequestBody> body{};

  ~PutBucketLifecycleRequest() = default;
};
class PutBucketLifecycleResponse : public Darabonba::Model {
public:
  PutBucketLifecycleResponse() {}
  explicit PutBucketLifecycleResponse(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!requestId) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("requestId is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (requestId) {
      res["x-oss-request-id"] = boost::any(*requestId);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("x-oss-request-id") != m.end()) {
      requestId =
          make_shared<string>(boost::any_cast<string>(m["x-oss-request-id"]));
    }
  }

  shared_ptr<string> requestId{};

  ~PutBucketLifecycleResponse() = default;
};
class DeleteMultipleObjectsRequestBodyDeleteObject : public Darabonba::Model {
public:
  DeleteMultipleObjectsRequestBodyDeleteObject() {}
  explicit DeleteMultipleObjectsRequestBodyDeleteObject(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {}

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (key) {
      res["Key"] = boost::any(*key);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("Key") != m.end()) {
      key = make_shared<string>(boost::any_cast<string>(m["Key"]));
    }
  }

  shared_ptr<string> key{};

  ~DeleteMultipleObjectsRequestBodyDeleteObject() = default;
};
class DeleteMultipleObjectsRequestBodyDelete : public Darabonba::Model {
public:
  DeleteMultipleObjectsRequestBodyDelete() {}
  explicit DeleteMultipleObjectsRequestBodyDelete(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {}

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (object) {
      vector<boost::any> temp1;
      for (auto item1 : *object) {
        temp1.push_back(boost::any(item1.toMap()));
      }
      res["Object"] = boost::any(temp1);
    }
    if (quiet) {
      res["Quiet"] = boost::any(*quiet);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("Object") != m.end()) {
      if (typeid(vector<boost::any>).name() == m["Object"].type().name()) {
        vector<DeleteMultipleObjectsRequestBodyDeleteObject> expect1;
        for (auto item1 : boost::any_cast<vector<boost::any>>(m["Object"])) {
          if (typeid(map<string, boost::any>).name() == item1.type().name()) {
            DeleteMultipleObjectsRequestBodyDeleteObject model2;
            model2.fromMap(boost::any_cast<map<string, boost::any>>(item1));
            expect1.push_back(model2);
          }
        }
        object =
            make_shared<vector<DeleteMultipleObjectsRequestBodyDeleteObject>>(
                expect1);
      }
    }
    if (m.find("Quiet") != m.end()) {
      quiet = make_shared<string>(boost::any_cast<string>(m["Quiet"]));
    }
  }

  shared_ptr<vector<DeleteMultipleObjectsRequestBodyDeleteObject>> object{};
  shared_ptr<string> quiet{};

  ~DeleteMultipleObjectsRequestBodyDelete() = default;
};
class DeleteMultipleObjectsRequestBody : public Darabonba::Model {
public:
  DeleteMultipleObjectsRequestBody() {}
  explicit DeleteMultipleObjectsRequestBody(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!delete_) {
      BOOST_THROW_EXCEPTION(
          boost::enable_error_info(std::runtime_error("delete is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (delete_) {
      res["Delete"] = delete_ ? boost::any(delete_->toMap())
                              : boost::any(map<string, boost::any>({}));
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("Delete") != m.end()) {
      if (typeid(map<string, boost::any>).name() == m["Delete"].type().name()) {
        DeleteMultipleObjectsRequestBodyDelete model1;
        model1.fromMap(boost::any_cast<map<string, boost::any>>(m["Delete"]));
        delete_ = make_shared<DeleteMultipleObjectsRequestBodyDelete>(model1);
      }
    }
  }

  shared_ptr<DeleteMultipleObjectsRequestBodyDelete> delete_{};

  ~DeleteMultipleObjectsRequestBody() = default;
};
class DeleteMultipleObjectsRequestHeader : public Darabonba::Model {
public:
  DeleteMultipleObjectsRequestHeader() {}
  explicit DeleteMultipleObjectsRequestHeader(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!contentLength) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("contentLength is required.")));
    }
    if (!contentMD5) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("contentMD5 is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (encodingType) {
      res["Encoding-type"] = boost::any(*encodingType);
    }
    if (contentLength) {
      res["Content-Length"] = boost::any(*contentLength);
    }
    if (contentMD5) {
      res["Content-MD5"] = boost::any(*contentMD5);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("Encoding-type") != m.end()) {
      encodingType =
          make_shared<string>(boost::any_cast<string>(m["Encoding-type"]));
    }
    if (m.find("Content-Length") != m.end()) {
      contentLength =
          make_shared<string>(boost::any_cast<string>(m["Content-Length"]));
    }
    if (m.find("Content-MD5") != m.end()) {
      contentMD5 =
          make_shared<string>(boost::any_cast<string>(m["Content-MD5"]));
    }
  }

  shared_ptr<string> encodingType{};
  shared_ptr<string> contentLength{};
  shared_ptr<string> contentMD5{};

  ~DeleteMultipleObjectsRequestHeader() = default;
};
class DeleteMultipleObjectsRequest : public Darabonba::Model {
public:
  DeleteMultipleObjectsRequest() {}
  explicit DeleteMultipleObjectsRequest(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!bucketName) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("bucketName is required.")));
    }
    Darabonba::Model::validatePattern("bucketName", bucketName,
                                      "[a-zA-Z0-9\\\\-\\\\_]+");
    if (!header) {
      BOOST_THROW_EXCEPTION(
          boost::enable_error_info(std::runtime_error("header is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (bucketName) {
      res["BucketName"] = boost::any(*bucketName);
    }
    if (body) {
      res["Body"] = body ? boost::any(body->toMap())
                         : boost::any(map<string, boost::any>({}));
    }
    if (header) {
      res["Header"] = header ? boost::any(header->toMap())
                             : boost::any(map<string, boost::any>({}));
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("BucketName") != m.end()) {
      bucketName =
          make_shared<string>(boost::any_cast<string>(m["BucketName"]));
    }
    if (m.find("Body") != m.end()) {
      if (typeid(map<string, boost::any>).name() == m["Body"].type().name()) {
        DeleteMultipleObjectsRequestBody model1;
        model1.fromMap(boost::any_cast<map<string, boost::any>>(m["Body"]));
        body = make_shared<DeleteMultipleObjectsRequestBody>(model1);
      }
    }
    if (m.find("Header") != m.end()) {
      if (typeid(map<string, boost::any>).name() == m["Header"].type().name()) {
        DeleteMultipleObjectsRequestHeader model1;
        model1.fromMap(boost::any_cast<map<string, boost::any>>(m["Header"]));
        header = make_shared<DeleteMultipleObjectsRequestHeader>(model1);
      }
    }
  }

  shared_ptr<string> bucketName{};
  shared_ptr<DeleteMultipleObjectsRequestBody> body{};
  shared_ptr<DeleteMultipleObjectsRequestHeader> header{};

  ~DeleteMultipleObjectsRequest() = default;
};
class DeleteMultipleObjectsResponseDeleteResultDeleted
    : public Darabonba::Model {
public:
  DeleteMultipleObjectsResponseDeleteResultDeleted() {}
  explicit DeleteMultipleObjectsResponseDeleteResultDeleted(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {}

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (key) {
      res["Key"] = boost::any(*key);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("Key") != m.end()) {
      key = make_shared<string>(boost::any_cast<string>(m["Key"]));
    }
  }

  shared_ptr<string> key{};

  ~DeleteMultipleObjectsResponseDeleteResultDeleted() = default;
};
class DeleteMultipleObjectsResponseDeleteResult : public Darabonba::Model {
public:
  DeleteMultipleObjectsResponseDeleteResult() {}
  explicit DeleteMultipleObjectsResponseDeleteResult(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {}

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (quiet) {
      res["Quiet"] = boost::any(*quiet);
    }
    if (encodingType) {
      res["EncodingType"] = boost::any(*encodingType);
    }
    if (deleted) {
      vector<boost::any> temp1;
      for (auto item1 : *deleted) {
        temp1.push_back(boost::any(item1.toMap()));
      }
      res["Deleted"] = boost::any(temp1);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("Quiet") != m.end()) {
      quiet = make_shared<string>(boost::any_cast<string>(m["Quiet"]));
    }
    if (m.find("EncodingType") != m.end()) {
      encodingType =
          make_shared<string>(boost::any_cast<string>(m["EncodingType"]));
    }
    if (m.find("Deleted") != m.end()) {
      if (typeid(vector<boost::any>).name() == m["Deleted"].type().name()) {
        vector<DeleteMultipleObjectsResponseDeleteResultDeleted> expect1;
        for (auto item1 : boost::any_cast<vector<boost::any>>(m["Deleted"])) {
          if (typeid(map<string, boost::any>).name() == item1.type().name()) {
            DeleteMultipleObjectsResponseDeleteResultDeleted model2;
            model2.fromMap(boost::any_cast<map<string, boost::any>>(item1));
            expect1.push_back(model2);
          }
        }
        deleted = make_shared<
            vector<DeleteMultipleObjectsResponseDeleteResultDeleted>>(expect1);
      }
    }
  }

  shared_ptr<string> quiet{};
  shared_ptr<string> encodingType{};
  shared_ptr<vector<DeleteMultipleObjectsResponseDeleteResultDeleted>>
      deleted{};

  ~DeleteMultipleObjectsResponseDeleteResult() = default;
};
class DeleteMultipleObjectsResponse : public Darabonba::Model {
public:
  DeleteMultipleObjectsResponse() {}
  explicit DeleteMultipleObjectsResponse(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!requestId) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("requestId is required.")));
    }
    if (!deleteResult) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("deleteResult is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (requestId) {
      res["x-oss-request-id"] = boost::any(*requestId);
    }
    if (deleteResult) {
      res["DeleteResult"] = deleteResult
                                ? boost::any(deleteResult->toMap())
                                : boost::any(map<string, boost::any>({}));
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("x-oss-request-id") != m.end()) {
      requestId =
          make_shared<string>(boost::any_cast<string>(m["x-oss-request-id"]));
    }
    if (m.find("DeleteResult") != m.end()) {
      if (typeid(map<string, boost::any>).name() ==
          m["DeleteResult"].type().name()) {
        DeleteMultipleObjectsResponseDeleteResult model1;
        model1.fromMap(
            boost::any_cast<map<string, boost::any>>(m["DeleteResult"]));
        deleteResult =
            make_shared<DeleteMultipleObjectsResponseDeleteResult>(model1);
      }
    }
  }

  shared_ptr<string> requestId{};
  shared_ptr<DeleteMultipleObjectsResponseDeleteResult> deleteResult{};

  ~DeleteMultipleObjectsResponse() = default;
};
class PutBucketRefererRequestBodyRefererConfigurationRefererList
    : public Darabonba::Model {
public:
  PutBucketRefererRequestBodyRefererConfigurationRefererList() {}
  explicit PutBucketRefererRequestBodyRefererConfigurationRefererList(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {}

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (referer) {
      res["Referer"] = boost::any(*referer);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("Referer") != m.end()) {
      vector<string> toVec1;
      if (typeid(vector<boost::any>).name() == m["Referer"].type().name()) {
        vector<boost::any> vec1 =
            boost::any_cast<vector<boost::any>>(m["Referer"]);
        for (auto item : vec1) {
          toVec1.push_back(boost::any_cast<string>(item));
        }
      }
      referer = make_shared<vector<string>>(toVec1);
    }
  }

  shared_ptr<vector<string>> referer{};

  ~PutBucketRefererRequestBodyRefererConfigurationRefererList() = default;
};
class PutBucketRefererRequestBodyRefererConfiguration
    : public Darabonba::Model {
public:
  PutBucketRefererRequestBodyRefererConfiguration() {}
  explicit PutBucketRefererRequestBodyRefererConfiguration(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {}

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (refererList) {
      res["RefererList"] = refererList
                               ? boost::any(refererList->toMap())
                               : boost::any(map<string, boost::any>({}));
    }
    if (allowEmptyReferer) {
      res["AllowEmptyReferer"] = boost::any(*allowEmptyReferer);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("RefererList") != m.end()) {
      if (typeid(map<string, boost::any>).name() ==
          m["RefererList"].type().name()) {
        PutBucketRefererRequestBodyRefererConfigurationRefererList model1;
        model1.fromMap(
            boost::any_cast<map<string, boost::any>>(m["RefererList"]));
        refererList = make_shared<
            PutBucketRefererRequestBodyRefererConfigurationRefererList>(model1);
      }
    }
    if (m.find("AllowEmptyReferer") != m.end()) {
      allowEmptyReferer =
          make_shared<bool>(boost::any_cast<bool>(m["AllowEmptyReferer"]));
    }
  }

  shared_ptr<PutBucketRefererRequestBodyRefererConfigurationRefererList>
      refererList{};
  shared_ptr<bool> allowEmptyReferer{};

  ~PutBucketRefererRequestBodyRefererConfiguration() = default;
};
class PutBucketRefererRequestBody : public Darabonba::Model {
public:
  PutBucketRefererRequestBody() {}
  explicit PutBucketRefererRequestBody(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!refererConfiguration) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("refererConfiguration is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (refererConfiguration) {
      res["RefererConfiguration"] =
          refererConfiguration ? boost::any(refererConfiguration->toMap())
                               : boost::any(map<string, boost::any>({}));
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("RefererConfiguration") != m.end()) {
      if (typeid(map<string, boost::any>).name() ==
          m["RefererConfiguration"].type().name()) {
        PutBucketRefererRequestBodyRefererConfiguration model1;
        model1.fromMap(boost::any_cast<map<string, boost::any>>(
            m["RefererConfiguration"]));
        refererConfiguration =
            make_shared<PutBucketRefererRequestBodyRefererConfiguration>(
                model1);
      }
    }
  }

  shared_ptr<PutBucketRefererRequestBodyRefererConfiguration>
      refererConfiguration{};

  ~PutBucketRefererRequestBody() = default;
};
class PutBucketRefererRequest : public Darabonba::Model {
public:
  PutBucketRefererRequest() {}
  explicit PutBucketRefererRequest(const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!bucketName) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("bucketName is required.")));
    }
    Darabonba::Model::validatePattern("bucketName", bucketName,
                                      "[a-zA-Z0-9\\\\-\\\\_]+");
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (bucketName) {
      res["BucketName"] = boost::any(*bucketName);
    }
    if (body) {
      res["Body"] = body ? boost::any(body->toMap())
                         : boost::any(map<string, boost::any>({}));
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("BucketName") != m.end()) {
      bucketName =
          make_shared<string>(boost::any_cast<string>(m["BucketName"]));
    }
    if (m.find("Body") != m.end()) {
      if (typeid(map<string, boost::any>).name() == m["Body"].type().name()) {
        PutBucketRefererRequestBody model1;
        model1.fromMap(boost::any_cast<map<string, boost::any>>(m["Body"]));
        body = make_shared<PutBucketRefererRequestBody>(model1);
      }
    }
  }

  shared_ptr<string> bucketName{};
  shared_ptr<PutBucketRefererRequestBody> body{};

  ~PutBucketRefererRequest() = default;
};
class PutBucketRefererResponse : public Darabonba::Model {
public:
  PutBucketRefererResponse() {}
  explicit PutBucketRefererResponse(const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!requestId) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("requestId is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (requestId) {
      res["x-oss-request-id"] = boost::any(*requestId);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("x-oss-request-id") != m.end()) {
      requestId =
          make_shared<string>(boost::any_cast<string>(m["x-oss-request-id"]));
    }
  }

  shared_ptr<string> requestId{};

  ~PutBucketRefererResponse() = default;
};
class PutBucketWebsiteRequestBodyWebsiteConfigurationIndexDocument
    : public Darabonba::Model {
public:
  PutBucketWebsiteRequestBodyWebsiteConfigurationIndexDocument() {}
  explicit PutBucketWebsiteRequestBodyWebsiteConfigurationIndexDocument(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {}

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (suffix) {
      res["Suffix"] = boost::any(*suffix);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("Suffix") != m.end()) {
      suffix = make_shared<string>(boost::any_cast<string>(m["Suffix"]));
    }
  }

  shared_ptr<string> suffix{};

  ~PutBucketWebsiteRequestBodyWebsiteConfigurationIndexDocument() = default;
};
class PutBucketWebsiteRequestBodyWebsiteConfigurationErrorDocument
    : public Darabonba::Model {
public:
  PutBucketWebsiteRequestBodyWebsiteConfigurationErrorDocument() {}
  explicit PutBucketWebsiteRequestBodyWebsiteConfigurationErrorDocument(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {}

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (key) {
      res["Key"] = boost::any(*key);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("Key") != m.end()) {
      key = make_shared<string>(boost::any_cast<string>(m["Key"]));
    }
  }

  shared_ptr<string> key{};

  ~PutBucketWebsiteRequestBodyWebsiteConfigurationErrorDocument() = default;
};
class
    PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleConditionIncludeHeader
    : public Darabonba::Model {
public:
  PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleConditionIncludeHeader() {
  }
  explicit PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleConditionIncludeHeader(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {}

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (key) {
      res["Key"] = boost::any(*key);
    }
    if (equals) {
      res["Equals"] = boost::any(*equals);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("Key") != m.end()) {
      key = make_shared<string>(boost::any_cast<string>(m["Key"]));
    }
    if (m.find("Equals") != m.end()) {
      equals = make_shared<string>(boost::any_cast<string>(m["Equals"]));
    }
  }

  shared_ptr<string> key{};
  shared_ptr<string> equals{};

  ~PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleConditionIncludeHeader() =
      default;
};
class
    PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleCondition
    : public Darabonba::Model {
public:
  PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleCondition() {
  }
  explicit PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleCondition(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {}

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (includeHeader) {
      res["IncludeHeader"] = includeHeader
                                 ? boost::any(includeHeader->toMap())
                                 : boost::any(map<string, boost::any>({}));
    }
    if (keyPrefixEquals) {
      res["KeyPrefixEquals"] = boost::any(*keyPrefixEquals);
    }
    if (httpErrorCodeReturnedEquals) {
      res["HttpErrorCodeReturnedEquals"] =
          boost::any(*httpErrorCodeReturnedEquals);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("IncludeHeader") != m.end()) {
      if (typeid(map<string, boost::any>).name() ==
          m["IncludeHeader"].type().name()) {
        PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleConditionIncludeHeader
            model1;
        model1.fromMap(
            boost::any_cast<map<string, boost::any>>(m["IncludeHeader"]));
        includeHeader = make_shared<
            PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleConditionIncludeHeader>(
            model1);
      }
    }
    if (m.find("KeyPrefixEquals") != m.end()) {
      keyPrefixEquals =
          make_shared<string>(boost::any_cast<string>(m["KeyPrefixEquals"]));
    }
    if (m.find("HttpErrorCodeReturnedEquals") != m.end()) {
      httpErrorCodeReturnedEquals = make_shared<string>(
          boost::any_cast<string>(m["HttpErrorCodeReturnedEquals"]));
    }
  }

  shared_ptr<
      PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleConditionIncludeHeader>
      includeHeader{};
  shared_ptr<string> keyPrefixEquals{};
  shared_ptr<string> httpErrorCodeReturnedEquals{};

  ~PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleCondition() =
      default;
};
class
    PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeadersSet
    : public Darabonba::Model {
public:
  PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeadersSet() {
  }
  explicit PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeadersSet(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {}

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (key) {
      res["Key"] = boost::any(*key);
    }
    if (value) {
      res["Value"] = boost::any(*value);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("Key") != m.end()) {
      key = make_shared<string>(boost::any_cast<string>(m["Key"]));
    }
    if (m.find("Value") != m.end()) {
      value = make_shared<string>(boost::any_cast<string>(m["Value"]));
    }
  }

  shared_ptr<string> key{};
  shared_ptr<string> value{};

  ~PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeadersSet() =
      default;
};
class
    PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeaders
    : public Darabonba::Model {
public:
  PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeaders() {
  }
  explicit PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeaders(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {}

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (set) {
      res["Set"] = set ? boost::any(set->toMap())
                       : boost::any(map<string, boost::any>({}));
    }
    if (passAll) {
      res["PassAll"] = boost::any(*passAll);
    }
    if (pass) {
      res["Pass"] = boost::any(*pass);
    }
    if (remove) {
      res["Remove"] = boost::any(*remove);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("Set") != m.end()) {
      if (typeid(map<string, boost::any>).name() == m["Set"].type().name()) {
        PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeadersSet
            model1;
        model1.fromMap(boost::any_cast<map<string, boost::any>>(m["Set"]));
        set = make_shared<
            PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeadersSet>(
            model1);
      }
    }
    if (m.find("PassAll") != m.end()) {
      passAll = make_shared<bool>(boost::any_cast<bool>(m["PassAll"]));
    }
    if (m.find("Pass") != m.end()) {
      pass = make_shared<string>(boost::any_cast<string>(m["Pass"]));
    }
    if (m.find("Remove") != m.end()) {
      remove = make_shared<string>(boost::any_cast<string>(m["Remove"]));
    }
  }

  shared_ptr<
      PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeadersSet>
      set{};
  shared_ptr<bool> passAll{};
  shared_ptr<string> pass{};
  shared_ptr<string> remove{};

  ~PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeaders() =
      default;
};
class
    PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirect
    : public Darabonba::Model {
public:
  PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirect() {
  }
  explicit PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirect(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {}

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (mirrorHeaders) {
      res["MirrorHeaders"] = mirrorHeaders
                                 ? boost::any(mirrorHeaders->toMap())
                                 : boost::any(map<string, boost::any>({}));
    }
    if (redirectType) {
      res["RedirectType"] = boost::any(*redirectType);
    }
    if (passQueryString) {
      res["PassQueryString"] = boost::any(*passQueryString);
    }
    if (mirrorURL) {
      res["MirrorURL"] = boost::any(*mirrorURL);
    }
    if (mirrorPassQueryString) {
      res["MirrorPassQueryString"] = boost::any(*mirrorPassQueryString);
    }
    if (mirrorFollowRedirect) {
      res["MirrorFollowRedirect"] = boost::any(*mirrorFollowRedirect);
    }
    if (mirrorCheckMd5) {
      res["MirrorCheckMd5"] = boost::any(*mirrorCheckMd5);
    }
    if (protocol) {
      res["Protocol"] = boost::any(*protocol);
    }
    if (hostName) {
      res["HostName"] = boost::any(*hostName);
    }
    if (httpRedirectCode) {
      res["HttpRedirectCode"] = boost::any(*httpRedirectCode);
    }
    if (replaceKeyPrefixWith) {
      res["ReplaceKeyPrefixWith"] = boost::any(*replaceKeyPrefixWith);
    }
    if (replaceKeyWith) {
      res["ReplaceKeyWith"] = boost::any(*replaceKeyWith);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("MirrorHeaders") != m.end()) {
      if (typeid(map<string, boost::any>).name() ==
          m["MirrorHeaders"].type().name()) {
        PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeaders
            model1;
        model1.fromMap(
            boost::any_cast<map<string, boost::any>>(m["MirrorHeaders"]));
        mirrorHeaders = make_shared<
            PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeaders>(
            model1);
      }
    }
    if (m.find("RedirectType") != m.end()) {
      redirectType =
          make_shared<string>(boost::any_cast<string>(m["RedirectType"]));
    }
    if (m.find("PassQueryString") != m.end()) {
      passQueryString =
          make_shared<bool>(boost::any_cast<bool>(m["PassQueryString"]));
    }
    if (m.find("MirrorURL") != m.end()) {
      mirrorURL = make_shared<string>(boost::any_cast<string>(m["MirrorURL"]));
    }
    if (m.find("MirrorPassQueryString") != m.end()) {
      mirrorPassQueryString =
          make_shared<bool>(boost::any_cast<bool>(m["MirrorPassQueryString"]));
    }
    if (m.find("MirrorFollowRedirect") != m.end()) {
      mirrorFollowRedirect =
          make_shared<bool>(boost::any_cast<bool>(m["MirrorFollowRedirect"]));
    }
    if (m.find("MirrorCheckMd5") != m.end()) {
      mirrorCheckMd5 =
          make_shared<bool>(boost::any_cast<bool>(m["MirrorCheckMd5"]));
    }
    if (m.find("Protocol") != m.end()) {
      protocol = make_shared<string>(boost::any_cast<string>(m["Protocol"]));
    }
    if (m.find("HostName") != m.end()) {
      hostName = make_shared<string>(boost::any_cast<string>(m["HostName"]));
    }
    if (m.find("HttpRedirectCode") != m.end()) {
      httpRedirectCode =
          make_shared<string>(boost::any_cast<string>(m["HttpRedirectCode"]));
    }
    if (m.find("ReplaceKeyPrefixWith") != m.end()) {
      replaceKeyPrefixWith = make_shared<string>(
          boost::any_cast<string>(m["ReplaceKeyPrefixWith"]));
    }
    if (m.find("ReplaceKeyWith") != m.end()) {
      replaceKeyWith =
          make_shared<string>(boost::any_cast<string>(m["ReplaceKeyWith"]));
    }
  }

  shared_ptr<
      PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeaders>
      mirrorHeaders{};
  shared_ptr<string> redirectType{};
  shared_ptr<bool> passQueryString{};
  shared_ptr<string> mirrorURL{};
  shared_ptr<bool> mirrorPassQueryString{};
  shared_ptr<bool> mirrorFollowRedirect{};
  shared_ptr<bool> mirrorCheckMd5{};
  shared_ptr<string> protocol{};
  shared_ptr<string> hostName{};
  shared_ptr<string> httpRedirectCode{};
  shared_ptr<string> replaceKeyPrefixWith{};
  shared_ptr<string> replaceKeyWith{};

  ~PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirect() =
      default;
};
class PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRule
    : public Darabonba::Model {
public:
  PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRule() {}
  explicit PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRule(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {}

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (condition) {
      res["Condition"] = condition ? boost::any(condition->toMap())
                                   : boost::any(map<string, boost::any>({}));
    }
    if (redirect) {
      res["Redirect"] = redirect ? boost::any(redirect->toMap())
                                 : boost::any(map<string, boost::any>({}));
    }
    if (ruleNumber) {
      res["RuleNumber"] = boost::any(*ruleNumber);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("Condition") != m.end()) {
      if (typeid(map<string, boost::any>).name() ==
          m["Condition"].type().name()) {
        PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleCondition
            model1;
        model1.fromMap(
            boost::any_cast<map<string, boost::any>>(m["Condition"]));
        condition = make_shared<
            PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleCondition>(
            model1);
      }
    }
    if (m.find("Redirect") != m.end()) {
      if (typeid(map<string, boost::any>).name() ==
          m["Redirect"].type().name()) {
        PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirect
            model1;
        model1.fromMap(boost::any_cast<map<string, boost::any>>(m["Redirect"]));
        redirect = make_shared<
            PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirect>(
            model1);
      }
    }
    if (m.find("RuleNumber") != m.end()) {
      ruleNumber = make_shared<int>(boost::any_cast<int>(m["RuleNumber"]));
    }
  }

  shared_ptr<
      PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleCondition>
      condition{};
  shared_ptr<
      PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirect>
      redirect{};
  shared_ptr<int> ruleNumber{};

  ~PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRule() =
      default;
};
class PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRules
    : public Darabonba::Model {
public:
  PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRules() {}
  explicit PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRules(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {}

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (routingRule) {
      vector<boost::any> temp1;
      for (auto item1 : *routingRule) {
        temp1.push_back(boost::any(item1.toMap()));
      }
      res["RoutingRule"] = boost::any(temp1);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("RoutingRule") != m.end()) {
      if (typeid(vector<boost::any>).name() == m["RoutingRule"].type().name()) {
        vector<
            PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRule>
            expect1;
        for (auto item1 :
             boost::any_cast<vector<boost::any>>(m["RoutingRule"])) {
          if (typeid(map<string, boost::any>).name() == item1.type().name()) {
            PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRule
                model2;
            model2.fromMap(boost::any_cast<map<string, boost::any>>(item1));
            expect1.push_back(model2);
          }
        }
        routingRule = make_shared<vector<
            PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRule>>(
            expect1);
      }
    }
  }

  shared_ptr<vector<
      PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRule>>
      routingRule{};

  ~PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRules() = default;
};
class PutBucketWebsiteRequestBodyWebsiteConfiguration
    : public Darabonba::Model {
public:
  PutBucketWebsiteRequestBodyWebsiteConfiguration() {}
  explicit PutBucketWebsiteRequestBodyWebsiteConfiguration(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {}

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (indexDocument) {
      res["IndexDocument"] = indexDocument
                                 ? boost::any(indexDocument->toMap())
                                 : boost::any(map<string, boost::any>({}));
    }
    if (errorDocument) {
      res["ErrorDocument"] = errorDocument
                                 ? boost::any(errorDocument->toMap())
                                 : boost::any(map<string, boost::any>({}));
    }
    if (routingRules) {
      res["RoutingRules"] = routingRules
                                ? boost::any(routingRules->toMap())
                                : boost::any(map<string, boost::any>({}));
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("IndexDocument") != m.end()) {
      if (typeid(map<string, boost::any>).name() ==
          m["IndexDocument"].type().name()) {
        PutBucketWebsiteRequestBodyWebsiteConfigurationIndexDocument model1;
        model1.fromMap(
            boost::any_cast<map<string, boost::any>>(m["IndexDocument"]));
        indexDocument = make_shared<
            PutBucketWebsiteRequestBodyWebsiteConfigurationIndexDocument>(
            model1);
      }
    }
    if (m.find("ErrorDocument") != m.end()) {
      if (typeid(map<string, boost::any>).name() ==
          m["ErrorDocument"].type().name()) {
        PutBucketWebsiteRequestBodyWebsiteConfigurationErrorDocument model1;
        model1.fromMap(
            boost::any_cast<map<string, boost::any>>(m["ErrorDocument"]));
        errorDocument = make_shared<
            PutBucketWebsiteRequestBodyWebsiteConfigurationErrorDocument>(
            model1);
      }
    }
    if (m.find("RoutingRules") != m.end()) {
      if (typeid(map<string, boost::any>).name() ==
          m["RoutingRules"].type().name()) {
        PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRules model1;
        model1.fromMap(
            boost::any_cast<map<string, boost::any>>(m["RoutingRules"]));
        routingRules = make_shared<
            PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRules>(
            model1);
      }
    }
  }

  shared_ptr<PutBucketWebsiteRequestBodyWebsiteConfigurationIndexDocument>
      indexDocument{};
  shared_ptr<PutBucketWebsiteRequestBodyWebsiteConfigurationErrorDocument>
      errorDocument{};
  shared_ptr<PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRules>
      routingRules{};

  ~PutBucketWebsiteRequestBodyWebsiteConfiguration() = default;
};
class PutBucketWebsiteRequestBody : public Darabonba::Model {
public:
  PutBucketWebsiteRequestBody() {}
  explicit PutBucketWebsiteRequestBody(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!websiteConfiguration) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("websiteConfiguration is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (websiteConfiguration) {
      res["WebsiteConfiguration"] =
          websiteConfiguration ? boost::any(websiteConfiguration->toMap())
                               : boost::any(map<string, boost::any>({}));
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("WebsiteConfiguration") != m.end()) {
      if (typeid(map<string, boost::any>).name() ==
          m["WebsiteConfiguration"].type().name()) {
        PutBucketWebsiteRequestBodyWebsiteConfiguration model1;
        model1.fromMap(boost::any_cast<map<string, boost::any>>(
            m["WebsiteConfiguration"]));
        websiteConfiguration =
            make_shared<PutBucketWebsiteRequestBodyWebsiteConfiguration>(
                model1);
      }
    }
  }

  shared_ptr<PutBucketWebsiteRequestBodyWebsiteConfiguration>
      websiteConfiguration{};

  ~PutBucketWebsiteRequestBody() = default;
};
class PutBucketWebsiteRequest : public Darabonba::Model {
public:
  PutBucketWebsiteRequest() {}
  explicit PutBucketWebsiteRequest(const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!bucketName) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("bucketName is required.")));
    }
    Darabonba::Model::validatePattern("bucketName", bucketName,
                                      "[a-zA-Z0-9\\\\-\\\\_]+");
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (bucketName) {
      res["BucketName"] = boost::any(*bucketName);
    }
    if (body) {
      res["Body"] = body ? boost::any(body->toMap())
                         : boost::any(map<string, boost::any>({}));
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("BucketName") != m.end()) {
      bucketName =
          make_shared<string>(boost::any_cast<string>(m["BucketName"]));
    }
    if (m.find("Body") != m.end()) {
      if (typeid(map<string, boost::any>).name() == m["Body"].type().name()) {
        PutBucketWebsiteRequestBody model1;
        model1.fromMap(boost::any_cast<map<string, boost::any>>(m["Body"]));
        body = make_shared<PutBucketWebsiteRequestBody>(model1);
      }
    }
  }

  shared_ptr<string> bucketName{};
  shared_ptr<PutBucketWebsiteRequestBody> body{};

  ~PutBucketWebsiteRequest() = default;
};
class PutBucketWebsiteResponse : public Darabonba::Model {
public:
  PutBucketWebsiteResponse() {}
  explicit PutBucketWebsiteResponse(const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!requestId) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("requestId is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (requestId) {
      res["x-oss-request-id"] = boost::any(*requestId);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("x-oss-request-id") != m.end()) {
      requestId =
          make_shared<string>(boost::any_cast<string>(m["x-oss-request-id"]));
    }
  }

  shared_ptr<string> requestId{};

  ~PutBucketWebsiteResponse() = default;
};
class CompleteMultipartUploadRequestFilter : public Darabonba::Model {
public:
  CompleteMultipartUploadRequestFilter() {}
  explicit CompleteMultipartUploadRequestFilter(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!uploadId) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("uploadId is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (uploadId) {
      res["uploadId"] = boost::any(*uploadId);
    }
    if (encodingType) {
      res["Encoding-type"] = boost::any(*encodingType);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("uploadId") != m.end()) {
      uploadId = make_shared<string>(boost::any_cast<string>(m["uploadId"]));
    }
    if (m.find("Encoding-type") != m.end()) {
      encodingType =
          make_shared<string>(boost::any_cast<string>(m["Encoding-type"]));
    }
  }

  shared_ptr<string> uploadId{};
  shared_ptr<string> encodingType{};

  ~CompleteMultipartUploadRequestFilter() = default;
};
class CompleteMultipartUploadRequestBodyCompleteMultipartUploadPart
    : public Darabonba::Model {
public:
  CompleteMultipartUploadRequestBodyCompleteMultipartUploadPart() {}
  explicit CompleteMultipartUploadRequestBodyCompleteMultipartUploadPart(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {}

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (partNumber) {
      res["PartNumber"] = boost::any(*partNumber);
    }
    if (eTag) {
      res["ETag"] = boost::any(*eTag);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("PartNumber") != m.end()) {
      partNumber =
          make_shared<string>(boost::any_cast<string>(m["PartNumber"]));
    }
    if (m.find("ETag") != m.end()) {
      eTag = make_shared<string>(boost::any_cast<string>(m["ETag"]));
    }
  }

  shared_ptr<string> partNumber{};
  shared_ptr<string> eTag{};

  ~CompleteMultipartUploadRequestBodyCompleteMultipartUploadPart() = default;
};
class CompleteMultipartUploadRequestBodyCompleteMultipartUpload
    : public Darabonba::Model {
public:
  CompleteMultipartUploadRequestBodyCompleteMultipartUpload() {}
  explicit CompleteMultipartUploadRequestBodyCompleteMultipartUpload(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {}

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (part) {
      vector<boost::any> temp1;
      for (auto item1 : *part) {
        temp1.push_back(boost::any(item1.toMap()));
      }
      res["Part"] = boost::any(temp1);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("Part") != m.end()) {
      if (typeid(vector<boost::any>).name() == m["Part"].type().name()) {
        vector<CompleteMultipartUploadRequestBodyCompleteMultipartUploadPart>
            expect1;
        for (auto item1 : boost::any_cast<vector<boost::any>>(m["Part"])) {
          if (typeid(map<string, boost::any>).name() == item1.type().name()) {
            CompleteMultipartUploadRequestBodyCompleteMultipartUploadPart
                model2;
            model2.fromMap(boost::any_cast<map<string, boost::any>>(item1));
            expect1.push_back(model2);
          }
        }
        part = make_shared<vector<
            CompleteMultipartUploadRequestBodyCompleteMultipartUploadPart>>(
            expect1);
      }
    }
  }

  shared_ptr<
      vector<CompleteMultipartUploadRequestBodyCompleteMultipartUploadPart>>
      part{};

  ~CompleteMultipartUploadRequestBodyCompleteMultipartUpload() = default;
};
class CompleteMultipartUploadRequestBody : public Darabonba::Model {
public:
  CompleteMultipartUploadRequestBody() {}
  explicit CompleteMultipartUploadRequestBody(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!completeMultipartUpload) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("completeMultipartUpload is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (completeMultipartUpload) {
      res["CompleteMultipartUpload"] =
          completeMultipartUpload ? boost::any(completeMultipartUpload->toMap())
                                  : boost::any(map<string, boost::any>({}));
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("CompleteMultipartUpload") != m.end()) {
      if (typeid(map<string, boost::any>).name() ==
          m["CompleteMultipartUpload"].type().name()) {
        CompleteMultipartUploadRequestBodyCompleteMultipartUpload model1;
        model1.fromMap(boost::any_cast<map<string, boost::any>>(
            m["CompleteMultipartUpload"]));
        completeMultipartUpload = make_shared<
            CompleteMultipartUploadRequestBodyCompleteMultipartUpload>(model1);
      }
    }
  }

  shared_ptr<CompleteMultipartUploadRequestBodyCompleteMultipartUpload>
      completeMultipartUpload{};

  ~CompleteMultipartUploadRequestBody() = default;
};
class CompleteMultipartUploadRequest : public Darabonba::Model {
public:
  CompleteMultipartUploadRequest() {}
  explicit CompleteMultipartUploadRequest(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!bucketName) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("bucketName is required.")));
    }
    Darabonba::Model::validatePattern("bucketName", bucketName,
                                      "[a-zA-Z0-9\\\\-\\\\_]+");
    if (!objectName) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("objectName is required.")));
    }
    if (!filter) {
      BOOST_THROW_EXCEPTION(
          boost::enable_error_info(std::runtime_error("filter is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (bucketName) {
      res["BucketName"] = boost::any(*bucketName);
    }
    if (objectName) {
      res["ObjectName"] = boost::any(*objectName);
    }
    if (filter) {
      res["Filter"] = filter ? boost::any(filter->toMap())
                             : boost::any(map<string, boost::any>({}));
    }
    if (body) {
      res["Body"] = body ? boost::any(body->toMap())
                         : boost::any(map<string, boost::any>({}));
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("BucketName") != m.end()) {
      bucketName =
          make_shared<string>(boost::any_cast<string>(m["BucketName"]));
    }
    if (m.find("ObjectName") != m.end()) {
      objectName =
          make_shared<string>(boost::any_cast<string>(m["ObjectName"]));
    }
    if (m.find("Filter") != m.end()) {
      if (typeid(map<string, boost::any>).name() == m["Filter"].type().name()) {
        CompleteMultipartUploadRequestFilter model1;
        model1.fromMap(boost::any_cast<map<string, boost::any>>(m["Filter"]));
        filter = make_shared<CompleteMultipartUploadRequestFilter>(model1);
      }
    }
    if (m.find("Body") != m.end()) {
      if (typeid(map<string, boost::any>).name() == m["Body"].type().name()) {
        CompleteMultipartUploadRequestBody model1;
        model1.fromMap(boost::any_cast<map<string, boost::any>>(m["Body"]));
        body = make_shared<CompleteMultipartUploadRequestBody>(model1);
      }
    }
  }

  shared_ptr<string> bucketName{};
  shared_ptr<string> objectName{};
  shared_ptr<CompleteMultipartUploadRequestFilter> filter{};
  shared_ptr<CompleteMultipartUploadRequestBody> body{};

  ~CompleteMultipartUploadRequest() = default;
};
class CompleteMultipartUploadResponseCompleteMultipartUploadResult
    : public Darabonba::Model {
public:
  CompleteMultipartUploadResponseCompleteMultipartUploadResult() {}
  explicit CompleteMultipartUploadResponseCompleteMultipartUploadResult(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {}

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (bucket) {
      res["Bucket"] = boost::any(*bucket);
    }
    if (eTag) {
      res["ETag"] = boost::any(*eTag);
    }
    if (location) {
      res["Location"] = boost::any(*location);
    }
    if (key) {
      res["Key"] = boost::any(*key);
    }
    if (encodingType) {
      res["EncodingType"] = boost::any(*encodingType);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("Bucket") != m.end()) {
      bucket = make_shared<string>(boost::any_cast<string>(m["Bucket"]));
    }
    if (m.find("ETag") != m.end()) {
      eTag = make_shared<string>(boost::any_cast<string>(m["ETag"]));
    }
    if (m.find("Location") != m.end()) {
      location = make_shared<string>(boost::any_cast<string>(m["Location"]));
    }
    if (m.find("Key") != m.end()) {
      key = make_shared<string>(boost::any_cast<string>(m["Key"]));
    }
    if (m.find("EncodingType") != m.end()) {
      encodingType =
          make_shared<string>(boost::any_cast<string>(m["EncodingType"]));
    }
  }

  shared_ptr<string> bucket{};
  shared_ptr<string> eTag{};
  shared_ptr<string> location{};
  shared_ptr<string> key{};
  shared_ptr<string> encodingType{};

  ~CompleteMultipartUploadResponseCompleteMultipartUploadResult() = default;
};
class CompleteMultipartUploadResponse : public Darabonba::Model {
public:
  CompleteMultipartUploadResponse() {}
  explicit CompleteMultipartUploadResponse(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!requestId) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("requestId is required.")));
    }
    if (!completeMultipartUploadResult) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("completeMultipartUploadResult is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (requestId) {
      res["x-oss-request-id"] = boost::any(*requestId);
    }
    if (completeMultipartUploadResult) {
      res["CompleteMultipartUploadResult"] =
          completeMultipartUploadResult
              ? boost::any(completeMultipartUploadResult->toMap())
              : boost::any(map<string, boost::any>({}));
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("x-oss-request-id") != m.end()) {
      requestId =
          make_shared<string>(boost::any_cast<string>(m["x-oss-request-id"]));
    }
    if (m.find("CompleteMultipartUploadResult") != m.end()) {
      if (typeid(map<string, boost::any>).name() ==
          m["CompleteMultipartUploadResult"].type().name()) {
        CompleteMultipartUploadResponseCompleteMultipartUploadResult model1;
        model1.fromMap(boost::any_cast<map<string, boost::any>>(
            m["CompleteMultipartUploadResult"]));
        completeMultipartUploadResult = make_shared<
            CompleteMultipartUploadResponseCompleteMultipartUploadResult>(
            model1);
      }
    }
  }

  shared_ptr<string> requestId{};
  shared_ptr<CompleteMultipartUploadResponseCompleteMultipartUploadResult>
      completeMultipartUploadResult{};

  ~CompleteMultipartUploadResponse() = default;
};
class PutBucketLoggingRequestBodyBucketLoggingStatusLoggingEnabled
    : public Darabonba::Model {
public:
  PutBucketLoggingRequestBodyBucketLoggingStatusLoggingEnabled() {}
  explicit PutBucketLoggingRequestBodyBucketLoggingStatusLoggingEnabled(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {}

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (targetBucket) {
      res["TargetBucket"] = boost::any(*targetBucket);
    }
    if (targetPrefix) {
      res["TargetPrefix"] = boost::any(*targetPrefix);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("TargetBucket") != m.end()) {
      targetBucket =
          make_shared<string>(boost::any_cast<string>(m["TargetBucket"]));
    }
    if (m.find("TargetPrefix") != m.end()) {
      targetPrefix =
          make_shared<string>(boost::any_cast<string>(m["TargetPrefix"]));
    }
  }

  shared_ptr<string> targetBucket{};
  shared_ptr<string> targetPrefix{};

  ~PutBucketLoggingRequestBodyBucketLoggingStatusLoggingEnabled() = default;
};
class PutBucketLoggingRequestBodyBucketLoggingStatus : public Darabonba::Model {
public:
  PutBucketLoggingRequestBodyBucketLoggingStatus() {}
  explicit PutBucketLoggingRequestBodyBucketLoggingStatus(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {}

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (loggingEnabled) {
      res["LoggingEnabled"] = loggingEnabled
                                  ? boost::any(loggingEnabled->toMap())
                                  : boost::any(map<string, boost::any>({}));
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("LoggingEnabled") != m.end()) {
      if (typeid(map<string, boost::any>).name() ==
          m["LoggingEnabled"].type().name()) {
        PutBucketLoggingRequestBodyBucketLoggingStatusLoggingEnabled model1;
        model1.fromMap(
            boost::any_cast<map<string, boost::any>>(m["LoggingEnabled"]));
        loggingEnabled = make_shared<
            PutBucketLoggingRequestBodyBucketLoggingStatusLoggingEnabled>(
            model1);
      }
    }
  }

  shared_ptr<PutBucketLoggingRequestBodyBucketLoggingStatusLoggingEnabled>
      loggingEnabled{};

  ~PutBucketLoggingRequestBodyBucketLoggingStatus() = default;
};
class PutBucketLoggingRequestBody : public Darabonba::Model {
public:
  PutBucketLoggingRequestBody() {}
  explicit PutBucketLoggingRequestBody(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!bucketLoggingStatus) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("bucketLoggingStatus is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (bucketLoggingStatus) {
      res["BucketLoggingStatus"] =
          bucketLoggingStatus ? boost::any(bucketLoggingStatus->toMap())
                              : boost::any(map<string, boost::any>({}));
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("BucketLoggingStatus") != m.end()) {
      if (typeid(map<string, boost::any>).name() ==
          m["BucketLoggingStatus"].type().name()) {
        PutBucketLoggingRequestBodyBucketLoggingStatus model1;
        model1.fromMap(
            boost::any_cast<map<string, boost::any>>(m["BucketLoggingStatus"]));
        bucketLoggingStatus =
            make_shared<PutBucketLoggingRequestBodyBucketLoggingStatus>(model1);
      }
    }
  }

  shared_ptr<PutBucketLoggingRequestBodyBucketLoggingStatus>
      bucketLoggingStatus{};

  ~PutBucketLoggingRequestBody() = default;
};
class PutBucketLoggingRequest : public Darabonba::Model {
public:
  PutBucketLoggingRequest() {}
  explicit PutBucketLoggingRequest(const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!bucketName) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("bucketName is required.")));
    }
    Darabonba::Model::validatePattern("bucketName", bucketName,
                                      "[a-zA-Z0-9\\\\-\\\\_]+");
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (bucketName) {
      res["BucketName"] = boost::any(*bucketName);
    }
    if (body) {
      res["Body"] = body ? boost::any(body->toMap())
                         : boost::any(map<string, boost::any>({}));
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("BucketName") != m.end()) {
      bucketName =
          make_shared<string>(boost::any_cast<string>(m["BucketName"]));
    }
    if (m.find("Body") != m.end()) {
      if (typeid(map<string, boost::any>).name() == m["Body"].type().name()) {
        PutBucketLoggingRequestBody model1;
        model1.fromMap(boost::any_cast<map<string, boost::any>>(m["Body"]));
        body = make_shared<PutBucketLoggingRequestBody>(model1);
      }
    }
  }

  shared_ptr<string> bucketName{};
  shared_ptr<PutBucketLoggingRequestBody> body{};

  ~PutBucketLoggingRequest() = default;
};
class PutBucketLoggingResponse : public Darabonba::Model {
public:
  PutBucketLoggingResponse() {}
  explicit PutBucketLoggingResponse(const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!requestId) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("requestId is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (requestId) {
      res["x-oss-request-id"] = boost::any(*requestId);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("x-oss-request-id") != m.end()) {
      requestId =
          make_shared<string>(boost::any_cast<string>(m["x-oss-request-id"]));
    }
  }

  shared_ptr<string> requestId{};

  ~PutBucketLoggingResponse() = default;
};
class PutBucketRequestPaymentRequestBodyRequestPaymentConfiguration
    : public Darabonba::Model {
public:
  PutBucketRequestPaymentRequestBodyRequestPaymentConfiguration() {}
  explicit PutBucketRequestPaymentRequestBodyRequestPaymentConfiguration(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {}

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (payer) {
      res["Payer"] = boost::any(*payer);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("Payer") != m.end()) {
      payer = make_shared<string>(boost::any_cast<string>(m["Payer"]));
    }
  }

  shared_ptr<string> payer{};

  ~PutBucketRequestPaymentRequestBodyRequestPaymentConfiguration() = default;
};
class PutBucketRequestPaymentRequestBody : public Darabonba::Model {
public:
  PutBucketRequestPaymentRequestBody() {}
  explicit PutBucketRequestPaymentRequestBody(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!requestPaymentConfiguration) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("requestPaymentConfiguration is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (requestPaymentConfiguration) {
      res["RequestPaymentConfiguration"] =
          requestPaymentConfiguration
              ? boost::any(requestPaymentConfiguration->toMap())
              : boost::any(map<string, boost::any>({}));
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("RequestPaymentConfiguration") != m.end()) {
      if (typeid(map<string, boost::any>).name() ==
          m["RequestPaymentConfiguration"].type().name()) {
        PutBucketRequestPaymentRequestBodyRequestPaymentConfiguration model1;
        model1.fromMap(boost::any_cast<map<string, boost::any>>(
            m["RequestPaymentConfiguration"]));
        requestPaymentConfiguration = make_shared<
            PutBucketRequestPaymentRequestBodyRequestPaymentConfiguration>(
            model1);
      }
    }
  }

  shared_ptr<PutBucketRequestPaymentRequestBodyRequestPaymentConfiguration>
      requestPaymentConfiguration{};

  ~PutBucketRequestPaymentRequestBody() = default;
};
class PutBucketRequestPaymentRequest : public Darabonba::Model {
public:
  PutBucketRequestPaymentRequest() {}
  explicit PutBucketRequestPaymentRequest(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!bucketName) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("bucketName is required.")));
    }
    Darabonba::Model::validatePattern("bucketName", bucketName,
                                      "[a-zA-Z0-9\\\\-\\\\_]+");
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (bucketName) {
      res["BucketName"] = boost::any(*bucketName);
    }
    if (body) {
      res["Body"] = body ? boost::any(body->toMap())
                         : boost::any(map<string, boost::any>({}));
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("BucketName") != m.end()) {
      bucketName =
          make_shared<string>(boost::any_cast<string>(m["BucketName"]));
    }
    if (m.find("Body") != m.end()) {
      if (typeid(map<string, boost::any>).name() == m["Body"].type().name()) {
        PutBucketRequestPaymentRequestBody model1;
        model1.fromMap(boost::any_cast<map<string, boost::any>>(m["Body"]));
        body = make_shared<PutBucketRequestPaymentRequestBody>(model1);
      }
    }
  }

  shared_ptr<string> bucketName{};
  shared_ptr<PutBucketRequestPaymentRequestBody> body{};

  ~PutBucketRequestPaymentRequest() = default;
};
class PutBucketRequestPaymentResponse : public Darabonba::Model {
public:
  PutBucketRequestPaymentResponse() {}
  explicit PutBucketRequestPaymentResponse(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!requestId) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("requestId is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (requestId) {
      res["x-oss-request-id"] = boost::any(*requestId);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("x-oss-request-id") != m.end()) {
      requestId =
          make_shared<string>(boost::any_cast<string>(m["x-oss-request-id"]));
    }
  }

  shared_ptr<string> requestId{};

  ~PutBucketRequestPaymentResponse() = default;
};
class
    PutBucketEncryptionRequestBodyServerSideEncryptionRuleApplyServerSideEncryptionByDefault
    : public Darabonba::Model {
public:
  PutBucketEncryptionRequestBodyServerSideEncryptionRuleApplyServerSideEncryptionByDefault() {
  }
  explicit PutBucketEncryptionRequestBodyServerSideEncryptionRuleApplyServerSideEncryptionByDefault(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {}

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (sSEAlgorithm) {
      res["SSEAlgorithm"] = boost::any(*sSEAlgorithm);
    }
    if (kMSMasterKeyID) {
      res["KMSMasterKeyID"] = boost::any(*kMSMasterKeyID);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("SSEAlgorithm") != m.end()) {
      sSEAlgorithm =
          make_shared<string>(boost::any_cast<string>(m["SSEAlgorithm"]));
    }
    if (m.find("KMSMasterKeyID") != m.end()) {
      kMSMasterKeyID =
          make_shared<string>(boost::any_cast<string>(m["KMSMasterKeyID"]));
    }
  }

  shared_ptr<string> sSEAlgorithm{};
  shared_ptr<string> kMSMasterKeyID{};

  ~PutBucketEncryptionRequestBodyServerSideEncryptionRuleApplyServerSideEncryptionByDefault() =
      default;
};
class PutBucketEncryptionRequestBodyServerSideEncryptionRule
    : public Darabonba::Model {
public:
  PutBucketEncryptionRequestBodyServerSideEncryptionRule() {}
  explicit PutBucketEncryptionRequestBodyServerSideEncryptionRule(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {}

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (applyServerSideEncryptionByDefault) {
      res["ApplyServerSideEncryptionByDefault"] =
          applyServerSideEncryptionByDefault
              ? boost::any(applyServerSideEncryptionByDefault->toMap())
              : boost::any(map<string, boost::any>({}));
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("ApplyServerSideEncryptionByDefault") != m.end()) {
      if (typeid(map<string, boost::any>).name() ==
          m["ApplyServerSideEncryptionByDefault"].type().name()) {
        PutBucketEncryptionRequestBodyServerSideEncryptionRuleApplyServerSideEncryptionByDefault
            model1;
        model1.fromMap(boost::any_cast<map<string, boost::any>>(
            m["ApplyServerSideEncryptionByDefault"]));
        applyServerSideEncryptionByDefault = make_shared<
            PutBucketEncryptionRequestBodyServerSideEncryptionRuleApplyServerSideEncryptionByDefault>(
            model1);
      }
    }
  }

  shared_ptr<
      PutBucketEncryptionRequestBodyServerSideEncryptionRuleApplyServerSideEncryptionByDefault>
      applyServerSideEncryptionByDefault{};

  ~PutBucketEncryptionRequestBodyServerSideEncryptionRule() = default;
};
class PutBucketEncryptionRequestBody : public Darabonba::Model {
public:
  PutBucketEncryptionRequestBody() {}
  explicit PutBucketEncryptionRequestBody(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!serverSideEncryptionRule) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("serverSideEncryptionRule is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (serverSideEncryptionRule) {
      res["ServerSideEncryptionRule"] =
          serverSideEncryptionRule
              ? boost::any(serverSideEncryptionRule->toMap())
              : boost::any(map<string, boost::any>({}));
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("ServerSideEncryptionRule") != m.end()) {
      if (typeid(map<string, boost::any>).name() ==
          m["ServerSideEncryptionRule"].type().name()) {
        PutBucketEncryptionRequestBodyServerSideEncryptionRule model1;
        model1.fromMap(boost::any_cast<map<string, boost::any>>(
            m["ServerSideEncryptionRule"]));
        serverSideEncryptionRule =
            make_shared<PutBucketEncryptionRequestBodyServerSideEncryptionRule>(
                model1);
      }
    }
  }

  shared_ptr<PutBucketEncryptionRequestBodyServerSideEncryptionRule>
      serverSideEncryptionRule{};

  ~PutBucketEncryptionRequestBody() = default;
};
class PutBucketEncryptionRequest : public Darabonba::Model {
public:
  PutBucketEncryptionRequest() {}
  explicit PutBucketEncryptionRequest(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!bucketName) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("bucketName is required.")));
    }
    Darabonba::Model::validatePattern("bucketName", bucketName,
                                      "[a-zA-Z0-9\\\\-\\\\_]+");
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (bucketName) {
      res["BucketName"] = boost::any(*bucketName);
    }
    if (body) {
      res["Body"] = body ? boost::any(body->toMap())
                         : boost::any(map<string, boost::any>({}));
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("BucketName") != m.end()) {
      bucketName =
          make_shared<string>(boost::any_cast<string>(m["BucketName"]));
    }
    if (m.find("Body") != m.end()) {
      if (typeid(map<string, boost::any>).name() == m["Body"].type().name()) {
        PutBucketEncryptionRequestBody model1;
        model1.fromMap(boost::any_cast<map<string, boost::any>>(m["Body"]));
        body = make_shared<PutBucketEncryptionRequestBody>(model1);
      }
    }
  }

  shared_ptr<string> bucketName{};
  shared_ptr<PutBucketEncryptionRequestBody> body{};

  ~PutBucketEncryptionRequest() = default;
};
class PutBucketEncryptionResponse : public Darabonba::Model {
public:
  PutBucketEncryptionResponse() {}
  explicit PutBucketEncryptionResponse(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!requestId) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("requestId is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (requestId) {
      res["x-oss-request-id"] = boost::any(*requestId);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("x-oss-request-id") != m.end()) {
      requestId =
          make_shared<string>(boost::any_cast<string>(m["x-oss-request-id"]));
    }
  }

  shared_ptr<string> requestId{};

  ~PutBucketEncryptionResponse() = default;
};
class PutLiveChannelRequestBodyLiveChannelConfigurationTarget
    : public Darabonba::Model {
public:
  PutLiveChannelRequestBodyLiveChannelConfigurationTarget() {}
  explicit PutLiveChannelRequestBodyLiveChannelConfigurationTarget(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {}

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (type) {
      res["Type"] = boost::any(*type);
    }
    if (fragDuration) {
      res["FragDuration"] = boost::any(*fragDuration);
    }
    if (fragCount) {
      res["FragCount"] = boost::any(*fragCount);
    }
    if (playlistName) {
      res["PlaylistName"] = boost::any(*playlistName);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("Type") != m.end()) {
      type = make_shared<string>(boost::any_cast<string>(m["Type"]));
    }
    if (m.find("FragDuration") != m.end()) {
      fragDuration =
          make_shared<string>(boost::any_cast<string>(m["FragDuration"]));
    }
    if (m.find("FragCount") != m.end()) {
      fragCount = make_shared<string>(boost::any_cast<string>(m["FragCount"]));
    }
    if (m.find("PlaylistName") != m.end()) {
      playlistName =
          make_shared<string>(boost::any_cast<string>(m["PlaylistName"]));
    }
  }

  shared_ptr<string> type{};
  shared_ptr<string> fragDuration{};
  shared_ptr<string> fragCount{};
  shared_ptr<string> playlistName{};

  ~PutLiveChannelRequestBodyLiveChannelConfigurationTarget() = default;
};
class PutLiveChannelRequestBodyLiveChannelConfigurationSnapshot
    : public Darabonba::Model {
public:
  PutLiveChannelRequestBodyLiveChannelConfigurationSnapshot() {}
  explicit PutLiveChannelRequestBodyLiveChannelConfigurationSnapshot(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {}

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (roleName) {
      res["RoleName"] = boost::any(*roleName);
    }
    if (destBucket) {
      res["DestBucket"] = boost::any(*destBucket);
    }
    if (notifyTopic) {
      res["NotifyTopic"] = boost::any(*notifyTopic);
    }
    if (interval) {
      res["Interval"] = boost::any(*interval);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("RoleName") != m.end()) {
      roleName = make_shared<string>(boost::any_cast<string>(m["RoleName"]));
    }
    if (m.find("DestBucket") != m.end()) {
      destBucket =
          make_shared<string>(boost::any_cast<string>(m["DestBucket"]));
    }
    if (m.find("NotifyTopic") != m.end()) {
      notifyTopic =
          make_shared<string>(boost::any_cast<string>(m["NotifyTopic"]));
    }
    if (m.find("Interval") != m.end()) {
      interval = make_shared<string>(boost::any_cast<string>(m["Interval"]));
    }
  }

  shared_ptr<string> roleName{};
  shared_ptr<string> destBucket{};
  shared_ptr<string> notifyTopic{};
  shared_ptr<string> interval{};

  ~PutLiveChannelRequestBodyLiveChannelConfigurationSnapshot() = default;
};
class PutLiveChannelRequestBodyLiveChannelConfiguration
    : public Darabonba::Model {
public:
  PutLiveChannelRequestBodyLiveChannelConfiguration() {}
  explicit PutLiveChannelRequestBodyLiveChannelConfiguration(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {}

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (target) {
      res["Target"] = target ? boost::any(target->toMap())
                             : boost::any(map<string, boost::any>({}));
    }
    if (snapshot) {
      res["Snapshot"] = snapshot ? boost::any(snapshot->toMap())
                                 : boost::any(map<string, boost::any>({}));
    }
    if (description) {
      res["Description"] = boost::any(*description);
    }
    if (status) {
      res["Status"] = boost::any(*status);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("Target") != m.end()) {
      if (typeid(map<string, boost::any>).name() == m["Target"].type().name()) {
        PutLiveChannelRequestBodyLiveChannelConfigurationTarget model1;
        model1.fromMap(boost::any_cast<map<string, boost::any>>(m["Target"]));
        target = make_shared<
            PutLiveChannelRequestBodyLiveChannelConfigurationTarget>(model1);
      }
    }
    if (m.find("Snapshot") != m.end()) {
      if (typeid(map<string, boost::any>).name() ==
          m["Snapshot"].type().name()) {
        PutLiveChannelRequestBodyLiveChannelConfigurationSnapshot model1;
        model1.fromMap(boost::any_cast<map<string, boost::any>>(m["Snapshot"]));
        snapshot = make_shared<
            PutLiveChannelRequestBodyLiveChannelConfigurationSnapshot>(model1);
      }
    }
    if (m.find("Description") != m.end()) {
      description =
          make_shared<string>(boost::any_cast<string>(m["Description"]));
    }
    if (m.find("Status") != m.end()) {
      status = make_shared<string>(boost::any_cast<string>(m["Status"]));
    }
  }

  shared_ptr<PutLiveChannelRequestBodyLiveChannelConfigurationTarget> target{};
  shared_ptr<PutLiveChannelRequestBodyLiveChannelConfigurationSnapshot>
      snapshot{};
  shared_ptr<string> description{};
  shared_ptr<string> status{};

  ~PutLiveChannelRequestBodyLiveChannelConfiguration() = default;
};
class PutLiveChannelRequestBody : public Darabonba::Model {
public:
  PutLiveChannelRequestBody() {}
  explicit PutLiveChannelRequestBody(const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!liveChannelConfiguration) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("liveChannelConfiguration is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (liveChannelConfiguration) {
      res["LiveChannelConfiguration"] =
          liveChannelConfiguration
              ? boost::any(liveChannelConfiguration->toMap())
              : boost::any(map<string, boost::any>({}));
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("LiveChannelConfiguration") != m.end()) {
      if (typeid(map<string, boost::any>).name() ==
          m["LiveChannelConfiguration"].type().name()) {
        PutLiveChannelRequestBodyLiveChannelConfiguration model1;
        model1.fromMap(boost::any_cast<map<string, boost::any>>(
            m["LiveChannelConfiguration"]));
        liveChannelConfiguration =
            make_shared<PutLiveChannelRequestBodyLiveChannelConfiguration>(
                model1);
      }
    }
  }

  shared_ptr<PutLiveChannelRequestBodyLiveChannelConfiguration>
      liveChannelConfiguration{};

  ~PutLiveChannelRequestBody() = default;
};
class PutLiveChannelRequest : public Darabonba::Model {
public:
  PutLiveChannelRequest() {}
  explicit PutLiveChannelRequest(const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!bucketName) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("bucketName is required.")));
    }
    Darabonba::Model::validatePattern("bucketName", bucketName,
                                      "[a-zA-Z0-9\\\\-\\\\_]+");
    if (!channelName) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("channelName is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (bucketName) {
      res["BucketName"] = boost::any(*bucketName);
    }
    if (channelName) {
      res["ChannelName"] = boost::any(*channelName);
    }
    if (body) {
      res["Body"] = body ? boost::any(body->toMap())
                         : boost::any(map<string, boost::any>({}));
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("BucketName") != m.end()) {
      bucketName =
          make_shared<string>(boost::any_cast<string>(m["BucketName"]));
    }
    if (m.find("ChannelName") != m.end()) {
      channelName =
          make_shared<string>(boost::any_cast<string>(m["ChannelName"]));
    }
    if (m.find("Body") != m.end()) {
      if (typeid(map<string, boost::any>).name() == m["Body"].type().name()) {
        PutLiveChannelRequestBody model1;
        model1.fromMap(boost::any_cast<map<string, boost::any>>(m["Body"]));
        body = make_shared<PutLiveChannelRequestBody>(model1);
      }
    }
  }

  shared_ptr<string> bucketName{};
  shared_ptr<string> channelName{};
  shared_ptr<PutLiveChannelRequestBody> body{};

  ~PutLiveChannelRequest() = default;
};
class PutLiveChannelResponseCreateLiveChannelResultPublishUrls
    : public Darabonba::Model {
public:
  PutLiveChannelResponseCreateLiveChannelResultPublishUrls() {}
  explicit PutLiveChannelResponseCreateLiveChannelResultPublishUrls(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {}

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (url) {
      res["Url"] = boost::any(*url);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("Url") != m.end()) {
      url = make_shared<string>(boost::any_cast<string>(m["Url"]));
    }
  }

  shared_ptr<string> url{};

  ~PutLiveChannelResponseCreateLiveChannelResultPublishUrls() = default;
};
class PutLiveChannelResponseCreateLiveChannelResultPlayUrls
    : public Darabonba::Model {
public:
  PutLiveChannelResponseCreateLiveChannelResultPlayUrls() {}
  explicit PutLiveChannelResponseCreateLiveChannelResultPlayUrls(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {}

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (url) {
      res["Url"] = boost::any(*url);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("Url") != m.end()) {
      url = make_shared<string>(boost::any_cast<string>(m["Url"]));
    }
  }

  shared_ptr<string> url{};

  ~PutLiveChannelResponseCreateLiveChannelResultPlayUrls() = default;
};
class PutLiveChannelResponseCreateLiveChannelResult : public Darabonba::Model {
public:
  PutLiveChannelResponseCreateLiveChannelResult() {}
  explicit PutLiveChannelResponseCreateLiveChannelResult(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!publishUrls) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("publishUrls is required.")));
    }
    if (!playUrls) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("playUrls is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (publishUrls) {
      res["PublishUrls"] = publishUrls
                               ? boost::any(publishUrls->toMap())
                               : boost::any(map<string, boost::any>({}));
    }
    if (playUrls) {
      res["PlayUrls"] = playUrls ? boost::any(playUrls->toMap())
                                 : boost::any(map<string, boost::any>({}));
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("PublishUrls") != m.end()) {
      if (typeid(map<string, boost::any>).name() ==
          m["PublishUrls"].type().name()) {
        PutLiveChannelResponseCreateLiveChannelResultPublishUrls model1;
        model1.fromMap(
            boost::any_cast<map<string, boost::any>>(m["PublishUrls"]));
        publishUrls = make_shared<
            PutLiveChannelResponseCreateLiveChannelResultPublishUrls>(model1);
      }
    }
    if (m.find("PlayUrls") != m.end()) {
      if (typeid(map<string, boost::any>).name() ==
          m["PlayUrls"].type().name()) {
        PutLiveChannelResponseCreateLiveChannelResultPlayUrls model1;
        model1.fromMap(boost::any_cast<map<string, boost::any>>(m["PlayUrls"]));
        playUrls =
            make_shared<PutLiveChannelResponseCreateLiveChannelResultPlayUrls>(
                model1);
      }
    }
  }

  shared_ptr<PutLiveChannelResponseCreateLiveChannelResultPublishUrls>
      publishUrls{};
  shared_ptr<PutLiveChannelResponseCreateLiveChannelResultPlayUrls> playUrls{};

  ~PutLiveChannelResponseCreateLiveChannelResult() = default;
};
class PutLiveChannelResponse : public Darabonba::Model {
public:
  PutLiveChannelResponse() {}
  explicit PutLiveChannelResponse(const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!requestId) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("requestId is required.")));
    }
    if (!createLiveChannelResult) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("createLiveChannelResult is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (requestId) {
      res["x-oss-request-id"] = boost::any(*requestId);
    }
    if (createLiveChannelResult) {
      res["CreateLiveChannelResult"] =
          createLiveChannelResult ? boost::any(createLiveChannelResult->toMap())
                                  : boost::any(map<string, boost::any>({}));
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("x-oss-request-id") != m.end()) {
      requestId =
          make_shared<string>(boost::any_cast<string>(m["x-oss-request-id"]));
    }
    if (m.find("CreateLiveChannelResult") != m.end()) {
      if (typeid(map<string, boost::any>).name() ==
          m["CreateLiveChannelResult"].type().name()) {
        PutLiveChannelResponseCreateLiveChannelResult model1;
        model1.fromMap(boost::any_cast<map<string, boost::any>>(
            m["CreateLiveChannelResult"]));
        createLiveChannelResult =
            make_shared<PutLiveChannelResponseCreateLiveChannelResult>(model1);
      }
    }
  }

  shared_ptr<string> requestId{};
  shared_ptr<PutLiveChannelResponseCreateLiveChannelResult>
      createLiveChannelResult{};

  ~PutLiveChannelResponse() = default;
};
class PutBucketTagsRequestBodyTaggingTagSetTag : public Darabonba::Model {
public:
  PutBucketTagsRequestBodyTaggingTagSetTag() {}
  explicit PutBucketTagsRequestBodyTaggingTagSetTag(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {}

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (key) {
      res["Key"] = boost::any(*key);
    }
    if (value) {
      res["Value"] = boost::any(*value);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("Key") != m.end()) {
      key = make_shared<string>(boost::any_cast<string>(m["Key"]));
    }
    if (m.find("Value") != m.end()) {
      value = make_shared<string>(boost::any_cast<string>(m["Value"]));
    }
  }

  shared_ptr<string> key{};
  shared_ptr<string> value{};

  ~PutBucketTagsRequestBodyTaggingTagSetTag() = default;
};
class PutBucketTagsRequestBodyTaggingTagSet : public Darabonba::Model {
public:
  PutBucketTagsRequestBodyTaggingTagSet() {}
  explicit PutBucketTagsRequestBodyTaggingTagSet(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {}

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (tag) {
      vector<boost::any> temp1;
      for (auto item1 : *tag) {
        temp1.push_back(boost::any(item1.toMap()));
      }
      res["Tag"] = boost::any(temp1);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("Tag") != m.end()) {
      if (typeid(vector<boost::any>).name() == m["Tag"].type().name()) {
        vector<PutBucketTagsRequestBodyTaggingTagSetTag> expect1;
        for (auto item1 : boost::any_cast<vector<boost::any>>(m["Tag"])) {
          if (typeid(map<string, boost::any>).name() == item1.type().name()) {
            PutBucketTagsRequestBodyTaggingTagSetTag model2;
            model2.fromMap(boost::any_cast<map<string, boost::any>>(item1));
            expect1.push_back(model2);
          }
        }
        tag = make_shared<vector<PutBucketTagsRequestBodyTaggingTagSetTag>>(
            expect1);
      }
    }
  }

  shared_ptr<vector<PutBucketTagsRequestBodyTaggingTagSetTag>> tag{};

  ~PutBucketTagsRequestBodyTaggingTagSet() = default;
};
class PutBucketTagsRequestBodyTagging : public Darabonba::Model {
public:
  PutBucketTagsRequestBodyTagging() {}
  explicit PutBucketTagsRequestBodyTagging(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {}

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (tagSet) {
      res["TagSet"] = tagSet ? boost::any(tagSet->toMap())
                             : boost::any(map<string, boost::any>({}));
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("TagSet") != m.end()) {
      if (typeid(map<string, boost::any>).name() == m["TagSet"].type().name()) {
        PutBucketTagsRequestBodyTaggingTagSet model1;
        model1.fromMap(boost::any_cast<map<string, boost::any>>(m["TagSet"]));
        tagSet = make_shared<PutBucketTagsRequestBodyTaggingTagSet>(model1);
      }
    }
  }

  shared_ptr<PutBucketTagsRequestBodyTaggingTagSet> tagSet{};

  ~PutBucketTagsRequestBodyTagging() = default;
};
class PutBucketTagsRequestBody : public Darabonba::Model {
public:
  PutBucketTagsRequestBody() {}
  explicit PutBucketTagsRequestBody(const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!tagging) {
      BOOST_THROW_EXCEPTION(
          boost::enable_error_info(std::runtime_error("tagging is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (tagging) {
      res["Tagging"] = tagging ? boost::any(tagging->toMap())
                               : boost::any(map<string, boost::any>({}));
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("Tagging") != m.end()) {
      if (typeid(map<string, boost::any>).name() ==
          m["Tagging"].type().name()) {
        PutBucketTagsRequestBodyTagging model1;
        model1.fromMap(boost::any_cast<map<string, boost::any>>(m["Tagging"]));
        tagging = make_shared<PutBucketTagsRequestBodyTagging>(model1);
      }
    }
  }

  shared_ptr<PutBucketTagsRequestBodyTagging> tagging{};

  ~PutBucketTagsRequestBody() = default;
};
class PutBucketTagsRequest : public Darabonba::Model {
public:
  PutBucketTagsRequest() {}
  explicit PutBucketTagsRequest(const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!bucketName) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("bucketName is required.")));
    }
    Darabonba::Model::validatePattern("bucketName", bucketName,
                                      "[a-zA-Z0-9\\\\-\\\\_]+");
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (bucketName) {
      res["BucketName"] = boost::any(*bucketName);
    }
    if (body) {
      res["Body"] = body ? boost::any(body->toMap())
                         : boost::any(map<string, boost::any>({}));
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("BucketName") != m.end()) {
      bucketName =
          make_shared<string>(boost::any_cast<string>(m["BucketName"]));
    }
    if (m.find("Body") != m.end()) {
      if (typeid(map<string, boost::any>).name() == m["Body"].type().name()) {
        PutBucketTagsRequestBody model1;
        model1.fromMap(boost::any_cast<map<string, boost::any>>(m["Body"]));
        body = make_shared<PutBucketTagsRequestBody>(model1);
      }
    }
  }

  shared_ptr<string> bucketName{};
  shared_ptr<PutBucketTagsRequestBody> body{};

  ~PutBucketTagsRequest() = default;
};
class PutBucketTagsResponse : public Darabonba::Model {
public:
  PutBucketTagsResponse() {}
  explicit PutBucketTagsResponse(const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!requestId) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("requestId is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (requestId) {
      res["x-oss-request-id"] = boost::any(*requestId);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("x-oss-request-id") != m.end()) {
      requestId =
          make_shared<string>(boost::any_cast<string>(m["x-oss-request-id"]));
    }
  }

  shared_ptr<string> requestId{};

  ~PutBucketTagsResponse() = default;
};
class PutObjectTaggingRequestBodyTaggingTagSetTag : public Darabonba::Model {
public:
  PutObjectTaggingRequestBodyTaggingTagSetTag() {}
  explicit PutObjectTaggingRequestBodyTaggingTagSetTag(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {}

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (key) {
      res["Key"] = boost::any(*key);
    }
    if (value) {
      res["Value"] = boost::any(*value);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("Key") != m.end()) {
      key = make_shared<string>(boost::any_cast<string>(m["Key"]));
    }
    if (m.find("Value") != m.end()) {
      value = make_shared<string>(boost::any_cast<string>(m["Value"]));
    }
  }

  shared_ptr<string> key{};
  shared_ptr<string> value{};

  ~PutObjectTaggingRequestBodyTaggingTagSetTag() = default;
};
class PutObjectTaggingRequestBodyTaggingTagSet : public Darabonba::Model {
public:
  PutObjectTaggingRequestBodyTaggingTagSet() {}
  explicit PutObjectTaggingRequestBodyTaggingTagSet(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {}

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (tag) {
      vector<boost::any> temp1;
      for (auto item1 : *tag) {
        temp1.push_back(boost::any(item1.toMap()));
      }
      res["Tag"] = boost::any(temp1);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("Tag") != m.end()) {
      if (typeid(vector<boost::any>).name() == m["Tag"].type().name()) {
        vector<PutObjectTaggingRequestBodyTaggingTagSetTag> expect1;
        for (auto item1 : boost::any_cast<vector<boost::any>>(m["Tag"])) {
          if (typeid(map<string, boost::any>).name() == item1.type().name()) {
            PutObjectTaggingRequestBodyTaggingTagSetTag model2;
            model2.fromMap(boost::any_cast<map<string, boost::any>>(item1));
            expect1.push_back(model2);
          }
        }
        tag = make_shared<vector<PutObjectTaggingRequestBodyTaggingTagSetTag>>(
            expect1);
      }
    }
  }

  shared_ptr<vector<PutObjectTaggingRequestBodyTaggingTagSetTag>> tag{};

  ~PutObjectTaggingRequestBodyTaggingTagSet() = default;
};
class PutObjectTaggingRequestBodyTagging : public Darabonba::Model {
public:
  PutObjectTaggingRequestBodyTagging() {}
  explicit PutObjectTaggingRequestBodyTagging(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {}

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (tagSet) {
      res["TagSet"] = tagSet ? boost::any(tagSet->toMap())
                             : boost::any(map<string, boost::any>({}));
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("TagSet") != m.end()) {
      if (typeid(map<string, boost::any>).name() == m["TagSet"].type().name()) {
        PutObjectTaggingRequestBodyTaggingTagSet model1;
        model1.fromMap(boost::any_cast<map<string, boost::any>>(m["TagSet"]));
        tagSet = make_shared<PutObjectTaggingRequestBodyTaggingTagSet>(model1);
      }
    }
  }

  shared_ptr<PutObjectTaggingRequestBodyTaggingTagSet> tagSet{};

  ~PutObjectTaggingRequestBodyTagging() = default;
};
class PutObjectTaggingRequestBody : public Darabonba::Model {
public:
  PutObjectTaggingRequestBody() {}
  explicit PutObjectTaggingRequestBody(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!tagging) {
      BOOST_THROW_EXCEPTION(
          boost::enable_error_info(std::runtime_error("tagging is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (tagging) {
      res["Tagging"] = tagging ? boost::any(tagging->toMap())
                               : boost::any(map<string, boost::any>({}));
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("Tagging") != m.end()) {
      if (typeid(map<string, boost::any>).name() ==
          m["Tagging"].type().name()) {
        PutObjectTaggingRequestBodyTagging model1;
        model1.fromMap(boost::any_cast<map<string, boost::any>>(m["Tagging"]));
        tagging = make_shared<PutObjectTaggingRequestBodyTagging>(model1);
      }
    }
  }

  shared_ptr<PutObjectTaggingRequestBodyTagging> tagging{};

  ~PutObjectTaggingRequestBody() = default;
};
class PutObjectTaggingRequest : public Darabonba::Model {
public:
  PutObjectTaggingRequest() {}
  explicit PutObjectTaggingRequest(const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!bucketName) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("bucketName is required.")));
    }
    Darabonba::Model::validatePattern("bucketName", bucketName,
                                      "[a-zA-Z0-9\\\\-\\\\_]+");
    if (!objectName) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("objectName is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (bucketName) {
      res["BucketName"] = boost::any(*bucketName);
    }
    if (objectName) {
      res["ObjectName"] = boost::any(*objectName);
    }
    if (body) {
      res["Body"] = body ? boost::any(body->toMap())
                         : boost::any(map<string, boost::any>({}));
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("BucketName") != m.end()) {
      bucketName =
          make_shared<string>(boost::any_cast<string>(m["BucketName"]));
    }
    if (m.find("ObjectName") != m.end()) {
      objectName =
          make_shared<string>(boost::any_cast<string>(m["ObjectName"]));
    }
    if (m.find("Body") != m.end()) {
      if (typeid(map<string, boost::any>).name() == m["Body"].type().name()) {
        PutObjectTaggingRequestBody model1;
        model1.fromMap(boost::any_cast<map<string, boost::any>>(m["Body"]));
        body = make_shared<PutObjectTaggingRequestBody>(model1);
      }
    }
  }

  shared_ptr<string> bucketName{};
  shared_ptr<string> objectName{};
  shared_ptr<PutObjectTaggingRequestBody> body{};

  ~PutObjectTaggingRequest() = default;
};
class PutObjectTaggingResponse : public Darabonba::Model {
public:
  PutObjectTaggingResponse() {}
  explicit PutObjectTaggingResponse(const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!requestId) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("requestId is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (requestId) {
      res["x-oss-request-id"] = boost::any(*requestId);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("x-oss-request-id") != m.end()) {
      requestId =
          make_shared<string>(boost::any_cast<string>(m["x-oss-request-id"]));
    }
  }

  shared_ptr<string> requestId{};

  ~PutObjectTaggingResponse() = default;
};
class SelectObjectRequestFilter : public Darabonba::Model {
public:
  SelectObjectRequestFilter() {}
  explicit SelectObjectRequestFilter(const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!porcess) {
      BOOST_THROW_EXCEPTION(
          boost::enable_error_info(std::runtime_error("porcess is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (porcess) {
      res["x-oss-process"] = boost::any(*porcess);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("x-oss-process") != m.end()) {
      porcess =
          make_shared<string>(boost::any_cast<string>(m["x-oss-process"]));
    }
  }

  shared_ptr<string> porcess{};

  ~SelectObjectRequestFilter() = default;
};
class SelectObjectRequestBodySelectRequestInputSerializationCSV
    : public Darabonba::Model {
public:
  SelectObjectRequestBodySelectRequestInputSerializationCSV() {}
  explicit SelectObjectRequestBodySelectRequestInputSerializationCSV(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {}

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (fileHeaderInfo) {
      res["FileHeaderInfo"] = boost::any(*fileHeaderInfo);
    }
    if (recordDelimiter) {
      res["RecordDelimiter"] = boost::any(*recordDelimiter);
    }
    if (fieldDelimiter) {
      res["FieldDelimiter"] = boost::any(*fieldDelimiter);
    }
    if (quoteCharacter) {
      res["QuoteCharacter"] = boost::any(*quoteCharacter);
    }
    if (commentCharacter) {
      res["CommentCharacter"] = boost::any(*commentCharacter);
    }
    if (range) {
      res["Range"] = boost::any(*range);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("FileHeaderInfo") != m.end()) {
      fileHeaderInfo =
          make_shared<string>(boost::any_cast<string>(m["FileHeaderInfo"]));
    }
    if (m.find("RecordDelimiter") != m.end()) {
      recordDelimiter =
          make_shared<string>(boost::any_cast<string>(m["RecordDelimiter"]));
    }
    if (m.find("FieldDelimiter") != m.end()) {
      fieldDelimiter =
          make_shared<string>(boost::any_cast<string>(m["FieldDelimiter"]));
    }
    if (m.find("QuoteCharacter") != m.end()) {
      quoteCharacter =
          make_shared<string>(boost::any_cast<string>(m["QuoteCharacter"]));
    }
    if (m.find("CommentCharacter") != m.end()) {
      commentCharacter =
          make_shared<string>(boost::any_cast<string>(m["CommentCharacter"]));
    }
    if (m.find("Range") != m.end()) {
      range = make_shared<string>(boost::any_cast<string>(m["Range"]));
    }
  }

  shared_ptr<string> fileHeaderInfo{};
  shared_ptr<string> recordDelimiter{};
  shared_ptr<string> fieldDelimiter{};
  shared_ptr<string> quoteCharacter{};
  shared_ptr<string> commentCharacter{};
  shared_ptr<string> range{};

  ~SelectObjectRequestBodySelectRequestInputSerializationCSV() = default;
};
class SelectObjectRequestBodySelectRequestInputSerialization
    : public Darabonba::Model {
public:
  SelectObjectRequestBodySelectRequestInputSerialization() {}
  explicit SelectObjectRequestBodySelectRequestInputSerialization(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {}

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (cSV) {
      res["CSV"] = cSV ? boost::any(cSV->toMap())
                       : boost::any(map<string, boost::any>({}));
    }
    if (compressionType) {
      res["CompressionType"] = boost::any(*compressionType);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("CSV") != m.end()) {
      if (typeid(map<string, boost::any>).name() == m["CSV"].type().name()) {
        SelectObjectRequestBodySelectRequestInputSerializationCSV model1;
        model1.fromMap(boost::any_cast<map<string, boost::any>>(m["CSV"]));
        cSV = make_shared<
            SelectObjectRequestBodySelectRequestInputSerializationCSV>(model1);
      }
    }
    if (m.find("CompressionType") != m.end()) {
      compressionType =
          make_shared<string>(boost::any_cast<string>(m["CompressionType"]));
    }
  }

  shared_ptr<SelectObjectRequestBodySelectRequestInputSerializationCSV> cSV{};
  shared_ptr<string> compressionType{};

  ~SelectObjectRequestBodySelectRequestInputSerialization() = default;
};
class SelectObjectRequestBodySelectRequestOutputSerializationCSV
    : public Darabonba::Model {
public:
  SelectObjectRequestBodySelectRequestOutputSerializationCSV() {}
  explicit SelectObjectRequestBodySelectRequestOutputSerializationCSV(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {}

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (recordDelimiter) {
      res["RecordDelimiter"] = boost::any(*recordDelimiter);
    }
    if (fieldDelimiter) {
      res["FieldDelimiter"] = boost::any(*fieldDelimiter);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("RecordDelimiter") != m.end()) {
      recordDelimiter =
          make_shared<string>(boost::any_cast<string>(m["RecordDelimiter"]));
    }
    if (m.find("FieldDelimiter") != m.end()) {
      fieldDelimiter =
          make_shared<string>(boost::any_cast<string>(m["FieldDelimiter"]));
    }
  }

  shared_ptr<string> recordDelimiter{};
  shared_ptr<string> fieldDelimiter{};

  ~SelectObjectRequestBodySelectRequestOutputSerializationCSV() = default;
};
class SelectObjectRequestBodySelectRequestOutputSerialization
    : public Darabonba::Model {
public:
  SelectObjectRequestBodySelectRequestOutputSerialization() {}
  explicit SelectObjectRequestBodySelectRequestOutputSerialization(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {}

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (cSV) {
      res["CSV"] = cSV ? boost::any(cSV->toMap())
                       : boost::any(map<string, boost::any>({}));
    }
    if (keepAllColumns) {
      res["KeepAllColumns"] = boost::any(*keepAllColumns);
    }
    if (outputRawData) {
      res["OutputRawData"] = boost::any(*outputRawData);
    }
    if (enablePayloadCrc) {
      res["EnablePayloadCrc"] = boost::any(*enablePayloadCrc);
    }
    if (outputHeader) {
      res["OutputHeader"] = boost::any(*outputHeader);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("CSV") != m.end()) {
      if (typeid(map<string, boost::any>).name() == m["CSV"].type().name()) {
        SelectObjectRequestBodySelectRequestOutputSerializationCSV model1;
        model1.fromMap(boost::any_cast<map<string, boost::any>>(m["CSV"]));
        cSV = make_shared<
            SelectObjectRequestBodySelectRequestOutputSerializationCSV>(model1);
      }
    }
    if (m.find("KeepAllColumns") != m.end()) {
      keepAllColumns =
          make_shared<string>(boost::any_cast<string>(m["KeepAllColumns"]));
    }
    if (m.find("OutputRawData") != m.end()) {
      outputRawData =
          make_shared<string>(boost::any_cast<string>(m["OutputRawData"]));
    }
    if (m.find("EnablePayloadCrc") != m.end()) {
      enablePayloadCrc =
          make_shared<string>(boost::any_cast<string>(m["EnablePayloadCrc"]));
    }
    if (m.find("OutputHeader") != m.end()) {
      outputHeader =
          make_shared<string>(boost::any_cast<string>(m["OutputHeader"]));
    }
  }

  shared_ptr<SelectObjectRequestBodySelectRequestOutputSerializationCSV> cSV{};
  shared_ptr<string> keepAllColumns{};
  shared_ptr<string> outputRawData{};
  shared_ptr<string> enablePayloadCrc{};
  shared_ptr<string> outputHeader{};

  ~SelectObjectRequestBodySelectRequestOutputSerialization() = default;
};
class SelectObjectRequestBodySelectRequestOptions : public Darabonba::Model {
public:
  SelectObjectRequestBodySelectRequestOptions() {}
  explicit SelectObjectRequestBodySelectRequestOptions(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {}

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (skipPartialDataRecord) {
      res["SkipPartialDataRecord"] = boost::any(*skipPartialDataRecord);
    }
    if (maxSkippedRecordsAllowed) {
      res["MaxSkippedRecordsAllowed"] = boost::any(*maxSkippedRecordsAllowed);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("SkipPartialDataRecord") != m.end()) {
      skipPartialDataRecord = make_shared<string>(
          boost::any_cast<string>(m["SkipPartialDataRecord"]));
    }
    if (m.find("MaxSkippedRecordsAllowed") != m.end()) {
      maxSkippedRecordsAllowed = make_shared<string>(
          boost::any_cast<string>(m["MaxSkippedRecordsAllowed"]));
    }
  }

  shared_ptr<string> skipPartialDataRecord{};
  shared_ptr<string> maxSkippedRecordsAllowed{};

  ~SelectObjectRequestBodySelectRequestOptions() = default;
};
class SelectObjectRequestBodySelectRequest : public Darabonba::Model {
public:
  SelectObjectRequestBodySelectRequest() {}
  explicit SelectObjectRequestBodySelectRequest(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {}

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (inputSerialization) {
      res["InputSerialization"] = inputSerialization
                                      ? boost::any(inputSerialization->toMap())
                                      : boost::any(map<string, boost::any>({}));
    }
    if (outputSerialization) {
      res["OutputSerialization"] =
          outputSerialization ? boost::any(outputSerialization->toMap())
                              : boost::any(map<string, boost::any>({}));
    }
    if (options) {
      res["Options"] = options ? boost::any(options->toMap())
                               : boost::any(map<string, boost::any>({}));
    }
    if (expression) {
      res["Expression"] = boost::any(*expression);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("InputSerialization") != m.end()) {
      if (typeid(map<string, boost::any>).name() ==
          m["InputSerialization"].type().name()) {
        SelectObjectRequestBodySelectRequestInputSerialization model1;
        model1.fromMap(
            boost::any_cast<map<string, boost::any>>(m["InputSerialization"]));
        inputSerialization =
            make_shared<SelectObjectRequestBodySelectRequestInputSerialization>(
                model1);
      }
    }
    if (m.find("OutputSerialization") != m.end()) {
      if (typeid(map<string, boost::any>).name() ==
          m["OutputSerialization"].type().name()) {
        SelectObjectRequestBodySelectRequestOutputSerialization model1;
        model1.fromMap(
            boost::any_cast<map<string, boost::any>>(m["OutputSerialization"]));
        outputSerialization = make_shared<
            SelectObjectRequestBodySelectRequestOutputSerialization>(model1);
      }
    }
    if (m.find("Options") != m.end()) {
      if (typeid(map<string, boost::any>).name() ==
          m["Options"].type().name()) {
        SelectObjectRequestBodySelectRequestOptions model1;
        model1.fromMap(boost::any_cast<map<string, boost::any>>(m["Options"]));
        options =
            make_shared<SelectObjectRequestBodySelectRequestOptions>(model1);
      }
    }
    if (m.find("Expression") != m.end()) {
      expression =
          make_shared<string>(boost::any_cast<string>(m["Expression"]));
    }
  }

  shared_ptr<SelectObjectRequestBodySelectRequestInputSerialization>
      inputSerialization{};
  shared_ptr<SelectObjectRequestBodySelectRequestOutputSerialization>
      outputSerialization{};
  shared_ptr<SelectObjectRequestBodySelectRequestOptions> options{};
  shared_ptr<string> expression{};

  ~SelectObjectRequestBodySelectRequest() = default;
};
class SelectObjectRequestBody : public Darabonba::Model {
public:
  SelectObjectRequestBody() {}
  explicit SelectObjectRequestBody(const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!selectRequest) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("selectRequest is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (selectRequest) {
      res["SelectRequest"] = selectRequest
                                 ? boost::any(selectRequest->toMap())
                                 : boost::any(map<string, boost::any>({}));
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("SelectRequest") != m.end()) {
      if (typeid(map<string, boost::any>).name() ==
          m["SelectRequest"].type().name()) {
        SelectObjectRequestBodySelectRequest model1;
        model1.fromMap(
            boost::any_cast<map<string, boost::any>>(m["SelectRequest"]));
        selectRequest =
            make_shared<SelectObjectRequestBodySelectRequest>(model1);
      }
    }
  }

  shared_ptr<SelectObjectRequestBodySelectRequest> selectRequest{};

  ~SelectObjectRequestBody() = default;
};
class SelectObjectRequest : public Darabonba::Model {
public:
  SelectObjectRequest() {}
  explicit SelectObjectRequest(const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!bucketName) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("bucketName is required.")));
    }
    Darabonba::Model::validatePattern("bucketName", bucketName,
                                      "[a-zA-Z0-9\\\\-\\\\_]+");
    if (!objectName) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("objectName is required.")));
    }
    if (!filter) {
      BOOST_THROW_EXCEPTION(
          boost::enable_error_info(std::runtime_error("filter is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (bucketName) {
      res["BucketName"] = boost::any(*bucketName);
    }
    if (objectName) {
      res["ObjectName"] = boost::any(*objectName);
    }
    if (filter) {
      res["Filter"] = filter ? boost::any(filter->toMap())
                             : boost::any(map<string, boost::any>({}));
    }
    if (body) {
      res["Body"] = body ? boost::any(body->toMap())
                         : boost::any(map<string, boost::any>({}));
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("BucketName") != m.end()) {
      bucketName =
          make_shared<string>(boost::any_cast<string>(m["BucketName"]));
    }
    if (m.find("ObjectName") != m.end()) {
      objectName =
          make_shared<string>(boost::any_cast<string>(m["ObjectName"]));
    }
    if (m.find("Filter") != m.end()) {
      if (typeid(map<string, boost::any>).name() == m["Filter"].type().name()) {
        SelectObjectRequestFilter model1;
        model1.fromMap(boost::any_cast<map<string, boost::any>>(m["Filter"]));
        filter = make_shared<SelectObjectRequestFilter>(model1);
      }
    }
    if (m.find("Body") != m.end()) {
      if (typeid(map<string, boost::any>).name() == m["Body"].type().name()) {
        SelectObjectRequestBody model1;
        model1.fromMap(boost::any_cast<map<string, boost::any>>(m["Body"]));
        body = make_shared<SelectObjectRequestBody>(model1);
      }
    }
  }

  shared_ptr<string> bucketName{};
  shared_ptr<string> objectName{};
  shared_ptr<SelectObjectRequestFilter> filter{};
  shared_ptr<SelectObjectRequestBody> body{};

  ~SelectObjectRequest() = default;
};
class SelectObjectResponse : public Darabonba::Model {
public:
  SelectObjectResponse() {}
  explicit SelectObjectResponse(const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!requestId) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("requestId is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (requestId) {
      res["x-oss-request-id"] = boost::any(*requestId);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("x-oss-request-id") != m.end()) {
      requestId =
          make_shared<string>(boost::any_cast<string>(m["x-oss-request-id"]));
    }
  }

  shared_ptr<string> requestId{};

  ~SelectObjectResponse() = default;
};
class PutBucketCORSRequestBodyCORSConfigurationCORSRule
    : public Darabonba::Model {
public:
  PutBucketCORSRequestBodyCORSConfigurationCORSRule() {}
  explicit PutBucketCORSRequestBodyCORSConfigurationCORSRule(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {}

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (allowedOrigin) {
      res["AllowedOrigin"] = boost::any(*allowedOrigin);
    }
    if (allowedMethod) {
      res["AllowedMethod"] = boost::any(*allowedMethod);
    }
    if (allowedHeader) {
      res["AllowedHeader"] = boost::any(*allowedHeader);
    }
    if (exposeHeader) {
      res["ExposeHeader"] = boost::any(*exposeHeader);
    }
    if (maxAgeSeconds) {
      res["MaxAgeSeconds"] = boost::any(*maxAgeSeconds);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("AllowedOrigin") != m.end()) {
      vector<string> toVec1;
      if (typeid(vector<boost::any>).name() ==
          m["AllowedOrigin"].type().name()) {
        vector<boost::any> vec1 =
            boost::any_cast<vector<boost::any>>(m["AllowedOrigin"]);
        for (auto item : vec1) {
          toVec1.push_back(boost::any_cast<string>(item));
        }
      }
      allowedOrigin = make_shared<vector<string>>(toVec1);
    }
    if (m.find("AllowedMethod") != m.end()) {
      vector<string> toVec1;
      if (typeid(vector<boost::any>).name() ==
          m["AllowedMethod"].type().name()) {
        vector<boost::any> vec1 =
            boost::any_cast<vector<boost::any>>(m["AllowedMethod"]);
        for (auto item : vec1) {
          toVec1.push_back(boost::any_cast<string>(item));
        }
      }
      allowedMethod = make_shared<vector<string>>(toVec1);
    }
    if (m.find("AllowedHeader") != m.end()) {
      vector<string> toVec1;
      if (typeid(vector<boost::any>).name() ==
          m["AllowedHeader"].type().name()) {
        vector<boost::any> vec1 =
            boost::any_cast<vector<boost::any>>(m["AllowedHeader"]);
        for (auto item : vec1) {
          toVec1.push_back(boost::any_cast<string>(item));
        }
      }
      allowedHeader = make_shared<vector<string>>(toVec1);
    }
    if (m.find("ExposeHeader") != m.end()) {
      vector<string> toVec1;
      if (typeid(vector<boost::any>).name() ==
          m["ExposeHeader"].type().name()) {
        vector<boost::any> vec1 =
            boost::any_cast<vector<boost::any>>(m["ExposeHeader"]);
        for (auto item : vec1) {
          toVec1.push_back(boost::any_cast<string>(item));
        }
      }
      exposeHeader = make_shared<vector<string>>(toVec1);
    }
    if (m.find("MaxAgeSeconds") != m.end()) {
      maxAgeSeconds =
          make_shared<string>(boost::any_cast<string>(m["MaxAgeSeconds"]));
    }
  }

  shared_ptr<vector<string>> allowedOrigin{};
  shared_ptr<vector<string>> allowedMethod{};
  shared_ptr<vector<string>> allowedHeader{};
  shared_ptr<vector<string>> exposeHeader{};
  shared_ptr<string> maxAgeSeconds{};

  ~PutBucketCORSRequestBodyCORSConfigurationCORSRule() = default;
};
class PutBucketCORSRequestBodyCORSConfiguration : public Darabonba::Model {
public:
  PutBucketCORSRequestBodyCORSConfiguration() {}
  explicit PutBucketCORSRequestBodyCORSConfiguration(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {}

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (cORSRule) {
      vector<boost::any> temp1;
      for (auto item1 : *cORSRule) {
        temp1.push_back(boost::any(item1.toMap()));
      }
      res["CORSRule"] = boost::any(temp1);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("CORSRule") != m.end()) {
      if (typeid(vector<boost::any>).name() == m["CORSRule"].type().name()) {
        vector<PutBucketCORSRequestBodyCORSConfigurationCORSRule> expect1;
        for (auto item1 : boost::any_cast<vector<boost::any>>(m["CORSRule"])) {
          if (typeid(map<string, boost::any>).name() == item1.type().name()) {
            PutBucketCORSRequestBodyCORSConfigurationCORSRule model2;
            model2.fromMap(boost::any_cast<map<string, boost::any>>(item1));
            expect1.push_back(model2);
          }
        }
        cORSRule = make_shared<
            vector<PutBucketCORSRequestBodyCORSConfigurationCORSRule>>(expect1);
      }
    }
  }

  shared_ptr<vector<PutBucketCORSRequestBodyCORSConfigurationCORSRule>>
      cORSRule{};

  ~PutBucketCORSRequestBodyCORSConfiguration() = default;
};
class PutBucketCORSRequestBody : public Darabonba::Model {
public:
  PutBucketCORSRequestBody() {}
  explicit PutBucketCORSRequestBody(const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!cORSConfiguration) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("cORSConfiguration is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (cORSConfiguration) {
      res["CORSConfiguration"] = cORSConfiguration
                                     ? boost::any(cORSConfiguration->toMap())
                                     : boost::any(map<string, boost::any>({}));
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("CORSConfiguration") != m.end()) {
      if (typeid(map<string, boost::any>).name() ==
          m["CORSConfiguration"].type().name()) {
        PutBucketCORSRequestBodyCORSConfiguration model1;
        model1.fromMap(
            boost::any_cast<map<string, boost::any>>(m["CORSConfiguration"]));
        cORSConfiguration =
            make_shared<PutBucketCORSRequestBodyCORSConfiguration>(model1);
      }
    }
  }

  shared_ptr<PutBucketCORSRequestBodyCORSConfiguration> cORSConfiguration{};

  ~PutBucketCORSRequestBody() = default;
};
class PutBucketCORSRequest : public Darabonba::Model {
public:
  PutBucketCORSRequest() {}
  explicit PutBucketCORSRequest(const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!bucketName) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("bucketName is required.")));
    }
    Darabonba::Model::validatePattern("bucketName", bucketName,
                                      "[a-zA-Z0-9\\\\-\\\\_]+");
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (bucketName) {
      res["BucketName"] = boost::any(*bucketName);
    }
    if (body) {
      res["Body"] = body ? boost::any(body->toMap())
                         : boost::any(map<string, boost::any>({}));
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("BucketName") != m.end()) {
      bucketName =
          make_shared<string>(boost::any_cast<string>(m["BucketName"]));
    }
    if (m.find("Body") != m.end()) {
      if (typeid(map<string, boost::any>).name() == m["Body"].type().name()) {
        PutBucketCORSRequestBody model1;
        model1.fromMap(boost::any_cast<map<string, boost::any>>(m["Body"]));
        body = make_shared<PutBucketCORSRequestBody>(model1);
      }
    }
  }

  shared_ptr<string> bucketName{};
  shared_ptr<PutBucketCORSRequestBody> body{};

  ~PutBucketCORSRequest() = default;
};
class PutBucketCORSResponse : public Darabonba::Model {
public:
  PutBucketCORSResponse() {}
  explicit PutBucketCORSResponse(const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!requestId) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("requestId is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (requestId) {
      res["x-oss-request-id"] = boost::any(*requestId);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("x-oss-request-id") != m.end()) {
      requestId =
          make_shared<string>(boost::any_cast<string>(m["x-oss-request-id"]));
    }
  }

  shared_ptr<string> requestId{};

  ~PutBucketCORSResponse() = default;
};
class PutBucketRequestBodyCreateBucketConfiguration : public Darabonba::Model {
public:
  PutBucketRequestBodyCreateBucketConfiguration() {}
  explicit PutBucketRequestBodyCreateBucketConfiguration(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {}

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (storageClass) {
      res["StorageClass"] = boost::any(*storageClass);
    }
    if (dataRedundancyType) {
      res["DataRedundancyType"] = boost::any(*dataRedundancyType);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("StorageClass") != m.end()) {
      storageClass =
          make_shared<string>(boost::any_cast<string>(m["StorageClass"]));
    }
    if (m.find("DataRedundancyType") != m.end()) {
      dataRedundancyType =
          make_shared<string>(boost::any_cast<string>(m["DataRedundancyType"]));
    }
  }

  shared_ptr<string> storageClass{};
  shared_ptr<string> dataRedundancyType{};

  ~PutBucketRequestBodyCreateBucketConfiguration() = default;
};
class PutBucketRequestBody : public Darabonba::Model {
public:
  PutBucketRequestBody() {}
  explicit PutBucketRequestBody(const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!createBucketConfiguration) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("createBucketConfiguration is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (createBucketConfiguration) {
      res["CreateBucketConfiguration"] =
          createBucketConfiguration
              ? boost::any(createBucketConfiguration->toMap())
              : boost::any(map<string, boost::any>({}));
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("CreateBucketConfiguration") != m.end()) {
      if (typeid(map<string, boost::any>).name() ==
          m["CreateBucketConfiguration"].type().name()) {
        PutBucketRequestBodyCreateBucketConfiguration model1;
        model1.fromMap(boost::any_cast<map<string, boost::any>>(
            m["CreateBucketConfiguration"]));
        createBucketConfiguration =
            make_shared<PutBucketRequestBodyCreateBucketConfiguration>(model1);
      }
    }
  }

  shared_ptr<PutBucketRequestBodyCreateBucketConfiguration>
      createBucketConfiguration{};

  ~PutBucketRequestBody() = default;
};
class PutBucketRequestHeader : public Darabonba::Model {
public:
  PutBucketRequestHeader() {}
  explicit PutBucketRequestHeader(const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {}

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (acl) {
      res["x-oss-acl"] = boost::any(*acl);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("x-oss-acl") != m.end()) {
      acl = make_shared<string>(boost::any_cast<string>(m["x-oss-acl"]));
    }
  }

  shared_ptr<string> acl{};

  ~PutBucketRequestHeader() = default;
};
class PutBucketRequest : public Darabonba::Model {
public:
  PutBucketRequest() {}
  explicit PutBucketRequest(const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!bucketName) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("bucketName is required.")));
    }
    Darabonba::Model::validatePattern("bucketName", bucketName,
                                      "[a-zA-Z0-9\\\\-\\\\_]+");
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (bucketName) {
      res["BucketName"] = boost::any(*bucketName);
    }
    if (body) {
      res["Body"] = body ? boost::any(body->toMap())
                         : boost::any(map<string, boost::any>({}));
    }
    if (header) {
      res["Header"] = header ? boost::any(header->toMap())
                             : boost::any(map<string, boost::any>({}));
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("BucketName") != m.end()) {
      bucketName =
          make_shared<string>(boost::any_cast<string>(m["BucketName"]));
    }
    if (m.find("Body") != m.end()) {
      if (typeid(map<string, boost::any>).name() == m["Body"].type().name()) {
        PutBucketRequestBody model1;
        model1.fromMap(boost::any_cast<map<string, boost::any>>(m["Body"]));
        body = make_shared<PutBucketRequestBody>(model1);
      }
    }
    if (m.find("Header") != m.end()) {
      if (typeid(map<string, boost::any>).name() == m["Header"].type().name()) {
        PutBucketRequestHeader model1;
        model1.fromMap(boost::any_cast<map<string, boost::any>>(m["Header"]));
        header = make_shared<PutBucketRequestHeader>(model1);
      }
    }
  }

  shared_ptr<string> bucketName{};
  shared_ptr<PutBucketRequestBody> body{};
  shared_ptr<PutBucketRequestHeader> header{};

  ~PutBucketRequest() = default;
};
class PutBucketResponse : public Darabonba::Model {
public:
  PutBucketResponse() {}
  explicit PutBucketResponse(const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!requestId) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("requestId is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (requestId) {
      res["x-oss-request-id"] = boost::any(*requestId);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("x-oss-request-id") != m.end()) {
      requestId =
          make_shared<string>(boost::any_cast<string>(m["x-oss-request-id"]));
    }
  }

  shared_ptr<string> requestId{};

  ~PutBucketResponse() = default;
};
class ListMultipartUploadsRequestFilter : public Darabonba::Model {
public:
  ListMultipartUploadsRequestFilter() {}
  explicit ListMultipartUploadsRequestFilter(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {}

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (delimiter) {
      res["delimiter"] = boost::any(*delimiter);
    }
    if (maxUploads) {
      res["max-uploads"] = boost::any(*maxUploads);
    }
    if (keyMarker) {
      res["key-marker"] = boost::any(*keyMarker);
    }
    if (prefix) {
      res["prefix"] = boost::any(*prefix);
    }
    if (uploadIdMarker) {
      res["upload-id-marker"] = boost::any(*uploadIdMarker);
    }
    if (encodingType) {
      res["encoding-type"] = boost::any(*encodingType);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("delimiter") != m.end()) {
      delimiter = make_shared<string>(boost::any_cast<string>(m["delimiter"]));
    }
    if (m.find("max-uploads") != m.end()) {
      maxUploads =
          make_shared<string>(boost::any_cast<string>(m["max-uploads"]));
    }
    if (m.find("key-marker") != m.end()) {
      keyMarker = make_shared<string>(boost::any_cast<string>(m["key-marker"]));
    }
    if (m.find("prefix") != m.end()) {
      prefix = make_shared<string>(boost::any_cast<string>(m["prefix"]));
    }
    if (m.find("upload-id-marker") != m.end()) {
      uploadIdMarker =
          make_shared<string>(boost::any_cast<string>(m["upload-id-marker"]));
    }
    if (m.find("encoding-type") != m.end()) {
      encodingType =
          make_shared<string>(boost::any_cast<string>(m["encoding-type"]));
    }
  }

  shared_ptr<string> delimiter{};
  shared_ptr<string> maxUploads{};
  shared_ptr<string> keyMarker{};
  shared_ptr<string> prefix{};
  shared_ptr<string> uploadIdMarker{};
  shared_ptr<string> encodingType{};

  ~ListMultipartUploadsRequestFilter() = default;
};
class ListMultipartUploadsRequest : public Darabonba::Model {
public:
  ListMultipartUploadsRequest() {}
  explicit ListMultipartUploadsRequest(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!bucketName) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("bucketName is required.")));
    }
    Darabonba::Model::validatePattern("bucketName", bucketName,
                                      "[a-zA-Z0-9\\\\-\\\\_]+");
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (bucketName) {
      res["BucketName"] = boost::any(*bucketName);
    }
    if (filter) {
      res["Filter"] = filter ? boost::any(filter->toMap())
                             : boost::any(map<string, boost::any>({}));
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("BucketName") != m.end()) {
      bucketName =
          make_shared<string>(boost::any_cast<string>(m["BucketName"]));
    }
    if (m.find("Filter") != m.end()) {
      if (typeid(map<string, boost::any>).name() == m["Filter"].type().name()) {
        ListMultipartUploadsRequestFilter model1;
        model1.fromMap(boost::any_cast<map<string, boost::any>>(m["Filter"]));
        filter = make_shared<ListMultipartUploadsRequestFilter>(model1);
      }
    }
  }

  shared_ptr<string> bucketName{};
  shared_ptr<ListMultipartUploadsRequestFilter> filter{};

  ~ListMultipartUploadsRequest() = default;
};
class ListMultipartUploadsResponseListMultipartUploadsResultUpload
    : public Darabonba::Model {
public:
  ListMultipartUploadsResponseListMultipartUploadsResultUpload() {}
  explicit ListMultipartUploadsResponseListMultipartUploadsResultUpload(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {}

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (key) {
      res["Key"] = boost::any(*key);
    }
    if (uploadId) {
      res["UploadId"] = boost::any(*uploadId);
    }
    if (initiated) {
      res["Initiated"] = boost::any(*initiated);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("Key") != m.end()) {
      key = make_shared<string>(boost::any_cast<string>(m["Key"]));
    }
    if (m.find("UploadId") != m.end()) {
      uploadId = make_shared<string>(boost::any_cast<string>(m["UploadId"]));
    }
    if (m.find("Initiated") != m.end()) {
      initiated = make_shared<string>(boost::any_cast<string>(m["Initiated"]));
    }
  }

  shared_ptr<string> key{};
  shared_ptr<string> uploadId{};
  shared_ptr<string> initiated{};

  ~ListMultipartUploadsResponseListMultipartUploadsResultUpload() = default;
};
class ListMultipartUploadsResponseListMultipartUploadsResult
    : public Darabonba::Model {
public:
  ListMultipartUploadsResponseListMultipartUploadsResult() {}
  explicit ListMultipartUploadsResponseListMultipartUploadsResult(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {}

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (bucket) {
      res["Bucket"] = boost::any(*bucket);
    }
    if (encodingType) {
      res["EncodingType"] = boost::any(*encodingType);
    }
    if (keyMarker) {
      res["KeyMarker"] = boost::any(*keyMarker);
    }
    if (uploadIdMarker) {
      res["UploadIdMarker"] = boost::any(*uploadIdMarker);
    }
    if (nextKeyMarker) {
      res["NextKeyMarker"] = boost::any(*nextKeyMarker);
    }
    if (nextUploadIdMarker) {
      res["NextUploadIdMarker"] = boost::any(*nextUploadIdMarker);
    }
    if (delimiter) {
      res["Delimiter"] = boost::any(*delimiter);
    }
    if (maxUploads) {
      res["MaxUploads"] = boost::any(*maxUploads);
    }
    if (isTruncated) {
      res["IsTruncated"] = boost::any(*isTruncated);
    }
    if (upload) {
      vector<boost::any> temp1;
      for (auto item1 : *upload) {
        temp1.push_back(boost::any(item1.toMap()));
      }
      res["Upload"] = boost::any(temp1);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("Bucket") != m.end()) {
      bucket = make_shared<string>(boost::any_cast<string>(m["Bucket"]));
    }
    if (m.find("EncodingType") != m.end()) {
      encodingType =
          make_shared<string>(boost::any_cast<string>(m["EncodingType"]));
    }
    if (m.find("KeyMarker") != m.end()) {
      keyMarker = make_shared<string>(boost::any_cast<string>(m["KeyMarker"]));
    }
    if (m.find("UploadIdMarker") != m.end()) {
      uploadIdMarker =
          make_shared<string>(boost::any_cast<string>(m["UploadIdMarker"]));
    }
    if (m.find("NextKeyMarker") != m.end()) {
      nextKeyMarker =
          make_shared<string>(boost::any_cast<string>(m["NextKeyMarker"]));
    }
    if (m.find("NextUploadIdMarker") != m.end()) {
      nextUploadIdMarker =
          make_shared<string>(boost::any_cast<string>(m["NextUploadIdMarker"]));
    }
    if (m.find("Delimiter") != m.end()) {
      delimiter = make_shared<string>(boost::any_cast<string>(m["Delimiter"]));
    }
    if (m.find("MaxUploads") != m.end()) {
      maxUploads =
          make_shared<string>(boost::any_cast<string>(m["MaxUploads"]));
    }
    if (m.find("IsTruncated") != m.end()) {
      isTruncated =
          make_shared<string>(boost::any_cast<string>(m["IsTruncated"]));
    }
    if (m.find("Upload") != m.end()) {
      if (typeid(vector<boost::any>).name() == m["Upload"].type().name()) {
        vector<ListMultipartUploadsResponseListMultipartUploadsResultUpload>
            expect1;
        for (auto item1 : boost::any_cast<vector<boost::any>>(m["Upload"])) {
          if (typeid(map<string, boost::any>).name() == item1.type().name()) {
            ListMultipartUploadsResponseListMultipartUploadsResultUpload model2;
            model2.fromMap(boost::any_cast<map<string, boost::any>>(item1));
            expect1.push_back(model2);
          }
        }
        upload = make_shared<vector<
            ListMultipartUploadsResponseListMultipartUploadsResultUpload>>(
            expect1);
      }
    }
  }

  shared_ptr<string> bucket{};
  shared_ptr<string> encodingType{};
  shared_ptr<string> keyMarker{};
  shared_ptr<string> uploadIdMarker{};
  shared_ptr<string> nextKeyMarker{};
  shared_ptr<string> nextUploadIdMarker{};
  shared_ptr<string> delimiter{};
  shared_ptr<string> maxUploads{};
  shared_ptr<string> isTruncated{};
  shared_ptr<
      vector<ListMultipartUploadsResponseListMultipartUploadsResultUpload>>
      upload{};

  ~ListMultipartUploadsResponseListMultipartUploadsResult() = default;
};
class ListMultipartUploadsResponse : public Darabonba::Model {
public:
  ListMultipartUploadsResponse() {}
  explicit ListMultipartUploadsResponse(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!requestId) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("requestId is required.")));
    }
    if (!listMultipartUploadsResult) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("listMultipartUploadsResult is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (requestId) {
      res["x-oss-request-id"] = boost::any(*requestId);
    }
    if (listMultipartUploadsResult) {
      res["ListMultipartUploadsResult"] =
          listMultipartUploadsResult
              ? boost::any(listMultipartUploadsResult->toMap())
              : boost::any(map<string, boost::any>({}));
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("x-oss-request-id") != m.end()) {
      requestId =
          make_shared<string>(boost::any_cast<string>(m["x-oss-request-id"]));
    }
    if (m.find("ListMultipartUploadsResult") != m.end()) {
      if (typeid(map<string, boost::any>).name() ==
          m["ListMultipartUploadsResult"].type().name()) {
        ListMultipartUploadsResponseListMultipartUploadsResult model1;
        model1.fromMap(boost::any_cast<map<string, boost::any>>(
            m["ListMultipartUploadsResult"]));
        listMultipartUploadsResult =
            make_shared<ListMultipartUploadsResponseListMultipartUploadsResult>(
                model1);
      }
    }
  }

  shared_ptr<string> requestId{};
  shared_ptr<ListMultipartUploadsResponseListMultipartUploadsResult>
      listMultipartUploadsResult{};

  ~ListMultipartUploadsResponse() = default;
};
class GetBucketRequestPaymentRequest : public Darabonba::Model {
public:
  GetBucketRequestPaymentRequest() {}
  explicit GetBucketRequestPaymentRequest(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!bucketName) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("bucketName is required.")));
    }
    Darabonba::Model::validatePattern("bucketName", bucketName,
                                      "[a-zA-Z0-9\\\\-\\\\_]+");
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (bucketName) {
      res["BucketName"] = boost::any(*bucketName);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("BucketName") != m.end()) {
      bucketName =
          make_shared<string>(boost::any_cast<string>(m["BucketName"]));
    }
  }

  shared_ptr<string> bucketName{};

  ~GetBucketRequestPaymentRequest() = default;
};
class GetBucketRequestPaymentResponseRequestPaymentConfiguration
    : public Darabonba::Model {
public:
  GetBucketRequestPaymentResponseRequestPaymentConfiguration() {}
  explicit GetBucketRequestPaymentResponseRequestPaymentConfiguration(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {}

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (payer) {
      res["Payer"] = boost::any(*payer);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("Payer") != m.end()) {
      payer = make_shared<string>(boost::any_cast<string>(m["Payer"]));
    }
  }

  shared_ptr<string> payer{};

  ~GetBucketRequestPaymentResponseRequestPaymentConfiguration() = default;
};
class GetBucketRequestPaymentResponse : public Darabonba::Model {
public:
  GetBucketRequestPaymentResponse() {}
  explicit GetBucketRequestPaymentResponse(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!requestId) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("requestId is required.")));
    }
    if (!requestPaymentConfiguration) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("requestPaymentConfiguration is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (requestId) {
      res["x-oss-request-id"] = boost::any(*requestId);
    }
    if (requestPaymentConfiguration) {
      res["RequestPaymentConfiguration"] =
          requestPaymentConfiguration
              ? boost::any(requestPaymentConfiguration->toMap())
              : boost::any(map<string, boost::any>({}));
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("x-oss-request-id") != m.end()) {
      requestId =
          make_shared<string>(boost::any_cast<string>(m["x-oss-request-id"]));
    }
    if (m.find("RequestPaymentConfiguration") != m.end()) {
      if (typeid(map<string, boost::any>).name() ==
          m["RequestPaymentConfiguration"].type().name()) {
        GetBucketRequestPaymentResponseRequestPaymentConfiguration model1;
        model1.fromMap(boost::any_cast<map<string, boost::any>>(
            m["RequestPaymentConfiguration"]));
        requestPaymentConfiguration = make_shared<
            GetBucketRequestPaymentResponseRequestPaymentConfiguration>(model1);
      }
    }
  }

  shared_ptr<string> requestId{};
  shared_ptr<GetBucketRequestPaymentResponseRequestPaymentConfiguration>
      requestPaymentConfiguration{};

  ~GetBucketRequestPaymentResponse() = default;
};
class GetBucketEncryptionRequest : public Darabonba::Model {
public:
  GetBucketEncryptionRequest() {}
  explicit GetBucketEncryptionRequest(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!bucketName) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("bucketName is required.")));
    }
    Darabonba::Model::validatePattern("bucketName", bucketName,
                                      "[a-zA-Z0-9\\\\-\\\\_]+");
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (bucketName) {
      res["BucketName"] = boost::any(*bucketName);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("BucketName") != m.end()) {
      bucketName =
          make_shared<string>(boost::any_cast<string>(m["BucketName"]));
    }
  }

  shared_ptr<string> bucketName{};

  ~GetBucketEncryptionRequest() = default;
};
class
    GetBucketEncryptionResponseServerSideEncryptionRuleApplyServerSideEncryptionByDefault
    : public Darabonba::Model {
public:
  GetBucketEncryptionResponseServerSideEncryptionRuleApplyServerSideEncryptionByDefault() {
  }
  explicit GetBucketEncryptionResponseServerSideEncryptionRuleApplyServerSideEncryptionByDefault(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {}

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (sSEAlgorithm) {
      res["SSEAlgorithm"] = boost::any(*sSEAlgorithm);
    }
    if (kMSMasterKeyID) {
      res["KMSMasterKeyID"] = boost::any(*kMSMasterKeyID);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("SSEAlgorithm") != m.end()) {
      sSEAlgorithm =
          make_shared<string>(boost::any_cast<string>(m["SSEAlgorithm"]));
    }
    if (m.find("KMSMasterKeyID") != m.end()) {
      kMSMasterKeyID =
          make_shared<string>(boost::any_cast<string>(m["KMSMasterKeyID"]));
    }
  }

  shared_ptr<string> sSEAlgorithm{};
  shared_ptr<string> kMSMasterKeyID{};

  ~GetBucketEncryptionResponseServerSideEncryptionRuleApplyServerSideEncryptionByDefault() =
      default;
};
class GetBucketEncryptionResponseServerSideEncryptionRule
    : public Darabonba::Model {
public:
  GetBucketEncryptionResponseServerSideEncryptionRule() {}
  explicit GetBucketEncryptionResponseServerSideEncryptionRule(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!applyServerSideEncryptionByDefault) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(std::runtime_error(
          "applyServerSideEncryptionByDefault is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (applyServerSideEncryptionByDefault) {
      res["ApplyServerSideEncryptionByDefault"] =
          applyServerSideEncryptionByDefault
              ? boost::any(applyServerSideEncryptionByDefault->toMap())
              : boost::any(map<string, boost::any>({}));
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("ApplyServerSideEncryptionByDefault") != m.end()) {
      if (typeid(map<string, boost::any>).name() ==
          m["ApplyServerSideEncryptionByDefault"].type().name()) {
        GetBucketEncryptionResponseServerSideEncryptionRuleApplyServerSideEncryptionByDefault
            model1;
        model1.fromMap(boost::any_cast<map<string, boost::any>>(
            m["ApplyServerSideEncryptionByDefault"]));
        applyServerSideEncryptionByDefault = make_shared<
            GetBucketEncryptionResponseServerSideEncryptionRuleApplyServerSideEncryptionByDefault>(
            model1);
      }
    }
  }

  shared_ptr<
      GetBucketEncryptionResponseServerSideEncryptionRuleApplyServerSideEncryptionByDefault>
      applyServerSideEncryptionByDefault{};

  ~GetBucketEncryptionResponseServerSideEncryptionRule() = default;
};
class GetBucketEncryptionResponse : public Darabonba::Model {
public:
  GetBucketEncryptionResponse() {}
  explicit GetBucketEncryptionResponse(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!requestId) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("requestId is required.")));
    }
    if (!serverSideEncryptionRule) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("serverSideEncryptionRule is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (requestId) {
      res["x-oss-request-id"] = boost::any(*requestId);
    }
    if (serverSideEncryptionRule) {
      res["ServerSideEncryptionRule"] =
          serverSideEncryptionRule
              ? boost::any(serverSideEncryptionRule->toMap())
              : boost::any(map<string, boost::any>({}));
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("x-oss-request-id") != m.end()) {
      requestId =
          make_shared<string>(boost::any_cast<string>(m["x-oss-request-id"]));
    }
    if (m.find("ServerSideEncryptionRule") != m.end()) {
      if (typeid(map<string, boost::any>).name() ==
          m["ServerSideEncryptionRule"].type().name()) {
        GetBucketEncryptionResponseServerSideEncryptionRule model1;
        model1.fromMap(boost::any_cast<map<string, boost::any>>(
            m["ServerSideEncryptionRule"]));
        serverSideEncryptionRule =
            make_shared<GetBucketEncryptionResponseServerSideEncryptionRule>(
                model1);
      }
    }
  }

  shared_ptr<string> requestId{};
  shared_ptr<GetBucketEncryptionResponseServerSideEncryptionRule>
      serverSideEncryptionRule{};

  ~GetBucketEncryptionResponse() = default;
};
class GetBucketTagsRequest : public Darabonba::Model {
public:
  GetBucketTagsRequest() {}
  explicit GetBucketTagsRequest(const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!bucketName) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("bucketName is required.")));
    }
    Darabonba::Model::validatePattern("bucketName", bucketName,
                                      "[a-zA-Z0-9\\\\-\\\\_]+");
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (bucketName) {
      res["BucketName"] = boost::any(*bucketName);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("BucketName") != m.end()) {
      bucketName =
          make_shared<string>(boost::any_cast<string>(m["BucketName"]));
    }
  }

  shared_ptr<string> bucketName{};

  ~GetBucketTagsRequest() = default;
};
class GetBucketTagsResponseTaggingTagSetTag : public Darabonba::Model {
public:
  GetBucketTagsResponseTaggingTagSetTag() {}
  explicit GetBucketTagsResponseTaggingTagSetTag(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {}

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (key) {
      res["Key"] = boost::any(*key);
    }
    if (value) {
      res["Value"] = boost::any(*value);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("Key") != m.end()) {
      key = make_shared<string>(boost::any_cast<string>(m["Key"]));
    }
    if (m.find("Value") != m.end()) {
      value = make_shared<string>(boost::any_cast<string>(m["Value"]));
    }
  }

  shared_ptr<string> key{};
  shared_ptr<string> value{};

  ~GetBucketTagsResponseTaggingTagSetTag() = default;
};
class GetBucketTagsResponseTaggingTagSet : public Darabonba::Model {
public:
  GetBucketTagsResponseTaggingTagSet() {}
  explicit GetBucketTagsResponseTaggingTagSet(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {}

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (tag) {
      vector<boost::any> temp1;
      for (auto item1 : *tag) {
        temp1.push_back(boost::any(item1.toMap()));
      }
      res["Tag"] = boost::any(temp1);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("Tag") != m.end()) {
      if (typeid(vector<boost::any>).name() == m["Tag"].type().name()) {
        vector<GetBucketTagsResponseTaggingTagSetTag> expect1;
        for (auto item1 : boost::any_cast<vector<boost::any>>(m["Tag"])) {
          if (typeid(map<string, boost::any>).name() == item1.type().name()) {
            GetBucketTagsResponseTaggingTagSetTag model2;
            model2.fromMap(boost::any_cast<map<string, boost::any>>(item1));
            expect1.push_back(model2);
          }
        }
        tag =
            make_shared<vector<GetBucketTagsResponseTaggingTagSetTag>>(expect1);
      }
    }
  }

  shared_ptr<vector<GetBucketTagsResponseTaggingTagSetTag>> tag{};

  ~GetBucketTagsResponseTaggingTagSet() = default;
};
class GetBucketTagsResponseTagging : public Darabonba::Model {
public:
  GetBucketTagsResponseTagging() {}
  explicit GetBucketTagsResponseTagging(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!tagSet) {
      BOOST_THROW_EXCEPTION(
          boost::enable_error_info(std::runtime_error("tagSet is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (tagSet) {
      res["TagSet"] = tagSet ? boost::any(tagSet->toMap())
                             : boost::any(map<string, boost::any>({}));
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("TagSet") != m.end()) {
      if (typeid(map<string, boost::any>).name() == m["TagSet"].type().name()) {
        GetBucketTagsResponseTaggingTagSet model1;
        model1.fromMap(boost::any_cast<map<string, boost::any>>(m["TagSet"]));
        tagSet = make_shared<GetBucketTagsResponseTaggingTagSet>(model1);
      }
    }
  }

  shared_ptr<GetBucketTagsResponseTaggingTagSet> tagSet{};

  ~GetBucketTagsResponseTagging() = default;
};
class GetBucketTagsResponse : public Darabonba::Model {
public:
  GetBucketTagsResponse() {}
  explicit GetBucketTagsResponse(const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!requestId) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("requestId is required.")));
    }
    if (!tagging) {
      BOOST_THROW_EXCEPTION(
          boost::enable_error_info(std::runtime_error("tagging is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (requestId) {
      res["x-oss-request-id"] = boost::any(*requestId);
    }
    if (tagging) {
      res["Tagging"] = tagging ? boost::any(tagging->toMap())
                               : boost::any(map<string, boost::any>({}));
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("x-oss-request-id") != m.end()) {
      requestId =
          make_shared<string>(boost::any_cast<string>(m["x-oss-request-id"]));
    }
    if (m.find("Tagging") != m.end()) {
      if (typeid(map<string, boost::any>).name() ==
          m["Tagging"].type().name()) {
        GetBucketTagsResponseTagging model1;
        model1.fromMap(boost::any_cast<map<string, boost::any>>(m["Tagging"]));
        tagging = make_shared<GetBucketTagsResponseTagging>(model1);
      }
    }
  }

  shared_ptr<string> requestId{};
  shared_ptr<GetBucketTagsResponseTagging> tagging{};

  ~GetBucketTagsResponse() = default;
};
class GetServiceRequestFilter : public Darabonba::Model {
public:
  GetServiceRequestFilter() {}
  explicit GetServiceRequestFilter(const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {}

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (prefix) {
      res["prefix"] = boost::any(*prefix);
    }
    if (marker) {
      res["marker"] = boost::any(*marker);
    }
    if (maxKeys) {
      res["max-keys"] = boost::any(*maxKeys);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("prefix") != m.end()) {
      prefix = make_shared<string>(boost::any_cast<string>(m["prefix"]));
    }
    if (m.find("marker") != m.end()) {
      marker = make_shared<string>(boost::any_cast<string>(m["marker"]));
    }
    if (m.find("max-keys") != m.end()) {
      maxKeys = make_shared<string>(boost::any_cast<string>(m["max-keys"]));
    }
  }

  shared_ptr<string> prefix{};
  shared_ptr<string> marker{};
  shared_ptr<string> maxKeys{};

  ~GetServiceRequestFilter() = default;
};
class GetServiceRequest : public Darabonba::Model {
public:
  GetServiceRequest() {}
  explicit GetServiceRequest(const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {}

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (filter) {
      res["Filter"] = filter ? boost::any(filter->toMap())
                             : boost::any(map<string, boost::any>({}));
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("Filter") != m.end()) {
      if (typeid(map<string, boost::any>).name() == m["Filter"].type().name()) {
        GetServiceRequestFilter model1;
        model1.fromMap(boost::any_cast<map<string, boost::any>>(m["Filter"]));
        filter = make_shared<GetServiceRequestFilter>(model1);
      }
    }
  }

  shared_ptr<GetServiceRequestFilter> filter{};

  ~GetServiceRequest() = default;
};
class GetServiceResponseListAllMyBucketsResultOwner : public Darabonba::Model {
public:
  GetServiceResponseListAllMyBucketsResultOwner() {}
  explicit GetServiceResponseListAllMyBucketsResultOwner(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {}

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (iD) {
      res["ID"] = boost::any(*iD);
    }
    if (displayName) {
      res["DisplayName"] = boost::any(*displayName);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("ID") != m.end()) {
      iD = make_shared<string>(boost::any_cast<string>(m["ID"]));
    }
    if (m.find("DisplayName") != m.end()) {
      displayName =
          make_shared<string>(boost::any_cast<string>(m["DisplayName"]));
    }
  }

  shared_ptr<string> iD{};
  shared_ptr<string> displayName{};

  ~GetServiceResponseListAllMyBucketsResultOwner() = default;
};
class GetServiceResponseListAllMyBucketsResultBucketsBucket
    : public Darabonba::Model {
public:
  GetServiceResponseListAllMyBucketsResultBucketsBucket() {}
  explicit GetServiceResponseListAllMyBucketsResultBucketsBucket(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {}

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (name) {
      res["Name"] = boost::any(*name);
    }
    if (createDate) {
      res["CreateDate"] = boost::any(*createDate);
    }
    if (location) {
      res["Location"] = boost::any(*location);
    }
    if (extranetEndpoint) {
      res["ExtranetEndpoint"] = boost::any(*extranetEndpoint);
    }
    if (intranetEndpoint) {
      res["IntranetEndpoint"] = boost::any(*intranetEndpoint);
    }
    if (storageClass) {
      res["StorageClass"] = boost::any(*storageClass);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("Name") != m.end()) {
      name = make_shared<string>(boost::any_cast<string>(m["Name"]));
    }
    if (m.find("CreateDate") != m.end()) {
      createDate =
          make_shared<string>(boost::any_cast<string>(m["CreateDate"]));
    }
    if (m.find("Location") != m.end()) {
      location = make_shared<string>(boost::any_cast<string>(m["Location"]));
    }
    if (m.find("ExtranetEndpoint") != m.end()) {
      extranetEndpoint =
          make_shared<string>(boost::any_cast<string>(m["ExtranetEndpoint"]));
    }
    if (m.find("IntranetEndpoint") != m.end()) {
      intranetEndpoint =
          make_shared<string>(boost::any_cast<string>(m["IntranetEndpoint"]));
    }
    if (m.find("StorageClass") != m.end()) {
      storageClass =
          make_shared<string>(boost::any_cast<string>(m["StorageClass"]));
    }
  }

  shared_ptr<string> name{};
  shared_ptr<string> createDate{};
  shared_ptr<string> location{};
  shared_ptr<string> extranetEndpoint{};
  shared_ptr<string> intranetEndpoint{};
  shared_ptr<string> storageClass{};

  ~GetServiceResponseListAllMyBucketsResultBucketsBucket() = default;
};
class GetServiceResponseListAllMyBucketsResultBuckets
    : public Darabonba::Model {
public:
  GetServiceResponseListAllMyBucketsResultBuckets() {}
  explicit GetServiceResponseListAllMyBucketsResultBuckets(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {}

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (bucket) {
      vector<boost::any> temp1;
      for (auto item1 : *bucket) {
        temp1.push_back(boost::any(item1.toMap()));
      }
      res["Bucket"] = boost::any(temp1);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("Bucket") != m.end()) {
      if (typeid(vector<boost::any>).name() == m["Bucket"].type().name()) {
        vector<GetServiceResponseListAllMyBucketsResultBucketsBucket> expect1;
        for (auto item1 : boost::any_cast<vector<boost::any>>(m["Bucket"])) {
          if (typeid(map<string, boost::any>).name() == item1.type().name()) {
            GetServiceResponseListAllMyBucketsResultBucketsBucket model2;
            model2.fromMap(boost::any_cast<map<string, boost::any>>(item1));
            expect1.push_back(model2);
          }
        }
        bucket = make_shared<
            vector<GetServiceResponseListAllMyBucketsResultBucketsBucket>>(
            expect1);
      }
    }
  }

  shared_ptr<vector<GetServiceResponseListAllMyBucketsResultBucketsBucket>>
      bucket{};

  ~GetServiceResponseListAllMyBucketsResultBuckets() = default;
};
class GetServiceResponseListAllMyBucketsResult : public Darabonba::Model {
public:
  GetServiceResponseListAllMyBucketsResult() {}
  explicit GetServiceResponseListAllMyBucketsResult(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!owner) {
      BOOST_THROW_EXCEPTION(
          boost::enable_error_info(std::runtime_error("owner is required.")));
    }
    if (!buckets) {
      BOOST_THROW_EXCEPTION(
          boost::enable_error_info(std::runtime_error("buckets is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (prefix) {
      res["Prefix"] = boost::any(*prefix);
    }
    if (marker) {
      res["Marker"] = boost::any(*marker);
    }
    if (maxKeys) {
      res["MaxKeys"] = boost::any(*maxKeys);
    }
    if (isTruncated) {
      res["IsTruncated"] = boost::any(*isTruncated);
    }
    if (nextMarker) {
      res["NextMarker"] = boost::any(*nextMarker);
    }
    if (owner) {
      res["Owner"] = owner ? boost::any(owner->toMap())
                           : boost::any(map<string, boost::any>({}));
    }
    if (buckets) {
      res["Buckets"] = buckets ? boost::any(buckets->toMap())
                               : boost::any(map<string, boost::any>({}));
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("Prefix") != m.end()) {
      prefix = make_shared<string>(boost::any_cast<string>(m["Prefix"]));
    }
    if (m.find("Marker") != m.end()) {
      marker = make_shared<string>(boost::any_cast<string>(m["Marker"]));
    }
    if (m.find("MaxKeys") != m.end()) {
      maxKeys = make_shared<string>(boost::any_cast<string>(m["MaxKeys"]));
    }
    if (m.find("IsTruncated") != m.end()) {
      isTruncated =
          make_shared<string>(boost::any_cast<string>(m["IsTruncated"]));
    }
    if (m.find("NextMarker") != m.end()) {
      nextMarker =
          make_shared<string>(boost::any_cast<string>(m["NextMarker"]));
    }
    if (m.find("Owner") != m.end()) {
      if (typeid(map<string, boost::any>).name() == m["Owner"].type().name()) {
        GetServiceResponseListAllMyBucketsResultOwner model1;
        model1.fromMap(boost::any_cast<map<string, boost::any>>(m["Owner"]));
        owner =
            make_shared<GetServiceResponseListAllMyBucketsResultOwner>(model1);
      }
    }
    if (m.find("Buckets") != m.end()) {
      if (typeid(map<string, boost::any>).name() ==
          m["Buckets"].type().name()) {
        GetServiceResponseListAllMyBucketsResultBuckets model1;
        model1.fromMap(boost::any_cast<map<string, boost::any>>(m["Buckets"]));
        buckets = make_shared<GetServiceResponseListAllMyBucketsResultBuckets>(
            model1);
      }
    }
  }

  shared_ptr<string> prefix{};
  shared_ptr<string> marker{};
  shared_ptr<string> maxKeys{};
  shared_ptr<string> isTruncated{};
  shared_ptr<string> nextMarker{};
  shared_ptr<GetServiceResponseListAllMyBucketsResultOwner> owner{};
  shared_ptr<GetServiceResponseListAllMyBucketsResultBuckets> buckets{};

  ~GetServiceResponseListAllMyBucketsResult() = default;
};
class GetServiceResponse : public Darabonba::Model {
public:
  GetServiceResponse() {}
  explicit GetServiceResponse(const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!requestId) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("requestId is required.")));
    }
    if (!listAllMyBucketsResult) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("listAllMyBucketsResult is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (requestId) {
      res["x-oss-request-id"] = boost::any(*requestId);
    }
    if (listAllMyBucketsResult) {
      res["ListAllMyBucketsResult"] =
          listAllMyBucketsResult ? boost::any(listAllMyBucketsResult->toMap())
                                 : boost::any(map<string, boost::any>({}));
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("x-oss-request-id") != m.end()) {
      requestId =
          make_shared<string>(boost::any_cast<string>(m["x-oss-request-id"]));
    }
    if (m.find("ListAllMyBucketsResult") != m.end()) {
      if (typeid(map<string, boost::any>).name() ==
          m["ListAllMyBucketsResult"].type().name()) {
        GetServiceResponseListAllMyBucketsResult model1;
        model1.fromMap(boost::any_cast<map<string, boost::any>>(
            m["ListAllMyBucketsResult"]));
        listAllMyBucketsResult =
            make_shared<GetServiceResponseListAllMyBucketsResult>(model1);
      }
    }
  }

  shared_ptr<string> requestId{};
  shared_ptr<GetServiceResponseListAllMyBucketsResult> listAllMyBucketsResult{};

  ~GetServiceResponse() = default;
};
class DeleteBucketEncryptionRequest : public Darabonba::Model {
public:
  DeleteBucketEncryptionRequest() {}
  explicit DeleteBucketEncryptionRequest(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!bucketName) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("bucketName is required.")));
    }
    Darabonba::Model::validatePattern("bucketName", bucketName,
                                      "[a-zA-Z0-9\\\\-\\\\_]+");
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (bucketName) {
      res["BucketName"] = boost::any(*bucketName);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("BucketName") != m.end()) {
      bucketName =
          make_shared<string>(boost::any_cast<string>(m["BucketName"]));
    }
  }

  shared_ptr<string> bucketName{};

  ~DeleteBucketEncryptionRequest() = default;
};
class DeleteBucketEncryptionResponse : public Darabonba::Model {
public:
  DeleteBucketEncryptionResponse() {}
  explicit DeleteBucketEncryptionResponse(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!requestId) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("requestId is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (requestId) {
      res["x-oss-request-id"] = boost::any(*requestId);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("x-oss-request-id") != m.end()) {
      requestId =
          make_shared<string>(boost::any_cast<string>(m["x-oss-request-id"]));
    }
  }

  shared_ptr<string> requestId{};

  ~DeleteBucketEncryptionResponse() = default;
};
class DeleteBucketTagsRequestFilter : public Darabonba::Model {
public:
  DeleteBucketTagsRequestFilter() {}
  explicit DeleteBucketTagsRequestFilter(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!tagging) {
      BOOST_THROW_EXCEPTION(
          boost::enable_error_info(std::runtime_error("tagging is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (tagging) {
      res["tagging"] = boost::any(*tagging);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("tagging") != m.end()) {
      tagging = make_shared<string>(boost::any_cast<string>(m["tagging"]));
    }
  }

  shared_ptr<string> tagging{};

  ~DeleteBucketTagsRequestFilter() = default;
};
class DeleteBucketTagsRequest : public Darabonba::Model {
public:
  DeleteBucketTagsRequest() {}
  explicit DeleteBucketTagsRequest(const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!bucketName) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("bucketName is required.")));
    }
    Darabonba::Model::validatePattern("bucketName", bucketName,
                                      "[a-zA-Z0-9\\\\-\\\\_]+");
    if (!filter) {
      BOOST_THROW_EXCEPTION(
          boost::enable_error_info(std::runtime_error("filter is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (bucketName) {
      res["BucketName"] = boost::any(*bucketName);
    }
    if (filter) {
      res["Filter"] = filter ? boost::any(filter->toMap())
                             : boost::any(map<string, boost::any>({}));
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("BucketName") != m.end()) {
      bucketName =
          make_shared<string>(boost::any_cast<string>(m["BucketName"]));
    }
    if (m.find("Filter") != m.end()) {
      if (typeid(map<string, boost::any>).name() == m["Filter"].type().name()) {
        DeleteBucketTagsRequestFilter model1;
        model1.fromMap(boost::any_cast<map<string, boost::any>>(m["Filter"]));
        filter = make_shared<DeleteBucketTagsRequestFilter>(model1);
      }
    }
  }

  shared_ptr<string> bucketName{};
  shared_ptr<DeleteBucketTagsRequestFilter> filter{};

  ~DeleteBucketTagsRequest() = default;
};
class DeleteBucketTagsResponse : public Darabonba::Model {
public:
  DeleteBucketTagsResponse() {}
  explicit DeleteBucketTagsResponse(const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!requestId) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("requestId is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (requestId) {
      res["x-oss-request-id"] = boost::any(*requestId);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("x-oss-request-id") != m.end()) {
      requestId =
          make_shared<string>(boost::any_cast<string>(m["x-oss-request-id"]));
    }
  }

  shared_ptr<string> requestId{};

  ~DeleteBucketTagsResponse() = default;
};
class GetBucketWebsiteRequest : public Darabonba::Model {
public:
  GetBucketWebsiteRequest() {}
  explicit GetBucketWebsiteRequest(const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!bucketName) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("bucketName is required.")));
    }
    Darabonba::Model::validatePattern("bucketName", bucketName,
                                      "[a-zA-Z0-9\\\\-\\\\_]+");
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (bucketName) {
      res["BucketName"] = boost::any(*bucketName);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("BucketName") != m.end()) {
      bucketName =
          make_shared<string>(boost::any_cast<string>(m["BucketName"]));
    }
  }

  shared_ptr<string> bucketName{};

  ~GetBucketWebsiteRequest() = default;
};
class GetBucketWebsiteResponseWebsiteConfigurationIndexDocument
    : public Darabonba::Model {
public:
  GetBucketWebsiteResponseWebsiteConfigurationIndexDocument() {}
  explicit GetBucketWebsiteResponseWebsiteConfigurationIndexDocument(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {}

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (suffix) {
      res["Suffix"] = boost::any(*suffix);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("Suffix") != m.end()) {
      suffix = make_shared<string>(boost::any_cast<string>(m["Suffix"]));
    }
  }

  shared_ptr<string> suffix{};

  ~GetBucketWebsiteResponseWebsiteConfigurationIndexDocument() = default;
};
class GetBucketWebsiteResponseWebsiteConfigurationErrorDocument
    : public Darabonba::Model {
public:
  GetBucketWebsiteResponseWebsiteConfigurationErrorDocument() {}
  explicit GetBucketWebsiteResponseWebsiteConfigurationErrorDocument(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {}

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (key) {
      res["Key"] = boost::any(*key);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("Key") != m.end()) {
      key = make_shared<string>(boost::any_cast<string>(m["Key"]));
    }
  }

  shared_ptr<string> key{};

  ~GetBucketWebsiteResponseWebsiteConfigurationErrorDocument() = default;
};
class
    GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleConditionIncludeHeader
    : public Darabonba::Model {
public:
  GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleConditionIncludeHeader() {
  }
  explicit GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleConditionIncludeHeader(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {}

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (key) {
      res["Key"] = boost::any(*key);
    }
    if (equals) {
      res["Equals"] = boost::any(*equals);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("Key") != m.end()) {
      key = make_shared<string>(boost::any_cast<string>(m["Key"]));
    }
    if (m.find("Equals") != m.end()) {
      equals = make_shared<string>(boost::any_cast<string>(m["Equals"]));
    }
  }

  shared_ptr<string> key{};
  shared_ptr<string> equals{};

  ~GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleConditionIncludeHeader() =
      default;
};
class
    GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleCondition
    : public Darabonba::Model {
public:
  GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleCondition() {
  }
  explicit GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleCondition(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!includeHeader) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("includeHeader is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (keyPrefixEquals) {
      res["KeyPrefixEquals"] = boost::any(*keyPrefixEquals);
    }
    if (httpErrorCodeReturnedEquals) {
      res["HttpErrorCodeReturnedEquals"] =
          boost::any(*httpErrorCodeReturnedEquals);
    }
    if (includeHeader) {
      res["IncludeHeader"] = includeHeader
                                 ? boost::any(includeHeader->toMap())
                                 : boost::any(map<string, boost::any>({}));
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("KeyPrefixEquals") != m.end()) {
      keyPrefixEquals =
          make_shared<string>(boost::any_cast<string>(m["KeyPrefixEquals"]));
    }
    if (m.find("HttpErrorCodeReturnedEquals") != m.end()) {
      httpErrorCodeReturnedEquals = make_shared<string>(
          boost::any_cast<string>(m["HttpErrorCodeReturnedEquals"]));
    }
    if (m.find("IncludeHeader") != m.end()) {
      if (typeid(map<string, boost::any>).name() ==
          m["IncludeHeader"].type().name()) {
        GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleConditionIncludeHeader
            model1;
        model1.fromMap(
            boost::any_cast<map<string, boost::any>>(m["IncludeHeader"]));
        includeHeader = make_shared<
            GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleConditionIncludeHeader>(
            model1);
      }
    }
  }

  shared_ptr<string> keyPrefixEquals{};
  shared_ptr<string> httpErrorCodeReturnedEquals{};
  shared_ptr<
      GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleConditionIncludeHeader>
      includeHeader{};

  ~GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleCondition() =
      default;
};
class
    GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeadersSet
    : public Darabonba::Model {
public:
  GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeadersSet() {
  }
  explicit GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeadersSet(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {}

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (key) {
      res["Key"] = boost::any(*key);
    }
    if (value) {
      res["Value"] = boost::any(*value);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("Key") != m.end()) {
      key = make_shared<string>(boost::any_cast<string>(m["Key"]));
    }
    if (m.find("Value") != m.end()) {
      value = make_shared<string>(boost::any_cast<string>(m["Value"]));
    }
  }

  shared_ptr<string> key{};
  shared_ptr<string> value{};

  ~GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeadersSet() =
      default;
};
class
    GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeaders
    : public Darabonba::Model {
public:
  GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeaders() {
  }
  explicit GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeaders(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!set) {
      BOOST_THROW_EXCEPTION(
          boost::enable_error_info(std::runtime_error("set is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (passAll) {
      res["PassAll"] = boost::any(*passAll);
    }
    if (pass) {
      res["Pass"] = boost::any(*pass);
    }
    if (remove) {
      res["Remove"] = boost::any(*remove);
    }
    if (set) {
      res["Set"] = set ? boost::any(set->toMap())
                       : boost::any(map<string, boost::any>({}));
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("PassAll") != m.end()) {
      passAll = make_shared<bool>(boost::any_cast<bool>(m["PassAll"]));
    }
    if (m.find("Pass") != m.end()) {
      pass = make_shared<string>(boost::any_cast<string>(m["Pass"]));
    }
    if (m.find("Remove") != m.end()) {
      remove = make_shared<string>(boost::any_cast<string>(m["Remove"]));
    }
    if (m.find("Set") != m.end()) {
      if (typeid(map<string, boost::any>).name() == m["Set"].type().name()) {
        GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeadersSet
            model1;
        model1.fromMap(boost::any_cast<map<string, boost::any>>(m["Set"]));
        set = make_shared<
            GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeadersSet>(
            model1);
      }
    }
  }

  shared_ptr<bool> passAll{};
  shared_ptr<string> pass{};
  shared_ptr<string> remove{};
  shared_ptr<
      GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeadersSet>
      set{};

  ~GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeaders() =
      default;
};
class
    GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirect
    : public Darabonba::Model {
public:
  GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirect() {
  }
  explicit GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirect(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!mirrorHeaders) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("mirrorHeaders is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (redirectType) {
      res["RedirectType"] = boost::any(*redirectType);
    }
    if (passQueryString) {
      res["PassQueryString"] = boost::any(*passQueryString);
    }
    if (mirrorURL) {
      res["MirrorURL"] = boost::any(*mirrorURL);
    }
    if (mirrorPassQueryString) {
      res["MirrorPassQueryString"] = boost::any(*mirrorPassQueryString);
    }
    if (mirrorFollowRedirect) {
      res["MirrorFollowRedirect"] = boost::any(*mirrorFollowRedirect);
    }
    if (mirrorCheckMd5) {
      res["MirrorCheckMd5"] = boost::any(*mirrorCheckMd5);
    }
    if (protocol) {
      res["Protocol"] = boost::any(*protocol);
    }
    if (hostName) {
      res["HostName"] = boost::any(*hostName);
    }
    if (httpRedirectCode) {
      res["HttpRedirectCode"] = boost::any(*httpRedirectCode);
    }
    if (replaceKeyPrefixWith) {
      res["ReplaceKeyPrefixWith"] = boost::any(*replaceKeyPrefixWith);
    }
    if (replaceKeyWith) {
      res["ReplaceKeyWith"] = boost::any(*replaceKeyWith);
    }
    if (mirrorHeaders) {
      res["MirrorHeaders"] = mirrorHeaders
                                 ? boost::any(mirrorHeaders->toMap())
                                 : boost::any(map<string, boost::any>({}));
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("RedirectType") != m.end()) {
      redirectType =
          make_shared<string>(boost::any_cast<string>(m["RedirectType"]));
    }
    if (m.find("PassQueryString") != m.end()) {
      passQueryString =
          make_shared<bool>(boost::any_cast<bool>(m["PassQueryString"]));
    }
    if (m.find("MirrorURL") != m.end()) {
      mirrorURL = make_shared<string>(boost::any_cast<string>(m["MirrorURL"]));
    }
    if (m.find("MirrorPassQueryString") != m.end()) {
      mirrorPassQueryString =
          make_shared<bool>(boost::any_cast<bool>(m["MirrorPassQueryString"]));
    }
    if (m.find("MirrorFollowRedirect") != m.end()) {
      mirrorFollowRedirect =
          make_shared<bool>(boost::any_cast<bool>(m["MirrorFollowRedirect"]));
    }
    if (m.find("MirrorCheckMd5") != m.end()) {
      mirrorCheckMd5 =
          make_shared<bool>(boost::any_cast<bool>(m["MirrorCheckMd5"]));
    }
    if (m.find("Protocol") != m.end()) {
      protocol = make_shared<string>(boost::any_cast<string>(m["Protocol"]));
    }
    if (m.find("HostName") != m.end()) {
      hostName = make_shared<string>(boost::any_cast<string>(m["HostName"]));
    }
    if (m.find("HttpRedirectCode") != m.end()) {
      httpRedirectCode =
          make_shared<string>(boost::any_cast<string>(m["HttpRedirectCode"]));
    }
    if (m.find("ReplaceKeyPrefixWith") != m.end()) {
      replaceKeyPrefixWith = make_shared<string>(
          boost::any_cast<string>(m["ReplaceKeyPrefixWith"]));
    }
    if (m.find("ReplaceKeyWith") != m.end()) {
      replaceKeyWith =
          make_shared<string>(boost::any_cast<string>(m["ReplaceKeyWith"]));
    }
    if (m.find("MirrorHeaders") != m.end()) {
      if (typeid(map<string, boost::any>).name() ==
          m["MirrorHeaders"].type().name()) {
        GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeaders
            model1;
        model1.fromMap(
            boost::any_cast<map<string, boost::any>>(m["MirrorHeaders"]));
        mirrorHeaders = make_shared<
            GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeaders>(
            model1);
      }
    }
  }

  shared_ptr<string> redirectType{};
  shared_ptr<bool> passQueryString{};
  shared_ptr<string> mirrorURL{};
  shared_ptr<bool> mirrorPassQueryString{};
  shared_ptr<bool> mirrorFollowRedirect{};
  shared_ptr<bool> mirrorCheckMd5{};
  shared_ptr<string> protocol{};
  shared_ptr<string> hostName{};
  shared_ptr<string> httpRedirectCode{};
  shared_ptr<string> replaceKeyPrefixWith{};
  shared_ptr<string> replaceKeyWith{};
  shared_ptr<
      GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeaders>
      mirrorHeaders{};

  ~GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirect() =
      default;
};
class GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRule
    : public Darabonba::Model {
public:
  GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRule() {}
  explicit GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRule(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!condition) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("condition is required.")));
    }
    if (!redirect) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("redirect is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (ruleNumber) {
      res["RuleNumber"] = boost::any(*ruleNumber);
    }
    if (condition) {
      res["Condition"] = condition ? boost::any(condition->toMap())
                                   : boost::any(map<string, boost::any>({}));
    }
    if (redirect) {
      res["Redirect"] = redirect ? boost::any(redirect->toMap())
                                 : boost::any(map<string, boost::any>({}));
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("RuleNumber") != m.end()) {
      ruleNumber = make_shared<int>(boost::any_cast<int>(m["RuleNumber"]));
    }
    if (m.find("Condition") != m.end()) {
      if (typeid(map<string, boost::any>).name() ==
          m["Condition"].type().name()) {
        GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleCondition
            model1;
        model1.fromMap(
            boost::any_cast<map<string, boost::any>>(m["Condition"]));
        condition = make_shared<
            GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleCondition>(
            model1);
      }
    }
    if (m.find("Redirect") != m.end()) {
      if (typeid(map<string, boost::any>).name() ==
          m["Redirect"].type().name()) {
        GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirect
            model1;
        model1.fromMap(boost::any_cast<map<string, boost::any>>(m["Redirect"]));
        redirect = make_shared<
            GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirect>(
            model1);
      }
    }
  }

  shared_ptr<int> ruleNumber{};
  shared_ptr<
      GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleCondition>
      condition{};
  shared_ptr<
      GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirect>
      redirect{};

  ~GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRule() =
      default;
};
class GetBucketWebsiteResponseWebsiteConfigurationRoutingRules
    : public Darabonba::Model {
public:
  GetBucketWebsiteResponseWebsiteConfigurationRoutingRules() {}
  explicit GetBucketWebsiteResponseWebsiteConfigurationRoutingRules(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {}

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (routingRule) {
      vector<boost::any> temp1;
      for (auto item1 : *routingRule) {
        temp1.push_back(boost::any(item1.toMap()));
      }
      res["RoutingRule"] = boost::any(temp1);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("RoutingRule") != m.end()) {
      if (typeid(vector<boost::any>).name() == m["RoutingRule"].type().name()) {
        vector<
            GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRule>
            expect1;
        for (auto item1 :
             boost::any_cast<vector<boost::any>>(m["RoutingRule"])) {
          if (typeid(map<string, boost::any>).name() == item1.type().name()) {
            GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRule
                model2;
            model2.fromMap(boost::any_cast<map<string, boost::any>>(item1));
            expect1.push_back(model2);
          }
        }
        routingRule = make_shared<vector<
            GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRule>>(
            expect1);
      }
    }
  }

  shared_ptr<vector<
      GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRule>>
      routingRule{};

  ~GetBucketWebsiteResponseWebsiteConfigurationRoutingRules() = default;
};
class GetBucketWebsiteResponseWebsiteConfiguration : public Darabonba::Model {
public:
  GetBucketWebsiteResponseWebsiteConfiguration() {}
  explicit GetBucketWebsiteResponseWebsiteConfiguration(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!indexDocument) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("indexDocument is required.")));
    }
    if (!errorDocument) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("errorDocument is required.")));
    }
    if (!routingRules) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("routingRules is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (indexDocument) {
      res["IndexDocument"] = indexDocument
                                 ? boost::any(indexDocument->toMap())
                                 : boost::any(map<string, boost::any>({}));
    }
    if (errorDocument) {
      res["ErrorDocument"] = errorDocument
                                 ? boost::any(errorDocument->toMap())
                                 : boost::any(map<string, boost::any>({}));
    }
    if (routingRules) {
      res["RoutingRules"] = routingRules
                                ? boost::any(routingRules->toMap())
                                : boost::any(map<string, boost::any>({}));
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("IndexDocument") != m.end()) {
      if (typeid(map<string, boost::any>).name() ==
          m["IndexDocument"].type().name()) {
        GetBucketWebsiteResponseWebsiteConfigurationIndexDocument model1;
        model1.fromMap(
            boost::any_cast<map<string, boost::any>>(m["IndexDocument"]));
        indexDocument = make_shared<
            GetBucketWebsiteResponseWebsiteConfigurationIndexDocument>(model1);
      }
    }
    if (m.find("ErrorDocument") != m.end()) {
      if (typeid(map<string, boost::any>).name() ==
          m["ErrorDocument"].type().name()) {
        GetBucketWebsiteResponseWebsiteConfigurationErrorDocument model1;
        model1.fromMap(
            boost::any_cast<map<string, boost::any>>(m["ErrorDocument"]));
        errorDocument = make_shared<
            GetBucketWebsiteResponseWebsiteConfigurationErrorDocument>(model1);
      }
    }
    if (m.find("RoutingRules") != m.end()) {
      if (typeid(map<string, boost::any>).name() ==
          m["RoutingRules"].type().name()) {
        GetBucketWebsiteResponseWebsiteConfigurationRoutingRules model1;
        model1.fromMap(
            boost::any_cast<map<string, boost::any>>(m["RoutingRules"]));
        routingRules = make_shared<
            GetBucketWebsiteResponseWebsiteConfigurationRoutingRules>(model1);
      }
    }
  }

  shared_ptr<GetBucketWebsiteResponseWebsiteConfigurationIndexDocument>
      indexDocument{};
  shared_ptr<GetBucketWebsiteResponseWebsiteConfigurationErrorDocument>
      errorDocument{};
  shared_ptr<GetBucketWebsiteResponseWebsiteConfigurationRoutingRules>
      routingRules{};

  ~GetBucketWebsiteResponseWebsiteConfiguration() = default;
};
class GetBucketWebsiteResponse : public Darabonba::Model {
public:
  GetBucketWebsiteResponse() {}
  explicit GetBucketWebsiteResponse(const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!requestId) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("requestId is required.")));
    }
    if (!websiteConfiguration) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("websiteConfiguration is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (requestId) {
      res["x-oss-request-id"] = boost::any(*requestId);
    }
    if (websiteConfiguration) {
      res["WebsiteConfiguration"] =
          websiteConfiguration ? boost::any(websiteConfiguration->toMap())
                               : boost::any(map<string, boost::any>({}));
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("x-oss-request-id") != m.end()) {
      requestId =
          make_shared<string>(boost::any_cast<string>(m["x-oss-request-id"]));
    }
    if (m.find("WebsiteConfiguration") != m.end()) {
      if (typeid(map<string, boost::any>).name() ==
          m["WebsiteConfiguration"].type().name()) {
        GetBucketWebsiteResponseWebsiteConfiguration model1;
        model1.fromMap(boost::any_cast<map<string, boost::any>>(
            m["WebsiteConfiguration"]));
        websiteConfiguration =
            make_shared<GetBucketWebsiteResponseWebsiteConfiguration>(model1);
      }
    }
  }

  shared_ptr<string> requestId{};
  shared_ptr<GetBucketWebsiteResponseWebsiteConfiguration>
      websiteConfiguration{};

  ~GetBucketWebsiteResponse() = default;
};
class DeleteLiveChannelRequest : public Darabonba::Model {
public:
  DeleteLiveChannelRequest() {}
  explicit DeleteLiveChannelRequest(const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!bucketName) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("bucketName is required.")));
    }
    Darabonba::Model::validatePattern("bucketName", bucketName,
                                      "[a-zA-Z0-9\\\\-\\\\_]+");
    if (!channelName) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("channelName is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (bucketName) {
      res["BucketName"] = boost::any(*bucketName);
    }
    if (channelName) {
      res["ChannelName"] = boost::any(*channelName);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("BucketName") != m.end()) {
      bucketName =
          make_shared<string>(boost::any_cast<string>(m["BucketName"]));
    }
    if (m.find("ChannelName") != m.end()) {
      channelName =
          make_shared<string>(boost::any_cast<string>(m["ChannelName"]));
    }
  }

  shared_ptr<string> bucketName{};
  shared_ptr<string> channelName{};

  ~DeleteLiveChannelRequest() = default;
};
class DeleteLiveChannelResponse : public Darabonba::Model {
public:
  DeleteLiveChannelResponse() {}
  explicit DeleteLiveChannelResponse(const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!requestId) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("requestId is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (requestId) {
      res["x-oss-request-id"] = boost::any(*requestId);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("x-oss-request-id") != m.end()) {
      requestId =
          make_shared<string>(boost::any_cast<string>(m["x-oss-request-id"]));
    }
  }

  shared_ptr<string> requestId{};

  ~DeleteLiveChannelResponse() = default;
};
class GetBucketLocationRequest : public Darabonba::Model {
public:
  GetBucketLocationRequest() {}
  explicit GetBucketLocationRequest(const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!bucketName) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("bucketName is required.")));
    }
    Darabonba::Model::validatePattern("bucketName", bucketName,
                                      "[a-zA-Z0-9\\\\-\\\\_]+");
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (bucketName) {
      res["BucketName"] = boost::any(*bucketName);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("BucketName") != m.end()) {
      bucketName =
          make_shared<string>(boost::any_cast<string>(m["BucketName"]));
    }
  }

  shared_ptr<string> bucketName{};

  ~GetBucketLocationRequest() = default;
};
class GetBucketLocationResponse : public Darabonba::Model {
public:
  GetBucketLocationResponse() {}
  explicit GetBucketLocationResponse(const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!requestId) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("requestId is required.")));
    }
    if (!locationConstraint) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("locationConstraint is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (requestId) {
      res["x-oss-request-id"] = boost::any(*requestId);
    }
    if (locationConstraint) {
      res["LocationConstraint"] = boost::any(*locationConstraint);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("x-oss-request-id") != m.end()) {
      requestId =
          make_shared<string>(boost::any_cast<string>(m["x-oss-request-id"]));
    }
    if (m.find("LocationConstraint") != m.end()) {
      locationConstraint =
          make_shared<string>(boost::any_cast<string>(m["LocationConstraint"]));
    }
  }

  shared_ptr<string> requestId{};
  shared_ptr<string> locationConstraint{};

  ~GetBucketLocationResponse() = default;
};
class ListLiveChannelRequestFilter : public Darabonba::Model {
public:
  ListLiveChannelRequestFilter() {}
  explicit ListLiveChannelRequestFilter(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {}

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (marker) {
      res["marker"] = boost::any(*marker);
    }
    if (maxKeys) {
      res["max-keys"] = boost::any(*maxKeys);
    }
    if (prefix) {
      res["prefix"] = boost::any(*prefix);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("marker") != m.end()) {
      marker = make_shared<string>(boost::any_cast<string>(m["marker"]));
    }
    if (m.find("max-keys") != m.end()) {
      maxKeys = make_shared<string>(boost::any_cast<string>(m["max-keys"]));
    }
    if (m.find("prefix") != m.end()) {
      prefix = make_shared<string>(boost::any_cast<string>(m["prefix"]));
    }
  }

  shared_ptr<string> marker{};
  shared_ptr<string> maxKeys{};
  shared_ptr<string> prefix{};

  ~ListLiveChannelRequestFilter() = default;
};
class ListLiveChannelRequest : public Darabonba::Model {
public:
  ListLiveChannelRequest() {}
  explicit ListLiveChannelRequest(const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!bucketName) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("bucketName is required.")));
    }
    Darabonba::Model::validatePattern("bucketName", bucketName,
                                      "[a-zA-Z0-9\\\\-\\\\_]+");
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (bucketName) {
      res["BucketName"] = boost::any(*bucketName);
    }
    if (filter) {
      res["Filter"] = filter ? boost::any(filter->toMap())
                             : boost::any(map<string, boost::any>({}));
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("BucketName") != m.end()) {
      bucketName =
          make_shared<string>(boost::any_cast<string>(m["BucketName"]));
    }
    if (m.find("Filter") != m.end()) {
      if (typeid(map<string, boost::any>).name() == m["Filter"].type().name()) {
        ListLiveChannelRequestFilter model1;
        model1.fromMap(boost::any_cast<map<string, boost::any>>(m["Filter"]));
        filter = make_shared<ListLiveChannelRequestFilter>(model1);
      }
    }
  }

  shared_ptr<string> bucketName{};
  shared_ptr<ListLiveChannelRequestFilter> filter{};

  ~ListLiveChannelRequest() = default;
};
class ListLiveChannelResponseListLiveChannelResultLiveChannelPublishUrls
    : public Darabonba::Model {
public:
  ListLiveChannelResponseListLiveChannelResultLiveChannelPublishUrls() {}
  explicit ListLiveChannelResponseListLiveChannelResultLiveChannelPublishUrls(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {}

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (url) {
      res["Url"] = boost::any(*url);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("Url") != m.end()) {
      url = make_shared<string>(boost::any_cast<string>(m["Url"]));
    }
  }

  shared_ptr<string> url{};

  ~ListLiveChannelResponseListLiveChannelResultLiveChannelPublishUrls() =
      default;
};
class ListLiveChannelResponseListLiveChannelResultLiveChannelPlayUrls
    : public Darabonba::Model {
public:
  ListLiveChannelResponseListLiveChannelResultLiveChannelPlayUrls() {}
  explicit ListLiveChannelResponseListLiveChannelResultLiveChannelPlayUrls(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {}

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (url) {
      res["Url"] = boost::any(*url);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("Url") != m.end()) {
      url = make_shared<string>(boost::any_cast<string>(m["Url"]));
    }
  }

  shared_ptr<string> url{};

  ~ListLiveChannelResponseListLiveChannelResultLiveChannelPlayUrls() = default;
};
class ListLiveChannelResponseListLiveChannelResultLiveChannel
    : public Darabonba::Model {
public:
  ListLiveChannelResponseListLiveChannelResultLiveChannel() {}
  explicit ListLiveChannelResponseListLiveChannelResultLiveChannel(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!publishUrls) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("publishUrls is required.")));
    }
    if (!playUrls) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("playUrls is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (name) {
      res["Name"] = boost::any(*name);
    }
    if (description) {
      res["Description"] = boost::any(*description);
    }
    if (status) {
      res["Status"] = boost::any(*status);
    }
    if (lastModified) {
      res["LastModified"] = boost::any(*lastModified);
    }
    if (publishUrls) {
      res["PublishUrls"] = publishUrls
                               ? boost::any(publishUrls->toMap())
                               : boost::any(map<string, boost::any>({}));
    }
    if (playUrls) {
      res["PlayUrls"] = playUrls ? boost::any(playUrls->toMap())
                                 : boost::any(map<string, boost::any>({}));
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("Name") != m.end()) {
      name = make_shared<string>(boost::any_cast<string>(m["Name"]));
    }
    if (m.find("Description") != m.end()) {
      description =
          make_shared<string>(boost::any_cast<string>(m["Description"]));
    }
    if (m.find("Status") != m.end()) {
      status = make_shared<string>(boost::any_cast<string>(m["Status"]));
    }
    if (m.find("LastModified") != m.end()) {
      lastModified =
          make_shared<string>(boost::any_cast<string>(m["LastModified"]));
    }
    if (m.find("PublishUrls") != m.end()) {
      if (typeid(map<string, boost::any>).name() ==
          m["PublishUrls"].type().name()) {
        ListLiveChannelResponseListLiveChannelResultLiveChannelPublishUrls
            model1;
        model1.fromMap(
            boost::any_cast<map<string, boost::any>>(m["PublishUrls"]));
        publishUrls = make_shared<
            ListLiveChannelResponseListLiveChannelResultLiveChannelPublishUrls>(
            model1);
      }
    }
    if (m.find("PlayUrls") != m.end()) {
      if (typeid(map<string, boost::any>).name() ==
          m["PlayUrls"].type().name()) {
        ListLiveChannelResponseListLiveChannelResultLiveChannelPlayUrls model1;
        model1.fromMap(boost::any_cast<map<string, boost::any>>(m["PlayUrls"]));
        playUrls = make_shared<
            ListLiveChannelResponseListLiveChannelResultLiveChannelPlayUrls>(
            model1);
      }
    }
  }

  shared_ptr<string> name{};
  shared_ptr<string> description{};
  shared_ptr<string> status{};
  shared_ptr<string> lastModified{};
  shared_ptr<ListLiveChannelResponseListLiveChannelResultLiveChannelPublishUrls>
      publishUrls{};
  shared_ptr<ListLiveChannelResponseListLiveChannelResultLiveChannelPlayUrls>
      playUrls{};

  ~ListLiveChannelResponseListLiveChannelResultLiveChannel() = default;
};
class ListLiveChannelResponseListLiveChannelResult : public Darabonba::Model {
public:
  ListLiveChannelResponseListLiveChannelResult() {}
  explicit ListLiveChannelResponseListLiveChannelResult(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!liveChannel) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("liveChannel is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (prefix) {
      res["Prefix"] = boost::any(*prefix);
    }
    if (marker) {
      res["Marker"] = boost::any(*marker);
    }
    if (maxKeys) {
      res["MaxKeys"] = boost::any(*maxKeys);
    }
    if (isTruncated) {
      res["IsTruncated"] = boost::any(*isTruncated);
    }
    if (nextMarker) {
      res["NextMarker"] = boost::any(*nextMarker);
    }
    if (liveChannel) {
      res["LiveChannel"] = liveChannel
                               ? boost::any(liveChannel->toMap())
                               : boost::any(map<string, boost::any>({}));
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("Prefix") != m.end()) {
      prefix = make_shared<string>(boost::any_cast<string>(m["Prefix"]));
    }
    if (m.find("Marker") != m.end()) {
      marker = make_shared<string>(boost::any_cast<string>(m["Marker"]));
    }
    if (m.find("MaxKeys") != m.end()) {
      maxKeys = make_shared<string>(boost::any_cast<string>(m["MaxKeys"]));
    }
    if (m.find("IsTruncated") != m.end()) {
      isTruncated =
          make_shared<string>(boost::any_cast<string>(m["IsTruncated"]));
    }
    if (m.find("NextMarker") != m.end()) {
      nextMarker =
          make_shared<string>(boost::any_cast<string>(m["NextMarker"]));
    }
    if (m.find("LiveChannel") != m.end()) {
      if (typeid(map<string, boost::any>).name() ==
          m["LiveChannel"].type().name()) {
        ListLiveChannelResponseListLiveChannelResultLiveChannel model1;
        model1.fromMap(
            boost::any_cast<map<string, boost::any>>(m["LiveChannel"]));
        liveChannel = make_shared<
            ListLiveChannelResponseListLiveChannelResultLiveChannel>(model1);
      }
    }
  }

  shared_ptr<string> prefix{};
  shared_ptr<string> marker{};
  shared_ptr<string> maxKeys{};
  shared_ptr<string> isTruncated{};
  shared_ptr<string> nextMarker{};
  shared_ptr<ListLiveChannelResponseListLiveChannelResultLiveChannel>
      liveChannel{};

  ~ListLiveChannelResponseListLiveChannelResult() = default;
};
class ListLiveChannelResponse : public Darabonba::Model {
public:
  ListLiveChannelResponse() {}
  explicit ListLiveChannelResponse(const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!requestId) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("requestId is required.")));
    }
    if (!listLiveChannelResult) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("listLiveChannelResult is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (requestId) {
      res["x-oss-request-id"] = boost::any(*requestId);
    }
    if (listLiveChannelResult) {
      res["ListLiveChannelResult"] =
          listLiveChannelResult ? boost::any(listLiveChannelResult->toMap())
                                : boost::any(map<string, boost::any>({}));
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("x-oss-request-id") != m.end()) {
      requestId =
          make_shared<string>(boost::any_cast<string>(m["x-oss-request-id"]));
    }
    if (m.find("ListLiveChannelResult") != m.end()) {
      if (typeid(map<string, boost::any>).name() ==
          m["ListLiveChannelResult"].type().name()) {
        ListLiveChannelResponseListLiveChannelResult model1;
        model1.fromMap(boost::any_cast<map<string, boost::any>>(
            m["ListLiveChannelResult"]));
        listLiveChannelResult =
            make_shared<ListLiveChannelResponseListLiveChannelResult>(model1);
      }
    }
  }

  shared_ptr<string> requestId{};
  shared_ptr<ListLiveChannelResponseListLiveChannelResult>
      listLiveChannelResult{};

  ~ListLiveChannelResponse() = default;
};
class GetObjectMetaRequest : public Darabonba::Model {
public:
  GetObjectMetaRequest() {}
  explicit GetObjectMetaRequest(const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!bucketName) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("bucketName is required.")));
    }
    Darabonba::Model::validatePattern("bucketName", bucketName,
                                      "[a-zA-Z0-9\\\\-\\\\_]+");
    if (!objectName) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("objectName is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (bucketName) {
      res["BucketName"] = boost::any(*bucketName);
    }
    if (objectName) {
      res["ObjectName"] = boost::any(*objectName);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("BucketName") != m.end()) {
      bucketName =
          make_shared<string>(boost::any_cast<string>(m["BucketName"]));
    }
    if (m.find("ObjectName") != m.end()) {
      objectName =
          make_shared<string>(boost::any_cast<string>(m["ObjectName"]));
    }
  }

  shared_ptr<string> bucketName{};
  shared_ptr<string> objectName{};

  ~GetObjectMetaRequest() = default;
};
class GetObjectMetaResponse : public Darabonba::Model {
public:
  GetObjectMetaResponse() {}
  explicit GetObjectMetaResponse(const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!requestId) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("requestId is required.")));
    }
    if (!eTag) {
      BOOST_THROW_EXCEPTION(
          boost::enable_error_info(std::runtime_error("eTag is required.")));
    }
    if (!contentLength) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("contentLength is required.")));
    }
    if (!lastModified) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("lastModified is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (requestId) {
      res["x-oss-request-id"] = boost::any(*requestId);
    }
    if (eTag) {
      res["etag"] = boost::any(*eTag);
    }
    if (contentLength) {
      res["content-length"] = boost::any(*contentLength);
    }
    if (lastModified) {
      res["last-modified"] = boost::any(*lastModified);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("x-oss-request-id") != m.end()) {
      requestId =
          make_shared<string>(boost::any_cast<string>(m["x-oss-request-id"]));
    }
    if (m.find("etag") != m.end()) {
      eTag = make_shared<string>(boost::any_cast<string>(m["etag"]));
    }
    if (m.find("content-length") != m.end()) {
      contentLength =
          make_shared<string>(boost::any_cast<string>(m["content-length"]));
    }
    if (m.find("last-modified") != m.end()) {
      lastModified =
          make_shared<string>(boost::any_cast<string>(m["last-modified"]));
    }
  }

  shared_ptr<string> requestId{};
  shared_ptr<string> eTag{};
  shared_ptr<string> contentLength{};
  shared_ptr<string> lastModified{};

  ~GetObjectMetaResponse() = default;
};
class GetBucketAclRequest : public Darabonba::Model {
public:
  GetBucketAclRequest() {}
  explicit GetBucketAclRequest(const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!bucketName) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("bucketName is required.")));
    }
    Darabonba::Model::validatePattern("bucketName", bucketName,
                                      "[a-zA-Z0-9\\\\-\\\\_]+");
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (bucketName) {
      res["BucketName"] = boost::any(*bucketName);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("BucketName") != m.end()) {
      bucketName =
          make_shared<string>(boost::any_cast<string>(m["BucketName"]));
    }
  }

  shared_ptr<string> bucketName{};

  ~GetBucketAclRequest() = default;
};
class GetBucketAclResponseAccessControlPolicyOwner : public Darabonba::Model {
public:
  GetBucketAclResponseAccessControlPolicyOwner() {}
  explicit GetBucketAclResponseAccessControlPolicyOwner(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {}

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (iD) {
      res["ID"] = boost::any(*iD);
    }
    if (displayName) {
      res["DisplayName"] = boost::any(*displayName);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("ID") != m.end()) {
      iD = make_shared<string>(boost::any_cast<string>(m["ID"]));
    }
    if (m.find("DisplayName") != m.end()) {
      displayName =
          make_shared<string>(boost::any_cast<string>(m["DisplayName"]));
    }
  }

  shared_ptr<string> iD{};
  shared_ptr<string> displayName{};

  ~GetBucketAclResponseAccessControlPolicyOwner() = default;
};
class GetBucketAclResponseAccessControlPolicyAccessControlList
    : public Darabonba::Model {
public:
  GetBucketAclResponseAccessControlPolicyAccessControlList() {}
  explicit GetBucketAclResponseAccessControlPolicyAccessControlList(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {}

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (grant) {
      res["Grant"] = boost::any(*grant);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("Grant") != m.end()) {
      grant = make_shared<string>(boost::any_cast<string>(m["Grant"]));
    }
  }

  shared_ptr<string> grant{};

  ~GetBucketAclResponseAccessControlPolicyAccessControlList() = default;
};
class GetBucketAclResponseAccessControlPolicy : public Darabonba::Model {
public:
  GetBucketAclResponseAccessControlPolicy() {}
  explicit GetBucketAclResponseAccessControlPolicy(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!owner) {
      BOOST_THROW_EXCEPTION(
          boost::enable_error_info(std::runtime_error("owner is required.")));
    }
    if (!accessControlList) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("accessControlList is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (owner) {
      res["Owner"] = owner ? boost::any(owner->toMap())
                           : boost::any(map<string, boost::any>({}));
    }
    if (accessControlList) {
      res["AccessControlList"] = accessControlList
                                     ? boost::any(accessControlList->toMap())
                                     : boost::any(map<string, boost::any>({}));
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("Owner") != m.end()) {
      if (typeid(map<string, boost::any>).name() == m["Owner"].type().name()) {
        GetBucketAclResponseAccessControlPolicyOwner model1;
        model1.fromMap(boost::any_cast<map<string, boost::any>>(m["Owner"]));
        owner =
            make_shared<GetBucketAclResponseAccessControlPolicyOwner>(model1);
      }
    }
    if (m.find("AccessControlList") != m.end()) {
      if (typeid(map<string, boost::any>).name() ==
          m["AccessControlList"].type().name()) {
        GetBucketAclResponseAccessControlPolicyAccessControlList model1;
        model1.fromMap(
            boost::any_cast<map<string, boost::any>>(m["AccessControlList"]));
        accessControlList = make_shared<
            GetBucketAclResponseAccessControlPolicyAccessControlList>(model1);
      }
    }
  }

  shared_ptr<GetBucketAclResponseAccessControlPolicyOwner> owner{};
  shared_ptr<GetBucketAclResponseAccessControlPolicyAccessControlList>
      accessControlList{};

  ~GetBucketAclResponseAccessControlPolicy() = default;
};
class GetBucketAclResponse : public Darabonba::Model {
public:
  GetBucketAclResponse() {}
  explicit GetBucketAclResponse(const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!requestId) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("requestId is required.")));
    }
    if (!accessControlPolicy) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("accessControlPolicy is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (requestId) {
      res["x-oss-request-id"] = boost::any(*requestId);
    }
    if (accessControlPolicy) {
      res["AccessControlPolicy"] =
          accessControlPolicy ? boost::any(accessControlPolicy->toMap())
                              : boost::any(map<string, boost::any>({}));
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("x-oss-request-id") != m.end()) {
      requestId =
          make_shared<string>(boost::any_cast<string>(m["x-oss-request-id"]));
    }
    if (m.find("AccessControlPolicy") != m.end()) {
      if (typeid(map<string, boost::any>).name() ==
          m["AccessControlPolicy"].type().name()) {
        GetBucketAclResponseAccessControlPolicy model1;
        model1.fromMap(
            boost::any_cast<map<string, boost::any>>(m["AccessControlPolicy"]));
        accessControlPolicy =
            make_shared<GetBucketAclResponseAccessControlPolicy>(model1);
      }
    }
  }

  shared_ptr<string> requestId{};
  shared_ptr<GetBucketAclResponseAccessControlPolicy> accessControlPolicy{};

  ~GetBucketAclResponse() = default;
};
class ListPartsRequestFilter : public Darabonba::Model {
public:
  ListPartsRequestFilter() {}
  explicit ListPartsRequestFilter(const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!uploadId) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("uploadId is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (uploadId) {
      res["uploadId"] = boost::any(*uploadId);
    }
    if (maxParts) {
      res["max-parts"] = boost::any(*maxParts);
    }
    if (partNumberMarker) {
      res["part-number-marker"] = boost::any(*partNumberMarker);
    }
    if (encodingType) {
      res["Encoding-type"] = boost::any(*encodingType);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("uploadId") != m.end()) {
      uploadId = make_shared<string>(boost::any_cast<string>(m["uploadId"]));
    }
    if (m.find("max-parts") != m.end()) {
      maxParts = make_shared<int>(boost::any_cast<int>(m["max-parts"]));
    }
    if (m.find("part-number-marker") != m.end()) {
      partNumberMarker =
          make_shared<int>(boost::any_cast<int>(m["part-number-marker"]));
    }
    if (m.find("Encoding-type") != m.end()) {
      encodingType =
          make_shared<string>(boost::any_cast<string>(m["Encoding-type"]));
    }
  }

  shared_ptr<string> uploadId{};
  shared_ptr<int> maxParts{};
  shared_ptr<int> partNumberMarker{};
  shared_ptr<string> encodingType{};

  ~ListPartsRequestFilter() = default;
};
class ListPartsRequest : public Darabonba::Model {
public:
  ListPartsRequest() {}
  explicit ListPartsRequest(const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!bucketName) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("bucketName is required.")));
    }
    Darabonba::Model::validatePattern("bucketName", bucketName,
                                      "[a-zA-Z0-9\\\\-\\\\_]+");
    if (!objectName) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("objectName is required.")));
    }
    if (!filter) {
      BOOST_THROW_EXCEPTION(
          boost::enable_error_info(std::runtime_error("filter is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (bucketName) {
      res["BucketName"] = boost::any(*bucketName);
    }
    if (objectName) {
      res["ObjectName"] = boost::any(*objectName);
    }
    if (filter) {
      res["Filter"] = filter ? boost::any(filter->toMap())
                             : boost::any(map<string, boost::any>({}));
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("BucketName") != m.end()) {
      bucketName =
          make_shared<string>(boost::any_cast<string>(m["BucketName"]));
    }
    if (m.find("ObjectName") != m.end()) {
      objectName =
          make_shared<string>(boost::any_cast<string>(m["ObjectName"]));
    }
    if (m.find("Filter") != m.end()) {
      if (typeid(map<string, boost::any>).name() == m["Filter"].type().name()) {
        ListPartsRequestFilter model1;
        model1.fromMap(boost::any_cast<map<string, boost::any>>(m["Filter"]));
        filter = make_shared<ListPartsRequestFilter>(model1);
      }
    }
  }

  shared_ptr<string> bucketName{};
  shared_ptr<string> objectName{};
  shared_ptr<ListPartsRequestFilter> filter{};

  ~ListPartsRequest() = default;
};
class ListPartsResponseListPartsResultPart : public Darabonba::Model {
public:
  ListPartsResponseListPartsResultPart() {}
  explicit ListPartsResponseListPartsResultPart(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {}

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (partNumber) {
      res["PartNumber"] = boost::any(*partNumber);
    }
    if (lastModified) {
      res["LastModified"] = boost::any(*lastModified);
    }
    if (eTag) {
      res["ETag"] = boost::any(*eTag);
    }
    if (size) {
      res["Size"] = boost::any(*size);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("PartNumber") != m.end()) {
      partNumber =
          make_shared<string>(boost::any_cast<string>(m["PartNumber"]));
    }
    if (m.find("LastModified") != m.end()) {
      lastModified =
          make_shared<string>(boost::any_cast<string>(m["LastModified"]));
    }
    if (m.find("ETag") != m.end()) {
      eTag = make_shared<string>(boost::any_cast<string>(m["ETag"]));
    }
    if (m.find("Size") != m.end()) {
      size = make_shared<string>(boost::any_cast<string>(m["Size"]));
    }
  }

  shared_ptr<string> partNumber{};
  shared_ptr<string> lastModified{};
  shared_ptr<string> eTag{};
  shared_ptr<string> size{};

  ~ListPartsResponseListPartsResultPart() = default;
};
class ListPartsResponseListPartsResult : public Darabonba::Model {
public:
  ListPartsResponseListPartsResult() {}
  explicit ListPartsResponseListPartsResult(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {}

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (bucket) {
      res["Bucket"] = boost::any(*bucket);
    }
    if (encodingType) {
      res["EncodingType"] = boost::any(*encodingType);
    }
    if (key) {
      res["Key"] = boost::any(*key);
    }
    if (uploadId) {
      res["UploadId"] = boost::any(*uploadId);
    }
    if (partNumberMarker) {
      res["PartNumberMarker"] = boost::any(*partNumberMarker);
    }
    if (nextPartNumberMarker) {
      res["NextPartNumberMarker"] = boost::any(*nextPartNumberMarker);
    }
    if (maxParts) {
      res["MaxParts"] = boost::any(*maxParts);
    }
    if (isTruncated) {
      res["IsTruncated"] = boost::any(*isTruncated);
    }
    if (part) {
      vector<boost::any> temp1;
      for (auto item1 : *part) {
        temp1.push_back(boost::any(item1.toMap()));
      }
      res["Part"] = boost::any(temp1);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("Bucket") != m.end()) {
      bucket = make_shared<string>(boost::any_cast<string>(m["Bucket"]));
    }
    if (m.find("EncodingType") != m.end()) {
      encodingType =
          make_shared<string>(boost::any_cast<string>(m["EncodingType"]));
    }
    if (m.find("Key") != m.end()) {
      key = make_shared<string>(boost::any_cast<string>(m["Key"]));
    }
    if (m.find("UploadId") != m.end()) {
      uploadId = make_shared<string>(boost::any_cast<string>(m["UploadId"]));
    }
    if (m.find("PartNumberMarker") != m.end()) {
      partNumberMarker =
          make_shared<string>(boost::any_cast<string>(m["PartNumberMarker"]));
    }
    if (m.find("NextPartNumberMarker") != m.end()) {
      nextPartNumberMarker = make_shared<string>(
          boost::any_cast<string>(m["NextPartNumberMarker"]));
    }
    if (m.find("MaxParts") != m.end()) {
      maxParts = make_shared<string>(boost::any_cast<string>(m["MaxParts"]));
    }
    if (m.find("IsTruncated") != m.end()) {
      isTruncated =
          make_shared<string>(boost::any_cast<string>(m["IsTruncated"]));
    }
    if (m.find("Part") != m.end()) {
      if (typeid(vector<boost::any>).name() == m["Part"].type().name()) {
        vector<ListPartsResponseListPartsResultPart> expect1;
        for (auto item1 : boost::any_cast<vector<boost::any>>(m["Part"])) {
          if (typeid(map<string, boost::any>).name() == item1.type().name()) {
            ListPartsResponseListPartsResultPart model2;
            model2.fromMap(boost::any_cast<map<string, boost::any>>(item1));
            expect1.push_back(model2);
          }
        }
        part =
            make_shared<vector<ListPartsResponseListPartsResultPart>>(expect1);
      }
    }
  }

  shared_ptr<string> bucket{};
  shared_ptr<string> encodingType{};
  shared_ptr<string> key{};
  shared_ptr<string> uploadId{};
  shared_ptr<string> partNumberMarker{};
  shared_ptr<string> nextPartNumberMarker{};
  shared_ptr<string> maxParts{};
  shared_ptr<string> isTruncated{};
  shared_ptr<vector<ListPartsResponseListPartsResultPart>> part{};

  ~ListPartsResponseListPartsResult() = default;
};
class ListPartsResponse : public Darabonba::Model {
public:
  ListPartsResponse() {}
  explicit ListPartsResponse(const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!requestId) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("requestId is required.")));
    }
    if (!listPartsResult) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("listPartsResult is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (requestId) {
      res["x-oss-request-id"] = boost::any(*requestId);
    }
    if (listPartsResult) {
      res["ListPartsResult"] = listPartsResult
                                   ? boost::any(listPartsResult->toMap())
                                   : boost::any(map<string, boost::any>({}));
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("x-oss-request-id") != m.end()) {
      requestId =
          make_shared<string>(boost::any_cast<string>(m["x-oss-request-id"]));
    }
    if (m.find("ListPartsResult") != m.end()) {
      if (typeid(map<string, boost::any>).name() ==
          m["ListPartsResult"].type().name()) {
        ListPartsResponseListPartsResult model1;
        model1.fromMap(
            boost::any_cast<map<string, boost::any>>(m["ListPartsResult"]));
        listPartsResult = make_shared<ListPartsResponseListPartsResult>(model1);
      }
    }
  }

  shared_ptr<string> requestId{};
  shared_ptr<ListPartsResponseListPartsResult> listPartsResult{};

  ~ListPartsResponse() = default;
};
class GetLiveChannelHistoryRequestFilter : public Darabonba::Model {
public:
  GetLiveChannelHistoryRequestFilter() {}
  explicit GetLiveChannelHistoryRequestFilter(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {}

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (comp) {
      res["comp"] = boost::any(*comp);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("comp") != m.end()) {
      comp = make_shared<string>(boost::any_cast<string>(m["comp"]));
    }
  }

  shared_ptr<string> comp{};

  ~GetLiveChannelHistoryRequestFilter() = default;
};
class GetLiveChannelHistoryRequest : public Darabonba::Model {
public:
  GetLiveChannelHistoryRequest() {}
  explicit GetLiveChannelHistoryRequest(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!bucketName) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("bucketName is required.")));
    }
    Darabonba::Model::validatePattern("bucketName", bucketName,
                                      "[a-zA-Z0-9\\\\-\\\\_]+");
    if (!channelName) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("channelName is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (bucketName) {
      res["BucketName"] = boost::any(*bucketName);
    }
    if (channelName) {
      res["ChannelName"] = boost::any(*channelName);
    }
    if (filter) {
      res["Filter"] = filter ? boost::any(filter->toMap())
                             : boost::any(map<string, boost::any>({}));
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("BucketName") != m.end()) {
      bucketName =
          make_shared<string>(boost::any_cast<string>(m["BucketName"]));
    }
    if (m.find("ChannelName") != m.end()) {
      channelName =
          make_shared<string>(boost::any_cast<string>(m["ChannelName"]));
    }
    if (m.find("Filter") != m.end()) {
      if (typeid(map<string, boost::any>).name() == m["Filter"].type().name()) {
        GetLiveChannelHistoryRequestFilter model1;
        model1.fromMap(boost::any_cast<map<string, boost::any>>(m["Filter"]));
        filter = make_shared<GetLiveChannelHistoryRequestFilter>(model1);
      }
    }
  }

  shared_ptr<string> bucketName{};
  shared_ptr<string> channelName{};
  shared_ptr<GetLiveChannelHistoryRequestFilter> filter{};

  ~GetLiveChannelHistoryRequest() = default;
};
class GetLiveChannelHistoryResponseLiveChannelHistoryLiveRecord
    : public Darabonba::Model {
public:
  GetLiveChannelHistoryResponseLiveChannelHistoryLiveRecord() {}
  explicit GetLiveChannelHistoryResponseLiveChannelHistoryLiveRecord(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {}

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (startTime) {
      res["StartTime"] = boost::any(*startTime);
    }
    if (endTime) {
      res["EndTime"] = boost::any(*endTime);
    }
    if (remoteAddr) {
      res["RemoteAddr"] = boost::any(*remoteAddr);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("StartTime") != m.end()) {
      startTime = make_shared<string>(boost::any_cast<string>(m["StartTime"]));
    }
    if (m.find("EndTime") != m.end()) {
      endTime = make_shared<string>(boost::any_cast<string>(m["EndTime"]));
    }
    if (m.find("RemoteAddr") != m.end()) {
      remoteAddr =
          make_shared<string>(boost::any_cast<string>(m["RemoteAddr"]));
    }
  }

  shared_ptr<string> startTime{};
  shared_ptr<string> endTime{};
  shared_ptr<string> remoteAddr{};

  ~GetLiveChannelHistoryResponseLiveChannelHistoryLiveRecord() = default;
};
class GetLiveChannelHistoryResponseLiveChannelHistory
    : public Darabonba::Model {
public:
  GetLiveChannelHistoryResponseLiveChannelHistory() {}
  explicit GetLiveChannelHistoryResponseLiveChannelHistory(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {}

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (liveRecord) {
      vector<boost::any> temp1;
      for (auto item1 : *liveRecord) {
        temp1.push_back(boost::any(item1.toMap()));
      }
      res["LiveRecord"] = boost::any(temp1);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("LiveRecord") != m.end()) {
      if (typeid(vector<boost::any>).name() == m["LiveRecord"].type().name()) {
        vector<GetLiveChannelHistoryResponseLiveChannelHistoryLiveRecord>
            expect1;
        for (auto item1 :
             boost::any_cast<vector<boost::any>>(m["LiveRecord"])) {
          if (typeid(map<string, boost::any>).name() == item1.type().name()) {
            GetLiveChannelHistoryResponseLiveChannelHistoryLiveRecord model2;
            model2.fromMap(boost::any_cast<map<string, boost::any>>(item1));
            expect1.push_back(model2);
          }
        }
        liveRecord = make_shared<
            vector<GetLiveChannelHistoryResponseLiveChannelHistoryLiveRecord>>(
            expect1);
      }
    }
  }

  shared_ptr<vector<GetLiveChannelHistoryResponseLiveChannelHistoryLiveRecord>>
      liveRecord{};

  ~GetLiveChannelHistoryResponseLiveChannelHistory() = default;
};
class GetLiveChannelHistoryResponse : public Darabonba::Model {
public:
  GetLiveChannelHistoryResponse() {}
  explicit GetLiveChannelHistoryResponse(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!requestId) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("requestId is required.")));
    }
    if (!liveChannelHistory) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("liveChannelHistory is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (requestId) {
      res["x-oss-request-id"] = boost::any(*requestId);
    }
    if (liveChannelHistory) {
      res["LiveChannelHistory"] = liveChannelHistory
                                      ? boost::any(liveChannelHistory->toMap())
                                      : boost::any(map<string, boost::any>({}));
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("x-oss-request-id") != m.end()) {
      requestId =
          make_shared<string>(boost::any_cast<string>(m["x-oss-request-id"]));
    }
    if (m.find("LiveChannelHistory") != m.end()) {
      if (typeid(map<string, boost::any>).name() ==
          m["LiveChannelHistory"].type().name()) {
        GetLiveChannelHistoryResponseLiveChannelHistory model1;
        model1.fromMap(
            boost::any_cast<map<string, boost::any>>(m["LiveChannelHistory"]));
        liveChannelHistory =
            make_shared<GetLiveChannelHistoryResponseLiveChannelHistory>(
                model1);
      }
    }
  }

  shared_ptr<string> requestId{};
  shared_ptr<GetLiveChannelHistoryResponseLiveChannelHistory>
      liveChannelHistory{};

  ~GetLiveChannelHistoryResponse() = default;
};
class GetBucketRequestFilter : public Darabonba::Model {
public:
  GetBucketRequestFilter() {}
  explicit GetBucketRequestFilter(const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {}

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (delimiter) {
      res["delimiter"] = boost::any(*delimiter);
    }
    if (marker) {
      res["marker"] = boost::any(*marker);
    }
    if (maxKeys) {
      res["max-keys"] = boost::any(*maxKeys);
    }
    if (prefix) {
      res["prefix"] = boost::any(*prefix);
    }
    if (encodingType) {
      res["encoding-type"] = boost::any(*encodingType);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("delimiter") != m.end()) {
      delimiter = make_shared<string>(boost::any_cast<string>(m["delimiter"]));
    }
    if (m.find("marker") != m.end()) {
      marker = make_shared<string>(boost::any_cast<string>(m["marker"]));
    }
    if (m.find("max-keys") != m.end()) {
      maxKeys = make_shared<string>(boost::any_cast<string>(m["max-keys"]));
    }
    if (m.find("prefix") != m.end()) {
      prefix = make_shared<string>(boost::any_cast<string>(m["prefix"]));
    }
    if (m.find("encoding-type") != m.end()) {
      encodingType =
          make_shared<string>(boost::any_cast<string>(m["encoding-type"]));
    }
  }

  shared_ptr<string> delimiter{};
  shared_ptr<string> marker{};
  shared_ptr<string> maxKeys{};
  shared_ptr<string> prefix{};
  shared_ptr<string> encodingType{};

  ~GetBucketRequestFilter() = default;
};
class GetBucketRequest : public Darabonba::Model {
public:
  GetBucketRequest() {}
  explicit GetBucketRequest(const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!bucketName) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("bucketName is required.")));
    }
    Darabonba::Model::validatePattern("bucketName", bucketName,
                                      "[a-zA-Z0-9\\\\-\\\\_]+");
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (bucketName) {
      res["BucketName"] = boost::any(*bucketName);
    }
    if (filter) {
      res["Filter"] = filter ? boost::any(filter->toMap())
                             : boost::any(map<string, boost::any>({}));
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("BucketName") != m.end()) {
      bucketName =
          make_shared<string>(boost::any_cast<string>(m["BucketName"]));
    }
    if (m.find("Filter") != m.end()) {
      if (typeid(map<string, boost::any>).name() == m["Filter"].type().name()) {
        GetBucketRequestFilter model1;
        model1.fromMap(boost::any_cast<map<string, boost::any>>(m["Filter"]));
        filter = make_shared<GetBucketRequestFilter>(model1);
      }
    }
  }

  shared_ptr<string> bucketName{};
  shared_ptr<GetBucketRequestFilter> filter{};

  ~GetBucketRequest() = default;
};
class GetBucketResponseListBucketResultContentsOwner : public Darabonba::Model {
public:
  GetBucketResponseListBucketResultContentsOwner() {}
  explicit GetBucketResponseListBucketResultContentsOwner(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {}

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (iD) {
      res["ID"] = boost::any(*iD);
    }
    if (displayName) {
      res["DisplayName"] = boost::any(*displayName);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("ID") != m.end()) {
      iD = make_shared<string>(boost::any_cast<string>(m["ID"]));
    }
    if (m.find("DisplayName") != m.end()) {
      displayName =
          make_shared<string>(boost::any_cast<string>(m["DisplayName"]));
    }
  }

  shared_ptr<string> iD{};
  shared_ptr<string> displayName{};

  ~GetBucketResponseListBucketResultContentsOwner() = default;
};
class GetBucketResponseListBucketResultContents : public Darabonba::Model {
public:
  GetBucketResponseListBucketResultContents() {}
  explicit GetBucketResponseListBucketResultContents(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!owner) {
      BOOST_THROW_EXCEPTION(
          boost::enable_error_info(std::runtime_error("owner is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (key) {
      res["Key"] = boost::any(*key);
    }
    if (eTag) {
      res["ETag"] = boost::any(*eTag);
    }
    if (lastModified) {
      res["LastModified"] = boost::any(*lastModified);
    }
    if (size) {
      res["Size"] = boost::any(*size);
    }
    if (storageClass) {
      res["StorageClass"] = boost::any(*storageClass);
    }
    if (owner) {
      res["Owner"] = owner ? boost::any(owner->toMap())
                           : boost::any(map<string, boost::any>({}));
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("Key") != m.end()) {
      key = make_shared<string>(boost::any_cast<string>(m["Key"]));
    }
    if (m.find("ETag") != m.end()) {
      eTag = make_shared<string>(boost::any_cast<string>(m["ETag"]));
    }
    if (m.find("LastModified") != m.end()) {
      lastModified =
          make_shared<string>(boost::any_cast<string>(m["LastModified"]));
    }
    if (m.find("Size") != m.end()) {
      size = make_shared<string>(boost::any_cast<string>(m["Size"]));
    }
    if (m.find("StorageClass") != m.end()) {
      storageClass =
          make_shared<string>(boost::any_cast<string>(m["StorageClass"]));
    }
    if (m.find("Owner") != m.end()) {
      if (typeid(map<string, boost::any>).name() == m["Owner"].type().name()) {
        GetBucketResponseListBucketResultContentsOwner model1;
        model1.fromMap(boost::any_cast<map<string, boost::any>>(m["Owner"]));
        owner =
            make_shared<GetBucketResponseListBucketResultContentsOwner>(model1);
      }
    }
  }

  shared_ptr<string> key{};
  shared_ptr<string> eTag{};
  shared_ptr<string> lastModified{};
  shared_ptr<string> size{};
  shared_ptr<string> storageClass{};
  shared_ptr<GetBucketResponseListBucketResultContentsOwner> owner{};

  ~GetBucketResponseListBucketResultContents() = default;
};
class GetBucketResponseListBucketResult : public Darabonba::Model {
public:
  GetBucketResponseListBucketResult() {}
  explicit GetBucketResponseListBucketResult(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {}

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (name) {
      res["Name"] = boost::any(*name);
    }
    if (prefix) {
      res["Prefix"] = boost::any(*prefix);
    }
    if (marker) {
      res["Marker"] = boost::any(*marker);
    }
    if (maxKeys) {
      res["MaxKeys"] = boost::any(*maxKeys);
    }
    if (delimiter) {
      res["Delimiter"] = boost::any(*delimiter);
    }
    if (isTruncated) {
      res["IsTruncated"] = boost::any(*isTruncated);
    }
    if (encodingType) {
      res["EncodingType"] = boost::any(*encodingType);
    }
    if (commonPrefixes) {
      res["CommonPrefixes"] = boost::any(*commonPrefixes);
    }
    if (contents) {
      vector<boost::any> temp1;
      for (auto item1 : *contents) {
        temp1.push_back(boost::any(item1.toMap()));
      }
      res["Contents"] = boost::any(temp1);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("Name") != m.end()) {
      name = make_shared<string>(boost::any_cast<string>(m["Name"]));
    }
    if (m.find("Prefix") != m.end()) {
      prefix = make_shared<string>(boost::any_cast<string>(m["Prefix"]));
    }
    if (m.find("Marker") != m.end()) {
      marker = make_shared<string>(boost::any_cast<string>(m["Marker"]));
    }
    if (m.find("MaxKeys") != m.end()) {
      maxKeys = make_shared<string>(boost::any_cast<string>(m["MaxKeys"]));
    }
    if (m.find("Delimiter") != m.end()) {
      delimiter = make_shared<string>(boost::any_cast<string>(m["Delimiter"]));
    }
    if (m.find("IsTruncated") != m.end()) {
      isTruncated =
          make_shared<string>(boost::any_cast<string>(m["IsTruncated"]));
    }
    if (m.find("EncodingType") != m.end()) {
      encodingType =
          make_shared<string>(boost::any_cast<string>(m["EncodingType"]));
    }
    if (m.find("CommonPrefixes") != m.end()) {
      commonPrefixes =
          make_shared<string>(boost::any_cast<string>(m["CommonPrefixes"]));
    }
    if (m.find("Contents") != m.end()) {
      if (typeid(vector<boost::any>).name() == m["Contents"].type().name()) {
        vector<GetBucketResponseListBucketResultContents> expect1;
        for (auto item1 : boost::any_cast<vector<boost::any>>(m["Contents"])) {
          if (typeid(map<string, boost::any>).name() == item1.type().name()) {
            GetBucketResponseListBucketResultContents model2;
            model2.fromMap(boost::any_cast<map<string, boost::any>>(item1));
            expect1.push_back(model2);
          }
        }
        contents =
            make_shared<vector<GetBucketResponseListBucketResultContents>>(
                expect1);
      }
    }
  }

  shared_ptr<string> name{};
  shared_ptr<string> prefix{};
  shared_ptr<string> marker{};
  shared_ptr<string> maxKeys{};
  shared_ptr<string> delimiter{};
  shared_ptr<string> isTruncated{};
  shared_ptr<string> encodingType{};
  shared_ptr<string> commonPrefixes{};
  shared_ptr<vector<GetBucketResponseListBucketResultContents>> contents{};

  ~GetBucketResponseListBucketResult() = default;
};
class GetBucketResponse : public Darabonba::Model {
public:
  GetBucketResponse() {}
  explicit GetBucketResponse(const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!requestId) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("requestId is required.")));
    }
    if (!listBucketResult) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("listBucketResult is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (requestId) {
      res["x-oss-request-id"] = boost::any(*requestId);
    }
    if (listBucketResult) {
      res["ListBucketResult"] = listBucketResult
                                    ? boost::any(listBucketResult->toMap())
                                    : boost::any(map<string, boost::any>({}));
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("x-oss-request-id") != m.end()) {
      requestId =
          make_shared<string>(boost::any_cast<string>(m["x-oss-request-id"]));
    }
    if (m.find("ListBucketResult") != m.end()) {
      if (typeid(map<string, boost::any>).name() ==
          m["ListBucketResult"].type().name()) {
        GetBucketResponseListBucketResult model1;
        model1.fromMap(
            boost::any_cast<map<string, boost::any>>(m["ListBucketResult"]));
        listBucketResult =
            make_shared<GetBucketResponseListBucketResult>(model1);
      }
    }
  }

  shared_ptr<string> requestId{};
  shared_ptr<GetBucketResponseListBucketResult> listBucketResult{};

  ~GetBucketResponse() = default;
};
class GetLiveChannelInfoRequest : public Darabonba::Model {
public:
  GetLiveChannelInfoRequest() {}
  explicit GetLiveChannelInfoRequest(const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!bucketName) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("bucketName is required.")));
    }
    Darabonba::Model::validatePattern("bucketName", bucketName,
                                      "[a-zA-Z0-9\\\\-\\\\_]+");
    if (!channelName) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("channelName is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (bucketName) {
      res["BucketName"] = boost::any(*bucketName);
    }
    if (channelName) {
      res["ChannelName"] = boost::any(*channelName);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("BucketName") != m.end()) {
      bucketName =
          make_shared<string>(boost::any_cast<string>(m["BucketName"]));
    }
    if (m.find("ChannelName") != m.end()) {
      channelName =
          make_shared<string>(boost::any_cast<string>(m["ChannelName"]));
    }
  }

  shared_ptr<string> bucketName{};
  shared_ptr<string> channelName{};

  ~GetLiveChannelInfoRequest() = default;
};
class GetLiveChannelInfoResponseLiveChannelConfigurationTarget
    : public Darabonba::Model {
public:
  GetLiveChannelInfoResponseLiveChannelConfigurationTarget() {}
  explicit GetLiveChannelInfoResponseLiveChannelConfigurationTarget(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {}

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (type) {
      res["Type"] = boost::any(*type);
    }
    if (fragDuration) {
      res["FragDuration"] = boost::any(*fragDuration);
    }
    if (fragCount) {
      res["FragCount"] = boost::any(*fragCount);
    }
    if (playlistName) {
      res["PlaylistName"] = boost::any(*playlistName);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("Type") != m.end()) {
      type = make_shared<string>(boost::any_cast<string>(m["Type"]));
    }
    if (m.find("FragDuration") != m.end()) {
      fragDuration =
          make_shared<string>(boost::any_cast<string>(m["FragDuration"]));
    }
    if (m.find("FragCount") != m.end()) {
      fragCount = make_shared<string>(boost::any_cast<string>(m["FragCount"]));
    }
    if (m.find("PlaylistName") != m.end()) {
      playlistName =
          make_shared<string>(boost::any_cast<string>(m["PlaylistName"]));
    }
  }

  shared_ptr<string> type{};
  shared_ptr<string> fragDuration{};
  shared_ptr<string> fragCount{};
  shared_ptr<string> playlistName{};

  ~GetLiveChannelInfoResponseLiveChannelConfigurationTarget() = default;
};
class GetLiveChannelInfoResponseLiveChannelConfiguration
    : public Darabonba::Model {
public:
  GetLiveChannelInfoResponseLiveChannelConfiguration() {}
  explicit GetLiveChannelInfoResponseLiveChannelConfiguration(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!target) {
      BOOST_THROW_EXCEPTION(
          boost::enable_error_info(std::runtime_error("target is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (description) {
      res["Description"] = boost::any(*description);
    }
    if (status) {
      res["Status"] = boost::any(*status);
    }
    if (target) {
      res["Target"] = target ? boost::any(target->toMap())
                             : boost::any(map<string, boost::any>({}));
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("Description") != m.end()) {
      description =
          make_shared<string>(boost::any_cast<string>(m["Description"]));
    }
    if (m.find("Status") != m.end()) {
      status = make_shared<string>(boost::any_cast<string>(m["Status"]));
    }
    if (m.find("Target") != m.end()) {
      if (typeid(map<string, boost::any>).name() == m["Target"].type().name()) {
        GetLiveChannelInfoResponseLiveChannelConfigurationTarget model1;
        model1.fromMap(boost::any_cast<map<string, boost::any>>(m["Target"]));
        target = make_shared<
            GetLiveChannelInfoResponseLiveChannelConfigurationTarget>(model1);
      }
    }
  }

  shared_ptr<string> description{};
  shared_ptr<string> status{};
  shared_ptr<GetLiveChannelInfoResponseLiveChannelConfigurationTarget> target{};

  ~GetLiveChannelInfoResponseLiveChannelConfiguration() = default;
};
class GetLiveChannelInfoResponse : public Darabonba::Model {
public:
  GetLiveChannelInfoResponse() {}
  explicit GetLiveChannelInfoResponse(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!requestId) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("requestId is required.")));
    }
    if (!liveChannelConfiguration) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("liveChannelConfiguration is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (requestId) {
      res["x-oss-request-id"] = boost::any(*requestId);
    }
    if (liveChannelConfiguration) {
      res["LiveChannelConfiguration"] =
          liveChannelConfiguration
              ? boost::any(liveChannelConfiguration->toMap())
              : boost::any(map<string, boost::any>({}));
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("x-oss-request-id") != m.end()) {
      requestId =
          make_shared<string>(boost::any_cast<string>(m["x-oss-request-id"]));
    }
    if (m.find("LiveChannelConfiguration") != m.end()) {
      if (typeid(map<string, boost::any>).name() ==
          m["LiveChannelConfiguration"].type().name()) {
        GetLiveChannelInfoResponseLiveChannelConfiguration model1;
        model1.fromMap(boost::any_cast<map<string, boost::any>>(
            m["LiveChannelConfiguration"]));
        liveChannelConfiguration =
            make_shared<GetLiveChannelInfoResponseLiveChannelConfiguration>(
                model1);
      }
    }
  }

  shared_ptr<string> requestId{};
  shared_ptr<GetLiveChannelInfoResponseLiveChannelConfiguration>
      liveChannelConfiguration{};

  ~GetLiveChannelInfoResponse() = default;
};
class GetLiveChannelStatRequestFilter : public Darabonba::Model {
public:
  GetLiveChannelStatRequestFilter() {}
  explicit GetLiveChannelStatRequestFilter(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {}

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (comp) {
      res["comp"] = boost::any(*comp);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("comp") != m.end()) {
      comp = make_shared<string>(boost::any_cast<string>(m["comp"]));
    }
  }

  shared_ptr<string> comp{};

  ~GetLiveChannelStatRequestFilter() = default;
};
class GetLiveChannelStatRequest : public Darabonba::Model {
public:
  GetLiveChannelStatRequest() {}
  explicit GetLiveChannelStatRequest(const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!bucketName) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("bucketName is required.")));
    }
    Darabonba::Model::validatePattern("bucketName", bucketName,
                                      "[a-zA-Z0-9\\\\-\\\\_]+");
    if (!channelName) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("channelName is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (bucketName) {
      res["BucketName"] = boost::any(*bucketName);
    }
    if (channelName) {
      res["ChannelName"] = boost::any(*channelName);
    }
    if (filter) {
      res["Filter"] = filter ? boost::any(filter->toMap())
                             : boost::any(map<string, boost::any>({}));
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("BucketName") != m.end()) {
      bucketName =
          make_shared<string>(boost::any_cast<string>(m["BucketName"]));
    }
    if (m.find("ChannelName") != m.end()) {
      channelName =
          make_shared<string>(boost::any_cast<string>(m["ChannelName"]));
    }
    if (m.find("Filter") != m.end()) {
      if (typeid(map<string, boost::any>).name() == m["Filter"].type().name()) {
        GetLiveChannelStatRequestFilter model1;
        model1.fromMap(boost::any_cast<map<string, boost::any>>(m["Filter"]));
        filter = make_shared<GetLiveChannelStatRequestFilter>(model1);
      }
    }
  }

  shared_ptr<string> bucketName{};
  shared_ptr<string> channelName{};
  shared_ptr<GetLiveChannelStatRequestFilter> filter{};

  ~GetLiveChannelStatRequest() = default;
};
class GetLiveChannelStatResponseLiveChannelStatVideo : public Darabonba::Model {
public:
  GetLiveChannelStatResponseLiveChannelStatVideo() {}
  explicit GetLiveChannelStatResponseLiveChannelStatVideo(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {}

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (width) {
      res["Width"] = boost::any(*width);
    }
    if (height) {
      res["Height"] = boost::any(*height);
    }
    if (frameRate) {
      res["FrameRate"] = boost::any(*frameRate);
    }
    if (bandwidth) {
      res["Bandwidth"] = boost::any(*bandwidth);
    }
    if (codec) {
      res["Codec"] = boost::any(*codec);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("Width") != m.end()) {
      width = make_shared<string>(boost::any_cast<string>(m["Width"]));
    }
    if (m.find("Height") != m.end()) {
      height = make_shared<string>(boost::any_cast<string>(m["Height"]));
    }
    if (m.find("FrameRate") != m.end()) {
      frameRate = make_shared<string>(boost::any_cast<string>(m["FrameRate"]));
    }
    if (m.find("Bandwidth") != m.end()) {
      bandwidth = make_shared<string>(boost::any_cast<string>(m["Bandwidth"]));
    }
    if (m.find("Codec") != m.end()) {
      codec = make_shared<string>(boost::any_cast<string>(m["Codec"]));
    }
  }

  shared_ptr<string> width{};
  shared_ptr<string> height{};
  shared_ptr<string> frameRate{};
  shared_ptr<string> bandwidth{};
  shared_ptr<string> codec{};

  ~GetLiveChannelStatResponseLiveChannelStatVideo() = default;
};
class GetLiveChannelStatResponseLiveChannelStatAudio : public Darabonba::Model {
public:
  GetLiveChannelStatResponseLiveChannelStatAudio() {}
  explicit GetLiveChannelStatResponseLiveChannelStatAudio(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {}

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (bandwidth) {
      res["Bandwidth"] = boost::any(*bandwidth);
    }
    if (sampleRate) {
      res["SampleRate"] = boost::any(*sampleRate);
    }
    if (codec) {
      res["Codec"] = boost::any(*codec);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("Bandwidth") != m.end()) {
      bandwidth = make_shared<string>(boost::any_cast<string>(m["Bandwidth"]));
    }
    if (m.find("SampleRate") != m.end()) {
      sampleRate =
          make_shared<string>(boost::any_cast<string>(m["SampleRate"]));
    }
    if (m.find("Codec") != m.end()) {
      codec = make_shared<string>(boost::any_cast<string>(m["Codec"]));
    }
  }

  shared_ptr<string> bandwidth{};
  shared_ptr<string> sampleRate{};
  shared_ptr<string> codec{};

  ~GetLiveChannelStatResponseLiveChannelStatAudio() = default;
};
class GetLiveChannelStatResponseLiveChannelStat : public Darabonba::Model {
public:
  GetLiveChannelStatResponseLiveChannelStat() {}
  explicit GetLiveChannelStatResponseLiveChannelStat(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!video) {
      BOOST_THROW_EXCEPTION(
          boost::enable_error_info(std::runtime_error("video is required.")));
    }
    if (!audio) {
      BOOST_THROW_EXCEPTION(
          boost::enable_error_info(std::runtime_error("audio is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (status) {
      res["Status"] = boost::any(*status);
    }
    if (connectedTime) {
      res["ConnectedTime"] = boost::any(*connectedTime);
    }
    if (remoteAddr) {
      res["RemoteAddr"] = boost::any(*remoteAddr);
    }
    if (video) {
      res["Video"] = video ? boost::any(video->toMap())
                           : boost::any(map<string, boost::any>({}));
    }
    if (audio) {
      res["Audio"] = audio ? boost::any(audio->toMap())
                           : boost::any(map<string, boost::any>({}));
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("Status") != m.end()) {
      status = make_shared<string>(boost::any_cast<string>(m["Status"]));
    }
    if (m.find("ConnectedTime") != m.end()) {
      connectedTime =
          make_shared<string>(boost::any_cast<string>(m["ConnectedTime"]));
    }
    if (m.find("RemoteAddr") != m.end()) {
      remoteAddr =
          make_shared<string>(boost::any_cast<string>(m["RemoteAddr"]));
    }
    if (m.find("Video") != m.end()) {
      if (typeid(map<string, boost::any>).name() == m["Video"].type().name()) {
        GetLiveChannelStatResponseLiveChannelStatVideo model1;
        model1.fromMap(boost::any_cast<map<string, boost::any>>(m["Video"]));
        video =
            make_shared<GetLiveChannelStatResponseLiveChannelStatVideo>(model1);
      }
    }
    if (m.find("Audio") != m.end()) {
      if (typeid(map<string, boost::any>).name() == m["Audio"].type().name()) {
        GetLiveChannelStatResponseLiveChannelStatAudio model1;
        model1.fromMap(boost::any_cast<map<string, boost::any>>(m["Audio"]));
        audio =
            make_shared<GetLiveChannelStatResponseLiveChannelStatAudio>(model1);
      }
    }
  }

  shared_ptr<string> status{};
  shared_ptr<string> connectedTime{};
  shared_ptr<string> remoteAddr{};
  shared_ptr<GetLiveChannelStatResponseLiveChannelStatVideo> video{};
  shared_ptr<GetLiveChannelStatResponseLiveChannelStatAudio> audio{};

  ~GetLiveChannelStatResponseLiveChannelStat() = default;
};
class GetLiveChannelStatResponse : public Darabonba::Model {
public:
  GetLiveChannelStatResponse() {}
  explicit GetLiveChannelStatResponse(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!requestId) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("requestId is required.")));
    }
    if (!liveChannelStat) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("liveChannelStat is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (requestId) {
      res["x-oss-request-id"] = boost::any(*requestId);
    }
    if (liveChannelStat) {
      res["LiveChannelStat"] = liveChannelStat
                                   ? boost::any(liveChannelStat->toMap())
                                   : boost::any(map<string, boost::any>({}));
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("x-oss-request-id") != m.end()) {
      requestId =
          make_shared<string>(boost::any_cast<string>(m["x-oss-request-id"]));
    }
    if (m.find("LiveChannelStat") != m.end()) {
      if (typeid(map<string, boost::any>).name() ==
          m["LiveChannelStat"].type().name()) {
        GetLiveChannelStatResponseLiveChannelStat model1;
        model1.fromMap(
            boost::any_cast<map<string, boost::any>>(m["LiveChannelStat"]));
        liveChannelStat =
            make_shared<GetLiveChannelStatResponseLiveChannelStat>(model1);
      }
    }
  }

  shared_ptr<string> requestId{};
  shared_ptr<GetLiveChannelStatResponseLiveChannelStat> liveChannelStat{};

  ~GetLiveChannelStatResponse() = default;
};
class DeleteObjectRequest : public Darabonba::Model {
public:
  DeleteObjectRequest() {}
  explicit DeleteObjectRequest(const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!bucketName) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("bucketName is required.")));
    }
    Darabonba::Model::validatePattern("bucketName", bucketName,
                                      "[a-zA-Z0-9\\\\-\\\\_]+");
    if (!objectName) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("objectName is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (bucketName) {
      res["BucketName"] = boost::any(*bucketName);
    }
    if (objectName) {
      res["ObjectName"] = boost::any(*objectName);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("BucketName") != m.end()) {
      bucketName =
          make_shared<string>(boost::any_cast<string>(m["BucketName"]));
    }
    if (m.find("ObjectName") != m.end()) {
      objectName =
          make_shared<string>(boost::any_cast<string>(m["ObjectName"]));
    }
  }

  shared_ptr<string> bucketName{};
  shared_ptr<string> objectName{};

  ~DeleteObjectRequest() = default;
};
class DeleteObjectResponse : public Darabonba::Model {
public:
  DeleteObjectResponse() {}
  explicit DeleteObjectResponse(const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!requestId) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("requestId is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (requestId) {
      res["x-oss-request-id"] = boost::any(*requestId);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("x-oss-request-id") != m.end()) {
      requestId =
          make_shared<string>(boost::any_cast<string>(m["x-oss-request-id"]));
    }
  }

  shared_ptr<string> requestId{};

  ~DeleteObjectResponse() = default;
};
class AbortMultipartUploadRequestFilter : public Darabonba::Model {
public:
  AbortMultipartUploadRequestFilter() {}
  explicit AbortMultipartUploadRequestFilter(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!uploadId) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("uploadId is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (uploadId) {
      res["uploadId"] = boost::any(*uploadId);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("uploadId") != m.end()) {
      uploadId = make_shared<string>(boost::any_cast<string>(m["uploadId"]));
    }
  }

  shared_ptr<string> uploadId{};

  ~AbortMultipartUploadRequestFilter() = default;
};
class AbortMultipartUploadRequest : public Darabonba::Model {
public:
  AbortMultipartUploadRequest() {}
  explicit AbortMultipartUploadRequest(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!bucketName) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("bucketName is required.")));
    }
    Darabonba::Model::validatePattern("bucketName", bucketName,
                                      "[a-zA-Z0-9\\\\-\\\\_]+");
    if (!objectName) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("objectName is required.")));
    }
    if (!filter) {
      BOOST_THROW_EXCEPTION(
          boost::enable_error_info(std::runtime_error("filter is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (bucketName) {
      res["BucketName"] = boost::any(*bucketName);
    }
    if (objectName) {
      res["ObjectName"] = boost::any(*objectName);
    }
    if (filter) {
      res["Filter"] = filter ? boost::any(filter->toMap())
                             : boost::any(map<string, boost::any>({}));
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("BucketName") != m.end()) {
      bucketName =
          make_shared<string>(boost::any_cast<string>(m["BucketName"]));
    }
    if (m.find("ObjectName") != m.end()) {
      objectName =
          make_shared<string>(boost::any_cast<string>(m["ObjectName"]));
    }
    if (m.find("Filter") != m.end()) {
      if (typeid(map<string, boost::any>).name() == m["Filter"].type().name()) {
        AbortMultipartUploadRequestFilter model1;
        model1.fromMap(boost::any_cast<map<string, boost::any>>(m["Filter"]));
        filter = make_shared<AbortMultipartUploadRequestFilter>(model1);
      }
    }
  }

  shared_ptr<string> bucketName{};
  shared_ptr<string> objectName{};
  shared_ptr<AbortMultipartUploadRequestFilter> filter{};

  ~AbortMultipartUploadRequest() = default;
};
class AbortMultipartUploadResponse : public Darabonba::Model {
public:
  AbortMultipartUploadResponse() {}
  explicit AbortMultipartUploadResponse(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!requestId) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("requestId is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (requestId) {
      res["x-oss-request-id"] = boost::any(*requestId);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("x-oss-request-id") != m.end()) {
      requestId =
          make_shared<string>(boost::any_cast<string>(m["x-oss-request-id"]));
    }
  }

  shared_ptr<string> requestId{};

  ~AbortMultipartUploadResponse() = default;
};
class AppendObjectRequestFilter : public Darabonba::Model {
public:
  AppendObjectRequestFilter() {}
  explicit AppendObjectRequestFilter(const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!position) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("position is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (position) {
      res["position"] = boost::any(*position);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("position") != m.end()) {
      position = make_shared<string>(boost::any_cast<string>(m["position"]));
    }
  }

  shared_ptr<string> position{};

  ~AppendObjectRequestFilter() = default;
};
class AppendObjectRequestHeader : public Darabonba::Model {
public:
  AppendObjectRequestHeader() {}
  explicit AppendObjectRequestHeader(const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {}

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (cacheControl) {
      res["Cache-Control"] = boost::any(*cacheControl);
    }
    if (contentDisposition) {
      res["Content-Disposition"] = boost::any(*contentDisposition);
    }
    if (contentEncoding) {
      res["Content-Encoding"] = boost::any(*contentEncoding);
    }
    if (contentMD5) {
      res["Content-MD5"] = boost::any(*contentMD5);
    }
    if (expires) {
      res["Expires"] = boost::any(*expires);
    }
    if (serverSideEncryption) {
      res["x-oss-server-side-encryption"] = boost::any(*serverSideEncryption);
    }
    if (objectAcl) {
      res["x-oss-object-acl"] = boost::any(*objectAcl);
    }
    if (storageClass) {
      res["x-oss-storage-class"] = boost::any(*storageClass);
    }
    if (contentType) {
      res["content-type"] = boost::any(*contentType);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("Cache-Control") != m.end()) {
      cacheControl =
          make_shared<string>(boost::any_cast<string>(m["Cache-Control"]));
    }
    if (m.find("Content-Disposition") != m.end()) {
      contentDisposition = make_shared<string>(
          boost::any_cast<string>(m["Content-Disposition"]));
    }
    if (m.find("Content-Encoding") != m.end()) {
      contentEncoding =
          make_shared<string>(boost::any_cast<string>(m["Content-Encoding"]));
    }
    if (m.find("Content-MD5") != m.end()) {
      contentMD5 =
          make_shared<string>(boost::any_cast<string>(m["Content-MD5"]));
    }
    if (m.find("Expires") != m.end()) {
      expires = make_shared<string>(boost::any_cast<string>(m["Expires"]));
    }
    if (m.find("x-oss-server-side-encryption") != m.end()) {
      serverSideEncryption = make_shared<string>(
          boost::any_cast<string>(m["x-oss-server-side-encryption"]));
    }
    if (m.find("x-oss-object-acl") != m.end()) {
      objectAcl =
          make_shared<string>(boost::any_cast<string>(m["x-oss-object-acl"]));
    }
    if (m.find("x-oss-storage-class") != m.end()) {
      storageClass = make_shared<string>(
          boost::any_cast<string>(m["x-oss-storage-class"]));
    }
    if (m.find("content-type") != m.end()) {
      contentType =
          make_shared<string>(boost::any_cast<string>(m["content-type"]));
    }
  }

  shared_ptr<string> cacheControl{};
  shared_ptr<string> contentDisposition{};
  shared_ptr<string> contentEncoding{};
  shared_ptr<string> contentMD5{};
  shared_ptr<string> expires{};
  shared_ptr<string> serverSideEncryption{};
  shared_ptr<string> objectAcl{};
  shared_ptr<string> storageClass{};
  shared_ptr<string> contentType{};

  ~AppendObjectRequestHeader() = default;
};
class AppendObjectRequest : public Darabonba::Model {
public:
  AppendObjectRequest() {}
  explicit AppendObjectRequest(const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!bucketName) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("bucketName is required.")));
    }
    Darabonba::Model::validatePattern("bucketName", bucketName,
                                      "[a-zA-Z0-9\\\\-\\\\_]+");
    if (!objectName) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("objectName is required.")));
    }
    if (!filter) {
      BOOST_THROW_EXCEPTION(
          boost::enable_error_info(std::runtime_error("filter is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (bucketName) {
      res["BucketName"] = boost::any(*bucketName);
    }
    if (objectName) {
      res["ObjectName"] = boost::any(*objectName);
    }
    if (userMeta) {
      res["UserMeta"] = boost::any(*userMeta);
    }
    if (body) {
      res["body"] = boost::any(*body);
    }
    if (filter) {
      res["Filter"] = filter ? boost::any(filter->toMap())
                             : boost::any(map<string, boost::any>({}));
    }
    if (header) {
      res["Header"] = header ? boost::any(header->toMap())
                             : boost::any(map<string, boost::any>({}));
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("BucketName") != m.end()) {
      bucketName =
          make_shared<string>(boost::any_cast<string>(m["BucketName"]));
    }
    if (m.find("ObjectName") != m.end()) {
      objectName =
          make_shared<string>(boost::any_cast<string>(m["ObjectName"]));
    }
    if (m.find("UserMeta") != m.end()) {
      map<string, boost::any> map1 =
          boost::any_cast<map<string, boost::any>>(m["UserMeta"]);
      map<string, string> toMap1;
      for (auto item : map1) {
        toMap1[item.first] = boost::any_cast<string>(item.second);
      }
      userMeta = make_shared<map<string, string>>(toMap1);
    }
    if (m.find("body") != m.end()) {
      body = make_shared<Darabonba::Stream>(
          boost::any_cast<Darabonba::Stream>(m["body"]));
    }
    if (m.find("Filter") != m.end()) {
      if (typeid(map<string, boost::any>).name() == m["Filter"].type().name()) {
        AppendObjectRequestFilter model1;
        model1.fromMap(boost::any_cast<map<string, boost::any>>(m["Filter"]));
        filter = make_shared<AppendObjectRequestFilter>(model1);
      }
    }
    if (m.find("Header") != m.end()) {
      if (typeid(map<string, boost::any>).name() == m["Header"].type().name()) {
        AppendObjectRequestHeader model1;
        model1.fromMap(boost::any_cast<map<string, boost::any>>(m["Header"]));
        header = make_shared<AppendObjectRequestHeader>(model1);
      }
    }
  }

  shared_ptr<string> bucketName{};
  shared_ptr<string> objectName{};
  shared_ptr<map<string, string>> userMeta{};
  shared_ptr<Darabonba::Stream> body{};
  shared_ptr<AppendObjectRequestFilter> filter{};
  shared_ptr<AppendObjectRequestHeader> header{};

  ~AppendObjectRequest() = default;
};
class AppendObjectResponse : public Darabonba::Model {
public:
  AppendObjectResponse() {}
  explicit AppendObjectResponse(const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!requestId) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("requestId is required.")));
    }
    if (!nextAppendPosition) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("nextAppendPosition is required.")));
    }
    if (!hashCrc64ecma) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("hashCrc64ecma is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (requestId) {
      res["x-oss-request-id"] = boost::any(*requestId);
    }
    if (nextAppendPosition) {
      res["x-oss-next-append-position"] = boost::any(*nextAppendPosition);
    }
    if (hashCrc64ecma) {
      res["x-oss-hash-crc64ecma"] = boost::any(*hashCrc64ecma);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("x-oss-request-id") != m.end()) {
      requestId =
          make_shared<string>(boost::any_cast<string>(m["x-oss-request-id"]));
    }
    if (m.find("x-oss-next-append-position") != m.end()) {
      nextAppendPosition = make_shared<string>(
          boost::any_cast<string>(m["x-oss-next-append-position"]));
    }
    if (m.find("x-oss-hash-crc64ecma") != m.end()) {
      hashCrc64ecma = make_shared<string>(
          boost::any_cast<string>(m["x-oss-hash-crc64ecma"]));
    }
  }

  shared_ptr<string> requestId{};
  shared_ptr<string> nextAppendPosition{};
  shared_ptr<string> hashCrc64ecma{};

  ~AppendObjectResponse() = default;
};
class UploadPartCopyRequestFilter : public Darabonba::Model {
public:
  UploadPartCopyRequestFilter() {}
  explicit UploadPartCopyRequestFilter(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!partNumber) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("partNumber is required.")));
    }
    if (!uploadId) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("uploadId is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (partNumber) {
      res["partNumber"] = boost::any(*partNumber);
    }
    if (uploadId) {
      res["uploadId"] = boost::any(*uploadId);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("partNumber") != m.end()) {
      partNumber =
          make_shared<string>(boost::any_cast<string>(m["partNumber"]));
    }
    if (m.find("uploadId") != m.end()) {
      uploadId = make_shared<string>(boost::any_cast<string>(m["uploadId"]));
    }
  }

  shared_ptr<string> partNumber{};
  shared_ptr<string> uploadId{};

  ~UploadPartCopyRequestFilter() = default;
};
class UploadPartCopyRequestHeader : public Darabonba::Model {
public:
  UploadPartCopyRequestHeader() {}
  explicit UploadPartCopyRequestHeader(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!copySource) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("copySource is required.")));
    }
    if (!copySourceRange) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("copySourceRange is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (copySource) {
      res["x-oss-copy-source"] = boost::any(*copySource);
    }
    if (copySourceRange) {
      res["x-oss-copy-source-range"] = boost::any(*copySourceRange);
    }
    if (copySourceIfMatch) {
      res["x-oss-copy-source-if-match"] = boost::any(*copySourceIfMatch);
    }
    if (copySourceIfNoneMatch) {
      res["x-oss-copy-source-if-none-match"] =
          boost::any(*copySourceIfNoneMatch);
    }
    if (copySourceIfUnmodifiedSince) {
      res["x-oss-copy-source-if-unmodified-since"] =
          boost::any(*copySourceIfUnmodifiedSince);
    }
    if (copySourceIfModifiedSince) {
      res["x-oss-copy-source-if-modified-since"] =
          boost::any(*copySourceIfModifiedSince);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("x-oss-copy-source") != m.end()) {
      copySource =
          make_shared<string>(boost::any_cast<string>(m["x-oss-copy-source"]));
    }
    if (m.find("x-oss-copy-source-range") != m.end()) {
      copySourceRange = make_shared<string>(
          boost::any_cast<string>(m["x-oss-copy-source-range"]));
    }
    if (m.find("x-oss-copy-source-if-match") != m.end()) {
      copySourceIfMatch = make_shared<string>(
          boost::any_cast<string>(m["x-oss-copy-source-if-match"]));
    }
    if (m.find("x-oss-copy-source-if-none-match") != m.end()) {
      copySourceIfNoneMatch = make_shared<string>(
          boost::any_cast<string>(m["x-oss-copy-source-if-none-match"]));
    }
    if (m.find("x-oss-copy-source-if-unmodified-since") != m.end()) {
      copySourceIfUnmodifiedSince = make_shared<string>(
          boost::any_cast<string>(m["x-oss-copy-source-if-unmodified-since"]));
    }
    if (m.find("x-oss-copy-source-if-modified-since") != m.end()) {
      copySourceIfModifiedSince = make_shared<string>(
          boost::any_cast<string>(m["x-oss-copy-source-if-modified-since"]));
    }
  }

  shared_ptr<string> copySource{};
  shared_ptr<string> copySourceRange{};
  shared_ptr<string> copySourceIfMatch{};
  shared_ptr<string> copySourceIfNoneMatch{};
  shared_ptr<string> copySourceIfUnmodifiedSince{};
  shared_ptr<string> copySourceIfModifiedSince{};

  ~UploadPartCopyRequestHeader() = default;
};
class UploadPartCopyRequest : public Darabonba::Model {
public:
  UploadPartCopyRequest() {}
  explicit UploadPartCopyRequest(const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!bucketName) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("bucketName is required.")));
    }
    Darabonba::Model::validatePattern("bucketName", bucketName,
                                      "[a-zA-Z0-9\\\\-\\\\_]+");
    if (!objectName) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("objectName is required.")));
    }
    if (!filter) {
      BOOST_THROW_EXCEPTION(
          boost::enable_error_info(std::runtime_error("filter is required.")));
    }
    if (!header) {
      BOOST_THROW_EXCEPTION(
          boost::enable_error_info(std::runtime_error("header is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (bucketName) {
      res["BucketName"] = boost::any(*bucketName);
    }
    if (objectName) {
      res["ObjectName"] = boost::any(*objectName);
    }
    if (filter) {
      res["Filter"] = filter ? boost::any(filter->toMap())
                             : boost::any(map<string, boost::any>({}));
    }
    if (header) {
      res["Header"] = header ? boost::any(header->toMap())
                             : boost::any(map<string, boost::any>({}));
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("BucketName") != m.end()) {
      bucketName =
          make_shared<string>(boost::any_cast<string>(m["BucketName"]));
    }
    if (m.find("ObjectName") != m.end()) {
      objectName =
          make_shared<string>(boost::any_cast<string>(m["ObjectName"]));
    }
    if (m.find("Filter") != m.end()) {
      if (typeid(map<string, boost::any>).name() == m["Filter"].type().name()) {
        UploadPartCopyRequestFilter model1;
        model1.fromMap(boost::any_cast<map<string, boost::any>>(m["Filter"]));
        filter = make_shared<UploadPartCopyRequestFilter>(model1);
      }
    }
    if (m.find("Header") != m.end()) {
      if (typeid(map<string, boost::any>).name() == m["Header"].type().name()) {
        UploadPartCopyRequestHeader model1;
        model1.fromMap(boost::any_cast<map<string, boost::any>>(m["Header"]));
        header = make_shared<UploadPartCopyRequestHeader>(model1);
      }
    }
  }

  shared_ptr<string> bucketName{};
  shared_ptr<string> objectName{};
  shared_ptr<UploadPartCopyRequestFilter> filter{};
  shared_ptr<UploadPartCopyRequestHeader> header{};

  ~UploadPartCopyRequest() = default;
};
class UploadPartCopyResponseCopyPartResult : public Darabonba::Model {
public:
  UploadPartCopyResponseCopyPartResult() {}
  explicit UploadPartCopyResponseCopyPartResult(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {}

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (lastModified) {
      res["LastModified"] = boost::any(*lastModified);
    }
    if (eTag) {
      res["ETag"] = boost::any(*eTag);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("LastModified") != m.end()) {
      lastModified =
          make_shared<string>(boost::any_cast<string>(m["LastModified"]));
    }
    if (m.find("ETag") != m.end()) {
      eTag = make_shared<string>(boost::any_cast<string>(m["ETag"]));
    }
  }

  shared_ptr<string> lastModified{};
  shared_ptr<string> eTag{};

  ~UploadPartCopyResponseCopyPartResult() = default;
};
class UploadPartCopyResponse : public Darabonba::Model {
public:
  UploadPartCopyResponse() {}
  explicit UploadPartCopyResponse(const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!requestId) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("requestId is required.")));
    }
    if (!copyPartResult) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("copyPartResult is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (requestId) {
      res["x-oss-request-id"] = boost::any(*requestId);
    }
    if (copyPartResult) {
      res["CopyPartResult"] = copyPartResult
                                  ? boost::any(copyPartResult->toMap())
                                  : boost::any(map<string, boost::any>({}));
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("x-oss-request-id") != m.end()) {
      requestId =
          make_shared<string>(boost::any_cast<string>(m["x-oss-request-id"]));
    }
    if (m.find("CopyPartResult") != m.end()) {
      if (typeid(map<string, boost::any>).name() ==
          m["CopyPartResult"].type().name()) {
        UploadPartCopyResponseCopyPartResult model1;
        model1.fromMap(
            boost::any_cast<map<string, boost::any>>(m["CopyPartResult"]));
        copyPartResult =
            make_shared<UploadPartCopyResponseCopyPartResult>(model1);
      }
    }
  }

  shared_ptr<string> requestId{};
  shared_ptr<UploadPartCopyResponseCopyPartResult> copyPartResult{};

  ~UploadPartCopyResponse() = default;
};
class GetVodPlaylistRequestFilter : public Darabonba::Model {
public:
  GetVodPlaylistRequestFilter() {}
  explicit GetVodPlaylistRequestFilter(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!endTime) {
      BOOST_THROW_EXCEPTION(
          boost::enable_error_info(std::runtime_error("endTime is required.")));
    }
    if (!startTime) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("startTime is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (endTime) {
      res["endTime"] = boost::any(*endTime);
    }
    if (startTime) {
      res["startTime"] = boost::any(*startTime);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("endTime") != m.end()) {
      endTime = make_shared<string>(boost::any_cast<string>(m["endTime"]));
    }
    if (m.find("startTime") != m.end()) {
      startTime = make_shared<string>(boost::any_cast<string>(m["startTime"]));
    }
  }

  shared_ptr<string> endTime{};
  shared_ptr<string> startTime{};

  ~GetVodPlaylistRequestFilter() = default;
};
class GetVodPlaylistRequest : public Darabonba::Model {
public:
  GetVodPlaylistRequest() {}
  explicit GetVodPlaylistRequest(const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!bucketName) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("bucketName is required.")));
    }
    Darabonba::Model::validatePattern("bucketName", bucketName,
                                      "[a-zA-Z0-9\\\\-\\\\_]+");
    if (!channelName) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("channelName is required.")));
    }
    if (!filter) {
      BOOST_THROW_EXCEPTION(
          boost::enable_error_info(std::runtime_error("filter is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (bucketName) {
      res["BucketName"] = boost::any(*bucketName);
    }
    if (channelName) {
      res["ChannelName"] = boost::any(*channelName);
    }
    if (filter) {
      res["Filter"] = filter ? boost::any(filter->toMap())
                             : boost::any(map<string, boost::any>({}));
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("BucketName") != m.end()) {
      bucketName =
          make_shared<string>(boost::any_cast<string>(m["BucketName"]));
    }
    if (m.find("ChannelName") != m.end()) {
      channelName =
          make_shared<string>(boost::any_cast<string>(m["ChannelName"]));
    }
    if (m.find("Filter") != m.end()) {
      if (typeid(map<string, boost::any>).name() == m["Filter"].type().name()) {
        GetVodPlaylistRequestFilter model1;
        model1.fromMap(boost::any_cast<map<string, boost::any>>(m["Filter"]));
        filter = make_shared<GetVodPlaylistRequestFilter>(model1);
      }
    }
  }

  shared_ptr<string> bucketName{};
  shared_ptr<string> channelName{};
  shared_ptr<GetVodPlaylistRequestFilter> filter{};

  ~GetVodPlaylistRequest() = default;
};
class GetVodPlaylistResponse : public Darabonba::Model {
public:
  GetVodPlaylistResponse() {}
  explicit GetVodPlaylistResponse(const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!requestId) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("requestId is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (requestId) {
      res["x-oss-request-id"] = boost::any(*requestId);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("x-oss-request-id") != m.end()) {
      requestId =
          make_shared<string>(boost::any_cast<string>(m["x-oss-request-id"]));
    }
  }

  shared_ptr<string> requestId{};

  ~GetVodPlaylistResponse() = default;
};
class DeleteBucketCORSRequest : public Darabonba::Model {
public:
  DeleteBucketCORSRequest() {}
  explicit DeleteBucketCORSRequest(const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!bucketName) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("bucketName is required.")));
    }
    Darabonba::Model::validatePattern("bucketName", bucketName,
                                      "[a-zA-Z0-9\\\\-\\\\_]+");
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (bucketName) {
      res["BucketName"] = boost::any(*bucketName);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("BucketName") != m.end()) {
      bucketName =
          make_shared<string>(boost::any_cast<string>(m["BucketName"]));
    }
  }

  shared_ptr<string> bucketName{};

  ~DeleteBucketCORSRequest() = default;
};
class DeleteBucketCORSResponse : public Darabonba::Model {
public:
  DeleteBucketCORSResponse() {}
  explicit DeleteBucketCORSResponse(const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!requestId) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("requestId is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (requestId) {
      res["x-oss-request-id"] = boost::any(*requestId);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("x-oss-request-id") != m.end()) {
      requestId =
          make_shared<string>(boost::any_cast<string>(m["x-oss-request-id"]));
    }
  }

  shared_ptr<string> requestId{};

  ~DeleteBucketCORSResponse() = default;
};
class GetObjectRequestHeader : public Darabonba::Model {
public:
  GetObjectRequestHeader() {}
  explicit GetObjectRequestHeader(const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {}

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (responseContentType) {
      res["response-content-type"] = boost::any(*responseContentType);
    }
    if (responseContentLanguage) {
      res["response-content-language"] = boost::any(*responseContentLanguage);
    }
    if (responseExpires) {
      res["response-expires"] = boost::any(*responseExpires);
    }
    if (responseCacheControl) {
      res["response-cache-control"] = boost::any(*responseCacheControl);
    }
    if (responseContentDisposition) {
      res["response-content-disposition"] =
          boost::any(*responseContentDisposition);
    }
    if (responseContentEncoding) {
      res["response-content-encoding"] = boost::any(*responseContentEncoding);
    }
    if (range) {
      res["Range"] = boost::any(*range);
    }
    if (ifModifiedSince) {
      res["If-Modified-Since"] = boost::any(*ifModifiedSince);
    }
    if (ifUnmodifiedSince) {
      res["If-Unmodified-Since"] = boost::any(*ifUnmodifiedSince);
    }
    if (ifMatch) {
      res["If-Match"] = boost::any(*ifMatch);
    }
    if (ifNoneMatch) {
      res["If-None-Match"] = boost::any(*ifNoneMatch);
    }
    if (acceptEncoding) {
      res["Accept-Encoding"] = boost::any(*acceptEncoding);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("response-content-type") != m.end()) {
      responseContentType = make_shared<string>(
          boost::any_cast<string>(m["response-content-type"]));
    }
    if (m.find("response-content-language") != m.end()) {
      responseContentLanguage = make_shared<string>(
          boost::any_cast<string>(m["response-content-language"]));
    }
    if (m.find("response-expires") != m.end()) {
      responseExpires =
          make_shared<string>(boost::any_cast<string>(m["response-expires"]));
    }
    if (m.find("response-cache-control") != m.end()) {
      responseCacheControl = make_shared<string>(
          boost::any_cast<string>(m["response-cache-control"]));
    }
    if (m.find("response-content-disposition") != m.end()) {
      responseContentDisposition = make_shared<string>(
          boost::any_cast<string>(m["response-content-disposition"]));
    }
    if (m.find("response-content-encoding") != m.end()) {
      responseContentEncoding = make_shared<string>(
          boost::any_cast<string>(m["response-content-encoding"]));
    }
    if (m.find("Range") != m.end()) {
      range = make_shared<string>(boost::any_cast<string>(m["Range"]));
    }
    if (m.find("If-Modified-Since") != m.end()) {
      ifModifiedSince =
          make_shared<string>(boost::any_cast<string>(m["If-Modified-Since"]));
    }
    if (m.find("If-Unmodified-Since") != m.end()) {
      ifUnmodifiedSince = make_shared<string>(
          boost::any_cast<string>(m["If-Unmodified-Since"]));
    }
    if (m.find("If-Match") != m.end()) {
      ifMatch = make_shared<string>(boost::any_cast<string>(m["If-Match"]));
    }
    if (m.find("If-None-Match") != m.end()) {
      ifNoneMatch =
          make_shared<string>(boost::any_cast<string>(m["If-None-Match"]));
    }
    if (m.find("Accept-Encoding") != m.end()) {
      acceptEncoding =
          make_shared<string>(boost::any_cast<string>(m["Accept-Encoding"]));
    }
  }

  shared_ptr<string> responseContentType{};
  shared_ptr<string> responseContentLanguage{};
  shared_ptr<string> responseExpires{};
  shared_ptr<string> responseCacheControl{};
  shared_ptr<string> responseContentDisposition{};
  shared_ptr<string> responseContentEncoding{};
  shared_ptr<string> range{};
  shared_ptr<string> ifModifiedSince{};
  shared_ptr<string> ifUnmodifiedSince{};
  shared_ptr<string> ifMatch{};
  shared_ptr<string> ifNoneMatch{};
  shared_ptr<string> acceptEncoding{};

  ~GetObjectRequestHeader() = default;
};
class GetObjectRequest : public Darabonba::Model {
public:
  GetObjectRequest() {}
  explicit GetObjectRequest(const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!bucketName) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("bucketName is required.")));
    }
    Darabonba::Model::validatePattern("bucketName", bucketName,
                                      "[a-zA-Z0-9\\\\-\\\\_]+");
    if (!objectName) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("objectName is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (bucketName) {
      res["BucketName"] = boost::any(*bucketName);
    }
    if (objectName) {
      res["ObjectName"] = boost::any(*objectName);
    }
    if (header) {
      res["Header"] = header ? boost::any(header->toMap())
                             : boost::any(map<string, boost::any>({}));
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("BucketName") != m.end()) {
      bucketName =
          make_shared<string>(boost::any_cast<string>(m["BucketName"]));
    }
    if (m.find("ObjectName") != m.end()) {
      objectName =
          make_shared<string>(boost::any_cast<string>(m["ObjectName"]));
    }
    if (m.find("Header") != m.end()) {
      if (typeid(map<string, boost::any>).name() == m["Header"].type().name()) {
        GetObjectRequestHeader model1;
        model1.fromMap(boost::any_cast<map<string, boost::any>>(m["Header"]));
        header = make_shared<GetObjectRequestHeader>(model1);
      }
    }
  }

  shared_ptr<string> bucketName{};
  shared_ptr<string> objectName{};
  shared_ptr<GetObjectRequestHeader> header{};

  ~GetObjectRequest() = default;
};
class GetObjectResponse : public Darabonba::Model {
public:
  GetObjectResponse() {}
  explicit GetObjectResponse(const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!requestId) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("requestId is required.")));
    }
    if (!objectType) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("objectType is required.")));
    }
    if (!serverSideEncryption) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("serverSideEncryption is required.")));
    }
    if (!taggingCount) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("taggingCount is required.")));
    }
    if (!restore) {
      BOOST_THROW_EXCEPTION(
          boost::enable_error_info(std::runtime_error("restore is required.")));
    }
    if (!body) {
      BOOST_THROW_EXCEPTION(
          boost::enable_error_info(std::runtime_error("body is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (requestId) {
      res["x-oss-request-id"] = boost::any(*requestId);
    }
    if (objectType) {
      res["x-oss-object-type"] = boost::any(*objectType);
    }
    if (serverSideEncryption) {
      res["x-oss-server-side-encryption"] = boost::any(*serverSideEncryption);
    }
    if (taggingCount) {
      res["x-oss-tagging-count"] = boost::any(*taggingCount);
    }
    if (restore) {
      res["x-oss-restore"] = boost::any(*restore);
    }
    if (body) {
      res["body"] = boost::any(*body);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("x-oss-request-id") != m.end()) {
      requestId =
          make_shared<string>(boost::any_cast<string>(m["x-oss-request-id"]));
    }
    if (m.find("x-oss-object-type") != m.end()) {
      objectType =
          make_shared<string>(boost::any_cast<string>(m["x-oss-object-type"]));
    }
    if (m.find("x-oss-server-side-encryption") != m.end()) {
      serverSideEncryption = make_shared<string>(
          boost::any_cast<string>(m["x-oss-server-side-encryption"]));
    }
    if (m.find("x-oss-tagging-count") != m.end()) {
      taggingCount = make_shared<string>(
          boost::any_cast<string>(m["x-oss-tagging-count"]));
    }
    if (m.find("x-oss-restore") != m.end()) {
      restore =
          make_shared<string>(boost::any_cast<string>(m["x-oss-restore"]));
    }
    if (m.find("body") != m.end()) {
      body = make_shared<Darabonba::Stream>(
          boost::any_cast<Darabonba::Stream>(m["body"]));
    }
  }

  shared_ptr<string> requestId{};
  shared_ptr<string> objectType{};
  shared_ptr<string> serverSideEncryption{};
  shared_ptr<string> taggingCount{};
  shared_ptr<string> restore{};
  shared_ptr<Darabonba::Stream> body{};

  ~GetObjectResponse() = default;
};
class UploadPartRequestFilter : public Darabonba::Model {
public:
  UploadPartRequestFilter() {}
  explicit UploadPartRequestFilter(const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!partNumber) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("partNumber is required.")));
    }
    if (!uploadId) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("uploadId is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (partNumber) {
      res["partNumber"] = boost::any(*partNumber);
    }
    if (uploadId) {
      res["uploadId"] = boost::any(*uploadId);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("partNumber") != m.end()) {
      partNumber =
          make_shared<string>(boost::any_cast<string>(m["partNumber"]));
    }
    if (m.find("uploadId") != m.end()) {
      uploadId = make_shared<string>(boost::any_cast<string>(m["uploadId"]));
    }
  }

  shared_ptr<string> partNumber{};
  shared_ptr<string> uploadId{};

  ~UploadPartRequestFilter() = default;
};
class UploadPartRequest : public Darabonba::Model {
public:
  UploadPartRequest() {}
  explicit UploadPartRequest(const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!bucketName) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("bucketName is required.")));
    }
    Darabonba::Model::validatePattern("bucketName", bucketName,
                                      "[a-zA-Z0-9\\\\-\\\\_]+");
    if (!objectName) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("objectName is required.")));
    }
    if (!filter) {
      BOOST_THROW_EXCEPTION(
          boost::enable_error_info(std::runtime_error("filter is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (bucketName) {
      res["BucketName"] = boost::any(*bucketName);
    }
    if (objectName) {
      res["ObjectName"] = boost::any(*objectName);
    }
    if (body) {
      res["body"] = boost::any(*body);
    }
    if (filter) {
      res["Filter"] = filter ? boost::any(filter->toMap())
                             : boost::any(map<string, boost::any>({}));
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("BucketName") != m.end()) {
      bucketName =
          make_shared<string>(boost::any_cast<string>(m["BucketName"]));
    }
    if (m.find("ObjectName") != m.end()) {
      objectName =
          make_shared<string>(boost::any_cast<string>(m["ObjectName"]));
    }
    if (m.find("body") != m.end()) {
      body = make_shared<Darabonba::Stream>(
          boost::any_cast<Darabonba::Stream>(m["body"]));
    }
    if (m.find("Filter") != m.end()) {
      if (typeid(map<string, boost::any>).name() == m["Filter"].type().name()) {
        UploadPartRequestFilter model1;
        model1.fromMap(boost::any_cast<map<string, boost::any>>(m["Filter"]));
        filter = make_shared<UploadPartRequestFilter>(model1);
      }
    }
  }

  shared_ptr<string> bucketName{};
  shared_ptr<string> objectName{};
  shared_ptr<Darabonba::Stream> body{};
  shared_ptr<UploadPartRequestFilter> filter{};

  ~UploadPartRequest() = default;
};
class UploadPartResponse : public Darabonba::Model {
public:
  UploadPartResponse() {}
  explicit UploadPartResponse(const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!requestId) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("requestId is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (requestId) {
      res["x-oss-request-id"] = boost::any(*requestId);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("x-oss-request-id") != m.end()) {
      requestId =
          make_shared<string>(boost::any_cast<string>(m["x-oss-request-id"]));
    }
  }

  shared_ptr<string> requestId{};

  ~UploadPartResponse() = default;
};
class GetBucketCORSRequest : public Darabonba::Model {
public:
  GetBucketCORSRequest() {}
  explicit GetBucketCORSRequest(const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!bucketName) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("bucketName is required.")));
    }
    Darabonba::Model::validatePattern("bucketName", bucketName,
                                      "[a-zA-Z0-9\\\\-\\\\_]+");
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (bucketName) {
      res["BucketName"] = boost::any(*bucketName);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("BucketName") != m.end()) {
      bucketName =
          make_shared<string>(boost::any_cast<string>(m["BucketName"]));
    }
  }

  shared_ptr<string> bucketName{};

  ~GetBucketCORSRequest() = default;
};
class GetBucketCORSResponseCORSConfigurationCORSRule : public Darabonba::Model {
public:
  GetBucketCORSResponseCORSConfigurationCORSRule() {}
  explicit GetBucketCORSResponseCORSConfigurationCORSRule(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {}

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (maxAgeSeconds) {
      res["MaxAgeSeconds"] = boost::any(*maxAgeSeconds);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("MaxAgeSeconds") != m.end()) {
      maxAgeSeconds =
          make_shared<string>(boost::any_cast<string>(m["MaxAgeSeconds"]));
    }
  }

  shared_ptr<string> maxAgeSeconds{};

  ~GetBucketCORSResponseCORSConfigurationCORSRule() = default;
};
class GetBucketCORSResponseCORSConfiguration : public Darabonba::Model {
public:
  GetBucketCORSResponseCORSConfiguration() {}
  explicit GetBucketCORSResponseCORSConfiguration(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {}

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (cORSRule) {
      vector<boost::any> temp1;
      for (auto item1 : *cORSRule) {
        temp1.push_back(boost::any(item1.toMap()));
      }
      res["CORSRule"] = boost::any(temp1);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("CORSRule") != m.end()) {
      if (typeid(vector<boost::any>).name() == m["CORSRule"].type().name()) {
        vector<GetBucketCORSResponseCORSConfigurationCORSRule> expect1;
        for (auto item1 : boost::any_cast<vector<boost::any>>(m["CORSRule"])) {
          if (typeid(map<string, boost::any>).name() == item1.type().name()) {
            GetBucketCORSResponseCORSConfigurationCORSRule model2;
            model2.fromMap(boost::any_cast<map<string, boost::any>>(item1));
            expect1.push_back(model2);
          }
        }
        cORSRule =
            make_shared<vector<GetBucketCORSResponseCORSConfigurationCORSRule>>(
                expect1);
      }
    }
  }

  shared_ptr<vector<GetBucketCORSResponseCORSConfigurationCORSRule>> cORSRule{};

  ~GetBucketCORSResponseCORSConfiguration() = default;
};
class GetBucketCORSResponse : public Darabonba::Model {
public:
  GetBucketCORSResponse() {}
  explicit GetBucketCORSResponse(const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!requestId) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("requestId is required.")));
    }
    if (!cORSConfiguration) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("cORSConfiguration is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (requestId) {
      res["x-oss-request-id"] = boost::any(*requestId);
    }
    if (cORSConfiguration) {
      res["CORSConfiguration"] = cORSConfiguration
                                     ? boost::any(cORSConfiguration->toMap())
                                     : boost::any(map<string, boost::any>({}));
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("x-oss-request-id") != m.end()) {
      requestId =
          make_shared<string>(boost::any_cast<string>(m["x-oss-request-id"]));
    }
    if (m.find("CORSConfiguration") != m.end()) {
      if (typeid(map<string, boost::any>).name() ==
          m["CORSConfiguration"].type().name()) {
        GetBucketCORSResponseCORSConfiguration model1;
        model1.fromMap(
            boost::any_cast<map<string, boost::any>>(m["CORSConfiguration"]));
        cORSConfiguration =
            make_shared<GetBucketCORSResponseCORSConfiguration>(model1);
      }
    }
  }

  shared_ptr<string> requestId{};
  shared_ptr<GetBucketCORSResponseCORSConfiguration> cORSConfiguration{};

  ~GetBucketCORSResponse() = default;
};
class CopyObjectRequestHeader : public Darabonba::Model {
public:
  CopyObjectRequestHeader() {}
  explicit CopyObjectRequestHeader(const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!copySource) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("copySource is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (copySource) {
      res["x-oss-copy-source"] = boost::any(*copySource);
    }
    if (copySourceIfMatch) {
      res["x-oss-copy-source-if-match"] = boost::any(*copySourceIfMatch);
    }
    if (copySourceIfNoneMatch) {
      res["x-oss-copy-source-if-none-match"] =
          boost::any(*copySourceIfNoneMatch);
    }
    if (copySourceIfUnmodifiedSince) {
      res["x-oss-copy-source-if-unmodified-since"] =
          boost::any(*copySourceIfUnmodifiedSince);
    }
    if (copySourceIfModifiedSince) {
      res["x-oss-copy-source-if-modified-since"] =
          boost::any(*copySourceIfModifiedSince);
    }
    if (metadataDirective) {
      res["x-oss-metadata-directive"] = boost::any(*metadataDirective);
    }
    if (serverSideEncryption) {
      res["x-oss-server-side-encryption"] = boost::any(*serverSideEncryption);
    }
    if (serverSideEncryptionKeyId) {
      res["x-oss-server-side-encryption-key-id"] =
          boost::any(*serverSideEncryptionKeyId);
    }
    if (objectAcl) {
      res["x-oss-object-acl"] = boost::any(*objectAcl);
    }
    if (storageClass) {
      res["x-oss-storage-class"] = boost::any(*storageClass);
    }
    if (tagging) {
      res["x-oss-tagging"] = boost::any(*tagging);
    }
    if (taggingDirective) {
      res["x-oss-tagging-directive"] = boost::any(*taggingDirective);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("x-oss-copy-source") != m.end()) {
      copySource =
          make_shared<string>(boost::any_cast<string>(m["x-oss-copy-source"]));
    }
    if (m.find("x-oss-copy-source-if-match") != m.end()) {
      copySourceIfMatch = make_shared<string>(
          boost::any_cast<string>(m["x-oss-copy-source-if-match"]));
    }
    if (m.find("x-oss-copy-source-if-none-match") != m.end()) {
      copySourceIfNoneMatch = make_shared<string>(
          boost::any_cast<string>(m["x-oss-copy-source-if-none-match"]));
    }
    if (m.find("x-oss-copy-source-if-unmodified-since") != m.end()) {
      copySourceIfUnmodifiedSince = make_shared<string>(
          boost::any_cast<string>(m["x-oss-copy-source-if-unmodified-since"]));
    }
    if (m.find("x-oss-copy-source-if-modified-since") != m.end()) {
      copySourceIfModifiedSince = make_shared<string>(
          boost::any_cast<string>(m["x-oss-copy-source-if-modified-since"]));
    }
    if (m.find("x-oss-metadata-directive") != m.end()) {
      metadataDirective = make_shared<string>(
          boost::any_cast<string>(m["x-oss-metadata-directive"]));
    }
    if (m.find("x-oss-server-side-encryption") != m.end()) {
      serverSideEncryption = make_shared<string>(
          boost::any_cast<string>(m["x-oss-server-side-encryption"]));
    }
    if (m.find("x-oss-server-side-encryption-key-id") != m.end()) {
      serverSideEncryptionKeyId = make_shared<string>(
          boost::any_cast<string>(m["x-oss-server-side-encryption-key-id"]));
    }
    if (m.find("x-oss-object-acl") != m.end()) {
      objectAcl =
          make_shared<string>(boost::any_cast<string>(m["x-oss-object-acl"]));
    }
    if (m.find("x-oss-storage-class") != m.end()) {
      storageClass = make_shared<string>(
          boost::any_cast<string>(m["x-oss-storage-class"]));
    }
    if (m.find("x-oss-tagging") != m.end()) {
      tagging =
          make_shared<string>(boost::any_cast<string>(m["x-oss-tagging"]));
    }
    if (m.find("x-oss-tagging-directive") != m.end()) {
      taggingDirective = make_shared<string>(
          boost::any_cast<string>(m["x-oss-tagging-directive"]));
    }
  }

  shared_ptr<string> copySource{};
  shared_ptr<string> copySourceIfMatch{};
  shared_ptr<string> copySourceIfNoneMatch{};
  shared_ptr<string> copySourceIfUnmodifiedSince{};
  shared_ptr<string> copySourceIfModifiedSince{};
  shared_ptr<string> metadataDirective{};
  shared_ptr<string> serverSideEncryption{};
  shared_ptr<string> serverSideEncryptionKeyId{};
  shared_ptr<string> objectAcl{};
  shared_ptr<string> storageClass{};
  shared_ptr<string> tagging{};
  shared_ptr<string> taggingDirective{};

  ~CopyObjectRequestHeader() = default;
};
class CopyObjectRequest : public Darabonba::Model {
public:
  CopyObjectRequest() {}
  explicit CopyObjectRequest(const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!bucketName) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("bucketName is required.")));
    }
    Darabonba::Model::validatePattern("bucketName", bucketName,
                                      "[a-zA-Z0-9\\\\-\\\\_]+");
    if (!destObjectName) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("destObjectName is required.")));
    }
    if (!header) {
      BOOST_THROW_EXCEPTION(
          boost::enable_error_info(std::runtime_error("header is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (bucketName) {
      res["BucketName"] = boost::any(*bucketName);
    }
    if (destObjectName) {
      res["DestObjectName"] = boost::any(*destObjectName);
    }
    if (header) {
      res["Header"] = header ? boost::any(header->toMap())
                             : boost::any(map<string, boost::any>({}));
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("BucketName") != m.end()) {
      bucketName =
          make_shared<string>(boost::any_cast<string>(m["BucketName"]));
    }
    if (m.find("DestObjectName") != m.end()) {
      destObjectName =
          make_shared<string>(boost::any_cast<string>(m["DestObjectName"]));
    }
    if (m.find("Header") != m.end()) {
      if (typeid(map<string, boost::any>).name() == m["Header"].type().name()) {
        CopyObjectRequestHeader model1;
        model1.fromMap(boost::any_cast<map<string, boost::any>>(m["Header"]));
        header = make_shared<CopyObjectRequestHeader>(model1);
      }
    }
  }

  shared_ptr<string> bucketName{};
  shared_ptr<string> destObjectName{};
  shared_ptr<CopyObjectRequestHeader> header{};

  ~CopyObjectRequest() = default;
};
class CopyObjectResponseCopyObjectResult : public Darabonba::Model {
public:
  CopyObjectResponseCopyObjectResult() {}
  explicit CopyObjectResponseCopyObjectResult(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {}

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (lastModified) {
      res["LastModified"] = boost::any(*lastModified);
    }
    if (eTag) {
      res["ETag"] = boost::any(*eTag);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("LastModified") != m.end()) {
      lastModified =
          make_shared<string>(boost::any_cast<string>(m["LastModified"]));
    }
    if (m.find("ETag") != m.end()) {
      eTag = make_shared<string>(boost::any_cast<string>(m["ETag"]));
    }
  }

  shared_ptr<string> lastModified{};
  shared_ptr<string> eTag{};

  ~CopyObjectResponseCopyObjectResult() = default;
};
class CopyObjectResponse : public Darabonba::Model {
public:
  CopyObjectResponse() {}
  explicit CopyObjectResponse(const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!requestId) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("requestId is required.")));
    }
    if (!copyObjectResult) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("copyObjectResult is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (requestId) {
      res["x-oss-request-id"] = boost::any(*requestId);
    }
    if (copyObjectResult) {
      res["CopyObjectResult"] = copyObjectResult
                                    ? boost::any(copyObjectResult->toMap())
                                    : boost::any(map<string, boost::any>({}));
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("x-oss-request-id") != m.end()) {
      requestId =
          make_shared<string>(boost::any_cast<string>(m["x-oss-request-id"]));
    }
    if (m.find("CopyObjectResult") != m.end()) {
      if (typeid(map<string, boost::any>).name() ==
          m["CopyObjectResult"].type().name()) {
        CopyObjectResponseCopyObjectResult model1;
        model1.fromMap(
            boost::any_cast<map<string, boost::any>>(m["CopyObjectResult"]));
        copyObjectResult =
            make_shared<CopyObjectResponseCopyObjectResult>(model1);
      }
    }
  }

  shared_ptr<string> requestId{};
  shared_ptr<CopyObjectResponseCopyObjectResult> copyObjectResult{};

  ~CopyObjectResponse() = default;
};
class GetObjectTaggingRequest : public Darabonba::Model {
public:
  GetObjectTaggingRequest() {}
  explicit GetObjectTaggingRequest(const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!bucketName) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("bucketName is required.")));
    }
    Darabonba::Model::validatePattern("bucketName", bucketName,
                                      "[a-zA-Z0-9\\\\-\\\\_]+");
    if (!objectName) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("objectName is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (bucketName) {
      res["BucketName"] = boost::any(*bucketName);
    }
    if (objectName) {
      res["ObjectName"] = boost::any(*objectName);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("BucketName") != m.end()) {
      bucketName =
          make_shared<string>(boost::any_cast<string>(m["BucketName"]));
    }
    if (m.find("ObjectName") != m.end()) {
      objectName =
          make_shared<string>(boost::any_cast<string>(m["ObjectName"]));
    }
  }

  shared_ptr<string> bucketName{};
  shared_ptr<string> objectName{};

  ~GetObjectTaggingRequest() = default;
};
class GetObjectTaggingResponseTaggingTagSetTag : public Darabonba::Model {
public:
  GetObjectTaggingResponseTaggingTagSetTag() {}
  explicit GetObjectTaggingResponseTaggingTagSetTag(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {}

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (key) {
      res["Key"] = boost::any(*key);
    }
    if (value) {
      res["Value"] = boost::any(*value);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("Key") != m.end()) {
      key = make_shared<string>(boost::any_cast<string>(m["Key"]));
    }
    if (m.find("Value") != m.end()) {
      value = make_shared<string>(boost::any_cast<string>(m["Value"]));
    }
  }

  shared_ptr<string> key{};
  shared_ptr<string> value{};

  ~GetObjectTaggingResponseTaggingTagSetTag() = default;
};
class GetObjectTaggingResponseTaggingTagSet : public Darabonba::Model {
public:
  GetObjectTaggingResponseTaggingTagSet() {}
  explicit GetObjectTaggingResponseTaggingTagSet(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {}

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (tag) {
      vector<boost::any> temp1;
      for (auto item1 : *tag) {
        temp1.push_back(boost::any(item1.toMap()));
      }
      res["Tag"] = boost::any(temp1);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("Tag") != m.end()) {
      if (typeid(vector<boost::any>).name() == m["Tag"].type().name()) {
        vector<GetObjectTaggingResponseTaggingTagSetTag> expect1;
        for (auto item1 : boost::any_cast<vector<boost::any>>(m["Tag"])) {
          if (typeid(map<string, boost::any>).name() == item1.type().name()) {
            GetObjectTaggingResponseTaggingTagSetTag model2;
            model2.fromMap(boost::any_cast<map<string, boost::any>>(item1));
            expect1.push_back(model2);
          }
        }
        tag = make_shared<vector<GetObjectTaggingResponseTaggingTagSetTag>>(
            expect1);
      }
    }
  }

  shared_ptr<vector<GetObjectTaggingResponseTaggingTagSetTag>> tag{};

  ~GetObjectTaggingResponseTaggingTagSet() = default;
};
class GetObjectTaggingResponseTagging : public Darabonba::Model {
public:
  GetObjectTaggingResponseTagging() {}
  explicit GetObjectTaggingResponseTagging(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!tagSet) {
      BOOST_THROW_EXCEPTION(
          boost::enable_error_info(std::runtime_error("tagSet is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (tagSet) {
      res["TagSet"] = tagSet ? boost::any(tagSet->toMap())
                             : boost::any(map<string, boost::any>({}));
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("TagSet") != m.end()) {
      if (typeid(map<string, boost::any>).name() == m["TagSet"].type().name()) {
        GetObjectTaggingResponseTaggingTagSet model1;
        model1.fromMap(boost::any_cast<map<string, boost::any>>(m["TagSet"]));
        tagSet = make_shared<GetObjectTaggingResponseTaggingTagSet>(model1);
      }
    }
  }

  shared_ptr<GetObjectTaggingResponseTaggingTagSet> tagSet{};

  ~GetObjectTaggingResponseTagging() = default;
};
class GetObjectTaggingResponse : public Darabonba::Model {
public:
  GetObjectTaggingResponse() {}
  explicit GetObjectTaggingResponse(const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!requestId) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("requestId is required.")));
    }
    if (!tagging) {
      BOOST_THROW_EXCEPTION(
          boost::enable_error_info(std::runtime_error("tagging is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (requestId) {
      res["x-oss-request-id"] = boost::any(*requestId);
    }
    if (tagging) {
      res["Tagging"] = tagging ? boost::any(tagging->toMap())
                               : boost::any(map<string, boost::any>({}));
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("x-oss-request-id") != m.end()) {
      requestId =
          make_shared<string>(boost::any_cast<string>(m["x-oss-request-id"]));
    }
    if (m.find("Tagging") != m.end()) {
      if (typeid(map<string, boost::any>).name() ==
          m["Tagging"].type().name()) {
        GetObjectTaggingResponseTagging model1;
        model1.fromMap(boost::any_cast<map<string, boost::any>>(m["Tagging"]));
        tagging = make_shared<GetObjectTaggingResponseTagging>(model1);
      }
    }
  }

  shared_ptr<string> requestId{};
  shared_ptr<GetObjectTaggingResponseTagging> tagging{};

  ~GetObjectTaggingResponse() = default;
};
class DeleteBucketLifecycleRequest : public Darabonba::Model {
public:
  DeleteBucketLifecycleRequest() {}
  explicit DeleteBucketLifecycleRequest(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!bucketName) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("bucketName is required.")));
    }
    Darabonba::Model::validatePattern("bucketName", bucketName,
                                      "[a-zA-Z0-9\\\\-\\\\_]+");
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (bucketName) {
      res["BucketName"] = boost::any(*bucketName);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("BucketName") != m.end()) {
      bucketName =
          make_shared<string>(boost::any_cast<string>(m["BucketName"]));
    }
  }

  shared_ptr<string> bucketName{};

  ~DeleteBucketLifecycleRequest() = default;
};
class DeleteBucketLifecycleResponse : public Darabonba::Model {
public:
  DeleteBucketLifecycleResponse() {}
  explicit DeleteBucketLifecycleResponse(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!requestId) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("requestId is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (requestId) {
      res["x-oss-request-id"] = boost::any(*requestId);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("x-oss-request-id") != m.end()) {
      requestId =
          make_shared<string>(boost::any_cast<string>(m["x-oss-request-id"]));
    }
  }

  shared_ptr<string> requestId{};

  ~DeleteBucketLifecycleResponse() = default;
};
class DeleteBucketLoggingRequest : public Darabonba::Model {
public:
  DeleteBucketLoggingRequest() {}
  explicit DeleteBucketLoggingRequest(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!bucketName) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("bucketName is required.")));
    }
    Darabonba::Model::validatePattern("bucketName", bucketName,
                                      "[a-zA-Z0-9\\\\-\\\\_]+");
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (bucketName) {
      res["BucketName"] = boost::any(*bucketName);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("BucketName") != m.end()) {
      bucketName =
          make_shared<string>(boost::any_cast<string>(m["BucketName"]));
    }
  }

  shared_ptr<string> bucketName{};

  ~DeleteBucketLoggingRequest() = default;
};
class DeleteBucketLoggingResponse : public Darabonba::Model {
public:
  DeleteBucketLoggingResponse() {}
  explicit DeleteBucketLoggingResponse(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!requestId) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("requestId is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (requestId) {
      res["x-oss-request-id"] = boost::any(*requestId);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("x-oss-request-id") != m.end()) {
      requestId =
          make_shared<string>(boost::any_cast<string>(m["x-oss-request-id"]));
    }
  }

  shared_ptr<string> requestId{};

  ~DeleteBucketLoggingResponse() = default;
};
class DeleteBucketWebsiteRequest : public Darabonba::Model {
public:
  DeleteBucketWebsiteRequest() {}
  explicit DeleteBucketWebsiteRequest(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!bucketName) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("bucketName is required.")));
    }
    Darabonba::Model::validatePattern("bucketName", bucketName,
                                      "[a-zA-Z0-9\\\\-\\\\_]+");
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (bucketName) {
      res["BucketName"] = boost::any(*bucketName);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("BucketName") != m.end()) {
      bucketName =
          make_shared<string>(boost::any_cast<string>(m["BucketName"]));
    }
  }

  shared_ptr<string> bucketName{};

  ~DeleteBucketWebsiteRequest() = default;
};
class DeleteBucketWebsiteResponse : public Darabonba::Model {
public:
  DeleteBucketWebsiteResponse() {}
  explicit DeleteBucketWebsiteResponse(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!requestId) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("requestId is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (requestId) {
      res["x-oss-request-id"] = boost::any(*requestId);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("x-oss-request-id") != m.end()) {
      requestId =
          make_shared<string>(boost::any_cast<string>(m["x-oss-request-id"]));
    }
  }

  shared_ptr<string> requestId{};

  ~DeleteBucketWebsiteResponse() = default;
};
class GetSymlinkRequest : public Darabonba::Model {
public:
  GetSymlinkRequest() {}
  explicit GetSymlinkRequest(const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!bucketName) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("bucketName is required.")));
    }
    Darabonba::Model::validatePattern("bucketName", bucketName,
                                      "[a-zA-Z0-9\\\\-\\\\_]+");
    if (!objectName) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("objectName is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (bucketName) {
      res["BucketName"] = boost::any(*bucketName);
    }
    if (objectName) {
      res["ObjectName"] = boost::any(*objectName);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("BucketName") != m.end()) {
      bucketName =
          make_shared<string>(boost::any_cast<string>(m["BucketName"]));
    }
    if (m.find("ObjectName") != m.end()) {
      objectName =
          make_shared<string>(boost::any_cast<string>(m["ObjectName"]));
    }
  }

  shared_ptr<string> bucketName{};
  shared_ptr<string> objectName{};

  ~GetSymlinkRequest() = default;
};
class GetSymlinkResponse : public Darabonba::Model {
public:
  GetSymlinkResponse() {}
  explicit GetSymlinkResponse(const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!requestId) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("requestId is required.")));
    }
    if (!symlinkTarget) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("symlinkTarget is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (requestId) {
      res["x-oss-request-id"] = boost::any(*requestId);
    }
    if (symlinkTarget) {
      res["x-oss-symlink-target"] = boost::any(*symlinkTarget);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("x-oss-request-id") != m.end()) {
      requestId =
          make_shared<string>(boost::any_cast<string>(m["x-oss-request-id"]));
    }
    if (m.find("x-oss-symlink-target") != m.end()) {
      symlinkTarget = make_shared<string>(
          boost::any_cast<string>(m["x-oss-symlink-target"]));
    }
  }

  shared_ptr<string> requestId{};
  shared_ptr<string> symlinkTarget{};

  ~GetSymlinkResponse() = default;
};
class GetBucketLifecycleRequest : public Darabonba::Model {
public:
  GetBucketLifecycleRequest() {}
  explicit GetBucketLifecycleRequest(const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!bucketName) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("bucketName is required.")));
    }
    Darabonba::Model::validatePattern("bucketName", bucketName,
                                      "[a-zA-Z0-9\\\\-\\\\_]+");
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (bucketName) {
      res["BucketName"] = boost::any(*bucketName);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("BucketName") != m.end()) {
      bucketName =
          make_shared<string>(boost::any_cast<string>(m["BucketName"]));
    }
  }

  shared_ptr<string> bucketName{};

  ~GetBucketLifecycleRequest() = default;
};
class GetBucketLifecycleResponseLifecycleConfigurationRuleExpiration
    : public Darabonba::Model {
public:
  GetBucketLifecycleResponseLifecycleConfigurationRuleExpiration() {}
  explicit GetBucketLifecycleResponseLifecycleConfigurationRuleExpiration(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {}

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (days) {
      res["Days"] = boost::any(*days);
    }
    if (createdBeforeDate) {
      res["CreatedBeforeDate"] = boost::any(*createdBeforeDate);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("Days") != m.end()) {
      days = make_shared<int>(boost::any_cast<int>(m["Days"]));
    }
    if (m.find("CreatedBeforeDate") != m.end()) {
      createdBeforeDate =
          make_shared<string>(boost::any_cast<string>(m["CreatedBeforeDate"]));
    }
  }

  shared_ptr<int> days{};
  shared_ptr<string> createdBeforeDate{};

  ~GetBucketLifecycleResponseLifecycleConfigurationRuleExpiration() = default;
};
class GetBucketLifecycleResponseLifecycleConfigurationRuleTransition
    : public Darabonba::Model {
public:
  GetBucketLifecycleResponseLifecycleConfigurationRuleTransition() {}
  explicit GetBucketLifecycleResponseLifecycleConfigurationRuleTransition(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {}

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (days) {
      res["Days"] = boost::any(*days);
    }
    if (storageClass) {
      res["StorageClass"] = boost::any(*storageClass);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("Days") != m.end()) {
      days = make_shared<int>(boost::any_cast<int>(m["Days"]));
    }
    if (m.find("StorageClass") != m.end()) {
      storageClass =
          make_shared<string>(boost::any_cast<string>(m["StorageClass"]));
    }
  }

  shared_ptr<int> days{};
  shared_ptr<string> storageClass{};

  ~GetBucketLifecycleResponseLifecycleConfigurationRuleTransition() = default;
};
class GetBucketLifecycleResponseLifecycleConfigurationRuleAbortMultipartUpload
    : public Darabonba::Model {
public:
  GetBucketLifecycleResponseLifecycleConfigurationRuleAbortMultipartUpload() {}
  explicit GetBucketLifecycleResponseLifecycleConfigurationRuleAbortMultipartUpload(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {}

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (days) {
      res["Days"] = boost::any(*days);
    }
    if (createdBeforeDate) {
      res["CreatedBeforeDate"] = boost::any(*createdBeforeDate);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("Days") != m.end()) {
      days = make_shared<int>(boost::any_cast<int>(m["Days"]));
    }
    if (m.find("CreatedBeforeDate") != m.end()) {
      createdBeforeDate =
          make_shared<string>(boost::any_cast<string>(m["CreatedBeforeDate"]));
    }
  }

  shared_ptr<int> days{};
  shared_ptr<string> createdBeforeDate{};

  ~GetBucketLifecycleResponseLifecycleConfigurationRuleAbortMultipartUpload() =
      default;
};
class GetBucketLifecycleResponseLifecycleConfigurationRuleTag
    : public Darabonba::Model {
public:
  GetBucketLifecycleResponseLifecycleConfigurationRuleTag() {}
  explicit GetBucketLifecycleResponseLifecycleConfigurationRuleTag(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {}

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (key) {
      res["Key"] = boost::any(*key);
    }
    if (value) {
      res["Value"] = boost::any(*value);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("Key") != m.end()) {
      key = make_shared<string>(boost::any_cast<string>(m["Key"]));
    }
    if (m.find("Value") != m.end()) {
      value = make_shared<string>(boost::any_cast<string>(m["Value"]));
    }
  }

  shared_ptr<string> key{};
  shared_ptr<string> value{};

  ~GetBucketLifecycleResponseLifecycleConfigurationRuleTag() = default;
};
class GetBucketLifecycleResponseLifecycleConfigurationRule
    : public Darabonba::Model {
public:
  GetBucketLifecycleResponseLifecycleConfigurationRule() {}
  explicit GetBucketLifecycleResponseLifecycleConfigurationRule(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!expiration) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("expiration is required.")));
    }
    if (!transition) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("transition is required.")));
    }
    if (!abortMultipartUpload) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("abortMultipartUpload is required.")));
    }
    if (!tag) {
      BOOST_THROW_EXCEPTION(
          boost::enable_error_info(std::runtime_error("tag is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (iD) {
      res["ID"] = boost::any(*iD);
    }
    if (prefix) {
      res["Prefix"] = boost::any(*prefix);
    }
    if (status) {
      res["Status"] = boost::any(*status);
    }
    if (expiration) {
      res["Expiration"] = expiration ? boost::any(expiration->toMap())
                                     : boost::any(map<string, boost::any>({}));
    }
    if (transition) {
      res["Transition"] = transition ? boost::any(transition->toMap())
                                     : boost::any(map<string, boost::any>({}));
    }
    if (abortMultipartUpload) {
      res["AbortMultipartUpload"] =
          abortMultipartUpload ? boost::any(abortMultipartUpload->toMap())
                               : boost::any(map<string, boost::any>({}));
    }
    if (tag) {
      res["Tag"] = tag ? boost::any(tag->toMap())
                       : boost::any(map<string, boost::any>({}));
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("ID") != m.end()) {
      iD = make_shared<string>(boost::any_cast<string>(m["ID"]));
    }
    if (m.find("Prefix") != m.end()) {
      prefix = make_shared<string>(boost::any_cast<string>(m["Prefix"]));
    }
    if (m.find("Status") != m.end()) {
      status = make_shared<string>(boost::any_cast<string>(m["Status"]));
    }
    if (m.find("Expiration") != m.end()) {
      if (typeid(map<string, boost::any>).name() ==
          m["Expiration"].type().name()) {
        GetBucketLifecycleResponseLifecycleConfigurationRuleExpiration model1;
        model1.fromMap(
            boost::any_cast<map<string, boost::any>>(m["Expiration"]));
        expiration = make_shared<
            GetBucketLifecycleResponseLifecycleConfigurationRuleExpiration>(
            model1);
      }
    }
    if (m.find("Transition") != m.end()) {
      if (typeid(map<string, boost::any>).name() ==
          m["Transition"].type().name()) {
        GetBucketLifecycleResponseLifecycleConfigurationRuleTransition model1;
        model1.fromMap(
            boost::any_cast<map<string, boost::any>>(m["Transition"]));
        transition = make_shared<
            GetBucketLifecycleResponseLifecycleConfigurationRuleTransition>(
            model1);
      }
    }
    if (m.find("AbortMultipartUpload") != m.end()) {
      if (typeid(map<string, boost::any>).name() ==
          m["AbortMultipartUpload"].type().name()) {
        GetBucketLifecycleResponseLifecycleConfigurationRuleAbortMultipartUpload
            model1;
        model1.fromMap(boost::any_cast<map<string, boost::any>>(
            m["AbortMultipartUpload"]));
        abortMultipartUpload = make_shared<
            GetBucketLifecycleResponseLifecycleConfigurationRuleAbortMultipartUpload>(
            model1);
      }
    }
    if (m.find("Tag") != m.end()) {
      if (typeid(map<string, boost::any>).name() == m["Tag"].type().name()) {
        GetBucketLifecycleResponseLifecycleConfigurationRuleTag model1;
        model1.fromMap(boost::any_cast<map<string, boost::any>>(m["Tag"]));
        tag = make_shared<
            GetBucketLifecycleResponseLifecycleConfigurationRuleTag>(model1);
      }
    }
  }

  shared_ptr<string> iD{};
  shared_ptr<string> prefix{};
  shared_ptr<string> status{};
  shared_ptr<GetBucketLifecycleResponseLifecycleConfigurationRuleExpiration>
      expiration{};
  shared_ptr<GetBucketLifecycleResponseLifecycleConfigurationRuleTransition>
      transition{};
  shared_ptr<
      GetBucketLifecycleResponseLifecycleConfigurationRuleAbortMultipartUpload>
      abortMultipartUpload{};
  shared_ptr<GetBucketLifecycleResponseLifecycleConfigurationRuleTag> tag{};

  ~GetBucketLifecycleResponseLifecycleConfigurationRule() = default;
};
class GetBucketLifecycleResponseLifecycleConfiguration
    : public Darabonba::Model {
public:
  GetBucketLifecycleResponseLifecycleConfiguration() {}
  explicit GetBucketLifecycleResponseLifecycleConfiguration(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {}

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (rule) {
      vector<boost::any> temp1;
      for (auto item1 : *rule) {
        temp1.push_back(boost::any(item1.toMap()));
      }
      res["Rule"] = boost::any(temp1);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("Rule") != m.end()) {
      if (typeid(vector<boost::any>).name() == m["Rule"].type().name()) {
        vector<GetBucketLifecycleResponseLifecycleConfigurationRule> expect1;
        for (auto item1 : boost::any_cast<vector<boost::any>>(m["Rule"])) {
          if (typeid(map<string, boost::any>).name() == item1.type().name()) {
            GetBucketLifecycleResponseLifecycleConfigurationRule model2;
            model2.fromMap(boost::any_cast<map<string, boost::any>>(item1));
            expect1.push_back(model2);
          }
        }
        rule = make_shared<
            vector<GetBucketLifecycleResponseLifecycleConfigurationRule>>(
            expect1);
      }
    }
  }

  shared_ptr<vector<GetBucketLifecycleResponseLifecycleConfigurationRule>>
      rule{};

  ~GetBucketLifecycleResponseLifecycleConfiguration() = default;
};
class GetBucketLifecycleResponse : public Darabonba::Model {
public:
  GetBucketLifecycleResponse() {}
  explicit GetBucketLifecycleResponse(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!requestId) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("requestId is required.")));
    }
    if (!lifecycleConfiguration) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("lifecycleConfiguration is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (requestId) {
      res["x-oss-request-id"] = boost::any(*requestId);
    }
    if (lifecycleConfiguration) {
      res["LifecycleConfiguration"] =
          lifecycleConfiguration ? boost::any(lifecycleConfiguration->toMap())
                                 : boost::any(map<string, boost::any>({}));
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("x-oss-request-id") != m.end()) {
      requestId =
          make_shared<string>(boost::any_cast<string>(m["x-oss-request-id"]));
    }
    if (m.find("LifecycleConfiguration") != m.end()) {
      if (typeid(map<string, boost::any>).name() ==
          m["LifecycleConfiguration"].type().name()) {
        GetBucketLifecycleResponseLifecycleConfiguration model1;
        model1.fromMap(boost::any_cast<map<string, boost::any>>(
            m["LifecycleConfiguration"]));
        lifecycleConfiguration =
            make_shared<GetBucketLifecycleResponseLifecycleConfiguration>(
                model1);
      }
    }
  }

  shared_ptr<string> requestId{};
  shared_ptr<GetBucketLifecycleResponseLifecycleConfiguration>
      lifecycleConfiguration{};

  ~GetBucketLifecycleResponse() = default;
};
class PutSymlinkRequestHeader : public Darabonba::Model {
public:
  PutSymlinkRequestHeader() {}
  explicit PutSymlinkRequestHeader(const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!symlinkTarget) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("symlinkTarget is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (symlinkTarget) {
      res["x-oss-symlink-target"] = boost::any(*symlinkTarget);
    }
    if (storageClass) {
      res["x-oss-storage-class"] = boost::any(*storageClass);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("x-oss-symlink-target") != m.end()) {
      symlinkTarget = make_shared<string>(
          boost::any_cast<string>(m["x-oss-symlink-target"]));
    }
    if (m.find("x-oss-storage-class") != m.end()) {
      storageClass = make_shared<string>(
          boost::any_cast<string>(m["x-oss-storage-class"]));
    }
  }

  shared_ptr<string> symlinkTarget{};
  shared_ptr<string> storageClass{};

  ~PutSymlinkRequestHeader() = default;
};
class PutSymlinkRequest : public Darabonba::Model {
public:
  PutSymlinkRequest() {}
  explicit PutSymlinkRequest(const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!bucketName) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("bucketName is required.")));
    }
    Darabonba::Model::validatePattern("bucketName", bucketName,
                                      "[a-zA-Z0-9\\\\-\\\\_]+");
    if (!objectName) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("objectName is required.")));
    }
    if (!header) {
      BOOST_THROW_EXCEPTION(
          boost::enable_error_info(std::runtime_error("header is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (bucketName) {
      res["BucketName"] = boost::any(*bucketName);
    }
    if (objectName) {
      res["ObjectName"] = boost::any(*objectName);
    }
    if (header) {
      res["Header"] = header ? boost::any(header->toMap())
                             : boost::any(map<string, boost::any>({}));
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("BucketName") != m.end()) {
      bucketName =
          make_shared<string>(boost::any_cast<string>(m["BucketName"]));
    }
    if (m.find("ObjectName") != m.end()) {
      objectName =
          make_shared<string>(boost::any_cast<string>(m["ObjectName"]));
    }
    if (m.find("Header") != m.end()) {
      if (typeid(map<string, boost::any>).name() == m["Header"].type().name()) {
        PutSymlinkRequestHeader model1;
        model1.fromMap(boost::any_cast<map<string, boost::any>>(m["Header"]));
        header = make_shared<PutSymlinkRequestHeader>(model1);
      }
    }
  }

  shared_ptr<string> bucketName{};
  shared_ptr<string> objectName{};
  shared_ptr<PutSymlinkRequestHeader> header{};

  ~PutSymlinkRequest() = default;
};
class PutSymlinkResponse : public Darabonba::Model {
public:
  PutSymlinkResponse() {}
  explicit PutSymlinkResponse(const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!requestId) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("requestId is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (requestId) {
      res["x-oss-request-id"] = boost::any(*requestId);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("x-oss-request-id") != m.end()) {
      requestId =
          make_shared<string>(boost::any_cast<string>(m["x-oss-request-id"]));
    }
  }

  shared_ptr<string> requestId{};

  ~PutSymlinkResponse() = default;
};
class GetBucketRefererRequest : public Darabonba::Model {
public:
  GetBucketRefererRequest() {}
  explicit GetBucketRefererRequest(const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!bucketName) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("bucketName is required.")));
    }
    Darabonba::Model::validatePattern("bucketName", bucketName,
                                      "[a-zA-Z0-9\\\\-\\\\_]+");
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (bucketName) {
      res["BucketName"] = boost::any(*bucketName);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("BucketName") != m.end()) {
      bucketName =
          make_shared<string>(boost::any_cast<string>(m["BucketName"]));
    }
  }

  shared_ptr<string> bucketName{};

  ~GetBucketRefererRequest() = default;
};
class GetBucketRefererResponseRefererConfigurationRefererList
    : public Darabonba::Model {
public:
  GetBucketRefererResponseRefererConfigurationRefererList() {}
  explicit GetBucketRefererResponseRefererConfigurationRefererList(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {}

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (referer) {
      res["Referer"] = boost::any(*referer);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("Referer") != m.end()) {
      vector<string> toVec1;
      if (typeid(vector<boost::any>).name() == m["Referer"].type().name()) {
        vector<boost::any> vec1 =
            boost::any_cast<vector<boost::any>>(m["Referer"]);
        for (auto item : vec1) {
          toVec1.push_back(boost::any_cast<string>(item));
        }
      }
      referer = make_shared<vector<string>>(toVec1);
    }
  }

  shared_ptr<vector<string>> referer{};

  ~GetBucketRefererResponseRefererConfigurationRefererList() = default;
};
class GetBucketRefererResponseRefererConfiguration : public Darabonba::Model {
public:
  GetBucketRefererResponseRefererConfiguration() {}
  explicit GetBucketRefererResponseRefererConfiguration(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!refererList) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("refererList is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (allowEmptyReferer) {
      res["AllowEmptyReferer"] = boost::any(*allowEmptyReferer);
    }
    if (refererList) {
      res["RefererList"] = refererList
                               ? boost::any(refererList->toMap())
                               : boost::any(map<string, boost::any>({}));
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("AllowEmptyReferer") != m.end()) {
      allowEmptyReferer =
          make_shared<bool>(boost::any_cast<bool>(m["AllowEmptyReferer"]));
    }
    if (m.find("RefererList") != m.end()) {
      if (typeid(map<string, boost::any>).name() ==
          m["RefererList"].type().name()) {
        GetBucketRefererResponseRefererConfigurationRefererList model1;
        model1.fromMap(
            boost::any_cast<map<string, boost::any>>(m["RefererList"]));
        refererList = make_shared<
            GetBucketRefererResponseRefererConfigurationRefererList>(model1);
      }
    }
  }

  shared_ptr<bool> allowEmptyReferer{};
  shared_ptr<GetBucketRefererResponseRefererConfigurationRefererList>
      refererList{};

  ~GetBucketRefererResponseRefererConfiguration() = default;
};
class GetBucketRefererResponse : public Darabonba::Model {
public:
  GetBucketRefererResponse() {}
  explicit GetBucketRefererResponse(const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!requestId) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("requestId is required.")));
    }
    if (!refererConfiguration) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("refererConfiguration is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (requestId) {
      res["x-oss-request-id"] = boost::any(*requestId);
    }
    if (refererConfiguration) {
      res["RefererConfiguration"] =
          refererConfiguration ? boost::any(refererConfiguration->toMap())
                               : boost::any(map<string, boost::any>({}));
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("x-oss-request-id") != m.end()) {
      requestId =
          make_shared<string>(boost::any_cast<string>(m["x-oss-request-id"]));
    }
    if (m.find("RefererConfiguration") != m.end()) {
      if (typeid(map<string, boost::any>).name() ==
          m["RefererConfiguration"].type().name()) {
        GetBucketRefererResponseRefererConfiguration model1;
        model1.fromMap(boost::any_cast<map<string, boost::any>>(
            m["RefererConfiguration"]));
        refererConfiguration =
            make_shared<GetBucketRefererResponseRefererConfiguration>(model1);
      }
    }
  }

  shared_ptr<string> requestId{};
  shared_ptr<GetBucketRefererResponseRefererConfiguration>
      refererConfiguration{};

  ~GetBucketRefererResponse() = default;
};
class CallbackRequest : public Darabonba::Model {
public:
  CallbackRequest() {}
  explicit CallbackRequest(const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!bucketName) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("bucketName is required.")));
    }
    Darabonba::Model::validatePattern("bucketName", bucketName,
                                      "[a-zA-Z0-9\\\\-\\\\_]+");
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (bucketName) {
      res["BucketName"] = boost::any(*bucketName);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("BucketName") != m.end()) {
      bucketName =
          make_shared<string>(boost::any_cast<string>(m["BucketName"]));
    }
  }

  shared_ptr<string> bucketName{};

  ~CallbackRequest() = default;
};
class CallbackResponse : public Darabonba::Model {
public:
  CallbackResponse() {}
  explicit CallbackResponse(const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!requestId) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("requestId is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (requestId) {
      res["x-oss-request-id"] = boost::any(*requestId);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("x-oss-request-id") != m.end()) {
      requestId =
          make_shared<string>(boost::any_cast<string>(m["x-oss-request-id"]));
    }
  }

  shared_ptr<string> requestId{};

  ~CallbackResponse() = default;
};
class GetBucketLoggingRequest : public Darabonba::Model {
public:
  GetBucketLoggingRequest() {}
  explicit GetBucketLoggingRequest(const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!bucketName) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("bucketName is required.")));
    }
    Darabonba::Model::validatePattern("bucketName", bucketName,
                                      "[a-zA-Z0-9\\\\-\\\\_]+");
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (bucketName) {
      res["BucketName"] = boost::any(*bucketName);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("BucketName") != m.end()) {
      bucketName =
          make_shared<string>(boost::any_cast<string>(m["BucketName"]));
    }
  }

  shared_ptr<string> bucketName{};

  ~GetBucketLoggingRequest() = default;
};
class GetBucketLoggingResponseBucketLoggingStatusLoggingEnabled
    : public Darabonba::Model {
public:
  GetBucketLoggingResponseBucketLoggingStatusLoggingEnabled() {}
  explicit GetBucketLoggingResponseBucketLoggingStatusLoggingEnabled(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {}

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (targetBucket) {
      res["TargetBucket"] = boost::any(*targetBucket);
    }
    if (targetPrefix) {
      res["TargetPrefix"] = boost::any(*targetPrefix);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("TargetBucket") != m.end()) {
      targetBucket =
          make_shared<string>(boost::any_cast<string>(m["TargetBucket"]));
    }
    if (m.find("TargetPrefix") != m.end()) {
      targetPrefix =
          make_shared<string>(boost::any_cast<string>(m["TargetPrefix"]));
    }
  }

  shared_ptr<string> targetBucket{};
  shared_ptr<string> targetPrefix{};

  ~GetBucketLoggingResponseBucketLoggingStatusLoggingEnabled() = default;
};
class GetBucketLoggingResponseBucketLoggingStatus : public Darabonba::Model {
public:
  GetBucketLoggingResponseBucketLoggingStatus() {}
  explicit GetBucketLoggingResponseBucketLoggingStatus(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!loggingEnabled) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("loggingEnabled is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (loggingEnabled) {
      res["LoggingEnabled"] = loggingEnabled
                                  ? boost::any(loggingEnabled->toMap())
                                  : boost::any(map<string, boost::any>({}));
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("LoggingEnabled") != m.end()) {
      if (typeid(map<string, boost::any>).name() ==
          m["LoggingEnabled"].type().name()) {
        GetBucketLoggingResponseBucketLoggingStatusLoggingEnabled model1;
        model1.fromMap(
            boost::any_cast<map<string, boost::any>>(m["LoggingEnabled"]));
        loggingEnabled = make_shared<
            GetBucketLoggingResponseBucketLoggingStatusLoggingEnabled>(model1);
      }
    }
  }

  shared_ptr<GetBucketLoggingResponseBucketLoggingStatusLoggingEnabled>
      loggingEnabled{};

  ~GetBucketLoggingResponseBucketLoggingStatus() = default;
};
class GetBucketLoggingResponse : public Darabonba::Model {
public:
  GetBucketLoggingResponse() {}
  explicit GetBucketLoggingResponse(const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!requestId) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("requestId is required.")));
    }
    if (!bucketLoggingStatus) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("bucketLoggingStatus is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (requestId) {
      res["x-oss-request-id"] = boost::any(*requestId);
    }
    if (bucketLoggingStatus) {
      res["BucketLoggingStatus"] =
          bucketLoggingStatus ? boost::any(bucketLoggingStatus->toMap())
                              : boost::any(map<string, boost::any>({}));
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("x-oss-request-id") != m.end()) {
      requestId =
          make_shared<string>(boost::any_cast<string>(m["x-oss-request-id"]));
    }
    if (m.find("BucketLoggingStatus") != m.end()) {
      if (typeid(map<string, boost::any>).name() ==
          m["BucketLoggingStatus"].type().name()) {
        GetBucketLoggingResponseBucketLoggingStatus model1;
        model1.fromMap(
            boost::any_cast<map<string, boost::any>>(m["BucketLoggingStatus"]));
        bucketLoggingStatus =
            make_shared<GetBucketLoggingResponseBucketLoggingStatus>(model1);
      }
    }
  }

  shared_ptr<string> requestId{};
  shared_ptr<GetBucketLoggingResponseBucketLoggingStatus> bucketLoggingStatus{};

  ~GetBucketLoggingResponse() = default;
};
class PutObjectAclRequestHeader : public Darabonba::Model {
public:
  PutObjectAclRequestHeader() {}
  explicit PutObjectAclRequestHeader(const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!objectAcl) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("objectAcl is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (objectAcl) {
      res["x-oss-object-acl"] = boost::any(*objectAcl);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("x-oss-object-acl") != m.end()) {
      objectAcl =
          make_shared<string>(boost::any_cast<string>(m["x-oss-object-acl"]));
    }
  }

  shared_ptr<string> objectAcl{};

  ~PutObjectAclRequestHeader() = default;
};
class PutObjectAclRequest : public Darabonba::Model {
public:
  PutObjectAclRequest() {}
  explicit PutObjectAclRequest(const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!bucketName) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("bucketName is required.")));
    }
    Darabonba::Model::validatePattern("bucketName", bucketName,
                                      "[a-zA-Z0-9\\\\-\\\\_]+");
    if (!objectName) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("objectName is required.")));
    }
    if (!header) {
      BOOST_THROW_EXCEPTION(
          boost::enable_error_info(std::runtime_error("header is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (bucketName) {
      res["BucketName"] = boost::any(*bucketName);
    }
    if (objectName) {
      res["ObjectName"] = boost::any(*objectName);
    }
    if (header) {
      res["Header"] = header ? boost::any(header->toMap())
                             : boost::any(map<string, boost::any>({}));
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("BucketName") != m.end()) {
      bucketName =
          make_shared<string>(boost::any_cast<string>(m["BucketName"]));
    }
    if (m.find("ObjectName") != m.end()) {
      objectName =
          make_shared<string>(boost::any_cast<string>(m["ObjectName"]));
    }
    if (m.find("Header") != m.end()) {
      if (typeid(map<string, boost::any>).name() == m["Header"].type().name()) {
        PutObjectAclRequestHeader model1;
        model1.fromMap(boost::any_cast<map<string, boost::any>>(m["Header"]));
        header = make_shared<PutObjectAclRequestHeader>(model1);
      }
    }
  }

  shared_ptr<string> bucketName{};
  shared_ptr<string> objectName{};
  shared_ptr<PutObjectAclRequestHeader> header{};

  ~PutObjectAclRequest() = default;
};
class PutObjectAclResponse : public Darabonba::Model {
public:
  PutObjectAclResponse() {}
  explicit PutObjectAclResponse(const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!requestId) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("requestId is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (requestId) {
      res["x-oss-request-id"] = boost::any(*requestId);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("x-oss-request-id") != m.end()) {
      requestId =
          make_shared<string>(boost::any_cast<string>(m["x-oss-request-id"]));
    }
  }

  shared_ptr<string> requestId{};

  ~PutObjectAclResponse() = default;
};
class GetBucketInfoRequest : public Darabonba::Model {
public:
  GetBucketInfoRequest() {}
  explicit GetBucketInfoRequest(const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!bucketName) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("bucketName is required.")));
    }
    Darabonba::Model::validatePattern("bucketName", bucketName,
                                      "[a-zA-Z0-9\\\\-\\\\_]+");
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (bucketName) {
      res["BucketName"] = boost::any(*bucketName);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("BucketName") != m.end()) {
      bucketName =
          make_shared<string>(boost::any_cast<string>(m["BucketName"]));
    }
  }

  shared_ptr<string> bucketName{};

  ~GetBucketInfoRequest() = default;
};
class GetBucketInfoResponseBucketInfoBucketOwner : public Darabonba::Model {
public:
  GetBucketInfoResponseBucketInfoBucketOwner() {}
  explicit GetBucketInfoResponseBucketInfoBucketOwner(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {}

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (iD) {
      res["ID"] = boost::any(*iD);
    }
    if (displayName) {
      res["DisplayName"] = boost::any(*displayName);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("ID") != m.end()) {
      iD = make_shared<string>(boost::any_cast<string>(m["ID"]));
    }
    if (m.find("DisplayName") != m.end()) {
      displayName =
          make_shared<string>(boost::any_cast<string>(m["DisplayName"]));
    }
  }

  shared_ptr<string> iD{};
  shared_ptr<string> displayName{};

  ~GetBucketInfoResponseBucketInfoBucketOwner() = default;
};
class GetBucketInfoResponseBucketInfoBucketAccessControlList
    : public Darabonba::Model {
public:
  GetBucketInfoResponseBucketInfoBucketAccessControlList() {}
  explicit GetBucketInfoResponseBucketInfoBucketAccessControlList(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {}

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (grant) {
      res["Grant"] = boost::any(*grant);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("Grant") != m.end()) {
      grant = make_shared<string>(boost::any_cast<string>(m["Grant"]));
    }
  }

  shared_ptr<string> grant{};

  ~GetBucketInfoResponseBucketInfoBucketAccessControlList() = default;
};
class GetBucketInfoResponseBucketInfoBucket : public Darabonba::Model {
public:
  GetBucketInfoResponseBucketInfoBucket() {}
  explicit GetBucketInfoResponseBucketInfoBucket(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!owner) {
      BOOST_THROW_EXCEPTION(
          boost::enable_error_info(std::runtime_error("owner is required.")));
    }
    if (!accessControlList) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("accessControlList is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (creationDate) {
      res["CreationDate"] = boost::any(*creationDate);
    }
    if (extranetEndpoint) {
      res["ExtranetEndpoint"] = boost::any(*extranetEndpoint);
    }
    if (intranetEndpoint) {
      res["IntranetEndpoint"] = boost::any(*intranetEndpoint);
    }
    if (location) {
      res["Location"] = boost::any(*location);
    }
    if (name) {
      res["Name"] = boost::any(*name);
    }
    if (dataRedundancyType) {
      res["DataRedundancyType"] = boost::any(*dataRedundancyType);
    }
    if (storageClass) {
      res["StorageClass"] = boost::any(*storageClass);
    }
    if (comment) {
      res["Comment"] = boost::any(*comment);
    }
    if (owner) {
      res["Owner"] = owner ? boost::any(owner->toMap())
                           : boost::any(map<string, boost::any>({}));
    }
    if (accessControlList) {
      res["AccessControlList"] = accessControlList
                                     ? boost::any(accessControlList->toMap())
                                     : boost::any(map<string, boost::any>({}));
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("CreationDate") != m.end()) {
      creationDate =
          make_shared<string>(boost::any_cast<string>(m["CreationDate"]));
    }
    if (m.find("ExtranetEndpoint") != m.end()) {
      extranetEndpoint =
          make_shared<string>(boost::any_cast<string>(m["ExtranetEndpoint"]));
    }
    if (m.find("IntranetEndpoint") != m.end()) {
      intranetEndpoint =
          make_shared<string>(boost::any_cast<string>(m["IntranetEndpoint"]));
    }
    if (m.find("Location") != m.end()) {
      location = make_shared<string>(boost::any_cast<string>(m["Location"]));
    }
    if (m.find("Name") != m.end()) {
      name = make_shared<string>(boost::any_cast<string>(m["Name"]));
    }
    if (m.find("DataRedundancyType") != m.end()) {
      dataRedundancyType =
          make_shared<string>(boost::any_cast<string>(m["DataRedundancyType"]));
    }
    if (m.find("StorageClass") != m.end()) {
      storageClass =
          make_shared<string>(boost::any_cast<string>(m["StorageClass"]));
    }
    if (m.find("Comment") != m.end()) {
      comment = make_shared<string>(boost::any_cast<string>(m["Comment"]));
    }
    if (m.find("Owner") != m.end()) {
      if (typeid(map<string, boost::any>).name() == m["Owner"].type().name()) {
        GetBucketInfoResponseBucketInfoBucketOwner model1;
        model1.fromMap(boost::any_cast<map<string, boost::any>>(m["Owner"]));
        owner = make_shared<GetBucketInfoResponseBucketInfoBucketOwner>(model1);
      }
    }
    if (m.find("AccessControlList") != m.end()) {
      if (typeid(map<string, boost::any>).name() ==
          m["AccessControlList"].type().name()) {
        GetBucketInfoResponseBucketInfoBucketAccessControlList model1;
        model1.fromMap(
            boost::any_cast<map<string, boost::any>>(m["AccessControlList"]));
        accessControlList =
            make_shared<GetBucketInfoResponseBucketInfoBucketAccessControlList>(
                model1);
      }
    }
  }

  shared_ptr<string> creationDate{};
  shared_ptr<string> extranetEndpoint{};
  shared_ptr<string> intranetEndpoint{};
  shared_ptr<string> location{};
  shared_ptr<string> name{};
  shared_ptr<string> dataRedundancyType{};
  shared_ptr<string> storageClass{};
  shared_ptr<string> comment{};
  shared_ptr<GetBucketInfoResponseBucketInfoBucketOwner> owner{};
  shared_ptr<GetBucketInfoResponseBucketInfoBucketAccessControlList>
      accessControlList{};

  ~GetBucketInfoResponseBucketInfoBucket() = default;
};
class GetBucketInfoResponseBucketInfo : public Darabonba::Model {
public:
  GetBucketInfoResponseBucketInfo() {}
  explicit GetBucketInfoResponseBucketInfo(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!bucket) {
      BOOST_THROW_EXCEPTION(
          boost::enable_error_info(std::runtime_error("bucket is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (bucket) {
      res["Bucket"] = bucket ? boost::any(bucket->toMap())
                             : boost::any(map<string, boost::any>({}));
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("Bucket") != m.end()) {
      if (typeid(map<string, boost::any>).name() == m["Bucket"].type().name()) {
        GetBucketInfoResponseBucketInfoBucket model1;
        model1.fromMap(boost::any_cast<map<string, boost::any>>(m["Bucket"]));
        bucket = make_shared<GetBucketInfoResponseBucketInfoBucket>(model1);
      }
    }
  }

  shared_ptr<GetBucketInfoResponseBucketInfoBucket> bucket{};

  ~GetBucketInfoResponseBucketInfo() = default;
};
class GetBucketInfoResponse : public Darabonba::Model {
public:
  GetBucketInfoResponse() {}
  explicit GetBucketInfoResponse(const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!requestId) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("requestId is required.")));
    }
    if (!bucketInfo) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("bucketInfo is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (requestId) {
      res["x-oss-request-id"] = boost::any(*requestId);
    }
    if (bucketInfo) {
      res["BucketInfo"] = bucketInfo ? boost::any(bucketInfo->toMap())
                                     : boost::any(map<string, boost::any>({}));
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("x-oss-request-id") != m.end()) {
      requestId =
          make_shared<string>(boost::any_cast<string>(m["x-oss-request-id"]));
    }
    if (m.find("BucketInfo") != m.end()) {
      if (typeid(map<string, boost::any>).name() ==
          m["BucketInfo"].type().name()) {
        GetBucketInfoResponseBucketInfo model1;
        model1.fromMap(
            boost::any_cast<map<string, boost::any>>(m["BucketInfo"]));
        bucketInfo = make_shared<GetBucketInfoResponseBucketInfo>(model1);
      }
    }
  }

  shared_ptr<string> requestId{};
  shared_ptr<GetBucketInfoResponseBucketInfo> bucketInfo{};

  ~GetBucketInfoResponse() = default;
};
class PutLiveChannelStatusRequestFilter : public Darabonba::Model {
public:
  PutLiveChannelStatusRequestFilter() {}
  explicit PutLiveChannelStatusRequestFilter(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!status) {
      BOOST_THROW_EXCEPTION(
          boost::enable_error_info(std::runtime_error("status is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (status) {
      res["status"] = boost::any(*status);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("status") != m.end()) {
      status = make_shared<string>(boost::any_cast<string>(m["status"]));
    }
  }

  shared_ptr<string> status{};

  ~PutLiveChannelStatusRequestFilter() = default;
};
class PutLiveChannelStatusRequest : public Darabonba::Model {
public:
  PutLiveChannelStatusRequest() {}
  explicit PutLiveChannelStatusRequest(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!bucketName) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("bucketName is required.")));
    }
    Darabonba::Model::validatePattern("bucketName", bucketName,
                                      "[a-zA-Z0-9\\\\-\\\\_]+");
    if (!channelName) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("channelName is required.")));
    }
    if (!filter) {
      BOOST_THROW_EXCEPTION(
          boost::enable_error_info(std::runtime_error("filter is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (bucketName) {
      res["BucketName"] = boost::any(*bucketName);
    }
    if (channelName) {
      res["ChannelName"] = boost::any(*channelName);
    }
    if (filter) {
      res["Filter"] = filter ? boost::any(filter->toMap())
                             : boost::any(map<string, boost::any>({}));
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("BucketName") != m.end()) {
      bucketName =
          make_shared<string>(boost::any_cast<string>(m["BucketName"]));
    }
    if (m.find("ChannelName") != m.end()) {
      channelName =
          make_shared<string>(boost::any_cast<string>(m["ChannelName"]));
    }
    if (m.find("Filter") != m.end()) {
      if (typeid(map<string, boost::any>).name() == m["Filter"].type().name()) {
        PutLiveChannelStatusRequestFilter model1;
        model1.fromMap(boost::any_cast<map<string, boost::any>>(m["Filter"]));
        filter = make_shared<PutLiveChannelStatusRequestFilter>(model1);
      }
    }
  }

  shared_ptr<string> bucketName{};
  shared_ptr<string> channelName{};
  shared_ptr<PutLiveChannelStatusRequestFilter> filter{};

  ~PutLiveChannelStatusRequest() = default;
};
class PutLiveChannelStatusResponse : public Darabonba::Model {
public:
  PutLiveChannelStatusResponse() {}
  explicit PutLiveChannelStatusResponse(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!requestId) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("requestId is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (requestId) {
      res["x-oss-request-id"] = boost::any(*requestId);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("x-oss-request-id") != m.end()) {
      requestId =
          make_shared<string>(boost::any_cast<string>(m["x-oss-request-id"]));
    }
  }

  shared_ptr<string> requestId{};

  ~PutLiveChannelStatusResponse() = default;
};
class InitiateMultipartUploadRequestFilter : public Darabonba::Model {
public:
  InitiateMultipartUploadRequestFilter() {}
  explicit InitiateMultipartUploadRequestFilter(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {}

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (encodingType) {
      res["encoding-type"] = boost::any(*encodingType);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("encoding-type") != m.end()) {
      encodingType =
          make_shared<string>(boost::any_cast<string>(m["encoding-type"]));
    }
  }

  shared_ptr<string> encodingType{};

  ~InitiateMultipartUploadRequestFilter() = default;
};
class InitiateMultipartUploadRequestHeader : public Darabonba::Model {
public:
  InitiateMultipartUploadRequestHeader() {}
  explicit InitiateMultipartUploadRequestHeader(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {}

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (cacheControl) {
      res["Cache-Control"] = boost::any(*cacheControl);
    }
    if (contentDisposition) {
      res["Content-Disposition"] = boost::any(*contentDisposition);
    }
    if (contentEncoding) {
      res["Content-Encoding"] = boost::any(*contentEncoding);
    }
    if (expires) {
      res["Expires"] = boost::any(*expires);
    }
    if (serverSideEncryption) {
      res["x-oss-server-side-encryption"] = boost::any(*serverSideEncryption);
    }
    if (serverSideEncryptionKeyId) {
      res["x-oss-server-side-encryption-key-id"] =
          boost::any(*serverSideEncryptionKeyId);
    }
    if (storageClass) {
      res["x-oss-storage-class"] = boost::any(*storageClass);
    }
    if (tagging) {
      res["x-oss-tagging"] = boost::any(*tagging);
    }
    if (contentType) {
      res["content-type"] = boost::any(*contentType);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("Cache-Control") != m.end()) {
      cacheControl =
          make_shared<string>(boost::any_cast<string>(m["Cache-Control"]));
    }
    if (m.find("Content-Disposition") != m.end()) {
      contentDisposition = make_shared<string>(
          boost::any_cast<string>(m["Content-Disposition"]));
    }
    if (m.find("Content-Encoding") != m.end()) {
      contentEncoding =
          make_shared<string>(boost::any_cast<string>(m["Content-Encoding"]));
    }
    if (m.find("Expires") != m.end()) {
      expires = make_shared<string>(boost::any_cast<string>(m["Expires"]));
    }
    if (m.find("x-oss-server-side-encryption") != m.end()) {
      serverSideEncryption = make_shared<string>(
          boost::any_cast<string>(m["x-oss-server-side-encryption"]));
    }
    if (m.find("x-oss-server-side-encryption-key-id") != m.end()) {
      serverSideEncryptionKeyId = make_shared<string>(
          boost::any_cast<string>(m["x-oss-server-side-encryption-key-id"]));
    }
    if (m.find("x-oss-storage-class") != m.end()) {
      storageClass = make_shared<string>(
          boost::any_cast<string>(m["x-oss-storage-class"]));
    }
    if (m.find("x-oss-tagging") != m.end()) {
      tagging =
          make_shared<string>(boost::any_cast<string>(m["x-oss-tagging"]));
    }
    if (m.find("content-type") != m.end()) {
      contentType =
          make_shared<string>(boost::any_cast<string>(m["content-type"]));
    }
  }

  shared_ptr<string> cacheControl{};
  shared_ptr<string> contentDisposition{};
  shared_ptr<string> contentEncoding{};
  shared_ptr<string> expires{};
  shared_ptr<string> serverSideEncryption{};
  shared_ptr<string> serverSideEncryptionKeyId{};
  shared_ptr<string> storageClass{};
  shared_ptr<string> tagging{};
  shared_ptr<string> contentType{};

  ~InitiateMultipartUploadRequestHeader() = default;
};
class InitiateMultipartUploadRequest : public Darabonba::Model {
public:
  InitiateMultipartUploadRequest() {}
  explicit InitiateMultipartUploadRequest(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!bucketName) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("bucketName is required.")));
    }
    Darabonba::Model::validatePattern("bucketName", bucketName,
                                      "[a-zA-Z0-9\\\\-\\\\_]+");
    if (!objectName) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("objectName is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (bucketName) {
      res["BucketName"] = boost::any(*bucketName);
    }
    if (objectName) {
      res["ObjectName"] = boost::any(*objectName);
    }
    if (filter) {
      res["Filter"] = filter ? boost::any(filter->toMap())
                             : boost::any(map<string, boost::any>({}));
    }
    if (header) {
      res["Header"] = header ? boost::any(header->toMap())
                             : boost::any(map<string, boost::any>({}));
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("BucketName") != m.end()) {
      bucketName =
          make_shared<string>(boost::any_cast<string>(m["BucketName"]));
    }
    if (m.find("ObjectName") != m.end()) {
      objectName =
          make_shared<string>(boost::any_cast<string>(m["ObjectName"]));
    }
    if (m.find("Filter") != m.end()) {
      if (typeid(map<string, boost::any>).name() == m["Filter"].type().name()) {
        InitiateMultipartUploadRequestFilter model1;
        model1.fromMap(boost::any_cast<map<string, boost::any>>(m["Filter"]));
        filter = make_shared<InitiateMultipartUploadRequestFilter>(model1);
      }
    }
    if (m.find("Header") != m.end()) {
      if (typeid(map<string, boost::any>).name() == m["Header"].type().name()) {
        InitiateMultipartUploadRequestHeader model1;
        model1.fromMap(boost::any_cast<map<string, boost::any>>(m["Header"]));
        header = make_shared<InitiateMultipartUploadRequestHeader>(model1);
      }
    }
  }

  shared_ptr<string> bucketName{};
  shared_ptr<string> objectName{};
  shared_ptr<InitiateMultipartUploadRequestFilter> filter{};
  shared_ptr<InitiateMultipartUploadRequestHeader> header{};

  ~InitiateMultipartUploadRequest() = default;
};
class InitiateMultipartUploadResponseInitiateMultipartUploadResult
    : public Darabonba::Model {
public:
  InitiateMultipartUploadResponseInitiateMultipartUploadResult() {}
  explicit InitiateMultipartUploadResponseInitiateMultipartUploadResult(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {}

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (bucket) {
      res["Bucket"] = boost::any(*bucket);
    }
    if (key) {
      res["Key"] = boost::any(*key);
    }
    if (uploadId) {
      res["UploadId"] = boost::any(*uploadId);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("Bucket") != m.end()) {
      bucket = make_shared<string>(boost::any_cast<string>(m["Bucket"]));
    }
    if (m.find("Key") != m.end()) {
      key = make_shared<string>(boost::any_cast<string>(m["Key"]));
    }
    if (m.find("UploadId") != m.end()) {
      uploadId = make_shared<string>(boost::any_cast<string>(m["UploadId"]));
    }
  }

  shared_ptr<string> bucket{};
  shared_ptr<string> key{};
  shared_ptr<string> uploadId{};

  ~InitiateMultipartUploadResponseInitiateMultipartUploadResult() = default;
};
class InitiateMultipartUploadResponse : public Darabonba::Model {
public:
  InitiateMultipartUploadResponse() {}
  explicit InitiateMultipartUploadResponse(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!requestId) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("requestId is required.")));
    }
    if (!initiateMultipartUploadResult) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("initiateMultipartUploadResult is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (requestId) {
      res["x-oss-request-id"] = boost::any(*requestId);
    }
    if (initiateMultipartUploadResult) {
      res["InitiateMultipartUploadResult"] =
          initiateMultipartUploadResult
              ? boost::any(initiateMultipartUploadResult->toMap())
              : boost::any(map<string, boost::any>({}));
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("x-oss-request-id") != m.end()) {
      requestId =
          make_shared<string>(boost::any_cast<string>(m["x-oss-request-id"]));
    }
    if (m.find("InitiateMultipartUploadResult") != m.end()) {
      if (typeid(map<string, boost::any>).name() ==
          m["InitiateMultipartUploadResult"].type().name()) {
        InitiateMultipartUploadResponseInitiateMultipartUploadResult model1;
        model1.fromMap(boost::any_cast<map<string, boost::any>>(
            m["InitiateMultipartUploadResult"]));
        initiateMultipartUploadResult = make_shared<
            InitiateMultipartUploadResponseInitiateMultipartUploadResult>(
            model1);
      }
    }
  }

  shared_ptr<string> requestId{};
  shared_ptr<InitiateMultipartUploadResponseInitiateMultipartUploadResult>
      initiateMultipartUploadResult{};

  ~InitiateMultipartUploadResponse() = default;
};
class OptionObjectRequestHeader : public Darabonba::Model {
public:
  OptionObjectRequestHeader() {}
  explicit OptionObjectRequestHeader(const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!origin) {
      BOOST_THROW_EXCEPTION(
          boost::enable_error_info(std::runtime_error("origin is required.")));
    }
    if (!accessControlRequestMethod) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("accessControlRequestMethod is required.")));
    }
    if (!accessControlRequestHeaders) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("accessControlRequestHeaders is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (origin) {
      res["Origin"] = boost::any(*origin);
    }
    if (accessControlRequestMethod) {
      res["Access-Control-Request-Method"] =
          boost::any(*accessControlRequestMethod);
    }
    if (accessControlRequestHeaders) {
      res["Access-Control-Request-Headers"] =
          boost::any(*accessControlRequestHeaders);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("Origin") != m.end()) {
      origin = make_shared<string>(boost::any_cast<string>(m["Origin"]));
    }
    if (m.find("Access-Control-Request-Method") != m.end()) {
      accessControlRequestMethod = make_shared<string>(
          boost::any_cast<string>(m["Access-Control-Request-Method"]));
    }
    if (m.find("Access-Control-Request-Headers") != m.end()) {
      accessControlRequestHeaders = make_shared<string>(
          boost::any_cast<string>(m["Access-Control-Request-Headers"]));
    }
  }

  shared_ptr<string> origin{};
  shared_ptr<string> accessControlRequestMethod{};
  shared_ptr<string> accessControlRequestHeaders{};

  ~OptionObjectRequestHeader() = default;
};
class OptionObjectRequest : public Darabonba::Model {
public:
  OptionObjectRequest() {}
  explicit OptionObjectRequest(const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!bucketName) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("bucketName is required.")));
    }
    Darabonba::Model::validatePattern("bucketName", bucketName,
                                      "[a-zA-Z0-9\\\\-\\\\_]+");
    if (!objectName) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("objectName is required.")));
    }
    if (!header) {
      BOOST_THROW_EXCEPTION(
          boost::enable_error_info(std::runtime_error("header is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (bucketName) {
      res["BucketName"] = boost::any(*bucketName);
    }
    if (objectName) {
      res["ObjectName"] = boost::any(*objectName);
    }
    if (header) {
      res["Header"] = header ? boost::any(header->toMap())
                             : boost::any(map<string, boost::any>({}));
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("BucketName") != m.end()) {
      bucketName =
          make_shared<string>(boost::any_cast<string>(m["BucketName"]));
    }
    if (m.find("ObjectName") != m.end()) {
      objectName =
          make_shared<string>(boost::any_cast<string>(m["ObjectName"]));
    }
    if (m.find("Header") != m.end()) {
      if (typeid(map<string, boost::any>).name() == m["Header"].type().name()) {
        OptionObjectRequestHeader model1;
        model1.fromMap(boost::any_cast<map<string, boost::any>>(m["Header"]));
        header = make_shared<OptionObjectRequestHeader>(model1);
      }
    }
  }

  shared_ptr<string> bucketName{};
  shared_ptr<string> objectName{};
  shared_ptr<OptionObjectRequestHeader> header{};

  ~OptionObjectRequest() = default;
};
class OptionObjectResponse : public Darabonba::Model {
public:
  OptionObjectResponse() {}
  explicit OptionObjectResponse(const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!requestId) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("requestId is required.")));
    }
    if (!accessControlAllowOrigin) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("accessControlAllowOrigin is required.")));
    }
    if (!accessControlAllowMethods) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("accessControlAllowMethods is required.")));
    }
    if (!accessControlAllowHeaders) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("accessControlAllowHeaders is required.")));
    }
    if (!accessControlExposeHeaders) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("accessControlExposeHeaders is required.")));
    }
    if (!accessControlMaxAge) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("accessControlMaxAge is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (requestId) {
      res["x-oss-request-id"] = boost::any(*requestId);
    }
    if (accessControlAllowOrigin) {
      res["access-control-allow-origin"] =
          boost::any(*accessControlAllowOrigin);
    }
    if (accessControlAllowMethods) {
      res["access-control-allow-methods"] =
          boost::any(*accessControlAllowMethods);
    }
    if (accessControlAllowHeaders) {
      res["access-control-allow-headers"] =
          boost::any(*accessControlAllowHeaders);
    }
    if (accessControlExposeHeaders) {
      res["access-control-expose-headers"] =
          boost::any(*accessControlExposeHeaders);
    }
    if (accessControlMaxAge) {
      res["access-control-max-age"] = boost::any(*accessControlMaxAge);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("x-oss-request-id") != m.end()) {
      requestId =
          make_shared<string>(boost::any_cast<string>(m["x-oss-request-id"]));
    }
    if (m.find("access-control-allow-origin") != m.end()) {
      accessControlAllowOrigin = make_shared<string>(
          boost::any_cast<string>(m["access-control-allow-origin"]));
    }
    if (m.find("access-control-allow-methods") != m.end()) {
      accessControlAllowMethods = make_shared<string>(
          boost::any_cast<string>(m["access-control-allow-methods"]));
    }
    if (m.find("access-control-allow-headers") != m.end()) {
      accessControlAllowHeaders = make_shared<string>(
          boost::any_cast<string>(m["access-control-allow-headers"]));
    }
    if (m.find("access-control-expose-headers") != m.end()) {
      accessControlExposeHeaders = make_shared<string>(
          boost::any_cast<string>(m["access-control-expose-headers"]));
    }
    if (m.find("access-control-max-age") != m.end()) {
      accessControlMaxAge = make_shared<string>(
          boost::any_cast<string>(m["access-control-max-age"]));
    }
  }

  shared_ptr<string> requestId{};
  shared_ptr<string> accessControlAllowOrigin{};
  shared_ptr<string> accessControlAllowMethods{};
  shared_ptr<string> accessControlAllowHeaders{};
  shared_ptr<string> accessControlExposeHeaders{};
  shared_ptr<string> accessControlMaxAge{};

  ~OptionObjectResponse() = default;
};
class PostVodPlaylistRequestFilter : public Darabonba::Model {
public:
  PostVodPlaylistRequestFilter() {}
  explicit PostVodPlaylistRequestFilter(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!endTime) {
      BOOST_THROW_EXCEPTION(
          boost::enable_error_info(std::runtime_error("endTime is required.")));
    }
    if (!startTime) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("startTime is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (endTime) {
      res["endTime"] = boost::any(*endTime);
    }
    if (startTime) {
      res["startTime"] = boost::any(*startTime);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("endTime") != m.end()) {
      endTime = make_shared<string>(boost::any_cast<string>(m["endTime"]));
    }
    if (m.find("startTime") != m.end()) {
      startTime = make_shared<string>(boost::any_cast<string>(m["startTime"]));
    }
  }

  shared_ptr<string> endTime{};
  shared_ptr<string> startTime{};

  ~PostVodPlaylistRequestFilter() = default;
};
class PostVodPlaylistRequest : public Darabonba::Model {
public:
  PostVodPlaylistRequest() {}
  explicit PostVodPlaylistRequest(const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!bucketName) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("bucketName is required.")));
    }
    Darabonba::Model::validatePattern("bucketName", bucketName,
                                      "[a-zA-Z0-9\\\\-\\\\_]+");
    if (!channelName) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("channelName is required.")));
    }
    if (!playlistName) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("playlistName is required.")));
    }
    if (!filter) {
      BOOST_THROW_EXCEPTION(
          boost::enable_error_info(std::runtime_error("filter is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (bucketName) {
      res["BucketName"] = boost::any(*bucketName);
    }
    if (channelName) {
      res["ChannelName"] = boost::any(*channelName);
    }
    if (playlistName) {
      res["PlaylistName"] = boost::any(*playlistName);
    }
    if (filter) {
      res["Filter"] = filter ? boost::any(filter->toMap())
                             : boost::any(map<string, boost::any>({}));
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("BucketName") != m.end()) {
      bucketName =
          make_shared<string>(boost::any_cast<string>(m["BucketName"]));
    }
    if (m.find("ChannelName") != m.end()) {
      channelName =
          make_shared<string>(boost::any_cast<string>(m["ChannelName"]));
    }
    if (m.find("PlaylistName") != m.end()) {
      playlistName =
          make_shared<string>(boost::any_cast<string>(m["PlaylistName"]));
    }
    if (m.find("Filter") != m.end()) {
      if (typeid(map<string, boost::any>).name() == m["Filter"].type().name()) {
        PostVodPlaylistRequestFilter model1;
        model1.fromMap(boost::any_cast<map<string, boost::any>>(m["Filter"]));
        filter = make_shared<PostVodPlaylistRequestFilter>(model1);
      }
    }
  }

  shared_ptr<string> bucketName{};
  shared_ptr<string> channelName{};
  shared_ptr<string> playlistName{};
  shared_ptr<PostVodPlaylistRequestFilter> filter{};

  ~PostVodPlaylistRequest() = default;
};
class PostVodPlaylistResponse : public Darabonba::Model {
public:
  PostVodPlaylistResponse() {}
  explicit PostVodPlaylistResponse(const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!requestId) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("requestId is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (requestId) {
      res["x-oss-request-id"] = boost::any(*requestId);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("x-oss-request-id") != m.end()) {
      requestId =
          make_shared<string>(boost::any_cast<string>(m["x-oss-request-id"]));
    }
  }

  shared_ptr<string> requestId{};

  ~PostVodPlaylistResponse() = default;
};
class PostObjectRequestHeader : public Darabonba::Model {
public:
  PostObjectRequestHeader() {}
  explicit PostObjectRequestHeader(const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!accessKeyId) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("accessKeyId is required.")));
    }
    if (!policy) {
      BOOST_THROW_EXCEPTION(
          boost::enable_error_info(std::runtime_error("policy is required.")));
    }
    if (!signature) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("signature is required.")));
    }
    if (!file) {
      BOOST_THROW_EXCEPTION(
          boost::enable_error_info(std::runtime_error("file is required.")));
    }
    if (!key) {
      BOOST_THROW_EXCEPTION(
          boost::enable_error_info(std::runtime_error("key is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (accessKeyId) {
      res["OSSAccessKeyId"] = boost::any(*accessKeyId);
    }
    if (policy) {
      res["policy"] = boost::any(*policy);
    }
    if (signature) {
      res["Signature"] = boost::any(*signature);
    }
    if (successActionStatus) {
      res["success_action_status"] = boost::any(*successActionStatus);
    }
    if (file) {
      res["file"] = file ? boost::any(file->toMap())
                         : boost::any(map<string, boost::any>({}));
    }
    if (key) {
      res["key"] = boost::any(*key);
    }
    if (userMeta) {
      res["UserMeta"] = boost::any(*userMeta);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("OSSAccessKeyId") != m.end()) {
      accessKeyId =
          make_shared<string>(boost::any_cast<string>(m["OSSAccessKeyId"]));
    }
    if (m.find("policy") != m.end()) {
      policy = make_shared<string>(boost::any_cast<string>(m["policy"]));
    }
    if (m.find("Signature") != m.end()) {
      signature = make_shared<string>(boost::any_cast<string>(m["Signature"]));
    }
    if (m.find("success_action_status") != m.end()) {
      successActionStatus = make_shared<string>(
          boost::any_cast<string>(m["success_action_status"]));
    }
    if (m.find("file") != m.end()) {
      if (typeid(map<string, boost::any>).name() == m["file"].type().name()) {
        Darabonba_FileForm::FileField model1;
        model1.fromMap(boost::any_cast<map<string, boost::any>>(m["file"]));
        file = make_shared<Darabonba_FileForm::FileField>(model1);
      }
    }
    if (m.find("key") != m.end()) {
      key = make_shared<string>(boost::any_cast<string>(m["key"]));
    }
    if (m.find("UserMeta") != m.end()) {
      map<string, boost::any> map1 =
          boost::any_cast<map<string, boost::any>>(m["UserMeta"]);
      map<string, string> toMap1;
      for (auto item : map1) {
        toMap1[item.first] = boost::any_cast<string>(item.second);
      }
      userMeta = make_shared<map<string, string>>(toMap1);
    }
  }

  shared_ptr<string> accessKeyId{};
  shared_ptr<string> policy{};
  shared_ptr<string> signature{};
  shared_ptr<string> successActionStatus{};
  shared_ptr<Darabonba_FileForm::FileField> file{};
  shared_ptr<string> key{};
  shared_ptr<map<string, string>> userMeta{};

  ~PostObjectRequestHeader() = default;
};
class PostObjectRequest : public Darabonba::Model {
public:
  PostObjectRequest() {}
  explicit PostObjectRequest(const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!bucketName) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("bucketName is required.")));
    }
    Darabonba::Model::validatePattern("bucketName", bucketName,
                                      "[a-zA-Z0-9\\\\-\\\\_]+");
    if (!header) {
      BOOST_THROW_EXCEPTION(
          boost::enable_error_info(std::runtime_error("header is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (bucketName) {
      res["BucketName"] = boost::any(*bucketName);
    }
    if (header) {
      res["header"] = header ? boost::any(header->toMap())
                             : boost::any(map<string, boost::any>({}));
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("BucketName") != m.end()) {
      bucketName =
          make_shared<string>(boost::any_cast<string>(m["BucketName"]));
    }
    if (m.find("header") != m.end()) {
      if (typeid(map<string, boost::any>).name() == m["header"].type().name()) {
        PostObjectRequestHeader model1;
        model1.fromMap(boost::any_cast<map<string, boost::any>>(m["header"]));
        header = make_shared<PostObjectRequestHeader>(model1);
      }
    }
  }

  shared_ptr<string> bucketName{};
  shared_ptr<PostObjectRequestHeader> header{};

  ~PostObjectRequest() = default;
};
class PostObjectResponsePostResponse : public Darabonba::Model {
public:
  PostObjectResponsePostResponse() {}
  explicit PostObjectResponsePostResponse(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!bucket) {
      BOOST_THROW_EXCEPTION(
          boost::enable_error_info(std::runtime_error("bucket is required.")));
    }
    if (!eTag) {
      BOOST_THROW_EXCEPTION(
          boost::enable_error_info(std::runtime_error("eTag is required.")));
    }
    if (!location) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("location is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (bucket) {
      res["Bucket"] = boost::any(*bucket);
    }
    if (eTag) {
      res["ETag"] = boost::any(*eTag);
    }
    if (location) {
      res["Location"] = boost::any(*location);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("Bucket") != m.end()) {
      bucket = make_shared<string>(boost::any_cast<string>(m["Bucket"]));
    }
    if (m.find("ETag") != m.end()) {
      eTag = make_shared<string>(boost::any_cast<string>(m["ETag"]));
    }
    if (m.find("Location") != m.end()) {
      location = make_shared<string>(boost::any_cast<string>(m["Location"]));
    }
  }

  shared_ptr<string> bucket{};
  shared_ptr<string> eTag{};
  shared_ptr<string> location{};

  ~PostObjectResponsePostResponse() = default;
};
class PostObjectResponse : public Darabonba::Model {
public:
  PostObjectResponse() {}
  explicit PostObjectResponse(const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!postResponse) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("postResponse is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (postResponse) {
      res["PostResponse"] = postResponse
                                ? boost::any(postResponse->toMap())
                                : boost::any(map<string, boost::any>({}));
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("PostResponse") != m.end()) {
      if (typeid(map<string, boost::any>).name() ==
          m["PostResponse"].type().name()) {
        PostObjectResponsePostResponse model1;
        model1.fromMap(
            boost::any_cast<map<string, boost::any>>(m["PostResponse"]));
        postResponse = make_shared<PostObjectResponsePostResponse>(model1);
      }
    }
  }

  shared_ptr<PostObjectResponsePostResponse> postResponse{};

  ~PostObjectResponse() = default;
};
class HeadObjectRequestHeader : public Darabonba::Model {
public:
  HeadObjectRequestHeader() {}
  explicit HeadObjectRequestHeader(const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {}

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (ifModifiedSince) {
      res["If-Modified-Since"] = boost::any(*ifModifiedSince);
    }
    if (ifUnmodifiedSince) {
      res["If-Unmodified-Since"] = boost::any(*ifUnmodifiedSince);
    }
    if (ifMatch) {
      res["If-Match"] = boost::any(*ifMatch);
    }
    if (ifNoneMatch) {
      res["If-None-Match"] = boost::any(*ifNoneMatch);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("If-Modified-Since") != m.end()) {
      ifModifiedSince =
          make_shared<string>(boost::any_cast<string>(m["If-Modified-Since"]));
    }
    if (m.find("If-Unmodified-Since") != m.end()) {
      ifUnmodifiedSince = make_shared<string>(
          boost::any_cast<string>(m["If-Unmodified-Since"]));
    }
    if (m.find("If-Match") != m.end()) {
      ifMatch = make_shared<string>(boost::any_cast<string>(m["If-Match"]));
    }
    if (m.find("If-None-Match") != m.end()) {
      ifNoneMatch =
          make_shared<string>(boost::any_cast<string>(m["If-None-Match"]));
    }
  }

  shared_ptr<string> ifModifiedSince{};
  shared_ptr<string> ifUnmodifiedSince{};
  shared_ptr<string> ifMatch{};
  shared_ptr<string> ifNoneMatch{};

  ~HeadObjectRequestHeader() = default;
};
class HeadObjectRequest : public Darabonba::Model {
public:
  HeadObjectRequest() {}
  explicit HeadObjectRequest(const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!bucketName) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("bucketName is required.")));
    }
    Darabonba::Model::validatePattern("bucketName", bucketName,
                                      "[a-zA-Z0-9\\\\-\\\\_]+");
    if (!objectName) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("objectName is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (bucketName) {
      res["BucketName"] = boost::any(*bucketName);
    }
    if (objectName) {
      res["ObjectName"] = boost::any(*objectName);
    }
    if (header) {
      res["Header"] = header ? boost::any(header->toMap())
                             : boost::any(map<string, boost::any>({}));
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("BucketName") != m.end()) {
      bucketName =
          make_shared<string>(boost::any_cast<string>(m["BucketName"]));
    }
    if (m.find("ObjectName") != m.end()) {
      objectName =
          make_shared<string>(boost::any_cast<string>(m["ObjectName"]));
    }
    if (m.find("Header") != m.end()) {
      if (typeid(map<string, boost::any>).name() == m["Header"].type().name()) {
        HeadObjectRequestHeader model1;
        model1.fromMap(boost::any_cast<map<string, boost::any>>(m["Header"]));
        header = make_shared<HeadObjectRequestHeader>(model1);
      }
    }
  }

  shared_ptr<string> bucketName{};
  shared_ptr<string> objectName{};
  shared_ptr<HeadObjectRequestHeader> header{};

  ~HeadObjectRequest() = default;
};
class HeadObjectResponse : public Darabonba::Model {
public:
  HeadObjectResponse() {}
  explicit HeadObjectResponse(const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!requestId) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("requestId is required.")));
    }
    if (!userMeta) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("userMeta is required.")));
    }
    if (!serverSideEncryption) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("serverSideEncryption is required.")));
    }
    if (!serverSideEncryptionKeyId) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("serverSideEncryptionKeyId is required.")));
    }
    if (!storageClass) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("storageClass is required.")));
    }
    if (!objectType) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("objectType is required.")));
    }
    if (!nextAppendPosition) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("nextAppendPosition is required.")));
    }
    if (!hashCrc64ecma) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("hashCrc64ecma is required.")));
    }
    if (!expiration) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("expiration is required.")));
    }
    if (!restore) {
      BOOST_THROW_EXCEPTION(
          boost::enable_error_info(std::runtime_error("restore is required.")));
    }
    if (!processStatus) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("processStatus is required.")));
    }
    if (!requestCharged) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("requestCharged is required.")));
    }
    if (!contentMd5) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("contentMd5 is required.")));
    }
    if (!lastModified) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("lastModified is required.")));
    }
    if (!accessControlAllowOrigin) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("accessControlAllowOrigin is required.")));
    }
    if (!accessControlAllowMethods) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("accessControlAllowMethods is required.")));
    }
    if (!accessControlMaxAge) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("accessControlMaxAge is required.")));
    }
    if (!accessControlAllowHeaders) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("accessControlAllowHeaders is required.")));
    }
    if (!accessControlExposeHeaders) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("accessControlExposeHeaders is required.")));
    }
    if (!taggingCount) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("taggingCount is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (requestId) {
      res["x-oss-request-id"] = boost::any(*requestId);
    }
    if (userMeta) {
      res["usermeta"] = boost::any(*userMeta);
    }
    if (serverSideEncryption) {
      res["x-oss-server-side-encryption"] = boost::any(*serverSideEncryption);
    }
    if (serverSideEncryptionKeyId) {
      res["x-oss-server-side-encryption-key-id"] =
          boost::any(*serverSideEncryptionKeyId);
    }
    if (storageClass) {
      res["x-oss-storage-class"] = boost::any(*storageClass);
    }
    if (objectType) {
      res["x-oss-object-type"] = boost::any(*objectType);
    }
    if (nextAppendPosition) {
      res["x-oss-next-append-position"] = boost::any(*nextAppendPosition);
    }
    if (hashCrc64ecma) {
      res["x-oss-hash-crc64ecma"] = boost::any(*hashCrc64ecma);
    }
    if (expiration) {
      res["x-oss-expiration"] = boost::any(*expiration);
    }
    if (restore) {
      res["x-oss-restore"] = boost::any(*restore);
    }
    if (processStatus) {
      res["x-oss-process-status"] = boost::any(*processStatus);
    }
    if (requestCharged) {
      res["x-oss-request-charged"] = boost::any(*requestCharged);
    }
    if (contentMd5) {
      res["content-md5"] = boost::any(*contentMd5);
    }
    if (lastModified) {
      res["last-modified"] = boost::any(*lastModified);
    }
    if (accessControlAllowOrigin) {
      res["access-control-allow-origin"] =
          boost::any(*accessControlAllowOrigin);
    }
    if (accessControlAllowMethods) {
      res["access-control-allow-methods"] =
          boost::any(*accessControlAllowMethods);
    }
    if (accessControlMaxAge) {
      res["access-control-max-age"] = boost::any(*accessControlMaxAge);
    }
    if (accessControlAllowHeaders) {
      res["access-control-allow-headers"] =
          boost::any(*accessControlAllowHeaders);
    }
    if (accessControlExposeHeaders) {
      res["access-control-expose-headers"] =
          boost::any(*accessControlExposeHeaders);
    }
    if (taggingCount) {
      res["x-oss-tagging-count"] = boost::any(*taggingCount);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("x-oss-request-id") != m.end()) {
      requestId =
          make_shared<string>(boost::any_cast<string>(m["x-oss-request-id"]));
    }
    if (m.find("usermeta") != m.end()) {
      map<string, boost::any> map1 =
          boost::any_cast<map<string, boost::any>>(m["usermeta"]);
      map<string, string> toMap1;
      for (auto item : map1) {
        toMap1[item.first] = boost::any_cast<string>(item.second);
      }
      userMeta = make_shared<map<string, string>>(toMap1);
    }
    if (m.find("x-oss-server-side-encryption") != m.end()) {
      serverSideEncryption = make_shared<string>(
          boost::any_cast<string>(m["x-oss-server-side-encryption"]));
    }
    if (m.find("x-oss-server-side-encryption-key-id") != m.end()) {
      serverSideEncryptionKeyId = make_shared<string>(
          boost::any_cast<string>(m["x-oss-server-side-encryption-key-id"]));
    }
    if (m.find("x-oss-storage-class") != m.end()) {
      storageClass = make_shared<string>(
          boost::any_cast<string>(m["x-oss-storage-class"]));
    }
    if (m.find("x-oss-object-type") != m.end()) {
      objectType =
          make_shared<string>(boost::any_cast<string>(m["x-oss-object-type"]));
    }
    if (m.find("x-oss-next-append-position") != m.end()) {
      nextAppendPosition = make_shared<string>(
          boost::any_cast<string>(m["x-oss-next-append-position"]));
    }
    if (m.find("x-oss-hash-crc64ecma") != m.end()) {
      hashCrc64ecma = make_shared<string>(
          boost::any_cast<string>(m["x-oss-hash-crc64ecma"]));
    }
    if (m.find("x-oss-expiration") != m.end()) {
      expiration =
          make_shared<string>(boost::any_cast<string>(m["x-oss-expiration"]));
    }
    if (m.find("x-oss-restore") != m.end()) {
      restore =
          make_shared<string>(boost::any_cast<string>(m["x-oss-restore"]));
    }
    if (m.find("x-oss-process-status") != m.end()) {
      processStatus = make_shared<string>(
          boost::any_cast<string>(m["x-oss-process-status"]));
    }
    if (m.find("x-oss-request-charged") != m.end()) {
      requestCharged = make_shared<string>(
          boost::any_cast<string>(m["x-oss-request-charged"]));
    }
    if (m.find("content-md5") != m.end()) {
      contentMd5 =
          make_shared<string>(boost::any_cast<string>(m["content-md5"]));
    }
    if (m.find("last-modified") != m.end()) {
      lastModified =
          make_shared<string>(boost::any_cast<string>(m["last-modified"]));
    }
    if (m.find("access-control-allow-origin") != m.end()) {
      accessControlAllowOrigin = make_shared<string>(
          boost::any_cast<string>(m["access-control-allow-origin"]));
    }
    if (m.find("access-control-allow-methods") != m.end()) {
      accessControlAllowMethods = make_shared<string>(
          boost::any_cast<string>(m["access-control-allow-methods"]));
    }
    if (m.find("access-control-max-age") != m.end()) {
      accessControlMaxAge = make_shared<string>(
          boost::any_cast<string>(m["access-control-max-age"]));
    }
    if (m.find("access-control-allow-headers") != m.end()) {
      accessControlAllowHeaders = make_shared<string>(
          boost::any_cast<string>(m["access-control-allow-headers"]));
    }
    if (m.find("access-control-expose-headers") != m.end()) {
      accessControlExposeHeaders = make_shared<string>(
          boost::any_cast<string>(m["access-control-expose-headers"]));
    }
    if (m.find("x-oss-tagging-count") != m.end()) {
      taggingCount = make_shared<string>(
          boost::any_cast<string>(m["x-oss-tagging-count"]));
    }
  }

  shared_ptr<string> requestId{};
  shared_ptr<map<string, string>> userMeta{};
  shared_ptr<string> serverSideEncryption{};
  shared_ptr<string> serverSideEncryptionKeyId{};
  shared_ptr<string> storageClass{};
  shared_ptr<string> objectType{};
  shared_ptr<string> nextAppendPosition{};
  shared_ptr<string> hashCrc64ecma{};
  shared_ptr<string> expiration{};
  shared_ptr<string> restore{};
  shared_ptr<string> processStatus{};
  shared_ptr<string> requestCharged{};
  shared_ptr<string> contentMd5{};
  shared_ptr<string> lastModified{};
  shared_ptr<string> accessControlAllowOrigin{};
  shared_ptr<string> accessControlAllowMethods{};
  shared_ptr<string> accessControlMaxAge{};
  shared_ptr<string> accessControlAllowHeaders{};
  shared_ptr<string> accessControlExposeHeaders{};
  shared_ptr<string> taggingCount{};

  ~HeadObjectResponse() = default;
};
class DeleteObjectTaggingRequest : public Darabonba::Model {
public:
  DeleteObjectTaggingRequest() {}
  explicit DeleteObjectTaggingRequest(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!bucketName) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("bucketName is required.")));
    }
    Darabonba::Model::validatePattern("bucketName", bucketName,
                                      "[a-zA-Z0-9\\\\-\\\\_]+");
    if (!objectName) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("objectName is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (bucketName) {
      res["BucketName"] = boost::any(*bucketName);
    }
    if (objectName) {
      res["ObjectName"] = boost::any(*objectName);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("BucketName") != m.end()) {
      bucketName =
          make_shared<string>(boost::any_cast<string>(m["BucketName"]));
    }
    if (m.find("ObjectName") != m.end()) {
      objectName =
          make_shared<string>(boost::any_cast<string>(m["ObjectName"]));
    }
  }

  shared_ptr<string> bucketName{};
  shared_ptr<string> objectName{};

  ~DeleteObjectTaggingRequest() = default;
};
class DeleteObjectTaggingResponse : public Darabonba::Model {
public:
  DeleteObjectTaggingResponse() {}
  explicit DeleteObjectTaggingResponse(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!requestId) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("requestId is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (requestId) {
      res["x-oss-request-id"] = boost::any(*requestId);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("x-oss-request-id") != m.end()) {
      requestId =
          make_shared<string>(boost::any_cast<string>(m["x-oss-request-id"]));
    }
  }

  shared_ptr<string> requestId{};

  ~DeleteObjectTaggingResponse() = default;
};
class RestoreObjectRequest : public Darabonba::Model {
public:
  RestoreObjectRequest() {}
  explicit RestoreObjectRequest(const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!bucketName) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("bucketName is required.")));
    }
    Darabonba::Model::validatePattern("bucketName", bucketName,
                                      "[a-zA-Z0-9\\\\-\\\\_]+");
    if (!objectName) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("objectName is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (bucketName) {
      res["BucketName"] = boost::any(*bucketName);
    }
    if (objectName) {
      res["ObjectName"] = boost::any(*objectName);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("BucketName") != m.end()) {
      bucketName =
          make_shared<string>(boost::any_cast<string>(m["BucketName"]));
    }
    if (m.find("ObjectName") != m.end()) {
      objectName =
          make_shared<string>(boost::any_cast<string>(m["ObjectName"]));
    }
  }

  shared_ptr<string> bucketName{};
  shared_ptr<string> objectName{};

  ~RestoreObjectRequest() = default;
};
class RestoreObjectResponse : public Darabonba::Model {
public:
  RestoreObjectResponse() {}
  explicit RestoreObjectResponse(const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!requestId) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("requestId is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (requestId) {
      res["x-oss-request-id"] = boost::any(*requestId);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("x-oss-request-id") != m.end()) {
      requestId =
          make_shared<string>(boost::any_cast<string>(m["x-oss-request-id"]));
    }
  }

  shared_ptr<string> requestId{};

  ~RestoreObjectResponse() = default;
};
class GetObjectAclRequest : public Darabonba::Model {
public:
  GetObjectAclRequest() {}
  explicit GetObjectAclRequest(const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!bucketName) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("bucketName is required.")));
    }
    Darabonba::Model::validatePattern("bucketName", bucketName,
                                      "[a-zA-Z0-9\\\\-\\\\_]+");
    if (!objectName) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("objectName is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (bucketName) {
      res["BucketName"] = boost::any(*bucketName);
    }
    if (objectName) {
      res["ObjectName"] = boost::any(*objectName);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("BucketName") != m.end()) {
      bucketName =
          make_shared<string>(boost::any_cast<string>(m["BucketName"]));
    }
    if (m.find("ObjectName") != m.end()) {
      objectName =
          make_shared<string>(boost::any_cast<string>(m["ObjectName"]));
    }
  }

  shared_ptr<string> bucketName{};
  shared_ptr<string> objectName{};

  ~GetObjectAclRequest() = default;
};
class GetObjectAclResponseAccessControlPolicyOwner : public Darabonba::Model {
public:
  GetObjectAclResponseAccessControlPolicyOwner() {}
  explicit GetObjectAclResponseAccessControlPolicyOwner(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {}

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (iD) {
      res["ID"] = boost::any(*iD);
    }
    if (displayName) {
      res["DisplayName"] = boost::any(*displayName);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("ID") != m.end()) {
      iD = make_shared<string>(boost::any_cast<string>(m["ID"]));
    }
    if (m.find("DisplayName") != m.end()) {
      displayName =
          make_shared<string>(boost::any_cast<string>(m["DisplayName"]));
    }
  }

  shared_ptr<string> iD{};
  shared_ptr<string> displayName{};

  ~GetObjectAclResponseAccessControlPolicyOwner() = default;
};
class GetObjectAclResponseAccessControlPolicyAccessControlList
    : public Darabonba::Model {
public:
  GetObjectAclResponseAccessControlPolicyAccessControlList() {}
  explicit GetObjectAclResponseAccessControlPolicyAccessControlList(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {}

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (grant) {
      res["Grant"] = boost::any(*grant);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("Grant") != m.end()) {
      grant = make_shared<string>(boost::any_cast<string>(m["Grant"]));
    }
  }

  shared_ptr<string> grant{};

  ~GetObjectAclResponseAccessControlPolicyAccessControlList() = default;
};
class GetObjectAclResponseAccessControlPolicy : public Darabonba::Model {
public:
  GetObjectAclResponseAccessControlPolicy() {}
  explicit GetObjectAclResponseAccessControlPolicy(
      const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!owner) {
      BOOST_THROW_EXCEPTION(
          boost::enable_error_info(std::runtime_error("owner is required.")));
    }
    if (!accessControlList) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("accessControlList is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (owner) {
      res["Owner"] = owner ? boost::any(owner->toMap())
                           : boost::any(map<string, boost::any>({}));
    }
    if (accessControlList) {
      res["AccessControlList"] = accessControlList
                                     ? boost::any(accessControlList->toMap())
                                     : boost::any(map<string, boost::any>({}));
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("Owner") != m.end()) {
      if (typeid(map<string, boost::any>).name() == m["Owner"].type().name()) {
        GetObjectAclResponseAccessControlPolicyOwner model1;
        model1.fromMap(boost::any_cast<map<string, boost::any>>(m["Owner"]));
        owner =
            make_shared<GetObjectAclResponseAccessControlPolicyOwner>(model1);
      }
    }
    if (m.find("AccessControlList") != m.end()) {
      if (typeid(map<string, boost::any>).name() ==
          m["AccessControlList"].type().name()) {
        GetObjectAclResponseAccessControlPolicyAccessControlList model1;
        model1.fromMap(
            boost::any_cast<map<string, boost::any>>(m["AccessControlList"]));
        accessControlList = make_shared<
            GetObjectAclResponseAccessControlPolicyAccessControlList>(model1);
      }
    }
  }

  shared_ptr<GetObjectAclResponseAccessControlPolicyOwner> owner{};
  shared_ptr<GetObjectAclResponseAccessControlPolicyAccessControlList>
      accessControlList{};

  ~GetObjectAclResponseAccessControlPolicy() = default;
};
class GetObjectAclResponse : public Darabonba::Model {
public:
  GetObjectAclResponse() {}
  explicit GetObjectAclResponse(const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!requestId) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("requestId is required.")));
    }
    if (!accessControlPolicy) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("accessControlPolicy is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (requestId) {
      res["x-oss-request-id"] = boost::any(*requestId);
    }
    if (accessControlPolicy) {
      res["AccessControlPolicy"] =
          accessControlPolicy ? boost::any(accessControlPolicy->toMap())
                              : boost::any(map<string, boost::any>({}));
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("x-oss-request-id") != m.end()) {
      requestId =
          make_shared<string>(boost::any_cast<string>(m["x-oss-request-id"]));
    }
    if (m.find("AccessControlPolicy") != m.end()) {
      if (typeid(map<string, boost::any>).name() ==
          m["AccessControlPolicy"].type().name()) {
        GetObjectAclResponseAccessControlPolicy model1;
        model1.fromMap(
            boost::any_cast<map<string, boost::any>>(m["AccessControlPolicy"]));
        accessControlPolicy =
            make_shared<GetObjectAclResponseAccessControlPolicy>(model1);
      }
    }
  }

  shared_ptr<string> requestId{};
  shared_ptr<GetObjectAclResponseAccessControlPolicy> accessControlPolicy{};

  ~GetObjectAclResponse() = default;
};
class PutBucketAclRequestHeader : public Darabonba::Model {
public:
  PutBucketAclRequestHeader() {}
  explicit PutBucketAclRequestHeader(const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!acl) {
      BOOST_THROW_EXCEPTION(
          boost::enable_error_info(std::runtime_error("acl is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (acl) {
      res["x-oss-acl"] = boost::any(*acl);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("x-oss-acl") != m.end()) {
      acl = make_shared<string>(boost::any_cast<string>(m["x-oss-acl"]));
    }
  }

  shared_ptr<string> acl{};

  ~PutBucketAclRequestHeader() = default;
};
class PutBucketAclRequest : public Darabonba::Model {
public:
  PutBucketAclRequest() {}
  explicit PutBucketAclRequest(const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!bucketName) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("bucketName is required.")));
    }
    Darabonba::Model::validatePattern("bucketName", bucketName,
                                      "[a-zA-Z0-9\\\\-\\\\_]+");
    if (!header) {
      BOOST_THROW_EXCEPTION(
          boost::enable_error_info(std::runtime_error("header is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (bucketName) {
      res["BucketName"] = boost::any(*bucketName);
    }
    if (header) {
      res["Header"] = header ? boost::any(header->toMap())
                             : boost::any(map<string, boost::any>({}));
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("BucketName") != m.end()) {
      bucketName =
          make_shared<string>(boost::any_cast<string>(m["BucketName"]));
    }
    if (m.find("Header") != m.end()) {
      if (typeid(map<string, boost::any>).name() == m["Header"].type().name()) {
        PutBucketAclRequestHeader model1;
        model1.fromMap(boost::any_cast<map<string, boost::any>>(m["Header"]));
        header = make_shared<PutBucketAclRequestHeader>(model1);
      }
    }
  }

  shared_ptr<string> bucketName{};
  shared_ptr<PutBucketAclRequestHeader> header{};

  ~PutBucketAclRequest() = default;
};
class PutBucketAclResponse : public Darabonba::Model {
public:
  PutBucketAclResponse() {}
  explicit PutBucketAclResponse(const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!requestId) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("requestId is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (requestId) {
      res["x-oss-request-id"] = boost::any(*requestId);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("x-oss-request-id") != m.end()) {
      requestId =
          make_shared<string>(boost::any_cast<string>(m["x-oss-request-id"]));
    }
  }

  shared_ptr<string> requestId{};

  ~PutBucketAclResponse() = default;
};
class DeleteBucketRequest : public Darabonba::Model {
public:
  DeleteBucketRequest() {}
  explicit DeleteBucketRequest(const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!bucketName) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("bucketName is required.")));
    }
    Darabonba::Model::validatePattern("bucketName", bucketName,
                                      "[a-zA-Z0-9\\\\-\\\\_]+");
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (bucketName) {
      res["BucketName"] = boost::any(*bucketName);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("BucketName") != m.end()) {
      bucketName =
          make_shared<string>(boost::any_cast<string>(m["BucketName"]));
    }
  }

  shared_ptr<string> bucketName{};

  ~DeleteBucketRequest() = default;
};
class DeleteBucketResponse : public Darabonba::Model {
public:
  DeleteBucketResponse() {}
  explicit DeleteBucketResponse(const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!requestId) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("requestId is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (requestId) {
      res["x-oss-request-id"] = boost::any(*requestId);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("x-oss-request-id") != m.end()) {
      requestId =
          make_shared<string>(boost::any_cast<string>(m["x-oss-request-id"]));
    }
  }

  shared_ptr<string> requestId{};

  ~DeleteBucketResponse() = default;
};
class PutObjectRequestHeader : public Darabonba::Model {
public:
  PutObjectRequestHeader() {}
  explicit PutObjectRequestHeader(const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {}

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (authorization) {
      res["Authorization"] = boost::any(*authorization);
    }
    if (cacheControl) {
      res["Cache-Control"] = boost::any(*cacheControl);
    }
    if (contentDisposition) {
      res["Content-Disposition"] = boost::any(*contentDisposition);
    }
    if (contentEncoding) {
      res["Content-Encoding"] = boost::any(*contentEncoding);
    }
    if (contentMD5) {
      res["Content-MD5"] = boost::any(*contentMD5);
    }
    if (contentLength) {
      res["Content-Length"] = boost::any(*contentLength);
    }
    if (eTag) {
      res["CETag"] = boost::any(*eTag);
    }
    if (expires) {
      res["Expires"] = boost::any(*expires);
    }
    if (serverSideEncryption) {
      res["x-oss-server-side-encryption"] = boost::any(*serverSideEncryption);
    }
    if (serverSideEncryptionKeyId) {
      res["x-oss-server-side-encryption-key-id"] =
          boost::any(*serverSideEncryptionKeyId);
    }
    if (objectAcl) {
      res["x-oss-object-acl"] = boost::any(*objectAcl);
    }
    if (storageClass) {
      res["x-oss-storage-class"] = boost::any(*storageClass);
    }
    if (tagging) {
      res["x-oss-tagging"] = boost::any(*tagging);
    }
    if (contentType) {
      res["content-type"] = boost::any(*contentType);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("Authorization") != m.end()) {
      authorization =
          make_shared<string>(boost::any_cast<string>(m["Authorization"]));
    }
    if (m.find("Cache-Control") != m.end()) {
      cacheControl =
          make_shared<string>(boost::any_cast<string>(m["Cache-Control"]));
    }
    if (m.find("Content-Disposition") != m.end()) {
      contentDisposition = make_shared<string>(
          boost::any_cast<string>(m["Content-Disposition"]));
    }
    if (m.find("Content-Encoding") != m.end()) {
      contentEncoding =
          make_shared<string>(boost::any_cast<string>(m["Content-Encoding"]));
    }
    if (m.find("Content-MD5") != m.end()) {
      contentMD5 =
          make_shared<string>(boost::any_cast<string>(m["Content-MD5"]));
    }
    if (m.find("Content-Length") != m.end()) {
      contentLength =
          make_shared<string>(boost::any_cast<string>(m["Content-Length"]));
    }
    if (m.find("CETag") != m.end()) {
      eTag = make_shared<string>(boost::any_cast<string>(m["CETag"]));
    }
    if (m.find("Expires") != m.end()) {
      expires = make_shared<string>(boost::any_cast<string>(m["Expires"]));
    }
    if (m.find("x-oss-server-side-encryption") != m.end()) {
      serverSideEncryption = make_shared<string>(
          boost::any_cast<string>(m["x-oss-server-side-encryption"]));
    }
    if (m.find("x-oss-server-side-encryption-key-id") != m.end()) {
      serverSideEncryptionKeyId = make_shared<string>(
          boost::any_cast<string>(m["x-oss-server-side-encryption-key-id"]));
    }
    if (m.find("x-oss-object-acl") != m.end()) {
      objectAcl =
          make_shared<string>(boost::any_cast<string>(m["x-oss-object-acl"]));
    }
    if (m.find("x-oss-storage-class") != m.end()) {
      storageClass = make_shared<string>(
          boost::any_cast<string>(m["x-oss-storage-class"]));
    }
    if (m.find("x-oss-tagging") != m.end()) {
      tagging =
          make_shared<string>(boost::any_cast<string>(m["x-oss-tagging"]));
    }
    if (m.find("content-type") != m.end()) {
      contentType =
          make_shared<string>(boost::any_cast<string>(m["content-type"]));
    }
  }

  shared_ptr<string> authorization{};
  shared_ptr<string> cacheControl{};
  shared_ptr<string> contentDisposition{};
  shared_ptr<string> contentEncoding{};
  shared_ptr<string> contentMD5{};
  shared_ptr<string> contentLength{};
  shared_ptr<string> eTag{};
  shared_ptr<string> expires{};
  shared_ptr<string> serverSideEncryption{};
  shared_ptr<string> serverSideEncryptionKeyId{};
  shared_ptr<string> objectAcl{};
  shared_ptr<string> storageClass{};
  shared_ptr<string> tagging{};
  shared_ptr<string> contentType{};

  ~PutObjectRequestHeader() = default;
};
class PutObjectRequest : public Darabonba::Model {
public:
  PutObjectRequest() {}
  explicit PutObjectRequest(const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!bucketName) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("bucketName is required.")));
    }
    Darabonba::Model::validatePattern("bucketName", bucketName,
                                      "[a-zA-Z0-9\\\\-\\\\_]+");
    if (!objectName) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("objectName is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (bucketName) {
      res["BucketName"] = boost::any(*bucketName);
    }
    if (objectName) {
      res["ObjectName"] = boost::any(*objectName);
    }
    if (userMeta) {
      res["UserMeta"] = boost::any(*userMeta);
    }
    if (body) {
      res["body"] = boost::any(*body);
    }
    if (header) {
      res["Header"] = header ? boost::any(header->toMap())
                             : boost::any(map<string, boost::any>({}));
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("BucketName") != m.end()) {
      bucketName =
          make_shared<string>(boost::any_cast<string>(m["BucketName"]));
    }
    if (m.find("ObjectName") != m.end()) {
      objectName =
          make_shared<string>(boost::any_cast<string>(m["ObjectName"]));
    }
    if (m.find("UserMeta") != m.end()) {
      map<string, boost::any> map1 =
          boost::any_cast<map<string, boost::any>>(m["UserMeta"]);
      map<string, string> toMap1;
      for (auto item : map1) {
        toMap1[item.first] = boost::any_cast<string>(item.second);
      }
      userMeta = make_shared<map<string, string>>(toMap1);
    }
    if (m.find("body") != m.end()) {
      body = make_shared<Darabonba::Stream>(
          boost::any_cast<Darabonba::Stream>(m["body"]));
    }
    if (m.find("Header") != m.end()) {
      if (typeid(map<string, boost::any>).name() == m["Header"].type().name()) {
        PutObjectRequestHeader model1;
        model1.fromMap(boost::any_cast<map<string, boost::any>>(m["Header"]));
        header = make_shared<PutObjectRequestHeader>(model1);
      }
    }
  }

  shared_ptr<string> bucketName{};
  shared_ptr<string> objectName{};
  shared_ptr<map<string, string>> userMeta{};
  shared_ptr<Darabonba::Stream> body{};
  shared_ptr<PutObjectRequestHeader> header{};

  ~PutObjectRequest() = default;
};
class PutObjectResponse : public Darabonba::Model {
public:
  PutObjectResponse() {}
  explicit PutObjectResponse(const std::map<string, boost::any> &config)
      : Darabonba::Model(config) {
    fromMap(config);
  };

  void validate() override {
    if (!requestId) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("requestId is required.")));
    }
    if (!hashCrc64ecma) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("hashCrc64ecma is required.")));
    }
    if (!serverTime) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("serverTime is required.")));
    }
    if (!bucketVersion) {
      BOOST_THROW_EXCEPTION(boost::enable_error_info(
          std::runtime_error("bucketVersion is required.")));
    }
  }

  map<string, boost::any> toMap() override {
    map<string, boost::any> res;
    if (requestId) {
      res["x-oss-request-id"] = boost::any(*requestId);
    }
    if (hashCrc64ecma) {
      res["x-oss-hash-crc64ecma"] = boost::any(*hashCrc64ecma);
    }
    if (serverTime) {
      res["x-oss-server-time"] = boost::any(*serverTime);
    }
    if (bucketVersion) {
      res["x-oss-bucket-version"] = boost::any(*bucketVersion);
    }
    return res;
  }

  void fromMap(map<string, boost::any> m) override {
    if (m.find("x-oss-request-id") != m.end()) {
      requestId =
          make_shared<string>(boost::any_cast<string>(m["x-oss-request-id"]));
    }
    if (m.find("x-oss-hash-crc64ecma") != m.end()) {
      hashCrc64ecma = make_shared<string>(
          boost::any_cast<string>(m["x-oss-hash-crc64ecma"]));
    }
    if (m.find("x-oss-server-time") != m.end()) {
      serverTime =
          make_shared<string>(boost::any_cast<string>(m["x-oss-server-time"]));
    }
    if (m.find("x-oss-bucket-version") != m.end()) {
      bucketVersion = make_shared<string>(
          boost::any_cast<string>(m["x-oss-bucket-version"]));
    }
  }

  shared_ptr<string> requestId{};
  shared_ptr<string> hashCrc64ecma{};
  shared_ptr<string> serverTime{};
  shared_ptr<string> bucketVersion{};

  ~PutObjectResponse() = default;
};
class Client {
public:
  shared_ptr<string> _endpoint{};
  shared_ptr<string> _regionId{};
  shared_ptr<string> _hostModel{};
  shared_ptr<string> _protocol{};
  shared_ptr<int> _readTimeout{};
  shared_ptr<int> _connectTimeout{};
  shared_ptr<string> _signatureVersion{};
  shared_ptr<vector<string>> _addtionalHeaders{};
  shared_ptr<string> _localAddr{};
  shared_ptr<string> _httpProxy{};
  shared_ptr<string> _httpsProxy{};
  shared_ptr<string> _noProxy{};
  shared_ptr<string> _userAgent{};
  shared_ptr<string> _socks5Proxy{};
  shared_ptr<bool> _isEnableCrc{};
  shared_ptr<bool> _isEnableMD5{};
  shared_ptr<string> _socks5NetWork{};
  shared_ptr<int> _maxIdleConns{};
  shared_ptr<Alibabacloud_Credential::Client> _credential{};
  explicit Client(const shared_ptr<Config> &config);
  PutBucketLifecycleResponse
  putBucketLifecycle(shared_ptr<PutBucketLifecycleRequest> request,
                     shared_ptr<Alibabacloud_OSSUtil::RuntimeOptions> runtime);
  DeleteMultipleObjectsResponse deleteMultipleObjects(
      shared_ptr<DeleteMultipleObjectsRequest> request,
      shared_ptr<Alibabacloud_OSSUtil::RuntimeOptions> runtime);
  PutBucketRefererResponse
  putBucketReferer(shared_ptr<PutBucketRefererRequest> request,
                   shared_ptr<Alibabacloud_OSSUtil::RuntimeOptions> runtime);
  PutBucketWebsiteResponse
  putBucketWebsite(shared_ptr<PutBucketWebsiteRequest> request,
                   shared_ptr<Alibabacloud_OSSUtil::RuntimeOptions> runtime);
  CompleteMultipartUploadResponse completeMultipartUpload(
      shared_ptr<CompleteMultipartUploadRequest> request,
      shared_ptr<Alibabacloud_OSSUtil::RuntimeOptions> runtime);
  PutBucketLoggingResponse
  putBucketLogging(shared_ptr<PutBucketLoggingRequest> request,
                   shared_ptr<Alibabacloud_OSSUtil::RuntimeOptions> runtime);
  PutBucketRequestPaymentResponse putBucketRequestPayment(
      shared_ptr<PutBucketRequestPaymentRequest> request,
      shared_ptr<Alibabacloud_OSSUtil::RuntimeOptions> runtime);
  PutBucketEncryptionResponse
  putBucketEncryption(shared_ptr<PutBucketEncryptionRequest> request,
                      shared_ptr<Alibabacloud_OSSUtil::RuntimeOptions> runtime);
  PutLiveChannelResponse
  putLiveChannel(shared_ptr<PutLiveChannelRequest> request,
                 shared_ptr<Alibabacloud_OSSUtil::RuntimeOptions> runtime);
  PutBucketTagsResponse
  putBucketTags(shared_ptr<PutBucketTagsRequest> request,
                shared_ptr<Alibabacloud_OSSUtil::RuntimeOptions> runtime);
  PutObjectTaggingResponse
  putObjectTagging(shared_ptr<PutObjectTaggingRequest> request,
                   shared_ptr<Alibabacloud_OSSUtil::RuntimeOptions> runtime);
  SelectObjectResponse
  selectObject(shared_ptr<SelectObjectRequest> request,
               shared_ptr<Alibabacloud_OSSUtil::RuntimeOptions> runtime);
  PutBucketCORSResponse
  putBucketCORS(shared_ptr<PutBucketCORSRequest> request,
                shared_ptr<Alibabacloud_OSSUtil::RuntimeOptions> runtime);
  PutBucketResponse
  putBucket(shared_ptr<PutBucketRequest> request,
            shared_ptr<Alibabacloud_OSSUtil::RuntimeOptions> runtime);
  ListMultipartUploadsResponse listMultipartUploads(
      shared_ptr<ListMultipartUploadsRequest> request,
      shared_ptr<Alibabacloud_OSSUtil::RuntimeOptions> runtime);
  GetBucketRequestPaymentResponse getBucketRequestPayment(
      shared_ptr<GetBucketRequestPaymentRequest> request,
      shared_ptr<Alibabacloud_OSSUtil::RuntimeOptions> runtime);
  GetBucketEncryptionResponse
  getBucketEncryption(shared_ptr<GetBucketEncryptionRequest> request,
                      shared_ptr<Alibabacloud_OSSUtil::RuntimeOptions> runtime);
  GetBucketTagsResponse
  getBucketTags(shared_ptr<GetBucketTagsRequest> request,
                shared_ptr<Alibabacloud_OSSUtil::RuntimeOptions> runtime);
  GetServiceResponse
  getService(shared_ptr<GetServiceRequest> request,
             shared_ptr<Alibabacloud_OSSUtil::RuntimeOptions> runtime);
  DeleteBucketEncryptionResponse deleteBucketEncryption(
      shared_ptr<DeleteBucketEncryptionRequest> request,
      shared_ptr<Alibabacloud_OSSUtil::RuntimeOptions> runtime);
  DeleteBucketTagsResponse
  deleteBucketTags(shared_ptr<DeleteBucketTagsRequest> request,
                   shared_ptr<Alibabacloud_OSSUtil::RuntimeOptions> runtime);
  GetBucketWebsiteResponse
  getBucketWebsite(shared_ptr<GetBucketWebsiteRequest> request,
                   shared_ptr<Alibabacloud_OSSUtil::RuntimeOptions> runtime);
  DeleteLiveChannelResponse
  deleteLiveChannel(shared_ptr<DeleteLiveChannelRequest> request,
                    shared_ptr<Alibabacloud_OSSUtil::RuntimeOptions> runtime);
  GetBucketLocationResponse
  getBucketLocation(shared_ptr<GetBucketLocationRequest> request,
                    shared_ptr<Alibabacloud_OSSUtil::RuntimeOptions> runtime);
  ListLiveChannelResponse
  listLiveChannel(shared_ptr<ListLiveChannelRequest> request,
                  shared_ptr<Alibabacloud_OSSUtil::RuntimeOptions> runtime);
  GetObjectMetaResponse
  getObjectMeta(shared_ptr<GetObjectMetaRequest> request,
                shared_ptr<Alibabacloud_OSSUtil::RuntimeOptions> runtime);
  GetBucketAclResponse
  getBucketAcl(shared_ptr<GetBucketAclRequest> request,
               shared_ptr<Alibabacloud_OSSUtil::RuntimeOptions> runtime);
  ListPartsResponse
  listParts(shared_ptr<ListPartsRequest> request,
            shared_ptr<Alibabacloud_OSSUtil::RuntimeOptions> runtime);
  GetLiveChannelHistoryResponse getLiveChannelHistory(
      shared_ptr<GetLiveChannelHistoryRequest> request,
      shared_ptr<Alibabacloud_OSSUtil::RuntimeOptions> runtime);
  GetBucketResponse
  getBucket(shared_ptr<GetBucketRequest> request,
            shared_ptr<Alibabacloud_OSSUtil::RuntimeOptions> runtime);
  GetLiveChannelInfoResponse
  getLiveChannelInfo(shared_ptr<GetLiveChannelInfoRequest> request,
                     shared_ptr<Alibabacloud_OSSUtil::RuntimeOptions> runtime);
  GetLiveChannelStatResponse
  getLiveChannelStat(shared_ptr<GetLiveChannelStatRequest> request,
                     shared_ptr<Alibabacloud_OSSUtil::RuntimeOptions> runtime);
  DeleteObjectResponse
  deleteObject(shared_ptr<DeleteObjectRequest> request,
               shared_ptr<Alibabacloud_OSSUtil::RuntimeOptions> runtime);
  AbortMultipartUploadResponse abortMultipartUpload(
      shared_ptr<AbortMultipartUploadRequest> request,
      shared_ptr<Alibabacloud_OSSUtil::RuntimeOptions> runtime);
  AppendObjectResponse
  appendObject(shared_ptr<AppendObjectRequest> request,
               shared_ptr<Alibabacloud_OSSUtil::RuntimeOptions> runtime);
  UploadPartCopyResponse
  uploadPartCopy(shared_ptr<UploadPartCopyRequest> request,
                 shared_ptr<Alibabacloud_OSSUtil::RuntimeOptions> runtime);
  GetVodPlaylistResponse
  getVodPlaylist(shared_ptr<GetVodPlaylistRequest> request,
                 shared_ptr<Alibabacloud_OSSUtil::RuntimeOptions> runtime);
  DeleteBucketCORSResponse
  deleteBucketCORS(shared_ptr<DeleteBucketCORSRequest> request,
                   shared_ptr<Alibabacloud_OSSUtil::RuntimeOptions> runtime);
  GetObjectResponse
  getObject(shared_ptr<GetObjectRequest> request,
            shared_ptr<Alibabacloud_OSSUtil::RuntimeOptions> runtime);
  UploadPartResponse
  uploadPart(shared_ptr<UploadPartRequest> request,
             shared_ptr<Alibabacloud_OSSUtil::RuntimeOptions> runtime);
  GetBucketCORSResponse
  getBucketCORS(shared_ptr<GetBucketCORSRequest> request,
                shared_ptr<Alibabacloud_OSSUtil::RuntimeOptions> runtime);
  CopyObjectResponse
  copyObject(shared_ptr<CopyObjectRequest> request,
             shared_ptr<Alibabacloud_OSSUtil::RuntimeOptions> runtime);
  GetObjectTaggingResponse
  getObjectTagging(shared_ptr<GetObjectTaggingRequest> request,
                   shared_ptr<Alibabacloud_OSSUtil::RuntimeOptions> runtime);
  DeleteBucketLifecycleResponse deleteBucketLifecycle(
      shared_ptr<DeleteBucketLifecycleRequest> request,
      shared_ptr<Alibabacloud_OSSUtil::RuntimeOptions> runtime);
  DeleteBucketLoggingResponse
  deleteBucketLogging(shared_ptr<DeleteBucketLoggingRequest> request,
                      shared_ptr<Alibabacloud_OSSUtil::RuntimeOptions> runtime);
  DeleteBucketWebsiteResponse
  deleteBucketWebsite(shared_ptr<DeleteBucketWebsiteRequest> request,
                      shared_ptr<Alibabacloud_OSSUtil::RuntimeOptions> runtime);
  GetSymlinkResponse
  getSymlink(shared_ptr<GetSymlinkRequest> request,
             shared_ptr<Alibabacloud_OSSUtil::RuntimeOptions> runtime);
  GetBucketLifecycleResponse
  getBucketLifecycle(shared_ptr<GetBucketLifecycleRequest> request,
                     shared_ptr<Alibabacloud_OSSUtil::RuntimeOptions> runtime);
  PutSymlinkResponse
  putSymlink(shared_ptr<PutSymlinkRequest> request,
             shared_ptr<Alibabacloud_OSSUtil::RuntimeOptions> runtime);
  GetBucketRefererResponse
  getBucketReferer(shared_ptr<GetBucketRefererRequest> request,
                   shared_ptr<Alibabacloud_OSSUtil::RuntimeOptions> runtime);
  CallbackResponse
  callback(shared_ptr<CallbackRequest> request,
           shared_ptr<Alibabacloud_OSSUtil::RuntimeOptions> runtime);
  GetBucketLoggingResponse
  getBucketLogging(shared_ptr<GetBucketLoggingRequest> request,
                   shared_ptr<Alibabacloud_OSSUtil::RuntimeOptions> runtime);
  PutObjectAclResponse
  putObjectAcl(shared_ptr<PutObjectAclRequest> request,
               shared_ptr<Alibabacloud_OSSUtil::RuntimeOptions> runtime);
  GetBucketInfoResponse
  getBucketInfo(shared_ptr<GetBucketInfoRequest> request,
                shared_ptr<Alibabacloud_OSSUtil::RuntimeOptions> runtime);
  PutLiveChannelStatusResponse putLiveChannelStatus(
      shared_ptr<PutLiveChannelStatusRequest> request,
      shared_ptr<Alibabacloud_OSSUtil::RuntimeOptions> runtime);
  InitiateMultipartUploadResponse initiateMultipartUpload(
      shared_ptr<InitiateMultipartUploadRequest> request,
      shared_ptr<Alibabacloud_OSSUtil::RuntimeOptions> runtime);
  OptionObjectResponse
  optionObject(shared_ptr<OptionObjectRequest> request,
               shared_ptr<Alibabacloud_OSSUtil::RuntimeOptions> runtime);
  PostVodPlaylistResponse
  postVodPlaylist(shared_ptr<PostVodPlaylistRequest> request,
                  shared_ptr<Alibabacloud_OSSUtil::RuntimeOptions> runtime);
  PostObjectResponse
  postObject(shared_ptr<PostObjectRequest> request,
             shared_ptr<Alibabacloud_OSSUtil::RuntimeOptions> runtime);
  HeadObjectResponse
  headObject(shared_ptr<HeadObjectRequest> request,
             shared_ptr<Alibabacloud_OSSUtil::RuntimeOptions> runtime);
  DeleteObjectTaggingResponse
  deleteObjectTagging(shared_ptr<DeleteObjectTaggingRequest> request,
                      shared_ptr<Alibabacloud_OSSUtil::RuntimeOptions> runtime);
  RestoreObjectResponse
  restoreObject(shared_ptr<RestoreObjectRequest> request,
                shared_ptr<Alibabacloud_OSSUtil::RuntimeOptions> runtime);
  GetObjectAclResponse
  getObjectAcl(shared_ptr<GetObjectAclRequest> request,
               shared_ptr<Alibabacloud_OSSUtil::RuntimeOptions> runtime);
  PutBucketAclResponse
  putBucketAcl(shared_ptr<PutBucketAclRequest> request,
               shared_ptr<Alibabacloud_OSSUtil::RuntimeOptions> runtime);
  DeleteBucketResponse
  deleteBucket(shared_ptr<DeleteBucketRequest> request,
               shared_ptr<Alibabacloud_OSSUtil::RuntimeOptions> runtime);
  PutObjectResponse
  putObject(shared_ptr<PutObjectRequest> request,
            shared_ptr<Alibabacloud_OSSUtil::RuntimeOptions> runtime);
  void setUserAgent(shared_ptr<string> userAgent);
  void appendUserAgent(shared_ptr<string> userAgent);
  string getUserAgent();
  string getAccessKeyId();
  string getAccessKeySecret();

  ~Client() = default;
};
} // namespace Alibabacloud_OSS

#endif
