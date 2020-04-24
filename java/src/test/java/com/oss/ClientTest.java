// This file is auto-generated, don't edit it. Thanks.
package com.oss;

import com.aliyun.oss.Client;
import com.aliyun.oss.models.*;
import com.aliyun.oss.models.PutBucketLifecycleRequest.PutBucketLifecycleRequestBody;
import com.aliyun.oss.models.PutBucketLifecycleRequest.PutBucketLifecycleRequestBodyLifecycleConfiguration;
import com.aliyun.oss.models.PutBucketLifecycleRequest.PutBucketLifecycleRequestBodyLifecycleConfigurationRule;
import com.aliyun.oss.models.PutBucketLifecycleRequest.PutBucketLifecycleRequestBodyLifecycleConfigurationRuleExpiration;
import com.aliyun.ossutil.models.RuntimeOptions;
import org.junit.Assert;
import org.junit.Before;
import org.junit.Ignore;
import org.junit.Test;

import java.io.ByteArrayInputStream;
import java.util.ArrayList;
import java.util.List;

public class ClientTest {
    private Client client;
    private String uploadId = "";

    @Before
    public void createClient() throws Exception {
        Config config = new Config();
        config.accessKeyId = System.getenv("RAMAccessKeyId");
        config.accessKeySecret = System.getenv("RAMAccessKeySecret");
        config.signatureVersion = "V1";
        client = new Client(config);
    }

    @Test
    public void GetBucketInfoTest() throws Exception {
        GetBucketInfoRequest request = new GetBucketInfoRequest();
        request.bucketName = "sdk-script";
        RuntimeOptions RuntimeOptions = new RuntimeOptions();
        GetBucketInfoResponse response = client.getBucketInfo(request, RuntimeOptions);
        Assert.assertEquals("sdk-script", response.bucketInfo.bucket.name);
    }

    @Test
    public void GetBucketTest() throws Exception {
        GetBucketRequest request = new GetBucketRequest();
        request.bucketName = "sdk-script";
        RuntimeOptions RuntimeOptions = new RuntimeOptions();
        GetBucketResponse response = client.getBucket(request, RuntimeOptions);
        Assert.assertEquals("sdk-script", response.listBucketResult.name);
    }

    @Test
    public void DeleteBucketLoggingTest() throws Exception {
        DeleteBucketLoggingRequest request = new DeleteBucketLoggingRequest();
        request.bucketName = "sdk-oss-test";
        RuntimeOptions RuntimeOptions = new RuntimeOptions();
        DeleteBucketLoggingResponse response = client.deleteBucketLogging(request, RuntimeOptions);
        Assert.assertNotNull(response.requestId);
    }

    @Test
    public void GetBucketLoggingTest() throws Exception {
        GetBucketLoggingRequest request = new GetBucketLoggingRequest();
        request.bucketName = "sdk-oss-test";
        RuntimeOptions RuntimeOptions = new RuntimeOptions();
        GetBucketLoggingResponse response = client.getBucketLogging(request, RuntimeOptions);
        Assert.assertNotNull(response.bucketLoggingStatus);
    }

    @Test
    public void GetBucketRefererTest() throws Exception {
        GetBucketRefererRequest request = new GetBucketRefererRequest();
        request.bucketName = "sdk-oss-test";
        RuntimeOptions RuntimeOptions = new RuntimeOptions();
        GetBucketRefererResponse response = client.getBucketReferer(request, RuntimeOptions);
        Assert.assertTrue(response.refererConfiguration.allowEmptyReferer);
    }

    @Test
    public void PutBucketAclTest() throws Exception {
        PutBucketAclRequest request = new PutBucketAclRequest();
        request.bucketName = "sdk-oss-test";
        PutBucketAclRequest.PutBucketAclRequestHeader header = new PutBucketAclRequest.PutBucketAclRequestHeader();
        header.acl = "public-read";
        request.header = header;
        RuntimeOptions RuntimeOptions = new RuntimeOptions();
        PutBucketAclResponse response = client.putBucketAcl(request, RuntimeOptions);
        Assert.assertNotNull(response.requestId);
    }

    @Test
    public void GetBucketAclTest() throws Exception {
        GetBucketAclRequest request = new GetBucketAclRequest();
        request.bucketName = "sdk-oss-test";
        RuntimeOptions RuntimeOptions = new RuntimeOptions();
        GetBucketAclResponse response = client.getBucketAcl(request, RuntimeOptions);
        Assert.assertNotNull(response.accessControlPolicy);
    }

    @Test
    public void GetBucketLocationTest() throws Exception {
        GetBucketLocationRequest request = new GetBucketLocationRequest();
        request.bucketName = "sdk-oss-test";
        RuntimeOptions RuntimeOptions = new RuntimeOptions();
        GetBucketLocationResponse response = client.getBucketLocation(request, RuntimeOptions);
        Assert.assertEquals("oss-cn-hangzhou", response.locationConstraint);
    }

    @Test
    public void DeleteBucketWebsiteTest() throws Exception {
        DeleteBucketWebsiteRequest request = new DeleteBucketWebsiteRequest();
        request.bucketName = "sdk-oss-test";
        RuntimeOptions RuntimeOptions = new RuntimeOptions();
        DeleteBucketWebsiteResponse response = client.deleteBucketWebsite(request, RuntimeOptions);
        Assert.assertNotNull(response.requestId);
    }

    @Test
    public void PutObjectTest() throws Exception {
        PutObjectRequest request = new PutObjectRequest();
        request.bucketName = "sdk-oss-test";
        request.objectName = "sdk.txt";
        PutObjectRequest.PutObjectRequestHeader header = new PutObjectRequest.PutObjectRequestHeader();
        header.storageClass = "Archive";
        request.header = header;
        request.body = new ByteArrayInputStream("value".getBytes("UTF-8"));
        RuntimeOptions RuntimeOptions = new RuntimeOptions();
        PutObjectResponse response = client.putObject(request, RuntimeOptions);
        Assert.assertNotNull(response.requestId);
    }

    @Test
    public void CopyObjectTest() throws Exception {
        CopyObjectRequest request = new CopyObjectRequest();
        request.bucketName = "sdk-oss-test";
        request.destObjectName = "dest.txt";
        CopyObjectRequest.CopyObjectRequestHeader header = new CopyObjectRequest.CopyObjectRequestHeader();
        header.copySource = "/sdk-oss-test/source.txt";
        request.header = header;
        RuntimeOptions RuntimeOptions = new RuntimeOptions();
        CopyObjectResponse response = client.copyObject(request, RuntimeOptions);
        Assert.assertNotNull(response.copyObjectResult);
    }

    @Test
    public void AppendObjectTest() throws Exception {
        AppendObjectRequest request = new AppendObjectRequest();
        request.bucketName = "sdk-oss-test";
        AppendObjectRequest.AppendObjectRequestFilter filter = new AppendObjectRequest.AppendObjectRequestFilter();
        filter.position = "0";
        request.objectName = "test123456.txt";
        request.body = new ByteArrayInputStream("oss".getBytes("UTF-8"));
        request.filter = filter;
        RuntimeOptions RuntimeOptions = new RuntimeOptions();
        AppendObjectResponse response = client.appendObject(request, RuntimeOptions);
        Assert.assertEquals("3", response.nextAppendPosition);
    }

    @Test
    public void GetObjectTest() throws Exception {
        GetObjectRequest request = new GetObjectRequest();
        request.bucketName = "sdk-oss-test";
        request.objectName = "test123456.txt";
        RuntimeOptions RuntimeOptions = new RuntimeOptions();
        GetObjectResponse response = client.getObject(request, RuntimeOptions);
        Assert.assertEquals("Appendable", response.objectType);
    }

    @Test
    public void GetObjectTaggingTest() throws Exception {
        GetObjectTaggingRequest request = new GetObjectTaggingRequest();
        request.bucketName = "sdk-oss-test";
        request.objectName = "test123456.txt";
        RuntimeOptions RuntimeOptions = new RuntimeOptions();
        GetObjectTaggingResponse response = client.getObjectTagging(request, RuntimeOptions);
        Assert.assertNotNull(response.tagging);
    }

    @Test
    public void GetObjectMetaTest() throws Exception {
        GetObjectMetaRequest request = new GetObjectMetaRequest();
        request.bucketName = "sdk-oss-test";
        request.objectName = "test123456.txt";
        RuntimeOptions RuntimeOptions = new RuntimeOptions();
        GetObjectMetaResponse response = client.getObjectMeta(request, RuntimeOptions);
        Assert.assertEquals("3", response.contentLength);
    }

    @Test
    public void HeadObjectTest() throws Exception {
        HeadObjectRequest request = new HeadObjectRequest();
        request.bucketName = "sdk-oss-test";
        request.objectName = "test123456.txt";
        RuntimeOptions RuntimeOptions = new RuntimeOptions();
        HeadObjectResponse response = client.headObject(request, RuntimeOptions);
        Assert.assertEquals("3", response.nextAppendPosition);
    }

    @Test
    public void DeleteObjectTaggingTest() throws Exception {
        DeleteObjectTaggingRequest request = new DeleteObjectTaggingRequest();
        request.bucketName = "sdk-oss-test";
        request.objectName = "test123456.txt";
        RuntimeOptions RuntimeOptions = new RuntimeOptions();
        DeleteObjectTaggingResponse response = client.deleteObjectTagging(request, RuntimeOptions);
        Assert.assertNotNull(response.requestId);
    }

    @Test
    public void DeleteObjectTest() throws Exception {
        DeleteObjectRequest request = new DeleteObjectRequest();
        request.bucketName = "sdk-oss-test";
        request.objectName = "test123456.txt";
        RuntimeOptions RuntimeOptions = new RuntimeOptions();
        DeleteObjectResponse response = client.deleteObject(request, RuntimeOptions);
        Assert.assertNotNull(response.requestId);
    }

    @Test
    public void PutObjectAclTest() throws Exception {
        PutObjectAclRequest request = new PutObjectAclRequest();
        PutObjectAclRequest.PutObjectAclRequestHeader header = new PutObjectAclRequest.PutObjectAclRequestHeader();
        header.objectAcl = "private";
        request.bucketName = "sdk-oss-test";
        request.objectName = "test123456.txt";
        request.header = header;
        RuntimeOptions RuntimeOptions = new RuntimeOptions();
        PutObjectAclResponse response = client.putObjectAcl(request, RuntimeOptions);
        Assert.assertNotNull(response.requestId);
    }

    @Test
    public void GetObjectAclTest() throws Exception {
        GetObjectAclRequest request = new GetObjectAclRequest();
        request.bucketName = "sdk-oss-test";
        request.objectName = "test123456.txt";
        RuntimeOptions RuntimeOptions = new RuntimeOptions();
        GetObjectAclResponse response = client.getObjectAcl(request, RuntimeOptions);
        Assert.assertNotNull(response.accessControlPolicy);
    }

    @Test
    public void PutSymlinkTest() throws Exception {
        PutSymlinkRequest request = new PutSymlinkRequest();
        PutSymlinkRequest.PutSymlinkRequestHeader header = new PutSymlinkRequest.PutSymlinkRequestHeader();
        header.symlinkTarget = "test123456.txt";
        request.bucketName = "sdk-oss-test";
        request.objectName = "test123456link.txt";
        request.header = header;
        RuntimeOptions RuntimeOptions = new RuntimeOptions();
        PutSymlinkResponse response = client.putSymlink(request, RuntimeOptions);
        Assert.assertNotNull(response.requestId);
    }

    @Test
    public void GetSymlinkTest() throws Exception {
        GetSymlinkRequest request = new GetSymlinkRequest();
        request.bucketName = "sdk-oss-test";
        request.objectName = "test123456link.txt";
        RuntimeOptions RuntimeOptions = new RuntimeOptions();
        GetSymlinkResponse response = client.getSymlink(request, RuntimeOptions);
        Assert.assertEquals("test123456.txt", response.symlinkTarget);
    }

    @Test
    public void RestoreObjectTest() throws Exception {
        RestoreObjectRequest request = new RestoreObjectRequest();
        request.bucketName = "sdk-oss-test";
        request.objectName = "obj.txt";
        RuntimeOptions RuntimeOptions = new RuntimeOptions();
        RestoreObjectResponse response = client.restoreObject(request, RuntimeOptions);
        Assert.assertNotNull(response.requestId);
    }

    @Test
    public void InitiateMultipartUploadTest() throws Exception {
        InitiateMultipartUploadRequest request = new InitiateMultipartUploadRequest();
        InitiateMultipartUploadRequest.InitiateMultipartUploadRequestFilter filter =
                new InitiateMultipartUploadRequest.InitiateMultipartUploadRequestFilter();
        filter.encodingType = "url";
        request.bucketName = "sdk-oss-test";
        request.objectName = "init.txt";
        request.filter = filter;
        RuntimeOptions RuntimeOptions = new RuntimeOptions();
        InitiateMultipartUploadResponse response = client.initiateMultipartUpload(request, RuntimeOptions);
        this.uploadId = response.initiateMultipartUploadResult.uploadId;
        Assert.assertNotNull(response.requestId);

        UploadPartRequest uploadPartRequest = new UploadPartRequest();
        UploadPartRequest.UploadPartRequestFilter uploadPartRequestFilter =
                new UploadPartRequest.UploadPartRequestFilter();
        uploadPartRequestFilter.partNumber = "1";
        uploadPartRequestFilter.uploadId = this.uploadId;
        uploadPartRequest.bucketName = "sdk-oss-test";
        uploadPartRequest.objectName = "init.txt";
        uploadPartRequest.filter = uploadPartRequestFilter;
        uploadPartRequest.body = new ByteArrayInputStream("oss test".getBytes("UTF-8"));
        UploadPartResponse uploadPartResponse = client.uploadPart(uploadPartRequest, RuntimeOptions);
        Assert.assertNotNull(uploadPartResponse.requestId);

        UploadPartCopyRequest uploadPartCopyRequest = new UploadPartCopyRequest();
        UploadPartCopyRequest.UploadPartCopyRequestFilter uploadPartCopyRequestFilter =
                new UploadPartCopyRequest.UploadPartCopyRequestFilter();
        UploadPartCopyRequest.UploadPartCopyRequestHeader uploadPartCopyRequestHeader =
                new UploadPartCopyRequest.UploadPartCopyRequestHeader();
        uploadPartCopyRequestHeader.copySource = "/sdk-oss-test/obj.txt";
        uploadPartCopyRequestHeader.copySourceRange = "1";
        uploadPartCopyRequestFilter.partNumber = "1";
        uploadPartCopyRequestFilter.uploadId = this.uploadId;
        uploadPartCopyRequest.bucketName = "sdk-oss-test";
        uploadPartCopyRequest.objectName = "init.txt";
        uploadPartCopyRequest.filter = uploadPartCopyRequestFilter;
        uploadPartCopyRequest.header = uploadPartCopyRequestHeader;
        UploadPartCopyResponse UploadPartCopyResponse = client.uploadPartCopy(uploadPartCopyRequest, RuntimeOptions);
        Assert.assertNotNull(UploadPartCopyResponse.copyPartResult);

        ListPartsRequest listPartsRequest = new ListPartsRequest();
        ListPartsRequest.ListPartsRequestFilter listPartsRequestFilter =
                new ListPartsRequest.ListPartsRequestFilter();
        listPartsRequestFilter.uploadId = this.uploadId;
        listPartsRequest.bucketName = "sdk-oss-test";
        listPartsRequest.objectName = "init.txt";
        listPartsRequest.filter = listPartsRequestFilter;
        ListPartsResponse listPartsResponse = client.listParts(listPartsRequest, RuntimeOptions);
        Assert.assertNotNull(listPartsResponse.listPartsResult);

        AbortMultipartUploadRequest abortMultipartUploadRequest = new AbortMultipartUploadRequest();
        AbortMultipartUploadRequest.AbortMultipartUploadRequestFilter abortMultipartUploadRequestFilter =
                new AbortMultipartUploadRequest.AbortMultipartUploadRequestFilter();
        abortMultipartUploadRequestFilter.uploadId = this.uploadId;
        abortMultipartUploadRequest.bucketName = "sdk-oss-test";
        abortMultipartUploadRequest.objectName = "init.txt";
        abortMultipartUploadRequest.filter = abortMultipartUploadRequestFilter;
        AbortMultipartUploadResponse abortMultipartUploadResponse =
                client.abortMultipartUpload(abortMultipartUploadRequest, RuntimeOptions);
        Assert.assertNotNull(abortMultipartUploadResponse.requestId);
    }

    @Test
    public void GetBucketCORSTest() throws Exception {
        GetBucketCORSRequest request = new GetBucketCORSRequest();
        request.bucketName = "sdk-oss-test";
        RuntimeOptions RuntimeOptions = new RuntimeOptions();
        GetBucketCORSResponse response = client.getBucketCORS(request, RuntimeOptions);
        Assert.assertNotNull(response.cORSConfiguration);
    }

    @Test
    public void OptionObjectTest() throws Exception {
        OptionObjectRequest request = new OptionObjectRequest();
        OptionObjectRequest.OptionObjectRequestHeader header = new OptionObjectRequest.OptionObjectRequestHeader();
        header.origin = "origin";
        header.accessControlRequestHeaders = "sdk";
        header.accessControlRequestMethod = "GET";
        request.bucketName = "sdk-oss-test";
        request.objectName = "obj.txt";
        request.header = header;
        RuntimeOptions RuntimeOptions = new RuntimeOptions();
        OptionObjectResponse response = client.optionObject(request, RuntimeOptions);
        Assert.assertEquals("sdk", response.accessControlAllowHeaders);
    }

    @Test
    public void DeleteBucketCORSTest() throws Exception {
        DeleteBucketCORSRequest request = new DeleteBucketCORSRequest();
        request.bucketName = "sdk-oss-test";
        RuntimeOptions RuntimeOptions = new RuntimeOptions();
        DeleteBucketCORSResponse response = client.deleteBucketCORS(request, RuntimeOptions);
        Assert.assertNotNull(response.requestId);
    }

    @Test
    @Ignore
    public void PutLiveChannelStatusTest() throws Exception {
        PutLiveChannelStatusRequest request = new PutLiveChannelStatusRequest();
        PutLiveChannelStatusRequest.PutLiveChannelStatusRequestFilter filter = new PutLiveChannelStatusRequest.PutLiveChannelStatusRequestFilter();
        filter.status = "enabled";
        request.filter = filter;
        request.bucketName = "sdk-oss-test";
        request.channelName = "OSS";
        RuntimeOptions RuntimeOptions = new RuntimeOptions();
        PutLiveChannelStatusResponse response = client.putLiveChannelStatus(request, RuntimeOptions);
        Assert.assertNotNull(response.requestId);
    }

    @Test
    @Ignore
    public void PostVodPlaylistTest() throws Exception {
        PostVodPlaylistRequest request = new PostVodPlaylistRequest();
        request.bucketName = "sdk-oss-test";
        request.channelName = "channelname";
        request.playlistName = "playlistname";
        RuntimeOptions RuntimeOptions = new RuntimeOptions();
        PostVodPlaylistResponse response = client.postVodPlaylist(request, RuntimeOptions);
        Assert.assertNotNull(response.requestId);
    }

    @Test
    @Ignore
    public void GetVodPlaylistTest() throws Exception {
        GetVodPlaylistRequest request = new GetVodPlaylistRequest();
        request.bucketName = "sdk-oss-test";
        request.channelName = "channelname";
        RuntimeOptions RuntimeOptions = new RuntimeOptions();
        GetVodPlaylistResponse response = client.getVodPlaylist(request, RuntimeOptions);
        Assert.assertNotNull(response.requestId);
    }

    @Test
    public void putBucketLifecycle() throws Exception {
        PutBucketLifecycleRequest request = new PutBucketLifecycleRequest();
        PutBucketLifecycleRequestBody body = new PutBucketLifecycleRequestBody();
        PutBucketLifecycleRequestBodyLifecycleConfiguration configuration = new PutBucketLifecycleRequestBodyLifecycleConfiguration();
        PutBucketLifecycleRequestBodyLifecycleConfigurationRule rule = new PutBucketLifecycleRequestBodyLifecycleConfigurationRule();
        PutBucketLifecycleRequestBodyLifecycleConfigurationRuleExpiration expiration = new PutBucketLifecycleRequestBodyLifecycleConfigurationRuleExpiration();
        expiration.days = 1;
        rule.prefix = "test";
        rule.expiration = expiration;
        rule.iD = "1";
        rule.prefix = "Prefix";
        rule.status = "Disabled";
        List<PutBucketLifecycleRequestBodyLifecycleConfigurationRule> list = new ArrayList<>();
        list.add(rule);
        configuration.rule = list;
        body.lifecycleConfiguration = configuration;
        request.body = body;
        request.bucketName = "sdk-oss-test";
        RuntimeOptions RuntimeOptions = new RuntimeOptions();
        PutBucketLifecycleResponse response = client.putBucketLifecycle(request, RuntimeOptions);
        Assert.assertNotNull(response.requestId);
    }

    @Test
    public void getBucketLifecycle() throws Exception {
        GetBucketLifecycleRequest request = new GetBucketLifecycleRequest();
        request.bucketName = "sdk-oss-test";
        RuntimeOptions RuntimeOptions = new RuntimeOptions();
        GetBucketLifecycleResponse response = client.getBucketLifecycle(request, RuntimeOptions);
        Assert.assertEquals("1", response.lifecycleConfiguration.rule.get(0).iD);
        Assert.assertEquals("Prefix", response.lifecycleConfiguration.rule.get(0).prefix);
        Assert.assertEquals("Disabled", response.lifecycleConfiguration.rule.get(0).status);
    }

    @Test
    public void deleteBucketLifecycle() throws Exception {
        DeleteBucketLifecycleRequest request = new DeleteBucketLifecycleRequest();
        request.bucketName = "sdk-oss-test";
        RuntimeOptions RuntimeOptions = new RuntimeOptions();
        DeleteBucketLifecycleResponse response = client.deleteBucketLifecycle(request, RuntimeOptions);
        Assert.assertNotNull(response.requestId);
    }

    @Test
    public void putObejct() throws Exception {
        PutObjectRequest request = new PutObjectRequest();
        request.bucketName = "sdk-oss-test";
        request.body = new ByteArrayInputStream("123456789123456789".getBytes("UTF-8"));
        request.objectName = "123.txt";
        RuntimeOptions RuntimeOptions = new RuntimeOptions();
        PutObjectResponse response = client.putObject(request, RuntimeOptions);
        Assert.assertEquals("11205368990259748190", response.hashCrc64ecma);
    }

    @Test
    public void getObject() throws Exception {
        GetObjectRequest request = new GetObjectRequest();
        request.bucketName = "sdk-oss-test";
        request.objectName = "123.txt";
        RuntimeOptions RuntimeOptions = new RuntimeOptions();
        GetObjectResponse response = client.getObject(request, RuntimeOptions);
        Assert.assertNotNull(response.body);
    }

    @Test
    public void deleteObject() throws Exception {
        DeleteObjectRequest request = new DeleteObjectRequest();
        request.bucketName = "sdk-oss-test";
        request.objectName = "123.txt";
        RuntimeOptions RuntimeOptions = new RuntimeOptions();
        DeleteObjectResponse response = client.deleteObject(request, RuntimeOptions);
        Assert.assertNotNull(response.requestId);
    }

}

