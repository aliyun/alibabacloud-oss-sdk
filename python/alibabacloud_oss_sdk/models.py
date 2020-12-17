# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import List, Dict, BinaryIO

from alibabacloud_tea_fileform import models as file_form_models


class Config(TeaModel):
    def __init__(
        self,
        type: str = None,
        security_token: str = None,
        access_key_id: str = None,
        access_key_secret: str = None,
        endpoint: str = None,
        protocol: str = None,
        region_id: str = None,
        user_agent: str = None,
        host_model: str = None,
        signature_version: str = None,
        is_enable_md5: bool = None,
        is_enable_crc: bool = None,
        read_timeout: int = None,
        connect_timeout: int = None,
        local_addr: str = None,
        http_proxy: str = None,
        https_proxy: str = None,
        no_proxy: str = None,
        socks_5proxy: str = None,
        socks_5net_work: str = None,
        max_idle_conns: int = None,
        addtional_headers: List[str] = None,
    ):
        self.type = type
        self.security_token = security_token
        self.access_key_id = access_key_id
        self.access_key_secret = access_key_secret
        self.endpoint = endpoint
        self.protocol = protocol
        self.region_id = region_id
        self.user_agent = user_agent
        self.host_model = host_model
        self.signature_version = signature_version
        self.is_enable_md5 = is_enable_md5
        self.is_enable_crc = is_enable_crc
        self.read_timeout = read_timeout
        self.connect_timeout = connect_timeout
        self.local_addr = local_addr
        self.http_proxy = http_proxy
        self.https_proxy = https_proxy
        self.no_proxy = no_proxy
        self.socks_5proxy = socks_5proxy
        self.socks_5net_work = socks_5net_work
        self.max_idle_conns = max_idle_conns
        self.addtional_headers = addtional_headers

    def validate(self):
        self.validate_required(self.access_key_id, 'access_key_id')
        self.validate_required(self.access_key_secret, 'access_key_secret')
        if self.region_id is not None:
            self.validate_pattern(self.region_id, 'region_id', '[a-zA-Z0-9-_]+')

    def to_map(self):
        result = dict()
        if self.type is not None:
            result['type'] = self.type
        if self.security_token is not None:
            result['securityToken'] = self.security_token
        if self.access_key_id is not None:
            result['accessKeyId'] = self.access_key_id
        if self.access_key_secret is not None:
            result['accessKeySecret'] = self.access_key_secret
        if self.endpoint is not None:
            result['endpoint'] = self.endpoint
        if self.protocol is not None:
            result['protocol'] = self.protocol
        if self.region_id is not None:
            result['regionId'] = self.region_id
        if self.user_agent is not None:
            result['userAgent'] = self.user_agent
        if self.host_model is not None:
            result['hostModel'] = self.host_model
        if self.signature_version is not None:
            result['signatureVersion'] = self.signature_version
        if self.is_enable_md5 is not None:
            result['isEnableMD5'] = self.is_enable_md5
        if self.is_enable_crc is not None:
            result['isEnableCrc'] = self.is_enable_crc
        if self.read_timeout is not None:
            result['readTimeout'] = self.read_timeout
        if self.connect_timeout is not None:
            result['connectTimeout'] = self.connect_timeout
        if self.local_addr is not None:
            result['localAddr'] = self.local_addr
        if self.http_proxy is not None:
            result['httpProxy'] = self.http_proxy
        if self.https_proxy is not None:
            result['httpsProxy'] = self.https_proxy
        if self.no_proxy is not None:
            result['noProxy'] = self.no_proxy
        if self.socks_5proxy is not None:
            result['socks5Proxy'] = self.socks_5proxy
        if self.socks_5net_work is not None:
            result['socks5NetWork'] = self.socks_5net_work
        if self.max_idle_conns is not None:
            result['maxIdleConns'] = self.max_idle_conns
        if self.addtional_headers is not None:
            result['addtionalHeaders'] = self.addtional_headers
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('securityToken') is not None:
            self.security_token = m.get('securityToken')
        if m.get('accessKeyId') is not None:
            self.access_key_id = m.get('accessKeyId')
        if m.get('accessKeySecret') is not None:
            self.access_key_secret = m.get('accessKeySecret')
        if m.get('endpoint') is not None:
            self.endpoint = m.get('endpoint')
        if m.get('protocol') is not None:
            self.protocol = m.get('protocol')
        if m.get('regionId') is not None:
            self.region_id = m.get('regionId')
        if m.get('userAgent') is not None:
            self.user_agent = m.get('userAgent')
        if m.get('hostModel') is not None:
            self.host_model = m.get('hostModel')
        if m.get('signatureVersion') is not None:
            self.signature_version = m.get('signatureVersion')
        if m.get('isEnableMD5') is not None:
            self.is_enable_md5 = m.get('isEnableMD5')
        if m.get('isEnableCrc') is not None:
            self.is_enable_crc = m.get('isEnableCrc')
        if m.get('readTimeout') is not None:
            self.read_timeout = m.get('readTimeout')
        if m.get('connectTimeout') is not None:
            self.connect_timeout = m.get('connectTimeout')
        if m.get('localAddr') is not None:
            self.local_addr = m.get('localAddr')
        if m.get('httpProxy') is not None:
            self.http_proxy = m.get('httpProxy')
        if m.get('httpsProxy') is not None:
            self.https_proxy = m.get('httpsProxy')
        if m.get('noProxy') is not None:
            self.no_proxy = m.get('noProxy')
        if m.get('socks5Proxy') is not None:
            self.socks_5proxy = m.get('socks5Proxy')
        if m.get('socks5NetWork') is not None:
            self.socks_5net_work = m.get('socks5NetWork')
        if m.get('maxIdleConns') is not None:
            self.max_idle_conns = m.get('maxIdleConns')
        if m.get('addtionalHeaders') is not None:
            self.addtional_headers = m.get('addtionalHeaders')
        return self


class PutBucketLifecycleRequestBodyLifecycleConfigurationRuleExpiration(TeaModel):
    def __init__(
        self,
        days: int = None,
        created_before_date: str = None,
    ):
        # Days
        self.days = days
        # CreatedBeforeDate
        self.created_before_date = created_before_date

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.days is not None:
            result['Days'] = self.days
        if self.created_before_date is not None:
            result['CreatedBeforeDate'] = self.created_before_date
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('Days') is not None:
            self.days = m.get('Days')
        if m.get('CreatedBeforeDate') is not None:
            self.created_before_date = m.get('CreatedBeforeDate')
        return self


class PutBucketLifecycleRequestBodyLifecycleConfigurationRuleTransition(TeaModel):
    def __init__(
        self,
        days: int = None,
        storage_class: str = None,
    ):
        # Days
        self.days = days
        # StorageClass
        self.storage_class = storage_class

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.days is not None:
            result['Days'] = self.days
        if self.storage_class is not None:
            result['StorageClass'] = self.storage_class
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('Days') is not None:
            self.days = m.get('Days')
        if m.get('StorageClass') is not None:
            self.storage_class = m.get('StorageClass')
        return self


class PutBucketLifecycleRequestBodyLifecycleConfigurationRuleAbortMultipartUpload(TeaModel):
    def __init__(
        self,
        days: int = None,
        created_before_date: str = None,
    ):
        # Days
        self.days = days
        # CreatedBeforeDate
        self.created_before_date = created_before_date

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.days is not None:
            result['Days'] = self.days
        if self.created_before_date is not None:
            result['CreatedBeforeDate'] = self.created_before_date
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('Days') is not None:
            self.days = m.get('Days')
        if m.get('CreatedBeforeDate') is not None:
            self.created_before_date = m.get('CreatedBeforeDate')
        return self


class PutBucketLifecycleRequestBodyLifecycleConfigurationRuleTag(TeaModel):
    def __init__(
        self,
        key: str = None,
        value: str = None,
    ):
        # Key
        self.key = key
        # Value
        self.value = value

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.key is not None:
            result['Key'] = self.key
        if self.value is not None:
            result['Value'] = self.value
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('Key') is not None:
            self.key = m.get('Key')
        if m.get('Value') is not None:
            self.value = m.get('Value')
        return self


class PutBucketLifecycleRequestBodyLifecycleConfigurationRule(TeaModel):
    def __init__(
        self,
        expiration: PutBucketLifecycleRequestBodyLifecycleConfigurationRuleExpiration = None,
        transition: PutBucketLifecycleRequestBodyLifecycleConfigurationRuleTransition = None,
        abort_multipart_upload: PutBucketLifecycleRequestBodyLifecycleConfigurationRuleAbortMultipartUpload = None,
        tag: PutBucketLifecycleRequestBodyLifecycleConfigurationRuleTag = None,
        i_d: str = None,
        prefix: str = None,
        status: str = None,
    ):
        # Expiration
        self.expiration = expiration
        # Transition
        self.transition = transition
        # AbortMultipartUpload
        self.abort_multipart_upload = abort_multipart_upload
        # Tag
        self.tag = tag
        # ID
        self.i_d = i_d
        # Prefix
        self.prefix = prefix
        # Status
        self.status = status

    def validate(self):
        if self.expiration:
            self.expiration.validate()
        if self.transition:
            self.transition.validate()
        if self.abort_multipart_upload:
            self.abort_multipart_upload.validate()
        if self.tag:
            self.tag.validate()

    def to_map(self):
        result = dict()
        if self.expiration is not None:
            result['Expiration'] = self.expiration.to_map()
        if self.transition is not None:
            result['Transition'] = self.transition.to_map()
        if self.abort_multipart_upload is not None:
            result['AbortMultipartUpload'] = self.abort_multipart_upload.to_map()
        if self.tag is not None:
            result['Tag'] = self.tag.to_map()
        if self.i_d is not None:
            result['ID'] = self.i_d
        if self.prefix is not None:
            result['Prefix'] = self.prefix
        if self.status is not None:
            result['Status'] = self.status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('Expiration') is not None:
            temp_model = PutBucketLifecycleRequestBodyLifecycleConfigurationRuleExpiration()
            self.expiration = temp_model.from_map(m['Expiration'])
        if m.get('Transition') is not None:
            temp_model = PutBucketLifecycleRequestBodyLifecycleConfigurationRuleTransition()
            self.transition = temp_model.from_map(m['Transition'])
        if m.get('AbortMultipartUpload') is not None:
            temp_model = PutBucketLifecycleRequestBodyLifecycleConfigurationRuleAbortMultipartUpload()
            self.abort_multipart_upload = temp_model.from_map(m['AbortMultipartUpload'])
        if m.get('Tag') is not None:
            temp_model = PutBucketLifecycleRequestBodyLifecycleConfigurationRuleTag()
            self.tag = temp_model.from_map(m['Tag'])
        if m.get('ID') is not None:
            self.i_d = m.get('ID')
        if m.get('Prefix') is not None:
            self.prefix = m.get('Prefix')
        if m.get('Status') is not None:
            self.status = m.get('Status')
        return self


class PutBucketLifecycleRequestBodyLifecycleConfiguration(TeaModel):
    def __init__(
        self,
        rule: List[PutBucketLifecycleRequestBodyLifecycleConfigurationRule] = None,
    ):
        # Rule
        self.rule = rule

    def validate(self):
        if self.rule:
            for k in self.rule:
                if k:
                    k.validate()

    def to_map(self):
        result = dict()
        result['Rule'] = []
        if self.rule is not None:
            for k in self.rule:
                result['Rule'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.rule = []
        if m.get('Rule') is not None:
            for k in m.get('Rule'):
                temp_model = PutBucketLifecycleRequestBodyLifecycleConfigurationRule()
                self.rule.append(temp_model.from_map(k))
        return self


class PutBucketLifecycleRequestBody(TeaModel):
    def __init__(
        self,
        lifecycle_configuration: PutBucketLifecycleRequestBodyLifecycleConfiguration = None,
    ):
        # LifecycleConfiguration
        self.lifecycle_configuration = lifecycle_configuration

    def validate(self):
        self.validate_required(self.lifecycle_configuration, 'lifecycle_configuration')
        if self.lifecycle_configuration:
            self.lifecycle_configuration.validate()

    def to_map(self):
        result = dict()
        if self.lifecycle_configuration is not None:
            result['LifecycleConfiguration'] = self.lifecycle_configuration.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('LifecycleConfiguration') is not None:
            temp_model = PutBucketLifecycleRequestBodyLifecycleConfiguration()
            self.lifecycle_configuration = temp_model.from_map(m['LifecycleConfiguration'])
        return self


class PutBucketLifecycleRequest(TeaModel):
    def __init__(
        self,
        bucket_name: str = None,
        body: PutBucketLifecycleRequestBody = None,
    ):
        # BucketName
        self.bucket_name = bucket_name
        # Body
        self.body = body

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')
        if self.bucket_name is not None:
            self.validate_pattern(self.bucket_name, 'bucket_name', '[a-zA-Z0-9-_]+')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = dict()
        if self.bucket_name is not None:
            result['BucketName'] = self.bucket_name
        if self.body is not None:
            result['Body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('BucketName') is not None:
            self.bucket_name = m.get('BucketName')
        if m.get('Body') is not None:
            temp_model = PutBucketLifecycleRequestBody()
            self.body = temp_model.from_map(m['Body'])
        return self


class PutBucketLifecycleResponse(TeaModel):
    def __init__(
        self,
        request_id: str = None,
    ):
        # x-oss-request-id
        self.request_id = request_id

    def validate(self):
        self.validate_required(self.request_id, 'request_id')

    def to_map(self):
        result = dict()
        if self.request_id is not None:
            result['x-oss-request-id'] = self.request_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('x-oss-request-id') is not None:
            self.request_id = m.get('x-oss-request-id')
        return self


class DeleteMultipleObjectsRequestBodyDeleteObject(TeaModel):
    def __init__(
        self,
        key: str = None,
    ):
        # Key
        self.key = key

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.key is not None:
            result['Key'] = self.key
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('Key') is not None:
            self.key = m.get('Key')
        return self


class DeleteMultipleObjectsRequestBodyDelete(TeaModel):
    def __init__(
        self,
        object: List[DeleteMultipleObjectsRequestBodyDeleteObject] = None,
        quiet: str = None,
    ):
        # Object
        self.object = object
        # Quiet
        self.quiet = quiet

    def validate(self):
        if self.object:
            for k in self.object:
                if k:
                    k.validate()

    def to_map(self):
        result = dict()
        result['Object'] = []
        if self.object is not None:
            for k in self.object:
                result['Object'].append(k.to_map() if k else None)
        if self.quiet is not None:
            result['Quiet'] = self.quiet
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.object = []
        if m.get('Object') is not None:
            for k in m.get('Object'):
                temp_model = DeleteMultipleObjectsRequestBodyDeleteObject()
                self.object.append(temp_model.from_map(k))
        if m.get('Quiet') is not None:
            self.quiet = m.get('Quiet')
        return self


class DeleteMultipleObjectsRequestBody(TeaModel):
    def __init__(
        self,
        delete: DeleteMultipleObjectsRequestBodyDelete = None,
    ):
        # Delete
        self.delete = delete

    def validate(self):
        self.validate_required(self.delete, 'delete')
        if self.delete:
            self.delete.validate()

    def to_map(self):
        result = dict()
        if self.delete is not None:
            result['Delete'] = self.delete.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('Delete') is not None:
            temp_model = DeleteMultipleObjectsRequestBodyDelete()
            self.delete = temp_model.from_map(m['Delete'])
        return self


class DeleteMultipleObjectsRequestHeader(TeaModel):
    def __init__(
        self,
        encoding_type: str = None,
        content_length: str = None,
        content_md5: str = None,
    ):
        # Encoding-type
        self.encoding_type = encoding_type
        # Content-Length
        self.content_length = content_length
        # Content-MD5
        self.content_md5 = content_md5

    def validate(self):
        self.validate_required(self.content_length, 'content_length')
        self.validate_required(self.content_md5, 'content_md5')

    def to_map(self):
        result = dict()
        if self.encoding_type is not None:
            result['Encoding-type'] = self.encoding_type
        if self.content_length is not None:
            result['Content-Length'] = self.content_length
        if self.content_md5 is not None:
            result['Content-MD5'] = self.content_md5
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('Encoding-type') is not None:
            self.encoding_type = m.get('Encoding-type')
        if m.get('Content-Length') is not None:
            self.content_length = m.get('Content-Length')
        if m.get('Content-MD5') is not None:
            self.content_md5 = m.get('Content-MD5')
        return self


class DeleteMultipleObjectsRequest(TeaModel):
    def __init__(
        self,
        bucket_name: str = None,
        body: DeleteMultipleObjectsRequestBody = None,
        header: DeleteMultipleObjectsRequestHeader = None,
    ):
        # BucketName
        self.bucket_name = bucket_name
        # Body
        self.body = body
        # Header
        self.header = header

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')
        if self.bucket_name is not None:
            self.validate_pattern(self.bucket_name, 'bucket_name', '[a-zA-Z0-9-_]+')
        if self.body:
            self.body.validate()
        self.validate_required(self.header, 'header')
        if self.header:
            self.header.validate()

    def to_map(self):
        result = dict()
        if self.bucket_name is not None:
            result['BucketName'] = self.bucket_name
        if self.body is not None:
            result['Body'] = self.body.to_map()
        if self.header is not None:
            result['Header'] = self.header.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('BucketName') is not None:
            self.bucket_name = m.get('BucketName')
        if m.get('Body') is not None:
            temp_model = DeleteMultipleObjectsRequestBody()
            self.body = temp_model.from_map(m['Body'])
        if m.get('Header') is not None:
            temp_model = DeleteMultipleObjectsRequestHeader()
            self.header = temp_model.from_map(m['Header'])
        return self


class DeleteMultipleObjectsResponseDeleteResultDeleted(TeaModel):
    def __init__(
        self,
        key: str = None,
    ):
        # Key
        self.key = key

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.key is not None:
            result['Key'] = self.key
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('Key') is not None:
            self.key = m.get('Key')
        return self


class DeleteMultipleObjectsResponseDeleteResult(TeaModel):
    def __init__(
        self,
        quiet: str = None,
        encoding_type: str = None,
        deleted: List[DeleteMultipleObjectsResponseDeleteResultDeleted] = None,
    ):
        # Quiet
        self.quiet = quiet
        # EncodingType
        self.encoding_type = encoding_type
        # Deleted
        self.deleted = deleted

    def validate(self):
        if self.deleted:
            for k in self.deleted:
                if k:
                    k.validate()

    def to_map(self):
        result = dict()
        if self.quiet is not None:
            result['Quiet'] = self.quiet
        if self.encoding_type is not None:
            result['EncodingType'] = self.encoding_type
        result['Deleted'] = []
        if self.deleted is not None:
            for k in self.deleted:
                result['Deleted'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('Quiet') is not None:
            self.quiet = m.get('Quiet')
        if m.get('EncodingType') is not None:
            self.encoding_type = m.get('EncodingType')
        self.deleted = []
        if m.get('Deleted') is not None:
            for k in m.get('Deleted'):
                temp_model = DeleteMultipleObjectsResponseDeleteResultDeleted()
                self.deleted.append(temp_model.from_map(k))
        return self


class DeleteMultipleObjectsResponse(TeaModel):
    def __init__(
        self,
        request_id: str = None,
        delete_result: DeleteMultipleObjectsResponseDeleteResult = None,
    ):
        # x-oss-request-id
        self.request_id = request_id
        # DeleteResult
        self.delete_result = delete_result

    def validate(self):
        self.validate_required(self.request_id, 'request_id')
        self.validate_required(self.delete_result, 'delete_result')
        if self.delete_result:
            self.delete_result.validate()

    def to_map(self):
        result = dict()
        if self.request_id is not None:
            result['x-oss-request-id'] = self.request_id
        if self.delete_result is not None:
            result['DeleteResult'] = self.delete_result.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('x-oss-request-id') is not None:
            self.request_id = m.get('x-oss-request-id')
        if m.get('DeleteResult') is not None:
            temp_model = DeleteMultipleObjectsResponseDeleteResult()
            self.delete_result = temp_model.from_map(m['DeleteResult'])
        return self


class PutBucketRefererRequestBodyRefererConfigurationRefererList(TeaModel):
    def __init__(
        self,
        referer: List[str] = None,
    ):
        # Referer
        self.referer = referer

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.referer is not None:
            result['Referer'] = self.referer
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('Referer') is not None:
            self.referer = m.get('Referer')
        return self


class PutBucketRefererRequestBodyRefererConfiguration(TeaModel):
    def __init__(
        self,
        referer_list: PutBucketRefererRequestBodyRefererConfigurationRefererList = None,
        allow_empty_referer: bool = None,
    ):
        # RefererList
        self.referer_list = referer_list
        # AllowEmptyReferer
        self.allow_empty_referer = allow_empty_referer

    def validate(self):
        if self.referer_list:
            self.referer_list.validate()

    def to_map(self):
        result = dict()
        if self.referer_list is not None:
            result['RefererList'] = self.referer_list.to_map()
        if self.allow_empty_referer is not None:
            result['AllowEmptyReferer'] = self.allow_empty_referer
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('RefererList') is not None:
            temp_model = PutBucketRefererRequestBodyRefererConfigurationRefererList()
            self.referer_list = temp_model.from_map(m['RefererList'])
        if m.get('AllowEmptyReferer') is not None:
            self.allow_empty_referer = m.get('AllowEmptyReferer')
        return self


class PutBucketRefererRequestBody(TeaModel):
    def __init__(
        self,
        referer_configuration: PutBucketRefererRequestBodyRefererConfiguration = None,
    ):
        # RefererConfiguration
        self.referer_configuration = referer_configuration

    def validate(self):
        self.validate_required(self.referer_configuration, 'referer_configuration')
        if self.referer_configuration:
            self.referer_configuration.validate()

    def to_map(self):
        result = dict()
        if self.referer_configuration is not None:
            result['RefererConfiguration'] = self.referer_configuration.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('RefererConfiguration') is not None:
            temp_model = PutBucketRefererRequestBodyRefererConfiguration()
            self.referer_configuration = temp_model.from_map(m['RefererConfiguration'])
        return self


class PutBucketRefererRequest(TeaModel):
    def __init__(
        self,
        bucket_name: str = None,
        body: PutBucketRefererRequestBody = None,
    ):
        # BucketName
        self.bucket_name = bucket_name
        # Body
        self.body = body

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')
        if self.bucket_name is not None:
            self.validate_pattern(self.bucket_name, 'bucket_name', '[a-zA-Z0-9-_]+')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = dict()
        if self.bucket_name is not None:
            result['BucketName'] = self.bucket_name
        if self.body is not None:
            result['Body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('BucketName') is not None:
            self.bucket_name = m.get('BucketName')
        if m.get('Body') is not None:
            temp_model = PutBucketRefererRequestBody()
            self.body = temp_model.from_map(m['Body'])
        return self


class PutBucketRefererResponse(TeaModel):
    def __init__(
        self,
        request_id: str = None,
    ):
        # x-oss-request-id
        self.request_id = request_id

    def validate(self):
        self.validate_required(self.request_id, 'request_id')

    def to_map(self):
        result = dict()
        if self.request_id is not None:
            result['x-oss-request-id'] = self.request_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('x-oss-request-id') is not None:
            self.request_id = m.get('x-oss-request-id')
        return self


class PutBucketWebsiteRequestBodyWebsiteConfigurationIndexDocument(TeaModel):
    def __init__(
        self,
        suffix: str = None,
    ):
        # Suffix
        self.suffix = suffix

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.suffix is not None:
            result['Suffix'] = self.suffix
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('Suffix') is not None:
            self.suffix = m.get('Suffix')
        return self


class PutBucketWebsiteRequestBodyWebsiteConfigurationErrorDocument(TeaModel):
    def __init__(
        self,
        key: str = None,
    ):
        # Key
        self.key = key

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.key is not None:
            result['Key'] = self.key
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('Key') is not None:
            self.key = m.get('Key')
        return self


class PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleConditionIncludeHeader(TeaModel):
    def __init__(
        self,
        key: str = None,
        equals: str = None,
    ):
        # Key
        self.key = key
        # Equals
        self.equals = equals

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.key is not None:
            result['Key'] = self.key
        if self.equals is not None:
            result['Equals'] = self.equals
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('Key') is not None:
            self.key = m.get('Key')
        if m.get('Equals') is not None:
            self.equals = m.get('Equals')
        return self


class PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleCondition(TeaModel):
    def __init__(
        self,
        include_header: PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleConditionIncludeHeader = None,
        key_prefix_equals: str = None,
        http_error_code_returned_equals: str = None,
    ):
        # IncludeHeader
        self.include_header = include_header
        # KeyPrefixEquals
        self.key_prefix_equals = key_prefix_equals
        # HttpErrorCodeReturnedEquals
        self.http_error_code_returned_equals = http_error_code_returned_equals

    def validate(self):
        if self.include_header:
            self.include_header.validate()

    def to_map(self):
        result = dict()
        if self.include_header is not None:
            result['IncludeHeader'] = self.include_header.to_map()
        if self.key_prefix_equals is not None:
            result['KeyPrefixEquals'] = self.key_prefix_equals
        if self.http_error_code_returned_equals is not None:
            result['HttpErrorCodeReturnedEquals'] = self.http_error_code_returned_equals
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('IncludeHeader') is not None:
            temp_model = PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleConditionIncludeHeader()
            self.include_header = temp_model.from_map(m['IncludeHeader'])
        if m.get('KeyPrefixEquals') is not None:
            self.key_prefix_equals = m.get('KeyPrefixEquals')
        if m.get('HttpErrorCodeReturnedEquals') is not None:
            self.http_error_code_returned_equals = m.get('HttpErrorCodeReturnedEquals')
        return self


class PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeadersSet(TeaModel):
    def __init__(
        self,
        key: str = None,
        value: str = None,
    ):
        # Key
        self.key = key
        # Value
        self.value = value

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.key is not None:
            result['Key'] = self.key
        if self.value is not None:
            result['Value'] = self.value
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('Key') is not None:
            self.key = m.get('Key')
        if m.get('Value') is not None:
            self.value = m.get('Value')
        return self


class PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeaders(TeaModel):
    def __init__(
        self,
        set: PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeadersSet = None,
        pass_all: bool = None,
        pass_: str = None,
        remove: str = None,
    ):
        # Set
        self.set = set
        # PassAll
        self.pass_all = pass_all
        # Pass
        self.pass_ = pass_
        # Remove
        self.remove = remove

    def validate(self):
        if self.set:
            self.set.validate()

    def to_map(self):
        result = dict()
        if self.set is not None:
            result['Set'] = self.set.to_map()
        if self.pass_all is not None:
            result['PassAll'] = self.pass_all
        if self.pass_ is not None:
            result['Pass'] = self.pass_
        if self.remove is not None:
            result['Remove'] = self.remove
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('Set') is not None:
            temp_model = PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeadersSet()
            self.set = temp_model.from_map(m['Set'])
        if m.get('PassAll') is not None:
            self.pass_all = m.get('PassAll')
        if m.get('Pass') is not None:
            self.pass_ = m.get('Pass')
        if m.get('Remove') is not None:
            self.remove = m.get('Remove')
        return self


class PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirect(TeaModel):
    def __init__(
        self,
        mirror_headers: PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeaders = None,
        redirect_type: str = None,
        pass_query_string: bool = None,
        mirror_url: str = None,
        mirror_pass_query_string: bool = None,
        mirror_follow_redirect: bool = None,
        mirror_check_md_5: bool = None,
        protocol: str = None,
        host_name: str = None,
        http_redirect_code: str = None,
        replace_key_prefix_with: str = None,
        replace_key_with: str = None,
    ):
        # MirrorHeaders
        self.mirror_headers = mirror_headers
        # RedirectType
        self.redirect_type = redirect_type
        # PassQueryString
        self.pass_query_string = pass_query_string
        # MirrorURL
        self.mirror_url = mirror_url
        # MirrorPassQueryString
        self.mirror_pass_query_string = mirror_pass_query_string
        # MirrorFollowRedirect
        self.mirror_follow_redirect = mirror_follow_redirect
        # MirrorCheckMd5
        self.mirror_check_md_5 = mirror_check_md_5
        # Protocol
        self.protocol = protocol
        # HostName
        self.host_name = host_name
        # HttpRedirectCode
        self.http_redirect_code = http_redirect_code
        # ReplaceKeyPrefixWith
        self.replace_key_prefix_with = replace_key_prefix_with
        # ReplaceKeyWith
        self.replace_key_with = replace_key_with

    def validate(self):
        if self.mirror_headers:
            self.mirror_headers.validate()

    def to_map(self):
        result = dict()
        if self.mirror_headers is not None:
            result['MirrorHeaders'] = self.mirror_headers.to_map()
        if self.redirect_type is not None:
            result['RedirectType'] = self.redirect_type
        if self.pass_query_string is not None:
            result['PassQueryString'] = self.pass_query_string
        if self.mirror_url is not None:
            result['MirrorURL'] = self.mirror_url
        if self.mirror_pass_query_string is not None:
            result['MirrorPassQueryString'] = self.mirror_pass_query_string
        if self.mirror_follow_redirect is not None:
            result['MirrorFollowRedirect'] = self.mirror_follow_redirect
        if self.mirror_check_md_5 is not None:
            result['MirrorCheckMd5'] = self.mirror_check_md_5
        if self.protocol is not None:
            result['Protocol'] = self.protocol
        if self.host_name is not None:
            result['HostName'] = self.host_name
        if self.http_redirect_code is not None:
            result['HttpRedirectCode'] = self.http_redirect_code
        if self.replace_key_prefix_with is not None:
            result['ReplaceKeyPrefixWith'] = self.replace_key_prefix_with
        if self.replace_key_with is not None:
            result['ReplaceKeyWith'] = self.replace_key_with
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('MirrorHeaders') is not None:
            temp_model = PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeaders()
            self.mirror_headers = temp_model.from_map(m['MirrorHeaders'])
        if m.get('RedirectType') is not None:
            self.redirect_type = m.get('RedirectType')
        if m.get('PassQueryString') is not None:
            self.pass_query_string = m.get('PassQueryString')
        if m.get('MirrorURL') is not None:
            self.mirror_url = m.get('MirrorURL')
        if m.get('MirrorPassQueryString') is not None:
            self.mirror_pass_query_string = m.get('MirrorPassQueryString')
        if m.get('MirrorFollowRedirect') is not None:
            self.mirror_follow_redirect = m.get('MirrorFollowRedirect')
        if m.get('MirrorCheckMd5') is not None:
            self.mirror_check_md_5 = m.get('MirrorCheckMd5')
        if m.get('Protocol') is not None:
            self.protocol = m.get('Protocol')
        if m.get('HostName') is not None:
            self.host_name = m.get('HostName')
        if m.get('HttpRedirectCode') is not None:
            self.http_redirect_code = m.get('HttpRedirectCode')
        if m.get('ReplaceKeyPrefixWith') is not None:
            self.replace_key_prefix_with = m.get('ReplaceKeyPrefixWith')
        if m.get('ReplaceKeyWith') is not None:
            self.replace_key_with = m.get('ReplaceKeyWith')
        return self


class PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRule(TeaModel):
    def __init__(
        self,
        condition: PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleCondition = None,
        redirect: PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirect = None,
        rule_number: int = None,
    ):
        # Condition
        self.condition = condition
        # Redirect
        self.redirect = redirect
        # RuleNumber
        self.rule_number = rule_number

    def validate(self):
        if self.condition:
            self.condition.validate()
        if self.redirect:
            self.redirect.validate()

    def to_map(self):
        result = dict()
        if self.condition is not None:
            result['Condition'] = self.condition.to_map()
        if self.redirect is not None:
            result['Redirect'] = self.redirect.to_map()
        if self.rule_number is not None:
            result['RuleNumber'] = self.rule_number
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('Condition') is not None:
            temp_model = PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleCondition()
            self.condition = temp_model.from_map(m['Condition'])
        if m.get('Redirect') is not None:
            temp_model = PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirect()
            self.redirect = temp_model.from_map(m['Redirect'])
        if m.get('RuleNumber') is not None:
            self.rule_number = m.get('RuleNumber')
        return self


class PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRules(TeaModel):
    def __init__(
        self,
        routing_rule: List[PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRule] = None,
    ):
        # RoutingRule
        self.routing_rule = routing_rule

    def validate(self):
        if self.routing_rule:
            for k in self.routing_rule:
                if k:
                    k.validate()

    def to_map(self):
        result = dict()
        result['RoutingRule'] = []
        if self.routing_rule is not None:
            for k in self.routing_rule:
                result['RoutingRule'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.routing_rule = []
        if m.get('RoutingRule') is not None:
            for k in m.get('RoutingRule'):
                temp_model = PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRule()
                self.routing_rule.append(temp_model.from_map(k))
        return self


class PutBucketWebsiteRequestBodyWebsiteConfiguration(TeaModel):
    def __init__(
        self,
        index_document: PutBucketWebsiteRequestBodyWebsiteConfigurationIndexDocument = None,
        error_document: PutBucketWebsiteRequestBodyWebsiteConfigurationErrorDocument = None,
        routing_rules: PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRules = None,
    ):
        # IndexDocument
        self.index_document = index_document
        # ErrorDocument
        self.error_document = error_document
        # RoutingRules
        self.routing_rules = routing_rules

    def validate(self):
        if self.index_document:
            self.index_document.validate()
        if self.error_document:
            self.error_document.validate()
        if self.routing_rules:
            self.routing_rules.validate()

    def to_map(self):
        result = dict()
        if self.index_document is not None:
            result['IndexDocument'] = self.index_document.to_map()
        if self.error_document is not None:
            result['ErrorDocument'] = self.error_document.to_map()
        if self.routing_rules is not None:
            result['RoutingRules'] = self.routing_rules.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('IndexDocument') is not None:
            temp_model = PutBucketWebsiteRequestBodyWebsiteConfigurationIndexDocument()
            self.index_document = temp_model.from_map(m['IndexDocument'])
        if m.get('ErrorDocument') is not None:
            temp_model = PutBucketWebsiteRequestBodyWebsiteConfigurationErrorDocument()
            self.error_document = temp_model.from_map(m['ErrorDocument'])
        if m.get('RoutingRules') is not None:
            temp_model = PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRules()
            self.routing_rules = temp_model.from_map(m['RoutingRules'])
        return self


class PutBucketWebsiteRequestBody(TeaModel):
    def __init__(
        self,
        website_configuration: PutBucketWebsiteRequestBodyWebsiteConfiguration = None,
    ):
        # WebsiteConfiguration
        self.website_configuration = website_configuration

    def validate(self):
        self.validate_required(self.website_configuration, 'website_configuration')
        if self.website_configuration:
            self.website_configuration.validate()

    def to_map(self):
        result = dict()
        if self.website_configuration is not None:
            result['WebsiteConfiguration'] = self.website_configuration.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('WebsiteConfiguration') is not None:
            temp_model = PutBucketWebsiteRequestBodyWebsiteConfiguration()
            self.website_configuration = temp_model.from_map(m['WebsiteConfiguration'])
        return self


class PutBucketWebsiteRequest(TeaModel):
    def __init__(
        self,
        bucket_name: str = None,
        body: PutBucketWebsiteRequestBody = None,
    ):
        # BucketName
        self.bucket_name = bucket_name
        # Body
        self.body = body

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')
        if self.bucket_name is not None:
            self.validate_pattern(self.bucket_name, 'bucket_name', '[a-zA-Z0-9-_]+')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = dict()
        if self.bucket_name is not None:
            result['BucketName'] = self.bucket_name
        if self.body is not None:
            result['Body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('BucketName') is not None:
            self.bucket_name = m.get('BucketName')
        if m.get('Body') is not None:
            temp_model = PutBucketWebsiteRequestBody()
            self.body = temp_model.from_map(m['Body'])
        return self


class PutBucketWebsiteResponse(TeaModel):
    def __init__(
        self,
        request_id: str = None,
    ):
        # x-oss-request-id
        self.request_id = request_id

    def validate(self):
        self.validate_required(self.request_id, 'request_id')

    def to_map(self):
        result = dict()
        if self.request_id is not None:
            result['x-oss-request-id'] = self.request_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('x-oss-request-id') is not None:
            self.request_id = m.get('x-oss-request-id')
        return self


class CompleteMultipartUploadRequestFilter(TeaModel):
    def __init__(
        self,
        upload_id: str = None,
        encoding_type: str = None,
    ):
        # uploadId
        self.upload_id = upload_id
        # Encoding-type
        self.encoding_type = encoding_type

    def validate(self):
        self.validate_required(self.upload_id, 'upload_id')

    def to_map(self):
        result = dict()
        if self.upload_id is not None:
            result['uploadId'] = self.upload_id
        if self.encoding_type is not None:
            result['Encoding-type'] = self.encoding_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('uploadId') is not None:
            self.upload_id = m.get('uploadId')
        if m.get('Encoding-type') is not None:
            self.encoding_type = m.get('Encoding-type')
        return self


class CompleteMultipartUploadRequestBodyCompleteMultipartUploadPart(TeaModel):
    def __init__(
        self,
        part_number: str = None,
        e_tag: str = None,
    ):
        # PartNumber
        self.part_number = part_number
        # ETag
        self.e_tag = e_tag

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.part_number is not None:
            result['PartNumber'] = self.part_number
        if self.e_tag is not None:
            result['ETag'] = self.e_tag
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('PartNumber') is not None:
            self.part_number = m.get('PartNumber')
        if m.get('ETag') is not None:
            self.e_tag = m.get('ETag')
        return self


class CompleteMultipartUploadRequestBodyCompleteMultipartUpload(TeaModel):
    def __init__(
        self,
        part: List[CompleteMultipartUploadRequestBodyCompleteMultipartUploadPart] = None,
    ):
        # Part
        self.part = part

    def validate(self):
        if self.part:
            for k in self.part:
                if k:
                    k.validate()

    def to_map(self):
        result = dict()
        result['Part'] = []
        if self.part is not None:
            for k in self.part:
                result['Part'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.part = []
        if m.get('Part') is not None:
            for k in m.get('Part'):
                temp_model = CompleteMultipartUploadRequestBodyCompleteMultipartUploadPart()
                self.part.append(temp_model.from_map(k))
        return self


class CompleteMultipartUploadRequestBody(TeaModel):
    def __init__(
        self,
        complete_multipart_upload: CompleteMultipartUploadRequestBodyCompleteMultipartUpload = None,
    ):
        # CompleteMultipartUpload
        self.complete_multipart_upload = complete_multipart_upload

    def validate(self):
        self.validate_required(self.complete_multipart_upload, 'complete_multipart_upload')
        if self.complete_multipart_upload:
            self.complete_multipart_upload.validate()

    def to_map(self):
        result = dict()
        if self.complete_multipart_upload is not None:
            result['CompleteMultipartUpload'] = self.complete_multipart_upload.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('CompleteMultipartUpload') is not None:
            temp_model = CompleteMultipartUploadRequestBodyCompleteMultipartUpload()
            self.complete_multipart_upload = temp_model.from_map(m['CompleteMultipartUpload'])
        return self


class CompleteMultipartUploadRequest(TeaModel):
    def __init__(
        self,
        bucket_name: str = None,
        object_name: str = None,
        filter: CompleteMultipartUploadRequestFilter = None,
        body: CompleteMultipartUploadRequestBody = None,
    ):
        # BucketName
        self.bucket_name = bucket_name
        # ObjectName
        self.object_name = object_name
        # Filter
        self.filter = filter
        # Body
        self.body = body

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')
        if self.bucket_name is not None:
            self.validate_pattern(self.bucket_name, 'bucket_name', '[a-zA-Z0-9-_]+')
        self.validate_required(self.object_name, 'object_name')
        self.validate_required(self.filter, 'filter')
        if self.filter:
            self.filter.validate()
        if self.body:
            self.body.validate()

    def to_map(self):
        result = dict()
        if self.bucket_name is not None:
            result['BucketName'] = self.bucket_name
        if self.object_name is not None:
            result['ObjectName'] = self.object_name
        if self.filter is not None:
            result['Filter'] = self.filter.to_map()
        if self.body is not None:
            result['Body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('BucketName') is not None:
            self.bucket_name = m.get('BucketName')
        if m.get('ObjectName') is not None:
            self.object_name = m.get('ObjectName')
        if m.get('Filter') is not None:
            temp_model = CompleteMultipartUploadRequestFilter()
            self.filter = temp_model.from_map(m['Filter'])
        if m.get('Body') is not None:
            temp_model = CompleteMultipartUploadRequestBody()
            self.body = temp_model.from_map(m['Body'])
        return self


class CompleteMultipartUploadResponseCompleteMultipartUploadResult(TeaModel):
    def __init__(
        self,
        bucket: str = None,
        e_tag: str = None,
        location: str = None,
        key: str = None,
        encoding_type: str = None,
    ):
        # Bucket
        self.bucket = bucket
        # ETag
        self.e_tag = e_tag
        # Location
        self.location = location
        # Key
        self.key = key
        # EncodingType
        self.encoding_type = encoding_type

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.bucket is not None:
            result['Bucket'] = self.bucket
        if self.e_tag is not None:
            result['ETag'] = self.e_tag
        if self.location is not None:
            result['Location'] = self.location
        if self.key is not None:
            result['Key'] = self.key
        if self.encoding_type is not None:
            result['EncodingType'] = self.encoding_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('Bucket') is not None:
            self.bucket = m.get('Bucket')
        if m.get('ETag') is not None:
            self.e_tag = m.get('ETag')
        if m.get('Location') is not None:
            self.location = m.get('Location')
        if m.get('Key') is not None:
            self.key = m.get('Key')
        if m.get('EncodingType') is not None:
            self.encoding_type = m.get('EncodingType')
        return self


class CompleteMultipartUploadResponse(TeaModel):
    def __init__(
        self,
        request_id: str = None,
        complete_multipart_upload_result: CompleteMultipartUploadResponseCompleteMultipartUploadResult = None,
    ):
        # x-oss-request-id
        self.request_id = request_id
        # CompleteMultipartUploadResult
        self.complete_multipart_upload_result = complete_multipart_upload_result

    def validate(self):
        self.validate_required(self.request_id, 'request_id')
        self.validate_required(self.complete_multipart_upload_result, 'complete_multipart_upload_result')
        if self.complete_multipart_upload_result:
            self.complete_multipart_upload_result.validate()

    def to_map(self):
        result = dict()
        if self.request_id is not None:
            result['x-oss-request-id'] = self.request_id
        if self.complete_multipart_upload_result is not None:
            result['CompleteMultipartUploadResult'] = self.complete_multipart_upload_result.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('x-oss-request-id') is not None:
            self.request_id = m.get('x-oss-request-id')
        if m.get('CompleteMultipartUploadResult') is not None:
            temp_model = CompleteMultipartUploadResponseCompleteMultipartUploadResult()
            self.complete_multipart_upload_result = temp_model.from_map(m['CompleteMultipartUploadResult'])
        return self


class PutBucketLoggingRequestBodyBucketLoggingStatusLoggingEnabled(TeaModel):
    def __init__(
        self,
        target_bucket: str = None,
        target_prefix: str = None,
    ):
        # TargetBucket
        self.target_bucket = target_bucket
        # TargetPrefix
        self.target_prefix = target_prefix

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.target_bucket is not None:
            result['TargetBucket'] = self.target_bucket
        if self.target_prefix is not None:
            result['TargetPrefix'] = self.target_prefix
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('TargetBucket') is not None:
            self.target_bucket = m.get('TargetBucket')
        if m.get('TargetPrefix') is not None:
            self.target_prefix = m.get('TargetPrefix')
        return self


class PutBucketLoggingRequestBodyBucketLoggingStatus(TeaModel):
    def __init__(
        self,
        logging_enabled: PutBucketLoggingRequestBodyBucketLoggingStatusLoggingEnabled = None,
    ):
        # LoggingEnabled
        self.logging_enabled = logging_enabled

    def validate(self):
        if self.logging_enabled:
            self.logging_enabled.validate()

    def to_map(self):
        result = dict()
        if self.logging_enabled is not None:
            result['LoggingEnabled'] = self.logging_enabled.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('LoggingEnabled') is not None:
            temp_model = PutBucketLoggingRequestBodyBucketLoggingStatusLoggingEnabled()
            self.logging_enabled = temp_model.from_map(m['LoggingEnabled'])
        return self


class PutBucketLoggingRequestBody(TeaModel):
    def __init__(
        self,
        bucket_logging_status: PutBucketLoggingRequestBodyBucketLoggingStatus = None,
    ):
        # BucketLoggingStatus
        self.bucket_logging_status = bucket_logging_status

    def validate(self):
        self.validate_required(self.bucket_logging_status, 'bucket_logging_status')
        if self.bucket_logging_status:
            self.bucket_logging_status.validate()

    def to_map(self):
        result = dict()
        if self.bucket_logging_status is not None:
            result['BucketLoggingStatus'] = self.bucket_logging_status.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('BucketLoggingStatus') is not None:
            temp_model = PutBucketLoggingRequestBodyBucketLoggingStatus()
            self.bucket_logging_status = temp_model.from_map(m['BucketLoggingStatus'])
        return self


class PutBucketLoggingRequest(TeaModel):
    def __init__(
        self,
        bucket_name: str = None,
        body: PutBucketLoggingRequestBody = None,
    ):
        # BucketName
        self.bucket_name = bucket_name
        # Body
        self.body = body

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')
        if self.bucket_name is not None:
            self.validate_pattern(self.bucket_name, 'bucket_name', '[a-zA-Z0-9-_]+')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = dict()
        if self.bucket_name is not None:
            result['BucketName'] = self.bucket_name
        if self.body is not None:
            result['Body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('BucketName') is not None:
            self.bucket_name = m.get('BucketName')
        if m.get('Body') is not None:
            temp_model = PutBucketLoggingRequestBody()
            self.body = temp_model.from_map(m['Body'])
        return self


class PutBucketLoggingResponse(TeaModel):
    def __init__(
        self,
        request_id: str = None,
    ):
        # x-oss-request-id
        self.request_id = request_id

    def validate(self):
        self.validate_required(self.request_id, 'request_id')

    def to_map(self):
        result = dict()
        if self.request_id is not None:
            result['x-oss-request-id'] = self.request_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('x-oss-request-id') is not None:
            self.request_id = m.get('x-oss-request-id')
        return self


class PutBucketRequestPaymentRequestBodyRequestPaymentConfiguration(TeaModel):
    def __init__(
        self,
        payer: str = None,
    ):
        # Payer
        self.payer = payer

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.payer is not None:
            result['Payer'] = self.payer
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('Payer') is not None:
            self.payer = m.get('Payer')
        return self


class PutBucketRequestPaymentRequestBody(TeaModel):
    def __init__(
        self,
        request_payment_configuration: PutBucketRequestPaymentRequestBodyRequestPaymentConfiguration = None,
    ):
        # RequestPaymentConfiguration
        self.request_payment_configuration = request_payment_configuration

    def validate(self):
        self.validate_required(self.request_payment_configuration, 'request_payment_configuration')
        if self.request_payment_configuration:
            self.request_payment_configuration.validate()

    def to_map(self):
        result = dict()
        if self.request_payment_configuration is not None:
            result['RequestPaymentConfiguration'] = self.request_payment_configuration.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('RequestPaymentConfiguration') is not None:
            temp_model = PutBucketRequestPaymentRequestBodyRequestPaymentConfiguration()
            self.request_payment_configuration = temp_model.from_map(m['RequestPaymentConfiguration'])
        return self


class PutBucketRequestPaymentRequest(TeaModel):
    def __init__(
        self,
        bucket_name: str = None,
        body: PutBucketRequestPaymentRequestBody = None,
    ):
        # BucketName
        self.bucket_name = bucket_name
        # Body
        self.body = body

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')
        if self.bucket_name is not None:
            self.validate_pattern(self.bucket_name, 'bucket_name', '[a-zA-Z0-9-_]+')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = dict()
        if self.bucket_name is not None:
            result['BucketName'] = self.bucket_name
        if self.body is not None:
            result['Body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('BucketName') is not None:
            self.bucket_name = m.get('BucketName')
        if m.get('Body') is not None:
            temp_model = PutBucketRequestPaymentRequestBody()
            self.body = temp_model.from_map(m['Body'])
        return self


class PutBucketRequestPaymentResponse(TeaModel):
    def __init__(
        self,
        request_id: str = None,
    ):
        # x-oss-request-id
        self.request_id = request_id

    def validate(self):
        self.validate_required(self.request_id, 'request_id')

    def to_map(self):
        result = dict()
        if self.request_id is not None:
            result['x-oss-request-id'] = self.request_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('x-oss-request-id') is not None:
            self.request_id = m.get('x-oss-request-id')
        return self


class PutBucketEncryptionRequestBodyServerSideEncryptionRuleApplyServerSideEncryptionByDefault(TeaModel):
    def __init__(
        self,
        s_sealgorithm: str = None,
        k_msmaster_key_id: str = None,
    ):
        # SSEAlgorithm
        self.s_sealgorithm = s_sealgorithm
        # KMSMasterKeyID
        self.k_msmaster_key_id = k_msmaster_key_id

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.s_sealgorithm is not None:
            result['SSEAlgorithm'] = self.s_sealgorithm
        if self.k_msmaster_key_id is not None:
            result['KMSMasterKeyID'] = self.k_msmaster_key_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('SSEAlgorithm') is not None:
            self.s_sealgorithm = m.get('SSEAlgorithm')
        if m.get('KMSMasterKeyID') is not None:
            self.k_msmaster_key_id = m.get('KMSMasterKeyID')
        return self


class PutBucketEncryptionRequestBodyServerSideEncryptionRule(TeaModel):
    def __init__(
        self,
        apply_server_side_encryption_by_default: PutBucketEncryptionRequestBodyServerSideEncryptionRuleApplyServerSideEncryptionByDefault = None,
    ):
        # ApplyServerSideEncryptionByDefault
        self.apply_server_side_encryption_by_default = apply_server_side_encryption_by_default

    def validate(self):
        if self.apply_server_side_encryption_by_default:
            self.apply_server_side_encryption_by_default.validate()

    def to_map(self):
        result = dict()
        if self.apply_server_side_encryption_by_default is not None:
            result['ApplyServerSideEncryptionByDefault'] = self.apply_server_side_encryption_by_default.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('ApplyServerSideEncryptionByDefault') is not None:
            temp_model = PutBucketEncryptionRequestBodyServerSideEncryptionRuleApplyServerSideEncryptionByDefault()
            self.apply_server_side_encryption_by_default = temp_model.from_map(m['ApplyServerSideEncryptionByDefault'])
        return self


class PutBucketEncryptionRequestBody(TeaModel):
    def __init__(
        self,
        server_side_encryption_rule: PutBucketEncryptionRequestBodyServerSideEncryptionRule = None,
    ):
        # ServerSideEncryptionRule
        self.server_side_encryption_rule = server_side_encryption_rule

    def validate(self):
        self.validate_required(self.server_side_encryption_rule, 'server_side_encryption_rule')
        if self.server_side_encryption_rule:
            self.server_side_encryption_rule.validate()

    def to_map(self):
        result = dict()
        if self.server_side_encryption_rule is not None:
            result['ServerSideEncryptionRule'] = self.server_side_encryption_rule.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('ServerSideEncryptionRule') is not None:
            temp_model = PutBucketEncryptionRequestBodyServerSideEncryptionRule()
            self.server_side_encryption_rule = temp_model.from_map(m['ServerSideEncryptionRule'])
        return self


class PutBucketEncryptionRequest(TeaModel):
    def __init__(
        self,
        bucket_name: str = None,
        body: PutBucketEncryptionRequestBody = None,
    ):
        # BucketName
        self.bucket_name = bucket_name
        # Body
        self.body = body

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')
        if self.bucket_name is not None:
            self.validate_pattern(self.bucket_name, 'bucket_name', '[a-zA-Z0-9-_]+')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = dict()
        if self.bucket_name is not None:
            result['BucketName'] = self.bucket_name
        if self.body is not None:
            result['Body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('BucketName') is not None:
            self.bucket_name = m.get('BucketName')
        if m.get('Body') is not None:
            temp_model = PutBucketEncryptionRequestBody()
            self.body = temp_model.from_map(m['Body'])
        return self


class PutBucketEncryptionResponse(TeaModel):
    def __init__(
        self,
        request_id: str = None,
    ):
        # x-oss-request-id
        self.request_id = request_id

    def validate(self):
        self.validate_required(self.request_id, 'request_id')

    def to_map(self):
        result = dict()
        if self.request_id is not None:
            result['x-oss-request-id'] = self.request_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('x-oss-request-id') is not None:
            self.request_id = m.get('x-oss-request-id')
        return self


class PutLiveChannelRequestBodyLiveChannelConfigurationTarget(TeaModel):
    def __init__(
        self,
        type: str = None,
        frag_duration: str = None,
        frag_count: str = None,
        playlist_name: str = None,
    ):
        # Type
        self.type = type
        # FragDuration
        self.frag_duration = frag_duration
        # FragCount
        self.frag_count = frag_count
        # PlaylistName
        self.playlist_name = playlist_name

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.type is not None:
            result['Type'] = self.type
        if self.frag_duration is not None:
            result['FragDuration'] = self.frag_duration
        if self.frag_count is not None:
            result['FragCount'] = self.frag_count
        if self.playlist_name is not None:
            result['PlaylistName'] = self.playlist_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('Type') is not None:
            self.type = m.get('Type')
        if m.get('FragDuration') is not None:
            self.frag_duration = m.get('FragDuration')
        if m.get('FragCount') is not None:
            self.frag_count = m.get('FragCount')
        if m.get('PlaylistName') is not None:
            self.playlist_name = m.get('PlaylistName')
        return self


class PutLiveChannelRequestBodyLiveChannelConfigurationSnapshot(TeaModel):
    def __init__(
        self,
        role_name: str = None,
        dest_bucket: str = None,
        notify_topic: str = None,
        interval: str = None,
    ):
        # RoleName
        self.role_name = role_name
        # DestBucket
        self.dest_bucket = dest_bucket
        # NotifyTopic
        self.notify_topic = notify_topic
        # Interval
        self.interval = interval

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.role_name is not None:
            result['RoleName'] = self.role_name
        if self.dest_bucket is not None:
            result['DestBucket'] = self.dest_bucket
        if self.notify_topic is not None:
            result['NotifyTopic'] = self.notify_topic
        if self.interval is not None:
            result['Interval'] = self.interval
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('RoleName') is not None:
            self.role_name = m.get('RoleName')
        if m.get('DestBucket') is not None:
            self.dest_bucket = m.get('DestBucket')
        if m.get('NotifyTopic') is not None:
            self.notify_topic = m.get('NotifyTopic')
        if m.get('Interval') is not None:
            self.interval = m.get('Interval')
        return self


class PutLiveChannelRequestBodyLiveChannelConfiguration(TeaModel):
    def __init__(
        self,
        target: PutLiveChannelRequestBodyLiveChannelConfigurationTarget = None,
        snapshot: PutLiveChannelRequestBodyLiveChannelConfigurationSnapshot = None,
        description: str = None,
        status: str = None,
    ):
        # Target
        self.target = target
        # Snapshot
        self.snapshot = snapshot
        # Description
        self.description = description
        # Status
        self.status = status

    def validate(self):
        if self.target:
            self.target.validate()
        if self.snapshot:
            self.snapshot.validate()

    def to_map(self):
        result = dict()
        if self.target is not None:
            result['Target'] = self.target.to_map()
        if self.snapshot is not None:
            result['Snapshot'] = self.snapshot.to_map()
        if self.description is not None:
            result['Description'] = self.description
        if self.status is not None:
            result['Status'] = self.status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('Target') is not None:
            temp_model = PutLiveChannelRequestBodyLiveChannelConfigurationTarget()
            self.target = temp_model.from_map(m['Target'])
        if m.get('Snapshot') is not None:
            temp_model = PutLiveChannelRequestBodyLiveChannelConfigurationSnapshot()
            self.snapshot = temp_model.from_map(m['Snapshot'])
        if m.get('Description') is not None:
            self.description = m.get('Description')
        if m.get('Status') is not None:
            self.status = m.get('Status')
        return self


class PutLiveChannelRequestBody(TeaModel):
    def __init__(
        self,
        live_channel_configuration: PutLiveChannelRequestBodyLiveChannelConfiguration = None,
    ):
        # LiveChannelConfiguration
        self.live_channel_configuration = live_channel_configuration

    def validate(self):
        self.validate_required(self.live_channel_configuration, 'live_channel_configuration')
        if self.live_channel_configuration:
            self.live_channel_configuration.validate()

    def to_map(self):
        result = dict()
        if self.live_channel_configuration is not None:
            result['LiveChannelConfiguration'] = self.live_channel_configuration.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('LiveChannelConfiguration') is not None:
            temp_model = PutLiveChannelRequestBodyLiveChannelConfiguration()
            self.live_channel_configuration = temp_model.from_map(m['LiveChannelConfiguration'])
        return self


class PutLiveChannelRequest(TeaModel):
    def __init__(
        self,
        bucket_name: str = None,
        channel_name: str = None,
        body: PutLiveChannelRequestBody = None,
    ):
        # BucketName
        self.bucket_name = bucket_name
        # ChannelName
        self.channel_name = channel_name
        # Body
        self.body = body

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')
        if self.bucket_name is not None:
            self.validate_pattern(self.bucket_name, 'bucket_name', '[a-zA-Z0-9-_]+')
        self.validate_required(self.channel_name, 'channel_name')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = dict()
        if self.bucket_name is not None:
            result['BucketName'] = self.bucket_name
        if self.channel_name is not None:
            result['ChannelName'] = self.channel_name
        if self.body is not None:
            result['Body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('BucketName') is not None:
            self.bucket_name = m.get('BucketName')
        if m.get('ChannelName') is not None:
            self.channel_name = m.get('ChannelName')
        if m.get('Body') is not None:
            temp_model = PutLiveChannelRequestBody()
            self.body = temp_model.from_map(m['Body'])
        return self


class PutLiveChannelResponseCreateLiveChannelResultPublishUrls(TeaModel):
    def __init__(
        self,
        url: str = None,
    ):
        # Url
        self.url = url

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.url is not None:
            result['Url'] = self.url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('Url') is not None:
            self.url = m.get('Url')
        return self


class PutLiveChannelResponseCreateLiveChannelResultPlayUrls(TeaModel):
    def __init__(
        self,
        url: str = None,
    ):
        # Url
        self.url = url

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.url is not None:
            result['Url'] = self.url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('Url') is not None:
            self.url = m.get('Url')
        return self


class PutLiveChannelResponseCreateLiveChannelResult(TeaModel):
    def __init__(
        self,
        publish_urls: PutLiveChannelResponseCreateLiveChannelResultPublishUrls = None,
        play_urls: PutLiveChannelResponseCreateLiveChannelResultPlayUrls = None,
    ):
        # PublishUrls
        self.publish_urls = publish_urls
        # PlayUrls
        self.play_urls = play_urls

    def validate(self):
        self.validate_required(self.publish_urls, 'publish_urls')
        if self.publish_urls:
            self.publish_urls.validate()
        self.validate_required(self.play_urls, 'play_urls')
        if self.play_urls:
            self.play_urls.validate()

    def to_map(self):
        result = dict()
        if self.publish_urls is not None:
            result['PublishUrls'] = self.publish_urls.to_map()
        if self.play_urls is not None:
            result['PlayUrls'] = self.play_urls.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('PublishUrls') is not None:
            temp_model = PutLiveChannelResponseCreateLiveChannelResultPublishUrls()
            self.publish_urls = temp_model.from_map(m['PublishUrls'])
        if m.get('PlayUrls') is not None:
            temp_model = PutLiveChannelResponseCreateLiveChannelResultPlayUrls()
            self.play_urls = temp_model.from_map(m['PlayUrls'])
        return self


class PutLiveChannelResponse(TeaModel):
    def __init__(
        self,
        request_id: str = None,
        create_live_channel_result: PutLiveChannelResponseCreateLiveChannelResult = None,
    ):
        # x-oss-request-id
        self.request_id = request_id
        # CreateLiveChannelResult
        self.create_live_channel_result = create_live_channel_result

    def validate(self):
        self.validate_required(self.request_id, 'request_id')
        self.validate_required(self.create_live_channel_result, 'create_live_channel_result')
        if self.create_live_channel_result:
            self.create_live_channel_result.validate()

    def to_map(self):
        result = dict()
        if self.request_id is not None:
            result['x-oss-request-id'] = self.request_id
        if self.create_live_channel_result is not None:
            result['CreateLiveChannelResult'] = self.create_live_channel_result.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('x-oss-request-id') is not None:
            self.request_id = m.get('x-oss-request-id')
        if m.get('CreateLiveChannelResult') is not None:
            temp_model = PutLiveChannelResponseCreateLiveChannelResult()
            self.create_live_channel_result = temp_model.from_map(m['CreateLiveChannelResult'])
        return self


class PutBucketTagsRequestBodyTaggingTagSetTag(TeaModel):
    def __init__(
        self,
        key: str = None,
        value: str = None,
    ):
        # Key
        self.key = key
        # Value
        self.value = value

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.key is not None:
            result['Key'] = self.key
        if self.value is not None:
            result['Value'] = self.value
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('Key') is not None:
            self.key = m.get('Key')
        if m.get('Value') is not None:
            self.value = m.get('Value')
        return self


class PutBucketTagsRequestBodyTaggingTagSet(TeaModel):
    def __init__(
        self,
        tag: List[PutBucketTagsRequestBodyTaggingTagSetTag] = None,
    ):
        # Tag
        self.tag = tag

    def validate(self):
        if self.tag:
            for k in self.tag:
                if k:
                    k.validate()

    def to_map(self):
        result = dict()
        result['Tag'] = []
        if self.tag is not None:
            for k in self.tag:
                result['Tag'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.tag = []
        if m.get('Tag') is not None:
            for k in m.get('Tag'):
                temp_model = PutBucketTagsRequestBodyTaggingTagSetTag()
                self.tag.append(temp_model.from_map(k))
        return self


class PutBucketTagsRequestBodyTagging(TeaModel):
    def __init__(
        self,
        tag_set: PutBucketTagsRequestBodyTaggingTagSet = None,
    ):
        # TagSet
        self.tag_set = tag_set

    def validate(self):
        if self.tag_set:
            self.tag_set.validate()

    def to_map(self):
        result = dict()
        if self.tag_set is not None:
            result['TagSet'] = self.tag_set.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('TagSet') is not None:
            temp_model = PutBucketTagsRequestBodyTaggingTagSet()
            self.tag_set = temp_model.from_map(m['TagSet'])
        return self


class PutBucketTagsRequestBody(TeaModel):
    def __init__(
        self,
        tagging: PutBucketTagsRequestBodyTagging = None,
    ):
        # Tagging
        self.tagging = tagging

    def validate(self):
        self.validate_required(self.tagging, 'tagging')
        if self.tagging:
            self.tagging.validate()

    def to_map(self):
        result = dict()
        if self.tagging is not None:
            result['Tagging'] = self.tagging.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('Tagging') is not None:
            temp_model = PutBucketTagsRequestBodyTagging()
            self.tagging = temp_model.from_map(m['Tagging'])
        return self


class PutBucketTagsRequest(TeaModel):
    def __init__(
        self,
        bucket_name: str = None,
        body: PutBucketTagsRequestBody = None,
    ):
        # BucketName
        self.bucket_name = bucket_name
        # Body
        self.body = body

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')
        if self.bucket_name is not None:
            self.validate_pattern(self.bucket_name, 'bucket_name', '[a-zA-Z0-9-_]+')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = dict()
        if self.bucket_name is not None:
            result['BucketName'] = self.bucket_name
        if self.body is not None:
            result['Body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('BucketName') is not None:
            self.bucket_name = m.get('BucketName')
        if m.get('Body') is not None:
            temp_model = PutBucketTagsRequestBody()
            self.body = temp_model.from_map(m['Body'])
        return self


class PutBucketTagsResponse(TeaModel):
    def __init__(
        self,
        request_id: str = None,
    ):
        # x-oss-request-id
        self.request_id = request_id

    def validate(self):
        self.validate_required(self.request_id, 'request_id')

    def to_map(self):
        result = dict()
        if self.request_id is not None:
            result['x-oss-request-id'] = self.request_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('x-oss-request-id') is not None:
            self.request_id = m.get('x-oss-request-id')
        return self


class PutObjectTaggingRequestBodyTaggingTagSetTag(TeaModel):
    def __init__(
        self,
        key: str = None,
        value: str = None,
    ):
        # Key
        self.key = key
        # Value
        self.value = value

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.key is not None:
            result['Key'] = self.key
        if self.value is not None:
            result['Value'] = self.value
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('Key') is not None:
            self.key = m.get('Key')
        if m.get('Value') is not None:
            self.value = m.get('Value')
        return self


class PutObjectTaggingRequestBodyTaggingTagSet(TeaModel):
    def __init__(
        self,
        tag: List[PutObjectTaggingRequestBodyTaggingTagSetTag] = None,
    ):
        # Tag
        self.tag = tag

    def validate(self):
        if self.tag:
            for k in self.tag:
                if k:
                    k.validate()

    def to_map(self):
        result = dict()
        result['Tag'] = []
        if self.tag is not None:
            for k in self.tag:
                result['Tag'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.tag = []
        if m.get('Tag') is not None:
            for k in m.get('Tag'):
                temp_model = PutObjectTaggingRequestBodyTaggingTagSetTag()
                self.tag.append(temp_model.from_map(k))
        return self


class PutObjectTaggingRequestBodyTagging(TeaModel):
    def __init__(
        self,
        tag_set: PutObjectTaggingRequestBodyTaggingTagSet = None,
    ):
        # TagSet
        self.tag_set = tag_set

    def validate(self):
        if self.tag_set:
            self.tag_set.validate()

    def to_map(self):
        result = dict()
        if self.tag_set is not None:
            result['TagSet'] = self.tag_set.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('TagSet') is not None:
            temp_model = PutObjectTaggingRequestBodyTaggingTagSet()
            self.tag_set = temp_model.from_map(m['TagSet'])
        return self


class PutObjectTaggingRequestBody(TeaModel):
    def __init__(
        self,
        tagging: PutObjectTaggingRequestBodyTagging = None,
    ):
        # Tagging
        self.tagging = tagging

    def validate(self):
        self.validate_required(self.tagging, 'tagging')
        if self.tagging:
            self.tagging.validate()

    def to_map(self):
        result = dict()
        if self.tagging is not None:
            result['Tagging'] = self.tagging.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('Tagging') is not None:
            temp_model = PutObjectTaggingRequestBodyTagging()
            self.tagging = temp_model.from_map(m['Tagging'])
        return self


class PutObjectTaggingRequest(TeaModel):
    def __init__(
        self,
        bucket_name: str = None,
        object_name: str = None,
        body: PutObjectTaggingRequestBody = None,
    ):
        # BucketName
        self.bucket_name = bucket_name
        # ObjectName
        self.object_name = object_name
        # Body
        self.body = body

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')
        if self.bucket_name is not None:
            self.validate_pattern(self.bucket_name, 'bucket_name', '[a-zA-Z0-9-_]+')
        self.validate_required(self.object_name, 'object_name')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = dict()
        if self.bucket_name is not None:
            result['BucketName'] = self.bucket_name
        if self.object_name is not None:
            result['ObjectName'] = self.object_name
        if self.body is not None:
            result['Body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('BucketName') is not None:
            self.bucket_name = m.get('BucketName')
        if m.get('ObjectName') is not None:
            self.object_name = m.get('ObjectName')
        if m.get('Body') is not None:
            temp_model = PutObjectTaggingRequestBody()
            self.body = temp_model.from_map(m['Body'])
        return self


class PutObjectTaggingResponse(TeaModel):
    def __init__(
        self,
        request_id: str = None,
    ):
        # x-oss-request-id
        self.request_id = request_id

    def validate(self):
        self.validate_required(self.request_id, 'request_id')

    def to_map(self):
        result = dict()
        if self.request_id is not None:
            result['x-oss-request-id'] = self.request_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('x-oss-request-id') is not None:
            self.request_id = m.get('x-oss-request-id')
        return self


class SelectObjectRequestFilter(TeaModel):
    def __init__(
        self,
        porcess: str = None,
    ):
        # x-oss-process
        self.porcess = porcess

    def validate(self):
        self.validate_required(self.porcess, 'porcess')

    def to_map(self):
        result = dict()
        if self.porcess is not None:
            result['x-oss-process'] = self.porcess
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('x-oss-process') is not None:
            self.porcess = m.get('x-oss-process')
        return self


class SelectObjectRequestBodySelectRequestInputSerializationCSV(TeaModel):
    def __init__(
        self,
        file_header_info: str = None,
        record_delimiter: str = None,
        field_delimiter: str = None,
        quote_character: str = None,
        comment_character: str = None,
        range: str = None,
    ):
        # FileHeaderInfo
        self.file_header_info = file_header_info
        # RecordDelimiter
        self.record_delimiter = record_delimiter
        # FieldDelimiter
        self.field_delimiter = field_delimiter
        # QuoteCharacter
        self.quote_character = quote_character
        # CommentCharacter
        self.comment_character = comment_character
        # Range
        self.range = range

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.file_header_info is not None:
            result['FileHeaderInfo'] = self.file_header_info
        if self.record_delimiter is not None:
            result['RecordDelimiter'] = self.record_delimiter
        if self.field_delimiter is not None:
            result['FieldDelimiter'] = self.field_delimiter
        if self.quote_character is not None:
            result['QuoteCharacter'] = self.quote_character
        if self.comment_character is not None:
            result['CommentCharacter'] = self.comment_character
        if self.range is not None:
            result['Range'] = self.range
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('FileHeaderInfo') is not None:
            self.file_header_info = m.get('FileHeaderInfo')
        if m.get('RecordDelimiter') is not None:
            self.record_delimiter = m.get('RecordDelimiter')
        if m.get('FieldDelimiter') is not None:
            self.field_delimiter = m.get('FieldDelimiter')
        if m.get('QuoteCharacter') is not None:
            self.quote_character = m.get('QuoteCharacter')
        if m.get('CommentCharacter') is not None:
            self.comment_character = m.get('CommentCharacter')
        if m.get('Range') is not None:
            self.range = m.get('Range')
        return self


class SelectObjectRequestBodySelectRequestInputSerialization(TeaModel):
    def __init__(
        self,
        c_sv: SelectObjectRequestBodySelectRequestInputSerializationCSV = None,
        compression_type: str = None,
    ):
        # CSV
        self.c_sv = c_sv
        # CompressionType
        self.compression_type = compression_type

    def validate(self):
        if self.c_sv:
            self.c_sv.validate()

    def to_map(self):
        result = dict()
        if self.c_sv is not None:
            result['CSV'] = self.c_sv.to_map()
        if self.compression_type is not None:
            result['CompressionType'] = self.compression_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('CSV') is not None:
            temp_model = SelectObjectRequestBodySelectRequestInputSerializationCSV()
            self.c_sv = temp_model.from_map(m['CSV'])
        if m.get('CompressionType') is not None:
            self.compression_type = m.get('CompressionType')
        return self


class SelectObjectRequestBodySelectRequestOutputSerializationCSV(TeaModel):
    def __init__(
        self,
        record_delimiter: str = None,
        field_delimiter: str = None,
    ):
        # RecordDelimiter
        self.record_delimiter = record_delimiter
        # FieldDelimiter
        self.field_delimiter = field_delimiter

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.record_delimiter is not None:
            result['RecordDelimiter'] = self.record_delimiter
        if self.field_delimiter is not None:
            result['FieldDelimiter'] = self.field_delimiter
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('RecordDelimiter') is not None:
            self.record_delimiter = m.get('RecordDelimiter')
        if m.get('FieldDelimiter') is not None:
            self.field_delimiter = m.get('FieldDelimiter')
        return self


class SelectObjectRequestBodySelectRequestOutputSerialization(TeaModel):
    def __init__(
        self,
        c_sv: SelectObjectRequestBodySelectRequestOutputSerializationCSV = None,
        keep_all_columns: str = None,
        output_raw_data: str = None,
        enable_payload_crc: str = None,
        output_header: str = None,
    ):
        # CSV
        self.c_sv = c_sv
        # KeepAllColumns
        self.keep_all_columns = keep_all_columns
        # OutputRawData
        self.output_raw_data = output_raw_data
        # EnablePayloadCrc
        self.enable_payload_crc = enable_payload_crc
        # OutputHeader
        self.output_header = output_header

    def validate(self):
        if self.c_sv:
            self.c_sv.validate()

    def to_map(self):
        result = dict()
        if self.c_sv is not None:
            result['CSV'] = self.c_sv.to_map()
        if self.keep_all_columns is not None:
            result['KeepAllColumns'] = self.keep_all_columns
        if self.output_raw_data is not None:
            result['OutputRawData'] = self.output_raw_data
        if self.enable_payload_crc is not None:
            result['EnablePayloadCrc'] = self.enable_payload_crc
        if self.output_header is not None:
            result['OutputHeader'] = self.output_header
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('CSV') is not None:
            temp_model = SelectObjectRequestBodySelectRequestOutputSerializationCSV()
            self.c_sv = temp_model.from_map(m['CSV'])
        if m.get('KeepAllColumns') is not None:
            self.keep_all_columns = m.get('KeepAllColumns')
        if m.get('OutputRawData') is not None:
            self.output_raw_data = m.get('OutputRawData')
        if m.get('EnablePayloadCrc') is not None:
            self.enable_payload_crc = m.get('EnablePayloadCrc')
        if m.get('OutputHeader') is not None:
            self.output_header = m.get('OutputHeader')
        return self


class SelectObjectRequestBodySelectRequestOptions(TeaModel):
    def __init__(
        self,
        skip_partial_data_record: str = None,
        max_skipped_records_allowed: str = None,
    ):
        # SkipPartialDataRecord
        self.skip_partial_data_record = skip_partial_data_record
        # MaxSkippedRecordsAllowed
        self.max_skipped_records_allowed = max_skipped_records_allowed

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.skip_partial_data_record is not None:
            result['SkipPartialDataRecord'] = self.skip_partial_data_record
        if self.max_skipped_records_allowed is not None:
            result['MaxSkippedRecordsAllowed'] = self.max_skipped_records_allowed
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('SkipPartialDataRecord') is not None:
            self.skip_partial_data_record = m.get('SkipPartialDataRecord')
        if m.get('MaxSkippedRecordsAllowed') is not None:
            self.max_skipped_records_allowed = m.get('MaxSkippedRecordsAllowed')
        return self


class SelectObjectRequestBodySelectRequest(TeaModel):
    def __init__(
        self,
        input_serialization: SelectObjectRequestBodySelectRequestInputSerialization = None,
        output_serialization: SelectObjectRequestBodySelectRequestOutputSerialization = None,
        options: SelectObjectRequestBodySelectRequestOptions = None,
        expression: str = None,
    ):
        # InputSerialization
        self.input_serialization = input_serialization
        # OutputSerialization
        self.output_serialization = output_serialization
        # Options
        self.options = options
        # Expression
        self.expression = expression

    def validate(self):
        if self.input_serialization:
            self.input_serialization.validate()
        if self.output_serialization:
            self.output_serialization.validate()
        if self.options:
            self.options.validate()

    def to_map(self):
        result = dict()
        if self.input_serialization is not None:
            result['InputSerialization'] = self.input_serialization.to_map()
        if self.output_serialization is not None:
            result['OutputSerialization'] = self.output_serialization.to_map()
        if self.options is not None:
            result['Options'] = self.options.to_map()
        if self.expression is not None:
            result['Expression'] = self.expression
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('InputSerialization') is not None:
            temp_model = SelectObjectRequestBodySelectRequestInputSerialization()
            self.input_serialization = temp_model.from_map(m['InputSerialization'])
        if m.get('OutputSerialization') is not None:
            temp_model = SelectObjectRequestBodySelectRequestOutputSerialization()
            self.output_serialization = temp_model.from_map(m['OutputSerialization'])
        if m.get('Options') is not None:
            temp_model = SelectObjectRequestBodySelectRequestOptions()
            self.options = temp_model.from_map(m['Options'])
        if m.get('Expression') is not None:
            self.expression = m.get('Expression')
        return self


class SelectObjectRequestBody(TeaModel):
    def __init__(
        self,
        select_request: SelectObjectRequestBodySelectRequest = None,
    ):
        # SelectRequest
        self.select_request = select_request

    def validate(self):
        self.validate_required(self.select_request, 'select_request')
        if self.select_request:
            self.select_request.validate()

    def to_map(self):
        result = dict()
        if self.select_request is not None:
            result['SelectRequest'] = self.select_request.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('SelectRequest') is not None:
            temp_model = SelectObjectRequestBodySelectRequest()
            self.select_request = temp_model.from_map(m['SelectRequest'])
        return self


class SelectObjectRequest(TeaModel):
    def __init__(
        self,
        bucket_name: str = None,
        object_name: str = None,
        filter: SelectObjectRequestFilter = None,
        body: SelectObjectRequestBody = None,
    ):
        # BucketName
        self.bucket_name = bucket_name
        # ObjectName
        self.object_name = object_name
        # Filter
        self.filter = filter
        # Body
        self.body = body

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')
        if self.bucket_name is not None:
            self.validate_pattern(self.bucket_name, 'bucket_name', '[a-zA-Z0-9-_]+')
        self.validate_required(self.object_name, 'object_name')
        self.validate_required(self.filter, 'filter')
        if self.filter:
            self.filter.validate()
        if self.body:
            self.body.validate()

    def to_map(self):
        result = dict()
        if self.bucket_name is not None:
            result['BucketName'] = self.bucket_name
        if self.object_name is not None:
            result['ObjectName'] = self.object_name
        if self.filter is not None:
            result['Filter'] = self.filter.to_map()
        if self.body is not None:
            result['Body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('BucketName') is not None:
            self.bucket_name = m.get('BucketName')
        if m.get('ObjectName') is not None:
            self.object_name = m.get('ObjectName')
        if m.get('Filter') is not None:
            temp_model = SelectObjectRequestFilter()
            self.filter = temp_model.from_map(m['Filter'])
        if m.get('Body') is not None:
            temp_model = SelectObjectRequestBody()
            self.body = temp_model.from_map(m['Body'])
        return self


class SelectObjectResponse(TeaModel):
    def __init__(
        self,
        request_id: str = None,
    ):
        # x-oss-request-id
        self.request_id = request_id

    def validate(self):
        self.validate_required(self.request_id, 'request_id')

    def to_map(self):
        result = dict()
        if self.request_id is not None:
            result['x-oss-request-id'] = self.request_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('x-oss-request-id') is not None:
            self.request_id = m.get('x-oss-request-id')
        return self


class PutBucketCORSRequestBodyCORSConfigurationCORSRule(TeaModel):
    def __init__(
        self,
        allowed_origin: List[str] = None,
        allowed_method: List[str] = None,
        allowed_header: List[str] = None,
        expose_header: List[str] = None,
        max_age_seconds: str = None,
    ):
        # AllowedOrigin
        self.allowed_origin = allowed_origin
        # AllowedMethod
        self.allowed_method = allowed_method
        # AllowedHeader
        self.allowed_header = allowed_header
        # ExposeHeader
        self.expose_header = expose_header
        # MaxAgeSeconds
        self.max_age_seconds = max_age_seconds

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.allowed_origin is not None:
            result['AllowedOrigin'] = self.allowed_origin
        if self.allowed_method is not None:
            result['AllowedMethod'] = self.allowed_method
        if self.allowed_header is not None:
            result['AllowedHeader'] = self.allowed_header
        if self.expose_header is not None:
            result['ExposeHeader'] = self.expose_header
        if self.max_age_seconds is not None:
            result['MaxAgeSeconds'] = self.max_age_seconds
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('AllowedOrigin') is not None:
            self.allowed_origin = m.get('AllowedOrigin')
        if m.get('AllowedMethod') is not None:
            self.allowed_method = m.get('AllowedMethod')
        if m.get('AllowedHeader') is not None:
            self.allowed_header = m.get('AllowedHeader')
        if m.get('ExposeHeader') is not None:
            self.expose_header = m.get('ExposeHeader')
        if m.get('MaxAgeSeconds') is not None:
            self.max_age_seconds = m.get('MaxAgeSeconds')
        return self


class PutBucketCORSRequestBodyCORSConfiguration(TeaModel):
    def __init__(
        self,
        c_orsrule: List[PutBucketCORSRequestBodyCORSConfigurationCORSRule] = None,
    ):
        # CORSRule
        self.c_orsrule = c_orsrule

    def validate(self):
        if self.c_orsrule:
            for k in self.c_orsrule:
                if k:
                    k.validate()

    def to_map(self):
        result = dict()
        result['CORSRule'] = []
        if self.c_orsrule is not None:
            for k in self.c_orsrule:
                result['CORSRule'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.c_orsrule = []
        if m.get('CORSRule') is not None:
            for k in m.get('CORSRule'):
                temp_model = PutBucketCORSRequestBodyCORSConfigurationCORSRule()
                self.c_orsrule.append(temp_model.from_map(k))
        return self


class PutBucketCORSRequestBody(TeaModel):
    def __init__(
        self,
        c_orsconfiguration: PutBucketCORSRequestBodyCORSConfiguration = None,
    ):
        # CORSConfiguration
        self.c_orsconfiguration = c_orsconfiguration

    def validate(self):
        self.validate_required(self.c_orsconfiguration, 'c_orsconfiguration')
        if self.c_orsconfiguration:
            self.c_orsconfiguration.validate()

    def to_map(self):
        result = dict()
        if self.c_orsconfiguration is not None:
            result['CORSConfiguration'] = self.c_orsconfiguration.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('CORSConfiguration') is not None:
            temp_model = PutBucketCORSRequestBodyCORSConfiguration()
            self.c_orsconfiguration = temp_model.from_map(m['CORSConfiguration'])
        return self


class PutBucketCORSRequest(TeaModel):
    def __init__(
        self,
        bucket_name: str = None,
        body: PutBucketCORSRequestBody = None,
    ):
        # BucketName
        self.bucket_name = bucket_name
        # Body
        self.body = body

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')
        if self.bucket_name is not None:
            self.validate_pattern(self.bucket_name, 'bucket_name', '[a-zA-Z0-9-_]+')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = dict()
        if self.bucket_name is not None:
            result['BucketName'] = self.bucket_name
        if self.body is not None:
            result['Body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('BucketName') is not None:
            self.bucket_name = m.get('BucketName')
        if m.get('Body') is not None:
            temp_model = PutBucketCORSRequestBody()
            self.body = temp_model.from_map(m['Body'])
        return self


class PutBucketCORSResponse(TeaModel):
    def __init__(
        self,
        request_id: str = None,
    ):
        # x-oss-request-id
        self.request_id = request_id

    def validate(self):
        self.validate_required(self.request_id, 'request_id')

    def to_map(self):
        result = dict()
        if self.request_id is not None:
            result['x-oss-request-id'] = self.request_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('x-oss-request-id') is not None:
            self.request_id = m.get('x-oss-request-id')
        return self


class PutBucketRequestBodyCreateBucketConfiguration(TeaModel):
    def __init__(
        self,
        storage_class: str = None,
        data_redundancy_type: str = None,
    ):
        # StorageClass
        self.storage_class = storage_class
        # DataRedundancyType
        self.data_redundancy_type = data_redundancy_type

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.storage_class is not None:
            result['StorageClass'] = self.storage_class
        if self.data_redundancy_type is not None:
            result['DataRedundancyType'] = self.data_redundancy_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('StorageClass') is not None:
            self.storage_class = m.get('StorageClass')
        if m.get('DataRedundancyType') is not None:
            self.data_redundancy_type = m.get('DataRedundancyType')
        return self


class PutBucketRequestBody(TeaModel):
    def __init__(
        self,
        create_bucket_configuration: PutBucketRequestBodyCreateBucketConfiguration = None,
    ):
        # CreateBucketConfiguration
        self.create_bucket_configuration = create_bucket_configuration

    def validate(self):
        self.validate_required(self.create_bucket_configuration, 'create_bucket_configuration')
        if self.create_bucket_configuration:
            self.create_bucket_configuration.validate()

    def to_map(self):
        result = dict()
        if self.create_bucket_configuration is not None:
            result['CreateBucketConfiguration'] = self.create_bucket_configuration.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('CreateBucketConfiguration') is not None:
            temp_model = PutBucketRequestBodyCreateBucketConfiguration()
            self.create_bucket_configuration = temp_model.from_map(m['CreateBucketConfiguration'])
        return self


class PutBucketRequestHeader(TeaModel):
    def __init__(
        self,
        acl: str = None,
    ):
        # x-oss-acl
        self.acl = acl

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.acl is not None:
            result['x-oss-acl'] = self.acl
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('x-oss-acl') is not None:
            self.acl = m.get('x-oss-acl')
        return self


class PutBucketRequest(TeaModel):
    def __init__(
        self,
        bucket_name: str = None,
        body: PutBucketRequestBody = None,
        header: PutBucketRequestHeader = None,
    ):
        # BucketName
        self.bucket_name = bucket_name
        # Body
        self.body = body
        # Header
        self.header = header

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')
        if self.bucket_name is not None:
            self.validate_pattern(self.bucket_name, 'bucket_name', '[a-zA-Z0-9-_]+')
        if self.body:
            self.body.validate()
        if self.header:
            self.header.validate()

    def to_map(self):
        result = dict()
        if self.bucket_name is not None:
            result['BucketName'] = self.bucket_name
        if self.body is not None:
            result['Body'] = self.body.to_map()
        if self.header is not None:
            result['Header'] = self.header.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('BucketName') is not None:
            self.bucket_name = m.get('BucketName')
        if m.get('Body') is not None:
            temp_model = PutBucketRequestBody()
            self.body = temp_model.from_map(m['Body'])
        if m.get('Header') is not None:
            temp_model = PutBucketRequestHeader()
            self.header = temp_model.from_map(m['Header'])
        return self


class PutBucketResponse(TeaModel):
    def __init__(
        self,
        request_id: str = None,
    ):
        # x-oss-request-id
        self.request_id = request_id

    def validate(self):
        self.validate_required(self.request_id, 'request_id')

    def to_map(self):
        result = dict()
        if self.request_id is not None:
            result['x-oss-request-id'] = self.request_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('x-oss-request-id') is not None:
            self.request_id = m.get('x-oss-request-id')
        return self


class ListMultipartUploadsRequestFilter(TeaModel):
    def __init__(
        self,
        delimiter: str = None,
        max_uploads: str = None,
        key_marker: str = None,
        prefix: str = None,
        upload_id_marker: str = None,
        encoding_type: str = None,
    ):
        # delimiter
        self.delimiter = delimiter
        # max-uploads
        self.max_uploads = max_uploads
        # key-marker
        self.key_marker = key_marker
        # prefix
        self.prefix = prefix
        # upload-id-marker
        self.upload_id_marker = upload_id_marker
        # encoding-type
        self.encoding_type = encoding_type

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.delimiter is not None:
            result['delimiter'] = self.delimiter
        if self.max_uploads is not None:
            result['max-uploads'] = self.max_uploads
        if self.key_marker is not None:
            result['key-marker'] = self.key_marker
        if self.prefix is not None:
            result['prefix'] = self.prefix
        if self.upload_id_marker is not None:
            result['upload-id-marker'] = self.upload_id_marker
        if self.encoding_type is not None:
            result['encoding-type'] = self.encoding_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('delimiter') is not None:
            self.delimiter = m.get('delimiter')
        if m.get('max-uploads') is not None:
            self.max_uploads = m.get('max-uploads')
        if m.get('key-marker') is not None:
            self.key_marker = m.get('key-marker')
        if m.get('prefix') is not None:
            self.prefix = m.get('prefix')
        if m.get('upload-id-marker') is not None:
            self.upload_id_marker = m.get('upload-id-marker')
        if m.get('encoding-type') is not None:
            self.encoding_type = m.get('encoding-type')
        return self


class ListMultipartUploadsRequest(TeaModel):
    def __init__(
        self,
        bucket_name: str = None,
        filter: ListMultipartUploadsRequestFilter = None,
    ):
        # BucketName
        self.bucket_name = bucket_name
        # Filter
        self.filter = filter

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')
        if self.bucket_name is not None:
            self.validate_pattern(self.bucket_name, 'bucket_name', '[a-zA-Z0-9-_]+')
        if self.filter:
            self.filter.validate()

    def to_map(self):
        result = dict()
        if self.bucket_name is not None:
            result['BucketName'] = self.bucket_name
        if self.filter is not None:
            result['Filter'] = self.filter.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('BucketName') is not None:
            self.bucket_name = m.get('BucketName')
        if m.get('Filter') is not None:
            temp_model = ListMultipartUploadsRequestFilter()
            self.filter = temp_model.from_map(m['Filter'])
        return self


class ListMultipartUploadsResponseListMultipartUploadsResultUpload(TeaModel):
    def __init__(
        self,
        key: str = None,
        upload_id: str = None,
        initiated: str = None,
    ):
        # Key
        self.key = key
        # UploadId
        self.upload_id = upload_id
        # Initiated
        self.initiated = initiated

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.key is not None:
            result['Key'] = self.key
        if self.upload_id is not None:
            result['UploadId'] = self.upload_id
        if self.initiated is not None:
            result['Initiated'] = self.initiated
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('Key') is not None:
            self.key = m.get('Key')
        if m.get('UploadId') is not None:
            self.upload_id = m.get('UploadId')
        if m.get('Initiated') is not None:
            self.initiated = m.get('Initiated')
        return self


class ListMultipartUploadsResponseListMultipartUploadsResult(TeaModel):
    def __init__(
        self,
        bucket: str = None,
        encoding_type: str = None,
        key_marker: str = None,
        upload_id_marker: str = None,
        next_key_marker: str = None,
        next_upload_id_marker: str = None,
        delimiter: str = None,
        max_uploads: str = None,
        is_truncated: str = None,
        upload: List[ListMultipartUploadsResponseListMultipartUploadsResultUpload] = None,
    ):
        # Bucket
        self.bucket = bucket
        # EncodingType
        self.encoding_type = encoding_type
        # KeyMarker
        self.key_marker = key_marker
        # UploadIdMarker
        self.upload_id_marker = upload_id_marker
        # NextKeyMarker
        self.next_key_marker = next_key_marker
        # NextUploadIdMarker
        self.next_upload_id_marker = next_upload_id_marker
        # Delimiter
        self.delimiter = delimiter
        # MaxUploads
        self.max_uploads = max_uploads
        # IsTruncated
        self.is_truncated = is_truncated
        # Upload
        self.upload = upload

    def validate(self):
        if self.upload:
            for k in self.upload:
                if k:
                    k.validate()

    def to_map(self):
        result = dict()
        if self.bucket is not None:
            result['Bucket'] = self.bucket
        if self.encoding_type is not None:
            result['EncodingType'] = self.encoding_type
        if self.key_marker is not None:
            result['KeyMarker'] = self.key_marker
        if self.upload_id_marker is not None:
            result['UploadIdMarker'] = self.upload_id_marker
        if self.next_key_marker is not None:
            result['NextKeyMarker'] = self.next_key_marker
        if self.next_upload_id_marker is not None:
            result['NextUploadIdMarker'] = self.next_upload_id_marker
        if self.delimiter is not None:
            result['Delimiter'] = self.delimiter
        if self.max_uploads is not None:
            result['MaxUploads'] = self.max_uploads
        if self.is_truncated is not None:
            result['IsTruncated'] = self.is_truncated
        result['Upload'] = []
        if self.upload is not None:
            for k in self.upload:
                result['Upload'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('Bucket') is not None:
            self.bucket = m.get('Bucket')
        if m.get('EncodingType') is not None:
            self.encoding_type = m.get('EncodingType')
        if m.get('KeyMarker') is not None:
            self.key_marker = m.get('KeyMarker')
        if m.get('UploadIdMarker') is not None:
            self.upload_id_marker = m.get('UploadIdMarker')
        if m.get('NextKeyMarker') is not None:
            self.next_key_marker = m.get('NextKeyMarker')
        if m.get('NextUploadIdMarker') is not None:
            self.next_upload_id_marker = m.get('NextUploadIdMarker')
        if m.get('Delimiter') is not None:
            self.delimiter = m.get('Delimiter')
        if m.get('MaxUploads') is not None:
            self.max_uploads = m.get('MaxUploads')
        if m.get('IsTruncated') is not None:
            self.is_truncated = m.get('IsTruncated')
        self.upload = []
        if m.get('Upload') is not None:
            for k in m.get('Upload'):
                temp_model = ListMultipartUploadsResponseListMultipartUploadsResultUpload()
                self.upload.append(temp_model.from_map(k))
        return self


class ListMultipartUploadsResponse(TeaModel):
    def __init__(
        self,
        request_id: str = None,
        list_multipart_uploads_result: ListMultipartUploadsResponseListMultipartUploadsResult = None,
    ):
        # x-oss-request-id
        self.request_id = request_id
        # ListMultipartUploadsResult
        self.list_multipart_uploads_result = list_multipart_uploads_result

    def validate(self):
        self.validate_required(self.request_id, 'request_id')
        self.validate_required(self.list_multipart_uploads_result, 'list_multipart_uploads_result')
        if self.list_multipart_uploads_result:
            self.list_multipart_uploads_result.validate()

    def to_map(self):
        result = dict()
        if self.request_id is not None:
            result['x-oss-request-id'] = self.request_id
        if self.list_multipart_uploads_result is not None:
            result['ListMultipartUploadsResult'] = self.list_multipart_uploads_result.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('x-oss-request-id') is not None:
            self.request_id = m.get('x-oss-request-id')
        if m.get('ListMultipartUploadsResult') is not None:
            temp_model = ListMultipartUploadsResponseListMultipartUploadsResult()
            self.list_multipart_uploads_result = temp_model.from_map(m['ListMultipartUploadsResult'])
        return self


class GetBucketRequestPaymentRequest(TeaModel):
    def __init__(
        self,
        bucket_name: str = None,
    ):
        # BucketName
        self.bucket_name = bucket_name

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')
        if self.bucket_name is not None:
            self.validate_pattern(self.bucket_name, 'bucket_name', '[a-zA-Z0-9-_]+')

    def to_map(self):
        result = dict()
        if self.bucket_name is not None:
            result['BucketName'] = self.bucket_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('BucketName') is not None:
            self.bucket_name = m.get('BucketName')
        return self


class GetBucketRequestPaymentResponseRequestPaymentConfiguration(TeaModel):
    def __init__(
        self,
        payer: str = None,
    ):
        # Payer
        self.payer = payer

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.payer is not None:
            result['Payer'] = self.payer
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('Payer') is not None:
            self.payer = m.get('Payer')
        return self


class GetBucketRequestPaymentResponse(TeaModel):
    def __init__(
        self,
        request_id: str = None,
        request_payment_configuration: GetBucketRequestPaymentResponseRequestPaymentConfiguration = None,
    ):
        # x-oss-request-id
        self.request_id = request_id
        # RequestPaymentConfiguration
        self.request_payment_configuration = request_payment_configuration

    def validate(self):
        self.validate_required(self.request_id, 'request_id')
        self.validate_required(self.request_payment_configuration, 'request_payment_configuration')
        if self.request_payment_configuration:
            self.request_payment_configuration.validate()

    def to_map(self):
        result = dict()
        if self.request_id is not None:
            result['x-oss-request-id'] = self.request_id
        if self.request_payment_configuration is not None:
            result['RequestPaymentConfiguration'] = self.request_payment_configuration.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('x-oss-request-id') is not None:
            self.request_id = m.get('x-oss-request-id')
        if m.get('RequestPaymentConfiguration') is not None:
            temp_model = GetBucketRequestPaymentResponseRequestPaymentConfiguration()
            self.request_payment_configuration = temp_model.from_map(m['RequestPaymentConfiguration'])
        return self


class GetBucketEncryptionRequest(TeaModel):
    def __init__(
        self,
        bucket_name: str = None,
    ):
        # BucketName
        self.bucket_name = bucket_name

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')
        if self.bucket_name is not None:
            self.validate_pattern(self.bucket_name, 'bucket_name', '[a-zA-Z0-9-_]+')

    def to_map(self):
        result = dict()
        if self.bucket_name is not None:
            result['BucketName'] = self.bucket_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('BucketName') is not None:
            self.bucket_name = m.get('BucketName')
        return self


class GetBucketEncryptionResponseServerSideEncryptionRuleApplyServerSideEncryptionByDefault(TeaModel):
    def __init__(
        self,
        s_sealgorithm: str = None,
        k_msmaster_key_id: str = None,
    ):
        # SSEAlgorithm
        self.s_sealgorithm = s_sealgorithm
        # KMSMasterKeyID
        self.k_msmaster_key_id = k_msmaster_key_id

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.s_sealgorithm is not None:
            result['SSEAlgorithm'] = self.s_sealgorithm
        if self.k_msmaster_key_id is not None:
            result['KMSMasterKeyID'] = self.k_msmaster_key_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('SSEAlgorithm') is not None:
            self.s_sealgorithm = m.get('SSEAlgorithm')
        if m.get('KMSMasterKeyID') is not None:
            self.k_msmaster_key_id = m.get('KMSMasterKeyID')
        return self


class GetBucketEncryptionResponseServerSideEncryptionRule(TeaModel):
    def __init__(
        self,
        apply_server_side_encryption_by_default: GetBucketEncryptionResponseServerSideEncryptionRuleApplyServerSideEncryptionByDefault = None,
    ):
        # ApplyServerSideEncryptionByDefault
        self.apply_server_side_encryption_by_default = apply_server_side_encryption_by_default

    def validate(self):
        self.validate_required(self.apply_server_side_encryption_by_default, 'apply_server_side_encryption_by_default')
        if self.apply_server_side_encryption_by_default:
            self.apply_server_side_encryption_by_default.validate()

    def to_map(self):
        result = dict()
        if self.apply_server_side_encryption_by_default is not None:
            result['ApplyServerSideEncryptionByDefault'] = self.apply_server_side_encryption_by_default.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('ApplyServerSideEncryptionByDefault') is not None:
            temp_model = GetBucketEncryptionResponseServerSideEncryptionRuleApplyServerSideEncryptionByDefault()
            self.apply_server_side_encryption_by_default = temp_model.from_map(m['ApplyServerSideEncryptionByDefault'])
        return self


class GetBucketEncryptionResponse(TeaModel):
    def __init__(
        self,
        request_id: str = None,
        server_side_encryption_rule: GetBucketEncryptionResponseServerSideEncryptionRule = None,
    ):
        # x-oss-request-id
        self.request_id = request_id
        # ServerSideEncryptionRule
        self.server_side_encryption_rule = server_side_encryption_rule

    def validate(self):
        self.validate_required(self.request_id, 'request_id')
        self.validate_required(self.server_side_encryption_rule, 'server_side_encryption_rule')
        if self.server_side_encryption_rule:
            self.server_side_encryption_rule.validate()

    def to_map(self):
        result = dict()
        if self.request_id is not None:
            result['x-oss-request-id'] = self.request_id
        if self.server_side_encryption_rule is not None:
            result['ServerSideEncryptionRule'] = self.server_side_encryption_rule.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('x-oss-request-id') is not None:
            self.request_id = m.get('x-oss-request-id')
        if m.get('ServerSideEncryptionRule') is not None:
            temp_model = GetBucketEncryptionResponseServerSideEncryptionRule()
            self.server_side_encryption_rule = temp_model.from_map(m['ServerSideEncryptionRule'])
        return self


class GetBucketTagsRequest(TeaModel):
    def __init__(
        self,
        bucket_name: str = None,
    ):
        # BucketName
        self.bucket_name = bucket_name

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')
        if self.bucket_name is not None:
            self.validate_pattern(self.bucket_name, 'bucket_name', '[a-zA-Z0-9-_]+')

    def to_map(self):
        result = dict()
        if self.bucket_name is not None:
            result['BucketName'] = self.bucket_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('BucketName') is not None:
            self.bucket_name = m.get('BucketName')
        return self


class GetBucketTagsResponseTaggingTagSetTag(TeaModel):
    def __init__(
        self,
        key: str = None,
        value: str = None,
    ):
        # Key
        self.key = key
        # Value
        self.value = value

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.key is not None:
            result['Key'] = self.key
        if self.value is not None:
            result['Value'] = self.value
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('Key') is not None:
            self.key = m.get('Key')
        if m.get('Value') is not None:
            self.value = m.get('Value')
        return self


class GetBucketTagsResponseTaggingTagSet(TeaModel):
    def __init__(
        self,
        tag: List[GetBucketTagsResponseTaggingTagSetTag] = None,
    ):
        # Tag
        self.tag = tag

    def validate(self):
        if self.tag:
            for k in self.tag:
                if k:
                    k.validate()

    def to_map(self):
        result = dict()
        result['Tag'] = []
        if self.tag is not None:
            for k in self.tag:
                result['Tag'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.tag = []
        if m.get('Tag') is not None:
            for k in m.get('Tag'):
                temp_model = GetBucketTagsResponseTaggingTagSetTag()
                self.tag.append(temp_model.from_map(k))
        return self


class GetBucketTagsResponseTagging(TeaModel):
    def __init__(
        self,
        tag_set: GetBucketTagsResponseTaggingTagSet = None,
    ):
        # TagSet
        self.tag_set = tag_set

    def validate(self):
        self.validate_required(self.tag_set, 'tag_set')
        if self.tag_set:
            self.tag_set.validate()

    def to_map(self):
        result = dict()
        if self.tag_set is not None:
            result['TagSet'] = self.tag_set.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('TagSet') is not None:
            temp_model = GetBucketTagsResponseTaggingTagSet()
            self.tag_set = temp_model.from_map(m['TagSet'])
        return self


class GetBucketTagsResponse(TeaModel):
    def __init__(
        self,
        request_id: str = None,
        tagging: GetBucketTagsResponseTagging = None,
    ):
        # x-oss-request-id
        self.request_id = request_id
        # Tagging
        self.tagging = tagging

    def validate(self):
        self.validate_required(self.request_id, 'request_id')
        self.validate_required(self.tagging, 'tagging')
        if self.tagging:
            self.tagging.validate()

    def to_map(self):
        result = dict()
        if self.request_id is not None:
            result['x-oss-request-id'] = self.request_id
        if self.tagging is not None:
            result['Tagging'] = self.tagging.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('x-oss-request-id') is not None:
            self.request_id = m.get('x-oss-request-id')
        if m.get('Tagging') is not None:
            temp_model = GetBucketTagsResponseTagging()
            self.tagging = temp_model.from_map(m['Tagging'])
        return self


class GetServiceRequestFilter(TeaModel):
    def __init__(
        self,
        prefix: str = None,
        marker: str = None,
        max_keys: str = None,
    ):
        # prefix
        self.prefix = prefix
        # marker
        self.marker = marker
        # max-keys
        self.max_keys = max_keys

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.prefix is not None:
            result['prefix'] = self.prefix
        if self.marker is not None:
            result['marker'] = self.marker
        if self.max_keys is not None:
            result['max-keys'] = self.max_keys
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('prefix') is not None:
            self.prefix = m.get('prefix')
        if m.get('marker') is not None:
            self.marker = m.get('marker')
        if m.get('max-keys') is not None:
            self.max_keys = m.get('max-keys')
        return self


class GetServiceRequest(TeaModel):
    def __init__(
        self,
        filter: GetServiceRequestFilter = None,
    ):
        # Filter
        self.filter = filter

    def validate(self):
        if self.filter:
            self.filter.validate()

    def to_map(self):
        result = dict()
        if self.filter is not None:
            result['Filter'] = self.filter.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('Filter') is not None:
            temp_model = GetServiceRequestFilter()
            self.filter = temp_model.from_map(m['Filter'])
        return self


class GetServiceResponseListAllMyBucketsResultOwner(TeaModel):
    def __init__(
        self,
        i_d: str = None,
        display_name: str = None,
    ):
        # ID
        self.i_d = i_d
        # DisplayName
        self.display_name = display_name

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.i_d is not None:
            result['ID'] = self.i_d
        if self.display_name is not None:
            result['DisplayName'] = self.display_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('ID') is not None:
            self.i_d = m.get('ID')
        if m.get('DisplayName') is not None:
            self.display_name = m.get('DisplayName')
        return self


class GetServiceResponseListAllMyBucketsResultBucketsBucket(TeaModel):
    def __init__(
        self,
        name: str = None,
        create_date: str = None,
        location: str = None,
        extranet_endpoint: str = None,
        intranet_endpoint: str = None,
        storage_class: str = None,
    ):
        # Name
        self.name = name
        # CreateDate
        self.create_date = create_date
        # Location
        self.location = location
        # ExtranetEndpoint
        self.extranet_endpoint = extranet_endpoint
        # IntranetEndpoint
        self.intranet_endpoint = intranet_endpoint
        # StorageClass
        self.storage_class = storage_class

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.name is not None:
            result['Name'] = self.name
        if self.create_date is not None:
            result['CreateDate'] = self.create_date
        if self.location is not None:
            result['Location'] = self.location
        if self.extranet_endpoint is not None:
            result['ExtranetEndpoint'] = self.extranet_endpoint
        if self.intranet_endpoint is not None:
            result['IntranetEndpoint'] = self.intranet_endpoint
        if self.storage_class is not None:
            result['StorageClass'] = self.storage_class
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('Name') is not None:
            self.name = m.get('Name')
        if m.get('CreateDate') is not None:
            self.create_date = m.get('CreateDate')
        if m.get('Location') is not None:
            self.location = m.get('Location')
        if m.get('ExtranetEndpoint') is not None:
            self.extranet_endpoint = m.get('ExtranetEndpoint')
        if m.get('IntranetEndpoint') is not None:
            self.intranet_endpoint = m.get('IntranetEndpoint')
        if m.get('StorageClass') is not None:
            self.storage_class = m.get('StorageClass')
        return self


class GetServiceResponseListAllMyBucketsResultBuckets(TeaModel):
    def __init__(
        self,
        bucket: List[GetServiceResponseListAllMyBucketsResultBucketsBucket] = None,
    ):
        # Bucket
        self.bucket = bucket

    def validate(self):
        if self.bucket:
            for k in self.bucket:
                if k:
                    k.validate()

    def to_map(self):
        result = dict()
        result['Bucket'] = []
        if self.bucket is not None:
            for k in self.bucket:
                result['Bucket'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.bucket = []
        if m.get('Bucket') is not None:
            for k in m.get('Bucket'):
                temp_model = GetServiceResponseListAllMyBucketsResultBucketsBucket()
                self.bucket.append(temp_model.from_map(k))
        return self


class GetServiceResponseListAllMyBucketsResult(TeaModel):
    def __init__(
        self,
        prefix: str = None,
        marker: str = None,
        max_keys: str = None,
        is_truncated: str = None,
        next_marker: str = None,
        owner: GetServiceResponseListAllMyBucketsResultOwner = None,
        buckets: GetServiceResponseListAllMyBucketsResultBuckets = None,
    ):
        # Prefix
        self.prefix = prefix
        # Marker
        self.marker = marker
        # MaxKeys
        self.max_keys = max_keys
        # IsTruncated
        self.is_truncated = is_truncated
        # NextMarker
        self.next_marker = next_marker
        # Owner
        self.owner = owner
        # Buckets
        self.buckets = buckets

    def validate(self):
        self.validate_required(self.owner, 'owner')
        if self.owner:
            self.owner.validate()
        self.validate_required(self.buckets, 'buckets')
        if self.buckets:
            self.buckets.validate()

    def to_map(self):
        result = dict()
        if self.prefix is not None:
            result['Prefix'] = self.prefix
        if self.marker is not None:
            result['Marker'] = self.marker
        if self.max_keys is not None:
            result['MaxKeys'] = self.max_keys
        if self.is_truncated is not None:
            result['IsTruncated'] = self.is_truncated
        if self.next_marker is not None:
            result['NextMarker'] = self.next_marker
        if self.owner is not None:
            result['Owner'] = self.owner.to_map()
        if self.buckets is not None:
            result['Buckets'] = self.buckets.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('Prefix') is not None:
            self.prefix = m.get('Prefix')
        if m.get('Marker') is not None:
            self.marker = m.get('Marker')
        if m.get('MaxKeys') is not None:
            self.max_keys = m.get('MaxKeys')
        if m.get('IsTruncated') is not None:
            self.is_truncated = m.get('IsTruncated')
        if m.get('NextMarker') is not None:
            self.next_marker = m.get('NextMarker')
        if m.get('Owner') is not None:
            temp_model = GetServiceResponseListAllMyBucketsResultOwner()
            self.owner = temp_model.from_map(m['Owner'])
        if m.get('Buckets') is not None:
            temp_model = GetServiceResponseListAllMyBucketsResultBuckets()
            self.buckets = temp_model.from_map(m['Buckets'])
        return self


class GetServiceResponse(TeaModel):
    def __init__(
        self,
        request_id: str = None,
        list_all_my_buckets_result: GetServiceResponseListAllMyBucketsResult = None,
    ):
        # x-oss-request-id
        self.request_id = request_id
        # ListAllMyBucketsResult
        self.list_all_my_buckets_result = list_all_my_buckets_result

    def validate(self):
        self.validate_required(self.request_id, 'request_id')
        self.validate_required(self.list_all_my_buckets_result, 'list_all_my_buckets_result')
        if self.list_all_my_buckets_result:
            self.list_all_my_buckets_result.validate()

    def to_map(self):
        result = dict()
        if self.request_id is not None:
            result['x-oss-request-id'] = self.request_id
        if self.list_all_my_buckets_result is not None:
            result['ListAllMyBucketsResult'] = self.list_all_my_buckets_result.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('x-oss-request-id') is not None:
            self.request_id = m.get('x-oss-request-id')
        if m.get('ListAllMyBucketsResult') is not None:
            temp_model = GetServiceResponseListAllMyBucketsResult()
            self.list_all_my_buckets_result = temp_model.from_map(m['ListAllMyBucketsResult'])
        return self


class DeleteBucketEncryptionRequest(TeaModel):
    def __init__(
        self,
        bucket_name: str = None,
    ):
        # BucketName
        self.bucket_name = bucket_name

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')
        if self.bucket_name is not None:
            self.validate_pattern(self.bucket_name, 'bucket_name', '[a-zA-Z0-9-_]+')

    def to_map(self):
        result = dict()
        if self.bucket_name is not None:
            result['BucketName'] = self.bucket_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('BucketName') is not None:
            self.bucket_name = m.get('BucketName')
        return self


class DeleteBucketEncryptionResponse(TeaModel):
    def __init__(
        self,
        request_id: str = None,
    ):
        # x-oss-request-id
        self.request_id = request_id

    def validate(self):
        self.validate_required(self.request_id, 'request_id')

    def to_map(self):
        result = dict()
        if self.request_id is not None:
            result['x-oss-request-id'] = self.request_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('x-oss-request-id') is not None:
            self.request_id = m.get('x-oss-request-id')
        return self


class DeleteBucketTagsRequestFilter(TeaModel):
    def __init__(
        self,
        tagging: str = None,
    ):
        # tagging
        self.tagging = tagging

    def validate(self):
        self.validate_required(self.tagging, 'tagging')

    def to_map(self):
        result = dict()
        if self.tagging is not None:
            result['tagging'] = self.tagging
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('tagging') is not None:
            self.tagging = m.get('tagging')
        return self


class DeleteBucketTagsRequest(TeaModel):
    def __init__(
        self,
        bucket_name: str = None,
        filter: DeleteBucketTagsRequestFilter = None,
    ):
        # BucketName
        self.bucket_name = bucket_name
        # Filter
        self.filter = filter

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')
        if self.bucket_name is not None:
            self.validate_pattern(self.bucket_name, 'bucket_name', '[a-zA-Z0-9-_]+')
        self.validate_required(self.filter, 'filter')
        if self.filter:
            self.filter.validate()

    def to_map(self):
        result = dict()
        if self.bucket_name is not None:
            result['BucketName'] = self.bucket_name
        if self.filter is not None:
            result['Filter'] = self.filter.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('BucketName') is not None:
            self.bucket_name = m.get('BucketName')
        if m.get('Filter') is not None:
            temp_model = DeleteBucketTagsRequestFilter()
            self.filter = temp_model.from_map(m['Filter'])
        return self


class DeleteBucketTagsResponse(TeaModel):
    def __init__(
        self,
        request_id: str = None,
    ):
        # x-oss-request-id
        self.request_id = request_id

    def validate(self):
        self.validate_required(self.request_id, 'request_id')

    def to_map(self):
        result = dict()
        if self.request_id is not None:
            result['x-oss-request-id'] = self.request_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('x-oss-request-id') is not None:
            self.request_id = m.get('x-oss-request-id')
        return self


class GetBucketWebsiteRequest(TeaModel):
    def __init__(
        self,
        bucket_name: str = None,
    ):
        # BucketName
        self.bucket_name = bucket_name

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')
        if self.bucket_name is not None:
            self.validate_pattern(self.bucket_name, 'bucket_name', '[a-zA-Z0-9-_]+')

    def to_map(self):
        result = dict()
        if self.bucket_name is not None:
            result['BucketName'] = self.bucket_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('BucketName') is not None:
            self.bucket_name = m.get('BucketName')
        return self


class GetBucketWebsiteResponseWebsiteConfigurationIndexDocument(TeaModel):
    def __init__(
        self,
        suffix: str = None,
    ):
        # Suffix
        self.suffix = suffix

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.suffix is not None:
            result['Suffix'] = self.suffix
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('Suffix') is not None:
            self.suffix = m.get('Suffix')
        return self


class GetBucketWebsiteResponseWebsiteConfigurationErrorDocument(TeaModel):
    def __init__(
        self,
        key: str = None,
    ):
        # Key
        self.key = key

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.key is not None:
            result['Key'] = self.key
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('Key') is not None:
            self.key = m.get('Key')
        return self


class GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleConditionIncludeHeader(TeaModel):
    def __init__(
        self,
        key: str = None,
        equals: str = None,
    ):
        # Key
        self.key = key
        # Equals
        self.equals = equals

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.key is not None:
            result['Key'] = self.key
        if self.equals is not None:
            result['Equals'] = self.equals
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('Key') is not None:
            self.key = m.get('Key')
        if m.get('Equals') is not None:
            self.equals = m.get('Equals')
        return self


class GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleCondition(TeaModel):
    def __init__(
        self,
        key_prefix_equals: str = None,
        http_error_code_returned_equals: str = None,
        include_header: GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleConditionIncludeHeader = None,
    ):
        # KeyPrefixEquals
        self.key_prefix_equals = key_prefix_equals
        # HttpErrorCodeReturnedEquals
        self.http_error_code_returned_equals = http_error_code_returned_equals
        # IncludeHeader
        self.include_header = include_header

    def validate(self):
        self.validate_required(self.include_header, 'include_header')
        if self.include_header:
            self.include_header.validate()

    def to_map(self):
        result = dict()
        if self.key_prefix_equals is not None:
            result['KeyPrefixEquals'] = self.key_prefix_equals
        if self.http_error_code_returned_equals is not None:
            result['HttpErrorCodeReturnedEquals'] = self.http_error_code_returned_equals
        if self.include_header is not None:
            result['IncludeHeader'] = self.include_header.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('KeyPrefixEquals') is not None:
            self.key_prefix_equals = m.get('KeyPrefixEquals')
        if m.get('HttpErrorCodeReturnedEquals') is not None:
            self.http_error_code_returned_equals = m.get('HttpErrorCodeReturnedEquals')
        if m.get('IncludeHeader') is not None:
            temp_model = GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleConditionIncludeHeader()
            self.include_header = temp_model.from_map(m['IncludeHeader'])
        return self


class GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeadersSet(TeaModel):
    def __init__(
        self,
        key: str = None,
        value: str = None,
    ):
        # Key
        self.key = key
        # Value
        self.value = value

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.key is not None:
            result['Key'] = self.key
        if self.value is not None:
            result['Value'] = self.value
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('Key') is not None:
            self.key = m.get('Key')
        if m.get('Value') is not None:
            self.value = m.get('Value')
        return self


class GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeaders(TeaModel):
    def __init__(
        self,
        pass_all: bool = None,
        pass_: str = None,
        remove: str = None,
        set: GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeadersSet = None,
    ):
        # PassAll
        self.pass_all = pass_all
        # Pass
        self.pass_ = pass_
        # Remove
        self.remove = remove
        # Set
        self.set = set

    def validate(self):
        self.validate_required(self.set, 'set')
        if self.set:
            self.set.validate()

    def to_map(self):
        result = dict()
        if self.pass_all is not None:
            result['PassAll'] = self.pass_all
        if self.pass_ is not None:
            result['Pass'] = self.pass_
        if self.remove is not None:
            result['Remove'] = self.remove
        if self.set is not None:
            result['Set'] = self.set.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('PassAll') is not None:
            self.pass_all = m.get('PassAll')
        if m.get('Pass') is not None:
            self.pass_ = m.get('Pass')
        if m.get('Remove') is not None:
            self.remove = m.get('Remove')
        if m.get('Set') is not None:
            temp_model = GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeadersSet()
            self.set = temp_model.from_map(m['Set'])
        return self


class GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirect(TeaModel):
    def __init__(
        self,
        redirect_type: str = None,
        pass_query_string: bool = None,
        mirror_url: str = None,
        mirror_pass_query_string: bool = None,
        mirror_follow_redirect: bool = None,
        mirror_check_md_5: bool = None,
        protocol: str = None,
        host_name: str = None,
        http_redirect_code: str = None,
        replace_key_prefix_with: str = None,
        replace_key_with: str = None,
        mirror_headers: GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeaders = None,
    ):
        # RedirectType
        self.redirect_type = redirect_type
        # PassQueryString
        self.pass_query_string = pass_query_string
        # MirrorURL
        self.mirror_url = mirror_url
        # MirrorPassQueryString
        self.mirror_pass_query_string = mirror_pass_query_string
        # MirrorFollowRedirect
        self.mirror_follow_redirect = mirror_follow_redirect
        # MirrorCheckMd5
        self.mirror_check_md_5 = mirror_check_md_5
        # Protocol
        self.protocol = protocol
        # HostName
        self.host_name = host_name
        # HttpRedirectCode
        self.http_redirect_code = http_redirect_code
        # ReplaceKeyPrefixWith
        self.replace_key_prefix_with = replace_key_prefix_with
        # ReplaceKeyWith
        self.replace_key_with = replace_key_with
        # MirrorHeaders
        self.mirror_headers = mirror_headers

    def validate(self):
        self.validate_required(self.mirror_headers, 'mirror_headers')
        if self.mirror_headers:
            self.mirror_headers.validate()

    def to_map(self):
        result = dict()
        if self.redirect_type is not None:
            result['RedirectType'] = self.redirect_type
        if self.pass_query_string is not None:
            result['PassQueryString'] = self.pass_query_string
        if self.mirror_url is not None:
            result['MirrorURL'] = self.mirror_url
        if self.mirror_pass_query_string is not None:
            result['MirrorPassQueryString'] = self.mirror_pass_query_string
        if self.mirror_follow_redirect is not None:
            result['MirrorFollowRedirect'] = self.mirror_follow_redirect
        if self.mirror_check_md_5 is not None:
            result['MirrorCheckMd5'] = self.mirror_check_md_5
        if self.protocol is not None:
            result['Protocol'] = self.protocol
        if self.host_name is not None:
            result['HostName'] = self.host_name
        if self.http_redirect_code is not None:
            result['HttpRedirectCode'] = self.http_redirect_code
        if self.replace_key_prefix_with is not None:
            result['ReplaceKeyPrefixWith'] = self.replace_key_prefix_with
        if self.replace_key_with is not None:
            result['ReplaceKeyWith'] = self.replace_key_with
        if self.mirror_headers is not None:
            result['MirrorHeaders'] = self.mirror_headers.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('RedirectType') is not None:
            self.redirect_type = m.get('RedirectType')
        if m.get('PassQueryString') is not None:
            self.pass_query_string = m.get('PassQueryString')
        if m.get('MirrorURL') is not None:
            self.mirror_url = m.get('MirrorURL')
        if m.get('MirrorPassQueryString') is not None:
            self.mirror_pass_query_string = m.get('MirrorPassQueryString')
        if m.get('MirrorFollowRedirect') is not None:
            self.mirror_follow_redirect = m.get('MirrorFollowRedirect')
        if m.get('MirrorCheckMd5') is not None:
            self.mirror_check_md_5 = m.get('MirrorCheckMd5')
        if m.get('Protocol') is not None:
            self.protocol = m.get('Protocol')
        if m.get('HostName') is not None:
            self.host_name = m.get('HostName')
        if m.get('HttpRedirectCode') is not None:
            self.http_redirect_code = m.get('HttpRedirectCode')
        if m.get('ReplaceKeyPrefixWith') is not None:
            self.replace_key_prefix_with = m.get('ReplaceKeyPrefixWith')
        if m.get('ReplaceKeyWith') is not None:
            self.replace_key_with = m.get('ReplaceKeyWith')
        if m.get('MirrorHeaders') is not None:
            temp_model = GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeaders()
            self.mirror_headers = temp_model.from_map(m['MirrorHeaders'])
        return self


class GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRule(TeaModel):
    def __init__(
        self,
        rule_number: int = None,
        condition: GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleCondition = None,
        redirect: GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirect = None,
    ):
        # RuleNumber
        self.rule_number = rule_number
        # Condition
        self.condition = condition
        # Redirect
        self.redirect = redirect

    def validate(self):
        self.validate_required(self.condition, 'condition')
        if self.condition:
            self.condition.validate()
        self.validate_required(self.redirect, 'redirect')
        if self.redirect:
            self.redirect.validate()

    def to_map(self):
        result = dict()
        if self.rule_number is not None:
            result['RuleNumber'] = self.rule_number
        if self.condition is not None:
            result['Condition'] = self.condition.to_map()
        if self.redirect is not None:
            result['Redirect'] = self.redirect.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('RuleNumber') is not None:
            self.rule_number = m.get('RuleNumber')
        if m.get('Condition') is not None:
            temp_model = GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleCondition()
            self.condition = temp_model.from_map(m['Condition'])
        if m.get('Redirect') is not None:
            temp_model = GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirect()
            self.redirect = temp_model.from_map(m['Redirect'])
        return self


class GetBucketWebsiteResponseWebsiteConfigurationRoutingRules(TeaModel):
    def __init__(
        self,
        routing_rule: List[GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRule] = None,
    ):
        # RoutingRule
        self.routing_rule = routing_rule

    def validate(self):
        if self.routing_rule:
            for k in self.routing_rule:
                if k:
                    k.validate()

    def to_map(self):
        result = dict()
        result['RoutingRule'] = []
        if self.routing_rule is not None:
            for k in self.routing_rule:
                result['RoutingRule'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.routing_rule = []
        if m.get('RoutingRule') is not None:
            for k in m.get('RoutingRule'):
                temp_model = GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRule()
                self.routing_rule.append(temp_model.from_map(k))
        return self


class GetBucketWebsiteResponseWebsiteConfiguration(TeaModel):
    def __init__(
        self,
        index_document: GetBucketWebsiteResponseWebsiteConfigurationIndexDocument = None,
        error_document: GetBucketWebsiteResponseWebsiteConfigurationErrorDocument = None,
        routing_rules: GetBucketWebsiteResponseWebsiteConfigurationRoutingRules = None,
    ):
        # IndexDocument
        self.index_document = index_document
        # ErrorDocument
        self.error_document = error_document
        # RoutingRules
        self.routing_rules = routing_rules

    def validate(self):
        self.validate_required(self.index_document, 'index_document')
        if self.index_document:
            self.index_document.validate()
        self.validate_required(self.error_document, 'error_document')
        if self.error_document:
            self.error_document.validate()
        self.validate_required(self.routing_rules, 'routing_rules')
        if self.routing_rules:
            self.routing_rules.validate()

    def to_map(self):
        result = dict()
        if self.index_document is not None:
            result['IndexDocument'] = self.index_document.to_map()
        if self.error_document is not None:
            result['ErrorDocument'] = self.error_document.to_map()
        if self.routing_rules is not None:
            result['RoutingRules'] = self.routing_rules.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('IndexDocument') is not None:
            temp_model = GetBucketWebsiteResponseWebsiteConfigurationIndexDocument()
            self.index_document = temp_model.from_map(m['IndexDocument'])
        if m.get('ErrorDocument') is not None:
            temp_model = GetBucketWebsiteResponseWebsiteConfigurationErrorDocument()
            self.error_document = temp_model.from_map(m['ErrorDocument'])
        if m.get('RoutingRules') is not None:
            temp_model = GetBucketWebsiteResponseWebsiteConfigurationRoutingRules()
            self.routing_rules = temp_model.from_map(m['RoutingRules'])
        return self


class GetBucketWebsiteResponse(TeaModel):
    def __init__(
        self,
        request_id: str = None,
        website_configuration: GetBucketWebsiteResponseWebsiteConfiguration = None,
    ):
        # x-oss-request-id
        self.request_id = request_id
        # WebsiteConfiguration
        self.website_configuration = website_configuration

    def validate(self):
        self.validate_required(self.request_id, 'request_id')
        self.validate_required(self.website_configuration, 'website_configuration')
        if self.website_configuration:
            self.website_configuration.validate()

    def to_map(self):
        result = dict()
        if self.request_id is not None:
            result['x-oss-request-id'] = self.request_id
        if self.website_configuration is not None:
            result['WebsiteConfiguration'] = self.website_configuration.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('x-oss-request-id') is not None:
            self.request_id = m.get('x-oss-request-id')
        if m.get('WebsiteConfiguration') is not None:
            temp_model = GetBucketWebsiteResponseWebsiteConfiguration()
            self.website_configuration = temp_model.from_map(m['WebsiteConfiguration'])
        return self


class DeleteLiveChannelRequest(TeaModel):
    def __init__(
        self,
        bucket_name: str = None,
        channel_name: str = None,
    ):
        # BucketName
        self.bucket_name = bucket_name
        # ChannelName
        self.channel_name = channel_name

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')
        if self.bucket_name is not None:
            self.validate_pattern(self.bucket_name, 'bucket_name', '[a-zA-Z0-9-_]+')
        self.validate_required(self.channel_name, 'channel_name')

    def to_map(self):
        result = dict()
        if self.bucket_name is not None:
            result['BucketName'] = self.bucket_name
        if self.channel_name is not None:
            result['ChannelName'] = self.channel_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('BucketName') is not None:
            self.bucket_name = m.get('BucketName')
        if m.get('ChannelName') is not None:
            self.channel_name = m.get('ChannelName')
        return self


class DeleteLiveChannelResponse(TeaModel):
    def __init__(
        self,
        request_id: str = None,
    ):
        # x-oss-request-id
        self.request_id = request_id

    def validate(self):
        self.validate_required(self.request_id, 'request_id')

    def to_map(self):
        result = dict()
        if self.request_id is not None:
            result['x-oss-request-id'] = self.request_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('x-oss-request-id') is not None:
            self.request_id = m.get('x-oss-request-id')
        return self


class GetBucketLocationRequest(TeaModel):
    def __init__(
        self,
        bucket_name: str = None,
    ):
        # BucketName
        self.bucket_name = bucket_name

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')
        if self.bucket_name is not None:
            self.validate_pattern(self.bucket_name, 'bucket_name', '[a-zA-Z0-9-_]+')

    def to_map(self):
        result = dict()
        if self.bucket_name is not None:
            result['BucketName'] = self.bucket_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('BucketName') is not None:
            self.bucket_name = m.get('BucketName')
        return self


class GetBucketLocationResponse(TeaModel):
    def __init__(
        self,
        request_id: str = None,
        location_constraint: str = None,
    ):
        # x-oss-request-id
        self.request_id = request_id
        # LocationConstraint
        self.location_constraint = location_constraint

    def validate(self):
        self.validate_required(self.request_id, 'request_id')
        self.validate_required(self.location_constraint, 'location_constraint')

    def to_map(self):
        result = dict()
        if self.request_id is not None:
            result['x-oss-request-id'] = self.request_id
        if self.location_constraint is not None:
            result['LocationConstraint'] = self.location_constraint
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('x-oss-request-id') is not None:
            self.request_id = m.get('x-oss-request-id')
        if m.get('LocationConstraint') is not None:
            self.location_constraint = m.get('LocationConstraint')
        return self


class ListLiveChannelRequestFilter(TeaModel):
    def __init__(
        self,
        marker: str = None,
        max_keys: str = None,
        prefix: str = None,
    ):
        # marker
        self.marker = marker
        # max-keys
        self.max_keys = max_keys
        # prefix
        self.prefix = prefix

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.marker is not None:
            result['marker'] = self.marker
        if self.max_keys is not None:
            result['max-keys'] = self.max_keys
        if self.prefix is not None:
            result['prefix'] = self.prefix
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('marker') is not None:
            self.marker = m.get('marker')
        if m.get('max-keys') is not None:
            self.max_keys = m.get('max-keys')
        if m.get('prefix') is not None:
            self.prefix = m.get('prefix')
        return self


class ListLiveChannelRequest(TeaModel):
    def __init__(
        self,
        bucket_name: str = None,
        filter: ListLiveChannelRequestFilter = None,
    ):
        # BucketName
        self.bucket_name = bucket_name
        # Filter
        self.filter = filter

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')
        if self.bucket_name is not None:
            self.validate_pattern(self.bucket_name, 'bucket_name', '[a-zA-Z0-9-_]+')
        if self.filter:
            self.filter.validate()

    def to_map(self):
        result = dict()
        if self.bucket_name is not None:
            result['BucketName'] = self.bucket_name
        if self.filter is not None:
            result['Filter'] = self.filter.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('BucketName') is not None:
            self.bucket_name = m.get('BucketName')
        if m.get('Filter') is not None:
            temp_model = ListLiveChannelRequestFilter()
            self.filter = temp_model.from_map(m['Filter'])
        return self


class ListLiveChannelResponseListLiveChannelResultLiveChannelPublishUrls(TeaModel):
    def __init__(
        self,
        url: str = None,
    ):
        # Url
        self.url = url

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.url is not None:
            result['Url'] = self.url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('Url') is not None:
            self.url = m.get('Url')
        return self


class ListLiveChannelResponseListLiveChannelResultLiveChannelPlayUrls(TeaModel):
    def __init__(
        self,
        url: str = None,
    ):
        # Url
        self.url = url

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.url is not None:
            result['Url'] = self.url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('Url') is not None:
            self.url = m.get('Url')
        return self


class ListLiveChannelResponseListLiveChannelResultLiveChannel(TeaModel):
    def __init__(
        self,
        name: str = None,
        description: str = None,
        status: str = None,
        last_modified: str = None,
        publish_urls: ListLiveChannelResponseListLiveChannelResultLiveChannelPublishUrls = None,
        play_urls: ListLiveChannelResponseListLiveChannelResultLiveChannelPlayUrls = None,
    ):
        # Name
        self.name = name
        # Description
        self.description = description
        # Status
        self.status = status
        # LastModified
        self.last_modified = last_modified
        # PublishUrls
        self.publish_urls = publish_urls
        # PlayUrls
        self.play_urls = play_urls

    def validate(self):
        self.validate_required(self.publish_urls, 'publish_urls')
        if self.publish_urls:
            self.publish_urls.validate()
        self.validate_required(self.play_urls, 'play_urls')
        if self.play_urls:
            self.play_urls.validate()

    def to_map(self):
        result = dict()
        if self.name is not None:
            result['Name'] = self.name
        if self.description is not None:
            result['Description'] = self.description
        if self.status is not None:
            result['Status'] = self.status
        if self.last_modified is not None:
            result['LastModified'] = self.last_modified
        if self.publish_urls is not None:
            result['PublishUrls'] = self.publish_urls.to_map()
        if self.play_urls is not None:
            result['PlayUrls'] = self.play_urls.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('Name') is not None:
            self.name = m.get('Name')
        if m.get('Description') is not None:
            self.description = m.get('Description')
        if m.get('Status') is not None:
            self.status = m.get('Status')
        if m.get('LastModified') is not None:
            self.last_modified = m.get('LastModified')
        if m.get('PublishUrls') is not None:
            temp_model = ListLiveChannelResponseListLiveChannelResultLiveChannelPublishUrls()
            self.publish_urls = temp_model.from_map(m['PublishUrls'])
        if m.get('PlayUrls') is not None:
            temp_model = ListLiveChannelResponseListLiveChannelResultLiveChannelPlayUrls()
            self.play_urls = temp_model.from_map(m['PlayUrls'])
        return self


class ListLiveChannelResponseListLiveChannelResult(TeaModel):
    def __init__(
        self,
        prefix: str = None,
        marker: str = None,
        max_keys: str = None,
        is_truncated: str = None,
        next_marker: str = None,
        live_channel: ListLiveChannelResponseListLiveChannelResultLiveChannel = None,
    ):
        # Prefix
        self.prefix = prefix
        # Marker
        self.marker = marker
        # MaxKeys
        self.max_keys = max_keys
        # IsTruncated
        self.is_truncated = is_truncated
        # NextMarker
        self.next_marker = next_marker
        # LiveChannel
        self.live_channel = live_channel

    def validate(self):
        self.validate_required(self.live_channel, 'live_channel')
        if self.live_channel:
            self.live_channel.validate()

    def to_map(self):
        result = dict()
        if self.prefix is not None:
            result['Prefix'] = self.prefix
        if self.marker is not None:
            result['Marker'] = self.marker
        if self.max_keys is not None:
            result['MaxKeys'] = self.max_keys
        if self.is_truncated is not None:
            result['IsTruncated'] = self.is_truncated
        if self.next_marker is not None:
            result['NextMarker'] = self.next_marker
        if self.live_channel is not None:
            result['LiveChannel'] = self.live_channel.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('Prefix') is not None:
            self.prefix = m.get('Prefix')
        if m.get('Marker') is not None:
            self.marker = m.get('Marker')
        if m.get('MaxKeys') is not None:
            self.max_keys = m.get('MaxKeys')
        if m.get('IsTruncated') is not None:
            self.is_truncated = m.get('IsTruncated')
        if m.get('NextMarker') is not None:
            self.next_marker = m.get('NextMarker')
        if m.get('LiveChannel') is not None:
            temp_model = ListLiveChannelResponseListLiveChannelResultLiveChannel()
            self.live_channel = temp_model.from_map(m['LiveChannel'])
        return self


class ListLiveChannelResponse(TeaModel):
    def __init__(
        self,
        request_id: str = None,
        list_live_channel_result: ListLiveChannelResponseListLiveChannelResult = None,
    ):
        # x-oss-request-id
        self.request_id = request_id
        # ListLiveChannelResult
        self.list_live_channel_result = list_live_channel_result

    def validate(self):
        self.validate_required(self.request_id, 'request_id')
        self.validate_required(self.list_live_channel_result, 'list_live_channel_result')
        if self.list_live_channel_result:
            self.list_live_channel_result.validate()

    def to_map(self):
        result = dict()
        if self.request_id is not None:
            result['x-oss-request-id'] = self.request_id
        if self.list_live_channel_result is not None:
            result['ListLiveChannelResult'] = self.list_live_channel_result.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('x-oss-request-id') is not None:
            self.request_id = m.get('x-oss-request-id')
        if m.get('ListLiveChannelResult') is not None:
            temp_model = ListLiveChannelResponseListLiveChannelResult()
            self.list_live_channel_result = temp_model.from_map(m['ListLiveChannelResult'])
        return self


class GetObjectMetaRequest(TeaModel):
    def __init__(
        self,
        bucket_name: str = None,
        object_name: str = None,
    ):
        # BucketName
        self.bucket_name = bucket_name
        # ObjectName
        self.object_name = object_name

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')
        if self.bucket_name is not None:
            self.validate_pattern(self.bucket_name, 'bucket_name', '[a-zA-Z0-9-_]+')
        self.validate_required(self.object_name, 'object_name')

    def to_map(self):
        result = dict()
        if self.bucket_name is not None:
            result['BucketName'] = self.bucket_name
        if self.object_name is not None:
            result['ObjectName'] = self.object_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('BucketName') is not None:
            self.bucket_name = m.get('BucketName')
        if m.get('ObjectName') is not None:
            self.object_name = m.get('ObjectName')
        return self


class GetObjectMetaResponse(TeaModel):
    def __init__(
        self,
        request_id: str = None,
        e_tag: str = None,
        content_length: str = None,
        last_modified: str = None,
    ):
        # x-oss-request-id
        self.request_id = request_id
        # ETag
        self.e_tag = e_tag
        # Content-Length
        self.content_length = content_length
        # Last-Modified
        self.last_modified = last_modified

    def validate(self):
        self.validate_required(self.request_id, 'request_id')
        self.validate_required(self.e_tag, 'e_tag')
        self.validate_required(self.content_length, 'content_length')
        self.validate_required(self.last_modified, 'last_modified')

    def to_map(self):
        result = dict()
        if self.request_id is not None:
            result['x-oss-request-id'] = self.request_id
        if self.e_tag is not None:
            result['etag'] = self.e_tag
        if self.content_length is not None:
            result['content-length'] = self.content_length
        if self.last_modified is not None:
            result['last-modified'] = self.last_modified
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('x-oss-request-id') is not None:
            self.request_id = m.get('x-oss-request-id')
        if m.get('etag') is not None:
            self.e_tag = m.get('etag')
        if m.get('content-length') is not None:
            self.content_length = m.get('content-length')
        if m.get('last-modified') is not None:
            self.last_modified = m.get('last-modified')
        return self


class GetBucketAclRequest(TeaModel):
    def __init__(
        self,
        bucket_name: str = None,
    ):
        # BucketName
        self.bucket_name = bucket_name

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')
        if self.bucket_name is not None:
            self.validate_pattern(self.bucket_name, 'bucket_name', '[a-zA-Z0-9-_]+')

    def to_map(self):
        result = dict()
        if self.bucket_name is not None:
            result['BucketName'] = self.bucket_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('BucketName') is not None:
            self.bucket_name = m.get('BucketName')
        return self


class GetBucketAclResponseAccessControlPolicyOwner(TeaModel):
    def __init__(
        self,
        i_d: str = None,
        display_name: str = None,
    ):
        # ID
        self.i_d = i_d
        # DisplayName
        self.display_name = display_name

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.i_d is not None:
            result['ID'] = self.i_d
        if self.display_name is not None:
            result['DisplayName'] = self.display_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('ID') is not None:
            self.i_d = m.get('ID')
        if m.get('DisplayName') is not None:
            self.display_name = m.get('DisplayName')
        return self


class GetBucketAclResponseAccessControlPolicyAccessControlList(TeaModel):
    def __init__(
        self,
        grant: str = None,
    ):
        # Grant
        self.grant = grant

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.grant is not None:
            result['Grant'] = self.grant
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('Grant') is not None:
            self.grant = m.get('Grant')
        return self


class GetBucketAclResponseAccessControlPolicy(TeaModel):
    def __init__(
        self,
        owner: GetBucketAclResponseAccessControlPolicyOwner = None,
        access_control_list: GetBucketAclResponseAccessControlPolicyAccessControlList = None,
    ):
        # Owner
        self.owner = owner
        # AccessControlList
        self.access_control_list = access_control_list

    def validate(self):
        self.validate_required(self.owner, 'owner')
        if self.owner:
            self.owner.validate()
        self.validate_required(self.access_control_list, 'access_control_list')
        if self.access_control_list:
            self.access_control_list.validate()

    def to_map(self):
        result = dict()
        if self.owner is not None:
            result['Owner'] = self.owner.to_map()
        if self.access_control_list is not None:
            result['AccessControlList'] = self.access_control_list.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('Owner') is not None:
            temp_model = GetBucketAclResponseAccessControlPolicyOwner()
            self.owner = temp_model.from_map(m['Owner'])
        if m.get('AccessControlList') is not None:
            temp_model = GetBucketAclResponseAccessControlPolicyAccessControlList()
            self.access_control_list = temp_model.from_map(m['AccessControlList'])
        return self


class GetBucketAclResponse(TeaModel):
    def __init__(
        self,
        request_id: str = None,
        access_control_policy: GetBucketAclResponseAccessControlPolicy = None,
    ):
        # x-oss-request-id
        self.request_id = request_id
        # AccessControlPolicy
        self.access_control_policy = access_control_policy

    def validate(self):
        self.validate_required(self.request_id, 'request_id')
        self.validate_required(self.access_control_policy, 'access_control_policy')
        if self.access_control_policy:
            self.access_control_policy.validate()

    def to_map(self):
        result = dict()
        if self.request_id is not None:
            result['x-oss-request-id'] = self.request_id
        if self.access_control_policy is not None:
            result['AccessControlPolicy'] = self.access_control_policy.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('x-oss-request-id') is not None:
            self.request_id = m.get('x-oss-request-id')
        if m.get('AccessControlPolicy') is not None:
            temp_model = GetBucketAclResponseAccessControlPolicy()
            self.access_control_policy = temp_model.from_map(m['AccessControlPolicy'])
        return self


class ListPartsRequestFilter(TeaModel):
    def __init__(
        self,
        upload_id: str = None,
        max_parts: int = None,
        part_number_marker: int = None,
        encoding_type: str = None,
    ):
        # uploadId
        self.upload_id = upload_id
        # max-parts
        self.max_parts = max_parts
        # part-number-marker
        self.part_number_marker = part_number_marker
        # Encoding-type
        self.encoding_type = encoding_type

    def validate(self):
        self.validate_required(self.upload_id, 'upload_id')

    def to_map(self):
        result = dict()
        if self.upload_id is not None:
            result['uploadId'] = self.upload_id
        if self.max_parts is not None:
            result['max-parts'] = self.max_parts
        if self.part_number_marker is not None:
            result['part-number-marker'] = self.part_number_marker
        if self.encoding_type is not None:
            result['Encoding-type'] = self.encoding_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('uploadId') is not None:
            self.upload_id = m.get('uploadId')
        if m.get('max-parts') is not None:
            self.max_parts = m.get('max-parts')
        if m.get('part-number-marker') is not None:
            self.part_number_marker = m.get('part-number-marker')
        if m.get('Encoding-type') is not None:
            self.encoding_type = m.get('Encoding-type')
        return self


class ListPartsRequest(TeaModel):
    def __init__(
        self,
        bucket_name: str = None,
        object_name: str = None,
        filter: ListPartsRequestFilter = None,
    ):
        # BucketName
        self.bucket_name = bucket_name
        # ObjectName
        self.object_name = object_name
        # Filter
        self.filter = filter

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')
        if self.bucket_name is not None:
            self.validate_pattern(self.bucket_name, 'bucket_name', '[a-zA-Z0-9-_]+')
        self.validate_required(self.object_name, 'object_name')
        self.validate_required(self.filter, 'filter')
        if self.filter:
            self.filter.validate()

    def to_map(self):
        result = dict()
        if self.bucket_name is not None:
            result['BucketName'] = self.bucket_name
        if self.object_name is not None:
            result['ObjectName'] = self.object_name
        if self.filter is not None:
            result['Filter'] = self.filter.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('BucketName') is not None:
            self.bucket_name = m.get('BucketName')
        if m.get('ObjectName') is not None:
            self.object_name = m.get('ObjectName')
        if m.get('Filter') is not None:
            temp_model = ListPartsRequestFilter()
            self.filter = temp_model.from_map(m['Filter'])
        return self


class ListPartsResponseListPartsResultPart(TeaModel):
    def __init__(
        self,
        part_number: str = None,
        last_modified: str = None,
        e_tag: str = None,
        size: str = None,
    ):
        # PartNumber
        self.part_number = part_number
        # LastModified
        self.last_modified = last_modified
        # ETag
        self.e_tag = e_tag
        # Size
        self.size = size

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.part_number is not None:
            result['PartNumber'] = self.part_number
        if self.last_modified is not None:
            result['LastModified'] = self.last_modified
        if self.e_tag is not None:
            result['ETag'] = self.e_tag
        if self.size is not None:
            result['Size'] = self.size
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('PartNumber') is not None:
            self.part_number = m.get('PartNumber')
        if m.get('LastModified') is not None:
            self.last_modified = m.get('LastModified')
        if m.get('ETag') is not None:
            self.e_tag = m.get('ETag')
        if m.get('Size') is not None:
            self.size = m.get('Size')
        return self


class ListPartsResponseListPartsResult(TeaModel):
    def __init__(
        self,
        bucket: str = None,
        encoding_type: str = None,
        key: str = None,
        upload_id: str = None,
        part_number_marker: str = None,
        next_part_number_marker: str = None,
        max_parts: str = None,
        is_truncated: str = None,
        part: List[ListPartsResponseListPartsResultPart] = None,
    ):
        # Bucket
        self.bucket = bucket
        # EncodingType
        self.encoding_type = encoding_type
        # Key
        self.key = key
        # UploadId
        self.upload_id = upload_id
        # PartNumberMarker
        self.part_number_marker = part_number_marker
        # NextPartNumberMarker
        self.next_part_number_marker = next_part_number_marker
        # MaxParts
        self.max_parts = max_parts
        # IsTruncated
        self.is_truncated = is_truncated
        # Part
        self.part = part

    def validate(self):
        if self.part:
            for k in self.part:
                if k:
                    k.validate()

    def to_map(self):
        result = dict()
        if self.bucket is not None:
            result['Bucket'] = self.bucket
        if self.encoding_type is not None:
            result['EncodingType'] = self.encoding_type
        if self.key is not None:
            result['Key'] = self.key
        if self.upload_id is not None:
            result['UploadId'] = self.upload_id
        if self.part_number_marker is not None:
            result['PartNumberMarker'] = self.part_number_marker
        if self.next_part_number_marker is not None:
            result['NextPartNumberMarker'] = self.next_part_number_marker
        if self.max_parts is not None:
            result['MaxParts'] = self.max_parts
        if self.is_truncated is not None:
            result['IsTruncated'] = self.is_truncated
        result['Part'] = []
        if self.part is not None:
            for k in self.part:
                result['Part'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('Bucket') is not None:
            self.bucket = m.get('Bucket')
        if m.get('EncodingType') is not None:
            self.encoding_type = m.get('EncodingType')
        if m.get('Key') is not None:
            self.key = m.get('Key')
        if m.get('UploadId') is not None:
            self.upload_id = m.get('UploadId')
        if m.get('PartNumberMarker') is not None:
            self.part_number_marker = m.get('PartNumberMarker')
        if m.get('NextPartNumberMarker') is not None:
            self.next_part_number_marker = m.get('NextPartNumberMarker')
        if m.get('MaxParts') is not None:
            self.max_parts = m.get('MaxParts')
        if m.get('IsTruncated') is not None:
            self.is_truncated = m.get('IsTruncated')
        self.part = []
        if m.get('Part') is not None:
            for k in m.get('Part'):
                temp_model = ListPartsResponseListPartsResultPart()
                self.part.append(temp_model.from_map(k))
        return self


class ListPartsResponse(TeaModel):
    def __init__(
        self,
        request_id: str = None,
        list_parts_result: ListPartsResponseListPartsResult = None,
    ):
        # x-oss-request-id
        self.request_id = request_id
        # ListPartsResult
        self.list_parts_result = list_parts_result

    def validate(self):
        self.validate_required(self.request_id, 'request_id')
        self.validate_required(self.list_parts_result, 'list_parts_result')
        if self.list_parts_result:
            self.list_parts_result.validate()

    def to_map(self):
        result = dict()
        if self.request_id is not None:
            result['x-oss-request-id'] = self.request_id
        if self.list_parts_result is not None:
            result['ListPartsResult'] = self.list_parts_result.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('x-oss-request-id') is not None:
            self.request_id = m.get('x-oss-request-id')
        if m.get('ListPartsResult') is not None:
            temp_model = ListPartsResponseListPartsResult()
            self.list_parts_result = temp_model.from_map(m['ListPartsResult'])
        return self


class GetLiveChannelHistoryRequestFilter(TeaModel):
    def __init__(
        self,
        comp: str = None,
    ):
        # comp
        self.comp = comp

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.comp is not None:
            result['comp'] = self.comp
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('comp') is not None:
            self.comp = m.get('comp')
        return self


class GetLiveChannelHistoryRequest(TeaModel):
    def __init__(
        self,
        bucket_name: str = None,
        channel_name: str = None,
        filter: GetLiveChannelHistoryRequestFilter = None,
    ):
        # BucketName
        self.bucket_name = bucket_name
        # ChannelName
        self.channel_name = channel_name
        # Filter
        self.filter = filter

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')
        if self.bucket_name is not None:
            self.validate_pattern(self.bucket_name, 'bucket_name', '[a-zA-Z0-9-_]+')
        self.validate_required(self.channel_name, 'channel_name')
        if self.filter:
            self.filter.validate()

    def to_map(self):
        result = dict()
        if self.bucket_name is not None:
            result['BucketName'] = self.bucket_name
        if self.channel_name is not None:
            result['ChannelName'] = self.channel_name
        if self.filter is not None:
            result['Filter'] = self.filter.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('BucketName') is not None:
            self.bucket_name = m.get('BucketName')
        if m.get('ChannelName') is not None:
            self.channel_name = m.get('ChannelName')
        if m.get('Filter') is not None:
            temp_model = GetLiveChannelHistoryRequestFilter()
            self.filter = temp_model.from_map(m['Filter'])
        return self


class GetLiveChannelHistoryResponseLiveChannelHistoryLiveRecord(TeaModel):
    def __init__(
        self,
        start_time: str = None,
        end_time: str = None,
        remote_addr: str = None,
    ):
        # StartTime
        self.start_time = start_time
        # EndTime
        self.end_time = end_time
        # RemoteAddr
        self.remote_addr = remote_addr

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.start_time is not None:
            result['StartTime'] = self.start_time
        if self.end_time is not None:
            result['EndTime'] = self.end_time
        if self.remote_addr is not None:
            result['RemoteAddr'] = self.remote_addr
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('StartTime') is not None:
            self.start_time = m.get('StartTime')
        if m.get('EndTime') is not None:
            self.end_time = m.get('EndTime')
        if m.get('RemoteAddr') is not None:
            self.remote_addr = m.get('RemoteAddr')
        return self


class GetLiveChannelHistoryResponseLiveChannelHistory(TeaModel):
    def __init__(
        self,
        live_record: List[GetLiveChannelHistoryResponseLiveChannelHistoryLiveRecord] = None,
    ):
        # LiveRecord
        self.live_record = live_record

    def validate(self):
        if self.live_record:
            for k in self.live_record:
                if k:
                    k.validate()

    def to_map(self):
        result = dict()
        result['LiveRecord'] = []
        if self.live_record is not None:
            for k in self.live_record:
                result['LiveRecord'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.live_record = []
        if m.get('LiveRecord') is not None:
            for k in m.get('LiveRecord'):
                temp_model = GetLiveChannelHistoryResponseLiveChannelHistoryLiveRecord()
                self.live_record.append(temp_model.from_map(k))
        return self


class GetLiveChannelHistoryResponse(TeaModel):
    def __init__(
        self,
        request_id: str = None,
        live_channel_history: GetLiveChannelHistoryResponseLiveChannelHistory = None,
    ):
        # x-oss-request-id
        self.request_id = request_id
        # LiveChannelHistory
        self.live_channel_history = live_channel_history

    def validate(self):
        self.validate_required(self.request_id, 'request_id')
        self.validate_required(self.live_channel_history, 'live_channel_history')
        if self.live_channel_history:
            self.live_channel_history.validate()

    def to_map(self):
        result = dict()
        if self.request_id is not None:
            result['x-oss-request-id'] = self.request_id
        if self.live_channel_history is not None:
            result['LiveChannelHistory'] = self.live_channel_history.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('x-oss-request-id') is not None:
            self.request_id = m.get('x-oss-request-id')
        if m.get('LiveChannelHistory') is not None:
            temp_model = GetLiveChannelHistoryResponseLiveChannelHistory()
            self.live_channel_history = temp_model.from_map(m['LiveChannelHistory'])
        return self


class GetBucketRequestFilter(TeaModel):
    def __init__(
        self,
        delimiter: str = None,
        marker: str = None,
        max_keys: str = None,
        prefix: str = None,
        encoding_type: str = None,
    ):
        # delimiter
        self.delimiter = delimiter
        # marker
        self.marker = marker
        # max-keys
        self.max_keys = max_keys
        # prefix
        self.prefix = prefix
        # encoding-type
        self.encoding_type = encoding_type

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.delimiter is not None:
            result['delimiter'] = self.delimiter
        if self.marker is not None:
            result['marker'] = self.marker
        if self.max_keys is not None:
            result['max-keys'] = self.max_keys
        if self.prefix is not None:
            result['prefix'] = self.prefix
        if self.encoding_type is not None:
            result['encoding-type'] = self.encoding_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('delimiter') is not None:
            self.delimiter = m.get('delimiter')
        if m.get('marker') is not None:
            self.marker = m.get('marker')
        if m.get('max-keys') is not None:
            self.max_keys = m.get('max-keys')
        if m.get('prefix') is not None:
            self.prefix = m.get('prefix')
        if m.get('encoding-type') is not None:
            self.encoding_type = m.get('encoding-type')
        return self


class GetBucketRequest(TeaModel):
    def __init__(
        self,
        bucket_name: str = None,
        filter: GetBucketRequestFilter = None,
    ):
        # BucketName
        self.bucket_name = bucket_name
        # Filter
        self.filter = filter

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')
        if self.bucket_name is not None:
            self.validate_pattern(self.bucket_name, 'bucket_name', '[a-zA-Z0-9-_]+')
        if self.filter:
            self.filter.validate()

    def to_map(self):
        result = dict()
        if self.bucket_name is not None:
            result['BucketName'] = self.bucket_name
        if self.filter is not None:
            result['Filter'] = self.filter.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('BucketName') is not None:
            self.bucket_name = m.get('BucketName')
        if m.get('Filter') is not None:
            temp_model = GetBucketRequestFilter()
            self.filter = temp_model.from_map(m['Filter'])
        return self


class GetBucketResponseListBucketResultContentsOwner(TeaModel):
    def __init__(
        self,
        i_d: str = None,
        display_name: str = None,
    ):
        # ID
        self.i_d = i_d
        # DisplayName
        self.display_name = display_name

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.i_d is not None:
            result['ID'] = self.i_d
        if self.display_name is not None:
            result['DisplayName'] = self.display_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('ID') is not None:
            self.i_d = m.get('ID')
        if m.get('DisplayName') is not None:
            self.display_name = m.get('DisplayName')
        return self


class GetBucketResponseListBucketResultContents(TeaModel):
    def __init__(
        self,
        key: str = None,
        e_tag: str = None,
        last_modified: str = None,
        size: str = None,
        storage_class: str = None,
        owner: GetBucketResponseListBucketResultContentsOwner = None,
    ):
        # Key
        self.key = key
        # ETag
        self.e_tag = e_tag
        # LastModified
        self.last_modified = last_modified
        # Size
        self.size = size
        # StorageClass
        self.storage_class = storage_class
        # Owner
        self.owner = owner

    def validate(self):
        self.validate_required(self.owner, 'owner')
        if self.owner:
            self.owner.validate()

    def to_map(self):
        result = dict()
        if self.key is not None:
            result['Key'] = self.key
        if self.e_tag is not None:
            result['ETag'] = self.e_tag
        if self.last_modified is not None:
            result['LastModified'] = self.last_modified
        if self.size is not None:
            result['Size'] = self.size
        if self.storage_class is not None:
            result['StorageClass'] = self.storage_class
        if self.owner is not None:
            result['Owner'] = self.owner.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('Key') is not None:
            self.key = m.get('Key')
        if m.get('ETag') is not None:
            self.e_tag = m.get('ETag')
        if m.get('LastModified') is not None:
            self.last_modified = m.get('LastModified')
        if m.get('Size') is not None:
            self.size = m.get('Size')
        if m.get('StorageClass') is not None:
            self.storage_class = m.get('StorageClass')
        if m.get('Owner') is not None:
            temp_model = GetBucketResponseListBucketResultContentsOwner()
            self.owner = temp_model.from_map(m['Owner'])
        return self


class GetBucketResponseListBucketResult(TeaModel):
    def __init__(
        self,
        name: str = None,
        prefix: str = None,
        marker: str = None,
        max_keys: str = None,
        delimiter: str = None,
        is_truncated: str = None,
        encoding_type: str = None,
        common_prefixes: str = None,
        contents: List[GetBucketResponseListBucketResultContents] = None,
    ):
        # Name
        self.name = name
        # Prefix
        self.prefix = prefix
        # Marker
        self.marker = marker
        # MaxKeys
        self.max_keys = max_keys
        # Delimiter
        self.delimiter = delimiter
        # IsTruncated
        self.is_truncated = is_truncated
        # EncodingType
        self.encoding_type = encoding_type
        # CommonPrefixes
        self.common_prefixes = common_prefixes
        # Contents
        self.contents = contents

    def validate(self):
        if self.contents:
            for k in self.contents:
                if k:
                    k.validate()

    def to_map(self):
        result = dict()
        if self.name is not None:
            result['Name'] = self.name
        if self.prefix is not None:
            result['Prefix'] = self.prefix
        if self.marker is not None:
            result['Marker'] = self.marker
        if self.max_keys is not None:
            result['MaxKeys'] = self.max_keys
        if self.delimiter is not None:
            result['Delimiter'] = self.delimiter
        if self.is_truncated is not None:
            result['IsTruncated'] = self.is_truncated
        if self.encoding_type is not None:
            result['EncodingType'] = self.encoding_type
        if self.common_prefixes is not None:
            result['CommonPrefixes'] = self.common_prefixes
        result['Contents'] = []
        if self.contents is not None:
            for k in self.contents:
                result['Contents'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('Name') is not None:
            self.name = m.get('Name')
        if m.get('Prefix') is not None:
            self.prefix = m.get('Prefix')
        if m.get('Marker') is not None:
            self.marker = m.get('Marker')
        if m.get('MaxKeys') is not None:
            self.max_keys = m.get('MaxKeys')
        if m.get('Delimiter') is not None:
            self.delimiter = m.get('Delimiter')
        if m.get('IsTruncated') is not None:
            self.is_truncated = m.get('IsTruncated')
        if m.get('EncodingType') is not None:
            self.encoding_type = m.get('EncodingType')
        if m.get('CommonPrefixes') is not None:
            self.common_prefixes = m.get('CommonPrefixes')
        self.contents = []
        if m.get('Contents') is not None:
            for k in m.get('Contents'):
                temp_model = GetBucketResponseListBucketResultContents()
                self.contents.append(temp_model.from_map(k))
        return self


class GetBucketResponse(TeaModel):
    def __init__(
        self,
        request_id: str = None,
        list_bucket_result: GetBucketResponseListBucketResult = None,
    ):
        # x-oss-request-id
        self.request_id = request_id
        # ListBucketResult
        self.list_bucket_result = list_bucket_result

    def validate(self):
        self.validate_required(self.request_id, 'request_id')
        self.validate_required(self.list_bucket_result, 'list_bucket_result')
        if self.list_bucket_result:
            self.list_bucket_result.validate()

    def to_map(self):
        result = dict()
        if self.request_id is not None:
            result['x-oss-request-id'] = self.request_id
        if self.list_bucket_result is not None:
            result['ListBucketResult'] = self.list_bucket_result.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('x-oss-request-id') is not None:
            self.request_id = m.get('x-oss-request-id')
        if m.get('ListBucketResult') is not None:
            temp_model = GetBucketResponseListBucketResult()
            self.list_bucket_result = temp_model.from_map(m['ListBucketResult'])
        return self


class GetLiveChannelInfoRequest(TeaModel):
    def __init__(
        self,
        bucket_name: str = None,
        channel_name: str = None,
    ):
        # BucketName
        self.bucket_name = bucket_name
        # ChannelName
        self.channel_name = channel_name

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')
        if self.bucket_name is not None:
            self.validate_pattern(self.bucket_name, 'bucket_name', '[a-zA-Z0-9-_]+')
        self.validate_required(self.channel_name, 'channel_name')

    def to_map(self):
        result = dict()
        if self.bucket_name is not None:
            result['BucketName'] = self.bucket_name
        if self.channel_name is not None:
            result['ChannelName'] = self.channel_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('BucketName') is not None:
            self.bucket_name = m.get('BucketName')
        if m.get('ChannelName') is not None:
            self.channel_name = m.get('ChannelName')
        return self


class GetLiveChannelInfoResponseLiveChannelConfigurationTarget(TeaModel):
    def __init__(
        self,
        type: str = None,
        frag_duration: str = None,
        frag_count: str = None,
        playlist_name: str = None,
    ):
        # Type
        self.type = type
        # FragDuration
        self.frag_duration = frag_duration
        # FragCount
        self.frag_count = frag_count
        # PlaylistName
        self.playlist_name = playlist_name

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.type is not None:
            result['Type'] = self.type
        if self.frag_duration is not None:
            result['FragDuration'] = self.frag_duration
        if self.frag_count is not None:
            result['FragCount'] = self.frag_count
        if self.playlist_name is not None:
            result['PlaylistName'] = self.playlist_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('Type') is not None:
            self.type = m.get('Type')
        if m.get('FragDuration') is not None:
            self.frag_duration = m.get('FragDuration')
        if m.get('FragCount') is not None:
            self.frag_count = m.get('FragCount')
        if m.get('PlaylistName') is not None:
            self.playlist_name = m.get('PlaylistName')
        return self


class GetLiveChannelInfoResponseLiveChannelConfiguration(TeaModel):
    def __init__(
        self,
        description: str = None,
        status: str = None,
        target: GetLiveChannelInfoResponseLiveChannelConfigurationTarget = None,
    ):
        # Description
        self.description = description
        # Status
        self.status = status
        # Target
        self.target = target

    def validate(self):
        self.validate_required(self.target, 'target')
        if self.target:
            self.target.validate()

    def to_map(self):
        result = dict()
        if self.description is not None:
            result['Description'] = self.description
        if self.status is not None:
            result['Status'] = self.status
        if self.target is not None:
            result['Target'] = self.target.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('Description') is not None:
            self.description = m.get('Description')
        if m.get('Status') is not None:
            self.status = m.get('Status')
        if m.get('Target') is not None:
            temp_model = GetLiveChannelInfoResponseLiveChannelConfigurationTarget()
            self.target = temp_model.from_map(m['Target'])
        return self


class GetLiveChannelInfoResponse(TeaModel):
    def __init__(
        self,
        request_id: str = None,
        live_channel_configuration: GetLiveChannelInfoResponseLiveChannelConfiguration = None,
    ):
        # x-oss-request-id
        self.request_id = request_id
        # LiveChannelConfiguration
        self.live_channel_configuration = live_channel_configuration

    def validate(self):
        self.validate_required(self.request_id, 'request_id')
        self.validate_required(self.live_channel_configuration, 'live_channel_configuration')
        if self.live_channel_configuration:
            self.live_channel_configuration.validate()

    def to_map(self):
        result = dict()
        if self.request_id is not None:
            result['x-oss-request-id'] = self.request_id
        if self.live_channel_configuration is not None:
            result['LiveChannelConfiguration'] = self.live_channel_configuration.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('x-oss-request-id') is not None:
            self.request_id = m.get('x-oss-request-id')
        if m.get('LiveChannelConfiguration') is not None:
            temp_model = GetLiveChannelInfoResponseLiveChannelConfiguration()
            self.live_channel_configuration = temp_model.from_map(m['LiveChannelConfiguration'])
        return self


class GetLiveChannelStatRequestFilter(TeaModel):
    def __init__(
        self,
        comp: str = None,
    ):
        # comp
        self.comp = comp

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.comp is not None:
            result['comp'] = self.comp
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('comp') is not None:
            self.comp = m.get('comp')
        return self


class GetLiveChannelStatRequest(TeaModel):
    def __init__(
        self,
        bucket_name: str = None,
        channel_name: str = None,
        filter: GetLiveChannelStatRequestFilter = None,
    ):
        # BucketName
        self.bucket_name = bucket_name
        # ChannelName
        self.channel_name = channel_name
        # Filter
        self.filter = filter

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')
        if self.bucket_name is not None:
            self.validate_pattern(self.bucket_name, 'bucket_name', '[a-zA-Z0-9-_]+')
        self.validate_required(self.channel_name, 'channel_name')
        if self.filter:
            self.filter.validate()

    def to_map(self):
        result = dict()
        if self.bucket_name is not None:
            result['BucketName'] = self.bucket_name
        if self.channel_name is not None:
            result['ChannelName'] = self.channel_name
        if self.filter is not None:
            result['Filter'] = self.filter.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('BucketName') is not None:
            self.bucket_name = m.get('BucketName')
        if m.get('ChannelName') is not None:
            self.channel_name = m.get('ChannelName')
        if m.get('Filter') is not None:
            temp_model = GetLiveChannelStatRequestFilter()
            self.filter = temp_model.from_map(m['Filter'])
        return self


class GetLiveChannelStatResponseLiveChannelStatVideo(TeaModel):
    def __init__(
        self,
        width: str = None,
        height: str = None,
        frame_rate: str = None,
        bandwidth: str = None,
        codec: str = None,
    ):
        # Width
        self.width = width
        # Height
        self.height = height
        # FrameRate
        self.frame_rate = frame_rate
        # Bandwidth
        self.bandwidth = bandwidth
        # Codec
        self.codec = codec

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.width is not None:
            result['Width'] = self.width
        if self.height is not None:
            result['Height'] = self.height
        if self.frame_rate is not None:
            result['FrameRate'] = self.frame_rate
        if self.bandwidth is not None:
            result['Bandwidth'] = self.bandwidth
        if self.codec is not None:
            result['Codec'] = self.codec
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('Width') is not None:
            self.width = m.get('Width')
        if m.get('Height') is not None:
            self.height = m.get('Height')
        if m.get('FrameRate') is not None:
            self.frame_rate = m.get('FrameRate')
        if m.get('Bandwidth') is not None:
            self.bandwidth = m.get('Bandwidth')
        if m.get('Codec') is not None:
            self.codec = m.get('Codec')
        return self


class GetLiveChannelStatResponseLiveChannelStatAudio(TeaModel):
    def __init__(
        self,
        bandwidth: str = None,
        sample_rate: str = None,
        codec: str = None,
    ):
        # Bandwidth
        self.bandwidth = bandwidth
        # SampleRate
        self.sample_rate = sample_rate
        # Codec
        self.codec = codec

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.bandwidth is not None:
            result['Bandwidth'] = self.bandwidth
        if self.sample_rate is not None:
            result['SampleRate'] = self.sample_rate
        if self.codec is not None:
            result['Codec'] = self.codec
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('Bandwidth') is not None:
            self.bandwidth = m.get('Bandwidth')
        if m.get('SampleRate') is not None:
            self.sample_rate = m.get('SampleRate')
        if m.get('Codec') is not None:
            self.codec = m.get('Codec')
        return self


class GetLiveChannelStatResponseLiveChannelStat(TeaModel):
    def __init__(
        self,
        status: str = None,
        connected_time: str = None,
        remote_addr: str = None,
        video: GetLiveChannelStatResponseLiveChannelStatVideo = None,
        audio: GetLiveChannelStatResponseLiveChannelStatAudio = None,
    ):
        # Status
        self.status = status
        # ConnectedTime
        self.connected_time = connected_time
        # RemoteAddr
        self.remote_addr = remote_addr
        # Video
        self.video = video
        # Audio
        self.audio = audio

    def validate(self):
        self.validate_required(self.video, 'video')
        if self.video:
            self.video.validate()
        self.validate_required(self.audio, 'audio')
        if self.audio:
            self.audio.validate()

    def to_map(self):
        result = dict()
        if self.status is not None:
            result['Status'] = self.status
        if self.connected_time is not None:
            result['ConnectedTime'] = self.connected_time
        if self.remote_addr is not None:
            result['RemoteAddr'] = self.remote_addr
        if self.video is not None:
            result['Video'] = self.video.to_map()
        if self.audio is not None:
            result['Audio'] = self.audio.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('Status') is not None:
            self.status = m.get('Status')
        if m.get('ConnectedTime') is not None:
            self.connected_time = m.get('ConnectedTime')
        if m.get('RemoteAddr') is not None:
            self.remote_addr = m.get('RemoteAddr')
        if m.get('Video') is not None:
            temp_model = GetLiveChannelStatResponseLiveChannelStatVideo()
            self.video = temp_model.from_map(m['Video'])
        if m.get('Audio') is not None:
            temp_model = GetLiveChannelStatResponseLiveChannelStatAudio()
            self.audio = temp_model.from_map(m['Audio'])
        return self


class GetLiveChannelStatResponse(TeaModel):
    def __init__(
        self,
        request_id: str = None,
        live_channel_stat: GetLiveChannelStatResponseLiveChannelStat = None,
    ):
        # x-oss-request-id
        self.request_id = request_id
        # LiveChannelStat
        self.live_channel_stat = live_channel_stat

    def validate(self):
        self.validate_required(self.request_id, 'request_id')
        self.validate_required(self.live_channel_stat, 'live_channel_stat')
        if self.live_channel_stat:
            self.live_channel_stat.validate()

    def to_map(self):
        result = dict()
        if self.request_id is not None:
            result['x-oss-request-id'] = self.request_id
        if self.live_channel_stat is not None:
            result['LiveChannelStat'] = self.live_channel_stat.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('x-oss-request-id') is not None:
            self.request_id = m.get('x-oss-request-id')
        if m.get('LiveChannelStat') is not None:
            temp_model = GetLiveChannelStatResponseLiveChannelStat()
            self.live_channel_stat = temp_model.from_map(m['LiveChannelStat'])
        return self


class DeleteObjectRequest(TeaModel):
    def __init__(
        self,
        bucket_name: str = None,
        object_name: str = None,
    ):
        # BucketName
        self.bucket_name = bucket_name
        # ObjectName
        self.object_name = object_name

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')
        if self.bucket_name is not None:
            self.validate_pattern(self.bucket_name, 'bucket_name', '[a-zA-Z0-9-_]+')
        self.validate_required(self.object_name, 'object_name')

    def to_map(self):
        result = dict()
        if self.bucket_name is not None:
            result['BucketName'] = self.bucket_name
        if self.object_name is not None:
            result['ObjectName'] = self.object_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('BucketName') is not None:
            self.bucket_name = m.get('BucketName')
        if m.get('ObjectName') is not None:
            self.object_name = m.get('ObjectName')
        return self


class DeleteObjectResponse(TeaModel):
    def __init__(
        self,
        request_id: str = None,
    ):
        # x-oss-request-id
        self.request_id = request_id

    def validate(self):
        self.validate_required(self.request_id, 'request_id')

    def to_map(self):
        result = dict()
        if self.request_id is not None:
            result['x-oss-request-id'] = self.request_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('x-oss-request-id') is not None:
            self.request_id = m.get('x-oss-request-id')
        return self


class AbortMultipartUploadRequestFilter(TeaModel):
    def __init__(
        self,
        upload_id: str = None,
    ):
        # uploadId
        self.upload_id = upload_id

    def validate(self):
        self.validate_required(self.upload_id, 'upload_id')

    def to_map(self):
        result = dict()
        if self.upload_id is not None:
            result['uploadId'] = self.upload_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('uploadId') is not None:
            self.upload_id = m.get('uploadId')
        return self


class AbortMultipartUploadRequest(TeaModel):
    def __init__(
        self,
        bucket_name: str = None,
        object_name: str = None,
        filter: AbortMultipartUploadRequestFilter = None,
    ):
        # BucketName
        self.bucket_name = bucket_name
        # ObjectName
        self.object_name = object_name
        # Filter
        self.filter = filter

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')
        if self.bucket_name is not None:
            self.validate_pattern(self.bucket_name, 'bucket_name', '[a-zA-Z0-9-_]+')
        self.validate_required(self.object_name, 'object_name')
        self.validate_required(self.filter, 'filter')
        if self.filter:
            self.filter.validate()

    def to_map(self):
        result = dict()
        if self.bucket_name is not None:
            result['BucketName'] = self.bucket_name
        if self.object_name is not None:
            result['ObjectName'] = self.object_name
        if self.filter is not None:
            result['Filter'] = self.filter.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('BucketName') is not None:
            self.bucket_name = m.get('BucketName')
        if m.get('ObjectName') is not None:
            self.object_name = m.get('ObjectName')
        if m.get('Filter') is not None:
            temp_model = AbortMultipartUploadRequestFilter()
            self.filter = temp_model.from_map(m['Filter'])
        return self


class AbortMultipartUploadResponse(TeaModel):
    def __init__(
        self,
        request_id: str = None,
    ):
        # x-oss-request-id
        self.request_id = request_id

    def validate(self):
        self.validate_required(self.request_id, 'request_id')

    def to_map(self):
        result = dict()
        if self.request_id is not None:
            result['x-oss-request-id'] = self.request_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('x-oss-request-id') is not None:
            self.request_id = m.get('x-oss-request-id')
        return self


class AppendObjectRequestFilter(TeaModel):
    def __init__(
        self,
        position: str = None,
    ):
        # position
        self.position = position

    def validate(self):
        self.validate_required(self.position, 'position')

    def to_map(self):
        result = dict()
        if self.position is not None:
            result['position'] = self.position
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('position') is not None:
            self.position = m.get('position')
        return self


class AppendObjectRequestHeader(TeaModel):
    def __init__(
        self,
        cache_control: str = None,
        content_disposition: str = None,
        content_encoding: str = None,
        content_md5: str = None,
        expires: str = None,
        server_side_encryption: str = None,
        object_acl: str = None,
        storage_class: str = None,
        content_type: str = None,
    ):
        # Cache-Control
        self.cache_control = cache_control
        # Content-Disposition
        self.content_disposition = content_disposition
        # Content-Encoding
        self.content_encoding = content_encoding
        # Content-MD5
        self.content_md5 = content_md5
        # Expires
        self.expires = expires
        # x-oss-server-side-encryption
        self.server_side_encryption = server_side_encryption
        # x-oss-object-acl
        self.object_acl = object_acl
        # x-oss-storage-class
        self.storage_class = storage_class
        # content-type
        self.content_type = content_type

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.cache_control is not None:
            result['Cache-Control'] = self.cache_control
        if self.content_disposition is not None:
            result['Content-Disposition'] = self.content_disposition
        if self.content_encoding is not None:
            result['Content-Encoding'] = self.content_encoding
        if self.content_md5 is not None:
            result['Content-MD5'] = self.content_md5
        if self.expires is not None:
            result['Expires'] = self.expires
        if self.server_side_encryption is not None:
            result['x-oss-server-side-encryption'] = self.server_side_encryption
        if self.object_acl is not None:
            result['x-oss-object-acl'] = self.object_acl
        if self.storage_class is not None:
            result['x-oss-storage-class'] = self.storage_class
        if self.content_type is not None:
            result['content-type'] = self.content_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('Cache-Control') is not None:
            self.cache_control = m.get('Cache-Control')
        if m.get('Content-Disposition') is not None:
            self.content_disposition = m.get('Content-Disposition')
        if m.get('Content-Encoding') is not None:
            self.content_encoding = m.get('Content-Encoding')
        if m.get('Content-MD5') is not None:
            self.content_md5 = m.get('Content-MD5')
        if m.get('Expires') is not None:
            self.expires = m.get('Expires')
        if m.get('x-oss-server-side-encryption') is not None:
            self.server_side_encryption = m.get('x-oss-server-side-encryption')
        if m.get('x-oss-object-acl') is not None:
            self.object_acl = m.get('x-oss-object-acl')
        if m.get('x-oss-storage-class') is not None:
            self.storage_class = m.get('x-oss-storage-class')
        if m.get('content-type') is not None:
            self.content_type = m.get('content-type')
        return self


class AppendObjectRequest(TeaModel):
    def __init__(
        self,
        bucket_name: str = None,
        object_name: str = None,
        user_meta: Dict[str, str] = None,
        body: BinaryIO = None,
        filter: AppendObjectRequestFilter = None,
        header: AppendObjectRequestHeader = None,
    ):
        # BucketName
        self.bucket_name = bucket_name
        # ObjectName
        self.object_name = object_name
        # UserMeta
        self.user_meta = user_meta
        # body
        self.body = body
        # Filter
        self.filter = filter
        # Header
        self.header = header

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')
        if self.bucket_name is not None:
            self.validate_pattern(self.bucket_name, 'bucket_name', '[a-zA-Z0-9-_]+')
        self.validate_required(self.object_name, 'object_name')
        self.validate_required(self.filter, 'filter')
        if self.filter:
            self.filter.validate()
        if self.header:
            self.header.validate()

    def to_map(self):
        result = dict()
        if self.bucket_name is not None:
            result['BucketName'] = self.bucket_name
        if self.object_name is not None:
            result['ObjectName'] = self.object_name
        if self.user_meta is not None:
            result['UserMeta'] = self.user_meta
        if self.body is not None:
            result['body'] = self.body
        if self.filter is not None:
            result['Filter'] = self.filter.to_map()
        if self.header is not None:
            result['Header'] = self.header.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('BucketName') is not None:
            self.bucket_name = m.get('BucketName')
        if m.get('ObjectName') is not None:
            self.object_name = m.get('ObjectName')
        if m.get('UserMeta') is not None:
            self.user_meta = m.get('UserMeta')
        if m.get('body') is not None:
            self.body = m.get('body')
        if m.get('Filter') is not None:
            temp_model = AppendObjectRequestFilter()
            self.filter = temp_model.from_map(m['Filter'])
        if m.get('Header') is not None:
            temp_model = AppendObjectRequestHeader()
            self.header = temp_model.from_map(m['Header'])
        return self


class AppendObjectResponse(TeaModel):
    def __init__(
        self,
        request_id: str = None,
        next_append_position: str = None,
        hash_crc_64ecma: str = None,
    ):
        # x-oss-request-id
        self.request_id = request_id
        # x-oss-next-append-position
        self.next_append_position = next_append_position
        # x-oss-hash-crc64ecma
        self.hash_crc_64ecma = hash_crc_64ecma

    def validate(self):
        self.validate_required(self.request_id, 'request_id')
        self.validate_required(self.next_append_position, 'next_append_position')
        self.validate_required(self.hash_crc_64ecma, 'hash_crc_64ecma')

    def to_map(self):
        result = dict()
        if self.request_id is not None:
            result['x-oss-request-id'] = self.request_id
        if self.next_append_position is not None:
            result['x-oss-next-append-position'] = self.next_append_position
        if self.hash_crc_64ecma is not None:
            result['x-oss-hash-crc64ecma'] = self.hash_crc_64ecma
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('x-oss-request-id') is not None:
            self.request_id = m.get('x-oss-request-id')
        if m.get('x-oss-next-append-position') is not None:
            self.next_append_position = m.get('x-oss-next-append-position')
        if m.get('x-oss-hash-crc64ecma') is not None:
            self.hash_crc_64ecma = m.get('x-oss-hash-crc64ecma')
        return self


class UploadPartCopyRequestFilter(TeaModel):
    def __init__(
        self,
        part_number: str = None,
        upload_id: str = None,
    ):
        # partNumber
        self.part_number = part_number
        # uploadId
        self.upload_id = upload_id

    def validate(self):
        self.validate_required(self.part_number, 'part_number')
        self.validate_required(self.upload_id, 'upload_id')

    def to_map(self):
        result = dict()
        if self.part_number is not None:
            result['partNumber'] = self.part_number
        if self.upload_id is not None:
            result['uploadId'] = self.upload_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('partNumber') is not None:
            self.part_number = m.get('partNumber')
        if m.get('uploadId') is not None:
            self.upload_id = m.get('uploadId')
        return self


class UploadPartCopyRequestHeader(TeaModel):
    def __init__(
        self,
        copy_source: str = None,
        copy_source_range: str = None,
        copy_source_if_match: str = None,
        copy_source_if_none_match: str = None,
        copy_source_if_unmodified_since: str = None,
        copy_source_if_modified_since: str = None,
    ):
        # x-oss-copy-source
        self.copy_source = copy_source
        # x-oss-copy-source-range
        self.copy_source_range = copy_source_range
        # x-oss-copy-source-if-match
        self.copy_source_if_match = copy_source_if_match
        # x-oss-copy-source-if-none-match
        self.copy_source_if_none_match = copy_source_if_none_match
        # x-oss-copy-source-if-unmodified-since
        self.copy_source_if_unmodified_since = copy_source_if_unmodified_since
        # x-oss-copy-source-if-modified-since
        self.copy_source_if_modified_since = copy_source_if_modified_since

    def validate(self):
        self.validate_required(self.copy_source, 'copy_source')
        self.validate_required(self.copy_source_range, 'copy_source_range')

    def to_map(self):
        result = dict()
        if self.copy_source is not None:
            result['x-oss-copy-source'] = self.copy_source
        if self.copy_source_range is not None:
            result['x-oss-copy-source-range'] = self.copy_source_range
        if self.copy_source_if_match is not None:
            result['x-oss-copy-source-if-match'] = self.copy_source_if_match
        if self.copy_source_if_none_match is not None:
            result['x-oss-copy-source-if-none-match'] = self.copy_source_if_none_match
        if self.copy_source_if_unmodified_since is not None:
            result['x-oss-copy-source-if-unmodified-since'] = self.copy_source_if_unmodified_since
        if self.copy_source_if_modified_since is not None:
            result['x-oss-copy-source-if-modified-since'] = self.copy_source_if_modified_since
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('x-oss-copy-source') is not None:
            self.copy_source = m.get('x-oss-copy-source')
        if m.get('x-oss-copy-source-range') is not None:
            self.copy_source_range = m.get('x-oss-copy-source-range')
        if m.get('x-oss-copy-source-if-match') is not None:
            self.copy_source_if_match = m.get('x-oss-copy-source-if-match')
        if m.get('x-oss-copy-source-if-none-match') is not None:
            self.copy_source_if_none_match = m.get('x-oss-copy-source-if-none-match')
        if m.get('x-oss-copy-source-if-unmodified-since') is not None:
            self.copy_source_if_unmodified_since = m.get('x-oss-copy-source-if-unmodified-since')
        if m.get('x-oss-copy-source-if-modified-since') is not None:
            self.copy_source_if_modified_since = m.get('x-oss-copy-source-if-modified-since')
        return self


class UploadPartCopyRequest(TeaModel):
    def __init__(
        self,
        bucket_name: str = None,
        object_name: str = None,
        filter: UploadPartCopyRequestFilter = None,
        header: UploadPartCopyRequestHeader = None,
    ):
        # BucketName
        self.bucket_name = bucket_name
        # ObjectName
        self.object_name = object_name
        # Filter
        self.filter = filter
        # Header
        self.header = header

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')
        if self.bucket_name is not None:
            self.validate_pattern(self.bucket_name, 'bucket_name', '[a-zA-Z0-9-_]+')
        self.validate_required(self.object_name, 'object_name')
        self.validate_required(self.filter, 'filter')
        if self.filter:
            self.filter.validate()
        self.validate_required(self.header, 'header')
        if self.header:
            self.header.validate()

    def to_map(self):
        result = dict()
        if self.bucket_name is not None:
            result['BucketName'] = self.bucket_name
        if self.object_name is not None:
            result['ObjectName'] = self.object_name
        if self.filter is not None:
            result['Filter'] = self.filter.to_map()
        if self.header is not None:
            result['Header'] = self.header.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('BucketName') is not None:
            self.bucket_name = m.get('BucketName')
        if m.get('ObjectName') is not None:
            self.object_name = m.get('ObjectName')
        if m.get('Filter') is not None:
            temp_model = UploadPartCopyRequestFilter()
            self.filter = temp_model.from_map(m['Filter'])
        if m.get('Header') is not None:
            temp_model = UploadPartCopyRequestHeader()
            self.header = temp_model.from_map(m['Header'])
        return self


class UploadPartCopyResponseCopyPartResult(TeaModel):
    def __init__(
        self,
        last_modified: str = None,
        e_tag: str = None,
    ):
        # LastModified
        self.last_modified = last_modified
        # ETag
        self.e_tag = e_tag

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.last_modified is not None:
            result['LastModified'] = self.last_modified
        if self.e_tag is not None:
            result['ETag'] = self.e_tag
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('LastModified') is not None:
            self.last_modified = m.get('LastModified')
        if m.get('ETag') is not None:
            self.e_tag = m.get('ETag')
        return self


class UploadPartCopyResponse(TeaModel):
    def __init__(
        self,
        request_id: str = None,
        copy_part_result: UploadPartCopyResponseCopyPartResult = None,
    ):
        # x-oss-request-id
        self.request_id = request_id
        # CopyPartResult
        self.copy_part_result = copy_part_result

    def validate(self):
        self.validate_required(self.request_id, 'request_id')
        self.validate_required(self.copy_part_result, 'copy_part_result')
        if self.copy_part_result:
            self.copy_part_result.validate()

    def to_map(self):
        result = dict()
        if self.request_id is not None:
            result['x-oss-request-id'] = self.request_id
        if self.copy_part_result is not None:
            result['CopyPartResult'] = self.copy_part_result.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('x-oss-request-id') is not None:
            self.request_id = m.get('x-oss-request-id')
        if m.get('CopyPartResult') is not None:
            temp_model = UploadPartCopyResponseCopyPartResult()
            self.copy_part_result = temp_model.from_map(m['CopyPartResult'])
        return self


class GetVodPlaylistRequestFilter(TeaModel):
    def __init__(
        self,
        end_time: str = None,
        start_time: str = None,
    ):
        # endTime
        self.end_time = end_time
        # startTime
        self.start_time = start_time

    def validate(self):
        self.validate_required(self.end_time, 'end_time')
        self.validate_required(self.start_time, 'start_time')

    def to_map(self):
        result = dict()
        if self.end_time is not None:
            result['endTime'] = self.end_time
        if self.start_time is not None:
            result['startTime'] = self.start_time
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        return self


class GetVodPlaylistRequest(TeaModel):
    def __init__(
        self,
        bucket_name: str = None,
        channel_name: str = None,
        filter: GetVodPlaylistRequestFilter = None,
    ):
        # BucketName
        self.bucket_name = bucket_name
        # ChannelName
        self.channel_name = channel_name
        # Filter
        self.filter = filter

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')
        if self.bucket_name is not None:
            self.validate_pattern(self.bucket_name, 'bucket_name', '[a-zA-Z0-9-_]+')
        self.validate_required(self.channel_name, 'channel_name')
        self.validate_required(self.filter, 'filter')
        if self.filter:
            self.filter.validate()

    def to_map(self):
        result = dict()
        if self.bucket_name is not None:
            result['BucketName'] = self.bucket_name
        if self.channel_name is not None:
            result['ChannelName'] = self.channel_name
        if self.filter is not None:
            result['Filter'] = self.filter.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('BucketName') is not None:
            self.bucket_name = m.get('BucketName')
        if m.get('ChannelName') is not None:
            self.channel_name = m.get('ChannelName')
        if m.get('Filter') is not None:
            temp_model = GetVodPlaylistRequestFilter()
            self.filter = temp_model.from_map(m['Filter'])
        return self


class GetVodPlaylistResponse(TeaModel):
    def __init__(
        self,
        request_id: str = None,
    ):
        # x-oss-request-id
        self.request_id = request_id

    def validate(self):
        self.validate_required(self.request_id, 'request_id')

    def to_map(self):
        result = dict()
        if self.request_id is not None:
            result['x-oss-request-id'] = self.request_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('x-oss-request-id') is not None:
            self.request_id = m.get('x-oss-request-id')
        return self


class DeleteBucketCORSRequest(TeaModel):
    def __init__(
        self,
        bucket_name: str = None,
    ):
        # BucketName
        self.bucket_name = bucket_name

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')
        if self.bucket_name is not None:
            self.validate_pattern(self.bucket_name, 'bucket_name', '[a-zA-Z0-9-_]+')

    def to_map(self):
        result = dict()
        if self.bucket_name is not None:
            result['BucketName'] = self.bucket_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('BucketName') is not None:
            self.bucket_name = m.get('BucketName')
        return self


class DeleteBucketCORSResponse(TeaModel):
    def __init__(
        self,
        request_id: str = None,
    ):
        # x-oss-request-id
        self.request_id = request_id

    def validate(self):
        self.validate_required(self.request_id, 'request_id')

    def to_map(self):
        result = dict()
        if self.request_id is not None:
            result['x-oss-request-id'] = self.request_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('x-oss-request-id') is not None:
            self.request_id = m.get('x-oss-request-id')
        return self


class GetObjectRequestHeader(TeaModel):
    def __init__(
        self,
        response_content_type: str = None,
        response_content_language: str = None,
        response_expires: str = None,
        response_cache_control: str = None,
        response_content_disposition: str = None,
        response_content_encoding: str = None,
        range: str = None,
        if_modified_since: str = None,
        if_unmodified_since: str = None,
        if_match: str = None,
        if_none_match: str = None,
        accept_encoding: str = None,
    ):
        # response-content-type
        self.response_content_type = response_content_type
        # response-content-language
        self.response_content_language = response_content_language
        # response-expires
        self.response_expires = response_expires
        # response-cache-control
        self.response_cache_control = response_cache_control
        # response-content-disposition
        self.response_content_disposition = response_content_disposition
        # response-content-encoding
        self.response_content_encoding = response_content_encoding
        # Range
        self.range = range
        # If-Modified-Since
        self.if_modified_since = if_modified_since
        # If-Unmodified-Since
        self.if_unmodified_since = if_unmodified_since
        # If-Match
        self.if_match = if_match
        # If-None-Match
        self.if_none_match = if_none_match
        # Accept-Encoding
        self.accept_encoding = accept_encoding

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.response_content_type is not None:
            result['response-content-type'] = self.response_content_type
        if self.response_content_language is not None:
            result['response-content-language'] = self.response_content_language
        if self.response_expires is not None:
            result['response-expires'] = self.response_expires
        if self.response_cache_control is not None:
            result['response-cache-control'] = self.response_cache_control
        if self.response_content_disposition is not None:
            result['response-content-disposition'] = self.response_content_disposition
        if self.response_content_encoding is not None:
            result['response-content-encoding'] = self.response_content_encoding
        if self.range is not None:
            result['Range'] = self.range
        if self.if_modified_since is not None:
            result['If-Modified-Since'] = self.if_modified_since
        if self.if_unmodified_since is not None:
            result['If-Unmodified-Since'] = self.if_unmodified_since
        if self.if_match is not None:
            result['If-Match'] = self.if_match
        if self.if_none_match is not None:
            result['If-None-Match'] = self.if_none_match
        if self.accept_encoding is not None:
            result['Accept-Encoding'] = self.accept_encoding
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('response-content-type') is not None:
            self.response_content_type = m.get('response-content-type')
        if m.get('response-content-language') is not None:
            self.response_content_language = m.get('response-content-language')
        if m.get('response-expires') is not None:
            self.response_expires = m.get('response-expires')
        if m.get('response-cache-control') is not None:
            self.response_cache_control = m.get('response-cache-control')
        if m.get('response-content-disposition') is not None:
            self.response_content_disposition = m.get('response-content-disposition')
        if m.get('response-content-encoding') is not None:
            self.response_content_encoding = m.get('response-content-encoding')
        if m.get('Range') is not None:
            self.range = m.get('Range')
        if m.get('If-Modified-Since') is not None:
            self.if_modified_since = m.get('If-Modified-Since')
        if m.get('If-Unmodified-Since') is not None:
            self.if_unmodified_since = m.get('If-Unmodified-Since')
        if m.get('If-Match') is not None:
            self.if_match = m.get('If-Match')
        if m.get('If-None-Match') is not None:
            self.if_none_match = m.get('If-None-Match')
        if m.get('Accept-Encoding') is not None:
            self.accept_encoding = m.get('Accept-Encoding')
        return self


class GetObjectRequest(TeaModel):
    def __init__(
        self,
        bucket_name: str = None,
        object_name: str = None,
        header: GetObjectRequestHeader = None,
    ):
        # BucketName
        self.bucket_name = bucket_name
        # ObjectName
        self.object_name = object_name
        # Header
        self.header = header

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')
        if self.bucket_name is not None:
            self.validate_pattern(self.bucket_name, 'bucket_name', '[a-zA-Z0-9-_]+')
        self.validate_required(self.object_name, 'object_name')
        if self.header:
            self.header.validate()

    def to_map(self):
        result = dict()
        if self.bucket_name is not None:
            result['BucketName'] = self.bucket_name
        if self.object_name is not None:
            result['ObjectName'] = self.object_name
        if self.header is not None:
            result['Header'] = self.header.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('BucketName') is not None:
            self.bucket_name = m.get('BucketName')
        if m.get('ObjectName') is not None:
            self.object_name = m.get('ObjectName')
        if m.get('Header') is not None:
            temp_model = GetObjectRequestHeader()
            self.header = temp_model.from_map(m['Header'])
        return self


class GetObjectResponse(TeaModel):
    def __init__(
        self,
        request_id: str = None,
        object_type: str = None,
        server_side_encryption: str = None,
        tagging_count: str = None,
        restore: str = None,
        body: BinaryIO = None,
    ):
        # x-oss-request-id
        self.request_id = request_id
        # x-oss-object-type
        self.object_type = object_type
        # x-oss-server-side-encryption
        self.server_side_encryption = server_side_encryption
        # x-oss-tagging-count
        self.tagging_count = tagging_count
        # x-oss-restore
        self.restore = restore
        # body
        self.body = body

    def validate(self):
        self.validate_required(self.request_id, 'request_id')
        self.validate_required(self.object_type, 'object_type')
        self.validate_required(self.server_side_encryption, 'server_side_encryption')
        self.validate_required(self.tagging_count, 'tagging_count')
        self.validate_required(self.restore, 'restore')
        self.validate_required(self.body, 'body')

    def to_map(self):
        result = dict()
        if self.request_id is not None:
            result['x-oss-request-id'] = self.request_id
        if self.object_type is not None:
            result['x-oss-object-type'] = self.object_type
        if self.server_side_encryption is not None:
            result['x-oss-server-side-encryption'] = self.server_side_encryption
        if self.tagging_count is not None:
            result['x-oss-tagging-count'] = self.tagging_count
        if self.restore is not None:
            result['x-oss-restore'] = self.restore
        if self.body is not None:
            result['body'] = self.body
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('x-oss-request-id') is not None:
            self.request_id = m.get('x-oss-request-id')
        if m.get('x-oss-object-type') is not None:
            self.object_type = m.get('x-oss-object-type')
        if m.get('x-oss-server-side-encryption') is not None:
            self.server_side_encryption = m.get('x-oss-server-side-encryption')
        if m.get('x-oss-tagging-count') is not None:
            self.tagging_count = m.get('x-oss-tagging-count')
        if m.get('x-oss-restore') is not None:
            self.restore = m.get('x-oss-restore')
        if m.get('body') is not None:
            self.body = m.get('body')
        return self


class UploadPartRequestFilter(TeaModel):
    def __init__(
        self,
        part_number: str = None,
        upload_id: str = None,
    ):
        # partNumber
        self.part_number = part_number
        # uploadId
        self.upload_id = upload_id

    def validate(self):
        self.validate_required(self.part_number, 'part_number')
        self.validate_required(self.upload_id, 'upload_id')

    def to_map(self):
        result = dict()
        if self.part_number is not None:
            result['partNumber'] = self.part_number
        if self.upload_id is not None:
            result['uploadId'] = self.upload_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('partNumber') is not None:
            self.part_number = m.get('partNumber')
        if m.get('uploadId') is not None:
            self.upload_id = m.get('uploadId')
        return self


class UploadPartRequest(TeaModel):
    def __init__(
        self,
        bucket_name: str = None,
        object_name: str = None,
        body: BinaryIO = None,
        filter: UploadPartRequestFilter = None,
    ):
        # BucketName
        self.bucket_name = bucket_name
        # ObjectName
        self.object_name = object_name
        # body
        self.body = body
        # Filter
        self.filter = filter

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')
        if self.bucket_name is not None:
            self.validate_pattern(self.bucket_name, 'bucket_name', '[a-zA-Z0-9-_]+')
        self.validate_required(self.object_name, 'object_name')
        self.validate_required(self.filter, 'filter')
        if self.filter:
            self.filter.validate()

    def to_map(self):
        result = dict()
        if self.bucket_name is not None:
            result['BucketName'] = self.bucket_name
        if self.object_name is not None:
            result['ObjectName'] = self.object_name
        if self.body is not None:
            result['body'] = self.body
        if self.filter is not None:
            result['Filter'] = self.filter.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('BucketName') is not None:
            self.bucket_name = m.get('BucketName')
        if m.get('ObjectName') is not None:
            self.object_name = m.get('ObjectName')
        if m.get('body') is not None:
            self.body = m.get('body')
        if m.get('Filter') is not None:
            temp_model = UploadPartRequestFilter()
            self.filter = temp_model.from_map(m['Filter'])
        return self


class UploadPartResponse(TeaModel):
    def __init__(
        self,
        request_id: str = None,
    ):
        # x-oss-request-id
        self.request_id = request_id

    def validate(self):
        self.validate_required(self.request_id, 'request_id')

    def to_map(self):
        result = dict()
        if self.request_id is not None:
            result['x-oss-request-id'] = self.request_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('x-oss-request-id') is not None:
            self.request_id = m.get('x-oss-request-id')
        return self


class GetBucketCORSRequest(TeaModel):
    def __init__(
        self,
        bucket_name: str = None,
    ):
        # BucketName
        self.bucket_name = bucket_name

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')
        if self.bucket_name is not None:
            self.validate_pattern(self.bucket_name, 'bucket_name', '[a-zA-Z0-9-_]+')

    def to_map(self):
        result = dict()
        if self.bucket_name is not None:
            result['BucketName'] = self.bucket_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('BucketName') is not None:
            self.bucket_name = m.get('BucketName')
        return self


class GetBucketCORSResponseCORSConfigurationCORSRule(TeaModel):
    def __init__(
        self,
        max_age_seconds: str = None,
    ):
        # MaxAgeSeconds
        self.max_age_seconds = max_age_seconds

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.max_age_seconds is not None:
            result['MaxAgeSeconds'] = self.max_age_seconds
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('MaxAgeSeconds') is not None:
            self.max_age_seconds = m.get('MaxAgeSeconds')
        return self


class GetBucketCORSResponseCORSConfiguration(TeaModel):
    def __init__(
        self,
        c_orsrule: List[GetBucketCORSResponseCORSConfigurationCORSRule] = None,
    ):
        # CORSRule
        self.c_orsrule = c_orsrule

    def validate(self):
        if self.c_orsrule:
            for k in self.c_orsrule:
                if k:
                    k.validate()

    def to_map(self):
        result = dict()
        result['CORSRule'] = []
        if self.c_orsrule is not None:
            for k in self.c_orsrule:
                result['CORSRule'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.c_orsrule = []
        if m.get('CORSRule') is not None:
            for k in m.get('CORSRule'):
                temp_model = GetBucketCORSResponseCORSConfigurationCORSRule()
                self.c_orsrule.append(temp_model.from_map(k))
        return self


class GetBucketCORSResponse(TeaModel):
    def __init__(
        self,
        request_id: str = None,
        c_orsconfiguration: GetBucketCORSResponseCORSConfiguration = None,
    ):
        # x-oss-request-id
        self.request_id = request_id
        # CORSConfiguration
        self.c_orsconfiguration = c_orsconfiguration

    def validate(self):
        self.validate_required(self.request_id, 'request_id')
        self.validate_required(self.c_orsconfiguration, 'c_orsconfiguration')
        if self.c_orsconfiguration:
            self.c_orsconfiguration.validate()

    def to_map(self):
        result = dict()
        if self.request_id is not None:
            result['x-oss-request-id'] = self.request_id
        if self.c_orsconfiguration is not None:
            result['CORSConfiguration'] = self.c_orsconfiguration.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('x-oss-request-id') is not None:
            self.request_id = m.get('x-oss-request-id')
        if m.get('CORSConfiguration') is not None:
            temp_model = GetBucketCORSResponseCORSConfiguration()
            self.c_orsconfiguration = temp_model.from_map(m['CORSConfiguration'])
        return self


class CopyObjectRequestHeader(TeaModel):
    def __init__(
        self,
        copy_source: str = None,
        copy_source_if_match: str = None,
        copy_source_if_none_match: str = None,
        copy_source_if_unmodified_since: str = None,
        copy_source_if_modified_since: str = None,
        metadata_directive: str = None,
        server_side_encryption: str = None,
        server_side_encryption_key_id: str = None,
        object_acl: str = None,
        storage_class: str = None,
        tagging: str = None,
        tagging_directive: str = None,
    ):
        # x-oss-copy-source
        self.copy_source = copy_source
        # x-oss-copy-source-if-match
        self.copy_source_if_match = copy_source_if_match
        # x-oss-copy-source-if-none-match
        self.copy_source_if_none_match = copy_source_if_none_match
        # x-oss-copy-source-if-unmodified-since
        self.copy_source_if_unmodified_since = copy_source_if_unmodified_since
        # x-oss-copy-source-if-modified-since
        self.copy_source_if_modified_since = copy_source_if_modified_since
        # x-oss-metadata-directive
        self.metadata_directive = metadata_directive
        # x-oss-server-side-encryption
        self.server_side_encryption = server_side_encryption
        # x-oss-server-side-encryption-key-id
        self.server_side_encryption_key_id = server_side_encryption_key_id
        # x-oss-object-acl
        self.object_acl = object_acl
        # x-oss-storage-class
        self.storage_class = storage_class
        # x-oss-tagging
        self.tagging = tagging
        # x-oss-tagging-directive
        self.tagging_directive = tagging_directive

    def validate(self):
        self.validate_required(self.copy_source, 'copy_source')

    def to_map(self):
        result = dict()
        if self.copy_source is not None:
            result['x-oss-copy-source'] = self.copy_source
        if self.copy_source_if_match is not None:
            result['x-oss-copy-source-if-match'] = self.copy_source_if_match
        if self.copy_source_if_none_match is not None:
            result['x-oss-copy-source-if-none-match'] = self.copy_source_if_none_match
        if self.copy_source_if_unmodified_since is not None:
            result['x-oss-copy-source-if-unmodified-since'] = self.copy_source_if_unmodified_since
        if self.copy_source_if_modified_since is not None:
            result['x-oss-copy-source-if-modified-since'] = self.copy_source_if_modified_since
        if self.metadata_directive is not None:
            result['x-oss-metadata-directive'] = self.metadata_directive
        if self.server_side_encryption is not None:
            result['x-oss-server-side-encryption'] = self.server_side_encryption
        if self.server_side_encryption_key_id is not None:
            result['x-oss-server-side-encryption-key-id'] = self.server_side_encryption_key_id
        if self.object_acl is not None:
            result['x-oss-object-acl'] = self.object_acl
        if self.storage_class is not None:
            result['x-oss-storage-class'] = self.storage_class
        if self.tagging is not None:
            result['x-oss-tagging'] = self.tagging
        if self.tagging_directive is not None:
            result['x-oss-tagging-directive'] = self.tagging_directive
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('x-oss-copy-source') is not None:
            self.copy_source = m.get('x-oss-copy-source')
        if m.get('x-oss-copy-source-if-match') is not None:
            self.copy_source_if_match = m.get('x-oss-copy-source-if-match')
        if m.get('x-oss-copy-source-if-none-match') is not None:
            self.copy_source_if_none_match = m.get('x-oss-copy-source-if-none-match')
        if m.get('x-oss-copy-source-if-unmodified-since') is not None:
            self.copy_source_if_unmodified_since = m.get('x-oss-copy-source-if-unmodified-since')
        if m.get('x-oss-copy-source-if-modified-since') is not None:
            self.copy_source_if_modified_since = m.get('x-oss-copy-source-if-modified-since')
        if m.get('x-oss-metadata-directive') is not None:
            self.metadata_directive = m.get('x-oss-metadata-directive')
        if m.get('x-oss-server-side-encryption') is not None:
            self.server_side_encryption = m.get('x-oss-server-side-encryption')
        if m.get('x-oss-server-side-encryption-key-id') is not None:
            self.server_side_encryption_key_id = m.get('x-oss-server-side-encryption-key-id')
        if m.get('x-oss-object-acl') is not None:
            self.object_acl = m.get('x-oss-object-acl')
        if m.get('x-oss-storage-class') is not None:
            self.storage_class = m.get('x-oss-storage-class')
        if m.get('x-oss-tagging') is not None:
            self.tagging = m.get('x-oss-tagging')
        if m.get('x-oss-tagging-directive') is not None:
            self.tagging_directive = m.get('x-oss-tagging-directive')
        return self


class CopyObjectRequest(TeaModel):
    def __init__(
        self,
        bucket_name: str = None,
        dest_object_name: str = None,
        header: CopyObjectRequestHeader = None,
    ):
        # BucketName
        self.bucket_name = bucket_name
        # DestObjectName
        self.dest_object_name = dest_object_name
        # Header
        self.header = header

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')
        if self.bucket_name is not None:
            self.validate_pattern(self.bucket_name, 'bucket_name', '[a-zA-Z0-9-_]+')
        self.validate_required(self.dest_object_name, 'dest_object_name')
        self.validate_required(self.header, 'header')
        if self.header:
            self.header.validate()

    def to_map(self):
        result = dict()
        if self.bucket_name is not None:
            result['BucketName'] = self.bucket_name
        if self.dest_object_name is not None:
            result['DestObjectName'] = self.dest_object_name
        if self.header is not None:
            result['Header'] = self.header.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('BucketName') is not None:
            self.bucket_name = m.get('BucketName')
        if m.get('DestObjectName') is not None:
            self.dest_object_name = m.get('DestObjectName')
        if m.get('Header') is not None:
            temp_model = CopyObjectRequestHeader()
            self.header = temp_model.from_map(m['Header'])
        return self


class CopyObjectResponseCopyObjectResult(TeaModel):
    def __init__(
        self,
        last_modified: str = None,
        e_tag: str = None,
    ):
        # LastModified
        self.last_modified = last_modified
        # ETag
        self.e_tag = e_tag

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.last_modified is not None:
            result['LastModified'] = self.last_modified
        if self.e_tag is not None:
            result['ETag'] = self.e_tag
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('LastModified') is not None:
            self.last_modified = m.get('LastModified')
        if m.get('ETag') is not None:
            self.e_tag = m.get('ETag')
        return self


class CopyObjectResponse(TeaModel):
    def __init__(
        self,
        request_id: str = None,
        copy_object_result: CopyObjectResponseCopyObjectResult = None,
    ):
        # x-oss-request-id
        self.request_id = request_id
        # CopyObjectResult
        self.copy_object_result = copy_object_result

    def validate(self):
        self.validate_required(self.request_id, 'request_id')
        self.validate_required(self.copy_object_result, 'copy_object_result')
        if self.copy_object_result:
            self.copy_object_result.validate()

    def to_map(self):
        result = dict()
        if self.request_id is not None:
            result['x-oss-request-id'] = self.request_id
        if self.copy_object_result is not None:
            result['CopyObjectResult'] = self.copy_object_result.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('x-oss-request-id') is not None:
            self.request_id = m.get('x-oss-request-id')
        if m.get('CopyObjectResult') is not None:
            temp_model = CopyObjectResponseCopyObjectResult()
            self.copy_object_result = temp_model.from_map(m['CopyObjectResult'])
        return self


class GetObjectTaggingRequest(TeaModel):
    def __init__(
        self,
        bucket_name: str = None,
        object_name: str = None,
    ):
        # BucketName
        self.bucket_name = bucket_name
        # ObjectName
        self.object_name = object_name

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')
        if self.bucket_name is not None:
            self.validate_pattern(self.bucket_name, 'bucket_name', '[a-zA-Z0-9-_]+')
        self.validate_required(self.object_name, 'object_name')

    def to_map(self):
        result = dict()
        if self.bucket_name is not None:
            result['BucketName'] = self.bucket_name
        if self.object_name is not None:
            result['ObjectName'] = self.object_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('BucketName') is not None:
            self.bucket_name = m.get('BucketName')
        if m.get('ObjectName') is not None:
            self.object_name = m.get('ObjectName')
        return self


class GetObjectTaggingResponseTaggingTagSetTag(TeaModel):
    def __init__(
        self,
        key: str = None,
        value: str = None,
    ):
        # Key
        self.key = key
        # Value
        self.value = value

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.key is not None:
            result['Key'] = self.key
        if self.value is not None:
            result['Value'] = self.value
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('Key') is not None:
            self.key = m.get('Key')
        if m.get('Value') is not None:
            self.value = m.get('Value')
        return self


class GetObjectTaggingResponseTaggingTagSet(TeaModel):
    def __init__(
        self,
        tag: List[GetObjectTaggingResponseTaggingTagSetTag] = None,
    ):
        # Tag
        self.tag = tag

    def validate(self):
        if self.tag:
            for k in self.tag:
                if k:
                    k.validate()

    def to_map(self):
        result = dict()
        result['Tag'] = []
        if self.tag is not None:
            for k in self.tag:
                result['Tag'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.tag = []
        if m.get('Tag') is not None:
            for k in m.get('Tag'):
                temp_model = GetObjectTaggingResponseTaggingTagSetTag()
                self.tag.append(temp_model.from_map(k))
        return self


class GetObjectTaggingResponseTagging(TeaModel):
    def __init__(
        self,
        tag_set: GetObjectTaggingResponseTaggingTagSet = None,
    ):
        # TagSet
        self.tag_set = tag_set

    def validate(self):
        self.validate_required(self.tag_set, 'tag_set')
        if self.tag_set:
            self.tag_set.validate()

    def to_map(self):
        result = dict()
        if self.tag_set is not None:
            result['TagSet'] = self.tag_set.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('TagSet') is not None:
            temp_model = GetObjectTaggingResponseTaggingTagSet()
            self.tag_set = temp_model.from_map(m['TagSet'])
        return self


class GetObjectTaggingResponse(TeaModel):
    def __init__(
        self,
        request_id: str = None,
        tagging: GetObjectTaggingResponseTagging = None,
    ):
        # x-oss-request-id
        self.request_id = request_id
        # Tagging
        self.tagging = tagging

    def validate(self):
        self.validate_required(self.request_id, 'request_id')
        self.validate_required(self.tagging, 'tagging')
        if self.tagging:
            self.tagging.validate()

    def to_map(self):
        result = dict()
        if self.request_id is not None:
            result['x-oss-request-id'] = self.request_id
        if self.tagging is not None:
            result['Tagging'] = self.tagging.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('x-oss-request-id') is not None:
            self.request_id = m.get('x-oss-request-id')
        if m.get('Tagging') is not None:
            temp_model = GetObjectTaggingResponseTagging()
            self.tagging = temp_model.from_map(m['Tagging'])
        return self


class DeleteBucketLifecycleRequest(TeaModel):
    def __init__(
        self,
        bucket_name: str = None,
    ):
        # BucketName
        self.bucket_name = bucket_name

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')
        if self.bucket_name is not None:
            self.validate_pattern(self.bucket_name, 'bucket_name', '[a-zA-Z0-9-_]+')

    def to_map(self):
        result = dict()
        if self.bucket_name is not None:
            result['BucketName'] = self.bucket_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('BucketName') is not None:
            self.bucket_name = m.get('BucketName')
        return self


class DeleteBucketLifecycleResponse(TeaModel):
    def __init__(
        self,
        request_id: str = None,
    ):
        # x-oss-request-id
        self.request_id = request_id

    def validate(self):
        self.validate_required(self.request_id, 'request_id')

    def to_map(self):
        result = dict()
        if self.request_id is not None:
            result['x-oss-request-id'] = self.request_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('x-oss-request-id') is not None:
            self.request_id = m.get('x-oss-request-id')
        return self


class DeleteBucketLoggingRequest(TeaModel):
    def __init__(
        self,
        bucket_name: str = None,
    ):
        # BucketName
        self.bucket_name = bucket_name

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')
        if self.bucket_name is not None:
            self.validate_pattern(self.bucket_name, 'bucket_name', '[a-zA-Z0-9-_]+')

    def to_map(self):
        result = dict()
        if self.bucket_name is not None:
            result['BucketName'] = self.bucket_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('BucketName') is not None:
            self.bucket_name = m.get('BucketName')
        return self


class DeleteBucketLoggingResponse(TeaModel):
    def __init__(
        self,
        request_id: str = None,
    ):
        # x-oss-request-id
        self.request_id = request_id

    def validate(self):
        self.validate_required(self.request_id, 'request_id')

    def to_map(self):
        result = dict()
        if self.request_id is not None:
            result['x-oss-request-id'] = self.request_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('x-oss-request-id') is not None:
            self.request_id = m.get('x-oss-request-id')
        return self


class DeleteBucketWebsiteRequest(TeaModel):
    def __init__(
        self,
        bucket_name: str = None,
    ):
        # BucketName
        self.bucket_name = bucket_name

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')
        if self.bucket_name is not None:
            self.validate_pattern(self.bucket_name, 'bucket_name', '[a-zA-Z0-9-_]+')

    def to_map(self):
        result = dict()
        if self.bucket_name is not None:
            result['BucketName'] = self.bucket_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('BucketName') is not None:
            self.bucket_name = m.get('BucketName')
        return self


class DeleteBucketWebsiteResponse(TeaModel):
    def __init__(
        self,
        request_id: str = None,
    ):
        # x-oss-request-id
        self.request_id = request_id

    def validate(self):
        self.validate_required(self.request_id, 'request_id')

    def to_map(self):
        result = dict()
        if self.request_id is not None:
            result['x-oss-request-id'] = self.request_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('x-oss-request-id') is not None:
            self.request_id = m.get('x-oss-request-id')
        return self


class GetSymlinkRequest(TeaModel):
    def __init__(
        self,
        bucket_name: str = None,
        object_name: str = None,
    ):
        # BucketName
        self.bucket_name = bucket_name
        # ObjectName
        self.object_name = object_name

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')
        if self.bucket_name is not None:
            self.validate_pattern(self.bucket_name, 'bucket_name', '[a-zA-Z0-9-_]+')
        self.validate_required(self.object_name, 'object_name')

    def to_map(self):
        result = dict()
        if self.bucket_name is not None:
            result['BucketName'] = self.bucket_name
        if self.object_name is not None:
            result['ObjectName'] = self.object_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('BucketName') is not None:
            self.bucket_name = m.get('BucketName')
        if m.get('ObjectName') is not None:
            self.object_name = m.get('ObjectName')
        return self


class GetSymlinkResponse(TeaModel):
    def __init__(
        self,
        request_id: str = None,
        symlink_target: str = None,
    ):
        # x-oss-request-id
        self.request_id = request_id
        # x-oss-symlink-target
        self.symlink_target = symlink_target

    def validate(self):
        self.validate_required(self.request_id, 'request_id')
        self.validate_required(self.symlink_target, 'symlink_target')

    def to_map(self):
        result = dict()
        if self.request_id is not None:
            result['x-oss-request-id'] = self.request_id
        if self.symlink_target is not None:
            result['x-oss-symlink-target'] = self.symlink_target
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('x-oss-request-id') is not None:
            self.request_id = m.get('x-oss-request-id')
        if m.get('x-oss-symlink-target') is not None:
            self.symlink_target = m.get('x-oss-symlink-target')
        return self


class GetBucketLifecycleRequest(TeaModel):
    def __init__(
        self,
        bucket_name: str = None,
    ):
        # BucketName
        self.bucket_name = bucket_name

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')
        if self.bucket_name is not None:
            self.validate_pattern(self.bucket_name, 'bucket_name', '[a-zA-Z0-9-_]+')

    def to_map(self):
        result = dict()
        if self.bucket_name is not None:
            result['BucketName'] = self.bucket_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('BucketName') is not None:
            self.bucket_name = m.get('BucketName')
        return self


class GetBucketLifecycleResponseLifecycleConfigurationRuleExpiration(TeaModel):
    def __init__(
        self,
        days: int = None,
        created_before_date: str = None,
    ):
        # Days
        self.days = days
        # CreatedBeforeDate
        self.created_before_date = created_before_date

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.days is not None:
            result['Days'] = self.days
        if self.created_before_date is not None:
            result['CreatedBeforeDate'] = self.created_before_date
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('Days') is not None:
            self.days = m.get('Days')
        if m.get('CreatedBeforeDate') is not None:
            self.created_before_date = m.get('CreatedBeforeDate')
        return self


class GetBucketLifecycleResponseLifecycleConfigurationRuleTransition(TeaModel):
    def __init__(
        self,
        days: int = None,
        storage_class: str = None,
    ):
        # Days
        self.days = days
        # StorageClass
        self.storage_class = storage_class

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.days is not None:
            result['Days'] = self.days
        if self.storage_class is not None:
            result['StorageClass'] = self.storage_class
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('Days') is not None:
            self.days = m.get('Days')
        if m.get('StorageClass') is not None:
            self.storage_class = m.get('StorageClass')
        return self


class GetBucketLifecycleResponseLifecycleConfigurationRuleAbortMultipartUpload(TeaModel):
    def __init__(
        self,
        days: int = None,
        created_before_date: str = None,
    ):
        # Days
        self.days = days
        # CreatedBeforeDate
        self.created_before_date = created_before_date

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.days is not None:
            result['Days'] = self.days
        if self.created_before_date is not None:
            result['CreatedBeforeDate'] = self.created_before_date
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('Days') is not None:
            self.days = m.get('Days')
        if m.get('CreatedBeforeDate') is not None:
            self.created_before_date = m.get('CreatedBeforeDate')
        return self


class GetBucketLifecycleResponseLifecycleConfigurationRuleTag(TeaModel):
    def __init__(
        self,
        key: str = None,
        value: str = None,
    ):
        # Key
        self.key = key
        # Value
        self.value = value

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.key is not None:
            result['Key'] = self.key
        if self.value is not None:
            result['Value'] = self.value
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('Key') is not None:
            self.key = m.get('Key')
        if m.get('Value') is not None:
            self.value = m.get('Value')
        return self


class GetBucketLifecycleResponseLifecycleConfigurationRule(TeaModel):
    def __init__(
        self,
        i_d: str = None,
        prefix: str = None,
        status: str = None,
        expiration: GetBucketLifecycleResponseLifecycleConfigurationRuleExpiration = None,
        transition: GetBucketLifecycleResponseLifecycleConfigurationRuleTransition = None,
        abort_multipart_upload: GetBucketLifecycleResponseLifecycleConfigurationRuleAbortMultipartUpload = None,
        tag: GetBucketLifecycleResponseLifecycleConfigurationRuleTag = None,
    ):
        # ID
        self.i_d = i_d
        # Prefix
        self.prefix = prefix
        # Status
        self.status = status
        # Expiration
        self.expiration = expiration
        # Transition
        self.transition = transition
        # AbortMultipartUpload
        self.abort_multipart_upload = abort_multipart_upload
        # Tag
        self.tag = tag

    def validate(self):
        self.validate_required(self.expiration, 'expiration')
        if self.expiration:
            self.expiration.validate()
        self.validate_required(self.transition, 'transition')
        if self.transition:
            self.transition.validate()
        self.validate_required(self.abort_multipart_upload, 'abort_multipart_upload')
        if self.abort_multipart_upload:
            self.abort_multipart_upload.validate()
        self.validate_required(self.tag, 'tag')
        if self.tag:
            self.tag.validate()

    def to_map(self):
        result = dict()
        if self.i_d is not None:
            result['ID'] = self.i_d
        if self.prefix is not None:
            result['Prefix'] = self.prefix
        if self.status is not None:
            result['Status'] = self.status
        if self.expiration is not None:
            result['Expiration'] = self.expiration.to_map()
        if self.transition is not None:
            result['Transition'] = self.transition.to_map()
        if self.abort_multipart_upload is not None:
            result['AbortMultipartUpload'] = self.abort_multipart_upload.to_map()
        if self.tag is not None:
            result['Tag'] = self.tag.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('ID') is not None:
            self.i_d = m.get('ID')
        if m.get('Prefix') is not None:
            self.prefix = m.get('Prefix')
        if m.get('Status') is not None:
            self.status = m.get('Status')
        if m.get('Expiration') is not None:
            temp_model = GetBucketLifecycleResponseLifecycleConfigurationRuleExpiration()
            self.expiration = temp_model.from_map(m['Expiration'])
        if m.get('Transition') is not None:
            temp_model = GetBucketLifecycleResponseLifecycleConfigurationRuleTransition()
            self.transition = temp_model.from_map(m['Transition'])
        if m.get('AbortMultipartUpload') is not None:
            temp_model = GetBucketLifecycleResponseLifecycleConfigurationRuleAbortMultipartUpload()
            self.abort_multipart_upload = temp_model.from_map(m['AbortMultipartUpload'])
        if m.get('Tag') is not None:
            temp_model = GetBucketLifecycleResponseLifecycleConfigurationRuleTag()
            self.tag = temp_model.from_map(m['Tag'])
        return self


class GetBucketLifecycleResponseLifecycleConfiguration(TeaModel):
    def __init__(
        self,
        rule: List[GetBucketLifecycleResponseLifecycleConfigurationRule] = None,
    ):
        # Rule
        self.rule = rule

    def validate(self):
        if self.rule:
            for k in self.rule:
                if k:
                    k.validate()

    def to_map(self):
        result = dict()
        result['Rule'] = []
        if self.rule is not None:
            for k in self.rule:
                result['Rule'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.rule = []
        if m.get('Rule') is not None:
            for k in m.get('Rule'):
                temp_model = GetBucketLifecycleResponseLifecycleConfigurationRule()
                self.rule.append(temp_model.from_map(k))
        return self


class GetBucketLifecycleResponse(TeaModel):
    def __init__(
        self,
        request_id: str = None,
        lifecycle_configuration: GetBucketLifecycleResponseLifecycleConfiguration = None,
    ):
        # x-oss-request-id
        self.request_id = request_id
        # LifecycleConfiguration
        self.lifecycle_configuration = lifecycle_configuration

    def validate(self):
        self.validate_required(self.request_id, 'request_id')
        self.validate_required(self.lifecycle_configuration, 'lifecycle_configuration')
        if self.lifecycle_configuration:
            self.lifecycle_configuration.validate()

    def to_map(self):
        result = dict()
        if self.request_id is not None:
            result['x-oss-request-id'] = self.request_id
        if self.lifecycle_configuration is not None:
            result['LifecycleConfiguration'] = self.lifecycle_configuration.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('x-oss-request-id') is not None:
            self.request_id = m.get('x-oss-request-id')
        if m.get('LifecycleConfiguration') is not None:
            temp_model = GetBucketLifecycleResponseLifecycleConfiguration()
            self.lifecycle_configuration = temp_model.from_map(m['LifecycleConfiguration'])
        return self


class PutSymlinkRequestHeader(TeaModel):
    def __init__(
        self,
        symlink_target: str = None,
        storage_class: str = None,
    ):
        # x-oss-symlink-target
        self.symlink_target = symlink_target
        # x-oss-storage-class
        self.storage_class = storage_class

    def validate(self):
        self.validate_required(self.symlink_target, 'symlink_target')

    def to_map(self):
        result = dict()
        if self.symlink_target is not None:
            result['x-oss-symlink-target'] = self.symlink_target
        if self.storage_class is not None:
            result['x-oss-storage-class'] = self.storage_class
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('x-oss-symlink-target') is not None:
            self.symlink_target = m.get('x-oss-symlink-target')
        if m.get('x-oss-storage-class') is not None:
            self.storage_class = m.get('x-oss-storage-class')
        return self


class PutSymlinkRequest(TeaModel):
    def __init__(
        self,
        bucket_name: str = None,
        object_name: str = None,
        header: PutSymlinkRequestHeader = None,
    ):
        # BucketName
        self.bucket_name = bucket_name
        # ObjectName
        self.object_name = object_name
        # Header
        self.header = header

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')
        if self.bucket_name is not None:
            self.validate_pattern(self.bucket_name, 'bucket_name', '[a-zA-Z0-9-_]+')
        self.validate_required(self.object_name, 'object_name')
        self.validate_required(self.header, 'header')
        if self.header:
            self.header.validate()

    def to_map(self):
        result = dict()
        if self.bucket_name is not None:
            result['BucketName'] = self.bucket_name
        if self.object_name is not None:
            result['ObjectName'] = self.object_name
        if self.header is not None:
            result['Header'] = self.header.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('BucketName') is not None:
            self.bucket_name = m.get('BucketName')
        if m.get('ObjectName') is not None:
            self.object_name = m.get('ObjectName')
        if m.get('Header') is not None:
            temp_model = PutSymlinkRequestHeader()
            self.header = temp_model.from_map(m['Header'])
        return self


class PutSymlinkResponse(TeaModel):
    def __init__(
        self,
        request_id: str = None,
    ):
        # x-oss-request-id
        self.request_id = request_id

    def validate(self):
        self.validate_required(self.request_id, 'request_id')

    def to_map(self):
        result = dict()
        if self.request_id is not None:
            result['x-oss-request-id'] = self.request_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('x-oss-request-id') is not None:
            self.request_id = m.get('x-oss-request-id')
        return self


class GetBucketRefererRequest(TeaModel):
    def __init__(
        self,
        bucket_name: str = None,
    ):
        # BucketName
        self.bucket_name = bucket_name

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')
        if self.bucket_name is not None:
            self.validate_pattern(self.bucket_name, 'bucket_name', '[a-zA-Z0-9-_]+')

    def to_map(self):
        result = dict()
        if self.bucket_name is not None:
            result['BucketName'] = self.bucket_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('BucketName') is not None:
            self.bucket_name = m.get('BucketName')
        return self


class GetBucketRefererResponseRefererConfigurationRefererList(TeaModel):
    def __init__(
        self,
        referer: List[str] = None,
    ):
        # Referer
        self.referer = referer

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.referer is not None:
            result['Referer'] = self.referer
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('Referer') is not None:
            self.referer = m.get('Referer')
        return self


class GetBucketRefererResponseRefererConfiguration(TeaModel):
    def __init__(
        self,
        allow_empty_referer: bool = None,
        referer_list: GetBucketRefererResponseRefererConfigurationRefererList = None,
    ):
        # AllowEmptyReferer
        self.allow_empty_referer = allow_empty_referer
        # RefererList
        self.referer_list = referer_list

    def validate(self):
        self.validate_required(self.referer_list, 'referer_list')
        if self.referer_list:
            self.referer_list.validate()

    def to_map(self):
        result = dict()
        if self.allow_empty_referer is not None:
            result['AllowEmptyReferer'] = self.allow_empty_referer
        if self.referer_list is not None:
            result['RefererList'] = self.referer_list.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('AllowEmptyReferer') is not None:
            self.allow_empty_referer = m.get('AllowEmptyReferer')
        if m.get('RefererList') is not None:
            temp_model = GetBucketRefererResponseRefererConfigurationRefererList()
            self.referer_list = temp_model.from_map(m['RefererList'])
        return self


class GetBucketRefererResponse(TeaModel):
    def __init__(
        self,
        request_id: str = None,
        referer_configuration: GetBucketRefererResponseRefererConfiguration = None,
    ):
        # x-oss-request-id
        self.request_id = request_id
        # RefererConfiguration
        self.referer_configuration = referer_configuration

    def validate(self):
        self.validate_required(self.request_id, 'request_id')
        self.validate_required(self.referer_configuration, 'referer_configuration')
        if self.referer_configuration:
            self.referer_configuration.validate()

    def to_map(self):
        result = dict()
        if self.request_id is not None:
            result['x-oss-request-id'] = self.request_id
        if self.referer_configuration is not None:
            result['RefererConfiguration'] = self.referer_configuration.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('x-oss-request-id') is not None:
            self.request_id = m.get('x-oss-request-id')
        if m.get('RefererConfiguration') is not None:
            temp_model = GetBucketRefererResponseRefererConfiguration()
            self.referer_configuration = temp_model.from_map(m['RefererConfiguration'])
        return self


class CallbackRequest(TeaModel):
    def __init__(
        self,
        bucket_name: str = None,
    ):
        # BucketName
        self.bucket_name = bucket_name

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')
        if self.bucket_name is not None:
            self.validate_pattern(self.bucket_name, 'bucket_name', '[a-zA-Z0-9-_]+')

    def to_map(self):
        result = dict()
        if self.bucket_name is not None:
            result['BucketName'] = self.bucket_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('BucketName') is not None:
            self.bucket_name = m.get('BucketName')
        return self


class CallbackResponse(TeaModel):
    def __init__(
        self,
        request_id: str = None,
    ):
        # x-oss-request-id
        self.request_id = request_id

    def validate(self):
        self.validate_required(self.request_id, 'request_id')

    def to_map(self):
        result = dict()
        if self.request_id is not None:
            result['x-oss-request-id'] = self.request_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('x-oss-request-id') is not None:
            self.request_id = m.get('x-oss-request-id')
        return self


class GetBucketLoggingRequest(TeaModel):
    def __init__(
        self,
        bucket_name: str = None,
    ):
        # BucketName
        self.bucket_name = bucket_name

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')
        if self.bucket_name is not None:
            self.validate_pattern(self.bucket_name, 'bucket_name', '[a-zA-Z0-9-_]+')

    def to_map(self):
        result = dict()
        if self.bucket_name is not None:
            result['BucketName'] = self.bucket_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('BucketName') is not None:
            self.bucket_name = m.get('BucketName')
        return self


class GetBucketLoggingResponseBucketLoggingStatusLoggingEnabled(TeaModel):
    def __init__(
        self,
        target_bucket: str = None,
        target_prefix: str = None,
    ):
        # TargetBucket
        self.target_bucket = target_bucket
        # TargetPrefix
        self.target_prefix = target_prefix

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.target_bucket is not None:
            result['TargetBucket'] = self.target_bucket
        if self.target_prefix is not None:
            result['TargetPrefix'] = self.target_prefix
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('TargetBucket') is not None:
            self.target_bucket = m.get('TargetBucket')
        if m.get('TargetPrefix') is not None:
            self.target_prefix = m.get('TargetPrefix')
        return self


class GetBucketLoggingResponseBucketLoggingStatus(TeaModel):
    def __init__(
        self,
        logging_enabled: GetBucketLoggingResponseBucketLoggingStatusLoggingEnabled = None,
    ):
        # LoggingEnabled
        self.logging_enabled = logging_enabled

    def validate(self):
        self.validate_required(self.logging_enabled, 'logging_enabled')
        if self.logging_enabled:
            self.logging_enabled.validate()

    def to_map(self):
        result = dict()
        if self.logging_enabled is not None:
            result['LoggingEnabled'] = self.logging_enabled.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('LoggingEnabled') is not None:
            temp_model = GetBucketLoggingResponseBucketLoggingStatusLoggingEnabled()
            self.logging_enabled = temp_model.from_map(m['LoggingEnabled'])
        return self


class GetBucketLoggingResponse(TeaModel):
    def __init__(
        self,
        request_id: str = None,
        bucket_logging_status: GetBucketLoggingResponseBucketLoggingStatus = None,
    ):
        # x-oss-request-id
        self.request_id = request_id
        # BucketLoggingStatus
        self.bucket_logging_status = bucket_logging_status

    def validate(self):
        self.validate_required(self.request_id, 'request_id')
        self.validate_required(self.bucket_logging_status, 'bucket_logging_status')
        if self.bucket_logging_status:
            self.bucket_logging_status.validate()

    def to_map(self):
        result = dict()
        if self.request_id is not None:
            result['x-oss-request-id'] = self.request_id
        if self.bucket_logging_status is not None:
            result['BucketLoggingStatus'] = self.bucket_logging_status.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('x-oss-request-id') is not None:
            self.request_id = m.get('x-oss-request-id')
        if m.get('BucketLoggingStatus') is not None:
            temp_model = GetBucketLoggingResponseBucketLoggingStatus()
            self.bucket_logging_status = temp_model.from_map(m['BucketLoggingStatus'])
        return self


class PutObjectAclRequestHeader(TeaModel):
    def __init__(
        self,
        object_acl: str = None,
    ):
        # x-oss-object-acl
        self.object_acl = object_acl

    def validate(self):
        self.validate_required(self.object_acl, 'object_acl')

    def to_map(self):
        result = dict()
        if self.object_acl is not None:
            result['x-oss-object-acl'] = self.object_acl
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('x-oss-object-acl') is not None:
            self.object_acl = m.get('x-oss-object-acl')
        return self


class PutObjectAclRequest(TeaModel):
    def __init__(
        self,
        bucket_name: str = None,
        object_name: str = None,
        header: PutObjectAclRequestHeader = None,
    ):
        # BucketName
        self.bucket_name = bucket_name
        # ObjectName
        self.object_name = object_name
        # Header
        self.header = header

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')
        if self.bucket_name is not None:
            self.validate_pattern(self.bucket_name, 'bucket_name', '[a-zA-Z0-9-_]+')
        self.validate_required(self.object_name, 'object_name')
        self.validate_required(self.header, 'header')
        if self.header:
            self.header.validate()

    def to_map(self):
        result = dict()
        if self.bucket_name is not None:
            result['BucketName'] = self.bucket_name
        if self.object_name is not None:
            result['ObjectName'] = self.object_name
        if self.header is not None:
            result['Header'] = self.header.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('BucketName') is not None:
            self.bucket_name = m.get('BucketName')
        if m.get('ObjectName') is not None:
            self.object_name = m.get('ObjectName')
        if m.get('Header') is not None:
            temp_model = PutObjectAclRequestHeader()
            self.header = temp_model.from_map(m['Header'])
        return self


class PutObjectAclResponse(TeaModel):
    def __init__(
        self,
        request_id: str = None,
    ):
        # x-oss-request-id
        self.request_id = request_id

    def validate(self):
        self.validate_required(self.request_id, 'request_id')

    def to_map(self):
        result = dict()
        if self.request_id is not None:
            result['x-oss-request-id'] = self.request_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('x-oss-request-id') is not None:
            self.request_id = m.get('x-oss-request-id')
        return self


class GetBucketInfoRequest(TeaModel):
    def __init__(
        self,
        bucket_name: str = None,
    ):
        # BucketName
        self.bucket_name = bucket_name

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')
        if self.bucket_name is not None:
            self.validate_pattern(self.bucket_name, 'bucket_name', '[a-zA-Z0-9-_]+')

    def to_map(self):
        result = dict()
        if self.bucket_name is not None:
            result['BucketName'] = self.bucket_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('BucketName') is not None:
            self.bucket_name = m.get('BucketName')
        return self


class GetBucketInfoResponseBucketInfoBucketOwner(TeaModel):
    def __init__(
        self,
        i_d: str = None,
        display_name: str = None,
    ):
        # ID
        self.i_d = i_d
        # DisplayName
        self.display_name = display_name

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.i_d is not None:
            result['ID'] = self.i_d
        if self.display_name is not None:
            result['DisplayName'] = self.display_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('ID') is not None:
            self.i_d = m.get('ID')
        if m.get('DisplayName') is not None:
            self.display_name = m.get('DisplayName')
        return self


class GetBucketInfoResponseBucketInfoBucketAccessControlList(TeaModel):
    def __init__(
        self,
        grant: str = None,
    ):
        # Grant
        self.grant = grant

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.grant is not None:
            result['Grant'] = self.grant
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('Grant') is not None:
            self.grant = m.get('Grant')
        return self


class GetBucketInfoResponseBucketInfoBucket(TeaModel):
    def __init__(
        self,
        creation_date: str = None,
        extranet_endpoint: str = None,
        intranet_endpoint: str = None,
        location: str = None,
        name: str = None,
        data_redundancy_type: str = None,
        storage_class: str = None,
        comment: str = None,
        owner: GetBucketInfoResponseBucketInfoBucketOwner = None,
        access_control_list: GetBucketInfoResponseBucketInfoBucketAccessControlList = None,
    ):
        # CreationDate
        self.creation_date = creation_date
        # ExtranetEndpoint
        self.extranet_endpoint = extranet_endpoint
        # IntranetEndpoint
        self.intranet_endpoint = intranet_endpoint
        # Location
        self.location = location
        # Name
        self.name = name
        # DataRedundancyType
        self.data_redundancy_type = data_redundancy_type
        # StorageClass
        self.storage_class = storage_class
        # Comment
        self.comment = comment
        # Owner
        self.owner = owner
        # AccessControlList
        self.access_control_list = access_control_list

    def validate(self):
        self.validate_required(self.owner, 'owner')
        if self.owner:
            self.owner.validate()
        self.validate_required(self.access_control_list, 'access_control_list')
        if self.access_control_list:
            self.access_control_list.validate()

    def to_map(self):
        result = dict()
        if self.creation_date is not None:
            result['CreationDate'] = self.creation_date
        if self.extranet_endpoint is not None:
            result['ExtranetEndpoint'] = self.extranet_endpoint
        if self.intranet_endpoint is not None:
            result['IntranetEndpoint'] = self.intranet_endpoint
        if self.location is not None:
            result['Location'] = self.location
        if self.name is not None:
            result['Name'] = self.name
        if self.data_redundancy_type is not None:
            result['DataRedundancyType'] = self.data_redundancy_type
        if self.storage_class is not None:
            result['StorageClass'] = self.storage_class
        if self.comment is not None:
            result['Comment'] = self.comment
        if self.owner is not None:
            result['Owner'] = self.owner.to_map()
        if self.access_control_list is not None:
            result['AccessControlList'] = self.access_control_list.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('CreationDate') is not None:
            self.creation_date = m.get('CreationDate')
        if m.get('ExtranetEndpoint') is not None:
            self.extranet_endpoint = m.get('ExtranetEndpoint')
        if m.get('IntranetEndpoint') is not None:
            self.intranet_endpoint = m.get('IntranetEndpoint')
        if m.get('Location') is not None:
            self.location = m.get('Location')
        if m.get('Name') is not None:
            self.name = m.get('Name')
        if m.get('DataRedundancyType') is not None:
            self.data_redundancy_type = m.get('DataRedundancyType')
        if m.get('StorageClass') is not None:
            self.storage_class = m.get('StorageClass')
        if m.get('Comment') is not None:
            self.comment = m.get('Comment')
        if m.get('Owner') is not None:
            temp_model = GetBucketInfoResponseBucketInfoBucketOwner()
            self.owner = temp_model.from_map(m['Owner'])
        if m.get('AccessControlList') is not None:
            temp_model = GetBucketInfoResponseBucketInfoBucketAccessControlList()
            self.access_control_list = temp_model.from_map(m['AccessControlList'])
        return self


class GetBucketInfoResponseBucketInfo(TeaModel):
    def __init__(
        self,
        bucket: GetBucketInfoResponseBucketInfoBucket = None,
    ):
        # Bucket
        self.bucket = bucket

    def validate(self):
        self.validate_required(self.bucket, 'bucket')
        if self.bucket:
            self.bucket.validate()

    def to_map(self):
        result = dict()
        if self.bucket is not None:
            result['Bucket'] = self.bucket.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('Bucket') is not None:
            temp_model = GetBucketInfoResponseBucketInfoBucket()
            self.bucket = temp_model.from_map(m['Bucket'])
        return self


class GetBucketInfoResponse(TeaModel):
    def __init__(
        self,
        request_id: str = None,
        bucket_info: GetBucketInfoResponseBucketInfo = None,
    ):
        # x-oss-request-id
        self.request_id = request_id
        # BucketInfo
        self.bucket_info = bucket_info

    def validate(self):
        self.validate_required(self.request_id, 'request_id')
        self.validate_required(self.bucket_info, 'bucket_info')
        if self.bucket_info:
            self.bucket_info.validate()

    def to_map(self):
        result = dict()
        if self.request_id is not None:
            result['x-oss-request-id'] = self.request_id
        if self.bucket_info is not None:
            result['BucketInfo'] = self.bucket_info.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('x-oss-request-id') is not None:
            self.request_id = m.get('x-oss-request-id')
        if m.get('BucketInfo') is not None:
            temp_model = GetBucketInfoResponseBucketInfo()
            self.bucket_info = temp_model.from_map(m['BucketInfo'])
        return self


class PutLiveChannelStatusRequestFilter(TeaModel):
    def __init__(
        self,
        status: str = None,
    ):
        # status
        self.status = status

    def validate(self):
        self.validate_required(self.status, 'status')

    def to_map(self):
        result = dict()
        if self.status is not None:
            result['status'] = self.status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('status') is not None:
            self.status = m.get('status')
        return self


class PutLiveChannelStatusRequest(TeaModel):
    def __init__(
        self,
        bucket_name: str = None,
        channel_name: str = None,
        filter: PutLiveChannelStatusRequestFilter = None,
    ):
        # BucketName
        self.bucket_name = bucket_name
        # ChannelName
        self.channel_name = channel_name
        # Filter
        self.filter = filter

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')
        if self.bucket_name is not None:
            self.validate_pattern(self.bucket_name, 'bucket_name', '[a-zA-Z0-9-_]+')
        self.validate_required(self.channel_name, 'channel_name')
        self.validate_required(self.filter, 'filter')
        if self.filter:
            self.filter.validate()

    def to_map(self):
        result = dict()
        if self.bucket_name is not None:
            result['BucketName'] = self.bucket_name
        if self.channel_name is not None:
            result['ChannelName'] = self.channel_name
        if self.filter is not None:
            result['Filter'] = self.filter.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('BucketName') is not None:
            self.bucket_name = m.get('BucketName')
        if m.get('ChannelName') is not None:
            self.channel_name = m.get('ChannelName')
        if m.get('Filter') is not None:
            temp_model = PutLiveChannelStatusRequestFilter()
            self.filter = temp_model.from_map(m['Filter'])
        return self


class PutLiveChannelStatusResponse(TeaModel):
    def __init__(
        self,
        request_id: str = None,
    ):
        # x-oss-request-id
        self.request_id = request_id

    def validate(self):
        self.validate_required(self.request_id, 'request_id')

    def to_map(self):
        result = dict()
        if self.request_id is not None:
            result['x-oss-request-id'] = self.request_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('x-oss-request-id') is not None:
            self.request_id = m.get('x-oss-request-id')
        return self


class InitiateMultipartUploadRequestFilter(TeaModel):
    def __init__(
        self,
        encoding_type: str = None,
    ):
        # encoding-type
        self.encoding_type = encoding_type

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.encoding_type is not None:
            result['encoding-type'] = self.encoding_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('encoding-type') is not None:
            self.encoding_type = m.get('encoding-type')
        return self


class InitiateMultipartUploadRequestHeader(TeaModel):
    def __init__(
        self,
        cache_control: str = None,
        content_disposition: str = None,
        content_encoding: str = None,
        expires: str = None,
        server_side_encryption: str = None,
        server_side_encryption_key_id: str = None,
        storage_class: str = None,
        tagging: str = None,
        content_type: str = None,
    ):
        # Cache-Control
        self.cache_control = cache_control
        # Content-Disposition
        self.content_disposition = content_disposition
        # Content-Encoding
        self.content_encoding = content_encoding
        # Expires
        self.expires = expires
        # x-oss-server-side-encryption
        self.server_side_encryption = server_side_encryption
        # x-oss-server-side-encryption-key-id
        self.server_side_encryption_key_id = server_side_encryption_key_id
        # x-oss-storage-class
        self.storage_class = storage_class
        # x-oss-tagging
        self.tagging = tagging
        # content-type
        self.content_type = content_type

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.cache_control is not None:
            result['Cache-Control'] = self.cache_control
        if self.content_disposition is not None:
            result['Content-Disposition'] = self.content_disposition
        if self.content_encoding is not None:
            result['Content-Encoding'] = self.content_encoding
        if self.expires is not None:
            result['Expires'] = self.expires
        if self.server_side_encryption is not None:
            result['x-oss-server-side-encryption'] = self.server_side_encryption
        if self.server_side_encryption_key_id is not None:
            result['x-oss-server-side-encryption-key-id'] = self.server_side_encryption_key_id
        if self.storage_class is not None:
            result['x-oss-storage-class'] = self.storage_class
        if self.tagging is not None:
            result['x-oss-tagging'] = self.tagging
        if self.content_type is not None:
            result['content-type'] = self.content_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('Cache-Control') is not None:
            self.cache_control = m.get('Cache-Control')
        if m.get('Content-Disposition') is not None:
            self.content_disposition = m.get('Content-Disposition')
        if m.get('Content-Encoding') is not None:
            self.content_encoding = m.get('Content-Encoding')
        if m.get('Expires') is not None:
            self.expires = m.get('Expires')
        if m.get('x-oss-server-side-encryption') is not None:
            self.server_side_encryption = m.get('x-oss-server-side-encryption')
        if m.get('x-oss-server-side-encryption-key-id') is not None:
            self.server_side_encryption_key_id = m.get('x-oss-server-side-encryption-key-id')
        if m.get('x-oss-storage-class') is not None:
            self.storage_class = m.get('x-oss-storage-class')
        if m.get('x-oss-tagging') is not None:
            self.tagging = m.get('x-oss-tagging')
        if m.get('content-type') is not None:
            self.content_type = m.get('content-type')
        return self


class InitiateMultipartUploadRequest(TeaModel):
    def __init__(
        self,
        bucket_name: str = None,
        object_name: str = None,
        filter: InitiateMultipartUploadRequestFilter = None,
        header: InitiateMultipartUploadRequestHeader = None,
    ):
        # BucketName
        self.bucket_name = bucket_name
        # ObjectName
        self.object_name = object_name
        # Filter
        self.filter = filter
        # Header
        self.header = header

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')
        if self.bucket_name is not None:
            self.validate_pattern(self.bucket_name, 'bucket_name', '[a-zA-Z0-9-_]+')
        self.validate_required(self.object_name, 'object_name')
        if self.filter:
            self.filter.validate()
        if self.header:
            self.header.validate()

    def to_map(self):
        result = dict()
        if self.bucket_name is not None:
            result['BucketName'] = self.bucket_name
        if self.object_name is not None:
            result['ObjectName'] = self.object_name
        if self.filter is not None:
            result['Filter'] = self.filter.to_map()
        if self.header is not None:
            result['Header'] = self.header.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('BucketName') is not None:
            self.bucket_name = m.get('BucketName')
        if m.get('ObjectName') is not None:
            self.object_name = m.get('ObjectName')
        if m.get('Filter') is not None:
            temp_model = InitiateMultipartUploadRequestFilter()
            self.filter = temp_model.from_map(m['Filter'])
        if m.get('Header') is not None:
            temp_model = InitiateMultipartUploadRequestHeader()
            self.header = temp_model.from_map(m['Header'])
        return self


class InitiateMultipartUploadResponseInitiateMultipartUploadResult(TeaModel):
    def __init__(
        self,
        bucket: str = None,
        key: str = None,
        upload_id: str = None,
    ):
        # Bucket
        self.bucket = bucket
        # Key
        self.key = key
        # UploadId
        self.upload_id = upload_id

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.bucket is not None:
            result['Bucket'] = self.bucket
        if self.key is not None:
            result['Key'] = self.key
        if self.upload_id is not None:
            result['UploadId'] = self.upload_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('Bucket') is not None:
            self.bucket = m.get('Bucket')
        if m.get('Key') is not None:
            self.key = m.get('Key')
        if m.get('UploadId') is not None:
            self.upload_id = m.get('UploadId')
        return self


class InitiateMultipartUploadResponse(TeaModel):
    def __init__(
        self,
        request_id: str = None,
        initiate_multipart_upload_result: InitiateMultipartUploadResponseInitiateMultipartUploadResult = None,
    ):
        # x-oss-request-id
        self.request_id = request_id
        # InitiateMultipartUploadResult
        self.initiate_multipart_upload_result = initiate_multipart_upload_result

    def validate(self):
        self.validate_required(self.request_id, 'request_id')
        self.validate_required(self.initiate_multipart_upload_result, 'initiate_multipart_upload_result')
        if self.initiate_multipart_upload_result:
            self.initiate_multipart_upload_result.validate()

    def to_map(self):
        result = dict()
        if self.request_id is not None:
            result['x-oss-request-id'] = self.request_id
        if self.initiate_multipart_upload_result is not None:
            result['InitiateMultipartUploadResult'] = self.initiate_multipart_upload_result.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('x-oss-request-id') is not None:
            self.request_id = m.get('x-oss-request-id')
        if m.get('InitiateMultipartUploadResult') is not None:
            temp_model = InitiateMultipartUploadResponseInitiateMultipartUploadResult()
            self.initiate_multipart_upload_result = temp_model.from_map(m['InitiateMultipartUploadResult'])
        return self


class OptionObjectRequestHeader(TeaModel):
    def __init__(
        self,
        origin: str = None,
        access_control_request_method: str = None,
        access_control_request_headers: str = None,
    ):
        # Origin
        self.origin = origin
        # Access-Control-Request-Method
        self.access_control_request_method = access_control_request_method
        # Access-Control-Request-Headers
        self.access_control_request_headers = access_control_request_headers

    def validate(self):
        self.validate_required(self.origin, 'origin')
        self.validate_required(self.access_control_request_method, 'access_control_request_method')
        self.validate_required(self.access_control_request_headers, 'access_control_request_headers')

    def to_map(self):
        result = dict()
        if self.origin is not None:
            result['Origin'] = self.origin
        if self.access_control_request_method is not None:
            result['Access-Control-Request-Method'] = self.access_control_request_method
        if self.access_control_request_headers is not None:
            result['Access-Control-Request-Headers'] = self.access_control_request_headers
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('Origin') is not None:
            self.origin = m.get('Origin')
        if m.get('Access-Control-Request-Method') is not None:
            self.access_control_request_method = m.get('Access-Control-Request-Method')
        if m.get('Access-Control-Request-Headers') is not None:
            self.access_control_request_headers = m.get('Access-Control-Request-Headers')
        return self


class OptionObjectRequest(TeaModel):
    def __init__(
        self,
        bucket_name: str = None,
        object_name: str = None,
        header: OptionObjectRequestHeader = None,
    ):
        # BucketName
        self.bucket_name = bucket_name
        # ObjectName
        self.object_name = object_name
        # Header
        self.header = header

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')
        if self.bucket_name is not None:
            self.validate_pattern(self.bucket_name, 'bucket_name', '[a-zA-Z0-9-_]+')
        self.validate_required(self.object_name, 'object_name')
        self.validate_required(self.header, 'header')
        if self.header:
            self.header.validate()

    def to_map(self):
        result = dict()
        if self.bucket_name is not None:
            result['BucketName'] = self.bucket_name
        if self.object_name is not None:
            result['ObjectName'] = self.object_name
        if self.header is not None:
            result['Header'] = self.header.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('BucketName') is not None:
            self.bucket_name = m.get('BucketName')
        if m.get('ObjectName') is not None:
            self.object_name = m.get('ObjectName')
        if m.get('Header') is not None:
            temp_model = OptionObjectRequestHeader()
            self.header = temp_model.from_map(m['Header'])
        return self


class OptionObjectResponse(TeaModel):
    def __init__(
        self,
        request_id: str = None,
        access_control_allow_origin: str = None,
        access_control_allow_methods: str = None,
        access_control_allow_headers: str = None,
        access_control_expose_headers: str = None,
        access_control_max_age: str = None,
    ):
        # x-oss-request-id
        self.request_id = request_id
        # Access-Control-Allow-Origin
        self.access_control_allow_origin = access_control_allow_origin
        # Access-Control-Allow-Methods
        self.access_control_allow_methods = access_control_allow_methods
        # Access-Control-Allow-Headers
        self.access_control_allow_headers = access_control_allow_headers
        # Access-Control-Expose-Headers
        self.access_control_expose_headers = access_control_expose_headers
        # Access-Control-Max-Age
        self.access_control_max_age = access_control_max_age

    def validate(self):
        self.validate_required(self.request_id, 'request_id')
        self.validate_required(self.access_control_allow_origin, 'access_control_allow_origin')
        self.validate_required(self.access_control_allow_methods, 'access_control_allow_methods')
        self.validate_required(self.access_control_allow_headers, 'access_control_allow_headers')
        self.validate_required(self.access_control_expose_headers, 'access_control_expose_headers')
        self.validate_required(self.access_control_max_age, 'access_control_max_age')

    def to_map(self):
        result = dict()
        if self.request_id is not None:
            result['x-oss-request-id'] = self.request_id
        if self.access_control_allow_origin is not None:
            result['access-control-allow-origin'] = self.access_control_allow_origin
        if self.access_control_allow_methods is not None:
            result['access-control-allow-methods'] = self.access_control_allow_methods
        if self.access_control_allow_headers is not None:
            result['access-control-allow-headers'] = self.access_control_allow_headers
        if self.access_control_expose_headers is not None:
            result['access-control-expose-headers'] = self.access_control_expose_headers
        if self.access_control_max_age is not None:
            result['access-control-max-age'] = self.access_control_max_age
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('x-oss-request-id') is not None:
            self.request_id = m.get('x-oss-request-id')
        if m.get('access-control-allow-origin') is not None:
            self.access_control_allow_origin = m.get('access-control-allow-origin')
        if m.get('access-control-allow-methods') is not None:
            self.access_control_allow_methods = m.get('access-control-allow-methods')
        if m.get('access-control-allow-headers') is not None:
            self.access_control_allow_headers = m.get('access-control-allow-headers')
        if m.get('access-control-expose-headers') is not None:
            self.access_control_expose_headers = m.get('access-control-expose-headers')
        if m.get('access-control-max-age') is not None:
            self.access_control_max_age = m.get('access-control-max-age')
        return self


class PostVodPlaylistRequestFilter(TeaModel):
    def __init__(
        self,
        end_time: str = None,
        start_time: str = None,
    ):
        # endTime
        self.end_time = end_time
        # startTime
        self.start_time = start_time

    def validate(self):
        self.validate_required(self.end_time, 'end_time')
        self.validate_required(self.start_time, 'start_time')

    def to_map(self):
        result = dict()
        if self.end_time is not None:
            result['endTime'] = self.end_time
        if self.start_time is not None:
            result['startTime'] = self.start_time
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        return self


class PostVodPlaylistRequest(TeaModel):
    def __init__(
        self,
        bucket_name: str = None,
        channel_name: str = None,
        playlist_name: str = None,
        filter: PostVodPlaylistRequestFilter = None,
    ):
        # BucketName
        self.bucket_name = bucket_name
        # ChannelName
        self.channel_name = channel_name
        # PlaylistName
        self.playlist_name = playlist_name
        # Filter
        self.filter = filter

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')
        if self.bucket_name is not None:
            self.validate_pattern(self.bucket_name, 'bucket_name', '[a-zA-Z0-9-_]+')
        self.validate_required(self.channel_name, 'channel_name')
        self.validate_required(self.playlist_name, 'playlist_name')
        self.validate_required(self.filter, 'filter')
        if self.filter:
            self.filter.validate()

    def to_map(self):
        result = dict()
        if self.bucket_name is not None:
            result['BucketName'] = self.bucket_name
        if self.channel_name is not None:
            result['ChannelName'] = self.channel_name
        if self.playlist_name is not None:
            result['PlaylistName'] = self.playlist_name
        if self.filter is not None:
            result['Filter'] = self.filter.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('BucketName') is not None:
            self.bucket_name = m.get('BucketName')
        if m.get('ChannelName') is not None:
            self.channel_name = m.get('ChannelName')
        if m.get('PlaylistName') is not None:
            self.playlist_name = m.get('PlaylistName')
        if m.get('Filter') is not None:
            temp_model = PostVodPlaylistRequestFilter()
            self.filter = temp_model.from_map(m['Filter'])
        return self


class PostVodPlaylistResponse(TeaModel):
    def __init__(
        self,
        request_id: str = None,
    ):
        # x-oss-request-id
        self.request_id = request_id

    def validate(self):
        self.validate_required(self.request_id, 'request_id')

    def to_map(self):
        result = dict()
        if self.request_id is not None:
            result['x-oss-request-id'] = self.request_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('x-oss-request-id') is not None:
            self.request_id = m.get('x-oss-request-id')
        return self


class PostObjectRequestHeader(TeaModel):
    def __init__(
        self,
        access_key_id: str = None,
        policy: str = None,
        signature: str = None,
        success_action_status: str = None,
        file: file_form_models.FileField = None,
        key: str = None,
        user_meta: Dict[str, str] = None,
    ):
        # OSSAccessKeyId
        self.access_key_id = access_key_id
        # policy
        self.policy = policy
        # Signature
        self.signature = signature
        # success_action_status
        self.success_action_status = success_action_status
        self.file = file
        # key
        self.key = key
        # UserMeta
        self.user_meta = user_meta

    def validate(self):
        self.validate_required(self.access_key_id, 'access_key_id')
        self.validate_required(self.policy, 'policy')
        self.validate_required(self.signature, 'signature')
        self.validate_required(self.file, 'file')
        if self.file:
            self.file.validate()
        self.validate_required(self.key, 'key')

    def to_map(self):
        result = dict()
        if self.access_key_id is not None:
            result['OSSAccessKeyId'] = self.access_key_id
        if self.policy is not None:
            result['policy'] = self.policy
        if self.signature is not None:
            result['Signature'] = self.signature
        if self.success_action_status is not None:
            result['success_action_status'] = self.success_action_status
        if self.file is not None:
            result['file'] = self.file.to_map()
        if self.key is not None:
            result['key'] = self.key
        if self.user_meta is not None:
            result['UserMeta'] = self.user_meta
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('OSSAccessKeyId') is not None:
            self.access_key_id = m.get('OSSAccessKeyId')
        if m.get('policy') is not None:
            self.policy = m.get('policy')
        if m.get('Signature') is not None:
            self.signature = m.get('Signature')
        if m.get('success_action_status') is not None:
            self.success_action_status = m.get('success_action_status')
        if m.get('file') is not None:
            temp_model = file_form_models.FileField()
            self.file = temp_model.from_map(m['file'])
        if m.get('key') is not None:
            self.key = m.get('key')
        if m.get('UserMeta') is not None:
            self.user_meta = m.get('UserMeta')
        return self


class PostObjectRequest(TeaModel):
    def __init__(
        self,
        bucket_name: str = None,
        header: PostObjectRequestHeader = None,
    ):
        # BucketName
        self.bucket_name = bucket_name
        # header
        self.header = header

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')
        if self.bucket_name is not None:
            self.validate_pattern(self.bucket_name, 'bucket_name', '[a-zA-Z0-9-_]+')
        self.validate_required(self.header, 'header')
        if self.header:
            self.header.validate()

    def to_map(self):
        result = dict()
        if self.bucket_name is not None:
            result['BucketName'] = self.bucket_name
        if self.header is not None:
            result['header'] = self.header.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('BucketName') is not None:
            self.bucket_name = m.get('BucketName')
        if m.get('header') is not None:
            temp_model = PostObjectRequestHeader()
            self.header = temp_model.from_map(m['header'])
        return self


class PostObjectResponsePostResponse(TeaModel):
    def __init__(
        self,
        bucket: str = None,
        e_tag: str = None,
        location: str = None,
    ):
        # Bucket
        self.bucket = bucket
        # ETag
        self.e_tag = e_tag
        # Location
        self.location = location

    def validate(self):
        self.validate_required(self.bucket, 'bucket')
        self.validate_required(self.e_tag, 'e_tag')
        self.validate_required(self.location, 'location')

    def to_map(self):
        result = dict()
        if self.bucket is not None:
            result['Bucket'] = self.bucket
        if self.e_tag is not None:
            result['ETag'] = self.e_tag
        if self.location is not None:
            result['Location'] = self.location
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('Bucket') is not None:
            self.bucket = m.get('Bucket')
        if m.get('ETag') is not None:
            self.e_tag = m.get('ETag')
        if m.get('Location') is not None:
            self.location = m.get('Location')
        return self


class PostObjectResponse(TeaModel):
    def __init__(
        self,
        post_response: PostObjectResponsePostResponse = None,
    ):
        # PostResponse
        self.post_response = post_response

    def validate(self):
        self.validate_required(self.post_response, 'post_response')
        if self.post_response:
            self.post_response.validate()

    def to_map(self):
        result = dict()
        if self.post_response is not None:
            result['PostResponse'] = self.post_response.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('PostResponse') is not None:
            temp_model = PostObjectResponsePostResponse()
            self.post_response = temp_model.from_map(m['PostResponse'])
        return self


class HeadObjectRequestHeader(TeaModel):
    def __init__(
        self,
        if_modified_since: str = None,
        if_unmodified_since: str = None,
        if_match: str = None,
        if_none_match: str = None,
    ):
        # If-Modified-Since
        self.if_modified_since = if_modified_since
        # If-Unmodified-Since
        self.if_unmodified_since = if_unmodified_since
        # If-Match
        self.if_match = if_match
        # If-None-Match
        self.if_none_match = if_none_match

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.if_modified_since is not None:
            result['If-Modified-Since'] = self.if_modified_since
        if self.if_unmodified_since is not None:
            result['If-Unmodified-Since'] = self.if_unmodified_since
        if self.if_match is not None:
            result['If-Match'] = self.if_match
        if self.if_none_match is not None:
            result['If-None-Match'] = self.if_none_match
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('If-Modified-Since') is not None:
            self.if_modified_since = m.get('If-Modified-Since')
        if m.get('If-Unmodified-Since') is not None:
            self.if_unmodified_since = m.get('If-Unmodified-Since')
        if m.get('If-Match') is not None:
            self.if_match = m.get('If-Match')
        if m.get('If-None-Match') is not None:
            self.if_none_match = m.get('If-None-Match')
        return self


class HeadObjectRequest(TeaModel):
    def __init__(
        self,
        bucket_name: str = None,
        object_name: str = None,
        header: HeadObjectRequestHeader = None,
    ):
        # BucketName
        self.bucket_name = bucket_name
        # ObjectName
        self.object_name = object_name
        # Header
        self.header = header

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')
        if self.bucket_name is not None:
            self.validate_pattern(self.bucket_name, 'bucket_name', '[a-zA-Z0-9-_]+')
        self.validate_required(self.object_name, 'object_name')
        if self.header:
            self.header.validate()

    def to_map(self):
        result = dict()
        if self.bucket_name is not None:
            result['BucketName'] = self.bucket_name
        if self.object_name is not None:
            result['ObjectName'] = self.object_name
        if self.header is not None:
            result['Header'] = self.header.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('BucketName') is not None:
            self.bucket_name = m.get('BucketName')
        if m.get('ObjectName') is not None:
            self.object_name = m.get('ObjectName')
        if m.get('Header') is not None:
            temp_model = HeadObjectRequestHeader()
            self.header = temp_model.from_map(m['Header'])
        return self


class HeadObjectResponse(TeaModel):
    def __init__(
        self,
        request_id: str = None,
        user_meta: Dict[str, str] = None,
        server_side_encryption: str = None,
        server_side_encryption_key_id: str = None,
        storage_class: str = None,
        object_type: str = None,
        next_append_position: str = None,
        hash_crc_64ecma: str = None,
        expiration: str = None,
        restore: str = None,
        process_status: str = None,
        request_charged: str = None,
        content_md_5: str = None,
        last_modified: str = None,
        access_control_allow_origin: str = None,
        access_control_allow_methods: str = None,
        access_control_max_age: str = None,
        access_control_allow_headers: str = None,
        access_control_expose_headers: str = None,
        tagging_count: str = None,
    ):
        # x-oss-request-id
        self.request_id = request_id
        # usermeta
        self.user_meta = user_meta
        # x-oss-server-side-encryption
        self.server_side_encryption = server_side_encryption
        # x-oss-server-side-encryption-key-id
        self.server_side_encryption_key_id = server_side_encryption_key_id
        # x-oss-storage-class
        self.storage_class = storage_class
        # x-oss-object-type
        self.object_type = object_type
        # x-oss-next-append-position
        self.next_append_position = next_append_position
        # x-oss-hash-crc64ecma
        self.hash_crc_64ecma = hash_crc_64ecma
        # x-oss-expiration
        self.expiration = expiration
        # x-oss-restore
        self.restore = restore
        # x-oss-process-status
        self.process_status = process_status
        # x-oss-request-charged
        self.request_charged = request_charged
        # Content-Md5
        self.content_md_5 = content_md_5
        # Last-Modified
        self.last_modified = last_modified
        # Access-Control-Allow-Origin
        self.access_control_allow_origin = access_control_allow_origin
        # Access-Control-Allow-Methods
        self.access_control_allow_methods = access_control_allow_methods
        # Access-Control-Max-Age
        self.access_control_max_age = access_control_max_age
        # Access-Control-Allow-Headers
        self.access_control_allow_headers = access_control_allow_headers
        # Access-Control-Expose-Headers
        self.access_control_expose_headers = access_control_expose_headers
        # x-oss-tagging-count
        self.tagging_count = tagging_count

    def validate(self):
        self.validate_required(self.request_id, 'request_id')
        self.validate_required(self.user_meta, 'user_meta')
        self.validate_required(self.server_side_encryption, 'server_side_encryption')
        self.validate_required(self.server_side_encryption_key_id, 'server_side_encryption_key_id')
        self.validate_required(self.storage_class, 'storage_class')
        self.validate_required(self.object_type, 'object_type')
        self.validate_required(self.next_append_position, 'next_append_position')
        self.validate_required(self.hash_crc_64ecma, 'hash_crc_64ecma')
        self.validate_required(self.expiration, 'expiration')
        self.validate_required(self.restore, 'restore')
        self.validate_required(self.process_status, 'process_status')
        self.validate_required(self.request_charged, 'request_charged')
        self.validate_required(self.content_md_5, 'content_md_5')
        self.validate_required(self.last_modified, 'last_modified')
        self.validate_required(self.access_control_allow_origin, 'access_control_allow_origin')
        self.validate_required(self.access_control_allow_methods, 'access_control_allow_methods')
        self.validate_required(self.access_control_max_age, 'access_control_max_age')
        self.validate_required(self.access_control_allow_headers, 'access_control_allow_headers')
        self.validate_required(self.access_control_expose_headers, 'access_control_expose_headers')
        self.validate_required(self.tagging_count, 'tagging_count')

    def to_map(self):
        result = dict()
        if self.request_id is not None:
            result['x-oss-request-id'] = self.request_id
        if self.user_meta is not None:
            result['usermeta'] = self.user_meta
        if self.server_side_encryption is not None:
            result['x-oss-server-side-encryption'] = self.server_side_encryption
        if self.server_side_encryption_key_id is not None:
            result['x-oss-server-side-encryption-key-id'] = self.server_side_encryption_key_id
        if self.storage_class is not None:
            result['x-oss-storage-class'] = self.storage_class
        if self.object_type is not None:
            result['x-oss-object-type'] = self.object_type
        if self.next_append_position is not None:
            result['x-oss-next-append-position'] = self.next_append_position
        if self.hash_crc_64ecma is not None:
            result['x-oss-hash-crc64ecma'] = self.hash_crc_64ecma
        if self.expiration is not None:
            result['x-oss-expiration'] = self.expiration
        if self.restore is not None:
            result['x-oss-restore'] = self.restore
        if self.process_status is not None:
            result['x-oss-process-status'] = self.process_status
        if self.request_charged is not None:
            result['x-oss-request-charged'] = self.request_charged
        if self.content_md_5 is not None:
            result['content-md5'] = self.content_md_5
        if self.last_modified is not None:
            result['last-modified'] = self.last_modified
        if self.access_control_allow_origin is not None:
            result['access-control-allow-origin'] = self.access_control_allow_origin
        if self.access_control_allow_methods is not None:
            result['access-control-allow-methods'] = self.access_control_allow_methods
        if self.access_control_max_age is not None:
            result['access-control-max-age'] = self.access_control_max_age
        if self.access_control_allow_headers is not None:
            result['access-control-allow-headers'] = self.access_control_allow_headers
        if self.access_control_expose_headers is not None:
            result['access-control-expose-headers'] = self.access_control_expose_headers
        if self.tagging_count is not None:
            result['x-oss-tagging-count'] = self.tagging_count
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('x-oss-request-id') is not None:
            self.request_id = m.get('x-oss-request-id')
        if m.get('usermeta') is not None:
            self.user_meta = m.get('usermeta')
        if m.get('x-oss-server-side-encryption') is not None:
            self.server_side_encryption = m.get('x-oss-server-side-encryption')
        if m.get('x-oss-server-side-encryption-key-id') is not None:
            self.server_side_encryption_key_id = m.get('x-oss-server-side-encryption-key-id')
        if m.get('x-oss-storage-class') is not None:
            self.storage_class = m.get('x-oss-storage-class')
        if m.get('x-oss-object-type') is not None:
            self.object_type = m.get('x-oss-object-type')
        if m.get('x-oss-next-append-position') is not None:
            self.next_append_position = m.get('x-oss-next-append-position')
        if m.get('x-oss-hash-crc64ecma') is not None:
            self.hash_crc_64ecma = m.get('x-oss-hash-crc64ecma')
        if m.get('x-oss-expiration') is not None:
            self.expiration = m.get('x-oss-expiration')
        if m.get('x-oss-restore') is not None:
            self.restore = m.get('x-oss-restore')
        if m.get('x-oss-process-status') is not None:
            self.process_status = m.get('x-oss-process-status')
        if m.get('x-oss-request-charged') is not None:
            self.request_charged = m.get('x-oss-request-charged')
        if m.get('content-md5') is not None:
            self.content_md_5 = m.get('content-md5')
        if m.get('last-modified') is not None:
            self.last_modified = m.get('last-modified')
        if m.get('access-control-allow-origin') is not None:
            self.access_control_allow_origin = m.get('access-control-allow-origin')
        if m.get('access-control-allow-methods') is not None:
            self.access_control_allow_methods = m.get('access-control-allow-methods')
        if m.get('access-control-max-age') is not None:
            self.access_control_max_age = m.get('access-control-max-age')
        if m.get('access-control-allow-headers') is not None:
            self.access_control_allow_headers = m.get('access-control-allow-headers')
        if m.get('access-control-expose-headers') is not None:
            self.access_control_expose_headers = m.get('access-control-expose-headers')
        if m.get('x-oss-tagging-count') is not None:
            self.tagging_count = m.get('x-oss-tagging-count')
        return self


class DeleteObjectTaggingRequest(TeaModel):
    def __init__(
        self,
        bucket_name: str = None,
        object_name: str = None,
    ):
        # BucketName
        self.bucket_name = bucket_name
        # ObjectName
        self.object_name = object_name

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')
        if self.bucket_name is not None:
            self.validate_pattern(self.bucket_name, 'bucket_name', '[a-zA-Z0-9-_]+')
        self.validate_required(self.object_name, 'object_name')

    def to_map(self):
        result = dict()
        if self.bucket_name is not None:
            result['BucketName'] = self.bucket_name
        if self.object_name is not None:
            result['ObjectName'] = self.object_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('BucketName') is not None:
            self.bucket_name = m.get('BucketName')
        if m.get('ObjectName') is not None:
            self.object_name = m.get('ObjectName')
        return self


class DeleteObjectTaggingResponse(TeaModel):
    def __init__(
        self,
        request_id: str = None,
    ):
        # x-oss-request-id
        self.request_id = request_id

    def validate(self):
        self.validate_required(self.request_id, 'request_id')

    def to_map(self):
        result = dict()
        if self.request_id is not None:
            result['x-oss-request-id'] = self.request_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('x-oss-request-id') is not None:
            self.request_id = m.get('x-oss-request-id')
        return self


class RestoreObjectRequest(TeaModel):
    def __init__(
        self,
        bucket_name: str = None,
        object_name: str = None,
    ):
        # BucketName
        self.bucket_name = bucket_name
        # ObjectName
        self.object_name = object_name

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')
        if self.bucket_name is not None:
            self.validate_pattern(self.bucket_name, 'bucket_name', '[a-zA-Z0-9-_]+')
        self.validate_required(self.object_name, 'object_name')

    def to_map(self):
        result = dict()
        if self.bucket_name is not None:
            result['BucketName'] = self.bucket_name
        if self.object_name is not None:
            result['ObjectName'] = self.object_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('BucketName') is not None:
            self.bucket_name = m.get('BucketName')
        if m.get('ObjectName') is not None:
            self.object_name = m.get('ObjectName')
        return self


class RestoreObjectResponse(TeaModel):
    def __init__(
        self,
        request_id: str = None,
    ):
        # x-oss-request-id
        self.request_id = request_id

    def validate(self):
        self.validate_required(self.request_id, 'request_id')

    def to_map(self):
        result = dict()
        if self.request_id is not None:
            result['x-oss-request-id'] = self.request_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('x-oss-request-id') is not None:
            self.request_id = m.get('x-oss-request-id')
        return self


class GetObjectAclRequest(TeaModel):
    def __init__(
        self,
        bucket_name: str = None,
        object_name: str = None,
    ):
        # BucketName
        self.bucket_name = bucket_name
        # ObjectName
        self.object_name = object_name

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')
        if self.bucket_name is not None:
            self.validate_pattern(self.bucket_name, 'bucket_name', '[a-zA-Z0-9-_]+')
        self.validate_required(self.object_name, 'object_name')

    def to_map(self):
        result = dict()
        if self.bucket_name is not None:
            result['BucketName'] = self.bucket_name
        if self.object_name is not None:
            result['ObjectName'] = self.object_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('BucketName') is not None:
            self.bucket_name = m.get('BucketName')
        if m.get('ObjectName') is not None:
            self.object_name = m.get('ObjectName')
        return self


class GetObjectAclResponseAccessControlPolicyOwner(TeaModel):
    def __init__(
        self,
        i_d: str = None,
        display_name: str = None,
    ):
        # ID
        self.i_d = i_d
        # DisplayName
        self.display_name = display_name

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.i_d is not None:
            result['ID'] = self.i_d
        if self.display_name is not None:
            result['DisplayName'] = self.display_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('ID') is not None:
            self.i_d = m.get('ID')
        if m.get('DisplayName') is not None:
            self.display_name = m.get('DisplayName')
        return self


class GetObjectAclResponseAccessControlPolicyAccessControlList(TeaModel):
    def __init__(
        self,
        grant: str = None,
    ):
        # Grant
        self.grant = grant

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.grant is not None:
            result['Grant'] = self.grant
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('Grant') is not None:
            self.grant = m.get('Grant')
        return self


class GetObjectAclResponseAccessControlPolicy(TeaModel):
    def __init__(
        self,
        owner: GetObjectAclResponseAccessControlPolicyOwner = None,
        access_control_list: GetObjectAclResponseAccessControlPolicyAccessControlList = None,
    ):
        # Owner
        self.owner = owner
        # AccessControlList
        self.access_control_list = access_control_list

    def validate(self):
        self.validate_required(self.owner, 'owner')
        if self.owner:
            self.owner.validate()
        self.validate_required(self.access_control_list, 'access_control_list')
        if self.access_control_list:
            self.access_control_list.validate()

    def to_map(self):
        result = dict()
        if self.owner is not None:
            result['Owner'] = self.owner.to_map()
        if self.access_control_list is not None:
            result['AccessControlList'] = self.access_control_list.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('Owner') is not None:
            temp_model = GetObjectAclResponseAccessControlPolicyOwner()
            self.owner = temp_model.from_map(m['Owner'])
        if m.get('AccessControlList') is not None:
            temp_model = GetObjectAclResponseAccessControlPolicyAccessControlList()
            self.access_control_list = temp_model.from_map(m['AccessControlList'])
        return self


class GetObjectAclResponse(TeaModel):
    def __init__(
        self,
        request_id: str = None,
        access_control_policy: GetObjectAclResponseAccessControlPolicy = None,
    ):
        # x-oss-request-id
        self.request_id = request_id
        # AccessControlPolicy
        self.access_control_policy = access_control_policy

    def validate(self):
        self.validate_required(self.request_id, 'request_id')
        self.validate_required(self.access_control_policy, 'access_control_policy')
        if self.access_control_policy:
            self.access_control_policy.validate()

    def to_map(self):
        result = dict()
        if self.request_id is not None:
            result['x-oss-request-id'] = self.request_id
        if self.access_control_policy is not None:
            result['AccessControlPolicy'] = self.access_control_policy.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('x-oss-request-id') is not None:
            self.request_id = m.get('x-oss-request-id')
        if m.get('AccessControlPolicy') is not None:
            temp_model = GetObjectAclResponseAccessControlPolicy()
            self.access_control_policy = temp_model.from_map(m['AccessControlPolicy'])
        return self


class PutBucketAclRequestHeader(TeaModel):
    def __init__(
        self,
        acl: str = None,
    ):
        # x-oss-acl
        self.acl = acl

    def validate(self):
        self.validate_required(self.acl, 'acl')

    def to_map(self):
        result = dict()
        if self.acl is not None:
            result['x-oss-acl'] = self.acl
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('x-oss-acl') is not None:
            self.acl = m.get('x-oss-acl')
        return self


class PutBucketAclRequest(TeaModel):
    def __init__(
        self,
        bucket_name: str = None,
        header: PutBucketAclRequestHeader = None,
    ):
        # BucketName
        self.bucket_name = bucket_name
        # Header
        self.header = header

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')
        if self.bucket_name is not None:
            self.validate_pattern(self.bucket_name, 'bucket_name', '[a-zA-Z0-9-_]+')
        self.validate_required(self.header, 'header')
        if self.header:
            self.header.validate()

    def to_map(self):
        result = dict()
        if self.bucket_name is not None:
            result['BucketName'] = self.bucket_name
        if self.header is not None:
            result['Header'] = self.header.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('BucketName') is not None:
            self.bucket_name = m.get('BucketName')
        if m.get('Header') is not None:
            temp_model = PutBucketAclRequestHeader()
            self.header = temp_model.from_map(m['Header'])
        return self


class PutBucketAclResponse(TeaModel):
    def __init__(
        self,
        request_id: str = None,
    ):
        # x-oss-request-id
        self.request_id = request_id

    def validate(self):
        self.validate_required(self.request_id, 'request_id')

    def to_map(self):
        result = dict()
        if self.request_id is not None:
            result['x-oss-request-id'] = self.request_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('x-oss-request-id') is not None:
            self.request_id = m.get('x-oss-request-id')
        return self


class DeleteBucketRequest(TeaModel):
    def __init__(
        self,
        bucket_name: str = None,
    ):
        # BucketName
        self.bucket_name = bucket_name

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')
        if self.bucket_name is not None:
            self.validate_pattern(self.bucket_name, 'bucket_name', '[a-zA-Z0-9-_]+')

    def to_map(self):
        result = dict()
        if self.bucket_name is not None:
            result['BucketName'] = self.bucket_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('BucketName') is not None:
            self.bucket_name = m.get('BucketName')
        return self


class DeleteBucketResponse(TeaModel):
    def __init__(
        self,
        request_id: str = None,
    ):
        # x-oss-request-id
        self.request_id = request_id

    def validate(self):
        self.validate_required(self.request_id, 'request_id')

    def to_map(self):
        result = dict()
        if self.request_id is not None:
            result['x-oss-request-id'] = self.request_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('x-oss-request-id') is not None:
            self.request_id = m.get('x-oss-request-id')
        return self


class PutObjectRequestHeader(TeaModel):
    def __init__(
        self,
        authorization: str = None,
        cache_control: str = None,
        content_disposition: str = None,
        content_encoding: str = None,
        content_md5: str = None,
        content_length: str = None,
        e_tag: str = None,
        expires: str = None,
        server_side_encryption: str = None,
        server_side_encryption_key_id: str = None,
        object_acl: str = None,
        storage_class: str = None,
        tagging: str = None,
        content_type: str = None,
    ):
        # Authorization
        self.authorization = authorization
        # Cache-Control
        self.cache_control = cache_control
        # Content-Disposition
        self.content_disposition = content_disposition
        # Content-Encoding
        self.content_encoding = content_encoding
        # Content-MD5
        self.content_md5 = content_md5
        # Content-Length
        self.content_length = content_length
        # CETag
        self.e_tag = e_tag
        # Expires
        self.expires = expires
        # x-oss-server-side-encryption
        self.server_side_encryption = server_side_encryption
        # x-oss-server-side-encryption-key-id
        self.server_side_encryption_key_id = server_side_encryption_key_id
        # x-oss-object-acl
        self.object_acl = object_acl
        # x-oss-storage-class
        self.storage_class = storage_class
        # x-oss-tagging
        self.tagging = tagging
        # content-type
        self.content_type = content_type

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.authorization is not None:
            result['Authorization'] = self.authorization
        if self.cache_control is not None:
            result['Cache-Control'] = self.cache_control
        if self.content_disposition is not None:
            result['Content-Disposition'] = self.content_disposition
        if self.content_encoding is not None:
            result['Content-Encoding'] = self.content_encoding
        if self.content_md5 is not None:
            result['Content-MD5'] = self.content_md5
        if self.content_length is not None:
            result['Content-Length'] = self.content_length
        if self.e_tag is not None:
            result['CETag'] = self.e_tag
        if self.expires is not None:
            result['Expires'] = self.expires
        if self.server_side_encryption is not None:
            result['x-oss-server-side-encryption'] = self.server_side_encryption
        if self.server_side_encryption_key_id is not None:
            result['x-oss-server-side-encryption-key-id'] = self.server_side_encryption_key_id
        if self.object_acl is not None:
            result['x-oss-object-acl'] = self.object_acl
        if self.storage_class is not None:
            result['x-oss-storage-class'] = self.storage_class
        if self.tagging is not None:
            result['x-oss-tagging'] = self.tagging
        if self.content_type is not None:
            result['content-type'] = self.content_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('Authorization') is not None:
            self.authorization = m.get('Authorization')
        if m.get('Cache-Control') is not None:
            self.cache_control = m.get('Cache-Control')
        if m.get('Content-Disposition') is not None:
            self.content_disposition = m.get('Content-Disposition')
        if m.get('Content-Encoding') is not None:
            self.content_encoding = m.get('Content-Encoding')
        if m.get('Content-MD5') is not None:
            self.content_md5 = m.get('Content-MD5')
        if m.get('Content-Length') is not None:
            self.content_length = m.get('Content-Length')
        if m.get('CETag') is not None:
            self.e_tag = m.get('CETag')
        if m.get('Expires') is not None:
            self.expires = m.get('Expires')
        if m.get('x-oss-server-side-encryption') is not None:
            self.server_side_encryption = m.get('x-oss-server-side-encryption')
        if m.get('x-oss-server-side-encryption-key-id') is not None:
            self.server_side_encryption_key_id = m.get('x-oss-server-side-encryption-key-id')
        if m.get('x-oss-object-acl') is not None:
            self.object_acl = m.get('x-oss-object-acl')
        if m.get('x-oss-storage-class') is not None:
            self.storage_class = m.get('x-oss-storage-class')
        if m.get('x-oss-tagging') is not None:
            self.tagging = m.get('x-oss-tagging')
        if m.get('content-type') is not None:
            self.content_type = m.get('content-type')
        return self


class PutObjectRequest(TeaModel):
    def __init__(
        self,
        bucket_name: str = None,
        object_name: str = None,
        user_meta: Dict[str, str] = None,
        body: BinaryIO = None,
        header: PutObjectRequestHeader = None,
    ):
        # BucketName
        self.bucket_name = bucket_name
        # ObjectName
        self.object_name = object_name
        # UserMeta
        self.user_meta = user_meta
        # body
        self.body = body
        # Header
        self.header = header

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')
        if self.bucket_name is not None:
            self.validate_pattern(self.bucket_name, 'bucket_name', '[a-zA-Z0-9-_]+')
        self.validate_required(self.object_name, 'object_name')
        if self.header:
            self.header.validate()

    def to_map(self):
        result = dict()
        if self.bucket_name is not None:
            result['BucketName'] = self.bucket_name
        if self.object_name is not None:
            result['ObjectName'] = self.object_name
        if self.user_meta is not None:
            result['UserMeta'] = self.user_meta
        if self.body is not None:
            result['body'] = self.body
        if self.header is not None:
            result['Header'] = self.header.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('BucketName') is not None:
            self.bucket_name = m.get('BucketName')
        if m.get('ObjectName') is not None:
            self.object_name = m.get('ObjectName')
        if m.get('UserMeta') is not None:
            self.user_meta = m.get('UserMeta')
        if m.get('body') is not None:
            self.body = m.get('body')
        if m.get('Header') is not None:
            temp_model = PutObjectRequestHeader()
            self.header = temp_model.from_map(m['Header'])
        return self


class PutObjectResponse(TeaModel):
    def __init__(
        self,
        request_id: str = None,
        hash_crc_64ecma: str = None,
        server_time: str = None,
        bucket_version: str = None,
    ):
        # x-oss-request-id
        self.request_id = request_id
        # x-oss-hash-crc64ecma
        self.hash_crc_64ecma = hash_crc_64ecma
        # x-oss-server-time
        self.server_time = server_time
        # x-oss-bucket-version
        self.bucket_version = bucket_version

    def validate(self):
        self.validate_required(self.request_id, 'request_id')
        self.validate_required(self.hash_crc_64ecma, 'hash_crc_64ecma')
        self.validate_required(self.server_time, 'server_time')
        self.validate_required(self.bucket_version, 'bucket_version')

    def to_map(self):
        result = dict()
        if self.request_id is not None:
            result['x-oss-request-id'] = self.request_id
        if self.hash_crc_64ecma is not None:
            result['x-oss-hash-crc64ecma'] = self.hash_crc_64ecma
        if self.server_time is not None:
            result['x-oss-server-time'] = self.server_time
        if self.bucket_version is not None:
            result['x-oss-bucket-version'] = self.bucket_version
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('x-oss-request-id') is not None:
            self.request_id = m.get('x-oss-request-id')
        if m.get('x-oss-hash-crc64ecma') is not None:
            self.hash_crc_64ecma = m.get('x-oss-hash-crc64ecma')
        if m.get('x-oss-server-time') is not None:
            self.server_time = m.get('x-oss-server-time')
        if m.get('x-oss-bucket-version') is not None:
            self.bucket_version = m.get('x-oss-bucket-version')
        return self


