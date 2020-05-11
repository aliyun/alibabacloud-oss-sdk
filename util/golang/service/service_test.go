package service

import (
	"io"
	"io/ioutil"
	"strings"
	"testing"

	"github.com/alibabacloud-go/tea/tea"
	"github.com/alibabacloud-go/tea/utils"
)

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
	meta := map[string]*string{
		"a": tea.String("ok"),
	}
	result := ToMeta(meta, tea.String("x-oss-"))
	utils.AssertEqual(t, "ok", tea.StringValue(result["x-oss-a"]))
}

// func Test_SetLogger(t *testing.T) {
// 	client.SetLogger("info", "ALibabacloud", nil, "<date>")
// 	utils.AssertEqual(t, true, client.Logger.GetIsopen())
// }

func Test_ParseMeta(t *testing.T) {
	raw := map[string]*string{
		"x-oss-key": tea.String("oss"),
	}
	res := ParseMeta(raw, tea.String("x-oss-"))
	utils.AssertEqual(t, "oss", tea.StringValue(res["key"]))
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
	result := GetErrMessage(tea.String(""))
	utils.AssertEqual(t, len(result), 0)

	str := `<?xml version="1.0" encoding="utf-8" standalone="no"?>
	<num>10</num>`
	result = GetErrMessage(tea.String(str))
	utils.AssertEqual(t, result["Code"].(string), "")

}

func Test_GetContentType(t *testing.T) {
	typ := GetContentType(tea.String("a.txt"))
	utils.AssertEqual(t, "text/plain; charset=utf-8", tea.StringValue(typ))
}

func Test_Encode(t *testing.T) {
	res := Encode(tea.String("/oss"), tea.String("Base64"))
	utils.AssertEqual(t, "/b3Nz", tea.StringValue(res))

	res = Encode(tea.String("/oss"), tea.String("UrlEncode"))
	utils.AssertEqual(t, "/oss", tea.StringValue(res))
}

func Test_Decode(t *testing.T) {
	dec := Decode(tea.String("a/afgg?';;"), tea.String("Base64Decode"))
	utils.AssertEqual(t, "", tea.StringValue(dec))
	dec = Decode(tea.String("afff"), tea.String("Base64Decode"))
	utils.AssertEqual(t, 3, len(tea.StringValue(dec)))

	dec = Decode(tea.String("a/afg%"), tea.String("UrlDecode"))
	utils.AssertEqual(t, "", tea.StringValue(dec))
	dec = Decode(tea.String("afff"), tea.String("UrlDecode"))
	utils.AssertEqual(t, 4, len(tea.StringValue(dec)))

	dec = Decode(tea.String("afff"), tea.String(""))
	utils.AssertEqual(t, "afff", tea.StringValue(dec))
}

func Test_GetRefer(t *testing.T) {
	body := strings.NewReader("oss")
	ref := make(map[string]*string)
	reader := Inject(body, ref)
	_, err := ioutil.ReadAll(reader)
	utils.AssertNil(t, err)
	utils.AssertEqual(t, "NpZEESCkAveTpwR2ZUDmng==", tea.StringValue(ref["md5"]))
	utils.AssertEqual(t, "14794686500134955722", tea.StringValue(ref["crc"]))

	err = reader.(io.ReadCloser).Close()
	utils.AssertNil(t, err)

	tmp := ioutil.NopCloser(body)
	reader = Inject(tmp, ref)
	err = reader.(io.ReadCloser).Close()
	utils.AssertNil(t, err)
}

func Test_GetContentMD5(t *testing.T) {
	md5 := GetContentMD5(tea.String("oss"), tea.Bool(true))
	utils.AssertEqual(t, "NpZEESCkAveTpwR2ZUDmng==", tea.StringValue(md5))

	md5 = GetContentMD5(tea.String("oss"), tea.Bool(false))
	utils.AssertEqual(t, "", tea.StringValue(md5))
}

func Test_GetSignature(t *testing.T) {
	request := tea.NewRequest()
	request.Query = map[string]*string{
		"oss":      tea.String("ok"),
		"location": tea.String("oss"),
	}
	request.Headers = map[string]*string{
		"x-oss-meta": tea.String("user"),
	}

	sign := GetSignature(request, tea.String("script"), tea.String("accessKeyId"), tea.String("accessKeySecret"), tea.String("V1"), []*string{tea.String("x-oss-meta")})
	utils.AssertEqual(t, "OSS accessKeyId:S7JeWK7VQxpJ+LyWrfYz0o69Nm4=", tea.StringValue(sign))

	sign = GetSignature(request, tea.String("script"), tea.String("accessKeyId"), tea.String("accessKeySecret"), tea.String("V2"), nil)
	utils.AssertEqual(t, "OSS2 AccessKeyId:accessKeyId,Signature:5fFDYYbdsAFGXOH0p53pT5dg1ox0Z/qwmb08Zr37cT0=", tea.StringValue(sign))

	request.Pathname = tea.String("test?sdk")

	sign = GetSignature(request, tea.String("script"), tea.String("accessKeyId"), tea.String("accessKeySecret"), tea.String("V1"), []*string{tea.String("x-oss-meta")})
	utils.AssertEqual(t, "OSS accessKeyId:ZL1VdoByVOT5pajpF+bV29JEOGM=", tea.StringValue(sign))

	sign = GetSignature(request, tea.String("script"), tea.String("accessKeyId"), tea.String("accessKeySecret"), tea.String("V2"), []*string{tea.String("x-oss-meta")})
	utils.AssertEqual(t, "OSS2 AccessKeyId:accessKeyId,AdditionalHeaders:x-oss-meta,Signature:3bTli+EG0i9H93UbtZRdvHd0TB4I2/T9u+JzCT/EOJ4=", tea.StringValue(sign))
}
