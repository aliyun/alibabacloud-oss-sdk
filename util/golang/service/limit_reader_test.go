package service

import (
	"io/ioutil"
	"strings"
	"testing"

	"github.com/aliyun/alibabacloud-oss-sdk/baseclient/go/utils"
)

func Test_LimitSpeedReader(t *testing.T) {
	limiter := GetOssLimiter(10)
	limitReader := &LimitSpeedReader{
		ossLimiter: limiter,
		reader:     strings.NewReader("oss"),
	}
	limitReader.ReadCloser = ioutil.NopCloser(strings.NewReader("oss"))
	tmp := make([]byte, 3)
	n, err := limitReader.Read(tmp)
	utils.AssertNil(t, err)
	utils.AssertEqual(t, 3, n)

	err = limitReader.Close()
	utils.AssertNil(t, err)

	limiter = GetOssLimiter(0)
	body := make([]byte, 2048)
	limitReader.ossLimiter = limiter
	n, err = limitReader.Read(body)
	utils.AssertEqual(t, "EOF", err.Error())
	utils.AssertEqual(t, 0, n)

	limitReader.reader = ioutil.NopCloser(strings.NewReader("oss"))
	err = limitReader.Close()
	utils.AssertNil(t, err)

}
