package service

import (
	"encoding/json"
	"io"
	"io/ioutil"
	"net/http"
	"strings"
	"testing"

	"github.com/alibabacloud-go/tea/tea"
	"github.com/aliyun/alibabacloud-oss-sdk/baseclient/go/utils"
)

var client = new(BaseClient)

type ConfigTest struct {
	AccessKeyId     *string `json:"accessKeyId" xml:"accessKeyId"`
	AccessKeySecret *string `json:"accessKeySecret" xml:"accessKeySecret"`
	Type            *string `json:"type" xml:"type" require:"true"`
	SecurityToken   *string `json:"securityToken" xml:"securityToken"`
	Endpoint        *string `json:"endpoint" xml:"endpoint" require:"true"`
	Protocol        *string `json:"protocol" xml:"protocol" require:"true"`
	RegionId        *string `json:"regionId" xml:"regionId" require:"true"`
}

func Test_InitClient(t *testing.T) {
	accessKeyId, accessKeySecret, securityToken, credentialType := "accessKeyId", "accessKeySecret", "securityToken", "sts"
	configTest := &ConfigTest{
		AccessKeyId: &accessKeyId,
	}

	byt, _ := json.Marshal(configTest)
	config := make(map[string]interface{})
	json.Unmarshal(byt, &config)
	err := client.InitClient(config)
	utils.AssertEqual(t, "AccessKeySecret cannot be empty", err.Error())

	configTest = &ConfigTest{
		AccessKeyId:     &accessKeyId,
		AccessKeySecret: &accessKeySecret,
		SecurityToken:   &securityToken,
		Type:            &credentialType,
	}

	byt, _ = json.Marshal(configTest)
	json.Unmarshal(byt, &config)
	err = client.InitClient(config)
	utils.AssertNil(t, err)
}

func Test_GetAuth(t *testing.T) {
	originCredential := client.credential
	client.credential = nil
	request := tea.NewRequest()
	request.Headers["host"] = "oss.aliyun.com"
	auth := client.GetAuth(request, "oss")
	utils.AssertEqual(t, "", auth)

	client.credential = originCredential
	auth = client.GetAuth(request, "oss")
	utils.AssertEqual(t, "OSS accessKeyId:pKbGkl6i6KlGaQPl9QWFqNw1wuw=", auth)

	client.SignatureVersion = "V2"
	auth = client.GetAuth(request, "oss")
	utils.AssertEqual(t, "OSS2 AccessKeyId:accessKeyId,Signature:ec99QpyH6hbQIJAJayQksSGkXcepQw5vfsw9zik0tkA=", auth)

	client.SignatureVersion = "V2"
	client.AddtionalHeaders = []string{"host"}
	auth = client.GetAuth(request, "oss")
	utils.AssertEqual(t, "OSS2 AccessKeyId:accessKeyId,AdditionalHeaders:host,Signature:NqYFfxGjPjmSSQVqQtvao7jRs2VKvgqh1Hj9wS6SLaA=", auth)
}

func Test_GetHost(t *testing.T) {
	host := client.GetHost("")
	utils.AssertEqual(t, "oss-cn-hangzhou.aliyuncs.com", host)

	host = client.GetHost("oss")
	utils.AssertEqual(t, "oss.oss-cn-hangzhou.aliyuncs.com", host)

	client.HostModel = "cname"
	host = client.GetHost("oss")
	utils.AssertEqual(t, "oss-cn-hangzhou.aliyuncs.com", host)

	client.HostModel = "ip"
	host = client.GetHost("oss")
	utils.AssertEqual(t, "oss-cn-hangzhou.aliyuncs.com/oss", host)
}

// func Test_GetCrc(t *testing.T) {
// 	listener := &listenerTest{}
// 	tracker := client.GetTracker()
// 	request := tea.NewRequest()
// 	crc := client.GetCrc(request, "0", listener, tracker)
// 	utils.AssertNil(t, crc)

// 	client.IsEnableCrc = true
// 	crc = client.GetCrc(request, "0", listener, tracker)
// 	utils.AssertEqual(t, uint64(0), crc.Sum64())
// }

// func Test_GetRespCrc(t *testing.T) {
// 	listener := &listenerTest{}
// 	tracker := client.GetTracker()
// 	httpResp := &http.Response{
// 		Body:          ioutil.NopCloser(strings.NewReader("oss")),
// 		ContentLength: 10,
// 	}
// 	resp := tea.NewResponse(httpResp)
// 	crc := client.GetRespCrc(resp, true, listener, tracker)
// 	utils.AssertNil(t, crc)

// 	crc = client.GetRespCrc(resp, false, listener, tracker)
// 	utils.AssertEqual(t, uint64(0), crc.Sum64())
// }

// func Test_IsNotCrcMatched(t *testing.T) {
// 	client.IsEnableCrc = false
// 	notmatch := client.IsNotCrcMatched(nil, "oss")
// 	utils.AssertEqual(t, false, notmatch)

// 	client.IsEnableCrc = true
// 	crc := NewCRC(crcTable(), uint64(64))
// 	notmatch = client.IsNotCrcMatched(crc, "oss")
// 	utils.AssertEqual(t, true, notmatch)
// }

func Test_GetUserAgent(t *testing.T) {
	ua := client.GetUserAgent()
	utils.AssertContains(t, ua, "Core/0.01")

	client.UserAgent = "ua"
	ua = client.GetUserAgent()
	utils.AssertContains(t, ua, "Core/0.01 ua")
}

func Test_ParseUint(t *testing.T) {
	val := client.ParseUint("respCrc", true)
	utils.AssertEqual(t, uint64(0), val)

	val = client.ParseUint("respCrc", false)
	utils.AssertEqual(t, uint64(0), val)

	val = client.ParseUint("64", false)
	utils.AssertEqual(t, uint64(64), val)
}

// func Test_IsUploadSpeedLimit(t *testing.T) {
// 	body := strings.NewReader("oss")
// 	read := client.IsUploadSpeedLimit(body, 0)
// 	byt, err := ioutil.ReadAll(read)
// 	utils.AssertNil(t, err)
// 	utils.AssertEqual(t, "oss", string(byt))

// 	body = strings.NewReader("oss")
// 	read = client.IsUploadSpeedLimit(body, 3)
// 	byt, err = ioutil.ReadAll(read)
// 	utils.AssertNil(t, err)
// 	utils.AssertEqual(t, "oss", string(byt))
// }

func Test_DefaultNumber(t *testing.T) {
	num := client.DefaultNumber(0, 1)
	utils.AssertEqual(t, 1, num)

	num = client.DefaultNumber(2, 1)
	utils.AssertEqual(t, 2, num)
}

func Test_Default(t *testing.T) {
	str := client.Default("", "1")
	utils.AssertEqual(t, "1", str)

	str = client.Default("2", "1")
	utils.AssertEqual(t, "2", str)
}

func Test_GetDate(t *testing.T) {
	time := client.GetDate()
	utils.AssertEqual(t, 29, len(time))
}

func Test_ToQuery(t *testing.T) {
	input := map[string]interface{}{
		"key":   "ccp",
		"value": "ok",
	}
	out := client.ToQuery(input)
	utils.AssertEqual(t, "ccp", out["key"])
	utils.AssertEqual(t, "ok", out["value"])
}

// func Test_IfRange(t *testing.T) {
// 	input := map[string]interface{}{
// 		"oss": "ok",
// 		"num": 10,
// 	}
// 	ifrange := client.IfRange(input)
// 	utils.AssertEqual(t, false, ifrange)

// 	input = map[string]interface{}{
// 		"oss": "ok",
// 	}
// 	ifrange = client.IfRange(input)
// 	utils.AssertEqual(t, false, ifrange)

// 	input = map[string]interface{}{
// 		"oss":   "ok",
// 		"Range": "ok",
// 	}
// 	ifrange = client.IfRange(input)
// 	utils.AssertEqual(t, true, ifrange)
// }

func Test_ToMeta(t *testing.T) {
	meta := map[string]string{
		"a": "ok",
	}
	result := client.ToMeta(meta, "x-oss-")
	utils.AssertEqual(t, "ok", result["x-oss-a"])
}

type Resp struct {
	Num *int    `json:"num" xml:"num"`
	Str *string `json:"str" xml:"str"`
}

func Test_ToBody(t *testing.T) {
	input := map[string]string{
		"oss": "ok",
	}
	body := client.ToBody(input)
	utils.AssertNil(t, body)

	con := &Resp{
		Num: &num,
		Str: &str1,
	}
	body = client.ToBody(con)
	utils.AssertNotNil(t, body)
}

func Test_GetSpecialValue(t *testing.T) {
	val := client.GetSpecialValue(map[string]interface{}{"key": "value"}, "oss")
	utils.AssertEqual(t, "", val)

	val = client.GetSpecialValue(map[string]interface{}{"key": "value"}, "key")
	utils.AssertEqual(t, "value", val)
}

// func Test_SetLogger(t *testing.T) {
// 	client.SetLogger("info", "ALibabacloud", nil, "<date>")
// 	utils.AssertEqual(t, true, client.Logger.GetIsopen())
// }

func Test_ParseMeta(t *testing.T) {
	raw := map[string]string{
		"x-oss-key": "oss",
	}
	res := client.ParseMeta(raw, "x-oss-")
	utils.AssertEqual(t, "oss", res["key"])
}

func Test_IsFail(t *testing.T) {
	httpresp := &http.Response{
		StatusCode: 300,
	}
	resp := tea.NewResponse(httpresp)
	isfail := client.IsFail(resp)
	utils.AssertEqual(t, true, isfail)
}

// func Test_GetContentLength(t *testing.T) {
// 	length := client.GetContentLength(nil, "10")
// 	utils.AssertEqual(t, "10", length)

// 	tee := &teeReader{}
// 	request := tea.NewRequest()

// 	buf := new(bytes.Buffer)
// 	request.Body = buf
// 	length = client.GetContentLength(request, "")
// 	utils.AssertEqual(t, "0", length)

// 	tee.reader = buf
// 	request.Body = tee
// 	length = client.GetContentLength(request, "")
// 	utils.AssertEqual(t, "0", length)

// 	read := new(bytes.Reader)
// 	request.Body = read
// 	length = client.GetContentLength(request, "")
// 	utils.AssertEqual(t, "0", length)

// 	tee.reader = read
// 	request.Body = tee
// 	length = client.GetContentLength(request, "")
// 	utils.AssertEqual(t, "0", length)

// 	str := strings.NewReader("")
// 	request.Body = str
// 	length = client.GetContentLength(request, "")
// 	utils.AssertEqual(t, "0", length)

// 	tee.reader = str
// 	request.Body = tee
// 	length = client.GetContentLength(request, "")
// 	utils.AssertEqual(t, "0", length)

// 	file, err := os.Create("_test.txt")
// 	utils.AssertNil(t, err)
// 	defer func() {
// 		os.Remove("_test.txt")
// 	}()
// 	request.Body = file
// 	length = client.GetContentLength(request, "")
// 	utils.AssertEqual(t, "0", length)

// 	tee.reader = file
// 	request.Body = tee
// 	length = client.GetContentLength(request, "")
// 	utils.AssertEqual(t, "0", length)

// 	limit := new(io.LimitedReader)
// 	request.Body = limit
// 	length = client.GetContentLength(request, "")
// 	utils.AssertEqual(t, "0", length)

// 	tee.reader = limit
// 	request.Body = tee
// 	length = client.GetContentLength(request, "")
// 	utils.AssertEqual(t, "0", length)
// }

// func Test_GetContentMD5(t *testing.T) {
// 	request := tea.NewRequest()
// 	md5 := client.GetContentMD5(request, "md5Value", int64(10))
// 	utils.AssertEqual(t, "", md5)

// 	client.IsEnableMD5 = true
// 	md5 = client.GetContentMD5(request, "md5Value", int64(10))
// 	utils.AssertEqual(t, "md5Value", md5)

// 	request.Headers["content-length"] = "ok"
// 	md5 = client.GetContentMD5(request, "", int64(10))
// 	utils.AssertEqual(t, "", md5)

// 	request.Headers["content-length"] = "10"
// 	request.Body = strings.NewReader("oss")
// 	md5 = client.GetContentMD5(request, "", int64(10))
// 	utils.AssertEqual(t, "NpZEESCkAveTpwR2ZUDmng==", md5)
// }

func Test_GetErrmessage(t *testing.T) {
	httpResponse := &http.Response{
		Body: ioutil.NopCloser(strings.NewReader("")),
	}
	resp := tea.NewResponse(httpResponse)
	result, err := client.GetErrMessage(resp)
	utils.AssertEqual(t, "EOF", err.Error())
	utils.AssertEqual(t, len(result), 0)

	str := `<?xml version="1.0" encoding="utf-8" standalone="no"?>
	<num>10</num>`
	httpResponse.Body = ioutil.NopCloser(strings.NewReader(str))
	resp = tea.NewResponse(httpResponse)
	result, err = client.GetErrMessage(resp)
	utils.AssertNil(t, err)
	utils.AssertEqual(t, result["Code"].(string), "")

}

func Test_GetContentType(t *testing.T) {
	typ := client.GetContentType("a.txt")
	utils.AssertEqual(t, "text/plain; charset=utf-8", typ)
}

func Test_Encode(t *testing.T) {
	res := client.Encode("/oss", "Base64")
	utils.AssertEqual(t, "/b3Nz", res)

	res = client.Encode("/oss", "UrlEncode")
	utils.AssertEqual(t, "/oss", res)
}

func Test_Base64Decode(t *testing.T) {
	dec := client.Base64Decode("a/afgg?';;")
	utils.AssertEqual(t, "", dec)

	dec = client.Base64Decode("afff")
	utils.AssertEqual(t, 3, len(dec))
}

func Test_UrlDecode(t *testing.T) {
	dec := client.UrlDecode("a/afg%")
	utils.AssertEqual(t, "", dec)

	dec = client.UrlDecode("afff")
	utils.AssertEqual(t, 4, len(dec))
}

type parseTest struct {
	Body io.ReadCloser `json:"Body"`
}

func Test_ParseXml(t *testing.T) {
	httpResp := &http.Response{
		Body: ioutil.NopCloser(strings.NewReader("")),
	}

	resp := tea.NewResponse(httpResp)
	resp.Headers["Content-Type"] = "application/json"
	result, err := client.ParseXml(resp, new(parseTest))
	utils.AssertEqual(t, 1, len(result))

	resp.Headers["Content-Type"] = "application/json"
	result, err = client.ParseXml(resp, new(validatorTest))
	utils.AssertEqual(t, "unexpected end of JSON input", err.Error())
	utils.AssertEqual(t, 0, len(result))

	str := `<?xml version="1.0" encoding="utf-8" standalone="no"?>
	<num>10</num>`
	httpResp.Body = ioutil.NopCloser(strings.NewReader(str))
	resp = tea.NewResponse(httpResp)
	resp.Headers["Content-Type"] = "application/xml"
	result, err = client.ParseXml(resp, new(validatorTest))
	utils.AssertNil(t, err)
	utils.AssertEqual(t, 1, len(result))

	str = `<?xml version="1.0" encoding="utf-8" standalone="no"?>
	<num/num>`
	httpResp.Body = ioutil.NopCloser(strings.NewReader(str))
	resp = tea.NewResponse(httpResp)
	resp.Headers["Content-Type"] = "application/xml"
	result, err = client.ParseXml(resp, new(validatorTest))
	utils.AssertNil(t, err)
	utils.AssertEqual(t, 1, len(result))
}

func Test_ReadAsStream(t *testing.T) {
	httpResp := &http.Response{
		Body: ioutil.NopCloser(strings.NewReader("oss")),
	}
	resp := tea.NewResponse(httpResp)
	body := client.ReadAsStream(resp)
	byt, err := ioutil.ReadAll(body)
	defer body.Close()
	utils.AssertNil(t, err)
	utils.AssertEqual(t, "oss", string(byt))
}

func Test_ToHeader(t *testing.T) {
	raw := map[string]interface{}{
		"num": 10,
	}
	header := client.ToHeader(raw)
	utils.AssertNil(t, header)

	raw = map[string]interface{}{
		"key": "value",
	}
	header = client.ToHeader(raw)
	utils.AssertEqual(t, "value", header["key"])
}
