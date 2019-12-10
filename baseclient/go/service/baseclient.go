package service

import (
	"encoding/base64"
	"encoding/json"
	"encoding/xml"
	"fmt"
	"hash/crc64"
	"io"
	"net/http"
	"net/url"
	"reflect"
	"runtime"
	"strconv"
	"strings"
	"time"

	"github.com/alibabacloud-go/tea/tea"
	teautil "github.com/alibabacloud-go/tea/utils"
	"github.com/aliyun/alibabacloud-oss-sdk/baseclient/go/utils"
	"github.com/aliyun/credentials-go/credentials"
)

var crcTable = func() *crc64.Table {
	return crc64.MakeTable(crc64.ECMA)
}

var defaultUserAgent = fmt.Sprintf("AlibabaCloud (%s; %s) Golang/%s Core/%s", runtime.GOOS, runtime.GOARCH, strings.Trim(runtime.Version(), "go"), "0.01")

// Client is for calling oss api
type BaseClient struct {
	RegionId         string   `json:"RegionId" xml:"RegionId"`
	Protocol         string   `json:"Protocol" xml:"Protocol"`
	Endpoint         string   `json:"Endpoint" xml:"Endpoint"`
	UserAgent        string   `json:"UserAgent" xml:"UserAgent"`
	HostModel        string   `json:"HostModel" xml:"HostModel"`
	SignatureVersion string   `json:"SignatureVersion" xml:"SignatureVersion"`
	IsEnableMD5      bool     `json:"IsEnableMD5" xml:"IsEnableMD5"`
	IsEnableCrc      bool     `json:"IsEnableCrc" xml:"IsEnableCrc"`
	ReadTimeout      int      `json:"ReadTimeout" xml:"ReadTimeout"`
	ConnectTimeout   int      `json:"ConnectTimeout" xml:"ConnectTimeout"`
	LocalAddr        string   `json:"LocalAddr" xml:"LocalAddr"`
	HttpProxy        string   `json:"HttpProxy" xml:"HttpProxy"`
	HttpsProxy       string   `json:"HttpsProxy" xml:"HttpsProxy"`
	NoProxy          string   `json:"NoProxy" xml:"NoProxy"`
	Socks5Proxy      string   `json:"SOCKS5Proxy" xml:"SOCKS5Proxy"`
	Socks5NetWork    string   `json:"SOCKS5NetWork" xml:"SOCKS5NetWork"`
	MaxIdleConns     int      `json:"MaxIdleConns" xml:"MaxIdleConns"`
	AddtionalHeaders []string `json:"AddtionalHeaders" xml:"AddtionalHeaders"`
	credential       credentials.Credential
	Logger           *teautil.Logger
}

// ServiceError is for recording error which is caused when sending request
type ServiceError struct {
	Code      string `json:"Code" xml:"Code"`
	Message   string `json:"Message" xml:"Message"`
	RequestId string `json:"RequestId" xml:"RequestId"`
	HostId    string `json:"HostId" xml:"HostId"`
}

// New a client according to config
func (client *BaseClient) InitClient(config map[string]interface{}) error {
	client.Protocol = getStringValue(config["protocol"])
	client.RegionId = getStringValue(config["regionId"])
	client.Endpoint = getStringValue(config["endpoint"])
	conf := &credentials.Configuration{
		AccessKeyID:     getStringValue(config["accessKeyId"]),
		AccessKeySecret: getStringValue(config["accessKeySecret"]),
		SecurityToken:   getStringValue(config["securityToken"]),
		Type:            getStringValue(config["type"]),
	}
	if conf.Type == "" {
		conf.Type = "access_key"
	}
	credential, err := credentials.NewCredential(conf)
	client.credential = credential
	if err != nil {
		return err
	}

	return nil
}

// Get Signature according to reqeust and bucketName
func (client *BaseClient) GetAuth(request *tea.Request, bucketName string) string {
	auth := ""
	if client.credential == nil {
		return ""
	}
	accessKeyId, err := client.credential.GetAccessKeyID()
	if err != nil {
		return ""
	}

	accessKeySecret, err := client.credential.GetAccessSecret()
	if err != nil {
		return ""
	}

	securityToken, err := client.credential.GetSecurityToken()
	if err != nil {
		return ""
	}

	if securityToken != "" {
		request.Headers["X-Oss-Security-Token"] = securityToken
	}
	if strings.ToLower(client.SignatureVersion) == "v2" {
		signature := getSignatureV2(request, bucketName, accessKeySecret, client.AddtionalHeaders)
		if len(client.AddtionalHeaders) == 0 {
			auth = "OSS2 AccessKeyId:" + accessKeyId + ",Signature:" + signature
		} else {
			auth = "OSS2 AccessKeyId:" + accessKeyId + ",AdditionalHeaders:" + strings.Join(client.AddtionalHeaders, ";") + ",Signature:" + signature
		}
	} else {
		signature := getSignatureV1(request, bucketName, accessKeySecret)
		auth = "OSS " + accessKeyId + ":" + signature
	}
	return auth
}

// Get OSS host
func (client *BaseClient) GetHost(bucketName string) string {
	host := ""
	if client.RegionId == "" {
		client.RegionId = "cn-hangzhou"
	}
	if client.Endpoint == "" {
		client.Endpoint = "oss-" + client.RegionId + ".aliyuncs.com"
	}
	if bucketName != "" {
		if strings.ToLower(client.HostModel) == "ip" {
			host = client.Endpoint + "/" + bucketName
		} else if strings.ToLower(client.HostModel) == "cname" {
			host = client.Endpoint
		} else {
			host = bucketName + "." + client.Endpoint
		}
	} else {
		host = client.Endpoint
	}
	return host
}

// Get Crc from request
// func (client *BaseClient) GetCrc(request *tea.Request, contentlength string, listener interface{}, tracker *teautil.ReaderTracker) hash.Hash64 {
// 	if !client.IsEnableCrc {
// 		return nil
// 	}
// 	val, err := strconv.Atoi(contentlength)
// 	if err != nil {
// 		return nil
// 	}
// 	crc := NewCRC(crcTable(), 0)
// 	reader := TeeReader(request.Body, crc, int64(val), teautil.GetProgressListener(listener), tracker)
// 	request.Body = reader

// 	return crc
// }

// func (client *BaseClient) GetTracker() *teautil.ReaderTracker {
// 	return &teautil.ReaderTracker{CompletedBytes: 0}
// }

// func (client *BaseClient) SetLogger(level string, channel string, out io.Writer, template string) {
// 	client.Logger = teautil.NewLogger(level, channel, out, template)
// }

// Get Crc from response
// func (client *BaseClient) GetRespCrc(response *tea.Response, hasRange bool, listener interface{}, tracker *teautil.ReaderTracker) hash.Hash64 {
// 	if !client.IsEnableCrc || hasRange {
// 		return nil
// 	}
// 	crc := NewCRC(crcTable(), 0)

// 	reader := TeeReader(response.Body, crc, response.ContentLength, teautil.GetProgressListener(listener), tracker)
// 	response.Body = reader
// 	return crc
// }

// Verify that the two CRC values are the same
// func (client *BaseClient) IsNotCrcMatched(calCrc hash.Hash64, respCrc string) bool {
// 	if client.IsEnableCrc {
// 		crc, err := strconv.ParseUint(respCrc, 10, 64)
// 		if crc != calCrc.Sum64() || err != nil {
// 			return true
// 		}
// 	}
// 	return false
// }

func (client *BaseClient) ReadAsStream(response *tea.Response) io.ReadCloser {
	return response.Body
}

func (client *BaseClient) GetUserAgent() string {
	if client.UserAgent == "" {
		return defaultUserAgent
	}
	return defaultUserAgent + " " + client.UserAgent
}

// Parse string to uint
func (client *BaseClient) ParseUint(respCrc string, hasRange bool) uint64 {
	if hasRange {
		return 0
	}
	crc, err := strconv.ParseUint(respCrc, 10, 64)
	if err != nil {
		return 0
	}
	return crc
}

// func (client *BaseClient) IsUploadSpeedLimit(body io.Reader, limitSpeed int) io.Reader {
// 	if limitSpeed == 0 {
// 		return body
// 	}
// 	uploadLimiter := GetOssLimiter(limitSpeed)
// 	return &LimitSpeedReader{
// 		reader:     body,
// 		ossLimiter: uploadLimiter,
// 	}
// }

// If num is not 0, return num, or return defaultNum
func (client *BaseClient) DefaultNumber(num int, defaultNum int) int {
	if num != 0 {
		return num
	}
	return defaultNum
}

func (client *BaseClient) ToHeader(raw map[string]interface{}) map[string]string {
	byt, _ := json.Marshal(raw)
	header := make(map[string]string)
	err := json.Unmarshal(byt, &header)
	if err != nil {
		return nil
	}
	return header
}

// Parse filter to produce a map[string]string
func (client *BaseClient) ToQuery(filter map[string]interface{}) map[string]string {
	result := make(map[string]string)
	for key, value := range filter {
		filterValue := reflect.ValueOf(value)
		flatRepeatedList(filterValue, result, key)
	}
	return result
}

// Get Date in GMT
func (client *BaseClient) GetDate() string {
	return time.Now().UTC().Format(http.TimeFormat)
}

// func (client *BaseClient) IfRange(header interface{}) bool {
// 	result := make(map[string]string)
// 	byt, _ := json.Marshal(header)
// 	err := json.Unmarshal(byt, &result)
// 	if err != nil {
// 		return false
// 	}
// 	if v := result["Range"]; v == "" {
// 		return false
// 	}
// 	return true
// }

// Add prefix to key of meta
func (client *BaseClient) ToMeta(meta map[string]string, prefix string) map[string]string {
	result := make(map[string]string)
	for key, value := range meta {
		if !strings.HasPrefix(strings.ToLower((key)), prefix) {
			key = prefix + key
		}
		result[key] = value
	}
	return result
}

// Translate interface{} to io.Reader
func (client *BaseClient) ToBody(body interface{}) io.Reader {
	byt, err := xml.Marshal(body)
	if err != nil {
		return nil
	}
	return strings.NewReader(string(byt))
}

// Get value from obj according to key
func (client *BaseClient) GetSpecialValue(obj map[string]interface{}, key string) string {
	tmp := make(map[string]string)
	byt, _ := json.Marshal(obj)
	json.Unmarshal(byt, &tmp)

	return tmp[key]
}

// Remove prefix from key of meta
func (client *BaseClient) ParseMeta(meta map[string]string, prefix string) map[string]string {
	userMeta := make(map[string]string)
	for key, value := range meta {
		if strings.HasPrefix(strings.ToLower(key), prefix) {
			key = strings.Replace(key, prefix, "", 1)
		}
		userMeta[key] = value
	}
	return userMeta
}

func (client *BaseClient) GetErrMessage(response *tea.Response) (map[string]interface{}, error) {
	resp := make(map[string]interface{})
	body, err := response.ReadBody()
	if err != nil {
		return resp, err
	}
	errMsg := &ServiceError{}
	err = xml.Unmarshal(body, errMsg)
	if err != nil {
		return resp, err
	}
	resp["Code"] = errMsg.Code
	resp["Message"] = errMsg.Message
	resp["RequestId"] = errMsg.RequestId
	resp["HostId"] = errMsg.HostId
	return resp, nil
}

// Parse Body to map[string]interface{}
func (client *BaseClient) ParseXml(response *tea.Response, result interface{}) (map[string]interface{}, error) {
	resp := make(map[string]interface{})
	contentType := "application/xml"
	if response.Headers["Content-Type"] != "" {
		contentType = response.Headers["Content-Type"]
	}
	_, isBodyExist := reflect.TypeOf(result).Elem().FieldByName("Body")
	if isBodyExist {
		resp["Body"] = response.Body
	} else {
		body, err := response.ReadBody()
		if err != nil {
			return resp, err
		}
		if contentType == "application/xml" {
			start := getStartElement(body)
			out, err := XmlUnmarshal(body, result)
			if err != nil {
				return resp, err
			}
			resp[start] = out
		} else {
			err := json.Unmarshal(body, &resp)
			if err != nil {
				return resp, err
			}
		}
	}
	return resp, nil
}

// Determine whether the request failed
func (client *BaseClient) IsFail(response *tea.Response) bool {
	return response.StatusCode < 200 || response.StatusCode >= 300
}

// If realStr is not "", return realStr, or return defaultStr
func (client *BaseClient) Default(realStr string, defaultStr string) string {
	if realStr != "" {
		return realStr
	}
	return defaultStr
}

// Return body length
// func (client *BaseClient) GetContentLength(request *tea.Request, length string) string {
// 	if length != "" {
// 		return length
// 	}
// 	var contentlength int64
// 	switch v := request.Body.(type) {
// 	case *teeReader:
// 		switch a := v.reader.(type) {
// 		case *bytes.Buffer:
// 			contentlength = int64(a.Len())
// 		case *bytes.Reader:
// 			contentlength = int64(a.Len())
// 		case *strings.Reader:
// 			contentlength = int64(a.Len())
// 		case *os.File:
// 			contentlength = tryGetFileSize(a)
// 		case *io.LimitedReader:
// 			contentlength = int64(a.N)
// 		}
// 	case *bytes.Buffer:
// 		contentlength = int64(v.Len())
// 	case *bytes.Reader:
// 		contentlength = int64(v.Len())
// 	case *strings.Reader:
// 		contentlength = int64(v.Len())
// 	case *os.File:
// 		contentlength = tryGetFileSize(v)
// 	case *io.LimitedReader:
// 		contentlength = int64(v.N)
// 	}
// 	return strconv.FormatInt(contentlength, 10)
// }

// func tryGetFileSize(f *os.File) int64 {
// 	fInfo, _ := f.Stat()
// 	return fInfo.Size()
// }

// Return md5 according to body
// func (client *BaseClient) GetContentMD5(request *tea.Request, md5Value string, md5Threshold int64) string {
// 	if !client.IsEnableMD5 {
// 		return ""
// 	}
// 	if md5Value != "" {
// 		return md5Value
// 	}
// 	contntlength := request.Headers["content-length"]
// 	realLength, err := strconv.Atoi(contntlength)
// 	if err != nil {
// 		return ""
// 	}
// 	reader, md5 := utils.CalcMD5(request.Body, int64(realLength), md5Threshold)
// 	request.Body = reader
// 	return md5
// }

// Return content-type according to object name
func (client *BaseClient) GetContentType(name string) string {
	return utils.TypeByExtension(name)
}

// Encryption
func (client *BaseClient) Encode(val string, encodeType string) string {
	strs := strings.Split(val, "/")
	if encodeType == "Base64" {
		encodeStr := base64.StdEncoding.EncodeToString([]byte(strs[len(strs)-1]))
		strs[len(strs)-1] = encodeStr
	} else if encodeType == "UrlEncode" {
		encodeStr, err := url.QueryUnescape(strs[len(strs)-1])
		if err != nil {
			return ""
		}
		strs[len(strs)-1] = encodeStr
	}
	return strings.Join(strs, "/")
}

// Decryption
func (client *BaseClient) Base64Decode(value string) string {
	strs := strings.Split(value, "/")
	result, err := base64.StdEncoding.DecodeString(strs[len(strs)-1])
	if err != nil {
		return ""
	}
	strs[len(strs)-1] = string(result)
	return strings.Join(strs, "/")
}

// Decryption
func (client *BaseClient) UrlDecode(value string) string {
	strs := strings.Split(value, "/")
	result, err := url.QueryUnescape(strs[len(strs)-1])
	if err != nil {
		return ""
	}
	strs[len(strs)-1] = result
	return strings.Join(strs, "/")
}
