# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel

from alibabacloud_tea_fileform import models as file_form_models


class Config(TeaModel):
    def __init__(self, type=None, security_token=None, access_key_id=None, access_key_secret=None, endpoint=None,
                 protocol=None, region_id=None, user_agent=None, host_model=None, signature_version=None, is_enable_md5=None,
                 is_enable_crc=None, read_timeout=None, connect_timeout=None, local_addr=None, http_proxy=None, https_proxy=None,
                 no_proxy=None, socks_5proxy=None, socks_5net_work=None, max_idle_conns=None, addtional_headers=None):
        self.type = type  # type: str
        self.security_token = security_token  # type: str
        self.access_key_id = access_key_id  # type: str
        self.access_key_secret = access_key_secret  # type: str
        self.endpoint = endpoint  # type: str
        self.protocol = protocol  # type: str
        self.region_id = region_id  # type: str
        self.user_agent = user_agent  # type: str
        self.host_model = host_model  # type: str
        self.signature_version = signature_version  # type: str
        self.is_enable_md5 = is_enable_md5  # type: bool
        self.is_enable_crc = is_enable_crc  # type: bool
        self.read_timeout = read_timeout  # type: int
        self.connect_timeout = connect_timeout  # type: int
        self.local_addr = local_addr  # type: str
        self.http_proxy = http_proxy  # type: str
        self.https_proxy = https_proxy  # type: str
        self.no_proxy = no_proxy  # type: str
        self.socks_5proxy = socks_5proxy  # type: str
        self.socks_5net_work = socks_5net_work  # type: str
        self.max_idle_conns = max_idle_conns  # type: int
        self.addtional_headers = addtional_headers  # type: list[str]

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

    def from_map(self, m=None):
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
    def __init__(self, days=None, created_before_date=None):
        # Days
        self.days = days  # type: int
        # CreatedBeforeDate
        self.created_before_date = created_before_date  # type: str

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.days is not None:
            result['Days'] = self.days
        if self.created_before_date is not None:
            result['CreatedBeforeDate'] = self.created_before_date
        return result

    def from_map(self, m=None):
        m = m or dict()
        if m.get('Days') is not None:
            self.days = m.get('Days')
        if m.get('CreatedBeforeDate') is not None:
            self.created_before_date = m.get('CreatedBeforeDate')
        return self


class PutBucketLifecycleRequestBodyLifecycleConfigurationRuleTransition(TeaModel):
    def __init__(self, days=None, storage_class=None):
        # Days
        self.days = days  # type: int
        # StorageClass
        self.storage_class = storage_class  # type: str

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.days is not None:
            result['Days'] = self.days
        if self.storage_class is not None:
            result['StorageClass'] = self.storage_class
        return result

    def from_map(self, m=None):
        m = m or dict()
        if m.get('Days') is not None:
            self.days = m.get('Days')
        if m.get('StorageClass') is not None:
            self.storage_class = m.get('StorageClass')
        return self


class PutBucketLifecycleRequestBodyLifecycleConfigurationRuleAbortMultipartUpload(TeaModel):
    def __init__(self, days=None, created_before_date=None):
        # Days
        self.days = days  # type: int
        # CreatedBeforeDate
        self.created_before_date = created_before_date  # type: str

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.days is not None:
            result['Days'] = self.days
        if self.created_before_date is not None:
            result['CreatedBeforeDate'] = self.created_before_date
        return result

    def from_map(self, m=None):
        m = m or dict()
        if m.get('Days') is not None:
            self.days = m.get('Days')
        if m.get('CreatedBeforeDate') is not None:
            self.created_before_date = m.get('CreatedBeforeDate')
        return self


class PutBucketLifecycleRequestBodyLifecycleConfigurationRuleTag(TeaModel):
    def __init__(self, key=None, value=None):
        # Key
        self.key = key  # type: str
        # Value
        self.value = value  # type: str

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.key is not None:
            result['Key'] = self.key
        if self.value is not None:
            result['Value'] = self.value
        return result

    def from_map(self, m=None):
        m = m or dict()
        if m.get('Key') is not None:
            self.key = m.get('Key')
        if m.get('Value') is not None:
            self.value = m.get('Value')
        return self


class PutBucketLifecycleRequestBodyLifecycleConfigurationRule(TeaModel):
    def __init__(self, expiration=None, transition=None, abort_multipart_upload=None, tag=None, i_d=None,
                 prefix=None, status=None):
        # Expiration
        self.expiration = expiration  # type: PutBucketLifecycleRequestBodyLifecycleConfigurationRuleExpiration
        # Transition
        self.transition = transition  # type: PutBucketLifecycleRequestBodyLifecycleConfigurationRuleTransition
        # AbortMultipartUpload
        self.abort_multipart_upload = abort_multipart_upload  # type: PutBucketLifecycleRequestBodyLifecycleConfigurationRuleAbortMultipartUpload
        # Tag
        self.tag = tag  # type: PutBucketLifecycleRequestBodyLifecycleConfigurationRuleTag
        # ID
        self.i_d = i_d  # type: str
        # Prefix
        self.prefix = prefix  # type: str
        # Status
        self.status = status  # type: str

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

    def from_map(self, m=None):
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
    def __init__(self, rule=None):
        # Rule
        self.rule = rule  # type: list[PutBucketLifecycleRequestBodyLifecycleConfigurationRule]

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

    def from_map(self, m=None):
        m = m or dict()
        self.rule = []
        if m.get('Rule') is not None:
            for k in m.get('Rule'):
                temp_model = PutBucketLifecycleRequestBodyLifecycleConfigurationRule()
                self.rule.append(temp_model.from_map(k))
        return self


class PutBucketLifecycleRequestBody(TeaModel):
    def __init__(self, lifecycle_configuration=None):
        # LifecycleConfiguration
        self.lifecycle_configuration = lifecycle_configuration  # type: PutBucketLifecycleRequestBodyLifecycleConfiguration

    def validate(self):
        self.validate_required(self.lifecycle_configuration, 'lifecycle_configuration')
        if self.lifecycle_configuration:
            self.lifecycle_configuration.validate()

    def to_map(self):
        result = dict()
        if self.lifecycle_configuration is not None:
            result['LifecycleConfiguration'] = self.lifecycle_configuration.to_map()
        return result

    def from_map(self, m=None):
        m = m or dict()
        if m.get('LifecycleConfiguration') is not None:
            temp_model = PutBucketLifecycleRequestBodyLifecycleConfiguration()
            self.lifecycle_configuration = temp_model.from_map(m['LifecycleConfiguration'])
        return self


class PutBucketLifecycleRequest(TeaModel):
    def __init__(self, bucket_name=None, body=None):
        # BucketName
        self.bucket_name = bucket_name  # type: str
        # Body
        self.body = body  # type: PutBucketLifecycleRequestBody

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

    def from_map(self, m=None):
        m = m or dict()
        if m.get('BucketName') is not None:
            self.bucket_name = m.get('BucketName')
        if m.get('Body') is not None:
            temp_model = PutBucketLifecycleRequestBody()
            self.body = temp_model.from_map(m['Body'])
        return self


class PutBucketLifecycleResponse(TeaModel):
    def __init__(self, request_id=None):
        # x-oss-request-id
        self.request_id = request_id  # type: str

    def validate(self):
        self.validate_required(self.request_id, 'request_id')

    def to_map(self):
        result = dict()
        if self.request_id is not None:
            result['x-oss-request-id'] = self.request_id
        return result

    def from_map(self, m=None):
        m = m or dict()
        if m.get('x-oss-request-id') is not None:
            self.request_id = m.get('x-oss-request-id')
        return self


class DeleteMultipleObjectsRequestBodyDeleteObject(TeaModel):
    def __init__(self, key=None):
        # Key
        self.key = key  # type: str

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.key is not None:
            result['Key'] = self.key
        return result

    def from_map(self, m=None):
        m = m or dict()
        if m.get('Key') is not None:
            self.key = m.get('Key')
        return self


class DeleteMultipleObjectsRequestBodyDelete(TeaModel):
    def __init__(self, object=None, quiet=None):
        # Object
        self.object = object  # type: list[DeleteMultipleObjectsRequestBodyDeleteObject]
        # Quiet
        self.quiet = quiet  # type: str

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

    def from_map(self, m=None):
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
    def __init__(self, delete=None):
        # Delete
        self.delete = delete  # type: DeleteMultipleObjectsRequestBodyDelete

    def validate(self):
        self.validate_required(self.delete, 'delete')
        if self.delete:
            self.delete.validate()

    def to_map(self):
        result = dict()
        if self.delete is not None:
            result['Delete'] = self.delete.to_map()
        return result

    def from_map(self, m=None):
        m = m or dict()
        if m.get('Delete') is not None:
            temp_model = DeleteMultipleObjectsRequestBodyDelete()
            self.delete = temp_model.from_map(m['Delete'])
        return self


class DeleteMultipleObjectsRequestHeader(TeaModel):
    def __init__(self, encoding_type=None, content_length=None, content_md5=None):
        # Encoding-type
        self.encoding_type = encoding_type  # type: str
        # Content-Length
        self.content_length = content_length  # type: str
        # Content-MD5
        self.content_md5 = content_md5  # type: str

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

    def from_map(self, m=None):
        m = m or dict()
        if m.get('Encoding-type') is not None:
            self.encoding_type = m.get('Encoding-type')
        if m.get('Content-Length') is not None:
            self.content_length = m.get('Content-Length')
        if m.get('Content-MD5') is not None:
            self.content_md5 = m.get('Content-MD5')
        return self


class DeleteMultipleObjectsRequest(TeaModel):
    def __init__(self, bucket_name=None, body=None, header=None):
        # BucketName
        self.bucket_name = bucket_name  # type: str
        # Body
        self.body = body  # type: DeleteMultipleObjectsRequestBody
        # Header
        self.header = header  # type: DeleteMultipleObjectsRequestHeader

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

    def from_map(self, m=None):
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
    def __init__(self, key=None):
        # Key
        self.key = key  # type: str

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.key is not None:
            result['Key'] = self.key
        return result

    def from_map(self, m=None):
        m = m or dict()
        if m.get('Key') is not None:
            self.key = m.get('Key')
        return self


class DeleteMultipleObjectsResponseDeleteResult(TeaModel):
    def __init__(self, quiet=None, encoding_type=None, deleted=None):
        # Quiet
        self.quiet = quiet  # type: str
        # EncodingType
        self.encoding_type = encoding_type  # type: str
        # Deleted
        self.deleted = deleted  # type: list[DeleteMultipleObjectsResponseDeleteResultDeleted]

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

    def from_map(self, m=None):
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
    def __init__(self, request_id=None, delete_result=None):
        # x-oss-request-id
        self.request_id = request_id  # type: str
        # DeleteResult
        self.delete_result = delete_result  # type: DeleteMultipleObjectsResponseDeleteResult

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

    def from_map(self, m=None):
        m = m or dict()
        if m.get('x-oss-request-id') is not None:
            self.request_id = m.get('x-oss-request-id')
        if m.get('DeleteResult') is not None:
            temp_model = DeleteMultipleObjectsResponseDeleteResult()
            self.delete_result = temp_model.from_map(m['DeleteResult'])
        return self


class PutBucketRefererRequestBodyRefererConfigurationRefererList(TeaModel):
    def __init__(self, referer=None):
        # Referer
        self.referer = referer  # type: list[str]

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.referer is not None:
            result['Referer'] = self.referer
        return result

    def from_map(self, m=None):
        m = m or dict()
        if m.get('Referer') is not None:
            self.referer = m.get('Referer')
        return self


class PutBucketRefererRequestBodyRefererConfiguration(TeaModel):
    def __init__(self, referer_list=None, allow_empty_referer=None):
        # RefererList
        self.referer_list = referer_list  # type: PutBucketRefererRequestBodyRefererConfigurationRefererList
        # AllowEmptyReferer
        self.allow_empty_referer = allow_empty_referer  # type: bool

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

    def from_map(self, m=None):
        m = m or dict()
        if m.get('RefererList') is not None:
            temp_model = PutBucketRefererRequestBodyRefererConfigurationRefererList()
            self.referer_list = temp_model.from_map(m['RefererList'])
        if m.get('AllowEmptyReferer') is not None:
            self.allow_empty_referer = m.get('AllowEmptyReferer')
        return self


class PutBucketRefererRequestBody(TeaModel):
    def __init__(self, referer_configuration=None):
        # RefererConfiguration
        self.referer_configuration = referer_configuration  # type: PutBucketRefererRequestBodyRefererConfiguration

    def validate(self):
        self.validate_required(self.referer_configuration, 'referer_configuration')
        if self.referer_configuration:
            self.referer_configuration.validate()

    def to_map(self):
        result = dict()
        if self.referer_configuration is not None:
            result['RefererConfiguration'] = self.referer_configuration.to_map()
        return result

    def from_map(self, m=None):
        m = m or dict()
        if m.get('RefererConfiguration') is not None:
            temp_model = PutBucketRefererRequestBodyRefererConfiguration()
            self.referer_configuration = temp_model.from_map(m['RefererConfiguration'])
        return self


class PutBucketRefererRequest(TeaModel):
    def __init__(self, bucket_name=None, body=None):
        # BucketName
        self.bucket_name = bucket_name  # type: str
        # Body
        self.body = body  # type: PutBucketRefererRequestBody

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

    def from_map(self, m=None):
        m = m or dict()
        if m.get('BucketName') is not None:
            self.bucket_name = m.get('BucketName')
        if m.get('Body') is not None:
            temp_model = PutBucketRefererRequestBody()
            self.body = temp_model.from_map(m['Body'])
        return self


class PutBucketRefererResponse(TeaModel):
    def __init__(self, request_id=None):
        # x-oss-request-id
        self.request_id = request_id  # type: str

    def validate(self):
        self.validate_required(self.request_id, 'request_id')

    def to_map(self):
        result = dict()
        if self.request_id is not None:
            result['x-oss-request-id'] = self.request_id
        return result

    def from_map(self, m=None):
        m = m or dict()
        if m.get('x-oss-request-id') is not None:
            self.request_id = m.get('x-oss-request-id')
        return self


class PutBucketWebsiteRequestBodyWebsiteConfigurationIndexDocument(TeaModel):
    def __init__(self, suffix=None):
        # Suffix
        self.suffix = suffix  # type: str

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.suffix is not None:
            result['Suffix'] = self.suffix
        return result

    def from_map(self, m=None):
        m = m or dict()
        if m.get('Suffix') is not None:
            self.suffix = m.get('Suffix')
        return self


class PutBucketWebsiteRequestBodyWebsiteConfigurationErrorDocument(TeaModel):
    def __init__(self, key=None):
        # Key
        self.key = key  # type: str

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.key is not None:
            result['Key'] = self.key
        return result

    def from_map(self, m=None):
        m = m or dict()
        if m.get('Key') is not None:
            self.key = m.get('Key')
        return self


class PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleConditionIncludeHeader(TeaModel):
    def __init__(self, key=None, equals=None):
        # Key
        self.key = key  # type: str
        # Equals
        self.equals = equals  # type: str

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.key is not None:
            result['Key'] = self.key
        if self.equals is not None:
            result['Equals'] = self.equals
        return result

    def from_map(self, m=None):
        m = m or dict()
        if m.get('Key') is not None:
            self.key = m.get('Key')
        if m.get('Equals') is not None:
            self.equals = m.get('Equals')
        return self


class PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleCondition(TeaModel):
    def __init__(self, include_header=None, key_prefix_equals=None, http_error_code_returned_equals=None):
        # IncludeHeader
        self.include_header = include_header  # type: PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleConditionIncludeHeader
        # KeyPrefixEquals
        self.key_prefix_equals = key_prefix_equals  # type: str
        # HttpErrorCodeReturnedEquals
        self.http_error_code_returned_equals = http_error_code_returned_equals  # type: str

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

    def from_map(self, m=None):
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
    def __init__(self, key=None, value=None):
        # Key
        self.key = key  # type: str
        # Value
        self.value = value  # type: str

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.key is not None:
            result['Key'] = self.key
        if self.value is not None:
            result['Value'] = self.value
        return result

    def from_map(self, m=None):
        m = m or dict()
        if m.get('Key') is not None:
            self.key = m.get('Key')
        if m.get('Value') is not None:
            self.value = m.get('Value')
        return self


class PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeaders(TeaModel):
    def __init__(self, set=None, pass_all=None, pass_=None, remove=None):
        # Set
        self.set = set  # type: PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeadersSet
        # PassAll
        self.pass_all = pass_all  # type: bool
        # Pass
        self.pass_ = pass_  # type: str
        # Remove
        self.remove = remove  # type: str

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

    def from_map(self, m=None):
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
    def __init__(self, mirror_headers=None, redirect_type=None, pass_query_string=None, mirror_url=None,
                 mirror_pass_query_string=None, mirror_follow_redirect=None, mirror_check_md_5=None, protocol=None, host_name=None,
                 http_redirect_code=None, replace_key_prefix_with=None, replace_key_with=None):
        # MirrorHeaders
        self.mirror_headers = mirror_headers  # type: PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeaders
        # RedirectType
        self.redirect_type = redirect_type  # type: str
        # PassQueryString
        self.pass_query_string = pass_query_string  # type: bool
        # MirrorURL
        self.mirror_url = mirror_url  # type: str
        # MirrorPassQueryString
        self.mirror_pass_query_string = mirror_pass_query_string  # type: bool
        # MirrorFollowRedirect
        self.mirror_follow_redirect = mirror_follow_redirect  # type: bool
        # MirrorCheckMd5
        self.mirror_check_md_5 = mirror_check_md_5  # type: bool
        # Protocol
        self.protocol = protocol  # type: str
        # HostName
        self.host_name = host_name  # type: str
        # HttpRedirectCode
        self.http_redirect_code = http_redirect_code  # type: str
        # ReplaceKeyPrefixWith
        self.replace_key_prefix_with = replace_key_prefix_with  # type: str
        # ReplaceKeyWith
        self.replace_key_with = replace_key_with  # type: str

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

    def from_map(self, m=None):
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
    def __init__(self, condition=None, redirect=None, rule_number=None):
        # Condition
        self.condition = condition  # type: PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleCondition
        # Redirect
        self.redirect = redirect  # type: PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirect
        # RuleNumber
        self.rule_number = rule_number  # type: int

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

    def from_map(self, m=None):
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
    def __init__(self, routing_rule=None):
        # RoutingRule
        self.routing_rule = routing_rule  # type: list[PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRule]

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

    def from_map(self, m=None):
        m = m or dict()
        self.routing_rule = []
        if m.get('RoutingRule') is not None:
            for k in m.get('RoutingRule'):
                temp_model = PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRule()
                self.routing_rule.append(temp_model.from_map(k))
        return self


class PutBucketWebsiteRequestBodyWebsiteConfiguration(TeaModel):
    def __init__(self, index_document=None, error_document=None, routing_rules=None):
        # IndexDocument
        self.index_document = index_document  # type: PutBucketWebsiteRequestBodyWebsiteConfigurationIndexDocument
        # ErrorDocument
        self.error_document = error_document  # type: PutBucketWebsiteRequestBodyWebsiteConfigurationErrorDocument
        # RoutingRules
        self.routing_rules = routing_rules  # type: PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRules

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

    def from_map(self, m=None):
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
    def __init__(self, website_configuration=None):
        # WebsiteConfiguration
        self.website_configuration = website_configuration  # type: PutBucketWebsiteRequestBodyWebsiteConfiguration

    def validate(self):
        self.validate_required(self.website_configuration, 'website_configuration')
        if self.website_configuration:
            self.website_configuration.validate()

    def to_map(self):
        result = dict()
        if self.website_configuration is not None:
            result['WebsiteConfiguration'] = self.website_configuration.to_map()
        return result

    def from_map(self, m=None):
        m = m or dict()
        if m.get('WebsiteConfiguration') is not None:
            temp_model = PutBucketWebsiteRequestBodyWebsiteConfiguration()
            self.website_configuration = temp_model.from_map(m['WebsiteConfiguration'])
        return self


class PutBucketWebsiteRequest(TeaModel):
    def __init__(self, bucket_name=None, body=None):
        # BucketName
        self.bucket_name = bucket_name  # type: str
        # Body
        self.body = body  # type: PutBucketWebsiteRequestBody

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

    def from_map(self, m=None):
        m = m or dict()
        if m.get('BucketName') is not None:
            self.bucket_name = m.get('BucketName')
        if m.get('Body') is not None:
            temp_model = PutBucketWebsiteRequestBody()
            self.body = temp_model.from_map(m['Body'])
        return self


class PutBucketWebsiteResponse(TeaModel):
    def __init__(self, request_id=None):
        # x-oss-request-id
        self.request_id = request_id  # type: str

    def validate(self):
        self.validate_required(self.request_id, 'request_id')

    def to_map(self):
        result = dict()
        if self.request_id is not None:
            result['x-oss-request-id'] = self.request_id
        return result

    def from_map(self, m=None):
        m = m or dict()
        if m.get('x-oss-request-id') is not None:
            self.request_id = m.get('x-oss-request-id')
        return self


class CompleteMultipartUploadRequestFilter(TeaModel):
    def __init__(self, upload_id=None, encoding_type=None):
        # uploadId
        self.upload_id = upload_id  # type: str
        # Encoding-type
        self.encoding_type = encoding_type  # type: str

    def validate(self):
        self.validate_required(self.upload_id, 'upload_id')

    def to_map(self):
        result = dict()
        if self.upload_id is not None:
            result['uploadId'] = self.upload_id
        if self.encoding_type is not None:
            result['Encoding-type'] = self.encoding_type
        return result

    def from_map(self, m=None):
        m = m or dict()
        if m.get('uploadId') is not None:
            self.upload_id = m.get('uploadId')
        if m.get('Encoding-type') is not None:
            self.encoding_type = m.get('Encoding-type')
        return self


class CompleteMultipartUploadRequestBodyCompleteMultipartUploadPart(TeaModel):
    def __init__(self, part_number=None, e_tag=None):
        # PartNumber
        self.part_number = part_number  # type: str
        # ETag
        self.e_tag = e_tag  # type: str

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.part_number is not None:
            result['PartNumber'] = self.part_number
        if self.e_tag is not None:
            result['ETag'] = self.e_tag
        return result

    def from_map(self, m=None):
        m = m or dict()
        if m.get('PartNumber') is not None:
            self.part_number = m.get('PartNumber')
        if m.get('ETag') is not None:
            self.e_tag = m.get('ETag')
        return self


class CompleteMultipartUploadRequestBodyCompleteMultipartUpload(TeaModel):
    def __init__(self, part=None):
        # Part
        self.part = part  # type: list[CompleteMultipartUploadRequestBodyCompleteMultipartUploadPart]

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

    def from_map(self, m=None):
        m = m or dict()
        self.part = []
        if m.get('Part') is not None:
            for k in m.get('Part'):
                temp_model = CompleteMultipartUploadRequestBodyCompleteMultipartUploadPart()
                self.part.append(temp_model.from_map(k))
        return self


class CompleteMultipartUploadRequestBody(TeaModel):
    def __init__(self, complete_multipart_upload=None):
        # CompleteMultipartUpload
        self.complete_multipart_upload = complete_multipart_upload  # type: CompleteMultipartUploadRequestBodyCompleteMultipartUpload

    def validate(self):
        self.validate_required(self.complete_multipart_upload, 'complete_multipart_upload')
        if self.complete_multipart_upload:
            self.complete_multipart_upload.validate()

    def to_map(self):
        result = dict()
        if self.complete_multipart_upload is not None:
            result['CompleteMultipartUpload'] = self.complete_multipart_upload.to_map()
        return result

    def from_map(self, m=None):
        m = m or dict()
        if m.get('CompleteMultipartUpload') is not None:
            temp_model = CompleteMultipartUploadRequestBodyCompleteMultipartUpload()
            self.complete_multipart_upload = temp_model.from_map(m['CompleteMultipartUpload'])
        return self


class CompleteMultipartUploadRequest(TeaModel):
    def __init__(self, bucket_name=None, object_name=None, filter=None, body=None):
        # BucketName
        self.bucket_name = bucket_name  # type: str
        # ObjectName
        self.object_name = object_name  # type: str
        # Filter
        self.filter = filter  # type: CompleteMultipartUploadRequestFilter
        # Body
        self.body = body  # type: CompleteMultipartUploadRequestBody

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

    def from_map(self, m=None):
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
    def __init__(self, bucket=None, e_tag=None, location=None, key=None, encoding_type=None):
        # Bucket
        self.bucket = bucket  # type: str
        # ETag
        self.e_tag = e_tag  # type: str
        # Location
        self.location = location  # type: str
        # Key
        self.key = key  # type: str
        # EncodingType
        self.encoding_type = encoding_type  # type: str

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

    def from_map(self, m=None):
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
    def __init__(self, request_id=None, complete_multipart_upload_result=None):
        # x-oss-request-id
        self.request_id = request_id  # type: str
        # CompleteMultipartUploadResult
        self.complete_multipart_upload_result = complete_multipart_upload_result  # type: CompleteMultipartUploadResponseCompleteMultipartUploadResult

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

    def from_map(self, m=None):
        m = m or dict()
        if m.get('x-oss-request-id') is not None:
            self.request_id = m.get('x-oss-request-id')
        if m.get('CompleteMultipartUploadResult') is not None:
            temp_model = CompleteMultipartUploadResponseCompleteMultipartUploadResult()
            self.complete_multipart_upload_result = temp_model.from_map(m['CompleteMultipartUploadResult'])
        return self


class PutBucketLoggingRequestBodyBucketLoggingStatusLoggingEnabled(TeaModel):
    def __init__(self, target_bucket=None, target_prefix=None):
        # TargetBucket
        self.target_bucket = target_bucket  # type: str
        # TargetPrefix
        self.target_prefix = target_prefix  # type: str

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.target_bucket is not None:
            result['TargetBucket'] = self.target_bucket
        if self.target_prefix is not None:
            result['TargetPrefix'] = self.target_prefix
        return result

    def from_map(self, m=None):
        m = m or dict()
        if m.get('TargetBucket') is not None:
            self.target_bucket = m.get('TargetBucket')
        if m.get('TargetPrefix') is not None:
            self.target_prefix = m.get('TargetPrefix')
        return self


class PutBucketLoggingRequestBodyBucketLoggingStatus(TeaModel):
    def __init__(self, logging_enabled=None):
        # LoggingEnabled
        self.logging_enabled = logging_enabled  # type: PutBucketLoggingRequestBodyBucketLoggingStatusLoggingEnabled

    def validate(self):
        if self.logging_enabled:
            self.logging_enabled.validate()

    def to_map(self):
        result = dict()
        if self.logging_enabled is not None:
            result['LoggingEnabled'] = self.logging_enabled.to_map()
        return result

    def from_map(self, m=None):
        m = m or dict()
        if m.get('LoggingEnabled') is not None:
            temp_model = PutBucketLoggingRequestBodyBucketLoggingStatusLoggingEnabled()
            self.logging_enabled = temp_model.from_map(m['LoggingEnabled'])
        return self


class PutBucketLoggingRequestBody(TeaModel):
    def __init__(self, bucket_logging_status=None):
        # BucketLoggingStatus
        self.bucket_logging_status = bucket_logging_status  # type: PutBucketLoggingRequestBodyBucketLoggingStatus

    def validate(self):
        self.validate_required(self.bucket_logging_status, 'bucket_logging_status')
        if self.bucket_logging_status:
            self.bucket_logging_status.validate()

    def to_map(self):
        result = dict()
        if self.bucket_logging_status is not None:
            result['BucketLoggingStatus'] = self.bucket_logging_status.to_map()
        return result

    def from_map(self, m=None):
        m = m or dict()
        if m.get('BucketLoggingStatus') is not None:
            temp_model = PutBucketLoggingRequestBodyBucketLoggingStatus()
            self.bucket_logging_status = temp_model.from_map(m['BucketLoggingStatus'])
        return self


class PutBucketLoggingRequest(TeaModel):
    def __init__(self, bucket_name=None, body=None):
        # BucketName
        self.bucket_name = bucket_name  # type: str
        # Body
        self.body = body  # type: PutBucketLoggingRequestBody

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

    def from_map(self, m=None):
        m = m or dict()
        if m.get('BucketName') is not None:
            self.bucket_name = m.get('BucketName')
        if m.get('Body') is not None:
            temp_model = PutBucketLoggingRequestBody()
            self.body = temp_model.from_map(m['Body'])
        return self


class PutBucketLoggingResponse(TeaModel):
    def __init__(self, request_id=None):
        # x-oss-request-id
        self.request_id = request_id  # type: str

    def validate(self):
        self.validate_required(self.request_id, 'request_id')

    def to_map(self):
        result = dict()
        if self.request_id is not None:
            result['x-oss-request-id'] = self.request_id
        return result

    def from_map(self, m=None):
        m = m or dict()
        if m.get('x-oss-request-id') is not None:
            self.request_id = m.get('x-oss-request-id')
        return self


class PutBucketRequestPaymentRequestBodyRequestPaymentConfiguration(TeaModel):
    def __init__(self, payer=None):
        # Payer
        self.payer = payer  # type: str

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.payer is not None:
            result['Payer'] = self.payer
        return result

    def from_map(self, m=None):
        m = m or dict()
        if m.get('Payer') is not None:
            self.payer = m.get('Payer')
        return self


class PutBucketRequestPaymentRequestBody(TeaModel):
    def __init__(self, request_payment_configuration=None):
        # RequestPaymentConfiguration
        self.request_payment_configuration = request_payment_configuration  # type: PutBucketRequestPaymentRequestBodyRequestPaymentConfiguration

    def validate(self):
        self.validate_required(self.request_payment_configuration, 'request_payment_configuration')
        if self.request_payment_configuration:
            self.request_payment_configuration.validate()

    def to_map(self):
        result = dict()
        if self.request_payment_configuration is not None:
            result['RequestPaymentConfiguration'] = self.request_payment_configuration.to_map()
        return result

    def from_map(self, m=None):
        m = m or dict()
        if m.get('RequestPaymentConfiguration') is not None:
            temp_model = PutBucketRequestPaymentRequestBodyRequestPaymentConfiguration()
            self.request_payment_configuration = temp_model.from_map(m['RequestPaymentConfiguration'])
        return self


class PutBucketRequestPaymentRequest(TeaModel):
    def __init__(self, bucket_name=None, body=None):
        # BucketName
        self.bucket_name = bucket_name  # type: str
        # Body
        self.body = body  # type: PutBucketRequestPaymentRequestBody

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

    def from_map(self, m=None):
        m = m or dict()
        if m.get('BucketName') is not None:
            self.bucket_name = m.get('BucketName')
        if m.get('Body') is not None:
            temp_model = PutBucketRequestPaymentRequestBody()
            self.body = temp_model.from_map(m['Body'])
        return self


class PutBucketRequestPaymentResponse(TeaModel):
    def __init__(self, request_id=None):
        # x-oss-request-id
        self.request_id = request_id  # type: str

    def validate(self):
        self.validate_required(self.request_id, 'request_id')

    def to_map(self):
        result = dict()
        if self.request_id is not None:
            result['x-oss-request-id'] = self.request_id
        return result

    def from_map(self, m=None):
        m = m or dict()
        if m.get('x-oss-request-id') is not None:
            self.request_id = m.get('x-oss-request-id')
        return self


class PutBucketEncryptionRequestBodyServerSideEncryptionRuleApplyServerSideEncryptionByDefault(TeaModel):
    def __init__(self, s_sealgorithm=None, k_msmaster_key_id=None):
        # SSEAlgorithm
        self.s_sealgorithm = s_sealgorithm  # type: str
        # KMSMasterKeyID
        self.k_msmaster_key_id = k_msmaster_key_id  # type: str

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.s_sealgorithm is not None:
            result['SSEAlgorithm'] = self.s_sealgorithm
        if self.k_msmaster_key_id is not None:
            result['KMSMasterKeyID'] = self.k_msmaster_key_id
        return result

    def from_map(self, m=None):
        m = m or dict()
        if m.get('SSEAlgorithm') is not None:
            self.s_sealgorithm = m.get('SSEAlgorithm')
        if m.get('KMSMasterKeyID') is not None:
            self.k_msmaster_key_id = m.get('KMSMasterKeyID')
        return self


class PutBucketEncryptionRequestBodyServerSideEncryptionRule(TeaModel):
    def __init__(self, apply_server_side_encryption_by_default=None):
        # ApplyServerSideEncryptionByDefault
        self.apply_server_side_encryption_by_default = apply_server_side_encryption_by_default  # type: PutBucketEncryptionRequestBodyServerSideEncryptionRuleApplyServerSideEncryptionByDefault

    def validate(self):
        if self.apply_server_side_encryption_by_default:
            self.apply_server_side_encryption_by_default.validate()

    def to_map(self):
        result = dict()
        if self.apply_server_side_encryption_by_default is not None:
            result['ApplyServerSideEncryptionByDefault'] = self.apply_server_side_encryption_by_default.to_map()
        return result

    def from_map(self, m=None):
        m = m or dict()
        if m.get('ApplyServerSideEncryptionByDefault') is not None:
            temp_model = PutBucketEncryptionRequestBodyServerSideEncryptionRuleApplyServerSideEncryptionByDefault()
            self.apply_server_side_encryption_by_default = temp_model.from_map(m['ApplyServerSideEncryptionByDefault'])
        return self


class PutBucketEncryptionRequestBody(TeaModel):
    def __init__(self, server_side_encryption_rule=None):
        # ServerSideEncryptionRule
        self.server_side_encryption_rule = server_side_encryption_rule  # type: PutBucketEncryptionRequestBodyServerSideEncryptionRule

    def validate(self):
        self.validate_required(self.server_side_encryption_rule, 'server_side_encryption_rule')
        if self.server_side_encryption_rule:
            self.server_side_encryption_rule.validate()

    def to_map(self):
        result = dict()
        if self.server_side_encryption_rule is not None:
            result['ServerSideEncryptionRule'] = self.server_side_encryption_rule.to_map()
        return result

    def from_map(self, m=None):
        m = m or dict()
        if m.get('ServerSideEncryptionRule') is not None:
            temp_model = PutBucketEncryptionRequestBodyServerSideEncryptionRule()
            self.server_side_encryption_rule = temp_model.from_map(m['ServerSideEncryptionRule'])
        return self


class PutBucketEncryptionRequest(TeaModel):
    def __init__(self, bucket_name=None, body=None):
        # BucketName
        self.bucket_name = bucket_name  # type: str
        # Body
        self.body = body  # type: PutBucketEncryptionRequestBody

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

    def from_map(self, m=None):
        m = m or dict()
        if m.get('BucketName') is not None:
            self.bucket_name = m.get('BucketName')
        if m.get('Body') is not None:
            temp_model = PutBucketEncryptionRequestBody()
            self.body = temp_model.from_map(m['Body'])
        return self


class PutBucketEncryptionResponse(TeaModel):
    def __init__(self, request_id=None):
        # x-oss-request-id
        self.request_id = request_id  # type: str

    def validate(self):
        self.validate_required(self.request_id, 'request_id')

    def to_map(self):
        result = dict()
        if self.request_id is not None:
            result['x-oss-request-id'] = self.request_id
        return result

    def from_map(self, m=None):
        m = m or dict()
        if m.get('x-oss-request-id') is not None:
            self.request_id = m.get('x-oss-request-id')
        return self


class PutLiveChannelRequestBodyLiveChannelConfigurationTarget(TeaModel):
    def __init__(self, type=None, frag_duration=None, frag_count=None, playlist_name=None):
        # Type
        self.type = type  # type: str
        # FragDuration
        self.frag_duration = frag_duration  # type: str
        # FragCount
        self.frag_count = frag_count  # type: str
        # PlaylistName
        self.playlist_name = playlist_name  # type: str

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

    def from_map(self, m=None):
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
    def __init__(self, role_name=None, dest_bucket=None, notify_topic=None, interval=None):
        # RoleName
        self.role_name = role_name  # type: str
        # DestBucket
        self.dest_bucket = dest_bucket  # type: str
        # NotifyTopic
        self.notify_topic = notify_topic  # type: str
        # Interval
        self.interval = interval  # type: str

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

    def from_map(self, m=None):
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
    def __init__(self, target=None, snapshot=None, description=None, status=None):
        # Target
        self.target = target  # type: PutLiveChannelRequestBodyLiveChannelConfigurationTarget
        # Snapshot
        self.snapshot = snapshot  # type: PutLiveChannelRequestBodyLiveChannelConfigurationSnapshot
        # Description
        self.description = description  # type: str
        # Status
        self.status = status  # type: str

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

    def from_map(self, m=None):
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
    def __init__(self, live_channel_configuration=None):
        # LiveChannelConfiguration
        self.live_channel_configuration = live_channel_configuration  # type: PutLiveChannelRequestBodyLiveChannelConfiguration

    def validate(self):
        self.validate_required(self.live_channel_configuration, 'live_channel_configuration')
        if self.live_channel_configuration:
            self.live_channel_configuration.validate()

    def to_map(self):
        result = dict()
        if self.live_channel_configuration is not None:
            result['LiveChannelConfiguration'] = self.live_channel_configuration.to_map()
        return result

    def from_map(self, m=None):
        m = m or dict()
        if m.get('LiveChannelConfiguration') is not None:
            temp_model = PutLiveChannelRequestBodyLiveChannelConfiguration()
            self.live_channel_configuration = temp_model.from_map(m['LiveChannelConfiguration'])
        return self


class PutLiveChannelRequest(TeaModel):
    def __init__(self, bucket_name=None, channel_name=None, body=None):
        # BucketName
        self.bucket_name = bucket_name  # type: str
        # ChannelName
        self.channel_name = channel_name  # type: str
        # Body
        self.body = body  # type: PutLiveChannelRequestBody

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

    def from_map(self, m=None):
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
    def __init__(self, url=None):
        # Url
        self.url = url  # type: str

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.url is not None:
            result['Url'] = self.url
        return result

    def from_map(self, m=None):
        m = m or dict()
        if m.get('Url') is not None:
            self.url = m.get('Url')
        return self


class PutLiveChannelResponseCreateLiveChannelResultPlayUrls(TeaModel):
    def __init__(self, url=None):
        # Url
        self.url = url  # type: str

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.url is not None:
            result['Url'] = self.url
        return result

    def from_map(self, m=None):
        m = m or dict()
        if m.get('Url') is not None:
            self.url = m.get('Url')
        return self


class PutLiveChannelResponseCreateLiveChannelResult(TeaModel):
    def __init__(self, publish_urls=None, play_urls=None):
        # PublishUrls
        self.publish_urls = publish_urls  # type: PutLiveChannelResponseCreateLiveChannelResultPublishUrls
        # PlayUrls
        self.play_urls = play_urls  # type: PutLiveChannelResponseCreateLiveChannelResultPlayUrls

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

    def from_map(self, m=None):
        m = m or dict()
        if m.get('PublishUrls') is not None:
            temp_model = PutLiveChannelResponseCreateLiveChannelResultPublishUrls()
            self.publish_urls = temp_model.from_map(m['PublishUrls'])
        if m.get('PlayUrls') is not None:
            temp_model = PutLiveChannelResponseCreateLiveChannelResultPlayUrls()
            self.play_urls = temp_model.from_map(m['PlayUrls'])
        return self


class PutLiveChannelResponse(TeaModel):
    def __init__(self, request_id=None, create_live_channel_result=None):
        # x-oss-request-id
        self.request_id = request_id  # type: str
        # CreateLiveChannelResult
        self.create_live_channel_result = create_live_channel_result  # type: PutLiveChannelResponseCreateLiveChannelResult

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

    def from_map(self, m=None):
        m = m or dict()
        if m.get('x-oss-request-id') is not None:
            self.request_id = m.get('x-oss-request-id')
        if m.get('CreateLiveChannelResult') is not None:
            temp_model = PutLiveChannelResponseCreateLiveChannelResult()
            self.create_live_channel_result = temp_model.from_map(m['CreateLiveChannelResult'])
        return self


class PutBucketTagsRequestBodyTaggingTagSetTag(TeaModel):
    def __init__(self, key=None, value=None):
        # Key
        self.key = key  # type: str
        # Value
        self.value = value  # type: str

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.key is not None:
            result['Key'] = self.key
        if self.value is not None:
            result['Value'] = self.value
        return result

    def from_map(self, m=None):
        m = m or dict()
        if m.get('Key') is not None:
            self.key = m.get('Key')
        if m.get('Value') is not None:
            self.value = m.get('Value')
        return self


class PutBucketTagsRequestBodyTaggingTagSet(TeaModel):
    def __init__(self, tag=None):
        # Tag
        self.tag = tag  # type: list[PutBucketTagsRequestBodyTaggingTagSetTag]

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

    def from_map(self, m=None):
        m = m or dict()
        self.tag = []
        if m.get('Tag') is not None:
            for k in m.get('Tag'):
                temp_model = PutBucketTagsRequestBodyTaggingTagSetTag()
                self.tag.append(temp_model.from_map(k))
        return self


class PutBucketTagsRequestBodyTagging(TeaModel):
    def __init__(self, tag_set=None):
        # TagSet
        self.tag_set = tag_set  # type: PutBucketTagsRequestBodyTaggingTagSet

    def validate(self):
        if self.tag_set:
            self.tag_set.validate()

    def to_map(self):
        result = dict()
        if self.tag_set is not None:
            result['TagSet'] = self.tag_set.to_map()
        return result

    def from_map(self, m=None):
        m = m or dict()
        if m.get('TagSet') is not None:
            temp_model = PutBucketTagsRequestBodyTaggingTagSet()
            self.tag_set = temp_model.from_map(m['TagSet'])
        return self


class PutBucketTagsRequestBody(TeaModel):
    def __init__(self, tagging=None):
        # Tagging
        self.tagging = tagging  # type: PutBucketTagsRequestBodyTagging

    def validate(self):
        self.validate_required(self.tagging, 'tagging')
        if self.tagging:
            self.tagging.validate()

    def to_map(self):
        result = dict()
        if self.tagging is not None:
            result['Tagging'] = self.tagging.to_map()
        return result

    def from_map(self, m=None):
        m = m or dict()
        if m.get('Tagging') is not None:
            temp_model = PutBucketTagsRequestBodyTagging()
            self.tagging = temp_model.from_map(m['Tagging'])
        return self


class PutBucketTagsRequest(TeaModel):
    def __init__(self, bucket_name=None, body=None):
        # BucketName
        self.bucket_name = bucket_name  # type: str
        # Body
        self.body = body  # type: PutBucketTagsRequestBody

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

    def from_map(self, m=None):
        m = m or dict()
        if m.get('BucketName') is not None:
            self.bucket_name = m.get('BucketName')
        if m.get('Body') is not None:
            temp_model = PutBucketTagsRequestBody()
            self.body = temp_model.from_map(m['Body'])
        return self


class PutBucketTagsResponse(TeaModel):
    def __init__(self, request_id=None):
        # x-oss-request-id
        self.request_id = request_id  # type: str

    def validate(self):
        self.validate_required(self.request_id, 'request_id')

    def to_map(self):
        result = dict()
        if self.request_id is not None:
            result['x-oss-request-id'] = self.request_id
        return result

    def from_map(self, m=None):
        m = m or dict()
        if m.get('x-oss-request-id') is not None:
            self.request_id = m.get('x-oss-request-id')
        return self


class PutObjectTaggingRequestBodyTaggingTagSetTag(TeaModel):
    def __init__(self, key=None, value=None):
        # Key
        self.key = key  # type: str
        # Value
        self.value = value  # type: str

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.key is not None:
            result['Key'] = self.key
        if self.value is not None:
            result['Value'] = self.value
        return result

    def from_map(self, m=None):
        m = m or dict()
        if m.get('Key') is not None:
            self.key = m.get('Key')
        if m.get('Value') is not None:
            self.value = m.get('Value')
        return self


class PutObjectTaggingRequestBodyTaggingTagSet(TeaModel):
    def __init__(self, tag=None):
        # Tag
        self.tag = tag  # type: list[PutObjectTaggingRequestBodyTaggingTagSetTag]

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

    def from_map(self, m=None):
        m = m or dict()
        self.tag = []
        if m.get('Tag') is not None:
            for k in m.get('Tag'):
                temp_model = PutObjectTaggingRequestBodyTaggingTagSetTag()
                self.tag.append(temp_model.from_map(k))
        return self


class PutObjectTaggingRequestBodyTagging(TeaModel):
    def __init__(self, tag_set=None):
        # TagSet
        self.tag_set = tag_set  # type: PutObjectTaggingRequestBodyTaggingTagSet

    def validate(self):
        if self.tag_set:
            self.tag_set.validate()

    def to_map(self):
        result = dict()
        if self.tag_set is not None:
            result['TagSet'] = self.tag_set.to_map()
        return result

    def from_map(self, m=None):
        m = m or dict()
        if m.get('TagSet') is not None:
            temp_model = PutObjectTaggingRequestBodyTaggingTagSet()
            self.tag_set = temp_model.from_map(m['TagSet'])
        return self


class PutObjectTaggingRequestBody(TeaModel):
    def __init__(self, tagging=None):
        # Tagging
        self.tagging = tagging  # type: PutObjectTaggingRequestBodyTagging

    def validate(self):
        self.validate_required(self.tagging, 'tagging')
        if self.tagging:
            self.tagging.validate()

    def to_map(self):
        result = dict()
        if self.tagging is not None:
            result['Tagging'] = self.tagging.to_map()
        return result

    def from_map(self, m=None):
        m = m or dict()
        if m.get('Tagging') is not None:
            temp_model = PutObjectTaggingRequestBodyTagging()
            self.tagging = temp_model.from_map(m['Tagging'])
        return self


class PutObjectTaggingRequest(TeaModel):
    def __init__(self, bucket_name=None, object_name=None, body=None):
        # BucketName
        self.bucket_name = bucket_name  # type: str
        # ObjectName
        self.object_name = object_name  # type: str
        # Body
        self.body = body  # type: PutObjectTaggingRequestBody

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

    def from_map(self, m=None):
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
    def __init__(self, request_id=None):
        # x-oss-request-id
        self.request_id = request_id  # type: str

    def validate(self):
        self.validate_required(self.request_id, 'request_id')

    def to_map(self):
        result = dict()
        if self.request_id is not None:
            result['x-oss-request-id'] = self.request_id
        return result

    def from_map(self, m=None):
        m = m or dict()
        if m.get('x-oss-request-id') is not None:
            self.request_id = m.get('x-oss-request-id')
        return self


class SelectObjectRequestFilter(TeaModel):
    def __init__(self, porcess=None):
        # x-oss-process
        self.porcess = porcess  # type: str

    def validate(self):
        self.validate_required(self.porcess, 'porcess')

    def to_map(self):
        result = dict()
        if self.porcess is not None:
            result['x-oss-process'] = self.porcess
        return result

    def from_map(self, m=None):
        m = m or dict()
        if m.get('x-oss-process') is not None:
            self.porcess = m.get('x-oss-process')
        return self


class SelectObjectRequestBodySelectRequestInputSerializationCSV(TeaModel):
    def __init__(self, file_header_info=None, record_delimiter=None, field_delimiter=None, quote_character=None,
                 comment_character=None, range=None):
        # FileHeaderInfo
        self.file_header_info = file_header_info  # type: str
        # RecordDelimiter
        self.record_delimiter = record_delimiter  # type: str
        # FieldDelimiter
        self.field_delimiter = field_delimiter  # type: str
        # QuoteCharacter
        self.quote_character = quote_character  # type: str
        # CommentCharacter
        self.comment_character = comment_character  # type: str
        # Range
        self.range = range  # type: str

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

    def from_map(self, m=None):
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
    def __init__(self, c_sv=None, compression_type=None):
        # CSV
        self.c_sv = c_sv  # type: SelectObjectRequestBodySelectRequestInputSerializationCSV
        # CompressionType
        self.compression_type = compression_type  # type: str

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

    def from_map(self, m=None):
        m = m or dict()
        if m.get('CSV') is not None:
            temp_model = SelectObjectRequestBodySelectRequestInputSerializationCSV()
            self.c_sv = temp_model.from_map(m['CSV'])
        if m.get('CompressionType') is not None:
            self.compression_type = m.get('CompressionType')
        return self


class SelectObjectRequestBodySelectRequestOutputSerializationCSV(TeaModel):
    def __init__(self, record_delimiter=None, field_delimiter=None):
        # RecordDelimiter
        self.record_delimiter = record_delimiter  # type: str
        # FieldDelimiter
        self.field_delimiter = field_delimiter  # type: str

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.record_delimiter is not None:
            result['RecordDelimiter'] = self.record_delimiter
        if self.field_delimiter is not None:
            result['FieldDelimiter'] = self.field_delimiter
        return result

    def from_map(self, m=None):
        m = m or dict()
        if m.get('RecordDelimiter') is not None:
            self.record_delimiter = m.get('RecordDelimiter')
        if m.get('FieldDelimiter') is not None:
            self.field_delimiter = m.get('FieldDelimiter')
        return self


class SelectObjectRequestBodySelectRequestOutputSerialization(TeaModel):
    def __init__(self, c_sv=None, keep_all_columns=None, output_raw_data=None, enable_payload_crc=None,
                 output_header=None):
        # CSV
        self.c_sv = c_sv  # type: SelectObjectRequestBodySelectRequestOutputSerializationCSV
        # KeepAllColumns
        self.keep_all_columns = keep_all_columns  # type: str
        # OutputRawData
        self.output_raw_data = output_raw_data  # type: str
        # EnablePayloadCrc
        self.enable_payload_crc = enable_payload_crc  # type: str
        # OutputHeader
        self.output_header = output_header  # type: str

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

    def from_map(self, m=None):
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
    def __init__(self, skip_partial_data_record=None, max_skipped_records_allowed=None):
        # SkipPartialDataRecord
        self.skip_partial_data_record = skip_partial_data_record  # type: str
        # MaxSkippedRecordsAllowed
        self.max_skipped_records_allowed = max_skipped_records_allowed  # type: str

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.skip_partial_data_record is not None:
            result['SkipPartialDataRecord'] = self.skip_partial_data_record
        if self.max_skipped_records_allowed is not None:
            result['MaxSkippedRecordsAllowed'] = self.max_skipped_records_allowed
        return result

    def from_map(self, m=None):
        m = m or dict()
        if m.get('SkipPartialDataRecord') is not None:
            self.skip_partial_data_record = m.get('SkipPartialDataRecord')
        if m.get('MaxSkippedRecordsAllowed') is not None:
            self.max_skipped_records_allowed = m.get('MaxSkippedRecordsAllowed')
        return self


class SelectObjectRequestBodySelectRequest(TeaModel):
    def __init__(self, input_serialization=None, output_serialization=None, options=None, expression=None):
        # InputSerialization
        self.input_serialization = input_serialization  # type: SelectObjectRequestBodySelectRequestInputSerialization
        # OutputSerialization
        self.output_serialization = output_serialization  # type: SelectObjectRequestBodySelectRequestOutputSerialization
        # Options
        self.options = options  # type: SelectObjectRequestBodySelectRequestOptions
        # Expression
        self.expression = expression  # type: str

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

    def from_map(self, m=None):
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
    def __init__(self, select_request=None):
        # SelectRequest
        self.select_request = select_request  # type: SelectObjectRequestBodySelectRequest

    def validate(self):
        self.validate_required(self.select_request, 'select_request')
        if self.select_request:
            self.select_request.validate()

    def to_map(self):
        result = dict()
        if self.select_request is not None:
            result['SelectRequest'] = self.select_request.to_map()
        return result

    def from_map(self, m=None):
        m = m or dict()
        if m.get('SelectRequest') is not None:
            temp_model = SelectObjectRequestBodySelectRequest()
            self.select_request = temp_model.from_map(m['SelectRequest'])
        return self


class SelectObjectRequest(TeaModel):
    def __init__(self, bucket_name=None, object_name=None, filter=None, body=None):
        # BucketName
        self.bucket_name = bucket_name  # type: str
        # ObjectName
        self.object_name = object_name  # type: str
        # Filter
        self.filter = filter  # type: SelectObjectRequestFilter
        # Body
        self.body = body  # type: SelectObjectRequestBody

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

    def from_map(self, m=None):
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
    def __init__(self, request_id=None):
        # x-oss-request-id
        self.request_id = request_id  # type: str

    def validate(self):
        self.validate_required(self.request_id, 'request_id')

    def to_map(self):
        result = dict()
        if self.request_id is not None:
            result['x-oss-request-id'] = self.request_id
        return result

    def from_map(self, m=None):
        m = m or dict()
        if m.get('x-oss-request-id') is not None:
            self.request_id = m.get('x-oss-request-id')
        return self


class PutBucketCORSRequestBodyCORSConfigurationCORSRule(TeaModel):
    def __init__(self, allowed_origin=None, allowed_method=None, allowed_header=None, expose_header=None,
                 max_age_seconds=None):
        # AllowedOrigin
        self.allowed_origin = allowed_origin  # type: list[str]
        # AllowedMethod
        self.allowed_method = allowed_method  # type: list[str]
        # AllowedHeader
        self.allowed_header = allowed_header  # type: list[str]
        # ExposeHeader
        self.expose_header = expose_header  # type: list[str]
        # MaxAgeSeconds
        self.max_age_seconds = max_age_seconds  # type: str

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

    def from_map(self, m=None):
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
    def __init__(self, c_orsrule=None):
        # CORSRule
        self.c_orsrule = c_orsrule  # type: list[PutBucketCORSRequestBodyCORSConfigurationCORSRule]

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

    def from_map(self, m=None):
        m = m or dict()
        self.c_orsrule = []
        if m.get('CORSRule') is not None:
            for k in m.get('CORSRule'):
                temp_model = PutBucketCORSRequestBodyCORSConfigurationCORSRule()
                self.c_orsrule.append(temp_model.from_map(k))
        return self


class PutBucketCORSRequestBody(TeaModel):
    def __init__(self, c_orsconfiguration=None):
        # CORSConfiguration
        self.c_orsconfiguration = c_orsconfiguration  # type: PutBucketCORSRequestBodyCORSConfiguration

    def validate(self):
        self.validate_required(self.c_orsconfiguration, 'c_orsconfiguration')
        if self.c_orsconfiguration:
            self.c_orsconfiguration.validate()

    def to_map(self):
        result = dict()
        if self.c_orsconfiguration is not None:
            result['CORSConfiguration'] = self.c_orsconfiguration.to_map()
        return result

    def from_map(self, m=None):
        m = m or dict()
        if m.get('CORSConfiguration') is not None:
            temp_model = PutBucketCORSRequestBodyCORSConfiguration()
            self.c_orsconfiguration = temp_model.from_map(m['CORSConfiguration'])
        return self


class PutBucketCORSRequest(TeaModel):
    def __init__(self, bucket_name=None, body=None):
        # BucketName
        self.bucket_name = bucket_name  # type: str
        # Body
        self.body = body  # type: PutBucketCORSRequestBody

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

    def from_map(self, m=None):
        m = m or dict()
        if m.get('BucketName') is not None:
            self.bucket_name = m.get('BucketName')
        if m.get('Body') is not None:
            temp_model = PutBucketCORSRequestBody()
            self.body = temp_model.from_map(m['Body'])
        return self


class PutBucketCORSResponse(TeaModel):
    def __init__(self, request_id=None):
        # x-oss-request-id
        self.request_id = request_id  # type: str

    def validate(self):
        self.validate_required(self.request_id, 'request_id')

    def to_map(self):
        result = dict()
        if self.request_id is not None:
            result['x-oss-request-id'] = self.request_id
        return result

    def from_map(self, m=None):
        m = m or dict()
        if m.get('x-oss-request-id') is not None:
            self.request_id = m.get('x-oss-request-id')
        return self


class PutBucketRequestBodyCreateBucketConfiguration(TeaModel):
    def __init__(self, storage_class=None, data_redundancy_type=None):
        # StorageClass
        self.storage_class = storage_class  # type: str
        # DataRedundancyType
        self.data_redundancy_type = data_redundancy_type  # type: str

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.storage_class is not None:
            result['StorageClass'] = self.storage_class
        if self.data_redundancy_type is not None:
            result['DataRedundancyType'] = self.data_redundancy_type
        return result

    def from_map(self, m=None):
        m = m or dict()
        if m.get('StorageClass') is not None:
            self.storage_class = m.get('StorageClass')
        if m.get('DataRedundancyType') is not None:
            self.data_redundancy_type = m.get('DataRedundancyType')
        return self


class PutBucketRequestBody(TeaModel):
    def __init__(self, create_bucket_configuration=None):
        # CreateBucketConfiguration
        self.create_bucket_configuration = create_bucket_configuration  # type: PutBucketRequestBodyCreateBucketConfiguration

    def validate(self):
        self.validate_required(self.create_bucket_configuration, 'create_bucket_configuration')
        if self.create_bucket_configuration:
            self.create_bucket_configuration.validate()

    def to_map(self):
        result = dict()
        if self.create_bucket_configuration is not None:
            result['CreateBucketConfiguration'] = self.create_bucket_configuration.to_map()
        return result

    def from_map(self, m=None):
        m = m or dict()
        if m.get('CreateBucketConfiguration') is not None:
            temp_model = PutBucketRequestBodyCreateBucketConfiguration()
            self.create_bucket_configuration = temp_model.from_map(m['CreateBucketConfiguration'])
        return self


class PutBucketRequestHeader(TeaModel):
    def __init__(self, acl=None):
        # x-oss-acl
        self.acl = acl  # type: str

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.acl is not None:
            result['x-oss-acl'] = self.acl
        return result

    def from_map(self, m=None):
        m = m or dict()
        if m.get('x-oss-acl') is not None:
            self.acl = m.get('x-oss-acl')
        return self


class PutBucketRequest(TeaModel):
    def __init__(self, bucket_name=None, body=None, header=None):
        # BucketName
        self.bucket_name = bucket_name  # type: str
        # Body
        self.body = body  # type: PutBucketRequestBody
        # Header
        self.header = header  # type: PutBucketRequestHeader

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

    def from_map(self, m=None):
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
    def __init__(self, request_id=None):
        # x-oss-request-id
        self.request_id = request_id  # type: str

    def validate(self):
        self.validate_required(self.request_id, 'request_id')

    def to_map(self):
        result = dict()
        if self.request_id is not None:
            result['x-oss-request-id'] = self.request_id
        return result

    def from_map(self, m=None):
        m = m or dict()
        if m.get('x-oss-request-id') is not None:
            self.request_id = m.get('x-oss-request-id')
        return self


class ListMultipartUploadsRequestFilter(TeaModel):
    def __init__(self, delimiter=None, max_uploads=None, key_marker=None, prefix=None, upload_id_marker=None,
                 encoding_type=None):
        # delimiter
        self.delimiter = delimiter  # type: str
        # max-uploads
        self.max_uploads = max_uploads  # type: str
        # key-marker
        self.key_marker = key_marker  # type: str
        # prefix
        self.prefix = prefix  # type: str
        # upload-id-marker
        self.upload_id_marker = upload_id_marker  # type: str
        # encoding-type
        self.encoding_type = encoding_type  # type: str

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

    def from_map(self, m=None):
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
    def __init__(self, bucket_name=None, filter=None):
        # BucketName
        self.bucket_name = bucket_name  # type: str
        # Filter
        self.filter = filter  # type: ListMultipartUploadsRequestFilter

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

    def from_map(self, m=None):
        m = m or dict()
        if m.get('BucketName') is not None:
            self.bucket_name = m.get('BucketName')
        if m.get('Filter') is not None:
            temp_model = ListMultipartUploadsRequestFilter()
            self.filter = temp_model.from_map(m['Filter'])
        return self


class ListMultipartUploadsResponseListMultipartUploadsResultUpload(TeaModel):
    def __init__(self, key=None, upload_id=None, initiated=None):
        # Key
        self.key = key  # type: str
        # UploadId
        self.upload_id = upload_id  # type: str
        # Initiated
        self.initiated = initiated  # type: str

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

    def from_map(self, m=None):
        m = m or dict()
        if m.get('Key') is not None:
            self.key = m.get('Key')
        if m.get('UploadId') is not None:
            self.upload_id = m.get('UploadId')
        if m.get('Initiated') is not None:
            self.initiated = m.get('Initiated')
        return self


class ListMultipartUploadsResponseListMultipartUploadsResult(TeaModel):
    def __init__(self, bucket=None, encoding_type=None, key_marker=None, upload_id_marker=None,
                 next_key_marker=None, next_upload_id_marker=None, delimiter=None, max_uploads=None, is_truncated=None, upload=None):
        # Bucket
        self.bucket = bucket  # type: str
        # EncodingType
        self.encoding_type = encoding_type  # type: str
        # KeyMarker
        self.key_marker = key_marker  # type: str
        # UploadIdMarker
        self.upload_id_marker = upload_id_marker  # type: str
        # NextKeyMarker
        self.next_key_marker = next_key_marker  # type: str
        # NextUploadIdMarker
        self.next_upload_id_marker = next_upload_id_marker  # type: str
        # Delimiter
        self.delimiter = delimiter  # type: str
        # MaxUploads
        self.max_uploads = max_uploads  # type: str
        # IsTruncated
        self.is_truncated = is_truncated  # type: str
        # Upload
        self.upload = upload  # type: list[ListMultipartUploadsResponseListMultipartUploadsResultUpload]

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

    def from_map(self, m=None):
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
    def __init__(self, request_id=None, list_multipart_uploads_result=None):
        # x-oss-request-id
        self.request_id = request_id  # type: str
        # ListMultipartUploadsResult
        self.list_multipart_uploads_result = list_multipart_uploads_result  # type: ListMultipartUploadsResponseListMultipartUploadsResult

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

    def from_map(self, m=None):
        m = m or dict()
        if m.get('x-oss-request-id') is not None:
            self.request_id = m.get('x-oss-request-id')
        if m.get('ListMultipartUploadsResult') is not None:
            temp_model = ListMultipartUploadsResponseListMultipartUploadsResult()
            self.list_multipart_uploads_result = temp_model.from_map(m['ListMultipartUploadsResult'])
        return self


class GetBucketRequestPaymentRequest(TeaModel):
    def __init__(self, bucket_name=None):
        # BucketName
        self.bucket_name = bucket_name  # type: str

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')
        if self.bucket_name is not None:
            self.validate_pattern(self.bucket_name, 'bucket_name', '[a-zA-Z0-9-_]+')

    def to_map(self):
        result = dict()
        if self.bucket_name is not None:
            result['BucketName'] = self.bucket_name
        return result

    def from_map(self, m=None):
        m = m or dict()
        if m.get('BucketName') is not None:
            self.bucket_name = m.get('BucketName')
        return self


class GetBucketRequestPaymentResponseRequestPaymentConfiguration(TeaModel):
    def __init__(self, payer=None):
        # Payer
        self.payer = payer  # type: str

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.payer is not None:
            result['Payer'] = self.payer
        return result

    def from_map(self, m=None):
        m = m or dict()
        if m.get('Payer') is not None:
            self.payer = m.get('Payer')
        return self


class GetBucketRequestPaymentResponse(TeaModel):
    def __init__(self, request_id=None, request_payment_configuration=None):
        # x-oss-request-id
        self.request_id = request_id  # type: str
        # RequestPaymentConfiguration
        self.request_payment_configuration = request_payment_configuration  # type: GetBucketRequestPaymentResponseRequestPaymentConfiguration

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

    def from_map(self, m=None):
        m = m or dict()
        if m.get('x-oss-request-id') is not None:
            self.request_id = m.get('x-oss-request-id')
        if m.get('RequestPaymentConfiguration') is not None:
            temp_model = GetBucketRequestPaymentResponseRequestPaymentConfiguration()
            self.request_payment_configuration = temp_model.from_map(m['RequestPaymentConfiguration'])
        return self


class GetBucketEncryptionRequest(TeaModel):
    def __init__(self, bucket_name=None):
        # BucketName
        self.bucket_name = bucket_name  # type: str

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')
        if self.bucket_name is not None:
            self.validate_pattern(self.bucket_name, 'bucket_name', '[a-zA-Z0-9-_]+')

    def to_map(self):
        result = dict()
        if self.bucket_name is not None:
            result['BucketName'] = self.bucket_name
        return result

    def from_map(self, m=None):
        m = m or dict()
        if m.get('BucketName') is not None:
            self.bucket_name = m.get('BucketName')
        return self


class GetBucketEncryptionResponseServerSideEncryptionRuleApplyServerSideEncryptionByDefault(TeaModel):
    def __init__(self, s_sealgorithm=None, k_msmaster_key_id=None):
        # SSEAlgorithm
        self.s_sealgorithm = s_sealgorithm  # type: str
        # KMSMasterKeyID
        self.k_msmaster_key_id = k_msmaster_key_id  # type: str

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.s_sealgorithm is not None:
            result['SSEAlgorithm'] = self.s_sealgorithm
        if self.k_msmaster_key_id is not None:
            result['KMSMasterKeyID'] = self.k_msmaster_key_id
        return result

    def from_map(self, m=None):
        m = m or dict()
        if m.get('SSEAlgorithm') is not None:
            self.s_sealgorithm = m.get('SSEAlgorithm')
        if m.get('KMSMasterKeyID') is not None:
            self.k_msmaster_key_id = m.get('KMSMasterKeyID')
        return self


class GetBucketEncryptionResponseServerSideEncryptionRule(TeaModel):
    def __init__(self, apply_server_side_encryption_by_default=None):
        # ApplyServerSideEncryptionByDefault
        self.apply_server_side_encryption_by_default = apply_server_side_encryption_by_default  # type: GetBucketEncryptionResponseServerSideEncryptionRuleApplyServerSideEncryptionByDefault

    def validate(self):
        self.validate_required(self.apply_server_side_encryption_by_default, 'apply_server_side_encryption_by_default')
        if self.apply_server_side_encryption_by_default:
            self.apply_server_side_encryption_by_default.validate()

    def to_map(self):
        result = dict()
        if self.apply_server_side_encryption_by_default is not None:
            result['ApplyServerSideEncryptionByDefault'] = self.apply_server_side_encryption_by_default.to_map()
        return result

    def from_map(self, m=None):
        m = m or dict()
        if m.get('ApplyServerSideEncryptionByDefault') is not None:
            temp_model = GetBucketEncryptionResponseServerSideEncryptionRuleApplyServerSideEncryptionByDefault()
            self.apply_server_side_encryption_by_default = temp_model.from_map(m['ApplyServerSideEncryptionByDefault'])
        return self


class GetBucketEncryptionResponse(TeaModel):
    def __init__(self, request_id=None, server_side_encryption_rule=None):
        # x-oss-request-id
        self.request_id = request_id  # type: str
        # ServerSideEncryptionRule
        self.server_side_encryption_rule = server_side_encryption_rule  # type: GetBucketEncryptionResponseServerSideEncryptionRule

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

    def from_map(self, m=None):
        m = m or dict()
        if m.get('x-oss-request-id') is not None:
            self.request_id = m.get('x-oss-request-id')
        if m.get('ServerSideEncryptionRule') is not None:
            temp_model = GetBucketEncryptionResponseServerSideEncryptionRule()
            self.server_side_encryption_rule = temp_model.from_map(m['ServerSideEncryptionRule'])
        return self


class GetBucketTagsRequest(TeaModel):
    def __init__(self, bucket_name=None):
        # BucketName
        self.bucket_name = bucket_name  # type: str

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')
        if self.bucket_name is not None:
            self.validate_pattern(self.bucket_name, 'bucket_name', '[a-zA-Z0-9-_]+')

    def to_map(self):
        result = dict()
        if self.bucket_name is not None:
            result['BucketName'] = self.bucket_name
        return result

    def from_map(self, m=None):
        m = m or dict()
        if m.get('BucketName') is not None:
            self.bucket_name = m.get('BucketName')
        return self


class GetBucketTagsResponseTaggingTagSetTag(TeaModel):
    def __init__(self, key=None, value=None):
        # Key
        self.key = key  # type: str
        # Value
        self.value = value  # type: str

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.key is not None:
            result['Key'] = self.key
        if self.value is not None:
            result['Value'] = self.value
        return result

    def from_map(self, m=None):
        m = m or dict()
        if m.get('Key') is not None:
            self.key = m.get('Key')
        if m.get('Value') is not None:
            self.value = m.get('Value')
        return self


class GetBucketTagsResponseTaggingTagSet(TeaModel):
    def __init__(self, tag=None):
        # Tag
        self.tag = tag  # type: list[GetBucketTagsResponseTaggingTagSetTag]

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

    def from_map(self, m=None):
        m = m or dict()
        self.tag = []
        if m.get('Tag') is not None:
            for k in m.get('Tag'):
                temp_model = GetBucketTagsResponseTaggingTagSetTag()
                self.tag.append(temp_model.from_map(k))
        return self


class GetBucketTagsResponseTagging(TeaModel):
    def __init__(self, tag_set=None):
        # TagSet
        self.tag_set = tag_set  # type: GetBucketTagsResponseTaggingTagSet

    def validate(self):
        self.validate_required(self.tag_set, 'tag_set')
        if self.tag_set:
            self.tag_set.validate()

    def to_map(self):
        result = dict()
        if self.tag_set is not None:
            result['TagSet'] = self.tag_set.to_map()
        return result

    def from_map(self, m=None):
        m = m or dict()
        if m.get('TagSet') is not None:
            temp_model = GetBucketTagsResponseTaggingTagSet()
            self.tag_set = temp_model.from_map(m['TagSet'])
        return self


class GetBucketTagsResponse(TeaModel):
    def __init__(self, request_id=None, tagging=None):
        # x-oss-request-id
        self.request_id = request_id  # type: str
        # Tagging
        self.tagging = tagging  # type: GetBucketTagsResponseTagging

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

    def from_map(self, m=None):
        m = m or dict()
        if m.get('x-oss-request-id') is not None:
            self.request_id = m.get('x-oss-request-id')
        if m.get('Tagging') is not None:
            temp_model = GetBucketTagsResponseTagging()
            self.tagging = temp_model.from_map(m['Tagging'])
        return self


class GetServiceRequestFilter(TeaModel):
    def __init__(self, prefix=None, marker=None, max_keys=None):
        # prefix
        self.prefix = prefix  # type: str
        # marker
        self.marker = marker  # type: str
        # max-keys
        self.max_keys = max_keys  # type: str

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

    def from_map(self, m=None):
        m = m or dict()
        if m.get('prefix') is not None:
            self.prefix = m.get('prefix')
        if m.get('marker') is not None:
            self.marker = m.get('marker')
        if m.get('max-keys') is not None:
            self.max_keys = m.get('max-keys')
        return self


class GetServiceRequest(TeaModel):
    def __init__(self, filter=None):
        # Filter
        self.filter = filter  # type: GetServiceRequestFilter

    def validate(self):
        if self.filter:
            self.filter.validate()

    def to_map(self):
        result = dict()
        if self.filter is not None:
            result['Filter'] = self.filter.to_map()
        return result

    def from_map(self, m=None):
        m = m or dict()
        if m.get('Filter') is not None:
            temp_model = GetServiceRequestFilter()
            self.filter = temp_model.from_map(m['Filter'])
        return self


class GetServiceResponseListAllMyBucketsResultOwner(TeaModel):
    def __init__(self, i_d=None, display_name=None):
        # ID
        self.i_d = i_d  # type: str
        # DisplayName
        self.display_name = display_name  # type: str

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.i_d is not None:
            result['ID'] = self.i_d
        if self.display_name is not None:
            result['DisplayName'] = self.display_name
        return result

    def from_map(self, m=None):
        m = m or dict()
        if m.get('ID') is not None:
            self.i_d = m.get('ID')
        if m.get('DisplayName') is not None:
            self.display_name = m.get('DisplayName')
        return self


class GetServiceResponseListAllMyBucketsResultBucketsBucket(TeaModel):
    def __init__(self, name=None, create_date=None, location=None, extranet_endpoint=None, intranet_endpoint=None,
                 storage_class=None):
        # Name
        self.name = name  # type: str
        # CreateDate
        self.create_date = create_date  # type: str
        # Location
        self.location = location  # type: str
        # ExtranetEndpoint
        self.extranet_endpoint = extranet_endpoint  # type: str
        # IntranetEndpoint
        self.intranet_endpoint = intranet_endpoint  # type: str
        # StorageClass
        self.storage_class = storage_class  # type: str

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

    def from_map(self, m=None):
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
    def __init__(self, bucket=None):
        # Bucket
        self.bucket = bucket  # type: list[GetServiceResponseListAllMyBucketsResultBucketsBucket]

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

    def from_map(self, m=None):
        m = m or dict()
        self.bucket = []
        if m.get('Bucket') is not None:
            for k in m.get('Bucket'):
                temp_model = GetServiceResponseListAllMyBucketsResultBucketsBucket()
                self.bucket.append(temp_model.from_map(k))
        return self


class GetServiceResponseListAllMyBucketsResult(TeaModel):
    def __init__(self, prefix=None, marker=None, max_keys=None, is_truncated=None, next_marker=None, owner=None,
                 buckets=None):
        # Prefix
        self.prefix = prefix  # type: str
        # Marker
        self.marker = marker  # type: str
        # MaxKeys
        self.max_keys = max_keys  # type: str
        # IsTruncated
        self.is_truncated = is_truncated  # type: str
        # NextMarker
        self.next_marker = next_marker  # type: str
        # Owner
        self.owner = owner  # type: GetServiceResponseListAllMyBucketsResultOwner
        # Buckets
        self.buckets = buckets  # type: GetServiceResponseListAllMyBucketsResultBuckets

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

    def from_map(self, m=None):
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
    def __init__(self, request_id=None, list_all_my_buckets_result=None):
        # x-oss-request-id
        self.request_id = request_id  # type: str
        # ListAllMyBucketsResult
        self.list_all_my_buckets_result = list_all_my_buckets_result  # type: GetServiceResponseListAllMyBucketsResult

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

    def from_map(self, m=None):
        m = m or dict()
        if m.get('x-oss-request-id') is not None:
            self.request_id = m.get('x-oss-request-id')
        if m.get('ListAllMyBucketsResult') is not None:
            temp_model = GetServiceResponseListAllMyBucketsResult()
            self.list_all_my_buckets_result = temp_model.from_map(m['ListAllMyBucketsResult'])
        return self


class DeleteBucketEncryptionRequest(TeaModel):
    def __init__(self, bucket_name=None):
        # BucketName
        self.bucket_name = bucket_name  # type: str

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')
        if self.bucket_name is not None:
            self.validate_pattern(self.bucket_name, 'bucket_name', '[a-zA-Z0-9-_]+')

    def to_map(self):
        result = dict()
        if self.bucket_name is not None:
            result['BucketName'] = self.bucket_name
        return result

    def from_map(self, m=None):
        m = m or dict()
        if m.get('BucketName') is not None:
            self.bucket_name = m.get('BucketName')
        return self


class DeleteBucketEncryptionResponse(TeaModel):
    def __init__(self, request_id=None):
        # x-oss-request-id
        self.request_id = request_id  # type: str

    def validate(self):
        self.validate_required(self.request_id, 'request_id')

    def to_map(self):
        result = dict()
        if self.request_id is not None:
            result['x-oss-request-id'] = self.request_id
        return result

    def from_map(self, m=None):
        m = m or dict()
        if m.get('x-oss-request-id') is not None:
            self.request_id = m.get('x-oss-request-id')
        return self


class DeleteBucketTagsRequestFilter(TeaModel):
    def __init__(self, tagging=None):
        # tagging
        self.tagging = tagging  # type: str

    def validate(self):
        self.validate_required(self.tagging, 'tagging')

    def to_map(self):
        result = dict()
        if self.tagging is not None:
            result['tagging'] = self.tagging
        return result

    def from_map(self, m=None):
        m = m or dict()
        if m.get('tagging') is not None:
            self.tagging = m.get('tagging')
        return self


class DeleteBucketTagsRequest(TeaModel):
    def __init__(self, bucket_name=None, filter=None):
        # BucketName
        self.bucket_name = bucket_name  # type: str
        # Filter
        self.filter = filter  # type: DeleteBucketTagsRequestFilter

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

    def from_map(self, m=None):
        m = m or dict()
        if m.get('BucketName') is not None:
            self.bucket_name = m.get('BucketName')
        if m.get('Filter') is not None:
            temp_model = DeleteBucketTagsRequestFilter()
            self.filter = temp_model.from_map(m['Filter'])
        return self


class DeleteBucketTagsResponse(TeaModel):
    def __init__(self, request_id=None):
        # x-oss-request-id
        self.request_id = request_id  # type: str

    def validate(self):
        self.validate_required(self.request_id, 'request_id')

    def to_map(self):
        result = dict()
        if self.request_id is not None:
            result['x-oss-request-id'] = self.request_id
        return result

    def from_map(self, m=None):
        m = m or dict()
        if m.get('x-oss-request-id') is not None:
            self.request_id = m.get('x-oss-request-id')
        return self


class GetBucketWebsiteRequest(TeaModel):
    def __init__(self, bucket_name=None):
        # BucketName
        self.bucket_name = bucket_name  # type: str

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')
        if self.bucket_name is not None:
            self.validate_pattern(self.bucket_name, 'bucket_name', '[a-zA-Z0-9-_]+')

    def to_map(self):
        result = dict()
        if self.bucket_name is not None:
            result['BucketName'] = self.bucket_name
        return result

    def from_map(self, m=None):
        m = m or dict()
        if m.get('BucketName') is not None:
            self.bucket_name = m.get('BucketName')
        return self


class GetBucketWebsiteResponseWebsiteConfigurationIndexDocument(TeaModel):
    def __init__(self, suffix=None):
        # Suffix
        self.suffix = suffix  # type: str

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.suffix is not None:
            result['Suffix'] = self.suffix
        return result

    def from_map(self, m=None):
        m = m or dict()
        if m.get('Suffix') is not None:
            self.suffix = m.get('Suffix')
        return self


class GetBucketWebsiteResponseWebsiteConfigurationErrorDocument(TeaModel):
    def __init__(self, key=None):
        # Key
        self.key = key  # type: str

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.key is not None:
            result['Key'] = self.key
        return result

    def from_map(self, m=None):
        m = m or dict()
        if m.get('Key') is not None:
            self.key = m.get('Key')
        return self


class GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleConditionIncludeHeader(TeaModel):
    def __init__(self, key=None, equals=None):
        # Key
        self.key = key  # type: str
        # Equals
        self.equals = equals  # type: str

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.key is not None:
            result['Key'] = self.key
        if self.equals is not None:
            result['Equals'] = self.equals
        return result

    def from_map(self, m=None):
        m = m or dict()
        if m.get('Key') is not None:
            self.key = m.get('Key')
        if m.get('Equals') is not None:
            self.equals = m.get('Equals')
        return self


class GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleCondition(TeaModel):
    def __init__(self, key_prefix_equals=None, http_error_code_returned_equals=None, include_header=None):
        # KeyPrefixEquals
        self.key_prefix_equals = key_prefix_equals  # type: str
        # HttpErrorCodeReturnedEquals
        self.http_error_code_returned_equals = http_error_code_returned_equals  # type: str
        # IncludeHeader
        self.include_header = include_header  # type: GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleConditionIncludeHeader

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

    def from_map(self, m=None):
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
    def __init__(self, key=None, value=None):
        # Key
        self.key = key  # type: str
        # Value
        self.value = value  # type: str

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.key is not None:
            result['Key'] = self.key
        if self.value is not None:
            result['Value'] = self.value
        return result

    def from_map(self, m=None):
        m = m or dict()
        if m.get('Key') is not None:
            self.key = m.get('Key')
        if m.get('Value') is not None:
            self.value = m.get('Value')
        return self


class GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeaders(TeaModel):
    def __init__(self, pass_all=None, pass_=None, remove=None, set=None):
        # PassAll
        self.pass_all = pass_all  # type: bool
        # Pass
        self.pass_ = pass_  # type: str
        # Remove
        self.remove = remove  # type: str
        # Set
        self.set = set  # type: GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeadersSet

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

    def from_map(self, m=None):
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
    def __init__(self, redirect_type=None, pass_query_string=None, mirror_url=None, mirror_pass_query_string=None,
                 mirror_follow_redirect=None, mirror_check_md_5=None, protocol=None, host_name=None, http_redirect_code=None,
                 replace_key_prefix_with=None, replace_key_with=None, mirror_headers=None):
        # RedirectType
        self.redirect_type = redirect_type  # type: str
        # PassQueryString
        self.pass_query_string = pass_query_string  # type: bool
        # MirrorURL
        self.mirror_url = mirror_url  # type: str
        # MirrorPassQueryString
        self.mirror_pass_query_string = mirror_pass_query_string  # type: bool
        # MirrorFollowRedirect
        self.mirror_follow_redirect = mirror_follow_redirect  # type: bool
        # MirrorCheckMd5
        self.mirror_check_md_5 = mirror_check_md_5  # type: bool
        # Protocol
        self.protocol = protocol  # type: str
        # HostName
        self.host_name = host_name  # type: str
        # HttpRedirectCode
        self.http_redirect_code = http_redirect_code  # type: str
        # ReplaceKeyPrefixWith
        self.replace_key_prefix_with = replace_key_prefix_with  # type: str
        # ReplaceKeyWith
        self.replace_key_with = replace_key_with  # type: str
        # MirrorHeaders
        self.mirror_headers = mirror_headers  # type: GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeaders

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

    def from_map(self, m=None):
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
    def __init__(self, rule_number=None, condition=None, redirect=None):
        # RuleNumber
        self.rule_number = rule_number  # type: int
        # Condition
        self.condition = condition  # type: GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleCondition
        # Redirect
        self.redirect = redirect  # type: GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirect

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

    def from_map(self, m=None):
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
    def __init__(self, routing_rule=None):
        # RoutingRule
        self.routing_rule = routing_rule  # type: list[GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRule]

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

    def from_map(self, m=None):
        m = m or dict()
        self.routing_rule = []
        if m.get('RoutingRule') is not None:
            for k in m.get('RoutingRule'):
                temp_model = GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRule()
                self.routing_rule.append(temp_model.from_map(k))
        return self


class GetBucketWebsiteResponseWebsiteConfiguration(TeaModel):
    def __init__(self, index_document=None, error_document=None, routing_rules=None):
        # IndexDocument
        self.index_document = index_document  # type: GetBucketWebsiteResponseWebsiteConfigurationIndexDocument
        # ErrorDocument
        self.error_document = error_document  # type: GetBucketWebsiteResponseWebsiteConfigurationErrorDocument
        # RoutingRules
        self.routing_rules = routing_rules  # type: GetBucketWebsiteResponseWebsiteConfigurationRoutingRules

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

    def from_map(self, m=None):
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
    def __init__(self, request_id=None, website_configuration=None):
        # x-oss-request-id
        self.request_id = request_id  # type: str
        # WebsiteConfiguration
        self.website_configuration = website_configuration  # type: GetBucketWebsiteResponseWebsiteConfiguration

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

    def from_map(self, m=None):
        m = m or dict()
        if m.get('x-oss-request-id') is not None:
            self.request_id = m.get('x-oss-request-id')
        if m.get('WebsiteConfiguration') is not None:
            temp_model = GetBucketWebsiteResponseWebsiteConfiguration()
            self.website_configuration = temp_model.from_map(m['WebsiteConfiguration'])
        return self


class DeleteLiveChannelRequest(TeaModel):
    def __init__(self, bucket_name=None, channel_name=None):
        # BucketName
        self.bucket_name = bucket_name  # type: str
        # ChannelName
        self.channel_name = channel_name  # type: str

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

    def from_map(self, m=None):
        m = m or dict()
        if m.get('BucketName') is not None:
            self.bucket_name = m.get('BucketName')
        if m.get('ChannelName') is not None:
            self.channel_name = m.get('ChannelName')
        return self


class DeleteLiveChannelResponse(TeaModel):
    def __init__(self, request_id=None):
        # x-oss-request-id
        self.request_id = request_id  # type: str

    def validate(self):
        self.validate_required(self.request_id, 'request_id')

    def to_map(self):
        result = dict()
        if self.request_id is not None:
            result['x-oss-request-id'] = self.request_id
        return result

    def from_map(self, m=None):
        m = m or dict()
        if m.get('x-oss-request-id') is not None:
            self.request_id = m.get('x-oss-request-id')
        return self


class GetBucketLocationRequest(TeaModel):
    def __init__(self, bucket_name=None):
        # BucketName
        self.bucket_name = bucket_name  # type: str

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')
        if self.bucket_name is not None:
            self.validate_pattern(self.bucket_name, 'bucket_name', '[a-zA-Z0-9-_]+')

    def to_map(self):
        result = dict()
        if self.bucket_name is not None:
            result['BucketName'] = self.bucket_name
        return result

    def from_map(self, m=None):
        m = m or dict()
        if m.get('BucketName') is not None:
            self.bucket_name = m.get('BucketName')
        return self


class GetBucketLocationResponse(TeaModel):
    def __init__(self, request_id=None, location_constraint=None):
        # x-oss-request-id
        self.request_id = request_id  # type: str
        # LocationConstraint
        self.location_constraint = location_constraint  # type: str

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

    def from_map(self, m=None):
        m = m or dict()
        if m.get('x-oss-request-id') is not None:
            self.request_id = m.get('x-oss-request-id')
        if m.get('LocationConstraint') is not None:
            self.location_constraint = m.get('LocationConstraint')
        return self


class ListLiveChannelRequestFilter(TeaModel):
    def __init__(self, marker=None, max_keys=None, prefix=None):
        # marker
        self.marker = marker  # type: str
        # max-keys
        self.max_keys = max_keys  # type: str
        # prefix
        self.prefix = prefix  # type: str

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

    def from_map(self, m=None):
        m = m or dict()
        if m.get('marker') is not None:
            self.marker = m.get('marker')
        if m.get('max-keys') is not None:
            self.max_keys = m.get('max-keys')
        if m.get('prefix') is not None:
            self.prefix = m.get('prefix')
        return self


class ListLiveChannelRequest(TeaModel):
    def __init__(self, bucket_name=None, filter=None):
        # BucketName
        self.bucket_name = bucket_name  # type: str
        # Filter
        self.filter = filter  # type: ListLiveChannelRequestFilter

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

    def from_map(self, m=None):
        m = m or dict()
        if m.get('BucketName') is not None:
            self.bucket_name = m.get('BucketName')
        if m.get('Filter') is not None:
            temp_model = ListLiveChannelRequestFilter()
            self.filter = temp_model.from_map(m['Filter'])
        return self


class ListLiveChannelResponseListLiveChannelResultLiveChannelPublishUrls(TeaModel):
    def __init__(self, url=None):
        # Url
        self.url = url  # type: str

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.url is not None:
            result['Url'] = self.url
        return result

    def from_map(self, m=None):
        m = m or dict()
        if m.get('Url') is not None:
            self.url = m.get('Url')
        return self


class ListLiveChannelResponseListLiveChannelResultLiveChannelPlayUrls(TeaModel):
    def __init__(self, url=None):
        # Url
        self.url = url  # type: str

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.url is not None:
            result['Url'] = self.url
        return result

    def from_map(self, m=None):
        m = m or dict()
        if m.get('Url') is not None:
            self.url = m.get('Url')
        return self


class ListLiveChannelResponseListLiveChannelResultLiveChannel(TeaModel):
    def __init__(self, name=None, description=None, status=None, last_modified=None, publish_urls=None,
                 play_urls=None):
        # Name
        self.name = name  # type: str
        # Description
        self.description = description  # type: str
        # Status
        self.status = status  # type: str
        # LastModified
        self.last_modified = last_modified  # type: str
        # PublishUrls
        self.publish_urls = publish_urls  # type: ListLiveChannelResponseListLiveChannelResultLiveChannelPublishUrls
        # PlayUrls
        self.play_urls = play_urls  # type: ListLiveChannelResponseListLiveChannelResultLiveChannelPlayUrls

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

    def from_map(self, m=None):
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
    def __init__(self, prefix=None, marker=None, max_keys=None, is_truncated=None, next_marker=None,
                 live_channel=None):
        # Prefix
        self.prefix = prefix  # type: str
        # Marker
        self.marker = marker  # type: str
        # MaxKeys
        self.max_keys = max_keys  # type: str
        # IsTruncated
        self.is_truncated = is_truncated  # type: str
        # NextMarker
        self.next_marker = next_marker  # type: str
        # LiveChannel
        self.live_channel = live_channel  # type: ListLiveChannelResponseListLiveChannelResultLiveChannel

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

    def from_map(self, m=None):
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
    def __init__(self, request_id=None, list_live_channel_result=None):
        # x-oss-request-id
        self.request_id = request_id  # type: str
        # ListLiveChannelResult
        self.list_live_channel_result = list_live_channel_result  # type: ListLiveChannelResponseListLiveChannelResult

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

    def from_map(self, m=None):
        m = m or dict()
        if m.get('x-oss-request-id') is not None:
            self.request_id = m.get('x-oss-request-id')
        if m.get('ListLiveChannelResult') is not None:
            temp_model = ListLiveChannelResponseListLiveChannelResult()
            self.list_live_channel_result = temp_model.from_map(m['ListLiveChannelResult'])
        return self


class GetObjectMetaRequest(TeaModel):
    def __init__(self, bucket_name=None, object_name=None):
        # BucketName
        self.bucket_name = bucket_name  # type: str
        # ObjectName
        self.object_name = object_name  # type: str

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

    def from_map(self, m=None):
        m = m or dict()
        if m.get('BucketName') is not None:
            self.bucket_name = m.get('BucketName')
        if m.get('ObjectName') is not None:
            self.object_name = m.get('ObjectName')
        return self


class GetObjectMetaResponse(TeaModel):
    def __init__(self, request_id=None, e_tag=None, content_length=None, last_modified=None):
        # x-oss-request-id
        self.request_id = request_id  # type: str
        # ETag
        self.e_tag = e_tag  # type: str
        # Content-Length
        self.content_length = content_length  # type: str
        # Last-Modified
        self.last_modified = last_modified  # type: str

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

    def from_map(self, m=None):
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
    def __init__(self, bucket_name=None):
        # BucketName
        self.bucket_name = bucket_name  # type: str

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')
        if self.bucket_name is not None:
            self.validate_pattern(self.bucket_name, 'bucket_name', '[a-zA-Z0-9-_]+')

    def to_map(self):
        result = dict()
        if self.bucket_name is not None:
            result['BucketName'] = self.bucket_name
        return result

    def from_map(self, m=None):
        m = m or dict()
        if m.get('BucketName') is not None:
            self.bucket_name = m.get('BucketName')
        return self


class GetBucketAclResponseAccessControlPolicyOwner(TeaModel):
    def __init__(self, i_d=None, display_name=None):
        # ID
        self.i_d = i_d  # type: str
        # DisplayName
        self.display_name = display_name  # type: str

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.i_d is not None:
            result['ID'] = self.i_d
        if self.display_name is not None:
            result['DisplayName'] = self.display_name
        return result

    def from_map(self, m=None):
        m = m or dict()
        if m.get('ID') is not None:
            self.i_d = m.get('ID')
        if m.get('DisplayName') is not None:
            self.display_name = m.get('DisplayName')
        return self


class GetBucketAclResponseAccessControlPolicyAccessControlList(TeaModel):
    def __init__(self, grant=None):
        # Grant
        self.grant = grant  # type: str

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.grant is not None:
            result['Grant'] = self.grant
        return result

    def from_map(self, m=None):
        m = m or dict()
        if m.get('Grant') is not None:
            self.grant = m.get('Grant')
        return self


class GetBucketAclResponseAccessControlPolicy(TeaModel):
    def __init__(self, owner=None, access_control_list=None):
        # Owner
        self.owner = owner  # type: GetBucketAclResponseAccessControlPolicyOwner
        # AccessControlList
        self.access_control_list = access_control_list  # type: GetBucketAclResponseAccessControlPolicyAccessControlList

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

    def from_map(self, m=None):
        m = m or dict()
        if m.get('Owner') is not None:
            temp_model = GetBucketAclResponseAccessControlPolicyOwner()
            self.owner = temp_model.from_map(m['Owner'])
        if m.get('AccessControlList') is not None:
            temp_model = GetBucketAclResponseAccessControlPolicyAccessControlList()
            self.access_control_list = temp_model.from_map(m['AccessControlList'])
        return self


class GetBucketAclResponse(TeaModel):
    def __init__(self, request_id=None, access_control_policy=None):
        # x-oss-request-id
        self.request_id = request_id  # type: str
        # AccessControlPolicy
        self.access_control_policy = access_control_policy  # type: GetBucketAclResponseAccessControlPolicy

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

    def from_map(self, m=None):
        m = m or dict()
        if m.get('x-oss-request-id') is not None:
            self.request_id = m.get('x-oss-request-id')
        if m.get('AccessControlPolicy') is not None:
            temp_model = GetBucketAclResponseAccessControlPolicy()
            self.access_control_policy = temp_model.from_map(m['AccessControlPolicy'])
        return self


class ListPartsRequestFilter(TeaModel):
    def __init__(self, upload_id=None, max_parts=None, part_number_marker=None, encoding_type=None):
        # uploadId
        self.upload_id = upload_id  # type: str
        # max-parts
        self.max_parts = max_parts  # type: int
        # part-number-marker
        self.part_number_marker = part_number_marker  # type: int
        # Encoding-type
        self.encoding_type = encoding_type  # type: str

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

    def from_map(self, m=None):
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
    def __init__(self, bucket_name=None, object_name=None, filter=None):
        # BucketName
        self.bucket_name = bucket_name  # type: str
        # ObjectName
        self.object_name = object_name  # type: str
        # Filter
        self.filter = filter  # type: ListPartsRequestFilter

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

    def from_map(self, m=None):
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
    def __init__(self, part_number=None, last_modified=None, e_tag=None, size=None):
        # PartNumber
        self.part_number = part_number  # type: str
        # LastModified
        self.last_modified = last_modified  # type: str
        # ETag
        self.e_tag = e_tag  # type: str
        # Size
        self.size = size  # type: str

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

    def from_map(self, m=None):
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
    def __init__(self, bucket=None, encoding_type=None, key=None, upload_id=None, part_number_marker=None,
                 next_part_number_marker=None, max_parts=None, is_truncated=None, part=None):
        # Bucket
        self.bucket = bucket  # type: str
        # EncodingType
        self.encoding_type = encoding_type  # type: str
        # Key
        self.key = key  # type: str
        # UploadId
        self.upload_id = upload_id  # type: str
        # PartNumberMarker
        self.part_number_marker = part_number_marker  # type: str
        # NextPartNumberMarker
        self.next_part_number_marker = next_part_number_marker  # type: str
        # MaxParts
        self.max_parts = max_parts  # type: str
        # IsTruncated
        self.is_truncated = is_truncated  # type: str
        # Part
        self.part = part  # type: list[ListPartsResponseListPartsResultPart]

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

    def from_map(self, m=None):
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
    def __init__(self, request_id=None, list_parts_result=None):
        # x-oss-request-id
        self.request_id = request_id  # type: str
        # ListPartsResult
        self.list_parts_result = list_parts_result  # type: ListPartsResponseListPartsResult

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

    def from_map(self, m=None):
        m = m or dict()
        if m.get('x-oss-request-id') is not None:
            self.request_id = m.get('x-oss-request-id')
        if m.get('ListPartsResult') is not None:
            temp_model = ListPartsResponseListPartsResult()
            self.list_parts_result = temp_model.from_map(m['ListPartsResult'])
        return self


class GetLiveChannelHistoryRequestFilter(TeaModel):
    def __init__(self, comp=None):
        # comp
        self.comp = comp  # type: str

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.comp is not None:
            result['comp'] = self.comp
        return result

    def from_map(self, m=None):
        m = m or dict()
        if m.get('comp') is not None:
            self.comp = m.get('comp')
        return self


class GetLiveChannelHistoryRequest(TeaModel):
    def __init__(self, bucket_name=None, channel_name=None, filter=None):
        # BucketName
        self.bucket_name = bucket_name  # type: str
        # ChannelName
        self.channel_name = channel_name  # type: str
        # Filter
        self.filter = filter  # type: GetLiveChannelHistoryRequestFilter

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

    def from_map(self, m=None):
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
    def __init__(self, start_time=None, end_time=None, remote_addr=None):
        # StartTime
        self.start_time = start_time  # type: str
        # EndTime
        self.end_time = end_time  # type: str
        # RemoteAddr
        self.remote_addr = remote_addr  # type: str

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

    def from_map(self, m=None):
        m = m or dict()
        if m.get('StartTime') is not None:
            self.start_time = m.get('StartTime')
        if m.get('EndTime') is not None:
            self.end_time = m.get('EndTime')
        if m.get('RemoteAddr') is not None:
            self.remote_addr = m.get('RemoteAddr')
        return self


class GetLiveChannelHistoryResponseLiveChannelHistory(TeaModel):
    def __init__(self, live_record=None):
        # LiveRecord
        self.live_record = live_record  # type: list[GetLiveChannelHistoryResponseLiveChannelHistoryLiveRecord]

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

    def from_map(self, m=None):
        m = m or dict()
        self.live_record = []
        if m.get('LiveRecord') is not None:
            for k in m.get('LiveRecord'):
                temp_model = GetLiveChannelHistoryResponseLiveChannelHistoryLiveRecord()
                self.live_record.append(temp_model.from_map(k))
        return self


class GetLiveChannelHistoryResponse(TeaModel):
    def __init__(self, request_id=None, live_channel_history=None):
        # x-oss-request-id
        self.request_id = request_id  # type: str
        # LiveChannelHistory
        self.live_channel_history = live_channel_history  # type: GetLiveChannelHistoryResponseLiveChannelHistory

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

    def from_map(self, m=None):
        m = m or dict()
        if m.get('x-oss-request-id') is not None:
            self.request_id = m.get('x-oss-request-id')
        if m.get('LiveChannelHistory') is not None:
            temp_model = GetLiveChannelHistoryResponseLiveChannelHistory()
            self.live_channel_history = temp_model.from_map(m['LiveChannelHistory'])
        return self


class GetBucketRequestFilter(TeaModel):
    def __init__(self, delimiter=None, marker=None, max_keys=None, prefix=None, encoding_type=None):
        # delimiter
        self.delimiter = delimiter  # type: str
        # marker
        self.marker = marker  # type: str
        # max-keys
        self.max_keys = max_keys  # type: str
        # prefix
        self.prefix = prefix  # type: str
        # encoding-type
        self.encoding_type = encoding_type  # type: str

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

    def from_map(self, m=None):
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
    def __init__(self, bucket_name=None, filter=None):
        # BucketName
        self.bucket_name = bucket_name  # type: str
        # Filter
        self.filter = filter  # type: GetBucketRequestFilter

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

    def from_map(self, m=None):
        m = m or dict()
        if m.get('BucketName') is not None:
            self.bucket_name = m.get('BucketName')
        if m.get('Filter') is not None:
            temp_model = GetBucketRequestFilter()
            self.filter = temp_model.from_map(m['Filter'])
        return self


class GetBucketResponseListBucketResultContentsOwner(TeaModel):
    def __init__(self, i_d=None, display_name=None):
        # ID
        self.i_d = i_d  # type: str
        # DisplayName
        self.display_name = display_name  # type: str

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.i_d is not None:
            result['ID'] = self.i_d
        if self.display_name is not None:
            result['DisplayName'] = self.display_name
        return result

    def from_map(self, m=None):
        m = m or dict()
        if m.get('ID') is not None:
            self.i_d = m.get('ID')
        if m.get('DisplayName') is not None:
            self.display_name = m.get('DisplayName')
        return self


class GetBucketResponseListBucketResultContents(TeaModel):
    def __init__(self, key=None, e_tag=None, last_modified=None, size=None, storage_class=None, owner=None):
        # Key
        self.key = key  # type: str
        # ETag
        self.e_tag = e_tag  # type: str
        # LastModified
        self.last_modified = last_modified  # type: str
        # Size
        self.size = size  # type: str
        # StorageClass
        self.storage_class = storage_class  # type: str
        # Owner
        self.owner = owner  # type: GetBucketResponseListBucketResultContentsOwner

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

    def from_map(self, m=None):
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
    def __init__(self, name=None, prefix=None, marker=None, max_keys=None, delimiter=None, is_truncated=None,
                 encoding_type=None, common_prefixes=None, contents=None):
        # Name
        self.name = name  # type: str
        # Prefix
        self.prefix = prefix  # type: str
        # Marker
        self.marker = marker  # type: str
        # MaxKeys
        self.max_keys = max_keys  # type: str
        # Delimiter
        self.delimiter = delimiter  # type: str
        # IsTruncated
        self.is_truncated = is_truncated  # type: str
        # EncodingType
        self.encoding_type = encoding_type  # type: str
        # CommonPrefixes
        self.common_prefixes = common_prefixes  # type: str
        # Contents
        self.contents = contents  # type: list[GetBucketResponseListBucketResultContents]

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

    def from_map(self, m=None):
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
    def __init__(self, request_id=None, list_bucket_result=None):
        # x-oss-request-id
        self.request_id = request_id  # type: str
        # ListBucketResult
        self.list_bucket_result = list_bucket_result  # type: GetBucketResponseListBucketResult

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

    def from_map(self, m=None):
        m = m or dict()
        if m.get('x-oss-request-id') is not None:
            self.request_id = m.get('x-oss-request-id')
        if m.get('ListBucketResult') is not None:
            temp_model = GetBucketResponseListBucketResult()
            self.list_bucket_result = temp_model.from_map(m['ListBucketResult'])
        return self


class GetLiveChannelInfoRequest(TeaModel):
    def __init__(self, bucket_name=None, channel_name=None):
        # BucketName
        self.bucket_name = bucket_name  # type: str
        # ChannelName
        self.channel_name = channel_name  # type: str

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

    def from_map(self, m=None):
        m = m or dict()
        if m.get('BucketName') is not None:
            self.bucket_name = m.get('BucketName')
        if m.get('ChannelName') is not None:
            self.channel_name = m.get('ChannelName')
        return self


class GetLiveChannelInfoResponseLiveChannelConfigurationTarget(TeaModel):
    def __init__(self, type=None, frag_duration=None, frag_count=None, playlist_name=None):
        # Type
        self.type = type  # type: str
        # FragDuration
        self.frag_duration = frag_duration  # type: str
        # FragCount
        self.frag_count = frag_count  # type: str
        # PlaylistName
        self.playlist_name = playlist_name  # type: str

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

    def from_map(self, m=None):
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
    def __init__(self, description=None, status=None, target=None):
        # Description
        self.description = description  # type: str
        # Status
        self.status = status  # type: str
        # Target
        self.target = target  # type: GetLiveChannelInfoResponseLiveChannelConfigurationTarget

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

    def from_map(self, m=None):
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
    def __init__(self, request_id=None, live_channel_configuration=None):
        # x-oss-request-id
        self.request_id = request_id  # type: str
        # LiveChannelConfiguration
        self.live_channel_configuration = live_channel_configuration  # type: GetLiveChannelInfoResponseLiveChannelConfiguration

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

    def from_map(self, m=None):
        m = m or dict()
        if m.get('x-oss-request-id') is not None:
            self.request_id = m.get('x-oss-request-id')
        if m.get('LiveChannelConfiguration') is not None:
            temp_model = GetLiveChannelInfoResponseLiveChannelConfiguration()
            self.live_channel_configuration = temp_model.from_map(m['LiveChannelConfiguration'])
        return self


class GetLiveChannelStatRequestFilter(TeaModel):
    def __init__(self, comp=None):
        # comp
        self.comp = comp  # type: str

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.comp is not None:
            result['comp'] = self.comp
        return result

    def from_map(self, m=None):
        m = m or dict()
        if m.get('comp') is not None:
            self.comp = m.get('comp')
        return self


class GetLiveChannelStatRequest(TeaModel):
    def __init__(self, bucket_name=None, channel_name=None, filter=None):
        # BucketName
        self.bucket_name = bucket_name  # type: str
        # ChannelName
        self.channel_name = channel_name  # type: str
        # Filter
        self.filter = filter  # type: GetLiveChannelStatRequestFilter

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

    def from_map(self, m=None):
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
    def __init__(self, width=None, height=None, frame_rate=None, bandwidth=None, codec=None):
        # Width
        self.width = width  # type: str
        # Height
        self.height = height  # type: str
        # FrameRate
        self.frame_rate = frame_rate  # type: str
        # Bandwidth
        self.bandwidth = bandwidth  # type: str
        # Codec
        self.codec = codec  # type: str

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

    def from_map(self, m=None):
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
    def __init__(self, bandwidth=None, sample_rate=None, codec=None):
        # Bandwidth
        self.bandwidth = bandwidth  # type: str
        # SampleRate
        self.sample_rate = sample_rate  # type: str
        # Codec
        self.codec = codec  # type: str

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

    def from_map(self, m=None):
        m = m or dict()
        if m.get('Bandwidth') is not None:
            self.bandwidth = m.get('Bandwidth')
        if m.get('SampleRate') is not None:
            self.sample_rate = m.get('SampleRate')
        if m.get('Codec') is not None:
            self.codec = m.get('Codec')
        return self


class GetLiveChannelStatResponseLiveChannelStat(TeaModel):
    def __init__(self, status=None, connected_time=None, remote_addr=None, video=None, audio=None):
        # Status
        self.status = status  # type: str
        # ConnectedTime
        self.connected_time = connected_time  # type: str
        # RemoteAddr
        self.remote_addr = remote_addr  # type: str
        # Video
        self.video = video  # type: GetLiveChannelStatResponseLiveChannelStatVideo
        # Audio
        self.audio = audio  # type: GetLiveChannelStatResponseLiveChannelStatAudio

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

    def from_map(self, m=None):
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
    def __init__(self, request_id=None, live_channel_stat=None):
        # x-oss-request-id
        self.request_id = request_id  # type: str
        # LiveChannelStat
        self.live_channel_stat = live_channel_stat  # type: GetLiveChannelStatResponseLiveChannelStat

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

    def from_map(self, m=None):
        m = m or dict()
        if m.get('x-oss-request-id') is not None:
            self.request_id = m.get('x-oss-request-id')
        if m.get('LiveChannelStat') is not None:
            temp_model = GetLiveChannelStatResponseLiveChannelStat()
            self.live_channel_stat = temp_model.from_map(m['LiveChannelStat'])
        return self


class DeleteObjectRequest(TeaModel):
    def __init__(self, bucket_name=None, object_name=None):
        # BucketName
        self.bucket_name = bucket_name  # type: str
        # ObjectName
        self.object_name = object_name  # type: str

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

    def from_map(self, m=None):
        m = m or dict()
        if m.get('BucketName') is not None:
            self.bucket_name = m.get('BucketName')
        if m.get('ObjectName') is not None:
            self.object_name = m.get('ObjectName')
        return self


class DeleteObjectResponse(TeaModel):
    def __init__(self, request_id=None):
        # x-oss-request-id
        self.request_id = request_id  # type: str

    def validate(self):
        self.validate_required(self.request_id, 'request_id')

    def to_map(self):
        result = dict()
        if self.request_id is not None:
            result['x-oss-request-id'] = self.request_id
        return result

    def from_map(self, m=None):
        m = m or dict()
        if m.get('x-oss-request-id') is not None:
            self.request_id = m.get('x-oss-request-id')
        return self


class AbortMultipartUploadRequestFilter(TeaModel):
    def __init__(self, upload_id=None):
        # uploadId
        self.upload_id = upload_id  # type: str

    def validate(self):
        self.validate_required(self.upload_id, 'upload_id')

    def to_map(self):
        result = dict()
        if self.upload_id is not None:
            result['uploadId'] = self.upload_id
        return result

    def from_map(self, m=None):
        m = m or dict()
        if m.get('uploadId') is not None:
            self.upload_id = m.get('uploadId')
        return self


class AbortMultipartUploadRequest(TeaModel):
    def __init__(self, bucket_name=None, object_name=None, filter=None):
        # BucketName
        self.bucket_name = bucket_name  # type: str
        # ObjectName
        self.object_name = object_name  # type: str
        # Filter
        self.filter = filter  # type: AbortMultipartUploadRequestFilter

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

    def from_map(self, m=None):
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
    def __init__(self, request_id=None):
        # x-oss-request-id
        self.request_id = request_id  # type: str

    def validate(self):
        self.validate_required(self.request_id, 'request_id')

    def to_map(self):
        result = dict()
        if self.request_id is not None:
            result['x-oss-request-id'] = self.request_id
        return result

    def from_map(self, m=None):
        m = m or dict()
        if m.get('x-oss-request-id') is not None:
            self.request_id = m.get('x-oss-request-id')
        return self


class AppendObjectRequestFilter(TeaModel):
    def __init__(self, position=None):
        # position
        self.position = position  # type: str

    def validate(self):
        self.validate_required(self.position, 'position')

    def to_map(self):
        result = dict()
        if self.position is not None:
            result['position'] = self.position
        return result

    def from_map(self, m=None):
        m = m or dict()
        if m.get('position') is not None:
            self.position = m.get('position')
        return self


class AppendObjectRequestHeader(TeaModel):
    def __init__(self, cache_control=None, content_disposition=None, content_encoding=None, content_md5=None,
                 expires=None, server_side_encryption=None, object_acl=None, storage_class=None, content_type=None):
        # Cache-Control
        self.cache_control = cache_control  # type: str
        # Content-Disposition
        self.content_disposition = content_disposition  # type: str
        # Content-Encoding
        self.content_encoding = content_encoding  # type: str
        # Content-MD5
        self.content_md5 = content_md5  # type: str
        # Expires
        self.expires = expires  # type: str
        # x-oss-server-side-encryption
        self.server_side_encryption = server_side_encryption  # type: str
        # x-oss-object-acl
        self.object_acl = object_acl  # type: str
        # x-oss-storage-class
        self.storage_class = storage_class  # type: str
        # content-type
        self.content_type = content_type  # type: str

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

    def from_map(self, m=None):
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
    def __init__(self, bucket_name=None, object_name=None, user_meta=None, body=None, filter=None, header=None):
        # BucketName
        self.bucket_name = bucket_name  # type: str
        # ObjectName
        self.object_name = object_name  # type: str
        # UserMeta
        self.user_meta = user_meta  # type: dict[str, str]
        # body
        self.body = body  # type: READABLE
        # Filter
        self.filter = filter  # type: AppendObjectRequestFilter
        # Header
        self.header = header  # type: AppendObjectRequestHeader

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

    def from_map(self, m=None):
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
    def __init__(self, request_id=None, next_append_position=None, hash_crc_64ecma=None):
        # x-oss-request-id
        self.request_id = request_id  # type: str
        # x-oss-next-append-position
        self.next_append_position = next_append_position  # type: str
        # x-oss-hash-crc64ecma
        self.hash_crc_64ecma = hash_crc_64ecma  # type: str

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

    def from_map(self, m=None):
        m = m or dict()
        if m.get('x-oss-request-id') is not None:
            self.request_id = m.get('x-oss-request-id')
        if m.get('x-oss-next-append-position') is not None:
            self.next_append_position = m.get('x-oss-next-append-position')
        if m.get('x-oss-hash-crc64ecma') is not None:
            self.hash_crc_64ecma = m.get('x-oss-hash-crc64ecma')
        return self


class UploadPartCopyRequestFilter(TeaModel):
    def __init__(self, part_number=None, upload_id=None):
        # partNumber
        self.part_number = part_number  # type: str
        # uploadId
        self.upload_id = upload_id  # type: str

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

    def from_map(self, m=None):
        m = m or dict()
        if m.get('partNumber') is not None:
            self.part_number = m.get('partNumber')
        if m.get('uploadId') is not None:
            self.upload_id = m.get('uploadId')
        return self


class UploadPartCopyRequestHeader(TeaModel):
    def __init__(self, copy_source=None, copy_source_range=None, copy_source_if_match=None,
                 copy_source_if_none_match=None, copy_source_if_unmodified_since=None, copy_source_if_modified_since=None):
        # x-oss-copy-source
        self.copy_source = copy_source  # type: str
        # x-oss-copy-source-range
        self.copy_source_range = copy_source_range  # type: str
        # x-oss-copy-source-if-match
        self.copy_source_if_match = copy_source_if_match  # type: str
        # x-oss-copy-source-if-none-match
        self.copy_source_if_none_match = copy_source_if_none_match  # type: str
        # x-oss-copy-source-if-unmodified-since
        self.copy_source_if_unmodified_since = copy_source_if_unmodified_since  # type: str
        # x-oss-copy-source-if-modified-since
        self.copy_source_if_modified_since = copy_source_if_modified_since  # type: str

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

    def from_map(self, m=None):
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
    def __init__(self, bucket_name=None, object_name=None, filter=None, header=None):
        # BucketName
        self.bucket_name = bucket_name  # type: str
        # ObjectName
        self.object_name = object_name  # type: str
        # Filter
        self.filter = filter  # type: UploadPartCopyRequestFilter
        # Header
        self.header = header  # type: UploadPartCopyRequestHeader

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

    def from_map(self, m=None):
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
    def __init__(self, last_modified=None, e_tag=None):
        # LastModified
        self.last_modified = last_modified  # type: str
        # ETag
        self.e_tag = e_tag  # type: str

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.last_modified is not None:
            result['LastModified'] = self.last_modified
        if self.e_tag is not None:
            result['ETag'] = self.e_tag
        return result

    def from_map(self, m=None):
        m = m or dict()
        if m.get('LastModified') is not None:
            self.last_modified = m.get('LastModified')
        if m.get('ETag') is not None:
            self.e_tag = m.get('ETag')
        return self


class UploadPartCopyResponse(TeaModel):
    def __init__(self, request_id=None, copy_part_result=None):
        # x-oss-request-id
        self.request_id = request_id  # type: str
        # CopyPartResult
        self.copy_part_result = copy_part_result  # type: UploadPartCopyResponseCopyPartResult

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

    def from_map(self, m=None):
        m = m or dict()
        if m.get('x-oss-request-id') is not None:
            self.request_id = m.get('x-oss-request-id')
        if m.get('CopyPartResult') is not None:
            temp_model = UploadPartCopyResponseCopyPartResult()
            self.copy_part_result = temp_model.from_map(m['CopyPartResult'])
        return self


class GetVodPlaylistRequestFilter(TeaModel):
    def __init__(self, end_time=None, start_time=None):
        # endTime
        self.end_time = end_time  # type: str
        # startTime
        self.start_time = start_time  # type: str

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

    def from_map(self, m=None):
        m = m or dict()
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        return self


class GetVodPlaylistRequest(TeaModel):
    def __init__(self, bucket_name=None, channel_name=None, filter=None):
        # BucketName
        self.bucket_name = bucket_name  # type: str
        # ChannelName
        self.channel_name = channel_name  # type: str
        # Filter
        self.filter = filter  # type: GetVodPlaylistRequestFilter

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

    def from_map(self, m=None):
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
    def __init__(self, request_id=None):
        # x-oss-request-id
        self.request_id = request_id  # type: str

    def validate(self):
        self.validate_required(self.request_id, 'request_id')

    def to_map(self):
        result = dict()
        if self.request_id is not None:
            result['x-oss-request-id'] = self.request_id
        return result

    def from_map(self, m=None):
        m = m or dict()
        if m.get('x-oss-request-id') is not None:
            self.request_id = m.get('x-oss-request-id')
        return self


class DeleteBucketCORSRequest(TeaModel):
    def __init__(self, bucket_name=None):
        # BucketName
        self.bucket_name = bucket_name  # type: str

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')
        if self.bucket_name is not None:
            self.validate_pattern(self.bucket_name, 'bucket_name', '[a-zA-Z0-9-_]+')

    def to_map(self):
        result = dict()
        if self.bucket_name is not None:
            result['BucketName'] = self.bucket_name
        return result

    def from_map(self, m=None):
        m = m or dict()
        if m.get('BucketName') is not None:
            self.bucket_name = m.get('BucketName')
        return self


class DeleteBucketCORSResponse(TeaModel):
    def __init__(self, request_id=None):
        # x-oss-request-id
        self.request_id = request_id  # type: str

    def validate(self):
        self.validate_required(self.request_id, 'request_id')

    def to_map(self):
        result = dict()
        if self.request_id is not None:
            result['x-oss-request-id'] = self.request_id
        return result

    def from_map(self, m=None):
        m = m or dict()
        if m.get('x-oss-request-id') is not None:
            self.request_id = m.get('x-oss-request-id')
        return self


class GetObjectRequestHeader(TeaModel):
    def __init__(self, response_content_type=None, response_content_language=None, response_expires=None,
                 response_cache_control=None, response_content_disposition=None, response_content_encoding=None, range=None,
                 if_modified_since=None, if_unmodified_since=None, if_match=None, if_none_match=None, accept_encoding=None):
        # response-content-type
        self.response_content_type = response_content_type  # type: str
        # response-content-language
        self.response_content_language = response_content_language  # type: str
        # response-expires
        self.response_expires = response_expires  # type: str
        # response-cache-control
        self.response_cache_control = response_cache_control  # type: str
        # response-content-disposition
        self.response_content_disposition = response_content_disposition  # type: str
        # response-content-encoding
        self.response_content_encoding = response_content_encoding  # type: str
        # Range
        self.range = range  # type: str
        # If-Modified-Since
        self.if_modified_since = if_modified_since  # type: str
        # If-Unmodified-Since
        self.if_unmodified_since = if_unmodified_since  # type: str
        # If-Match
        self.if_match = if_match  # type: str
        # If-None-Match
        self.if_none_match = if_none_match  # type: str
        # Accept-Encoding
        self.accept_encoding = accept_encoding  # type: str

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

    def from_map(self, m=None):
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
    def __init__(self, bucket_name=None, object_name=None, header=None):
        # BucketName
        self.bucket_name = bucket_name  # type: str
        # ObjectName
        self.object_name = object_name  # type: str
        # Header
        self.header = header  # type: GetObjectRequestHeader

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

    def from_map(self, m=None):
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
    def __init__(self, request_id=None, object_type=None, server_side_encryption=None, tagging_count=None,
                 restore=None, body=None):
        # x-oss-request-id
        self.request_id = request_id  # type: str
        # x-oss-object-type
        self.object_type = object_type  # type: str
        # x-oss-server-side-encryption
        self.server_side_encryption = server_side_encryption  # type: str
        # x-oss-tagging-count
        self.tagging_count = tagging_count  # type: str
        # x-oss-restore
        self.restore = restore  # type: str
        # body
        self.body = body  # type: READABLE

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

    def from_map(self, m=None):
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
    def __init__(self, part_number=None, upload_id=None):
        # partNumber
        self.part_number = part_number  # type: str
        # uploadId
        self.upload_id = upload_id  # type: str

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

    def from_map(self, m=None):
        m = m or dict()
        if m.get('partNumber') is not None:
            self.part_number = m.get('partNumber')
        if m.get('uploadId') is not None:
            self.upload_id = m.get('uploadId')
        return self


class UploadPartRequest(TeaModel):
    def __init__(self, bucket_name=None, object_name=None, body=None, filter=None):
        # BucketName
        self.bucket_name = bucket_name  # type: str
        # ObjectName
        self.object_name = object_name  # type: str
        # body
        self.body = body  # type: READABLE
        # Filter
        self.filter = filter  # type: UploadPartRequestFilter

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

    def from_map(self, m=None):
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
    def __init__(self, request_id=None):
        # x-oss-request-id
        self.request_id = request_id  # type: str

    def validate(self):
        self.validate_required(self.request_id, 'request_id')

    def to_map(self):
        result = dict()
        if self.request_id is not None:
            result['x-oss-request-id'] = self.request_id
        return result

    def from_map(self, m=None):
        m = m or dict()
        if m.get('x-oss-request-id') is not None:
            self.request_id = m.get('x-oss-request-id')
        return self


class GetBucketCORSRequest(TeaModel):
    def __init__(self, bucket_name=None):
        # BucketName
        self.bucket_name = bucket_name  # type: str

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')
        if self.bucket_name is not None:
            self.validate_pattern(self.bucket_name, 'bucket_name', '[a-zA-Z0-9-_]+')

    def to_map(self):
        result = dict()
        if self.bucket_name is not None:
            result['BucketName'] = self.bucket_name
        return result

    def from_map(self, m=None):
        m = m or dict()
        if m.get('BucketName') is not None:
            self.bucket_name = m.get('BucketName')
        return self


class GetBucketCORSResponseCORSConfigurationCORSRule(TeaModel):
    def __init__(self, max_age_seconds=None):
        # MaxAgeSeconds
        self.max_age_seconds = max_age_seconds  # type: str

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.max_age_seconds is not None:
            result['MaxAgeSeconds'] = self.max_age_seconds
        return result

    def from_map(self, m=None):
        m = m or dict()
        if m.get('MaxAgeSeconds') is not None:
            self.max_age_seconds = m.get('MaxAgeSeconds')
        return self


class GetBucketCORSResponseCORSConfiguration(TeaModel):
    def __init__(self, c_orsrule=None):
        # CORSRule
        self.c_orsrule = c_orsrule  # type: list[GetBucketCORSResponseCORSConfigurationCORSRule]

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

    def from_map(self, m=None):
        m = m or dict()
        self.c_orsrule = []
        if m.get('CORSRule') is not None:
            for k in m.get('CORSRule'):
                temp_model = GetBucketCORSResponseCORSConfigurationCORSRule()
                self.c_orsrule.append(temp_model.from_map(k))
        return self


class GetBucketCORSResponse(TeaModel):
    def __init__(self, request_id=None, c_orsconfiguration=None):
        # x-oss-request-id
        self.request_id = request_id  # type: str
        # CORSConfiguration
        self.c_orsconfiguration = c_orsconfiguration  # type: GetBucketCORSResponseCORSConfiguration

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

    def from_map(self, m=None):
        m = m or dict()
        if m.get('x-oss-request-id') is not None:
            self.request_id = m.get('x-oss-request-id')
        if m.get('CORSConfiguration') is not None:
            temp_model = GetBucketCORSResponseCORSConfiguration()
            self.c_orsconfiguration = temp_model.from_map(m['CORSConfiguration'])
        return self


class CopyObjectRequestHeader(TeaModel):
    def __init__(self, copy_source=None, copy_source_if_match=None, copy_source_if_none_match=None,
                 copy_source_if_unmodified_since=None, copy_source_if_modified_since=None, metadata_directive=None, server_side_encryption=None,
                 server_side_encryption_key_id=None, object_acl=None, storage_class=None, tagging=None, tagging_directive=None):
        # x-oss-copy-source
        self.copy_source = copy_source  # type: str
        # x-oss-copy-source-if-match
        self.copy_source_if_match = copy_source_if_match  # type: str
        # x-oss-copy-source-if-none-match
        self.copy_source_if_none_match = copy_source_if_none_match  # type: str
        # x-oss-copy-source-if-unmodified-since
        self.copy_source_if_unmodified_since = copy_source_if_unmodified_since  # type: str
        # x-oss-copy-source-if-modified-since
        self.copy_source_if_modified_since = copy_source_if_modified_since  # type: str
        # x-oss-metadata-directive
        self.metadata_directive = metadata_directive  # type: str
        # x-oss-server-side-encryption
        self.server_side_encryption = server_side_encryption  # type: str
        # x-oss-server-side-encryption-key-id
        self.server_side_encryption_key_id = server_side_encryption_key_id  # type: str
        # x-oss-object-acl
        self.object_acl = object_acl  # type: str
        # x-oss-storage-class
        self.storage_class = storage_class  # type: str
        # x-oss-tagging
        self.tagging = tagging  # type: str
        # x-oss-tagging-directive
        self.tagging_directive = tagging_directive  # type: str

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

    def from_map(self, m=None):
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
    def __init__(self, bucket_name=None, dest_object_name=None, header=None):
        # BucketName
        self.bucket_name = bucket_name  # type: str
        # DestObjectName
        self.dest_object_name = dest_object_name  # type: str
        # Header
        self.header = header  # type: CopyObjectRequestHeader

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

    def from_map(self, m=None):
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
    def __init__(self, last_modified=None, e_tag=None):
        # LastModified
        self.last_modified = last_modified  # type: str
        # ETag
        self.e_tag = e_tag  # type: str

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.last_modified is not None:
            result['LastModified'] = self.last_modified
        if self.e_tag is not None:
            result['ETag'] = self.e_tag
        return result

    def from_map(self, m=None):
        m = m or dict()
        if m.get('LastModified') is not None:
            self.last_modified = m.get('LastModified')
        if m.get('ETag') is not None:
            self.e_tag = m.get('ETag')
        return self


class CopyObjectResponse(TeaModel):
    def __init__(self, request_id=None, copy_object_result=None):
        # x-oss-request-id
        self.request_id = request_id  # type: str
        # CopyObjectResult
        self.copy_object_result = copy_object_result  # type: CopyObjectResponseCopyObjectResult

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

    def from_map(self, m=None):
        m = m or dict()
        if m.get('x-oss-request-id') is not None:
            self.request_id = m.get('x-oss-request-id')
        if m.get('CopyObjectResult') is not None:
            temp_model = CopyObjectResponseCopyObjectResult()
            self.copy_object_result = temp_model.from_map(m['CopyObjectResult'])
        return self


class GetObjectTaggingRequest(TeaModel):
    def __init__(self, bucket_name=None, object_name=None):
        # BucketName
        self.bucket_name = bucket_name  # type: str
        # ObjectName
        self.object_name = object_name  # type: str

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

    def from_map(self, m=None):
        m = m or dict()
        if m.get('BucketName') is not None:
            self.bucket_name = m.get('BucketName')
        if m.get('ObjectName') is not None:
            self.object_name = m.get('ObjectName')
        return self


class GetObjectTaggingResponseTaggingTagSetTag(TeaModel):
    def __init__(self, key=None, value=None):
        # Key
        self.key = key  # type: str
        # Value
        self.value = value  # type: str

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.key is not None:
            result['Key'] = self.key
        if self.value is not None:
            result['Value'] = self.value
        return result

    def from_map(self, m=None):
        m = m or dict()
        if m.get('Key') is not None:
            self.key = m.get('Key')
        if m.get('Value') is not None:
            self.value = m.get('Value')
        return self


class GetObjectTaggingResponseTaggingTagSet(TeaModel):
    def __init__(self, tag=None):
        # Tag
        self.tag = tag  # type: list[GetObjectTaggingResponseTaggingTagSetTag]

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

    def from_map(self, m=None):
        m = m or dict()
        self.tag = []
        if m.get('Tag') is not None:
            for k in m.get('Tag'):
                temp_model = GetObjectTaggingResponseTaggingTagSetTag()
                self.tag.append(temp_model.from_map(k))
        return self


class GetObjectTaggingResponseTagging(TeaModel):
    def __init__(self, tag_set=None):
        # TagSet
        self.tag_set = tag_set  # type: GetObjectTaggingResponseTaggingTagSet

    def validate(self):
        self.validate_required(self.tag_set, 'tag_set')
        if self.tag_set:
            self.tag_set.validate()

    def to_map(self):
        result = dict()
        if self.tag_set is not None:
            result['TagSet'] = self.tag_set.to_map()
        return result

    def from_map(self, m=None):
        m = m or dict()
        if m.get('TagSet') is not None:
            temp_model = GetObjectTaggingResponseTaggingTagSet()
            self.tag_set = temp_model.from_map(m['TagSet'])
        return self


class GetObjectTaggingResponse(TeaModel):
    def __init__(self, request_id=None, tagging=None):
        # x-oss-request-id
        self.request_id = request_id  # type: str
        # Tagging
        self.tagging = tagging  # type: GetObjectTaggingResponseTagging

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

    def from_map(self, m=None):
        m = m or dict()
        if m.get('x-oss-request-id') is not None:
            self.request_id = m.get('x-oss-request-id')
        if m.get('Tagging') is not None:
            temp_model = GetObjectTaggingResponseTagging()
            self.tagging = temp_model.from_map(m['Tagging'])
        return self


class DeleteBucketLifecycleRequest(TeaModel):
    def __init__(self, bucket_name=None):
        # BucketName
        self.bucket_name = bucket_name  # type: str

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')
        if self.bucket_name is not None:
            self.validate_pattern(self.bucket_name, 'bucket_name', '[a-zA-Z0-9-_]+')

    def to_map(self):
        result = dict()
        if self.bucket_name is not None:
            result['BucketName'] = self.bucket_name
        return result

    def from_map(self, m=None):
        m = m or dict()
        if m.get('BucketName') is not None:
            self.bucket_name = m.get('BucketName')
        return self


class DeleteBucketLifecycleResponse(TeaModel):
    def __init__(self, request_id=None):
        # x-oss-request-id
        self.request_id = request_id  # type: str

    def validate(self):
        self.validate_required(self.request_id, 'request_id')

    def to_map(self):
        result = dict()
        if self.request_id is not None:
            result['x-oss-request-id'] = self.request_id
        return result

    def from_map(self, m=None):
        m = m or dict()
        if m.get('x-oss-request-id') is not None:
            self.request_id = m.get('x-oss-request-id')
        return self


class DeleteBucketLoggingRequest(TeaModel):
    def __init__(self, bucket_name=None):
        # BucketName
        self.bucket_name = bucket_name  # type: str

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')
        if self.bucket_name is not None:
            self.validate_pattern(self.bucket_name, 'bucket_name', '[a-zA-Z0-9-_]+')

    def to_map(self):
        result = dict()
        if self.bucket_name is not None:
            result['BucketName'] = self.bucket_name
        return result

    def from_map(self, m=None):
        m = m or dict()
        if m.get('BucketName') is not None:
            self.bucket_name = m.get('BucketName')
        return self


class DeleteBucketLoggingResponse(TeaModel):
    def __init__(self, request_id=None):
        # x-oss-request-id
        self.request_id = request_id  # type: str

    def validate(self):
        self.validate_required(self.request_id, 'request_id')

    def to_map(self):
        result = dict()
        if self.request_id is not None:
            result['x-oss-request-id'] = self.request_id
        return result

    def from_map(self, m=None):
        m = m or dict()
        if m.get('x-oss-request-id') is not None:
            self.request_id = m.get('x-oss-request-id')
        return self


class DeleteBucketWebsiteRequest(TeaModel):
    def __init__(self, bucket_name=None):
        # BucketName
        self.bucket_name = bucket_name  # type: str

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')
        if self.bucket_name is not None:
            self.validate_pattern(self.bucket_name, 'bucket_name', '[a-zA-Z0-9-_]+')

    def to_map(self):
        result = dict()
        if self.bucket_name is not None:
            result['BucketName'] = self.bucket_name
        return result

    def from_map(self, m=None):
        m = m or dict()
        if m.get('BucketName') is not None:
            self.bucket_name = m.get('BucketName')
        return self


class DeleteBucketWebsiteResponse(TeaModel):
    def __init__(self, request_id=None):
        # x-oss-request-id
        self.request_id = request_id  # type: str

    def validate(self):
        self.validate_required(self.request_id, 'request_id')

    def to_map(self):
        result = dict()
        if self.request_id is not None:
            result['x-oss-request-id'] = self.request_id
        return result

    def from_map(self, m=None):
        m = m or dict()
        if m.get('x-oss-request-id') is not None:
            self.request_id = m.get('x-oss-request-id')
        return self


class GetSymlinkRequest(TeaModel):
    def __init__(self, bucket_name=None, object_name=None):
        # BucketName
        self.bucket_name = bucket_name  # type: str
        # ObjectName
        self.object_name = object_name  # type: str

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

    def from_map(self, m=None):
        m = m or dict()
        if m.get('BucketName') is not None:
            self.bucket_name = m.get('BucketName')
        if m.get('ObjectName') is not None:
            self.object_name = m.get('ObjectName')
        return self


class GetSymlinkResponse(TeaModel):
    def __init__(self, request_id=None, symlink_target=None):
        # x-oss-request-id
        self.request_id = request_id  # type: str
        # x-oss-symlink-target
        self.symlink_target = symlink_target  # type: str

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

    def from_map(self, m=None):
        m = m or dict()
        if m.get('x-oss-request-id') is not None:
            self.request_id = m.get('x-oss-request-id')
        if m.get('x-oss-symlink-target') is not None:
            self.symlink_target = m.get('x-oss-symlink-target')
        return self


class GetBucketLifecycleRequest(TeaModel):
    def __init__(self, bucket_name=None):
        # BucketName
        self.bucket_name = bucket_name  # type: str

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')
        if self.bucket_name is not None:
            self.validate_pattern(self.bucket_name, 'bucket_name', '[a-zA-Z0-9-_]+')

    def to_map(self):
        result = dict()
        if self.bucket_name is not None:
            result['BucketName'] = self.bucket_name
        return result

    def from_map(self, m=None):
        m = m or dict()
        if m.get('BucketName') is not None:
            self.bucket_name = m.get('BucketName')
        return self


class GetBucketLifecycleResponseLifecycleConfigurationRuleExpiration(TeaModel):
    def __init__(self, days=None, created_before_date=None):
        # Days
        self.days = days  # type: int
        # CreatedBeforeDate
        self.created_before_date = created_before_date  # type: str

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.days is not None:
            result['Days'] = self.days
        if self.created_before_date is not None:
            result['CreatedBeforeDate'] = self.created_before_date
        return result

    def from_map(self, m=None):
        m = m or dict()
        if m.get('Days') is not None:
            self.days = m.get('Days')
        if m.get('CreatedBeforeDate') is not None:
            self.created_before_date = m.get('CreatedBeforeDate')
        return self


class GetBucketLifecycleResponseLifecycleConfigurationRuleTransition(TeaModel):
    def __init__(self, days=None, storage_class=None):
        # Days
        self.days = days  # type: int
        # StorageClass
        self.storage_class = storage_class  # type: str

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.days is not None:
            result['Days'] = self.days
        if self.storage_class is not None:
            result['StorageClass'] = self.storage_class
        return result

    def from_map(self, m=None):
        m = m or dict()
        if m.get('Days') is not None:
            self.days = m.get('Days')
        if m.get('StorageClass') is not None:
            self.storage_class = m.get('StorageClass')
        return self


class GetBucketLifecycleResponseLifecycleConfigurationRuleAbortMultipartUpload(TeaModel):
    def __init__(self, days=None, created_before_date=None):
        # Days
        self.days = days  # type: int
        # CreatedBeforeDate
        self.created_before_date = created_before_date  # type: str

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.days is not None:
            result['Days'] = self.days
        if self.created_before_date is not None:
            result['CreatedBeforeDate'] = self.created_before_date
        return result

    def from_map(self, m=None):
        m = m or dict()
        if m.get('Days') is not None:
            self.days = m.get('Days')
        if m.get('CreatedBeforeDate') is not None:
            self.created_before_date = m.get('CreatedBeforeDate')
        return self


class GetBucketLifecycleResponseLifecycleConfigurationRuleTag(TeaModel):
    def __init__(self, key=None, value=None):
        # Key
        self.key = key  # type: str
        # Value
        self.value = value  # type: str

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.key is not None:
            result['Key'] = self.key
        if self.value is not None:
            result['Value'] = self.value
        return result

    def from_map(self, m=None):
        m = m or dict()
        if m.get('Key') is not None:
            self.key = m.get('Key')
        if m.get('Value') is not None:
            self.value = m.get('Value')
        return self


class GetBucketLifecycleResponseLifecycleConfigurationRule(TeaModel):
    def __init__(self, i_d=None, prefix=None, status=None, expiration=None, transition=None,
                 abort_multipart_upload=None, tag=None):
        # ID
        self.i_d = i_d  # type: str
        # Prefix
        self.prefix = prefix  # type: str
        # Status
        self.status = status  # type: str
        # Expiration
        self.expiration = expiration  # type: GetBucketLifecycleResponseLifecycleConfigurationRuleExpiration
        # Transition
        self.transition = transition  # type: GetBucketLifecycleResponseLifecycleConfigurationRuleTransition
        # AbortMultipartUpload
        self.abort_multipart_upload = abort_multipart_upload  # type: GetBucketLifecycleResponseLifecycleConfigurationRuleAbortMultipartUpload
        # Tag
        self.tag = tag  # type: GetBucketLifecycleResponseLifecycleConfigurationRuleTag

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

    def from_map(self, m=None):
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
    def __init__(self, rule=None):
        # Rule
        self.rule = rule  # type: list[GetBucketLifecycleResponseLifecycleConfigurationRule]

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

    def from_map(self, m=None):
        m = m or dict()
        self.rule = []
        if m.get('Rule') is not None:
            for k in m.get('Rule'):
                temp_model = GetBucketLifecycleResponseLifecycleConfigurationRule()
                self.rule.append(temp_model.from_map(k))
        return self


class GetBucketLifecycleResponse(TeaModel):
    def __init__(self, request_id=None, lifecycle_configuration=None):
        # x-oss-request-id
        self.request_id = request_id  # type: str
        # LifecycleConfiguration
        self.lifecycle_configuration = lifecycle_configuration  # type: GetBucketLifecycleResponseLifecycleConfiguration

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

    def from_map(self, m=None):
        m = m or dict()
        if m.get('x-oss-request-id') is not None:
            self.request_id = m.get('x-oss-request-id')
        if m.get('LifecycleConfiguration') is not None:
            temp_model = GetBucketLifecycleResponseLifecycleConfiguration()
            self.lifecycle_configuration = temp_model.from_map(m['LifecycleConfiguration'])
        return self


class PutSymlinkRequestHeader(TeaModel):
    def __init__(self, symlink_target=None, storage_class=None):
        # x-oss-symlink-target
        self.symlink_target = symlink_target  # type: str
        # x-oss-storage-class
        self.storage_class = storage_class  # type: str

    def validate(self):
        self.validate_required(self.symlink_target, 'symlink_target')

    def to_map(self):
        result = dict()
        if self.symlink_target is not None:
            result['x-oss-symlink-target'] = self.symlink_target
        if self.storage_class is not None:
            result['x-oss-storage-class'] = self.storage_class
        return result

    def from_map(self, m=None):
        m = m or dict()
        if m.get('x-oss-symlink-target') is not None:
            self.symlink_target = m.get('x-oss-symlink-target')
        if m.get('x-oss-storage-class') is not None:
            self.storage_class = m.get('x-oss-storage-class')
        return self


class PutSymlinkRequest(TeaModel):
    def __init__(self, bucket_name=None, object_name=None, header=None):
        # BucketName
        self.bucket_name = bucket_name  # type: str
        # ObjectName
        self.object_name = object_name  # type: str
        # Header
        self.header = header  # type: PutSymlinkRequestHeader

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

    def from_map(self, m=None):
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
    def __init__(self, request_id=None):
        # x-oss-request-id
        self.request_id = request_id  # type: str

    def validate(self):
        self.validate_required(self.request_id, 'request_id')

    def to_map(self):
        result = dict()
        if self.request_id is not None:
            result['x-oss-request-id'] = self.request_id
        return result

    def from_map(self, m=None):
        m = m or dict()
        if m.get('x-oss-request-id') is not None:
            self.request_id = m.get('x-oss-request-id')
        return self


class GetBucketRefererRequest(TeaModel):
    def __init__(self, bucket_name=None):
        # BucketName
        self.bucket_name = bucket_name  # type: str

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')
        if self.bucket_name is not None:
            self.validate_pattern(self.bucket_name, 'bucket_name', '[a-zA-Z0-9-_]+')

    def to_map(self):
        result = dict()
        if self.bucket_name is not None:
            result['BucketName'] = self.bucket_name
        return result

    def from_map(self, m=None):
        m = m or dict()
        if m.get('BucketName') is not None:
            self.bucket_name = m.get('BucketName')
        return self


class GetBucketRefererResponseRefererConfigurationRefererList(TeaModel):
    def __init__(self, referer=None):
        # Referer
        self.referer = referer  # type: list[str]

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.referer is not None:
            result['Referer'] = self.referer
        return result

    def from_map(self, m=None):
        m = m or dict()
        if m.get('Referer') is not None:
            self.referer = m.get('Referer')
        return self


class GetBucketRefererResponseRefererConfiguration(TeaModel):
    def __init__(self, allow_empty_referer=None, referer_list=None):
        # AllowEmptyReferer
        self.allow_empty_referer = allow_empty_referer  # type: bool
        # RefererList
        self.referer_list = referer_list  # type: GetBucketRefererResponseRefererConfigurationRefererList

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

    def from_map(self, m=None):
        m = m or dict()
        if m.get('AllowEmptyReferer') is not None:
            self.allow_empty_referer = m.get('AllowEmptyReferer')
        if m.get('RefererList') is not None:
            temp_model = GetBucketRefererResponseRefererConfigurationRefererList()
            self.referer_list = temp_model.from_map(m['RefererList'])
        return self


class GetBucketRefererResponse(TeaModel):
    def __init__(self, request_id=None, referer_configuration=None):
        # x-oss-request-id
        self.request_id = request_id  # type: str
        # RefererConfiguration
        self.referer_configuration = referer_configuration  # type: GetBucketRefererResponseRefererConfiguration

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

    def from_map(self, m=None):
        m = m or dict()
        if m.get('x-oss-request-id') is not None:
            self.request_id = m.get('x-oss-request-id')
        if m.get('RefererConfiguration') is not None:
            temp_model = GetBucketRefererResponseRefererConfiguration()
            self.referer_configuration = temp_model.from_map(m['RefererConfiguration'])
        return self


class CallbackRequest(TeaModel):
    def __init__(self, bucket_name=None):
        # BucketName
        self.bucket_name = bucket_name  # type: str

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')
        if self.bucket_name is not None:
            self.validate_pattern(self.bucket_name, 'bucket_name', '[a-zA-Z0-9-_]+')

    def to_map(self):
        result = dict()
        if self.bucket_name is not None:
            result['BucketName'] = self.bucket_name
        return result

    def from_map(self, m=None):
        m = m or dict()
        if m.get('BucketName') is not None:
            self.bucket_name = m.get('BucketName')
        return self


class CallbackResponse(TeaModel):
    def __init__(self, request_id=None):
        # x-oss-request-id
        self.request_id = request_id  # type: str

    def validate(self):
        self.validate_required(self.request_id, 'request_id')

    def to_map(self):
        result = dict()
        if self.request_id is not None:
            result['x-oss-request-id'] = self.request_id
        return result

    def from_map(self, m=None):
        m = m or dict()
        if m.get('x-oss-request-id') is not None:
            self.request_id = m.get('x-oss-request-id')
        return self


class GetBucketLoggingRequest(TeaModel):
    def __init__(self, bucket_name=None):
        # BucketName
        self.bucket_name = bucket_name  # type: str

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')
        if self.bucket_name is not None:
            self.validate_pattern(self.bucket_name, 'bucket_name', '[a-zA-Z0-9-_]+')

    def to_map(self):
        result = dict()
        if self.bucket_name is not None:
            result['BucketName'] = self.bucket_name
        return result

    def from_map(self, m=None):
        m = m or dict()
        if m.get('BucketName') is not None:
            self.bucket_name = m.get('BucketName')
        return self


class GetBucketLoggingResponseBucketLoggingStatusLoggingEnabled(TeaModel):
    def __init__(self, target_bucket=None, target_prefix=None):
        # TargetBucket
        self.target_bucket = target_bucket  # type: str
        # TargetPrefix
        self.target_prefix = target_prefix  # type: str

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.target_bucket is not None:
            result['TargetBucket'] = self.target_bucket
        if self.target_prefix is not None:
            result['TargetPrefix'] = self.target_prefix
        return result

    def from_map(self, m=None):
        m = m or dict()
        if m.get('TargetBucket') is not None:
            self.target_bucket = m.get('TargetBucket')
        if m.get('TargetPrefix') is not None:
            self.target_prefix = m.get('TargetPrefix')
        return self


class GetBucketLoggingResponseBucketLoggingStatus(TeaModel):
    def __init__(self, logging_enabled=None):
        # LoggingEnabled
        self.logging_enabled = logging_enabled  # type: GetBucketLoggingResponseBucketLoggingStatusLoggingEnabled

    def validate(self):
        self.validate_required(self.logging_enabled, 'logging_enabled')
        if self.logging_enabled:
            self.logging_enabled.validate()

    def to_map(self):
        result = dict()
        if self.logging_enabled is not None:
            result['LoggingEnabled'] = self.logging_enabled.to_map()
        return result

    def from_map(self, m=None):
        m = m or dict()
        if m.get('LoggingEnabled') is not None:
            temp_model = GetBucketLoggingResponseBucketLoggingStatusLoggingEnabled()
            self.logging_enabled = temp_model.from_map(m['LoggingEnabled'])
        return self


class GetBucketLoggingResponse(TeaModel):
    def __init__(self, request_id=None, bucket_logging_status=None):
        # x-oss-request-id
        self.request_id = request_id  # type: str
        # BucketLoggingStatus
        self.bucket_logging_status = bucket_logging_status  # type: GetBucketLoggingResponseBucketLoggingStatus

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

    def from_map(self, m=None):
        m = m or dict()
        if m.get('x-oss-request-id') is not None:
            self.request_id = m.get('x-oss-request-id')
        if m.get('BucketLoggingStatus') is not None:
            temp_model = GetBucketLoggingResponseBucketLoggingStatus()
            self.bucket_logging_status = temp_model.from_map(m['BucketLoggingStatus'])
        return self


class PutObjectAclRequestHeader(TeaModel):
    def __init__(self, object_acl=None):
        # x-oss-object-acl
        self.object_acl = object_acl  # type: str

    def validate(self):
        self.validate_required(self.object_acl, 'object_acl')

    def to_map(self):
        result = dict()
        if self.object_acl is not None:
            result['x-oss-object-acl'] = self.object_acl
        return result

    def from_map(self, m=None):
        m = m or dict()
        if m.get('x-oss-object-acl') is not None:
            self.object_acl = m.get('x-oss-object-acl')
        return self


class PutObjectAclRequest(TeaModel):
    def __init__(self, bucket_name=None, object_name=None, header=None):
        # BucketName
        self.bucket_name = bucket_name  # type: str
        # ObjectName
        self.object_name = object_name  # type: str
        # Header
        self.header = header  # type: PutObjectAclRequestHeader

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

    def from_map(self, m=None):
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
    def __init__(self, request_id=None):
        # x-oss-request-id
        self.request_id = request_id  # type: str

    def validate(self):
        self.validate_required(self.request_id, 'request_id')

    def to_map(self):
        result = dict()
        if self.request_id is not None:
            result['x-oss-request-id'] = self.request_id
        return result

    def from_map(self, m=None):
        m = m or dict()
        if m.get('x-oss-request-id') is not None:
            self.request_id = m.get('x-oss-request-id')
        return self


class GetBucketInfoRequest(TeaModel):
    def __init__(self, bucket_name=None):
        # BucketName
        self.bucket_name = bucket_name  # type: str

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')
        if self.bucket_name is not None:
            self.validate_pattern(self.bucket_name, 'bucket_name', '[a-zA-Z0-9-_]+')

    def to_map(self):
        result = dict()
        if self.bucket_name is not None:
            result['BucketName'] = self.bucket_name
        return result

    def from_map(self, m=None):
        m = m or dict()
        if m.get('BucketName') is not None:
            self.bucket_name = m.get('BucketName')
        return self


class GetBucketInfoResponseBucketInfoBucketOwner(TeaModel):
    def __init__(self, i_d=None, display_name=None):
        # ID
        self.i_d = i_d  # type: str
        # DisplayName
        self.display_name = display_name  # type: str

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.i_d is not None:
            result['ID'] = self.i_d
        if self.display_name is not None:
            result['DisplayName'] = self.display_name
        return result

    def from_map(self, m=None):
        m = m or dict()
        if m.get('ID') is not None:
            self.i_d = m.get('ID')
        if m.get('DisplayName') is not None:
            self.display_name = m.get('DisplayName')
        return self


class GetBucketInfoResponseBucketInfoBucketAccessControlList(TeaModel):
    def __init__(self, grant=None):
        # Grant
        self.grant = grant  # type: str

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.grant is not None:
            result['Grant'] = self.grant
        return result

    def from_map(self, m=None):
        m = m or dict()
        if m.get('Grant') is not None:
            self.grant = m.get('Grant')
        return self


class GetBucketInfoResponseBucketInfoBucket(TeaModel):
    def __init__(self, creation_date=None, extranet_endpoint=None, intranet_endpoint=None, location=None, name=None,
                 data_redundancy_type=None, storage_class=None, comment=None, owner=None, access_control_list=None):
        # CreationDate
        self.creation_date = creation_date  # type: str
        # ExtranetEndpoint
        self.extranet_endpoint = extranet_endpoint  # type: str
        # IntranetEndpoint
        self.intranet_endpoint = intranet_endpoint  # type: str
        # Location
        self.location = location  # type: str
        # Name
        self.name = name  # type: str
        # DataRedundancyType
        self.data_redundancy_type = data_redundancy_type  # type: str
        # StorageClass
        self.storage_class = storage_class  # type: str
        # Comment
        self.comment = comment  # type: str
        # Owner
        self.owner = owner  # type: GetBucketInfoResponseBucketInfoBucketOwner
        # AccessControlList
        self.access_control_list = access_control_list  # type: GetBucketInfoResponseBucketInfoBucketAccessControlList

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

    def from_map(self, m=None):
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
    def __init__(self, bucket=None):
        # Bucket
        self.bucket = bucket  # type: GetBucketInfoResponseBucketInfoBucket

    def validate(self):
        self.validate_required(self.bucket, 'bucket')
        if self.bucket:
            self.bucket.validate()

    def to_map(self):
        result = dict()
        if self.bucket is not None:
            result['Bucket'] = self.bucket.to_map()
        return result

    def from_map(self, m=None):
        m = m or dict()
        if m.get('Bucket') is not None:
            temp_model = GetBucketInfoResponseBucketInfoBucket()
            self.bucket = temp_model.from_map(m['Bucket'])
        return self


class GetBucketInfoResponse(TeaModel):
    def __init__(self, request_id=None, bucket_info=None):
        # x-oss-request-id
        self.request_id = request_id  # type: str
        # BucketInfo
        self.bucket_info = bucket_info  # type: GetBucketInfoResponseBucketInfo

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

    def from_map(self, m=None):
        m = m or dict()
        if m.get('x-oss-request-id') is not None:
            self.request_id = m.get('x-oss-request-id')
        if m.get('BucketInfo') is not None:
            temp_model = GetBucketInfoResponseBucketInfo()
            self.bucket_info = temp_model.from_map(m['BucketInfo'])
        return self


class PutLiveChannelStatusRequestFilter(TeaModel):
    def __init__(self, status=None):
        # status
        self.status = status  # type: str

    def validate(self):
        self.validate_required(self.status, 'status')

    def to_map(self):
        result = dict()
        if self.status is not None:
            result['status'] = self.status
        return result

    def from_map(self, m=None):
        m = m or dict()
        if m.get('status') is not None:
            self.status = m.get('status')
        return self


class PutLiveChannelStatusRequest(TeaModel):
    def __init__(self, bucket_name=None, channel_name=None, filter=None):
        # BucketName
        self.bucket_name = bucket_name  # type: str
        # ChannelName
        self.channel_name = channel_name  # type: str
        # Filter
        self.filter = filter  # type: PutLiveChannelStatusRequestFilter

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

    def from_map(self, m=None):
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
    def __init__(self, request_id=None):
        # x-oss-request-id
        self.request_id = request_id  # type: str

    def validate(self):
        self.validate_required(self.request_id, 'request_id')

    def to_map(self):
        result = dict()
        if self.request_id is not None:
            result['x-oss-request-id'] = self.request_id
        return result

    def from_map(self, m=None):
        m = m or dict()
        if m.get('x-oss-request-id') is not None:
            self.request_id = m.get('x-oss-request-id')
        return self


class InitiateMultipartUploadRequestFilter(TeaModel):
    def __init__(self, encoding_type=None):
        # encoding-type
        self.encoding_type = encoding_type  # type: str

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.encoding_type is not None:
            result['encoding-type'] = self.encoding_type
        return result

    def from_map(self, m=None):
        m = m or dict()
        if m.get('encoding-type') is not None:
            self.encoding_type = m.get('encoding-type')
        return self


class InitiateMultipartUploadRequestHeader(TeaModel):
    def __init__(self, cache_control=None, content_disposition=None, content_encoding=None, expires=None,
                 server_side_encryption=None, server_side_encryption_key_id=None, storage_class=None, tagging=None, content_type=None):
        # Cache-Control
        self.cache_control = cache_control  # type: str
        # Content-Disposition
        self.content_disposition = content_disposition  # type: str
        # Content-Encoding
        self.content_encoding = content_encoding  # type: str
        # Expires
        self.expires = expires  # type: str
        # x-oss-server-side-encryption
        self.server_side_encryption = server_side_encryption  # type: str
        # x-oss-server-side-encryption-key-id
        self.server_side_encryption_key_id = server_side_encryption_key_id  # type: str
        # x-oss-storage-class
        self.storage_class = storage_class  # type: str
        # x-oss-tagging
        self.tagging = tagging  # type: str
        # content-type
        self.content_type = content_type  # type: str

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

    def from_map(self, m=None):
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
    def __init__(self, bucket_name=None, object_name=None, filter=None, header=None):
        # BucketName
        self.bucket_name = bucket_name  # type: str
        # ObjectName
        self.object_name = object_name  # type: str
        # Filter
        self.filter = filter  # type: InitiateMultipartUploadRequestFilter
        # Header
        self.header = header  # type: InitiateMultipartUploadRequestHeader

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

    def from_map(self, m=None):
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
    def __init__(self, bucket=None, key=None, upload_id=None):
        # Bucket
        self.bucket = bucket  # type: str
        # Key
        self.key = key  # type: str
        # UploadId
        self.upload_id = upload_id  # type: str

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

    def from_map(self, m=None):
        m = m or dict()
        if m.get('Bucket') is not None:
            self.bucket = m.get('Bucket')
        if m.get('Key') is not None:
            self.key = m.get('Key')
        if m.get('UploadId') is not None:
            self.upload_id = m.get('UploadId')
        return self


class InitiateMultipartUploadResponse(TeaModel):
    def __init__(self, request_id=None, initiate_multipart_upload_result=None):
        # x-oss-request-id
        self.request_id = request_id  # type: str
        # InitiateMultipartUploadResult
        self.initiate_multipart_upload_result = initiate_multipart_upload_result  # type: InitiateMultipartUploadResponseInitiateMultipartUploadResult

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

    def from_map(self, m=None):
        m = m or dict()
        if m.get('x-oss-request-id') is not None:
            self.request_id = m.get('x-oss-request-id')
        if m.get('InitiateMultipartUploadResult') is not None:
            temp_model = InitiateMultipartUploadResponseInitiateMultipartUploadResult()
            self.initiate_multipart_upload_result = temp_model.from_map(m['InitiateMultipartUploadResult'])
        return self


class OptionObjectRequestHeader(TeaModel):
    def __init__(self, origin=None, access_control_request_method=None, access_control_request_headers=None):
        # Origin
        self.origin = origin  # type: str
        # Access-Control-Request-Method
        self.access_control_request_method = access_control_request_method  # type: str
        # Access-Control-Request-Headers
        self.access_control_request_headers = access_control_request_headers  # type: str

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

    def from_map(self, m=None):
        m = m or dict()
        if m.get('Origin') is not None:
            self.origin = m.get('Origin')
        if m.get('Access-Control-Request-Method') is not None:
            self.access_control_request_method = m.get('Access-Control-Request-Method')
        if m.get('Access-Control-Request-Headers') is not None:
            self.access_control_request_headers = m.get('Access-Control-Request-Headers')
        return self


class OptionObjectRequest(TeaModel):
    def __init__(self, bucket_name=None, object_name=None, header=None):
        # BucketName
        self.bucket_name = bucket_name  # type: str
        # ObjectName
        self.object_name = object_name  # type: str
        # Header
        self.header = header  # type: OptionObjectRequestHeader

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

    def from_map(self, m=None):
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
    def __init__(self, request_id=None, access_control_allow_origin=None, access_control_allow_methods=None,
                 access_control_allow_headers=None, access_control_expose_headers=None, access_control_max_age=None):
        # x-oss-request-id
        self.request_id = request_id  # type: str
        # Access-Control-Allow-Origin
        self.access_control_allow_origin = access_control_allow_origin  # type: str
        # Access-Control-Allow-Methods
        self.access_control_allow_methods = access_control_allow_methods  # type: str
        # Access-Control-Allow-Headers
        self.access_control_allow_headers = access_control_allow_headers  # type: str
        # Access-Control-Expose-Headers
        self.access_control_expose_headers = access_control_expose_headers  # type: str
        # Access-Control-Max-Age
        self.access_control_max_age = access_control_max_age  # type: str

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

    def from_map(self, m=None):
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
    def __init__(self, end_time=None, start_time=None):
        # endTime
        self.end_time = end_time  # type: str
        # startTime
        self.start_time = start_time  # type: str

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

    def from_map(self, m=None):
        m = m or dict()
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        return self


class PostVodPlaylistRequest(TeaModel):
    def __init__(self, bucket_name=None, channel_name=None, playlist_name=None, filter=None):
        # BucketName
        self.bucket_name = bucket_name  # type: str
        # ChannelName
        self.channel_name = channel_name  # type: str
        # PlaylistName
        self.playlist_name = playlist_name  # type: str
        # Filter
        self.filter = filter  # type: PostVodPlaylistRequestFilter

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

    def from_map(self, m=None):
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
    def __init__(self, request_id=None):
        # x-oss-request-id
        self.request_id = request_id  # type: str

    def validate(self):
        self.validate_required(self.request_id, 'request_id')

    def to_map(self):
        result = dict()
        if self.request_id is not None:
            result['x-oss-request-id'] = self.request_id
        return result

    def from_map(self, m=None):
        m = m or dict()
        if m.get('x-oss-request-id') is not None:
            self.request_id = m.get('x-oss-request-id')
        return self


class PostObjectRequestHeader(TeaModel):
    def __init__(self, access_key_id=None, policy=None, signature=None, success_action_status=None, file=None,
                 key=None, user_meta=None):
        # OSSAccessKeyId
        self.access_key_id = access_key_id  # type: str
        # policy
        self.policy = policy  # type: str
        # Signature
        self.signature = signature  # type: str
        # success_action_status
        self.success_action_status = success_action_status  # type: str
        self.file = file  # type: file_form_models.FileField
        # key
        self.key = key  # type: str
        # UserMeta
        self.user_meta = user_meta  # type: dict[str, str]

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

    def from_map(self, m=None):
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
    def __init__(self, bucket_name=None, header=None):
        # BucketName
        self.bucket_name = bucket_name  # type: str
        # header
        self.header = header  # type: PostObjectRequestHeader

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

    def from_map(self, m=None):
        m = m or dict()
        if m.get('BucketName') is not None:
            self.bucket_name = m.get('BucketName')
        if m.get('header') is not None:
            temp_model = PostObjectRequestHeader()
            self.header = temp_model.from_map(m['header'])
        return self


class PostObjectResponsePostResponse(TeaModel):
    def __init__(self, bucket=None, e_tag=None, location=None):
        # Bucket
        self.bucket = bucket  # type: str
        # ETag
        self.e_tag = e_tag  # type: str
        # Location
        self.location = location  # type: str

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

    def from_map(self, m=None):
        m = m or dict()
        if m.get('Bucket') is not None:
            self.bucket = m.get('Bucket')
        if m.get('ETag') is not None:
            self.e_tag = m.get('ETag')
        if m.get('Location') is not None:
            self.location = m.get('Location')
        return self


class PostObjectResponse(TeaModel):
    def __init__(self, post_response=None):
        # PostResponse
        self.post_response = post_response  # type: PostObjectResponsePostResponse

    def validate(self):
        self.validate_required(self.post_response, 'post_response')
        if self.post_response:
            self.post_response.validate()

    def to_map(self):
        result = dict()
        if self.post_response is not None:
            result['PostResponse'] = self.post_response.to_map()
        return result

    def from_map(self, m=None):
        m = m or dict()
        if m.get('PostResponse') is not None:
            temp_model = PostObjectResponsePostResponse()
            self.post_response = temp_model.from_map(m['PostResponse'])
        return self


class HeadObjectRequestHeader(TeaModel):
    def __init__(self, if_modified_since=None, if_unmodified_since=None, if_match=None, if_none_match=None):
        # If-Modified-Since
        self.if_modified_since = if_modified_since  # type: str
        # If-Unmodified-Since
        self.if_unmodified_since = if_unmodified_since  # type: str
        # If-Match
        self.if_match = if_match  # type: str
        # If-None-Match
        self.if_none_match = if_none_match  # type: str

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

    def from_map(self, m=None):
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
    def __init__(self, bucket_name=None, object_name=None, header=None):
        # BucketName
        self.bucket_name = bucket_name  # type: str
        # ObjectName
        self.object_name = object_name  # type: str
        # Header
        self.header = header  # type: HeadObjectRequestHeader

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

    def from_map(self, m=None):
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
    def __init__(self, request_id=None, user_meta=None, server_side_encryption=None,
                 server_side_encryption_key_id=None, storage_class=None, object_type=None, next_append_position=None, hash_crc_64ecma=None,
                 expiration=None, restore=None, process_status=None, request_charged=None, content_md_5=None,
                 last_modified=None, access_control_allow_origin=None, access_control_allow_methods=None,
                 access_control_max_age=None, access_control_allow_headers=None, access_control_expose_headers=None, tagging_count=None):
        # x-oss-request-id
        self.request_id = request_id  # type: str
        # usermeta
        self.user_meta = user_meta  # type: dict[str, str]
        # x-oss-server-side-encryption
        self.server_side_encryption = server_side_encryption  # type: str
        # x-oss-server-side-encryption-key-id
        self.server_side_encryption_key_id = server_side_encryption_key_id  # type: str
        # x-oss-storage-class
        self.storage_class = storage_class  # type: str
        # x-oss-object-type
        self.object_type = object_type  # type: str
        # x-oss-next-append-position
        self.next_append_position = next_append_position  # type: str
        # x-oss-hash-crc64ecma
        self.hash_crc_64ecma = hash_crc_64ecma  # type: str
        # x-oss-expiration
        self.expiration = expiration  # type: str
        # x-oss-restore
        self.restore = restore  # type: str
        # x-oss-process-status
        self.process_status = process_status  # type: str
        # x-oss-request-charged
        self.request_charged = request_charged  # type: str
        # Content-Md5
        self.content_md_5 = content_md_5  # type: str
        # Last-Modified
        self.last_modified = last_modified  # type: str
        # Access-Control-Allow-Origin
        self.access_control_allow_origin = access_control_allow_origin  # type: str
        # Access-Control-Allow-Methods
        self.access_control_allow_methods = access_control_allow_methods  # type: str
        # Access-Control-Max-Age
        self.access_control_max_age = access_control_max_age  # type: str
        # Access-Control-Allow-Headers
        self.access_control_allow_headers = access_control_allow_headers  # type: str
        # Access-Control-Expose-Headers
        self.access_control_expose_headers = access_control_expose_headers  # type: str
        # x-oss-tagging-count
        self.tagging_count = tagging_count  # type: str

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

    def from_map(self, m=None):
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
    def __init__(self, bucket_name=None, object_name=None):
        # BucketName
        self.bucket_name = bucket_name  # type: str
        # ObjectName
        self.object_name = object_name  # type: str

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

    def from_map(self, m=None):
        m = m or dict()
        if m.get('BucketName') is not None:
            self.bucket_name = m.get('BucketName')
        if m.get('ObjectName') is not None:
            self.object_name = m.get('ObjectName')
        return self


class DeleteObjectTaggingResponse(TeaModel):
    def __init__(self, request_id=None):
        # x-oss-request-id
        self.request_id = request_id  # type: str

    def validate(self):
        self.validate_required(self.request_id, 'request_id')

    def to_map(self):
        result = dict()
        if self.request_id is not None:
            result['x-oss-request-id'] = self.request_id
        return result

    def from_map(self, m=None):
        m = m or dict()
        if m.get('x-oss-request-id') is not None:
            self.request_id = m.get('x-oss-request-id')
        return self


class RestoreObjectRequest(TeaModel):
    def __init__(self, bucket_name=None, object_name=None):
        # BucketName
        self.bucket_name = bucket_name  # type: str
        # ObjectName
        self.object_name = object_name  # type: str

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

    def from_map(self, m=None):
        m = m or dict()
        if m.get('BucketName') is not None:
            self.bucket_name = m.get('BucketName')
        if m.get('ObjectName') is not None:
            self.object_name = m.get('ObjectName')
        return self


class RestoreObjectResponse(TeaModel):
    def __init__(self, request_id=None):
        # x-oss-request-id
        self.request_id = request_id  # type: str

    def validate(self):
        self.validate_required(self.request_id, 'request_id')

    def to_map(self):
        result = dict()
        if self.request_id is not None:
            result['x-oss-request-id'] = self.request_id
        return result

    def from_map(self, m=None):
        m = m or dict()
        if m.get('x-oss-request-id') is not None:
            self.request_id = m.get('x-oss-request-id')
        return self


class GetObjectAclRequest(TeaModel):
    def __init__(self, bucket_name=None, object_name=None):
        # BucketName
        self.bucket_name = bucket_name  # type: str
        # ObjectName
        self.object_name = object_name  # type: str

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

    def from_map(self, m=None):
        m = m or dict()
        if m.get('BucketName') is not None:
            self.bucket_name = m.get('BucketName')
        if m.get('ObjectName') is not None:
            self.object_name = m.get('ObjectName')
        return self


class GetObjectAclResponseAccessControlPolicyOwner(TeaModel):
    def __init__(self, i_d=None, display_name=None):
        # ID
        self.i_d = i_d  # type: str
        # DisplayName
        self.display_name = display_name  # type: str

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.i_d is not None:
            result['ID'] = self.i_d
        if self.display_name is not None:
            result['DisplayName'] = self.display_name
        return result

    def from_map(self, m=None):
        m = m or dict()
        if m.get('ID') is not None:
            self.i_d = m.get('ID')
        if m.get('DisplayName') is not None:
            self.display_name = m.get('DisplayName')
        return self


class GetObjectAclResponseAccessControlPolicyAccessControlList(TeaModel):
    def __init__(self, grant=None):
        # Grant
        self.grant = grant  # type: str

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.grant is not None:
            result['Grant'] = self.grant
        return result

    def from_map(self, m=None):
        m = m or dict()
        if m.get('Grant') is not None:
            self.grant = m.get('Grant')
        return self


class GetObjectAclResponseAccessControlPolicy(TeaModel):
    def __init__(self, owner=None, access_control_list=None):
        # Owner
        self.owner = owner  # type: GetObjectAclResponseAccessControlPolicyOwner
        # AccessControlList
        self.access_control_list = access_control_list  # type: GetObjectAclResponseAccessControlPolicyAccessControlList

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

    def from_map(self, m=None):
        m = m or dict()
        if m.get('Owner') is not None:
            temp_model = GetObjectAclResponseAccessControlPolicyOwner()
            self.owner = temp_model.from_map(m['Owner'])
        if m.get('AccessControlList') is not None:
            temp_model = GetObjectAclResponseAccessControlPolicyAccessControlList()
            self.access_control_list = temp_model.from_map(m['AccessControlList'])
        return self


class GetObjectAclResponse(TeaModel):
    def __init__(self, request_id=None, access_control_policy=None):
        # x-oss-request-id
        self.request_id = request_id  # type: str
        # AccessControlPolicy
        self.access_control_policy = access_control_policy  # type: GetObjectAclResponseAccessControlPolicy

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

    def from_map(self, m=None):
        m = m or dict()
        if m.get('x-oss-request-id') is not None:
            self.request_id = m.get('x-oss-request-id')
        if m.get('AccessControlPolicy') is not None:
            temp_model = GetObjectAclResponseAccessControlPolicy()
            self.access_control_policy = temp_model.from_map(m['AccessControlPolicy'])
        return self


class PutBucketAclRequestHeader(TeaModel):
    def __init__(self, acl=None):
        # x-oss-acl
        self.acl = acl  # type: str

    def validate(self):
        self.validate_required(self.acl, 'acl')

    def to_map(self):
        result = dict()
        if self.acl is not None:
            result['x-oss-acl'] = self.acl
        return result

    def from_map(self, m=None):
        m = m or dict()
        if m.get('x-oss-acl') is not None:
            self.acl = m.get('x-oss-acl')
        return self


class PutBucketAclRequest(TeaModel):
    def __init__(self, bucket_name=None, header=None):
        # BucketName
        self.bucket_name = bucket_name  # type: str
        # Header
        self.header = header  # type: PutBucketAclRequestHeader

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

    def from_map(self, m=None):
        m = m or dict()
        if m.get('BucketName') is not None:
            self.bucket_name = m.get('BucketName')
        if m.get('Header') is not None:
            temp_model = PutBucketAclRequestHeader()
            self.header = temp_model.from_map(m['Header'])
        return self


class PutBucketAclResponse(TeaModel):
    def __init__(self, request_id=None):
        # x-oss-request-id
        self.request_id = request_id  # type: str

    def validate(self):
        self.validate_required(self.request_id, 'request_id')

    def to_map(self):
        result = dict()
        if self.request_id is not None:
            result['x-oss-request-id'] = self.request_id
        return result

    def from_map(self, m=None):
        m = m or dict()
        if m.get('x-oss-request-id') is not None:
            self.request_id = m.get('x-oss-request-id')
        return self


class DeleteBucketRequest(TeaModel):
    def __init__(self, bucket_name=None):
        # BucketName
        self.bucket_name = bucket_name  # type: str

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')
        if self.bucket_name is not None:
            self.validate_pattern(self.bucket_name, 'bucket_name', '[a-zA-Z0-9-_]+')

    def to_map(self):
        result = dict()
        if self.bucket_name is not None:
            result['BucketName'] = self.bucket_name
        return result

    def from_map(self, m=None):
        m = m or dict()
        if m.get('BucketName') is not None:
            self.bucket_name = m.get('BucketName')
        return self


class DeleteBucketResponse(TeaModel):
    def __init__(self, request_id=None):
        # x-oss-request-id
        self.request_id = request_id  # type: str

    def validate(self):
        self.validate_required(self.request_id, 'request_id')

    def to_map(self):
        result = dict()
        if self.request_id is not None:
            result['x-oss-request-id'] = self.request_id
        return result

    def from_map(self, m=None):
        m = m or dict()
        if m.get('x-oss-request-id') is not None:
            self.request_id = m.get('x-oss-request-id')
        return self


class PutObjectRequestHeader(TeaModel):
    def __init__(self, authorization=None, cache_control=None, content_disposition=None, content_encoding=None,
                 content_md5=None, content_length=None, e_tag=None, expires=None, server_side_encryption=None,
                 server_side_encryption_key_id=None, object_acl=None, storage_class=None, tagging=None, content_type=None):
        # Authorization
        self.authorization = authorization  # type: str
        # Cache-Control
        self.cache_control = cache_control  # type: str
        # Content-Disposition
        self.content_disposition = content_disposition  # type: str
        # Content-Encoding
        self.content_encoding = content_encoding  # type: str
        # Content-MD5
        self.content_md5 = content_md5  # type: str
        # Content-Length
        self.content_length = content_length  # type: str
        # CETag
        self.e_tag = e_tag  # type: str
        # Expires
        self.expires = expires  # type: str
        # x-oss-server-side-encryption
        self.server_side_encryption = server_side_encryption  # type: str
        # x-oss-server-side-encryption-key-id
        self.server_side_encryption_key_id = server_side_encryption_key_id  # type: str
        # x-oss-object-acl
        self.object_acl = object_acl  # type: str
        # x-oss-storage-class
        self.storage_class = storage_class  # type: str
        # x-oss-tagging
        self.tagging = tagging  # type: str
        # content-type
        self.content_type = content_type  # type: str

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

    def from_map(self, m=None):
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
    def __init__(self, bucket_name=None, object_name=None, user_meta=None, body=None, header=None):
        # BucketName
        self.bucket_name = bucket_name  # type: str
        # ObjectName
        self.object_name = object_name  # type: str
        # UserMeta
        self.user_meta = user_meta  # type: dict[str, str]
        # body
        self.body = body  # type: READABLE
        # Header
        self.header = header  # type: PutObjectRequestHeader

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

    def from_map(self, m=None):
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
    def __init__(self, request_id=None, hash_crc_64ecma=None, server_time=None, bucket_version=None):
        # x-oss-request-id
        self.request_id = request_id  # type: str
        # x-oss-hash-crc64ecma
        self.hash_crc_64ecma = hash_crc_64ecma  # type: str
        # x-oss-server-time
        self.server_time = server_time  # type: str
        # x-oss-bucket-version
        self.bucket_version = bucket_version  # type: str

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

    def from_map(self, m=None):
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


