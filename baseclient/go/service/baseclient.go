package service

import (
	"crypto/md5"
	"encoding/base64"
	"encoding/json"
	"encoding/xml"
	"errors"
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
	client.UserAgent = getStringValue(config["userAgent"])
	client.HostModel = getStringValue(config["hostModel"])
	client.SignatureVersion = getStringValue(config["signatureVersion"])
	client.IsEnableMD5 = getBoolValue(config["isEnableMD5"])
	client.IsEnableCrc = getBoolValue(config["isEnableCrc"])
	client.ReadTimeout = getIntValue(config["readTimeout"])
	client.ConnectTimeout = getIntValue(config["connectTimeout"])
	client.LocalAddr = getStringValue(config["localAddr"])
	client.HttpProxy = getStringValue(config["httpProxy"])
	client.HttpsProxy = getStringValue(config["httpsProxy"])
	client.NoProxy = getStringValue(config["noProxy"])
	client.Socks5Proxy = getStringValue(config["socks5Proxy"])
	client.Socks5NetWork = getStringValue(config["socks5NetWork"])
	client.MaxIdleConns = getIntValue(config["maxIdleConns"])
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

// func (client *BaseClient) SetLogger(level string, channel string, out io.Writer, template string) {
// 	client.Logger = teautil.NewLogger(level, channel, out, template)
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

func (client *BaseClient) Empty(val string) bool {
	return val == ""
}

func (client *BaseClient) Equal(val, val2 string) bool {
	return val == val2
}

func (client *BaseClient) IfListEmpty(val []string) bool {
	return len(val) == 0
}

func (client *BaseClient) ReadAsString(resp *tea.Response) (string, error) {
	byt, err := resp.ReadBody()
	if err != nil {
		return "", err
	}
	return string(byt), err
}

func (client *BaseClient) GetSignatureV1(request *tea.Request, bucketName, accessKeySecret string) string {
	resource := ""
	if bucketName != "" {
		resource = "/" + bucketName
	}
	resource = resource + request.Pathname
	if !strings.Contains(resource, "?") {
		resource += "?"
	}
	for key, value := range request.Query {
		if isParamSign(key) {
			if value != "" {
				if strings.HasSuffix(resource, "?") {
					resource = resource + key + "=" + value
				} else {
					resource = resource + "&" + key + "=" + value
				}
			}
		}
	}
	return getSignedStrV1(request, resource, accessKeySecret)
}

func (client *BaseClient) GetSignatureV2(request *tea.Request, bucketName, accessKeySecret string, additionalHeaders []string) string {
	resource := ""
	pathName := request.Pathname
	if bucketName != "" {
		pathName = "/" + bucketName + request.Pathname
	}

	strs := strings.Split(pathName, "?")
	resource += uriEncode(strs[0], true)
	hs := newSorter(request.Query)
	if strings.Contains(pathName, "?") {
		hs.Keys = append(hs.Keys, strs[1])
		hs.Vals = append(hs.Vals, "")
	}

	// Sort the temp by the ascending order
	hs.Sort()
	if len(hs.Keys) > 0 {
		resource += "?"
	}
	for i := range hs.Keys {
		if !strings.HasSuffix(resource, "?") {
			resource += "&"
		}
		if hs.Vals[i] == "" {
			resource += uriEncode(hs.Keys[i], true)
		} else {
			resource += uriEncode(hs.Keys[i], true) + "=" + uriEncode(hs.Vals[i], true)
		}
	}
	return getSignedStrV2(request, resource, accessKeySecret, additionalHeaders)
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

// Get value from obj according to key
func (client *BaseClient) GetSpecialValue(obj map[string]interface{}, key string) string {
	tmp := make(map[string]string)
	byt, _ := json.Marshal(obj)
	err := json.Unmarshal(byt, &tmp)
	if err != nil {
		return ""
	}

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

func (client *BaseClient) GetErrMessage(bodyStr string) map[string]interface{} {
	resp := make(map[string]interface{})
	errMsg := &ServiceError{}
	err := xml.Unmarshal([]byte(bodyStr), errMsg)
	if err != nil {
		return resp
	}
	resp["Code"] = errMsg.Code
	resp["Message"] = errMsg.Message
	resp["RequestId"] = errMsg.RequestId
	resp["HostId"] = errMsg.HostId
	return resp
}

// Parse Body to map[string]interface{}
func (client *BaseClient) ParseXml(val string, result interface{}) map[string]interface{} {
	resp := make(map[string]interface{})

	start := getStartElement([]byte(val))
	out, err := XmlUnmarshal([]byte(val), result)
	if err != nil {
		return resp
	}
	resp[start] = out
	return resp
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

// Return md5 according to body
func (client *BaseClient) GetContentMD5(a string) string {
	if !client.IsEnableMD5 {
		return ""
	}

	sum := md5.Sum([]byte(a))
	b64 := base64.StdEncoding.EncodeToString(sum[:])
	return b64
}

func (client *BaseClient) ToXML(obj map[string]interface{}) string {
	return mapToXML(obj)
}

func (client *BaseClient) NotNull(obj map[string]interface{}) bool {
	return len(obj) > 0
}

// Return content-type according to object name
func (client *BaseClient) GetContentType(name string) string {
	return utils.TypeByExtension(name)
}

func (client *BaseClient) GetAccessKeyID() (string, error) {
	if client.credential == nil {
		return "", errors.New("No credential valid!")
	}
	accessKeyId, err := client.credential.GetAccessKeyId()
	return accessKeyId, err
}

func (client *BaseClient) GetAccessKeySecret() (string, error) {
	if client.credential == nil {
		return "", errors.New("No credential valid!")
	}
	accessKeySecret, err := client.credential.GetAccessKeySecret()
	return accessKeySecret, err
}

func (client *BaseClient) ListToString(a []string, sep string) string {
	return strings.Join(a, sep)
}

func (client *BaseClient) GetSecurityToken() (string, error) {
	if client.credential == nil {
		return "", errors.New("No credential valid!")
	}
	token, err := client.credential.GetSecurityToken()
	return token, err
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

func (client *BaseClient) Inject(body io.Reader, ref map[string]string) io.Reader {
	body = ComplexReader(body, ref)
	return body
}
