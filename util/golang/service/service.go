package service

import (
	"crypto/md5"
	"encoding/base64"
	"encoding/xml"
	"hash/crc64"
	"io"
	"net/url"
	"strings"

	"github.com/alibabacloud-go/tea/tea"
	"github.com/aliyun/rpc-client-go/service"
)

var crcTable = func() *crc64.Table {
	return crc64.MakeTable(crc64.ECMA)
}

type RuntimeOptions struct {
	Autoretry        *bool       `json:"autoretry" xml:"autoretry"`
	IgnoreSSL        *bool       `json:"ignoreSSL" xml:"ignoreSSL"`
	MaxAttempts      *int        `json:"maxAttempts" xml:"maxAttempts"`
	BackoffPolicy    *string     `json:"backoffPolicy" xml:"backoffPolicy"`
	BackoffPeriod    *int        `json:"backoffPeriod" xml:"backoffPeriod"`
	ReadTimeout      *int        `json:"readTimeout" xml:"readTimeout"`
	ConnectTimeout   *int        `json:"connectTimeout" xml:"connectTimeout"`
	LocalAddr        *string     `json:"localAddr" xml:"localAddr"`
	HttpProxy        *string     `json:"httpProxy" xml:"httpProxy"`
	HttpsProxy       *string     `json:"httpsProxy" xml:"httpsProxy"`
	NoProxy          *string     `json:"noProxy" xml:"noProxy"`
	MaxIdleConns     *int        `json:"maxIdleConns" xml:"maxIdleConns"`
	Socks5Proxy      *string     `json:"socks5Proxy" xml:"socks5Proxy"`
	Socks5NetWork    *string     `json:"socks5NetWork" xml:"socks5NetWork"`
	UploadLimitSpeed *int        `json:"uploadLimitSpeed" xml:"uploadLimitSpeed"`
	Listener         interface{} `json:"listener" xml:"listener"`
}

func (s RuntimeOptions) String() string {
	return service.Prettify(s)
}

func (s RuntimeOptions) GoString() string {
	return s.String()
}

func (s *RuntimeOptions) SetAutoretry(v bool) *RuntimeOptions {
	s.Autoretry = &v
	return s
}

func (s *RuntimeOptions) SetIgnoreSSL(v bool) *RuntimeOptions {
	s.IgnoreSSL = &v
	return s
}

func (s *RuntimeOptions) SetMaxAttempts(v int) *RuntimeOptions {
	s.MaxAttempts = &v
	return s
}

func (s *RuntimeOptions) SetBackoffPolicy(v string) *RuntimeOptions {
	s.BackoffPolicy = &v
	return s
}

func (s *RuntimeOptions) SetBackoffPeriod(v int) *RuntimeOptions {
	s.BackoffPeriod = &v
	return s
}

func (s *RuntimeOptions) SetReadTimeout(v int) *RuntimeOptions {
	s.ReadTimeout = &v
	return s
}

func (s *RuntimeOptions) SetConnectTimeout(v int) *RuntimeOptions {
	s.ConnectTimeout = &v
	return s
}

func (s *RuntimeOptions) SetLocalAddr(v string) *RuntimeOptions {
	s.LocalAddr = &v
	return s
}

func (s *RuntimeOptions) SetHttpProxy(v string) *RuntimeOptions {
	s.HttpProxy = &v
	return s
}

func (s *RuntimeOptions) SetHttpsProxy(v string) *RuntimeOptions {
	s.HttpsProxy = &v
	return s
}

func (s *RuntimeOptions) SetNoProxy(v string) *RuntimeOptions {
	s.NoProxy = &v
	return s
}

func (s *RuntimeOptions) SetMaxIdleConns(v int) *RuntimeOptions {
	s.MaxIdleConns = &v
	return s
}

func (s *RuntimeOptions) SetSocks5Proxy(v string) *RuntimeOptions {
	s.Socks5Proxy = &v
	return s
}

func (s *RuntimeOptions) SetSocks5NetWork(v string) *RuntimeOptions {
	s.Socks5NetWork = &v
	return s
}

func (s *RuntimeOptions) SetUploadLimitSpeed(v int) *RuntimeOptions {
	s.UploadLimitSpeed = &v
	return s
}

func (s *RuntimeOptions) SetListener(v interface{}) *RuntimeOptions {
	s.Listener = v
	return s
}

// ServiceError is for recording error which is caused when sending request
type ServiceError struct {
	Code      string `json:"Code" xml:"Code"`
	Message   string `json:"Message" xml:"Message"`
	RequestId string `json:"RequestId" xml:"RequestId"`
	HostId    string `json:"HostId" xml:"HostId"`
}

func GetSignature(request *tea.Request, bucketName, accessKeyId, accessKeySecret, signatureVersion string, addtionalHeaders []string) string {
	sign := ""
	if strings.ToUpper(signatureVersion) == "V2" {
		if len(addtionalHeaders) == 0 {
			sign = "OSS2 AccessKeyId:" + accessKeyId + ",Signature:" +
				getSignatureV2(request, bucketName, accessKeySecret, addtionalHeaders)
			return sign
		} else {
			sign = "OSS2 AccessKeyId:" + accessKeyId + ",AdditionalHeaders:" + listToString(addtionalHeaders, ";") +
				",Signature:" + getSignatureV2(request, bucketName, accessKeySecret, addtionalHeaders)
			return sign
		}

	} else {
		sign = "OSS " + accessKeyId + ":" + getSignatureV1(request, bucketName, accessKeySecret)
		return sign
	}
}

// func IsUploadSpeedLimit(body io.Reader, limitSpeed int) io.Reader {
// 	if limitSpeed == 0 {
// 		return body
// 	}
// 	uploadLimiter := GetOssLimiter(limitSpeed)
// 	return &LimitSpeedReader{
// 		reader:     body,
// 		ossLimiter: uploadLimiter,
// 	}
// }

// Add prefix to key of meta
func ToMeta(meta map[string]string, prefix string) map[string]string {
	result := make(map[string]string)
	for key, value := range meta {
		if !strings.HasPrefix(strings.ToLower((key)), prefix) {
			key = prefix + key
		}
		result[key] = value
	}
	return result
}

// Remove prefix from key of meta
func ParseMeta(meta map[string]string, prefix string) map[string]string {
	userMeta := make(map[string]string)
	for key, value := range meta {
		if strings.HasPrefix(strings.ToLower(key), prefix) {
			key = strings.Replace(key, prefix, "", 1)
		}
		userMeta[key] = value
	}
	return userMeta
}

func GetErrMessage(bodyStr string) map[string]interface{} {
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

// Return md5 according to body
func GetContentMD5(a string, isEnableMD5 bool) string {
	if !isEnableMD5 {
		return ""
	}

	sum := md5.Sum([]byte(a))
	b64 := base64.StdEncoding.EncodeToString(sum[:])
	return b64
}

// Return content-type according to object name
func GetContentType(name string) string {
	return typeByExtension(name)
}

// Encryption
func Encode(val string, encodeType string) string {
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

func Decode(value string, decodeType string) string {
	if decodeType == "Base64Decode" {
		return base64Decode(value)
	} else if decodeType == "UrlDecode" {
		return urlDecode(value)
	}
	return value
}

func Inject(body io.Reader, ref map[string]string) io.Reader {
	body = ComplexReader(body, ref)
	return body
}

func GetHost(bucketName, regionId, endpoint, hostModel string) string {
	host := ""
	if regionId == "" {
		regionId = "cn-hangzhou"
	}
	if endpoint == "" {
		endpoint = "oss-" + regionId + ".aliyuncs.com"
	}
	if bucketName != "" {
		if strings.ToLower(hostModel) == "ip" {
			host = endpoint + "/" + bucketName
		} else if strings.ToLower(hostModel) == "cname" {
			host = endpoint
		} else {
			host = bucketName + "." + endpoint
		}
	} else {
		host = endpoint
	}
	return host
}
