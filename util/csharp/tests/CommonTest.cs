using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using AlibabaCloud.OSSUtil;
using Moq;
using Tea;
using tests.Models;
using Xunit;
using static tests.Models.ListAllMyBucketsResult;
using static tests.Models.ListAllMyBucketsResult.Buckets;

namespace tests
{
    public class CommonTest
    {

        [Fact]
        public void Test_GetErrmessage()
        {
            string message = "<?xml version=\"1.0\" encoding=\"utf-8\" standalone=\"no\"?><num>10</num>";

            Assert.Null(Common.GetErrMessage(message));
        }

        [Fact]
        public void Test_ToQuery()
        {
            Dictionary<string, object> dict = new Dictionary<string, object>();
            dict.Add("testKey", "testValue");
            dict.Add("testNull", null);
            Dictionary<string, string> dictQuery = Common.ToQuery(dict);
            Assert.NotNull(dictQuery);
            Assert.Equal("testValue", dictQuery["testKey"]);
        }

        [Fact]
        public void Test_ToMeta()
        {
            Assert.Empty(Common.ToMeta(null, null));

            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("testKey", "testValue");
            dict.Add("k", "v");
            Dictionary<string, string> dictResult = Common.ToMeta(dict, "test");
            Assert.NotNull(dictResult);
            Assert.Equal("testk", dictResult.Keys.ToList()[1]);
        }

        [Fact]
        public void Test_ParseMeta()
        {
            Assert.Empty(Common.ParseMeta(null, null));

            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("testKey", "testValue");
            dict.Add("k", "v");
            Dictionary<string, string> dictResult = Common.ParseMeta(dict, "test");
            Assert.NotNull(dictResult);
            Assert.Equal("Key", dictResult.Keys.ToList()[0]);
        }

        [Fact]
        public void Test_GetContentType()
        {
            Assert.Equal("text/plain", Common.GetContentType("test.txt"));

            Assert.Equal("model/mesh", Common.GetContentType("test.silo"));
        }

        [Fact]
        public void TestGetContentMD5()
        {
            string oss = "oss";

            Assert.Empty(Common.GetContentMD5(oss, false));

            string md5 = Common.GetContentMD5(oss, true);
            Assert.NotNull(md5);
        }

        [Fact]
        public void Test_Encode()
        {
            Assert.Equal("/b3Nz", Common.Encode("/oss", "Base64"));

            Assert.Equal("/oss", Common.Encode("/oss", "UrlEncode"));
        }

        [Fact]
        public void Test_GetUserAgent()
        {
            Assert.NotNull(Common.GetUserAgent(null));

            Assert.Contains("appendUserAgent", Common.GetUserAgent("appendUserAgent"));

        }

        [Fact]
        public void Test_GetHost()
        {
            string host = Common.GetHost("testBucket", null, null, null);
            Assert.Equal("testBucket.oss-cn-hangzhou.aliyuncs.com", host);

            host = Common.GetHost("testBucket", null, null, "ip");
            Assert.Equal("oss-cn-hangzhou.aliyuncs.com/testBucket", host);

            host = Common.GetHost("testBucket", null, null, "cname");
            Assert.Equal("oss-cn-hangzhou.aliyuncs.com", host);

            host = Common.GetHost(null, null, null, "cname");
            Assert.Equal("oss-cn-hangzhou.aliyuncs.com", host);
        }

        [Fact]
        public void Test_Inject()
        {
            Assert.NotNull(Common.Inject(new MemoryStream(), new Dictionary<string, string>()));
        }

        [Fact]
        public void Test_GetSignedStrV1()
        {
            TeaRequest request = new TeaRequest();
            request.Method = "GET";
            request.Headers.Add("test", null);
            request.Headers.Add("x-oss-test", "test");
            string result = Common.GetSignedStrV1(request, "test", "sk");
            Assert.Equal("VVpCxhs5fWxzPsVpaNqiPr1iXEE=", result);

            request.Headers.Add("content-type", "type");
            request.Headers.Add("content-md5", "md5");
            result = Common.GetSignedStrV1(request, "test", "sk");
            Assert.Equal("MSexwBJvDwWazzrX9GV3mlsjI0g=", result);
        }

        [Fact]
        public void Test_GetSignatureV1()
        {
            TeaRequest request = new TeaRequest();
            request.Method = "GET";
            request.Headers.Add("x-oss-test", "test");
            request.Headers.Add("content-type", "type");
            request.Headers.Add("content-md5", "md5");
            request.Query.Add("testQuery", "testQuery");
            request.Query.Add("queryKey", "queryValue");
            request.Query.Add("x-oss-process", "value");

            string result = Common.GetSignatureV1(request, "test", "sk");
            Assert.Equal("q9lSDGVH1VmpjMTGSwUZn3tg3J4=", result);
        }

        [Fact]
        public void Test_GetSignatureV2()
        {
            TeaRequest request = new TeaRequest();
            request.Method = "GET";
            request.Pathname = "test?aa";
            request.Headers.Add("x-oss-test", "test");
            request.Headers.Add("content-type", "type");
            request.Headers.Add("content-md5", "md5");
            request.Query.Add("testQuery", "testQuery");
            request.Query.Add("querykey", "queryValue");
            request.Query.Add("x-oss-test", "test");

            string result = Common.GetSignatureV2(request, "test", "sk", new List<string> { "querykey" });
            Assert.Equal("NTrErwnblTk2y8h/NJKCcPCr73iRTfcl99PEc1fCgZY=", result);
        }

        [Fact]
        public void Test_GetSignature()
        {
            TeaRequest requestV1 = new TeaRequest();
            requestV1.Method = "GET";
            requestV1.Headers.Add("x-oss-test", "test");
            requestV1.Headers.Add("content-type", "type");
            requestV1.Headers.Add("content-md5", "md5");
            requestV1.Query.Add("testQuery", "testQuery");
            requestV1.Query.Add("queryKey", "queryValue");
            requestV1.Query.Add("x-oss-process", "value");

            string result = Common.GetSignature(requestV1, "test", "ak", "sk", "v1", null);
            Assert.Equal("OSS ak:q9lSDGVH1VmpjMTGSwUZn3tg3J4=", result);

            TeaRequest requestV2 = new TeaRequest();
            requestV2.Method = "GET";
            requestV2.Pathname = "test?aa";
            requestV2.Headers.Add("x-oss-test", "test");
            requestV2.Headers.Add("content-type", "type");
            requestV2.Headers.Add("content-md5", "md5");
            requestV2.Query.Add("testQuery", "testQuery");
            requestV2.Query.Add("querykey", "queryValue");
            requestV2.Query.Add("x-oss-test", "test");

            string resultV2 = Common.GetSignature(requestV2, "test", "ak", "sk", "v2", null);
            Assert.Equal("OSS2 AccessKeyId:ak,Signature:8ZVVQOOgBTR2pRklfYiV7stmckZ9jVM6sT01So44was=", resultV2);

            resultV2 = Common.GetSignature(requestV2, "test", "ak", "sk", "v2", new List<string> { "querykey" });
            Assert.Equal("OSS2 AccessKeyId:ak,AdditionalHeaders:querykey,Signature:NTrErwnblTk2y8h/NJKCcPCr73iRTfcl99PEc1fCgZY=", resultV2);
        }

        [Fact]
        public void Test_Decode()
        {
            Assert.Equal(3, Common.Decode("afff", "Base64Decode").Length);

            Assert.Equal(4, Common.Decode("afff", "UrlDecode").Length);

            Assert.Equal("afff", Common.Decode("afff", null));
        }

        [Fact]
        public void Test_UriEncode()
        {
            Assert.Equal("a%7BA%5B0%3A/_", Common.UriEncode("a{A[0:/_", false));

            Assert.Equal("a%7BA%5B0%3A%2F_", Common.UriEncode("a{A[0:/_", true));
        }
    }
}
