using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;

using AlibabaCloud.OSS;

using Aliyun.Credentials;
using Aliyun.Credentials.Utils;

using Moq;

using Tea;

using unitTest.Models;

using Xunit;
using static unitTest.Models.ListAllMyBucketsResult;
using static unitTest.Models.ListAllMyBucketsResult.Buckets;

namespace unitTest
{
    public class BaseClientTest
    {
        public Dictionary<string, object> config;

        public BaseClient baseClient;
        public BaseClientTest()
        {
            config = new Dictionary<string, object>();
            config.Add("accessKeyId", "accessKeyId");
            config.Add("accessKeySecret", "accessKeySecret");
            config.Add("securityToken", "securityToken");
            config.Add("type", AuthConstant.Sts);
            baseClient = new BaseClient(config);
        }

        [Fact]
        public void TestProperties()
        {
            BaseClient baseClientPorp = new BaseClient(config);
            baseClientPorp.AddtionalHeaders = new string[] { "test" };
            Assert.Equal("test", baseClientPorp.AddtionalHeaders[0]);
            baseClientPorp.SignatureVersion = "test";
            Assert.Equal("test", baseClientPorp.SignatureVersion);
        }

        [Fact]
        public void TestSetCredential()
        {
            Dictionary<string, object> configTypeNull = new Dictionary<string, object>();
            configTypeNull.Add("accessKeyId", "accessKeyId");
            configTypeNull.Add("accessKeySecret", "accessKeySecret");
            configTypeNull.Add("securityToken", "securityToken");
            BaseClient baseClientTypeNull = new BaseClient(configTypeNull);

            Assert.Equal(AuthConstant.AccessKey, baseClientTypeNull.credential.Type);
        }

        [Fact]
        public void TestGetAuth()
        {
            Credential origincredential = baseClient.credential;
            baseClient.credential = null;
            TeaRequest request = new TeaRequest();
            string authEmpty = (string) TestHelper.RunInstanceMethod(typeof(BaseClient), "_getAuth", baseClient, new object[] { request, "oss" });
            Assert.Empty(authEmpty);

            baseClient.credential = origincredential;
            string auth = (string) TestHelper.RunInstanceMethod(typeof(BaseClient), "_getAuth", baseClient, new object[] { request, "oss" });
            Assert.Equal("OSS accessKeyId:OVuXr5THk6VcE/2U78ukqMl032w=", auth);

            baseClient.SignatureVersion = "V2";
            request.Headers = new Dictionary<string, string>();
            string authV2 = (string) TestHelper.RunInstanceMethod(typeof(BaseClient), "_getAuth", baseClient, new object[] { request, "oss" });
            Assert.Equal("OSS2 AccessKeyId:accessKeyId,Signature:ec99QpyH6hbQIJAJayQksSGkXcepQw5vfsw9zik0tkA=", authV2);

        }

        [Fact]
        public void TestDefaultNumber()
        {
            Assert.Equal(0, (int) TestHelper.RunInstanceMethod(typeof(BaseClient), "_defaultNumber", baseClient, new object[] {-1, 0 }));

            Assert.Equal(1, (int) TestHelper.RunInstanceMethod(typeof(BaseClient), "_defaultNumber", baseClient, new object[] { 1, 0 }));
        }

        [Fact]
        public void TestDefault()
        {
            Assert.Equal("default", (string) TestHelper.RunInstanceMethod(typeof(BaseClient), "_default", baseClient, new object[] { string.Empty, "default" }));

            Assert.Equal("inputStr", (string) TestHelper.RunInstanceMethod(typeof(BaseClient), "_default", baseClient, new object[] { "inputStr", "default" }));
        }

        [Fact]
        public void TestGetDate()
        {
            string Date = (string) TestHelper.RunInstanceMethod(typeof(BaseClient), "_getDate", baseClient, null);
            Assert.NotNull(Date);
        }

        [Fact]
        public void TestGetContentMD5()
        {
            TeaRequest teaRequest = new TeaRequest();
            string oss = "oss";
            byte[] bytes = Encoding.UTF8.GetBytes(oss);
            MemoryStream stream = new MemoryStream();
            stream.Write(bytes, 0, bytes.Length);
            stream.Seek(0, SeekOrigin.Begin);
            teaRequest.Body = stream;

            Assert.Empty((string) TestHelper.RunInstanceMethod(typeof(BaseClient), "_getContentMD5", baseClient, new object[] { teaRequest, string.Empty, 0 }));

            BindingFlags InstanceBindFlags = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic;
            Type type = typeof(BaseClient);
            var filed = type.GetField("_isEnableMD5", InstanceBindFlags);
            filed.SetValue(baseClient, true);

            Assert.Equal("md5", (string) TestHelper.RunInstanceMethod(typeof(BaseClient), "_getContentMD5", baseClient, new object[] { teaRequest, "md5", 0 }));

            string md5 = (string) TestHelper.RunInstanceMethod(typeof(BaseClient), "_getContentMD5", baseClient, new object[] { teaRequest, string.Empty, 0 });
            Assert.NotNull(md5);

            teaRequest.Body = null;
            Assert.Empty((string) TestHelper.RunInstanceMethod(typeof(BaseClient), "_getContentMD5", baseClient, new object[] { teaRequest, string.Empty, 0 }));
        }

        [Fact]
        public void TestToBody()
        {
            TeaModel modelNull = new TeaModel();
            Assert.Empty((string) TestHelper.RunInstanceMethod(typeof(BaseClient), "_toBody", baseClient, new object[] { modelNull }));

            ToBodyModel model = new ToBodyModel();
            ListAllMyBucketsResult result = new ListAllMyBucketsResult();
            Buckets buckets = new Buckets();
            buckets.bucket = new List<Bucket>();
            buckets.bucket.Add(new Bucket { CreationDate = "2015-12-17T18:12:43.000Z", ExtranetEndpoint = "oss-cn-shanghai.aliyuncs.com", IntranetEndpoint = "oss-cn-shanghai-internal.aliyuncs.com", Location = "oss-cn-shanghai", Name = "app-base-oss", StorageClass = "Standard" });
            buckets.bucket.Add(new Bucket { CreationDate = "2014-12-25T11:21:04.000Z", ExtranetEndpoint = "oss-cn-hangzhou.aliyuncs.com", IntranetEndpoint = "oss-cn-hangzhou-internal.aliyuncs.com", Location = "oss-cn-hangzhou", Name = "atestleo23", StorageClass = "IA" });
            buckets.bucket.Add(null);
            result.buckets = buckets;
            Owner owner = new Owner { ID = 512, DisplayName = "51264" };
            result.owner = owner;
            model.listAllMyBucketsResult = result;
            model.listAllMyBucketsResult.testStrList = new List<string> { "1", "2" };
            model.listAllMyBucketsResult.owners = new List<Owner>();
            model.listAllMyBucketsResult.owners.Add(owner);
            model.listAllMyBucketsResult.TestDouble = 1;
            model.listAllMyBucketsResult.TestFloat = 2;
            model.listAllMyBucketsResult.TestLong = 3;
            model.listAllMyBucketsResult.TestShort = 4;
            model.listAllMyBucketsResult.TestUInt = 5;
            model.listAllMyBucketsResult.TestULong = 6;
            model.listAllMyBucketsResult.TestUShort = 7;
            model.listAllMyBucketsResult.TestBool = true;
            model.listAllMyBucketsResult.TestNull = null;
            model.listAllMyBucketsResult.TestListNull = null;
            string xmlStr = (string) TestHelper.RunInstanceMethod(typeof(BaseClient), "_toBody", baseClient, new object[] { model });
            Assert.NotNull(xmlStr);

            Mock<HttpWebResponse> mockHttpWebResponse = new Mock<HttpWebResponse>();
            mockHttpWebResponse.Setup(p => p.StatusCode).Returns(HttpStatusCode.OK);
            mockHttpWebResponse.Setup(p => p.StatusDescription).Returns("StatusDescription");
            mockHttpWebResponse.Setup(p => p.Headers).Returns(new WebHeaderCollection());
            byte[] array = Encoding.UTF8.GetBytes(xmlStr);
            MemoryStream stream = new MemoryStream(array);
            mockHttpWebResponse.Setup(p => p.GetResponseStream()).Returns(stream);
            TeaResponse teaResponse = new TeaResponse(mockHttpWebResponse.Object);
            Dictionary<string, object> xmlBody = (Dictionary<string, object>) TestHelper.RunInstanceMethod(typeof(BaseClient), "_parseXml", baseClient, new object[] { teaResponse, typeof(ToBodyModel) });
            ToBodyModel teaModel = TeaModel.ToObject<ToBodyModel>(xmlBody);
            Assert.NotNull(teaModel);
            Assert.Equal(1, teaModel.listAllMyBucketsResult.TestDouble);
        }

        [Fact]
        public void TestGetHost()
        {
            BaseClient getHostClient = new BaseClient(config);
            string host = (string) TestHelper.RunInstanceMethod(typeof(BaseClient), "_getHost", getHostClient, new object[] { "testBucket" });
            Assert.Equal("testBucket.oss-cn-hangzhou.aliyuncs.com", host);

            BindingFlags InstanceBindFlags = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic;
            Type type = typeof(BaseClient);
            var filed = type.GetField("_hostModel", InstanceBindFlags);
            filed.SetValue(getHostClient, "ip");
            host = (string) TestHelper.RunInstanceMethod(typeof(BaseClient), "_getHost", getHostClient, new object[] { "testBucket" });
            Assert.Equal("oss-cn-hangzhou.aliyuncs.com/testBucket", host);

            filed.SetValue(getHostClient, "cname");
            host = (string) TestHelper.RunInstanceMethod(typeof(BaseClient), "_getHost", getHostClient, new object[] { "testBucket" });
            Assert.Equal("oss-cn-hangzhou.aliyuncs.com", host);

            host = (string) TestHelper.RunInstanceMethod(typeof(BaseClient), "_getHost", getHostClient, new object[] { null });
            Assert.Equal("oss-cn-hangzhou.aliyuncs.com", host);
        }

        [Fact]
        public void TestIsFail()
        {
            Mock<HttpWebResponse> mockHttpWebResponse = new Mock<HttpWebResponse>();
            mockHttpWebResponse.Setup(p => p.StatusCode).Returns(HttpStatusCode.OK);
            mockHttpWebResponse.Setup(p => p.StatusDescription).Returns("StatusDescription");
            mockHttpWebResponse.Setup(p => p.Headers).Returns(new WebHeaderCollection());
            byte[] array = Encoding.UTF8.GetBytes("test");
            MemoryStream stream = new MemoryStream(array);
            mockHttpWebResponse.Setup(p => p.GetResponseStream()).Returns(stream);
            TeaResponse teaResponse = new TeaResponse(mockHttpWebResponse.Object);
            Assert.False((bool) TestHelper.RunInstanceMethod(typeof(BaseClient), "_isFail", baseClient, new object[] { teaResponse }));

            mockHttpWebResponse.Setup(p => p.StatusCode).Returns(HttpStatusCode.NotFound);
            teaResponse = new TeaResponse(mockHttpWebResponse.Object);
            Assert.True((bool) TestHelper.RunInstanceMethod(typeof(BaseClient), "_isFail", baseClient, new object[] { teaResponse }));
        }

        [Fact]
        public void TestToQuery()
        {
            Dictionary<string, object> dict = new Dictionary<string, object>();
            dict.Add("testKey", "testValue");
            dict.Add("testNull", null);
            Dictionary<string, string> dictQuery = (Dictionary<string, string>) TestHelper.RunInstanceMethod(typeof(BaseClient), "_toQuery", baseClient, new object[] { dict });
            Assert.NotNull(dictQuery);
            Assert.Equal("testValue", dictQuery["testKey"]);
        }

        [Fact]
        public void TestToMeta()
        {
            Assert.Empty((Dictionary<string, string>) TestHelper.RunInstanceMethod(typeof(BaseClient), "_toMeta", baseClient, new object[] { null, null }));

            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("testKey", "testValue");
            dict.Add("k", "v");
            Dictionary<string, string> dictResult = (Dictionary<string, string>) TestHelper.RunInstanceMethod(typeof(BaseClient), "_toMeta", baseClient, new object[] { dict, "test" });
            Assert.NotNull(dictResult);
            Assert.Equal("testk", dictResult.Keys.ToList() [1]);
        }

        [Fact]
        public void TestParseMeta()
        {
            Assert.Empty((Dictionary<string, string>) TestHelper.RunInstanceMethod(typeof(BaseClient), "_parseMeta", baseClient, new object[] { null, null }));

            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("testKey", "testValue");
            dict.Add("k", "v");
            Dictionary<string, string> dictResult = (Dictionary<string, string>) TestHelper.RunInstanceMethod(typeof(BaseClient), "_parseMeta", baseClient, new object[] { dict, "test" });
            Assert.NotNull(dictResult);
            Assert.Equal("Key", dictResult.Keys.ToList() [0]);
        }

        [Fact]
        public void TestGetContentLength()
        {
            TeaRequest teaRequest = new TeaRequest();
            string oss = "oss";
            byte[] bytes = Encoding.UTF8.GetBytes(oss);
            MemoryStream stream = new MemoryStream();
            stream.Write(bytes, 0, bytes.Length);
            stream.Seek(0, SeekOrigin.Begin);
            teaRequest.Body = stream;

            Assert.Equal("1024", (string) TestHelper.RunInstanceMethod(typeof(BaseClient), "_getContentLength", baseClient, new object[] { teaRequest, "1024" }));

            Assert.Equal("3", (string) TestHelper.RunInstanceMethod(typeof(BaseClient), "_getContentLength", baseClient, new object[] { teaRequest, string.Empty }));
        }

        [Fact]
        public void TestGetSpecialValue()
        {
            var obj = new
            {
                testKey = "testValue"
            };
            Assert.Equal("testValue", (string) TestHelper.RunInstanceMethod(typeof(BaseClient), "_getSpecialValue", baseClient, new object[] { obj, "testKey" }));
        }

        [Fact]
        public void TestGetContentType()
        {
            Assert.Equal("text/plain", (string) TestHelper.RunInstanceMethod(typeof(BaseClient), "_getContentType", baseClient, new object[] { "test.txt" }));

            Assert.Equal("model/mesh", (string) TestHelper.RunInstanceMethod(typeof(BaseClient), "_getContentType", baseClient, new object[] { "test.silo" }));
        }

        [Fact]
        public void TestIsEnableCrc()
        {
            Assert.False((bool) TestHelper.RunInstanceMethod(typeof(BaseClient), "_isNotCrcMatched", baseClient, new object[] { 1UL, string.Empty }));

            BindingFlags InstanceBindFlags = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic;
            Type type = typeof(BaseClient);
            var filed = type.GetField("_isEnableCrc", InstanceBindFlags);
            filed.SetValue(baseClient, true);

            Assert.False((bool) TestHelper.RunInstanceMethod(typeof(BaseClient), "_isNotCrcMatched", baseClient, new object[] { 1UL, string.Empty }));

            Assert.True((bool) TestHelper.RunInstanceMethod(typeof(BaseClient), "_isNotCrcMatched", baseClient, new object[] { 1UL, "1" }));
        }

        [Fact]
        public void TestEncode()
        {
            Assert.Equal("/b3Nz", (string) TestHelper.RunInstanceMethod(typeof(BaseClient), "_encode", baseClient, new object[] { "/oss", "Base64" }));

            Assert.Equal("/oss", (string) TestHelper.RunInstanceMethod(typeof(BaseClient), "_encode", baseClient, new object[] { "/oss", "UrlEncode" }));
        }

        [Fact]
        public void TestBase64Decode()
        {
            string str = (string) TestHelper.RunInstanceMethod(typeof(BaseClient), "_base64Decode", baseClient, new object[] { "afff" });
            Assert.Equal(3, str.Length);
        }

        [Fact]
        public void TestUrlDecode()
        {
            string str = (string) TestHelper.RunInstanceMethod(typeof(BaseClient), "_urlDecode", baseClient, new object[] { "afff" });
            Assert.Equal(4, str.Length);
        }

        [Fact]
        public void TestParseUint()
        {
            ulong u = (ulong) TestHelper.RunInstanceMethod(typeof(BaseClient), "_parseUint", baseClient, new object[] { "respCrc", true });
            Assert.Equal(0. ToString(), u.ToString());

            ulong uCatch = (ulong) TestHelper.RunInstanceMethod(typeof(BaseClient), "_parseUint", baseClient, new object[] { "respCrc", false });
            Assert.Equal(0. ToString(), uCatch.ToString());

            ulong uParse = (ulong) TestHelper.RunInstanceMethod(typeof(BaseClient), "_parseUint", baseClient, new object[] { "64", false });
            Assert.Equal(64. ToString(), uParse.ToString());
        }

        [Fact]
        public void TestGetUserAgent()
        {
            Assert.NotNull(baseClient._getUserAgent());

            baseClient._appendUserAgent("");
            baseClient._appendUserAgent("appendUserAgent");
            Assert.Contains("appendUserAgent", baseClient._getUserAgent());

            baseClient._setUserAgent("setUserAgent");
            Assert.DoesNotContain("appendUserAgent", baseClient._getUserAgent());
            Assert.Contains("setUserAgent", baseClient._getUserAgent());

            baseClient._appendUserAgent("append");
            Assert.Contains("setUserAgent", baseClient._getUserAgent());
            Assert.Contains("append", baseClient._getUserAgent());
        }

        [Fact]
        public void TestGetErrmessage()
        {
            Mock<HttpWebResponse> mockHttpWebResponse = new Mock<HttpWebResponse>();
            mockHttpWebResponse.Setup(p => p.StatusCode).Returns(HttpStatusCode.OK);
            mockHttpWebResponse.Setup(p => p.StatusDescription).Returns("StatusDescription");
            mockHttpWebResponse.Setup(p => p.Headers).Returns(new WebHeaderCollection());
            byte[] array = Encoding.UTF8.GetBytes("<?xml version=\"1.0\" encoding=\"utf-8\" standalone=\"no\"?><num>10</num>");
            MemoryStream stream = new MemoryStream(array);
            mockHttpWebResponse.Setup(p => p.GetResponseStream()).Returns(stream);
            TeaResponse teaResponse = new TeaResponse(mockHttpWebResponse.Object);

            Assert.Null((Dictionary<string, object>) TestHelper.RunInstanceMethod(typeof(BaseClient), "_getErrMessage", baseClient, new object[] { teaResponse }));
        }

        [Fact]
        public void TestToHeader()
        {
            Dictionary<string, object> dict = new Dictionary<string, object>();
            dict.Add("keyNull", null);
            dict.Add("key", "value");
            Assert.Single((Dictionary<string, string>) TestHelper.RunInstanceMethod(typeof(BaseClient), "_toHeader", baseClient, new object[] { dict }));
        }

        [Fact]
        public void TestReadAsStream()
        {
            Mock<HttpWebResponse> mockHttpWebResponse = new Mock<HttpWebResponse>();
            mockHttpWebResponse.Setup(p => p.StatusCode).Returns(HttpStatusCode.OK);
            mockHttpWebResponse.Setup(p => p.StatusDescription).Returns("StatusDescription");
            mockHttpWebResponse.Setup(p => p.Headers).Returns(new WebHeaderCollection());
            byte[] array = Encoding.UTF8.GetBytes("test");
            MemoryStream stream = new MemoryStream(array);
            mockHttpWebResponse.Setup(p => p.GetResponseStream()).Returns(stream);
            TeaResponse teaResponse = new TeaResponse(mockHttpWebResponse.Object);

            Stream testStream = (Stream) TestHelper.RunInstanceMethod(typeof(BaseClient), "_readAsStream", baseClient, new object[] { teaResponse });
            Assert.Equal(4, testStream.Length);

            TeaResponse teaResponseNull = new TeaResponse(null);
            Assert.Null(TestHelper.RunInstanceMethod(typeof(BaseClient), "_readAsStream", baseClient, new object[] { teaResponseNull }));

        }

        [Fact]
        public void TestUriEncode()
        {
            Assert.Equal("a%7BA%5B0%3A/_", baseClient.UriEncode("a{A[0:/_", false));

            Assert.Equal("a%7BA%5B0%3A%2F_", baseClient.UriEncode("a{A[0:/_", true));
        }
    }
}
