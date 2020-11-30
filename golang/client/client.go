// This file is auto-generated, don't edit it. Thanks.
package client

import (
	fileform "github.com/alibabacloud-go/tea-fileform/service"
	ossutil "github.com/alibabacloud-go/tea-oss-utils/service"
	util "github.com/alibabacloud-go/tea-utils/service"
	xml "github.com/alibabacloud-go/tea-xml/service"
	"github.com/alibabacloud-go/tea/tea"
	credential "github.com/aliyun/credentials-go/credentials"
	"io"
)

type Config struct {
	Type             *string   `json:"type,omitempty" xml:"type,omitempty"`
	SecurityToken    *string   `json:"securityToken,omitempty" xml:"securityToken,omitempty"`
	AccessKeyId      *string   `json:"accessKeyId,omitempty" xml:"accessKeyId,omitempty" require:"true"`
	AccessKeySecret  *string   `json:"accessKeySecret,omitempty" xml:"accessKeySecret,omitempty" require:"true"`
	Endpoint         *string   `json:"endpoint,omitempty" xml:"endpoint,omitempty"`
	Protocol         *string   `json:"protocol,omitempty" xml:"protocol,omitempty"`
	RegionId         *string   `json:"regionId,omitempty" xml:"regionId,omitempty" pattern:"[a-zA-Z0-9-_]+"`
	UserAgent        *string   `json:"userAgent,omitempty" xml:"userAgent,omitempty"`
	HostModel        *string   `json:"hostModel,omitempty" xml:"hostModel,omitempty"`
	SignatureVersion *string   `json:"signatureVersion,omitempty" xml:"signatureVersion,omitempty"`
	IsEnableMD5      *bool     `json:"isEnableMD5,omitempty" xml:"isEnableMD5,omitempty"`
	IsEnableCrc      *bool     `json:"isEnableCrc,omitempty" xml:"isEnableCrc,omitempty"`
	ReadTimeout      *int      `json:"readTimeout,omitempty" xml:"readTimeout,omitempty"`
	ConnectTimeout   *int      `json:"connectTimeout,omitempty" xml:"connectTimeout,omitempty"`
	LocalAddr        *string   `json:"localAddr,omitempty" xml:"localAddr,omitempty"`
	HttpProxy        *string   `json:"httpProxy,omitempty" xml:"httpProxy,omitempty"`
	HttpsProxy       *string   `json:"httpsProxy,omitempty" xml:"httpsProxy,omitempty"`
	NoProxy          *string   `json:"noProxy,omitempty" xml:"noProxy,omitempty"`
	Socks5Proxy      *string   `json:"socks5Proxy,omitempty" xml:"socks5Proxy,omitempty"`
	Socks5NetWork    *string   `json:"socks5NetWork,omitempty" xml:"socks5NetWork,omitempty"`
	MaxIdleConns     *int      `json:"maxIdleConns,omitempty" xml:"maxIdleConns,omitempty"`
	AddtionalHeaders []*string `json:"addtionalHeaders,omitempty" xml:"addtionalHeaders,omitempty" type:"Repeated"`
}

func (s Config) String() string {
	return tea.Prettify(s)
}

func (s Config) GoString() string {
	return s.String()
}

func (s *Config) SetType(v string) *Config {
	s.Type = &v
	return s
}

func (s *Config) SetSecurityToken(v string) *Config {
	s.SecurityToken = &v
	return s
}

func (s *Config) SetAccessKeyId(v string) *Config {
	s.AccessKeyId = &v
	return s
}

func (s *Config) SetAccessKeySecret(v string) *Config {
	s.AccessKeySecret = &v
	return s
}

func (s *Config) SetEndpoint(v string) *Config {
	s.Endpoint = &v
	return s
}

func (s *Config) SetProtocol(v string) *Config {
	s.Protocol = &v
	return s
}

func (s *Config) SetRegionId(v string) *Config {
	s.RegionId = &v
	return s
}

func (s *Config) SetUserAgent(v string) *Config {
	s.UserAgent = &v
	return s
}

func (s *Config) SetHostModel(v string) *Config {
	s.HostModel = &v
	return s
}

func (s *Config) SetSignatureVersion(v string) *Config {
	s.SignatureVersion = &v
	return s
}

func (s *Config) SetIsEnableMD5(v bool) *Config {
	s.IsEnableMD5 = &v
	return s
}

func (s *Config) SetIsEnableCrc(v bool) *Config {
	s.IsEnableCrc = &v
	return s
}

func (s *Config) SetReadTimeout(v int) *Config {
	s.ReadTimeout = &v
	return s
}

func (s *Config) SetConnectTimeout(v int) *Config {
	s.ConnectTimeout = &v
	return s
}

func (s *Config) SetLocalAddr(v string) *Config {
	s.LocalAddr = &v
	return s
}

func (s *Config) SetHttpProxy(v string) *Config {
	s.HttpProxy = &v
	return s
}

func (s *Config) SetHttpsProxy(v string) *Config {
	s.HttpsProxy = &v
	return s
}

func (s *Config) SetNoProxy(v string) *Config {
	s.NoProxy = &v
	return s
}

func (s *Config) SetSocks5Proxy(v string) *Config {
	s.Socks5Proxy = &v
	return s
}

func (s *Config) SetSocks5NetWork(v string) *Config {
	s.Socks5NetWork = &v
	return s
}

func (s *Config) SetMaxIdleConns(v int) *Config {
	s.MaxIdleConns = &v
	return s
}

func (s *Config) SetAddtionalHeaders(v []*string) *Config {
	s.AddtionalHeaders = v
	return s
}

type PutBucketLifecycleRequest struct {
	// BucketName
	BucketName *string `json:"BucketName,omitempty" xml:"BucketName,omitempty" require:"true" pattern:"[a-zA-Z0-9-_]+"`
	// Body
	Body *PutBucketLifecycleRequestBody `json:"Body,omitempty" xml:"Body,omitempty" type:"Struct"`
}

func (s PutBucketLifecycleRequest) String() string {
	return tea.Prettify(s)
}

func (s PutBucketLifecycleRequest) GoString() string {
	return s.String()
}

func (s *PutBucketLifecycleRequest) SetBucketName(v string) *PutBucketLifecycleRequest {
	s.BucketName = &v
	return s
}

func (s *PutBucketLifecycleRequest) SetBody(v *PutBucketLifecycleRequestBody) *PutBucketLifecycleRequest {
	s.Body = v
	return s
}

type PutBucketLifecycleRequestBody struct {
	// LifecycleConfiguration
	LifecycleConfiguration *PutBucketLifecycleRequestBodyLifecycleConfiguration `json:"LifecycleConfiguration,omitempty" xml:"LifecycleConfiguration,omitempty" require:"true" type:"Struct"`
}

func (s PutBucketLifecycleRequestBody) String() string {
	return tea.Prettify(s)
}

func (s PutBucketLifecycleRequestBody) GoString() string {
	return s.String()
}

func (s *PutBucketLifecycleRequestBody) SetLifecycleConfiguration(v *PutBucketLifecycleRequestBodyLifecycleConfiguration) *PutBucketLifecycleRequestBody {
	s.LifecycleConfiguration = v
	return s
}

type PutBucketLifecycleRequestBodyLifecycleConfiguration struct {
	// Rule
	Rule []*PutBucketLifecycleRequestBodyLifecycleConfigurationRule `json:"Rule,omitempty" xml:"Rule,omitempty" type:"Repeated"`
}

func (s PutBucketLifecycleRequestBodyLifecycleConfiguration) String() string {
	return tea.Prettify(s)
}

func (s PutBucketLifecycleRequestBodyLifecycleConfiguration) GoString() string {
	return s.String()
}

func (s *PutBucketLifecycleRequestBodyLifecycleConfiguration) SetRule(v []*PutBucketLifecycleRequestBodyLifecycleConfigurationRule) *PutBucketLifecycleRequestBodyLifecycleConfiguration {
	s.Rule = v
	return s
}

type PutBucketLifecycleRequestBodyLifecycleConfigurationRule struct {
	// Expiration
	Expiration *PutBucketLifecycleRequestBodyLifecycleConfigurationRuleExpiration `json:"Expiration,omitempty" xml:"Expiration,omitempty" type:"Struct"`
	// Transition
	Transition *PutBucketLifecycleRequestBodyLifecycleConfigurationRuleTransition `json:"Transition,omitempty" xml:"Transition,omitempty" type:"Struct"`
	// AbortMultipartUpload
	AbortMultipartUpload *PutBucketLifecycleRequestBodyLifecycleConfigurationRuleAbortMultipartUpload `json:"AbortMultipartUpload,omitempty" xml:"AbortMultipartUpload,omitempty" type:"Struct"`
	// Tag
	Tag *PutBucketLifecycleRequestBodyLifecycleConfigurationRuleTag `json:"Tag,omitempty" xml:"Tag,omitempty" type:"Struct"`
	// ID
	ID *string `json:"ID,omitempty" xml:"ID,omitempty"`
	// Prefix
	Prefix *string `json:"Prefix,omitempty" xml:"Prefix,omitempty"`
	// Status
	Status *string `json:"Status,omitempty" xml:"Status,omitempty"`
}

func (s PutBucketLifecycleRequestBodyLifecycleConfigurationRule) String() string {
	return tea.Prettify(s)
}

func (s PutBucketLifecycleRequestBodyLifecycleConfigurationRule) GoString() string {
	return s.String()
}

func (s *PutBucketLifecycleRequestBodyLifecycleConfigurationRule) SetExpiration(v *PutBucketLifecycleRequestBodyLifecycleConfigurationRuleExpiration) *PutBucketLifecycleRequestBodyLifecycleConfigurationRule {
	s.Expiration = v
	return s
}

func (s *PutBucketLifecycleRequestBodyLifecycleConfigurationRule) SetTransition(v *PutBucketLifecycleRequestBodyLifecycleConfigurationRuleTransition) *PutBucketLifecycleRequestBodyLifecycleConfigurationRule {
	s.Transition = v
	return s
}

func (s *PutBucketLifecycleRequestBodyLifecycleConfigurationRule) SetAbortMultipartUpload(v *PutBucketLifecycleRequestBodyLifecycleConfigurationRuleAbortMultipartUpload) *PutBucketLifecycleRequestBodyLifecycleConfigurationRule {
	s.AbortMultipartUpload = v
	return s
}

func (s *PutBucketLifecycleRequestBodyLifecycleConfigurationRule) SetTag(v *PutBucketLifecycleRequestBodyLifecycleConfigurationRuleTag) *PutBucketLifecycleRequestBodyLifecycleConfigurationRule {
	s.Tag = v
	return s
}

func (s *PutBucketLifecycleRequestBodyLifecycleConfigurationRule) SetID(v string) *PutBucketLifecycleRequestBodyLifecycleConfigurationRule {
	s.ID = &v
	return s
}

func (s *PutBucketLifecycleRequestBodyLifecycleConfigurationRule) SetPrefix(v string) *PutBucketLifecycleRequestBodyLifecycleConfigurationRule {
	s.Prefix = &v
	return s
}

func (s *PutBucketLifecycleRequestBodyLifecycleConfigurationRule) SetStatus(v string) *PutBucketLifecycleRequestBodyLifecycleConfigurationRule {
	s.Status = &v
	return s
}

type PutBucketLifecycleRequestBodyLifecycleConfigurationRuleExpiration struct {
	// Days
	Days *int `json:"Days,omitempty" xml:"Days,omitempty"`
	// CreatedBeforeDate
	CreatedBeforeDate *string `json:"CreatedBeforeDate,omitempty" xml:"CreatedBeforeDate,omitempty"`
}

func (s PutBucketLifecycleRequestBodyLifecycleConfigurationRuleExpiration) String() string {
	return tea.Prettify(s)
}

func (s PutBucketLifecycleRequestBodyLifecycleConfigurationRuleExpiration) GoString() string {
	return s.String()
}

func (s *PutBucketLifecycleRequestBodyLifecycleConfigurationRuleExpiration) SetDays(v int) *PutBucketLifecycleRequestBodyLifecycleConfigurationRuleExpiration {
	s.Days = &v
	return s
}

func (s *PutBucketLifecycleRequestBodyLifecycleConfigurationRuleExpiration) SetCreatedBeforeDate(v string) *PutBucketLifecycleRequestBodyLifecycleConfigurationRuleExpiration {
	s.CreatedBeforeDate = &v
	return s
}

type PutBucketLifecycleRequestBodyLifecycleConfigurationRuleTransition struct {
	// Days
	Days *int `json:"Days,omitempty" xml:"Days,omitempty"`
	// StorageClass
	StorageClass *string `json:"StorageClass,omitempty" xml:"StorageClass,omitempty"`
}

func (s PutBucketLifecycleRequestBodyLifecycleConfigurationRuleTransition) String() string {
	return tea.Prettify(s)
}

func (s PutBucketLifecycleRequestBodyLifecycleConfigurationRuleTransition) GoString() string {
	return s.String()
}

func (s *PutBucketLifecycleRequestBodyLifecycleConfigurationRuleTransition) SetDays(v int) *PutBucketLifecycleRequestBodyLifecycleConfigurationRuleTransition {
	s.Days = &v
	return s
}

func (s *PutBucketLifecycleRequestBodyLifecycleConfigurationRuleTransition) SetStorageClass(v string) *PutBucketLifecycleRequestBodyLifecycleConfigurationRuleTransition {
	s.StorageClass = &v
	return s
}

type PutBucketLifecycleRequestBodyLifecycleConfigurationRuleAbortMultipartUpload struct {
	// Days
	Days *int `json:"Days,omitempty" xml:"Days,omitempty"`
	// CreatedBeforeDate
	CreatedBeforeDate *string `json:"CreatedBeforeDate,omitempty" xml:"CreatedBeforeDate,omitempty"`
}

func (s PutBucketLifecycleRequestBodyLifecycleConfigurationRuleAbortMultipartUpload) String() string {
	return tea.Prettify(s)
}

func (s PutBucketLifecycleRequestBodyLifecycleConfigurationRuleAbortMultipartUpload) GoString() string {
	return s.String()
}

func (s *PutBucketLifecycleRequestBodyLifecycleConfigurationRuleAbortMultipartUpload) SetDays(v int) *PutBucketLifecycleRequestBodyLifecycleConfigurationRuleAbortMultipartUpload {
	s.Days = &v
	return s
}

func (s *PutBucketLifecycleRequestBodyLifecycleConfigurationRuleAbortMultipartUpload) SetCreatedBeforeDate(v string) *PutBucketLifecycleRequestBodyLifecycleConfigurationRuleAbortMultipartUpload {
	s.CreatedBeforeDate = &v
	return s
}

type PutBucketLifecycleRequestBodyLifecycleConfigurationRuleTag struct {
	// Key
	Key *string `json:"Key,omitempty" xml:"Key,omitempty"`
	// Value
	Value *string `json:"Value,omitempty" xml:"Value,omitempty"`
}

func (s PutBucketLifecycleRequestBodyLifecycleConfigurationRuleTag) String() string {
	return tea.Prettify(s)
}

func (s PutBucketLifecycleRequestBodyLifecycleConfigurationRuleTag) GoString() string {
	return s.String()
}

func (s *PutBucketLifecycleRequestBodyLifecycleConfigurationRuleTag) SetKey(v string) *PutBucketLifecycleRequestBodyLifecycleConfigurationRuleTag {
	s.Key = &v
	return s
}

func (s *PutBucketLifecycleRequestBodyLifecycleConfigurationRuleTag) SetValue(v string) *PutBucketLifecycleRequestBodyLifecycleConfigurationRuleTag {
	s.Value = &v
	return s
}

type PutBucketLifecycleResponse struct {
	// x-oss-request-id
	RequestId *string `json:"x-oss-request-id,omitempty" xml:"x-oss-request-id,omitempty" require:"true"`
}

func (s PutBucketLifecycleResponse) String() string {
	return tea.Prettify(s)
}

func (s PutBucketLifecycleResponse) GoString() string {
	return s.String()
}

func (s *PutBucketLifecycleResponse) SetRequestId(v string) *PutBucketLifecycleResponse {
	s.RequestId = &v
	return s
}

type DeleteMultipleObjectsRequest struct {
	// BucketName
	BucketName *string `json:"BucketName,omitempty" xml:"BucketName,omitempty" require:"true" pattern:"[a-zA-Z0-9-_]+"`
	// Body
	Body *DeleteMultipleObjectsRequestBody `json:"Body,omitempty" xml:"Body,omitempty" type:"Struct"`
	// Header
	Header *DeleteMultipleObjectsRequestHeader `json:"Header,omitempty" xml:"Header,omitempty" require:"true" type:"Struct"`
}

func (s DeleteMultipleObjectsRequest) String() string {
	return tea.Prettify(s)
}

func (s DeleteMultipleObjectsRequest) GoString() string {
	return s.String()
}

func (s *DeleteMultipleObjectsRequest) SetBucketName(v string) *DeleteMultipleObjectsRequest {
	s.BucketName = &v
	return s
}

func (s *DeleteMultipleObjectsRequest) SetBody(v *DeleteMultipleObjectsRequestBody) *DeleteMultipleObjectsRequest {
	s.Body = v
	return s
}

func (s *DeleteMultipleObjectsRequest) SetHeader(v *DeleteMultipleObjectsRequestHeader) *DeleteMultipleObjectsRequest {
	s.Header = v
	return s
}

type DeleteMultipleObjectsRequestBody struct {
	// Delete
	Delete *DeleteMultipleObjectsRequestBodyDelete `json:"Delete,omitempty" xml:"Delete,omitempty" require:"true" type:"Struct"`
}

func (s DeleteMultipleObjectsRequestBody) String() string {
	return tea.Prettify(s)
}

func (s DeleteMultipleObjectsRequestBody) GoString() string {
	return s.String()
}

func (s *DeleteMultipleObjectsRequestBody) SetDelete(v *DeleteMultipleObjectsRequestBodyDelete) *DeleteMultipleObjectsRequestBody {
	s.Delete = v
	return s
}

type DeleteMultipleObjectsRequestBodyDelete struct {
	// Object
	Object []*DeleteMultipleObjectsRequestBodyDeleteObject `json:"Object,omitempty" xml:"Object,omitempty" type:"Repeated"`
	// Quiet
	Quiet *string `json:"Quiet,omitempty" xml:"Quiet,omitempty"`
}

func (s DeleteMultipleObjectsRequestBodyDelete) String() string {
	return tea.Prettify(s)
}

func (s DeleteMultipleObjectsRequestBodyDelete) GoString() string {
	return s.String()
}

func (s *DeleteMultipleObjectsRequestBodyDelete) SetObject(v []*DeleteMultipleObjectsRequestBodyDeleteObject) *DeleteMultipleObjectsRequestBodyDelete {
	s.Object = v
	return s
}

func (s *DeleteMultipleObjectsRequestBodyDelete) SetQuiet(v string) *DeleteMultipleObjectsRequestBodyDelete {
	s.Quiet = &v
	return s
}

type DeleteMultipleObjectsRequestBodyDeleteObject struct {
	// Key
	Key *string `json:"Key,omitempty" xml:"Key,omitempty"`
}

func (s DeleteMultipleObjectsRequestBodyDeleteObject) String() string {
	return tea.Prettify(s)
}

func (s DeleteMultipleObjectsRequestBodyDeleteObject) GoString() string {
	return s.String()
}

func (s *DeleteMultipleObjectsRequestBodyDeleteObject) SetKey(v string) *DeleteMultipleObjectsRequestBodyDeleteObject {
	s.Key = &v
	return s
}

type DeleteMultipleObjectsRequestHeader struct {
	// Encoding-type
	EncodingType *string `json:"Encoding-type,omitempty" xml:"Encoding-type,omitempty"`
	// Content-Length
	ContentLength *string `json:"Content-Length,omitempty" xml:"Content-Length,omitempty" require:"true"`
	// Content-MD5
	ContentMD5 *string `json:"Content-MD5,omitempty" xml:"Content-MD5,omitempty" require:"true"`
}

func (s DeleteMultipleObjectsRequestHeader) String() string {
	return tea.Prettify(s)
}

func (s DeleteMultipleObjectsRequestHeader) GoString() string {
	return s.String()
}

func (s *DeleteMultipleObjectsRequestHeader) SetEncodingType(v string) *DeleteMultipleObjectsRequestHeader {
	s.EncodingType = &v
	return s
}

func (s *DeleteMultipleObjectsRequestHeader) SetContentLength(v string) *DeleteMultipleObjectsRequestHeader {
	s.ContentLength = &v
	return s
}

func (s *DeleteMultipleObjectsRequestHeader) SetContentMD5(v string) *DeleteMultipleObjectsRequestHeader {
	s.ContentMD5 = &v
	return s
}

type DeleteMultipleObjectsResponse struct {
	// x-oss-request-id
	RequestId *string `json:"x-oss-request-id,omitempty" xml:"x-oss-request-id,omitempty" require:"true"`
	// DeleteResult
	DeleteResult *DeleteMultipleObjectsResponseDeleteResult `json:"DeleteResult,omitempty" xml:"DeleteResult,omitempty" require:"true" type:"Struct"`
}

func (s DeleteMultipleObjectsResponse) String() string {
	return tea.Prettify(s)
}

func (s DeleteMultipleObjectsResponse) GoString() string {
	return s.String()
}

func (s *DeleteMultipleObjectsResponse) SetRequestId(v string) *DeleteMultipleObjectsResponse {
	s.RequestId = &v
	return s
}

func (s *DeleteMultipleObjectsResponse) SetDeleteResult(v *DeleteMultipleObjectsResponseDeleteResult) *DeleteMultipleObjectsResponse {
	s.DeleteResult = v
	return s
}

type DeleteMultipleObjectsResponseDeleteResult struct {
	// Quiet
	Quiet *string `json:"Quiet,omitempty" xml:"Quiet,omitempty"`
	// EncodingType
	EncodingType *string `json:"EncodingType,omitempty" xml:"EncodingType,omitempty"`
	// Deleted
	Deleted []*DeleteMultipleObjectsResponseDeleteResultDeleted `json:"Deleted,omitempty" xml:"Deleted,omitempty" type:"Repeated"`
}

func (s DeleteMultipleObjectsResponseDeleteResult) String() string {
	return tea.Prettify(s)
}

func (s DeleteMultipleObjectsResponseDeleteResult) GoString() string {
	return s.String()
}

func (s *DeleteMultipleObjectsResponseDeleteResult) SetQuiet(v string) *DeleteMultipleObjectsResponseDeleteResult {
	s.Quiet = &v
	return s
}

func (s *DeleteMultipleObjectsResponseDeleteResult) SetEncodingType(v string) *DeleteMultipleObjectsResponseDeleteResult {
	s.EncodingType = &v
	return s
}

func (s *DeleteMultipleObjectsResponseDeleteResult) SetDeleted(v []*DeleteMultipleObjectsResponseDeleteResultDeleted) *DeleteMultipleObjectsResponseDeleteResult {
	s.Deleted = v
	return s
}

type DeleteMultipleObjectsResponseDeleteResultDeleted struct {
	// Key
	Key *string `json:"Key,omitempty" xml:"Key,omitempty"`
}

func (s DeleteMultipleObjectsResponseDeleteResultDeleted) String() string {
	return tea.Prettify(s)
}

func (s DeleteMultipleObjectsResponseDeleteResultDeleted) GoString() string {
	return s.String()
}

func (s *DeleteMultipleObjectsResponseDeleteResultDeleted) SetKey(v string) *DeleteMultipleObjectsResponseDeleteResultDeleted {
	s.Key = &v
	return s
}

type PutBucketRefererRequest struct {
	// BucketName
	BucketName *string `json:"BucketName,omitempty" xml:"BucketName,omitempty" require:"true" pattern:"[a-zA-Z0-9-_]+"`
	// Body
	Body *PutBucketRefererRequestBody `json:"Body,omitempty" xml:"Body,omitempty" type:"Struct"`
}

func (s PutBucketRefererRequest) String() string {
	return tea.Prettify(s)
}

func (s PutBucketRefererRequest) GoString() string {
	return s.String()
}

func (s *PutBucketRefererRequest) SetBucketName(v string) *PutBucketRefererRequest {
	s.BucketName = &v
	return s
}

func (s *PutBucketRefererRequest) SetBody(v *PutBucketRefererRequestBody) *PutBucketRefererRequest {
	s.Body = v
	return s
}

type PutBucketRefererRequestBody struct {
	// RefererConfiguration
	RefererConfiguration *PutBucketRefererRequestBodyRefererConfiguration `json:"RefererConfiguration,omitempty" xml:"RefererConfiguration,omitempty" require:"true" type:"Struct"`
}

func (s PutBucketRefererRequestBody) String() string {
	return tea.Prettify(s)
}

func (s PutBucketRefererRequestBody) GoString() string {
	return s.String()
}

func (s *PutBucketRefererRequestBody) SetRefererConfiguration(v *PutBucketRefererRequestBodyRefererConfiguration) *PutBucketRefererRequestBody {
	s.RefererConfiguration = v
	return s
}

type PutBucketRefererRequestBodyRefererConfiguration struct {
	// RefererList
	RefererList *PutBucketRefererRequestBodyRefererConfigurationRefererList `json:"RefererList,omitempty" xml:"RefererList,omitempty" type:"Struct"`
	// AllowEmptyReferer
	AllowEmptyReferer *bool `json:"AllowEmptyReferer,omitempty" xml:"AllowEmptyReferer,omitempty"`
}

func (s PutBucketRefererRequestBodyRefererConfiguration) String() string {
	return tea.Prettify(s)
}

func (s PutBucketRefererRequestBodyRefererConfiguration) GoString() string {
	return s.String()
}

func (s *PutBucketRefererRequestBodyRefererConfiguration) SetRefererList(v *PutBucketRefererRequestBodyRefererConfigurationRefererList) *PutBucketRefererRequestBodyRefererConfiguration {
	s.RefererList = v
	return s
}

func (s *PutBucketRefererRequestBodyRefererConfiguration) SetAllowEmptyReferer(v bool) *PutBucketRefererRequestBodyRefererConfiguration {
	s.AllowEmptyReferer = &v
	return s
}

type PutBucketRefererRequestBodyRefererConfigurationRefererList struct {
	// Referer
	Referer []*string `json:"Referer,omitempty" xml:"Referer,omitempty" type:"Repeated"`
}

func (s PutBucketRefererRequestBodyRefererConfigurationRefererList) String() string {
	return tea.Prettify(s)
}

func (s PutBucketRefererRequestBodyRefererConfigurationRefererList) GoString() string {
	return s.String()
}

func (s *PutBucketRefererRequestBodyRefererConfigurationRefererList) SetReferer(v []*string) *PutBucketRefererRequestBodyRefererConfigurationRefererList {
	s.Referer = v
	return s
}

type PutBucketRefererResponse struct {
	// x-oss-request-id
	RequestId *string `json:"x-oss-request-id,omitempty" xml:"x-oss-request-id,omitempty" require:"true"`
}

func (s PutBucketRefererResponse) String() string {
	return tea.Prettify(s)
}

func (s PutBucketRefererResponse) GoString() string {
	return s.String()
}

func (s *PutBucketRefererResponse) SetRequestId(v string) *PutBucketRefererResponse {
	s.RequestId = &v
	return s
}

type PutBucketWebsiteRequest struct {
	// BucketName
	BucketName *string `json:"BucketName,omitempty" xml:"BucketName,omitempty" require:"true" pattern:"[a-zA-Z0-9-_]+"`
	// Body
	Body *PutBucketWebsiteRequestBody `json:"Body,omitempty" xml:"Body,omitempty" type:"Struct"`
}

func (s PutBucketWebsiteRequest) String() string {
	return tea.Prettify(s)
}

func (s PutBucketWebsiteRequest) GoString() string {
	return s.String()
}

func (s *PutBucketWebsiteRequest) SetBucketName(v string) *PutBucketWebsiteRequest {
	s.BucketName = &v
	return s
}

func (s *PutBucketWebsiteRequest) SetBody(v *PutBucketWebsiteRequestBody) *PutBucketWebsiteRequest {
	s.Body = v
	return s
}

type PutBucketWebsiteRequestBody struct {
	// WebsiteConfiguration
	WebsiteConfiguration *PutBucketWebsiteRequestBodyWebsiteConfiguration `json:"WebsiteConfiguration,omitempty" xml:"WebsiteConfiguration,omitempty" require:"true" type:"Struct"`
}

func (s PutBucketWebsiteRequestBody) String() string {
	return tea.Prettify(s)
}

func (s PutBucketWebsiteRequestBody) GoString() string {
	return s.String()
}

func (s *PutBucketWebsiteRequestBody) SetWebsiteConfiguration(v *PutBucketWebsiteRequestBodyWebsiteConfiguration) *PutBucketWebsiteRequestBody {
	s.WebsiteConfiguration = v
	return s
}

type PutBucketWebsiteRequestBodyWebsiteConfiguration struct {
	// IndexDocument
	IndexDocument *PutBucketWebsiteRequestBodyWebsiteConfigurationIndexDocument `json:"IndexDocument,omitempty" xml:"IndexDocument,omitempty" type:"Struct"`
	// ErrorDocument
	ErrorDocument *PutBucketWebsiteRequestBodyWebsiteConfigurationErrorDocument `json:"ErrorDocument,omitempty" xml:"ErrorDocument,omitempty" type:"Struct"`
	// RoutingRules
	RoutingRules *PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRules `json:"RoutingRules,omitempty" xml:"RoutingRules,omitempty" type:"Struct"`
}

func (s PutBucketWebsiteRequestBodyWebsiteConfiguration) String() string {
	return tea.Prettify(s)
}

func (s PutBucketWebsiteRequestBodyWebsiteConfiguration) GoString() string {
	return s.String()
}

func (s *PutBucketWebsiteRequestBodyWebsiteConfiguration) SetIndexDocument(v *PutBucketWebsiteRequestBodyWebsiteConfigurationIndexDocument) *PutBucketWebsiteRequestBodyWebsiteConfiguration {
	s.IndexDocument = v
	return s
}

func (s *PutBucketWebsiteRequestBodyWebsiteConfiguration) SetErrorDocument(v *PutBucketWebsiteRequestBodyWebsiteConfigurationErrorDocument) *PutBucketWebsiteRequestBodyWebsiteConfiguration {
	s.ErrorDocument = v
	return s
}

func (s *PutBucketWebsiteRequestBodyWebsiteConfiguration) SetRoutingRules(v *PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRules) *PutBucketWebsiteRequestBodyWebsiteConfiguration {
	s.RoutingRules = v
	return s
}

type PutBucketWebsiteRequestBodyWebsiteConfigurationIndexDocument struct {
	// Suffix
	Suffix *string `json:"Suffix,omitempty" xml:"Suffix,omitempty"`
}

func (s PutBucketWebsiteRequestBodyWebsiteConfigurationIndexDocument) String() string {
	return tea.Prettify(s)
}

func (s PutBucketWebsiteRequestBodyWebsiteConfigurationIndexDocument) GoString() string {
	return s.String()
}

func (s *PutBucketWebsiteRequestBodyWebsiteConfigurationIndexDocument) SetSuffix(v string) *PutBucketWebsiteRequestBodyWebsiteConfigurationIndexDocument {
	s.Suffix = &v
	return s
}

type PutBucketWebsiteRequestBodyWebsiteConfigurationErrorDocument struct {
	// Key
	Key *string `json:"Key,omitempty" xml:"Key,omitempty"`
}

func (s PutBucketWebsiteRequestBodyWebsiteConfigurationErrorDocument) String() string {
	return tea.Prettify(s)
}

func (s PutBucketWebsiteRequestBodyWebsiteConfigurationErrorDocument) GoString() string {
	return s.String()
}

func (s *PutBucketWebsiteRequestBodyWebsiteConfigurationErrorDocument) SetKey(v string) *PutBucketWebsiteRequestBodyWebsiteConfigurationErrorDocument {
	s.Key = &v
	return s
}

type PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRules struct {
	// RoutingRule
	RoutingRule []*PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRule `json:"RoutingRule,omitempty" xml:"RoutingRule,omitempty" type:"Repeated"`
}

func (s PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRules) String() string {
	return tea.Prettify(s)
}

func (s PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRules) GoString() string {
	return s.String()
}

func (s *PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRules) SetRoutingRule(v []*PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRule) *PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRules {
	s.RoutingRule = v
	return s
}

type PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRule struct {
	// Condition
	Condition *PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleCondition `json:"Condition,omitempty" xml:"Condition,omitempty" type:"Struct"`
	// Redirect
	Redirect *PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirect `json:"Redirect,omitempty" xml:"Redirect,omitempty" type:"Struct"`
	// RuleNumber
	RuleNumber *int `json:"RuleNumber,omitempty" xml:"RuleNumber,omitempty"`
}

func (s PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRule) String() string {
	return tea.Prettify(s)
}

func (s PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRule) GoString() string {
	return s.String()
}

func (s *PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRule) SetCondition(v *PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleCondition) *PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRule {
	s.Condition = v
	return s
}

func (s *PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRule) SetRedirect(v *PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirect) *PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRule {
	s.Redirect = v
	return s
}

func (s *PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRule) SetRuleNumber(v int) *PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRule {
	s.RuleNumber = &v
	return s
}

type PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleCondition struct {
	// IncludeHeader
	IncludeHeader *PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleConditionIncludeHeader `json:"IncludeHeader,omitempty" xml:"IncludeHeader,omitempty" type:"Struct"`
	// KeyPrefixEquals
	KeyPrefixEquals *string `json:"KeyPrefixEquals,omitempty" xml:"KeyPrefixEquals,omitempty"`
	// HttpErrorCodeReturnedEquals
	HttpErrorCodeReturnedEquals *string `json:"HttpErrorCodeReturnedEquals,omitempty" xml:"HttpErrorCodeReturnedEquals,omitempty"`
}

func (s PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleCondition) String() string {
	return tea.Prettify(s)
}

func (s PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleCondition) GoString() string {
	return s.String()
}

func (s *PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleCondition) SetIncludeHeader(v *PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleConditionIncludeHeader) *PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleCondition {
	s.IncludeHeader = v
	return s
}

func (s *PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleCondition) SetKeyPrefixEquals(v string) *PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleCondition {
	s.KeyPrefixEquals = &v
	return s
}

func (s *PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleCondition) SetHttpErrorCodeReturnedEquals(v string) *PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleCondition {
	s.HttpErrorCodeReturnedEquals = &v
	return s
}

type PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleConditionIncludeHeader struct {
	// Key
	Key *string `json:"Key,omitempty" xml:"Key,omitempty"`
	// Equals
	Equals *string `json:"Equals,omitempty" xml:"Equals,omitempty"`
}

func (s PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleConditionIncludeHeader) String() string {
	return tea.Prettify(s)
}

func (s PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleConditionIncludeHeader) GoString() string {
	return s.String()
}

func (s *PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleConditionIncludeHeader) SetKey(v string) *PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleConditionIncludeHeader {
	s.Key = &v
	return s
}

func (s *PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleConditionIncludeHeader) SetEquals(v string) *PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleConditionIncludeHeader {
	s.Equals = &v
	return s
}

type PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirect struct {
	// MirrorHeaders
	MirrorHeaders *PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeaders `json:"MirrorHeaders,omitempty" xml:"MirrorHeaders,omitempty" type:"Struct"`
	// RedirectType
	RedirectType *string `json:"RedirectType,omitempty" xml:"RedirectType,omitempty"`
	// PassQueryString
	PassQueryString *bool `json:"PassQueryString,omitempty" xml:"PassQueryString,omitempty"`
	// MirrorURL
	MirrorURL *string `json:"MirrorURL,omitempty" xml:"MirrorURL,omitempty"`
	// MirrorPassQueryString
	MirrorPassQueryString *bool `json:"MirrorPassQueryString,omitempty" xml:"MirrorPassQueryString,omitempty"`
	// MirrorFollowRedirect
	MirrorFollowRedirect *bool `json:"MirrorFollowRedirect,omitempty" xml:"MirrorFollowRedirect,omitempty"`
	// MirrorCheckMd5
	MirrorCheckMd5 *bool `json:"MirrorCheckMd5,omitempty" xml:"MirrorCheckMd5,omitempty"`
	// Protocol
	Protocol *string `json:"Protocol,omitempty" xml:"Protocol,omitempty"`
	// HostName
	HostName *string `json:"HostName,omitempty" xml:"HostName,omitempty"`
	// HttpRedirectCode
	HttpRedirectCode *string `json:"HttpRedirectCode,omitempty" xml:"HttpRedirectCode,omitempty"`
	// ReplaceKeyPrefixWith
	ReplaceKeyPrefixWith *string `json:"ReplaceKeyPrefixWith,omitempty" xml:"ReplaceKeyPrefixWith,omitempty"`
	// ReplaceKeyWith
	ReplaceKeyWith *string `json:"ReplaceKeyWith,omitempty" xml:"ReplaceKeyWith,omitempty"`
}

func (s PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirect) String() string {
	return tea.Prettify(s)
}

func (s PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirect) GoString() string {
	return s.String()
}

func (s *PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirect) SetMirrorHeaders(v *PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeaders) *PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirect {
	s.MirrorHeaders = v
	return s
}

func (s *PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirect) SetRedirectType(v string) *PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirect {
	s.RedirectType = &v
	return s
}

func (s *PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirect) SetPassQueryString(v bool) *PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirect {
	s.PassQueryString = &v
	return s
}

func (s *PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirect) SetMirrorURL(v string) *PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirect {
	s.MirrorURL = &v
	return s
}

func (s *PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirect) SetMirrorPassQueryString(v bool) *PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirect {
	s.MirrorPassQueryString = &v
	return s
}

func (s *PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirect) SetMirrorFollowRedirect(v bool) *PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirect {
	s.MirrorFollowRedirect = &v
	return s
}

func (s *PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirect) SetMirrorCheckMd5(v bool) *PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirect {
	s.MirrorCheckMd5 = &v
	return s
}

func (s *PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirect) SetProtocol(v string) *PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirect {
	s.Protocol = &v
	return s
}

func (s *PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirect) SetHostName(v string) *PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirect {
	s.HostName = &v
	return s
}

func (s *PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirect) SetHttpRedirectCode(v string) *PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirect {
	s.HttpRedirectCode = &v
	return s
}

func (s *PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirect) SetReplaceKeyPrefixWith(v string) *PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirect {
	s.ReplaceKeyPrefixWith = &v
	return s
}

func (s *PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirect) SetReplaceKeyWith(v string) *PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirect {
	s.ReplaceKeyWith = &v
	return s
}

type PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeaders struct {
	// Set
	Set *PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeadersSet `json:"Set,omitempty" xml:"Set,omitempty" type:"Struct"`
	// PassAll
	PassAll *bool `json:"PassAll,omitempty" xml:"PassAll,omitempty"`
	// Pass
	Pass *string `json:"Pass,omitempty" xml:"Pass,omitempty"`
	// Remove
	Remove *string `json:"Remove,omitempty" xml:"Remove,omitempty"`
}

func (s PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeaders) String() string {
	return tea.Prettify(s)
}

func (s PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeaders) GoString() string {
	return s.String()
}

func (s *PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeaders) SetSet(v *PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeadersSet) *PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeaders {
	s.Set = v
	return s
}

func (s *PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeaders) SetPassAll(v bool) *PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeaders {
	s.PassAll = &v
	return s
}

func (s *PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeaders) SetPass(v string) *PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeaders {
	s.Pass = &v
	return s
}

func (s *PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeaders) SetRemove(v string) *PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeaders {
	s.Remove = &v
	return s
}

type PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeadersSet struct {
	// Key
	Key *string `json:"Key,omitempty" xml:"Key,omitempty"`
	// Value
	Value *string `json:"Value,omitempty" xml:"Value,omitempty"`
}

func (s PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeadersSet) String() string {
	return tea.Prettify(s)
}

func (s PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeadersSet) GoString() string {
	return s.String()
}

func (s *PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeadersSet) SetKey(v string) *PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeadersSet {
	s.Key = &v
	return s
}

func (s *PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeadersSet) SetValue(v string) *PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeadersSet {
	s.Value = &v
	return s
}

type PutBucketWebsiteResponse struct {
	// x-oss-request-id
	RequestId *string `json:"x-oss-request-id,omitempty" xml:"x-oss-request-id,omitempty" require:"true"`
}

func (s PutBucketWebsiteResponse) String() string {
	return tea.Prettify(s)
}

func (s PutBucketWebsiteResponse) GoString() string {
	return s.String()
}

func (s *PutBucketWebsiteResponse) SetRequestId(v string) *PutBucketWebsiteResponse {
	s.RequestId = &v
	return s
}

type CompleteMultipartUploadRequest struct {
	// BucketName
	BucketName *string `json:"BucketName,omitempty" xml:"BucketName,omitempty" require:"true" pattern:"[a-zA-Z0-9-_]+"`
	// ObjectName
	ObjectName *string `json:"ObjectName,omitempty" xml:"ObjectName,omitempty" require:"true"`
	// Filter
	Filter *CompleteMultipartUploadRequestFilter `json:"Filter,omitempty" xml:"Filter,omitempty" require:"true" type:"Struct"`
	// Body
	Body *CompleteMultipartUploadRequestBody `json:"Body,omitempty" xml:"Body,omitempty" type:"Struct"`
}

func (s CompleteMultipartUploadRequest) String() string {
	return tea.Prettify(s)
}

func (s CompleteMultipartUploadRequest) GoString() string {
	return s.String()
}

func (s *CompleteMultipartUploadRequest) SetBucketName(v string) *CompleteMultipartUploadRequest {
	s.BucketName = &v
	return s
}

func (s *CompleteMultipartUploadRequest) SetObjectName(v string) *CompleteMultipartUploadRequest {
	s.ObjectName = &v
	return s
}

func (s *CompleteMultipartUploadRequest) SetFilter(v *CompleteMultipartUploadRequestFilter) *CompleteMultipartUploadRequest {
	s.Filter = v
	return s
}

func (s *CompleteMultipartUploadRequest) SetBody(v *CompleteMultipartUploadRequestBody) *CompleteMultipartUploadRequest {
	s.Body = v
	return s
}

type CompleteMultipartUploadRequestFilter struct {
	// uploadId
	UploadId *string `json:"uploadId,omitempty" xml:"uploadId,omitempty" require:"true" signed:"true"`
	// Encoding-type
	EncodingType *string `json:"Encoding-type,omitempty" xml:"Encoding-type,omitempty"`
}

func (s CompleteMultipartUploadRequestFilter) String() string {
	return tea.Prettify(s)
}

func (s CompleteMultipartUploadRequestFilter) GoString() string {
	return s.String()
}

func (s *CompleteMultipartUploadRequestFilter) SetUploadId(v string) *CompleteMultipartUploadRequestFilter {
	s.UploadId = &v
	return s
}

func (s *CompleteMultipartUploadRequestFilter) SetEncodingType(v string) *CompleteMultipartUploadRequestFilter {
	s.EncodingType = &v
	return s
}

type CompleteMultipartUploadRequestBody struct {
	// CompleteMultipartUpload
	CompleteMultipartUpload *CompleteMultipartUploadRequestBodyCompleteMultipartUpload `json:"CompleteMultipartUpload,omitempty" xml:"CompleteMultipartUpload,omitempty" require:"true" type:"Struct"`
}

func (s CompleteMultipartUploadRequestBody) String() string {
	return tea.Prettify(s)
}

func (s CompleteMultipartUploadRequestBody) GoString() string {
	return s.String()
}

func (s *CompleteMultipartUploadRequestBody) SetCompleteMultipartUpload(v *CompleteMultipartUploadRequestBodyCompleteMultipartUpload) *CompleteMultipartUploadRequestBody {
	s.CompleteMultipartUpload = v
	return s
}

type CompleteMultipartUploadRequestBodyCompleteMultipartUpload struct {
	// Part
	Part []*CompleteMultipartUploadRequestBodyCompleteMultipartUploadPart `json:"Part,omitempty" xml:"Part,omitempty" type:"Repeated"`
}

func (s CompleteMultipartUploadRequestBodyCompleteMultipartUpload) String() string {
	return tea.Prettify(s)
}

func (s CompleteMultipartUploadRequestBodyCompleteMultipartUpload) GoString() string {
	return s.String()
}

func (s *CompleteMultipartUploadRequestBodyCompleteMultipartUpload) SetPart(v []*CompleteMultipartUploadRequestBodyCompleteMultipartUploadPart) *CompleteMultipartUploadRequestBodyCompleteMultipartUpload {
	s.Part = v
	return s
}

type CompleteMultipartUploadRequestBodyCompleteMultipartUploadPart struct {
	// PartNumber
	PartNumber *string `json:"PartNumber,omitempty" xml:"PartNumber,omitempty"`
	// ETag
	ETag *string `json:"ETag,omitempty" xml:"ETag,omitempty"`
}

func (s CompleteMultipartUploadRequestBodyCompleteMultipartUploadPart) String() string {
	return tea.Prettify(s)
}

func (s CompleteMultipartUploadRequestBodyCompleteMultipartUploadPart) GoString() string {
	return s.String()
}

func (s *CompleteMultipartUploadRequestBodyCompleteMultipartUploadPart) SetPartNumber(v string) *CompleteMultipartUploadRequestBodyCompleteMultipartUploadPart {
	s.PartNumber = &v
	return s
}

func (s *CompleteMultipartUploadRequestBodyCompleteMultipartUploadPart) SetETag(v string) *CompleteMultipartUploadRequestBodyCompleteMultipartUploadPart {
	s.ETag = &v
	return s
}

type CompleteMultipartUploadResponse struct {
	// x-oss-request-id
	RequestId *string `json:"x-oss-request-id,omitempty" xml:"x-oss-request-id,omitempty" require:"true"`
	// CompleteMultipartUploadResult
	CompleteMultipartUploadResult *CompleteMultipartUploadResponseCompleteMultipartUploadResult `json:"CompleteMultipartUploadResult,omitempty" xml:"CompleteMultipartUploadResult,omitempty" require:"true" type:"Struct"`
}

func (s CompleteMultipartUploadResponse) String() string {
	return tea.Prettify(s)
}

func (s CompleteMultipartUploadResponse) GoString() string {
	return s.String()
}

func (s *CompleteMultipartUploadResponse) SetRequestId(v string) *CompleteMultipartUploadResponse {
	s.RequestId = &v
	return s
}

func (s *CompleteMultipartUploadResponse) SetCompleteMultipartUploadResult(v *CompleteMultipartUploadResponseCompleteMultipartUploadResult) *CompleteMultipartUploadResponse {
	s.CompleteMultipartUploadResult = v
	return s
}

type CompleteMultipartUploadResponseCompleteMultipartUploadResult struct {
	// Bucket
	Bucket *string `json:"Bucket,omitempty" xml:"Bucket,omitempty"`
	// ETag
	ETag *string `json:"ETag,omitempty" xml:"ETag,omitempty"`
	// Location
	Location *string `json:"Location,omitempty" xml:"Location,omitempty"`
	// Key
	Key *string `json:"Key,omitempty" xml:"Key,omitempty"`
	// EncodingType
	EncodingType *string `json:"EncodingType,omitempty" xml:"EncodingType,omitempty"`
}

func (s CompleteMultipartUploadResponseCompleteMultipartUploadResult) String() string {
	return tea.Prettify(s)
}

func (s CompleteMultipartUploadResponseCompleteMultipartUploadResult) GoString() string {
	return s.String()
}

func (s *CompleteMultipartUploadResponseCompleteMultipartUploadResult) SetBucket(v string) *CompleteMultipartUploadResponseCompleteMultipartUploadResult {
	s.Bucket = &v
	return s
}

func (s *CompleteMultipartUploadResponseCompleteMultipartUploadResult) SetETag(v string) *CompleteMultipartUploadResponseCompleteMultipartUploadResult {
	s.ETag = &v
	return s
}

func (s *CompleteMultipartUploadResponseCompleteMultipartUploadResult) SetLocation(v string) *CompleteMultipartUploadResponseCompleteMultipartUploadResult {
	s.Location = &v
	return s
}

func (s *CompleteMultipartUploadResponseCompleteMultipartUploadResult) SetKey(v string) *CompleteMultipartUploadResponseCompleteMultipartUploadResult {
	s.Key = &v
	return s
}

func (s *CompleteMultipartUploadResponseCompleteMultipartUploadResult) SetEncodingType(v string) *CompleteMultipartUploadResponseCompleteMultipartUploadResult {
	s.EncodingType = &v
	return s
}

type PutBucketLoggingRequest struct {
	// BucketName
	BucketName *string `json:"BucketName,omitempty" xml:"BucketName,omitempty" require:"true" pattern:"[a-zA-Z0-9-_]+"`
	// Body
	Body *PutBucketLoggingRequestBody `json:"Body,omitempty" xml:"Body,omitempty" type:"Struct"`
}

func (s PutBucketLoggingRequest) String() string {
	return tea.Prettify(s)
}

func (s PutBucketLoggingRequest) GoString() string {
	return s.String()
}

func (s *PutBucketLoggingRequest) SetBucketName(v string) *PutBucketLoggingRequest {
	s.BucketName = &v
	return s
}

func (s *PutBucketLoggingRequest) SetBody(v *PutBucketLoggingRequestBody) *PutBucketLoggingRequest {
	s.Body = v
	return s
}

type PutBucketLoggingRequestBody struct {
	// BucketLoggingStatus
	BucketLoggingStatus *PutBucketLoggingRequestBodyBucketLoggingStatus `json:"BucketLoggingStatus,omitempty" xml:"BucketLoggingStatus,omitempty" require:"true" type:"Struct"`
}

func (s PutBucketLoggingRequestBody) String() string {
	return tea.Prettify(s)
}

func (s PutBucketLoggingRequestBody) GoString() string {
	return s.String()
}

func (s *PutBucketLoggingRequestBody) SetBucketLoggingStatus(v *PutBucketLoggingRequestBodyBucketLoggingStatus) *PutBucketLoggingRequestBody {
	s.BucketLoggingStatus = v
	return s
}

type PutBucketLoggingRequestBodyBucketLoggingStatus struct {
	// LoggingEnabled
	LoggingEnabled *PutBucketLoggingRequestBodyBucketLoggingStatusLoggingEnabled `json:"LoggingEnabled,omitempty" xml:"LoggingEnabled,omitempty" type:"Struct"`
}

func (s PutBucketLoggingRequestBodyBucketLoggingStatus) String() string {
	return tea.Prettify(s)
}

func (s PutBucketLoggingRequestBodyBucketLoggingStatus) GoString() string {
	return s.String()
}

func (s *PutBucketLoggingRequestBodyBucketLoggingStatus) SetLoggingEnabled(v *PutBucketLoggingRequestBodyBucketLoggingStatusLoggingEnabled) *PutBucketLoggingRequestBodyBucketLoggingStatus {
	s.LoggingEnabled = v
	return s
}

type PutBucketLoggingRequestBodyBucketLoggingStatusLoggingEnabled struct {
	// TargetBucket
	TargetBucket *string `json:"TargetBucket,omitempty" xml:"TargetBucket,omitempty"`
	// TargetPrefix
	TargetPrefix *string `json:"TargetPrefix,omitempty" xml:"TargetPrefix,omitempty"`
}

func (s PutBucketLoggingRequestBodyBucketLoggingStatusLoggingEnabled) String() string {
	return tea.Prettify(s)
}

func (s PutBucketLoggingRequestBodyBucketLoggingStatusLoggingEnabled) GoString() string {
	return s.String()
}

func (s *PutBucketLoggingRequestBodyBucketLoggingStatusLoggingEnabled) SetTargetBucket(v string) *PutBucketLoggingRequestBodyBucketLoggingStatusLoggingEnabled {
	s.TargetBucket = &v
	return s
}

func (s *PutBucketLoggingRequestBodyBucketLoggingStatusLoggingEnabled) SetTargetPrefix(v string) *PutBucketLoggingRequestBodyBucketLoggingStatusLoggingEnabled {
	s.TargetPrefix = &v
	return s
}

type PutBucketLoggingResponse struct {
	// x-oss-request-id
	RequestId *string `json:"x-oss-request-id,omitempty" xml:"x-oss-request-id,omitempty" require:"true"`
}

func (s PutBucketLoggingResponse) String() string {
	return tea.Prettify(s)
}

func (s PutBucketLoggingResponse) GoString() string {
	return s.String()
}

func (s *PutBucketLoggingResponse) SetRequestId(v string) *PutBucketLoggingResponse {
	s.RequestId = &v
	return s
}

type PutBucketRequestPaymentRequest struct {
	// BucketName
	BucketName *string `json:"BucketName,omitempty" xml:"BucketName,omitempty" require:"true" pattern:"[a-zA-Z0-9-_]+"`
	// Body
	Body *PutBucketRequestPaymentRequestBody `json:"Body,omitempty" xml:"Body,omitempty" type:"Struct"`
}

func (s PutBucketRequestPaymentRequest) String() string {
	return tea.Prettify(s)
}

func (s PutBucketRequestPaymentRequest) GoString() string {
	return s.String()
}

func (s *PutBucketRequestPaymentRequest) SetBucketName(v string) *PutBucketRequestPaymentRequest {
	s.BucketName = &v
	return s
}

func (s *PutBucketRequestPaymentRequest) SetBody(v *PutBucketRequestPaymentRequestBody) *PutBucketRequestPaymentRequest {
	s.Body = v
	return s
}

type PutBucketRequestPaymentRequestBody struct {
	// RequestPaymentConfiguration
	RequestPaymentConfiguration *PutBucketRequestPaymentRequestBodyRequestPaymentConfiguration `json:"RequestPaymentConfiguration,omitempty" xml:"RequestPaymentConfiguration,omitempty" require:"true" type:"Struct"`
}

func (s PutBucketRequestPaymentRequestBody) String() string {
	return tea.Prettify(s)
}

func (s PutBucketRequestPaymentRequestBody) GoString() string {
	return s.String()
}

func (s *PutBucketRequestPaymentRequestBody) SetRequestPaymentConfiguration(v *PutBucketRequestPaymentRequestBodyRequestPaymentConfiguration) *PutBucketRequestPaymentRequestBody {
	s.RequestPaymentConfiguration = v
	return s
}

type PutBucketRequestPaymentRequestBodyRequestPaymentConfiguration struct {
	// Payer
	Payer *string `json:"Payer,omitempty" xml:"Payer,omitempty"`
}

func (s PutBucketRequestPaymentRequestBodyRequestPaymentConfiguration) String() string {
	return tea.Prettify(s)
}

func (s PutBucketRequestPaymentRequestBodyRequestPaymentConfiguration) GoString() string {
	return s.String()
}

func (s *PutBucketRequestPaymentRequestBodyRequestPaymentConfiguration) SetPayer(v string) *PutBucketRequestPaymentRequestBodyRequestPaymentConfiguration {
	s.Payer = &v
	return s
}

type PutBucketRequestPaymentResponse struct {
	// x-oss-request-id
	RequestId *string `json:"x-oss-request-id,omitempty" xml:"x-oss-request-id,omitempty" require:"true"`
}

func (s PutBucketRequestPaymentResponse) String() string {
	return tea.Prettify(s)
}

func (s PutBucketRequestPaymentResponse) GoString() string {
	return s.String()
}

func (s *PutBucketRequestPaymentResponse) SetRequestId(v string) *PutBucketRequestPaymentResponse {
	s.RequestId = &v
	return s
}

type PutBucketEncryptionRequest struct {
	// BucketName
	BucketName *string `json:"BucketName,omitempty" xml:"BucketName,omitempty" require:"true" pattern:"[a-zA-Z0-9-_]+"`
	// Body
	Body *PutBucketEncryptionRequestBody `json:"Body,omitempty" xml:"Body,omitempty" type:"Struct"`
}

func (s PutBucketEncryptionRequest) String() string {
	return tea.Prettify(s)
}

func (s PutBucketEncryptionRequest) GoString() string {
	return s.String()
}

func (s *PutBucketEncryptionRequest) SetBucketName(v string) *PutBucketEncryptionRequest {
	s.BucketName = &v
	return s
}

func (s *PutBucketEncryptionRequest) SetBody(v *PutBucketEncryptionRequestBody) *PutBucketEncryptionRequest {
	s.Body = v
	return s
}

type PutBucketEncryptionRequestBody struct {
	// ServerSideEncryptionRule
	ServerSideEncryptionRule *PutBucketEncryptionRequestBodyServerSideEncryptionRule `json:"ServerSideEncryptionRule,omitempty" xml:"ServerSideEncryptionRule,omitempty" require:"true" type:"Struct"`
}

func (s PutBucketEncryptionRequestBody) String() string {
	return tea.Prettify(s)
}

func (s PutBucketEncryptionRequestBody) GoString() string {
	return s.String()
}

func (s *PutBucketEncryptionRequestBody) SetServerSideEncryptionRule(v *PutBucketEncryptionRequestBodyServerSideEncryptionRule) *PutBucketEncryptionRequestBody {
	s.ServerSideEncryptionRule = v
	return s
}

type PutBucketEncryptionRequestBodyServerSideEncryptionRule struct {
	// ApplyServerSideEncryptionByDefault
	ApplyServerSideEncryptionByDefault *PutBucketEncryptionRequestBodyServerSideEncryptionRuleApplyServerSideEncryptionByDefault `json:"ApplyServerSideEncryptionByDefault,omitempty" xml:"ApplyServerSideEncryptionByDefault,omitempty" type:"Struct"`
}

func (s PutBucketEncryptionRequestBodyServerSideEncryptionRule) String() string {
	return tea.Prettify(s)
}

func (s PutBucketEncryptionRequestBodyServerSideEncryptionRule) GoString() string {
	return s.String()
}

func (s *PutBucketEncryptionRequestBodyServerSideEncryptionRule) SetApplyServerSideEncryptionByDefault(v *PutBucketEncryptionRequestBodyServerSideEncryptionRuleApplyServerSideEncryptionByDefault) *PutBucketEncryptionRequestBodyServerSideEncryptionRule {
	s.ApplyServerSideEncryptionByDefault = v
	return s
}

type PutBucketEncryptionRequestBodyServerSideEncryptionRuleApplyServerSideEncryptionByDefault struct {
	// SSEAlgorithm
	SSEAlgorithm *string `json:"SSEAlgorithm,omitempty" xml:"SSEAlgorithm,omitempty"`
	// KMSMasterKeyID
	KMSMasterKeyID *string `json:"KMSMasterKeyID,omitempty" xml:"KMSMasterKeyID,omitempty"`
}

func (s PutBucketEncryptionRequestBodyServerSideEncryptionRuleApplyServerSideEncryptionByDefault) String() string {
	return tea.Prettify(s)
}

func (s PutBucketEncryptionRequestBodyServerSideEncryptionRuleApplyServerSideEncryptionByDefault) GoString() string {
	return s.String()
}

func (s *PutBucketEncryptionRequestBodyServerSideEncryptionRuleApplyServerSideEncryptionByDefault) SetSSEAlgorithm(v string) *PutBucketEncryptionRequestBodyServerSideEncryptionRuleApplyServerSideEncryptionByDefault {
	s.SSEAlgorithm = &v
	return s
}

func (s *PutBucketEncryptionRequestBodyServerSideEncryptionRuleApplyServerSideEncryptionByDefault) SetKMSMasterKeyID(v string) *PutBucketEncryptionRequestBodyServerSideEncryptionRuleApplyServerSideEncryptionByDefault {
	s.KMSMasterKeyID = &v
	return s
}

type PutBucketEncryptionResponse struct {
	// x-oss-request-id
	RequestId *string `json:"x-oss-request-id,omitempty" xml:"x-oss-request-id,omitempty" require:"true"`
}

func (s PutBucketEncryptionResponse) String() string {
	return tea.Prettify(s)
}

func (s PutBucketEncryptionResponse) GoString() string {
	return s.String()
}

func (s *PutBucketEncryptionResponse) SetRequestId(v string) *PutBucketEncryptionResponse {
	s.RequestId = &v
	return s
}

type PutLiveChannelRequest struct {
	// BucketName
	BucketName *string `json:"BucketName,omitempty" xml:"BucketName,omitempty" require:"true" pattern:"[a-zA-Z0-9-_]+"`
	// ChannelName
	ChannelName *string `json:"ChannelName,omitempty" xml:"ChannelName,omitempty" require:"true"`
	// Body
	Body *PutLiveChannelRequestBody `json:"Body,omitempty" xml:"Body,omitempty" type:"Struct"`
}

func (s PutLiveChannelRequest) String() string {
	return tea.Prettify(s)
}

func (s PutLiveChannelRequest) GoString() string {
	return s.String()
}

func (s *PutLiveChannelRequest) SetBucketName(v string) *PutLiveChannelRequest {
	s.BucketName = &v
	return s
}

func (s *PutLiveChannelRequest) SetChannelName(v string) *PutLiveChannelRequest {
	s.ChannelName = &v
	return s
}

func (s *PutLiveChannelRequest) SetBody(v *PutLiveChannelRequestBody) *PutLiveChannelRequest {
	s.Body = v
	return s
}

type PutLiveChannelRequestBody struct {
	// LiveChannelConfiguration
	LiveChannelConfiguration *PutLiveChannelRequestBodyLiveChannelConfiguration `json:"LiveChannelConfiguration,omitempty" xml:"LiveChannelConfiguration,omitempty" require:"true" type:"Struct"`
}

func (s PutLiveChannelRequestBody) String() string {
	return tea.Prettify(s)
}

func (s PutLiveChannelRequestBody) GoString() string {
	return s.String()
}

func (s *PutLiveChannelRequestBody) SetLiveChannelConfiguration(v *PutLiveChannelRequestBodyLiveChannelConfiguration) *PutLiveChannelRequestBody {
	s.LiveChannelConfiguration = v
	return s
}

type PutLiveChannelRequestBodyLiveChannelConfiguration struct {
	// Target
	Target *PutLiveChannelRequestBodyLiveChannelConfigurationTarget `json:"Target,omitempty" xml:"Target,omitempty" type:"Struct"`
	// Snapshot
	Snapshot *PutLiveChannelRequestBodyLiveChannelConfigurationSnapshot `json:"Snapshot,omitempty" xml:"Snapshot,omitempty" type:"Struct"`
	// Description
	Description *string `json:"Description,omitempty" xml:"Description,omitempty"`
	// Status
	Status *string `json:"Status,omitempty" xml:"Status,omitempty"`
}

func (s PutLiveChannelRequestBodyLiveChannelConfiguration) String() string {
	return tea.Prettify(s)
}

func (s PutLiveChannelRequestBodyLiveChannelConfiguration) GoString() string {
	return s.String()
}

func (s *PutLiveChannelRequestBodyLiveChannelConfiguration) SetTarget(v *PutLiveChannelRequestBodyLiveChannelConfigurationTarget) *PutLiveChannelRequestBodyLiveChannelConfiguration {
	s.Target = v
	return s
}

func (s *PutLiveChannelRequestBodyLiveChannelConfiguration) SetSnapshot(v *PutLiveChannelRequestBodyLiveChannelConfigurationSnapshot) *PutLiveChannelRequestBodyLiveChannelConfiguration {
	s.Snapshot = v
	return s
}

func (s *PutLiveChannelRequestBodyLiveChannelConfiguration) SetDescription(v string) *PutLiveChannelRequestBodyLiveChannelConfiguration {
	s.Description = &v
	return s
}

func (s *PutLiveChannelRequestBodyLiveChannelConfiguration) SetStatus(v string) *PutLiveChannelRequestBodyLiveChannelConfiguration {
	s.Status = &v
	return s
}

type PutLiveChannelRequestBodyLiveChannelConfigurationTarget struct {
	// Type
	Type *string `json:"Type,omitempty" xml:"Type,omitempty"`
	// FragDuration
	FragDuration *string `json:"FragDuration,omitempty" xml:"FragDuration,omitempty"`
	// FragCount
	FragCount *string `json:"FragCount,omitempty" xml:"FragCount,omitempty"`
	// PlaylistName
	PlaylistName *string `json:"PlaylistName,omitempty" xml:"PlaylistName,omitempty"`
}

func (s PutLiveChannelRequestBodyLiveChannelConfigurationTarget) String() string {
	return tea.Prettify(s)
}

func (s PutLiveChannelRequestBodyLiveChannelConfigurationTarget) GoString() string {
	return s.String()
}

func (s *PutLiveChannelRequestBodyLiveChannelConfigurationTarget) SetType(v string) *PutLiveChannelRequestBodyLiveChannelConfigurationTarget {
	s.Type = &v
	return s
}

func (s *PutLiveChannelRequestBodyLiveChannelConfigurationTarget) SetFragDuration(v string) *PutLiveChannelRequestBodyLiveChannelConfigurationTarget {
	s.FragDuration = &v
	return s
}

func (s *PutLiveChannelRequestBodyLiveChannelConfigurationTarget) SetFragCount(v string) *PutLiveChannelRequestBodyLiveChannelConfigurationTarget {
	s.FragCount = &v
	return s
}

func (s *PutLiveChannelRequestBodyLiveChannelConfigurationTarget) SetPlaylistName(v string) *PutLiveChannelRequestBodyLiveChannelConfigurationTarget {
	s.PlaylistName = &v
	return s
}

type PutLiveChannelRequestBodyLiveChannelConfigurationSnapshot struct {
	// RoleName
	RoleName *string `json:"RoleName,omitempty" xml:"RoleName,omitempty"`
	// DestBucket
	DestBucket *string `json:"DestBucket,omitempty" xml:"DestBucket,omitempty"`
	// NotifyTopic
	NotifyTopic *string `json:"NotifyTopic,omitempty" xml:"NotifyTopic,omitempty"`
	// Interval
	Interval *string `json:"Interval,omitempty" xml:"Interval,omitempty"`
}

func (s PutLiveChannelRequestBodyLiveChannelConfigurationSnapshot) String() string {
	return tea.Prettify(s)
}

func (s PutLiveChannelRequestBodyLiveChannelConfigurationSnapshot) GoString() string {
	return s.String()
}

func (s *PutLiveChannelRequestBodyLiveChannelConfigurationSnapshot) SetRoleName(v string) *PutLiveChannelRequestBodyLiveChannelConfigurationSnapshot {
	s.RoleName = &v
	return s
}

func (s *PutLiveChannelRequestBodyLiveChannelConfigurationSnapshot) SetDestBucket(v string) *PutLiveChannelRequestBodyLiveChannelConfigurationSnapshot {
	s.DestBucket = &v
	return s
}

func (s *PutLiveChannelRequestBodyLiveChannelConfigurationSnapshot) SetNotifyTopic(v string) *PutLiveChannelRequestBodyLiveChannelConfigurationSnapshot {
	s.NotifyTopic = &v
	return s
}

func (s *PutLiveChannelRequestBodyLiveChannelConfigurationSnapshot) SetInterval(v string) *PutLiveChannelRequestBodyLiveChannelConfigurationSnapshot {
	s.Interval = &v
	return s
}

type PutLiveChannelResponse struct {
	// x-oss-request-id
	RequestId *string `json:"x-oss-request-id,omitempty" xml:"x-oss-request-id,omitempty" require:"true"`
	// CreateLiveChannelResult
	CreateLiveChannelResult *PutLiveChannelResponseCreateLiveChannelResult `json:"CreateLiveChannelResult,omitempty" xml:"CreateLiveChannelResult,omitempty" require:"true" type:"Struct"`
}

func (s PutLiveChannelResponse) String() string {
	return tea.Prettify(s)
}

func (s PutLiveChannelResponse) GoString() string {
	return s.String()
}

func (s *PutLiveChannelResponse) SetRequestId(v string) *PutLiveChannelResponse {
	s.RequestId = &v
	return s
}

func (s *PutLiveChannelResponse) SetCreateLiveChannelResult(v *PutLiveChannelResponseCreateLiveChannelResult) *PutLiveChannelResponse {
	s.CreateLiveChannelResult = v
	return s
}

type PutLiveChannelResponseCreateLiveChannelResult struct {
	// PublishUrls
	PublishUrls *PutLiveChannelResponseCreateLiveChannelResultPublishUrls `json:"PublishUrls,omitempty" xml:"PublishUrls,omitempty" require:"true" type:"Struct"`
	// PlayUrls
	PlayUrls *PutLiveChannelResponseCreateLiveChannelResultPlayUrls `json:"PlayUrls,omitempty" xml:"PlayUrls,omitempty" require:"true" type:"Struct"`
}

func (s PutLiveChannelResponseCreateLiveChannelResult) String() string {
	return tea.Prettify(s)
}

func (s PutLiveChannelResponseCreateLiveChannelResult) GoString() string {
	return s.String()
}

func (s *PutLiveChannelResponseCreateLiveChannelResult) SetPublishUrls(v *PutLiveChannelResponseCreateLiveChannelResultPublishUrls) *PutLiveChannelResponseCreateLiveChannelResult {
	s.PublishUrls = v
	return s
}

func (s *PutLiveChannelResponseCreateLiveChannelResult) SetPlayUrls(v *PutLiveChannelResponseCreateLiveChannelResultPlayUrls) *PutLiveChannelResponseCreateLiveChannelResult {
	s.PlayUrls = v
	return s
}

type PutLiveChannelResponseCreateLiveChannelResultPublishUrls struct {
	// Url
	Url *string `json:"Url,omitempty" xml:"Url,omitempty"`
}

func (s PutLiveChannelResponseCreateLiveChannelResultPublishUrls) String() string {
	return tea.Prettify(s)
}

func (s PutLiveChannelResponseCreateLiveChannelResultPublishUrls) GoString() string {
	return s.String()
}

func (s *PutLiveChannelResponseCreateLiveChannelResultPublishUrls) SetUrl(v string) *PutLiveChannelResponseCreateLiveChannelResultPublishUrls {
	s.Url = &v
	return s
}

type PutLiveChannelResponseCreateLiveChannelResultPlayUrls struct {
	// Url
	Url *string `json:"Url,omitempty" xml:"Url,omitempty"`
}

func (s PutLiveChannelResponseCreateLiveChannelResultPlayUrls) String() string {
	return tea.Prettify(s)
}

func (s PutLiveChannelResponseCreateLiveChannelResultPlayUrls) GoString() string {
	return s.String()
}

func (s *PutLiveChannelResponseCreateLiveChannelResultPlayUrls) SetUrl(v string) *PutLiveChannelResponseCreateLiveChannelResultPlayUrls {
	s.Url = &v
	return s
}

type PutBucketTagsRequest struct {
	// BucketName
	BucketName *string `json:"BucketName,omitempty" xml:"BucketName,omitempty" require:"true" pattern:"[a-zA-Z0-9-_]+"`
	// Body
	Body *PutBucketTagsRequestBody `json:"Body,omitempty" xml:"Body,omitempty" type:"Struct"`
}

func (s PutBucketTagsRequest) String() string {
	return tea.Prettify(s)
}

func (s PutBucketTagsRequest) GoString() string {
	return s.String()
}

func (s *PutBucketTagsRequest) SetBucketName(v string) *PutBucketTagsRequest {
	s.BucketName = &v
	return s
}

func (s *PutBucketTagsRequest) SetBody(v *PutBucketTagsRequestBody) *PutBucketTagsRequest {
	s.Body = v
	return s
}

type PutBucketTagsRequestBody struct {
	// Tagging
	Tagging *PutBucketTagsRequestBodyTagging `json:"Tagging,omitempty" xml:"Tagging,omitempty" require:"true" type:"Struct"`
}

func (s PutBucketTagsRequestBody) String() string {
	return tea.Prettify(s)
}

func (s PutBucketTagsRequestBody) GoString() string {
	return s.String()
}

func (s *PutBucketTagsRequestBody) SetTagging(v *PutBucketTagsRequestBodyTagging) *PutBucketTagsRequestBody {
	s.Tagging = v
	return s
}

type PutBucketTagsRequestBodyTagging struct {
	// TagSet
	TagSet *PutBucketTagsRequestBodyTaggingTagSet `json:"TagSet,omitempty" xml:"TagSet,omitempty" type:"Struct"`
}

func (s PutBucketTagsRequestBodyTagging) String() string {
	return tea.Prettify(s)
}

func (s PutBucketTagsRequestBodyTagging) GoString() string {
	return s.String()
}

func (s *PutBucketTagsRequestBodyTagging) SetTagSet(v *PutBucketTagsRequestBodyTaggingTagSet) *PutBucketTagsRequestBodyTagging {
	s.TagSet = v
	return s
}

type PutBucketTagsRequestBodyTaggingTagSet struct {
	// Tag
	Tag []*PutBucketTagsRequestBodyTaggingTagSetTag `json:"Tag,omitempty" xml:"Tag,omitempty" type:"Repeated"`
}

func (s PutBucketTagsRequestBodyTaggingTagSet) String() string {
	return tea.Prettify(s)
}

func (s PutBucketTagsRequestBodyTaggingTagSet) GoString() string {
	return s.String()
}

func (s *PutBucketTagsRequestBodyTaggingTagSet) SetTag(v []*PutBucketTagsRequestBodyTaggingTagSetTag) *PutBucketTagsRequestBodyTaggingTagSet {
	s.Tag = v
	return s
}

type PutBucketTagsRequestBodyTaggingTagSetTag struct {
	// Key
	Key *string `json:"Key,omitempty" xml:"Key,omitempty"`
	// Value
	Value *string `json:"Value,omitempty" xml:"Value,omitempty"`
}

func (s PutBucketTagsRequestBodyTaggingTagSetTag) String() string {
	return tea.Prettify(s)
}

func (s PutBucketTagsRequestBodyTaggingTagSetTag) GoString() string {
	return s.String()
}

func (s *PutBucketTagsRequestBodyTaggingTagSetTag) SetKey(v string) *PutBucketTagsRequestBodyTaggingTagSetTag {
	s.Key = &v
	return s
}

func (s *PutBucketTagsRequestBodyTaggingTagSetTag) SetValue(v string) *PutBucketTagsRequestBodyTaggingTagSetTag {
	s.Value = &v
	return s
}

type PutBucketTagsResponse struct {
	// x-oss-request-id
	RequestId *string `json:"x-oss-request-id,omitempty" xml:"x-oss-request-id,omitempty" require:"true"`
}

func (s PutBucketTagsResponse) String() string {
	return tea.Prettify(s)
}

func (s PutBucketTagsResponse) GoString() string {
	return s.String()
}

func (s *PutBucketTagsResponse) SetRequestId(v string) *PutBucketTagsResponse {
	s.RequestId = &v
	return s
}

type PutObjectTaggingRequest struct {
	// BucketName
	BucketName *string `json:"BucketName,omitempty" xml:"BucketName,omitempty" require:"true" pattern:"[a-zA-Z0-9-_]+"`
	// ObjectName
	ObjectName *string `json:"ObjectName,omitempty" xml:"ObjectName,omitempty" require:"true"`
	// Body
	Body *PutObjectTaggingRequestBody `json:"Body,omitempty" xml:"Body,omitempty" type:"Struct"`
}

func (s PutObjectTaggingRequest) String() string {
	return tea.Prettify(s)
}

func (s PutObjectTaggingRequest) GoString() string {
	return s.String()
}

func (s *PutObjectTaggingRequest) SetBucketName(v string) *PutObjectTaggingRequest {
	s.BucketName = &v
	return s
}

func (s *PutObjectTaggingRequest) SetObjectName(v string) *PutObjectTaggingRequest {
	s.ObjectName = &v
	return s
}

func (s *PutObjectTaggingRequest) SetBody(v *PutObjectTaggingRequestBody) *PutObjectTaggingRequest {
	s.Body = v
	return s
}

type PutObjectTaggingRequestBody struct {
	// Tagging
	Tagging *PutObjectTaggingRequestBodyTagging `json:"Tagging,omitempty" xml:"Tagging,omitempty" require:"true" type:"Struct"`
}

func (s PutObjectTaggingRequestBody) String() string {
	return tea.Prettify(s)
}

func (s PutObjectTaggingRequestBody) GoString() string {
	return s.String()
}

func (s *PutObjectTaggingRequestBody) SetTagging(v *PutObjectTaggingRequestBodyTagging) *PutObjectTaggingRequestBody {
	s.Tagging = v
	return s
}

type PutObjectTaggingRequestBodyTagging struct {
	// TagSet
	TagSet *PutObjectTaggingRequestBodyTaggingTagSet `json:"TagSet,omitempty" xml:"TagSet,omitempty" type:"Struct"`
}

func (s PutObjectTaggingRequestBodyTagging) String() string {
	return tea.Prettify(s)
}

func (s PutObjectTaggingRequestBodyTagging) GoString() string {
	return s.String()
}

func (s *PutObjectTaggingRequestBodyTagging) SetTagSet(v *PutObjectTaggingRequestBodyTaggingTagSet) *PutObjectTaggingRequestBodyTagging {
	s.TagSet = v
	return s
}

type PutObjectTaggingRequestBodyTaggingTagSet struct {
	// Tag
	Tag []*PutObjectTaggingRequestBodyTaggingTagSetTag `json:"Tag,omitempty" xml:"Tag,omitempty" type:"Repeated"`
}

func (s PutObjectTaggingRequestBodyTaggingTagSet) String() string {
	return tea.Prettify(s)
}

func (s PutObjectTaggingRequestBodyTaggingTagSet) GoString() string {
	return s.String()
}

func (s *PutObjectTaggingRequestBodyTaggingTagSet) SetTag(v []*PutObjectTaggingRequestBodyTaggingTagSetTag) *PutObjectTaggingRequestBodyTaggingTagSet {
	s.Tag = v
	return s
}

type PutObjectTaggingRequestBodyTaggingTagSetTag struct {
	// Key
	Key *string `json:"Key,omitempty" xml:"Key,omitempty"`
	// Value
	Value *string `json:"Value,omitempty" xml:"Value,omitempty"`
}

func (s PutObjectTaggingRequestBodyTaggingTagSetTag) String() string {
	return tea.Prettify(s)
}

func (s PutObjectTaggingRequestBodyTaggingTagSetTag) GoString() string {
	return s.String()
}

func (s *PutObjectTaggingRequestBodyTaggingTagSetTag) SetKey(v string) *PutObjectTaggingRequestBodyTaggingTagSetTag {
	s.Key = &v
	return s
}

func (s *PutObjectTaggingRequestBodyTaggingTagSetTag) SetValue(v string) *PutObjectTaggingRequestBodyTaggingTagSetTag {
	s.Value = &v
	return s
}

type PutObjectTaggingResponse struct {
	// x-oss-request-id
	RequestId *string `json:"x-oss-request-id,omitempty" xml:"x-oss-request-id,omitempty" require:"true"`
}

func (s PutObjectTaggingResponse) String() string {
	return tea.Prettify(s)
}

func (s PutObjectTaggingResponse) GoString() string {
	return s.String()
}

func (s *PutObjectTaggingResponse) SetRequestId(v string) *PutObjectTaggingResponse {
	s.RequestId = &v
	return s
}

type SelectObjectRequest struct {
	// BucketName
	BucketName *string `json:"BucketName,omitempty" xml:"BucketName,omitempty" require:"true" pattern:"[a-zA-Z0-9-_]+"`
	// ObjectName
	ObjectName *string `json:"ObjectName,omitempty" xml:"ObjectName,omitempty" require:"true"`
	// Filter
	Filter *SelectObjectRequestFilter `json:"Filter,omitempty" xml:"Filter,omitempty" require:"true" type:"Struct"`
	// Body
	Body *SelectObjectRequestBody `json:"Body,omitempty" xml:"Body,omitempty" type:"Struct"`
}

func (s SelectObjectRequest) String() string {
	return tea.Prettify(s)
}

func (s SelectObjectRequest) GoString() string {
	return s.String()
}

func (s *SelectObjectRequest) SetBucketName(v string) *SelectObjectRequest {
	s.BucketName = &v
	return s
}

func (s *SelectObjectRequest) SetObjectName(v string) *SelectObjectRequest {
	s.ObjectName = &v
	return s
}

func (s *SelectObjectRequest) SetFilter(v *SelectObjectRequestFilter) *SelectObjectRequest {
	s.Filter = v
	return s
}

func (s *SelectObjectRequest) SetBody(v *SelectObjectRequestBody) *SelectObjectRequest {
	s.Body = v
	return s
}

type SelectObjectRequestFilter struct {
	// x-oss-process
	Porcess *string `json:"x-oss-process,omitempty" xml:"x-oss-process,omitempty" require:"true"`
}

func (s SelectObjectRequestFilter) String() string {
	return tea.Prettify(s)
}

func (s SelectObjectRequestFilter) GoString() string {
	return s.String()
}

func (s *SelectObjectRequestFilter) SetPorcess(v string) *SelectObjectRequestFilter {
	s.Porcess = &v
	return s
}

type SelectObjectRequestBody struct {
	// SelectRequest
	SelectRequest *SelectObjectRequestBodySelectRequest `json:"SelectRequest,omitempty" xml:"SelectRequest,omitempty" require:"true" type:"Struct"`
}

func (s SelectObjectRequestBody) String() string {
	return tea.Prettify(s)
}

func (s SelectObjectRequestBody) GoString() string {
	return s.String()
}

func (s *SelectObjectRequestBody) SetSelectRequest(v *SelectObjectRequestBodySelectRequest) *SelectObjectRequestBody {
	s.SelectRequest = v
	return s
}

type SelectObjectRequestBodySelectRequest struct {
	// InputSerialization
	InputSerialization *SelectObjectRequestBodySelectRequestInputSerialization `json:"InputSerialization,omitempty" xml:"InputSerialization,omitempty" type:"Struct"`
	// OutputSerialization
	OutputSerialization *SelectObjectRequestBodySelectRequestOutputSerialization `json:"OutputSerialization,omitempty" xml:"OutputSerialization,omitempty" type:"Struct"`
	// Options
	Options *SelectObjectRequestBodySelectRequestOptions `json:"Options,omitempty" xml:"Options,omitempty" type:"Struct"`
	// Expression
	Expression *string `json:"Expression,omitempty" xml:"Expression,omitempty"`
}

func (s SelectObjectRequestBodySelectRequest) String() string {
	return tea.Prettify(s)
}

func (s SelectObjectRequestBodySelectRequest) GoString() string {
	return s.String()
}

func (s *SelectObjectRequestBodySelectRequest) SetInputSerialization(v *SelectObjectRequestBodySelectRequestInputSerialization) *SelectObjectRequestBodySelectRequest {
	s.InputSerialization = v
	return s
}

func (s *SelectObjectRequestBodySelectRequest) SetOutputSerialization(v *SelectObjectRequestBodySelectRequestOutputSerialization) *SelectObjectRequestBodySelectRequest {
	s.OutputSerialization = v
	return s
}

func (s *SelectObjectRequestBodySelectRequest) SetOptions(v *SelectObjectRequestBodySelectRequestOptions) *SelectObjectRequestBodySelectRequest {
	s.Options = v
	return s
}

func (s *SelectObjectRequestBodySelectRequest) SetExpression(v string) *SelectObjectRequestBodySelectRequest {
	s.Expression = &v
	return s
}

type SelectObjectRequestBodySelectRequestInputSerialization struct {
	// CSV
	CSV *SelectObjectRequestBodySelectRequestInputSerializationCSV `json:"CSV,omitempty" xml:"CSV,omitempty" type:"Struct"`
	// CompressionType
	CompressionType *string `json:"CompressionType,omitempty" xml:"CompressionType,omitempty"`
}

func (s SelectObjectRequestBodySelectRequestInputSerialization) String() string {
	return tea.Prettify(s)
}

func (s SelectObjectRequestBodySelectRequestInputSerialization) GoString() string {
	return s.String()
}

func (s *SelectObjectRequestBodySelectRequestInputSerialization) SetCSV(v *SelectObjectRequestBodySelectRequestInputSerializationCSV) *SelectObjectRequestBodySelectRequestInputSerialization {
	s.CSV = v
	return s
}

func (s *SelectObjectRequestBodySelectRequestInputSerialization) SetCompressionType(v string) *SelectObjectRequestBodySelectRequestInputSerialization {
	s.CompressionType = &v
	return s
}

type SelectObjectRequestBodySelectRequestInputSerializationCSV struct {
	// FileHeaderInfo
	FileHeaderInfo *string `json:"FileHeaderInfo,omitempty" xml:"FileHeaderInfo,omitempty"`
	// RecordDelimiter
	RecordDelimiter *string `json:"RecordDelimiter,omitempty" xml:"RecordDelimiter,omitempty"`
	// FieldDelimiter
	FieldDelimiter *string `json:"FieldDelimiter,omitempty" xml:"FieldDelimiter,omitempty"`
	// QuoteCharacter
	QuoteCharacter *string `json:"QuoteCharacter,omitempty" xml:"QuoteCharacter,omitempty"`
	// CommentCharacter
	CommentCharacter *string `json:"CommentCharacter,omitempty" xml:"CommentCharacter,omitempty"`
	// Range
	Range *string `json:"Range,omitempty" xml:"Range,omitempty"`
}

func (s SelectObjectRequestBodySelectRequestInputSerializationCSV) String() string {
	return tea.Prettify(s)
}

func (s SelectObjectRequestBodySelectRequestInputSerializationCSV) GoString() string {
	return s.String()
}

func (s *SelectObjectRequestBodySelectRequestInputSerializationCSV) SetFileHeaderInfo(v string) *SelectObjectRequestBodySelectRequestInputSerializationCSV {
	s.FileHeaderInfo = &v
	return s
}

func (s *SelectObjectRequestBodySelectRequestInputSerializationCSV) SetRecordDelimiter(v string) *SelectObjectRequestBodySelectRequestInputSerializationCSV {
	s.RecordDelimiter = &v
	return s
}

func (s *SelectObjectRequestBodySelectRequestInputSerializationCSV) SetFieldDelimiter(v string) *SelectObjectRequestBodySelectRequestInputSerializationCSV {
	s.FieldDelimiter = &v
	return s
}

func (s *SelectObjectRequestBodySelectRequestInputSerializationCSV) SetQuoteCharacter(v string) *SelectObjectRequestBodySelectRequestInputSerializationCSV {
	s.QuoteCharacter = &v
	return s
}

func (s *SelectObjectRequestBodySelectRequestInputSerializationCSV) SetCommentCharacter(v string) *SelectObjectRequestBodySelectRequestInputSerializationCSV {
	s.CommentCharacter = &v
	return s
}

func (s *SelectObjectRequestBodySelectRequestInputSerializationCSV) SetRange(v string) *SelectObjectRequestBodySelectRequestInputSerializationCSV {
	s.Range = &v
	return s
}

type SelectObjectRequestBodySelectRequestOutputSerialization struct {
	// CSV
	CSV *SelectObjectRequestBodySelectRequestOutputSerializationCSV `json:"CSV,omitempty" xml:"CSV,omitempty" type:"Struct"`
	// KeepAllColumns
	KeepAllColumns *string `json:"KeepAllColumns,omitempty" xml:"KeepAllColumns,omitempty"`
	// OutputRawData
	OutputRawData *string `json:"OutputRawData,omitempty" xml:"OutputRawData,omitempty"`
	// EnablePayloadCrc
	EnablePayloadCrc *string `json:"EnablePayloadCrc,omitempty" xml:"EnablePayloadCrc,omitempty"`
	// OutputHeader
	OutputHeader *string `json:"OutputHeader,omitempty" xml:"OutputHeader,omitempty"`
}

func (s SelectObjectRequestBodySelectRequestOutputSerialization) String() string {
	return tea.Prettify(s)
}

func (s SelectObjectRequestBodySelectRequestOutputSerialization) GoString() string {
	return s.String()
}

func (s *SelectObjectRequestBodySelectRequestOutputSerialization) SetCSV(v *SelectObjectRequestBodySelectRequestOutputSerializationCSV) *SelectObjectRequestBodySelectRequestOutputSerialization {
	s.CSV = v
	return s
}

func (s *SelectObjectRequestBodySelectRequestOutputSerialization) SetKeepAllColumns(v string) *SelectObjectRequestBodySelectRequestOutputSerialization {
	s.KeepAllColumns = &v
	return s
}

func (s *SelectObjectRequestBodySelectRequestOutputSerialization) SetOutputRawData(v string) *SelectObjectRequestBodySelectRequestOutputSerialization {
	s.OutputRawData = &v
	return s
}

func (s *SelectObjectRequestBodySelectRequestOutputSerialization) SetEnablePayloadCrc(v string) *SelectObjectRequestBodySelectRequestOutputSerialization {
	s.EnablePayloadCrc = &v
	return s
}

func (s *SelectObjectRequestBodySelectRequestOutputSerialization) SetOutputHeader(v string) *SelectObjectRequestBodySelectRequestOutputSerialization {
	s.OutputHeader = &v
	return s
}

type SelectObjectRequestBodySelectRequestOutputSerializationCSV struct {
	// RecordDelimiter
	RecordDelimiter *string `json:"RecordDelimiter,omitempty" xml:"RecordDelimiter,omitempty"`
	// FieldDelimiter
	FieldDelimiter *string `json:"FieldDelimiter,omitempty" xml:"FieldDelimiter,omitempty"`
}

func (s SelectObjectRequestBodySelectRequestOutputSerializationCSV) String() string {
	return tea.Prettify(s)
}

func (s SelectObjectRequestBodySelectRequestOutputSerializationCSV) GoString() string {
	return s.String()
}

func (s *SelectObjectRequestBodySelectRequestOutputSerializationCSV) SetRecordDelimiter(v string) *SelectObjectRequestBodySelectRequestOutputSerializationCSV {
	s.RecordDelimiter = &v
	return s
}

func (s *SelectObjectRequestBodySelectRequestOutputSerializationCSV) SetFieldDelimiter(v string) *SelectObjectRequestBodySelectRequestOutputSerializationCSV {
	s.FieldDelimiter = &v
	return s
}

type SelectObjectRequestBodySelectRequestOptions struct {
	// SkipPartialDataRecord
	SkipPartialDataRecord *string `json:"SkipPartialDataRecord,omitempty" xml:"SkipPartialDataRecord,omitempty"`
	// MaxSkippedRecordsAllowed
	MaxSkippedRecordsAllowed *string `json:"MaxSkippedRecordsAllowed,omitempty" xml:"MaxSkippedRecordsAllowed,omitempty"`
}

func (s SelectObjectRequestBodySelectRequestOptions) String() string {
	return tea.Prettify(s)
}

func (s SelectObjectRequestBodySelectRequestOptions) GoString() string {
	return s.String()
}

func (s *SelectObjectRequestBodySelectRequestOptions) SetSkipPartialDataRecord(v string) *SelectObjectRequestBodySelectRequestOptions {
	s.SkipPartialDataRecord = &v
	return s
}

func (s *SelectObjectRequestBodySelectRequestOptions) SetMaxSkippedRecordsAllowed(v string) *SelectObjectRequestBodySelectRequestOptions {
	s.MaxSkippedRecordsAllowed = &v
	return s
}

type SelectObjectResponse struct {
	// x-oss-request-id
	RequestId *string `json:"x-oss-request-id,omitempty" xml:"x-oss-request-id,omitempty" require:"true"`
}

func (s SelectObjectResponse) String() string {
	return tea.Prettify(s)
}

func (s SelectObjectResponse) GoString() string {
	return s.String()
}

func (s *SelectObjectResponse) SetRequestId(v string) *SelectObjectResponse {
	s.RequestId = &v
	return s
}

type PutBucketCORSRequest struct {
	// BucketName
	BucketName *string `json:"BucketName,omitempty" xml:"BucketName,omitempty" require:"true" pattern:"[a-zA-Z0-9-_]+"`
	// Body
	Body *PutBucketCORSRequestBody `json:"Body,omitempty" xml:"Body,omitempty" type:"Struct"`
}

func (s PutBucketCORSRequest) String() string {
	return tea.Prettify(s)
}

func (s PutBucketCORSRequest) GoString() string {
	return s.String()
}

func (s *PutBucketCORSRequest) SetBucketName(v string) *PutBucketCORSRequest {
	s.BucketName = &v
	return s
}

func (s *PutBucketCORSRequest) SetBody(v *PutBucketCORSRequestBody) *PutBucketCORSRequest {
	s.Body = v
	return s
}

type PutBucketCORSRequestBody struct {
	// CORSConfiguration
	CORSConfiguration *PutBucketCORSRequestBodyCORSConfiguration `json:"CORSConfiguration,omitempty" xml:"CORSConfiguration,omitempty" require:"true" type:"Struct"`
}

func (s PutBucketCORSRequestBody) String() string {
	return tea.Prettify(s)
}

func (s PutBucketCORSRequestBody) GoString() string {
	return s.String()
}

func (s *PutBucketCORSRequestBody) SetCORSConfiguration(v *PutBucketCORSRequestBodyCORSConfiguration) *PutBucketCORSRequestBody {
	s.CORSConfiguration = v
	return s
}

type PutBucketCORSRequestBodyCORSConfiguration struct {
	// CORSRule
	CORSRule []*PutBucketCORSRequestBodyCORSConfigurationCORSRule `json:"CORSRule,omitempty" xml:"CORSRule,omitempty" type:"Repeated"`
}

func (s PutBucketCORSRequestBodyCORSConfiguration) String() string {
	return tea.Prettify(s)
}

func (s PutBucketCORSRequestBodyCORSConfiguration) GoString() string {
	return s.String()
}

func (s *PutBucketCORSRequestBodyCORSConfiguration) SetCORSRule(v []*PutBucketCORSRequestBodyCORSConfigurationCORSRule) *PutBucketCORSRequestBodyCORSConfiguration {
	s.CORSRule = v
	return s
}

type PutBucketCORSRequestBodyCORSConfigurationCORSRule struct {
	// AllowedOrigin
	AllowedOrigin []*string `json:"AllowedOrigin,omitempty" xml:"AllowedOrigin,omitempty" type:"Repeated"`
	// AllowedMethod
	AllowedMethod []*string `json:"AllowedMethod,omitempty" xml:"AllowedMethod,omitempty" type:"Repeated"`
	// AllowedHeader
	AllowedHeader []*string `json:"AllowedHeader,omitempty" xml:"AllowedHeader,omitempty" type:"Repeated"`
	// ExposeHeader
	ExposeHeader []*string `json:"ExposeHeader,omitempty" xml:"ExposeHeader,omitempty" type:"Repeated"`
	// MaxAgeSeconds
	MaxAgeSeconds *string `json:"MaxAgeSeconds,omitempty" xml:"MaxAgeSeconds,omitempty"`
}

func (s PutBucketCORSRequestBodyCORSConfigurationCORSRule) String() string {
	return tea.Prettify(s)
}

func (s PutBucketCORSRequestBodyCORSConfigurationCORSRule) GoString() string {
	return s.String()
}

func (s *PutBucketCORSRequestBodyCORSConfigurationCORSRule) SetAllowedOrigin(v []*string) *PutBucketCORSRequestBodyCORSConfigurationCORSRule {
	s.AllowedOrigin = v
	return s
}

func (s *PutBucketCORSRequestBodyCORSConfigurationCORSRule) SetAllowedMethod(v []*string) *PutBucketCORSRequestBodyCORSConfigurationCORSRule {
	s.AllowedMethod = v
	return s
}

func (s *PutBucketCORSRequestBodyCORSConfigurationCORSRule) SetAllowedHeader(v []*string) *PutBucketCORSRequestBodyCORSConfigurationCORSRule {
	s.AllowedHeader = v
	return s
}

func (s *PutBucketCORSRequestBodyCORSConfigurationCORSRule) SetExposeHeader(v []*string) *PutBucketCORSRequestBodyCORSConfigurationCORSRule {
	s.ExposeHeader = v
	return s
}

func (s *PutBucketCORSRequestBodyCORSConfigurationCORSRule) SetMaxAgeSeconds(v string) *PutBucketCORSRequestBodyCORSConfigurationCORSRule {
	s.MaxAgeSeconds = &v
	return s
}

type PutBucketCORSResponse struct {
	// x-oss-request-id
	RequestId *string `json:"x-oss-request-id,omitempty" xml:"x-oss-request-id,omitempty" require:"true"`
}

func (s PutBucketCORSResponse) String() string {
	return tea.Prettify(s)
}

func (s PutBucketCORSResponse) GoString() string {
	return s.String()
}

func (s *PutBucketCORSResponse) SetRequestId(v string) *PutBucketCORSResponse {
	s.RequestId = &v
	return s
}

type PutBucketRequest struct {
	// BucketName
	BucketName *string `json:"BucketName,omitempty" xml:"BucketName,omitempty" require:"true" pattern:"[a-zA-Z0-9-_]+"`
	// Body
	Body *PutBucketRequestBody `json:"Body,omitempty" xml:"Body,omitempty" type:"Struct"`
	// Header
	Header *PutBucketRequestHeader `json:"Header,omitempty" xml:"Header,omitempty" type:"Struct"`
}

func (s PutBucketRequest) String() string {
	return tea.Prettify(s)
}

func (s PutBucketRequest) GoString() string {
	return s.String()
}

func (s *PutBucketRequest) SetBucketName(v string) *PutBucketRequest {
	s.BucketName = &v
	return s
}

func (s *PutBucketRequest) SetBody(v *PutBucketRequestBody) *PutBucketRequest {
	s.Body = v
	return s
}

func (s *PutBucketRequest) SetHeader(v *PutBucketRequestHeader) *PutBucketRequest {
	s.Header = v
	return s
}

type PutBucketRequestBody struct {
	// CreateBucketConfiguration
	CreateBucketConfiguration *PutBucketRequestBodyCreateBucketConfiguration `json:"CreateBucketConfiguration,omitempty" xml:"CreateBucketConfiguration,omitempty" require:"true" type:"Struct"`
}

func (s PutBucketRequestBody) String() string {
	return tea.Prettify(s)
}

func (s PutBucketRequestBody) GoString() string {
	return s.String()
}

func (s *PutBucketRequestBody) SetCreateBucketConfiguration(v *PutBucketRequestBodyCreateBucketConfiguration) *PutBucketRequestBody {
	s.CreateBucketConfiguration = v
	return s
}

type PutBucketRequestBodyCreateBucketConfiguration struct {
	// StorageClass
	StorageClass *string `json:"StorageClass,omitempty" xml:"StorageClass,omitempty"`
	// DataRedundancyType
	DataRedundancyType *string `json:"DataRedundancyType,omitempty" xml:"DataRedundancyType,omitempty"`
}

func (s PutBucketRequestBodyCreateBucketConfiguration) String() string {
	return tea.Prettify(s)
}

func (s PutBucketRequestBodyCreateBucketConfiguration) GoString() string {
	return s.String()
}

func (s *PutBucketRequestBodyCreateBucketConfiguration) SetStorageClass(v string) *PutBucketRequestBodyCreateBucketConfiguration {
	s.StorageClass = &v
	return s
}

func (s *PutBucketRequestBodyCreateBucketConfiguration) SetDataRedundancyType(v string) *PutBucketRequestBodyCreateBucketConfiguration {
	s.DataRedundancyType = &v
	return s
}

type PutBucketRequestHeader struct {
	// x-oss-acl
	Acl *string `json:"x-oss-acl,omitempty" xml:"x-oss-acl,omitempty"`
}

func (s PutBucketRequestHeader) String() string {
	return tea.Prettify(s)
}

func (s PutBucketRequestHeader) GoString() string {
	return s.String()
}

func (s *PutBucketRequestHeader) SetAcl(v string) *PutBucketRequestHeader {
	s.Acl = &v
	return s
}

type PutBucketResponse struct {
	// x-oss-request-id
	RequestId *string `json:"x-oss-request-id,omitempty" xml:"x-oss-request-id,omitempty" require:"true"`
}

func (s PutBucketResponse) String() string {
	return tea.Prettify(s)
}

func (s PutBucketResponse) GoString() string {
	return s.String()
}

func (s *PutBucketResponse) SetRequestId(v string) *PutBucketResponse {
	s.RequestId = &v
	return s
}

type ListMultipartUploadsRequest struct {
	// BucketName
	BucketName *string `json:"BucketName,omitempty" xml:"BucketName,omitempty" require:"true" pattern:"[a-zA-Z0-9-_]+"`
	// Filter
	Filter *ListMultipartUploadsRequestFilter `json:"Filter,omitempty" xml:"Filter,omitempty" type:"Struct"`
}

func (s ListMultipartUploadsRequest) String() string {
	return tea.Prettify(s)
}

func (s ListMultipartUploadsRequest) GoString() string {
	return s.String()
}

func (s *ListMultipartUploadsRequest) SetBucketName(v string) *ListMultipartUploadsRequest {
	s.BucketName = &v
	return s
}

func (s *ListMultipartUploadsRequest) SetFilter(v *ListMultipartUploadsRequestFilter) *ListMultipartUploadsRequest {
	s.Filter = v
	return s
}

type ListMultipartUploadsRequestFilter struct {
	// delimiter
	Delimiter *string `json:"delimiter,omitempty" xml:"delimiter,omitempty"`
	// max-uploads
	MaxUploads *string `json:"max-uploads,omitempty" xml:"max-uploads,omitempty"`
	// key-marker
	KeyMarker *string `json:"key-marker,omitempty" xml:"key-marker,omitempty"`
	// prefix
	Prefix *string `json:"prefix,omitempty" xml:"prefix,omitempty"`
	// upload-id-marker
	UploadIdMarker *string `json:"upload-id-marker,omitempty" xml:"upload-id-marker,omitempty"`
	// encoding-type
	EncodingType *string `json:"encoding-type,omitempty" xml:"encoding-type,omitempty"`
}

func (s ListMultipartUploadsRequestFilter) String() string {
	return tea.Prettify(s)
}

func (s ListMultipartUploadsRequestFilter) GoString() string {
	return s.String()
}

func (s *ListMultipartUploadsRequestFilter) SetDelimiter(v string) *ListMultipartUploadsRequestFilter {
	s.Delimiter = &v
	return s
}

func (s *ListMultipartUploadsRequestFilter) SetMaxUploads(v string) *ListMultipartUploadsRequestFilter {
	s.MaxUploads = &v
	return s
}

func (s *ListMultipartUploadsRequestFilter) SetKeyMarker(v string) *ListMultipartUploadsRequestFilter {
	s.KeyMarker = &v
	return s
}

func (s *ListMultipartUploadsRequestFilter) SetPrefix(v string) *ListMultipartUploadsRequestFilter {
	s.Prefix = &v
	return s
}

func (s *ListMultipartUploadsRequestFilter) SetUploadIdMarker(v string) *ListMultipartUploadsRequestFilter {
	s.UploadIdMarker = &v
	return s
}

func (s *ListMultipartUploadsRequestFilter) SetEncodingType(v string) *ListMultipartUploadsRequestFilter {
	s.EncodingType = &v
	return s
}

type ListMultipartUploadsResponse struct {
	// x-oss-request-id
	RequestId *string `json:"x-oss-request-id,omitempty" xml:"x-oss-request-id,omitempty" require:"true"`
	// ListMultipartUploadsResult
	ListMultipartUploadsResult *ListMultipartUploadsResponseListMultipartUploadsResult `json:"ListMultipartUploadsResult,omitempty" xml:"ListMultipartUploadsResult,omitempty" require:"true" type:"Struct"`
}

func (s ListMultipartUploadsResponse) String() string {
	return tea.Prettify(s)
}

func (s ListMultipartUploadsResponse) GoString() string {
	return s.String()
}

func (s *ListMultipartUploadsResponse) SetRequestId(v string) *ListMultipartUploadsResponse {
	s.RequestId = &v
	return s
}

func (s *ListMultipartUploadsResponse) SetListMultipartUploadsResult(v *ListMultipartUploadsResponseListMultipartUploadsResult) *ListMultipartUploadsResponse {
	s.ListMultipartUploadsResult = v
	return s
}

type ListMultipartUploadsResponseListMultipartUploadsResult struct {
	// Bucket
	Bucket *string `json:"Bucket,omitempty" xml:"Bucket,omitempty"`
	// EncodingType
	EncodingType *string `json:"EncodingType,omitempty" xml:"EncodingType,omitempty"`
	// KeyMarker
	KeyMarker *string `json:"KeyMarker,omitempty" xml:"KeyMarker,omitempty"`
	// UploadIdMarker
	UploadIdMarker *string `json:"UploadIdMarker,omitempty" xml:"UploadIdMarker,omitempty"`
	// NextKeyMarker
	NextKeyMarker *string `json:"NextKeyMarker,omitempty" xml:"NextKeyMarker,omitempty"`
	// NextUploadIdMarker
	NextUploadIdMarker *string `json:"NextUploadIdMarker,omitempty" xml:"NextUploadIdMarker,omitempty"`
	// Delimiter
	Delimiter *string `json:"Delimiter,omitempty" xml:"Delimiter,omitempty"`
	// MaxUploads
	MaxUploads *string `json:"MaxUploads,omitempty" xml:"MaxUploads,omitempty"`
	// IsTruncated
	IsTruncated *string `json:"IsTruncated,omitempty" xml:"IsTruncated,omitempty"`
	// Upload
	Upload []*ListMultipartUploadsResponseListMultipartUploadsResultUpload `json:"Upload,omitempty" xml:"Upload,omitempty" type:"Repeated"`
}

func (s ListMultipartUploadsResponseListMultipartUploadsResult) String() string {
	return tea.Prettify(s)
}

func (s ListMultipartUploadsResponseListMultipartUploadsResult) GoString() string {
	return s.String()
}

func (s *ListMultipartUploadsResponseListMultipartUploadsResult) SetBucket(v string) *ListMultipartUploadsResponseListMultipartUploadsResult {
	s.Bucket = &v
	return s
}

func (s *ListMultipartUploadsResponseListMultipartUploadsResult) SetEncodingType(v string) *ListMultipartUploadsResponseListMultipartUploadsResult {
	s.EncodingType = &v
	return s
}

func (s *ListMultipartUploadsResponseListMultipartUploadsResult) SetKeyMarker(v string) *ListMultipartUploadsResponseListMultipartUploadsResult {
	s.KeyMarker = &v
	return s
}

func (s *ListMultipartUploadsResponseListMultipartUploadsResult) SetUploadIdMarker(v string) *ListMultipartUploadsResponseListMultipartUploadsResult {
	s.UploadIdMarker = &v
	return s
}

func (s *ListMultipartUploadsResponseListMultipartUploadsResult) SetNextKeyMarker(v string) *ListMultipartUploadsResponseListMultipartUploadsResult {
	s.NextKeyMarker = &v
	return s
}

func (s *ListMultipartUploadsResponseListMultipartUploadsResult) SetNextUploadIdMarker(v string) *ListMultipartUploadsResponseListMultipartUploadsResult {
	s.NextUploadIdMarker = &v
	return s
}

func (s *ListMultipartUploadsResponseListMultipartUploadsResult) SetDelimiter(v string) *ListMultipartUploadsResponseListMultipartUploadsResult {
	s.Delimiter = &v
	return s
}

func (s *ListMultipartUploadsResponseListMultipartUploadsResult) SetMaxUploads(v string) *ListMultipartUploadsResponseListMultipartUploadsResult {
	s.MaxUploads = &v
	return s
}

func (s *ListMultipartUploadsResponseListMultipartUploadsResult) SetIsTruncated(v string) *ListMultipartUploadsResponseListMultipartUploadsResult {
	s.IsTruncated = &v
	return s
}

func (s *ListMultipartUploadsResponseListMultipartUploadsResult) SetUpload(v []*ListMultipartUploadsResponseListMultipartUploadsResultUpload) *ListMultipartUploadsResponseListMultipartUploadsResult {
	s.Upload = v
	return s
}

type ListMultipartUploadsResponseListMultipartUploadsResultUpload struct {
	// Key
	Key *string `json:"Key,omitempty" xml:"Key,omitempty"`
	// UploadId
	UploadId *string `json:"UploadId,omitempty" xml:"UploadId,omitempty"`
	// Initiated
	Initiated *string `json:"Initiated,omitempty" xml:"Initiated,omitempty"`
}

func (s ListMultipartUploadsResponseListMultipartUploadsResultUpload) String() string {
	return tea.Prettify(s)
}

func (s ListMultipartUploadsResponseListMultipartUploadsResultUpload) GoString() string {
	return s.String()
}

func (s *ListMultipartUploadsResponseListMultipartUploadsResultUpload) SetKey(v string) *ListMultipartUploadsResponseListMultipartUploadsResultUpload {
	s.Key = &v
	return s
}

func (s *ListMultipartUploadsResponseListMultipartUploadsResultUpload) SetUploadId(v string) *ListMultipartUploadsResponseListMultipartUploadsResultUpload {
	s.UploadId = &v
	return s
}

func (s *ListMultipartUploadsResponseListMultipartUploadsResultUpload) SetInitiated(v string) *ListMultipartUploadsResponseListMultipartUploadsResultUpload {
	s.Initiated = &v
	return s
}

type GetBucketRequestPaymentRequest struct {
	// BucketName
	BucketName *string `json:"BucketName,omitempty" xml:"BucketName,omitempty" require:"true" pattern:"[a-zA-Z0-9-_]+"`
}

func (s GetBucketRequestPaymentRequest) String() string {
	return tea.Prettify(s)
}

func (s GetBucketRequestPaymentRequest) GoString() string {
	return s.String()
}

func (s *GetBucketRequestPaymentRequest) SetBucketName(v string) *GetBucketRequestPaymentRequest {
	s.BucketName = &v
	return s
}

type GetBucketRequestPaymentResponse struct {
	// x-oss-request-id
	RequestId *string `json:"x-oss-request-id,omitempty" xml:"x-oss-request-id,omitempty" require:"true"`
	// RequestPaymentConfiguration
	RequestPaymentConfiguration *GetBucketRequestPaymentResponseRequestPaymentConfiguration `json:"RequestPaymentConfiguration,omitempty" xml:"RequestPaymentConfiguration,omitempty" require:"true" type:"Struct"`
}

func (s GetBucketRequestPaymentResponse) String() string {
	return tea.Prettify(s)
}

func (s GetBucketRequestPaymentResponse) GoString() string {
	return s.String()
}

func (s *GetBucketRequestPaymentResponse) SetRequestId(v string) *GetBucketRequestPaymentResponse {
	s.RequestId = &v
	return s
}

func (s *GetBucketRequestPaymentResponse) SetRequestPaymentConfiguration(v *GetBucketRequestPaymentResponseRequestPaymentConfiguration) *GetBucketRequestPaymentResponse {
	s.RequestPaymentConfiguration = v
	return s
}

type GetBucketRequestPaymentResponseRequestPaymentConfiguration struct {
	// Payer
	Payer *string `json:"Payer,omitempty" xml:"Payer,omitempty"`
}

func (s GetBucketRequestPaymentResponseRequestPaymentConfiguration) String() string {
	return tea.Prettify(s)
}

func (s GetBucketRequestPaymentResponseRequestPaymentConfiguration) GoString() string {
	return s.String()
}

func (s *GetBucketRequestPaymentResponseRequestPaymentConfiguration) SetPayer(v string) *GetBucketRequestPaymentResponseRequestPaymentConfiguration {
	s.Payer = &v
	return s
}

type GetBucketEncryptionRequest struct {
	// BucketName
	BucketName *string `json:"BucketName,omitempty" xml:"BucketName,omitempty" require:"true" pattern:"[a-zA-Z0-9-_]+"`
}

func (s GetBucketEncryptionRequest) String() string {
	return tea.Prettify(s)
}

func (s GetBucketEncryptionRequest) GoString() string {
	return s.String()
}

func (s *GetBucketEncryptionRequest) SetBucketName(v string) *GetBucketEncryptionRequest {
	s.BucketName = &v
	return s
}

type GetBucketEncryptionResponse struct {
	// x-oss-request-id
	RequestId *string `json:"x-oss-request-id,omitempty" xml:"x-oss-request-id,omitempty" require:"true"`
	// ServerSideEncryptionRule
	ServerSideEncryptionRule *GetBucketEncryptionResponseServerSideEncryptionRule `json:"ServerSideEncryptionRule,omitempty" xml:"ServerSideEncryptionRule,omitempty" require:"true" type:"Struct"`
}

func (s GetBucketEncryptionResponse) String() string {
	return tea.Prettify(s)
}

func (s GetBucketEncryptionResponse) GoString() string {
	return s.String()
}

func (s *GetBucketEncryptionResponse) SetRequestId(v string) *GetBucketEncryptionResponse {
	s.RequestId = &v
	return s
}

func (s *GetBucketEncryptionResponse) SetServerSideEncryptionRule(v *GetBucketEncryptionResponseServerSideEncryptionRule) *GetBucketEncryptionResponse {
	s.ServerSideEncryptionRule = v
	return s
}

type GetBucketEncryptionResponseServerSideEncryptionRule struct {
	// ApplyServerSideEncryptionByDefault
	ApplyServerSideEncryptionByDefault *GetBucketEncryptionResponseServerSideEncryptionRuleApplyServerSideEncryptionByDefault `json:"ApplyServerSideEncryptionByDefault,omitempty" xml:"ApplyServerSideEncryptionByDefault,omitempty" require:"true" type:"Struct"`
}

func (s GetBucketEncryptionResponseServerSideEncryptionRule) String() string {
	return tea.Prettify(s)
}

func (s GetBucketEncryptionResponseServerSideEncryptionRule) GoString() string {
	return s.String()
}

func (s *GetBucketEncryptionResponseServerSideEncryptionRule) SetApplyServerSideEncryptionByDefault(v *GetBucketEncryptionResponseServerSideEncryptionRuleApplyServerSideEncryptionByDefault) *GetBucketEncryptionResponseServerSideEncryptionRule {
	s.ApplyServerSideEncryptionByDefault = v
	return s
}

type GetBucketEncryptionResponseServerSideEncryptionRuleApplyServerSideEncryptionByDefault struct {
	// SSEAlgorithm
	SSEAlgorithm *string `json:"SSEAlgorithm,omitempty" xml:"SSEAlgorithm,omitempty"`
	// KMSMasterKeyID
	KMSMasterKeyID *string `json:"KMSMasterKeyID,omitempty" xml:"KMSMasterKeyID,omitempty"`
}

func (s GetBucketEncryptionResponseServerSideEncryptionRuleApplyServerSideEncryptionByDefault) String() string {
	return tea.Prettify(s)
}

func (s GetBucketEncryptionResponseServerSideEncryptionRuleApplyServerSideEncryptionByDefault) GoString() string {
	return s.String()
}

func (s *GetBucketEncryptionResponseServerSideEncryptionRuleApplyServerSideEncryptionByDefault) SetSSEAlgorithm(v string) *GetBucketEncryptionResponseServerSideEncryptionRuleApplyServerSideEncryptionByDefault {
	s.SSEAlgorithm = &v
	return s
}

func (s *GetBucketEncryptionResponseServerSideEncryptionRuleApplyServerSideEncryptionByDefault) SetKMSMasterKeyID(v string) *GetBucketEncryptionResponseServerSideEncryptionRuleApplyServerSideEncryptionByDefault {
	s.KMSMasterKeyID = &v
	return s
}

type GetBucketTagsRequest struct {
	// BucketName
	BucketName *string `json:"BucketName,omitempty" xml:"BucketName,omitempty" require:"true" pattern:"[a-zA-Z0-9-_]+"`
}

func (s GetBucketTagsRequest) String() string {
	return tea.Prettify(s)
}

func (s GetBucketTagsRequest) GoString() string {
	return s.String()
}

func (s *GetBucketTagsRequest) SetBucketName(v string) *GetBucketTagsRequest {
	s.BucketName = &v
	return s
}

type GetBucketTagsResponse struct {
	// x-oss-request-id
	RequestId *string `json:"x-oss-request-id,omitempty" xml:"x-oss-request-id,omitempty" require:"true"`
	// Tagging
	Tagging *GetBucketTagsResponseTagging `json:"Tagging,omitempty" xml:"Tagging,omitempty" require:"true" type:"Struct"`
}

func (s GetBucketTagsResponse) String() string {
	return tea.Prettify(s)
}

func (s GetBucketTagsResponse) GoString() string {
	return s.String()
}

func (s *GetBucketTagsResponse) SetRequestId(v string) *GetBucketTagsResponse {
	s.RequestId = &v
	return s
}

func (s *GetBucketTagsResponse) SetTagging(v *GetBucketTagsResponseTagging) *GetBucketTagsResponse {
	s.Tagging = v
	return s
}

type GetBucketTagsResponseTagging struct {
	// TagSet
	TagSet *GetBucketTagsResponseTaggingTagSet `json:"TagSet,omitempty" xml:"TagSet,omitempty" require:"true" type:"Struct"`
}

func (s GetBucketTagsResponseTagging) String() string {
	return tea.Prettify(s)
}

func (s GetBucketTagsResponseTagging) GoString() string {
	return s.String()
}

func (s *GetBucketTagsResponseTagging) SetTagSet(v *GetBucketTagsResponseTaggingTagSet) *GetBucketTagsResponseTagging {
	s.TagSet = v
	return s
}

type GetBucketTagsResponseTaggingTagSet struct {
	// Tag
	Tag []*GetBucketTagsResponseTaggingTagSetTag `json:"Tag,omitempty" xml:"Tag,omitempty" type:"Repeated"`
}

func (s GetBucketTagsResponseTaggingTagSet) String() string {
	return tea.Prettify(s)
}

func (s GetBucketTagsResponseTaggingTagSet) GoString() string {
	return s.String()
}

func (s *GetBucketTagsResponseTaggingTagSet) SetTag(v []*GetBucketTagsResponseTaggingTagSetTag) *GetBucketTagsResponseTaggingTagSet {
	s.Tag = v
	return s
}

type GetBucketTagsResponseTaggingTagSetTag struct {
	// Key
	Key *string `json:"Key,omitempty" xml:"Key,omitempty"`
	// Value
	Value *string `json:"Value,omitempty" xml:"Value,omitempty"`
}

func (s GetBucketTagsResponseTaggingTagSetTag) String() string {
	return tea.Prettify(s)
}

func (s GetBucketTagsResponseTaggingTagSetTag) GoString() string {
	return s.String()
}

func (s *GetBucketTagsResponseTaggingTagSetTag) SetKey(v string) *GetBucketTagsResponseTaggingTagSetTag {
	s.Key = &v
	return s
}

func (s *GetBucketTagsResponseTaggingTagSetTag) SetValue(v string) *GetBucketTagsResponseTaggingTagSetTag {
	s.Value = &v
	return s
}

type GetServiceRequest struct {
	// Filter
	Filter *GetServiceRequestFilter `json:"Filter,omitempty" xml:"Filter,omitempty" type:"Struct"`
}

func (s GetServiceRequest) String() string {
	return tea.Prettify(s)
}

func (s GetServiceRequest) GoString() string {
	return s.String()
}

func (s *GetServiceRequest) SetFilter(v *GetServiceRequestFilter) *GetServiceRequest {
	s.Filter = v
	return s
}

type GetServiceRequestFilter struct {
	// prefix
	Prefix *string `json:"prefix,omitempty" xml:"prefix,omitempty"`
	// marker
	Marker *string `json:"marker,omitempty" xml:"marker,omitempty"`
	// max-keys
	MaxKeys *string `json:"max-keys,omitempty" xml:"max-keys,omitempty"`
}

func (s GetServiceRequestFilter) String() string {
	return tea.Prettify(s)
}

func (s GetServiceRequestFilter) GoString() string {
	return s.String()
}

func (s *GetServiceRequestFilter) SetPrefix(v string) *GetServiceRequestFilter {
	s.Prefix = &v
	return s
}

func (s *GetServiceRequestFilter) SetMarker(v string) *GetServiceRequestFilter {
	s.Marker = &v
	return s
}

func (s *GetServiceRequestFilter) SetMaxKeys(v string) *GetServiceRequestFilter {
	s.MaxKeys = &v
	return s
}

type GetServiceResponse struct {
	// x-oss-request-id
	RequestId *string `json:"x-oss-request-id,omitempty" xml:"x-oss-request-id,omitempty" require:"true"`
	// ListAllMyBucketsResult
	ListAllMyBucketsResult *GetServiceResponseListAllMyBucketsResult `json:"ListAllMyBucketsResult,omitempty" xml:"ListAllMyBucketsResult,omitempty" require:"true" type:"Struct"`
}

func (s GetServiceResponse) String() string {
	return tea.Prettify(s)
}

func (s GetServiceResponse) GoString() string {
	return s.String()
}

func (s *GetServiceResponse) SetRequestId(v string) *GetServiceResponse {
	s.RequestId = &v
	return s
}

func (s *GetServiceResponse) SetListAllMyBucketsResult(v *GetServiceResponseListAllMyBucketsResult) *GetServiceResponse {
	s.ListAllMyBucketsResult = v
	return s
}

type GetServiceResponseListAllMyBucketsResult struct {
	// Prefix
	Prefix *string `json:"Prefix,omitempty" xml:"Prefix,omitempty"`
	// Marker
	Marker *string `json:"Marker,omitempty" xml:"Marker,omitempty"`
	// MaxKeys
	MaxKeys *string `json:"MaxKeys,omitempty" xml:"MaxKeys,omitempty"`
	// IsTruncated
	IsTruncated *string `json:"IsTruncated,omitempty" xml:"IsTruncated,omitempty"`
	// NextMarker
	NextMarker *string `json:"NextMarker,omitempty" xml:"NextMarker,omitempty"`
	// Owner
	Owner *GetServiceResponseListAllMyBucketsResultOwner `json:"Owner,omitempty" xml:"Owner,omitempty" require:"true" type:"Struct"`
	// Buckets
	Buckets *GetServiceResponseListAllMyBucketsResultBuckets `json:"Buckets,omitempty" xml:"Buckets,omitempty" require:"true" type:"Struct"`
}

func (s GetServiceResponseListAllMyBucketsResult) String() string {
	return tea.Prettify(s)
}

func (s GetServiceResponseListAllMyBucketsResult) GoString() string {
	return s.String()
}

func (s *GetServiceResponseListAllMyBucketsResult) SetPrefix(v string) *GetServiceResponseListAllMyBucketsResult {
	s.Prefix = &v
	return s
}

func (s *GetServiceResponseListAllMyBucketsResult) SetMarker(v string) *GetServiceResponseListAllMyBucketsResult {
	s.Marker = &v
	return s
}

func (s *GetServiceResponseListAllMyBucketsResult) SetMaxKeys(v string) *GetServiceResponseListAllMyBucketsResult {
	s.MaxKeys = &v
	return s
}

func (s *GetServiceResponseListAllMyBucketsResult) SetIsTruncated(v string) *GetServiceResponseListAllMyBucketsResult {
	s.IsTruncated = &v
	return s
}

func (s *GetServiceResponseListAllMyBucketsResult) SetNextMarker(v string) *GetServiceResponseListAllMyBucketsResult {
	s.NextMarker = &v
	return s
}

func (s *GetServiceResponseListAllMyBucketsResult) SetOwner(v *GetServiceResponseListAllMyBucketsResultOwner) *GetServiceResponseListAllMyBucketsResult {
	s.Owner = v
	return s
}

func (s *GetServiceResponseListAllMyBucketsResult) SetBuckets(v *GetServiceResponseListAllMyBucketsResultBuckets) *GetServiceResponseListAllMyBucketsResult {
	s.Buckets = v
	return s
}

type GetServiceResponseListAllMyBucketsResultOwner struct {
	// ID
	ID *string `json:"ID,omitempty" xml:"ID,omitempty"`
	// DisplayName
	DisplayName *string `json:"DisplayName,omitempty" xml:"DisplayName,omitempty"`
}

func (s GetServiceResponseListAllMyBucketsResultOwner) String() string {
	return tea.Prettify(s)
}

func (s GetServiceResponseListAllMyBucketsResultOwner) GoString() string {
	return s.String()
}

func (s *GetServiceResponseListAllMyBucketsResultOwner) SetID(v string) *GetServiceResponseListAllMyBucketsResultOwner {
	s.ID = &v
	return s
}

func (s *GetServiceResponseListAllMyBucketsResultOwner) SetDisplayName(v string) *GetServiceResponseListAllMyBucketsResultOwner {
	s.DisplayName = &v
	return s
}

type GetServiceResponseListAllMyBucketsResultBuckets struct {
	// Bucket
	Bucket []*GetServiceResponseListAllMyBucketsResultBucketsBucket `json:"Bucket,omitempty" xml:"Bucket,omitempty" type:"Repeated"`
}

func (s GetServiceResponseListAllMyBucketsResultBuckets) String() string {
	return tea.Prettify(s)
}

func (s GetServiceResponseListAllMyBucketsResultBuckets) GoString() string {
	return s.String()
}

func (s *GetServiceResponseListAllMyBucketsResultBuckets) SetBucket(v []*GetServiceResponseListAllMyBucketsResultBucketsBucket) *GetServiceResponseListAllMyBucketsResultBuckets {
	s.Bucket = v
	return s
}

type GetServiceResponseListAllMyBucketsResultBucketsBucket struct {
	// Name
	Name *string `json:"Name,omitempty" xml:"Name,omitempty"`
	// CreateDate
	CreateDate *string `json:"CreateDate,omitempty" xml:"CreateDate,omitempty"`
	// Location
	Location *string `json:"Location,omitempty" xml:"Location,omitempty"`
	// ExtranetEndpoint
	ExtranetEndpoint *string `json:"ExtranetEndpoint,omitempty" xml:"ExtranetEndpoint,omitempty"`
	// IntranetEndpoint
	IntranetEndpoint *string `json:"IntranetEndpoint,omitempty" xml:"IntranetEndpoint,omitempty"`
	// StorageClass
	StorageClass *string `json:"StorageClass,omitempty" xml:"StorageClass,omitempty"`
}

func (s GetServiceResponseListAllMyBucketsResultBucketsBucket) String() string {
	return tea.Prettify(s)
}

func (s GetServiceResponseListAllMyBucketsResultBucketsBucket) GoString() string {
	return s.String()
}

func (s *GetServiceResponseListAllMyBucketsResultBucketsBucket) SetName(v string) *GetServiceResponseListAllMyBucketsResultBucketsBucket {
	s.Name = &v
	return s
}

func (s *GetServiceResponseListAllMyBucketsResultBucketsBucket) SetCreateDate(v string) *GetServiceResponseListAllMyBucketsResultBucketsBucket {
	s.CreateDate = &v
	return s
}

func (s *GetServiceResponseListAllMyBucketsResultBucketsBucket) SetLocation(v string) *GetServiceResponseListAllMyBucketsResultBucketsBucket {
	s.Location = &v
	return s
}

func (s *GetServiceResponseListAllMyBucketsResultBucketsBucket) SetExtranetEndpoint(v string) *GetServiceResponseListAllMyBucketsResultBucketsBucket {
	s.ExtranetEndpoint = &v
	return s
}

func (s *GetServiceResponseListAllMyBucketsResultBucketsBucket) SetIntranetEndpoint(v string) *GetServiceResponseListAllMyBucketsResultBucketsBucket {
	s.IntranetEndpoint = &v
	return s
}

func (s *GetServiceResponseListAllMyBucketsResultBucketsBucket) SetStorageClass(v string) *GetServiceResponseListAllMyBucketsResultBucketsBucket {
	s.StorageClass = &v
	return s
}

type DeleteBucketEncryptionRequest struct {
	// BucketName
	BucketName *string `json:"BucketName,omitempty" xml:"BucketName,omitempty" require:"true" pattern:"[a-zA-Z0-9-_]+"`
}

func (s DeleteBucketEncryptionRequest) String() string {
	return tea.Prettify(s)
}

func (s DeleteBucketEncryptionRequest) GoString() string {
	return s.String()
}

func (s *DeleteBucketEncryptionRequest) SetBucketName(v string) *DeleteBucketEncryptionRequest {
	s.BucketName = &v
	return s
}

type DeleteBucketEncryptionResponse struct {
	// x-oss-request-id
	RequestId *string `json:"x-oss-request-id,omitempty" xml:"x-oss-request-id,omitempty" require:"true"`
}

func (s DeleteBucketEncryptionResponse) String() string {
	return tea.Prettify(s)
}

func (s DeleteBucketEncryptionResponse) GoString() string {
	return s.String()
}

func (s *DeleteBucketEncryptionResponse) SetRequestId(v string) *DeleteBucketEncryptionResponse {
	s.RequestId = &v
	return s
}

type DeleteBucketTagsRequest struct {
	// BucketName
	BucketName *string `json:"BucketName,omitempty" xml:"BucketName,omitempty" require:"true" pattern:"[a-zA-Z0-9-_]+"`
	// Filter
	Filter *DeleteBucketTagsRequestFilter `json:"Filter,omitempty" xml:"Filter,omitempty" require:"true" type:"Struct"`
}

func (s DeleteBucketTagsRequest) String() string {
	return tea.Prettify(s)
}

func (s DeleteBucketTagsRequest) GoString() string {
	return s.String()
}

func (s *DeleteBucketTagsRequest) SetBucketName(v string) *DeleteBucketTagsRequest {
	s.BucketName = &v
	return s
}

func (s *DeleteBucketTagsRequest) SetFilter(v *DeleteBucketTagsRequestFilter) *DeleteBucketTagsRequest {
	s.Filter = v
	return s
}

type DeleteBucketTagsRequestFilter struct {
	// tagging
	Tagging *string `json:"tagging,omitempty" xml:"tagging,omitempty" require:"true" signed:"true"`
}

func (s DeleteBucketTagsRequestFilter) String() string {
	return tea.Prettify(s)
}

func (s DeleteBucketTagsRequestFilter) GoString() string {
	return s.String()
}

func (s *DeleteBucketTagsRequestFilter) SetTagging(v string) *DeleteBucketTagsRequestFilter {
	s.Tagging = &v
	return s
}

type DeleteBucketTagsResponse struct {
	// x-oss-request-id
	RequestId *string `json:"x-oss-request-id,omitempty" xml:"x-oss-request-id,omitempty" require:"true"`
}

func (s DeleteBucketTagsResponse) String() string {
	return tea.Prettify(s)
}

func (s DeleteBucketTagsResponse) GoString() string {
	return s.String()
}

func (s *DeleteBucketTagsResponse) SetRequestId(v string) *DeleteBucketTagsResponse {
	s.RequestId = &v
	return s
}

type GetBucketWebsiteRequest struct {
	// BucketName
	BucketName *string `json:"BucketName,omitempty" xml:"BucketName,omitempty" require:"true" pattern:"[a-zA-Z0-9-_]+"`
}

func (s GetBucketWebsiteRequest) String() string {
	return tea.Prettify(s)
}

func (s GetBucketWebsiteRequest) GoString() string {
	return s.String()
}

func (s *GetBucketWebsiteRequest) SetBucketName(v string) *GetBucketWebsiteRequest {
	s.BucketName = &v
	return s
}

type GetBucketWebsiteResponse struct {
	// x-oss-request-id
	RequestId *string `json:"x-oss-request-id,omitempty" xml:"x-oss-request-id,omitempty" require:"true"`
	// WebsiteConfiguration
	WebsiteConfiguration *GetBucketWebsiteResponseWebsiteConfiguration `json:"WebsiteConfiguration,omitempty" xml:"WebsiteConfiguration,omitempty" require:"true" type:"Struct"`
}

func (s GetBucketWebsiteResponse) String() string {
	return tea.Prettify(s)
}

func (s GetBucketWebsiteResponse) GoString() string {
	return s.String()
}

func (s *GetBucketWebsiteResponse) SetRequestId(v string) *GetBucketWebsiteResponse {
	s.RequestId = &v
	return s
}

func (s *GetBucketWebsiteResponse) SetWebsiteConfiguration(v *GetBucketWebsiteResponseWebsiteConfiguration) *GetBucketWebsiteResponse {
	s.WebsiteConfiguration = v
	return s
}

type GetBucketWebsiteResponseWebsiteConfiguration struct {
	// IndexDocument
	IndexDocument *GetBucketWebsiteResponseWebsiteConfigurationIndexDocument `json:"IndexDocument,omitempty" xml:"IndexDocument,omitempty" require:"true" type:"Struct"`
	// ErrorDocument
	ErrorDocument *GetBucketWebsiteResponseWebsiteConfigurationErrorDocument `json:"ErrorDocument,omitempty" xml:"ErrorDocument,omitempty" require:"true" type:"Struct"`
	// RoutingRules
	RoutingRules *GetBucketWebsiteResponseWebsiteConfigurationRoutingRules `json:"RoutingRules,omitempty" xml:"RoutingRules,omitempty" require:"true" type:"Struct"`
}

func (s GetBucketWebsiteResponseWebsiteConfiguration) String() string {
	return tea.Prettify(s)
}

func (s GetBucketWebsiteResponseWebsiteConfiguration) GoString() string {
	return s.String()
}

func (s *GetBucketWebsiteResponseWebsiteConfiguration) SetIndexDocument(v *GetBucketWebsiteResponseWebsiteConfigurationIndexDocument) *GetBucketWebsiteResponseWebsiteConfiguration {
	s.IndexDocument = v
	return s
}

func (s *GetBucketWebsiteResponseWebsiteConfiguration) SetErrorDocument(v *GetBucketWebsiteResponseWebsiteConfigurationErrorDocument) *GetBucketWebsiteResponseWebsiteConfiguration {
	s.ErrorDocument = v
	return s
}

func (s *GetBucketWebsiteResponseWebsiteConfiguration) SetRoutingRules(v *GetBucketWebsiteResponseWebsiteConfigurationRoutingRules) *GetBucketWebsiteResponseWebsiteConfiguration {
	s.RoutingRules = v
	return s
}

type GetBucketWebsiteResponseWebsiteConfigurationIndexDocument struct {
	// Suffix
	Suffix *string `json:"Suffix,omitempty" xml:"Suffix,omitempty"`
}

func (s GetBucketWebsiteResponseWebsiteConfigurationIndexDocument) String() string {
	return tea.Prettify(s)
}

func (s GetBucketWebsiteResponseWebsiteConfigurationIndexDocument) GoString() string {
	return s.String()
}

func (s *GetBucketWebsiteResponseWebsiteConfigurationIndexDocument) SetSuffix(v string) *GetBucketWebsiteResponseWebsiteConfigurationIndexDocument {
	s.Suffix = &v
	return s
}

type GetBucketWebsiteResponseWebsiteConfigurationErrorDocument struct {
	// Key
	Key *string `json:"Key,omitempty" xml:"Key,omitempty"`
}

func (s GetBucketWebsiteResponseWebsiteConfigurationErrorDocument) String() string {
	return tea.Prettify(s)
}

func (s GetBucketWebsiteResponseWebsiteConfigurationErrorDocument) GoString() string {
	return s.String()
}

func (s *GetBucketWebsiteResponseWebsiteConfigurationErrorDocument) SetKey(v string) *GetBucketWebsiteResponseWebsiteConfigurationErrorDocument {
	s.Key = &v
	return s
}

type GetBucketWebsiteResponseWebsiteConfigurationRoutingRules struct {
	// RoutingRule
	RoutingRule []*GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRule `json:"RoutingRule,omitempty" xml:"RoutingRule,omitempty" type:"Repeated"`
}

func (s GetBucketWebsiteResponseWebsiteConfigurationRoutingRules) String() string {
	return tea.Prettify(s)
}

func (s GetBucketWebsiteResponseWebsiteConfigurationRoutingRules) GoString() string {
	return s.String()
}

func (s *GetBucketWebsiteResponseWebsiteConfigurationRoutingRules) SetRoutingRule(v []*GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRule) *GetBucketWebsiteResponseWebsiteConfigurationRoutingRules {
	s.RoutingRule = v
	return s
}

type GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRule struct {
	// RuleNumber
	RuleNumber *int `json:"RuleNumber,omitempty" xml:"RuleNumber,omitempty"`
	// Condition
	Condition *GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleCondition `json:"Condition,omitempty" xml:"Condition,omitempty" require:"true" type:"Struct"`
	// Redirect
	Redirect *GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirect `json:"Redirect,omitempty" xml:"Redirect,omitempty" require:"true" type:"Struct"`
}

func (s GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRule) String() string {
	return tea.Prettify(s)
}

func (s GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRule) GoString() string {
	return s.String()
}

func (s *GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRule) SetRuleNumber(v int) *GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRule {
	s.RuleNumber = &v
	return s
}

func (s *GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRule) SetCondition(v *GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleCondition) *GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRule {
	s.Condition = v
	return s
}

func (s *GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRule) SetRedirect(v *GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirect) *GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRule {
	s.Redirect = v
	return s
}

type GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleCondition struct {
	// KeyPrefixEquals
	KeyPrefixEquals *string `json:"KeyPrefixEquals,omitempty" xml:"KeyPrefixEquals,omitempty"`
	// HttpErrorCodeReturnedEquals
	HttpErrorCodeReturnedEquals *string `json:"HttpErrorCodeReturnedEquals,omitempty" xml:"HttpErrorCodeReturnedEquals,omitempty"`
	// IncludeHeader
	IncludeHeader *GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleConditionIncludeHeader `json:"IncludeHeader,omitempty" xml:"IncludeHeader,omitempty" require:"true" type:"Struct"`
}

func (s GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleCondition) String() string {
	return tea.Prettify(s)
}

func (s GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleCondition) GoString() string {
	return s.String()
}

func (s *GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleCondition) SetKeyPrefixEquals(v string) *GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleCondition {
	s.KeyPrefixEquals = &v
	return s
}

func (s *GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleCondition) SetHttpErrorCodeReturnedEquals(v string) *GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleCondition {
	s.HttpErrorCodeReturnedEquals = &v
	return s
}

func (s *GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleCondition) SetIncludeHeader(v *GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleConditionIncludeHeader) *GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleCondition {
	s.IncludeHeader = v
	return s
}

type GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleConditionIncludeHeader struct {
	// Key
	Key *string `json:"Key,omitempty" xml:"Key,omitempty"`
	// Equals
	Equals *string `json:"Equals,omitempty" xml:"Equals,omitempty"`
}

func (s GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleConditionIncludeHeader) String() string {
	return tea.Prettify(s)
}

func (s GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleConditionIncludeHeader) GoString() string {
	return s.String()
}

func (s *GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleConditionIncludeHeader) SetKey(v string) *GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleConditionIncludeHeader {
	s.Key = &v
	return s
}

func (s *GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleConditionIncludeHeader) SetEquals(v string) *GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleConditionIncludeHeader {
	s.Equals = &v
	return s
}

type GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirect struct {
	// RedirectType
	RedirectType *string `json:"RedirectType,omitempty" xml:"RedirectType,omitempty"`
	// PassQueryString
	PassQueryString *bool `json:"PassQueryString,omitempty" xml:"PassQueryString,omitempty"`
	// MirrorURL
	MirrorURL *string `json:"MirrorURL,omitempty" xml:"MirrorURL,omitempty"`
	// MirrorPassQueryString
	MirrorPassQueryString *bool `json:"MirrorPassQueryString,omitempty" xml:"MirrorPassQueryString,omitempty"`
	// MirrorFollowRedirect
	MirrorFollowRedirect *bool `json:"MirrorFollowRedirect,omitempty" xml:"MirrorFollowRedirect,omitempty"`
	// MirrorCheckMd5
	MirrorCheckMd5 *bool `json:"MirrorCheckMd5,omitempty" xml:"MirrorCheckMd5,omitempty"`
	// Protocol
	Protocol *string `json:"Protocol,omitempty" xml:"Protocol,omitempty"`
	// HostName
	HostName *string `json:"HostName,omitempty" xml:"HostName,omitempty"`
	// HttpRedirectCode
	HttpRedirectCode *string `json:"HttpRedirectCode,omitempty" xml:"HttpRedirectCode,omitempty"`
	// ReplaceKeyPrefixWith
	ReplaceKeyPrefixWith *string `json:"ReplaceKeyPrefixWith,omitempty" xml:"ReplaceKeyPrefixWith,omitempty"`
	// ReplaceKeyWith
	ReplaceKeyWith *string `json:"ReplaceKeyWith,omitempty" xml:"ReplaceKeyWith,omitempty"`
	// MirrorHeaders
	MirrorHeaders *GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeaders `json:"MirrorHeaders,omitempty" xml:"MirrorHeaders,omitempty" require:"true" type:"Struct"`
}

func (s GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirect) String() string {
	return tea.Prettify(s)
}

func (s GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirect) GoString() string {
	return s.String()
}

func (s *GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirect) SetRedirectType(v string) *GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirect {
	s.RedirectType = &v
	return s
}

func (s *GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirect) SetPassQueryString(v bool) *GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirect {
	s.PassQueryString = &v
	return s
}

func (s *GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirect) SetMirrorURL(v string) *GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirect {
	s.MirrorURL = &v
	return s
}

func (s *GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirect) SetMirrorPassQueryString(v bool) *GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirect {
	s.MirrorPassQueryString = &v
	return s
}

func (s *GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirect) SetMirrorFollowRedirect(v bool) *GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirect {
	s.MirrorFollowRedirect = &v
	return s
}

func (s *GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirect) SetMirrorCheckMd5(v bool) *GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirect {
	s.MirrorCheckMd5 = &v
	return s
}

func (s *GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirect) SetProtocol(v string) *GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirect {
	s.Protocol = &v
	return s
}

func (s *GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirect) SetHostName(v string) *GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirect {
	s.HostName = &v
	return s
}

func (s *GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirect) SetHttpRedirectCode(v string) *GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirect {
	s.HttpRedirectCode = &v
	return s
}

func (s *GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirect) SetReplaceKeyPrefixWith(v string) *GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirect {
	s.ReplaceKeyPrefixWith = &v
	return s
}

func (s *GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirect) SetReplaceKeyWith(v string) *GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirect {
	s.ReplaceKeyWith = &v
	return s
}

func (s *GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirect) SetMirrorHeaders(v *GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeaders) *GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirect {
	s.MirrorHeaders = v
	return s
}

type GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeaders struct {
	// PassAll
	PassAll *bool `json:"PassAll,omitempty" xml:"PassAll,omitempty"`
	// Pass
	Pass *string `json:"Pass,omitempty" xml:"Pass,omitempty"`
	// Remove
	Remove *string `json:"Remove,omitempty" xml:"Remove,omitempty"`
	// Set
	Set *GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeadersSet `json:"Set,omitempty" xml:"Set,omitempty" require:"true" type:"Struct"`
}

func (s GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeaders) String() string {
	return tea.Prettify(s)
}

func (s GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeaders) GoString() string {
	return s.String()
}

func (s *GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeaders) SetPassAll(v bool) *GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeaders {
	s.PassAll = &v
	return s
}

func (s *GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeaders) SetPass(v string) *GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeaders {
	s.Pass = &v
	return s
}

func (s *GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeaders) SetRemove(v string) *GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeaders {
	s.Remove = &v
	return s
}

func (s *GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeaders) SetSet(v *GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeadersSet) *GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeaders {
	s.Set = v
	return s
}

type GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeadersSet struct {
	// Key
	Key *string `json:"Key,omitempty" xml:"Key,omitempty"`
	// Value
	Value *string `json:"Value,omitempty" xml:"Value,omitempty"`
}

func (s GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeadersSet) String() string {
	return tea.Prettify(s)
}

func (s GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeadersSet) GoString() string {
	return s.String()
}

func (s *GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeadersSet) SetKey(v string) *GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeadersSet {
	s.Key = &v
	return s
}

func (s *GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeadersSet) SetValue(v string) *GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeadersSet {
	s.Value = &v
	return s
}

type DeleteLiveChannelRequest struct {
	// BucketName
	BucketName *string `json:"BucketName,omitempty" xml:"BucketName,omitempty" require:"true" pattern:"[a-zA-Z0-9-_]+"`
	// ChannelName
	ChannelName *string `json:"ChannelName,omitempty" xml:"ChannelName,omitempty" require:"true"`
}

func (s DeleteLiveChannelRequest) String() string {
	return tea.Prettify(s)
}

func (s DeleteLiveChannelRequest) GoString() string {
	return s.String()
}

func (s *DeleteLiveChannelRequest) SetBucketName(v string) *DeleteLiveChannelRequest {
	s.BucketName = &v
	return s
}

func (s *DeleteLiveChannelRequest) SetChannelName(v string) *DeleteLiveChannelRequest {
	s.ChannelName = &v
	return s
}

type DeleteLiveChannelResponse struct {
	// x-oss-request-id
	RequestId *string `json:"x-oss-request-id,omitempty" xml:"x-oss-request-id,omitempty" require:"true"`
}

func (s DeleteLiveChannelResponse) String() string {
	return tea.Prettify(s)
}

func (s DeleteLiveChannelResponse) GoString() string {
	return s.String()
}

func (s *DeleteLiveChannelResponse) SetRequestId(v string) *DeleteLiveChannelResponse {
	s.RequestId = &v
	return s
}

type GetBucketLocationRequest struct {
	// BucketName
	BucketName *string `json:"BucketName,omitempty" xml:"BucketName,omitempty" require:"true" pattern:"[a-zA-Z0-9-_]+"`
}

func (s GetBucketLocationRequest) String() string {
	return tea.Prettify(s)
}

func (s GetBucketLocationRequest) GoString() string {
	return s.String()
}

func (s *GetBucketLocationRequest) SetBucketName(v string) *GetBucketLocationRequest {
	s.BucketName = &v
	return s
}

type GetBucketLocationResponse struct {
	// x-oss-request-id
	RequestId *string `json:"x-oss-request-id,omitempty" xml:"x-oss-request-id,omitempty" require:"true"`
	// LocationConstraint
	LocationConstraint *string `json:"LocationConstraint,omitempty" xml:"LocationConstraint,omitempty" require:"true"`
}

func (s GetBucketLocationResponse) String() string {
	return tea.Prettify(s)
}

func (s GetBucketLocationResponse) GoString() string {
	return s.String()
}

func (s *GetBucketLocationResponse) SetRequestId(v string) *GetBucketLocationResponse {
	s.RequestId = &v
	return s
}

func (s *GetBucketLocationResponse) SetLocationConstraint(v string) *GetBucketLocationResponse {
	s.LocationConstraint = &v
	return s
}

type ListLiveChannelRequest struct {
	// BucketName
	BucketName *string `json:"BucketName,omitempty" xml:"BucketName,omitempty" require:"true" pattern:"[a-zA-Z0-9-_]+"`
	// Filter
	Filter *ListLiveChannelRequestFilter `json:"Filter,omitempty" xml:"Filter,omitempty" type:"Struct"`
}

func (s ListLiveChannelRequest) String() string {
	return tea.Prettify(s)
}

func (s ListLiveChannelRequest) GoString() string {
	return s.String()
}

func (s *ListLiveChannelRequest) SetBucketName(v string) *ListLiveChannelRequest {
	s.BucketName = &v
	return s
}

func (s *ListLiveChannelRequest) SetFilter(v *ListLiveChannelRequestFilter) *ListLiveChannelRequest {
	s.Filter = v
	return s
}

type ListLiveChannelRequestFilter struct {
	// marker
	Marker *string `json:"marker,omitempty" xml:"marker,omitempty"`
	// max-keys
	MaxKeys *string `json:"max-keys,omitempty" xml:"max-keys,omitempty"`
	// prefix
	Prefix *string `json:"prefix,omitempty" xml:"prefix,omitempty"`
}

func (s ListLiveChannelRequestFilter) String() string {
	return tea.Prettify(s)
}

func (s ListLiveChannelRequestFilter) GoString() string {
	return s.String()
}

func (s *ListLiveChannelRequestFilter) SetMarker(v string) *ListLiveChannelRequestFilter {
	s.Marker = &v
	return s
}

func (s *ListLiveChannelRequestFilter) SetMaxKeys(v string) *ListLiveChannelRequestFilter {
	s.MaxKeys = &v
	return s
}

func (s *ListLiveChannelRequestFilter) SetPrefix(v string) *ListLiveChannelRequestFilter {
	s.Prefix = &v
	return s
}

type ListLiveChannelResponse struct {
	// x-oss-request-id
	RequestId *string `json:"x-oss-request-id,omitempty" xml:"x-oss-request-id,omitempty" require:"true"`
	// ListLiveChannelResult
	ListLiveChannelResult *ListLiveChannelResponseListLiveChannelResult `json:"ListLiveChannelResult,omitempty" xml:"ListLiveChannelResult,omitempty" require:"true" type:"Struct"`
}

func (s ListLiveChannelResponse) String() string {
	return tea.Prettify(s)
}

func (s ListLiveChannelResponse) GoString() string {
	return s.String()
}

func (s *ListLiveChannelResponse) SetRequestId(v string) *ListLiveChannelResponse {
	s.RequestId = &v
	return s
}

func (s *ListLiveChannelResponse) SetListLiveChannelResult(v *ListLiveChannelResponseListLiveChannelResult) *ListLiveChannelResponse {
	s.ListLiveChannelResult = v
	return s
}

type ListLiveChannelResponseListLiveChannelResult struct {
	// Prefix
	Prefix *string `json:"Prefix,omitempty" xml:"Prefix,omitempty"`
	// Marker
	Marker *string `json:"Marker,omitempty" xml:"Marker,omitempty"`
	// MaxKeys
	MaxKeys *string `json:"MaxKeys,omitempty" xml:"MaxKeys,omitempty"`
	// IsTruncated
	IsTruncated *string `json:"IsTruncated,omitempty" xml:"IsTruncated,omitempty"`
	// NextMarker
	NextMarker *string `json:"NextMarker,omitempty" xml:"NextMarker,omitempty"`
	// LiveChannel
	LiveChannel *ListLiveChannelResponseListLiveChannelResultLiveChannel `json:"LiveChannel,omitempty" xml:"LiveChannel,omitempty" require:"true" type:"Struct"`
}

func (s ListLiveChannelResponseListLiveChannelResult) String() string {
	return tea.Prettify(s)
}

func (s ListLiveChannelResponseListLiveChannelResult) GoString() string {
	return s.String()
}

func (s *ListLiveChannelResponseListLiveChannelResult) SetPrefix(v string) *ListLiveChannelResponseListLiveChannelResult {
	s.Prefix = &v
	return s
}

func (s *ListLiveChannelResponseListLiveChannelResult) SetMarker(v string) *ListLiveChannelResponseListLiveChannelResult {
	s.Marker = &v
	return s
}

func (s *ListLiveChannelResponseListLiveChannelResult) SetMaxKeys(v string) *ListLiveChannelResponseListLiveChannelResult {
	s.MaxKeys = &v
	return s
}

func (s *ListLiveChannelResponseListLiveChannelResult) SetIsTruncated(v string) *ListLiveChannelResponseListLiveChannelResult {
	s.IsTruncated = &v
	return s
}

func (s *ListLiveChannelResponseListLiveChannelResult) SetNextMarker(v string) *ListLiveChannelResponseListLiveChannelResult {
	s.NextMarker = &v
	return s
}

func (s *ListLiveChannelResponseListLiveChannelResult) SetLiveChannel(v *ListLiveChannelResponseListLiveChannelResultLiveChannel) *ListLiveChannelResponseListLiveChannelResult {
	s.LiveChannel = v
	return s
}

type ListLiveChannelResponseListLiveChannelResultLiveChannel struct {
	// Name
	Name *string `json:"Name,omitempty" xml:"Name,omitempty"`
	// Description
	Description *string `json:"Description,omitempty" xml:"Description,omitempty"`
	// Status
	Status *string `json:"Status,omitempty" xml:"Status,omitempty"`
	// LastModified
	LastModified *string `json:"LastModified,omitempty" xml:"LastModified,omitempty"`
	// PublishUrls
	PublishUrls *ListLiveChannelResponseListLiveChannelResultLiveChannelPublishUrls `json:"PublishUrls,omitempty" xml:"PublishUrls,omitempty" require:"true" type:"Struct"`
	// PlayUrls
	PlayUrls *ListLiveChannelResponseListLiveChannelResultLiveChannelPlayUrls `json:"PlayUrls,omitempty" xml:"PlayUrls,omitempty" require:"true" type:"Struct"`
}

func (s ListLiveChannelResponseListLiveChannelResultLiveChannel) String() string {
	return tea.Prettify(s)
}

func (s ListLiveChannelResponseListLiveChannelResultLiveChannel) GoString() string {
	return s.String()
}

func (s *ListLiveChannelResponseListLiveChannelResultLiveChannel) SetName(v string) *ListLiveChannelResponseListLiveChannelResultLiveChannel {
	s.Name = &v
	return s
}

func (s *ListLiveChannelResponseListLiveChannelResultLiveChannel) SetDescription(v string) *ListLiveChannelResponseListLiveChannelResultLiveChannel {
	s.Description = &v
	return s
}

func (s *ListLiveChannelResponseListLiveChannelResultLiveChannel) SetStatus(v string) *ListLiveChannelResponseListLiveChannelResultLiveChannel {
	s.Status = &v
	return s
}

func (s *ListLiveChannelResponseListLiveChannelResultLiveChannel) SetLastModified(v string) *ListLiveChannelResponseListLiveChannelResultLiveChannel {
	s.LastModified = &v
	return s
}

func (s *ListLiveChannelResponseListLiveChannelResultLiveChannel) SetPublishUrls(v *ListLiveChannelResponseListLiveChannelResultLiveChannelPublishUrls) *ListLiveChannelResponseListLiveChannelResultLiveChannel {
	s.PublishUrls = v
	return s
}

func (s *ListLiveChannelResponseListLiveChannelResultLiveChannel) SetPlayUrls(v *ListLiveChannelResponseListLiveChannelResultLiveChannelPlayUrls) *ListLiveChannelResponseListLiveChannelResultLiveChannel {
	s.PlayUrls = v
	return s
}

type ListLiveChannelResponseListLiveChannelResultLiveChannelPublishUrls struct {
	// Url
	Url *string `json:"Url,omitempty" xml:"Url,omitempty"`
}

func (s ListLiveChannelResponseListLiveChannelResultLiveChannelPublishUrls) String() string {
	return tea.Prettify(s)
}

func (s ListLiveChannelResponseListLiveChannelResultLiveChannelPublishUrls) GoString() string {
	return s.String()
}

func (s *ListLiveChannelResponseListLiveChannelResultLiveChannelPublishUrls) SetUrl(v string) *ListLiveChannelResponseListLiveChannelResultLiveChannelPublishUrls {
	s.Url = &v
	return s
}

type ListLiveChannelResponseListLiveChannelResultLiveChannelPlayUrls struct {
	// Url
	Url *string `json:"Url,omitempty" xml:"Url,omitempty"`
}

func (s ListLiveChannelResponseListLiveChannelResultLiveChannelPlayUrls) String() string {
	return tea.Prettify(s)
}

func (s ListLiveChannelResponseListLiveChannelResultLiveChannelPlayUrls) GoString() string {
	return s.String()
}

func (s *ListLiveChannelResponseListLiveChannelResultLiveChannelPlayUrls) SetUrl(v string) *ListLiveChannelResponseListLiveChannelResultLiveChannelPlayUrls {
	s.Url = &v
	return s
}

type GetObjectMetaRequest struct {
	// BucketName
	BucketName *string `json:"BucketName,omitempty" xml:"BucketName,omitempty" require:"true" pattern:"[a-zA-Z0-9-_]+"`
	// ObjectName
	ObjectName *string `json:"ObjectName,omitempty" xml:"ObjectName,omitempty" require:"true"`
}

func (s GetObjectMetaRequest) String() string {
	return tea.Prettify(s)
}

func (s GetObjectMetaRequest) GoString() string {
	return s.String()
}

func (s *GetObjectMetaRequest) SetBucketName(v string) *GetObjectMetaRequest {
	s.BucketName = &v
	return s
}

func (s *GetObjectMetaRequest) SetObjectName(v string) *GetObjectMetaRequest {
	s.ObjectName = &v
	return s
}

type GetObjectMetaResponse struct {
	// x-oss-request-id
	RequestId *string `json:"x-oss-request-id,omitempty" xml:"x-oss-request-id,omitempty" require:"true"`
	// ETag
	ETag *string `json:"etag,omitempty" xml:"etag,omitempty" require:"true"`
	// Content-Length
	ContentLength *string `json:"content-length,omitempty" xml:"content-length,omitempty" require:"true"`
	// Last-Modified
	LastModified *string `json:"last-modified,omitempty" xml:"last-modified,omitempty" require:"true"`
}

func (s GetObjectMetaResponse) String() string {
	return tea.Prettify(s)
}

func (s GetObjectMetaResponse) GoString() string {
	return s.String()
}

func (s *GetObjectMetaResponse) SetRequestId(v string) *GetObjectMetaResponse {
	s.RequestId = &v
	return s
}

func (s *GetObjectMetaResponse) SetETag(v string) *GetObjectMetaResponse {
	s.ETag = &v
	return s
}

func (s *GetObjectMetaResponse) SetContentLength(v string) *GetObjectMetaResponse {
	s.ContentLength = &v
	return s
}

func (s *GetObjectMetaResponse) SetLastModified(v string) *GetObjectMetaResponse {
	s.LastModified = &v
	return s
}

type GetBucketAclRequest struct {
	// BucketName
	BucketName *string `json:"BucketName,omitempty" xml:"BucketName,omitempty" require:"true" pattern:"[a-zA-Z0-9-_]+"`
}

func (s GetBucketAclRequest) String() string {
	return tea.Prettify(s)
}

func (s GetBucketAclRequest) GoString() string {
	return s.String()
}

func (s *GetBucketAclRequest) SetBucketName(v string) *GetBucketAclRequest {
	s.BucketName = &v
	return s
}

type GetBucketAclResponse struct {
	// x-oss-request-id
	RequestId *string `json:"x-oss-request-id,omitempty" xml:"x-oss-request-id,omitempty" require:"true"`
	// AccessControlPolicy
	AccessControlPolicy *GetBucketAclResponseAccessControlPolicy `json:"AccessControlPolicy,omitempty" xml:"AccessControlPolicy,omitempty" require:"true" type:"Struct"`
}

func (s GetBucketAclResponse) String() string {
	return tea.Prettify(s)
}

func (s GetBucketAclResponse) GoString() string {
	return s.String()
}

func (s *GetBucketAclResponse) SetRequestId(v string) *GetBucketAclResponse {
	s.RequestId = &v
	return s
}

func (s *GetBucketAclResponse) SetAccessControlPolicy(v *GetBucketAclResponseAccessControlPolicy) *GetBucketAclResponse {
	s.AccessControlPolicy = v
	return s
}

type GetBucketAclResponseAccessControlPolicy struct {
	// Owner
	Owner *GetBucketAclResponseAccessControlPolicyOwner `json:"Owner,omitempty" xml:"Owner,omitempty" require:"true" type:"Struct"`
	// AccessControlList
	AccessControlList *GetBucketAclResponseAccessControlPolicyAccessControlList `json:"AccessControlList,omitempty" xml:"AccessControlList,omitempty" require:"true" type:"Struct"`
}

func (s GetBucketAclResponseAccessControlPolicy) String() string {
	return tea.Prettify(s)
}

func (s GetBucketAclResponseAccessControlPolicy) GoString() string {
	return s.String()
}

func (s *GetBucketAclResponseAccessControlPolicy) SetOwner(v *GetBucketAclResponseAccessControlPolicyOwner) *GetBucketAclResponseAccessControlPolicy {
	s.Owner = v
	return s
}

func (s *GetBucketAclResponseAccessControlPolicy) SetAccessControlList(v *GetBucketAclResponseAccessControlPolicyAccessControlList) *GetBucketAclResponseAccessControlPolicy {
	s.AccessControlList = v
	return s
}

type GetBucketAclResponseAccessControlPolicyOwner struct {
	// ID
	ID *string `json:"ID,omitempty" xml:"ID,omitempty"`
	// DisplayName
	DisplayName *string `json:"DisplayName,omitempty" xml:"DisplayName,omitempty"`
}

func (s GetBucketAclResponseAccessControlPolicyOwner) String() string {
	return tea.Prettify(s)
}

func (s GetBucketAclResponseAccessControlPolicyOwner) GoString() string {
	return s.String()
}

func (s *GetBucketAclResponseAccessControlPolicyOwner) SetID(v string) *GetBucketAclResponseAccessControlPolicyOwner {
	s.ID = &v
	return s
}

func (s *GetBucketAclResponseAccessControlPolicyOwner) SetDisplayName(v string) *GetBucketAclResponseAccessControlPolicyOwner {
	s.DisplayName = &v
	return s
}

type GetBucketAclResponseAccessControlPolicyAccessControlList struct {
	// Grant
	Grant *string `json:"Grant,omitempty" xml:"Grant,omitempty"`
}

func (s GetBucketAclResponseAccessControlPolicyAccessControlList) String() string {
	return tea.Prettify(s)
}

func (s GetBucketAclResponseAccessControlPolicyAccessControlList) GoString() string {
	return s.String()
}

func (s *GetBucketAclResponseAccessControlPolicyAccessControlList) SetGrant(v string) *GetBucketAclResponseAccessControlPolicyAccessControlList {
	s.Grant = &v
	return s
}

type ListPartsRequest struct {
	// BucketName
	BucketName *string `json:"BucketName,omitempty" xml:"BucketName,omitempty" require:"true" pattern:"[a-zA-Z0-9-_]+"`
	// ObjectName
	ObjectName *string `json:"ObjectName,omitempty" xml:"ObjectName,omitempty" require:"true"`
	// Filter
	Filter *ListPartsRequestFilter `json:"Filter,omitempty" xml:"Filter,omitempty" require:"true" type:"Struct"`
}

func (s ListPartsRequest) String() string {
	return tea.Prettify(s)
}

func (s ListPartsRequest) GoString() string {
	return s.String()
}

func (s *ListPartsRequest) SetBucketName(v string) *ListPartsRequest {
	s.BucketName = &v
	return s
}

func (s *ListPartsRequest) SetObjectName(v string) *ListPartsRequest {
	s.ObjectName = &v
	return s
}

func (s *ListPartsRequest) SetFilter(v *ListPartsRequestFilter) *ListPartsRequest {
	s.Filter = v
	return s
}

type ListPartsRequestFilter struct {
	// uploadId
	UploadId *string `json:"uploadId,omitempty" xml:"uploadId,omitempty" require:"true" signed:"true"`
	// max-parts
	MaxParts *int `json:"max-parts,omitempty" xml:"max-parts,omitempty"`
	// part-number-marker
	PartNumberMarker *int `json:"part-number-marker,omitempty" xml:"part-number-marker,omitempty"`
	// Encoding-type
	EncodingType *string `json:"Encoding-type,omitempty" xml:"Encoding-type,omitempty"`
}

func (s ListPartsRequestFilter) String() string {
	return tea.Prettify(s)
}

func (s ListPartsRequestFilter) GoString() string {
	return s.String()
}

func (s *ListPartsRequestFilter) SetUploadId(v string) *ListPartsRequestFilter {
	s.UploadId = &v
	return s
}

func (s *ListPartsRequestFilter) SetMaxParts(v int) *ListPartsRequestFilter {
	s.MaxParts = &v
	return s
}

func (s *ListPartsRequestFilter) SetPartNumberMarker(v int) *ListPartsRequestFilter {
	s.PartNumberMarker = &v
	return s
}

func (s *ListPartsRequestFilter) SetEncodingType(v string) *ListPartsRequestFilter {
	s.EncodingType = &v
	return s
}

type ListPartsResponse struct {
	// x-oss-request-id
	RequestId *string `json:"x-oss-request-id,omitempty" xml:"x-oss-request-id,omitempty" require:"true"`
	// ListPartsResult
	ListPartsResult *ListPartsResponseListPartsResult `json:"ListPartsResult,omitempty" xml:"ListPartsResult,omitempty" require:"true" type:"Struct"`
}

func (s ListPartsResponse) String() string {
	return tea.Prettify(s)
}

func (s ListPartsResponse) GoString() string {
	return s.String()
}

func (s *ListPartsResponse) SetRequestId(v string) *ListPartsResponse {
	s.RequestId = &v
	return s
}

func (s *ListPartsResponse) SetListPartsResult(v *ListPartsResponseListPartsResult) *ListPartsResponse {
	s.ListPartsResult = v
	return s
}

type ListPartsResponseListPartsResult struct {
	// Bucket
	Bucket *string `json:"Bucket,omitempty" xml:"Bucket,omitempty"`
	// EncodingType
	EncodingType *string `json:"EncodingType,omitempty" xml:"EncodingType,omitempty"`
	// Key
	Key *string `json:"Key,omitempty" xml:"Key,omitempty"`
	// UploadId
	UploadId *string `json:"UploadId,omitempty" xml:"UploadId,omitempty"`
	// PartNumberMarker
	PartNumberMarker *string `json:"PartNumberMarker,omitempty" xml:"PartNumberMarker,omitempty"`
	// NextPartNumberMarker
	NextPartNumberMarker *string `json:"NextPartNumberMarker,omitempty" xml:"NextPartNumberMarker,omitempty"`
	// MaxParts
	MaxParts *string `json:"MaxParts,omitempty" xml:"MaxParts,omitempty"`
	// IsTruncated
	IsTruncated *string `json:"IsTruncated,omitempty" xml:"IsTruncated,omitempty"`
	// Part
	Part []*ListPartsResponseListPartsResultPart `json:"Part,omitempty" xml:"Part,omitempty" type:"Repeated"`
}

func (s ListPartsResponseListPartsResult) String() string {
	return tea.Prettify(s)
}

func (s ListPartsResponseListPartsResult) GoString() string {
	return s.String()
}

func (s *ListPartsResponseListPartsResult) SetBucket(v string) *ListPartsResponseListPartsResult {
	s.Bucket = &v
	return s
}

func (s *ListPartsResponseListPartsResult) SetEncodingType(v string) *ListPartsResponseListPartsResult {
	s.EncodingType = &v
	return s
}

func (s *ListPartsResponseListPartsResult) SetKey(v string) *ListPartsResponseListPartsResult {
	s.Key = &v
	return s
}

func (s *ListPartsResponseListPartsResult) SetUploadId(v string) *ListPartsResponseListPartsResult {
	s.UploadId = &v
	return s
}

func (s *ListPartsResponseListPartsResult) SetPartNumberMarker(v string) *ListPartsResponseListPartsResult {
	s.PartNumberMarker = &v
	return s
}

func (s *ListPartsResponseListPartsResult) SetNextPartNumberMarker(v string) *ListPartsResponseListPartsResult {
	s.NextPartNumberMarker = &v
	return s
}

func (s *ListPartsResponseListPartsResult) SetMaxParts(v string) *ListPartsResponseListPartsResult {
	s.MaxParts = &v
	return s
}

func (s *ListPartsResponseListPartsResult) SetIsTruncated(v string) *ListPartsResponseListPartsResult {
	s.IsTruncated = &v
	return s
}

func (s *ListPartsResponseListPartsResult) SetPart(v []*ListPartsResponseListPartsResultPart) *ListPartsResponseListPartsResult {
	s.Part = v
	return s
}

type ListPartsResponseListPartsResultPart struct {
	// PartNumber
	PartNumber *string `json:"PartNumber,omitempty" xml:"PartNumber,omitempty"`
	// LastModified
	LastModified *string `json:"LastModified,omitempty" xml:"LastModified,omitempty"`
	// ETag
	ETag *string `json:"ETag,omitempty" xml:"ETag,omitempty"`
	// Size
	Size *string `json:"Size,omitempty" xml:"Size,omitempty"`
}

func (s ListPartsResponseListPartsResultPart) String() string {
	return tea.Prettify(s)
}

func (s ListPartsResponseListPartsResultPart) GoString() string {
	return s.String()
}

func (s *ListPartsResponseListPartsResultPart) SetPartNumber(v string) *ListPartsResponseListPartsResultPart {
	s.PartNumber = &v
	return s
}

func (s *ListPartsResponseListPartsResultPart) SetLastModified(v string) *ListPartsResponseListPartsResultPart {
	s.LastModified = &v
	return s
}

func (s *ListPartsResponseListPartsResultPart) SetETag(v string) *ListPartsResponseListPartsResultPart {
	s.ETag = &v
	return s
}

func (s *ListPartsResponseListPartsResultPart) SetSize(v string) *ListPartsResponseListPartsResultPart {
	s.Size = &v
	return s
}

type GetLiveChannelHistoryRequest struct {
	// BucketName
	BucketName *string `json:"BucketName,omitempty" xml:"BucketName,omitempty" require:"true" pattern:"[a-zA-Z0-9-_]+"`
	// ChannelName
	ChannelName *string `json:"ChannelName,omitempty" xml:"ChannelName,omitempty" require:"true"`
	// Filter
	Filter *GetLiveChannelHistoryRequestFilter `json:"Filter,omitempty" xml:"Filter,omitempty" type:"Struct"`
}

func (s GetLiveChannelHistoryRequest) String() string {
	return tea.Prettify(s)
}

func (s GetLiveChannelHistoryRequest) GoString() string {
	return s.String()
}

func (s *GetLiveChannelHistoryRequest) SetBucketName(v string) *GetLiveChannelHistoryRequest {
	s.BucketName = &v
	return s
}

func (s *GetLiveChannelHistoryRequest) SetChannelName(v string) *GetLiveChannelHistoryRequest {
	s.ChannelName = &v
	return s
}

func (s *GetLiveChannelHistoryRequest) SetFilter(v *GetLiveChannelHistoryRequestFilter) *GetLiveChannelHistoryRequest {
	s.Filter = v
	return s
}

type GetLiveChannelHistoryRequestFilter struct {
	// comp
	Comp *string `json:"comp,omitempty" xml:"comp,omitempty" signed:"true"`
}

func (s GetLiveChannelHistoryRequestFilter) String() string {
	return tea.Prettify(s)
}

func (s GetLiveChannelHistoryRequestFilter) GoString() string {
	return s.String()
}

func (s *GetLiveChannelHistoryRequestFilter) SetComp(v string) *GetLiveChannelHistoryRequestFilter {
	s.Comp = &v
	return s
}

type GetLiveChannelHistoryResponse struct {
	// x-oss-request-id
	RequestId *string `json:"x-oss-request-id,omitempty" xml:"x-oss-request-id,omitempty" require:"true"`
	// LiveChannelHistory
	LiveChannelHistory *GetLiveChannelHistoryResponseLiveChannelHistory `json:"LiveChannelHistory,omitempty" xml:"LiveChannelHistory,omitempty" require:"true" type:"Struct"`
}

func (s GetLiveChannelHistoryResponse) String() string {
	return tea.Prettify(s)
}

func (s GetLiveChannelHistoryResponse) GoString() string {
	return s.String()
}

func (s *GetLiveChannelHistoryResponse) SetRequestId(v string) *GetLiveChannelHistoryResponse {
	s.RequestId = &v
	return s
}

func (s *GetLiveChannelHistoryResponse) SetLiveChannelHistory(v *GetLiveChannelHistoryResponseLiveChannelHistory) *GetLiveChannelHistoryResponse {
	s.LiveChannelHistory = v
	return s
}

type GetLiveChannelHistoryResponseLiveChannelHistory struct {
	// LiveRecord
	LiveRecord []*GetLiveChannelHistoryResponseLiveChannelHistoryLiveRecord `json:"LiveRecord,omitempty" xml:"LiveRecord,omitempty" type:"Repeated"`
}

func (s GetLiveChannelHistoryResponseLiveChannelHistory) String() string {
	return tea.Prettify(s)
}

func (s GetLiveChannelHistoryResponseLiveChannelHistory) GoString() string {
	return s.String()
}

func (s *GetLiveChannelHistoryResponseLiveChannelHistory) SetLiveRecord(v []*GetLiveChannelHistoryResponseLiveChannelHistoryLiveRecord) *GetLiveChannelHistoryResponseLiveChannelHistory {
	s.LiveRecord = v
	return s
}

type GetLiveChannelHistoryResponseLiveChannelHistoryLiveRecord struct {
	// StartTime
	StartTime *string `json:"StartTime,omitempty" xml:"StartTime,omitempty"`
	// EndTime
	EndTime *string `json:"EndTime,omitempty" xml:"EndTime,omitempty"`
	// RemoteAddr
	RemoteAddr *string `json:"RemoteAddr,omitempty" xml:"RemoteAddr,omitempty"`
}

func (s GetLiveChannelHistoryResponseLiveChannelHistoryLiveRecord) String() string {
	return tea.Prettify(s)
}

func (s GetLiveChannelHistoryResponseLiveChannelHistoryLiveRecord) GoString() string {
	return s.String()
}

func (s *GetLiveChannelHistoryResponseLiveChannelHistoryLiveRecord) SetStartTime(v string) *GetLiveChannelHistoryResponseLiveChannelHistoryLiveRecord {
	s.StartTime = &v
	return s
}

func (s *GetLiveChannelHistoryResponseLiveChannelHistoryLiveRecord) SetEndTime(v string) *GetLiveChannelHistoryResponseLiveChannelHistoryLiveRecord {
	s.EndTime = &v
	return s
}

func (s *GetLiveChannelHistoryResponseLiveChannelHistoryLiveRecord) SetRemoteAddr(v string) *GetLiveChannelHistoryResponseLiveChannelHistoryLiveRecord {
	s.RemoteAddr = &v
	return s
}

type GetBucketRequest struct {
	// BucketName
	BucketName *string `json:"BucketName,omitempty" xml:"BucketName,omitempty" require:"true" pattern:"[a-zA-Z0-9-_]+"`
	// Filter
	Filter *GetBucketRequestFilter `json:"Filter,omitempty" xml:"Filter,omitempty" type:"Struct"`
}

func (s GetBucketRequest) String() string {
	return tea.Prettify(s)
}

func (s GetBucketRequest) GoString() string {
	return s.String()
}

func (s *GetBucketRequest) SetBucketName(v string) *GetBucketRequest {
	s.BucketName = &v
	return s
}

func (s *GetBucketRequest) SetFilter(v *GetBucketRequestFilter) *GetBucketRequest {
	s.Filter = v
	return s
}

type GetBucketRequestFilter struct {
	// delimiter
	Delimiter *string `json:"delimiter,omitempty" xml:"delimiter,omitempty"`
	// marker
	Marker *string `json:"marker,omitempty" xml:"marker,omitempty"`
	// max-keys
	MaxKeys *string `json:"max-keys,omitempty" xml:"max-keys,omitempty"`
	// prefix
	Prefix *string `json:"prefix,omitempty" xml:"prefix,omitempty"`
	// encoding-type
	EncodingType *string `json:"encoding-type,omitempty" xml:"encoding-type,omitempty"`
}

func (s GetBucketRequestFilter) String() string {
	return tea.Prettify(s)
}

func (s GetBucketRequestFilter) GoString() string {
	return s.String()
}

func (s *GetBucketRequestFilter) SetDelimiter(v string) *GetBucketRequestFilter {
	s.Delimiter = &v
	return s
}

func (s *GetBucketRequestFilter) SetMarker(v string) *GetBucketRequestFilter {
	s.Marker = &v
	return s
}

func (s *GetBucketRequestFilter) SetMaxKeys(v string) *GetBucketRequestFilter {
	s.MaxKeys = &v
	return s
}

func (s *GetBucketRequestFilter) SetPrefix(v string) *GetBucketRequestFilter {
	s.Prefix = &v
	return s
}

func (s *GetBucketRequestFilter) SetEncodingType(v string) *GetBucketRequestFilter {
	s.EncodingType = &v
	return s
}

type GetBucketResponse struct {
	// x-oss-request-id
	RequestId *string `json:"x-oss-request-id,omitempty" xml:"x-oss-request-id,omitempty" require:"true"`
	// ListBucketResult
	ListBucketResult *GetBucketResponseListBucketResult `json:"ListBucketResult,omitempty" xml:"ListBucketResult,omitempty" require:"true" type:"Struct"`
}

func (s GetBucketResponse) String() string {
	return tea.Prettify(s)
}

func (s GetBucketResponse) GoString() string {
	return s.String()
}

func (s *GetBucketResponse) SetRequestId(v string) *GetBucketResponse {
	s.RequestId = &v
	return s
}

func (s *GetBucketResponse) SetListBucketResult(v *GetBucketResponseListBucketResult) *GetBucketResponse {
	s.ListBucketResult = v
	return s
}

type GetBucketResponseListBucketResult struct {
	// Name
	Name *string `json:"Name,omitempty" xml:"Name,omitempty"`
	// Prefix
	Prefix *string `json:"Prefix,omitempty" xml:"Prefix,omitempty"`
	// Marker
	Marker *string `json:"Marker,omitempty" xml:"Marker,omitempty"`
	// MaxKeys
	MaxKeys *string `json:"MaxKeys,omitempty" xml:"MaxKeys,omitempty"`
	// Delimiter
	Delimiter *string `json:"Delimiter,omitempty" xml:"Delimiter,omitempty"`
	// IsTruncated
	IsTruncated *string `json:"IsTruncated,omitempty" xml:"IsTruncated,omitempty"`
	// EncodingType
	EncodingType *string `json:"EncodingType,omitempty" xml:"EncodingType,omitempty"`
	// CommonPrefixes
	CommonPrefixes *string `json:"CommonPrefixes,omitempty" xml:"CommonPrefixes,omitempty"`
	// Contents
	Contents []*GetBucketResponseListBucketResultContents `json:"Contents,omitempty" xml:"Contents,omitempty" type:"Repeated"`
}

func (s GetBucketResponseListBucketResult) String() string {
	return tea.Prettify(s)
}

func (s GetBucketResponseListBucketResult) GoString() string {
	return s.String()
}

func (s *GetBucketResponseListBucketResult) SetName(v string) *GetBucketResponseListBucketResult {
	s.Name = &v
	return s
}

func (s *GetBucketResponseListBucketResult) SetPrefix(v string) *GetBucketResponseListBucketResult {
	s.Prefix = &v
	return s
}

func (s *GetBucketResponseListBucketResult) SetMarker(v string) *GetBucketResponseListBucketResult {
	s.Marker = &v
	return s
}

func (s *GetBucketResponseListBucketResult) SetMaxKeys(v string) *GetBucketResponseListBucketResult {
	s.MaxKeys = &v
	return s
}

func (s *GetBucketResponseListBucketResult) SetDelimiter(v string) *GetBucketResponseListBucketResult {
	s.Delimiter = &v
	return s
}

func (s *GetBucketResponseListBucketResult) SetIsTruncated(v string) *GetBucketResponseListBucketResult {
	s.IsTruncated = &v
	return s
}

func (s *GetBucketResponseListBucketResult) SetEncodingType(v string) *GetBucketResponseListBucketResult {
	s.EncodingType = &v
	return s
}

func (s *GetBucketResponseListBucketResult) SetCommonPrefixes(v string) *GetBucketResponseListBucketResult {
	s.CommonPrefixes = &v
	return s
}

func (s *GetBucketResponseListBucketResult) SetContents(v []*GetBucketResponseListBucketResultContents) *GetBucketResponseListBucketResult {
	s.Contents = v
	return s
}

type GetBucketResponseListBucketResultContents struct {
	// Key
	Key *string `json:"Key,omitempty" xml:"Key,omitempty"`
	// ETag
	ETag *string `json:"ETag,omitempty" xml:"ETag,omitempty"`
	// LastModified
	LastModified *string `json:"LastModified,omitempty" xml:"LastModified,omitempty"`
	// Size
	Size *string `json:"Size,omitempty" xml:"Size,omitempty"`
	// StorageClass
	StorageClass *string `json:"StorageClass,omitempty" xml:"StorageClass,omitempty"`
	// Owner
	Owner *GetBucketResponseListBucketResultContentsOwner `json:"Owner,omitempty" xml:"Owner,omitempty" require:"true" type:"Struct"`
}

func (s GetBucketResponseListBucketResultContents) String() string {
	return tea.Prettify(s)
}

func (s GetBucketResponseListBucketResultContents) GoString() string {
	return s.String()
}

func (s *GetBucketResponseListBucketResultContents) SetKey(v string) *GetBucketResponseListBucketResultContents {
	s.Key = &v
	return s
}

func (s *GetBucketResponseListBucketResultContents) SetETag(v string) *GetBucketResponseListBucketResultContents {
	s.ETag = &v
	return s
}

func (s *GetBucketResponseListBucketResultContents) SetLastModified(v string) *GetBucketResponseListBucketResultContents {
	s.LastModified = &v
	return s
}

func (s *GetBucketResponseListBucketResultContents) SetSize(v string) *GetBucketResponseListBucketResultContents {
	s.Size = &v
	return s
}

func (s *GetBucketResponseListBucketResultContents) SetStorageClass(v string) *GetBucketResponseListBucketResultContents {
	s.StorageClass = &v
	return s
}

func (s *GetBucketResponseListBucketResultContents) SetOwner(v *GetBucketResponseListBucketResultContentsOwner) *GetBucketResponseListBucketResultContents {
	s.Owner = v
	return s
}

type GetBucketResponseListBucketResultContentsOwner struct {
	// ID
	ID *string `json:"ID,omitempty" xml:"ID,omitempty"`
	// DisplayName
	DisplayName *string `json:"DisplayName,omitempty" xml:"DisplayName,omitempty"`
}

func (s GetBucketResponseListBucketResultContentsOwner) String() string {
	return tea.Prettify(s)
}

func (s GetBucketResponseListBucketResultContentsOwner) GoString() string {
	return s.String()
}

func (s *GetBucketResponseListBucketResultContentsOwner) SetID(v string) *GetBucketResponseListBucketResultContentsOwner {
	s.ID = &v
	return s
}

func (s *GetBucketResponseListBucketResultContentsOwner) SetDisplayName(v string) *GetBucketResponseListBucketResultContentsOwner {
	s.DisplayName = &v
	return s
}

type GetLiveChannelInfoRequest struct {
	// BucketName
	BucketName *string `json:"BucketName,omitempty" xml:"BucketName,omitempty" require:"true" pattern:"[a-zA-Z0-9-_]+"`
	// ChannelName
	ChannelName *string `json:"ChannelName,omitempty" xml:"ChannelName,omitempty" require:"true"`
}

func (s GetLiveChannelInfoRequest) String() string {
	return tea.Prettify(s)
}

func (s GetLiveChannelInfoRequest) GoString() string {
	return s.String()
}

func (s *GetLiveChannelInfoRequest) SetBucketName(v string) *GetLiveChannelInfoRequest {
	s.BucketName = &v
	return s
}

func (s *GetLiveChannelInfoRequest) SetChannelName(v string) *GetLiveChannelInfoRequest {
	s.ChannelName = &v
	return s
}

type GetLiveChannelInfoResponse struct {
	// x-oss-request-id
	RequestId *string `json:"x-oss-request-id,omitempty" xml:"x-oss-request-id,omitempty" require:"true"`
	// LiveChannelConfiguration
	LiveChannelConfiguration *GetLiveChannelInfoResponseLiveChannelConfiguration `json:"LiveChannelConfiguration,omitempty" xml:"LiveChannelConfiguration,omitempty" require:"true" type:"Struct"`
}

func (s GetLiveChannelInfoResponse) String() string {
	return tea.Prettify(s)
}

func (s GetLiveChannelInfoResponse) GoString() string {
	return s.String()
}

func (s *GetLiveChannelInfoResponse) SetRequestId(v string) *GetLiveChannelInfoResponse {
	s.RequestId = &v
	return s
}

func (s *GetLiveChannelInfoResponse) SetLiveChannelConfiguration(v *GetLiveChannelInfoResponseLiveChannelConfiguration) *GetLiveChannelInfoResponse {
	s.LiveChannelConfiguration = v
	return s
}

type GetLiveChannelInfoResponseLiveChannelConfiguration struct {
	// Description
	Description *string `json:"Description,omitempty" xml:"Description,omitempty"`
	// Status
	Status *string `json:"Status,omitempty" xml:"Status,omitempty"`
	// Target
	Target *GetLiveChannelInfoResponseLiveChannelConfigurationTarget `json:"Target,omitempty" xml:"Target,omitempty" require:"true" type:"Struct"`
}

func (s GetLiveChannelInfoResponseLiveChannelConfiguration) String() string {
	return tea.Prettify(s)
}

func (s GetLiveChannelInfoResponseLiveChannelConfiguration) GoString() string {
	return s.String()
}

func (s *GetLiveChannelInfoResponseLiveChannelConfiguration) SetDescription(v string) *GetLiveChannelInfoResponseLiveChannelConfiguration {
	s.Description = &v
	return s
}

func (s *GetLiveChannelInfoResponseLiveChannelConfiguration) SetStatus(v string) *GetLiveChannelInfoResponseLiveChannelConfiguration {
	s.Status = &v
	return s
}

func (s *GetLiveChannelInfoResponseLiveChannelConfiguration) SetTarget(v *GetLiveChannelInfoResponseLiveChannelConfigurationTarget) *GetLiveChannelInfoResponseLiveChannelConfiguration {
	s.Target = v
	return s
}

type GetLiveChannelInfoResponseLiveChannelConfigurationTarget struct {
	// Type
	Type *string `json:"Type,omitempty" xml:"Type,omitempty"`
	// FragDuration
	FragDuration *string `json:"FragDuration,omitempty" xml:"FragDuration,omitempty"`
	// FragCount
	FragCount *string `json:"FragCount,omitempty" xml:"FragCount,omitempty"`
	// PlaylistName
	PlaylistName *string `json:"PlaylistName,omitempty" xml:"PlaylistName,omitempty"`
}

func (s GetLiveChannelInfoResponseLiveChannelConfigurationTarget) String() string {
	return tea.Prettify(s)
}

func (s GetLiveChannelInfoResponseLiveChannelConfigurationTarget) GoString() string {
	return s.String()
}

func (s *GetLiveChannelInfoResponseLiveChannelConfigurationTarget) SetType(v string) *GetLiveChannelInfoResponseLiveChannelConfigurationTarget {
	s.Type = &v
	return s
}

func (s *GetLiveChannelInfoResponseLiveChannelConfigurationTarget) SetFragDuration(v string) *GetLiveChannelInfoResponseLiveChannelConfigurationTarget {
	s.FragDuration = &v
	return s
}

func (s *GetLiveChannelInfoResponseLiveChannelConfigurationTarget) SetFragCount(v string) *GetLiveChannelInfoResponseLiveChannelConfigurationTarget {
	s.FragCount = &v
	return s
}

func (s *GetLiveChannelInfoResponseLiveChannelConfigurationTarget) SetPlaylistName(v string) *GetLiveChannelInfoResponseLiveChannelConfigurationTarget {
	s.PlaylistName = &v
	return s
}

type GetLiveChannelStatRequest struct {
	// BucketName
	BucketName *string `json:"BucketName,omitempty" xml:"BucketName,omitempty" require:"true" pattern:"[a-zA-Z0-9-_]+"`
	// ChannelName
	ChannelName *string `json:"ChannelName,omitempty" xml:"ChannelName,omitempty" require:"true"`
	// Filter
	Filter *GetLiveChannelStatRequestFilter `json:"Filter,omitempty" xml:"Filter,omitempty" type:"Struct"`
}

func (s GetLiveChannelStatRequest) String() string {
	return tea.Prettify(s)
}

func (s GetLiveChannelStatRequest) GoString() string {
	return s.String()
}

func (s *GetLiveChannelStatRequest) SetBucketName(v string) *GetLiveChannelStatRequest {
	s.BucketName = &v
	return s
}

func (s *GetLiveChannelStatRequest) SetChannelName(v string) *GetLiveChannelStatRequest {
	s.ChannelName = &v
	return s
}

func (s *GetLiveChannelStatRequest) SetFilter(v *GetLiveChannelStatRequestFilter) *GetLiveChannelStatRequest {
	s.Filter = v
	return s
}

type GetLiveChannelStatRequestFilter struct {
	// comp
	Comp *string `json:"comp,omitempty" xml:"comp,omitempty" signed:"true"`
}

func (s GetLiveChannelStatRequestFilter) String() string {
	return tea.Prettify(s)
}

func (s GetLiveChannelStatRequestFilter) GoString() string {
	return s.String()
}

func (s *GetLiveChannelStatRequestFilter) SetComp(v string) *GetLiveChannelStatRequestFilter {
	s.Comp = &v
	return s
}

type GetLiveChannelStatResponse struct {
	// x-oss-request-id
	RequestId *string `json:"x-oss-request-id,omitempty" xml:"x-oss-request-id,omitempty" require:"true"`
	// LiveChannelStat
	LiveChannelStat *GetLiveChannelStatResponseLiveChannelStat `json:"LiveChannelStat,omitempty" xml:"LiveChannelStat,omitempty" require:"true" type:"Struct"`
}

func (s GetLiveChannelStatResponse) String() string {
	return tea.Prettify(s)
}

func (s GetLiveChannelStatResponse) GoString() string {
	return s.String()
}

func (s *GetLiveChannelStatResponse) SetRequestId(v string) *GetLiveChannelStatResponse {
	s.RequestId = &v
	return s
}

func (s *GetLiveChannelStatResponse) SetLiveChannelStat(v *GetLiveChannelStatResponseLiveChannelStat) *GetLiveChannelStatResponse {
	s.LiveChannelStat = v
	return s
}

type GetLiveChannelStatResponseLiveChannelStat struct {
	// Status
	Status *string `json:"Status,omitempty" xml:"Status,omitempty"`
	// ConnectedTime
	ConnectedTime *string `json:"ConnectedTime,omitempty" xml:"ConnectedTime,omitempty"`
	// RemoteAddr
	RemoteAddr *string `json:"RemoteAddr,omitempty" xml:"RemoteAddr,omitempty"`
	// Video
	Video *GetLiveChannelStatResponseLiveChannelStatVideo `json:"Video,omitempty" xml:"Video,omitempty" require:"true" type:"Struct"`
	// Audio
	Audio *GetLiveChannelStatResponseLiveChannelStatAudio `json:"Audio,omitempty" xml:"Audio,omitempty" require:"true" type:"Struct"`
}

func (s GetLiveChannelStatResponseLiveChannelStat) String() string {
	return tea.Prettify(s)
}

func (s GetLiveChannelStatResponseLiveChannelStat) GoString() string {
	return s.String()
}

func (s *GetLiveChannelStatResponseLiveChannelStat) SetStatus(v string) *GetLiveChannelStatResponseLiveChannelStat {
	s.Status = &v
	return s
}

func (s *GetLiveChannelStatResponseLiveChannelStat) SetConnectedTime(v string) *GetLiveChannelStatResponseLiveChannelStat {
	s.ConnectedTime = &v
	return s
}

func (s *GetLiveChannelStatResponseLiveChannelStat) SetRemoteAddr(v string) *GetLiveChannelStatResponseLiveChannelStat {
	s.RemoteAddr = &v
	return s
}

func (s *GetLiveChannelStatResponseLiveChannelStat) SetVideo(v *GetLiveChannelStatResponseLiveChannelStatVideo) *GetLiveChannelStatResponseLiveChannelStat {
	s.Video = v
	return s
}

func (s *GetLiveChannelStatResponseLiveChannelStat) SetAudio(v *GetLiveChannelStatResponseLiveChannelStatAudio) *GetLiveChannelStatResponseLiveChannelStat {
	s.Audio = v
	return s
}

type GetLiveChannelStatResponseLiveChannelStatVideo struct {
	// Width
	Width *string `json:"Width,omitempty" xml:"Width,omitempty"`
	// Height
	Height *string `json:"Height,omitempty" xml:"Height,omitempty"`
	// FrameRate
	FrameRate *string `json:"FrameRate,omitempty" xml:"FrameRate,omitempty"`
	// Bandwidth
	Bandwidth *string `json:"Bandwidth,omitempty" xml:"Bandwidth,omitempty"`
	// Codec
	Codec *string `json:"Codec,omitempty" xml:"Codec,omitempty"`
}

func (s GetLiveChannelStatResponseLiveChannelStatVideo) String() string {
	return tea.Prettify(s)
}

func (s GetLiveChannelStatResponseLiveChannelStatVideo) GoString() string {
	return s.String()
}

func (s *GetLiveChannelStatResponseLiveChannelStatVideo) SetWidth(v string) *GetLiveChannelStatResponseLiveChannelStatVideo {
	s.Width = &v
	return s
}

func (s *GetLiveChannelStatResponseLiveChannelStatVideo) SetHeight(v string) *GetLiveChannelStatResponseLiveChannelStatVideo {
	s.Height = &v
	return s
}

func (s *GetLiveChannelStatResponseLiveChannelStatVideo) SetFrameRate(v string) *GetLiveChannelStatResponseLiveChannelStatVideo {
	s.FrameRate = &v
	return s
}

func (s *GetLiveChannelStatResponseLiveChannelStatVideo) SetBandwidth(v string) *GetLiveChannelStatResponseLiveChannelStatVideo {
	s.Bandwidth = &v
	return s
}

func (s *GetLiveChannelStatResponseLiveChannelStatVideo) SetCodec(v string) *GetLiveChannelStatResponseLiveChannelStatVideo {
	s.Codec = &v
	return s
}

type GetLiveChannelStatResponseLiveChannelStatAudio struct {
	// Bandwidth
	Bandwidth *string `json:"Bandwidth,omitempty" xml:"Bandwidth,omitempty"`
	// SampleRate
	SampleRate *string `json:"SampleRate,omitempty" xml:"SampleRate,omitempty"`
	// Codec
	Codec *string `json:"Codec,omitempty" xml:"Codec,omitempty"`
}

func (s GetLiveChannelStatResponseLiveChannelStatAudio) String() string {
	return tea.Prettify(s)
}

func (s GetLiveChannelStatResponseLiveChannelStatAudio) GoString() string {
	return s.String()
}

func (s *GetLiveChannelStatResponseLiveChannelStatAudio) SetBandwidth(v string) *GetLiveChannelStatResponseLiveChannelStatAudio {
	s.Bandwidth = &v
	return s
}

func (s *GetLiveChannelStatResponseLiveChannelStatAudio) SetSampleRate(v string) *GetLiveChannelStatResponseLiveChannelStatAudio {
	s.SampleRate = &v
	return s
}

func (s *GetLiveChannelStatResponseLiveChannelStatAudio) SetCodec(v string) *GetLiveChannelStatResponseLiveChannelStatAudio {
	s.Codec = &v
	return s
}

type DeleteObjectRequest struct {
	// BucketName
	BucketName *string `json:"BucketName,omitempty" xml:"BucketName,omitempty" require:"true" pattern:"[a-zA-Z0-9-_]+"`
	// ObjectName
	ObjectName *string `json:"ObjectName,omitempty" xml:"ObjectName,omitempty" require:"true"`
}

func (s DeleteObjectRequest) String() string {
	return tea.Prettify(s)
}

func (s DeleteObjectRequest) GoString() string {
	return s.String()
}

func (s *DeleteObjectRequest) SetBucketName(v string) *DeleteObjectRequest {
	s.BucketName = &v
	return s
}

func (s *DeleteObjectRequest) SetObjectName(v string) *DeleteObjectRequest {
	s.ObjectName = &v
	return s
}

type DeleteObjectResponse struct {
	// x-oss-request-id
	RequestId *string `json:"x-oss-request-id,omitempty" xml:"x-oss-request-id,omitempty" require:"true"`
}

func (s DeleteObjectResponse) String() string {
	return tea.Prettify(s)
}

func (s DeleteObjectResponse) GoString() string {
	return s.String()
}

func (s *DeleteObjectResponse) SetRequestId(v string) *DeleteObjectResponse {
	s.RequestId = &v
	return s
}

type AbortMultipartUploadRequest struct {
	// BucketName
	BucketName *string `json:"BucketName,omitempty" xml:"BucketName,omitempty" require:"true" pattern:"[a-zA-Z0-9-_]+"`
	// ObjectName
	ObjectName *string `json:"ObjectName,omitempty" xml:"ObjectName,omitempty" require:"true"`
	// Filter
	Filter *AbortMultipartUploadRequestFilter `json:"Filter,omitempty" xml:"Filter,omitempty" require:"true" type:"Struct"`
}

func (s AbortMultipartUploadRequest) String() string {
	return tea.Prettify(s)
}

func (s AbortMultipartUploadRequest) GoString() string {
	return s.String()
}

func (s *AbortMultipartUploadRequest) SetBucketName(v string) *AbortMultipartUploadRequest {
	s.BucketName = &v
	return s
}

func (s *AbortMultipartUploadRequest) SetObjectName(v string) *AbortMultipartUploadRequest {
	s.ObjectName = &v
	return s
}

func (s *AbortMultipartUploadRequest) SetFilter(v *AbortMultipartUploadRequestFilter) *AbortMultipartUploadRequest {
	s.Filter = v
	return s
}

type AbortMultipartUploadRequestFilter struct {
	// uploadId
	UploadId *string `json:"uploadId,omitempty" xml:"uploadId,omitempty" require:"true" signed:"true"`
}

func (s AbortMultipartUploadRequestFilter) String() string {
	return tea.Prettify(s)
}

func (s AbortMultipartUploadRequestFilter) GoString() string {
	return s.String()
}

func (s *AbortMultipartUploadRequestFilter) SetUploadId(v string) *AbortMultipartUploadRequestFilter {
	s.UploadId = &v
	return s
}

type AbortMultipartUploadResponse struct {
	// x-oss-request-id
	RequestId *string `json:"x-oss-request-id,omitempty" xml:"x-oss-request-id,omitempty" require:"true"`
}

func (s AbortMultipartUploadResponse) String() string {
	return tea.Prettify(s)
}

func (s AbortMultipartUploadResponse) GoString() string {
	return s.String()
}

func (s *AbortMultipartUploadResponse) SetRequestId(v string) *AbortMultipartUploadResponse {
	s.RequestId = &v
	return s
}

type AppendObjectRequest struct {
	// BucketName
	BucketName *string `json:"BucketName,omitempty" xml:"BucketName,omitempty" require:"true" pattern:"[a-zA-Z0-9-_]+"`
	// ObjectName
	ObjectName *string `json:"ObjectName,omitempty" xml:"ObjectName,omitempty" require:"true"`
	// UserMeta
	UserMeta map[string]*string `json:"UserMeta,omitempty" xml:"UserMeta,omitempty"`
	// body
	Body io.Reader `json:"body,omitempty" xml:"body,omitempty"`
	// Filter
	Filter *AppendObjectRequestFilter `json:"Filter,omitempty" xml:"Filter,omitempty" require:"true" type:"Struct"`
	// Header
	Header *AppendObjectRequestHeader `json:"Header,omitempty" xml:"Header,omitempty" type:"Struct"`
}

func (s AppendObjectRequest) String() string {
	return tea.Prettify(s)
}

func (s AppendObjectRequest) GoString() string {
	return s.String()
}

func (s *AppendObjectRequest) SetBucketName(v string) *AppendObjectRequest {
	s.BucketName = &v
	return s
}

func (s *AppendObjectRequest) SetObjectName(v string) *AppendObjectRequest {
	s.ObjectName = &v
	return s
}

func (s *AppendObjectRequest) SetUserMeta(v map[string]*string) *AppendObjectRequest {
	s.UserMeta = v
	return s
}

func (s *AppendObjectRequest) SetBody(v io.Reader) *AppendObjectRequest {
	s.Body = v
	return s
}

func (s *AppendObjectRequest) SetFilter(v *AppendObjectRequestFilter) *AppendObjectRequest {
	s.Filter = v
	return s
}

func (s *AppendObjectRequest) SetHeader(v *AppendObjectRequestHeader) *AppendObjectRequest {
	s.Header = v
	return s
}

type AppendObjectRequestFilter struct {
	// position
	Position *string `json:"position,omitempty" xml:"position,omitempty" require:"true" signed:"true"`
}

func (s AppendObjectRequestFilter) String() string {
	return tea.Prettify(s)
}

func (s AppendObjectRequestFilter) GoString() string {
	return s.String()
}

func (s *AppendObjectRequestFilter) SetPosition(v string) *AppendObjectRequestFilter {
	s.Position = &v
	return s
}

type AppendObjectRequestHeader struct {
	// Cache-Control
	CacheControl *string `json:"Cache-Control,omitempty" xml:"Cache-Control,omitempty"`
	// Content-Disposition
	ContentDisposition *string `json:"Content-Disposition,omitempty" xml:"Content-Disposition,omitempty"`
	// Content-Encoding
	ContentEncoding *string `json:"Content-Encoding,omitempty" xml:"Content-Encoding,omitempty"`
	// Content-MD5
	ContentMD5 *string `json:"Content-MD5,omitempty" xml:"Content-MD5,omitempty"`
	// Expires
	Expires *string `json:"Expires,omitempty" xml:"Expires,omitempty"`
	// x-oss-server-side-encryption
	ServerSideEncryption *string `json:"x-oss-server-side-encryption,omitempty" xml:"x-oss-server-side-encryption,omitempty"`
	// x-oss-object-acl
	ObjectAcl *string `json:"x-oss-object-acl,omitempty" xml:"x-oss-object-acl,omitempty"`
	// x-oss-storage-class
	StorageClass *string `json:"x-oss-storage-class,omitempty" xml:"x-oss-storage-class,omitempty"`
	// content-type
	ContentType *string `json:"content-type,omitempty" xml:"content-type,omitempty"`
}

func (s AppendObjectRequestHeader) String() string {
	return tea.Prettify(s)
}

func (s AppendObjectRequestHeader) GoString() string {
	return s.String()
}

func (s *AppendObjectRequestHeader) SetCacheControl(v string) *AppendObjectRequestHeader {
	s.CacheControl = &v
	return s
}

func (s *AppendObjectRequestHeader) SetContentDisposition(v string) *AppendObjectRequestHeader {
	s.ContentDisposition = &v
	return s
}

func (s *AppendObjectRequestHeader) SetContentEncoding(v string) *AppendObjectRequestHeader {
	s.ContentEncoding = &v
	return s
}

func (s *AppendObjectRequestHeader) SetContentMD5(v string) *AppendObjectRequestHeader {
	s.ContentMD5 = &v
	return s
}

func (s *AppendObjectRequestHeader) SetExpires(v string) *AppendObjectRequestHeader {
	s.Expires = &v
	return s
}

func (s *AppendObjectRequestHeader) SetServerSideEncryption(v string) *AppendObjectRequestHeader {
	s.ServerSideEncryption = &v
	return s
}

func (s *AppendObjectRequestHeader) SetObjectAcl(v string) *AppendObjectRequestHeader {
	s.ObjectAcl = &v
	return s
}

func (s *AppendObjectRequestHeader) SetStorageClass(v string) *AppendObjectRequestHeader {
	s.StorageClass = &v
	return s
}

func (s *AppendObjectRequestHeader) SetContentType(v string) *AppendObjectRequestHeader {
	s.ContentType = &v
	return s
}

type AppendObjectResponse struct {
	// x-oss-request-id
	RequestId *string `json:"x-oss-request-id,omitempty" xml:"x-oss-request-id,omitempty" require:"true"`
	// x-oss-next-append-position
	NextAppendPosition *string `json:"x-oss-next-append-position,omitempty" xml:"x-oss-next-append-position,omitempty" require:"true"`
	// x-oss-hash-crc64ecma
	HashCrc64ecma *string `json:"x-oss-hash-crc64ecma,omitempty" xml:"x-oss-hash-crc64ecma,omitempty" require:"true"`
}

func (s AppendObjectResponse) String() string {
	return tea.Prettify(s)
}

func (s AppendObjectResponse) GoString() string {
	return s.String()
}

func (s *AppendObjectResponse) SetRequestId(v string) *AppendObjectResponse {
	s.RequestId = &v
	return s
}

func (s *AppendObjectResponse) SetNextAppendPosition(v string) *AppendObjectResponse {
	s.NextAppendPosition = &v
	return s
}

func (s *AppendObjectResponse) SetHashCrc64ecma(v string) *AppendObjectResponse {
	s.HashCrc64ecma = &v
	return s
}

type UploadPartCopyRequest struct {
	// BucketName
	BucketName *string `json:"BucketName,omitempty" xml:"BucketName,omitempty" require:"true" pattern:"[a-zA-Z0-9-_]+"`
	// ObjectName
	ObjectName *string `json:"ObjectName,omitempty" xml:"ObjectName,omitempty" require:"true"`
	// Filter
	Filter *UploadPartCopyRequestFilter `json:"Filter,omitempty" xml:"Filter,omitempty" require:"true" type:"Struct"`
	// Header
	Header *UploadPartCopyRequestHeader `json:"Header,omitempty" xml:"Header,omitempty" require:"true" type:"Struct"`
}

func (s UploadPartCopyRequest) String() string {
	return tea.Prettify(s)
}

func (s UploadPartCopyRequest) GoString() string {
	return s.String()
}

func (s *UploadPartCopyRequest) SetBucketName(v string) *UploadPartCopyRequest {
	s.BucketName = &v
	return s
}

func (s *UploadPartCopyRequest) SetObjectName(v string) *UploadPartCopyRequest {
	s.ObjectName = &v
	return s
}

func (s *UploadPartCopyRequest) SetFilter(v *UploadPartCopyRequestFilter) *UploadPartCopyRequest {
	s.Filter = v
	return s
}

func (s *UploadPartCopyRequest) SetHeader(v *UploadPartCopyRequestHeader) *UploadPartCopyRequest {
	s.Header = v
	return s
}

type UploadPartCopyRequestFilter struct {
	// partNumber
	PartNumber *string `json:"partNumber,omitempty" xml:"partNumber,omitempty" require:"true" signed:"true"`
	// uploadId
	UploadId *string `json:"uploadId,omitempty" xml:"uploadId,omitempty" require:"true" signed:"true"`
}

func (s UploadPartCopyRequestFilter) String() string {
	return tea.Prettify(s)
}

func (s UploadPartCopyRequestFilter) GoString() string {
	return s.String()
}

func (s *UploadPartCopyRequestFilter) SetPartNumber(v string) *UploadPartCopyRequestFilter {
	s.PartNumber = &v
	return s
}

func (s *UploadPartCopyRequestFilter) SetUploadId(v string) *UploadPartCopyRequestFilter {
	s.UploadId = &v
	return s
}

type UploadPartCopyRequestHeader struct {
	// x-oss-copy-source
	CopySource *string `json:"x-oss-copy-source,omitempty" xml:"x-oss-copy-source,omitempty" require:"true"`
	// x-oss-copy-source-range
	CopySourceRange *string `json:"x-oss-copy-source-range,omitempty" xml:"x-oss-copy-source-range,omitempty" require:"true"`
	// x-oss-copy-source-if-match
	CopySourceIfMatch *string `json:"x-oss-copy-source-if-match,omitempty" xml:"x-oss-copy-source-if-match,omitempty"`
	// x-oss-copy-source-if-none-match
	CopySourceIfNoneMatch *string `json:"x-oss-copy-source-if-none-match,omitempty" xml:"x-oss-copy-source-if-none-match,omitempty"`
	// x-oss-copy-source-if-unmodified-since
	CopySourceIfUnmodifiedSince *string `json:"x-oss-copy-source-if-unmodified-since,omitempty" xml:"x-oss-copy-source-if-unmodified-since,omitempty"`
	// x-oss-copy-source-if-modified-since
	CopySourceIfModifiedSince *string `json:"x-oss-copy-source-if-modified-since,omitempty" xml:"x-oss-copy-source-if-modified-since,omitempty"`
}

func (s UploadPartCopyRequestHeader) String() string {
	return tea.Prettify(s)
}

func (s UploadPartCopyRequestHeader) GoString() string {
	return s.String()
}

func (s *UploadPartCopyRequestHeader) SetCopySource(v string) *UploadPartCopyRequestHeader {
	s.CopySource = &v
	return s
}

func (s *UploadPartCopyRequestHeader) SetCopySourceRange(v string) *UploadPartCopyRequestHeader {
	s.CopySourceRange = &v
	return s
}

func (s *UploadPartCopyRequestHeader) SetCopySourceIfMatch(v string) *UploadPartCopyRequestHeader {
	s.CopySourceIfMatch = &v
	return s
}

func (s *UploadPartCopyRequestHeader) SetCopySourceIfNoneMatch(v string) *UploadPartCopyRequestHeader {
	s.CopySourceIfNoneMatch = &v
	return s
}

func (s *UploadPartCopyRequestHeader) SetCopySourceIfUnmodifiedSince(v string) *UploadPartCopyRequestHeader {
	s.CopySourceIfUnmodifiedSince = &v
	return s
}

func (s *UploadPartCopyRequestHeader) SetCopySourceIfModifiedSince(v string) *UploadPartCopyRequestHeader {
	s.CopySourceIfModifiedSince = &v
	return s
}

type UploadPartCopyResponse struct {
	// x-oss-request-id
	RequestId *string `json:"x-oss-request-id,omitempty" xml:"x-oss-request-id,omitempty" require:"true"`
	// CopyPartResult
	CopyPartResult *UploadPartCopyResponseCopyPartResult `json:"CopyPartResult,omitempty" xml:"CopyPartResult,omitempty" require:"true" type:"Struct"`
}

func (s UploadPartCopyResponse) String() string {
	return tea.Prettify(s)
}

func (s UploadPartCopyResponse) GoString() string {
	return s.String()
}

func (s *UploadPartCopyResponse) SetRequestId(v string) *UploadPartCopyResponse {
	s.RequestId = &v
	return s
}

func (s *UploadPartCopyResponse) SetCopyPartResult(v *UploadPartCopyResponseCopyPartResult) *UploadPartCopyResponse {
	s.CopyPartResult = v
	return s
}

type UploadPartCopyResponseCopyPartResult struct {
	// LastModified
	LastModified *string `json:"LastModified,omitempty" xml:"LastModified,omitempty"`
	// ETag
	ETag *string `json:"ETag,omitempty" xml:"ETag,omitempty"`
}

func (s UploadPartCopyResponseCopyPartResult) String() string {
	return tea.Prettify(s)
}

func (s UploadPartCopyResponseCopyPartResult) GoString() string {
	return s.String()
}

func (s *UploadPartCopyResponseCopyPartResult) SetLastModified(v string) *UploadPartCopyResponseCopyPartResult {
	s.LastModified = &v
	return s
}

func (s *UploadPartCopyResponseCopyPartResult) SetETag(v string) *UploadPartCopyResponseCopyPartResult {
	s.ETag = &v
	return s
}

type GetVodPlaylistRequest struct {
	// BucketName
	BucketName *string `json:"BucketName,omitempty" xml:"BucketName,omitempty" require:"true" pattern:"[a-zA-Z0-9-_]+"`
	// ChannelName
	ChannelName *string `json:"ChannelName,omitempty" xml:"ChannelName,omitempty" require:"true"`
	// Filter
	Filter *GetVodPlaylistRequestFilter `json:"Filter,omitempty" xml:"Filter,omitempty" require:"true" type:"Struct"`
}

func (s GetVodPlaylistRequest) String() string {
	return tea.Prettify(s)
}

func (s GetVodPlaylistRequest) GoString() string {
	return s.String()
}

func (s *GetVodPlaylistRequest) SetBucketName(v string) *GetVodPlaylistRequest {
	s.BucketName = &v
	return s
}

func (s *GetVodPlaylistRequest) SetChannelName(v string) *GetVodPlaylistRequest {
	s.ChannelName = &v
	return s
}

func (s *GetVodPlaylistRequest) SetFilter(v *GetVodPlaylistRequestFilter) *GetVodPlaylistRequest {
	s.Filter = v
	return s
}

type GetVodPlaylistRequestFilter struct {
	// endTime
	EndTime *string `json:"endTime,omitempty" xml:"endTime,omitempty" require:"true" signed:"true"`
	// startTime
	StartTime *string `json:"startTime,omitempty" xml:"startTime,omitempty" require:"true" signed:"true"`
}

func (s GetVodPlaylistRequestFilter) String() string {
	return tea.Prettify(s)
}

func (s GetVodPlaylistRequestFilter) GoString() string {
	return s.String()
}

func (s *GetVodPlaylistRequestFilter) SetEndTime(v string) *GetVodPlaylistRequestFilter {
	s.EndTime = &v
	return s
}

func (s *GetVodPlaylistRequestFilter) SetStartTime(v string) *GetVodPlaylistRequestFilter {
	s.StartTime = &v
	return s
}

type GetVodPlaylistResponse struct {
	// x-oss-request-id
	RequestId *string `json:"x-oss-request-id,omitempty" xml:"x-oss-request-id,omitempty" require:"true"`
}

func (s GetVodPlaylistResponse) String() string {
	return tea.Prettify(s)
}

func (s GetVodPlaylistResponse) GoString() string {
	return s.String()
}

func (s *GetVodPlaylistResponse) SetRequestId(v string) *GetVodPlaylistResponse {
	s.RequestId = &v
	return s
}

type DeleteBucketCORSRequest struct {
	// BucketName
	BucketName *string `json:"BucketName,omitempty" xml:"BucketName,omitempty" require:"true" pattern:"[a-zA-Z0-9-_]+"`
}

func (s DeleteBucketCORSRequest) String() string {
	return tea.Prettify(s)
}

func (s DeleteBucketCORSRequest) GoString() string {
	return s.String()
}

func (s *DeleteBucketCORSRequest) SetBucketName(v string) *DeleteBucketCORSRequest {
	s.BucketName = &v
	return s
}

type DeleteBucketCORSResponse struct {
	// x-oss-request-id
	RequestId *string `json:"x-oss-request-id,omitempty" xml:"x-oss-request-id,omitempty" require:"true"`
}

func (s DeleteBucketCORSResponse) String() string {
	return tea.Prettify(s)
}

func (s DeleteBucketCORSResponse) GoString() string {
	return s.String()
}

func (s *DeleteBucketCORSResponse) SetRequestId(v string) *DeleteBucketCORSResponse {
	s.RequestId = &v
	return s
}

type GetObjectRequest struct {
	// BucketName
	BucketName *string `json:"BucketName,omitempty" xml:"BucketName,omitempty" require:"true" pattern:"[a-zA-Z0-9-_]+"`
	// ObjectName
	ObjectName *string `json:"ObjectName,omitempty" xml:"ObjectName,omitempty" require:"true"`
	// Header
	Header *GetObjectRequestHeader `json:"Header,omitempty" xml:"Header,omitempty" type:"Struct"`
}

func (s GetObjectRequest) String() string {
	return tea.Prettify(s)
}

func (s GetObjectRequest) GoString() string {
	return s.String()
}

func (s *GetObjectRequest) SetBucketName(v string) *GetObjectRequest {
	s.BucketName = &v
	return s
}

func (s *GetObjectRequest) SetObjectName(v string) *GetObjectRequest {
	s.ObjectName = &v
	return s
}

func (s *GetObjectRequest) SetHeader(v *GetObjectRequestHeader) *GetObjectRequest {
	s.Header = v
	return s
}

type GetObjectRequestHeader struct {
	// response-content-type
	ResponseContentType *string `json:"response-content-type,omitempty" xml:"response-content-type,omitempty"`
	// response-content-language
	ResponseContentLanguage *string `json:"response-content-language,omitempty" xml:"response-content-language,omitempty"`
	// response-expires
	ResponseExpires *string `json:"response-expires,omitempty" xml:"response-expires,omitempty"`
	// response-cache-control
	ResponseCacheControl *string `json:"response-cache-control,omitempty" xml:"response-cache-control,omitempty"`
	// response-content-disposition
	ResponseContentDisposition *string `json:"response-content-disposition,omitempty" xml:"response-content-disposition,omitempty"`
	// response-content-encoding
	ResponseContentEncoding *string `json:"response-content-encoding,omitempty" xml:"response-content-encoding,omitempty"`
	// Range
	Range *string `json:"Range,omitempty" xml:"Range,omitempty"`
	// If-Modified-Since
	IfModifiedSince *string `json:"If-Modified-Since,omitempty" xml:"If-Modified-Since,omitempty"`
	// If-Unmodified-Since
	IfUnmodifiedSince *string `json:"If-Unmodified-Since,omitempty" xml:"If-Unmodified-Since,omitempty"`
	// If-Match
	IfMatch *string `json:"If-Match,omitempty" xml:"If-Match,omitempty"`
	// If-None-Match
	IfNoneMatch *string `json:"If-None-Match,omitempty" xml:"If-None-Match,omitempty"`
	// Accept-Encoding
	AcceptEncoding *string `json:"Accept-Encoding,omitempty" xml:"Accept-Encoding,omitempty"`
}

func (s GetObjectRequestHeader) String() string {
	return tea.Prettify(s)
}

func (s GetObjectRequestHeader) GoString() string {
	return s.String()
}

func (s *GetObjectRequestHeader) SetResponseContentType(v string) *GetObjectRequestHeader {
	s.ResponseContentType = &v
	return s
}

func (s *GetObjectRequestHeader) SetResponseContentLanguage(v string) *GetObjectRequestHeader {
	s.ResponseContentLanguage = &v
	return s
}

func (s *GetObjectRequestHeader) SetResponseExpires(v string) *GetObjectRequestHeader {
	s.ResponseExpires = &v
	return s
}

func (s *GetObjectRequestHeader) SetResponseCacheControl(v string) *GetObjectRequestHeader {
	s.ResponseCacheControl = &v
	return s
}

func (s *GetObjectRequestHeader) SetResponseContentDisposition(v string) *GetObjectRequestHeader {
	s.ResponseContentDisposition = &v
	return s
}

func (s *GetObjectRequestHeader) SetResponseContentEncoding(v string) *GetObjectRequestHeader {
	s.ResponseContentEncoding = &v
	return s
}

func (s *GetObjectRequestHeader) SetRange(v string) *GetObjectRequestHeader {
	s.Range = &v
	return s
}

func (s *GetObjectRequestHeader) SetIfModifiedSince(v string) *GetObjectRequestHeader {
	s.IfModifiedSince = &v
	return s
}

func (s *GetObjectRequestHeader) SetIfUnmodifiedSince(v string) *GetObjectRequestHeader {
	s.IfUnmodifiedSince = &v
	return s
}

func (s *GetObjectRequestHeader) SetIfMatch(v string) *GetObjectRequestHeader {
	s.IfMatch = &v
	return s
}

func (s *GetObjectRequestHeader) SetIfNoneMatch(v string) *GetObjectRequestHeader {
	s.IfNoneMatch = &v
	return s
}

func (s *GetObjectRequestHeader) SetAcceptEncoding(v string) *GetObjectRequestHeader {
	s.AcceptEncoding = &v
	return s
}

type GetObjectResponse struct {
	// x-oss-request-id
	RequestId *string `json:"x-oss-request-id,omitempty" xml:"x-oss-request-id,omitempty" require:"true"`
	// x-oss-object-type
	ObjectType *string `json:"x-oss-object-type,omitempty" xml:"x-oss-object-type,omitempty" require:"true"`
	// x-oss-server-side-encryption
	ServerSideEncryption *string `json:"x-oss-server-side-encryption,omitempty" xml:"x-oss-server-side-encryption,omitempty" require:"true"`
	// x-oss-tagging-count
	TaggingCount *string `json:"x-oss-tagging-count,omitempty" xml:"x-oss-tagging-count,omitempty" require:"true"`
	// x-oss-restore
	Restore *string `json:"x-oss-restore,omitempty" xml:"x-oss-restore,omitempty" require:"true"`
	// body
	Body io.Reader `json:"body,omitempty" xml:"body,omitempty" require:"true"`
}

func (s GetObjectResponse) String() string {
	return tea.Prettify(s)
}

func (s GetObjectResponse) GoString() string {
	return s.String()
}

func (s *GetObjectResponse) SetRequestId(v string) *GetObjectResponse {
	s.RequestId = &v
	return s
}

func (s *GetObjectResponse) SetObjectType(v string) *GetObjectResponse {
	s.ObjectType = &v
	return s
}

func (s *GetObjectResponse) SetServerSideEncryption(v string) *GetObjectResponse {
	s.ServerSideEncryption = &v
	return s
}

func (s *GetObjectResponse) SetTaggingCount(v string) *GetObjectResponse {
	s.TaggingCount = &v
	return s
}

func (s *GetObjectResponse) SetRestore(v string) *GetObjectResponse {
	s.Restore = &v
	return s
}

func (s *GetObjectResponse) SetBody(v io.Reader) *GetObjectResponse {
	s.Body = v
	return s
}

type UploadPartRequest struct {
	// BucketName
	BucketName *string `json:"BucketName,omitempty" xml:"BucketName,omitempty" require:"true" pattern:"[a-zA-Z0-9-_]+"`
	// ObjectName
	ObjectName *string `json:"ObjectName,omitempty" xml:"ObjectName,omitempty" require:"true"`
	// body
	Body io.Reader `json:"body,omitempty" xml:"body,omitempty"`
	// Filter
	Filter *UploadPartRequestFilter `json:"Filter,omitempty" xml:"Filter,omitempty" require:"true" type:"Struct"`
}

func (s UploadPartRequest) String() string {
	return tea.Prettify(s)
}

func (s UploadPartRequest) GoString() string {
	return s.String()
}

func (s *UploadPartRequest) SetBucketName(v string) *UploadPartRequest {
	s.BucketName = &v
	return s
}

func (s *UploadPartRequest) SetObjectName(v string) *UploadPartRequest {
	s.ObjectName = &v
	return s
}

func (s *UploadPartRequest) SetBody(v io.Reader) *UploadPartRequest {
	s.Body = v
	return s
}

func (s *UploadPartRequest) SetFilter(v *UploadPartRequestFilter) *UploadPartRequest {
	s.Filter = v
	return s
}

type UploadPartRequestFilter struct {
	// partNumber
	PartNumber *string `json:"partNumber,omitempty" xml:"partNumber,omitempty" require:"true" signed:"true"`
	// uploadId
	UploadId *string `json:"uploadId,omitempty" xml:"uploadId,omitempty" require:"true" signed:"true"`
}

func (s UploadPartRequestFilter) String() string {
	return tea.Prettify(s)
}

func (s UploadPartRequestFilter) GoString() string {
	return s.String()
}

func (s *UploadPartRequestFilter) SetPartNumber(v string) *UploadPartRequestFilter {
	s.PartNumber = &v
	return s
}

func (s *UploadPartRequestFilter) SetUploadId(v string) *UploadPartRequestFilter {
	s.UploadId = &v
	return s
}

type UploadPartResponse struct {
	// x-oss-request-id
	RequestId *string `json:"x-oss-request-id,omitempty" xml:"x-oss-request-id,omitempty" require:"true"`
}

func (s UploadPartResponse) String() string {
	return tea.Prettify(s)
}

func (s UploadPartResponse) GoString() string {
	return s.String()
}

func (s *UploadPartResponse) SetRequestId(v string) *UploadPartResponse {
	s.RequestId = &v
	return s
}

type GetBucketCORSRequest struct {
	// BucketName
	BucketName *string `json:"BucketName,omitempty" xml:"BucketName,omitempty" require:"true" pattern:"[a-zA-Z0-9-_]+"`
}

func (s GetBucketCORSRequest) String() string {
	return tea.Prettify(s)
}

func (s GetBucketCORSRequest) GoString() string {
	return s.String()
}

func (s *GetBucketCORSRequest) SetBucketName(v string) *GetBucketCORSRequest {
	s.BucketName = &v
	return s
}

type GetBucketCORSResponse struct {
	// x-oss-request-id
	RequestId *string `json:"x-oss-request-id,omitempty" xml:"x-oss-request-id,omitempty" require:"true"`
	// CORSConfiguration
	CORSConfiguration *GetBucketCORSResponseCORSConfiguration `json:"CORSConfiguration,omitempty" xml:"CORSConfiguration,omitempty" require:"true" type:"Struct"`
}

func (s GetBucketCORSResponse) String() string {
	return tea.Prettify(s)
}

func (s GetBucketCORSResponse) GoString() string {
	return s.String()
}

func (s *GetBucketCORSResponse) SetRequestId(v string) *GetBucketCORSResponse {
	s.RequestId = &v
	return s
}

func (s *GetBucketCORSResponse) SetCORSConfiguration(v *GetBucketCORSResponseCORSConfiguration) *GetBucketCORSResponse {
	s.CORSConfiguration = v
	return s
}

type GetBucketCORSResponseCORSConfiguration struct {
	// CORSRule
	CORSRule []*GetBucketCORSResponseCORSConfigurationCORSRule `json:"CORSRule,omitempty" xml:"CORSRule,omitempty" type:"Repeated"`
}

func (s GetBucketCORSResponseCORSConfiguration) String() string {
	return tea.Prettify(s)
}

func (s GetBucketCORSResponseCORSConfiguration) GoString() string {
	return s.String()
}

func (s *GetBucketCORSResponseCORSConfiguration) SetCORSRule(v []*GetBucketCORSResponseCORSConfigurationCORSRule) *GetBucketCORSResponseCORSConfiguration {
	s.CORSRule = v
	return s
}

type GetBucketCORSResponseCORSConfigurationCORSRule struct {
	// MaxAgeSeconds
	MaxAgeSeconds *string `json:"MaxAgeSeconds,omitempty" xml:"MaxAgeSeconds,omitempty"`
}

func (s GetBucketCORSResponseCORSConfigurationCORSRule) String() string {
	return tea.Prettify(s)
}

func (s GetBucketCORSResponseCORSConfigurationCORSRule) GoString() string {
	return s.String()
}

func (s *GetBucketCORSResponseCORSConfigurationCORSRule) SetMaxAgeSeconds(v string) *GetBucketCORSResponseCORSConfigurationCORSRule {
	s.MaxAgeSeconds = &v
	return s
}

type CopyObjectRequest struct {
	// BucketName
	BucketName *string `json:"BucketName,omitempty" xml:"BucketName,omitempty" require:"true" pattern:"[a-zA-Z0-9-_]+"`
	// DestObjectName
	DestObjectName *string `json:"DestObjectName,omitempty" xml:"DestObjectName,omitempty" require:"true"`
	// Header
	Header *CopyObjectRequestHeader `json:"Header,omitempty" xml:"Header,omitempty" require:"true" type:"Struct"`
}

func (s CopyObjectRequest) String() string {
	return tea.Prettify(s)
}

func (s CopyObjectRequest) GoString() string {
	return s.String()
}

func (s *CopyObjectRequest) SetBucketName(v string) *CopyObjectRequest {
	s.BucketName = &v
	return s
}

func (s *CopyObjectRequest) SetDestObjectName(v string) *CopyObjectRequest {
	s.DestObjectName = &v
	return s
}

func (s *CopyObjectRequest) SetHeader(v *CopyObjectRequestHeader) *CopyObjectRequest {
	s.Header = v
	return s
}

type CopyObjectRequestHeader struct {
	// x-oss-copy-source
	CopySource *string `json:"x-oss-copy-source,omitempty" xml:"x-oss-copy-source,omitempty" require:"true"`
	// x-oss-copy-source-if-match
	CopySourceIfMatch *string `json:"x-oss-copy-source-if-match,omitempty" xml:"x-oss-copy-source-if-match,omitempty"`
	// x-oss-copy-source-if-none-match
	CopySourceIfNoneMatch *string `json:"x-oss-copy-source-if-none-match,omitempty" xml:"x-oss-copy-source-if-none-match,omitempty"`
	// x-oss-copy-source-if-unmodified-since
	CopySourceIfUnmodifiedSince *string `json:"x-oss-copy-source-if-unmodified-since,omitempty" xml:"x-oss-copy-source-if-unmodified-since,omitempty"`
	// x-oss-copy-source-if-modified-since
	CopySourceIfModifiedSince *string `json:"x-oss-copy-source-if-modified-since,omitempty" xml:"x-oss-copy-source-if-modified-since,omitempty"`
	// x-oss-metadata-directive
	MetadataDirective *string `json:"x-oss-metadata-directive,omitempty" xml:"x-oss-metadata-directive,omitempty"`
	// x-oss-server-side-encryption
	ServerSideEncryption *string `json:"x-oss-server-side-encryption,omitempty" xml:"x-oss-server-side-encryption,omitempty"`
	// x-oss-server-side-encryption-key-id
	ServerSideEncryptionKeyId *string `json:"x-oss-server-side-encryption-key-id,omitempty" xml:"x-oss-server-side-encryption-key-id,omitempty"`
	// x-oss-object-acl
	ObjectAcl *string `json:"x-oss-object-acl,omitempty" xml:"x-oss-object-acl,omitempty"`
	// x-oss-storage-class
	StorageClass *string `json:"x-oss-storage-class,omitempty" xml:"x-oss-storage-class,omitempty"`
	// x-oss-tagging
	Tagging *string `json:"x-oss-tagging,omitempty" xml:"x-oss-tagging,omitempty"`
	// x-oss-tagging-directive
	TaggingDirective *string `json:"x-oss-tagging-directive,omitempty" xml:"x-oss-tagging-directive,omitempty"`
}

func (s CopyObjectRequestHeader) String() string {
	return tea.Prettify(s)
}

func (s CopyObjectRequestHeader) GoString() string {
	return s.String()
}

func (s *CopyObjectRequestHeader) SetCopySource(v string) *CopyObjectRequestHeader {
	s.CopySource = &v
	return s
}

func (s *CopyObjectRequestHeader) SetCopySourceIfMatch(v string) *CopyObjectRequestHeader {
	s.CopySourceIfMatch = &v
	return s
}

func (s *CopyObjectRequestHeader) SetCopySourceIfNoneMatch(v string) *CopyObjectRequestHeader {
	s.CopySourceIfNoneMatch = &v
	return s
}

func (s *CopyObjectRequestHeader) SetCopySourceIfUnmodifiedSince(v string) *CopyObjectRequestHeader {
	s.CopySourceIfUnmodifiedSince = &v
	return s
}

func (s *CopyObjectRequestHeader) SetCopySourceIfModifiedSince(v string) *CopyObjectRequestHeader {
	s.CopySourceIfModifiedSince = &v
	return s
}

func (s *CopyObjectRequestHeader) SetMetadataDirective(v string) *CopyObjectRequestHeader {
	s.MetadataDirective = &v
	return s
}

func (s *CopyObjectRequestHeader) SetServerSideEncryption(v string) *CopyObjectRequestHeader {
	s.ServerSideEncryption = &v
	return s
}

func (s *CopyObjectRequestHeader) SetServerSideEncryptionKeyId(v string) *CopyObjectRequestHeader {
	s.ServerSideEncryptionKeyId = &v
	return s
}

func (s *CopyObjectRequestHeader) SetObjectAcl(v string) *CopyObjectRequestHeader {
	s.ObjectAcl = &v
	return s
}

func (s *CopyObjectRequestHeader) SetStorageClass(v string) *CopyObjectRequestHeader {
	s.StorageClass = &v
	return s
}

func (s *CopyObjectRequestHeader) SetTagging(v string) *CopyObjectRequestHeader {
	s.Tagging = &v
	return s
}

func (s *CopyObjectRequestHeader) SetTaggingDirective(v string) *CopyObjectRequestHeader {
	s.TaggingDirective = &v
	return s
}

type CopyObjectResponse struct {
	// x-oss-request-id
	RequestId *string `json:"x-oss-request-id,omitempty" xml:"x-oss-request-id,omitempty" require:"true"`
	// CopyObjectResult
	CopyObjectResult *CopyObjectResponseCopyObjectResult `json:"CopyObjectResult,omitempty" xml:"CopyObjectResult,omitempty" require:"true" type:"Struct"`
}

func (s CopyObjectResponse) String() string {
	return tea.Prettify(s)
}

func (s CopyObjectResponse) GoString() string {
	return s.String()
}

func (s *CopyObjectResponse) SetRequestId(v string) *CopyObjectResponse {
	s.RequestId = &v
	return s
}

func (s *CopyObjectResponse) SetCopyObjectResult(v *CopyObjectResponseCopyObjectResult) *CopyObjectResponse {
	s.CopyObjectResult = v
	return s
}

type CopyObjectResponseCopyObjectResult struct {
	// LastModified
	LastModified *string `json:"LastModified,omitempty" xml:"LastModified,omitempty"`
	// ETag
	ETag *string `json:"ETag,omitempty" xml:"ETag,omitempty"`
}

func (s CopyObjectResponseCopyObjectResult) String() string {
	return tea.Prettify(s)
}

func (s CopyObjectResponseCopyObjectResult) GoString() string {
	return s.String()
}

func (s *CopyObjectResponseCopyObjectResult) SetLastModified(v string) *CopyObjectResponseCopyObjectResult {
	s.LastModified = &v
	return s
}

func (s *CopyObjectResponseCopyObjectResult) SetETag(v string) *CopyObjectResponseCopyObjectResult {
	s.ETag = &v
	return s
}

type GetObjectTaggingRequest struct {
	// BucketName
	BucketName *string `json:"BucketName,omitempty" xml:"BucketName,omitempty" require:"true" pattern:"[a-zA-Z0-9-_]+"`
	// ObjectName
	ObjectName *string `json:"ObjectName,omitempty" xml:"ObjectName,omitempty" require:"true"`
}

func (s GetObjectTaggingRequest) String() string {
	return tea.Prettify(s)
}

func (s GetObjectTaggingRequest) GoString() string {
	return s.String()
}

func (s *GetObjectTaggingRequest) SetBucketName(v string) *GetObjectTaggingRequest {
	s.BucketName = &v
	return s
}

func (s *GetObjectTaggingRequest) SetObjectName(v string) *GetObjectTaggingRequest {
	s.ObjectName = &v
	return s
}

type GetObjectTaggingResponse struct {
	// x-oss-request-id
	RequestId *string `json:"x-oss-request-id,omitempty" xml:"x-oss-request-id,omitempty" require:"true"`
	// Tagging
	Tagging *GetObjectTaggingResponseTagging `json:"Tagging,omitempty" xml:"Tagging,omitempty" require:"true" type:"Struct"`
}

func (s GetObjectTaggingResponse) String() string {
	return tea.Prettify(s)
}

func (s GetObjectTaggingResponse) GoString() string {
	return s.String()
}

func (s *GetObjectTaggingResponse) SetRequestId(v string) *GetObjectTaggingResponse {
	s.RequestId = &v
	return s
}

func (s *GetObjectTaggingResponse) SetTagging(v *GetObjectTaggingResponseTagging) *GetObjectTaggingResponse {
	s.Tagging = v
	return s
}

type GetObjectTaggingResponseTagging struct {
	// TagSet
	TagSet *GetObjectTaggingResponseTaggingTagSet `json:"TagSet,omitempty" xml:"TagSet,omitempty" require:"true" type:"Struct"`
}

func (s GetObjectTaggingResponseTagging) String() string {
	return tea.Prettify(s)
}

func (s GetObjectTaggingResponseTagging) GoString() string {
	return s.String()
}

func (s *GetObjectTaggingResponseTagging) SetTagSet(v *GetObjectTaggingResponseTaggingTagSet) *GetObjectTaggingResponseTagging {
	s.TagSet = v
	return s
}

type GetObjectTaggingResponseTaggingTagSet struct {
	// Tag
	Tag []*GetObjectTaggingResponseTaggingTagSetTag `json:"Tag,omitempty" xml:"Tag,omitempty" type:"Repeated"`
}

func (s GetObjectTaggingResponseTaggingTagSet) String() string {
	return tea.Prettify(s)
}

func (s GetObjectTaggingResponseTaggingTagSet) GoString() string {
	return s.String()
}

func (s *GetObjectTaggingResponseTaggingTagSet) SetTag(v []*GetObjectTaggingResponseTaggingTagSetTag) *GetObjectTaggingResponseTaggingTagSet {
	s.Tag = v
	return s
}

type GetObjectTaggingResponseTaggingTagSetTag struct {
	// Key
	Key *string `json:"Key,omitempty" xml:"Key,omitempty"`
	// Value
	Value *string `json:"Value,omitempty" xml:"Value,omitempty"`
}

func (s GetObjectTaggingResponseTaggingTagSetTag) String() string {
	return tea.Prettify(s)
}

func (s GetObjectTaggingResponseTaggingTagSetTag) GoString() string {
	return s.String()
}

func (s *GetObjectTaggingResponseTaggingTagSetTag) SetKey(v string) *GetObjectTaggingResponseTaggingTagSetTag {
	s.Key = &v
	return s
}

func (s *GetObjectTaggingResponseTaggingTagSetTag) SetValue(v string) *GetObjectTaggingResponseTaggingTagSetTag {
	s.Value = &v
	return s
}

type DeleteBucketLifecycleRequest struct {
	// BucketName
	BucketName *string `json:"BucketName,omitempty" xml:"BucketName,omitempty" require:"true" pattern:"[a-zA-Z0-9-_]+"`
}

func (s DeleteBucketLifecycleRequest) String() string {
	return tea.Prettify(s)
}

func (s DeleteBucketLifecycleRequest) GoString() string {
	return s.String()
}

func (s *DeleteBucketLifecycleRequest) SetBucketName(v string) *DeleteBucketLifecycleRequest {
	s.BucketName = &v
	return s
}

type DeleteBucketLifecycleResponse struct {
	// x-oss-request-id
	RequestId *string `json:"x-oss-request-id,omitempty" xml:"x-oss-request-id,omitempty" require:"true"`
}

func (s DeleteBucketLifecycleResponse) String() string {
	return tea.Prettify(s)
}

func (s DeleteBucketLifecycleResponse) GoString() string {
	return s.String()
}

func (s *DeleteBucketLifecycleResponse) SetRequestId(v string) *DeleteBucketLifecycleResponse {
	s.RequestId = &v
	return s
}

type DeleteBucketLoggingRequest struct {
	// BucketName
	BucketName *string `json:"BucketName,omitempty" xml:"BucketName,omitempty" require:"true" pattern:"[a-zA-Z0-9-_]+"`
}

func (s DeleteBucketLoggingRequest) String() string {
	return tea.Prettify(s)
}

func (s DeleteBucketLoggingRequest) GoString() string {
	return s.String()
}

func (s *DeleteBucketLoggingRequest) SetBucketName(v string) *DeleteBucketLoggingRequest {
	s.BucketName = &v
	return s
}

type DeleteBucketLoggingResponse struct {
	// x-oss-request-id
	RequestId *string `json:"x-oss-request-id,omitempty" xml:"x-oss-request-id,omitempty" require:"true"`
}

func (s DeleteBucketLoggingResponse) String() string {
	return tea.Prettify(s)
}

func (s DeleteBucketLoggingResponse) GoString() string {
	return s.String()
}

func (s *DeleteBucketLoggingResponse) SetRequestId(v string) *DeleteBucketLoggingResponse {
	s.RequestId = &v
	return s
}

type DeleteBucketWebsiteRequest struct {
	// BucketName
	BucketName *string `json:"BucketName,omitempty" xml:"BucketName,omitempty" require:"true" pattern:"[a-zA-Z0-9-_]+"`
}

func (s DeleteBucketWebsiteRequest) String() string {
	return tea.Prettify(s)
}

func (s DeleteBucketWebsiteRequest) GoString() string {
	return s.String()
}

func (s *DeleteBucketWebsiteRequest) SetBucketName(v string) *DeleteBucketWebsiteRequest {
	s.BucketName = &v
	return s
}

type DeleteBucketWebsiteResponse struct {
	// x-oss-request-id
	RequestId *string `json:"x-oss-request-id,omitempty" xml:"x-oss-request-id,omitempty" require:"true"`
}

func (s DeleteBucketWebsiteResponse) String() string {
	return tea.Prettify(s)
}

func (s DeleteBucketWebsiteResponse) GoString() string {
	return s.String()
}

func (s *DeleteBucketWebsiteResponse) SetRequestId(v string) *DeleteBucketWebsiteResponse {
	s.RequestId = &v
	return s
}

type GetSymlinkRequest struct {
	// BucketName
	BucketName *string `json:"BucketName,omitempty" xml:"BucketName,omitempty" require:"true" pattern:"[a-zA-Z0-9-_]+"`
	// ObjectName
	ObjectName *string `json:"ObjectName,omitempty" xml:"ObjectName,omitempty" require:"true"`
}

func (s GetSymlinkRequest) String() string {
	return tea.Prettify(s)
}

func (s GetSymlinkRequest) GoString() string {
	return s.String()
}

func (s *GetSymlinkRequest) SetBucketName(v string) *GetSymlinkRequest {
	s.BucketName = &v
	return s
}

func (s *GetSymlinkRequest) SetObjectName(v string) *GetSymlinkRequest {
	s.ObjectName = &v
	return s
}

type GetSymlinkResponse struct {
	// x-oss-request-id
	RequestId *string `json:"x-oss-request-id,omitempty" xml:"x-oss-request-id,omitempty" require:"true"`
	// x-oss-symlink-target
	SymlinkTarget *string `json:"x-oss-symlink-target,omitempty" xml:"x-oss-symlink-target,omitempty" require:"true"`
}

func (s GetSymlinkResponse) String() string {
	return tea.Prettify(s)
}

func (s GetSymlinkResponse) GoString() string {
	return s.String()
}

func (s *GetSymlinkResponse) SetRequestId(v string) *GetSymlinkResponse {
	s.RequestId = &v
	return s
}

func (s *GetSymlinkResponse) SetSymlinkTarget(v string) *GetSymlinkResponse {
	s.SymlinkTarget = &v
	return s
}

type GetBucketLifecycleRequest struct {
	// BucketName
	BucketName *string `json:"BucketName,omitempty" xml:"BucketName,omitempty" require:"true" pattern:"[a-zA-Z0-9-_]+"`
}

func (s GetBucketLifecycleRequest) String() string {
	return tea.Prettify(s)
}

func (s GetBucketLifecycleRequest) GoString() string {
	return s.String()
}

func (s *GetBucketLifecycleRequest) SetBucketName(v string) *GetBucketLifecycleRequest {
	s.BucketName = &v
	return s
}

type GetBucketLifecycleResponse struct {
	// x-oss-request-id
	RequestId *string `json:"x-oss-request-id,omitempty" xml:"x-oss-request-id,omitempty" require:"true"`
	// LifecycleConfiguration
	LifecycleConfiguration *GetBucketLifecycleResponseLifecycleConfiguration `json:"LifecycleConfiguration,omitempty" xml:"LifecycleConfiguration,omitempty" require:"true" type:"Struct"`
}

func (s GetBucketLifecycleResponse) String() string {
	return tea.Prettify(s)
}

func (s GetBucketLifecycleResponse) GoString() string {
	return s.String()
}

func (s *GetBucketLifecycleResponse) SetRequestId(v string) *GetBucketLifecycleResponse {
	s.RequestId = &v
	return s
}

func (s *GetBucketLifecycleResponse) SetLifecycleConfiguration(v *GetBucketLifecycleResponseLifecycleConfiguration) *GetBucketLifecycleResponse {
	s.LifecycleConfiguration = v
	return s
}

type GetBucketLifecycleResponseLifecycleConfiguration struct {
	// Rule
	Rule []*GetBucketLifecycleResponseLifecycleConfigurationRule `json:"Rule,omitempty" xml:"Rule,omitempty" type:"Repeated"`
}

func (s GetBucketLifecycleResponseLifecycleConfiguration) String() string {
	return tea.Prettify(s)
}

func (s GetBucketLifecycleResponseLifecycleConfiguration) GoString() string {
	return s.String()
}

func (s *GetBucketLifecycleResponseLifecycleConfiguration) SetRule(v []*GetBucketLifecycleResponseLifecycleConfigurationRule) *GetBucketLifecycleResponseLifecycleConfiguration {
	s.Rule = v
	return s
}

type GetBucketLifecycleResponseLifecycleConfigurationRule struct {
	// ID
	ID *string `json:"ID,omitempty" xml:"ID,omitempty"`
	// Prefix
	Prefix *string `json:"Prefix,omitempty" xml:"Prefix,omitempty"`
	// Status
	Status *string `json:"Status,omitempty" xml:"Status,omitempty"`
	// Expiration
	Expiration *GetBucketLifecycleResponseLifecycleConfigurationRuleExpiration `json:"Expiration,omitempty" xml:"Expiration,omitempty" require:"true" type:"Struct"`
	// Transition
	Transition *GetBucketLifecycleResponseLifecycleConfigurationRuleTransition `json:"Transition,omitempty" xml:"Transition,omitempty" require:"true" type:"Struct"`
	// AbortMultipartUpload
	AbortMultipartUpload *GetBucketLifecycleResponseLifecycleConfigurationRuleAbortMultipartUpload `json:"AbortMultipartUpload,omitempty" xml:"AbortMultipartUpload,omitempty" require:"true" type:"Struct"`
	// Tag
	Tag *GetBucketLifecycleResponseLifecycleConfigurationRuleTag `json:"Tag,omitempty" xml:"Tag,omitempty" require:"true" type:"Struct"`
}

func (s GetBucketLifecycleResponseLifecycleConfigurationRule) String() string {
	return tea.Prettify(s)
}

func (s GetBucketLifecycleResponseLifecycleConfigurationRule) GoString() string {
	return s.String()
}

func (s *GetBucketLifecycleResponseLifecycleConfigurationRule) SetID(v string) *GetBucketLifecycleResponseLifecycleConfigurationRule {
	s.ID = &v
	return s
}

func (s *GetBucketLifecycleResponseLifecycleConfigurationRule) SetPrefix(v string) *GetBucketLifecycleResponseLifecycleConfigurationRule {
	s.Prefix = &v
	return s
}

func (s *GetBucketLifecycleResponseLifecycleConfigurationRule) SetStatus(v string) *GetBucketLifecycleResponseLifecycleConfigurationRule {
	s.Status = &v
	return s
}

func (s *GetBucketLifecycleResponseLifecycleConfigurationRule) SetExpiration(v *GetBucketLifecycleResponseLifecycleConfigurationRuleExpiration) *GetBucketLifecycleResponseLifecycleConfigurationRule {
	s.Expiration = v
	return s
}

func (s *GetBucketLifecycleResponseLifecycleConfigurationRule) SetTransition(v *GetBucketLifecycleResponseLifecycleConfigurationRuleTransition) *GetBucketLifecycleResponseLifecycleConfigurationRule {
	s.Transition = v
	return s
}

func (s *GetBucketLifecycleResponseLifecycleConfigurationRule) SetAbortMultipartUpload(v *GetBucketLifecycleResponseLifecycleConfigurationRuleAbortMultipartUpload) *GetBucketLifecycleResponseLifecycleConfigurationRule {
	s.AbortMultipartUpload = v
	return s
}

func (s *GetBucketLifecycleResponseLifecycleConfigurationRule) SetTag(v *GetBucketLifecycleResponseLifecycleConfigurationRuleTag) *GetBucketLifecycleResponseLifecycleConfigurationRule {
	s.Tag = v
	return s
}

type GetBucketLifecycleResponseLifecycleConfigurationRuleExpiration struct {
	// Days
	Days *int `json:"Days,omitempty" xml:"Days,omitempty"`
	// CreatedBeforeDate
	CreatedBeforeDate *string `json:"CreatedBeforeDate,omitempty" xml:"CreatedBeforeDate,omitempty"`
}

func (s GetBucketLifecycleResponseLifecycleConfigurationRuleExpiration) String() string {
	return tea.Prettify(s)
}

func (s GetBucketLifecycleResponseLifecycleConfigurationRuleExpiration) GoString() string {
	return s.String()
}

func (s *GetBucketLifecycleResponseLifecycleConfigurationRuleExpiration) SetDays(v int) *GetBucketLifecycleResponseLifecycleConfigurationRuleExpiration {
	s.Days = &v
	return s
}

func (s *GetBucketLifecycleResponseLifecycleConfigurationRuleExpiration) SetCreatedBeforeDate(v string) *GetBucketLifecycleResponseLifecycleConfigurationRuleExpiration {
	s.CreatedBeforeDate = &v
	return s
}

type GetBucketLifecycleResponseLifecycleConfigurationRuleTransition struct {
	// Days
	Days *int `json:"Days,omitempty" xml:"Days,omitempty"`
	// StorageClass
	StorageClass *string `json:"StorageClass,omitempty" xml:"StorageClass,omitempty"`
}

func (s GetBucketLifecycleResponseLifecycleConfigurationRuleTransition) String() string {
	return tea.Prettify(s)
}

func (s GetBucketLifecycleResponseLifecycleConfigurationRuleTransition) GoString() string {
	return s.String()
}

func (s *GetBucketLifecycleResponseLifecycleConfigurationRuleTransition) SetDays(v int) *GetBucketLifecycleResponseLifecycleConfigurationRuleTransition {
	s.Days = &v
	return s
}

func (s *GetBucketLifecycleResponseLifecycleConfigurationRuleTransition) SetStorageClass(v string) *GetBucketLifecycleResponseLifecycleConfigurationRuleTransition {
	s.StorageClass = &v
	return s
}

type GetBucketLifecycleResponseLifecycleConfigurationRuleAbortMultipartUpload struct {
	// Days
	Days *int `json:"Days,omitempty" xml:"Days,omitempty"`
	// CreatedBeforeDate
	CreatedBeforeDate *string `json:"CreatedBeforeDate,omitempty" xml:"CreatedBeforeDate,omitempty"`
}

func (s GetBucketLifecycleResponseLifecycleConfigurationRuleAbortMultipartUpload) String() string {
	return tea.Prettify(s)
}

func (s GetBucketLifecycleResponseLifecycleConfigurationRuleAbortMultipartUpload) GoString() string {
	return s.String()
}

func (s *GetBucketLifecycleResponseLifecycleConfigurationRuleAbortMultipartUpload) SetDays(v int) *GetBucketLifecycleResponseLifecycleConfigurationRuleAbortMultipartUpload {
	s.Days = &v
	return s
}

func (s *GetBucketLifecycleResponseLifecycleConfigurationRuleAbortMultipartUpload) SetCreatedBeforeDate(v string) *GetBucketLifecycleResponseLifecycleConfigurationRuleAbortMultipartUpload {
	s.CreatedBeforeDate = &v
	return s
}

type GetBucketLifecycleResponseLifecycleConfigurationRuleTag struct {
	// Key
	Key *string `json:"Key,omitempty" xml:"Key,omitempty"`
	// Value
	Value *string `json:"Value,omitempty" xml:"Value,omitempty"`
}

func (s GetBucketLifecycleResponseLifecycleConfigurationRuleTag) String() string {
	return tea.Prettify(s)
}

func (s GetBucketLifecycleResponseLifecycleConfigurationRuleTag) GoString() string {
	return s.String()
}

func (s *GetBucketLifecycleResponseLifecycleConfigurationRuleTag) SetKey(v string) *GetBucketLifecycleResponseLifecycleConfigurationRuleTag {
	s.Key = &v
	return s
}

func (s *GetBucketLifecycleResponseLifecycleConfigurationRuleTag) SetValue(v string) *GetBucketLifecycleResponseLifecycleConfigurationRuleTag {
	s.Value = &v
	return s
}

type PutSymlinkRequest struct {
	// BucketName
	BucketName *string `json:"BucketName,omitempty" xml:"BucketName,omitempty" require:"true" pattern:"[a-zA-Z0-9-_]+"`
	// ObjectName
	ObjectName *string `json:"ObjectName,omitempty" xml:"ObjectName,omitempty" require:"true"`
	// Header
	Header *PutSymlinkRequestHeader `json:"Header,omitempty" xml:"Header,omitempty" require:"true" type:"Struct"`
}

func (s PutSymlinkRequest) String() string {
	return tea.Prettify(s)
}

func (s PutSymlinkRequest) GoString() string {
	return s.String()
}

func (s *PutSymlinkRequest) SetBucketName(v string) *PutSymlinkRequest {
	s.BucketName = &v
	return s
}

func (s *PutSymlinkRequest) SetObjectName(v string) *PutSymlinkRequest {
	s.ObjectName = &v
	return s
}

func (s *PutSymlinkRequest) SetHeader(v *PutSymlinkRequestHeader) *PutSymlinkRequest {
	s.Header = v
	return s
}

type PutSymlinkRequestHeader struct {
	// x-oss-symlink-target
	SymlinkTarget *string `json:"x-oss-symlink-target,omitempty" xml:"x-oss-symlink-target,omitempty" require:"true"`
	// x-oss-storage-class
	StorageClass *string `json:"x-oss-storage-class,omitempty" xml:"x-oss-storage-class,omitempty"`
}

func (s PutSymlinkRequestHeader) String() string {
	return tea.Prettify(s)
}

func (s PutSymlinkRequestHeader) GoString() string {
	return s.String()
}

func (s *PutSymlinkRequestHeader) SetSymlinkTarget(v string) *PutSymlinkRequestHeader {
	s.SymlinkTarget = &v
	return s
}

func (s *PutSymlinkRequestHeader) SetStorageClass(v string) *PutSymlinkRequestHeader {
	s.StorageClass = &v
	return s
}

type PutSymlinkResponse struct {
	// x-oss-request-id
	RequestId *string `json:"x-oss-request-id,omitempty" xml:"x-oss-request-id,omitempty" require:"true"`
}

func (s PutSymlinkResponse) String() string {
	return tea.Prettify(s)
}

func (s PutSymlinkResponse) GoString() string {
	return s.String()
}

func (s *PutSymlinkResponse) SetRequestId(v string) *PutSymlinkResponse {
	s.RequestId = &v
	return s
}

type GetBucketRefererRequest struct {
	// BucketName
	BucketName *string `json:"BucketName,omitempty" xml:"BucketName,omitempty" require:"true" pattern:"[a-zA-Z0-9-_]+"`
}

func (s GetBucketRefererRequest) String() string {
	return tea.Prettify(s)
}

func (s GetBucketRefererRequest) GoString() string {
	return s.String()
}

func (s *GetBucketRefererRequest) SetBucketName(v string) *GetBucketRefererRequest {
	s.BucketName = &v
	return s
}

type GetBucketRefererResponse struct {
	// x-oss-request-id
	RequestId *string `json:"x-oss-request-id,omitempty" xml:"x-oss-request-id,omitempty" require:"true"`
	// RefererConfiguration
	RefererConfiguration *GetBucketRefererResponseRefererConfiguration `json:"RefererConfiguration,omitempty" xml:"RefererConfiguration,omitempty" require:"true" type:"Struct"`
}

func (s GetBucketRefererResponse) String() string {
	return tea.Prettify(s)
}

func (s GetBucketRefererResponse) GoString() string {
	return s.String()
}

func (s *GetBucketRefererResponse) SetRequestId(v string) *GetBucketRefererResponse {
	s.RequestId = &v
	return s
}

func (s *GetBucketRefererResponse) SetRefererConfiguration(v *GetBucketRefererResponseRefererConfiguration) *GetBucketRefererResponse {
	s.RefererConfiguration = v
	return s
}

type GetBucketRefererResponseRefererConfiguration struct {
	// AllowEmptyReferer
	AllowEmptyReferer *bool `json:"AllowEmptyReferer,omitempty" xml:"AllowEmptyReferer,omitempty"`
	// RefererList
	RefererList *GetBucketRefererResponseRefererConfigurationRefererList `json:"RefererList,omitempty" xml:"RefererList,omitempty" require:"true" type:"Struct"`
}

func (s GetBucketRefererResponseRefererConfiguration) String() string {
	return tea.Prettify(s)
}

func (s GetBucketRefererResponseRefererConfiguration) GoString() string {
	return s.String()
}

func (s *GetBucketRefererResponseRefererConfiguration) SetAllowEmptyReferer(v bool) *GetBucketRefererResponseRefererConfiguration {
	s.AllowEmptyReferer = &v
	return s
}

func (s *GetBucketRefererResponseRefererConfiguration) SetRefererList(v *GetBucketRefererResponseRefererConfigurationRefererList) *GetBucketRefererResponseRefererConfiguration {
	s.RefererList = v
	return s
}

type GetBucketRefererResponseRefererConfigurationRefererList struct {
	// Referer
	Referer []*string `json:"Referer,omitempty" xml:"Referer,omitempty" type:"Repeated"`
}

func (s GetBucketRefererResponseRefererConfigurationRefererList) String() string {
	return tea.Prettify(s)
}

func (s GetBucketRefererResponseRefererConfigurationRefererList) GoString() string {
	return s.String()
}

func (s *GetBucketRefererResponseRefererConfigurationRefererList) SetReferer(v []*string) *GetBucketRefererResponseRefererConfigurationRefererList {
	s.Referer = v
	return s
}

type CallbackRequest struct {
	// BucketName
	BucketName *string `json:"BucketName,omitempty" xml:"BucketName,omitempty" require:"true" pattern:"[a-zA-Z0-9-_]+"`
}

func (s CallbackRequest) String() string {
	return tea.Prettify(s)
}

func (s CallbackRequest) GoString() string {
	return s.String()
}

func (s *CallbackRequest) SetBucketName(v string) *CallbackRequest {
	s.BucketName = &v
	return s
}

type CallbackResponse struct {
	// x-oss-request-id
	RequestId *string `json:"x-oss-request-id,omitempty" xml:"x-oss-request-id,omitempty" require:"true"`
}

func (s CallbackResponse) String() string {
	return tea.Prettify(s)
}

func (s CallbackResponse) GoString() string {
	return s.String()
}

func (s *CallbackResponse) SetRequestId(v string) *CallbackResponse {
	s.RequestId = &v
	return s
}

type GetBucketLoggingRequest struct {
	// BucketName
	BucketName *string `json:"BucketName,omitempty" xml:"BucketName,omitempty" require:"true" pattern:"[a-zA-Z0-9-_]+"`
}

func (s GetBucketLoggingRequest) String() string {
	return tea.Prettify(s)
}

func (s GetBucketLoggingRequest) GoString() string {
	return s.String()
}

func (s *GetBucketLoggingRequest) SetBucketName(v string) *GetBucketLoggingRequest {
	s.BucketName = &v
	return s
}

type GetBucketLoggingResponse struct {
	// x-oss-request-id
	RequestId *string `json:"x-oss-request-id,omitempty" xml:"x-oss-request-id,omitempty" require:"true"`
	// BucketLoggingStatus
	BucketLoggingStatus *GetBucketLoggingResponseBucketLoggingStatus `json:"BucketLoggingStatus,omitempty" xml:"BucketLoggingStatus,omitempty" require:"true" type:"Struct"`
}

func (s GetBucketLoggingResponse) String() string {
	return tea.Prettify(s)
}

func (s GetBucketLoggingResponse) GoString() string {
	return s.String()
}

func (s *GetBucketLoggingResponse) SetRequestId(v string) *GetBucketLoggingResponse {
	s.RequestId = &v
	return s
}

func (s *GetBucketLoggingResponse) SetBucketLoggingStatus(v *GetBucketLoggingResponseBucketLoggingStatus) *GetBucketLoggingResponse {
	s.BucketLoggingStatus = v
	return s
}

type GetBucketLoggingResponseBucketLoggingStatus struct {
	// LoggingEnabled
	LoggingEnabled *GetBucketLoggingResponseBucketLoggingStatusLoggingEnabled `json:"LoggingEnabled,omitempty" xml:"LoggingEnabled,omitempty" require:"true" type:"Struct"`
}

func (s GetBucketLoggingResponseBucketLoggingStatus) String() string {
	return tea.Prettify(s)
}

func (s GetBucketLoggingResponseBucketLoggingStatus) GoString() string {
	return s.String()
}

func (s *GetBucketLoggingResponseBucketLoggingStatus) SetLoggingEnabled(v *GetBucketLoggingResponseBucketLoggingStatusLoggingEnabled) *GetBucketLoggingResponseBucketLoggingStatus {
	s.LoggingEnabled = v
	return s
}

type GetBucketLoggingResponseBucketLoggingStatusLoggingEnabled struct {
	// TargetBucket
	TargetBucket *string `json:"TargetBucket,omitempty" xml:"TargetBucket,omitempty"`
	// TargetPrefix
	TargetPrefix *string `json:"TargetPrefix,omitempty" xml:"TargetPrefix,omitempty"`
}

func (s GetBucketLoggingResponseBucketLoggingStatusLoggingEnabled) String() string {
	return tea.Prettify(s)
}

func (s GetBucketLoggingResponseBucketLoggingStatusLoggingEnabled) GoString() string {
	return s.String()
}

func (s *GetBucketLoggingResponseBucketLoggingStatusLoggingEnabled) SetTargetBucket(v string) *GetBucketLoggingResponseBucketLoggingStatusLoggingEnabled {
	s.TargetBucket = &v
	return s
}

func (s *GetBucketLoggingResponseBucketLoggingStatusLoggingEnabled) SetTargetPrefix(v string) *GetBucketLoggingResponseBucketLoggingStatusLoggingEnabled {
	s.TargetPrefix = &v
	return s
}

type PutObjectAclRequest struct {
	// BucketName
	BucketName *string `json:"BucketName,omitempty" xml:"BucketName,omitempty" require:"true" pattern:"[a-zA-Z0-9-_]+"`
	// ObjectName
	ObjectName *string `json:"ObjectName,omitempty" xml:"ObjectName,omitempty" require:"true"`
	// Header
	Header *PutObjectAclRequestHeader `json:"Header,omitempty" xml:"Header,omitempty" require:"true" type:"Struct"`
}

func (s PutObjectAclRequest) String() string {
	return tea.Prettify(s)
}

func (s PutObjectAclRequest) GoString() string {
	return s.String()
}

func (s *PutObjectAclRequest) SetBucketName(v string) *PutObjectAclRequest {
	s.BucketName = &v
	return s
}

func (s *PutObjectAclRequest) SetObjectName(v string) *PutObjectAclRequest {
	s.ObjectName = &v
	return s
}

func (s *PutObjectAclRequest) SetHeader(v *PutObjectAclRequestHeader) *PutObjectAclRequest {
	s.Header = v
	return s
}

type PutObjectAclRequestHeader struct {
	// x-oss-object-acl
	ObjectAcl *string `json:"x-oss-object-acl,omitempty" xml:"x-oss-object-acl,omitempty" require:"true"`
}

func (s PutObjectAclRequestHeader) String() string {
	return tea.Prettify(s)
}

func (s PutObjectAclRequestHeader) GoString() string {
	return s.String()
}

func (s *PutObjectAclRequestHeader) SetObjectAcl(v string) *PutObjectAclRequestHeader {
	s.ObjectAcl = &v
	return s
}

type PutObjectAclResponse struct {
	// x-oss-request-id
	RequestId *string `json:"x-oss-request-id,omitempty" xml:"x-oss-request-id,omitempty" require:"true"`
}

func (s PutObjectAclResponse) String() string {
	return tea.Prettify(s)
}

func (s PutObjectAclResponse) GoString() string {
	return s.String()
}

func (s *PutObjectAclResponse) SetRequestId(v string) *PutObjectAclResponse {
	s.RequestId = &v
	return s
}

type GetBucketInfoRequest struct {
	// BucketName
	BucketName *string `json:"BucketName,omitempty" xml:"BucketName,omitempty" require:"true" pattern:"[a-zA-Z0-9-_]+"`
}

func (s GetBucketInfoRequest) String() string {
	return tea.Prettify(s)
}

func (s GetBucketInfoRequest) GoString() string {
	return s.String()
}

func (s *GetBucketInfoRequest) SetBucketName(v string) *GetBucketInfoRequest {
	s.BucketName = &v
	return s
}

type GetBucketInfoResponse struct {
	// x-oss-request-id
	RequestId *string `json:"x-oss-request-id,omitempty" xml:"x-oss-request-id,omitempty" require:"true"`
	// BucketInfo
	BucketInfo *GetBucketInfoResponseBucketInfo `json:"BucketInfo,omitempty" xml:"BucketInfo,omitempty" require:"true" type:"Struct"`
}

func (s GetBucketInfoResponse) String() string {
	return tea.Prettify(s)
}

func (s GetBucketInfoResponse) GoString() string {
	return s.String()
}

func (s *GetBucketInfoResponse) SetRequestId(v string) *GetBucketInfoResponse {
	s.RequestId = &v
	return s
}

func (s *GetBucketInfoResponse) SetBucketInfo(v *GetBucketInfoResponseBucketInfo) *GetBucketInfoResponse {
	s.BucketInfo = v
	return s
}

type GetBucketInfoResponseBucketInfo struct {
	// Bucket
	Bucket *GetBucketInfoResponseBucketInfoBucket `json:"Bucket,omitempty" xml:"Bucket,omitempty" require:"true" type:"Struct"`
}

func (s GetBucketInfoResponseBucketInfo) String() string {
	return tea.Prettify(s)
}

func (s GetBucketInfoResponseBucketInfo) GoString() string {
	return s.String()
}

func (s *GetBucketInfoResponseBucketInfo) SetBucket(v *GetBucketInfoResponseBucketInfoBucket) *GetBucketInfoResponseBucketInfo {
	s.Bucket = v
	return s
}

type GetBucketInfoResponseBucketInfoBucket struct {
	// CreationDate
	CreationDate *string `json:"CreationDate,omitempty" xml:"CreationDate,omitempty"`
	// ExtranetEndpoint
	ExtranetEndpoint *string `json:"ExtranetEndpoint,omitempty" xml:"ExtranetEndpoint,omitempty"`
	// IntranetEndpoint
	IntranetEndpoint *string `json:"IntranetEndpoint,omitempty" xml:"IntranetEndpoint,omitempty"`
	// Location
	Location *string `json:"Location,omitempty" xml:"Location,omitempty"`
	// Name
	Name *string `json:"Name,omitempty" xml:"Name,omitempty"`
	// DataRedundancyType
	DataRedundancyType *string `json:"DataRedundancyType,omitempty" xml:"DataRedundancyType,omitempty"`
	// StorageClass
	StorageClass *string `json:"StorageClass,omitempty" xml:"StorageClass,omitempty"`
	// Comment
	Comment *string `json:"Comment,omitempty" xml:"Comment,omitempty"`
	// Owner
	Owner *GetBucketInfoResponseBucketInfoBucketOwner `json:"Owner,omitempty" xml:"Owner,omitempty" require:"true" type:"Struct"`
	// AccessControlList
	AccessControlList *GetBucketInfoResponseBucketInfoBucketAccessControlList `json:"AccessControlList,omitempty" xml:"AccessControlList,omitempty" require:"true" type:"Struct"`
}

func (s GetBucketInfoResponseBucketInfoBucket) String() string {
	return tea.Prettify(s)
}

func (s GetBucketInfoResponseBucketInfoBucket) GoString() string {
	return s.String()
}

func (s *GetBucketInfoResponseBucketInfoBucket) SetCreationDate(v string) *GetBucketInfoResponseBucketInfoBucket {
	s.CreationDate = &v
	return s
}

func (s *GetBucketInfoResponseBucketInfoBucket) SetExtranetEndpoint(v string) *GetBucketInfoResponseBucketInfoBucket {
	s.ExtranetEndpoint = &v
	return s
}

func (s *GetBucketInfoResponseBucketInfoBucket) SetIntranetEndpoint(v string) *GetBucketInfoResponseBucketInfoBucket {
	s.IntranetEndpoint = &v
	return s
}

func (s *GetBucketInfoResponseBucketInfoBucket) SetLocation(v string) *GetBucketInfoResponseBucketInfoBucket {
	s.Location = &v
	return s
}

func (s *GetBucketInfoResponseBucketInfoBucket) SetName(v string) *GetBucketInfoResponseBucketInfoBucket {
	s.Name = &v
	return s
}

func (s *GetBucketInfoResponseBucketInfoBucket) SetDataRedundancyType(v string) *GetBucketInfoResponseBucketInfoBucket {
	s.DataRedundancyType = &v
	return s
}

func (s *GetBucketInfoResponseBucketInfoBucket) SetStorageClass(v string) *GetBucketInfoResponseBucketInfoBucket {
	s.StorageClass = &v
	return s
}

func (s *GetBucketInfoResponseBucketInfoBucket) SetComment(v string) *GetBucketInfoResponseBucketInfoBucket {
	s.Comment = &v
	return s
}

func (s *GetBucketInfoResponseBucketInfoBucket) SetOwner(v *GetBucketInfoResponseBucketInfoBucketOwner) *GetBucketInfoResponseBucketInfoBucket {
	s.Owner = v
	return s
}

func (s *GetBucketInfoResponseBucketInfoBucket) SetAccessControlList(v *GetBucketInfoResponseBucketInfoBucketAccessControlList) *GetBucketInfoResponseBucketInfoBucket {
	s.AccessControlList = v
	return s
}

type GetBucketInfoResponseBucketInfoBucketOwner struct {
	// ID
	ID *string `json:"ID,omitempty" xml:"ID,omitempty"`
	// DisplayName
	DisplayName *string `json:"DisplayName,omitempty" xml:"DisplayName,omitempty"`
}

func (s GetBucketInfoResponseBucketInfoBucketOwner) String() string {
	return tea.Prettify(s)
}

func (s GetBucketInfoResponseBucketInfoBucketOwner) GoString() string {
	return s.String()
}

func (s *GetBucketInfoResponseBucketInfoBucketOwner) SetID(v string) *GetBucketInfoResponseBucketInfoBucketOwner {
	s.ID = &v
	return s
}

func (s *GetBucketInfoResponseBucketInfoBucketOwner) SetDisplayName(v string) *GetBucketInfoResponseBucketInfoBucketOwner {
	s.DisplayName = &v
	return s
}

type GetBucketInfoResponseBucketInfoBucketAccessControlList struct {
	// Grant
	Grant *string `json:"Grant,omitempty" xml:"Grant,omitempty"`
}

func (s GetBucketInfoResponseBucketInfoBucketAccessControlList) String() string {
	return tea.Prettify(s)
}

func (s GetBucketInfoResponseBucketInfoBucketAccessControlList) GoString() string {
	return s.String()
}

func (s *GetBucketInfoResponseBucketInfoBucketAccessControlList) SetGrant(v string) *GetBucketInfoResponseBucketInfoBucketAccessControlList {
	s.Grant = &v
	return s
}

type PutLiveChannelStatusRequest struct {
	// BucketName
	BucketName *string `json:"BucketName,omitempty" xml:"BucketName,omitempty" require:"true" pattern:"[a-zA-Z0-9-_]+"`
	// ChannelName
	ChannelName *string `json:"ChannelName,omitempty" xml:"ChannelName,omitempty" require:"true"`
	// Filter
	Filter *PutLiveChannelStatusRequestFilter `json:"Filter,omitempty" xml:"Filter,omitempty" require:"true" type:"Struct"`
}

func (s PutLiveChannelStatusRequest) String() string {
	return tea.Prettify(s)
}

func (s PutLiveChannelStatusRequest) GoString() string {
	return s.String()
}

func (s *PutLiveChannelStatusRequest) SetBucketName(v string) *PutLiveChannelStatusRequest {
	s.BucketName = &v
	return s
}

func (s *PutLiveChannelStatusRequest) SetChannelName(v string) *PutLiveChannelStatusRequest {
	s.ChannelName = &v
	return s
}

func (s *PutLiveChannelStatusRequest) SetFilter(v *PutLiveChannelStatusRequestFilter) *PutLiveChannelStatusRequest {
	s.Filter = v
	return s
}

type PutLiveChannelStatusRequestFilter struct {
	// status
	Status *string `json:"status,omitempty" xml:"status,omitempty" require:"true" signed:"true"`
}

func (s PutLiveChannelStatusRequestFilter) String() string {
	return tea.Prettify(s)
}

func (s PutLiveChannelStatusRequestFilter) GoString() string {
	return s.String()
}

func (s *PutLiveChannelStatusRequestFilter) SetStatus(v string) *PutLiveChannelStatusRequestFilter {
	s.Status = &v
	return s
}

type PutLiveChannelStatusResponse struct {
	// x-oss-request-id
	RequestId *string `json:"x-oss-request-id,omitempty" xml:"x-oss-request-id,omitempty" require:"true"`
}

func (s PutLiveChannelStatusResponse) String() string {
	return tea.Prettify(s)
}

func (s PutLiveChannelStatusResponse) GoString() string {
	return s.String()
}

func (s *PutLiveChannelStatusResponse) SetRequestId(v string) *PutLiveChannelStatusResponse {
	s.RequestId = &v
	return s
}

type InitiateMultipartUploadRequest struct {
	// BucketName
	BucketName *string `json:"BucketName,omitempty" xml:"BucketName,omitempty" require:"true" pattern:"[a-zA-Z0-9-_]+"`
	// ObjectName
	ObjectName *string `json:"ObjectName,omitempty" xml:"ObjectName,omitempty" require:"true"`
	// Filter
	Filter *InitiateMultipartUploadRequestFilter `json:"Filter,omitempty" xml:"Filter,omitempty" type:"Struct"`
	// Header
	Header *InitiateMultipartUploadRequestHeader `json:"Header,omitempty" xml:"Header,omitempty" type:"Struct"`
}

func (s InitiateMultipartUploadRequest) String() string {
	return tea.Prettify(s)
}

func (s InitiateMultipartUploadRequest) GoString() string {
	return s.String()
}

func (s *InitiateMultipartUploadRequest) SetBucketName(v string) *InitiateMultipartUploadRequest {
	s.BucketName = &v
	return s
}

func (s *InitiateMultipartUploadRequest) SetObjectName(v string) *InitiateMultipartUploadRequest {
	s.ObjectName = &v
	return s
}

func (s *InitiateMultipartUploadRequest) SetFilter(v *InitiateMultipartUploadRequestFilter) *InitiateMultipartUploadRequest {
	s.Filter = v
	return s
}

func (s *InitiateMultipartUploadRequest) SetHeader(v *InitiateMultipartUploadRequestHeader) *InitiateMultipartUploadRequest {
	s.Header = v
	return s
}

type InitiateMultipartUploadRequestFilter struct {
	// encoding-type
	EncodingType *string `json:"encoding-type,omitempty" xml:"encoding-type,omitempty"`
}

func (s InitiateMultipartUploadRequestFilter) String() string {
	return tea.Prettify(s)
}

func (s InitiateMultipartUploadRequestFilter) GoString() string {
	return s.String()
}

func (s *InitiateMultipartUploadRequestFilter) SetEncodingType(v string) *InitiateMultipartUploadRequestFilter {
	s.EncodingType = &v
	return s
}

type InitiateMultipartUploadRequestHeader struct {
	// Cache-Control
	CacheControl *string `json:"Cache-Control,omitempty" xml:"Cache-Control,omitempty"`
	// Content-Disposition
	ContentDisposition *string `json:"Content-Disposition,omitempty" xml:"Content-Disposition,omitempty"`
	// Content-Encoding
	ContentEncoding *string `json:"Content-Encoding,omitempty" xml:"Content-Encoding,omitempty"`
	// Expires
	Expires *string `json:"Expires,omitempty" xml:"Expires,omitempty"`
	// x-oss-server-side-encryption
	ServerSideEncryption *string `json:"x-oss-server-side-encryption,omitempty" xml:"x-oss-server-side-encryption,omitempty"`
	// x-oss-server-side-encryption-key-id
	ServerSideEncryptionKeyId *string `json:"x-oss-server-side-encryption-key-id,omitempty" xml:"x-oss-server-side-encryption-key-id,omitempty"`
	// x-oss-storage-class
	StorageClass *string `json:"x-oss-storage-class,omitempty" xml:"x-oss-storage-class,omitempty"`
	// x-oss-tagging
	Tagging *string `json:"x-oss-tagging,omitempty" xml:"x-oss-tagging,omitempty"`
	// content-type
	ContentType *string `json:"content-type,omitempty" xml:"content-type,omitempty"`
}

func (s InitiateMultipartUploadRequestHeader) String() string {
	return tea.Prettify(s)
}

func (s InitiateMultipartUploadRequestHeader) GoString() string {
	return s.String()
}

func (s *InitiateMultipartUploadRequestHeader) SetCacheControl(v string) *InitiateMultipartUploadRequestHeader {
	s.CacheControl = &v
	return s
}

func (s *InitiateMultipartUploadRequestHeader) SetContentDisposition(v string) *InitiateMultipartUploadRequestHeader {
	s.ContentDisposition = &v
	return s
}

func (s *InitiateMultipartUploadRequestHeader) SetContentEncoding(v string) *InitiateMultipartUploadRequestHeader {
	s.ContentEncoding = &v
	return s
}

func (s *InitiateMultipartUploadRequestHeader) SetExpires(v string) *InitiateMultipartUploadRequestHeader {
	s.Expires = &v
	return s
}

func (s *InitiateMultipartUploadRequestHeader) SetServerSideEncryption(v string) *InitiateMultipartUploadRequestHeader {
	s.ServerSideEncryption = &v
	return s
}

func (s *InitiateMultipartUploadRequestHeader) SetServerSideEncryptionKeyId(v string) *InitiateMultipartUploadRequestHeader {
	s.ServerSideEncryptionKeyId = &v
	return s
}

func (s *InitiateMultipartUploadRequestHeader) SetStorageClass(v string) *InitiateMultipartUploadRequestHeader {
	s.StorageClass = &v
	return s
}

func (s *InitiateMultipartUploadRequestHeader) SetTagging(v string) *InitiateMultipartUploadRequestHeader {
	s.Tagging = &v
	return s
}

func (s *InitiateMultipartUploadRequestHeader) SetContentType(v string) *InitiateMultipartUploadRequestHeader {
	s.ContentType = &v
	return s
}

type InitiateMultipartUploadResponse struct {
	// x-oss-request-id
	RequestId *string `json:"x-oss-request-id,omitempty" xml:"x-oss-request-id,omitempty" require:"true"`
	// InitiateMultipartUploadResult
	InitiateMultipartUploadResult *InitiateMultipartUploadResponseInitiateMultipartUploadResult `json:"InitiateMultipartUploadResult,omitempty" xml:"InitiateMultipartUploadResult,omitempty" require:"true" type:"Struct"`
}

func (s InitiateMultipartUploadResponse) String() string {
	return tea.Prettify(s)
}

func (s InitiateMultipartUploadResponse) GoString() string {
	return s.String()
}

func (s *InitiateMultipartUploadResponse) SetRequestId(v string) *InitiateMultipartUploadResponse {
	s.RequestId = &v
	return s
}

func (s *InitiateMultipartUploadResponse) SetInitiateMultipartUploadResult(v *InitiateMultipartUploadResponseInitiateMultipartUploadResult) *InitiateMultipartUploadResponse {
	s.InitiateMultipartUploadResult = v
	return s
}

type InitiateMultipartUploadResponseInitiateMultipartUploadResult struct {
	// Bucket
	Bucket *string `json:"Bucket,omitempty" xml:"Bucket,omitempty"`
	// Key
	Key *string `json:"Key,omitempty" xml:"Key,omitempty"`
	// UploadId
	UploadId *string `json:"UploadId,omitempty" xml:"UploadId,omitempty"`
}

func (s InitiateMultipartUploadResponseInitiateMultipartUploadResult) String() string {
	return tea.Prettify(s)
}

func (s InitiateMultipartUploadResponseInitiateMultipartUploadResult) GoString() string {
	return s.String()
}

func (s *InitiateMultipartUploadResponseInitiateMultipartUploadResult) SetBucket(v string) *InitiateMultipartUploadResponseInitiateMultipartUploadResult {
	s.Bucket = &v
	return s
}

func (s *InitiateMultipartUploadResponseInitiateMultipartUploadResult) SetKey(v string) *InitiateMultipartUploadResponseInitiateMultipartUploadResult {
	s.Key = &v
	return s
}

func (s *InitiateMultipartUploadResponseInitiateMultipartUploadResult) SetUploadId(v string) *InitiateMultipartUploadResponseInitiateMultipartUploadResult {
	s.UploadId = &v
	return s
}

type OptionObjectRequest struct {
	// BucketName
	BucketName *string `json:"BucketName,omitempty" xml:"BucketName,omitempty" require:"true" pattern:"[a-zA-Z0-9-_]+"`
	// ObjectName
	ObjectName *string `json:"ObjectName,omitempty" xml:"ObjectName,omitempty" require:"true"`
	// Header
	Header *OptionObjectRequestHeader `json:"Header,omitempty" xml:"Header,omitempty" require:"true" type:"Struct"`
}

func (s OptionObjectRequest) String() string {
	return tea.Prettify(s)
}

func (s OptionObjectRequest) GoString() string {
	return s.String()
}

func (s *OptionObjectRequest) SetBucketName(v string) *OptionObjectRequest {
	s.BucketName = &v
	return s
}

func (s *OptionObjectRequest) SetObjectName(v string) *OptionObjectRequest {
	s.ObjectName = &v
	return s
}

func (s *OptionObjectRequest) SetHeader(v *OptionObjectRequestHeader) *OptionObjectRequest {
	s.Header = v
	return s
}

type OptionObjectRequestHeader struct {
	// Origin
	Origin *string `json:"Origin,omitempty" xml:"Origin,omitempty" require:"true"`
	// Access-Control-Request-Method
	AccessControlRequestMethod *string `json:"Access-Control-Request-Method,omitempty" xml:"Access-Control-Request-Method,omitempty" require:"true"`
	// Access-Control-Request-Headers
	AccessControlRequestHeaders *string `json:"Access-Control-Request-Headers,omitempty" xml:"Access-Control-Request-Headers,omitempty" require:"true"`
}

func (s OptionObjectRequestHeader) String() string {
	return tea.Prettify(s)
}

func (s OptionObjectRequestHeader) GoString() string {
	return s.String()
}

func (s *OptionObjectRequestHeader) SetOrigin(v string) *OptionObjectRequestHeader {
	s.Origin = &v
	return s
}

func (s *OptionObjectRequestHeader) SetAccessControlRequestMethod(v string) *OptionObjectRequestHeader {
	s.AccessControlRequestMethod = &v
	return s
}

func (s *OptionObjectRequestHeader) SetAccessControlRequestHeaders(v string) *OptionObjectRequestHeader {
	s.AccessControlRequestHeaders = &v
	return s
}

type OptionObjectResponse struct {
	// x-oss-request-id
	RequestId *string `json:"x-oss-request-id,omitempty" xml:"x-oss-request-id,omitempty" require:"true"`
	// Access-Control-Allow-Origin
	AccessControlAllowOrigin *string `json:"access-control-allow-origin,omitempty" xml:"access-control-allow-origin,omitempty" require:"true"`
	// Access-Control-Allow-Methods
	AccessControlAllowMethods *string `json:"access-control-allow-methods,omitempty" xml:"access-control-allow-methods,omitempty" require:"true"`
	// Access-Control-Allow-Headers
	AccessControlAllowHeaders *string `json:"access-control-allow-headers,omitempty" xml:"access-control-allow-headers,omitempty" require:"true"`
	// Access-Control-Expose-Headers
	AccessControlExposeHeaders *string `json:"access-control-expose-headers,omitempty" xml:"access-control-expose-headers,omitempty" require:"true"`
	// Access-Control-Max-Age
	AccessControlMaxAge *string `json:"access-control-max-age,omitempty" xml:"access-control-max-age,omitempty" require:"true"`
}

func (s OptionObjectResponse) String() string {
	return tea.Prettify(s)
}

func (s OptionObjectResponse) GoString() string {
	return s.String()
}

func (s *OptionObjectResponse) SetRequestId(v string) *OptionObjectResponse {
	s.RequestId = &v
	return s
}

func (s *OptionObjectResponse) SetAccessControlAllowOrigin(v string) *OptionObjectResponse {
	s.AccessControlAllowOrigin = &v
	return s
}

func (s *OptionObjectResponse) SetAccessControlAllowMethods(v string) *OptionObjectResponse {
	s.AccessControlAllowMethods = &v
	return s
}

func (s *OptionObjectResponse) SetAccessControlAllowHeaders(v string) *OptionObjectResponse {
	s.AccessControlAllowHeaders = &v
	return s
}

func (s *OptionObjectResponse) SetAccessControlExposeHeaders(v string) *OptionObjectResponse {
	s.AccessControlExposeHeaders = &v
	return s
}

func (s *OptionObjectResponse) SetAccessControlMaxAge(v string) *OptionObjectResponse {
	s.AccessControlMaxAge = &v
	return s
}

type PostVodPlaylistRequest struct {
	// BucketName
	BucketName *string `json:"BucketName,omitempty" xml:"BucketName,omitempty" require:"true" pattern:"[a-zA-Z0-9-_]+"`
	// ChannelName
	ChannelName *string `json:"ChannelName,omitempty" xml:"ChannelName,omitempty" require:"true"`
	// PlaylistName
	PlaylistName *string `json:"PlaylistName,omitempty" xml:"PlaylistName,omitempty" require:"true"`
	// Filter
	Filter *PostVodPlaylistRequestFilter `json:"Filter,omitempty" xml:"Filter,omitempty" require:"true" type:"Struct"`
}

func (s PostVodPlaylistRequest) String() string {
	return tea.Prettify(s)
}

func (s PostVodPlaylistRequest) GoString() string {
	return s.String()
}

func (s *PostVodPlaylistRequest) SetBucketName(v string) *PostVodPlaylistRequest {
	s.BucketName = &v
	return s
}

func (s *PostVodPlaylistRequest) SetChannelName(v string) *PostVodPlaylistRequest {
	s.ChannelName = &v
	return s
}

func (s *PostVodPlaylistRequest) SetPlaylistName(v string) *PostVodPlaylistRequest {
	s.PlaylistName = &v
	return s
}

func (s *PostVodPlaylistRequest) SetFilter(v *PostVodPlaylistRequestFilter) *PostVodPlaylistRequest {
	s.Filter = v
	return s
}

type PostVodPlaylistRequestFilter struct {
	// endTime
	EndTime *string `json:"endTime,omitempty" xml:"endTime,omitempty" require:"true" signed:"true"`
	// startTime
	StartTime *string `json:"startTime,omitempty" xml:"startTime,omitempty" require:"true" signed:"true"`
}

func (s PostVodPlaylistRequestFilter) String() string {
	return tea.Prettify(s)
}

func (s PostVodPlaylistRequestFilter) GoString() string {
	return s.String()
}

func (s *PostVodPlaylistRequestFilter) SetEndTime(v string) *PostVodPlaylistRequestFilter {
	s.EndTime = &v
	return s
}

func (s *PostVodPlaylistRequestFilter) SetStartTime(v string) *PostVodPlaylistRequestFilter {
	s.StartTime = &v
	return s
}

type PostVodPlaylistResponse struct {
	// x-oss-request-id
	RequestId *string `json:"x-oss-request-id,omitempty" xml:"x-oss-request-id,omitempty" require:"true"`
}

func (s PostVodPlaylistResponse) String() string {
	return tea.Prettify(s)
}

func (s PostVodPlaylistResponse) GoString() string {
	return s.String()
}

func (s *PostVodPlaylistResponse) SetRequestId(v string) *PostVodPlaylistResponse {
	s.RequestId = &v
	return s
}

type PostObjectRequest struct {
	// BucketName
	BucketName *string `json:"BucketName,omitempty" xml:"BucketName,omitempty" require:"true" pattern:"[a-zA-Z0-9-_]+"`
	// header
	Header *PostObjectRequestHeader `json:"header,omitempty" xml:"header,omitempty" require:"true" type:"Struct"`
}

func (s PostObjectRequest) String() string {
	return tea.Prettify(s)
}

func (s PostObjectRequest) GoString() string {
	return s.String()
}

func (s *PostObjectRequest) SetBucketName(v string) *PostObjectRequest {
	s.BucketName = &v
	return s
}

func (s *PostObjectRequest) SetHeader(v *PostObjectRequestHeader) *PostObjectRequest {
	s.Header = v
	return s
}

type PostObjectRequestHeader struct {
	// OSSAccessKeyId
	AccessKeyId *string `json:"OSSAccessKeyId,omitempty" xml:"OSSAccessKeyId,omitempty" require:"true"`
	// policy
	Policy *string `json:"policy,omitempty" xml:"policy,omitempty" require:"true"`
	// Signature
	Signature *string `json:"Signature,omitempty" xml:"Signature,omitempty" require:"true"`
	// success_action_status
	SuccessActionStatus *string             `json:"success_action_status,omitempty" xml:"success_action_status,omitempty"`
	File                *fileform.FileField `json:"file,omitempty" xml:"file,omitempty" require:"true"`
	// key
	Key *string `json:"key,omitempty" xml:"key,omitempty" require:"true"`
	// UserMeta
	UserMeta map[string]*string `json:"UserMeta,omitempty" xml:"UserMeta,omitempty"`
}

func (s PostObjectRequestHeader) String() string {
	return tea.Prettify(s)
}

func (s PostObjectRequestHeader) GoString() string {
	return s.String()
}

func (s *PostObjectRequestHeader) SetAccessKeyId(v string) *PostObjectRequestHeader {
	s.AccessKeyId = &v
	return s
}

func (s *PostObjectRequestHeader) SetPolicy(v string) *PostObjectRequestHeader {
	s.Policy = &v
	return s
}

func (s *PostObjectRequestHeader) SetSignature(v string) *PostObjectRequestHeader {
	s.Signature = &v
	return s
}

func (s *PostObjectRequestHeader) SetSuccessActionStatus(v string) *PostObjectRequestHeader {
	s.SuccessActionStatus = &v
	return s
}

func (s *PostObjectRequestHeader) SetFile(v *fileform.FileField) *PostObjectRequestHeader {
	s.File = v
	return s
}

func (s *PostObjectRequestHeader) SetKey(v string) *PostObjectRequestHeader {
	s.Key = &v
	return s
}

func (s *PostObjectRequestHeader) SetUserMeta(v map[string]*string) *PostObjectRequestHeader {
	s.UserMeta = v
	return s
}

type PostObjectResponse struct {
	// PostResponse
	PostResponse *PostObjectResponsePostResponse `json:"PostResponse,omitempty" xml:"PostResponse,omitempty" require:"true" type:"Struct"`
}

func (s PostObjectResponse) String() string {
	return tea.Prettify(s)
}

func (s PostObjectResponse) GoString() string {
	return s.String()
}

func (s *PostObjectResponse) SetPostResponse(v *PostObjectResponsePostResponse) *PostObjectResponse {
	s.PostResponse = v
	return s
}

type PostObjectResponsePostResponse struct {
	// Bucket
	Bucket *string `json:"Bucket,omitempty" xml:"Bucket,omitempty" require:"true"`
	// ETag
	ETag *string `json:"ETag,omitempty" xml:"ETag,omitempty" require:"true"`
	// Location
	Location *string `json:"Location,omitempty" xml:"Location,omitempty" require:"true"`
}

func (s PostObjectResponsePostResponse) String() string {
	return tea.Prettify(s)
}

func (s PostObjectResponsePostResponse) GoString() string {
	return s.String()
}

func (s *PostObjectResponsePostResponse) SetBucket(v string) *PostObjectResponsePostResponse {
	s.Bucket = &v
	return s
}

func (s *PostObjectResponsePostResponse) SetETag(v string) *PostObjectResponsePostResponse {
	s.ETag = &v
	return s
}

func (s *PostObjectResponsePostResponse) SetLocation(v string) *PostObjectResponsePostResponse {
	s.Location = &v
	return s
}

type HeadObjectRequest struct {
	// BucketName
	BucketName *string `json:"BucketName,omitempty" xml:"BucketName,omitempty" require:"true" pattern:"[a-zA-Z0-9-_]+"`
	// ObjectName
	ObjectName *string `json:"ObjectName,omitempty" xml:"ObjectName,omitempty" require:"true"`
	// Header
	Header *HeadObjectRequestHeader `json:"Header,omitempty" xml:"Header,omitempty" type:"Struct"`
}

func (s HeadObjectRequest) String() string {
	return tea.Prettify(s)
}

func (s HeadObjectRequest) GoString() string {
	return s.String()
}

func (s *HeadObjectRequest) SetBucketName(v string) *HeadObjectRequest {
	s.BucketName = &v
	return s
}

func (s *HeadObjectRequest) SetObjectName(v string) *HeadObjectRequest {
	s.ObjectName = &v
	return s
}

func (s *HeadObjectRequest) SetHeader(v *HeadObjectRequestHeader) *HeadObjectRequest {
	s.Header = v
	return s
}

type HeadObjectRequestHeader struct {
	// If-Modified-Since
	IfModifiedSince *string `json:"If-Modified-Since,omitempty" xml:"If-Modified-Since,omitempty"`
	// If-Unmodified-Since
	IfUnmodifiedSince *string `json:"If-Unmodified-Since,omitempty" xml:"If-Unmodified-Since,omitempty"`
	// If-Match
	IfMatch *string `json:"If-Match,omitempty" xml:"If-Match,omitempty"`
	// If-None-Match
	IfNoneMatch *string `json:"If-None-Match,omitempty" xml:"If-None-Match,omitempty"`
}

func (s HeadObjectRequestHeader) String() string {
	return tea.Prettify(s)
}

func (s HeadObjectRequestHeader) GoString() string {
	return s.String()
}

func (s *HeadObjectRequestHeader) SetIfModifiedSince(v string) *HeadObjectRequestHeader {
	s.IfModifiedSince = &v
	return s
}

func (s *HeadObjectRequestHeader) SetIfUnmodifiedSince(v string) *HeadObjectRequestHeader {
	s.IfUnmodifiedSince = &v
	return s
}

func (s *HeadObjectRequestHeader) SetIfMatch(v string) *HeadObjectRequestHeader {
	s.IfMatch = &v
	return s
}

func (s *HeadObjectRequestHeader) SetIfNoneMatch(v string) *HeadObjectRequestHeader {
	s.IfNoneMatch = &v
	return s
}

type HeadObjectResponse struct {
	// x-oss-request-id
	RequestId *string `json:"x-oss-request-id,omitempty" xml:"x-oss-request-id,omitempty" require:"true"`
	// usermeta
	UserMeta map[string]*string `json:"usermeta,omitempty" xml:"usermeta,omitempty" require:"true"`
	// x-oss-server-side-encryption
	ServerSideEncryption *string `json:"x-oss-server-side-encryption,omitempty" xml:"x-oss-server-side-encryption,omitempty" require:"true"`
	// x-oss-server-side-encryption-key-id
	ServerSideEncryptionKeyId *string `json:"x-oss-server-side-encryption-key-id,omitempty" xml:"x-oss-server-side-encryption-key-id,omitempty" require:"true"`
	// x-oss-storage-class
	StorageClass *string `json:"x-oss-storage-class,omitempty" xml:"x-oss-storage-class,omitempty" require:"true"`
	// x-oss-object-type
	ObjectType *string `json:"x-oss-object-type,omitempty" xml:"x-oss-object-type,omitempty" require:"true"`
	// x-oss-next-append-position
	NextAppendPosition *string `json:"x-oss-next-append-position,omitempty" xml:"x-oss-next-append-position,omitempty" require:"true"`
	// x-oss-hash-crc64ecma
	HashCrc64ecma *string `json:"x-oss-hash-crc64ecma,omitempty" xml:"x-oss-hash-crc64ecma,omitempty" require:"true"`
	// x-oss-expiration
	Expiration *string `json:"x-oss-expiration,omitempty" xml:"x-oss-expiration,omitempty" require:"true"`
	// x-oss-restore
	Restore *string `json:"x-oss-restore,omitempty" xml:"x-oss-restore,omitempty" require:"true"`
	// x-oss-process-status
	ProcessStatus *string `json:"x-oss-process-status,omitempty" xml:"x-oss-process-status,omitempty" require:"true"`
	// x-oss-request-charged
	RequestCharged *string `json:"x-oss-request-charged,omitempty" xml:"x-oss-request-charged,omitempty" require:"true"`
	// Content-Md5
	ContentMd5 *string `json:"content-md5,omitempty" xml:"content-md5,omitempty" require:"true"`
	// Last-Modified
	LastModified *string `json:"last-modified,omitempty" xml:"last-modified,omitempty" require:"true"`
	// Access-Control-Allow-Origin
	AccessControlAllowOrigin *string `json:"access-control-allow-origin,omitempty" xml:"access-control-allow-origin,omitempty" require:"true"`
	// Access-Control-Allow-Methods
	AccessControlAllowMethods *string `json:"access-control-allow-methods,omitempty" xml:"access-control-allow-methods,omitempty" require:"true"`
	// Access-Control-Max-Age
	AccessControlMaxAge *string `json:"access-control-max-age,omitempty" xml:"access-control-max-age,omitempty" require:"true"`
	// Access-Control-Allow-Headers
	AccessControlAllowHeaders *string `json:"access-control-allow-headers,omitempty" xml:"access-control-allow-headers,omitempty" require:"true"`
	// Access-Control-Expose-Headers
	AccessControlExposeHeaders *string `json:"access-control-expose-headers,omitempty" xml:"access-control-expose-headers,omitempty" require:"true"`
	// x-oss-tagging-count
	TaggingCount *string `json:"x-oss-tagging-count,omitempty" xml:"x-oss-tagging-count,omitempty" require:"true"`
}

func (s HeadObjectResponse) String() string {
	return tea.Prettify(s)
}

func (s HeadObjectResponse) GoString() string {
	return s.String()
}

func (s *HeadObjectResponse) SetRequestId(v string) *HeadObjectResponse {
	s.RequestId = &v
	return s
}

func (s *HeadObjectResponse) SetUserMeta(v map[string]*string) *HeadObjectResponse {
	s.UserMeta = v
	return s
}

func (s *HeadObjectResponse) SetServerSideEncryption(v string) *HeadObjectResponse {
	s.ServerSideEncryption = &v
	return s
}

func (s *HeadObjectResponse) SetServerSideEncryptionKeyId(v string) *HeadObjectResponse {
	s.ServerSideEncryptionKeyId = &v
	return s
}

func (s *HeadObjectResponse) SetStorageClass(v string) *HeadObjectResponse {
	s.StorageClass = &v
	return s
}

func (s *HeadObjectResponse) SetObjectType(v string) *HeadObjectResponse {
	s.ObjectType = &v
	return s
}

func (s *HeadObjectResponse) SetNextAppendPosition(v string) *HeadObjectResponse {
	s.NextAppendPosition = &v
	return s
}

func (s *HeadObjectResponse) SetHashCrc64ecma(v string) *HeadObjectResponse {
	s.HashCrc64ecma = &v
	return s
}

func (s *HeadObjectResponse) SetExpiration(v string) *HeadObjectResponse {
	s.Expiration = &v
	return s
}

func (s *HeadObjectResponse) SetRestore(v string) *HeadObjectResponse {
	s.Restore = &v
	return s
}

func (s *HeadObjectResponse) SetProcessStatus(v string) *HeadObjectResponse {
	s.ProcessStatus = &v
	return s
}

func (s *HeadObjectResponse) SetRequestCharged(v string) *HeadObjectResponse {
	s.RequestCharged = &v
	return s
}

func (s *HeadObjectResponse) SetContentMd5(v string) *HeadObjectResponse {
	s.ContentMd5 = &v
	return s
}

func (s *HeadObjectResponse) SetLastModified(v string) *HeadObjectResponse {
	s.LastModified = &v
	return s
}

func (s *HeadObjectResponse) SetAccessControlAllowOrigin(v string) *HeadObjectResponse {
	s.AccessControlAllowOrigin = &v
	return s
}

func (s *HeadObjectResponse) SetAccessControlAllowMethods(v string) *HeadObjectResponse {
	s.AccessControlAllowMethods = &v
	return s
}

func (s *HeadObjectResponse) SetAccessControlMaxAge(v string) *HeadObjectResponse {
	s.AccessControlMaxAge = &v
	return s
}

func (s *HeadObjectResponse) SetAccessControlAllowHeaders(v string) *HeadObjectResponse {
	s.AccessControlAllowHeaders = &v
	return s
}

func (s *HeadObjectResponse) SetAccessControlExposeHeaders(v string) *HeadObjectResponse {
	s.AccessControlExposeHeaders = &v
	return s
}

func (s *HeadObjectResponse) SetTaggingCount(v string) *HeadObjectResponse {
	s.TaggingCount = &v
	return s
}

type DeleteObjectTaggingRequest struct {
	// BucketName
	BucketName *string `json:"BucketName,omitempty" xml:"BucketName,omitempty" require:"true" pattern:"[a-zA-Z0-9-_]+"`
	// ObjectName
	ObjectName *string `json:"ObjectName,omitempty" xml:"ObjectName,omitempty" require:"true"`
}

func (s DeleteObjectTaggingRequest) String() string {
	return tea.Prettify(s)
}

func (s DeleteObjectTaggingRequest) GoString() string {
	return s.String()
}

func (s *DeleteObjectTaggingRequest) SetBucketName(v string) *DeleteObjectTaggingRequest {
	s.BucketName = &v
	return s
}

func (s *DeleteObjectTaggingRequest) SetObjectName(v string) *DeleteObjectTaggingRequest {
	s.ObjectName = &v
	return s
}

type DeleteObjectTaggingResponse struct {
	// x-oss-request-id
	RequestId *string `json:"x-oss-request-id,omitempty" xml:"x-oss-request-id,omitempty" require:"true"`
}

func (s DeleteObjectTaggingResponse) String() string {
	return tea.Prettify(s)
}

func (s DeleteObjectTaggingResponse) GoString() string {
	return s.String()
}

func (s *DeleteObjectTaggingResponse) SetRequestId(v string) *DeleteObjectTaggingResponse {
	s.RequestId = &v
	return s
}

type RestoreObjectRequest struct {
	// BucketName
	BucketName *string `json:"BucketName,omitempty" xml:"BucketName,omitempty" require:"true" pattern:"[a-zA-Z0-9-_]+"`
	// ObjectName
	ObjectName *string `json:"ObjectName,omitempty" xml:"ObjectName,omitempty" require:"true"`
}

func (s RestoreObjectRequest) String() string {
	return tea.Prettify(s)
}

func (s RestoreObjectRequest) GoString() string {
	return s.String()
}

func (s *RestoreObjectRequest) SetBucketName(v string) *RestoreObjectRequest {
	s.BucketName = &v
	return s
}

func (s *RestoreObjectRequest) SetObjectName(v string) *RestoreObjectRequest {
	s.ObjectName = &v
	return s
}

type RestoreObjectResponse struct {
	// x-oss-request-id
	RequestId *string `json:"x-oss-request-id,omitempty" xml:"x-oss-request-id,omitempty" require:"true"`
}

func (s RestoreObjectResponse) String() string {
	return tea.Prettify(s)
}

func (s RestoreObjectResponse) GoString() string {
	return s.String()
}

func (s *RestoreObjectResponse) SetRequestId(v string) *RestoreObjectResponse {
	s.RequestId = &v
	return s
}

type GetObjectAclRequest struct {
	// BucketName
	BucketName *string `json:"BucketName,omitempty" xml:"BucketName,omitempty" require:"true" pattern:"[a-zA-Z0-9-_]+"`
	// ObjectName
	ObjectName *string `json:"ObjectName,omitempty" xml:"ObjectName,omitempty" require:"true"`
}

func (s GetObjectAclRequest) String() string {
	return tea.Prettify(s)
}

func (s GetObjectAclRequest) GoString() string {
	return s.String()
}

func (s *GetObjectAclRequest) SetBucketName(v string) *GetObjectAclRequest {
	s.BucketName = &v
	return s
}

func (s *GetObjectAclRequest) SetObjectName(v string) *GetObjectAclRequest {
	s.ObjectName = &v
	return s
}

type GetObjectAclResponse struct {
	// x-oss-request-id
	RequestId *string `json:"x-oss-request-id,omitempty" xml:"x-oss-request-id,omitempty" require:"true"`
	// AccessControlPolicy
	AccessControlPolicy *GetObjectAclResponseAccessControlPolicy `json:"AccessControlPolicy,omitempty" xml:"AccessControlPolicy,omitempty" require:"true" type:"Struct"`
}

func (s GetObjectAclResponse) String() string {
	return tea.Prettify(s)
}

func (s GetObjectAclResponse) GoString() string {
	return s.String()
}

func (s *GetObjectAclResponse) SetRequestId(v string) *GetObjectAclResponse {
	s.RequestId = &v
	return s
}

func (s *GetObjectAclResponse) SetAccessControlPolicy(v *GetObjectAclResponseAccessControlPolicy) *GetObjectAclResponse {
	s.AccessControlPolicy = v
	return s
}

type GetObjectAclResponseAccessControlPolicy struct {
	// Owner
	Owner *GetObjectAclResponseAccessControlPolicyOwner `json:"Owner,omitempty" xml:"Owner,omitempty" require:"true" type:"Struct"`
	// AccessControlList
	AccessControlList *GetObjectAclResponseAccessControlPolicyAccessControlList `json:"AccessControlList,omitempty" xml:"AccessControlList,omitempty" require:"true" type:"Struct"`
}

func (s GetObjectAclResponseAccessControlPolicy) String() string {
	return tea.Prettify(s)
}

func (s GetObjectAclResponseAccessControlPolicy) GoString() string {
	return s.String()
}

func (s *GetObjectAclResponseAccessControlPolicy) SetOwner(v *GetObjectAclResponseAccessControlPolicyOwner) *GetObjectAclResponseAccessControlPolicy {
	s.Owner = v
	return s
}

func (s *GetObjectAclResponseAccessControlPolicy) SetAccessControlList(v *GetObjectAclResponseAccessControlPolicyAccessControlList) *GetObjectAclResponseAccessControlPolicy {
	s.AccessControlList = v
	return s
}

type GetObjectAclResponseAccessControlPolicyOwner struct {
	// ID
	ID *string `json:"ID,omitempty" xml:"ID,omitempty"`
	// DisplayName
	DisplayName *string `json:"DisplayName,omitempty" xml:"DisplayName,omitempty"`
}

func (s GetObjectAclResponseAccessControlPolicyOwner) String() string {
	return tea.Prettify(s)
}

func (s GetObjectAclResponseAccessControlPolicyOwner) GoString() string {
	return s.String()
}

func (s *GetObjectAclResponseAccessControlPolicyOwner) SetID(v string) *GetObjectAclResponseAccessControlPolicyOwner {
	s.ID = &v
	return s
}

func (s *GetObjectAclResponseAccessControlPolicyOwner) SetDisplayName(v string) *GetObjectAclResponseAccessControlPolicyOwner {
	s.DisplayName = &v
	return s
}

type GetObjectAclResponseAccessControlPolicyAccessControlList struct {
	// Grant
	Grant *string `json:"Grant,omitempty" xml:"Grant,omitempty"`
}

func (s GetObjectAclResponseAccessControlPolicyAccessControlList) String() string {
	return tea.Prettify(s)
}

func (s GetObjectAclResponseAccessControlPolicyAccessControlList) GoString() string {
	return s.String()
}

func (s *GetObjectAclResponseAccessControlPolicyAccessControlList) SetGrant(v string) *GetObjectAclResponseAccessControlPolicyAccessControlList {
	s.Grant = &v
	return s
}

type PutBucketAclRequest struct {
	// BucketName
	BucketName *string `json:"BucketName,omitempty" xml:"BucketName,omitempty" require:"true" pattern:"[a-zA-Z0-9-_]+"`
	// Header
	Header *PutBucketAclRequestHeader `json:"Header,omitempty" xml:"Header,omitempty" require:"true" type:"Struct"`
}

func (s PutBucketAclRequest) String() string {
	return tea.Prettify(s)
}

func (s PutBucketAclRequest) GoString() string {
	return s.String()
}

func (s *PutBucketAclRequest) SetBucketName(v string) *PutBucketAclRequest {
	s.BucketName = &v
	return s
}

func (s *PutBucketAclRequest) SetHeader(v *PutBucketAclRequestHeader) *PutBucketAclRequest {
	s.Header = v
	return s
}

type PutBucketAclRequestHeader struct {
	// x-oss-acl
	Acl *string `json:"x-oss-acl,omitempty" xml:"x-oss-acl,omitempty" require:"true"`
}

func (s PutBucketAclRequestHeader) String() string {
	return tea.Prettify(s)
}

func (s PutBucketAclRequestHeader) GoString() string {
	return s.String()
}

func (s *PutBucketAclRequestHeader) SetAcl(v string) *PutBucketAclRequestHeader {
	s.Acl = &v
	return s
}

type PutBucketAclResponse struct {
	// x-oss-request-id
	RequestId *string `json:"x-oss-request-id,omitempty" xml:"x-oss-request-id,omitempty" require:"true"`
}

func (s PutBucketAclResponse) String() string {
	return tea.Prettify(s)
}

func (s PutBucketAclResponse) GoString() string {
	return s.String()
}

func (s *PutBucketAclResponse) SetRequestId(v string) *PutBucketAclResponse {
	s.RequestId = &v
	return s
}

type DeleteBucketRequest struct {
	// BucketName
	BucketName *string `json:"BucketName,omitempty" xml:"BucketName,omitempty" require:"true" pattern:"[a-zA-Z0-9-_]+"`
}

func (s DeleteBucketRequest) String() string {
	return tea.Prettify(s)
}

func (s DeleteBucketRequest) GoString() string {
	return s.String()
}

func (s *DeleteBucketRequest) SetBucketName(v string) *DeleteBucketRequest {
	s.BucketName = &v
	return s
}

type DeleteBucketResponse struct {
	// x-oss-request-id
	RequestId *string `json:"x-oss-request-id,omitempty" xml:"x-oss-request-id,omitempty" require:"true"`
}

func (s DeleteBucketResponse) String() string {
	return tea.Prettify(s)
}

func (s DeleteBucketResponse) GoString() string {
	return s.String()
}

func (s *DeleteBucketResponse) SetRequestId(v string) *DeleteBucketResponse {
	s.RequestId = &v
	return s
}

type PutObjectRequest struct {
	// BucketName
	BucketName *string `json:"BucketName,omitempty" xml:"BucketName,omitempty" require:"true" pattern:"[a-zA-Z0-9-_]+"`
	// ObjectName
	ObjectName *string `json:"ObjectName,omitempty" xml:"ObjectName,omitempty" require:"true"`
	// UserMeta
	UserMeta map[string]*string `json:"UserMeta,omitempty" xml:"UserMeta,omitempty"`
	// body
	Body io.Reader `json:"body,omitempty" xml:"body,omitempty"`
	// Header
	Header *PutObjectRequestHeader `json:"Header,omitempty" xml:"Header,omitempty" type:"Struct"`
}

func (s PutObjectRequest) String() string {
	return tea.Prettify(s)
}

func (s PutObjectRequest) GoString() string {
	return s.String()
}

func (s *PutObjectRequest) SetBucketName(v string) *PutObjectRequest {
	s.BucketName = &v
	return s
}

func (s *PutObjectRequest) SetObjectName(v string) *PutObjectRequest {
	s.ObjectName = &v
	return s
}

func (s *PutObjectRequest) SetUserMeta(v map[string]*string) *PutObjectRequest {
	s.UserMeta = v
	return s
}

func (s *PutObjectRequest) SetBody(v io.Reader) *PutObjectRequest {
	s.Body = v
	return s
}

func (s *PutObjectRequest) SetHeader(v *PutObjectRequestHeader) *PutObjectRequest {
	s.Header = v
	return s
}

type PutObjectRequestHeader struct {
	// Authorization
	Authorization *string `json:"Authorization,omitempty" xml:"Authorization,omitempty"`
	// Cache-Control
	CacheControl *string `json:"Cache-Control,omitempty" xml:"Cache-Control,omitempty"`
	// Content-Disposition
	ContentDisposition *string `json:"Content-Disposition,omitempty" xml:"Content-Disposition,omitempty"`
	// Content-Encoding
	ContentEncoding *string `json:"Content-Encoding,omitempty" xml:"Content-Encoding,omitempty"`
	// Content-MD5
	ContentMD5 *string `json:"Content-MD5,omitempty" xml:"Content-MD5,omitempty"`
	// Content-Length
	ContentLength *string `json:"Content-Length,omitempty" xml:"Content-Length,omitempty"`
	// CETag
	ETag *string `json:"CETag,omitempty" xml:"CETag,omitempty"`
	// Expires
	Expires *string `json:"Expires,omitempty" xml:"Expires,omitempty"`
	// x-oss-server-side-encryption
	ServerSideEncryption *string `json:"x-oss-server-side-encryption,omitempty" xml:"x-oss-server-side-encryption,omitempty"`
	// x-oss-server-side-encryption-key-id
	ServerSideEncryptionKeyId *string `json:"x-oss-server-side-encryption-key-id,omitempty" xml:"x-oss-server-side-encryption-key-id,omitempty"`
	// x-oss-object-acl
	ObjectAcl *string `json:"x-oss-object-acl,omitempty" xml:"x-oss-object-acl,omitempty"`
	// x-oss-storage-class
	StorageClass *string `json:"x-oss-storage-class,omitempty" xml:"x-oss-storage-class,omitempty"`
	// x-oss-tagging
	Tagging *string `json:"x-oss-tagging,omitempty" xml:"x-oss-tagging,omitempty"`
	// content-type
	ContentType *string `json:"content-type,omitempty" xml:"content-type,omitempty"`
}

func (s PutObjectRequestHeader) String() string {
	return tea.Prettify(s)
}

func (s PutObjectRequestHeader) GoString() string {
	return s.String()
}

func (s *PutObjectRequestHeader) SetAuthorization(v string) *PutObjectRequestHeader {
	s.Authorization = &v
	return s
}

func (s *PutObjectRequestHeader) SetCacheControl(v string) *PutObjectRequestHeader {
	s.CacheControl = &v
	return s
}

func (s *PutObjectRequestHeader) SetContentDisposition(v string) *PutObjectRequestHeader {
	s.ContentDisposition = &v
	return s
}

func (s *PutObjectRequestHeader) SetContentEncoding(v string) *PutObjectRequestHeader {
	s.ContentEncoding = &v
	return s
}

func (s *PutObjectRequestHeader) SetContentMD5(v string) *PutObjectRequestHeader {
	s.ContentMD5 = &v
	return s
}

func (s *PutObjectRequestHeader) SetContentLength(v string) *PutObjectRequestHeader {
	s.ContentLength = &v
	return s
}

func (s *PutObjectRequestHeader) SetETag(v string) *PutObjectRequestHeader {
	s.ETag = &v
	return s
}

func (s *PutObjectRequestHeader) SetExpires(v string) *PutObjectRequestHeader {
	s.Expires = &v
	return s
}

func (s *PutObjectRequestHeader) SetServerSideEncryption(v string) *PutObjectRequestHeader {
	s.ServerSideEncryption = &v
	return s
}

func (s *PutObjectRequestHeader) SetServerSideEncryptionKeyId(v string) *PutObjectRequestHeader {
	s.ServerSideEncryptionKeyId = &v
	return s
}

func (s *PutObjectRequestHeader) SetObjectAcl(v string) *PutObjectRequestHeader {
	s.ObjectAcl = &v
	return s
}

func (s *PutObjectRequestHeader) SetStorageClass(v string) *PutObjectRequestHeader {
	s.StorageClass = &v
	return s
}

func (s *PutObjectRequestHeader) SetTagging(v string) *PutObjectRequestHeader {
	s.Tagging = &v
	return s
}

func (s *PutObjectRequestHeader) SetContentType(v string) *PutObjectRequestHeader {
	s.ContentType = &v
	return s
}

type PutObjectResponse struct {
	// x-oss-request-id
	RequestId *string `json:"x-oss-request-id,omitempty" xml:"x-oss-request-id,omitempty" require:"true"`
	// x-oss-hash-crc64ecma
	HashCrc64ecma *string `json:"x-oss-hash-crc64ecma,omitempty" xml:"x-oss-hash-crc64ecma,omitempty" require:"true"`
	// x-oss-server-time
	ServerTime *string `json:"x-oss-server-time,omitempty" xml:"x-oss-server-time,omitempty" require:"true"`
	// x-oss-bucket-version
	BucketVersion *string `json:"x-oss-bucket-version,omitempty" xml:"x-oss-bucket-version,omitempty" require:"true"`
}

func (s PutObjectResponse) String() string {
	return tea.Prettify(s)
}

func (s PutObjectResponse) GoString() string {
	return s.String()
}

func (s *PutObjectResponse) SetRequestId(v string) *PutObjectResponse {
	s.RequestId = &v
	return s
}

func (s *PutObjectResponse) SetHashCrc64ecma(v string) *PutObjectResponse {
	s.HashCrc64ecma = &v
	return s
}

func (s *PutObjectResponse) SetServerTime(v string) *PutObjectResponse {
	s.ServerTime = &v
	return s
}

func (s *PutObjectResponse) SetBucketVersion(v string) *PutObjectResponse {
	s.BucketVersion = &v
	return s
}

type Client struct {
	Endpoint         *string
	RegionId         *string
	HostModel        *string
	Protocol         *string
	ReadTimeout      *int
	ConnectTimeout   *int
	SignatureVersion *string
	AddtionalHeaders []*string
	LocalAddr        *string
	HttpProxy        *string
	HttpsProxy       *string
	NoProxy          *string
	UserAgent        *string
	Socks5Proxy      *string
	IsEnableCrc      *bool
	IsEnableMD5      *bool
	Socks5NetWork    *string
	MaxIdleConns     *int
	Credential       credential.Credential
}

func NewClient(config *Config) (*Client, error) {
	client := new(Client)
	err := client.Init(config)
	return client, err
}

func (client *Client) Init(config *Config) (_err error) {
	if tea.BoolValue(util.IsUnset(tea.ToMap(config))) {
		_err = tea.NewSDKError(map[string]interface{}{
			"name":    "ParameterMissing",
			"message": "'config' can not be unset",
		})
		return _err
	}

	if tea.BoolValue(util.Empty(config.Type)) {
		config.Type = tea.String("access_key")
	}

	credentialConfig := &credential.Config{
		AccessKeyId:     config.AccessKeyId,
		Type:            config.Type,
		AccessKeySecret: config.AccessKeySecret,
		SecurityToken:   config.SecurityToken,
	}
	client.Credential, _err = credential.NewCredential(credentialConfig)
	if _err != nil {
		return _err
	}

	if tea.BoolValue(util.IsUnset(config.IsEnableMD5)) {
		config.IsEnableMD5 = tea.Bool(false)
	}

	if tea.BoolValue(util.IsUnset(config.IsEnableCrc)) {
		config.IsEnableCrc = tea.Bool(false)
	}

	client.Endpoint = config.Endpoint
	client.Protocol = config.Protocol
	client.RegionId = config.RegionId
	client.UserAgent = config.UserAgent
	client.ReadTimeout = config.ReadTimeout
	client.ConnectTimeout = config.ConnectTimeout
	client.LocalAddr = config.LocalAddr
	client.HttpProxy = config.HttpProxy
	client.HttpsProxy = config.HttpsProxy
	client.NoProxy = config.NoProxy
	client.Socks5Proxy = config.Socks5Proxy
	client.Socks5NetWork = config.Socks5NetWork
	client.MaxIdleConns = config.MaxIdleConns
	client.SignatureVersion = config.SignatureVersion
	client.AddtionalHeaders = config.AddtionalHeaders
	client.HostModel = config.HostModel
	client.IsEnableMD5 = config.IsEnableMD5
	client.IsEnableCrc = config.IsEnableCrc
	return nil
}

func (client *Client) PutBucketLifecycle(request *PutBucketLifecycleRequest, runtime *ossutil.RuntimeOptions) (_result *PutBucketLifecycleResponse, _err error) {
	_err = tea.Validate(request)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Validate(runtime)
	if _err != nil {
		return _result, _err
	}
	_runtime := map[string]interface{}{
		"timeouted":      "retry",
		"readTimeout":    tea.IntValue(util.DefaultNumber(runtime.ReadTimeout, client.ReadTimeout)),
		"connectTimeout": tea.IntValue(util.DefaultNumber(runtime.ConnectTimeout, client.ConnectTimeout)),
		"localAddr":      tea.StringValue(util.DefaultString(runtime.LocalAddr, client.LocalAddr)),
		"httpProxy":      tea.StringValue(util.DefaultString(runtime.HttpProxy, client.HttpProxy)),
		"httpsProxy":     tea.StringValue(util.DefaultString(runtime.HttpsProxy, client.HttpsProxy)),
		"noProxy":        tea.StringValue(util.DefaultString(runtime.NoProxy, client.NoProxy)),
		"socks5Proxy":    tea.StringValue(util.DefaultString(runtime.Socks5Proxy, client.Socks5Proxy)),
		"socks5NetWork":  tea.StringValue(util.DefaultString(runtime.Socks5NetWork, client.Socks5NetWork)),
		"maxIdleConns":   tea.IntValue(util.DefaultNumber(runtime.MaxIdleConns, client.MaxIdleConns)),
		"retry": map[string]interface{}{
			"retryable":   tea.BoolValue(runtime.Autoretry),
			"maxAttempts": tea.IntValue(util.DefaultNumber(runtime.MaxAttempts, tea.Int(3))),
		},
		"backoff": map[string]interface{}{
			"policy": tea.StringValue(util.DefaultString(runtime.BackoffPolicy, tea.String("no"))),
			"period": tea.IntValue(util.DefaultNumber(runtime.BackoffPeriod, tea.Int(1))),
		},
		"ignoreSSL": tea.BoolValue(runtime.IgnoreSSL),
	}

	_resp := &PutBucketLifecycleResponse{}
	for _retryTimes := 0; tea.BoolValue(tea.AllowRetry(_runtime["retry"], tea.Int(_retryTimes))); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], tea.Int(_retryTimes))
			if tea.IntValue(_backoffTime) > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, _err = func() (*PutBucketLifecycleResponse, error) {
			request_ := tea.NewRequest()
			accessKeyId, _err := client.Credential.GetAccessKeyId()
			if _err != nil {
				return _result, _err
			}

			accessKeySecret, _err := client.Credential.GetAccessKeySecret()
			if _err != nil {
				return _result, _err
			}

			token, _err := client.Credential.GetSecurityToken()
			if _err != nil {
				return _result, _err
			}

			reqBody := xml.ToXML(tea.ToMap(request.Body))
			request_.Protocol = client.Protocol
			request_.Method = tea.String("PUT")
			request_.Pathname = tea.String("/?lifecycle")
			request_.Headers = map[string]*string{
				"host":       ossutil.GetHost(request.BucketName, client.RegionId, client.Endpoint, client.HostModel),
				"date":       util.GetDateUTCString(),
				"user-agent": client.GetUserAgent(),
			}
			if !tea.BoolValue(util.Empty(token)) {
				request_.Headers["x-oss-security-token"] = token
			}

			request_.Body = tea.ToReader(reqBody)
			request_.Headers["authorization"] = ossutil.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, client.SignatureVersion, client.AddtionalHeaders)
			response_, _err := tea.DoRequest(request_, _runtime)
			if _err != nil {
				return _result, _err
			}
			var respMap map[string]interface{}
			var bodyStr *string
			if tea.BoolValue(util.Is4xx(response_.StatusCode)) || tea.BoolValue(util.Is5xx(response_.StatusCode)) {
				bodyStr, _err = util.ReadAsString(response_.Body)
				if _err != nil {
					return _result, _err
				}

				respMap = ossutil.GetErrMessage(bodyStr)
				_err = tea.NewSDKError(map[string]interface{}{
					"code":    respMap["Code"],
					"message": respMap["Message"],
					"data": map[string]interface{}{
						"httpCode":  tea.IntValue(response_.StatusCode),
						"requestId": respMap["RequestId"],
						"hostId":    respMap["HostId"],
					},
				})
				return _result, _err
			}

			_result = &PutBucketLifecycleResponse{}
			_err = tea.Convert(response_.Headers, &_result)
			return _result, _err
		}()
		if !tea.BoolValue(tea.Retryable(_err)) {
			break
		}
	}

	return _resp, _err
}

func (client *Client) DeleteMultipleObjects(request *DeleteMultipleObjectsRequest, runtime *ossutil.RuntimeOptions) (_result *DeleteMultipleObjectsResponse, _err error) {
	_err = tea.Validate(request)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Validate(runtime)
	if _err != nil {
		return _result, _err
	}
	_runtime := map[string]interface{}{
		"timeouted":      "retry",
		"readTimeout":    tea.IntValue(util.DefaultNumber(runtime.ReadTimeout, client.ReadTimeout)),
		"connectTimeout": tea.IntValue(util.DefaultNumber(runtime.ConnectTimeout, client.ConnectTimeout)),
		"localAddr":      tea.StringValue(util.DefaultString(runtime.LocalAddr, client.LocalAddr)),
		"httpProxy":      tea.StringValue(util.DefaultString(runtime.HttpProxy, client.HttpProxy)),
		"httpsProxy":     tea.StringValue(util.DefaultString(runtime.HttpsProxy, client.HttpsProxy)),
		"noProxy":        tea.StringValue(util.DefaultString(runtime.NoProxy, client.NoProxy)),
		"socks5Proxy":    tea.StringValue(util.DefaultString(runtime.Socks5Proxy, client.Socks5Proxy)),
		"socks5NetWork":  tea.StringValue(util.DefaultString(runtime.Socks5NetWork, client.Socks5NetWork)),
		"maxIdleConns":   tea.IntValue(util.DefaultNumber(runtime.MaxIdleConns, client.MaxIdleConns)),
		"retry": map[string]interface{}{
			"retryable":   tea.BoolValue(runtime.Autoretry),
			"maxAttempts": tea.IntValue(util.DefaultNumber(runtime.MaxAttempts, tea.Int(3))),
		},
		"backoff": map[string]interface{}{
			"policy": tea.StringValue(util.DefaultString(runtime.BackoffPolicy, tea.String("no"))),
			"period": tea.IntValue(util.DefaultNumber(runtime.BackoffPeriod, tea.Int(1))),
		},
		"ignoreSSL": tea.BoolValue(runtime.IgnoreSSL),
	}

	_resp := &DeleteMultipleObjectsResponse{}
	for _retryTimes := 0; tea.BoolValue(tea.AllowRetry(_runtime["retry"], tea.Int(_retryTimes))); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], tea.Int(_retryTimes))
			if tea.IntValue(_backoffTime) > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, _err = func() (*DeleteMultipleObjectsResponse, error) {
			request_ := tea.NewRequest()
			accessKeyId, _err := client.Credential.GetAccessKeyId()
			if _err != nil {
				return _result, _err
			}

			accessKeySecret, _err := client.Credential.GetAccessKeySecret()
			if _err != nil {
				return _result, _err
			}

			token, _err := client.Credential.GetSecurityToken()
			if _err != nil {
				return _result, _err
			}

			reqBody := xml.ToXML(tea.ToMap(request.Body))
			request_.Protocol = client.Protocol
			request_.Method = tea.String("POST")
			request_.Pathname = tea.String("/?delete")
			request_.Headers = tea.Merge(map[string]*string{
				"host":       ossutil.GetHost(request.BucketName, client.RegionId, client.Endpoint, client.HostModel),
				"date":       util.GetDateUTCString(),
				"user-agent": client.GetUserAgent(),
			}, util.StringifyMapValue(tea.ToMap(request.Header)))
			if !tea.BoolValue(util.Empty(token)) {
				request_.Headers["x-oss-security-token"] = token
			}

			request_.Body = tea.ToReader(reqBody)
			if !tea.BoolValue(util.IsUnset(tea.ToMap(request.Header))) && !tea.BoolValue(util.Empty(request.Header.ContentMD5)) {
				request_.Headers["content-md5"] = request.Header.ContentMD5
			} else {
				request_.Headers["content-md5"] = ossutil.GetContentMD5(reqBody, client.IsEnableMD5)
			}

			request_.Headers["authorization"] = ossutil.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, client.SignatureVersion, client.AddtionalHeaders)
			response_, _err := tea.DoRequest(request_, _runtime)
			if _err != nil {
				return _result, _err
			}
			var respMap map[string]interface{}
			var bodyStr *string
			if tea.BoolValue(util.Is4xx(response_.StatusCode)) || tea.BoolValue(util.Is5xx(response_.StatusCode)) {
				bodyStr, _err = util.ReadAsString(response_.Body)
				if _err != nil {
					return _result, _err
				}

				respMap = ossutil.GetErrMessage(bodyStr)
				_err = tea.NewSDKError(map[string]interface{}{
					"code":    respMap["Code"],
					"message": respMap["Message"],
					"data": map[string]interface{}{
						"httpCode":  tea.IntValue(response_.StatusCode),
						"requestId": respMap["RequestId"],
						"hostId":    respMap["HostId"],
					},
				})
				return _result, _err
			}

			bodyStr, _err = util.ReadAsString(response_.Body)
			if _err != nil {
				return _result, _err
			}

			respMap = xml.ParseXml(bodyStr, new(DeleteMultipleObjectsResponse))
			_result = &DeleteMultipleObjectsResponse{}
			_err = tea.Convert(tea.ToMap(map[string]interface{}{
				"DeleteResult": respMap["DeleteResult"],
			}, response_.Headers), &_result)
			return _result, _err
		}()
		if !tea.BoolValue(tea.Retryable(_err)) {
			break
		}
	}

	return _resp, _err
}

func (client *Client) PutBucketReferer(request *PutBucketRefererRequest, runtime *ossutil.RuntimeOptions) (_result *PutBucketRefererResponse, _err error) {
	_err = tea.Validate(request)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Validate(runtime)
	if _err != nil {
		return _result, _err
	}
	_runtime := map[string]interface{}{
		"timeouted":      "retry",
		"readTimeout":    tea.IntValue(util.DefaultNumber(runtime.ReadTimeout, client.ReadTimeout)),
		"connectTimeout": tea.IntValue(util.DefaultNumber(runtime.ConnectTimeout, client.ConnectTimeout)),
		"localAddr":      tea.StringValue(util.DefaultString(runtime.LocalAddr, client.LocalAddr)),
		"httpProxy":      tea.StringValue(util.DefaultString(runtime.HttpProxy, client.HttpProxy)),
		"httpsProxy":     tea.StringValue(util.DefaultString(runtime.HttpsProxy, client.HttpsProxy)),
		"noProxy":        tea.StringValue(util.DefaultString(runtime.NoProxy, client.NoProxy)),
		"socks5Proxy":    tea.StringValue(util.DefaultString(runtime.Socks5Proxy, client.Socks5Proxy)),
		"socks5NetWork":  tea.StringValue(util.DefaultString(runtime.Socks5NetWork, client.Socks5NetWork)),
		"maxIdleConns":   tea.IntValue(util.DefaultNumber(runtime.MaxIdleConns, client.MaxIdleConns)),
		"retry": map[string]interface{}{
			"retryable":   tea.BoolValue(runtime.Autoretry),
			"maxAttempts": tea.IntValue(util.DefaultNumber(runtime.MaxAttempts, tea.Int(3))),
		},
		"backoff": map[string]interface{}{
			"policy": tea.StringValue(util.DefaultString(runtime.BackoffPolicy, tea.String("no"))),
			"period": tea.IntValue(util.DefaultNumber(runtime.BackoffPeriod, tea.Int(1))),
		},
		"ignoreSSL": tea.BoolValue(runtime.IgnoreSSL),
	}

	_resp := &PutBucketRefererResponse{}
	for _retryTimes := 0; tea.BoolValue(tea.AllowRetry(_runtime["retry"], tea.Int(_retryTimes))); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], tea.Int(_retryTimes))
			if tea.IntValue(_backoffTime) > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, _err = func() (*PutBucketRefererResponse, error) {
			request_ := tea.NewRequest()
			accessKeyId, _err := client.Credential.GetAccessKeyId()
			if _err != nil {
				return _result, _err
			}

			accessKeySecret, _err := client.Credential.GetAccessKeySecret()
			if _err != nil {
				return _result, _err
			}

			token, _err := client.Credential.GetSecurityToken()
			if _err != nil {
				return _result, _err
			}

			reqBody := xml.ToXML(tea.ToMap(request.Body))
			request_.Protocol = client.Protocol
			request_.Method = tea.String("PUT")
			request_.Pathname = tea.String("/?referer")
			request_.Headers = map[string]*string{
				"host":       ossutil.GetHost(request.BucketName, client.RegionId, client.Endpoint, client.HostModel),
				"date":       util.GetDateUTCString(),
				"user-agent": client.GetUserAgent(),
			}
			if !tea.BoolValue(util.Empty(token)) {
				request_.Headers["x-oss-security-token"] = token
			}

			request_.Body = tea.ToReader(reqBody)
			request_.Headers["authorization"] = ossutil.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, client.SignatureVersion, client.AddtionalHeaders)
			response_, _err := tea.DoRequest(request_, _runtime)
			if _err != nil {
				return _result, _err
			}
			var respMap map[string]interface{}
			var bodyStr *string
			if tea.BoolValue(util.Is4xx(response_.StatusCode)) || tea.BoolValue(util.Is5xx(response_.StatusCode)) {
				bodyStr, _err = util.ReadAsString(response_.Body)
				if _err != nil {
					return _result, _err
				}

				respMap = ossutil.GetErrMessage(bodyStr)
				_err = tea.NewSDKError(map[string]interface{}{
					"code":    respMap["Code"],
					"message": respMap["Message"],
					"data": map[string]interface{}{
						"httpCode":  tea.IntValue(response_.StatusCode),
						"requestId": respMap["RequestId"],
						"hostId":    respMap["HostId"],
					},
				})
				return _result, _err
			}

			_result = &PutBucketRefererResponse{}
			_err = tea.Convert(response_.Headers, &_result)
			return _result, _err
		}()
		if !tea.BoolValue(tea.Retryable(_err)) {
			break
		}
	}

	return _resp, _err
}

func (client *Client) PutBucketWebsite(request *PutBucketWebsiteRequest, runtime *ossutil.RuntimeOptions) (_result *PutBucketWebsiteResponse, _err error) {
	_err = tea.Validate(request)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Validate(runtime)
	if _err != nil {
		return _result, _err
	}
	_runtime := map[string]interface{}{
		"timeouted":      "retry",
		"readTimeout":    tea.IntValue(util.DefaultNumber(runtime.ReadTimeout, client.ReadTimeout)),
		"connectTimeout": tea.IntValue(util.DefaultNumber(runtime.ConnectTimeout, client.ConnectTimeout)),
		"localAddr":      tea.StringValue(util.DefaultString(runtime.LocalAddr, client.LocalAddr)),
		"httpProxy":      tea.StringValue(util.DefaultString(runtime.HttpProxy, client.HttpProxy)),
		"httpsProxy":     tea.StringValue(util.DefaultString(runtime.HttpsProxy, client.HttpsProxy)),
		"noProxy":        tea.StringValue(util.DefaultString(runtime.NoProxy, client.NoProxy)),
		"socks5Proxy":    tea.StringValue(util.DefaultString(runtime.Socks5Proxy, client.Socks5Proxy)),
		"socks5NetWork":  tea.StringValue(util.DefaultString(runtime.Socks5NetWork, client.Socks5NetWork)),
		"maxIdleConns":   tea.IntValue(util.DefaultNumber(runtime.MaxIdleConns, client.MaxIdleConns)),
		"retry": map[string]interface{}{
			"retryable":   tea.BoolValue(runtime.Autoretry),
			"maxAttempts": tea.IntValue(util.DefaultNumber(runtime.MaxAttempts, tea.Int(3))),
		},
		"backoff": map[string]interface{}{
			"policy": tea.StringValue(util.DefaultString(runtime.BackoffPolicy, tea.String("no"))),
			"period": tea.IntValue(util.DefaultNumber(runtime.BackoffPeriod, tea.Int(1))),
		},
		"ignoreSSL": tea.BoolValue(runtime.IgnoreSSL),
	}

	_resp := &PutBucketWebsiteResponse{}
	for _retryTimes := 0; tea.BoolValue(tea.AllowRetry(_runtime["retry"], tea.Int(_retryTimes))); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], tea.Int(_retryTimes))
			if tea.IntValue(_backoffTime) > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, _err = func() (*PutBucketWebsiteResponse, error) {
			request_ := tea.NewRequest()
			accessKeyId, _err := client.Credential.GetAccessKeyId()
			if _err != nil {
				return _result, _err
			}

			accessKeySecret, _err := client.Credential.GetAccessKeySecret()
			if _err != nil {
				return _result, _err
			}

			token, _err := client.Credential.GetSecurityToken()
			if _err != nil {
				return _result, _err
			}

			reqBody := xml.ToXML(tea.ToMap(request.Body))
			request_.Protocol = client.Protocol
			request_.Method = tea.String("PUT")
			request_.Pathname = tea.String("/?website")
			request_.Headers = map[string]*string{
				"host":       ossutil.GetHost(request.BucketName, client.RegionId, client.Endpoint, client.HostModel),
				"date":       util.GetDateUTCString(),
				"user-agent": client.GetUserAgent(),
			}
			if !tea.BoolValue(util.Empty(token)) {
				request_.Headers["x-oss-security-token"] = token
			}

			request_.Body = tea.ToReader(reqBody)
			request_.Headers["authorization"] = ossutil.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, client.SignatureVersion, client.AddtionalHeaders)
			response_, _err := tea.DoRequest(request_, _runtime)
			if _err != nil {
				return _result, _err
			}
			var respMap map[string]interface{}
			var bodyStr *string
			if tea.BoolValue(util.Is4xx(response_.StatusCode)) || tea.BoolValue(util.Is5xx(response_.StatusCode)) {
				bodyStr, _err = util.ReadAsString(response_.Body)
				if _err != nil {
					return _result, _err
				}

				respMap = ossutil.GetErrMessage(bodyStr)
				_err = tea.NewSDKError(map[string]interface{}{
					"code":    respMap["Code"],
					"message": respMap["Message"],
					"data": map[string]interface{}{
						"httpCode":  tea.IntValue(response_.StatusCode),
						"requestId": respMap["RequestId"],
						"hostId":    respMap["HostId"],
					},
				})
				return _result, _err
			}

			_result = &PutBucketWebsiteResponse{}
			_err = tea.Convert(response_.Headers, &_result)
			return _result, _err
		}()
		if !tea.BoolValue(tea.Retryable(_err)) {
			break
		}
	}

	return _resp, _err
}

func (client *Client) CompleteMultipartUpload(request *CompleteMultipartUploadRequest, runtime *ossutil.RuntimeOptions) (_result *CompleteMultipartUploadResponse, _err error) {
	_err = tea.Validate(request)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Validate(runtime)
	if _err != nil {
		return _result, _err
	}
	_runtime := map[string]interface{}{
		"timeouted":      "retry",
		"readTimeout":    tea.IntValue(util.DefaultNumber(runtime.ReadTimeout, client.ReadTimeout)),
		"connectTimeout": tea.IntValue(util.DefaultNumber(runtime.ConnectTimeout, client.ConnectTimeout)),
		"localAddr":      tea.StringValue(util.DefaultString(runtime.LocalAddr, client.LocalAddr)),
		"httpProxy":      tea.StringValue(util.DefaultString(runtime.HttpProxy, client.HttpProxy)),
		"httpsProxy":     tea.StringValue(util.DefaultString(runtime.HttpsProxy, client.HttpsProxy)),
		"noProxy":        tea.StringValue(util.DefaultString(runtime.NoProxy, client.NoProxy)),
		"socks5Proxy":    tea.StringValue(util.DefaultString(runtime.Socks5Proxy, client.Socks5Proxy)),
		"socks5NetWork":  tea.StringValue(util.DefaultString(runtime.Socks5NetWork, client.Socks5NetWork)),
		"maxIdleConns":   tea.IntValue(util.DefaultNumber(runtime.MaxIdleConns, client.MaxIdleConns)),
		"retry": map[string]interface{}{
			"retryable":   tea.BoolValue(runtime.Autoretry),
			"maxAttempts": tea.IntValue(util.DefaultNumber(runtime.MaxAttempts, tea.Int(3))),
		},
		"backoff": map[string]interface{}{
			"policy": tea.StringValue(util.DefaultString(runtime.BackoffPolicy, tea.String("no"))),
			"period": tea.IntValue(util.DefaultNumber(runtime.BackoffPeriod, tea.Int(1))),
		},
		"ignoreSSL": tea.BoolValue(runtime.IgnoreSSL),
	}

	_resp := &CompleteMultipartUploadResponse{}
	for _retryTimes := 0; tea.BoolValue(tea.AllowRetry(_runtime["retry"], tea.Int(_retryTimes))); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], tea.Int(_retryTimes))
			if tea.IntValue(_backoffTime) > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, _err = func() (*CompleteMultipartUploadResponse, error) {
			request_ := tea.NewRequest()
			accessKeyId, _err := client.Credential.GetAccessKeyId()
			if _err != nil {
				return _result, _err
			}

			accessKeySecret, _err := client.Credential.GetAccessKeySecret()
			if _err != nil {
				return _result, _err
			}

			token, _err := client.Credential.GetSecurityToken()
			if _err != nil {
				return _result, _err
			}

			reqBody := xml.ToXML(tea.ToMap(request.Body))
			request_.Protocol = client.Protocol
			request_.Method = tea.String("POST")
			request_.Pathname = tea.String("/" + tea.StringValue(request.ObjectName))
			request_.Headers = map[string]*string{
				"host":       ossutil.GetHost(request.BucketName, client.RegionId, client.Endpoint, client.HostModel),
				"date":       util.GetDateUTCString(),
				"user-agent": client.GetUserAgent(),
			}
			if !tea.BoolValue(util.Empty(token)) {
				request_.Headers["x-oss-security-token"] = token
			}

			request_.Query = util.StringifyMapValue(tea.ToMap(request.Filter))
			request_.Body = tea.ToReader(reqBody)
			request_.Headers["authorization"] = ossutil.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, client.SignatureVersion, client.AddtionalHeaders)
			response_, _err := tea.DoRequest(request_, _runtime)
			if _err != nil {
				return _result, _err
			}
			var respMap map[string]interface{}
			var bodyStr *string
			if tea.BoolValue(util.Is4xx(response_.StatusCode)) || tea.BoolValue(util.Is5xx(response_.StatusCode)) {
				bodyStr, _err = util.ReadAsString(response_.Body)
				if _err != nil {
					return _result, _err
				}

				respMap = ossutil.GetErrMessage(bodyStr)
				_err = tea.NewSDKError(map[string]interface{}{
					"code":    respMap["Code"],
					"message": respMap["Message"],
					"data": map[string]interface{}{
						"httpCode":  tea.IntValue(response_.StatusCode),
						"requestId": respMap["RequestId"],
						"hostId":    respMap["HostId"],
					},
				})
				return _result, _err
			}

			bodyStr, _err = util.ReadAsString(response_.Body)
			if _err != nil {
				return _result, _err
			}

			respMap = xml.ParseXml(bodyStr, new(CompleteMultipartUploadResponse))
			_result = &CompleteMultipartUploadResponse{}
			_err = tea.Convert(tea.ToMap(map[string]interface{}{
				"CompleteMultipartUploadResult": respMap["CompleteMultipartUploadResult"],
			}, response_.Headers), &_result)
			return _result, _err
		}()
		if !tea.BoolValue(tea.Retryable(_err)) {
			break
		}
	}

	return _resp, _err
}

func (client *Client) PutBucketLogging(request *PutBucketLoggingRequest, runtime *ossutil.RuntimeOptions) (_result *PutBucketLoggingResponse, _err error) {
	_err = tea.Validate(request)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Validate(runtime)
	if _err != nil {
		return _result, _err
	}
	_runtime := map[string]interface{}{
		"timeouted":      "retry",
		"readTimeout":    tea.IntValue(util.DefaultNumber(runtime.ReadTimeout, client.ReadTimeout)),
		"connectTimeout": tea.IntValue(util.DefaultNumber(runtime.ConnectTimeout, client.ConnectTimeout)),
		"localAddr":      tea.StringValue(util.DefaultString(runtime.LocalAddr, client.LocalAddr)),
		"httpProxy":      tea.StringValue(util.DefaultString(runtime.HttpProxy, client.HttpProxy)),
		"httpsProxy":     tea.StringValue(util.DefaultString(runtime.HttpsProxy, client.HttpsProxy)),
		"noProxy":        tea.StringValue(util.DefaultString(runtime.NoProxy, client.NoProxy)),
		"socks5Proxy":    tea.StringValue(util.DefaultString(runtime.Socks5Proxy, client.Socks5Proxy)),
		"socks5NetWork":  tea.StringValue(util.DefaultString(runtime.Socks5NetWork, client.Socks5NetWork)),
		"maxIdleConns":   tea.IntValue(util.DefaultNumber(runtime.MaxIdleConns, client.MaxIdleConns)),
		"retry": map[string]interface{}{
			"retryable":   tea.BoolValue(runtime.Autoretry),
			"maxAttempts": tea.IntValue(util.DefaultNumber(runtime.MaxAttempts, tea.Int(3))),
		},
		"backoff": map[string]interface{}{
			"policy": tea.StringValue(util.DefaultString(runtime.BackoffPolicy, tea.String("no"))),
			"period": tea.IntValue(util.DefaultNumber(runtime.BackoffPeriod, tea.Int(1))),
		},
		"ignoreSSL": tea.BoolValue(runtime.IgnoreSSL),
	}

	_resp := &PutBucketLoggingResponse{}
	for _retryTimes := 0; tea.BoolValue(tea.AllowRetry(_runtime["retry"], tea.Int(_retryTimes))); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], tea.Int(_retryTimes))
			if tea.IntValue(_backoffTime) > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, _err = func() (*PutBucketLoggingResponse, error) {
			request_ := tea.NewRequest()
			accessKeyId, _err := client.Credential.GetAccessKeyId()
			if _err != nil {
				return _result, _err
			}

			accessKeySecret, _err := client.Credential.GetAccessKeySecret()
			if _err != nil {
				return _result, _err
			}

			token, _err := client.Credential.GetSecurityToken()
			if _err != nil {
				return _result, _err
			}

			reqBody := xml.ToXML(tea.ToMap(request.Body))
			request_.Protocol = client.Protocol
			request_.Method = tea.String("PUT")
			request_.Pathname = tea.String("/?logging")
			request_.Headers = map[string]*string{
				"host":       ossutil.GetHost(request.BucketName, client.RegionId, client.Endpoint, client.HostModel),
				"date":       util.GetDateUTCString(),
				"user-agent": client.GetUserAgent(),
			}
			if !tea.BoolValue(util.Empty(token)) {
				request_.Headers["x-oss-security-token"] = token
			}

			request_.Body = tea.ToReader(reqBody)
			request_.Headers["authorization"] = ossutil.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, client.SignatureVersion, client.AddtionalHeaders)
			response_, _err := tea.DoRequest(request_, _runtime)
			if _err != nil {
				return _result, _err
			}
			var respMap map[string]interface{}
			var bodyStr *string
			if tea.BoolValue(util.Is4xx(response_.StatusCode)) || tea.BoolValue(util.Is5xx(response_.StatusCode)) {
				bodyStr, _err = util.ReadAsString(response_.Body)
				if _err != nil {
					return _result, _err
				}

				respMap = ossutil.GetErrMessage(bodyStr)
				_err = tea.NewSDKError(map[string]interface{}{
					"code":    respMap["Code"],
					"message": respMap["Message"],
					"data": map[string]interface{}{
						"httpCode":  tea.IntValue(response_.StatusCode),
						"requestId": respMap["RequestId"],
						"hostId":    respMap["HostId"],
					},
				})
				return _result, _err
			}

			_result = &PutBucketLoggingResponse{}
			_err = tea.Convert(response_.Headers, &_result)
			return _result, _err
		}()
		if !tea.BoolValue(tea.Retryable(_err)) {
			break
		}
	}

	return _resp, _err
}

func (client *Client) PutBucketRequestPayment(request *PutBucketRequestPaymentRequest, runtime *ossutil.RuntimeOptions) (_result *PutBucketRequestPaymentResponse, _err error) {
	_err = tea.Validate(request)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Validate(runtime)
	if _err != nil {
		return _result, _err
	}
	_runtime := map[string]interface{}{
		"timeouted":      "retry",
		"readTimeout":    tea.IntValue(util.DefaultNumber(runtime.ReadTimeout, client.ReadTimeout)),
		"connectTimeout": tea.IntValue(util.DefaultNumber(runtime.ConnectTimeout, client.ConnectTimeout)),
		"localAddr":      tea.StringValue(util.DefaultString(runtime.LocalAddr, client.LocalAddr)),
		"httpProxy":      tea.StringValue(util.DefaultString(runtime.HttpProxy, client.HttpProxy)),
		"httpsProxy":     tea.StringValue(util.DefaultString(runtime.HttpsProxy, client.HttpsProxy)),
		"noProxy":        tea.StringValue(util.DefaultString(runtime.NoProxy, client.NoProxy)),
		"socks5Proxy":    tea.StringValue(util.DefaultString(runtime.Socks5Proxy, client.Socks5Proxy)),
		"socks5NetWork":  tea.StringValue(util.DefaultString(runtime.Socks5NetWork, client.Socks5NetWork)),
		"maxIdleConns":   tea.IntValue(util.DefaultNumber(runtime.MaxIdleConns, client.MaxIdleConns)),
		"retry": map[string]interface{}{
			"retryable":   tea.BoolValue(runtime.Autoretry),
			"maxAttempts": tea.IntValue(util.DefaultNumber(runtime.MaxAttempts, tea.Int(3))),
		},
		"backoff": map[string]interface{}{
			"policy": tea.StringValue(util.DefaultString(runtime.BackoffPolicy, tea.String("no"))),
			"period": tea.IntValue(util.DefaultNumber(runtime.BackoffPeriod, tea.Int(1))),
		},
		"ignoreSSL": tea.BoolValue(runtime.IgnoreSSL),
	}

	_resp := &PutBucketRequestPaymentResponse{}
	for _retryTimes := 0; tea.BoolValue(tea.AllowRetry(_runtime["retry"], tea.Int(_retryTimes))); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], tea.Int(_retryTimes))
			if tea.IntValue(_backoffTime) > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, _err = func() (*PutBucketRequestPaymentResponse, error) {
			request_ := tea.NewRequest()
			accessKeyId, _err := client.Credential.GetAccessKeyId()
			if _err != nil {
				return _result, _err
			}

			accessKeySecret, _err := client.Credential.GetAccessKeySecret()
			if _err != nil {
				return _result, _err
			}

			token, _err := client.Credential.GetSecurityToken()
			if _err != nil {
				return _result, _err
			}

			reqBody := xml.ToXML(tea.ToMap(request.Body))
			request_.Protocol = client.Protocol
			request_.Method = tea.String("PUT")
			request_.Pathname = tea.String("/?requestPayment")
			request_.Headers = map[string]*string{
				"host":       ossutil.GetHost(request.BucketName, client.RegionId, client.Endpoint, client.HostModel),
				"date":       util.GetDateUTCString(),
				"user-agent": client.GetUserAgent(),
			}
			if !tea.BoolValue(util.Empty(token)) {
				request_.Headers["x-oss-security-token"] = token
			}

			request_.Body = tea.ToReader(reqBody)
			request_.Headers["authorization"] = ossutil.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, client.SignatureVersion, client.AddtionalHeaders)
			response_, _err := tea.DoRequest(request_, _runtime)
			if _err != nil {
				return _result, _err
			}
			var respMap map[string]interface{}
			var bodyStr *string
			if tea.BoolValue(util.Is4xx(response_.StatusCode)) || tea.BoolValue(util.Is5xx(response_.StatusCode)) {
				bodyStr, _err = util.ReadAsString(response_.Body)
				if _err != nil {
					return _result, _err
				}

				respMap = ossutil.GetErrMessage(bodyStr)
				_err = tea.NewSDKError(map[string]interface{}{
					"code":    respMap["Code"],
					"message": respMap["Message"],
					"data": map[string]interface{}{
						"httpCode":  tea.IntValue(response_.StatusCode),
						"requestId": respMap["RequestId"],
						"hostId":    respMap["HostId"],
					},
				})
				return _result, _err
			}

			_result = &PutBucketRequestPaymentResponse{}
			_err = tea.Convert(response_.Headers, &_result)
			return _result, _err
		}()
		if !tea.BoolValue(tea.Retryable(_err)) {
			break
		}
	}

	return _resp, _err
}

func (client *Client) PutBucketEncryption(request *PutBucketEncryptionRequest, runtime *ossutil.RuntimeOptions) (_result *PutBucketEncryptionResponse, _err error) {
	_err = tea.Validate(request)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Validate(runtime)
	if _err != nil {
		return _result, _err
	}
	_runtime := map[string]interface{}{
		"timeouted":      "retry",
		"readTimeout":    tea.IntValue(util.DefaultNumber(runtime.ReadTimeout, client.ReadTimeout)),
		"connectTimeout": tea.IntValue(util.DefaultNumber(runtime.ConnectTimeout, client.ConnectTimeout)),
		"localAddr":      tea.StringValue(util.DefaultString(runtime.LocalAddr, client.LocalAddr)),
		"httpProxy":      tea.StringValue(util.DefaultString(runtime.HttpProxy, client.HttpProxy)),
		"httpsProxy":     tea.StringValue(util.DefaultString(runtime.HttpsProxy, client.HttpsProxy)),
		"noProxy":        tea.StringValue(util.DefaultString(runtime.NoProxy, client.NoProxy)),
		"socks5Proxy":    tea.StringValue(util.DefaultString(runtime.Socks5Proxy, client.Socks5Proxy)),
		"socks5NetWork":  tea.StringValue(util.DefaultString(runtime.Socks5NetWork, client.Socks5NetWork)),
		"maxIdleConns":   tea.IntValue(util.DefaultNumber(runtime.MaxIdleConns, client.MaxIdleConns)),
		"retry": map[string]interface{}{
			"retryable":   tea.BoolValue(runtime.Autoretry),
			"maxAttempts": tea.IntValue(util.DefaultNumber(runtime.MaxAttempts, tea.Int(3))),
		},
		"backoff": map[string]interface{}{
			"policy": tea.StringValue(util.DefaultString(runtime.BackoffPolicy, tea.String("no"))),
			"period": tea.IntValue(util.DefaultNumber(runtime.BackoffPeriod, tea.Int(1))),
		},
		"ignoreSSL": tea.BoolValue(runtime.IgnoreSSL),
	}

	_resp := &PutBucketEncryptionResponse{}
	for _retryTimes := 0; tea.BoolValue(tea.AllowRetry(_runtime["retry"], tea.Int(_retryTimes))); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], tea.Int(_retryTimes))
			if tea.IntValue(_backoffTime) > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, _err = func() (*PutBucketEncryptionResponse, error) {
			request_ := tea.NewRequest()
			accessKeyId, _err := client.Credential.GetAccessKeyId()
			if _err != nil {
				return _result, _err
			}

			accessKeySecret, _err := client.Credential.GetAccessKeySecret()
			if _err != nil {
				return _result, _err
			}

			token, _err := client.Credential.GetSecurityToken()
			if _err != nil {
				return _result, _err
			}

			reqBody := xml.ToXML(tea.ToMap(request.Body))
			request_.Protocol = client.Protocol
			request_.Method = tea.String("PUT")
			request_.Pathname = tea.String("/?encryption")
			request_.Headers = map[string]*string{
				"host":       ossutil.GetHost(request.BucketName, client.RegionId, client.Endpoint, client.HostModel),
				"date":       util.GetDateUTCString(),
				"user-agent": client.GetUserAgent(),
			}
			if !tea.BoolValue(util.Empty(token)) {
				request_.Headers["x-oss-security-token"] = token
			}

			request_.Body = tea.ToReader(reqBody)
			request_.Headers["authorization"] = ossutil.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, client.SignatureVersion, client.AddtionalHeaders)
			response_, _err := tea.DoRequest(request_, _runtime)
			if _err != nil {
				return _result, _err
			}
			var respMap map[string]interface{}
			var bodyStr *string
			if tea.BoolValue(util.Is4xx(response_.StatusCode)) || tea.BoolValue(util.Is5xx(response_.StatusCode)) {
				bodyStr, _err = util.ReadAsString(response_.Body)
				if _err != nil {
					return _result, _err
				}

				respMap = ossutil.GetErrMessage(bodyStr)
				_err = tea.NewSDKError(map[string]interface{}{
					"code":    respMap["Code"],
					"message": respMap["Message"],
					"data": map[string]interface{}{
						"httpCode":  tea.IntValue(response_.StatusCode),
						"requestId": respMap["RequestId"],
						"hostId":    respMap["HostId"],
					},
				})
				return _result, _err
			}

			_result = &PutBucketEncryptionResponse{}
			_err = tea.Convert(response_.Headers, &_result)
			return _result, _err
		}()
		if !tea.BoolValue(tea.Retryable(_err)) {
			break
		}
	}

	return _resp, _err
}

func (client *Client) PutLiveChannel(request *PutLiveChannelRequest, runtime *ossutil.RuntimeOptions) (_result *PutLiveChannelResponse, _err error) {
	_err = tea.Validate(request)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Validate(runtime)
	if _err != nil {
		return _result, _err
	}
	_runtime := map[string]interface{}{
		"timeouted":      "retry",
		"readTimeout":    tea.IntValue(util.DefaultNumber(runtime.ReadTimeout, client.ReadTimeout)),
		"connectTimeout": tea.IntValue(util.DefaultNumber(runtime.ConnectTimeout, client.ConnectTimeout)),
		"localAddr":      tea.StringValue(util.DefaultString(runtime.LocalAddr, client.LocalAddr)),
		"httpProxy":      tea.StringValue(util.DefaultString(runtime.HttpProxy, client.HttpProxy)),
		"httpsProxy":     tea.StringValue(util.DefaultString(runtime.HttpsProxy, client.HttpsProxy)),
		"noProxy":        tea.StringValue(util.DefaultString(runtime.NoProxy, client.NoProxy)),
		"socks5Proxy":    tea.StringValue(util.DefaultString(runtime.Socks5Proxy, client.Socks5Proxy)),
		"socks5NetWork":  tea.StringValue(util.DefaultString(runtime.Socks5NetWork, client.Socks5NetWork)),
		"maxIdleConns":   tea.IntValue(util.DefaultNumber(runtime.MaxIdleConns, client.MaxIdleConns)),
		"retry": map[string]interface{}{
			"retryable":   tea.BoolValue(runtime.Autoretry),
			"maxAttempts": tea.IntValue(util.DefaultNumber(runtime.MaxAttempts, tea.Int(3))),
		},
		"backoff": map[string]interface{}{
			"policy": tea.StringValue(util.DefaultString(runtime.BackoffPolicy, tea.String("no"))),
			"period": tea.IntValue(util.DefaultNumber(runtime.BackoffPeriod, tea.Int(1))),
		},
		"ignoreSSL": tea.BoolValue(runtime.IgnoreSSL),
	}

	_resp := &PutLiveChannelResponse{}
	for _retryTimes := 0; tea.BoolValue(tea.AllowRetry(_runtime["retry"], tea.Int(_retryTimes))); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], tea.Int(_retryTimes))
			if tea.IntValue(_backoffTime) > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, _err = func() (*PutLiveChannelResponse, error) {
			request_ := tea.NewRequest()
			accessKeyId, _err := client.Credential.GetAccessKeyId()
			if _err != nil {
				return _result, _err
			}

			accessKeySecret, _err := client.Credential.GetAccessKeySecret()
			if _err != nil {
				return _result, _err
			}

			token, _err := client.Credential.GetSecurityToken()
			if _err != nil {
				return _result, _err
			}

			reqBody := xml.ToXML(tea.ToMap(request.Body))
			request_.Protocol = client.Protocol
			request_.Method = tea.String("PUT")
			request_.Pathname = tea.String("/" + tea.StringValue(request.ChannelName) + "?live")
			request_.Headers = map[string]*string{
				"host":       ossutil.GetHost(request.BucketName, client.RegionId, client.Endpoint, client.HostModel),
				"date":       util.GetDateUTCString(),
				"user-agent": client.GetUserAgent(),
			}
			if !tea.BoolValue(util.Empty(token)) {
				request_.Headers["x-oss-security-token"] = token
			}

			request_.Body = tea.ToReader(reqBody)
			request_.Headers["authorization"] = ossutil.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, client.SignatureVersion, client.AddtionalHeaders)
			response_, _err := tea.DoRequest(request_, _runtime)
			if _err != nil {
				return _result, _err
			}
			var respMap map[string]interface{}
			var bodyStr *string
			if tea.BoolValue(util.Is4xx(response_.StatusCode)) || tea.BoolValue(util.Is5xx(response_.StatusCode)) {
				bodyStr, _err = util.ReadAsString(response_.Body)
				if _err != nil {
					return _result, _err
				}

				respMap = ossutil.GetErrMessage(bodyStr)
				_err = tea.NewSDKError(map[string]interface{}{
					"code":    respMap["Code"],
					"message": respMap["Message"],
					"data": map[string]interface{}{
						"httpCode":  tea.IntValue(response_.StatusCode),
						"requestId": respMap["RequestId"],
						"hostId":    respMap["HostId"],
					},
				})
				return _result, _err
			}

			bodyStr, _err = util.ReadAsString(response_.Body)
			if _err != nil {
				return _result, _err
			}

			respMap = xml.ParseXml(bodyStr, new(PutLiveChannelResponse))
			_result = &PutLiveChannelResponse{}
			_err = tea.Convert(tea.ToMap(map[string]interface{}{
				"CreateLiveChannelResult": respMap["CreateLiveChannelResult"],
			}, response_.Headers), &_result)
			return _result, _err
		}()
		if !tea.BoolValue(tea.Retryable(_err)) {
			break
		}
	}

	return _resp, _err
}

func (client *Client) PutBucketTags(request *PutBucketTagsRequest, runtime *ossutil.RuntimeOptions) (_result *PutBucketTagsResponse, _err error) {
	_err = tea.Validate(request)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Validate(runtime)
	if _err != nil {
		return _result, _err
	}
	_runtime := map[string]interface{}{
		"timeouted":      "retry",
		"readTimeout":    tea.IntValue(util.DefaultNumber(runtime.ReadTimeout, client.ReadTimeout)),
		"connectTimeout": tea.IntValue(util.DefaultNumber(runtime.ConnectTimeout, client.ConnectTimeout)),
		"localAddr":      tea.StringValue(util.DefaultString(runtime.LocalAddr, client.LocalAddr)),
		"httpProxy":      tea.StringValue(util.DefaultString(runtime.HttpProxy, client.HttpProxy)),
		"httpsProxy":     tea.StringValue(util.DefaultString(runtime.HttpsProxy, client.HttpsProxy)),
		"noProxy":        tea.StringValue(util.DefaultString(runtime.NoProxy, client.NoProxy)),
		"socks5Proxy":    tea.StringValue(util.DefaultString(runtime.Socks5Proxy, client.Socks5Proxy)),
		"socks5NetWork":  tea.StringValue(util.DefaultString(runtime.Socks5NetWork, client.Socks5NetWork)),
		"maxIdleConns":   tea.IntValue(util.DefaultNumber(runtime.MaxIdleConns, client.MaxIdleConns)),
		"retry": map[string]interface{}{
			"retryable":   tea.BoolValue(runtime.Autoretry),
			"maxAttempts": tea.IntValue(util.DefaultNumber(runtime.MaxAttempts, tea.Int(3))),
		},
		"backoff": map[string]interface{}{
			"policy": tea.StringValue(util.DefaultString(runtime.BackoffPolicy, tea.String("no"))),
			"period": tea.IntValue(util.DefaultNumber(runtime.BackoffPeriod, tea.Int(1))),
		},
		"ignoreSSL": tea.BoolValue(runtime.IgnoreSSL),
	}

	_resp := &PutBucketTagsResponse{}
	for _retryTimes := 0; tea.BoolValue(tea.AllowRetry(_runtime["retry"], tea.Int(_retryTimes))); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], tea.Int(_retryTimes))
			if tea.IntValue(_backoffTime) > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, _err = func() (*PutBucketTagsResponse, error) {
			request_ := tea.NewRequest()
			accessKeyId, _err := client.Credential.GetAccessKeyId()
			if _err != nil {
				return _result, _err
			}

			accessKeySecret, _err := client.Credential.GetAccessKeySecret()
			if _err != nil {
				return _result, _err
			}

			token, _err := client.Credential.GetSecurityToken()
			if _err != nil {
				return _result, _err
			}

			reqBody := xml.ToXML(tea.ToMap(request.Body))
			request_.Protocol = client.Protocol
			request_.Method = tea.String("PUT")
			request_.Pathname = tea.String("/?tagging")
			request_.Headers = map[string]*string{
				"host":       ossutil.GetHost(request.BucketName, client.RegionId, client.Endpoint, client.HostModel),
				"date":       util.GetDateUTCString(),
				"user-agent": client.GetUserAgent(),
			}
			if !tea.BoolValue(util.Empty(token)) {
				request_.Headers["x-oss-security-token"] = token
			}

			request_.Body = tea.ToReader(reqBody)
			request_.Headers["authorization"] = ossutil.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, client.SignatureVersion, client.AddtionalHeaders)
			response_, _err := tea.DoRequest(request_, _runtime)
			if _err != nil {
				return _result, _err
			}
			var respMap map[string]interface{}
			var bodyStr *string
			if tea.BoolValue(util.Is4xx(response_.StatusCode)) || tea.BoolValue(util.Is5xx(response_.StatusCode)) {
				bodyStr, _err = util.ReadAsString(response_.Body)
				if _err != nil {
					return _result, _err
				}

				respMap = ossutil.GetErrMessage(bodyStr)
				_err = tea.NewSDKError(map[string]interface{}{
					"code":    respMap["Code"],
					"message": respMap["Message"],
					"data": map[string]interface{}{
						"httpCode":  tea.IntValue(response_.StatusCode),
						"requestId": respMap["RequestId"],
						"hostId":    respMap["HostId"],
					},
				})
				return _result, _err
			}

			_result = &PutBucketTagsResponse{}
			_err = tea.Convert(response_.Headers, &_result)
			return _result, _err
		}()
		if !tea.BoolValue(tea.Retryable(_err)) {
			break
		}
	}

	return _resp, _err
}

func (client *Client) PutObjectTagging(request *PutObjectTaggingRequest, runtime *ossutil.RuntimeOptions) (_result *PutObjectTaggingResponse, _err error) {
	_err = tea.Validate(request)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Validate(runtime)
	if _err != nil {
		return _result, _err
	}
	_runtime := map[string]interface{}{
		"timeouted":      "retry",
		"readTimeout":    tea.IntValue(util.DefaultNumber(runtime.ReadTimeout, client.ReadTimeout)),
		"connectTimeout": tea.IntValue(util.DefaultNumber(runtime.ConnectTimeout, client.ConnectTimeout)),
		"localAddr":      tea.StringValue(util.DefaultString(runtime.LocalAddr, client.LocalAddr)),
		"httpProxy":      tea.StringValue(util.DefaultString(runtime.HttpProxy, client.HttpProxy)),
		"httpsProxy":     tea.StringValue(util.DefaultString(runtime.HttpsProxy, client.HttpsProxy)),
		"noProxy":        tea.StringValue(util.DefaultString(runtime.NoProxy, client.NoProxy)),
		"socks5Proxy":    tea.StringValue(util.DefaultString(runtime.Socks5Proxy, client.Socks5Proxy)),
		"socks5NetWork":  tea.StringValue(util.DefaultString(runtime.Socks5NetWork, client.Socks5NetWork)),
		"maxIdleConns":   tea.IntValue(util.DefaultNumber(runtime.MaxIdleConns, client.MaxIdleConns)),
		"retry": map[string]interface{}{
			"retryable":   tea.BoolValue(runtime.Autoretry),
			"maxAttempts": tea.IntValue(util.DefaultNumber(runtime.MaxAttempts, tea.Int(3))),
		},
		"backoff": map[string]interface{}{
			"policy": tea.StringValue(util.DefaultString(runtime.BackoffPolicy, tea.String("no"))),
			"period": tea.IntValue(util.DefaultNumber(runtime.BackoffPeriod, tea.Int(1))),
		},
		"ignoreSSL": tea.BoolValue(runtime.IgnoreSSL),
	}

	_resp := &PutObjectTaggingResponse{}
	for _retryTimes := 0; tea.BoolValue(tea.AllowRetry(_runtime["retry"], tea.Int(_retryTimes))); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], tea.Int(_retryTimes))
			if tea.IntValue(_backoffTime) > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, _err = func() (*PutObjectTaggingResponse, error) {
			request_ := tea.NewRequest()
			accessKeyId, _err := client.Credential.GetAccessKeyId()
			if _err != nil {
				return _result, _err
			}

			accessKeySecret, _err := client.Credential.GetAccessKeySecret()
			if _err != nil {
				return _result, _err
			}

			token, _err := client.Credential.GetSecurityToken()
			if _err != nil {
				return _result, _err
			}

			reqBody := xml.ToXML(tea.ToMap(request.Body))
			request_.Protocol = client.Protocol
			request_.Method = tea.String("PUT")
			request_.Pathname = tea.String("/" + tea.StringValue(request.ObjectName) + "?tagging")
			request_.Headers = map[string]*string{
				"host":       ossutil.GetHost(request.BucketName, client.RegionId, client.Endpoint, client.HostModel),
				"date":       util.GetDateUTCString(),
				"user-agent": client.GetUserAgent(),
			}
			if !tea.BoolValue(util.Empty(token)) {
				request_.Headers["x-oss-security-token"] = token
			}

			request_.Body = tea.ToReader(reqBody)
			request_.Headers["authorization"] = ossutil.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, client.SignatureVersion, client.AddtionalHeaders)
			response_, _err := tea.DoRequest(request_, _runtime)
			if _err != nil {
				return _result, _err
			}
			var respMap map[string]interface{}
			var bodyStr *string
			if tea.BoolValue(util.Is4xx(response_.StatusCode)) || tea.BoolValue(util.Is5xx(response_.StatusCode)) {
				bodyStr, _err = util.ReadAsString(response_.Body)
				if _err != nil {
					return _result, _err
				}

				respMap = ossutil.GetErrMessage(bodyStr)
				_err = tea.NewSDKError(map[string]interface{}{
					"code":    respMap["Code"],
					"message": respMap["Message"],
					"data": map[string]interface{}{
						"httpCode":  tea.IntValue(response_.StatusCode),
						"requestId": respMap["RequestId"],
						"hostId":    respMap["HostId"],
					},
				})
				return _result, _err
			}

			_result = &PutObjectTaggingResponse{}
			_err = tea.Convert(response_.Headers, &_result)
			return _result, _err
		}()
		if !tea.BoolValue(tea.Retryable(_err)) {
			break
		}
	}

	return _resp, _err
}

func (client *Client) SelectObject(request *SelectObjectRequest, runtime *ossutil.RuntimeOptions) (_result *SelectObjectResponse, _err error) {
	_err = tea.Validate(request)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Validate(runtime)
	if _err != nil {
		return _result, _err
	}
	_runtime := map[string]interface{}{
		"timeouted":      "retry",
		"readTimeout":    tea.IntValue(util.DefaultNumber(runtime.ReadTimeout, client.ReadTimeout)),
		"connectTimeout": tea.IntValue(util.DefaultNumber(runtime.ConnectTimeout, client.ConnectTimeout)),
		"localAddr":      tea.StringValue(util.DefaultString(runtime.LocalAddr, client.LocalAddr)),
		"httpProxy":      tea.StringValue(util.DefaultString(runtime.HttpProxy, client.HttpProxy)),
		"httpsProxy":     tea.StringValue(util.DefaultString(runtime.HttpsProxy, client.HttpsProxy)),
		"noProxy":        tea.StringValue(util.DefaultString(runtime.NoProxy, client.NoProxy)),
		"socks5Proxy":    tea.StringValue(util.DefaultString(runtime.Socks5Proxy, client.Socks5Proxy)),
		"socks5NetWork":  tea.StringValue(util.DefaultString(runtime.Socks5NetWork, client.Socks5NetWork)),
		"maxIdleConns":   tea.IntValue(util.DefaultNumber(runtime.MaxIdleConns, client.MaxIdleConns)),
		"retry": map[string]interface{}{
			"retryable":   tea.BoolValue(runtime.Autoretry),
			"maxAttempts": tea.IntValue(util.DefaultNumber(runtime.MaxAttempts, tea.Int(3))),
		},
		"backoff": map[string]interface{}{
			"policy": tea.StringValue(util.DefaultString(runtime.BackoffPolicy, tea.String("no"))),
			"period": tea.IntValue(util.DefaultNumber(runtime.BackoffPeriod, tea.Int(1))),
		},
		"ignoreSSL": tea.BoolValue(runtime.IgnoreSSL),
	}

	_resp := &SelectObjectResponse{}
	for _retryTimes := 0; tea.BoolValue(tea.AllowRetry(_runtime["retry"], tea.Int(_retryTimes))); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], tea.Int(_retryTimes))
			if tea.IntValue(_backoffTime) > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, _err = func() (*SelectObjectResponse, error) {
			request_ := tea.NewRequest()
			accessKeyId, _err := client.Credential.GetAccessKeyId()
			if _err != nil {
				return _result, _err
			}

			accessKeySecret, _err := client.Credential.GetAccessKeySecret()
			if _err != nil {
				return _result, _err
			}

			token, _err := client.Credential.GetSecurityToken()
			if _err != nil {
				return _result, _err
			}

			reqBody := xml.ToXML(tea.ToMap(request.Body))
			request_.Protocol = client.Protocol
			request_.Method = tea.String("POST")
			request_.Pathname = tea.String("/" + tea.StringValue(request.ObjectName))
			request_.Headers = map[string]*string{
				"host":       ossutil.GetHost(request.BucketName, client.RegionId, client.Endpoint, client.HostModel),
				"date":       util.GetDateUTCString(),
				"user-agent": client.GetUserAgent(),
			}
			if !tea.BoolValue(util.Empty(token)) {
				request_.Headers["x-oss-security-token"] = token
			}

			request_.Query = util.StringifyMapValue(tea.ToMap(request.Filter))
			request_.Body = tea.ToReader(reqBody)
			request_.Headers["authorization"] = ossutil.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, client.SignatureVersion, client.AddtionalHeaders)
			response_, _err := tea.DoRequest(request_, _runtime)
			if _err != nil {
				return _result, _err
			}
			var respMap map[string]interface{}
			var bodyStr *string
			if tea.BoolValue(util.Is4xx(response_.StatusCode)) || tea.BoolValue(util.Is5xx(response_.StatusCode)) {
				bodyStr, _err = util.ReadAsString(response_.Body)
				if _err != nil {
					return _result, _err
				}

				respMap = ossutil.GetErrMessage(bodyStr)
				_err = tea.NewSDKError(map[string]interface{}{
					"code":    respMap["Code"],
					"message": respMap["Message"],
					"data": map[string]interface{}{
						"httpCode":  tea.IntValue(response_.StatusCode),
						"requestId": respMap["RequestId"],
						"hostId":    respMap["HostId"],
					},
				})
				return _result, _err
			}

			_result = &SelectObjectResponse{}
			_err = tea.Convert(response_.Headers, &_result)
			return _result, _err
		}()
		if !tea.BoolValue(tea.Retryable(_err)) {
			break
		}
	}

	return _resp, _err
}

func (client *Client) PutBucketCORS(request *PutBucketCORSRequest, runtime *ossutil.RuntimeOptions) (_result *PutBucketCORSResponse, _err error) {
	_err = tea.Validate(request)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Validate(runtime)
	if _err != nil {
		return _result, _err
	}
	_runtime := map[string]interface{}{
		"timeouted":      "retry",
		"readTimeout":    tea.IntValue(util.DefaultNumber(runtime.ReadTimeout, client.ReadTimeout)),
		"connectTimeout": tea.IntValue(util.DefaultNumber(runtime.ConnectTimeout, client.ConnectTimeout)),
		"localAddr":      tea.StringValue(util.DefaultString(runtime.LocalAddr, client.LocalAddr)),
		"httpProxy":      tea.StringValue(util.DefaultString(runtime.HttpProxy, client.HttpProxy)),
		"httpsProxy":     tea.StringValue(util.DefaultString(runtime.HttpsProxy, client.HttpsProxy)),
		"noProxy":        tea.StringValue(util.DefaultString(runtime.NoProxy, client.NoProxy)),
		"socks5Proxy":    tea.StringValue(util.DefaultString(runtime.Socks5Proxy, client.Socks5Proxy)),
		"socks5NetWork":  tea.StringValue(util.DefaultString(runtime.Socks5NetWork, client.Socks5NetWork)),
		"maxIdleConns":   tea.IntValue(util.DefaultNumber(runtime.MaxIdleConns, client.MaxIdleConns)),
		"retry": map[string]interface{}{
			"retryable":   tea.BoolValue(runtime.Autoretry),
			"maxAttempts": tea.IntValue(util.DefaultNumber(runtime.MaxAttempts, tea.Int(3))),
		},
		"backoff": map[string]interface{}{
			"policy": tea.StringValue(util.DefaultString(runtime.BackoffPolicy, tea.String("no"))),
			"period": tea.IntValue(util.DefaultNumber(runtime.BackoffPeriod, tea.Int(1))),
		},
		"ignoreSSL": tea.BoolValue(runtime.IgnoreSSL),
	}

	_resp := &PutBucketCORSResponse{}
	for _retryTimes := 0; tea.BoolValue(tea.AllowRetry(_runtime["retry"], tea.Int(_retryTimes))); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], tea.Int(_retryTimes))
			if tea.IntValue(_backoffTime) > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, _err = func() (*PutBucketCORSResponse, error) {
			request_ := tea.NewRequest()
			accessKeyId, _err := client.Credential.GetAccessKeyId()
			if _err != nil {
				return _result, _err
			}

			accessKeySecret, _err := client.Credential.GetAccessKeySecret()
			if _err != nil {
				return _result, _err
			}

			token, _err := client.Credential.GetSecurityToken()
			if _err != nil {
				return _result, _err
			}

			reqBody := xml.ToXML(tea.ToMap(request.Body))
			request_.Protocol = client.Protocol
			request_.Method = tea.String("PUT")
			request_.Pathname = tea.String("/?cors")
			request_.Headers = map[string]*string{
				"host":       ossutil.GetHost(request.BucketName, client.RegionId, client.Endpoint, client.HostModel),
				"date":       util.GetDateUTCString(),
				"user-agent": client.GetUserAgent(),
			}
			if !tea.BoolValue(util.Empty(token)) {
				request_.Headers["x-oss-security-token"] = token
			}

			request_.Body = tea.ToReader(reqBody)
			request_.Headers["authorization"] = ossutil.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, client.SignatureVersion, client.AddtionalHeaders)
			response_, _err := tea.DoRequest(request_, _runtime)
			if _err != nil {
				return _result, _err
			}
			var respMap map[string]interface{}
			var bodyStr *string
			if tea.BoolValue(util.Is4xx(response_.StatusCode)) || tea.BoolValue(util.Is5xx(response_.StatusCode)) {
				bodyStr, _err = util.ReadAsString(response_.Body)
				if _err != nil {
					return _result, _err
				}

				respMap = ossutil.GetErrMessage(bodyStr)
				_err = tea.NewSDKError(map[string]interface{}{
					"code":    respMap["Code"],
					"message": respMap["Message"],
					"data": map[string]interface{}{
						"httpCode":  tea.IntValue(response_.StatusCode),
						"requestId": respMap["RequestId"],
						"hostId":    respMap["HostId"],
					},
				})
				return _result, _err
			}

			_result = &PutBucketCORSResponse{}
			_err = tea.Convert(response_.Headers, &_result)
			return _result, _err
		}()
		if !tea.BoolValue(tea.Retryable(_err)) {
			break
		}
	}

	return _resp, _err
}

func (client *Client) PutBucket(request *PutBucketRequest, runtime *ossutil.RuntimeOptions) (_result *PutBucketResponse, _err error) {
	_err = tea.Validate(request)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Validate(runtime)
	if _err != nil {
		return _result, _err
	}
	_runtime := map[string]interface{}{
		"timeouted":      "retry",
		"readTimeout":    tea.IntValue(util.DefaultNumber(runtime.ReadTimeout, client.ReadTimeout)),
		"connectTimeout": tea.IntValue(util.DefaultNumber(runtime.ConnectTimeout, client.ConnectTimeout)),
		"localAddr":      tea.StringValue(util.DefaultString(runtime.LocalAddr, client.LocalAddr)),
		"httpProxy":      tea.StringValue(util.DefaultString(runtime.HttpProxy, client.HttpProxy)),
		"httpsProxy":     tea.StringValue(util.DefaultString(runtime.HttpsProxy, client.HttpsProxy)),
		"noProxy":        tea.StringValue(util.DefaultString(runtime.NoProxy, client.NoProxy)),
		"socks5Proxy":    tea.StringValue(util.DefaultString(runtime.Socks5Proxy, client.Socks5Proxy)),
		"socks5NetWork":  tea.StringValue(util.DefaultString(runtime.Socks5NetWork, client.Socks5NetWork)),
		"maxIdleConns":   tea.IntValue(util.DefaultNumber(runtime.MaxIdleConns, client.MaxIdleConns)),
		"retry": map[string]interface{}{
			"retryable":   tea.BoolValue(runtime.Autoretry),
			"maxAttempts": tea.IntValue(util.DefaultNumber(runtime.MaxAttempts, tea.Int(3))),
		},
		"backoff": map[string]interface{}{
			"policy": tea.StringValue(util.DefaultString(runtime.BackoffPolicy, tea.String("no"))),
			"period": tea.IntValue(util.DefaultNumber(runtime.BackoffPeriod, tea.Int(1))),
		},
		"ignoreSSL": tea.BoolValue(runtime.IgnoreSSL),
	}

	_resp := &PutBucketResponse{}
	for _retryTimes := 0; tea.BoolValue(tea.AllowRetry(_runtime["retry"], tea.Int(_retryTimes))); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], tea.Int(_retryTimes))
			if tea.IntValue(_backoffTime) > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, _err = func() (*PutBucketResponse, error) {
			request_ := tea.NewRequest()
			accessKeyId, _err := client.Credential.GetAccessKeyId()
			if _err != nil {
				return _result, _err
			}

			accessKeySecret, _err := client.Credential.GetAccessKeySecret()
			if _err != nil {
				return _result, _err
			}

			token, _err := client.Credential.GetSecurityToken()
			if _err != nil {
				return _result, _err
			}

			reqBody := xml.ToXML(tea.ToMap(request.Body))
			request_.Protocol = client.Protocol
			request_.Method = tea.String("PUT")
			request_.Pathname = tea.String("/")
			request_.Headers = tea.Merge(map[string]*string{
				"host":       ossutil.GetHost(request.BucketName, client.RegionId, client.Endpoint, client.HostModel),
				"date":       util.GetDateUTCString(),
				"user-agent": client.GetUserAgent(),
			}, util.StringifyMapValue(tea.ToMap(request.Header)))
			if !tea.BoolValue(util.Empty(token)) {
				request_.Headers["x-oss-security-token"] = token
			}

			request_.Body = tea.ToReader(reqBody)
			request_.Headers["authorization"] = ossutil.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, client.SignatureVersion, client.AddtionalHeaders)
			response_, _err := tea.DoRequest(request_, _runtime)
			if _err != nil {
				return _result, _err
			}
			var respMap map[string]interface{}
			var bodyStr *string
			if tea.BoolValue(util.Is4xx(response_.StatusCode)) || tea.BoolValue(util.Is5xx(response_.StatusCode)) {
				bodyStr, _err = util.ReadAsString(response_.Body)
				if _err != nil {
					return _result, _err
				}

				respMap = ossutil.GetErrMessage(bodyStr)
				_err = tea.NewSDKError(map[string]interface{}{
					"code":    respMap["Code"],
					"message": respMap["Message"],
					"data": map[string]interface{}{
						"httpCode":  tea.IntValue(response_.StatusCode),
						"requestId": respMap["RequestId"],
						"hostId":    respMap["HostId"],
					},
				})
				return _result, _err
			}

			_result = &PutBucketResponse{}
			_err = tea.Convert(response_.Headers, &_result)
			return _result, _err
		}()
		if !tea.BoolValue(tea.Retryable(_err)) {
			break
		}
	}

	return _resp, _err
}

func (client *Client) ListMultipartUploads(request *ListMultipartUploadsRequest, runtime *ossutil.RuntimeOptions) (_result *ListMultipartUploadsResponse, _err error) {
	_err = tea.Validate(request)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Validate(runtime)
	if _err != nil {
		return _result, _err
	}
	_runtime := map[string]interface{}{
		"timeouted":      "retry",
		"readTimeout":    tea.IntValue(util.DefaultNumber(runtime.ReadTimeout, client.ReadTimeout)),
		"connectTimeout": tea.IntValue(util.DefaultNumber(runtime.ConnectTimeout, client.ConnectTimeout)),
		"localAddr":      tea.StringValue(util.DefaultString(runtime.LocalAddr, client.LocalAddr)),
		"httpProxy":      tea.StringValue(util.DefaultString(runtime.HttpProxy, client.HttpProxy)),
		"httpsProxy":     tea.StringValue(util.DefaultString(runtime.HttpsProxy, client.HttpsProxy)),
		"noProxy":        tea.StringValue(util.DefaultString(runtime.NoProxy, client.NoProxy)),
		"socks5Proxy":    tea.StringValue(util.DefaultString(runtime.Socks5Proxy, client.Socks5Proxy)),
		"socks5NetWork":  tea.StringValue(util.DefaultString(runtime.Socks5NetWork, client.Socks5NetWork)),
		"maxIdleConns":   tea.IntValue(util.DefaultNumber(runtime.MaxIdleConns, client.MaxIdleConns)),
		"retry": map[string]interface{}{
			"retryable":   tea.BoolValue(runtime.Autoretry),
			"maxAttempts": tea.IntValue(util.DefaultNumber(runtime.MaxAttempts, tea.Int(3))),
		},
		"backoff": map[string]interface{}{
			"policy": tea.StringValue(util.DefaultString(runtime.BackoffPolicy, tea.String("no"))),
			"period": tea.IntValue(util.DefaultNumber(runtime.BackoffPeriod, tea.Int(1))),
		},
		"ignoreSSL": tea.BoolValue(runtime.IgnoreSSL),
	}

	_resp := &ListMultipartUploadsResponse{}
	for _retryTimes := 0; tea.BoolValue(tea.AllowRetry(_runtime["retry"], tea.Int(_retryTimes))); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], tea.Int(_retryTimes))
			if tea.IntValue(_backoffTime) > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, _err = func() (*ListMultipartUploadsResponse, error) {
			request_ := tea.NewRequest()
			accessKeyId, _err := client.Credential.GetAccessKeyId()
			if _err != nil {
				return _result, _err
			}

			accessKeySecret, _err := client.Credential.GetAccessKeySecret()
			if _err != nil {
				return _result, _err
			}

			token, _err := client.Credential.GetSecurityToken()
			if _err != nil {
				return _result, _err
			}

			request_.Protocol = client.Protocol
			request_.Method = tea.String("GET")
			request_.Pathname = tea.String("/?uploads")
			request_.Headers = map[string]*string{
				"host":       ossutil.GetHost(request.BucketName, client.RegionId, client.Endpoint, client.HostModel),
				"date":       util.GetDateUTCString(),
				"user-agent": client.GetUserAgent(),
			}
			if !tea.BoolValue(util.Empty(token)) {
				request_.Headers["x-oss-security-token"] = token
			}

			request_.Query = util.StringifyMapValue(tea.ToMap(request.Filter))
			request_.Headers["authorization"] = ossutil.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, client.SignatureVersion, client.AddtionalHeaders)
			response_, _err := tea.DoRequest(request_, _runtime)
			if _err != nil {
				return _result, _err
			}
			var respMap map[string]interface{}
			var bodyStr *string
			if tea.BoolValue(util.Is4xx(response_.StatusCode)) || tea.BoolValue(util.Is5xx(response_.StatusCode)) {
				bodyStr, _err = util.ReadAsString(response_.Body)
				if _err != nil {
					return _result, _err
				}

				respMap = ossutil.GetErrMessage(bodyStr)
				_err = tea.NewSDKError(map[string]interface{}{
					"code":    respMap["Code"],
					"message": respMap["Message"],
					"data": map[string]interface{}{
						"httpCode":  tea.IntValue(response_.StatusCode),
						"requestId": respMap["RequestId"],
						"hostId":    respMap["HostId"],
					},
				})
				return _result, _err
			}

			bodyStr, _err = util.ReadAsString(response_.Body)
			if _err != nil {
				return _result, _err
			}

			respMap = xml.ParseXml(bodyStr, new(ListMultipartUploadsResponse))
			_result = &ListMultipartUploadsResponse{}
			_err = tea.Convert(tea.ToMap(map[string]interface{}{
				"ListMultipartUploadsResult": respMap["ListMultipartUploadsResult"],
			}, response_.Headers), &_result)
			return _result, _err
		}()
		if !tea.BoolValue(tea.Retryable(_err)) {
			break
		}
	}

	return _resp, _err
}

func (client *Client) GetBucketRequestPayment(request *GetBucketRequestPaymentRequest, runtime *ossutil.RuntimeOptions) (_result *GetBucketRequestPaymentResponse, _err error) {
	_err = tea.Validate(request)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Validate(runtime)
	if _err != nil {
		return _result, _err
	}
	_runtime := map[string]interface{}{
		"timeouted":      "retry",
		"readTimeout":    tea.IntValue(util.DefaultNumber(runtime.ReadTimeout, client.ReadTimeout)),
		"connectTimeout": tea.IntValue(util.DefaultNumber(runtime.ConnectTimeout, client.ConnectTimeout)),
		"localAddr":      tea.StringValue(util.DefaultString(runtime.LocalAddr, client.LocalAddr)),
		"httpProxy":      tea.StringValue(util.DefaultString(runtime.HttpProxy, client.HttpProxy)),
		"httpsProxy":     tea.StringValue(util.DefaultString(runtime.HttpsProxy, client.HttpsProxy)),
		"noProxy":        tea.StringValue(util.DefaultString(runtime.NoProxy, client.NoProxy)),
		"socks5Proxy":    tea.StringValue(util.DefaultString(runtime.Socks5Proxy, client.Socks5Proxy)),
		"socks5NetWork":  tea.StringValue(util.DefaultString(runtime.Socks5NetWork, client.Socks5NetWork)),
		"maxIdleConns":   tea.IntValue(util.DefaultNumber(runtime.MaxIdleConns, client.MaxIdleConns)),
		"retry": map[string]interface{}{
			"retryable":   tea.BoolValue(runtime.Autoretry),
			"maxAttempts": tea.IntValue(util.DefaultNumber(runtime.MaxAttempts, tea.Int(3))),
		},
		"backoff": map[string]interface{}{
			"policy": tea.StringValue(util.DefaultString(runtime.BackoffPolicy, tea.String("no"))),
			"period": tea.IntValue(util.DefaultNumber(runtime.BackoffPeriod, tea.Int(1))),
		},
		"ignoreSSL": tea.BoolValue(runtime.IgnoreSSL),
	}

	_resp := &GetBucketRequestPaymentResponse{}
	for _retryTimes := 0; tea.BoolValue(tea.AllowRetry(_runtime["retry"], tea.Int(_retryTimes))); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], tea.Int(_retryTimes))
			if tea.IntValue(_backoffTime) > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, _err = func() (*GetBucketRequestPaymentResponse, error) {
			request_ := tea.NewRequest()
			accessKeyId, _err := client.Credential.GetAccessKeyId()
			if _err != nil {
				return _result, _err
			}

			accessKeySecret, _err := client.Credential.GetAccessKeySecret()
			if _err != nil {
				return _result, _err
			}

			token, _err := client.Credential.GetSecurityToken()
			if _err != nil {
				return _result, _err
			}

			request_.Protocol = client.Protocol
			request_.Method = tea.String("GET")
			request_.Pathname = tea.String("/?requestPayment")
			request_.Headers = map[string]*string{
				"host":       ossutil.GetHost(request.BucketName, client.RegionId, client.Endpoint, client.HostModel),
				"date":       util.GetDateUTCString(),
				"user-agent": client.GetUserAgent(),
			}
			if !tea.BoolValue(util.Empty(token)) {
				request_.Headers["x-oss-security-token"] = token
			}

			request_.Headers["authorization"] = ossutil.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, client.SignatureVersion, client.AddtionalHeaders)
			response_, _err := tea.DoRequest(request_, _runtime)
			if _err != nil {
				return _result, _err
			}
			var respMap map[string]interface{}
			var bodyStr *string
			if tea.BoolValue(util.Is4xx(response_.StatusCode)) || tea.BoolValue(util.Is5xx(response_.StatusCode)) {
				bodyStr, _err = util.ReadAsString(response_.Body)
				if _err != nil {
					return _result, _err
				}

				respMap = ossutil.GetErrMessage(bodyStr)
				_err = tea.NewSDKError(map[string]interface{}{
					"code":    respMap["Code"],
					"message": respMap["Message"],
					"data": map[string]interface{}{
						"httpCode":  tea.IntValue(response_.StatusCode),
						"requestId": respMap["RequestId"],
						"hostId":    respMap["HostId"],
					},
				})
				return _result, _err
			}

			bodyStr, _err = util.ReadAsString(response_.Body)
			if _err != nil {
				return _result, _err
			}

			respMap = xml.ParseXml(bodyStr, new(GetBucketRequestPaymentResponse))
			_result = &GetBucketRequestPaymentResponse{}
			_err = tea.Convert(tea.ToMap(map[string]interface{}{
				"RequestPaymentConfiguration": respMap["RequestPaymentConfiguration"],
			}, response_.Headers), &_result)
			return _result, _err
		}()
		if !tea.BoolValue(tea.Retryable(_err)) {
			break
		}
	}

	return _resp, _err
}

func (client *Client) GetBucketEncryption(request *GetBucketEncryptionRequest, runtime *ossutil.RuntimeOptions) (_result *GetBucketEncryptionResponse, _err error) {
	_err = tea.Validate(request)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Validate(runtime)
	if _err != nil {
		return _result, _err
	}
	_runtime := map[string]interface{}{
		"timeouted":      "retry",
		"readTimeout":    tea.IntValue(util.DefaultNumber(runtime.ReadTimeout, client.ReadTimeout)),
		"connectTimeout": tea.IntValue(util.DefaultNumber(runtime.ConnectTimeout, client.ConnectTimeout)),
		"localAddr":      tea.StringValue(util.DefaultString(runtime.LocalAddr, client.LocalAddr)),
		"httpProxy":      tea.StringValue(util.DefaultString(runtime.HttpProxy, client.HttpProxy)),
		"httpsProxy":     tea.StringValue(util.DefaultString(runtime.HttpsProxy, client.HttpsProxy)),
		"noProxy":        tea.StringValue(util.DefaultString(runtime.NoProxy, client.NoProxy)),
		"socks5Proxy":    tea.StringValue(util.DefaultString(runtime.Socks5Proxy, client.Socks5Proxy)),
		"socks5NetWork":  tea.StringValue(util.DefaultString(runtime.Socks5NetWork, client.Socks5NetWork)),
		"maxIdleConns":   tea.IntValue(util.DefaultNumber(runtime.MaxIdleConns, client.MaxIdleConns)),
		"retry": map[string]interface{}{
			"retryable":   tea.BoolValue(runtime.Autoretry),
			"maxAttempts": tea.IntValue(util.DefaultNumber(runtime.MaxAttempts, tea.Int(3))),
		},
		"backoff": map[string]interface{}{
			"policy": tea.StringValue(util.DefaultString(runtime.BackoffPolicy, tea.String("no"))),
			"period": tea.IntValue(util.DefaultNumber(runtime.BackoffPeriod, tea.Int(1))),
		},
		"ignoreSSL": tea.BoolValue(runtime.IgnoreSSL),
	}

	_resp := &GetBucketEncryptionResponse{}
	for _retryTimes := 0; tea.BoolValue(tea.AllowRetry(_runtime["retry"], tea.Int(_retryTimes))); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], tea.Int(_retryTimes))
			if tea.IntValue(_backoffTime) > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, _err = func() (*GetBucketEncryptionResponse, error) {
			request_ := tea.NewRequest()
			accessKeyId, _err := client.Credential.GetAccessKeyId()
			if _err != nil {
				return _result, _err
			}

			accessKeySecret, _err := client.Credential.GetAccessKeySecret()
			if _err != nil {
				return _result, _err
			}

			token, _err := client.Credential.GetSecurityToken()
			if _err != nil {
				return _result, _err
			}

			request_.Protocol = client.Protocol
			request_.Method = tea.String("GET")
			request_.Pathname = tea.String("/?encryption")
			request_.Headers = map[string]*string{
				"host":       ossutil.GetHost(request.BucketName, client.RegionId, client.Endpoint, client.HostModel),
				"date":       util.GetDateUTCString(),
				"user-agent": client.GetUserAgent(),
			}
			if !tea.BoolValue(util.Empty(token)) {
				request_.Headers["x-oss-security-token"] = token
			}

			request_.Headers["authorization"] = ossutil.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, client.SignatureVersion, client.AddtionalHeaders)
			response_, _err := tea.DoRequest(request_, _runtime)
			if _err != nil {
				return _result, _err
			}
			var respMap map[string]interface{}
			var bodyStr *string
			if tea.BoolValue(util.Is4xx(response_.StatusCode)) || tea.BoolValue(util.Is5xx(response_.StatusCode)) {
				bodyStr, _err = util.ReadAsString(response_.Body)
				if _err != nil {
					return _result, _err
				}

				respMap = ossutil.GetErrMessage(bodyStr)
				_err = tea.NewSDKError(map[string]interface{}{
					"code":    respMap["Code"],
					"message": respMap["Message"],
					"data": map[string]interface{}{
						"httpCode":  tea.IntValue(response_.StatusCode),
						"requestId": respMap["RequestId"],
						"hostId":    respMap["HostId"],
					},
				})
				return _result, _err
			}

			bodyStr, _err = util.ReadAsString(response_.Body)
			if _err != nil {
				return _result, _err
			}

			respMap = xml.ParseXml(bodyStr, new(GetBucketEncryptionResponse))
			_result = &GetBucketEncryptionResponse{}
			_err = tea.Convert(tea.ToMap(map[string]interface{}{
				"ServerSideEncryptionRule": respMap["ServerSideEncryptionRule"],
			}, response_.Headers), &_result)
			return _result, _err
		}()
		if !tea.BoolValue(tea.Retryable(_err)) {
			break
		}
	}

	return _resp, _err
}

func (client *Client) GetBucketTags(request *GetBucketTagsRequest, runtime *ossutil.RuntimeOptions) (_result *GetBucketTagsResponse, _err error) {
	_err = tea.Validate(request)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Validate(runtime)
	if _err != nil {
		return _result, _err
	}
	_runtime := map[string]interface{}{
		"timeouted":      "retry",
		"readTimeout":    tea.IntValue(util.DefaultNumber(runtime.ReadTimeout, client.ReadTimeout)),
		"connectTimeout": tea.IntValue(util.DefaultNumber(runtime.ConnectTimeout, client.ConnectTimeout)),
		"localAddr":      tea.StringValue(util.DefaultString(runtime.LocalAddr, client.LocalAddr)),
		"httpProxy":      tea.StringValue(util.DefaultString(runtime.HttpProxy, client.HttpProxy)),
		"httpsProxy":     tea.StringValue(util.DefaultString(runtime.HttpsProxy, client.HttpsProxy)),
		"noProxy":        tea.StringValue(util.DefaultString(runtime.NoProxy, client.NoProxy)),
		"socks5Proxy":    tea.StringValue(util.DefaultString(runtime.Socks5Proxy, client.Socks5Proxy)),
		"socks5NetWork":  tea.StringValue(util.DefaultString(runtime.Socks5NetWork, client.Socks5NetWork)),
		"maxIdleConns":   tea.IntValue(util.DefaultNumber(runtime.MaxIdleConns, client.MaxIdleConns)),
		"retry": map[string]interface{}{
			"retryable":   tea.BoolValue(runtime.Autoretry),
			"maxAttempts": tea.IntValue(util.DefaultNumber(runtime.MaxAttempts, tea.Int(3))),
		},
		"backoff": map[string]interface{}{
			"policy": tea.StringValue(util.DefaultString(runtime.BackoffPolicy, tea.String("no"))),
			"period": tea.IntValue(util.DefaultNumber(runtime.BackoffPeriod, tea.Int(1))),
		},
		"ignoreSSL": tea.BoolValue(runtime.IgnoreSSL),
	}

	_resp := &GetBucketTagsResponse{}
	for _retryTimes := 0; tea.BoolValue(tea.AllowRetry(_runtime["retry"], tea.Int(_retryTimes))); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], tea.Int(_retryTimes))
			if tea.IntValue(_backoffTime) > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, _err = func() (*GetBucketTagsResponse, error) {
			request_ := tea.NewRequest()
			accessKeyId, _err := client.Credential.GetAccessKeyId()
			if _err != nil {
				return _result, _err
			}

			accessKeySecret, _err := client.Credential.GetAccessKeySecret()
			if _err != nil {
				return _result, _err
			}

			token, _err := client.Credential.GetSecurityToken()
			if _err != nil {
				return _result, _err
			}

			request_.Protocol = client.Protocol
			request_.Method = tea.String("GET")
			request_.Pathname = tea.String("/?tagging")
			request_.Headers = map[string]*string{
				"host":       ossutil.GetHost(request.BucketName, client.RegionId, client.Endpoint, client.HostModel),
				"date":       util.GetDateUTCString(),
				"user-agent": client.GetUserAgent(),
			}
			if !tea.BoolValue(util.Empty(token)) {
				request_.Headers["x-oss-security-token"] = token
			}

			request_.Headers["authorization"] = ossutil.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, client.SignatureVersion, client.AddtionalHeaders)
			response_, _err := tea.DoRequest(request_, _runtime)
			if _err != nil {
				return _result, _err
			}
			var respMap map[string]interface{}
			var bodyStr *string
			if tea.BoolValue(util.Is4xx(response_.StatusCode)) || tea.BoolValue(util.Is5xx(response_.StatusCode)) {
				bodyStr, _err = util.ReadAsString(response_.Body)
				if _err != nil {
					return _result, _err
				}

				respMap = ossutil.GetErrMessage(bodyStr)
				_err = tea.NewSDKError(map[string]interface{}{
					"code":    respMap["Code"],
					"message": respMap["Message"],
					"data": map[string]interface{}{
						"httpCode":  tea.IntValue(response_.StatusCode),
						"requestId": respMap["RequestId"],
						"hostId":    respMap["HostId"],
					},
				})
				return _result, _err
			}

			bodyStr, _err = util.ReadAsString(response_.Body)
			if _err != nil {
				return _result, _err
			}

			respMap = xml.ParseXml(bodyStr, new(GetBucketTagsResponse))
			_result = &GetBucketTagsResponse{}
			_err = tea.Convert(tea.ToMap(map[string]interface{}{
				"Tagging": respMap["Tagging"],
			}, response_.Headers), &_result)
			return _result, _err
		}()
		if !tea.BoolValue(tea.Retryable(_err)) {
			break
		}
	}

	return _resp, _err
}

func (client *Client) GetService(request *GetServiceRequest, runtime *ossutil.RuntimeOptions) (_result *GetServiceResponse, _err error) {
	_err = tea.Validate(request)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Validate(runtime)
	if _err != nil {
		return _result, _err
	}
	_runtime := map[string]interface{}{
		"timeouted":      "retry",
		"readTimeout":    tea.IntValue(util.DefaultNumber(runtime.ReadTimeout, client.ReadTimeout)),
		"connectTimeout": tea.IntValue(util.DefaultNumber(runtime.ConnectTimeout, client.ConnectTimeout)),
		"localAddr":      tea.StringValue(util.DefaultString(runtime.LocalAddr, client.LocalAddr)),
		"httpProxy":      tea.StringValue(util.DefaultString(runtime.HttpProxy, client.HttpProxy)),
		"httpsProxy":     tea.StringValue(util.DefaultString(runtime.HttpsProxy, client.HttpsProxy)),
		"noProxy":        tea.StringValue(util.DefaultString(runtime.NoProxy, client.NoProxy)),
		"socks5Proxy":    tea.StringValue(util.DefaultString(runtime.Socks5Proxy, client.Socks5Proxy)),
		"socks5NetWork":  tea.StringValue(util.DefaultString(runtime.Socks5NetWork, client.Socks5NetWork)),
		"maxIdleConns":   tea.IntValue(util.DefaultNumber(runtime.MaxIdleConns, client.MaxIdleConns)),
		"retry": map[string]interface{}{
			"retryable":   tea.BoolValue(runtime.Autoretry),
			"maxAttempts": tea.IntValue(util.DefaultNumber(runtime.MaxAttempts, tea.Int(3))),
		},
		"backoff": map[string]interface{}{
			"policy": tea.StringValue(util.DefaultString(runtime.BackoffPolicy, tea.String("no"))),
			"period": tea.IntValue(util.DefaultNumber(runtime.BackoffPeriod, tea.Int(1))),
		},
		"ignoreSSL": tea.BoolValue(runtime.IgnoreSSL),
	}

	_resp := &GetServiceResponse{}
	for _retryTimes := 0; tea.BoolValue(tea.AllowRetry(_runtime["retry"], tea.Int(_retryTimes))); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], tea.Int(_retryTimes))
			if tea.IntValue(_backoffTime) > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, _err = func() (*GetServiceResponse, error) {
			request_ := tea.NewRequest()
			accessKeyId, _err := client.Credential.GetAccessKeyId()
			if _err != nil {
				return _result, _err
			}

			accessKeySecret, _err := client.Credential.GetAccessKeySecret()
			if _err != nil {
				return _result, _err
			}

			token, _err := client.Credential.GetSecurityToken()
			if _err != nil {
				return _result, _err
			}

			request_.Protocol = client.Protocol
			request_.Method = tea.String("GET")
			request_.Pathname = tea.String("/")
			request_.Headers = map[string]*string{
				"host":       ossutil.GetHost(tea.String(""), client.RegionId, client.Endpoint, client.HostModel),
				"date":       util.GetDateUTCString(),
				"user-agent": client.GetUserAgent(),
			}
			if !tea.BoolValue(util.Empty(token)) {
				request_.Headers["x-oss-security-token"] = token
			}

			request_.Query = util.StringifyMapValue(tea.ToMap(request.Filter))
			request_.Headers["authorization"] = ossutil.GetSignature(request_, tea.String(""), accessKeyId, accessKeySecret, client.SignatureVersion, client.AddtionalHeaders)
			response_, _err := tea.DoRequest(request_, _runtime)
			if _err != nil {
				return _result, _err
			}
			var respMap map[string]interface{}
			var bodyStr *string
			if tea.BoolValue(util.Is4xx(response_.StatusCode)) || tea.BoolValue(util.Is5xx(response_.StatusCode)) {
				bodyStr, _err = util.ReadAsString(response_.Body)
				if _err != nil {
					return _result, _err
				}

				respMap = ossutil.GetErrMessage(bodyStr)
				_err = tea.NewSDKError(map[string]interface{}{
					"code":    respMap["Code"],
					"message": respMap["Message"],
					"data": map[string]interface{}{
						"httpCode":  tea.IntValue(response_.StatusCode),
						"requestId": respMap["RequestId"],
						"hostId":    respMap["HostId"],
					},
				})
				return _result, _err
			}

			bodyStr, _err = util.ReadAsString(response_.Body)
			if _err != nil {
				return _result, _err
			}

			respMap = xml.ParseXml(bodyStr, new(GetServiceResponse))
			_result = &GetServiceResponse{}
			_err = tea.Convert(tea.ToMap(map[string]interface{}{
				"ListAllMyBucketsResult": respMap["ListAllMyBucketsResult"],
			}, response_.Headers), &_result)
			return _result, _err
		}()
		if !tea.BoolValue(tea.Retryable(_err)) {
			break
		}
	}

	return _resp, _err
}

func (client *Client) DeleteBucketEncryption(request *DeleteBucketEncryptionRequest, runtime *ossutil.RuntimeOptions) (_result *DeleteBucketEncryptionResponse, _err error) {
	_err = tea.Validate(request)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Validate(runtime)
	if _err != nil {
		return _result, _err
	}
	_runtime := map[string]interface{}{
		"timeouted":      "retry",
		"readTimeout":    tea.IntValue(util.DefaultNumber(runtime.ReadTimeout, client.ReadTimeout)),
		"connectTimeout": tea.IntValue(util.DefaultNumber(runtime.ConnectTimeout, client.ConnectTimeout)),
		"localAddr":      tea.StringValue(util.DefaultString(runtime.LocalAddr, client.LocalAddr)),
		"httpProxy":      tea.StringValue(util.DefaultString(runtime.HttpProxy, client.HttpProxy)),
		"httpsProxy":     tea.StringValue(util.DefaultString(runtime.HttpsProxy, client.HttpsProxy)),
		"noProxy":        tea.StringValue(util.DefaultString(runtime.NoProxy, client.NoProxy)),
		"socks5Proxy":    tea.StringValue(util.DefaultString(runtime.Socks5Proxy, client.Socks5Proxy)),
		"socks5NetWork":  tea.StringValue(util.DefaultString(runtime.Socks5NetWork, client.Socks5NetWork)),
		"maxIdleConns":   tea.IntValue(util.DefaultNumber(runtime.MaxIdleConns, client.MaxIdleConns)),
		"retry": map[string]interface{}{
			"retryable":   tea.BoolValue(runtime.Autoretry),
			"maxAttempts": tea.IntValue(util.DefaultNumber(runtime.MaxAttempts, tea.Int(3))),
		},
		"backoff": map[string]interface{}{
			"policy": tea.StringValue(util.DefaultString(runtime.BackoffPolicy, tea.String("no"))),
			"period": tea.IntValue(util.DefaultNumber(runtime.BackoffPeriod, tea.Int(1))),
		},
		"ignoreSSL": tea.BoolValue(runtime.IgnoreSSL),
	}

	_resp := &DeleteBucketEncryptionResponse{}
	for _retryTimes := 0; tea.BoolValue(tea.AllowRetry(_runtime["retry"], tea.Int(_retryTimes))); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], tea.Int(_retryTimes))
			if tea.IntValue(_backoffTime) > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, _err = func() (*DeleteBucketEncryptionResponse, error) {
			request_ := tea.NewRequest()
			accessKeyId, _err := client.Credential.GetAccessKeyId()
			if _err != nil {
				return _result, _err
			}

			accessKeySecret, _err := client.Credential.GetAccessKeySecret()
			if _err != nil {
				return _result, _err
			}

			token, _err := client.Credential.GetSecurityToken()
			if _err != nil {
				return _result, _err
			}

			request_.Protocol = client.Protocol
			request_.Method = tea.String("DELETE")
			request_.Pathname = tea.String("/?encryption")
			request_.Headers = map[string]*string{
				"host":       ossutil.GetHost(request.BucketName, client.RegionId, client.Endpoint, client.HostModel),
				"date":       util.GetDateUTCString(),
				"user-agent": client.GetUserAgent(),
			}
			if !tea.BoolValue(util.Empty(token)) {
				request_.Headers["x-oss-security-token"] = token
			}

			request_.Headers["authorization"] = ossutil.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, client.SignatureVersion, client.AddtionalHeaders)
			response_, _err := tea.DoRequest(request_, _runtime)
			if _err != nil {
				return _result, _err
			}
			var respMap map[string]interface{}
			var bodyStr *string
			if tea.BoolValue(util.Is4xx(response_.StatusCode)) || tea.BoolValue(util.Is5xx(response_.StatusCode)) {
				bodyStr, _err = util.ReadAsString(response_.Body)
				if _err != nil {
					return _result, _err
				}

				respMap = ossutil.GetErrMessage(bodyStr)
				_err = tea.NewSDKError(map[string]interface{}{
					"code":    respMap["Code"],
					"message": respMap["Message"],
					"data": map[string]interface{}{
						"httpCode":  tea.IntValue(response_.StatusCode),
						"requestId": respMap["RequestId"],
						"hostId":    respMap["HostId"],
					},
				})
				return _result, _err
			}

			_result = &DeleteBucketEncryptionResponse{}
			_err = tea.Convert(response_.Headers, &_result)
			return _result, _err
		}()
		if !tea.BoolValue(tea.Retryable(_err)) {
			break
		}
	}

	return _resp, _err
}

func (client *Client) DeleteBucketTags(request *DeleteBucketTagsRequest, runtime *ossutil.RuntimeOptions) (_result *DeleteBucketTagsResponse, _err error) {
	_err = tea.Validate(request)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Validate(runtime)
	if _err != nil {
		return _result, _err
	}
	_runtime := map[string]interface{}{
		"timeouted":      "retry",
		"readTimeout":    tea.IntValue(util.DefaultNumber(runtime.ReadTimeout, client.ReadTimeout)),
		"connectTimeout": tea.IntValue(util.DefaultNumber(runtime.ConnectTimeout, client.ConnectTimeout)),
		"localAddr":      tea.StringValue(util.DefaultString(runtime.LocalAddr, client.LocalAddr)),
		"httpProxy":      tea.StringValue(util.DefaultString(runtime.HttpProxy, client.HttpProxy)),
		"httpsProxy":     tea.StringValue(util.DefaultString(runtime.HttpsProxy, client.HttpsProxy)),
		"noProxy":        tea.StringValue(util.DefaultString(runtime.NoProxy, client.NoProxy)),
		"socks5Proxy":    tea.StringValue(util.DefaultString(runtime.Socks5Proxy, client.Socks5Proxy)),
		"socks5NetWork":  tea.StringValue(util.DefaultString(runtime.Socks5NetWork, client.Socks5NetWork)),
		"maxIdleConns":   tea.IntValue(util.DefaultNumber(runtime.MaxIdleConns, client.MaxIdleConns)),
		"retry": map[string]interface{}{
			"retryable":   tea.BoolValue(runtime.Autoretry),
			"maxAttempts": tea.IntValue(util.DefaultNumber(runtime.MaxAttempts, tea.Int(3))),
		},
		"backoff": map[string]interface{}{
			"policy": tea.StringValue(util.DefaultString(runtime.BackoffPolicy, tea.String("no"))),
			"period": tea.IntValue(util.DefaultNumber(runtime.BackoffPeriod, tea.Int(1))),
		},
		"ignoreSSL": tea.BoolValue(runtime.IgnoreSSL),
	}

	_resp := &DeleteBucketTagsResponse{}
	for _retryTimes := 0; tea.BoolValue(tea.AllowRetry(_runtime["retry"], tea.Int(_retryTimes))); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], tea.Int(_retryTimes))
			if tea.IntValue(_backoffTime) > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, _err = func() (*DeleteBucketTagsResponse, error) {
			request_ := tea.NewRequest()
			accessKeyId, _err := client.Credential.GetAccessKeyId()
			if _err != nil {
				return _result, _err
			}

			accessKeySecret, _err := client.Credential.GetAccessKeySecret()
			if _err != nil {
				return _result, _err
			}

			token, _err := client.Credential.GetSecurityToken()
			if _err != nil {
				return _result, _err
			}

			request_.Protocol = client.Protocol
			request_.Method = tea.String("DELETE")
			request_.Pathname = tea.String("/")
			request_.Headers = map[string]*string{
				"host":       ossutil.GetHost(request.BucketName, client.RegionId, client.Endpoint, client.HostModel),
				"date":       util.GetDateUTCString(),
				"user-agent": client.GetUserAgent(),
			}
			if !tea.BoolValue(util.Empty(token)) {
				request_.Headers["x-oss-security-token"] = token
			}

			request_.Query = util.StringifyMapValue(tea.ToMap(request.Filter))
			request_.Headers["authorization"] = ossutil.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, client.SignatureVersion, client.AddtionalHeaders)
			response_, _err := tea.DoRequest(request_, _runtime)
			if _err != nil {
				return _result, _err
			}
			var respMap map[string]interface{}
			var bodyStr *string
			if tea.BoolValue(util.Is4xx(response_.StatusCode)) || tea.BoolValue(util.Is5xx(response_.StatusCode)) {
				bodyStr, _err = util.ReadAsString(response_.Body)
				if _err != nil {
					return _result, _err
				}

				respMap = ossutil.GetErrMessage(bodyStr)
				_err = tea.NewSDKError(map[string]interface{}{
					"code":    respMap["Code"],
					"message": respMap["Message"],
					"data": map[string]interface{}{
						"httpCode":  tea.IntValue(response_.StatusCode),
						"requestId": respMap["RequestId"],
						"hostId":    respMap["HostId"],
					},
				})
				return _result, _err
			}

			_result = &DeleteBucketTagsResponse{}
			_err = tea.Convert(response_.Headers, &_result)
			return _result, _err
		}()
		if !tea.BoolValue(tea.Retryable(_err)) {
			break
		}
	}

	return _resp, _err
}

func (client *Client) GetBucketWebsite(request *GetBucketWebsiteRequest, runtime *ossutil.RuntimeOptions) (_result *GetBucketWebsiteResponse, _err error) {
	_err = tea.Validate(request)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Validate(runtime)
	if _err != nil {
		return _result, _err
	}
	_runtime := map[string]interface{}{
		"timeouted":      "retry",
		"readTimeout":    tea.IntValue(util.DefaultNumber(runtime.ReadTimeout, client.ReadTimeout)),
		"connectTimeout": tea.IntValue(util.DefaultNumber(runtime.ConnectTimeout, client.ConnectTimeout)),
		"localAddr":      tea.StringValue(util.DefaultString(runtime.LocalAddr, client.LocalAddr)),
		"httpProxy":      tea.StringValue(util.DefaultString(runtime.HttpProxy, client.HttpProxy)),
		"httpsProxy":     tea.StringValue(util.DefaultString(runtime.HttpsProxy, client.HttpsProxy)),
		"noProxy":        tea.StringValue(util.DefaultString(runtime.NoProxy, client.NoProxy)),
		"socks5Proxy":    tea.StringValue(util.DefaultString(runtime.Socks5Proxy, client.Socks5Proxy)),
		"socks5NetWork":  tea.StringValue(util.DefaultString(runtime.Socks5NetWork, client.Socks5NetWork)),
		"maxIdleConns":   tea.IntValue(util.DefaultNumber(runtime.MaxIdleConns, client.MaxIdleConns)),
		"retry": map[string]interface{}{
			"retryable":   tea.BoolValue(runtime.Autoretry),
			"maxAttempts": tea.IntValue(util.DefaultNumber(runtime.MaxAttempts, tea.Int(3))),
		},
		"backoff": map[string]interface{}{
			"policy": tea.StringValue(util.DefaultString(runtime.BackoffPolicy, tea.String("no"))),
			"period": tea.IntValue(util.DefaultNumber(runtime.BackoffPeriod, tea.Int(1))),
		},
		"ignoreSSL": tea.BoolValue(runtime.IgnoreSSL),
	}

	_resp := &GetBucketWebsiteResponse{}
	for _retryTimes := 0; tea.BoolValue(tea.AllowRetry(_runtime["retry"], tea.Int(_retryTimes))); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], tea.Int(_retryTimes))
			if tea.IntValue(_backoffTime) > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, _err = func() (*GetBucketWebsiteResponse, error) {
			request_ := tea.NewRequest()
			accessKeyId, _err := client.Credential.GetAccessKeyId()
			if _err != nil {
				return _result, _err
			}

			accessKeySecret, _err := client.Credential.GetAccessKeySecret()
			if _err != nil {
				return _result, _err
			}

			token, _err := client.Credential.GetSecurityToken()
			if _err != nil {
				return _result, _err
			}

			request_.Protocol = client.Protocol
			request_.Method = tea.String("GET")
			request_.Pathname = tea.String("/?website")
			request_.Headers = map[string]*string{
				"host":       ossutil.GetHost(request.BucketName, client.RegionId, client.Endpoint, client.HostModel),
				"date":       util.GetDateUTCString(),
				"user-agent": client.GetUserAgent(),
			}
			if !tea.BoolValue(util.Empty(token)) {
				request_.Headers["x-oss-security-token"] = token
			}

			request_.Headers["authorization"] = ossutil.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, client.SignatureVersion, client.AddtionalHeaders)
			response_, _err := tea.DoRequest(request_, _runtime)
			if _err != nil {
				return _result, _err
			}
			var respMap map[string]interface{}
			var bodyStr *string
			if tea.BoolValue(util.Is4xx(response_.StatusCode)) || tea.BoolValue(util.Is5xx(response_.StatusCode)) {
				bodyStr, _err = util.ReadAsString(response_.Body)
				if _err != nil {
					return _result, _err
				}

				respMap = ossutil.GetErrMessage(bodyStr)
				_err = tea.NewSDKError(map[string]interface{}{
					"code":    respMap["Code"],
					"message": respMap["Message"],
					"data": map[string]interface{}{
						"httpCode":  tea.IntValue(response_.StatusCode),
						"requestId": respMap["RequestId"],
						"hostId":    respMap["HostId"],
					},
				})
				return _result, _err
			}

			bodyStr, _err = util.ReadAsString(response_.Body)
			if _err != nil {
				return _result, _err
			}

			respMap = xml.ParseXml(bodyStr, new(GetBucketWebsiteResponse))
			_result = &GetBucketWebsiteResponse{}
			_err = tea.Convert(tea.ToMap(map[string]interface{}{
				"WebsiteConfiguration": respMap["WebsiteConfiguration"],
			}, response_.Headers), &_result)
			return _result, _err
		}()
		if !tea.BoolValue(tea.Retryable(_err)) {
			break
		}
	}

	return _resp, _err
}

func (client *Client) DeleteLiveChannel(request *DeleteLiveChannelRequest, runtime *ossutil.RuntimeOptions) (_result *DeleteLiveChannelResponse, _err error) {
	_err = tea.Validate(request)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Validate(runtime)
	if _err != nil {
		return _result, _err
	}
	_runtime := map[string]interface{}{
		"timeouted":      "retry",
		"readTimeout":    tea.IntValue(util.DefaultNumber(runtime.ReadTimeout, client.ReadTimeout)),
		"connectTimeout": tea.IntValue(util.DefaultNumber(runtime.ConnectTimeout, client.ConnectTimeout)),
		"localAddr":      tea.StringValue(util.DefaultString(runtime.LocalAddr, client.LocalAddr)),
		"httpProxy":      tea.StringValue(util.DefaultString(runtime.HttpProxy, client.HttpProxy)),
		"httpsProxy":     tea.StringValue(util.DefaultString(runtime.HttpsProxy, client.HttpsProxy)),
		"noProxy":        tea.StringValue(util.DefaultString(runtime.NoProxy, client.NoProxy)),
		"socks5Proxy":    tea.StringValue(util.DefaultString(runtime.Socks5Proxy, client.Socks5Proxy)),
		"socks5NetWork":  tea.StringValue(util.DefaultString(runtime.Socks5NetWork, client.Socks5NetWork)),
		"maxIdleConns":   tea.IntValue(util.DefaultNumber(runtime.MaxIdleConns, client.MaxIdleConns)),
		"retry": map[string]interface{}{
			"retryable":   tea.BoolValue(runtime.Autoretry),
			"maxAttempts": tea.IntValue(util.DefaultNumber(runtime.MaxAttempts, tea.Int(3))),
		},
		"backoff": map[string]interface{}{
			"policy": tea.StringValue(util.DefaultString(runtime.BackoffPolicy, tea.String("no"))),
			"period": tea.IntValue(util.DefaultNumber(runtime.BackoffPeriod, tea.Int(1))),
		},
		"ignoreSSL": tea.BoolValue(runtime.IgnoreSSL),
	}

	_resp := &DeleteLiveChannelResponse{}
	for _retryTimes := 0; tea.BoolValue(tea.AllowRetry(_runtime["retry"], tea.Int(_retryTimes))); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], tea.Int(_retryTimes))
			if tea.IntValue(_backoffTime) > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, _err = func() (*DeleteLiveChannelResponse, error) {
			request_ := tea.NewRequest()
			accessKeyId, _err := client.Credential.GetAccessKeyId()
			if _err != nil {
				return _result, _err
			}

			accessKeySecret, _err := client.Credential.GetAccessKeySecret()
			if _err != nil {
				return _result, _err
			}

			token, _err := client.Credential.GetSecurityToken()
			if _err != nil {
				return _result, _err
			}

			request_.Protocol = client.Protocol
			request_.Method = tea.String("DELETE")
			request_.Pathname = tea.String("/" + tea.StringValue(request.ChannelName) + "?live")
			request_.Headers = map[string]*string{
				"host":       ossutil.GetHost(request.BucketName, client.RegionId, client.Endpoint, client.HostModel),
				"date":       util.GetDateUTCString(),
				"user-agent": client.GetUserAgent(),
			}
			if !tea.BoolValue(util.Empty(token)) {
				request_.Headers["x-oss-security-token"] = token
			}

			request_.Headers["authorization"] = ossutil.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, client.SignatureVersion, client.AddtionalHeaders)
			response_, _err := tea.DoRequest(request_, _runtime)
			if _err != nil {
				return _result, _err
			}
			var respMap map[string]interface{}
			var bodyStr *string
			if tea.BoolValue(util.Is4xx(response_.StatusCode)) || tea.BoolValue(util.Is5xx(response_.StatusCode)) {
				bodyStr, _err = util.ReadAsString(response_.Body)
				if _err != nil {
					return _result, _err
				}

				respMap = ossutil.GetErrMessage(bodyStr)
				_err = tea.NewSDKError(map[string]interface{}{
					"code":    respMap["Code"],
					"message": respMap["Message"],
					"data": map[string]interface{}{
						"httpCode":  tea.IntValue(response_.StatusCode),
						"requestId": respMap["RequestId"],
						"hostId":    respMap["HostId"],
					},
				})
				return _result, _err
			}

			_result = &DeleteLiveChannelResponse{}
			_err = tea.Convert(response_.Headers, &_result)
			return _result, _err
		}()
		if !tea.BoolValue(tea.Retryable(_err)) {
			break
		}
	}

	return _resp, _err
}

func (client *Client) GetBucketLocation(request *GetBucketLocationRequest, runtime *ossutil.RuntimeOptions) (_result *GetBucketLocationResponse, _err error) {
	_err = tea.Validate(request)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Validate(runtime)
	if _err != nil {
		return _result, _err
	}
	_runtime := map[string]interface{}{
		"timeouted":      "retry",
		"readTimeout":    tea.IntValue(util.DefaultNumber(runtime.ReadTimeout, client.ReadTimeout)),
		"connectTimeout": tea.IntValue(util.DefaultNumber(runtime.ConnectTimeout, client.ConnectTimeout)),
		"localAddr":      tea.StringValue(util.DefaultString(runtime.LocalAddr, client.LocalAddr)),
		"httpProxy":      tea.StringValue(util.DefaultString(runtime.HttpProxy, client.HttpProxy)),
		"httpsProxy":     tea.StringValue(util.DefaultString(runtime.HttpsProxy, client.HttpsProxy)),
		"noProxy":        tea.StringValue(util.DefaultString(runtime.NoProxy, client.NoProxy)),
		"socks5Proxy":    tea.StringValue(util.DefaultString(runtime.Socks5Proxy, client.Socks5Proxy)),
		"socks5NetWork":  tea.StringValue(util.DefaultString(runtime.Socks5NetWork, client.Socks5NetWork)),
		"maxIdleConns":   tea.IntValue(util.DefaultNumber(runtime.MaxIdleConns, client.MaxIdleConns)),
		"retry": map[string]interface{}{
			"retryable":   tea.BoolValue(runtime.Autoretry),
			"maxAttempts": tea.IntValue(util.DefaultNumber(runtime.MaxAttempts, tea.Int(3))),
		},
		"backoff": map[string]interface{}{
			"policy": tea.StringValue(util.DefaultString(runtime.BackoffPolicy, tea.String("no"))),
			"period": tea.IntValue(util.DefaultNumber(runtime.BackoffPeriod, tea.Int(1))),
		},
		"ignoreSSL": tea.BoolValue(runtime.IgnoreSSL),
	}

	_resp := &GetBucketLocationResponse{}
	for _retryTimes := 0; tea.BoolValue(tea.AllowRetry(_runtime["retry"], tea.Int(_retryTimes))); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], tea.Int(_retryTimes))
			if tea.IntValue(_backoffTime) > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, _err = func() (*GetBucketLocationResponse, error) {
			request_ := tea.NewRequest()
			accessKeyId, _err := client.Credential.GetAccessKeyId()
			if _err != nil {
				return _result, _err
			}

			accessKeySecret, _err := client.Credential.GetAccessKeySecret()
			if _err != nil {
				return _result, _err
			}

			token, _err := client.Credential.GetSecurityToken()
			if _err != nil {
				return _result, _err
			}

			request_.Protocol = client.Protocol
			request_.Method = tea.String("GET")
			request_.Pathname = tea.String("/?location")
			request_.Headers = map[string]*string{
				"host":       ossutil.GetHost(request.BucketName, client.RegionId, client.Endpoint, client.HostModel),
				"date":       util.GetDateUTCString(),
				"user-agent": client.GetUserAgent(),
			}
			if !tea.BoolValue(util.Empty(token)) {
				request_.Headers["x-oss-security-token"] = token
			}

			request_.Headers["authorization"] = ossutil.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, client.SignatureVersion, client.AddtionalHeaders)
			response_, _err := tea.DoRequest(request_, _runtime)
			if _err != nil {
				return _result, _err
			}
			var respMap map[string]interface{}
			var bodyStr *string
			if tea.BoolValue(util.Is4xx(response_.StatusCode)) || tea.BoolValue(util.Is5xx(response_.StatusCode)) {
				bodyStr, _err = util.ReadAsString(response_.Body)
				if _err != nil {
					return _result, _err
				}

				respMap = ossutil.GetErrMessage(bodyStr)
				_err = tea.NewSDKError(map[string]interface{}{
					"code":    respMap["Code"],
					"message": respMap["Message"],
					"data": map[string]interface{}{
						"httpCode":  tea.IntValue(response_.StatusCode),
						"requestId": respMap["RequestId"],
						"hostId":    respMap["HostId"],
					},
				})
				return _result, _err
			}

			bodyStr, _err = util.ReadAsString(response_.Body)
			if _err != nil {
				return _result, _err
			}

			respMap = xml.ParseXml(bodyStr, new(GetBucketLocationResponse))
			_result = &GetBucketLocationResponse{}
			_err = tea.Convert(tea.ToMap(map[string]interface{}{
				"LocationConstraint": respMap["LocationConstraint"],
			}, response_.Headers), &_result)
			return _result, _err
		}()
		if !tea.BoolValue(tea.Retryable(_err)) {
			break
		}
	}

	return _resp, _err
}

func (client *Client) ListLiveChannel(request *ListLiveChannelRequest, runtime *ossutil.RuntimeOptions) (_result *ListLiveChannelResponse, _err error) {
	_err = tea.Validate(request)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Validate(runtime)
	if _err != nil {
		return _result, _err
	}
	_runtime := map[string]interface{}{
		"timeouted":      "retry",
		"readTimeout":    tea.IntValue(util.DefaultNumber(runtime.ReadTimeout, client.ReadTimeout)),
		"connectTimeout": tea.IntValue(util.DefaultNumber(runtime.ConnectTimeout, client.ConnectTimeout)),
		"localAddr":      tea.StringValue(util.DefaultString(runtime.LocalAddr, client.LocalAddr)),
		"httpProxy":      tea.StringValue(util.DefaultString(runtime.HttpProxy, client.HttpProxy)),
		"httpsProxy":     tea.StringValue(util.DefaultString(runtime.HttpsProxy, client.HttpsProxy)),
		"noProxy":        tea.StringValue(util.DefaultString(runtime.NoProxy, client.NoProxy)),
		"socks5Proxy":    tea.StringValue(util.DefaultString(runtime.Socks5Proxy, client.Socks5Proxy)),
		"socks5NetWork":  tea.StringValue(util.DefaultString(runtime.Socks5NetWork, client.Socks5NetWork)),
		"maxIdleConns":   tea.IntValue(util.DefaultNumber(runtime.MaxIdleConns, client.MaxIdleConns)),
		"retry": map[string]interface{}{
			"retryable":   tea.BoolValue(runtime.Autoretry),
			"maxAttempts": tea.IntValue(util.DefaultNumber(runtime.MaxAttempts, tea.Int(3))),
		},
		"backoff": map[string]interface{}{
			"policy": tea.StringValue(util.DefaultString(runtime.BackoffPolicy, tea.String("no"))),
			"period": tea.IntValue(util.DefaultNumber(runtime.BackoffPeriod, tea.Int(1))),
		},
		"ignoreSSL": tea.BoolValue(runtime.IgnoreSSL),
	}

	_resp := &ListLiveChannelResponse{}
	for _retryTimes := 0; tea.BoolValue(tea.AllowRetry(_runtime["retry"], tea.Int(_retryTimes))); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], tea.Int(_retryTimes))
			if tea.IntValue(_backoffTime) > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, _err = func() (*ListLiveChannelResponse, error) {
			request_ := tea.NewRequest()
			accessKeyId, _err := client.Credential.GetAccessKeyId()
			if _err != nil {
				return _result, _err
			}

			accessKeySecret, _err := client.Credential.GetAccessKeySecret()
			if _err != nil {
				return _result, _err
			}

			token, _err := client.Credential.GetSecurityToken()
			if _err != nil {
				return _result, _err
			}

			request_.Protocol = client.Protocol
			request_.Method = tea.String("GET")
			request_.Pathname = tea.String("/?live")
			request_.Headers = map[string]*string{
				"host":       ossutil.GetHost(request.BucketName, client.RegionId, client.Endpoint, client.HostModel),
				"date":       util.GetDateUTCString(),
				"user-agent": client.GetUserAgent(),
			}
			if !tea.BoolValue(util.Empty(token)) {
				request_.Headers["x-oss-security-token"] = token
			}

			request_.Query = util.StringifyMapValue(tea.ToMap(request.Filter))
			request_.Headers["authorization"] = ossutil.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, client.SignatureVersion, client.AddtionalHeaders)
			response_, _err := tea.DoRequest(request_, _runtime)
			if _err != nil {
				return _result, _err
			}
			var respMap map[string]interface{}
			var bodyStr *string
			if tea.BoolValue(util.Is4xx(response_.StatusCode)) || tea.BoolValue(util.Is5xx(response_.StatusCode)) {
				bodyStr, _err = util.ReadAsString(response_.Body)
				if _err != nil {
					return _result, _err
				}

				respMap = ossutil.GetErrMessage(bodyStr)
				_err = tea.NewSDKError(map[string]interface{}{
					"code":    respMap["Code"],
					"message": respMap["Message"],
					"data": map[string]interface{}{
						"httpCode":  tea.IntValue(response_.StatusCode),
						"requestId": respMap["RequestId"],
						"hostId":    respMap["HostId"],
					},
				})
				return _result, _err
			}

			bodyStr, _err = util.ReadAsString(response_.Body)
			if _err != nil {
				return _result, _err
			}

			respMap = xml.ParseXml(bodyStr, new(ListLiveChannelResponse))
			_result = &ListLiveChannelResponse{}
			_err = tea.Convert(tea.ToMap(map[string]interface{}{
				"ListLiveChannelResult": respMap["ListLiveChannelResult"],
			}, response_.Headers), &_result)
			return _result, _err
		}()
		if !tea.BoolValue(tea.Retryable(_err)) {
			break
		}
	}

	return _resp, _err
}

func (client *Client) GetObjectMeta(request *GetObjectMetaRequest, runtime *ossutil.RuntimeOptions) (_result *GetObjectMetaResponse, _err error) {
	_err = tea.Validate(request)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Validate(runtime)
	if _err != nil {
		return _result, _err
	}
	_runtime := map[string]interface{}{
		"timeouted":      "retry",
		"readTimeout":    tea.IntValue(util.DefaultNumber(runtime.ReadTimeout, client.ReadTimeout)),
		"connectTimeout": tea.IntValue(util.DefaultNumber(runtime.ConnectTimeout, client.ConnectTimeout)),
		"localAddr":      tea.StringValue(util.DefaultString(runtime.LocalAddr, client.LocalAddr)),
		"httpProxy":      tea.StringValue(util.DefaultString(runtime.HttpProxy, client.HttpProxy)),
		"httpsProxy":     tea.StringValue(util.DefaultString(runtime.HttpsProxy, client.HttpsProxy)),
		"noProxy":        tea.StringValue(util.DefaultString(runtime.NoProxy, client.NoProxy)),
		"socks5Proxy":    tea.StringValue(util.DefaultString(runtime.Socks5Proxy, client.Socks5Proxy)),
		"socks5NetWork":  tea.StringValue(util.DefaultString(runtime.Socks5NetWork, client.Socks5NetWork)),
		"maxIdleConns":   tea.IntValue(util.DefaultNumber(runtime.MaxIdleConns, client.MaxIdleConns)),
		"retry": map[string]interface{}{
			"retryable":   tea.BoolValue(runtime.Autoretry),
			"maxAttempts": tea.IntValue(util.DefaultNumber(runtime.MaxAttempts, tea.Int(3))),
		},
		"backoff": map[string]interface{}{
			"policy": tea.StringValue(util.DefaultString(runtime.BackoffPolicy, tea.String("no"))),
			"period": tea.IntValue(util.DefaultNumber(runtime.BackoffPeriod, tea.Int(1))),
		},
		"ignoreSSL": tea.BoolValue(runtime.IgnoreSSL),
	}

	_resp := &GetObjectMetaResponse{}
	for _retryTimes := 0; tea.BoolValue(tea.AllowRetry(_runtime["retry"], tea.Int(_retryTimes))); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], tea.Int(_retryTimes))
			if tea.IntValue(_backoffTime) > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, _err = func() (*GetObjectMetaResponse, error) {
			request_ := tea.NewRequest()
			accessKeyId, _err := client.Credential.GetAccessKeyId()
			if _err != nil {
				return _result, _err
			}

			accessKeySecret, _err := client.Credential.GetAccessKeySecret()
			if _err != nil {
				return _result, _err
			}

			token, _err := client.Credential.GetSecurityToken()
			if _err != nil {
				return _result, _err
			}

			request_.Protocol = client.Protocol
			request_.Method = tea.String("HEAD")
			request_.Pathname = tea.String("/" + tea.StringValue(request.ObjectName) + "?objectMeta")
			request_.Headers = map[string]*string{
				"host":       ossutil.GetHost(request.BucketName, client.RegionId, client.Endpoint, client.HostModel),
				"date":       util.GetDateUTCString(),
				"user-agent": client.GetUserAgent(),
			}
			if !tea.BoolValue(util.Empty(token)) {
				request_.Headers["x-oss-security-token"] = token
			}

			request_.Headers["authorization"] = ossutil.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, client.SignatureVersion, client.AddtionalHeaders)
			response_, _err := tea.DoRequest(request_, _runtime)
			if _err != nil {
				return _result, _err
			}
			var respMap map[string]interface{}
			var bodyStr *string
			if tea.BoolValue(util.Is4xx(response_.StatusCode)) || tea.BoolValue(util.Is5xx(response_.StatusCode)) {
				bodyStr, _err = util.ReadAsString(response_.Body)
				if _err != nil {
					return _result, _err
				}

				respMap = ossutil.GetErrMessage(bodyStr)
				_err = tea.NewSDKError(map[string]interface{}{
					"code":    respMap["Code"],
					"message": respMap["Message"],
					"data": map[string]interface{}{
						"httpCode":  tea.IntValue(response_.StatusCode),
						"requestId": respMap["RequestId"],
						"hostId":    respMap["HostId"],
					},
				})
				return _result, _err
			}

			_result = &GetObjectMetaResponse{}
			_err = tea.Convert(response_.Headers, &_result)
			return _result, _err
		}()
		if !tea.BoolValue(tea.Retryable(_err)) {
			break
		}
	}

	return _resp, _err
}

func (client *Client) GetBucketAcl(request *GetBucketAclRequest, runtime *ossutil.RuntimeOptions) (_result *GetBucketAclResponse, _err error) {
	_err = tea.Validate(request)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Validate(runtime)
	if _err != nil {
		return _result, _err
	}
	_runtime := map[string]interface{}{
		"timeouted":      "retry",
		"readTimeout":    tea.IntValue(util.DefaultNumber(runtime.ReadTimeout, client.ReadTimeout)),
		"connectTimeout": tea.IntValue(util.DefaultNumber(runtime.ConnectTimeout, client.ConnectTimeout)),
		"localAddr":      tea.StringValue(util.DefaultString(runtime.LocalAddr, client.LocalAddr)),
		"httpProxy":      tea.StringValue(util.DefaultString(runtime.HttpProxy, client.HttpProxy)),
		"httpsProxy":     tea.StringValue(util.DefaultString(runtime.HttpsProxy, client.HttpsProxy)),
		"noProxy":        tea.StringValue(util.DefaultString(runtime.NoProxy, client.NoProxy)),
		"socks5Proxy":    tea.StringValue(util.DefaultString(runtime.Socks5Proxy, client.Socks5Proxy)),
		"socks5NetWork":  tea.StringValue(util.DefaultString(runtime.Socks5NetWork, client.Socks5NetWork)),
		"maxIdleConns":   tea.IntValue(util.DefaultNumber(runtime.MaxIdleConns, client.MaxIdleConns)),
		"retry": map[string]interface{}{
			"retryable":   tea.BoolValue(runtime.Autoretry),
			"maxAttempts": tea.IntValue(util.DefaultNumber(runtime.MaxAttempts, tea.Int(3))),
		},
		"backoff": map[string]interface{}{
			"policy": tea.StringValue(util.DefaultString(runtime.BackoffPolicy, tea.String("no"))),
			"period": tea.IntValue(util.DefaultNumber(runtime.BackoffPeriod, tea.Int(1))),
		},
		"ignoreSSL": tea.BoolValue(runtime.IgnoreSSL),
	}

	_resp := &GetBucketAclResponse{}
	for _retryTimes := 0; tea.BoolValue(tea.AllowRetry(_runtime["retry"], tea.Int(_retryTimes))); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], tea.Int(_retryTimes))
			if tea.IntValue(_backoffTime) > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, _err = func() (*GetBucketAclResponse, error) {
			request_ := tea.NewRequest()
			accessKeyId, _err := client.Credential.GetAccessKeyId()
			if _err != nil {
				return _result, _err
			}

			accessKeySecret, _err := client.Credential.GetAccessKeySecret()
			if _err != nil {
				return _result, _err
			}

			token, _err := client.Credential.GetSecurityToken()
			if _err != nil {
				return _result, _err
			}

			request_.Protocol = client.Protocol
			request_.Method = tea.String("GET")
			request_.Pathname = tea.String("/?acl")
			request_.Headers = map[string]*string{
				"host":       ossutil.GetHost(request.BucketName, client.RegionId, client.Endpoint, client.HostModel),
				"date":       util.GetDateUTCString(),
				"user-agent": client.GetUserAgent(),
			}
			if !tea.BoolValue(util.Empty(token)) {
				request_.Headers["x-oss-security-token"] = token
			}

			request_.Headers["authorization"] = ossutil.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, client.SignatureVersion, client.AddtionalHeaders)
			response_, _err := tea.DoRequest(request_, _runtime)
			if _err != nil {
				return _result, _err
			}
			var respMap map[string]interface{}
			var bodyStr *string
			if tea.BoolValue(util.Is4xx(response_.StatusCode)) || tea.BoolValue(util.Is5xx(response_.StatusCode)) {
				bodyStr, _err = util.ReadAsString(response_.Body)
				if _err != nil {
					return _result, _err
				}

				respMap = ossutil.GetErrMessage(bodyStr)
				_err = tea.NewSDKError(map[string]interface{}{
					"code":    respMap["Code"],
					"message": respMap["Message"],
					"data": map[string]interface{}{
						"httpCode":  tea.IntValue(response_.StatusCode),
						"requestId": respMap["RequestId"],
						"hostId":    respMap["HostId"],
					},
				})
				return _result, _err
			}

			bodyStr, _err = util.ReadAsString(response_.Body)
			if _err != nil {
				return _result, _err
			}

			respMap = xml.ParseXml(bodyStr, new(GetBucketAclResponse))
			_result = &GetBucketAclResponse{}
			_err = tea.Convert(tea.ToMap(map[string]interface{}{
				"AccessControlPolicy": respMap["AccessControlPolicy"],
			}, response_.Headers), &_result)
			return _result, _err
		}()
		if !tea.BoolValue(tea.Retryable(_err)) {
			break
		}
	}

	return _resp, _err
}

func (client *Client) ListParts(request *ListPartsRequest, runtime *ossutil.RuntimeOptions) (_result *ListPartsResponse, _err error) {
	_err = tea.Validate(request)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Validate(runtime)
	if _err != nil {
		return _result, _err
	}
	_runtime := map[string]interface{}{
		"timeouted":      "retry",
		"readTimeout":    tea.IntValue(util.DefaultNumber(runtime.ReadTimeout, client.ReadTimeout)),
		"connectTimeout": tea.IntValue(util.DefaultNumber(runtime.ConnectTimeout, client.ConnectTimeout)),
		"localAddr":      tea.StringValue(util.DefaultString(runtime.LocalAddr, client.LocalAddr)),
		"httpProxy":      tea.StringValue(util.DefaultString(runtime.HttpProxy, client.HttpProxy)),
		"httpsProxy":     tea.StringValue(util.DefaultString(runtime.HttpsProxy, client.HttpsProxy)),
		"noProxy":        tea.StringValue(util.DefaultString(runtime.NoProxy, client.NoProxy)),
		"socks5Proxy":    tea.StringValue(util.DefaultString(runtime.Socks5Proxy, client.Socks5Proxy)),
		"socks5NetWork":  tea.StringValue(util.DefaultString(runtime.Socks5NetWork, client.Socks5NetWork)),
		"maxIdleConns":   tea.IntValue(util.DefaultNumber(runtime.MaxIdleConns, client.MaxIdleConns)),
		"retry": map[string]interface{}{
			"retryable":   tea.BoolValue(runtime.Autoretry),
			"maxAttempts": tea.IntValue(util.DefaultNumber(runtime.MaxAttempts, tea.Int(3))),
		},
		"backoff": map[string]interface{}{
			"policy": tea.StringValue(util.DefaultString(runtime.BackoffPolicy, tea.String("no"))),
			"period": tea.IntValue(util.DefaultNumber(runtime.BackoffPeriod, tea.Int(1))),
		},
		"ignoreSSL": tea.BoolValue(runtime.IgnoreSSL),
	}

	_resp := &ListPartsResponse{}
	for _retryTimes := 0; tea.BoolValue(tea.AllowRetry(_runtime["retry"], tea.Int(_retryTimes))); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], tea.Int(_retryTimes))
			if tea.IntValue(_backoffTime) > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, _err = func() (*ListPartsResponse, error) {
			request_ := tea.NewRequest()
			accessKeyId, _err := client.Credential.GetAccessKeyId()
			if _err != nil {
				return _result, _err
			}

			accessKeySecret, _err := client.Credential.GetAccessKeySecret()
			if _err != nil {
				return _result, _err
			}

			token, _err := client.Credential.GetSecurityToken()
			if _err != nil {
				return _result, _err
			}

			request_.Protocol = client.Protocol
			request_.Method = tea.String("GET")
			request_.Pathname = tea.String("/" + tea.StringValue(request.ObjectName))
			request_.Headers = map[string]*string{
				"host":       ossutil.GetHost(request.BucketName, client.RegionId, client.Endpoint, client.HostModel),
				"date":       util.GetDateUTCString(),
				"user-agent": client.GetUserAgent(),
			}
			if !tea.BoolValue(util.Empty(token)) {
				request_.Headers["x-oss-security-token"] = token
			}

			request_.Query = util.StringifyMapValue(tea.ToMap(request.Filter))
			request_.Headers["authorization"] = ossutil.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, client.SignatureVersion, client.AddtionalHeaders)
			response_, _err := tea.DoRequest(request_, _runtime)
			if _err != nil {
				return _result, _err
			}
			var respMap map[string]interface{}
			var bodyStr *string
			if tea.BoolValue(util.Is4xx(response_.StatusCode)) || tea.BoolValue(util.Is5xx(response_.StatusCode)) {
				bodyStr, _err = util.ReadAsString(response_.Body)
				if _err != nil {
					return _result, _err
				}

				respMap = ossutil.GetErrMessage(bodyStr)
				_err = tea.NewSDKError(map[string]interface{}{
					"code":    respMap["Code"],
					"message": respMap["Message"],
					"data": map[string]interface{}{
						"httpCode":  tea.IntValue(response_.StatusCode),
						"requestId": respMap["RequestId"],
						"hostId":    respMap["HostId"],
					},
				})
				return _result, _err
			}

			bodyStr, _err = util.ReadAsString(response_.Body)
			if _err != nil {
				return _result, _err
			}

			respMap = xml.ParseXml(bodyStr, new(ListPartsResponse))
			_result = &ListPartsResponse{}
			_err = tea.Convert(tea.ToMap(map[string]interface{}{
				"ListPartsResult": respMap["ListPartsResult"],
			}, response_.Headers), &_result)
			return _result, _err
		}()
		if !tea.BoolValue(tea.Retryable(_err)) {
			break
		}
	}

	return _resp, _err
}

func (client *Client) GetLiveChannelHistory(request *GetLiveChannelHistoryRequest, runtime *ossutil.RuntimeOptions) (_result *GetLiveChannelHistoryResponse, _err error) {
	_err = tea.Validate(request)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Validate(runtime)
	if _err != nil {
		return _result, _err
	}
	_runtime := map[string]interface{}{
		"timeouted":      "retry",
		"readTimeout":    tea.IntValue(util.DefaultNumber(runtime.ReadTimeout, client.ReadTimeout)),
		"connectTimeout": tea.IntValue(util.DefaultNumber(runtime.ConnectTimeout, client.ConnectTimeout)),
		"localAddr":      tea.StringValue(util.DefaultString(runtime.LocalAddr, client.LocalAddr)),
		"httpProxy":      tea.StringValue(util.DefaultString(runtime.HttpProxy, client.HttpProxy)),
		"httpsProxy":     tea.StringValue(util.DefaultString(runtime.HttpsProxy, client.HttpsProxy)),
		"noProxy":        tea.StringValue(util.DefaultString(runtime.NoProxy, client.NoProxy)),
		"socks5Proxy":    tea.StringValue(util.DefaultString(runtime.Socks5Proxy, client.Socks5Proxy)),
		"socks5NetWork":  tea.StringValue(util.DefaultString(runtime.Socks5NetWork, client.Socks5NetWork)),
		"maxIdleConns":   tea.IntValue(util.DefaultNumber(runtime.MaxIdleConns, client.MaxIdleConns)),
		"retry": map[string]interface{}{
			"retryable":   tea.BoolValue(runtime.Autoretry),
			"maxAttempts": tea.IntValue(util.DefaultNumber(runtime.MaxAttempts, tea.Int(3))),
		},
		"backoff": map[string]interface{}{
			"policy": tea.StringValue(util.DefaultString(runtime.BackoffPolicy, tea.String("no"))),
			"period": tea.IntValue(util.DefaultNumber(runtime.BackoffPeriod, tea.Int(1))),
		},
		"ignoreSSL": tea.BoolValue(runtime.IgnoreSSL),
	}

	_resp := &GetLiveChannelHistoryResponse{}
	for _retryTimes := 0; tea.BoolValue(tea.AllowRetry(_runtime["retry"], tea.Int(_retryTimes))); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], tea.Int(_retryTimes))
			if tea.IntValue(_backoffTime) > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, _err = func() (*GetLiveChannelHistoryResponse, error) {
			request_ := tea.NewRequest()
			accessKeyId, _err := client.Credential.GetAccessKeyId()
			if _err != nil {
				return _result, _err
			}

			accessKeySecret, _err := client.Credential.GetAccessKeySecret()
			if _err != nil {
				return _result, _err
			}

			token, _err := client.Credential.GetSecurityToken()
			if _err != nil {
				return _result, _err
			}

			request_.Protocol = client.Protocol
			request_.Method = tea.String("GET")
			request_.Pathname = tea.String("/" + tea.StringValue(request.ChannelName) + "?live")
			request_.Headers = map[string]*string{
				"host":       ossutil.GetHost(request.BucketName, client.RegionId, client.Endpoint, client.HostModel),
				"date":       util.GetDateUTCString(),
				"user-agent": client.GetUserAgent(),
			}
			if !tea.BoolValue(util.Empty(token)) {
				request_.Headers["x-oss-security-token"] = token
			}

			request_.Query = util.StringifyMapValue(tea.ToMap(request.Filter))
			request_.Headers["authorization"] = ossutil.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, client.SignatureVersion, client.AddtionalHeaders)
			response_, _err := tea.DoRequest(request_, _runtime)
			if _err != nil {
				return _result, _err
			}
			var respMap map[string]interface{}
			var bodyStr *string
			if tea.BoolValue(util.Is4xx(response_.StatusCode)) || tea.BoolValue(util.Is5xx(response_.StatusCode)) {
				bodyStr, _err = util.ReadAsString(response_.Body)
				if _err != nil {
					return _result, _err
				}

				respMap = ossutil.GetErrMessage(bodyStr)
				_err = tea.NewSDKError(map[string]interface{}{
					"code":    respMap["Code"],
					"message": respMap["Message"],
					"data": map[string]interface{}{
						"httpCode":  tea.IntValue(response_.StatusCode),
						"requestId": respMap["RequestId"],
						"hostId":    respMap["HostId"],
					},
				})
				return _result, _err
			}

			bodyStr, _err = util.ReadAsString(response_.Body)
			if _err != nil {
				return _result, _err
			}

			respMap = xml.ParseXml(bodyStr, new(GetLiveChannelHistoryResponse))
			_result = &GetLiveChannelHistoryResponse{}
			_err = tea.Convert(tea.ToMap(map[string]interface{}{
				"LiveChannelHistory": respMap["LiveChannelHistory"],
			}, response_.Headers), &_result)
			return _result, _err
		}()
		if !tea.BoolValue(tea.Retryable(_err)) {
			break
		}
	}

	return _resp, _err
}

func (client *Client) GetBucket(request *GetBucketRequest, runtime *ossutil.RuntimeOptions) (_result *GetBucketResponse, _err error) {
	_err = tea.Validate(request)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Validate(runtime)
	if _err != nil {
		return _result, _err
	}
	_runtime := map[string]interface{}{
		"timeouted":      "retry",
		"readTimeout":    tea.IntValue(util.DefaultNumber(runtime.ReadTimeout, client.ReadTimeout)),
		"connectTimeout": tea.IntValue(util.DefaultNumber(runtime.ConnectTimeout, client.ConnectTimeout)),
		"localAddr":      tea.StringValue(util.DefaultString(runtime.LocalAddr, client.LocalAddr)),
		"httpProxy":      tea.StringValue(util.DefaultString(runtime.HttpProxy, client.HttpProxy)),
		"httpsProxy":     tea.StringValue(util.DefaultString(runtime.HttpsProxy, client.HttpsProxy)),
		"noProxy":        tea.StringValue(util.DefaultString(runtime.NoProxy, client.NoProxy)),
		"socks5Proxy":    tea.StringValue(util.DefaultString(runtime.Socks5Proxy, client.Socks5Proxy)),
		"socks5NetWork":  tea.StringValue(util.DefaultString(runtime.Socks5NetWork, client.Socks5NetWork)),
		"maxIdleConns":   tea.IntValue(util.DefaultNumber(runtime.MaxIdleConns, client.MaxIdleConns)),
		"retry": map[string]interface{}{
			"retryable":   tea.BoolValue(runtime.Autoretry),
			"maxAttempts": tea.IntValue(util.DefaultNumber(runtime.MaxAttempts, tea.Int(3))),
		},
		"backoff": map[string]interface{}{
			"policy": tea.StringValue(util.DefaultString(runtime.BackoffPolicy, tea.String("no"))),
			"period": tea.IntValue(util.DefaultNumber(runtime.BackoffPeriod, tea.Int(1))),
		},
		"ignoreSSL": tea.BoolValue(runtime.IgnoreSSL),
	}

	_resp := &GetBucketResponse{}
	for _retryTimes := 0; tea.BoolValue(tea.AllowRetry(_runtime["retry"], tea.Int(_retryTimes))); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], tea.Int(_retryTimes))
			if tea.IntValue(_backoffTime) > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, _err = func() (*GetBucketResponse, error) {
			request_ := tea.NewRequest()
			accessKeyId, _err := client.Credential.GetAccessKeyId()
			if _err != nil {
				return _result, _err
			}

			accessKeySecret, _err := client.Credential.GetAccessKeySecret()
			if _err != nil {
				return _result, _err
			}

			token, _err := client.Credential.GetSecurityToken()
			if _err != nil {
				return _result, _err
			}

			request_.Protocol = client.Protocol
			request_.Method = tea.String("GET")
			request_.Pathname = tea.String("/")
			request_.Headers = map[string]*string{
				"host":       ossutil.GetHost(request.BucketName, client.RegionId, client.Endpoint, client.HostModel),
				"date":       util.GetDateUTCString(),
				"user-agent": client.GetUserAgent(),
			}
			if !tea.BoolValue(util.Empty(token)) {
				request_.Headers["x-oss-security-token"] = token
			}

			request_.Query = util.StringifyMapValue(tea.ToMap(request.Filter))
			request_.Headers["authorization"] = ossutil.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, client.SignatureVersion, client.AddtionalHeaders)
			response_, _err := tea.DoRequest(request_, _runtime)
			if _err != nil {
				return _result, _err
			}
			var respMap map[string]interface{}
			var bodyStr *string
			if tea.BoolValue(util.Is4xx(response_.StatusCode)) || tea.BoolValue(util.Is5xx(response_.StatusCode)) {
				bodyStr, _err = util.ReadAsString(response_.Body)
				if _err != nil {
					return _result, _err
				}

				respMap = ossutil.GetErrMessage(bodyStr)
				_err = tea.NewSDKError(map[string]interface{}{
					"code":    respMap["Code"],
					"message": respMap["Message"],
					"data": map[string]interface{}{
						"httpCode":  tea.IntValue(response_.StatusCode),
						"requestId": respMap["RequestId"],
						"hostId":    respMap["HostId"],
					},
				})
				return _result, _err
			}

			bodyStr, _err = util.ReadAsString(response_.Body)
			if _err != nil {
				return _result, _err
			}

			respMap = xml.ParseXml(bodyStr, new(GetBucketResponse))
			_result = &GetBucketResponse{}
			_err = tea.Convert(tea.ToMap(map[string]interface{}{
				"ListBucketResult": respMap["ListBucketResult"],
			}, response_.Headers), &_result)
			return _result, _err
		}()
		if !tea.BoolValue(tea.Retryable(_err)) {
			break
		}
	}

	return _resp, _err
}

func (client *Client) GetLiveChannelInfo(request *GetLiveChannelInfoRequest, runtime *ossutil.RuntimeOptions) (_result *GetLiveChannelInfoResponse, _err error) {
	_err = tea.Validate(request)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Validate(runtime)
	if _err != nil {
		return _result, _err
	}
	_runtime := map[string]interface{}{
		"timeouted":      "retry",
		"readTimeout":    tea.IntValue(util.DefaultNumber(runtime.ReadTimeout, client.ReadTimeout)),
		"connectTimeout": tea.IntValue(util.DefaultNumber(runtime.ConnectTimeout, client.ConnectTimeout)),
		"localAddr":      tea.StringValue(util.DefaultString(runtime.LocalAddr, client.LocalAddr)),
		"httpProxy":      tea.StringValue(util.DefaultString(runtime.HttpProxy, client.HttpProxy)),
		"httpsProxy":     tea.StringValue(util.DefaultString(runtime.HttpsProxy, client.HttpsProxy)),
		"noProxy":        tea.StringValue(util.DefaultString(runtime.NoProxy, client.NoProxy)),
		"socks5Proxy":    tea.StringValue(util.DefaultString(runtime.Socks5Proxy, client.Socks5Proxy)),
		"socks5NetWork":  tea.StringValue(util.DefaultString(runtime.Socks5NetWork, client.Socks5NetWork)),
		"maxIdleConns":   tea.IntValue(util.DefaultNumber(runtime.MaxIdleConns, client.MaxIdleConns)),
		"retry": map[string]interface{}{
			"retryable":   tea.BoolValue(runtime.Autoretry),
			"maxAttempts": tea.IntValue(util.DefaultNumber(runtime.MaxAttempts, tea.Int(3))),
		},
		"backoff": map[string]interface{}{
			"policy": tea.StringValue(util.DefaultString(runtime.BackoffPolicy, tea.String("no"))),
			"period": tea.IntValue(util.DefaultNumber(runtime.BackoffPeriod, tea.Int(1))),
		},
		"ignoreSSL": tea.BoolValue(runtime.IgnoreSSL),
	}

	_resp := &GetLiveChannelInfoResponse{}
	for _retryTimes := 0; tea.BoolValue(tea.AllowRetry(_runtime["retry"], tea.Int(_retryTimes))); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], tea.Int(_retryTimes))
			if tea.IntValue(_backoffTime) > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, _err = func() (*GetLiveChannelInfoResponse, error) {
			request_ := tea.NewRequest()
			accessKeyId, _err := client.Credential.GetAccessKeyId()
			if _err != nil {
				return _result, _err
			}

			accessKeySecret, _err := client.Credential.GetAccessKeySecret()
			if _err != nil {
				return _result, _err
			}

			token, _err := client.Credential.GetSecurityToken()
			if _err != nil {
				return _result, _err
			}

			request_.Protocol = client.Protocol
			request_.Method = tea.String("GET")
			request_.Pathname = tea.String("/" + tea.StringValue(request.ChannelName) + "?live")
			request_.Headers = map[string]*string{
				"host":       ossutil.GetHost(request.BucketName, client.RegionId, client.Endpoint, client.HostModel),
				"date":       util.GetDateUTCString(),
				"user-agent": client.GetUserAgent(),
			}
			if !tea.BoolValue(util.Empty(token)) {
				request_.Headers["x-oss-security-token"] = token
			}

			request_.Headers["authorization"] = ossutil.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, client.SignatureVersion, client.AddtionalHeaders)
			response_, _err := tea.DoRequest(request_, _runtime)
			if _err != nil {
				return _result, _err
			}
			var respMap map[string]interface{}
			var bodyStr *string
			if tea.BoolValue(util.Is4xx(response_.StatusCode)) || tea.BoolValue(util.Is5xx(response_.StatusCode)) {
				bodyStr, _err = util.ReadAsString(response_.Body)
				if _err != nil {
					return _result, _err
				}

				respMap = ossutil.GetErrMessage(bodyStr)
				_err = tea.NewSDKError(map[string]interface{}{
					"code":    respMap["Code"],
					"message": respMap["Message"],
					"data": map[string]interface{}{
						"httpCode":  tea.IntValue(response_.StatusCode),
						"requestId": respMap["RequestId"],
						"hostId":    respMap["HostId"],
					},
				})
				return _result, _err
			}

			bodyStr, _err = util.ReadAsString(response_.Body)
			if _err != nil {
				return _result, _err
			}

			respMap = xml.ParseXml(bodyStr, new(GetLiveChannelInfoResponse))
			_result = &GetLiveChannelInfoResponse{}
			_err = tea.Convert(tea.ToMap(map[string]interface{}{
				"LiveChannelConfiguration": respMap["LiveChannelConfiguration"],
			}, response_.Headers), &_result)
			return _result, _err
		}()
		if !tea.BoolValue(tea.Retryable(_err)) {
			break
		}
	}

	return _resp, _err
}

func (client *Client) GetLiveChannelStat(request *GetLiveChannelStatRequest, runtime *ossutil.RuntimeOptions) (_result *GetLiveChannelStatResponse, _err error) {
	_err = tea.Validate(request)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Validate(runtime)
	if _err != nil {
		return _result, _err
	}
	_runtime := map[string]interface{}{
		"timeouted":      "retry",
		"readTimeout":    tea.IntValue(util.DefaultNumber(runtime.ReadTimeout, client.ReadTimeout)),
		"connectTimeout": tea.IntValue(util.DefaultNumber(runtime.ConnectTimeout, client.ConnectTimeout)),
		"localAddr":      tea.StringValue(util.DefaultString(runtime.LocalAddr, client.LocalAddr)),
		"httpProxy":      tea.StringValue(util.DefaultString(runtime.HttpProxy, client.HttpProxy)),
		"httpsProxy":     tea.StringValue(util.DefaultString(runtime.HttpsProxy, client.HttpsProxy)),
		"noProxy":        tea.StringValue(util.DefaultString(runtime.NoProxy, client.NoProxy)),
		"socks5Proxy":    tea.StringValue(util.DefaultString(runtime.Socks5Proxy, client.Socks5Proxy)),
		"socks5NetWork":  tea.StringValue(util.DefaultString(runtime.Socks5NetWork, client.Socks5NetWork)),
		"maxIdleConns":   tea.IntValue(util.DefaultNumber(runtime.MaxIdleConns, client.MaxIdleConns)),
		"retry": map[string]interface{}{
			"retryable":   tea.BoolValue(runtime.Autoretry),
			"maxAttempts": tea.IntValue(util.DefaultNumber(runtime.MaxAttempts, tea.Int(3))),
		},
		"backoff": map[string]interface{}{
			"policy": tea.StringValue(util.DefaultString(runtime.BackoffPolicy, tea.String("no"))),
			"period": tea.IntValue(util.DefaultNumber(runtime.BackoffPeriod, tea.Int(1))),
		},
		"ignoreSSL": tea.BoolValue(runtime.IgnoreSSL),
	}

	_resp := &GetLiveChannelStatResponse{}
	for _retryTimes := 0; tea.BoolValue(tea.AllowRetry(_runtime["retry"], tea.Int(_retryTimes))); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], tea.Int(_retryTimes))
			if tea.IntValue(_backoffTime) > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, _err = func() (*GetLiveChannelStatResponse, error) {
			request_ := tea.NewRequest()
			accessKeyId, _err := client.Credential.GetAccessKeyId()
			if _err != nil {
				return _result, _err
			}

			accessKeySecret, _err := client.Credential.GetAccessKeySecret()
			if _err != nil {
				return _result, _err
			}

			token, _err := client.Credential.GetSecurityToken()
			if _err != nil {
				return _result, _err
			}

			request_.Protocol = client.Protocol
			request_.Method = tea.String("GET")
			request_.Pathname = tea.String("/" + tea.StringValue(request.ChannelName) + "?live")
			request_.Headers = map[string]*string{
				"host":       ossutil.GetHost(request.BucketName, client.RegionId, client.Endpoint, client.HostModel),
				"date":       util.GetDateUTCString(),
				"user-agent": client.GetUserAgent(),
			}
			if !tea.BoolValue(util.Empty(token)) {
				request_.Headers["x-oss-security-token"] = token
			}

			request_.Query = util.StringifyMapValue(tea.ToMap(request.Filter))
			request_.Headers["authorization"] = ossutil.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, client.SignatureVersion, client.AddtionalHeaders)
			response_, _err := tea.DoRequest(request_, _runtime)
			if _err != nil {
				return _result, _err
			}
			var respMap map[string]interface{}
			var bodyStr *string
			if tea.BoolValue(util.Is4xx(response_.StatusCode)) || tea.BoolValue(util.Is5xx(response_.StatusCode)) {
				bodyStr, _err = util.ReadAsString(response_.Body)
				if _err != nil {
					return _result, _err
				}

				respMap = ossutil.GetErrMessage(bodyStr)
				_err = tea.NewSDKError(map[string]interface{}{
					"code":    respMap["Code"],
					"message": respMap["Message"],
					"data": map[string]interface{}{
						"httpCode":  tea.IntValue(response_.StatusCode),
						"requestId": respMap["RequestId"],
						"hostId":    respMap["HostId"],
					},
				})
				return _result, _err
			}

			bodyStr, _err = util.ReadAsString(response_.Body)
			if _err != nil {
				return _result, _err
			}

			respMap = xml.ParseXml(bodyStr, new(GetLiveChannelStatResponse))
			_result = &GetLiveChannelStatResponse{}
			_err = tea.Convert(tea.ToMap(map[string]interface{}{
				"LiveChannelStat": respMap["LiveChannelStat"],
			}, response_.Headers), &_result)
			return _result, _err
		}()
		if !tea.BoolValue(tea.Retryable(_err)) {
			break
		}
	}

	return _resp, _err
}

func (client *Client) DeleteObject(request *DeleteObjectRequest, runtime *ossutil.RuntimeOptions) (_result *DeleteObjectResponse, _err error) {
	_err = tea.Validate(request)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Validate(runtime)
	if _err != nil {
		return _result, _err
	}
	_runtime := map[string]interface{}{
		"timeouted":      "retry",
		"readTimeout":    tea.IntValue(util.DefaultNumber(runtime.ReadTimeout, client.ReadTimeout)),
		"connectTimeout": tea.IntValue(util.DefaultNumber(runtime.ConnectTimeout, client.ConnectTimeout)),
		"localAddr":      tea.StringValue(util.DefaultString(runtime.LocalAddr, client.LocalAddr)),
		"httpProxy":      tea.StringValue(util.DefaultString(runtime.HttpProxy, client.HttpProxy)),
		"httpsProxy":     tea.StringValue(util.DefaultString(runtime.HttpsProxy, client.HttpsProxy)),
		"noProxy":        tea.StringValue(util.DefaultString(runtime.NoProxy, client.NoProxy)),
		"socks5Proxy":    tea.StringValue(util.DefaultString(runtime.Socks5Proxy, client.Socks5Proxy)),
		"socks5NetWork":  tea.StringValue(util.DefaultString(runtime.Socks5NetWork, client.Socks5NetWork)),
		"maxIdleConns":   tea.IntValue(util.DefaultNumber(runtime.MaxIdleConns, client.MaxIdleConns)),
		"retry": map[string]interface{}{
			"retryable":   tea.BoolValue(runtime.Autoretry),
			"maxAttempts": tea.IntValue(util.DefaultNumber(runtime.MaxAttempts, tea.Int(3))),
		},
		"backoff": map[string]interface{}{
			"policy": tea.StringValue(util.DefaultString(runtime.BackoffPolicy, tea.String("no"))),
			"period": tea.IntValue(util.DefaultNumber(runtime.BackoffPeriod, tea.Int(1))),
		},
		"ignoreSSL": tea.BoolValue(runtime.IgnoreSSL),
	}

	_resp := &DeleteObjectResponse{}
	for _retryTimes := 0; tea.BoolValue(tea.AllowRetry(_runtime["retry"], tea.Int(_retryTimes))); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], tea.Int(_retryTimes))
			if tea.IntValue(_backoffTime) > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, _err = func() (*DeleteObjectResponse, error) {
			request_ := tea.NewRequest()
			accessKeyId, _err := client.Credential.GetAccessKeyId()
			if _err != nil {
				return _result, _err
			}

			accessKeySecret, _err := client.Credential.GetAccessKeySecret()
			if _err != nil {
				return _result, _err
			}

			token, _err := client.Credential.GetSecurityToken()
			if _err != nil {
				return _result, _err
			}

			request_.Protocol = client.Protocol
			request_.Method = tea.String("DELETE")
			request_.Pathname = tea.String("/" + tea.StringValue(request.ObjectName))
			request_.Headers = map[string]*string{
				"host":       ossutil.GetHost(request.BucketName, client.RegionId, client.Endpoint, client.HostModel),
				"date":       util.GetDateUTCString(),
				"user-agent": client.GetUserAgent(),
			}
			if !tea.BoolValue(util.Empty(token)) {
				request_.Headers["x-oss-security-token"] = token
			}

			request_.Headers["authorization"] = ossutil.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, client.SignatureVersion, client.AddtionalHeaders)
			response_, _err := tea.DoRequest(request_, _runtime)
			if _err != nil {
				return _result, _err
			}
			var respMap map[string]interface{}
			var bodyStr *string
			if tea.BoolValue(util.Is4xx(response_.StatusCode)) || tea.BoolValue(util.Is5xx(response_.StatusCode)) {
				bodyStr, _err = util.ReadAsString(response_.Body)
				if _err != nil {
					return _result, _err
				}

				respMap = ossutil.GetErrMessage(bodyStr)
				_err = tea.NewSDKError(map[string]interface{}{
					"code":    respMap["Code"],
					"message": respMap["Message"],
					"data": map[string]interface{}{
						"httpCode":  tea.IntValue(response_.StatusCode),
						"requestId": respMap["RequestId"],
						"hostId":    respMap["HostId"],
					},
				})
				return _result, _err
			}

			_result = &DeleteObjectResponse{}
			_err = tea.Convert(response_.Headers, &_result)
			return _result, _err
		}()
		if !tea.BoolValue(tea.Retryable(_err)) {
			break
		}
	}

	return _resp, _err
}

func (client *Client) AbortMultipartUpload(request *AbortMultipartUploadRequest, runtime *ossutil.RuntimeOptions) (_result *AbortMultipartUploadResponse, _err error) {
	_err = tea.Validate(request)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Validate(runtime)
	if _err != nil {
		return _result, _err
	}
	_runtime := map[string]interface{}{
		"timeouted":      "retry",
		"readTimeout":    tea.IntValue(util.DefaultNumber(runtime.ReadTimeout, client.ReadTimeout)),
		"connectTimeout": tea.IntValue(util.DefaultNumber(runtime.ConnectTimeout, client.ConnectTimeout)),
		"localAddr":      tea.StringValue(util.DefaultString(runtime.LocalAddr, client.LocalAddr)),
		"httpProxy":      tea.StringValue(util.DefaultString(runtime.HttpProxy, client.HttpProxy)),
		"httpsProxy":     tea.StringValue(util.DefaultString(runtime.HttpsProxy, client.HttpsProxy)),
		"noProxy":        tea.StringValue(util.DefaultString(runtime.NoProxy, client.NoProxy)),
		"socks5Proxy":    tea.StringValue(util.DefaultString(runtime.Socks5Proxy, client.Socks5Proxy)),
		"socks5NetWork":  tea.StringValue(util.DefaultString(runtime.Socks5NetWork, client.Socks5NetWork)),
		"maxIdleConns":   tea.IntValue(util.DefaultNumber(runtime.MaxIdleConns, client.MaxIdleConns)),
		"retry": map[string]interface{}{
			"retryable":   tea.BoolValue(runtime.Autoretry),
			"maxAttempts": tea.IntValue(util.DefaultNumber(runtime.MaxAttempts, tea.Int(3))),
		},
		"backoff": map[string]interface{}{
			"policy": tea.StringValue(util.DefaultString(runtime.BackoffPolicy, tea.String("no"))),
			"period": tea.IntValue(util.DefaultNumber(runtime.BackoffPeriod, tea.Int(1))),
		},
		"ignoreSSL": tea.BoolValue(runtime.IgnoreSSL),
	}

	_resp := &AbortMultipartUploadResponse{}
	for _retryTimes := 0; tea.BoolValue(tea.AllowRetry(_runtime["retry"], tea.Int(_retryTimes))); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], tea.Int(_retryTimes))
			if tea.IntValue(_backoffTime) > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, _err = func() (*AbortMultipartUploadResponse, error) {
			request_ := tea.NewRequest()
			accessKeyId, _err := client.Credential.GetAccessKeyId()
			if _err != nil {
				return _result, _err
			}

			accessKeySecret, _err := client.Credential.GetAccessKeySecret()
			if _err != nil {
				return _result, _err
			}

			token, _err := client.Credential.GetSecurityToken()
			if _err != nil {
				return _result, _err
			}

			request_.Protocol = client.Protocol
			request_.Method = tea.String("DELETE")
			request_.Pathname = tea.String("/" + tea.StringValue(request.ObjectName))
			request_.Headers = map[string]*string{
				"host":       ossutil.GetHost(request.BucketName, client.RegionId, client.Endpoint, client.HostModel),
				"date":       util.GetDateUTCString(),
				"user-agent": client.GetUserAgent(),
			}
			if !tea.BoolValue(util.Empty(token)) {
				request_.Headers["x-oss-security-token"] = token
			}

			request_.Query = util.StringifyMapValue(tea.ToMap(request.Filter))
			request_.Headers["authorization"] = ossutil.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, client.SignatureVersion, client.AddtionalHeaders)
			response_, _err := tea.DoRequest(request_, _runtime)
			if _err != nil {
				return _result, _err
			}
			var respMap map[string]interface{}
			var bodyStr *string
			if tea.BoolValue(util.Is4xx(response_.StatusCode)) || tea.BoolValue(util.Is5xx(response_.StatusCode)) {
				bodyStr, _err = util.ReadAsString(response_.Body)
				if _err != nil {
					return _result, _err
				}

				respMap = ossutil.GetErrMessage(bodyStr)
				_err = tea.NewSDKError(map[string]interface{}{
					"code":    respMap["Code"],
					"message": respMap["Message"],
					"data": map[string]interface{}{
						"httpCode":  tea.IntValue(response_.StatusCode),
						"requestId": respMap["RequestId"],
						"hostId":    respMap["HostId"],
					},
				})
				return _result, _err
			}

			_result = &AbortMultipartUploadResponse{}
			_err = tea.Convert(response_.Headers, &_result)
			return _result, _err
		}()
		if !tea.BoolValue(tea.Retryable(_err)) {
			break
		}
	}

	return _resp, _err
}

func (client *Client) AppendObject(request *AppendObjectRequest, runtime *ossutil.RuntimeOptions) (_result *AppendObjectResponse, _err error) {
	_err = tea.Validate(request)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Validate(runtime)
	if _err != nil {
		return _result, _err
	}
	_runtime := map[string]interface{}{
		"timeouted":      "retry",
		"readTimeout":    tea.IntValue(util.DefaultNumber(runtime.ReadTimeout, client.ReadTimeout)),
		"connectTimeout": tea.IntValue(util.DefaultNumber(runtime.ConnectTimeout, client.ConnectTimeout)),
		"localAddr":      tea.StringValue(util.DefaultString(runtime.LocalAddr, client.LocalAddr)),
		"httpProxy":      tea.StringValue(util.DefaultString(runtime.HttpProxy, client.HttpProxy)),
		"httpsProxy":     tea.StringValue(util.DefaultString(runtime.HttpsProxy, client.HttpsProxy)),
		"noProxy":        tea.StringValue(util.DefaultString(runtime.NoProxy, client.NoProxy)),
		"socks5Proxy":    tea.StringValue(util.DefaultString(runtime.Socks5Proxy, client.Socks5Proxy)),
		"socks5NetWork":  tea.StringValue(util.DefaultString(runtime.Socks5NetWork, client.Socks5NetWork)),
		"maxIdleConns":   tea.IntValue(util.DefaultNumber(runtime.MaxIdleConns, client.MaxIdleConns)),
		"retry": map[string]interface{}{
			"retryable":   tea.BoolValue(runtime.Autoretry),
			"maxAttempts": tea.IntValue(util.DefaultNumber(runtime.MaxAttempts, tea.Int(3))),
		},
		"backoff": map[string]interface{}{
			"policy": tea.StringValue(util.DefaultString(runtime.BackoffPolicy, tea.String("no"))),
			"period": tea.IntValue(util.DefaultNumber(runtime.BackoffPeriod, tea.Int(1))),
		},
		"ignoreSSL": tea.BoolValue(runtime.IgnoreSSL),
	}

	_resp := &AppendObjectResponse{}
	for _retryTimes := 0; tea.BoolValue(tea.AllowRetry(_runtime["retry"], tea.Int(_retryTimes))); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], tea.Int(_retryTimes))
			if tea.IntValue(_backoffTime) > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, _err = func() (*AppendObjectResponse, error) {
			request_ := tea.NewRequest()
			ctx := make(map[string]*string)
			accessKeyId, _err := client.Credential.GetAccessKeyId()
			if _err != nil {
				return _result, _err
			}

			accessKeySecret, _err := client.Credential.GetAccessKeySecret()
			if _err != nil {
				return _result, _err
			}

			token, _err := client.Credential.GetSecurityToken()
			if _err != nil {
				return _result, _err
			}

			request_.Protocol = client.Protocol
			request_.Method = tea.String("POST")
			request_.Pathname = tea.String("/" + tea.StringValue(request.ObjectName) + "?append")
			request_.Headers = tea.Merge(map[string]*string{
				"host":       ossutil.GetHost(request.BucketName, client.RegionId, client.Endpoint, client.HostModel),
				"date":       util.GetDateUTCString(),
				"user-agent": client.GetUserAgent(),
			}, util.StringifyMapValue(tea.ToMap(request.Header)),
				ossutil.ParseMeta(request.UserMeta, tea.String("x-oss-meta-")))
			if !tea.BoolValue(util.Empty(token)) {
				request_.Headers["x-oss-security-token"] = token
			}

			request_.Query = util.StringifyMapValue(tea.ToMap(request.Filter))
			request_.Body = ossutil.Inject(request.Body, ctx)
			if !tea.BoolValue(util.IsUnset(tea.ToMap(request.Header))) && !tea.BoolValue(util.Empty(request.Header.ContentType)) {
				request_.Headers["content-type"] = request.Header.ContentType
			} else {
				request_.Headers["content-type"] = ossutil.GetContentType(request.ObjectName)
			}

			request_.Headers["authorization"] = ossutil.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, client.SignatureVersion, client.AddtionalHeaders)
			response_, _err := tea.DoRequest(request_, _runtime)
			if _err != nil {
				return _result, _err
			}
			var respMap map[string]interface{}
			var bodyStr *string
			if tea.BoolValue(util.Is4xx(response_.StatusCode)) || tea.BoolValue(util.Is5xx(response_.StatusCode)) {
				bodyStr, _err = util.ReadAsString(response_.Body)
				if _err != nil {
					return _result, _err
				}

				respMap = ossutil.GetErrMessage(bodyStr)
				_err = tea.NewSDKError(map[string]interface{}{
					"code":    respMap["Code"],
					"message": respMap["Message"],
					"data": map[string]interface{}{
						"httpCode":  tea.IntValue(response_.StatusCode),
						"requestId": respMap["RequestId"],
						"hostId":    respMap["HostId"],
					},
				})
				return _result, _err
			}

			if tea.BoolValue(client.IsEnableCrc) && !tea.BoolValue(util.EqualString(ctx["crc"], response_.Headers["x-oss-hash-crc64ecma"])) {
				_err = tea.NewSDKError(map[string]interface{}{
					"code": "CrcNotMatched",
					"data": map[string]*string{
						"clientCrc": ctx["crc"],
						"serverCrc": response_.Headers["x-oss-hash-crc64ecma"],
					},
				})
				return _result, _err
			}

			if tea.BoolValue(client.IsEnableMD5) && !tea.BoolValue(util.EqualString(ctx["md5"], response_.Headers["content-md5"])) {
				_err = tea.NewSDKError(map[string]interface{}{
					"code": "MD5NotMatched",
					"data": map[string]*string{
						"clientMD5": ctx["md5"],
						"serverMD5": response_.Headers["content-md5"],
					},
				})
				return _result, _err
			}

			_result = &AppendObjectResponse{}
			_err = tea.Convert(response_.Headers, &_result)
			return _result, _err
		}()
		if !tea.BoolValue(tea.Retryable(_err)) {
			break
		}
	}

	return _resp, _err
}

func (client *Client) UploadPartCopy(request *UploadPartCopyRequest, runtime *ossutil.RuntimeOptions) (_result *UploadPartCopyResponse, _err error) {
	_err = tea.Validate(request)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Validate(runtime)
	if _err != nil {
		return _result, _err
	}
	_runtime := map[string]interface{}{
		"timeouted":      "retry",
		"readTimeout":    tea.IntValue(util.DefaultNumber(runtime.ReadTimeout, client.ReadTimeout)),
		"connectTimeout": tea.IntValue(util.DefaultNumber(runtime.ConnectTimeout, client.ConnectTimeout)),
		"localAddr":      tea.StringValue(util.DefaultString(runtime.LocalAddr, client.LocalAddr)),
		"httpProxy":      tea.StringValue(util.DefaultString(runtime.HttpProxy, client.HttpProxy)),
		"httpsProxy":     tea.StringValue(util.DefaultString(runtime.HttpsProxy, client.HttpsProxy)),
		"noProxy":        tea.StringValue(util.DefaultString(runtime.NoProxy, client.NoProxy)),
		"socks5Proxy":    tea.StringValue(util.DefaultString(runtime.Socks5Proxy, client.Socks5Proxy)),
		"socks5NetWork":  tea.StringValue(util.DefaultString(runtime.Socks5NetWork, client.Socks5NetWork)),
		"maxIdleConns":   tea.IntValue(util.DefaultNumber(runtime.MaxIdleConns, client.MaxIdleConns)),
		"retry": map[string]interface{}{
			"retryable":   tea.BoolValue(runtime.Autoretry),
			"maxAttempts": tea.IntValue(util.DefaultNumber(runtime.MaxAttempts, tea.Int(3))),
		},
		"backoff": map[string]interface{}{
			"policy": tea.StringValue(util.DefaultString(runtime.BackoffPolicy, tea.String("no"))),
			"period": tea.IntValue(util.DefaultNumber(runtime.BackoffPeriod, tea.Int(1))),
		},
		"ignoreSSL": tea.BoolValue(runtime.IgnoreSSL),
	}

	_resp := &UploadPartCopyResponse{}
	for _retryTimes := 0; tea.BoolValue(tea.AllowRetry(_runtime["retry"], tea.Int(_retryTimes))); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], tea.Int(_retryTimes))
			if tea.IntValue(_backoffTime) > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, _err = func() (*UploadPartCopyResponse, error) {
			request_ := tea.NewRequest()
			accessKeyId, _err := client.Credential.GetAccessKeyId()
			if _err != nil {
				return _result, _err
			}

			accessKeySecret, _err := client.Credential.GetAccessKeySecret()
			if _err != nil {
				return _result, _err
			}

			token, _err := client.Credential.GetSecurityToken()
			if _err != nil {
				return _result, _err
			}

			request_.Protocol = client.Protocol
			request_.Method = tea.String("PUT")
			request_.Pathname = tea.String("/" + tea.StringValue(request.ObjectName))
			request_.Headers = tea.Merge(map[string]*string{
				"host":       ossutil.GetHost(request.BucketName, client.RegionId, client.Endpoint, client.HostModel),
				"date":       util.GetDateUTCString(),
				"user-agent": client.GetUserAgent(),
			}, util.StringifyMapValue(tea.ToMap(request.Header)))
			if !tea.BoolValue(util.Empty(token)) {
				request_.Headers["x-oss-security-token"] = token
			}

			request_.Query = util.StringifyMapValue(tea.ToMap(request.Filter))
			request_.Headers["authorization"] = ossutil.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, client.SignatureVersion, client.AddtionalHeaders)
			response_, _err := tea.DoRequest(request_, _runtime)
			if _err != nil {
				return _result, _err
			}
			var respMap map[string]interface{}
			var bodyStr *string
			if tea.BoolValue(util.Is4xx(response_.StatusCode)) || tea.BoolValue(util.Is5xx(response_.StatusCode)) {
				bodyStr, _err = util.ReadAsString(response_.Body)
				if _err != nil {
					return _result, _err
				}

				respMap = ossutil.GetErrMessage(bodyStr)
				_err = tea.NewSDKError(map[string]interface{}{
					"code":    respMap["Code"],
					"message": respMap["Message"],
					"data": map[string]interface{}{
						"httpCode":  tea.IntValue(response_.StatusCode),
						"requestId": respMap["RequestId"],
						"hostId":    respMap["HostId"],
					},
				})
				return _result, _err
			}

			bodyStr, _err = util.ReadAsString(response_.Body)
			if _err != nil {
				return _result, _err
			}

			respMap = xml.ParseXml(bodyStr, new(UploadPartCopyResponse))
			_result = &UploadPartCopyResponse{}
			_err = tea.Convert(tea.ToMap(map[string]interface{}{
				"CopyPartResult": respMap["CopyPartResult"],
			}, response_.Headers), &_result)
			return _result, _err
		}()
		if !tea.BoolValue(tea.Retryable(_err)) {
			break
		}
	}

	return _resp, _err
}

func (client *Client) GetVodPlaylist(request *GetVodPlaylistRequest, runtime *ossutil.RuntimeOptions) (_result *GetVodPlaylistResponse, _err error) {
	_err = tea.Validate(request)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Validate(runtime)
	if _err != nil {
		return _result, _err
	}
	_runtime := map[string]interface{}{
		"timeouted":      "retry",
		"readTimeout":    tea.IntValue(util.DefaultNumber(runtime.ReadTimeout, client.ReadTimeout)),
		"connectTimeout": tea.IntValue(util.DefaultNumber(runtime.ConnectTimeout, client.ConnectTimeout)),
		"localAddr":      tea.StringValue(util.DefaultString(runtime.LocalAddr, client.LocalAddr)),
		"httpProxy":      tea.StringValue(util.DefaultString(runtime.HttpProxy, client.HttpProxy)),
		"httpsProxy":     tea.StringValue(util.DefaultString(runtime.HttpsProxy, client.HttpsProxy)),
		"noProxy":        tea.StringValue(util.DefaultString(runtime.NoProxy, client.NoProxy)),
		"socks5Proxy":    tea.StringValue(util.DefaultString(runtime.Socks5Proxy, client.Socks5Proxy)),
		"socks5NetWork":  tea.StringValue(util.DefaultString(runtime.Socks5NetWork, client.Socks5NetWork)),
		"maxIdleConns":   tea.IntValue(util.DefaultNumber(runtime.MaxIdleConns, client.MaxIdleConns)),
		"retry": map[string]interface{}{
			"retryable":   tea.BoolValue(runtime.Autoretry),
			"maxAttempts": tea.IntValue(util.DefaultNumber(runtime.MaxAttempts, tea.Int(3))),
		},
		"backoff": map[string]interface{}{
			"policy": tea.StringValue(util.DefaultString(runtime.BackoffPolicy, tea.String("no"))),
			"period": tea.IntValue(util.DefaultNumber(runtime.BackoffPeriod, tea.Int(1))),
		},
		"ignoreSSL": tea.BoolValue(runtime.IgnoreSSL),
	}

	_resp := &GetVodPlaylistResponse{}
	for _retryTimes := 0; tea.BoolValue(tea.AllowRetry(_runtime["retry"], tea.Int(_retryTimes))); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], tea.Int(_retryTimes))
			if tea.IntValue(_backoffTime) > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, _err = func() (*GetVodPlaylistResponse, error) {
			request_ := tea.NewRequest()
			accessKeyId, _err := client.Credential.GetAccessKeyId()
			if _err != nil {
				return _result, _err
			}

			accessKeySecret, _err := client.Credential.GetAccessKeySecret()
			if _err != nil {
				return _result, _err
			}

			token, _err := client.Credential.GetSecurityToken()
			if _err != nil {
				return _result, _err
			}

			request_.Protocol = client.Protocol
			request_.Method = tea.String("GET")
			request_.Pathname = tea.String("/" + tea.StringValue(request.ChannelName) + "?vod")
			request_.Headers = map[string]*string{
				"host":       ossutil.GetHost(request.BucketName, client.RegionId, client.Endpoint, client.HostModel),
				"date":       util.GetDateUTCString(),
				"user-agent": client.GetUserAgent(),
			}
			if !tea.BoolValue(util.Empty(token)) {
				request_.Headers["x-oss-security-token"] = token
			}

			request_.Query = util.StringifyMapValue(tea.ToMap(request.Filter))
			request_.Headers["authorization"] = ossutil.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, client.SignatureVersion, client.AddtionalHeaders)
			response_, _err := tea.DoRequest(request_, _runtime)
			if _err != nil {
				return _result, _err
			}
			var respMap map[string]interface{}
			var bodyStr *string
			if tea.BoolValue(util.Is4xx(response_.StatusCode)) || tea.BoolValue(util.Is5xx(response_.StatusCode)) {
				bodyStr, _err = util.ReadAsString(response_.Body)
				if _err != nil {
					return _result, _err
				}

				respMap = ossutil.GetErrMessage(bodyStr)
				_err = tea.NewSDKError(map[string]interface{}{
					"code":    respMap["Code"],
					"message": respMap["Message"],
					"data": map[string]interface{}{
						"httpCode":  tea.IntValue(response_.StatusCode),
						"requestId": respMap["RequestId"],
						"hostId":    respMap["HostId"],
					},
				})
				return _result, _err
			}

			_result = &GetVodPlaylistResponse{}
			_err = tea.Convert(response_.Headers, &_result)
			return _result, _err
		}()
		if !tea.BoolValue(tea.Retryable(_err)) {
			break
		}
	}

	return _resp, _err
}

func (client *Client) DeleteBucketCORS(request *DeleteBucketCORSRequest, runtime *ossutil.RuntimeOptions) (_result *DeleteBucketCORSResponse, _err error) {
	_err = tea.Validate(request)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Validate(runtime)
	if _err != nil {
		return _result, _err
	}
	_runtime := map[string]interface{}{
		"timeouted":      "retry",
		"readTimeout":    tea.IntValue(util.DefaultNumber(runtime.ReadTimeout, client.ReadTimeout)),
		"connectTimeout": tea.IntValue(util.DefaultNumber(runtime.ConnectTimeout, client.ConnectTimeout)),
		"localAddr":      tea.StringValue(util.DefaultString(runtime.LocalAddr, client.LocalAddr)),
		"httpProxy":      tea.StringValue(util.DefaultString(runtime.HttpProxy, client.HttpProxy)),
		"httpsProxy":     tea.StringValue(util.DefaultString(runtime.HttpsProxy, client.HttpsProxy)),
		"noProxy":        tea.StringValue(util.DefaultString(runtime.NoProxy, client.NoProxy)),
		"socks5Proxy":    tea.StringValue(util.DefaultString(runtime.Socks5Proxy, client.Socks5Proxy)),
		"socks5NetWork":  tea.StringValue(util.DefaultString(runtime.Socks5NetWork, client.Socks5NetWork)),
		"maxIdleConns":   tea.IntValue(util.DefaultNumber(runtime.MaxIdleConns, client.MaxIdleConns)),
		"retry": map[string]interface{}{
			"retryable":   tea.BoolValue(runtime.Autoretry),
			"maxAttempts": tea.IntValue(util.DefaultNumber(runtime.MaxAttempts, tea.Int(3))),
		},
		"backoff": map[string]interface{}{
			"policy": tea.StringValue(util.DefaultString(runtime.BackoffPolicy, tea.String("no"))),
			"period": tea.IntValue(util.DefaultNumber(runtime.BackoffPeriod, tea.Int(1))),
		},
		"ignoreSSL": tea.BoolValue(runtime.IgnoreSSL),
	}

	_resp := &DeleteBucketCORSResponse{}
	for _retryTimes := 0; tea.BoolValue(tea.AllowRetry(_runtime["retry"], tea.Int(_retryTimes))); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], tea.Int(_retryTimes))
			if tea.IntValue(_backoffTime) > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, _err = func() (*DeleteBucketCORSResponse, error) {
			request_ := tea.NewRequest()
			accessKeyId, _err := client.Credential.GetAccessKeyId()
			if _err != nil {
				return _result, _err
			}

			accessKeySecret, _err := client.Credential.GetAccessKeySecret()
			if _err != nil {
				return _result, _err
			}

			token, _err := client.Credential.GetSecurityToken()
			if _err != nil {
				return _result, _err
			}

			request_.Protocol = client.Protocol
			request_.Method = tea.String("DELETE")
			request_.Pathname = tea.String("/?cors")
			request_.Headers = map[string]*string{
				"host":       ossutil.GetHost(request.BucketName, client.RegionId, client.Endpoint, client.HostModel),
				"date":       util.GetDateUTCString(),
				"user-agent": client.GetUserAgent(),
			}
			if !tea.BoolValue(util.Empty(token)) {
				request_.Headers["x-oss-security-token"] = token
			}

			request_.Headers["authorization"] = ossutil.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, client.SignatureVersion, client.AddtionalHeaders)
			response_, _err := tea.DoRequest(request_, _runtime)
			if _err != nil {
				return _result, _err
			}
			var respMap map[string]interface{}
			var bodyStr *string
			if tea.BoolValue(util.Is4xx(response_.StatusCode)) || tea.BoolValue(util.Is5xx(response_.StatusCode)) {
				bodyStr, _err = util.ReadAsString(response_.Body)
				if _err != nil {
					return _result, _err
				}

				respMap = ossutil.GetErrMessage(bodyStr)
				_err = tea.NewSDKError(map[string]interface{}{
					"code":    respMap["Code"],
					"message": respMap["Message"],
					"data": map[string]interface{}{
						"httpCode":  tea.IntValue(response_.StatusCode),
						"requestId": respMap["RequestId"],
						"hostId":    respMap["HostId"],
					},
				})
				return _result, _err
			}

			_result = &DeleteBucketCORSResponse{}
			_err = tea.Convert(response_.Headers, &_result)
			return _result, _err
		}()
		if !tea.BoolValue(tea.Retryable(_err)) {
			break
		}
	}

	return _resp, _err
}

func (client *Client) GetObject(request *GetObjectRequest, runtime *ossutil.RuntimeOptions) (_result *GetObjectResponse, _err error) {
	_err = tea.Validate(request)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Validate(runtime)
	if _err != nil {
		return _result, _err
	}
	_runtime := map[string]interface{}{
		"timeouted":      "retry",
		"readTimeout":    tea.IntValue(util.DefaultNumber(runtime.ReadTimeout, client.ReadTimeout)),
		"connectTimeout": tea.IntValue(util.DefaultNumber(runtime.ConnectTimeout, client.ConnectTimeout)),
		"localAddr":      tea.StringValue(util.DefaultString(runtime.LocalAddr, client.LocalAddr)),
		"httpProxy":      tea.StringValue(util.DefaultString(runtime.HttpProxy, client.HttpProxy)),
		"httpsProxy":     tea.StringValue(util.DefaultString(runtime.HttpsProxy, client.HttpsProxy)),
		"noProxy":        tea.StringValue(util.DefaultString(runtime.NoProxy, client.NoProxy)),
		"socks5Proxy":    tea.StringValue(util.DefaultString(runtime.Socks5Proxy, client.Socks5Proxy)),
		"socks5NetWork":  tea.StringValue(util.DefaultString(runtime.Socks5NetWork, client.Socks5NetWork)),
		"maxIdleConns":   tea.IntValue(util.DefaultNumber(runtime.MaxIdleConns, client.MaxIdleConns)),
		"retry": map[string]interface{}{
			"retryable":   tea.BoolValue(runtime.Autoretry),
			"maxAttempts": tea.IntValue(util.DefaultNumber(runtime.MaxAttempts, tea.Int(3))),
		},
		"backoff": map[string]interface{}{
			"policy": tea.StringValue(util.DefaultString(runtime.BackoffPolicy, tea.String("no"))),
			"period": tea.IntValue(util.DefaultNumber(runtime.BackoffPeriod, tea.Int(1))),
		},
		"ignoreSSL": tea.BoolValue(runtime.IgnoreSSL),
	}

	_resp := &GetObjectResponse{}
	for _retryTimes := 0; tea.BoolValue(tea.AllowRetry(_runtime["retry"], tea.Int(_retryTimes))); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], tea.Int(_retryTimes))
			if tea.IntValue(_backoffTime) > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, _err = func() (*GetObjectResponse, error) {
			request_ := tea.NewRequest()
			accessKeyId, _err := client.Credential.GetAccessKeyId()
			if _err != nil {
				return _result, _err
			}

			accessKeySecret, _err := client.Credential.GetAccessKeySecret()
			if _err != nil {
				return _result, _err
			}

			token, _err := client.Credential.GetSecurityToken()
			if _err != nil {
				return _result, _err
			}

			request_.Protocol = client.Protocol
			request_.Method = tea.String("GET")
			request_.Pathname = tea.String("/" + tea.StringValue(request.ObjectName))
			request_.Headers = tea.Merge(map[string]*string{
				"host":       ossutil.GetHost(request.BucketName, client.RegionId, client.Endpoint, client.HostModel),
				"date":       util.GetDateUTCString(),
				"user-agent": client.GetUserAgent(),
			}, util.StringifyMapValue(tea.ToMap(request.Header)))
			if !tea.BoolValue(util.Empty(token)) {
				request_.Headers["x-oss-security-token"] = token
			}

			request_.Headers["authorization"] = ossutil.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, client.SignatureVersion, client.AddtionalHeaders)
			response_, _err := tea.DoRequest(request_, _runtime)
			if _err != nil {
				return _result, _err
			}
			var respMap map[string]interface{}
			var bodyStr *string
			if tea.BoolValue(util.Is4xx(response_.StatusCode)) || tea.BoolValue(util.Is5xx(response_.StatusCode)) {
				bodyStr, _err = util.ReadAsString(response_.Body)
				if _err != nil {
					return _result, _err
				}

				respMap = ossutil.GetErrMessage(bodyStr)
				_err = tea.NewSDKError(map[string]interface{}{
					"code":    respMap["Code"],
					"message": respMap["Message"],
					"data": map[string]interface{}{
						"httpCode":  tea.IntValue(response_.StatusCode),
						"requestId": respMap["RequestId"],
						"hostId":    respMap["HostId"],
					},
				})
				return _result, _err
			}

			_result = &GetObjectResponse{}
			_result.Body = response_.Body
			_err = tea.Convert(response_.Headers, &_result)
			return _result, _err
		}()
		if !tea.BoolValue(tea.Retryable(_err)) {
			break
		}
	}

	return _resp, _err
}

func (client *Client) UploadPart(request *UploadPartRequest, runtime *ossutil.RuntimeOptions) (_result *UploadPartResponse, _err error) {
	_err = tea.Validate(request)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Validate(runtime)
	if _err != nil {
		return _result, _err
	}
	_runtime := map[string]interface{}{
		"timeouted":      "retry",
		"readTimeout":    tea.IntValue(util.DefaultNumber(runtime.ReadTimeout, client.ReadTimeout)),
		"connectTimeout": tea.IntValue(util.DefaultNumber(runtime.ConnectTimeout, client.ConnectTimeout)),
		"localAddr":      tea.StringValue(util.DefaultString(runtime.LocalAddr, client.LocalAddr)),
		"httpProxy":      tea.StringValue(util.DefaultString(runtime.HttpProxy, client.HttpProxy)),
		"httpsProxy":     tea.StringValue(util.DefaultString(runtime.HttpsProxy, client.HttpsProxy)),
		"noProxy":        tea.StringValue(util.DefaultString(runtime.NoProxy, client.NoProxy)),
		"socks5Proxy":    tea.StringValue(util.DefaultString(runtime.Socks5Proxy, client.Socks5Proxy)),
		"socks5NetWork":  tea.StringValue(util.DefaultString(runtime.Socks5NetWork, client.Socks5NetWork)),
		"maxIdleConns":   tea.IntValue(util.DefaultNumber(runtime.MaxIdleConns, client.MaxIdleConns)),
		"retry": map[string]interface{}{
			"retryable":   tea.BoolValue(runtime.Autoretry),
			"maxAttempts": tea.IntValue(util.DefaultNumber(runtime.MaxAttempts, tea.Int(3))),
		},
		"backoff": map[string]interface{}{
			"policy": tea.StringValue(util.DefaultString(runtime.BackoffPolicy, tea.String("no"))),
			"period": tea.IntValue(util.DefaultNumber(runtime.BackoffPeriod, tea.Int(1))),
		},
		"ignoreSSL": tea.BoolValue(runtime.IgnoreSSL),
	}

	_resp := &UploadPartResponse{}
	for _retryTimes := 0; tea.BoolValue(tea.AllowRetry(_runtime["retry"], tea.Int(_retryTimes))); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], tea.Int(_retryTimes))
			if tea.IntValue(_backoffTime) > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, _err = func() (*UploadPartResponse, error) {
			request_ := tea.NewRequest()
			ctx := make(map[string]*string)
			accessKeyId, _err := client.Credential.GetAccessKeyId()
			if _err != nil {
				return _result, _err
			}

			accessKeySecret, _err := client.Credential.GetAccessKeySecret()
			if _err != nil {
				return _result, _err
			}

			token, _err := client.Credential.GetSecurityToken()
			if _err != nil {
				return _result, _err
			}

			request_.Protocol = client.Protocol
			request_.Method = tea.String("PUT")
			request_.Pathname = tea.String("/" + tea.StringValue(request.ObjectName))
			request_.Headers = map[string]*string{
				"host":       ossutil.GetHost(request.BucketName, client.RegionId, client.Endpoint, client.HostModel),
				"date":       util.GetDateUTCString(),
				"user-agent": client.GetUserAgent(),
			}
			if !tea.BoolValue(util.Empty(token)) {
				request_.Headers["x-oss-security-token"] = token
			}

			request_.Query = util.StringifyMapValue(tea.ToMap(request.Filter))
			request_.Body = ossutil.Inject(request.Body, ctx)
			request_.Headers["authorization"] = ossutil.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, client.SignatureVersion, client.AddtionalHeaders)
			response_, _err := tea.DoRequest(request_, _runtime)
			if _err != nil {
				return _result, _err
			}
			var respMap map[string]interface{}
			var bodyStr *string
			if tea.BoolValue(util.Is4xx(response_.StatusCode)) || tea.BoolValue(util.Is5xx(response_.StatusCode)) {
				bodyStr, _err = util.ReadAsString(response_.Body)
				if _err != nil {
					return _result, _err
				}

				respMap = ossutil.GetErrMessage(bodyStr)
				_err = tea.NewSDKError(map[string]interface{}{
					"code":    respMap["Code"],
					"message": respMap["Message"],
					"data": map[string]interface{}{
						"httpCode":  tea.IntValue(response_.StatusCode),
						"requestId": respMap["RequestId"],
						"hostId":    respMap["HostId"],
					},
				})
				return _result, _err
			}

			if tea.BoolValue(client.IsEnableCrc) && !tea.BoolValue(util.EqualString(ctx["crc"], response_.Headers["x-oss-hash-crc64ecma"])) {
				_err = tea.NewSDKError(map[string]interface{}{
					"code": "CrcNotMatched",
					"data": map[string]*string{
						"clientCrc": ctx["crc"],
						"serverCrc": response_.Headers["x-oss-hash-crc64ecma"],
					},
				})
				return _result, _err
			}

			if tea.BoolValue(client.IsEnableMD5) && !tea.BoolValue(util.EqualString(ctx["md5"], response_.Headers["content-md5"])) {
				_err = tea.NewSDKError(map[string]interface{}{
					"code": "MD5NotMatched",
					"data": map[string]*string{
						"clientMD5": ctx["md5"],
						"serverMD5": response_.Headers["content-md5"],
					},
				})
				return _result, _err
			}

			_result = &UploadPartResponse{}
			_err = tea.Convert(response_.Headers, &_result)
			return _result, _err
		}()
		if !tea.BoolValue(tea.Retryable(_err)) {
			break
		}
	}

	return _resp, _err
}

func (client *Client) GetBucketCORS(request *GetBucketCORSRequest, runtime *ossutil.RuntimeOptions) (_result *GetBucketCORSResponse, _err error) {
	_err = tea.Validate(request)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Validate(runtime)
	if _err != nil {
		return _result, _err
	}
	_runtime := map[string]interface{}{
		"timeouted":      "retry",
		"readTimeout":    tea.IntValue(util.DefaultNumber(runtime.ReadTimeout, client.ReadTimeout)),
		"connectTimeout": tea.IntValue(util.DefaultNumber(runtime.ConnectTimeout, client.ConnectTimeout)),
		"localAddr":      tea.StringValue(util.DefaultString(runtime.LocalAddr, client.LocalAddr)),
		"httpProxy":      tea.StringValue(util.DefaultString(runtime.HttpProxy, client.HttpProxy)),
		"httpsProxy":     tea.StringValue(util.DefaultString(runtime.HttpsProxy, client.HttpsProxy)),
		"noProxy":        tea.StringValue(util.DefaultString(runtime.NoProxy, client.NoProxy)),
		"socks5Proxy":    tea.StringValue(util.DefaultString(runtime.Socks5Proxy, client.Socks5Proxy)),
		"socks5NetWork":  tea.StringValue(util.DefaultString(runtime.Socks5NetWork, client.Socks5NetWork)),
		"maxIdleConns":   tea.IntValue(util.DefaultNumber(runtime.MaxIdleConns, client.MaxIdleConns)),
		"retry": map[string]interface{}{
			"retryable":   tea.BoolValue(runtime.Autoretry),
			"maxAttempts": tea.IntValue(util.DefaultNumber(runtime.MaxAttempts, tea.Int(3))),
		},
		"backoff": map[string]interface{}{
			"policy": tea.StringValue(util.DefaultString(runtime.BackoffPolicy, tea.String("no"))),
			"period": tea.IntValue(util.DefaultNumber(runtime.BackoffPeriod, tea.Int(1))),
		},
		"ignoreSSL": tea.BoolValue(runtime.IgnoreSSL),
	}

	_resp := &GetBucketCORSResponse{}
	for _retryTimes := 0; tea.BoolValue(tea.AllowRetry(_runtime["retry"], tea.Int(_retryTimes))); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], tea.Int(_retryTimes))
			if tea.IntValue(_backoffTime) > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, _err = func() (*GetBucketCORSResponse, error) {
			request_ := tea.NewRequest()
			accessKeyId, _err := client.Credential.GetAccessKeyId()
			if _err != nil {
				return _result, _err
			}

			accessKeySecret, _err := client.Credential.GetAccessKeySecret()
			if _err != nil {
				return _result, _err
			}

			token, _err := client.Credential.GetSecurityToken()
			if _err != nil {
				return _result, _err
			}

			request_.Protocol = client.Protocol
			request_.Method = tea.String("GET")
			request_.Pathname = tea.String("/?cors")
			request_.Headers = map[string]*string{
				"host":       ossutil.GetHost(request.BucketName, client.RegionId, client.Endpoint, client.HostModel),
				"date":       util.GetDateUTCString(),
				"user-agent": client.GetUserAgent(),
			}
			if !tea.BoolValue(util.Empty(token)) {
				request_.Headers["x-oss-security-token"] = token
			}

			request_.Headers["authorization"] = ossutil.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, client.SignatureVersion, client.AddtionalHeaders)
			response_, _err := tea.DoRequest(request_, _runtime)
			if _err != nil {
				return _result, _err
			}
			var respMap map[string]interface{}
			var bodyStr *string
			if tea.BoolValue(util.Is4xx(response_.StatusCode)) || tea.BoolValue(util.Is5xx(response_.StatusCode)) {
				bodyStr, _err = util.ReadAsString(response_.Body)
				if _err != nil {
					return _result, _err
				}

				respMap = ossutil.GetErrMessage(bodyStr)
				_err = tea.NewSDKError(map[string]interface{}{
					"code":    respMap["Code"],
					"message": respMap["Message"],
					"data": map[string]interface{}{
						"httpCode":  tea.IntValue(response_.StatusCode),
						"requestId": respMap["RequestId"],
						"hostId":    respMap["HostId"],
					},
				})
				return _result, _err
			}

			bodyStr, _err = util.ReadAsString(response_.Body)
			if _err != nil {
				return _result, _err
			}

			respMap = xml.ParseXml(bodyStr, new(GetBucketCORSResponse))
			_result = &GetBucketCORSResponse{}
			_err = tea.Convert(tea.ToMap(map[string]interface{}{
				"CORSConfiguration": respMap["CORSConfiguration"],
			}, response_.Headers), &_result)
			return _result, _err
		}()
		if !tea.BoolValue(tea.Retryable(_err)) {
			break
		}
	}

	return _resp, _err
}

func (client *Client) CopyObject(request *CopyObjectRequest, runtime *ossutil.RuntimeOptions) (_result *CopyObjectResponse, _err error) {
	_err = tea.Validate(request)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Validate(runtime)
	if _err != nil {
		return _result, _err
	}
	_runtime := map[string]interface{}{
		"timeouted":      "retry",
		"readTimeout":    tea.IntValue(util.DefaultNumber(runtime.ReadTimeout, client.ReadTimeout)),
		"connectTimeout": tea.IntValue(util.DefaultNumber(runtime.ConnectTimeout, client.ConnectTimeout)),
		"localAddr":      tea.StringValue(util.DefaultString(runtime.LocalAddr, client.LocalAddr)),
		"httpProxy":      tea.StringValue(util.DefaultString(runtime.HttpProxy, client.HttpProxy)),
		"httpsProxy":     tea.StringValue(util.DefaultString(runtime.HttpsProxy, client.HttpsProxy)),
		"noProxy":        tea.StringValue(util.DefaultString(runtime.NoProxy, client.NoProxy)),
		"socks5Proxy":    tea.StringValue(util.DefaultString(runtime.Socks5Proxy, client.Socks5Proxy)),
		"socks5NetWork":  tea.StringValue(util.DefaultString(runtime.Socks5NetWork, client.Socks5NetWork)),
		"maxIdleConns":   tea.IntValue(util.DefaultNumber(runtime.MaxIdleConns, client.MaxIdleConns)),
		"retry": map[string]interface{}{
			"retryable":   tea.BoolValue(runtime.Autoretry),
			"maxAttempts": tea.IntValue(util.DefaultNumber(runtime.MaxAttempts, tea.Int(3))),
		},
		"backoff": map[string]interface{}{
			"policy": tea.StringValue(util.DefaultString(runtime.BackoffPolicy, tea.String("no"))),
			"period": tea.IntValue(util.DefaultNumber(runtime.BackoffPeriod, tea.Int(1))),
		},
		"ignoreSSL": tea.BoolValue(runtime.IgnoreSSL),
	}

	_resp := &CopyObjectResponse{}
	for _retryTimes := 0; tea.BoolValue(tea.AllowRetry(_runtime["retry"], tea.Int(_retryTimes))); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], tea.Int(_retryTimes))
			if tea.IntValue(_backoffTime) > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, _err = func() (*CopyObjectResponse, error) {
			request_ := tea.NewRequest()
			accessKeyId, _err := client.Credential.GetAccessKeyId()
			if _err != nil {
				return _result, _err
			}

			accessKeySecret, _err := client.Credential.GetAccessKeySecret()
			if _err != nil {
				return _result, _err
			}

			token, _err := client.Credential.GetSecurityToken()
			if _err != nil {
				return _result, _err
			}

			request_.Protocol = client.Protocol
			request_.Method = tea.String("PUT")
			request_.Pathname = tea.String("/" + tea.StringValue(request.DestObjectName))
			request_.Headers = tea.Merge(map[string]*string{
				"host":       ossutil.GetHost(request.BucketName, client.RegionId, client.Endpoint, client.HostModel),
				"date":       util.GetDateUTCString(),
				"user-agent": client.GetUserAgent(),
			}, util.StringifyMapValue(tea.ToMap(request.Header)))
			if !tea.BoolValue(util.Empty(token)) {
				request_.Headers["x-oss-security-token"] = token
			}

			request_.Headers["x-oss-copy-source"] = ossutil.Encode(request_.Headers["x-oss-copy-source"], tea.String("UrlEncode"))
			request_.Headers["authorization"] = ossutil.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, client.SignatureVersion, client.AddtionalHeaders)
			response_, _err := tea.DoRequest(request_, _runtime)
			if _err != nil {
				return _result, _err
			}
			var respMap map[string]interface{}
			var bodyStr *string
			if tea.BoolValue(util.Is4xx(response_.StatusCode)) || tea.BoolValue(util.Is5xx(response_.StatusCode)) {
				bodyStr, _err = util.ReadAsString(response_.Body)
				if _err != nil {
					return _result, _err
				}

				respMap = ossutil.GetErrMessage(bodyStr)
				_err = tea.NewSDKError(map[string]interface{}{
					"code":    respMap["Code"],
					"message": respMap["Message"],
					"data": map[string]interface{}{
						"httpCode":  tea.IntValue(response_.StatusCode),
						"requestId": respMap["RequestId"],
						"hostId":    respMap["HostId"],
					},
				})
				return _result, _err
			}

			bodyStr, _err = util.ReadAsString(response_.Body)
			if _err != nil {
				return _result, _err
			}

			respMap = xml.ParseXml(bodyStr, new(CopyObjectResponse))
			_result = &CopyObjectResponse{}
			_err = tea.Convert(tea.ToMap(map[string]interface{}{
				"CopyObjectResult": respMap["CopyObjectResult"],
			}, response_.Headers), &_result)
			return _result, _err
		}()
		if !tea.BoolValue(tea.Retryable(_err)) {
			break
		}
	}

	return _resp, _err
}

func (client *Client) GetObjectTagging(request *GetObjectTaggingRequest, runtime *ossutil.RuntimeOptions) (_result *GetObjectTaggingResponse, _err error) {
	_err = tea.Validate(request)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Validate(runtime)
	if _err != nil {
		return _result, _err
	}
	_runtime := map[string]interface{}{
		"timeouted":      "retry",
		"readTimeout":    tea.IntValue(util.DefaultNumber(runtime.ReadTimeout, client.ReadTimeout)),
		"connectTimeout": tea.IntValue(util.DefaultNumber(runtime.ConnectTimeout, client.ConnectTimeout)),
		"localAddr":      tea.StringValue(util.DefaultString(runtime.LocalAddr, client.LocalAddr)),
		"httpProxy":      tea.StringValue(util.DefaultString(runtime.HttpProxy, client.HttpProxy)),
		"httpsProxy":     tea.StringValue(util.DefaultString(runtime.HttpsProxy, client.HttpsProxy)),
		"noProxy":        tea.StringValue(util.DefaultString(runtime.NoProxy, client.NoProxy)),
		"socks5Proxy":    tea.StringValue(util.DefaultString(runtime.Socks5Proxy, client.Socks5Proxy)),
		"socks5NetWork":  tea.StringValue(util.DefaultString(runtime.Socks5NetWork, client.Socks5NetWork)),
		"maxIdleConns":   tea.IntValue(util.DefaultNumber(runtime.MaxIdleConns, client.MaxIdleConns)),
		"retry": map[string]interface{}{
			"retryable":   tea.BoolValue(runtime.Autoretry),
			"maxAttempts": tea.IntValue(util.DefaultNumber(runtime.MaxAttempts, tea.Int(3))),
		},
		"backoff": map[string]interface{}{
			"policy": tea.StringValue(util.DefaultString(runtime.BackoffPolicy, tea.String("no"))),
			"period": tea.IntValue(util.DefaultNumber(runtime.BackoffPeriod, tea.Int(1))),
		},
		"ignoreSSL": tea.BoolValue(runtime.IgnoreSSL),
	}

	_resp := &GetObjectTaggingResponse{}
	for _retryTimes := 0; tea.BoolValue(tea.AllowRetry(_runtime["retry"], tea.Int(_retryTimes))); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], tea.Int(_retryTimes))
			if tea.IntValue(_backoffTime) > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, _err = func() (*GetObjectTaggingResponse, error) {
			request_ := tea.NewRequest()
			accessKeyId, _err := client.Credential.GetAccessKeyId()
			if _err != nil {
				return _result, _err
			}

			accessKeySecret, _err := client.Credential.GetAccessKeySecret()
			if _err != nil {
				return _result, _err
			}

			token, _err := client.Credential.GetSecurityToken()
			if _err != nil {
				return _result, _err
			}

			request_.Protocol = client.Protocol
			request_.Method = tea.String("GET")
			request_.Pathname = tea.String("/" + tea.StringValue(request.ObjectName) + "?tagging")
			request_.Headers = map[string]*string{
				"host":       ossutil.GetHost(request.BucketName, client.RegionId, client.Endpoint, client.HostModel),
				"date":       util.GetDateUTCString(),
				"user-agent": client.GetUserAgent(),
			}
			if !tea.BoolValue(util.Empty(token)) {
				request_.Headers["x-oss-security-token"] = token
			}

			request_.Headers["authorization"] = ossutil.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, client.SignatureVersion, client.AddtionalHeaders)
			response_, _err := tea.DoRequest(request_, _runtime)
			if _err != nil {
				return _result, _err
			}
			var respMap map[string]interface{}
			var bodyStr *string
			if tea.BoolValue(util.Is4xx(response_.StatusCode)) || tea.BoolValue(util.Is5xx(response_.StatusCode)) {
				bodyStr, _err = util.ReadAsString(response_.Body)
				if _err != nil {
					return _result, _err
				}

				respMap = ossutil.GetErrMessage(bodyStr)
				_err = tea.NewSDKError(map[string]interface{}{
					"code":    respMap["Code"],
					"message": respMap["Message"],
					"data": map[string]interface{}{
						"httpCode":  tea.IntValue(response_.StatusCode),
						"requestId": respMap["RequestId"],
						"hostId":    respMap["HostId"],
					},
				})
				return _result, _err
			}

			bodyStr, _err = util.ReadAsString(response_.Body)
			if _err != nil {
				return _result, _err
			}

			respMap = xml.ParseXml(bodyStr, new(GetObjectTaggingResponse))
			_result = &GetObjectTaggingResponse{}
			_err = tea.Convert(tea.ToMap(map[string]interface{}{
				"Tagging": respMap["Tagging"],
			}, response_.Headers), &_result)
			return _result, _err
		}()
		if !tea.BoolValue(tea.Retryable(_err)) {
			break
		}
	}

	return _resp, _err
}

func (client *Client) DeleteBucketLifecycle(request *DeleteBucketLifecycleRequest, runtime *ossutil.RuntimeOptions) (_result *DeleteBucketLifecycleResponse, _err error) {
	_err = tea.Validate(request)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Validate(runtime)
	if _err != nil {
		return _result, _err
	}
	_runtime := map[string]interface{}{
		"timeouted":      "retry",
		"readTimeout":    tea.IntValue(util.DefaultNumber(runtime.ReadTimeout, client.ReadTimeout)),
		"connectTimeout": tea.IntValue(util.DefaultNumber(runtime.ConnectTimeout, client.ConnectTimeout)),
		"localAddr":      tea.StringValue(util.DefaultString(runtime.LocalAddr, client.LocalAddr)),
		"httpProxy":      tea.StringValue(util.DefaultString(runtime.HttpProxy, client.HttpProxy)),
		"httpsProxy":     tea.StringValue(util.DefaultString(runtime.HttpsProxy, client.HttpsProxy)),
		"noProxy":        tea.StringValue(util.DefaultString(runtime.NoProxy, client.NoProxy)),
		"socks5Proxy":    tea.StringValue(util.DefaultString(runtime.Socks5Proxy, client.Socks5Proxy)),
		"socks5NetWork":  tea.StringValue(util.DefaultString(runtime.Socks5NetWork, client.Socks5NetWork)),
		"maxIdleConns":   tea.IntValue(util.DefaultNumber(runtime.MaxIdleConns, client.MaxIdleConns)),
		"retry": map[string]interface{}{
			"retryable":   tea.BoolValue(runtime.Autoretry),
			"maxAttempts": tea.IntValue(util.DefaultNumber(runtime.MaxAttempts, tea.Int(3))),
		},
		"backoff": map[string]interface{}{
			"policy": tea.StringValue(util.DefaultString(runtime.BackoffPolicy, tea.String("no"))),
			"period": tea.IntValue(util.DefaultNumber(runtime.BackoffPeriod, tea.Int(1))),
		},
		"ignoreSSL": tea.BoolValue(runtime.IgnoreSSL),
	}

	_resp := &DeleteBucketLifecycleResponse{}
	for _retryTimes := 0; tea.BoolValue(tea.AllowRetry(_runtime["retry"], tea.Int(_retryTimes))); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], tea.Int(_retryTimes))
			if tea.IntValue(_backoffTime) > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, _err = func() (*DeleteBucketLifecycleResponse, error) {
			request_ := tea.NewRequest()
			accessKeyId, _err := client.Credential.GetAccessKeyId()
			if _err != nil {
				return _result, _err
			}

			accessKeySecret, _err := client.Credential.GetAccessKeySecret()
			if _err != nil {
				return _result, _err
			}

			token, _err := client.Credential.GetSecurityToken()
			if _err != nil {
				return _result, _err
			}

			request_.Protocol = client.Protocol
			request_.Method = tea.String("DELETE")
			request_.Pathname = tea.String("/?lifecycle")
			request_.Headers = map[string]*string{
				"host":       ossutil.GetHost(request.BucketName, client.RegionId, client.Endpoint, client.HostModel),
				"date":       util.GetDateUTCString(),
				"user-agent": client.GetUserAgent(),
			}
			if !tea.BoolValue(util.Empty(token)) {
				request_.Headers["x-oss-security-token"] = token
			}

			request_.Headers["authorization"] = ossutil.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, client.SignatureVersion, client.AddtionalHeaders)
			response_, _err := tea.DoRequest(request_, _runtime)
			if _err != nil {
				return _result, _err
			}
			var respMap map[string]interface{}
			var bodyStr *string
			if tea.BoolValue(util.Is4xx(response_.StatusCode)) || tea.BoolValue(util.Is5xx(response_.StatusCode)) {
				bodyStr, _err = util.ReadAsString(response_.Body)
				if _err != nil {
					return _result, _err
				}

				respMap = ossutil.GetErrMessage(bodyStr)
				_err = tea.NewSDKError(map[string]interface{}{
					"code":    respMap["Code"],
					"message": respMap["Message"],
					"data": map[string]interface{}{
						"httpCode":  tea.IntValue(response_.StatusCode),
						"requestId": respMap["RequestId"],
						"hostId":    respMap["HostId"],
					},
				})
				return _result, _err
			}

			_result = &DeleteBucketLifecycleResponse{}
			_err = tea.Convert(response_.Headers, &_result)
			return _result, _err
		}()
		if !tea.BoolValue(tea.Retryable(_err)) {
			break
		}
	}

	return _resp, _err
}

func (client *Client) DeleteBucketLogging(request *DeleteBucketLoggingRequest, runtime *ossutil.RuntimeOptions) (_result *DeleteBucketLoggingResponse, _err error) {
	_err = tea.Validate(request)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Validate(runtime)
	if _err != nil {
		return _result, _err
	}
	_runtime := map[string]interface{}{
		"timeouted":      "retry",
		"readTimeout":    tea.IntValue(util.DefaultNumber(runtime.ReadTimeout, client.ReadTimeout)),
		"connectTimeout": tea.IntValue(util.DefaultNumber(runtime.ConnectTimeout, client.ConnectTimeout)),
		"localAddr":      tea.StringValue(util.DefaultString(runtime.LocalAddr, client.LocalAddr)),
		"httpProxy":      tea.StringValue(util.DefaultString(runtime.HttpProxy, client.HttpProxy)),
		"httpsProxy":     tea.StringValue(util.DefaultString(runtime.HttpsProxy, client.HttpsProxy)),
		"noProxy":        tea.StringValue(util.DefaultString(runtime.NoProxy, client.NoProxy)),
		"socks5Proxy":    tea.StringValue(util.DefaultString(runtime.Socks5Proxy, client.Socks5Proxy)),
		"socks5NetWork":  tea.StringValue(util.DefaultString(runtime.Socks5NetWork, client.Socks5NetWork)),
		"maxIdleConns":   tea.IntValue(util.DefaultNumber(runtime.MaxIdleConns, client.MaxIdleConns)),
		"retry": map[string]interface{}{
			"retryable":   tea.BoolValue(runtime.Autoretry),
			"maxAttempts": tea.IntValue(util.DefaultNumber(runtime.MaxAttempts, tea.Int(3))),
		},
		"backoff": map[string]interface{}{
			"policy": tea.StringValue(util.DefaultString(runtime.BackoffPolicy, tea.String("no"))),
			"period": tea.IntValue(util.DefaultNumber(runtime.BackoffPeriod, tea.Int(1))),
		},
		"ignoreSSL": tea.BoolValue(runtime.IgnoreSSL),
	}

	_resp := &DeleteBucketLoggingResponse{}
	for _retryTimes := 0; tea.BoolValue(tea.AllowRetry(_runtime["retry"], tea.Int(_retryTimes))); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], tea.Int(_retryTimes))
			if tea.IntValue(_backoffTime) > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, _err = func() (*DeleteBucketLoggingResponse, error) {
			request_ := tea.NewRequest()
			accessKeyId, _err := client.Credential.GetAccessKeyId()
			if _err != nil {
				return _result, _err
			}

			accessKeySecret, _err := client.Credential.GetAccessKeySecret()
			if _err != nil {
				return _result, _err
			}

			token, _err := client.Credential.GetSecurityToken()
			if _err != nil {
				return _result, _err
			}

			request_.Protocol = client.Protocol
			request_.Method = tea.String("DELETE")
			request_.Pathname = tea.String("/?logging")
			request_.Headers = map[string]*string{
				"host":       ossutil.GetHost(request.BucketName, client.RegionId, client.Endpoint, client.HostModel),
				"date":       util.GetDateUTCString(),
				"user-agent": client.GetUserAgent(),
			}
			if !tea.BoolValue(util.Empty(token)) {
				request_.Headers["x-oss-security-token"] = token
			}

			request_.Headers["authorization"] = ossutil.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, client.SignatureVersion, client.AddtionalHeaders)
			response_, _err := tea.DoRequest(request_, _runtime)
			if _err != nil {
				return _result, _err
			}
			var respMap map[string]interface{}
			var bodyStr *string
			if tea.BoolValue(util.Is4xx(response_.StatusCode)) || tea.BoolValue(util.Is5xx(response_.StatusCode)) {
				bodyStr, _err = util.ReadAsString(response_.Body)
				if _err != nil {
					return _result, _err
				}

				respMap = ossutil.GetErrMessage(bodyStr)
				_err = tea.NewSDKError(map[string]interface{}{
					"code":    respMap["Code"],
					"message": respMap["Message"],
					"data": map[string]interface{}{
						"httpCode":  tea.IntValue(response_.StatusCode),
						"requestId": respMap["RequestId"],
						"hostId":    respMap["HostId"],
					},
				})
				return _result, _err
			}

			_result = &DeleteBucketLoggingResponse{}
			_err = tea.Convert(response_.Headers, &_result)
			return _result, _err
		}()
		if !tea.BoolValue(tea.Retryable(_err)) {
			break
		}
	}

	return _resp, _err
}

func (client *Client) DeleteBucketWebsite(request *DeleteBucketWebsiteRequest, runtime *ossutil.RuntimeOptions) (_result *DeleteBucketWebsiteResponse, _err error) {
	_err = tea.Validate(request)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Validate(runtime)
	if _err != nil {
		return _result, _err
	}
	_runtime := map[string]interface{}{
		"timeouted":      "retry",
		"readTimeout":    tea.IntValue(util.DefaultNumber(runtime.ReadTimeout, client.ReadTimeout)),
		"connectTimeout": tea.IntValue(util.DefaultNumber(runtime.ConnectTimeout, client.ConnectTimeout)),
		"localAddr":      tea.StringValue(util.DefaultString(runtime.LocalAddr, client.LocalAddr)),
		"httpProxy":      tea.StringValue(util.DefaultString(runtime.HttpProxy, client.HttpProxy)),
		"httpsProxy":     tea.StringValue(util.DefaultString(runtime.HttpsProxy, client.HttpsProxy)),
		"noProxy":        tea.StringValue(util.DefaultString(runtime.NoProxy, client.NoProxy)),
		"socks5Proxy":    tea.StringValue(util.DefaultString(runtime.Socks5Proxy, client.Socks5Proxy)),
		"socks5NetWork":  tea.StringValue(util.DefaultString(runtime.Socks5NetWork, client.Socks5NetWork)),
		"maxIdleConns":   tea.IntValue(util.DefaultNumber(runtime.MaxIdleConns, client.MaxIdleConns)),
		"retry": map[string]interface{}{
			"retryable":   tea.BoolValue(runtime.Autoretry),
			"maxAttempts": tea.IntValue(util.DefaultNumber(runtime.MaxAttempts, tea.Int(3))),
		},
		"backoff": map[string]interface{}{
			"policy": tea.StringValue(util.DefaultString(runtime.BackoffPolicy, tea.String("no"))),
			"period": tea.IntValue(util.DefaultNumber(runtime.BackoffPeriod, tea.Int(1))),
		},
		"ignoreSSL": tea.BoolValue(runtime.IgnoreSSL),
	}

	_resp := &DeleteBucketWebsiteResponse{}
	for _retryTimes := 0; tea.BoolValue(tea.AllowRetry(_runtime["retry"], tea.Int(_retryTimes))); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], tea.Int(_retryTimes))
			if tea.IntValue(_backoffTime) > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, _err = func() (*DeleteBucketWebsiteResponse, error) {
			request_ := tea.NewRequest()
			accessKeyId, _err := client.Credential.GetAccessKeyId()
			if _err != nil {
				return _result, _err
			}

			accessKeySecret, _err := client.Credential.GetAccessKeySecret()
			if _err != nil {
				return _result, _err
			}

			token, _err := client.Credential.GetSecurityToken()
			if _err != nil {
				return _result, _err
			}

			request_.Protocol = client.Protocol
			request_.Method = tea.String("DELETE")
			request_.Pathname = tea.String("/?website")
			request_.Headers = map[string]*string{
				"host":       ossutil.GetHost(request.BucketName, client.RegionId, client.Endpoint, client.HostModel),
				"date":       util.GetDateUTCString(),
				"user-agent": client.GetUserAgent(),
			}
			if !tea.BoolValue(util.Empty(token)) {
				request_.Headers["x-oss-security-token"] = token
			}

			request_.Headers["authorization"] = ossutil.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, client.SignatureVersion, client.AddtionalHeaders)
			response_, _err := tea.DoRequest(request_, _runtime)
			if _err != nil {
				return _result, _err
			}
			var respMap map[string]interface{}
			var bodyStr *string
			if tea.BoolValue(util.Is4xx(response_.StatusCode)) || tea.BoolValue(util.Is5xx(response_.StatusCode)) {
				bodyStr, _err = util.ReadAsString(response_.Body)
				if _err != nil {
					return _result, _err
				}

				respMap = ossutil.GetErrMessage(bodyStr)
				_err = tea.NewSDKError(map[string]interface{}{
					"code":    respMap["Code"],
					"message": respMap["Message"],
					"data": map[string]interface{}{
						"httpCode":  tea.IntValue(response_.StatusCode),
						"requestId": respMap["RequestId"],
						"hostId":    respMap["HostId"],
					},
				})
				return _result, _err
			}

			_result = &DeleteBucketWebsiteResponse{}
			_err = tea.Convert(response_.Headers, &_result)
			return _result, _err
		}()
		if !tea.BoolValue(tea.Retryable(_err)) {
			break
		}
	}

	return _resp, _err
}

func (client *Client) GetSymlink(request *GetSymlinkRequest, runtime *ossutil.RuntimeOptions) (_result *GetSymlinkResponse, _err error) {
	_err = tea.Validate(request)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Validate(runtime)
	if _err != nil {
		return _result, _err
	}
	_runtime := map[string]interface{}{
		"timeouted":      "retry",
		"readTimeout":    tea.IntValue(util.DefaultNumber(runtime.ReadTimeout, client.ReadTimeout)),
		"connectTimeout": tea.IntValue(util.DefaultNumber(runtime.ConnectTimeout, client.ConnectTimeout)),
		"localAddr":      tea.StringValue(util.DefaultString(runtime.LocalAddr, client.LocalAddr)),
		"httpProxy":      tea.StringValue(util.DefaultString(runtime.HttpProxy, client.HttpProxy)),
		"httpsProxy":     tea.StringValue(util.DefaultString(runtime.HttpsProxy, client.HttpsProxy)),
		"noProxy":        tea.StringValue(util.DefaultString(runtime.NoProxy, client.NoProxy)),
		"socks5Proxy":    tea.StringValue(util.DefaultString(runtime.Socks5Proxy, client.Socks5Proxy)),
		"socks5NetWork":  tea.StringValue(util.DefaultString(runtime.Socks5NetWork, client.Socks5NetWork)),
		"maxIdleConns":   tea.IntValue(util.DefaultNumber(runtime.MaxIdleConns, client.MaxIdleConns)),
		"retry": map[string]interface{}{
			"retryable":   tea.BoolValue(runtime.Autoretry),
			"maxAttempts": tea.IntValue(util.DefaultNumber(runtime.MaxAttempts, tea.Int(3))),
		},
		"backoff": map[string]interface{}{
			"policy": tea.StringValue(util.DefaultString(runtime.BackoffPolicy, tea.String("no"))),
			"period": tea.IntValue(util.DefaultNumber(runtime.BackoffPeriod, tea.Int(1))),
		},
		"ignoreSSL": tea.BoolValue(runtime.IgnoreSSL),
	}

	_resp := &GetSymlinkResponse{}
	for _retryTimes := 0; tea.BoolValue(tea.AllowRetry(_runtime["retry"], tea.Int(_retryTimes))); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], tea.Int(_retryTimes))
			if tea.IntValue(_backoffTime) > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, _err = func() (*GetSymlinkResponse, error) {
			request_ := tea.NewRequest()
			accessKeyId, _err := client.Credential.GetAccessKeyId()
			if _err != nil {
				return _result, _err
			}

			accessKeySecret, _err := client.Credential.GetAccessKeySecret()
			if _err != nil {
				return _result, _err
			}

			token, _err := client.Credential.GetSecurityToken()
			if _err != nil {
				return _result, _err
			}

			request_.Protocol = client.Protocol
			request_.Method = tea.String("GET")
			request_.Pathname = tea.String("/" + tea.StringValue(request.ObjectName) + "?symlink")
			request_.Headers = map[string]*string{
				"host":       ossutil.GetHost(request.BucketName, client.RegionId, client.Endpoint, client.HostModel),
				"date":       util.GetDateUTCString(),
				"user-agent": client.GetUserAgent(),
			}
			if !tea.BoolValue(util.Empty(token)) {
				request_.Headers["x-oss-security-token"] = token
			}

			request_.Headers["authorization"] = ossutil.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, client.SignatureVersion, client.AddtionalHeaders)
			response_, _err := tea.DoRequest(request_, _runtime)
			if _err != nil {
				return _result, _err
			}
			var respMap map[string]interface{}
			var bodyStr *string
			if tea.BoolValue(util.Is4xx(response_.StatusCode)) || tea.BoolValue(util.Is5xx(response_.StatusCode)) {
				bodyStr, _err = util.ReadAsString(response_.Body)
				if _err != nil {
					return _result, _err
				}

				respMap = ossutil.GetErrMessage(bodyStr)
				_err = tea.NewSDKError(map[string]interface{}{
					"code":    respMap["Code"],
					"message": respMap["Message"],
					"data": map[string]interface{}{
						"httpCode":  tea.IntValue(response_.StatusCode),
						"requestId": respMap["RequestId"],
						"hostId":    respMap["HostId"],
					},
				})
				return _result, _err
			}

			_result = &GetSymlinkResponse{}
			_err = tea.Convert(response_.Headers, &_result)
			return _result, _err
		}()
		if !tea.BoolValue(tea.Retryable(_err)) {
			break
		}
	}

	return _resp, _err
}

func (client *Client) GetBucketLifecycle(request *GetBucketLifecycleRequest, runtime *ossutil.RuntimeOptions) (_result *GetBucketLifecycleResponse, _err error) {
	_err = tea.Validate(request)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Validate(runtime)
	if _err != nil {
		return _result, _err
	}
	_runtime := map[string]interface{}{
		"timeouted":      "retry",
		"readTimeout":    tea.IntValue(util.DefaultNumber(runtime.ReadTimeout, client.ReadTimeout)),
		"connectTimeout": tea.IntValue(util.DefaultNumber(runtime.ConnectTimeout, client.ConnectTimeout)),
		"localAddr":      tea.StringValue(util.DefaultString(runtime.LocalAddr, client.LocalAddr)),
		"httpProxy":      tea.StringValue(util.DefaultString(runtime.HttpProxy, client.HttpProxy)),
		"httpsProxy":     tea.StringValue(util.DefaultString(runtime.HttpsProxy, client.HttpsProxy)),
		"noProxy":        tea.StringValue(util.DefaultString(runtime.NoProxy, client.NoProxy)),
		"socks5Proxy":    tea.StringValue(util.DefaultString(runtime.Socks5Proxy, client.Socks5Proxy)),
		"socks5NetWork":  tea.StringValue(util.DefaultString(runtime.Socks5NetWork, client.Socks5NetWork)),
		"maxIdleConns":   tea.IntValue(util.DefaultNumber(runtime.MaxIdleConns, client.MaxIdleConns)),
		"retry": map[string]interface{}{
			"retryable":   tea.BoolValue(runtime.Autoretry),
			"maxAttempts": tea.IntValue(util.DefaultNumber(runtime.MaxAttempts, tea.Int(3))),
		},
		"backoff": map[string]interface{}{
			"policy": tea.StringValue(util.DefaultString(runtime.BackoffPolicy, tea.String("no"))),
			"period": tea.IntValue(util.DefaultNumber(runtime.BackoffPeriod, tea.Int(1))),
		},
		"ignoreSSL": tea.BoolValue(runtime.IgnoreSSL),
	}

	_resp := &GetBucketLifecycleResponse{}
	for _retryTimes := 0; tea.BoolValue(tea.AllowRetry(_runtime["retry"], tea.Int(_retryTimes))); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], tea.Int(_retryTimes))
			if tea.IntValue(_backoffTime) > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, _err = func() (*GetBucketLifecycleResponse, error) {
			request_ := tea.NewRequest()
			accessKeyId, _err := client.Credential.GetAccessKeyId()
			if _err != nil {
				return _result, _err
			}

			accessKeySecret, _err := client.Credential.GetAccessKeySecret()
			if _err != nil {
				return _result, _err
			}

			token, _err := client.Credential.GetSecurityToken()
			if _err != nil {
				return _result, _err
			}

			request_.Protocol = client.Protocol
			request_.Method = tea.String("GET")
			request_.Pathname = tea.String("/?lifecycle")
			request_.Headers = map[string]*string{
				"host":       ossutil.GetHost(request.BucketName, client.RegionId, client.Endpoint, client.HostModel),
				"date":       util.GetDateUTCString(),
				"user-agent": client.GetUserAgent(),
			}
			if !tea.BoolValue(util.Empty(token)) {
				request_.Headers["x-oss-security-token"] = token
			}

			request_.Headers["authorization"] = ossutil.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, client.SignatureVersion, client.AddtionalHeaders)
			response_, _err := tea.DoRequest(request_, _runtime)
			if _err != nil {
				return _result, _err
			}
			var respMap map[string]interface{}
			var bodyStr *string
			if tea.BoolValue(util.Is4xx(response_.StatusCode)) || tea.BoolValue(util.Is5xx(response_.StatusCode)) {
				bodyStr, _err = util.ReadAsString(response_.Body)
				if _err != nil {
					return _result, _err
				}

				respMap = ossutil.GetErrMessage(bodyStr)
				_err = tea.NewSDKError(map[string]interface{}{
					"code":    respMap["Code"],
					"message": respMap["Message"],
					"data": map[string]interface{}{
						"httpCode":  tea.IntValue(response_.StatusCode),
						"requestId": respMap["RequestId"],
						"hostId":    respMap["HostId"],
					},
				})
				return _result, _err
			}

			bodyStr, _err = util.ReadAsString(response_.Body)
			if _err != nil {
				return _result, _err
			}

			respMap = xml.ParseXml(bodyStr, new(GetBucketLifecycleResponse))
			_result = &GetBucketLifecycleResponse{}
			_err = tea.Convert(tea.ToMap(map[string]interface{}{
				"LifecycleConfiguration": respMap["LifecycleConfiguration"],
			}, response_.Headers), &_result)
			return _result, _err
		}()
		if !tea.BoolValue(tea.Retryable(_err)) {
			break
		}
	}

	return _resp, _err
}

func (client *Client) PutSymlink(request *PutSymlinkRequest, runtime *ossutil.RuntimeOptions) (_result *PutSymlinkResponse, _err error) {
	_err = tea.Validate(request)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Validate(runtime)
	if _err != nil {
		return _result, _err
	}
	_runtime := map[string]interface{}{
		"timeouted":      "retry",
		"readTimeout":    tea.IntValue(util.DefaultNumber(runtime.ReadTimeout, client.ReadTimeout)),
		"connectTimeout": tea.IntValue(util.DefaultNumber(runtime.ConnectTimeout, client.ConnectTimeout)),
		"localAddr":      tea.StringValue(util.DefaultString(runtime.LocalAddr, client.LocalAddr)),
		"httpProxy":      tea.StringValue(util.DefaultString(runtime.HttpProxy, client.HttpProxy)),
		"httpsProxy":     tea.StringValue(util.DefaultString(runtime.HttpsProxy, client.HttpsProxy)),
		"noProxy":        tea.StringValue(util.DefaultString(runtime.NoProxy, client.NoProxy)),
		"socks5Proxy":    tea.StringValue(util.DefaultString(runtime.Socks5Proxy, client.Socks5Proxy)),
		"socks5NetWork":  tea.StringValue(util.DefaultString(runtime.Socks5NetWork, client.Socks5NetWork)),
		"maxIdleConns":   tea.IntValue(util.DefaultNumber(runtime.MaxIdleConns, client.MaxIdleConns)),
		"retry": map[string]interface{}{
			"retryable":   tea.BoolValue(runtime.Autoretry),
			"maxAttempts": tea.IntValue(util.DefaultNumber(runtime.MaxAttempts, tea.Int(3))),
		},
		"backoff": map[string]interface{}{
			"policy": tea.StringValue(util.DefaultString(runtime.BackoffPolicy, tea.String("no"))),
			"period": tea.IntValue(util.DefaultNumber(runtime.BackoffPeriod, tea.Int(1))),
		},
		"ignoreSSL": tea.BoolValue(runtime.IgnoreSSL),
	}

	_resp := &PutSymlinkResponse{}
	for _retryTimes := 0; tea.BoolValue(tea.AllowRetry(_runtime["retry"], tea.Int(_retryTimes))); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], tea.Int(_retryTimes))
			if tea.IntValue(_backoffTime) > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, _err = func() (*PutSymlinkResponse, error) {
			request_ := tea.NewRequest()
			accessKeyId, _err := client.Credential.GetAccessKeyId()
			if _err != nil {
				return _result, _err
			}

			accessKeySecret, _err := client.Credential.GetAccessKeySecret()
			if _err != nil {
				return _result, _err
			}

			token, _err := client.Credential.GetSecurityToken()
			if _err != nil {
				return _result, _err
			}

			request_.Protocol = client.Protocol
			request_.Method = tea.String("PUT")
			request_.Pathname = tea.String("/" + tea.StringValue(request.ObjectName) + "?symlink")
			request_.Headers = tea.Merge(map[string]*string{
				"host":       ossutil.GetHost(request.BucketName, client.RegionId, client.Endpoint, client.HostModel),
				"date":       util.GetDateUTCString(),
				"user-agent": client.GetUserAgent(),
			}, util.StringifyMapValue(tea.ToMap(request.Header)))
			if !tea.BoolValue(util.Empty(token)) {
				request_.Headers["x-oss-security-token"] = token
			}

			request_.Headers["authorization"] = ossutil.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, client.SignatureVersion, client.AddtionalHeaders)
			response_, _err := tea.DoRequest(request_, _runtime)
			if _err != nil {
				return _result, _err
			}
			var respMap map[string]interface{}
			var bodyStr *string
			if tea.BoolValue(util.Is4xx(response_.StatusCode)) || tea.BoolValue(util.Is5xx(response_.StatusCode)) {
				bodyStr, _err = util.ReadAsString(response_.Body)
				if _err != nil {
					return _result, _err
				}

				respMap = ossutil.GetErrMessage(bodyStr)
				_err = tea.NewSDKError(map[string]interface{}{
					"code":    respMap["Code"],
					"message": respMap["Message"],
					"data": map[string]interface{}{
						"httpCode":  tea.IntValue(response_.StatusCode),
						"requestId": respMap["RequestId"],
						"hostId":    respMap["HostId"],
					},
				})
				return _result, _err
			}

			_result = &PutSymlinkResponse{}
			_err = tea.Convert(response_.Headers, &_result)
			return _result, _err
		}()
		if !tea.BoolValue(tea.Retryable(_err)) {
			break
		}
	}

	return _resp, _err
}

func (client *Client) GetBucketReferer(request *GetBucketRefererRequest, runtime *ossutil.RuntimeOptions) (_result *GetBucketRefererResponse, _err error) {
	_err = tea.Validate(request)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Validate(runtime)
	if _err != nil {
		return _result, _err
	}
	_runtime := map[string]interface{}{
		"timeouted":      "retry",
		"readTimeout":    tea.IntValue(util.DefaultNumber(runtime.ReadTimeout, client.ReadTimeout)),
		"connectTimeout": tea.IntValue(util.DefaultNumber(runtime.ConnectTimeout, client.ConnectTimeout)),
		"localAddr":      tea.StringValue(util.DefaultString(runtime.LocalAddr, client.LocalAddr)),
		"httpProxy":      tea.StringValue(util.DefaultString(runtime.HttpProxy, client.HttpProxy)),
		"httpsProxy":     tea.StringValue(util.DefaultString(runtime.HttpsProxy, client.HttpsProxy)),
		"noProxy":        tea.StringValue(util.DefaultString(runtime.NoProxy, client.NoProxy)),
		"socks5Proxy":    tea.StringValue(util.DefaultString(runtime.Socks5Proxy, client.Socks5Proxy)),
		"socks5NetWork":  tea.StringValue(util.DefaultString(runtime.Socks5NetWork, client.Socks5NetWork)),
		"maxIdleConns":   tea.IntValue(util.DefaultNumber(runtime.MaxIdleConns, client.MaxIdleConns)),
		"retry": map[string]interface{}{
			"retryable":   tea.BoolValue(runtime.Autoretry),
			"maxAttempts": tea.IntValue(util.DefaultNumber(runtime.MaxAttempts, tea.Int(3))),
		},
		"backoff": map[string]interface{}{
			"policy": tea.StringValue(util.DefaultString(runtime.BackoffPolicy, tea.String("no"))),
			"period": tea.IntValue(util.DefaultNumber(runtime.BackoffPeriod, tea.Int(1))),
		},
		"ignoreSSL": tea.BoolValue(runtime.IgnoreSSL),
	}

	_resp := &GetBucketRefererResponse{}
	for _retryTimes := 0; tea.BoolValue(tea.AllowRetry(_runtime["retry"], tea.Int(_retryTimes))); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], tea.Int(_retryTimes))
			if tea.IntValue(_backoffTime) > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, _err = func() (*GetBucketRefererResponse, error) {
			request_ := tea.NewRequest()
			accessKeyId, _err := client.Credential.GetAccessKeyId()
			if _err != nil {
				return _result, _err
			}

			accessKeySecret, _err := client.Credential.GetAccessKeySecret()
			if _err != nil {
				return _result, _err
			}

			token, _err := client.Credential.GetSecurityToken()
			if _err != nil {
				return _result, _err
			}

			request_.Protocol = client.Protocol
			request_.Method = tea.String("GET")
			request_.Pathname = tea.String("/?referer")
			request_.Headers = map[string]*string{
				"host":       ossutil.GetHost(request.BucketName, client.RegionId, client.Endpoint, client.HostModel),
				"date":       util.GetDateUTCString(),
				"user-agent": client.GetUserAgent(),
			}
			if !tea.BoolValue(util.Empty(token)) {
				request_.Headers["x-oss-security-token"] = token
			}

			request_.Headers["authorization"] = ossutil.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, client.SignatureVersion, client.AddtionalHeaders)
			response_, _err := tea.DoRequest(request_, _runtime)
			if _err != nil {
				return _result, _err
			}
			var respMap map[string]interface{}
			var bodyStr *string
			if tea.BoolValue(util.Is4xx(response_.StatusCode)) || tea.BoolValue(util.Is5xx(response_.StatusCode)) {
				bodyStr, _err = util.ReadAsString(response_.Body)
				if _err != nil {
					return _result, _err
				}

				respMap = ossutil.GetErrMessage(bodyStr)
				_err = tea.NewSDKError(map[string]interface{}{
					"code":    respMap["Code"],
					"message": respMap["Message"],
					"data": map[string]interface{}{
						"httpCode":  tea.IntValue(response_.StatusCode),
						"requestId": respMap["RequestId"],
						"hostId":    respMap["HostId"],
					},
				})
				return _result, _err
			}

			bodyStr, _err = util.ReadAsString(response_.Body)
			if _err != nil {
				return _result, _err
			}

			respMap = xml.ParseXml(bodyStr, new(GetBucketRefererResponse))
			_result = &GetBucketRefererResponse{}
			_err = tea.Convert(tea.ToMap(map[string]interface{}{
				"RefererConfiguration": respMap["RefererConfiguration"],
			}, response_.Headers), &_result)
			return _result, _err
		}()
		if !tea.BoolValue(tea.Retryable(_err)) {
			break
		}
	}

	return _resp, _err
}

func (client *Client) Callback(request *CallbackRequest, runtime *ossutil.RuntimeOptions) (_result *CallbackResponse, _err error) {
	_err = tea.Validate(request)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Validate(runtime)
	if _err != nil {
		return _result, _err
	}
	_runtime := map[string]interface{}{
		"timeouted":      "retry",
		"readTimeout":    tea.IntValue(util.DefaultNumber(runtime.ReadTimeout, client.ReadTimeout)),
		"connectTimeout": tea.IntValue(util.DefaultNumber(runtime.ConnectTimeout, client.ConnectTimeout)),
		"localAddr":      tea.StringValue(util.DefaultString(runtime.LocalAddr, client.LocalAddr)),
		"httpProxy":      tea.StringValue(util.DefaultString(runtime.HttpProxy, client.HttpProxy)),
		"httpsProxy":     tea.StringValue(util.DefaultString(runtime.HttpsProxy, client.HttpsProxy)),
		"noProxy":        tea.StringValue(util.DefaultString(runtime.NoProxy, client.NoProxy)),
		"socks5Proxy":    tea.StringValue(util.DefaultString(runtime.Socks5Proxy, client.Socks5Proxy)),
		"socks5NetWork":  tea.StringValue(util.DefaultString(runtime.Socks5NetWork, client.Socks5NetWork)),
		"maxIdleConns":   tea.IntValue(util.DefaultNumber(runtime.MaxIdleConns, client.MaxIdleConns)),
		"retry": map[string]interface{}{
			"retryable":   tea.BoolValue(runtime.Autoretry),
			"maxAttempts": tea.IntValue(util.DefaultNumber(runtime.MaxAttempts, tea.Int(3))),
		},
		"backoff": map[string]interface{}{
			"policy": tea.StringValue(util.DefaultString(runtime.BackoffPolicy, tea.String("no"))),
			"period": tea.IntValue(util.DefaultNumber(runtime.BackoffPeriod, tea.Int(1))),
		},
		"ignoreSSL": tea.BoolValue(runtime.IgnoreSSL),
	}

	_resp := &CallbackResponse{}
	for _retryTimes := 0; tea.BoolValue(tea.AllowRetry(_runtime["retry"], tea.Int(_retryTimes))); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], tea.Int(_retryTimes))
			if tea.IntValue(_backoffTime) > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, _err = func() (*CallbackResponse, error) {
			request_ := tea.NewRequest()
			accessKeyId, _err := client.Credential.GetAccessKeyId()
			if _err != nil {
				return _result, _err
			}

			accessKeySecret, _err := client.Credential.GetAccessKeySecret()
			if _err != nil {
				return _result, _err
			}

			token, _err := client.Credential.GetSecurityToken()
			if _err != nil {
				return _result, _err
			}

			request_.Protocol = client.Protocol
			request_.Method = tea.String("GET")
			request_.Pathname = tea.String("/")
			request_.Headers = map[string]*string{
				"host":       ossutil.GetHost(request.BucketName, client.RegionId, client.Endpoint, client.HostModel),
				"date":       util.GetDateUTCString(),
				"user-agent": client.GetUserAgent(),
			}
			if !tea.BoolValue(util.Empty(token)) {
				request_.Headers["x-oss-security-token"] = token
			}

			request_.Headers["authorization"] = ossutil.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, client.SignatureVersion, client.AddtionalHeaders)
			response_, _err := tea.DoRequest(request_, _runtime)
			if _err != nil {
				return _result, _err
			}
			var respMap map[string]interface{}
			var bodyStr *string
			if tea.BoolValue(util.Is4xx(response_.StatusCode)) || tea.BoolValue(util.Is5xx(response_.StatusCode)) {
				bodyStr, _err = util.ReadAsString(response_.Body)
				if _err != nil {
					return _result, _err
				}

				respMap = ossutil.GetErrMessage(bodyStr)
				_err = tea.NewSDKError(map[string]interface{}{
					"code":    respMap["Code"],
					"message": respMap["Message"],
					"data": map[string]interface{}{
						"httpCode":  tea.IntValue(response_.StatusCode),
						"requestId": respMap["RequestId"],
						"hostId":    respMap["HostId"],
					},
				})
				return _result, _err
			}

			_result = &CallbackResponse{}
			_err = tea.Convert(response_.Headers, &_result)
			return _result, _err
		}()
		if !tea.BoolValue(tea.Retryable(_err)) {
			break
		}
	}

	return _resp, _err
}

func (client *Client) GetBucketLogging(request *GetBucketLoggingRequest, runtime *ossutil.RuntimeOptions) (_result *GetBucketLoggingResponse, _err error) {
	_err = tea.Validate(request)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Validate(runtime)
	if _err != nil {
		return _result, _err
	}
	_runtime := map[string]interface{}{
		"timeouted":      "retry",
		"readTimeout":    tea.IntValue(util.DefaultNumber(runtime.ReadTimeout, client.ReadTimeout)),
		"connectTimeout": tea.IntValue(util.DefaultNumber(runtime.ConnectTimeout, client.ConnectTimeout)),
		"localAddr":      tea.StringValue(util.DefaultString(runtime.LocalAddr, client.LocalAddr)),
		"httpProxy":      tea.StringValue(util.DefaultString(runtime.HttpProxy, client.HttpProxy)),
		"httpsProxy":     tea.StringValue(util.DefaultString(runtime.HttpsProxy, client.HttpsProxy)),
		"noProxy":        tea.StringValue(util.DefaultString(runtime.NoProxy, client.NoProxy)),
		"socks5Proxy":    tea.StringValue(util.DefaultString(runtime.Socks5Proxy, client.Socks5Proxy)),
		"socks5NetWork":  tea.StringValue(util.DefaultString(runtime.Socks5NetWork, client.Socks5NetWork)),
		"maxIdleConns":   tea.IntValue(util.DefaultNumber(runtime.MaxIdleConns, client.MaxIdleConns)),
		"retry": map[string]interface{}{
			"retryable":   tea.BoolValue(runtime.Autoretry),
			"maxAttempts": tea.IntValue(util.DefaultNumber(runtime.MaxAttempts, tea.Int(3))),
		},
		"backoff": map[string]interface{}{
			"policy": tea.StringValue(util.DefaultString(runtime.BackoffPolicy, tea.String("no"))),
			"period": tea.IntValue(util.DefaultNumber(runtime.BackoffPeriod, tea.Int(1))),
		},
		"ignoreSSL": tea.BoolValue(runtime.IgnoreSSL),
	}

	_resp := &GetBucketLoggingResponse{}
	for _retryTimes := 0; tea.BoolValue(tea.AllowRetry(_runtime["retry"], tea.Int(_retryTimes))); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], tea.Int(_retryTimes))
			if tea.IntValue(_backoffTime) > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, _err = func() (*GetBucketLoggingResponse, error) {
			request_ := tea.NewRequest()
			accessKeyId, _err := client.Credential.GetAccessKeyId()
			if _err != nil {
				return _result, _err
			}

			accessKeySecret, _err := client.Credential.GetAccessKeySecret()
			if _err != nil {
				return _result, _err
			}

			token, _err := client.Credential.GetSecurityToken()
			if _err != nil {
				return _result, _err
			}

			request_.Protocol = client.Protocol
			request_.Method = tea.String("GET")
			request_.Pathname = tea.String("/?logging")
			request_.Headers = map[string]*string{
				"host":       ossutil.GetHost(request.BucketName, client.RegionId, client.Endpoint, client.HostModel),
				"date":       util.GetDateUTCString(),
				"user-agent": client.GetUserAgent(),
			}
			if !tea.BoolValue(util.Empty(token)) {
				request_.Headers["x-oss-security-token"] = token
			}

			request_.Headers["authorization"] = ossutil.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, client.SignatureVersion, client.AddtionalHeaders)
			response_, _err := tea.DoRequest(request_, _runtime)
			if _err != nil {
				return _result, _err
			}
			var respMap map[string]interface{}
			var bodyStr *string
			if tea.BoolValue(util.Is4xx(response_.StatusCode)) || tea.BoolValue(util.Is5xx(response_.StatusCode)) {
				bodyStr, _err = util.ReadAsString(response_.Body)
				if _err != nil {
					return _result, _err
				}

				respMap = ossutil.GetErrMessage(bodyStr)
				_err = tea.NewSDKError(map[string]interface{}{
					"code":    respMap["Code"],
					"message": respMap["Message"],
					"data": map[string]interface{}{
						"httpCode":  tea.IntValue(response_.StatusCode),
						"requestId": respMap["RequestId"],
						"hostId":    respMap["HostId"],
					},
				})
				return _result, _err
			}

			bodyStr, _err = util.ReadAsString(response_.Body)
			if _err != nil {
				return _result, _err
			}

			respMap = xml.ParseXml(bodyStr, new(GetBucketLoggingResponse))
			_result = &GetBucketLoggingResponse{}
			_err = tea.Convert(tea.ToMap(map[string]interface{}{
				"BucketLoggingStatus": respMap["BucketLoggingStatus"],
			}, response_.Headers), &_result)
			return _result, _err
		}()
		if !tea.BoolValue(tea.Retryable(_err)) {
			break
		}
	}

	return _resp, _err
}

func (client *Client) PutObjectAcl(request *PutObjectAclRequest, runtime *ossutil.RuntimeOptions) (_result *PutObjectAclResponse, _err error) {
	_err = tea.Validate(request)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Validate(runtime)
	if _err != nil {
		return _result, _err
	}
	_runtime := map[string]interface{}{
		"timeouted":      "retry",
		"readTimeout":    tea.IntValue(util.DefaultNumber(runtime.ReadTimeout, client.ReadTimeout)),
		"connectTimeout": tea.IntValue(util.DefaultNumber(runtime.ConnectTimeout, client.ConnectTimeout)),
		"localAddr":      tea.StringValue(util.DefaultString(runtime.LocalAddr, client.LocalAddr)),
		"httpProxy":      tea.StringValue(util.DefaultString(runtime.HttpProxy, client.HttpProxy)),
		"httpsProxy":     tea.StringValue(util.DefaultString(runtime.HttpsProxy, client.HttpsProxy)),
		"noProxy":        tea.StringValue(util.DefaultString(runtime.NoProxy, client.NoProxy)),
		"socks5Proxy":    tea.StringValue(util.DefaultString(runtime.Socks5Proxy, client.Socks5Proxy)),
		"socks5NetWork":  tea.StringValue(util.DefaultString(runtime.Socks5NetWork, client.Socks5NetWork)),
		"maxIdleConns":   tea.IntValue(util.DefaultNumber(runtime.MaxIdleConns, client.MaxIdleConns)),
		"retry": map[string]interface{}{
			"retryable":   tea.BoolValue(runtime.Autoretry),
			"maxAttempts": tea.IntValue(util.DefaultNumber(runtime.MaxAttempts, tea.Int(3))),
		},
		"backoff": map[string]interface{}{
			"policy": tea.StringValue(util.DefaultString(runtime.BackoffPolicy, tea.String("no"))),
			"period": tea.IntValue(util.DefaultNumber(runtime.BackoffPeriod, tea.Int(1))),
		},
		"ignoreSSL": tea.BoolValue(runtime.IgnoreSSL),
	}

	_resp := &PutObjectAclResponse{}
	for _retryTimes := 0; tea.BoolValue(tea.AllowRetry(_runtime["retry"], tea.Int(_retryTimes))); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], tea.Int(_retryTimes))
			if tea.IntValue(_backoffTime) > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, _err = func() (*PutObjectAclResponse, error) {
			request_ := tea.NewRequest()
			accessKeyId, _err := client.Credential.GetAccessKeyId()
			if _err != nil {
				return _result, _err
			}

			accessKeySecret, _err := client.Credential.GetAccessKeySecret()
			if _err != nil {
				return _result, _err
			}

			token, _err := client.Credential.GetSecurityToken()
			if _err != nil {
				return _result, _err
			}

			request_.Protocol = client.Protocol
			request_.Method = tea.String("PUT")
			request_.Pathname = tea.String("/" + tea.StringValue(request.ObjectName) + "?acl")
			request_.Headers = tea.Merge(map[string]*string{
				"host":       ossutil.GetHost(request.BucketName, client.RegionId, client.Endpoint, client.HostModel),
				"date":       util.GetDateUTCString(),
				"user-agent": client.GetUserAgent(),
			}, util.StringifyMapValue(tea.ToMap(request.Header)))
			if !tea.BoolValue(util.Empty(token)) {
				request_.Headers["x-oss-security-token"] = token
			}

			request_.Headers["authorization"] = ossutil.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, client.SignatureVersion, client.AddtionalHeaders)
			response_, _err := tea.DoRequest(request_, _runtime)
			if _err != nil {
				return _result, _err
			}
			var respMap map[string]interface{}
			var bodyStr *string
			if tea.BoolValue(util.Is4xx(response_.StatusCode)) || tea.BoolValue(util.Is5xx(response_.StatusCode)) {
				bodyStr, _err = util.ReadAsString(response_.Body)
				if _err != nil {
					return _result, _err
				}

				respMap = ossutil.GetErrMessage(bodyStr)
				_err = tea.NewSDKError(map[string]interface{}{
					"code":    respMap["Code"],
					"message": respMap["Message"],
					"data": map[string]interface{}{
						"httpCode":  tea.IntValue(response_.StatusCode),
						"requestId": respMap["RequestId"],
						"hostId":    respMap["HostId"],
					},
				})
				return _result, _err
			}

			_result = &PutObjectAclResponse{}
			_err = tea.Convert(response_.Headers, &_result)
			return _result, _err
		}()
		if !tea.BoolValue(tea.Retryable(_err)) {
			break
		}
	}

	return _resp, _err
}

func (client *Client) GetBucketInfo(request *GetBucketInfoRequest, runtime *ossutil.RuntimeOptions) (_result *GetBucketInfoResponse, _err error) {
	_err = tea.Validate(request)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Validate(runtime)
	if _err != nil {
		return _result, _err
	}
	_runtime := map[string]interface{}{
		"timeouted":      "retry",
		"readTimeout":    tea.IntValue(util.DefaultNumber(runtime.ReadTimeout, client.ReadTimeout)),
		"connectTimeout": tea.IntValue(util.DefaultNumber(runtime.ConnectTimeout, client.ConnectTimeout)),
		"localAddr":      tea.StringValue(util.DefaultString(runtime.LocalAddr, client.LocalAddr)),
		"httpProxy":      tea.StringValue(util.DefaultString(runtime.HttpProxy, client.HttpProxy)),
		"httpsProxy":     tea.StringValue(util.DefaultString(runtime.HttpsProxy, client.HttpsProxy)),
		"noProxy":        tea.StringValue(util.DefaultString(runtime.NoProxy, client.NoProxy)),
		"socks5Proxy":    tea.StringValue(util.DefaultString(runtime.Socks5Proxy, client.Socks5Proxy)),
		"socks5NetWork":  tea.StringValue(util.DefaultString(runtime.Socks5NetWork, client.Socks5NetWork)),
		"maxIdleConns":   tea.IntValue(util.DefaultNumber(runtime.MaxIdleConns, client.MaxIdleConns)),
		"retry": map[string]interface{}{
			"retryable":   tea.BoolValue(runtime.Autoretry),
			"maxAttempts": tea.IntValue(util.DefaultNumber(runtime.MaxAttempts, tea.Int(3))),
		},
		"backoff": map[string]interface{}{
			"policy": tea.StringValue(util.DefaultString(runtime.BackoffPolicy, tea.String("no"))),
			"period": tea.IntValue(util.DefaultNumber(runtime.BackoffPeriod, tea.Int(1))),
		},
		"ignoreSSL": tea.BoolValue(runtime.IgnoreSSL),
	}

	_resp := &GetBucketInfoResponse{}
	for _retryTimes := 0; tea.BoolValue(tea.AllowRetry(_runtime["retry"], tea.Int(_retryTimes))); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], tea.Int(_retryTimes))
			if tea.IntValue(_backoffTime) > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, _err = func() (*GetBucketInfoResponse, error) {
			request_ := tea.NewRequest()
			accessKeyId, _err := client.Credential.GetAccessKeyId()
			if _err != nil {
				return _result, _err
			}

			accessKeySecret, _err := client.Credential.GetAccessKeySecret()
			if _err != nil {
				return _result, _err
			}

			token, _err := client.Credential.GetSecurityToken()
			if _err != nil {
				return _result, _err
			}

			request_.Protocol = client.Protocol
			request_.Method = tea.String("GET")
			request_.Pathname = tea.String("/?bucketInfo")
			request_.Headers = map[string]*string{
				"host":       ossutil.GetHost(request.BucketName, client.RegionId, client.Endpoint, client.HostModel),
				"date":       util.GetDateUTCString(),
				"user-agent": client.GetUserAgent(),
			}
			if !tea.BoolValue(util.Empty(token)) {
				request_.Headers["x-oss-security-token"] = token
			}

			request_.Headers["authorization"] = ossutil.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, client.SignatureVersion, client.AddtionalHeaders)
			response_, _err := tea.DoRequest(request_, _runtime)
			if _err != nil {
				return _result, _err
			}
			var respMap map[string]interface{}
			var bodyStr *string
			if tea.BoolValue(util.Is4xx(response_.StatusCode)) || tea.BoolValue(util.Is5xx(response_.StatusCode)) {
				bodyStr, _err = util.ReadAsString(response_.Body)
				if _err != nil {
					return _result, _err
				}

				respMap = ossutil.GetErrMessage(bodyStr)
				_err = tea.NewSDKError(map[string]interface{}{
					"code":    respMap["Code"],
					"message": respMap["Message"],
					"data": map[string]interface{}{
						"httpCode":  tea.IntValue(response_.StatusCode),
						"requestId": respMap["RequestId"],
						"hostId":    respMap["HostId"],
					},
				})
				return _result, _err
			}

			bodyStr, _err = util.ReadAsString(response_.Body)
			if _err != nil {
				return _result, _err
			}

			respMap = xml.ParseXml(bodyStr, new(GetBucketInfoResponse))
			_result = &GetBucketInfoResponse{}
			_err = tea.Convert(tea.ToMap(map[string]interface{}{
				"BucketInfo": respMap["BucketInfo"],
			}, response_.Headers), &_result)
			return _result, _err
		}()
		if !tea.BoolValue(tea.Retryable(_err)) {
			break
		}
	}

	return _resp, _err
}

func (client *Client) PutLiveChannelStatus(request *PutLiveChannelStatusRequest, runtime *ossutil.RuntimeOptions) (_result *PutLiveChannelStatusResponse, _err error) {
	_err = tea.Validate(request)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Validate(runtime)
	if _err != nil {
		return _result, _err
	}
	_runtime := map[string]interface{}{
		"timeouted":      "retry",
		"readTimeout":    tea.IntValue(util.DefaultNumber(runtime.ReadTimeout, client.ReadTimeout)),
		"connectTimeout": tea.IntValue(util.DefaultNumber(runtime.ConnectTimeout, client.ConnectTimeout)),
		"localAddr":      tea.StringValue(util.DefaultString(runtime.LocalAddr, client.LocalAddr)),
		"httpProxy":      tea.StringValue(util.DefaultString(runtime.HttpProxy, client.HttpProxy)),
		"httpsProxy":     tea.StringValue(util.DefaultString(runtime.HttpsProxy, client.HttpsProxy)),
		"noProxy":        tea.StringValue(util.DefaultString(runtime.NoProxy, client.NoProxy)),
		"socks5Proxy":    tea.StringValue(util.DefaultString(runtime.Socks5Proxy, client.Socks5Proxy)),
		"socks5NetWork":  tea.StringValue(util.DefaultString(runtime.Socks5NetWork, client.Socks5NetWork)),
		"maxIdleConns":   tea.IntValue(util.DefaultNumber(runtime.MaxIdleConns, client.MaxIdleConns)),
		"retry": map[string]interface{}{
			"retryable":   tea.BoolValue(runtime.Autoretry),
			"maxAttempts": tea.IntValue(util.DefaultNumber(runtime.MaxAttempts, tea.Int(3))),
		},
		"backoff": map[string]interface{}{
			"policy": tea.StringValue(util.DefaultString(runtime.BackoffPolicy, tea.String("no"))),
			"period": tea.IntValue(util.DefaultNumber(runtime.BackoffPeriod, tea.Int(1))),
		},
		"ignoreSSL": tea.BoolValue(runtime.IgnoreSSL),
	}

	_resp := &PutLiveChannelStatusResponse{}
	for _retryTimes := 0; tea.BoolValue(tea.AllowRetry(_runtime["retry"], tea.Int(_retryTimes))); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], tea.Int(_retryTimes))
			if tea.IntValue(_backoffTime) > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, _err = func() (*PutLiveChannelStatusResponse, error) {
			request_ := tea.NewRequest()
			accessKeyId, _err := client.Credential.GetAccessKeyId()
			if _err != nil {
				return _result, _err
			}

			accessKeySecret, _err := client.Credential.GetAccessKeySecret()
			if _err != nil {
				return _result, _err
			}

			token, _err := client.Credential.GetSecurityToken()
			if _err != nil {
				return _result, _err
			}

			request_.Protocol = client.Protocol
			request_.Method = tea.String("PUT")
			request_.Pathname = tea.String("/" + tea.StringValue(request.ChannelName) + "?live")
			request_.Headers = map[string]*string{
				"host":       ossutil.GetHost(request.BucketName, client.RegionId, client.Endpoint, client.HostModel),
				"date":       util.GetDateUTCString(),
				"user-agent": client.GetUserAgent(),
			}
			if !tea.BoolValue(util.Empty(token)) {
				request_.Headers["x-oss-security-token"] = token
			}

			request_.Query = util.StringifyMapValue(tea.ToMap(request.Filter))
			request_.Headers["authorization"] = ossutil.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, client.SignatureVersion, client.AddtionalHeaders)
			response_, _err := tea.DoRequest(request_, _runtime)
			if _err != nil {
				return _result, _err
			}
			var respMap map[string]interface{}
			var bodyStr *string
			if tea.BoolValue(util.Is4xx(response_.StatusCode)) || tea.BoolValue(util.Is5xx(response_.StatusCode)) {
				bodyStr, _err = util.ReadAsString(response_.Body)
				if _err != nil {
					return _result, _err
				}

				respMap = ossutil.GetErrMessage(bodyStr)
				_err = tea.NewSDKError(map[string]interface{}{
					"code":    respMap["Code"],
					"message": respMap["Message"],
					"data": map[string]interface{}{
						"httpCode":  tea.IntValue(response_.StatusCode),
						"requestId": respMap["RequestId"],
						"hostId":    respMap["HostId"],
					},
				})
				return _result, _err
			}

			_result = &PutLiveChannelStatusResponse{}
			_err = tea.Convert(response_.Headers, &_result)
			return _result, _err
		}()
		if !tea.BoolValue(tea.Retryable(_err)) {
			break
		}
	}

	return _resp, _err
}

func (client *Client) InitiateMultipartUpload(request *InitiateMultipartUploadRequest, runtime *ossutil.RuntimeOptions) (_result *InitiateMultipartUploadResponse, _err error) {
	_err = tea.Validate(request)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Validate(runtime)
	if _err != nil {
		return _result, _err
	}
	_runtime := map[string]interface{}{
		"timeouted":      "retry",
		"readTimeout":    tea.IntValue(util.DefaultNumber(runtime.ReadTimeout, client.ReadTimeout)),
		"connectTimeout": tea.IntValue(util.DefaultNumber(runtime.ConnectTimeout, client.ConnectTimeout)),
		"localAddr":      tea.StringValue(util.DefaultString(runtime.LocalAddr, client.LocalAddr)),
		"httpProxy":      tea.StringValue(util.DefaultString(runtime.HttpProxy, client.HttpProxy)),
		"httpsProxy":     tea.StringValue(util.DefaultString(runtime.HttpsProxy, client.HttpsProxy)),
		"noProxy":        tea.StringValue(util.DefaultString(runtime.NoProxy, client.NoProxy)),
		"socks5Proxy":    tea.StringValue(util.DefaultString(runtime.Socks5Proxy, client.Socks5Proxy)),
		"socks5NetWork":  tea.StringValue(util.DefaultString(runtime.Socks5NetWork, client.Socks5NetWork)),
		"maxIdleConns":   tea.IntValue(util.DefaultNumber(runtime.MaxIdleConns, client.MaxIdleConns)),
		"retry": map[string]interface{}{
			"retryable":   tea.BoolValue(runtime.Autoretry),
			"maxAttempts": tea.IntValue(util.DefaultNumber(runtime.MaxAttempts, tea.Int(3))),
		},
		"backoff": map[string]interface{}{
			"policy": tea.StringValue(util.DefaultString(runtime.BackoffPolicy, tea.String("no"))),
			"period": tea.IntValue(util.DefaultNumber(runtime.BackoffPeriod, tea.Int(1))),
		},
		"ignoreSSL": tea.BoolValue(runtime.IgnoreSSL),
	}

	_resp := &InitiateMultipartUploadResponse{}
	for _retryTimes := 0; tea.BoolValue(tea.AllowRetry(_runtime["retry"], tea.Int(_retryTimes))); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], tea.Int(_retryTimes))
			if tea.IntValue(_backoffTime) > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, _err = func() (*InitiateMultipartUploadResponse, error) {
			request_ := tea.NewRequest()
			accessKeyId, _err := client.Credential.GetAccessKeyId()
			if _err != nil {
				return _result, _err
			}

			accessKeySecret, _err := client.Credential.GetAccessKeySecret()
			if _err != nil {
				return _result, _err
			}

			token, _err := client.Credential.GetSecurityToken()
			if _err != nil {
				return _result, _err
			}

			request_.Protocol = client.Protocol
			request_.Method = tea.String("POST")
			request_.Pathname = tea.String("/" + tea.StringValue(request.ObjectName) + "?uploads")
			request_.Headers = tea.Merge(map[string]*string{
				"host":       ossutil.GetHost(request.BucketName, client.RegionId, client.Endpoint, client.HostModel),
				"date":       util.GetDateUTCString(),
				"user-agent": client.GetUserAgent(),
			}, util.StringifyMapValue(tea.ToMap(request.Header)))
			if !tea.BoolValue(util.Empty(token)) {
				request_.Headers["x-oss-security-token"] = token
			}

			request_.Query = util.StringifyMapValue(tea.ToMap(request.Filter))
			if !tea.BoolValue(util.IsUnset(tea.ToMap(request.Header))) && !tea.BoolValue(util.Empty(request.Header.ContentType)) {
				request_.Headers["content-type"] = request.Header.ContentType
			} else {
				request_.Headers["content-type"] = ossutil.GetContentType(request.ObjectName)
			}

			request_.Headers["authorization"] = ossutil.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, client.SignatureVersion, client.AddtionalHeaders)
			response_, _err := tea.DoRequest(request_, _runtime)
			if _err != nil {
				return _result, _err
			}
			var respMap map[string]interface{}
			var bodyStr *string
			if tea.BoolValue(util.Is4xx(response_.StatusCode)) || tea.BoolValue(util.Is5xx(response_.StatusCode)) {
				bodyStr, _err = util.ReadAsString(response_.Body)
				if _err != nil {
					return _result, _err
				}

				respMap = ossutil.GetErrMessage(bodyStr)
				_err = tea.NewSDKError(map[string]interface{}{
					"code":    respMap["Code"],
					"message": respMap["Message"],
					"data": map[string]interface{}{
						"httpCode":  tea.IntValue(response_.StatusCode),
						"requestId": respMap["RequestId"],
						"hostId":    respMap["HostId"],
					},
				})
				return _result, _err
			}

			bodyStr, _err = util.ReadAsString(response_.Body)
			if _err != nil {
				return _result, _err
			}

			respMap = xml.ParseXml(bodyStr, new(InitiateMultipartUploadResponse))
			_result = &InitiateMultipartUploadResponse{}
			_err = tea.Convert(tea.ToMap(map[string]interface{}{
				"InitiateMultipartUploadResult": respMap["InitiateMultipartUploadResult"],
			}, response_.Headers), &_result)
			return _result, _err
		}()
		if !tea.BoolValue(tea.Retryable(_err)) {
			break
		}
	}

	return _resp, _err
}

func (client *Client) OptionObject(request *OptionObjectRequest, runtime *ossutil.RuntimeOptions) (_result *OptionObjectResponse, _err error) {
	_err = tea.Validate(request)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Validate(runtime)
	if _err != nil {
		return _result, _err
	}
	_runtime := map[string]interface{}{
		"timeouted":      "retry",
		"readTimeout":    tea.IntValue(util.DefaultNumber(runtime.ReadTimeout, client.ReadTimeout)),
		"connectTimeout": tea.IntValue(util.DefaultNumber(runtime.ConnectTimeout, client.ConnectTimeout)),
		"localAddr":      tea.StringValue(util.DefaultString(runtime.LocalAddr, client.LocalAddr)),
		"httpProxy":      tea.StringValue(util.DefaultString(runtime.HttpProxy, client.HttpProxy)),
		"httpsProxy":     tea.StringValue(util.DefaultString(runtime.HttpsProxy, client.HttpsProxy)),
		"noProxy":        tea.StringValue(util.DefaultString(runtime.NoProxy, client.NoProxy)),
		"socks5Proxy":    tea.StringValue(util.DefaultString(runtime.Socks5Proxy, client.Socks5Proxy)),
		"socks5NetWork":  tea.StringValue(util.DefaultString(runtime.Socks5NetWork, client.Socks5NetWork)),
		"maxIdleConns":   tea.IntValue(util.DefaultNumber(runtime.MaxIdleConns, client.MaxIdleConns)),
		"retry": map[string]interface{}{
			"retryable":   tea.BoolValue(runtime.Autoretry),
			"maxAttempts": tea.IntValue(util.DefaultNumber(runtime.MaxAttempts, tea.Int(3))),
		},
		"backoff": map[string]interface{}{
			"policy": tea.StringValue(util.DefaultString(runtime.BackoffPolicy, tea.String("no"))),
			"period": tea.IntValue(util.DefaultNumber(runtime.BackoffPeriod, tea.Int(1))),
		},
		"ignoreSSL": tea.BoolValue(runtime.IgnoreSSL),
	}

	_resp := &OptionObjectResponse{}
	for _retryTimes := 0; tea.BoolValue(tea.AllowRetry(_runtime["retry"], tea.Int(_retryTimes))); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], tea.Int(_retryTimes))
			if tea.IntValue(_backoffTime) > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, _err = func() (*OptionObjectResponse, error) {
			request_ := tea.NewRequest()
			accessKeyId, _err := client.Credential.GetAccessKeyId()
			if _err != nil {
				return _result, _err
			}

			accessKeySecret, _err := client.Credential.GetAccessKeySecret()
			if _err != nil {
				return _result, _err
			}

			token, _err := client.Credential.GetSecurityToken()
			if _err != nil {
				return _result, _err
			}

			request_.Protocol = client.Protocol
			request_.Method = tea.String("OPTIONS")
			request_.Pathname = tea.String("/" + tea.StringValue(request.ObjectName))
			request_.Headers = tea.Merge(map[string]*string{
				"host":       ossutil.GetHost(request.BucketName, client.RegionId, client.Endpoint, client.HostModel),
				"date":       util.GetDateUTCString(),
				"user-agent": client.GetUserAgent(),
			}, util.StringifyMapValue(tea.ToMap(request.Header)))
			if !tea.BoolValue(util.Empty(token)) {
				request_.Headers["x-oss-security-token"] = token
			}

			request_.Headers["authorization"] = ossutil.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, client.SignatureVersion, client.AddtionalHeaders)
			response_, _err := tea.DoRequest(request_, _runtime)
			if _err != nil {
				return _result, _err
			}
			var respMap map[string]interface{}
			var bodyStr *string
			if tea.BoolValue(util.Is4xx(response_.StatusCode)) || tea.BoolValue(util.Is5xx(response_.StatusCode)) {
				bodyStr, _err = util.ReadAsString(response_.Body)
				if _err != nil {
					return _result, _err
				}

				respMap = ossutil.GetErrMessage(bodyStr)
				_err = tea.NewSDKError(map[string]interface{}{
					"code":    respMap["Code"],
					"message": respMap["Message"],
					"data": map[string]interface{}{
						"httpCode":  tea.IntValue(response_.StatusCode),
						"requestId": respMap["RequestId"],
						"hostId":    respMap["HostId"],
					},
				})
				return _result, _err
			}

			_result = &OptionObjectResponse{}
			_err = tea.Convert(response_.Headers, &_result)
			return _result, _err
		}()
		if !tea.BoolValue(tea.Retryable(_err)) {
			break
		}
	}

	return _resp, _err
}

func (client *Client) PostVodPlaylist(request *PostVodPlaylistRequest, runtime *ossutil.RuntimeOptions) (_result *PostVodPlaylistResponse, _err error) {
	_err = tea.Validate(request)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Validate(runtime)
	if _err != nil {
		return _result, _err
	}
	_runtime := map[string]interface{}{
		"timeouted":      "retry",
		"readTimeout":    tea.IntValue(util.DefaultNumber(runtime.ReadTimeout, client.ReadTimeout)),
		"connectTimeout": tea.IntValue(util.DefaultNumber(runtime.ConnectTimeout, client.ConnectTimeout)),
		"localAddr":      tea.StringValue(util.DefaultString(runtime.LocalAddr, client.LocalAddr)),
		"httpProxy":      tea.StringValue(util.DefaultString(runtime.HttpProxy, client.HttpProxy)),
		"httpsProxy":     tea.StringValue(util.DefaultString(runtime.HttpsProxy, client.HttpsProxy)),
		"noProxy":        tea.StringValue(util.DefaultString(runtime.NoProxy, client.NoProxy)),
		"socks5Proxy":    tea.StringValue(util.DefaultString(runtime.Socks5Proxy, client.Socks5Proxy)),
		"socks5NetWork":  tea.StringValue(util.DefaultString(runtime.Socks5NetWork, client.Socks5NetWork)),
		"maxIdleConns":   tea.IntValue(util.DefaultNumber(runtime.MaxIdleConns, client.MaxIdleConns)),
		"retry": map[string]interface{}{
			"retryable":   tea.BoolValue(runtime.Autoretry),
			"maxAttempts": tea.IntValue(util.DefaultNumber(runtime.MaxAttempts, tea.Int(3))),
		},
		"backoff": map[string]interface{}{
			"policy": tea.StringValue(util.DefaultString(runtime.BackoffPolicy, tea.String("no"))),
			"period": tea.IntValue(util.DefaultNumber(runtime.BackoffPeriod, tea.Int(1))),
		},
		"ignoreSSL": tea.BoolValue(runtime.IgnoreSSL),
	}

	_resp := &PostVodPlaylistResponse{}
	for _retryTimes := 0; tea.BoolValue(tea.AllowRetry(_runtime["retry"], tea.Int(_retryTimes))); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], tea.Int(_retryTimes))
			if tea.IntValue(_backoffTime) > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, _err = func() (*PostVodPlaylistResponse, error) {
			request_ := tea.NewRequest()
			accessKeyId, _err := client.Credential.GetAccessKeyId()
			if _err != nil {
				return _result, _err
			}

			accessKeySecret, _err := client.Credential.GetAccessKeySecret()
			if _err != nil {
				return _result, _err
			}

			token, _err := client.Credential.GetSecurityToken()
			if _err != nil {
				return _result, _err
			}

			request_.Protocol = client.Protocol
			request_.Method = tea.String("POST")
			request_.Pathname = tea.String("/" + tea.StringValue(request.ChannelName) + "/" + tea.StringValue(request.PlaylistName) + "?vod")
			request_.Headers = map[string]*string{
				"host":       ossutil.GetHost(request.BucketName, client.RegionId, client.Endpoint, client.HostModel),
				"date":       util.GetDateUTCString(),
				"user-agent": client.GetUserAgent(),
			}
			if !tea.BoolValue(util.Empty(token)) {
				request_.Headers["x-oss-security-token"] = token
			}

			request_.Query = util.StringifyMapValue(tea.ToMap(request.Filter))
			request_.Headers["authorization"] = ossutil.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, client.SignatureVersion, client.AddtionalHeaders)
			response_, _err := tea.DoRequest(request_, _runtime)
			if _err != nil {
				return _result, _err
			}
			var respMap map[string]interface{}
			var bodyStr *string
			if tea.BoolValue(util.Is4xx(response_.StatusCode)) || tea.BoolValue(util.Is5xx(response_.StatusCode)) {
				bodyStr, _err = util.ReadAsString(response_.Body)
				if _err != nil {
					return _result, _err
				}

				respMap = ossutil.GetErrMessage(bodyStr)
				_err = tea.NewSDKError(map[string]interface{}{
					"code":    respMap["Code"],
					"message": respMap["Message"],
					"data": map[string]interface{}{
						"httpCode":  tea.IntValue(response_.StatusCode),
						"requestId": respMap["RequestId"],
						"hostId":    respMap["HostId"],
					},
				})
				return _result, _err
			}

			_result = &PostVodPlaylistResponse{}
			_err = tea.Convert(response_.Headers, &_result)
			return _result, _err
		}()
		if !tea.BoolValue(tea.Retryable(_err)) {
			break
		}
	}

	return _resp, _err
}

func (client *Client) PostObject(request *PostObjectRequest, runtime *ossutil.RuntimeOptions) (_result *PostObjectResponse, _err error) {
	_err = tea.Validate(request)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Validate(runtime)
	if _err != nil {
		return _result, _err
	}
	_runtime := map[string]interface{}{
		"timeouted":      "retry",
		"readTimeout":    tea.IntValue(util.DefaultNumber(runtime.ReadTimeout, client.ReadTimeout)),
		"connectTimeout": tea.IntValue(util.DefaultNumber(runtime.ConnectTimeout, client.ConnectTimeout)),
		"httpProxy":      tea.StringValue(util.DefaultString(runtime.HttpProxy, client.HttpProxy)),
		"httpsProxy":     tea.StringValue(util.DefaultString(runtime.HttpsProxy, client.HttpsProxy)),
		"noProxy":        tea.StringValue(util.DefaultString(runtime.NoProxy, client.NoProxy)),
		"maxIdleConns":   tea.IntValue(util.DefaultNumber(runtime.MaxIdleConns, client.MaxIdleConns)),
		"retry": map[string]interface{}{
			"retryable":   tea.BoolValue(runtime.Autoretry),
			"maxAttempts": tea.IntValue(util.DefaultNumber(runtime.MaxAttempts, tea.Int(3))),
		},
		"backoff": map[string]interface{}{
			"policy": tea.StringValue(util.DefaultString(runtime.BackoffPolicy, tea.String("no"))),
			"period": tea.IntValue(util.DefaultNumber(runtime.BackoffPeriod, tea.Int(1))),
		},
		"ignoreSSL": tea.BoolValue(runtime.IgnoreSSL),
	}

	_resp := &PostObjectResponse{}
	for _retryTimes := 0; tea.BoolValue(tea.AllowRetry(_runtime["retry"], tea.Int(_retryTimes))); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], tea.Int(_retryTimes))
			if tea.IntValue(_backoffTime) > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, _err = func() (*PostObjectResponse, error) {
			request_ := tea.NewRequest()
			boundary := fileform.GetBoundary()
			request_.Protocol = client.Protocol
			request_.Method = tea.String("POST")
			request_.Pathname = tea.String("/")
			request_.Headers = map[string]*string{
				"host":       ossutil.GetHost(request.BucketName, client.RegionId, client.Endpoint, client.HostModel),
				"date":       util.GetDateUTCString(),
				"user-agent": client.GetUserAgent(),
			}
			request_.Headers["content-type"] = tea.String("multipart/form-data; boundary=" + tea.StringValue(boundary))
			form := tea.ToMap(map[string]interface{}{
				"OSSAccessKeyId":        tea.StringValue(request.Header.AccessKeyId),
				"policy":                tea.StringValue(request.Header.Policy),
				"Signature":             tea.StringValue(request.Header.Signature),
				"key":                   tea.StringValue(request.Header.Key),
				"success_action_status": tea.StringValue(request.Header.SuccessActionStatus),
				"file":                  request.Header.File,
			}, ossutil.ToMeta(request.Header.UserMeta, tea.String("x-oss-meta-")))
			request_.Body = fileform.ToFileForm(form, boundary)
			response_, _err := tea.DoRequest(request_, _runtime)
			if _err != nil {
				return _result, _err
			}
			var respMap map[string]interface{}
			bodyStr, _err := util.ReadAsString(response_.Body)
			if _err != nil {
				return _result, _err
			}

			if tea.BoolValue(util.Is4xx(response_.StatusCode)) || tea.BoolValue(util.Is5xx(response_.StatusCode)) {
				respMap = ossutil.GetErrMessage(bodyStr)
				_err = tea.NewSDKError(map[string]interface{}{
					"code":    respMap["Code"],
					"message": respMap["Message"],
					"data": map[string]interface{}{
						"httpCode":  tea.IntValue(response_.StatusCode),
						"requestId": respMap["RequestId"],
						"hostId":    respMap["HostId"],
					},
				})
				return _result, _err
			}

			respMap = xml.ParseXml(bodyStr, new(PostObjectResponse))
			_result = &PostObjectResponse{}
			_err = tea.Convert(respMap, &_result)
			return _result, _err
		}()
		if !tea.BoolValue(tea.Retryable(_err)) {
			break
		}
	}

	return _resp, _err
}

func (client *Client) HeadObject(request *HeadObjectRequest, runtime *ossutil.RuntimeOptions) (_result *HeadObjectResponse, _err error) {
	_err = tea.Validate(request)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Validate(runtime)
	if _err != nil {
		return _result, _err
	}
	_runtime := map[string]interface{}{
		"timeouted":      "retry",
		"readTimeout":    tea.IntValue(util.DefaultNumber(runtime.ReadTimeout, client.ReadTimeout)),
		"connectTimeout": tea.IntValue(util.DefaultNumber(runtime.ConnectTimeout, client.ConnectTimeout)),
		"localAddr":      tea.StringValue(util.DefaultString(runtime.LocalAddr, client.LocalAddr)),
		"httpProxy":      tea.StringValue(util.DefaultString(runtime.HttpProxy, client.HttpProxy)),
		"httpsProxy":     tea.StringValue(util.DefaultString(runtime.HttpsProxy, client.HttpsProxy)),
		"noProxy":        tea.StringValue(util.DefaultString(runtime.NoProxy, client.NoProxy)),
		"socks5Proxy":    tea.StringValue(util.DefaultString(runtime.Socks5Proxy, client.Socks5Proxy)),
		"socks5NetWork":  tea.StringValue(util.DefaultString(runtime.Socks5NetWork, client.Socks5NetWork)),
		"maxIdleConns":   tea.IntValue(util.DefaultNumber(runtime.MaxIdleConns, client.MaxIdleConns)),
		"retry": map[string]interface{}{
			"retryable":   tea.BoolValue(runtime.Autoretry),
			"maxAttempts": tea.IntValue(util.DefaultNumber(runtime.MaxAttempts, tea.Int(3))),
		},
		"backoff": map[string]interface{}{
			"policy": tea.StringValue(util.DefaultString(runtime.BackoffPolicy, tea.String("no"))),
			"period": tea.IntValue(util.DefaultNumber(runtime.BackoffPeriod, tea.Int(1))),
		},
		"ignoreSSL": tea.BoolValue(runtime.IgnoreSSL),
	}

	_resp := &HeadObjectResponse{}
	for _retryTimes := 0; tea.BoolValue(tea.AllowRetry(_runtime["retry"], tea.Int(_retryTimes))); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], tea.Int(_retryTimes))
			if tea.IntValue(_backoffTime) > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, _err = func() (*HeadObjectResponse, error) {
			request_ := tea.NewRequest()
			accessKeyId, _err := client.Credential.GetAccessKeyId()
			if _err != nil {
				return _result, _err
			}

			accessKeySecret, _err := client.Credential.GetAccessKeySecret()
			if _err != nil {
				return _result, _err
			}

			token, _err := client.Credential.GetSecurityToken()
			if _err != nil {
				return _result, _err
			}

			request_.Protocol = client.Protocol
			request_.Method = tea.String("HEAD")
			request_.Pathname = tea.String("/" + tea.StringValue(request.ObjectName))
			request_.Headers = tea.Merge(map[string]*string{
				"host":       ossutil.GetHost(request.BucketName, client.RegionId, client.Endpoint, client.HostModel),
				"date":       util.GetDateUTCString(),
				"user-agent": client.GetUserAgent(),
			}, util.StringifyMapValue(tea.ToMap(request.Header)))
			if !tea.BoolValue(util.Empty(token)) {
				request_.Headers["x-oss-security-token"] = token
			}

			request_.Headers["authorization"] = ossutil.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, client.SignatureVersion, client.AddtionalHeaders)
			response_, _err := tea.DoRequest(request_, _runtime)
			if _err != nil {
				return _result, _err
			}
			var respMap map[string]interface{}
			var bodyStr *string
			if tea.BoolValue(util.Is4xx(response_.StatusCode)) || tea.BoolValue(util.Is5xx(response_.StatusCode)) {
				bodyStr, _err = util.ReadAsString(response_.Body)
				if _err != nil {
					return _result, _err
				}

				respMap = ossutil.GetErrMessage(bodyStr)
				_err = tea.NewSDKError(map[string]interface{}{
					"code":    respMap["Code"],
					"message": respMap["Message"],
					"data": map[string]interface{}{
						"httpCode":  tea.IntValue(response_.StatusCode),
						"requestId": respMap["RequestId"],
						"hostId":    respMap["HostId"],
					},
				})
				return _result, _err
			}

			_result = &HeadObjectResponse{}
			_err = tea.Convert(tea.ToMap(map[string]interface{}{
				"usermeta": ossutil.ToMeta(response_.Headers, tea.String("x-oss-meta-")),
			}, response_.Headers), &_result)
			return _result, _err
		}()
		if !tea.BoolValue(tea.Retryable(_err)) {
			break
		}
	}

	return _resp, _err
}

func (client *Client) DeleteObjectTagging(request *DeleteObjectTaggingRequest, runtime *ossutil.RuntimeOptions) (_result *DeleteObjectTaggingResponse, _err error) {
	_err = tea.Validate(request)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Validate(runtime)
	if _err != nil {
		return _result, _err
	}
	_runtime := map[string]interface{}{
		"timeouted":      "retry",
		"readTimeout":    tea.IntValue(util.DefaultNumber(runtime.ReadTimeout, client.ReadTimeout)),
		"connectTimeout": tea.IntValue(util.DefaultNumber(runtime.ConnectTimeout, client.ConnectTimeout)),
		"localAddr":      tea.StringValue(util.DefaultString(runtime.LocalAddr, client.LocalAddr)),
		"httpProxy":      tea.StringValue(util.DefaultString(runtime.HttpProxy, client.HttpProxy)),
		"httpsProxy":     tea.StringValue(util.DefaultString(runtime.HttpsProxy, client.HttpsProxy)),
		"noProxy":        tea.StringValue(util.DefaultString(runtime.NoProxy, client.NoProxy)),
		"socks5Proxy":    tea.StringValue(util.DefaultString(runtime.Socks5Proxy, client.Socks5Proxy)),
		"socks5NetWork":  tea.StringValue(util.DefaultString(runtime.Socks5NetWork, client.Socks5NetWork)),
		"maxIdleConns":   tea.IntValue(util.DefaultNumber(runtime.MaxIdleConns, client.MaxIdleConns)),
		"retry": map[string]interface{}{
			"retryable":   tea.BoolValue(runtime.Autoretry),
			"maxAttempts": tea.IntValue(util.DefaultNumber(runtime.MaxAttempts, tea.Int(3))),
		},
		"backoff": map[string]interface{}{
			"policy": tea.StringValue(util.DefaultString(runtime.BackoffPolicy, tea.String("no"))),
			"period": tea.IntValue(util.DefaultNumber(runtime.BackoffPeriod, tea.Int(1))),
		},
		"ignoreSSL": tea.BoolValue(runtime.IgnoreSSL),
	}

	_resp := &DeleteObjectTaggingResponse{}
	for _retryTimes := 0; tea.BoolValue(tea.AllowRetry(_runtime["retry"], tea.Int(_retryTimes))); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], tea.Int(_retryTimes))
			if tea.IntValue(_backoffTime) > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, _err = func() (*DeleteObjectTaggingResponse, error) {
			request_ := tea.NewRequest()
			accessKeyId, _err := client.Credential.GetAccessKeyId()
			if _err != nil {
				return _result, _err
			}

			accessKeySecret, _err := client.Credential.GetAccessKeySecret()
			if _err != nil {
				return _result, _err
			}

			token, _err := client.Credential.GetSecurityToken()
			if _err != nil {
				return _result, _err
			}

			request_.Protocol = client.Protocol
			request_.Method = tea.String("DELETE")
			request_.Pathname = tea.String("/" + tea.StringValue(request.ObjectName) + "?tagging")
			request_.Headers = map[string]*string{
				"host":       ossutil.GetHost(request.BucketName, client.RegionId, client.Endpoint, client.HostModel),
				"date":       util.GetDateUTCString(),
				"user-agent": client.GetUserAgent(),
			}
			if !tea.BoolValue(util.Empty(token)) {
				request_.Headers["x-oss-security-token"] = token
			}

			request_.Headers["authorization"] = ossutil.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, client.SignatureVersion, client.AddtionalHeaders)
			response_, _err := tea.DoRequest(request_, _runtime)
			if _err != nil {
				return _result, _err
			}
			var respMap map[string]interface{}
			var bodyStr *string
			if tea.BoolValue(util.Is4xx(response_.StatusCode)) || tea.BoolValue(util.Is5xx(response_.StatusCode)) {
				bodyStr, _err = util.ReadAsString(response_.Body)
				if _err != nil {
					return _result, _err
				}

				respMap = ossutil.GetErrMessage(bodyStr)
				_err = tea.NewSDKError(map[string]interface{}{
					"code":    respMap["Code"],
					"message": respMap["Message"],
					"data": map[string]interface{}{
						"httpCode":  tea.IntValue(response_.StatusCode),
						"requestId": respMap["RequestId"],
						"hostId":    respMap["HostId"],
					},
				})
				return _result, _err
			}

			_result = &DeleteObjectTaggingResponse{}
			_err = tea.Convert(response_.Headers, &_result)
			return _result, _err
		}()
		if !tea.BoolValue(tea.Retryable(_err)) {
			break
		}
	}

	return _resp, _err
}

func (client *Client) RestoreObject(request *RestoreObjectRequest, runtime *ossutil.RuntimeOptions) (_result *RestoreObjectResponse, _err error) {
	_err = tea.Validate(request)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Validate(runtime)
	if _err != nil {
		return _result, _err
	}
	_runtime := map[string]interface{}{
		"timeouted":      "retry",
		"readTimeout":    tea.IntValue(util.DefaultNumber(runtime.ReadTimeout, client.ReadTimeout)),
		"connectTimeout": tea.IntValue(util.DefaultNumber(runtime.ConnectTimeout, client.ConnectTimeout)),
		"localAddr":      tea.StringValue(util.DefaultString(runtime.LocalAddr, client.LocalAddr)),
		"httpProxy":      tea.StringValue(util.DefaultString(runtime.HttpProxy, client.HttpProxy)),
		"httpsProxy":     tea.StringValue(util.DefaultString(runtime.HttpsProxy, client.HttpsProxy)),
		"noProxy":        tea.StringValue(util.DefaultString(runtime.NoProxy, client.NoProxy)),
		"socks5Proxy":    tea.StringValue(util.DefaultString(runtime.Socks5Proxy, client.Socks5Proxy)),
		"socks5NetWork":  tea.StringValue(util.DefaultString(runtime.Socks5NetWork, client.Socks5NetWork)),
		"maxIdleConns":   tea.IntValue(util.DefaultNumber(runtime.MaxIdleConns, client.MaxIdleConns)),
		"retry": map[string]interface{}{
			"retryable":   tea.BoolValue(runtime.Autoretry),
			"maxAttempts": tea.IntValue(util.DefaultNumber(runtime.MaxAttempts, tea.Int(3))),
		},
		"backoff": map[string]interface{}{
			"policy": tea.StringValue(util.DefaultString(runtime.BackoffPolicy, tea.String("no"))),
			"period": tea.IntValue(util.DefaultNumber(runtime.BackoffPeriod, tea.Int(1))),
		},
		"ignoreSSL": tea.BoolValue(runtime.IgnoreSSL),
	}

	_resp := &RestoreObjectResponse{}
	for _retryTimes := 0; tea.BoolValue(tea.AllowRetry(_runtime["retry"], tea.Int(_retryTimes))); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], tea.Int(_retryTimes))
			if tea.IntValue(_backoffTime) > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, _err = func() (*RestoreObjectResponse, error) {
			request_ := tea.NewRequest()
			accessKeyId, _err := client.Credential.GetAccessKeyId()
			if _err != nil {
				return _result, _err
			}

			accessKeySecret, _err := client.Credential.GetAccessKeySecret()
			if _err != nil {
				return _result, _err
			}

			token, _err := client.Credential.GetSecurityToken()
			if _err != nil {
				return _result, _err
			}

			request_.Protocol = client.Protocol
			request_.Method = tea.String("POST")
			request_.Pathname = tea.String("/" + tea.StringValue(request.ObjectName) + "?restore")
			request_.Headers = map[string]*string{
				"host":       ossutil.GetHost(request.BucketName, client.RegionId, client.Endpoint, client.HostModel),
				"date":       util.GetDateUTCString(),
				"user-agent": client.GetUserAgent(),
			}
			if !tea.BoolValue(util.Empty(token)) {
				request_.Headers["x-oss-security-token"] = token
			}

			request_.Headers["authorization"] = ossutil.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, client.SignatureVersion, client.AddtionalHeaders)
			response_, _err := tea.DoRequest(request_, _runtime)
			if _err != nil {
				return _result, _err
			}
			var respMap map[string]interface{}
			var bodyStr *string
			if tea.BoolValue(util.Is4xx(response_.StatusCode)) || tea.BoolValue(util.Is5xx(response_.StatusCode)) {
				bodyStr, _err = util.ReadAsString(response_.Body)
				if _err != nil {
					return _result, _err
				}

				respMap = ossutil.GetErrMessage(bodyStr)
				_err = tea.NewSDKError(map[string]interface{}{
					"code":    respMap["Code"],
					"message": respMap["Message"],
					"data": map[string]interface{}{
						"httpCode":  tea.IntValue(response_.StatusCode),
						"requestId": respMap["RequestId"],
						"hostId":    respMap["HostId"],
					},
				})
				return _result, _err
			}

			_result = &RestoreObjectResponse{}
			_err = tea.Convert(response_.Headers, &_result)
			return _result, _err
		}()
		if !tea.BoolValue(tea.Retryable(_err)) {
			break
		}
	}

	return _resp, _err
}

func (client *Client) GetObjectAcl(request *GetObjectAclRequest, runtime *ossutil.RuntimeOptions) (_result *GetObjectAclResponse, _err error) {
	_err = tea.Validate(request)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Validate(runtime)
	if _err != nil {
		return _result, _err
	}
	_runtime := map[string]interface{}{
		"timeouted":      "retry",
		"readTimeout":    tea.IntValue(util.DefaultNumber(runtime.ReadTimeout, client.ReadTimeout)),
		"connectTimeout": tea.IntValue(util.DefaultNumber(runtime.ConnectTimeout, client.ConnectTimeout)),
		"localAddr":      tea.StringValue(util.DefaultString(runtime.LocalAddr, client.LocalAddr)),
		"httpProxy":      tea.StringValue(util.DefaultString(runtime.HttpProxy, client.HttpProxy)),
		"httpsProxy":     tea.StringValue(util.DefaultString(runtime.HttpsProxy, client.HttpsProxy)),
		"noProxy":        tea.StringValue(util.DefaultString(runtime.NoProxy, client.NoProxy)),
		"socks5Proxy":    tea.StringValue(util.DefaultString(runtime.Socks5Proxy, client.Socks5Proxy)),
		"socks5NetWork":  tea.StringValue(util.DefaultString(runtime.Socks5NetWork, client.Socks5NetWork)),
		"maxIdleConns":   tea.IntValue(util.DefaultNumber(runtime.MaxIdleConns, client.MaxIdleConns)),
		"retry": map[string]interface{}{
			"retryable":   tea.BoolValue(runtime.Autoretry),
			"maxAttempts": tea.IntValue(util.DefaultNumber(runtime.MaxAttempts, tea.Int(3))),
		},
		"backoff": map[string]interface{}{
			"policy": tea.StringValue(util.DefaultString(runtime.BackoffPolicy, tea.String("no"))),
			"period": tea.IntValue(util.DefaultNumber(runtime.BackoffPeriod, tea.Int(1))),
		},
		"ignoreSSL": tea.BoolValue(runtime.IgnoreSSL),
	}

	_resp := &GetObjectAclResponse{}
	for _retryTimes := 0; tea.BoolValue(tea.AllowRetry(_runtime["retry"], tea.Int(_retryTimes))); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], tea.Int(_retryTimes))
			if tea.IntValue(_backoffTime) > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, _err = func() (*GetObjectAclResponse, error) {
			request_ := tea.NewRequest()
			accessKeyId, _err := client.Credential.GetAccessKeyId()
			if _err != nil {
				return _result, _err
			}

			accessKeySecret, _err := client.Credential.GetAccessKeySecret()
			if _err != nil {
				return _result, _err
			}

			token, _err := client.Credential.GetSecurityToken()
			if _err != nil {
				return _result, _err
			}

			request_.Protocol = client.Protocol
			request_.Method = tea.String("GET")
			request_.Pathname = tea.String("/" + tea.StringValue(request.ObjectName) + "?acl")
			request_.Headers = map[string]*string{
				"host":       ossutil.GetHost(request.BucketName, client.RegionId, client.Endpoint, client.HostModel),
				"date":       util.GetDateUTCString(),
				"user-agent": client.GetUserAgent(),
			}
			if !tea.BoolValue(util.Empty(token)) {
				request_.Headers["x-oss-security-token"] = token
			}

			request_.Headers["authorization"] = ossutil.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, client.SignatureVersion, client.AddtionalHeaders)
			response_, _err := tea.DoRequest(request_, _runtime)
			if _err != nil {
				return _result, _err
			}
			var respMap map[string]interface{}
			var bodyStr *string
			if tea.BoolValue(util.Is4xx(response_.StatusCode)) || tea.BoolValue(util.Is5xx(response_.StatusCode)) {
				bodyStr, _err = util.ReadAsString(response_.Body)
				if _err != nil {
					return _result, _err
				}

				respMap = ossutil.GetErrMessage(bodyStr)
				_err = tea.NewSDKError(map[string]interface{}{
					"code":    respMap["Code"],
					"message": respMap["Message"],
					"data": map[string]interface{}{
						"httpCode":  tea.IntValue(response_.StatusCode),
						"requestId": respMap["RequestId"],
						"hostId":    respMap["HostId"],
					},
				})
				return _result, _err
			}

			bodyStr, _err = util.ReadAsString(response_.Body)
			if _err != nil {
				return _result, _err
			}

			respMap = xml.ParseXml(bodyStr, new(GetObjectAclResponse))
			_result = &GetObjectAclResponse{}
			_err = tea.Convert(tea.ToMap(map[string]interface{}{
				"AccessControlPolicy": respMap["AccessControlPolicy"],
			}, response_.Headers), &_result)
			return _result, _err
		}()
		if !tea.BoolValue(tea.Retryable(_err)) {
			break
		}
	}

	return _resp, _err
}

func (client *Client) PutBucketAcl(request *PutBucketAclRequest, runtime *ossutil.RuntimeOptions) (_result *PutBucketAclResponse, _err error) {
	_err = tea.Validate(request)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Validate(runtime)
	if _err != nil {
		return _result, _err
	}
	_runtime := map[string]interface{}{
		"timeouted":      "retry",
		"readTimeout":    tea.IntValue(util.DefaultNumber(runtime.ReadTimeout, client.ReadTimeout)),
		"connectTimeout": tea.IntValue(util.DefaultNumber(runtime.ConnectTimeout, client.ConnectTimeout)),
		"localAddr":      tea.StringValue(util.DefaultString(runtime.LocalAddr, client.LocalAddr)),
		"httpProxy":      tea.StringValue(util.DefaultString(runtime.HttpProxy, client.HttpProxy)),
		"httpsProxy":     tea.StringValue(util.DefaultString(runtime.HttpsProxy, client.HttpsProxy)),
		"noProxy":        tea.StringValue(util.DefaultString(runtime.NoProxy, client.NoProxy)),
		"socks5Proxy":    tea.StringValue(util.DefaultString(runtime.Socks5Proxy, client.Socks5Proxy)),
		"socks5NetWork":  tea.StringValue(util.DefaultString(runtime.Socks5NetWork, client.Socks5NetWork)),
		"maxIdleConns":   tea.IntValue(util.DefaultNumber(runtime.MaxIdleConns, client.MaxIdleConns)),
		"retry": map[string]interface{}{
			"retryable":   tea.BoolValue(runtime.Autoretry),
			"maxAttempts": tea.IntValue(util.DefaultNumber(runtime.MaxAttempts, tea.Int(3))),
		},
		"backoff": map[string]interface{}{
			"policy": tea.StringValue(util.DefaultString(runtime.BackoffPolicy, tea.String("no"))),
			"period": tea.IntValue(util.DefaultNumber(runtime.BackoffPeriod, tea.Int(1))),
		},
		"ignoreSSL": tea.BoolValue(runtime.IgnoreSSL),
	}

	_resp := &PutBucketAclResponse{}
	for _retryTimes := 0; tea.BoolValue(tea.AllowRetry(_runtime["retry"], tea.Int(_retryTimes))); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], tea.Int(_retryTimes))
			if tea.IntValue(_backoffTime) > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, _err = func() (*PutBucketAclResponse, error) {
			request_ := tea.NewRequest()
			accessKeyId, _err := client.Credential.GetAccessKeyId()
			if _err != nil {
				return _result, _err
			}

			accessKeySecret, _err := client.Credential.GetAccessKeySecret()
			if _err != nil {
				return _result, _err
			}

			token, _err := client.Credential.GetSecurityToken()
			if _err != nil {
				return _result, _err
			}

			request_.Protocol = client.Protocol
			request_.Method = tea.String("PUT")
			request_.Pathname = tea.String("/?acl")
			request_.Headers = tea.Merge(map[string]*string{
				"host":       ossutil.GetHost(request.BucketName, client.RegionId, client.Endpoint, client.HostModel),
				"date":       util.GetDateUTCString(),
				"user-agent": client.GetUserAgent(),
			}, util.StringifyMapValue(tea.ToMap(request.Header)))
			if !tea.BoolValue(util.Empty(token)) {
				request_.Headers["x-oss-security-token"] = token
			}

			request_.Headers["authorization"] = ossutil.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, client.SignatureVersion, client.AddtionalHeaders)
			response_, _err := tea.DoRequest(request_, _runtime)
			if _err != nil {
				return _result, _err
			}
			var respMap map[string]interface{}
			var bodyStr *string
			if tea.BoolValue(util.Is4xx(response_.StatusCode)) || tea.BoolValue(util.Is5xx(response_.StatusCode)) {
				bodyStr, _err = util.ReadAsString(response_.Body)
				if _err != nil {
					return _result, _err
				}

				respMap = ossutil.GetErrMessage(bodyStr)
				_err = tea.NewSDKError(map[string]interface{}{
					"code":    respMap["Code"],
					"message": respMap["Message"],
					"data": map[string]interface{}{
						"httpCode":  tea.IntValue(response_.StatusCode),
						"requestId": respMap["RequestId"],
						"hostId":    respMap["HostId"],
					},
				})
				return _result, _err
			}

			_result = &PutBucketAclResponse{}
			_err = tea.Convert(response_.Headers, &_result)
			return _result, _err
		}()
		if !tea.BoolValue(tea.Retryable(_err)) {
			break
		}
	}

	return _resp, _err
}

func (client *Client) DeleteBucket(request *DeleteBucketRequest, runtime *ossutil.RuntimeOptions) (_result *DeleteBucketResponse, _err error) {
	_err = tea.Validate(request)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Validate(runtime)
	if _err != nil {
		return _result, _err
	}
	_runtime := map[string]interface{}{
		"timeouted":      "retry",
		"readTimeout":    tea.IntValue(util.DefaultNumber(runtime.ReadTimeout, client.ReadTimeout)),
		"connectTimeout": tea.IntValue(util.DefaultNumber(runtime.ConnectTimeout, client.ConnectTimeout)),
		"localAddr":      tea.StringValue(util.DefaultString(runtime.LocalAddr, client.LocalAddr)),
		"httpProxy":      tea.StringValue(util.DefaultString(runtime.HttpProxy, client.HttpProxy)),
		"httpsProxy":     tea.StringValue(util.DefaultString(runtime.HttpsProxy, client.HttpsProxy)),
		"noProxy":        tea.StringValue(util.DefaultString(runtime.NoProxy, client.NoProxy)),
		"socks5Proxy":    tea.StringValue(util.DefaultString(runtime.Socks5Proxy, client.Socks5Proxy)),
		"socks5NetWork":  tea.StringValue(util.DefaultString(runtime.Socks5NetWork, client.Socks5NetWork)),
		"maxIdleConns":   tea.IntValue(util.DefaultNumber(runtime.MaxIdleConns, client.MaxIdleConns)),
		"retry": map[string]interface{}{
			"retryable":   tea.BoolValue(runtime.Autoretry),
			"maxAttempts": tea.IntValue(util.DefaultNumber(runtime.MaxAttempts, tea.Int(3))),
		},
		"backoff": map[string]interface{}{
			"policy": tea.StringValue(util.DefaultString(runtime.BackoffPolicy, tea.String("no"))),
			"period": tea.IntValue(util.DefaultNumber(runtime.BackoffPeriod, tea.Int(1))),
		},
		"ignoreSSL": tea.BoolValue(runtime.IgnoreSSL),
	}

	_resp := &DeleteBucketResponse{}
	for _retryTimes := 0; tea.BoolValue(tea.AllowRetry(_runtime["retry"], tea.Int(_retryTimes))); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], tea.Int(_retryTimes))
			if tea.IntValue(_backoffTime) > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, _err = func() (*DeleteBucketResponse, error) {
			request_ := tea.NewRequest()
			accessKeyId, _err := client.Credential.GetAccessKeyId()
			if _err != nil {
				return _result, _err
			}

			accessKeySecret, _err := client.Credential.GetAccessKeySecret()
			if _err != nil {
				return _result, _err
			}

			token, _err := client.Credential.GetSecurityToken()
			if _err != nil {
				return _result, _err
			}

			request_.Protocol = client.Protocol
			request_.Method = tea.String("DELETE")
			request_.Pathname = tea.String("/")
			request_.Headers = map[string]*string{
				"host":       ossutil.GetHost(request.BucketName, client.RegionId, client.Endpoint, client.HostModel),
				"date":       util.GetDateUTCString(),
				"user-agent": client.GetUserAgent(),
			}
			if !tea.BoolValue(util.Empty(token)) {
				request_.Headers["x-oss-security-token"] = token
			}

			request_.Headers["authorization"] = ossutil.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, client.SignatureVersion, client.AddtionalHeaders)
			response_, _err := tea.DoRequest(request_, _runtime)
			if _err != nil {
				return _result, _err
			}
			var respMap map[string]interface{}
			var bodyStr *string
			if tea.BoolValue(util.Is4xx(response_.StatusCode)) || tea.BoolValue(util.Is5xx(response_.StatusCode)) {
				bodyStr, _err = util.ReadAsString(response_.Body)
				if _err != nil {
					return _result, _err
				}

				respMap = ossutil.GetErrMessage(bodyStr)
				_err = tea.NewSDKError(map[string]interface{}{
					"code":    respMap["Code"],
					"message": respMap["Message"],
					"data": map[string]interface{}{
						"httpCode":  tea.IntValue(response_.StatusCode),
						"requestId": respMap["RequestId"],
						"hostId":    respMap["HostId"],
					},
				})
				return _result, _err
			}

			_result = &DeleteBucketResponse{}
			_err = tea.Convert(response_.Headers, &_result)
			return _result, _err
		}()
		if !tea.BoolValue(tea.Retryable(_err)) {
			break
		}
	}

	return _resp, _err
}

func (client *Client) PutObject(request *PutObjectRequest, runtime *ossutil.RuntimeOptions) (_result *PutObjectResponse, _err error) {
	_err = tea.Validate(request)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Validate(runtime)
	if _err != nil {
		return _result, _err
	}
	_runtime := map[string]interface{}{
		"timeouted":      "retry",
		"readTimeout":    tea.IntValue(util.DefaultNumber(runtime.ReadTimeout, client.ReadTimeout)),
		"connectTimeout": tea.IntValue(util.DefaultNumber(runtime.ConnectTimeout, client.ConnectTimeout)),
		"localAddr":      tea.StringValue(util.DefaultString(runtime.LocalAddr, client.LocalAddr)),
		"httpProxy":      tea.StringValue(util.DefaultString(runtime.HttpProxy, client.HttpProxy)),
		"httpsProxy":     tea.StringValue(util.DefaultString(runtime.HttpsProxy, client.HttpsProxy)),
		"noProxy":        tea.StringValue(util.DefaultString(runtime.NoProxy, client.NoProxy)),
		"socks5Proxy":    tea.StringValue(util.DefaultString(runtime.Socks5Proxy, client.Socks5Proxy)),
		"socks5NetWork":  tea.StringValue(util.DefaultString(runtime.Socks5NetWork, client.Socks5NetWork)),
		"maxIdleConns":   tea.IntValue(util.DefaultNumber(runtime.MaxIdleConns, client.MaxIdleConns)),
		"retry": map[string]interface{}{
			"retryable":   tea.BoolValue(runtime.Autoretry),
			"maxAttempts": tea.IntValue(util.DefaultNumber(runtime.MaxAttempts, tea.Int(3))),
		},
		"backoff": map[string]interface{}{
			"policy": tea.StringValue(util.DefaultString(runtime.BackoffPolicy, tea.String("no"))),
			"period": tea.IntValue(util.DefaultNumber(runtime.BackoffPeriod, tea.Int(1))),
		},
		"ignoreSSL": tea.BoolValue(runtime.IgnoreSSL),
	}

	_resp := &PutObjectResponse{}
	for _retryTimes := 0; tea.BoolValue(tea.AllowRetry(_runtime["retry"], tea.Int(_retryTimes))); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], tea.Int(_retryTimes))
			if tea.IntValue(_backoffTime) > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, _err = func() (*PutObjectResponse, error) {
			request_ := tea.NewRequest()
			ctx := make(map[string]*string)
			accessKeyId, _err := client.Credential.GetAccessKeyId()
			if _err != nil {
				return _result, _err
			}

			accessKeySecret, _err := client.Credential.GetAccessKeySecret()
			if _err != nil {
				return _result, _err
			}

			token, _err := client.Credential.GetSecurityToken()
			if _err != nil {
				return _result, _err
			}

			request_.Protocol = client.Protocol
			request_.Method = tea.String("PUT")
			request_.Pathname = tea.String("/" + tea.StringValue(request.ObjectName))
			request_.Headers = tea.Merge(map[string]*string{
				"host":       ossutil.GetHost(request.BucketName, client.RegionId, client.Endpoint, client.HostModel),
				"date":       util.GetDateUTCString(),
				"user-agent": client.GetUserAgent(),
			}, util.StringifyMapValue(tea.ToMap(request.Header)),
				ossutil.ParseMeta(request.UserMeta, tea.String("x-oss-meta-")))
			if !tea.BoolValue(util.Empty(token)) {
				request_.Headers["x-oss-security-token"] = token
			}

			request_.Body = ossutil.Inject(request.Body, ctx)
			if !tea.BoolValue(util.IsUnset(tea.ToMap(request.Header))) && !tea.BoolValue(util.Empty(request.Header.ContentType)) {
				request_.Headers["content-type"] = request.Header.ContentType
			} else {
				request_.Headers["content-type"] = ossutil.GetContentType(request.ObjectName)
			}

			request_.Headers["authorization"] = ossutil.GetSignature(request_, request.BucketName, accessKeyId, accessKeySecret, client.SignatureVersion, client.AddtionalHeaders)
			response_, _err := tea.DoRequest(request_, _runtime)
			if _err != nil {
				return _result, _err
			}
			var respMap map[string]interface{}
			var bodyStr *string
			if tea.BoolValue(util.Is4xx(response_.StatusCode)) || tea.BoolValue(util.Is5xx(response_.StatusCode)) {
				bodyStr, _err = util.ReadAsString(response_.Body)
				if _err != nil {
					return _result, _err
				}

				respMap = ossutil.GetErrMessage(bodyStr)
				_err = tea.NewSDKError(map[string]interface{}{
					"code":    respMap["Code"],
					"message": respMap["Message"],
					"data": map[string]interface{}{
						"httpCode":  tea.IntValue(response_.StatusCode),
						"requestId": respMap["RequestId"],
						"hostId":    respMap["HostId"],
					},
				})
				return _result, _err
			}

			if tea.BoolValue(client.IsEnableCrc) && !tea.BoolValue(util.EqualString(ctx["crc"], response_.Headers["x-oss-hash-crc64ecma"])) {
				_err = tea.NewSDKError(map[string]interface{}{
					"code": "CrcNotMatched",
					"data": map[string]*string{
						"clientCrc": ctx["crc"],
						"serverCrc": response_.Headers["x-oss-hash-crc64ecma"],
					},
				})
				return _result, _err
			}

			if tea.BoolValue(client.IsEnableMD5) && !tea.BoolValue(util.EqualString(ctx["md5"], response_.Headers["content-md5"])) {
				_err = tea.NewSDKError(map[string]interface{}{
					"code": "MD5NotMatched",
					"data": map[string]*string{
						"clientMD5": ctx["md5"],
						"serverMD5": response_.Headers["content-md5"],
					},
				})
				return _result, _err
			}

			_result = &PutObjectResponse{}
			_err = tea.Convert(response_.Headers, &_result)
			return _result, _err
		}()
		if !tea.BoolValue(tea.Retryable(_err)) {
			break
		}
	}

	return _resp, _err
}

func (client *Client) SetUserAgent(userAgent *string) {
	client.UserAgent = userAgent
}

func (client *Client) AppendUserAgent(userAgent *string) {
	client.UserAgent = tea.String(tea.StringValue(client.UserAgent) + " " + tea.StringValue(userAgent))
}

func (client *Client) GetUserAgent() (_result *string) {
	userAgent := util.GetUserAgent(client.UserAgent)
	_result = userAgent
	return _result
}

func (client *Client) GetAccessKeyId() (_result *string, _err error) {
	if tea.BoolValue(util.IsUnset(client.Credential)) {
		_result = tea.String("")
		return _result, _err
	}

	accessKeyId, _err := client.Credential.GetAccessKeyId()
	if _err != nil {
		return _result, _err
	}

	_result = accessKeyId
	return _result, _err
}

func (client *Client) GetAccessKeySecret() (_result *string, _err error) {
	if tea.BoolValue(util.IsUnset(client.Credential)) {
		_result = tea.String("")
		return _result, _err
	}

	secret, _err := client.Credential.GetAccessKeySecret()
	if _err != nil {
		return _result, _err
	}

	_result = secret
	return _result, _err
}
