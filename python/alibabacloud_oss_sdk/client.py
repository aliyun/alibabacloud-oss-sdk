# This file is auto-generated, don't edit it. Thanks.
import time

from alibabacloud_credentials.client import Client as CredentialClient
from alibabacloud_oss_sdk import models as _oss_models
from alibabacloud_tea_util.client import Client as UtilClient
from Tea.exceptions import TeaException
from alibabacloud_credentials import models as credential_models
from alibabacloud_oss_util import models as ossutil_models
from Tea.request import TeaRequest
from Tea.core import TeaCore
from Tea.response import TeaResponse
from alibabacloud_tea_xml.client import Client as XMLClient
from alibabacloud_oss_util.client import Client as OSSUtilClient
from Tea.exceptions import UnretryableException
from alibabacloud_tea_fileform.client import Client as FileFormClient


class Client:
    def __init__(self, config, _endpoint=None, _region_id=None, _host_model=None, _protocol=None, _read_timeout=None, _connect_timeout=None, _signature_version=None, _addtional_headers=None, _local_addr=None, _http_proxy=None, _https_proxy=None, _no_proxy=None, _user_agent=None, _socks_5proxy=None, _is_enable_crc=None, _is_enable_md5=None, _socks_5net_work=None, _max_idle_conns=None, _credential=None):
        self._endpoint = _endpoint
        self._region_id = _region_id
        self._host_model = _host_model
        self._protocol = _protocol
        self._read_timeout = _read_timeout
        self._connect_timeout = _connect_timeout
        self._signature_version = _signature_version
        self._addtional_headers = []
        self._local_addr = _local_addr
        self._http_proxy = _http_proxy
        self._https_proxy = _https_proxy
        self._no_proxy = _no_proxy
        self._user_agent = _user_agent
        self._socks_5proxy = _socks_5proxy
        self._is_enable_crc = _is_enable_crc
        self._is_enable_md5 = _is_enable_md5
        self._socks_5net_work = _socks_5net_work
        self._max_idle_conns = _max_idle_conns
        self._credential = _credential
        if UtilClient.is_unset(config.to_map()):
            raise TeaException({
                "name": "ParameterMissing",
                "message": "'config' can not be unset"
            })
        if UtilClient.empty(config.type):
            config.type = "access_key"
        credential_config = credential_models.Config(
            access_key_id=config.access_key_id,
            type=config.type,
            access_key_secret=config.access_key_secret,
            security_token=config.security_token
        )
        self._credential = CredentialClient(credential_config)
        if UtilClient.is_unset(config.is_enable_md5):
            config.is_enable_md5 = False
        if UtilClient.is_unset(config.is_enable_crc):
            config.is_enable_crc = False
        self._endpoint = config.endpoint
        self._protocol = config.protocol
        self._region_id = config.region_id
        self._user_agent = config.user_agent
        self._read_timeout = config.read_timeout
        self._connect_timeout = config.connect_timeout
        self._local_addr = config.local_addr
        self._http_proxy = config.http_proxy
        self._https_proxy = config.https_proxy
        self._no_proxy = config.no_proxy
        self._socks_5proxy = config.socks_5proxy
        self._socks_5net_work = config.socks_5net_work
        self._max_idle_conns = config.max_idle_conns
        self._signature_version = config.signature_version
        self._addtional_headers = config.addtional_headers
        self._host_model = config.host_model
        self._is_enable_md5 = config.is_enable_md5
        self._is_enable_crc = config.is_enable_crc

    def put_bucket_lifecycle(self, request, runtime):
        request.validate()
        runtime.validate()
        _runtime = {
            "timeouted": "retry",
            "readTimeout": UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            "connectTimeout": UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            "localAddr": UtilClient.default_string(runtime.local_addr, self._local_addr),
            "httpProxy": UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            "httpsProxy": UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            "noProxy": UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            "socks5Proxy": UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            "socks5NetWork": UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            "maxIdleConns": UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            "retry": {
                "retryable": runtime.autoretry,
                "maxAttempts": UtilClient.default_number(runtime.max_attempts, 3)
            },
            "backoff": {
                "policy": UtilClient.default_string(runtime.backoff_policy, "no"),
                "period": UtilClient.default_number(runtime.backoff_period, 1)
            },
            "ignoreSSL": runtime.ignore_ssl
        }
        _last_request = None
        _last_exception = None
        _now = time.time()
        _retry_times = 0
        while TeaCore.allow_retry(_runtime.get('retry'), _retry_times, _now):
            if _retry_times > 0:
                _backoff_time = TeaCore.get_backoff_time(_runtime.get('backoff'), _retry_times)
                if _backoff_time > 0:
                    TeaCore.sleep(_backoff_time)
            _retry_times = _retry_times + 1
            try:
                _request = TeaRequest()
                access_key_id = self._credential.get_access_key_id()
                access_key_secret = self._credential.get_access_key_secret()
                token = self._credential.get_security_token()
                req_body = XMLClient.to_xml(request.body.to_map())
                _request.protocol = self._protocol
                _request.method = "PUT"
                _request.pathname = "/?lifecycle"
                _request.headers = {
                    "host": OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    "date": UtilClient.get_date_utcstring(),
                    "user-agent": self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers["x-oss-security-token"] = token
                _request.body = req_body
                _request.headers["authorization"] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = UtilClient.read_as_string(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        "code": resp_map.get('Code'),
                        "message": resp_map.get('Message'),
                        "data": {
                            "httpCode": _response.status_code,
                            "requestId": resp_map.get('RequestId'),
                            "hostId": resp_map.get('HostId')
                        }
                    })
                return _oss_models.PutBucketLifecycleResponse().from_map(TeaCore.merge(_response.headers))

            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def delete_multiple_objects(self, request, runtime):
        request.validate()
        runtime.validate()
        _runtime = {
            "timeouted": "retry",
            "readTimeout": UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            "connectTimeout": UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            "localAddr": UtilClient.default_string(runtime.local_addr, self._local_addr),
            "httpProxy": UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            "httpsProxy": UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            "noProxy": UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            "socks5Proxy": UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            "socks5NetWork": UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            "maxIdleConns": UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            "retry": {
                "retryable": runtime.autoretry,
                "maxAttempts": UtilClient.default_number(runtime.max_attempts, 3)
            },
            "backoff": {
                "policy": UtilClient.default_string(runtime.backoff_policy, "no"),
                "period": UtilClient.default_number(runtime.backoff_period, 1)
            },
            "ignoreSSL": runtime.ignore_ssl
        }
        _last_request = None
        _last_exception = None
        _now = time.time()
        _retry_times = 0
        while TeaCore.allow_retry(_runtime.get('retry'), _retry_times, _now):
            if _retry_times > 0:
                _backoff_time = TeaCore.get_backoff_time(_runtime.get('backoff'), _retry_times)
                if _backoff_time > 0:
                    TeaCore.sleep(_backoff_time)
            _retry_times = _retry_times + 1
            try:
                _request = TeaRequest()
                access_key_id = self._credential.get_access_key_id()
                access_key_secret = self._credential.get_access_key_secret()
                token = self._credential.get_security_token()
                req_body = XMLClient.to_xml(request.body.to_map())
                _request.protocol = self._protocol
                _request.method = "POST"
                _request.pathname = "/?delete"
                _request.headers = TeaCore.merge({
                    "host": OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    "date": UtilClient.get_date_utcstring(),
                    "user-agent": self.get_user_agent()
                }, UtilClient.stringify_map_value(request.header.to_map()))
                if not UtilClient.empty(token):
                    _request.headers["x-oss-security-token"] = token
                _request.body = req_body
                if not UtilClient.is_unset(request.header.to_map()) and not UtilClient.empty(request.header.content_md5):
                    _request.headers["content-md5"] = request.header.content_md5
                else:
                    _request.headers["content-md5"] = OSSUtilClient.get_content_md5(req_body, self._is_enable_md5)
                _request.headers["authorization"] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = UtilClient.read_as_string(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        "code": resp_map.get('Code'),
                        "message": resp_map.get('Message'),
                        "data": {
                            "httpCode": _response.status_code,
                            "requestId": resp_map.get('RequestId'),
                            "hostId": resp_map.get('HostId')
                        }
                    })
                body_str = UtilClient.read_as_string(_response.body)
                resp_map = XMLClient.parse_xml(body_str, _oss_models.DeleteMultipleObjectsResponse())
                return _oss_models.DeleteMultipleObjectsResponse().from_map(TeaCore.merge({
                    "DeleteResult": resp_map.get('DeleteResult')
                }, _response.headers))

            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def put_bucket_referer(self, request, runtime):
        request.validate()
        runtime.validate()
        _runtime = {
            "timeouted": "retry",
            "readTimeout": UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            "connectTimeout": UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            "localAddr": UtilClient.default_string(runtime.local_addr, self._local_addr),
            "httpProxy": UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            "httpsProxy": UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            "noProxy": UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            "socks5Proxy": UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            "socks5NetWork": UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            "maxIdleConns": UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            "retry": {
                "retryable": runtime.autoretry,
                "maxAttempts": UtilClient.default_number(runtime.max_attempts, 3)
            },
            "backoff": {
                "policy": UtilClient.default_string(runtime.backoff_policy, "no"),
                "period": UtilClient.default_number(runtime.backoff_period, 1)
            },
            "ignoreSSL": runtime.ignore_ssl
        }
        _last_request = None
        _last_exception = None
        _now = time.time()
        _retry_times = 0
        while TeaCore.allow_retry(_runtime.get('retry'), _retry_times, _now):
            if _retry_times > 0:
                _backoff_time = TeaCore.get_backoff_time(_runtime.get('backoff'), _retry_times)
                if _backoff_time > 0:
                    TeaCore.sleep(_backoff_time)
            _retry_times = _retry_times + 1
            try:
                _request = TeaRequest()
                access_key_id = self._credential.get_access_key_id()
                access_key_secret = self._credential.get_access_key_secret()
                token = self._credential.get_security_token()
                req_body = XMLClient.to_xml(request.body.to_map())
                _request.protocol = self._protocol
                _request.method = "PUT"
                _request.pathname = "/?referer"
                _request.headers = {
                    "host": OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    "date": UtilClient.get_date_utcstring(),
                    "user-agent": self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers["x-oss-security-token"] = token
                _request.body = req_body
                _request.headers["authorization"] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = UtilClient.read_as_string(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        "code": resp_map.get('Code'),
                        "message": resp_map.get('Message'),
                        "data": {
                            "httpCode": _response.status_code,
                            "requestId": resp_map.get('RequestId'),
                            "hostId": resp_map.get('HostId')
                        }
                    })
                return _oss_models.PutBucketRefererResponse().from_map(TeaCore.merge(_response.headers))

            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def put_bucket_website(self, request, runtime):
        request.validate()
        runtime.validate()
        _runtime = {
            "timeouted": "retry",
            "readTimeout": UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            "connectTimeout": UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            "localAddr": UtilClient.default_string(runtime.local_addr, self._local_addr),
            "httpProxy": UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            "httpsProxy": UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            "noProxy": UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            "socks5Proxy": UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            "socks5NetWork": UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            "maxIdleConns": UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            "retry": {
                "retryable": runtime.autoretry,
                "maxAttempts": UtilClient.default_number(runtime.max_attempts, 3)
            },
            "backoff": {
                "policy": UtilClient.default_string(runtime.backoff_policy, "no"),
                "period": UtilClient.default_number(runtime.backoff_period, 1)
            },
            "ignoreSSL": runtime.ignore_ssl
        }
        _last_request = None
        _last_exception = None
        _now = time.time()
        _retry_times = 0
        while TeaCore.allow_retry(_runtime.get('retry'), _retry_times, _now):
            if _retry_times > 0:
                _backoff_time = TeaCore.get_backoff_time(_runtime.get('backoff'), _retry_times)
                if _backoff_time > 0:
                    TeaCore.sleep(_backoff_time)
            _retry_times = _retry_times + 1
            try:
                _request = TeaRequest()
                access_key_id = self._credential.get_access_key_id()
                access_key_secret = self._credential.get_access_key_secret()
                token = self._credential.get_security_token()
                req_body = XMLClient.to_xml(request.body.to_map())
                _request.protocol = self._protocol
                _request.method = "PUT"
                _request.pathname = "/?website"
                _request.headers = {
                    "host": OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    "date": UtilClient.get_date_utcstring(),
                    "user-agent": self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers["x-oss-security-token"] = token
                _request.body = req_body
                _request.headers["authorization"] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = UtilClient.read_as_string(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        "code": resp_map.get('Code'),
                        "message": resp_map.get('Message'),
                        "data": {
                            "httpCode": _response.status_code,
                            "requestId": resp_map.get('RequestId'),
                            "hostId": resp_map.get('HostId')
                        }
                    })
                return _oss_models.PutBucketWebsiteResponse().from_map(TeaCore.merge(_response.headers))

            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def complete_multipart_upload(self, request, runtime):
        request.validate()
        runtime.validate()
        _runtime = {
            "timeouted": "retry",
            "readTimeout": UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            "connectTimeout": UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            "localAddr": UtilClient.default_string(runtime.local_addr, self._local_addr),
            "httpProxy": UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            "httpsProxy": UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            "noProxy": UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            "socks5Proxy": UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            "socks5NetWork": UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            "maxIdleConns": UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            "retry": {
                "retryable": runtime.autoretry,
                "maxAttempts": UtilClient.default_number(runtime.max_attempts, 3)
            },
            "backoff": {
                "policy": UtilClient.default_string(runtime.backoff_policy, "no"),
                "period": UtilClient.default_number(runtime.backoff_period, 1)
            },
            "ignoreSSL": runtime.ignore_ssl
        }
        _last_request = None
        _last_exception = None
        _now = time.time()
        _retry_times = 0
        while TeaCore.allow_retry(_runtime.get('retry'), _retry_times, _now):
            if _retry_times > 0:
                _backoff_time = TeaCore.get_backoff_time(_runtime.get('backoff'), _retry_times)
                if _backoff_time > 0:
                    TeaCore.sleep(_backoff_time)
            _retry_times = _retry_times + 1
            try:
                _request = TeaRequest()
                access_key_id = self._credential.get_access_key_id()
                access_key_secret = self._credential.get_access_key_secret()
                token = self._credential.get_security_token()
                req_body = XMLClient.to_xml(request.body.to_map())
                _request.protocol = self._protocol
                _request.method = "POST"
                _request.pathname = "/" + request.object_name + ""
                _request.headers = {
                    "host": OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    "date": UtilClient.get_date_utcstring(),
                    "user-agent": self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers["x-oss-security-token"] = token
                _request.query = UtilClient.stringify_map_value(request.filter.to_map())
                _request.body = req_body
                _request.headers["authorization"] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = UtilClient.read_as_string(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        "code": resp_map.get('Code'),
                        "message": resp_map.get('Message'),
                        "data": {
                            "httpCode": _response.status_code,
                            "requestId": resp_map.get('RequestId'),
                            "hostId": resp_map.get('HostId')
                        }
                    })
                body_str = UtilClient.read_as_string(_response.body)
                resp_map = XMLClient.parse_xml(body_str, _oss_models.CompleteMultipartUploadResponse())
                return _oss_models.CompleteMultipartUploadResponse().from_map(TeaCore.merge({
                    "CompleteMultipartUploadResult": resp_map.get('CompleteMultipartUploadResult')
                }, _response.headers))

            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def put_bucket_logging(self, request, runtime):
        request.validate()
        runtime.validate()
        _runtime = {
            "timeouted": "retry",
            "readTimeout": UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            "connectTimeout": UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            "localAddr": UtilClient.default_string(runtime.local_addr, self._local_addr),
            "httpProxy": UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            "httpsProxy": UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            "noProxy": UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            "socks5Proxy": UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            "socks5NetWork": UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            "maxIdleConns": UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            "retry": {
                "retryable": runtime.autoretry,
                "maxAttempts": UtilClient.default_number(runtime.max_attempts, 3)
            },
            "backoff": {
                "policy": UtilClient.default_string(runtime.backoff_policy, "no"),
                "period": UtilClient.default_number(runtime.backoff_period, 1)
            },
            "ignoreSSL": runtime.ignore_ssl
        }
        _last_request = None
        _last_exception = None
        _now = time.time()
        _retry_times = 0
        while TeaCore.allow_retry(_runtime.get('retry'), _retry_times, _now):
            if _retry_times > 0:
                _backoff_time = TeaCore.get_backoff_time(_runtime.get('backoff'), _retry_times)
                if _backoff_time > 0:
                    TeaCore.sleep(_backoff_time)
            _retry_times = _retry_times + 1
            try:
                _request = TeaRequest()
                access_key_id = self._credential.get_access_key_id()
                access_key_secret = self._credential.get_access_key_secret()
                token = self._credential.get_security_token()
                req_body = XMLClient.to_xml(request.body.to_map())
                _request.protocol = self._protocol
                _request.method = "PUT"
                _request.pathname = "/?logging"
                _request.headers = {
                    "host": OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    "date": UtilClient.get_date_utcstring(),
                    "user-agent": self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers["x-oss-security-token"] = token
                _request.body = req_body
                _request.headers["authorization"] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = UtilClient.read_as_string(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        "code": resp_map.get('Code'),
                        "message": resp_map.get('Message'),
                        "data": {
                            "httpCode": _response.status_code,
                            "requestId": resp_map.get('RequestId'),
                            "hostId": resp_map.get('HostId')
                        }
                    })
                return _oss_models.PutBucketLoggingResponse().from_map(TeaCore.merge(_response.headers))

            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def put_bucket_request_payment(self, request, runtime):
        request.validate()
        runtime.validate()
        _runtime = {
            "timeouted": "retry",
            "readTimeout": UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            "connectTimeout": UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            "localAddr": UtilClient.default_string(runtime.local_addr, self._local_addr),
            "httpProxy": UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            "httpsProxy": UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            "noProxy": UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            "socks5Proxy": UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            "socks5NetWork": UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            "maxIdleConns": UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            "retry": {
                "retryable": runtime.autoretry,
                "maxAttempts": UtilClient.default_number(runtime.max_attempts, 3)
            },
            "backoff": {
                "policy": UtilClient.default_string(runtime.backoff_policy, "no"),
                "period": UtilClient.default_number(runtime.backoff_period, 1)
            },
            "ignoreSSL": runtime.ignore_ssl
        }
        _last_request = None
        _last_exception = None
        _now = time.time()
        _retry_times = 0
        while TeaCore.allow_retry(_runtime.get('retry'), _retry_times, _now):
            if _retry_times > 0:
                _backoff_time = TeaCore.get_backoff_time(_runtime.get('backoff'), _retry_times)
                if _backoff_time > 0:
                    TeaCore.sleep(_backoff_time)
            _retry_times = _retry_times + 1
            try:
                _request = TeaRequest()
                access_key_id = self._credential.get_access_key_id()
                access_key_secret = self._credential.get_access_key_secret()
                token = self._credential.get_security_token()
                req_body = XMLClient.to_xml(request.body.to_map())
                _request.protocol = self._protocol
                _request.method = "PUT"
                _request.pathname = "/?requestPayment"
                _request.headers = {
                    "host": OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    "date": UtilClient.get_date_utcstring(),
                    "user-agent": self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers["x-oss-security-token"] = token
                _request.body = req_body
                _request.headers["authorization"] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = UtilClient.read_as_string(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        "code": resp_map.get('Code'),
                        "message": resp_map.get('Message'),
                        "data": {
                            "httpCode": _response.status_code,
                            "requestId": resp_map.get('RequestId'),
                            "hostId": resp_map.get('HostId')
                        }
                    })
                return _oss_models.PutBucketRequestPaymentResponse().from_map(TeaCore.merge(_response.headers))

            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def put_bucket_encryption(self, request, runtime):
        request.validate()
        runtime.validate()
        _runtime = {
            "timeouted": "retry",
            "readTimeout": UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            "connectTimeout": UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            "localAddr": UtilClient.default_string(runtime.local_addr, self._local_addr),
            "httpProxy": UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            "httpsProxy": UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            "noProxy": UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            "socks5Proxy": UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            "socks5NetWork": UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            "maxIdleConns": UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            "retry": {
                "retryable": runtime.autoretry,
                "maxAttempts": UtilClient.default_number(runtime.max_attempts, 3)
            },
            "backoff": {
                "policy": UtilClient.default_string(runtime.backoff_policy, "no"),
                "period": UtilClient.default_number(runtime.backoff_period, 1)
            },
            "ignoreSSL": runtime.ignore_ssl
        }
        _last_request = None
        _last_exception = None
        _now = time.time()
        _retry_times = 0
        while TeaCore.allow_retry(_runtime.get('retry'), _retry_times, _now):
            if _retry_times > 0:
                _backoff_time = TeaCore.get_backoff_time(_runtime.get('backoff'), _retry_times)
                if _backoff_time > 0:
                    TeaCore.sleep(_backoff_time)
            _retry_times = _retry_times + 1
            try:
                _request = TeaRequest()
                access_key_id = self._credential.get_access_key_id()
                access_key_secret = self._credential.get_access_key_secret()
                token = self._credential.get_security_token()
                req_body = XMLClient.to_xml(request.body.to_map())
                _request.protocol = self._protocol
                _request.method = "PUT"
                _request.pathname = "/?encryption"
                _request.headers = {
                    "host": OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    "date": UtilClient.get_date_utcstring(),
                    "user-agent": self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers["x-oss-security-token"] = token
                _request.body = req_body
                _request.headers["authorization"] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = UtilClient.read_as_string(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        "code": resp_map.get('Code'),
                        "message": resp_map.get('Message'),
                        "data": {
                            "httpCode": _response.status_code,
                            "requestId": resp_map.get('RequestId'),
                            "hostId": resp_map.get('HostId')
                        }
                    })
                return _oss_models.PutBucketEncryptionResponse().from_map(TeaCore.merge(_response.headers))

            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def put_live_channel(self, request, runtime):
        request.validate()
        runtime.validate()
        _runtime = {
            "timeouted": "retry",
            "readTimeout": UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            "connectTimeout": UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            "localAddr": UtilClient.default_string(runtime.local_addr, self._local_addr),
            "httpProxy": UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            "httpsProxy": UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            "noProxy": UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            "socks5Proxy": UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            "socks5NetWork": UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            "maxIdleConns": UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            "retry": {
                "retryable": runtime.autoretry,
                "maxAttempts": UtilClient.default_number(runtime.max_attempts, 3)
            },
            "backoff": {
                "policy": UtilClient.default_string(runtime.backoff_policy, "no"),
                "period": UtilClient.default_number(runtime.backoff_period, 1)
            },
            "ignoreSSL": runtime.ignore_ssl
        }
        _last_request = None
        _last_exception = None
        _now = time.time()
        _retry_times = 0
        while TeaCore.allow_retry(_runtime.get('retry'), _retry_times, _now):
            if _retry_times > 0:
                _backoff_time = TeaCore.get_backoff_time(_runtime.get('backoff'), _retry_times)
                if _backoff_time > 0:
                    TeaCore.sleep(_backoff_time)
            _retry_times = _retry_times + 1
            try:
                _request = TeaRequest()
                access_key_id = self._credential.get_access_key_id()
                access_key_secret = self._credential.get_access_key_secret()
                token = self._credential.get_security_token()
                req_body = XMLClient.to_xml(request.body.to_map())
                _request.protocol = self._protocol
                _request.method = "PUT"
                _request.pathname = "/" + request.channel_name + "?live"
                _request.headers = {
                    "host": OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    "date": UtilClient.get_date_utcstring(),
                    "user-agent": self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers["x-oss-security-token"] = token
                _request.body = req_body
                _request.headers["authorization"] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = UtilClient.read_as_string(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        "code": resp_map.get('Code'),
                        "message": resp_map.get('Message'),
                        "data": {
                            "httpCode": _response.status_code,
                            "requestId": resp_map.get('RequestId'),
                            "hostId": resp_map.get('HostId')
                        }
                    })
                body_str = UtilClient.read_as_string(_response.body)
                resp_map = XMLClient.parse_xml(body_str, _oss_models.PutLiveChannelResponse())
                return _oss_models.PutLiveChannelResponse().from_map(TeaCore.merge({
                    "CreateLiveChannelResult": resp_map.get('CreateLiveChannelResult')
                }, _response.headers))

            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def put_bucket_tags(self, request, runtime):
        request.validate()
        runtime.validate()
        _runtime = {
            "timeouted": "retry",
            "readTimeout": UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            "connectTimeout": UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            "localAddr": UtilClient.default_string(runtime.local_addr, self._local_addr),
            "httpProxy": UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            "httpsProxy": UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            "noProxy": UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            "socks5Proxy": UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            "socks5NetWork": UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            "maxIdleConns": UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            "retry": {
                "retryable": runtime.autoretry,
                "maxAttempts": UtilClient.default_number(runtime.max_attempts, 3)
            },
            "backoff": {
                "policy": UtilClient.default_string(runtime.backoff_policy, "no"),
                "period": UtilClient.default_number(runtime.backoff_period, 1)
            },
            "ignoreSSL": runtime.ignore_ssl
        }
        _last_request = None
        _last_exception = None
        _now = time.time()
        _retry_times = 0
        while TeaCore.allow_retry(_runtime.get('retry'), _retry_times, _now):
            if _retry_times > 0:
                _backoff_time = TeaCore.get_backoff_time(_runtime.get('backoff'), _retry_times)
                if _backoff_time > 0:
                    TeaCore.sleep(_backoff_time)
            _retry_times = _retry_times + 1
            try:
                _request = TeaRequest()
                access_key_id = self._credential.get_access_key_id()
                access_key_secret = self._credential.get_access_key_secret()
                token = self._credential.get_security_token()
                req_body = XMLClient.to_xml(request.body.to_map())
                _request.protocol = self._protocol
                _request.method = "PUT"
                _request.pathname = "/?tagging"
                _request.headers = {
                    "host": OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    "date": UtilClient.get_date_utcstring(),
                    "user-agent": self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers["x-oss-security-token"] = token
                _request.body = req_body
                _request.headers["authorization"] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = UtilClient.read_as_string(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        "code": resp_map.get('Code'),
                        "message": resp_map.get('Message'),
                        "data": {
                            "httpCode": _response.status_code,
                            "requestId": resp_map.get('RequestId'),
                            "hostId": resp_map.get('HostId')
                        }
                    })
                return _oss_models.PutBucketTagsResponse().from_map(TeaCore.merge(_response.headers))

            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def put_object_tagging(self, request, runtime):
        request.validate()
        runtime.validate()
        _runtime = {
            "timeouted": "retry",
            "readTimeout": UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            "connectTimeout": UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            "localAddr": UtilClient.default_string(runtime.local_addr, self._local_addr),
            "httpProxy": UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            "httpsProxy": UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            "noProxy": UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            "socks5Proxy": UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            "socks5NetWork": UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            "maxIdleConns": UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            "retry": {
                "retryable": runtime.autoretry,
                "maxAttempts": UtilClient.default_number(runtime.max_attempts, 3)
            },
            "backoff": {
                "policy": UtilClient.default_string(runtime.backoff_policy, "no"),
                "period": UtilClient.default_number(runtime.backoff_period, 1)
            },
            "ignoreSSL": runtime.ignore_ssl
        }
        _last_request = None
        _last_exception = None
        _now = time.time()
        _retry_times = 0
        while TeaCore.allow_retry(_runtime.get('retry'), _retry_times, _now):
            if _retry_times > 0:
                _backoff_time = TeaCore.get_backoff_time(_runtime.get('backoff'), _retry_times)
                if _backoff_time > 0:
                    TeaCore.sleep(_backoff_time)
            _retry_times = _retry_times + 1
            try:
                _request = TeaRequest()
                access_key_id = self._credential.get_access_key_id()
                access_key_secret = self._credential.get_access_key_secret()
                token = self._credential.get_security_token()
                req_body = XMLClient.to_xml(request.body.to_map())
                _request.protocol = self._protocol
                _request.method = "PUT"
                _request.pathname = "/" + request.object_name + "?tagging"
                _request.headers = {
                    "host": OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    "date": UtilClient.get_date_utcstring(),
                    "user-agent": self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers["x-oss-security-token"] = token
                _request.body = req_body
                _request.headers["authorization"] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = UtilClient.read_as_string(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        "code": resp_map.get('Code'),
                        "message": resp_map.get('Message'),
                        "data": {
                            "httpCode": _response.status_code,
                            "requestId": resp_map.get('RequestId'),
                            "hostId": resp_map.get('HostId')
                        }
                    })
                return _oss_models.PutObjectTaggingResponse().from_map(TeaCore.merge(_response.headers))

            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def select_object(self, request, runtime):
        request.validate()
        runtime.validate()
        _runtime = {
            "timeouted": "retry",
            "readTimeout": UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            "connectTimeout": UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            "localAddr": UtilClient.default_string(runtime.local_addr, self._local_addr),
            "httpProxy": UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            "httpsProxy": UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            "noProxy": UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            "socks5Proxy": UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            "socks5NetWork": UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            "maxIdleConns": UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            "retry": {
                "retryable": runtime.autoretry,
                "maxAttempts": UtilClient.default_number(runtime.max_attempts, 3)
            },
            "backoff": {
                "policy": UtilClient.default_string(runtime.backoff_policy, "no"),
                "period": UtilClient.default_number(runtime.backoff_period, 1)
            },
            "ignoreSSL": runtime.ignore_ssl
        }
        _last_request = None
        _last_exception = None
        _now = time.time()
        _retry_times = 0
        while TeaCore.allow_retry(_runtime.get('retry'), _retry_times, _now):
            if _retry_times > 0:
                _backoff_time = TeaCore.get_backoff_time(_runtime.get('backoff'), _retry_times)
                if _backoff_time > 0:
                    TeaCore.sleep(_backoff_time)
            _retry_times = _retry_times + 1
            try:
                _request = TeaRequest()
                access_key_id = self._credential.get_access_key_id()
                access_key_secret = self._credential.get_access_key_secret()
                token = self._credential.get_security_token()
                req_body = XMLClient.to_xml(request.body.to_map())
                _request.protocol = self._protocol
                _request.method = "POST"
                _request.pathname = "/" + request.object_name + ""
                _request.headers = {
                    "host": OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    "date": UtilClient.get_date_utcstring(),
                    "user-agent": self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers["x-oss-security-token"] = token
                _request.query = UtilClient.stringify_map_value(request.filter.to_map())
                _request.body = req_body
                _request.headers["authorization"] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = UtilClient.read_as_string(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        "code": resp_map.get('Code'),
                        "message": resp_map.get('Message'),
                        "data": {
                            "httpCode": _response.status_code,
                            "requestId": resp_map.get('RequestId'),
                            "hostId": resp_map.get('HostId')
                        }
                    })
                return _oss_models.SelectObjectResponse().from_map(TeaCore.merge(_response.headers))

            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def put_bucket_cors(self, request, runtime):
        request.validate()
        runtime.validate()
        _runtime = {
            "timeouted": "retry",
            "readTimeout": UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            "connectTimeout": UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            "localAddr": UtilClient.default_string(runtime.local_addr, self._local_addr),
            "httpProxy": UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            "httpsProxy": UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            "noProxy": UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            "socks5Proxy": UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            "socks5NetWork": UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            "maxIdleConns": UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            "retry": {
                "retryable": runtime.autoretry,
                "maxAttempts": UtilClient.default_number(runtime.max_attempts, 3)
            },
            "backoff": {
                "policy": UtilClient.default_string(runtime.backoff_policy, "no"),
                "period": UtilClient.default_number(runtime.backoff_period, 1)
            },
            "ignoreSSL": runtime.ignore_ssl
        }
        _last_request = None
        _last_exception = None
        _now = time.time()
        _retry_times = 0
        while TeaCore.allow_retry(_runtime.get('retry'), _retry_times, _now):
            if _retry_times > 0:
                _backoff_time = TeaCore.get_backoff_time(_runtime.get('backoff'), _retry_times)
                if _backoff_time > 0:
                    TeaCore.sleep(_backoff_time)
            _retry_times = _retry_times + 1
            try:
                _request = TeaRequest()
                access_key_id = self._credential.get_access_key_id()
                access_key_secret = self._credential.get_access_key_secret()
                token = self._credential.get_security_token()
                req_body = XMLClient.to_xml(request.body.to_map())
                _request.protocol = self._protocol
                _request.method = "PUT"
                _request.pathname = "/?cors"
                _request.headers = {
                    "host": OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    "date": UtilClient.get_date_utcstring(),
                    "user-agent": self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers["x-oss-security-token"] = token
                _request.body = req_body
                _request.headers["authorization"] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = UtilClient.read_as_string(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        "code": resp_map.get('Code'),
                        "message": resp_map.get('Message'),
                        "data": {
                            "httpCode": _response.status_code,
                            "requestId": resp_map.get('RequestId'),
                            "hostId": resp_map.get('HostId')
                        }
                    })
                return _oss_models.PutBucketCORSResponse().from_map(TeaCore.merge(_response.headers))

            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def put_bucket(self, request, runtime):
        request.validate()
        runtime.validate()
        _runtime = {
            "timeouted": "retry",
            "readTimeout": UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            "connectTimeout": UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            "localAddr": UtilClient.default_string(runtime.local_addr, self._local_addr),
            "httpProxy": UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            "httpsProxy": UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            "noProxy": UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            "socks5Proxy": UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            "socks5NetWork": UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            "maxIdleConns": UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            "retry": {
                "retryable": runtime.autoretry,
                "maxAttempts": UtilClient.default_number(runtime.max_attempts, 3)
            },
            "backoff": {
                "policy": UtilClient.default_string(runtime.backoff_policy, "no"),
                "period": UtilClient.default_number(runtime.backoff_period, 1)
            },
            "ignoreSSL": runtime.ignore_ssl
        }
        _last_request = None
        _last_exception = None
        _now = time.time()
        _retry_times = 0
        while TeaCore.allow_retry(_runtime.get('retry'), _retry_times, _now):
            if _retry_times > 0:
                _backoff_time = TeaCore.get_backoff_time(_runtime.get('backoff'), _retry_times)
                if _backoff_time > 0:
                    TeaCore.sleep(_backoff_time)
            _retry_times = _retry_times + 1
            try:
                _request = TeaRequest()
                access_key_id = self._credential.get_access_key_id()
                access_key_secret = self._credential.get_access_key_secret()
                token = self._credential.get_security_token()
                req_body = XMLClient.to_xml(request.body.to_map())
                _request.protocol = self._protocol
                _request.method = "PUT"
                _request.pathname = "/"
                _request.headers = TeaCore.merge({
                    "host": OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    "date": UtilClient.get_date_utcstring(),
                    "user-agent": self.get_user_agent()
                }, UtilClient.stringify_map_value(request.header.to_map()))
                if not UtilClient.empty(token):
                    _request.headers["x-oss-security-token"] = token
                _request.body = req_body
                _request.headers["authorization"] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = UtilClient.read_as_string(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        "code": resp_map.get('Code'),
                        "message": resp_map.get('Message'),
                        "data": {
                            "httpCode": _response.status_code,
                            "requestId": resp_map.get('RequestId'),
                            "hostId": resp_map.get('HostId')
                        }
                    })
                return _oss_models.PutBucketResponse().from_map(TeaCore.merge(_response.headers))

            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def list_multipart_uploads(self, request, runtime):
        request.validate()
        runtime.validate()
        _runtime = {
            "timeouted": "retry",
            "readTimeout": UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            "connectTimeout": UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            "localAddr": UtilClient.default_string(runtime.local_addr, self._local_addr),
            "httpProxy": UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            "httpsProxy": UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            "noProxy": UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            "socks5Proxy": UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            "socks5NetWork": UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            "maxIdleConns": UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            "retry": {
                "retryable": runtime.autoretry,
                "maxAttempts": UtilClient.default_number(runtime.max_attempts, 3)
            },
            "backoff": {
                "policy": UtilClient.default_string(runtime.backoff_policy, "no"),
                "period": UtilClient.default_number(runtime.backoff_period, 1)
            },
            "ignoreSSL": runtime.ignore_ssl
        }
        _last_request = None
        _last_exception = None
        _now = time.time()
        _retry_times = 0
        while TeaCore.allow_retry(_runtime.get('retry'), _retry_times, _now):
            if _retry_times > 0:
                _backoff_time = TeaCore.get_backoff_time(_runtime.get('backoff'), _retry_times)
                if _backoff_time > 0:
                    TeaCore.sleep(_backoff_time)
            _retry_times = _retry_times + 1
            try:
                _request = TeaRequest()
                access_key_id = self._credential.get_access_key_id()
                access_key_secret = self._credential.get_access_key_secret()
                token = self._credential.get_security_token()
                _request.protocol = self._protocol
                _request.method = "GET"
                _request.pathname = "/?uploads"
                _request.headers = {
                    "host": OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    "date": UtilClient.get_date_utcstring(),
                    "user-agent": self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers["x-oss-security-token"] = token
                _request.query = UtilClient.stringify_map_value(request.filter.to_map())
                _request.headers["authorization"] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = UtilClient.read_as_string(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        "code": resp_map.get('Code'),
                        "message": resp_map.get('Message'),
                        "data": {
                            "httpCode": _response.status_code,
                            "requestId": resp_map.get('RequestId'),
                            "hostId": resp_map.get('HostId')
                        }
                    })
                body_str = UtilClient.read_as_string(_response.body)
                resp_map = XMLClient.parse_xml(body_str, _oss_models.ListMultipartUploadsResponse())
                return _oss_models.ListMultipartUploadsResponse().from_map(TeaCore.merge({
                    "ListMultipartUploadsResult": resp_map.get('ListMultipartUploadsResult')
                }, _response.headers))

            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def get_bucket_request_payment(self, request, runtime):
        request.validate()
        runtime.validate()
        _runtime = {
            "timeouted": "retry",
            "readTimeout": UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            "connectTimeout": UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            "localAddr": UtilClient.default_string(runtime.local_addr, self._local_addr),
            "httpProxy": UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            "httpsProxy": UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            "noProxy": UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            "socks5Proxy": UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            "socks5NetWork": UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            "maxIdleConns": UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            "retry": {
                "retryable": runtime.autoretry,
                "maxAttempts": UtilClient.default_number(runtime.max_attempts, 3)
            },
            "backoff": {
                "policy": UtilClient.default_string(runtime.backoff_policy, "no"),
                "period": UtilClient.default_number(runtime.backoff_period, 1)
            },
            "ignoreSSL": runtime.ignore_ssl
        }
        _last_request = None
        _last_exception = None
        _now = time.time()
        _retry_times = 0
        while TeaCore.allow_retry(_runtime.get('retry'), _retry_times, _now):
            if _retry_times > 0:
                _backoff_time = TeaCore.get_backoff_time(_runtime.get('backoff'), _retry_times)
                if _backoff_time > 0:
                    TeaCore.sleep(_backoff_time)
            _retry_times = _retry_times + 1
            try:
                _request = TeaRequest()
                access_key_id = self._credential.get_access_key_id()
                access_key_secret = self._credential.get_access_key_secret()
                token = self._credential.get_security_token()
                _request.protocol = self._protocol
                _request.method = "GET"
                _request.pathname = "/?requestPayment"
                _request.headers = {
                    "host": OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    "date": UtilClient.get_date_utcstring(),
                    "user-agent": self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers["x-oss-security-token"] = token
                _request.headers["authorization"] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = UtilClient.read_as_string(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        "code": resp_map.get('Code'),
                        "message": resp_map.get('Message'),
                        "data": {
                            "httpCode": _response.status_code,
                            "requestId": resp_map.get('RequestId'),
                            "hostId": resp_map.get('HostId')
                        }
                    })
                body_str = UtilClient.read_as_string(_response.body)
                resp_map = XMLClient.parse_xml(body_str, _oss_models.GetBucketRequestPaymentResponse())
                return _oss_models.GetBucketRequestPaymentResponse().from_map(TeaCore.merge({
                    "RequestPaymentConfiguration": resp_map.get('RequestPaymentConfiguration')
                }, _response.headers))

            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def get_bucket_encryption(self, request, runtime):
        request.validate()
        runtime.validate()
        _runtime = {
            "timeouted": "retry",
            "readTimeout": UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            "connectTimeout": UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            "localAddr": UtilClient.default_string(runtime.local_addr, self._local_addr),
            "httpProxy": UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            "httpsProxy": UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            "noProxy": UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            "socks5Proxy": UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            "socks5NetWork": UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            "maxIdleConns": UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            "retry": {
                "retryable": runtime.autoretry,
                "maxAttempts": UtilClient.default_number(runtime.max_attempts, 3)
            },
            "backoff": {
                "policy": UtilClient.default_string(runtime.backoff_policy, "no"),
                "period": UtilClient.default_number(runtime.backoff_period, 1)
            },
            "ignoreSSL": runtime.ignore_ssl
        }
        _last_request = None
        _last_exception = None
        _now = time.time()
        _retry_times = 0
        while TeaCore.allow_retry(_runtime.get('retry'), _retry_times, _now):
            if _retry_times > 0:
                _backoff_time = TeaCore.get_backoff_time(_runtime.get('backoff'), _retry_times)
                if _backoff_time > 0:
                    TeaCore.sleep(_backoff_time)
            _retry_times = _retry_times + 1
            try:
                _request = TeaRequest()
                access_key_id = self._credential.get_access_key_id()
                access_key_secret = self._credential.get_access_key_secret()
                token = self._credential.get_security_token()
                _request.protocol = self._protocol
                _request.method = "GET"
                _request.pathname = "/?encryption"
                _request.headers = {
                    "host": OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    "date": UtilClient.get_date_utcstring(),
                    "user-agent": self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers["x-oss-security-token"] = token
                _request.headers["authorization"] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = UtilClient.read_as_string(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        "code": resp_map.get('Code'),
                        "message": resp_map.get('Message'),
                        "data": {
                            "httpCode": _response.status_code,
                            "requestId": resp_map.get('RequestId'),
                            "hostId": resp_map.get('HostId')
                        }
                    })
                body_str = UtilClient.read_as_string(_response.body)
                resp_map = XMLClient.parse_xml(body_str, _oss_models.GetBucketEncryptionResponse())
                return _oss_models.GetBucketEncryptionResponse().from_map(TeaCore.merge({
                    "ServerSideEncryptionRule": resp_map.get('ServerSideEncryptionRule')
                }, _response.headers))

            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def get_bucket_tags(self, request, runtime):
        request.validate()
        runtime.validate()
        _runtime = {
            "timeouted": "retry",
            "readTimeout": UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            "connectTimeout": UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            "localAddr": UtilClient.default_string(runtime.local_addr, self._local_addr),
            "httpProxy": UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            "httpsProxy": UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            "noProxy": UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            "socks5Proxy": UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            "socks5NetWork": UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            "maxIdleConns": UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            "retry": {
                "retryable": runtime.autoretry,
                "maxAttempts": UtilClient.default_number(runtime.max_attempts, 3)
            },
            "backoff": {
                "policy": UtilClient.default_string(runtime.backoff_policy, "no"),
                "period": UtilClient.default_number(runtime.backoff_period, 1)
            },
            "ignoreSSL": runtime.ignore_ssl
        }
        _last_request = None
        _last_exception = None
        _now = time.time()
        _retry_times = 0
        while TeaCore.allow_retry(_runtime.get('retry'), _retry_times, _now):
            if _retry_times > 0:
                _backoff_time = TeaCore.get_backoff_time(_runtime.get('backoff'), _retry_times)
                if _backoff_time > 0:
                    TeaCore.sleep(_backoff_time)
            _retry_times = _retry_times + 1
            try:
                _request = TeaRequest()
                access_key_id = self._credential.get_access_key_id()
                access_key_secret = self._credential.get_access_key_secret()
                token = self._credential.get_security_token()
                _request.protocol = self._protocol
                _request.method = "GET"
                _request.pathname = "/?tagging"
                _request.headers = {
                    "host": OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    "date": UtilClient.get_date_utcstring(),
                    "user-agent": self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers["x-oss-security-token"] = token
                _request.headers["authorization"] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = UtilClient.read_as_string(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        "code": resp_map.get('Code'),
                        "message": resp_map.get('Message'),
                        "data": {
                            "httpCode": _response.status_code,
                            "requestId": resp_map.get('RequestId'),
                            "hostId": resp_map.get('HostId')
                        }
                    })
                body_str = UtilClient.read_as_string(_response.body)
                resp_map = XMLClient.parse_xml(body_str, _oss_models.GetBucketTagsResponse())
                return _oss_models.GetBucketTagsResponse().from_map(TeaCore.merge({
                    "Tagging": resp_map.get('Tagging')
                }, _response.headers))

            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def get_service(self, request, runtime):
        request.validate()
        runtime.validate()
        _runtime = {
            "timeouted": "retry",
            "readTimeout": UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            "connectTimeout": UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            "localAddr": UtilClient.default_string(runtime.local_addr, self._local_addr),
            "httpProxy": UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            "httpsProxy": UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            "noProxy": UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            "socks5Proxy": UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            "socks5NetWork": UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            "maxIdleConns": UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            "retry": {
                "retryable": runtime.autoretry,
                "maxAttempts": UtilClient.default_number(runtime.max_attempts, 3)
            },
            "backoff": {
                "policy": UtilClient.default_string(runtime.backoff_policy, "no"),
                "period": UtilClient.default_number(runtime.backoff_period, 1)
            },
            "ignoreSSL": runtime.ignore_ssl
        }
        _last_request = None
        _last_exception = None
        _now = time.time()
        _retry_times = 0
        while TeaCore.allow_retry(_runtime.get('retry'), _retry_times, _now):
            if _retry_times > 0:
                _backoff_time = TeaCore.get_backoff_time(_runtime.get('backoff'), _retry_times)
                if _backoff_time > 0:
                    TeaCore.sleep(_backoff_time)
            _retry_times = _retry_times + 1
            try:
                _request = TeaRequest()
                access_key_id = self._credential.get_access_key_id()
                access_key_secret = self._credential.get_access_key_secret()
                token = self._credential.get_security_token()
                _request.protocol = self._protocol
                _request.method = "GET"
                _request.pathname = "/"
                _request.headers = {
                    "host": OSSUtilClient.get_host("", self._region_id, self._endpoint, self._host_model),
                    "date": UtilClient.get_date_utcstring(),
                    "user-agent": self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers["x-oss-security-token"] = token
                _request.query = UtilClient.stringify_map_value(request.filter.to_map())
                _request.headers["authorization"] = OSSUtilClient.get_signature(_request, "", access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = UtilClient.read_as_string(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        "code": resp_map.get('Code'),
                        "message": resp_map.get('Message'),
                        "data": {
                            "httpCode": _response.status_code,
                            "requestId": resp_map.get('RequestId'),
                            "hostId": resp_map.get('HostId')
                        }
                    })
                body_str = UtilClient.read_as_string(_response.body)
                resp_map = XMLClient.parse_xml(body_str, _oss_models.GetServiceResponse())
                return _oss_models.GetServiceResponse().from_map(TeaCore.merge({
                    "ListAllMyBucketsResult": resp_map.get('ListAllMyBucketsResult')
                }, _response.headers))

            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def delete_bucket_encryption(self, request, runtime):
        request.validate()
        runtime.validate()
        _runtime = {
            "timeouted": "retry",
            "readTimeout": UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            "connectTimeout": UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            "localAddr": UtilClient.default_string(runtime.local_addr, self._local_addr),
            "httpProxy": UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            "httpsProxy": UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            "noProxy": UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            "socks5Proxy": UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            "socks5NetWork": UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            "maxIdleConns": UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            "retry": {
                "retryable": runtime.autoretry,
                "maxAttempts": UtilClient.default_number(runtime.max_attempts, 3)
            },
            "backoff": {
                "policy": UtilClient.default_string(runtime.backoff_policy, "no"),
                "period": UtilClient.default_number(runtime.backoff_period, 1)
            },
            "ignoreSSL": runtime.ignore_ssl
        }
        _last_request = None
        _last_exception = None
        _now = time.time()
        _retry_times = 0
        while TeaCore.allow_retry(_runtime.get('retry'), _retry_times, _now):
            if _retry_times > 0:
                _backoff_time = TeaCore.get_backoff_time(_runtime.get('backoff'), _retry_times)
                if _backoff_time > 0:
                    TeaCore.sleep(_backoff_time)
            _retry_times = _retry_times + 1
            try:
                _request = TeaRequest()
                access_key_id = self._credential.get_access_key_id()
                access_key_secret = self._credential.get_access_key_secret()
                token = self._credential.get_security_token()
                _request.protocol = self._protocol
                _request.method = "DELETE"
                _request.pathname = "/?encryption"
                _request.headers = {
                    "host": OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    "date": UtilClient.get_date_utcstring(),
                    "user-agent": self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers["x-oss-security-token"] = token
                _request.headers["authorization"] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = UtilClient.read_as_string(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        "code": resp_map.get('Code'),
                        "message": resp_map.get('Message'),
                        "data": {
                            "httpCode": _response.status_code,
                            "requestId": resp_map.get('RequestId'),
                            "hostId": resp_map.get('HostId')
                        }
                    })
                return _oss_models.DeleteBucketEncryptionResponse().from_map(TeaCore.merge(_response.headers))

            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def delete_bucket_tags(self, request, runtime):
        request.validate()
        runtime.validate()
        _runtime = {
            "timeouted": "retry",
            "readTimeout": UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            "connectTimeout": UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            "localAddr": UtilClient.default_string(runtime.local_addr, self._local_addr),
            "httpProxy": UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            "httpsProxy": UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            "noProxy": UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            "socks5Proxy": UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            "socks5NetWork": UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            "maxIdleConns": UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            "retry": {
                "retryable": runtime.autoretry,
                "maxAttempts": UtilClient.default_number(runtime.max_attempts, 3)
            },
            "backoff": {
                "policy": UtilClient.default_string(runtime.backoff_policy, "no"),
                "period": UtilClient.default_number(runtime.backoff_period, 1)
            },
            "ignoreSSL": runtime.ignore_ssl
        }
        _last_request = None
        _last_exception = None
        _now = time.time()
        _retry_times = 0
        while TeaCore.allow_retry(_runtime.get('retry'), _retry_times, _now):
            if _retry_times > 0:
                _backoff_time = TeaCore.get_backoff_time(_runtime.get('backoff'), _retry_times)
                if _backoff_time > 0:
                    TeaCore.sleep(_backoff_time)
            _retry_times = _retry_times + 1
            try:
                _request = TeaRequest()
                access_key_id = self._credential.get_access_key_id()
                access_key_secret = self._credential.get_access_key_secret()
                token = self._credential.get_security_token()
                _request.protocol = self._protocol
                _request.method = "DELETE"
                _request.pathname = "/"
                _request.headers = {
                    "host": OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    "date": UtilClient.get_date_utcstring(),
                    "user-agent": self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers["x-oss-security-token"] = token
                _request.query = UtilClient.stringify_map_value(request.filter.to_map())
                _request.headers["authorization"] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = UtilClient.read_as_string(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        "code": resp_map.get('Code'),
                        "message": resp_map.get('Message'),
                        "data": {
                            "httpCode": _response.status_code,
                            "requestId": resp_map.get('RequestId'),
                            "hostId": resp_map.get('HostId')
                        }
                    })
                return _oss_models.DeleteBucketTagsResponse().from_map(TeaCore.merge(_response.headers))

            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def get_bucket_website(self, request, runtime):
        request.validate()
        runtime.validate()
        _runtime = {
            "timeouted": "retry",
            "readTimeout": UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            "connectTimeout": UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            "localAddr": UtilClient.default_string(runtime.local_addr, self._local_addr),
            "httpProxy": UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            "httpsProxy": UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            "noProxy": UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            "socks5Proxy": UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            "socks5NetWork": UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            "maxIdleConns": UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            "retry": {
                "retryable": runtime.autoretry,
                "maxAttempts": UtilClient.default_number(runtime.max_attempts, 3)
            },
            "backoff": {
                "policy": UtilClient.default_string(runtime.backoff_policy, "no"),
                "period": UtilClient.default_number(runtime.backoff_period, 1)
            },
            "ignoreSSL": runtime.ignore_ssl
        }
        _last_request = None
        _last_exception = None
        _now = time.time()
        _retry_times = 0
        while TeaCore.allow_retry(_runtime.get('retry'), _retry_times, _now):
            if _retry_times > 0:
                _backoff_time = TeaCore.get_backoff_time(_runtime.get('backoff'), _retry_times)
                if _backoff_time > 0:
                    TeaCore.sleep(_backoff_time)
            _retry_times = _retry_times + 1
            try:
                _request = TeaRequest()
                access_key_id = self._credential.get_access_key_id()
                access_key_secret = self._credential.get_access_key_secret()
                token = self._credential.get_security_token()
                _request.protocol = self._protocol
                _request.method = "GET"
                _request.pathname = "/?website"
                _request.headers = {
                    "host": OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    "date": UtilClient.get_date_utcstring(),
                    "user-agent": self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers["x-oss-security-token"] = token
                _request.headers["authorization"] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = UtilClient.read_as_string(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        "code": resp_map.get('Code'),
                        "message": resp_map.get('Message'),
                        "data": {
                            "httpCode": _response.status_code,
                            "requestId": resp_map.get('RequestId'),
                            "hostId": resp_map.get('HostId')
                        }
                    })
                body_str = UtilClient.read_as_string(_response.body)
                resp_map = XMLClient.parse_xml(body_str, _oss_models.GetBucketWebsiteResponse())
                return _oss_models.GetBucketWebsiteResponse().from_map(TeaCore.merge({
                    "WebsiteConfiguration": resp_map.get('WebsiteConfiguration')
                }, _response.headers))

            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def delete_live_channel(self, request, runtime):
        request.validate()
        runtime.validate()
        _runtime = {
            "timeouted": "retry",
            "readTimeout": UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            "connectTimeout": UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            "localAddr": UtilClient.default_string(runtime.local_addr, self._local_addr),
            "httpProxy": UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            "httpsProxy": UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            "noProxy": UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            "socks5Proxy": UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            "socks5NetWork": UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            "maxIdleConns": UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            "retry": {
                "retryable": runtime.autoretry,
                "maxAttempts": UtilClient.default_number(runtime.max_attempts, 3)
            },
            "backoff": {
                "policy": UtilClient.default_string(runtime.backoff_policy, "no"),
                "period": UtilClient.default_number(runtime.backoff_period, 1)
            },
            "ignoreSSL": runtime.ignore_ssl
        }
        _last_request = None
        _last_exception = None
        _now = time.time()
        _retry_times = 0
        while TeaCore.allow_retry(_runtime.get('retry'), _retry_times, _now):
            if _retry_times > 0:
                _backoff_time = TeaCore.get_backoff_time(_runtime.get('backoff'), _retry_times)
                if _backoff_time > 0:
                    TeaCore.sleep(_backoff_time)
            _retry_times = _retry_times + 1
            try:
                _request = TeaRequest()
                access_key_id = self._credential.get_access_key_id()
                access_key_secret = self._credential.get_access_key_secret()
                token = self._credential.get_security_token()
                _request.protocol = self._protocol
                _request.method = "DELETE"
                _request.pathname = "/" + request.channel_name + "?live"
                _request.headers = {
                    "host": OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    "date": UtilClient.get_date_utcstring(),
                    "user-agent": self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers["x-oss-security-token"] = token
                _request.headers["authorization"] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = UtilClient.read_as_string(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        "code": resp_map.get('Code'),
                        "message": resp_map.get('Message'),
                        "data": {
                            "httpCode": _response.status_code,
                            "requestId": resp_map.get('RequestId'),
                            "hostId": resp_map.get('HostId')
                        }
                    })
                return _oss_models.DeleteLiveChannelResponse().from_map(TeaCore.merge(_response.headers))

            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def get_bucket_location(self, request, runtime):
        request.validate()
        runtime.validate()
        _runtime = {
            "timeouted": "retry",
            "readTimeout": UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            "connectTimeout": UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            "localAddr": UtilClient.default_string(runtime.local_addr, self._local_addr),
            "httpProxy": UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            "httpsProxy": UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            "noProxy": UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            "socks5Proxy": UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            "socks5NetWork": UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            "maxIdleConns": UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            "retry": {
                "retryable": runtime.autoretry,
                "maxAttempts": UtilClient.default_number(runtime.max_attempts, 3)
            },
            "backoff": {
                "policy": UtilClient.default_string(runtime.backoff_policy, "no"),
                "period": UtilClient.default_number(runtime.backoff_period, 1)
            },
            "ignoreSSL": runtime.ignore_ssl
        }
        _last_request = None
        _last_exception = None
        _now = time.time()
        _retry_times = 0
        while TeaCore.allow_retry(_runtime.get('retry'), _retry_times, _now):
            if _retry_times > 0:
                _backoff_time = TeaCore.get_backoff_time(_runtime.get('backoff'), _retry_times)
                if _backoff_time > 0:
                    TeaCore.sleep(_backoff_time)
            _retry_times = _retry_times + 1
            try:
                _request = TeaRequest()
                access_key_id = self._credential.get_access_key_id()
                access_key_secret = self._credential.get_access_key_secret()
                token = self._credential.get_security_token()
                _request.protocol = self._protocol
                _request.method = "GET"
                _request.pathname = "/?location"
                _request.headers = {
                    "host": OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    "date": UtilClient.get_date_utcstring(),
                    "user-agent": self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers["x-oss-security-token"] = token
                _request.headers["authorization"] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = UtilClient.read_as_string(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        "code": resp_map.get('Code'),
                        "message": resp_map.get('Message'),
                        "data": {
                            "httpCode": _response.status_code,
                            "requestId": resp_map.get('RequestId'),
                            "hostId": resp_map.get('HostId')
                        }
                    })
                body_str = UtilClient.read_as_string(_response.body)
                resp_map = XMLClient.parse_xml(body_str, _oss_models.GetBucketLocationResponse())
                return _oss_models.GetBucketLocationResponse().from_map(TeaCore.merge({
                    "LocationConstraint": resp_map.get('LocationConstraint')
                }, _response.headers))

            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def list_live_channel(self, request, runtime):
        request.validate()
        runtime.validate()
        _runtime = {
            "timeouted": "retry",
            "readTimeout": UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            "connectTimeout": UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            "localAddr": UtilClient.default_string(runtime.local_addr, self._local_addr),
            "httpProxy": UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            "httpsProxy": UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            "noProxy": UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            "socks5Proxy": UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            "socks5NetWork": UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            "maxIdleConns": UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            "retry": {
                "retryable": runtime.autoretry,
                "maxAttempts": UtilClient.default_number(runtime.max_attempts, 3)
            },
            "backoff": {
                "policy": UtilClient.default_string(runtime.backoff_policy, "no"),
                "period": UtilClient.default_number(runtime.backoff_period, 1)
            },
            "ignoreSSL": runtime.ignore_ssl
        }
        _last_request = None
        _last_exception = None
        _now = time.time()
        _retry_times = 0
        while TeaCore.allow_retry(_runtime.get('retry'), _retry_times, _now):
            if _retry_times > 0:
                _backoff_time = TeaCore.get_backoff_time(_runtime.get('backoff'), _retry_times)
                if _backoff_time > 0:
                    TeaCore.sleep(_backoff_time)
            _retry_times = _retry_times + 1
            try:
                _request = TeaRequest()
                access_key_id = self._credential.get_access_key_id()
                access_key_secret = self._credential.get_access_key_secret()
                token = self._credential.get_security_token()
                _request.protocol = self._protocol
                _request.method = "GET"
                _request.pathname = "/?live"
                _request.headers = {
                    "host": OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    "date": UtilClient.get_date_utcstring(),
                    "user-agent": self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers["x-oss-security-token"] = token
                _request.query = UtilClient.stringify_map_value(request.filter.to_map())
                _request.headers["authorization"] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = UtilClient.read_as_string(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        "code": resp_map.get('Code'),
                        "message": resp_map.get('Message'),
                        "data": {
                            "httpCode": _response.status_code,
                            "requestId": resp_map.get('RequestId'),
                            "hostId": resp_map.get('HostId')
                        }
                    })
                body_str = UtilClient.read_as_string(_response.body)
                resp_map = XMLClient.parse_xml(body_str, _oss_models.ListLiveChannelResponse())
                return _oss_models.ListLiveChannelResponse().from_map(TeaCore.merge({
                    "ListLiveChannelResult": resp_map.get('ListLiveChannelResult')
                }, _response.headers))

            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def get_object_meta(self, request, runtime):
        request.validate()
        runtime.validate()
        _runtime = {
            "timeouted": "retry",
            "readTimeout": UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            "connectTimeout": UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            "localAddr": UtilClient.default_string(runtime.local_addr, self._local_addr),
            "httpProxy": UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            "httpsProxy": UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            "noProxy": UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            "socks5Proxy": UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            "socks5NetWork": UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            "maxIdleConns": UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            "retry": {
                "retryable": runtime.autoretry,
                "maxAttempts": UtilClient.default_number(runtime.max_attempts, 3)
            },
            "backoff": {
                "policy": UtilClient.default_string(runtime.backoff_policy, "no"),
                "period": UtilClient.default_number(runtime.backoff_period, 1)
            },
            "ignoreSSL": runtime.ignore_ssl
        }
        _last_request = None
        _last_exception = None
        _now = time.time()
        _retry_times = 0
        while TeaCore.allow_retry(_runtime.get('retry'), _retry_times, _now):
            if _retry_times > 0:
                _backoff_time = TeaCore.get_backoff_time(_runtime.get('backoff'), _retry_times)
                if _backoff_time > 0:
                    TeaCore.sleep(_backoff_time)
            _retry_times = _retry_times + 1
            try:
                _request = TeaRequest()
                access_key_id = self._credential.get_access_key_id()
                access_key_secret = self._credential.get_access_key_secret()
                token = self._credential.get_security_token()
                _request.protocol = self._protocol
                _request.method = "HEAD"
                _request.pathname = "/" + request.object_name + "?objectMeta"
                _request.headers = {
                    "host": OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    "date": UtilClient.get_date_utcstring(),
                    "user-agent": self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers["x-oss-security-token"] = token
                _request.headers["authorization"] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = UtilClient.read_as_string(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        "code": resp_map.get('Code'),
                        "message": resp_map.get('Message'),
                        "data": {
                            "httpCode": _response.status_code,
                            "requestId": resp_map.get('RequestId'),
                            "hostId": resp_map.get('HostId')
                        }
                    })
                return _oss_models.GetObjectMetaResponse().from_map(TeaCore.merge(_response.headers))

            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def get_bucket_acl(self, request, runtime):
        request.validate()
        runtime.validate()
        _runtime = {
            "timeouted": "retry",
            "readTimeout": UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            "connectTimeout": UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            "localAddr": UtilClient.default_string(runtime.local_addr, self._local_addr),
            "httpProxy": UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            "httpsProxy": UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            "noProxy": UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            "socks5Proxy": UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            "socks5NetWork": UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            "maxIdleConns": UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            "retry": {
                "retryable": runtime.autoretry,
                "maxAttempts": UtilClient.default_number(runtime.max_attempts, 3)
            },
            "backoff": {
                "policy": UtilClient.default_string(runtime.backoff_policy, "no"),
                "period": UtilClient.default_number(runtime.backoff_period, 1)
            },
            "ignoreSSL": runtime.ignore_ssl
        }
        _last_request = None
        _last_exception = None
        _now = time.time()
        _retry_times = 0
        while TeaCore.allow_retry(_runtime.get('retry'), _retry_times, _now):
            if _retry_times > 0:
                _backoff_time = TeaCore.get_backoff_time(_runtime.get('backoff'), _retry_times)
                if _backoff_time > 0:
                    TeaCore.sleep(_backoff_time)
            _retry_times = _retry_times + 1
            try:
                _request = TeaRequest()
                access_key_id = self._credential.get_access_key_id()
                access_key_secret = self._credential.get_access_key_secret()
                token = self._credential.get_security_token()
                _request.protocol = self._protocol
                _request.method = "GET"
                _request.pathname = "/?acl"
                _request.headers = {
                    "host": OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    "date": UtilClient.get_date_utcstring(),
                    "user-agent": self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers["x-oss-security-token"] = token
                _request.headers["authorization"] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = UtilClient.read_as_string(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        "code": resp_map.get('Code'),
                        "message": resp_map.get('Message'),
                        "data": {
                            "httpCode": _response.status_code,
                            "requestId": resp_map.get('RequestId'),
                            "hostId": resp_map.get('HostId')
                        }
                    })
                body_str = UtilClient.read_as_string(_response.body)
                resp_map = XMLClient.parse_xml(body_str, _oss_models.GetBucketAclResponse())
                return _oss_models.GetBucketAclResponse().from_map(TeaCore.merge({
                    "AccessControlPolicy": resp_map.get('AccessControlPolicy')
                }, _response.headers))

            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def list_parts(self, request, runtime):
        request.validate()
        runtime.validate()
        _runtime = {
            "timeouted": "retry",
            "readTimeout": UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            "connectTimeout": UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            "localAddr": UtilClient.default_string(runtime.local_addr, self._local_addr),
            "httpProxy": UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            "httpsProxy": UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            "noProxy": UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            "socks5Proxy": UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            "socks5NetWork": UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            "maxIdleConns": UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            "retry": {
                "retryable": runtime.autoretry,
                "maxAttempts": UtilClient.default_number(runtime.max_attempts, 3)
            },
            "backoff": {
                "policy": UtilClient.default_string(runtime.backoff_policy, "no"),
                "period": UtilClient.default_number(runtime.backoff_period, 1)
            },
            "ignoreSSL": runtime.ignore_ssl
        }
        _last_request = None
        _last_exception = None
        _now = time.time()
        _retry_times = 0
        while TeaCore.allow_retry(_runtime.get('retry'), _retry_times, _now):
            if _retry_times > 0:
                _backoff_time = TeaCore.get_backoff_time(_runtime.get('backoff'), _retry_times)
                if _backoff_time > 0:
                    TeaCore.sleep(_backoff_time)
            _retry_times = _retry_times + 1
            try:
                _request = TeaRequest()
                access_key_id = self._credential.get_access_key_id()
                access_key_secret = self._credential.get_access_key_secret()
                token = self._credential.get_security_token()
                _request.protocol = self._protocol
                _request.method = "GET"
                _request.pathname = "/" + request.object_name + ""
                _request.headers = {
                    "host": OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    "date": UtilClient.get_date_utcstring(),
                    "user-agent": self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers["x-oss-security-token"] = token
                _request.query = UtilClient.stringify_map_value(request.filter.to_map())
                _request.headers["authorization"] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = UtilClient.read_as_string(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        "code": resp_map.get('Code'),
                        "message": resp_map.get('Message'),
                        "data": {
                            "httpCode": _response.status_code,
                            "requestId": resp_map.get('RequestId'),
                            "hostId": resp_map.get('HostId')
                        }
                    })
                body_str = UtilClient.read_as_string(_response.body)
                resp_map = XMLClient.parse_xml(body_str, _oss_models.ListPartsResponse())
                return _oss_models.ListPartsResponse().from_map(TeaCore.merge({
                    "ListPartsResult": resp_map.get('ListPartsResult')
                }, _response.headers))

            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def get_live_channel_history(self, request, runtime):
        request.validate()
        runtime.validate()
        _runtime = {
            "timeouted": "retry",
            "readTimeout": UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            "connectTimeout": UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            "localAddr": UtilClient.default_string(runtime.local_addr, self._local_addr),
            "httpProxy": UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            "httpsProxy": UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            "noProxy": UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            "socks5Proxy": UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            "socks5NetWork": UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            "maxIdleConns": UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            "retry": {
                "retryable": runtime.autoretry,
                "maxAttempts": UtilClient.default_number(runtime.max_attempts, 3)
            },
            "backoff": {
                "policy": UtilClient.default_string(runtime.backoff_policy, "no"),
                "period": UtilClient.default_number(runtime.backoff_period, 1)
            },
            "ignoreSSL": runtime.ignore_ssl
        }
        _last_request = None
        _last_exception = None
        _now = time.time()
        _retry_times = 0
        while TeaCore.allow_retry(_runtime.get('retry'), _retry_times, _now):
            if _retry_times > 0:
                _backoff_time = TeaCore.get_backoff_time(_runtime.get('backoff'), _retry_times)
                if _backoff_time > 0:
                    TeaCore.sleep(_backoff_time)
            _retry_times = _retry_times + 1
            try:
                _request = TeaRequest()
                access_key_id = self._credential.get_access_key_id()
                access_key_secret = self._credential.get_access_key_secret()
                token = self._credential.get_security_token()
                _request.protocol = self._protocol
                _request.method = "GET"
                _request.pathname = "/" + request.channel_name + "?live"
                _request.headers = {
                    "host": OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    "date": UtilClient.get_date_utcstring(),
                    "user-agent": self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers["x-oss-security-token"] = token
                _request.query = UtilClient.stringify_map_value(request.filter.to_map())
                _request.headers["authorization"] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = UtilClient.read_as_string(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        "code": resp_map.get('Code'),
                        "message": resp_map.get('Message'),
                        "data": {
                            "httpCode": _response.status_code,
                            "requestId": resp_map.get('RequestId'),
                            "hostId": resp_map.get('HostId')
                        }
                    })
                body_str = UtilClient.read_as_string(_response.body)
                resp_map = XMLClient.parse_xml(body_str, _oss_models.GetLiveChannelHistoryResponse())
                return _oss_models.GetLiveChannelHistoryResponse().from_map(TeaCore.merge({
                    "LiveChannelHistory": resp_map.get('LiveChannelHistory')
                }, _response.headers))

            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def get_bucket(self, request, runtime):
        request.validate()
        runtime.validate()
        _runtime = {
            "timeouted": "retry",
            "readTimeout": UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            "connectTimeout": UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            "localAddr": UtilClient.default_string(runtime.local_addr, self._local_addr),
            "httpProxy": UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            "httpsProxy": UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            "noProxy": UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            "socks5Proxy": UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            "socks5NetWork": UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            "maxIdleConns": UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            "retry": {
                "retryable": runtime.autoretry,
                "maxAttempts": UtilClient.default_number(runtime.max_attempts, 3)
            },
            "backoff": {
                "policy": UtilClient.default_string(runtime.backoff_policy, "no"),
                "period": UtilClient.default_number(runtime.backoff_period, 1)
            },
            "ignoreSSL": runtime.ignore_ssl
        }
        _last_request = None
        _last_exception = None
        _now = time.time()
        _retry_times = 0
        while TeaCore.allow_retry(_runtime.get('retry'), _retry_times, _now):
            if _retry_times > 0:
                _backoff_time = TeaCore.get_backoff_time(_runtime.get('backoff'), _retry_times)
                if _backoff_time > 0:
                    TeaCore.sleep(_backoff_time)
            _retry_times = _retry_times + 1
            try:
                _request = TeaRequest()
                access_key_id = self._credential.get_access_key_id()
                access_key_secret = self._credential.get_access_key_secret()
                token = self._credential.get_security_token()
                _request.protocol = self._protocol
                _request.method = "GET"
                _request.pathname = "/"
                _request.headers = {
                    "host": OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    "date": UtilClient.get_date_utcstring(),
                    "user-agent": self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers["x-oss-security-token"] = token
                _request.query = UtilClient.stringify_map_value(request.filter.to_map())
                _request.headers["authorization"] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = UtilClient.read_as_string(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        "code": resp_map.get('Code'),
                        "message": resp_map.get('Message'),
                        "data": {
                            "httpCode": _response.status_code,
                            "requestId": resp_map.get('RequestId'),
                            "hostId": resp_map.get('HostId')
                        }
                    })
                body_str = UtilClient.read_as_string(_response.body)
                resp_map = XMLClient.parse_xml(body_str, _oss_models.GetBucketResponse())
                return _oss_models.GetBucketResponse().from_map(TeaCore.merge({
                    "ListBucketResult": resp_map.get('ListBucketResult')
                }, _response.headers))

            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def get_live_channel_info(self, request, runtime):
        request.validate()
        runtime.validate()
        _runtime = {
            "timeouted": "retry",
            "readTimeout": UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            "connectTimeout": UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            "localAddr": UtilClient.default_string(runtime.local_addr, self._local_addr),
            "httpProxy": UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            "httpsProxy": UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            "noProxy": UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            "socks5Proxy": UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            "socks5NetWork": UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            "maxIdleConns": UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            "retry": {
                "retryable": runtime.autoretry,
                "maxAttempts": UtilClient.default_number(runtime.max_attempts, 3)
            },
            "backoff": {
                "policy": UtilClient.default_string(runtime.backoff_policy, "no"),
                "period": UtilClient.default_number(runtime.backoff_period, 1)
            },
            "ignoreSSL": runtime.ignore_ssl
        }
        _last_request = None
        _last_exception = None
        _now = time.time()
        _retry_times = 0
        while TeaCore.allow_retry(_runtime.get('retry'), _retry_times, _now):
            if _retry_times > 0:
                _backoff_time = TeaCore.get_backoff_time(_runtime.get('backoff'), _retry_times)
                if _backoff_time > 0:
                    TeaCore.sleep(_backoff_time)
            _retry_times = _retry_times + 1
            try:
                _request = TeaRequest()
                access_key_id = self._credential.get_access_key_id()
                access_key_secret = self._credential.get_access_key_secret()
                token = self._credential.get_security_token()
                _request.protocol = self._protocol
                _request.method = "GET"
                _request.pathname = "/" + request.channel_name + "?live"
                _request.headers = {
                    "host": OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    "date": UtilClient.get_date_utcstring(),
                    "user-agent": self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers["x-oss-security-token"] = token
                _request.headers["authorization"] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = UtilClient.read_as_string(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        "code": resp_map.get('Code'),
                        "message": resp_map.get('Message'),
                        "data": {
                            "httpCode": _response.status_code,
                            "requestId": resp_map.get('RequestId'),
                            "hostId": resp_map.get('HostId')
                        }
                    })
                body_str = UtilClient.read_as_string(_response.body)
                resp_map = XMLClient.parse_xml(body_str, _oss_models.GetLiveChannelInfoResponse())
                return _oss_models.GetLiveChannelInfoResponse().from_map(TeaCore.merge({
                    "LiveChannelConfiguration": resp_map.get('LiveChannelConfiguration')
                }, _response.headers))

            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def get_live_channel_stat(self, request, runtime):
        request.validate()
        runtime.validate()
        _runtime = {
            "timeouted": "retry",
            "readTimeout": UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            "connectTimeout": UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            "localAddr": UtilClient.default_string(runtime.local_addr, self._local_addr),
            "httpProxy": UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            "httpsProxy": UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            "noProxy": UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            "socks5Proxy": UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            "socks5NetWork": UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            "maxIdleConns": UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            "retry": {
                "retryable": runtime.autoretry,
                "maxAttempts": UtilClient.default_number(runtime.max_attempts, 3)
            },
            "backoff": {
                "policy": UtilClient.default_string(runtime.backoff_policy, "no"),
                "period": UtilClient.default_number(runtime.backoff_period, 1)
            },
            "ignoreSSL": runtime.ignore_ssl
        }
        _last_request = None
        _last_exception = None
        _now = time.time()
        _retry_times = 0
        while TeaCore.allow_retry(_runtime.get('retry'), _retry_times, _now):
            if _retry_times > 0:
                _backoff_time = TeaCore.get_backoff_time(_runtime.get('backoff'), _retry_times)
                if _backoff_time > 0:
                    TeaCore.sleep(_backoff_time)
            _retry_times = _retry_times + 1
            try:
                _request = TeaRequest()
                access_key_id = self._credential.get_access_key_id()
                access_key_secret = self._credential.get_access_key_secret()
                token = self._credential.get_security_token()
                _request.protocol = self._protocol
                _request.method = "GET"
                _request.pathname = "/" + request.channel_name + "?live"
                _request.headers = {
                    "host": OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    "date": UtilClient.get_date_utcstring(),
                    "user-agent": self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers["x-oss-security-token"] = token
                _request.query = UtilClient.stringify_map_value(request.filter.to_map())
                _request.headers["authorization"] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = UtilClient.read_as_string(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        "code": resp_map.get('Code'),
                        "message": resp_map.get('Message'),
                        "data": {
                            "httpCode": _response.status_code,
                            "requestId": resp_map.get('RequestId'),
                            "hostId": resp_map.get('HostId')
                        }
                    })
                body_str = UtilClient.read_as_string(_response.body)
                resp_map = XMLClient.parse_xml(body_str, _oss_models.GetLiveChannelStatResponse())
                return _oss_models.GetLiveChannelStatResponse().from_map(TeaCore.merge({
                    "LiveChannelStat": resp_map.get('LiveChannelStat')
                }, _response.headers))

            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def delete_object(self, request, runtime):
        request.validate()
        runtime.validate()
        _runtime = {
            "timeouted": "retry",
            "readTimeout": UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            "connectTimeout": UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            "localAddr": UtilClient.default_string(runtime.local_addr, self._local_addr),
            "httpProxy": UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            "httpsProxy": UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            "noProxy": UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            "socks5Proxy": UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            "socks5NetWork": UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            "maxIdleConns": UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            "retry": {
                "retryable": runtime.autoretry,
                "maxAttempts": UtilClient.default_number(runtime.max_attempts, 3)
            },
            "backoff": {
                "policy": UtilClient.default_string(runtime.backoff_policy, "no"),
                "period": UtilClient.default_number(runtime.backoff_period, 1)
            },
            "ignoreSSL": runtime.ignore_ssl
        }
        _last_request = None
        _last_exception = None
        _now = time.time()
        _retry_times = 0
        while TeaCore.allow_retry(_runtime.get('retry'), _retry_times, _now):
            if _retry_times > 0:
                _backoff_time = TeaCore.get_backoff_time(_runtime.get('backoff'), _retry_times)
                if _backoff_time > 0:
                    TeaCore.sleep(_backoff_time)
            _retry_times = _retry_times + 1
            try:
                _request = TeaRequest()
                access_key_id = self._credential.get_access_key_id()
                access_key_secret = self._credential.get_access_key_secret()
                token = self._credential.get_security_token()
                _request.protocol = self._protocol
                _request.method = "DELETE"
                _request.pathname = "/" + request.object_name + ""
                _request.headers = {
                    "host": OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    "date": UtilClient.get_date_utcstring(),
                    "user-agent": self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers["x-oss-security-token"] = token
                _request.headers["authorization"] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = UtilClient.read_as_string(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        "code": resp_map.get('Code'),
                        "message": resp_map.get('Message'),
                        "data": {
                            "httpCode": _response.status_code,
                            "requestId": resp_map.get('RequestId'),
                            "hostId": resp_map.get('HostId')
                        }
                    })
                return _oss_models.DeleteObjectResponse().from_map(TeaCore.merge(_response.headers))

            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def abort_multipart_upload(self, request, runtime):
        request.validate()
        runtime.validate()
        _runtime = {
            "timeouted": "retry",
            "readTimeout": UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            "connectTimeout": UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            "localAddr": UtilClient.default_string(runtime.local_addr, self._local_addr),
            "httpProxy": UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            "httpsProxy": UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            "noProxy": UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            "socks5Proxy": UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            "socks5NetWork": UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            "maxIdleConns": UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            "retry": {
                "retryable": runtime.autoretry,
                "maxAttempts": UtilClient.default_number(runtime.max_attempts, 3)
            },
            "backoff": {
                "policy": UtilClient.default_string(runtime.backoff_policy, "no"),
                "period": UtilClient.default_number(runtime.backoff_period, 1)
            },
            "ignoreSSL": runtime.ignore_ssl
        }
        _last_request = None
        _last_exception = None
        _now = time.time()
        _retry_times = 0
        while TeaCore.allow_retry(_runtime.get('retry'), _retry_times, _now):
            if _retry_times > 0:
                _backoff_time = TeaCore.get_backoff_time(_runtime.get('backoff'), _retry_times)
                if _backoff_time > 0:
                    TeaCore.sleep(_backoff_time)
            _retry_times = _retry_times + 1
            try:
                _request = TeaRequest()
                access_key_id = self._credential.get_access_key_id()
                access_key_secret = self._credential.get_access_key_secret()
                token = self._credential.get_security_token()
                _request.protocol = self._protocol
                _request.method = "DELETE"
                _request.pathname = "/" + request.object_name + ""
                _request.headers = {
                    "host": OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    "date": UtilClient.get_date_utcstring(),
                    "user-agent": self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers["x-oss-security-token"] = token
                _request.query = UtilClient.stringify_map_value(request.filter.to_map())
                _request.headers["authorization"] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = UtilClient.read_as_string(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        "code": resp_map.get('Code'),
                        "message": resp_map.get('Message'),
                        "data": {
                            "httpCode": _response.status_code,
                            "requestId": resp_map.get('RequestId'),
                            "hostId": resp_map.get('HostId')
                        }
                    })
                return _oss_models.AbortMultipartUploadResponse().from_map(TeaCore.merge(_response.headers))

            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def append_object(self, request, runtime):
        request.validate()
        runtime.validate()
        _runtime = {
            "timeouted": "retry",
            "readTimeout": UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            "connectTimeout": UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            "localAddr": UtilClient.default_string(runtime.local_addr, self._local_addr),
            "httpProxy": UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            "httpsProxy": UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            "noProxy": UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            "socks5Proxy": UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            "socks5NetWork": UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            "maxIdleConns": UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            "retry": {
                "retryable": runtime.autoretry,
                "maxAttempts": UtilClient.default_number(runtime.max_attempts, 3)
            },
            "backoff": {
                "policy": UtilClient.default_string(runtime.backoff_policy, "no"),
                "period": UtilClient.default_number(runtime.backoff_period, 1)
            },
            "ignoreSSL": runtime.ignore_ssl
        }
        _last_request = None
        _last_exception = None
        _now = time.time()
        _retry_times = 0
        while TeaCore.allow_retry(_runtime.get('retry'), _retry_times, _now):
            if _retry_times > 0:
                _backoff_time = TeaCore.get_backoff_time(_runtime.get('backoff'), _retry_times)
                if _backoff_time > 0:
                    TeaCore.sleep(_backoff_time)
            _retry_times = _retry_times + 1
            try:
                _request = TeaRequest()
                ctx = {}
                access_key_id = self._credential.get_access_key_id()
                access_key_secret = self._credential.get_access_key_secret()
                token = self._credential.get_security_token()
                _request.protocol = self._protocol
                _request.method = "POST"
                _request.pathname = "/" + request.object_name + "?append"
                _request.headers = TeaCore.merge({
                    "host": OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    "date": UtilClient.get_date_utcstring(),
                    "user-agent": self.get_user_agent()
                }, UtilClient.stringify_map_value(request.header.to_map()),
                    OSSUtilClient.parse_meta(request.user_meta, "x-oss-meta-"))
                if not UtilClient.empty(token):
                    _request.headers["x-oss-security-token"] = token
                _request.query = UtilClient.stringify_map_value(request.filter.to_map())
                _request.body = OSSUtilClient.inject(request.body, ctx)
                if not UtilClient.is_unset(request.header.to_map()) and not UtilClient.empty(request.header.content_type):
                    _request.headers["content-type"] = request.header.content_type
                else:
                    _request.headers["content-type"] = OSSUtilClient.get_content_type(request.object_name)
                _request.headers["authorization"] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = UtilClient.read_as_string(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        "code": resp_map.get('Code'),
                        "message": resp_map.get('Message'),
                        "data": {
                            "httpCode": _response.status_code,
                            "requestId": resp_map.get('RequestId'),
                            "hostId": resp_map.get('HostId')
                        }
                    })
                if self._is_enable_crc and not UtilClient.equal_string(ctx.get('crc'), _response.headers.get('x-oss-hash-crc64ecma')):
                    raise TeaException({
                        "code": "CrcNotMatched",
                        "data": {
                            "clientCrc": ctx.get('crc'),
                            "serverCrc": _response.headers.get('x-oss-hash-crc64ecma')
                        }
                    })
                if self._is_enable_md5 and not UtilClient.equal_string(ctx.get('md5'), _response.headers.get('content-md5')):
                    raise TeaException({
                        "code": "MD5NotMatched",
                        "data": {
                            "clientMD5": ctx.get('md5'),
                            "serverMD5": _response.headers.get('content-md5')
                        }
                    })
                return _oss_models.AppendObjectResponse().from_map(TeaCore.merge(_response.headers))

            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def upload_part_copy(self, request, runtime):
        request.validate()
        runtime.validate()
        _runtime = {
            "timeouted": "retry",
            "readTimeout": UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            "connectTimeout": UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            "localAddr": UtilClient.default_string(runtime.local_addr, self._local_addr),
            "httpProxy": UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            "httpsProxy": UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            "noProxy": UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            "socks5Proxy": UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            "socks5NetWork": UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            "maxIdleConns": UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            "retry": {
                "retryable": runtime.autoretry,
                "maxAttempts": UtilClient.default_number(runtime.max_attempts, 3)
            },
            "backoff": {
                "policy": UtilClient.default_string(runtime.backoff_policy, "no"),
                "period": UtilClient.default_number(runtime.backoff_period, 1)
            },
            "ignoreSSL": runtime.ignore_ssl
        }
        _last_request = None
        _last_exception = None
        _now = time.time()
        _retry_times = 0
        while TeaCore.allow_retry(_runtime.get('retry'), _retry_times, _now):
            if _retry_times > 0:
                _backoff_time = TeaCore.get_backoff_time(_runtime.get('backoff'), _retry_times)
                if _backoff_time > 0:
                    TeaCore.sleep(_backoff_time)
            _retry_times = _retry_times + 1
            try:
                _request = TeaRequest()
                access_key_id = self._credential.get_access_key_id()
                access_key_secret = self._credential.get_access_key_secret()
                token = self._credential.get_security_token()
                _request.protocol = self._protocol
                _request.method = "PUT"
                _request.pathname = "/" + request.object_name + ""
                _request.headers = TeaCore.merge({
                    "host": OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    "date": UtilClient.get_date_utcstring(),
                    "user-agent": self.get_user_agent()
                }, UtilClient.stringify_map_value(request.header.to_map()))
                if not UtilClient.empty(token):
                    _request.headers["x-oss-security-token"] = token
                _request.query = UtilClient.stringify_map_value(request.filter.to_map())
                _request.headers["authorization"] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = UtilClient.read_as_string(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        "code": resp_map.get('Code'),
                        "message": resp_map.get('Message'),
                        "data": {
                            "httpCode": _response.status_code,
                            "requestId": resp_map.get('RequestId'),
                            "hostId": resp_map.get('HostId')
                        }
                    })
                body_str = UtilClient.read_as_string(_response.body)
                resp_map = XMLClient.parse_xml(body_str, _oss_models.UploadPartCopyResponse())
                return _oss_models.UploadPartCopyResponse().from_map(TeaCore.merge({
                    "CopyPartResult": resp_map.get('CopyPartResult')
                }, _response.headers))

            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def get_vod_playlist(self, request, runtime):
        request.validate()
        runtime.validate()
        _runtime = {
            "timeouted": "retry",
            "readTimeout": UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            "connectTimeout": UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            "localAddr": UtilClient.default_string(runtime.local_addr, self._local_addr),
            "httpProxy": UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            "httpsProxy": UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            "noProxy": UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            "socks5Proxy": UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            "socks5NetWork": UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            "maxIdleConns": UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            "retry": {
                "retryable": runtime.autoretry,
                "maxAttempts": UtilClient.default_number(runtime.max_attempts, 3)
            },
            "backoff": {
                "policy": UtilClient.default_string(runtime.backoff_policy, "no"),
                "period": UtilClient.default_number(runtime.backoff_period, 1)
            },
            "ignoreSSL": runtime.ignore_ssl
        }
        _last_request = None
        _last_exception = None
        _now = time.time()
        _retry_times = 0
        while TeaCore.allow_retry(_runtime.get('retry'), _retry_times, _now):
            if _retry_times > 0:
                _backoff_time = TeaCore.get_backoff_time(_runtime.get('backoff'), _retry_times)
                if _backoff_time > 0:
                    TeaCore.sleep(_backoff_time)
            _retry_times = _retry_times + 1
            try:
                _request = TeaRequest()
                access_key_id = self._credential.get_access_key_id()
                access_key_secret = self._credential.get_access_key_secret()
                token = self._credential.get_security_token()
                _request.protocol = self._protocol
                _request.method = "GET"
                _request.pathname = "/" + request.channel_name + "?vod"
                _request.headers = {
                    "host": OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    "date": UtilClient.get_date_utcstring(),
                    "user-agent": self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers["x-oss-security-token"] = token
                _request.query = UtilClient.stringify_map_value(request.filter.to_map())
                _request.headers["authorization"] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = UtilClient.read_as_string(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        "code": resp_map.get('Code'),
                        "message": resp_map.get('Message'),
                        "data": {
                            "httpCode": _response.status_code,
                            "requestId": resp_map.get('RequestId'),
                            "hostId": resp_map.get('HostId')
                        }
                    })
                return _oss_models.GetVodPlaylistResponse().from_map(TeaCore.merge(_response.headers))

            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def delete_bucket_cors(self, request, runtime):
        request.validate()
        runtime.validate()
        _runtime = {
            "timeouted": "retry",
            "readTimeout": UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            "connectTimeout": UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            "localAddr": UtilClient.default_string(runtime.local_addr, self._local_addr),
            "httpProxy": UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            "httpsProxy": UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            "noProxy": UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            "socks5Proxy": UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            "socks5NetWork": UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            "maxIdleConns": UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            "retry": {
                "retryable": runtime.autoretry,
                "maxAttempts": UtilClient.default_number(runtime.max_attempts, 3)
            },
            "backoff": {
                "policy": UtilClient.default_string(runtime.backoff_policy, "no"),
                "period": UtilClient.default_number(runtime.backoff_period, 1)
            },
            "ignoreSSL": runtime.ignore_ssl
        }
        _last_request = None
        _last_exception = None
        _now = time.time()
        _retry_times = 0
        while TeaCore.allow_retry(_runtime.get('retry'), _retry_times, _now):
            if _retry_times > 0:
                _backoff_time = TeaCore.get_backoff_time(_runtime.get('backoff'), _retry_times)
                if _backoff_time > 0:
                    TeaCore.sleep(_backoff_time)
            _retry_times = _retry_times + 1
            try:
                _request = TeaRequest()
                access_key_id = self._credential.get_access_key_id()
                access_key_secret = self._credential.get_access_key_secret()
                token = self._credential.get_security_token()
                _request.protocol = self._protocol
                _request.method = "DELETE"
                _request.pathname = "/?cors"
                _request.headers = {
                    "host": OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    "date": UtilClient.get_date_utcstring(),
                    "user-agent": self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers["x-oss-security-token"] = token
                _request.headers["authorization"] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = UtilClient.read_as_string(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        "code": resp_map.get('Code'),
                        "message": resp_map.get('Message'),
                        "data": {
                            "httpCode": _response.status_code,
                            "requestId": resp_map.get('RequestId'),
                            "hostId": resp_map.get('HostId')
                        }
                    })
                return _oss_models.DeleteBucketCORSResponse().from_map(TeaCore.merge(_response.headers))

            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def get_object(self, request, runtime):
        request.validate()
        runtime.validate()
        _runtime = {
            "timeouted": "retry",
            "readTimeout": UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            "connectTimeout": UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            "localAddr": UtilClient.default_string(runtime.local_addr, self._local_addr),
            "httpProxy": UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            "httpsProxy": UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            "noProxy": UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            "socks5Proxy": UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            "socks5NetWork": UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            "maxIdleConns": UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            "retry": {
                "retryable": runtime.autoretry,
                "maxAttempts": UtilClient.default_number(runtime.max_attempts, 3)
            },
            "backoff": {
                "policy": UtilClient.default_string(runtime.backoff_policy, "no"),
                "period": UtilClient.default_number(runtime.backoff_period, 1)
            },
            "ignoreSSL": runtime.ignore_ssl
        }
        _last_request = None
        _last_exception = None
        _now = time.time()
        _retry_times = 0
        while TeaCore.allow_retry(_runtime.get('retry'), _retry_times, _now):
            if _retry_times > 0:
                _backoff_time = TeaCore.get_backoff_time(_runtime.get('backoff'), _retry_times)
                if _backoff_time > 0:
                    TeaCore.sleep(_backoff_time)
            _retry_times = _retry_times + 1
            try:
                _request = TeaRequest()
                access_key_id = self._credential.get_access_key_id()
                access_key_secret = self._credential.get_access_key_secret()
                token = self._credential.get_security_token()
                _request.protocol = self._protocol
                _request.method = "GET"
                _request.pathname = "/" + request.object_name + ""
                _request.headers = TeaCore.merge({
                    "host": OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    "date": UtilClient.get_date_utcstring(),
                    "user-agent": self.get_user_agent()
                }, UtilClient.stringify_map_value(request.header.to_map()))
                if not UtilClient.empty(token):
                    _request.headers["x-oss-security-token"] = token
                _request.headers["authorization"] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = UtilClient.read_as_string(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        "code": resp_map.get('Code'),
                        "message": resp_map.get('Message'),
                        "data": {
                            "httpCode": _response.status_code,
                            "requestId": resp_map.get('RequestId'),
                            "hostId": resp_map.get('HostId')
                        }
                    })
                return _oss_models.GetObjectResponse().from_map(TeaCore.merge({
                    "body": _response.body
                }, _response.headers))

            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def upload_part(self, request, runtime):
        request.validate()
        runtime.validate()
        _runtime = {
            "timeouted": "retry",
            "readTimeout": UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            "connectTimeout": UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            "localAddr": UtilClient.default_string(runtime.local_addr, self._local_addr),
            "httpProxy": UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            "httpsProxy": UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            "noProxy": UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            "socks5Proxy": UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            "socks5NetWork": UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            "maxIdleConns": UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            "retry": {
                "retryable": runtime.autoretry,
                "maxAttempts": UtilClient.default_number(runtime.max_attempts, 3)
            },
            "backoff": {
                "policy": UtilClient.default_string(runtime.backoff_policy, "no"),
                "period": UtilClient.default_number(runtime.backoff_period, 1)
            },
            "ignoreSSL": runtime.ignore_ssl
        }
        _last_request = None
        _last_exception = None
        _now = time.time()
        _retry_times = 0
        while TeaCore.allow_retry(_runtime.get('retry'), _retry_times, _now):
            if _retry_times > 0:
                _backoff_time = TeaCore.get_backoff_time(_runtime.get('backoff'), _retry_times)
                if _backoff_time > 0:
                    TeaCore.sleep(_backoff_time)
            _retry_times = _retry_times + 1
            try:
                _request = TeaRequest()
                ctx = {}
                access_key_id = self._credential.get_access_key_id()
                access_key_secret = self._credential.get_access_key_secret()
                token = self._credential.get_security_token()
                _request.protocol = self._protocol
                _request.method = "PUT"
                _request.pathname = "/" + request.object_name + ""
                _request.headers = {
                    "host": OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    "date": UtilClient.get_date_utcstring(),
                    "user-agent": self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers["x-oss-security-token"] = token
                _request.query = UtilClient.stringify_map_value(request.filter.to_map())
                _request.body = OSSUtilClient.inject(request.body, ctx)
                _request.headers["authorization"] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = UtilClient.read_as_string(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        "code": resp_map.get('Code'),
                        "message": resp_map.get('Message'),
                        "data": {
                            "httpCode": _response.status_code,
                            "requestId": resp_map.get('RequestId'),
                            "hostId": resp_map.get('HostId')
                        }
                    })
                if self._is_enable_crc and not UtilClient.equal_string(ctx.get('crc'), _response.headers.get('x-oss-hash-crc64ecma')):
                    raise TeaException({
                        "code": "CrcNotMatched",
                        "data": {
                            "clientCrc": ctx.get('crc'),
                            "serverCrc": _response.headers.get('x-oss-hash-crc64ecma')
                        }
                    })
                if self._is_enable_md5 and not UtilClient.equal_string(ctx.get('md5'), _response.headers.get('content-md5')):
                    raise TeaException({
                        "code": "MD5NotMatched",
                        "data": {
                            "clientMD5": ctx.get('md5'),
                            "serverMD5": _response.headers.get('content-md5')
                        }
                    })
                return _oss_models.UploadPartResponse().from_map(TeaCore.merge(_response.headers))

            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def get_bucket_cors(self, request, runtime):
        request.validate()
        runtime.validate()
        _runtime = {
            "timeouted": "retry",
            "readTimeout": UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            "connectTimeout": UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            "localAddr": UtilClient.default_string(runtime.local_addr, self._local_addr),
            "httpProxy": UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            "httpsProxy": UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            "noProxy": UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            "socks5Proxy": UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            "socks5NetWork": UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            "maxIdleConns": UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            "retry": {
                "retryable": runtime.autoretry,
                "maxAttempts": UtilClient.default_number(runtime.max_attempts, 3)
            },
            "backoff": {
                "policy": UtilClient.default_string(runtime.backoff_policy, "no"),
                "period": UtilClient.default_number(runtime.backoff_period, 1)
            },
            "ignoreSSL": runtime.ignore_ssl
        }
        _last_request = None
        _last_exception = None
        _now = time.time()
        _retry_times = 0
        while TeaCore.allow_retry(_runtime.get('retry'), _retry_times, _now):
            if _retry_times > 0:
                _backoff_time = TeaCore.get_backoff_time(_runtime.get('backoff'), _retry_times)
                if _backoff_time > 0:
                    TeaCore.sleep(_backoff_time)
            _retry_times = _retry_times + 1
            try:
                _request = TeaRequest()
                access_key_id = self._credential.get_access_key_id()
                access_key_secret = self._credential.get_access_key_secret()
                token = self._credential.get_security_token()
                _request.protocol = self._protocol
                _request.method = "GET"
                _request.pathname = "/?cors"
                _request.headers = {
                    "host": OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    "date": UtilClient.get_date_utcstring(),
                    "user-agent": self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers["x-oss-security-token"] = token
                _request.headers["authorization"] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = UtilClient.read_as_string(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        "code": resp_map.get('Code'),
                        "message": resp_map.get('Message'),
                        "data": {
                            "httpCode": _response.status_code,
                            "requestId": resp_map.get('RequestId'),
                            "hostId": resp_map.get('HostId')
                        }
                    })
                body_str = UtilClient.read_as_string(_response.body)
                resp_map = XMLClient.parse_xml(body_str, _oss_models.GetBucketCORSResponse())
                return _oss_models.GetBucketCORSResponse().from_map(TeaCore.merge({
                    "CORSConfiguration": resp_map.get('CORSConfiguration')
                }, _response.headers))

            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def copy_object(self, request, runtime):
        request.validate()
        runtime.validate()
        _runtime = {
            "timeouted": "retry",
            "readTimeout": UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            "connectTimeout": UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            "localAddr": UtilClient.default_string(runtime.local_addr, self._local_addr),
            "httpProxy": UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            "httpsProxy": UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            "noProxy": UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            "socks5Proxy": UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            "socks5NetWork": UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            "maxIdleConns": UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            "retry": {
                "retryable": runtime.autoretry,
                "maxAttempts": UtilClient.default_number(runtime.max_attempts, 3)
            },
            "backoff": {
                "policy": UtilClient.default_string(runtime.backoff_policy, "no"),
                "period": UtilClient.default_number(runtime.backoff_period, 1)
            },
            "ignoreSSL": runtime.ignore_ssl
        }
        _last_request = None
        _last_exception = None
        _now = time.time()
        _retry_times = 0
        while TeaCore.allow_retry(_runtime.get('retry'), _retry_times, _now):
            if _retry_times > 0:
                _backoff_time = TeaCore.get_backoff_time(_runtime.get('backoff'), _retry_times)
                if _backoff_time > 0:
                    TeaCore.sleep(_backoff_time)
            _retry_times = _retry_times + 1
            try:
                _request = TeaRequest()
                access_key_id = self._credential.get_access_key_id()
                access_key_secret = self._credential.get_access_key_secret()
                token = self._credential.get_security_token()
                _request.protocol = self._protocol
                _request.method = "PUT"
                _request.pathname = "/" + request.dest_object_name + ""
                _request.headers = TeaCore.merge({
                    "host": OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    "date": UtilClient.get_date_utcstring(),
                    "user-agent": self.get_user_agent()
                }, UtilClient.stringify_map_value(request.header.to_map()))
                if not UtilClient.empty(token):
                    _request.headers["x-oss-security-token"] = token
                _request.headers["x-oss-copy-source"] = OSSUtilClient.encode(_request.headers.get('x-oss-copy-source'), "UrlEncode")
                _request.headers["authorization"] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = UtilClient.read_as_string(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        "code": resp_map.get('Code'),
                        "message": resp_map.get('Message'),
                        "data": {
                            "httpCode": _response.status_code,
                            "requestId": resp_map.get('RequestId'),
                            "hostId": resp_map.get('HostId')
                        }
                    })
                body_str = UtilClient.read_as_string(_response.body)
                resp_map = XMLClient.parse_xml(body_str, _oss_models.CopyObjectResponse())
                return _oss_models.CopyObjectResponse().from_map(TeaCore.merge({
                    "CopyObjectResult": resp_map.get('CopyObjectResult')
                }, _response.headers))

            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def get_object_tagging(self, request, runtime):
        request.validate()
        runtime.validate()
        _runtime = {
            "timeouted": "retry",
            "readTimeout": UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            "connectTimeout": UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            "localAddr": UtilClient.default_string(runtime.local_addr, self._local_addr),
            "httpProxy": UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            "httpsProxy": UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            "noProxy": UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            "socks5Proxy": UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            "socks5NetWork": UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            "maxIdleConns": UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            "retry": {
                "retryable": runtime.autoretry,
                "maxAttempts": UtilClient.default_number(runtime.max_attempts, 3)
            },
            "backoff": {
                "policy": UtilClient.default_string(runtime.backoff_policy, "no"),
                "period": UtilClient.default_number(runtime.backoff_period, 1)
            },
            "ignoreSSL": runtime.ignore_ssl
        }
        _last_request = None
        _last_exception = None
        _now = time.time()
        _retry_times = 0
        while TeaCore.allow_retry(_runtime.get('retry'), _retry_times, _now):
            if _retry_times > 0:
                _backoff_time = TeaCore.get_backoff_time(_runtime.get('backoff'), _retry_times)
                if _backoff_time > 0:
                    TeaCore.sleep(_backoff_time)
            _retry_times = _retry_times + 1
            try:
                _request = TeaRequest()
                access_key_id = self._credential.get_access_key_id()
                access_key_secret = self._credential.get_access_key_secret()
                token = self._credential.get_security_token()
                _request.protocol = self._protocol
                _request.method = "GET"
                _request.pathname = "/" + request.object_name + "?tagging"
                _request.headers = {
                    "host": OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    "date": UtilClient.get_date_utcstring(),
                    "user-agent": self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers["x-oss-security-token"] = token
                _request.headers["authorization"] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = UtilClient.read_as_string(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        "code": resp_map.get('Code'),
                        "message": resp_map.get('Message'),
                        "data": {
                            "httpCode": _response.status_code,
                            "requestId": resp_map.get('RequestId'),
                            "hostId": resp_map.get('HostId')
                        }
                    })
                body_str = UtilClient.read_as_string(_response.body)
                resp_map = XMLClient.parse_xml(body_str, _oss_models.GetObjectTaggingResponse())
                return _oss_models.GetObjectTaggingResponse().from_map(TeaCore.merge({
                    "Tagging": resp_map.get('Tagging')
                }, _response.headers))

            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def delete_bucket_lifecycle(self, request, runtime):
        request.validate()
        runtime.validate()
        _runtime = {
            "timeouted": "retry",
            "readTimeout": UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            "connectTimeout": UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            "localAddr": UtilClient.default_string(runtime.local_addr, self._local_addr),
            "httpProxy": UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            "httpsProxy": UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            "noProxy": UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            "socks5Proxy": UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            "socks5NetWork": UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            "maxIdleConns": UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            "retry": {
                "retryable": runtime.autoretry,
                "maxAttempts": UtilClient.default_number(runtime.max_attempts, 3)
            },
            "backoff": {
                "policy": UtilClient.default_string(runtime.backoff_policy, "no"),
                "period": UtilClient.default_number(runtime.backoff_period, 1)
            },
            "ignoreSSL": runtime.ignore_ssl
        }
        _last_request = None
        _last_exception = None
        _now = time.time()
        _retry_times = 0
        while TeaCore.allow_retry(_runtime.get('retry'), _retry_times, _now):
            if _retry_times > 0:
                _backoff_time = TeaCore.get_backoff_time(_runtime.get('backoff'), _retry_times)
                if _backoff_time > 0:
                    TeaCore.sleep(_backoff_time)
            _retry_times = _retry_times + 1
            try:
                _request = TeaRequest()
                access_key_id = self._credential.get_access_key_id()
                access_key_secret = self._credential.get_access_key_secret()
                token = self._credential.get_security_token()
                _request.protocol = self._protocol
                _request.method = "DELETE"
                _request.pathname = "/?lifecycle"
                _request.headers = {
                    "host": OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    "date": UtilClient.get_date_utcstring(),
                    "user-agent": self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers["x-oss-security-token"] = token
                _request.headers["authorization"] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = UtilClient.read_as_string(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        "code": resp_map.get('Code'),
                        "message": resp_map.get('Message'),
                        "data": {
                            "httpCode": _response.status_code,
                            "requestId": resp_map.get('RequestId'),
                            "hostId": resp_map.get('HostId')
                        }
                    })
                return _oss_models.DeleteBucketLifecycleResponse().from_map(TeaCore.merge(_response.headers))

            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def delete_bucket_logging(self, request, runtime):
        request.validate()
        runtime.validate()
        _runtime = {
            "timeouted": "retry",
            "readTimeout": UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            "connectTimeout": UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            "localAddr": UtilClient.default_string(runtime.local_addr, self._local_addr),
            "httpProxy": UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            "httpsProxy": UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            "noProxy": UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            "socks5Proxy": UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            "socks5NetWork": UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            "maxIdleConns": UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            "retry": {
                "retryable": runtime.autoretry,
                "maxAttempts": UtilClient.default_number(runtime.max_attempts, 3)
            },
            "backoff": {
                "policy": UtilClient.default_string(runtime.backoff_policy, "no"),
                "period": UtilClient.default_number(runtime.backoff_period, 1)
            },
            "ignoreSSL": runtime.ignore_ssl
        }
        _last_request = None
        _last_exception = None
        _now = time.time()
        _retry_times = 0
        while TeaCore.allow_retry(_runtime.get('retry'), _retry_times, _now):
            if _retry_times > 0:
                _backoff_time = TeaCore.get_backoff_time(_runtime.get('backoff'), _retry_times)
                if _backoff_time > 0:
                    TeaCore.sleep(_backoff_time)
            _retry_times = _retry_times + 1
            try:
                _request = TeaRequest()
                access_key_id = self._credential.get_access_key_id()
                access_key_secret = self._credential.get_access_key_secret()
                token = self._credential.get_security_token()
                _request.protocol = self._protocol
                _request.method = "DELETE"
                _request.pathname = "/?logging"
                _request.headers = {
                    "host": OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    "date": UtilClient.get_date_utcstring(),
                    "user-agent": self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers["x-oss-security-token"] = token
                _request.headers["authorization"] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = UtilClient.read_as_string(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        "code": resp_map.get('Code'),
                        "message": resp_map.get('Message'),
                        "data": {
                            "httpCode": _response.status_code,
                            "requestId": resp_map.get('RequestId'),
                            "hostId": resp_map.get('HostId')
                        }
                    })
                return _oss_models.DeleteBucketLoggingResponse().from_map(TeaCore.merge(_response.headers))

            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def delete_bucket_website(self, request, runtime):
        request.validate()
        runtime.validate()
        _runtime = {
            "timeouted": "retry",
            "readTimeout": UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            "connectTimeout": UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            "localAddr": UtilClient.default_string(runtime.local_addr, self._local_addr),
            "httpProxy": UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            "httpsProxy": UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            "noProxy": UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            "socks5Proxy": UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            "socks5NetWork": UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            "maxIdleConns": UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            "retry": {
                "retryable": runtime.autoretry,
                "maxAttempts": UtilClient.default_number(runtime.max_attempts, 3)
            },
            "backoff": {
                "policy": UtilClient.default_string(runtime.backoff_policy, "no"),
                "period": UtilClient.default_number(runtime.backoff_period, 1)
            },
            "ignoreSSL": runtime.ignore_ssl
        }
        _last_request = None
        _last_exception = None
        _now = time.time()
        _retry_times = 0
        while TeaCore.allow_retry(_runtime.get('retry'), _retry_times, _now):
            if _retry_times > 0:
                _backoff_time = TeaCore.get_backoff_time(_runtime.get('backoff'), _retry_times)
                if _backoff_time > 0:
                    TeaCore.sleep(_backoff_time)
            _retry_times = _retry_times + 1
            try:
                _request = TeaRequest()
                access_key_id = self._credential.get_access_key_id()
                access_key_secret = self._credential.get_access_key_secret()
                token = self._credential.get_security_token()
                _request.protocol = self._protocol
                _request.method = "DELETE"
                _request.pathname = "/?website"
                _request.headers = {
                    "host": OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    "date": UtilClient.get_date_utcstring(),
                    "user-agent": self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers["x-oss-security-token"] = token
                _request.headers["authorization"] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = UtilClient.read_as_string(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        "code": resp_map.get('Code'),
                        "message": resp_map.get('Message'),
                        "data": {
                            "httpCode": _response.status_code,
                            "requestId": resp_map.get('RequestId'),
                            "hostId": resp_map.get('HostId')
                        }
                    })
                return _oss_models.DeleteBucketWebsiteResponse().from_map(TeaCore.merge(_response.headers))

            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def get_symlink(self, request, runtime):
        request.validate()
        runtime.validate()
        _runtime = {
            "timeouted": "retry",
            "readTimeout": UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            "connectTimeout": UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            "localAddr": UtilClient.default_string(runtime.local_addr, self._local_addr),
            "httpProxy": UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            "httpsProxy": UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            "noProxy": UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            "socks5Proxy": UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            "socks5NetWork": UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            "maxIdleConns": UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            "retry": {
                "retryable": runtime.autoretry,
                "maxAttempts": UtilClient.default_number(runtime.max_attempts, 3)
            },
            "backoff": {
                "policy": UtilClient.default_string(runtime.backoff_policy, "no"),
                "period": UtilClient.default_number(runtime.backoff_period, 1)
            },
            "ignoreSSL": runtime.ignore_ssl
        }
        _last_request = None
        _last_exception = None
        _now = time.time()
        _retry_times = 0
        while TeaCore.allow_retry(_runtime.get('retry'), _retry_times, _now):
            if _retry_times > 0:
                _backoff_time = TeaCore.get_backoff_time(_runtime.get('backoff'), _retry_times)
                if _backoff_time > 0:
                    TeaCore.sleep(_backoff_time)
            _retry_times = _retry_times + 1
            try:
                _request = TeaRequest()
                access_key_id = self._credential.get_access_key_id()
                access_key_secret = self._credential.get_access_key_secret()
                token = self._credential.get_security_token()
                _request.protocol = self._protocol
                _request.method = "GET"
                _request.pathname = "/" + request.object_name + "?symlink"
                _request.headers = {
                    "host": OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    "date": UtilClient.get_date_utcstring(),
                    "user-agent": self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers["x-oss-security-token"] = token
                _request.headers["authorization"] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = UtilClient.read_as_string(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        "code": resp_map.get('Code'),
                        "message": resp_map.get('Message'),
                        "data": {
                            "httpCode": _response.status_code,
                            "requestId": resp_map.get('RequestId'),
                            "hostId": resp_map.get('HostId')
                        }
                    })
                return _oss_models.GetSymlinkResponse().from_map(TeaCore.merge(_response.headers))

            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def get_bucket_lifecycle(self, request, runtime):
        request.validate()
        runtime.validate()
        _runtime = {
            "timeouted": "retry",
            "readTimeout": UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            "connectTimeout": UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            "localAddr": UtilClient.default_string(runtime.local_addr, self._local_addr),
            "httpProxy": UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            "httpsProxy": UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            "noProxy": UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            "socks5Proxy": UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            "socks5NetWork": UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            "maxIdleConns": UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            "retry": {
                "retryable": runtime.autoretry,
                "maxAttempts": UtilClient.default_number(runtime.max_attempts, 3)
            },
            "backoff": {
                "policy": UtilClient.default_string(runtime.backoff_policy, "no"),
                "period": UtilClient.default_number(runtime.backoff_period, 1)
            },
            "ignoreSSL": runtime.ignore_ssl
        }
        _last_request = None
        _last_exception = None
        _now = time.time()
        _retry_times = 0
        while TeaCore.allow_retry(_runtime.get('retry'), _retry_times, _now):
            if _retry_times > 0:
                _backoff_time = TeaCore.get_backoff_time(_runtime.get('backoff'), _retry_times)
                if _backoff_time > 0:
                    TeaCore.sleep(_backoff_time)
            _retry_times = _retry_times + 1
            try:
                _request = TeaRequest()
                access_key_id = self._credential.get_access_key_id()
                access_key_secret = self._credential.get_access_key_secret()
                token = self._credential.get_security_token()
                _request.protocol = self._protocol
                _request.method = "GET"
                _request.pathname = "/?lifecycle"
                _request.headers = {
                    "host": OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    "date": UtilClient.get_date_utcstring(),
                    "user-agent": self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers["x-oss-security-token"] = token
                _request.headers["authorization"] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = UtilClient.read_as_string(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        "code": resp_map.get('Code'),
                        "message": resp_map.get('Message'),
                        "data": {
                            "httpCode": _response.status_code,
                            "requestId": resp_map.get('RequestId'),
                            "hostId": resp_map.get('HostId')
                        }
                    })
                body_str = UtilClient.read_as_string(_response.body)
                resp_map = XMLClient.parse_xml(body_str, _oss_models.GetBucketLifecycleResponse())
                return _oss_models.GetBucketLifecycleResponse().from_map(TeaCore.merge({
                    "LifecycleConfiguration": resp_map.get('LifecycleConfiguration')
                }, _response.headers))

            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def put_symlink(self, request, runtime):
        request.validate()
        runtime.validate()
        _runtime = {
            "timeouted": "retry",
            "readTimeout": UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            "connectTimeout": UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            "localAddr": UtilClient.default_string(runtime.local_addr, self._local_addr),
            "httpProxy": UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            "httpsProxy": UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            "noProxy": UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            "socks5Proxy": UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            "socks5NetWork": UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            "maxIdleConns": UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            "retry": {
                "retryable": runtime.autoretry,
                "maxAttempts": UtilClient.default_number(runtime.max_attempts, 3)
            },
            "backoff": {
                "policy": UtilClient.default_string(runtime.backoff_policy, "no"),
                "period": UtilClient.default_number(runtime.backoff_period, 1)
            },
            "ignoreSSL": runtime.ignore_ssl
        }
        _last_request = None
        _last_exception = None
        _now = time.time()
        _retry_times = 0
        while TeaCore.allow_retry(_runtime.get('retry'), _retry_times, _now):
            if _retry_times > 0:
                _backoff_time = TeaCore.get_backoff_time(_runtime.get('backoff'), _retry_times)
                if _backoff_time > 0:
                    TeaCore.sleep(_backoff_time)
            _retry_times = _retry_times + 1
            try:
                _request = TeaRequest()
                access_key_id = self._credential.get_access_key_id()
                access_key_secret = self._credential.get_access_key_secret()
                token = self._credential.get_security_token()
                _request.protocol = self._protocol
                _request.method = "PUT"
                _request.pathname = "/" + request.object_name + "?symlink"
                _request.headers = TeaCore.merge({
                    "host": OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    "date": UtilClient.get_date_utcstring(),
                    "user-agent": self.get_user_agent()
                }, UtilClient.stringify_map_value(request.header.to_map()))
                if not UtilClient.empty(token):
                    _request.headers["x-oss-security-token"] = token
                _request.headers["authorization"] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = UtilClient.read_as_string(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        "code": resp_map.get('Code'),
                        "message": resp_map.get('Message'),
                        "data": {
                            "httpCode": _response.status_code,
                            "requestId": resp_map.get('RequestId'),
                            "hostId": resp_map.get('HostId')
                        }
                    })
                return _oss_models.PutSymlinkResponse().from_map(TeaCore.merge(_response.headers))

            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def get_bucket_referer(self, request, runtime):
        request.validate()
        runtime.validate()
        _runtime = {
            "timeouted": "retry",
            "readTimeout": UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            "connectTimeout": UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            "localAddr": UtilClient.default_string(runtime.local_addr, self._local_addr),
            "httpProxy": UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            "httpsProxy": UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            "noProxy": UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            "socks5Proxy": UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            "socks5NetWork": UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            "maxIdleConns": UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            "retry": {
                "retryable": runtime.autoretry,
                "maxAttempts": UtilClient.default_number(runtime.max_attempts, 3)
            },
            "backoff": {
                "policy": UtilClient.default_string(runtime.backoff_policy, "no"),
                "period": UtilClient.default_number(runtime.backoff_period, 1)
            },
            "ignoreSSL": runtime.ignore_ssl
        }
        _last_request = None
        _last_exception = None
        _now = time.time()
        _retry_times = 0
        while TeaCore.allow_retry(_runtime.get('retry'), _retry_times, _now):
            if _retry_times > 0:
                _backoff_time = TeaCore.get_backoff_time(_runtime.get('backoff'), _retry_times)
                if _backoff_time > 0:
                    TeaCore.sleep(_backoff_time)
            _retry_times = _retry_times + 1
            try:
                _request = TeaRequest()
                access_key_id = self._credential.get_access_key_id()
                access_key_secret = self._credential.get_access_key_secret()
                token = self._credential.get_security_token()
                _request.protocol = self._protocol
                _request.method = "GET"
                _request.pathname = "/?referer"
                _request.headers = {
                    "host": OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    "date": UtilClient.get_date_utcstring(),
                    "user-agent": self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers["x-oss-security-token"] = token
                _request.headers["authorization"] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = UtilClient.read_as_string(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        "code": resp_map.get('Code'),
                        "message": resp_map.get('Message'),
                        "data": {
                            "httpCode": _response.status_code,
                            "requestId": resp_map.get('RequestId'),
                            "hostId": resp_map.get('HostId')
                        }
                    })
                body_str = UtilClient.read_as_string(_response.body)
                resp_map = XMLClient.parse_xml(body_str, _oss_models.GetBucketRefererResponse())
                return _oss_models.GetBucketRefererResponse().from_map(TeaCore.merge({
                    "RefererConfiguration": resp_map.get('RefererConfiguration')
                }, _response.headers))

            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def callback(self, request, runtime):
        request.validate()
        runtime.validate()
        _runtime = {
            "timeouted": "retry",
            "readTimeout": UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            "connectTimeout": UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            "localAddr": UtilClient.default_string(runtime.local_addr, self._local_addr),
            "httpProxy": UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            "httpsProxy": UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            "noProxy": UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            "socks5Proxy": UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            "socks5NetWork": UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            "maxIdleConns": UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            "retry": {
                "retryable": runtime.autoretry,
                "maxAttempts": UtilClient.default_number(runtime.max_attempts, 3)
            },
            "backoff": {
                "policy": UtilClient.default_string(runtime.backoff_policy, "no"),
                "period": UtilClient.default_number(runtime.backoff_period, 1)
            },
            "ignoreSSL": runtime.ignore_ssl
        }
        _last_request = None
        _last_exception = None
        _now = time.time()
        _retry_times = 0
        while TeaCore.allow_retry(_runtime.get('retry'), _retry_times, _now):
            if _retry_times > 0:
                _backoff_time = TeaCore.get_backoff_time(_runtime.get('backoff'), _retry_times)
                if _backoff_time > 0:
                    TeaCore.sleep(_backoff_time)
            _retry_times = _retry_times + 1
            try:
                _request = TeaRequest()
                access_key_id = self._credential.get_access_key_id()
                access_key_secret = self._credential.get_access_key_secret()
                token = self._credential.get_security_token()
                _request.protocol = self._protocol
                _request.method = "GET"
                _request.pathname = "/"
                _request.headers = {
                    "host": OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    "date": UtilClient.get_date_utcstring(),
                    "user-agent": self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers["x-oss-security-token"] = token
                _request.headers["authorization"] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = UtilClient.read_as_string(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        "code": resp_map.get('Code'),
                        "message": resp_map.get('Message'),
                        "data": {
                            "httpCode": _response.status_code,
                            "requestId": resp_map.get('RequestId'),
                            "hostId": resp_map.get('HostId')
                        }
                    })
                return _oss_models.CallbackResponse().from_map(TeaCore.merge(_response.headers))

            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def get_bucket_logging(self, request, runtime):
        request.validate()
        runtime.validate()
        _runtime = {
            "timeouted": "retry",
            "readTimeout": UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            "connectTimeout": UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            "localAddr": UtilClient.default_string(runtime.local_addr, self._local_addr),
            "httpProxy": UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            "httpsProxy": UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            "noProxy": UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            "socks5Proxy": UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            "socks5NetWork": UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            "maxIdleConns": UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            "retry": {
                "retryable": runtime.autoretry,
                "maxAttempts": UtilClient.default_number(runtime.max_attempts, 3)
            },
            "backoff": {
                "policy": UtilClient.default_string(runtime.backoff_policy, "no"),
                "period": UtilClient.default_number(runtime.backoff_period, 1)
            },
            "ignoreSSL": runtime.ignore_ssl
        }
        _last_request = None
        _last_exception = None
        _now = time.time()
        _retry_times = 0
        while TeaCore.allow_retry(_runtime.get('retry'), _retry_times, _now):
            if _retry_times > 0:
                _backoff_time = TeaCore.get_backoff_time(_runtime.get('backoff'), _retry_times)
                if _backoff_time > 0:
                    TeaCore.sleep(_backoff_time)
            _retry_times = _retry_times + 1
            try:
                _request = TeaRequest()
                access_key_id = self._credential.get_access_key_id()
                access_key_secret = self._credential.get_access_key_secret()
                token = self._credential.get_security_token()
                _request.protocol = self._protocol
                _request.method = "GET"
                _request.pathname = "/?logging"
                _request.headers = {
                    "host": OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    "date": UtilClient.get_date_utcstring(),
                    "user-agent": self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers["x-oss-security-token"] = token
                _request.headers["authorization"] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = UtilClient.read_as_string(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        "code": resp_map.get('Code'),
                        "message": resp_map.get('Message'),
                        "data": {
                            "httpCode": _response.status_code,
                            "requestId": resp_map.get('RequestId'),
                            "hostId": resp_map.get('HostId')
                        }
                    })
                body_str = UtilClient.read_as_string(_response.body)
                resp_map = XMLClient.parse_xml(body_str, _oss_models.GetBucketLoggingResponse())
                return _oss_models.GetBucketLoggingResponse().from_map(TeaCore.merge({
                    "BucketLoggingStatus": resp_map.get('BucketLoggingStatus')
                }, _response.headers))

            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def put_object_acl(self, request, runtime):
        request.validate()
        runtime.validate()
        _runtime = {
            "timeouted": "retry",
            "readTimeout": UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            "connectTimeout": UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            "localAddr": UtilClient.default_string(runtime.local_addr, self._local_addr),
            "httpProxy": UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            "httpsProxy": UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            "noProxy": UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            "socks5Proxy": UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            "socks5NetWork": UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            "maxIdleConns": UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            "retry": {
                "retryable": runtime.autoretry,
                "maxAttempts": UtilClient.default_number(runtime.max_attempts, 3)
            },
            "backoff": {
                "policy": UtilClient.default_string(runtime.backoff_policy, "no"),
                "period": UtilClient.default_number(runtime.backoff_period, 1)
            },
            "ignoreSSL": runtime.ignore_ssl
        }
        _last_request = None
        _last_exception = None
        _now = time.time()
        _retry_times = 0
        while TeaCore.allow_retry(_runtime.get('retry'), _retry_times, _now):
            if _retry_times > 0:
                _backoff_time = TeaCore.get_backoff_time(_runtime.get('backoff'), _retry_times)
                if _backoff_time > 0:
                    TeaCore.sleep(_backoff_time)
            _retry_times = _retry_times + 1
            try:
                _request = TeaRequest()
                access_key_id = self._credential.get_access_key_id()
                access_key_secret = self._credential.get_access_key_secret()
                token = self._credential.get_security_token()
                _request.protocol = self._protocol
                _request.method = "PUT"
                _request.pathname = "/" + request.object_name + "?acl"
                _request.headers = TeaCore.merge({
                    "host": OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    "date": UtilClient.get_date_utcstring(),
                    "user-agent": self.get_user_agent()
                }, UtilClient.stringify_map_value(request.header.to_map()))
                if not UtilClient.empty(token):
                    _request.headers["x-oss-security-token"] = token
                _request.headers["authorization"] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = UtilClient.read_as_string(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        "code": resp_map.get('Code'),
                        "message": resp_map.get('Message'),
                        "data": {
                            "httpCode": _response.status_code,
                            "requestId": resp_map.get('RequestId'),
                            "hostId": resp_map.get('HostId')
                        }
                    })
                return _oss_models.PutObjectAclResponse().from_map(TeaCore.merge(_response.headers))

            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def get_bucket_info(self, request, runtime):
        request.validate()
        runtime.validate()
        _runtime = {
            "timeouted": "retry",
            "readTimeout": UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            "connectTimeout": UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            "localAddr": UtilClient.default_string(runtime.local_addr, self._local_addr),
            "httpProxy": UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            "httpsProxy": UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            "noProxy": UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            "socks5Proxy": UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            "socks5NetWork": UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            "maxIdleConns": UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            "retry": {
                "retryable": runtime.autoretry,
                "maxAttempts": UtilClient.default_number(runtime.max_attempts, 3)
            },
            "backoff": {
                "policy": UtilClient.default_string(runtime.backoff_policy, "no"),
                "period": UtilClient.default_number(runtime.backoff_period, 1)
            },
            "ignoreSSL": runtime.ignore_ssl
        }
        _last_request = None
        _last_exception = None
        _now = time.time()
        _retry_times = 0
        while TeaCore.allow_retry(_runtime.get('retry'), _retry_times, _now):
            if _retry_times > 0:
                _backoff_time = TeaCore.get_backoff_time(_runtime.get('backoff'), _retry_times)
                if _backoff_time > 0:
                    TeaCore.sleep(_backoff_time)
            _retry_times = _retry_times + 1
            try:
                _request = TeaRequest()
                access_key_id = self._credential.get_access_key_id()
                access_key_secret = self._credential.get_access_key_secret()
                token = self._credential.get_security_token()
                _request.protocol = self._protocol
                _request.method = "GET"
                _request.pathname = "/?bucketInfo"
                _request.headers = {
                    "host": OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    "date": UtilClient.get_date_utcstring(),
                    "user-agent": self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers["x-oss-security-token"] = token
                _request.headers["authorization"] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = UtilClient.read_as_string(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        "code": resp_map.get('Code'),
                        "message": resp_map.get('Message'),
                        "data": {
                            "httpCode": _response.status_code,
                            "requestId": resp_map.get('RequestId'),
                            "hostId": resp_map.get('HostId')
                        }
                    })
                body_str = UtilClient.read_as_string(_response.body)
                resp_map = XMLClient.parse_xml(body_str, _oss_models.GetBucketInfoResponse())
                return _oss_models.GetBucketInfoResponse().from_map(TeaCore.merge({
                    "BucketInfo": resp_map.get('BucketInfo')
                }, _response.headers))

            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def put_live_channel_status(self, request, runtime):
        request.validate()
        runtime.validate()
        _runtime = {
            "timeouted": "retry",
            "readTimeout": UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            "connectTimeout": UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            "localAddr": UtilClient.default_string(runtime.local_addr, self._local_addr),
            "httpProxy": UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            "httpsProxy": UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            "noProxy": UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            "socks5Proxy": UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            "socks5NetWork": UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            "maxIdleConns": UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            "retry": {
                "retryable": runtime.autoretry,
                "maxAttempts": UtilClient.default_number(runtime.max_attempts, 3)
            },
            "backoff": {
                "policy": UtilClient.default_string(runtime.backoff_policy, "no"),
                "period": UtilClient.default_number(runtime.backoff_period, 1)
            },
            "ignoreSSL": runtime.ignore_ssl
        }
        _last_request = None
        _last_exception = None
        _now = time.time()
        _retry_times = 0
        while TeaCore.allow_retry(_runtime.get('retry'), _retry_times, _now):
            if _retry_times > 0:
                _backoff_time = TeaCore.get_backoff_time(_runtime.get('backoff'), _retry_times)
                if _backoff_time > 0:
                    TeaCore.sleep(_backoff_time)
            _retry_times = _retry_times + 1
            try:
                _request = TeaRequest()
                access_key_id = self._credential.get_access_key_id()
                access_key_secret = self._credential.get_access_key_secret()
                token = self._credential.get_security_token()
                _request.protocol = self._protocol
                _request.method = "PUT"
                _request.pathname = "/" + request.channel_name + "?live"
                _request.headers = {
                    "host": OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    "date": UtilClient.get_date_utcstring(),
                    "user-agent": self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers["x-oss-security-token"] = token
                _request.query = UtilClient.stringify_map_value(request.filter.to_map())
                _request.headers["authorization"] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = UtilClient.read_as_string(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        "code": resp_map.get('Code'),
                        "message": resp_map.get('Message'),
                        "data": {
                            "httpCode": _response.status_code,
                            "requestId": resp_map.get('RequestId'),
                            "hostId": resp_map.get('HostId')
                        }
                    })
                return _oss_models.PutLiveChannelStatusResponse().from_map(TeaCore.merge(_response.headers))

            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def initiate_multipart_upload(self, request, runtime):
        request.validate()
        runtime.validate()
        _runtime = {
            "timeouted": "retry",
            "readTimeout": UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            "connectTimeout": UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            "localAddr": UtilClient.default_string(runtime.local_addr, self._local_addr),
            "httpProxy": UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            "httpsProxy": UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            "noProxy": UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            "socks5Proxy": UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            "socks5NetWork": UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            "maxIdleConns": UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            "retry": {
                "retryable": runtime.autoretry,
                "maxAttempts": UtilClient.default_number(runtime.max_attempts, 3)
            },
            "backoff": {
                "policy": UtilClient.default_string(runtime.backoff_policy, "no"),
                "period": UtilClient.default_number(runtime.backoff_period, 1)
            },
            "ignoreSSL": runtime.ignore_ssl
        }
        _last_request = None
        _last_exception = None
        _now = time.time()
        _retry_times = 0
        while TeaCore.allow_retry(_runtime.get('retry'), _retry_times, _now):
            if _retry_times > 0:
                _backoff_time = TeaCore.get_backoff_time(_runtime.get('backoff'), _retry_times)
                if _backoff_time > 0:
                    TeaCore.sleep(_backoff_time)
            _retry_times = _retry_times + 1
            try:
                _request = TeaRequest()
                access_key_id = self._credential.get_access_key_id()
                access_key_secret = self._credential.get_access_key_secret()
                token = self._credential.get_security_token()
                _request.protocol = self._protocol
                _request.method = "POST"
                _request.pathname = "/" + request.object_name + "?uploads"
                _request.headers = TeaCore.merge({
                    "host": OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    "date": UtilClient.get_date_utcstring(),
                    "user-agent": self.get_user_agent()
                }, UtilClient.stringify_map_value(request.header.to_map()))
                if not UtilClient.empty(token):
                    _request.headers["x-oss-security-token"] = token
                _request.query = UtilClient.stringify_map_value(request.filter.to_map())
                if not UtilClient.is_unset(request.header.to_map()) and not UtilClient.empty(request.header.content_type):
                    _request.headers["content-type"] = request.header.content_type
                else:
                    _request.headers["content-type"] = OSSUtilClient.get_content_type(request.object_name)
                _request.headers["authorization"] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = UtilClient.read_as_string(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        "code": resp_map.get('Code'),
                        "message": resp_map.get('Message'),
                        "data": {
                            "httpCode": _response.status_code,
                            "requestId": resp_map.get('RequestId'),
                            "hostId": resp_map.get('HostId')
                        }
                    })
                body_str = UtilClient.read_as_string(_response.body)
                resp_map = XMLClient.parse_xml(body_str, _oss_models.InitiateMultipartUploadResponse())
                return _oss_models.InitiateMultipartUploadResponse().from_map(TeaCore.merge({
                    "InitiateMultipartUploadResult": resp_map.get('InitiateMultipartUploadResult')
                }, _response.headers))

            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def option_object(self, request, runtime):
        request.validate()
        runtime.validate()
        _runtime = {
            "timeouted": "retry",
            "readTimeout": UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            "connectTimeout": UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            "localAddr": UtilClient.default_string(runtime.local_addr, self._local_addr),
            "httpProxy": UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            "httpsProxy": UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            "noProxy": UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            "socks5Proxy": UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            "socks5NetWork": UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            "maxIdleConns": UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            "retry": {
                "retryable": runtime.autoretry,
                "maxAttempts": UtilClient.default_number(runtime.max_attempts, 3)
            },
            "backoff": {
                "policy": UtilClient.default_string(runtime.backoff_policy, "no"),
                "period": UtilClient.default_number(runtime.backoff_period, 1)
            },
            "ignoreSSL": runtime.ignore_ssl
        }
        _last_request = None
        _last_exception = None
        _now = time.time()
        _retry_times = 0
        while TeaCore.allow_retry(_runtime.get('retry'), _retry_times, _now):
            if _retry_times > 0:
                _backoff_time = TeaCore.get_backoff_time(_runtime.get('backoff'), _retry_times)
                if _backoff_time > 0:
                    TeaCore.sleep(_backoff_time)
            _retry_times = _retry_times + 1
            try:
                _request = TeaRequest()
                access_key_id = self._credential.get_access_key_id()
                access_key_secret = self._credential.get_access_key_secret()
                token = self._credential.get_security_token()
                _request.protocol = self._protocol
                _request.method = "OPTIONS"
                _request.pathname = "/" + request.object_name + ""
                _request.headers = TeaCore.merge({
                    "host": OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    "date": UtilClient.get_date_utcstring(),
                    "user-agent": self.get_user_agent()
                }, UtilClient.stringify_map_value(request.header.to_map()))
                if not UtilClient.empty(token):
                    _request.headers["x-oss-security-token"] = token
                _request.headers["authorization"] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = UtilClient.read_as_string(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        "code": resp_map.get('Code'),
                        "message": resp_map.get('Message'),
                        "data": {
                            "httpCode": _response.status_code,
                            "requestId": resp_map.get('RequestId'),
                            "hostId": resp_map.get('HostId')
                        }
                    })
                return _oss_models.OptionObjectResponse().from_map(TeaCore.merge(_response.headers))

            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def post_vod_playlist(self, request, runtime):
        request.validate()
        runtime.validate()
        _runtime = {
            "timeouted": "retry",
            "readTimeout": UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            "connectTimeout": UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            "localAddr": UtilClient.default_string(runtime.local_addr, self._local_addr),
            "httpProxy": UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            "httpsProxy": UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            "noProxy": UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            "socks5Proxy": UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            "socks5NetWork": UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            "maxIdleConns": UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            "retry": {
                "retryable": runtime.autoretry,
                "maxAttempts": UtilClient.default_number(runtime.max_attempts, 3)
            },
            "backoff": {
                "policy": UtilClient.default_string(runtime.backoff_policy, "no"),
                "period": UtilClient.default_number(runtime.backoff_period, 1)
            },
            "ignoreSSL": runtime.ignore_ssl
        }
        _last_request = None
        _last_exception = None
        _now = time.time()
        _retry_times = 0
        while TeaCore.allow_retry(_runtime.get('retry'), _retry_times, _now):
            if _retry_times > 0:
                _backoff_time = TeaCore.get_backoff_time(_runtime.get('backoff'), _retry_times)
                if _backoff_time > 0:
                    TeaCore.sleep(_backoff_time)
            _retry_times = _retry_times + 1
            try:
                _request = TeaRequest()
                access_key_id = self._credential.get_access_key_id()
                access_key_secret = self._credential.get_access_key_secret()
                token = self._credential.get_security_token()
                _request.protocol = self._protocol
                _request.method = "POST"
                _request.pathname = "/" + request.channel_name + "/" + request.playlist_name + "?vod"
                _request.headers = {
                    "host": OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    "date": UtilClient.get_date_utcstring(),
                    "user-agent": self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers["x-oss-security-token"] = token
                _request.query = UtilClient.stringify_map_value(request.filter.to_map())
                _request.headers["authorization"] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = UtilClient.read_as_string(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        "code": resp_map.get('Code'),
                        "message": resp_map.get('Message'),
                        "data": {
                            "httpCode": _response.status_code,
                            "requestId": resp_map.get('RequestId'),
                            "hostId": resp_map.get('HostId')
                        }
                    })
                return _oss_models.PostVodPlaylistResponse().from_map(TeaCore.merge(_response.headers))

            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def post_object(self, request, runtime):
        request.validate()
        runtime.validate()
        _runtime = {
            "timeouted": "retry",
            "readTimeout": UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            "connectTimeout": UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            "httpProxy": UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            "httpsProxy": UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            "noProxy": UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            "maxIdleConns": UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            "retry": {
                "retryable": runtime.autoretry,
                "maxAttempts": UtilClient.default_number(runtime.max_attempts, 3)
            },
            "backoff": {
                "policy": UtilClient.default_string(runtime.backoff_policy, "no"),
                "period": UtilClient.default_number(runtime.backoff_period, 1)
            },
            "ignoreSSL": runtime.ignore_ssl
        }
        _last_request = None
        _last_exception = None
        _now = time.time()
        _retry_times = 0
        while TeaCore.allow_retry(_runtime.get('retry'), _retry_times, _now):
            if _retry_times > 0:
                _backoff_time = TeaCore.get_backoff_time(_runtime.get('backoff'), _retry_times)
                if _backoff_time > 0:
                    TeaCore.sleep(_backoff_time)
            _retry_times = _retry_times + 1
            try:
                _request = TeaRequest()
                boundary = FileFormClient.get_boundary()
                _request.protocol = self._protocol
                _request.method = "POST"
                _request.pathname = "/"
                _request.headers = {
                    "host": OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    "date": UtilClient.get_date_utcstring(),
                    "user-agent": self.get_user_agent()
                }
                _request.headers["content-type"] = "multipart/form-data; boundary=" + boundary + ""
                form = TeaCore.merge({
                    "OSSAccessKeyId": request.header.access_key_id,
                    "policy": request.header.policy,
                    "Signature": request.header.signature,
                    "key": request.header.key,
                    "success_action_status": request.header.success_action_status,
                    "file": request.header.file
                }, OSSUtilClient.to_meta(request.header.user_meta, "x-oss-meta-"))
                _request.body = FileFormClient.to_file_form(form, boundary)
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                body_str = UtilClient.read_as_string(_response.body)
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        "code": resp_map.get('Code'),
                        "message": resp_map.get('Message'),
                        "data": {
                            "httpCode": _response.status_code,
                            "requestId": resp_map.get('RequestId'),
                            "hostId": resp_map.get('HostId')
                        }
                    })
                resp_map = XMLClient.parse_xml(body_str, _oss_models.PostObjectResponse())
                return _oss_models.PostObjectResponse().from_map(TeaCore.merge(resp_map))

            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def head_object(self, request, runtime):
        request.validate()
        runtime.validate()
        _runtime = {
            "timeouted": "retry",
            "readTimeout": UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            "connectTimeout": UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            "localAddr": UtilClient.default_string(runtime.local_addr, self._local_addr),
            "httpProxy": UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            "httpsProxy": UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            "noProxy": UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            "socks5Proxy": UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            "socks5NetWork": UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            "maxIdleConns": UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            "retry": {
                "retryable": runtime.autoretry,
                "maxAttempts": UtilClient.default_number(runtime.max_attempts, 3)
            },
            "backoff": {
                "policy": UtilClient.default_string(runtime.backoff_policy, "no"),
                "period": UtilClient.default_number(runtime.backoff_period, 1)
            },
            "ignoreSSL": runtime.ignore_ssl
        }
        _last_request = None
        _last_exception = None
        _now = time.time()
        _retry_times = 0
        while TeaCore.allow_retry(_runtime.get('retry'), _retry_times, _now):
            if _retry_times > 0:
                _backoff_time = TeaCore.get_backoff_time(_runtime.get('backoff'), _retry_times)
                if _backoff_time > 0:
                    TeaCore.sleep(_backoff_time)
            _retry_times = _retry_times + 1
            try:
                _request = TeaRequest()
                access_key_id = self._credential.get_access_key_id()
                access_key_secret = self._credential.get_access_key_secret()
                token = self._credential.get_security_token()
                _request.protocol = self._protocol
                _request.method = "HEAD"
                _request.pathname = "/" + request.object_name + ""
                _request.headers = TeaCore.merge({
                    "host": OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    "date": UtilClient.get_date_utcstring(),
                    "user-agent": self.get_user_agent()
                }, UtilClient.stringify_map_value(request.header.to_map()))
                if not UtilClient.empty(token):
                    _request.headers["x-oss-security-token"] = token
                _request.headers["authorization"] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = UtilClient.read_as_string(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        "code": resp_map.get('Code'),
                        "message": resp_map.get('Message'),
                        "data": {
                            "httpCode": _response.status_code,
                            "requestId": resp_map.get('RequestId'),
                            "hostId": resp_map.get('HostId')
                        }
                    })
                return _oss_models.HeadObjectResponse().from_map(TeaCore.merge({
                    "usermeta": OSSUtilClient.to_meta(_response.headers, "x-oss-meta-")
                }, _response.headers))

            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def delete_object_tagging(self, request, runtime):
        request.validate()
        runtime.validate()
        _runtime = {
            "timeouted": "retry",
            "readTimeout": UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            "connectTimeout": UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            "localAddr": UtilClient.default_string(runtime.local_addr, self._local_addr),
            "httpProxy": UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            "httpsProxy": UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            "noProxy": UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            "socks5Proxy": UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            "socks5NetWork": UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            "maxIdleConns": UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            "retry": {
                "retryable": runtime.autoretry,
                "maxAttempts": UtilClient.default_number(runtime.max_attempts, 3)
            },
            "backoff": {
                "policy": UtilClient.default_string(runtime.backoff_policy, "no"),
                "period": UtilClient.default_number(runtime.backoff_period, 1)
            },
            "ignoreSSL": runtime.ignore_ssl
        }
        _last_request = None
        _last_exception = None
        _now = time.time()
        _retry_times = 0
        while TeaCore.allow_retry(_runtime.get('retry'), _retry_times, _now):
            if _retry_times > 0:
                _backoff_time = TeaCore.get_backoff_time(_runtime.get('backoff'), _retry_times)
                if _backoff_time > 0:
                    TeaCore.sleep(_backoff_time)
            _retry_times = _retry_times + 1
            try:
                _request = TeaRequest()
                access_key_id = self._credential.get_access_key_id()
                access_key_secret = self._credential.get_access_key_secret()
                token = self._credential.get_security_token()
                _request.protocol = self._protocol
                _request.method = "DELETE"
                _request.pathname = "/" + request.object_name + "?tagging"
                _request.headers = {
                    "host": OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    "date": UtilClient.get_date_utcstring(),
                    "user-agent": self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers["x-oss-security-token"] = token
                _request.headers["authorization"] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = UtilClient.read_as_string(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        "code": resp_map.get('Code'),
                        "message": resp_map.get('Message'),
                        "data": {
                            "httpCode": _response.status_code,
                            "requestId": resp_map.get('RequestId'),
                            "hostId": resp_map.get('HostId')
                        }
                    })
                return _oss_models.DeleteObjectTaggingResponse().from_map(TeaCore.merge(_response.headers))

            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def restore_object(self, request, runtime):
        request.validate()
        runtime.validate()
        _runtime = {
            "timeouted": "retry",
            "readTimeout": UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            "connectTimeout": UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            "localAddr": UtilClient.default_string(runtime.local_addr, self._local_addr),
            "httpProxy": UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            "httpsProxy": UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            "noProxy": UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            "socks5Proxy": UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            "socks5NetWork": UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            "maxIdleConns": UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            "retry": {
                "retryable": runtime.autoretry,
                "maxAttempts": UtilClient.default_number(runtime.max_attempts, 3)
            },
            "backoff": {
                "policy": UtilClient.default_string(runtime.backoff_policy, "no"),
                "period": UtilClient.default_number(runtime.backoff_period, 1)
            },
            "ignoreSSL": runtime.ignore_ssl
        }
        _last_request = None
        _last_exception = None
        _now = time.time()
        _retry_times = 0
        while TeaCore.allow_retry(_runtime.get('retry'), _retry_times, _now):
            if _retry_times > 0:
                _backoff_time = TeaCore.get_backoff_time(_runtime.get('backoff'), _retry_times)
                if _backoff_time > 0:
                    TeaCore.sleep(_backoff_time)
            _retry_times = _retry_times + 1
            try:
                _request = TeaRequest()
                access_key_id = self._credential.get_access_key_id()
                access_key_secret = self._credential.get_access_key_secret()
                token = self._credential.get_security_token()
                _request.protocol = self._protocol
                _request.method = "POST"
                _request.pathname = "/" + request.object_name + "?restore"
                _request.headers = {
                    "host": OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    "date": UtilClient.get_date_utcstring(),
                    "user-agent": self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers["x-oss-security-token"] = token
                _request.headers["authorization"] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = UtilClient.read_as_string(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        "code": resp_map.get('Code'),
                        "message": resp_map.get('Message'),
                        "data": {
                            "httpCode": _response.status_code,
                            "requestId": resp_map.get('RequestId'),
                            "hostId": resp_map.get('HostId')
                        }
                    })
                return _oss_models.RestoreObjectResponse().from_map(TeaCore.merge(_response.headers))

            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def get_object_acl(self, request, runtime):
        request.validate()
        runtime.validate()
        _runtime = {
            "timeouted": "retry",
            "readTimeout": UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            "connectTimeout": UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            "localAddr": UtilClient.default_string(runtime.local_addr, self._local_addr),
            "httpProxy": UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            "httpsProxy": UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            "noProxy": UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            "socks5Proxy": UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            "socks5NetWork": UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            "maxIdleConns": UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            "retry": {
                "retryable": runtime.autoretry,
                "maxAttempts": UtilClient.default_number(runtime.max_attempts, 3)
            },
            "backoff": {
                "policy": UtilClient.default_string(runtime.backoff_policy, "no"),
                "period": UtilClient.default_number(runtime.backoff_period, 1)
            },
            "ignoreSSL": runtime.ignore_ssl
        }
        _last_request = None
        _last_exception = None
        _now = time.time()
        _retry_times = 0
        while TeaCore.allow_retry(_runtime.get('retry'), _retry_times, _now):
            if _retry_times > 0:
                _backoff_time = TeaCore.get_backoff_time(_runtime.get('backoff'), _retry_times)
                if _backoff_time > 0:
                    TeaCore.sleep(_backoff_time)
            _retry_times = _retry_times + 1
            try:
                _request = TeaRequest()
                access_key_id = self._credential.get_access_key_id()
                access_key_secret = self._credential.get_access_key_secret()
                token = self._credential.get_security_token()
                _request.protocol = self._protocol
                _request.method = "GET"
                _request.pathname = "/" + request.object_name + "?acl"
                _request.headers = {
                    "host": OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    "date": UtilClient.get_date_utcstring(),
                    "user-agent": self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers["x-oss-security-token"] = token
                _request.headers["authorization"] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = UtilClient.read_as_string(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        "code": resp_map.get('Code'),
                        "message": resp_map.get('Message'),
                        "data": {
                            "httpCode": _response.status_code,
                            "requestId": resp_map.get('RequestId'),
                            "hostId": resp_map.get('HostId')
                        }
                    })
                body_str = UtilClient.read_as_string(_response.body)
                resp_map = XMLClient.parse_xml(body_str, _oss_models.GetObjectAclResponse())
                return _oss_models.GetObjectAclResponse().from_map(TeaCore.merge({
                    "AccessControlPolicy": resp_map.get('AccessControlPolicy')
                }, _response.headers))

            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def put_bucket_acl(self, request, runtime):
        request.validate()
        runtime.validate()
        _runtime = {
            "timeouted": "retry",
            "readTimeout": UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            "connectTimeout": UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            "localAddr": UtilClient.default_string(runtime.local_addr, self._local_addr),
            "httpProxy": UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            "httpsProxy": UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            "noProxy": UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            "socks5Proxy": UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            "socks5NetWork": UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            "maxIdleConns": UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            "retry": {
                "retryable": runtime.autoretry,
                "maxAttempts": UtilClient.default_number(runtime.max_attempts, 3)
            },
            "backoff": {
                "policy": UtilClient.default_string(runtime.backoff_policy, "no"),
                "period": UtilClient.default_number(runtime.backoff_period, 1)
            },
            "ignoreSSL": runtime.ignore_ssl
        }
        _last_request = None
        _last_exception = None
        _now = time.time()
        _retry_times = 0
        while TeaCore.allow_retry(_runtime.get('retry'), _retry_times, _now):
            if _retry_times > 0:
                _backoff_time = TeaCore.get_backoff_time(_runtime.get('backoff'), _retry_times)
                if _backoff_time > 0:
                    TeaCore.sleep(_backoff_time)
            _retry_times = _retry_times + 1
            try:
                _request = TeaRequest()
                access_key_id = self._credential.get_access_key_id()
                access_key_secret = self._credential.get_access_key_secret()
                token = self._credential.get_security_token()
                _request.protocol = self._protocol
                _request.method = "PUT"
                _request.pathname = "/?acl"
                _request.headers = TeaCore.merge({
                    "host": OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    "date": UtilClient.get_date_utcstring(),
                    "user-agent": self.get_user_agent()
                }, UtilClient.stringify_map_value(request.header.to_map()))
                if not UtilClient.empty(token):
                    _request.headers["x-oss-security-token"] = token
                _request.headers["authorization"] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = UtilClient.read_as_string(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        "code": resp_map.get('Code'),
                        "message": resp_map.get('Message'),
                        "data": {
                            "httpCode": _response.status_code,
                            "requestId": resp_map.get('RequestId'),
                            "hostId": resp_map.get('HostId')
                        }
                    })
                return _oss_models.PutBucketAclResponse().from_map(TeaCore.merge(_response.headers))

            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def delete_bucket(self, request, runtime):
        request.validate()
        runtime.validate()
        _runtime = {
            "timeouted": "retry",
            "readTimeout": UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            "connectTimeout": UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            "localAddr": UtilClient.default_string(runtime.local_addr, self._local_addr),
            "httpProxy": UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            "httpsProxy": UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            "noProxy": UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            "socks5Proxy": UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            "socks5NetWork": UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            "maxIdleConns": UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            "retry": {
                "retryable": runtime.autoretry,
                "maxAttempts": UtilClient.default_number(runtime.max_attempts, 3)
            },
            "backoff": {
                "policy": UtilClient.default_string(runtime.backoff_policy, "no"),
                "period": UtilClient.default_number(runtime.backoff_period, 1)
            },
            "ignoreSSL": runtime.ignore_ssl
        }
        _last_request = None
        _last_exception = None
        _now = time.time()
        _retry_times = 0
        while TeaCore.allow_retry(_runtime.get('retry'), _retry_times, _now):
            if _retry_times > 0:
                _backoff_time = TeaCore.get_backoff_time(_runtime.get('backoff'), _retry_times)
                if _backoff_time > 0:
                    TeaCore.sleep(_backoff_time)
            _retry_times = _retry_times + 1
            try:
                _request = TeaRequest()
                access_key_id = self._credential.get_access_key_id()
                access_key_secret = self._credential.get_access_key_secret()
                token = self._credential.get_security_token()
                _request.protocol = self._protocol
                _request.method = "DELETE"
                _request.pathname = "/"
                _request.headers = {
                    "host": OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    "date": UtilClient.get_date_utcstring(),
                    "user-agent": self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers["x-oss-security-token"] = token
                _request.headers["authorization"] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = UtilClient.read_as_string(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        "code": resp_map.get('Code'),
                        "message": resp_map.get('Message'),
                        "data": {
                            "httpCode": _response.status_code,
                            "requestId": resp_map.get('RequestId'),
                            "hostId": resp_map.get('HostId')
                        }
                    })
                return _oss_models.DeleteBucketResponse().from_map(TeaCore.merge(_response.headers))

            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def put_object(self, request, runtime):
        request.validate()
        runtime.validate()
        _runtime = {
            "timeouted": "retry",
            "readTimeout": UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            "connectTimeout": UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            "localAddr": UtilClient.default_string(runtime.local_addr, self._local_addr),
            "httpProxy": UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            "httpsProxy": UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            "noProxy": UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            "socks5Proxy": UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            "socks5NetWork": UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            "maxIdleConns": UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            "retry": {
                "retryable": runtime.autoretry,
                "maxAttempts": UtilClient.default_number(runtime.max_attempts, 3)
            },
            "backoff": {
                "policy": UtilClient.default_string(runtime.backoff_policy, "no"),
                "period": UtilClient.default_number(runtime.backoff_period, 1)
            },
            "ignoreSSL": runtime.ignore_ssl
        }
        _last_request = None
        _last_exception = None
        _now = time.time()
        _retry_times = 0
        while TeaCore.allow_retry(_runtime.get('retry'), _retry_times, _now):
            if _retry_times > 0:
                _backoff_time = TeaCore.get_backoff_time(_runtime.get('backoff'), _retry_times)
                if _backoff_time > 0:
                    TeaCore.sleep(_backoff_time)
            _retry_times = _retry_times + 1
            try:
                _request = TeaRequest()
                ctx = {}
                access_key_id = self._credential.get_access_key_id()
                access_key_secret = self._credential.get_access_key_secret()
                token = self._credential.get_security_token()
                _request.protocol = self._protocol
                _request.method = "PUT"
                _request.pathname = "/" + request.object_name + ""
                _request.headers = TeaCore.merge({
                    "host": OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    "date": UtilClient.get_date_utcstring(),
                    "user-agent": self.get_user_agent()
                }, UtilClient.stringify_map_value(request.header.to_map()),
                    OSSUtilClient.parse_meta(request.user_meta, "x-oss-meta-"))
                if not UtilClient.empty(token):
                    _request.headers["x-oss-security-token"] = token
                _request.body = OSSUtilClient.inject(request.body, ctx)
                if not UtilClient.is_unset(request.header.to_map()) and not UtilClient.empty(request.header.content_type):
                    _request.headers["content-type"] = request.header.content_type
                else:
                    _request.headers["content-type"] = OSSUtilClient.get_content_type(request.object_name)
                _request.headers["authorization"] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = UtilClient.read_as_string(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        "code": resp_map.get('Code'),
                        "message": resp_map.get('Message'),
                        "data": {
                            "httpCode": _response.status_code,
                            "requestId": resp_map.get('RequestId'),
                            "hostId": resp_map.get('HostId')
                        }
                    })
                if self._is_enable_crc and not UtilClient.equal_string(ctx.get('crc'), _response.headers.get('x-oss-hash-crc64ecma')):
                    raise TeaException({
                        "code": "CrcNotMatched",
                        "data": {
                            "clientCrc": ctx.get('crc'),
                            "serverCrc": _response.headers.get('x-oss-hash-crc64ecma')
                        }
                    })
                if self._is_enable_md5 and not UtilClient.equal_string(ctx.get('md5'), _response.headers.get('content-md5')):
                    raise TeaException({
                        "code": "MD5NotMatched",
                        "data": {
                            "clientMD5": ctx.get('md5'),
                            "serverMD5": _response.headers.get('content-md5')
                        }
                    })
                return _oss_models.PutObjectResponse().from_map(TeaCore.merge(_response.headers))

            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def set_user_agent(self, user_agent):
        self._user_agent = user_agent

    def append_user_agent(self, user_agent):
        self._user_agent = "" + self._user_agent + " " + user_agent + ""

    def get_user_agent(self):
        user_agent = UtilClient.get_user_agent(self._user_agent)
        return user_agent

    def get_access_key_id(self):
        if UtilClient.is_unset(self._credential):
            return ''
        access_key_id = self._credential.get_access_key_id()
        return access_key_id

    def get_access_key_secret(self):
        if UtilClient.is_unset(self._credential):
            return ''
        secret = self._credential.get_access_key_secret()
        return secret
