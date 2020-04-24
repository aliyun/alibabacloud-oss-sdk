// This file is auto-generated, don't edit it
import Util from '@alicloud/tea-util';
import OSSUtil, * as $OSSUtil from '@alicloud/oss-util';
import XML from '@alicloud/tea-xml';
import FileForm, * as $FileForm from '@alicloud/tea-fileform';
import Credential, * as $Credential from '@alicloud/credentials';
import { Readable } from 'stream';
import * as $tea from '@alicloud/tea-typescript';

export class Config extends $tea.Model {
  type?: string;
  securityToken?: string;
  accessKeyId: string;
  accessKeySecret: string;
  endpoint?: string;
  protocol?: string;
  regionId?: string;
  userAgent?: string;
  hostModel?: string;
  signatureVersion?: string;
  isEnableMD5?: boolean;
  isEnableCrc?: boolean;
  readTimeout?: number;
  connectTimeout?: number;
  localAddr?: string;
  httpProxy?: string;
  httpsProxy?: string;
  noProxy?: string;
  socks5Proxy?: string;
  socks5NetWork?: string;
  maxIdleConns?: number;
  addtionalHeaders?: string[];
  static names(): { [key: string]: string } {
    return {
      type: 'type',
      securityToken: 'securityToken',
      accessKeyId: 'accessKeyId',
      accessKeySecret: 'accessKeySecret',
      endpoint: 'endpoint',
      protocol: 'protocol',
      regionId: 'regionId',
      userAgent: 'userAgent',
      hostModel: 'hostModel',
      signatureVersion: 'signatureVersion',
      isEnableMD5: 'isEnableMD5',
      isEnableCrc: 'isEnableCrc',
      readTimeout: 'readTimeout',
      connectTimeout: 'connectTimeout',
      localAddr: 'localAddr',
      httpProxy: 'httpProxy',
      httpsProxy: 'httpsProxy',
      noProxy: 'noProxy',
      socks5Proxy: 'socks5Proxy',
      socks5NetWork: 'socks5NetWork',
      maxIdleConns: 'maxIdleConns',
      addtionalHeaders: 'addtionalHeaders',
    };
  }

  static types(): { [key: string]: any } {
    return {
      type: 'string',
      securityToken: 'string',
      accessKeyId: 'string',
      accessKeySecret: 'string',
      endpoint: 'string',
      protocol: 'string',
      regionId: 'string',
      userAgent: 'string',
      hostModel: 'string',
      signatureVersion: 'string',
      isEnableMD5: 'boolean',
      isEnableCrc: 'boolean',
      readTimeout: 'number',
      connectTimeout: 'number',
      localAddr: 'string',
      httpProxy: 'string',
      httpsProxy: 'string',
      noProxy: 'string',
      socks5Proxy: 'string',
      socks5NetWork: 'string',
      maxIdleConns: 'number',
      addtionalHeaders: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PutBucketLifecycleRequest extends $tea.Model {
  bucketName: string;
  body?: PutBucketLifecycleRequestBody;
  static names(): { [key: string]: string } {
    return {
      bucketName: 'BucketName',
      body: 'Body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bucketName: 'string',
      body: PutBucketLifecycleRequestBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PutBucketLifecycleResponse extends $tea.Model {
  requestId: string;
  static names(): { [key: string]: string } {
    return {
      requestId: 'x-oss-request-id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteMultipleObjectsRequest extends $tea.Model {
  bucketName: string;
  body?: DeleteMultipleObjectsRequestBody;
  header: DeleteMultipleObjectsRequestHeader;
  static names(): { [key: string]: string } {
    return {
      bucketName: 'BucketName',
      body: 'Body',
      header: 'Header',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bucketName: 'string',
      body: DeleteMultipleObjectsRequestBody,
      header: DeleteMultipleObjectsRequestHeader,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteMultipleObjectsResponse extends $tea.Model {
  requestId: string;
  deleteResult: DeleteMultipleObjectsResponseDeleteResult;
  static names(): { [key: string]: string } {
    return {
      requestId: 'x-oss-request-id',
      deleteResult: 'DeleteResult',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
      deleteResult: DeleteMultipleObjectsResponseDeleteResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PutBucketRefererRequest extends $tea.Model {
  bucketName: string;
  body?: PutBucketRefererRequestBody;
  static names(): { [key: string]: string } {
    return {
      bucketName: 'BucketName',
      body: 'Body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bucketName: 'string',
      body: PutBucketRefererRequestBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PutBucketRefererResponse extends $tea.Model {
  requestId: string;
  static names(): { [key: string]: string } {
    return {
      requestId: 'x-oss-request-id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PutBucketWebsiteRequest extends $tea.Model {
  bucketName: string;
  body?: PutBucketWebsiteRequestBody;
  static names(): { [key: string]: string } {
    return {
      bucketName: 'BucketName',
      body: 'Body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bucketName: 'string',
      body: PutBucketWebsiteRequestBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PutBucketWebsiteResponse extends $tea.Model {
  requestId: string;
  static names(): { [key: string]: string } {
    return {
      requestId: 'x-oss-request-id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CompleteMultipartUploadRequest extends $tea.Model {
  bucketName: string;
  objectName: string;
  filter: CompleteMultipartUploadRequestFilter;
  body?: CompleteMultipartUploadRequestBody;
  static names(): { [key: string]: string } {
    return {
      bucketName: 'BucketName',
      objectName: 'ObjectName',
      filter: 'Filter',
      body: 'Body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bucketName: 'string',
      objectName: 'string',
      filter: CompleteMultipartUploadRequestFilter,
      body: CompleteMultipartUploadRequestBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CompleteMultipartUploadResponse extends $tea.Model {
  requestId: string;
  completeMultipartUploadResult: CompleteMultipartUploadResponseCompleteMultipartUploadResult;
  static names(): { [key: string]: string } {
    return {
      requestId: 'x-oss-request-id',
      completeMultipartUploadResult: 'CompleteMultipartUploadResult',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
      completeMultipartUploadResult: CompleteMultipartUploadResponseCompleteMultipartUploadResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PutBucketLoggingRequest extends $tea.Model {
  bucketName: string;
  body?: PutBucketLoggingRequestBody;
  static names(): { [key: string]: string } {
    return {
      bucketName: 'BucketName',
      body: 'Body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bucketName: 'string',
      body: PutBucketLoggingRequestBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PutBucketLoggingResponse extends $tea.Model {
  requestId: string;
  static names(): { [key: string]: string } {
    return {
      requestId: 'x-oss-request-id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PutBucketRequestPaymentRequest extends $tea.Model {
  bucketName: string;
  body?: PutBucketRequestPaymentRequestBody;
  static names(): { [key: string]: string } {
    return {
      bucketName: 'BucketName',
      body: 'Body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bucketName: 'string',
      body: PutBucketRequestPaymentRequestBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PutBucketRequestPaymentResponse extends $tea.Model {
  requestId: string;
  static names(): { [key: string]: string } {
    return {
      requestId: 'x-oss-request-id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PutBucketEncryptionRequest extends $tea.Model {
  bucketName: string;
  body?: PutBucketEncryptionRequestBody;
  static names(): { [key: string]: string } {
    return {
      bucketName: 'BucketName',
      body: 'Body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bucketName: 'string',
      body: PutBucketEncryptionRequestBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PutBucketEncryptionResponse extends $tea.Model {
  requestId: string;
  static names(): { [key: string]: string } {
    return {
      requestId: 'x-oss-request-id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PutLiveChannelRequest extends $tea.Model {
  bucketName: string;
  channelName: string;
  body?: PutLiveChannelRequestBody;
  static names(): { [key: string]: string } {
    return {
      bucketName: 'BucketName',
      channelName: 'ChannelName',
      body: 'Body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bucketName: 'string',
      channelName: 'string',
      body: PutLiveChannelRequestBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PutLiveChannelResponse extends $tea.Model {
  requestId: string;
  createLiveChannelResult: PutLiveChannelResponseCreateLiveChannelResult;
  static names(): { [key: string]: string } {
    return {
      requestId: 'x-oss-request-id',
      createLiveChannelResult: 'CreateLiveChannelResult',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
      createLiveChannelResult: PutLiveChannelResponseCreateLiveChannelResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PutBucketTagsRequest extends $tea.Model {
  bucketName: string;
  body?: PutBucketTagsRequestBody;
  static names(): { [key: string]: string } {
    return {
      bucketName: 'BucketName',
      body: 'Body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bucketName: 'string',
      body: PutBucketTagsRequestBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PutBucketTagsResponse extends $tea.Model {
  requestId: string;
  static names(): { [key: string]: string } {
    return {
      requestId: 'x-oss-request-id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PutObjectTaggingRequest extends $tea.Model {
  bucketName: string;
  objectName: string;
  body?: PutObjectTaggingRequestBody;
  static names(): { [key: string]: string } {
    return {
      bucketName: 'BucketName',
      objectName: 'ObjectName',
      body: 'Body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bucketName: 'string',
      objectName: 'string',
      body: PutObjectTaggingRequestBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PutObjectTaggingResponse extends $tea.Model {
  requestId: string;
  static names(): { [key: string]: string } {
    return {
      requestId: 'x-oss-request-id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SelectObjectRequest extends $tea.Model {
  bucketName: string;
  objectName: string;
  filter: SelectObjectRequestFilter;
  body?: SelectObjectRequestBody;
  static names(): { [key: string]: string } {
    return {
      bucketName: 'BucketName',
      objectName: 'ObjectName',
      filter: 'Filter',
      body: 'Body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bucketName: 'string',
      objectName: 'string',
      filter: SelectObjectRequestFilter,
      body: SelectObjectRequestBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SelectObjectResponse extends $tea.Model {
  requestId: string;
  static names(): { [key: string]: string } {
    return {
      requestId: 'x-oss-request-id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PutBucketCORSRequest extends $tea.Model {
  bucketName: string;
  body?: PutBucketCORSRequestBody;
  static names(): { [key: string]: string } {
    return {
      bucketName: 'BucketName',
      body: 'Body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bucketName: 'string',
      body: PutBucketCORSRequestBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PutBucketCORSResponse extends $tea.Model {
  requestId: string;
  static names(): { [key: string]: string } {
    return {
      requestId: 'x-oss-request-id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PutBucketRequest extends $tea.Model {
  bucketName: string;
  body?: PutBucketRequestBody;
  header?: PutBucketRequestHeader;
  static names(): { [key: string]: string } {
    return {
      bucketName: 'BucketName',
      body: 'Body',
      header: 'Header',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bucketName: 'string',
      body: PutBucketRequestBody,
      header: PutBucketRequestHeader,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PutBucketResponse extends $tea.Model {
  requestId: string;
  static names(): { [key: string]: string } {
    return {
      requestId: 'x-oss-request-id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListMultipartUploadsRequest extends $tea.Model {
  bucketName: string;
  filter?: ListMultipartUploadsRequestFilter;
  static names(): { [key: string]: string } {
    return {
      bucketName: 'BucketName',
      filter: 'Filter',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bucketName: 'string',
      filter: ListMultipartUploadsRequestFilter,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListMultipartUploadsResponse extends $tea.Model {
  requestId: string;
  listMultipartUploadsResult: ListMultipartUploadsResponseListMultipartUploadsResult;
  static names(): { [key: string]: string } {
    return {
      requestId: 'x-oss-request-id',
      listMultipartUploadsResult: 'ListMultipartUploadsResult',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
      listMultipartUploadsResult: ListMultipartUploadsResponseListMultipartUploadsResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetBucketRequestPaymentRequest extends $tea.Model {
  bucketName: string;
  static names(): { [key: string]: string } {
    return {
      bucketName: 'BucketName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bucketName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetBucketRequestPaymentResponse extends $tea.Model {
  requestId: string;
  requestPaymentConfiguration: GetBucketRequestPaymentResponseRequestPaymentConfiguration;
  static names(): { [key: string]: string } {
    return {
      requestId: 'x-oss-request-id',
      requestPaymentConfiguration: 'RequestPaymentConfiguration',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
      requestPaymentConfiguration: GetBucketRequestPaymentResponseRequestPaymentConfiguration,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetBucketEncryptionRequest extends $tea.Model {
  bucketName: string;
  static names(): { [key: string]: string } {
    return {
      bucketName: 'BucketName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bucketName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetBucketEncryptionResponse extends $tea.Model {
  requestId: string;
  serverSideEncryptionRule: GetBucketEncryptionResponseServerSideEncryptionRule;
  static names(): { [key: string]: string } {
    return {
      requestId: 'x-oss-request-id',
      serverSideEncryptionRule: 'ServerSideEncryptionRule',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
      serverSideEncryptionRule: GetBucketEncryptionResponseServerSideEncryptionRule,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetBucketTagsRequest extends $tea.Model {
  bucketName: string;
  static names(): { [key: string]: string } {
    return {
      bucketName: 'BucketName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bucketName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetBucketTagsResponse extends $tea.Model {
  requestId: string;
  tagging: GetBucketTagsResponseTagging;
  static names(): { [key: string]: string } {
    return {
      requestId: 'x-oss-request-id',
      tagging: 'Tagging',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
      tagging: GetBucketTagsResponseTagging,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetServiceRequest extends $tea.Model {
  filter?: GetServiceRequestFilter;
  static names(): { [key: string]: string } {
    return {
      filter: 'Filter',
    };
  }

  static types(): { [key: string]: any } {
    return {
      filter: GetServiceRequestFilter,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetServiceResponse extends $tea.Model {
  requestId: string;
  listAllMyBucketsResult: GetServiceResponseListAllMyBucketsResult;
  static names(): { [key: string]: string } {
    return {
      requestId: 'x-oss-request-id',
      listAllMyBucketsResult: 'ListAllMyBucketsResult',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
      listAllMyBucketsResult: GetServiceResponseListAllMyBucketsResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteBucketEncryptionRequest extends $tea.Model {
  bucketName: string;
  static names(): { [key: string]: string } {
    return {
      bucketName: 'BucketName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bucketName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteBucketEncryptionResponse extends $tea.Model {
  requestId: string;
  static names(): { [key: string]: string } {
    return {
      requestId: 'x-oss-request-id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteBucketTagsRequest extends $tea.Model {
  bucketName: string;
  filter: DeleteBucketTagsRequestFilter;
  static names(): { [key: string]: string } {
    return {
      bucketName: 'BucketName',
      filter: 'Filter',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bucketName: 'string',
      filter: DeleteBucketTagsRequestFilter,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteBucketTagsResponse extends $tea.Model {
  requestId: string;
  static names(): { [key: string]: string } {
    return {
      requestId: 'x-oss-request-id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetBucketWebsiteRequest extends $tea.Model {
  bucketName: string;
  static names(): { [key: string]: string } {
    return {
      bucketName: 'BucketName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bucketName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetBucketWebsiteResponse extends $tea.Model {
  requestId: string;
  websiteConfiguration: GetBucketWebsiteResponseWebsiteConfiguration;
  static names(): { [key: string]: string } {
    return {
      requestId: 'x-oss-request-id',
      websiteConfiguration: 'WebsiteConfiguration',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
      websiteConfiguration: GetBucketWebsiteResponseWebsiteConfiguration,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteLiveChannelRequest extends $tea.Model {
  bucketName: string;
  channelName: string;
  static names(): { [key: string]: string } {
    return {
      bucketName: 'BucketName',
      channelName: 'ChannelName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bucketName: 'string',
      channelName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteLiveChannelResponse extends $tea.Model {
  requestId: string;
  static names(): { [key: string]: string } {
    return {
      requestId: 'x-oss-request-id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetBucketLocationRequest extends $tea.Model {
  bucketName: string;
  static names(): { [key: string]: string } {
    return {
      bucketName: 'BucketName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bucketName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetBucketLocationResponse extends $tea.Model {
  requestId: string;
  locationConstraint: string;
  static names(): { [key: string]: string } {
    return {
      requestId: 'x-oss-request-id',
      locationConstraint: 'LocationConstraint',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
      locationConstraint: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListLiveChannelRequest extends $tea.Model {
  bucketName: string;
  filter?: ListLiveChannelRequestFilter;
  static names(): { [key: string]: string } {
    return {
      bucketName: 'BucketName',
      filter: 'Filter',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bucketName: 'string',
      filter: ListLiveChannelRequestFilter,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListLiveChannelResponse extends $tea.Model {
  requestId: string;
  listLiveChannelResult: ListLiveChannelResponseListLiveChannelResult;
  static names(): { [key: string]: string } {
    return {
      requestId: 'x-oss-request-id',
      listLiveChannelResult: 'ListLiveChannelResult',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
      listLiveChannelResult: ListLiveChannelResponseListLiveChannelResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetObjectMetaRequest extends $tea.Model {
  bucketName: string;
  objectName: string;
  static names(): { [key: string]: string } {
    return {
      bucketName: 'BucketName',
      objectName: 'ObjectName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bucketName: 'string',
      objectName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetObjectMetaResponse extends $tea.Model {
  requestId: string;
  eTag: string;
  contentLength: string;
  lastModified: string;
  static names(): { [key: string]: string } {
    return {
      requestId: 'x-oss-request-id',
      eTag: 'etag',
      contentLength: 'content-length',
      lastModified: 'last-modified',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
      eTag: 'string',
      contentLength: 'string',
      lastModified: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetBucketAclRequest extends $tea.Model {
  bucketName: string;
  static names(): { [key: string]: string } {
    return {
      bucketName: 'BucketName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bucketName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetBucketAclResponse extends $tea.Model {
  requestId: string;
  accessControlPolicy: GetBucketAclResponseAccessControlPolicy;
  static names(): { [key: string]: string } {
    return {
      requestId: 'x-oss-request-id',
      accessControlPolicy: 'AccessControlPolicy',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
      accessControlPolicy: GetBucketAclResponseAccessControlPolicy,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListPartsRequest extends $tea.Model {
  bucketName: string;
  objectName: string;
  filter: ListPartsRequestFilter;
  static names(): { [key: string]: string } {
    return {
      bucketName: 'BucketName',
      objectName: 'ObjectName',
      filter: 'Filter',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bucketName: 'string',
      objectName: 'string',
      filter: ListPartsRequestFilter,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListPartsResponse extends $tea.Model {
  requestId: string;
  listPartsResult: ListPartsResponseListPartsResult;
  static names(): { [key: string]: string } {
    return {
      requestId: 'x-oss-request-id',
      listPartsResult: 'ListPartsResult',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
      listPartsResult: ListPartsResponseListPartsResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetLiveChannelHistoryRequest extends $tea.Model {
  bucketName: string;
  channelName: string;
  filter?: GetLiveChannelHistoryRequestFilter;
  static names(): { [key: string]: string } {
    return {
      bucketName: 'BucketName',
      channelName: 'ChannelName',
      filter: 'Filter',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bucketName: 'string',
      channelName: 'string',
      filter: GetLiveChannelHistoryRequestFilter,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetLiveChannelHistoryResponse extends $tea.Model {
  requestId: string;
  liveChannelHistory: GetLiveChannelHistoryResponseLiveChannelHistory;
  static names(): { [key: string]: string } {
    return {
      requestId: 'x-oss-request-id',
      liveChannelHistory: 'LiveChannelHistory',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
      liveChannelHistory: GetLiveChannelHistoryResponseLiveChannelHistory,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetBucketRequest extends $tea.Model {
  bucketName: string;
  filter?: GetBucketRequestFilter;
  static names(): { [key: string]: string } {
    return {
      bucketName: 'BucketName',
      filter: 'Filter',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bucketName: 'string',
      filter: GetBucketRequestFilter,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetBucketResponse extends $tea.Model {
  requestId: string;
  listBucketResult: GetBucketResponseListBucketResult;
  static names(): { [key: string]: string } {
    return {
      requestId: 'x-oss-request-id',
      listBucketResult: 'ListBucketResult',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
      listBucketResult: GetBucketResponseListBucketResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetLiveChannelInfoRequest extends $tea.Model {
  bucketName: string;
  channelName: string;
  static names(): { [key: string]: string } {
    return {
      bucketName: 'BucketName',
      channelName: 'ChannelName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bucketName: 'string',
      channelName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetLiveChannelInfoResponse extends $tea.Model {
  requestId: string;
  liveChannelConfiguration: GetLiveChannelInfoResponseLiveChannelConfiguration;
  static names(): { [key: string]: string } {
    return {
      requestId: 'x-oss-request-id',
      liveChannelConfiguration: 'LiveChannelConfiguration',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
      liveChannelConfiguration: GetLiveChannelInfoResponseLiveChannelConfiguration,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetLiveChannelStatRequest extends $tea.Model {
  bucketName: string;
  channelName: string;
  filter?: GetLiveChannelStatRequestFilter;
  static names(): { [key: string]: string } {
    return {
      bucketName: 'BucketName',
      channelName: 'ChannelName',
      filter: 'Filter',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bucketName: 'string',
      channelName: 'string',
      filter: GetLiveChannelStatRequestFilter,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetLiveChannelStatResponse extends $tea.Model {
  requestId: string;
  liveChannelStat: GetLiveChannelStatResponseLiveChannelStat;
  static names(): { [key: string]: string } {
    return {
      requestId: 'x-oss-request-id',
      liveChannelStat: 'LiveChannelStat',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
      liveChannelStat: GetLiveChannelStatResponseLiveChannelStat,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteObjectRequest extends $tea.Model {
  bucketName: string;
  objectName: string;
  static names(): { [key: string]: string } {
    return {
      bucketName: 'BucketName',
      objectName: 'ObjectName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bucketName: 'string',
      objectName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteObjectResponse extends $tea.Model {
  requestId: string;
  static names(): { [key: string]: string } {
    return {
      requestId: 'x-oss-request-id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AbortMultipartUploadRequest extends $tea.Model {
  bucketName: string;
  objectName: string;
  filter: AbortMultipartUploadRequestFilter;
  static names(): { [key: string]: string } {
    return {
      bucketName: 'BucketName',
      objectName: 'ObjectName',
      filter: 'Filter',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bucketName: 'string',
      objectName: 'string',
      filter: AbortMultipartUploadRequestFilter,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AbortMultipartUploadResponse extends $tea.Model {
  requestId: string;
  static names(): { [key: string]: string } {
    return {
      requestId: 'x-oss-request-id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AppendObjectRequest extends $tea.Model {
  bucketName: string;
  objectName: string;
  userMeta?: { [key: string]: string };
  body?: Readable;
  filter: AppendObjectRequestFilter;
  header?: AppendObjectRequestHeader;
  static names(): { [key: string]: string } {
    return {
      bucketName: 'BucketName',
      objectName: 'ObjectName',
      userMeta: 'UserMeta',
      body: 'body',
      filter: 'Filter',
      header: 'Header',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bucketName: 'string',
      objectName: 'string',
      userMeta: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: 'Readable',
      filter: AppendObjectRequestFilter,
      header: AppendObjectRequestHeader,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AppendObjectResponse extends $tea.Model {
  requestId: string;
  nextAppendPosition: string;
  hashCrc64ecma: string;
  static names(): { [key: string]: string } {
    return {
      requestId: 'x-oss-request-id',
      nextAppendPosition: 'x-oss-next-append-position',
      hashCrc64ecma: 'x-oss-hash-crc64ecma',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
      nextAppendPosition: 'string',
      hashCrc64ecma: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UploadPartCopyRequest extends $tea.Model {
  bucketName: string;
  objectName: string;
  filter: UploadPartCopyRequestFilter;
  header: UploadPartCopyRequestHeader;
  static names(): { [key: string]: string } {
    return {
      bucketName: 'BucketName',
      objectName: 'ObjectName',
      filter: 'Filter',
      header: 'Header',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bucketName: 'string',
      objectName: 'string',
      filter: UploadPartCopyRequestFilter,
      header: UploadPartCopyRequestHeader,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UploadPartCopyResponse extends $tea.Model {
  requestId: string;
  copyPartResult: UploadPartCopyResponseCopyPartResult;
  static names(): { [key: string]: string } {
    return {
      requestId: 'x-oss-request-id',
      copyPartResult: 'CopyPartResult',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
      copyPartResult: UploadPartCopyResponseCopyPartResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetVodPlaylistRequest extends $tea.Model {
  bucketName: string;
  channelName: string;
  filter: GetVodPlaylistRequestFilter;
  static names(): { [key: string]: string } {
    return {
      bucketName: 'BucketName',
      channelName: 'ChannelName',
      filter: 'Filter',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bucketName: 'string',
      channelName: 'string',
      filter: GetVodPlaylistRequestFilter,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetVodPlaylistResponse extends $tea.Model {
  requestId: string;
  static names(): { [key: string]: string } {
    return {
      requestId: 'x-oss-request-id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteBucketCORSRequest extends $tea.Model {
  bucketName: string;
  static names(): { [key: string]: string } {
    return {
      bucketName: 'BucketName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bucketName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteBucketCORSResponse extends $tea.Model {
  requestId: string;
  static names(): { [key: string]: string } {
    return {
      requestId: 'x-oss-request-id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetObjectRequest extends $tea.Model {
  bucketName: string;
  objectName: string;
  header?: GetObjectRequestHeader;
  static names(): { [key: string]: string } {
    return {
      bucketName: 'BucketName',
      objectName: 'ObjectName',
      header: 'Header',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bucketName: 'string',
      objectName: 'string',
      header: GetObjectRequestHeader,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetObjectResponse extends $tea.Model {
  requestId: string;
  objectType: string;
  serverSideEncryption: string;
  taggingCount: string;
  restore: string;
  body: Readable;
  static names(): { [key: string]: string } {
    return {
      requestId: 'x-oss-request-id',
      objectType: 'x-oss-object-type',
      serverSideEncryption: 'x-oss-server-side-encryption',
      taggingCount: 'x-oss-tagging-count',
      restore: 'x-oss-restore',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
      objectType: 'string',
      serverSideEncryption: 'string',
      taggingCount: 'string',
      restore: 'string',
      body: 'Readable',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UploadPartRequest extends $tea.Model {
  bucketName: string;
  objectName: string;
  body?: Readable;
  filter: UploadPartRequestFilter;
  static names(): { [key: string]: string } {
    return {
      bucketName: 'BucketName',
      objectName: 'ObjectName',
      body: 'body',
      filter: 'Filter',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bucketName: 'string',
      objectName: 'string',
      body: 'Readable',
      filter: UploadPartRequestFilter,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UploadPartResponse extends $tea.Model {
  requestId: string;
  static names(): { [key: string]: string } {
    return {
      requestId: 'x-oss-request-id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetBucketCORSRequest extends $tea.Model {
  bucketName: string;
  static names(): { [key: string]: string } {
    return {
      bucketName: 'BucketName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bucketName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetBucketCORSResponse extends $tea.Model {
  requestId: string;
  cORSConfiguration: GetBucketCORSResponseCORSConfiguration;
  static names(): { [key: string]: string } {
    return {
      requestId: 'x-oss-request-id',
      cORSConfiguration: 'CORSConfiguration',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
      cORSConfiguration: GetBucketCORSResponseCORSConfiguration,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CopyObjectRequest extends $tea.Model {
  bucketName: string;
  destObjectName: string;
  header: CopyObjectRequestHeader;
  static names(): { [key: string]: string } {
    return {
      bucketName: 'BucketName',
      destObjectName: 'DestObjectName',
      header: 'Header',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bucketName: 'string',
      destObjectName: 'string',
      header: CopyObjectRequestHeader,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CopyObjectResponse extends $tea.Model {
  requestId: string;
  copyObjectResult: CopyObjectResponseCopyObjectResult;
  static names(): { [key: string]: string } {
    return {
      requestId: 'x-oss-request-id',
      copyObjectResult: 'CopyObjectResult',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
      copyObjectResult: CopyObjectResponseCopyObjectResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetObjectTaggingRequest extends $tea.Model {
  bucketName: string;
  objectName: string;
  static names(): { [key: string]: string } {
    return {
      bucketName: 'BucketName',
      objectName: 'ObjectName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bucketName: 'string',
      objectName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetObjectTaggingResponse extends $tea.Model {
  requestId: string;
  tagging: GetObjectTaggingResponseTagging;
  static names(): { [key: string]: string } {
    return {
      requestId: 'x-oss-request-id',
      tagging: 'Tagging',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
      tagging: GetObjectTaggingResponseTagging,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteBucketLifecycleRequest extends $tea.Model {
  bucketName: string;
  static names(): { [key: string]: string } {
    return {
      bucketName: 'BucketName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bucketName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteBucketLifecycleResponse extends $tea.Model {
  requestId: string;
  static names(): { [key: string]: string } {
    return {
      requestId: 'x-oss-request-id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteBucketLoggingRequest extends $tea.Model {
  bucketName: string;
  static names(): { [key: string]: string } {
    return {
      bucketName: 'BucketName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bucketName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteBucketLoggingResponse extends $tea.Model {
  requestId: string;
  static names(): { [key: string]: string } {
    return {
      requestId: 'x-oss-request-id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteBucketWebsiteRequest extends $tea.Model {
  bucketName: string;
  static names(): { [key: string]: string } {
    return {
      bucketName: 'BucketName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bucketName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteBucketWebsiteResponse extends $tea.Model {
  requestId: string;
  static names(): { [key: string]: string } {
    return {
      requestId: 'x-oss-request-id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSymlinkRequest extends $tea.Model {
  bucketName: string;
  objectName: string;
  static names(): { [key: string]: string } {
    return {
      bucketName: 'BucketName',
      objectName: 'ObjectName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bucketName: 'string',
      objectName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSymlinkResponse extends $tea.Model {
  requestId: string;
  symlinkTarget: string;
  static names(): { [key: string]: string } {
    return {
      requestId: 'x-oss-request-id',
      symlinkTarget: 'x-oss-symlink-target',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
      symlinkTarget: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetBucketLifecycleRequest extends $tea.Model {
  bucketName: string;
  static names(): { [key: string]: string } {
    return {
      bucketName: 'BucketName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bucketName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetBucketLifecycleResponse extends $tea.Model {
  requestId: string;
  lifecycleConfiguration: GetBucketLifecycleResponseLifecycleConfiguration;
  static names(): { [key: string]: string } {
    return {
      requestId: 'x-oss-request-id',
      lifecycleConfiguration: 'LifecycleConfiguration',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
      lifecycleConfiguration: GetBucketLifecycleResponseLifecycleConfiguration,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PutSymlinkRequest extends $tea.Model {
  bucketName: string;
  objectName: string;
  header: PutSymlinkRequestHeader;
  static names(): { [key: string]: string } {
    return {
      bucketName: 'BucketName',
      objectName: 'ObjectName',
      header: 'Header',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bucketName: 'string',
      objectName: 'string',
      header: PutSymlinkRequestHeader,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PutSymlinkResponse extends $tea.Model {
  requestId: string;
  static names(): { [key: string]: string } {
    return {
      requestId: 'x-oss-request-id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetBucketRefererRequest extends $tea.Model {
  bucketName: string;
  static names(): { [key: string]: string } {
    return {
      bucketName: 'BucketName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bucketName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetBucketRefererResponse extends $tea.Model {
  requestId: string;
  refererConfiguration: GetBucketRefererResponseRefererConfiguration;
  static names(): { [key: string]: string } {
    return {
      requestId: 'x-oss-request-id',
      refererConfiguration: 'RefererConfiguration',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
      refererConfiguration: GetBucketRefererResponseRefererConfiguration,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CallbackRequest extends $tea.Model {
  bucketName: string;
  static names(): { [key: string]: string } {
    return {
      bucketName: 'BucketName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bucketName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CallbackResponse extends $tea.Model {
  requestId: string;
  static names(): { [key: string]: string } {
    return {
      requestId: 'x-oss-request-id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetBucketLoggingRequest extends $tea.Model {
  bucketName: string;
  static names(): { [key: string]: string } {
    return {
      bucketName: 'BucketName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bucketName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetBucketLoggingResponse extends $tea.Model {
  requestId: string;
  bucketLoggingStatus: GetBucketLoggingResponseBucketLoggingStatus;
  static names(): { [key: string]: string } {
    return {
      requestId: 'x-oss-request-id',
      bucketLoggingStatus: 'BucketLoggingStatus',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
      bucketLoggingStatus: GetBucketLoggingResponseBucketLoggingStatus,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PutObjectAclRequest extends $tea.Model {
  bucketName: string;
  objectName: string;
  header: PutObjectAclRequestHeader;
  static names(): { [key: string]: string } {
    return {
      bucketName: 'BucketName',
      objectName: 'ObjectName',
      header: 'Header',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bucketName: 'string',
      objectName: 'string',
      header: PutObjectAclRequestHeader,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PutObjectAclResponse extends $tea.Model {
  requestId: string;
  static names(): { [key: string]: string } {
    return {
      requestId: 'x-oss-request-id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetBucketInfoRequest extends $tea.Model {
  bucketName: string;
  static names(): { [key: string]: string } {
    return {
      bucketName: 'BucketName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bucketName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetBucketInfoResponse extends $tea.Model {
  requestId: string;
  bucketInfo: GetBucketInfoResponseBucketInfo;
  static names(): { [key: string]: string } {
    return {
      requestId: 'x-oss-request-id',
      bucketInfo: 'BucketInfo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
      bucketInfo: GetBucketInfoResponseBucketInfo,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PutLiveChannelStatusRequest extends $tea.Model {
  bucketName: string;
  channelName: string;
  filter: PutLiveChannelStatusRequestFilter;
  static names(): { [key: string]: string } {
    return {
      bucketName: 'BucketName',
      channelName: 'ChannelName',
      filter: 'Filter',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bucketName: 'string',
      channelName: 'string',
      filter: PutLiveChannelStatusRequestFilter,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PutLiveChannelStatusResponse extends $tea.Model {
  requestId: string;
  static names(): { [key: string]: string } {
    return {
      requestId: 'x-oss-request-id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InitiateMultipartUploadRequest extends $tea.Model {
  bucketName: string;
  objectName: string;
  filter?: InitiateMultipartUploadRequestFilter;
  header?: InitiateMultipartUploadRequestHeader;
  static names(): { [key: string]: string } {
    return {
      bucketName: 'BucketName',
      objectName: 'ObjectName',
      filter: 'Filter',
      header: 'Header',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bucketName: 'string',
      objectName: 'string',
      filter: InitiateMultipartUploadRequestFilter,
      header: InitiateMultipartUploadRequestHeader,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InitiateMultipartUploadResponse extends $tea.Model {
  requestId: string;
  initiateMultipartUploadResult: InitiateMultipartUploadResponseInitiateMultipartUploadResult;
  static names(): { [key: string]: string } {
    return {
      requestId: 'x-oss-request-id',
      initiateMultipartUploadResult: 'InitiateMultipartUploadResult',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
      initiateMultipartUploadResult: InitiateMultipartUploadResponseInitiateMultipartUploadResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class OptionObjectRequest extends $tea.Model {
  bucketName: string;
  objectName: string;
  header: OptionObjectRequestHeader;
  static names(): { [key: string]: string } {
    return {
      bucketName: 'BucketName',
      objectName: 'ObjectName',
      header: 'Header',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bucketName: 'string',
      objectName: 'string',
      header: OptionObjectRequestHeader,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class OptionObjectResponse extends $tea.Model {
  requestId: string;
  accessControlAllowOrigin: string;
  accessControlAllowMethods: string;
  accessControlAllowHeaders: string;
  accessControlExposeHeaders: string;
  accessControlMaxAge: string;
  static names(): { [key: string]: string } {
    return {
      requestId: 'x-oss-request-id',
      accessControlAllowOrigin: 'access-control-allow-origin',
      accessControlAllowMethods: 'access-control-allow-methods',
      accessControlAllowHeaders: 'access-control-allow-headers',
      accessControlExposeHeaders: 'access-control-expose-headers',
      accessControlMaxAge: 'access-control-max-age',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
      accessControlAllowOrigin: 'string',
      accessControlAllowMethods: 'string',
      accessControlAllowHeaders: 'string',
      accessControlExposeHeaders: 'string',
      accessControlMaxAge: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PostVodPlaylistRequest extends $tea.Model {
  bucketName: string;
  channelName: string;
  playlistName: string;
  filter: PostVodPlaylistRequestFilter;
  static names(): { [key: string]: string } {
    return {
      bucketName: 'BucketName',
      channelName: 'ChannelName',
      playlistName: 'PlaylistName',
      filter: 'Filter',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bucketName: 'string',
      channelName: 'string',
      playlistName: 'string',
      filter: PostVodPlaylistRequestFilter,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PostVodPlaylistResponse extends $tea.Model {
  requestId: string;
  static names(): { [key: string]: string } {
    return {
      requestId: 'x-oss-request-id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PostObjectRequest extends $tea.Model {
  bucketName: string;
  header: PostObjectRequestHeader;
  static names(): { [key: string]: string } {
    return {
      bucketName: 'BucketName',
      header: 'header',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bucketName: 'string',
      header: PostObjectRequestHeader,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PostObjectResponse extends $tea.Model {
  postResponse: PostObjectResponsePostResponse;
  static names(): { [key: string]: string } {
    return {
      postResponse: 'PostResponse',
    };
  }

  static types(): { [key: string]: any } {
    return {
      postResponse: PostObjectResponsePostResponse,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HeadObjectRequest extends $tea.Model {
  bucketName: string;
  objectName: string;
  header?: HeadObjectRequestHeader;
  static names(): { [key: string]: string } {
    return {
      bucketName: 'BucketName',
      objectName: 'ObjectName',
      header: 'Header',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bucketName: 'string',
      objectName: 'string',
      header: HeadObjectRequestHeader,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HeadObjectResponse extends $tea.Model {
  requestId: string;
  userMeta: { [key: string]: string };
  serverSideEncryption: string;
  serverSideEncryptionKeyId: string;
  storageClass: string;
  objectType: string;
  nextAppendPosition: string;
  hashCrc64ecma: string;
  expiration: string;
  restore: string;
  processStatus: string;
  requestCharged: string;
  contentMd5: string;
  lastModified: string;
  accessControlAllowOrigin: string;
  accessControlAllowMethods: string;
  accessControlMaxAge: string;
  accessControlAllowHeaders: string;
  accessControlExposeHeaders: string;
  taggingCount: string;
  static names(): { [key: string]: string } {
    return {
      requestId: 'x-oss-request-id',
      userMeta: 'usermeta',
      serverSideEncryption: 'x-oss-server-side-encryption',
      serverSideEncryptionKeyId: 'x-oss-server-side-encryption-key-id',
      storageClass: 'x-oss-storage-class',
      objectType: 'x-oss-object-type',
      nextAppendPosition: 'x-oss-next-append-position',
      hashCrc64ecma: 'x-oss-hash-crc64ecma',
      expiration: 'x-oss-expiration',
      restore: 'x-oss-restore',
      processStatus: 'x-oss-process-status',
      requestCharged: 'x-oss-request-charged',
      contentMd5: 'content-md5',
      lastModified: 'last-modified',
      accessControlAllowOrigin: 'access-control-allow-origin',
      accessControlAllowMethods: 'access-control-allow-methods',
      accessControlMaxAge: 'access-control-max-age',
      accessControlAllowHeaders: 'access-control-allow-headers',
      accessControlExposeHeaders: 'access-control-expose-headers',
      taggingCount: 'x-oss-tagging-count',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
      userMeta: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      serverSideEncryption: 'string',
      serverSideEncryptionKeyId: 'string',
      storageClass: 'string',
      objectType: 'string',
      nextAppendPosition: 'string',
      hashCrc64ecma: 'string',
      expiration: 'string',
      restore: 'string',
      processStatus: 'string',
      requestCharged: 'string',
      contentMd5: 'string',
      lastModified: 'string',
      accessControlAllowOrigin: 'string',
      accessControlAllowMethods: 'string',
      accessControlMaxAge: 'string',
      accessControlAllowHeaders: 'string',
      accessControlExposeHeaders: 'string',
      taggingCount: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteObjectTaggingRequest extends $tea.Model {
  bucketName: string;
  objectName: string;
  static names(): { [key: string]: string } {
    return {
      bucketName: 'BucketName',
      objectName: 'ObjectName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bucketName: 'string',
      objectName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteObjectTaggingResponse extends $tea.Model {
  requestId: string;
  static names(): { [key: string]: string } {
    return {
      requestId: 'x-oss-request-id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RestoreObjectRequest extends $tea.Model {
  bucketName: string;
  objectName: string;
  static names(): { [key: string]: string } {
    return {
      bucketName: 'BucketName',
      objectName: 'ObjectName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bucketName: 'string',
      objectName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RestoreObjectResponse extends $tea.Model {
  requestId: string;
  static names(): { [key: string]: string } {
    return {
      requestId: 'x-oss-request-id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetObjectAclRequest extends $tea.Model {
  bucketName: string;
  objectName: string;
  static names(): { [key: string]: string } {
    return {
      bucketName: 'BucketName',
      objectName: 'ObjectName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bucketName: 'string',
      objectName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetObjectAclResponse extends $tea.Model {
  requestId: string;
  accessControlPolicy: GetObjectAclResponseAccessControlPolicy;
  static names(): { [key: string]: string } {
    return {
      requestId: 'x-oss-request-id',
      accessControlPolicy: 'AccessControlPolicy',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
      accessControlPolicy: GetObjectAclResponseAccessControlPolicy,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PutBucketAclRequest extends $tea.Model {
  bucketName: string;
  header: PutBucketAclRequestHeader;
  static names(): { [key: string]: string } {
    return {
      bucketName: 'BucketName',
      header: 'Header',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bucketName: 'string',
      header: PutBucketAclRequestHeader,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PutBucketAclResponse extends $tea.Model {
  requestId: string;
  static names(): { [key: string]: string } {
    return {
      requestId: 'x-oss-request-id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteBucketRequest extends $tea.Model {
  bucketName: string;
  static names(): { [key: string]: string } {
    return {
      bucketName: 'BucketName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bucketName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteBucketResponse extends $tea.Model {
  requestId: string;
  static names(): { [key: string]: string } {
    return {
      requestId: 'x-oss-request-id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PutObjectRequest extends $tea.Model {
  bucketName: string;
  objectName: string;
  userMeta?: { [key: string]: string };
  body?: Readable;
  header?: PutObjectRequestHeader;
  static names(): { [key: string]: string } {
    return {
      bucketName: 'BucketName',
      objectName: 'ObjectName',
      userMeta: 'UserMeta',
      body: 'body',
      header: 'Header',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bucketName: 'string',
      objectName: 'string',
      userMeta: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: 'Readable',
      header: PutObjectRequestHeader,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PutObjectResponse extends $tea.Model {
  requestId: string;
  hashCrc64ecma: string;
  serverTime: string;
  bucketVersion: string;
  static names(): { [key: string]: string } {
    return {
      requestId: 'x-oss-request-id',
      hashCrc64ecma: 'x-oss-hash-crc64ecma',
      serverTime: 'x-oss-server-time',
      bucketVersion: 'x-oss-bucket-version',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
      hashCrc64ecma: 'string',
      serverTime: 'string',
      bucketVersion: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PutBucketLifecycleRequestBodyLifecycleConfigurationRuleExpiration extends $tea.Model {
  days?: number;
  createdBeforeDate?: string;
  static names(): { [key: string]: string } {
    return {
      days: 'Days',
      createdBeforeDate: 'CreatedBeforeDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      days: 'number',
      createdBeforeDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PutBucketLifecycleRequestBodyLifecycleConfigurationRuleTransition extends $tea.Model {
  days?: number;
  storageClass?: string;
  static names(): { [key: string]: string } {
    return {
      days: 'Days',
      storageClass: 'StorageClass',
    };
  }

  static types(): { [key: string]: any } {
    return {
      days: 'number',
      storageClass: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PutBucketLifecycleRequestBodyLifecycleConfigurationRuleAbortMultipartUpload extends $tea.Model {
  days?: number;
  createdBeforeDate?: string;
  static names(): { [key: string]: string } {
    return {
      days: 'Days',
      createdBeforeDate: 'CreatedBeforeDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      days: 'number',
      createdBeforeDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PutBucketLifecycleRequestBodyLifecycleConfigurationRuleTag extends $tea.Model {
  key?: string;
  value?: string;
  static names(): { [key: string]: string } {
    return {
      key: 'Key',
      value: 'Value',
    };
  }

  static types(): { [key: string]: any } {
    return {
      key: 'string',
      value: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PutBucketLifecycleRequestBodyLifecycleConfigurationRule extends $tea.Model {
  expiration?: PutBucketLifecycleRequestBodyLifecycleConfigurationRuleExpiration;
  transition?: PutBucketLifecycleRequestBodyLifecycleConfigurationRuleTransition;
  abortMultipartUpload?: PutBucketLifecycleRequestBodyLifecycleConfigurationRuleAbortMultipartUpload;
  tag?: PutBucketLifecycleRequestBodyLifecycleConfigurationRuleTag;
  iD?: string;
  prefix?: string;
  status?: string;
  static names(): { [key: string]: string } {
    return {
      expiration: 'Expiration',
      transition: 'Transition',
      abortMultipartUpload: 'AbortMultipartUpload',
      tag: 'Tag',
      iD: 'ID',
      prefix: 'Prefix',
      status: 'Status',
    };
  }

  static types(): { [key: string]: any } {
    return {
      expiration: PutBucketLifecycleRequestBodyLifecycleConfigurationRuleExpiration,
      transition: PutBucketLifecycleRequestBodyLifecycleConfigurationRuleTransition,
      abortMultipartUpload: PutBucketLifecycleRequestBodyLifecycleConfigurationRuleAbortMultipartUpload,
      tag: PutBucketLifecycleRequestBodyLifecycleConfigurationRuleTag,
      iD: 'string',
      prefix: 'string',
      status: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PutBucketLifecycleRequestBodyLifecycleConfiguration extends $tea.Model {
  rule?: PutBucketLifecycleRequestBodyLifecycleConfigurationRule[];
  static names(): { [key: string]: string } {
    return {
      rule: 'Rule',
    };
  }

  static types(): { [key: string]: any } {
    return {
      rule: { 'type': 'array', 'itemType': PutBucketLifecycleRequestBodyLifecycleConfigurationRule },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PutBucketLifecycleRequestBody extends $tea.Model {
  lifecycleConfiguration: PutBucketLifecycleRequestBodyLifecycleConfiguration;
  static names(): { [key: string]: string } {
    return {
      lifecycleConfiguration: 'LifecycleConfiguration',
    };
  }

  static types(): { [key: string]: any } {
    return {
      lifecycleConfiguration: PutBucketLifecycleRequestBodyLifecycleConfiguration,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteMultipleObjectsRequestBodyDeleteObject extends $tea.Model {
  key?: string;
  static names(): { [key: string]: string } {
    return {
      key: 'Key',
    };
  }

  static types(): { [key: string]: any } {
    return {
      key: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteMultipleObjectsRequestBodyDelete extends $tea.Model {
  object?: DeleteMultipleObjectsRequestBodyDeleteObject[];
  quiet?: string;
  static names(): { [key: string]: string } {
    return {
      object: 'Object',
      quiet: 'Quiet',
    };
  }

  static types(): { [key: string]: any } {
    return {
      object: { 'type': 'array', 'itemType': DeleteMultipleObjectsRequestBodyDeleteObject },
      quiet: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteMultipleObjectsRequestBody extends $tea.Model {
  delete: DeleteMultipleObjectsRequestBodyDelete;
  static names(): { [key: string]: string } {
    return {
      delete: 'Delete',
    };
  }

  static types(): { [key: string]: any } {
    return {
      delete: DeleteMultipleObjectsRequestBodyDelete,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteMultipleObjectsRequestHeader extends $tea.Model {
  encodingType?: string;
  contentLength: string;
  contentMD5: string;
  static names(): { [key: string]: string } {
    return {
      encodingType: 'Encoding-type',
      contentLength: 'Content-Length',
      contentMD5: 'Content-MD5',
    };
  }

  static types(): { [key: string]: any } {
    return {
      encodingType: 'string',
      contentLength: 'string',
      contentMD5: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteMultipleObjectsResponseDeleteResultDeleted extends $tea.Model {
  key?: string;
  static names(): { [key: string]: string } {
    return {
      key: 'Key',
    };
  }

  static types(): { [key: string]: any } {
    return {
      key: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteMultipleObjectsResponseDeleteResult extends $tea.Model {
  quiet?: string;
  encodingType?: string;
  deleted?: DeleteMultipleObjectsResponseDeleteResultDeleted[];
  static names(): { [key: string]: string } {
    return {
      quiet: 'Quiet',
      encodingType: 'EncodingType',
      deleted: 'Deleted',
    };
  }

  static types(): { [key: string]: any } {
    return {
      quiet: 'string',
      encodingType: 'string',
      deleted: { 'type': 'array', 'itemType': DeleteMultipleObjectsResponseDeleteResultDeleted },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PutBucketRefererRequestBodyRefererConfigurationRefererList extends $tea.Model {
  referer?: string[];
  static names(): { [key: string]: string } {
    return {
      referer: 'Referer',
    };
  }

  static types(): { [key: string]: any } {
    return {
      referer: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PutBucketRefererRequestBodyRefererConfiguration extends $tea.Model {
  refererList?: PutBucketRefererRequestBodyRefererConfigurationRefererList;
  allowEmptyReferer?: boolean;
  static names(): { [key: string]: string } {
    return {
      refererList: 'RefererList',
      allowEmptyReferer: 'AllowEmptyReferer',
    };
  }

  static types(): { [key: string]: any } {
    return {
      refererList: PutBucketRefererRequestBodyRefererConfigurationRefererList,
      allowEmptyReferer: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PutBucketRefererRequestBody extends $tea.Model {
  refererConfiguration: PutBucketRefererRequestBodyRefererConfiguration;
  static names(): { [key: string]: string } {
    return {
      refererConfiguration: 'RefererConfiguration',
    };
  }

  static types(): { [key: string]: any } {
    return {
      refererConfiguration: PutBucketRefererRequestBodyRefererConfiguration,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PutBucketWebsiteRequestBodyWebsiteConfigurationIndexDocument extends $tea.Model {
  suffix?: string;
  static names(): { [key: string]: string } {
    return {
      suffix: 'Suffix',
    };
  }

  static types(): { [key: string]: any } {
    return {
      suffix: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PutBucketWebsiteRequestBodyWebsiteConfigurationErrorDocument extends $tea.Model {
  key?: string;
  static names(): { [key: string]: string } {
    return {
      key: 'Key',
    };
  }

  static types(): { [key: string]: any } {
    return {
      key: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleConditionIncludeHeader extends $tea.Model {
  key?: string;
  equals?: string;
  static names(): { [key: string]: string } {
    return {
      key: 'Key',
      equals: 'Equals',
    };
  }

  static types(): { [key: string]: any } {
    return {
      key: 'string',
      equals: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleCondition extends $tea.Model {
  includeHeader?: PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleConditionIncludeHeader;
  keyPrefixEquals?: string;
  httpErrorCodeReturnedEquals?: string;
  static names(): { [key: string]: string } {
    return {
      includeHeader: 'IncludeHeader',
      keyPrefixEquals: 'KeyPrefixEquals',
      httpErrorCodeReturnedEquals: 'HttpErrorCodeReturnedEquals',
    };
  }

  static types(): { [key: string]: any } {
    return {
      includeHeader: PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleConditionIncludeHeader,
      keyPrefixEquals: 'string',
      httpErrorCodeReturnedEquals: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeadersSet extends $tea.Model {
  key?: string;
  value?: string;
  static names(): { [key: string]: string } {
    return {
      key: 'Key',
      value: 'Value',
    };
  }

  static types(): { [key: string]: any } {
    return {
      key: 'string',
      value: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeaders extends $tea.Model {
  set?: PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeadersSet;
  passAll?: boolean;
  pass?: string;
  remove?: string;
  static names(): { [key: string]: string } {
    return {
      set: 'Set',
      passAll: 'PassAll',
      pass: 'Pass',
      remove: 'Remove',
    };
  }

  static types(): { [key: string]: any } {
    return {
      set: PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeadersSet,
      passAll: 'boolean',
      pass: 'string',
      remove: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirect extends $tea.Model {
  mirrorHeaders?: PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeaders;
  redirectType?: string;
  passQueryString?: boolean;
  mirrorURL?: string;
  mirrorPassQueryString?: boolean;
  mirrorFollowRedirect?: boolean;
  mirrorCheckMd5?: boolean;
  protocol?: string;
  hostName?: string;
  httpRedirectCode?: string;
  replaceKeyPrefixWith?: string;
  replaceKeyWith?: string;
  static names(): { [key: string]: string } {
    return {
      mirrorHeaders: 'MirrorHeaders',
      redirectType: 'RedirectType',
      passQueryString: 'PassQueryString',
      mirrorURL: 'MirrorURL',
      mirrorPassQueryString: 'MirrorPassQueryString',
      mirrorFollowRedirect: 'MirrorFollowRedirect',
      mirrorCheckMd5: 'MirrorCheckMd5',
      protocol: 'Protocol',
      hostName: 'HostName',
      httpRedirectCode: 'HttpRedirectCode',
      replaceKeyPrefixWith: 'ReplaceKeyPrefixWith',
      replaceKeyWith: 'ReplaceKeyWith',
    };
  }

  static types(): { [key: string]: any } {
    return {
      mirrorHeaders: PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeaders,
      redirectType: 'string',
      passQueryString: 'boolean',
      mirrorURL: 'string',
      mirrorPassQueryString: 'boolean',
      mirrorFollowRedirect: 'boolean',
      mirrorCheckMd5: 'boolean',
      protocol: 'string',
      hostName: 'string',
      httpRedirectCode: 'string',
      replaceKeyPrefixWith: 'string',
      replaceKeyWith: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRule extends $tea.Model {
  condition?: PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleCondition;
  redirect?: PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirect;
  ruleNumber?: number;
  static names(): { [key: string]: string } {
    return {
      condition: 'Condition',
      redirect: 'Redirect',
      ruleNumber: 'RuleNumber',
    };
  }

  static types(): { [key: string]: any } {
    return {
      condition: PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleCondition,
      redirect: PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirect,
      ruleNumber: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRules extends $tea.Model {
  routingRule?: PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRule[];
  static names(): { [key: string]: string } {
    return {
      routingRule: 'RoutingRule',
    };
  }

  static types(): { [key: string]: any } {
    return {
      routingRule: { 'type': 'array', 'itemType': PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRule },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PutBucketWebsiteRequestBodyWebsiteConfiguration extends $tea.Model {
  indexDocument?: PutBucketWebsiteRequestBodyWebsiteConfigurationIndexDocument;
  errorDocument?: PutBucketWebsiteRequestBodyWebsiteConfigurationErrorDocument;
  routingRules?: PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRules;
  static names(): { [key: string]: string } {
    return {
      indexDocument: 'IndexDocument',
      errorDocument: 'ErrorDocument',
      routingRules: 'RoutingRules',
    };
  }

  static types(): { [key: string]: any } {
    return {
      indexDocument: PutBucketWebsiteRequestBodyWebsiteConfigurationIndexDocument,
      errorDocument: PutBucketWebsiteRequestBodyWebsiteConfigurationErrorDocument,
      routingRules: PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRules,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PutBucketWebsiteRequestBody extends $tea.Model {
  websiteConfiguration: PutBucketWebsiteRequestBodyWebsiteConfiguration;
  static names(): { [key: string]: string } {
    return {
      websiteConfiguration: 'WebsiteConfiguration',
    };
  }

  static types(): { [key: string]: any } {
    return {
      websiteConfiguration: PutBucketWebsiteRequestBodyWebsiteConfiguration,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CompleteMultipartUploadRequestFilter extends $tea.Model {
  uploadId: string;
  encodingType?: string;
  static names(): { [key: string]: string } {
    return {
      uploadId: 'uploadId',
      encodingType: 'Encoding-type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      uploadId: 'string',
      encodingType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CompleteMultipartUploadRequestBodyCompleteMultipartUploadPart extends $tea.Model {
  partNumber?: string;
  eTag?: string;
  static names(): { [key: string]: string } {
    return {
      partNumber: 'PartNumber',
      eTag: 'ETag',
    };
  }

  static types(): { [key: string]: any } {
    return {
      partNumber: 'string',
      eTag: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CompleteMultipartUploadRequestBodyCompleteMultipartUpload extends $tea.Model {
  part?: CompleteMultipartUploadRequestBodyCompleteMultipartUploadPart[];
  static names(): { [key: string]: string } {
    return {
      part: 'Part',
    };
  }

  static types(): { [key: string]: any } {
    return {
      part: { 'type': 'array', 'itemType': CompleteMultipartUploadRequestBodyCompleteMultipartUploadPart },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CompleteMultipartUploadRequestBody extends $tea.Model {
  completeMultipartUpload: CompleteMultipartUploadRequestBodyCompleteMultipartUpload;
  static names(): { [key: string]: string } {
    return {
      completeMultipartUpload: 'CompleteMultipartUpload',
    };
  }

  static types(): { [key: string]: any } {
    return {
      completeMultipartUpload: CompleteMultipartUploadRequestBodyCompleteMultipartUpload,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CompleteMultipartUploadResponseCompleteMultipartUploadResult extends $tea.Model {
  bucket?: string;
  eTag?: string;
  location?: string;
  key?: string;
  encodingType?: string;
  static names(): { [key: string]: string } {
    return {
      bucket: 'Bucket',
      eTag: 'ETag',
      location: 'Location',
      key: 'Key',
      encodingType: 'EncodingType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bucket: 'string',
      eTag: 'string',
      location: 'string',
      key: 'string',
      encodingType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PutBucketLoggingRequestBodyBucketLoggingStatusLoggingEnabled extends $tea.Model {
  targetBucket?: string;
  targetPrefix?: string;
  static names(): { [key: string]: string } {
    return {
      targetBucket: 'TargetBucket',
      targetPrefix: 'TargetPrefix',
    };
  }

  static types(): { [key: string]: any } {
    return {
      targetBucket: 'string',
      targetPrefix: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PutBucketLoggingRequestBodyBucketLoggingStatus extends $tea.Model {
  loggingEnabled?: PutBucketLoggingRequestBodyBucketLoggingStatusLoggingEnabled;
  static names(): { [key: string]: string } {
    return {
      loggingEnabled: 'LoggingEnabled',
    };
  }

  static types(): { [key: string]: any } {
    return {
      loggingEnabled: PutBucketLoggingRequestBodyBucketLoggingStatusLoggingEnabled,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PutBucketLoggingRequestBody extends $tea.Model {
  bucketLoggingStatus: PutBucketLoggingRequestBodyBucketLoggingStatus;
  static names(): { [key: string]: string } {
    return {
      bucketLoggingStatus: 'BucketLoggingStatus',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bucketLoggingStatus: PutBucketLoggingRequestBodyBucketLoggingStatus,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PutBucketRequestPaymentRequestBodyRequestPaymentConfiguration extends $tea.Model {
  payer?: string;
  static names(): { [key: string]: string } {
    return {
      payer: 'Payer',
    };
  }

  static types(): { [key: string]: any } {
    return {
      payer: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PutBucketRequestPaymentRequestBody extends $tea.Model {
  requestPaymentConfiguration: PutBucketRequestPaymentRequestBodyRequestPaymentConfiguration;
  static names(): { [key: string]: string } {
    return {
      requestPaymentConfiguration: 'RequestPaymentConfiguration',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestPaymentConfiguration: PutBucketRequestPaymentRequestBodyRequestPaymentConfiguration,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PutBucketEncryptionRequestBodyServerSideEncryptionRuleApplyServerSideEncryptionByDefault extends $tea.Model {
  sSEAlgorithm?: string;
  kMSMasterKeyID?: string;
  static names(): { [key: string]: string } {
    return {
      sSEAlgorithm: 'SSEAlgorithm',
      kMSMasterKeyID: 'KMSMasterKeyID',
    };
  }

  static types(): { [key: string]: any } {
    return {
      sSEAlgorithm: 'string',
      kMSMasterKeyID: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PutBucketEncryptionRequestBodyServerSideEncryptionRule extends $tea.Model {
  applyServerSideEncryptionByDefault?: PutBucketEncryptionRequestBodyServerSideEncryptionRuleApplyServerSideEncryptionByDefault;
  static names(): { [key: string]: string } {
    return {
      applyServerSideEncryptionByDefault: 'ApplyServerSideEncryptionByDefault',
    };
  }

  static types(): { [key: string]: any } {
    return {
      applyServerSideEncryptionByDefault: PutBucketEncryptionRequestBodyServerSideEncryptionRuleApplyServerSideEncryptionByDefault,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PutBucketEncryptionRequestBody extends $tea.Model {
  serverSideEncryptionRule: PutBucketEncryptionRequestBodyServerSideEncryptionRule;
  static names(): { [key: string]: string } {
    return {
      serverSideEncryptionRule: 'ServerSideEncryptionRule',
    };
  }

  static types(): { [key: string]: any } {
    return {
      serverSideEncryptionRule: PutBucketEncryptionRequestBodyServerSideEncryptionRule,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PutLiveChannelRequestBodyLiveChannelConfigurationTarget extends $tea.Model {
  type?: string;
  fragDuration?: string;
  fragCount?: string;
  playlistName?: string;
  static names(): { [key: string]: string } {
    return {
      type: 'Type',
      fragDuration: 'FragDuration',
      fragCount: 'FragCount',
      playlistName: 'PlaylistName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      type: 'string',
      fragDuration: 'string',
      fragCount: 'string',
      playlistName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PutLiveChannelRequestBodyLiveChannelConfigurationSnapshot extends $tea.Model {
  roleName?: string;
  destBucket?: string;
  notifyTopic?: string;
  interval?: string;
  static names(): { [key: string]: string } {
    return {
      roleName: 'RoleName',
      destBucket: 'DestBucket',
      notifyTopic: 'NotifyTopic',
      interval: 'Interval',
    };
  }

  static types(): { [key: string]: any } {
    return {
      roleName: 'string',
      destBucket: 'string',
      notifyTopic: 'string',
      interval: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PutLiveChannelRequestBodyLiveChannelConfiguration extends $tea.Model {
  target?: PutLiveChannelRequestBodyLiveChannelConfigurationTarget;
  snapshot?: PutLiveChannelRequestBodyLiveChannelConfigurationSnapshot;
  description?: string;
  status?: string;
  static names(): { [key: string]: string } {
    return {
      target: 'Target',
      snapshot: 'Snapshot',
      description: 'Description',
      status: 'Status',
    };
  }

  static types(): { [key: string]: any } {
    return {
      target: PutLiveChannelRequestBodyLiveChannelConfigurationTarget,
      snapshot: PutLiveChannelRequestBodyLiveChannelConfigurationSnapshot,
      description: 'string',
      status: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PutLiveChannelRequestBody extends $tea.Model {
  liveChannelConfiguration: PutLiveChannelRequestBodyLiveChannelConfiguration;
  static names(): { [key: string]: string } {
    return {
      liveChannelConfiguration: 'LiveChannelConfiguration',
    };
  }

  static types(): { [key: string]: any } {
    return {
      liveChannelConfiguration: PutLiveChannelRequestBodyLiveChannelConfiguration,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PutLiveChannelResponseCreateLiveChannelResultPublishUrls extends $tea.Model {
  url?: string;
  static names(): { [key: string]: string } {
    return {
      url: 'Url',
    };
  }

  static types(): { [key: string]: any } {
    return {
      url: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PutLiveChannelResponseCreateLiveChannelResultPlayUrls extends $tea.Model {
  url?: string;
  static names(): { [key: string]: string } {
    return {
      url: 'Url',
    };
  }

  static types(): { [key: string]: any } {
    return {
      url: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PutLiveChannelResponseCreateLiveChannelResult extends $tea.Model {
  publishUrls: PutLiveChannelResponseCreateLiveChannelResultPublishUrls;
  playUrls: PutLiveChannelResponseCreateLiveChannelResultPlayUrls;
  static names(): { [key: string]: string } {
    return {
      publishUrls: 'PublishUrls',
      playUrls: 'PlayUrls',
    };
  }

  static types(): { [key: string]: any } {
    return {
      publishUrls: PutLiveChannelResponseCreateLiveChannelResultPublishUrls,
      playUrls: PutLiveChannelResponseCreateLiveChannelResultPlayUrls,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PutBucketTagsRequestBodyTaggingTagSetTag extends $tea.Model {
  key?: string;
  value?: string;
  static names(): { [key: string]: string } {
    return {
      key: 'Key',
      value: 'Value',
    };
  }

  static types(): { [key: string]: any } {
    return {
      key: 'string',
      value: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PutBucketTagsRequestBodyTaggingTagSet extends $tea.Model {
  tag?: PutBucketTagsRequestBodyTaggingTagSetTag[];
  static names(): { [key: string]: string } {
    return {
      tag: 'Tag',
    };
  }

  static types(): { [key: string]: any } {
    return {
      tag: { 'type': 'array', 'itemType': PutBucketTagsRequestBodyTaggingTagSetTag },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PutBucketTagsRequestBodyTagging extends $tea.Model {
  tagSet?: PutBucketTagsRequestBodyTaggingTagSet;
  static names(): { [key: string]: string } {
    return {
      tagSet: 'TagSet',
    };
  }

  static types(): { [key: string]: any } {
    return {
      tagSet: PutBucketTagsRequestBodyTaggingTagSet,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PutBucketTagsRequestBody extends $tea.Model {
  tagging: PutBucketTagsRequestBodyTagging;
  static names(): { [key: string]: string } {
    return {
      tagging: 'Tagging',
    };
  }

  static types(): { [key: string]: any } {
    return {
      tagging: PutBucketTagsRequestBodyTagging,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PutObjectTaggingRequestBodyTaggingTagSetTag extends $tea.Model {
  key?: string;
  value?: string;
  static names(): { [key: string]: string } {
    return {
      key: 'Key',
      value: 'Value',
    };
  }

  static types(): { [key: string]: any } {
    return {
      key: 'string',
      value: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PutObjectTaggingRequestBodyTaggingTagSet extends $tea.Model {
  tag?: PutObjectTaggingRequestBodyTaggingTagSetTag[];
  static names(): { [key: string]: string } {
    return {
      tag: 'Tag',
    };
  }

  static types(): { [key: string]: any } {
    return {
      tag: { 'type': 'array', 'itemType': PutObjectTaggingRequestBodyTaggingTagSetTag },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PutObjectTaggingRequestBodyTagging extends $tea.Model {
  tagSet?: PutObjectTaggingRequestBodyTaggingTagSet;
  static names(): { [key: string]: string } {
    return {
      tagSet: 'TagSet',
    };
  }

  static types(): { [key: string]: any } {
    return {
      tagSet: PutObjectTaggingRequestBodyTaggingTagSet,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PutObjectTaggingRequestBody extends $tea.Model {
  tagging: PutObjectTaggingRequestBodyTagging;
  static names(): { [key: string]: string } {
    return {
      tagging: 'Tagging',
    };
  }

  static types(): { [key: string]: any } {
    return {
      tagging: PutObjectTaggingRequestBodyTagging,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SelectObjectRequestFilter extends $tea.Model {
  porcess: string;
  static names(): { [key: string]: string } {
    return {
      porcess: 'x-oss-process',
    };
  }

  static types(): { [key: string]: any } {
    return {
      porcess: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SelectObjectRequestBodySelectRequestInputSerializationCSV extends $tea.Model {
  fileHeaderInfo?: string;
  recordDelimiter?: string;
  fieldDelimiter?: string;
  quoteCharacter?: string;
  commentCharacter?: string;
  range?: string;
  static names(): { [key: string]: string } {
    return {
      fileHeaderInfo: 'FileHeaderInfo',
      recordDelimiter: 'RecordDelimiter',
      fieldDelimiter: 'FieldDelimiter',
      quoteCharacter: 'QuoteCharacter',
      commentCharacter: 'CommentCharacter',
      range: 'Range',
    };
  }

  static types(): { [key: string]: any } {
    return {
      fileHeaderInfo: 'string',
      recordDelimiter: 'string',
      fieldDelimiter: 'string',
      quoteCharacter: 'string',
      commentCharacter: 'string',
      range: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SelectObjectRequestBodySelectRequestInputSerialization extends $tea.Model {
  cSV?: SelectObjectRequestBodySelectRequestInputSerializationCSV;
  compressionType?: string;
  static names(): { [key: string]: string } {
    return {
      cSV: 'CSV',
      compressionType: 'CompressionType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      cSV: SelectObjectRequestBodySelectRequestInputSerializationCSV,
      compressionType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SelectObjectRequestBodySelectRequestOutputSerializationCSV extends $tea.Model {
  recordDelimiter?: string;
  fieldDelimiter?: string;
  static names(): { [key: string]: string } {
    return {
      recordDelimiter: 'RecordDelimiter',
      fieldDelimiter: 'FieldDelimiter',
    };
  }

  static types(): { [key: string]: any } {
    return {
      recordDelimiter: 'string',
      fieldDelimiter: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SelectObjectRequestBodySelectRequestOutputSerialization extends $tea.Model {
  cSV?: SelectObjectRequestBodySelectRequestOutputSerializationCSV;
  keepAllColumns?: string;
  outputRawData?: string;
  enablePayloadCrc?: string;
  outputHeader?: string;
  static names(): { [key: string]: string } {
    return {
      cSV: 'CSV',
      keepAllColumns: 'KeepAllColumns',
      outputRawData: 'OutputRawData',
      enablePayloadCrc: 'EnablePayloadCrc',
      outputHeader: 'OutputHeader',
    };
  }

  static types(): { [key: string]: any } {
    return {
      cSV: SelectObjectRequestBodySelectRequestOutputSerializationCSV,
      keepAllColumns: 'string',
      outputRawData: 'string',
      enablePayloadCrc: 'string',
      outputHeader: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SelectObjectRequestBodySelectRequestOptions extends $tea.Model {
  skipPartialDataRecord?: string;
  maxSkippedRecordsAllowed?: string;
  static names(): { [key: string]: string } {
    return {
      skipPartialDataRecord: 'SkipPartialDataRecord',
      maxSkippedRecordsAllowed: 'MaxSkippedRecordsAllowed',
    };
  }

  static types(): { [key: string]: any } {
    return {
      skipPartialDataRecord: 'string',
      maxSkippedRecordsAllowed: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SelectObjectRequestBodySelectRequest extends $tea.Model {
  inputSerialization?: SelectObjectRequestBodySelectRequestInputSerialization;
  outputSerialization?: SelectObjectRequestBodySelectRequestOutputSerialization;
  options?: SelectObjectRequestBodySelectRequestOptions;
  expression?: string;
  static names(): { [key: string]: string } {
    return {
      inputSerialization: 'InputSerialization',
      outputSerialization: 'OutputSerialization',
      options: 'Options',
      expression: 'Expression',
    };
  }

  static types(): { [key: string]: any } {
    return {
      inputSerialization: SelectObjectRequestBodySelectRequestInputSerialization,
      outputSerialization: SelectObjectRequestBodySelectRequestOutputSerialization,
      options: SelectObjectRequestBodySelectRequestOptions,
      expression: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SelectObjectRequestBody extends $tea.Model {
  selectRequest: SelectObjectRequestBodySelectRequest;
  static names(): { [key: string]: string } {
    return {
      selectRequest: 'SelectRequest',
    };
  }

  static types(): { [key: string]: any } {
    return {
      selectRequest: SelectObjectRequestBodySelectRequest,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PutBucketCORSRequestBodyCORSConfigurationCORSRule extends $tea.Model {
  allowedOrigin?: string[];
  allowedMethod?: string[];
  allowedHeader?: string[];
  exposeHeader?: string[];
  maxAgeSeconds?: string;
  static names(): { [key: string]: string } {
    return {
      allowedOrigin: 'AllowedOrigin',
      allowedMethod: 'AllowedMethod',
      allowedHeader: 'AllowedHeader',
      exposeHeader: 'ExposeHeader',
      maxAgeSeconds: 'MaxAgeSeconds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      allowedOrigin: { 'type': 'array', 'itemType': 'string' },
      allowedMethod: { 'type': 'array', 'itemType': 'string' },
      allowedHeader: { 'type': 'array', 'itemType': 'string' },
      exposeHeader: { 'type': 'array', 'itemType': 'string' },
      maxAgeSeconds: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PutBucketCORSRequestBodyCORSConfiguration extends $tea.Model {
  cORSRule?: PutBucketCORSRequestBodyCORSConfigurationCORSRule[];
  static names(): { [key: string]: string } {
    return {
      cORSRule: 'CORSRule',
    };
  }

  static types(): { [key: string]: any } {
    return {
      cORSRule: { 'type': 'array', 'itemType': PutBucketCORSRequestBodyCORSConfigurationCORSRule },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PutBucketCORSRequestBody extends $tea.Model {
  cORSConfiguration: PutBucketCORSRequestBodyCORSConfiguration;
  static names(): { [key: string]: string } {
    return {
      cORSConfiguration: 'CORSConfiguration',
    };
  }

  static types(): { [key: string]: any } {
    return {
      cORSConfiguration: PutBucketCORSRequestBodyCORSConfiguration,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PutBucketRequestBodyCreateBucketConfiguration extends $tea.Model {
  storageClass?: string;
  dataRedundancyType?: string;
  static names(): { [key: string]: string } {
    return {
      storageClass: 'StorageClass',
      dataRedundancyType: 'DataRedundancyType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      storageClass: 'string',
      dataRedundancyType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PutBucketRequestBody extends $tea.Model {
  createBucketConfiguration: PutBucketRequestBodyCreateBucketConfiguration;
  static names(): { [key: string]: string } {
    return {
      createBucketConfiguration: 'CreateBucketConfiguration',
    };
  }

  static types(): { [key: string]: any } {
    return {
      createBucketConfiguration: PutBucketRequestBodyCreateBucketConfiguration,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PutBucketRequestHeader extends $tea.Model {
  acl?: string;
  static names(): { [key: string]: string } {
    return {
      acl: 'x-oss-acl',
    };
  }

  static types(): { [key: string]: any } {
    return {
      acl: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListMultipartUploadsRequestFilter extends $tea.Model {
  delimiter?: string;
  maxUploads?: string;
  keyMarker?: string;
  prefix?: string;
  uploadIdMarker?: string;
  encodingType?: string;
  static names(): { [key: string]: string } {
    return {
      delimiter: 'delimiter',
      maxUploads: 'max-uploads',
      keyMarker: 'key-marker',
      prefix: 'prefix',
      uploadIdMarker: 'upload-id-marker',
      encodingType: 'encoding-type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      delimiter: 'string',
      maxUploads: 'string',
      keyMarker: 'string',
      prefix: 'string',
      uploadIdMarker: 'string',
      encodingType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListMultipartUploadsResponseListMultipartUploadsResultUpload extends $tea.Model {
  key?: string;
  uploadId?: string;
  initiated?: string;
  static names(): { [key: string]: string } {
    return {
      key: 'Key',
      uploadId: 'UploadId',
      initiated: 'Initiated',
    };
  }

  static types(): { [key: string]: any } {
    return {
      key: 'string',
      uploadId: 'string',
      initiated: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListMultipartUploadsResponseListMultipartUploadsResult extends $tea.Model {
  bucket?: string;
  encodingType?: string;
  keyMarker?: string;
  uploadIdMarker?: string;
  nextKeyMarker?: string;
  nextUploadIdMarker?: string;
  delimiter?: string;
  maxUploads?: string;
  isTruncated?: string;
  upload?: ListMultipartUploadsResponseListMultipartUploadsResultUpload[];
  static names(): { [key: string]: string } {
    return {
      bucket: 'Bucket',
      encodingType: 'EncodingType',
      keyMarker: 'KeyMarker',
      uploadIdMarker: 'UploadIdMarker',
      nextKeyMarker: 'NextKeyMarker',
      nextUploadIdMarker: 'NextUploadIdMarker',
      delimiter: 'Delimiter',
      maxUploads: 'MaxUploads',
      isTruncated: 'IsTruncated',
      upload: 'Upload',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bucket: 'string',
      encodingType: 'string',
      keyMarker: 'string',
      uploadIdMarker: 'string',
      nextKeyMarker: 'string',
      nextUploadIdMarker: 'string',
      delimiter: 'string',
      maxUploads: 'string',
      isTruncated: 'string',
      upload: { 'type': 'array', 'itemType': ListMultipartUploadsResponseListMultipartUploadsResultUpload },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetBucketRequestPaymentResponseRequestPaymentConfiguration extends $tea.Model {
  payer?: string;
  static names(): { [key: string]: string } {
    return {
      payer: 'Payer',
    };
  }

  static types(): { [key: string]: any } {
    return {
      payer: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetBucketEncryptionResponseServerSideEncryptionRuleApplyServerSideEncryptionByDefault extends $tea.Model {
  sSEAlgorithm?: string;
  kMSMasterKeyID?: string;
  static names(): { [key: string]: string } {
    return {
      sSEAlgorithm: 'SSEAlgorithm',
      kMSMasterKeyID: 'KMSMasterKeyID',
    };
  }

  static types(): { [key: string]: any } {
    return {
      sSEAlgorithm: 'string',
      kMSMasterKeyID: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetBucketEncryptionResponseServerSideEncryptionRule extends $tea.Model {
  applyServerSideEncryptionByDefault: GetBucketEncryptionResponseServerSideEncryptionRuleApplyServerSideEncryptionByDefault;
  static names(): { [key: string]: string } {
    return {
      applyServerSideEncryptionByDefault: 'ApplyServerSideEncryptionByDefault',
    };
  }

  static types(): { [key: string]: any } {
    return {
      applyServerSideEncryptionByDefault: GetBucketEncryptionResponseServerSideEncryptionRuleApplyServerSideEncryptionByDefault,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetBucketTagsResponseTaggingTagSetTag extends $tea.Model {
  key?: string;
  value?: string;
  static names(): { [key: string]: string } {
    return {
      key: 'Key',
      value: 'Value',
    };
  }

  static types(): { [key: string]: any } {
    return {
      key: 'string',
      value: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetBucketTagsResponseTaggingTagSet extends $tea.Model {
  tag?: GetBucketTagsResponseTaggingTagSetTag[];
  static names(): { [key: string]: string } {
    return {
      tag: 'Tag',
    };
  }

  static types(): { [key: string]: any } {
    return {
      tag: { 'type': 'array', 'itemType': GetBucketTagsResponseTaggingTagSetTag },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetBucketTagsResponseTagging extends $tea.Model {
  tagSet: GetBucketTagsResponseTaggingTagSet;
  static names(): { [key: string]: string } {
    return {
      tagSet: 'TagSet',
    };
  }

  static types(): { [key: string]: any } {
    return {
      tagSet: GetBucketTagsResponseTaggingTagSet,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetServiceRequestFilter extends $tea.Model {
  prefix?: string;
  marker?: string;
  maxKeys?: string;
  static names(): { [key: string]: string } {
    return {
      prefix: 'prefix',
      marker: 'marker',
      maxKeys: 'max-keys',
    };
  }

  static types(): { [key: string]: any } {
    return {
      prefix: 'string',
      marker: 'string',
      maxKeys: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetServiceResponseListAllMyBucketsResultOwner extends $tea.Model {
  iD?: string;
  displayName?: string;
  static names(): { [key: string]: string } {
    return {
      iD: 'ID',
      displayName: 'DisplayName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      iD: 'string',
      displayName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetServiceResponseListAllMyBucketsResultBucketsBucket extends $tea.Model {
  name?: string;
  createDate?: string;
  location?: string;
  extranetEndpoint?: string;
  intranetEndpoint?: string;
  storageClass?: string;
  static names(): { [key: string]: string } {
    return {
      name: 'Name',
      createDate: 'CreateDate',
      location: 'Location',
      extranetEndpoint: 'ExtranetEndpoint',
      intranetEndpoint: 'IntranetEndpoint',
      storageClass: 'StorageClass',
    };
  }

  static types(): { [key: string]: any } {
    return {
      name: 'string',
      createDate: 'string',
      location: 'string',
      extranetEndpoint: 'string',
      intranetEndpoint: 'string',
      storageClass: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetServiceResponseListAllMyBucketsResultBuckets extends $tea.Model {
  bucket?: GetServiceResponseListAllMyBucketsResultBucketsBucket[];
  static names(): { [key: string]: string } {
    return {
      bucket: 'Bucket',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bucket: { 'type': 'array', 'itemType': GetServiceResponseListAllMyBucketsResultBucketsBucket },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetServiceResponseListAllMyBucketsResult extends $tea.Model {
  prefix?: string;
  marker?: string;
  maxKeys?: string;
  isTruncated?: string;
  nextMarker?: string;
  owner: GetServiceResponseListAllMyBucketsResultOwner;
  buckets: GetServiceResponseListAllMyBucketsResultBuckets;
  static names(): { [key: string]: string } {
    return {
      prefix: 'Prefix',
      marker: 'Marker',
      maxKeys: 'MaxKeys',
      isTruncated: 'IsTruncated',
      nextMarker: 'NextMarker',
      owner: 'Owner',
      buckets: 'Buckets',
    };
  }

  static types(): { [key: string]: any } {
    return {
      prefix: 'string',
      marker: 'string',
      maxKeys: 'string',
      isTruncated: 'string',
      nextMarker: 'string',
      owner: GetServiceResponseListAllMyBucketsResultOwner,
      buckets: GetServiceResponseListAllMyBucketsResultBuckets,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteBucketTagsRequestFilter extends $tea.Model {
  tagging: string;
  static names(): { [key: string]: string } {
    return {
      tagging: 'tagging',
    };
  }

  static types(): { [key: string]: any } {
    return {
      tagging: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetBucketWebsiteResponseWebsiteConfigurationIndexDocument extends $tea.Model {
  suffix?: string;
  static names(): { [key: string]: string } {
    return {
      suffix: 'Suffix',
    };
  }

  static types(): { [key: string]: any } {
    return {
      suffix: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetBucketWebsiteResponseWebsiteConfigurationErrorDocument extends $tea.Model {
  key?: string;
  static names(): { [key: string]: string } {
    return {
      key: 'Key',
    };
  }

  static types(): { [key: string]: any } {
    return {
      key: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleConditionIncludeHeader extends $tea.Model {
  key?: string;
  equals?: string;
  static names(): { [key: string]: string } {
    return {
      key: 'Key',
      equals: 'Equals',
    };
  }

  static types(): { [key: string]: any } {
    return {
      key: 'string',
      equals: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleCondition extends $tea.Model {
  keyPrefixEquals?: string;
  httpErrorCodeReturnedEquals?: string;
  includeHeader: GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleConditionIncludeHeader;
  static names(): { [key: string]: string } {
    return {
      keyPrefixEquals: 'KeyPrefixEquals',
      httpErrorCodeReturnedEquals: 'HttpErrorCodeReturnedEquals',
      includeHeader: 'IncludeHeader',
    };
  }

  static types(): { [key: string]: any } {
    return {
      keyPrefixEquals: 'string',
      httpErrorCodeReturnedEquals: 'string',
      includeHeader: GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleConditionIncludeHeader,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeadersSet extends $tea.Model {
  key?: string;
  value?: string;
  static names(): { [key: string]: string } {
    return {
      key: 'Key',
      value: 'Value',
    };
  }

  static types(): { [key: string]: any } {
    return {
      key: 'string',
      value: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeaders extends $tea.Model {
  passAll?: boolean;
  pass?: string;
  remove?: string;
  set: GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeadersSet;
  static names(): { [key: string]: string } {
    return {
      passAll: 'PassAll',
      pass: 'Pass',
      remove: 'Remove',
      set: 'Set',
    };
  }

  static types(): { [key: string]: any } {
    return {
      passAll: 'boolean',
      pass: 'string',
      remove: 'string',
      set: GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeadersSet,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirect extends $tea.Model {
  redirectType?: string;
  passQueryString?: boolean;
  mirrorURL?: string;
  mirrorPassQueryString?: boolean;
  mirrorFollowRedirect?: boolean;
  mirrorCheckMd5?: boolean;
  protocol?: string;
  hostName?: string;
  httpRedirectCode?: string;
  replaceKeyPrefixWith?: string;
  replaceKeyWith?: string;
  mirrorHeaders: GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeaders;
  static names(): { [key: string]: string } {
    return {
      redirectType: 'RedirectType',
      passQueryString: 'PassQueryString',
      mirrorURL: 'MirrorURL',
      mirrorPassQueryString: 'MirrorPassQueryString',
      mirrorFollowRedirect: 'MirrorFollowRedirect',
      mirrorCheckMd5: 'MirrorCheckMd5',
      protocol: 'Protocol',
      hostName: 'HostName',
      httpRedirectCode: 'HttpRedirectCode',
      replaceKeyPrefixWith: 'ReplaceKeyPrefixWith',
      replaceKeyWith: 'ReplaceKeyWith',
      mirrorHeaders: 'MirrorHeaders',
    };
  }

  static types(): { [key: string]: any } {
    return {
      redirectType: 'string',
      passQueryString: 'boolean',
      mirrorURL: 'string',
      mirrorPassQueryString: 'boolean',
      mirrorFollowRedirect: 'boolean',
      mirrorCheckMd5: 'boolean',
      protocol: 'string',
      hostName: 'string',
      httpRedirectCode: 'string',
      replaceKeyPrefixWith: 'string',
      replaceKeyWith: 'string',
      mirrorHeaders: GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeaders,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRule extends $tea.Model {
  ruleNumber?: number;
  condition: GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleCondition;
  redirect: GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirect;
  static names(): { [key: string]: string } {
    return {
      ruleNumber: 'RuleNumber',
      condition: 'Condition',
      redirect: 'Redirect',
    };
  }

  static types(): { [key: string]: any } {
    return {
      ruleNumber: 'number',
      condition: GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleCondition,
      redirect: GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirect,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetBucketWebsiteResponseWebsiteConfigurationRoutingRules extends $tea.Model {
  routingRule?: GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRule[];
  static names(): { [key: string]: string } {
    return {
      routingRule: 'RoutingRule',
    };
  }

  static types(): { [key: string]: any } {
    return {
      routingRule: { 'type': 'array', 'itemType': GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRule },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetBucketWebsiteResponseWebsiteConfiguration extends $tea.Model {
  indexDocument: GetBucketWebsiteResponseWebsiteConfigurationIndexDocument;
  errorDocument: GetBucketWebsiteResponseWebsiteConfigurationErrorDocument;
  routingRules: GetBucketWebsiteResponseWebsiteConfigurationRoutingRules;
  static names(): { [key: string]: string } {
    return {
      indexDocument: 'IndexDocument',
      errorDocument: 'ErrorDocument',
      routingRules: 'RoutingRules',
    };
  }

  static types(): { [key: string]: any } {
    return {
      indexDocument: GetBucketWebsiteResponseWebsiteConfigurationIndexDocument,
      errorDocument: GetBucketWebsiteResponseWebsiteConfigurationErrorDocument,
      routingRules: GetBucketWebsiteResponseWebsiteConfigurationRoutingRules,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListLiveChannelRequestFilter extends $tea.Model {
  marker?: string;
  maxKeys?: string;
  prefix?: string;
  static names(): { [key: string]: string } {
    return {
      marker: 'marker',
      maxKeys: 'max-keys',
      prefix: 'prefix',
    };
  }

  static types(): { [key: string]: any } {
    return {
      marker: 'string',
      maxKeys: 'string',
      prefix: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListLiveChannelResponseListLiveChannelResultLiveChannelPublishUrls extends $tea.Model {
  url?: string;
  static names(): { [key: string]: string } {
    return {
      url: 'Url',
    };
  }

  static types(): { [key: string]: any } {
    return {
      url: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListLiveChannelResponseListLiveChannelResultLiveChannelPlayUrls extends $tea.Model {
  url?: string;
  static names(): { [key: string]: string } {
    return {
      url: 'Url',
    };
  }

  static types(): { [key: string]: any } {
    return {
      url: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListLiveChannelResponseListLiveChannelResultLiveChannel extends $tea.Model {
  name?: string;
  description?: string;
  status?: string;
  lastModified?: string;
  publishUrls: ListLiveChannelResponseListLiveChannelResultLiveChannelPublishUrls;
  playUrls: ListLiveChannelResponseListLiveChannelResultLiveChannelPlayUrls;
  static names(): { [key: string]: string } {
    return {
      name: 'Name',
      description: 'Description',
      status: 'Status',
      lastModified: 'LastModified',
      publishUrls: 'PublishUrls',
      playUrls: 'PlayUrls',
    };
  }

  static types(): { [key: string]: any } {
    return {
      name: 'string',
      description: 'string',
      status: 'string',
      lastModified: 'string',
      publishUrls: ListLiveChannelResponseListLiveChannelResultLiveChannelPublishUrls,
      playUrls: ListLiveChannelResponseListLiveChannelResultLiveChannelPlayUrls,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListLiveChannelResponseListLiveChannelResult extends $tea.Model {
  prefix?: string;
  marker?: string;
  maxKeys?: string;
  isTruncated?: string;
  nextMarker?: string;
  liveChannel: ListLiveChannelResponseListLiveChannelResultLiveChannel;
  static names(): { [key: string]: string } {
    return {
      prefix: 'Prefix',
      marker: 'Marker',
      maxKeys: 'MaxKeys',
      isTruncated: 'IsTruncated',
      nextMarker: 'NextMarker',
      liveChannel: 'LiveChannel',
    };
  }

  static types(): { [key: string]: any } {
    return {
      prefix: 'string',
      marker: 'string',
      maxKeys: 'string',
      isTruncated: 'string',
      nextMarker: 'string',
      liveChannel: ListLiveChannelResponseListLiveChannelResultLiveChannel,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetBucketAclResponseAccessControlPolicyOwner extends $tea.Model {
  iD?: string;
  displayName?: string;
  static names(): { [key: string]: string } {
    return {
      iD: 'ID',
      displayName: 'DisplayName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      iD: 'string',
      displayName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetBucketAclResponseAccessControlPolicyAccessControlList extends $tea.Model {
  grant?: string;
  static names(): { [key: string]: string } {
    return {
      grant: 'Grant',
    };
  }

  static types(): { [key: string]: any } {
    return {
      grant: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetBucketAclResponseAccessControlPolicy extends $tea.Model {
  owner: GetBucketAclResponseAccessControlPolicyOwner;
  accessControlList: GetBucketAclResponseAccessControlPolicyAccessControlList;
  static names(): { [key: string]: string } {
    return {
      owner: 'Owner',
      accessControlList: 'AccessControlList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      owner: GetBucketAclResponseAccessControlPolicyOwner,
      accessControlList: GetBucketAclResponseAccessControlPolicyAccessControlList,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListPartsRequestFilter extends $tea.Model {
  uploadId: string;
  maxParts?: number;
  partNumberMarker?: number;
  encodingType?: string;
  static names(): { [key: string]: string } {
    return {
      uploadId: 'uploadId',
      maxParts: 'max-parts',
      partNumberMarker: 'part-number-marker',
      encodingType: 'Encoding-type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      uploadId: 'string',
      maxParts: 'number',
      partNumberMarker: 'number',
      encodingType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListPartsResponseListPartsResultPart extends $tea.Model {
  partNumber?: string;
  lastModified?: string;
  eTag?: string;
  size?: string;
  static names(): { [key: string]: string } {
    return {
      partNumber: 'PartNumber',
      lastModified: 'LastModified',
      eTag: 'ETag',
      size: 'Size',
    };
  }

  static types(): { [key: string]: any } {
    return {
      partNumber: 'string',
      lastModified: 'string',
      eTag: 'string',
      size: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListPartsResponseListPartsResult extends $tea.Model {
  bucket?: string;
  encodingType?: string;
  key?: string;
  uploadId?: string;
  partNumberMarker?: string;
  nextPartNumberMarker?: string;
  maxParts?: string;
  isTruncated?: string;
  part?: ListPartsResponseListPartsResultPart[];
  static names(): { [key: string]: string } {
    return {
      bucket: 'Bucket',
      encodingType: 'EncodingType',
      key: 'Key',
      uploadId: 'UploadId',
      partNumberMarker: 'PartNumberMarker',
      nextPartNumberMarker: 'NextPartNumberMarker',
      maxParts: 'MaxParts',
      isTruncated: 'IsTruncated',
      part: 'Part',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bucket: 'string',
      encodingType: 'string',
      key: 'string',
      uploadId: 'string',
      partNumberMarker: 'string',
      nextPartNumberMarker: 'string',
      maxParts: 'string',
      isTruncated: 'string',
      part: { 'type': 'array', 'itemType': ListPartsResponseListPartsResultPart },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetLiveChannelHistoryRequestFilter extends $tea.Model {
  comp?: string;
  static names(): { [key: string]: string } {
    return {
      comp: 'comp',
    };
  }

  static types(): { [key: string]: any } {
    return {
      comp: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetLiveChannelHistoryResponseLiveChannelHistoryLiveRecord extends $tea.Model {
  startTime?: string;
  endTime?: string;
  remoteAddr?: string;
  static names(): { [key: string]: string } {
    return {
      startTime: 'StartTime',
      endTime: 'EndTime',
      remoteAddr: 'RemoteAddr',
    };
  }

  static types(): { [key: string]: any } {
    return {
      startTime: 'string',
      endTime: 'string',
      remoteAddr: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetLiveChannelHistoryResponseLiveChannelHistory extends $tea.Model {
  liveRecord?: GetLiveChannelHistoryResponseLiveChannelHistoryLiveRecord[];
  static names(): { [key: string]: string } {
    return {
      liveRecord: 'LiveRecord',
    };
  }

  static types(): { [key: string]: any } {
    return {
      liveRecord: { 'type': 'array', 'itemType': GetLiveChannelHistoryResponseLiveChannelHistoryLiveRecord },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetBucketRequestFilter extends $tea.Model {
  delimiter?: string;
  marker?: string;
  maxKeys?: string;
  prefix?: string;
  encodingType?: string;
  static names(): { [key: string]: string } {
    return {
      delimiter: 'delimiter',
      marker: 'marker',
      maxKeys: 'max-keys',
      prefix: 'prefix',
      encodingType: 'encoding-type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      delimiter: 'string',
      marker: 'string',
      maxKeys: 'string',
      prefix: 'string',
      encodingType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetBucketResponseListBucketResultContentsOwner extends $tea.Model {
  iD?: string;
  displayName?: string;
  static names(): { [key: string]: string } {
    return {
      iD: 'ID',
      displayName: 'DisplayName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      iD: 'string',
      displayName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetBucketResponseListBucketResultContents extends $tea.Model {
  key?: string;
  eTag?: string;
  lastModified?: string;
  size?: string;
  storageClass?: string;
  owner: GetBucketResponseListBucketResultContentsOwner;
  static names(): { [key: string]: string } {
    return {
      key: 'Key',
      eTag: 'ETag',
      lastModified: 'LastModified',
      size: 'Size',
      storageClass: 'StorageClass',
      owner: 'Owner',
    };
  }

  static types(): { [key: string]: any } {
    return {
      key: 'string',
      eTag: 'string',
      lastModified: 'string',
      size: 'string',
      storageClass: 'string',
      owner: GetBucketResponseListBucketResultContentsOwner,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetBucketResponseListBucketResult extends $tea.Model {
  name?: string;
  prefix?: string;
  marker?: string;
  maxKeys?: string;
  delimiter?: string;
  isTruncated?: string;
  encodingType?: string;
  commonPrefixes?: string;
  contents?: GetBucketResponseListBucketResultContents[];
  static names(): { [key: string]: string } {
    return {
      name: 'Name',
      prefix: 'Prefix',
      marker: 'Marker',
      maxKeys: 'MaxKeys',
      delimiter: 'Delimiter',
      isTruncated: 'IsTruncated',
      encodingType: 'EncodingType',
      commonPrefixes: 'CommonPrefixes',
      contents: 'Contents',
    };
  }

  static types(): { [key: string]: any } {
    return {
      name: 'string',
      prefix: 'string',
      marker: 'string',
      maxKeys: 'string',
      delimiter: 'string',
      isTruncated: 'string',
      encodingType: 'string',
      commonPrefixes: 'string',
      contents: { 'type': 'array', 'itemType': GetBucketResponseListBucketResultContents },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetLiveChannelInfoResponseLiveChannelConfigurationTarget extends $tea.Model {
  type?: string;
  fragDuration?: string;
  fragCount?: string;
  playlistName?: string;
  static names(): { [key: string]: string } {
    return {
      type: 'Type',
      fragDuration: 'FragDuration',
      fragCount: 'FragCount',
      playlistName: 'PlaylistName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      type: 'string',
      fragDuration: 'string',
      fragCount: 'string',
      playlistName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetLiveChannelInfoResponseLiveChannelConfiguration extends $tea.Model {
  description?: string;
  status?: string;
  target: GetLiveChannelInfoResponseLiveChannelConfigurationTarget;
  static names(): { [key: string]: string } {
    return {
      description: 'Description',
      status: 'Status',
      target: 'Target',
    };
  }

  static types(): { [key: string]: any } {
    return {
      description: 'string',
      status: 'string',
      target: GetLiveChannelInfoResponseLiveChannelConfigurationTarget,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetLiveChannelStatRequestFilter extends $tea.Model {
  comp?: string;
  static names(): { [key: string]: string } {
    return {
      comp: 'comp',
    };
  }

  static types(): { [key: string]: any } {
    return {
      comp: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetLiveChannelStatResponseLiveChannelStatVideo extends $tea.Model {
  width?: string;
  height?: string;
  frameRate?: string;
  bandwidth?: string;
  codec?: string;
  static names(): { [key: string]: string } {
    return {
      width: 'Width',
      height: 'Height',
      frameRate: 'FrameRate',
      bandwidth: 'Bandwidth',
      codec: 'Codec',
    };
  }

  static types(): { [key: string]: any } {
    return {
      width: 'string',
      height: 'string',
      frameRate: 'string',
      bandwidth: 'string',
      codec: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetLiveChannelStatResponseLiveChannelStatAudio extends $tea.Model {
  bandwidth?: string;
  sampleRate?: string;
  codec?: string;
  static names(): { [key: string]: string } {
    return {
      bandwidth: 'Bandwidth',
      sampleRate: 'SampleRate',
      codec: 'Codec',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bandwidth: 'string',
      sampleRate: 'string',
      codec: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetLiveChannelStatResponseLiveChannelStat extends $tea.Model {
  status?: string;
  connectedTime?: string;
  remoteAddr?: string;
  video: GetLiveChannelStatResponseLiveChannelStatVideo;
  audio: GetLiveChannelStatResponseLiveChannelStatAudio;
  static names(): { [key: string]: string } {
    return {
      status: 'Status',
      connectedTime: 'ConnectedTime',
      remoteAddr: 'RemoteAddr',
      video: 'Video',
      audio: 'Audio',
    };
  }

  static types(): { [key: string]: any } {
    return {
      status: 'string',
      connectedTime: 'string',
      remoteAddr: 'string',
      video: GetLiveChannelStatResponseLiveChannelStatVideo,
      audio: GetLiveChannelStatResponseLiveChannelStatAudio,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AbortMultipartUploadRequestFilter extends $tea.Model {
  uploadId: string;
  static names(): { [key: string]: string } {
    return {
      uploadId: 'uploadId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      uploadId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AppendObjectRequestFilter extends $tea.Model {
  position: string;
  static names(): { [key: string]: string } {
    return {
      position: 'position',
    };
  }

  static types(): { [key: string]: any } {
    return {
      position: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AppendObjectRequestHeader extends $tea.Model {
  cacheControl?: string;
  contentDisposition?: string;
  contentEncoding?: string;
  contentMD5?: string;
  expires?: string;
  serverSideEncryption?: string;
  objectAcl?: string;
  storageClass?: string;
  contentType?: string;
  static names(): { [key: string]: string } {
    return {
      cacheControl: 'Cache-Control',
      contentDisposition: 'Content-Disposition',
      contentEncoding: 'Content-Encoding',
      contentMD5: 'Content-MD5',
      expires: 'Expires',
      serverSideEncryption: 'x-oss-server-side-encryption',
      objectAcl: 'x-oss-object-acl',
      storageClass: 'x-oss-storage-class',
      contentType: 'content-type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      cacheControl: 'string',
      contentDisposition: 'string',
      contentEncoding: 'string',
      contentMD5: 'string',
      expires: 'string',
      serverSideEncryption: 'string',
      objectAcl: 'string',
      storageClass: 'string',
      contentType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UploadPartCopyRequestFilter extends $tea.Model {
  partNumber: string;
  uploadId: string;
  static names(): { [key: string]: string } {
    return {
      partNumber: 'partNumber',
      uploadId: 'uploadId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      partNumber: 'string',
      uploadId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UploadPartCopyRequestHeader extends $tea.Model {
  copySource: string;
  copySourceRange: string;
  copySourceIfMatch?: string;
  copySourceIfNoneMatch?: string;
  copySourceIfUnmodifiedSince?: string;
  copySourceIfModifiedSince?: string;
  static names(): { [key: string]: string } {
    return {
      copySource: 'x-oss-copy-source',
      copySourceRange: 'x-oss-copy-source-range',
      copySourceIfMatch: 'x-oss-copy-source-if-match',
      copySourceIfNoneMatch: 'x-oss-copy-source-if-none-match',
      copySourceIfUnmodifiedSince: 'x-oss-copy-source-if-unmodified-since',
      copySourceIfModifiedSince: 'x-oss-copy-source-if-modified-since',
    };
  }

  static types(): { [key: string]: any } {
    return {
      copySource: 'string',
      copySourceRange: 'string',
      copySourceIfMatch: 'string',
      copySourceIfNoneMatch: 'string',
      copySourceIfUnmodifiedSince: 'string',
      copySourceIfModifiedSince: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UploadPartCopyResponseCopyPartResult extends $tea.Model {
  lastModified?: string;
  eTag?: string;
  static names(): { [key: string]: string } {
    return {
      lastModified: 'LastModified',
      eTag: 'ETag',
    };
  }

  static types(): { [key: string]: any } {
    return {
      lastModified: 'string',
      eTag: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetVodPlaylistRequestFilter extends $tea.Model {
  endTime: string;
  startTime: string;
  static names(): { [key: string]: string } {
    return {
      endTime: 'endTime',
      startTime: 'startTime',
    };
  }

  static types(): { [key: string]: any } {
    return {
      endTime: 'string',
      startTime: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetObjectRequestHeader extends $tea.Model {
  responseContentType?: string;
  responseContentLanguage?: string;
  responseExpires?: string;
  responseCacheControl?: string;
  responseContentDisposition?: string;
  responseContentEncoding?: string;
  range?: string;
  ifModifiedSince?: string;
  ifUnmodifiedSince?: string;
  ifMatch?: string;
  ifNoneMatch?: string;
  acceptEncoding?: string;
  static names(): { [key: string]: string } {
    return {
      responseContentType: 'response-content-type',
      responseContentLanguage: 'response-content-language',
      responseExpires: 'response-expires',
      responseCacheControl: 'response-cache-control',
      responseContentDisposition: 'response-content-disposition',
      responseContentEncoding: 'response-content-encoding',
      range: 'Range',
      ifModifiedSince: 'If-Modified-Since',
      ifUnmodifiedSince: 'If-Unmodified-Since',
      ifMatch: 'If-Match',
      ifNoneMatch: 'If-None-Match',
      acceptEncoding: 'Accept-Encoding',
    };
  }

  static types(): { [key: string]: any } {
    return {
      responseContentType: 'string',
      responseContentLanguage: 'string',
      responseExpires: 'string',
      responseCacheControl: 'string',
      responseContentDisposition: 'string',
      responseContentEncoding: 'string',
      range: 'string',
      ifModifiedSince: 'string',
      ifUnmodifiedSince: 'string',
      ifMatch: 'string',
      ifNoneMatch: 'string',
      acceptEncoding: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UploadPartRequestFilter extends $tea.Model {
  partNumber: string;
  uploadId: string;
  static names(): { [key: string]: string } {
    return {
      partNumber: 'partNumber',
      uploadId: 'uploadId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      partNumber: 'string',
      uploadId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetBucketCORSResponseCORSConfigurationCORSRule extends $tea.Model {
  maxAgeSeconds?: string;
  static names(): { [key: string]: string } {
    return {
      maxAgeSeconds: 'MaxAgeSeconds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      maxAgeSeconds: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetBucketCORSResponseCORSConfiguration extends $tea.Model {
  cORSRule?: GetBucketCORSResponseCORSConfigurationCORSRule[];
  static names(): { [key: string]: string } {
    return {
      cORSRule: 'CORSRule',
    };
  }

  static types(): { [key: string]: any } {
    return {
      cORSRule: { 'type': 'array', 'itemType': GetBucketCORSResponseCORSConfigurationCORSRule },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CopyObjectRequestHeader extends $tea.Model {
  copySource: string;
  copySourceIfMatch?: string;
  copySourceIfNoneMatch?: string;
  copySourceIfUnmodifiedSince?: string;
  copySourceIfModifiedSince?: string;
  metadataDirective?: string;
  serverSideEncryption?: string;
  serverSideEncryptionKeyId?: string;
  objectAcl?: string;
  storageClass?: string;
  tagging?: string;
  taggingDirective?: string;
  static names(): { [key: string]: string } {
    return {
      copySource: 'x-oss-copy-source',
      copySourceIfMatch: 'x-oss-copy-source-if-match',
      copySourceIfNoneMatch: 'x-oss-copy-source-if-none-match',
      copySourceIfUnmodifiedSince: 'x-oss-copy-source-if-unmodified-since',
      copySourceIfModifiedSince: 'x-oss-copy-source-if-modified-since',
      metadataDirective: 'x-oss-metadata-directive',
      serverSideEncryption: 'x-oss-server-side-encryption',
      serverSideEncryptionKeyId: 'x-oss-server-side-encryption-key-id',
      objectAcl: 'x-oss-object-acl',
      storageClass: 'x-oss-storage-class',
      tagging: 'x-oss-tagging',
      taggingDirective: 'x-oss-tagging-directive',
    };
  }

  static types(): { [key: string]: any } {
    return {
      copySource: 'string',
      copySourceIfMatch: 'string',
      copySourceIfNoneMatch: 'string',
      copySourceIfUnmodifiedSince: 'string',
      copySourceIfModifiedSince: 'string',
      metadataDirective: 'string',
      serverSideEncryption: 'string',
      serverSideEncryptionKeyId: 'string',
      objectAcl: 'string',
      storageClass: 'string',
      tagging: 'string',
      taggingDirective: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CopyObjectResponseCopyObjectResult extends $tea.Model {
  lastModified?: string;
  eTag?: string;
  static names(): { [key: string]: string } {
    return {
      lastModified: 'LastModified',
      eTag: 'ETag',
    };
  }

  static types(): { [key: string]: any } {
    return {
      lastModified: 'string',
      eTag: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetObjectTaggingResponseTaggingTagSetTag extends $tea.Model {
  key?: string;
  value?: string;
  static names(): { [key: string]: string } {
    return {
      key: 'Key',
      value: 'Value',
    };
  }

  static types(): { [key: string]: any } {
    return {
      key: 'string',
      value: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetObjectTaggingResponseTaggingTagSet extends $tea.Model {
  tag?: GetObjectTaggingResponseTaggingTagSetTag[];
  static names(): { [key: string]: string } {
    return {
      tag: 'Tag',
    };
  }

  static types(): { [key: string]: any } {
    return {
      tag: { 'type': 'array', 'itemType': GetObjectTaggingResponseTaggingTagSetTag },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetObjectTaggingResponseTagging extends $tea.Model {
  tagSet: GetObjectTaggingResponseTaggingTagSet;
  static names(): { [key: string]: string } {
    return {
      tagSet: 'TagSet',
    };
  }

  static types(): { [key: string]: any } {
    return {
      tagSet: GetObjectTaggingResponseTaggingTagSet,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetBucketLifecycleResponseLifecycleConfigurationRuleExpiration extends $tea.Model {
  days?: number;
  createdBeforeDate?: string;
  static names(): { [key: string]: string } {
    return {
      days: 'Days',
      createdBeforeDate: 'CreatedBeforeDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      days: 'number',
      createdBeforeDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetBucketLifecycleResponseLifecycleConfigurationRuleTransition extends $tea.Model {
  days?: number;
  storageClass?: string;
  static names(): { [key: string]: string } {
    return {
      days: 'Days',
      storageClass: 'StorageClass',
    };
  }

  static types(): { [key: string]: any } {
    return {
      days: 'number',
      storageClass: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetBucketLifecycleResponseLifecycleConfigurationRuleAbortMultipartUpload extends $tea.Model {
  days?: number;
  createdBeforeDate?: string;
  static names(): { [key: string]: string } {
    return {
      days: 'Days',
      createdBeforeDate: 'CreatedBeforeDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      days: 'number',
      createdBeforeDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetBucketLifecycleResponseLifecycleConfigurationRuleTag extends $tea.Model {
  key?: string;
  value?: string;
  static names(): { [key: string]: string } {
    return {
      key: 'Key',
      value: 'Value',
    };
  }

  static types(): { [key: string]: any } {
    return {
      key: 'string',
      value: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetBucketLifecycleResponseLifecycleConfigurationRule extends $tea.Model {
  iD?: string;
  prefix?: string;
  status?: string;
  expiration: GetBucketLifecycleResponseLifecycleConfigurationRuleExpiration;
  transition: GetBucketLifecycleResponseLifecycleConfigurationRuleTransition;
  abortMultipartUpload: GetBucketLifecycleResponseLifecycleConfigurationRuleAbortMultipartUpload;
  tag: GetBucketLifecycleResponseLifecycleConfigurationRuleTag;
  static names(): { [key: string]: string } {
    return {
      iD: 'ID',
      prefix: 'Prefix',
      status: 'Status',
      expiration: 'Expiration',
      transition: 'Transition',
      abortMultipartUpload: 'AbortMultipartUpload',
      tag: 'Tag',
    };
  }

  static types(): { [key: string]: any } {
    return {
      iD: 'string',
      prefix: 'string',
      status: 'string',
      expiration: GetBucketLifecycleResponseLifecycleConfigurationRuleExpiration,
      transition: GetBucketLifecycleResponseLifecycleConfigurationRuleTransition,
      abortMultipartUpload: GetBucketLifecycleResponseLifecycleConfigurationRuleAbortMultipartUpload,
      tag: GetBucketLifecycleResponseLifecycleConfigurationRuleTag,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetBucketLifecycleResponseLifecycleConfiguration extends $tea.Model {
  rule?: GetBucketLifecycleResponseLifecycleConfigurationRule[];
  static names(): { [key: string]: string } {
    return {
      rule: 'Rule',
    };
  }

  static types(): { [key: string]: any } {
    return {
      rule: { 'type': 'array', 'itemType': GetBucketLifecycleResponseLifecycleConfigurationRule },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PutSymlinkRequestHeader extends $tea.Model {
  symlinkTarget: string;
  storageClass?: string;
  static names(): { [key: string]: string } {
    return {
      symlinkTarget: 'x-oss-symlink-target',
      storageClass: 'x-oss-storage-class',
    };
  }

  static types(): { [key: string]: any } {
    return {
      symlinkTarget: 'string',
      storageClass: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetBucketRefererResponseRefererConfigurationRefererList extends $tea.Model {
  referer?: string[];
  static names(): { [key: string]: string } {
    return {
      referer: 'Referer',
    };
  }

  static types(): { [key: string]: any } {
    return {
      referer: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetBucketRefererResponseRefererConfiguration extends $tea.Model {
  allowEmptyReferer?: boolean;
  refererList: GetBucketRefererResponseRefererConfigurationRefererList;
  static names(): { [key: string]: string } {
    return {
      allowEmptyReferer: 'AllowEmptyReferer',
      refererList: 'RefererList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      allowEmptyReferer: 'boolean',
      refererList: GetBucketRefererResponseRefererConfigurationRefererList,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetBucketLoggingResponseBucketLoggingStatusLoggingEnabled extends $tea.Model {
  targetBucket?: string;
  targetPrefix?: string;
  static names(): { [key: string]: string } {
    return {
      targetBucket: 'TargetBucket',
      targetPrefix: 'TargetPrefix',
    };
  }

  static types(): { [key: string]: any } {
    return {
      targetBucket: 'string',
      targetPrefix: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetBucketLoggingResponseBucketLoggingStatus extends $tea.Model {
  loggingEnabled: GetBucketLoggingResponseBucketLoggingStatusLoggingEnabled;
  static names(): { [key: string]: string } {
    return {
      loggingEnabled: 'LoggingEnabled',
    };
  }

  static types(): { [key: string]: any } {
    return {
      loggingEnabled: GetBucketLoggingResponseBucketLoggingStatusLoggingEnabled,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PutObjectAclRequestHeader extends $tea.Model {
  objectAcl: string;
  static names(): { [key: string]: string } {
    return {
      objectAcl: 'x-oss-object-acl',
    };
  }

  static types(): { [key: string]: any } {
    return {
      objectAcl: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetBucketInfoResponseBucketInfoBucketOwner extends $tea.Model {
  iD?: string;
  displayName?: string;
  static names(): { [key: string]: string } {
    return {
      iD: 'ID',
      displayName: 'DisplayName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      iD: 'string',
      displayName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetBucketInfoResponseBucketInfoBucketAccessControlList extends $tea.Model {
  grant?: string;
  static names(): { [key: string]: string } {
    return {
      grant: 'Grant',
    };
  }

  static types(): { [key: string]: any } {
    return {
      grant: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetBucketInfoResponseBucketInfoBucket extends $tea.Model {
  creationDate?: string;
  extranetEndpoint?: string;
  intranetEndpoint?: string;
  location?: string;
  name?: string;
  dataRedundancyType?: string;
  storageClass?: string;
  comment?: string;
  owner: GetBucketInfoResponseBucketInfoBucketOwner;
  accessControlList: GetBucketInfoResponseBucketInfoBucketAccessControlList;
  static names(): { [key: string]: string } {
    return {
      creationDate: 'CreationDate',
      extranetEndpoint: 'ExtranetEndpoint',
      intranetEndpoint: 'IntranetEndpoint',
      location: 'Location',
      name: 'Name',
      dataRedundancyType: 'DataRedundancyType',
      storageClass: 'StorageClass',
      comment: 'Comment',
      owner: 'Owner',
      accessControlList: 'AccessControlList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      creationDate: 'string',
      extranetEndpoint: 'string',
      intranetEndpoint: 'string',
      location: 'string',
      name: 'string',
      dataRedundancyType: 'string',
      storageClass: 'string',
      comment: 'string',
      owner: GetBucketInfoResponseBucketInfoBucketOwner,
      accessControlList: GetBucketInfoResponseBucketInfoBucketAccessControlList,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetBucketInfoResponseBucketInfo extends $tea.Model {
  bucket: GetBucketInfoResponseBucketInfoBucket;
  static names(): { [key: string]: string } {
    return {
      bucket: 'Bucket',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bucket: GetBucketInfoResponseBucketInfoBucket,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PutLiveChannelStatusRequestFilter extends $tea.Model {
  status: string;
  static names(): { [key: string]: string } {
    return {
      status: 'status',
    };
  }

  static types(): { [key: string]: any } {
    return {
      status: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InitiateMultipartUploadRequestFilter extends $tea.Model {
  encodingType?: string;
  static names(): { [key: string]: string } {
    return {
      encodingType: 'encoding-type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      encodingType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InitiateMultipartUploadRequestHeader extends $tea.Model {
  cacheControl?: string;
  contentDisposition?: string;
  contentEncoding?: string;
  expires?: string;
  serverSideEncryption?: string;
  serverSideEncryptionKeyId?: string;
  storageClass?: string;
  tagging?: string;
  contentType?: string;
  static names(): { [key: string]: string } {
    return {
      cacheControl: 'Cache-Control',
      contentDisposition: 'Content-Disposition',
      contentEncoding: 'Content-Encoding',
      expires: 'Expires',
      serverSideEncryption: 'x-oss-server-side-encryption',
      serverSideEncryptionKeyId: 'x-oss-server-side-encryption-key-id',
      storageClass: 'x-oss-storage-class',
      tagging: 'x-oss-tagging',
      contentType: 'content-type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      cacheControl: 'string',
      contentDisposition: 'string',
      contentEncoding: 'string',
      expires: 'string',
      serverSideEncryption: 'string',
      serverSideEncryptionKeyId: 'string',
      storageClass: 'string',
      tagging: 'string',
      contentType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InitiateMultipartUploadResponseInitiateMultipartUploadResult extends $tea.Model {
  bucket?: string;
  key?: string;
  uploadId?: string;
  static names(): { [key: string]: string } {
    return {
      bucket: 'Bucket',
      key: 'Key',
      uploadId: 'UploadId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bucket: 'string',
      key: 'string',
      uploadId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class OptionObjectRequestHeader extends $tea.Model {
  origin: string;
  accessControlRequestMethod: string;
  accessControlRequestHeaders: string;
  static names(): { [key: string]: string } {
    return {
      origin: 'Origin',
      accessControlRequestMethod: 'Access-Control-Request-Method',
      accessControlRequestHeaders: 'Access-Control-Request-Headers',
    };
  }

  static types(): { [key: string]: any } {
    return {
      origin: 'string',
      accessControlRequestMethod: 'string',
      accessControlRequestHeaders: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PostVodPlaylistRequestFilter extends $tea.Model {
  endTime: string;
  startTime: string;
  static names(): { [key: string]: string } {
    return {
      endTime: 'endTime',
      startTime: 'startTime',
    };
  }

  static types(): { [key: string]: any } {
    return {
      endTime: 'string',
      startTime: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PostObjectRequestHeader extends $tea.Model {
  accessKeyId: string;
  policy: string;
  signature: string;
  successActionStatus?: string;
  file: $FileForm.FileField;
  key: string;
  userMeta?: { [key: string]: string };
  static names(): { [key: string]: string } {
    return {
      accessKeyId: 'OSSAccessKeyId',
      policy: 'policy',
      signature: 'Signature',
      successActionStatus: 'success_action_status',
      file: 'file',
      key: 'key',
      userMeta: 'UserMeta',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accessKeyId: 'string',
      policy: 'string',
      signature: 'string',
      successActionStatus: 'string',
      file: $FileForm.FileField,
      key: 'string',
      userMeta: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PostObjectResponsePostResponse extends $tea.Model {
  bucket: string;
  eTag: string;
  location: string;
  static names(): { [key: string]: string } {
    return {
      bucket: 'Bucket',
      eTag: 'ETag',
      location: 'Location',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bucket: 'string',
      eTag: 'string',
      location: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HeadObjectRequestHeader extends $tea.Model {
  ifModifiedSince?: string;
  ifUnmodifiedSince?: string;
  ifMatch?: string;
  ifNoneMatch?: string;
  static names(): { [key: string]: string } {
    return {
      ifModifiedSince: 'If-Modified-Since',
      ifUnmodifiedSince: 'If-Unmodified-Since',
      ifMatch: 'If-Match',
      ifNoneMatch: 'If-None-Match',
    };
  }

  static types(): { [key: string]: any } {
    return {
      ifModifiedSince: 'string',
      ifUnmodifiedSince: 'string',
      ifMatch: 'string',
      ifNoneMatch: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetObjectAclResponseAccessControlPolicyOwner extends $tea.Model {
  iD?: string;
  displayName?: string;
  static names(): { [key: string]: string } {
    return {
      iD: 'ID',
      displayName: 'DisplayName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      iD: 'string',
      displayName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetObjectAclResponseAccessControlPolicyAccessControlList extends $tea.Model {
  grant?: string;
  static names(): { [key: string]: string } {
    return {
      grant: 'Grant',
    };
  }

  static types(): { [key: string]: any } {
    return {
      grant: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetObjectAclResponseAccessControlPolicy extends $tea.Model {
  owner: GetObjectAclResponseAccessControlPolicyOwner;
  accessControlList: GetObjectAclResponseAccessControlPolicyAccessControlList;
  static names(): { [key: string]: string } {
    return {
      owner: 'Owner',
      accessControlList: 'AccessControlList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      owner: GetObjectAclResponseAccessControlPolicyOwner,
      accessControlList: GetObjectAclResponseAccessControlPolicyAccessControlList,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PutBucketAclRequestHeader extends $tea.Model {
  acl: string;
  static names(): { [key: string]: string } {
    return {
      acl: 'x-oss-acl',
    };
  }

  static types(): { [key: string]: any } {
    return {
      acl: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PutObjectRequestHeader extends $tea.Model {
  authorization?: string;
  cacheControl?: string;
  contentDisposition?: string;
  contentEncoding?: string;
  contentMD5?: string;
  contentLength?: string;
  eTag?: string;
  expires?: string;
  serverSideEncryption?: string;
  serverSideEncryptionKeyId?: string;
  objectAcl?: string;
  storageClass?: string;
  tagging?: string;
  contentType?: string;
  static names(): { [key: string]: string } {
    return {
      authorization: 'Authorization',
      cacheControl: 'Cache-Control',
      contentDisposition: 'Content-Disposition',
      contentEncoding: 'Content-Encoding',
      contentMD5: 'Content-MD5',
      contentLength: 'Content-Length',
      eTag: 'CETag',
      expires: 'Expires',
      serverSideEncryption: 'x-oss-server-side-encryption',
      serverSideEncryptionKeyId: 'x-oss-server-side-encryption-key-id',
      objectAcl: 'x-oss-object-acl',
      storageClass: 'x-oss-storage-class',
      tagging: 'x-oss-tagging',
      contentType: 'content-type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      authorization: 'string',
      cacheControl: 'string',
      contentDisposition: 'string',
      contentEncoding: 'string',
      contentMD5: 'string',
      contentLength: 'string',
      eTag: 'string',
      expires: 'string',
      serverSideEncryption: 'string',
      serverSideEncryptionKeyId: 'string',
      objectAcl: 'string',
      storageClass: 'string',
      tagging: 'string',
      contentType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}


export default class Client {
  _endpoint: string;
  _regionId: string;
  _hostModel: string;
  _protocol: string;
  _readTimeout: number;
  _connectTimeout: number;
  _signatureVersion: string;
  _addtionalHeaders: string[];
  _localAddr: string;
  _httpProxy: string;
  _httpsProxy: string;
  _noProxy: string;
  _userAgent: string;
  _socks5Proxy: string;
  _isEnableCrc: boolean;
  _isEnableMD5: boolean;
  _socks5NetWork: string;
  _maxIdleConns: number;
  _credential: Credential;

  constructor(config: Config) {
    if (Util.isUnset($tea.toMap(config))) {
      throw $tea.newError({
        name: "ParameterMissing",
        message: "'config' can not be unset",
      });
    }

    if (Util.empty(config.type)) {
      config.type = "access_key";
    }

    let credentialConfig = new $Credential.Config({
      accessKeyId: config.accessKeyId,
      type: config.type,
      accessKeySecret: config.accessKeySecret,
      securityToken: config.securityToken,
    });
    this._credential = new Credential(credentialConfig);
    if (Util.isUnset(config.isEnableMD5)) {
      config.isEnableMD5 = false;
    }

    if (Util.isUnset(config.isEnableCrc)) {
      config.isEnableCrc = false;
    }

    this._endpoint = config.endpoint;
    this._protocol = config.protocol;
    this._regionId = config.regionId;
    this._userAgent = config.userAgent;
    this._readTimeout = config.readTimeout;
    this._connectTimeout = config.connectTimeout;
    this._localAddr = config.localAddr;
    this._httpProxy = config.httpProxy;
    this._httpsProxy = config.httpsProxy;
    this._noProxy = config.noProxy;
    this._socks5Proxy = config.socks5Proxy;
    this._socks5NetWork = config.socks5NetWork;
    this._maxIdleConns = config.maxIdleConns;
    this._signatureVersion = config.signatureVersion;
    this._addtionalHeaders = config.addtionalHeaders;
    this._hostModel = config.hostModel;
    this._isEnableMD5 = config.isEnableMD5;
    this._isEnableCrc = config.isEnableCrc;
  }

  async putBucketLifecycle(request: PutBucketLifecycleRequest, runtime: $OSSUtil.RuntimeOptions): Promise<PutBucketLifecycleResponse> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: Util.defaultNumber(runtime.readTimeout, this._readTimeout),
      connectTimeout: Util.defaultNumber(runtime.connectTimeout, this._connectTimeout),
      localAddr: Util.defaultString(runtime.localAddr, this._localAddr),
      httpProxy: Util.defaultString(runtime.httpProxy, this._httpProxy),
      httpsProxy: Util.defaultString(runtime.httpsProxy, this._httpsProxy),
      noProxy: Util.defaultString(runtime.noProxy, this._noProxy),
      socks5Proxy: Util.defaultString(runtime.socks5Proxy, this._socks5Proxy),
      socks5NetWork: Util.defaultString(runtime.socks5NetWork, this._socks5NetWork),
      maxIdleConns: Util.defaultNumber(runtime.maxIdleConns, this._maxIdleConns),
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: Util.defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: Util.defaultString(runtime.backoffPolicy, "no"),
        period: Util.defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
    }

    let _lastRequest = null;
    let _now = Date.now();
    let _retryTimes = 0;
    while ($tea.allowRetry(_runtime['retry'], _retryTimes, _now)) {
      if (_retryTimes > 0) {
        let _backoffTime = $tea.getBackoffTime(_runtime['backoff'], _retryTimes);
        if (_backoffTime > 0) {
          await $tea.sleep(_backoffTime);
        }
      }

      _retryTimes = _retryTimes + 1;
      try {
        let request_ = new $tea.Request();
        let accessKeyId = await this._credential.getAccessKeyId();
        let accessKeySecret = await this._credential.getAccessKeySecret();
        let token = await this._credential.getSecurityToken();
        let reqBody = XML.toXML($tea.toMap(request.body));
        request_.protocol = this._protocol;
        request_.method = "PUT";
        request_.pathname = `/?lifecycle`;
        request_.headers = {
          host: OSSUtil.getHost(request.bucketName, this._regionId, this._endpoint, this._hostModel),
          date: Util.getDateUTCString(),
          'user-agent': this.getUserAgent(),
        };
        if (!Util.empty(token)) {
          request_.headers["x-oss-security-token"] = token;
        }

        request_.body = new $tea.BytesReadable(reqBody);
        request_.headers["authorization"] = OSSUtil.getSignature(request_, request.bucketName, accessKeyId, accessKeySecret, this._signatureVersion, this._addtionalHeaders);
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap : {[key: string]: any} = null;
        let bodyStr : string = null;
        if (Util.is4xx(response_.statusCode) || Util.is5xx(response_.statusCode)) {
          bodyStr = await Util.readAsString(response_.body);
          respMap = OSSUtil.getErrMessage(bodyStr);
          throw $tea.newError({
            code: respMap["Code"],
            message: respMap["Message"],
            data: {
              httpCode: response_.statusCode,
              requestId: respMap["RequestId"],
              hostId: respMap["HostId"],
            },
          });
        }

        return $tea.cast<PutBucketLifecycleResponse>({
          ...response_.headers,
        }, new PutBucketLifecycleResponse({}));
      } catch (ex) {
        if ($tea.isRetryable(ex)) {
          continue;
        }
        throw ex;
      }
    }

    throw $tea.newUnretryableError(_lastRequest);
  }

  async deleteMultipleObjects(request: DeleteMultipleObjectsRequest, runtime: $OSSUtil.RuntimeOptions): Promise<DeleteMultipleObjectsResponse> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: Util.defaultNumber(runtime.readTimeout, this._readTimeout),
      connectTimeout: Util.defaultNumber(runtime.connectTimeout, this._connectTimeout),
      localAddr: Util.defaultString(runtime.localAddr, this._localAddr),
      httpProxy: Util.defaultString(runtime.httpProxy, this._httpProxy),
      httpsProxy: Util.defaultString(runtime.httpsProxy, this._httpsProxy),
      noProxy: Util.defaultString(runtime.noProxy, this._noProxy),
      socks5Proxy: Util.defaultString(runtime.socks5Proxy, this._socks5Proxy),
      socks5NetWork: Util.defaultString(runtime.socks5NetWork, this._socks5NetWork),
      maxIdleConns: Util.defaultNumber(runtime.maxIdleConns, this._maxIdleConns),
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: Util.defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: Util.defaultString(runtime.backoffPolicy, "no"),
        period: Util.defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
    }

    let _lastRequest = null;
    let _now = Date.now();
    let _retryTimes = 0;
    while ($tea.allowRetry(_runtime['retry'], _retryTimes, _now)) {
      if (_retryTimes > 0) {
        let _backoffTime = $tea.getBackoffTime(_runtime['backoff'], _retryTimes);
        if (_backoffTime > 0) {
          await $tea.sleep(_backoffTime);
        }
      }

      _retryTimes = _retryTimes + 1;
      try {
        let request_ = new $tea.Request();
        let accessKeyId = await this._credential.getAccessKeyId();
        let accessKeySecret = await this._credential.getAccessKeySecret();
        let token = await this._credential.getSecurityToken();
        let reqBody = XML.toXML($tea.toMap(request.body));
        request_.protocol = this._protocol;
        request_.method = "POST";
        request_.pathname = `/?delete`;
        request_.headers = {
          host: OSSUtil.getHost(request.bucketName, this._regionId, this._endpoint, this._hostModel),
          date: Util.getDateUTCString(),
          'user-agent': this.getUserAgent(),
          ...Util.stringifyMapValue($tea.toMap(request.header)),
        };
        if (!Util.empty(token)) {
          request_.headers["x-oss-security-token"] = token;
        }

        request_.body = new $tea.BytesReadable(reqBody);
        if (!Util.isUnset($tea.toMap(request.header)) && !Util.empty(request.header.contentMD5)) {
          request_.headers["content-md5"] = request.header.contentMD5;
        } else {
          request_.headers["content-md5"] = OSSUtil.getContentMD5(reqBody, this._isEnableMD5);
        }

        request_.headers["authorization"] = OSSUtil.getSignature(request_, request.bucketName, accessKeyId, accessKeySecret, this._signatureVersion, this._addtionalHeaders);
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap : {[key: string]: any} = null;
        let bodyStr : string = null;
        if (Util.is4xx(response_.statusCode) || Util.is5xx(response_.statusCode)) {
          bodyStr = await Util.readAsString(response_.body);
          respMap = OSSUtil.getErrMessage(bodyStr);
          throw $tea.newError({
            code: respMap["Code"],
            message: respMap["Message"],
            data: {
              httpCode: response_.statusCode,
              requestId: respMap["RequestId"],
              hostId: respMap["HostId"],
            },
          });
        }

        bodyStr = await Util.readAsString(response_.body);
        respMap = XML.parseXml(bodyStr, DeleteMultipleObjectsResponse);
        return $tea.cast<DeleteMultipleObjectsResponse>({
          DeleteResult: respMap["DeleteResult"],
          ...response_.headers,
        }, new DeleteMultipleObjectsResponse({}));
      } catch (ex) {
        if ($tea.isRetryable(ex)) {
          continue;
        }
        throw ex;
      }
    }

    throw $tea.newUnretryableError(_lastRequest);
  }

  async putBucketReferer(request: PutBucketRefererRequest, runtime: $OSSUtil.RuntimeOptions): Promise<PutBucketRefererResponse> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: Util.defaultNumber(runtime.readTimeout, this._readTimeout),
      connectTimeout: Util.defaultNumber(runtime.connectTimeout, this._connectTimeout),
      localAddr: Util.defaultString(runtime.localAddr, this._localAddr),
      httpProxy: Util.defaultString(runtime.httpProxy, this._httpProxy),
      httpsProxy: Util.defaultString(runtime.httpsProxy, this._httpsProxy),
      noProxy: Util.defaultString(runtime.noProxy, this._noProxy),
      socks5Proxy: Util.defaultString(runtime.socks5Proxy, this._socks5Proxy),
      socks5NetWork: Util.defaultString(runtime.socks5NetWork, this._socks5NetWork),
      maxIdleConns: Util.defaultNumber(runtime.maxIdleConns, this._maxIdleConns),
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: Util.defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: Util.defaultString(runtime.backoffPolicy, "no"),
        period: Util.defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
    }

    let _lastRequest = null;
    let _now = Date.now();
    let _retryTimes = 0;
    while ($tea.allowRetry(_runtime['retry'], _retryTimes, _now)) {
      if (_retryTimes > 0) {
        let _backoffTime = $tea.getBackoffTime(_runtime['backoff'], _retryTimes);
        if (_backoffTime > 0) {
          await $tea.sleep(_backoffTime);
        }
      }

      _retryTimes = _retryTimes + 1;
      try {
        let request_ = new $tea.Request();
        let accessKeyId = await this._credential.getAccessKeyId();
        let accessKeySecret = await this._credential.getAccessKeySecret();
        let token = await this._credential.getSecurityToken();
        let reqBody = XML.toXML($tea.toMap(request.body));
        request_.protocol = this._protocol;
        request_.method = "PUT";
        request_.pathname = `/?referer`;
        request_.headers = {
          host: OSSUtil.getHost(request.bucketName, this._regionId, this._endpoint, this._hostModel),
          date: Util.getDateUTCString(),
          'user-agent': this.getUserAgent(),
        };
        if (!Util.empty(token)) {
          request_.headers["x-oss-security-token"] = token;
        }

        request_.body = new $tea.BytesReadable(reqBody);
        request_.headers["authorization"] = OSSUtil.getSignature(request_, request.bucketName, accessKeyId, accessKeySecret, this._signatureVersion, this._addtionalHeaders);
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap : {[key: string]: any} = null;
        let bodyStr : string = null;
        if (Util.is4xx(response_.statusCode) || Util.is5xx(response_.statusCode)) {
          bodyStr = await Util.readAsString(response_.body);
          respMap = OSSUtil.getErrMessage(bodyStr);
          throw $tea.newError({
            code: respMap["Code"],
            message: respMap["Message"],
            data: {
              httpCode: response_.statusCode,
              requestId: respMap["RequestId"],
              hostId: respMap["HostId"],
            },
          });
        }

        return $tea.cast<PutBucketRefererResponse>({
          ...response_.headers,
        }, new PutBucketRefererResponse({}));
      } catch (ex) {
        if ($tea.isRetryable(ex)) {
          continue;
        }
        throw ex;
      }
    }

    throw $tea.newUnretryableError(_lastRequest);
  }

  async putBucketWebsite(request: PutBucketWebsiteRequest, runtime: $OSSUtil.RuntimeOptions): Promise<PutBucketWebsiteResponse> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: Util.defaultNumber(runtime.readTimeout, this._readTimeout),
      connectTimeout: Util.defaultNumber(runtime.connectTimeout, this._connectTimeout),
      localAddr: Util.defaultString(runtime.localAddr, this._localAddr),
      httpProxy: Util.defaultString(runtime.httpProxy, this._httpProxy),
      httpsProxy: Util.defaultString(runtime.httpsProxy, this._httpsProxy),
      noProxy: Util.defaultString(runtime.noProxy, this._noProxy),
      socks5Proxy: Util.defaultString(runtime.socks5Proxy, this._socks5Proxy),
      socks5NetWork: Util.defaultString(runtime.socks5NetWork, this._socks5NetWork),
      maxIdleConns: Util.defaultNumber(runtime.maxIdleConns, this._maxIdleConns),
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: Util.defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: Util.defaultString(runtime.backoffPolicy, "no"),
        period: Util.defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
    }

    let _lastRequest = null;
    let _now = Date.now();
    let _retryTimes = 0;
    while ($tea.allowRetry(_runtime['retry'], _retryTimes, _now)) {
      if (_retryTimes > 0) {
        let _backoffTime = $tea.getBackoffTime(_runtime['backoff'], _retryTimes);
        if (_backoffTime > 0) {
          await $tea.sleep(_backoffTime);
        }
      }

      _retryTimes = _retryTimes + 1;
      try {
        let request_ = new $tea.Request();
        let accessKeyId = await this._credential.getAccessKeyId();
        let accessKeySecret = await this._credential.getAccessKeySecret();
        let token = await this._credential.getSecurityToken();
        let reqBody = XML.toXML($tea.toMap(request.body));
        request_.protocol = this._protocol;
        request_.method = "PUT";
        request_.pathname = `/?website`;
        request_.headers = {
          host: OSSUtil.getHost(request.bucketName, this._regionId, this._endpoint, this._hostModel),
          date: Util.getDateUTCString(),
          'user-agent': this.getUserAgent(),
        };
        if (!Util.empty(token)) {
          request_.headers["x-oss-security-token"] = token;
        }

        request_.body = new $tea.BytesReadable(reqBody);
        request_.headers["authorization"] = OSSUtil.getSignature(request_, request.bucketName, accessKeyId, accessKeySecret, this._signatureVersion, this._addtionalHeaders);
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap : {[key: string]: any} = null;
        let bodyStr : string = null;
        if (Util.is4xx(response_.statusCode) || Util.is5xx(response_.statusCode)) {
          bodyStr = await Util.readAsString(response_.body);
          respMap = OSSUtil.getErrMessage(bodyStr);
          throw $tea.newError({
            code: respMap["Code"],
            message: respMap["Message"],
            data: {
              httpCode: response_.statusCode,
              requestId: respMap["RequestId"],
              hostId: respMap["HostId"],
            },
          });
        }

        return $tea.cast<PutBucketWebsiteResponse>({
          ...response_.headers,
        }, new PutBucketWebsiteResponse({}));
      } catch (ex) {
        if ($tea.isRetryable(ex)) {
          continue;
        }
        throw ex;
      }
    }

    throw $tea.newUnretryableError(_lastRequest);
  }

  async completeMultipartUpload(request: CompleteMultipartUploadRequest, runtime: $OSSUtil.RuntimeOptions): Promise<CompleteMultipartUploadResponse> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: Util.defaultNumber(runtime.readTimeout, this._readTimeout),
      connectTimeout: Util.defaultNumber(runtime.connectTimeout, this._connectTimeout),
      localAddr: Util.defaultString(runtime.localAddr, this._localAddr),
      httpProxy: Util.defaultString(runtime.httpProxy, this._httpProxy),
      httpsProxy: Util.defaultString(runtime.httpsProxy, this._httpsProxy),
      noProxy: Util.defaultString(runtime.noProxy, this._noProxy),
      socks5Proxy: Util.defaultString(runtime.socks5Proxy, this._socks5Proxy),
      socks5NetWork: Util.defaultString(runtime.socks5NetWork, this._socks5NetWork),
      maxIdleConns: Util.defaultNumber(runtime.maxIdleConns, this._maxIdleConns),
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: Util.defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: Util.defaultString(runtime.backoffPolicy, "no"),
        period: Util.defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
    }

    let _lastRequest = null;
    let _now = Date.now();
    let _retryTimes = 0;
    while ($tea.allowRetry(_runtime['retry'], _retryTimes, _now)) {
      if (_retryTimes > 0) {
        let _backoffTime = $tea.getBackoffTime(_runtime['backoff'], _retryTimes);
        if (_backoffTime > 0) {
          await $tea.sleep(_backoffTime);
        }
      }

      _retryTimes = _retryTimes + 1;
      try {
        let request_ = new $tea.Request();
        let accessKeyId = await this._credential.getAccessKeyId();
        let accessKeySecret = await this._credential.getAccessKeySecret();
        let token = await this._credential.getSecurityToken();
        let reqBody = XML.toXML($tea.toMap(request.body));
        request_.protocol = this._protocol;
        request_.method = "POST";
        request_.pathname = `/${request.objectName}`;
        request_.headers = {
          host: OSSUtil.getHost(request.bucketName, this._regionId, this._endpoint, this._hostModel),
          date: Util.getDateUTCString(),
          'user-agent': this.getUserAgent(),
        };
        if (!Util.empty(token)) {
          request_.headers["x-oss-security-token"] = token;
        }

        request_.query = Util.stringifyMapValue($tea.toMap(request.filter));
        request_.body = new $tea.BytesReadable(reqBody);
        request_.headers["authorization"] = OSSUtil.getSignature(request_, request.bucketName, accessKeyId, accessKeySecret, this._signatureVersion, this._addtionalHeaders);
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap : {[key: string]: any} = null;
        let bodyStr : string = null;
        if (Util.is4xx(response_.statusCode) || Util.is5xx(response_.statusCode)) {
          bodyStr = await Util.readAsString(response_.body);
          respMap = OSSUtil.getErrMessage(bodyStr);
          throw $tea.newError({
            code: respMap["Code"],
            message: respMap["Message"],
            data: {
              httpCode: response_.statusCode,
              requestId: respMap["RequestId"],
              hostId: respMap["HostId"],
            },
          });
        }

        bodyStr = await Util.readAsString(response_.body);
        respMap = XML.parseXml(bodyStr, CompleteMultipartUploadResponse);
        return $tea.cast<CompleteMultipartUploadResponse>({
          CompleteMultipartUploadResult: respMap["CompleteMultipartUploadResult"],
          ...response_.headers,
        }, new CompleteMultipartUploadResponse({}));
      } catch (ex) {
        if ($tea.isRetryable(ex)) {
          continue;
        }
        throw ex;
      }
    }

    throw $tea.newUnretryableError(_lastRequest);
  }

  async putBucketLogging(request: PutBucketLoggingRequest, runtime: $OSSUtil.RuntimeOptions): Promise<PutBucketLoggingResponse> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: Util.defaultNumber(runtime.readTimeout, this._readTimeout),
      connectTimeout: Util.defaultNumber(runtime.connectTimeout, this._connectTimeout),
      localAddr: Util.defaultString(runtime.localAddr, this._localAddr),
      httpProxy: Util.defaultString(runtime.httpProxy, this._httpProxy),
      httpsProxy: Util.defaultString(runtime.httpsProxy, this._httpsProxy),
      noProxy: Util.defaultString(runtime.noProxy, this._noProxy),
      socks5Proxy: Util.defaultString(runtime.socks5Proxy, this._socks5Proxy),
      socks5NetWork: Util.defaultString(runtime.socks5NetWork, this._socks5NetWork),
      maxIdleConns: Util.defaultNumber(runtime.maxIdleConns, this._maxIdleConns),
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: Util.defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: Util.defaultString(runtime.backoffPolicy, "no"),
        period: Util.defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
    }

    let _lastRequest = null;
    let _now = Date.now();
    let _retryTimes = 0;
    while ($tea.allowRetry(_runtime['retry'], _retryTimes, _now)) {
      if (_retryTimes > 0) {
        let _backoffTime = $tea.getBackoffTime(_runtime['backoff'], _retryTimes);
        if (_backoffTime > 0) {
          await $tea.sleep(_backoffTime);
        }
      }

      _retryTimes = _retryTimes + 1;
      try {
        let request_ = new $tea.Request();
        let accessKeyId = await this._credential.getAccessKeyId();
        let accessKeySecret = await this._credential.getAccessKeySecret();
        let token = await this._credential.getSecurityToken();
        let reqBody = XML.toXML($tea.toMap(request.body));
        request_.protocol = this._protocol;
        request_.method = "PUT";
        request_.pathname = `/?logging`;
        request_.headers = {
          host: OSSUtil.getHost(request.bucketName, this._regionId, this._endpoint, this._hostModel),
          date: Util.getDateUTCString(),
          'user-agent': this.getUserAgent(),
        };
        if (!Util.empty(token)) {
          request_.headers["x-oss-security-token"] = token;
        }

        request_.body = new $tea.BytesReadable(reqBody);
        request_.headers["authorization"] = OSSUtil.getSignature(request_, request.bucketName, accessKeyId, accessKeySecret, this._signatureVersion, this._addtionalHeaders);
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap : {[key: string]: any} = null;
        let bodyStr : string = null;
        if (Util.is4xx(response_.statusCode) || Util.is5xx(response_.statusCode)) {
          bodyStr = await Util.readAsString(response_.body);
          respMap = OSSUtil.getErrMessage(bodyStr);
          throw $tea.newError({
            code: respMap["Code"],
            message: respMap["Message"],
            data: {
              httpCode: response_.statusCode,
              requestId: respMap["RequestId"],
              hostId: respMap["HostId"],
            },
          });
        }

        return $tea.cast<PutBucketLoggingResponse>({
          ...response_.headers,
        }, new PutBucketLoggingResponse({}));
      } catch (ex) {
        if ($tea.isRetryable(ex)) {
          continue;
        }
        throw ex;
      }
    }

    throw $tea.newUnretryableError(_lastRequest);
  }

  async putBucketRequestPayment(request: PutBucketRequestPaymentRequest, runtime: $OSSUtil.RuntimeOptions): Promise<PutBucketRequestPaymentResponse> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: Util.defaultNumber(runtime.readTimeout, this._readTimeout),
      connectTimeout: Util.defaultNumber(runtime.connectTimeout, this._connectTimeout),
      localAddr: Util.defaultString(runtime.localAddr, this._localAddr),
      httpProxy: Util.defaultString(runtime.httpProxy, this._httpProxy),
      httpsProxy: Util.defaultString(runtime.httpsProxy, this._httpsProxy),
      noProxy: Util.defaultString(runtime.noProxy, this._noProxy),
      socks5Proxy: Util.defaultString(runtime.socks5Proxy, this._socks5Proxy),
      socks5NetWork: Util.defaultString(runtime.socks5NetWork, this._socks5NetWork),
      maxIdleConns: Util.defaultNumber(runtime.maxIdleConns, this._maxIdleConns),
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: Util.defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: Util.defaultString(runtime.backoffPolicy, "no"),
        period: Util.defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
    }

    let _lastRequest = null;
    let _now = Date.now();
    let _retryTimes = 0;
    while ($tea.allowRetry(_runtime['retry'], _retryTimes, _now)) {
      if (_retryTimes > 0) {
        let _backoffTime = $tea.getBackoffTime(_runtime['backoff'], _retryTimes);
        if (_backoffTime > 0) {
          await $tea.sleep(_backoffTime);
        }
      }

      _retryTimes = _retryTimes + 1;
      try {
        let request_ = new $tea.Request();
        let accessKeyId = await this._credential.getAccessKeyId();
        let accessKeySecret = await this._credential.getAccessKeySecret();
        let token = await this._credential.getSecurityToken();
        let reqBody = XML.toXML($tea.toMap(request.body));
        request_.protocol = this._protocol;
        request_.method = "PUT";
        request_.pathname = `/?requestPayment`;
        request_.headers = {
          host: OSSUtil.getHost(request.bucketName, this._regionId, this._endpoint, this._hostModel),
          date: Util.getDateUTCString(),
          'user-agent': this.getUserAgent(),
        };
        if (!Util.empty(token)) {
          request_.headers["x-oss-security-token"] = token;
        }

        request_.body = new $tea.BytesReadable(reqBody);
        request_.headers["authorization"] = OSSUtil.getSignature(request_, request.bucketName, accessKeyId, accessKeySecret, this._signatureVersion, this._addtionalHeaders);
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap : {[key: string]: any} = null;
        let bodyStr : string = null;
        if (Util.is4xx(response_.statusCode) || Util.is5xx(response_.statusCode)) {
          bodyStr = await Util.readAsString(response_.body);
          respMap = OSSUtil.getErrMessage(bodyStr);
          throw $tea.newError({
            code: respMap["Code"],
            message: respMap["Message"],
            data: {
              httpCode: response_.statusCode,
              requestId: respMap["RequestId"],
              hostId: respMap["HostId"],
            },
          });
        }

        return $tea.cast<PutBucketRequestPaymentResponse>({
          ...response_.headers,
        }, new PutBucketRequestPaymentResponse({}));
      } catch (ex) {
        if ($tea.isRetryable(ex)) {
          continue;
        }
        throw ex;
      }
    }

    throw $tea.newUnretryableError(_lastRequest);
  }

  async putBucketEncryption(request: PutBucketEncryptionRequest, runtime: $OSSUtil.RuntimeOptions): Promise<PutBucketEncryptionResponse> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: Util.defaultNumber(runtime.readTimeout, this._readTimeout),
      connectTimeout: Util.defaultNumber(runtime.connectTimeout, this._connectTimeout),
      localAddr: Util.defaultString(runtime.localAddr, this._localAddr),
      httpProxy: Util.defaultString(runtime.httpProxy, this._httpProxy),
      httpsProxy: Util.defaultString(runtime.httpsProxy, this._httpsProxy),
      noProxy: Util.defaultString(runtime.noProxy, this._noProxy),
      socks5Proxy: Util.defaultString(runtime.socks5Proxy, this._socks5Proxy),
      socks5NetWork: Util.defaultString(runtime.socks5NetWork, this._socks5NetWork),
      maxIdleConns: Util.defaultNumber(runtime.maxIdleConns, this._maxIdleConns),
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: Util.defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: Util.defaultString(runtime.backoffPolicy, "no"),
        period: Util.defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
    }

    let _lastRequest = null;
    let _now = Date.now();
    let _retryTimes = 0;
    while ($tea.allowRetry(_runtime['retry'], _retryTimes, _now)) {
      if (_retryTimes > 0) {
        let _backoffTime = $tea.getBackoffTime(_runtime['backoff'], _retryTimes);
        if (_backoffTime > 0) {
          await $tea.sleep(_backoffTime);
        }
      }

      _retryTimes = _retryTimes + 1;
      try {
        let request_ = new $tea.Request();
        let accessKeyId = await this._credential.getAccessKeyId();
        let accessKeySecret = await this._credential.getAccessKeySecret();
        let token = await this._credential.getSecurityToken();
        let reqBody = XML.toXML($tea.toMap(request.body));
        request_.protocol = this._protocol;
        request_.method = "PUT";
        request_.pathname = `/?encryption`;
        request_.headers = {
          host: OSSUtil.getHost(request.bucketName, this._regionId, this._endpoint, this._hostModel),
          date: Util.getDateUTCString(),
          'user-agent': this.getUserAgent(),
        };
        if (!Util.empty(token)) {
          request_.headers["x-oss-security-token"] = token;
        }

        request_.body = new $tea.BytesReadable(reqBody);
        request_.headers["authorization"] = OSSUtil.getSignature(request_, request.bucketName, accessKeyId, accessKeySecret, this._signatureVersion, this._addtionalHeaders);
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap : {[key: string]: any} = null;
        let bodyStr : string = null;
        if (Util.is4xx(response_.statusCode) || Util.is5xx(response_.statusCode)) {
          bodyStr = await Util.readAsString(response_.body);
          respMap = OSSUtil.getErrMessage(bodyStr);
          throw $tea.newError({
            code: respMap["Code"],
            message: respMap["Message"],
            data: {
              httpCode: response_.statusCode,
              requestId: respMap["RequestId"],
              hostId: respMap["HostId"],
            },
          });
        }

        return $tea.cast<PutBucketEncryptionResponse>({
          ...response_.headers,
        }, new PutBucketEncryptionResponse({}));
      } catch (ex) {
        if ($tea.isRetryable(ex)) {
          continue;
        }
        throw ex;
      }
    }

    throw $tea.newUnretryableError(_lastRequest);
  }

  async putLiveChannel(request: PutLiveChannelRequest, runtime: $OSSUtil.RuntimeOptions): Promise<PutLiveChannelResponse> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: Util.defaultNumber(runtime.readTimeout, this._readTimeout),
      connectTimeout: Util.defaultNumber(runtime.connectTimeout, this._connectTimeout),
      localAddr: Util.defaultString(runtime.localAddr, this._localAddr),
      httpProxy: Util.defaultString(runtime.httpProxy, this._httpProxy),
      httpsProxy: Util.defaultString(runtime.httpsProxy, this._httpsProxy),
      noProxy: Util.defaultString(runtime.noProxy, this._noProxy),
      socks5Proxy: Util.defaultString(runtime.socks5Proxy, this._socks5Proxy),
      socks5NetWork: Util.defaultString(runtime.socks5NetWork, this._socks5NetWork),
      maxIdleConns: Util.defaultNumber(runtime.maxIdleConns, this._maxIdleConns),
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: Util.defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: Util.defaultString(runtime.backoffPolicy, "no"),
        period: Util.defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
    }

    let _lastRequest = null;
    let _now = Date.now();
    let _retryTimes = 0;
    while ($tea.allowRetry(_runtime['retry'], _retryTimes, _now)) {
      if (_retryTimes > 0) {
        let _backoffTime = $tea.getBackoffTime(_runtime['backoff'], _retryTimes);
        if (_backoffTime > 0) {
          await $tea.sleep(_backoffTime);
        }
      }

      _retryTimes = _retryTimes + 1;
      try {
        let request_ = new $tea.Request();
        let accessKeyId = await this._credential.getAccessKeyId();
        let accessKeySecret = await this._credential.getAccessKeySecret();
        let token = await this._credential.getSecurityToken();
        let reqBody = XML.toXML($tea.toMap(request.body));
        request_.protocol = this._protocol;
        request_.method = "PUT";
        request_.pathname = `/${request.channelName}?live`;
        request_.headers = {
          host: OSSUtil.getHost(request.bucketName, this._regionId, this._endpoint, this._hostModel),
          date: Util.getDateUTCString(),
          'user-agent': this.getUserAgent(),
        };
        if (!Util.empty(token)) {
          request_.headers["x-oss-security-token"] = token;
        }

        request_.body = new $tea.BytesReadable(reqBody);
        request_.headers["authorization"] = OSSUtil.getSignature(request_, request.bucketName, accessKeyId, accessKeySecret, this._signatureVersion, this._addtionalHeaders);
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap : {[key: string]: any} = null;
        let bodyStr : string = null;
        if (Util.is4xx(response_.statusCode) || Util.is5xx(response_.statusCode)) {
          bodyStr = await Util.readAsString(response_.body);
          respMap = OSSUtil.getErrMessage(bodyStr);
          throw $tea.newError({
            code: respMap["Code"],
            message: respMap["Message"],
            data: {
              httpCode: response_.statusCode,
              requestId: respMap["RequestId"],
              hostId: respMap["HostId"],
            },
          });
        }

        bodyStr = await Util.readAsString(response_.body);
        respMap = XML.parseXml(bodyStr, PutLiveChannelResponse);
        return $tea.cast<PutLiveChannelResponse>({
          CreateLiveChannelResult: respMap["CreateLiveChannelResult"],
          ...response_.headers,
        }, new PutLiveChannelResponse({}));
      } catch (ex) {
        if ($tea.isRetryable(ex)) {
          continue;
        }
        throw ex;
      }
    }

    throw $tea.newUnretryableError(_lastRequest);
  }

  async putBucketTags(request: PutBucketTagsRequest, runtime: $OSSUtil.RuntimeOptions): Promise<PutBucketTagsResponse> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: Util.defaultNumber(runtime.readTimeout, this._readTimeout),
      connectTimeout: Util.defaultNumber(runtime.connectTimeout, this._connectTimeout),
      localAddr: Util.defaultString(runtime.localAddr, this._localAddr),
      httpProxy: Util.defaultString(runtime.httpProxy, this._httpProxy),
      httpsProxy: Util.defaultString(runtime.httpsProxy, this._httpsProxy),
      noProxy: Util.defaultString(runtime.noProxy, this._noProxy),
      socks5Proxy: Util.defaultString(runtime.socks5Proxy, this._socks5Proxy),
      socks5NetWork: Util.defaultString(runtime.socks5NetWork, this._socks5NetWork),
      maxIdleConns: Util.defaultNumber(runtime.maxIdleConns, this._maxIdleConns),
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: Util.defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: Util.defaultString(runtime.backoffPolicy, "no"),
        period: Util.defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
    }

    let _lastRequest = null;
    let _now = Date.now();
    let _retryTimes = 0;
    while ($tea.allowRetry(_runtime['retry'], _retryTimes, _now)) {
      if (_retryTimes > 0) {
        let _backoffTime = $tea.getBackoffTime(_runtime['backoff'], _retryTimes);
        if (_backoffTime > 0) {
          await $tea.sleep(_backoffTime);
        }
      }

      _retryTimes = _retryTimes + 1;
      try {
        let request_ = new $tea.Request();
        let accessKeyId = await this._credential.getAccessKeyId();
        let accessKeySecret = await this._credential.getAccessKeySecret();
        let token = await this._credential.getSecurityToken();
        let reqBody = XML.toXML($tea.toMap(request.body));
        request_.protocol = this._protocol;
        request_.method = "PUT";
        request_.pathname = `/?tagging`;
        request_.headers = {
          host: OSSUtil.getHost(request.bucketName, this._regionId, this._endpoint, this._hostModel),
          date: Util.getDateUTCString(),
          'user-agent': this.getUserAgent(),
        };
        if (!Util.empty(token)) {
          request_.headers["x-oss-security-token"] = token;
        }

        request_.body = new $tea.BytesReadable(reqBody);
        request_.headers["authorization"] = OSSUtil.getSignature(request_, request.bucketName, accessKeyId, accessKeySecret, this._signatureVersion, this._addtionalHeaders);
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap : {[key: string]: any} = null;
        let bodyStr : string = null;
        if (Util.is4xx(response_.statusCode) || Util.is5xx(response_.statusCode)) {
          bodyStr = await Util.readAsString(response_.body);
          respMap = OSSUtil.getErrMessage(bodyStr);
          throw $tea.newError({
            code: respMap["Code"],
            message: respMap["Message"],
            data: {
              httpCode: response_.statusCode,
              requestId: respMap["RequestId"],
              hostId: respMap["HostId"],
            },
          });
        }

        return $tea.cast<PutBucketTagsResponse>({
          ...response_.headers,
        }, new PutBucketTagsResponse({}));
      } catch (ex) {
        if ($tea.isRetryable(ex)) {
          continue;
        }
        throw ex;
      }
    }

    throw $tea.newUnretryableError(_lastRequest);
  }

  async putObjectTagging(request: PutObjectTaggingRequest, runtime: $OSSUtil.RuntimeOptions): Promise<PutObjectTaggingResponse> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: Util.defaultNumber(runtime.readTimeout, this._readTimeout),
      connectTimeout: Util.defaultNumber(runtime.connectTimeout, this._connectTimeout),
      localAddr: Util.defaultString(runtime.localAddr, this._localAddr),
      httpProxy: Util.defaultString(runtime.httpProxy, this._httpProxy),
      httpsProxy: Util.defaultString(runtime.httpsProxy, this._httpsProxy),
      noProxy: Util.defaultString(runtime.noProxy, this._noProxy),
      socks5Proxy: Util.defaultString(runtime.socks5Proxy, this._socks5Proxy),
      socks5NetWork: Util.defaultString(runtime.socks5NetWork, this._socks5NetWork),
      maxIdleConns: Util.defaultNumber(runtime.maxIdleConns, this._maxIdleConns),
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: Util.defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: Util.defaultString(runtime.backoffPolicy, "no"),
        period: Util.defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
    }

    let _lastRequest = null;
    let _now = Date.now();
    let _retryTimes = 0;
    while ($tea.allowRetry(_runtime['retry'], _retryTimes, _now)) {
      if (_retryTimes > 0) {
        let _backoffTime = $tea.getBackoffTime(_runtime['backoff'], _retryTimes);
        if (_backoffTime > 0) {
          await $tea.sleep(_backoffTime);
        }
      }

      _retryTimes = _retryTimes + 1;
      try {
        let request_ = new $tea.Request();
        let accessKeyId = await this._credential.getAccessKeyId();
        let accessKeySecret = await this._credential.getAccessKeySecret();
        let token = await this._credential.getSecurityToken();
        let reqBody = XML.toXML($tea.toMap(request.body));
        request_.protocol = this._protocol;
        request_.method = "PUT";
        request_.pathname = `/${request.objectName}?tagging`;
        request_.headers = {
          host: OSSUtil.getHost(request.bucketName, this._regionId, this._endpoint, this._hostModel),
          date: Util.getDateUTCString(),
          'user-agent': this.getUserAgent(),
        };
        if (!Util.empty(token)) {
          request_.headers["x-oss-security-token"] = token;
        }

        request_.body = new $tea.BytesReadable(reqBody);
        request_.headers["authorization"] = OSSUtil.getSignature(request_, request.bucketName, accessKeyId, accessKeySecret, this._signatureVersion, this._addtionalHeaders);
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap : {[key: string]: any} = null;
        let bodyStr : string = null;
        if (Util.is4xx(response_.statusCode) || Util.is5xx(response_.statusCode)) {
          bodyStr = await Util.readAsString(response_.body);
          respMap = OSSUtil.getErrMessage(bodyStr);
          throw $tea.newError({
            code: respMap["Code"],
            message: respMap["Message"],
            data: {
              httpCode: response_.statusCode,
              requestId: respMap["RequestId"],
              hostId: respMap["HostId"],
            },
          });
        }

        return $tea.cast<PutObjectTaggingResponse>({
          ...response_.headers,
        }, new PutObjectTaggingResponse({}));
      } catch (ex) {
        if ($tea.isRetryable(ex)) {
          continue;
        }
        throw ex;
      }
    }

    throw $tea.newUnretryableError(_lastRequest);
  }

  async selectObject(request: SelectObjectRequest, runtime: $OSSUtil.RuntimeOptions): Promise<SelectObjectResponse> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: Util.defaultNumber(runtime.readTimeout, this._readTimeout),
      connectTimeout: Util.defaultNumber(runtime.connectTimeout, this._connectTimeout),
      localAddr: Util.defaultString(runtime.localAddr, this._localAddr),
      httpProxy: Util.defaultString(runtime.httpProxy, this._httpProxy),
      httpsProxy: Util.defaultString(runtime.httpsProxy, this._httpsProxy),
      noProxy: Util.defaultString(runtime.noProxy, this._noProxy),
      socks5Proxy: Util.defaultString(runtime.socks5Proxy, this._socks5Proxy),
      socks5NetWork: Util.defaultString(runtime.socks5NetWork, this._socks5NetWork),
      maxIdleConns: Util.defaultNumber(runtime.maxIdleConns, this._maxIdleConns),
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: Util.defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: Util.defaultString(runtime.backoffPolicy, "no"),
        period: Util.defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
    }

    let _lastRequest = null;
    let _now = Date.now();
    let _retryTimes = 0;
    while ($tea.allowRetry(_runtime['retry'], _retryTimes, _now)) {
      if (_retryTimes > 0) {
        let _backoffTime = $tea.getBackoffTime(_runtime['backoff'], _retryTimes);
        if (_backoffTime > 0) {
          await $tea.sleep(_backoffTime);
        }
      }

      _retryTimes = _retryTimes + 1;
      try {
        let request_ = new $tea.Request();
        let accessKeyId = await this._credential.getAccessKeyId();
        let accessKeySecret = await this._credential.getAccessKeySecret();
        let token = await this._credential.getSecurityToken();
        let reqBody = XML.toXML($tea.toMap(request.body));
        request_.protocol = this._protocol;
        request_.method = "POST";
        request_.pathname = `/${request.objectName}`;
        request_.headers = {
          host: OSSUtil.getHost(request.bucketName, this._regionId, this._endpoint, this._hostModel),
          date: Util.getDateUTCString(),
          'user-agent': this.getUserAgent(),
        };
        if (!Util.empty(token)) {
          request_.headers["x-oss-security-token"] = token;
        }

        request_.query = Util.stringifyMapValue($tea.toMap(request.filter));
        request_.body = new $tea.BytesReadable(reqBody);
        request_.headers["authorization"] = OSSUtil.getSignature(request_, request.bucketName, accessKeyId, accessKeySecret, this._signatureVersion, this._addtionalHeaders);
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap : {[key: string]: any} = null;
        let bodyStr : string = null;
        if (Util.is4xx(response_.statusCode) || Util.is5xx(response_.statusCode)) {
          bodyStr = await Util.readAsString(response_.body);
          respMap = OSSUtil.getErrMessage(bodyStr);
          throw $tea.newError({
            code: respMap["Code"],
            message: respMap["Message"],
            data: {
              httpCode: response_.statusCode,
              requestId: respMap["RequestId"],
              hostId: respMap["HostId"],
            },
          });
        }

        return $tea.cast<SelectObjectResponse>({
          ...response_.headers,
        }, new SelectObjectResponse({}));
      } catch (ex) {
        if ($tea.isRetryable(ex)) {
          continue;
        }
        throw ex;
      }
    }

    throw $tea.newUnretryableError(_lastRequest);
  }

  async putBucketCORS(request: PutBucketCORSRequest, runtime: $OSSUtil.RuntimeOptions): Promise<PutBucketCORSResponse> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: Util.defaultNumber(runtime.readTimeout, this._readTimeout),
      connectTimeout: Util.defaultNumber(runtime.connectTimeout, this._connectTimeout),
      localAddr: Util.defaultString(runtime.localAddr, this._localAddr),
      httpProxy: Util.defaultString(runtime.httpProxy, this._httpProxy),
      httpsProxy: Util.defaultString(runtime.httpsProxy, this._httpsProxy),
      noProxy: Util.defaultString(runtime.noProxy, this._noProxy),
      socks5Proxy: Util.defaultString(runtime.socks5Proxy, this._socks5Proxy),
      socks5NetWork: Util.defaultString(runtime.socks5NetWork, this._socks5NetWork),
      maxIdleConns: Util.defaultNumber(runtime.maxIdleConns, this._maxIdleConns),
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: Util.defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: Util.defaultString(runtime.backoffPolicy, "no"),
        period: Util.defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
    }

    let _lastRequest = null;
    let _now = Date.now();
    let _retryTimes = 0;
    while ($tea.allowRetry(_runtime['retry'], _retryTimes, _now)) {
      if (_retryTimes > 0) {
        let _backoffTime = $tea.getBackoffTime(_runtime['backoff'], _retryTimes);
        if (_backoffTime > 0) {
          await $tea.sleep(_backoffTime);
        }
      }

      _retryTimes = _retryTimes + 1;
      try {
        let request_ = new $tea.Request();
        let accessKeyId = await this._credential.getAccessKeyId();
        let accessKeySecret = await this._credential.getAccessKeySecret();
        let token = await this._credential.getSecurityToken();
        let reqBody = XML.toXML($tea.toMap(request.body));
        request_.protocol = this._protocol;
        request_.method = "PUT";
        request_.pathname = `/?cors`;
        request_.headers = {
          host: OSSUtil.getHost(request.bucketName, this._regionId, this._endpoint, this._hostModel),
          date: Util.getDateUTCString(),
          'user-agent': this.getUserAgent(),
        };
        if (!Util.empty(token)) {
          request_.headers["x-oss-security-token"] = token;
        }

        request_.body = new $tea.BytesReadable(reqBody);
        request_.headers["authorization"] = OSSUtil.getSignature(request_, request.bucketName, accessKeyId, accessKeySecret, this._signatureVersion, this._addtionalHeaders);
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap : {[key: string]: any} = null;
        let bodyStr : string = null;
        if (Util.is4xx(response_.statusCode) || Util.is5xx(response_.statusCode)) {
          bodyStr = await Util.readAsString(response_.body);
          respMap = OSSUtil.getErrMessage(bodyStr);
          throw $tea.newError({
            code: respMap["Code"],
            message: respMap["Message"],
            data: {
              httpCode: response_.statusCode,
              requestId: respMap["RequestId"],
              hostId: respMap["HostId"],
            },
          });
        }

        return $tea.cast<PutBucketCORSResponse>({
          ...response_.headers,
        }, new PutBucketCORSResponse({}));
      } catch (ex) {
        if ($tea.isRetryable(ex)) {
          continue;
        }
        throw ex;
      }
    }

    throw $tea.newUnretryableError(_lastRequest);
  }

  async putBucket(request: PutBucketRequest, runtime: $OSSUtil.RuntimeOptions): Promise<PutBucketResponse> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: Util.defaultNumber(runtime.readTimeout, this._readTimeout),
      connectTimeout: Util.defaultNumber(runtime.connectTimeout, this._connectTimeout),
      localAddr: Util.defaultString(runtime.localAddr, this._localAddr),
      httpProxy: Util.defaultString(runtime.httpProxy, this._httpProxy),
      httpsProxy: Util.defaultString(runtime.httpsProxy, this._httpsProxy),
      noProxy: Util.defaultString(runtime.noProxy, this._noProxy),
      socks5Proxy: Util.defaultString(runtime.socks5Proxy, this._socks5Proxy),
      socks5NetWork: Util.defaultString(runtime.socks5NetWork, this._socks5NetWork),
      maxIdleConns: Util.defaultNumber(runtime.maxIdleConns, this._maxIdleConns),
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: Util.defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: Util.defaultString(runtime.backoffPolicy, "no"),
        period: Util.defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
    }

    let _lastRequest = null;
    let _now = Date.now();
    let _retryTimes = 0;
    while ($tea.allowRetry(_runtime['retry'], _retryTimes, _now)) {
      if (_retryTimes > 0) {
        let _backoffTime = $tea.getBackoffTime(_runtime['backoff'], _retryTimes);
        if (_backoffTime > 0) {
          await $tea.sleep(_backoffTime);
        }
      }

      _retryTimes = _retryTimes + 1;
      try {
        let request_ = new $tea.Request();
        let accessKeyId = await this._credential.getAccessKeyId();
        let accessKeySecret = await this._credential.getAccessKeySecret();
        let token = await this._credential.getSecurityToken();
        let reqBody = XML.toXML($tea.toMap(request.body));
        request_.protocol = this._protocol;
        request_.method = "PUT";
        request_.pathname = `/`;
        request_.headers = {
          host: OSSUtil.getHost(request.bucketName, this._regionId, this._endpoint, this._hostModel),
          date: Util.getDateUTCString(),
          'user-agent': this.getUserAgent(),
          ...Util.stringifyMapValue($tea.toMap(request.header)),
        };
        if (!Util.empty(token)) {
          request_.headers["x-oss-security-token"] = token;
        }

        request_.body = new $tea.BytesReadable(reqBody);
        request_.headers["authorization"] = OSSUtil.getSignature(request_, request.bucketName, accessKeyId, accessKeySecret, this._signatureVersion, this._addtionalHeaders);
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap : {[key: string]: any} = null;
        let bodyStr : string = null;
        if (Util.is4xx(response_.statusCode) || Util.is5xx(response_.statusCode)) {
          bodyStr = await Util.readAsString(response_.body);
          respMap = OSSUtil.getErrMessage(bodyStr);
          throw $tea.newError({
            code: respMap["Code"],
            message: respMap["Message"],
            data: {
              httpCode: response_.statusCode,
              requestId: respMap["RequestId"],
              hostId: respMap["HostId"],
            },
          });
        }

        return $tea.cast<PutBucketResponse>({
          ...response_.headers,
        }, new PutBucketResponse({}));
      } catch (ex) {
        if ($tea.isRetryable(ex)) {
          continue;
        }
        throw ex;
      }
    }

    throw $tea.newUnretryableError(_lastRequest);
  }

  async listMultipartUploads(request: ListMultipartUploadsRequest, runtime: $OSSUtil.RuntimeOptions): Promise<ListMultipartUploadsResponse> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: Util.defaultNumber(runtime.readTimeout, this._readTimeout),
      connectTimeout: Util.defaultNumber(runtime.connectTimeout, this._connectTimeout),
      localAddr: Util.defaultString(runtime.localAddr, this._localAddr),
      httpProxy: Util.defaultString(runtime.httpProxy, this._httpProxy),
      httpsProxy: Util.defaultString(runtime.httpsProxy, this._httpsProxy),
      noProxy: Util.defaultString(runtime.noProxy, this._noProxy),
      socks5Proxy: Util.defaultString(runtime.socks5Proxy, this._socks5Proxy),
      socks5NetWork: Util.defaultString(runtime.socks5NetWork, this._socks5NetWork),
      maxIdleConns: Util.defaultNumber(runtime.maxIdleConns, this._maxIdleConns),
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: Util.defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: Util.defaultString(runtime.backoffPolicy, "no"),
        period: Util.defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
    }

    let _lastRequest = null;
    let _now = Date.now();
    let _retryTimes = 0;
    while ($tea.allowRetry(_runtime['retry'], _retryTimes, _now)) {
      if (_retryTimes > 0) {
        let _backoffTime = $tea.getBackoffTime(_runtime['backoff'], _retryTimes);
        if (_backoffTime > 0) {
          await $tea.sleep(_backoffTime);
        }
      }

      _retryTimes = _retryTimes + 1;
      try {
        let request_ = new $tea.Request();
        let accessKeyId = await this._credential.getAccessKeyId();
        let accessKeySecret = await this._credential.getAccessKeySecret();
        let token = await this._credential.getSecurityToken();
        request_.protocol = this._protocol;
        request_.method = "GET";
        request_.pathname = `/?uploads`;
        request_.headers = {
          host: OSSUtil.getHost(request.bucketName, this._regionId, this._endpoint, this._hostModel),
          date: Util.getDateUTCString(),
          'user-agent': this.getUserAgent(),
        };
        if (!Util.empty(token)) {
          request_.headers["x-oss-security-token"] = token;
        }

        request_.query = Util.stringifyMapValue($tea.toMap(request.filter));
        request_.headers["authorization"] = OSSUtil.getSignature(request_, request.bucketName, accessKeyId, accessKeySecret, this._signatureVersion, this._addtionalHeaders);
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap : {[key: string]: any} = null;
        let bodyStr : string = null;
        if (Util.is4xx(response_.statusCode) || Util.is5xx(response_.statusCode)) {
          bodyStr = await Util.readAsString(response_.body);
          respMap = OSSUtil.getErrMessage(bodyStr);
          throw $tea.newError({
            code: respMap["Code"],
            message: respMap["Message"],
            data: {
              httpCode: response_.statusCode,
              requestId: respMap["RequestId"],
              hostId: respMap["HostId"],
            },
          });
        }

        bodyStr = await Util.readAsString(response_.body);
        respMap = XML.parseXml(bodyStr, ListMultipartUploadsResponse);
        return $tea.cast<ListMultipartUploadsResponse>({
          ListMultipartUploadsResult: respMap["ListMultipartUploadsResult"],
          ...response_.headers,
        }, new ListMultipartUploadsResponse({}));
      } catch (ex) {
        if ($tea.isRetryable(ex)) {
          continue;
        }
        throw ex;
      }
    }

    throw $tea.newUnretryableError(_lastRequest);
  }

  async getBucketRequestPayment(request: GetBucketRequestPaymentRequest, runtime: $OSSUtil.RuntimeOptions): Promise<GetBucketRequestPaymentResponse> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: Util.defaultNumber(runtime.readTimeout, this._readTimeout),
      connectTimeout: Util.defaultNumber(runtime.connectTimeout, this._connectTimeout),
      localAddr: Util.defaultString(runtime.localAddr, this._localAddr),
      httpProxy: Util.defaultString(runtime.httpProxy, this._httpProxy),
      httpsProxy: Util.defaultString(runtime.httpsProxy, this._httpsProxy),
      noProxy: Util.defaultString(runtime.noProxy, this._noProxy),
      socks5Proxy: Util.defaultString(runtime.socks5Proxy, this._socks5Proxy),
      socks5NetWork: Util.defaultString(runtime.socks5NetWork, this._socks5NetWork),
      maxIdleConns: Util.defaultNumber(runtime.maxIdleConns, this._maxIdleConns),
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: Util.defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: Util.defaultString(runtime.backoffPolicy, "no"),
        period: Util.defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
    }

    let _lastRequest = null;
    let _now = Date.now();
    let _retryTimes = 0;
    while ($tea.allowRetry(_runtime['retry'], _retryTimes, _now)) {
      if (_retryTimes > 0) {
        let _backoffTime = $tea.getBackoffTime(_runtime['backoff'], _retryTimes);
        if (_backoffTime > 0) {
          await $tea.sleep(_backoffTime);
        }
      }

      _retryTimes = _retryTimes + 1;
      try {
        let request_ = new $tea.Request();
        let accessKeyId = await this._credential.getAccessKeyId();
        let accessKeySecret = await this._credential.getAccessKeySecret();
        let token = await this._credential.getSecurityToken();
        request_.protocol = this._protocol;
        request_.method = "GET";
        request_.pathname = `/?requestPayment`;
        request_.headers = {
          host: OSSUtil.getHost(request.bucketName, this._regionId, this._endpoint, this._hostModel),
          date: Util.getDateUTCString(),
          'user-agent': this.getUserAgent(),
        };
        if (!Util.empty(token)) {
          request_.headers["x-oss-security-token"] = token;
        }

        request_.headers["authorization"] = OSSUtil.getSignature(request_, request.bucketName, accessKeyId, accessKeySecret, this._signatureVersion, this._addtionalHeaders);
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap : {[key: string]: any} = null;
        let bodyStr : string = null;
        if (Util.is4xx(response_.statusCode) || Util.is5xx(response_.statusCode)) {
          bodyStr = await Util.readAsString(response_.body);
          respMap = OSSUtil.getErrMessage(bodyStr);
          throw $tea.newError({
            code: respMap["Code"],
            message: respMap["Message"],
            data: {
              httpCode: response_.statusCode,
              requestId: respMap["RequestId"],
              hostId: respMap["HostId"],
            },
          });
        }

        bodyStr = await Util.readAsString(response_.body);
        respMap = XML.parseXml(bodyStr, GetBucketRequestPaymentResponse);
        return $tea.cast<GetBucketRequestPaymentResponse>({
          RequestPaymentConfiguration: respMap["RequestPaymentConfiguration"],
          ...response_.headers,
        }, new GetBucketRequestPaymentResponse({}));
      } catch (ex) {
        if ($tea.isRetryable(ex)) {
          continue;
        }
        throw ex;
      }
    }

    throw $tea.newUnretryableError(_lastRequest);
  }

  async getBucketEncryption(request: GetBucketEncryptionRequest, runtime: $OSSUtil.RuntimeOptions): Promise<GetBucketEncryptionResponse> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: Util.defaultNumber(runtime.readTimeout, this._readTimeout),
      connectTimeout: Util.defaultNumber(runtime.connectTimeout, this._connectTimeout),
      localAddr: Util.defaultString(runtime.localAddr, this._localAddr),
      httpProxy: Util.defaultString(runtime.httpProxy, this._httpProxy),
      httpsProxy: Util.defaultString(runtime.httpsProxy, this._httpsProxy),
      noProxy: Util.defaultString(runtime.noProxy, this._noProxy),
      socks5Proxy: Util.defaultString(runtime.socks5Proxy, this._socks5Proxy),
      socks5NetWork: Util.defaultString(runtime.socks5NetWork, this._socks5NetWork),
      maxIdleConns: Util.defaultNumber(runtime.maxIdleConns, this._maxIdleConns),
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: Util.defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: Util.defaultString(runtime.backoffPolicy, "no"),
        period: Util.defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
    }

    let _lastRequest = null;
    let _now = Date.now();
    let _retryTimes = 0;
    while ($tea.allowRetry(_runtime['retry'], _retryTimes, _now)) {
      if (_retryTimes > 0) {
        let _backoffTime = $tea.getBackoffTime(_runtime['backoff'], _retryTimes);
        if (_backoffTime > 0) {
          await $tea.sleep(_backoffTime);
        }
      }

      _retryTimes = _retryTimes + 1;
      try {
        let request_ = new $tea.Request();
        let accessKeyId = await this._credential.getAccessKeyId();
        let accessKeySecret = await this._credential.getAccessKeySecret();
        let token = await this._credential.getSecurityToken();
        request_.protocol = this._protocol;
        request_.method = "GET";
        request_.pathname = `/?encryption`;
        request_.headers = {
          host: OSSUtil.getHost(request.bucketName, this._regionId, this._endpoint, this._hostModel),
          date: Util.getDateUTCString(),
          'user-agent': this.getUserAgent(),
        };
        if (!Util.empty(token)) {
          request_.headers["x-oss-security-token"] = token;
        }

        request_.headers["authorization"] = OSSUtil.getSignature(request_, request.bucketName, accessKeyId, accessKeySecret, this._signatureVersion, this._addtionalHeaders);
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap : {[key: string]: any} = null;
        let bodyStr : string = null;
        if (Util.is4xx(response_.statusCode) || Util.is5xx(response_.statusCode)) {
          bodyStr = await Util.readAsString(response_.body);
          respMap = OSSUtil.getErrMessage(bodyStr);
          throw $tea.newError({
            code: respMap["Code"],
            message: respMap["Message"],
            data: {
              httpCode: response_.statusCode,
              requestId: respMap["RequestId"],
              hostId: respMap["HostId"],
            },
          });
        }

        bodyStr = await Util.readAsString(response_.body);
        respMap = XML.parseXml(bodyStr, GetBucketEncryptionResponse);
        return $tea.cast<GetBucketEncryptionResponse>({
          ServerSideEncryptionRule: respMap["ServerSideEncryptionRule"],
          ...response_.headers,
        }, new GetBucketEncryptionResponse({}));
      } catch (ex) {
        if ($tea.isRetryable(ex)) {
          continue;
        }
        throw ex;
      }
    }

    throw $tea.newUnretryableError(_lastRequest);
  }

  async getBucketTags(request: GetBucketTagsRequest, runtime: $OSSUtil.RuntimeOptions): Promise<GetBucketTagsResponse> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: Util.defaultNumber(runtime.readTimeout, this._readTimeout),
      connectTimeout: Util.defaultNumber(runtime.connectTimeout, this._connectTimeout),
      localAddr: Util.defaultString(runtime.localAddr, this._localAddr),
      httpProxy: Util.defaultString(runtime.httpProxy, this._httpProxy),
      httpsProxy: Util.defaultString(runtime.httpsProxy, this._httpsProxy),
      noProxy: Util.defaultString(runtime.noProxy, this._noProxy),
      socks5Proxy: Util.defaultString(runtime.socks5Proxy, this._socks5Proxy),
      socks5NetWork: Util.defaultString(runtime.socks5NetWork, this._socks5NetWork),
      maxIdleConns: Util.defaultNumber(runtime.maxIdleConns, this._maxIdleConns),
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: Util.defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: Util.defaultString(runtime.backoffPolicy, "no"),
        period: Util.defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
    }

    let _lastRequest = null;
    let _now = Date.now();
    let _retryTimes = 0;
    while ($tea.allowRetry(_runtime['retry'], _retryTimes, _now)) {
      if (_retryTimes > 0) {
        let _backoffTime = $tea.getBackoffTime(_runtime['backoff'], _retryTimes);
        if (_backoffTime > 0) {
          await $tea.sleep(_backoffTime);
        }
      }

      _retryTimes = _retryTimes + 1;
      try {
        let request_ = new $tea.Request();
        let accessKeyId = await this._credential.getAccessKeyId();
        let accessKeySecret = await this._credential.getAccessKeySecret();
        let token = await this._credential.getSecurityToken();
        request_.protocol = this._protocol;
        request_.method = "GET";
        request_.pathname = `/?tagging`;
        request_.headers = {
          host: OSSUtil.getHost(request.bucketName, this._regionId, this._endpoint, this._hostModel),
          date: Util.getDateUTCString(),
          'user-agent': this.getUserAgent(),
        };
        if (!Util.empty(token)) {
          request_.headers["x-oss-security-token"] = token;
        }

        request_.headers["authorization"] = OSSUtil.getSignature(request_, request.bucketName, accessKeyId, accessKeySecret, this._signatureVersion, this._addtionalHeaders);
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap : {[key: string]: any} = null;
        let bodyStr : string = null;
        if (Util.is4xx(response_.statusCode) || Util.is5xx(response_.statusCode)) {
          bodyStr = await Util.readAsString(response_.body);
          respMap = OSSUtil.getErrMessage(bodyStr);
          throw $tea.newError({
            code: respMap["Code"],
            message: respMap["Message"],
            data: {
              httpCode: response_.statusCode,
              requestId: respMap["RequestId"],
              hostId: respMap["HostId"],
            },
          });
        }

        bodyStr = await Util.readAsString(response_.body);
        respMap = XML.parseXml(bodyStr, GetBucketTagsResponse);
        return $tea.cast<GetBucketTagsResponse>({
          Tagging: respMap["Tagging"],
          ...response_.headers,
        }, new GetBucketTagsResponse({}));
      } catch (ex) {
        if ($tea.isRetryable(ex)) {
          continue;
        }
        throw ex;
      }
    }

    throw $tea.newUnretryableError(_lastRequest);
  }

  async getService(request: GetServiceRequest, runtime: $OSSUtil.RuntimeOptions): Promise<GetServiceResponse> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: Util.defaultNumber(runtime.readTimeout, this._readTimeout),
      connectTimeout: Util.defaultNumber(runtime.connectTimeout, this._connectTimeout),
      localAddr: Util.defaultString(runtime.localAddr, this._localAddr),
      httpProxy: Util.defaultString(runtime.httpProxy, this._httpProxy),
      httpsProxy: Util.defaultString(runtime.httpsProxy, this._httpsProxy),
      noProxy: Util.defaultString(runtime.noProxy, this._noProxy),
      socks5Proxy: Util.defaultString(runtime.socks5Proxy, this._socks5Proxy),
      socks5NetWork: Util.defaultString(runtime.socks5NetWork, this._socks5NetWork),
      maxIdleConns: Util.defaultNumber(runtime.maxIdleConns, this._maxIdleConns),
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: Util.defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: Util.defaultString(runtime.backoffPolicy, "no"),
        period: Util.defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
    }

    let _lastRequest = null;
    let _now = Date.now();
    let _retryTimes = 0;
    while ($tea.allowRetry(_runtime['retry'], _retryTimes, _now)) {
      if (_retryTimes > 0) {
        let _backoffTime = $tea.getBackoffTime(_runtime['backoff'], _retryTimes);
        if (_backoffTime > 0) {
          await $tea.sleep(_backoffTime);
        }
      }

      _retryTimes = _retryTimes + 1;
      try {
        let request_ = new $tea.Request();
        let accessKeyId = await this._credential.getAccessKeyId();
        let accessKeySecret = await this._credential.getAccessKeySecret();
        let token = await this._credential.getSecurityToken();
        request_.protocol = this._protocol;
        request_.method = "GET";
        request_.pathname = `/`;
        request_.headers = {
          host: OSSUtil.getHost("", this._regionId, this._endpoint, this._hostModel),
          date: Util.getDateUTCString(),
          'user-agent': this.getUserAgent(),
        };
        if (!Util.empty(token)) {
          request_.headers["x-oss-security-token"] = token;
        }

        request_.query = Util.stringifyMapValue($tea.toMap(request.filter));
        request_.headers["authorization"] = OSSUtil.getSignature(request_, "", accessKeyId, accessKeySecret, this._signatureVersion, this._addtionalHeaders);
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap : {[key: string]: any} = null;
        let bodyStr : string = null;
        if (Util.is4xx(response_.statusCode) || Util.is5xx(response_.statusCode)) {
          bodyStr = await Util.readAsString(response_.body);
          respMap = OSSUtil.getErrMessage(bodyStr);
          throw $tea.newError({
            code: respMap["Code"],
            message: respMap["Message"],
            data: {
              httpCode: response_.statusCode,
              requestId: respMap["RequestId"],
              hostId: respMap["HostId"],
            },
          });
        }

        bodyStr = await Util.readAsString(response_.body);
        respMap = XML.parseXml(bodyStr, GetServiceResponse);
        return $tea.cast<GetServiceResponse>({
          ListAllMyBucketsResult: respMap["ListAllMyBucketsResult"],
          ...response_.headers,
        }, new GetServiceResponse({}));
      } catch (ex) {
        if ($tea.isRetryable(ex)) {
          continue;
        }
        throw ex;
      }
    }

    throw $tea.newUnretryableError(_lastRequest);
  }

  async deleteBucketEncryption(request: DeleteBucketEncryptionRequest, runtime: $OSSUtil.RuntimeOptions): Promise<DeleteBucketEncryptionResponse> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: Util.defaultNumber(runtime.readTimeout, this._readTimeout),
      connectTimeout: Util.defaultNumber(runtime.connectTimeout, this._connectTimeout),
      localAddr: Util.defaultString(runtime.localAddr, this._localAddr),
      httpProxy: Util.defaultString(runtime.httpProxy, this._httpProxy),
      httpsProxy: Util.defaultString(runtime.httpsProxy, this._httpsProxy),
      noProxy: Util.defaultString(runtime.noProxy, this._noProxy),
      socks5Proxy: Util.defaultString(runtime.socks5Proxy, this._socks5Proxy),
      socks5NetWork: Util.defaultString(runtime.socks5NetWork, this._socks5NetWork),
      maxIdleConns: Util.defaultNumber(runtime.maxIdleConns, this._maxIdleConns),
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: Util.defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: Util.defaultString(runtime.backoffPolicy, "no"),
        period: Util.defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
    }

    let _lastRequest = null;
    let _now = Date.now();
    let _retryTimes = 0;
    while ($tea.allowRetry(_runtime['retry'], _retryTimes, _now)) {
      if (_retryTimes > 0) {
        let _backoffTime = $tea.getBackoffTime(_runtime['backoff'], _retryTimes);
        if (_backoffTime > 0) {
          await $tea.sleep(_backoffTime);
        }
      }

      _retryTimes = _retryTimes + 1;
      try {
        let request_ = new $tea.Request();
        let accessKeyId = await this._credential.getAccessKeyId();
        let accessKeySecret = await this._credential.getAccessKeySecret();
        let token = await this._credential.getSecurityToken();
        request_.protocol = this._protocol;
        request_.method = "DELETE";
        request_.pathname = `/?encryption`;
        request_.headers = {
          host: OSSUtil.getHost(request.bucketName, this._regionId, this._endpoint, this._hostModel),
          date: Util.getDateUTCString(),
          'user-agent': this.getUserAgent(),
        };
        if (!Util.empty(token)) {
          request_.headers["x-oss-security-token"] = token;
        }

        request_.headers["authorization"] = OSSUtil.getSignature(request_, request.bucketName, accessKeyId, accessKeySecret, this._signatureVersion, this._addtionalHeaders);
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap : {[key: string]: any} = null;
        let bodyStr : string = null;
        if (Util.is4xx(response_.statusCode) || Util.is5xx(response_.statusCode)) {
          bodyStr = await Util.readAsString(response_.body);
          respMap = OSSUtil.getErrMessage(bodyStr);
          throw $tea.newError({
            code: respMap["Code"],
            message: respMap["Message"],
            data: {
              httpCode: response_.statusCode,
              requestId: respMap["RequestId"],
              hostId: respMap["HostId"],
            },
          });
        }

        return $tea.cast<DeleteBucketEncryptionResponse>({
          ...response_.headers,
        }, new DeleteBucketEncryptionResponse({}));
      } catch (ex) {
        if ($tea.isRetryable(ex)) {
          continue;
        }
        throw ex;
      }
    }

    throw $tea.newUnretryableError(_lastRequest);
  }

  async deleteBucketTags(request: DeleteBucketTagsRequest, runtime: $OSSUtil.RuntimeOptions): Promise<DeleteBucketTagsResponse> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: Util.defaultNumber(runtime.readTimeout, this._readTimeout),
      connectTimeout: Util.defaultNumber(runtime.connectTimeout, this._connectTimeout),
      localAddr: Util.defaultString(runtime.localAddr, this._localAddr),
      httpProxy: Util.defaultString(runtime.httpProxy, this._httpProxy),
      httpsProxy: Util.defaultString(runtime.httpsProxy, this._httpsProxy),
      noProxy: Util.defaultString(runtime.noProxy, this._noProxy),
      socks5Proxy: Util.defaultString(runtime.socks5Proxy, this._socks5Proxy),
      socks5NetWork: Util.defaultString(runtime.socks5NetWork, this._socks5NetWork),
      maxIdleConns: Util.defaultNumber(runtime.maxIdleConns, this._maxIdleConns),
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: Util.defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: Util.defaultString(runtime.backoffPolicy, "no"),
        period: Util.defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
    }

    let _lastRequest = null;
    let _now = Date.now();
    let _retryTimes = 0;
    while ($tea.allowRetry(_runtime['retry'], _retryTimes, _now)) {
      if (_retryTimes > 0) {
        let _backoffTime = $tea.getBackoffTime(_runtime['backoff'], _retryTimes);
        if (_backoffTime > 0) {
          await $tea.sleep(_backoffTime);
        }
      }

      _retryTimes = _retryTimes + 1;
      try {
        let request_ = new $tea.Request();
        let accessKeyId = await this._credential.getAccessKeyId();
        let accessKeySecret = await this._credential.getAccessKeySecret();
        let token = await this._credential.getSecurityToken();
        request_.protocol = this._protocol;
        request_.method = "DELETE";
        request_.pathname = `/`;
        request_.headers = {
          host: OSSUtil.getHost(request.bucketName, this._regionId, this._endpoint, this._hostModel),
          date: Util.getDateUTCString(),
          'user-agent': this.getUserAgent(),
        };
        if (!Util.empty(token)) {
          request_.headers["x-oss-security-token"] = token;
        }

        request_.query = Util.stringifyMapValue($tea.toMap(request.filter));
        request_.headers["authorization"] = OSSUtil.getSignature(request_, request.bucketName, accessKeyId, accessKeySecret, this._signatureVersion, this._addtionalHeaders);
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap : {[key: string]: any} = null;
        let bodyStr : string = null;
        if (Util.is4xx(response_.statusCode) || Util.is5xx(response_.statusCode)) {
          bodyStr = await Util.readAsString(response_.body);
          respMap = OSSUtil.getErrMessage(bodyStr);
          throw $tea.newError({
            code: respMap["Code"],
            message: respMap["Message"],
            data: {
              httpCode: response_.statusCode,
              requestId: respMap["RequestId"],
              hostId: respMap["HostId"],
            },
          });
        }

        return $tea.cast<DeleteBucketTagsResponse>({
          ...response_.headers,
        }, new DeleteBucketTagsResponse({}));
      } catch (ex) {
        if ($tea.isRetryable(ex)) {
          continue;
        }
        throw ex;
      }
    }

    throw $tea.newUnretryableError(_lastRequest);
  }

  async getBucketWebsite(request: GetBucketWebsiteRequest, runtime: $OSSUtil.RuntimeOptions): Promise<GetBucketWebsiteResponse> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: Util.defaultNumber(runtime.readTimeout, this._readTimeout),
      connectTimeout: Util.defaultNumber(runtime.connectTimeout, this._connectTimeout),
      localAddr: Util.defaultString(runtime.localAddr, this._localAddr),
      httpProxy: Util.defaultString(runtime.httpProxy, this._httpProxy),
      httpsProxy: Util.defaultString(runtime.httpsProxy, this._httpsProxy),
      noProxy: Util.defaultString(runtime.noProxy, this._noProxy),
      socks5Proxy: Util.defaultString(runtime.socks5Proxy, this._socks5Proxy),
      socks5NetWork: Util.defaultString(runtime.socks5NetWork, this._socks5NetWork),
      maxIdleConns: Util.defaultNumber(runtime.maxIdleConns, this._maxIdleConns),
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: Util.defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: Util.defaultString(runtime.backoffPolicy, "no"),
        period: Util.defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
    }

    let _lastRequest = null;
    let _now = Date.now();
    let _retryTimes = 0;
    while ($tea.allowRetry(_runtime['retry'], _retryTimes, _now)) {
      if (_retryTimes > 0) {
        let _backoffTime = $tea.getBackoffTime(_runtime['backoff'], _retryTimes);
        if (_backoffTime > 0) {
          await $tea.sleep(_backoffTime);
        }
      }

      _retryTimes = _retryTimes + 1;
      try {
        let request_ = new $tea.Request();
        let accessKeyId = await this._credential.getAccessKeyId();
        let accessKeySecret = await this._credential.getAccessKeySecret();
        let token = await this._credential.getSecurityToken();
        request_.protocol = this._protocol;
        request_.method = "GET";
        request_.pathname = `/?website`;
        request_.headers = {
          host: OSSUtil.getHost(request.bucketName, this._regionId, this._endpoint, this._hostModel),
          date: Util.getDateUTCString(),
          'user-agent': this.getUserAgent(),
        };
        if (!Util.empty(token)) {
          request_.headers["x-oss-security-token"] = token;
        }

        request_.headers["authorization"] = OSSUtil.getSignature(request_, request.bucketName, accessKeyId, accessKeySecret, this._signatureVersion, this._addtionalHeaders);
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap : {[key: string]: any} = null;
        let bodyStr : string = null;
        if (Util.is4xx(response_.statusCode) || Util.is5xx(response_.statusCode)) {
          bodyStr = await Util.readAsString(response_.body);
          respMap = OSSUtil.getErrMessage(bodyStr);
          throw $tea.newError({
            code: respMap["Code"],
            message: respMap["Message"],
            data: {
              httpCode: response_.statusCode,
              requestId: respMap["RequestId"],
              hostId: respMap["HostId"],
            },
          });
        }

        bodyStr = await Util.readAsString(response_.body);
        respMap = XML.parseXml(bodyStr, GetBucketWebsiteResponse);
        return $tea.cast<GetBucketWebsiteResponse>({
          WebsiteConfiguration: respMap["WebsiteConfiguration"],
          ...response_.headers,
        }, new GetBucketWebsiteResponse({}));
      } catch (ex) {
        if ($tea.isRetryable(ex)) {
          continue;
        }
        throw ex;
      }
    }

    throw $tea.newUnretryableError(_lastRequest);
  }

  async deleteLiveChannel(request: DeleteLiveChannelRequest, runtime: $OSSUtil.RuntimeOptions): Promise<DeleteLiveChannelResponse> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: Util.defaultNumber(runtime.readTimeout, this._readTimeout),
      connectTimeout: Util.defaultNumber(runtime.connectTimeout, this._connectTimeout),
      localAddr: Util.defaultString(runtime.localAddr, this._localAddr),
      httpProxy: Util.defaultString(runtime.httpProxy, this._httpProxy),
      httpsProxy: Util.defaultString(runtime.httpsProxy, this._httpsProxy),
      noProxy: Util.defaultString(runtime.noProxy, this._noProxy),
      socks5Proxy: Util.defaultString(runtime.socks5Proxy, this._socks5Proxy),
      socks5NetWork: Util.defaultString(runtime.socks5NetWork, this._socks5NetWork),
      maxIdleConns: Util.defaultNumber(runtime.maxIdleConns, this._maxIdleConns),
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: Util.defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: Util.defaultString(runtime.backoffPolicy, "no"),
        period: Util.defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
    }

    let _lastRequest = null;
    let _now = Date.now();
    let _retryTimes = 0;
    while ($tea.allowRetry(_runtime['retry'], _retryTimes, _now)) {
      if (_retryTimes > 0) {
        let _backoffTime = $tea.getBackoffTime(_runtime['backoff'], _retryTimes);
        if (_backoffTime > 0) {
          await $tea.sleep(_backoffTime);
        }
      }

      _retryTimes = _retryTimes + 1;
      try {
        let request_ = new $tea.Request();
        let accessKeyId = await this._credential.getAccessKeyId();
        let accessKeySecret = await this._credential.getAccessKeySecret();
        let token = await this._credential.getSecurityToken();
        request_.protocol = this._protocol;
        request_.method = "DELETE";
        request_.pathname = `/${request.channelName}?live`;
        request_.headers = {
          host: OSSUtil.getHost(request.bucketName, this._regionId, this._endpoint, this._hostModel),
          date: Util.getDateUTCString(),
          'user-agent': this.getUserAgent(),
        };
        if (!Util.empty(token)) {
          request_.headers["x-oss-security-token"] = token;
        }

        request_.headers["authorization"] = OSSUtil.getSignature(request_, request.bucketName, accessKeyId, accessKeySecret, this._signatureVersion, this._addtionalHeaders);
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap : {[key: string]: any} = null;
        let bodyStr : string = null;
        if (Util.is4xx(response_.statusCode) || Util.is5xx(response_.statusCode)) {
          bodyStr = await Util.readAsString(response_.body);
          respMap = OSSUtil.getErrMessage(bodyStr);
          throw $tea.newError({
            code: respMap["Code"],
            message: respMap["Message"],
            data: {
              httpCode: response_.statusCode,
              requestId: respMap["RequestId"],
              hostId: respMap["HostId"],
            },
          });
        }

        return $tea.cast<DeleteLiveChannelResponse>({
          ...response_.headers,
        }, new DeleteLiveChannelResponse({}));
      } catch (ex) {
        if ($tea.isRetryable(ex)) {
          continue;
        }
        throw ex;
      }
    }

    throw $tea.newUnretryableError(_lastRequest);
  }

  async getBucketLocation(request: GetBucketLocationRequest, runtime: $OSSUtil.RuntimeOptions): Promise<GetBucketLocationResponse> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: Util.defaultNumber(runtime.readTimeout, this._readTimeout),
      connectTimeout: Util.defaultNumber(runtime.connectTimeout, this._connectTimeout),
      localAddr: Util.defaultString(runtime.localAddr, this._localAddr),
      httpProxy: Util.defaultString(runtime.httpProxy, this._httpProxy),
      httpsProxy: Util.defaultString(runtime.httpsProxy, this._httpsProxy),
      noProxy: Util.defaultString(runtime.noProxy, this._noProxy),
      socks5Proxy: Util.defaultString(runtime.socks5Proxy, this._socks5Proxy),
      socks5NetWork: Util.defaultString(runtime.socks5NetWork, this._socks5NetWork),
      maxIdleConns: Util.defaultNumber(runtime.maxIdleConns, this._maxIdleConns),
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: Util.defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: Util.defaultString(runtime.backoffPolicy, "no"),
        period: Util.defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
    }

    let _lastRequest = null;
    let _now = Date.now();
    let _retryTimes = 0;
    while ($tea.allowRetry(_runtime['retry'], _retryTimes, _now)) {
      if (_retryTimes > 0) {
        let _backoffTime = $tea.getBackoffTime(_runtime['backoff'], _retryTimes);
        if (_backoffTime > 0) {
          await $tea.sleep(_backoffTime);
        }
      }

      _retryTimes = _retryTimes + 1;
      try {
        let request_ = new $tea.Request();
        let accessKeyId = await this._credential.getAccessKeyId();
        let accessKeySecret = await this._credential.getAccessKeySecret();
        let token = await this._credential.getSecurityToken();
        request_.protocol = this._protocol;
        request_.method = "GET";
        request_.pathname = `/?location`;
        request_.headers = {
          host: OSSUtil.getHost(request.bucketName, this._regionId, this._endpoint, this._hostModel),
          date: Util.getDateUTCString(),
          'user-agent': this.getUserAgent(),
        };
        if (!Util.empty(token)) {
          request_.headers["x-oss-security-token"] = token;
        }

        request_.headers["authorization"] = OSSUtil.getSignature(request_, request.bucketName, accessKeyId, accessKeySecret, this._signatureVersion, this._addtionalHeaders);
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap : {[key: string]: any} = null;
        let bodyStr : string = null;
        if (Util.is4xx(response_.statusCode) || Util.is5xx(response_.statusCode)) {
          bodyStr = await Util.readAsString(response_.body);
          respMap = OSSUtil.getErrMessage(bodyStr);
          throw $tea.newError({
            code: respMap["Code"],
            message: respMap["Message"],
            data: {
              httpCode: response_.statusCode,
              requestId: respMap["RequestId"],
              hostId: respMap["HostId"],
            },
          });
        }

        bodyStr = await Util.readAsString(response_.body);
        respMap = XML.parseXml(bodyStr, GetBucketLocationResponse);
        return $tea.cast<GetBucketLocationResponse>({
          LocationConstraint: respMap["LocationConstraint"],
          ...response_.headers,
        }, new GetBucketLocationResponse({}));
      } catch (ex) {
        if ($tea.isRetryable(ex)) {
          continue;
        }
        throw ex;
      }
    }

    throw $tea.newUnretryableError(_lastRequest);
  }

  async listLiveChannel(request: ListLiveChannelRequest, runtime: $OSSUtil.RuntimeOptions): Promise<ListLiveChannelResponse> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: Util.defaultNumber(runtime.readTimeout, this._readTimeout),
      connectTimeout: Util.defaultNumber(runtime.connectTimeout, this._connectTimeout),
      localAddr: Util.defaultString(runtime.localAddr, this._localAddr),
      httpProxy: Util.defaultString(runtime.httpProxy, this._httpProxy),
      httpsProxy: Util.defaultString(runtime.httpsProxy, this._httpsProxy),
      noProxy: Util.defaultString(runtime.noProxy, this._noProxy),
      socks5Proxy: Util.defaultString(runtime.socks5Proxy, this._socks5Proxy),
      socks5NetWork: Util.defaultString(runtime.socks5NetWork, this._socks5NetWork),
      maxIdleConns: Util.defaultNumber(runtime.maxIdleConns, this._maxIdleConns),
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: Util.defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: Util.defaultString(runtime.backoffPolicy, "no"),
        period: Util.defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
    }

    let _lastRequest = null;
    let _now = Date.now();
    let _retryTimes = 0;
    while ($tea.allowRetry(_runtime['retry'], _retryTimes, _now)) {
      if (_retryTimes > 0) {
        let _backoffTime = $tea.getBackoffTime(_runtime['backoff'], _retryTimes);
        if (_backoffTime > 0) {
          await $tea.sleep(_backoffTime);
        }
      }

      _retryTimes = _retryTimes + 1;
      try {
        let request_ = new $tea.Request();
        let accessKeyId = await this._credential.getAccessKeyId();
        let accessKeySecret = await this._credential.getAccessKeySecret();
        let token = await this._credential.getSecurityToken();
        request_.protocol = this._protocol;
        request_.method = "GET";
        request_.pathname = `/?live`;
        request_.headers = {
          host: OSSUtil.getHost(request.bucketName, this._regionId, this._endpoint, this._hostModel),
          date: Util.getDateUTCString(),
          'user-agent': this.getUserAgent(),
        };
        if (!Util.empty(token)) {
          request_.headers["x-oss-security-token"] = token;
        }

        request_.query = Util.stringifyMapValue($tea.toMap(request.filter));
        request_.headers["authorization"] = OSSUtil.getSignature(request_, request.bucketName, accessKeyId, accessKeySecret, this._signatureVersion, this._addtionalHeaders);
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap : {[key: string]: any} = null;
        let bodyStr : string = null;
        if (Util.is4xx(response_.statusCode) || Util.is5xx(response_.statusCode)) {
          bodyStr = await Util.readAsString(response_.body);
          respMap = OSSUtil.getErrMessage(bodyStr);
          throw $tea.newError({
            code: respMap["Code"],
            message: respMap["Message"],
            data: {
              httpCode: response_.statusCode,
              requestId: respMap["RequestId"],
              hostId: respMap["HostId"],
            },
          });
        }

        bodyStr = await Util.readAsString(response_.body);
        respMap = XML.parseXml(bodyStr, ListLiveChannelResponse);
        return $tea.cast<ListLiveChannelResponse>({
          ListLiveChannelResult: respMap["ListLiveChannelResult"],
          ...response_.headers,
        }, new ListLiveChannelResponse({}));
      } catch (ex) {
        if ($tea.isRetryable(ex)) {
          continue;
        }
        throw ex;
      }
    }

    throw $tea.newUnretryableError(_lastRequest);
  }

  async getObjectMeta(request: GetObjectMetaRequest, runtime: $OSSUtil.RuntimeOptions): Promise<GetObjectMetaResponse> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: Util.defaultNumber(runtime.readTimeout, this._readTimeout),
      connectTimeout: Util.defaultNumber(runtime.connectTimeout, this._connectTimeout),
      localAddr: Util.defaultString(runtime.localAddr, this._localAddr),
      httpProxy: Util.defaultString(runtime.httpProxy, this._httpProxy),
      httpsProxy: Util.defaultString(runtime.httpsProxy, this._httpsProxy),
      noProxy: Util.defaultString(runtime.noProxy, this._noProxy),
      socks5Proxy: Util.defaultString(runtime.socks5Proxy, this._socks5Proxy),
      socks5NetWork: Util.defaultString(runtime.socks5NetWork, this._socks5NetWork),
      maxIdleConns: Util.defaultNumber(runtime.maxIdleConns, this._maxIdleConns),
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: Util.defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: Util.defaultString(runtime.backoffPolicy, "no"),
        period: Util.defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
    }

    let _lastRequest = null;
    let _now = Date.now();
    let _retryTimes = 0;
    while ($tea.allowRetry(_runtime['retry'], _retryTimes, _now)) {
      if (_retryTimes > 0) {
        let _backoffTime = $tea.getBackoffTime(_runtime['backoff'], _retryTimes);
        if (_backoffTime > 0) {
          await $tea.sleep(_backoffTime);
        }
      }

      _retryTimes = _retryTimes + 1;
      try {
        let request_ = new $tea.Request();
        let accessKeyId = await this._credential.getAccessKeyId();
        let accessKeySecret = await this._credential.getAccessKeySecret();
        let token = await this._credential.getSecurityToken();
        request_.protocol = this._protocol;
        request_.method = "HEAD";
        request_.pathname = `/${request.objectName}?objectMeta`;
        request_.headers = {
          host: OSSUtil.getHost(request.bucketName, this._regionId, this._endpoint, this._hostModel),
          date: Util.getDateUTCString(),
          'user-agent': this.getUserAgent(),
        };
        if (!Util.empty(token)) {
          request_.headers["x-oss-security-token"] = token;
        }

        request_.headers["authorization"] = OSSUtil.getSignature(request_, request.bucketName, accessKeyId, accessKeySecret, this._signatureVersion, this._addtionalHeaders);
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap : {[key: string]: any} = null;
        let bodyStr : string = null;
        if (Util.is4xx(response_.statusCode) || Util.is5xx(response_.statusCode)) {
          bodyStr = await Util.readAsString(response_.body);
          respMap = OSSUtil.getErrMessage(bodyStr);
          throw $tea.newError({
            code: respMap["Code"],
            message: respMap["Message"],
            data: {
              httpCode: response_.statusCode,
              requestId: respMap["RequestId"],
              hostId: respMap["HostId"],
            },
          });
        }

        return $tea.cast<GetObjectMetaResponse>({
          ...response_.headers,
        }, new GetObjectMetaResponse({}));
      } catch (ex) {
        if ($tea.isRetryable(ex)) {
          continue;
        }
        throw ex;
      }
    }

    throw $tea.newUnretryableError(_lastRequest);
  }

  async getBucketAcl(request: GetBucketAclRequest, runtime: $OSSUtil.RuntimeOptions): Promise<GetBucketAclResponse> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: Util.defaultNumber(runtime.readTimeout, this._readTimeout),
      connectTimeout: Util.defaultNumber(runtime.connectTimeout, this._connectTimeout),
      localAddr: Util.defaultString(runtime.localAddr, this._localAddr),
      httpProxy: Util.defaultString(runtime.httpProxy, this._httpProxy),
      httpsProxy: Util.defaultString(runtime.httpsProxy, this._httpsProxy),
      noProxy: Util.defaultString(runtime.noProxy, this._noProxy),
      socks5Proxy: Util.defaultString(runtime.socks5Proxy, this._socks5Proxy),
      socks5NetWork: Util.defaultString(runtime.socks5NetWork, this._socks5NetWork),
      maxIdleConns: Util.defaultNumber(runtime.maxIdleConns, this._maxIdleConns),
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: Util.defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: Util.defaultString(runtime.backoffPolicy, "no"),
        period: Util.defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
    }

    let _lastRequest = null;
    let _now = Date.now();
    let _retryTimes = 0;
    while ($tea.allowRetry(_runtime['retry'], _retryTimes, _now)) {
      if (_retryTimes > 0) {
        let _backoffTime = $tea.getBackoffTime(_runtime['backoff'], _retryTimes);
        if (_backoffTime > 0) {
          await $tea.sleep(_backoffTime);
        }
      }

      _retryTimes = _retryTimes + 1;
      try {
        let request_ = new $tea.Request();
        let accessKeyId = await this._credential.getAccessKeyId();
        let accessKeySecret = await this._credential.getAccessKeySecret();
        let token = await this._credential.getSecurityToken();
        request_.protocol = this._protocol;
        request_.method = "GET";
        request_.pathname = `/?acl`;
        request_.headers = {
          host: OSSUtil.getHost(request.bucketName, this._regionId, this._endpoint, this._hostModel),
          date: Util.getDateUTCString(),
          'user-agent': this.getUserAgent(),
        };
        if (!Util.empty(token)) {
          request_.headers["x-oss-security-token"] = token;
        }

        request_.headers["authorization"] = OSSUtil.getSignature(request_, request.bucketName, accessKeyId, accessKeySecret, this._signatureVersion, this._addtionalHeaders);
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap : {[key: string]: any} = null;
        let bodyStr : string = null;
        if (Util.is4xx(response_.statusCode) || Util.is5xx(response_.statusCode)) {
          bodyStr = await Util.readAsString(response_.body);
          respMap = OSSUtil.getErrMessage(bodyStr);
          throw $tea.newError({
            code: respMap["Code"],
            message: respMap["Message"],
            data: {
              httpCode: response_.statusCode,
              requestId: respMap["RequestId"],
              hostId: respMap["HostId"],
            },
          });
        }

        bodyStr = await Util.readAsString(response_.body);
        respMap = XML.parseXml(bodyStr, GetBucketAclResponse);
        return $tea.cast<GetBucketAclResponse>({
          AccessControlPolicy: respMap["AccessControlPolicy"],
          ...response_.headers,
        }, new GetBucketAclResponse({}));
      } catch (ex) {
        if ($tea.isRetryable(ex)) {
          continue;
        }
        throw ex;
      }
    }

    throw $tea.newUnretryableError(_lastRequest);
  }

  async listParts(request: ListPartsRequest, runtime: $OSSUtil.RuntimeOptions): Promise<ListPartsResponse> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: Util.defaultNumber(runtime.readTimeout, this._readTimeout),
      connectTimeout: Util.defaultNumber(runtime.connectTimeout, this._connectTimeout),
      localAddr: Util.defaultString(runtime.localAddr, this._localAddr),
      httpProxy: Util.defaultString(runtime.httpProxy, this._httpProxy),
      httpsProxy: Util.defaultString(runtime.httpsProxy, this._httpsProxy),
      noProxy: Util.defaultString(runtime.noProxy, this._noProxy),
      socks5Proxy: Util.defaultString(runtime.socks5Proxy, this._socks5Proxy),
      socks5NetWork: Util.defaultString(runtime.socks5NetWork, this._socks5NetWork),
      maxIdleConns: Util.defaultNumber(runtime.maxIdleConns, this._maxIdleConns),
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: Util.defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: Util.defaultString(runtime.backoffPolicy, "no"),
        period: Util.defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
    }

    let _lastRequest = null;
    let _now = Date.now();
    let _retryTimes = 0;
    while ($tea.allowRetry(_runtime['retry'], _retryTimes, _now)) {
      if (_retryTimes > 0) {
        let _backoffTime = $tea.getBackoffTime(_runtime['backoff'], _retryTimes);
        if (_backoffTime > 0) {
          await $tea.sleep(_backoffTime);
        }
      }

      _retryTimes = _retryTimes + 1;
      try {
        let request_ = new $tea.Request();
        let accessKeyId = await this._credential.getAccessKeyId();
        let accessKeySecret = await this._credential.getAccessKeySecret();
        let token = await this._credential.getSecurityToken();
        request_.protocol = this._protocol;
        request_.method = "GET";
        request_.pathname = `/${request.objectName}`;
        request_.headers = {
          host: OSSUtil.getHost(request.bucketName, this._regionId, this._endpoint, this._hostModel),
          date: Util.getDateUTCString(),
          'user-agent': this.getUserAgent(),
        };
        if (!Util.empty(token)) {
          request_.headers["x-oss-security-token"] = token;
        }

        request_.query = Util.stringifyMapValue($tea.toMap(request.filter));
        request_.headers["authorization"] = OSSUtil.getSignature(request_, request.bucketName, accessKeyId, accessKeySecret, this._signatureVersion, this._addtionalHeaders);
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap : {[key: string]: any} = null;
        let bodyStr : string = null;
        if (Util.is4xx(response_.statusCode) || Util.is5xx(response_.statusCode)) {
          bodyStr = await Util.readAsString(response_.body);
          respMap = OSSUtil.getErrMessage(bodyStr);
          throw $tea.newError({
            code: respMap["Code"],
            message: respMap["Message"],
            data: {
              httpCode: response_.statusCode,
              requestId: respMap["RequestId"],
              hostId: respMap["HostId"],
            },
          });
        }

        bodyStr = await Util.readAsString(response_.body);
        respMap = XML.parseXml(bodyStr, ListPartsResponse);
        return $tea.cast<ListPartsResponse>({
          ListPartsResult: respMap["ListPartsResult"],
          ...response_.headers,
        }, new ListPartsResponse({}));
      } catch (ex) {
        if ($tea.isRetryable(ex)) {
          continue;
        }
        throw ex;
      }
    }

    throw $tea.newUnretryableError(_lastRequest);
  }

  async getLiveChannelHistory(request: GetLiveChannelHistoryRequest, runtime: $OSSUtil.RuntimeOptions): Promise<GetLiveChannelHistoryResponse> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: Util.defaultNumber(runtime.readTimeout, this._readTimeout),
      connectTimeout: Util.defaultNumber(runtime.connectTimeout, this._connectTimeout),
      localAddr: Util.defaultString(runtime.localAddr, this._localAddr),
      httpProxy: Util.defaultString(runtime.httpProxy, this._httpProxy),
      httpsProxy: Util.defaultString(runtime.httpsProxy, this._httpsProxy),
      noProxy: Util.defaultString(runtime.noProxy, this._noProxy),
      socks5Proxy: Util.defaultString(runtime.socks5Proxy, this._socks5Proxy),
      socks5NetWork: Util.defaultString(runtime.socks5NetWork, this._socks5NetWork),
      maxIdleConns: Util.defaultNumber(runtime.maxIdleConns, this._maxIdleConns),
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: Util.defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: Util.defaultString(runtime.backoffPolicy, "no"),
        period: Util.defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
    }

    let _lastRequest = null;
    let _now = Date.now();
    let _retryTimes = 0;
    while ($tea.allowRetry(_runtime['retry'], _retryTimes, _now)) {
      if (_retryTimes > 0) {
        let _backoffTime = $tea.getBackoffTime(_runtime['backoff'], _retryTimes);
        if (_backoffTime > 0) {
          await $tea.sleep(_backoffTime);
        }
      }

      _retryTimes = _retryTimes + 1;
      try {
        let request_ = new $tea.Request();
        let accessKeyId = await this._credential.getAccessKeyId();
        let accessKeySecret = await this._credential.getAccessKeySecret();
        let token = await this._credential.getSecurityToken();
        request_.protocol = this._protocol;
        request_.method = "GET";
        request_.pathname = `/${request.channelName}?live`;
        request_.headers = {
          host: OSSUtil.getHost(request.bucketName, this._regionId, this._endpoint, this._hostModel),
          date: Util.getDateUTCString(),
          'user-agent': this.getUserAgent(),
        };
        if (!Util.empty(token)) {
          request_.headers["x-oss-security-token"] = token;
        }

        request_.query = Util.stringifyMapValue($tea.toMap(request.filter));
        request_.headers["authorization"] = OSSUtil.getSignature(request_, request.bucketName, accessKeyId, accessKeySecret, this._signatureVersion, this._addtionalHeaders);
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap : {[key: string]: any} = null;
        let bodyStr : string = null;
        if (Util.is4xx(response_.statusCode) || Util.is5xx(response_.statusCode)) {
          bodyStr = await Util.readAsString(response_.body);
          respMap = OSSUtil.getErrMessage(bodyStr);
          throw $tea.newError({
            code: respMap["Code"],
            message: respMap["Message"],
            data: {
              httpCode: response_.statusCode,
              requestId: respMap["RequestId"],
              hostId: respMap["HostId"],
            },
          });
        }

        bodyStr = await Util.readAsString(response_.body);
        respMap = XML.parseXml(bodyStr, GetLiveChannelHistoryResponse);
        return $tea.cast<GetLiveChannelHistoryResponse>({
          LiveChannelHistory: respMap["LiveChannelHistory"],
          ...response_.headers,
        }, new GetLiveChannelHistoryResponse({}));
      } catch (ex) {
        if ($tea.isRetryable(ex)) {
          continue;
        }
        throw ex;
      }
    }

    throw $tea.newUnretryableError(_lastRequest);
  }

  async getBucket(request: GetBucketRequest, runtime: $OSSUtil.RuntimeOptions): Promise<GetBucketResponse> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: Util.defaultNumber(runtime.readTimeout, this._readTimeout),
      connectTimeout: Util.defaultNumber(runtime.connectTimeout, this._connectTimeout),
      localAddr: Util.defaultString(runtime.localAddr, this._localAddr),
      httpProxy: Util.defaultString(runtime.httpProxy, this._httpProxy),
      httpsProxy: Util.defaultString(runtime.httpsProxy, this._httpsProxy),
      noProxy: Util.defaultString(runtime.noProxy, this._noProxy),
      socks5Proxy: Util.defaultString(runtime.socks5Proxy, this._socks5Proxy),
      socks5NetWork: Util.defaultString(runtime.socks5NetWork, this._socks5NetWork),
      maxIdleConns: Util.defaultNumber(runtime.maxIdleConns, this._maxIdleConns),
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: Util.defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: Util.defaultString(runtime.backoffPolicy, "no"),
        period: Util.defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
    }

    let _lastRequest = null;
    let _now = Date.now();
    let _retryTimes = 0;
    while ($tea.allowRetry(_runtime['retry'], _retryTimes, _now)) {
      if (_retryTimes > 0) {
        let _backoffTime = $tea.getBackoffTime(_runtime['backoff'], _retryTimes);
        if (_backoffTime > 0) {
          await $tea.sleep(_backoffTime);
        }
      }

      _retryTimes = _retryTimes + 1;
      try {
        let request_ = new $tea.Request();
        let accessKeyId = await this._credential.getAccessKeyId();
        let accessKeySecret = await this._credential.getAccessKeySecret();
        let token = await this._credential.getSecurityToken();
        request_.protocol = this._protocol;
        request_.method = "GET";
        request_.pathname = `/`;
        request_.headers = {
          host: OSSUtil.getHost(request.bucketName, this._regionId, this._endpoint, this._hostModel),
          date: Util.getDateUTCString(),
          'user-agent': this.getUserAgent(),
        };
        if (!Util.empty(token)) {
          request_.headers["x-oss-security-token"] = token;
        }

        request_.query = Util.stringifyMapValue($tea.toMap(request.filter));
        request_.headers["authorization"] = OSSUtil.getSignature(request_, request.bucketName, accessKeyId, accessKeySecret, this._signatureVersion, this._addtionalHeaders);
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap : {[key: string]: any} = null;
        let bodyStr : string = null;
        if (Util.is4xx(response_.statusCode) || Util.is5xx(response_.statusCode)) {
          bodyStr = await Util.readAsString(response_.body);
          respMap = OSSUtil.getErrMessage(bodyStr);
          throw $tea.newError({
            code: respMap["Code"],
            message: respMap["Message"],
            data: {
              httpCode: response_.statusCode,
              requestId: respMap["RequestId"],
              hostId: respMap["HostId"],
            },
          });
        }

        bodyStr = await Util.readAsString(response_.body);
        respMap = XML.parseXml(bodyStr, GetBucketResponse);
        return $tea.cast<GetBucketResponse>({
          ListBucketResult: respMap["ListBucketResult"],
          ...response_.headers,
        }, new GetBucketResponse({}));
      } catch (ex) {
        if ($tea.isRetryable(ex)) {
          continue;
        }
        throw ex;
      }
    }

    throw $tea.newUnretryableError(_lastRequest);
  }

  async getLiveChannelInfo(request: GetLiveChannelInfoRequest, runtime: $OSSUtil.RuntimeOptions): Promise<GetLiveChannelInfoResponse> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: Util.defaultNumber(runtime.readTimeout, this._readTimeout),
      connectTimeout: Util.defaultNumber(runtime.connectTimeout, this._connectTimeout),
      localAddr: Util.defaultString(runtime.localAddr, this._localAddr),
      httpProxy: Util.defaultString(runtime.httpProxy, this._httpProxy),
      httpsProxy: Util.defaultString(runtime.httpsProxy, this._httpsProxy),
      noProxy: Util.defaultString(runtime.noProxy, this._noProxy),
      socks5Proxy: Util.defaultString(runtime.socks5Proxy, this._socks5Proxy),
      socks5NetWork: Util.defaultString(runtime.socks5NetWork, this._socks5NetWork),
      maxIdleConns: Util.defaultNumber(runtime.maxIdleConns, this._maxIdleConns),
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: Util.defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: Util.defaultString(runtime.backoffPolicy, "no"),
        period: Util.defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
    }

    let _lastRequest = null;
    let _now = Date.now();
    let _retryTimes = 0;
    while ($tea.allowRetry(_runtime['retry'], _retryTimes, _now)) {
      if (_retryTimes > 0) {
        let _backoffTime = $tea.getBackoffTime(_runtime['backoff'], _retryTimes);
        if (_backoffTime > 0) {
          await $tea.sleep(_backoffTime);
        }
      }

      _retryTimes = _retryTimes + 1;
      try {
        let request_ = new $tea.Request();
        let accessKeyId = await this._credential.getAccessKeyId();
        let accessKeySecret = await this._credential.getAccessKeySecret();
        let token = await this._credential.getSecurityToken();
        request_.protocol = this._protocol;
        request_.method = "GET";
        request_.pathname = `/${request.channelName}?live`;
        request_.headers = {
          host: OSSUtil.getHost(request.bucketName, this._regionId, this._endpoint, this._hostModel),
          date: Util.getDateUTCString(),
          'user-agent': this.getUserAgent(),
        };
        if (!Util.empty(token)) {
          request_.headers["x-oss-security-token"] = token;
        }

        request_.headers["authorization"] = OSSUtil.getSignature(request_, request.bucketName, accessKeyId, accessKeySecret, this._signatureVersion, this._addtionalHeaders);
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap : {[key: string]: any} = null;
        let bodyStr : string = null;
        if (Util.is4xx(response_.statusCode) || Util.is5xx(response_.statusCode)) {
          bodyStr = await Util.readAsString(response_.body);
          respMap = OSSUtil.getErrMessage(bodyStr);
          throw $tea.newError({
            code: respMap["Code"],
            message: respMap["Message"],
            data: {
              httpCode: response_.statusCode,
              requestId: respMap["RequestId"],
              hostId: respMap["HostId"],
            },
          });
        }

        bodyStr = await Util.readAsString(response_.body);
        respMap = XML.parseXml(bodyStr, GetLiveChannelInfoResponse);
        return $tea.cast<GetLiveChannelInfoResponse>({
          LiveChannelConfiguration: respMap["LiveChannelConfiguration"],
          ...response_.headers,
        }, new GetLiveChannelInfoResponse({}));
      } catch (ex) {
        if ($tea.isRetryable(ex)) {
          continue;
        }
        throw ex;
      }
    }

    throw $tea.newUnretryableError(_lastRequest);
  }

  async getLiveChannelStat(request: GetLiveChannelStatRequest, runtime: $OSSUtil.RuntimeOptions): Promise<GetLiveChannelStatResponse> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: Util.defaultNumber(runtime.readTimeout, this._readTimeout),
      connectTimeout: Util.defaultNumber(runtime.connectTimeout, this._connectTimeout),
      localAddr: Util.defaultString(runtime.localAddr, this._localAddr),
      httpProxy: Util.defaultString(runtime.httpProxy, this._httpProxy),
      httpsProxy: Util.defaultString(runtime.httpsProxy, this._httpsProxy),
      noProxy: Util.defaultString(runtime.noProxy, this._noProxy),
      socks5Proxy: Util.defaultString(runtime.socks5Proxy, this._socks5Proxy),
      socks5NetWork: Util.defaultString(runtime.socks5NetWork, this._socks5NetWork),
      maxIdleConns: Util.defaultNumber(runtime.maxIdleConns, this._maxIdleConns),
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: Util.defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: Util.defaultString(runtime.backoffPolicy, "no"),
        period: Util.defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
    }

    let _lastRequest = null;
    let _now = Date.now();
    let _retryTimes = 0;
    while ($tea.allowRetry(_runtime['retry'], _retryTimes, _now)) {
      if (_retryTimes > 0) {
        let _backoffTime = $tea.getBackoffTime(_runtime['backoff'], _retryTimes);
        if (_backoffTime > 0) {
          await $tea.sleep(_backoffTime);
        }
      }

      _retryTimes = _retryTimes + 1;
      try {
        let request_ = new $tea.Request();
        let accessKeyId = await this._credential.getAccessKeyId();
        let accessKeySecret = await this._credential.getAccessKeySecret();
        let token = await this._credential.getSecurityToken();
        request_.protocol = this._protocol;
        request_.method = "GET";
        request_.pathname = `/${request.channelName}?live`;
        request_.headers = {
          host: OSSUtil.getHost(request.bucketName, this._regionId, this._endpoint, this._hostModel),
          date: Util.getDateUTCString(),
          'user-agent': this.getUserAgent(),
        };
        if (!Util.empty(token)) {
          request_.headers["x-oss-security-token"] = token;
        }

        request_.query = Util.stringifyMapValue($tea.toMap(request.filter));
        request_.headers["authorization"] = OSSUtil.getSignature(request_, request.bucketName, accessKeyId, accessKeySecret, this._signatureVersion, this._addtionalHeaders);
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap : {[key: string]: any} = null;
        let bodyStr : string = null;
        if (Util.is4xx(response_.statusCode) || Util.is5xx(response_.statusCode)) {
          bodyStr = await Util.readAsString(response_.body);
          respMap = OSSUtil.getErrMessage(bodyStr);
          throw $tea.newError({
            code: respMap["Code"],
            message: respMap["Message"],
            data: {
              httpCode: response_.statusCode,
              requestId: respMap["RequestId"],
              hostId: respMap["HostId"],
            },
          });
        }

        bodyStr = await Util.readAsString(response_.body);
        respMap = XML.parseXml(bodyStr, GetLiveChannelStatResponse);
        return $tea.cast<GetLiveChannelStatResponse>({
          LiveChannelStat: respMap["LiveChannelStat"],
          ...response_.headers,
        }, new GetLiveChannelStatResponse({}));
      } catch (ex) {
        if ($tea.isRetryable(ex)) {
          continue;
        }
        throw ex;
      }
    }

    throw $tea.newUnretryableError(_lastRequest);
  }

  async deleteObject(request: DeleteObjectRequest, runtime: $OSSUtil.RuntimeOptions): Promise<DeleteObjectResponse> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: Util.defaultNumber(runtime.readTimeout, this._readTimeout),
      connectTimeout: Util.defaultNumber(runtime.connectTimeout, this._connectTimeout),
      localAddr: Util.defaultString(runtime.localAddr, this._localAddr),
      httpProxy: Util.defaultString(runtime.httpProxy, this._httpProxy),
      httpsProxy: Util.defaultString(runtime.httpsProxy, this._httpsProxy),
      noProxy: Util.defaultString(runtime.noProxy, this._noProxy),
      socks5Proxy: Util.defaultString(runtime.socks5Proxy, this._socks5Proxy),
      socks5NetWork: Util.defaultString(runtime.socks5NetWork, this._socks5NetWork),
      maxIdleConns: Util.defaultNumber(runtime.maxIdleConns, this._maxIdleConns),
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: Util.defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: Util.defaultString(runtime.backoffPolicy, "no"),
        period: Util.defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
    }

    let _lastRequest = null;
    let _now = Date.now();
    let _retryTimes = 0;
    while ($tea.allowRetry(_runtime['retry'], _retryTimes, _now)) {
      if (_retryTimes > 0) {
        let _backoffTime = $tea.getBackoffTime(_runtime['backoff'], _retryTimes);
        if (_backoffTime > 0) {
          await $tea.sleep(_backoffTime);
        }
      }

      _retryTimes = _retryTimes + 1;
      try {
        let request_ = new $tea.Request();
        let accessKeyId = await this._credential.getAccessKeyId();
        let accessKeySecret = await this._credential.getAccessKeySecret();
        let token = await this._credential.getSecurityToken();
        request_.protocol = this._protocol;
        request_.method = "DELETE";
        request_.pathname = `/${request.objectName}`;
        request_.headers = {
          host: OSSUtil.getHost(request.bucketName, this._regionId, this._endpoint, this._hostModel),
          date: Util.getDateUTCString(),
          'user-agent': this.getUserAgent(),
        };
        if (!Util.empty(token)) {
          request_.headers["x-oss-security-token"] = token;
        }

        request_.headers["authorization"] = OSSUtil.getSignature(request_, request.bucketName, accessKeyId, accessKeySecret, this._signatureVersion, this._addtionalHeaders);
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap : {[key: string]: any} = null;
        let bodyStr : string = null;
        if (Util.is4xx(response_.statusCode) || Util.is5xx(response_.statusCode)) {
          bodyStr = await Util.readAsString(response_.body);
          respMap = OSSUtil.getErrMessage(bodyStr);
          throw $tea.newError({
            code: respMap["Code"],
            message: respMap["Message"],
            data: {
              httpCode: response_.statusCode,
              requestId: respMap["RequestId"],
              hostId: respMap["HostId"],
            },
          });
        }

        return $tea.cast<DeleteObjectResponse>({
          ...response_.headers,
        }, new DeleteObjectResponse({}));
      } catch (ex) {
        if ($tea.isRetryable(ex)) {
          continue;
        }
        throw ex;
      }
    }

    throw $tea.newUnretryableError(_lastRequest);
  }

  async abortMultipartUpload(request: AbortMultipartUploadRequest, runtime: $OSSUtil.RuntimeOptions): Promise<AbortMultipartUploadResponse> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: Util.defaultNumber(runtime.readTimeout, this._readTimeout),
      connectTimeout: Util.defaultNumber(runtime.connectTimeout, this._connectTimeout),
      localAddr: Util.defaultString(runtime.localAddr, this._localAddr),
      httpProxy: Util.defaultString(runtime.httpProxy, this._httpProxy),
      httpsProxy: Util.defaultString(runtime.httpsProxy, this._httpsProxy),
      noProxy: Util.defaultString(runtime.noProxy, this._noProxy),
      socks5Proxy: Util.defaultString(runtime.socks5Proxy, this._socks5Proxy),
      socks5NetWork: Util.defaultString(runtime.socks5NetWork, this._socks5NetWork),
      maxIdleConns: Util.defaultNumber(runtime.maxIdleConns, this._maxIdleConns),
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: Util.defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: Util.defaultString(runtime.backoffPolicy, "no"),
        period: Util.defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
    }

    let _lastRequest = null;
    let _now = Date.now();
    let _retryTimes = 0;
    while ($tea.allowRetry(_runtime['retry'], _retryTimes, _now)) {
      if (_retryTimes > 0) {
        let _backoffTime = $tea.getBackoffTime(_runtime['backoff'], _retryTimes);
        if (_backoffTime > 0) {
          await $tea.sleep(_backoffTime);
        }
      }

      _retryTimes = _retryTimes + 1;
      try {
        let request_ = new $tea.Request();
        let accessKeyId = await this._credential.getAccessKeyId();
        let accessKeySecret = await this._credential.getAccessKeySecret();
        let token = await this._credential.getSecurityToken();
        request_.protocol = this._protocol;
        request_.method = "DELETE";
        request_.pathname = `/${request.objectName}`;
        request_.headers = {
          host: OSSUtil.getHost(request.bucketName, this._regionId, this._endpoint, this._hostModel),
          date: Util.getDateUTCString(),
          'user-agent': this.getUserAgent(),
        };
        if (!Util.empty(token)) {
          request_.headers["x-oss-security-token"] = token;
        }

        request_.query = Util.stringifyMapValue($tea.toMap(request.filter));
        request_.headers["authorization"] = OSSUtil.getSignature(request_, request.bucketName, accessKeyId, accessKeySecret, this._signatureVersion, this._addtionalHeaders);
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap : {[key: string]: any} = null;
        let bodyStr : string = null;
        if (Util.is4xx(response_.statusCode) || Util.is5xx(response_.statusCode)) {
          bodyStr = await Util.readAsString(response_.body);
          respMap = OSSUtil.getErrMessage(bodyStr);
          throw $tea.newError({
            code: respMap["Code"],
            message: respMap["Message"],
            data: {
              httpCode: response_.statusCode,
              requestId: respMap["RequestId"],
              hostId: respMap["HostId"],
            },
          });
        }

        return $tea.cast<AbortMultipartUploadResponse>({
          ...response_.headers,
        }, new AbortMultipartUploadResponse({}));
      } catch (ex) {
        if ($tea.isRetryable(ex)) {
          continue;
        }
        throw ex;
      }
    }

    throw $tea.newUnretryableError(_lastRequest);
  }

  async appendObject(request: AppendObjectRequest, runtime: $OSSUtil.RuntimeOptions): Promise<AppendObjectResponse> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: Util.defaultNumber(runtime.readTimeout, this._readTimeout),
      connectTimeout: Util.defaultNumber(runtime.connectTimeout, this._connectTimeout),
      localAddr: Util.defaultString(runtime.localAddr, this._localAddr),
      httpProxy: Util.defaultString(runtime.httpProxy, this._httpProxy),
      httpsProxy: Util.defaultString(runtime.httpsProxy, this._httpsProxy),
      noProxy: Util.defaultString(runtime.noProxy, this._noProxy),
      socks5Proxy: Util.defaultString(runtime.socks5Proxy, this._socks5Proxy),
      socks5NetWork: Util.defaultString(runtime.socks5NetWork, this._socks5NetWork),
      maxIdleConns: Util.defaultNumber(runtime.maxIdleConns, this._maxIdleConns),
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: Util.defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: Util.defaultString(runtime.backoffPolicy, "no"),
        period: Util.defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
    }

    let _lastRequest = null;
    let _now = Date.now();
    let _retryTimes = 0;
    while ($tea.allowRetry(_runtime['retry'], _retryTimes, _now)) {
      if (_retryTimes > 0) {
        let _backoffTime = $tea.getBackoffTime(_runtime['backoff'], _retryTimes);
        if (_backoffTime > 0) {
          await $tea.sleep(_backoffTime);
        }
      }

      _retryTimes = _retryTimes + 1;
      try {
        let request_ = new $tea.Request();
        let ctx : {[key: string ]: string} = { };
        let accessKeyId = await this._credential.getAccessKeyId();
        let accessKeySecret = await this._credential.getAccessKeySecret();
        let token = await this._credential.getSecurityToken();
        request_.protocol = this._protocol;
        request_.method = "POST";
        request_.pathname = `/${request.objectName}?append`;
        request_.headers = {
          host: OSSUtil.getHost(request.bucketName, this._regionId, this._endpoint, this._hostModel),
          date: Util.getDateUTCString(),
          'user-agent': this.getUserAgent(),
          ...Util.stringifyMapValue($tea.toMap(request.header)),
          ...OSSUtil.parseMeta(request.userMeta, "x-oss-meta-"),
        };
        if (!Util.empty(token)) {
          request_.headers["x-oss-security-token"] = token;
        }

        request_.query = Util.stringifyMapValue($tea.toMap(request.filter));
        request_.body = OSSUtil.inject(request.body, ctx);
        if (!Util.isUnset($tea.toMap(request.header)) && !Util.empty(request.header.contentType)) {
          request_.headers["content-type"] = request.header.contentType;
        } else {
          request_.headers["content-type"] = OSSUtil.getContentType(request.objectName);
        }

        request_.headers["authorization"] = OSSUtil.getSignature(request_, request.bucketName, accessKeyId, accessKeySecret, this._signatureVersion, this._addtionalHeaders);
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap : {[key: string]: any} = null;
        let bodyStr : string = null;
        if (Util.is4xx(response_.statusCode) || Util.is5xx(response_.statusCode)) {
          bodyStr = await Util.readAsString(response_.body);
          respMap = OSSUtil.getErrMessage(bodyStr);
          throw $tea.newError({
            code: respMap["Code"],
            message: respMap["Message"],
            data: {
              httpCode: response_.statusCode,
              requestId: respMap["RequestId"],
              hostId: respMap["HostId"],
            },
          });
        }

        if (this._isEnableCrc && !Util.equalString(ctx["crc"], response_.headers["x-oss-hash-crc64ecma"])) {
          throw $tea.newError({
            code: "CrcNotMatched",
            data: {
              clientCrc: ctx["crc"],
              serverCrc: response_.headers["x-oss-hash-crc64ecma"],
            },
          });
        }

        if (this._isEnableMD5 && !Util.equalString(ctx["md5"], response_.headers["content-md5"])) {
          throw $tea.newError({
            code: "MD5NotMatched",
            data: {
              clientMD5: ctx["md5"],
              serverMD5: response_.headers["content-md5"],
            },
          });
        }

        return $tea.cast<AppendObjectResponse>({
          ...response_.headers,
        }, new AppendObjectResponse({}));
      } catch (ex) {
        if ($tea.isRetryable(ex)) {
          continue;
        }
        throw ex;
      }
    }

    throw $tea.newUnretryableError(_lastRequest);
  }

  async uploadPartCopy(request: UploadPartCopyRequest, runtime: $OSSUtil.RuntimeOptions): Promise<UploadPartCopyResponse> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: Util.defaultNumber(runtime.readTimeout, this._readTimeout),
      connectTimeout: Util.defaultNumber(runtime.connectTimeout, this._connectTimeout),
      localAddr: Util.defaultString(runtime.localAddr, this._localAddr),
      httpProxy: Util.defaultString(runtime.httpProxy, this._httpProxy),
      httpsProxy: Util.defaultString(runtime.httpsProxy, this._httpsProxy),
      noProxy: Util.defaultString(runtime.noProxy, this._noProxy),
      socks5Proxy: Util.defaultString(runtime.socks5Proxy, this._socks5Proxy),
      socks5NetWork: Util.defaultString(runtime.socks5NetWork, this._socks5NetWork),
      maxIdleConns: Util.defaultNumber(runtime.maxIdleConns, this._maxIdleConns),
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: Util.defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: Util.defaultString(runtime.backoffPolicy, "no"),
        period: Util.defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
    }

    let _lastRequest = null;
    let _now = Date.now();
    let _retryTimes = 0;
    while ($tea.allowRetry(_runtime['retry'], _retryTimes, _now)) {
      if (_retryTimes > 0) {
        let _backoffTime = $tea.getBackoffTime(_runtime['backoff'], _retryTimes);
        if (_backoffTime > 0) {
          await $tea.sleep(_backoffTime);
        }
      }

      _retryTimes = _retryTimes + 1;
      try {
        let request_ = new $tea.Request();
        let accessKeyId = await this._credential.getAccessKeyId();
        let accessKeySecret = await this._credential.getAccessKeySecret();
        let token = await this._credential.getSecurityToken();
        request_.protocol = this._protocol;
        request_.method = "PUT";
        request_.pathname = `/${request.objectName}`;
        request_.headers = {
          host: OSSUtil.getHost(request.bucketName, this._regionId, this._endpoint, this._hostModel),
          date: Util.getDateUTCString(),
          'user-agent': this.getUserAgent(),
          ...Util.stringifyMapValue($tea.toMap(request.header)),
        };
        if (!Util.empty(token)) {
          request_.headers["x-oss-security-token"] = token;
        }

        request_.query = Util.stringifyMapValue($tea.toMap(request.filter));
        request_.headers["authorization"] = OSSUtil.getSignature(request_, request.bucketName, accessKeyId, accessKeySecret, this._signatureVersion, this._addtionalHeaders);
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap : {[key: string]: any} = null;
        let bodyStr : string = null;
        if (Util.is4xx(response_.statusCode) || Util.is5xx(response_.statusCode)) {
          bodyStr = await Util.readAsString(response_.body);
          respMap = OSSUtil.getErrMessage(bodyStr);
          throw $tea.newError({
            code: respMap["Code"],
            message: respMap["Message"],
            data: {
              httpCode: response_.statusCode,
              requestId: respMap["RequestId"],
              hostId: respMap["HostId"],
            },
          });
        }

        bodyStr = await Util.readAsString(response_.body);
        respMap = XML.parseXml(bodyStr, UploadPartCopyResponse);
        return $tea.cast<UploadPartCopyResponse>({
          CopyPartResult: respMap["CopyPartResult"],
          ...response_.headers,
        }, new UploadPartCopyResponse({}));
      } catch (ex) {
        if ($tea.isRetryable(ex)) {
          continue;
        }
        throw ex;
      }
    }

    throw $tea.newUnretryableError(_lastRequest);
  }

  async getVodPlaylist(request: GetVodPlaylistRequest, runtime: $OSSUtil.RuntimeOptions): Promise<GetVodPlaylistResponse> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: Util.defaultNumber(runtime.readTimeout, this._readTimeout),
      connectTimeout: Util.defaultNumber(runtime.connectTimeout, this._connectTimeout),
      localAddr: Util.defaultString(runtime.localAddr, this._localAddr),
      httpProxy: Util.defaultString(runtime.httpProxy, this._httpProxy),
      httpsProxy: Util.defaultString(runtime.httpsProxy, this._httpsProxy),
      noProxy: Util.defaultString(runtime.noProxy, this._noProxy),
      socks5Proxy: Util.defaultString(runtime.socks5Proxy, this._socks5Proxy),
      socks5NetWork: Util.defaultString(runtime.socks5NetWork, this._socks5NetWork),
      maxIdleConns: Util.defaultNumber(runtime.maxIdleConns, this._maxIdleConns),
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: Util.defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: Util.defaultString(runtime.backoffPolicy, "no"),
        period: Util.defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
    }

    let _lastRequest = null;
    let _now = Date.now();
    let _retryTimes = 0;
    while ($tea.allowRetry(_runtime['retry'], _retryTimes, _now)) {
      if (_retryTimes > 0) {
        let _backoffTime = $tea.getBackoffTime(_runtime['backoff'], _retryTimes);
        if (_backoffTime > 0) {
          await $tea.sleep(_backoffTime);
        }
      }

      _retryTimes = _retryTimes + 1;
      try {
        let request_ = new $tea.Request();
        let accessKeyId = await this._credential.getAccessKeyId();
        let accessKeySecret = await this._credential.getAccessKeySecret();
        let token = await this._credential.getSecurityToken();
        request_.protocol = this._protocol;
        request_.method = "GET";
        request_.pathname = `/${request.channelName}?vod`;
        request_.headers = {
          host: OSSUtil.getHost(request.bucketName, this._regionId, this._endpoint, this._hostModel),
          date: Util.getDateUTCString(),
          'user-agent': this.getUserAgent(),
        };
        if (!Util.empty(token)) {
          request_.headers["x-oss-security-token"] = token;
        }

        request_.query = Util.stringifyMapValue($tea.toMap(request.filter));
        request_.headers["authorization"] = OSSUtil.getSignature(request_, request.bucketName, accessKeyId, accessKeySecret, this._signatureVersion, this._addtionalHeaders);
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap : {[key: string]: any} = null;
        let bodyStr : string = null;
        if (Util.is4xx(response_.statusCode) || Util.is5xx(response_.statusCode)) {
          bodyStr = await Util.readAsString(response_.body);
          respMap = OSSUtil.getErrMessage(bodyStr);
          throw $tea.newError({
            code: respMap["Code"],
            message: respMap["Message"],
            data: {
              httpCode: response_.statusCode,
              requestId: respMap["RequestId"],
              hostId: respMap["HostId"],
            },
          });
        }

        return $tea.cast<GetVodPlaylistResponse>({
          ...response_.headers,
        }, new GetVodPlaylistResponse({}));
      } catch (ex) {
        if ($tea.isRetryable(ex)) {
          continue;
        }
        throw ex;
      }
    }

    throw $tea.newUnretryableError(_lastRequest);
  }

  async deleteBucketCORS(request: DeleteBucketCORSRequest, runtime: $OSSUtil.RuntimeOptions): Promise<DeleteBucketCORSResponse> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: Util.defaultNumber(runtime.readTimeout, this._readTimeout),
      connectTimeout: Util.defaultNumber(runtime.connectTimeout, this._connectTimeout),
      localAddr: Util.defaultString(runtime.localAddr, this._localAddr),
      httpProxy: Util.defaultString(runtime.httpProxy, this._httpProxy),
      httpsProxy: Util.defaultString(runtime.httpsProxy, this._httpsProxy),
      noProxy: Util.defaultString(runtime.noProxy, this._noProxy),
      socks5Proxy: Util.defaultString(runtime.socks5Proxy, this._socks5Proxy),
      socks5NetWork: Util.defaultString(runtime.socks5NetWork, this._socks5NetWork),
      maxIdleConns: Util.defaultNumber(runtime.maxIdleConns, this._maxIdleConns),
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: Util.defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: Util.defaultString(runtime.backoffPolicy, "no"),
        period: Util.defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
    }

    let _lastRequest = null;
    let _now = Date.now();
    let _retryTimes = 0;
    while ($tea.allowRetry(_runtime['retry'], _retryTimes, _now)) {
      if (_retryTimes > 0) {
        let _backoffTime = $tea.getBackoffTime(_runtime['backoff'], _retryTimes);
        if (_backoffTime > 0) {
          await $tea.sleep(_backoffTime);
        }
      }

      _retryTimes = _retryTimes + 1;
      try {
        let request_ = new $tea.Request();
        let accessKeyId = await this._credential.getAccessKeyId();
        let accessKeySecret = await this._credential.getAccessKeySecret();
        let token = await this._credential.getSecurityToken();
        request_.protocol = this._protocol;
        request_.method = "DELETE";
        request_.pathname = `/?cors`;
        request_.headers = {
          host: OSSUtil.getHost(request.bucketName, this._regionId, this._endpoint, this._hostModel),
          date: Util.getDateUTCString(),
          'user-agent': this.getUserAgent(),
        };
        if (!Util.empty(token)) {
          request_.headers["x-oss-security-token"] = token;
        }

        request_.headers["authorization"] = OSSUtil.getSignature(request_, request.bucketName, accessKeyId, accessKeySecret, this._signatureVersion, this._addtionalHeaders);
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap : {[key: string]: any} = null;
        let bodyStr : string = null;
        if (Util.is4xx(response_.statusCode) || Util.is5xx(response_.statusCode)) {
          bodyStr = await Util.readAsString(response_.body);
          respMap = OSSUtil.getErrMessage(bodyStr);
          throw $tea.newError({
            code: respMap["Code"],
            message: respMap["Message"],
            data: {
              httpCode: response_.statusCode,
              requestId: respMap["RequestId"],
              hostId: respMap["HostId"],
            },
          });
        }

        return $tea.cast<DeleteBucketCORSResponse>({
          ...response_.headers,
        }, new DeleteBucketCORSResponse({}));
      } catch (ex) {
        if ($tea.isRetryable(ex)) {
          continue;
        }
        throw ex;
      }
    }

    throw $tea.newUnretryableError(_lastRequest);
  }

  async getObject(request: GetObjectRequest, runtime: $OSSUtil.RuntimeOptions): Promise<GetObjectResponse> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: Util.defaultNumber(runtime.readTimeout, this._readTimeout),
      connectTimeout: Util.defaultNumber(runtime.connectTimeout, this._connectTimeout),
      localAddr: Util.defaultString(runtime.localAddr, this._localAddr),
      httpProxy: Util.defaultString(runtime.httpProxy, this._httpProxy),
      httpsProxy: Util.defaultString(runtime.httpsProxy, this._httpsProxy),
      noProxy: Util.defaultString(runtime.noProxy, this._noProxy),
      socks5Proxy: Util.defaultString(runtime.socks5Proxy, this._socks5Proxy),
      socks5NetWork: Util.defaultString(runtime.socks5NetWork, this._socks5NetWork),
      maxIdleConns: Util.defaultNumber(runtime.maxIdleConns, this._maxIdleConns),
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: Util.defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: Util.defaultString(runtime.backoffPolicy, "no"),
        period: Util.defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
    }

    let _lastRequest = null;
    let _now = Date.now();
    let _retryTimes = 0;
    while ($tea.allowRetry(_runtime['retry'], _retryTimes, _now)) {
      if (_retryTimes > 0) {
        let _backoffTime = $tea.getBackoffTime(_runtime['backoff'], _retryTimes);
        if (_backoffTime > 0) {
          await $tea.sleep(_backoffTime);
        }
      }

      _retryTimes = _retryTimes + 1;
      try {
        let request_ = new $tea.Request();
        let accessKeyId = await this._credential.getAccessKeyId();
        let accessKeySecret = await this._credential.getAccessKeySecret();
        let token = await this._credential.getSecurityToken();
        request_.protocol = this._protocol;
        request_.method = "GET";
        request_.pathname = `/${request.objectName}`;
        request_.headers = {
          host: OSSUtil.getHost(request.bucketName, this._regionId, this._endpoint, this._hostModel),
          date: Util.getDateUTCString(),
          'user-agent': this.getUserAgent(),
          ...Util.stringifyMapValue($tea.toMap(request.header)),
        };
        if (!Util.empty(token)) {
          request_.headers["x-oss-security-token"] = token;
        }

        request_.headers["authorization"] = OSSUtil.getSignature(request_, request.bucketName, accessKeyId, accessKeySecret, this._signatureVersion, this._addtionalHeaders);
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap : {[key: string]: any} = null;
        let bodyStr : string = null;
        if (Util.is4xx(response_.statusCode) || Util.is5xx(response_.statusCode)) {
          bodyStr = await Util.readAsString(response_.body);
          respMap = OSSUtil.getErrMessage(bodyStr);
          throw $tea.newError({
            code: respMap["Code"],
            message: respMap["Message"],
            data: {
              httpCode: response_.statusCode,
              requestId: respMap["RequestId"],
              hostId: respMap["HostId"],
            },
          });
        }

        return $tea.cast<GetObjectResponse>({
          body: response_.body,
          ...response_.headers,
        }, new GetObjectResponse({}));
      } catch (ex) {
        if ($tea.isRetryable(ex)) {
          continue;
        }
        throw ex;
      }
    }

    throw $tea.newUnretryableError(_lastRequest);
  }

  async uploadPart(request: UploadPartRequest, runtime: $OSSUtil.RuntimeOptions): Promise<UploadPartResponse> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: Util.defaultNumber(runtime.readTimeout, this._readTimeout),
      connectTimeout: Util.defaultNumber(runtime.connectTimeout, this._connectTimeout),
      localAddr: Util.defaultString(runtime.localAddr, this._localAddr),
      httpProxy: Util.defaultString(runtime.httpProxy, this._httpProxy),
      httpsProxy: Util.defaultString(runtime.httpsProxy, this._httpsProxy),
      noProxy: Util.defaultString(runtime.noProxy, this._noProxy),
      socks5Proxy: Util.defaultString(runtime.socks5Proxy, this._socks5Proxy),
      socks5NetWork: Util.defaultString(runtime.socks5NetWork, this._socks5NetWork),
      maxIdleConns: Util.defaultNumber(runtime.maxIdleConns, this._maxIdleConns),
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: Util.defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: Util.defaultString(runtime.backoffPolicy, "no"),
        period: Util.defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
    }

    let _lastRequest = null;
    let _now = Date.now();
    let _retryTimes = 0;
    while ($tea.allowRetry(_runtime['retry'], _retryTimes, _now)) {
      if (_retryTimes > 0) {
        let _backoffTime = $tea.getBackoffTime(_runtime['backoff'], _retryTimes);
        if (_backoffTime > 0) {
          await $tea.sleep(_backoffTime);
        }
      }

      _retryTimes = _retryTimes + 1;
      try {
        let request_ = new $tea.Request();
        let ctx : {[key: string ]: string} = { };
        let accessKeyId = await this._credential.getAccessKeyId();
        let accessKeySecret = await this._credential.getAccessKeySecret();
        let token = await this._credential.getSecurityToken();
        request_.protocol = this._protocol;
        request_.method = "PUT";
        request_.pathname = `/${request.objectName}`;
        request_.headers = {
          host: OSSUtil.getHost(request.bucketName, this._regionId, this._endpoint, this._hostModel),
          date: Util.getDateUTCString(),
          'user-agent': this.getUserAgent(),
        };
        if (!Util.empty(token)) {
          request_.headers["x-oss-security-token"] = token;
        }

        request_.query = Util.stringifyMapValue($tea.toMap(request.filter));
        request_.body = OSSUtil.inject(request.body, ctx);
        request_.headers["authorization"] = OSSUtil.getSignature(request_, request.bucketName, accessKeyId, accessKeySecret, this._signatureVersion, this._addtionalHeaders);
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap : {[key: string]: any} = null;
        let bodyStr : string = null;
        if (Util.is4xx(response_.statusCode) || Util.is5xx(response_.statusCode)) {
          bodyStr = await Util.readAsString(response_.body);
          respMap = OSSUtil.getErrMessage(bodyStr);
          throw $tea.newError({
            code: respMap["Code"],
            message: respMap["Message"],
            data: {
              httpCode: response_.statusCode,
              requestId: respMap["RequestId"],
              hostId: respMap["HostId"],
            },
          });
        }

        if (this._isEnableCrc && !Util.equalString(ctx["crc"], response_.headers["x-oss-hash-crc64ecma"])) {
          throw $tea.newError({
            code: "CrcNotMatched",
            data: {
              clientCrc: ctx["crc"],
              serverCrc: response_.headers["x-oss-hash-crc64ecma"],
            },
          });
        }

        if (this._isEnableMD5 && !Util.equalString(ctx["md5"], response_.headers["content-md5"])) {
          throw $tea.newError({
            code: "MD5NotMatched",
            data: {
              clientMD5: ctx["md5"],
              serverMD5: response_.headers["content-md5"],
            },
          });
        }

        return $tea.cast<UploadPartResponse>({
          ...response_.headers,
        }, new UploadPartResponse({}));
      } catch (ex) {
        if ($tea.isRetryable(ex)) {
          continue;
        }
        throw ex;
      }
    }

    throw $tea.newUnretryableError(_lastRequest);
  }

  async getBucketCORS(request: GetBucketCORSRequest, runtime: $OSSUtil.RuntimeOptions): Promise<GetBucketCORSResponse> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: Util.defaultNumber(runtime.readTimeout, this._readTimeout),
      connectTimeout: Util.defaultNumber(runtime.connectTimeout, this._connectTimeout),
      localAddr: Util.defaultString(runtime.localAddr, this._localAddr),
      httpProxy: Util.defaultString(runtime.httpProxy, this._httpProxy),
      httpsProxy: Util.defaultString(runtime.httpsProxy, this._httpsProxy),
      noProxy: Util.defaultString(runtime.noProxy, this._noProxy),
      socks5Proxy: Util.defaultString(runtime.socks5Proxy, this._socks5Proxy),
      socks5NetWork: Util.defaultString(runtime.socks5NetWork, this._socks5NetWork),
      maxIdleConns: Util.defaultNumber(runtime.maxIdleConns, this._maxIdleConns),
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: Util.defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: Util.defaultString(runtime.backoffPolicy, "no"),
        period: Util.defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
    }

    let _lastRequest = null;
    let _now = Date.now();
    let _retryTimes = 0;
    while ($tea.allowRetry(_runtime['retry'], _retryTimes, _now)) {
      if (_retryTimes > 0) {
        let _backoffTime = $tea.getBackoffTime(_runtime['backoff'], _retryTimes);
        if (_backoffTime > 0) {
          await $tea.sleep(_backoffTime);
        }
      }

      _retryTimes = _retryTimes + 1;
      try {
        let request_ = new $tea.Request();
        let accessKeyId = await this._credential.getAccessKeyId();
        let accessKeySecret = await this._credential.getAccessKeySecret();
        let token = await this._credential.getSecurityToken();
        request_.protocol = this._protocol;
        request_.method = "GET";
        request_.pathname = `/?cors`;
        request_.headers = {
          host: OSSUtil.getHost(request.bucketName, this._regionId, this._endpoint, this._hostModel),
          date: Util.getDateUTCString(),
          'user-agent': this.getUserAgent(),
        };
        if (!Util.empty(token)) {
          request_.headers["x-oss-security-token"] = token;
        }

        request_.headers["authorization"] = OSSUtil.getSignature(request_, request.bucketName, accessKeyId, accessKeySecret, this._signatureVersion, this._addtionalHeaders);
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap : {[key: string]: any} = null;
        let bodyStr : string = null;
        if (Util.is4xx(response_.statusCode) || Util.is5xx(response_.statusCode)) {
          bodyStr = await Util.readAsString(response_.body);
          respMap = OSSUtil.getErrMessage(bodyStr);
          throw $tea.newError({
            code: respMap["Code"],
            message: respMap["Message"],
            data: {
              httpCode: response_.statusCode,
              requestId: respMap["RequestId"],
              hostId: respMap["HostId"],
            },
          });
        }

        bodyStr = await Util.readAsString(response_.body);
        respMap = XML.parseXml(bodyStr, GetBucketCORSResponse);
        return $tea.cast<GetBucketCORSResponse>({
          CORSConfiguration: respMap["CORSConfiguration"],
          ...response_.headers,
        }, new GetBucketCORSResponse({}));
      } catch (ex) {
        if ($tea.isRetryable(ex)) {
          continue;
        }
        throw ex;
      }
    }

    throw $tea.newUnretryableError(_lastRequest);
  }

  async copyObject(request: CopyObjectRequest, runtime: $OSSUtil.RuntimeOptions): Promise<CopyObjectResponse> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: Util.defaultNumber(runtime.readTimeout, this._readTimeout),
      connectTimeout: Util.defaultNumber(runtime.connectTimeout, this._connectTimeout),
      localAddr: Util.defaultString(runtime.localAddr, this._localAddr),
      httpProxy: Util.defaultString(runtime.httpProxy, this._httpProxy),
      httpsProxy: Util.defaultString(runtime.httpsProxy, this._httpsProxy),
      noProxy: Util.defaultString(runtime.noProxy, this._noProxy),
      socks5Proxy: Util.defaultString(runtime.socks5Proxy, this._socks5Proxy),
      socks5NetWork: Util.defaultString(runtime.socks5NetWork, this._socks5NetWork),
      maxIdleConns: Util.defaultNumber(runtime.maxIdleConns, this._maxIdleConns),
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: Util.defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: Util.defaultString(runtime.backoffPolicy, "no"),
        period: Util.defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
    }

    let _lastRequest = null;
    let _now = Date.now();
    let _retryTimes = 0;
    while ($tea.allowRetry(_runtime['retry'], _retryTimes, _now)) {
      if (_retryTimes > 0) {
        let _backoffTime = $tea.getBackoffTime(_runtime['backoff'], _retryTimes);
        if (_backoffTime > 0) {
          await $tea.sleep(_backoffTime);
        }
      }

      _retryTimes = _retryTimes + 1;
      try {
        let request_ = new $tea.Request();
        let accessKeyId = await this._credential.getAccessKeyId();
        let accessKeySecret = await this._credential.getAccessKeySecret();
        let token = await this._credential.getSecurityToken();
        request_.protocol = this._protocol;
        request_.method = "PUT";
        request_.pathname = `/${request.destObjectName}`;
        request_.headers = {
          host: OSSUtil.getHost(request.bucketName, this._regionId, this._endpoint, this._hostModel),
          date: Util.getDateUTCString(),
          'user-agent': this.getUserAgent(),
          ...Util.stringifyMapValue($tea.toMap(request.header)),
        };
        if (!Util.empty(token)) {
          request_.headers["x-oss-security-token"] = token;
        }

        request_.headers["x-oss-copy-source"] = OSSUtil.encode(request_.headers["x-oss-copy-source"], "UrlEncode");
        request_.headers["authorization"] = OSSUtil.getSignature(request_, request.bucketName, accessKeyId, accessKeySecret, this._signatureVersion, this._addtionalHeaders);
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap : {[key: string]: any} = null;
        let bodyStr : string = null;
        if (Util.is4xx(response_.statusCode) || Util.is5xx(response_.statusCode)) {
          bodyStr = await Util.readAsString(response_.body);
          respMap = OSSUtil.getErrMessage(bodyStr);
          throw $tea.newError({
            code: respMap["Code"],
            message: respMap["Message"],
            data: {
              httpCode: response_.statusCode,
              requestId: respMap["RequestId"],
              hostId: respMap["HostId"],
            },
          });
        }

        bodyStr = await Util.readAsString(response_.body);
        respMap = XML.parseXml(bodyStr, CopyObjectResponse);
        return $tea.cast<CopyObjectResponse>({
          CopyObjectResult: respMap["CopyObjectResult"],
          ...response_.headers,
        }, new CopyObjectResponse({}));
      } catch (ex) {
        if ($tea.isRetryable(ex)) {
          continue;
        }
        throw ex;
      }
    }

    throw $tea.newUnretryableError(_lastRequest);
  }

  async getObjectTagging(request: GetObjectTaggingRequest, runtime: $OSSUtil.RuntimeOptions): Promise<GetObjectTaggingResponse> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: Util.defaultNumber(runtime.readTimeout, this._readTimeout),
      connectTimeout: Util.defaultNumber(runtime.connectTimeout, this._connectTimeout),
      localAddr: Util.defaultString(runtime.localAddr, this._localAddr),
      httpProxy: Util.defaultString(runtime.httpProxy, this._httpProxy),
      httpsProxy: Util.defaultString(runtime.httpsProxy, this._httpsProxy),
      noProxy: Util.defaultString(runtime.noProxy, this._noProxy),
      socks5Proxy: Util.defaultString(runtime.socks5Proxy, this._socks5Proxy),
      socks5NetWork: Util.defaultString(runtime.socks5NetWork, this._socks5NetWork),
      maxIdleConns: Util.defaultNumber(runtime.maxIdleConns, this._maxIdleConns),
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: Util.defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: Util.defaultString(runtime.backoffPolicy, "no"),
        period: Util.defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
    }

    let _lastRequest = null;
    let _now = Date.now();
    let _retryTimes = 0;
    while ($tea.allowRetry(_runtime['retry'], _retryTimes, _now)) {
      if (_retryTimes > 0) {
        let _backoffTime = $tea.getBackoffTime(_runtime['backoff'], _retryTimes);
        if (_backoffTime > 0) {
          await $tea.sleep(_backoffTime);
        }
      }

      _retryTimes = _retryTimes + 1;
      try {
        let request_ = new $tea.Request();
        let accessKeyId = await this._credential.getAccessKeyId();
        let accessKeySecret = await this._credential.getAccessKeySecret();
        let token = await this._credential.getSecurityToken();
        request_.protocol = this._protocol;
        request_.method = "GET";
        request_.pathname = `/${request.objectName}?tagging`;
        request_.headers = {
          host: OSSUtil.getHost(request.bucketName, this._regionId, this._endpoint, this._hostModel),
          date: Util.getDateUTCString(),
          'user-agent': this.getUserAgent(),
        };
        if (!Util.empty(token)) {
          request_.headers["x-oss-security-token"] = token;
        }

        request_.headers["authorization"] = OSSUtil.getSignature(request_, request.bucketName, accessKeyId, accessKeySecret, this._signatureVersion, this._addtionalHeaders);
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap : {[key: string]: any} = null;
        let bodyStr : string = null;
        if (Util.is4xx(response_.statusCode) || Util.is5xx(response_.statusCode)) {
          bodyStr = await Util.readAsString(response_.body);
          respMap = OSSUtil.getErrMessage(bodyStr);
          throw $tea.newError({
            code: respMap["Code"],
            message: respMap["Message"],
            data: {
              httpCode: response_.statusCode,
              requestId: respMap["RequestId"],
              hostId: respMap["HostId"],
            },
          });
        }

        bodyStr = await Util.readAsString(response_.body);
        respMap = XML.parseXml(bodyStr, GetObjectTaggingResponse);
        return $tea.cast<GetObjectTaggingResponse>({
          Tagging: respMap["Tagging"],
          ...response_.headers,
        }, new GetObjectTaggingResponse({}));
      } catch (ex) {
        if ($tea.isRetryable(ex)) {
          continue;
        }
        throw ex;
      }
    }

    throw $tea.newUnretryableError(_lastRequest);
  }

  async deleteBucketLifecycle(request: DeleteBucketLifecycleRequest, runtime: $OSSUtil.RuntimeOptions): Promise<DeleteBucketLifecycleResponse> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: Util.defaultNumber(runtime.readTimeout, this._readTimeout),
      connectTimeout: Util.defaultNumber(runtime.connectTimeout, this._connectTimeout),
      localAddr: Util.defaultString(runtime.localAddr, this._localAddr),
      httpProxy: Util.defaultString(runtime.httpProxy, this._httpProxy),
      httpsProxy: Util.defaultString(runtime.httpsProxy, this._httpsProxy),
      noProxy: Util.defaultString(runtime.noProxy, this._noProxy),
      socks5Proxy: Util.defaultString(runtime.socks5Proxy, this._socks5Proxy),
      socks5NetWork: Util.defaultString(runtime.socks5NetWork, this._socks5NetWork),
      maxIdleConns: Util.defaultNumber(runtime.maxIdleConns, this._maxIdleConns),
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: Util.defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: Util.defaultString(runtime.backoffPolicy, "no"),
        period: Util.defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
    }

    let _lastRequest = null;
    let _now = Date.now();
    let _retryTimes = 0;
    while ($tea.allowRetry(_runtime['retry'], _retryTimes, _now)) {
      if (_retryTimes > 0) {
        let _backoffTime = $tea.getBackoffTime(_runtime['backoff'], _retryTimes);
        if (_backoffTime > 0) {
          await $tea.sleep(_backoffTime);
        }
      }

      _retryTimes = _retryTimes + 1;
      try {
        let request_ = new $tea.Request();
        let accessKeyId = await this._credential.getAccessKeyId();
        let accessKeySecret = await this._credential.getAccessKeySecret();
        let token = await this._credential.getSecurityToken();
        request_.protocol = this._protocol;
        request_.method = "DELETE";
        request_.pathname = `/?lifecycle`;
        request_.headers = {
          host: OSSUtil.getHost(request.bucketName, this._regionId, this._endpoint, this._hostModel),
          date: Util.getDateUTCString(),
          'user-agent': this.getUserAgent(),
        };
        if (!Util.empty(token)) {
          request_.headers["x-oss-security-token"] = token;
        }

        request_.headers["authorization"] = OSSUtil.getSignature(request_, request.bucketName, accessKeyId, accessKeySecret, this._signatureVersion, this._addtionalHeaders);
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap : {[key: string]: any} = null;
        let bodyStr : string = null;
        if (Util.is4xx(response_.statusCode) || Util.is5xx(response_.statusCode)) {
          bodyStr = await Util.readAsString(response_.body);
          respMap = OSSUtil.getErrMessage(bodyStr);
          throw $tea.newError({
            code: respMap["Code"],
            message: respMap["Message"],
            data: {
              httpCode: response_.statusCode,
              requestId: respMap["RequestId"],
              hostId: respMap["HostId"],
            },
          });
        }

        return $tea.cast<DeleteBucketLifecycleResponse>({
          ...response_.headers,
        }, new DeleteBucketLifecycleResponse({}));
      } catch (ex) {
        if ($tea.isRetryable(ex)) {
          continue;
        }
        throw ex;
      }
    }

    throw $tea.newUnretryableError(_lastRequest);
  }

  async deleteBucketLogging(request: DeleteBucketLoggingRequest, runtime: $OSSUtil.RuntimeOptions): Promise<DeleteBucketLoggingResponse> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: Util.defaultNumber(runtime.readTimeout, this._readTimeout),
      connectTimeout: Util.defaultNumber(runtime.connectTimeout, this._connectTimeout),
      localAddr: Util.defaultString(runtime.localAddr, this._localAddr),
      httpProxy: Util.defaultString(runtime.httpProxy, this._httpProxy),
      httpsProxy: Util.defaultString(runtime.httpsProxy, this._httpsProxy),
      noProxy: Util.defaultString(runtime.noProxy, this._noProxy),
      socks5Proxy: Util.defaultString(runtime.socks5Proxy, this._socks5Proxy),
      socks5NetWork: Util.defaultString(runtime.socks5NetWork, this._socks5NetWork),
      maxIdleConns: Util.defaultNumber(runtime.maxIdleConns, this._maxIdleConns),
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: Util.defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: Util.defaultString(runtime.backoffPolicy, "no"),
        period: Util.defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
    }

    let _lastRequest = null;
    let _now = Date.now();
    let _retryTimes = 0;
    while ($tea.allowRetry(_runtime['retry'], _retryTimes, _now)) {
      if (_retryTimes > 0) {
        let _backoffTime = $tea.getBackoffTime(_runtime['backoff'], _retryTimes);
        if (_backoffTime > 0) {
          await $tea.sleep(_backoffTime);
        }
      }

      _retryTimes = _retryTimes + 1;
      try {
        let request_ = new $tea.Request();
        let accessKeyId = await this._credential.getAccessKeyId();
        let accessKeySecret = await this._credential.getAccessKeySecret();
        let token = await this._credential.getSecurityToken();
        request_.protocol = this._protocol;
        request_.method = "DELETE";
        request_.pathname = `/?logging`;
        request_.headers = {
          host: OSSUtil.getHost(request.bucketName, this._regionId, this._endpoint, this._hostModel),
          date: Util.getDateUTCString(),
          'user-agent': this.getUserAgent(),
        };
        if (!Util.empty(token)) {
          request_.headers["x-oss-security-token"] = token;
        }

        request_.headers["authorization"] = OSSUtil.getSignature(request_, request.bucketName, accessKeyId, accessKeySecret, this._signatureVersion, this._addtionalHeaders);
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap : {[key: string]: any} = null;
        let bodyStr : string = null;
        if (Util.is4xx(response_.statusCode) || Util.is5xx(response_.statusCode)) {
          bodyStr = await Util.readAsString(response_.body);
          respMap = OSSUtil.getErrMessage(bodyStr);
          throw $tea.newError({
            code: respMap["Code"],
            message: respMap["Message"],
            data: {
              httpCode: response_.statusCode,
              requestId: respMap["RequestId"],
              hostId: respMap["HostId"],
            },
          });
        }

        return $tea.cast<DeleteBucketLoggingResponse>({
          ...response_.headers,
        }, new DeleteBucketLoggingResponse({}));
      } catch (ex) {
        if ($tea.isRetryable(ex)) {
          continue;
        }
        throw ex;
      }
    }

    throw $tea.newUnretryableError(_lastRequest);
  }

  async deleteBucketWebsite(request: DeleteBucketWebsiteRequest, runtime: $OSSUtil.RuntimeOptions): Promise<DeleteBucketWebsiteResponse> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: Util.defaultNumber(runtime.readTimeout, this._readTimeout),
      connectTimeout: Util.defaultNumber(runtime.connectTimeout, this._connectTimeout),
      localAddr: Util.defaultString(runtime.localAddr, this._localAddr),
      httpProxy: Util.defaultString(runtime.httpProxy, this._httpProxy),
      httpsProxy: Util.defaultString(runtime.httpsProxy, this._httpsProxy),
      noProxy: Util.defaultString(runtime.noProxy, this._noProxy),
      socks5Proxy: Util.defaultString(runtime.socks5Proxy, this._socks5Proxy),
      socks5NetWork: Util.defaultString(runtime.socks5NetWork, this._socks5NetWork),
      maxIdleConns: Util.defaultNumber(runtime.maxIdleConns, this._maxIdleConns),
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: Util.defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: Util.defaultString(runtime.backoffPolicy, "no"),
        period: Util.defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
    }

    let _lastRequest = null;
    let _now = Date.now();
    let _retryTimes = 0;
    while ($tea.allowRetry(_runtime['retry'], _retryTimes, _now)) {
      if (_retryTimes > 0) {
        let _backoffTime = $tea.getBackoffTime(_runtime['backoff'], _retryTimes);
        if (_backoffTime > 0) {
          await $tea.sleep(_backoffTime);
        }
      }

      _retryTimes = _retryTimes + 1;
      try {
        let request_ = new $tea.Request();
        let accessKeyId = await this._credential.getAccessKeyId();
        let accessKeySecret = await this._credential.getAccessKeySecret();
        let token = await this._credential.getSecurityToken();
        request_.protocol = this._protocol;
        request_.method = "DELETE";
        request_.pathname = `/?website`;
        request_.headers = {
          host: OSSUtil.getHost(request.bucketName, this._regionId, this._endpoint, this._hostModel),
          date: Util.getDateUTCString(),
          'user-agent': this.getUserAgent(),
        };
        if (!Util.empty(token)) {
          request_.headers["x-oss-security-token"] = token;
        }

        request_.headers["authorization"] = OSSUtil.getSignature(request_, request.bucketName, accessKeyId, accessKeySecret, this._signatureVersion, this._addtionalHeaders);
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap : {[key: string]: any} = null;
        let bodyStr : string = null;
        if (Util.is4xx(response_.statusCode) || Util.is5xx(response_.statusCode)) {
          bodyStr = await Util.readAsString(response_.body);
          respMap = OSSUtil.getErrMessage(bodyStr);
          throw $tea.newError({
            code: respMap["Code"],
            message: respMap["Message"],
            data: {
              httpCode: response_.statusCode,
              requestId: respMap["RequestId"],
              hostId: respMap["HostId"],
            },
          });
        }

        return $tea.cast<DeleteBucketWebsiteResponse>({
          ...response_.headers,
        }, new DeleteBucketWebsiteResponse({}));
      } catch (ex) {
        if ($tea.isRetryable(ex)) {
          continue;
        }
        throw ex;
      }
    }

    throw $tea.newUnretryableError(_lastRequest);
  }

  async getSymlink(request: GetSymlinkRequest, runtime: $OSSUtil.RuntimeOptions): Promise<GetSymlinkResponse> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: Util.defaultNumber(runtime.readTimeout, this._readTimeout),
      connectTimeout: Util.defaultNumber(runtime.connectTimeout, this._connectTimeout),
      localAddr: Util.defaultString(runtime.localAddr, this._localAddr),
      httpProxy: Util.defaultString(runtime.httpProxy, this._httpProxy),
      httpsProxy: Util.defaultString(runtime.httpsProxy, this._httpsProxy),
      noProxy: Util.defaultString(runtime.noProxy, this._noProxy),
      socks5Proxy: Util.defaultString(runtime.socks5Proxy, this._socks5Proxy),
      socks5NetWork: Util.defaultString(runtime.socks5NetWork, this._socks5NetWork),
      maxIdleConns: Util.defaultNumber(runtime.maxIdleConns, this._maxIdleConns),
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: Util.defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: Util.defaultString(runtime.backoffPolicy, "no"),
        period: Util.defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
    }

    let _lastRequest = null;
    let _now = Date.now();
    let _retryTimes = 0;
    while ($tea.allowRetry(_runtime['retry'], _retryTimes, _now)) {
      if (_retryTimes > 0) {
        let _backoffTime = $tea.getBackoffTime(_runtime['backoff'], _retryTimes);
        if (_backoffTime > 0) {
          await $tea.sleep(_backoffTime);
        }
      }

      _retryTimes = _retryTimes + 1;
      try {
        let request_ = new $tea.Request();
        let accessKeyId = await this._credential.getAccessKeyId();
        let accessKeySecret = await this._credential.getAccessKeySecret();
        let token = await this._credential.getSecurityToken();
        request_.protocol = this._protocol;
        request_.method = "GET";
        request_.pathname = `/${request.objectName}?symlink`;
        request_.headers = {
          host: OSSUtil.getHost(request.bucketName, this._regionId, this._endpoint, this._hostModel),
          date: Util.getDateUTCString(),
          'user-agent': this.getUserAgent(),
        };
        if (!Util.empty(token)) {
          request_.headers["x-oss-security-token"] = token;
        }

        request_.headers["authorization"] = OSSUtil.getSignature(request_, request.bucketName, accessKeyId, accessKeySecret, this._signatureVersion, this._addtionalHeaders);
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap : {[key: string]: any} = null;
        let bodyStr : string = null;
        if (Util.is4xx(response_.statusCode) || Util.is5xx(response_.statusCode)) {
          bodyStr = await Util.readAsString(response_.body);
          respMap = OSSUtil.getErrMessage(bodyStr);
          throw $tea.newError({
            code: respMap["Code"],
            message: respMap["Message"],
            data: {
              httpCode: response_.statusCode,
              requestId: respMap["RequestId"],
              hostId: respMap["HostId"],
            },
          });
        }

        return $tea.cast<GetSymlinkResponse>({
          ...response_.headers,
        }, new GetSymlinkResponse({}));
      } catch (ex) {
        if ($tea.isRetryable(ex)) {
          continue;
        }
        throw ex;
      }
    }

    throw $tea.newUnretryableError(_lastRequest);
  }

  async getBucketLifecycle(request: GetBucketLifecycleRequest, runtime: $OSSUtil.RuntimeOptions): Promise<GetBucketLifecycleResponse> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: Util.defaultNumber(runtime.readTimeout, this._readTimeout),
      connectTimeout: Util.defaultNumber(runtime.connectTimeout, this._connectTimeout),
      localAddr: Util.defaultString(runtime.localAddr, this._localAddr),
      httpProxy: Util.defaultString(runtime.httpProxy, this._httpProxy),
      httpsProxy: Util.defaultString(runtime.httpsProxy, this._httpsProxy),
      noProxy: Util.defaultString(runtime.noProxy, this._noProxy),
      socks5Proxy: Util.defaultString(runtime.socks5Proxy, this._socks5Proxy),
      socks5NetWork: Util.defaultString(runtime.socks5NetWork, this._socks5NetWork),
      maxIdleConns: Util.defaultNumber(runtime.maxIdleConns, this._maxIdleConns),
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: Util.defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: Util.defaultString(runtime.backoffPolicy, "no"),
        period: Util.defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
    }

    let _lastRequest = null;
    let _now = Date.now();
    let _retryTimes = 0;
    while ($tea.allowRetry(_runtime['retry'], _retryTimes, _now)) {
      if (_retryTimes > 0) {
        let _backoffTime = $tea.getBackoffTime(_runtime['backoff'], _retryTimes);
        if (_backoffTime > 0) {
          await $tea.sleep(_backoffTime);
        }
      }

      _retryTimes = _retryTimes + 1;
      try {
        let request_ = new $tea.Request();
        let accessKeyId = await this._credential.getAccessKeyId();
        let accessKeySecret = await this._credential.getAccessKeySecret();
        let token = await this._credential.getSecurityToken();
        request_.protocol = this._protocol;
        request_.method = "GET";
        request_.pathname = `/?lifecycle`;
        request_.headers = {
          host: OSSUtil.getHost(request.bucketName, this._regionId, this._endpoint, this._hostModel),
          date: Util.getDateUTCString(),
          'user-agent': this.getUserAgent(),
        };
        if (!Util.empty(token)) {
          request_.headers["x-oss-security-token"] = token;
        }

        request_.headers["authorization"] = OSSUtil.getSignature(request_, request.bucketName, accessKeyId, accessKeySecret, this._signatureVersion, this._addtionalHeaders);
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap : {[key: string]: any} = null;
        let bodyStr : string = null;
        if (Util.is4xx(response_.statusCode) || Util.is5xx(response_.statusCode)) {
          bodyStr = await Util.readAsString(response_.body);
          respMap = OSSUtil.getErrMessage(bodyStr);
          throw $tea.newError({
            code: respMap["Code"],
            message: respMap["Message"],
            data: {
              httpCode: response_.statusCode,
              requestId: respMap["RequestId"],
              hostId: respMap["HostId"],
            },
          });
        }

        bodyStr = await Util.readAsString(response_.body);
        respMap = XML.parseXml(bodyStr, GetBucketLifecycleResponse);
        return $tea.cast<GetBucketLifecycleResponse>({
          LifecycleConfiguration: respMap["LifecycleConfiguration"],
          ...response_.headers,
        }, new GetBucketLifecycleResponse({}));
      } catch (ex) {
        if ($tea.isRetryable(ex)) {
          continue;
        }
        throw ex;
      }
    }

    throw $tea.newUnretryableError(_lastRequest);
  }

  async putSymlink(request: PutSymlinkRequest, runtime: $OSSUtil.RuntimeOptions): Promise<PutSymlinkResponse> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: Util.defaultNumber(runtime.readTimeout, this._readTimeout),
      connectTimeout: Util.defaultNumber(runtime.connectTimeout, this._connectTimeout),
      localAddr: Util.defaultString(runtime.localAddr, this._localAddr),
      httpProxy: Util.defaultString(runtime.httpProxy, this._httpProxy),
      httpsProxy: Util.defaultString(runtime.httpsProxy, this._httpsProxy),
      noProxy: Util.defaultString(runtime.noProxy, this._noProxy),
      socks5Proxy: Util.defaultString(runtime.socks5Proxy, this._socks5Proxy),
      socks5NetWork: Util.defaultString(runtime.socks5NetWork, this._socks5NetWork),
      maxIdleConns: Util.defaultNumber(runtime.maxIdleConns, this._maxIdleConns),
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: Util.defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: Util.defaultString(runtime.backoffPolicy, "no"),
        period: Util.defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
    }

    let _lastRequest = null;
    let _now = Date.now();
    let _retryTimes = 0;
    while ($tea.allowRetry(_runtime['retry'], _retryTimes, _now)) {
      if (_retryTimes > 0) {
        let _backoffTime = $tea.getBackoffTime(_runtime['backoff'], _retryTimes);
        if (_backoffTime > 0) {
          await $tea.sleep(_backoffTime);
        }
      }

      _retryTimes = _retryTimes + 1;
      try {
        let request_ = new $tea.Request();
        let accessKeyId = await this._credential.getAccessKeyId();
        let accessKeySecret = await this._credential.getAccessKeySecret();
        let token = await this._credential.getSecurityToken();
        request_.protocol = this._protocol;
        request_.method = "PUT";
        request_.pathname = `/${request.objectName}?symlink`;
        request_.headers = {
          host: OSSUtil.getHost(request.bucketName, this._regionId, this._endpoint, this._hostModel),
          date: Util.getDateUTCString(),
          'user-agent': this.getUserAgent(),
          ...Util.stringifyMapValue($tea.toMap(request.header)),
        };
        if (!Util.empty(token)) {
          request_.headers["x-oss-security-token"] = token;
        }

        request_.headers["authorization"] = OSSUtil.getSignature(request_, request.bucketName, accessKeyId, accessKeySecret, this._signatureVersion, this._addtionalHeaders);
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap : {[key: string]: any} = null;
        let bodyStr : string = null;
        if (Util.is4xx(response_.statusCode) || Util.is5xx(response_.statusCode)) {
          bodyStr = await Util.readAsString(response_.body);
          respMap = OSSUtil.getErrMessage(bodyStr);
          throw $tea.newError({
            code: respMap["Code"],
            message: respMap["Message"],
            data: {
              httpCode: response_.statusCode,
              requestId: respMap["RequestId"],
              hostId: respMap["HostId"],
            },
          });
        }

        return $tea.cast<PutSymlinkResponse>({
          ...response_.headers,
        }, new PutSymlinkResponse({}));
      } catch (ex) {
        if ($tea.isRetryable(ex)) {
          continue;
        }
        throw ex;
      }
    }

    throw $tea.newUnretryableError(_lastRequest);
  }

  async getBucketReferer(request: GetBucketRefererRequest, runtime: $OSSUtil.RuntimeOptions): Promise<GetBucketRefererResponse> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: Util.defaultNumber(runtime.readTimeout, this._readTimeout),
      connectTimeout: Util.defaultNumber(runtime.connectTimeout, this._connectTimeout),
      localAddr: Util.defaultString(runtime.localAddr, this._localAddr),
      httpProxy: Util.defaultString(runtime.httpProxy, this._httpProxy),
      httpsProxy: Util.defaultString(runtime.httpsProxy, this._httpsProxy),
      noProxy: Util.defaultString(runtime.noProxy, this._noProxy),
      socks5Proxy: Util.defaultString(runtime.socks5Proxy, this._socks5Proxy),
      socks5NetWork: Util.defaultString(runtime.socks5NetWork, this._socks5NetWork),
      maxIdleConns: Util.defaultNumber(runtime.maxIdleConns, this._maxIdleConns),
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: Util.defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: Util.defaultString(runtime.backoffPolicy, "no"),
        period: Util.defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
    }

    let _lastRequest = null;
    let _now = Date.now();
    let _retryTimes = 0;
    while ($tea.allowRetry(_runtime['retry'], _retryTimes, _now)) {
      if (_retryTimes > 0) {
        let _backoffTime = $tea.getBackoffTime(_runtime['backoff'], _retryTimes);
        if (_backoffTime > 0) {
          await $tea.sleep(_backoffTime);
        }
      }

      _retryTimes = _retryTimes + 1;
      try {
        let request_ = new $tea.Request();
        let accessKeyId = await this._credential.getAccessKeyId();
        let accessKeySecret = await this._credential.getAccessKeySecret();
        let token = await this._credential.getSecurityToken();
        request_.protocol = this._protocol;
        request_.method = "GET";
        request_.pathname = `/?referer`;
        request_.headers = {
          host: OSSUtil.getHost(request.bucketName, this._regionId, this._endpoint, this._hostModel),
          date: Util.getDateUTCString(),
          'user-agent': this.getUserAgent(),
        };
        if (!Util.empty(token)) {
          request_.headers["x-oss-security-token"] = token;
        }

        request_.headers["authorization"] = OSSUtil.getSignature(request_, request.bucketName, accessKeyId, accessKeySecret, this._signatureVersion, this._addtionalHeaders);
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap : {[key: string]: any} = null;
        let bodyStr : string = null;
        if (Util.is4xx(response_.statusCode) || Util.is5xx(response_.statusCode)) {
          bodyStr = await Util.readAsString(response_.body);
          respMap = OSSUtil.getErrMessage(bodyStr);
          throw $tea.newError({
            code: respMap["Code"],
            message: respMap["Message"],
            data: {
              httpCode: response_.statusCode,
              requestId: respMap["RequestId"],
              hostId: respMap["HostId"],
            },
          });
        }

        bodyStr = await Util.readAsString(response_.body);
        respMap = XML.parseXml(bodyStr, GetBucketRefererResponse);
        return $tea.cast<GetBucketRefererResponse>({
          RefererConfiguration: respMap["RefererConfiguration"],
          ...response_.headers,
        }, new GetBucketRefererResponse({}));
      } catch (ex) {
        if ($tea.isRetryable(ex)) {
          continue;
        }
        throw ex;
      }
    }

    throw $tea.newUnretryableError(_lastRequest);
  }

  async callback(request: CallbackRequest, runtime: $OSSUtil.RuntimeOptions): Promise<CallbackResponse> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: Util.defaultNumber(runtime.readTimeout, this._readTimeout),
      connectTimeout: Util.defaultNumber(runtime.connectTimeout, this._connectTimeout),
      localAddr: Util.defaultString(runtime.localAddr, this._localAddr),
      httpProxy: Util.defaultString(runtime.httpProxy, this._httpProxy),
      httpsProxy: Util.defaultString(runtime.httpsProxy, this._httpsProxy),
      noProxy: Util.defaultString(runtime.noProxy, this._noProxy),
      socks5Proxy: Util.defaultString(runtime.socks5Proxy, this._socks5Proxy),
      socks5NetWork: Util.defaultString(runtime.socks5NetWork, this._socks5NetWork),
      maxIdleConns: Util.defaultNumber(runtime.maxIdleConns, this._maxIdleConns),
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: Util.defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: Util.defaultString(runtime.backoffPolicy, "no"),
        period: Util.defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
    }

    let _lastRequest = null;
    let _now = Date.now();
    let _retryTimes = 0;
    while ($tea.allowRetry(_runtime['retry'], _retryTimes, _now)) {
      if (_retryTimes > 0) {
        let _backoffTime = $tea.getBackoffTime(_runtime['backoff'], _retryTimes);
        if (_backoffTime > 0) {
          await $tea.sleep(_backoffTime);
        }
      }

      _retryTimes = _retryTimes + 1;
      try {
        let request_ = new $tea.Request();
        let accessKeyId = await this._credential.getAccessKeyId();
        let accessKeySecret = await this._credential.getAccessKeySecret();
        let token = await this._credential.getSecurityToken();
        request_.protocol = this._protocol;
        request_.method = "GET";
        request_.pathname = `/`;
        request_.headers = {
          host: OSSUtil.getHost(request.bucketName, this._regionId, this._endpoint, this._hostModel),
          date: Util.getDateUTCString(),
          'user-agent': this.getUserAgent(),
        };
        if (!Util.empty(token)) {
          request_.headers["x-oss-security-token"] = token;
        }

        request_.headers["authorization"] = OSSUtil.getSignature(request_, request.bucketName, accessKeyId, accessKeySecret, this._signatureVersion, this._addtionalHeaders);
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap : {[key: string]: any} = null;
        let bodyStr : string = null;
        if (Util.is4xx(response_.statusCode) || Util.is5xx(response_.statusCode)) {
          bodyStr = await Util.readAsString(response_.body);
          respMap = OSSUtil.getErrMessage(bodyStr);
          throw $tea.newError({
            code: respMap["Code"],
            message: respMap["Message"],
            data: {
              httpCode: response_.statusCode,
              requestId: respMap["RequestId"],
              hostId: respMap["HostId"],
            },
          });
        }

        return $tea.cast<CallbackResponse>({
          ...response_.headers,
        }, new CallbackResponse({}));
      } catch (ex) {
        if ($tea.isRetryable(ex)) {
          continue;
        }
        throw ex;
      }
    }

    throw $tea.newUnretryableError(_lastRequest);
  }

  async getBucketLogging(request: GetBucketLoggingRequest, runtime: $OSSUtil.RuntimeOptions): Promise<GetBucketLoggingResponse> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: Util.defaultNumber(runtime.readTimeout, this._readTimeout),
      connectTimeout: Util.defaultNumber(runtime.connectTimeout, this._connectTimeout),
      localAddr: Util.defaultString(runtime.localAddr, this._localAddr),
      httpProxy: Util.defaultString(runtime.httpProxy, this._httpProxy),
      httpsProxy: Util.defaultString(runtime.httpsProxy, this._httpsProxy),
      noProxy: Util.defaultString(runtime.noProxy, this._noProxy),
      socks5Proxy: Util.defaultString(runtime.socks5Proxy, this._socks5Proxy),
      socks5NetWork: Util.defaultString(runtime.socks5NetWork, this._socks5NetWork),
      maxIdleConns: Util.defaultNumber(runtime.maxIdleConns, this._maxIdleConns),
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: Util.defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: Util.defaultString(runtime.backoffPolicy, "no"),
        period: Util.defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
    }

    let _lastRequest = null;
    let _now = Date.now();
    let _retryTimes = 0;
    while ($tea.allowRetry(_runtime['retry'], _retryTimes, _now)) {
      if (_retryTimes > 0) {
        let _backoffTime = $tea.getBackoffTime(_runtime['backoff'], _retryTimes);
        if (_backoffTime > 0) {
          await $tea.sleep(_backoffTime);
        }
      }

      _retryTimes = _retryTimes + 1;
      try {
        let request_ = new $tea.Request();
        let accessKeyId = await this._credential.getAccessKeyId();
        let accessKeySecret = await this._credential.getAccessKeySecret();
        let token = await this._credential.getSecurityToken();
        request_.protocol = this._protocol;
        request_.method = "GET";
        request_.pathname = `/?logging`;
        request_.headers = {
          host: OSSUtil.getHost(request.bucketName, this._regionId, this._endpoint, this._hostModel),
          date: Util.getDateUTCString(),
          'user-agent': this.getUserAgent(),
        };
        if (!Util.empty(token)) {
          request_.headers["x-oss-security-token"] = token;
        }

        request_.headers["authorization"] = OSSUtil.getSignature(request_, request.bucketName, accessKeyId, accessKeySecret, this._signatureVersion, this._addtionalHeaders);
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap : {[key: string]: any} = null;
        let bodyStr : string = null;
        if (Util.is4xx(response_.statusCode) || Util.is5xx(response_.statusCode)) {
          bodyStr = await Util.readAsString(response_.body);
          respMap = OSSUtil.getErrMessage(bodyStr);
          throw $tea.newError({
            code: respMap["Code"],
            message: respMap["Message"],
            data: {
              httpCode: response_.statusCode,
              requestId: respMap["RequestId"],
              hostId: respMap["HostId"],
            },
          });
        }

        bodyStr = await Util.readAsString(response_.body);
        respMap = XML.parseXml(bodyStr, GetBucketLoggingResponse);
        return $tea.cast<GetBucketLoggingResponse>({
          BucketLoggingStatus: respMap["BucketLoggingStatus"],
          ...response_.headers,
        }, new GetBucketLoggingResponse({}));
      } catch (ex) {
        if ($tea.isRetryable(ex)) {
          continue;
        }
        throw ex;
      }
    }

    throw $tea.newUnretryableError(_lastRequest);
  }

  async putObjectAcl(request: PutObjectAclRequest, runtime: $OSSUtil.RuntimeOptions): Promise<PutObjectAclResponse> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: Util.defaultNumber(runtime.readTimeout, this._readTimeout),
      connectTimeout: Util.defaultNumber(runtime.connectTimeout, this._connectTimeout),
      localAddr: Util.defaultString(runtime.localAddr, this._localAddr),
      httpProxy: Util.defaultString(runtime.httpProxy, this._httpProxy),
      httpsProxy: Util.defaultString(runtime.httpsProxy, this._httpsProxy),
      noProxy: Util.defaultString(runtime.noProxy, this._noProxy),
      socks5Proxy: Util.defaultString(runtime.socks5Proxy, this._socks5Proxy),
      socks5NetWork: Util.defaultString(runtime.socks5NetWork, this._socks5NetWork),
      maxIdleConns: Util.defaultNumber(runtime.maxIdleConns, this._maxIdleConns),
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: Util.defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: Util.defaultString(runtime.backoffPolicy, "no"),
        period: Util.defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
    }

    let _lastRequest = null;
    let _now = Date.now();
    let _retryTimes = 0;
    while ($tea.allowRetry(_runtime['retry'], _retryTimes, _now)) {
      if (_retryTimes > 0) {
        let _backoffTime = $tea.getBackoffTime(_runtime['backoff'], _retryTimes);
        if (_backoffTime > 0) {
          await $tea.sleep(_backoffTime);
        }
      }

      _retryTimes = _retryTimes + 1;
      try {
        let request_ = new $tea.Request();
        let accessKeyId = await this._credential.getAccessKeyId();
        let accessKeySecret = await this._credential.getAccessKeySecret();
        let token = await this._credential.getSecurityToken();
        request_.protocol = this._protocol;
        request_.method = "PUT";
        request_.pathname = `/${request.objectName}?acl`;
        request_.headers = {
          host: OSSUtil.getHost(request.bucketName, this._regionId, this._endpoint, this._hostModel),
          date: Util.getDateUTCString(),
          'user-agent': this.getUserAgent(),
          ...Util.stringifyMapValue($tea.toMap(request.header)),
        };
        if (!Util.empty(token)) {
          request_.headers["x-oss-security-token"] = token;
        }

        request_.headers["authorization"] = OSSUtil.getSignature(request_, request.bucketName, accessKeyId, accessKeySecret, this._signatureVersion, this._addtionalHeaders);
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap : {[key: string]: any} = null;
        let bodyStr : string = null;
        if (Util.is4xx(response_.statusCode) || Util.is5xx(response_.statusCode)) {
          bodyStr = await Util.readAsString(response_.body);
          respMap = OSSUtil.getErrMessage(bodyStr);
          throw $tea.newError({
            code: respMap["Code"],
            message: respMap["Message"],
            data: {
              httpCode: response_.statusCode,
              requestId: respMap["RequestId"],
              hostId: respMap["HostId"],
            },
          });
        }

        return $tea.cast<PutObjectAclResponse>({
          ...response_.headers,
        }, new PutObjectAclResponse({}));
      } catch (ex) {
        if ($tea.isRetryable(ex)) {
          continue;
        }
        throw ex;
      }
    }

    throw $tea.newUnretryableError(_lastRequest);
  }

  async getBucketInfo(request: GetBucketInfoRequest, runtime: $OSSUtil.RuntimeOptions): Promise<GetBucketInfoResponse> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: Util.defaultNumber(runtime.readTimeout, this._readTimeout),
      connectTimeout: Util.defaultNumber(runtime.connectTimeout, this._connectTimeout),
      localAddr: Util.defaultString(runtime.localAddr, this._localAddr),
      httpProxy: Util.defaultString(runtime.httpProxy, this._httpProxy),
      httpsProxy: Util.defaultString(runtime.httpsProxy, this._httpsProxy),
      noProxy: Util.defaultString(runtime.noProxy, this._noProxy),
      socks5Proxy: Util.defaultString(runtime.socks5Proxy, this._socks5Proxy),
      socks5NetWork: Util.defaultString(runtime.socks5NetWork, this._socks5NetWork),
      maxIdleConns: Util.defaultNumber(runtime.maxIdleConns, this._maxIdleConns),
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: Util.defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: Util.defaultString(runtime.backoffPolicy, "no"),
        period: Util.defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
    }

    let _lastRequest = null;
    let _now = Date.now();
    let _retryTimes = 0;
    while ($tea.allowRetry(_runtime['retry'], _retryTimes, _now)) {
      if (_retryTimes > 0) {
        let _backoffTime = $tea.getBackoffTime(_runtime['backoff'], _retryTimes);
        if (_backoffTime > 0) {
          await $tea.sleep(_backoffTime);
        }
      }

      _retryTimes = _retryTimes + 1;
      try {
        let request_ = new $tea.Request();
        let accessKeyId = await this._credential.getAccessKeyId();
        let accessKeySecret = await this._credential.getAccessKeySecret();
        let token = await this._credential.getSecurityToken();
        request_.protocol = this._protocol;
        request_.method = "GET";
        request_.pathname = `/?bucketInfo`;
        request_.headers = {
          host: OSSUtil.getHost(request.bucketName, this._regionId, this._endpoint, this._hostModel),
          date: Util.getDateUTCString(),
          'user-agent': this.getUserAgent(),
        };
        if (!Util.empty(token)) {
          request_.headers["x-oss-security-token"] = token;
        }

        request_.headers["authorization"] = OSSUtil.getSignature(request_, request.bucketName, accessKeyId, accessKeySecret, this._signatureVersion, this._addtionalHeaders);
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap : {[key: string]: any} = null;
        let bodyStr : string = null;
        if (Util.is4xx(response_.statusCode) || Util.is5xx(response_.statusCode)) {
          bodyStr = await Util.readAsString(response_.body);
          respMap = OSSUtil.getErrMessage(bodyStr);
          throw $tea.newError({
            code: respMap["Code"],
            message: respMap["Message"],
            data: {
              httpCode: response_.statusCode,
              requestId: respMap["RequestId"],
              hostId: respMap["HostId"],
            },
          });
        }

        bodyStr = await Util.readAsString(response_.body);
        respMap = XML.parseXml(bodyStr, GetBucketInfoResponse);
        return $tea.cast<GetBucketInfoResponse>({
          BucketInfo: respMap["BucketInfo"],
          ...response_.headers,
        }, new GetBucketInfoResponse({}));
      } catch (ex) {
        if ($tea.isRetryable(ex)) {
          continue;
        }
        throw ex;
      }
    }

    throw $tea.newUnretryableError(_lastRequest);
  }

  async putLiveChannelStatus(request: PutLiveChannelStatusRequest, runtime: $OSSUtil.RuntimeOptions): Promise<PutLiveChannelStatusResponse> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: Util.defaultNumber(runtime.readTimeout, this._readTimeout),
      connectTimeout: Util.defaultNumber(runtime.connectTimeout, this._connectTimeout),
      localAddr: Util.defaultString(runtime.localAddr, this._localAddr),
      httpProxy: Util.defaultString(runtime.httpProxy, this._httpProxy),
      httpsProxy: Util.defaultString(runtime.httpsProxy, this._httpsProxy),
      noProxy: Util.defaultString(runtime.noProxy, this._noProxy),
      socks5Proxy: Util.defaultString(runtime.socks5Proxy, this._socks5Proxy),
      socks5NetWork: Util.defaultString(runtime.socks5NetWork, this._socks5NetWork),
      maxIdleConns: Util.defaultNumber(runtime.maxIdleConns, this._maxIdleConns),
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: Util.defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: Util.defaultString(runtime.backoffPolicy, "no"),
        period: Util.defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
    }

    let _lastRequest = null;
    let _now = Date.now();
    let _retryTimes = 0;
    while ($tea.allowRetry(_runtime['retry'], _retryTimes, _now)) {
      if (_retryTimes > 0) {
        let _backoffTime = $tea.getBackoffTime(_runtime['backoff'], _retryTimes);
        if (_backoffTime > 0) {
          await $tea.sleep(_backoffTime);
        }
      }

      _retryTimes = _retryTimes + 1;
      try {
        let request_ = new $tea.Request();
        let accessKeyId = await this._credential.getAccessKeyId();
        let accessKeySecret = await this._credential.getAccessKeySecret();
        let token = await this._credential.getSecurityToken();
        request_.protocol = this._protocol;
        request_.method = "PUT";
        request_.pathname = `/${request.channelName}?live`;
        request_.headers = {
          host: OSSUtil.getHost(request.bucketName, this._regionId, this._endpoint, this._hostModel),
          date: Util.getDateUTCString(),
          'user-agent': this.getUserAgent(),
        };
        if (!Util.empty(token)) {
          request_.headers["x-oss-security-token"] = token;
        }

        request_.query = Util.stringifyMapValue($tea.toMap(request.filter));
        request_.headers["authorization"] = OSSUtil.getSignature(request_, request.bucketName, accessKeyId, accessKeySecret, this._signatureVersion, this._addtionalHeaders);
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap : {[key: string]: any} = null;
        let bodyStr : string = null;
        if (Util.is4xx(response_.statusCode) || Util.is5xx(response_.statusCode)) {
          bodyStr = await Util.readAsString(response_.body);
          respMap = OSSUtil.getErrMessage(bodyStr);
          throw $tea.newError({
            code: respMap["Code"],
            message: respMap["Message"],
            data: {
              httpCode: response_.statusCode,
              requestId: respMap["RequestId"],
              hostId: respMap["HostId"],
            },
          });
        }

        return $tea.cast<PutLiveChannelStatusResponse>({
          ...response_.headers,
        }, new PutLiveChannelStatusResponse({}));
      } catch (ex) {
        if ($tea.isRetryable(ex)) {
          continue;
        }
        throw ex;
      }
    }

    throw $tea.newUnretryableError(_lastRequest);
  }

  async initiateMultipartUpload(request: InitiateMultipartUploadRequest, runtime: $OSSUtil.RuntimeOptions): Promise<InitiateMultipartUploadResponse> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: Util.defaultNumber(runtime.readTimeout, this._readTimeout),
      connectTimeout: Util.defaultNumber(runtime.connectTimeout, this._connectTimeout),
      localAddr: Util.defaultString(runtime.localAddr, this._localAddr),
      httpProxy: Util.defaultString(runtime.httpProxy, this._httpProxy),
      httpsProxy: Util.defaultString(runtime.httpsProxy, this._httpsProxy),
      noProxy: Util.defaultString(runtime.noProxy, this._noProxy),
      socks5Proxy: Util.defaultString(runtime.socks5Proxy, this._socks5Proxy),
      socks5NetWork: Util.defaultString(runtime.socks5NetWork, this._socks5NetWork),
      maxIdleConns: Util.defaultNumber(runtime.maxIdleConns, this._maxIdleConns),
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: Util.defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: Util.defaultString(runtime.backoffPolicy, "no"),
        period: Util.defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
    }

    let _lastRequest = null;
    let _now = Date.now();
    let _retryTimes = 0;
    while ($tea.allowRetry(_runtime['retry'], _retryTimes, _now)) {
      if (_retryTimes > 0) {
        let _backoffTime = $tea.getBackoffTime(_runtime['backoff'], _retryTimes);
        if (_backoffTime > 0) {
          await $tea.sleep(_backoffTime);
        }
      }

      _retryTimes = _retryTimes + 1;
      try {
        let request_ = new $tea.Request();
        let accessKeyId = await this._credential.getAccessKeyId();
        let accessKeySecret = await this._credential.getAccessKeySecret();
        let token = await this._credential.getSecurityToken();
        request_.protocol = this._protocol;
        request_.method = "POST";
        request_.pathname = `/${request.objectName}?uploads`;
        request_.headers = {
          host: OSSUtil.getHost(request.bucketName, this._regionId, this._endpoint, this._hostModel),
          date: Util.getDateUTCString(),
          'user-agent': this.getUserAgent(),
          ...Util.stringifyMapValue($tea.toMap(request.header)),
        };
        if (!Util.empty(token)) {
          request_.headers["x-oss-security-token"] = token;
        }

        request_.query = Util.stringifyMapValue($tea.toMap(request.filter));
        if (!Util.isUnset($tea.toMap(request.header)) && !Util.empty(request.header.contentType)) {
          request_.headers["content-type"] = request.header.contentType;
        } else {
          request_.headers["content-type"] = OSSUtil.getContentType(request.objectName);
        }

        request_.headers["authorization"] = OSSUtil.getSignature(request_, request.bucketName, accessKeyId, accessKeySecret, this._signatureVersion, this._addtionalHeaders);
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap : {[key: string]: any} = null;
        let bodyStr : string = null;
        if (Util.is4xx(response_.statusCode) || Util.is5xx(response_.statusCode)) {
          bodyStr = await Util.readAsString(response_.body);
          respMap = OSSUtil.getErrMessage(bodyStr);
          throw $tea.newError({
            code: respMap["Code"],
            message: respMap["Message"],
            data: {
              httpCode: response_.statusCode,
              requestId: respMap["RequestId"],
              hostId: respMap["HostId"],
            },
          });
        }

        bodyStr = await Util.readAsString(response_.body);
        respMap = XML.parseXml(bodyStr, InitiateMultipartUploadResponse);
        return $tea.cast<InitiateMultipartUploadResponse>({
          InitiateMultipartUploadResult: respMap["InitiateMultipartUploadResult"],
          ...response_.headers,
        }, new InitiateMultipartUploadResponse({}));
      } catch (ex) {
        if ($tea.isRetryable(ex)) {
          continue;
        }
        throw ex;
      }
    }

    throw $tea.newUnretryableError(_lastRequest);
  }

  async optionObject(request: OptionObjectRequest, runtime: $OSSUtil.RuntimeOptions): Promise<OptionObjectResponse> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: Util.defaultNumber(runtime.readTimeout, this._readTimeout),
      connectTimeout: Util.defaultNumber(runtime.connectTimeout, this._connectTimeout),
      localAddr: Util.defaultString(runtime.localAddr, this._localAddr),
      httpProxy: Util.defaultString(runtime.httpProxy, this._httpProxy),
      httpsProxy: Util.defaultString(runtime.httpsProxy, this._httpsProxy),
      noProxy: Util.defaultString(runtime.noProxy, this._noProxy),
      socks5Proxy: Util.defaultString(runtime.socks5Proxy, this._socks5Proxy),
      socks5NetWork: Util.defaultString(runtime.socks5NetWork, this._socks5NetWork),
      maxIdleConns: Util.defaultNumber(runtime.maxIdleConns, this._maxIdleConns),
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: Util.defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: Util.defaultString(runtime.backoffPolicy, "no"),
        period: Util.defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
    }

    let _lastRequest = null;
    let _now = Date.now();
    let _retryTimes = 0;
    while ($tea.allowRetry(_runtime['retry'], _retryTimes, _now)) {
      if (_retryTimes > 0) {
        let _backoffTime = $tea.getBackoffTime(_runtime['backoff'], _retryTimes);
        if (_backoffTime > 0) {
          await $tea.sleep(_backoffTime);
        }
      }

      _retryTimes = _retryTimes + 1;
      try {
        let request_ = new $tea.Request();
        let accessKeyId = await this._credential.getAccessKeyId();
        let accessKeySecret = await this._credential.getAccessKeySecret();
        let token = await this._credential.getSecurityToken();
        request_.protocol = this._protocol;
        request_.method = "OPTIONS";
        request_.pathname = `/${request.objectName}`;
        request_.headers = {
          host: OSSUtil.getHost(request.bucketName, this._regionId, this._endpoint, this._hostModel),
          date: Util.getDateUTCString(),
          'user-agent': this.getUserAgent(),
          ...Util.stringifyMapValue($tea.toMap(request.header)),
        };
        if (!Util.empty(token)) {
          request_.headers["x-oss-security-token"] = token;
        }

        request_.headers["authorization"] = OSSUtil.getSignature(request_, request.bucketName, accessKeyId, accessKeySecret, this._signatureVersion, this._addtionalHeaders);
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap : {[key: string]: any} = null;
        let bodyStr : string = null;
        if (Util.is4xx(response_.statusCode) || Util.is5xx(response_.statusCode)) {
          bodyStr = await Util.readAsString(response_.body);
          respMap = OSSUtil.getErrMessage(bodyStr);
          throw $tea.newError({
            code: respMap["Code"],
            message: respMap["Message"],
            data: {
              httpCode: response_.statusCode,
              requestId: respMap["RequestId"],
              hostId: respMap["HostId"],
            },
          });
        }

        return $tea.cast<OptionObjectResponse>({
          ...response_.headers,
        }, new OptionObjectResponse({}));
      } catch (ex) {
        if ($tea.isRetryable(ex)) {
          continue;
        }
        throw ex;
      }
    }

    throw $tea.newUnretryableError(_lastRequest);
  }

  async postVodPlaylist(request: PostVodPlaylistRequest, runtime: $OSSUtil.RuntimeOptions): Promise<PostVodPlaylistResponse> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: Util.defaultNumber(runtime.readTimeout, this._readTimeout),
      connectTimeout: Util.defaultNumber(runtime.connectTimeout, this._connectTimeout),
      localAddr: Util.defaultString(runtime.localAddr, this._localAddr),
      httpProxy: Util.defaultString(runtime.httpProxy, this._httpProxy),
      httpsProxy: Util.defaultString(runtime.httpsProxy, this._httpsProxy),
      noProxy: Util.defaultString(runtime.noProxy, this._noProxy),
      socks5Proxy: Util.defaultString(runtime.socks5Proxy, this._socks5Proxy),
      socks5NetWork: Util.defaultString(runtime.socks5NetWork, this._socks5NetWork),
      maxIdleConns: Util.defaultNumber(runtime.maxIdleConns, this._maxIdleConns),
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: Util.defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: Util.defaultString(runtime.backoffPolicy, "no"),
        period: Util.defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
    }

    let _lastRequest = null;
    let _now = Date.now();
    let _retryTimes = 0;
    while ($tea.allowRetry(_runtime['retry'], _retryTimes, _now)) {
      if (_retryTimes > 0) {
        let _backoffTime = $tea.getBackoffTime(_runtime['backoff'], _retryTimes);
        if (_backoffTime > 0) {
          await $tea.sleep(_backoffTime);
        }
      }

      _retryTimes = _retryTimes + 1;
      try {
        let request_ = new $tea.Request();
        let accessKeyId = await this._credential.getAccessKeyId();
        let accessKeySecret = await this._credential.getAccessKeySecret();
        let token = await this._credential.getSecurityToken();
        request_.protocol = this._protocol;
        request_.method = "POST";
        request_.pathname = `/${request.channelName}/${request.playlistName}?vod`;
        request_.headers = {
          host: OSSUtil.getHost(request.bucketName, this._regionId, this._endpoint, this._hostModel),
          date: Util.getDateUTCString(),
          'user-agent': this.getUserAgent(),
        };
        if (!Util.empty(token)) {
          request_.headers["x-oss-security-token"] = token;
        }

        request_.query = Util.stringifyMapValue($tea.toMap(request.filter));
        request_.headers["authorization"] = OSSUtil.getSignature(request_, request.bucketName, accessKeyId, accessKeySecret, this._signatureVersion, this._addtionalHeaders);
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap : {[key: string]: any} = null;
        let bodyStr : string = null;
        if (Util.is4xx(response_.statusCode) || Util.is5xx(response_.statusCode)) {
          bodyStr = await Util.readAsString(response_.body);
          respMap = OSSUtil.getErrMessage(bodyStr);
          throw $tea.newError({
            code: respMap["Code"],
            message: respMap["Message"],
            data: {
              httpCode: response_.statusCode,
              requestId: respMap["RequestId"],
              hostId: respMap["HostId"],
            },
          });
        }

        return $tea.cast<PostVodPlaylistResponse>({
          ...response_.headers,
        }, new PostVodPlaylistResponse({}));
      } catch (ex) {
        if ($tea.isRetryable(ex)) {
          continue;
        }
        throw ex;
      }
    }

    throw $tea.newUnretryableError(_lastRequest);
  }

  async postObject(request: PostObjectRequest, runtime: $OSSUtil.RuntimeOptions): Promise<PostObjectResponse> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: Util.defaultNumber(runtime.readTimeout, this._readTimeout),
      connectTimeout: Util.defaultNumber(runtime.connectTimeout, this._connectTimeout),
      httpProxy: Util.defaultString(runtime.httpProxy, this._httpProxy),
      httpsProxy: Util.defaultString(runtime.httpsProxy, this._httpsProxy),
      noProxy: Util.defaultString(runtime.noProxy, this._noProxy),
      maxIdleConns: Util.defaultNumber(runtime.maxIdleConns, this._maxIdleConns),
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: Util.defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: Util.defaultString(runtime.backoffPolicy, "no"),
        period: Util.defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
    }

    let _lastRequest = null;
    let _now = Date.now();
    let _retryTimes = 0;
    while ($tea.allowRetry(_runtime['retry'], _retryTimes, _now)) {
      if (_retryTimes > 0) {
        let _backoffTime = $tea.getBackoffTime(_runtime['backoff'], _retryTimes);
        if (_backoffTime > 0) {
          await $tea.sleep(_backoffTime);
        }
      }

      _retryTimes = _retryTimes + 1;
      try {
        let request_ = new $tea.Request();
        let boundary = FileForm.getBoundary();
        request_.protocol = this._protocol;
        request_.method = "POST";
        request_.pathname = `/`;
        request_.headers = {
          host: OSSUtil.getHost(request.bucketName, this._regionId, this._endpoint, this._hostModel),
          date: Util.getDateUTCString(),
          'user-agent': this.getUserAgent(),
        };
        request_.headers["content-type"] = `multipart/form-data; boundary=${boundary}`;
        let form = {
          OSSAccessKeyId: request.header.accessKeyId,
          policy: request.header.policy,
          Signature: request.header.signature,
          key: request.header.key,
          success_action_status: request.header.successActionStatus,
          file: request.header.file,
          ...OSSUtil.toMeta(request.header.userMeta, "x-oss-meta-"),
        };
        request_.body = FileForm.toFileForm(form, boundary);
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap : {[key: string]: any} = null;
        let bodyStr = await Util.readAsString(response_.body);
        if (Util.is4xx(response_.statusCode) || Util.is5xx(response_.statusCode)) {
          respMap = OSSUtil.getErrMessage(bodyStr);
          throw $tea.newError({
            code: respMap["Code"],
            message: respMap["Message"],
            data: {
              httpCode: response_.statusCode,
              requestId: respMap["RequestId"],
              hostId: respMap["HostId"],
            },
          });
        }

        respMap = XML.parseXml(bodyStr, PostObjectResponse);
        return $tea.cast<PostObjectResponse>({
          ...respMap,
        }, new PostObjectResponse({}));
      } catch (ex) {
        if ($tea.isRetryable(ex)) {
          continue;
        }
        throw ex;
      }
    }

    throw $tea.newUnretryableError(_lastRequest);
  }

  async headObject(request: HeadObjectRequest, runtime: $OSSUtil.RuntimeOptions): Promise<HeadObjectResponse> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: Util.defaultNumber(runtime.readTimeout, this._readTimeout),
      connectTimeout: Util.defaultNumber(runtime.connectTimeout, this._connectTimeout),
      localAddr: Util.defaultString(runtime.localAddr, this._localAddr),
      httpProxy: Util.defaultString(runtime.httpProxy, this._httpProxy),
      httpsProxy: Util.defaultString(runtime.httpsProxy, this._httpsProxy),
      noProxy: Util.defaultString(runtime.noProxy, this._noProxy),
      socks5Proxy: Util.defaultString(runtime.socks5Proxy, this._socks5Proxy),
      socks5NetWork: Util.defaultString(runtime.socks5NetWork, this._socks5NetWork),
      maxIdleConns: Util.defaultNumber(runtime.maxIdleConns, this._maxIdleConns),
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: Util.defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: Util.defaultString(runtime.backoffPolicy, "no"),
        period: Util.defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
    }

    let _lastRequest = null;
    let _now = Date.now();
    let _retryTimes = 0;
    while ($tea.allowRetry(_runtime['retry'], _retryTimes, _now)) {
      if (_retryTimes > 0) {
        let _backoffTime = $tea.getBackoffTime(_runtime['backoff'], _retryTimes);
        if (_backoffTime > 0) {
          await $tea.sleep(_backoffTime);
        }
      }

      _retryTimes = _retryTimes + 1;
      try {
        let request_ = new $tea.Request();
        let accessKeyId = await this._credential.getAccessKeyId();
        let accessKeySecret = await this._credential.getAccessKeySecret();
        let token = await this._credential.getSecurityToken();
        request_.protocol = this._protocol;
        request_.method = "HEAD";
        request_.pathname = `/${request.objectName}`;
        request_.headers = {
          host: OSSUtil.getHost(request.bucketName, this._regionId, this._endpoint, this._hostModel),
          date: Util.getDateUTCString(),
          'user-agent': this.getUserAgent(),
          ...Util.stringifyMapValue($tea.toMap(request.header)),
        };
        if (!Util.empty(token)) {
          request_.headers["x-oss-security-token"] = token;
        }

        request_.headers["authorization"] = OSSUtil.getSignature(request_, request.bucketName, accessKeyId, accessKeySecret, this._signatureVersion, this._addtionalHeaders);
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap : {[key: string]: any} = null;
        let bodyStr : string = null;
        if (Util.is4xx(response_.statusCode) || Util.is5xx(response_.statusCode)) {
          bodyStr = await Util.readAsString(response_.body);
          respMap = OSSUtil.getErrMessage(bodyStr);
          throw $tea.newError({
            code: respMap["Code"],
            message: respMap["Message"],
            data: {
              httpCode: response_.statusCode,
              requestId: respMap["RequestId"],
              hostId: respMap["HostId"],
            },
          });
        }

        return $tea.cast<HeadObjectResponse>({
          usermeta: OSSUtil.toMeta(response_.headers, "x-oss-meta-"),
          ...response_.headers,
        }, new HeadObjectResponse({}));
      } catch (ex) {
        if ($tea.isRetryable(ex)) {
          continue;
        }
        throw ex;
      }
    }

    throw $tea.newUnretryableError(_lastRequest);
  }

  async deleteObjectTagging(request: DeleteObjectTaggingRequest, runtime: $OSSUtil.RuntimeOptions): Promise<DeleteObjectTaggingResponse> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: Util.defaultNumber(runtime.readTimeout, this._readTimeout),
      connectTimeout: Util.defaultNumber(runtime.connectTimeout, this._connectTimeout),
      localAddr: Util.defaultString(runtime.localAddr, this._localAddr),
      httpProxy: Util.defaultString(runtime.httpProxy, this._httpProxy),
      httpsProxy: Util.defaultString(runtime.httpsProxy, this._httpsProxy),
      noProxy: Util.defaultString(runtime.noProxy, this._noProxy),
      socks5Proxy: Util.defaultString(runtime.socks5Proxy, this._socks5Proxy),
      socks5NetWork: Util.defaultString(runtime.socks5NetWork, this._socks5NetWork),
      maxIdleConns: Util.defaultNumber(runtime.maxIdleConns, this._maxIdleConns),
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: Util.defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: Util.defaultString(runtime.backoffPolicy, "no"),
        period: Util.defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
    }

    let _lastRequest = null;
    let _now = Date.now();
    let _retryTimes = 0;
    while ($tea.allowRetry(_runtime['retry'], _retryTimes, _now)) {
      if (_retryTimes > 0) {
        let _backoffTime = $tea.getBackoffTime(_runtime['backoff'], _retryTimes);
        if (_backoffTime > 0) {
          await $tea.sleep(_backoffTime);
        }
      }

      _retryTimes = _retryTimes + 1;
      try {
        let request_ = new $tea.Request();
        let accessKeyId = await this._credential.getAccessKeyId();
        let accessKeySecret = await this._credential.getAccessKeySecret();
        let token = await this._credential.getSecurityToken();
        request_.protocol = this._protocol;
        request_.method = "DELETE";
        request_.pathname = `/${request.objectName}?tagging`;
        request_.headers = {
          host: OSSUtil.getHost(request.bucketName, this._regionId, this._endpoint, this._hostModel),
          date: Util.getDateUTCString(),
          'user-agent': this.getUserAgent(),
        };
        if (!Util.empty(token)) {
          request_.headers["x-oss-security-token"] = token;
        }

        request_.headers["authorization"] = OSSUtil.getSignature(request_, request.bucketName, accessKeyId, accessKeySecret, this._signatureVersion, this._addtionalHeaders);
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap : {[key: string]: any} = null;
        let bodyStr : string = null;
        if (Util.is4xx(response_.statusCode) || Util.is5xx(response_.statusCode)) {
          bodyStr = await Util.readAsString(response_.body);
          respMap = OSSUtil.getErrMessage(bodyStr);
          throw $tea.newError({
            code: respMap["Code"],
            message: respMap["Message"],
            data: {
              httpCode: response_.statusCode,
              requestId: respMap["RequestId"],
              hostId: respMap["HostId"],
            },
          });
        }

        return $tea.cast<DeleteObjectTaggingResponse>({
          ...response_.headers,
        }, new DeleteObjectTaggingResponse({}));
      } catch (ex) {
        if ($tea.isRetryable(ex)) {
          continue;
        }
        throw ex;
      }
    }

    throw $tea.newUnretryableError(_lastRequest);
  }

  async restoreObject(request: RestoreObjectRequest, runtime: $OSSUtil.RuntimeOptions): Promise<RestoreObjectResponse> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: Util.defaultNumber(runtime.readTimeout, this._readTimeout),
      connectTimeout: Util.defaultNumber(runtime.connectTimeout, this._connectTimeout),
      localAddr: Util.defaultString(runtime.localAddr, this._localAddr),
      httpProxy: Util.defaultString(runtime.httpProxy, this._httpProxy),
      httpsProxy: Util.defaultString(runtime.httpsProxy, this._httpsProxy),
      noProxy: Util.defaultString(runtime.noProxy, this._noProxy),
      socks5Proxy: Util.defaultString(runtime.socks5Proxy, this._socks5Proxy),
      socks5NetWork: Util.defaultString(runtime.socks5NetWork, this._socks5NetWork),
      maxIdleConns: Util.defaultNumber(runtime.maxIdleConns, this._maxIdleConns),
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: Util.defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: Util.defaultString(runtime.backoffPolicy, "no"),
        period: Util.defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
    }

    let _lastRequest = null;
    let _now = Date.now();
    let _retryTimes = 0;
    while ($tea.allowRetry(_runtime['retry'], _retryTimes, _now)) {
      if (_retryTimes > 0) {
        let _backoffTime = $tea.getBackoffTime(_runtime['backoff'], _retryTimes);
        if (_backoffTime > 0) {
          await $tea.sleep(_backoffTime);
        }
      }

      _retryTimes = _retryTimes + 1;
      try {
        let request_ = new $tea.Request();
        let accessKeyId = await this._credential.getAccessKeyId();
        let accessKeySecret = await this._credential.getAccessKeySecret();
        let token = await this._credential.getSecurityToken();
        request_.protocol = this._protocol;
        request_.method = "POST";
        request_.pathname = `/${request.objectName}?restore`;
        request_.headers = {
          host: OSSUtil.getHost(request.bucketName, this._regionId, this._endpoint, this._hostModel),
          date: Util.getDateUTCString(),
          'user-agent': this.getUserAgent(),
        };
        if (!Util.empty(token)) {
          request_.headers["x-oss-security-token"] = token;
        }

        request_.headers["authorization"] = OSSUtil.getSignature(request_, request.bucketName, accessKeyId, accessKeySecret, this._signatureVersion, this._addtionalHeaders);
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap : {[key: string]: any} = null;
        let bodyStr : string = null;
        if (Util.is4xx(response_.statusCode) || Util.is5xx(response_.statusCode)) {
          bodyStr = await Util.readAsString(response_.body);
          respMap = OSSUtil.getErrMessage(bodyStr);
          throw $tea.newError({
            code: respMap["Code"],
            message: respMap["Message"],
            data: {
              httpCode: response_.statusCode,
              requestId: respMap["RequestId"],
              hostId: respMap["HostId"],
            },
          });
        }

        return $tea.cast<RestoreObjectResponse>({
          ...response_.headers,
        }, new RestoreObjectResponse({}));
      } catch (ex) {
        if ($tea.isRetryable(ex)) {
          continue;
        }
        throw ex;
      }
    }

    throw $tea.newUnretryableError(_lastRequest);
  }

  async getObjectAcl(request: GetObjectAclRequest, runtime: $OSSUtil.RuntimeOptions): Promise<GetObjectAclResponse> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: Util.defaultNumber(runtime.readTimeout, this._readTimeout),
      connectTimeout: Util.defaultNumber(runtime.connectTimeout, this._connectTimeout),
      localAddr: Util.defaultString(runtime.localAddr, this._localAddr),
      httpProxy: Util.defaultString(runtime.httpProxy, this._httpProxy),
      httpsProxy: Util.defaultString(runtime.httpsProxy, this._httpsProxy),
      noProxy: Util.defaultString(runtime.noProxy, this._noProxy),
      socks5Proxy: Util.defaultString(runtime.socks5Proxy, this._socks5Proxy),
      socks5NetWork: Util.defaultString(runtime.socks5NetWork, this._socks5NetWork),
      maxIdleConns: Util.defaultNumber(runtime.maxIdleConns, this._maxIdleConns),
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: Util.defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: Util.defaultString(runtime.backoffPolicy, "no"),
        period: Util.defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
    }

    let _lastRequest = null;
    let _now = Date.now();
    let _retryTimes = 0;
    while ($tea.allowRetry(_runtime['retry'], _retryTimes, _now)) {
      if (_retryTimes > 0) {
        let _backoffTime = $tea.getBackoffTime(_runtime['backoff'], _retryTimes);
        if (_backoffTime > 0) {
          await $tea.sleep(_backoffTime);
        }
      }

      _retryTimes = _retryTimes + 1;
      try {
        let request_ = new $tea.Request();
        let accessKeyId = await this._credential.getAccessKeyId();
        let accessKeySecret = await this._credential.getAccessKeySecret();
        let token = await this._credential.getSecurityToken();
        request_.protocol = this._protocol;
        request_.method = "GET";
        request_.pathname = `/${request.objectName}?acl`;
        request_.headers = {
          host: OSSUtil.getHost(request.bucketName, this._regionId, this._endpoint, this._hostModel),
          date: Util.getDateUTCString(),
          'user-agent': this.getUserAgent(),
        };
        if (!Util.empty(token)) {
          request_.headers["x-oss-security-token"] = token;
        }

        request_.headers["authorization"] = OSSUtil.getSignature(request_, request.bucketName, accessKeyId, accessKeySecret, this._signatureVersion, this._addtionalHeaders);
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap : {[key: string]: any} = null;
        let bodyStr : string = null;
        if (Util.is4xx(response_.statusCode) || Util.is5xx(response_.statusCode)) {
          bodyStr = await Util.readAsString(response_.body);
          respMap = OSSUtil.getErrMessage(bodyStr);
          throw $tea.newError({
            code: respMap["Code"],
            message: respMap["Message"],
            data: {
              httpCode: response_.statusCode,
              requestId: respMap["RequestId"],
              hostId: respMap["HostId"],
            },
          });
        }

        bodyStr = await Util.readAsString(response_.body);
        respMap = XML.parseXml(bodyStr, GetObjectAclResponse);
        return $tea.cast<GetObjectAclResponse>({
          AccessControlPolicy: respMap["AccessControlPolicy"],
          ...response_.headers,
        }, new GetObjectAclResponse({}));
      } catch (ex) {
        if ($tea.isRetryable(ex)) {
          continue;
        }
        throw ex;
      }
    }

    throw $tea.newUnretryableError(_lastRequest);
  }

  async putBucketAcl(request: PutBucketAclRequest, runtime: $OSSUtil.RuntimeOptions): Promise<PutBucketAclResponse> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: Util.defaultNumber(runtime.readTimeout, this._readTimeout),
      connectTimeout: Util.defaultNumber(runtime.connectTimeout, this._connectTimeout),
      localAddr: Util.defaultString(runtime.localAddr, this._localAddr),
      httpProxy: Util.defaultString(runtime.httpProxy, this._httpProxy),
      httpsProxy: Util.defaultString(runtime.httpsProxy, this._httpsProxy),
      noProxy: Util.defaultString(runtime.noProxy, this._noProxy),
      socks5Proxy: Util.defaultString(runtime.socks5Proxy, this._socks5Proxy),
      socks5NetWork: Util.defaultString(runtime.socks5NetWork, this._socks5NetWork),
      maxIdleConns: Util.defaultNumber(runtime.maxIdleConns, this._maxIdleConns),
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: Util.defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: Util.defaultString(runtime.backoffPolicy, "no"),
        period: Util.defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
    }

    let _lastRequest = null;
    let _now = Date.now();
    let _retryTimes = 0;
    while ($tea.allowRetry(_runtime['retry'], _retryTimes, _now)) {
      if (_retryTimes > 0) {
        let _backoffTime = $tea.getBackoffTime(_runtime['backoff'], _retryTimes);
        if (_backoffTime > 0) {
          await $tea.sleep(_backoffTime);
        }
      }

      _retryTimes = _retryTimes + 1;
      try {
        let request_ = new $tea.Request();
        let accessKeyId = await this._credential.getAccessKeyId();
        let accessKeySecret = await this._credential.getAccessKeySecret();
        let token = await this._credential.getSecurityToken();
        request_.protocol = this._protocol;
        request_.method = "PUT";
        request_.pathname = `/?acl`;
        request_.headers = {
          host: OSSUtil.getHost(request.bucketName, this._regionId, this._endpoint, this._hostModel),
          date: Util.getDateUTCString(),
          'user-agent': this.getUserAgent(),
          ...Util.stringifyMapValue($tea.toMap(request.header)),
        };
        if (!Util.empty(token)) {
          request_.headers["x-oss-security-token"] = token;
        }

        request_.headers["authorization"] = OSSUtil.getSignature(request_, request.bucketName, accessKeyId, accessKeySecret, this._signatureVersion, this._addtionalHeaders);
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap : {[key: string]: any} = null;
        let bodyStr : string = null;
        if (Util.is4xx(response_.statusCode) || Util.is5xx(response_.statusCode)) {
          bodyStr = await Util.readAsString(response_.body);
          respMap = OSSUtil.getErrMessage(bodyStr);
          throw $tea.newError({
            code: respMap["Code"],
            message: respMap["Message"],
            data: {
              httpCode: response_.statusCode,
              requestId: respMap["RequestId"],
              hostId: respMap["HostId"],
            },
          });
        }

        return $tea.cast<PutBucketAclResponse>({
          ...response_.headers,
        }, new PutBucketAclResponse({}));
      } catch (ex) {
        if ($tea.isRetryable(ex)) {
          continue;
        }
        throw ex;
      }
    }

    throw $tea.newUnretryableError(_lastRequest);
  }

  async deleteBucket(request: DeleteBucketRequest, runtime: $OSSUtil.RuntimeOptions): Promise<DeleteBucketResponse> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: Util.defaultNumber(runtime.readTimeout, this._readTimeout),
      connectTimeout: Util.defaultNumber(runtime.connectTimeout, this._connectTimeout),
      localAddr: Util.defaultString(runtime.localAddr, this._localAddr),
      httpProxy: Util.defaultString(runtime.httpProxy, this._httpProxy),
      httpsProxy: Util.defaultString(runtime.httpsProxy, this._httpsProxy),
      noProxy: Util.defaultString(runtime.noProxy, this._noProxy),
      socks5Proxy: Util.defaultString(runtime.socks5Proxy, this._socks5Proxy),
      socks5NetWork: Util.defaultString(runtime.socks5NetWork, this._socks5NetWork),
      maxIdleConns: Util.defaultNumber(runtime.maxIdleConns, this._maxIdleConns),
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: Util.defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: Util.defaultString(runtime.backoffPolicy, "no"),
        period: Util.defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
    }

    let _lastRequest = null;
    let _now = Date.now();
    let _retryTimes = 0;
    while ($tea.allowRetry(_runtime['retry'], _retryTimes, _now)) {
      if (_retryTimes > 0) {
        let _backoffTime = $tea.getBackoffTime(_runtime['backoff'], _retryTimes);
        if (_backoffTime > 0) {
          await $tea.sleep(_backoffTime);
        }
      }

      _retryTimes = _retryTimes + 1;
      try {
        let request_ = new $tea.Request();
        let accessKeyId = await this._credential.getAccessKeyId();
        let accessKeySecret = await this._credential.getAccessKeySecret();
        let token = await this._credential.getSecurityToken();
        request_.protocol = this._protocol;
        request_.method = "DELETE";
        request_.pathname = `/`;
        request_.headers = {
          host: OSSUtil.getHost(request.bucketName, this._regionId, this._endpoint, this._hostModel),
          date: Util.getDateUTCString(),
          'user-agent': this.getUserAgent(),
        };
        if (!Util.empty(token)) {
          request_.headers["x-oss-security-token"] = token;
        }

        request_.headers["authorization"] = OSSUtil.getSignature(request_, request.bucketName, accessKeyId, accessKeySecret, this._signatureVersion, this._addtionalHeaders);
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap : {[key: string]: any} = null;
        let bodyStr : string = null;
        if (Util.is4xx(response_.statusCode) || Util.is5xx(response_.statusCode)) {
          bodyStr = await Util.readAsString(response_.body);
          respMap = OSSUtil.getErrMessage(bodyStr);
          throw $tea.newError({
            code: respMap["Code"],
            message: respMap["Message"],
            data: {
              httpCode: response_.statusCode,
              requestId: respMap["RequestId"],
              hostId: respMap["HostId"],
            },
          });
        }

        return $tea.cast<DeleteBucketResponse>({
          ...response_.headers,
        }, new DeleteBucketResponse({}));
      } catch (ex) {
        if ($tea.isRetryable(ex)) {
          continue;
        }
        throw ex;
      }
    }

    throw $tea.newUnretryableError(_lastRequest);
  }

  async putObject(request: PutObjectRequest, runtime: $OSSUtil.RuntimeOptions): Promise<PutObjectResponse> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: Util.defaultNumber(runtime.readTimeout, this._readTimeout),
      connectTimeout: Util.defaultNumber(runtime.connectTimeout, this._connectTimeout),
      localAddr: Util.defaultString(runtime.localAddr, this._localAddr),
      httpProxy: Util.defaultString(runtime.httpProxy, this._httpProxy),
      httpsProxy: Util.defaultString(runtime.httpsProxy, this._httpsProxy),
      noProxy: Util.defaultString(runtime.noProxy, this._noProxy),
      socks5Proxy: Util.defaultString(runtime.socks5Proxy, this._socks5Proxy),
      socks5NetWork: Util.defaultString(runtime.socks5NetWork, this._socks5NetWork),
      maxIdleConns: Util.defaultNumber(runtime.maxIdleConns, this._maxIdleConns),
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: Util.defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: Util.defaultString(runtime.backoffPolicy, "no"),
        period: Util.defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
    }

    let _lastRequest = null;
    let _now = Date.now();
    let _retryTimes = 0;
    while ($tea.allowRetry(_runtime['retry'], _retryTimes, _now)) {
      if (_retryTimes > 0) {
        let _backoffTime = $tea.getBackoffTime(_runtime['backoff'], _retryTimes);
        if (_backoffTime > 0) {
          await $tea.sleep(_backoffTime);
        }
      }

      _retryTimes = _retryTimes + 1;
      try {
        let request_ = new $tea.Request();
        let ctx : {[key: string ]: string} = { };
        let accessKeyId = await this._credential.getAccessKeyId();
        let accessKeySecret = await this._credential.getAccessKeySecret();
        let token = await this._credential.getSecurityToken();
        request_.protocol = this._protocol;
        request_.method = "PUT";
        request_.pathname = `/${request.objectName}`;
        request_.headers = {
          host: OSSUtil.getHost(request.bucketName, this._regionId, this._endpoint, this._hostModel),
          date: Util.getDateUTCString(),
          'user-agent': this.getUserAgent(),
          ...Util.stringifyMapValue($tea.toMap(request.header)),
          ...OSSUtil.parseMeta(request.userMeta, "x-oss-meta-"),
        };
        if (!Util.empty(token)) {
          request_.headers["x-oss-security-token"] = token;
        }

        request_.body = OSSUtil.inject(request.body, ctx);
        if (!Util.isUnset($tea.toMap(request.header)) && !Util.empty(request.header.contentType)) {
          request_.headers["content-type"] = request.header.contentType;
        } else {
          request_.headers["content-type"] = OSSUtil.getContentType(request.objectName);
        }

        request_.headers["authorization"] = OSSUtil.getSignature(request_, request.bucketName, accessKeyId, accessKeySecret, this._signatureVersion, this._addtionalHeaders);
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap : {[key: string]: any} = null;
        let bodyStr : string = null;
        if (Util.is4xx(response_.statusCode) || Util.is5xx(response_.statusCode)) {
          bodyStr = await Util.readAsString(response_.body);
          respMap = OSSUtil.getErrMessage(bodyStr);
          throw $tea.newError({
            code: respMap["Code"],
            message: respMap["Message"],
            data: {
              httpCode: response_.statusCode,
              requestId: respMap["RequestId"],
              hostId: respMap["HostId"],
            },
          });
        }

        if (this._isEnableCrc && !Util.equalString(ctx["crc"], response_.headers["x-oss-hash-crc64ecma"])) {
          throw $tea.newError({
            code: "CrcNotMatched",
            data: {
              clientCrc: ctx["crc"],
              serverCrc: response_.headers["x-oss-hash-crc64ecma"],
            },
          });
        }

        if (this._isEnableMD5 && !Util.equalString(ctx["md5"], response_.headers["content-md5"])) {
          throw $tea.newError({
            code: "MD5NotMatched",
            data: {
              clientMD5: ctx["md5"],
              serverMD5: response_.headers["content-md5"],
            },
          });
        }

        return $tea.cast<PutObjectResponse>({
          ...response_.headers,
        }, new PutObjectResponse({}));
      } catch (ex) {
        if ($tea.isRetryable(ex)) {
          continue;
        }
        throw ex;
      }
    }

    throw $tea.newUnretryableError(_lastRequest);
  }

  setUserAgent(userAgent: string): void {
    this._userAgent = userAgent;
  }

  appendUserAgent(userAgent: string): void {
    this._userAgent = `${this._userAgent} ${userAgent}`;
  }

  getUserAgent(): string {
    let userAgent = Util.getUserAgent(this._userAgent);
    return userAgent;
  }

  async getAccessKeyId(): Promise<string> {
    if (Util.isUnset(this._credential)) {
      return "";
    }

    let accessKeyId = await this._credential.getAccessKeyId();
    return accessKeyId;
  }

  async getAccessKeySecret(): Promise<string> {
    if (Util.isUnset(this._credential)) {
      return "";
    }

    let secret = await this._credential.getAccessKeySecret();
    return secret;
  }

}
