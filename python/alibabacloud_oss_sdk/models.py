# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from alibabacloud_tea_fileform import models as file_form_models


class Config(TeaModel):
    def __init__(self, type=None, security_token=None, access_key_id=None, access_key_secret=None, endpoint=None, protocol=None, region_id=None, user_agent=None, host_model=None, signature_version=None, is_enable_md5=None, is_enable_crc=None, read_timeout=None, connect_timeout=None, local_addr=None, http_proxy=None, https_proxy=None, no_proxy=None, socks_5proxy=None, socks_5net_work=None, max_idle_conns=None, addtional_headers=None):
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
        self.addtional_headers = []

    def validate(self):
        self.validate_required(self.access_key_id, 'access_key_id')
        self.validate_required(self.access_key_secret, 'access_key_secret')

    def to_map(self):
        result = {}
        result['type'] = self.type
        result['securityToken'] = self.security_token
        result['accessKeyId'] = self.access_key_id
        result['accessKeySecret'] = self.access_key_secret
        result['endpoint'] = self.endpoint
        result['protocol'] = self.protocol
        result['regionId'] = self.region_id
        result['userAgent'] = self.user_agent
        result['hostModel'] = self.host_model
        result['signatureVersion'] = self.signature_version
        result['isEnableMD5'] = self.is_enable_md5
        result['isEnableCrc'] = self.is_enable_crc
        result['readTimeout'] = self.read_timeout
        result['connectTimeout'] = self.connect_timeout
        result['localAddr'] = self.local_addr
        result['httpProxy'] = self.http_proxy
        result['httpsProxy'] = self.https_proxy
        result['noProxy'] = self.no_proxy
        result['socks5Proxy'] = self.socks_5proxy
        result['socks5NetWork'] = self.socks_5net_work
        result['maxIdleConns'] = self.max_idle_conns
        result['addtionalHeaders'] = []
        if self.addtional_headers is not None:
            for k in self.addtional_headers:
                result['addtionalHeaders'].append(k)
        else:
            result['addtionalHeaders'] = None
        return result

    def from_map(self, map={}):
        self.type = map.get('type')
        self.security_token = map.get('securityToken')
        self.access_key_id = map.get('accessKeyId')
        self.access_key_secret = map.get('accessKeySecret')
        self.endpoint = map.get('endpoint')
        self.protocol = map.get('protocol')
        self.region_id = map.get('regionId')
        self.user_agent = map.get('userAgent')
        self.host_model = map.get('hostModel')
        self.signature_version = map.get('signatureVersion')
        self.is_enable_md5 = map.get('isEnableMD5')
        self.is_enable_crc = map.get('isEnableCrc')
        self.read_timeout = map.get('readTimeout')
        self.connect_timeout = map.get('connectTimeout')
        self.local_addr = map.get('localAddr')
        self.http_proxy = map.get('httpProxy')
        self.https_proxy = map.get('httpsProxy')
        self.no_proxy = map.get('noProxy')
        self.socks_5proxy = map.get('socks5Proxy')
        self.socks_5net_work = map.get('socks5NetWork')
        self.max_idle_conns = map.get('maxIdleConns')
        self.addtional_headers = []
        if map.get('addtionalHeaders') is not None:
            for k in map.get('addtionalHeaders'):
                self.addtional_headers.append(k)
        else:
            self.addtional_headers = None
        return self


class PutBucketLifecycleRequest(TeaModel):
    def __init__(self, bucket_name=None, body=None):
        self.bucket_name = bucket_name
        self.body = body

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = {}
        result['BucketName'] = self.bucket_name
        if self.body is not None:
            result['Body'] = self.body.to_map()
        else:
            result['Body'] = None
        return result

    def from_map(self, map={}):
        self.bucket_name = map.get('BucketName')
        if map.get('Body') is not None:
            temp_model = PutBucketLifecycleRequestBody()
            self.body = temp_model.from_map(map['Body'])
        else:
            self.body = None
        return self


class PutBucketLifecycleRequestBodyLifecycleConfigurationRuleExpiration(TeaModel):
    def __init__(self, days=None, created_before_date=None):
        self.days = days
        self.created_before_date = created_before_date

    def validate(self):
        pass

    def to_map(self):
        result = {}
        result['Days'] = self.days
        result['CreatedBeforeDate'] = self.created_before_date
        return result

    def from_map(self, map={}):
        self.days = map.get('Days')
        self.created_before_date = map.get('CreatedBeforeDate')
        return self


class PutBucketLifecycleRequestBodyLifecycleConfigurationRuleTransition(TeaModel):
    def __init__(self, days=None, storage_class=None):
        self.days = days
        self.storage_class = storage_class

    def validate(self):
        pass

    def to_map(self):
        result = {}
        result['Days'] = self.days
        result['StorageClass'] = self.storage_class
        return result

    def from_map(self, map={}):
        self.days = map.get('Days')
        self.storage_class = map.get('StorageClass')
        return self


class PutBucketLifecycleRequestBodyLifecycleConfigurationRuleAbortMultipartUpload(TeaModel):
    def __init__(self, days=None, created_before_date=None):
        self.days = days
        self.created_before_date = created_before_date

    def validate(self):
        pass

    def to_map(self):
        result = {}
        result['Days'] = self.days
        result['CreatedBeforeDate'] = self.created_before_date
        return result

    def from_map(self, map={}):
        self.days = map.get('Days')
        self.created_before_date = map.get('CreatedBeforeDate')
        return self


class PutBucketLifecycleRequestBodyLifecycleConfigurationRuleTag(TeaModel):
    def __init__(self, key=None, value=None):
        self.key = key
        self.value = value

    def validate(self):
        pass

    def to_map(self):
        result = {}
        result['Key'] = self.key
        result['Value'] = self.value
        return result

    def from_map(self, map={}):
        self.key = map.get('Key')
        self.value = map.get('Value')
        return self


class PutBucketLifecycleRequestBodyLifecycleConfigurationRule(TeaModel):
    def __init__(self, expiration=None, transition=None, abort_multipart_upload=None, tag=None, i_d=None, prefix=None, status=None):
        self.expiration = expiration
        self.transition = transition
        self.abort_multipart_upload = abort_multipart_upload
        self.tag = tag
        self.i_d = i_d
        self.prefix = prefix
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
        result = {}
        if self.expiration is not None:
            result['Expiration'] = self.expiration.to_map()
        else:
            result['Expiration'] = None
        if self.transition is not None:
            result['Transition'] = self.transition.to_map()
        else:
            result['Transition'] = None
        if self.abort_multipart_upload is not None:
            result['AbortMultipartUpload'] = self.abort_multipart_upload.to_map()
        else:
            result['AbortMultipartUpload'] = None
        if self.tag is not None:
            result['Tag'] = self.tag.to_map()
        else:
            result['Tag'] = None
        result['ID'] = self.i_d
        result['Prefix'] = self.prefix
        result['Status'] = self.status
        return result

    def from_map(self, map={}):
        if map.get('Expiration') is not None:
            temp_model = PutBucketLifecycleRequestBodyLifecycleConfigurationRuleExpiration()
            self.expiration = temp_model.from_map(map['Expiration'])
        else:
            self.expiration = None
        if map.get('Transition') is not None:
            temp_model = PutBucketLifecycleRequestBodyLifecycleConfigurationRuleTransition()
            self.transition = temp_model.from_map(map['Transition'])
        else:
            self.transition = None
        if map.get('AbortMultipartUpload') is not None:
            temp_model = PutBucketLifecycleRequestBodyLifecycleConfigurationRuleAbortMultipartUpload()
            self.abort_multipart_upload = temp_model.from_map(map['AbortMultipartUpload'])
        else:
            self.abort_multipart_upload = None
        if map.get('Tag') is not None:
            temp_model = PutBucketLifecycleRequestBodyLifecycleConfigurationRuleTag()
            self.tag = temp_model.from_map(map['Tag'])
        else:
            self.tag = None
        self.i_d = map.get('ID')
        self.prefix = map.get('Prefix')
        self.status = map.get('Status')
        return self


class PutBucketLifecycleRequestBodyLifecycleConfiguration(TeaModel):
    def __init__(self, rule=None):
        self.rule = []

    def validate(self):
        if self.rule:
            for k in self.rule:
                if k :
                    k.validate()

    def to_map(self):
        result = {}
        result['Rule'] = []
        if self.rule is not None:
            for k in self.rule:
                result['Rule'].append(k.to_map() if k else None)
        else:
            result['Rule'] = None
        return result

    def from_map(self, map={}):
        self.rule = []
        if map.get('Rule') is not None:
            for k in map.get('Rule'):
                temp_model = PutBucketLifecycleRequestBodyLifecycleConfigurationRule()
                temp_model = temp_model.from_map(k)
                self.rule.append(temp_model)
        else:
            self.rule = None
        return self


class PutBucketLifecycleRequestBody(TeaModel):
    def __init__(self, lifecycle_configuration=None):
        self.lifecycle_configuration = lifecycle_configuration

    def validate(self):
        self.validate_required(self.lifecycle_configuration, 'lifecycle_configuration')
        if self.lifecycle_configuration:
            self.lifecycle_configuration.validate()

    def to_map(self):
        result = {}
        if self.lifecycle_configuration is not None:
            result['LifecycleConfiguration'] = self.lifecycle_configuration.to_map()
        else:
            result['LifecycleConfiguration'] = None
        return result

    def from_map(self, map={}):
        if map.get('LifecycleConfiguration') is not None:
            temp_model = PutBucketLifecycleRequestBodyLifecycleConfiguration()
            self.lifecycle_configuration = temp_model.from_map(map['LifecycleConfiguration'])
        else:
            self.lifecycle_configuration = None
        return self


class PutBucketLifecycleResponse(TeaModel):
    def __init__(self, request_id=None):
        self.request_id = request_id

    def validate(self):
        self.validate_required(self.request_id, 'request_id')

    def to_map(self):
        result = {}
        result['x-oss-request-id'] = self.request_id
        return result

    def from_map(self, map={}):
        self.request_id = map.get('x-oss-request-id')
        return self


class DeleteMultipleObjectsRequest(TeaModel):
    def __init__(self, bucket_name=None, body=None, header=None):
        self.bucket_name = bucket_name
        self.body = body
        self.header = header

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')
        if self.body:
            self.body.validate()
        self.validate_required(self.header, 'header')
        if self.header:
            self.header.validate()

    def to_map(self):
        result = {}
        result['BucketName'] = self.bucket_name
        if self.body is not None:
            result['Body'] = self.body.to_map()
        else:
            result['Body'] = None
        if self.header is not None:
            result['Header'] = self.header.to_map()
        else:
            result['Header'] = None
        return result

    def from_map(self, map={}):
        self.bucket_name = map.get('BucketName')
        if map.get('Body') is not None:
            temp_model = DeleteMultipleObjectsRequestBody()
            self.body = temp_model.from_map(map['Body'])
        else:
            self.body = None
        if map.get('Header') is not None:
            temp_model = DeleteMultipleObjectsRequestHeader()
            self.header = temp_model.from_map(map['Header'])
        else:
            self.header = None
        return self


class DeleteMultipleObjectsRequestBodyDeleteObject(TeaModel):
    def __init__(self, key=None):
        self.key = key

    def validate(self):
        pass

    def to_map(self):
        result = {}
        result['Key'] = self.key
        return result

    def from_map(self, map={}):
        self.key = map.get('Key')
        return self


class DeleteMultipleObjectsRequestBodyDelete(TeaModel):
    def __init__(self, object=None, quiet=None):
        self.object = []
        self.quiet = quiet

    def validate(self):
        if self.object:
            for k in self.object:
                if k :
                    k.validate()

    def to_map(self):
        result = {}
        result['Object'] = []
        if self.object is not None:
            for k in self.object:
                result['Object'].append(k.to_map() if k else None)
        else:
            result['Object'] = None
        result['Quiet'] = self.quiet
        return result

    def from_map(self, map={}):
        self.object = []
        if map.get('Object') is not None:
            for k in map.get('Object'):
                temp_model = DeleteMultipleObjectsRequestBodyDeleteObject()
                temp_model = temp_model.from_map(k)
                self.object.append(temp_model)
        else:
            self.object = None
        self.quiet = map.get('Quiet')
        return self


class DeleteMultipleObjectsRequestBody(TeaModel):
    def __init__(self, delete=None):
        self.delete = delete

    def validate(self):
        self.validate_required(self.delete, 'delete')
        if self.delete:
            self.delete.validate()

    def to_map(self):
        result = {}
        if self.delete is not None:
            result['Delete'] = self.delete.to_map()
        else:
            result['Delete'] = None
        return result

    def from_map(self, map={}):
        if map.get('Delete') is not None:
            temp_model = DeleteMultipleObjectsRequestBodyDelete()
            self.delete = temp_model.from_map(map['Delete'])
        else:
            self.delete = None
        return self


class DeleteMultipleObjectsRequestHeader(TeaModel):
    def __init__(self, encoding_type=None, content_length=None, content_md5=None):
        self.encoding_type = encoding_type
        self.content_length = content_length
        self.content_md5 = content_md5

    def validate(self):
        self.validate_required(self.content_length, 'content_length')
        self.validate_required(self.content_md5, 'content_md5')

    def to_map(self):
        result = {}
        result['Encoding-type'] = self.encoding_type
        result['Content-Length'] = self.content_length
        result['Content-MD5'] = self.content_md5
        return result

    def from_map(self, map={}):
        self.encoding_type = map.get('Encoding-type')
        self.content_length = map.get('Content-Length')
        self.content_md5 = map.get('Content-MD5')
        return self


class DeleteMultipleObjectsResponse(TeaModel):
    def __init__(self, request_id=None, delete_result=None):
        self.request_id = request_id
        self.delete_result = delete_result

    def validate(self):
        self.validate_required(self.request_id, 'request_id')
        self.validate_required(self.delete_result, 'delete_result')
        if self.delete_result:
            self.delete_result.validate()

    def to_map(self):
        result = {}
        result['x-oss-request-id'] = self.request_id
        if self.delete_result is not None:
            result['DeleteResult'] = self.delete_result.to_map()
        else:
            result['DeleteResult'] = None
        return result

    def from_map(self, map={}):
        self.request_id = map.get('x-oss-request-id')
        if map.get('DeleteResult') is not None:
            temp_model = DeleteMultipleObjectsResponseDeleteResult()
            self.delete_result = temp_model.from_map(map['DeleteResult'])
        else:
            self.delete_result = None
        return self


class DeleteMultipleObjectsResponseDeleteResultDeleted(TeaModel):
    def __init__(self, key=None):
        self.key = key

    def validate(self):
        pass

    def to_map(self):
        result = {}
        result['Key'] = self.key
        return result

    def from_map(self, map={}):
        self.key = map.get('Key')
        return self


class DeleteMultipleObjectsResponseDeleteResult(TeaModel):
    def __init__(self, quiet=None, encoding_type=None, deleted=None):
        self.quiet = quiet
        self.encoding_type = encoding_type
        self.deleted = []

    def validate(self):
        if self.deleted:
            for k in self.deleted:
                if k :
                    k.validate()

    def to_map(self):
        result = {}
        result['Quiet'] = self.quiet
        result['EncodingType'] = self.encoding_type
        result['Deleted'] = []
        if self.deleted is not None:
            for k in self.deleted:
                result['Deleted'].append(k.to_map() if k else None)
        else:
            result['Deleted'] = None
        return result

    def from_map(self, map={}):
        self.quiet = map.get('Quiet')
        self.encoding_type = map.get('EncodingType')
        self.deleted = []
        if map.get('Deleted') is not None:
            for k in map.get('Deleted'):
                temp_model = DeleteMultipleObjectsResponseDeleteResultDeleted()
                temp_model = temp_model.from_map(k)
                self.deleted.append(temp_model)
        else:
            self.deleted = None
        return self


class PutBucketRefererRequest(TeaModel):
    def __init__(self, bucket_name=None, body=None):
        self.bucket_name = bucket_name
        self.body = body

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = {}
        result['BucketName'] = self.bucket_name
        if self.body is not None:
            result['Body'] = self.body.to_map()
        else:
            result['Body'] = None
        return result

    def from_map(self, map={}):
        self.bucket_name = map.get('BucketName')
        if map.get('Body') is not None:
            temp_model = PutBucketRefererRequestBody()
            self.body = temp_model.from_map(map['Body'])
        else:
            self.body = None
        return self


class PutBucketRefererRequestBodyRefererConfigurationRefererList(TeaModel):
    def __init__(self, referer=None):
        self.referer = []

    def validate(self):
        pass

    def to_map(self):
        result = {}
        result['Referer'] = []
        if self.referer is not None:
            for k in self.referer:
                result['Referer'].append(k)
        else:
            result['Referer'] = None
        return result

    def from_map(self, map={}):
        self.referer = []
        if map.get('Referer') is not None:
            for k in map.get('Referer'):
                self.referer.append(k)
        else:
            self.referer = None
        return self


class PutBucketRefererRequestBodyRefererConfiguration(TeaModel):
    def __init__(self, referer_list=None, allow_empty_referer=None):
        self.referer_list = referer_list
        self.allow_empty_referer = allow_empty_referer

    def validate(self):
        if self.referer_list:
            self.referer_list.validate()

    def to_map(self):
        result = {}
        if self.referer_list is not None:
            result['RefererList'] = self.referer_list.to_map()
        else:
            result['RefererList'] = None
        result['AllowEmptyReferer'] = self.allow_empty_referer
        return result

    def from_map(self, map={}):
        if map.get('RefererList') is not None:
            temp_model = PutBucketRefererRequestBodyRefererConfigurationRefererList()
            self.referer_list = temp_model.from_map(map['RefererList'])
        else:
            self.referer_list = None
        self.allow_empty_referer = map.get('AllowEmptyReferer')
        return self


class PutBucketRefererRequestBody(TeaModel):
    def __init__(self, referer_configuration=None):
        self.referer_configuration = referer_configuration

    def validate(self):
        self.validate_required(self.referer_configuration, 'referer_configuration')
        if self.referer_configuration:
            self.referer_configuration.validate()

    def to_map(self):
        result = {}
        if self.referer_configuration is not None:
            result['RefererConfiguration'] = self.referer_configuration.to_map()
        else:
            result['RefererConfiguration'] = None
        return result

    def from_map(self, map={}):
        if map.get('RefererConfiguration') is not None:
            temp_model = PutBucketRefererRequestBodyRefererConfiguration()
            self.referer_configuration = temp_model.from_map(map['RefererConfiguration'])
        else:
            self.referer_configuration = None
        return self


class PutBucketRefererResponse(TeaModel):
    def __init__(self, request_id=None):
        self.request_id = request_id

    def validate(self):
        self.validate_required(self.request_id, 'request_id')

    def to_map(self):
        result = {}
        result['x-oss-request-id'] = self.request_id
        return result

    def from_map(self, map={}):
        self.request_id = map.get('x-oss-request-id')
        return self


class PutBucketWebsiteRequest(TeaModel):
    def __init__(self, bucket_name=None, body=None):
        self.bucket_name = bucket_name
        self.body = body

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = {}
        result['BucketName'] = self.bucket_name
        if self.body is not None:
            result['Body'] = self.body.to_map()
        else:
            result['Body'] = None
        return result

    def from_map(self, map={}):
        self.bucket_name = map.get('BucketName')
        if map.get('Body') is not None:
            temp_model = PutBucketWebsiteRequestBody()
            self.body = temp_model.from_map(map['Body'])
        else:
            self.body = None
        return self


class PutBucketWebsiteRequestBodyWebsiteConfigurationIndexDocument(TeaModel):
    def __init__(self, suffix=None):
        self.suffix = suffix

    def validate(self):
        pass

    def to_map(self):
        result = {}
        result['Suffix'] = self.suffix
        return result

    def from_map(self, map={}):
        self.suffix = map.get('Suffix')
        return self


class PutBucketWebsiteRequestBodyWebsiteConfigurationErrorDocument(TeaModel):
    def __init__(self, key=None):
        self.key = key

    def validate(self):
        pass

    def to_map(self):
        result = {}
        result['Key'] = self.key
        return result

    def from_map(self, map={}):
        self.key = map.get('Key')
        return self


class PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleConditionIncludeHeader(TeaModel):
    def __init__(self, key=None, equals=None):
        self.key = key
        self.equals = equals

    def validate(self):
        pass

    def to_map(self):
        result = {}
        result['Key'] = self.key
        result['Equals'] = self.equals
        return result

    def from_map(self, map={}):
        self.key = map.get('Key')
        self.equals = map.get('Equals')
        return self


class PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleCondition(TeaModel):
    def __init__(self, include_header=None, key_prefix_equals=None, http_error_code_returned_equals=None):
        self.include_header = include_header
        self.key_prefix_equals = key_prefix_equals
        self.http_error_code_returned_equals = http_error_code_returned_equals

    def validate(self):
        if self.include_header:
            self.include_header.validate()

    def to_map(self):
        result = {}
        if self.include_header is not None:
            result['IncludeHeader'] = self.include_header.to_map()
        else:
            result['IncludeHeader'] = None
        result['KeyPrefixEquals'] = self.key_prefix_equals
        result['HttpErrorCodeReturnedEquals'] = self.http_error_code_returned_equals
        return result

    def from_map(self, map={}):
        if map.get('IncludeHeader') is not None:
            temp_model = PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleConditionIncludeHeader()
            self.include_header = temp_model.from_map(map['IncludeHeader'])
        else:
            self.include_header = None
        self.key_prefix_equals = map.get('KeyPrefixEquals')
        self.http_error_code_returned_equals = map.get('HttpErrorCodeReturnedEquals')
        return self


class PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeadersSet(TeaModel):
    def __init__(self, key=None, value=None):
        self.key = key
        self.value = value

    def validate(self):
        pass

    def to_map(self):
        result = {}
        result['Key'] = self.key
        result['Value'] = self.value
        return result

    def from_map(self, map={}):
        self.key = map.get('Key')
        self.value = map.get('Value')
        return self


class PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeaders(TeaModel):
    def __init__(self, set=None, pass_all=None, pass_=None, remove=None):
        self.set = set
        self.pass_all = pass_all
        self.pass_ = pass_
        self.remove = remove

    def validate(self):
        if self.set:
            self.set.validate()

    def to_map(self):
        result = {}
        if self.set is not None:
            result['Set'] = self.set.to_map()
        else:
            result['Set'] = None
        result['PassAll'] = self.pass_all
        result['Pass'] = self.pass_
        result['Remove'] = self.remove
        return result

    def from_map(self, map={}):
        if map.get('Set') is not None:
            temp_model = PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeadersSet()
            self.set = temp_model.from_map(map['Set'])
        else:
            self.set = None
        self.pass_all = map.get('PassAll')
        self.pass_ = map.get('Pass')
        self.remove = map.get('Remove')
        return self


class PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirect(TeaModel):
    def __init__(self, mirror_headers=None, redirect_type=None, pass_query_string=None, mirror_url=None, mirror_pass_query_string=None, mirror_follow_redirect=None, mirror_check_md_5=None, protocol=None, host_name=None, http_redirect_code=None, replace_key_prefix_with=None, replace_key_with=None):
        self.mirror_headers = mirror_headers
        self.redirect_type = redirect_type
        self.pass_query_string = pass_query_string
        self.mirror_url = mirror_url
        self.mirror_pass_query_string = mirror_pass_query_string
        self.mirror_follow_redirect = mirror_follow_redirect
        self.mirror_check_md_5 = mirror_check_md_5
        self.protocol = protocol
        self.host_name = host_name
        self.http_redirect_code = http_redirect_code
        self.replace_key_prefix_with = replace_key_prefix_with
        self.replace_key_with = replace_key_with

    def validate(self):
        if self.mirror_headers:
            self.mirror_headers.validate()

    def to_map(self):
        result = {}
        if self.mirror_headers is not None:
            result['MirrorHeaders'] = self.mirror_headers.to_map()
        else:
            result['MirrorHeaders'] = None
        result['RedirectType'] = self.redirect_type
        result['PassQueryString'] = self.pass_query_string
        result['MirrorURL'] = self.mirror_url
        result['MirrorPassQueryString'] = self.mirror_pass_query_string
        result['MirrorFollowRedirect'] = self.mirror_follow_redirect
        result['MirrorCheckMd5'] = self.mirror_check_md_5
        result['Protocol'] = self.protocol
        result['HostName'] = self.host_name
        result['HttpRedirectCode'] = self.http_redirect_code
        result['ReplaceKeyPrefixWith'] = self.replace_key_prefix_with
        result['ReplaceKeyWith'] = self.replace_key_with
        return result

    def from_map(self, map={}):
        if map.get('MirrorHeaders') is not None:
            temp_model = PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeaders()
            self.mirror_headers = temp_model.from_map(map['MirrorHeaders'])
        else:
            self.mirror_headers = None
        self.redirect_type = map.get('RedirectType')
        self.pass_query_string = map.get('PassQueryString')
        self.mirror_url = map.get('MirrorURL')
        self.mirror_pass_query_string = map.get('MirrorPassQueryString')
        self.mirror_follow_redirect = map.get('MirrorFollowRedirect')
        self.mirror_check_md_5 = map.get('MirrorCheckMd5')
        self.protocol = map.get('Protocol')
        self.host_name = map.get('HostName')
        self.http_redirect_code = map.get('HttpRedirectCode')
        self.replace_key_prefix_with = map.get('ReplaceKeyPrefixWith')
        self.replace_key_with = map.get('ReplaceKeyWith')
        return self


class PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRule(TeaModel):
    def __init__(self, condition=None, redirect=None, rule_number=None):
        self.condition = condition
        self.redirect = redirect
        self.rule_number = rule_number

    def validate(self):
        if self.condition:
            self.condition.validate()
        if self.redirect:
            self.redirect.validate()

    def to_map(self):
        result = {}
        if self.condition is not None:
            result['Condition'] = self.condition.to_map()
        else:
            result['Condition'] = None
        if self.redirect is not None:
            result['Redirect'] = self.redirect.to_map()
        else:
            result['Redirect'] = None
        result['RuleNumber'] = self.rule_number
        return result

    def from_map(self, map={}):
        if map.get('Condition') is not None:
            temp_model = PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleCondition()
            self.condition = temp_model.from_map(map['Condition'])
        else:
            self.condition = None
        if map.get('Redirect') is not None:
            temp_model = PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirect()
            self.redirect = temp_model.from_map(map['Redirect'])
        else:
            self.redirect = None
        self.rule_number = map.get('RuleNumber')
        return self


class PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRules(TeaModel):
    def __init__(self, routing_rule=None):
        self.routing_rule = []

    def validate(self):
        if self.routing_rule:
            for k in self.routing_rule:
                if k :
                    k.validate()

    def to_map(self):
        result = {}
        result['RoutingRule'] = []
        if self.routing_rule is not None:
            for k in self.routing_rule:
                result['RoutingRule'].append(k.to_map() if k else None)
        else:
            result['RoutingRule'] = None
        return result

    def from_map(self, map={}):
        self.routing_rule = []
        if map.get('RoutingRule') is not None:
            for k in map.get('RoutingRule'):
                temp_model = PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRule()
                temp_model = temp_model.from_map(k)
                self.routing_rule.append(temp_model)
        else:
            self.routing_rule = None
        return self


class PutBucketWebsiteRequestBodyWebsiteConfiguration(TeaModel):
    def __init__(self, index_document=None, error_document=None, routing_rules=None):
        self.index_document = index_document
        self.error_document = error_document
        self.routing_rules = routing_rules

    def validate(self):
        if self.index_document:
            self.index_document.validate()
        if self.error_document:
            self.error_document.validate()
        if self.routing_rules:
            self.routing_rules.validate()

    def to_map(self):
        result = {}
        if self.index_document is not None:
            result['IndexDocument'] = self.index_document.to_map()
        else:
            result['IndexDocument'] = None
        if self.error_document is not None:
            result['ErrorDocument'] = self.error_document.to_map()
        else:
            result['ErrorDocument'] = None
        if self.routing_rules is not None:
            result['RoutingRules'] = self.routing_rules.to_map()
        else:
            result['RoutingRules'] = None
        return result

    def from_map(self, map={}):
        if map.get('IndexDocument') is not None:
            temp_model = PutBucketWebsiteRequestBodyWebsiteConfigurationIndexDocument()
            self.index_document = temp_model.from_map(map['IndexDocument'])
        else:
            self.index_document = None
        if map.get('ErrorDocument') is not None:
            temp_model = PutBucketWebsiteRequestBodyWebsiteConfigurationErrorDocument()
            self.error_document = temp_model.from_map(map['ErrorDocument'])
        else:
            self.error_document = None
        if map.get('RoutingRules') is not None:
            temp_model = PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRules()
            self.routing_rules = temp_model.from_map(map['RoutingRules'])
        else:
            self.routing_rules = None
        return self


class PutBucketWebsiteRequestBody(TeaModel):
    def __init__(self, website_configuration=None):
        self.website_configuration = website_configuration

    def validate(self):
        self.validate_required(self.website_configuration, 'website_configuration')
        if self.website_configuration:
            self.website_configuration.validate()

    def to_map(self):
        result = {}
        if self.website_configuration is not None:
            result['WebsiteConfiguration'] = self.website_configuration.to_map()
        else:
            result['WebsiteConfiguration'] = None
        return result

    def from_map(self, map={}):
        if map.get('WebsiteConfiguration') is not None:
            temp_model = PutBucketWebsiteRequestBodyWebsiteConfiguration()
            self.website_configuration = temp_model.from_map(map['WebsiteConfiguration'])
        else:
            self.website_configuration = None
        return self


class PutBucketWebsiteResponse(TeaModel):
    def __init__(self, request_id=None):
        self.request_id = request_id

    def validate(self):
        self.validate_required(self.request_id, 'request_id')

    def to_map(self):
        result = {}
        result['x-oss-request-id'] = self.request_id
        return result

    def from_map(self, map={}):
        self.request_id = map.get('x-oss-request-id')
        return self


class CompleteMultipartUploadRequest(TeaModel):
    def __init__(self, bucket_name=None, object_name=None, filter=None, body=None):
        self.bucket_name = bucket_name
        self.object_name = object_name
        self.filter = filter
        self.body = body

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')
        self.validate_required(self.object_name, 'object_name')
        self.validate_required(self.filter, 'filter')
        if self.filter:
            self.filter.validate()
        if self.body:
            self.body.validate()

    def to_map(self):
        result = {}
        result['BucketName'] = self.bucket_name
        result['ObjectName'] = self.object_name
        if self.filter is not None:
            result['Filter'] = self.filter.to_map()
        else:
            result['Filter'] = None
        if self.body is not None:
            result['Body'] = self.body.to_map()
        else:
            result['Body'] = None
        return result

    def from_map(self, map={}):
        self.bucket_name = map.get('BucketName')
        self.object_name = map.get('ObjectName')
        if map.get('Filter') is not None:
            temp_model = CompleteMultipartUploadRequestFilter()
            self.filter = temp_model.from_map(map['Filter'])
        else:
            self.filter = None
        if map.get('Body') is not None:
            temp_model = CompleteMultipartUploadRequestBody()
            self.body = temp_model.from_map(map['Body'])
        else:
            self.body = None
        return self


class CompleteMultipartUploadRequestFilter(TeaModel):
    def __init__(self, upload_id=None, encoding_type=None):
        self.upload_id = upload_id
        self.encoding_type = encoding_type

    def validate(self):
        self.validate_required(self.upload_id, 'upload_id')

    def to_map(self):
        result = {}
        result['uploadId'] = self.upload_id
        result['Encoding-type'] = self.encoding_type
        return result

    def from_map(self, map={}):
        self.upload_id = map.get('uploadId')
        self.encoding_type = map.get('Encoding-type')
        return self


class CompleteMultipartUploadRequestBodyCompleteMultipartUploadPart(TeaModel):
    def __init__(self, part_number=None, e_tag=None):
        self.part_number = part_number
        self.e_tag = e_tag

    def validate(self):
        pass

    def to_map(self):
        result = {}
        result['PartNumber'] = self.part_number
        result['ETag'] = self.e_tag
        return result

    def from_map(self, map={}):
        self.part_number = map.get('PartNumber')
        self.e_tag = map.get('ETag')
        return self


class CompleteMultipartUploadRequestBodyCompleteMultipartUpload(TeaModel):
    def __init__(self, part=None):
        self.part = []

    def validate(self):
        if self.part:
            for k in self.part:
                if k :
                    k.validate()

    def to_map(self):
        result = {}
        result['Part'] = []
        if self.part is not None:
            for k in self.part:
                result['Part'].append(k.to_map() if k else None)
        else:
            result['Part'] = None
        return result

    def from_map(self, map={}):
        self.part = []
        if map.get('Part') is not None:
            for k in map.get('Part'):
                temp_model = CompleteMultipartUploadRequestBodyCompleteMultipartUploadPart()
                temp_model = temp_model.from_map(k)
                self.part.append(temp_model)
        else:
            self.part = None
        return self


class CompleteMultipartUploadRequestBody(TeaModel):
    def __init__(self, complete_multipart_upload=None):
        self.complete_multipart_upload = complete_multipart_upload

    def validate(self):
        self.validate_required(self.complete_multipart_upload, 'complete_multipart_upload')
        if self.complete_multipart_upload:
            self.complete_multipart_upload.validate()

    def to_map(self):
        result = {}
        if self.complete_multipart_upload is not None:
            result['CompleteMultipartUpload'] = self.complete_multipart_upload.to_map()
        else:
            result['CompleteMultipartUpload'] = None
        return result

    def from_map(self, map={}):
        if map.get('CompleteMultipartUpload') is not None:
            temp_model = CompleteMultipartUploadRequestBodyCompleteMultipartUpload()
            self.complete_multipart_upload = temp_model.from_map(map['CompleteMultipartUpload'])
        else:
            self.complete_multipart_upload = None
        return self


class CompleteMultipartUploadResponse(TeaModel):
    def __init__(self, request_id=None, complete_multipart_upload_result=None):
        self.request_id = request_id
        self.complete_multipart_upload_result = complete_multipart_upload_result

    def validate(self):
        self.validate_required(self.request_id, 'request_id')
        self.validate_required(self.complete_multipart_upload_result, 'complete_multipart_upload_result')
        if self.complete_multipart_upload_result:
            self.complete_multipart_upload_result.validate()

    def to_map(self):
        result = {}
        result['x-oss-request-id'] = self.request_id
        if self.complete_multipart_upload_result is not None:
            result['CompleteMultipartUploadResult'] = self.complete_multipart_upload_result.to_map()
        else:
            result['CompleteMultipartUploadResult'] = None
        return result

    def from_map(self, map={}):
        self.request_id = map.get('x-oss-request-id')
        if map.get('CompleteMultipartUploadResult') is not None:
            temp_model = CompleteMultipartUploadResponseCompleteMultipartUploadResult()
            self.complete_multipart_upload_result = temp_model.from_map(map['CompleteMultipartUploadResult'])
        else:
            self.complete_multipart_upload_result = None
        return self


class CompleteMultipartUploadResponseCompleteMultipartUploadResult(TeaModel):
    def __init__(self, bucket=None, e_tag=None, location=None, key=None, encoding_type=None):
        self.bucket = bucket
        self.e_tag = e_tag
        self.location = location
        self.key = key
        self.encoding_type = encoding_type

    def validate(self):
        pass

    def to_map(self):
        result = {}
        result['Bucket'] = self.bucket
        result['ETag'] = self.e_tag
        result['Location'] = self.location
        result['Key'] = self.key
        result['EncodingType'] = self.encoding_type
        return result

    def from_map(self, map={}):
        self.bucket = map.get('Bucket')
        self.e_tag = map.get('ETag')
        self.location = map.get('Location')
        self.key = map.get('Key')
        self.encoding_type = map.get('EncodingType')
        return self


class PutBucketLoggingRequest(TeaModel):
    def __init__(self, bucket_name=None, body=None):
        self.bucket_name = bucket_name
        self.body = body

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = {}
        result['BucketName'] = self.bucket_name
        if self.body is not None:
            result['Body'] = self.body.to_map()
        else:
            result['Body'] = None
        return result

    def from_map(self, map={}):
        self.bucket_name = map.get('BucketName')
        if map.get('Body') is not None:
            temp_model = PutBucketLoggingRequestBody()
            self.body = temp_model.from_map(map['Body'])
        else:
            self.body = None
        return self


class PutBucketLoggingRequestBodyBucketLoggingStatusLoggingEnabled(TeaModel):
    def __init__(self, target_bucket=None, target_prefix=None):
        self.target_bucket = target_bucket
        self.target_prefix = target_prefix

    def validate(self):
        pass

    def to_map(self):
        result = {}
        result['TargetBucket'] = self.target_bucket
        result['TargetPrefix'] = self.target_prefix
        return result

    def from_map(self, map={}):
        self.target_bucket = map.get('TargetBucket')
        self.target_prefix = map.get('TargetPrefix')
        return self


class PutBucketLoggingRequestBodyBucketLoggingStatus(TeaModel):
    def __init__(self, logging_enabled=None):
        self.logging_enabled = logging_enabled

    def validate(self):
        if self.logging_enabled:
            self.logging_enabled.validate()

    def to_map(self):
        result = {}
        if self.logging_enabled is not None:
            result['LoggingEnabled'] = self.logging_enabled.to_map()
        else:
            result['LoggingEnabled'] = None
        return result

    def from_map(self, map={}):
        if map.get('LoggingEnabled') is not None:
            temp_model = PutBucketLoggingRequestBodyBucketLoggingStatusLoggingEnabled()
            self.logging_enabled = temp_model.from_map(map['LoggingEnabled'])
        else:
            self.logging_enabled = None
        return self


class PutBucketLoggingRequestBody(TeaModel):
    def __init__(self, bucket_logging_status=None):
        self.bucket_logging_status = bucket_logging_status

    def validate(self):
        self.validate_required(self.bucket_logging_status, 'bucket_logging_status')
        if self.bucket_logging_status:
            self.bucket_logging_status.validate()

    def to_map(self):
        result = {}
        if self.bucket_logging_status is not None:
            result['BucketLoggingStatus'] = self.bucket_logging_status.to_map()
        else:
            result['BucketLoggingStatus'] = None
        return result

    def from_map(self, map={}):
        if map.get('BucketLoggingStatus') is not None:
            temp_model = PutBucketLoggingRequestBodyBucketLoggingStatus()
            self.bucket_logging_status = temp_model.from_map(map['BucketLoggingStatus'])
        else:
            self.bucket_logging_status = None
        return self


class PutBucketLoggingResponse(TeaModel):
    def __init__(self, request_id=None):
        self.request_id = request_id

    def validate(self):
        self.validate_required(self.request_id, 'request_id')

    def to_map(self):
        result = {}
        result['x-oss-request-id'] = self.request_id
        return result

    def from_map(self, map={}):
        self.request_id = map.get('x-oss-request-id')
        return self


class PutBucketRequestPaymentRequest(TeaModel):
    def __init__(self, bucket_name=None, body=None):
        self.bucket_name = bucket_name
        self.body = body

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = {}
        result['BucketName'] = self.bucket_name
        if self.body is not None:
            result['Body'] = self.body.to_map()
        else:
            result['Body'] = None
        return result

    def from_map(self, map={}):
        self.bucket_name = map.get('BucketName')
        if map.get('Body') is not None:
            temp_model = PutBucketRequestPaymentRequestBody()
            self.body = temp_model.from_map(map['Body'])
        else:
            self.body = None
        return self


class PutBucketRequestPaymentRequestBodyRequestPaymentConfiguration(TeaModel):
    def __init__(self, payer=None):
        self.payer = payer

    def validate(self):
        pass

    def to_map(self):
        result = {}
        result['Payer'] = self.payer
        return result

    def from_map(self, map={}):
        self.payer = map.get('Payer')
        return self


class PutBucketRequestPaymentRequestBody(TeaModel):
    def __init__(self, request_payment_configuration=None):
        self.request_payment_configuration = request_payment_configuration

    def validate(self):
        self.validate_required(self.request_payment_configuration, 'request_payment_configuration')
        if self.request_payment_configuration:
            self.request_payment_configuration.validate()

    def to_map(self):
        result = {}
        if self.request_payment_configuration is not None:
            result['RequestPaymentConfiguration'] = self.request_payment_configuration.to_map()
        else:
            result['RequestPaymentConfiguration'] = None
        return result

    def from_map(self, map={}):
        if map.get('RequestPaymentConfiguration') is not None:
            temp_model = PutBucketRequestPaymentRequestBodyRequestPaymentConfiguration()
            self.request_payment_configuration = temp_model.from_map(map['RequestPaymentConfiguration'])
        else:
            self.request_payment_configuration = None
        return self


class PutBucketRequestPaymentResponse(TeaModel):
    def __init__(self, request_id=None):
        self.request_id = request_id

    def validate(self):
        self.validate_required(self.request_id, 'request_id')

    def to_map(self):
        result = {}
        result['x-oss-request-id'] = self.request_id
        return result

    def from_map(self, map={}):
        self.request_id = map.get('x-oss-request-id')
        return self


class PutBucketEncryptionRequest(TeaModel):
    def __init__(self, bucket_name=None, body=None):
        self.bucket_name = bucket_name
        self.body = body

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = {}
        result['BucketName'] = self.bucket_name
        if self.body is not None:
            result['Body'] = self.body.to_map()
        else:
            result['Body'] = None
        return result

    def from_map(self, map={}):
        self.bucket_name = map.get('BucketName')
        if map.get('Body') is not None:
            temp_model = PutBucketEncryptionRequestBody()
            self.body = temp_model.from_map(map['Body'])
        else:
            self.body = None
        return self


class PutBucketEncryptionRequestBodyServerSideEncryptionRuleApplyServerSideEncryptionByDefault(TeaModel):
    def __init__(self, s_sealgorithm=None, k_msmaster_key_id=None):
        self.s_sealgorithm = s_sealgorithm
        self.k_msmaster_key_id = k_msmaster_key_id

    def validate(self):
        pass

    def to_map(self):
        result = {}
        result['SSEAlgorithm'] = self.s_sealgorithm
        result['KMSMasterKeyID'] = self.k_msmaster_key_id
        return result

    def from_map(self, map={}):
        self.s_sealgorithm = map.get('SSEAlgorithm')
        self.k_msmaster_key_id = map.get('KMSMasterKeyID')
        return self


class PutBucketEncryptionRequestBodyServerSideEncryptionRule(TeaModel):
    def __init__(self, apply_server_side_encryption_by_default=None):
        self.apply_server_side_encryption_by_default = apply_server_side_encryption_by_default

    def validate(self):
        if self.apply_server_side_encryption_by_default:
            self.apply_server_side_encryption_by_default.validate()

    def to_map(self):
        result = {}
        if self.apply_server_side_encryption_by_default is not None:
            result['ApplyServerSideEncryptionByDefault'] = self.apply_server_side_encryption_by_default.to_map()
        else:
            result['ApplyServerSideEncryptionByDefault'] = None
        return result

    def from_map(self, map={}):
        if map.get('ApplyServerSideEncryptionByDefault') is not None:
            temp_model = PutBucketEncryptionRequestBodyServerSideEncryptionRuleApplyServerSideEncryptionByDefault()
            self.apply_server_side_encryption_by_default = temp_model.from_map(map['ApplyServerSideEncryptionByDefault'])
        else:
            self.apply_server_side_encryption_by_default = None
        return self


class PutBucketEncryptionRequestBody(TeaModel):
    def __init__(self, server_side_encryption_rule=None):
        self.server_side_encryption_rule = server_side_encryption_rule

    def validate(self):
        self.validate_required(self.server_side_encryption_rule, 'server_side_encryption_rule')
        if self.server_side_encryption_rule:
            self.server_side_encryption_rule.validate()

    def to_map(self):
        result = {}
        if self.server_side_encryption_rule is not None:
            result['ServerSideEncryptionRule'] = self.server_side_encryption_rule.to_map()
        else:
            result['ServerSideEncryptionRule'] = None
        return result

    def from_map(self, map={}):
        if map.get('ServerSideEncryptionRule') is not None:
            temp_model = PutBucketEncryptionRequestBodyServerSideEncryptionRule()
            self.server_side_encryption_rule = temp_model.from_map(map['ServerSideEncryptionRule'])
        else:
            self.server_side_encryption_rule = None
        return self


class PutBucketEncryptionResponse(TeaModel):
    def __init__(self, request_id=None):
        self.request_id = request_id

    def validate(self):
        self.validate_required(self.request_id, 'request_id')

    def to_map(self):
        result = {}
        result['x-oss-request-id'] = self.request_id
        return result

    def from_map(self, map={}):
        self.request_id = map.get('x-oss-request-id')
        return self


class PutLiveChannelRequest(TeaModel):
    def __init__(self, bucket_name=None, channel_name=None, body=None):
        self.bucket_name = bucket_name
        self.channel_name = channel_name
        self.body = body

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')
        self.validate_required(self.channel_name, 'channel_name')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = {}
        result['BucketName'] = self.bucket_name
        result['ChannelName'] = self.channel_name
        if self.body is not None:
            result['Body'] = self.body.to_map()
        else:
            result['Body'] = None
        return result

    def from_map(self, map={}):
        self.bucket_name = map.get('BucketName')
        self.channel_name = map.get('ChannelName')
        if map.get('Body') is not None:
            temp_model = PutLiveChannelRequestBody()
            self.body = temp_model.from_map(map['Body'])
        else:
            self.body = None
        return self


class PutLiveChannelRequestBodyLiveChannelConfigurationTarget(TeaModel):
    def __init__(self, type=None, frag_duration=None, frag_count=None, playlist_name=None):
        self.type = type
        self.frag_duration = frag_duration
        self.frag_count = frag_count
        self.playlist_name = playlist_name

    def validate(self):
        pass

    def to_map(self):
        result = {}
        result['Type'] = self.type
        result['FragDuration'] = self.frag_duration
        result['FragCount'] = self.frag_count
        result['PlaylistName'] = self.playlist_name
        return result

    def from_map(self, map={}):
        self.type = map.get('Type')
        self.frag_duration = map.get('FragDuration')
        self.frag_count = map.get('FragCount')
        self.playlist_name = map.get('PlaylistName')
        return self


class PutLiveChannelRequestBodyLiveChannelConfigurationSnapshot(TeaModel):
    def __init__(self, role_name=None, dest_bucket=None, notify_topic=None, interval=None):
        self.role_name = role_name
        self.dest_bucket = dest_bucket
        self.notify_topic = notify_topic
        self.interval = interval

    def validate(self):
        pass

    def to_map(self):
        result = {}
        result['RoleName'] = self.role_name
        result['DestBucket'] = self.dest_bucket
        result['NotifyTopic'] = self.notify_topic
        result['Interval'] = self.interval
        return result

    def from_map(self, map={}):
        self.role_name = map.get('RoleName')
        self.dest_bucket = map.get('DestBucket')
        self.notify_topic = map.get('NotifyTopic')
        self.interval = map.get('Interval')
        return self


class PutLiveChannelRequestBodyLiveChannelConfiguration(TeaModel):
    def __init__(self, target=None, snapshot=None, description=None, status=None):
        self.target = target
        self.snapshot = snapshot
        self.description = description
        self.status = status

    def validate(self):
        if self.target:
            self.target.validate()
        if self.snapshot:
            self.snapshot.validate()

    def to_map(self):
        result = {}
        if self.target is not None:
            result['Target'] = self.target.to_map()
        else:
            result['Target'] = None
        if self.snapshot is not None:
            result['Snapshot'] = self.snapshot.to_map()
        else:
            result['Snapshot'] = None
        result['Description'] = self.description
        result['Status'] = self.status
        return result

    def from_map(self, map={}):
        if map.get('Target') is not None:
            temp_model = PutLiveChannelRequestBodyLiveChannelConfigurationTarget()
            self.target = temp_model.from_map(map['Target'])
        else:
            self.target = None
        if map.get('Snapshot') is not None:
            temp_model = PutLiveChannelRequestBodyLiveChannelConfigurationSnapshot()
            self.snapshot = temp_model.from_map(map['Snapshot'])
        else:
            self.snapshot = None
        self.description = map.get('Description')
        self.status = map.get('Status')
        return self


class PutLiveChannelRequestBody(TeaModel):
    def __init__(self, live_channel_configuration=None):
        self.live_channel_configuration = live_channel_configuration

    def validate(self):
        self.validate_required(self.live_channel_configuration, 'live_channel_configuration')
        if self.live_channel_configuration:
            self.live_channel_configuration.validate()

    def to_map(self):
        result = {}
        if self.live_channel_configuration is not None:
            result['LiveChannelConfiguration'] = self.live_channel_configuration.to_map()
        else:
            result['LiveChannelConfiguration'] = None
        return result

    def from_map(self, map={}):
        if map.get('LiveChannelConfiguration') is not None:
            temp_model = PutLiveChannelRequestBodyLiveChannelConfiguration()
            self.live_channel_configuration = temp_model.from_map(map['LiveChannelConfiguration'])
        else:
            self.live_channel_configuration = None
        return self


class PutLiveChannelResponse(TeaModel):
    def __init__(self, request_id=None, create_live_channel_result=None):
        self.request_id = request_id
        self.create_live_channel_result = create_live_channel_result

    def validate(self):
        self.validate_required(self.request_id, 'request_id')
        self.validate_required(self.create_live_channel_result, 'create_live_channel_result')
        if self.create_live_channel_result:
            self.create_live_channel_result.validate()

    def to_map(self):
        result = {}
        result['x-oss-request-id'] = self.request_id
        if self.create_live_channel_result is not None:
            result['CreateLiveChannelResult'] = self.create_live_channel_result.to_map()
        else:
            result['CreateLiveChannelResult'] = None
        return result

    def from_map(self, map={}):
        self.request_id = map.get('x-oss-request-id')
        if map.get('CreateLiveChannelResult') is not None:
            temp_model = PutLiveChannelResponseCreateLiveChannelResult()
            self.create_live_channel_result = temp_model.from_map(map['CreateLiveChannelResult'])
        else:
            self.create_live_channel_result = None
        return self


class PutLiveChannelResponseCreateLiveChannelResultPublishUrls(TeaModel):
    def __init__(self, url=None):
        self.url = url

    def validate(self):
        pass

    def to_map(self):
        result = {}
        result['Url'] = self.url
        return result

    def from_map(self, map={}):
        self.url = map.get('Url')
        return self


class PutLiveChannelResponseCreateLiveChannelResultPlayUrls(TeaModel):
    def __init__(self, url=None):
        self.url = url

    def validate(self):
        pass

    def to_map(self):
        result = {}
        result['Url'] = self.url
        return result

    def from_map(self, map={}):
        self.url = map.get('Url')
        return self


class PutLiveChannelResponseCreateLiveChannelResult(TeaModel):
    def __init__(self, publish_urls=None, play_urls=None):
        self.publish_urls = publish_urls
        self.play_urls = play_urls

    def validate(self):
        self.validate_required(self.publish_urls, 'publish_urls')
        if self.publish_urls:
            self.publish_urls.validate()
        self.validate_required(self.play_urls, 'play_urls')
        if self.play_urls:
            self.play_urls.validate()

    def to_map(self):
        result = {}
        if self.publish_urls is not None:
            result['PublishUrls'] = self.publish_urls.to_map()
        else:
            result['PublishUrls'] = None
        if self.play_urls is not None:
            result['PlayUrls'] = self.play_urls.to_map()
        else:
            result['PlayUrls'] = None
        return result

    def from_map(self, map={}):
        if map.get('PublishUrls') is not None:
            temp_model = PutLiveChannelResponseCreateLiveChannelResultPublishUrls()
            self.publish_urls = temp_model.from_map(map['PublishUrls'])
        else:
            self.publish_urls = None
        if map.get('PlayUrls') is not None:
            temp_model = PutLiveChannelResponseCreateLiveChannelResultPlayUrls()
            self.play_urls = temp_model.from_map(map['PlayUrls'])
        else:
            self.play_urls = None
        return self


class PutBucketTagsRequest(TeaModel):
    def __init__(self, bucket_name=None, body=None):
        self.bucket_name = bucket_name
        self.body = body

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = {}
        result['BucketName'] = self.bucket_name
        if self.body is not None:
            result['Body'] = self.body.to_map()
        else:
            result['Body'] = None
        return result

    def from_map(self, map={}):
        self.bucket_name = map.get('BucketName')
        if map.get('Body') is not None:
            temp_model = PutBucketTagsRequestBody()
            self.body = temp_model.from_map(map['Body'])
        else:
            self.body = None
        return self


class PutBucketTagsRequestBodyTaggingTagSetTag(TeaModel):
    def __init__(self, key=None, value=None):
        self.key = key
        self.value = value

    def validate(self):
        pass

    def to_map(self):
        result = {}
        result['Key'] = self.key
        result['Value'] = self.value
        return result

    def from_map(self, map={}):
        self.key = map.get('Key')
        self.value = map.get('Value')
        return self


class PutBucketTagsRequestBodyTaggingTagSet(TeaModel):
    def __init__(self, tag=None):
        self.tag = []

    def validate(self):
        if self.tag:
            for k in self.tag:
                if k :
                    k.validate()

    def to_map(self):
        result = {}
        result['Tag'] = []
        if self.tag is not None:
            for k in self.tag:
                result['Tag'].append(k.to_map() if k else None)
        else:
            result['Tag'] = None
        return result

    def from_map(self, map={}):
        self.tag = []
        if map.get('Tag') is not None:
            for k in map.get('Tag'):
                temp_model = PutBucketTagsRequestBodyTaggingTagSetTag()
                temp_model = temp_model.from_map(k)
                self.tag.append(temp_model)
        else:
            self.tag = None
        return self


class PutBucketTagsRequestBodyTagging(TeaModel):
    def __init__(self, tag_set=None):
        self.tag_set = tag_set

    def validate(self):
        if self.tag_set:
            self.tag_set.validate()

    def to_map(self):
        result = {}
        if self.tag_set is not None:
            result['TagSet'] = self.tag_set.to_map()
        else:
            result['TagSet'] = None
        return result

    def from_map(self, map={}):
        if map.get('TagSet') is not None:
            temp_model = PutBucketTagsRequestBodyTaggingTagSet()
            self.tag_set = temp_model.from_map(map['TagSet'])
        else:
            self.tag_set = None
        return self


class PutBucketTagsRequestBody(TeaModel):
    def __init__(self, tagging=None):
        self.tagging = tagging

    def validate(self):
        self.validate_required(self.tagging, 'tagging')
        if self.tagging:
            self.tagging.validate()

    def to_map(self):
        result = {}
        if self.tagging is not None:
            result['Tagging'] = self.tagging.to_map()
        else:
            result['Tagging'] = None
        return result

    def from_map(self, map={}):
        if map.get('Tagging') is not None:
            temp_model = PutBucketTagsRequestBodyTagging()
            self.tagging = temp_model.from_map(map['Tagging'])
        else:
            self.tagging = None
        return self


class PutBucketTagsResponse(TeaModel):
    def __init__(self, request_id=None):
        self.request_id = request_id

    def validate(self):
        self.validate_required(self.request_id, 'request_id')

    def to_map(self):
        result = {}
        result['x-oss-request-id'] = self.request_id
        return result

    def from_map(self, map={}):
        self.request_id = map.get('x-oss-request-id')
        return self


class PutObjectTaggingRequest(TeaModel):
    def __init__(self, bucket_name=None, object_name=None, body=None):
        self.bucket_name = bucket_name
        self.object_name = object_name
        self.body = body

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')
        self.validate_required(self.object_name, 'object_name')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = {}
        result['BucketName'] = self.bucket_name
        result['ObjectName'] = self.object_name
        if self.body is not None:
            result['Body'] = self.body.to_map()
        else:
            result['Body'] = None
        return result

    def from_map(self, map={}):
        self.bucket_name = map.get('BucketName')
        self.object_name = map.get('ObjectName')
        if map.get('Body') is not None:
            temp_model = PutObjectTaggingRequestBody()
            self.body = temp_model.from_map(map['Body'])
        else:
            self.body = None
        return self


class PutObjectTaggingRequestBodyTaggingTagSetTag(TeaModel):
    def __init__(self, key=None, value=None):
        self.key = key
        self.value = value

    def validate(self):
        pass

    def to_map(self):
        result = {}
        result['Key'] = self.key
        result['Value'] = self.value
        return result

    def from_map(self, map={}):
        self.key = map.get('Key')
        self.value = map.get('Value')
        return self


class PutObjectTaggingRequestBodyTaggingTagSet(TeaModel):
    def __init__(self, tag=None):
        self.tag = []

    def validate(self):
        if self.tag:
            for k in self.tag:
                if k :
                    k.validate()

    def to_map(self):
        result = {}
        result['Tag'] = []
        if self.tag is not None:
            for k in self.tag:
                result['Tag'].append(k.to_map() if k else None)
        else:
            result['Tag'] = None
        return result

    def from_map(self, map={}):
        self.tag = []
        if map.get('Tag') is not None:
            for k in map.get('Tag'):
                temp_model = PutObjectTaggingRequestBodyTaggingTagSetTag()
                temp_model = temp_model.from_map(k)
                self.tag.append(temp_model)
        else:
            self.tag = None
        return self


class PutObjectTaggingRequestBodyTagging(TeaModel):
    def __init__(self, tag_set=None):
        self.tag_set = tag_set

    def validate(self):
        if self.tag_set:
            self.tag_set.validate()

    def to_map(self):
        result = {}
        if self.tag_set is not None:
            result['TagSet'] = self.tag_set.to_map()
        else:
            result['TagSet'] = None
        return result

    def from_map(self, map={}):
        if map.get('TagSet') is not None:
            temp_model = PutObjectTaggingRequestBodyTaggingTagSet()
            self.tag_set = temp_model.from_map(map['TagSet'])
        else:
            self.tag_set = None
        return self


class PutObjectTaggingRequestBody(TeaModel):
    def __init__(self, tagging=None):
        self.tagging = tagging

    def validate(self):
        self.validate_required(self.tagging, 'tagging')
        if self.tagging:
            self.tagging.validate()

    def to_map(self):
        result = {}
        if self.tagging is not None:
            result['Tagging'] = self.tagging.to_map()
        else:
            result['Tagging'] = None
        return result

    def from_map(self, map={}):
        if map.get('Tagging') is not None:
            temp_model = PutObjectTaggingRequestBodyTagging()
            self.tagging = temp_model.from_map(map['Tagging'])
        else:
            self.tagging = None
        return self


class PutObjectTaggingResponse(TeaModel):
    def __init__(self, request_id=None):
        self.request_id = request_id

    def validate(self):
        self.validate_required(self.request_id, 'request_id')

    def to_map(self):
        result = {}
        result['x-oss-request-id'] = self.request_id
        return result

    def from_map(self, map={}):
        self.request_id = map.get('x-oss-request-id')
        return self


class SelectObjectRequest(TeaModel):
    def __init__(self, bucket_name=None, object_name=None, filter=None, body=None):
        self.bucket_name = bucket_name
        self.object_name = object_name
        self.filter = filter
        self.body = body

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')
        self.validate_required(self.object_name, 'object_name')
        self.validate_required(self.filter, 'filter')
        if self.filter:
            self.filter.validate()
        if self.body:
            self.body.validate()

    def to_map(self):
        result = {}
        result['BucketName'] = self.bucket_name
        result['ObjectName'] = self.object_name
        if self.filter is not None:
            result['Filter'] = self.filter.to_map()
        else:
            result['Filter'] = None
        if self.body is not None:
            result['Body'] = self.body.to_map()
        else:
            result['Body'] = None
        return result

    def from_map(self, map={}):
        self.bucket_name = map.get('BucketName')
        self.object_name = map.get('ObjectName')
        if map.get('Filter') is not None:
            temp_model = SelectObjectRequestFilter()
            self.filter = temp_model.from_map(map['Filter'])
        else:
            self.filter = None
        if map.get('Body') is not None:
            temp_model = SelectObjectRequestBody()
            self.body = temp_model.from_map(map['Body'])
        else:
            self.body = None
        return self


class SelectObjectRequestFilter(TeaModel):
    def __init__(self, porcess=None):
        self.porcess = porcess

    def validate(self):
        self.validate_required(self.porcess, 'porcess')

    def to_map(self):
        result = {}
        result['x-oss-process'] = self.porcess
        return result

    def from_map(self, map={}):
        self.porcess = map.get('x-oss-process')
        return self


class SelectObjectRequestBodySelectRequestInputSerializationCSV(TeaModel):
    def __init__(self, file_header_info=None, record_delimiter=None, field_delimiter=None, quote_character=None, comment_character=None, range=None):
        self.file_header_info = file_header_info
        self.record_delimiter = record_delimiter
        self.field_delimiter = field_delimiter
        self.quote_character = quote_character
        self.comment_character = comment_character
        self.range = range

    def validate(self):
        pass

    def to_map(self):
        result = {}
        result['FileHeaderInfo'] = self.file_header_info
        result['RecordDelimiter'] = self.record_delimiter
        result['FieldDelimiter'] = self.field_delimiter
        result['QuoteCharacter'] = self.quote_character
        result['CommentCharacter'] = self.comment_character
        result['Range'] = self.range
        return result

    def from_map(self, map={}):
        self.file_header_info = map.get('FileHeaderInfo')
        self.record_delimiter = map.get('RecordDelimiter')
        self.field_delimiter = map.get('FieldDelimiter')
        self.quote_character = map.get('QuoteCharacter')
        self.comment_character = map.get('CommentCharacter')
        self.range = map.get('Range')
        return self


class SelectObjectRequestBodySelectRequestInputSerialization(TeaModel):
    def __init__(self, c_sv=None, compression_type=None):
        self.c_sv = c_sv
        self.compression_type = compression_type

    def validate(self):
        if self.c_sv:
            self.c_sv.validate()

    def to_map(self):
        result = {}
        if self.c_sv is not None:
            result['CSV'] = self.c_sv.to_map()
        else:
            result['CSV'] = None
        result['CompressionType'] = self.compression_type
        return result

    def from_map(self, map={}):
        if map.get('CSV') is not None:
            temp_model = SelectObjectRequestBodySelectRequestInputSerializationCSV()
            self.c_sv = temp_model.from_map(map['CSV'])
        else:
            self.c_sv = None
        self.compression_type = map.get('CompressionType')
        return self


class SelectObjectRequestBodySelectRequestOutputSerializationCSV(TeaModel):
    def __init__(self, record_delimiter=None, field_delimiter=None):
        self.record_delimiter = record_delimiter
        self.field_delimiter = field_delimiter

    def validate(self):
        pass

    def to_map(self):
        result = {}
        result['RecordDelimiter'] = self.record_delimiter
        result['FieldDelimiter'] = self.field_delimiter
        return result

    def from_map(self, map={}):
        self.record_delimiter = map.get('RecordDelimiter')
        self.field_delimiter = map.get('FieldDelimiter')
        return self


class SelectObjectRequestBodySelectRequestOutputSerialization(TeaModel):
    def __init__(self, c_sv=None, keep_all_columns=None, output_raw_data=None, enable_payload_crc=None, output_header=None):
        self.c_sv = c_sv
        self.keep_all_columns = keep_all_columns
        self.output_raw_data = output_raw_data
        self.enable_payload_crc = enable_payload_crc
        self.output_header = output_header

    def validate(self):
        if self.c_sv:
            self.c_sv.validate()

    def to_map(self):
        result = {}
        if self.c_sv is not None:
            result['CSV'] = self.c_sv.to_map()
        else:
            result['CSV'] = None
        result['KeepAllColumns'] = self.keep_all_columns
        result['OutputRawData'] = self.output_raw_data
        result['EnablePayloadCrc'] = self.enable_payload_crc
        result['OutputHeader'] = self.output_header
        return result

    def from_map(self, map={}):
        if map.get('CSV') is not None:
            temp_model = SelectObjectRequestBodySelectRequestOutputSerializationCSV()
            self.c_sv = temp_model.from_map(map['CSV'])
        else:
            self.c_sv = None
        self.keep_all_columns = map.get('KeepAllColumns')
        self.output_raw_data = map.get('OutputRawData')
        self.enable_payload_crc = map.get('EnablePayloadCrc')
        self.output_header = map.get('OutputHeader')
        return self


class SelectObjectRequestBodySelectRequestOptions(TeaModel):
    def __init__(self, skip_partial_data_record=None, max_skipped_records_allowed=None):
        self.skip_partial_data_record = skip_partial_data_record
        self.max_skipped_records_allowed = max_skipped_records_allowed

    def validate(self):
        pass

    def to_map(self):
        result = {}
        result['SkipPartialDataRecord'] = self.skip_partial_data_record
        result['MaxSkippedRecordsAllowed'] = self.max_skipped_records_allowed
        return result

    def from_map(self, map={}):
        self.skip_partial_data_record = map.get('SkipPartialDataRecord')
        self.max_skipped_records_allowed = map.get('MaxSkippedRecordsAllowed')
        return self


class SelectObjectRequestBodySelectRequest(TeaModel):
    def __init__(self, input_serialization=None, output_serialization=None, options=None, expression=None):
        self.input_serialization = input_serialization
        self.output_serialization = output_serialization
        self.options = options
        self.expression = expression

    def validate(self):
        if self.input_serialization:
            self.input_serialization.validate()
        if self.output_serialization:
            self.output_serialization.validate()
        if self.options:
            self.options.validate()

    def to_map(self):
        result = {}
        if self.input_serialization is not None:
            result['InputSerialization'] = self.input_serialization.to_map()
        else:
            result['InputSerialization'] = None
        if self.output_serialization is not None:
            result['OutputSerialization'] = self.output_serialization.to_map()
        else:
            result['OutputSerialization'] = None
        if self.options is not None:
            result['Options'] = self.options.to_map()
        else:
            result['Options'] = None
        result['Expression'] = self.expression
        return result

    def from_map(self, map={}):
        if map.get('InputSerialization') is not None:
            temp_model = SelectObjectRequestBodySelectRequestInputSerialization()
            self.input_serialization = temp_model.from_map(map['InputSerialization'])
        else:
            self.input_serialization = None
        if map.get('OutputSerialization') is not None:
            temp_model = SelectObjectRequestBodySelectRequestOutputSerialization()
            self.output_serialization = temp_model.from_map(map['OutputSerialization'])
        else:
            self.output_serialization = None
        if map.get('Options') is not None:
            temp_model = SelectObjectRequestBodySelectRequestOptions()
            self.options = temp_model.from_map(map['Options'])
        else:
            self.options = None
        self.expression = map.get('Expression')
        return self


class SelectObjectRequestBody(TeaModel):
    def __init__(self, select_request=None):
        self.select_request = select_request

    def validate(self):
        self.validate_required(self.select_request, 'select_request')
        if self.select_request:
            self.select_request.validate()

    def to_map(self):
        result = {}
        if self.select_request is not None:
            result['SelectRequest'] = self.select_request.to_map()
        else:
            result['SelectRequest'] = None
        return result

    def from_map(self, map={}):
        if map.get('SelectRequest') is not None:
            temp_model = SelectObjectRequestBodySelectRequest()
            self.select_request = temp_model.from_map(map['SelectRequest'])
        else:
            self.select_request = None
        return self


class SelectObjectResponse(TeaModel):
    def __init__(self, request_id=None):
        self.request_id = request_id

    def validate(self):
        self.validate_required(self.request_id, 'request_id')

    def to_map(self):
        result = {}
        result['x-oss-request-id'] = self.request_id
        return result

    def from_map(self, map={}):
        self.request_id = map.get('x-oss-request-id')
        return self


class PutBucketCORSRequest(TeaModel):
    def __init__(self, bucket_name=None, body=None):
        self.bucket_name = bucket_name
        self.body = body

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = {}
        result['BucketName'] = self.bucket_name
        if self.body is not None:
            result['Body'] = self.body.to_map()
        else:
            result['Body'] = None
        return result

    def from_map(self, map={}):
        self.bucket_name = map.get('BucketName')
        if map.get('Body') is not None:
            temp_model = PutBucketCORSRequestBody()
            self.body = temp_model.from_map(map['Body'])
        else:
            self.body = None
        return self


class PutBucketCORSRequestBodyCORSConfigurationCORSRule(TeaModel):
    def __init__(self, allowed_origin=None, allowed_method=None, allowed_header=None, expose_header=None, max_age_seconds=None):
        self.allowed_origin = []
        self.allowed_method = []
        self.allowed_header = []
        self.expose_header = []
        self.max_age_seconds = max_age_seconds

    def validate(self):
        pass

    def to_map(self):
        result = {}
        result['AllowedOrigin'] = []
        if self.allowed_origin is not None:
            for k in self.allowed_origin:
                result['AllowedOrigin'].append(k)
        else:
            result['AllowedOrigin'] = None
        result['AllowedMethod'] = []
        if self.allowed_method is not None:
            for k in self.allowed_method:
                result['AllowedMethod'].append(k)
        else:
            result['AllowedMethod'] = None
        result['AllowedHeader'] = []
        if self.allowed_header is not None:
            for k in self.allowed_header:
                result['AllowedHeader'].append(k)
        else:
            result['AllowedHeader'] = None
        result['ExposeHeader'] = []
        if self.expose_header is not None:
            for k in self.expose_header:
                result['ExposeHeader'].append(k)
        else:
            result['ExposeHeader'] = None
        result['MaxAgeSeconds'] = self.max_age_seconds
        return result

    def from_map(self, map={}):
        self.allowed_origin = []
        if map.get('AllowedOrigin') is not None:
            for k in map.get('AllowedOrigin'):
                self.allowed_origin.append(k)
        else:
            self.allowed_origin = None
        self.allowed_method = []
        if map.get('AllowedMethod') is not None:
            for k in map.get('AllowedMethod'):
                self.allowed_method.append(k)
        else:
            self.allowed_method = None
        self.allowed_header = []
        if map.get('AllowedHeader') is not None:
            for k in map.get('AllowedHeader'):
                self.allowed_header.append(k)
        else:
            self.allowed_header = None
        self.expose_header = []
        if map.get('ExposeHeader') is not None:
            for k in map.get('ExposeHeader'):
                self.expose_header.append(k)
        else:
            self.expose_header = None
        self.max_age_seconds = map.get('MaxAgeSeconds')
        return self


class PutBucketCORSRequestBodyCORSConfiguration(TeaModel):
    def __init__(self, c_orsrule=None):
        self.c_orsrule = []

    def validate(self):
        if self.c_orsrule:
            for k in self.c_orsrule:
                if k :
                    k.validate()

    def to_map(self):
        result = {}
        result['CORSRule'] = []
        if self.c_orsrule is not None:
            for k in self.c_orsrule:
                result['CORSRule'].append(k.to_map() if k else None)
        else:
            result['CORSRule'] = None
        return result

    def from_map(self, map={}):
        self.c_orsrule = []
        if map.get('CORSRule') is not None:
            for k in map.get('CORSRule'):
                temp_model = PutBucketCORSRequestBodyCORSConfigurationCORSRule()
                temp_model = temp_model.from_map(k)
                self.c_orsrule.append(temp_model)
        else:
            self.c_orsrule = None
        return self


class PutBucketCORSRequestBody(TeaModel):
    def __init__(self, c_orsconfiguration=None):
        self.c_orsconfiguration = c_orsconfiguration

    def validate(self):
        self.validate_required(self.c_orsconfiguration, 'c_orsconfiguration')
        if self.c_orsconfiguration:
            self.c_orsconfiguration.validate()

    def to_map(self):
        result = {}
        if self.c_orsconfiguration is not None:
            result['CORSConfiguration'] = self.c_orsconfiguration.to_map()
        else:
            result['CORSConfiguration'] = None
        return result

    def from_map(self, map={}):
        if map.get('CORSConfiguration') is not None:
            temp_model = PutBucketCORSRequestBodyCORSConfiguration()
            self.c_orsconfiguration = temp_model.from_map(map['CORSConfiguration'])
        else:
            self.c_orsconfiguration = None
        return self


class PutBucketCORSResponse(TeaModel):
    def __init__(self, request_id=None):
        self.request_id = request_id

    def validate(self):
        self.validate_required(self.request_id, 'request_id')

    def to_map(self):
        result = {}
        result['x-oss-request-id'] = self.request_id
        return result

    def from_map(self, map={}):
        self.request_id = map.get('x-oss-request-id')
        return self


class PutBucketRequest(TeaModel):
    def __init__(self, bucket_name=None, body=None, header=None):
        self.bucket_name = bucket_name
        self.body = body
        self.header = header

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')
        if self.body:
            self.body.validate()
        if self.header:
            self.header.validate()

    def to_map(self):
        result = {}
        result['BucketName'] = self.bucket_name
        if self.body is not None:
            result['Body'] = self.body.to_map()
        else:
            result['Body'] = None
        if self.header is not None:
            result['Header'] = self.header.to_map()
        else:
            result['Header'] = None
        return result

    def from_map(self, map={}):
        self.bucket_name = map.get('BucketName')
        if map.get('Body') is not None:
            temp_model = PutBucketRequestBody()
            self.body = temp_model.from_map(map['Body'])
        else:
            self.body = None
        if map.get('Header') is not None:
            temp_model = PutBucketRequestHeader()
            self.header = temp_model.from_map(map['Header'])
        else:
            self.header = None
        return self


class PutBucketRequestBodyCreateBucketConfiguration(TeaModel):
    def __init__(self, storage_class=None, data_redundancy_type=None):
        self.storage_class = storage_class
        self.data_redundancy_type = data_redundancy_type

    def validate(self):
        pass

    def to_map(self):
        result = {}
        result['StorageClass'] = self.storage_class
        result['DataRedundancyType'] = self.data_redundancy_type
        return result

    def from_map(self, map={}):
        self.storage_class = map.get('StorageClass')
        self.data_redundancy_type = map.get('DataRedundancyType')
        return self


class PutBucketRequestBody(TeaModel):
    def __init__(self, create_bucket_configuration=None):
        self.create_bucket_configuration = create_bucket_configuration

    def validate(self):
        self.validate_required(self.create_bucket_configuration, 'create_bucket_configuration')
        if self.create_bucket_configuration:
            self.create_bucket_configuration.validate()

    def to_map(self):
        result = {}
        if self.create_bucket_configuration is not None:
            result['CreateBucketConfiguration'] = self.create_bucket_configuration.to_map()
        else:
            result['CreateBucketConfiguration'] = None
        return result

    def from_map(self, map={}):
        if map.get('CreateBucketConfiguration') is not None:
            temp_model = PutBucketRequestBodyCreateBucketConfiguration()
            self.create_bucket_configuration = temp_model.from_map(map['CreateBucketConfiguration'])
        else:
            self.create_bucket_configuration = None
        return self


class PutBucketRequestHeader(TeaModel):
    def __init__(self, acl=None):
        self.acl = acl

    def validate(self):
        pass

    def to_map(self):
        result = {}
        result['x-oss-acl'] = self.acl
        return result

    def from_map(self, map={}):
        self.acl = map.get('x-oss-acl')
        return self


class PutBucketResponse(TeaModel):
    def __init__(self, request_id=None):
        self.request_id = request_id

    def validate(self):
        self.validate_required(self.request_id, 'request_id')

    def to_map(self):
        result = {}
        result['x-oss-request-id'] = self.request_id
        return result

    def from_map(self, map={}):
        self.request_id = map.get('x-oss-request-id')
        return self


class ListMultipartUploadsRequest(TeaModel):
    def __init__(self, bucket_name=None, filter=None):
        self.bucket_name = bucket_name
        self.filter = filter

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')
        if self.filter:
            self.filter.validate()

    def to_map(self):
        result = {}
        result['BucketName'] = self.bucket_name
        if self.filter is not None:
            result['Filter'] = self.filter.to_map()
        else:
            result['Filter'] = None
        return result

    def from_map(self, map={}):
        self.bucket_name = map.get('BucketName')
        if map.get('Filter') is not None:
            temp_model = ListMultipartUploadsRequestFilter()
            self.filter = temp_model.from_map(map['Filter'])
        else:
            self.filter = None
        return self


class ListMultipartUploadsRequestFilter(TeaModel):
    def __init__(self, delimiter=None, max_uploads=None, key_marker=None, prefix=None, upload_id_marker=None, encoding_type=None):
        self.delimiter = delimiter
        self.max_uploads = max_uploads
        self.key_marker = key_marker
        self.prefix = prefix
        self.upload_id_marker = upload_id_marker
        self.encoding_type = encoding_type

    def validate(self):
        pass

    def to_map(self):
        result = {}
        result['delimiter'] = self.delimiter
        result['max-uploads'] = self.max_uploads
        result['key-marker'] = self.key_marker
        result['prefix'] = self.prefix
        result['upload-id-marker'] = self.upload_id_marker
        result['encoding-type'] = self.encoding_type
        return result

    def from_map(self, map={}):
        self.delimiter = map.get('delimiter')
        self.max_uploads = map.get('max-uploads')
        self.key_marker = map.get('key-marker')
        self.prefix = map.get('prefix')
        self.upload_id_marker = map.get('upload-id-marker')
        self.encoding_type = map.get('encoding-type')
        return self


class ListMultipartUploadsResponse(TeaModel):
    def __init__(self, request_id=None, list_multipart_uploads_result=None):
        self.request_id = request_id
        self.list_multipart_uploads_result = list_multipart_uploads_result

    def validate(self):
        self.validate_required(self.request_id, 'request_id')
        self.validate_required(self.list_multipart_uploads_result, 'list_multipart_uploads_result')
        if self.list_multipart_uploads_result:
            self.list_multipart_uploads_result.validate()

    def to_map(self):
        result = {}
        result['x-oss-request-id'] = self.request_id
        if self.list_multipart_uploads_result is not None:
            result['ListMultipartUploadsResult'] = self.list_multipart_uploads_result.to_map()
        else:
            result['ListMultipartUploadsResult'] = None
        return result

    def from_map(self, map={}):
        self.request_id = map.get('x-oss-request-id')
        if map.get('ListMultipartUploadsResult') is not None:
            temp_model = ListMultipartUploadsResponseListMultipartUploadsResult()
            self.list_multipart_uploads_result = temp_model.from_map(map['ListMultipartUploadsResult'])
        else:
            self.list_multipart_uploads_result = None
        return self


class ListMultipartUploadsResponseListMultipartUploadsResultUpload(TeaModel):
    def __init__(self, key=None, upload_id=None, initiated=None):
        self.key = key
        self.upload_id = upload_id
        self.initiated = initiated

    def validate(self):
        pass

    def to_map(self):
        result = {}
        result['Key'] = self.key
        result['UploadId'] = self.upload_id
        result['Initiated'] = self.initiated
        return result

    def from_map(self, map={}):
        self.key = map.get('Key')
        self.upload_id = map.get('UploadId')
        self.initiated = map.get('Initiated')
        return self


class ListMultipartUploadsResponseListMultipartUploadsResult(TeaModel):
    def __init__(self, bucket=None, encoding_type=None, key_marker=None, upload_id_marker=None, next_key_marker=None, next_upload_id_marker=None, delimiter=None, max_uploads=None, is_truncated=None, upload=None):
        self.bucket = bucket
        self.encoding_type = encoding_type
        self.key_marker = key_marker
        self.upload_id_marker = upload_id_marker
        self.next_key_marker = next_key_marker
        self.next_upload_id_marker = next_upload_id_marker
        self.delimiter = delimiter
        self.max_uploads = max_uploads
        self.is_truncated = is_truncated
        self.upload = []

    def validate(self):
        if self.upload:
            for k in self.upload:
                if k :
                    k.validate()

    def to_map(self):
        result = {}
        result['Bucket'] = self.bucket
        result['EncodingType'] = self.encoding_type
        result['KeyMarker'] = self.key_marker
        result['UploadIdMarker'] = self.upload_id_marker
        result['NextKeyMarker'] = self.next_key_marker
        result['NextUploadIdMarker'] = self.next_upload_id_marker
        result['Delimiter'] = self.delimiter
        result['MaxUploads'] = self.max_uploads
        result['IsTruncated'] = self.is_truncated
        result['Upload'] = []
        if self.upload is not None:
            for k in self.upload:
                result['Upload'].append(k.to_map() if k else None)
        else:
            result['Upload'] = None
        return result

    def from_map(self, map={}):
        self.bucket = map.get('Bucket')
        self.encoding_type = map.get('EncodingType')
        self.key_marker = map.get('KeyMarker')
        self.upload_id_marker = map.get('UploadIdMarker')
        self.next_key_marker = map.get('NextKeyMarker')
        self.next_upload_id_marker = map.get('NextUploadIdMarker')
        self.delimiter = map.get('Delimiter')
        self.max_uploads = map.get('MaxUploads')
        self.is_truncated = map.get('IsTruncated')
        self.upload = []
        if map.get('Upload') is not None:
            for k in map.get('Upload'):
                temp_model = ListMultipartUploadsResponseListMultipartUploadsResultUpload()
                temp_model = temp_model.from_map(k)
                self.upload.append(temp_model)
        else:
            self.upload = None
        return self


class GetBucketRequestPaymentRequest(TeaModel):
    def __init__(self, bucket_name=None):
        self.bucket_name = bucket_name

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')

    def to_map(self):
        result = {}
        result['BucketName'] = self.bucket_name
        return result

    def from_map(self, map={}):
        self.bucket_name = map.get('BucketName')
        return self


class GetBucketRequestPaymentResponse(TeaModel):
    def __init__(self, request_id=None, request_payment_configuration=None):
        self.request_id = request_id
        self.request_payment_configuration = request_payment_configuration

    def validate(self):
        self.validate_required(self.request_id, 'request_id')
        self.validate_required(self.request_payment_configuration, 'request_payment_configuration')
        if self.request_payment_configuration:
            self.request_payment_configuration.validate()

    def to_map(self):
        result = {}
        result['x-oss-request-id'] = self.request_id
        if self.request_payment_configuration is not None:
            result['RequestPaymentConfiguration'] = self.request_payment_configuration.to_map()
        else:
            result['RequestPaymentConfiguration'] = None
        return result

    def from_map(self, map={}):
        self.request_id = map.get('x-oss-request-id')
        if map.get('RequestPaymentConfiguration') is not None:
            temp_model = GetBucketRequestPaymentResponseRequestPaymentConfiguration()
            self.request_payment_configuration = temp_model.from_map(map['RequestPaymentConfiguration'])
        else:
            self.request_payment_configuration = None
        return self


class GetBucketRequestPaymentResponseRequestPaymentConfiguration(TeaModel):
    def __init__(self, payer=None):
        self.payer = payer

    def validate(self):
        pass

    def to_map(self):
        result = {}
        result['Payer'] = self.payer
        return result

    def from_map(self, map={}):
        self.payer = map.get('Payer')
        return self


class GetBucketEncryptionRequest(TeaModel):
    def __init__(self, bucket_name=None):
        self.bucket_name = bucket_name

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')

    def to_map(self):
        result = {}
        result['BucketName'] = self.bucket_name
        return result

    def from_map(self, map={}):
        self.bucket_name = map.get('BucketName')
        return self


class GetBucketEncryptionResponse(TeaModel):
    def __init__(self, request_id=None, server_side_encryption_rule=None):
        self.request_id = request_id
        self.server_side_encryption_rule = server_side_encryption_rule

    def validate(self):
        self.validate_required(self.request_id, 'request_id')
        self.validate_required(self.server_side_encryption_rule, 'server_side_encryption_rule')
        if self.server_side_encryption_rule:
            self.server_side_encryption_rule.validate()

    def to_map(self):
        result = {}
        result['x-oss-request-id'] = self.request_id
        if self.server_side_encryption_rule is not None:
            result['ServerSideEncryptionRule'] = self.server_side_encryption_rule.to_map()
        else:
            result['ServerSideEncryptionRule'] = None
        return result

    def from_map(self, map={}):
        self.request_id = map.get('x-oss-request-id')
        if map.get('ServerSideEncryptionRule') is not None:
            temp_model = GetBucketEncryptionResponseServerSideEncryptionRule()
            self.server_side_encryption_rule = temp_model.from_map(map['ServerSideEncryptionRule'])
        else:
            self.server_side_encryption_rule = None
        return self


class GetBucketEncryptionResponseServerSideEncryptionRuleApplyServerSideEncryptionByDefault(TeaModel):
    def __init__(self, s_sealgorithm=None, k_msmaster_key_id=None):
        self.s_sealgorithm = s_sealgorithm
        self.k_msmaster_key_id = k_msmaster_key_id

    def validate(self):
        pass

    def to_map(self):
        result = {}
        result['SSEAlgorithm'] = self.s_sealgorithm
        result['KMSMasterKeyID'] = self.k_msmaster_key_id
        return result

    def from_map(self, map={}):
        self.s_sealgorithm = map.get('SSEAlgorithm')
        self.k_msmaster_key_id = map.get('KMSMasterKeyID')
        return self


class GetBucketEncryptionResponseServerSideEncryptionRule(TeaModel):
    def __init__(self, apply_server_side_encryption_by_default=None):
        self.apply_server_side_encryption_by_default = apply_server_side_encryption_by_default

    def validate(self):
        self.validate_required(self.apply_server_side_encryption_by_default, 'apply_server_side_encryption_by_default')
        if self.apply_server_side_encryption_by_default:
            self.apply_server_side_encryption_by_default.validate()

    def to_map(self):
        result = {}
        if self.apply_server_side_encryption_by_default is not None:
            result['ApplyServerSideEncryptionByDefault'] = self.apply_server_side_encryption_by_default.to_map()
        else:
            result['ApplyServerSideEncryptionByDefault'] = None
        return result

    def from_map(self, map={}):
        if map.get('ApplyServerSideEncryptionByDefault') is not None:
            temp_model = GetBucketEncryptionResponseServerSideEncryptionRuleApplyServerSideEncryptionByDefault()
            self.apply_server_side_encryption_by_default = temp_model.from_map(map['ApplyServerSideEncryptionByDefault'])
        else:
            self.apply_server_side_encryption_by_default = None
        return self


class GetBucketTagsRequest(TeaModel):
    def __init__(self, bucket_name=None):
        self.bucket_name = bucket_name

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')

    def to_map(self):
        result = {}
        result['BucketName'] = self.bucket_name
        return result

    def from_map(self, map={}):
        self.bucket_name = map.get('BucketName')
        return self


class GetBucketTagsResponse(TeaModel):
    def __init__(self, request_id=None, tagging=None):
        self.request_id = request_id
        self.tagging = tagging

    def validate(self):
        self.validate_required(self.request_id, 'request_id')
        self.validate_required(self.tagging, 'tagging')
        if self.tagging:
            self.tagging.validate()

    def to_map(self):
        result = {}
        result['x-oss-request-id'] = self.request_id
        if self.tagging is not None:
            result['Tagging'] = self.tagging.to_map()
        else:
            result['Tagging'] = None
        return result

    def from_map(self, map={}):
        self.request_id = map.get('x-oss-request-id')
        if map.get('Tagging') is not None:
            temp_model = GetBucketTagsResponseTagging()
            self.tagging = temp_model.from_map(map['Tagging'])
        else:
            self.tagging = None
        return self


class GetBucketTagsResponseTaggingTagSetTag(TeaModel):
    def __init__(self, key=None, value=None):
        self.key = key
        self.value = value

    def validate(self):
        pass

    def to_map(self):
        result = {}
        result['Key'] = self.key
        result['Value'] = self.value
        return result

    def from_map(self, map={}):
        self.key = map.get('Key')
        self.value = map.get('Value')
        return self


class GetBucketTagsResponseTaggingTagSet(TeaModel):
    def __init__(self, tag=None):
        self.tag = []

    def validate(self):
        if self.tag:
            for k in self.tag:
                if k :
                    k.validate()

    def to_map(self):
        result = {}
        result['Tag'] = []
        if self.tag is not None:
            for k in self.tag:
                result['Tag'].append(k.to_map() if k else None)
        else:
            result['Tag'] = None
        return result

    def from_map(self, map={}):
        self.tag = []
        if map.get('Tag') is not None:
            for k in map.get('Tag'):
                temp_model = GetBucketTagsResponseTaggingTagSetTag()
                temp_model = temp_model.from_map(k)
                self.tag.append(temp_model)
        else:
            self.tag = None
        return self


class GetBucketTagsResponseTagging(TeaModel):
    def __init__(self, tag_set=None):
        self.tag_set = tag_set

    def validate(self):
        self.validate_required(self.tag_set, 'tag_set')
        if self.tag_set:
            self.tag_set.validate()

    def to_map(self):
        result = {}
        if self.tag_set is not None:
            result['TagSet'] = self.tag_set.to_map()
        else:
            result['TagSet'] = None
        return result

    def from_map(self, map={}):
        if map.get('TagSet') is not None:
            temp_model = GetBucketTagsResponseTaggingTagSet()
            self.tag_set = temp_model.from_map(map['TagSet'])
        else:
            self.tag_set = None
        return self


class GetServiceRequest(TeaModel):
    def __init__(self, filter=None):
        self.filter = filter

    def validate(self):
        if self.filter:
            self.filter.validate()

    def to_map(self):
        result = {}
        if self.filter is not None:
            result['Filter'] = self.filter.to_map()
        else:
            result['Filter'] = None
        return result

    def from_map(self, map={}):
        if map.get('Filter') is not None:
            temp_model = GetServiceRequestFilter()
            self.filter = temp_model.from_map(map['Filter'])
        else:
            self.filter = None
        return self


class GetServiceRequestFilter(TeaModel):
    def __init__(self, prefix=None, marker=None, max_keys=None):
        self.prefix = prefix
        self.marker = marker
        self.max_keys = max_keys

    def validate(self):
        pass

    def to_map(self):
        result = {}
        result['prefix'] = self.prefix
        result['marker'] = self.marker
        result['max-keys'] = self.max_keys
        return result

    def from_map(self, map={}):
        self.prefix = map.get('prefix')
        self.marker = map.get('marker')
        self.max_keys = map.get('max-keys')
        return self


class GetServiceResponse(TeaModel):
    def __init__(self, request_id=None, list_all_my_buckets_result=None):
        self.request_id = request_id
        self.list_all_my_buckets_result = list_all_my_buckets_result

    def validate(self):
        self.validate_required(self.request_id, 'request_id')
        self.validate_required(self.list_all_my_buckets_result, 'list_all_my_buckets_result')
        if self.list_all_my_buckets_result:
            self.list_all_my_buckets_result.validate()

    def to_map(self):
        result = {}
        result['x-oss-request-id'] = self.request_id
        if self.list_all_my_buckets_result is not None:
            result['ListAllMyBucketsResult'] = self.list_all_my_buckets_result.to_map()
        else:
            result['ListAllMyBucketsResult'] = None
        return result

    def from_map(self, map={}):
        self.request_id = map.get('x-oss-request-id')
        if map.get('ListAllMyBucketsResult') is not None:
            temp_model = GetServiceResponseListAllMyBucketsResult()
            self.list_all_my_buckets_result = temp_model.from_map(map['ListAllMyBucketsResult'])
        else:
            self.list_all_my_buckets_result = None
        return self


class GetServiceResponseListAllMyBucketsResultOwner(TeaModel):
    def __init__(self, i_d=None, display_name=None):
        self.i_d = i_d
        self.display_name = display_name

    def validate(self):
        pass

    def to_map(self):
        result = {}
        result['ID'] = self.i_d
        result['DisplayName'] = self.display_name
        return result

    def from_map(self, map={}):
        self.i_d = map.get('ID')
        self.display_name = map.get('DisplayName')
        return self


class GetServiceResponseListAllMyBucketsResultBucketsBucket(TeaModel):
    def __init__(self, name=None, create_date=None, location=None, extranet_endpoint=None, intranet_endpoint=None, storage_class=None):
        self.name = name
        self.create_date = create_date
        self.location = location
        self.extranet_endpoint = extranet_endpoint
        self.intranet_endpoint = intranet_endpoint
        self.storage_class = storage_class

    def validate(self):
        pass

    def to_map(self):
        result = {}
        result['Name'] = self.name
        result['CreateDate'] = self.create_date
        result['Location'] = self.location
        result['ExtranetEndpoint'] = self.extranet_endpoint
        result['IntranetEndpoint'] = self.intranet_endpoint
        result['StorageClass'] = self.storage_class
        return result

    def from_map(self, map={}):
        self.name = map.get('Name')
        self.create_date = map.get('CreateDate')
        self.location = map.get('Location')
        self.extranet_endpoint = map.get('ExtranetEndpoint')
        self.intranet_endpoint = map.get('IntranetEndpoint')
        self.storage_class = map.get('StorageClass')
        return self


class GetServiceResponseListAllMyBucketsResultBuckets(TeaModel):
    def __init__(self, bucket=None):
        self.bucket = []

    def validate(self):
        if self.bucket:
            for k in self.bucket:
                if k :
                    k.validate()

    def to_map(self):
        result = {}
        result['Bucket'] = []
        if self.bucket is not None:
            for k in self.bucket:
                result['Bucket'].append(k.to_map() if k else None)
        else:
            result['Bucket'] = None
        return result

    def from_map(self, map={}):
        self.bucket = []
        if map.get('Bucket') is not None:
            for k in map.get('Bucket'):
                temp_model = GetServiceResponseListAllMyBucketsResultBucketsBucket()
                temp_model = temp_model.from_map(k)
                self.bucket.append(temp_model)
        else:
            self.bucket = None
        return self


class GetServiceResponseListAllMyBucketsResult(TeaModel):
    def __init__(self, prefix=None, marker=None, max_keys=None, is_truncated=None, next_marker=None, owner=None, buckets=None):
        self.prefix = prefix
        self.marker = marker
        self.max_keys = max_keys
        self.is_truncated = is_truncated
        self.next_marker = next_marker
        self.owner = owner
        self.buckets = buckets

    def validate(self):
        self.validate_required(self.owner, 'owner')
        if self.owner:
            self.owner.validate()
        self.validate_required(self.buckets, 'buckets')
        if self.buckets:
            self.buckets.validate()

    def to_map(self):
        result = {}
        result['Prefix'] = self.prefix
        result['Marker'] = self.marker
        result['MaxKeys'] = self.max_keys
        result['IsTruncated'] = self.is_truncated
        result['NextMarker'] = self.next_marker
        if self.owner is not None:
            result['Owner'] = self.owner.to_map()
        else:
            result['Owner'] = None
        if self.buckets is not None:
            result['Buckets'] = self.buckets.to_map()
        else:
            result['Buckets'] = None
        return result

    def from_map(self, map={}):
        self.prefix = map.get('Prefix')
        self.marker = map.get('Marker')
        self.max_keys = map.get('MaxKeys')
        self.is_truncated = map.get('IsTruncated')
        self.next_marker = map.get('NextMarker')
        if map.get('Owner') is not None:
            temp_model = GetServiceResponseListAllMyBucketsResultOwner()
            self.owner = temp_model.from_map(map['Owner'])
        else:
            self.owner = None
        if map.get('Buckets') is not None:
            temp_model = GetServiceResponseListAllMyBucketsResultBuckets()
            self.buckets = temp_model.from_map(map['Buckets'])
        else:
            self.buckets = None
        return self


class DeleteBucketEncryptionRequest(TeaModel):
    def __init__(self, bucket_name=None):
        self.bucket_name = bucket_name

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')

    def to_map(self):
        result = {}
        result['BucketName'] = self.bucket_name
        return result

    def from_map(self, map={}):
        self.bucket_name = map.get('BucketName')
        return self


class DeleteBucketEncryptionResponse(TeaModel):
    def __init__(self, request_id=None):
        self.request_id = request_id

    def validate(self):
        self.validate_required(self.request_id, 'request_id')

    def to_map(self):
        result = {}
        result['x-oss-request-id'] = self.request_id
        return result

    def from_map(self, map={}):
        self.request_id = map.get('x-oss-request-id')
        return self


class DeleteBucketTagsRequest(TeaModel):
    def __init__(self, bucket_name=None, filter=None):
        self.bucket_name = bucket_name
        self.filter = filter

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')
        self.validate_required(self.filter, 'filter')
        if self.filter:
            self.filter.validate()

    def to_map(self):
        result = {}
        result['BucketName'] = self.bucket_name
        if self.filter is not None:
            result['Filter'] = self.filter.to_map()
        else:
            result['Filter'] = None
        return result

    def from_map(self, map={}):
        self.bucket_name = map.get('BucketName')
        if map.get('Filter') is not None:
            temp_model = DeleteBucketTagsRequestFilter()
            self.filter = temp_model.from_map(map['Filter'])
        else:
            self.filter = None
        return self


class DeleteBucketTagsRequestFilter(TeaModel):
    def __init__(self, tagging=None):
        self.tagging = tagging

    def validate(self):
        self.validate_required(self.tagging, 'tagging')

    def to_map(self):
        result = {}
        result['tagging'] = self.tagging
        return result

    def from_map(self, map={}):
        self.tagging = map.get('tagging')
        return self


class DeleteBucketTagsResponse(TeaModel):
    def __init__(self, request_id=None):
        self.request_id = request_id

    def validate(self):
        self.validate_required(self.request_id, 'request_id')

    def to_map(self):
        result = {}
        result['x-oss-request-id'] = self.request_id
        return result

    def from_map(self, map={}):
        self.request_id = map.get('x-oss-request-id')
        return self


class GetBucketWebsiteRequest(TeaModel):
    def __init__(self, bucket_name=None):
        self.bucket_name = bucket_name

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')

    def to_map(self):
        result = {}
        result['BucketName'] = self.bucket_name
        return result

    def from_map(self, map={}):
        self.bucket_name = map.get('BucketName')
        return self


class GetBucketWebsiteResponse(TeaModel):
    def __init__(self, request_id=None, website_configuration=None):
        self.request_id = request_id
        self.website_configuration = website_configuration

    def validate(self):
        self.validate_required(self.request_id, 'request_id')
        self.validate_required(self.website_configuration, 'website_configuration')
        if self.website_configuration:
            self.website_configuration.validate()

    def to_map(self):
        result = {}
        result['x-oss-request-id'] = self.request_id
        if self.website_configuration is not None:
            result['WebsiteConfiguration'] = self.website_configuration.to_map()
        else:
            result['WebsiteConfiguration'] = None
        return result

    def from_map(self, map={}):
        self.request_id = map.get('x-oss-request-id')
        if map.get('WebsiteConfiguration') is not None:
            temp_model = GetBucketWebsiteResponseWebsiteConfiguration()
            self.website_configuration = temp_model.from_map(map['WebsiteConfiguration'])
        else:
            self.website_configuration = None
        return self


class GetBucketWebsiteResponseWebsiteConfigurationIndexDocument(TeaModel):
    def __init__(self, suffix=None):
        self.suffix = suffix

    def validate(self):
        pass

    def to_map(self):
        result = {}
        result['Suffix'] = self.suffix
        return result

    def from_map(self, map={}):
        self.suffix = map.get('Suffix')
        return self


class GetBucketWebsiteResponseWebsiteConfigurationErrorDocument(TeaModel):
    def __init__(self, key=None):
        self.key = key

    def validate(self):
        pass

    def to_map(self):
        result = {}
        result['Key'] = self.key
        return result

    def from_map(self, map={}):
        self.key = map.get('Key')
        return self


class GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleConditionIncludeHeader(TeaModel):
    def __init__(self, key=None, equals=None):
        self.key = key
        self.equals = equals

    def validate(self):
        pass

    def to_map(self):
        result = {}
        result['Key'] = self.key
        result['Equals'] = self.equals
        return result

    def from_map(self, map={}):
        self.key = map.get('Key')
        self.equals = map.get('Equals')
        return self


class GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleCondition(TeaModel):
    def __init__(self, key_prefix_equals=None, http_error_code_returned_equals=None, include_header=None):
        self.key_prefix_equals = key_prefix_equals
        self.http_error_code_returned_equals = http_error_code_returned_equals
        self.include_header = include_header

    def validate(self):
        self.validate_required(self.include_header, 'include_header')
        if self.include_header:
            self.include_header.validate()

    def to_map(self):
        result = {}
        result['KeyPrefixEquals'] = self.key_prefix_equals
        result['HttpErrorCodeReturnedEquals'] = self.http_error_code_returned_equals
        if self.include_header is not None:
            result['IncludeHeader'] = self.include_header.to_map()
        else:
            result['IncludeHeader'] = None
        return result

    def from_map(self, map={}):
        self.key_prefix_equals = map.get('KeyPrefixEquals')
        self.http_error_code_returned_equals = map.get('HttpErrorCodeReturnedEquals')
        if map.get('IncludeHeader') is not None:
            temp_model = GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleConditionIncludeHeader()
            self.include_header = temp_model.from_map(map['IncludeHeader'])
        else:
            self.include_header = None
        return self


class GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeadersSet(TeaModel):
    def __init__(self, key=None, value=None):
        self.key = key
        self.value = value

    def validate(self):
        pass

    def to_map(self):
        result = {}
        result['Key'] = self.key
        result['Value'] = self.value
        return result

    def from_map(self, map={}):
        self.key = map.get('Key')
        self.value = map.get('Value')
        return self


class GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeaders(TeaModel):
    def __init__(self, pass_all=None, pass_=None, remove=None, set=None):
        self.pass_all = pass_all
        self.pass_ = pass_
        self.remove = remove
        self.set = set

    def validate(self):
        self.validate_required(self.set, 'set')
        if self.set:
            self.set.validate()

    def to_map(self):
        result = {}
        result['PassAll'] = self.pass_all
        result['Pass'] = self.pass_
        result['Remove'] = self.remove
        if self.set is not None:
            result['Set'] = self.set.to_map()
        else:
            result['Set'] = None
        return result

    def from_map(self, map={}):
        self.pass_all = map.get('PassAll')
        self.pass_ = map.get('Pass')
        self.remove = map.get('Remove')
        if map.get('Set') is not None:
            temp_model = GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeadersSet()
            self.set = temp_model.from_map(map['Set'])
        else:
            self.set = None
        return self


class GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirect(TeaModel):
    def __init__(self, redirect_type=None, pass_query_string=None, mirror_url=None, mirror_pass_query_string=None, mirror_follow_redirect=None, mirror_check_md_5=None, protocol=None, host_name=None, http_redirect_code=None, replace_key_prefix_with=None, replace_key_with=None, mirror_headers=None):
        self.redirect_type = redirect_type
        self.pass_query_string = pass_query_string
        self.mirror_url = mirror_url
        self.mirror_pass_query_string = mirror_pass_query_string
        self.mirror_follow_redirect = mirror_follow_redirect
        self.mirror_check_md_5 = mirror_check_md_5
        self.protocol = protocol
        self.host_name = host_name
        self.http_redirect_code = http_redirect_code
        self.replace_key_prefix_with = replace_key_prefix_with
        self.replace_key_with = replace_key_with
        self.mirror_headers = mirror_headers

    def validate(self):
        self.validate_required(self.mirror_headers, 'mirror_headers')
        if self.mirror_headers:
            self.mirror_headers.validate()

    def to_map(self):
        result = {}
        result['RedirectType'] = self.redirect_type
        result['PassQueryString'] = self.pass_query_string
        result['MirrorURL'] = self.mirror_url
        result['MirrorPassQueryString'] = self.mirror_pass_query_string
        result['MirrorFollowRedirect'] = self.mirror_follow_redirect
        result['MirrorCheckMd5'] = self.mirror_check_md_5
        result['Protocol'] = self.protocol
        result['HostName'] = self.host_name
        result['HttpRedirectCode'] = self.http_redirect_code
        result['ReplaceKeyPrefixWith'] = self.replace_key_prefix_with
        result['ReplaceKeyWith'] = self.replace_key_with
        if self.mirror_headers is not None:
            result['MirrorHeaders'] = self.mirror_headers.to_map()
        else:
            result['MirrorHeaders'] = None
        return result

    def from_map(self, map={}):
        self.redirect_type = map.get('RedirectType')
        self.pass_query_string = map.get('PassQueryString')
        self.mirror_url = map.get('MirrorURL')
        self.mirror_pass_query_string = map.get('MirrorPassQueryString')
        self.mirror_follow_redirect = map.get('MirrorFollowRedirect')
        self.mirror_check_md_5 = map.get('MirrorCheckMd5')
        self.protocol = map.get('Protocol')
        self.host_name = map.get('HostName')
        self.http_redirect_code = map.get('HttpRedirectCode')
        self.replace_key_prefix_with = map.get('ReplaceKeyPrefixWith')
        self.replace_key_with = map.get('ReplaceKeyWith')
        if map.get('MirrorHeaders') is not None:
            temp_model = GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeaders()
            self.mirror_headers = temp_model.from_map(map['MirrorHeaders'])
        else:
            self.mirror_headers = None
        return self


class GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRule(TeaModel):
    def __init__(self, rule_number=None, condition=None, redirect=None):
        self.rule_number = rule_number
        self.condition = condition
        self.redirect = redirect

    def validate(self):
        self.validate_required(self.condition, 'condition')
        if self.condition:
            self.condition.validate()
        self.validate_required(self.redirect, 'redirect')
        if self.redirect:
            self.redirect.validate()

    def to_map(self):
        result = {}
        result['RuleNumber'] = self.rule_number
        if self.condition is not None:
            result['Condition'] = self.condition.to_map()
        else:
            result['Condition'] = None
        if self.redirect is not None:
            result['Redirect'] = self.redirect.to_map()
        else:
            result['Redirect'] = None
        return result

    def from_map(self, map={}):
        self.rule_number = map.get('RuleNumber')
        if map.get('Condition') is not None:
            temp_model = GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleCondition()
            self.condition = temp_model.from_map(map['Condition'])
        else:
            self.condition = None
        if map.get('Redirect') is not None:
            temp_model = GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirect()
            self.redirect = temp_model.from_map(map['Redirect'])
        else:
            self.redirect = None
        return self


class GetBucketWebsiteResponseWebsiteConfigurationRoutingRules(TeaModel):
    def __init__(self, routing_rule=None):
        self.routing_rule = []

    def validate(self):
        if self.routing_rule:
            for k in self.routing_rule:
                if k :
                    k.validate()

    def to_map(self):
        result = {}
        result['RoutingRule'] = []
        if self.routing_rule is not None:
            for k in self.routing_rule:
                result['RoutingRule'].append(k.to_map() if k else None)
        else:
            result['RoutingRule'] = None
        return result

    def from_map(self, map={}):
        self.routing_rule = []
        if map.get('RoutingRule') is not None:
            for k in map.get('RoutingRule'):
                temp_model = GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRule()
                temp_model = temp_model.from_map(k)
                self.routing_rule.append(temp_model)
        else:
            self.routing_rule = None
        return self


class GetBucketWebsiteResponseWebsiteConfiguration(TeaModel):
    def __init__(self, index_document=None, error_document=None, routing_rules=None):
        self.index_document = index_document
        self.error_document = error_document
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
        result = {}
        if self.index_document is not None:
            result['IndexDocument'] = self.index_document.to_map()
        else:
            result['IndexDocument'] = None
        if self.error_document is not None:
            result['ErrorDocument'] = self.error_document.to_map()
        else:
            result['ErrorDocument'] = None
        if self.routing_rules is not None:
            result['RoutingRules'] = self.routing_rules.to_map()
        else:
            result['RoutingRules'] = None
        return result

    def from_map(self, map={}):
        if map.get('IndexDocument') is not None:
            temp_model = GetBucketWebsiteResponseWebsiteConfigurationIndexDocument()
            self.index_document = temp_model.from_map(map['IndexDocument'])
        else:
            self.index_document = None
        if map.get('ErrorDocument') is not None:
            temp_model = GetBucketWebsiteResponseWebsiteConfigurationErrorDocument()
            self.error_document = temp_model.from_map(map['ErrorDocument'])
        else:
            self.error_document = None
        if map.get('RoutingRules') is not None:
            temp_model = GetBucketWebsiteResponseWebsiteConfigurationRoutingRules()
            self.routing_rules = temp_model.from_map(map['RoutingRules'])
        else:
            self.routing_rules = None
        return self


class DeleteLiveChannelRequest(TeaModel):
    def __init__(self, bucket_name=None, channel_name=None):
        self.bucket_name = bucket_name
        self.channel_name = channel_name

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')
        self.validate_required(self.channel_name, 'channel_name')

    def to_map(self):
        result = {}
        result['BucketName'] = self.bucket_name
        result['ChannelName'] = self.channel_name
        return result

    def from_map(self, map={}):
        self.bucket_name = map.get('BucketName')
        self.channel_name = map.get('ChannelName')
        return self


class DeleteLiveChannelResponse(TeaModel):
    def __init__(self, request_id=None):
        self.request_id = request_id

    def validate(self):
        self.validate_required(self.request_id, 'request_id')

    def to_map(self):
        result = {}
        result['x-oss-request-id'] = self.request_id
        return result

    def from_map(self, map={}):
        self.request_id = map.get('x-oss-request-id')
        return self


class GetBucketLocationRequest(TeaModel):
    def __init__(self, bucket_name=None):
        self.bucket_name = bucket_name

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')

    def to_map(self):
        result = {}
        result['BucketName'] = self.bucket_name
        return result

    def from_map(self, map={}):
        self.bucket_name = map.get('BucketName')
        return self


class GetBucketLocationResponse(TeaModel):
    def __init__(self, request_id=None, location_constraint=None):
        self.request_id = request_id
        self.location_constraint = location_constraint

    def validate(self):
        self.validate_required(self.request_id, 'request_id')
        self.validate_required(self.location_constraint, 'location_constraint')

    def to_map(self):
        result = {}
        result['x-oss-request-id'] = self.request_id
        result['LocationConstraint'] = self.location_constraint
        return result

    def from_map(self, map={}):
        self.request_id = map.get('x-oss-request-id')
        self.location_constraint = map.get('LocationConstraint')
        return self


class ListLiveChannelRequest(TeaModel):
    def __init__(self, bucket_name=None, filter=None):
        self.bucket_name = bucket_name
        self.filter = filter

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')
        if self.filter:
            self.filter.validate()

    def to_map(self):
        result = {}
        result['BucketName'] = self.bucket_name
        if self.filter is not None:
            result['Filter'] = self.filter.to_map()
        else:
            result['Filter'] = None
        return result

    def from_map(self, map={}):
        self.bucket_name = map.get('BucketName')
        if map.get('Filter') is not None:
            temp_model = ListLiveChannelRequestFilter()
            self.filter = temp_model.from_map(map['Filter'])
        else:
            self.filter = None
        return self


class ListLiveChannelRequestFilter(TeaModel):
    def __init__(self, marker=None, max_keys=None, prefix=None):
        self.marker = marker
        self.max_keys = max_keys
        self.prefix = prefix

    def validate(self):
        pass

    def to_map(self):
        result = {}
        result['marker'] = self.marker
        result['max-keys'] = self.max_keys
        result['prefix'] = self.prefix
        return result

    def from_map(self, map={}):
        self.marker = map.get('marker')
        self.max_keys = map.get('max-keys')
        self.prefix = map.get('prefix')
        return self


class ListLiveChannelResponse(TeaModel):
    def __init__(self, request_id=None, list_live_channel_result=None):
        self.request_id = request_id
        self.list_live_channel_result = list_live_channel_result

    def validate(self):
        self.validate_required(self.request_id, 'request_id')
        self.validate_required(self.list_live_channel_result, 'list_live_channel_result')
        if self.list_live_channel_result:
            self.list_live_channel_result.validate()

    def to_map(self):
        result = {}
        result['x-oss-request-id'] = self.request_id
        if self.list_live_channel_result is not None:
            result['ListLiveChannelResult'] = self.list_live_channel_result.to_map()
        else:
            result['ListLiveChannelResult'] = None
        return result

    def from_map(self, map={}):
        self.request_id = map.get('x-oss-request-id')
        if map.get('ListLiveChannelResult') is not None:
            temp_model = ListLiveChannelResponseListLiveChannelResult()
            self.list_live_channel_result = temp_model.from_map(map['ListLiveChannelResult'])
        else:
            self.list_live_channel_result = None
        return self


class ListLiveChannelResponseListLiveChannelResultLiveChannelPublishUrls(TeaModel):
    def __init__(self, url=None):
        self.url = url

    def validate(self):
        pass

    def to_map(self):
        result = {}
        result['Url'] = self.url
        return result

    def from_map(self, map={}):
        self.url = map.get('Url')
        return self


class ListLiveChannelResponseListLiveChannelResultLiveChannelPlayUrls(TeaModel):
    def __init__(self, url=None):
        self.url = url

    def validate(self):
        pass

    def to_map(self):
        result = {}
        result['Url'] = self.url
        return result

    def from_map(self, map={}):
        self.url = map.get('Url')
        return self


class ListLiveChannelResponseListLiveChannelResultLiveChannel(TeaModel):
    def __init__(self, name=None, description=None, status=None, last_modified=None, publish_urls=None, play_urls=None):
        self.name = name
        self.description = description
        self.status = status
        self.last_modified = last_modified
        self.publish_urls = publish_urls
        self.play_urls = play_urls

    def validate(self):
        self.validate_required(self.publish_urls, 'publish_urls')
        if self.publish_urls:
            self.publish_urls.validate()
        self.validate_required(self.play_urls, 'play_urls')
        if self.play_urls:
            self.play_urls.validate()

    def to_map(self):
        result = {}
        result['Name'] = self.name
        result['Description'] = self.description
        result['Status'] = self.status
        result['LastModified'] = self.last_modified
        if self.publish_urls is not None:
            result['PublishUrls'] = self.publish_urls.to_map()
        else:
            result['PublishUrls'] = None
        if self.play_urls is not None:
            result['PlayUrls'] = self.play_urls.to_map()
        else:
            result['PlayUrls'] = None
        return result

    def from_map(self, map={}):
        self.name = map.get('Name')
        self.description = map.get('Description')
        self.status = map.get('Status')
        self.last_modified = map.get('LastModified')
        if map.get('PublishUrls') is not None:
            temp_model = ListLiveChannelResponseListLiveChannelResultLiveChannelPublishUrls()
            self.publish_urls = temp_model.from_map(map['PublishUrls'])
        else:
            self.publish_urls = None
        if map.get('PlayUrls') is not None:
            temp_model = ListLiveChannelResponseListLiveChannelResultLiveChannelPlayUrls()
            self.play_urls = temp_model.from_map(map['PlayUrls'])
        else:
            self.play_urls = None
        return self


class ListLiveChannelResponseListLiveChannelResult(TeaModel):
    def __init__(self, prefix=None, marker=None, max_keys=None, is_truncated=None, next_marker=None, live_channel=None):
        self.prefix = prefix
        self.marker = marker
        self.max_keys = max_keys
        self.is_truncated = is_truncated
        self.next_marker = next_marker
        self.live_channel = live_channel

    def validate(self):
        self.validate_required(self.live_channel, 'live_channel')
        if self.live_channel:
            self.live_channel.validate()

    def to_map(self):
        result = {}
        result['Prefix'] = self.prefix
        result['Marker'] = self.marker
        result['MaxKeys'] = self.max_keys
        result['IsTruncated'] = self.is_truncated
        result['NextMarker'] = self.next_marker
        if self.live_channel is not None:
            result['LiveChannel'] = self.live_channel.to_map()
        else:
            result['LiveChannel'] = None
        return result

    def from_map(self, map={}):
        self.prefix = map.get('Prefix')
        self.marker = map.get('Marker')
        self.max_keys = map.get('MaxKeys')
        self.is_truncated = map.get('IsTruncated')
        self.next_marker = map.get('NextMarker')
        if map.get('LiveChannel') is not None:
            temp_model = ListLiveChannelResponseListLiveChannelResultLiveChannel()
            self.live_channel = temp_model.from_map(map['LiveChannel'])
        else:
            self.live_channel = None
        return self


class GetObjectMetaRequest(TeaModel):
    def __init__(self, bucket_name=None, object_name=None):
        self.bucket_name = bucket_name
        self.object_name = object_name

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')
        self.validate_required(self.object_name, 'object_name')

    def to_map(self):
        result = {}
        result['BucketName'] = self.bucket_name
        result['ObjectName'] = self.object_name
        return result

    def from_map(self, map={}):
        self.bucket_name = map.get('BucketName')
        self.object_name = map.get('ObjectName')
        return self


class GetObjectMetaResponse(TeaModel):
    def __init__(self, request_id=None, e_tag=None, content_length=None, last_modified=None):
        self.request_id = request_id
        self.e_tag = e_tag
        self.content_length = content_length
        self.last_modified = last_modified

    def validate(self):
        self.validate_required(self.request_id, 'request_id')
        self.validate_required(self.e_tag, 'e_tag')
        self.validate_required(self.content_length, 'content_length')
        self.validate_required(self.last_modified, 'last_modified')

    def to_map(self):
        result = {}
        result['x-oss-request-id'] = self.request_id
        result['etag'] = self.e_tag
        result['content-length'] = self.content_length
        result['last-modified'] = self.last_modified
        return result

    def from_map(self, map={}):
        self.request_id = map.get('x-oss-request-id')
        self.e_tag = map.get('etag')
        self.content_length = map.get('content-length')
        self.last_modified = map.get('last-modified')
        return self


class GetBucketAclRequest(TeaModel):
    def __init__(self, bucket_name=None):
        self.bucket_name = bucket_name

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')

    def to_map(self):
        result = {}
        result['BucketName'] = self.bucket_name
        return result

    def from_map(self, map={}):
        self.bucket_name = map.get('BucketName')
        return self


class GetBucketAclResponse(TeaModel):
    def __init__(self, request_id=None, access_control_policy=None):
        self.request_id = request_id
        self.access_control_policy = access_control_policy

    def validate(self):
        self.validate_required(self.request_id, 'request_id')
        self.validate_required(self.access_control_policy, 'access_control_policy')
        if self.access_control_policy:
            self.access_control_policy.validate()

    def to_map(self):
        result = {}
        result['x-oss-request-id'] = self.request_id
        if self.access_control_policy is not None:
            result['AccessControlPolicy'] = self.access_control_policy.to_map()
        else:
            result['AccessControlPolicy'] = None
        return result

    def from_map(self, map={}):
        self.request_id = map.get('x-oss-request-id')
        if map.get('AccessControlPolicy') is not None:
            temp_model = GetBucketAclResponseAccessControlPolicy()
            self.access_control_policy = temp_model.from_map(map['AccessControlPolicy'])
        else:
            self.access_control_policy = None
        return self


class GetBucketAclResponseAccessControlPolicyOwner(TeaModel):
    def __init__(self, i_d=None, display_name=None):
        self.i_d = i_d
        self.display_name = display_name

    def validate(self):
        pass

    def to_map(self):
        result = {}
        result['ID'] = self.i_d
        result['DisplayName'] = self.display_name
        return result

    def from_map(self, map={}):
        self.i_d = map.get('ID')
        self.display_name = map.get('DisplayName')
        return self


class GetBucketAclResponseAccessControlPolicyAccessControlList(TeaModel):
    def __init__(self, grant=None):
        self.grant = grant

    def validate(self):
        pass

    def to_map(self):
        result = {}
        result['Grant'] = self.grant
        return result

    def from_map(self, map={}):
        self.grant = map.get('Grant')
        return self


class GetBucketAclResponseAccessControlPolicy(TeaModel):
    def __init__(self, owner=None, access_control_list=None):
        self.owner = owner
        self.access_control_list = access_control_list

    def validate(self):
        self.validate_required(self.owner, 'owner')
        if self.owner:
            self.owner.validate()
        self.validate_required(self.access_control_list, 'access_control_list')
        if self.access_control_list:
            self.access_control_list.validate()

    def to_map(self):
        result = {}
        if self.owner is not None:
            result['Owner'] = self.owner.to_map()
        else:
            result['Owner'] = None
        if self.access_control_list is not None:
            result['AccessControlList'] = self.access_control_list.to_map()
        else:
            result['AccessControlList'] = None
        return result

    def from_map(self, map={}):
        if map.get('Owner') is not None:
            temp_model = GetBucketAclResponseAccessControlPolicyOwner()
            self.owner = temp_model.from_map(map['Owner'])
        else:
            self.owner = None
        if map.get('AccessControlList') is not None:
            temp_model = GetBucketAclResponseAccessControlPolicyAccessControlList()
            self.access_control_list = temp_model.from_map(map['AccessControlList'])
        else:
            self.access_control_list = None
        return self


class ListPartsRequest(TeaModel):
    def __init__(self, bucket_name=None, object_name=None, filter=None):
        self.bucket_name = bucket_name
        self.object_name = object_name
        self.filter = filter

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')
        self.validate_required(self.object_name, 'object_name')
        self.validate_required(self.filter, 'filter')
        if self.filter:
            self.filter.validate()

    def to_map(self):
        result = {}
        result['BucketName'] = self.bucket_name
        result['ObjectName'] = self.object_name
        if self.filter is not None:
            result['Filter'] = self.filter.to_map()
        else:
            result['Filter'] = None
        return result

    def from_map(self, map={}):
        self.bucket_name = map.get('BucketName')
        self.object_name = map.get('ObjectName')
        if map.get('Filter') is not None:
            temp_model = ListPartsRequestFilter()
            self.filter = temp_model.from_map(map['Filter'])
        else:
            self.filter = None
        return self


class ListPartsRequestFilter(TeaModel):
    def __init__(self, upload_id=None, max_parts=None, part_number_marker=None, encoding_type=None):
        self.upload_id = upload_id
        self.max_parts = max_parts
        self.part_number_marker = part_number_marker
        self.encoding_type = encoding_type

    def validate(self):
        self.validate_required(self.upload_id, 'upload_id')

    def to_map(self):
        result = {}
        result['uploadId'] = self.upload_id
        result['max-parts'] = self.max_parts
        result['part-number-marker'] = self.part_number_marker
        result['Encoding-type'] = self.encoding_type
        return result

    def from_map(self, map={}):
        self.upload_id = map.get('uploadId')
        self.max_parts = map.get('max-parts')
        self.part_number_marker = map.get('part-number-marker')
        self.encoding_type = map.get('Encoding-type')
        return self


class ListPartsResponse(TeaModel):
    def __init__(self, request_id=None, list_parts_result=None):
        self.request_id = request_id
        self.list_parts_result = list_parts_result

    def validate(self):
        self.validate_required(self.request_id, 'request_id')
        self.validate_required(self.list_parts_result, 'list_parts_result')
        if self.list_parts_result:
            self.list_parts_result.validate()

    def to_map(self):
        result = {}
        result['x-oss-request-id'] = self.request_id
        if self.list_parts_result is not None:
            result['ListPartsResult'] = self.list_parts_result.to_map()
        else:
            result['ListPartsResult'] = None
        return result

    def from_map(self, map={}):
        self.request_id = map.get('x-oss-request-id')
        if map.get('ListPartsResult') is not None:
            temp_model = ListPartsResponseListPartsResult()
            self.list_parts_result = temp_model.from_map(map['ListPartsResult'])
        else:
            self.list_parts_result = None
        return self


class ListPartsResponseListPartsResultPart(TeaModel):
    def __init__(self, part_number=None, last_modified=None, e_tag=None, size=None):
        self.part_number = part_number
        self.last_modified = last_modified
        self.e_tag = e_tag
        self.size = size

    def validate(self):
        pass

    def to_map(self):
        result = {}
        result['PartNumber'] = self.part_number
        result['LastModified'] = self.last_modified
        result['ETag'] = self.e_tag
        result['Size'] = self.size
        return result

    def from_map(self, map={}):
        self.part_number = map.get('PartNumber')
        self.last_modified = map.get('LastModified')
        self.e_tag = map.get('ETag')
        self.size = map.get('Size')
        return self


class ListPartsResponseListPartsResult(TeaModel):
    def __init__(self, bucket=None, encoding_type=None, key=None, upload_id=None, part_number_marker=None, next_part_number_marker=None, max_parts=None, is_truncated=None, part=None):
        self.bucket = bucket
        self.encoding_type = encoding_type
        self.key = key
        self.upload_id = upload_id
        self.part_number_marker = part_number_marker
        self.next_part_number_marker = next_part_number_marker
        self.max_parts = max_parts
        self.is_truncated = is_truncated
        self.part = []

    def validate(self):
        if self.part:
            for k in self.part:
                if k :
                    k.validate()

    def to_map(self):
        result = {}
        result['Bucket'] = self.bucket
        result['EncodingType'] = self.encoding_type
        result['Key'] = self.key
        result['UploadId'] = self.upload_id
        result['PartNumberMarker'] = self.part_number_marker
        result['NextPartNumberMarker'] = self.next_part_number_marker
        result['MaxParts'] = self.max_parts
        result['IsTruncated'] = self.is_truncated
        result['Part'] = []
        if self.part is not None:
            for k in self.part:
                result['Part'].append(k.to_map() if k else None)
        else:
            result['Part'] = None
        return result

    def from_map(self, map={}):
        self.bucket = map.get('Bucket')
        self.encoding_type = map.get('EncodingType')
        self.key = map.get('Key')
        self.upload_id = map.get('UploadId')
        self.part_number_marker = map.get('PartNumberMarker')
        self.next_part_number_marker = map.get('NextPartNumberMarker')
        self.max_parts = map.get('MaxParts')
        self.is_truncated = map.get('IsTruncated')
        self.part = []
        if map.get('Part') is not None:
            for k in map.get('Part'):
                temp_model = ListPartsResponseListPartsResultPart()
                temp_model = temp_model.from_map(k)
                self.part.append(temp_model)
        else:
            self.part = None
        return self


class GetLiveChannelHistoryRequest(TeaModel):
    def __init__(self, bucket_name=None, channel_name=None, filter=None):
        self.bucket_name = bucket_name
        self.channel_name = channel_name
        self.filter = filter

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')
        self.validate_required(self.channel_name, 'channel_name')
        if self.filter:
            self.filter.validate()

    def to_map(self):
        result = {}
        result['BucketName'] = self.bucket_name
        result['ChannelName'] = self.channel_name
        if self.filter is not None:
            result['Filter'] = self.filter.to_map()
        else:
            result['Filter'] = None
        return result

    def from_map(self, map={}):
        self.bucket_name = map.get('BucketName')
        self.channel_name = map.get('ChannelName')
        if map.get('Filter') is not None:
            temp_model = GetLiveChannelHistoryRequestFilter()
            self.filter = temp_model.from_map(map['Filter'])
        else:
            self.filter = None
        return self


class GetLiveChannelHistoryRequestFilter(TeaModel):
    def __init__(self, comp=None):
        self.comp = comp

    def validate(self):
        pass

    def to_map(self):
        result = {}
        result['comp'] = self.comp
        return result

    def from_map(self, map={}):
        self.comp = map.get('comp')
        return self


class GetLiveChannelHistoryResponse(TeaModel):
    def __init__(self, request_id=None, live_channel_history=None):
        self.request_id = request_id
        self.live_channel_history = live_channel_history

    def validate(self):
        self.validate_required(self.request_id, 'request_id')
        self.validate_required(self.live_channel_history, 'live_channel_history')
        if self.live_channel_history:
            self.live_channel_history.validate()

    def to_map(self):
        result = {}
        result['x-oss-request-id'] = self.request_id
        if self.live_channel_history is not None:
            result['LiveChannelHistory'] = self.live_channel_history.to_map()
        else:
            result['LiveChannelHistory'] = None
        return result

    def from_map(self, map={}):
        self.request_id = map.get('x-oss-request-id')
        if map.get('LiveChannelHistory') is not None:
            temp_model = GetLiveChannelHistoryResponseLiveChannelHistory()
            self.live_channel_history = temp_model.from_map(map['LiveChannelHistory'])
        else:
            self.live_channel_history = None
        return self


class GetLiveChannelHistoryResponseLiveChannelHistoryLiveRecord(TeaModel):
    def __init__(self, start_time=None, end_time=None, remote_addr=None):
        self.start_time = start_time
        self.end_time = end_time
        self.remote_addr = remote_addr

    def validate(self):
        pass

    def to_map(self):
        result = {}
        result['StartTime'] = self.start_time
        result['EndTime'] = self.end_time
        result['RemoteAddr'] = self.remote_addr
        return result

    def from_map(self, map={}):
        self.start_time = map.get('StartTime')
        self.end_time = map.get('EndTime')
        self.remote_addr = map.get('RemoteAddr')
        return self


class GetLiveChannelHistoryResponseLiveChannelHistory(TeaModel):
    def __init__(self, live_record=None):
        self.live_record = []

    def validate(self):
        if self.live_record:
            for k in self.live_record:
                if k :
                    k.validate()

    def to_map(self):
        result = {}
        result['LiveRecord'] = []
        if self.live_record is not None:
            for k in self.live_record:
                result['LiveRecord'].append(k.to_map() if k else None)
        else:
            result['LiveRecord'] = None
        return result

    def from_map(self, map={}):
        self.live_record = []
        if map.get('LiveRecord') is not None:
            for k in map.get('LiveRecord'):
                temp_model = GetLiveChannelHistoryResponseLiveChannelHistoryLiveRecord()
                temp_model = temp_model.from_map(k)
                self.live_record.append(temp_model)
        else:
            self.live_record = None
        return self


class GetBucketRequest(TeaModel):
    def __init__(self, bucket_name=None, filter=None):
        self.bucket_name = bucket_name
        self.filter = filter

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')
        if self.filter:
            self.filter.validate()

    def to_map(self):
        result = {}
        result['BucketName'] = self.bucket_name
        if self.filter is not None:
            result['Filter'] = self.filter.to_map()
        else:
            result['Filter'] = None
        return result

    def from_map(self, map={}):
        self.bucket_name = map.get('BucketName')
        if map.get('Filter') is not None:
            temp_model = GetBucketRequestFilter()
            self.filter = temp_model.from_map(map['Filter'])
        else:
            self.filter = None
        return self


class GetBucketRequestFilter(TeaModel):
    def __init__(self, delimiter=None, marker=None, max_keys=None, prefix=None, encoding_type=None):
        self.delimiter = delimiter
        self.marker = marker
        self.max_keys = max_keys
        self.prefix = prefix
        self.encoding_type = encoding_type

    def validate(self):
        pass

    def to_map(self):
        result = {}
        result['delimiter'] = self.delimiter
        result['marker'] = self.marker
        result['max-keys'] = self.max_keys
        result['prefix'] = self.prefix
        result['encoding-type'] = self.encoding_type
        return result

    def from_map(self, map={}):
        self.delimiter = map.get('delimiter')
        self.marker = map.get('marker')
        self.max_keys = map.get('max-keys')
        self.prefix = map.get('prefix')
        self.encoding_type = map.get('encoding-type')
        return self


class GetBucketResponse(TeaModel):
    def __init__(self, request_id=None, list_bucket_result=None):
        self.request_id = request_id
        self.list_bucket_result = list_bucket_result

    def validate(self):
        self.validate_required(self.request_id, 'request_id')
        self.validate_required(self.list_bucket_result, 'list_bucket_result')
        if self.list_bucket_result:
            self.list_bucket_result.validate()

    def to_map(self):
        result = {}
        result['x-oss-request-id'] = self.request_id
        if self.list_bucket_result is not None:
            result['ListBucketResult'] = self.list_bucket_result.to_map()
        else:
            result['ListBucketResult'] = None
        return result

    def from_map(self, map={}):
        self.request_id = map.get('x-oss-request-id')
        if map.get('ListBucketResult') is not None:
            temp_model = GetBucketResponseListBucketResult()
            self.list_bucket_result = temp_model.from_map(map['ListBucketResult'])
        else:
            self.list_bucket_result = None
        return self


class GetBucketResponseListBucketResultContentsOwner(TeaModel):
    def __init__(self, i_d=None, display_name=None):
        self.i_d = i_d
        self.display_name = display_name

    def validate(self):
        pass

    def to_map(self):
        result = {}
        result['ID'] = self.i_d
        result['DisplayName'] = self.display_name
        return result

    def from_map(self, map={}):
        self.i_d = map.get('ID')
        self.display_name = map.get('DisplayName')
        return self


class GetBucketResponseListBucketResultContents(TeaModel):
    def __init__(self, key=None, e_tag=None, last_modified=None, size=None, storage_class=None, owner=None):
        self.key = key
        self.e_tag = e_tag
        self.last_modified = last_modified
        self.size = size
        self.storage_class = storage_class
        self.owner = owner

    def validate(self):
        self.validate_required(self.owner, 'owner')
        if self.owner:
            self.owner.validate()

    def to_map(self):
        result = {}
        result['Key'] = self.key
        result['ETag'] = self.e_tag
        result['LastModified'] = self.last_modified
        result['Size'] = self.size
        result['StorageClass'] = self.storage_class
        if self.owner is not None:
            result['Owner'] = self.owner.to_map()
        else:
            result['Owner'] = None
        return result

    def from_map(self, map={}):
        self.key = map.get('Key')
        self.e_tag = map.get('ETag')
        self.last_modified = map.get('LastModified')
        self.size = map.get('Size')
        self.storage_class = map.get('StorageClass')
        if map.get('Owner') is not None:
            temp_model = GetBucketResponseListBucketResultContentsOwner()
            self.owner = temp_model.from_map(map['Owner'])
        else:
            self.owner = None
        return self


class GetBucketResponseListBucketResult(TeaModel):
    def __init__(self, name=None, prefix=None, marker=None, max_keys=None, delimiter=None, is_truncated=None, encoding_type=None, common_prefixes=None, contents=None):
        self.name = name
        self.prefix = prefix
        self.marker = marker
        self.max_keys = max_keys
        self.delimiter = delimiter
        self.is_truncated = is_truncated
        self.encoding_type = encoding_type
        self.common_prefixes = common_prefixes
        self.contents = []

    def validate(self):
        if self.contents:
            for k in self.contents:
                if k :
                    k.validate()

    def to_map(self):
        result = {}
        result['Name'] = self.name
        result['Prefix'] = self.prefix
        result['Marker'] = self.marker
        result['MaxKeys'] = self.max_keys
        result['Delimiter'] = self.delimiter
        result['IsTruncated'] = self.is_truncated
        result['EncodingType'] = self.encoding_type
        result['CommonPrefixes'] = self.common_prefixes
        result['Contents'] = []
        if self.contents is not None:
            for k in self.contents:
                result['Contents'].append(k.to_map() if k else None)
        else:
            result['Contents'] = None
        return result

    def from_map(self, map={}):
        self.name = map.get('Name')
        self.prefix = map.get('Prefix')
        self.marker = map.get('Marker')
        self.max_keys = map.get('MaxKeys')
        self.delimiter = map.get('Delimiter')
        self.is_truncated = map.get('IsTruncated')
        self.encoding_type = map.get('EncodingType')
        self.common_prefixes = map.get('CommonPrefixes')
        self.contents = []
        if map.get('Contents') is not None:
            for k in map.get('Contents'):
                temp_model = GetBucketResponseListBucketResultContents()
                temp_model = temp_model.from_map(k)
                self.contents.append(temp_model)
        else:
            self.contents = None
        return self


class GetLiveChannelInfoRequest(TeaModel):
    def __init__(self, bucket_name=None, channel_name=None):
        self.bucket_name = bucket_name
        self.channel_name = channel_name

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')
        self.validate_required(self.channel_name, 'channel_name')

    def to_map(self):
        result = {}
        result['BucketName'] = self.bucket_name
        result['ChannelName'] = self.channel_name
        return result

    def from_map(self, map={}):
        self.bucket_name = map.get('BucketName')
        self.channel_name = map.get('ChannelName')
        return self


class GetLiveChannelInfoResponse(TeaModel):
    def __init__(self, request_id=None, live_channel_configuration=None):
        self.request_id = request_id
        self.live_channel_configuration = live_channel_configuration

    def validate(self):
        self.validate_required(self.request_id, 'request_id')
        self.validate_required(self.live_channel_configuration, 'live_channel_configuration')
        if self.live_channel_configuration:
            self.live_channel_configuration.validate()

    def to_map(self):
        result = {}
        result['x-oss-request-id'] = self.request_id
        if self.live_channel_configuration is not None:
            result['LiveChannelConfiguration'] = self.live_channel_configuration.to_map()
        else:
            result['LiveChannelConfiguration'] = None
        return result

    def from_map(self, map={}):
        self.request_id = map.get('x-oss-request-id')
        if map.get('LiveChannelConfiguration') is not None:
            temp_model = GetLiveChannelInfoResponseLiveChannelConfiguration()
            self.live_channel_configuration = temp_model.from_map(map['LiveChannelConfiguration'])
        else:
            self.live_channel_configuration = None
        return self


class GetLiveChannelInfoResponseLiveChannelConfigurationTarget(TeaModel):
    def __init__(self, type=None, frag_duration=None, frag_count=None, playlist_name=None):
        self.type = type
        self.frag_duration = frag_duration
        self.frag_count = frag_count
        self.playlist_name = playlist_name

    def validate(self):
        pass

    def to_map(self):
        result = {}
        result['Type'] = self.type
        result['FragDuration'] = self.frag_duration
        result['FragCount'] = self.frag_count
        result['PlaylistName'] = self.playlist_name
        return result

    def from_map(self, map={}):
        self.type = map.get('Type')
        self.frag_duration = map.get('FragDuration')
        self.frag_count = map.get('FragCount')
        self.playlist_name = map.get('PlaylistName')
        return self


class GetLiveChannelInfoResponseLiveChannelConfiguration(TeaModel):
    def __init__(self, description=None, status=None, target=None):
        self.description = description
        self.status = status
        self.target = target

    def validate(self):
        self.validate_required(self.target, 'target')
        if self.target:
            self.target.validate()

    def to_map(self):
        result = {}
        result['Description'] = self.description
        result['Status'] = self.status
        if self.target is not None:
            result['Target'] = self.target.to_map()
        else:
            result['Target'] = None
        return result

    def from_map(self, map={}):
        self.description = map.get('Description')
        self.status = map.get('Status')
        if map.get('Target') is not None:
            temp_model = GetLiveChannelInfoResponseLiveChannelConfigurationTarget()
            self.target = temp_model.from_map(map['Target'])
        else:
            self.target = None
        return self


class GetLiveChannelStatRequest(TeaModel):
    def __init__(self, bucket_name=None, channel_name=None, filter=None):
        self.bucket_name = bucket_name
        self.channel_name = channel_name
        self.filter = filter

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')
        self.validate_required(self.channel_name, 'channel_name')
        if self.filter:
            self.filter.validate()

    def to_map(self):
        result = {}
        result['BucketName'] = self.bucket_name
        result['ChannelName'] = self.channel_name
        if self.filter is not None:
            result['Filter'] = self.filter.to_map()
        else:
            result['Filter'] = None
        return result

    def from_map(self, map={}):
        self.bucket_name = map.get('BucketName')
        self.channel_name = map.get('ChannelName')
        if map.get('Filter') is not None:
            temp_model = GetLiveChannelStatRequestFilter()
            self.filter = temp_model.from_map(map['Filter'])
        else:
            self.filter = None
        return self


class GetLiveChannelStatRequestFilter(TeaModel):
    def __init__(self, comp=None):
        self.comp = comp

    def validate(self):
        pass

    def to_map(self):
        result = {}
        result['comp'] = self.comp
        return result

    def from_map(self, map={}):
        self.comp = map.get('comp')
        return self


class GetLiveChannelStatResponse(TeaModel):
    def __init__(self, request_id=None, live_channel_stat=None):
        self.request_id = request_id
        self.live_channel_stat = live_channel_stat

    def validate(self):
        self.validate_required(self.request_id, 'request_id')
        self.validate_required(self.live_channel_stat, 'live_channel_stat')
        if self.live_channel_stat:
            self.live_channel_stat.validate()

    def to_map(self):
        result = {}
        result['x-oss-request-id'] = self.request_id
        if self.live_channel_stat is not None:
            result['LiveChannelStat'] = self.live_channel_stat.to_map()
        else:
            result['LiveChannelStat'] = None
        return result

    def from_map(self, map={}):
        self.request_id = map.get('x-oss-request-id')
        if map.get('LiveChannelStat') is not None:
            temp_model = GetLiveChannelStatResponseLiveChannelStat()
            self.live_channel_stat = temp_model.from_map(map['LiveChannelStat'])
        else:
            self.live_channel_stat = None
        return self


class GetLiveChannelStatResponseLiveChannelStatVideo(TeaModel):
    def __init__(self, width=None, height=None, frame_rate=None, bandwidth=None, codec=None):
        self.width = width
        self.height = height
        self.frame_rate = frame_rate
        self.bandwidth = bandwidth
        self.codec = codec

    def validate(self):
        pass

    def to_map(self):
        result = {}
        result['Width'] = self.width
        result['Height'] = self.height
        result['FrameRate'] = self.frame_rate
        result['Bandwidth'] = self.bandwidth
        result['Codec'] = self.codec
        return result

    def from_map(self, map={}):
        self.width = map.get('Width')
        self.height = map.get('Height')
        self.frame_rate = map.get('FrameRate')
        self.bandwidth = map.get('Bandwidth')
        self.codec = map.get('Codec')
        return self


class GetLiveChannelStatResponseLiveChannelStatAudio(TeaModel):
    def __init__(self, bandwidth=None, sample_rate=None, codec=None):
        self.bandwidth = bandwidth
        self.sample_rate = sample_rate
        self.codec = codec

    def validate(self):
        pass

    def to_map(self):
        result = {}
        result['Bandwidth'] = self.bandwidth
        result['SampleRate'] = self.sample_rate
        result['Codec'] = self.codec
        return result

    def from_map(self, map={}):
        self.bandwidth = map.get('Bandwidth')
        self.sample_rate = map.get('SampleRate')
        self.codec = map.get('Codec')
        return self


class GetLiveChannelStatResponseLiveChannelStat(TeaModel):
    def __init__(self, status=None, connected_time=None, remote_addr=None, video=None, audio=None):
        self.status = status
        self.connected_time = connected_time
        self.remote_addr = remote_addr
        self.video = video
        self.audio = audio

    def validate(self):
        self.validate_required(self.video, 'video')
        if self.video:
            self.video.validate()
        self.validate_required(self.audio, 'audio')
        if self.audio:
            self.audio.validate()

    def to_map(self):
        result = {}
        result['Status'] = self.status
        result['ConnectedTime'] = self.connected_time
        result['RemoteAddr'] = self.remote_addr
        if self.video is not None:
            result['Video'] = self.video.to_map()
        else:
            result['Video'] = None
        if self.audio is not None:
            result['Audio'] = self.audio.to_map()
        else:
            result['Audio'] = None
        return result

    def from_map(self, map={}):
        self.status = map.get('Status')
        self.connected_time = map.get('ConnectedTime')
        self.remote_addr = map.get('RemoteAddr')
        if map.get('Video') is not None:
            temp_model = GetLiveChannelStatResponseLiveChannelStatVideo()
            self.video = temp_model.from_map(map['Video'])
        else:
            self.video = None
        if map.get('Audio') is not None:
            temp_model = GetLiveChannelStatResponseLiveChannelStatAudio()
            self.audio = temp_model.from_map(map['Audio'])
        else:
            self.audio = None
        return self


class DeleteObjectRequest(TeaModel):
    def __init__(self, bucket_name=None, object_name=None):
        self.bucket_name = bucket_name
        self.object_name = object_name

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')
        self.validate_required(self.object_name, 'object_name')

    def to_map(self):
        result = {}
        result['BucketName'] = self.bucket_name
        result['ObjectName'] = self.object_name
        return result

    def from_map(self, map={}):
        self.bucket_name = map.get('BucketName')
        self.object_name = map.get('ObjectName')
        return self


class DeleteObjectResponse(TeaModel):
    def __init__(self, request_id=None):
        self.request_id = request_id

    def validate(self):
        self.validate_required(self.request_id, 'request_id')

    def to_map(self):
        result = {}
        result['x-oss-request-id'] = self.request_id
        return result

    def from_map(self, map={}):
        self.request_id = map.get('x-oss-request-id')
        return self


class AbortMultipartUploadRequest(TeaModel):
    def __init__(self, bucket_name=None, object_name=None, filter=None):
        self.bucket_name = bucket_name
        self.object_name = object_name
        self.filter = filter

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')
        self.validate_required(self.object_name, 'object_name')
        self.validate_required(self.filter, 'filter')
        if self.filter:
            self.filter.validate()

    def to_map(self):
        result = {}
        result['BucketName'] = self.bucket_name
        result['ObjectName'] = self.object_name
        if self.filter is not None:
            result['Filter'] = self.filter.to_map()
        else:
            result['Filter'] = None
        return result

    def from_map(self, map={}):
        self.bucket_name = map.get('BucketName')
        self.object_name = map.get('ObjectName')
        if map.get('Filter') is not None:
            temp_model = AbortMultipartUploadRequestFilter()
            self.filter = temp_model.from_map(map['Filter'])
        else:
            self.filter = None
        return self


class AbortMultipartUploadRequestFilter(TeaModel):
    def __init__(self, upload_id=None):
        self.upload_id = upload_id

    def validate(self):
        self.validate_required(self.upload_id, 'upload_id')

    def to_map(self):
        result = {}
        result['uploadId'] = self.upload_id
        return result

    def from_map(self, map={}):
        self.upload_id = map.get('uploadId')
        return self


class AbortMultipartUploadResponse(TeaModel):
    def __init__(self, request_id=None):
        self.request_id = request_id

    def validate(self):
        self.validate_required(self.request_id, 'request_id')

    def to_map(self):
        result = {}
        result['x-oss-request-id'] = self.request_id
        return result

    def from_map(self, map={}):
        self.request_id = map.get('x-oss-request-id')
        return self


class AppendObjectRequest(TeaModel):
    def __init__(self, bucket_name=None, object_name=None, user_meta=None, body=None, filter=None, header=None):
        self.bucket_name = bucket_name
        self.object_name = object_name
        self.user_meta = {}
        self.body = body
        self.filter = filter
        self.header = header

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')
        self.validate_required(self.object_name, 'object_name')
        self.validate_required(self.filter, 'filter')
        if self.filter:
            self.filter.validate()
        if self.header:
            self.header.validate()

    def to_map(self):
        result = {}
        result['BucketName'] = self.bucket_name
        result['ObjectName'] = self.object_name
        result['UserMeta'] = self.user_meta
        result['body'] = self.body
        if self.filter is not None:
            result['Filter'] = self.filter.to_map()
        else:
            result['Filter'] = None
        if self.header is not None:
            result['Header'] = self.header.to_map()
        else:
            result['Header'] = None
        return result

    def from_map(self, map={}):
        self.bucket_name = map.get('BucketName')
        self.object_name = map.get('ObjectName')
        self.user_meta = map.get('UserMeta')
        self.body = map.get('body')
        if map.get('Filter') is not None:
            temp_model = AppendObjectRequestFilter()
            self.filter = temp_model.from_map(map['Filter'])
        else:
            self.filter = None
        if map.get('Header') is not None:
            temp_model = AppendObjectRequestHeader()
            self.header = temp_model.from_map(map['Header'])
        else:
            self.header = None
        return self


class AppendObjectRequestFilter(TeaModel):
    def __init__(self, position=None):
        self.position = position

    def validate(self):
        self.validate_required(self.position, 'position')

    def to_map(self):
        result = {}
        result['position'] = self.position
        return result

    def from_map(self, map={}):
        self.position = map.get('position')
        return self


class AppendObjectRequestHeader(TeaModel):
    def __init__(self, cache_control=None, content_disposition=None, content_encoding=None, content_md5=None, expires=None, server_side_encryption=None, object_acl=None, storage_class=None, content_type=None):
        self.cache_control = cache_control
        self.content_disposition = content_disposition
        self.content_encoding = content_encoding
        self.content_md5 = content_md5
        self.expires = expires
        self.server_side_encryption = server_side_encryption
        self.object_acl = object_acl
        self.storage_class = storage_class
        self.content_type = content_type

    def validate(self):
        pass

    def to_map(self):
        result = {}
        result['Cache-Control'] = self.cache_control
        result['Content-Disposition'] = self.content_disposition
        result['Content-Encoding'] = self.content_encoding
        result['Content-MD5'] = self.content_md5
        result['Expires'] = self.expires
        result['x-oss-server-side-encryption'] = self.server_side_encryption
        result['x-oss-object-acl'] = self.object_acl
        result['x-oss-storage-class'] = self.storage_class
        result['content-type'] = self.content_type
        return result

    def from_map(self, map={}):
        self.cache_control = map.get('Cache-Control')
        self.content_disposition = map.get('Content-Disposition')
        self.content_encoding = map.get('Content-Encoding')
        self.content_md5 = map.get('Content-MD5')
        self.expires = map.get('Expires')
        self.server_side_encryption = map.get('x-oss-server-side-encryption')
        self.object_acl = map.get('x-oss-object-acl')
        self.storage_class = map.get('x-oss-storage-class')
        self.content_type = map.get('content-type')
        return self


class AppendObjectResponse(TeaModel):
    def __init__(self, request_id=None, next_append_position=None, hash_crc_64ecma=None):
        self.request_id = request_id
        self.next_append_position = next_append_position
        self.hash_crc_64ecma = hash_crc_64ecma

    def validate(self):
        self.validate_required(self.request_id, 'request_id')
        self.validate_required(self.next_append_position, 'next_append_position')
        self.validate_required(self.hash_crc_64ecma, 'hash_crc_64ecma')

    def to_map(self):
        result = {}
        result['x-oss-request-id'] = self.request_id
        result['x-oss-next-append-position'] = self.next_append_position
        result['x-oss-hash-crc64ecma'] = self.hash_crc_64ecma
        return result

    def from_map(self, map={}):
        self.request_id = map.get('x-oss-request-id')
        self.next_append_position = map.get('x-oss-next-append-position')
        self.hash_crc_64ecma = map.get('x-oss-hash-crc64ecma')
        return self


class UploadPartCopyRequest(TeaModel):
    def __init__(self, bucket_name=None, object_name=None, filter=None, header=None):
        self.bucket_name = bucket_name
        self.object_name = object_name
        self.filter = filter
        self.header = header

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')
        self.validate_required(self.object_name, 'object_name')
        self.validate_required(self.filter, 'filter')
        if self.filter:
            self.filter.validate()
        self.validate_required(self.header, 'header')
        if self.header:
            self.header.validate()

    def to_map(self):
        result = {}
        result['BucketName'] = self.bucket_name
        result['ObjectName'] = self.object_name
        if self.filter is not None:
            result['Filter'] = self.filter.to_map()
        else:
            result['Filter'] = None
        if self.header is not None:
            result['Header'] = self.header.to_map()
        else:
            result['Header'] = None
        return result

    def from_map(self, map={}):
        self.bucket_name = map.get('BucketName')
        self.object_name = map.get('ObjectName')
        if map.get('Filter') is not None:
            temp_model = UploadPartCopyRequestFilter()
            self.filter = temp_model.from_map(map['Filter'])
        else:
            self.filter = None
        if map.get('Header') is not None:
            temp_model = UploadPartCopyRequestHeader()
            self.header = temp_model.from_map(map['Header'])
        else:
            self.header = None
        return self


class UploadPartCopyRequestFilter(TeaModel):
    def __init__(self, part_number=None, upload_id=None):
        self.part_number = part_number
        self.upload_id = upload_id

    def validate(self):
        self.validate_required(self.part_number, 'part_number')
        self.validate_required(self.upload_id, 'upload_id')

    def to_map(self):
        result = {}
        result['partNumber'] = self.part_number
        result['uploadId'] = self.upload_id
        return result

    def from_map(self, map={}):
        self.part_number = map.get('partNumber')
        self.upload_id = map.get('uploadId')
        return self


class UploadPartCopyRequestHeader(TeaModel):
    def __init__(self, copy_source=None, copy_source_range=None, copy_source_if_match=None, copy_source_if_none_match=None, copy_source_if_unmodified_since=None, copy_source_if_modified_since=None):
        self.copy_source = copy_source
        self.copy_source_range = copy_source_range
        self.copy_source_if_match = copy_source_if_match
        self.copy_source_if_none_match = copy_source_if_none_match
        self.copy_source_if_unmodified_since = copy_source_if_unmodified_since
        self.copy_source_if_modified_since = copy_source_if_modified_since

    def validate(self):
        self.validate_required(self.copy_source, 'copy_source')
        self.validate_required(self.copy_source_range, 'copy_source_range')

    def to_map(self):
        result = {}
        result['x-oss-copy-source'] = self.copy_source
        result['x-oss-copy-source-range'] = self.copy_source_range
        result['x-oss-copy-source-if-match'] = self.copy_source_if_match
        result['x-oss-copy-source-if-none-match'] = self.copy_source_if_none_match
        result['x-oss-copy-source-if-unmodified-since'] = self.copy_source_if_unmodified_since
        result['x-oss-copy-source-if-modified-since'] = self.copy_source_if_modified_since
        return result

    def from_map(self, map={}):
        self.copy_source = map.get('x-oss-copy-source')
        self.copy_source_range = map.get('x-oss-copy-source-range')
        self.copy_source_if_match = map.get('x-oss-copy-source-if-match')
        self.copy_source_if_none_match = map.get('x-oss-copy-source-if-none-match')
        self.copy_source_if_unmodified_since = map.get('x-oss-copy-source-if-unmodified-since')
        self.copy_source_if_modified_since = map.get('x-oss-copy-source-if-modified-since')
        return self


class UploadPartCopyResponse(TeaModel):
    def __init__(self, request_id=None, copy_part_result=None):
        self.request_id = request_id
        self.copy_part_result = copy_part_result

    def validate(self):
        self.validate_required(self.request_id, 'request_id')
        self.validate_required(self.copy_part_result, 'copy_part_result')
        if self.copy_part_result:
            self.copy_part_result.validate()

    def to_map(self):
        result = {}
        result['x-oss-request-id'] = self.request_id
        if self.copy_part_result is not None:
            result['CopyPartResult'] = self.copy_part_result.to_map()
        else:
            result['CopyPartResult'] = None
        return result

    def from_map(self, map={}):
        self.request_id = map.get('x-oss-request-id')
        if map.get('CopyPartResult') is not None:
            temp_model = UploadPartCopyResponseCopyPartResult()
            self.copy_part_result = temp_model.from_map(map['CopyPartResult'])
        else:
            self.copy_part_result = None
        return self


class UploadPartCopyResponseCopyPartResult(TeaModel):
    def __init__(self, last_modified=None, e_tag=None):
        self.last_modified = last_modified
        self.e_tag = e_tag

    def validate(self):
        pass

    def to_map(self):
        result = {}
        result['LastModified'] = self.last_modified
        result['ETag'] = self.e_tag
        return result

    def from_map(self, map={}):
        self.last_modified = map.get('LastModified')
        self.e_tag = map.get('ETag')
        return self


class GetVodPlaylistRequest(TeaModel):
    def __init__(self, bucket_name=None, channel_name=None, filter=None):
        self.bucket_name = bucket_name
        self.channel_name = channel_name
        self.filter = filter

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')
        self.validate_required(self.channel_name, 'channel_name')
        self.validate_required(self.filter, 'filter')
        if self.filter:
            self.filter.validate()

    def to_map(self):
        result = {}
        result['BucketName'] = self.bucket_name
        result['ChannelName'] = self.channel_name
        if self.filter is not None:
            result['Filter'] = self.filter.to_map()
        else:
            result['Filter'] = None
        return result

    def from_map(self, map={}):
        self.bucket_name = map.get('BucketName')
        self.channel_name = map.get('ChannelName')
        if map.get('Filter') is not None:
            temp_model = GetVodPlaylistRequestFilter()
            self.filter = temp_model.from_map(map['Filter'])
        else:
            self.filter = None
        return self


class GetVodPlaylistRequestFilter(TeaModel):
    def __init__(self, end_time=None, start_time=None):
        self.end_time = end_time
        self.start_time = start_time

    def validate(self):
        self.validate_required(self.end_time, 'end_time')
        self.validate_required(self.start_time, 'start_time')

    def to_map(self):
        result = {}
        result['endTime'] = self.end_time
        result['startTime'] = self.start_time
        return result

    def from_map(self, map={}):
        self.end_time = map.get('endTime')
        self.start_time = map.get('startTime')
        return self


class GetVodPlaylistResponse(TeaModel):
    def __init__(self, request_id=None):
        self.request_id = request_id

    def validate(self):
        self.validate_required(self.request_id, 'request_id')

    def to_map(self):
        result = {}
        result['x-oss-request-id'] = self.request_id
        return result

    def from_map(self, map={}):
        self.request_id = map.get('x-oss-request-id')
        return self


class DeleteBucketCORSRequest(TeaModel):
    def __init__(self, bucket_name=None):
        self.bucket_name = bucket_name

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')

    def to_map(self):
        result = {}
        result['BucketName'] = self.bucket_name
        return result

    def from_map(self, map={}):
        self.bucket_name = map.get('BucketName')
        return self


class DeleteBucketCORSResponse(TeaModel):
    def __init__(self, request_id=None):
        self.request_id = request_id

    def validate(self):
        self.validate_required(self.request_id, 'request_id')

    def to_map(self):
        result = {}
        result['x-oss-request-id'] = self.request_id
        return result

    def from_map(self, map={}):
        self.request_id = map.get('x-oss-request-id')
        return self


class GetObjectRequest(TeaModel):
    def __init__(self, bucket_name=None, object_name=None, header=None):
        self.bucket_name = bucket_name
        self.object_name = object_name
        self.header = header

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')
        self.validate_required(self.object_name, 'object_name')
        if self.header:
            self.header.validate()

    def to_map(self):
        result = {}
        result['BucketName'] = self.bucket_name
        result['ObjectName'] = self.object_name
        if self.header is not None:
            result['Header'] = self.header.to_map()
        else:
            result['Header'] = None
        return result

    def from_map(self, map={}):
        self.bucket_name = map.get('BucketName')
        self.object_name = map.get('ObjectName')
        if map.get('Header') is not None:
            temp_model = GetObjectRequestHeader()
            self.header = temp_model.from_map(map['Header'])
        else:
            self.header = None
        return self


class GetObjectRequestHeader(TeaModel):
    def __init__(self, response_content_type=None, response_content_language=None, response_expires=None, response_cache_control=None, response_content_disposition=None, response_content_encoding=None, range=None, if_modified_since=None, if_unmodified_since=None, if_match=None, if_none_match=None, accept_encoding=None):
        self.response_content_type = response_content_type
        self.response_content_language = response_content_language
        self.response_expires = response_expires
        self.response_cache_control = response_cache_control
        self.response_content_disposition = response_content_disposition
        self.response_content_encoding = response_content_encoding
        self.range = range
        self.if_modified_since = if_modified_since
        self.if_unmodified_since = if_unmodified_since
        self.if_match = if_match
        self.if_none_match = if_none_match
        self.accept_encoding = accept_encoding

    def validate(self):
        pass

    def to_map(self):
        result = {}
        result['response-content-type'] = self.response_content_type
        result['response-content-language'] = self.response_content_language
        result['response-expires'] = self.response_expires
        result['response-cache-control'] = self.response_cache_control
        result['response-content-disposition'] = self.response_content_disposition
        result['response-content-encoding'] = self.response_content_encoding
        result['Range'] = self.range
        result['If-Modified-Since'] = self.if_modified_since
        result['If-Unmodified-Since'] = self.if_unmodified_since
        result['If-Match'] = self.if_match
        result['If-None-Match'] = self.if_none_match
        result['Accept-Encoding'] = self.accept_encoding
        return result

    def from_map(self, map={}):
        self.response_content_type = map.get('response-content-type')
        self.response_content_language = map.get('response-content-language')
        self.response_expires = map.get('response-expires')
        self.response_cache_control = map.get('response-cache-control')
        self.response_content_disposition = map.get('response-content-disposition')
        self.response_content_encoding = map.get('response-content-encoding')
        self.range = map.get('Range')
        self.if_modified_since = map.get('If-Modified-Since')
        self.if_unmodified_since = map.get('If-Unmodified-Since')
        self.if_match = map.get('If-Match')
        self.if_none_match = map.get('If-None-Match')
        self.accept_encoding = map.get('Accept-Encoding')
        return self


class GetObjectResponse(TeaModel):
    def __init__(self, request_id=None, object_type=None, server_side_encryption=None, tagging_count=None, restore=None, body=None):
        self.request_id = request_id
        self.object_type = object_type
        self.server_side_encryption = server_side_encryption
        self.tagging_count = tagging_count
        self.restore = restore
        self.body = body

    def validate(self):
        self.validate_required(self.request_id, 'request_id')
        self.validate_required(self.object_type, 'object_type')
        self.validate_required(self.server_side_encryption, 'server_side_encryption')
        self.validate_required(self.tagging_count, 'tagging_count')
        self.validate_required(self.restore, 'restore')
        self.validate_required(self.body, 'body')

    def to_map(self):
        result = {}
        result['x-oss-request-id'] = self.request_id
        result['x-oss-object-type'] = self.object_type
        result['x-oss-server-side-encryption'] = self.server_side_encryption
        result['x-oss-tagging-count'] = self.tagging_count
        result['x-oss-restore'] = self.restore
        result['body'] = self.body
        return result

    def from_map(self, map={}):
        self.request_id = map.get('x-oss-request-id')
        self.object_type = map.get('x-oss-object-type')
        self.server_side_encryption = map.get('x-oss-server-side-encryption')
        self.tagging_count = map.get('x-oss-tagging-count')
        self.restore = map.get('x-oss-restore')
        self.body = map.get('body')
        return self


class UploadPartRequest(TeaModel):
    def __init__(self, bucket_name=None, object_name=None, body=None, filter=None):
        self.bucket_name = bucket_name
        self.object_name = object_name
        self.body = body
        self.filter = filter

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')
        self.validate_required(self.object_name, 'object_name')
        self.validate_required(self.filter, 'filter')
        if self.filter:
            self.filter.validate()

    def to_map(self):
        result = {}
        result['BucketName'] = self.bucket_name
        result['ObjectName'] = self.object_name
        result['body'] = self.body
        if self.filter is not None:
            result['Filter'] = self.filter.to_map()
        else:
            result['Filter'] = None
        return result

    def from_map(self, map={}):
        self.bucket_name = map.get('BucketName')
        self.object_name = map.get('ObjectName')
        self.body = map.get('body')
        if map.get('Filter') is not None:
            temp_model = UploadPartRequestFilter()
            self.filter = temp_model.from_map(map['Filter'])
        else:
            self.filter = None
        return self


class UploadPartRequestFilter(TeaModel):
    def __init__(self, part_number=None, upload_id=None):
        self.part_number = part_number
        self.upload_id = upload_id

    def validate(self):
        self.validate_required(self.part_number, 'part_number')
        self.validate_required(self.upload_id, 'upload_id')

    def to_map(self):
        result = {}
        result['partNumber'] = self.part_number
        result['uploadId'] = self.upload_id
        return result

    def from_map(self, map={}):
        self.part_number = map.get('partNumber')
        self.upload_id = map.get('uploadId')
        return self


class UploadPartResponse(TeaModel):
    def __init__(self, request_id=None):
        self.request_id = request_id

    def validate(self):
        self.validate_required(self.request_id, 'request_id')

    def to_map(self):
        result = {}
        result['x-oss-request-id'] = self.request_id
        return result

    def from_map(self, map={}):
        self.request_id = map.get('x-oss-request-id')
        return self


class GetBucketCORSRequest(TeaModel):
    def __init__(self, bucket_name=None):
        self.bucket_name = bucket_name

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')

    def to_map(self):
        result = {}
        result['BucketName'] = self.bucket_name
        return result

    def from_map(self, map={}):
        self.bucket_name = map.get('BucketName')
        return self


class GetBucketCORSResponse(TeaModel):
    def __init__(self, request_id=None, c_orsconfiguration=None):
        self.request_id = request_id
        self.c_orsconfiguration = c_orsconfiguration

    def validate(self):
        self.validate_required(self.request_id, 'request_id')
        self.validate_required(self.c_orsconfiguration, 'c_orsconfiguration')
        if self.c_orsconfiguration:
            self.c_orsconfiguration.validate()

    def to_map(self):
        result = {}
        result['x-oss-request-id'] = self.request_id
        if self.c_orsconfiguration is not None:
            result['CORSConfiguration'] = self.c_orsconfiguration.to_map()
        else:
            result['CORSConfiguration'] = None
        return result

    def from_map(self, map={}):
        self.request_id = map.get('x-oss-request-id')
        if map.get('CORSConfiguration') is not None:
            temp_model = GetBucketCORSResponseCORSConfiguration()
            self.c_orsconfiguration = temp_model.from_map(map['CORSConfiguration'])
        else:
            self.c_orsconfiguration = None
        return self


class GetBucketCORSResponseCORSConfigurationCORSRule(TeaModel):
    def __init__(self, max_age_seconds=None):
        self.max_age_seconds = max_age_seconds

    def validate(self):
        pass

    def to_map(self):
        result = {}
        result['MaxAgeSeconds'] = self.max_age_seconds
        return result

    def from_map(self, map={}):
        self.max_age_seconds = map.get('MaxAgeSeconds')
        return self


class GetBucketCORSResponseCORSConfiguration(TeaModel):
    def __init__(self, c_orsrule=None):
        self.c_orsrule = []

    def validate(self):
        if self.c_orsrule:
            for k in self.c_orsrule:
                if k :
                    k.validate()

    def to_map(self):
        result = {}
        result['CORSRule'] = []
        if self.c_orsrule is not None:
            for k in self.c_orsrule:
                result['CORSRule'].append(k.to_map() if k else None)
        else:
            result['CORSRule'] = None
        return result

    def from_map(self, map={}):
        self.c_orsrule = []
        if map.get('CORSRule') is not None:
            for k in map.get('CORSRule'):
                temp_model = GetBucketCORSResponseCORSConfigurationCORSRule()
                temp_model = temp_model.from_map(k)
                self.c_orsrule.append(temp_model)
        else:
            self.c_orsrule = None
        return self


class CopyObjectRequest(TeaModel):
    def __init__(self, bucket_name=None, dest_object_name=None, header=None):
        self.bucket_name = bucket_name
        self.dest_object_name = dest_object_name
        self.header = header

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')
        self.validate_required(self.dest_object_name, 'dest_object_name')
        self.validate_required(self.header, 'header')
        if self.header:
            self.header.validate()

    def to_map(self):
        result = {}
        result['BucketName'] = self.bucket_name
        result['DestObjectName'] = self.dest_object_name
        if self.header is not None:
            result['Header'] = self.header.to_map()
        else:
            result['Header'] = None
        return result

    def from_map(self, map={}):
        self.bucket_name = map.get('BucketName')
        self.dest_object_name = map.get('DestObjectName')
        if map.get('Header') is not None:
            temp_model = CopyObjectRequestHeader()
            self.header = temp_model.from_map(map['Header'])
        else:
            self.header = None
        return self


class CopyObjectRequestHeader(TeaModel):
    def __init__(self, copy_source=None, copy_source_if_match=None, copy_source_if_none_match=None, copy_source_if_unmodified_since=None, copy_source_if_modified_since=None, metadata_directive=None, server_side_encryption=None, server_side_encryption_key_id=None, object_acl=None, storage_class=None, tagging=None, tagging_directive=None):
        self.copy_source = copy_source
        self.copy_source_if_match = copy_source_if_match
        self.copy_source_if_none_match = copy_source_if_none_match
        self.copy_source_if_unmodified_since = copy_source_if_unmodified_since
        self.copy_source_if_modified_since = copy_source_if_modified_since
        self.metadata_directive = metadata_directive
        self.server_side_encryption = server_side_encryption
        self.server_side_encryption_key_id = server_side_encryption_key_id
        self.object_acl = object_acl
        self.storage_class = storage_class
        self.tagging = tagging
        self.tagging_directive = tagging_directive

    def validate(self):
        self.validate_required(self.copy_source, 'copy_source')

    def to_map(self):
        result = {}
        result['x-oss-copy-source'] = self.copy_source
        result['x-oss-copy-source-if-match'] = self.copy_source_if_match
        result['x-oss-copy-source-if-none-match'] = self.copy_source_if_none_match
        result['x-oss-copy-source-if-unmodified-since'] = self.copy_source_if_unmodified_since
        result['x-oss-copy-source-if-modified-since'] = self.copy_source_if_modified_since
        result['x-oss-metadata-directive'] = self.metadata_directive
        result['x-oss-server-side-encryption'] = self.server_side_encryption
        result['x-oss-server-side-encryption-key-id'] = self.server_side_encryption_key_id
        result['x-oss-object-acl'] = self.object_acl
        result['x-oss-storage-class'] = self.storage_class
        result['x-oss-tagging'] = self.tagging
        result['x-oss-tagging-directive'] = self.tagging_directive
        return result

    def from_map(self, map={}):
        self.copy_source = map.get('x-oss-copy-source')
        self.copy_source_if_match = map.get('x-oss-copy-source-if-match')
        self.copy_source_if_none_match = map.get('x-oss-copy-source-if-none-match')
        self.copy_source_if_unmodified_since = map.get('x-oss-copy-source-if-unmodified-since')
        self.copy_source_if_modified_since = map.get('x-oss-copy-source-if-modified-since')
        self.metadata_directive = map.get('x-oss-metadata-directive')
        self.server_side_encryption = map.get('x-oss-server-side-encryption')
        self.server_side_encryption_key_id = map.get('x-oss-server-side-encryption-key-id')
        self.object_acl = map.get('x-oss-object-acl')
        self.storage_class = map.get('x-oss-storage-class')
        self.tagging = map.get('x-oss-tagging')
        self.tagging_directive = map.get('x-oss-tagging-directive')
        return self


class CopyObjectResponse(TeaModel):
    def __init__(self, request_id=None, copy_object_result=None):
        self.request_id = request_id
        self.copy_object_result = copy_object_result

    def validate(self):
        self.validate_required(self.request_id, 'request_id')
        self.validate_required(self.copy_object_result, 'copy_object_result')
        if self.copy_object_result:
            self.copy_object_result.validate()

    def to_map(self):
        result = {}
        result['x-oss-request-id'] = self.request_id
        if self.copy_object_result is not None:
            result['CopyObjectResult'] = self.copy_object_result.to_map()
        else:
            result['CopyObjectResult'] = None
        return result

    def from_map(self, map={}):
        self.request_id = map.get('x-oss-request-id')
        if map.get('CopyObjectResult') is not None:
            temp_model = CopyObjectResponseCopyObjectResult()
            self.copy_object_result = temp_model.from_map(map['CopyObjectResult'])
        else:
            self.copy_object_result = None
        return self


class CopyObjectResponseCopyObjectResult(TeaModel):
    def __init__(self, last_modified=None, e_tag=None):
        self.last_modified = last_modified
        self.e_tag = e_tag

    def validate(self):
        pass

    def to_map(self):
        result = {}
        result['LastModified'] = self.last_modified
        result['ETag'] = self.e_tag
        return result

    def from_map(self, map={}):
        self.last_modified = map.get('LastModified')
        self.e_tag = map.get('ETag')
        return self


class GetObjectTaggingRequest(TeaModel):
    def __init__(self, bucket_name=None, object_name=None):
        self.bucket_name = bucket_name
        self.object_name = object_name

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')
        self.validate_required(self.object_name, 'object_name')

    def to_map(self):
        result = {}
        result['BucketName'] = self.bucket_name
        result['ObjectName'] = self.object_name
        return result

    def from_map(self, map={}):
        self.bucket_name = map.get('BucketName')
        self.object_name = map.get('ObjectName')
        return self


class GetObjectTaggingResponse(TeaModel):
    def __init__(self, request_id=None, tagging=None):
        self.request_id = request_id
        self.tagging = tagging

    def validate(self):
        self.validate_required(self.request_id, 'request_id')
        self.validate_required(self.tagging, 'tagging')
        if self.tagging:
            self.tagging.validate()

    def to_map(self):
        result = {}
        result['x-oss-request-id'] = self.request_id
        if self.tagging is not None:
            result['Tagging'] = self.tagging.to_map()
        else:
            result['Tagging'] = None
        return result

    def from_map(self, map={}):
        self.request_id = map.get('x-oss-request-id')
        if map.get('Tagging') is not None:
            temp_model = GetObjectTaggingResponseTagging()
            self.tagging = temp_model.from_map(map['Tagging'])
        else:
            self.tagging = None
        return self


class GetObjectTaggingResponseTaggingTagSetTag(TeaModel):
    def __init__(self, key=None, value=None):
        self.key = key
        self.value = value

    def validate(self):
        pass

    def to_map(self):
        result = {}
        result['Key'] = self.key
        result['Value'] = self.value
        return result

    def from_map(self, map={}):
        self.key = map.get('Key')
        self.value = map.get('Value')
        return self


class GetObjectTaggingResponseTaggingTagSet(TeaModel):
    def __init__(self, tag=None):
        self.tag = []

    def validate(self):
        if self.tag:
            for k in self.tag:
                if k :
                    k.validate()

    def to_map(self):
        result = {}
        result['Tag'] = []
        if self.tag is not None:
            for k in self.tag:
                result['Tag'].append(k.to_map() if k else None)
        else:
            result['Tag'] = None
        return result

    def from_map(self, map={}):
        self.tag = []
        if map.get('Tag') is not None:
            for k in map.get('Tag'):
                temp_model = GetObjectTaggingResponseTaggingTagSetTag()
                temp_model = temp_model.from_map(k)
                self.tag.append(temp_model)
        else:
            self.tag = None
        return self


class GetObjectTaggingResponseTagging(TeaModel):
    def __init__(self, tag_set=None):
        self.tag_set = tag_set

    def validate(self):
        self.validate_required(self.tag_set, 'tag_set')
        if self.tag_set:
            self.tag_set.validate()

    def to_map(self):
        result = {}
        if self.tag_set is not None:
            result['TagSet'] = self.tag_set.to_map()
        else:
            result['TagSet'] = None
        return result

    def from_map(self, map={}):
        if map.get('TagSet') is not None:
            temp_model = GetObjectTaggingResponseTaggingTagSet()
            self.tag_set = temp_model.from_map(map['TagSet'])
        else:
            self.tag_set = None
        return self


class DeleteBucketLifecycleRequest(TeaModel):
    def __init__(self, bucket_name=None):
        self.bucket_name = bucket_name

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')

    def to_map(self):
        result = {}
        result['BucketName'] = self.bucket_name
        return result

    def from_map(self, map={}):
        self.bucket_name = map.get('BucketName')
        return self


class DeleteBucketLifecycleResponse(TeaModel):
    def __init__(self, request_id=None):
        self.request_id = request_id

    def validate(self):
        self.validate_required(self.request_id, 'request_id')

    def to_map(self):
        result = {}
        result['x-oss-request-id'] = self.request_id
        return result

    def from_map(self, map={}):
        self.request_id = map.get('x-oss-request-id')
        return self


class DeleteBucketLoggingRequest(TeaModel):
    def __init__(self, bucket_name=None):
        self.bucket_name = bucket_name

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')

    def to_map(self):
        result = {}
        result['BucketName'] = self.bucket_name
        return result

    def from_map(self, map={}):
        self.bucket_name = map.get('BucketName')
        return self


class DeleteBucketLoggingResponse(TeaModel):
    def __init__(self, request_id=None):
        self.request_id = request_id

    def validate(self):
        self.validate_required(self.request_id, 'request_id')

    def to_map(self):
        result = {}
        result['x-oss-request-id'] = self.request_id
        return result

    def from_map(self, map={}):
        self.request_id = map.get('x-oss-request-id')
        return self


class DeleteBucketWebsiteRequest(TeaModel):
    def __init__(self, bucket_name=None):
        self.bucket_name = bucket_name

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')

    def to_map(self):
        result = {}
        result['BucketName'] = self.bucket_name
        return result

    def from_map(self, map={}):
        self.bucket_name = map.get('BucketName')
        return self


class DeleteBucketWebsiteResponse(TeaModel):
    def __init__(self, request_id=None):
        self.request_id = request_id

    def validate(self):
        self.validate_required(self.request_id, 'request_id')

    def to_map(self):
        result = {}
        result['x-oss-request-id'] = self.request_id
        return result

    def from_map(self, map={}):
        self.request_id = map.get('x-oss-request-id')
        return self


class GetSymlinkRequest(TeaModel):
    def __init__(self, bucket_name=None, object_name=None):
        self.bucket_name = bucket_name
        self.object_name = object_name

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')
        self.validate_required(self.object_name, 'object_name')

    def to_map(self):
        result = {}
        result['BucketName'] = self.bucket_name
        result['ObjectName'] = self.object_name
        return result

    def from_map(self, map={}):
        self.bucket_name = map.get('BucketName')
        self.object_name = map.get('ObjectName')
        return self


class GetSymlinkResponse(TeaModel):
    def __init__(self, request_id=None, symlink_target=None):
        self.request_id = request_id
        self.symlink_target = symlink_target

    def validate(self):
        self.validate_required(self.request_id, 'request_id')
        self.validate_required(self.symlink_target, 'symlink_target')

    def to_map(self):
        result = {}
        result['x-oss-request-id'] = self.request_id
        result['x-oss-symlink-target'] = self.symlink_target
        return result

    def from_map(self, map={}):
        self.request_id = map.get('x-oss-request-id')
        self.symlink_target = map.get('x-oss-symlink-target')
        return self


class GetBucketLifecycleRequest(TeaModel):
    def __init__(self, bucket_name=None):
        self.bucket_name = bucket_name

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')

    def to_map(self):
        result = {}
        result['BucketName'] = self.bucket_name
        return result

    def from_map(self, map={}):
        self.bucket_name = map.get('BucketName')
        return self


class GetBucketLifecycleResponse(TeaModel):
    def __init__(self, request_id=None, lifecycle_configuration=None):
        self.request_id = request_id
        self.lifecycle_configuration = lifecycle_configuration

    def validate(self):
        self.validate_required(self.request_id, 'request_id')
        self.validate_required(self.lifecycle_configuration, 'lifecycle_configuration')
        if self.lifecycle_configuration:
            self.lifecycle_configuration.validate()

    def to_map(self):
        result = {}
        result['x-oss-request-id'] = self.request_id
        if self.lifecycle_configuration is not None:
            result['LifecycleConfiguration'] = self.lifecycle_configuration.to_map()
        else:
            result['LifecycleConfiguration'] = None
        return result

    def from_map(self, map={}):
        self.request_id = map.get('x-oss-request-id')
        if map.get('LifecycleConfiguration') is not None:
            temp_model = GetBucketLifecycleResponseLifecycleConfiguration()
            self.lifecycle_configuration = temp_model.from_map(map['LifecycleConfiguration'])
        else:
            self.lifecycle_configuration = None
        return self


class GetBucketLifecycleResponseLifecycleConfigurationRuleExpiration(TeaModel):
    def __init__(self, days=None, created_before_date=None):
        self.days = days
        self.created_before_date = created_before_date

    def validate(self):
        pass

    def to_map(self):
        result = {}
        result['Days'] = self.days
        result['CreatedBeforeDate'] = self.created_before_date
        return result

    def from_map(self, map={}):
        self.days = map.get('Days')
        self.created_before_date = map.get('CreatedBeforeDate')
        return self


class GetBucketLifecycleResponseLifecycleConfigurationRuleTransition(TeaModel):
    def __init__(self, days=None, storage_class=None):
        self.days = days
        self.storage_class = storage_class

    def validate(self):
        pass

    def to_map(self):
        result = {}
        result['Days'] = self.days
        result['StorageClass'] = self.storage_class
        return result

    def from_map(self, map={}):
        self.days = map.get('Days')
        self.storage_class = map.get('StorageClass')
        return self


class GetBucketLifecycleResponseLifecycleConfigurationRuleAbortMultipartUpload(TeaModel):
    def __init__(self, days=None, created_before_date=None):
        self.days = days
        self.created_before_date = created_before_date

    def validate(self):
        pass

    def to_map(self):
        result = {}
        result['Days'] = self.days
        result['CreatedBeforeDate'] = self.created_before_date
        return result

    def from_map(self, map={}):
        self.days = map.get('Days')
        self.created_before_date = map.get('CreatedBeforeDate')
        return self


class GetBucketLifecycleResponseLifecycleConfigurationRuleTag(TeaModel):
    def __init__(self, key=None, value=None):
        self.key = key
        self.value = value

    def validate(self):
        pass

    def to_map(self):
        result = {}
        result['Key'] = self.key
        result['Value'] = self.value
        return result

    def from_map(self, map={}):
        self.key = map.get('Key')
        self.value = map.get('Value')
        return self


class GetBucketLifecycleResponseLifecycleConfigurationRule(TeaModel):
    def __init__(self, i_d=None, prefix=None, status=None, expiration=None, transition=None, abort_multipart_upload=None, tag=None):
        self.i_d = i_d
        self.prefix = prefix
        self.status = status
        self.expiration = expiration
        self.transition = transition
        self.abort_multipart_upload = abort_multipart_upload
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
        result = {}
        result['ID'] = self.i_d
        result['Prefix'] = self.prefix
        result['Status'] = self.status
        if self.expiration is not None:
            result['Expiration'] = self.expiration.to_map()
        else:
            result['Expiration'] = None
        if self.transition is not None:
            result['Transition'] = self.transition.to_map()
        else:
            result['Transition'] = None
        if self.abort_multipart_upload is not None:
            result['AbortMultipartUpload'] = self.abort_multipart_upload.to_map()
        else:
            result['AbortMultipartUpload'] = None
        if self.tag is not None:
            result['Tag'] = self.tag.to_map()
        else:
            result['Tag'] = None
        return result

    def from_map(self, map={}):
        self.i_d = map.get('ID')
        self.prefix = map.get('Prefix')
        self.status = map.get('Status')
        if map.get('Expiration') is not None:
            temp_model = GetBucketLifecycleResponseLifecycleConfigurationRuleExpiration()
            self.expiration = temp_model.from_map(map['Expiration'])
        else:
            self.expiration = None
        if map.get('Transition') is not None:
            temp_model = GetBucketLifecycleResponseLifecycleConfigurationRuleTransition()
            self.transition = temp_model.from_map(map['Transition'])
        else:
            self.transition = None
        if map.get('AbortMultipartUpload') is not None:
            temp_model = GetBucketLifecycleResponseLifecycleConfigurationRuleAbortMultipartUpload()
            self.abort_multipart_upload = temp_model.from_map(map['AbortMultipartUpload'])
        else:
            self.abort_multipart_upload = None
        if map.get('Tag') is not None:
            temp_model = GetBucketLifecycleResponseLifecycleConfigurationRuleTag()
            self.tag = temp_model.from_map(map['Tag'])
        else:
            self.tag = None
        return self


class GetBucketLifecycleResponseLifecycleConfiguration(TeaModel):
    def __init__(self, rule=None):
        self.rule = []

    def validate(self):
        if self.rule:
            for k in self.rule:
                if k :
                    k.validate()

    def to_map(self):
        result = {}
        result['Rule'] = []
        if self.rule is not None:
            for k in self.rule:
                result['Rule'].append(k.to_map() if k else None)
        else:
            result['Rule'] = None
        return result

    def from_map(self, map={}):
        self.rule = []
        if map.get('Rule') is not None:
            for k in map.get('Rule'):
                temp_model = GetBucketLifecycleResponseLifecycleConfigurationRule()
                temp_model = temp_model.from_map(k)
                self.rule.append(temp_model)
        else:
            self.rule = None
        return self


class PutSymlinkRequest(TeaModel):
    def __init__(self, bucket_name=None, object_name=None, header=None):
        self.bucket_name = bucket_name
        self.object_name = object_name
        self.header = header

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')
        self.validate_required(self.object_name, 'object_name')
        self.validate_required(self.header, 'header')
        if self.header:
            self.header.validate()

    def to_map(self):
        result = {}
        result['BucketName'] = self.bucket_name
        result['ObjectName'] = self.object_name
        if self.header is not None:
            result['Header'] = self.header.to_map()
        else:
            result['Header'] = None
        return result

    def from_map(self, map={}):
        self.bucket_name = map.get('BucketName')
        self.object_name = map.get('ObjectName')
        if map.get('Header') is not None:
            temp_model = PutSymlinkRequestHeader()
            self.header = temp_model.from_map(map['Header'])
        else:
            self.header = None
        return self


class PutSymlinkRequestHeader(TeaModel):
    def __init__(self, symlink_target=None, storage_class=None):
        self.symlink_target = symlink_target
        self.storage_class = storage_class

    def validate(self):
        self.validate_required(self.symlink_target, 'symlink_target')

    def to_map(self):
        result = {}
        result['x-oss-symlink-target'] = self.symlink_target
        result['x-oss-storage-class'] = self.storage_class
        return result

    def from_map(self, map={}):
        self.symlink_target = map.get('x-oss-symlink-target')
        self.storage_class = map.get('x-oss-storage-class')
        return self


class PutSymlinkResponse(TeaModel):
    def __init__(self, request_id=None):
        self.request_id = request_id

    def validate(self):
        self.validate_required(self.request_id, 'request_id')

    def to_map(self):
        result = {}
        result['x-oss-request-id'] = self.request_id
        return result

    def from_map(self, map={}):
        self.request_id = map.get('x-oss-request-id')
        return self


class GetBucketRefererRequest(TeaModel):
    def __init__(self, bucket_name=None):
        self.bucket_name = bucket_name

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')

    def to_map(self):
        result = {}
        result['BucketName'] = self.bucket_name
        return result

    def from_map(self, map={}):
        self.bucket_name = map.get('BucketName')
        return self


class GetBucketRefererResponse(TeaModel):
    def __init__(self, request_id=None, referer_configuration=None):
        self.request_id = request_id
        self.referer_configuration = referer_configuration

    def validate(self):
        self.validate_required(self.request_id, 'request_id')
        self.validate_required(self.referer_configuration, 'referer_configuration')
        if self.referer_configuration:
            self.referer_configuration.validate()

    def to_map(self):
        result = {}
        result['x-oss-request-id'] = self.request_id
        if self.referer_configuration is not None:
            result['RefererConfiguration'] = self.referer_configuration.to_map()
        else:
            result['RefererConfiguration'] = None
        return result

    def from_map(self, map={}):
        self.request_id = map.get('x-oss-request-id')
        if map.get('RefererConfiguration') is not None:
            temp_model = GetBucketRefererResponseRefererConfiguration()
            self.referer_configuration = temp_model.from_map(map['RefererConfiguration'])
        else:
            self.referer_configuration = None
        return self


class GetBucketRefererResponseRefererConfigurationRefererList(TeaModel):
    def __init__(self, referer=None):
        self.referer = []

    def validate(self):
        pass

    def to_map(self):
        result = {}
        result['Referer'] = []
        if self.referer is not None:
            for k in self.referer:
                result['Referer'].append(k)
        else:
            result['Referer'] = None
        return result

    def from_map(self, map={}):
        self.referer = []
        if map.get('Referer') is not None:
            for k in map.get('Referer'):
                self.referer.append(k)
        else:
            self.referer = None
        return self


class GetBucketRefererResponseRefererConfiguration(TeaModel):
    def __init__(self, allow_empty_referer=None, referer_list=None):
        self.allow_empty_referer = allow_empty_referer
        self.referer_list = referer_list

    def validate(self):
        self.validate_required(self.referer_list, 'referer_list')
        if self.referer_list:
            self.referer_list.validate()

    def to_map(self):
        result = {}
        result['AllowEmptyReferer'] = self.allow_empty_referer
        if self.referer_list is not None:
            result['RefererList'] = self.referer_list.to_map()
        else:
            result['RefererList'] = None
        return result

    def from_map(self, map={}):
        self.allow_empty_referer = map.get('AllowEmptyReferer')
        if map.get('RefererList') is not None:
            temp_model = GetBucketRefererResponseRefererConfigurationRefererList()
            self.referer_list = temp_model.from_map(map['RefererList'])
        else:
            self.referer_list = None
        return self


class CallbackRequest(TeaModel):
    def __init__(self, bucket_name=None):
        self.bucket_name = bucket_name

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')

    def to_map(self):
        result = {}
        result['BucketName'] = self.bucket_name
        return result

    def from_map(self, map={}):
        self.bucket_name = map.get('BucketName')
        return self


class CallbackResponse(TeaModel):
    def __init__(self, request_id=None):
        self.request_id = request_id

    def validate(self):
        self.validate_required(self.request_id, 'request_id')

    def to_map(self):
        result = {}
        result['x-oss-request-id'] = self.request_id
        return result

    def from_map(self, map={}):
        self.request_id = map.get('x-oss-request-id')
        return self


class GetBucketLoggingRequest(TeaModel):
    def __init__(self, bucket_name=None):
        self.bucket_name = bucket_name

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')

    def to_map(self):
        result = {}
        result['BucketName'] = self.bucket_name
        return result

    def from_map(self, map={}):
        self.bucket_name = map.get('BucketName')
        return self


class GetBucketLoggingResponse(TeaModel):
    def __init__(self, request_id=None, bucket_logging_status=None):
        self.request_id = request_id
        self.bucket_logging_status = bucket_logging_status

    def validate(self):
        self.validate_required(self.request_id, 'request_id')
        self.validate_required(self.bucket_logging_status, 'bucket_logging_status')
        if self.bucket_logging_status:
            self.bucket_logging_status.validate()

    def to_map(self):
        result = {}
        result['x-oss-request-id'] = self.request_id
        if self.bucket_logging_status is not None:
            result['BucketLoggingStatus'] = self.bucket_logging_status.to_map()
        else:
            result['BucketLoggingStatus'] = None
        return result

    def from_map(self, map={}):
        self.request_id = map.get('x-oss-request-id')
        if map.get('BucketLoggingStatus') is not None:
            temp_model = GetBucketLoggingResponseBucketLoggingStatus()
            self.bucket_logging_status = temp_model.from_map(map['BucketLoggingStatus'])
        else:
            self.bucket_logging_status = None
        return self


class GetBucketLoggingResponseBucketLoggingStatusLoggingEnabled(TeaModel):
    def __init__(self, target_bucket=None, target_prefix=None):
        self.target_bucket = target_bucket
        self.target_prefix = target_prefix

    def validate(self):
        pass

    def to_map(self):
        result = {}
        result['TargetBucket'] = self.target_bucket
        result['TargetPrefix'] = self.target_prefix
        return result

    def from_map(self, map={}):
        self.target_bucket = map.get('TargetBucket')
        self.target_prefix = map.get('TargetPrefix')
        return self


class GetBucketLoggingResponseBucketLoggingStatus(TeaModel):
    def __init__(self, logging_enabled=None):
        self.logging_enabled = logging_enabled

    def validate(self):
        self.validate_required(self.logging_enabled, 'logging_enabled')
        if self.logging_enabled:
            self.logging_enabled.validate()

    def to_map(self):
        result = {}
        if self.logging_enabled is not None:
            result['LoggingEnabled'] = self.logging_enabled.to_map()
        else:
            result['LoggingEnabled'] = None
        return result

    def from_map(self, map={}):
        if map.get('LoggingEnabled') is not None:
            temp_model = GetBucketLoggingResponseBucketLoggingStatusLoggingEnabled()
            self.logging_enabled = temp_model.from_map(map['LoggingEnabled'])
        else:
            self.logging_enabled = None
        return self


class PutObjectAclRequest(TeaModel):
    def __init__(self, bucket_name=None, object_name=None, header=None):
        self.bucket_name = bucket_name
        self.object_name = object_name
        self.header = header

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')
        self.validate_required(self.object_name, 'object_name')
        self.validate_required(self.header, 'header')
        if self.header:
            self.header.validate()

    def to_map(self):
        result = {}
        result['BucketName'] = self.bucket_name
        result['ObjectName'] = self.object_name
        if self.header is not None:
            result['Header'] = self.header.to_map()
        else:
            result['Header'] = None
        return result

    def from_map(self, map={}):
        self.bucket_name = map.get('BucketName')
        self.object_name = map.get('ObjectName')
        if map.get('Header') is not None:
            temp_model = PutObjectAclRequestHeader()
            self.header = temp_model.from_map(map['Header'])
        else:
            self.header = None
        return self


class PutObjectAclRequestHeader(TeaModel):
    def __init__(self, object_acl=None):
        self.object_acl = object_acl

    def validate(self):
        self.validate_required(self.object_acl, 'object_acl')

    def to_map(self):
        result = {}
        result['x-oss-object-acl'] = self.object_acl
        return result

    def from_map(self, map={}):
        self.object_acl = map.get('x-oss-object-acl')
        return self


class PutObjectAclResponse(TeaModel):
    def __init__(self, request_id=None):
        self.request_id = request_id

    def validate(self):
        self.validate_required(self.request_id, 'request_id')

    def to_map(self):
        result = {}
        result['x-oss-request-id'] = self.request_id
        return result

    def from_map(self, map={}):
        self.request_id = map.get('x-oss-request-id')
        return self


class GetBucketInfoRequest(TeaModel):
    def __init__(self, bucket_name=None):
        self.bucket_name = bucket_name

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')

    def to_map(self):
        result = {}
        result['BucketName'] = self.bucket_name
        return result

    def from_map(self, map={}):
        self.bucket_name = map.get('BucketName')
        return self


class GetBucketInfoResponse(TeaModel):
    def __init__(self, request_id=None, bucket_info=None):
        self.request_id = request_id
        self.bucket_info = bucket_info

    def validate(self):
        self.validate_required(self.request_id, 'request_id')
        self.validate_required(self.bucket_info, 'bucket_info')
        if self.bucket_info:
            self.bucket_info.validate()

    def to_map(self):
        result = {}
        result['x-oss-request-id'] = self.request_id
        if self.bucket_info is not None:
            result['BucketInfo'] = self.bucket_info.to_map()
        else:
            result['BucketInfo'] = None
        return result

    def from_map(self, map={}):
        self.request_id = map.get('x-oss-request-id')
        if map.get('BucketInfo') is not None:
            temp_model = GetBucketInfoResponseBucketInfo()
            self.bucket_info = temp_model.from_map(map['BucketInfo'])
        else:
            self.bucket_info = None
        return self


class GetBucketInfoResponseBucketInfoBucketOwner(TeaModel):
    def __init__(self, i_d=None, display_name=None):
        self.i_d = i_d
        self.display_name = display_name

    def validate(self):
        pass

    def to_map(self):
        result = {}
        result['ID'] = self.i_d
        result['DisplayName'] = self.display_name
        return result

    def from_map(self, map={}):
        self.i_d = map.get('ID')
        self.display_name = map.get('DisplayName')
        return self


class GetBucketInfoResponseBucketInfoBucketAccessControlList(TeaModel):
    def __init__(self, grant=None):
        self.grant = grant

    def validate(self):
        pass

    def to_map(self):
        result = {}
        result['Grant'] = self.grant
        return result

    def from_map(self, map={}):
        self.grant = map.get('Grant')
        return self


class GetBucketInfoResponseBucketInfoBucket(TeaModel):
    def __init__(self, creation_date=None, extranet_endpoint=None, intranet_endpoint=None, location=None, name=None, data_redundancy_type=None, storage_class=None, comment=None, owner=None, access_control_list=None):
        self.creation_date = creation_date
        self.extranet_endpoint = extranet_endpoint
        self.intranet_endpoint = intranet_endpoint
        self.location = location
        self.name = name
        self.data_redundancy_type = data_redundancy_type
        self.storage_class = storage_class
        self.comment = comment
        self.owner = owner
        self.access_control_list = access_control_list

    def validate(self):
        self.validate_required(self.owner, 'owner')
        if self.owner:
            self.owner.validate()
        self.validate_required(self.access_control_list, 'access_control_list')
        if self.access_control_list:
            self.access_control_list.validate()

    def to_map(self):
        result = {}
        result['CreationDate'] = self.creation_date
        result['ExtranetEndpoint'] = self.extranet_endpoint
        result['IntranetEndpoint'] = self.intranet_endpoint
        result['Location'] = self.location
        result['Name'] = self.name
        result['DataRedundancyType'] = self.data_redundancy_type
        result['StorageClass'] = self.storage_class
        result['Comment'] = self.comment
        if self.owner is not None:
            result['Owner'] = self.owner.to_map()
        else:
            result['Owner'] = None
        if self.access_control_list is not None:
            result['AccessControlList'] = self.access_control_list.to_map()
        else:
            result['AccessControlList'] = None
        return result

    def from_map(self, map={}):
        self.creation_date = map.get('CreationDate')
        self.extranet_endpoint = map.get('ExtranetEndpoint')
        self.intranet_endpoint = map.get('IntranetEndpoint')
        self.location = map.get('Location')
        self.name = map.get('Name')
        self.data_redundancy_type = map.get('DataRedundancyType')
        self.storage_class = map.get('StorageClass')
        self.comment = map.get('Comment')
        if map.get('Owner') is not None:
            temp_model = GetBucketInfoResponseBucketInfoBucketOwner()
            self.owner = temp_model.from_map(map['Owner'])
        else:
            self.owner = None
        if map.get('AccessControlList') is not None:
            temp_model = GetBucketInfoResponseBucketInfoBucketAccessControlList()
            self.access_control_list = temp_model.from_map(map['AccessControlList'])
        else:
            self.access_control_list = None
        return self


class GetBucketInfoResponseBucketInfo(TeaModel):
    def __init__(self, bucket=None):
        self.bucket = bucket

    def validate(self):
        self.validate_required(self.bucket, 'bucket')
        if self.bucket:
            self.bucket.validate()

    def to_map(self):
        result = {}
        if self.bucket is not None:
            result['Bucket'] = self.bucket.to_map()
        else:
            result['Bucket'] = None
        return result

    def from_map(self, map={}):
        if map.get('Bucket') is not None:
            temp_model = GetBucketInfoResponseBucketInfoBucket()
            self.bucket = temp_model.from_map(map['Bucket'])
        else:
            self.bucket = None
        return self


class PutLiveChannelStatusRequest(TeaModel):
    def __init__(self, bucket_name=None, channel_name=None, filter=None):
        self.bucket_name = bucket_name
        self.channel_name = channel_name
        self.filter = filter

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')
        self.validate_required(self.channel_name, 'channel_name')
        self.validate_required(self.filter, 'filter')
        if self.filter:
            self.filter.validate()

    def to_map(self):
        result = {}
        result['BucketName'] = self.bucket_name
        result['ChannelName'] = self.channel_name
        if self.filter is not None:
            result['Filter'] = self.filter.to_map()
        else:
            result['Filter'] = None
        return result

    def from_map(self, map={}):
        self.bucket_name = map.get('BucketName')
        self.channel_name = map.get('ChannelName')
        if map.get('Filter') is not None:
            temp_model = PutLiveChannelStatusRequestFilter()
            self.filter = temp_model.from_map(map['Filter'])
        else:
            self.filter = None
        return self


class PutLiveChannelStatusRequestFilter(TeaModel):
    def __init__(self, status=None):
        self.status = status

    def validate(self):
        self.validate_required(self.status, 'status')

    def to_map(self):
        result = {}
        result['status'] = self.status
        return result

    def from_map(self, map={}):
        self.status = map.get('status')
        return self


class PutLiveChannelStatusResponse(TeaModel):
    def __init__(self, request_id=None):
        self.request_id = request_id

    def validate(self):
        self.validate_required(self.request_id, 'request_id')

    def to_map(self):
        result = {}
        result['x-oss-request-id'] = self.request_id
        return result

    def from_map(self, map={}):
        self.request_id = map.get('x-oss-request-id')
        return self


class InitiateMultipartUploadRequest(TeaModel):
    def __init__(self, bucket_name=None, object_name=None, filter=None, header=None):
        self.bucket_name = bucket_name
        self.object_name = object_name
        self.filter = filter
        self.header = header

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')
        self.validate_required(self.object_name, 'object_name')
        if self.filter:
            self.filter.validate()
        if self.header:
            self.header.validate()

    def to_map(self):
        result = {}
        result['BucketName'] = self.bucket_name
        result['ObjectName'] = self.object_name
        if self.filter is not None:
            result['Filter'] = self.filter.to_map()
        else:
            result['Filter'] = None
        if self.header is not None:
            result['Header'] = self.header.to_map()
        else:
            result['Header'] = None
        return result

    def from_map(self, map={}):
        self.bucket_name = map.get('BucketName')
        self.object_name = map.get('ObjectName')
        if map.get('Filter') is not None:
            temp_model = InitiateMultipartUploadRequestFilter()
            self.filter = temp_model.from_map(map['Filter'])
        else:
            self.filter = None
        if map.get('Header') is not None:
            temp_model = InitiateMultipartUploadRequestHeader()
            self.header = temp_model.from_map(map['Header'])
        else:
            self.header = None
        return self


class InitiateMultipartUploadRequestFilter(TeaModel):
    def __init__(self, encoding_type=None):
        self.encoding_type = encoding_type

    def validate(self):
        pass

    def to_map(self):
        result = {}
        result['encoding-type'] = self.encoding_type
        return result

    def from_map(self, map={}):
        self.encoding_type = map.get('encoding-type')
        return self


class InitiateMultipartUploadRequestHeader(TeaModel):
    def __init__(self, cache_control=None, content_disposition=None, content_encoding=None, expires=None, server_side_encryption=None, server_side_encryption_key_id=None, storage_class=None, tagging=None, content_type=None):
        self.cache_control = cache_control
        self.content_disposition = content_disposition
        self.content_encoding = content_encoding
        self.expires = expires
        self.server_side_encryption = server_side_encryption
        self.server_side_encryption_key_id = server_side_encryption_key_id
        self.storage_class = storage_class
        self.tagging = tagging
        self.content_type = content_type

    def validate(self):
        pass

    def to_map(self):
        result = {}
        result['Cache-Control'] = self.cache_control
        result['Content-Disposition'] = self.content_disposition
        result['Content-Encoding'] = self.content_encoding
        result['Expires'] = self.expires
        result['x-oss-server-side-encryption'] = self.server_side_encryption
        result['x-oss-server-side-encryption-key-id'] = self.server_side_encryption_key_id
        result['x-oss-storage-class'] = self.storage_class
        result['x-oss-tagging'] = self.tagging
        result['content-type'] = self.content_type
        return result

    def from_map(self, map={}):
        self.cache_control = map.get('Cache-Control')
        self.content_disposition = map.get('Content-Disposition')
        self.content_encoding = map.get('Content-Encoding')
        self.expires = map.get('Expires')
        self.server_side_encryption = map.get('x-oss-server-side-encryption')
        self.server_side_encryption_key_id = map.get('x-oss-server-side-encryption-key-id')
        self.storage_class = map.get('x-oss-storage-class')
        self.tagging = map.get('x-oss-tagging')
        self.content_type = map.get('content-type')
        return self


class InitiateMultipartUploadResponse(TeaModel):
    def __init__(self, request_id=None, initiate_multipart_upload_result=None):
        self.request_id = request_id
        self.initiate_multipart_upload_result = initiate_multipart_upload_result

    def validate(self):
        self.validate_required(self.request_id, 'request_id')
        self.validate_required(self.initiate_multipart_upload_result, 'initiate_multipart_upload_result')
        if self.initiate_multipart_upload_result:
            self.initiate_multipart_upload_result.validate()

    def to_map(self):
        result = {}
        result['x-oss-request-id'] = self.request_id
        if self.initiate_multipart_upload_result is not None:
            result['InitiateMultipartUploadResult'] = self.initiate_multipart_upload_result.to_map()
        else:
            result['InitiateMultipartUploadResult'] = None
        return result

    def from_map(self, map={}):
        self.request_id = map.get('x-oss-request-id')
        if map.get('InitiateMultipartUploadResult') is not None:
            temp_model = InitiateMultipartUploadResponseInitiateMultipartUploadResult()
            self.initiate_multipart_upload_result = temp_model.from_map(map['InitiateMultipartUploadResult'])
        else:
            self.initiate_multipart_upload_result = None
        return self


class InitiateMultipartUploadResponseInitiateMultipartUploadResult(TeaModel):
    def __init__(self, bucket=None, key=None, upload_id=None):
        self.bucket = bucket
        self.key = key
        self.upload_id = upload_id

    def validate(self):
        pass

    def to_map(self):
        result = {}
        result['Bucket'] = self.bucket
        result['Key'] = self.key
        result['UploadId'] = self.upload_id
        return result

    def from_map(self, map={}):
        self.bucket = map.get('Bucket')
        self.key = map.get('Key')
        self.upload_id = map.get('UploadId')
        return self


class OptionObjectRequest(TeaModel):
    def __init__(self, bucket_name=None, object_name=None, header=None):
        self.bucket_name = bucket_name
        self.object_name = object_name
        self.header = header

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')
        self.validate_required(self.object_name, 'object_name')
        self.validate_required(self.header, 'header')
        if self.header:
            self.header.validate()

    def to_map(self):
        result = {}
        result['BucketName'] = self.bucket_name
        result['ObjectName'] = self.object_name
        if self.header is not None:
            result['Header'] = self.header.to_map()
        else:
            result['Header'] = None
        return result

    def from_map(self, map={}):
        self.bucket_name = map.get('BucketName')
        self.object_name = map.get('ObjectName')
        if map.get('Header') is not None:
            temp_model = OptionObjectRequestHeader()
            self.header = temp_model.from_map(map['Header'])
        else:
            self.header = None
        return self


class OptionObjectRequestHeader(TeaModel):
    def __init__(self, origin=None, access_control_request_method=None, access_control_request_headers=None):
        self.origin = origin
        self.access_control_request_method = access_control_request_method
        self.access_control_request_headers = access_control_request_headers

    def validate(self):
        self.validate_required(self.origin, 'origin')
        self.validate_required(self.access_control_request_method, 'access_control_request_method')
        self.validate_required(self.access_control_request_headers, 'access_control_request_headers')

    def to_map(self):
        result = {}
        result['Origin'] = self.origin
        result['Access-Control-Request-Method'] = self.access_control_request_method
        result['Access-Control-Request-Headers'] = self.access_control_request_headers
        return result

    def from_map(self, map={}):
        self.origin = map.get('Origin')
        self.access_control_request_method = map.get('Access-Control-Request-Method')
        self.access_control_request_headers = map.get('Access-Control-Request-Headers')
        return self


class OptionObjectResponse(TeaModel):
    def __init__(self, request_id=None, access_control_allow_origin=None, access_control_allow_methods=None, access_control_allow_headers=None, access_control_expose_headers=None, access_control_max_age=None):
        self.request_id = request_id
        self.access_control_allow_origin = access_control_allow_origin
        self.access_control_allow_methods = access_control_allow_methods
        self.access_control_allow_headers = access_control_allow_headers
        self.access_control_expose_headers = access_control_expose_headers
        self.access_control_max_age = access_control_max_age

    def validate(self):
        self.validate_required(self.request_id, 'request_id')
        self.validate_required(self.access_control_allow_origin, 'access_control_allow_origin')
        self.validate_required(self.access_control_allow_methods, 'access_control_allow_methods')
        self.validate_required(self.access_control_allow_headers, 'access_control_allow_headers')
        self.validate_required(self.access_control_expose_headers, 'access_control_expose_headers')
        self.validate_required(self.access_control_max_age, 'access_control_max_age')

    def to_map(self):
        result = {}
        result['x-oss-request-id'] = self.request_id
        result['access-control-allow-origin'] = self.access_control_allow_origin
        result['access-control-allow-methods'] = self.access_control_allow_methods
        result['access-control-allow-headers'] = self.access_control_allow_headers
        result['access-control-expose-headers'] = self.access_control_expose_headers
        result['access-control-max-age'] = self.access_control_max_age
        return result

    def from_map(self, map={}):
        self.request_id = map.get('x-oss-request-id')
        self.access_control_allow_origin = map.get('access-control-allow-origin')
        self.access_control_allow_methods = map.get('access-control-allow-methods')
        self.access_control_allow_headers = map.get('access-control-allow-headers')
        self.access_control_expose_headers = map.get('access-control-expose-headers')
        self.access_control_max_age = map.get('access-control-max-age')
        return self


class PostVodPlaylistRequest(TeaModel):
    def __init__(self, bucket_name=None, channel_name=None, playlist_name=None, filter=None):
        self.bucket_name = bucket_name
        self.channel_name = channel_name
        self.playlist_name = playlist_name
        self.filter = filter

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')
        self.validate_required(self.channel_name, 'channel_name')
        self.validate_required(self.playlist_name, 'playlist_name')
        self.validate_required(self.filter, 'filter')
        if self.filter:
            self.filter.validate()

    def to_map(self):
        result = {}
        result['BucketName'] = self.bucket_name
        result['ChannelName'] = self.channel_name
        result['PlaylistName'] = self.playlist_name
        if self.filter is not None:
            result['Filter'] = self.filter.to_map()
        else:
            result['Filter'] = None
        return result

    def from_map(self, map={}):
        self.bucket_name = map.get('BucketName')
        self.channel_name = map.get('ChannelName')
        self.playlist_name = map.get('PlaylistName')
        if map.get('Filter') is not None:
            temp_model = PostVodPlaylistRequestFilter()
            self.filter = temp_model.from_map(map['Filter'])
        else:
            self.filter = None
        return self


class PostVodPlaylistRequestFilter(TeaModel):
    def __init__(self, end_time=None, start_time=None):
        self.end_time = end_time
        self.start_time = start_time

    def validate(self):
        self.validate_required(self.end_time, 'end_time')
        self.validate_required(self.start_time, 'start_time')

    def to_map(self):
        result = {}
        result['endTime'] = self.end_time
        result['startTime'] = self.start_time
        return result

    def from_map(self, map={}):
        self.end_time = map.get('endTime')
        self.start_time = map.get('startTime')
        return self


class PostVodPlaylistResponse(TeaModel):
    def __init__(self, request_id=None):
        self.request_id = request_id

    def validate(self):
        self.validate_required(self.request_id, 'request_id')

    def to_map(self):
        result = {}
        result['x-oss-request-id'] = self.request_id
        return result

    def from_map(self, map={}):
        self.request_id = map.get('x-oss-request-id')
        return self


class PostObjectRequest(TeaModel):
    def __init__(self, bucket_name=None, header=None):
        self.bucket_name = bucket_name
        self.header = header

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')
        self.validate_required(self.header, 'header')
        if self.header:
            self.header.validate()

    def to_map(self):
        result = {}
        result['BucketName'] = self.bucket_name
        if self.header is not None:
            result['header'] = self.header.to_map()
        else:
            result['header'] = None
        return result

    def from_map(self, map={}):
        self.bucket_name = map.get('BucketName')
        if map.get('header') is not None:
            temp_model = PostObjectRequestHeader()
            self.header = temp_model.from_map(map['header'])
        else:
            self.header = None
        return self


class PostObjectRequestHeader(TeaModel):
    def __init__(self, access_key_id=None, policy=None, signature=None, success_action_status=None, file=None, key=None, user_meta=None):
        self.access_key_id = access_key_id
        self.policy = policy
        self.signature = signature
        self.success_action_status = success_action_status
        self.file = file
        self.key = key
        self.user_meta = {}

    def validate(self):
        self.validate_required(self.access_key_id, 'access_key_id')
        self.validate_required(self.policy, 'policy')
        self.validate_required(self.signature, 'signature')
        self.validate_required(self.file, 'file')
        if self.file:
            self.file.validate()
        self.validate_required(self.key, 'key')

    def to_map(self):
        result = {}
        result['OSSAccessKeyId'] = self.access_key_id
        result['policy'] = self.policy
        result['Signature'] = self.signature
        result['success_action_status'] = self.success_action_status
        if self.file is not None:
            result['file'] = self.file.to_map()
        else:
            result['file'] = None
        result['key'] = self.key
        result['UserMeta'] = self.user_meta
        return result

    def from_map(self, map={}):
        self.access_key_id = map.get('OSSAccessKeyId')
        self.policy = map.get('policy')
        self.signature = map.get('Signature')
        self.success_action_status = map.get('success_action_status')
        if map.get('file') is not None:
            temp_model = file_form_models.FileField()
            self.file = temp_model.from_map(map['file'])
        else:
            self.file = None
        self.key = map.get('key')
        self.user_meta = map.get('UserMeta')
        return self


class PostObjectResponse(TeaModel):
    def __init__(self, post_response=None):
        self.post_response = post_response

    def validate(self):
        self.validate_required(self.post_response, 'post_response')
        if self.post_response:
            self.post_response.validate()

    def to_map(self):
        result = {}
        if self.post_response is not None:
            result['PostResponse'] = self.post_response.to_map()
        else:
            result['PostResponse'] = None
        return result

    def from_map(self, map={}):
        if map.get('PostResponse') is not None:
            temp_model = PostObjectResponsePostResponse()
            self.post_response = temp_model.from_map(map['PostResponse'])
        else:
            self.post_response = None
        return self


class PostObjectResponsePostResponse(TeaModel):
    def __init__(self, bucket=None, e_tag=None, location=None):
        self.bucket = bucket
        self.e_tag = e_tag
        self.location = location

    def validate(self):
        self.validate_required(self.bucket, 'bucket')
        self.validate_required(self.e_tag, 'e_tag')
        self.validate_required(self.location, 'location')

    def to_map(self):
        result = {}
        result['Bucket'] = self.bucket
        result['ETag'] = self.e_tag
        result['Location'] = self.location
        return result

    def from_map(self, map={}):
        self.bucket = map.get('Bucket')
        self.e_tag = map.get('ETag')
        self.location = map.get('Location')
        return self


class HeadObjectRequest(TeaModel):
    def __init__(self, bucket_name=None, object_name=None, header=None):
        self.bucket_name = bucket_name
        self.object_name = object_name
        self.header = header

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')
        self.validate_required(self.object_name, 'object_name')
        if self.header:
            self.header.validate()

    def to_map(self):
        result = {}
        result['BucketName'] = self.bucket_name
        result['ObjectName'] = self.object_name
        if self.header is not None:
            result['Header'] = self.header.to_map()
        else:
            result['Header'] = None
        return result

    def from_map(self, map={}):
        self.bucket_name = map.get('BucketName')
        self.object_name = map.get('ObjectName')
        if map.get('Header') is not None:
            temp_model = HeadObjectRequestHeader()
            self.header = temp_model.from_map(map['Header'])
        else:
            self.header = None
        return self


class HeadObjectRequestHeader(TeaModel):
    def __init__(self, if_modified_since=None, if_unmodified_since=None, if_match=None, if_none_match=None):
        self.if_modified_since = if_modified_since
        self.if_unmodified_since = if_unmodified_since
        self.if_match = if_match
        self.if_none_match = if_none_match

    def validate(self):
        pass

    def to_map(self):
        result = {}
        result['If-Modified-Since'] = self.if_modified_since
        result['If-Unmodified-Since'] = self.if_unmodified_since
        result['If-Match'] = self.if_match
        result['If-None-Match'] = self.if_none_match
        return result

    def from_map(self, map={}):
        self.if_modified_since = map.get('If-Modified-Since')
        self.if_unmodified_since = map.get('If-Unmodified-Since')
        self.if_match = map.get('If-Match')
        self.if_none_match = map.get('If-None-Match')
        return self


class HeadObjectResponse(TeaModel):
    def __init__(self, request_id=None, user_meta=None, server_side_encryption=None, server_side_encryption_key_id=None, storage_class=None, object_type=None, next_append_position=None, hash_crc_64ecma=None, expiration=None, restore=None, process_status=None, request_charged=None, content_md_5=None, last_modified=None, access_control_allow_origin=None, access_control_allow_methods=None, access_control_max_age=None, access_control_allow_headers=None, access_control_expose_headers=None, tagging_count=None):
        self.request_id = request_id
        self.user_meta = {}
        self.server_side_encryption = server_side_encryption
        self.server_side_encryption_key_id = server_side_encryption_key_id
        self.storage_class = storage_class
        self.object_type = object_type
        self.next_append_position = next_append_position
        self.hash_crc_64ecma = hash_crc_64ecma
        self.expiration = expiration
        self.restore = restore
        self.process_status = process_status
        self.request_charged = request_charged
        self.content_md_5 = content_md_5
        self.last_modified = last_modified
        self.access_control_allow_origin = access_control_allow_origin
        self.access_control_allow_methods = access_control_allow_methods
        self.access_control_max_age = access_control_max_age
        self.access_control_allow_headers = access_control_allow_headers
        self.access_control_expose_headers = access_control_expose_headers
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
        result = {}
        result['x-oss-request-id'] = self.request_id
        result['usermeta'] = self.user_meta
        result['x-oss-server-side-encryption'] = self.server_side_encryption
        result['x-oss-server-side-encryption-key-id'] = self.server_side_encryption_key_id
        result['x-oss-storage-class'] = self.storage_class
        result['x-oss-object-type'] = self.object_type
        result['x-oss-next-append-position'] = self.next_append_position
        result['x-oss-hash-crc64ecma'] = self.hash_crc_64ecma
        result['x-oss-expiration'] = self.expiration
        result['x-oss-restore'] = self.restore
        result['x-oss-process-status'] = self.process_status
        result['x-oss-request-charged'] = self.request_charged
        result['content-md5'] = self.content_md_5
        result['last-modified'] = self.last_modified
        result['access-control-allow-origin'] = self.access_control_allow_origin
        result['access-control-allow-methods'] = self.access_control_allow_methods
        result['access-control-max-age'] = self.access_control_max_age
        result['access-control-allow-headers'] = self.access_control_allow_headers
        result['access-control-expose-headers'] = self.access_control_expose_headers
        result['x-oss-tagging-count'] = self.tagging_count
        return result

    def from_map(self, map={}):
        self.request_id = map.get('x-oss-request-id')
        self.user_meta = map.get('usermeta')
        self.server_side_encryption = map.get('x-oss-server-side-encryption')
        self.server_side_encryption_key_id = map.get('x-oss-server-side-encryption-key-id')
        self.storage_class = map.get('x-oss-storage-class')
        self.object_type = map.get('x-oss-object-type')
        self.next_append_position = map.get('x-oss-next-append-position')
        self.hash_crc_64ecma = map.get('x-oss-hash-crc64ecma')
        self.expiration = map.get('x-oss-expiration')
        self.restore = map.get('x-oss-restore')
        self.process_status = map.get('x-oss-process-status')
        self.request_charged = map.get('x-oss-request-charged')
        self.content_md_5 = map.get('content-md5')
        self.last_modified = map.get('last-modified')
        self.access_control_allow_origin = map.get('access-control-allow-origin')
        self.access_control_allow_methods = map.get('access-control-allow-methods')
        self.access_control_max_age = map.get('access-control-max-age')
        self.access_control_allow_headers = map.get('access-control-allow-headers')
        self.access_control_expose_headers = map.get('access-control-expose-headers')
        self.tagging_count = map.get('x-oss-tagging-count')
        return self


class DeleteObjectTaggingRequest(TeaModel):
    def __init__(self, bucket_name=None, object_name=None):
        self.bucket_name = bucket_name
        self.object_name = object_name

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')
        self.validate_required(self.object_name, 'object_name')

    def to_map(self):
        result = {}
        result['BucketName'] = self.bucket_name
        result['ObjectName'] = self.object_name
        return result

    def from_map(self, map={}):
        self.bucket_name = map.get('BucketName')
        self.object_name = map.get('ObjectName')
        return self


class DeleteObjectTaggingResponse(TeaModel):
    def __init__(self, request_id=None):
        self.request_id = request_id

    def validate(self):
        self.validate_required(self.request_id, 'request_id')

    def to_map(self):
        result = {}
        result['x-oss-request-id'] = self.request_id
        return result

    def from_map(self, map={}):
        self.request_id = map.get('x-oss-request-id')
        return self


class RestoreObjectRequest(TeaModel):
    def __init__(self, bucket_name=None, object_name=None):
        self.bucket_name = bucket_name
        self.object_name = object_name

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')
        self.validate_required(self.object_name, 'object_name')

    def to_map(self):
        result = {}
        result['BucketName'] = self.bucket_name
        result['ObjectName'] = self.object_name
        return result

    def from_map(self, map={}):
        self.bucket_name = map.get('BucketName')
        self.object_name = map.get('ObjectName')
        return self


class RestoreObjectResponse(TeaModel):
    def __init__(self, request_id=None):
        self.request_id = request_id

    def validate(self):
        self.validate_required(self.request_id, 'request_id')

    def to_map(self):
        result = {}
        result['x-oss-request-id'] = self.request_id
        return result

    def from_map(self, map={}):
        self.request_id = map.get('x-oss-request-id')
        return self


class GetObjectAclRequest(TeaModel):
    def __init__(self, bucket_name=None, object_name=None):
        self.bucket_name = bucket_name
        self.object_name = object_name

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')
        self.validate_required(self.object_name, 'object_name')

    def to_map(self):
        result = {}
        result['BucketName'] = self.bucket_name
        result['ObjectName'] = self.object_name
        return result

    def from_map(self, map={}):
        self.bucket_name = map.get('BucketName')
        self.object_name = map.get('ObjectName')
        return self


class GetObjectAclResponse(TeaModel):
    def __init__(self, request_id=None, access_control_policy=None):
        self.request_id = request_id
        self.access_control_policy = access_control_policy

    def validate(self):
        self.validate_required(self.request_id, 'request_id')
        self.validate_required(self.access_control_policy, 'access_control_policy')
        if self.access_control_policy:
            self.access_control_policy.validate()

    def to_map(self):
        result = {}
        result['x-oss-request-id'] = self.request_id
        if self.access_control_policy is not None:
            result['AccessControlPolicy'] = self.access_control_policy.to_map()
        else:
            result['AccessControlPolicy'] = None
        return result

    def from_map(self, map={}):
        self.request_id = map.get('x-oss-request-id')
        if map.get('AccessControlPolicy') is not None:
            temp_model = GetObjectAclResponseAccessControlPolicy()
            self.access_control_policy = temp_model.from_map(map['AccessControlPolicy'])
        else:
            self.access_control_policy = None
        return self


class GetObjectAclResponseAccessControlPolicyOwner(TeaModel):
    def __init__(self, i_d=None, display_name=None):
        self.i_d = i_d
        self.display_name = display_name

    def validate(self):
        pass

    def to_map(self):
        result = {}
        result['ID'] = self.i_d
        result['DisplayName'] = self.display_name
        return result

    def from_map(self, map={}):
        self.i_d = map.get('ID')
        self.display_name = map.get('DisplayName')
        return self


class GetObjectAclResponseAccessControlPolicyAccessControlList(TeaModel):
    def __init__(self, grant=None):
        self.grant = grant

    def validate(self):
        pass

    def to_map(self):
        result = {}
        result['Grant'] = self.grant
        return result

    def from_map(self, map={}):
        self.grant = map.get('Grant')
        return self


class GetObjectAclResponseAccessControlPolicy(TeaModel):
    def __init__(self, owner=None, access_control_list=None):
        self.owner = owner
        self.access_control_list = access_control_list

    def validate(self):
        self.validate_required(self.owner, 'owner')
        if self.owner:
            self.owner.validate()
        self.validate_required(self.access_control_list, 'access_control_list')
        if self.access_control_list:
            self.access_control_list.validate()

    def to_map(self):
        result = {}
        if self.owner is not None:
            result['Owner'] = self.owner.to_map()
        else:
            result['Owner'] = None
        if self.access_control_list is not None:
            result['AccessControlList'] = self.access_control_list.to_map()
        else:
            result['AccessControlList'] = None
        return result

    def from_map(self, map={}):
        if map.get('Owner') is not None:
            temp_model = GetObjectAclResponseAccessControlPolicyOwner()
            self.owner = temp_model.from_map(map['Owner'])
        else:
            self.owner = None
        if map.get('AccessControlList') is not None:
            temp_model = GetObjectAclResponseAccessControlPolicyAccessControlList()
            self.access_control_list = temp_model.from_map(map['AccessControlList'])
        else:
            self.access_control_list = None
        return self


class PutBucketAclRequest(TeaModel):
    def __init__(self, bucket_name=None, header=None):
        self.bucket_name = bucket_name
        self.header = header

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')
        self.validate_required(self.header, 'header')
        if self.header:
            self.header.validate()

    def to_map(self):
        result = {}
        result['BucketName'] = self.bucket_name
        if self.header is not None:
            result['Header'] = self.header.to_map()
        else:
            result['Header'] = None
        return result

    def from_map(self, map={}):
        self.bucket_name = map.get('BucketName')
        if map.get('Header') is not None:
            temp_model = PutBucketAclRequestHeader()
            self.header = temp_model.from_map(map['Header'])
        else:
            self.header = None
        return self


class PutBucketAclRequestHeader(TeaModel):
    def __init__(self, acl=None):
        self.acl = acl

    def validate(self):
        self.validate_required(self.acl, 'acl')

    def to_map(self):
        result = {}
        result['x-oss-acl'] = self.acl
        return result

    def from_map(self, map={}):
        self.acl = map.get('x-oss-acl')
        return self


class PutBucketAclResponse(TeaModel):
    def __init__(self, request_id=None):
        self.request_id = request_id

    def validate(self):
        self.validate_required(self.request_id, 'request_id')

    def to_map(self):
        result = {}
        result['x-oss-request-id'] = self.request_id
        return result

    def from_map(self, map={}):
        self.request_id = map.get('x-oss-request-id')
        return self


class DeleteBucketRequest(TeaModel):
    def __init__(self, bucket_name=None):
        self.bucket_name = bucket_name

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')

    def to_map(self):
        result = {}
        result['BucketName'] = self.bucket_name
        return result

    def from_map(self, map={}):
        self.bucket_name = map.get('BucketName')
        return self


class DeleteBucketResponse(TeaModel):
    def __init__(self, request_id=None):
        self.request_id = request_id

    def validate(self):
        self.validate_required(self.request_id, 'request_id')

    def to_map(self):
        result = {}
        result['x-oss-request-id'] = self.request_id
        return result

    def from_map(self, map={}):
        self.request_id = map.get('x-oss-request-id')
        return self


class PutObjectRequest(TeaModel):
    def __init__(self, bucket_name=None, object_name=None, user_meta=None, body=None, header=None):
        self.bucket_name = bucket_name
        self.object_name = object_name
        self.user_meta = {}
        self.body = body
        self.header = header

    def validate(self):
        self.validate_required(self.bucket_name, 'bucket_name')
        self.validate_required(self.object_name, 'object_name')
        if self.header:
            self.header.validate()

    def to_map(self):
        result = {}
        result['BucketName'] = self.bucket_name
        result['ObjectName'] = self.object_name
        result['UserMeta'] = self.user_meta
        result['body'] = self.body
        if self.header is not None:
            result['Header'] = self.header.to_map()
        else:
            result['Header'] = None
        return result

    def from_map(self, map={}):
        self.bucket_name = map.get('BucketName')
        self.object_name = map.get('ObjectName')
        self.user_meta = map.get('UserMeta')
        self.body = map.get('body')
        if map.get('Header') is not None:
            temp_model = PutObjectRequestHeader()
            self.header = temp_model.from_map(map['Header'])
        else:
            self.header = None
        return self


class PutObjectRequestHeader(TeaModel):
    def __init__(self, authorization=None, cache_control=None, content_disposition=None, content_encoding=None, content_md5=None, content_length=None, e_tag=None, expires=None, server_side_encryption=None, server_side_encryption_key_id=None, object_acl=None, storage_class=None, tagging=None, content_type=None):
        self.authorization = authorization
        self.cache_control = cache_control
        self.content_disposition = content_disposition
        self.content_encoding = content_encoding
        self.content_md5 = content_md5
        self.content_length = content_length
        self.e_tag = e_tag
        self.expires = expires
        self.server_side_encryption = server_side_encryption
        self.server_side_encryption_key_id = server_side_encryption_key_id
        self.object_acl = object_acl
        self.storage_class = storage_class
        self.tagging = tagging
        self.content_type = content_type

    def validate(self):
        pass

    def to_map(self):
        result = {}
        result['Authorization'] = self.authorization
        result['Cache-Control'] = self.cache_control
        result['Content-Disposition'] = self.content_disposition
        result['Content-Encoding'] = self.content_encoding
        result['Content-MD5'] = self.content_md5
        result['Content-Length'] = self.content_length
        result['CETag'] = self.e_tag
        result['Expires'] = self.expires
        result['x-oss-server-side-encryption'] = self.server_side_encryption
        result['x-oss-server-side-encryption-key-id'] = self.server_side_encryption_key_id
        result['x-oss-object-acl'] = self.object_acl
        result['x-oss-storage-class'] = self.storage_class
        result['x-oss-tagging'] = self.tagging
        result['content-type'] = self.content_type
        return result

    def from_map(self, map={}):
        self.authorization = map.get('Authorization')
        self.cache_control = map.get('Cache-Control')
        self.content_disposition = map.get('Content-Disposition')
        self.content_encoding = map.get('Content-Encoding')
        self.content_md5 = map.get('Content-MD5')
        self.content_length = map.get('Content-Length')
        self.e_tag = map.get('CETag')
        self.expires = map.get('Expires')
        self.server_side_encryption = map.get('x-oss-server-side-encryption')
        self.server_side_encryption_key_id = map.get('x-oss-server-side-encryption-key-id')
        self.object_acl = map.get('x-oss-object-acl')
        self.storage_class = map.get('x-oss-storage-class')
        self.tagging = map.get('x-oss-tagging')
        self.content_type = map.get('content-type')
        return self


class PutObjectResponse(TeaModel):
    def __init__(self, request_id=None, hash_crc_64ecma=None, server_time=None, bucket_version=None):
        self.request_id = request_id
        self.hash_crc_64ecma = hash_crc_64ecma
        self.server_time = server_time
        self.bucket_version = bucket_version

    def validate(self):
        self.validate_required(self.request_id, 'request_id')
        self.validate_required(self.hash_crc_64ecma, 'hash_crc_64ecma')
        self.validate_required(self.server_time, 'server_time')
        self.validate_required(self.bucket_version, 'bucket_version')

    def to_map(self):
        result = {}
        result['x-oss-request-id'] = self.request_id
        result['x-oss-hash-crc64ecma'] = self.hash_crc_64ecma
        result['x-oss-server-time'] = self.server_time
        result['x-oss-bucket-version'] = self.bucket_version
        return result

    def from_map(self, map={}):
        self.request_id = map.get('x-oss-request-id')
        self.hash_crc_64ecma = map.get('x-oss-hash-crc64ecma')
        self.server_time = map.get('x-oss-server-time')
        self.bucket_version = map.get('x-oss-bucket-version')
        return self
