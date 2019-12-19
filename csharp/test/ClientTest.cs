using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

using AlibabaCloud.OSS;
using AlibabaCloud.OSS.Models;

using Xunit;
using static AlibabaCloud.OSS.Models.PutObjectRequest;

namespace test
{
    public class ClientTest
    {
        Config config;
        RuntimeObject runtime;
        Client client;
        string bucketName = "sdk-oss-test";
        //string objectName = "obj_Csharp";
        //string destObj = "desobj_Csharp";
        //string initObj = "init_Csharp";
        string appendObj = "append_Csharp.txt";
        //string sourceObj = "source_Csharp.txt";
        //string uploadId = "";

        public ClientTest()
        {
            List<string> a = new List<string> { { "1" }, { "2" } };
            config = new Config
            {
                AccessKeyId = Environment.GetEnvironmentVariable("ACCESS_KEY_ID"),
                AccessKeySecret = Environment.GetEnvironmentVariable("ACCESS_KEY_SECRET"),
                Type = "ACCESS_KEY"
            };

            runtime = new RuntimeObject
            {
                Md5Threshold = 1000,
                MaxIdleConns = 3
            };
            client = new Client(config);
            client.SignatureVersion = "V2";
        }

        [Fact]
        public void Test_putBucketLifecycle()
        {
            PutBucketLifecycleRequest request = new PutBucketLifecycleRequest();
            request.BucketName = bucketName;
            request.Body = new PutBucketLifecycleRequest.PutBucketLifecycleRequestBody
            {
                LifecycleConfiguration = new PutBucketLifecycleRequest.PutBucketLifecycleRequestBody.PutBucketLifecycleRequestLifecycleConfiguration
                {
                Rule = new List<PutBucketLifecycleRequest.PutBucketLifecycleRequestBody.PutBucketLifecycleRequestLifecycleConfiguration.PutBucketLifecycleRequestRule>
                {
                new PutBucketLifecycleRequest.PutBucketLifecycleRequestBody.PutBucketLifecycleRequestLifecycleConfiguration.PutBucketLifecycleRequestRule
                {
                ID = "1",
                Prefix = "Prefix",
                Status = "Disabled",
                Expiration = new PutBucketLifecycleRequest.PutBucketLifecycleRequestBody.PutBucketLifecycleRequestLifecycleConfiguration.PutBucketLifecycleRequestRule.PutBucketLifecycleRequestExpiration
                {
                Days = 1
                }
                }
                }
                }
            };

            var response = client.putBucketLifecycle(request, runtime);
            Assert.NotNull(response);
        }

        [Fact]
        public void Test_putBucketReferer()
        {
            PutBucketRefererRequest request = new PutBucketRefererRequest
            {
                BucketName = bucketName,
                Body = new PutBucketRefererRequest.PutBucketRefererRequestBody
                {
                RefererConfiguration = new PutBucketRefererRequest.PutBucketRefererRequestBody.PutBucketRefererRequestRefererConfiguration
                {
                AllowEmptyReferer = true,
                RefererList = new PutBucketRefererRequest.PutBucketRefererRequestBody.PutBucketRefererRequestRefererConfiguration.PutBucketRefererRequestRefererList
                {
                Referer = new List<string>
                {
                "test"
                }
                }
                }
                }
            };

            var response = client.putBucketReferer(request, runtime);
            Assert.NotNull(response);
            Assert.NotNull(response.RequestId);
        }

        [Fact]
        public void Test_getBucketReferer()
        {
            GetBucketRefererRequest request = new GetBucketRefererRequest
            {
                BucketName = bucketName
            };
            var response = client.getBucketReferer(request, runtime);
            Assert.NotNull(response);
            Assert.NotNull(response.RequestId);
        }

        //[Fact]
        //public void Test_GetBucketInfo()
        //{
        //    GetBucketInfoRequest request = new GetBucketInfoRequest();
        //    request.BucketName = bucketName;

        //    client.AddtionalHeaders = new string[] { "host" };
        //    var response = client.GetBucketInfo(request, runtime);

        //    Assert.NotNull(response);
        //    Assert.NotNull(response.BucketInfo);
        //    Assert.Equal(24, response.RequestId.Length);
        //}

        //[Fact]
        //public void Test_PutBucketAcl()
        //{
        //    PutBucketAclRequestHeader header = new PutBucketAclRequestHeader();
        //    header.Acl = "public-read";
        //    PutBucketAclRequest request = new PutBucketAclRequest();
        //    request.BucketName = bucketName;
        //    request.Header = header;
        //    var response = client.PutBucketAcl(request, runtime);
        //    Assert.NotNull(response);
        //    Assert.Equal(24, response.RequestId.Length);
        //}

        //[Fact]
        //public void Test_GetBucket()
        //{
        //    GetBucketRequest request = new GetBucketRequest()
        //    {
        //        BucketName = bucketName
        //    };

        //    var response = client.GetBucket(request, runtime);
        //    Assert.NotNull(response);
        //    Assert.NotNull(response.RequestId);
        //    Assert.NotNull(response.ListBucketResult);
        //}

        //[Fact]
        //public void Test_GetBucketLogging()
        //{
        //    GetBucketLoggingRequest request = new GetBucketLoggingRequest()
        //    {
        //        BucketName = bucketName,
        //    };
        //    var response = client.GetBucketLogging(request, runtime);
        //    Assert.NotNull(response.RequestId);

        //}

        //[Fact]
        //public void Test_GetBucketLoggingWithError()
        //{
        //    Config configErr = new Config
        //    {
        //        AccessKeyId = "accessKeyId",
        //        AccessKeySecret = "accessSecret"
        //    };
        //    Client clientErr = new Client(configErr);
        //    GetBucketLoggingRequest request = new GetBucketLoggingRequest
        //    {
        //        BucketName = bucketName
        //    };
        //    Assert.Throws<TeaUnretryableException>(() => { clientErr.GetBucketLogging(request, runtime); });
        //}

        [Fact]
        public void Test_GetBucketLifecycle()
        {
            GetBucketLifecycleRequest request = new GetBucketLifecycleRequest
            {
                BucketName = bucketName
            };
            var resp = client.getBucketLifecycle(request, runtime);
            Assert.NotNull(resp.RequestId);
            Assert.NotNull(resp.LifecycleConfiguration);
        }

        //[Fact]
        //public void Test_GetBucketAcl()
        //{
        //    GetBucketAclRequest request = new GetBucketAclRequest()
        //    {
        //        BucketName = bucketName
        //    };
        //    var resp = client.GetBucketAcl(request, runtime);
        //    Assert.NotNull(resp.RequestId);
        //    Assert.NotNull(resp.AccessControlPolicy);
        //}

        //[Fact]
        //public void Test_GetBucketLocation()
        //{
        //    GetBucketLocationRequest request = new GetBucketLocationRequest
        //    {
        //        BucketName = bucketName
        //    };
        //    var resp = client.GetBucketLocation(request, runtime);
        //    Assert.NotNull(resp.RequestId);
        //    Assert.NotNull(resp.LocationConstraint);
        //}

        //[Fact]
        //public void Test_DeleteBucketLogging()
        //{
        //    DeleteBucketLoggingRequest request = new DeleteBucketLoggingRequest
        //    {
        //        BucketName = bucketName
        //    };
        //    var resp = client.DeleteBucketLogging(request, runtime);
        //    Assert.NotNull(resp.RequestId);
        //}

        //[Fact]
        //public void Test_DeleteBucketWebsite()
        //{
        //    DeleteBucketWebsiteRequest request = new DeleteBucketWebsiteRequest
        //    {
        //        BucketName = bucketName
        //    };
        //    var resp = client.DeleteBucketWebsite(request, runtime);
        //    Assert.NotNull(resp.RequestId);
        //}

        [Fact]
        public void Test_DeleteBucketLifecycle()
        {
            DeleteBucketLifecycleRequest request = new DeleteBucketLifecycleRequest
            {
                BucketName = bucketName
            };
            var resp = client.deleteBucketLifecycle(request, runtime);
            Assert.NotNull(resp.RequestId);
        }

        [Fact]
        public void Test_PutObject()
        {
            PutObjectRequestHeader header = new PutObjectRequestHeader
            {
                StorageClass = "Standard"
            };
            PutObjectRequest request = new PutObjectRequest
            {
                BucketName = bucketName,
                Header = header,
                Body = new MemoryStream(Encoding.UTF8.GetBytes("123456789")),
                ObjectName = appendObj
            };
            var resp = client.putObject(request, runtime);
            Assert.NotNull(resp.RequestId);
            Assert.NotNull(resp.HashCrc64ecma);
        }

        //[Fact]
        //public void Test_CopyObject()
        //{
        //    CopyObjectRequestHeader header = new CopyObjectRequestHeader
        //    {
        //        CopySource = "/sdk-oss-test/source.txt"
        //    };
        //    CopyObjectRequest request = new CopyObjectRequest
        //    {
        //        BucketName = bucketName,
        //        DestObjectName = destObj,
        //        Header = header
        //    };
        //    var resp = client.CopyObject(request, runtime);
        //    Assert.NotNull(resp.RequestId);
        //    Assert.NotNull(resp.CopyObjectResult);
        //}

        //[Fact]
        //public void Test_AppendObject()
        //{
        //    AppendObjectRequestFilter filter = new AppendObjectRequestFilter
        //    {
        //        Position = "0"
        //    };
        //    AppendObjectRequest request = new AppendObjectRequest
        //    {
        //        BucketName = bucketName,
        //        ObjectName = appendObj,
        //        Body = new MemoryStream(Encoding.UTF8.GetBytes("oss")),
        //        Filter = filter
        //    };
        //    var resp = client.AppendObject(request, runtime);
        //    Assert.NotNull(resp.RequestId);
        //    Assert.NotNull(resp.HashCrc64ecma);
        //}

        [Fact]
        public void Test_GetObject()
        {
            GetObjectRequest request = new GetObjectRequest
            {
                BucketName = bucketName,
                ObjectName = appendObj
            };
            var resp = client.getObject(request, runtime);
            Assert.NotNull(resp.RequestId);
            Assert.NotNull(resp.ObjectType);
        }

        //[Fact]
        //public void Test_GetObjectTagging()
        //{
        //    GetObjectTaggingRequest request = new GetObjectTaggingRequest
        //    {
        //        BucketName = bucketName,
        //        ObjectName = appendObj
        //    };
        //    var resp = client.GetObjectTagging(request, runtime);
        //    Assert.NotNull(resp.RequestId);
        //    Assert.NotNull(resp.Tagging);
        //}

        //[Fact]
        //public void Test_GetObjectMeta()
        //{
        //    GetObjectMetaRequest request = new GetObjectMetaRequest
        //    {
        //        BucketName = bucketName,
        //        ObjectName = destObj
        //    };
        //    var resp = client.GetObjectMeta(request, runtime);
        //    Assert.NotNull(resp.RequestId);
        //    Assert.NotNull(resp.LastModified);
        //}

        //[Fact]
        //public void Test_DeleteObjectTagging()
        //{
        //    DeleteObjectTaggingRequest request = new DeleteObjectTaggingRequest
        //    {
        //        BucketName = bucketName,
        //        ObjectName = appendObj
        //    };
        //    var resp = client.DeleteObjectTagging(request, runtime);
        //    Assert.NotNull(resp.RequestId);
        //}

        [Fact]
        public void Test_DeleteObject()
        {
            DeleteObjectRequest request = new DeleteObjectRequest
            {
                BucketName = bucketName,
                ObjectName = appendObj
            };
            var resp = client.deleteObject(request, runtime);
            Assert.NotNull(resp.RequestId);
        }

        //[Fact]
        //public void Test_HeadObject()
        //{
        //    HeadObjectRequest request = new HeadObjectRequest
        //    {
        //        BucketName = bucketName,
        //        ObjectName = appendObj
        //    };
        //    var resp = client.HeadObject(request, runtime);
        //    Assert.NotNull(resp.RequestId);
        //    Assert.NotNull(resp.LastModified);
        //}

        //[Fact]
        //public void Test_PutObjectACL()
        //{
        //    PutObjectAclRequestHeader header = new PutObjectAclRequestHeader
        //    {
        //        ObjectAcl = "private"
        //    };
        //    PutObjectAclRequest request = new PutObjectAclRequest
        //    {
        //        BucketName = bucketName,
        //        ObjectName = destObj,
        //        Header = header
        //    };
        //    var resp = client.PutObjectAcl(request, runtime);
        //    Assert.NotNull(resp.RequestId);
        //}

        //[Fact]
        //public void Test_GetObjectACL()
        //{
        //    GetObjectAclRequest request = new GetObjectAclRequest
        //    {
        //        BucketName = bucketName,
        //        ObjectName = destObj
        //    };
        //    var resp = client.GetObjectAcl(request, runtime);
        //    Assert.NotNull(resp.RequestId);
        //    Assert.NotNull(resp.AccessControlPolicy);
        //}

        //[Fact]
        //public void Test_PutSymlink()
        //{
        //    PutSymlinkRequestHeader header = new PutSymlinkRequestHeader
        //    {
        //        SymlinkTarget = destObj
        //    };
        //    PutSymlinkRequest request = new PutSymlinkRequest
        //    {
        //        BucketName = bucketName,
        //        ObjectName = sourceObj,
        //        Header = header
        //    };
        //    var resp = client.PutSymlink(request, runtime);
        //    Assert.NotNull(resp.RequestId);
        //}

        //[Fact]
        //public void Test_GetSymlink()
        //{
        //    GetSymlinkRequest request = new GetSymlinkRequest
        //    {
        //        BucketName = bucketName,
        //        ObjectName = sourceObj
        //    };
        //    var resp = client.GetSymlink(request, runtime);
        //    Assert.NotNull(resp.RequestId);
        //    Assert.NotNull(resp.SymlinkTarget);
        //}

        //[Fact]
        //public void Test_RestoreObject()
        //{
        //    RestoreObjectRequest request = new RestoreObjectRequest
        //    {
        //        BucketName = bucketName,
        //        ObjectName = "obj.txt"
        //    };
        //    var resp = client.RestoreObject(request, runtime);
        //    Assert.NotNull(resp.RequestId);
        //}

        //[Fact]
        //public void Test_InitiateMultipartUpload()
        //{
        //    InitiateMultipartUploadRequestFilter filter = new InitiateMultipartUploadRequestFilter
        //    {
        //        EncodingType = "url"
        //    };
        //    InitiateMultipartUploadRequest request = new InitiateMultipartUploadRequest
        //    {
        //        BucketName = bucketName,
        //        ObjectName = initObj,
        //        Filter = filter
        //    };
        //    var resp = client.InitiateMultipartUpload(request, runtime);
        //    Assert.NotNull(resp.RequestId);
        //    Assert.NotNull(resp.InitiateMultipartUploadResult);
        //    uploadId = resp.InitiateMultipartUploadResult.UploadId;
        //}

        //[Fact]
        //public void Test_UploadPart()
        //{
        //    UploadPartRequestFilter filter = new UploadPartRequestFilter
        //    {
        //        PartNumber = "1",
        //        UploadId = uploadId
        //    };
        //    UploadPartRequest request = new UploadPartRequest
        //    {
        //        BucketName = "sdk-oss-test",
        //        ObjectName = initObj,
        //        Filter = filter,
        //        Body = new MemoryStream(Encoding.UTF8.GetBytes("oss test"))
        //    };
        //    var resp = client.UploadPart(request, runtime);
        //    Assert.NotNull(resp.RequestId);
        //}

        //[Fact]
        //public void Test_UploadPartCopy()
        //{
        //    UploadPartCopyRequestFilter filter = new UploadPartCopyRequestFilter
        //    {
        //        PartNumber = "1",
        //        UploadId = uploadId
        //    };
        //    UploadPartCopyRequestHeader header = new UploadPartCopyRequestHeader
        //    {
        //        CopySource = "/sdk-oss-test/obj.txt",
        //        CopySourceRange = "1"
        //    };
        //    UploadPartCopyRequest request = new UploadPartCopyRequest
        //    {
        //        BucketName = "sdk-oss-test",
        //        ObjectName = initObj,
        //        Filter = filter,
        //        Header = header
        //    };
        //    var resp = client.UploadPartCopy(request, runtime);
        //    Assert.NotNull(resp.RequestId);
        //    Assert.NotNull(resp.CopyPartResult);
        //}

        //[Fact]
        //public void Test_ListParts()
        //{
        //    ListPartsRequestFilter filter = new ListPartsRequestFilter
        //    {
        //        UploadId = uploadId
        //    };
        //    ListPartsRequest request = new ListPartsRequest
        //    {
        //        BucketName = bucketName,
        //        ObjectName = initObj,
        //        Filter = filter
        //    };
        //    var resp = client.ListParts(request, runtime);
        //    Assert.NotNull(resp.RequestId);
        //    Assert.NotNull(resp.ListPartsResult);
        //}

        //[Fact]
        //public void Test_AbortMultipartUpload()
        //{
        //    AbortMultipartUploadRequestFilter filter = new AbortMultipartUploadRequestFilter
        //    {
        //        UploadId = uploadId
        //    };
        //    AbortMultipartUploadRequest request = new AbortMultipartUploadRequest
        //    {
        //        BucketName = bucketName,
        //        ObjectName = initObj,
        //        Filter = filter
        //    };
        //    var resp = client.AbortMultipartUpload(request, runtime);
        //    Assert.NotNull(resp.RequestId);
        //}

        //[Fact]
        //public void Test_GetBucketCORS()
        //{
        //    GetBucketCORSRequest request = new GetBucketCORSRequest
        //    {
        //        BucketName = bucketName
        //    };
        //    var resp = client.GetBucketCORS(request, runtime);
        //    Assert.NotNull(resp.RequestId);
        //    Assert.NotNull(resp.CORSConfiguration);
        //}

        //[Fact]
        //public void Test_OptionObject()
        //{
        //    OptionObjectRequestHeader header = new OptionObjectRequestHeader
        //    {
        //        Origin = "origin",
        //        AccessControlRequestHeaders = "sdk",
        //        AccessControlRequestMethod = "GET"
        //    };
        //    OptionObjectRequest request = new OptionObjectRequest
        //    {
        //        BucketName = bucketName,
        //        ObjectName = objectName,
        //        Header = header
        //    };
        //    var resp = client.OptionObject(request, runtime);
        //    Assert.NotNull(resp.RequestId);
        //}

        //[Fact]
        //public void Test_DeleteBucketCORS()
        //{
        //    DeleteBucketCORSRequest request = new DeleteBucketCORSRequest
        //    {
        //        BucketName = bucketName
        //    };
        //    var resp = client.DeleteBucketCORS(request, runtime);
        //    Assert.NotNull(resp.RequestId);
        //}
    }
}
