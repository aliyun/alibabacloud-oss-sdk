#include "gtest/gtest.h"
#include <darabonba/core.hpp>
#include <alibabacloud/ossutil.hpp>
#include <iostream>

using namespace std;

int main(int argc, char **argv) {
  ::testing::InitGoogleTest(&argc, argv);
  return RUN_ALL_TESTS();
}


TEST(test_oss, test_get_err_message)
{
  string xml_str = "<?xml version='1.0' encoding='UTF-8'?><Error><Code>401</Code><Message>msg</Message><RequestId>reqid</RequestId><HostId>hostid</HostId></Error>";
  map<string, boost::any> result = Alibabacloud_OSSUtil::Client::getErrMessage(make_shared<string>(xml_str));
  ASSERT_EQ("401", boost::any_cast<string>(result.at("Code")));
  ASSERT_EQ("msg", boost::any_cast<string>(result.at("Message")));
  ASSERT_EQ("reqid", boost::any_cast<string>(result.at("RequestId")));
  ASSERT_EQ("hostid", boost::any_cast<string>(result.at("HostId")));

  string xml_str1 = "<?xml version='1.0' encoding='UTF-8'?><Code>401</Code>";
  map<string, boost::any> err_msg_map = Alibabacloud_OSSUtil::Client::getErrMessage(make_shared<string>(xml_str1));
  ASSERT_FALSE(err_msg_map.find("Code") != err_msg_map.end());
}

TEST(test_oss, test_to_meta)
{
  shared_ptr<map<string, string>> meta(new map<string, string>({
                                                                   {"size", "1"},
                                                                   {"test.key.id", "9527"}
                                                               }));
  map<string, string> result = Alibabacloud_OSSUtil::Client::toMeta(meta, make_shared<string>("test.key."));
  ASSERT_EQ("9527", result.at("test.key.id"));
  ASSERT_TRUE(result.find("test.key.size") != result.end());
}

TEST(test_oss, test_parse_meta)
{
  shared_ptr<map<string, string>> meta;
  map<string, string> result = Alibabacloud_OSSUtil::Client::parseMeta(meta, make_shared<string>("test.key"));
  ASSERT_TRUE(result.empty());

  meta = make_shared<map<string, string>>(map<string, string>({
                                                                  {"size", "1"},
                                                                  {"test.key.id", "9527"}
                                                              }));
  map<string, string> result1 = Alibabacloud_OSSUtil::Client::parseMeta(meta, make_shared<string>("test.key."));
  ASSERT_EQ("1", result1.at("size"));
  ASSERT_TRUE(result1.find("id") != result1.end());
  ASSERT_EQ("9527", result1.at("id"));
}

TEST(test_oss, test_get_content_type)
{
  ASSERT_EQ("image/webp", Alibabacloud_OSSUtil::Client::getContentType(make_shared<string>("test.webp")));
  ASSERT_EQ("audio/mpeg", Alibabacloud_OSSUtil::Client::getContentType(make_shared<string>("test.mp3")));
}

TEST(test_oss, test_get_content_md5)
{
  ASSERT_EQ("CY9rzUYh03PK3k6DJie09g==", Alibabacloud_OSSUtil::Client::getContentMD5(
      make_shared<string>("test"),
      make_shared<bool>(true)
  ));

  ASSERT_EQ("", Alibabacloud_OSSUtil::Client::getContentMD5(
      make_shared<string>("test"),
      make_shared<bool>(false)
  ));
}

TEST(test_oss, test_encode)
{
  shared_ptr<string> value(new string("test/encode/h%f"));
  shared_ptr<string> encode_type;
  ASSERT_EQ(*value, Alibabacloud_OSSUtil::Client::encode(value, encode_type));
  ASSERT_EQ("test/encode/aCVm", Alibabacloud_OSSUtil::Client::encode(value, make_shared<string>("Base64")));
  ASSERT_EQ("test/encode/h%25f", Alibabacloud_OSSUtil::Client::encode(value, make_shared<string>("UrlEncode")));
  ASSERT_EQ(*value, Alibabacloud_OSSUtil::Client::encode(value, make_shared<string>()));
}

TEST(test_oss, test_decode)
{
  ASSERT_EQ("test", Alibabacloud_OSSUtil::Client::decode(
      make_shared<string>("test"), make_shared<string>()));

  ASSERT_EQ("&2b", Alibabacloud_OSSUtil::Client::decode(
      make_shared<string>("JjJi"), make_shared<string>("Base64Decode")));

  ASSERT_EQ("path/&2b", Alibabacloud_OSSUtil::Client::decode(
      make_shared<string>("path/%262b"), make_shared<string>("UrlDecode")));
}

TEST(test_oss, test_get_host)
{
  shared_ptr<string> bucket_name;
  shared_ptr<string> region_id;
  shared_ptr<string> endpoint;
  shared_ptr<string> host_model;
  ASSERT_EQ(
      "oss-cn-hangzhou.aliyuncs.com",
      Alibabacloud_OSSUtil::Client::getHost(
          bucket_name, region_id, endpoint, host_model
      )
  );

  bucket_name = make_shared<string>("testBucket");
  region_id = make_shared<string>("region");
  endpoint = make_shared<string>("endpoint");
  host_model = make_shared<string>("ip");
  ASSERT_EQ(
      "endpoint/testBucket",
      Alibabacloud_OSSUtil::Client::getHost(
          bucket_name, region_id, endpoint, host_model
      )
  );

  *host_model = "cname";
  ASSERT_EQ(
      "endpoint",
      Alibabacloud_OSSUtil::Client::getHost(
          bucket_name, region_id, endpoint, host_model
      )
  );

  *host_model = "test";
  ASSERT_EQ(
      "testBucket.endpoint",
      Alibabacloud_OSSUtil::Client::getHost(
          bucket_name, region_id, endpoint, host_model
      )
  );
}

TEST(test_oss, test_get_signature_v1)
{
  shared_ptr<Darabonba::Request> request(new Darabonba::Request());
  request->headers = {
      {"x-oss-test", "test"},
      {"content-type", "type"},
      {"content-md5", "md5"},
  };
  request->query = {
      {"testQuery", "testQuery"},
      {"queryKey", "queryValue"},
      {"x-oss-process", "value"},
      {"location", "test"},
  };

  string res = Alibabacloud_OSSUtil::Client::getSignature(
      request,
      make_shared<string>("test"),
      make_shared<string>("ak"),
      make_shared<string>("sk"),
      make_shared<string>("v1"),
      make_shared<vector<string>>()
  );
  ASSERT_EQ("OSS ak:EutyeRVaRDNJSPiaBHmN/Cip8lw=", res);
}

TEST(test_oss, test_get_signature_v2)
{
  ASSERT_EQ(
      "OSS2 AccessKeyId:accessKeyId,Signature:61mT0P8eZxBI5cfj7YfqctSz4Zwtp0sltgTS5JZZc1M=",
      Alibabacloud_OSSUtil::Client::getSignature(
          make_shared<Darabonba::Request>(),
          make_shared<string>("bucket"),
          make_shared<string>("accessKeyId"),
          make_shared<string>("accessKeySecret"),
          make_shared<string>("v2"),
          make_shared<vector<string>>()
      )
  );

  shared_ptr<Darabonba::Request> request(new Darabonba::Request());
  request->pathname = "test?aa";
  request->headers = {
      {"x-oss-test", "test"},
      {"content-type", "type"},
      {"content-md5", "md5"}
  };
  request->query = {
      {"testQuery", "testQuery"},
      {"queryKey", "queryValue"},
      {"x-oss-test", "test"}
  };
  ASSERT_EQ(
      "OSS2 AccessKeyId:ak,AdditionalHeaders:headers;sign2,Signature:l8RDYSFtqTP0NhyoTyrRqAtrnUO6lCjrOF/MK2zV0nU=",
      Alibabacloud_OSSUtil::Client::getSignature(
          request,
          make_shared<string>("test"),
          make_shared<string>("ak"),
          make_shared<string>("sk"),
          make_shared<string>("v2"),
          make_shared<vector<string>>(vector<string>({"headers", "sign2"}))
      )
  );

  request->pathname = "test?zz";
  ASSERT_EQ(
      "OSS2 AccessKeyId:ak,AdditionalHeaders:headers,Signature:kbg4BGoZbDGm2OBRt1kOTh9z6dToFSg1L55PXTmGdQw=",
      Alibabacloud_OSSUtil::Client::getSignature(
          request,
          make_shared<string>("test"),
          make_shared<string>("ak"),
          make_shared<string>("sk"),
          make_shared<string>("v2"),
          make_shared<vector<string>>(vector<string>({"headers"}))
      )
  );
}

TEST(test_oss, test_inject)
{
  shared_ptr<map<string, string>> ctx;
  ctx = make_shared<map<string, string>>();

  shared_ptr<Darabonba::Stream> body = Alibabacloud_OSSUtil::Client::inject(
      make_shared<Darabonba::Stream>(make_shared<stringstream>("test")),
      ctx
  );
  ASSERT_EQ("test", body->read());
  ASSERT_EQ("CY9rzUYh03PK3k6DJie09g==", ctx->at("md5"));
  ASSERT_EQ("18020588380933092773", ctx->at("crc"));
}
