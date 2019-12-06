using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

using AlibabaCloud.OSS;
using AlibabaCloud.OSS.Utils;

using Aliyun.Credentials;
using Aliyun.Credentials.Utils;

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
            BindingFlags InstanceBindFlags = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic;
            Type type = typeof(BaseClient);
            var filed = type.GetField("_isEnableMD5", InstanceBindFlags);
            filed.SetValue(baseClient, true);
            TeaRequest teaRequest = new TeaRequest();
            string oss = "oss";
            byte[] bytes = Encoding.UTF8.GetBytes(oss);
            MemoryStream stream = new MemoryStream();
            stream.Write(bytes, 0, bytes.Length);
            stream.Seek(0, SeekOrigin.Begin);
            teaRequest.Body = stream;
            string md5 = (string) TestHelper.RunInstanceMethod(typeof(BaseClient), "_getContentMD5", baseClient, new object[] { teaRequest, string.Empty, 0 });
        }

        [Fact]
        public void TestToBody()
        {
            ToBodyModel model = new ToBodyModel();
            ListAllMyBucketsResult result = new ListAllMyBucketsResult();
            Buckets buckets = new Buckets();
            buckets.bucket = new List<Bucket>();
            buckets.bucket.Add(new Bucket { CreationDate = "2015-12-17T18:12:43.000Z", ExtranetEndpoint = "oss-cn-shanghai.aliyuncs.com", IntranetEndpoint = "oss-cn-shanghai-internal.aliyuncs.com", Location = "oss-cn-shanghai", Name = "app-base-oss", StorageClass = "Standard" });
            buckets.bucket.Add(new Bucket { CreationDate = "2014-12-25T11:21:04.000Z", ExtranetEndpoint = "oss-cn-hangzhou.aliyuncs.com", IntranetEndpoint = "oss-cn-hangzhou-internal.aliyuncs.com", Location = "oss-cn-hangzhou", Name = "atestleo23", StorageClass = "IA" });
            result.buckets = buckets;
            Owner owner = new Owner { ID = 512, DisplayName = "51264" };
            result.owner = owner;
            model.listAllMyBucketsResult = result;
            model.listAllMyBucketsResult.testStrList = new List<string> { "1", "2" };
            model.listAllMyBucketsResult.owners = new List<Owner>();
            model.listAllMyBucketsResult.owners.Add(owner);
            string xmlStr = (string) TestHelper.RunInstanceMethod(typeof(BaseClient), "_toBody", baseClient, new object[] { model });

            Dictionary<string, object> xmlBody = XmlUtil.DeserializeXml(xmlStr, typeof(ToBodyModel));

            ToBodyModel teaModel = TeaModel.ToObject<ToBodyModel>(xmlBody);
        }
    }
}
