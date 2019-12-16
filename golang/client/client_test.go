package client

import (
	"bytes"
	"os"
	"strings"
	"testing"

	"github.com/aliyun/alibabacloud-oss-sdk/baseclient/go/utils"
)

var config = new(Config).SetAccessKeyId(os.Getenv("ACCESS_KEY_ID")).
	SetAccessKeySecret(os.Getenv("ACCESS_KEY_SECRET")).
	SetType("access_key")

var runtimeObject = new(RuntimeObject).SetAutoretry(false).
	SetMd5Threshold(1000).
	SetMaxIdleConns(3)

// func Test_GetService(t *testing.T) {
// 	client, err := NewClient(config)
// 	utils.AssertNil(t, err)

// 	client.SignatureVersion = "V2"
// 	client.AddtionalHeaders = []string{"host"}
// 	setting := &GetServiceRequest{}
// 	filter := &GetServiceRequestFilter{}
// 	filter.SetPrefix("sdk").SetMarker("oss")
// 	setting.SetFilter(filter)

// 	resp, err := client.GetService(setting, runtimeObject)
// 	utils.AssertNil(t, err)

// 	utils.AssertNotNil(t, resp.RequestId)
// 	utils.AssertNotNil(t, resp.ListAllMyBucketsResult.Buckets)
// }

// func Test_PutBucket(t *testing.T) {
// 	client, err := NewClient(config)
// 	utils.AssertNil(t, err)

// 	client.SignatureVersion = "V2"
// 	client.AddtionalHeaders = []string{"host"}
// 	setting := new(PutBucketRequest).SetBucketName("sdk-oss-test")

// 	resp, err := client.PutBucket(setting, runtimeObject)
// 	utils.AssertNil(t, err)

// 	utils.AssertNotNil(t, resp.RequestId)
// }
var client *Client

func init() {
	client, _ = NewClient(config)
	client.SignatureVersion = "V2"
}

var uploadId = ""

func Test_GetBucketInfo(t *testing.T) {
	client.AddtionalHeaders = []string{"host"}
	setting := new(GetBucketInfoRequest).SetBucketName("sdk-oss-test")

	resp, err := client.GetBucketInfo(setting, runtimeObject)
	utils.AssertNil(t, err)

	utils.AssertEqual(t, len(*resp.RequestId), 24)
	utils.AssertNotNil(t, resp.BucketInfo)
}

func Test_PutBucketAcl(t *testing.T) {
	header := new(PutBucketAclRequestHeader).SetAcl("public-read")
	setting := new(PutBucketAclRequest).SetBucketName("sdk-oss-test").
		SetHeader(header)
	resp, err := client.PutBucketAcl(setting, runtimeObject)
	utils.AssertNil(t, err)
	utils.AssertEqual(t, len(*resp.RequestId), 24)
}

// func Test_PutBucketLogging(t *testing.T) {
// 	client, err := NewClient(config)
// 	utils.AssertNil(t, err)
// 	enabled := new(PutBucketLoggingRequestBodyBucketLoggingStatusLoggingEnabled).
// 		SetTargetBucket("sdk-script").
// 		SetTargetPrefix("sdk")
// 	status := new(PutBucketLoggingRequestBodyBucketLoggingStatus).
// 		SetLoggingEnabled(enabled)
// 	body := new(PutBucketLoggingRequestBody).
// 		SetBucketLoggingStatus(status)
// 	setting := new(PutBucketLoggingRequest).SetBucketName("sdk-oss-test").
// 		SetBody(body)
// 	resp, err := client.PutBucketLogging(setting, runtimeObject)
// 	utils.AssertNil(t, err)
// 	utils.AssertNotNil(t, resp.RequestId)
// }

// func Test_PutBucketWebsite(t *testing.T) {
// 	client, err := NewClient(config)
// 	utils.AssertNil(t, err)
// 	setting := new(PutBucketWebsiteRequest).SetBucketName("sdk-oss-test")
// 	resp, err := client.PutBucketWebsite(setting, runtimeObject)
// 	utils.AssertNil(t, err)
// 	utils.AssertNotNil(t, resp.RequestId)
// }

// func Test_PutBucketReferer(t *testing.T) {
// 	client, err := NewClient(config)
// 	utils.AssertNil(t, err)
// 	setting := new(PutBucketRefererRequest).SetBucketName("sdk-oss-test")
// 	resp, err := client.PutBucketReferer(setting, runtimeObject)
// 	utils.AssertNil(t, err)
// 	utils.AssertNotNil(t, resp.RequestId)
// }

// func Test_PutBucketLifecycle(t *testing.T) {
// 	client, err := NewClient(config)
// 	utils.AssertNil(t, err)
// 	setting := new(PutBucketLifecycleRequest).SetBucketName("sdk-oss-test")
// 	resp, err := client.PutBucketLifecycle(setting, runtimeObject)
// 	utils.AssertNil(t, err)
// 	utils.AssertNotNil(t, resp.RequestId)
// }

func Test_GetBucket(t *testing.T) {
	setting := new(GetBucketRequest).SetBucketName("sdk-oss-test")
	resp, err := client.GetBucket(setting, runtimeObject)
	utils.AssertNil(t, err)
	utils.AssertNotNil(t, resp.RequestId)
	utils.AssertNotNil(t, resp.ListBucketResult)
}

func Test_GetBucketLogging(t *testing.T) {
	setting := &GetBucketLoggingRequest{}
	setting.SetBucketName("sdk-oss-test")
	resp, err := client.GetBucketLogging(setting, runtimeObject)
	utils.AssertNil(t, err)
	utils.AssertNotNil(t, resp.RequestId)
	utils.AssertNotNil(t, resp.BucketLoggingStatus)
}

func Test_GetBucketLoggingWithError(t *testing.T) {
	config1 := &Config{}
	config1.SetAccessKeyId("sfasdfagfsg").SetAccessKeySecret("agffdswertret")
	clientError, err := NewClient(config1)
	utils.AssertNil(t, err)

	setting := &GetBucketLoggingRequest{}
	setting.SetBucketName("sdk-oss-test")
	resp, err := clientError.GetBucketLogging(setting, runtimeObject)
	utils.AssertContains(t, err.Error(), "The OSS Access Key Id you provided does not exist in our records")
	utils.AssertNil(t, resp)
}

// func Test_GetBucketWebsite(t *testing.T) {
// 	client, err := NewClient(config)
// 	utils.AssertNil(t, err)
// 	setting := new(GetBucketWebsiteRequest).SetBucketName("sdk-oss-test")
// 	resp, err := client.GetBucketWebsite(setting, runtimeObject)
// 	utils.AssertNil(t, err)
// 	utils.AssertNotNil(t, resp.RequestId)
// }

func Test_GetBucketReferer(t *testing.T) {
	setting := new(GetBucketRefererRequest).SetBucketName("sdk-oss-test")
	resp, err := client.GetBucketReferer(setting, runtimeObject)
	utils.AssertNil(t, err)
	utils.AssertNotNil(t, resp.RequestId)
	utils.AssertNotNil(t, resp.RefererConfiguration)
}

func Test_GetBucketLifecycle(t *testing.T) {
	setting := new(GetBucketLifecycleRequest).SetBucketName("sdk-oss-test")
	resp, err := client.GetBucketLifecycle(setting, runtimeObject)
	utils.AssertNil(t, err)
	utils.AssertNotNil(t, resp.RequestId)
	utils.AssertNotNil(t, resp.LifecycleConfiguration)
}

func Test_GetBucketAcl(t *testing.T) {
	setting := new(GetBucketAclRequest).SetBucketName("sdk-oss-test")
	resp, err := client.GetBucketAcl(setting, runtimeObject)
	utils.AssertNil(t, err)
	utils.AssertNotNil(t, resp.RequestId)
	utils.AssertNotNil(t, resp.AccessControlPolicy)
}

func Test_GetBucketLocation(t *testing.T) {
	setting := new(GetBucketLocationRequest).SetBucketName("sdk-oss-test")
	resp, err := client.GetBucketLocation(setting, runtimeObject)
	utils.AssertNil(t, err)
	utils.AssertNotNil(t, resp.RequestId)
	utils.AssertNotNil(t, resp.LocationConstraint)
}

func Test_DeleteBucketLogging(t *testing.T) {
	setting := new(DeleteBucketLoggingRequest).SetBucketName("sdk-oss-test")
	resp, err := client.DeleteBucketLogging(setting, runtimeObject)
	utils.AssertNil(t, err)
	utils.AssertNotNil(t, resp.RequestId)
}

func Test_DeleteBucketWebsite(t *testing.T) {
	setting := new(DeleteBucketWebsiteRequest).SetBucketName("sdk-oss-test")
	resp, err := client.DeleteBucketWebsite(setting, runtimeObject)
	utils.AssertNil(t, err)
	utils.AssertNotNil(t, resp.RequestId)
}

func Test_DeleteBucketLifecycle(t *testing.T) {
	setting := new(DeleteBucketLifecycleRequest).SetBucketName("sdk-oss-test")
	resp, err := client.DeleteBucketLifecycle(setting, runtimeObject)
	utils.AssertNil(t, err)
	utils.AssertNotNil(t, resp.RequestId)
}

func Test_PutObject(t *testing.T) {
	obj := bytes.NewReader([]byte("value"))
	setting := &PutObjectRequest{}
	header := &PutObjectRequestHeader{}
	header.SetStorageClass("Archive")
	setting.SetBucketName("sdk-oss-test").
		SetObjectName("tmp.txt").
		SetBody(obj).
		SetHeader(header)
	resp, err := client.PutObject(setting, runtimeObject)
	utils.AssertNil(t, err)
	utils.AssertNotNil(t, resp.RequestId)
	utils.AssertNotNil(t, resp.HashCrc64ecma)
}

func Test_CopyObject(t *testing.T) {
	setting := &CopyObjectRequest{}
	header := &CopyObjectRequestHeader{}
	header.SetCopySource("/sdk-oss-test/source.txt")
	setting.SetBucketName("sdk-oss-test").
		SetDestObjectName("dest.txt").
		SetHeader(header)
	resp, err := client.CopyObject(setting, runtimeObject)
	utils.AssertNil(t, err)
	utils.AssertNotNil(t, resp.RequestId)
}

func Test_AppendObject(t *testing.T) {
	setting := &AppendObjectRequest{}
	filter := &AppendObjectRequestFilter{}
	filter.SetPosition("0")
	setting.SetBucketName("sdk-oss-test").
		SetObjectName("test1.txt").
		SetBody(strings.NewReader("oss")).
		SetFilter(filter)
	resp, err := client.AppendObject(setting, runtimeObject)
	utils.AssertNil(t, err)
	utils.AssertNotNil(t, resp.RequestId)
}

// func Test_DeleteMultipleObjects(t *testing.T) {
// 	client, err := NewClient(config)
// 	utils.AssertNil(t, err)

// 	client.SignatureVersion = "V2"
// 	client.IsEnableMD5 = true
// 	setting := &DeleteMultipleObjectsRequest{}
// 	body := &DeleteMultipleObjectsRequestBody{}
// 	delete := &DeleteMultipleObjectsRequestBodyDelete{}
// 	object := &DeleteMultipleObjectsRequestBodyDeleteObject{}
// 	object.SetKey("f.txt")
// 	delete.SetObject([]*DeleteMultipleObjectsRequestBodyDeleteObject{object})
// 	body.SetDelete(delete)
// 	setting.SetBucketName("sdk-script")
// 	setting.SetBody(body)
// 	resp, err := client.DeleteMultipleObjects(setting, runtimeObject)
// 	utils.AssertNil(t, err)
// 	utils.AssertNotNil(t, resp.RequestId)
// }

func Test_GetObject(t *testing.T) {
	setting := &GetObjectRequest{}
	setting.SetBucketName("sdk-oss-test").
		SetObjectName("append.txt")
	resp, err := client.GetObject(setting, runtimeObject)
	utils.AssertNil(t, err)
	utils.AssertNotNil(t, resp.RequestId)
	utils.AssertNotNil(t, resp.Body)
}

func Test_GetObjectTagging(t *testing.T) {

	setting := &GetObjectTaggingRequest{}
	setting.SetBucketName("sdk-oss-test").
		SetObjectName("append.txt")
	resp, err := client.GetObjectTagging(setting, runtimeObject)
	utils.AssertNil(t, err)
	utils.AssertNotNil(t, resp.RequestId)
}

func Test_GetObjectMeta(t *testing.T) {
	setting := &GetObjectMetaRequest{}
	setting.SetBucketName("sdk-oss-test").
		SetObjectName("dest.txt")
	resp, err := client.GetObjectMeta(setting, runtimeObject)
	utils.AssertNil(t, err)
	utils.AssertNotNil(t, resp.RequestId)
}

func Test_DeleteObjectTagging(t *testing.T) {
	setting := &DeleteObjectTaggingRequest{}
	setting.SetBucketName("sdk-oss-test").
		SetObjectName("append.txt")
	resp, err := client.DeleteObjectTagging(setting, runtimeObject)
	utils.AssertNil(t, err)
	utils.AssertNotNil(t, resp.RequestId)
}

func Test_DeleteObject(t *testing.T) {
	setting := &DeleteObjectRequest{}
	setting.SetBucketName("sdk-oss-test").
		SetObjectName("append.txt")
	resp, err := client.DeleteObject(setting, runtimeObject)
	utils.AssertNil(t, err)
	utils.AssertNotNil(t, resp.RequestId)
}

func Test_HeadObject(t *testing.T) {
	setting := &HeadObjectRequest{}
	setting.SetBucketName("sdk-oss-test").
		SetObjectName("obj.txt")
	resp, err := client.HeadObject(setting, runtimeObject)
	utils.AssertNil(t, err)
	utils.AssertNotNil(t, resp.RequestId)
	utils.AssertNotNil(t, resp.LastModified)
}

func Test_PutObjectACL(t *testing.T) {
	setting := &PutObjectAclRequest{}
	header := &PutObjectAclRequestHeader{}
	header.SetObjectAcl("private")
	setting.SetBucketName("sdk-oss-test").
		SetObjectName("dest.txt").
		SetHeader(header)
	resp, err := client.PutObjectAcl(setting, runtimeObject)
	utils.AssertNil(t, err)
	utils.AssertNotNil(t, resp.RequestId)
}

func Test_GetObjectACL(t *testing.T) {
	setting := &GetObjectAclRequest{}
	setting.SetBucketName("sdk-oss-test").
		SetObjectName("dest.txt")
	resp, err := client.GetObjectAcl(setting, runtimeObject)
	utils.AssertNil(t, err)
	utils.AssertNotNil(t, resp.RequestId)
	utils.AssertNotNil(t, resp.AccessControlPolicy.AccessControlList.Grant)
}

func Test_PutSymlink(t *testing.T) {
	setting := &PutSymlinkRequest{}
	header := &PutSymlinkRequestHeader{}
	header.SetSymlinkTarget("dest.txt")
	setting.SetBucketName("sdk-oss-test").
		SetObjectName("source.txt").
		SetHeader(header)
	resp, err := client.PutSymlink(setting, runtimeObject)
	utils.AssertNil(t, err)
	utils.AssertNotNil(t, resp.RequestId)
}

func Test_GetSymlink(t *testing.T) {
	setting := &GetSymlinkRequest{}
	setting.SetBucketName("sdk-oss-test").
		SetObjectName("source.txt")
	resp, err := client.GetSymlink(setting, runtimeObject)
	utils.AssertNil(t, err)
	utils.AssertNotNil(t, resp.RequestId)
}

func Test_RestoreObject(t *testing.T) {
	setting := &RestoreObjectRequest{}
	setting.SetBucketName("sdk-oss-test").
		SetObjectName("obj.txt")
	resp, err := client.RestoreObject(setting, runtimeObject)
	utils.AssertNil(t, err)
	utils.AssertNotNil(t, resp.RequestId)
}

// func Test_SelectObject(t *testing.T) {
// 	client, err := NewClient(config)
// 	utils.AssertNil(t, err)

// 	client.SignatureVersion = "V2"
// 	client.IsEnableMD5 = true
// 	client.IsEnableCrc = true
// 	setting := &SelectObjectRequest{}
// 	filter := &SelectObjectRequestFilter{}
// 	filter.SetPorcess("json/select")
// 	body := &SelectObjectRequestBody{}
// 	selectRequest := &SelectObjectRequestBodySelectRequest{}
// 	selectRequest.SetExpression(base64.StdEncoding.EncodeToString([]byte("Select * from OSSOBJECT")))
// 	body.SetSelectRequest(selectRequest)
// 	setting.SetBody(body).
// 		SetBucketName("sdk-script").
// 		SetObjectName("d.txt").
// 		SetFilter(filter)
// 	resp, err := client.SelectObject(setting, runtimeObject)
// 	utils.AssertNil(t, err)
// 	utils.AssertNotNil(t, resp.RequestId)
// }

// func Test_PutObjectTagging(t *testing.T) {
// 	client, err := NewClient(config)
// 	utils.AssertNil(t, err)

// 	client.SignatureVersion = "V2"
// 	setting := &PutObjectTaggingRequest{}
// 	body := &PutObjectTaggingRequestBody{}
// 	tagging := &PutObjectTaggingRequestBodyTagging{}
// 	tagSet := &PutObjectTaggingRequestBodyTaggingTagSet{}
// 	tag := &PutObjectTaggingRequestBodyTaggingTagSetTag{}
// 	tag.SetKey("oss").SetValue("test")
// 	tagSet.SetTag([]*PutObjectTaggingRequestBodyTaggingTagSetTag{tag})
// 	tagging.SetTagSet(tagSet)
// 	body.SetTagging(tagging)
// 	setting.SetBody(body).
// 		SetBucketName("sdk-script").
// 		SetObjectName("a.txt")
// 	resp, err := client.PutObjectTagging(setting, runtimeObject)
// 	utils.AssertNil(t, err)
// 	utils.AssertNotNil(t, resp.RequestId)
// }

func Test_InitiateMultipartUpload(t *testing.T) {
	filter := new(InitiateMultipartUploadRequestFilter).SetEncodingType("url")
	setting := new(InitiateMultipartUploadRequest).SetBucketName("sdk-oss-test").
		SetObjectName("init.txt").
		SetFilter(filter)
	resp, err := client.InitiateMultipartUpload(setting, runtimeObject)
	utils.AssertNil(t, err)
	utils.AssertNotNil(t, resp.RequestId)
	uploadId = *resp.InitiateMultipartUploadResult.UploadId
}

func Test_UploadPart(t *testing.T) {
	body := strings.NewReader("oss test")
	filter := new(UploadPartRequestFilter).SetPartNumber("1").
		SetUploadId(uploadId)
	setting := new(UploadPartRequest).SetBucketName("sdk-oss-test").
		SetObjectName("init.txt").
		SetFilter(filter).
		SetBody(body)
	resp, err := client.UploadPart(setting, runtimeObject)
	utils.AssertNil(t, err)
	utils.AssertNotNil(t, resp.RequestId)
}

func Test_UploadPartCopy(t *testing.T) {
	filter := new(UploadPartCopyRequestFilter).SetPartNumber("1").
		SetUploadId(uploadId)
	header := new(UploadPartCopyRequestHeader).
		SetCopySource("/sdk-oss-test/obj.txt").
		SetCopySourceRange("1")
	setting := new(UploadPartCopyRequest).SetBucketName("sdk-oss-test").
		SetObjectName("init.txt").
		SetFilter(filter).
		SetHeader(header)
	resp, err := client.UploadPartCopy(setting, runtimeObject)
	utils.AssertNil(t, err)
	utils.AssertNotNil(t, resp.RequestId)
}

func Test_ListParts(t *testing.T) {
	filter := new(ListPartsRequestFilter).SetUploadId(uploadId)
	setting := new(ListPartsRequest).SetBucketName("sdk-oss-test").
		SetObjectName("init.txt").
		SetFilter(filter)
	resp, err := client.ListParts(setting, runtimeObject)
	utils.AssertNil(t, err)
	utils.AssertNotNil(t, resp.RequestId)
}

// func Test_ListMultipartUploads(t *testing.T) {
// 	client, err := NewClient(config)
// 	utils.AssertNil(t, err)

// 	client.SignatureVersion = "V2"
// 	setting := new(ListMultipartUploadsRequest).SetBucketName("sdk-oss-test")
// 	resp, err := client.ListMultipartUploads(setting, runtimeObject)
// 	utils.AssertNil(t, err)
// 	utils.AssertNotNil(t, resp.RequestId)
// }

func Test_AbortMultipartUpload(t *testing.T) {
	filter := new(AbortMultipartUploadRequestFilter).SetUploadId(uploadId)
	setting := new(AbortMultipartUploadRequest).SetBucketName("sdk-oss-test").
		SetObjectName("init.txt").
		SetFilter(filter)
	resp, err := client.AbortMultipartUpload(setting, runtimeObject)
	utils.AssertNil(t, err)
	utils.AssertNotNil(t, resp.RequestId)
}

// func Test_PutBucketCORS(t *testing.T) {
// 	client, err := NewClient(config)
// 	utils.AssertNil(t, err)

// 	client.SignatureVersion = "V2"
// 	setting := new(PutBucketCORSRequest).SetBucketName("sdk-oss-test")
// 	resp, err := client.PutBucketCORS(setting, runtimeObject)
// 	utils.AssertNil(t, err)
// 	utils.AssertNotNil(t, resp.RequestId)
// }

func Test_GetBucketCORS(t *testing.T) {
	setting := new(GetBucketCORSRequest).SetBucketName("sdk-oss-test")
	resp, err := client.GetBucketCORS(setting, runtimeObject)
	utils.AssertNil(t, err)
	utils.AssertNotNil(t, resp.RequestId)
}

func Test_OptionObject(t *testing.T) {
	header := new(OptionObjectRequestHeader).SetOrigin("origin").
		SetAccessControlRequestHeaders("sdk").
		SetAccessControlRequestMethod("GET")
	setting := new(OptionObjectRequest).SetBucketName("sdk-oss-test").
		SetObjectName("obj.txt").
		SetHeader(header)
	resp, err := client.OptionObject(setting, runtimeObject)
	utils.AssertNil(t, err)
	utils.AssertNotNil(t, resp.RequestId)
}

func Test_DeleteBucketCORS(t *testing.T) {
	setting := new(DeleteBucketCORSRequest).SetBucketName("sdk-oss-test")
	resp, err := client.DeleteBucketCORS(setting, runtimeObject)
	utils.AssertNil(t, err)
	utils.AssertNotNil(t, resp.RequestId)
}

// func Test_PutLiveChannel(t *testing.T) {
// 	client, err := NewClient(config)
// 	utils.AssertNil(t, err)

// 	client.SignatureVersion = "V2"
// 	setting := new(PutLiveChannelRequest).SetBucketName("sdk-oss-test").
// 		SetChannelName("channelname")
// 	resp, err := client.PutLiveChannel(setting, runtimeObject)
// 	utils.AssertNil(t, err)
// 	utils.AssertNotNil(t, resp.RequestId)
// }

func Test_PutLiveChannelStatus(t *testing.T) {
	filter := new(PutLiveChannelStatusRequestFilter).SetStatus("enabled")
	setting := new(PutLiveChannelStatusRequest).SetBucketName("sdk-oss-test").
		SetChannelName("OSS").
		SetFilter(filter)
	resp, err := client.PutLiveChannelStatus(setting, runtimeObject)
	utils.AssertNil(t, err)
	utils.AssertNotNil(t, resp.RequestId)
}

func Test_PostVodPlaylist(t *testing.T) {
	setting := new(PostVodPlaylistRequest).SetBucketName("sdk-oss-test").
		SetChannelName("channelname").
		SetPlaylistName("playlistname")
	resp, err := client.PostVodPlaylist(setting, runtimeObject)
	utils.AssertNil(t, err)
	utils.AssertNotNil(t, resp.RequestId)
}

func Test_GetVodPlaylist(t *testing.T) {
	setting := new(GetVodPlaylistRequest).SetBucketName("sdk-oss-test").
		SetChannelName("channelname")
	resp, err := client.GetVodPlaylist(setting, runtimeObject)
	utils.AssertNil(t, err)
	utils.AssertNotNil(t, resp.RequestId)
}

func Test_GetLiveChannelStat(t *testing.T) {
	setting := new(GetLiveChannelStatRequest).SetBucketName("sdk-oss-test").
		SetChannelName("channelname")
	resp, err := client.GetLiveChannelStat(setting, runtimeObject)
	utils.AssertNil(t, err)
	utils.AssertNotNil(t, resp.RequestId)
}

func Test_GetLiveChannelInfo(t *testing.T) {
	setting := new(GetLiveChannelInfoRequest).SetBucketName("sdk-oss-test").
		SetChannelName("channelname")
	resp, err := client.GetLiveChannelInfo(setting, runtimeObject)
	utils.AssertNil(t, err)
	utils.AssertNotNil(t, resp.RequestId)
}

func Test_GetLiveChannelHistory(t *testing.T) {
	setting := new(GetLiveChannelHistoryRequest).SetBucketName("sdk-oss-test").
		SetChannelName("channelname")
	resp, err := client.GetLiveChannelHistory(setting, runtimeObject)
	utils.AssertNil(t, err)
	utils.AssertNotNil(t, resp.RequestId)
}

func Test_ListLiveChannel(t *testing.T) {
	setting := new(ListLiveChannelRequest).SetBucketName("sdk-oss-test")
	resp, err := client.ListLiveChannel(setting, runtimeObject)
	utils.AssertNil(t, err)
	utils.AssertNotNil(t, resp.RequestId)
}

func Test_DeleteLiveChannel(t *testing.T) {
	setting := new(DeleteLiveChannelRequest).SetBucketName("sdk-oss-test").
		SetChannelName("channelname")
	resp, err := client.DeleteLiveChannel(setting, runtimeObject)
	utils.AssertNil(t, err)
	utils.AssertNotNil(t, resp.RequestId)
}

func Test_DeleteBucket(t *testing.T) {
	setting := new(DeleteBucketRequest).SetBucketName("sdk-oss-test")
	resp, err := client.DeleteBucket(setting, runtimeObject)
	utils.AssertNil(t, err)
	utils.AssertNotNil(t, resp.RequestId)
}
