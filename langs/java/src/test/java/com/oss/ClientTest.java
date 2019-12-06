// This file is auto-generated, don't edit it. Thanks.
package com.oss;

import com.oss.models.*;
import org.junit.Assert;
import org.junit.Before;
import org.junit.Ignore;
import org.junit.Test;

import java.io.ByteArrayInputStream;

public class ClientTest {
    private Client client;
    private String uploadId = "";

    @Before
    public void createClient() throws Exception {
        Config config = new Config();
        config.accessKeyId = System.getenv("sdk_testAK");
        config.accessKeySecret = System.getenv("sdk_testSk");
        config.signatureVersion = "v2";
        client = new Client(config);
    }

    @Test
    public void GetBucketInfoTest() throws Exception {
        GetBucketInfoRequest request = new GetBucketInfoRequest();
        request.bucketName = "sdk-script";
        RuntimeObject runtimeObject = new RuntimeObject();
        GetBucketInfoResponse response = client.GetBucketInfo(request, runtimeObject);
        Assert.assertEquals("sdk-script", response.bucketInfo.bucket.name);
    }

    @Test
    public void GetBucketTest() throws Exception {
        GetBucketRequest request = new GetBucketRequest();
        request.bucketName = "sdk-script";
        RuntimeObject runtimeObject = new RuntimeObject();
        GetBucketResponse response = client.GetBucket(request, runtimeObject);
        Assert.assertEquals("sdk-script", response.listBucketResult.name);
    }

    @Test
    public void DeleteBucketLoggingTest() throws Exception {
        DeleteBucketLoggingRequest request = new DeleteBucketLoggingRequest();
        request.bucketName = "sdk-oss-test";
        RuntimeObject runtimeObject = new RuntimeObject();
        DeleteBucketLoggingResponse response = client.DeleteBucketLogging(request, runtimeObject);
        Assert.assertNotNull(response.requestId);
    }

    @Test
    public void GetBucketLoggingTest() throws Exception {
        GetBucketLoggingRequest request = new GetBucketLoggingRequest();
        request.bucketName = "sdk-oss-test";
        RuntimeObject runtimeObject = new RuntimeObject();
        GetBucketLoggingResponse response = client.GetBucketLogging(request, runtimeObject);
        Assert.assertNotNull(response.bucketLoggingStatus);
    }

    @Test
    public void GetBucketRefererTest() throws Exception {
        GetBucketRefererRequest request = new GetBucketRefererRequest();
        request.bucketName = "sdk-oss-test";
        RuntimeObject runtimeObject = new RuntimeObject();
        GetBucketRefererResponse response = client.GetBucketReferer(request, runtimeObject);
        Assert.assertTrue(response.refererConfiguration.allowEmptyReferer);
    }

    @Test
    public void PutBucketAclTest() throws Exception {
        PutBucketAclRequest request = new PutBucketAclRequest();
        request.bucketName = "sdk-oss-test";
        PutBucketAclRequest.PutBucketAclRequestHeader header = new PutBucketAclRequest.PutBucketAclRequestHeader();
        header.acl = "public-read";
        request.header = header;
        RuntimeObject runtimeObject = new RuntimeObject();
        PutBucketAclResponse response = client.PutBucketAcl(request, runtimeObject);
        Assert.assertNotNull(response.requestId);
    }

    @Test
    public void GetBucketAclTest() throws Exception {
        GetBucketAclRequest request = new GetBucketAclRequest();
        request.bucketName = "sdk-oss-test";
        RuntimeObject runtimeObject = new RuntimeObject();
        GetBucketAclResponse response = client.GetBucketAcl(request, runtimeObject);
        Assert.assertNotNull(response.accessControlPolicy);
    }

    @Test
    public void GetBucketLocationTest() throws Exception {
        GetBucketLocationRequest request = new GetBucketLocationRequest();
        request.bucketName = "sdk-oss-test";
        RuntimeObject runtimeObject = new RuntimeObject();
        GetBucketLocationResponse response = client.GetBucketLocation(request, runtimeObject);
        Assert.assertEquals("oss-cn-hangzhou", response.locationConstraint);
    }

    @Test
    public void DeleteBucketWebsiteTest() throws Exception {
        DeleteBucketWebsiteRequest request = new DeleteBucketWebsiteRequest();
        request.bucketName = "sdk-oss-test";
        RuntimeObject runtimeObject = new RuntimeObject();
        DeleteBucketWebsiteResponse response = client.DeleteBucketWebsite(request, runtimeObject);
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
        RuntimeObject runtimeObject = new RuntimeObject();
        PutObjectResponse response = client.PutObject(request, runtimeObject);
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
        RuntimeObject runtimeObject = new RuntimeObject();
        CopyObjectResponse response = client.CopyObject(request, runtimeObject);
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
        RuntimeObject runtimeObject = new RuntimeObject();
        AppendObjectResponse response = client.AppendObject(request, runtimeObject);
        Assert.assertEquals("3", response.nextAppendPosition);
    }

    @Test
    public void GetObjectTest() throws Exception {
        GetObjectRequest request = new GetObjectRequest();
        request.bucketName = "sdk-oss-test";
        request.objectName = "test123456.txt";
        RuntimeObject runtimeObject = new RuntimeObject();
        GetObjectResponse response = client.GetObject(request, runtimeObject);
        Assert.assertEquals("Appendable", response.objectType);
    }

    @Test
    public void GetObjectTaggingTest() throws Exception {
        GetObjectTaggingRequest request = new GetObjectTaggingRequest();
        request.bucketName = "sdk-oss-test";
        request.objectName = "test123456.txt";
        RuntimeObject runtimeObject = new RuntimeObject();
        GetObjectTaggingResponse response = client.GetObjectTagging(request, runtimeObject);
        Assert.assertNotNull(response.tagging);
    }

    @Test
    public void GetObjectMetaTest() throws Exception {
        GetObjectMetaRequest request = new GetObjectMetaRequest();
        request.bucketName = "sdk-oss-test";
        request.objectName = "test123456.txt";
        RuntimeObject runtimeObject = new RuntimeObject();
        GetObjectMetaResponse response = client.GetObjectMeta(request, runtimeObject);
        Assert.assertEquals("3", response.contentLength);
    }

    @Test
    public void HeadObjectTest() throws Exception {
        HeadObjectRequest request = new HeadObjectRequest();
        request.bucketName = "sdk-oss-test";
        request.objectName = "test123456.txt";
        RuntimeObject runtimeObject = new RuntimeObject();
        HeadObjectResponse response = client.HeadObject(request, runtimeObject);
        Assert.assertEquals("3", response.nextAppendPosition);
    }

    @Test
    public void DeleteObjectTaggingTest() throws Exception {
        DeleteObjectTaggingRequest request = new DeleteObjectTaggingRequest();
        request.bucketName = "sdk-oss-test";
        request.objectName = "test123456.txt";
        RuntimeObject runtimeObject = new RuntimeObject();
        DeleteObjectTaggingResponse response = client.DeleteObjectTagging(request, runtimeObject);
        Assert.assertNotNull(response.requestId);
    }

    @Test
    public void DeleteObjectTest() throws Exception {
        DeleteObjectRequest request = new DeleteObjectRequest();
        request.bucketName = "sdk-oss-test";
        request.objectName = "test123456.txt";
        RuntimeObject runtimeObject = new RuntimeObject();
        DeleteObjectResponse response = client.DeleteObject(request, runtimeObject);
        Assert.assertNotNull(response.requestId);
    }

    @Test
    public void PutObjectAclTest() throws Exception {
        PutObjectAclRequest request = new PutObjectAclRequest();
        PutObjectAclRequest.PutObjectAclRequestHeader header =  new  PutObjectAclRequest.PutObjectAclRequestHeader();
        header.objectAcl = "private";
        request.bucketName = "sdk-oss-test";
        request.objectName = "test123456.txt";
        request.header = header;
        RuntimeObject runtimeObject = new RuntimeObject();
        PutObjectAclResponse response = client.PutObjectAcl(request, runtimeObject);
        Assert.assertNotNull(response.requestId);
    }

    @Test
    public void GetObjectAclTest() throws Exception {
        GetObjectAclRequest request = new GetObjectAclRequest();
        request.bucketName = "sdk-oss-test";
        request.objectName = "test123456.txt";
        RuntimeObject runtimeObject = new RuntimeObject();
        GetObjectAclResponse response = client.GetObjectAcl(request, runtimeObject);
        Assert.assertNotNull(response.accessControlPolicy);
    }

    @Test
    public void PutSymlinkTest() throws Exception {
        PutSymlinkRequest request = new PutSymlinkRequest();
        PutSymlinkRequest.PutSymlinkRequestHeader header =  new  PutSymlinkRequest.PutSymlinkRequestHeader();
        header.symlinkTarget = "test123456.txt";
        request.bucketName = "sdk-oss-test";
        request.objectName = "test123456link.txt";
        request.header = header;
        RuntimeObject runtimeObject = new RuntimeObject();
        PutSymlinkResponse response = client.PutSymlink(request, runtimeObject);
        Assert.assertNotNull(response.requestId);
    }

    @Test
    public void GetSymlinkTest() throws Exception {
        GetSymlinkRequest request = new GetSymlinkRequest();
        request.bucketName = "sdk-oss-test";
        request.objectName = "test123456link.txt";
        RuntimeObject runtimeObject = new RuntimeObject();
        GetSymlinkResponse response = client.GetSymlink(request, runtimeObject);
        Assert.assertEquals("test123456.txt", response.symlinkTarget);
    }

    @Test
    public void RestoreObjectTest() throws Exception {
        RestoreObjectRequest request = new RestoreObjectRequest();
        request.bucketName = "sdk-oss-test";
        request.objectName = "obj.txt";
        RuntimeObject runtimeObject = new RuntimeObject();
        RestoreObjectResponse response = client.RestoreObject(request, runtimeObject);
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
        RuntimeObject runtimeObject = new RuntimeObject();
        InitiateMultipartUploadResponse response = client.InitiateMultipartUpload(request, runtimeObject);
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
        UploadPartResponse uploadPartResponse = client.UploadPart(uploadPartRequest, runtimeObject);
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
        UploadPartCopyResponse UploadPartCopyResponse = client.UploadPartCopy(uploadPartCopyRequest, runtimeObject);
        Assert.assertNotNull(UploadPartCopyResponse.copyPartResult);

        ListPartsRequest listPartsRequest = new ListPartsRequest();
        ListPartsRequest.ListPartsRequestFilter listPartsRequestFilter =
                new ListPartsRequest.ListPartsRequestFilter();
        listPartsRequestFilter.uploadId = this.uploadId;
        listPartsRequest.bucketName = "sdk-oss-test";
        listPartsRequest.objectName = "init.txt";
        listPartsRequest.filter = listPartsRequestFilter;
        ListPartsResponse listPartsResponse = client.ListParts(listPartsRequest, runtimeObject);
        Assert.assertNotNull(listPartsResponse.listPartsResult);

        AbortMultipartUploadRequest abortMultipartUploadRequest = new AbortMultipartUploadRequest();
        AbortMultipartUploadRequest.AbortMultipartUploadRequestFilter abortMultipartUploadRequestFilter =
                new AbortMultipartUploadRequest.AbortMultipartUploadRequestFilter();
        abortMultipartUploadRequestFilter.uploadId = this.uploadId;
        abortMultipartUploadRequest.bucketName = "sdk-oss-test";
        abortMultipartUploadRequest.objectName = "init.txt";
        abortMultipartUploadRequest.filter = abortMultipartUploadRequestFilter;
        AbortMultipartUploadResponse abortMultipartUploadResponse =
                client.AbortMultipartUpload(abortMultipartUploadRequest, runtimeObject);
        Assert.assertNotNull(abortMultipartUploadResponse.requestId);
    }

    @Test
    public void GetBucketCORSTest() throws Exception {
        GetBucketCORSRequest request = new GetBucketCORSRequest();
        request.bucketName = "sdk-oss-test";
        RuntimeObject runtimeObject = new RuntimeObject();
        GetBucketCORSResponse response = client.GetBucketCORS(request, runtimeObject);
        Assert.assertNotNull(response.cORSConfiguration);
    }

    @Test
    public void OptionObjectTest() throws Exception {
        OptionObjectRequest request = new OptionObjectRequest();
        OptionObjectRequest.OptionObjectRequestHeader header = new  OptionObjectRequest.OptionObjectRequestHeader();
        header.origin = "origin";
        header.accessControlRequestHeaders = "sdk";
        header.accessControlRequestMethod = "GET";
        request.bucketName = "sdk-oss-test";
        request.objectName = "obj.txt";
        request.header = header;
        RuntimeObject runtimeObject = new RuntimeObject();
        OptionObjectResponse response = client.OptionObject(request, runtimeObject);
        Assert.assertEquals("sdk", response.accessControlAllowHeaders);
    }

    @Test
    public void DeleteBucketCORSTest() throws Exception {
        DeleteBucketCORSRequest request = new DeleteBucketCORSRequest();
        request.bucketName = "sdk-oss-test";
        RuntimeObject runtimeObject = new RuntimeObject();
        DeleteBucketCORSResponse response = client.DeleteBucketCORS(request, runtimeObject);
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
        RuntimeObject runtimeObject = new RuntimeObject();
        PutLiveChannelStatusResponse response = client.PutLiveChannelStatus(request, runtimeObject);
        Assert.assertNotNull(response.requestId);
    }

    @Test
    @Ignore
    public void PostVodPlaylistTest() throws Exception {
        PostVodPlaylistRequest request = new PostVodPlaylistRequest();
        request.bucketName = "sdk-oss-test";
        request.channelName = "channelname";
        request.playlistName = "playlistname";
        RuntimeObject runtimeObject = new RuntimeObject();
        PostVodPlaylistResponse response = client.PostVodPlaylist(request, runtimeObject);
        Assert.assertNotNull(response.requestId);
    }

    @Test
    @Ignore
    public void GetVodPlaylistTest() throws Exception {
        GetVodPlaylistRequest request = new GetVodPlaylistRequest();
        request.bucketName = "sdk-oss-test";
        request.channelName = "channelname";
        RuntimeObject runtimeObject = new RuntimeObject();
        GetVodPlaylistResponse response = client.GetVodPlaylist(request, runtimeObject);
        Assert.assertNotNull(response.requestId);
    }

}

