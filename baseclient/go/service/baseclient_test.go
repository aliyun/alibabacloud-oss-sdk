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
	err := json.Unmarshal(byt, &config)
	utils.AssertNil(t, err)
	err = client.InitClient(config)
	utils.AssertEqual(t, "AccessKeySecret cannot be empty", err.Error())

	configTest = &ConfigTest{
		AccessKeyId:     &accessKeyId,
		AccessKeySecret: &accessKeySecret,
		SecurityToken:   &securityToken,
		Type:            &credentialType,
	}

	byt, _ = json.Marshal(configTest)
	err = json.Unmarshal(byt, &config)
	utils.AssertNil(t, err)
	err = client.InitClient(config)
	utils.AssertNil(t, err)
}

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

func Test_GetErrmessage(t *testing.T) {
	result := client.GetErrMessage("")
	utils.AssertEqual(t, len(result), 0)

	str := `<?xml version="1.0" encoding="utf-8" standalone="no"?>
	<num>10</num>`
	result = client.GetErrMessage(str)
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

func Test_ParseXml(t *testing.T) {
	str := `<?xml version="1.0" encoding="utf-8" standalone="no"?>
	<num>10</num>`
	result := client.ParseXml(str, new(validatorTest))
	utils.AssertEqual(t, 1, len(result))

	str = `<?xml version="1.0" encoding="utf-8" standalone="no"?>
	<num/num>`
	result = client.ParseXml(str, new(validatorTest))
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

func Test_GetRefer(t *testing.T) {
	body := strings.NewReader("oss")
	ref := make(map[string]string)
	reader := client.Inject(body, ref)
	_, err := ioutil.ReadAll(reader)
	utils.AssertNil(t, err)
	utils.AssertEqual(t, "NpZEESCkAveTpwR2ZUDmng==", ref["md5"])
	utils.AssertEqual(t, "14794686500134955722", ref["crc"])

	err = reader.(io.ReadCloser).Close()
	utils.AssertNil(t, err)

	tmp := ioutil.NopCloser(body)
	reader = client.Inject(tmp, ref)
	err = reader.(io.ReadCloser).Close()
	utils.AssertNil(t, err)
}

func Test_Empty(t *testing.T) {
	ok := client.Empty("")
	utils.AssertEqual(t, true, ok)

	ok = client.Empty("oss")
	utils.AssertEqual(t, false, ok)
}

func Test_Equal(t *testing.T) {
	ok := client.Equal("v1", "v1")
	utils.AssertEqual(t, true, ok)

	ok = client.Equal("v1", "v2")
	utils.AssertEqual(t, false, ok)
}

func Test_IfListEmpty(t *testing.T) {
	strs := []string{}
	ok := client.IfListEmpty(strs)
	utils.AssertEqual(t, true, ok)

	strs = []string{"oss"}
	ok = client.IfListEmpty(strs)
	utils.AssertEqual(t, false, ok)
}

func Test_ReadAsString(t *testing.T) {
	httpResp := &http.Response{
		Body: ioutil.NopCloser(strings.NewReader("oss")),
	}
	resp := tea.NewResponse(httpResp)
	str, err := client.ReadAsString(resp)
	utils.AssertNil(t, err)
	utils.AssertEqual(t, "oss", str)
}

func Test_GetSignatureV1(t *testing.T) {
	request := tea.NewRequest()
	request.Query = map[string]string{
		"oss":      "ok",
		"location": "oss",
	}
	request.Headers = map[string]string{
		"x-oss-meta": "user",
	}
	str := client.GetSignatureV1(request, "script", "")
	utils.AssertEqual(t, 28, len(str))
}

func Test_GetSignatureV2(t *testing.T) {
	request := tea.NewRequest()
	request.Query = map[string]string{
		"oss":      "ok",
		"location": "oss",
	}
	request.Headers = map[string]string{
		"x-oss-meta": "user",
		"oss":        "ok",
	}
	str := client.GetSignatureV2(request, "script", "", []string{})
	utils.AssertEqual(t, 44, len(str))

	request.Pathname = "?"
	str = client.GetSignatureV2(request, "script", "", []string{"oss"})
	utils.AssertEqual(t, 44, len(str))
}

func Test_GetContentMD5(t *testing.T) {
	client.IsEnableMD5 = true
	md5 := client.GetContentMD5("oss")
	utils.AssertEqual(t, "NpZEESCkAveTpwR2ZUDmng==", md5)

	client.IsEnableMD5 = false
	md5 = client.GetContentMD5("oss")
	utils.AssertEqual(t, "", md5)
}

func Test_NotNull(t *testing.T) {
	val := map[string]interface{}{
		"oss": "sdk",
	}
	ok := client.NotNull(val)
	utils.AssertEqual(t, true, ok)
}

func Test_ToXML(t *testing.T) {
	val := map[string]interface{}{
		"oss": map[string]interface{}{
			"key": "value",
		},
	}
	str := client.ToXML(val)
	utils.AssertEqual(t, "<oss><key>value</key></oss>", str)
}

func Test_GetAccessKeyID(t *testing.T) {
	originCre := client.credential
	defer func() {
		client.credential = originCre
	}()
	token, err := client.GetAccessKeyID()
	utils.AssertNil(t, err)
	utils.AssertEqual(t, "accessKeyId", token)

	client.credential = nil
	token, err = client.GetAccessKeyID()
	utils.AssertEqual(t, "No credential valid!", err.Error())
	utils.AssertEqual(t, "", token)
}

func Test_GetAccessKeySecret(t *testing.T) {
	originCre := client.credential
	defer func() {
		client.credential = originCre
	}()
	token, err := client.GetAccessKeySecret()
	utils.AssertNil(t, err)
	utils.AssertEqual(t, "accessKeySecret", token)

	client.credential = nil
	token, err = client.GetAccessKeySecret()
	utils.AssertEqual(t, "No credential valid!", err.Error())
	utils.AssertEqual(t, "", token)
}

func Test_GetSecurityToken(t *testing.T) {
	originCre := client.credential
	defer func() {
		client.credential = originCre
	}()
	token, err := client.GetSecurityToken()
	utils.AssertNil(t, err)
	utils.AssertEqual(t, "securityToken", token)

	client.credential = nil
	token, err = client.GetSecurityToken()
	utils.AssertEqual(t, "No credential valid!", err.Error())
	utils.AssertEqual(t, "", token)
}

func Test_ListToString(t *testing.T) {
	val := []string{"oss", "sdk"}
	str := client.ListToString(val, ";")
	utils.AssertEqual(t, "oss;sdk", str)
}
