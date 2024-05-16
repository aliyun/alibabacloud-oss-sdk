import Foundation
import Tea
import TeaUtils
import AlibabaCloudOSSUtil
import DarabonbaXML
import TeaFileForm
import AlibabaCloudCredentials

open class Client {
    public var _endpoint: String?

    public var _regionId: String?

    public var _hostModel: String?

    public var _protocol: String?

    public var _readTimeout: Int?

    public var _connectTimeout: Int?

    public var _signatureVersion: String?

    public var _addtionalHeaders: [String]?

    public var _localAddr: String?

    public var _httpProxy: String?

    public var _httpsProxy: String?

    public var _noProxy: String?

    public var _userAgent: String?

    public var _socks5Proxy: String?

    public var _isEnableCrc: Bool?

    public var _isEnableMD5: Bool?

    public var _socks5NetWork: String?

    public var _maxIdleConns: Int?

    public var _credential: AlibabaCloudCredentials.Client?

    public init(_ config: Config) throws {
        if (TeaUtils.Client.isUnset(config)) {
            throw Tea.ReuqestError([
                "name": "ParameterMissing",
                "message": "'config' can not be unset"
            ])
        }
        if (TeaUtils.Client.empty(config.type)) {
            config.type = "access_key"
        }
        var credentialConfig: AlibabaCloudCredentials.Config = AlibabaCloudCredentials.Config([
            "accessKeyId": config.accessKeyId ?? "",
            "type": config.type ?? "",
            "accessKeySecret": config.accessKeySecret ?? "",
            "securityToken": config.securityToken ?? ""
        ])
        self._credential = AlibabaCloudCredentials.Client(credentialConfig)
        if (TeaUtils.Client.isUnset(config.isEnableMD5)) {
            config.isEnableMD5 = false
        }
        if (TeaUtils.Client.isUnset(config.isEnableCrc)) {
            config.isEnableCrc = false
        }
        self._endpoint = config.endpoint
        self._protocol = config.protocol_
        self._regionId = config.regionId
        self._userAgent = config.userAgent
        self._readTimeout = config.readTimeout
        self._connectTimeout = config.connectTimeout
        self._localAddr = config.localAddr
        self._httpProxy = config.httpProxy
        self._httpsProxy = config.httpsProxy
        self._noProxy = config.noProxy
        self._socks5Proxy = config.socks5Proxy
        self._socks5NetWork = config.socks5NetWork
        self._maxIdleConns = config.maxIdleConns
        self._signatureVersion = config.signatureVersion
        self._addtionalHeaders = config.addtionalHeaders
        self._hostModel = config.hostModel
        self._isEnableMD5 = config.isEnableMD5
        self._isEnableCrc = config.isEnableCrc
    }

    @available(macOS 10.15, iOS 13, tvOS 13, watchOS 6, *)
    public func postObject(_ request: PostObjectRequest, _ runtime: AlibabaCloudOSSUtil.RuntimeOptions) async throws -> PostObjectResponse {
        try request.validate()
        try runtime.validate()
        var _runtime: [String: Any] = [
            "timeouted": "retry",
            "readTimeout": TeaUtils.Client.defaultNumber(runtime.readTimeout, self._readTimeout),
            "connectTimeout": TeaUtils.Client.defaultNumber(runtime.connectTimeout, self._connectTimeout),
            "httpProxy": TeaUtils.Client.defaultString(runtime.httpProxy, self._httpProxy),
            "httpsProxy": TeaUtils.Client.defaultString(runtime.httpsProxy, self._httpsProxy),
            "noProxy": TeaUtils.Client.defaultString(runtime.noProxy, self._noProxy),
            "maxIdleConns": TeaUtils.Client.defaultNumber(runtime.maxIdleConns, self._maxIdleConns),
            "retry": [
                "retryable": runtime.autoretry!,
                "maxAttempts": TeaUtils.Client.defaultNumber(runtime.maxAttempts, 3)
            ],
            "backoff": [
                "policy": TeaUtils.Client.defaultString(runtime.backoffPolicy, "no"),
                "period": TeaUtils.Client.defaultNumber(runtime.backoffPeriod, 1)
            ],
            "ignoreSSL": Client.defaultAny(runtime.ignoreSSL, false)
        ]
        var _lastRequest: Tea.TeaRequest? = nil
        var _lastException: Tea.TeaError? = nil
        var _now: Int32 = Tea.TeaCore.timeNow()
        var _retryTimes: Int32 = 0
        while (Tea.TeaCore.allowRetry(_runtime["retry"], _retryTimes, _now)) {
            if (_retryTimes > 0) {
                var _backoffTime: Int32 = Tea.TeaCore.getBackoffTime(_runtime["backoff"], _retryTimes)
                if (_backoffTime > 0) {
                    Tea.TeaCore.sleep(_backoffTime)
                }
            }
            _retryTimes = _retryTimes + 1
            do {
                var _request: Tea.TeaRequest = Tea.TeaRequest()
                var boundary: String = TeaFileForm.Client.getBoundary()
                _request.protocol_ = self._protocol ?? ""
                _request.method = "POST"
                _request.pathname = "/"
                _request.headers = [
                    "host": AlibabaCloudOSSUtil.Client.getHost(request.bucketName, self._regionId, self._endpoint, self._hostModel),
                    "date": TeaUtils.Client.getDateUTCString(),
                    "user-agent": getUserAgent()
                ]
                _request.headers["content-type"] = "multipart/form-data; boundary=" + boundary;
                var form: [String: Any] = Tea.TeaConverter.merge([
                    "OSSAccessKeyId": request.header!.accessKeyId ?? "",
                    "policy": request.header!.policy ?? "",
                    "Signature": request.header!.signature ?? "",
                    "key": request.header!.key ?? "",
                    "success_action_status": request.header!.successActionStatus ?? "",
                    "file": request.header!.file!
                ], AlibabaCloudOSSUtil.Client.toMeta(request.header!.userMeta, "x-oss-meta-"))
                _request.body = TeaFileForm.Client.toFileForm(form, boundary)
                _lastRequest = _request
                var _response: Tea.TeaResponse = try await Tea.TeaCore.doAction(_request, _runtime)
                var respMap: [String: Any] = [:]
                var bodyStr: String = try await TeaUtils.Client.readAsString(_response.body)
                if (TeaUtils.Client.is4xx(_response.statusCode) || TeaUtils.Client.is5xx(_response.statusCode)) {
                    respMap = AlibabaCloudOSSUtil.Client.getErrMessage(bodyStr)
                    throw Tea.ReuqestError([
                        "code": respMap["Code"]!,
                        "message": respMap["Message"]!,
                        "data": [
                            "httpCode": _response.statusCode,
                            "requestId": respMap["RequestId"]!,
                            "hostId": respMap["HostId"]!
                        ]
                    ])
                }
                respMap = DarabonbaXML.Client.parseXml(bodyStr, PostObjectResponse())
                return Tea.TeaConverter.fromMap(PostObjectResponse(), respMap)
            }
            catch {
                if (Tea.TeaCore.isRetryable(error)) {
                    _lastException = error as! Tea.RetryableError
                    continue
                }
                throw error
            }
        }
        throw Tea.UnretryableError(_lastRequest, _lastException)
    }

    public func setUserAgent(_ userAgent: String) -> Void {
        self._userAgent = userAgent
    }

    public func appendUserAgent(_ userAgent: String) -> Void {
        self._userAgent = self._userAgent ?? "" + " " + userAgent
    }

    public func getUserAgent() -> String {
        var userAgent: String = TeaUtils.Client.getUserAgent(self._userAgent)
        return userAgent as! String
    }

    @available(macOS 10.15, iOS 13, tvOS 13, watchOS 6, *)
    public func getAccessKeyId() async throws -> String {
        if (TeaUtils.Client.isUnset(self._credential)) {
            return ""
        }
        var accessKeyId: String = try await self._credential!.getAccessKeyId()
        return accessKeyId as! String
    }

    @available(macOS 10.15, iOS 13, tvOS 13, watchOS 6, *)
    public func getAccessKeySecret() async throws -> String {
        if (TeaUtils.Client.isUnset(self._credential)) {
            return ""
        }
        var secret: String = try await self._credential!.getAccessKeySecret()
        return secret as! String
    }

    public static func defaultAny(_ inputValue: Any?, _ defaultValue: Any?) -> Any {
        if (TeaUtils.Client.isUnset(inputValue)) {
            return defaultValue as! Any
        }
        return inputValue as! Any
    }
}
