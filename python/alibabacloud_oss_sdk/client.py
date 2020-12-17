# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
import time

from Tea.exceptions import TeaException, UnretryableException
from Tea.request import TeaRequest
from Tea.core import TeaCore
from typing import List

from alibabacloud_credentials.client import Client as CredentialClient
from alibabacloud_oss_sdk import models as oss_models
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_credentials import models as credential_models
from alibabacloud_oss_util import models as ossutil_models
from alibabacloud_tea_xml.client import Client as XMLClient
from alibabacloud_oss_util.client import Client as OSSUtilClient
from alibabacloud_tea_fileform.client import Client as FileFormClient


class Client:
    _endpoint: str = None
    _region_id: str = None
    _host_model: str = None
    _protocol: str = None
    _read_timeout: int = None
    _connect_timeout: int = None
    _signature_version: str = None
    _addtional_headers: List[str] = None
    _local_addr: str = None
    _http_proxy: str = None
    _https_proxy: str = None
    _no_proxy: str = None
    _user_agent: str = None
    _socks_5proxy: str = None
    _is_enable_crc: bool = None
    _is_enable_md5: bool = None
    _socks_5net_work: str = None
    _max_idle_conns: int = None
    _credential: CredentialClient = None

    def __init__(
        self, 
        config: oss_models.Config,
    ):
        if UtilClient.is_unset(config):
            raise TeaException({
                'name': 'ParameterMissing',
                'message': "'config' can not be unset"
            })
        if UtilClient.empty(config.type):
            config.type = 'access_key'
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

    def put_bucket_lifecycle(
        self,
        request: oss_models.PutBucketLifecycleRequest,
        runtime: ossutil_models.RuntimeOptions,
    ) -> oss_models.PutBucketLifecycleResponse:
        request.validate()
        runtime.validate()
        _runtime = {
            'timeouted': 'retry',
            'readTimeout': UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            'connectTimeout': UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            'localAddr': UtilClient.default_string(runtime.local_addr, self._local_addr),
            'httpProxy': UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            'httpsProxy': UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            'noProxy': UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            'socks5Proxy': UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            'socks5NetWork': UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            'maxIdleConns': UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            'retry': {
                'retryable': runtime.autoretry,
                'maxAttempts': UtilClient.default_number(runtime.max_attempts, 3)
            },
            'backoff': {
                'policy': UtilClient.default_string(runtime.backoff_policy, 'no'),
                'period': UtilClient.default_number(runtime.backoff_period, 1)
            },
            'ignoreSSL': runtime.ignore_ssl
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
                req_body = XMLClient.to_xml(TeaCore.to_map(request.body))
                _request.protocol = self._protocol
                _request.method = 'PUT'
                _request.pathname = f'/?lifecycle'
                _request.headers = {
                    'host': OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    'date': UtilClient.get_date_utcstring(),
                    'user-agent': self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers['x-oss-security-token'] = token
                _request.body = req_body
                _request.headers['authorization'] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = UtilClient.read_as_string(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        'code': resp_map.get('Code'),
                        'message': resp_map.get('Message'),
                        'data': {
                            'httpCode': _response.status_code,
                            'requestId': resp_map.get('RequestId'),
                            'hostId': resp_map.get('HostId')
                        }
                    })
                return oss_models.PutBucketLifecycleResponse().from_map(
                    TeaCore.merge(_response.headers)
                )
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    async def put_bucket_lifecycle_async(
        self,
        request: oss_models.PutBucketLifecycleRequest,
        runtime: ossutil_models.RuntimeOptions,
    ) -> oss_models.PutBucketLifecycleResponse:
        request.validate()
        runtime.validate()
        _runtime = {
            'timeouted': 'retry',
            'readTimeout': UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            'connectTimeout': UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            'localAddr': UtilClient.default_string(runtime.local_addr, self._local_addr),
            'httpProxy': UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            'httpsProxy': UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            'noProxy': UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            'socks5Proxy': UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            'socks5NetWork': UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            'maxIdleConns': UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            'retry': {
                'retryable': runtime.autoretry,
                'maxAttempts': UtilClient.default_number(runtime.max_attempts, 3)
            },
            'backoff': {
                'policy': UtilClient.default_string(runtime.backoff_policy, 'no'),
                'period': UtilClient.default_number(runtime.backoff_period, 1)
            },
            'ignoreSSL': runtime.ignore_ssl
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
                access_key_id = await self._credential.get_access_key_id_async()
                access_key_secret = await self._credential.get_access_key_secret_async()
                token = await self._credential.get_security_token_async()
                req_body = XMLClient.to_xml(TeaCore.to_map(request.body))
                _request.protocol = self._protocol
                _request.method = 'PUT'
                _request.pathname = f'/?lifecycle'
                _request.headers = {
                    'host': OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    'date': UtilClient.get_date_utcstring(),
                    'user-agent': self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers['x-oss-security-token'] = token
                _request.body = req_body
                _request.headers['authorization'] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = await TeaCore.async_do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = await UtilClient.read_as_string_async(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        'code': resp_map.get('Code'),
                        'message': resp_map.get('Message'),
                        'data': {
                            'httpCode': _response.status_code,
                            'requestId': resp_map.get('RequestId'),
                            'hostId': resp_map.get('HostId')
                        }
                    })
                return oss_models.PutBucketLifecycleResponse().from_map(
                    TeaCore.merge(_response.headers)
                )
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def delete_multiple_objects(
        self,
        request: oss_models.DeleteMultipleObjectsRequest,
        runtime: ossutil_models.RuntimeOptions,
    ) -> oss_models.DeleteMultipleObjectsResponse:
        request.validate()
        runtime.validate()
        _runtime = {
            'timeouted': 'retry',
            'readTimeout': UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            'connectTimeout': UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            'localAddr': UtilClient.default_string(runtime.local_addr, self._local_addr),
            'httpProxy': UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            'httpsProxy': UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            'noProxy': UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            'socks5Proxy': UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            'socks5NetWork': UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            'maxIdleConns': UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            'retry': {
                'retryable': runtime.autoretry,
                'maxAttempts': UtilClient.default_number(runtime.max_attempts, 3)
            },
            'backoff': {
                'policy': UtilClient.default_string(runtime.backoff_policy, 'no'),
                'period': UtilClient.default_number(runtime.backoff_period, 1)
            },
            'ignoreSSL': runtime.ignore_ssl
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
                req_body = XMLClient.to_xml(TeaCore.to_map(request.body))
                _request.protocol = self._protocol
                _request.method = 'POST'
                _request.pathname = f'/?delete'
                _request.headers = TeaCore.merge({
                    'host': OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    'date': UtilClient.get_date_utcstring(),
                    'user-agent': self.get_user_agent()
                }, UtilClient.stringify_map_value(TeaCore.to_map(request.header)))
                if not UtilClient.empty(token):
                    _request.headers['x-oss-security-token'] = token
                _request.body = req_body
                if not UtilClient.is_unset(request.header) and not UtilClient.empty(request.header.content_md5):
                    _request.headers['content-md5'] = request.header.content_md5
                else:
                    _request.headers['content-md5'] = OSSUtilClient.get_content_md5(req_body, self._is_enable_md5)
                _request.headers['authorization'] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = UtilClient.read_as_string(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        'code': resp_map.get('Code'),
                        'message': resp_map.get('Message'),
                        'data': {
                            'httpCode': _response.status_code,
                            'requestId': resp_map.get('RequestId'),
                            'hostId': resp_map.get('HostId')
                        }
                    })
                body_str = UtilClient.read_as_string(_response.body)
                resp_map = XMLClient.parse_xml(body_str, oss_models.DeleteMultipleObjectsResponse())
                return oss_models.DeleteMultipleObjectsResponse().from_map(
                    TeaCore.merge({
                        'DeleteResult': resp_map.get('DeleteResult')
                    }, _response.headers)
                )
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    async def delete_multiple_objects_async(
        self,
        request: oss_models.DeleteMultipleObjectsRequest,
        runtime: ossutil_models.RuntimeOptions,
    ) -> oss_models.DeleteMultipleObjectsResponse:
        request.validate()
        runtime.validate()
        _runtime = {
            'timeouted': 'retry',
            'readTimeout': UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            'connectTimeout': UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            'localAddr': UtilClient.default_string(runtime.local_addr, self._local_addr),
            'httpProxy': UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            'httpsProxy': UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            'noProxy': UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            'socks5Proxy': UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            'socks5NetWork': UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            'maxIdleConns': UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            'retry': {
                'retryable': runtime.autoretry,
                'maxAttempts': UtilClient.default_number(runtime.max_attempts, 3)
            },
            'backoff': {
                'policy': UtilClient.default_string(runtime.backoff_policy, 'no'),
                'period': UtilClient.default_number(runtime.backoff_period, 1)
            },
            'ignoreSSL': runtime.ignore_ssl
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
                access_key_id = await self._credential.get_access_key_id_async()
                access_key_secret = await self._credential.get_access_key_secret_async()
                token = await self._credential.get_security_token_async()
                req_body = XMLClient.to_xml(TeaCore.to_map(request.body))
                _request.protocol = self._protocol
                _request.method = 'POST'
                _request.pathname = f'/?delete'
                _request.headers = TeaCore.merge({
                    'host': OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    'date': UtilClient.get_date_utcstring(),
                    'user-agent': self.get_user_agent()
                }, UtilClient.stringify_map_value(TeaCore.to_map(request.header)))
                if not UtilClient.empty(token):
                    _request.headers['x-oss-security-token'] = token
                _request.body = req_body
                if not UtilClient.is_unset(request.header) and not UtilClient.empty(request.header.content_md5):
                    _request.headers['content-md5'] = request.header.content_md5
                else:
                    _request.headers['content-md5'] = OSSUtilClient.get_content_md5(req_body, self._is_enable_md5)
                _request.headers['authorization'] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = await TeaCore.async_do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = await UtilClient.read_as_string_async(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        'code': resp_map.get('Code'),
                        'message': resp_map.get('Message'),
                        'data': {
                            'httpCode': _response.status_code,
                            'requestId': resp_map.get('RequestId'),
                            'hostId': resp_map.get('HostId')
                        }
                    })
                body_str = await UtilClient.read_as_string_async(_response.body)
                resp_map = XMLClient.parse_xml(body_str, oss_models.DeleteMultipleObjectsResponse())
                return oss_models.DeleteMultipleObjectsResponse().from_map(
                    TeaCore.merge({
                        'DeleteResult': resp_map.get('DeleteResult')
                    }, _response.headers)
                )
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def put_bucket_referer(
        self,
        request: oss_models.PutBucketRefererRequest,
        runtime: ossutil_models.RuntimeOptions,
    ) -> oss_models.PutBucketRefererResponse:
        request.validate()
        runtime.validate()
        _runtime = {
            'timeouted': 'retry',
            'readTimeout': UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            'connectTimeout': UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            'localAddr': UtilClient.default_string(runtime.local_addr, self._local_addr),
            'httpProxy': UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            'httpsProxy': UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            'noProxy': UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            'socks5Proxy': UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            'socks5NetWork': UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            'maxIdleConns': UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            'retry': {
                'retryable': runtime.autoretry,
                'maxAttempts': UtilClient.default_number(runtime.max_attempts, 3)
            },
            'backoff': {
                'policy': UtilClient.default_string(runtime.backoff_policy, 'no'),
                'period': UtilClient.default_number(runtime.backoff_period, 1)
            },
            'ignoreSSL': runtime.ignore_ssl
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
                req_body = XMLClient.to_xml(TeaCore.to_map(request.body))
                _request.protocol = self._protocol
                _request.method = 'PUT'
                _request.pathname = f'/?referer'
                _request.headers = {
                    'host': OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    'date': UtilClient.get_date_utcstring(),
                    'user-agent': self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers['x-oss-security-token'] = token
                _request.body = req_body
                _request.headers['authorization'] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = UtilClient.read_as_string(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        'code': resp_map.get('Code'),
                        'message': resp_map.get('Message'),
                        'data': {
                            'httpCode': _response.status_code,
                            'requestId': resp_map.get('RequestId'),
                            'hostId': resp_map.get('HostId')
                        }
                    })
                return oss_models.PutBucketRefererResponse().from_map(
                    TeaCore.merge(_response.headers)
                )
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    async def put_bucket_referer_async(
        self,
        request: oss_models.PutBucketRefererRequest,
        runtime: ossutil_models.RuntimeOptions,
    ) -> oss_models.PutBucketRefererResponse:
        request.validate()
        runtime.validate()
        _runtime = {
            'timeouted': 'retry',
            'readTimeout': UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            'connectTimeout': UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            'localAddr': UtilClient.default_string(runtime.local_addr, self._local_addr),
            'httpProxy': UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            'httpsProxy': UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            'noProxy': UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            'socks5Proxy': UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            'socks5NetWork': UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            'maxIdleConns': UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            'retry': {
                'retryable': runtime.autoretry,
                'maxAttempts': UtilClient.default_number(runtime.max_attempts, 3)
            },
            'backoff': {
                'policy': UtilClient.default_string(runtime.backoff_policy, 'no'),
                'period': UtilClient.default_number(runtime.backoff_period, 1)
            },
            'ignoreSSL': runtime.ignore_ssl
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
                access_key_id = await self._credential.get_access_key_id_async()
                access_key_secret = await self._credential.get_access_key_secret_async()
                token = await self._credential.get_security_token_async()
                req_body = XMLClient.to_xml(TeaCore.to_map(request.body))
                _request.protocol = self._protocol
                _request.method = 'PUT'
                _request.pathname = f'/?referer'
                _request.headers = {
                    'host': OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    'date': UtilClient.get_date_utcstring(),
                    'user-agent': self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers['x-oss-security-token'] = token
                _request.body = req_body
                _request.headers['authorization'] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = await TeaCore.async_do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = await UtilClient.read_as_string_async(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        'code': resp_map.get('Code'),
                        'message': resp_map.get('Message'),
                        'data': {
                            'httpCode': _response.status_code,
                            'requestId': resp_map.get('RequestId'),
                            'hostId': resp_map.get('HostId')
                        }
                    })
                return oss_models.PutBucketRefererResponse().from_map(
                    TeaCore.merge(_response.headers)
                )
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def put_bucket_website(
        self,
        request: oss_models.PutBucketWebsiteRequest,
        runtime: ossutil_models.RuntimeOptions,
    ) -> oss_models.PutBucketWebsiteResponse:
        request.validate()
        runtime.validate()
        _runtime = {
            'timeouted': 'retry',
            'readTimeout': UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            'connectTimeout': UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            'localAddr': UtilClient.default_string(runtime.local_addr, self._local_addr),
            'httpProxy': UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            'httpsProxy': UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            'noProxy': UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            'socks5Proxy': UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            'socks5NetWork': UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            'maxIdleConns': UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            'retry': {
                'retryable': runtime.autoretry,
                'maxAttempts': UtilClient.default_number(runtime.max_attempts, 3)
            },
            'backoff': {
                'policy': UtilClient.default_string(runtime.backoff_policy, 'no'),
                'period': UtilClient.default_number(runtime.backoff_period, 1)
            },
            'ignoreSSL': runtime.ignore_ssl
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
                req_body = XMLClient.to_xml(TeaCore.to_map(request.body))
                _request.protocol = self._protocol
                _request.method = 'PUT'
                _request.pathname = f'/?website'
                _request.headers = {
                    'host': OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    'date': UtilClient.get_date_utcstring(),
                    'user-agent': self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers['x-oss-security-token'] = token
                _request.body = req_body
                _request.headers['authorization'] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = UtilClient.read_as_string(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        'code': resp_map.get('Code'),
                        'message': resp_map.get('Message'),
                        'data': {
                            'httpCode': _response.status_code,
                            'requestId': resp_map.get('RequestId'),
                            'hostId': resp_map.get('HostId')
                        }
                    })
                return oss_models.PutBucketWebsiteResponse().from_map(
                    TeaCore.merge(_response.headers)
                )
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    async def put_bucket_website_async(
        self,
        request: oss_models.PutBucketWebsiteRequest,
        runtime: ossutil_models.RuntimeOptions,
    ) -> oss_models.PutBucketWebsiteResponse:
        request.validate()
        runtime.validate()
        _runtime = {
            'timeouted': 'retry',
            'readTimeout': UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            'connectTimeout': UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            'localAddr': UtilClient.default_string(runtime.local_addr, self._local_addr),
            'httpProxy': UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            'httpsProxy': UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            'noProxy': UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            'socks5Proxy': UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            'socks5NetWork': UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            'maxIdleConns': UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            'retry': {
                'retryable': runtime.autoretry,
                'maxAttempts': UtilClient.default_number(runtime.max_attempts, 3)
            },
            'backoff': {
                'policy': UtilClient.default_string(runtime.backoff_policy, 'no'),
                'period': UtilClient.default_number(runtime.backoff_period, 1)
            },
            'ignoreSSL': runtime.ignore_ssl
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
                access_key_id = await self._credential.get_access_key_id_async()
                access_key_secret = await self._credential.get_access_key_secret_async()
                token = await self._credential.get_security_token_async()
                req_body = XMLClient.to_xml(TeaCore.to_map(request.body))
                _request.protocol = self._protocol
                _request.method = 'PUT'
                _request.pathname = f'/?website'
                _request.headers = {
                    'host': OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    'date': UtilClient.get_date_utcstring(),
                    'user-agent': self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers['x-oss-security-token'] = token
                _request.body = req_body
                _request.headers['authorization'] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = await TeaCore.async_do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = await UtilClient.read_as_string_async(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        'code': resp_map.get('Code'),
                        'message': resp_map.get('Message'),
                        'data': {
                            'httpCode': _response.status_code,
                            'requestId': resp_map.get('RequestId'),
                            'hostId': resp_map.get('HostId')
                        }
                    })
                return oss_models.PutBucketWebsiteResponse().from_map(
                    TeaCore.merge(_response.headers)
                )
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def complete_multipart_upload(
        self,
        request: oss_models.CompleteMultipartUploadRequest,
        runtime: ossutil_models.RuntimeOptions,
    ) -> oss_models.CompleteMultipartUploadResponse:
        request.validate()
        runtime.validate()
        _runtime = {
            'timeouted': 'retry',
            'readTimeout': UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            'connectTimeout': UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            'localAddr': UtilClient.default_string(runtime.local_addr, self._local_addr),
            'httpProxy': UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            'httpsProxy': UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            'noProxy': UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            'socks5Proxy': UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            'socks5NetWork': UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            'maxIdleConns': UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            'retry': {
                'retryable': runtime.autoretry,
                'maxAttempts': UtilClient.default_number(runtime.max_attempts, 3)
            },
            'backoff': {
                'policy': UtilClient.default_string(runtime.backoff_policy, 'no'),
                'period': UtilClient.default_number(runtime.backoff_period, 1)
            },
            'ignoreSSL': runtime.ignore_ssl
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
                req_body = XMLClient.to_xml(TeaCore.to_map(request.body))
                _request.protocol = self._protocol
                _request.method = 'POST'
                _request.pathname = f'/{request.object_name}'
                _request.headers = {
                    'host': OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    'date': UtilClient.get_date_utcstring(),
                    'user-agent': self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers['x-oss-security-token'] = token
                _request.query = UtilClient.stringify_map_value(TeaCore.to_map(request.filter))
                _request.body = req_body
                _request.headers['authorization'] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = UtilClient.read_as_string(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        'code': resp_map.get('Code'),
                        'message': resp_map.get('Message'),
                        'data': {
                            'httpCode': _response.status_code,
                            'requestId': resp_map.get('RequestId'),
                            'hostId': resp_map.get('HostId')
                        }
                    })
                body_str = UtilClient.read_as_string(_response.body)
                resp_map = XMLClient.parse_xml(body_str, oss_models.CompleteMultipartUploadResponse())
                return oss_models.CompleteMultipartUploadResponse().from_map(
                    TeaCore.merge({
                        'CompleteMultipartUploadResult': resp_map.get('CompleteMultipartUploadResult')
                    }, _response.headers)
                )
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    async def complete_multipart_upload_async(
        self,
        request: oss_models.CompleteMultipartUploadRequest,
        runtime: ossutil_models.RuntimeOptions,
    ) -> oss_models.CompleteMultipartUploadResponse:
        request.validate()
        runtime.validate()
        _runtime = {
            'timeouted': 'retry',
            'readTimeout': UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            'connectTimeout': UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            'localAddr': UtilClient.default_string(runtime.local_addr, self._local_addr),
            'httpProxy': UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            'httpsProxy': UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            'noProxy': UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            'socks5Proxy': UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            'socks5NetWork': UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            'maxIdleConns': UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            'retry': {
                'retryable': runtime.autoretry,
                'maxAttempts': UtilClient.default_number(runtime.max_attempts, 3)
            },
            'backoff': {
                'policy': UtilClient.default_string(runtime.backoff_policy, 'no'),
                'period': UtilClient.default_number(runtime.backoff_period, 1)
            },
            'ignoreSSL': runtime.ignore_ssl
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
                access_key_id = await self._credential.get_access_key_id_async()
                access_key_secret = await self._credential.get_access_key_secret_async()
                token = await self._credential.get_security_token_async()
                req_body = XMLClient.to_xml(TeaCore.to_map(request.body))
                _request.protocol = self._protocol
                _request.method = 'POST'
                _request.pathname = f'/{request.object_name}'
                _request.headers = {
                    'host': OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    'date': UtilClient.get_date_utcstring(),
                    'user-agent': self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers['x-oss-security-token'] = token
                _request.query = UtilClient.stringify_map_value(TeaCore.to_map(request.filter))
                _request.body = req_body
                _request.headers['authorization'] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = await TeaCore.async_do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = await UtilClient.read_as_string_async(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        'code': resp_map.get('Code'),
                        'message': resp_map.get('Message'),
                        'data': {
                            'httpCode': _response.status_code,
                            'requestId': resp_map.get('RequestId'),
                            'hostId': resp_map.get('HostId')
                        }
                    })
                body_str = await UtilClient.read_as_string_async(_response.body)
                resp_map = XMLClient.parse_xml(body_str, oss_models.CompleteMultipartUploadResponse())
                return oss_models.CompleteMultipartUploadResponse().from_map(
                    TeaCore.merge({
                        'CompleteMultipartUploadResult': resp_map.get('CompleteMultipartUploadResult')
                    }, _response.headers)
                )
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def put_bucket_logging(
        self,
        request: oss_models.PutBucketLoggingRequest,
        runtime: ossutil_models.RuntimeOptions,
    ) -> oss_models.PutBucketLoggingResponse:
        request.validate()
        runtime.validate()
        _runtime = {
            'timeouted': 'retry',
            'readTimeout': UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            'connectTimeout': UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            'localAddr': UtilClient.default_string(runtime.local_addr, self._local_addr),
            'httpProxy': UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            'httpsProxy': UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            'noProxy': UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            'socks5Proxy': UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            'socks5NetWork': UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            'maxIdleConns': UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            'retry': {
                'retryable': runtime.autoretry,
                'maxAttempts': UtilClient.default_number(runtime.max_attempts, 3)
            },
            'backoff': {
                'policy': UtilClient.default_string(runtime.backoff_policy, 'no'),
                'period': UtilClient.default_number(runtime.backoff_period, 1)
            },
            'ignoreSSL': runtime.ignore_ssl
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
                req_body = XMLClient.to_xml(TeaCore.to_map(request.body))
                _request.protocol = self._protocol
                _request.method = 'PUT'
                _request.pathname = f'/?logging'
                _request.headers = {
                    'host': OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    'date': UtilClient.get_date_utcstring(),
                    'user-agent': self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers['x-oss-security-token'] = token
                _request.body = req_body
                _request.headers['authorization'] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = UtilClient.read_as_string(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        'code': resp_map.get('Code'),
                        'message': resp_map.get('Message'),
                        'data': {
                            'httpCode': _response.status_code,
                            'requestId': resp_map.get('RequestId'),
                            'hostId': resp_map.get('HostId')
                        }
                    })
                return oss_models.PutBucketLoggingResponse().from_map(
                    TeaCore.merge(_response.headers)
                )
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    async def put_bucket_logging_async(
        self,
        request: oss_models.PutBucketLoggingRequest,
        runtime: ossutil_models.RuntimeOptions,
    ) -> oss_models.PutBucketLoggingResponse:
        request.validate()
        runtime.validate()
        _runtime = {
            'timeouted': 'retry',
            'readTimeout': UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            'connectTimeout': UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            'localAddr': UtilClient.default_string(runtime.local_addr, self._local_addr),
            'httpProxy': UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            'httpsProxy': UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            'noProxy': UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            'socks5Proxy': UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            'socks5NetWork': UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            'maxIdleConns': UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            'retry': {
                'retryable': runtime.autoretry,
                'maxAttempts': UtilClient.default_number(runtime.max_attempts, 3)
            },
            'backoff': {
                'policy': UtilClient.default_string(runtime.backoff_policy, 'no'),
                'period': UtilClient.default_number(runtime.backoff_period, 1)
            },
            'ignoreSSL': runtime.ignore_ssl
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
                access_key_id = await self._credential.get_access_key_id_async()
                access_key_secret = await self._credential.get_access_key_secret_async()
                token = await self._credential.get_security_token_async()
                req_body = XMLClient.to_xml(TeaCore.to_map(request.body))
                _request.protocol = self._protocol
                _request.method = 'PUT'
                _request.pathname = f'/?logging'
                _request.headers = {
                    'host': OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    'date': UtilClient.get_date_utcstring(),
                    'user-agent': self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers['x-oss-security-token'] = token
                _request.body = req_body
                _request.headers['authorization'] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = await TeaCore.async_do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = await UtilClient.read_as_string_async(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        'code': resp_map.get('Code'),
                        'message': resp_map.get('Message'),
                        'data': {
                            'httpCode': _response.status_code,
                            'requestId': resp_map.get('RequestId'),
                            'hostId': resp_map.get('HostId')
                        }
                    })
                return oss_models.PutBucketLoggingResponse().from_map(
                    TeaCore.merge(_response.headers)
                )
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def put_bucket_request_payment(
        self,
        request: oss_models.PutBucketRequestPaymentRequest,
        runtime: ossutil_models.RuntimeOptions,
    ) -> oss_models.PutBucketRequestPaymentResponse:
        request.validate()
        runtime.validate()
        _runtime = {
            'timeouted': 'retry',
            'readTimeout': UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            'connectTimeout': UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            'localAddr': UtilClient.default_string(runtime.local_addr, self._local_addr),
            'httpProxy': UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            'httpsProxy': UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            'noProxy': UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            'socks5Proxy': UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            'socks5NetWork': UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            'maxIdleConns': UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            'retry': {
                'retryable': runtime.autoretry,
                'maxAttempts': UtilClient.default_number(runtime.max_attempts, 3)
            },
            'backoff': {
                'policy': UtilClient.default_string(runtime.backoff_policy, 'no'),
                'period': UtilClient.default_number(runtime.backoff_period, 1)
            },
            'ignoreSSL': runtime.ignore_ssl
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
                req_body = XMLClient.to_xml(TeaCore.to_map(request.body))
                _request.protocol = self._protocol
                _request.method = 'PUT'
                _request.pathname = f'/?requestPayment'
                _request.headers = {
                    'host': OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    'date': UtilClient.get_date_utcstring(),
                    'user-agent': self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers['x-oss-security-token'] = token
                _request.body = req_body
                _request.headers['authorization'] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = UtilClient.read_as_string(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        'code': resp_map.get('Code'),
                        'message': resp_map.get('Message'),
                        'data': {
                            'httpCode': _response.status_code,
                            'requestId': resp_map.get('RequestId'),
                            'hostId': resp_map.get('HostId')
                        }
                    })
                return oss_models.PutBucketRequestPaymentResponse().from_map(
                    TeaCore.merge(_response.headers)
                )
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    async def put_bucket_request_payment_async(
        self,
        request: oss_models.PutBucketRequestPaymentRequest,
        runtime: ossutil_models.RuntimeOptions,
    ) -> oss_models.PutBucketRequestPaymentResponse:
        request.validate()
        runtime.validate()
        _runtime = {
            'timeouted': 'retry',
            'readTimeout': UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            'connectTimeout': UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            'localAddr': UtilClient.default_string(runtime.local_addr, self._local_addr),
            'httpProxy': UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            'httpsProxy': UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            'noProxy': UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            'socks5Proxy': UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            'socks5NetWork': UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            'maxIdleConns': UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            'retry': {
                'retryable': runtime.autoretry,
                'maxAttempts': UtilClient.default_number(runtime.max_attempts, 3)
            },
            'backoff': {
                'policy': UtilClient.default_string(runtime.backoff_policy, 'no'),
                'period': UtilClient.default_number(runtime.backoff_period, 1)
            },
            'ignoreSSL': runtime.ignore_ssl
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
                access_key_id = await self._credential.get_access_key_id_async()
                access_key_secret = await self._credential.get_access_key_secret_async()
                token = await self._credential.get_security_token_async()
                req_body = XMLClient.to_xml(TeaCore.to_map(request.body))
                _request.protocol = self._protocol
                _request.method = 'PUT'
                _request.pathname = f'/?requestPayment'
                _request.headers = {
                    'host': OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    'date': UtilClient.get_date_utcstring(),
                    'user-agent': self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers['x-oss-security-token'] = token
                _request.body = req_body
                _request.headers['authorization'] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = await TeaCore.async_do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = await UtilClient.read_as_string_async(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        'code': resp_map.get('Code'),
                        'message': resp_map.get('Message'),
                        'data': {
                            'httpCode': _response.status_code,
                            'requestId': resp_map.get('RequestId'),
                            'hostId': resp_map.get('HostId')
                        }
                    })
                return oss_models.PutBucketRequestPaymentResponse().from_map(
                    TeaCore.merge(_response.headers)
                )
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def put_bucket_encryption(
        self,
        request: oss_models.PutBucketEncryptionRequest,
        runtime: ossutil_models.RuntimeOptions,
    ) -> oss_models.PutBucketEncryptionResponse:
        request.validate()
        runtime.validate()
        _runtime = {
            'timeouted': 'retry',
            'readTimeout': UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            'connectTimeout': UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            'localAddr': UtilClient.default_string(runtime.local_addr, self._local_addr),
            'httpProxy': UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            'httpsProxy': UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            'noProxy': UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            'socks5Proxy': UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            'socks5NetWork': UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            'maxIdleConns': UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            'retry': {
                'retryable': runtime.autoretry,
                'maxAttempts': UtilClient.default_number(runtime.max_attempts, 3)
            },
            'backoff': {
                'policy': UtilClient.default_string(runtime.backoff_policy, 'no'),
                'period': UtilClient.default_number(runtime.backoff_period, 1)
            },
            'ignoreSSL': runtime.ignore_ssl
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
                req_body = XMLClient.to_xml(TeaCore.to_map(request.body))
                _request.protocol = self._protocol
                _request.method = 'PUT'
                _request.pathname = f'/?encryption'
                _request.headers = {
                    'host': OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    'date': UtilClient.get_date_utcstring(),
                    'user-agent': self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers['x-oss-security-token'] = token
                _request.body = req_body
                _request.headers['authorization'] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = UtilClient.read_as_string(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        'code': resp_map.get('Code'),
                        'message': resp_map.get('Message'),
                        'data': {
                            'httpCode': _response.status_code,
                            'requestId': resp_map.get('RequestId'),
                            'hostId': resp_map.get('HostId')
                        }
                    })
                return oss_models.PutBucketEncryptionResponse().from_map(
                    TeaCore.merge(_response.headers)
                )
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    async def put_bucket_encryption_async(
        self,
        request: oss_models.PutBucketEncryptionRequest,
        runtime: ossutil_models.RuntimeOptions,
    ) -> oss_models.PutBucketEncryptionResponse:
        request.validate()
        runtime.validate()
        _runtime = {
            'timeouted': 'retry',
            'readTimeout': UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            'connectTimeout': UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            'localAddr': UtilClient.default_string(runtime.local_addr, self._local_addr),
            'httpProxy': UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            'httpsProxy': UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            'noProxy': UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            'socks5Proxy': UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            'socks5NetWork': UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            'maxIdleConns': UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            'retry': {
                'retryable': runtime.autoretry,
                'maxAttempts': UtilClient.default_number(runtime.max_attempts, 3)
            },
            'backoff': {
                'policy': UtilClient.default_string(runtime.backoff_policy, 'no'),
                'period': UtilClient.default_number(runtime.backoff_period, 1)
            },
            'ignoreSSL': runtime.ignore_ssl
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
                access_key_id = await self._credential.get_access_key_id_async()
                access_key_secret = await self._credential.get_access_key_secret_async()
                token = await self._credential.get_security_token_async()
                req_body = XMLClient.to_xml(TeaCore.to_map(request.body))
                _request.protocol = self._protocol
                _request.method = 'PUT'
                _request.pathname = f'/?encryption'
                _request.headers = {
                    'host': OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    'date': UtilClient.get_date_utcstring(),
                    'user-agent': self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers['x-oss-security-token'] = token
                _request.body = req_body
                _request.headers['authorization'] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = await TeaCore.async_do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = await UtilClient.read_as_string_async(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        'code': resp_map.get('Code'),
                        'message': resp_map.get('Message'),
                        'data': {
                            'httpCode': _response.status_code,
                            'requestId': resp_map.get('RequestId'),
                            'hostId': resp_map.get('HostId')
                        }
                    })
                return oss_models.PutBucketEncryptionResponse().from_map(
                    TeaCore.merge(_response.headers)
                )
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def put_live_channel(
        self,
        request: oss_models.PutLiveChannelRequest,
        runtime: ossutil_models.RuntimeOptions,
    ) -> oss_models.PutLiveChannelResponse:
        request.validate()
        runtime.validate()
        _runtime = {
            'timeouted': 'retry',
            'readTimeout': UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            'connectTimeout': UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            'localAddr': UtilClient.default_string(runtime.local_addr, self._local_addr),
            'httpProxy': UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            'httpsProxy': UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            'noProxy': UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            'socks5Proxy': UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            'socks5NetWork': UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            'maxIdleConns': UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            'retry': {
                'retryable': runtime.autoretry,
                'maxAttempts': UtilClient.default_number(runtime.max_attempts, 3)
            },
            'backoff': {
                'policy': UtilClient.default_string(runtime.backoff_policy, 'no'),
                'period': UtilClient.default_number(runtime.backoff_period, 1)
            },
            'ignoreSSL': runtime.ignore_ssl
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
                req_body = XMLClient.to_xml(TeaCore.to_map(request.body))
                _request.protocol = self._protocol
                _request.method = 'PUT'
                _request.pathname = f'/{request.channel_name}?live'
                _request.headers = {
                    'host': OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    'date': UtilClient.get_date_utcstring(),
                    'user-agent': self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers['x-oss-security-token'] = token
                _request.body = req_body
                _request.headers['authorization'] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = UtilClient.read_as_string(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        'code': resp_map.get('Code'),
                        'message': resp_map.get('Message'),
                        'data': {
                            'httpCode': _response.status_code,
                            'requestId': resp_map.get('RequestId'),
                            'hostId': resp_map.get('HostId')
                        }
                    })
                body_str = UtilClient.read_as_string(_response.body)
                resp_map = XMLClient.parse_xml(body_str, oss_models.PutLiveChannelResponse())
                return oss_models.PutLiveChannelResponse().from_map(
                    TeaCore.merge({
                        'CreateLiveChannelResult': resp_map.get('CreateLiveChannelResult')
                    }, _response.headers)
                )
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    async def put_live_channel_async(
        self,
        request: oss_models.PutLiveChannelRequest,
        runtime: ossutil_models.RuntimeOptions,
    ) -> oss_models.PutLiveChannelResponse:
        request.validate()
        runtime.validate()
        _runtime = {
            'timeouted': 'retry',
            'readTimeout': UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            'connectTimeout': UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            'localAddr': UtilClient.default_string(runtime.local_addr, self._local_addr),
            'httpProxy': UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            'httpsProxy': UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            'noProxy': UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            'socks5Proxy': UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            'socks5NetWork': UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            'maxIdleConns': UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            'retry': {
                'retryable': runtime.autoretry,
                'maxAttempts': UtilClient.default_number(runtime.max_attempts, 3)
            },
            'backoff': {
                'policy': UtilClient.default_string(runtime.backoff_policy, 'no'),
                'period': UtilClient.default_number(runtime.backoff_period, 1)
            },
            'ignoreSSL': runtime.ignore_ssl
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
                access_key_id = await self._credential.get_access_key_id_async()
                access_key_secret = await self._credential.get_access_key_secret_async()
                token = await self._credential.get_security_token_async()
                req_body = XMLClient.to_xml(TeaCore.to_map(request.body))
                _request.protocol = self._protocol
                _request.method = 'PUT'
                _request.pathname = f'/{request.channel_name}?live'
                _request.headers = {
                    'host': OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    'date': UtilClient.get_date_utcstring(),
                    'user-agent': self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers['x-oss-security-token'] = token
                _request.body = req_body
                _request.headers['authorization'] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = await TeaCore.async_do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = await UtilClient.read_as_string_async(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        'code': resp_map.get('Code'),
                        'message': resp_map.get('Message'),
                        'data': {
                            'httpCode': _response.status_code,
                            'requestId': resp_map.get('RequestId'),
                            'hostId': resp_map.get('HostId')
                        }
                    })
                body_str = await UtilClient.read_as_string_async(_response.body)
                resp_map = XMLClient.parse_xml(body_str, oss_models.PutLiveChannelResponse())
                return oss_models.PutLiveChannelResponse().from_map(
                    TeaCore.merge({
                        'CreateLiveChannelResult': resp_map.get('CreateLiveChannelResult')
                    }, _response.headers)
                )
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def put_bucket_tags(
        self,
        request: oss_models.PutBucketTagsRequest,
        runtime: ossutil_models.RuntimeOptions,
    ) -> oss_models.PutBucketTagsResponse:
        request.validate()
        runtime.validate()
        _runtime = {
            'timeouted': 'retry',
            'readTimeout': UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            'connectTimeout': UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            'localAddr': UtilClient.default_string(runtime.local_addr, self._local_addr),
            'httpProxy': UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            'httpsProxy': UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            'noProxy': UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            'socks5Proxy': UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            'socks5NetWork': UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            'maxIdleConns': UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            'retry': {
                'retryable': runtime.autoretry,
                'maxAttempts': UtilClient.default_number(runtime.max_attempts, 3)
            },
            'backoff': {
                'policy': UtilClient.default_string(runtime.backoff_policy, 'no'),
                'period': UtilClient.default_number(runtime.backoff_period, 1)
            },
            'ignoreSSL': runtime.ignore_ssl
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
                req_body = XMLClient.to_xml(TeaCore.to_map(request.body))
                _request.protocol = self._protocol
                _request.method = 'PUT'
                _request.pathname = f'/?tagging'
                _request.headers = {
                    'host': OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    'date': UtilClient.get_date_utcstring(),
                    'user-agent': self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers['x-oss-security-token'] = token
                _request.body = req_body
                _request.headers['authorization'] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = UtilClient.read_as_string(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        'code': resp_map.get('Code'),
                        'message': resp_map.get('Message'),
                        'data': {
                            'httpCode': _response.status_code,
                            'requestId': resp_map.get('RequestId'),
                            'hostId': resp_map.get('HostId')
                        }
                    })
                return oss_models.PutBucketTagsResponse().from_map(
                    TeaCore.merge(_response.headers)
                )
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    async def put_bucket_tags_async(
        self,
        request: oss_models.PutBucketTagsRequest,
        runtime: ossutil_models.RuntimeOptions,
    ) -> oss_models.PutBucketTagsResponse:
        request.validate()
        runtime.validate()
        _runtime = {
            'timeouted': 'retry',
            'readTimeout': UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            'connectTimeout': UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            'localAddr': UtilClient.default_string(runtime.local_addr, self._local_addr),
            'httpProxy': UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            'httpsProxy': UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            'noProxy': UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            'socks5Proxy': UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            'socks5NetWork': UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            'maxIdleConns': UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            'retry': {
                'retryable': runtime.autoretry,
                'maxAttempts': UtilClient.default_number(runtime.max_attempts, 3)
            },
            'backoff': {
                'policy': UtilClient.default_string(runtime.backoff_policy, 'no'),
                'period': UtilClient.default_number(runtime.backoff_period, 1)
            },
            'ignoreSSL': runtime.ignore_ssl
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
                access_key_id = await self._credential.get_access_key_id_async()
                access_key_secret = await self._credential.get_access_key_secret_async()
                token = await self._credential.get_security_token_async()
                req_body = XMLClient.to_xml(TeaCore.to_map(request.body))
                _request.protocol = self._protocol
                _request.method = 'PUT'
                _request.pathname = f'/?tagging'
                _request.headers = {
                    'host': OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    'date': UtilClient.get_date_utcstring(),
                    'user-agent': self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers['x-oss-security-token'] = token
                _request.body = req_body
                _request.headers['authorization'] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = await TeaCore.async_do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = await UtilClient.read_as_string_async(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        'code': resp_map.get('Code'),
                        'message': resp_map.get('Message'),
                        'data': {
                            'httpCode': _response.status_code,
                            'requestId': resp_map.get('RequestId'),
                            'hostId': resp_map.get('HostId')
                        }
                    })
                return oss_models.PutBucketTagsResponse().from_map(
                    TeaCore.merge(_response.headers)
                )
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def put_object_tagging(
        self,
        request: oss_models.PutObjectTaggingRequest,
        runtime: ossutil_models.RuntimeOptions,
    ) -> oss_models.PutObjectTaggingResponse:
        request.validate()
        runtime.validate()
        _runtime = {
            'timeouted': 'retry',
            'readTimeout': UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            'connectTimeout': UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            'localAddr': UtilClient.default_string(runtime.local_addr, self._local_addr),
            'httpProxy': UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            'httpsProxy': UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            'noProxy': UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            'socks5Proxy': UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            'socks5NetWork': UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            'maxIdleConns': UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            'retry': {
                'retryable': runtime.autoretry,
                'maxAttempts': UtilClient.default_number(runtime.max_attempts, 3)
            },
            'backoff': {
                'policy': UtilClient.default_string(runtime.backoff_policy, 'no'),
                'period': UtilClient.default_number(runtime.backoff_period, 1)
            },
            'ignoreSSL': runtime.ignore_ssl
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
                req_body = XMLClient.to_xml(TeaCore.to_map(request.body))
                _request.protocol = self._protocol
                _request.method = 'PUT'
                _request.pathname = f'/{request.object_name}?tagging'
                _request.headers = {
                    'host': OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    'date': UtilClient.get_date_utcstring(),
                    'user-agent': self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers['x-oss-security-token'] = token
                _request.body = req_body
                _request.headers['authorization'] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = UtilClient.read_as_string(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        'code': resp_map.get('Code'),
                        'message': resp_map.get('Message'),
                        'data': {
                            'httpCode': _response.status_code,
                            'requestId': resp_map.get('RequestId'),
                            'hostId': resp_map.get('HostId')
                        }
                    })
                return oss_models.PutObjectTaggingResponse().from_map(
                    TeaCore.merge(_response.headers)
                )
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    async def put_object_tagging_async(
        self,
        request: oss_models.PutObjectTaggingRequest,
        runtime: ossutil_models.RuntimeOptions,
    ) -> oss_models.PutObjectTaggingResponse:
        request.validate()
        runtime.validate()
        _runtime = {
            'timeouted': 'retry',
            'readTimeout': UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            'connectTimeout': UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            'localAddr': UtilClient.default_string(runtime.local_addr, self._local_addr),
            'httpProxy': UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            'httpsProxy': UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            'noProxy': UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            'socks5Proxy': UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            'socks5NetWork': UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            'maxIdleConns': UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            'retry': {
                'retryable': runtime.autoretry,
                'maxAttempts': UtilClient.default_number(runtime.max_attempts, 3)
            },
            'backoff': {
                'policy': UtilClient.default_string(runtime.backoff_policy, 'no'),
                'period': UtilClient.default_number(runtime.backoff_period, 1)
            },
            'ignoreSSL': runtime.ignore_ssl
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
                access_key_id = await self._credential.get_access_key_id_async()
                access_key_secret = await self._credential.get_access_key_secret_async()
                token = await self._credential.get_security_token_async()
                req_body = XMLClient.to_xml(TeaCore.to_map(request.body))
                _request.protocol = self._protocol
                _request.method = 'PUT'
                _request.pathname = f'/{request.object_name}?tagging'
                _request.headers = {
                    'host': OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    'date': UtilClient.get_date_utcstring(),
                    'user-agent': self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers['x-oss-security-token'] = token
                _request.body = req_body
                _request.headers['authorization'] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = await TeaCore.async_do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = await UtilClient.read_as_string_async(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        'code': resp_map.get('Code'),
                        'message': resp_map.get('Message'),
                        'data': {
                            'httpCode': _response.status_code,
                            'requestId': resp_map.get('RequestId'),
                            'hostId': resp_map.get('HostId')
                        }
                    })
                return oss_models.PutObjectTaggingResponse().from_map(
                    TeaCore.merge(_response.headers)
                )
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def select_object(
        self,
        request: oss_models.SelectObjectRequest,
        runtime: ossutil_models.RuntimeOptions,
    ) -> oss_models.SelectObjectResponse:
        request.validate()
        runtime.validate()
        _runtime = {
            'timeouted': 'retry',
            'readTimeout': UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            'connectTimeout': UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            'localAddr': UtilClient.default_string(runtime.local_addr, self._local_addr),
            'httpProxy': UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            'httpsProxy': UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            'noProxy': UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            'socks5Proxy': UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            'socks5NetWork': UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            'maxIdleConns': UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            'retry': {
                'retryable': runtime.autoretry,
                'maxAttempts': UtilClient.default_number(runtime.max_attempts, 3)
            },
            'backoff': {
                'policy': UtilClient.default_string(runtime.backoff_policy, 'no'),
                'period': UtilClient.default_number(runtime.backoff_period, 1)
            },
            'ignoreSSL': runtime.ignore_ssl
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
                req_body = XMLClient.to_xml(TeaCore.to_map(request.body))
                _request.protocol = self._protocol
                _request.method = 'POST'
                _request.pathname = f'/{request.object_name}'
                _request.headers = {
                    'host': OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    'date': UtilClient.get_date_utcstring(),
                    'user-agent': self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers['x-oss-security-token'] = token
                _request.query = UtilClient.stringify_map_value(TeaCore.to_map(request.filter))
                _request.body = req_body
                _request.headers['authorization'] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = UtilClient.read_as_string(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        'code': resp_map.get('Code'),
                        'message': resp_map.get('Message'),
                        'data': {
                            'httpCode': _response.status_code,
                            'requestId': resp_map.get('RequestId'),
                            'hostId': resp_map.get('HostId')
                        }
                    })
                return oss_models.SelectObjectResponse().from_map(
                    TeaCore.merge(_response.headers)
                )
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    async def select_object_async(
        self,
        request: oss_models.SelectObjectRequest,
        runtime: ossutil_models.RuntimeOptions,
    ) -> oss_models.SelectObjectResponse:
        request.validate()
        runtime.validate()
        _runtime = {
            'timeouted': 'retry',
            'readTimeout': UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            'connectTimeout': UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            'localAddr': UtilClient.default_string(runtime.local_addr, self._local_addr),
            'httpProxy': UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            'httpsProxy': UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            'noProxy': UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            'socks5Proxy': UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            'socks5NetWork': UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            'maxIdleConns': UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            'retry': {
                'retryable': runtime.autoretry,
                'maxAttempts': UtilClient.default_number(runtime.max_attempts, 3)
            },
            'backoff': {
                'policy': UtilClient.default_string(runtime.backoff_policy, 'no'),
                'period': UtilClient.default_number(runtime.backoff_period, 1)
            },
            'ignoreSSL': runtime.ignore_ssl
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
                access_key_id = await self._credential.get_access_key_id_async()
                access_key_secret = await self._credential.get_access_key_secret_async()
                token = await self._credential.get_security_token_async()
                req_body = XMLClient.to_xml(TeaCore.to_map(request.body))
                _request.protocol = self._protocol
                _request.method = 'POST'
                _request.pathname = f'/{request.object_name}'
                _request.headers = {
                    'host': OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    'date': UtilClient.get_date_utcstring(),
                    'user-agent': self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers['x-oss-security-token'] = token
                _request.query = UtilClient.stringify_map_value(TeaCore.to_map(request.filter))
                _request.body = req_body
                _request.headers['authorization'] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = await TeaCore.async_do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = await UtilClient.read_as_string_async(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        'code': resp_map.get('Code'),
                        'message': resp_map.get('Message'),
                        'data': {
                            'httpCode': _response.status_code,
                            'requestId': resp_map.get('RequestId'),
                            'hostId': resp_map.get('HostId')
                        }
                    })
                return oss_models.SelectObjectResponse().from_map(
                    TeaCore.merge(_response.headers)
                )
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def put_bucket_cors(
        self,
        request: oss_models.PutBucketCORSRequest,
        runtime: ossutil_models.RuntimeOptions,
    ) -> oss_models.PutBucketCORSResponse:
        request.validate()
        runtime.validate()
        _runtime = {
            'timeouted': 'retry',
            'readTimeout': UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            'connectTimeout': UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            'localAddr': UtilClient.default_string(runtime.local_addr, self._local_addr),
            'httpProxy': UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            'httpsProxy': UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            'noProxy': UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            'socks5Proxy': UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            'socks5NetWork': UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            'maxIdleConns': UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            'retry': {
                'retryable': runtime.autoretry,
                'maxAttempts': UtilClient.default_number(runtime.max_attempts, 3)
            },
            'backoff': {
                'policy': UtilClient.default_string(runtime.backoff_policy, 'no'),
                'period': UtilClient.default_number(runtime.backoff_period, 1)
            },
            'ignoreSSL': runtime.ignore_ssl
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
                req_body = XMLClient.to_xml(TeaCore.to_map(request.body))
                _request.protocol = self._protocol
                _request.method = 'PUT'
                _request.pathname = f'/?cors'
                _request.headers = {
                    'host': OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    'date': UtilClient.get_date_utcstring(),
                    'user-agent': self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers['x-oss-security-token'] = token
                _request.body = req_body
                _request.headers['authorization'] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = UtilClient.read_as_string(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        'code': resp_map.get('Code'),
                        'message': resp_map.get('Message'),
                        'data': {
                            'httpCode': _response.status_code,
                            'requestId': resp_map.get('RequestId'),
                            'hostId': resp_map.get('HostId')
                        }
                    })
                return oss_models.PutBucketCORSResponse().from_map(
                    TeaCore.merge(_response.headers)
                )
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    async def put_bucket_cors_async(
        self,
        request: oss_models.PutBucketCORSRequest,
        runtime: ossutil_models.RuntimeOptions,
    ) -> oss_models.PutBucketCORSResponse:
        request.validate()
        runtime.validate()
        _runtime = {
            'timeouted': 'retry',
            'readTimeout': UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            'connectTimeout': UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            'localAddr': UtilClient.default_string(runtime.local_addr, self._local_addr),
            'httpProxy': UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            'httpsProxy': UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            'noProxy': UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            'socks5Proxy': UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            'socks5NetWork': UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            'maxIdleConns': UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            'retry': {
                'retryable': runtime.autoretry,
                'maxAttempts': UtilClient.default_number(runtime.max_attempts, 3)
            },
            'backoff': {
                'policy': UtilClient.default_string(runtime.backoff_policy, 'no'),
                'period': UtilClient.default_number(runtime.backoff_period, 1)
            },
            'ignoreSSL': runtime.ignore_ssl
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
                access_key_id = await self._credential.get_access_key_id_async()
                access_key_secret = await self._credential.get_access_key_secret_async()
                token = await self._credential.get_security_token_async()
                req_body = XMLClient.to_xml(TeaCore.to_map(request.body))
                _request.protocol = self._protocol
                _request.method = 'PUT'
                _request.pathname = f'/?cors'
                _request.headers = {
                    'host': OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    'date': UtilClient.get_date_utcstring(),
                    'user-agent': self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers['x-oss-security-token'] = token
                _request.body = req_body
                _request.headers['authorization'] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = await TeaCore.async_do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = await UtilClient.read_as_string_async(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        'code': resp_map.get('Code'),
                        'message': resp_map.get('Message'),
                        'data': {
                            'httpCode': _response.status_code,
                            'requestId': resp_map.get('RequestId'),
                            'hostId': resp_map.get('HostId')
                        }
                    })
                return oss_models.PutBucketCORSResponse().from_map(
                    TeaCore.merge(_response.headers)
                )
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def put_bucket(
        self,
        request: oss_models.PutBucketRequest,
        runtime: ossutil_models.RuntimeOptions,
    ) -> oss_models.PutBucketResponse:
        request.validate()
        runtime.validate()
        _runtime = {
            'timeouted': 'retry',
            'readTimeout': UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            'connectTimeout': UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            'localAddr': UtilClient.default_string(runtime.local_addr, self._local_addr),
            'httpProxy': UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            'httpsProxy': UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            'noProxy': UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            'socks5Proxy': UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            'socks5NetWork': UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            'maxIdleConns': UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            'retry': {
                'retryable': runtime.autoretry,
                'maxAttempts': UtilClient.default_number(runtime.max_attempts, 3)
            },
            'backoff': {
                'policy': UtilClient.default_string(runtime.backoff_policy, 'no'),
                'period': UtilClient.default_number(runtime.backoff_period, 1)
            },
            'ignoreSSL': runtime.ignore_ssl
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
                req_body = XMLClient.to_xml(TeaCore.to_map(request.body))
                _request.protocol = self._protocol
                _request.method = 'PUT'
                _request.pathname = f'/'
                _request.headers = TeaCore.merge({
                    'host': OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    'date': UtilClient.get_date_utcstring(),
                    'user-agent': self.get_user_agent()
                }, UtilClient.stringify_map_value(TeaCore.to_map(request.header)))
                if not UtilClient.empty(token):
                    _request.headers['x-oss-security-token'] = token
                _request.body = req_body
                _request.headers['authorization'] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = UtilClient.read_as_string(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        'code': resp_map.get('Code'),
                        'message': resp_map.get('Message'),
                        'data': {
                            'httpCode': _response.status_code,
                            'requestId': resp_map.get('RequestId'),
                            'hostId': resp_map.get('HostId')
                        }
                    })
                return oss_models.PutBucketResponse().from_map(
                    TeaCore.merge(_response.headers)
                )
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    async def put_bucket_async(
        self,
        request: oss_models.PutBucketRequest,
        runtime: ossutil_models.RuntimeOptions,
    ) -> oss_models.PutBucketResponse:
        request.validate()
        runtime.validate()
        _runtime = {
            'timeouted': 'retry',
            'readTimeout': UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            'connectTimeout': UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            'localAddr': UtilClient.default_string(runtime.local_addr, self._local_addr),
            'httpProxy': UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            'httpsProxy': UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            'noProxy': UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            'socks5Proxy': UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            'socks5NetWork': UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            'maxIdleConns': UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            'retry': {
                'retryable': runtime.autoretry,
                'maxAttempts': UtilClient.default_number(runtime.max_attempts, 3)
            },
            'backoff': {
                'policy': UtilClient.default_string(runtime.backoff_policy, 'no'),
                'period': UtilClient.default_number(runtime.backoff_period, 1)
            },
            'ignoreSSL': runtime.ignore_ssl
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
                access_key_id = await self._credential.get_access_key_id_async()
                access_key_secret = await self._credential.get_access_key_secret_async()
                token = await self._credential.get_security_token_async()
                req_body = XMLClient.to_xml(TeaCore.to_map(request.body))
                _request.protocol = self._protocol
                _request.method = 'PUT'
                _request.pathname = f'/'
                _request.headers = TeaCore.merge({
                    'host': OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    'date': UtilClient.get_date_utcstring(),
                    'user-agent': self.get_user_agent()
                }, UtilClient.stringify_map_value(TeaCore.to_map(request.header)))
                if not UtilClient.empty(token):
                    _request.headers['x-oss-security-token'] = token
                _request.body = req_body
                _request.headers['authorization'] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = await TeaCore.async_do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = await UtilClient.read_as_string_async(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        'code': resp_map.get('Code'),
                        'message': resp_map.get('Message'),
                        'data': {
                            'httpCode': _response.status_code,
                            'requestId': resp_map.get('RequestId'),
                            'hostId': resp_map.get('HostId')
                        }
                    })
                return oss_models.PutBucketResponse().from_map(
                    TeaCore.merge(_response.headers)
                )
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def list_multipart_uploads(
        self,
        request: oss_models.ListMultipartUploadsRequest,
        runtime: ossutil_models.RuntimeOptions,
    ) -> oss_models.ListMultipartUploadsResponse:
        request.validate()
        runtime.validate()
        _runtime = {
            'timeouted': 'retry',
            'readTimeout': UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            'connectTimeout': UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            'localAddr': UtilClient.default_string(runtime.local_addr, self._local_addr),
            'httpProxy': UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            'httpsProxy': UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            'noProxy': UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            'socks5Proxy': UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            'socks5NetWork': UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            'maxIdleConns': UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            'retry': {
                'retryable': runtime.autoretry,
                'maxAttempts': UtilClient.default_number(runtime.max_attempts, 3)
            },
            'backoff': {
                'policy': UtilClient.default_string(runtime.backoff_policy, 'no'),
                'period': UtilClient.default_number(runtime.backoff_period, 1)
            },
            'ignoreSSL': runtime.ignore_ssl
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
                _request.method = 'GET'
                _request.pathname = f'/?uploads'
                _request.headers = {
                    'host': OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    'date': UtilClient.get_date_utcstring(),
                    'user-agent': self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers['x-oss-security-token'] = token
                _request.query = UtilClient.stringify_map_value(TeaCore.to_map(request.filter))
                _request.headers['authorization'] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = UtilClient.read_as_string(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        'code': resp_map.get('Code'),
                        'message': resp_map.get('Message'),
                        'data': {
                            'httpCode': _response.status_code,
                            'requestId': resp_map.get('RequestId'),
                            'hostId': resp_map.get('HostId')
                        }
                    })
                body_str = UtilClient.read_as_string(_response.body)
                resp_map = XMLClient.parse_xml(body_str, oss_models.ListMultipartUploadsResponse())
                return oss_models.ListMultipartUploadsResponse().from_map(
                    TeaCore.merge({
                        'ListMultipartUploadsResult': resp_map.get('ListMultipartUploadsResult')
                    }, _response.headers)
                )
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    async def list_multipart_uploads_async(
        self,
        request: oss_models.ListMultipartUploadsRequest,
        runtime: ossutil_models.RuntimeOptions,
    ) -> oss_models.ListMultipartUploadsResponse:
        request.validate()
        runtime.validate()
        _runtime = {
            'timeouted': 'retry',
            'readTimeout': UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            'connectTimeout': UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            'localAddr': UtilClient.default_string(runtime.local_addr, self._local_addr),
            'httpProxy': UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            'httpsProxy': UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            'noProxy': UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            'socks5Proxy': UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            'socks5NetWork': UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            'maxIdleConns': UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            'retry': {
                'retryable': runtime.autoretry,
                'maxAttempts': UtilClient.default_number(runtime.max_attempts, 3)
            },
            'backoff': {
                'policy': UtilClient.default_string(runtime.backoff_policy, 'no'),
                'period': UtilClient.default_number(runtime.backoff_period, 1)
            },
            'ignoreSSL': runtime.ignore_ssl
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
                access_key_id = await self._credential.get_access_key_id_async()
                access_key_secret = await self._credential.get_access_key_secret_async()
                token = await self._credential.get_security_token_async()
                _request.protocol = self._protocol
                _request.method = 'GET'
                _request.pathname = f'/?uploads'
                _request.headers = {
                    'host': OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    'date': UtilClient.get_date_utcstring(),
                    'user-agent': self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers['x-oss-security-token'] = token
                _request.query = UtilClient.stringify_map_value(TeaCore.to_map(request.filter))
                _request.headers['authorization'] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = await TeaCore.async_do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = await UtilClient.read_as_string_async(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        'code': resp_map.get('Code'),
                        'message': resp_map.get('Message'),
                        'data': {
                            'httpCode': _response.status_code,
                            'requestId': resp_map.get('RequestId'),
                            'hostId': resp_map.get('HostId')
                        }
                    })
                body_str = await UtilClient.read_as_string_async(_response.body)
                resp_map = XMLClient.parse_xml(body_str, oss_models.ListMultipartUploadsResponse())
                return oss_models.ListMultipartUploadsResponse().from_map(
                    TeaCore.merge({
                        'ListMultipartUploadsResult': resp_map.get('ListMultipartUploadsResult')
                    }, _response.headers)
                )
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def get_bucket_request_payment(
        self,
        request: oss_models.GetBucketRequestPaymentRequest,
        runtime: ossutil_models.RuntimeOptions,
    ) -> oss_models.GetBucketRequestPaymentResponse:
        request.validate()
        runtime.validate()
        _runtime = {
            'timeouted': 'retry',
            'readTimeout': UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            'connectTimeout': UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            'localAddr': UtilClient.default_string(runtime.local_addr, self._local_addr),
            'httpProxy': UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            'httpsProxy': UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            'noProxy': UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            'socks5Proxy': UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            'socks5NetWork': UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            'maxIdleConns': UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            'retry': {
                'retryable': runtime.autoretry,
                'maxAttempts': UtilClient.default_number(runtime.max_attempts, 3)
            },
            'backoff': {
                'policy': UtilClient.default_string(runtime.backoff_policy, 'no'),
                'period': UtilClient.default_number(runtime.backoff_period, 1)
            },
            'ignoreSSL': runtime.ignore_ssl
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
                _request.method = 'GET'
                _request.pathname = f'/?requestPayment'
                _request.headers = {
                    'host': OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    'date': UtilClient.get_date_utcstring(),
                    'user-agent': self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers['x-oss-security-token'] = token
                _request.headers['authorization'] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = UtilClient.read_as_string(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        'code': resp_map.get('Code'),
                        'message': resp_map.get('Message'),
                        'data': {
                            'httpCode': _response.status_code,
                            'requestId': resp_map.get('RequestId'),
                            'hostId': resp_map.get('HostId')
                        }
                    })
                body_str = UtilClient.read_as_string(_response.body)
                resp_map = XMLClient.parse_xml(body_str, oss_models.GetBucketRequestPaymentResponse())
                return oss_models.GetBucketRequestPaymentResponse().from_map(
                    TeaCore.merge({
                        'RequestPaymentConfiguration': resp_map.get('RequestPaymentConfiguration')
                    }, _response.headers)
                )
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    async def get_bucket_request_payment_async(
        self,
        request: oss_models.GetBucketRequestPaymentRequest,
        runtime: ossutil_models.RuntimeOptions,
    ) -> oss_models.GetBucketRequestPaymentResponse:
        request.validate()
        runtime.validate()
        _runtime = {
            'timeouted': 'retry',
            'readTimeout': UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            'connectTimeout': UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            'localAddr': UtilClient.default_string(runtime.local_addr, self._local_addr),
            'httpProxy': UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            'httpsProxy': UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            'noProxy': UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            'socks5Proxy': UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            'socks5NetWork': UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            'maxIdleConns': UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            'retry': {
                'retryable': runtime.autoretry,
                'maxAttempts': UtilClient.default_number(runtime.max_attempts, 3)
            },
            'backoff': {
                'policy': UtilClient.default_string(runtime.backoff_policy, 'no'),
                'period': UtilClient.default_number(runtime.backoff_period, 1)
            },
            'ignoreSSL': runtime.ignore_ssl
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
                access_key_id = await self._credential.get_access_key_id_async()
                access_key_secret = await self._credential.get_access_key_secret_async()
                token = await self._credential.get_security_token_async()
                _request.protocol = self._protocol
                _request.method = 'GET'
                _request.pathname = f'/?requestPayment'
                _request.headers = {
                    'host': OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    'date': UtilClient.get_date_utcstring(),
                    'user-agent': self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers['x-oss-security-token'] = token
                _request.headers['authorization'] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = await TeaCore.async_do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = await UtilClient.read_as_string_async(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        'code': resp_map.get('Code'),
                        'message': resp_map.get('Message'),
                        'data': {
                            'httpCode': _response.status_code,
                            'requestId': resp_map.get('RequestId'),
                            'hostId': resp_map.get('HostId')
                        }
                    })
                body_str = await UtilClient.read_as_string_async(_response.body)
                resp_map = XMLClient.parse_xml(body_str, oss_models.GetBucketRequestPaymentResponse())
                return oss_models.GetBucketRequestPaymentResponse().from_map(
                    TeaCore.merge({
                        'RequestPaymentConfiguration': resp_map.get('RequestPaymentConfiguration')
                    }, _response.headers)
                )
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def get_bucket_encryption(
        self,
        request: oss_models.GetBucketEncryptionRequest,
        runtime: ossutil_models.RuntimeOptions,
    ) -> oss_models.GetBucketEncryptionResponse:
        request.validate()
        runtime.validate()
        _runtime = {
            'timeouted': 'retry',
            'readTimeout': UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            'connectTimeout': UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            'localAddr': UtilClient.default_string(runtime.local_addr, self._local_addr),
            'httpProxy': UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            'httpsProxy': UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            'noProxy': UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            'socks5Proxy': UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            'socks5NetWork': UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            'maxIdleConns': UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            'retry': {
                'retryable': runtime.autoretry,
                'maxAttempts': UtilClient.default_number(runtime.max_attempts, 3)
            },
            'backoff': {
                'policy': UtilClient.default_string(runtime.backoff_policy, 'no'),
                'period': UtilClient.default_number(runtime.backoff_period, 1)
            },
            'ignoreSSL': runtime.ignore_ssl
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
                _request.method = 'GET'
                _request.pathname = f'/?encryption'
                _request.headers = {
                    'host': OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    'date': UtilClient.get_date_utcstring(),
                    'user-agent': self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers['x-oss-security-token'] = token
                _request.headers['authorization'] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = UtilClient.read_as_string(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        'code': resp_map.get('Code'),
                        'message': resp_map.get('Message'),
                        'data': {
                            'httpCode': _response.status_code,
                            'requestId': resp_map.get('RequestId'),
                            'hostId': resp_map.get('HostId')
                        }
                    })
                body_str = UtilClient.read_as_string(_response.body)
                resp_map = XMLClient.parse_xml(body_str, oss_models.GetBucketEncryptionResponse())
                return oss_models.GetBucketEncryptionResponse().from_map(
                    TeaCore.merge({
                        'ServerSideEncryptionRule': resp_map.get('ServerSideEncryptionRule')
                    }, _response.headers)
                )
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    async def get_bucket_encryption_async(
        self,
        request: oss_models.GetBucketEncryptionRequest,
        runtime: ossutil_models.RuntimeOptions,
    ) -> oss_models.GetBucketEncryptionResponse:
        request.validate()
        runtime.validate()
        _runtime = {
            'timeouted': 'retry',
            'readTimeout': UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            'connectTimeout': UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            'localAddr': UtilClient.default_string(runtime.local_addr, self._local_addr),
            'httpProxy': UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            'httpsProxy': UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            'noProxy': UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            'socks5Proxy': UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            'socks5NetWork': UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            'maxIdleConns': UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            'retry': {
                'retryable': runtime.autoretry,
                'maxAttempts': UtilClient.default_number(runtime.max_attempts, 3)
            },
            'backoff': {
                'policy': UtilClient.default_string(runtime.backoff_policy, 'no'),
                'period': UtilClient.default_number(runtime.backoff_period, 1)
            },
            'ignoreSSL': runtime.ignore_ssl
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
                access_key_id = await self._credential.get_access_key_id_async()
                access_key_secret = await self._credential.get_access_key_secret_async()
                token = await self._credential.get_security_token_async()
                _request.protocol = self._protocol
                _request.method = 'GET'
                _request.pathname = f'/?encryption'
                _request.headers = {
                    'host': OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    'date': UtilClient.get_date_utcstring(),
                    'user-agent': self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers['x-oss-security-token'] = token
                _request.headers['authorization'] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = await TeaCore.async_do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = await UtilClient.read_as_string_async(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        'code': resp_map.get('Code'),
                        'message': resp_map.get('Message'),
                        'data': {
                            'httpCode': _response.status_code,
                            'requestId': resp_map.get('RequestId'),
                            'hostId': resp_map.get('HostId')
                        }
                    })
                body_str = await UtilClient.read_as_string_async(_response.body)
                resp_map = XMLClient.parse_xml(body_str, oss_models.GetBucketEncryptionResponse())
                return oss_models.GetBucketEncryptionResponse().from_map(
                    TeaCore.merge({
                        'ServerSideEncryptionRule': resp_map.get('ServerSideEncryptionRule')
                    }, _response.headers)
                )
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def get_bucket_tags(
        self,
        request: oss_models.GetBucketTagsRequest,
        runtime: ossutil_models.RuntimeOptions,
    ) -> oss_models.GetBucketTagsResponse:
        request.validate()
        runtime.validate()
        _runtime = {
            'timeouted': 'retry',
            'readTimeout': UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            'connectTimeout': UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            'localAddr': UtilClient.default_string(runtime.local_addr, self._local_addr),
            'httpProxy': UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            'httpsProxy': UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            'noProxy': UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            'socks5Proxy': UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            'socks5NetWork': UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            'maxIdleConns': UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            'retry': {
                'retryable': runtime.autoretry,
                'maxAttempts': UtilClient.default_number(runtime.max_attempts, 3)
            },
            'backoff': {
                'policy': UtilClient.default_string(runtime.backoff_policy, 'no'),
                'period': UtilClient.default_number(runtime.backoff_period, 1)
            },
            'ignoreSSL': runtime.ignore_ssl
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
                _request.method = 'GET'
                _request.pathname = f'/?tagging'
                _request.headers = {
                    'host': OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    'date': UtilClient.get_date_utcstring(),
                    'user-agent': self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers['x-oss-security-token'] = token
                _request.headers['authorization'] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = UtilClient.read_as_string(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        'code': resp_map.get('Code'),
                        'message': resp_map.get('Message'),
                        'data': {
                            'httpCode': _response.status_code,
                            'requestId': resp_map.get('RequestId'),
                            'hostId': resp_map.get('HostId')
                        }
                    })
                body_str = UtilClient.read_as_string(_response.body)
                resp_map = XMLClient.parse_xml(body_str, oss_models.GetBucketTagsResponse())
                return oss_models.GetBucketTagsResponse().from_map(
                    TeaCore.merge({
                        'Tagging': resp_map.get('Tagging')
                    }, _response.headers)
                )
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    async def get_bucket_tags_async(
        self,
        request: oss_models.GetBucketTagsRequest,
        runtime: ossutil_models.RuntimeOptions,
    ) -> oss_models.GetBucketTagsResponse:
        request.validate()
        runtime.validate()
        _runtime = {
            'timeouted': 'retry',
            'readTimeout': UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            'connectTimeout': UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            'localAddr': UtilClient.default_string(runtime.local_addr, self._local_addr),
            'httpProxy': UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            'httpsProxy': UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            'noProxy': UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            'socks5Proxy': UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            'socks5NetWork': UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            'maxIdleConns': UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            'retry': {
                'retryable': runtime.autoretry,
                'maxAttempts': UtilClient.default_number(runtime.max_attempts, 3)
            },
            'backoff': {
                'policy': UtilClient.default_string(runtime.backoff_policy, 'no'),
                'period': UtilClient.default_number(runtime.backoff_period, 1)
            },
            'ignoreSSL': runtime.ignore_ssl
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
                access_key_id = await self._credential.get_access_key_id_async()
                access_key_secret = await self._credential.get_access_key_secret_async()
                token = await self._credential.get_security_token_async()
                _request.protocol = self._protocol
                _request.method = 'GET'
                _request.pathname = f'/?tagging'
                _request.headers = {
                    'host': OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    'date': UtilClient.get_date_utcstring(),
                    'user-agent': self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers['x-oss-security-token'] = token
                _request.headers['authorization'] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = await TeaCore.async_do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = await UtilClient.read_as_string_async(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        'code': resp_map.get('Code'),
                        'message': resp_map.get('Message'),
                        'data': {
                            'httpCode': _response.status_code,
                            'requestId': resp_map.get('RequestId'),
                            'hostId': resp_map.get('HostId')
                        }
                    })
                body_str = await UtilClient.read_as_string_async(_response.body)
                resp_map = XMLClient.parse_xml(body_str, oss_models.GetBucketTagsResponse())
                return oss_models.GetBucketTagsResponse().from_map(
                    TeaCore.merge({
                        'Tagging': resp_map.get('Tagging')
                    }, _response.headers)
                )
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def get_service(
        self,
        request: oss_models.GetServiceRequest,
        runtime: ossutil_models.RuntimeOptions,
    ) -> oss_models.GetServiceResponse:
        request.validate()
        runtime.validate()
        _runtime = {
            'timeouted': 'retry',
            'readTimeout': UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            'connectTimeout': UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            'localAddr': UtilClient.default_string(runtime.local_addr, self._local_addr),
            'httpProxy': UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            'httpsProxy': UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            'noProxy': UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            'socks5Proxy': UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            'socks5NetWork': UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            'maxIdleConns': UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            'retry': {
                'retryable': runtime.autoretry,
                'maxAttempts': UtilClient.default_number(runtime.max_attempts, 3)
            },
            'backoff': {
                'policy': UtilClient.default_string(runtime.backoff_policy, 'no'),
                'period': UtilClient.default_number(runtime.backoff_period, 1)
            },
            'ignoreSSL': runtime.ignore_ssl
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
                _request.method = 'GET'
                _request.pathname = f'/'
                _request.headers = {
                    'host': OSSUtilClient.get_host('', self._region_id, self._endpoint, self._host_model),
                    'date': UtilClient.get_date_utcstring(),
                    'user-agent': self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers['x-oss-security-token'] = token
                _request.query = UtilClient.stringify_map_value(TeaCore.to_map(request.filter))
                _request.headers['authorization'] = OSSUtilClient.get_signature(_request, '', access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = UtilClient.read_as_string(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        'code': resp_map.get('Code'),
                        'message': resp_map.get('Message'),
                        'data': {
                            'httpCode': _response.status_code,
                            'requestId': resp_map.get('RequestId'),
                            'hostId': resp_map.get('HostId')
                        }
                    })
                body_str = UtilClient.read_as_string(_response.body)
                resp_map = XMLClient.parse_xml(body_str, oss_models.GetServiceResponse())
                return oss_models.GetServiceResponse().from_map(
                    TeaCore.merge({
                        'ListAllMyBucketsResult': resp_map.get('ListAllMyBucketsResult')
                    }, _response.headers)
                )
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    async def get_service_async(
        self,
        request: oss_models.GetServiceRequest,
        runtime: ossutil_models.RuntimeOptions,
    ) -> oss_models.GetServiceResponse:
        request.validate()
        runtime.validate()
        _runtime = {
            'timeouted': 'retry',
            'readTimeout': UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            'connectTimeout': UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            'localAddr': UtilClient.default_string(runtime.local_addr, self._local_addr),
            'httpProxy': UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            'httpsProxy': UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            'noProxy': UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            'socks5Proxy': UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            'socks5NetWork': UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            'maxIdleConns': UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            'retry': {
                'retryable': runtime.autoretry,
                'maxAttempts': UtilClient.default_number(runtime.max_attempts, 3)
            },
            'backoff': {
                'policy': UtilClient.default_string(runtime.backoff_policy, 'no'),
                'period': UtilClient.default_number(runtime.backoff_period, 1)
            },
            'ignoreSSL': runtime.ignore_ssl
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
                access_key_id = await self._credential.get_access_key_id_async()
                access_key_secret = await self._credential.get_access_key_secret_async()
                token = await self._credential.get_security_token_async()
                _request.protocol = self._protocol
                _request.method = 'GET'
                _request.pathname = f'/'
                _request.headers = {
                    'host': OSSUtilClient.get_host('', self._region_id, self._endpoint, self._host_model),
                    'date': UtilClient.get_date_utcstring(),
                    'user-agent': self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers['x-oss-security-token'] = token
                _request.query = UtilClient.stringify_map_value(TeaCore.to_map(request.filter))
                _request.headers['authorization'] = OSSUtilClient.get_signature(_request, '', access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = await TeaCore.async_do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = await UtilClient.read_as_string_async(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        'code': resp_map.get('Code'),
                        'message': resp_map.get('Message'),
                        'data': {
                            'httpCode': _response.status_code,
                            'requestId': resp_map.get('RequestId'),
                            'hostId': resp_map.get('HostId')
                        }
                    })
                body_str = await UtilClient.read_as_string_async(_response.body)
                resp_map = XMLClient.parse_xml(body_str, oss_models.GetServiceResponse())
                return oss_models.GetServiceResponse().from_map(
                    TeaCore.merge({
                        'ListAllMyBucketsResult': resp_map.get('ListAllMyBucketsResult')
                    }, _response.headers)
                )
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def delete_bucket_encryption(
        self,
        request: oss_models.DeleteBucketEncryptionRequest,
        runtime: ossutil_models.RuntimeOptions,
    ) -> oss_models.DeleteBucketEncryptionResponse:
        request.validate()
        runtime.validate()
        _runtime = {
            'timeouted': 'retry',
            'readTimeout': UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            'connectTimeout': UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            'localAddr': UtilClient.default_string(runtime.local_addr, self._local_addr),
            'httpProxy': UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            'httpsProxy': UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            'noProxy': UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            'socks5Proxy': UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            'socks5NetWork': UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            'maxIdleConns': UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            'retry': {
                'retryable': runtime.autoretry,
                'maxAttempts': UtilClient.default_number(runtime.max_attempts, 3)
            },
            'backoff': {
                'policy': UtilClient.default_string(runtime.backoff_policy, 'no'),
                'period': UtilClient.default_number(runtime.backoff_period, 1)
            },
            'ignoreSSL': runtime.ignore_ssl
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
                _request.method = 'DELETE'
                _request.pathname = f'/?encryption'
                _request.headers = {
                    'host': OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    'date': UtilClient.get_date_utcstring(),
                    'user-agent': self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers['x-oss-security-token'] = token
                _request.headers['authorization'] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = UtilClient.read_as_string(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        'code': resp_map.get('Code'),
                        'message': resp_map.get('Message'),
                        'data': {
                            'httpCode': _response.status_code,
                            'requestId': resp_map.get('RequestId'),
                            'hostId': resp_map.get('HostId')
                        }
                    })
                return oss_models.DeleteBucketEncryptionResponse().from_map(
                    TeaCore.merge(_response.headers)
                )
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    async def delete_bucket_encryption_async(
        self,
        request: oss_models.DeleteBucketEncryptionRequest,
        runtime: ossutil_models.RuntimeOptions,
    ) -> oss_models.DeleteBucketEncryptionResponse:
        request.validate()
        runtime.validate()
        _runtime = {
            'timeouted': 'retry',
            'readTimeout': UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            'connectTimeout': UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            'localAddr': UtilClient.default_string(runtime.local_addr, self._local_addr),
            'httpProxy': UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            'httpsProxy': UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            'noProxy': UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            'socks5Proxy': UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            'socks5NetWork': UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            'maxIdleConns': UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            'retry': {
                'retryable': runtime.autoretry,
                'maxAttempts': UtilClient.default_number(runtime.max_attempts, 3)
            },
            'backoff': {
                'policy': UtilClient.default_string(runtime.backoff_policy, 'no'),
                'period': UtilClient.default_number(runtime.backoff_period, 1)
            },
            'ignoreSSL': runtime.ignore_ssl
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
                access_key_id = await self._credential.get_access_key_id_async()
                access_key_secret = await self._credential.get_access_key_secret_async()
                token = await self._credential.get_security_token_async()
                _request.protocol = self._protocol
                _request.method = 'DELETE'
                _request.pathname = f'/?encryption'
                _request.headers = {
                    'host': OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    'date': UtilClient.get_date_utcstring(),
                    'user-agent': self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers['x-oss-security-token'] = token
                _request.headers['authorization'] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = await TeaCore.async_do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = await UtilClient.read_as_string_async(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        'code': resp_map.get('Code'),
                        'message': resp_map.get('Message'),
                        'data': {
                            'httpCode': _response.status_code,
                            'requestId': resp_map.get('RequestId'),
                            'hostId': resp_map.get('HostId')
                        }
                    })
                return oss_models.DeleteBucketEncryptionResponse().from_map(
                    TeaCore.merge(_response.headers)
                )
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def delete_bucket_tags(
        self,
        request: oss_models.DeleteBucketTagsRequest,
        runtime: ossutil_models.RuntimeOptions,
    ) -> oss_models.DeleteBucketTagsResponse:
        request.validate()
        runtime.validate()
        _runtime = {
            'timeouted': 'retry',
            'readTimeout': UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            'connectTimeout': UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            'localAddr': UtilClient.default_string(runtime.local_addr, self._local_addr),
            'httpProxy': UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            'httpsProxy': UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            'noProxy': UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            'socks5Proxy': UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            'socks5NetWork': UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            'maxIdleConns': UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            'retry': {
                'retryable': runtime.autoretry,
                'maxAttempts': UtilClient.default_number(runtime.max_attempts, 3)
            },
            'backoff': {
                'policy': UtilClient.default_string(runtime.backoff_policy, 'no'),
                'period': UtilClient.default_number(runtime.backoff_period, 1)
            },
            'ignoreSSL': runtime.ignore_ssl
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
                _request.method = 'DELETE'
                _request.pathname = f'/'
                _request.headers = {
                    'host': OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    'date': UtilClient.get_date_utcstring(),
                    'user-agent': self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers['x-oss-security-token'] = token
                _request.query = UtilClient.stringify_map_value(TeaCore.to_map(request.filter))
                _request.headers['authorization'] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = UtilClient.read_as_string(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        'code': resp_map.get('Code'),
                        'message': resp_map.get('Message'),
                        'data': {
                            'httpCode': _response.status_code,
                            'requestId': resp_map.get('RequestId'),
                            'hostId': resp_map.get('HostId')
                        }
                    })
                return oss_models.DeleteBucketTagsResponse().from_map(
                    TeaCore.merge(_response.headers)
                )
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    async def delete_bucket_tags_async(
        self,
        request: oss_models.DeleteBucketTagsRequest,
        runtime: ossutil_models.RuntimeOptions,
    ) -> oss_models.DeleteBucketTagsResponse:
        request.validate()
        runtime.validate()
        _runtime = {
            'timeouted': 'retry',
            'readTimeout': UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            'connectTimeout': UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            'localAddr': UtilClient.default_string(runtime.local_addr, self._local_addr),
            'httpProxy': UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            'httpsProxy': UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            'noProxy': UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            'socks5Proxy': UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            'socks5NetWork': UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            'maxIdleConns': UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            'retry': {
                'retryable': runtime.autoretry,
                'maxAttempts': UtilClient.default_number(runtime.max_attempts, 3)
            },
            'backoff': {
                'policy': UtilClient.default_string(runtime.backoff_policy, 'no'),
                'period': UtilClient.default_number(runtime.backoff_period, 1)
            },
            'ignoreSSL': runtime.ignore_ssl
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
                access_key_id = await self._credential.get_access_key_id_async()
                access_key_secret = await self._credential.get_access_key_secret_async()
                token = await self._credential.get_security_token_async()
                _request.protocol = self._protocol
                _request.method = 'DELETE'
                _request.pathname = f'/'
                _request.headers = {
                    'host': OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    'date': UtilClient.get_date_utcstring(),
                    'user-agent': self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers['x-oss-security-token'] = token
                _request.query = UtilClient.stringify_map_value(TeaCore.to_map(request.filter))
                _request.headers['authorization'] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = await TeaCore.async_do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = await UtilClient.read_as_string_async(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        'code': resp_map.get('Code'),
                        'message': resp_map.get('Message'),
                        'data': {
                            'httpCode': _response.status_code,
                            'requestId': resp_map.get('RequestId'),
                            'hostId': resp_map.get('HostId')
                        }
                    })
                return oss_models.DeleteBucketTagsResponse().from_map(
                    TeaCore.merge(_response.headers)
                )
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def get_bucket_website(
        self,
        request: oss_models.GetBucketWebsiteRequest,
        runtime: ossutil_models.RuntimeOptions,
    ) -> oss_models.GetBucketWebsiteResponse:
        request.validate()
        runtime.validate()
        _runtime = {
            'timeouted': 'retry',
            'readTimeout': UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            'connectTimeout': UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            'localAddr': UtilClient.default_string(runtime.local_addr, self._local_addr),
            'httpProxy': UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            'httpsProxy': UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            'noProxy': UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            'socks5Proxy': UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            'socks5NetWork': UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            'maxIdleConns': UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            'retry': {
                'retryable': runtime.autoretry,
                'maxAttempts': UtilClient.default_number(runtime.max_attempts, 3)
            },
            'backoff': {
                'policy': UtilClient.default_string(runtime.backoff_policy, 'no'),
                'period': UtilClient.default_number(runtime.backoff_period, 1)
            },
            'ignoreSSL': runtime.ignore_ssl
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
                _request.method = 'GET'
                _request.pathname = f'/?website'
                _request.headers = {
                    'host': OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    'date': UtilClient.get_date_utcstring(),
                    'user-agent': self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers['x-oss-security-token'] = token
                _request.headers['authorization'] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = UtilClient.read_as_string(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        'code': resp_map.get('Code'),
                        'message': resp_map.get('Message'),
                        'data': {
                            'httpCode': _response.status_code,
                            'requestId': resp_map.get('RequestId'),
                            'hostId': resp_map.get('HostId')
                        }
                    })
                body_str = UtilClient.read_as_string(_response.body)
                resp_map = XMLClient.parse_xml(body_str, oss_models.GetBucketWebsiteResponse())
                return oss_models.GetBucketWebsiteResponse().from_map(
                    TeaCore.merge({
                        'WebsiteConfiguration': resp_map.get('WebsiteConfiguration')
                    }, _response.headers)
                )
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    async def get_bucket_website_async(
        self,
        request: oss_models.GetBucketWebsiteRequest,
        runtime: ossutil_models.RuntimeOptions,
    ) -> oss_models.GetBucketWebsiteResponse:
        request.validate()
        runtime.validate()
        _runtime = {
            'timeouted': 'retry',
            'readTimeout': UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            'connectTimeout': UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            'localAddr': UtilClient.default_string(runtime.local_addr, self._local_addr),
            'httpProxy': UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            'httpsProxy': UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            'noProxy': UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            'socks5Proxy': UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            'socks5NetWork': UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            'maxIdleConns': UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            'retry': {
                'retryable': runtime.autoretry,
                'maxAttempts': UtilClient.default_number(runtime.max_attempts, 3)
            },
            'backoff': {
                'policy': UtilClient.default_string(runtime.backoff_policy, 'no'),
                'period': UtilClient.default_number(runtime.backoff_period, 1)
            },
            'ignoreSSL': runtime.ignore_ssl
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
                access_key_id = await self._credential.get_access_key_id_async()
                access_key_secret = await self._credential.get_access_key_secret_async()
                token = await self._credential.get_security_token_async()
                _request.protocol = self._protocol
                _request.method = 'GET'
                _request.pathname = f'/?website'
                _request.headers = {
                    'host': OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    'date': UtilClient.get_date_utcstring(),
                    'user-agent': self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers['x-oss-security-token'] = token
                _request.headers['authorization'] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = await TeaCore.async_do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = await UtilClient.read_as_string_async(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        'code': resp_map.get('Code'),
                        'message': resp_map.get('Message'),
                        'data': {
                            'httpCode': _response.status_code,
                            'requestId': resp_map.get('RequestId'),
                            'hostId': resp_map.get('HostId')
                        }
                    })
                body_str = await UtilClient.read_as_string_async(_response.body)
                resp_map = XMLClient.parse_xml(body_str, oss_models.GetBucketWebsiteResponse())
                return oss_models.GetBucketWebsiteResponse().from_map(
                    TeaCore.merge({
                        'WebsiteConfiguration': resp_map.get('WebsiteConfiguration')
                    }, _response.headers)
                )
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def delete_live_channel(
        self,
        request: oss_models.DeleteLiveChannelRequest,
        runtime: ossutil_models.RuntimeOptions,
    ) -> oss_models.DeleteLiveChannelResponse:
        request.validate()
        runtime.validate()
        _runtime = {
            'timeouted': 'retry',
            'readTimeout': UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            'connectTimeout': UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            'localAddr': UtilClient.default_string(runtime.local_addr, self._local_addr),
            'httpProxy': UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            'httpsProxy': UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            'noProxy': UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            'socks5Proxy': UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            'socks5NetWork': UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            'maxIdleConns': UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            'retry': {
                'retryable': runtime.autoretry,
                'maxAttempts': UtilClient.default_number(runtime.max_attempts, 3)
            },
            'backoff': {
                'policy': UtilClient.default_string(runtime.backoff_policy, 'no'),
                'period': UtilClient.default_number(runtime.backoff_period, 1)
            },
            'ignoreSSL': runtime.ignore_ssl
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
                _request.method = 'DELETE'
                _request.pathname = f'/{request.channel_name}?live'
                _request.headers = {
                    'host': OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    'date': UtilClient.get_date_utcstring(),
                    'user-agent': self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers['x-oss-security-token'] = token
                _request.headers['authorization'] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = UtilClient.read_as_string(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        'code': resp_map.get('Code'),
                        'message': resp_map.get('Message'),
                        'data': {
                            'httpCode': _response.status_code,
                            'requestId': resp_map.get('RequestId'),
                            'hostId': resp_map.get('HostId')
                        }
                    })
                return oss_models.DeleteLiveChannelResponse().from_map(
                    TeaCore.merge(_response.headers)
                )
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    async def delete_live_channel_async(
        self,
        request: oss_models.DeleteLiveChannelRequest,
        runtime: ossutil_models.RuntimeOptions,
    ) -> oss_models.DeleteLiveChannelResponse:
        request.validate()
        runtime.validate()
        _runtime = {
            'timeouted': 'retry',
            'readTimeout': UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            'connectTimeout': UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            'localAddr': UtilClient.default_string(runtime.local_addr, self._local_addr),
            'httpProxy': UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            'httpsProxy': UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            'noProxy': UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            'socks5Proxy': UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            'socks5NetWork': UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            'maxIdleConns': UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            'retry': {
                'retryable': runtime.autoretry,
                'maxAttempts': UtilClient.default_number(runtime.max_attempts, 3)
            },
            'backoff': {
                'policy': UtilClient.default_string(runtime.backoff_policy, 'no'),
                'period': UtilClient.default_number(runtime.backoff_period, 1)
            },
            'ignoreSSL': runtime.ignore_ssl
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
                access_key_id = await self._credential.get_access_key_id_async()
                access_key_secret = await self._credential.get_access_key_secret_async()
                token = await self._credential.get_security_token_async()
                _request.protocol = self._protocol
                _request.method = 'DELETE'
                _request.pathname = f'/{request.channel_name}?live'
                _request.headers = {
                    'host': OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    'date': UtilClient.get_date_utcstring(),
                    'user-agent': self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers['x-oss-security-token'] = token
                _request.headers['authorization'] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = await TeaCore.async_do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = await UtilClient.read_as_string_async(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        'code': resp_map.get('Code'),
                        'message': resp_map.get('Message'),
                        'data': {
                            'httpCode': _response.status_code,
                            'requestId': resp_map.get('RequestId'),
                            'hostId': resp_map.get('HostId')
                        }
                    })
                return oss_models.DeleteLiveChannelResponse().from_map(
                    TeaCore.merge(_response.headers)
                )
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def get_bucket_location(
        self,
        request: oss_models.GetBucketLocationRequest,
        runtime: ossutil_models.RuntimeOptions,
    ) -> oss_models.GetBucketLocationResponse:
        request.validate()
        runtime.validate()
        _runtime = {
            'timeouted': 'retry',
            'readTimeout': UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            'connectTimeout': UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            'localAddr': UtilClient.default_string(runtime.local_addr, self._local_addr),
            'httpProxy': UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            'httpsProxy': UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            'noProxy': UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            'socks5Proxy': UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            'socks5NetWork': UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            'maxIdleConns': UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            'retry': {
                'retryable': runtime.autoretry,
                'maxAttempts': UtilClient.default_number(runtime.max_attempts, 3)
            },
            'backoff': {
                'policy': UtilClient.default_string(runtime.backoff_policy, 'no'),
                'period': UtilClient.default_number(runtime.backoff_period, 1)
            },
            'ignoreSSL': runtime.ignore_ssl
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
                _request.method = 'GET'
                _request.pathname = f'/?location'
                _request.headers = {
                    'host': OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    'date': UtilClient.get_date_utcstring(),
                    'user-agent': self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers['x-oss-security-token'] = token
                _request.headers['authorization'] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = UtilClient.read_as_string(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        'code': resp_map.get('Code'),
                        'message': resp_map.get('Message'),
                        'data': {
                            'httpCode': _response.status_code,
                            'requestId': resp_map.get('RequestId'),
                            'hostId': resp_map.get('HostId')
                        }
                    })
                body_str = UtilClient.read_as_string(_response.body)
                resp_map = XMLClient.parse_xml(body_str, oss_models.GetBucketLocationResponse())
                return oss_models.GetBucketLocationResponse().from_map(
                    TeaCore.merge({
                        'LocationConstraint': resp_map.get('LocationConstraint')
                    }, _response.headers)
                )
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    async def get_bucket_location_async(
        self,
        request: oss_models.GetBucketLocationRequest,
        runtime: ossutil_models.RuntimeOptions,
    ) -> oss_models.GetBucketLocationResponse:
        request.validate()
        runtime.validate()
        _runtime = {
            'timeouted': 'retry',
            'readTimeout': UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            'connectTimeout': UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            'localAddr': UtilClient.default_string(runtime.local_addr, self._local_addr),
            'httpProxy': UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            'httpsProxy': UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            'noProxy': UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            'socks5Proxy': UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            'socks5NetWork': UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            'maxIdleConns': UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            'retry': {
                'retryable': runtime.autoretry,
                'maxAttempts': UtilClient.default_number(runtime.max_attempts, 3)
            },
            'backoff': {
                'policy': UtilClient.default_string(runtime.backoff_policy, 'no'),
                'period': UtilClient.default_number(runtime.backoff_period, 1)
            },
            'ignoreSSL': runtime.ignore_ssl
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
                access_key_id = await self._credential.get_access_key_id_async()
                access_key_secret = await self._credential.get_access_key_secret_async()
                token = await self._credential.get_security_token_async()
                _request.protocol = self._protocol
                _request.method = 'GET'
                _request.pathname = f'/?location'
                _request.headers = {
                    'host': OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    'date': UtilClient.get_date_utcstring(),
                    'user-agent': self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers['x-oss-security-token'] = token
                _request.headers['authorization'] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = await TeaCore.async_do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = await UtilClient.read_as_string_async(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        'code': resp_map.get('Code'),
                        'message': resp_map.get('Message'),
                        'data': {
                            'httpCode': _response.status_code,
                            'requestId': resp_map.get('RequestId'),
                            'hostId': resp_map.get('HostId')
                        }
                    })
                body_str = await UtilClient.read_as_string_async(_response.body)
                resp_map = XMLClient.parse_xml(body_str, oss_models.GetBucketLocationResponse())
                return oss_models.GetBucketLocationResponse().from_map(
                    TeaCore.merge({
                        'LocationConstraint': resp_map.get('LocationConstraint')
                    }, _response.headers)
                )
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def list_live_channel(
        self,
        request: oss_models.ListLiveChannelRequest,
        runtime: ossutil_models.RuntimeOptions,
    ) -> oss_models.ListLiveChannelResponse:
        request.validate()
        runtime.validate()
        _runtime = {
            'timeouted': 'retry',
            'readTimeout': UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            'connectTimeout': UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            'localAddr': UtilClient.default_string(runtime.local_addr, self._local_addr),
            'httpProxy': UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            'httpsProxy': UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            'noProxy': UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            'socks5Proxy': UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            'socks5NetWork': UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            'maxIdleConns': UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            'retry': {
                'retryable': runtime.autoretry,
                'maxAttempts': UtilClient.default_number(runtime.max_attempts, 3)
            },
            'backoff': {
                'policy': UtilClient.default_string(runtime.backoff_policy, 'no'),
                'period': UtilClient.default_number(runtime.backoff_period, 1)
            },
            'ignoreSSL': runtime.ignore_ssl
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
                _request.method = 'GET'
                _request.pathname = f'/?live'
                _request.headers = {
                    'host': OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    'date': UtilClient.get_date_utcstring(),
                    'user-agent': self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers['x-oss-security-token'] = token
                _request.query = UtilClient.stringify_map_value(TeaCore.to_map(request.filter))
                _request.headers['authorization'] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = UtilClient.read_as_string(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        'code': resp_map.get('Code'),
                        'message': resp_map.get('Message'),
                        'data': {
                            'httpCode': _response.status_code,
                            'requestId': resp_map.get('RequestId'),
                            'hostId': resp_map.get('HostId')
                        }
                    })
                body_str = UtilClient.read_as_string(_response.body)
                resp_map = XMLClient.parse_xml(body_str, oss_models.ListLiveChannelResponse())
                return oss_models.ListLiveChannelResponse().from_map(
                    TeaCore.merge({
                        'ListLiveChannelResult': resp_map.get('ListLiveChannelResult')
                    }, _response.headers)
                )
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    async def list_live_channel_async(
        self,
        request: oss_models.ListLiveChannelRequest,
        runtime: ossutil_models.RuntimeOptions,
    ) -> oss_models.ListLiveChannelResponse:
        request.validate()
        runtime.validate()
        _runtime = {
            'timeouted': 'retry',
            'readTimeout': UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            'connectTimeout': UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            'localAddr': UtilClient.default_string(runtime.local_addr, self._local_addr),
            'httpProxy': UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            'httpsProxy': UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            'noProxy': UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            'socks5Proxy': UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            'socks5NetWork': UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            'maxIdleConns': UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            'retry': {
                'retryable': runtime.autoretry,
                'maxAttempts': UtilClient.default_number(runtime.max_attempts, 3)
            },
            'backoff': {
                'policy': UtilClient.default_string(runtime.backoff_policy, 'no'),
                'period': UtilClient.default_number(runtime.backoff_period, 1)
            },
            'ignoreSSL': runtime.ignore_ssl
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
                access_key_id = await self._credential.get_access_key_id_async()
                access_key_secret = await self._credential.get_access_key_secret_async()
                token = await self._credential.get_security_token_async()
                _request.protocol = self._protocol
                _request.method = 'GET'
                _request.pathname = f'/?live'
                _request.headers = {
                    'host': OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    'date': UtilClient.get_date_utcstring(),
                    'user-agent': self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers['x-oss-security-token'] = token
                _request.query = UtilClient.stringify_map_value(TeaCore.to_map(request.filter))
                _request.headers['authorization'] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = await TeaCore.async_do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = await UtilClient.read_as_string_async(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        'code': resp_map.get('Code'),
                        'message': resp_map.get('Message'),
                        'data': {
                            'httpCode': _response.status_code,
                            'requestId': resp_map.get('RequestId'),
                            'hostId': resp_map.get('HostId')
                        }
                    })
                body_str = await UtilClient.read_as_string_async(_response.body)
                resp_map = XMLClient.parse_xml(body_str, oss_models.ListLiveChannelResponse())
                return oss_models.ListLiveChannelResponse().from_map(
                    TeaCore.merge({
                        'ListLiveChannelResult': resp_map.get('ListLiveChannelResult')
                    }, _response.headers)
                )
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def get_object_meta(
        self,
        request: oss_models.GetObjectMetaRequest,
        runtime: ossutil_models.RuntimeOptions,
    ) -> oss_models.GetObjectMetaResponse:
        request.validate()
        runtime.validate()
        _runtime = {
            'timeouted': 'retry',
            'readTimeout': UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            'connectTimeout': UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            'localAddr': UtilClient.default_string(runtime.local_addr, self._local_addr),
            'httpProxy': UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            'httpsProxy': UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            'noProxy': UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            'socks5Proxy': UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            'socks5NetWork': UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            'maxIdleConns': UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            'retry': {
                'retryable': runtime.autoretry,
                'maxAttempts': UtilClient.default_number(runtime.max_attempts, 3)
            },
            'backoff': {
                'policy': UtilClient.default_string(runtime.backoff_policy, 'no'),
                'period': UtilClient.default_number(runtime.backoff_period, 1)
            },
            'ignoreSSL': runtime.ignore_ssl
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
                _request.method = 'HEAD'
                _request.pathname = f'/{request.object_name}?objectMeta'
                _request.headers = {
                    'host': OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    'date': UtilClient.get_date_utcstring(),
                    'user-agent': self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers['x-oss-security-token'] = token
                _request.headers['authorization'] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = UtilClient.read_as_string(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        'code': resp_map.get('Code'),
                        'message': resp_map.get('Message'),
                        'data': {
                            'httpCode': _response.status_code,
                            'requestId': resp_map.get('RequestId'),
                            'hostId': resp_map.get('HostId')
                        }
                    })
                return oss_models.GetObjectMetaResponse().from_map(
                    TeaCore.merge(_response.headers)
                )
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    async def get_object_meta_async(
        self,
        request: oss_models.GetObjectMetaRequest,
        runtime: ossutil_models.RuntimeOptions,
    ) -> oss_models.GetObjectMetaResponse:
        request.validate()
        runtime.validate()
        _runtime = {
            'timeouted': 'retry',
            'readTimeout': UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            'connectTimeout': UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            'localAddr': UtilClient.default_string(runtime.local_addr, self._local_addr),
            'httpProxy': UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            'httpsProxy': UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            'noProxy': UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            'socks5Proxy': UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            'socks5NetWork': UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            'maxIdleConns': UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            'retry': {
                'retryable': runtime.autoretry,
                'maxAttempts': UtilClient.default_number(runtime.max_attempts, 3)
            },
            'backoff': {
                'policy': UtilClient.default_string(runtime.backoff_policy, 'no'),
                'period': UtilClient.default_number(runtime.backoff_period, 1)
            },
            'ignoreSSL': runtime.ignore_ssl
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
                access_key_id = await self._credential.get_access_key_id_async()
                access_key_secret = await self._credential.get_access_key_secret_async()
                token = await self._credential.get_security_token_async()
                _request.protocol = self._protocol
                _request.method = 'HEAD'
                _request.pathname = f'/{request.object_name}?objectMeta'
                _request.headers = {
                    'host': OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    'date': UtilClient.get_date_utcstring(),
                    'user-agent': self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers['x-oss-security-token'] = token
                _request.headers['authorization'] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = await TeaCore.async_do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = await UtilClient.read_as_string_async(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        'code': resp_map.get('Code'),
                        'message': resp_map.get('Message'),
                        'data': {
                            'httpCode': _response.status_code,
                            'requestId': resp_map.get('RequestId'),
                            'hostId': resp_map.get('HostId')
                        }
                    })
                return oss_models.GetObjectMetaResponse().from_map(
                    TeaCore.merge(_response.headers)
                )
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def get_bucket_acl(
        self,
        request: oss_models.GetBucketAclRequest,
        runtime: ossutil_models.RuntimeOptions,
    ) -> oss_models.GetBucketAclResponse:
        request.validate()
        runtime.validate()
        _runtime = {
            'timeouted': 'retry',
            'readTimeout': UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            'connectTimeout': UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            'localAddr': UtilClient.default_string(runtime.local_addr, self._local_addr),
            'httpProxy': UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            'httpsProxy': UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            'noProxy': UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            'socks5Proxy': UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            'socks5NetWork': UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            'maxIdleConns': UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            'retry': {
                'retryable': runtime.autoretry,
                'maxAttempts': UtilClient.default_number(runtime.max_attempts, 3)
            },
            'backoff': {
                'policy': UtilClient.default_string(runtime.backoff_policy, 'no'),
                'period': UtilClient.default_number(runtime.backoff_period, 1)
            },
            'ignoreSSL': runtime.ignore_ssl
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
                _request.method = 'GET'
                _request.pathname = f'/?acl'
                _request.headers = {
                    'host': OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    'date': UtilClient.get_date_utcstring(),
                    'user-agent': self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers['x-oss-security-token'] = token
                _request.headers['authorization'] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = UtilClient.read_as_string(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        'code': resp_map.get('Code'),
                        'message': resp_map.get('Message'),
                        'data': {
                            'httpCode': _response.status_code,
                            'requestId': resp_map.get('RequestId'),
                            'hostId': resp_map.get('HostId')
                        }
                    })
                body_str = UtilClient.read_as_string(_response.body)
                resp_map = XMLClient.parse_xml(body_str, oss_models.GetBucketAclResponse())
                return oss_models.GetBucketAclResponse().from_map(
                    TeaCore.merge({
                        'AccessControlPolicy': resp_map.get('AccessControlPolicy')
                    }, _response.headers)
                )
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    async def get_bucket_acl_async(
        self,
        request: oss_models.GetBucketAclRequest,
        runtime: ossutil_models.RuntimeOptions,
    ) -> oss_models.GetBucketAclResponse:
        request.validate()
        runtime.validate()
        _runtime = {
            'timeouted': 'retry',
            'readTimeout': UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            'connectTimeout': UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            'localAddr': UtilClient.default_string(runtime.local_addr, self._local_addr),
            'httpProxy': UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            'httpsProxy': UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            'noProxy': UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            'socks5Proxy': UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            'socks5NetWork': UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            'maxIdleConns': UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            'retry': {
                'retryable': runtime.autoretry,
                'maxAttempts': UtilClient.default_number(runtime.max_attempts, 3)
            },
            'backoff': {
                'policy': UtilClient.default_string(runtime.backoff_policy, 'no'),
                'period': UtilClient.default_number(runtime.backoff_period, 1)
            },
            'ignoreSSL': runtime.ignore_ssl
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
                access_key_id = await self._credential.get_access_key_id_async()
                access_key_secret = await self._credential.get_access_key_secret_async()
                token = await self._credential.get_security_token_async()
                _request.protocol = self._protocol
                _request.method = 'GET'
                _request.pathname = f'/?acl'
                _request.headers = {
                    'host': OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    'date': UtilClient.get_date_utcstring(),
                    'user-agent': self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers['x-oss-security-token'] = token
                _request.headers['authorization'] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = await TeaCore.async_do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = await UtilClient.read_as_string_async(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        'code': resp_map.get('Code'),
                        'message': resp_map.get('Message'),
                        'data': {
                            'httpCode': _response.status_code,
                            'requestId': resp_map.get('RequestId'),
                            'hostId': resp_map.get('HostId')
                        }
                    })
                body_str = await UtilClient.read_as_string_async(_response.body)
                resp_map = XMLClient.parse_xml(body_str, oss_models.GetBucketAclResponse())
                return oss_models.GetBucketAclResponse().from_map(
                    TeaCore.merge({
                        'AccessControlPolicy': resp_map.get('AccessControlPolicy')
                    }, _response.headers)
                )
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def list_parts(
        self,
        request: oss_models.ListPartsRequest,
        runtime: ossutil_models.RuntimeOptions,
    ) -> oss_models.ListPartsResponse:
        request.validate()
        runtime.validate()
        _runtime = {
            'timeouted': 'retry',
            'readTimeout': UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            'connectTimeout': UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            'localAddr': UtilClient.default_string(runtime.local_addr, self._local_addr),
            'httpProxy': UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            'httpsProxy': UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            'noProxy': UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            'socks5Proxy': UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            'socks5NetWork': UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            'maxIdleConns': UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            'retry': {
                'retryable': runtime.autoretry,
                'maxAttempts': UtilClient.default_number(runtime.max_attempts, 3)
            },
            'backoff': {
                'policy': UtilClient.default_string(runtime.backoff_policy, 'no'),
                'period': UtilClient.default_number(runtime.backoff_period, 1)
            },
            'ignoreSSL': runtime.ignore_ssl
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
                _request.method = 'GET'
                _request.pathname = f'/{request.object_name}'
                _request.headers = {
                    'host': OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    'date': UtilClient.get_date_utcstring(),
                    'user-agent': self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers['x-oss-security-token'] = token
                _request.query = UtilClient.stringify_map_value(TeaCore.to_map(request.filter))
                _request.headers['authorization'] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = UtilClient.read_as_string(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        'code': resp_map.get('Code'),
                        'message': resp_map.get('Message'),
                        'data': {
                            'httpCode': _response.status_code,
                            'requestId': resp_map.get('RequestId'),
                            'hostId': resp_map.get('HostId')
                        }
                    })
                body_str = UtilClient.read_as_string(_response.body)
                resp_map = XMLClient.parse_xml(body_str, oss_models.ListPartsResponse())
                return oss_models.ListPartsResponse().from_map(
                    TeaCore.merge({
                        'ListPartsResult': resp_map.get('ListPartsResult')
                    }, _response.headers)
                )
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    async def list_parts_async(
        self,
        request: oss_models.ListPartsRequest,
        runtime: ossutil_models.RuntimeOptions,
    ) -> oss_models.ListPartsResponse:
        request.validate()
        runtime.validate()
        _runtime = {
            'timeouted': 'retry',
            'readTimeout': UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            'connectTimeout': UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            'localAddr': UtilClient.default_string(runtime.local_addr, self._local_addr),
            'httpProxy': UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            'httpsProxy': UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            'noProxy': UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            'socks5Proxy': UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            'socks5NetWork': UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            'maxIdleConns': UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            'retry': {
                'retryable': runtime.autoretry,
                'maxAttempts': UtilClient.default_number(runtime.max_attempts, 3)
            },
            'backoff': {
                'policy': UtilClient.default_string(runtime.backoff_policy, 'no'),
                'period': UtilClient.default_number(runtime.backoff_period, 1)
            },
            'ignoreSSL': runtime.ignore_ssl
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
                access_key_id = await self._credential.get_access_key_id_async()
                access_key_secret = await self._credential.get_access_key_secret_async()
                token = await self._credential.get_security_token_async()
                _request.protocol = self._protocol
                _request.method = 'GET'
                _request.pathname = f'/{request.object_name}'
                _request.headers = {
                    'host': OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    'date': UtilClient.get_date_utcstring(),
                    'user-agent': self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers['x-oss-security-token'] = token
                _request.query = UtilClient.stringify_map_value(TeaCore.to_map(request.filter))
                _request.headers['authorization'] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = await TeaCore.async_do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = await UtilClient.read_as_string_async(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        'code': resp_map.get('Code'),
                        'message': resp_map.get('Message'),
                        'data': {
                            'httpCode': _response.status_code,
                            'requestId': resp_map.get('RequestId'),
                            'hostId': resp_map.get('HostId')
                        }
                    })
                body_str = await UtilClient.read_as_string_async(_response.body)
                resp_map = XMLClient.parse_xml(body_str, oss_models.ListPartsResponse())
                return oss_models.ListPartsResponse().from_map(
                    TeaCore.merge({
                        'ListPartsResult': resp_map.get('ListPartsResult')
                    }, _response.headers)
                )
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def get_live_channel_history(
        self,
        request: oss_models.GetLiveChannelHistoryRequest,
        runtime: ossutil_models.RuntimeOptions,
    ) -> oss_models.GetLiveChannelHistoryResponse:
        request.validate()
        runtime.validate()
        _runtime = {
            'timeouted': 'retry',
            'readTimeout': UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            'connectTimeout': UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            'localAddr': UtilClient.default_string(runtime.local_addr, self._local_addr),
            'httpProxy': UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            'httpsProxy': UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            'noProxy': UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            'socks5Proxy': UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            'socks5NetWork': UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            'maxIdleConns': UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            'retry': {
                'retryable': runtime.autoretry,
                'maxAttempts': UtilClient.default_number(runtime.max_attempts, 3)
            },
            'backoff': {
                'policy': UtilClient.default_string(runtime.backoff_policy, 'no'),
                'period': UtilClient.default_number(runtime.backoff_period, 1)
            },
            'ignoreSSL': runtime.ignore_ssl
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
                _request.method = 'GET'
                _request.pathname = f'/{request.channel_name}?live'
                _request.headers = {
                    'host': OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    'date': UtilClient.get_date_utcstring(),
                    'user-agent': self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers['x-oss-security-token'] = token
                _request.query = UtilClient.stringify_map_value(TeaCore.to_map(request.filter))
                _request.headers['authorization'] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = UtilClient.read_as_string(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        'code': resp_map.get('Code'),
                        'message': resp_map.get('Message'),
                        'data': {
                            'httpCode': _response.status_code,
                            'requestId': resp_map.get('RequestId'),
                            'hostId': resp_map.get('HostId')
                        }
                    })
                body_str = UtilClient.read_as_string(_response.body)
                resp_map = XMLClient.parse_xml(body_str, oss_models.GetLiveChannelHistoryResponse())
                return oss_models.GetLiveChannelHistoryResponse().from_map(
                    TeaCore.merge({
                        'LiveChannelHistory': resp_map.get('LiveChannelHistory')
                    }, _response.headers)
                )
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    async def get_live_channel_history_async(
        self,
        request: oss_models.GetLiveChannelHistoryRequest,
        runtime: ossutil_models.RuntimeOptions,
    ) -> oss_models.GetLiveChannelHistoryResponse:
        request.validate()
        runtime.validate()
        _runtime = {
            'timeouted': 'retry',
            'readTimeout': UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            'connectTimeout': UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            'localAddr': UtilClient.default_string(runtime.local_addr, self._local_addr),
            'httpProxy': UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            'httpsProxy': UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            'noProxy': UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            'socks5Proxy': UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            'socks5NetWork': UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            'maxIdleConns': UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            'retry': {
                'retryable': runtime.autoretry,
                'maxAttempts': UtilClient.default_number(runtime.max_attempts, 3)
            },
            'backoff': {
                'policy': UtilClient.default_string(runtime.backoff_policy, 'no'),
                'period': UtilClient.default_number(runtime.backoff_period, 1)
            },
            'ignoreSSL': runtime.ignore_ssl
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
                access_key_id = await self._credential.get_access_key_id_async()
                access_key_secret = await self._credential.get_access_key_secret_async()
                token = await self._credential.get_security_token_async()
                _request.protocol = self._protocol
                _request.method = 'GET'
                _request.pathname = f'/{request.channel_name}?live'
                _request.headers = {
                    'host': OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    'date': UtilClient.get_date_utcstring(),
                    'user-agent': self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers['x-oss-security-token'] = token
                _request.query = UtilClient.stringify_map_value(TeaCore.to_map(request.filter))
                _request.headers['authorization'] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = await TeaCore.async_do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = await UtilClient.read_as_string_async(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        'code': resp_map.get('Code'),
                        'message': resp_map.get('Message'),
                        'data': {
                            'httpCode': _response.status_code,
                            'requestId': resp_map.get('RequestId'),
                            'hostId': resp_map.get('HostId')
                        }
                    })
                body_str = await UtilClient.read_as_string_async(_response.body)
                resp_map = XMLClient.parse_xml(body_str, oss_models.GetLiveChannelHistoryResponse())
                return oss_models.GetLiveChannelHistoryResponse().from_map(
                    TeaCore.merge({
                        'LiveChannelHistory': resp_map.get('LiveChannelHistory')
                    }, _response.headers)
                )
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def get_bucket(
        self,
        request: oss_models.GetBucketRequest,
        runtime: ossutil_models.RuntimeOptions,
    ) -> oss_models.GetBucketResponse:
        request.validate()
        runtime.validate()
        _runtime = {
            'timeouted': 'retry',
            'readTimeout': UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            'connectTimeout': UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            'localAddr': UtilClient.default_string(runtime.local_addr, self._local_addr),
            'httpProxy': UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            'httpsProxy': UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            'noProxy': UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            'socks5Proxy': UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            'socks5NetWork': UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            'maxIdleConns': UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            'retry': {
                'retryable': runtime.autoretry,
                'maxAttempts': UtilClient.default_number(runtime.max_attempts, 3)
            },
            'backoff': {
                'policy': UtilClient.default_string(runtime.backoff_policy, 'no'),
                'period': UtilClient.default_number(runtime.backoff_period, 1)
            },
            'ignoreSSL': runtime.ignore_ssl
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
                _request.method = 'GET'
                _request.pathname = f'/'
                _request.headers = {
                    'host': OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    'date': UtilClient.get_date_utcstring(),
                    'user-agent': self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers['x-oss-security-token'] = token
                _request.query = UtilClient.stringify_map_value(TeaCore.to_map(request.filter))
                _request.headers['authorization'] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = UtilClient.read_as_string(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        'code': resp_map.get('Code'),
                        'message': resp_map.get('Message'),
                        'data': {
                            'httpCode': _response.status_code,
                            'requestId': resp_map.get('RequestId'),
                            'hostId': resp_map.get('HostId')
                        }
                    })
                body_str = UtilClient.read_as_string(_response.body)
                resp_map = XMLClient.parse_xml(body_str, oss_models.GetBucketResponse())
                return oss_models.GetBucketResponse().from_map(
                    TeaCore.merge({
                        'ListBucketResult': resp_map.get('ListBucketResult')
                    }, _response.headers)
                )
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    async def get_bucket_async(
        self,
        request: oss_models.GetBucketRequest,
        runtime: ossutil_models.RuntimeOptions,
    ) -> oss_models.GetBucketResponse:
        request.validate()
        runtime.validate()
        _runtime = {
            'timeouted': 'retry',
            'readTimeout': UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            'connectTimeout': UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            'localAddr': UtilClient.default_string(runtime.local_addr, self._local_addr),
            'httpProxy': UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            'httpsProxy': UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            'noProxy': UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            'socks5Proxy': UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            'socks5NetWork': UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            'maxIdleConns': UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            'retry': {
                'retryable': runtime.autoretry,
                'maxAttempts': UtilClient.default_number(runtime.max_attempts, 3)
            },
            'backoff': {
                'policy': UtilClient.default_string(runtime.backoff_policy, 'no'),
                'period': UtilClient.default_number(runtime.backoff_period, 1)
            },
            'ignoreSSL': runtime.ignore_ssl
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
                access_key_id = await self._credential.get_access_key_id_async()
                access_key_secret = await self._credential.get_access_key_secret_async()
                token = await self._credential.get_security_token_async()
                _request.protocol = self._protocol
                _request.method = 'GET'
                _request.pathname = f'/'
                _request.headers = {
                    'host': OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    'date': UtilClient.get_date_utcstring(),
                    'user-agent': self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers['x-oss-security-token'] = token
                _request.query = UtilClient.stringify_map_value(TeaCore.to_map(request.filter))
                _request.headers['authorization'] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = await TeaCore.async_do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = await UtilClient.read_as_string_async(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        'code': resp_map.get('Code'),
                        'message': resp_map.get('Message'),
                        'data': {
                            'httpCode': _response.status_code,
                            'requestId': resp_map.get('RequestId'),
                            'hostId': resp_map.get('HostId')
                        }
                    })
                body_str = await UtilClient.read_as_string_async(_response.body)
                resp_map = XMLClient.parse_xml(body_str, oss_models.GetBucketResponse())
                return oss_models.GetBucketResponse().from_map(
                    TeaCore.merge({
                        'ListBucketResult': resp_map.get('ListBucketResult')
                    }, _response.headers)
                )
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def get_live_channel_info(
        self,
        request: oss_models.GetLiveChannelInfoRequest,
        runtime: ossutil_models.RuntimeOptions,
    ) -> oss_models.GetLiveChannelInfoResponse:
        request.validate()
        runtime.validate()
        _runtime = {
            'timeouted': 'retry',
            'readTimeout': UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            'connectTimeout': UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            'localAddr': UtilClient.default_string(runtime.local_addr, self._local_addr),
            'httpProxy': UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            'httpsProxy': UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            'noProxy': UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            'socks5Proxy': UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            'socks5NetWork': UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            'maxIdleConns': UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            'retry': {
                'retryable': runtime.autoretry,
                'maxAttempts': UtilClient.default_number(runtime.max_attempts, 3)
            },
            'backoff': {
                'policy': UtilClient.default_string(runtime.backoff_policy, 'no'),
                'period': UtilClient.default_number(runtime.backoff_period, 1)
            },
            'ignoreSSL': runtime.ignore_ssl
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
                _request.method = 'GET'
                _request.pathname = f'/{request.channel_name}?live'
                _request.headers = {
                    'host': OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    'date': UtilClient.get_date_utcstring(),
                    'user-agent': self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers['x-oss-security-token'] = token
                _request.headers['authorization'] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = UtilClient.read_as_string(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        'code': resp_map.get('Code'),
                        'message': resp_map.get('Message'),
                        'data': {
                            'httpCode': _response.status_code,
                            'requestId': resp_map.get('RequestId'),
                            'hostId': resp_map.get('HostId')
                        }
                    })
                body_str = UtilClient.read_as_string(_response.body)
                resp_map = XMLClient.parse_xml(body_str, oss_models.GetLiveChannelInfoResponse())
                return oss_models.GetLiveChannelInfoResponse().from_map(
                    TeaCore.merge({
                        'LiveChannelConfiguration': resp_map.get('LiveChannelConfiguration')
                    }, _response.headers)
                )
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    async def get_live_channel_info_async(
        self,
        request: oss_models.GetLiveChannelInfoRequest,
        runtime: ossutil_models.RuntimeOptions,
    ) -> oss_models.GetLiveChannelInfoResponse:
        request.validate()
        runtime.validate()
        _runtime = {
            'timeouted': 'retry',
            'readTimeout': UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            'connectTimeout': UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            'localAddr': UtilClient.default_string(runtime.local_addr, self._local_addr),
            'httpProxy': UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            'httpsProxy': UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            'noProxy': UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            'socks5Proxy': UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            'socks5NetWork': UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            'maxIdleConns': UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            'retry': {
                'retryable': runtime.autoretry,
                'maxAttempts': UtilClient.default_number(runtime.max_attempts, 3)
            },
            'backoff': {
                'policy': UtilClient.default_string(runtime.backoff_policy, 'no'),
                'period': UtilClient.default_number(runtime.backoff_period, 1)
            },
            'ignoreSSL': runtime.ignore_ssl
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
                access_key_id = await self._credential.get_access_key_id_async()
                access_key_secret = await self._credential.get_access_key_secret_async()
                token = await self._credential.get_security_token_async()
                _request.protocol = self._protocol
                _request.method = 'GET'
                _request.pathname = f'/{request.channel_name}?live'
                _request.headers = {
                    'host': OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    'date': UtilClient.get_date_utcstring(),
                    'user-agent': self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers['x-oss-security-token'] = token
                _request.headers['authorization'] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = await TeaCore.async_do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = await UtilClient.read_as_string_async(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        'code': resp_map.get('Code'),
                        'message': resp_map.get('Message'),
                        'data': {
                            'httpCode': _response.status_code,
                            'requestId': resp_map.get('RequestId'),
                            'hostId': resp_map.get('HostId')
                        }
                    })
                body_str = await UtilClient.read_as_string_async(_response.body)
                resp_map = XMLClient.parse_xml(body_str, oss_models.GetLiveChannelInfoResponse())
                return oss_models.GetLiveChannelInfoResponse().from_map(
                    TeaCore.merge({
                        'LiveChannelConfiguration': resp_map.get('LiveChannelConfiguration')
                    }, _response.headers)
                )
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def get_live_channel_stat(
        self,
        request: oss_models.GetLiveChannelStatRequest,
        runtime: ossutil_models.RuntimeOptions,
    ) -> oss_models.GetLiveChannelStatResponse:
        request.validate()
        runtime.validate()
        _runtime = {
            'timeouted': 'retry',
            'readTimeout': UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            'connectTimeout': UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            'localAddr': UtilClient.default_string(runtime.local_addr, self._local_addr),
            'httpProxy': UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            'httpsProxy': UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            'noProxy': UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            'socks5Proxy': UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            'socks5NetWork': UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            'maxIdleConns': UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            'retry': {
                'retryable': runtime.autoretry,
                'maxAttempts': UtilClient.default_number(runtime.max_attempts, 3)
            },
            'backoff': {
                'policy': UtilClient.default_string(runtime.backoff_policy, 'no'),
                'period': UtilClient.default_number(runtime.backoff_period, 1)
            },
            'ignoreSSL': runtime.ignore_ssl
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
                _request.method = 'GET'
                _request.pathname = f'/{request.channel_name}?live'
                _request.headers = {
                    'host': OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    'date': UtilClient.get_date_utcstring(),
                    'user-agent': self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers['x-oss-security-token'] = token
                _request.query = UtilClient.stringify_map_value(TeaCore.to_map(request.filter))
                _request.headers['authorization'] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = UtilClient.read_as_string(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        'code': resp_map.get('Code'),
                        'message': resp_map.get('Message'),
                        'data': {
                            'httpCode': _response.status_code,
                            'requestId': resp_map.get('RequestId'),
                            'hostId': resp_map.get('HostId')
                        }
                    })
                body_str = UtilClient.read_as_string(_response.body)
                resp_map = XMLClient.parse_xml(body_str, oss_models.GetLiveChannelStatResponse())
                return oss_models.GetLiveChannelStatResponse().from_map(
                    TeaCore.merge({
                        'LiveChannelStat': resp_map.get('LiveChannelStat')
                    }, _response.headers)
                )
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    async def get_live_channel_stat_async(
        self,
        request: oss_models.GetLiveChannelStatRequest,
        runtime: ossutil_models.RuntimeOptions,
    ) -> oss_models.GetLiveChannelStatResponse:
        request.validate()
        runtime.validate()
        _runtime = {
            'timeouted': 'retry',
            'readTimeout': UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            'connectTimeout': UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            'localAddr': UtilClient.default_string(runtime.local_addr, self._local_addr),
            'httpProxy': UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            'httpsProxy': UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            'noProxy': UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            'socks5Proxy': UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            'socks5NetWork': UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            'maxIdleConns': UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            'retry': {
                'retryable': runtime.autoretry,
                'maxAttempts': UtilClient.default_number(runtime.max_attempts, 3)
            },
            'backoff': {
                'policy': UtilClient.default_string(runtime.backoff_policy, 'no'),
                'period': UtilClient.default_number(runtime.backoff_period, 1)
            },
            'ignoreSSL': runtime.ignore_ssl
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
                access_key_id = await self._credential.get_access_key_id_async()
                access_key_secret = await self._credential.get_access_key_secret_async()
                token = await self._credential.get_security_token_async()
                _request.protocol = self._protocol
                _request.method = 'GET'
                _request.pathname = f'/{request.channel_name}?live'
                _request.headers = {
                    'host': OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    'date': UtilClient.get_date_utcstring(),
                    'user-agent': self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers['x-oss-security-token'] = token
                _request.query = UtilClient.stringify_map_value(TeaCore.to_map(request.filter))
                _request.headers['authorization'] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = await TeaCore.async_do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = await UtilClient.read_as_string_async(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        'code': resp_map.get('Code'),
                        'message': resp_map.get('Message'),
                        'data': {
                            'httpCode': _response.status_code,
                            'requestId': resp_map.get('RequestId'),
                            'hostId': resp_map.get('HostId')
                        }
                    })
                body_str = await UtilClient.read_as_string_async(_response.body)
                resp_map = XMLClient.parse_xml(body_str, oss_models.GetLiveChannelStatResponse())
                return oss_models.GetLiveChannelStatResponse().from_map(
                    TeaCore.merge({
                        'LiveChannelStat': resp_map.get('LiveChannelStat')
                    }, _response.headers)
                )
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def delete_object(
        self,
        request: oss_models.DeleteObjectRequest,
        runtime: ossutil_models.RuntimeOptions,
    ) -> oss_models.DeleteObjectResponse:
        request.validate()
        runtime.validate()
        _runtime = {
            'timeouted': 'retry',
            'readTimeout': UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            'connectTimeout': UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            'localAddr': UtilClient.default_string(runtime.local_addr, self._local_addr),
            'httpProxy': UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            'httpsProxy': UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            'noProxy': UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            'socks5Proxy': UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            'socks5NetWork': UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            'maxIdleConns': UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            'retry': {
                'retryable': runtime.autoretry,
                'maxAttempts': UtilClient.default_number(runtime.max_attempts, 3)
            },
            'backoff': {
                'policy': UtilClient.default_string(runtime.backoff_policy, 'no'),
                'period': UtilClient.default_number(runtime.backoff_period, 1)
            },
            'ignoreSSL': runtime.ignore_ssl
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
                _request.method = 'DELETE'
                _request.pathname = f'/{request.object_name}'
                _request.headers = {
                    'host': OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    'date': UtilClient.get_date_utcstring(),
                    'user-agent': self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers['x-oss-security-token'] = token
                _request.headers['authorization'] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = UtilClient.read_as_string(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        'code': resp_map.get('Code'),
                        'message': resp_map.get('Message'),
                        'data': {
                            'httpCode': _response.status_code,
                            'requestId': resp_map.get('RequestId'),
                            'hostId': resp_map.get('HostId')
                        }
                    })
                return oss_models.DeleteObjectResponse().from_map(
                    TeaCore.merge(_response.headers)
                )
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    async def delete_object_async(
        self,
        request: oss_models.DeleteObjectRequest,
        runtime: ossutil_models.RuntimeOptions,
    ) -> oss_models.DeleteObjectResponse:
        request.validate()
        runtime.validate()
        _runtime = {
            'timeouted': 'retry',
            'readTimeout': UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            'connectTimeout': UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            'localAddr': UtilClient.default_string(runtime.local_addr, self._local_addr),
            'httpProxy': UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            'httpsProxy': UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            'noProxy': UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            'socks5Proxy': UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            'socks5NetWork': UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            'maxIdleConns': UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            'retry': {
                'retryable': runtime.autoretry,
                'maxAttempts': UtilClient.default_number(runtime.max_attempts, 3)
            },
            'backoff': {
                'policy': UtilClient.default_string(runtime.backoff_policy, 'no'),
                'period': UtilClient.default_number(runtime.backoff_period, 1)
            },
            'ignoreSSL': runtime.ignore_ssl
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
                access_key_id = await self._credential.get_access_key_id_async()
                access_key_secret = await self._credential.get_access_key_secret_async()
                token = await self._credential.get_security_token_async()
                _request.protocol = self._protocol
                _request.method = 'DELETE'
                _request.pathname = f'/{request.object_name}'
                _request.headers = {
                    'host': OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    'date': UtilClient.get_date_utcstring(),
                    'user-agent': self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers['x-oss-security-token'] = token
                _request.headers['authorization'] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = await TeaCore.async_do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = await UtilClient.read_as_string_async(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        'code': resp_map.get('Code'),
                        'message': resp_map.get('Message'),
                        'data': {
                            'httpCode': _response.status_code,
                            'requestId': resp_map.get('RequestId'),
                            'hostId': resp_map.get('HostId')
                        }
                    })
                return oss_models.DeleteObjectResponse().from_map(
                    TeaCore.merge(_response.headers)
                )
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def abort_multipart_upload(
        self,
        request: oss_models.AbortMultipartUploadRequest,
        runtime: ossutil_models.RuntimeOptions,
    ) -> oss_models.AbortMultipartUploadResponse:
        request.validate()
        runtime.validate()
        _runtime = {
            'timeouted': 'retry',
            'readTimeout': UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            'connectTimeout': UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            'localAddr': UtilClient.default_string(runtime.local_addr, self._local_addr),
            'httpProxy': UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            'httpsProxy': UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            'noProxy': UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            'socks5Proxy': UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            'socks5NetWork': UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            'maxIdleConns': UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            'retry': {
                'retryable': runtime.autoretry,
                'maxAttempts': UtilClient.default_number(runtime.max_attempts, 3)
            },
            'backoff': {
                'policy': UtilClient.default_string(runtime.backoff_policy, 'no'),
                'period': UtilClient.default_number(runtime.backoff_period, 1)
            },
            'ignoreSSL': runtime.ignore_ssl
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
                _request.method = 'DELETE'
                _request.pathname = f'/{request.object_name}'
                _request.headers = {
                    'host': OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    'date': UtilClient.get_date_utcstring(),
                    'user-agent': self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers['x-oss-security-token'] = token
                _request.query = UtilClient.stringify_map_value(TeaCore.to_map(request.filter))
                _request.headers['authorization'] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = UtilClient.read_as_string(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        'code': resp_map.get('Code'),
                        'message': resp_map.get('Message'),
                        'data': {
                            'httpCode': _response.status_code,
                            'requestId': resp_map.get('RequestId'),
                            'hostId': resp_map.get('HostId')
                        }
                    })
                return oss_models.AbortMultipartUploadResponse().from_map(
                    TeaCore.merge(_response.headers)
                )
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    async def abort_multipart_upload_async(
        self,
        request: oss_models.AbortMultipartUploadRequest,
        runtime: ossutil_models.RuntimeOptions,
    ) -> oss_models.AbortMultipartUploadResponse:
        request.validate()
        runtime.validate()
        _runtime = {
            'timeouted': 'retry',
            'readTimeout': UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            'connectTimeout': UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            'localAddr': UtilClient.default_string(runtime.local_addr, self._local_addr),
            'httpProxy': UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            'httpsProxy': UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            'noProxy': UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            'socks5Proxy': UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            'socks5NetWork': UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            'maxIdleConns': UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            'retry': {
                'retryable': runtime.autoretry,
                'maxAttempts': UtilClient.default_number(runtime.max_attempts, 3)
            },
            'backoff': {
                'policy': UtilClient.default_string(runtime.backoff_policy, 'no'),
                'period': UtilClient.default_number(runtime.backoff_period, 1)
            },
            'ignoreSSL': runtime.ignore_ssl
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
                access_key_id = await self._credential.get_access_key_id_async()
                access_key_secret = await self._credential.get_access_key_secret_async()
                token = await self._credential.get_security_token_async()
                _request.protocol = self._protocol
                _request.method = 'DELETE'
                _request.pathname = f'/{request.object_name}'
                _request.headers = {
                    'host': OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    'date': UtilClient.get_date_utcstring(),
                    'user-agent': self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers['x-oss-security-token'] = token
                _request.query = UtilClient.stringify_map_value(TeaCore.to_map(request.filter))
                _request.headers['authorization'] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = await TeaCore.async_do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = await UtilClient.read_as_string_async(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        'code': resp_map.get('Code'),
                        'message': resp_map.get('Message'),
                        'data': {
                            'httpCode': _response.status_code,
                            'requestId': resp_map.get('RequestId'),
                            'hostId': resp_map.get('HostId')
                        }
                    })
                return oss_models.AbortMultipartUploadResponse().from_map(
                    TeaCore.merge(_response.headers)
                )
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def append_object(
        self,
        request: oss_models.AppendObjectRequest,
        runtime: ossutil_models.RuntimeOptions,
    ) -> oss_models.AppendObjectResponse:
        request.validate()
        runtime.validate()
        _runtime = {
            'timeouted': 'retry',
            'readTimeout': UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            'connectTimeout': UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            'localAddr': UtilClient.default_string(runtime.local_addr, self._local_addr),
            'httpProxy': UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            'httpsProxy': UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            'noProxy': UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            'socks5Proxy': UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            'socks5NetWork': UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            'maxIdleConns': UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            'retry': {
                'retryable': runtime.autoretry,
                'maxAttempts': UtilClient.default_number(runtime.max_attempts, 3)
            },
            'backoff': {
                'policy': UtilClient.default_string(runtime.backoff_policy, 'no'),
                'period': UtilClient.default_number(runtime.backoff_period, 1)
            },
            'ignoreSSL': runtime.ignore_ssl
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
                _request.method = 'POST'
                _request.pathname = f'/{request.object_name}?append'
                _request.headers = TeaCore.merge({
                    'host': OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    'date': UtilClient.get_date_utcstring(),
                    'user-agent': self.get_user_agent()
                }, UtilClient.stringify_map_value(TeaCore.to_map(request.header)),
                    OSSUtilClient.parse_meta(request.user_meta, 'x-oss-meta-'))
                if not UtilClient.empty(token):
                    _request.headers['x-oss-security-token'] = token
                _request.query = UtilClient.stringify_map_value(TeaCore.to_map(request.filter))
                _request.body = OSSUtilClient.inject(request.body, ctx)
                if not UtilClient.is_unset(request.header) and not UtilClient.empty(request.header.content_type):
                    _request.headers['content-type'] = request.header.content_type
                else:
                    _request.headers['content-type'] = OSSUtilClient.get_content_type(request.object_name)
                _request.headers['authorization'] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = UtilClient.read_as_string(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        'code': resp_map.get('Code'),
                        'message': resp_map.get('Message'),
                        'data': {
                            'httpCode': _response.status_code,
                            'requestId': resp_map.get('RequestId'),
                            'hostId': resp_map.get('HostId')
                        }
                    })
                if self._is_enable_crc and not UtilClient.equal_string(ctx.get('crc'), _response.headers.get('x-oss-hash-crc64ecma')):
                    raise TeaException({
                        'code': 'CrcNotMatched',
                        'data': {
                            'clientCrc': ctx.get('crc'),
                            'serverCrc': _response.headers.get('x-oss-hash-crc64ecma')
                        }
                    })
                if self._is_enable_md5 and not UtilClient.equal_string(ctx.get('md5'), _response.headers.get('content-md5')):
                    raise TeaException({
                        'code': 'MD5NotMatched',
                        'data': {
                            'clientMD5': ctx.get('md5'),
                            'serverMD5': _response.headers.get('content-md5')
                        }
                    })
                return oss_models.AppendObjectResponse().from_map(
                    TeaCore.merge(_response.headers)
                )
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    async def append_object_async(
        self,
        request: oss_models.AppendObjectRequest,
        runtime: ossutil_models.RuntimeOptions,
    ) -> oss_models.AppendObjectResponse:
        request.validate()
        runtime.validate()
        _runtime = {
            'timeouted': 'retry',
            'readTimeout': UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            'connectTimeout': UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            'localAddr': UtilClient.default_string(runtime.local_addr, self._local_addr),
            'httpProxy': UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            'httpsProxy': UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            'noProxy': UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            'socks5Proxy': UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            'socks5NetWork': UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            'maxIdleConns': UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            'retry': {
                'retryable': runtime.autoretry,
                'maxAttempts': UtilClient.default_number(runtime.max_attempts, 3)
            },
            'backoff': {
                'policy': UtilClient.default_string(runtime.backoff_policy, 'no'),
                'period': UtilClient.default_number(runtime.backoff_period, 1)
            },
            'ignoreSSL': runtime.ignore_ssl
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
                access_key_id = await self._credential.get_access_key_id_async()
                access_key_secret = await self._credential.get_access_key_secret_async()
                token = await self._credential.get_security_token_async()
                _request.protocol = self._protocol
                _request.method = 'POST'
                _request.pathname = f'/{request.object_name}?append'
                _request.headers = TeaCore.merge({
                    'host': OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    'date': UtilClient.get_date_utcstring(),
                    'user-agent': self.get_user_agent()
                }, UtilClient.stringify_map_value(TeaCore.to_map(request.header)),
                    OSSUtilClient.parse_meta(request.user_meta, 'x-oss-meta-'))
                if not UtilClient.empty(token):
                    _request.headers['x-oss-security-token'] = token
                _request.query = UtilClient.stringify_map_value(TeaCore.to_map(request.filter))
                _request.body = OSSUtilClient.inject(request.body, ctx)
                if not UtilClient.is_unset(request.header) and not UtilClient.empty(request.header.content_type):
                    _request.headers['content-type'] = request.header.content_type
                else:
                    _request.headers['content-type'] = OSSUtilClient.get_content_type(request.object_name)
                _request.headers['authorization'] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = await TeaCore.async_do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = await UtilClient.read_as_string_async(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        'code': resp_map.get('Code'),
                        'message': resp_map.get('Message'),
                        'data': {
                            'httpCode': _response.status_code,
                            'requestId': resp_map.get('RequestId'),
                            'hostId': resp_map.get('HostId')
                        }
                    })
                if self._is_enable_crc and not UtilClient.equal_string(ctx.get('crc'), _response.headers.get('x-oss-hash-crc64ecma')):
                    raise TeaException({
                        'code': 'CrcNotMatched',
                        'data': {
                            'clientCrc': ctx.get('crc'),
                            'serverCrc': _response.headers.get('x-oss-hash-crc64ecma')
                        }
                    })
                if self._is_enable_md5 and not UtilClient.equal_string(ctx.get('md5'), _response.headers.get('content-md5')):
                    raise TeaException({
                        'code': 'MD5NotMatched',
                        'data': {
                            'clientMD5': ctx.get('md5'),
                            'serverMD5': _response.headers.get('content-md5')
                        }
                    })
                return oss_models.AppendObjectResponse().from_map(
                    TeaCore.merge(_response.headers)
                )
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def upload_part_copy(
        self,
        request: oss_models.UploadPartCopyRequest,
        runtime: ossutil_models.RuntimeOptions,
    ) -> oss_models.UploadPartCopyResponse:
        request.validate()
        runtime.validate()
        _runtime = {
            'timeouted': 'retry',
            'readTimeout': UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            'connectTimeout': UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            'localAddr': UtilClient.default_string(runtime.local_addr, self._local_addr),
            'httpProxy': UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            'httpsProxy': UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            'noProxy': UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            'socks5Proxy': UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            'socks5NetWork': UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            'maxIdleConns': UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            'retry': {
                'retryable': runtime.autoretry,
                'maxAttempts': UtilClient.default_number(runtime.max_attempts, 3)
            },
            'backoff': {
                'policy': UtilClient.default_string(runtime.backoff_policy, 'no'),
                'period': UtilClient.default_number(runtime.backoff_period, 1)
            },
            'ignoreSSL': runtime.ignore_ssl
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
                _request.method = 'PUT'
                _request.pathname = f'/{request.object_name}'
                _request.headers = TeaCore.merge({
                    'host': OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    'date': UtilClient.get_date_utcstring(),
                    'user-agent': self.get_user_agent()
                }, UtilClient.stringify_map_value(TeaCore.to_map(request.header)))
                if not UtilClient.empty(token):
                    _request.headers['x-oss-security-token'] = token
                _request.query = UtilClient.stringify_map_value(TeaCore.to_map(request.filter))
                _request.headers['authorization'] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = UtilClient.read_as_string(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        'code': resp_map.get('Code'),
                        'message': resp_map.get('Message'),
                        'data': {
                            'httpCode': _response.status_code,
                            'requestId': resp_map.get('RequestId'),
                            'hostId': resp_map.get('HostId')
                        }
                    })
                body_str = UtilClient.read_as_string(_response.body)
                resp_map = XMLClient.parse_xml(body_str, oss_models.UploadPartCopyResponse())
                return oss_models.UploadPartCopyResponse().from_map(
                    TeaCore.merge({
                        'CopyPartResult': resp_map.get('CopyPartResult')
                    }, _response.headers)
                )
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    async def upload_part_copy_async(
        self,
        request: oss_models.UploadPartCopyRequest,
        runtime: ossutil_models.RuntimeOptions,
    ) -> oss_models.UploadPartCopyResponse:
        request.validate()
        runtime.validate()
        _runtime = {
            'timeouted': 'retry',
            'readTimeout': UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            'connectTimeout': UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            'localAddr': UtilClient.default_string(runtime.local_addr, self._local_addr),
            'httpProxy': UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            'httpsProxy': UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            'noProxy': UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            'socks5Proxy': UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            'socks5NetWork': UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            'maxIdleConns': UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            'retry': {
                'retryable': runtime.autoretry,
                'maxAttempts': UtilClient.default_number(runtime.max_attempts, 3)
            },
            'backoff': {
                'policy': UtilClient.default_string(runtime.backoff_policy, 'no'),
                'period': UtilClient.default_number(runtime.backoff_period, 1)
            },
            'ignoreSSL': runtime.ignore_ssl
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
                access_key_id = await self._credential.get_access_key_id_async()
                access_key_secret = await self._credential.get_access_key_secret_async()
                token = await self._credential.get_security_token_async()
                _request.protocol = self._protocol
                _request.method = 'PUT'
                _request.pathname = f'/{request.object_name}'
                _request.headers = TeaCore.merge({
                    'host': OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    'date': UtilClient.get_date_utcstring(),
                    'user-agent': self.get_user_agent()
                }, UtilClient.stringify_map_value(TeaCore.to_map(request.header)))
                if not UtilClient.empty(token):
                    _request.headers['x-oss-security-token'] = token
                _request.query = UtilClient.stringify_map_value(TeaCore.to_map(request.filter))
                _request.headers['authorization'] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = await TeaCore.async_do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = await UtilClient.read_as_string_async(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        'code': resp_map.get('Code'),
                        'message': resp_map.get('Message'),
                        'data': {
                            'httpCode': _response.status_code,
                            'requestId': resp_map.get('RequestId'),
                            'hostId': resp_map.get('HostId')
                        }
                    })
                body_str = await UtilClient.read_as_string_async(_response.body)
                resp_map = XMLClient.parse_xml(body_str, oss_models.UploadPartCopyResponse())
                return oss_models.UploadPartCopyResponse().from_map(
                    TeaCore.merge({
                        'CopyPartResult': resp_map.get('CopyPartResult')
                    }, _response.headers)
                )
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def get_vod_playlist(
        self,
        request: oss_models.GetVodPlaylistRequest,
        runtime: ossutil_models.RuntimeOptions,
    ) -> oss_models.GetVodPlaylistResponse:
        request.validate()
        runtime.validate()
        _runtime = {
            'timeouted': 'retry',
            'readTimeout': UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            'connectTimeout': UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            'localAddr': UtilClient.default_string(runtime.local_addr, self._local_addr),
            'httpProxy': UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            'httpsProxy': UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            'noProxy': UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            'socks5Proxy': UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            'socks5NetWork': UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            'maxIdleConns': UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            'retry': {
                'retryable': runtime.autoretry,
                'maxAttempts': UtilClient.default_number(runtime.max_attempts, 3)
            },
            'backoff': {
                'policy': UtilClient.default_string(runtime.backoff_policy, 'no'),
                'period': UtilClient.default_number(runtime.backoff_period, 1)
            },
            'ignoreSSL': runtime.ignore_ssl
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
                _request.method = 'GET'
                _request.pathname = f'/{request.channel_name}?vod'
                _request.headers = {
                    'host': OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    'date': UtilClient.get_date_utcstring(),
                    'user-agent': self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers['x-oss-security-token'] = token
                _request.query = UtilClient.stringify_map_value(TeaCore.to_map(request.filter))
                _request.headers['authorization'] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = UtilClient.read_as_string(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        'code': resp_map.get('Code'),
                        'message': resp_map.get('Message'),
                        'data': {
                            'httpCode': _response.status_code,
                            'requestId': resp_map.get('RequestId'),
                            'hostId': resp_map.get('HostId')
                        }
                    })
                return oss_models.GetVodPlaylistResponse().from_map(
                    TeaCore.merge(_response.headers)
                )
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    async def get_vod_playlist_async(
        self,
        request: oss_models.GetVodPlaylistRequest,
        runtime: ossutil_models.RuntimeOptions,
    ) -> oss_models.GetVodPlaylistResponse:
        request.validate()
        runtime.validate()
        _runtime = {
            'timeouted': 'retry',
            'readTimeout': UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            'connectTimeout': UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            'localAddr': UtilClient.default_string(runtime.local_addr, self._local_addr),
            'httpProxy': UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            'httpsProxy': UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            'noProxy': UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            'socks5Proxy': UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            'socks5NetWork': UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            'maxIdleConns': UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            'retry': {
                'retryable': runtime.autoretry,
                'maxAttempts': UtilClient.default_number(runtime.max_attempts, 3)
            },
            'backoff': {
                'policy': UtilClient.default_string(runtime.backoff_policy, 'no'),
                'period': UtilClient.default_number(runtime.backoff_period, 1)
            },
            'ignoreSSL': runtime.ignore_ssl
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
                access_key_id = await self._credential.get_access_key_id_async()
                access_key_secret = await self._credential.get_access_key_secret_async()
                token = await self._credential.get_security_token_async()
                _request.protocol = self._protocol
                _request.method = 'GET'
                _request.pathname = f'/{request.channel_name}?vod'
                _request.headers = {
                    'host': OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    'date': UtilClient.get_date_utcstring(),
                    'user-agent': self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers['x-oss-security-token'] = token
                _request.query = UtilClient.stringify_map_value(TeaCore.to_map(request.filter))
                _request.headers['authorization'] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = await TeaCore.async_do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = await UtilClient.read_as_string_async(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        'code': resp_map.get('Code'),
                        'message': resp_map.get('Message'),
                        'data': {
                            'httpCode': _response.status_code,
                            'requestId': resp_map.get('RequestId'),
                            'hostId': resp_map.get('HostId')
                        }
                    })
                return oss_models.GetVodPlaylistResponse().from_map(
                    TeaCore.merge(_response.headers)
                )
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def delete_bucket_cors(
        self,
        request: oss_models.DeleteBucketCORSRequest,
        runtime: ossutil_models.RuntimeOptions,
    ) -> oss_models.DeleteBucketCORSResponse:
        request.validate()
        runtime.validate()
        _runtime = {
            'timeouted': 'retry',
            'readTimeout': UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            'connectTimeout': UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            'localAddr': UtilClient.default_string(runtime.local_addr, self._local_addr),
            'httpProxy': UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            'httpsProxy': UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            'noProxy': UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            'socks5Proxy': UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            'socks5NetWork': UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            'maxIdleConns': UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            'retry': {
                'retryable': runtime.autoretry,
                'maxAttempts': UtilClient.default_number(runtime.max_attempts, 3)
            },
            'backoff': {
                'policy': UtilClient.default_string(runtime.backoff_policy, 'no'),
                'period': UtilClient.default_number(runtime.backoff_period, 1)
            },
            'ignoreSSL': runtime.ignore_ssl
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
                _request.method = 'DELETE'
                _request.pathname = f'/?cors'
                _request.headers = {
                    'host': OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    'date': UtilClient.get_date_utcstring(),
                    'user-agent': self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers['x-oss-security-token'] = token
                _request.headers['authorization'] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = UtilClient.read_as_string(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        'code': resp_map.get('Code'),
                        'message': resp_map.get('Message'),
                        'data': {
                            'httpCode': _response.status_code,
                            'requestId': resp_map.get('RequestId'),
                            'hostId': resp_map.get('HostId')
                        }
                    })
                return oss_models.DeleteBucketCORSResponse().from_map(
                    TeaCore.merge(_response.headers)
                )
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    async def delete_bucket_cors_async(
        self,
        request: oss_models.DeleteBucketCORSRequest,
        runtime: ossutil_models.RuntimeOptions,
    ) -> oss_models.DeleteBucketCORSResponse:
        request.validate()
        runtime.validate()
        _runtime = {
            'timeouted': 'retry',
            'readTimeout': UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            'connectTimeout': UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            'localAddr': UtilClient.default_string(runtime.local_addr, self._local_addr),
            'httpProxy': UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            'httpsProxy': UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            'noProxy': UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            'socks5Proxy': UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            'socks5NetWork': UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            'maxIdleConns': UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            'retry': {
                'retryable': runtime.autoretry,
                'maxAttempts': UtilClient.default_number(runtime.max_attempts, 3)
            },
            'backoff': {
                'policy': UtilClient.default_string(runtime.backoff_policy, 'no'),
                'period': UtilClient.default_number(runtime.backoff_period, 1)
            },
            'ignoreSSL': runtime.ignore_ssl
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
                access_key_id = await self._credential.get_access_key_id_async()
                access_key_secret = await self._credential.get_access_key_secret_async()
                token = await self._credential.get_security_token_async()
                _request.protocol = self._protocol
                _request.method = 'DELETE'
                _request.pathname = f'/?cors'
                _request.headers = {
                    'host': OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    'date': UtilClient.get_date_utcstring(),
                    'user-agent': self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers['x-oss-security-token'] = token
                _request.headers['authorization'] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = await TeaCore.async_do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = await UtilClient.read_as_string_async(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        'code': resp_map.get('Code'),
                        'message': resp_map.get('Message'),
                        'data': {
                            'httpCode': _response.status_code,
                            'requestId': resp_map.get('RequestId'),
                            'hostId': resp_map.get('HostId')
                        }
                    })
                return oss_models.DeleteBucketCORSResponse().from_map(
                    TeaCore.merge(_response.headers)
                )
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def get_object(
        self,
        request: oss_models.GetObjectRequest,
        runtime: ossutil_models.RuntimeOptions,
    ) -> oss_models.GetObjectResponse:
        request.validate()
        runtime.validate()
        _runtime = {
            'timeouted': 'retry',
            'readTimeout': UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            'connectTimeout': UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            'localAddr': UtilClient.default_string(runtime.local_addr, self._local_addr),
            'httpProxy': UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            'httpsProxy': UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            'noProxy': UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            'socks5Proxy': UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            'socks5NetWork': UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            'maxIdleConns': UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            'retry': {
                'retryable': runtime.autoretry,
                'maxAttempts': UtilClient.default_number(runtime.max_attempts, 3)
            },
            'backoff': {
                'policy': UtilClient.default_string(runtime.backoff_policy, 'no'),
                'period': UtilClient.default_number(runtime.backoff_period, 1)
            },
            'ignoreSSL': runtime.ignore_ssl
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
                _request.method = 'GET'
                _request.pathname = f'/{request.object_name}'
                _request.headers = TeaCore.merge({
                    'host': OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    'date': UtilClient.get_date_utcstring(),
                    'user-agent': self.get_user_agent()
                }, UtilClient.stringify_map_value(TeaCore.to_map(request.header)))
                if not UtilClient.empty(token):
                    _request.headers['x-oss-security-token'] = token
                _request.headers['authorization'] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = UtilClient.read_as_string(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        'code': resp_map.get('Code'),
                        'message': resp_map.get('Message'),
                        'data': {
                            'httpCode': _response.status_code,
                            'requestId': resp_map.get('RequestId'),
                            'hostId': resp_map.get('HostId')
                        }
                    })
                return oss_models.GetObjectResponse().from_map(
                    TeaCore.merge({
                        'body': _response.body
                    }, _response.headers)
                )
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    async def get_object_async(
        self,
        request: oss_models.GetObjectRequest,
        runtime: ossutil_models.RuntimeOptions,
    ) -> oss_models.GetObjectResponse:
        request.validate()
        runtime.validate()
        _runtime = {
            'timeouted': 'retry',
            'readTimeout': UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            'connectTimeout': UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            'localAddr': UtilClient.default_string(runtime.local_addr, self._local_addr),
            'httpProxy': UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            'httpsProxy': UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            'noProxy': UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            'socks5Proxy': UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            'socks5NetWork': UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            'maxIdleConns': UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            'retry': {
                'retryable': runtime.autoretry,
                'maxAttempts': UtilClient.default_number(runtime.max_attempts, 3)
            },
            'backoff': {
                'policy': UtilClient.default_string(runtime.backoff_policy, 'no'),
                'period': UtilClient.default_number(runtime.backoff_period, 1)
            },
            'ignoreSSL': runtime.ignore_ssl
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
                access_key_id = await self._credential.get_access_key_id_async()
                access_key_secret = await self._credential.get_access_key_secret_async()
                token = await self._credential.get_security_token_async()
                _request.protocol = self._protocol
                _request.method = 'GET'
                _request.pathname = f'/{request.object_name}'
                _request.headers = TeaCore.merge({
                    'host': OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    'date': UtilClient.get_date_utcstring(),
                    'user-agent': self.get_user_agent()
                }, UtilClient.stringify_map_value(TeaCore.to_map(request.header)))
                if not UtilClient.empty(token):
                    _request.headers['x-oss-security-token'] = token
                _request.headers['authorization'] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = await TeaCore.async_do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = await UtilClient.read_as_string_async(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        'code': resp_map.get('Code'),
                        'message': resp_map.get('Message'),
                        'data': {
                            'httpCode': _response.status_code,
                            'requestId': resp_map.get('RequestId'),
                            'hostId': resp_map.get('HostId')
                        }
                    })
                return oss_models.GetObjectResponse().from_map(
                    TeaCore.merge({
                        'body': _response.body
                    }, _response.headers)
                )
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def upload_part(
        self,
        request: oss_models.UploadPartRequest,
        runtime: ossutil_models.RuntimeOptions,
    ) -> oss_models.UploadPartResponse:
        request.validate()
        runtime.validate()
        _runtime = {
            'timeouted': 'retry',
            'readTimeout': UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            'connectTimeout': UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            'localAddr': UtilClient.default_string(runtime.local_addr, self._local_addr),
            'httpProxy': UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            'httpsProxy': UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            'noProxy': UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            'socks5Proxy': UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            'socks5NetWork': UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            'maxIdleConns': UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            'retry': {
                'retryable': runtime.autoretry,
                'maxAttempts': UtilClient.default_number(runtime.max_attempts, 3)
            },
            'backoff': {
                'policy': UtilClient.default_string(runtime.backoff_policy, 'no'),
                'period': UtilClient.default_number(runtime.backoff_period, 1)
            },
            'ignoreSSL': runtime.ignore_ssl
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
                _request.method = 'PUT'
                _request.pathname = f'/{request.object_name}'
                _request.headers = {
                    'host': OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    'date': UtilClient.get_date_utcstring(),
                    'user-agent': self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers['x-oss-security-token'] = token
                _request.query = UtilClient.stringify_map_value(TeaCore.to_map(request.filter))
                _request.body = OSSUtilClient.inject(request.body, ctx)
                _request.headers['authorization'] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = UtilClient.read_as_string(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        'code': resp_map.get('Code'),
                        'message': resp_map.get('Message'),
                        'data': {
                            'httpCode': _response.status_code,
                            'requestId': resp_map.get('RequestId'),
                            'hostId': resp_map.get('HostId')
                        }
                    })
                if self._is_enable_crc and not UtilClient.equal_string(ctx.get('crc'), _response.headers.get('x-oss-hash-crc64ecma')):
                    raise TeaException({
                        'code': 'CrcNotMatched',
                        'data': {
                            'clientCrc': ctx.get('crc'),
                            'serverCrc': _response.headers.get('x-oss-hash-crc64ecma')
                        }
                    })
                if self._is_enable_md5 and not UtilClient.equal_string(ctx.get('md5'), _response.headers.get('content-md5')):
                    raise TeaException({
                        'code': 'MD5NotMatched',
                        'data': {
                            'clientMD5': ctx.get('md5'),
                            'serverMD5': _response.headers.get('content-md5')
                        }
                    })
                return oss_models.UploadPartResponse().from_map(
                    TeaCore.merge(_response.headers)
                )
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    async def upload_part_async(
        self,
        request: oss_models.UploadPartRequest,
        runtime: ossutil_models.RuntimeOptions,
    ) -> oss_models.UploadPartResponse:
        request.validate()
        runtime.validate()
        _runtime = {
            'timeouted': 'retry',
            'readTimeout': UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            'connectTimeout': UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            'localAddr': UtilClient.default_string(runtime.local_addr, self._local_addr),
            'httpProxy': UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            'httpsProxy': UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            'noProxy': UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            'socks5Proxy': UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            'socks5NetWork': UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            'maxIdleConns': UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            'retry': {
                'retryable': runtime.autoretry,
                'maxAttempts': UtilClient.default_number(runtime.max_attempts, 3)
            },
            'backoff': {
                'policy': UtilClient.default_string(runtime.backoff_policy, 'no'),
                'period': UtilClient.default_number(runtime.backoff_period, 1)
            },
            'ignoreSSL': runtime.ignore_ssl
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
                access_key_id = await self._credential.get_access_key_id_async()
                access_key_secret = await self._credential.get_access_key_secret_async()
                token = await self._credential.get_security_token_async()
                _request.protocol = self._protocol
                _request.method = 'PUT'
                _request.pathname = f'/{request.object_name}'
                _request.headers = {
                    'host': OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    'date': UtilClient.get_date_utcstring(),
                    'user-agent': self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers['x-oss-security-token'] = token
                _request.query = UtilClient.stringify_map_value(TeaCore.to_map(request.filter))
                _request.body = OSSUtilClient.inject(request.body, ctx)
                _request.headers['authorization'] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = await TeaCore.async_do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = await UtilClient.read_as_string_async(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        'code': resp_map.get('Code'),
                        'message': resp_map.get('Message'),
                        'data': {
                            'httpCode': _response.status_code,
                            'requestId': resp_map.get('RequestId'),
                            'hostId': resp_map.get('HostId')
                        }
                    })
                if self._is_enable_crc and not UtilClient.equal_string(ctx.get('crc'), _response.headers.get('x-oss-hash-crc64ecma')):
                    raise TeaException({
                        'code': 'CrcNotMatched',
                        'data': {
                            'clientCrc': ctx.get('crc'),
                            'serverCrc': _response.headers.get('x-oss-hash-crc64ecma')
                        }
                    })
                if self._is_enable_md5 and not UtilClient.equal_string(ctx.get('md5'), _response.headers.get('content-md5')):
                    raise TeaException({
                        'code': 'MD5NotMatched',
                        'data': {
                            'clientMD5': ctx.get('md5'),
                            'serverMD5': _response.headers.get('content-md5')
                        }
                    })
                return oss_models.UploadPartResponse().from_map(
                    TeaCore.merge(_response.headers)
                )
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def get_bucket_cors(
        self,
        request: oss_models.GetBucketCORSRequest,
        runtime: ossutil_models.RuntimeOptions,
    ) -> oss_models.GetBucketCORSResponse:
        request.validate()
        runtime.validate()
        _runtime = {
            'timeouted': 'retry',
            'readTimeout': UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            'connectTimeout': UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            'localAddr': UtilClient.default_string(runtime.local_addr, self._local_addr),
            'httpProxy': UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            'httpsProxy': UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            'noProxy': UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            'socks5Proxy': UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            'socks5NetWork': UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            'maxIdleConns': UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            'retry': {
                'retryable': runtime.autoretry,
                'maxAttempts': UtilClient.default_number(runtime.max_attempts, 3)
            },
            'backoff': {
                'policy': UtilClient.default_string(runtime.backoff_policy, 'no'),
                'period': UtilClient.default_number(runtime.backoff_period, 1)
            },
            'ignoreSSL': runtime.ignore_ssl
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
                _request.method = 'GET'
                _request.pathname = f'/?cors'
                _request.headers = {
                    'host': OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    'date': UtilClient.get_date_utcstring(),
                    'user-agent': self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers['x-oss-security-token'] = token
                _request.headers['authorization'] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = UtilClient.read_as_string(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        'code': resp_map.get('Code'),
                        'message': resp_map.get('Message'),
                        'data': {
                            'httpCode': _response.status_code,
                            'requestId': resp_map.get('RequestId'),
                            'hostId': resp_map.get('HostId')
                        }
                    })
                body_str = UtilClient.read_as_string(_response.body)
                resp_map = XMLClient.parse_xml(body_str, oss_models.GetBucketCORSResponse())
                return oss_models.GetBucketCORSResponse().from_map(
                    TeaCore.merge({
                        'CORSConfiguration': resp_map.get('CORSConfiguration')
                    }, _response.headers)
                )
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    async def get_bucket_cors_async(
        self,
        request: oss_models.GetBucketCORSRequest,
        runtime: ossutil_models.RuntimeOptions,
    ) -> oss_models.GetBucketCORSResponse:
        request.validate()
        runtime.validate()
        _runtime = {
            'timeouted': 'retry',
            'readTimeout': UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            'connectTimeout': UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            'localAddr': UtilClient.default_string(runtime.local_addr, self._local_addr),
            'httpProxy': UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            'httpsProxy': UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            'noProxy': UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            'socks5Proxy': UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            'socks5NetWork': UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            'maxIdleConns': UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            'retry': {
                'retryable': runtime.autoretry,
                'maxAttempts': UtilClient.default_number(runtime.max_attempts, 3)
            },
            'backoff': {
                'policy': UtilClient.default_string(runtime.backoff_policy, 'no'),
                'period': UtilClient.default_number(runtime.backoff_period, 1)
            },
            'ignoreSSL': runtime.ignore_ssl
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
                access_key_id = await self._credential.get_access_key_id_async()
                access_key_secret = await self._credential.get_access_key_secret_async()
                token = await self._credential.get_security_token_async()
                _request.protocol = self._protocol
                _request.method = 'GET'
                _request.pathname = f'/?cors'
                _request.headers = {
                    'host': OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    'date': UtilClient.get_date_utcstring(),
                    'user-agent': self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers['x-oss-security-token'] = token
                _request.headers['authorization'] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = await TeaCore.async_do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = await UtilClient.read_as_string_async(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        'code': resp_map.get('Code'),
                        'message': resp_map.get('Message'),
                        'data': {
                            'httpCode': _response.status_code,
                            'requestId': resp_map.get('RequestId'),
                            'hostId': resp_map.get('HostId')
                        }
                    })
                body_str = await UtilClient.read_as_string_async(_response.body)
                resp_map = XMLClient.parse_xml(body_str, oss_models.GetBucketCORSResponse())
                return oss_models.GetBucketCORSResponse().from_map(
                    TeaCore.merge({
                        'CORSConfiguration': resp_map.get('CORSConfiguration')
                    }, _response.headers)
                )
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def copy_object(
        self,
        request: oss_models.CopyObjectRequest,
        runtime: ossutil_models.RuntimeOptions,
    ) -> oss_models.CopyObjectResponse:
        request.validate()
        runtime.validate()
        _runtime = {
            'timeouted': 'retry',
            'readTimeout': UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            'connectTimeout': UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            'localAddr': UtilClient.default_string(runtime.local_addr, self._local_addr),
            'httpProxy': UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            'httpsProxy': UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            'noProxy': UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            'socks5Proxy': UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            'socks5NetWork': UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            'maxIdleConns': UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            'retry': {
                'retryable': runtime.autoretry,
                'maxAttempts': UtilClient.default_number(runtime.max_attempts, 3)
            },
            'backoff': {
                'policy': UtilClient.default_string(runtime.backoff_policy, 'no'),
                'period': UtilClient.default_number(runtime.backoff_period, 1)
            },
            'ignoreSSL': runtime.ignore_ssl
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
                _request.method = 'PUT'
                _request.pathname = f'/{request.dest_object_name}'
                _request.headers = TeaCore.merge({
                    'host': OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    'date': UtilClient.get_date_utcstring(),
                    'user-agent': self.get_user_agent()
                }, UtilClient.stringify_map_value(TeaCore.to_map(request.header)))
                if not UtilClient.empty(token):
                    _request.headers['x-oss-security-token'] = token
                _request.headers['x-oss-copy-source'] = OSSUtilClient.encode(_request.headers.get('x-oss-copy-source'), 'UrlEncode')
                _request.headers['authorization'] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = UtilClient.read_as_string(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        'code': resp_map.get('Code'),
                        'message': resp_map.get('Message'),
                        'data': {
                            'httpCode': _response.status_code,
                            'requestId': resp_map.get('RequestId'),
                            'hostId': resp_map.get('HostId')
                        }
                    })
                body_str = UtilClient.read_as_string(_response.body)
                resp_map = XMLClient.parse_xml(body_str, oss_models.CopyObjectResponse())
                return oss_models.CopyObjectResponse().from_map(
                    TeaCore.merge({
                        'CopyObjectResult': resp_map.get('CopyObjectResult')
                    }, _response.headers)
                )
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    async def copy_object_async(
        self,
        request: oss_models.CopyObjectRequest,
        runtime: ossutil_models.RuntimeOptions,
    ) -> oss_models.CopyObjectResponse:
        request.validate()
        runtime.validate()
        _runtime = {
            'timeouted': 'retry',
            'readTimeout': UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            'connectTimeout': UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            'localAddr': UtilClient.default_string(runtime.local_addr, self._local_addr),
            'httpProxy': UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            'httpsProxy': UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            'noProxy': UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            'socks5Proxy': UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            'socks5NetWork': UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            'maxIdleConns': UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            'retry': {
                'retryable': runtime.autoretry,
                'maxAttempts': UtilClient.default_number(runtime.max_attempts, 3)
            },
            'backoff': {
                'policy': UtilClient.default_string(runtime.backoff_policy, 'no'),
                'period': UtilClient.default_number(runtime.backoff_period, 1)
            },
            'ignoreSSL': runtime.ignore_ssl
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
                access_key_id = await self._credential.get_access_key_id_async()
                access_key_secret = await self._credential.get_access_key_secret_async()
                token = await self._credential.get_security_token_async()
                _request.protocol = self._protocol
                _request.method = 'PUT'
                _request.pathname = f'/{request.dest_object_name}'
                _request.headers = TeaCore.merge({
                    'host': OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    'date': UtilClient.get_date_utcstring(),
                    'user-agent': self.get_user_agent()
                }, UtilClient.stringify_map_value(TeaCore.to_map(request.header)))
                if not UtilClient.empty(token):
                    _request.headers['x-oss-security-token'] = token
                _request.headers['x-oss-copy-source'] = OSSUtilClient.encode(_request.headers.get('x-oss-copy-source'), 'UrlEncode')
                _request.headers['authorization'] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = await TeaCore.async_do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = await UtilClient.read_as_string_async(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        'code': resp_map.get('Code'),
                        'message': resp_map.get('Message'),
                        'data': {
                            'httpCode': _response.status_code,
                            'requestId': resp_map.get('RequestId'),
                            'hostId': resp_map.get('HostId')
                        }
                    })
                body_str = await UtilClient.read_as_string_async(_response.body)
                resp_map = XMLClient.parse_xml(body_str, oss_models.CopyObjectResponse())
                return oss_models.CopyObjectResponse().from_map(
                    TeaCore.merge({
                        'CopyObjectResult': resp_map.get('CopyObjectResult')
                    }, _response.headers)
                )
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def get_object_tagging(
        self,
        request: oss_models.GetObjectTaggingRequest,
        runtime: ossutil_models.RuntimeOptions,
    ) -> oss_models.GetObjectTaggingResponse:
        request.validate()
        runtime.validate()
        _runtime = {
            'timeouted': 'retry',
            'readTimeout': UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            'connectTimeout': UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            'localAddr': UtilClient.default_string(runtime.local_addr, self._local_addr),
            'httpProxy': UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            'httpsProxy': UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            'noProxy': UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            'socks5Proxy': UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            'socks5NetWork': UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            'maxIdleConns': UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            'retry': {
                'retryable': runtime.autoretry,
                'maxAttempts': UtilClient.default_number(runtime.max_attempts, 3)
            },
            'backoff': {
                'policy': UtilClient.default_string(runtime.backoff_policy, 'no'),
                'period': UtilClient.default_number(runtime.backoff_period, 1)
            },
            'ignoreSSL': runtime.ignore_ssl
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
                _request.method = 'GET'
                _request.pathname = f'/{request.object_name}?tagging'
                _request.headers = {
                    'host': OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    'date': UtilClient.get_date_utcstring(),
                    'user-agent': self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers['x-oss-security-token'] = token
                _request.headers['authorization'] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = UtilClient.read_as_string(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        'code': resp_map.get('Code'),
                        'message': resp_map.get('Message'),
                        'data': {
                            'httpCode': _response.status_code,
                            'requestId': resp_map.get('RequestId'),
                            'hostId': resp_map.get('HostId')
                        }
                    })
                body_str = UtilClient.read_as_string(_response.body)
                resp_map = XMLClient.parse_xml(body_str, oss_models.GetObjectTaggingResponse())
                return oss_models.GetObjectTaggingResponse().from_map(
                    TeaCore.merge({
                        'Tagging': resp_map.get('Tagging')
                    }, _response.headers)
                )
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    async def get_object_tagging_async(
        self,
        request: oss_models.GetObjectTaggingRequest,
        runtime: ossutil_models.RuntimeOptions,
    ) -> oss_models.GetObjectTaggingResponse:
        request.validate()
        runtime.validate()
        _runtime = {
            'timeouted': 'retry',
            'readTimeout': UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            'connectTimeout': UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            'localAddr': UtilClient.default_string(runtime.local_addr, self._local_addr),
            'httpProxy': UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            'httpsProxy': UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            'noProxy': UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            'socks5Proxy': UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            'socks5NetWork': UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            'maxIdleConns': UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            'retry': {
                'retryable': runtime.autoretry,
                'maxAttempts': UtilClient.default_number(runtime.max_attempts, 3)
            },
            'backoff': {
                'policy': UtilClient.default_string(runtime.backoff_policy, 'no'),
                'period': UtilClient.default_number(runtime.backoff_period, 1)
            },
            'ignoreSSL': runtime.ignore_ssl
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
                access_key_id = await self._credential.get_access_key_id_async()
                access_key_secret = await self._credential.get_access_key_secret_async()
                token = await self._credential.get_security_token_async()
                _request.protocol = self._protocol
                _request.method = 'GET'
                _request.pathname = f'/{request.object_name}?tagging'
                _request.headers = {
                    'host': OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    'date': UtilClient.get_date_utcstring(),
                    'user-agent': self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers['x-oss-security-token'] = token
                _request.headers['authorization'] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = await TeaCore.async_do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = await UtilClient.read_as_string_async(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        'code': resp_map.get('Code'),
                        'message': resp_map.get('Message'),
                        'data': {
                            'httpCode': _response.status_code,
                            'requestId': resp_map.get('RequestId'),
                            'hostId': resp_map.get('HostId')
                        }
                    })
                body_str = await UtilClient.read_as_string_async(_response.body)
                resp_map = XMLClient.parse_xml(body_str, oss_models.GetObjectTaggingResponse())
                return oss_models.GetObjectTaggingResponse().from_map(
                    TeaCore.merge({
                        'Tagging': resp_map.get('Tagging')
                    }, _response.headers)
                )
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def delete_bucket_lifecycle(
        self,
        request: oss_models.DeleteBucketLifecycleRequest,
        runtime: ossutil_models.RuntimeOptions,
    ) -> oss_models.DeleteBucketLifecycleResponse:
        request.validate()
        runtime.validate()
        _runtime = {
            'timeouted': 'retry',
            'readTimeout': UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            'connectTimeout': UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            'localAddr': UtilClient.default_string(runtime.local_addr, self._local_addr),
            'httpProxy': UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            'httpsProxy': UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            'noProxy': UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            'socks5Proxy': UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            'socks5NetWork': UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            'maxIdleConns': UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            'retry': {
                'retryable': runtime.autoretry,
                'maxAttempts': UtilClient.default_number(runtime.max_attempts, 3)
            },
            'backoff': {
                'policy': UtilClient.default_string(runtime.backoff_policy, 'no'),
                'period': UtilClient.default_number(runtime.backoff_period, 1)
            },
            'ignoreSSL': runtime.ignore_ssl
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
                _request.method = 'DELETE'
                _request.pathname = f'/?lifecycle'
                _request.headers = {
                    'host': OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    'date': UtilClient.get_date_utcstring(),
                    'user-agent': self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers['x-oss-security-token'] = token
                _request.headers['authorization'] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = UtilClient.read_as_string(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        'code': resp_map.get('Code'),
                        'message': resp_map.get('Message'),
                        'data': {
                            'httpCode': _response.status_code,
                            'requestId': resp_map.get('RequestId'),
                            'hostId': resp_map.get('HostId')
                        }
                    })
                return oss_models.DeleteBucketLifecycleResponse().from_map(
                    TeaCore.merge(_response.headers)
                )
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    async def delete_bucket_lifecycle_async(
        self,
        request: oss_models.DeleteBucketLifecycleRequest,
        runtime: ossutil_models.RuntimeOptions,
    ) -> oss_models.DeleteBucketLifecycleResponse:
        request.validate()
        runtime.validate()
        _runtime = {
            'timeouted': 'retry',
            'readTimeout': UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            'connectTimeout': UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            'localAddr': UtilClient.default_string(runtime.local_addr, self._local_addr),
            'httpProxy': UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            'httpsProxy': UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            'noProxy': UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            'socks5Proxy': UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            'socks5NetWork': UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            'maxIdleConns': UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            'retry': {
                'retryable': runtime.autoretry,
                'maxAttempts': UtilClient.default_number(runtime.max_attempts, 3)
            },
            'backoff': {
                'policy': UtilClient.default_string(runtime.backoff_policy, 'no'),
                'period': UtilClient.default_number(runtime.backoff_period, 1)
            },
            'ignoreSSL': runtime.ignore_ssl
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
                access_key_id = await self._credential.get_access_key_id_async()
                access_key_secret = await self._credential.get_access_key_secret_async()
                token = await self._credential.get_security_token_async()
                _request.protocol = self._protocol
                _request.method = 'DELETE'
                _request.pathname = f'/?lifecycle'
                _request.headers = {
                    'host': OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    'date': UtilClient.get_date_utcstring(),
                    'user-agent': self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers['x-oss-security-token'] = token
                _request.headers['authorization'] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = await TeaCore.async_do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = await UtilClient.read_as_string_async(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        'code': resp_map.get('Code'),
                        'message': resp_map.get('Message'),
                        'data': {
                            'httpCode': _response.status_code,
                            'requestId': resp_map.get('RequestId'),
                            'hostId': resp_map.get('HostId')
                        }
                    })
                return oss_models.DeleteBucketLifecycleResponse().from_map(
                    TeaCore.merge(_response.headers)
                )
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def delete_bucket_logging(
        self,
        request: oss_models.DeleteBucketLoggingRequest,
        runtime: ossutil_models.RuntimeOptions,
    ) -> oss_models.DeleteBucketLoggingResponse:
        request.validate()
        runtime.validate()
        _runtime = {
            'timeouted': 'retry',
            'readTimeout': UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            'connectTimeout': UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            'localAddr': UtilClient.default_string(runtime.local_addr, self._local_addr),
            'httpProxy': UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            'httpsProxy': UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            'noProxy': UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            'socks5Proxy': UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            'socks5NetWork': UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            'maxIdleConns': UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            'retry': {
                'retryable': runtime.autoretry,
                'maxAttempts': UtilClient.default_number(runtime.max_attempts, 3)
            },
            'backoff': {
                'policy': UtilClient.default_string(runtime.backoff_policy, 'no'),
                'period': UtilClient.default_number(runtime.backoff_period, 1)
            },
            'ignoreSSL': runtime.ignore_ssl
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
                _request.method = 'DELETE'
                _request.pathname = f'/?logging'
                _request.headers = {
                    'host': OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    'date': UtilClient.get_date_utcstring(),
                    'user-agent': self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers['x-oss-security-token'] = token
                _request.headers['authorization'] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = UtilClient.read_as_string(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        'code': resp_map.get('Code'),
                        'message': resp_map.get('Message'),
                        'data': {
                            'httpCode': _response.status_code,
                            'requestId': resp_map.get('RequestId'),
                            'hostId': resp_map.get('HostId')
                        }
                    })
                return oss_models.DeleteBucketLoggingResponse().from_map(
                    TeaCore.merge(_response.headers)
                )
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    async def delete_bucket_logging_async(
        self,
        request: oss_models.DeleteBucketLoggingRequest,
        runtime: ossutil_models.RuntimeOptions,
    ) -> oss_models.DeleteBucketLoggingResponse:
        request.validate()
        runtime.validate()
        _runtime = {
            'timeouted': 'retry',
            'readTimeout': UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            'connectTimeout': UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            'localAddr': UtilClient.default_string(runtime.local_addr, self._local_addr),
            'httpProxy': UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            'httpsProxy': UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            'noProxy': UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            'socks5Proxy': UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            'socks5NetWork': UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            'maxIdleConns': UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            'retry': {
                'retryable': runtime.autoretry,
                'maxAttempts': UtilClient.default_number(runtime.max_attempts, 3)
            },
            'backoff': {
                'policy': UtilClient.default_string(runtime.backoff_policy, 'no'),
                'period': UtilClient.default_number(runtime.backoff_period, 1)
            },
            'ignoreSSL': runtime.ignore_ssl
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
                access_key_id = await self._credential.get_access_key_id_async()
                access_key_secret = await self._credential.get_access_key_secret_async()
                token = await self._credential.get_security_token_async()
                _request.protocol = self._protocol
                _request.method = 'DELETE'
                _request.pathname = f'/?logging'
                _request.headers = {
                    'host': OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    'date': UtilClient.get_date_utcstring(),
                    'user-agent': self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers['x-oss-security-token'] = token
                _request.headers['authorization'] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = await TeaCore.async_do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = await UtilClient.read_as_string_async(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        'code': resp_map.get('Code'),
                        'message': resp_map.get('Message'),
                        'data': {
                            'httpCode': _response.status_code,
                            'requestId': resp_map.get('RequestId'),
                            'hostId': resp_map.get('HostId')
                        }
                    })
                return oss_models.DeleteBucketLoggingResponse().from_map(
                    TeaCore.merge(_response.headers)
                )
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def delete_bucket_website(
        self,
        request: oss_models.DeleteBucketWebsiteRequest,
        runtime: ossutil_models.RuntimeOptions,
    ) -> oss_models.DeleteBucketWebsiteResponse:
        request.validate()
        runtime.validate()
        _runtime = {
            'timeouted': 'retry',
            'readTimeout': UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            'connectTimeout': UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            'localAddr': UtilClient.default_string(runtime.local_addr, self._local_addr),
            'httpProxy': UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            'httpsProxy': UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            'noProxy': UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            'socks5Proxy': UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            'socks5NetWork': UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            'maxIdleConns': UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            'retry': {
                'retryable': runtime.autoretry,
                'maxAttempts': UtilClient.default_number(runtime.max_attempts, 3)
            },
            'backoff': {
                'policy': UtilClient.default_string(runtime.backoff_policy, 'no'),
                'period': UtilClient.default_number(runtime.backoff_period, 1)
            },
            'ignoreSSL': runtime.ignore_ssl
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
                _request.method = 'DELETE'
                _request.pathname = f'/?website'
                _request.headers = {
                    'host': OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    'date': UtilClient.get_date_utcstring(),
                    'user-agent': self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers['x-oss-security-token'] = token
                _request.headers['authorization'] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = UtilClient.read_as_string(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        'code': resp_map.get('Code'),
                        'message': resp_map.get('Message'),
                        'data': {
                            'httpCode': _response.status_code,
                            'requestId': resp_map.get('RequestId'),
                            'hostId': resp_map.get('HostId')
                        }
                    })
                return oss_models.DeleteBucketWebsiteResponse().from_map(
                    TeaCore.merge(_response.headers)
                )
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    async def delete_bucket_website_async(
        self,
        request: oss_models.DeleteBucketWebsiteRequest,
        runtime: ossutil_models.RuntimeOptions,
    ) -> oss_models.DeleteBucketWebsiteResponse:
        request.validate()
        runtime.validate()
        _runtime = {
            'timeouted': 'retry',
            'readTimeout': UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            'connectTimeout': UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            'localAddr': UtilClient.default_string(runtime.local_addr, self._local_addr),
            'httpProxy': UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            'httpsProxy': UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            'noProxy': UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            'socks5Proxy': UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            'socks5NetWork': UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            'maxIdleConns': UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            'retry': {
                'retryable': runtime.autoretry,
                'maxAttempts': UtilClient.default_number(runtime.max_attempts, 3)
            },
            'backoff': {
                'policy': UtilClient.default_string(runtime.backoff_policy, 'no'),
                'period': UtilClient.default_number(runtime.backoff_period, 1)
            },
            'ignoreSSL': runtime.ignore_ssl
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
                access_key_id = await self._credential.get_access_key_id_async()
                access_key_secret = await self._credential.get_access_key_secret_async()
                token = await self._credential.get_security_token_async()
                _request.protocol = self._protocol
                _request.method = 'DELETE'
                _request.pathname = f'/?website'
                _request.headers = {
                    'host': OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    'date': UtilClient.get_date_utcstring(),
                    'user-agent': self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers['x-oss-security-token'] = token
                _request.headers['authorization'] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = await TeaCore.async_do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = await UtilClient.read_as_string_async(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        'code': resp_map.get('Code'),
                        'message': resp_map.get('Message'),
                        'data': {
                            'httpCode': _response.status_code,
                            'requestId': resp_map.get('RequestId'),
                            'hostId': resp_map.get('HostId')
                        }
                    })
                return oss_models.DeleteBucketWebsiteResponse().from_map(
                    TeaCore.merge(_response.headers)
                )
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def get_symlink(
        self,
        request: oss_models.GetSymlinkRequest,
        runtime: ossutil_models.RuntimeOptions,
    ) -> oss_models.GetSymlinkResponse:
        request.validate()
        runtime.validate()
        _runtime = {
            'timeouted': 'retry',
            'readTimeout': UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            'connectTimeout': UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            'localAddr': UtilClient.default_string(runtime.local_addr, self._local_addr),
            'httpProxy': UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            'httpsProxy': UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            'noProxy': UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            'socks5Proxy': UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            'socks5NetWork': UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            'maxIdleConns': UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            'retry': {
                'retryable': runtime.autoretry,
                'maxAttempts': UtilClient.default_number(runtime.max_attempts, 3)
            },
            'backoff': {
                'policy': UtilClient.default_string(runtime.backoff_policy, 'no'),
                'period': UtilClient.default_number(runtime.backoff_period, 1)
            },
            'ignoreSSL': runtime.ignore_ssl
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
                _request.method = 'GET'
                _request.pathname = f'/{request.object_name}?symlink'
                _request.headers = {
                    'host': OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    'date': UtilClient.get_date_utcstring(),
                    'user-agent': self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers['x-oss-security-token'] = token
                _request.headers['authorization'] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = UtilClient.read_as_string(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        'code': resp_map.get('Code'),
                        'message': resp_map.get('Message'),
                        'data': {
                            'httpCode': _response.status_code,
                            'requestId': resp_map.get('RequestId'),
                            'hostId': resp_map.get('HostId')
                        }
                    })
                return oss_models.GetSymlinkResponse().from_map(
                    TeaCore.merge(_response.headers)
                )
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    async def get_symlink_async(
        self,
        request: oss_models.GetSymlinkRequest,
        runtime: ossutil_models.RuntimeOptions,
    ) -> oss_models.GetSymlinkResponse:
        request.validate()
        runtime.validate()
        _runtime = {
            'timeouted': 'retry',
            'readTimeout': UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            'connectTimeout': UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            'localAddr': UtilClient.default_string(runtime.local_addr, self._local_addr),
            'httpProxy': UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            'httpsProxy': UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            'noProxy': UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            'socks5Proxy': UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            'socks5NetWork': UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            'maxIdleConns': UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            'retry': {
                'retryable': runtime.autoretry,
                'maxAttempts': UtilClient.default_number(runtime.max_attempts, 3)
            },
            'backoff': {
                'policy': UtilClient.default_string(runtime.backoff_policy, 'no'),
                'period': UtilClient.default_number(runtime.backoff_period, 1)
            },
            'ignoreSSL': runtime.ignore_ssl
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
                access_key_id = await self._credential.get_access_key_id_async()
                access_key_secret = await self._credential.get_access_key_secret_async()
                token = await self._credential.get_security_token_async()
                _request.protocol = self._protocol
                _request.method = 'GET'
                _request.pathname = f'/{request.object_name}?symlink'
                _request.headers = {
                    'host': OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    'date': UtilClient.get_date_utcstring(),
                    'user-agent': self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers['x-oss-security-token'] = token
                _request.headers['authorization'] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = await TeaCore.async_do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = await UtilClient.read_as_string_async(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        'code': resp_map.get('Code'),
                        'message': resp_map.get('Message'),
                        'data': {
                            'httpCode': _response.status_code,
                            'requestId': resp_map.get('RequestId'),
                            'hostId': resp_map.get('HostId')
                        }
                    })
                return oss_models.GetSymlinkResponse().from_map(
                    TeaCore.merge(_response.headers)
                )
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def get_bucket_lifecycle(
        self,
        request: oss_models.GetBucketLifecycleRequest,
        runtime: ossutil_models.RuntimeOptions,
    ) -> oss_models.GetBucketLifecycleResponse:
        request.validate()
        runtime.validate()
        _runtime = {
            'timeouted': 'retry',
            'readTimeout': UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            'connectTimeout': UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            'localAddr': UtilClient.default_string(runtime.local_addr, self._local_addr),
            'httpProxy': UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            'httpsProxy': UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            'noProxy': UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            'socks5Proxy': UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            'socks5NetWork': UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            'maxIdleConns': UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            'retry': {
                'retryable': runtime.autoretry,
                'maxAttempts': UtilClient.default_number(runtime.max_attempts, 3)
            },
            'backoff': {
                'policy': UtilClient.default_string(runtime.backoff_policy, 'no'),
                'period': UtilClient.default_number(runtime.backoff_period, 1)
            },
            'ignoreSSL': runtime.ignore_ssl
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
                _request.method = 'GET'
                _request.pathname = f'/?lifecycle'
                _request.headers = {
                    'host': OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    'date': UtilClient.get_date_utcstring(),
                    'user-agent': self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers['x-oss-security-token'] = token
                _request.headers['authorization'] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = UtilClient.read_as_string(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        'code': resp_map.get('Code'),
                        'message': resp_map.get('Message'),
                        'data': {
                            'httpCode': _response.status_code,
                            'requestId': resp_map.get('RequestId'),
                            'hostId': resp_map.get('HostId')
                        }
                    })
                body_str = UtilClient.read_as_string(_response.body)
                resp_map = XMLClient.parse_xml(body_str, oss_models.GetBucketLifecycleResponse())
                return oss_models.GetBucketLifecycleResponse().from_map(
                    TeaCore.merge({
                        'LifecycleConfiguration': resp_map.get('LifecycleConfiguration')
                    }, _response.headers)
                )
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    async def get_bucket_lifecycle_async(
        self,
        request: oss_models.GetBucketLifecycleRequest,
        runtime: ossutil_models.RuntimeOptions,
    ) -> oss_models.GetBucketLifecycleResponse:
        request.validate()
        runtime.validate()
        _runtime = {
            'timeouted': 'retry',
            'readTimeout': UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            'connectTimeout': UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            'localAddr': UtilClient.default_string(runtime.local_addr, self._local_addr),
            'httpProxy': UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            'httpsProxy': UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            'noProxy': UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            'socks5Proxy': UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            'socks5NetWork': UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            'maxIdleConns': UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            'retry': {
                'retryable': runtime.autoretry,
                'maxAttempts': UtilClient.default_number(runtime.max_attempts, 3)
            },
            'backoff': {
                'policy': UtilClient.default_string(runtime.backoff_policy, 'no'),
                'period': UtilClient.default_number(runtime.backoff_period, 1)
            },
            'ignoreSSL': runtime.ignore_ssl
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
                access_key_id = await self._credential.get_access_key_id_async()
                access_key_secret = await self._credential.get_access_key_secret_async()
                token = await self._credential.get_security_token_async()
                _request.protocol = self._protocol
                _request.method = 'GET'
                _request.pathname = f'/?lifecycle'
                _request.headers = {
                    'host': OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    'date': UtilClient.get_date_utcstring(),
                    'user-agent': self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers['x-oss-security-token'] = token
                _request.headers['authorization'] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = await TeaCore.async_do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = await UtilClient.read_as_string_async(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        'code': resp_map.get('Code'),
                        'message': resp_map.get('Message'),
                        'data': {
                            'httpCode': _response.status_code,
                            'requestId': resp_map.get('RequestId'),
                            'hostId': resp_map.get('HostId')
                        }
                    })
                body_str = await UtilClient.read_as_string_async(_response.body)
                resp_map = XMLClient.parse_xml(body_str, oss_models.GetBucketLifecycleResponse())
                return oss_models.GetBucketLifecycleResponse().from_map(
                    TeaCore.merge({
                        'LifecycleConfiguration': resp_map.get('LifecycleConfiguration')
                    }, _response.headers)
                )
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def put_symlink(
        self,
        request: oss_models.PutSymlinkRequest,
        runtime: ossutil_models.RuntimeOptions,
    ) -> oss_models.PutSymlinkResponse:
        request.validate()
        runtime.validate()
        _runtime = {
            'timeouted': 'retry',
            'readTimeout': UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            'connectTimeout': UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            'localAddr': UtilClient.default_string(runtime.local_addr, self._local_addr),
            'httpProxy': UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            'httpsProxy': UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            'noProxy': UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            'socks5Proxy': UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            'socks5NetWork': UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            'maxIdleConns': UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            'retry': {
                'retryable': runtime.autoretry,
                'maxAttempts': UtilClient.default_number(runtime.max_attempts, 3)
            },
            'backoff': {
                'policy': UtilClient.default_string(runtime.backoff_policy, 'no'),
                'period': UtilClient.default_number(runtime.backoff_period, 1)
            },
            'ignoreSSL': runtime.ignore_ssl
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
                _request.method = 'PUT'
                _request.pathname = f'/{request.object_name}?symlink'
                _request.headers = TeaCore.merge({
                    'host': OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    'date': UtilClient.get_date_utcstring(),
                    'user-agent': self.get_user_agent()
                }, UtilClient.stringify_map_value(TeaCore.to_map(request.header)))
                if not UtilClient.empty(token):
                    _request.headers['x-oss-security-token'] = token
                _request.headers['authorization'] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = UtilClient.read_as_string(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        'code': resp_map.get('Code'),
                        'message': resp_map.get('Message'),
                        'data': {
                            'httpCode': _response.status_code,
                            'requestId': resp_map.get('RequestId'),
                            'hostId': resp_map.get('HostId')
                        }
                    })
                return oss_models.PutSymlinkResponse().from_map(
                    TeaCore.merge(_response.headers)
                )
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    async def put_symlink_async(
        self,
        request: oss_models.PutSymlinkRequest,
        runtime: ossutil_models.RuntimeOptions,
    ) -> oss_models.PutSymlinkResponse:
        request.validate()
        runtime.validate()
        _runtime = {
            'timeouted': 'retry',
            'readTimeout': UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            'connectTimeout': UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            'localAddr': UtilClient.default_string(runtime.local_addr, self._local_addr),
            'httpProxy': UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            'httpsProxy': UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            'noProxy': UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            'socks5Proxy': UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            'socks5NetWork': UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            'maxIdleConns': UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            'retry': {
                'retryable': runtime.autoretry,
                'maxAttempts': UtilClient.default_number(runtime.max_attempts, 3)
            },
            'backoff': {
                'policy': UtilClient.default_string(runtime.backoff_policy, 'no'),
                'period': UtilClient.default_number(runtime.backoff_period, 1)
            },
            'ignoreSSL': runtime.ignore_ssl
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
                access_key_id = await self._credential.get_access_key_id_async()
                access_key_secret = await self._credential.get_access_key_secret_async()
                token = await self._credential.get_security_token_async()
                _request.protocol = self._protocol
                _request.method = 'PUT'
                _request.pathname = f'/{request.object_name}?symlink'
                _request.headers = TeaCore.merge({
                    'host': OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    'date': UtilClient.get_date_utcstring(),
                    'user-agent': self.get_user_agent()
                }, UtilClient.stringify_map_value(TeaCore.to_map(request.header)))
                if not UtilClient.empty(token):
                    _request.headers['x-oss-security-token'] = token
                _request.headers['authorization'] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = await TeaCore.async_do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = await UtilClient.read_as_string_async(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        'code': resp_map.get('Code'),
                        'message': resp_map.get('Message'),
                        'data': {
                            'httpCode': _response.status_code,
                            'requestId': resp_map.get('RequestId'),
                            'hostId': resp_map.get('HostId')
                        }
                    })
                return oss_models.PutSymlinkResponse().from_map(
                    TeaCore.merge(_response.headers)
                )
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def get_bucket_referer(
        self,
        request: oss_models.GetBucketRefererRequest,
        runtime: ossutil_models.RuntimeOptions,
    ) -> oss_models.GetBucketRefererResponse:
        request.validate()
        runtime.validate()
        _runtime = {
            'timeouted': 'retry',
            'readTimeout': UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            'connectTimeout': UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            'localAddr': UtilClient.default_string(runtime.local_addr, self._local_addr),
            'httpProxy': UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            'httpsProxy': UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            'noProxy': UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            'socks5Proxy': UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            'socks5NetWork': UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            'maxIdleConns': UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            'retry': {
                'retryable': runtime.autoretry,
                'maxAttempts': UtilClient.default_number(runtime.max_attempts, 3)
            },
            'backoff': {
                'policy': UtilClient.default_string(runtime.backoff_policy, 'no'),
                'period': UtilClient.default_number(runtime.backoff_period, 1)
            },
            'ignoreSSL': runtime.ignore_ssl
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
                _request.method = 'GET'
                _request.pathname = f'/?referer'
                _request.headers = {
                    'host': OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    'date': UtilClient.get_date_utcstring(),
                    'user-agent': self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers['x-oss-security-token'] = token
                _request.headers['authorization'] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = UtilClient.read_as_string(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        'code': resp_map.get('Code'),
                        'message': resp_map.get('Message'),
                        'data': {
                            'httpCode': _response.status_code,
                            'requestId': resp_map.get('RequestId'),
                            'hostId': resp_map.get('HostId')
                        }
                    })
                body_str = UtilClient.read_as_string(_response.body)
                resp_map = XMLClient.parse_xml(body_str, oss_models.GetBucketRefererResponse())
                return oss_models.GetBucketRefererResponse().from_map(
                    TeaCore.merge({
                        'RefererConfiguration': resp_map.get('RefererConfiguration')
                    }, _response.headers)
                )
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    async def get_bucket_referer_async(
        self,
        request: oss_models.GetBucketRefererRequest,
        runtime: ossutil_models.RuntimeOptions,
    ) -> oss_models.GetBucketRefererResponse:
        request.validate()
        runtime.validate()
        _runtime = {
            'timeouted': 'retry',
            'readTimeout': UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            'connectTimeout': UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            'localAddr': UtilClient.default_string(runtime.local_addr, self._local_addr),
            'httpProxy': UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            'httpsProxy': UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            'noProxy': UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            'socks5Proxy': UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            'socks5NetWork': UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            'maxIdleConns': UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            'retry': {
                'retryable': runtime.autoretry,
                'maxAttempts': UtilClient.default_number(runtime.max_attempts, 3)
            },
            'backoff': {
                'policy': UtilClient.default_string(runtime.backoff_policy, 'no'),
                'period': UtilClient.default_number(runtime.backoff_period, 1)
            },
            'ignoreSSL': runtime.ignore_ssl
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
                access_key_id = await self._credential.get_access_key_id_async()
                access_key_secret = await self._credential.get_access_key_secret_async()
                token = await self._credential.get_security_token_async()
                _request.protocol = self._protocol
                _request.method = 'GET'
                _request.pathname = f'/?referer'
                _request.headers = {
                    'host': OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    'date': UtilClient.get_date_utcstring(),
                    'user-agent': self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers['x-oss-security-token'] = token
                _request.headers['authorization'] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = await TeaCore.async_do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = await UtilClient.read_as_string_async(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        'code': resp_map.get('Code'),
                        'message': resp_map.get('Message'),
                        'data': {
                            'httpCode': _response.status_code,
                            'requestId': resp_map.get('RequestId'),
                            'hostId': resp_map.get('HostId')
                        }
                    })
                body_str = await UtilClient.read_as_string_async(_response.body)
                resp_map = XMLClient.parse_xml(body_str, oss_models.GetBucketRefererResponse())
                return oss_models.GetBucketRefererResponse().from_map(
                    TeaCore.merge({
                        'RefererConfiguration': resp_map.get('RefererConfiguration')
                    }, _response.headers)
                )
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def callback(
        self,
        request: oss_models.CallbackRequest,
        runtime: ossutil_models.RuntimeOptions,
    ) -> oss_models.CallbackResponse:
        request.validate()
        runtime.validate()
        _runtime = {
            'timeouted': 'retry',
            'readTimeout': UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            'connectTimeout': UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            'localAddr': UtilClient.default_string(runtime.local_addr, self._local_addr),
            'httpProxy': UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            'httpsProxy': UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            'noProxy': UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            'socks5Proxy': UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            'socks5NetWork': UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            'maxIdleConns': UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            'retry': {
                'retryable': runtime.autoretry,
                'maxAttempts': UtilClient.default_number(runtime.max_attempts, 3)
            },
            'backoff': {
                'policy': UtilClient.default_string(runtime.backoff_policy, 'no'),
                'period': UtilClient.default_number(runtime.backoff_period, 1)
            },
            'ignoreSSL': runtime.ignore_ssl
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
                _request.method = 'GET'
                _request.pathname = f'/'
                _request.headers = {
                    'host': OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    'date': UtilClient.get_date_utcstring(),
                    'user-agent': self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers['x-oss-security-token'] = token
                _request.headers['authorization'] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = UtilClient.read_as_string(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        'code': resp_map.get('Code'),
                        'message': resp_map.get('Message'),
                        'data': {
                            'httpCode': _response.status_code,
                            'requestId': resp_map.get('RequestId'),
                            'hostId': resp_map.get('HostId')
                        }
                    })
                return oss_models.CallbackResponse().from_map(
                    TeaCore.merge(_response.headers)
                )
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    async def callback_async(
        self,
        request: oss_models.CallbackRequest,
        runtime: ossutil_models.RuntimeOptions,
    ) -> oss_models.CallbackResponse:
        request.validate()
        runtime.validate()
        _runtime = {
            'timeouted': 'retry',
            'readTimeout': UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            'connectTimeout': UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            'localAddr': UtilClient.default_string(runtime.local_addr, self._local_addr),
            'httpProxy': UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            'httpsProxy': UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            'noProxy': UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            'socks5Proxy': UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            'socks5NetWork': UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            'maxIdleConns': UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            'retry': {
                'retryable': runtime.autoretry,
                'maxAttempts': UtilClient.default_number(runtime.max_attempts, 3)
            },
            'backoff': {
                'policy': UtilClient.default_string(runtime.backoff_policy, 'no'),
                'period': UtilClient.default_number(runtime.backoff_period, 1)
            },
            'ignoreSSL': runtime.ignore_ssl
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
                access_key_id = await self._credential.get_access_key_id_async()
                access_key_secret = await self._credential.get_access_key_secret_async()
                token = await self._credential.get_security_token_async()
                _request.protocol = self._protocol
                _request.method = 'GET'
                _request.pathname = f'/'
                _request.headers = {
                    'host': OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    'date': UtilClient.get_date_utcstring(),
                    'user-agent': self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers['x-oss-security-token'] = token
                _request.headers['authorization'] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = await TeaCore.async_do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = await UtilClient.read_as_string_async(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        'code': resp_map.get('Code'),
                        'message': resp_map.get('Message'),
                        'data': {
                            'httpCode': _response.status_code,
                            'requestId': resp_map.get('RequestId'),
                            'hostId': resp_map.get('HostId')
                        }
                    })
                return oss_models.CallbackResponse().from_map(
                    TeaCore.merge(_response.headers)
                )
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def get_bucket_logging(
        self,
        request: oss_models.GetBucketLoggingRequest,
        runtime: ossutil_models.RuntimeOptions,
    ) -> oss_models.GetBucketLoggingResponse:
        request.validate()
        runtime.validate()
        _runtime = {
            'timeouted': 'retry',
            'readTimeout': UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            'connectTimeout': UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            'localAddr': UtilClient.default_string(runtime.local_addr, self._local_addr),
            'httpProxy': UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            'httpsProxy': UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            'noProxy': UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            'socks5Proxy': UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            'socks5NetWork': UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            'maxIdleConns': UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            'retry': {
                'retryable': runtime.autoretry,
                'maxAttempts': UtilClient.default_number(runtime.max_attempts, 3)
            },
            'backoff': {
                'policy': UtilClient.default_string(runtime.backoff_policy, 'no'),
                'period': UtilClient.default_number(runtime.backoff_period, 1)
            },
            'ignoreSSL': runtime.ignore_ssl
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
                _request.method = 'GET'
                _request.pathname = f'/?logging'
                _request.headers = {
                    'host': OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    'date': UtilClient.get_date_utcstring(),
                    'user-agent': self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers['x-oss-security-token'] = token
                _request.headers['authorization'] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = UtilClient.read_as_string(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        'code': resp_map.get('Code'),
                        'message': resp_map.get('Message'),
                        'data': {
                            'httpCode': _response.status_code,
                            'requestId': resp_map.get('RequestId'),
                            'hostId': resp_map.get('HostId')
                        }
                    })
                body_str = UtilClient.read_as_string(_response.body)
                resp_map = XMLClient.parse_xml(body_str, oss_models.GetBucketLoggingResponse())
                return oss_models.GetBucketLoggingResponse().from_map(
                    TeaCore.merge({
                        'BucketLoggingStatus': resp_map.get('BucketLoggingStatus')
                    }, _response.headers)
                )
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    async def get_bucket_logging_async(
        self,
        request: oss_models.GetBucketLoggingRequest,
        runtime: ossutil_models.RuntimeOptions,
    ) -> oss_models.GetBucketLoggingResponse:
        request.validate()
        runtime.validate()
        _runtime = {
            'timeouted': 'retry',
            'readTimeout': UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            'connectTimeout': UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            'localAddr': UtilClient.default_string(runtime.local_addr, self._local_addr),
            'httpProxy': UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            'httpsProxy': UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            'noProxy': UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            'socks5Proxy': UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            'socks5NetWork': UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            'maxIdleConns': UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            'retry': {
                'retryable': runtime.autoretry,
                'maxAttempts': UtilClient.default_number(runtime.max_attempts, 3)
            },
            'backoff': {
                'policy': UtilClient.default_string(runtime.backoff_policy, 'no'),
                'period': UtilClient.default_number(runtime.backoff_period, 1)
            },
            'ignoreSSL': runtime.ignore_ssl
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
                access_key_id = await self._credential.get_access_key_id_async()
                access_key_secret = await self._credential.get_access_key_secret_async()
                token = await self._credential.get_security_token_async()
                _request.protocol = self._protocol
                _request.method = 'GET'
                _request.pathname = f'/?logging'
                _request.headers = {
                    'host': OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    'date': UtilClient.get_date_utcstring(),
                    'user-agent': self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers['x-oss-security-token'] = token
                _request.headers['authorization'] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = await TeaCore.async_do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = await UtilClient.read_as_string_async(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        'code': resp_map.get('Code'),
                        'message': resp_map.get('Message'),
                        'data': {
                            'httpCode': _response.status_code,
                            'requestId': resp_map.get('RequestId'),
                            'hostId': resp_map.get('HostId')
                        }
                    })
                body_str = await UtilClient.read_as_string_async(_response.body)
                resp_map = XMLClient.parse_xml(body_str, oss_models.GetBucketLoggingResponse())
                return oss_models.GetBucketLoggingResponse().from_map(
                    TeaCore.merge({
                        'BucketLoggingStatus': resp_map.get('BucketLoggingStatus')
                    }, _response.headers)
                )
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def put_object_acl(
        self,
        request: oss_models.PutObjectAclRequest,
        runtime: ossutil_models.RuntimeOptions,
    ) -> oss_models.PutObjectAclResponse:
        request.validate()
        runtime.validate()
        _runtime = {
            'timeouted': 'retry',
            'readTimeout': UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            'connectTimeout': UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            'localAddr': UtilClient.default_string(runtime.local_addr, self._local_addr),
            'httpProxy': UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            'httpsProxy': UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            'noProxy': UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            'socks5Proxy': UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            'socks5NetWork': UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            'maxIdleConns': UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            'retry': {
                'retryable': runtime.autoretry,
                'maxAttempts': UtilClient.default_number(runtime.max_attempts, 3)
            },
            'backoff': {
                'policy': UtilClient.default_string(runtime.backoff_policy, 'no'),
                'period': UtilClient.default_number(runtime.backoff_period, 1)
            },
            'ignoreSSL': runtime.ignore_ssl
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
                _request.method = 'PUT'
                _request.pathname = f'/{request.object_name}?acl'
                _request.headers = TeaCore.merge({
                    'host': OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    'date': UtilClient.get_date_utcstring(),
                    'user-agent': self.get_user_agent()
                }, UtilClient.stringify_map_value(TeaCore.to_map(request.header)))
                if not UtilClient.empty(token):
                    _request.headers['x-oss-security-token'] = token
                _request.headers['authorization'] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = UtilClient.read_as_string(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        'code': resp_map.get('Code'),
                        'message': resp_map.get('Message'),
                        'data': {
                            'httpCode': _response.status_code,
                            'requestId': resp_map.get('RequestId'),
                            'hostId': resp_map.get('HostId')
                        }
                    })
                return oss_models.PutObjectAclResponse().from_map(
                    TeaCore.merge(_response.headers)
                )
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    async def put_object_acl_async(
        self,
        request: oss_models.PutObjectAclRequest,
        runtime: ossutil_models.RuntimeOptions,
    ) -> oss_models.PutObjectAclResponse:
        request.validate()
        runtime.validate()
        _runtime = {
            'timeouted': 'retry',
            'readTimeout': UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            'connectTimeout': UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            'localAddr': UtilClient.default_string(runtime.local_addr, self._local_addr),
            'httpProxy': UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            'httpsProxy': UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            'noProxy': UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            'socks5Proxy': UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            'socks5NetWork': UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            'maxIdleConns': UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            'retry': {
                'retryable': runtime.autoretry,
                'maxAttempts': UtilClient.default_number(runtime.max_attempts, 3)
            },
            'backoff': {
                'policy': UtilClient.default_string(runtime.backoff_policy, 'no'),
                'period': UtilClient.default_number(runtime.backoff_period, 1)
            },
            'ignoreSSL': runtime.ignore_ssl
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
                access_key_id = await self._credential.get_access_key_id_async()
                access_key_secret = await self._credential.get_access_key_secret_async()
                token = await self._credential.get_security_token_async()
                _request.protocol = self._protocol
                _request.method = 'PUT'
                _request.pathname = f'/{request.object_name}?acl'
                _request.headers = TeaCore.merge({
                    'host': OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    'date': UtilClient.get_date_utcstring(),
                    'user-agent': self.get_user_agent()
                }, UtilClient.stringify_map_value(TeaCore.to_map(request.header)))
                if not UtilClient.empty(token):
                    _request.headers['x-oss-security-token'] = token
                _request.headers['authorization'] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = await TeaCore.async_do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = await UtilClient.read_as_string_async(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        'code': resp_map.get('Code'),
                        'message': resp_map.get('Message'),
                        'data': {
                            'httpCode': _response.status_code,
                            'requestId': resp_map.get('RequestId'),
                            'hostId': resp_map.get('HostId')
                        }
                    })
                return oss_models.PutObjectAclResponse().from_map(
                    TeaCore.merge(_response.headers)
                )
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def get_bucket_info(
        self,
        request: oss_models.GetBucketInfoRequest,
        runtime: ossutil_models.RuntimeOptions,
    ) -> oss_models.GetBucketInfoResponse:
        request.validate()
        runtime.validate()
        _runtime = {
            'timeouted': 'retry',
            'readTimeout': UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            'connectTimeout': UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            'localAddr': UtilClient.default_string(runtime.local_addr, self._local_addr),
            'httpProxy': UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            'httpsProxy': UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            'noProxy': UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            'socks5Proxy': UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            'socks5NetWork': UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            'maxIdleConns': UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            'retry': {
                'retryable': runtime.autoretry,
                'maxAttempts': UtilClient.default_number(runtime.max_attempts, 3)
            },
            'backoff': {
                'policy': UtilClient.default_string(runtime.backoff_policy, 'no'),
                'period': UtilClient.default_number(runtime.backoff_period, 1)
            },
            'ignoreSSL': runtime.ignore_ssl
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
                _request.method = 'GET'
                _request.pathname = f'/?bucketInfo'
                _request.headers = {
                    'host': OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    'date': UtilClient.get_date_utcstring(),
                    'user-agent': self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers['x-oss-security-token'] = token
                _request.headers['authorization'] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = UtilClient.read_as_string(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        'code': resp_map.get('Code'),
                        'message': resp_map.get('Message'),
                        'data': {
                            'httpCode': _response.status_code,
                            'requestId': resp_map.get('RequestId'),
                            'hostId': resp_map.get('HostId')
                        }
                    })
                body_str = UtilClient.read_as_string(_response.body)
                resp_map = XMLClient.parse_xml(body_str, oss_models.GetBucketInfoResponse())
                return oss_models.GetBucketInfoResponse().from_map(
                    TeaCore.merge({
                        'BucketInfo': resp_map.get('BucketInfo')
                    }, _response.headers)
                )
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    async def get_bucket_info_async(
        self,
        request: oss_models.GetBucketInfoRequest,
        runtime: ossutil_models.RuntimeOptions,
    ) -> oss_models.GetBucketInfoResponse:
        request.validate()
        runtime.validate()
        _runtime = {
            'timeouted': 'retry',
            'readTimeout': UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            'connectTimeout': UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            'localAddr': UtilClient.default_string(runtime.local_addr, self._local_addr),
            'httpProxy': UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            'httpsProxy': UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            'noProxy': UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            'socks5Proxy': UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            'socks5NetWork': UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            'maxIdleConns': UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            'retry': {
                'retryable': runtime.autoretry,
                'maxAttempts': UtilClient.default_number(runtime.max_attempts, 3)
            },
            'backoff': {
                'policy': UtilClient.default_string(runtime.backoff_policy, 'no'),
                'period': UtilClient.default_number(runtime.backoff_period, 1)
            },
            'ignoreSSL': runtime.ignore_ssl
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
                access_key_id = await self._credential.get_access_key_id_async()
                access_key_secret = await self._credential.get_access_key_secret_async()
                token = await self._credential.get_security_token_async()
                _request.protocol = self._protocol
                _request.method = 'GET'
                _request.pathname = f'/?bucketInfo'
                _request.headers = {
                    'host': OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    'date': UtilClient.get_date_utcstring(),
                    'user-agent': self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers['x-oss-security-token'] = token
                _request.headers['authorization'] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = await TeaCore.async_do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = await UtilClient.read_as_string_async(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        'code': resp_map.get('Code'),
                        'message': resp_map.get('Message'),
                        'data': {
                            'httpCode': _response.status_code,
                            'requestId': resp_map.get('RequestId'),
                            'hostId': resp_map.get('HostId')
                        }
                    })
                body_str = await UtilClient.read_as_string_async(_response.body)
                resp_map = XMLClient.parse_xml(body_str, oss_models.GetBucketInfoResponse())
                return oss_models.GetBucketInfoResponse().from_map(
                    TeaCore.merge({
                        'BucketInfo': resp_map.get('BucketInfo')
                    }, _response.headers)
                )
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def put_live_channel_status(
        self,
        request: oss_models.PutLiveChannelStatusRequest,
        runtime: ossutil_models.RuntimeOptions,
    ) -> oss_models.PutLiveChannelStatusResponse:
        request.validate()
        runtime.validate()
        _runtime = {
            'timeouted': 'retry',
            'readTimeout': UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            'connectTimeout': UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            'localAddr': UtilClient.default_string(runtime.local_addr, self._local_addr),
            'httpProxy': UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            'httpsProxy': UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            'noProxy': UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            'socks5Proxy': UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            'socks5NetWork': UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            'maxIdleConns': UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            'retry': {
                'retryable': runtime.autoretry,
                'maxAttempts': UtilClient.default_number(runtime.max_attempts, 3)
            },
            'backoff': {
                'policy': UtilClient.default_string(runtime.backoff_policy, 'no'),
                'period': UtilClient.default_number(runtime.backoff_period, 1)
            },
            'ignoreSSL': runtime.ignore_ssl
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
                _request.method = 'PUT'
                _request.pathname = f'/{request.channel_name}?live'
                _request.headers = {
                    'host': OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    'date': UtilClient.get_date_utcstring(),
                    'user-agent': self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers['x-oss-security-token'] = token
                _request.query = UtilClient.stringify_map_value(TeaCore.to_map(request.filter))
                _request.headers['authorization'] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = UtilClient.read_as_string(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        'code': resp_map.get('Code'),
                        'message': resp_map.get('Message'),
                        'data': {
                            'httpCode': _response.status_code,
                            'requestId': resp_map.get('RequestId'),
                            'hostId': resp_map.get('HostId')
                        }
                    })
                return oss_models.PutLiveChannelStatusResponse().from_map(
                    TeaCore.merge(_response.headers)
                )
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    async def put_live_channel_status_async(
        self,
        request: oss_models.PutLiveChannelStatusRequest,
        runtime: ossutil_models.RuntimeOptions,
    ) -> oss_models.PutLiveChannelStatusResponse:
        request.validate()
        runtime.validate()
        _runtime = {
            'timeouted': 'retry',
            'readTimeout': UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            'connectTimeout': UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            'localAddr': UtilClient.default_string(runtime.local_addr, self._local_addr),
            'httpProxy': UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            'httpsProxy': UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            'noProxy': UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            'socks5Proxy': UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            'socks5NetWork': UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            'maxIdleConns': UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            'retry': {
                'retryable': runtime.autoretry,
                'maxAttempts': UtilClient.default_number(runtime.max_attempts, 3)
            },
            'backoff': {
                'policy': UtilClient.default_string(runtime.backoff_policy, 'no'),
                'period': UtilClient.default_number(runtime.backoff_period, 1)
            },
            'ignoreSSL': runtime.ignore_ssl
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
                access_key_id = await self._credential.get_access_key_id_async()
                access_key_secret = await self._credential.get_access_key_secret_async()
                token = await self._credential.get_security_token_async()
                _request.protocol = self._protocol
                _request.method = 'PUT'
                _request.pathname = f'/{request.channel_name}?live'
                _request.headers = {
                    'host': OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    'date': UtilClient.get_date_utcstring(),
                    'user-agent': self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers['x-oss-security-token'] = token
                _request.query = UtilClient.stringify_map_value(TeaCore.to_map(request.filter))
                _request.headers['authorization'] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = await TeaCore.async_do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = await UtilClient.read_as_string_async(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        'code': resp_map.get('Code'),
                        'message': resp_map.get('Message'),
                        'data': {
                            'httpCode': _response.status_code,
                            'requestId': resp_map.get('RequestId'),
                            'hostId': resp_map.get('HostId')
                        }
                    })
                return oss_models.PutLiveChannelStatusResponse().from_map(
                    TeaCore.merge(_response.headers)
                )
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def initiate_multipart_upload(
        self,
        request: oss_models.InitiateMultipartUploadRequest,
        runtime: ossutil_models.RuntimeOptions,
    ) -> oss_models.InitiateMultipartUploadResponse:
        request.validate()
        runtime.validate()
        _runtime = {
            'timeouted': 'retry',
            'readTimeout': UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            'connectTimeout': UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            'localAddr': UtilClient.default_string(runtime.local_addr, self._local_addr),
            'httpProxy': UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            'httpsProxy': UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            'noProxy': UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            'socks5Proxy': UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            'socks5NetWork': UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            'maxIdleConns': UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            'retry': {
                'retryable': runtime.autoretry,
                'maxAttempts': UtilClient.default_number(runtime.max_attempts, 3)
            },
            'backoff': {
                'policy': UtilClient.default_string(runtime.backoff_policy, 'no'),
                'period': UtilClient.default_number(runtime.backoff_period, 1)
            },
            'ignoreSSL': runtime.ignore_ssl
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
                _request.method = 'POST'
                _request.pathname = f'/{request.object_name}?uploads'
                _request.headers = TeaCore.merge({
                    'host': OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    'date': UtilClient.get_date_utcstring(),
                    'user-agent': self.get_user_agent()
                }, UtilClient.stringify_map_value(TeaCore.to_map(request.header)))
                if not UtilClient.empty(token):
                    _request.headers['x-oss-security-token'] = token
                _request.query = UtilClient.stringify_map_value(TeaCore.to_map(request.filter))
                if not UtilClient.is_unset(request.header) and not UtilClient.empty(request.header.content_type):
                    _request.headers['content-type'] = request.header.content_type
                else:
                    _request.headers['content-type'] = OSSUtilClient.get_content_type(request.object_name)
                _request.headers['authorization'] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = UtilClient.read_as_string(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        'code': resp_map.get('Code'),
                        'message': resp_map.get('Message'),
                        'data': {
                            'httpCode': _response.status_code,
                            'requestId': resp_map.get('RequestId'),
                            'hostId': resp_map.get('HostId')
                        }
                    })
                body_str = UtilClient.read_as_string(_response.body)
                resp_map = XMLClient.parse_xml(body_str, oss_models.InitiateMultipartUploadResponse())
                return oss_models.InitiateMultipartUploadResponse().from_map(
                    TeaCore.merge({
                        'InitiateMultipartUploadResult': resp_map.get('InitiateMultipartUploadResult')
                    }, _response.headers)
                )
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    async def initiate_multipart_upload_async(
        self,
        request: oss_models.InitiateMultipartUploadRequest,
        runtime: ossutil_models.RuntimeOptions,
    ) -> oss_models.InitiateMultipartUploadResponse:
        request.validate()
        runtime.validate()
        _runtime = {
            'timeouted': 'retry',
            'readTimeout': UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            'connectTimeout': UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            'localAddr': UtilClient.default_string(runtime.local_addr, self._local_addr),
            'httpProxy': UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            'httpsProxy': UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            'noProxy': UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            'socks5Proxy': UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            'socks5NetWork': UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            'maxIdleConns': UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            'retry': {
                'retryable': runtime.autoretry,
                'maxAttempts': UtilClient.default_number(runtime.max_attempts, 3)
            },
            'backoff': {
                'policy': UtilClient.default_string(runtime.backoff_policy, 'no'),
                'period': UtilClient.default_number(runtime.backoff_period, 1)
            },
            'ignoreSSL': runtime.ignore_ssl
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
                access_key_id = await self._credential.get_access_key_id_async()
                access_key_secret = await self._credential.get_access_key_secret_async()
                token = await self._credential.get_security_token_async()
                _request.protocol = self._protocol
                _request.method = 'POST'
                _request.pathname = f'/{request.object_name}?uploads'
                _request.headers = TeaCore.merge({
                    'host': OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    'date': UtilClient.get_date_utcstring(),
                    'user-agent': self.get_user_agent()
                }, UtilClient.stringify_map_value(TeaCore.to_map(request.header)))
                if not UtilClient.empty(token):
                    _request.headers['x-oss-security-token'] = token
                _request.query = UtilClient.stringify_map_value(TeaCore.to_map(request.filter))
                if not UtilClient.is_unset(request.header) and not UtilClient.empty(request.header.content_type):
                    _request.headers['content-type'] = request.header.content_type
                else:
                    _request.headers['content-type'] = OSSUtilClient.get_content_type(request.object_name)
                _request.headers['authorization'] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = await TeaCore.async_do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = await UtilClient.read_as_string_async(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        'code': resp_map.get('Code'),
                        'message': resp_map.get('Message'),
                        'data': {
                            'httpCode': _response.status_code,
                            'requestId': resp_map.get('RequestId'),
                            'hostId': resp_map.get('HostId')
                        }
                    })
                body_str = await UtilClient.read_as_string_async(_response.body)
                resp_map = XMLClient.parse_xml(body_str, oss_models.InitiateMultipartUploadResponse())
                return oss_models.InitiateMultipartUploadResponse().from_map(
                    TeaCore.merge({
                        'InitiateMultipartUploadResult': resp_map.get('InitiateMultipartUploadResult')
                    }, _response.headers)
                )
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def option_object(
        self,
        request: oss_models.OptionObjectRequest,
        runtime: ossutil_models.RuntimeOptions,
    ) -> oss_models.OptionObjectResponse:
        request.validate()
        runtime.validate()
        _runtime = {
            'timeouted': 'retry',
            'readTimeout': UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            'connectTimeout': UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            'localAddr': UtilClient.default_string(runtime.local_addr, self._local_addr),
            'httpProxy': UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            'httpsProxy': UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            'noProxy': UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            'socks5Proxy': UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            'socks5NetWork': UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            'maxIdleConns': UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            'retry': {
                'retryable': runtime.autoretry,
                'maxAttempts': UtilClient.default_number(runtime.max_attempts, 3)
            },
            'backoff': {
                'policy': UtilClient.default_string(runtime.backoff_policy, 'no'),
                'period': UtilClient.default_number(runtime.backoff_period, 1)
            },
            'ignoreSSL': runtime.ignore_ssl
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
                _request.method = 'OPTIONS'
                _request.pathname = f'/{request.object_name}'
                _request.headers = TeaCore.merge({
                    'host': OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    'date': UtilClient.get_date_utcstring(),
                    'user-agent': self.get_user_agent()
                }, UtilClient.stringify_map_value(TeaCore.to_map(request.header)))
                if not UtilClient.empty(token):
                    _request.headers['x-oss-security-token'] = token
                _request.headers['authorization'] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = UtilClient.read_as_string(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        'code': resp_map.get('Code'),
                        'message': resp_map.get('Message'),
                        'data': {
                            'httpCode': _response.status_code,
                            'requestId': resp_map.get('RequestId'),
                            'hostId': resp_map.get('HostId')
                        }
                    })
                return oss_models.OptionObjectResponse().from_map(
                    TeaCore.merge(_response.headers)
                )
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    async def option_object_async(
        self,
        request: oss_models.OptionObjectRequest,
        runtime: ossutil_models.RuntimeOptions,
    ) -> oss_models.OptionObjectResponse:
        request.validate()
        runtime.validate()
        _runtime = {
            'timeouted': 'retry',
            'readTimeout': UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            'connectTimeout': UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            'localAddr': UtilClient.default_string(runtime.local_addr, self._local_addr),
            'httpProxy': UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            'httpsProxy': UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            'noProxy': UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            'socks5Proxy': UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            'socks5NetWork': UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            'maxIdleConns': UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            'retry': {
                'retryable': runtime.autoretry,
                'maxAttempts': UtilClient.default_number(runtime.max_attempts, 3)
            },
            'backoff': {
                'policy': UtilClient.default_string(runtime.backoff_policy, 'no'),
                'period': UtilClient.default_number(runtime.backoff_period, 1)
            },
            'ignoreSSL': runtime.ignore_ssl
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
                access_key_id = await self._credential.get_access_key_id_async()
                access_key_secret = await self._credential.get_access_key_secret_async()
                token = await self._credential.get_security_token_async()
                _request.protocol = self._protocol
                _request.method = 'OPTIONS'
                _request.pathname = f'/{request.object_name}'
                _request.headers = TeaCore.merge({
                    'host': OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    'date': UtilClient.get_date_utcstring(),
                    'user-agent': self.get_user_agent()
                }, UtilClient.stringify_map_value(TeaCore.to_map(request.header)))
                if not UtilClient.empty(token):
                    _request.headers['x-oss-security-token'] = token
                _request.headers['authorization'] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = await TeaCore.async_do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = await UtilClient.read_as_string_async(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        'code': resp_map.get('Code'),
                        'message': resp_map.get('Message'),
                        'data': {
                            'httpCode': _response.status_code,
                            'requestId': resp_map.get('RequestId'),
                            'hostId': resp_map.get('HostId')
                        }
                    })
                return oss_models.OptionObjectResponse().from_map(
                    TeaCore.merge(_response.headers)
                )
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def post_vod_playlist(
        self,
        request: oss_models.PostVodPlaylistRequest,
        runtime: ossutil_models.RuntimeOptions,
    ) -> oss_models.PostVodPlaylistResponse:
        request.validate()
        runtime.validate()
        _runtime = {
            'timeouted': 'retry',
            'readTimeout': UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            'connectTimeout': UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            'localAddr': UtilClient.default_string(runtime.local_addr, self._local_addr),
            'httpProxy': UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            'httpsProxy': UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            'noProxy': UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            'socks5Proxy': UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            'socks5NetWork': UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            'maxIdleConns': UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            'retry': {
                'retryable': runtime.autoretry,
                'maxAttempts': UtilClient.default_number(runtime.max_attempts, 3)
            },
            'backoff': {
                'policy': UtilClient.default_string(runtime.backoff_policy, 'no'),
                'period': UtilClient.default_number(runtime.backoff_period, 1)
            },
            'ignoreSSL': runtime.ignore_ssl
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
                _request.method = 'POST'
                _request.pathname = f'/{request.channel_name}/{request.playlist_name}?vod'
                _request.headers = {
                    'host': OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    'date': UtilClient.get_date_utcstring(),
                    'user-agent': self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers['x-oss-security-token'] = token
                _request.query = UtilClient.stringify_map_value(TeaCore.to_map(request.filter))
                _request.headers['authorization'] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = UtilClient.read_as_string(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        'code': resp_map.get('Code'),
                        'message': resp_map.get('Message'),
                        'data': {
                            'httpCode': _response.status_code,
                            'requestId': resp_map.get('RequestId'),
                            'hostId': resp_map.get('HostId')
                        }
                    })
                return oss_models.PostVodPlaylistResponse().from_map(
                    TeaCore.merge(_response.headers)
                )
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    async def post_vod_playlist_async(
        self,
        request: oss_models.PostVodPlaylistRequest,
        runtime: ossutil_models.RuntimeOptions,
    ) -> oss_models.PostVodPlaylistResponse:
        request.validate()
        runtime.validate()
        _runtime = {
            'timeouted': 'retry',
            'readTimeout': UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            'connectTimeout': UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            'localAddr': UtilClient.default_string(runtime.local_addr, self._local_addr),
            'httpProxy': UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            'httpsProxy': UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            'noProxy': UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            'socks5Proxy': UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            'socks5NetWork': UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            'maxIdleConns': UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            'retry': {
                'retryable': runtime.autoretry,
                'maxAttempts': UtilClient.default_number(runtime.max_attempts, 3)
            },
            'backoff': {
                'policy': UtilClient.default_string(runtime.backoff_policy, 'no'),
                'period': UtilClient.default_number(runtime.backoff_period, 1)
            },
            'ignoreSSL': runtime.ignore_ssl
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
                access_key_id = await self._credential.get_access_key_id_async()
                access_key_secret = await self._credential.get_access_key_secret_async()
                token = await self._credential.get_security_token_async()
                _request.protocol = self._protocol
                _request.method = 'POST'
                _request.pathname = f'/{request.channel_name}/{request.playlist_name}?vod'
                _request.headers = {
                    'host': OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    'date': UtilClient.get_date_utcstring(),
                    'user-agent': self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers['x-oss-security-token'] = token
                _request.query = UtilClient.stringify_map_value(TeaCore.to_map(request.filter))
                _request.headers['authorization'] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = await TeaCore.async_do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = await UtilClient.read_as_string_async(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        'code': resp_map.get('Code'),
                        'message': resp_map.get('Message'),
                        'data': {
                            'httpCode': _response.status_code,
                            'requestId': resp_map.get('RequestId'),
                            'hostId': resp_map.get('HostId')
                        }
                    })
                return oss_models.PostVodPlaylistResponse().from_map(
                    TeaCore.merge(_response.headers)
                )
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def post_object(
        self,
        request: oss_models.PostObjectRequest,
        runtime: ossutil_models.RuntimeOptions,
    ) -> oss_models.PostObjectResponse:
        request.validate()
        runtime.validate()
        _runtime = {
            'timeouted': 'retry',
            'readTimeout': UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            'connectTimeout': UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            'httpProxy': UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            'httpsProxy': UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            'noProxy': UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            'maxIdleConns': UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            'retry': {
                'retryable': runtime.autoretry,
                'maxAttempts': UtilClient.default_number(runtime.max_attempts, 3)
            },
            'backoff': {
                'policy': UtilClient.default_string(runtime.backoff_policy, 'no'),
                'period': UtilClient.default_number(runtime.backoff_period, 1)
            },
            'ignoreSSL': runtime.ignore_ssl
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
                _request.method = 'POST'
                _request.pathname = f'/'
                _request.headers = {
                    'host': OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    'date': UtilClient.get_date_utcstring(),
                    'user-agent': self.get_user_agent()
                }
                _request.headers['content-type'] = f'multipart/form-data; boundary={boundary}'
                form = TeaCore.merge({
                    'OSSAccessKeyId': request.header.access_key_id,
                    'policy': request.header.policy,
                    'Signature': request.header.signature,
                    'key': request.header.key,
                    'success_action_status': request.header.success_action_status,
                    'file': request.header.file
                }, OSSUtilClient.to_meta(request.header.user_meta, 'x-oss-meta-'))
                _request.body = FileFormClient.to_file_form(form, boundary)
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                body_str = UtilClient.read_as_string(_response.body)
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        'code': resp_map.get('Code'),
                        'message': resp_map.get('Message'),
                        'data': {
                            'httpCode': _response.status_code,
                            'requestId': resp_map.get('RequestId'),
                            'hostId': resp_map.get('HostId')
                        }
                    })
                resp_map = XMLClient.parse_xml(body_str, oss_models.PostObjectResponse())
                return oss_models.PostObjectResponse().from_map(
                    TeaCore.merge(resp_map)
                )
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    async def post_object_async(
        self,
        request: oss_models.PostObjectRequest,
        runtime: ossutil_models.RuntimeOptions,
    ) -> oss_models.PostObjectResponse:
        request.validate()
        runtime.validate()
        _runtime = {
            'timeouted': 'retry',
            'readTimeout': UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            'connectTimeout': UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            'httpProxy': UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            'httpsProxy': UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            'noProxy': UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            'maxIdleConns': UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            'retry': {
                'retryable': runtime.autoretry,
                'maxAttempts': UtilClient.default_number(runtime.max_attempts, 3)
            },
            'backoff': {
                'policy': UtilClient.default_string(runtime.backoff_policy, 'no'),
                'period': UtilClient.default_number(runtime.backoff_period, 1)
            },
            'ignoreSSL': runtime.ignore_ssl
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
                _request.method = 'POST'
                _request.pathname = f'/'
                _request.headers = {
                    'host': OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    'date': UtilClient.get_date_utcstring(),
                    'user-agent': self.get_user_agent()
                }
                _request.headers['content-type'] = f'multipart/form-data; boundary={boundary}'
                form = TeaCore.merge({
                    'OSSAccessKeyId': request.header.access_key_id,
                    'policy': request.header.policy,
                    'Signature': request.header.signature,
                    'key': request.header.key,
                    'success_action_status': request.header.success_action_status,
                    'file': request.header.file
                }, OSSUtilClient.to_meta(request.header.user_meta, 'x-oss-meta-'))
                _request.body = FileFormClient.to_file_form(form, boundary)
                _last_request = _request
                _response = await TeaCore.async_do_action(_request, _runtime)
                resp_map = None
                body_str = await UtilClient.read_as_string_async(_response.body)
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        'code': resp_map.get('Code'),
                        'message': resp_map.get('Message'),
                        'data': {
                            'httpCode': _response.status_code,
                            'requestId': resp_map.get('RequestId'),
                            'hostId': resp_map.get('HostId')
                        }
                    })
                resp_map = XMLClient.parse_xml(body_str, oss_models.PostObjectResponse())
                return oss_models.PostObjectResponse().from_map(
                    TeaCore.merge(resp_map)
                )
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def head_object(
        self,
        request: oss_models.HeadObjectRequest,
        runtime: ossutil_models.RuntimeOptions,
    ) -> oss_models.HeadObjectResponse:
        request.validate()
        runtime.validate()
        _runtime = {
            'timeouted': 'retry',
            'readTimeout': UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            'connectTimeout': UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            'localAddr': UtilClient.default_string(runtime.local_addr, self._local_addr),
            'httpProxy': UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            'httpsProxy': UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            'noProxy': UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            'socks5Proxy': UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            'socks5NetWork': UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            'maxIdleConns': UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            'retry': {
                'retryable': runtime.autoretry,
                'maxAttempts': UtilClient.default_number(runtime.max_attempts, 3)
            },
            'backoff': {
                'policy': UtilClient.default_string(runtime.backoff_policy, 'no'),
                'period': UtilClient.default_number(runtime.backoff_period, 1)
            },
            'ignoreSSL': runtime.ignore_ssl
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
                _request.method = 'HEAD'
                _request.pathname = f'/{request.object_name}'
                _request.headers = TeaCore.merge({
                    'host': OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    'date': UtilClient.get_date_utcstring(),
                    'user-agent': self.get_user_agent()
                }, UtilClient.stringify_map_value(TeaCore.to_map(request.header)))
                if not UtilClient.empty(token):
                    _request.headers['x-oss-security-token'] = token
                _request.headers['authorization'] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = UtilClient.read_as_string(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        'code': resp_map.get('Code'),
                        'message': resp_map.get('Message'),
                        'data': {
                            'httpCode': _response.status_code,
                            'requestId': resp_map.get('RequestId'),
                            'hostId': resp_map.get('HostId')
                        }
                    })
                return oss_models.HeadObjectResponse().from_map(
                    TeaCore.merge({
                        'usermeta': OSSUtilClient.to_meta(_response.headers, 'x-oss-meta-')
                    }, _response.headers)
                )
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    async def head_object_async(
        self,
        request: oss_models.HeadObjectRequest,
        runtime: ossutil_models.RuntimeOptions,
    ) -> oss_models.HeadObjectResponse:
        request.validate()
        runtime.validate()
        _runtime = {
            'timeouted': 'retry',
            'readTimeout': UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            'connectTimeout': UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            'localAddr': UtilClient.default_string(runtime.local_addr, self._local_addr),
            'httpProxy': UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            'httpsProxy': UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            'noProxy': UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            'socks5Proxy': UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            'socks5NetWork': UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            'maxIdleConns': UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            'retry': {
                'retryable': runtime.autoretry,
                'maxAttempts': UtilClient.default_number(runtime.max_attempts, 3)
            },
            'backoff': {
                'policy': UtilClient.default_string(runtime.backoff_policy, 'no'),
                'period': UtilClient.default_number(runtime.backoff_period, 1)
            },
            'ignoreSSL': runtime.ignore_ssl
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
                access_key_id = await self._credential.get_access_key_id_async()
                access_key_secret = await self._credential.get_access_key_secret_async()
                token = await self._credential.get_security_token_async()
                _request.protocol = self._protocol
                _request.method = 'HEAD'
                _request.pathname = f'/{request.object_name}'
                _request.headers = TeaCore.merge({
                    'host': OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    'date': UtilClient.get_date_utcstring(),
                    'user-agent': self.get_user_agent()
                }, UtilClient.stringify_map_value(TeaCore.to_map(request.header)))
                if not UtilClient.empty(token):
                    _request.headers['x-oss-security-token'] = token
                _request.headers['authorization'] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = await TeaCore.async_do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = await UtilClient.read_as_string_async(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        'code': resp_map.get('Code'),
                        'message': resp_map.get('Message'),
                        'data': {
                            'httpCode': _response.status_code,
                            'requestId': resp_map.get('RequestId'),
                            'hostId': resp_map.get('HostId')
                        }
                    })
                return oss_models.HeadObjectResponse().from_map(
                    TeaCore.merge({
                        'usermeta': OSSUtilClient.to_meta(_response.headers, 'x-oss-meta-')
                    }, _response.headers)
                )
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def delete_object_tagging(
        self,
        request: oss_models.DeleteObjectTaggingRequest,
        runtime: ossutil_models.RuntimeOptions,
    ) -> oss_models.DeleteObjectTaggingResponse:
        request.validate()
        runtime.validate()
        _runtime = {
            'timeouted': 'retry',
            'readTimeout': UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            'connectTimeout': UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            'localAddr': UtilClient.default_string(runtime.local_addr, self._local_addr),
            'httpProxy': UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            'httpsProxy': UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            'noProxy': UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            'socks5Proxy': UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            'socks5NetWork': UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            'maxIdleConns': UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            'retry': {
                'retryable': runtime.autoretry,
                'maxAttempts': UtilClient.default_number(runtime.max_attempts, 3)
            },
            'backoff': {
                'policy': UtilClient.default_string(runtime.backoff_policy, 'no'),
                'period': UtilClient.default_number(runtime.backoff_period, 1)
            },
            'ignoreSSL': runtime.ignore_ssl
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
                _request.method = 'DELETE'
                _request.pathname = f'/{request.object_name}?tagging'
                _request.headers = {
                    'host': OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    'date': UtilClient.get_date_utcstring(),
                    'user-agent': self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers['x-oss-security-token'] = token
                _request.headers['authorization'] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = UtilClient.read_as_string(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        'code': resp_map.get('Code'),
                        'message': resp_map.get('Message'),
                        'data': {
                            'httpCode': _response.status_code,
                            'requestId': resp_map.get('RequestId'),
                            'hostId': resp_map.get('HostId')
                        }
                    })
                return oss_models.DeleteObjectTaggingResponse().from_map(
                    TeaCore.merge(_response.headers)
                )
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    async def delete_object_tagging_async(
        self,
        request: oss_models.DeleteObjectTaggingRequest,
        runtime: ossutil_models.RuntimeOptions,
    ) -> oss_models.DeleteObjectTaggingResponse:
        request.validate()
        runtime.validate()
        _runtime = {
            'timeouted': 'retry',
            'readTimeout': UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            'connectTimeout': UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            'localAddr': UtilClient.default_string(runtime.local_addr, self._local_addr),
            'httpProxy': UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            'httpsProxy': UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            'noProxy': UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            'socks5Proxy': UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            'socks5NetWork': UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            'maxIdleConns': UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            'retry': {
                'retryable': runtime.autoretry,
                'maxAttempts': UtilClient.default_number(runtime.max_attempts, 3)
            },
            'backoff': {
                'policy': UtilClient.default_string(runtime.backoff_policy, 'no'),
                'period': UtilClient.default_number(runtime.backoff_period, 1)
            },
            'ignoreSSL': runtime.ignore_ssl
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
                access_key_id = await self._credential.get_access_key_id_async()
                access_key_secret = await self._credential.get_access_key_secret_async()
                token = await self._credential.get_security_token_async()
                _request.protocol = self._protocol
                _request.method = 'DELETE'
                _request.pathname = f'/{request.object_name}?tagging'
                _request.headers = {
                    'host': OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    'date': UtilClient.get_date_utcstring(),
                    'user-agent': self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers['x-oss-security-token'] = token
                _request.headers['authorization'] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = await TeaCore.async_do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = await UtilClient.read_as_string_async(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        'code': resp_map.get('Code'),
                        'message': resp_map.get('Message'),
                        'data': {
                            'httpCode': _response.status_code,
                            'requestId': resp_map.get('RequestId'),
                            'hostId': resp_map.get('HostId')
                        }
                    })
                return oss_models.DeleteObjectTaggingResponse().from_map(
                    TeaCore.merge(_response.headers)
                )
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def restore_object(
        self,
        request: oss_models.RestoreObjectRequest,
        runtime: ossutil_models.RuntimeOptions,
    ) -> oss_models.RestoreObjectResponse:
        request.validate()
        runtime.validate()
        _runtime = {
            'timeouted': 'retry',
            'readTimeout': UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            'connectTimeout': UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            'localAddr': UtilClient.default_string(runtime.local_addr, self._local_addr),
            'httpProxy': UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            'httpsProxy': UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            'noProxy': UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            'socks5Proxy': UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            'socks5NetWork': UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            'maxIdleConns': UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            'retry': {
                'retryable': runtime.autoretry,
                'maxAttempts': UtilClient.default_number(runtime.max_attempts, 3)
            },
            'backoff': {
                'policy': UtilClient.default_string(runtime.backoff_policy, 'no'),
                'period': UtilClient.default_number(runtime.backoff_period, 1)
            },
            'ignoreSSL': runtime.ignore_ssl
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
                _request.method = 'POST'
                _request.pathname = f'/{request.object_name}?restore'
                _request.headers = {
                    'host': OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    'date': UtilClient.get_date_utcstring(),
                    'user-agent': self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers['x-oss-security-token'] = token
                _request.headers['authorization'] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = UtilClient.read_as_string(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        'code': resp_map.get('Code'),
                        'message': resp_map.get('Message'),
                        'data': {
                            'httpCode': _response.status_code,
                            'requestId': resp_map.get('RequestId'),
                            'hostId': resp_map.get('HostId')
                        }
                    })
                return oss_models.RestoreObjectResponse().from_map(
                    TeaCore.merge(_response.headers)
                )
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    async def restore_object_async(
        self,
        request: oss_models.RestoreObjectRequest,
        runtime: ossutil_models.RuntimeOptions,
    ) -> oss_models.RestoreObjectResponse:
        request.validate()
        runtime.validate()
        _runtime = {
            'timeouted': 'retry',
            'readTimeout': UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            'connectTimeout': UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            'localAddr': UtilClient.default_string(runtime.local_addr, self._local_addr),
            'httpProxy': UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            'httpsProxy': UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            'noProxy': UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            'socks5Proxy': UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            'socks5NetWork': UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            'maxIdleConns': UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            'retry': {
                'retryable': runtime.autoretry,
                'maxAttempts': UtilClient.default_number(runtime.max_attempts, 3)
            },
            'backoff': {
                'policy': UtilClient.default_string(runtime.backoff_policy, 'no'),
                'period': UtilClient.default_number(runtime.backoff_period, 1)
            },
            'ignoreSSL': runtime.ignore_ssl
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
                access_key_id = await self._credential.get_access_key_id_async()
                access_key_secret = await self._credential.get_access_key_secret_async()
                token = await self._credential.get_security_token_async()
                _request.protocol = self._protocol
                _request.method = 'POST'
                _request.pathname = f'/{request.object_name}?restore'
                _request.headers = {
                    'host': OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    'date': UtilClient.get_date_utcstring(),
                    'user-agent': self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers['x-oss-security-token'] = token
                _request.headers['authorization'] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = await TeaCore.async_do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = await UtilClient.read_as_string_async(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        'code': resp_map.get('Code'),
                        'message': resp_map.get('Message'),
                        'data': {
                            'httpCode': _response.status_code,
                            'requestId': resp_map.get('RequestId'),
                            'hostId': resp_map.get('HostId')
                        }
                    })
                return oss_models.RestoreObjectResponse().from_map(
                    TeaCore.merge(_response.headers)
                )
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def get_object_acl(
        self,
        request: oss_models.GetObjectAclRequest,
        runtime: ossutil_models.RuntimeOptions,
    ) -> oss_models.GetObjectAclResponse:
        request.validate()
        runtime.validate()
        _runtime = {
            'timeouted': 'retry',
            'readTimeout': UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            'connectTimeout': UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            'localAddr': UtilClient.default_string(runtime.local_addr, self._local_addr),
            'httpProxy': UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            'httpsProxy': UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            'noProxy': UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            'socks5Proxy': UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            'socks5NetWork': UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            'maxIdleConns': UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            'retry': {
                'retryable': runtime.autoretry,
                'maxAttempts': UtilClient.default_number(runtime.max_attempts, 3)
            },
            'backoff': {
                'policy': UtilClient.default_string(runtime.backoff_policy, 'no'),
                'period': UtilClient.default_number(runtime.backoff_period, 1)
            },
            'ignoreSSL': runtime.ignore_ssl
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
                _request.method = 'GET'
                _request.pathname = f'/{request.object_name}?acl'
                _request.headers = {
                    'host': OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    'date': UtilClient.get_date_utcstring(),
                    'user-agent': self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers['x-oss-security-token'] = token
                _request.headers['authorization'] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = UtilClient.read_as_string(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        'code': resp_map.get('Code'),
                        'message': resp_map.get('Message'),
                        'data': {
                            'httpCode': _response.status_code,
                            'requestId': resp_map.get('RequestId'),
                            'hostId': resp_map.get('HostId')
                        }
                    })
                body_str = UtilClient.read_as_string(_response.body)
                resp_map = XMLClient.parse_xml(body_str, oss_models.GetObjectAclResponse())
                return oss_models.GetObjectAclResponse().from_map(
                    TeaCore.merge({
                        'AccessControlPolicy': resp_map.get('AccessControlPolicy')
                    }, _response.headers)
                )
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    async def get_object_acl_async(
        self,
        request: oss_models.GetObjectAclRequest,
        runtime: ossutil_models.RuntimeOptions,
    ) -> oss_models.GetObjectAclResponse:
        request.validate()
        runtime.validate()
        _runtime = {
            'timeouted': 'retry',
            'readTimeout': UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            'connectTimeout': UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            'localAddr': UtilClient.default_string(runtime.local_addr, self._local_addr),
            'httpProxy': UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            'httpsProxy': UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            'noProxy': UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            'socks5Proxy': UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            'socks5NetWork': UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            'maxIdleConns': UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            'retry': {
                'retryable': runtime.autoretry,
                'maxAttempts': UtilClient.default_number(runtime.max_attempts, 3)
            },
            'backoff': {
                'policy': UtilClient.default_string(runtime.backoff_policy, 'no'),
                'period': UtilClient.default_number(runtime.backoff_period, 1)
            },
            'ignoreSSL': runtime.ignore_ssl
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
                access_key_id = await self._credential.get_access_key_id_async()
                access_key_secret = await self._credential.get_access_key_secret_async()
                token = await self._credential.get_security_token_async()
                _request.protocol = self._protocol
                _request.method = 'GET'
                _request.pathname = f'/{request.object_name}?acl'
                _request.headers = {
                    'host': OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    'date': UtilClient.get_date_utcstring(),
                    'user-agent': self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers['x-oss-security-token'] = token
                _request.headers['authorization'] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = await TeaCore.async_do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = await UtilClient.read_as_string_async(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        'code': resp_map.get('Code'),
                        'message': resp_map.get('Message'),
                        'data': {
                            'httpCode': _response.status_code,
                            'requestId': resp_map.get('RequestId'),
                            'hostId': resp_map.get('HostId')
                        }
                    })
                body_str = await UtilClient.read_as_string_async(_response.body)
                resp_map = XMLClient.parse_xml(body_str, oss_models.GetObjectAclResponse())
                return oss_models.GetObjectAclResponse().from_map(
                    TeaCore.merge({
                        'AccessControlPolicy': resp_map.get('AccessControlPolicy')
                    }, _response.headers)
                )
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def put_bucket_acl(
        self,
        request: oss_models.PutBucketAclRequest,
        runtime: ossutil_models.RuntimeOptions,
    ) -> oss_models.PutBucketAclResponse:
        request.validate()
        runtime.validate()
        _runtime = {
            'timeouted': 'retry',
            'readTimeout': UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            'connectTimeout': UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            'localAddr': UtilClient.default_string(runtime.local_addr, self._local_addr),
            'httpProxy': UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            'httpsProxy': UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            'noProxy': UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            'socks5Proxy': UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            'socks5NetWork': UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            'maxIdleConns': UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            'retry': {
                'retryable': runtime.autoretry,
                'maxAttempts': UtilClient.default_number(runtime.max_attempts, 3)
            },
            'backoff': {
                'policy': UtilClient.default_string(runtime.backoff_policy, 'no'),
                'period': UtilClient.default_number(runtime.backoff_period, 1)
            },
            'ignoreSSL': runtime.ignore_ssl
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
                _request.method = 'PUT'
                _request.pathname = f'/?acl'
                _request.headers = TeaCore.merge({
                    'host': OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    'date': UtilClient.get_date_utcstring(),
                    'user-agent': self.get_user_agent()
                }, UtilClient.stringify_map_value(TeaCore.to_map(request.header)))
                if not UtilClient.empty(token):
                    _request.headers['x-oss-security-token'] = token
                _request.headers['authorization'] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = UtilClient.read_as_string(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        'code': resp_map.get('Code'),
                        'message': resp_map.get('Message'),
                        'data': {
                            'httpCode': _response.status_code,
                            'requestId': resp_map.get('RequestId'),
                            'hostId': resp_map.get('HostId')
                        }
                    })
                return oss_models.PutBucketAclResponse().from_map(
                    TeaCore.merge(_response.headers)
                )
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    async def put_bucket_acl_async(
        self,
        request: oss_models.PutBucketAclRequest,
        runtime: ossutil_models.RuntimeOptions,
    ) -> oss_models.PutBucketAclResponse:
        request.validate()
        runtime.validate()
        _runtime = {
            'timeouted': 'retry',
            'readTimeout': UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            'connectTimeout': UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            'localAddr': UtilClient.default_string(runtime.local_addr, self._local_addr),
            'httpProxy': UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            'httpsProxy': UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            'noProxy': UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            'socks5Proxy': UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            'socks5NetWork': UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            'maxIdleConns': UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            'retry': {
                'retryable': runtime.autoretry,
                'maxAttempts': UtilClient.default_number(runtime.max_attempts, 3)
            },
            'backoff': {
                'policy': UtilClient.default_string(runtime.backoff_policy, 'no'),
                'period': UtilClient.default_number(runtime.backoff_period, 1)
            },
            'ignoreSSL': runtime.ignore_ssl
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
                access_key_id = await self._credential.get_access_key_id_async()
                access_key_secret = await self._credential.get_access_key_secret_async()
                token = await self._credential.get_security_token_async()
                _request.protocol = self._protocol
                _request.method = 'PUT'
                _request.pathname = f'/?acl'
                _request.headers = TeaCore.merge({
                    'host': OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    'date': UtilClient.get_date_utcstring(),
                    'user-agent': self.get_user_agent()
                }, UtilClient.stringify_map_value(TeaCore.to_map(request.header)))
                if not UtilClient.empty(token):
                    _request.headers['x-oss-security-token'] = token
                _request.headers['authorization'] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = await TeaCore.async_do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = await UtilClient.read_as_string_async(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        'code': resp_map.get('Code'),
                        'message': resp_map.get('Message'),
                        'data': {
                            'httpCode': _response.status_code,
                            'requestId': resp_map.get('RequestId'),
                            'hostId': resp_map.get('HostId')
                        }
                    })
                return oss_models.PutBucketAclResponse().from_map(
                    TeaCore.merge(_response.headers)
                )
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def delete_bucket(
        self,
        request: oss_models.DeleteBucketRequest,
        runtime: ossutil_models.RuntimeOptions,
    ) -> oss_models.DeleteBucketResponse:
        request.validate()
        runtime.validate()
        _runtime = {
            'timeouted': 'retry',
            'readTimeout': UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            'connectTimeout': UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            'localAddr': UtilClient.default_string(runtime.local_addr, self._local_addr),
            'httpProxy': UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            'httpsProxy': UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            'noProxy': UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            'socks5Proxy': UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            'socks5NetWork': UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            'maxIdleConns': UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            'retry': {
                'retryable': runtime.autoretry,
                'maxAttempts': UtilClient.default_number(runtime.max_attempts, 3)
            },
            'backoff': {
                'policy': UtilClient.default_string(runtime.backoff_policy, 'no'),
                'period': UtilClient.default_number(runtime.backoff_period, 1)
            },
            'ignoreSSL': runtime.ignore_ssl
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
                _request.method = 'DELETE'
                _request.pathname = f'/'
                _request.headers = {
                    'host': OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    'date': UtilClient.get_date_utcstring(),
                    'user-agent': self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers['x-oss-security-token'] = token
                _request.headers['authorization'] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = UtilClient.read_as_string(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        'code': resp_map.get('Code'),
                        'message': resp_map.get('Message'),
                        'data': {
                            'httpCode': _response.status_code,
                            'requestId': resp_map.get('RequestId'),
                            'hostId': resp_map.get('HostId')
                        }
                    })
                return oss_models.DeleteBucketResponse().from_map(
                    TeaCore.merge(_response.headers)
                )
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    async def delete_bucket_async(
        self,
        request: oss_models.DeleteBucketRequest,
        runtime: ossutil_models.RuntimeOptions,
    ) -> oss_models.DeleteBucketResponse:
        request.validate()
        runtime.validate()
        _runtime = {
            'timeouted': 'retry',
            'readTimeout': UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            'connectTimeout': UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            'localAddr': UtilClient.default_string(runtime.local_addr, self._local_addr),
            'httpProxy': UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            'httpsProxy': UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            'noProxy': UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            'socks5Proxy': UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            'socks5NetWork': UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            'maxIdleConns': UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            'retry': {
                'retryable': runtime.autoretry,
                'maxAttempts': UtilClient.default_number(runtime.max_attempts, 3)
            },
            'backoff': {
                'policy': UtilClient.default_string(runtime.backoff_policy, 'no'),
                'period': UtilClient.default_number(runtime.backoff_period, 1)
            },
            'ignoreSSL': runtime.ignore_ssl
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
                access_key_id = await self._credential.get_access_key_id_async()
                access_key_secret = await self._credential.get_access_key_secret_async()
                token = await self._credential.get_security_token_async()
                _request.protocol = self._protocol
                _request.method = 'DELETE'
                _request.pathname = f'/'
                _request.headers = {
                    'host': OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    'date': UtilClient.get_date_utcstring(),
                    'user-agent': self.get_user_agent()
                }
                if not UtilClient.empty(token):
                    _request.headers['x-oss-security-token'] = token
                _request.headers['authorization'] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = await TeaCore.async_do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = await UtilClient.read_as_string_async(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        'code': resp_map.get('Code'),
                        'message': resp_map.get('Message'),
                        'data': {
                            'httpCode': _response.status_code,
                            'requestId': resp_map.get('RequestId'),
                            'hostId': resp_map.get('HostId')
                        }
                    })
                return oss_models.DeleteBucketResponse().from_map(
                    TeaCore.merge(_response.headers)
                )
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def put_object(
        self,
        request: oss_models.PutObjectRequest,
        runtime: ossutil_models.RuntimeOptions,
    ) -> oss_models.PutObjectResponse:
        request.validate()
        runtime.validate()
        _runtime = {
            'timeouted': 'retry',
            'readTimeout': UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            'connectTimeout': UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            'localAddr': UtilClient.default_string(runtime.local_addr, self._local_addr),
            'httpProxy': UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            'httpsProxy': UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            'noProxy': UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            'socks5Proxy': UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            'socks5NetWork': UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            'maxIdleConns': UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            'retry': {
                'retryable': runtime.autoretry,
                'maxAttempts': UtilClient.default_number(runtime.max_attempts, 3)
            },
            'backoff': {
                'policy': UtilClient.default_string(runtime.backoff_policy, 'no'),
                'period': UtilClient.default_number(runtime.backoff_period, 1)
            },
            'ignoreSSL': runtime.ignore_ssl
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
                _request.method = 'PUT'
                _request.pathname = f'/{request.object_name}'
                _request.headers = TeaCore.merge({
                    'host': OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    'date': UtilClient.get_date_utcstring(),
                    'user-agent': self.get_user_agent()
                }, UtilClient.stringify_map_value(TeaCore.to_map(request.header)),
                    OSSUtilClient.parse_meta(request.user_meta, 'x-oss-meta-'))
                if not UtilClient.empty(token):
                    _request.headers['x-oss-security-token'] = token
                _request.body = OSSUtilClient.inject(request.body, ctx)
                if not UtilClient.is_unset(request.header) and not UtilClient.empty(request.header.content_type):
                    _request.headers['content-type'] = request.header.content_type
                else:
                    _request.headers['content-type'] = OSSUtilClient.get_content_type(request.object_name)
                _request.headers['authorization'] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = UtilClient.read_as_string(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        'code': resp_map.get('Code'),
                        'message': resp_map.get('Message'),
                        'data': {
                            'httpCode': _response.status_code,
                            'requestId': resp_map.get('RequestId'),
                            'hostId': resp_map.get('HostId')
                        }
                    })
                if self._is_enable_crc and not UtilClient.equal_string(ctx.get('crc'), _response.headers.get('x-oss-hash-crc64ecma')):
                    raise TeaException({
                        'code': 'CrcNotMatched',
                        'data': {
                            'clientCrc': ctx.get('crc'),
                            'serverCrc': _response.headers.get('x-oss-hash-crc64ecma')
                        }
                    })
                if self._is_enable_md5 and not UtilClient.equal_string(ctx.get('md5'), _response.headers.get('content-md5')):
                    raise TeaException({
                        'code': 'MD5NotMatched',
                        'data': {
                            'clientMD5': ctx.get('md5'),
                            'serverMD5': _response.headers.get('content-md5')
                        }
                    })
                return oss_models.PutObjectResponse().from_map(
                    TeaCore.merge(_response.headers)
                )
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    async def put_object_async(
        self,
        request: oss_models.PutObjectRequest,
        runtime: ossutil_models.RuntimeOptions,
    ) -> oss_models.PutObjectResponse:
        request.validate()
        runtime.validate()
        _runtime = {
            'timeouted': 'retry',
            'readTimeout': UtilClient.default_number(runtime.read_timeout, self._read_timeout),
            'connectTimeout': UtilClient.default_number(runtime.connect_timeout, self._connect_timeout),
            'localAddr': UtilClient.default_string(runtime.local_addr, self._local_addr),
            'httpProxy': UtilClient.default_string(runtime.http_proxy, self._http_proxy),
            'httpsProxy': UtilClient.default_string(runtime.https_proxy, self._https_proxy),
            'noProxy': UtilClient.default_string(runtime.no_proxy, self._no_proxy),
            'socks5Proxy': UtilClient.default_string(runtime.socks_5proxy, self._socks_5proxy),
            'socks5NetWork': UtilClient.default_string(runtime.socks_5net_work, self._socks_5net_work),
            'maxIdleConns': UtilClient.default_number(runtime.max_idle_conns, self._max_idle_conns),
            'retry': {
                'retryable': runtime.autoretry,
                'maxAttempts': UtilClient.default_number(runtime.max_attempts, 3)
            },
            'backoff': {
                'policy': UtilClient.default_string(runtime.backoff_policy, 'no'),
                'period': UtilClient.default_number(runtime.backoff_period, 1)
            },
            'ignoreSSL': runtime.ignore_ssl
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
                access_key_id = await self._credential.get_access_key_id_async()
                access_key_secret = await self._credential.get_access_key_secret_async()
                token = await self._credential.get_security_token_async()
                _request.protocol = self._protocol
                _request.method = 'PUT'
                _request.pathname = f'/{request.object_name}'
                _request.headers = TeaCore.merge({
                    'host': OSSUtilClient.get_host(request.bucket_name, self._region_id, self._endpoint, self._host_model),
                    'date': UtilClient.get_date_utcstring(),
                    'user-agent': self.get_user_agent()
                }, UtilClient.stringify_map_value(TeaCore.to_map(request.header)),
                    OSSUtilClient.parse_meta(request.user_meta, 'x-oss-meta-'))
                if not UtilClient.empty(token):
                    _request.headers['x-oss-security-token'] = token
                _request.body = OSSUtilClient.inject(request.body, ctx)
                if not UtilClient.is_unset(request.header) and not UtilClient.empty(request.header.content_type):
                    _request.headers['content-type'] = request.header.content_type
                else:
                    _request.headers['content-type'] = OSSUtilClient.get_content_type(request.object_name)
                _request.headers['authorization'] = OSSUtilClient.get_signature(_request, request.bucket_name, access_key_id, access_key_secret, self._signature_version, self._addtional_headers)
                _last_request = _request
                _response = await TeaCore.async_do_action(_request, _runtime)
                resp_map = None
                body_str = None
                if UtilClient.is_4xx(_response.status_code) or UtilClient.is_5xx(_response.status_code):
                    body_str = await UtilClient.read_as_string_async(_response.body)
                    resp_map = OSSUtilClient.get_err_message(body_str)
                    raise TeaException({
                        'code': resp_map.get('Code'),
                        'message': resp_map.get('Message'),
                        'data': {
                            'httpCode': _response.status_code,
                            'requestId': resp_map.get('RequestId'),
                            'hostId': resp_map.get('HostId')
                        }
                    })
                if self._is_enable_crc and not UtilClient.equal_string(ctx.get('crc'), _response.headers.get('x-oss-hash-crc64ecma')):
                    raise TeaException({
                        'code': 'CrcNotMatched',
                        'data': {
                            'clientCrc': ctx.get('crc'),
                            'serverCrc': _response.headers.get('x-oss-hash-crc64ecma')
                        }
                    })
                if self._is_enable_md5 and not UtilClient.equal_string(ctx.get('md5'), _response.headers.get('content-md5')):
                    raise TeaException({
                        'code': 'MD5NotMatched',
                        'data': {
                            'clientMD5': ctx.get('md5'),
                            'serverMD5': _response.headers.get('content-md5')
                        }
                    })
                return oss_models.PutObjectResponse().from_map(
                    TeaCore.merge(_response.headers)
                )
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def set_user_agent(
        self,
        user_agent: str,
    ) -> None:
        self._user_agent = user_agent

    def append_user_agent(
        self,
        user_agent: str,
    ) -> None:
        self._user_agent = f'{self._user_agent} {user_agent}'

    def get_user_agent(self) -> str:
        user_agent = UtilClient.get_user_agent(self._user_agent)
        return user_agent

    def get_access_key_id(self) -> str:
        if UtilClient.is_unset(self._credential):
            return ''
        access_key_id = self._credential.get_access_key_id()
        return access_key_id

    async def get_access_key_id_async(self) -> str:
        if UtilClient.is_unset(self._credential):
            return ''
        access_key_id = await self._credential.get_access_key_id_async()
        return access_key_id

    def get_access_key_secret(self) -> str:
        if UtilClient.is_unset(self._credential):
            return ''
        secret = self._credential.get_access_key_secret()
        return secret

    async def get_access_key_secret_async(self) -> str:
        if UtilClient.is_unset(self._credential):
            return ''
        secret = await self._credential.get_access_key_secret_async()
        return secret
