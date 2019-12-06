package client

import (
	"encoding/json"
	"io"

	"github.com/alibabacloud-go/tea/tea"
	"github.com/aliyun/alibabacloud-oss-sdk/baseclient/go/service"
)

type RuntimeObject struct {
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
	Md5Threshold     *int64      `json:"MD5Threshold" xml:"MD5Threshold"`
	UploadLimitSpeed *int        `json:"uploadLimitSpeed" xml:"uploadLimitSpeed"`
	Listener         interface{} `json:"listener" xml:"listener"`
}

func (s RuntimeObject) String() string {
	return service.Prettify(s)
}

func (s RuntimeObject) GoString() string {
	return s.String()
}

func (s *RuntimeObject) SetAutoretry(v bool) *RuntimeObject {
	s.Autoretry = &v
	return s
}

func (s *RuntimeObject) SetIgnoreSSL(v bool) *RuntimeObject {
	s.IgnoreSSL = &v
	return s
}

func (s *RuntimeObject) SetMaxAttempts(v int) *RuntimeObject {
	s.MaxAttempts = &v
	return s
}

func (s *RuntimeObject) SetBackoffPolicy(v string) *RuntimeObject {
	s.BackoffPolicy = &v
	return s
}

func (s *RuntimeObject) SetBackoffPeriod(v int) *RuntimeObject {
	s.BackoffPeriod = &v
	return s
}

func (s *RuntimeObject) SetReadTimeout(v int) *RuntimeObject {
	s.ReadTimeout = &v
	return s
}

func (s *RuntimeObject) SetConnectTimeout(v int) *RuntimeObject {
	s.ConnectTimeout = &v
	return s
}

func (s *RuntimeObject) SetLocalAddr(v string) *RuntimeObject {
	s.LocalAddr = &v
	return s
}

func (s *RuntimeObject) SetHttpProxy(v string) *RuntimeObject {
	s.HttpProxy = &v
	return s
}

func (s *RuntimeObject) SetHttpsProxy(v string) *RuntimeObject {
	s.HttpsProxy = &v
	return s
}

func (s *RuntimeObject) SetNoProxy(v string) *RuntimeObject {
	s.NoProxy = &v
	return s
}

func (s *RuntimeObject) SetMaxIdleConns(v int) *RuntimeObject {
	s.MaxIdleConns = &v
	return s
}

func (s *RuntimeObject) SetSocks5Proxy(v string) *RuntimeObject {
	s.Socks5Proxy = &v
	return s
}

func (s *RuntimeObject) SetSocks5NetWork(v string) *RuntimeObject {
	s.Socks5NetWork = &v
	return s
}

func (s *RuntimeObject) SetMd5Threshold(v int64) *RuntimeObject {
	s.Md5Threshold = &v
	return s
}

func (s *RuntimeObject) SetUploadLimitSpeed(v int) *RuntimeObject {
	s.UploadLimitSpeed = &v
	return s
}

func (s *RuntimeObject) SetListener(v interface{}) *RuntimeObject {
	s.Listener = v
	return s
}

type Config struct {
	AccessKeyId      *string   `json:"accessKeyId" xml:"accessKeyId"`
	AccessKeySecret  *string   `json:"accessKeySecret" xml:"accessKeySecret"`
	Type             *string   `json:"type" xml:"type" require:"true"`
	SecurityToken    *string   `json:"securityToken" xml:"securityToken" require:"true"`
	Endpoint         *string   `json:"endpoint" xml:"endpoint" require:"true"`
	Protocol         *string   `json:"protocol" xml:"protocol" require:"true"`
	RegionId         *string   `json:"regionId" xml:"regionId" require:"true"`
	UserAgent        *string   `json:"userAgent" xml:"userAgent" require:"true"`
	HostModel        *string   `json:"hostModel" xml:"hostModel" require:"true"`
	SignatureVersion *string   `json:"signatureVersion" xml:"signatureVersion" require:"true"`
	IsEnableMD5      *bool     `json:"isEnableMD5" xml:"isEnableMD5" require:"true"`
	IsEnableCrc      *bool     `json:"isEnableCrc" xml:"isEnableCrc" require:"true"`
	ReadTimeout      *int      `json:"readTimeout" xml:"readTimeout" require:"true"`
	ConnectTimeout   *int      `json:"connectTimeout" xml:"connectTimeout" require:"true"`
	LocalAddr        *string   `json:"localAddr" xml:"localAddr" require:"true"`
	HttpProxy        *string   `json:"httpProxy" xml:"httpProxy" require:"true"`
	HttpsProxy       *string   `json:"httpsProxy" xml:"httpsProxy" require:"true"`
	NoProxy          *string   `json:"noProxy" xml:"noProxy" require:"true"`
	Socks5Proxy      *string   `json:"socks5Proxy" xml:"socks5Proxy" require:"true"`
	Socks5NetWork    *string   `json:"socks5NetWork" xml:"socks5NetWork" require:"true"`
	MaxIdleConns     *int      `json:"maxIdleConns" xml:"maxIdleConns" require:"true"`
	AddtionalHeaders []*string `json:"addtionalHeaders" xml:"addtionalHeaders" require:"true" type:"Repeated"`
}

func (s Config) String() string {
	return service.Prettify(s)
}

func (s Config) GoString() string {
	return s.String()
}

func (s *Config) SetAccessKeyId(v string) *Config {
	s.AccessKeyId = &v
	return s
}

func (s *Config) SetAccessKeySecret(v string) *Config {
	s.AccessKeySecret = &v
	return s
}

func (s *Config) SetType(v string) *Config {
	s.Type = &v
	return s
}

func (s *Config) SetSecurityToken(v string) *Config {
	s.SecurityToken = &v
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

type DeleteLiveChannelRequest struct {
	BucketName  *string `json:"BucketName" xml:"BucketName" require:"true"`
	ChannelName *string `json:"ChannelName" xml:"ChannelName" require:"true"`
}

func (s DeleteLiveChannelRequest) String() string {
	return service.Prettify(s)
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
	RequestId *string `json:"x-oss-request-id" xml:"x-oss-request-id" require:"true"`
}

func (s DeleteLiveChannelResponse) String() string {
	return service.Prettify(s)
}

func (s DeleteLiveChannelResponse) GoString() string {
	return s.String()
}

func (s *DeleteLiveChannelResponse) SetRequestId(v string) *DeleteLiveChannelResponse {
	s.RequestId = &v
	return s
}

type GetBucketLocationRequest struct {
	BucketName *string `json:"BucketName" xml:"BucketName" require:"true"`
}

func (s GetBucketLocationRequest) String() string {
	return service.Prettify(s)
}

func (s GetBucketLocationRequest) GoString() string {
	return s.String()
}

func (s *GetBucketLocationRequest) SetBucketName(v string) *GetBucketLocationRequest {
	s.BucketName = &v
	return s
}

type GetBucketLocationResponse struct {
	RequestId          *string `json:"x-oss-request-id" xml:"x-oss-request-id" require:"true"`
	LocationConstraint *string `json:"LocationConstraint" xml:"LocationConstraint" require:"true"`
}

func (s GetBucketLocationResponse) String() string {
	return service.Prettify(s)
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
	BucketName *string                       `json:"BucketName" xml:"BucketName" require:"true"`
	Filter     *ListLiveChannelRequestFilter `json:"Filter" xml:"Filter" type:"Struct"`
}

func (s ListLiveChannelRequest) String() string {
	return service.Prettify(s)
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
	Marker  *string `json:"marker" xml:"marker"`
	MaxKeys *string `json:"max-keys" xml:"max-keys"`
	Prefix  *string `json:"prefix" xml:"prefix"`
}

func (s ListLiveChannelRequestFilter) String() string {
	return service.Prettify(s)
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
	RequestId             *string                                       `json:"x-oss-request-id" xml:"x-oss-request-id" require:"true"`
	ListLiveChannelResult *ListLiveChannelResponseListLiveChannelResult `json:"ListLiveChannelResult" xml:"ListLiveChannelResult" require:"true" type:"Struct"`
}

func (s ListLiveChannelResponse) String() string {
	return service.Prettify(s)
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
	Prefix      *string                                                  `json:"Prefix" xml:"Prefix" require:"true"`
	Marker      *string                                                  `json:"Marker" xml:"Marker" require:"true"`
	MaxKeys     *string                                                  `json:"MaxKeys" xml:"MaxKeys" require:"true"`
	IsTruncated *string                                                  `json:"IsTruncated" xml:"IsTruncated" require:"true"`
	NextMarker  *string                                                  `json:"NextMarker" xml:"NextMarker" require:"true"`
	LiveChannel *ListLiveChannelResponseListLiveChannelResultLiveChannel `json:"LiveChannel" xml:"LiveChannel" require:"true" type:"Struct"`
}

func (s ListLiveChannelResponseListLiveChannelResult) String() string {
	return service.Prettify(s)
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
	Name         *string                                                             `json:"Name" xml:"Name" require:"true"`
	Description  *string                                                             `json:"Description" xml:"Description" require:"true"`
	Status       *string                                                             `json:"Status" xml:"Status" require:"true"`
	LastModified *string                                                             `json:"LastModified" xml:"LastModified" require:"true"`
	PublishUrls  *ListLiveChannelResponseListLiveChannelResultLiveChannelPublishUrls `json:"PublishUrls" xml:"PublishUrls" require:"true" type:"Struct"`
	PlayUrls     *ListLiveChannelResponseListLiveChannelResultLiveChannelPlayUrls    `json:"PlayUrls" xml:"PlayUrls" require:"true" type:"Struct"`
}

func (s ListLiveChannelResponseListLiveChannelResultLiveChannel) String() string {
	return service.Prettify(s)
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
	Url *string `json:"Url" xml:"Url" require:"true"`
}

func (s ListLiveChannelResponseListLiveChannelResultLiveChannelPublishUrls) String() string {
	return service.Prettify(s)
}

func (s ListLiveChannelResponseListLiveChannelResultLiveChannelPublishUrls) GoString() string {
	return s.String()
}

func (s *ListLiveChannelResponseListLiveChannelResultLiveChannelPublishUrls) SetUrl(v string) *ListLiveChannelResponseListLiveChannelResultLiveChannelPublishUrls {
	s.Url = &v
	return s
}

type ListLiveChannelResponseListLiveChannelResultLiveChannelPlayUrls struct {
	Url *string `json:"Url" xml:"Url" require:"true"`
}

func (s ListLiveChannelResponseListLiveChannelResultLiveChannelPlayUrls) String() string {
	return service.Prettify(s)
}

func (s ListLiveChannelResponseListLiveChannelResultLiveChannelPlayUrls) GoString() string {
	return s.String()
}

func (s *ListLiveChannelResponseListLiveChannelResultLiveChannelPlayUrls) SetUrl(v string) *ListLiveChannelResponseListLiveChannelResultLiveChannelPlayUrls {
	s.Url = &v
	return s
}

type GetObjectMetaRequest struct {
	BucketName *string `json:"BucketName" xml:"BucketName" require:"true"`
	ObjectName *string `json:"ObjectName" xml:"ObjectName" require:"true"`
}

func (s GetObjectMetaRequest) String() string {
	return service.Prettify(s)
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
	RequestId     *string `json:"x-oss-request-id" xml:"x-oss-request-id" require:"true"`
	ETag          *string `json:"etag" xml:"etag" require:"true"`
	ContentLength *string `json:"content-length" xml:"content-length" require:"true"`
	LastModified  *string `json:"last-modified" xml:"last-modified" require:"true"`
}

func (s GetObjectMetaResponse) String() string {
	return service.Prettify(s)
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
	BucketName *string `json:"BucketName" xml:"BucketName" require:"true"`
}

func (s GetBucketAclRequest) String() string {
	return service.Prettify(s)
}

func (s GetBucketAclRequest) GoString() string {
	return s.String()
}

func (s *GetBucketAclRequest) SetBucketName(v string) *GetBucketAclRequest {
	s.BucketName = &v
	return s
}

type GetBucketAclResponse struct {
	RequestId           *string                                  `json:"x-oss-request-id" xml:"x-oss-request-id" require:"true"`
	AccessControlPolicy *GetBucketAclResponseAccessControlPolicy `json:"AccessControlPolicy" xml:"AccessControlPolicy" require:"true" type:"Struct"`
}

func (s GetBucketAclResponse) String() string {
	return service.Prettify(s)
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
	Owner             *GetBucketAclResponseAccessControlPolicyOwner             `json:"Owner" xml:"Owner" require:"true" type:"Struct"`
	AccessControlList *GetBucketAclResponseAccessControlPolicyAccessControlList `json:"AccessControlList" xml:"AccessControlList" require:"true" type:"Struct"`
}

func (s GetBucketAclResponseAccessControlPolicy) String() string {
	return service.Prettify(s)
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
	ID          *string `json:"ID" xml:"ID" require:"true"`
	DisplayName *string `json:"DisplayName" xml:"DisplayName" require:"true"`
}

func (s GetBucketAclResponseAccessControlPolicyOwner) String() string {
	return service.Prettify(s)
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
	Grant *string `json:"Grant" xml:"Grant" require:"true"`
}

func (s GetBucketAclResponseAccessControlPolicyAccessControlList) String() string {
	return service.Prettify(s)
}

func (s GetBucketAclResponseAccessControlPolicyAccessControlList) GoString() string {
	return s.String()
}

func (s *GetBucketAclResponseAccessControlPolicyAccessControlList) SetGrant(v string) *GetBucketAclResponseAccessControlPolicyAccessControlList {
	s.Grant = &v
	return s
}

type ListPartsRequest struct {
	BucketName *string                 `json:"BucketName" xml:"BucketName" require:"true"`
	ObjectName *string                 `json:"ObjectName" xml:"ObjectName" require:"true"`
	Filter     *ListPartsRequestFilter `json:"Filter" xml:"Filter" require:"true" type:"Struct"`
}

func (s ListPartsRequest) String() string {
	return service.Prettify(s)
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
	UploadId         *string `json:"uploadId" xml:"uploadId" require:"true" signed:"true"`
	MaxParts         *int    `json:"max-parts" xml:"max-parts"`
	PartNumberMarker *int    `json:"part-number-marker" xml:"part-number-marker"`
	EncodingType     *string `json:"Encoding-type" xml:"Encoding-type"`
}

func (s ListPartsRequestFilter) String() string {
	return service.Prettify(s)
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
	RequestId       *string                           `json:"x-oss-request-id" xml:"x-oss-request-id" require:"true"`
	ListPartsResult *ListPartsResponseListPartsResult `json:"ListPartsResult" xml:"ListPartsResult" require:"true" type:"Struct"`
}

func (s ListPartsResponse) String() string {
	return service.Prettify(s)
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
	Bucket               *string                                 `json:"Bucket" xml:"Bucket" require:"true"`
	EncodingType         *string                                 `json:"EncodingType" xml:"EncodingType" require:"true"`
	Key                  *string                                 `json:"Key" xml:"Key" require:"true"`
	UploadId             *string                                 `json:"UploadId" xml:"UploadId" require:"true"`
	PartNumberMarker     *string                                 `json:"PartNumberMarker" xml:"PartNumberMarker" require:"true"`
	NextPartNumberMarker *string                                 `json:"NextPartNumberMarker" xml:"NextPartNumberMarker" require:"true"`
	MaxParts             *string                                 `json:"MaxParts" xml:"MaxParts" require:"true"`
	IsTruncated          *string                                 `json:"IsTruncated" xml:"IsTruncated" require:"true"`
	Part                 []*ListPartsResponseListPartsResultPart `json:"Part" xml:"Part" require:"true" type:"Repeated"`
}

func (s ListPartsResponseListPartsResult) String() string {
	return service.Prettify(s)
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
	PartNumber   *string `json:"PartNumber" xml:"PartNumber" require:"true"`
	LastModified *string `json:"LastModified" xml:"LastModified" require:"true"`
	ETag         *string `json:"ETag" xml:"ETag" require:"true"`
	Size         *string `json:"Size" xml:"Size" require:"true"`
}

func (s ListPartsResponseListPartsResultPart) String() string {
	return service.Prettify(s)
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
	BucketName  *string                             `json:"BucketName" xml:"BucketName" require:"true"`
	ChannelName *string                             `json:"ChannelName" xml:"ChannelName" require:"true"`
	Filter      *GetLiveChannelHistoryRequestFilter `json:"Filter" xml:"Filter" type:"Struct"`
}

func (s GetLiveChannelHistoryRequest) String() string {
	return service.Prettify(s)
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
	Comp *string `json:"comp" xml:"comp" signed:"true"`
}

func (s GetLiveChannelHistoryRequestFilter) String() string {
	return service.Prettify(s)
}

func (s GetLiveChannelHistoryRequestFilter) GoString() string {
	return s.String()
}

func (s *GetLiveChannelHistoryRequestFilter) SetComp(v string) *GetLiveChannelHistoryRequestFilter {
	s.Comp = &v
	return s
}

type GetLiveChannelHistoryResponse struct {
	RequestId          *string                                          `json:"x-oss-request-id" xml:"x-oss-request-id" require:"true"`
	LiveChannelHistory *GetLiveChannelHistoryResponseLiveChannelHistory `json:"LiveChannelHistory" xml:"LiveChannelHistory" require:"true" type:"Struct"`
}

func (s GetLiveChannelHistoryResponse) String() string {
	return service.Prettify(s)
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
	LiveRecord []*GetLiveChannelHistoryResponseLiveChannelHistoryLiveRecord `json:"LiveRecord" xml:"LiveRecord" require:"true" type:"Repeated"`
}

func (s GetLiveChannelHistoryResponseLiveChannelHistory) String() string {
	return service.Prettify(s)
}

func (s GetLiveChannelHistoryResponseLiveChannelHistory) GoString() string {
	return s.String()
}

func (s *GetLiveChannelHistoryResponseLiveChannelHistory) SetLiveRecord(v []*GetLiveChannelHistoryResponseLiveChannelHistoryLiveRecord) *GetLiveChannelHistoryResponseLiveChannelHistory {
	s.LiveRecord = v
	return s
}

type GetLiveChannelHistoryResponseLiveChannelHistoryLiveRecord struct {
	StartTime  *string `json:"StartTime" xml:"StartTime" require:"true"`
	EndTime    *string `json:"EndTime" xml:"EndTime" require:"true"`
	RemoteAddr *string `json:"RemoteAddr" xml:"RemoteAddr" require:"true"`
}

func (s GetLiveChannelHistoryResponseLiveChannelHistoryLiveRecord) String() string {
	return service.Prettify(s)
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
	BucketName *string                 `json:"BucketName" xml:"BucketName" require:"true"`
	Filter     *GetBucketRequestFilter `json:"Filter" xml:"Filter" type:"Struct"`
}

func (s GetBucketRequest) String() string {
	return service.Prettify(s)
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
	Delimiter    *string `json:"delimiter" xml:"delimiter"`
	Marker       *string `json:"marker" xml:"marker"`
	MaxKeys      *string `json:"max-keys" xml:"max-keys"`
	Prefix       *string `json:"prefix" xml:"prefix"`
	EncodingType *string `json:"encoding-type" xml:"encoding-type"`
}

func (s GetBucketRequestFilter) String() string {
	return service.Prettify(s)
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
	RequestId        *string                            `json:"x-oss-request-id" xml:"x-oss-request-id" require:"true"`
	ListBucketResult *GetBucketResponseListBucketResult `json:"ListBucketResult" xml:"ListBucketResult" require:"true" type:"Struct"`
}

func (s GetBucketResponse) String() string {
	return service.Prettify(s)
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
	Name           *string                                      `json:"Name" xml:"Name" require:"true"`
	Prefix         *string                                      `json:"Prefix" xml:"Prefix" require:"true"`
	Marker         *string                                      `json:"Marker" xml:"Marker" require:"true"`
	MaxKeys        *string                                      `json:"MaxKeys" xml:"MaxKeys" require:"true"`
	Delimiter      *string                                      `json:"Delimiter" xml:"Delimiter" require:"true"`
	IsTruncated    *string                                      `json:"IsTruncated" xml:"IsTruncated" require:"true"`
	EncodingType   *string                                      `json:"EncodingType" xml:"EncodingType" require:"true"`
	CommonPrefixes *string                                      `json:"CommonPrefixes" xml:"CommonPrefixes" require:"true"`
	Contents       []*GetBucketResponseListBucketResultContents `json:"Contents" xml:"Contents" require:"true" type:"Repeated"`
}

func (s GetBucketResponseListBucketResult) String() string {
	return service.Prettify(s)
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
	Key          *string                                         `json:"Key" xml:"Key" require:"true"`
	ETag         *string                                         `json:"ETag" xml:"ETag" require:"true"`
	LastModified *string                                         `json:"LastModified" xml:"LastModified" require:"true"`
	Size         *string                                         `json:"Size" xml:"Size" require:"true"`
	StorageClass *string                                         `json:"StorageClass" xml:"StorageClass" require:"true"`
	Owner        *GetBucketResponseListBucketResultContentsOwner `json:"Owner" xml:"Owner" require:"true" type:"Struct"`
}

func (s GetBucketResponseListBucketResultContents) String() string {
	return service.Prettify(s)
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
	ID          *string `json:"ID" xml:"ID" require:"true"`
	DisplayName *string `json:"DisplayName" xml:"DisplayName" require:"true"`
}

func (s GetBucketResponseListBucketResultContentsOwner) String() string {
	return service.Prettify(s)
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
	BucketName  *string `json:"BucketName" xml:"BucketName" require:"true"`
	ChannelName *string `json:"ChannelName" xml:"ChannelName" require:"true"`
}

func (s GetLiveChannelInfoRequest) String() string {
	return service.Prettify(s)
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
	RequestId                *string                                             `json:"x-oss-request-id" xml:"x-oss-request-id" require:"true"`
	LiveChannelConfiguration *GetLiveChannelInfoResponseLiveChannelConfiguration `json:"LiveChannelConfiguration" xml:"LiveChannelConfiguration" require:"true" type:"Struct"`
}

func (s GetLiveChannelInfoResponse) String() string {
	return service.Prettify(s)
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
	Description *string                                                   `json:"Description" xml:"Description" require:"true"`
	Status      *string                                                   `json:"Status" xml:"Status" require:"true"`
	Target      *GetLiveChannelInfoResponseLiveChannelConfigurationTarget `json:"Target" xml:"Target" require:"true" type:"Struct"`
}

func (s GetLiveChannelInfoResponseLiveChannelConfiguration) String() string {
	return service.Prettify(s)
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
	Type         *string `json:"Type" xml:"Type" require:"true"`
	FragDuration *string `json:"FragDuration" xml:"FragDuration" require:"true"`
	FragCount    *string `json:"FragCount" xml:"FragCount" require:"true"`
	PlaylistName *string `json:"PlaylistName" xml:"PlaylistName" require:"true"`
}

func (s GetLiveChannelInfoResponseLiveChannelConfigurationTarget) String() string {
	return service.Prettify(s)
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
	BucketName  *string                          `json:"BucketName" xml:"BucketName" require:"true"`
	ChannelName *string                          `json:"ChannelName" xml:"ChannelName" require:"true"`
	Filter      *GetLiveChannelStatRequestFilter `json:"Filter" xml:"Filter" type:"Struct"`
}

func (s GetLiveChannelStatRequest) String() string {
	return service.Prettify(s)
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
	Comp *string `json:"comp" xml:"comp" signed:"true"`
}

func (s GetLiveChannelStatRequestFilter) String() string {
	return service.Prettify(s)
}

func (s GetLiveChannelStatRequestFilter) GoString() string {
	return s.String()
}

func (s *GetLiveChannelStatRequestFilter) SetComp(v string) *GetLiveChannelStatRequestFilter {
	s.Comp = &v
	return s
}

type GetLiveChannelStatResponse struct {
	RequestId       *string                                    `json:"x-oss-request-id" xml:"x-oss-request-id" require:"true"`
	LiveChannelStat *GetLiveChannelStatResponseLiveChannelStat `json:"LiveChannelStat" xml:"LiveChannelStat" require:"true" type:"Struct"`
}

func (s GetLiveChannelStatResponse) String() string {
	return service.Prettify(s)
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
	Status        *string                                         `json:"Status" xml:"Status" require:"true"`
	ConnectedTime *string                                         `json:"ConnectedTime" xml:"ConnectedTime" require:"true"`
	RemoteAddr    *string                                         `json:"RemoteAddr" xml:"RemoteAddr" require:"true"`
	Video         *GetLiveChannelStatResponseLiveChannelStatVideo `json:"Video" xml:"Video" require:"true" type:"Struct"`
	Audio         *GetLiveChannelStatResponseLiveChannelStatAudio `json:"Audio" xml:"Audio" require:"true" type:"Struct"`
}

func (s GetLiveChannelStatResponseLiveChannelStat) String() string {
	return service.Prettify(s)
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
	Width     *string `json:"Width" xml:"Width" require:"true"`
	Height    *string `json:"Height" xml:"Height" require:"true"`
	FrameRate *string `json:"FrameRate" xml:"FrameRate" require:"true"`
	Bandwidth *string `json:"Bandwidth" xml:"Bandwidth" require:"true"`
	Codec     *string `json:"Codec" xml:"Codec" require:"true"`
}

func (s GetLiveChannelStatResponseLiveChannelStatVideo) String() string {
	return service.Prettify(s)
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
	Bandwidth  *string `json:"Bandwidth" xml:"Bandwidth" require:"true"`
	SampleRate *string `json:"SampleRate" xml:"SampleRate" require:"true"`
	Codec      *string `json:"Codec" xml:"Codec" require:"true"`
}

func (s GetLiveChannelStatResponseLiveChannelStatAudio) String() string {
	return service.Prettify(s)
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
	BucketName *string `json:"BucketName" xml:"BucketName" require:"true"`
	ObjectName *string `json:"ObjectName" xml:"ObjectName" require:"true"`
}

func (s DeleteObjectRequest) String() string {
	return service.Prettify(s)
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
	RequestId *string `json:"x-oss-request-id" xml:"x-oss-request-id" require:"true"`
}

func (s DeleteObjectResponse) String() string {
	return service.Prettify(s)
}

func (s DeleteObjectResponse) GoString() string {
	return s.String()
}

func (s *DeleteObjectResponse) SetRequestId(v string) *DeleteObjectResponse {
	s.RequestId = &v
	return s
}

type AbortMultipartUploadRequest struct {
	BucketName *string                            `json:"BucketName" xml:"BucketName" require:"true"`
	ObjectName *string                            `json:"ObjectName" xml:"ObjectName" require:"true"`
	Filter     *AbortMultipartUploadRequestFilter `json:"Filter" xml:"Filter" require:"true" type:"Struct"`
}

func (s AbortMultipartUploadRequest) String() string {
	return service.Prettify(s)
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
	UploadId *string `json:"uploadId" xml:"uploadId" require:"true" signed:"true"`
}

func (s AbortMultipartUploadRequestFilter) String() string {
	return service.Prettify(s)
}

func (s AbortMultipartUploadRequestFilter) GoString() string {
	return s.String()
}

func (s *AbortMultipartUploadRequestFilter) SetUploadId(v string) *AbortMultipartUploadRequestFilter {
	s.UploadId = &v
	return s
}

type AbortMultipartUploadResponse struct {
	RequestId *string `json:"x-oss-request-id" xml:"x-oss-request-id" require:"true"`
}

func (s AbortMultipartUploadResponse) String() string {
	return service.Prettify(s)
}

func (s AbortMultipartUploadResponse) GoString() string {
	return s.String()
}

func (s *AbortMultipartUploadResponse) SetRequestId(v string) *AbortMultipartUploadResponse {
	s.RequestId = &v
	return s
}

type AppendObjectRequest struct {
	BucketName *string                    `json:"BucketName" xml:"BucketName" require:"true"`
	ObjectName *string                    `json:"ObjectName" xml:"ObjectName" require:"true"`
	UserMeta   map[string]string          `json:"UserMeta" xml:"UserMeta"`
	Body       io.Reader                  `json:"body" xml:"body"`
	Filter     *AppendObjectRequestFilter `json:"Filter" xml:"Filter" require:"true" type:"Struct"`
	Header     *AppendObjectRequestHeader `json:"Header" xml:"Header" type:"Struct"`
}

func (s AppendObjectRequest) String() string {
	return service.Prettify(s)
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

func (s *AppendObjectRequest) SetUserMeta(v map[string]string) *AppendObjectRequest {
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
	Position *string `json:"position" xml:"position" require:"true" signed:"true"`
}

func (s AppendObjectRequestFilter) String() string {
	return service.Prettify(s)
}

func (s AppendObjectRequestFilter) GoString() string {
	return s.String()
}

func (s *AppendObjectRequestFilter) SetPosition(v string) *AppendObjectRequestFilter {
	s.Position = &v
	return s
}

type AppendObjectRequestHeader struct {
	CacheControl         *string `json:"Cache-Control" xml:"Cache-Control"`
	ContentDisposition   *string `json:"Content-Disposition" xml:"Content-Disposition"`
	ContentEncoding      *string `json:"Content-Encoding" xml:"Content-Encoding"`
	ContentMD5           *string `json:"Content-MD5" xml:"Content-MD5"`
	Expires              *string `json:"Expires" xml:"Expires"`
	ServerSideEncryption *string `json:"x-oss-server-side-encryption" xml:"x-oss-server-side-encryption"`
	ObjectAcl            *string `json:"x-oss-object-acl" xml:"x-oss-object-acl"`
	StorageClass         *string `json:"x-oss-storage-class" xml:"x-oss-storage-class"`
	ContentType          *string `json:"content-type" xml:"content-type"`
}

func (s AppendObjectRequestHeader) String() string {
	return service.Prettify(s)
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
	RequestId          *string `json:"x-oss-request-id" xml:"x-oss-request-id" require:"true"`
	NextAppendPosition *string `json:"x-oss-next-append-position" xml:"x-oss-next-append-position" require:"true"`
	HashCrc64ecma      *string `json:"x-oss-hash-crc64ecma" xml:"x-oss-hash-crc64ecma" require:"true"`
}

func (s AppendObjectResponse) String() string {
	return service.Prettify(s)
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
	BucketName *string                      `json:"BucketName" xml:"BucketName" require:"true"`
	ObjectName *string                      `json:"ObjectName" xml:"ObjectName" require:"true"`
	Filter     *UploadPartCopyRequestFilter `json:"Filter" xml:"Filter" require:"true" type:"Struct"`
	Header     *UploadPartCopyRequestHeader `json:"Header" xml:"Header" require:"true" type:"Struct"`
}

func (s UploadPartCopyRequest) String() string {
	return service.Prettify(s)
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
	PartNumber *string `json:"partNumber" xml:"partNumber" require:"true" signed:"true"`
	UploadId   *string `json:"uploadId" xml:"uploadId" require:"true" signed:"true"`
}

func (s UploadPartCopyRequestFilter) String() string {
	return service.Prettify(s)
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
	CopySource                  *string `json:"x-oss-copy-source" xml:"x-oss-copy-source" require:"true"`
	CopySourceRange             *string `json:"x-oss-copy-source-range" xml:"x-oss-copy-source-range" require:"true"`
	CopySourceIfMatch           *string `json:"x-oss-copy-source-if-match" xml:"x-oss-copy-source-if-match"`
	CopySourceIfNoneMatch       *string `json:"x-oss-copy-source-if-none-match" xml:"x-oss-copy-source-if-none-match"`
	CopySourceIfUnmodifiedSince *string `json:"x-oss-copy-source-if-unmodified-since" xml:"x-oss-copy-source-if-unmodified-since"`
	CopySourceIfModifiedSince   *string `json:"x-oss-copy-source-if-modified-since" xml:"x-oss-copy-source-if-modified-since"`
}

func (s UploadPartCopyRequestHeader) String() string {
	return service.Prettify(s)
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
	RequestId      *string                               `json:"x-oss-request-id" xml:"x-oss-request-id" require:"true"`
	CopyPartResult *UploadPartCopyResponseCopyPartResult `json:"CopyPartResult" xml:"CopyPartResult" require:"true" type:"Struct"`
}

func (s UploadPartCopyResponse) String() string {
	return service.Prettify(s)
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
	LastModified *string `json:"LastModified" xml:"LastModified" require:"true"`
	ETag         *string `json:"ETag" xml:"ETag" require:"true"`
}

func (s UploadPartCopyResponseCopyPartResult) String() string {
	return service.Prettify(s)
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
	BucketName  *string                      `json:"BucketName" xml:"BucketName" require:"true"`
	ChannelName *string                      `json:"ChannelName" xml:"ChannelName" require:"true"`
	Filter      *GetVodPlaylistRequestFilter `json:"Filter" xml:"Filter" require:"true" type:"Struct"`
}

func (s GetVodPlaylistRequest) String() string {
	return service.Prettify(s)
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
	EndTime   *string `json:"endTime" xml:"endTime" require:"true" signed:"true"`
	StartTime *string `json:"startTime" xml:"startTime" require:"true" signed:"true"`
}

func (s GetVodPlaylistRequestFilter) String() string {
	return service.Prettify(s)
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
	RequestId *string `json:"x-oss-request-id" xml:"x-oss-request-id" require:"true"`
}

func (s GetVodPlaylistResponse) String() string {
	return service.Prettify(s)
}

func (s GetVodPlaylistResponse) GoString() string {
	return s.String()
}

func (s *GetVodPlaylistResponse) SetRequestId(v string) *GetVodPlaylistResponse {
	s.RequestId = &v
	return s
}

type DeleteBucketCORSRequest struct {
	BucketName *string `json:"BucketName" xml:"BucketName" require:"true"`
}

func (s DeleteBucketCORSRequest) String() string {
	return service.Prettify(s)
}

func (s DeleteBucketCORSRequest) GoString() string {
	return s.String()
}

func (s *DeleteBucketCORSRequest) SetBucketName(v string) *DeleteBucketCORSRequest {
	s.BucketName = &v
	return s
}

type DeleteBucketCORSResponse struct {
	RequestId *string `json:"x-oss-request-id" xml:"x-oss-request-id" require:"true"`
}

func (s DeleteBucketCORSResponse) String() string {
	return service.Prettify(s)
}

func (s DeleteBucketCORSResponse) GoString() string {
	return s.String()
}

func (s *DeleteBucketCORSResponse) SetRequestId(v string) *DeleteBucketCORSResponse {
	s.RequestId = &v
	return s
}

type GetObjectRequest struct {
	BucketName *string                 `json:"BucketName" xml:"BucketName" require:"true"`
	ObjectName *string                 `json:"ObjectName" xml:"ObjectName" require:"true"`
	Header     *GetObjectRequestHeader `json:"Header" xml:"Header" type:"Struct"`
}

func (s GetObjectRequest) String() string {
	return service.Prettify(s)
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
	ResponseContentType        *string `json:"response-content-type" xml:"response-content-type"`
	ResponseContentLanguage    *string `json:"response-content-language" xml:"response-content-language"`
	ResponseExpires            *string `json:"response-expires" xml:"response-expires"`
	ResponseCacheControl       *string `json:"response-cache-control" xml:"response-cache-control"`
	ResponseContentDisposition *string `json:"response-content-disposition" xml:"response-content-disposition"`
	ResponseContentEncoding    *string `json:"response-content-encoding" xml:"response-content-encoding"`
	Range                      *string `json:"Range" xml:"Range"`
	IfModifiedSince            *string `json:"If-Modified-Since" xml:"If-Modified-Since"`
	IfUnmodifiedSince          *string `json:"If-Unmodified-Since" xml:"If-Unmodified-Since"`
	IfMatch                    *string `json:"If-Match" xml:"If-Match"`
	IfNoneMatch                *string `json:"If-None-Match" xml:"If-None-Match"`
	AcceptEncoding             *string `json:"Accept-Encoding" xml:"Accept-Encoding"`
}

func (s GetObjectRequestHeader) String() string {
	return service.Prettify(s)
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
	RequestId            *string   `json:"x-oss-request-id" xml:"x-oss-request-id" require:"true"`
	ObjectType           *string   `json:"x-oss-object-type" xml:"x-oss-object-type" require:"true"`
	ServerSideEncryption *string   `json:"x-oss-server-side-encryption" xml:"x-oss-server-side-encryption" require:"true"`
	TaggingCount         *string   `json:"x-oss-tagging-count" xml:"x-oss-tagging-count" require:"true"`
	Restore              *string   `json:"x-oss-restore" xml:"x-oss-restore" require:"true"`
	Body                 io.Reader `json:"body" xml:"body" require:"true"`
}

func (s GetObjectResponse) String() string {
	return service.Prettify(s)
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
	BucketName *string                  `json:"BucketName" xml:"BucketName" require:"true"`
	ObjectName *string                  `json:"ObjectName" xml:"ObjectName" require:"true"`
	Body       io.Reader                `json:"body" xml:"body"`
	Filter     *UploadPartRequestFilter `json:"Filter" xml:"Filter" require:"true" type:"Struct"`
}

func (s UploadPartRequest) String() string {
	return service.Prettify(s)
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
	PartNumber *string `json:"partNumber" xml:"partNumber" require:"true" signed:"true"`
	UploadId   *string `json:"uploadId" xml:"uploadId" require:"true" signed:"true"`
}

func (s UploadPartRequestFilter) String() string {
	return service.Prettify(s)
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
	RequestId *string `json:"x-oss-request-id" xml:"x-oss-request-id" require:"true"`
}

func (s UploadPartResponse) String() string {
	return service.Prettify(s)
}

func (s UploadPartResponse) GoString() string {
	return s.String()
}

func (s *UploadPartResponse) SetRequestId(v string) *UploadPartResponse {
	s.RequestId = &v
	return s
}

type GetBucketCORSRequest struct {
	BucketName *string `json:"BucketName" xml:"BucketName" require:"true"`
}

func (s GetBucketCORSRequest) String() string {
	return service.Prettify(s)
}

func (s GetBucketCORSRequest) GoString() string {
	return s.String()
}

func (s *GetBucketCORSRequest) SetBucketName(v string) *GetBucketCORSRequest {
	s.BucketName = &v
	return s
}

type GetBucketCORSResponse struct {
	RequestId         *string                                 `json:"x-oss-request-id" xml:"x-oss-request-id" require:"true"`
	CORSConfiguration *GetBucketCORSResponseCORSConfiguration `json:"CORSConfiguration" xml:"CORSConfiguration" require:"true" type:"Struct"`
}

func (s GetBucketCORSResponse) String() string {
	return service.Prettify(s)
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
	CORSRule []*GetBucketCORSResponseCORSConfigurationCORSRule `json:"CORSRule" xml:"CORSRule" require:"true" type:"Repeated"`
}

func (s GetBucketCORSResponseCORSConfiguration) String() string {
	return service.Prettify(s)
}

func (s GetBucketCORSResponseCORSConfiguration) GoString() string {
	return s.String()
}

func (s *GetBucketCORSResponseCORSConfiguration) SetCORSRule(v []*GetBucketCORSResponseCORSConfigurationCORSRule) *GetBucketCORSResponseCORSConfiguration {
	s.CORSRule = v
	return s
}

type GetBucketCORSResponseCORSConfigurationCORSRule struct {
	MaxAgeSeconds *string `json:"MaxAgeSeconds" xml:"MaxAgeSeconds" require:"true"`
}

func (s GetBucketCORSResponseCORSConfigurationCORSRule) String() string {
	return service.Prettify(s)
}

func (s GetBucketCORSResponseCORSConfigurationCORSRule) GoString() string {
	return s.String()
}

func (s *GetBucketCORSResponseCORSConfigurationCORSRule) SetMaxAgeSeconds(v string) *GetBucketCORSResponseCORSConfigurationCORSRule {
	s.MaxAgeSeconds = &v
	return s
}

type CopyObjectRequest struct {
	BucketName     *string                  `json:"BucketName" xml:"BucketName" require:"true"`
	DestObjectName *string                  `json:"DestObjectName" xml:"DestObjectName" require:"true"`
	Header         *CopyObjectRequestHeader `json:"Header" xml:"Header" require:"true" type:"Struct"`
}

func (s CopyObjectRequest) String() string {
	return service.Prettify(s)
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
	CopySource                  *string `json:"x-oss-copy-source" xml:"x-oss-copy-source" require:"true"`
	CopySourceIfMatch           *string `json:"x-oss-copy-source-if-match" xml:"x-oss-copy-source-if-match"`
	CopySourceIfNoneMatch       *string `json:"x-oss-copy-source-if-none-match" xml:"x-oss-copy-source-if-none-match"`
	CopySourceIfUnmodifiedSince *string `json:"x-oss-copy-source-if-unmodified-since" xml:"x-oss-copy-source-if-unmodified-since"`
	CopySourceIfModifiedSince   *string `json:"x-oss-copy-source-if-modified-since" xml:"x-oss-copy-source-if-modified-since"`
	MetadataDirective           *string `json:"x-oss-metadata-directive" xml:"x-oss-metadata-directive"`
	ServerSideEncryption        *string `json:"x-oss-server-side-encryption" xml:"x-oss-server-side-encryption"`
	ServerSideEncryptionKeyId   *string `json:"x-oss-server-side-encryption-key-id" xml:"x-oss-server-side-encryption-key-id"`
	ObjectAcl                   *string `json:"x-oss-object-acl" xml:"x-oss-object-acl"`
	StorageClass                *string `json:"x-oss-storage-class" xml:"x-oss-storage-class"`
	Tagging                     *string `json:"x-oss-tagging" xml:"x-oss-tagging"`
	TaggingDirective            *string `json:"x-oss-tagging-directive" xml:"x-oss-tagging-directive"`
}

func (s CopyObjectRequestHeader) String() string {
	return service.Prettify(s)
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
	RequestId        *string                             `json:"x-oss-request-id" xml:"x-oss-request-id" require:"true"`
	CopyObjectResult *CopyObjectResponseCopyObjectResult `json:"CopyObjectResult" xml:"CopyObjectResult" require:"true" type:"Struct"`
}

func (s CopyObjectResponse) String() string {
	return service.Prettify(s)
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
	LastModified *string `json:"LastModified" xml:"LastModified" require:"true"`
	ETag         *string `json:"ETag" xml:"ETag" require:"true"`
}

func (s CopyObjectResponseCopyObjectResult) String() string {
	return service.Prettify(s)
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
	BucketName *string `json:"BucketName" xml:"BucketName" require:"true"`
	ObjectName *string `json:"ObjectName" xml:"ObjectName" require:"true"`
}

func (s GetObjectTaggingRequest) String() string {
	return service.Prettify(s)
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
	RequestId *string                          `json:"x-oss-request-id" xml:"x-oss-request-id" require:"true"`
	Tagging   *GetObjectTaggingResponseTagging `json:"Tagging" xml:"Tagging" require:"true" type:"Struct"`
}

func (s GetObjectTaggingResponse) String() string {
	return service.Prettify(s)
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
	TagSet *GetObjectTaggingResponseTaggingTagSet `json:"TagSet" xml:"TagSet" require:"true" type:"Struct"`
}

func (s GetObjectTaggingResponseTagging) String() string {
	return service.Prettify(s)
}

func (s GetObjectTaggingResponseTagging) GoString() string {
	return s.String()
}

func (s *GetObjectTaggingResponseTagging) SetTagSet(v *GetObjectTaggingResponseTaggingTagSet) *GetObjectTaggingResponseTagging {
	s.TagSet = v
	return s
}

type GetObjectTaggingResponseTaggingTagSet struct {
	Tag []*GetObjectTaggingResponseTaggingTagSetTag `json:"Tag" xml:"Tag" require:"true" type:"Repeated"`
}

func (s GetObjectTaggingResponseTaggingTagSet) String() string {
	return service.Prettify(s)
}

func (s GetObjectTaggingResponseTaggingTagSet) GoString() string {
	return s.String()
}

func (s *GetObjectTaggingResponseTaggingTagSet) SetTag(v []*GetObjectTaggingResponseTaggingTagSetTag) *GetObjectTaggingResponseTaggingTagSet {
	s.Tag = v
	return s
}

type GetObjectTaggingResponseTaggingTagSetTag struct {
	Key   *string `json:"Key" xml:"Key" require:"true"`
	Value *string `json:"Value" xml:"Value" require:"true"`
}

func (s GetObjectTaggingResponseTaggingTagSetTag) String() string {
	return service.Prettify(s)
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
	BucketName *string `json:"BucketName" xml:"BucketName" require:"true"`
}

func (s DeleteBucketLifecycleRequest) String() string {
	return service.Prettify(s)
}

func (s DeleteBucketLifecycleRequest) GoString() string {
	return s.String()
}

func (s *DeleteBucketLifecycleRequest) SetBucketName(v string) *DeleteBucketLifecycleRequest {
	s.BucketName = &v
	return s
}

type DeleteBucketLifecycleResponse struct {
	RequestId *string `json:"x-oss-request-id" xml:"x-oss-request-id" require:"true"`
}

func (s DeleteBucketLifecycleResponse) String() string {
	return service.Prettify(s)
}

func (s DeleteBucketLifecycleResponse) GoString() string {
	return s.String()
}

func (s *DeleteBucketLifecycleResponse) SetRequestId(v string) *DeleteBucketLifecycleResponse {
	s.RequestId = &v
	return s
}

type DeleteBucketLoggingRequest struct {
	BucketName *string `json:"BucketName" xml:"BucketName" require:"true"`
}

func (s DeleteBucketLoggingRequest) String() string {
	return service.Prettify(s)
}

func (s DeleteBucketLoggingRequest) GoString() string {
	return s.String()
}

func (s *DeleteBucketLoggingRequest) SetBucketName(v string) *DeleteBucketLoggingRequest {
	s.BucketName = &v
	return s
}

type DeleteBucketLoggingResponse struct {
	RequestId *string `json:"x-oss-request-id" xml:"x-oss-request-id" require:"true"`
}

func (s DeleteBucketLoggingResponse) String() string {
	return service.Prettify(s)
}

func (s DeleteBucketLoggingResponse) GoString() string {
	return s.String()
}

func (s *DeleteBucketLoggingResponse) SetRequestId(v string) *DeleteBucketLoggingResponse {
	s.RequestId = &v
	return s
}

type DeleteBucketWebsiteRequest struct {
	BucketName *string `json:"BucketName" xml:"BucketName" require:"true"`
}

func (s DeleteBucketWebsiteRequest) String() string {
	return service.Prettify(s)
}

func (s DeleteBucketWebsiteRequest) GoString() string {
	return s.String()
}

func (s *DeleteBucketWebsiteRequest) SetBucketName(v string) *DeleteBucketWebsiteRequest {
	s.BucketName = &v
	return s
}

type DeleteBucketWebsiteResponse struct {
	RequestId *string `json:"x-oss-request-id" xml:"x-oss-request-id" require:"true"`
}

func (s DeleteBucketWebsiteResponse) String() string {
	return service.Prettify(s)
}

func (s DeleteBucketWebsiteResponse) GoString() string {
	return s.String()
}

func (s *DeleteBucketWebsiteResponse) SetRequestId(v string) *DeleteBucketWebsiteResponse {
	s.RequestId = &v
	return s
}

type GetSymlinkRequest struct {
	BucketName *string `json:"BucketName" xml:"BucketName" require:"true"`
	ObjectName *string `json:"ObjectName" xml:"ObjectName" require:"true"`
}

func (s GetSymlinkRequest) String() string {
	return service.Prettify(s)
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
	RequestId     *string `json:"x-oss-request-id" xml:"x-oss-request-id" require:"true"`
	SymlinkTarget *string `json:"x-oss-symlink-target" xml:"x-oss-symlink-target" require:"true"`
}

func (s GetSymlinkResponse) String() string {
	return service.Prettify(s)
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
	BucketName *string `json:"BucketName" xml:"BucketName" require:"true"`
}

func (s GetBucketLifecycleRequest) String() string {
	return service.Prettify(s)
}

func (s GetBucketLifecycleRequest) GoString() string {
	return s.String()
}

func (s *GetBucketLifecycleRequest) SetBucketName(v string) *GetBucketLifecycleRequest {
	s.BucketName = &v
	return s
}

type GetBucketLifecycleResponse struct {
	RequestId              *string                                           `json:"x-oss-request-id" xml:"x-oss-request-id" require:"true"`
	LifecycleConfiguration *GetBucketLifecycleResponseLifecycleConfiguration `json:"LifecycleConfiguration" xml:"LifecycleConfiguration" require:"true" type:"Struct"`
}

func (s GetBucketLifecycleResponse) String() string {
	return service.Prettify(s)
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
	Rule []*GetBucketLifecycleResponseLifecycleConfigurationRule `json:"Rule" xml:"Rule" require:"true" type:"Repeated"`
}

func (s GetBucketLifecycleResponseLifecycleConfiguration) String() string {
	return service.Prettify(s)
}

func (s GetBucketLifecycleResponseLifecycleConfiguration) GoString() string {
	return s.String()
}

func (s *GetBucketLifecycleResponseLifecycleConfiguration) SetRule(v []*GetBucketLifecycleResponseLifecycleConfigurationRule) *GetBucketLifecycleResponseLifecycleConfiguration {
	s.Rule = v
	return s
}

type GetBucketLifecycleResponseLifecycleConfigurationRule struct {
	ID                   *string                                                                   `json:"ID" xml:"ID" require:"true"`
	Prefix               *string                                                                   `json:"Prefix" xml:"Prefix" require:"true"`
	Status               *string                                                                   `json:"Status" xml:"Status" require:"true"`
	Expiration           *GetBucketLifecycleResponseLifecycleConfigurationRuleExpiration           `json:"Expiration" xml:"Expiration" require:"true" type:"Struct"`
	Transition           *GetBucketLifecycleResponseLifecycleConfigurationRuleTransition           `json:"Transition" xml:"Transition" require:"true" type:"Struct"`
	AbortMultipartUpload *GetBucketLifecycleResponseLifecycleConfigurationRuleAbortMultipartUpload `json:"AbortMultipartUpload" xml:"AbortMultipartUpload" require:"true" type:"Struct"`
	Tag                  *GetBucketLifecycleResponseLifecycleConfigurationRuleTag                  `json:"Tag" xml:"Tag" require:"true" type:"Struct"`
}

func (s GetBucketLifecycleResponseLifecycleConfigurationRule) String() string {
	return service.Prettify(s)
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
	Days              *int    `json:"Days" xml:"Days" require:"true"`
	CreatedBeforeDate *string `json:"CreatedBeforeDate" xml:"CreatedBeforeDate" require:"true"`
}

func (s GetBucketLifecycleResponseLifecycleConfigurationRuleExpiration) String() string {
	return service.Prettify(s)
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
	Days         *int    `json:"Days" xml:"Days" require:"true"`
	StorageClass *string `json:"StorageClass" xml:"StorageClass" require:"true"`
}

func (s GetBucketLifecycleResponseLifecycleConfigurationRuleTransition) String() string {
	return service.Prettify(s)
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
	Days              *int    `json:"Days" xml:"Days" require:"true"`
	CreatedBeforeDate *string `json:"CreatedBeforeDate" xml:"CreatedBeforeDate" require:"true"`
}

func (s GetBucketLifecycleResponseLifecycleConfigurationRuleAbortMultipartUpload) String() string {
	return service.Prettify(s)
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
	Key   *string `json:"Key" xml:"Key" require:"true"`
	Value *string `json:"Value" xml:"Value" require:"true"`
}

func (s GetBucketLifecycleResponseLifecycleConfigurationRuleTag) String() string {
	return service.Prettify(s)
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
	BucketName *string                  `json:"BucketName" xml:"BucketName" require:"true"`
	ObjectName *string                  `json:"ObjectName" xml:"ObjectName" require:"true"`
	Header     *PutSymlinkRequestHeader `json:"Header" xml:"Header" require:"true" type:"Struct"`
}

func (s PutSymlinkRequest) String() string {
	return service.Prettify(s)
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
	SymlinkTarget *string `json:"x-oss-symlink-target" xml:"x-oss-symlink-target" require:"true"`
	StorageClass  *string `json:"x-oss-storage-class" xml:"x-oss-storage-class"`
}

func (s PutSymlinkRequestHeader) String() string {
	return service.Prettify(s)
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
	RequestId *string `json:"x-oss-request-id" xml:"x-oss-request-id" require:"true"`
}

func (s PutSymlinkResponse) String() string {
	return service.Prettify(s)
}

func (s PutSymlinkResponse) GoString() string {
	return s.String()
}

func (s *PutSymlinkResponse) SetRequestId(v string) *PutSymlinkResponse {
	s.RequestId = &v
	return s
}

type GetBucketRefererRequest struct {
	BucketName *string `json:"BucketName" xml:"BucketName" require:"true"`
}

func (s GetBucketRefererRequest) String() string {
	return service.Prettify(s)
}

func (s GetBucketRefererRequest) GoString() string {
	return s.String()
}

func (s *GetBucketRefererRequest) SetBucketName(v string) *GetBucketRefererRequest {
	s.BucketName = &v
	return s
}

type GetBucketRefererResponse struct {
	RequestId            *string                                       `json:"x-oss-request-id" xml:"x-oss-request-id" require:"true"`
	RefererConfiguration *GetBucketRefererResponseRefererConfiguration `json:"RefererConfiguration" xml:"RefererConfiguration" require:"true" type:"Struct"`
}

func (s GetBucketRefererResponse) String() string {
	return service.Prettify(s)
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
	AllowEmptyReferer *bool                                                    `json:"AllowEmptyReferer" xml:"AllowEmptyReferer" require:"true"`
	RefererList       *GetBucketRefererResponseRefererConfigurationRefererList `json:"RefererList" xml:"RefererList" require:"true" type:"Struct"`
}

func (s GetBucketRefererResponseRefererConfiguration) String() string {
	return service.Prettify(s)
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
	Referer []*string `json:"Referer" xml:"Referer" require:"true" type:"Repeated"`
}

func (s GetBucketRefererResponseRefererConfigurationRefererList) String() string {
	return service.Prettify(s)
}

func (s GetBucketRefererResponseRefererConfigurationRefererList) GoString() string {
	return s.String()
}

func (s *GetBucketRefererResponseRefererConfigurationRefererList) SetReferer(v []*string) *GetBucketRefererResponseRefererConfigurationRefererList {
	s.Referer = v
	return s
}

type CallbackRequest struct {
	BucketName *string `json:"BucketName" xml:"BucketName" require:"true"`
}

func (s CallbackRequest) String() string {
	return service.Prettify(s)
}

func (s CallbackRequest) GoString() string {
	return s.String()
}

func (s *CallbackRequest) SetBucketName(v string) *CallbackRequest {
	s.BucketName = &v
	return s
}

type CallbackResponse struct {
	RequestId *string `json:"x-oss-request-id" xml:"x-oss-request-id" require:"true"`
}

func (s CallbackResponse) String() string {
	return service.Prettify(s)
}

func (s CallbackResponse) GoString() string {
	return s.String()
}

func (s *CallbackResponse) SetRequestId(v string) *CallbackResponse {
	s.RequestId = &v
	return s
}

type GetBucketLoggingRequest struct {
	BucketName *string `json:"BucketName" xml:"BucketName" require:"true"`
}

func (s GetBucketLoggingRequest) String() string {
	return service.Prettify(s)
}

func (s GetBucketLoggingRequest) GoString() string {
	return s.String()
}

func (s *GetBucketLoggingRequest) SetBucketName(v string) *GetBucketLoggingRequest {
	s.BucketName = &v
	return s
}

type GetBucketLoggingResponse struct {
	RequestId           *string                                      `json:"x-oss-request-id" xml:"x-oss-request-id" require:"true"`
	BucketLoggingStatus *GetBucketLoggingResponseBucketLoggingStatus `json:"BucketLoggingStatus" xml:"BucketLoggingStatus" require:"true" type:"Struct"`
}

func (s GetBucketLoggingResponse) String() string {
	return service.Prettify(s)
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
	LoggingEnabled *GetBucketLoggingResponseBucketLoggingStatusLoggingEnabled `json:"LoggingEnabled" xml:"LoggingEnabled" require:"true" type:"Struct"`
}

func (s GetBucketLoggingResponseBucketLoggingStatus) String() string {
	return service.Prettify(s)
}

func (s GetBucketLoggingResponseBucketLoggingStatus) GoString() string {
	return s.String()
}

func (s *GetBucketLoggingResponseBucketLoggingStatus) SetLoggingEnabled(v *GetBucketLoggingResponseBucketLoggingStatusLoggingEnabled) *GetBucketLoggingResponseBucketLoggingStatus {
	s.LoggingEnabled = v
	return s
}

type GetBucketLoggingResponseBucketLoggingStatusLoggingEnabled struct {
	TargetBucket *string `json:"TargetBucket" xml:"TargetBucket" require:"true"`
	TargetPrefix *string `json:"TargetPrefix" xml:"TargetPrefix" require:"true"`
}

func (s GetBucketLoggingResponseBucketLoggingStatusLoggingEnabled) String() string {
	return service.Prettify(s)
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
	BucketName *string                    `json:"BucketName" xml:"BucketName" require:"true"`
	ObjectName *string                    `json:"ObjectName" xml:"ObjectName" require:"true"`
	Header     *PutObjectAclRequestHeader `json:"Header" xml:"Header" require:"true" type:"Struct"`
}

func (s PutObjectAclRequest) String() string {
	return service.Prettify(s)
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
	ObjectAcl *string `json:"x-oss-object-acl" xml:"x-oss-object-acl" require:"true"`
}

func (s PutObjectAclRequestHeader) String() string {
	return service.Prettify(s)
}

func (s PutObjectAclRequestHeader) GoString() string {
	return s.String()
}

func (s *PutObjectAclRequestHeader) SetObjectAcl(v string) *PutObjectAclRequestHeader {
	s.ObjectAcl = &v
	return s
}

type PutObjectAclResponse struct {
	RequestId *string `json:"x-oss-request-id" xml:"x-oss-request-id" require:"true"`
}

func (s PutObjectAclResponse) String() string {
	return service.Prettify(s)
}

func (s PutObjectAclResponse) GoString() string {
	return s.String()
}

func (s *PutObjectAclResponse) SetRequestId(v string) *PutObjectAclResponse {
	s.RequestId = &v
	return s
}

type GetBucketInfoRequest struct {
	BucketName *string `json:"BucketName" xml:"BucketName" require:"true"`
}

func (s GetBucketInfoRequest) String() string {
	return service.Prettify(s)
}

func (s GetBucketInfoRequest) GoString() string {
	return s.String()
}

func (s *GetBucketInfoRequest) SetBucketName(v string) *GetBucketInfoRequest {
	s.BucketName = &v
	return s
}

type GetBucketInfoResponse struct {
	RequestId  *string                          `json:"x-oss-request-id" xml:"x-oss-request-id" require:"true"`
	BucketInfo *GetBucketInfoResponseBucketInfo `json:"BucketInfo" xml:"BucketInfo" require:"true" type:"Struct"`
}

func (s GetBucketInfoResponse) String() string {
	return service.Prettify(s)
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
	Bucket *GetBucketInfoResponseBucketInfoBucket `json:"Bucket" xml:"Bucket" require:"true" type:"Struct"`
}

func (s GetBucketInfoResponseBucketInfo) String() string {
	return service.Prettify(s)
}

func (s GetBucketInfoResponseBucketInfo) GoString() string {
	return s.String()
}

func (s *GetBucketInfoResponseBucketInfo) SetBucket(v *GetBucketInfoResponseBucketInfoBucket) *GetBucketInfoResponseBucketInfo {
	s.Bucket = v
	return s
}

type GetBucketInfoResponseBucketInfoBucket struct {
	CreationDate       *string                                                 `json:"CreationDate" xml:"CreationDate" require:"true"`
	ExtranetEndpoint   *string                                                 `json:"ExtranetEndpoint" xml:"ExtranetEndpoint" require:"true"`
	IntranetEndpoint   *string                                                 `json:"IntranetEndpoint" xml:"IntranetEndpoint" require:"true"`
	Location           *string                                                 `json:"Location" xml:"Location" require:"true"`
	Name               *string                                                 `json:"Name" xml:"Name" require:"true"`
	DataRedundancyType *string                                                 `json:"DataRedundancyType" xml:"DataRedundancyType" require:"true"`
	StorageClass       *string                                                 `json:"StorageClass" xml:"StorageClass" require:"true"`
	Comment            *string                                                 `json:"Comment" xml:"Comment" require:"true"`
	Owner              *GetBucketInfoResponseBucketInfoBucketOwner             `json:"Owner" xml:"Owner" require:"true" type:"Struct"`
	AccessControlList  *GetBucketInfoResponseBucketInfoBucketAccessControlList `json:"AccessControlList" xml:"AccessControlList" require:"true" type:"Struct"`
}

func (s GetBucketInfoResponseBucketInfoBucket) String() string {
	return service.Prettify(s)
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
	ID          *string `json:"ID" xml:"ID" require:"true"`
	DisplayName *string `json:"DisplayName" xml:"DisplayName" require:"true"`
}

func (s GetBucketInfoResponseBucketInfoBucketOwner) String() string {
	return service.Prettify(s)
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
	Grant *string `json:"Grant" xml:"Grant" require:"true"`
}

func (s GetBucketInfoResponseBucketInfoBucketAccessControlList) String() string {
	return service.Prettify(s)
}

func (s GetBucketInfoResponseBucketInfoBucketAccessControlList) GoString() string {
	return s.String()
}

func (s *GetBucketInfoResponseBucketInfoBucketAccessControlList) SetGrant(v string) *GetBucketInfoResponseBucketInfoBucketAccessControlList {
	s.Grant = &v
	return s
}

type PutLiveChannelStatusRequest struct {
	BucketName  *string                            `json:"BucketName" xml:"BucketName" require:"true"`
	ChannelName *string                            `json:"ChannelName" xml:"ChannelName" require:"true"`
	Filter      *PutLiveChannelStatusRequestFilter `json:"Filter" xml:"Filter" require:"true" type:"Struct"`
}

func (s PutLiveChannelStatusRequest) String() string {
	return service.Prettify(s)
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
	Status *string `json:"status" xml:"status" require:"true" signed:"true"`
}

func (s PutLiveChannelStatusRequestFilter) String() string {
	return service.Prettify(s)
}

func (s PutLiveChannelStatusRequestFilter) GoString() string {
	return s.String()
}

func (s *PutLiveChannelStatusRequestFilter) SetStatus(v string) *PutLiveChannelStatusRequestFilter {
	s.Status = &v
	return s
}

type PutLiveChannelStatusResponse struct {
	RequestId *string `json:"x-oss-request-id" xml:"x-oss-request-id" require:"true"`
}

func (s PutLiveChannelStatusResponse) String() string {
	return service.Prettify(s)
}

func (s PutLiveChannelStatusResponse) GoString() string {
	return s.String()
}

func (s *PutLiveChannelStatusResponse) SetRequestId(v string) *PutLiveChannelStatusResponse {
	s.RequestId = &v
	return s
}

type InitiateMultipartUploadRequest struct {
	BucketName *string                               `json:"BucketName" xml:"BucketName" require:"true"`
	ObjectName *string                               `json:"ObjectName" xml:"ObjectName" require:"true"`
	Filter     *InitiateMultipartUploadRequestFilter `json:"Filter" xml:"Filter" type:"Struct"`
	Header     *InitiateMultipartUploadRequestHeader `json:"Header" xml:"Header" type:"Struct"`
}

func (s InitiateMultipartUploadRequest) String() string {
	return service.Prettify(s)
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
	EncodingType *string `json:"encoding-type" xml:"encoding-type"`
}

func (s InitiateMultipartUploadRequestFilter) String() string {
	return service.Prettify(s)
}

func (s InitiateMultipartUploadRequestFilter) GoString() string {
	return s.String()
}

func (s *InitiateMultipartUploadRequestFilter) SetEncodingType(v string) *InitiateMultipartUploadRequestFilter {
	s.EncodingType = &v
	return s
}

type InitiateMultipartUploadRequestHeader struct {
	CacheControl              *string `json:"Cache-Control" xml:"Cache-Control"`
	ContentDisposition        *string `json:"Content-Disposition" xml:"Content-Disposition"`
	ContentEncoding           *string `json:"Content-Encoding" xml:"Content-Encoding"`
	Expires                   *string `json:"Expires" xml:"Expires"`
	ServerSideEncryption      *string `json:"x-oss-server-side-encryption" xml:"x-oss-server-side-encryption"`
	ServerSideEncryptionKeyId *string `json:"x-oss-server-side-encryption-key-id" xml:"x-oss-server-side-encryption-key-id"`
	StorageClass              *string `json:"x-oss-storage-class" xml:"x-oss-storage-class"`
	Tagging                   *string `json:"x-oss-tagging" xml:"x-oss-tagging"`
	ContentType               *string `json:"content-type" xml:"content-type"`
}

func (s InitiateMultipartUploadRequestHeader) String() string {
	return service.Prettify(s)
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
	RequestId                     *string                                                       `json:"x-oss-request-id" xml:"x-oss-request-id" require:"true"`
	InitiateMultipartUploadResult *InitiateMultipartUploadResponseInitiateMultipartUploadResult `json:"InitiateMultipartUploadResult" xml:"InitiateMultipartUploadResult" require:"true" type:"Struct"`
}

func (s InitiateMultipartUploadResponse) String() string {
	return service.Prettify(s)
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
	Bucket   *string `json:"Bucket" xml:"Bucket" require:"true"`
	Key      *string `json:"Key" xml:"Key" require:"true"`
	UploadId *string `json:"UploadId" xml:"UploadId" require:"true"`
}

func (s InitiateMultipartUploadResponseInitiateMultipartUploadResult) String() string {
	return service.Prettify(s)
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
	BucketName *string                    `json:"BucketName" xml:"BucketName" require:"true"`
	ObjectName *string                    `json:"ObjectName" xml:"ObjectName" require:"true"`
	Header     *OptionObjectRequestHeader `json:"Header" xml:"Header" require:"true" type:"Struct"`
}

func (s OptionObjectRequest) String() string {
	return service.Prettify(s)
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
	Origin                      *string `json:"Origin" xml:"Origin" require:"true"`
	AccessControlRequestMethod  *string `json:"Access-Control-Request-Method" xml:"Access-Control-Request-Method" require:"true"`
	AccessControlRequestHeaders *string `json:"Access-Control-Request-Headers" xml:"Access-Control-Request-Headers" require:"true"`
}

func (s OptionObjectRequestHeader) String() string {
	return service.Prettify(s)
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
	RequestId                  *string `json:"x-oss-request-id" xml:"x-oss-request-id" require:"true"`
	AccessControlAllowOrigin   *string `json:"access-control-allow-origin" xml:"access-control-allow-origin" require:"true"`
	AccessControlAllowMethods  *string `json:"access-control-allow-methods" xml:"access-control-allow-methods" require:"true"`
	AccessControlAllowHeaders  *string `json:"access-control-allow-headers" xml:"access-control-allow-headers" require:"true"`
	AccessControlExposeHeaders *string `json:"access-control-expose-headers" xml:"access-control-expose-headers" require:"true"`
	AccessControlMaxAge        *string `json:"access-control-max-age" xml:"access-control-max-age" require:"true"`
}

func (s OptionObjectResponse) String() string {
	return service.Prettify(s)
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
	BucketName   *string                       `json:"BucketName" xml:"BucketName" require:"true"`
	ChannelName  *string                       `json:"ChannelName" xml:"ChannelName" require:"true"`
	PlaylistName *string                       `json:"PlaylistName" xml:"PlaylistName" require:"true"`
	Filter       *PostVodPlaylistRequestFilter `json:"Filter" xml:"Filter" require:"true" type:"Struct"`
}

func (s PostVodPlaylistRequest) String() string {
	return service.Prettify(s)
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
	EndTime   *string `json:"endTime" xml:"endTime" require:"true" signed:"true"`
	StartTime *string `json:"startTime" xml:"startTime" require:"true" signed:"true"`
}

func (s PostVodPlaylistRequestFilter) String() string {
	return service.Prettify(s)
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
	RequestId *string `json:"x-oss-request-id" xml:"x-oss-request-id" require:"true"`
}

func (s PostVodPlaylistResponse) String() string {
	return service.Prettify(s)
}

func (s PostVodPlaylistResponse) GoString() string {
	return s.String()
}

func (s *PostVodPlaylistResponse) SetRequestId(v string) *PostVodPlaylistResponse {
	s.RequestId = &v
	return s
}

type PostObjectRequest struct {
	BucketName *string `json:"BucketName" xml:"BucketName" require:"true"`
}

func (s PostObjectRequest) String() string {
	return service.Prettify(s)
}

func (s PostObjectRequest) GoString() string {
	return s.String()
}

func (s *PostObjectRequest) SetBucketName(v string) *PostObjectRequest {
	s.BucketName = &v
	return s
}

type PostObjectResponse struct {
	RequestId            *string `json:"x-oss-request-id" xml:"x-oss-request-id" require:"true"`
	ServerSideEncryption *string `json:"x-oss-server-side-encryption" xml:"x-oss-server-side-encryption" require:"true"`
}

func (s PostObjectResponse) String() string {
	return service.Prettify(s)
}

func (s PostObjectResponse) GoString() string {
	return s.String()
}

func (s *PostObjectResponse) SetRequestId(v string) *PostObjectResponse {
	s.RequestId = &v
	return s
}

func (s *PostObjectResponse) SetServerSideEncryption(v string) *PostObjectResponse {
	s.ServerSideEncryption = &v
	return s
}

type HeadObjectRequest struct {
	BucketName *string                  `json:"BucketName" xml:"BucketName" require:"true"`
	ObjectName *string                  `json:"ObjectName" xml:"ObjectName" require:"true"`
	Header     *HeadObjectRequestHeader `json:"Header" xml:"Header" type:"Struct"`
}

func (s HeadObjectRequest) String() string {
	return service.Prettify(s)
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
	IfModifiedSince   *string `json:"If-Modified-Since" xml:"If-Modified-Since"`
	IfUnmodifiedSince *string `json:"If-Unmodified-Since" xml:"If-Unmodified-Since"`
	IfMatch           *string `json:"If-Match" xml:"If-Match"`
	IfNoneMatch       *string `json:"If-None-Match" xml:"If-None-Match"`
}

func (s HeadObjectRequestHeader) String() string {
	return service.Prettify(s)
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
	RequestId                  *string           `json:"x-oss-request-id" xml:"x-oss-request-id" require:"true"`
	UserMeta                   map[string]string `json:"usermeta" xml:"usermeta" require:"true"`
	ServerSideEncryption       *string           `json:"x-oss-server-side-encryption" xml:"x-oss-server-side-encryption" require:"true"`
	ServerSideEncryptionKeyId  *string           `json:"x-oss-server-side-encryption-key-id" xml:"x-oss-server-side-encryption-key-id" require:"true"`
	StorageClass               *string           `json:"x-oss-storage-class" xml:"x-oss-storage-class" require:"true"`
	ObjectType                 *string           `json:"x-oss-object-type" xml:"x-oss-object-type" require:"true"`
	NextAppendPosition         *string           `json:"x-oss-next-append-position" xml:"x-oss-next-append-position" require:"true"`
	HashCrc64ecma              *string           `json:"x-oss-hash-crc64ecma" xml:"x-oss-hash-crc64ecma" require:"true"`
	Expiration                 *string           `json:"x-oss-expiration" xml:"x-oss-expiration" require:"true"`
	Restore                    *string           `json:"x-oss-restore" xml:"x-oss-restore" require:"true"`
	ProcessStatus              *string           `json:"x-oss-process-status" xml:"x-oss-process-status" require:"true"`
	RequestCharged             *string           `json:"x-oss-request-charged" xml:"x-oss-request-charged" require:"true"`
	ContentMd5                 *string           `json:"content-md5" xml:"content-md5" require:"true"`
	LastModified               *string           `json:"last-modified" xml:"last-modified" require:"true"`
	AccessControlAllowOrigin   *string           `json:"access-control-allow-origin" xml:"access-control-allow-origin" require:"true"`
	AccessControlAllowMethods  *string           `json:"access-control-allow-methods" xml:"access-control-allow-methods" require:"true"`
	AccessControlMaxAge        *string           `json:"access-control-max-age" xml:"access-control-max-age" require:"true"`
	AccessControlAllowHeaders  *string           `json:"access-control-allow-headers" xml:"access-control-allow-headers" require:"true"`
	AccessControlExposeHeaders *string           `json:"access-control-expose-headers" xml:"access-control-expose-headers" require:"true"`
	TaggingCount               *string           `json:"x-oss-tagging-count" xml:"x-oss-tagging-count" require:"true"`
}

func (s HeadObjectResponse) String() string {
	return service.Prettify(s)
}

func (s HeadObjectResponse) GoString() string {
	return s.String()
}

func (s *HeadObjectResponse) SetRequestId(v string) *HeadObjectResponse {
	s.RequestId = &v
	return s
}

func (s *HeadObjectResponse) SetUserMeta(v map[string]string) *HeadObjectResponse {
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
	BucketName *string `json:"BucketName" xml:"BucketName" require:"true"`
	ObjectName *string `json:"ObjectName" xml:"ObjectName" require:"true"`
}

func (s DeleteObjectTaggingRequest) String() string {
	return service.Prettify(s)
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
	RequestId *string `json:"x-oss-request-id" xml:"x-oss-request-id" require:"true"`
}

func (s DeleteObjectTaggingResponse) String() string {
	return service.Prettify(s)
}

func (s DeleteObjectTaggingResponse) GoString() string {
	return s.String()
}

func (s *DeleteObjectTaggingResponse) SetRequestId(v string) *DeleteObjectTaggingResponse {
	s.RequestId = &v
	return s
}

type RestoreObjectRequest struct {
	BucketName *string `json:"BucketName" xml:"BucketName" require:"true"`
	ObjectName *string `json:"ObjectName" xml:"ObjectName" require:"true"`
}

func (s RestoreObjectRequest) String() string {
	return service.Prettify(s)
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
	RequestId *string `json:"x-oss-request-id" xml:"x-oss-request-id" require:"true"`
}

func (s RestoreObjectResponse) String() string {
	return service.Prettify(s)
}

func (s RestoreObjectResponse) GoString() string {
	return s.String()
}

func (s *RestoreObjectResponse) SetRequestId(v string) *RestoreObjectResponse {
	s.RequestId = &v
	return s
}

type GetObjectAclRequest struct {
	BucketName *string `json:"BucketName" xml:"BucketName" require:"true"`
	ObjectName *string `json:"ObjectName" xml:"ObjectName" require:"true"`
}

func (s GetObjectAclRequest) String() string {
	return service.Prettify(s)
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
	RequestId           *string                                  `json:"x-oss-request-id" xml:"x-oss-request-id" require:"true"`
	AccessControlPolicy *GetObjectAclResponseAccessControlPolicy `json:"AccessControlPolicy" xml:"AccessControlPolicy" require:"true" type:"Struct"`
}

func (s GetObjectAclResponse) String() string {
	return service.Prettify(s)
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
	Owner             *GetObjectAclResponseAccessControlPolicyOwner             `json:"Owner" xml:"Owner" require:"true" type:"Struct"`
	AccessControlList *GetObjectAclResponseAccessControlPolicyAccessControlList `json:"AccessControlList" xml:"AccessControlList" require:"true" type:"Struct"`
}

func (s GetObjectAclResponseAccessControlPolicy) String() string {
	return service.Prettify(s)
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
	ID          *string `json:"ID" xml:"ID" require:"true"`
	DisplayName *string `json:"DisplayName" xml:"DisplayName" require:"true"`
}

func (s GetObjectAclResponseAccessControlPolicyOwner) String() string {
	return service.Prettify(s)
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
	Grant *string `json:"Grant" xml:"Grant" require:"true"`
}

func (s GetObjectAclResponseAccessControlPolicyAccessControlList) String() string {
	return service.Prettify(s)
}

func (s GetObjectAclResponseAccessControlPolicyAccessControlList) GoString() string {
	return s.String()
}

func (s *GetObjectAclResponseAccessControlPolicyAccessControlList) SetGrant(v string) *GetObjectAclResponseAccessControlPolicyAccessControlList {
	s.Grant = &v
	return s
}

type PutBucketAclRequest struct {
	BucketName *string                    `json:"BucketName" xml:"BucketName" require:"true"`
	Header     *PutBucketAclRequestHeader `json:"Header" xml:"Header" require:"true" type:"Struct"`
}

func (s PutBucketAclRequest) String() string {
	return service.Prettify(s)
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
	Acl *string `json:"x-oss-acl" xml:"x-oss-acl" require:"true"`
}

func (s PutBucketAclRequestHeader) String() string {
	return service.Prettify(s)
}

func (s PutBucketAclRequestHeader) GoString() string {
	return s.String()
}

func (s *PutBucketAclRequestHeader) SetAcl(v string) *PutBucketAclRequestHeader {
	s.Acl = &v
	return s
}

type PutBucketAclResponse struct {
	RequestId *string `json:"x-oss-request-id" xml:"x-oss-request-id" require:"true"`
}

func (s PutBucketAclResponse) String() string {
	return service.Prettify(s)
}

func (s PutBucketAclResponse) GoString() string {
	return s.String()
}

func (s *PutBucketAclResponse) SetRequestId(v string) *PutBucketAclResponse {
	s.RequestId = &v
	return s
}

type DeleteBucketRequest struct {
	BucketName *string `json:"BucketName" xml:"BucketName" require:"true"`
}

func (s DeleteBucketRequest) String() string {
	return service.Prettify(s)
}

func (s DeleteBucketRequest) GoString() string {
	return s.String()
}

func (s *DeleteBucketRequest) SetBucketName(v string) *DeleteBucketRequest {
	s.BucketName = &v
	return s
}

type DeleteBucketResponse struct {
	RequestId *string `json:"x-oss-request-id" xml:"x-oss-request-id" require:"true"`
}

func (s DeleteBucketResponse) String() string {
	return service.Prettify(s)
}

func (s DeleteBucketResponse) GoString() string {
	return s.String()
}

func (s *DeleteBucketResponse) SetRequestId(v string) *DeleteBucketResponse {
	s.RequestId = &v
	return s
}

type PutObjectRequest struct {
	BucketName *string                 `json:"BucketName" xml:"BucketName" require:"true"`
	ObjectName *string                 `json:"ObjectName" xml:"ObjectName" require:"true"`
	UserMeta   map[string]string       `json:"UserMeta" xml:"UserMeta"`
	Body       io.Reader               `json:"body" xml:"body"`
	Header     *PutObjectRequestHeader `json:"Header" xml:"Header" type:"Struct"`
}

func (s PutObjectRequest) String() string {
	return service.Prettify(s)
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

func (s *PutObjectRequest) SetUserMeta(v map[string]string) *PutObjectRequest {
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
	Authorization             *string `json:"Authorization" xml:"Authorization"`
	CacheControl              *string `json:"Cache-Control" xml:"Cache-Control"`
	ContentDisposition        *string `json:"Content-Disposition" xml:"Content-Disposition"`
	ContentEncoding           *string `json:"Content-Encoding" xml:"Content-Encoding"`
	ContentMD5                *string `json:"Content-MD5" xml:"Content-MD5"`
	ContentLength             *string `json:"Content-Length" xml:"Content-Length"`
	ETag                      *string `json:"CETag" xml:"CETag"`
	Expires                   *string `json:"Expires" xml:"Expires"`
	ServerSideEncryption      *string `json:"x-oss-server-side-encryption" xml:"x-oss-server-side-encryption"`
	ServerSideEncryptionKeyId *string `json:"x-oss-server-side-encryption-key-id" xml:"x-oss-server-side-encryption-key-id"`
	ObjectAcl                 *string `json:"x-oss-object-acl" xml:"x-oss-object-acl"`
	StorageClass              *string `json:"x-oss-storage-class" xml:"x-oss-storage-class"`
	Tagging                   *string `json:"x-oss-tagging" xml:"x-oss-tagging"`
	ContentType               *string `json:"content-type" xml:"content-type"`
}

func (s PutObjectRequestHeader) String() string {
	return service.Prettify(s)
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
	RequestId     *string `json:"x-oss-request-id" xml:"x-oss-request-id" require:"true"`
	HashCrc64ecma *string `json:"x-oss-hash-crc64ecma" xml:"x-oss-hash-crc64ecma" require:"true"`
	ServerTime    *string `json:"x-oss-server-time" xml:"x-oss-server-time" require:"true"`
	BucketVersion *string `json:"x-oss-bucket-version" xml:"x-oss-bucket-version" require:"true"`
}

func (s PutObjectResponse) String() string {
	return service.Prettify(s)
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
	service.BaseClient
}

func NewClient(config *Config) (*Client, error) {
	client := &Client{}
	input := make(map[string]interface{})
	byt, _ := json.Marshal(config)
	err := json.Unmarshal(byt, &input)
	if err != nil {
		return nil, err
	}
	err = client.InitClient(input)
	if err != nil {
		return nil, err
	}
	return client, nil
}
func (client *Client) DeleteLiveChannel(request *DeleteLiveChannelRequest, runtime *RuntimeObject) (*DeleteLiveChannelResponse, error) {
	err := tea.Validate(request)
	if err != nil {
		return nil, err
	}
	err = tea.Validate(runtime)
	if err != nil {
		return nil, err
	}
	_runtime := map[string]interface{}{
		"timeouted":      "retry",
		"readTimeout":    client.DefaultNumber(tea.GetIntValue(runtime.ReadTimeout), client.ReadTimeout),
		"connectTimeout": client.DefaultNumber(tea.GetIntValue(runtime.ConnectTimeout), client.ConnectTimeout),
		"localAddr":      client.Default(tea.GetStringValue(runtime.LocalAddr), client.LocalAddr),
		"httpProxy":      client.Default(tea.GetStringValue(runtime.HttpProxy), client.HttpProxy),
		"httpsProxy":     client.Default(tea.GetStringValue(runtime.HttpsProxy), client.HttpsProxy),
		"noProxy":        client.Default(tea.GetStringValue(runtime.NoProxy), client.NoProxy),
		"socks5Proxy":    client.Default(tea.GetStringValue(runtime.Socks5Proxy), client.Socks5Proxy),
		"socks5NetWork":  client.Default(tea.GetStringValue(runtime.Socks5NetWork), client.Socks5NetWork),
		"maxIdleConns":   client.DefaultNumber(tea.GetIntValue(runtime.MaxIdleConns), client.MaxIdleConns),
		"retry": map[string]interface{}{
			"retryable":   tea.GetBoolValue(runtime.Autoretry),
			"maxAttempts": client.DefaultNumber(tea.GetIntValue(runtime.MaxAttempts), 3),
		},
		"backoff": map[string]interface{}{
			"policy": client.Default(tea.GetStringValue(runtime.BackoffPolicy), "no"),
			"period": client.DefaultNumber(tea.GetIntValue(runtime.BackoffPeriod), 1),
		},
		"ignoreSSL": tea.GetBoolValue(runtime.IgnoreSSL),
		"logger":    client.Logger,
		"listener":  runtime.Listener,
	}

	_resp := &DeleteLiveChannelResponse{}
	for _retryTimes := 0; tea.AllowRetry(_runtime["retry"], _retryTimes); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], _retryTimes)
			if _backoffTime > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, err = func() (*DeleteLiveChannelResponse, error) {
			request_ := tea.NewRequest()
			request_.Protocol = client.Protocol
			request_.Method = "DELETE"
			request_.Pathname = "/" + tea.ToString(tea.GetStringValue(request.ChannelName)) + "?live"
			request_.Headers = map[string]string{
				"host":       client.GetHost(tea.GetStringValue(request.BucketName)),
				"date":       client.GetDate(),
				"user-agent": client.GetUserAgent(),
			}
			request_.Headers["authorization"] = client.GetAuth(request_, tea.GetStringValue(request.BucketName))
			response_, err := tea.DoRequest(request_, _runtime)
			if err != nil {
				return nil, err
			}

			respMap := make(map[string]interface{})

			if client.IsFail(response_) {
				respMap, err = client.GetErrMessage(response_)
				if err != nil {
					return nil, err
				}

				err = tea.NewSDKError(map[string]interface{}{
					"code":    respMap["Code"],
					"message": respMap["Message"],
					"data": map[string]interface{}{
						"httpCode":  response_.StatusCode,
						"requestId": respMap["RequestId"],
						"hostId":    respMap["HostId"],
					},
				})
				return nil, err
			}

			_result := &DeleteLiveChannelResponse{}
			err = tea.Convert(response_.Headers, &_result)
			return _result, err
		}()
		if !tea.Retryable(err) {
			break
		}
	}

	return _resp, err
}

func (client *Client) GetBucketLocation(request *GetBucketLocationRequest, runtime *RuntimeObject) (*GetBucketLocationResponse, error) {
	err := tea.Validate(request)
	if err != nil {
		return nil, err
	}
	err = tea.Validate(runtime)
	if err != nil {
		return nil, err
	}
	_runtime := map[string]interface{}{
		"timeouted":      "retry",
		"readTimeout":    client.DefaultNumber(tea.GetIntValue(runtime.ReadTimeout), client.ReadTimeout),
		"connectTimeout": client.DefaultNumber(tea.GetIntValue(runtime.ConnectTimeout), client.ConnectTimeout),
		"localAddr":      client.Default(tea.GetStringValue(runtime.LocalAddr), client.LocalAddr),
		"httpProxy":      client.Default(tea.GetStringValue(runtime.HttpProxy), client.HttpProxy),
		"httpsProxy":     client.Default(tea.GetStringValue(runtime.HttpsProxy), client.HttpsProxy),
		"noProxy":        client.Default(tea.GetStringValue(runtime.NoProxy), client.NoProxy),
		"socks5Proxy":    client.Default(tea.GetStringValue(runtime.Socks5Proxy), client.Socks5Proxy),
		"socks5NetWork":  client.Default(tea.GetStringValue(runtime.Socks5NetWork), client.Socks5NetWork),
		"maxIdleConns":   client.DefaultNumber(tea.GetIntValue(runtime.MaxIdleConns), client.MaxIdleConns),
		"retry": map[string]interface{}{
			"retryable":   tea.GetBoolValue(runtime.Autoretry),
			"maxAttempts": client.DefaultNumber(tea.GetIntValue(runtime.MaxAttempts), 3),
		},
		"backoff": map[string]interface{}{
			"policy": client.Default(tea.GetStringValue(runtime.BackoffPolicy), "no"),
			"period": client.DefaultNumber(tea.GetIntValue(runtime.BackoffPeriod), 1),
		},
		"ignoreSSL": tea.GetBoolValue(runtime.IgnoreSSL),
		"logger":    client.Logger,
		"listener":  runtime.Listener,
	}

	_resp := &GetBucketLocationResponse{}
	for _retryTimes := 0; tea.AllowRetry(_runtime["retry"], _retryTimes); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], _retryTimes)
			if _backoffTime > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, err = func() (*GetBucketLocationResponse, error) {
			request_ := tea.NewRequest()
			request_.Protocol = client.Protocol
			request_.Method = "GET"
			request_.Pathname = "/?location"
			request_.Headers = map[string]string{
				"host":       client.GetHost(tea.GetStringValue(request.BucketName)),
				"date":       client.GetDate(),
				"user-agent": client.GetUserAgent(),
			}
			request_.Headers["authorization"] = client.GetAuth(request_, tea.GetStringValue(request.BucketName))
			response_, err := tea.DoRequest(request_, _runtime)
			if err != nil {
				return nil, err
			}

			respMap := make(map[string]interface{})

			if client.IsFail(response_) {
				respMap, err = client.GetErrMessage(response_)
				if err != nil {
					return nil, err
				}

				err = tea.NewSDKError(map[string]interface{}{
					"code":    respMap["Code"],
					"message": respMap["Message"],
					"data": map[string]interface{}{
						"httpCode":  response_.StatusCode,
						"requestId": respMap["RequestId"],
						"hostId":    respMap["HostId"],
					},
				})
				return nil, err
			}

			respMap, err = client.ParseXml(response_, new(GetBucketLocationResponse))
			if err != nil {
				return nil, err
			}

			_result := &GetBucketLocationResponse{}
			err = tea.Convert(tea.ToMap(map[string]interface{}{
				"LocationConstraint": respMap["LocationConstraint"],
			}, response_.Headers), &_result)
			return _result, err
		}()
		if !tea.Retryable(err) {
			break
		}
	}

	return _resp, err
}

func (client *Client) ListLiveChannel(request *ListLiveChannelRequest, runtime *RuntimeObject) (*ListLiveChannelResponse, error) {
	err := tea.Validate(request)
	if err != nil {
		return nil, err
	}
	err = tea.Validate(runtime)
	if err != nil {
		return nil, err
	}
	_runtime := map[string]interface{}{
		"timeouted":      "retry",
		"readTimeout":    client.DefaultNumber(tea.GetIntValue(runtime.ReadTimeout), client.ReadTimeout),
		"connectTimeout": client.DefaultNumber(tea.GetIntValue(runtime.ConnectTimeout), client.ConnectTimeout),
		"localAddr":      client.Default(tea.GetStringValue(runtime.LocalAddr), client.LocalAddr),
		"httpProxy":      client.Default(tea.GetStringValue(runtime.HttpProxy), client.HttpProxy),
		"httpsProxy":     client.Default(tea.GetStringValue(runtime.HttpsProxy), client.HttpsProxy),
		"noProxy":        client.Default(tea.GetStringValue(runtime.NoProxy), client.NoProxy),
		"socks5Proxy":    client.Default(tea.GetStringValue(runtime.Socks5Proxy), client.Socks5Proxy),
		"socks5NetWork":  client.Default(tea.GetStringValue(runtime.Socks5NetWork), client.Socks5NetWork),
		"maxIdleConns":   client.DefaultNumber(tea.GetIntValue(runtime.MaxIdleConns), client.MaxIdleConns),
		"retry": map[string]interface{}{
			"retryable":   tea.GetBoolValue(runtime.Autoretry),
			"maxAttempts": client.DefaultNumber(tea.GetIntValue(runtime.MaxAttempts), 3),
		},
		"backoff": map[string]interface{}{
			"policy": client.Default(tea.GetStringValue(runtime.BackoffPolicy), "no"),
			"period": client.DefaultNumber(tea.GetIntValue(runtime.BackoffPeriod), 1),
		},
		"ignoreSSL": tea.GetBoolValue(runtime.IgnoreSSL),
		"logger":    client.Logger,
		"listener":  runtime.Listener,
	}

	_resp := &ListLiveChannelResponse{}
	for _retryTimes := 0; tea.AllowRetry(_runtime["retry"], _retryTimes); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], _retryTimes)
			if _backoffTime > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, err = func() (*ListLiveChannelResponse, error) {
			request_ := tea.NewRequest()
			request_.Protocol = client.Protocol
			request_.Method = "GET"
			request_.Pathname = "/?live"
			request_.Headers = map[string]string{
				"host":       client.GetHost(tea.GetStringValue(request.BucketName)),
				"date":       client.GetDate(),
				"user-agent": client.GetUserAgent(),
			}
			request_.Query = client.ToQuery(tea.ToMap(request.Filter))
			request_.Headers["authorization"] = client.GetAuth(request_, tea.GetStringValue(request.BucketName))
			response_, err := tea.DoRequest(request_, _runtime)
			if err != nil {
				return nil, err
			}

			respMap := make(map[string]interface{})

			if client.IsFail(response_) {
				respMap, err = client.GetErrMessage(response_)
				if err != nil {
					return nil, err
				}

				err = tea.NewSDKError(map[string]interface{}{
					"code":    respMap["Code"],
					"message": respMap["Message"],
					"data": map[string]interface{}{
						"httpCode":  response_.StatusCode,
						"requestId": respMap["RequestId"],
						"hostId":    respMap["HostId"],
					},
				})
				return nil, err
			}

			respMap, err = client.ParseXml(response_, new(ListLiveChannelResponse))
			if err != nil {
				return nil, err
			}

			_result := &ListLiveChannelResponse{}
			err = tea.Convert(tea.ToMap(map[string]interface{}{
				"ListLiveChannelResult": respMap["ListLiveChannelResult"],
			}, response_.Headers), &_result)
			return _result, err
		}()
		if !tea.Retryable(err) {
			break
		}
	}

	return _resp, err
}

func (client *Client) GetObjectMeta(request *GetObjectMetaRequest, runtime *RuntimeObject) (*GetObjectMetaResponse, error) {
	err := tea.Validate(request)
	if err != nil {
		return nil, err
	}
	err = tea.Validate(runtime)
	if err != nil {
		return nil, err
	}
	_runtime := map[string]interface{}{
		"timeouted":      "retry",
		"readTimeout":    client.DefaultNumber(tea.GetIntValue(runtime.ReadTimeout), client.ReadTimeout),
		"connectTimeout": client.DefaultNumber(tea.GetIntValue(runtime.ConnectTimeout), client.ConnectTimeout),
		"localAddr":      client.Default(tea.GetStringValue(runtime.LocalAddr), client.LocalAddr),
		"httpProxy":      client.Default(tea.GetStringValue(runtime.HttpProxy), client.HttpProxy),
		"httpsProxy":     client.Default(tea.GetStringValue(runtime.HttpsProxy), client.HttpsProxy),
		"noProxy":        client.Default(tea.GetStringValue(runtime.NoProxy), client.NoProxy),
		"socks5Proxy":    client.Default(tea.GetStringValue(runtime.Socks5Proxy), client.Socks5Proxy),
		"socks5NetWork":  client.Default(tea.GetStringValue(runtime.Socks5NetWork), client.Socks5NetWork),
		"maxIdleConns":   client.DefaultNumber(tea.GetIntValue(runtime.MaxIdleConns), client.MaxIdleConns),
		"retry": map[string]interface{}{
			"retryable":   tea.GetBoolValue(runtime.Autoretry),
			"maxAttempts": client.DefaultNumber(tea.GetIntValue(runtime.MaxAttempts), 3),
		},
		"backoff": map[string]interface{}{
			"policy": client.Default(tea.GetStringValue(runtime.BackoffPolicy), "no"),
			"period": client.DefaultNumber(tea.GetIntValue(runtime.BackoffPeriod), 1),
		},
		"ignoreSSL": tea.GetBoolValue(runtime.IgnoreSSL),
		"logger":    client.Logger,
		"listener":  runtime.Listener,
	}

	_resp := &GetObjectMetaResponse{}
	for _retryTimes := 0; tea.AllowRetry(_runtime["retry"], _retryTimes); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], _retryTimes)
			if _backoffTime > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, err = func() (*GetObjectMetaResponse, error) {
			request_ := tea.NewRequest()
			request_.Protocol = client.Protocol
			request_.Method = "HEAD"
			request_.Pathname = "/" + tea.ToString(tea.GetStringValue(request.ObjectName)) + "?objectMeta"
			request_.Headers = map[string]string{
				"host":       client.GetHost(tea.GetStringValue(request.BucketName)),
				"date":       client.GetDate(),
				"user-agent": client.GetUserAgent(),
			}
			request_.Headers["authorization"] = client.GetAuth(request_, tea.GetStringValue(request.BucketName))
			response_, err := tea.DoRequest(request_, _runtime)
			if err != nil {
				return nil, err
			}

			respMap := make(map[string]interface{})

			if client.IsFail(response_) {
				respMap, err = client.GetErrMessage(response_)
				if err != nil {
					return nil, err
				}

				err = tea.NewSDKError(map[string]interface{}{
					"code":    respMap["Code"],
					"message": respMap["Message"],
					"data": map[string]interface{}{
						"httpCode":  response_.StatusCode,
						"requestId": respMap["RequestId"],
						"hostId":    respMap["HostId"],
					},
				})
				return nil, err
			}

			_result := &GetObjectMetaResponse{}
			err = tea.Convert(response_.Headers, &_result)
			return _result, err
		}()
		if !tea.Retryable(err) {
			break
		}
	}

	return _resp, err
}

func (client *Client) GetBucketAcl(request *GetBucketAclRequest, runtime *RuntimeObject) (*GetBucketAclResponse, error) {
	err := tea.Validate(request)
	if err != nil {
		return nil, err
	}
	err = tea.Validate(runtime)
	if err != nil {
		return nil, err
	}
	_runtime := map[string]interface{}{
		"timeouted":      "retry",
		"readTimeout":    client.DefaultNumber(tea.GetIntValue(runtime.ReadTimeout), client.ReadTimeout),
		"connectTimeout": client.DefaultNumber(tea.GetIntValue(runtime.ConnectTimeout), client.ConnectTimeout),
		"localAddr":      client.Default(tea.GetStringValue(runtime.LocalAddr), client.LocalAddr),
		"httpProxy":      client.Default(tea.GetStringValue(runtime.HttpProxy), client.HttpProxy),
		"httpsProxy":     client.Default(tea.GetStringValue(runtime.HttpsProxy), client.HttpsProxy),
		"noProxy":        client.Default(tea.GetStringValue(runtime.NoProxy), client.NoProxy),
		"socks5Proxy":    client.Default(tea.GetStringValue(runtime.Socks5Proxy), client.Socks5Proxy),
		"socks5NetWork":  client.Default(tea.GetStringValue(runtime.Socks5NetWork), client.Socks5NetWork),
		"maxIdleConns":   client.DefaultNumber(tea.GetIntValue(runtime.MaxIdleConns), client.MaxIdleConns),
		"retry": map[string]interface{}{
			"retryable":   tea.GetBoolValue(runtime.Autoretry),
			"maxAttempts": client.DefaultNumber(tea.GetIntValue(runtime.MaxAttempts), 3),
		},
		"backoff": map[string]interface{}{
			"policy": client.Default(tea.GetStringValue(runtime.BackoffPolicy), "no"),
			"period": client.DefaultNumber(tea.GetIntValue(runtime.BackoffPeriod), 1),
		},
		"ignoreSSL": tea.GetBoolValue(runtime.IgnoreSSL),
		"logger":    client.Logger,
		"listener":  runtime.Listener,
	}

	_resp := &GetBucketAclResponse{}
	for _retryTimes := 0; tea.AllowRetry(_runtime["retry"], _retryTimes); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], _retryTimes)
			if _backoffTime > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, err = func() (*GetBucketAclResponse, error) {
			request_ := tea.NewRequest()
			request_.Protocol = client.Protocol
			request_.Method = "GET"
			request_.Pathname = "/?acl"
			request_.Headers = map[string]string{
				"host":       client.GetHost(tea.GetStringValue(request.BucketName)),
				"date":       client.GetDate(),
				"user-agent": client.GetUserAgent(),
			}
			request_.Headers["authorization"] = client.GetAuth(request_, tea.GetStringValue(request.BucketName))
			response_, err := tea.DoRequest(request_, _runtime)
			if err != nil {
				return nil, err
			}

			respMap := make(map[string]interface{})

			if client.IsFail(response_) {
				respMap, err = client.GetErrMessage(response_)
				if err != nil {
					return nil, err
				}

				err = tea.NewSDKError(map[string]interface{}{
					"code":    respMap["Code"],
					"message": respMap["Message"],
					"data": map[string]interface{}{
						"httpCode":  response_.StatusCode,
						"requestId": respMap["RequestId"],
						"hostId":    respMap["HostId"],
					},
				})
				return nil, err
			}

			respMap, err = client.ParseXml(response_, new(GetBucketAclResponse))
			if err != nil {
				return nil, err
			}

			_result := &GetBucketAclResponse{}
			err = tea.Convert(tea.ToMap(map[string]interface{}{
				"AccessControlPolicy": respMap["AccessControlPolicy"],
			}, response_.Headers), &_result)
			return _result, err
		}()
		if !tea.Retryable(err) {
			break
		}
	}

	return _resp, err
}

func (client *Client) ListParts(request *ListPartsRequest, runtime *RuntimeObject) (*ListPartsResponse, error) {
	err := tea.Validate(request)
	if err != nil {
		return nil, err
	}
	err = tea.Validate(runtime)
	if err != nil {
		return nil, err
	}
	_runtime := map[string]interface{}{
		"timeouted":      "retry",
		"readTimeout":    client.DefaultNumber(tea.GetIntValue(runtime.ReadTimeout), client.ReadTimeout),
		"connectTimeout": client.DefaultNumber(tea.GetIntValue(runtime.ConnectTimeout), client.ConnectTimeout),
		"localAddr":      client.Default(tea.GetStringValue(runtime.LocalAddr), client.LocalAddr),
		"httpProxy":      client.Default(tea.GetStringValue(runtime.HttpProxy), client.HttpProxy),
		"httpsProxy":     client.Default(tea.GetStringValue(runtime.HttpsProxy), client.HttpsProxy),
		"noProxy":        client.Default(tea.GetStringValue(runtime.NoProxy), client.NoProxy),
		"socks5Proxy":    client.Default(tea.GetStringValue(runtime.Socks5Proxy), client.Socks5Proxy),
		"socks5NetWork":  client.Default(tea.GetStringValue(runtime.Socks5NetWork), client.Socks5NetWork),
		"maxIdleConns":   client.DefaultNumber(tea.GetIntValue(runtime.MaxIdleConns), client.MaxIdleConns),
		"retry": map[string]interface{}{
			"retryable":   tea.GetBoolValue(runtime.Autoretry),
			"maxAttempts": client.DefaultNumber(tea.GetIntValue(runtime.MaxAttempts), 3),
		},
		"backoff": map[string]interface{}{
			"policy": client.Default(tea.GetStringValue(runtime.BackoffPolicy), "no"),
			"period": client.DefaultNumber(tea.GetIntValue(runtime.BackoffPeriod), 1),
		},
		"ignoreSSL": tea.GetBoolValue(runtime.IgnoreSSL),
		"logger":    client.Logger,
		"listener":  runtime.Listener,
	}

	_resp := &ListPartsResponse{}
	for _retryTimes := 0; tea.AllowRetry(_runtime["retry"], _retryTimes); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], _retryTimes)
			if _backoffTime > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, err = func() (*ListPartsResponse, error) {
			request_ := tea.NewRequest()
			request_.Protocol = client.Protocol
			request_.Method = "GET"
			request_.Pathname = "/" + tea.ToString(tea.GetStringValue(request.ObjectName))
			request_.Headers = map[string]string{
				"host":       client.GetHost(tea.GetStringValue(request.BucketName)),
				"date":       client.GetDate(),
				"user-agent": client.GetUserAgent(),
			}
			request_.Query = client.ToQuery(tea.ToMap(request.Filter))
			request_.Headers["authorization"] = client.GetAuth(request_, tea.GetStringValue(request.BucketName))
			response_, err := tea.DoRequest(request_, _runtime)
			if err != nil {
				return nil, err
			}

			respMap := make(map[string]interface{})

			if client.IsFail(response_) {
				respMap, err = client.GetErrMessage(response_)
				if err != nil {
					return nil, err
				}

				err = tea.NewSDKError(map[string]interface{}{
					"code":    respMap["Code"],
					"message": respMap["Message"],
					"data": map[string]interface{}{
						"httpCode":  response_.StatusCode,
						"requestId": respMap["RequestId"],
						"hostId":    respMap["HostId"],
					},
				})
				return nil, err
			}

			respMap, err = client.ParseXml(response_, new(ListPartsResponse))
			if err != nil {
				return nil, err
			}

			_result := &ListPartsResponse{}
			err = tea.Convert(tea.ToMap(map[string]interface{}{
				"ListPartsResult": respMap["ListPartsResult"],
			}, response_.Headers), &_result)
			return _result, err
		}()
		if !tea.Retryable(err) {
			break
		}
	}

	return _resp, err
}

func (client *Client) GetLiveChannelHistory(request *GetLiveChannelHistoryRequest, runtime *RuntimeObject) (*GetLiveChannelHistoryResponse, error) {
	err := tea.Validate(request)
	if err != nil {
		return nil, err
	}
	err = tea.Validate(runtime)
	if err != nil {
		return nil, err
	}
	_runtime := map[string]interface{}{
		"timeouted":      "retry",
		"readTimeout":    client.DefaultNumber(tea.GetIntValue(runtime.ReadTimeout), client.ReadTimeout),
		"connectTimeout": client.DefaultNumber(tea.GetIntValue(runtime.ConnectTimeout), client.ConnectTimeout),
		"localAddr":      client.Default(tea.GetStringValue(runtime.LocalAddr), client.LocalAddr),
		"httpProxy":      client.Default(tea.GetStringValue(runtime.HttpProxy), client.HttpProxy),
		"httpsProxy":     client.Default(tea.GetStringValue(runtime.HttpsProxy), client.HttpsProxy),
		"noProxy":        client.Default(tea.GetStringValue(runtime.NoProxy), client.NoProxy),
		"socks5Proxy":    client.Default(tea.GetStringValue(runtime.Socks5Proxy), client.Socks5Proxy),
		"socks5NetWork":  client.Default(tea.GetStringValue(runtime.Socks5NetWork), client.Socks5NetWork),
		"maxIdleConns":   client.DefaultNumber(tea.GetIntValue(runtime.MaxIdleConns), client.MaxIdleConns),
		"retry": map[string]interface{}{
			"retryable":   tea.GetBoolValue(runtime.Autoretry),
			"maxAttempts": client.DefaultNumber(tea.GetIntValue(runtime.MaxAttempts), 3),
		},
		"backoff": map[string]interface{}{
			"policy": client.Default(tea.GetStringValue(runtime.BackoffPolicy), "no"),
			"period": client.DefaultNumber(tea.GetIntValue(runtime.BackoffPeriod), 1),
		},
		"ignoreSSL": tea.GetBoolValue(runtime.IgnoreSSL),
		"logger":    client.Logger,
		"listener":  runtime.Listener,
	}

	_resp := &GetLiveChannelHistoryResponse{}
	for _retryTimes := 0; tea.AllowRetry(_runtime["retry"], _retryTimes); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], _retryTimes)
			if _backoffTime > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, err = func() (*GetLiveChannelHistoryResponse, error) {
			request_ := tea.NewRequest()
			request_.Protocol = client.Protocol
			request_.Method = "GET"
			request_.Pathname = "/" + tea.ToString(tea.GetStringValue(request.ChannelName)) + "?live"
			request_.Headers = map[string]string{
				"host":       client.GetHost(tea.GetStringValue(request.BucketName)),
				"date":       client.GetDate(),
				"user-agent": client.GetUserAgent(),
			}
			request_.Query = client.ToQuery(tea.ToMap(request.Filter))
			request_.Headers["authorization"] = client.GetAuth(request_, tea.GetStringValue(request.BucketName))
			response_, err := tea.DoRequest(request_, _runtime)
			if err != nil {
				return nil, err
			}

			respMap := make(map[string]interface{})

			if client.IsFail(response_) {
				respMap, err = client.GetErrMessage(response_)
				if err != nil {
					return nil, err
				}

				err = tea.NewSDKError(map[string]interface{}{
					"code":    respMap["Code"],
					"message": respMap["Message"],
					"data": map[string]interface{}{
						"httpCode":  response_.StatusCode,
						"requestId": respMap["RequestId"],
						"hostId":    respMap["HostId"],
					},
				})
				return nil, err
			}

			respMap, err = client.ParseXml(response_, new(GetLiveChannelHistoryResponse))
			if err != nil {
				return nil, err
			}

			_result := &GetLiveChannelHistoryResponse{}
			err = tea.Convert(tea.ToMap(map[string]interface{}{
				"LiveChannelHistory": respMap["LiveChannelHistory"],
			}, response_.Headers), &_result)
			return _result, err
		}()
		if !tea.Retryable(err) {
			break
		}
	}

	return _resp, err
}

func (client *Client) GetBucket(request *GetBucketRequest, runtime *RuntimeObject) (*GetBucketResponse, error) {
	err := tea.Validate(request)
	if err != nil {
		return nil, err
	}
	err = tea.Validate(runtime)
	if err != nil {
		return nil, err
	}
	_runtime := map[string]interface{}{
		"timeouted":      "retry",
		"readTimeout":    client.DefaultNumber(tea.GetIntValue(runtime.ReadTimeout), client.ReadTimeout),
		"connectTimeout": client.DefaultNumber(tea.GetIntValue(runtime.ConnectTimeout), client.ConnectTimeout),
		"localAddr":      client.Default(tea.GetStringValue(runtime.LocalAddr), client.LocalAddr),
		"httpProxy":      client.Default(tea.GetStringValue(runtime.HttpProxy), client.HttpProxy),
		"httpsProxy":     client.Default(tea.GetStringValue(runtime.HttpsProxy), client.HttpsProxy),
		"noProxy":        client.Default(tea.GetStringValue(runtime.NoProxy), client.NoProxy),
		"socks5Proxy":    client.Default(tea.GetStringValue(runtime.Socks5Proxy), client.Socks5Proxy),
		"socks5NetWork":  client.Default(tea.GetStringValue(runtime.Socks5NetWork), client.Socks5NetWork),
		"maxIdleConns":   client.DefaultNumber(tea.GetIntValue(runtime.MaxIdleConns), client.MaxIdleConns),
		"retry": map[string]interface{}{
			"retryable":   tea.GetBoolValue(runtime.Autoretry),
			"maxAttempts": client.DefaultNumber(tea.GetIntValue(runtime.MaxAttempts), 3),
		},
		"backoff": map[string]interface{}{
			"policy": client.Default(tea.GetStringValue(runtime.BackoffPolicy), "no"),
			"period": client.DefaultNumber(tea.GetIntValue(runtime.BackoffPeriod), 1),
		},
		"ignoreSSL": tea.GetBoolValue(runtime.IgnoreSSL),
		"logger":    client.Logger,
		"listener":  runtime.Listener,
	}

	_resp := &GetBucketResponse{}
	for _retryTimes := 0; tea.AllowRetry(_runtime["retry"], _retryTimes); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], _retryTimes)
			if _backoffTime > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, err = func() (*GetBucketResponse, error) {
			request_ := tea.NewRequest()
			request_.Protocol = client.Protocol
			request_.Method = "GET"
			request_.Pathname = "/"
			request_.Headers = map[string]string{
				"host":       client.GetHost(tea.GetStringValue(request.BucketName)),
				"date":       client.GetDate(),
				"user-agent": client.GetUserAgent(),
			}
			request_.Query = client.ToQuery(tea.ToMap(request.Filter))
			request_.Headers["authorization"] = client.GetAuth(request_, tea.GetStringValue(request.BucketName))
			response_, err := tea.DoRequest(request_, _runtime)
			if err != nil {
				return nil, err
			}

			respMap := make(map[string]interface{})

			if client.IsFail(response_) {
				respMap, err = client.GetErrMessage(response_)
				if err != nil {
					return nil, err
				}

				err = tea.NewSDKError(map[string]interface{}{
					"code":    respMap["Code"],
					"message": respMap["Message"],
					"data": map[string]interface{}{
						"httpCode":  response_.StatusCode,
						"requestId": respMap["RequestId"],
						"hostId":    respMap["HostId"],
					},
				})
				return nil, err
			}

			respMap, err = client.ParseXml(response_, new(GetBucketResponse))
			if err != nil {
				return nil, err
			}

			_result := &GetBucketResponse{}
			err = tea.Convert(tea.ToMap(map[string]interface{}{
				"ListBucketResult": respMap["ListBucketResult"],
			}, response_.Headers), &_result)
			return _result, err
		}()
		if !tea.Retryable(err) {
			break
		}
	}

	return _resp, err
}

func (client *Client) GetLiveChannelInfo(request *GetLiveChannelInfoRequest, runtime *RuntimeObject) (*GetLiveChannelInfoResponse, error) {
	err := tea.Validate(request)
	if err != nil {
		return nil, err
	}
	err = tea.Validate(runtime)
	if err != nil {
		return nil, err
	}
	_runtime := map[string]interface{}{
		"timeouted":      "retry",
		"readTimeout":    client.DefaultNumber(tea.GetIntValue(runtime.ReadTimeout), client.ReadTimeout),
		"connectTimeout": client.DefaultNumber(tea.GetIntValue(runtime.ConnectTimeout), client.ConnectTimeout),
		"localAddr":      client.Default(tea.GetStringValue(runtime.LocalAddr), client.LocalAddr),
		"httpProxy":      client.Default(tea.GetStringValue(runtime.HttpProxy), client.HttpProxy),
		"httpsProxy":     client.Default(tea.GetStringValue(runtime.HttpsProxy), client.HttpsProxy),
		"noProxy":        client.Default(tea.GetStringValue(runtime.NoProxy), client.NoProxy),
		"socks5Proxy":    client.Default(tea.GetStringValue(runtime.Socks5Proxy), client.Socks5Proxy),
		"socks5NetWork":  client.Default(tea.GetStringValue(runtime.Socks5NetWork), client.Socks5NetWork),
		"maxIdleConns":   client.DefaultNumber(tea.GetIntValue(runtime.MaxIdleConns), client.MaxIdleConns),
		"retry": map[string]interface{}{
			"retryable":   tea.GetBoolValue(runtime.Autoretry),
			"maxAttempts": client.DefaultNumber(tea.GetIntValue(runtime.MaxAttempts), 3),
		},
		"backoff": map[string]interface{}{
			"policy": client.Default(tea.GetStringValue(runtime.BackoffPolicy), "no"),
			"period": client.DefaultNumber(tea.GetIntValue(runtime.BackoffPeriod), 1),
		},
		"ignoreSSL": tea.GetBoolValue(runtime.IgnoreSSL),
		"logger":    client.Logger,
		"listener":  runtime.Listener,
	}

	_resp := &GetLiveChannelInfoResponse{}
	for _retryTimes := 0; tea.AllowRetry(_runtime["retry"], _retryTimes); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], _retryTimes)
			if _backoffTime > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, err = func() (*GetLiveChannelInfoResponse, error) {
			request_ := tea.NewRequest()
			request_.Protocol = client.Protocol
			request_.Method = "GET"
			request_.Pathname = "/" + tea.ToString(tea.GetStringValue(request.ChannelName)) + "?live"
			request_.Headers = map[string]string{
				"host":       client.GetHost(tea.GetStringValue(request.BucketName)),
				"date":       client.GetDate(),
				"user-agent": client.GetUserAgent(),
			}
			request_.Headers["authorization"] = client.GetAuth(request_, tea.GetStringValue(request.BucketName))
			response_, err := tea.DoRequest(request_, _runtime)
			if err != nil {
				return nil, err
			}

			respMap := make(map[string]interface{})

			if client.IsFail(response_) {
				respMap, err = client.GetErrMessage(response_)
				if err != nil {
					return nil, err
				}

				err = tea.NewSDKError(map[string]interface{}{
					"code":    respMap["Code"],
					"message": respMap["Message"],
					"data": map[string]interface{}{
						"httpCode":  response_.StatusCode,
						"requestId": respMap["RequestId"],
						"hostId":    respMap["HostId"],
					},
				})
				return nil, err
			}

			respMap, err = client.ParseXml(response_, new(GetLiveChannelInfoResponse))
			if err != nil {
				return nil, err
			}

			_result := &GetLiveChannelInfoResponse{}
			err = tea.Convert(tea.ToMap(map[string]interface{}{
				"LiveChannelConfiguration": respMap["LiveChannelConfiguration"],
			}, response_.Headers), &_result)
			return _result, err
		}()
		if !tea.Retryable(err) {
			break
		}
	}

	return _resp, err
}

func (client *Client) GetLiveChannelStat(request *GetLiveChannelStatRequest, runtime *RuntimeObject) (*GetLiveChannelStatResponse, error) {
	err := tea.Validate(request)
	if err != nil {
		return nil, err
	}
	err = tea.Validate(runtime)
	if err != nil {
		return nil, err
	}
	_runtime := map[string]interface{}{
		"timeouted":      "retry",
		"readTimeout":    client.DefaultNumber(tea.GetIntValue(runtime.ReadTimeout), client.ReadTimeout),
		"connectTimeout": client.DefaultNumber(tea.GetIntValue(runtime.ConnectTimeout), client.ConnectTimeout),
		"localAddr":      client.Default(tea.GetStringValue(runtime.LocalAddr), client.LocalAddr),
		"httpProxy":      client.Default(tea.GetStringValue(runtime.HttpProxy), client.HttpProxy),
		"httpsProxy":     client.Default(tea.GetStringValue(runtime.HttpsProxy), client.HttpsProxy),
		"noProxy":        client.Default(tea.GetStringValue(runtime.NoProxy), client.NoProxy),
		"socks5Proxy":    client.Default(tea.GetStringValue(runtime.Socks5Proxy), client.Socks5Proxy),
		"socks5NetWork":  client.Default(tea.GetStringValue(runtime.Socks5NetWork), client.Socks5NetWork),
		"maxIdleConns":   client.DefaultNumber(tea.GetIntValue(runtime.MaxIdleConns), client.MaxIdleConns),
		"retry": map[string]interface{}{
			"retryable":   tea.GetBoolValue(runtime.Autoretry),
			"maxAttempts": client.DefaultNumber(tea.GetIntValue(runtime.MaxAttempts), 3),
		},
		"backoff": map[string]interface{}{
			"policy": client.Default(tea.GetStringValue(runtime.BackoffPolicy), "no"),
			"period": client.DefaultNumber(tea.GetIntValue(runtime.BackoffPeriod), 1),
		},
		"ignoreSSL": tea.GetBoolValue(runtime.IgnoreSSL),
		"logger":    client.Logger,
		"listener":  runtime.Listener,
	}

	_resp := &GetLiveChannelStatResponse{}
	for _retryTimes := 0; tea.AllowRetry(_runtime["retry"], _retryTimes); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], _retryTimes)
			if _backoffTime > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, err = func() (*GetLiveChannelStatResponse, error) {
			request_ := tea.NewRequest()
			request_.Protocol = client.Protocol
			request_.Method = "GET"
			request_.Pathname = "/" + tea.ToString(tea.GetStringValue(request.ChannelName)) + "?live"
			request_.Headers = map[string]string{
				"host":       client.GetHost(tea.GetStringValue(request.BucketName)),
				"date":       client.GetDate(),
				"user-agent": client.GetUserAgent(),
			}
			request_.Query = client.ToQuery(tea.ToMap(request.Filter))
			request_.Headers["authorization"] = client.GetAuth(request_, tea.GetStringValue(request.BucketName))
			response_, err := tea.DoRequest(request_, _runtime)
			if err != nil {
				return nil, err
			}

			respMap := make(map[string]interface{})

			if client.IsFail(response_) {
				respMap, err = client.GetErrMessage(response_)
				if err != nil {
					return nil, err
				}

				err = tea.NewSDKError(map[string]interface{}{
					"code":    respMap["Code"],
					"message": respMap["Message"],
					"data": map[string]interface{}{
						"httpCode":  response_.StatusCode,
						"requestId": respMap["RequestId"],
						"hostId":    respMap["HostId"],
					},
				})
				return nil, err
			}

			respMap, err = client.ParseXml(response_, new(GetLiveChannelStatResponse))
			if err != nil {
				return nil, err
			}

			_result := &GetLiveChannelStatResponse{}
			err = tea.Convert(tea.ToMap(map[string]interface{}{
				"LiveChannelStat": respMap["LiveChannelStat"],
			}, response_.Headers), &_result)
			return _result, err
		}()
		if !tea.Retryable(err) {
			break
		}
	}

	return _resp, err
}

func (client *Client) DeleteObject(request *DeleteObjectRequest, runtime *RuntimeObject) (*DeleteObjectResponse, error) {
	err := tea.Validate(request)
	if err != nil {
		return nil, err
	}
	err = tea.Validate(runtime)
	if err != nil {
		return nil, err
	}
	_runtime := map[string]interface{}{
		"timeouted":      "retry",
		"readTimeout":    client.DefaultNumber(tea.GetIntValue(runtime.ReadTimeout), client.ReadTimeout),
		"connectTimeout": client.DefaultNumber(tea.GetIntValue(runtime.ConnectTimeout), client.ConnectTimeout),
		"localAddr":      client.Default(tea.GetStringValue(runtime.LocalAddr), client.LocalAddr),
		"httpProxy":      client.Default(tea.GetStringValue(runtime.HttpProxy), client.HttpProxy),
		"httpsProxy":     client.Default(tea.GetStringValue(runtime.HttpsProxy), client.HttpsProxy),
		"noProxy":        client.Default(tea.GetStringValue(runtime.NoProxy), client.NoProxy),
		"socks5Proxy":    client.Default(tea.GetStringValue(runtime.Socks5Proxy), client.Socks5Proxy),
		"socks5NetWork":  client.Default(tea.GetStringValue(runtime.Socks5NetWork), client.Socks5NetWork),
		"maxIdleConns":   client.DefaultNumber(tea.GetIntValue(runtime.MaxIdleConns), client.MaxIdleConns),
		"retry": map[string]interface{}{
			"retryable":   tea.GetBoolValue(runtime.Autoretry),
			"maxAttempts": client.DefaultNumber(tea.GetIntValue(runtime.MaxAttempts), 3),
		},
		"backoff": map[string]interface{}{
			"policy": client.Default(tea.GetStringValue(runtime.BackoffPolicy), "no"),
			"period": client.DefaultNumber(tea.GetIntValue(runtime.BackoffPeriod), 1),
		},
		"ignoreSSL": tea.GetBoolValue(runtime.IgnoreSSL),
		"logger":    client.Logger,
		"listener":  runtime.Listener,
	}

	_resp := &DeleteObjectResponse{}
	for _retryTimes := 0; tea.AllowRetry(_runtime["retry"], _retryTimes); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], _retryTimes)
			if _backoffTime > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, err = func() (*DeleteObjectResponse, error) {
			request_ := tea.NewRequest()
			request_.Protocol = client.Protocol
			request_.Method = "DELETE"
			request_.Pathname = "/" + tea.ToString(tea.GetStringValue(request.ObjectName))
			request_.Headers = map[string]string{
				"host":       client.GetHost(tea.GetStringValue(request.BucketName)),
				"date":       client.GetDate(),
				"user-agent": client.GetUserAgent(),
			}
			request_.Headers["authorization"] = client.GetAuth(request_, tea.GetStringValue(request.BucketName))
			response_, err := tea.DoRequest(request_, _runtime)
			if err != nil {
				return nil, err
			}

			respMap := make(map[string]interface{})

			if client.IsFail(response_) {
				respMap, err = client.GetErrMessage(response_)
				if err != nil {
					return nil, err
				}

				err = tea.NewSDKError(map[string]interface{}{
					"code":    respMap["Code"],
					"message": respMap["Message"],
					"data": map[string]interface{}{
						"httpCode":  response_.StatusCode,
						"requestId": respMap["RequestId"],
						"hostId":    respMap["HostId"],
					},
				})
				return nil, err
			}

			_result := &DeleteObjectResponse{}
			err = tea.Convert(response_.Headers, &_result)
			return _result, err
		}()
		if !tea.Retryable(err) {
			break
		}
	}

	return _resp, err
}

func (client *Client) AbortMultipartUpload(request *AbortMultipartUploadRequest, runtime *RuntimeObject) (*AbortMultipartUploadResponse, error) {
	err := tea.Validate(request)
	if err != nil {
		return nil, err
	}
	err = tea.Validate(runtime)
	if err != nil {
		return nil, err
	}
	_runtime := map[string]interface{}{
		"timeouted":      "retry",
		"readTimeout":    client.DefaultNumber(tea.GetIntValue(runtime.ReadTimeout), client.ReadTimeout),
		"connectTimeout": client.DefaultNumber(tea.GetIntValue(runtime.ConnectTimeout), client.ConnectTimeout),
		"localAddr":      client.Default(tea.GetStringValue(runtime.LocalAddr), client.LocalAddr),
		"httpProxy":      client.Default(tea.GetStringValue(runtime.HttpProxy), client.HttpProxy),
		"httpsProxy":     client.Default(tea.GetStringValue(runtime.HttpsProxy), client.HttpsProxy),
		"noProxy":        client.Default(tea.GetStringValue(runtime.NoProxy), client.NoProxy),
		"socks5Proxy":    client.Default(tea.GetStringValue(runtime.Socks5Proxy), client.Socks5Proxy),
		"socks5NetWork":  client.Default(tea.GetStringValue(runtime.Socks5NetWork), client.Socks5NetWork),
		"maxIdleConns":   client.DefaultNumber(tea.GetIntValue(runtime.MaxIdleConns), client.MaxIdleConns),
		"retry": map[string]interface{}{
			"retryable":   tea.GetBoolValue(runtime.Autoretry),
			"maxAttempts": client.DefaultNumber(tea.GetIntValue(runtime.MaxAttempts), 3),
		},
		"backoff": map[string]interface{}{
			"policy": client.Default(tea.GetStringValue(runtime.BackoffPolicy), "no"),
			"period": client.DefaultNumber(tea.GetIntValue(runtime.BackoffPeriod), 1),
		},
		"ignoreSSL": tea.GetBoolValue(runtime.IgnoreSSL),
		"logger":    client.Logger,
		"listener":  runtime.Listener,
	}

	_resp := &AbortMultipartUploadResponse{}
	for _retryTimes := 0; tea.AllowRetry(_runtime["retry"], _retryTimes); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], _retryTimes)
			if _backoffTime > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, err = func() (*AbortMultipartUploadResponse, error) {
			request_ := tea.NewRequest()
			request_.Protocol = client.Protocol
			request_.Method = "DELETE"
			request_.Pathname = "/" + tea.ToString(tea.GetStringValue(request.ObjectName))
			request_.Headers = map[string]string{
				"host":       client.GetHost(tea.GetStringValue(request.BucketName)),
				"date":       client.GetDate(),
				"user-agent": client.GetUserAgent(),
			}
			request_.Query = client.ToQuery(tea.ToMap(request.Filter))
			request_.Headers["authorization"] = client.GetAuth(request_, tea.GetStringValue(request.BucketName))
			response_, err := tea.DoRequest(request_, _runtime)
			if err != nil {
				return nil, err
			}

			respMap := make(map[string]interface{})

			if client.IsFail(response_) {
				respMap, err = client.GetErrMessage(response_)
				if err != nil {
					return nil, err
				}

				err = tea.NewSDKError(map[string]interface{}{
					"code":    respMap["Code"],
					"message": respMap["Message"],
					"data": map[string]interface{}{
						"httpCode":  response_.StatusCode,
						"requestId": respMap["RequestId"],
						"hostId":    respMap["HostId"],
					},
				})
				return nil, err
			}

			_result := &AbortMultipartUploadResponse{}
			err = tea.Convert(response_.Headers, &_result)
			return _result, err
		}()
		if !tea.Retryable(err) {
			break
		}
	}

	return _resp, err
}

func (client *Client) AppendObject(request *AppendObjectRequest, runtime *RuntimeObject) (*AppendObjectResponse, error) {
	err := tea.Validate(request)
	if err != nil {
		return nil, err
	}
	err = tea.Validate(runtime)
	if err != nil {
		return nil, err
	}
	_runtime := map[string]interface{}{
		"timeouted":      "retry",
		"readTimeout":    client.DefaultNumber(tea.GetIntValue(runtime.ReadTimeout), client.ReadTimeout),
		"connectTimeout": client.DefaultNumber(tea.GetIntValue(runtime.ConnectTimeout), client.ConnectTimeout),
		"localAddr":      client.Default(tea.GetStringValue(runtime.LocalAddr), client.LocalAddr),
		"httpProxy":      client.Default(tea.GetStringValue(runtime.HttpProxy), client.HttpProxy),
		"httpsProxy":     client.Default(tea.GetStringValue(runtime.HttpsProxy), client.HttpsProxy),
		"noProxy":        client.Default(tea.GetStringValue(runtime.NoProxy), client.NoProxy),
		"socks5Proxy":    client.Default(tea.GetStringValue(runtime.Socks5Proxy), client.Socks5Proxy),
		"socks5NetWork":  client.Default(tea.GetStringValue(runtime.Socks5NetWork), client.Socks5NetWork),
		"maxIdleConns":   client.DefaultNumber(tea.GetIntValue(runtime.MaxIdleConns), client.MaxIdleConns),
		"retry": map[string]interface{}{
			"retryable":   tea.GetBoolValue(runtime.Autoretry),
			"maxAttempts": client.DefaultNumber(tea.GetIntValue(runtime.MaxAttempts), 3),
		},
		"backoff": map[string]interface{}{
			"policy": client.Default(tea.GetStringValue(runtime.BackoffPolicy), "no"),
			"period": client.DefaultNumber(tea.GetIntValue(runtime.BackoffPeriod), 1),
		},
		"ignoreSSL": tea.GetBoolValue(runtime.IgnoreSSL),
		"logger":    client.Logger,
		"listener":  runtime.Listener,
	}

	_resp := &AppendObjectResponse{}
	for _retryTimes := 0; tea.AllowRetry(_runtime["retry"], _retryTimes); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], _retryTimes)
			if _backoffTime > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, err = func() (*AppendObjectResponse, error) {
			request_ := tea.NewRequest()
			request_.Protocol = client.Protocol
			request_.Method = "POST"
			request_.Pathname = "/" + tea.ToString(tea.GetStringValue(request.ObjectName)) + "?append"
			request_.Headers = tea.Merge(map[string]string{
				"host":       client.GetHost(tea.GetStringValue(request.BucketName)),
				"date":       client.GetDate(),
				"user-agent": client.GetUserAgent(),
			}, client.ToHeader(tea.ToMap(request.Header)),
				client.ParseMeta(request.UserMeta, "x-oss-meta-"))
			request_.Query = client.ToQuery(tea.ToMap(request.Filter))
			request_.Body = request.Body
			request_.Headers["content-type"] = client.Default(client.GetSpecialValue(tea.ToMap(request.Header), "content-type"), client.GetContentType(tea.GetStringValue(request.ObjectName)))
			request_.Headers["authorization"] = client.GetAuth(request_, tea.GetStringValue(request.BucketName))
			response_, err := tea.DoRequest(request_, _runtime)
			if err != nil {
				return nil, err
			}

			respMap := make(map[string]interface{})

			if client.IsFail(response_) {
				respMap, err = client.GetErrMessage(response_)
				if err != nil {
					return nil, err
				}

				err = tea.NewSDKError(map[string]interface{}{
					"code":    respMap["Code"],
					"message": respMap["Message"],
					"data": map[string]interface{}{
						"httpCode":  response_.StatusCode,
						"requestId": respMap["RequestId"],
						"hostId":    respMap["HostId"],
					},
				})
				return nil, err
			}

			_result := &AppendObjectResponse{}
			err = tea.Convert(response_.Headers, &_result)
			return _result, err
		}()
		if !tea.Retryable(err) {
			break
		}
	}

	return _resp, err
}

func (client *Client) UploadPartCopy(request *UploadPartCopyRequest, runtime *RuntimeObject) (*UploadPartCopyResponse, error) {
	err := tea.Validate(request)
	if err != nil {
		return nil, err
	}
	err = tea.Validate(runtime)
	if err != nil {
		return nil, err
	}
	_runtime := map[string]interface{}{
		"timeouted":      "retry",
		"readTimeout":    client.DefaultNumber(tea.GetIntValue(runtime.ReadTimeout), client.ReadTimeout),
		"connectTimeout": client.DefaultNumber(tea.GetIntValue(runtime.ConnectTimeout), client.ConnectTimeout),
		"localAddr":      client.Default(tea.GetStringValue(runtime.LocalAddr), client.LocalAddr),
		"httpProxy":      client.Default(tea.GetStringValue(runtime.HttpProxy), client.HttpProxy),
		"httpsProxy":     client.Default(tea.GetStringValue(runtime.HttpsProxy), client.HttpsProxy),
		"noProxy":        client.Default(tea.GetStringValue(runtime.NoProxy), client.NoProxy),
		"socks5Proxy":    client.Default(tea.GetStringValue(runtime.Socks5Proxy), client.Socks5Proxy),
		"socks5NetWork":  client.Default(tea.GetStringValue(runtime.Socks5NetWork), client.Socks5NetWork),
		"maxIdleConns":   client.DefaultNumber(tea.GetIntValue(runtime.MaxIdleConns), client.MaxIdleConns),
		"retry": map[string]interface{}{
			"retryable":   tea.GetBoolValue(runtime.Autoretry),
			"maxAttempts": client.DefaultNumber(tea.GetIntValue(runtime.MaxAttempts), 3),
		},
		"backoff": map[string]interface{}{
			"policy": client.Default(tea.GetStringValue(runtime.BackoffPolicy), "no"),
			"period": client.DefaultNumber(tea.GetIntValue(runtime.BackoffPeriod), 1),
		},
		"ignoreSSL": tea.GetBoolValue(runtime.IgnoreSSL),
		"logger":    client.Logger,
		"listener":  runtime.Listener,
	}

	_resp := &UploadPartCopyResponse{}
	for _retryTimes := 0; tea.AllowRetry(_runtime["retry"], _retryTimes); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], _retryTimes)
			if _backoffTime > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, err = func() (*UploadPartCopyResponse, error) {
			request_ := tea.NewRequest()
			request_.Protocol = client.Protocol
			request_.Method = "PUT"
			request_.Pathname = "/" + tea.ToString(tea.GetStringValue(request.ObjectName))
			request_.Headers = tea.Merge(map[string]string{
				"host":       client.GetHost(tea.GetStringValue(request.BucketName)),
				"date":       client.GetDate(),
				"user-agent": client.GetUserAgent(),
			}, client.ToHeader(tea.ToMap(request.Header)))
			request_.Query = client.ToQuery(tea.ToMap(request.Filter))
			request_.Headers["authorization"] = client.GetAuth(request_, tea.GetStringValue(request.BucketName))
			response_, err := tea.DoRequest(request_, _runtime)
			if err != nil {
				return nil, err
			}

			respMap := make(map[string]interface{})

			if client.IsFail(response_) {
				respMap, err = client.GetErrMessage(response_)
				if err != nil {
					return nil, err
				}

				err = tea.NewSDKError(map[string]interface{}{
					"code":    respMap["Code"],
					"message": respMap["Message"],
					"data": map[string]interface{}{
						"httpCode":  response_.StatusCode,
						"requestId": respMap["RequestId"],
						"hostId":    respMap["HostId"],
					},
				})
				return nil, err
			}

			respMap, err = client.ParseXml(response_, new(UploadPartCopyResponse))
			if err != nil {
				return nil, err
			}

			_result := &UploadPartCopyResponse{}
			err = tea.Convert(tea.ToMap(map[string]interface{}{
				"CopyPartResult": respMap["CopyPartResult"],
			}, response_.Headers), &_result)
			return _result, err
		}()
		if !tea.Retryable(err) {
			break
		}
	}

	return _resp, err
}

func (client *Client) GetVodPlaylist(request *GetVodPlaylistRequest, runtime *RuntimeObject) (*GetVodPlaylistResponse, error) {
	err := tea.Validate(request)
	if err != nil {
		return nil, err
	}
	err = tea.Validate(runtime)
	if err != nil {
		return nil, err
	}
	_runtime := map[string]interface{}{
		"timeouted":      "retry",
		"readTimeout":    client.DefaultNumber(tea.GetIntValue(runtime.ReadTimeout), client.ReadTimeout),
		"connectTimeout": client.DefaultNumber(tea.GetIntValue(runtime.ConnectTimeout), client.ConnectTimeout),
		"localAddr":      client.Default(tea.GetStringValue(runtime.LocalAddr), client.LocalAddr),
		"httpProxy":      client.Default(tea.GetStringValue(runtime.HttpProxy), client.HttpProxy),
		"httpsProxy":     client.Default(tea.GetStringValue(runtime.HttpsProxy), client.HttpsProxy),
		"noProxy":        client.Default(tea.GetStringValue(runtime.NoProxy), client.NoProxy),
		"socks5Proxy":    client.Default(tea.GetStringValue(runtime.Socks5Proxy), client.Socks5Proxy),
		"socks5NetWork":  client.Default(tea.GetStringValue(runtime.Socks5NetWork), client.Socks5NetWork),
		"maxIdleConns":   client.DefaultNumber(tea.GetIntValue(runtime.MaxIdleConns), client.MaxIdleConns),
		"retry": map[string]interface{}{
			"retryable":   tea.GetBoolValue(runtime.Autoretry),
			"maxAttempts": client.DefaultNumber(tea.GetIntValue(runtime.MaxAttempts), 3),
		},
		"backoff": map[string]interface{}{
			"policy": client.Default(tea.GetStringValue(runtime.BackoffPolicy), "no"),
			"period": client.DefaultNumber(tea.GetIntValue(runtime.BackoffPeriod), 1),
		},
		"ignoreSSL": tea.GetBoolValue(runtime.IgnoreSSL),
		"logger":    client.Logger,
		"listener":  runtime.Listener,
	}

	_resp := &GetVodPlaylistResponse{}
	for _retryTimes := 0; tea.AllowRetry(_runtime["retry"], _retryTimes); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], _retryTimes)
			if _backoffTime > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, err = func() (*GetVodPlaylistResponse, error) {
			request_ := tea.NewRequest()
			request_.Protocol = client.Protocol
			request_.Method = "GET"
			request_.Pathname = "/" + tea.ToString(tea.GetStringValue(request.ChannelName)) + "?vod"
			request_.Headers = map[string]string{
				"host":       client.GetHost(tea.GetStringValue(request.BucketName)),
				"date":       client.GetDate(),
				"user-agent": client.GetUserAgent(),
			}
			request_.Query = client.ToQuery(tea.ToMap(request.Filter))
			request_.Headers["authorization"] = client.GetAuth(request_, tea.GetStringValue(request.BucketName))
			response_, err := tea.DoRequest(request_, _runtime)
			if err != nil {
				return nil, err
			}

			respMap := make(map[string]interface{})

			if client.IsFail(response_) {
				respMap, err = client.GetErrMessage(response_)
				if err != nil {
					return nil, err
				}

				err = tea.NewSDKError(map[string]interface{}{
					"code":    respMap["Code"],
					"message": respMap["Message"],
					"data": map[string]interface{}{
						"httpCode":  response_.StatusCode,
						"requestId": respMap["RequestId"],
						"hostId":    respMap["HostId"],
					},
				})
				return nil, err
			}

			_result := &GetVodPlaylistResponse{}
			err = tea.Convert(response_.Headers, &_result)
			return _result, err
		}()
		if !tea.Retryable(err) {
			break
		}
	}

	return _resp, err
}

func (client *Client) DeleteBucketCORS(request *DeleteBucketCORSRequest, runtime *RuntimeObject) (*DeleteBucketCORSResponse, error) {
	err := tea.Validate(request)
	if err != nil {
		return nil, err
	}
	err = tea.Validate(runtime)
	if err != nil {
		return nil, err
	}
	_runtime := map[string]interface{}{
		"timeouted":      "retry",
		"readTimeout":    client.DefaultNumber(tea.GetIntValue(runtime.ReadTimeout), client.ReadTimeout),
		"connectTimeout": client.DefaultNumber(tea.GetIntValue(runtime.ConnectTimeout), client.ConnectTimeout),
		"localAddr":      client.Default(tea.GetStringValue(runtime.LocalAddr), client.LocalAddr),
		"httpProxy":      client.Default(tea.GetStringValue(runtime.HttpProxy), client.HttpProxy),
		"httpsProxy":     client.Default(tea.GetStringValue(runtime.HttpsProxy), client.HttpsProxy),
		"noProxy":        client.Default(tea.GetStringValue(runtime.NoProxy), client.NoProxy),
		"socks5Proxy":    client.Default(tea.GetStringValue(runtime.Socks5Proxy), client.Socks5Proxy),
		"socks5NetWork":  client.Default(tea.GetStringValue(runtime.Socks5NetWork), client.Socks5NetWork),
		"maxIdleConns":   client.DefaultNumber(tea.GetIntValue(runtime.MaxIdleConns), client.MaxIdleConns),
		"retry": map[string]interface{}{
			"retryable":   tea.GetBoolValue(runtime.Autoretry),
			"maxAttempts": client.DefaultNumber(tea.GetIntValue(runtime.MaxAttempts), 3),
		},
		"backoff": map[string]interface{}{
			"policy": client.Default(tea.GetStringValue(runtime.BackoffPolicy), "no"),
			"period": client.DefaultNumber(tea.GetIntValue(runtime.BackoffPeriod), 1),
		},
		"ignoreSSL": tea.GetBoolValue(runtime.IgnoreSSL),
		"logger":    client.Logger,
		"listener":  runtime.Listener,
	}

	_resp := &DeleteBucketCORSResponse{}
	for _retryTimes := 0; tea.AllowRetry(_runtime["retry"], _retryTimes); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], _retryTimes)
			if _backoffTime > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, err = func() (*DeleteBucketCORSResponse, error) {
			request_ := tea.NewRequest()
			request_.Protocol = client.Protocol
			request_.Method = "DELETE"
			request_.Pathname = "/?cors"
			request_.Headers = map[string]string{
				"host":       client.GetHost(tea.GetStringValue(request.BucketName)),
				"date":       client.GetDate(),
				"user-agent": client.GetUserAgent(),
			}
			request_.Headers["authorization"] = client.GetAuth(request_, tea.GetStringValue(request.BucketName))
			response_, err := tea.DoRequest(request_, _runtime)
			if err != nil {
				return nil, err
			}

			respMap := make(map[string]interface{})

			if client.IsFail(response_) {
				respMap, err = client.GetErrMessage(response_)
				if err != nil {
					return nil, err
				}

				err = tea.NewSDKError(map[string]interface{}{
					"code":    respMap["Code"],
					"message": respMap["Message"],
					"data": map[string]interface{}{
						"httpCode":  response_.StatusCode,
						"requestId": respMap["RequestId"],
						"hostId":    respMap["HostId"],
					},
				})
				return nil, err
			}

			_result := &DeleteBucketCORSResponse{}
			err = tea.Convert(response_.Headers, &_result)
			return _result, err
		}()
		if !tea.Retryable(err) {
			break
		}
	}

	return _resp, err
}

func (client *Client) GetObject(request *GetObjectRequest, runtime *RuntimeObject) (*GetObjectResponse, error) {
	err := tea.Validate(request)
	if err != nil {
		return nil, err
	}
	err = tea.Validate(runtime)
	if err != nil {
		return nil, err
	}
	_runtime := map[string]interface{}{
		"timeouted":      "retry",
		"readTimeout":    client.DefaultNumber(tea.GetIntValue(runtime.ReadTimeout), client.ReadTimeout),
		"connectTimeout": client.DefaultNumber(tea.GetIntValue(runtime.ConnectTimeout), client.ConnectTimeout),
		"localAddr":      client.Default(tea.GetStringValue(runtime.LocalAddr), client.LocalAddr),
		"httpProxy":      client.Default(tea.GetStringValue(runtime.HttpProxy), client.HttpProxy),
		"httpsProxy":     client.Default(tea.GetStringValue(runtime.HttpsProxy), client.HttpsProxy),
		"noProxy":        client.Default(tea.GetStringValue(runtime.NoProxy), client.NoProxy),
		"socks5Proxy":    client.Default(tea.GetStringValue(runtime.Socks5Proxy), client.Socks5Proxy),
		"socks5NetWork":  client.Default(tea.GetStringValue(runtime.Socks5NetWork), client.Socks5NetWork),
		"maxIdleConns":   client.DefaultNumber(tea.GetIntValue(runtime.MaxIdleConns), client.MaxIdleConns),
		"retry": map[string]interface{}{
			"retryable":   tea.GetBoolValue(runtime.Autoretry),
			"maxAttempts": client.DefaultNumber(tea.GetIntValue(runtime.MaxAttempts), 3),
		},
		"backoff": map[string]interface{}{
			"policy": client.Default(tea.GetStringValue(runtime.BackoffPolicy), "no"),
			"period": client.DefaultNumber(tea.GetIntValue(runtime.BackoffPeriod), 1),
		},
		"ignoreSSL": tea.GetBoolValue(runtime.IgnoreSSL),
		"logger":    client.Logger,
		"listener":  runtime.Listener,
	}

	_resp := &GetObjectResponse{}
	for _retryTimes := 0; tea.AllowRetry(_runtime["retry"], _retryTimes); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], _retryTimes)
			if _backoffTime > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, err = func() (*GetObjectResponse, error) {
			request_ := tea.NewRequest()
			request_.Protocol = client.Protocol
			request_.Method = "GET"
			request_.Pathname = "/" + tea.ToString(tea.GetStringValue(request.ObjectName))
			request_.Headers = tea.Merge(map[string]string{
				"host":       client.GetHost(tea.GetStringValue(request.BucketName)),
				"date":       client.GetDate(),
				"user-agent": client.GetUserAgent(),
			}, client.ToHeader(tea.ToMap(request.Header)))
			request_.Headers["authorization"] = client.GetAuth(request_, tea.GetStringValue(request.BucketName))
			response_, err := tea.DoRequest(request_, _runtime)
			if err != nil {
				return nil, err
			}

			respMap := make(map[string]interface{})

			if client.IsFail(response_) {
				respMap, err = client.GetErrMessage(response_)
				if err != nil {
					return nil, err
				}

				err = tea.NewSDKError(map[string]interface{}{
					"code":    respMap["Code"],
					"message": respMap["Message"],
					"data": map[string]interface{}{
						"httpCode":  response_.StatusCode,
						"requestId": respMap["RequestId"],
						"hostId":    respMap["HostId"],
					},
				})
				return nil, err
			}

			_result := &GetObjectResponse{}
			err = tea.Convert(tea.ToMap(map[string]interface{}{
				"body": client.ReadAsStream(response_),
			}, response_.Headers), &_result)
			return _result, err
		}()
		if !tea.Retryable(err) {
			break
		}
	}

	return _resp, err
}

func (client *Client) UploadPart(request *UploadPartRequest, runtime *RuntimeObject) (*UploadPartResponse, error) {
	err := tea.Validate(request)
	if err != nil {
		return nil, err
	}
	err = tea.Validate(runtime)
	if err != nil {
		return nil, err
	}
	_runtime := map[string]interface{}{
		"timeouted":      "retry",
		"readTimeout":    client.DefaultNumber(tea.GetIntValue(runtime.ReadTimeout), client.ReadTimeout),
		"connectTimeout": client.DefaultNumber(tea.GetIntValue(runtime.ConnectTimeout), client.ConnectTimeout),
		"localAddr":      client.Default(tea.GetStringValue(runtime.LocalAddr), client.LocalAddr),
		"httpProxy":      client.Default(tea.GetStringValue(runtime.HttpProxy), client.HttpProxy),
		"httpsProxy":     client.Default(tea.GetStringValue(runtime.HttpsProxy), client.HttpsProxy),
		"noProxy":        client.Default(tea.GetStringValue(runtime.NoProxy), client.NoProxy),
		"socks5Proxy":    client.Default(tea.GetStringValue(runtime.Socks5Proxy), client.Socks5Proxy),
		"socks5NetWork":  client.Default(tea.GetStringValue(runtime.Socks5NetWork), client.Socks5NetWork),
		"maxIdleConns":   client.DefaultNumber(tea.GetIntValue(runtime.MaxIdleConns), client.MaxIdleConns),
		"retry": map[string]interface{}{
			"retryable":   tea.GetBoolValue(runtime.Autoretry),
			"maxAttempts": client.DefaultNumber(tea.GetIntValue(runtime.MaxAttempts), 3),
		},
		"backoff": map[string]interface{}{
			"policy": client.Default(tea.GetStringValue(runtime.BackoffPolicy), "no"),
			"period": client.DefaultNumber(tea.GetIntValue(runtime.BackoffPeriod), 1),
		},
		"ignoreSSL": tea.GetBoolValue(runtime.IgnoreSSL),
		"logger":    client.Logger,
		"listener":  runtime.Listener,
	}

	_resp := &UploadPartResponse{}
	for _retryTimes := 0; tea.AllowRetry(_runtime["retry"], _retryTimes); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], _retryTimes)
			if _backoffTime > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, err = func() (*UploadPartResponse, error) {
			request_ := tea.NewRequest()
			request_.Protocol = client.Protocol
			request_.Method = "PUT"
			request_.Pathname = "/" + tea.ToString(tea.GetStringValue(request.ObjectName))
			request_.Headers = map[string]string{
				"host":       client.GetHost(tea.GetStringValue(request.BucketName)),
				"date":       client.GetDate(),
				"user-agent": client.GetUserAgent(),
			}
			request_.Query = client.ToQuery(tea.ToMap(request.Filter))
			request_.Body = request.Body
			request_.Headers["authorization"] = client.GetAuth(request_, tea.GetStringValue(request.BucketName))
			response_, err := tea.DoRequest(request_, _runtime)
			if err != nil {
				return nil, err
			}

			respMap := make(map[string]interface{})

			if client.IsFail(response_) {
				respMap, err = client.GetErrMessage(response_)
				if err != nil {
					return nil, err
				}

				err = tea.NewSDKError(map[string]interface{}{
					"code":    respMap["Code"],
					"message": respMap["Message"],
					"data": map[string]interface{}{
						"httpCode":  response_.StatusCode,
						"requestId": respMap["RequestId"],
						"hostId":    respMap["HostId"],
					},
				})
				return nil, err
			}

			_result := &UploadPartResponse{}
			err = tea.Convert(response_.Headers, &_result)
			return _result, err
		}()
		if !tea.Retryable(err) {
			break
		}
	}

	return _resp, err
}

func (client *Client) GetBucketCORS(request *GetBucketCORSRequest, runtime *RuntimeObject) (*GetBucketCORSResponse, error) {
	err := tea.Validate(request)
	if err != nil {
		return nil, err
	}
	err = tea.Validate(runtime)
	if err != nil {
		return nil, err
	}
	_runtime := map[string]interface{}{
		"timeouted":      "retry",
		"readTimeout":    client.DefaultNumber(tea.GetIntValue(runtime.ReadTimeout), client.ReadTimeout),
		"connectTimeout": client.DefaultNumber(tea.GetIntValue(runtime.ConnectTimeout), client.ConnectTimeout),
		"localAddr":      client.Default(tea.GetStringValue(runtime.LocalAddr), client.LocalAddr),
		"httpProxy":      client.Default(tea.GetStringValue(runtime.HttpProxy), client.HttpProxy),
		"httpsProxy":     client.Default(tea.GetStringValue(runtime.HttpsProxy), client.HttpsProxy),
		"noProxy":        client.Default(tea.GetStringValue(runtime.NoProxy), client.NoProxy),
		"socks5Proxy":    client.Default(tea.GetStringValue(runtime.Socks5Proxy), client.Socks5Proxy),
		"socks5NetWork":  client.Default(tea.GetStringValue(runtime.Socks5NetWork), client.Socks5NetWork),
		"maxIdleConns":   client.DefaultNumber(tea.GetIntValue(runtime.MaxIdleConns), client.MaxIdleConns),
		"retry": map[string]interface{}{
			"retryable":   tea.GetBoolValue(runtime.Autoretry),
			"maxAttempts": client.DefaultNumber(tea.GetIntValue(runtime.MaxAttempts), 3),
		},
		"backoff": map[string]interface{}{
			"policy": client.Default(tea.GetStringValue(runtime.BackoffPolicy), "no"),
			"period": client.DefaultNumber(tea.GetIntValue(runtime.BackoffPeriod), 1),
		},
		"ignoreSSL": tea.GetBoolValue(runtime.IgnoreSSL),
		"logger":    client.Logger,
		"listener":  runtime.Listener,
	}

	_resp := &GetBucketCORSResponse{}
	for _retryTimes := 0; tea.AllowRetry(_runtime["retry"], _retryTimes); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], _retryTimes)
			if _backoffTime > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, err = func() (*GetBucketCORSResponse, error) {
			request_ := tea.NewRequest()
			request_.Protocol = client.Protocol
			request_.Method = "GET"
			request_.Pathname = "/?cors"
			request_.Headers = map[string]string{
				"host":       client.GetHost(tea.GetStringValue(request.BucketName)),
				"date":       client.GetDate(),
				"user-agent": client.GetUserAgent(),
			}
			request_.Headers["authorization"] = client.GetAuth(request_, tea.GetStringValue(request.BucketName))
			response_, err := tea.DoRequest(request_, _runtime)
			if err != nil {
				return nil, err
			}

			respMap := make(map[string]interface{})

			if client.IsFail(response_) {
				respMap, err = client.GetErrMessage(response_)
				if err != nil {
					return nil, err
				}

				err = tea.NewSDKError(map[string]interface{}{
					"code":    respMap["Code"],
					"message": respMap["Message"],
					"data": map[string]interface{}{
						"httpCode":  response_.StatusCode,
						"requestId": respMap["RequestId"],
						"hostId":    respMap["HostId"],
					},
				})
				return nil, err
			}

			respMap, err = client.ParseXml(response_, new(GetBucketCORSResponse))
			if err != nil {
				return nil, err
			}

			_result := &GetBucketCORSResponse{}
			err = tea.Convert(tea.ToMap(map[string]interface{}{
				"CORSConfiguration": respMap["CORSConfiguration"],
			}, response_.Headers), &_result)
			return _result, err
		}()
		if !tea.Retryable(err) {
			break
		}
	}

	return _resp, err
}

func (client *Client) CopyObject(request *CopyObjectRequest, runtime *RuntimeObject) (*CopyObjectResponse, error) {
	err := tea.Validate(request)
	if err != nil {
		return nil, err
	}
	err = tea.Validate(runtime)
	if err != nil {
		return nil, err
	}
	_runtime := map[string]interface{}{
		"timeouted":      "retry",
		"readTimeout":    client.DefaultNumber(tea.GetIntValue(runtime.ReadTimeout), client.ReadTimeout),
		"connectTimeout": client.DefaultNumber(tea.GetIntValue(runtime.ConnectTimeout), client.ConnectTimeout),
		"localAddr":      client.Default(tea.GetStringValue(runtime.LocalAddr), client.LocalAddr),
		"httpProxy":      client.Default(tea.GetStringValue(runtime.HttpProxy), client.HttpProxy),
		"httpsProxy":     client.Default(tea.GetStringValue(runtime.HttpsProxy), client.HttpsProxy),
		"noProxy":        client.Default(tea.GetStringValue(runtime.NoProxy), client.NoProxy),
		"socks5Proxy":    client.Default(tea.GetStringValue(runtime.Socks5Proxy), client.Socks5Proxy),
		"socks5NetWork":  client.Default(tea.GetStringValue(runtime.Socks5NetWork), client.Socks5NetWork),
		"maxIdleConns":   client.DefaultNumber(tea.GetIntValue(runtime.MaxIdleConns), client.MaxIdleConns),
		"retry": map[string]interface{}{
			"retryable":   tea.GetBoolValue(runtime.Autoretry),
			"maxAttempts": client.DefaultNumber(tea.GetIntValue(runtime.MaxAttempts), 3),
		},
		"backoff": map[string]interface{}{
			"policy": client.Default(tea.GetStringValue(runtime.BackoffPolicy), "no"),
			"period": client.DefaultNumber(tea.GetIntValue(runtime.BackoffPeriod), 1),
		},
		"ignoreSSL": tea.GetBoolValue(runtime.IgnoreSSL),
		"logger":    client.Logger,
		"listener":  runtime.Listener,
	}

	_resp := &CopyObjectResponse{}
	for _retryTimes := 0; tea.AllowRetry(_runtime["retry"], _retryTimes); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], _retryTimes)
			if _backoffTime > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, err = func() (*CopyObjectResponse, error) {
			request_ := tea.NewRequest()
			request_.Protocol = client.Protocol
			request_.Method = "PUT"
			request_.Pathname = "/" + tea.ToString(tea.GetStringValue(request.DestObjectName))
			request_.Headers = tea.Merge(map[string]string{
				"host":       client.GetHost(tea.GetStringValue(request.BucketName)),
				"date":       client.GetDate(),
				"user-agent": client.GetUserAgent(),
			}, client.ToHeader(tea.ToMap(request.Header)))
			request_.Headers["x-oss-copy-source"] = client.Encode(request_.Headers["x-oss-copy-source"], "UrlEncode")
			request_.Headers["authorization"] = client.GetAuth(request_, tea.GetStringValue(request.BucketName))
			response_, err := tea.DoRequest(request_, _runtime)
			if err != nil {
				return nil, err
			}

			respMap := make(map[string]interface{})

			if client.IsFail(response_) {
				respMap, err = client.GetErrMessage(response_)
				if err != nil {
					return nil, err
				}

				err = tea.NewSDKError(map[string]interface{}{
					"code":    respMap["Code"],
					"message": respMap["Message"],
					"data": map[string]interface{}{
						"httpCode":  response_.StatusCode,
						"requestId": respMap["RequestId"],
						"hostId":    respMap["HostId"],
					},
				})
				return nil, err
			}

			respMap, err = client.ParseXml(response_, new(CopyObjectResponse))
			if err != nil {
				return nil, err
			}

			_result := &CopyObjectResponse{}
			err = tea.Convert(tea.ToMap(map[string]interface{}{
				"CopyObjectResult": respMap["CopyObjectResult"],
			}, response_.Headers), &_result)
			return _result, err
		}()
		if !tea.Retryable(err) {
			break
		}
	}

	return _resp, err
}

func (client *Client) GetObjectTagging(request *GetObjectTaggingRequest, runtime *RuntimeObject) (*GetObjectTaggingResponse, error) {
	err := tea.Validate(request)
	if err != nil {
		return nil, err
	}
	err = tea.Validate(runtime)
	if err != nil {
		return nil, err
	}
	_runtime := map[string]interface{}{
		"timeouted":      "retry",
		"readTimeout":    client.DefaultNumber(tea.GetIntValue(runtime.ReadTimeout), client.ReadTimeout),
		"connectTimeout": client.DefaultNumber(tea.GetIntValue(runtime.ConnectTimeout), client.ConnectTimeout),
		"localAddr":      client.Default(tea.GetStringValue(runtime.LocalAddr), client.LocalAddr),
		"httpProxy":      client.Default(tea.GetStringValue(runtime.HttpProxy), client.HttpProxy),
		"httpsProxy":     client.Default(tea.GetStringValue(runtime.HttpsProxy), client.HttpsProxy),
		"noProxy":        client.Default(tea.GetStringValue(runtime.NoProxy), client.NoProxy),
		"socks5Proxy":    client.Default(tea.GetStringValue(runtime.Socks5Proxy), client.Socks5Proxy),
		"socks5NetWork":  client.Default(tea.GetStringValue(runtime.Socks5NetWork), client.Socks5NetWork),
		"maxIdleConns":   client.DefaultNumber(tea.GetIntValue(runtime.MaxIdleConns), client.MaxIdleConns),
		"retry": map[string]interface{}{
			"retryable":   tea.GetBoolValue(runtime.Autoretry),
			"maxAttempts": client.DefaultNumber(tea.GetIntValue(runtime.MaxAttempts), 3),
		},
		"backoff": map[string]interface{}{
			"policy": client.Default(tea.GetStringValue(runtime.BackoffPolicy), "no"),
			"period": client.DefaultNumber(tea.GetIntValue(runtime.BackoffPeriod), 1),
		},
		"ignoreSSL": tea.GetBoolValue(runtime.IgnoreSSL),
		"logger":    client.Logger,
		"listener":  runtime.Listener,
	}

	_resp := &GetObjectTaggingResponse{}
	for _retryTimes := 0; tea.AllowRetry(_runtime["retry"], _retryTimes); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], _retryTimes)
			if _backoffTime > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, err = func() (*GetObjectTaggingResponse, error) {
			request_ := tea.NewRequest()
			request_.Protocol = client.Protocol
			request_.Method = "GET"
			request_.Pathname = "/" + tea.ToString(tea.GetStringValue(request.ObjectName)) + "?tagging"
			request_.Headers = map[string]string{
				"host":       client.GetHost(tea.GetStringValue(request.BucketName)),
				"date":       client.GetDate(),
				"user-agent": client.GetUserAgent(),
			}
			request_.Headers["authorization"] = client.GetAuth(request_, tea.GetStringValue(request.BucketName))
			response_, err := tea.DoRequest(request_, _runtime)
			if err != nil {
				return nil, err
			}

			respMap := make(map[string]interface{})

			if client.IsFail(response_) {
				respMap, err = client.GetErrMessage(response_)
				if err != nil {
					return nil, err
				}

				err = tea.NewSDKError(map[string]interface{}{
					"code":    respMap["Code"],
					"message": respMap["Message"],
					"data": map[string]interface{}{
						"httpCode":  response_.StatusCode,
						"requestId": respMap["RequestId"],
						"hostId":    respMap["HostId"],
					},
				})
				return nil, err
			}

			respMap, err = client.ParseXml(response_, new(GetObjectTaggingResponse))
			if err != nil {
				return nil, err
			}

			_result := &GetObjectTaggingResponse{}
			err = tea.Convert(tea.ToMap(map[string]interface{}{
				"Tagging": respMap["Tagging"],
			}, response_.Headers), &_result)
			return _result, err
		}()
		if !tea.Retryable(err) {
			break
		}
	}

	return _resp, err
}

func (client *Client) DeleteBucketLifecycle(request *DeleteBucketLifecycleRequest, runtime *RuntimeObject) (*DeleteBucketLifecycleResponse, error) {
	err := tea.Validate(request)
	if err != nil {
		return nil, err
	}
	err = tea.Validate(runtime)
	if err != nil {
		return nil, err
	}
	_runtime := map[string]interface{}{
		"timeouted":      "retry",
		"readTimeout":    client.DefaultNumber(tea.GetIntValue(runtime.ReadTimeout), client.ReadTimeout),
		"connectTimeout": client.DefaultNumber(tea.GetIntValue(runtime.ConnectTimeout), client.ConnectTimeout),
		"localAddr":      client.Default(tea.GetStringValue(runtime.LocalAddr), client.LocalAddr),
		"httpProxy":      client.Default(tea.GetStringValue(runtime.HttpProxy), client.HttpProxy),
		"httpsProxy":     client.Default(tea.GetStringValue(runtime.HttpsProxy), client.HttpsProxy),
		"noProxy":        client.Default(tea.GetStringValue(runtime.NoProxy), client.NoProxy),
		"socks5Proxy":    client.Default(tea.GetStringValue(runtime.Socks5Proxy), client.Socks5Proxy),
		"socks5NetWork":  client.Default(tea.GetStringValue(runtime.Socks5NetWork), client.Socks5NetWork),
		"maxIdleConns":   client.DefaultNumber(tea.GetIntValue(runtime.MaxIdleConns), client.MaxIdleConns),
		"retry": map[string]interface{}{
			"retryable":   tea.GetBoolValue(runtime.Autoretry),
			"maxAttempts": client.DefaultNumber(tea.GetIntValue(runtime.MaxAttempts), 3),
		},
		"backoff": map[string]interface{}{
			"policy": client.Default(tea.GetStringValue(runtime.BackoffPolicy), "no"),
			"period": client.DefaultNumber(tea.GetIntValue(runtime.BackoffPeriod), 1),
		},
		"ignoreSSL": tea.GetBoolValue(runtime.IgnoreSSL),
		"logger":    client.Logger,
		"listener":  runtime.Listener,
	}

	_resp := &DeleteBucketLifecycleResponse{}
	for _retryTimes := 0; tea.AllowRetry(_runtime["retry"], _retryTimes); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], _retryTimes)
			if _backoffTime > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, err = func() (*DeleteBucketLifecycleResponse, error) {
			request_ := tea.NewRequest()
			request_.Protocol = client.Protocol
			request_.Method = "DELETE"
			request_.Pathname = "/?lifecycle"
			request_.Headers = map[string]string{
				"host":       client.GetHost(tea.GetStringValue(request.BucketName)),
				"date":       client.GetDate(),
				"user-agent": client.GetUserAgent(),
			}
			request_.Headers["authorization"] = client.GetAuth(request_, tea.GetStringValue(request.BucketName))
			response_, err := tea.DoRequest(request_, _runtime)
			if err != nil {
				return nil, err
			}

			respMap := make(map[string]interface{})

			if client.IsFail(response_) {
				respMap, err = client.GetErrMessage(response_)
				if err != nil {
					return nil, err
				}

				err = tea.NewSDKError(map[string]interface{}{
					"code":    respMap["Code"],
					"message": respMap["Message"],
					"data": map[string]interface{}{
						"httpCode":  response_.StatusCode,
						"requestId": respMap["RequestId"],
						"hostId":    respMap["HostId"],
					},
				})
				return nil, err
			}

			_result := &DeleteBucketLifecycleResponse{}
			err = tea.Convert(response_.Headers, &_result)
			return _result, err
		}()
		if !tea.Retryable(err) {
			break
		}
	}

	return _resp, err
}

func (client *Client) DeleteBucketLogging(request *DeleteBucketLoggingRequest, runtime *RuntimeObject) (*DeleteBucketLoggingResponse, error) {
	err := tea.Validate(request)
	if err != nil {
		return nil, err
	}
	err = tea.Validate(runtime)
	if err != nil {
		return nil, err
	}
	_runtime := map[string]interface{}{
		"timeouted":      "retry",
		"readTimeout":    client.DefaultNumber(tea.GetIntValue(runtime.ReadTimeout), client.ReadTimeout),
		"connectTimeout": client.DefaultNumber(tea.GetIntValue(runtime.ConnectTimeout), client.ConnectTimeout),
		"localAddr":      client.Default(tea.GetStringValue(runtime.LocalAddr), client.LocalAddr),
		"httpProxy":      client.Default(tea.GetStringValue(runtime.HttpProxy), client.HttpProxy),
		"httpsProxy":     client.Default(tea.GetStringValue(runtime.HttpsProxy), client.HttpsProxy),
		"noProxy":        client.Default(tea.GetStringValue(runtime.NoProxy), client.NoProxy),
		"socks5Proxy":    client.Default(tea.GetStringValue(runtime.Socks5Proxy), client.Socks5Proxy),
		"socks5NetWork":  client.Default(tea.GetStringValue(runtime.Socks5NetWork), client.Socks5NetWork),
		"maxIdleConns":   client.DefaultNumber(tea.GetIntValue(runtime.MaxIdleConns), client.MaxIdleConns),
		"retry": map[string]interface{}{
			"retryable":   tea.GetBoolValue(runtime.Autoretry),
			"maxAttempts": client.DefaultNumber(tea.GetIntValue(runtime.MaxAttempts), 3),
		},
		"backoff": map[string]interface{}{
			"policy": client.Default(tea.GetStringValue(runtime.BackoffPolicy), "no"),
			"period": client.DefaultNumber(tea.GetIntValue(runtime.BackoffPeriod), 1),
		},
		"ignoreSSL": tea.GetBoolValue(runtime.IgnoreSSL),
		"logger":    client.Logger,
		"listener":  runtime.Listener,
	}

	_resp := &DeleteBucketLoggingResponse{}
	for _retryTimes := 0; tea.AllowRetry(_runtime["retry"], _retryTimes); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], _retryTimes)
			if _backoffTime > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, err = func() (*DeleteBucketLoggingResponse, error) {
			request_ := tea.NewRequest()
			request_.Protocol = client.Protocol
			request_.Method = "DELETE"
			request_.Pathname = "/?logging"
			request_.Headers = map[string]string{
				"host":       client.GetHost(tea.GetStringValue(request.BucketName)),
				"date":       client.GetDate(),
				"user-agent": client.GetUserAgent(),
			}
			request_.Headers["authorization"] = client.GetAuth(request_, tea.GetStringValue(request.BucketName))
			response_, err := tea.DoRequest(request_, _runtime)
			if err != nil {
				return nil, err
			}

			respMap := make(map[string]interface{})

			if client.IsFail(response_) {
				respMap, err = client.GetErrMessage(response_)
				if err != nil {
					return nil, err
				}

				err = tea.NewSDKError(map[string]interface{}{
					"code":    respMap["Code"],
					"message": respMap["Message"],
					"data": map[string]interface{}{
						"httpCode":  response_.StatusCode,
						"requestId": respMap["RequestId"],
						"hostId":    respMap["HostId"],
					},
				})
				return nil, err
			}

			_result := &DeleteBucketLoggingResponse{}
			err = tea.Convert(response_.Headers, &_result)
			return _result, err
		}()
		if !tea.Retryable(err) {
			break
		}
	}

	return _resp, err
}

func (client *Client) DeleteBucketWebsite(request *DeleteBucketWebsiteRequest, runtime *RuntimeObject) (*DeleteBucketWebsiteResponse, error) {
	err := tea.Validate(request)
	if err != nil {
		return nil, err
	}
	err = tea.Validate(runtime)
	if err != nil {
		return nil, err
	}
	_runtime := map[string]interface{}{
		"timeouted":      "retry",
		"readTimeout":    client.DefaultNumber(tea.GetIntValue(runtime.ReadTimeout), client.ReadTimeout),
		"connectTimeout": client.DefaultNumber(tea.GetIntValue(runtime.ConnectTimeout), client.ConnectTimeout),
		"localAddr":      client.Default(tea.GetStringValue(runtime.LocalAddr), client.LocalAddr),
		"httpProxy":      client.Default(tea.GetStringValue(runtime.HttpProxy), client.HttpProxy),
		"httpsProxy":     client.Default(tea.GetStringValue(runtime.HttpsProxy), client.HttpsProxy),
		"noProxy":        client.Default(tea.GetStringValue(runtime.NoProxy), client.NoProxy),
		"socks5Proxy":    client.Default(tea.GetStringValue(runtime.Socks5Proxy), client.Socks5Proxy),
		"socks5NetWork":  client.Default(tea.GetStringValue(runtime.Socks5NetWork), client.Socks5NetWork),
		"maxIdleConns":   client.DefaultNumber(tea.GetIntValue(runtime.MaxIdleConns), client.MaxIdleConns),
		"retry": map[string]interface{}{
			"retryable":   tea.GetBoolValue(runtime.Autoretry),
			"maxAttempts": client.DefaultNumber(tea.GetIntValue(runtime.MaxAttempts), 3),
		},
		"backoff": map[string]interface{}{
			"policy": client.Default(tea.GetStringValue(runtime.BackoffPolicy), "no"),
			"period": client.DefaultNumber(tea.GetIntValue(runtime.BackoffPeriod), 1),
		},
		"ignoreSSL": tea.GetBoolValue(runtime.IgnoreSSL),
		"logger":    client.Logger,
		"listener":  runtime.Listener,
	}

	_resp := &DeleteBucketWebsiteResponse{}
	for _retryTimes := 0; tea.AllowRetry(_runtime["retry"], _retryTimes); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], _retryTimes)
			if _backoffTime > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, err = func() (*DeleteBucketWebsiteResponse, error) {
			request_ := tea.NewRequest()
			request_.Protocol = client.Protocol
			request_.Method = "DELETE"
			request_.Pathname = "/?website"
			request_.Headers = map[string]string{
				"host":       client.GetHost(tea.GetStringValue(request.BucketName)),
				"date":       client.GetDate(),
				"user-agent": client.GetUserAgent(),
			}
			request_.Headers["authorization"] = client.GetAuth(request_, tea.GetStringValue(request.BucketName))
			response_, err := tea.DoRequest(request_, _runtime)
			if err != nil {
				return nil, err
			}

			respMap := make(map[string]interface{})

			if client.IsFail(response_) {
				respMap, err = client.GetErrMessage(response_)
				if err != nil {
					return nil, err
				}

				err = tea.NewSDKError(map[string]interface{}{
					"code":    respMap["Code"],
					"message": respMap["Message"],
					"data": map[string]interface{}{
						"httpCode":  response_.StatusCode,
						"requestId": respMap["RequestId"],
						"hostId":    respMap["HostId"],
					},
				})
				return nil, err
			}

			_result := &DeleteBucketWebsiteResponse{}
			err = tea.Convert(response_.Headers, &_result)
			return _result, err
		}()
		if !tea.Retryable(err) {
			break
		}
	}

	return _resp, err
}

func (client *Client) GetSymlink(request *GetSymlinkRequest, runtime *RuntimeObject) (*GetSymlinkResponse, error) {
	err := tea.Validate(request)
	if err != nil {
		return nil, err
	}
	err = tea.Validate(runtime)
	if err != nil {
		return nil, err
	}
	_runtime := map[string]interface{}{
		"timeouted":      "retry",
		"readTimeout":    client.DefaultNumber(tea.GetIntValue(runtime.ReadTimeout), client.ReadTimeout),
		"connectTimeout": client.DefaultNumber(tea.GetIntValue(runtime.ConnectTimeout), client.ConnectTimeout),
		"localAddr":      client.Default(tea.GetStringValue(runtime.LocalAddr), client.LocalAddr),
		"httpProxy":      client.Default(tea.GetStringValue(runtime.HttpProxy), client.HttpProxy),
		"httpsProxy":     client.Default(tea.GetStringValue(runtime.HttpsProxy), client.HttpsProxy),
		"noProxy":        client.Default(tea.GetStringValue(runtime.NoProxy), client.NoProxy),
		"socks5Proxy":    client.Default(tea.GetStringValue(runtime.Socks5Proxy), client.Socks5Proxy),
		"socks5NetWork":  client.Default(tea.GetStringValue(runtime.Socks5NetWork), client.Socks5NetWork),
		"maxIdleConns":   client.DefaultNumber(tea.GetIntValue(runtime.MaxIdleConns), client.MaxIdleConns),
		"retry": map[string]interface{}{
			"retryable":   tea.GetBoolValue(runtime.Autoretry),
			"maxAttempts": client.DefaultNumber(tea.GetIntValue(runtime.MaxAttempts), 3),
		},
		"backoff": map[string]interface{}{
			"policy": client.Default(tea.GetStringValue(runtime.BackoffPolicy), "no"),
			"period": client.DefaultNumber(tea.GetIntValue(runtime.BackoffPeriod), 1),
		},
		"ignoreSSL": tea.GetBoolValue(runtime.IgnoreSSL),
		"logger":    client.Logger,
		"listener":  runtime.Listener,
	}

	_resp := &GetSymlinkResponse{}
	for _retryTimes := 0; tea.AllowRetry(_runtime["retry"], _retryTimes); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], _retryTimes)
			if _backoffTime > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, err = func() (*GetSymlinkResponse, error) {
			request_ := tea.NewRequest()
			request_.Protocol = client.Protocol
			request_.Method = "GET"
			request_.Pathname = "/" + tea.ToString(tea.GetStringValue(request.ObjectName)) + "?symlink"
			request_.Headers = map[string]string{
				"host":       client.GetHost(tea.GetStringValue(request.BucketName)),
				"date":       client.GetDate(),
				"user-agent": client.GetUserAgent(),
			}
			request_.Headers["authorization"] = client.GetAuth(request_, tea.GetStringValue(request.BucketName))
			response_, err := tea.DoRequest(request_, _runtime)
			if err != nil {
				return nil, err
			}

			respMap := make(map[string]interface{})

			if client.IsFail(response_) {
				respMap, err = client.GetErrMessage(response_)
				if err != nil {
					return nil, err
				}

				err = tea.NewSDKError(map[string]interface{}{
					"code":    respMap["Code"],
					"message": respMap["Message"],
					"data": map[string]interface{}{
						"httpCode":  response_.StatusCode,
						"requestId": respMap["RequestId"],
						"hostId":    respMap["HostId"],
					},
				})
				return nil, err
			}

			_result := &GetSymlinkResponse{}
			err = tea.Convert(response_.Headers, &_result)
			return _result, err
		}()
		if !tea.Retryable(err) {
			break
		}
	}

	return _resp, err
}

func (client *Client) GetBucketLifecycle(request *GetBucketLifecycleRequest, runtime *RuntimeObject) (*GetBucketLifecycleResponse, error) {
	err := tea.Validate(request)
	if err != nil {
		return nil, err
	}
	err = tea.Validate(runtime)
	if err != nil {
		return nil, err
	}
	_runtime := map[string]interface{}{
		"timeouted":      "retry",
		"readTimeout":    client.DefaultNumber(tea.GetIntValue(runtime.ReadTimeout), client.ReadTimeout),
		"connectTimeout": client.DefaultNumber(tea.GetIntValue(runtime.ConnectTimeout), client.ConnectTimeout),
		"localAddr":      client.Default(tea.GetStringValue(runtime.LocalAddr), client.LocalAddr),
		"httpProxy":      client.Default(tea.GetStringValue(runtime.HttpProxy), client.HttpProxy),
		"httpsProxy":     client.Default(tea.GetStringValue(runtime.HttpsProxy), client.HttpsProxy),
		"noProxy":        client.Default(tea.GetStringValue(runtime.NoProxy), client.NoProxy),
		"socks5Proxy":    client.Default(tea.GetStringValue(runtime.Socks5Proxy), client.Socks5Proxy),
		"socks5NetWork":  client.Default(tea.GetStringValue(runtime.Socks5NetWork), client.Socks5NetWork),
		"maxIdleConns":   client.DefaultNumber(tea.GetIntValue(runtime.MaxIdleConns), client.MaxIdleConns),
		"retry": map[string]interface{}{
			"retryable":   tea.GetBoolValue(runtime.Autoretry),
			"maxAttempts": client.DefaultNumber(tea.GetIntValue(runtime.MaxAttempts), 3),
		},
		"backoff": map[string]interface{}{
			"policy": client.Default(tea.GetStringValue(runtime.BackoffPolicy), "no"),
			"period": client.DefaultNumber(tea.GetIntValue(runtime.BackoffPeriod), 1),
		},
		"ignoreSSL": tea.GetBoolValue(runtime.IgnoreSSL),
		"logger":    client.Logger,
		"listener":  runtime.Listener,
	}

	_resp := &GetBucketLifecycleResponse{}
	for _retryTimes := 0; tea.AllowRetry(_runtime["retry"], _retryTimes); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], _retryTimes)
			if _backoffTime > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, err = func() (*GetBucketLifecycleResponse, error) {
			request_ := tea.NewRequest()
			request_.Protocol = client.Protocol
			request_.Method = "GET"
			request_.Pathname = "/?lifecycle"
			request_.Headers = map[string]string{
				"host":       client.GetHost(tea.GetStringValue(request.BucketName)),
				"date":       client.GetDate(),
				"user-agent": client.GetUserAgent(),
			}
			request_.Headers["authorization"] = client.GetAuth(request_, tea.GetStringValue(request.BucketName))
			response_, err := tea.DoRequest(request_, _runtime)
			if err != nil {
				return nil, err
			}

			respMap := make(map[string]interface{})

			if client.IsFail(response_) {
				respMap, err = client.GetErrMessage(response_)
				if err != nil {
					return nil, err
				}

				err = tea.NewSDKError(map[string]interface{}{
					"code":    respMap["Code"],
					"message": respMap["Message"],
					"data": map[string]interface{}{
						"httpCode":  response_.StatusCode,
						"requestId": respMap["RequestId"],
						"hostId":    respMap["HostId"],
					},
				})
				return nil, err
			}

			respMap, err = client.ParseXml(response_, new(GetBucketLifecycleResponse))
			if err != nil {
				return nil, err
			}

			_result := &GetBucketLifecycleResponse{}
			err = tea.Convert(tea.ToMap(map[string]interface{}{
				"LifecycleConfiguration": respMap["LifecycleConfiguration"],
			}, response_.Headers), &_result)
			return _result, err
		}()
		if !tea.Retryable(err) {
			break
		}
	}

	return _resp, err
}

func (client *Client) PutSymlink(request *PutSymlinkRequest, runtime *RuntimeObject) (*PutSymlinkResponse, error) {
	err := tea.Validate(request)
	if err != nil {
		return nil, err
	}
	err = tea.Validate(runtime)
	if err != nil {
		return nil, err
	}
	_runtime := map[string]interface{}{
		"timeouted":      "retry",
		"readTimeout":    client.DefaultNumber(tea.GetIntValue(runtime.ReadTimeout), client.ReadTimeout),
		"connectTimeout": client.DefaultNumber(tea.GetIntValue(runtime.ConnectTimeout), client.ConnectTimeout),
		"localAddr":      client.Default(tea.GetStringValue(runtime.LocalAddr), client.LocalAddr),
		"httpProxy":      client.Default(tea.GetStringValue(runtime.HttpProxy), client.HttpProxy),
		"httpsProxy":     client.Default(tea.GetStringValue(runtime.HttpsProxy), client.HttpsProxy),
		"noProxy":        client.Default(tea.GetStringValue(runtime.NoProxy), client.NoProxy),
		"socks5Proxy":    client.Default(tea.GetStringValue(runtime.Socks5Proxy), client.Socks5Proxy),
		"socks5NetWork":  client.Default(tea.GetStringValue(runtime.Socks5NetWork), client.Socks5NetWork),
		"maxIdleConns":   client.DefaultNumber(tea.GetIntValue(runtime.MaxIdleConns), client.MaxIdleConns),
		"retry": map[string]interface{}{
			"retryable":   tea.GetBoolValue(runtime.Autoretry),
			"maxAttempts": client.DefaultNumber(tea.GetIntValue(runtime.MaxAttempts), 3),
		},
		"backoff": map[string]interface{}{
			"policy": client.Default(tea.GetStringValue(runtime.BackoffPolicy), "no"),
			"period": client.DefaultNumber(tea.GetIntValue(runtime.BackoffPeriod), 1),
		},
		"ignoreSSL": tea.GetBoolValue(runtime.IgnoreSSL),
		"logger":    client.Logger,
		"listener":  runtime.Listener,
	}

	_resp := &PutSymlinkResponse{}
	for _retryTimes := 0; tea.AllowRetry(_runtime["retry"], _retryTimes); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], _retryTimes)
			if _backoffTime > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, err = func() (*PutSymlinkResponse, error) {
			request_ := tea.NewRequest()
			request_.Protocol = client.Protocol
			request_.Method = "PUT"
			request_.Pathname = "/" + tea.ToString(tea.GetStringValue(request.ObjectName)) + "?symlink"
			request_.Headers = tea.Merge(map[string]string{
				"host":       client.GetHost(tea.GetStringValue(request.BucketName)),
				"date":       client.GetDate(),
				"user-agent": client.GetUserAgent(),
			}, client.ToHeader(tea.ToMap(request.Header)))
			request_.Headers["authorization"] = client.GetAuth(request_, tea.GetStringValue(request.BucketName))
			response_, err := tea.DoRequest(request_, _runtime)
			if err != nil {
				return nil, err
			}

			respMap := make(map[string]interface{})

			if client.IsFail(response_) {
				respMap, err = client.GetErrMessage(response_)
				if err != nil {
					return nil, err
				}

				err = tea.NewSDKError(map[string]interface{}{
					"code":    respMap["Code"],
					"message": respMap["Message"],
					"data": map[string]interface{}{
						"httpCode":  response_.StatusCode,
						"requestId": respMap["RequestId"],
						"hostId":    respMap["HostId"],
					},
				})
				return nil, err
			}

			_result := &PutSymlinkResponse{}
			err = tea.Convert(response_.Headers, &_result)
			return _result, err
		}()
		if !tea.Retryable(err) {
			break
		}
	}

	return _resp, err
}

func (client *Client) GetBucketReferer(request *GetBucketRefererRequest, runtime *RuntimeObject) (*GetBucketRefererResponse, error) {
	err := tea.Validate(request)
	if err != nil {
		return nil, err
	}
	err = tea.Validate(runtime)
	if err != nil {
		return nil, err
	}
	_runtime := map[string]interface{}{
		"timeouted":      "retry",
		"readTimeout":    client.DefaultNumber(tea.GetIntValue(runtime.ReadTimeout), client.ReadTimeout),
		"connectTimeout": client.DefaultNumber(tea.GetIntValue(runtime.ConnectTimeout), client.ConnectTimeout),
		"localAddr":      client.Default(tea.GetStringValue(runtime.LocalAddr), client.LocalAddr),
		"httpProxy":      client.Default(tea.GetStringValue(runtime.HttpProxy), client.HttpProxy),
		"httpsProxy":     client.Default(tea.GetStringValue(runtime.HttpsProxy), client.HttpsProxy),
		"noProxy":        client.Default(tea.GetStringValue(runtime.NoProxy), client.NoProxy),
		"socks5Proxy":    client.Default(tea.GetStringValue(runtime.Socks5Proxy), client.Socks5Proxy),
		"socks5NetWork":  client.Default(tea.GetStringValue(runtime.Socks5NetWork), client.Socks5NetWork),
		"maxIdleConns":   client.DefaultNumber(tea.GetIntValue(runtime.MaxIdleConns), client.MaxIdleConns),
		"retry": map[string]interface{}{
			"retryable":   tea.GetBoolValue(runtime.Autoretry),
			"maxAttempts": client.DefaultNumber(tea.GetIntValue(runtime.MaxAttempts), 3),
		},
		"backoff": map[string]interface{}{
			"policy": client.Default(tea.GetStringValue(runtime.BackoffPolicy), "no"),
			"period": client.DefaultNumber(tea.GetIntValue(runtime.BackoffPeriod), 1),
		},
		"ignoreSSL": tea.GetBoolValue(runtime.IgnoreSSL),
		"logger":    client.Logger,
		"listener":  runtime.Listener,
	}

	_resp := &GetBucketRefererResponse{}
	for _retryTimes := 0; tea.AllowRetry(_runtime["retry"], _retryTimes); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], _retryTimes)
			if _backoffTime > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, err = func() (*GetBucketRefererResponse, error) {
			request_ := tea.NewRequest()
			request_.Protocol = client.Protocol
			request_.Method = "GET"
			request_.Pathname = "/?referer"
			request_.Headers = map[string]string{
				"host":       client.GetHost(tea.GetStringValue(request.BucketName)),
				"date":       client.GetDate(),
				"user-agent": client.GetUserAgent(),
			}
			request_.Headers["authorization"] = client.GetAuth(request_, tea.GetStringValue(request.BucketName))
			response_, err := tea.DoRequest(request_, _runtime)
			if err != nil {
				return nil, err
			}

			respMap := make(map[string]interface{})

			if client.IsFail(response_) {
				respMap, err = client.GetErrMessage(response_)
				if err != nil {
					return nil, err
				}

				err = tea.NewSDKError(map[string]interface{}{
					"code":    respMap["Code"],
					"message": respMap["Message"],
					"data": map[string]interface{}{
						"httpCode":  response_.StatusCode,
						"requestId": respMap["RequestId"],
						"hostId":    respMap["HostId"],
					},
				})
				return nil, err
			}

			respMap, err = client.ParseXml(response_, new(GetBucketRefererResponse))
			if err != nil {
				return nil, err
			}

			_result := &GetBucketRefererResponse{}
			err = tea.Convert(tea.ToMap(map[string]interface{}{
				"RefererConfiguration": respMap["RefererConfiguration"],
			}, response_.Headers), &_result)
			return _result, err
		}()
		if !tea.Retryable(err) {
			break
		}
	}

	return _resp, err
}

func (client *Client) Callback(request *CallbackRequest, runtime *RuntimeObject) (*CallbackResponse, error) {
	err := tea.Validate(request)
	if err != nil {
		return nil, err
	}
	err = tea.Validate(runtime)
	if err != nil {
		return nil, err
	}
	_runtime := map[string]interface{}{
		"timeouted":      "retry",
		"readTimeout":    client.DefaultNumber(tea.GetIntValue(runtime.ReadTimeout), client.ReadTimeout),
		"connectTimeout": client.DefaultNumber(tea.GetIntValue(runtime.ConnectTimeout), client.ConnectTimeout),
		"localAddr":      client.Default(tea.GetStringValue(runtime.LocalAddr), client.LocalAddr),
		"httpProxy":      client.Default(tea.GetStringValue(runtime.HttpProxy), client.HttpProxy),
		"httpsProxy":     client.Default(tea.GetStringValue(runtime.HttpsProxy), client.HttpsProxy),
		"noProxy":        client.Default(tea.GetStringValue(runtime.NoProxy), client.NoProxy),
		"socks5Proxy":    client.Default(tea.GetStringValue(runtime.Socks5Proxy), client.Socks5Proxy),
		"socks5NetWork":  client.Default(tea.GetStringValue(runtime.Socks5NetWork), client.Socks5NetWork),
		"maxIdleConns":   client.DefaultNumber(tea.GetIntValue(runtime.MaxIdleConns), client.MaxIdleConns),
		"retry": map[string]interface{}{
			"retryable":   tea.GetBoolValue(runtime.Autoretry),
			"maxAttempts": client.DefaultNumber(tea.GetIntValue(runtime.MaxAttempts), 3),
		},
		"backoff": map[string]interface{}{
			"policy": client.Default(tea.GetStringValue(runtime.BackoffPolicy), "no"),
			"period": client.DefaultNumber(tea.GetIntValue(runtime.BackoffPeriod), 1),
		},
		"ignoreSSL": tea.GetBoolValue(runtime.IgnoreSSL),
		"logger":    client.Logger,
		"listener":  runtime.Listener,
	}

	_resp := &CallbackResponse{}
	for _retryTimes := 0; tea.AllowRetry(_runtime["retry"], _retryTimes); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], _retryTimes)
			if _backoffTime > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, err = func() (*CallbackResponse, error) {
			request_ := tea.NewRequest()
			request_.Protocol = client.Protocol
			request_.Method = "GET"
			request_.Pathname = "/"
			request_.Headers = map[string]string{
				"host":       client.GetHost(tea.GetStringValue(request.BucketName)),
				"date":       client.GetDate(),
				"user-agent": client.GetUserAgent(),
			}
			request_.Headers["authorization"] = client.GetAuth(request_, tea.GetStringValue(request.BucketName))
			response_, err := tea.DoRequest(request_, _runtime)
			if err != nil {
				return nil, err
			}

			respMap := make(map[string]interface{})

			if client.IsFail(response_) {
				respMap, err = client.GetErrMessage(response_)
				if err != nil {
					return nil, err
				}

				err = tea.NewSDKError(map[string]interface{}{
					"code":    respMap["Code"],
					"message": respMap["Message"],
					"data": map[string]interface{}{
						"httpCode":  response_.StatusCode,
						"requestId": respMap["RequestId"],
						"hostId":    respMap["HostId"],
					},
				})
				return nil, err
			}

			_result := &CallbackResponse{}
			err = tea.Convert(response_.Headers, &_result)
			return _result, err
		}()
		if !tea.Retryable(err) {
			break
		}
	}

	return _resp, err
}

func (client *Client) GetBucketLogging(request *GetBucketLoggingRequest, runtime *RuntimeObject) (*GetBucketLoggingResponse, error) {
	err := tea.Validate(request)
	if err != nil {
		return nil, err
	}
	err = tea.Validate(runtime)
	if err != nil {
		return nil, err
	}
	_runtime := map[string]interface{}{
		"timeouted":      "retry",
		"readTimeout":    client.DefaultNumber(tea.GetIntValue(runtime.ReadTimeout), client.ReadTimeout),
		"connectTimeout": client.DefaultNumber(tea.GetIntValue(runtime.ConnectTimeout), client.ConnectTimeout),
		"localAddr":      client.Default(tea.GetStringValue(runtime.LocalAddr), client.LocalAddr),
		"httpProxy":      client.Default(tea.GetStringValue(runtime.HttpProxy), client.HttpProxy),
		"httpsProxy":     client.Default(tea.GetStringValue(runtime.HttpsProxy), client.HttpsProxy),
		"noProxy":        client.Default(tea.GetStringValue(runtime.NoProxy), client.NoProxy),
		"socks5Proxy":    client.Default(tea.GetStringValue(runtime.Socks5Proxy), client.Socks5Proxy),
		"socks5NetWork":  client.Default(tea.GetStringValue(runtime.Socks5NetWork), client.Socks5NetWork),
		"maxIdleConns":   client.DefaultNumber(tea.GetIntValue(runtime.MaxIdleConns), client.MaxIdleConns),
		"retry": map[string]interface{}{
			"retryable":   tea.GetBoolValue(runtime.Autoretry),
			"maxAttempts": client.DefaultNumber(tea.GetIntValue(runtime.MaxAttempts), 3),
		},
		"backoff": map[string]interface{}{
			"policy": client.Default(tea.GetStringValue(runtime.BackoffPolicy), "no"),
			"period": client.DefaultNumber(tea.GetIntValue(runtime.BackoffPeriod), 1),
		},
		"ignoreSSL": tea.GetBoolValue(runtime.IgnoreSSL),
		"logger":    client.Logger,
		"listener":  runtime.Listener,
	}

	_resp := &GetBucketLoggingResponse{}
	for _retryTimes := 0; tea.AllowRetry(_runtime["retry"], _retryTimes); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], _retryTimes)
			if _backoffTime > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, err = func() (*GetBucketLoggingResponse, error) {
			request_ := tea.NewRequest()
			request_.Protocol = client.Protocol
			request_.Method = "GET"
			request_.Pathname = "/?logging"
			request_.Headers = map[string]string{
				"host":       client.GetHost(tea.GetStringValue(request.BucketName)),
				"date":       client.GetDate(),
				"user-agent": client.GetUserAgent(),
			}
			request_.Headers["authorization"] = client.GetAuth(request_, tea.GetStringValue(request.BucketName))
			response_, err := tea.DoRequest(request_, _runtime)
			if err != nil {
				return nil, err
			}

			respMap := make(map[string]interface{})

			if client.IsFail(response_) {
				respMap, err = client.GetErrMessage(response_)
				if err != nil {
					return nil, err
				}

				err = tea.NewSDKError(map[string]interface{}{
					"code":    respMap["Code"],
					"message": respMap["Message"],
					"data": map[string]interface{}{
						"httpCode":  response_.StatusCode,
						"requestId": respMap["RequestId"],
						"hostId":    respMap["HostId"],
					},
				})
				return nil, err
			}

			respMap, err = client.ParseXml(response_, new(GetBucketLoggingResponse))
			if err != nil {
				return nil, err
			}

			_result := &GetBucketLoggingResponse{}
			err = tea.Convert(tea.ToMap(map[string]interface{}{
				"BucketLoggingStatus": respMap["BucketLoggingStatus"],
			}, response_.Headers), &_result)
			return _result, err
		}()
		if !tea.Retryable(err) {
			break
		}
	}

	return _resp, err
}

func (client *Client) PutObjectAcl(request *PutObjectAclRequest, runtime *RuntimeObject) (*PutObjectAclResponse, error) {
	err := tea.Validate(request)
	if err != nil {
		return nil, err
	}
	err = tea.Validate(runtime)
	if err != nil {
		return nil, err
	}
	_runtime := map[string]interface{}{
		"timeouted":      "retry",
		"readTimeout":    client.DefaultNumber(tea.GetIntValue(runtime.ReadTimeout), client.ReadTimeout),
		"connectTimeout": client.DefaultNumber(tea.GetIntValue(runtime.ConnectTimeout), client.ConnectTimeout),
		"localAddr":      client.Default(tea.GetStringValue(runtime.LocalAddr), client.LocalAddr),
		"httpProxy":      client.Default(tea.GetStringValue(runtime.HttpProxy), client.HttpProxy),
		"httpsProxy":     client.Default(tea.GetStringValue(runtime.HttpsProxy), client.HttpsProxy),
		"noProxy":        client.Default(tea.GetStringValue(runtime.NoProxy), client.NoProxy),
		"socks5Proxy":    client.Default(tea.GetStringValue(runtime.Socks5Proxy), client.Socks5Proxy),
		"socks5NetWork":  client.Default(tea.GetStringValue(runtime.Socks5NetWork), client.Socks5NetWork),
		"maxIdleConns":   client.DefaultNumber(tea.GetIntValue(runtime.MaxIdleConns), client.MaxIdleConns),
		"retry": map[string]interface{}{
			"retryable":   tea.GetBoolValue(runtime.Autoretry),
			"maxAttempts": client.DefaultNumber(tea.GetIntValue(runtime.MaxAttempts), 3),
		},
		"backoff": map[string]interface{}{
			"policy": client.Default(tea.GetStringValue(runtime.BackoffPolicy), "no"),
			"period": client.DefaultNumber(tea.GetIntValue(runtime.BackoffPeriod), 1),
		},
		"ignoreSSL": tea.GetBoolValue(runtime.IgnoreSSL),
		"logger":    client.Logger,
		"listener":  runtime.Listener,
	}

	_resp := &PutObjectAclResponse{}
	for _retryTimes := 0; tea.AllowRetry(_runtime["retry"], _retryTimes); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], _retryTimes)
			if _backoffTime > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, err = func() (*PutObjectAclResponse, error) {
			request_ := tea.NewRequest()
			request_.Protocol = client.Protocol
			request_.Method = "PUT"
			request_.Pathname = "/" + tea.ToString(tea.GetStringValue(request.ObjectName)) + "?acl"
			request_.Headers = tea.Merge(map[string]string{
				"host":       client.GetHost(tea.GetStringValue(request.BucketName)),
				"date":       client.GetDate(),
				"user-agent": client.GetUserAgent(),
			}, client.ToHeader(tea.ToMap(request.Header)))
			request_.Headers["authorization"] = client.GetAuth(request_, tea.GetStringValue(request.BucketName))
			response_, err := tea.DoRequest(request_, _runtime)
			if err != nil {
				return nil, err
			}

			respMap := make(map[string]interface{})

			if client.IsFail(response_) {
				respMap, err = client.GetErrMessage(response_)
				if err != nil {
					return nil, err
				}

				err = tea.NewSDKError(map[string]interface{}{
					"code":    respMap["Code"],
					"message": respMap["Message"],
					"data": map[string]interface{}{
						"httpCode":  response_.StatusCode,
						"requestId": respMap["RequestId"],
						"hostId":    respMap["HostId"],
					},
				})
				return nil, err
			}

			_result := &PutObjectAclResponse{}
			err = tea.Convert(response_.Headers, &_result)
			return _result, err
		}()
		if !tea.Retryable(err) {
			break
		}
	}

	return _resp, err
}

func (client *Client) GetBucketInfo(request *GetBucketInfoRequest, runtime *RuntimeObject) (*GetBucketInfoResponse, error) {
	err := tea.Validate(request)
	if err != nil {
		return nil, err
	}
	err = tea.Validate(runtime)
	if err != nil {
		return nil, err
	}
	_runtime := map[string]interface{}{
		"timeouted":      "retry",
		"readTimeout":    client.DefaultNumber(tea.GetIntValue(runtime.ReadTimeout), client.ReadTimeout),
		"connectTimeout": client.DefaultNumber(tea.GetIntValue(runtime.ConnectTimeout), client.ConnectTimeout),
		"localAddr":      client.Default(tea.GetStringValue(runtime.LocalAddr), client.LocalAddr),
		"httpProxy":      client.Default(tea.GetStringValue(runtime.HttpProxy), client.HttpProxy),
		"httpsProxy":     client.Default(tea.GetStringValue(runtime.HttpsProxy), client.HttpsProxy),
		"noProxy":        client.Default(tea.GetStringValue(runtime.NoProxy), client.NoProxy),
		"socks5Proxy":    client.Default(tea.GetStringValue(runtime.Socks5Proxy), client.Socks5Proxy),
		"socks5NetWork":  client.Default(tea.GetStringValue(runtime.Socks5NetWork), client.Socks5NetWork),
		"maxIdleConns":   client.DefaultNumber(tea.GetIntValue(runtime.MaxIdleConns), client.MaxIdleConns),
		"retry": map[string]interface{}{
			"retryable":   tea.GetBoolValue(runtime.Autoretry),
			"maxAttempts": client.DefaultNumber(tea.GetIntValue(runtime.MaxAttempts), 3),
		},
		"backoff": map[string]interface{}{
			"policy": client.Default(tea.GetStringValue(runtime.BackoffPolicy), "no"),
			"period": client.DefaultNumber(tea.GetIntValue(runtime.BackoffPeriod), 1),
		},
		"ignoreSSL": tea.GetBoolValue(runtime.IgnoreSSL),
		"logger":    client.Logger,
		"listener":  runtime.Listener,
	}

	_resp := &GetBucketInfoResponse{}
	for _retryTimes := 0; tea.AllowRetry(_runtime["retry"], _retryTimes); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], _retryTimes)
			if _backoffTime > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, err = func() (*GetBucketInfoResponse, error) {
			request_ := tea.NewRequest()
			request_.Protocol = client.Protocol
			request_.Method = "GET"
			request_.Pathname = "/?bucketInfo"
			request_.Headers = map[string]string{
				"host":       client.GetHost(tea.GetStringValue(request.BucketName)),
				"date":       client.GetDate(),
				"user-agent": client.GetUserAgent(),
			}
			request_.Headers["authorization"] = client.GetAuth(request_, tea.GetStringValue(request.BucketName))
			response_, err := tea.DoRequest(request_, _runtime)
			if err != nil {
				return nil, err
			}

			respMap := make(map[string]interface{})

			if client.IsFail(response_) {
				respMap, err = client.GetErrMessage(response_)
				if err != nil {
					return nil, err
				}

				err = tea.NewSDKError(map[string]interface{}{
					"code":    respMap["Code"],
					"message": respMap["Message"],
					"data": map[string]interface{}{
						"httpCode":  response_.StatusCode,
						"requestId": respMap["RequestId"],
						"hostId":    respMap["HostId"],
					},
				})
				return nil, err
			}

			respMap, err = client.ParseXml(response_, new(GetBucketInfoResponse))
			if err != nil {
				return nil, err
			}

			_result := &GetBucketInfoResponse{}
			err = tea.Convert(tea.ToMap(map[string]interface{}{
				"BucketInfo": respMap["BucketInfo"],
			}, response_.Headers), &_result)
			return _result, err
		}()
		if !tea.Retryable(err) {
			break
		}
	}

	return _resp, err
}

func (client *Client) PutLiveChannelStatus(request *PutLiveChannelStatusRequest, runtime *RuntimeObject) (*PutLiveChannelStatusResponse, error) {
	err := tea.Validate(request)
	if err != nil {
		return nil, err
	}
	err = tea.Validate(runtime)
	if err != nil {
		return nil, err
	}
	_runtime := map[string]interface{}{
		"timeouted":      "retry",
		"readTimeout":    client.DefaultNumber(tea.GetIntValue(runtime.ReadTimeout), client.ReadTimeout),
		"connectTimeout": client.DefaultNumber(tea.GetIntValue(runtime.ConnectTimeout), client.ConnectTimeout),
		"localAddr":      client.Default(tea.GetStringValue(runtime.LocalAddr), client.LocalAddr),
		"httpProxy":      client.Default(tea.GetStringValue(runtime.HttpProxy), client.HttpProxy),
		"httpsProxy":     client.Default(tea.GetStringValue(runtime.HttpsProxy), client.HttpsProxy),
		"noProxy":        client.Default(tea.GetStringValue(runtime.NoProxy), client.NoProxy),
		"socks5Proxy":    client.Default(tea.GetStringValue(runtime.Socks5Proxy), client.Socks5Proxy),
		"socks5NetWork":  client.Default(tea.GetStringValue(runtime.Socks5NetWork), client.Socks5NetWork),
		"maxIdleConns":   client.DefaultNumber(tea.GetIntValue(runtime.MaxIdleConns), client.MaxIdleConns),
		"retry": map[string]interface{}{
			"retryable":   tea.GetBoolValue(runtime.Autoretry),
			"maxAttempts": client.DefaultNumber(tea.GetIntValue(runtime.MaxAttempts), 3),
		},
		"backoff": map[string]interface{}{
			"policy": client.Default(tea.GetStringValue(runtime.BackoffPolicy), "no"),
			"period": client.DefaultNumber(tea.GetIntValue(runtime.BackoffPeriod), 1),
		},
		"ignoreSSL": tea.GetBoolValue(runtime.IgnoreSSL),
		"logger":    client.Logger,
		"listener":  runtime.Listener,
	}

	_resp := &PutLiveChannelStatusResponse{}
	for _retryTimes := 0; tea.AllowRetry(_runtime["retry"], _retryTimes); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], _retryTimes)
			if _backoffTime > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, err = func() (*PutLiveChannelStatusResponse, error) {
			request_ := tea.NewRequest()
			request_.Protocol = client.Protocol
			request_.Method = "PUT"
			request_.Pathname = "/" + tea.ToString(tea.GetStringValue(request.ChannelName)) + "?live"
			request_.Headers = map[string]string{
				"host":       client.GetHost(tea.GetStringValue(request.BucketName)),
				"date":       client.GetDate(),
				"user-agent": client.GetUserAgent(),
			}
			request_.Query = client.ToQuery(tea.ToMap(request.Filter))
			request_.Headers["authorization"] = client.GetAuth(request_, tea.GetStringValue(request.BucketName))
			response_, err := tea.DoRequest(request_, _runtime)
			if err != nil {
				return nil, err
			}

			respMap := make(map[string]interface{})

			if client.IsFail(response_) {
				respMap, err = client.GetErrMessage(response_)
				if err != nil {
					return nil, err
				}

				err = tea.NewSDKError(map[string]interface{}{
					"code":    respMap["Code"],
					"message": respMap["Message"],
					"data": map[string]interface{}{
						"httpCode":  response_.StatusCode,
						"requestId": respMap["RequestId"],
						"hostId":    respMap["HostId"],
					},
				})
				return nil, err
			}

			_result := &PutLiveChannelStatusResponse{}
			err = tea.Convert(response_.Headers, &_result)
			return _result, err
		}()
		if !tea.Retryable(err) {
			break
		}
	}

	return _resp, err
}

func (client *Client) InitiateMultipartUpload(request *InitiateMultipartUploadRequest, runtime *RuntimeObject) (*InitiateMultipartUploadResponse, error) {
	err := tea.Validate(request)
	if err != nil {
		return nil, err
	}
	err = tea.Validate(runtime)
	if err != nil {
		return nil, err
	}
	_runtime := map[string]interface{}{
		"timeouted":      "retry",
		"readTimeout":    client.DefaultNumber(tea.GetIntValue(runtime.ReadTimeout), client.ReadTimeout),
		"connectTimeout": client.DefaultNumber(tea.GetIntValue(runtime.ConnectTimeout), client.ConnectTimeout),
		"localAddr":      client.Default(tea.GetStringValue(runtime.LocalAddr), client.LocalAddr),
		"httpProxy":      client.Default(tea.GetStringValue(runtime.HttpProxy), client.HttpProxy),
		"httpsProxy":     client.Default(tea.GetStringValue(runtime.HttpsProxy), client.HttpsProxy),
		"noProxy":        client.Default(tea.GetStringValue(runtime.NoProxy), client.NoProxy),
		"socks5Proxy":    client.Default(tea.GetStringValue(runtime.Socks5Proxy), client.Socks5Proxy),
		"socks5NetWork":  client.Default(tea.GetStringValue(runtime.Socks5NetWork), client.Socks5NetWork),
		"maxIdleConns":   client.DefaultNumber(tea.GetIntValue(runtime.MaxIdleConns), client.MaxIdleConns),
		"retry": map[string]interface{}{
			"retryable":   tea.GetBoolValue(runtime.Autoretry),
			"maxAttempts": client.DefaultNumber(tea.GetIntValue(runtime.MaxAttempts), 3),
		},
		"backoff": map[string]interface{}{
			"policy": client.Default(tea.GetStringValue(runtime.BackoffPolicy), "no"),
			"period": client.DefaultNumber(tea.GetIntValue(runtime.BackoffPeriod), 1),
		},
		"ignoreSSL": tea.GetBoolValue(runtime.IgnoreSSL),
		"logger":    client.Logger,
		"listener":  runtime.Listener,
	}

	_resp := &InitiateMultipartUploadResponse{}
	for _retryTimes := 0; tea.AllowRetry(_runtime["retry"], _retryTimes); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], _retryTimes)
			if _backoffTime > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, err = func() (*InitiateMultipartUploadResponse, error) {
			request_ := tea.NewRequest()
			request_.Protocol = client.Protocol
			request_.Method = "POST"
			request_.Pathname = "/" + tea.ToString(tea.GetStringValue(request.ObjectName)) + "?uploads"
			request_.Headers = tea.Merge(map[string]string{
				"host":       client.GetHost(tea.GetStringValue(request.BucketName)),
				"date":       client.GetDate(),
				"user-agent": client.GetUserAgent(),
			}, client.ToHeader(tea.ToMap(request.Header)))
			request_.Query = client.ToQuery(tea.ToMap(request.Filter))
			request_.Headers["content-type"] = client.Default(client.GetSpecialValue(tea.ToMap(request.Header), "content-type"), client.GetContentType(tea.GetStringValue(request.ObjectName)))
			request_.Headers["authorization"] = client.GetAuth(request_, tea.GetStringValue(request.BucketName))
			response_, err := tea.DoRequest(request_, _runtime)
			if err != nil {
				return nil, err
			}

			respMap := make(map[string]interface{})

			if client.IsFail(response_) {
				respMap, err = client.GetErrMessage(response_)
				if err != nil {
					return nil, err
				}

				err = tea.NewSDKError(map[string]interface{}{
					"code":    respMap["Code"],
					"message": respMap["Message"],
					"data": map[string]interface{}{
						"httpCode":  response_.StatusCode,
						"requestId": respMap["RequestId"],
						"hostId":    respMap["HostId"],
					},
				})
				return nil, err
			}

			respMap, err = client.ParseXml(response_, new(InitiateMultipartUploadResponse))
			if err != nil {
				return nil, err
			}

			_result := &InitiateMultipartUploadResponse{}
			err = tea.Convert(tea.ToMap(map[string]interface{}{
				"InitiateMultipartUploadResult": respMap["InitiateMultipartUploadResult"],
			}, response_.Headers), &_result)
			return _result, err
		}()
		if !tea.Retryable(err) {
			break
		}
	}

	return _resp, err
}

func (client *Client) OptionObject(request *OptionObjectRequest, runtime *RuntimeObject) (*OptionObjectResponse, error) {
	err := tea.Validate(request)
	if err != nil {
		return nil, err
	}
	err = tea.Validate(runtime)
	if err != nil {
		return nil, err
	}
	_runtime := map[string]interface{}{
		"timeouted":      "retry",
		"readTimeout":    client.DefaultNumber(tea.GetIntValue(runtime.ReadTimeout), client.ReadTimeout),
		"connectTimeout": client.DefaultNumber(tea.GetIntValue(runtime.ConnectTimeout), client.ConnectTimeout),
		"localAddr":      client.Default(tea.GetStringValue(runtime.LocalAddr), client.LocalAddr),
		"httpProxy":      client.Default(tea.GetStringValue(runtime.HttpProxy), client.HttpProxy),
		"httpsProxy":     client.Default(tea.GetStringValue(runtime.HttpsProxy), client.HttpsProxy),
		"noProxy":        client.Default(tea.GetStringValue(runtime.NoProxy), client.NoProxy),
		"socks5Proxy":    client.Default(tea.GetStringValue(runtime.Socks5Proxy), client.Socks5Proxy),
		"socks5NetWork":  client.Default(tea.GetStringValue(runtime.Socks5NetWork), client.Socks5NetWork),
		"maxIdleConns":   client.DefaultNumber(tea.GetIntValue(runtime.MaxIdleConns), client.MaxIdleConns),
		"retry": map[string]interface{}{
			"retryable":   tea.GetBoolValue(runtime.Autoretry),
			"maxAttempts": client.DefaultNumber(tea.GetIntValue(runtime.MaxAttempts), 3),
		},
		"backoff": map[string]interface{}{
			"policy": client.Default(tea.GetStringValue(runtime.BackoffPolicy), "no"),
			"period": client.DefaultNumber(tea.GetIntValue(runtime.BackoffPeriod), 1),
		},
		"ignoreSSL": tea.GetBoolValue(runtime.IgnoreSSL),
		"logger":    client.Logger,
		"listener":  runtime.Listener,
	}

	_resp := &OptionObjectResponse{}
	for _retryTimes := 0; tea.AllowRetry(_runtime["retry"], _retryTimes); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], _retryTimes)
			if _backoffTime > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, err = func() (*OptionObjectResponse, error) {
			request_ := tea.NewRequest()
			request_.Protocol = client.Protocol
			request_.Method = "OPTIONS"
			request_.Pathname = "/" + tea.ToString(tea.GetStringValue(request.ObjectName))
			request_.Headers = tea.Merge(map[string]string{
				"host":       client.GetHost(tea.GetStringValue(request.BucketName)),
				"date":       client.GetDate(),
				"user-agent": client.GetUserAgent(),
			}, client.ToHeader(tea.ToMap(request.Header)))
			request_.Headers["authorization"] = client.GetAuth(request_, tea.GetStringValue(request.BucketName))
			response_, err := tea.DoRequest(request_, _runtime)
			if err != nil {
				return nil, err
			}

			respMap := make(map[string]interface{})

			if client.IsFail(response_) {
				respMap, err = client.GetErrMessage(response_)
				if err != nil {
					return nil, err
				}

				err = tea.NewSDKError(map[string]interface{}{
					"code":    respMap["Code"],
					"message": respMap["Message"],
					"data": map[string]interface{}{
						"httpCode":  response_.StatusCode,
						"requestId": respMap["RequestId"],
						"hostId":    respMap["HostId"],
					},
				})
				return nil, err
			}

			_result := &OptionObjectResponse{}
			err = tea.Convert(response_.Headers, &_result)
			return _result, err
		}()
		if !tea.Retryable(err) {
			break
		}
	}

	return _resp, err
}

func (client *Client) PostVodPlaylist(request *PostVodPlaylistRequest, runtime *RuntimeObject) (*PostVodPlaylistResponse, error) {
	err := tea.Validate(request)
	if err != nil {
		return nil, err
	}
	err = tea.Validate(runtime)
	if err != nil {
		return nil, err
	}
	_runtime := map[string]interface{}{
		"timeouted":      "retry",
		"readTimeout":    client.DefaultNumber(tea.GetIntValue(runtime.ReadTimeout), client.ReadTimeout),
		"connectTimeout": client.DefaultNumber(tea.GetIntValue(runtime.ConnectTimeout), client.ConnectTimeout),
		"localAddr":      client.Default(tea.GetStringValue(runtime.LocalAddr), client.LocalAddr),
		"httpProxy":      client.Default(tea.GetStringValue(runtime.HttpProxy), client.HttpProxy),
		"httpsProxy":     client.Default(tea.GetStringValue(runtime.HttpsProxy), client.HttpsProxy),
		"noProxy":        client.Default(tea.GetStringValue(runtime.NoProxy), client.NoProxy),
		"socks5Proxy":    client.Default(tea.GetStringValue(runtime.Socks5Proxy), client.Socks5Proxy),
		"socks5NetWork":  client.Default(tea.GetStringValue(runtime.Socks5NetWork), client.Socks5NetWork),
		"maxIdleConns":   client.DefaultNumber(tea.GetIntValue(runtime.MaxIdleConns), client.MaxIdleConns),
		"retry": map[string]interface{}{
			"retryable":   tea.GetBoolValue(runtime.Autoretry),
			"maxAttempts": client.DefaultNumber(tea.GetIntValue(runtime.MaxAttempts), 3),
		},
		"backoff": map[string]interface{}{
			"policy": client.Default(tea.GetStringValue(runtime.BackoffPolicy), "no"),
			"period": client.DefaultNumber(tea.GetIntValue(runtime.BackoffPeriod), 1),
		},
		"ignoreSSL": tea.GetBoolValue(runtime.IgnoreSSL),
		"logger":    client.Logger,
		"listener":  runtime.Listener,
	}

	_resp := &PostVodPlaylistResponse{}
	for _retryTimes := 0; tea.AllowRetry(_runtime["retry"], _retryTimes); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], _retryTimes)
			if _backoffTime > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, err = func() (*PostVodPlaylistResponse, error) {
			request_ := tea.NewRequest()
			request_.Protocol = client.Protocol
			request_.Method = "POST"
			request_.Pathname = "/" + tea.ToString(tea.GetStringValue(request.ChannelName)) + "/" + tea.ToString(tea.GetStringValue(request.PlaylistName)) + "?vod"
			request_.Headers = map[string]string{
				"host":       client.GetHost(tea.GetStringValue(request.BucketName)),
				"date":       client.GetDate(),
				"user-agent": client.GetUserAgent(),
			}
			request_.Query = client.ToQuery(tea.ToMap(request.Filter))
			request_.Headers["authorization"] = client.GetAuth(request_, tea.GetStringValue(request.BucketName))
			response_, err := tea.DoRequest(request_, _runtime)
			if err != nil {
				return nil, err
			}

			respMap := make(map[string]interface{})

			if client.IsFail(response_) {
				respMap, err = client.GetErrMessage(response_)
				if err != nil {
					return nil, err
				}

				err = tea.NewSDKError(map[string]interface{}{
					"code":    respMap["Code"],
					"message": respMap["Message"],
					"data": map[string]interface{}{
						"httpCode":  response_.StatusCode,
						"requestId": respMap["RequestId"],
						"hostId":    respMap["HostId"],
					},
				})
				return nil, err
			}

			_result := &PostVodPlaylistResponse{}
			err = tea.Convert(response_.Headers, &_result)
			return _result, err
		}()
		if !tea.Retryable(err) {
			break
		}
	}

	return _resp, err
}

func (client *Client) PostObject(request *PostObjectRequest, runtime *RuntimeObject) (*PostObjectResponse, error) {
	err := tea.Validate(request)
	if err != nil {
		return nil, err
	}
	err = tea.Validate(runtime)
	if err != nil {
		return nil, err
	}
	_runtime := map[string]interface{}{
		"timeouted":      "retry",
		"readTimeout":    client.DefaultNumber(tea.GetIntValue(runtime.ReadTimeout), client.ReadTimeout),
		"connectTimeout": client.DefaultNumber(tea.GetIntValue(runtime.ConnectTimeout), client.ConnectTimeout),
		"localAddr":      client.Default(tea.GetStringValue(runtime.LocalAddr), client.LocalAddr),
		"httpProxy":      client.Default(tea.GetStringValue(runtime.HttpProxy), client.HttpProxy),
		"httpsProxy":     client.Default(tea.GetStringValue(runtime.HttpsProxy), client.HttpsProxy),
		"noProxy":        client.Default(tea.GetStringValue(runtime.NoProxy), client.NoProxy),
		"socks5Proxy":    client.Default(tea.GetStringValue(runtime.Socks5Proxy), client.Socks5Proxy),
		"socks5NetWork":  client.Default(tea.GetStringValue(runtime.Socks5NetWork), client.Socks5NetWork),
		"maxIdleConns":   client.DefaultNumber(tea.GetIntValue(runtime.MaxIdleConns), client.MaxIdleConns),
		"retry": map[string]interface{}{
			"retryable":   tea.GetBoolValue(runtime.Autoretry),
			"maxAttempts": client.DefaultNumber(tea.GetIntValue(runtime.MaxAttempts), 3),
		},
		"backoff": map[string]interface{}{
			"policy": client.Default(tea.GetStringValue(runtime.BackoffPolicy), "no"),
			"period": client.DefaultNumber(tea.GetIntValue(runtime.BackoffPeriod), 1),
		},
		"ignoreSSL": tea.GetBoolValue(runtime.IgnoreSSL),
		"logger":    client.Logger,
		"listener":  runtime.Listener,
	}

	_resp := &PostObjectResponse{}
	for _retryTimes := 0; tea.AllowRetry(_runtime["retry"], _retryTimes); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], _retryTimes)
			if _backoffTime > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, err = func() (*PostObjectResponse, error) {
			request_ := tea.NewRequest()
			request_.Protocol = client.Protocol
			request_.Method = "POST"
			request_.Pathname = "/"
			request_.Headers = map[string]string{
				"host":       client.GetHost(tea.GetStringValue(request.BucketName)),
				"date":       client.GetDate(),
				"user-agent": client.GetUserAgent(),
			}
			request_.Headers["authorization"] = client.GetAuth(request_, tea.GetStringValue(request.BucketName))
			response_, err := tea.DoRequest(request_, _runtime)
			if err != nil {
				return nil, err
			}

			respMap := make(map[string]interface{})

			if client.IsFail(response_) {
				respMap, err = client.GetErrMessage(response_)
				if err != nil {
					return nil, err
				}

				err = tea.NewSDKError(map[string]interface{}{
					"code":    respMap["Code"],
					"message": respMap["Message"],
					"data": map[string]interface{}{
						"httpCode":  response_.StatusCode,
						"requestId": respMap["RequestId"],
						"hostId":    respMap["HostId"],
					},
				})
				return nil, err
			}

			_result := &PostObjectResponse{}
			err = tea.Convert(response_.Headers, &_result)
			return _result, err
		}()
		if !tea.Retryable(err) {
			break
		}
	}

	return _resp, err
}

func (client *Client) HeadObject(request *HeadObjectRequest, runtime *RuntimeObject) (*HeadObjectResponse, error) {
	err := tea.Validate(request)
	if err != nil {
		return nil, err
	}
	err = tea.Validate(runtime)
	if err != nil {
		return nil, err
	}
	_runtime := map[string]interface{}{
		"timeouted":      "retry",
		"readTimeout":    client.DefaultNumber(tea.GetIntValue(runtime.ReadTimeout), client.ReadTimeout),
		"connectTimeout": client.DefaultNumber(tea.GetIntValue(runtime.ConnectTimeout), client.ConnectTimeout),
		"localAddr":      client.Default(tea.GetStringValue(runtime.LocalAddr), client.LocalAddr),
		"httpProxy":      client.Default(tea.GetStringValue(runtime.HttpProxy), client.HttpProxy),
		"httpsProxy":     client.Default(tea.GetStringValue(runtime.HttpsProxy), client.HttpsProxy),
		"noProxy":        client.Default(tea.GetStringValue(runtime.NoProxy), client.NoProxy),
		"socks5Proxy":    client.Default(tea.GetStringValue(runtime.Socks5Proxy), client.Socks5Proxy),
		"socks5NetWork":  client.Default(tea.GetStringValue(runtime.Socks5NetWork), client.Socks5NetWork),
		"maxIdleConns":   client.DefaultNumber(tea.GetIntValue(runtime.MaxIdleConns), client.MaxIdleConns),
		"retry": map[string]interface{}{
			"retryable":   tea.GetBoolValue(runtime.Autoretry),
			"maxAttempts": client.DefaultNumber(tea.GetIntValue(runtime.MaxAttempts), 3),
		},
		"backoff": map[string]interface{}{
			"policy": client.Default(tea.GetStringValue(runtime.BackoffPolicy), "no"),
			"period": client.DefaultNumber(tea.GetIntValue(runtime.BackoffPeriod), 1),
		},
		"ignoreSSL": tea.GetBoolValue(runtime.IgnoreSSL),
		"logger":    client.Logger,
		"listener":  runtime.Listener,
	}

	_resp := &HeadObjectResponse{}
	for _retryTimes := 0; tea.AllowRetry(_runtime["retry"], _retryTimes); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], _retryTimes)
			if _backoffTime > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, err = func() (*HeadObjectResponse, error) {
			request_ := tea.NewRequest()
			request_.Protocol = client.Protocol
			request_.Method = "HEAD"
			request_.Pathname = "/" + tea.ToString(tea.GetStringValue(request.ObjectName))
			request_.Headers = tea.Merge(map[string]string{
				"host":       client.GetHost(tea.GetStringValue(request.BucketName)),
				"date":       client.GetDate(),
				"user-agent": client.GetUserAgent(),
			}, client.ToHeader(tea.ToMap(request.Header)))
			request_.Headers["authorization"] = client.GetAuth(request_, tea.GetStringValue(request.BucketName))
			response_, err := tea.DoRequest(request_, _runtime)
			if err != nil {
				return nil, err
			}

			respMap := make(map[string]interface{})

			if client.IsFail(response_) {
				respMap, err = client.GetErrMessage(response_)
				if err != nil {
					return nil, err
				}

				err = tea.NewSDKError(map[string]interface{}{
					"code":    respMap["Code"],
					"message": respMap["Message"],
					"data": map[string]interface{}{
						"httpCode":  response_.StatusCode,
						"requestId": respMap["RequestId"],
						"hostId":    respMap["HostId"],
					},
				})
				return nil, err
			}

			_result := &HeadObjectResponse{}
			err = tea.Convert(tea.ToMap(map[string]interface{}{
				"usermeta": client.ToMeta(response_.Headers, "x-oss-meta-"),
			}, response_.Headers), &_result)
			return _result, err
		}()
		if !tea.Retryable(err) {
			break
		}
	}

	return _resp, err
}

func (client *Client) DeleteObjectTagging(request *DeleteObjectTaggingRequest, runtime *RuntimeObject) (*DeleteObjectTaggingResponse, error) {
	err := tea.Validate(request)
	if err != nil {
		return nil, err
	}
	err = tea.Validate(runtime)
	if err != nil {
		return nil, err
	}
	_runtime := map[string]interface{}{
		"timeouted":      "retry",
		"readTimeout":    client.DefaultNumber(tea.GetIntValue(runtime.ReadTimeout), client.ReadTimeout),
		"connectTimeout": client.DefaultNumber(tea.GetIntValue(runtime.ConnectTimeout), client.ConnectTimeout),
		"localAddr":      client.Default(tea.GetStringValue(runtime.LocalAddr), client.LocalAddr),
		"httpProxy":      client.Default(tea.GetStringValue(runtime.HttpProxy), client.HttpProxy),
		"httpsProxy":     client.Default(tea.GetStringValue(runtime.HttpsProxy), client.HttpsProxy),
		"noProxy":        client.Default(tea.GetStringValue(runtime.NoProxy), client.NoProxy),
		"socks5Proxy":    client.Default(tea.GetStringValue(runtime.Socks5Proxy), client.Socks5Proxy),
		"socks5NetWork":  client.Default(tea.GetStringValue(runtime.Socks5NetWork), client.Socks5NetWork),
		"maxIdleConns":   client.DefaultNumber(tea.GetIntValue(runtime.MaxIdleConns), client.MaxIdleConns),
		"retry": map[string]interface{}{
			"retryable":   tea.GetBoolValue(runtime.Autoretry),
			"maxAttempts": client.DefaultNumber(tea.GetIntValue(runtime.MaxAttempts), 3),
		},
		"backoff": map[string]interface{}{
			"policy": client.Default(tea.GetStringValue(runtime.BackoffPolicy), "no"),
			"period": client.DefaultNumber(tea.GetIntValue(runtime.BackoffPeriod), 1),
		},
		"ignoreSSL": tea.GetBoolValue(runtime.IgnoreSSL),
		"logger":    client.Logger,
		"listener":  runtime.Listener,
	}

	_resp := &DeleteObjectTaggingResponse{}
	for _retryTimes := 0; tea.AllowRetry(_runtime["retry"], _retryTimes); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], _retryTimes)
			if _backoffTime > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, err = func() (*DeleteObjectTaggingResponse, error) {
			request_ := tea.NewRequest()
			request_.Protocol = client.Protocol
			request_.Method = "DELETE"
			request_.Pathname = "/" + tea.ToString(tea.GetStringValue(request.ObjectName)) + "?tagging"
			request_.Headers = map[string]string{
				"host":       client.GetHost(tea.GetStringValue(request.BucketName)),
				"date":       client.GetDate(),
				"user-agent": client.GetUserAgent(),
			}
			request_.Headers["authorization"] = client.GetAuth(request_, tea.GetStringValue(request.BucketName))
			response_, err := tea.DoRequest(request_, _runtime)
			if err != nil {
				return nil, err
			}

			respMap := make(map[string]interface{})

			if client.IsFail(response_) {
				respMap, err = client.GetErrMessage(response_)
				if err != nil {
					return nil, err
				}

				err = tea.NewSDKError(map[string]interface{}{
					"code":    respMap["Code"],
					"message": respMap["Message"],
					"data": map[string]interface{}{
						"httpCode":  response_.StatusCode,
						"requestId": respMap["RequestId"],
						"hostId":    respMap["HostId"],
					},
				})
				return nil, err
			}

			_result := &DeleteObjectTaggingResponse{}
			err = tea.Convert(response_.Headers, &_result)
			return _result, err
		}()
		if !tea.Retryable(err) {
			break
		}
	}

	return _resp, err
}

func (client *Client) RestoreObject(request *RestoreObjectRequest, runtime *RuntimeObject) (*RestoreObjectResponse, error) {
	err := tea.Validate(request)
	if err != nil {
		return nil, err
	}
	err = tea.Validate(runtime)
	if err != nil {
		return nil, err
	}
	_runtime := map[string]interface{}{
		"timeouted":      "retry",
		"readTimeout":    client.DefaultNumber(tea.GetIntValue(runtime.ReadTimeout), client.ReadTimeout),
		"connectTimeout": client.DefaultNumber(tea.GetIntValue(runtime.ConnectTimeout), client.ConnectTimeout),
		"localAddr":      client.Default(tea.GetStringValue(runtime.LocalAddr), client.LocalAddr),
		"httpProxy":      client.Default(tea.GetStringValue(runtime.HttpProxy), client.HttpProxy),
		"httpsProxy":     client.Default(tea.GetStringValue(runtime.HttpsProxy), client.HttpsProxy),
		"noProxy":        client.Default(tea.GetStringValue(runtime.NoProxy), client.NoProxy),
		"socks5Proxy":    client.Default(tea.GetStringValue(runtime.Socks5Proxy), client.Socks5Proxy),
		"socks5NetWork":  client.Default(tea.GetStringValue(runtime.Socks5NetWork), client.Socks5NetWork),
		"maxIdleConns":   client.DefaultNumber(tea.GetIntValue(runtime.MaxIdleConns), client.MaxIdleConns),
		"retry": map[string]interface{}{
			"retryable":   tea.GetBoolValue(runtime.Autoretry),
			"maxAttempts": client.DefaultNumber(tea.GetIntValue(runtime.MaxAttempts), 3),
		},
		"backoff": map[string]interface{}{
			"policy": client.Default(tea.GetStringValue(runtime.BackoffPolicy), "no"),
			"period": client.DefaultNumber(tea.GetIntValue(runtime.BackoffPeriod), 1),
		},
		"ignoreSSL": tea.GetBoolValue(runtime.IgnoreSSL),
		"logger":    client.Logger,
		"listener":  runtime.Listener,
	}

	_resp := &RestoreObjectResponse{}
	for _retryTimes := 0; tea.AllowRetry(_runtime["retry"], _retryTimes); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], _retryTimes)
			if _backoffTime > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, err = func() (*RestoreObjectResponse, error) {
			request_ := tea.NewRequest()
			request_.Protocol = client.Protocol
			request_.Method = "POST"
			request_.Pathname = "/" + tea.ToString(tea.GetStringValue(request.ObjectName)) + "?restore"
			request_.Headers = map[string]string{
				"host":       client.GetHost(tea.GetStringValue(request.BucketName)),
				"date":       client.GetDate(),
				"user-agent": client.GetUserAgent(),
			}
			request_.Headers["authorization"] = client.GetAuth(request_, tea.GetStringValue(request.BucketName))
			response_, err := tea.DoRequest(request_, _runtime)
			if err != nil {
				return nil, err
			}

			respMap := make(map[string]interface{})

			if client.IsFail(response_) {
				respMap, err = client.GetErrMessage(response_)
				if err != nil {
					return nil, err
				}

				err = tea.NewSDKError(map[string]interface{}{
					"code":    respMap["Code"],
					"message": respMap["Message"],
					"data": map[string]interface{}{
						"httpCode":  response_.StatusCode,
						"requestId": respMap["RequestId"],
						"hostId":    respMap["HostId"],
					},
				})
				return nil, err
			}

			_result := &RestoreObjectResponse{}
			err = tea.Convert(response_.Headers, &_result)
			return _result, err
		}()
		if !tea.Retryable(err) {
			break
		}
	}

	return _resp, err
}

func (client *Client) GetObjectAcl(request *GetObjectAclRequest, runtime *RuntimeObject) (*GetObjectAclResponse, error) {
	err := tea.Validate(request)
	if err != nil {
		return nil, err
	}
	err = tea.Validate(runtime)
	if err != nil {
		return nil, err
	}
	_runtime := map[string]interface{}{
		"timeouted":      "retry",
		"readTimeout":    client.DefaultNumber(tea.GetIntValue(runtime.ReadTimeout), client.ReadTimeout),
		"connectTimeout": client.DefaultNumber(tea.GetIntValue(runtime.ConnectTimeout), client.ConnectTimeout),
		"localAddr":      client.Default(tea.GetStringValue(runtime.LocalAddr), client.LocalAddr),
		"httpProxy":      client.Default(tea.GetStringValue(runtime.HttpProxy), client.HttpProxy),
		"httpsProxy":     client.Default(tea.GetStringValue(runtime.HttpsProxy), client.HttpsProxy),
		"noProxy":        client.Default(tea.GetStringValue(runtime.NoProxy), client.NoProxy),
		"socks5Proxy":    client.Default(tea.GetStringValue(runtime.Socks5Proxy), client.Socks5Proxy),
		"socks5NetWork":  client.Default(tea.GetStringValue(runtime.Socks5NetWork), client.Socks5NetWork),
		"maxIdleConns":   client.DefaultNumber(tea.GetIntValue(runtime.MaxIdleConns), client.MaxIdleConns),
		"retry": map[string]interface{}{
			"retryable":   tea.GetBoolValue(runtime.Autoretry),
			"maxAttempts": client.DefaultNumber(tea.GetIntValue(runtime.MaxAttempts), 3),
		},
		"backoff": map[string]interface{}{
			"policy": client.Default(tea.GetStringValue(runtime.BackoffPolicy), "no"),
			"period": client.DefaultNumber(tea.GetIntValue(runtime.BackoffPeriod), 1),
		},
		"ignoreSSL": tea.GetBoolValue(runtime.IgnoreSSL),
		"logger":    client.Logger,
		"listener":  runtime.Listener,
	}

	_resp := &GetObjectAclResponse{}
	for _retryTimes := 0; tea.AllowRetry(_runtime["retry"], _retryTimes); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], _retryTimes)
			if _backoffTime > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, err = func() (*GetObjectAclResponse, error) {
			request_ := tea.NewRequest()
			request_.Protocol = client.Protocol
			request_.Method = "GET"
			request_.Pathname = "/" + tea.ToString(tea.GetStringValue(request.ObjectName)) + "?acl"
			request_.Headers = map[string]string{
				"host":       client.GetHost(tea.GetStringValue(request.BucketName)),
				"date":       client.GetDate(),
				"user-agent": client.GetUserAgent(),
			}
			request_.Headers["authorization"] = client.GetAuth(request_, tea.GetStringValue(request.BucketName))
			response_, err := tea.DoRequest(request_, _runtime)
			if err != nil {
				return nil, err
			}

			respMap := make(map[string]interface{})

			if client.IsFail(response_) {
				respMap, err = client.GetErrMessage(response_)
				if err != nil {
					return nil, err
				}

				err = tea.NewSDKError(map[string]interface{}{
					"code":    respMap["Code"],
					"message": respMap["Message"],
					"data": map[string]interface{}{
						"httpCode":  response_.StatusCode,
						"requestId": respMap["RequestId"],
						"hostId":    respMap["HostId"],
					},
				})
				return nil, err
			}

			respMap, err = client.ParseXml(response_, new(GetObjectAclResponse))
			if err != nil {
				return nil, err
			}

			_result := &GetObjectAclResponse{}
			err = tea.Convert(tea.ToMap(map[string]interface{}{
				"AccessControlPolicy": respMap["AccessControlPolicy"],
			}, response_.Headers), &_result)
			return _result, err
		}()
		if !tea.Retryable(err) {
			break
		}
	}

	return _resp, err
}

func (client *Client) PutBucketAcl(request *PutBucketAclRequest, runtime *RuntimeObject) (*PutBucketAclResponse, error) {
	err := tea.Validate(request)
	if err != nil {
		return nil, err
	}
	err = tea.Validate(runtime)
	if err != nil {
		return nil, err
	}
	_runtime := map[string]interface{}{
		"timeouted":      "retry",
		"readTimeout":    client.DefaultNumber(tea.GetIntValue(runtime.ReadTimeout), client.ReadTimeout),
		"connectTimeout": client.DefaultNumber(tea.GetIntValue(runtime.ConnectTimeout), client.ConnectTimeout),
		"localAddr":      client.Default(tea.GetStringValue(runtime.LocalAddr), client.LocalAddr),
		"httpProxy":      client.Default(tea.GetStringValue(runtime.HttpProxy), client.HttpProxy),
		"httpsProxy":     client.Default(tea.GetStringValue(runtime.HttpsProxy), client.HttpsProxy),
		"noProxy":        client.Default(tea.GetStringValue(runtime.NoProxy), client.NoProxy),
		"socks5Proxy":    client.Default(tea.GetStringValue(runtime.Socks5Proxy), client.Socks5Proxy),
		"socks5NetWork":  client.Default(tea.GetStringValue(runtime.Socks5NetWork), client.Socks5NetWork),
		"maxIdleConns":   client.DefaultNumber(tea.GetIntValue(runtime.MaxIdleConns), client.MaxIdleConns),
		"retry": map[string]interface{}{
			"retryable":   tea.GetBoolValue(runtime.Autoretry),
			"maxAttempts": client.DefaultNumber(tea.GetIntValue(runtime.MaxAttempts), 3),
		},
		"backoff": map[string]interface{}{
			"policy": client.Default(tea.GetStringValue(runtime.BackoffPolicy), "no"),
			"period": client.DefaultNumber(tea.GetIntValue(runtime.BackoffPeriod), 1),
		},
		"ignoreSSL": tea.GetBoolValue(runtime.IgnoreSSL),
		"logger":    client.Logger,
		"listener":  runtime.Listener,
	}

	_resp := &PutBucketAclResponse{}
	for _retryTimes := 0; tea.AllowRetry(_runtime["retry"], _retryTimes); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], _retryTimes)
			if _backoffTime > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, err = func() (*PutBucketAclResponse, error) {
			request_ := tea.NewRequest()
			request_.Protocol = client.Protocol
			request_.Method = "PUT"
			request_.Pathname = "/?acl"
			request_.Headers = tea.Merge(map[string]string{
				"host":       client.GetHost(tea.GetStringValue(request.BucketName)),
				"date":       client.GetDate(),
				"user-agent": client.GetUserAgent(),
			}, client.ToHeader(tea.ToMap(request.Header)))
			request_.Headers["authorization"] = client.GetAuth(request_, tea.GetStringValue(request.BucketName))
			response_, err := tea.DoRequest(request_, _runtime)
			if err != nil {
				return nil, err
			}

			respMap := make(map[string]interface{})

			if client.IsFail(response_) {
				respMap, err = client.GetErrMessage(response_)
				if err != nil {
					return nil, err
				}

				err = tea.NewSDKError(map[string]interface{}{
					"code":    respMap["Code"],
					"message": respMap["Message"],
					"data": map[string]interface{}{
						"httpCode":  response_.StatusCode,
						"requestId": respMap["RequestId"],
						"hostId":    respMap["HostId"],
					},
				})
				return nil, err
			}

			_result := &PutBucketAclResponse{}
			err = tea.Convert(response_.Headers, &_result)
			return _result, err
		}()
		if !tea.Retryable(err) {
			break
		}
	}

	return _resp, err
}

func (client *Client) DeleteBucket(request *DeleteBucketRequest, runtime *RuntimeObject) (*DeleteBucketResponse, error) {
	err := tea.Validate(request)
	if err != nil {
		return nil, err
	}
	err = tea.Validate(runtime)
	if err != nil {
		return nil, err
	}
	_runtime := map[string]interface{}{
		"timeouted":      "retry",
		"readTimeout":    client.DefaultNumber(tea.GetIntValue(runtime.ReadTimeout), client.ReadTimeout),
		"connectTimeout": client.DefaultNumber(tea.GetIntValue(runtime.ConnectTimeout), client.ConnectTimeout),
		"localAddr":      client.Default(tea.GetStringValue(runtime.LocalAddr), client.LocalAddr),
		"httpProxy":      client.Default(tea.GetStringValue(runtime.HttpProxy), client.HttpProxy),
		"httpsProxy":     client.Default(tea.GetStringValue(runtime.HttpsProxy), client.HttpsProxy),
		"noProxy":        client.Default(tea.GetStringValue(runtime.NoProxy), client.NoProxy),
		"socks5Proxy":    client.Default(tea.GetStringValue(runtime.Socks5Proxy), client.Socks5Proxy),
		"socks5NetWork":  client.Default(tea.GetStringValue(runtime.Socks5NetWork), client.Socks5NetWork),
		"maxIdleConns":   client.DefaultNumber(tea.GetIntValue(runtime.MaxIdleConns), client.MaxIdleConns),
		"retry": map[string]interface{}{
			"retryable":   tea.GetBoolValue(runtime.Autoretry),
			"maxAttempts": client.DefaultNumber(tea.GetIntValue(runtime.MaxAttempts), 3),
		},
		"backoff": map[string]interface{}{
			"policy": client.Default(tea.GetStringValue(runtime.BackoffPolicy), "no"),
			"period": client.DefaultNumber(tea.GetIntValue(runtime.BackoffPeriod), 1),
		},
		"ignoreSSL": tea.GetBoolValue(runtime.IgnoreSSL),
		"logger":    client.Logger,
		"listener":  runtime.Listener,
	}

	_resp := &DeleteBucketResponse{}
	for _retryTimes := 0; tea.AllowRetry(_runtime["retry"], _retryTimes); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], _retryTimes)
			if _backoffTime > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, err = func() (*DeleteBucketResponse, error) {
			request_ := tea.NewRequest()
			request_.Protocol = client.Protocol
			request_.Method = "DELETE"
			request_.Pathname = "/"
			request_.Headers = map[string]string{
				"host":       client.GetHost(tea.GetStringValue(request.BucketName)),
				"date":       client.GetDate(),
				"user-agent": client.GetUserAgent(),
			}
			request_.Headers["authorization"] = client.GetAuth(request_, tea.GetStringValue(request.BucketName))
			response_, err := tea.DoRequest(request_, _runtime)
			if err != nil {
				return nil, err
			}

			respMap := make(map[string]interface{})

			if client.IsFail(response_) {
				respMap, err = client.GetErrMessage(response_)
				if err != nil {
					return nil, err
				}

				err = tea.NewSDKError(map[string]interface{}{
					"code":    respMap["Code"],
					"message": respMap["Message"],
					"data": map[string]interface{}{
						"httpCode":  response_.StatusCode,
						"requestId": respMap["RequestId"],
						"hostId":    respMap["HostId"],
					},
				})
				return nil, err
			}

			_result := &DeleteBucketResponse{}
			err = tea.Convert(response_.Headers, &_result)
			return _result, err
		}()
		if !tea.Retryable(err) {
			break
		}
	}

	return _resp, err
}

func (client *Client) PutObject(request *PutObjectRequest, runtime *RuntimeObject) (*PutObjectResponse, error) {
	err := tea.Validate(request)
	if err != nil {
		return nil, err
	}
	err = tea.Validate(runtime)
	if err != nil {
		return nil, err
	}
	_runtime := map[string]interface{}{
		"timeouted":      "retry",
		"readTimeout":    client.DefaultNumber(tea.GetIntValue(runtime.ReadTimeout), client.ReadTimeout),
		"connectTimeout": client.DefaultNumber(tea.GetIntValue(runtime.ConnectTimeout), client.ConnectTimeout),
		"localAddr":      client.Default(tea.GetStringValue(runtime.LocalAddr), client.LocalAddr),
		"httpProxy":      client.Default(tea.GetStringValue(runtime.HttpProxy), client.HttpProxy),
		"httpsProxy":     client.Default(tea.GetStringValue(runtime.HttpsProxy), client.HttpsProxy),
		"noProxy":        client.Default(tea.GetStringValue(runtime.NoProxy), client.NoProxy),
		"socks5Proxy":    client.Default(tea.GetStringValue(runtime.Socks5Proxy), client.Socks5Proxy),
		"socks5NetWork":  client.Default(tea.GetStringValue(runtime.Socks5NetWork), client.Socks5NetWork),
		"maxIdleConns":   client.DefaultNumber(tea.GetIntValue(runtime.MaxIdleConns), client.MaxIdleConns),
		"retry": map[string]interface{}{
			"retryable":   tea.GetBoolValue(runtime.Autoretry),
			"maxAttempts": client.DefaultNumber(tea.GetIntValue(runtime.MaxAttempts), 3),
		},
		"backoff": map[string]interface{}{
			"policy": client.Default(tea.GetStringValue(runtime.BackoffPolicy), "no"),
			"period": client.DefaultNumber(tea.GetIntValue(runtime.BackoffPeriod), 1),
		},
		"ignoreSSL": tea.GetBoolValue(runtime.IgnoreSSL),
		"logger":    client.Logger,
		"listener":  runtime.Listener,
	}

	_resp := &PutObjectResponse{}
	for _retryTimes := 0; tea.AllowRetry(_runtime["retry"], _retryTimes); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], _retryTimes)
			if _backoffTime > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, err = func() (*PutObjectResponse, error) {
			request_ := tea.NewRequest()
			request_.Protocol = client.Protocol
			request_.Method = "PUT"
			request_.Pathname = "/" + tea.ToString(tea.GetStringValue(request.ObjectName))
			request_.Headers = tea.Merge(map[string]string{
				"host":       client.GetHost(tea.GetStringValue(request.BucketName)),
				"date":       client.GetDate(),
				"user-agent": client.GetUserAgent(),
			}, client.ToHeader(tea.ToMap(request.Header)),
				client.ParseMeta(request.UserMeta, "x-oss-meta-"))
			request_.Body = request.Body
			request_.Headers["content-type"] = client.Default(client.GetSpecialValue(tea.ToMap(request.Header), "content-type"), client.GetContentType(tea.GetStringValue(request.ObjectName)))
			request_.Headers["authorization"] = client.GetAuth(request_, tea.GetStringValue(request.BucketName))
			response_, err := tea.DoRequest(request_, _runtime)
			if err != nil {
				return nil, err
			}

			respMap := make(map[string]interface{})

			if client.IsFail(response_) {
				respMap, err = client.GetErrMessage(response_)
				if err != nil {
					return nil, err
				}

				err = tea.NewSDKError(map[string]interface{}{
					"code":    respMap["Code"],
					"message": respMap["Message"],
					"data": map[string]interface{}{
						"httpCode":  response_.StatusCode,
						"requestId": respMap["RequestId"],
						"hostId":    respMap["HostId"],
					},
				})
				return nil, err
			}

			_result := &PutObjectResponse{}
			err = tea.Convert(response_.Headers, &_result)
			return _result, err
		}()
		if !tea.Retryable(err) {
			break
		}
	}

	return _resp, err
}
