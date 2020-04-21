package client

import (
	"bytes"
	"os"
	"testing"

	ossutil "github.com/alibabacloud-go/tea-oss-utils/service"
	"github.com/alibabacloud-go/tea/tea"
	"github.com/alibabacloud-go/tea/utils"
)

var config = new(Config).SetAccessKeyId(os.Getenv("ACCESS_KEY_ID")).
	SetAccessKeySecret(os.Getenv("ACCESS_KEY_SECRET")).
	SetType("access_key")

var runtimeObject = new(ossutil.RuntimeOptions).SetAutoretry(false).
	SetMaxIdleConns(3)

var client *Client

func init() {
	client, _ = NewClient(config)
	client.SignatureVersion = tea.String("V2")
}

func Test_PutBucketReferer(t *testing.T) {
	str := "oss sdk"
	refers := []*string{&str}
	referList := new(PutBucketRefererRequestBodyRefererConfigurationRefererList).SetReferer(refers)
	conf := new(PutBucketRefererRequestBodyRefererConfiguration).SetAllowEmptyReferer(true).SetRefererList(referList)
	body := new(PutBucketRefererRequestBody).SetRefererConfiguration(conf)
	setting := new(PutBucketRefererRequest).SetBucketName("sdk-oss-test").
		SetBody(body)
	resp, err := client.PutBucketReferer(setting, runtimeObject)
	utils.AssertNil(t, err)
	utils.AssertNotNil(t, resp.RequestId)
}

func Test_GetBucketReferer(t *testing.T) {
	setting := new(GetBucketRefererRequest).SetBucketName("sdk-oss-test")
	resp, err := client.GetBucketReferer(setting, runtimeObject)
	utils.AssertNil(t, err)
	utils.AssertNotNil(t, resp.RequestId)
	utils.AssertNotNil(t, resp.RefererConfiguration)
}

func Test_PutObject(t *testing.T) {
	client.IsEnableMD5 = tea.Bool(true)
	client.IsEnableCrc = tea.Bool(true)
	obj := bytes.NewReader([]byte("value"))
	setting := &PutObjectRequest{}
	header := &PutObjectRequestHeader{}
	header.SetStorageClass("Standard")
	setting.SetBucketName("sdk-oss-test").
		SetObjectName("go.txt").
		SetBody(obj).
		SetHeader(header)
	resp, err := client.PutObject(setting, runtimeObject)
	utils.AssertNil(t, err)
	utils.AssertNotNil(t, resp.RequestId)
	utils.AssertNotNil(t, resp.HashCrc64ecma)
}

func Test_GetObject(t *testing.T) {
	setting := &GetObjectRequest{}
	setting.SetBucketName("sdk-oss-test").
		SetObjectName("go.txt")
	resp, err := client.GetObject(setting, runtimeObject)
	utils.AssertNil(t, err)
	utils.AssertNotNil(t, resp.RequestId)
	utils.AssertNotNil(t, resp.Body)
}

func Test_DeleteObject(t *testing.T) {
	setting := &DeleteObjectRequest{}
	setting.SetBucketName("sdk-oss-test").
		SetObjectName("go.txt")
	resp, err := client.DeleteObject(setting, runtimeObject)
	utils.AssertNil(t, err)
	utils.AssertNotNil(t, resp.RequestId)
}
