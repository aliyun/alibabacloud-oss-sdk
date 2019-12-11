// This file is auto-generated, don't edit it
import { Readable } from 'stream';
import * as $tea from '@alicloud/tea-typescript';
import BaseClient from '@alicloud/oss-baseclient';

export class RuntimeObject extends $tea.Model {
  autoretry?: boolean;
  ignoreSSL?: boolean;
  maxAttempts?: number;
  backoffPolicy?: string;
  backoffPeriod?: number;
  readTimeout?: number;
  connectTimeout?: number;
  localAddr?: string;
  httpProxy?: string;
  httpsProxy?: string;
  noProxy?: string;
  maxIdleConns?: number;
  socks5Proxy?: string;
  socks5NetWork?: string;
  md5Threshold?: number;
  uploadLimitSpeed?: number;
  listener?: any;
  static names(): { [key: string]: string } {
    return {
      autoretry: 'autoretry',
      ignoreSSL: 'ignoreSSL',
      maxAttempts: 'maxAttempts',
      backoffPolicy: 'backoffPolicy',
      backoffPeriod: 'backoffPeriod',
      readTimeout: 'readTimeout',
      connectTimeout: 'connectTimeout',
      localAddr: 'localAddr',
      httpProxy: 'httpProxy',
      httpsProxy: 'httpsProxy',
      noProxy: 'noProxy',
      maxIdleConns: 'maxIdleConns',
      socks5Proxy: 'socks5Proxy',
      socks5NetWork: 'socks5NetWork',
      md5Threshold: 'MD5Threshold',
      uploadLimitSpeed: 'uploadLimitSpeed',
      listener: 'listener',
    };
  }

  static types(): { [key: string]: any } {
    return {
      autoretry: 'boolean',
      ignoreSSL: 'boolean',
      maxAttempts: 'number',
      backoffPolicy: 'string',
      backoffPeriod: 'number',
      readTimeout: 'number',
      connectTimeout: 'number',
      localAddr: 'string',
      httpProxy: 'string',
      httpsProxy: 'string',
      noProxy: 'string',
      maxIdleConns: 'number',
      socks5Proxy: 'string',
      socks5NetWork: 'string',
      md5Threshold: 'number',
      uploadLimitSpeed: 'number',
      listener: 'any',
    };
  }

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class Config extends $tea.Model {
  accessKeyId?: string;
  accessKeySecret?: string;
  type: string;
  securityToken: string;
  endpoint: string;
  protocol: string;
  regionId: string;
  userAgent: string;
  hostModel: string;
  signatureVersion: string;
  isEnableMD5: boolean;
  isEnableCrc: boolean;
  readTimeout: number;
  connectTimeout: number;
  localAddr: string;
  httpProxy: string;
  httpsProxy: string;
  noProxy: string;
  socks5Proxy: string;
  socks5NetWork: string;
  maxIdleConns: number;
  addtionalHeaders: string[];
  static names(): { [key: string]: string } {
    return {
      accessKeyId: 'accessKeyId',
      accessKeySecret: 'accessKeySecret',
      type: 'type',
      securityToken: 'securityToken',
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
      accessKeyId: 'string',
      accessKeySecret: 'string',
      type: 'string',
      securityToken: 'string',
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

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class ServerError extends $tea.Model {
  code?: string;
  message?: string;
  requestId?: string;
  hostId?: string;
  static names(): { [key: string]: string } {
    return {
      code: 'Code',
      message: 'Message',
      requestId: 'RequestId',
      hostId: 'HostId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
      message: 'string',
      requestId: 'string',
      hostId: 'string',
    };
  }

  constructor(map: { [key: string]: any }) {
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

  constructor(map: { [key: string]: any }) {
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

  constructor(map: { [key: string]: any }) {
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

  constructor(map: { [key: string]: any }) {
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

  constructor(map: { [key: string]: any }) {
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

  constructor(map: { [key: string]: any }) {
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

  constructor(map: { [key: string]: any }) {
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

  constructor(map: { [key: string]: any }) {
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

  constructor(map: { [key: string]: any }) {
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

  constructor(map: { [key: string]: any }) {
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

  constructor(map: { [key: string]: any }) {
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

  constructor(map: { [key: string]: any }) {
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

  constructor(map: { [key: string]: any }) {
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

  constructor(map: { [key: string]: any }) {
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

  constructor(map: { [key: string]: any }) {
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

  constructor(map: { [key: string]: any }) {
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

  constructor(map: { [key: string]: any }) {
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

  constructor(map: { [key: string]: any }) {
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

  constructor(map: { [key: string]: any }) {
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

  constructor(map: { [key: string]: any }) {
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

  constructor(map: { [key: string]: any }) {
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

  constructor(map: { [key: string]: any }) {
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

  constructor(map: { [key: string]: any }) {
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

  constructor(map: { [key: string]: any }) {
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

  constructor(map: { [key: string]: any }) {
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
      userMeta: 'map',
      body: 'Readable',
      filter: AppendObjectRequestFilter,
      header: AppendObjectRequestHeader,
    };
  }

  constructor(map: { [key: string]: any }) {
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

  constructor(map: { [key: string]: any }) {
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

  constructor(map: { [key: string]: any }) {
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

  constructor(map: { [key: string]: any }) {
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

  constructor(map: { [key: string]: any }) {
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

  constructor(map: { [key: string]: any }) {
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

  constructor(map: { [key: string]: any }) {
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

  constructor(map: { [key: string]: any }) {
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

  constructor(map: { [key: string]: any }) {
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

  constructor(map: { [key: string]: any }) {
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

  constructor(map: { [key: string]: any }) {
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

  constructor(map: { [key: string]: any }) {
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

  constructor(map: { [key: string]: any }) {
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

  constructor(map: { [key: string]: any }) {
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

  constructor(map: { [key: string]: any }) {
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

  constructor(map: { [key: string]: any }) {
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

  constructor(map: { [key: string]: any }) {
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

  constructor(map: { [key: string]: any }) {
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

  constructor(map: { [key: string]: any }) {
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

  constructor(map: { [key: string]: any }) {
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

  constructor(map: { [key: string]: any }) {
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

  constructor(map: { [key: string]: any }) {
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

  constructor(map: { [key: string]: any }) {
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

  constructor(map: { [key: string]: any }) {
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

  constructor(map: { [key: string]: any }) {
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

  constructor(map: { [key: string]: any }) {
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

  constructor(map: { [key: string]: any }) {
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

  constructor(map: { [key: string]: any }) {
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

  constructor(map: { [key: string]: any }) {
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

  constructor(map: { [key: string]: any }) {
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

  constructor(map: { [key: string]: any }) {
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

  constructor(map: { [key: string]: any }) {
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

  constructor(map: { [key: string]: any }) {
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

  constructor(map: { [key: string]: any }) {
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

  constructor(map: { [key: string]: any }) {
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

  constructor(map: { [key: string]: any }) {
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

  constructor(map: { [key: string]: any }) {
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

  constructor(map: { [key: string]: any }) {
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

  constructor(map: { [key: string]: any }) {
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

  constructor(map: { [key: string]: any }) {
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

  constructor(map: { [key: string]: any }) {
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

  constructor(map: { [key: string]: any }) {
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

  constructor(map: { [key: string]: any }) {
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

  constructor(map: { [key: string]: any }) {
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

  constructor(map: { [key: string]: any }) {
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

  constructor(map: { [key: string]: any }) {
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

  constructor(map: { [key: string]: any }) {
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

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class PostObjectRequest extends $tea.Model {
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

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class PostObjectResponse extends $tea.Model {
  requestId: string;
  serverSideEncryption: string;
  static names(): { [key: string]: string } {
    return {
      requestId: 'x-oss-request-id',
      serverSideEncryption: 'x-oss-server-side-encryption',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
      serverSideEncryption: 'string',
    };
  }

  constructor(map: { [key: string]: any }) {
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

  constructor(map: { [key: string]: any }) {
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
      userMeta: 'map',
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

  constructor(map: { [key: string]: any }) {
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

  constructor(map: { [key: string]: any }) {
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

  constructor(map: { [key: string]: any }) {
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

  constructor(map: { [key: string]: any }) {
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

  constructor(map: { [key: string]: any }) {
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

  constructor(map: { [key: string]: any }) {
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

  constructor(map: { [key: string]: any }) {
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

  constructor(map: { [key: string]: any }) {
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

  constructor(map: { [key: string]: any }) {
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

  constructor(map: { [key: string]: any }) {
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

  constructor(map: { [key: string]: any }) {
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
      userMeta: 'map',
      body: 'Readable',
      header: PutObjectRequestHeader,
    };
  }

  constructor(map: { [key: string]: any }) {
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

  constructor(map: { [key: string]: any }) {
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

  constructor(map: { [key: string]: any }) {
    super(map);
  }

}

export class ListLiveChannelResponseListLiveChannelResultLiveChannelPublishUrls extends $tea.Model {
  url: string;
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

  constructor(map: { [key: string]: any }) {
    super(map);
  }

}

export class ListLiveChannelResponseListLiveChannelResultLiveChannelPlayUrls extends $tea.Model {
  url: string;
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

  constructor(map: { [key: string]: any }) {
    super(map);
  }

}

export class ListLiveChannelResponseListLiveChannelResultLiveChannel extends $tea.Model {
  name: string;
  description: string;
  status: string;
  lastModified: string;
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

  constructor(map: { [key: string]: any }) {
    super(map);
  }

}

export class ListLiveChannelResponseListLiveChannelResult extends $tea.Model {
  prefix: string;
  marker: string;
  maxKeys: string;
  isTruncated: string;
  nextMarker: string;
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

  constructor(map: { [key: string]: any }) {
    super(map);
  }

}

export class GetBucketAclResponseAccessControlPolicyOwner extends $tea.Model {
  iD: string;
  displayName: string;
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

  constructor(map: { [key: string]: any }) {
    super(map);
  }

}

export class GetBucketAclResponseAccessControlPolicyAccessControlList extends $tea.Model {
  grant: string;
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

  constructor(map: { [key: string]: any }) {
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

  constructor(map: { [key: string]: any }) {
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

  constructor(map: { [key: string]: any }) {
    super(map);
  }

}

export class ListPartsResponseListPartsResultPart extends $tea.Model {
  partNumber: string;
  lastModified: string;
  eTag: string;
  size: string;
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

  constructor(map: { [key: string]: any }) {
    super(map);
  }

}

export class ListPartsResponseListPartsResult extends $tea.Model {
  bucket: string;
  encodingType: string;
  key: string;
  uploadId: string;
  partNumberMarker: string;
  nextPartNumberMarker: string;
  maxParts: string;
  isTruncated: string;
  part: ListPartsResponseListPartsResultPart[];
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

  constructor(map: { [key: string]: any }) {
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

  constructor(map: { [key: string]: any }) {
    super(map);
  }

}

export class GetLiveChannelHistoryResponseLiveChannelHistoryLiveRecord extends $tea.Model {
  startTime: string;
  endTime: string;
  remoteAddr: string;
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

  constructor(map: { [key: string]: any }) {
    super(map);
  }

}

export class GetLiveChannelHistoryResponseLiveChannelHistory extends $tea.Model {
  liveRecord: GetLiveChannelHistoryResponseLiveChannelHistoryLiveRecord[];
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

  constructor(map: { [key: string]: any }) {
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

  constructor(map: { [key: string]: any }) {
    super(map);
  }

}

export class GetBucketResponseListBucketResultContentsOwner extends $tea.Model {
  iD: string;
  displayName: string;
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

  constructor(map: { [key: string]: any }) {
    super(map);
  }

}

export class GetBucketResponseListBucketResultContents extends $tea.Model {
  key: string;
  eTag: string;
  lastModified: string;
  size: string;
  storageClass: string;
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

  constructor(map: { [key: string]: any }) {
    super(map);
  }

}

export class GetBucketResponseListBucketResult extends $tea.Model {
  name: string;
  prefix: string;
  marker: string;
  maxKeys: string;
  delimiter: string;
  isTruncated: string;
  encodingType: string;
  commonPrefixes: string;
  contents: GetBucketResponseListBucketResultContents[];
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

  constructor(map: { [key: string]: any }) {
    super(map);
  }

}

export class GetLiveChannelInfoResponseLiveChannelConfigurationTarget extends $tea.Model {
  type: string;
  fragDuration: string;
  fragCount: string;
  playlistName: string;
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

  constructor(map: { [key: string]: any }) {
    super(map);
  }

}

export class GetLiveChannelInfoResponseLiveChannelConfiguration extends $tea.Model {
  description: string;
  status: string;
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

  constructor(map: { [key: string]: any }) {
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

  constructor(map: { [key: string]: any }) {
    super(map);
  }

}

export class GetLiveChannelStatResponseLiveChannelStatVideo extends $tea.Model {
  width: string;
  height: string;
  frameRate: string;
  bandwidth: string;
  codec: string;
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

  constructor(map: { [key: string]: any }) {
    super(map);
  }

}

export class GetLiveChannelStatResponseLiveChannelStatAudio extends $tea.Model {
  bandwidth: string;
  sampleRate: string;
  codec: string;
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

  constructor(map: { [key: string]: any }) {
    super(map);
  }

}

export class GetLiveChannelStatResponseLiveChannelStat extends $tea.Model {
  status: string;
  connectedTime: string;
  remoteAddr: string;
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

  constructor(map: { [key: string]: any }) {
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

  constructor(map: { [key: string]: any }) {
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

  constructor(map: { [key: string]: any }) {
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

  constructor(map: { [key: string]: any }) {
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

  constructor(map: { [key: string]: any }) {
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

  constructor(map: { [key: string]: any }) {
    super(map);
  }

}

export class UploadPartCopyResponseCopyPartResult extends $tea.Model {
  lastModified: string;
  eTag: string;
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

  constructor(map: { [key: string]: any }) {
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

  constructor(map: { [key: string]: any }) {
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

  constructor(map: { [key: string]: any }) {
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

  constructor(map: { [key: string]: any }) {
    super(map);
  }

}

export class GetBucketCORSResponseCORSConfigurationCORSRule extends $tea.Model {
  maxAgeSeconds: string;
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

  constructor(map: { [key: string]: any }) {
    super(map);
  }

}

export class GetBucketCORSResponseCORSConfiguration extends $tea.Model {
  cORSRule: GetBucketCORSResponseCORSConfigurationCORSRule[];
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

  constructor(map: { [key: string]: any }) {
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

  constructor(map: { [key: string]: any }) {
    super(map);
  }

}

export class CopyObjectResponseCopyObjectResult extends $tea.Model {
  lastModified: string;
  eTag: string;
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

  constructor(map: { [key: string]: any }) {
    super(map);
  }

}

export class GetObjectTaggingResponseTaggingTagSetTag extends $tea.Model {
  key: string;
  value: string;
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

  constructor(map: { [key: string]: any }) {
    super(map);
  }

}

export class GetObjectTaggingResponseTaggingTagSet extends $tea.Model {
  tag: GetObjectTaggingResponseTaggingTagSetTag[];
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

  constructor(map: { [key: string]: any }) {
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

  constructor(map: { [key: string]: any }) {
    super(map);
  }

}

export class GetBucketLifecycleResponseLifecycleConfigurationRuleExpiration extends $tea.Model {
  days: number;
  createdBeforeDate: string;
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

  constructor(map: { [key: string]: any }) {
    super(map);
  }

}

export class GetBucketLifecycleResponseLifecycleConfigurationRuleTransition extends $tea.Model {
  days: number;
  storageClass: string;
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

  constructor(map: { [key: string]: any }) {
    super(map);
  }

}

export class GetBucketLifecycleResponseLifecycleConfigurationRuleAbortMultipartUpload extends $tea.Model {
  days: number;
  createdBeforeDate: string;
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

  constructor(map: { [key: string]: any }) {
    super(map);
  }

}

export class GetBucketLifecycleResponseLifecycleConfigurationRuleTag extends $tea.Model {
  key: string;
  value: string;
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

  constructor(map: { [key: string]: any }) {
    super(map);
  }

}

export class GetBucketLifecycleResponseLifecycleConfigurationRule extends $tea.Model {
  iD: string;
  prefix: string;
  status: string;
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

  constructor(map: { [key: string]: any }) {
    super(map);
  }

}

export class GetBucketLifecycleResponseLifecycleConfiguration extends $tea.Model {
  rule: GetBucketLifecycleResponseLifecycleConfigurationRule[];
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

  constructor(map: { [key: string]: any }) {
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

  constructor(map: { [key: string]: any }) {
    super(map);
  }

}

export class GetBucketRefererResponseRefererConfigurationRefererList extends $tea.Model {
  referer: string[];
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

  constructor(map: { [key: string]: any }) {
    super(map);
  }

}

export class GetBucketRefererResponseRefererConfiguration extends $tea.Model {
  allowEmptyReferer: boolean;
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

  constructor(map: { [key: string]: any }) {
    super(map);
  }

}

export class GetBucketLoggingResponseBucketLoggingStatusLoggingEnabled extends $tea.Model {
  targetBucket: string;
  targetPrefix: string;
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

  constructor(map: { [key: string]: any }) {
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

  constructor(map: { [key: string]: any }) {
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

  constructor(map: { [key: string]: any }) {
    super(map);
  }

}

export class GetBucketInfoResponseBucketInfoBucketOwner extends $tea.Model {
  iD: string;
  displayName: string;
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

  constructor(map: { [key: string]: any }) {
    super(map);
  }

}

export class GetBucketInfoResponseBucketInfoBucketAccessControlList extends $tea.Model {
  grant: string;
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

  constructor(map: { [key: string]: any }) {
    super(map);
  }

}

export class GetBucketInfoResponseBucketInfoBucket extends $tea.Model {
  creationDate: string;
  extranetEndpoint: string;
  intranetEndpoint: string;
  location: string;
  name: string;
  dataRedundancyType: string;
  storageClass: string;
  comment: string;
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

  constructor(map: { [key: string]: any }) {
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

  constructor(map: { [key: string]: any }) {
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

  constructor(map: { [key: string]: any }) {
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

  constructor(map: { [key: string]: any }) {
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

  constructor(map: { [key: string]: any }) {
    super(map);
  }

}

export class InitiateMultipartUploadResponseInitiateMultipartUploadResult extends $tea.Model {
  bucket: string;
  key: string;
  uploadId: string;
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

  constructor(map: { [key: string]: any }) {
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

  constructor(map: { [key: string]: any }) {
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

  constructor(map: { [key: string]: any }) {
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

  constructor(map: { [key: string]: any }) {
    super(map);
  }

}

export class GetObjectAclResponseAccessControlPolicyOwner extends $tea.Model {
  iD: string;
  displayName: string;
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

  constructor(map: { [key: string]: any }) {
    super(map);
  }

}

export class GetObjectAclResponseAccessControlPolicyAccessControlList extends $tea.Model {
  grant: string;
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

  constructor(map: { [key: string]: any }) {
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

  constructor(map: { [key: string]: any }) {
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

  constructor(map: { [key: string]: any }) {
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

  constructor(map: { [key: string]: any }) {
    super(map);
  }

}


export default class Client extends BaseClient {
  constructor(config: Config) {
    super($tea.toMap(config));
  }

  async deleteLiveChannel(request: DeleteLiveChannelRequest, runtime: RuntimeObject): Promise<DeleteLiveChannelResponse> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: this._defaultNumber(runtime.readTimeout, this._readTimeout),
      connectTimeout: this._defaultNumber(runtime.connectTimeout, this._connectTimeout),
      localAddr: this._default(runtime.localAddr, this._localAddr),
      httpProxy: this._default(runtime.httpProxy, this._httpProxy),
      httpsProxy: this._default(runtime.httpsProxy, this._httpsProxy),
      noProxy: this._default(runtime.noProxy, this._noProxy),
      socks5Proxy: this._default(runtime.socks5Proxy, this._socks5Proxy),
      socks5NetWork: this._default(runtime.socks5NetWork, this._socks5NetWork),
      maxIdleConns: this._defaultNumber(runtime.maxIdleConns, this._maxIdleConns),
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: this._defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: this._default(runtime.backoffPolicy, "no"),
        period: this._defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
      logger: this._logger,
      listener: runtime.listener,
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
        let token = this._getSecurityToken();
        request_.protocol = this._protocol;
        request_.method = "DELETE";
        request_.pathname = `/${request.channelName}?live`;
        request_.headers = {
          host: this.getHost(request.bucketName),
          date: this._getDate(),
          'user-agent': this._getUserAgent(),
        };
        if (this._notEmpty(token)) {
          request_.headers["x-oss-security-token"] = token;
        }
        request_.headers["authorization"] = this._getAuth(request_, request.bucketName);
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap = null;
        let bodyStr = await this._readAsString(response_);
        if (this._isFail(response_)) {
          respMap = this._parseXml(bodyStr, ServerError);
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

  async getBucketLocation(request: GetBucketLocationRequest, runtime: RuntimeObject): Promise<GetBucketLocationResponse> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: this._defaultNumber(runtime.readTimeout, this._readTimeout),
      connectTimeout: this._defaultNumber(runtime.connectTimeout, this._connectTimeout),
      localAddr: this._default(runtime.localAddr, this._localAddr),
      httpProxy: this._default(runtime.httpProxy, this._httpProxy),
      httpsProxy: this._default(runtime.httpsProxy, this._httpsProxy),
      noProxy: this._default(runtime.noProxy, this._noProxy),
      socks5Proxy: this._default(runtime.socks5Proxy, this._socks5Proxy),
      socks5NetWork: this._default(runtime.socks5NetWork, this._socks5NetWork),
      maxIdleConns: this._defaultNumber(runtime.maxIdleConns, this._maxIdleConns),
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: this._defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: this._default(runtime.backoffPolicy, "no"),
        period: this._defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
      logger: this._logger,
      listener: runtime.listener,
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
        let token = this._getSecurityToken();
        request_.protocol = this._protocol;
        request_.method = "GET";
        request_.pathname = `/?location`;
        request_.headers = {
          host: this.getHost(request.bucketName),
          date: this._getDate(),
          'user-agent': this._getUserAgent(),
        };
        if (this._notEmpty(token)) {
          request_.headers["x-oss-security-token"] = token;
        }
        request_.headers["authorization"] = this._getAuth(request_, request.bucketName);
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap = null;
        let bodyStr = await this._readAsString(response_);
        if (this._isFail(response_)) {
          respMap = this._parseXml(bodyStr, ServerError);
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

        respMap = this._parseXml(bodyStr, GetBucketLocationResponse);
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

  async listLiveChannel(request: ListLiveChannelRequest, runtime: RuntimeObject): Promise<ListLiveChannelResponse> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: this._defaultNumber(runtime.readTimeout, this._readTimeout),
      connectTimeout: this._defaultNumber(runtime.connectTimeout, this._connectTimeout),
      localAddr: this._default(runtime.localAddr, this._localAddr),
      httpProxy: this._default(runtime.httpProxy, this._httpProxy),
      httpsProxy: this._default(runtime.httpsProxy, this._httpsProxy),
      noProxy: this._default(runtime.noProxy, this._noProxy),
      socks5Proxy: this._default(runtime.socks5Proxy, this._socks5Proxy),
      socks5NetWork: this._default(runtime.socks5NetWork, this._socks5NetWork),
      maxIdleConns: this._defaultNumber(runtime.maxIdleConns, this._maxIdleConns),
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: this._defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: this._default(runtime.backoffPolicy, "no"),
        period: this._defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
      logger: this._logger,
      listener: runtime.listener,
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
        let token = this._getSecurityToken();
        request_.protocol = this._protocol;
        request_.method = "GET";
        request_.pathname = `/?live`;
        request_.headers = {
          host: this.getHost(request.bucketName),
          date: this._getDate(),
          'user-agent': this._getUserAgent(),
        };
        if (this._notEmpty(token)) {
          request_.headers["x-oss-security-token"] = token;
        }
        request_.query = this._toQuery(request.filter);
        request_.headers["authorization"] = this._getAuth(request_, request.bucketName);
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap = null;
        let bodyStr = await this._readAsString(response_);
        if (this._isFail(response_)) {
          respMap = this._parseXml(bodyStr, ServerError);
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

        respMap = this._parseXml(bodyStr, ListLiveChannelResponse);
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

  async getObjectMeta(request: GetObjectMetaRequest, runtime: RuntimeObject): Promise<GetObjectMetaResponse> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: this._defaultNumber(runtime.readTimeout, this._readTimeout),
      connectTimeout: this._defaultNumber(runtime.connectTimeout, this._connectTimeout),
      localAddr: this._default(runtime.localAddr, this._localAddr),
      httpProxy: this._default(runtime.httpProxy, this._httpProxy),
      httpsProxy: this._default(runtime.httpsProxy, this._httpsProxy),
      noProxy: this._default(runtime.noProxy, this._noProxy),
      socks5Proxy: this._default(runtime.socks5Proxy, this._socks5Proxy),
      socks5NetWork: this._default(runtime.socks5NetWork, this._socks5NetWork),
      maxIdleConns: this._defaultNumber(runtime.maxIdleConns, this._maxIdleConns),
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: this._defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: this._default(runtime.backoffPolicy, "no"),
        period: this._defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
      logger: this._logger,
      listener: runtime.listener,
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
        let token = this._getSecurityToken();
        request_.protocol = this._protocol;
        request_.method = "HEAD";
        request_.pathname = `/${request.objectName}?objectMeta`;
        request_.headers = {
          host: this.getHost(request.bucketName),
          date: this._getDate(),
          'user-agent': this._getUserAgent(),
        };
        if (this._notEmpty(token)) {
          request_.headers["x-oss-security-token"] = token;
        }
        request_.headers["authorization"] = this._getAuth(request_, request.bucketName);
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap = null;
        let bodyStr = await this._readAsString(response_);
        if (this._isFail(response_)) {
          respMap = this._parseXml(bodyStr, ServerError);
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

  async getBucketAcl(request: GetBucketAclRequest, runtime: RuntimeObject): Promise<GetBucketAclResponse> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: this._defaultNumber(runtime.readTimeout, this._readTimeout),
      connectTimeout: this._defaultNumber(runtime.connectTimeout, this._connectTimeout),
      localAddr: this._default(runtime.localAddr, this._localAddr),
      httpProxy: this._default(runtime.httpProxy, this._httpProxy),
      httpsProxy: this._default(runtime.httpsProxy, this._httpsProxy),
      noProxy: this._default(runtime.noProxy, this._noProxy),
      socks5Proxy: this._default(runtime.socks5Proxy, this._socks5Proxy),
      socks5NetWork: this._default(runtime.socks5NetWork, this._socks5NetWork),
      maxIdleConns: this._defaultNumber(runtime.maxIdleConns, this._maxIdleConns),
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: this._defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: this._default(runtime.backoffPolicy, "no"),
        period: this._defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
      logger: this._logger,
      listener: runtime.listener,
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
        let token = this._getSecurityToken();
        request_.protocol = this._protocol;
        request_.method = "GET";
        request_.pathname = `/?acl`;
        request_.headers = {
          host: this.getHost(request.bucketName),
          date: this._getDate(),
          'user-agent': this._getUserAgent(),
        };
        if (this._notEmpty(token)) {
          request_.headers["x-oss-security-token"] = token;
        }
        request_.headers["authorization"] = this._getAuth(request_, request.bucketName);
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap = null;
        let bodyStr = await this._readAsString(response_);
        if (this._isFail(response_)) {
          respMap = this._parseXml(bodyStr, ServerError);
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

        respMap = this._parseXml(bodyStr, GetBucketAclResponse);
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

  async listParts(request: ListPartsRequest, runtime: RuntimeObject): Promise<ListPartsResponse> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: this._defaultNumber(runtime.readTimeout, this._readTimeout),
      connectTimeout: this._defaultNumber(runtime.connectTimeout, this._connectTimeout),
      localAddr: this._default(runtime.localAddr, this._localAddr),
      httpProxy: this._default(runtime.httpProxy, this._httpProxy),
      httpsProxy: this._default(runtime.httpsProxy, this._httpsProxy),
      noProxy: this._default(runtime.noProxy, this._noProxy),
      socks5Proxy: this._default(runtime.socks5Proxy, this._socks5Proxy),
      socks5NetWork: this._default(runtime.socks5NetWork, this._socks5NetWork),
      maxIdleConns: this._defaultNumber(runtime.maxIdleConns, this._maxIdleConns),
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: this._defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: this._default(runtime.backoffPolicy, "no"),
        period: this._defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
      logger: this._logger,
      listener: runtime.listener,
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
        let token = this._getSecurityToken();
        request_.protocol = this._protocol;
        request_.method = "GET";
        request_.pathname = `/${request.objectName}`;
        request_.headers = {
          host: this.getHost(request.bucketName),
          date: this._getDate(),
          'user-agent': this._getUserAgent(),
        };
        if (this._notEmpty(token)) {
          request_.headers["x-oss-security-token"] = token;
        }
        request_.query = this._toQuery(request.filter);
        request_.headers["authorization"] = this._getAuth(request_, request.bucketName);
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap = null;
        let bodyStr = await this._readAsString(response_);
        if (this._isFail(response_)) {
          respMap = this._parseXml(bodyStr, ServerError);
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

        respMap = this._parseXml(bodyStr, ListPartsResponse);
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

  async getLiveChannelHistory(request: GetLiveChannelHistoryRequest, runtime: RuntimeObject): Promise<GetLiveChannelHistoryResponse> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: this._defaultNumber(runtime.readTimeout, this._readTimeout),
      connectTimeout: this._defaultNumber(runtime.connectTimeout, this._connectTimeout),
      localAddr: this._default(runtime.localAddr, this._localAddr),
      httpProxy: this._default(runtime.httpProxy, this._httpProxy),
      httpsProxy: this._default(runtime.httpsProxy, this._httpsProxy),
      noProxy: this._default(runtime.noProxy, this._noProxy),
      socks5Proxy: this._default(runtime.socks5Proxy, this._socks5Proxy),
      socks5NetWork: this._default(runtime.socks5NetWork, this._socks5NetWork),
      maxIdleConns: this._defaultNumber(runtime.maxIdleConns, this._maxIdleConns),
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: this._defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: this._default(runtime.backoffPolicy, "no"),
        period: this._defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
      logger: this._logger,
      listener: runtime.listener,
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
        let token = this._getSecurityToken();
        request_.protocol = this._protocol;
        request_.method = "GET";
        request_.pathname = `/${request.channelName}?live`;
        request_.headers = {
          host: this.getHost(request.bucketName),
          date: this._getDate(),
          'user-agent': this._getUserAgent(),
        };
        if (this._notEmpty(token)) {
          request_.headers["x-oss-security-token"] = token;
        }
        request_.query = this._toQuery(request.filter);
        request_.headers["authorization"] = this._getAuth(request_, request.bucketName);
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap = null;
        let bodyStr = await this._readAsString(response_);
        if (this._isFail(response_)) {
          respMap = this._parseXml(bodyStr, ServerError);
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

        respMap = this._parseXml(bodyStr, GetLiveChannelHistoryResponse);
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

  async getBucket(request: GetBucketRequest, runtime: RuntimeObject): Promise<GetBucketResponse> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: this._defaultNumber(runtime.readTimeout, this._readTimeout),
      connectTimeout: this._defaultNumber(runtime.connectTimeout, this._connectTimeout),
      localAddr: this._default(runtime.localAddr, this._localAddr),
      httpProxy: this._default(runtime.httpProxy, this._httpProxy),
      httpsProxy: this._default(runtime.httpsProxy, this._httpsProxy),
      noProxy: this._default(runtime.noProxy, this._noProxy),
      socks5Proxy: this._default(runtime.socks5Proxy, this._socks5Proxy),
      socks5NetWork: this._default(runtime.socks5NetWork, this._socks5NetWork),
      maxIdleConns: this._defaultNumber(runtime.maxIdleConns, this._maxIdleConns),
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: this._defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: this._default(runtime.backoffPolicy, "no"),
        period: this._defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
      logger: this._logger,
      listener: runtime.listener,
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
        let token = this._getSecurityToken();
        request_.protocol = this._protocol;
        request_.method = "GET";
        request_.pathname = `/`;
        request_.headers = {
          host: this.getHost(request.bucketName),
          date: this._getDate(),
          'user-agent': this._getUserAgent(),
        };
        if (this._notEmpty(token)) {
          request_.headers["x-oss-security-token"] = token;
        }
        request_.query = this._toQuery(request.filter);
        request_.headers["authorization"] = this._getAuth(request_, request.bucketName);
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap = null;
        let bodyStr = await this._readAsString(response_);
        if (this._isFail(response_)) {
          respMap = this._parseXml(bodyStr, ServerError);
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

        respMap = this._parseXml(bodyStr, GetBucketResponse);
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

  async getLiveChannelInfo(request: GetLiveChannelInfoRequest, runtime: RuntimeObject): Promise<GetLiveChannelInfoResponse> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: this._defaultNumber(runtime.readTimeout, this._readTimeout),
      connectTimeout: this._defaultNumber(runtime.connectTimeout, this._connectTimeout),
      localAddr: this._default(runtime.localAddr, this._localAddr),
      httpProxy: this._default(runtime.httpProxy, this._httpProxy),
      httpsProxy: this._default(runtime.httpsProxy, this._httpsProxy),
      noProxy: this._default(runtime.noProxy, this._noProxy),
      socks5Proxy: this._default(runtime.socks5Proxy, this._socks5Proxy),
      socks5NetWork: this._default(runtime.socks5NetWork, this._socks5NetWork),
      maxIdleConns: this._defaultNumber(runtime.maxIdleConns, this._maxIdleConns),
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: this._defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: this._default(runtime.backoffPolicy, "no"),
        period: this._defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
      logger: this._logger,
      listener: runtime.listener,
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
        let token = this._getSecurityToken();
        request_.protocol = this._protocol;
        request_.method = "GET";
        request_.pathname = `/${request.channelName}?live`;
        request_.headers = {
          host: this.getHost(request.bucketName),
          date: this._getDate(),
          'user-agent': this._getUserAgent(),
        };
        if (this._notEmpty(token)) {
          request_.headers["x-oss-security-token"] = token;
        }
        request_.headers["authorization"] = this._getAuth(request_, request.bucketName);
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap = null;
        let bodyStr = await this._readAsString(response_);
        if (this._isFail(response_)) {
          respMap = this._parseXml(bodyStr, ServerError);
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

        respMap = this._parseXml(bodyStr, GetLiveChannelInfoResponse);
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

  async getLiveChannelStat(request: GetLiveChannelStatRequest, runtime: RuntimeObject): Promise<GetLiveChannelStatResponse> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: this._defaultNumber(runtime.readTimeout, this._readTimeout),
      connectTimeout: this._defaultNumber(runtime.connectTimeout, this._connectTimeout),
      localAddr: this._default(runtime.localAddr, this._localAddr),
      httpProxy: this._default(runtime.httpProxy, this._httpProxy),
      httpsProxy: this._default(runtime.httpsProxy, this._httpsProxy),
      noProxy: this._default(runtime.noProxy, this._noProxy),
      socks5Proxy: this._default(runtime.socks5Proxy, this._socks5Proxy),
      socks5NetWork: this._default(runtime.socks5NetWork, this._socks5NetWork),
      maxIdleConns: this._defaultNumber(runtime.maxIdleConns, this._maxIdleConns),
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: this._defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: this._default(runtime.backoffPolicy, "no"),
        period: this._defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
      logger: this._logger,
      listener: runtime.listener,
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
        let token = this._getSecurityToken();
        request_.protocol = this._protocol;
        request_.method = "GET";
        request_.pathname = `/${request.channelName}?live`;
        request_.headers = {
          host: this.getHost(request.bucketName),
          date: this._getDate(),
          'user-agent': this._getUserAgent(),
        };
        if (this._notEmpty(token)) {
          request_.headers["x-oss-security-token"] = token;
        }
        request_.query = this._toQuery(request.filter);
        request_.headers["authorization"] = this._getAuth(request_, request.bucketName);
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap = null;
        let bodyStr = await this._readAsString(response_);
        if (this._isFail(response_)) {
          respMap = this._parseXml(bodyStr, ServerError);
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

        respMap = this._parseXml(bodyStr, GetLiveChannelStatResponse);
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

  async deleteObject(request: DeleteObjectRequest, runtime: RuntimeObject): Promise<DeleteObjectResponse> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: this._defaultNumber(runtime.readTimeout, this._readTimeout),
      connectTimeout: this._defaultNumber(runtime.connectTimeout, this._connectTimeout),
      localAddr: this._default(runtime.localAddr, this._localAddr),
      httpProxy: this._default(runtime.httpProxy, this._httpProxy),
      httpsProxy: this._default(runtime.httpsProxy, this._httpsProxy),
      noProxy: this._default(runtime.noProxy, this._noProxy),
      socks5Proxy: this._default(runtime.socks5Proxy, this._socks5Proxy),
      socks5NetWork: this._default(runtime.socks5NetWork, this._socks5NetWork),
      maxIdleConns: this._defaultNumber(runtime.maxIdleConns, this._maxIdleConns),
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: this._defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: this._default(runtime.backoffPolicy, "no"),
        period: this._defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
      logger: this._logger,
      listener: runtime.listener,
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
        let token = this._getSecurityToken();
        request_.protocol = this._protocol;
        request_.method = "DELETE";
        request_.pathname = `/${request.objectName}`;
        request_.headers = {
          host: this.getHost(request.bucketName),
          date: this._getDate(),
          'user-agent': this._getUserAgent(),
        };
        if (this._notEmpty(token)) {
          request_.headers["x-oss-security-token"] = token;
        }
        request_.headers["authorization"] = this._getAuth(request_, request.bucketName);
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap = null;
        let bodyStr = await this._readAsString(response_);
        if (this._isFail(response_)) {
          respMap = this._parseXml(bodyStr, ServerError);
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

  async abortMultipartUpload(request: AbortMultipartUploadRequest, runtime: RuntimeObject): Promise<AbortMultipartUploadResponse> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: this._defaultNumber(runtime.readTimeout, this._readTimeout),
      connectTimeout: this._defaultNumber(runtime.connectTimeout, this._connectTimeout),
      localAddr: this._default(runtime.localAddr, this._localAddr),
      httpProxy: this._default(runtime.httpProxy, this._httpProxy),
      httpsProxy: this._default(runtime.httpsProxy, this._httpsProxy),
      noProxy: this._default(runtime.noProxy, this._noProxy),
      socks5Proxy: this._default(runtime.socks5Proxy, this._socks5Proxy),
      socks5NetWork: this._default(runtime.socks5NetWork, this._socks5NetWork),
      maxIdleConns: this._defaultNumber(runtime.maxIdleConns, this._maxIdleConns),
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: this._defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: this._default(runtime.backoffPolicy, "no"),
        period: this._defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
      logger: this._logger,
      listener: runtime.listener,
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
        let token = this._getSecurityToken();
        request_.protocol = this._protocol;
        request_.method = "DELETE";
        request_.pathname = `/${request.objectName}`;
        request_.headers = {
          host: this.getHost(request.bucketName),
          date: this._getDate(),
          'user-agent': this._getUserAgent(),
        };
        if (this._notEmpty(token)) {
          request_.headers["x-oss-security-token"] = token;
        }
        request_.query = this._toQuery(request.filter);
        request_.headers["authorization"] = this._getAuth(request_, request.bucketName);
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap = null;
        let bodyStr = await this._readAsString(response_);
        if (this._isFail(response_)) {
          respMap = this._parseXml(bodyStr, ServerError);
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

  async appendObject(request: AppendObjectRequest, runtime: RuntimeObject): Promise<AppendObjectResponse> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: this._defaultNumber(runtime.readTimeout, this._readTimeout),
      connectTimeout: this._defaultNumber(runtime.connectTimeout, this._connectTimeout),
      localAddr: this._default(runtime.localAddr, this._localAddr),
      httpProxy: this._default(runtime.httpProxy, this._httpProxy),
      httpsProxy: this._default(runtime.httpsProxy, this._httpsProxy),
      noProxy: this._default(runtime.noProxy, this._noProxy),
      socks5Proxy: this._default(runtime.socks5Proxy, this._socks5Proxy),
      socks5NetWork: this._default(runtime.socks5NetWork, this._socks5NetWork),
      maxIdleConns: this._defaultNumber(runtime.maxIdleConns, this._maxIdleConns),
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: this._defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: this._default(runtime.backoffPolicy, "no"),
        period: this._defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
      logger: this._logger,
      listener: runtime.listener,
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
        let token = this._getSecurityToken();
        request_.protocol = this._protocol;
        request_.method = "POST";
        request_.pathname = `/${request.objectName}?append`;
        request_.headers = {
          host: this.getHost(request.bucketName),
          date: this._getDate(),
          'user-agent': this._getUserAgent(),
          ...this._toHeader(request.header),
          ...this._parseMeta(request.userMeta, "x-oss-meta-"),
        };
        if (this._notEmpty(token)) {
          request_.headers["x-oss-security-token"] = token;
        }
        request_.query = this._toQuery(request.filter);
        request_.body = request.body;
        request_.headers["content-type"] = this._default(this._getSpecialValue(request.header, "content-type"), this._getContentType(request.objectName));
        request_.headers["authorization"] = this._getAuth(request_, request.bucketName);
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap = null;
        let bodyStr = await this._readAsString(response_);
        if (this._isFail(response_)) {
          respMap = this._parseXml(bodyStr, ServerError);
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

  async uploadPartCopy(request: UploadPartCopyRequest, runtime: RuntimeObject): Promise<UploadPartCopyResponse> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: this._defaultNumber(runtime.readTimeout, this._readTimeout),
      connectTimeout: this._defaultNumber(runtime.connectTimeout, this._connectTimeout),
      localAddr: this._default(runtime.localAddr, this._localAddr),
      httpProxy: this._default(runtime.httpProxy, this._httpProxy),
      httpsProxy: this._default(runtime.httpsProxy, this._httpsProxy),
      noProxy: this._default(runtime.noProxy, this._noProxy),
      socks5Proxy: this._default(runtime.socks5Proxy, this._socks5Proxy),
      socks5NetWork: this._default(runtime.socks5NetWork, this._socks5NetWork),
      maxIdleConns: this._defaultNumber(runtime.maxIdleConns, this._maxIdleConns),
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: this._defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: this._default(runtime.backoffPolicy, "no"),
        period: this._defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
      logger: this._logger,
      listener: runtime.listener,
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
        let token = this._getSecurityToken();
        request_.protocol = this._protocol;
        request_.method = "PUT";
        request_.pathname = `/${request.objectName}`;
        request_.headers = {
          host: this.getHost(request.bucketName),
          date: this._getDate(),
          'user-agent': this._getUserAgent(),
          ...this._toHeader(request.header),
        };
        if (this._notEmpty(token)) {
          request_.headers["x-oss-security-token"] = token;
        }
        request_.query = this._toQuery(request.filter);
        request_.headers["authorization"] = this._getAuth(request_, request.bucketName);
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap = null;
        let bodyStr = await this._readAsString(response_);
        if (this._isFail(response_)) {
          respMap = this._parseXml(bodyStr, ServerError);
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

        respMap = this._parseXml(bodyStr, UploadPartCopyResponse);
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

  async getVodPlaylist(request: GetVodPlaylistRequest, runtime: RuntimeObject): Promise<GetVodPlaylistResponse> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: this._defaultNumber(runtime.readTimeout, this._readTimeout),
      connectTimeout: this._defaultNumber(runtime.connectTimeout, this._connectTimeout),
      localAddr: this._default(runtime.localAddr, this._localAddr),
      httpProxy: this._default(runtime.httpProxy, this._httpProxy),
      httpsProxy: this._default(runtime.httpsProxy, this._httpsProxy),
      noProxy: this._default(runtime.noProxy, this._noProxy),
      socks5Proxy: this._default(runtime.socks5Proxy, this._socks5Proxy),
      socks5NetWork: this._default(runtime.socks5NetWork, this._socks5NetWork),
      maxIdleConns: this._defaultNumber(runtime.maxIdleConns, this._maxIdleConns),
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: this._defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: this._default(runtime.backoffPolicy, "no"),
        period: this._defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
      logger: this._logger,
      listener: runtime.listener,
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
        let token = this._getSecurityToken();
        request_.protocol = this._protocol;
        request_.method = "GET";
        request_.pathname = `/${request.channelName}?vod`;
        request_.headers = {
          host: this.getHost(request.bucketName),
          date: this._getDate(),
          'user-agent': this._getUserAgent(),
        };
        if (this._notEmpty(token)) {
          request_.headers["x-oss-security-token"] = token;
        }
        request_.query = this._toQuery(request.filter);
        request_.headers["authorization"] = this._getAuth(request_, request.bucketName);
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap = null;
        let bodyStr = await this._readAsString(response_);
        if (this._isFail(response_)) {
          respMap = this._parseXml(bodyStr, ServerError);
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

  async deleteBucketCORS(request: DeleteBucketCORSRequest, runtime: RuntimeObject): Promise<DeleteBucketCORSResponse> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: this._defaultNumber(runtime.readTimeout, this._readTimeout),
      connectTimeout: this._defaultNumber(runtime.connectTimeout, this._connectTimeout),
      localAddr: this._default(runtime.localAddr, this._localAddr),
      httpProxy: this._default(runtime.httpProxy, this._httpProxy),
      httpsProxy: this._default(runtime.httpsProxy, this._httpsProxy),
      noProxy: this._default(runtime.noProxy, this._noProxy),
      socks5Proxy: this._default(runtime.socks5Proxy, this._socks5Proxy),
      socks5NetWork: this._default(runtime.socks5NetWork, this._socks5NetWork),
      maxIdleConns: this._defaultNumber(runtime.maxIdleConns, this._maxIdleConns),
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: this._defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: this._default(runtime.backoffPolicy, "no"),
        period: this._defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
      logger: this._logger,
      listener: runtime.listener,
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
        let token = this._getSecurityToken();
        request_.protocol = this._protocol;
        request_.method = "DELETE";
        request_.pathname = `/?cors`;
        request_.headers = {
          host: this.getHost(request.bucketName),
          date: this._getDate(),
          'user-agent': this._getUserAgent(),
        };
        if (this._notEmpty(token)) {
          request_.headers["x-oss-security-token"] = token;
        }
        request_.headers["authorization"] = this._getAuth(request_, request.bucketName);
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap = null;
        let bodyStr = await this._readAsString(response_);
        if (this._isFail(response_)) {
          respMap = this._parseXml(bodyStr, ServerError);
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

  async getObject(request: GetObjectRequest, runtime: RuntimeObject): Promise<GetObjectResponse> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: this._defaultNumber(runtime.readTimeout, this._readTimeout),
      connectTimeout: this._defaultNumber(runtime.connectTimeout, this._connectTimeout),
      localAddr: this._default(runtime.localAddr, this._localAddr),
      httpProxy: this._default(runtime.httpProxy, this._httpProxy),
      httpsProxy: this._default(runtime.httpsProxy, this._httpsProxy),
      noProxy: this._default(runtime.noProxy, this._noProxy),
      socks5Proxy: this._default(runtime.socks5Proxy, this._socks5Proxy),
      socks5NetWork: this._default(runtime.socks5NetWork, this._socks5NetWork),
      maxIdleConns: this._defaultNumber(runtime.maxIdleConns, this._maxIdleConns),
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: this._defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: this._default(runtime.backoffPolicy, "no"),
        period: this._defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
      logger: this._logger,
      listener: runtime.listener,
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
        let token = this._getSecurityToken();
        request_.protocol = this._protocol;
        request_.method = "GET";
        request_.pathname = `/${request.objectName}`;
        request_.headers = {
          host: this.getHost(request.bucketName),
          date: this._getDate(),
          'user-agent': this._getUserAgent(),
          ...this._toHeader(request.header),
        };
        if (this._notEmpty(token)) {
          request_.headers["x-oss-security-token"] = token;
        }
        request_.headers["authorization"] = this._getAuth(request_, request.bucketName);
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap = null;
        let bodyStr = await this._readAsString(response_);
        if (this._isFail(response_)) {
          respMap = this._parseXml(bodyStr, ServerError);
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
          body: this._readAsStream(response_),
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

  async uploadPart(request: UploadPartRequest, runtime: RuntimeObject): Promise<UploadPartResponse> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: this._defaultNumber(runtime.readTimeout, this._readTimeout),
      connectTimeout: this._defaultNumber(runtime.connectTimeout, this._connectTimeout),
      localAddr: this._default(runtime.localAddr, this._localAddr),
      httpProxy: this._default(runtime.httpProxy, this._httpProxy),
      httpsProxy: this._default(runtime.httpsProxy, this._httpsProxy),
      noProxy: this._default(runtime.noProxy, this._noProxy),
      socks5Proxy: this._default(runtime.socks5Proxy, this._socks5Proxy),
      socks5NetWork: this._default(runtime.socks5NetWork, this._socks5NetWork),
      maxIdleConns: this._defaultNumber(runtime.maxIdleConns, this._maxIdleConns),
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: this._defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: this._default(runtime.backoffPolicy, "no"),
        period: this._defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
      logger: this._logger,
      listener: runtime.listener,
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
        let token = this._getSecurityToken();
        request_.protocol = this._protocol;
        request_.method = "PUT";
        request_.pathname = `/${request.objectName}`;
        request_.headers = {
          host: this.getHost(request.bucketName),
          date: this._getDate(),
          'user-agent': this._getUserAgent(),
        };
        if (this._notEmpty(token)) {
          request_.headers["x-oss-security-token"] = token;
        }
        request_.query = this._toQuery(request.filter);
        request_.body = request.body;
        request_.headers["authorization"] = this._getAuth(request_, request.bucketName);
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap = null;
        let bodyStr = await this._readAsString(response_);
        if (this._isFail(response_)) {
          respMap = this._parseXml(bodyStr, ServerError);
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

  async getBucketCORS(request: GetBucketCORSRequest, runtime: RuntimeObject): Promise<GetBucketCORSResponse> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: this._defaultNumber(runtime.readTimeout, this._readTimeout),
      connectTimeout: this._defaultNumber(runtime.connectTimeout, this._connectTimeout),
      localAddr: this._default(runtime.localAddr, this._localAddr),
      httpProxy: this._default(runtime.httpProxy, this._httpProxy),
      httpsProxy: this._default(runtime.httpsProxy, this._httpsProxy),
      noProxy: this._default(runtime.noProxy, this._noProxy),
      socks5Proxy: this._default(runtime.socks5Proxy, this._socks5Proxy),
      socks5NetWork: this._default(runtime.socks5NetWork, this._socks5NetWork),
      maxIdleConns: this._defaultNumber(runtime.maxIdleConns, this._maxIdleConns),
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: this._defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: this._default(runtime.backoffPolicy, "no"),
        period: this._defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
      logger: this._logger,
      listener: runtime.listener,
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
        let token = this._getSecurityToken();
        request_.protocol = this._protocol;
        request_.method = "GET";
        request_.pathname = `/?cors`;
        request_.headers = {
          host: this.getHost(request.bucketName),
          date: this._getDate(),
          'user-agent': this._getUserAgent(),
        };
        if (this._notEmpty(token)) {
          request_.headers["x-oss-security-token"] = token;
        }
        request_.headers["authorization"] = this._getAuth(request_, request.bucketName);
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap = null;
        let bodyStr = await this._readAsString(response_);
        if (this._isFail(response_)) {
          respMap = this._parseXml(bodyStr, ServerError);
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

        respMap = this._parseXml(bodyStr, GetBucketCORSResponse);
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

  async copyObject(request: CopyObjectRequest, runtime: RuntimeObject): Promise<CopyObjectResponse> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: this._defaultNumber(runtime.readTimeout, this._readTimeout),
      connectTimeout: this._defaultNumber(runtime.connectTimeout, this._connectTimeout),
      localAddr: this._default(runtime.localAddr, this._localAddr),
      httpProxy: this._default(runtime.httpProxy, this._httpProxy),
      httpsProxy: this._default(runtime.httpsProxy, this._httpsProxy),
      noProxy: this._default(runtime.noProxy, this._noProxy),
      socks5Proxy: this._default(runtime.socks5Proxy, this._socks5Proxy),
      socks5NetWork: this._default(runtime.socks5NetWork, this._socks5NetWork),
      maxIdleConns: this._defaultNumber(runtime.maxIdleConns, this._maxIdleConns),
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: this._defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: this._default(runtime.backoffPolicy, "no"),
        period: this._defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
      logger: this._logger,
      listener: runtime.listener,
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
        let token = this._getSecurityToken();
        request_.protocol = this._protocol;
        request_.method = "PUT";
        request_.pathname = `/${request.destObjectName}`;
        request_.headers = {
          host: this.getHost(request.bucketName),
          date: this._getDate(),
          'user-agent': this._getUserAgent(),
          ...this._toHeader(request.header),
        };
        if (this._notEmpty(token)) {
          request_.headers["x-oss-security-token"] = token;
        }
        request_.headers["x-oss-copy-source"] = this._encode(request_.headers["x-oss-copy-source"], "UrlEncode");
        request_.headers["authorization"] = this._getAuth(request_, request.bucketName);
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap = null;
        let bodyStr = await this._readAsString(response_);
        if (this._isFail(response_)) {
          respMap = this._parseXml(bodyStr, ServerError);
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

        respMap = this._parseXml(bodyStr, CopyObjectResponse);
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

  async getObjectTagging(request: GetObjectTaggingRequest, runtime: RuntimeObject): Promise<GetObjectTaggingResponse> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: this._defaultNumber(runtime.readTimeout, this._readTimeout),
      connectTimeout: this._defaultNumber(runtime.connectTimeout, this._connectTimeout),
      localAddr: this._default(runtime.localAddr, this._localAddr),
      httpProxy: this._default(runtime.httpProxy, this._httpProxy),
      httpsProxy: this._default(runtime.httpsProxy, this._httpsProxy),
      noProxy: this._default(runtime.noProxy, this._noProxy),
      socks5Proxy: this._default(runtime.socks5Proxy, this._socks5Proxy),
      socks5NetWork: this._default(runtime.socks5NetWork, this._socks5NetWork),
      maxIdleConns: this._defaultNumber(runtime.maxIdleConns, this._maxIdleConns),
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: this._defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: this._default(runtime.backoffPolicy, "no"),
        period: this._defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
      logger: this._logger,
      listener: runtime.listener,
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
        let token = this._getSecurityToken();
        request_.protocol = this._protocol;
        request_.method = "GET";
        request_.pathname = `/${request.objectName}?tagging`;
        request_.headers = {
          host: this.getHost(request.bucketName),
          date: this._getDate(),
          'user-agent': this._getUserAgent(),
        };
        if (this._notEmpty(token)) {
          request_.headers["x-oss-security-token"] = token;
        }
        request_.headers["authorization"] = this._getAuth(request_, request.bucketName);
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap = null;
        let bodyStr = await this._readAsString(response_);
        if (this._isFail(response_)) {
          respMap = this._parseXml(bodyStr, ServerError);
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

        respMap = this._parseXml(bodyStr, GetObjectTaggingResponse);
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

  async deleteBucketLifecycle(request: DeleteBucketLifecycleRequest, runtime: RuntimeObject): Promise<DeleteBucketLifecycleResponse> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: this._defaultNumber(runtime.readTimeout, this._readTimeout),
      connectTimeout: this._defaultNumber(runtime.connectTimeout, this._connectTimeout),
      localAddr: this._default(runtime.localAddr, this._localAddr),
      httpProxy: this._default(runtime.httpProxy, this._httpProxy),
      httpsProxy: this._default(runtime.httpsProxy, this._httpsProxy),
      noProxy: this._default(runtime.noProxy, this._noProxy),
      socks5Proxy: this._default(runtime.socks5Proxy, this._socks5Proxy),
      socks5NetWork: this._default(runtime.socks5NetWork, this._socks5NetWork),
      maxIdleConns: this._defaultNumber(runtime.maxIdleConns, this._maxIdleConns),
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: this._defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: this._default(runtime.backoffPolicy, "no"),
        period: this._defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
      logger: this._logger,
      listener: runtime.listener,
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
        let token = this._getSecurityToken();
        request_.protocol = this._protocol;
        request_.method = "DELETE";
        request_.pathname = `/?lifecycle`;
        request_.headers = {
          host: this.getHost(request.bucketName),
          date: this._getDate(),
          'user-agent': this._getUserAgent(),
        };
        if (this._notEmpty(token)) {
          request_.headers["x-oss-security-token"] = token;
        }
        request_.headers["authorization"] = this._getAuth(request_, request.bucketName);
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap = null;
        let bodyStr = await this._readAsString(response_);
        if (this._isFail(response_)) {
          respMap = this._parseXml(bodyStr, ServerError);
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

  async deleteBucketLogging(request: DeleteBucketLoggingRequest, runtime: RuntimeObject): Promise<DeleteBucketLoggingResponse> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: this._defaultNumber(runtime.readTimeout, this._readTimeout),
      connectTimeout: this._defaultNumber(runtime.connectTimeout, this._connectTimeout),
      localAddr: this._default(runtime.localAddr, this._localAddr),
      httpProxy: this._default(runtime.httpProxy, this._httpProxy),
      httpsProxy: this._default(runtime.httpsProxy, this._httpsProxy),
      noProxy: this._default(runtime.noProxy, this._noProxy),
      socks5Proxy: this._default(runtime.socks5Proxy, this._socks5Proxy),
      socks5NetWork: this._default(runtime.socks5NetWork, this._socks5NetWork),
      maxIdleConns: this._defaultNumber(runtime.maxIdleConns, this._maxIdleConns),
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: this._defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: this._default(runtime.backoffPolicy, "no"),
        period: this._defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
      logger: this._logger,
      listener: runtime.listener,
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
        let token = this._getSecurityToken();
        request_.protocol = this._protocol;
        request_.method = "DELETE";
        request_.pathname = `/?logging`;
        request_.headers = {
          host: this.getHost(request.bucketName),
          date: this._getDate(),
          'user-agent': this._getUserAgent(),
        };
        if (this._notEmpty(token)) {
          request_.headers["x-oss-security-token"] = token;
        }
        request_.headers["authorization"] = this._getAuth(request_, request.bucketName);
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap = null;
        let bodyStr = await this._readAsString(response_);
        if (this._isFail(response_)) {
          respMap = this._parseXml(bodyStr, ServerError);
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

  async deleteBucketWebsite(request: DeleteBucketWebsiteRequest, runtime: RuntimeObject): Promise<DeleteBucketWebsiteResponse> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: this._defaultNumber(runtime.readTimeout, this._readTimeout),
      connectTimeout: this._defaultNumber(runtime.connectTimeout, this._connectTimeout),
      localAddr: this._default(runtime.localAddr, this._localAddr),
      httpProxy: this._default(runtime.httpProxy, this._httpProxy),
      httpsProxy: this._default(runtime.httpsProxy, this._httpsProxy),
      noProxy: this._default(runtime.noProxy, this._noProxy),
      socks5Proxy: this._default(runtime.socks5Proxy, this._socks5Proxy),
      socks5NetWork: this._default(runtime.socks5NetWork, this._socks5NetWork),
      maxIdleConns: this._defaultNumber(runtime.maxIdleConns, this._maxIdleConns),
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: this._defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: this._default(runtime.backoffPolicy, "no"),
        period: this._defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
      logger: this._logger,
      listener: runtime.listener,
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
        let token = this._getSecurityToken();
        request_.protocol = this._protocol;
        request_.method = "DELETE";
        request_.pathname = `/?website`;
        request_.headers = {
          host: this.getHost(request.bucketName),
          date: this._getDate(),
          'user-agent': this._getUserAgent(),
        };
        if (this._notEmpty(token)) {
          request_.headers["x-oss-security-token"] = token;
        }
        request_.headers["authorization"] = this._getAuth(request_, request.bucketName);
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap = null;
        let bodyStr = await this._readAsString(response_);
        if (this._isFail(response_)) {
          respMap = this._parseXml(bodyStr, ServerError);
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

  async getSymlink(request: GetSymlinkRequest, runtime: RuntimeObject): Promise<GetSymlinkResponse> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: this._defaultNumber(runtime.readTimeout, this._readTimeout),
      connectTimeout: this._defaultNumber(runtime.connectTimeout, this._connectTimeout),
      localAddr: this._default(runtime.localAddr, this._localAddr),
      httpProxy: this._default(runtime.httpProxy, this._httpProxy),
      httpsProxy: this._default(runtime.httpsProxy, this._httpsProxy),
      noProxy: this._default(runtime.noProxy, this._noProxy),
      socks5Proxy: this._default(runtime.socks5Proxy, this._socks5Proxy),
      socks5NetWork: this._default(runtime.socks5NetWork, this._socks5NetWork),
      maxIdleConns: this._defaultNumber(runtime.maxIdleConns, this._maxIdleConns),
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: this._defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: this._default(runtime.backoffPolicy, "no"),
        period: this._defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
      logger: this._logger,
      listener: runtime.listener,
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
        let token = this._getSecurityToken();
        request_.protocol = this._protocol;
        request_.method = "GET";
        request_.pathname = `/${request.objectName}?symlink`;
        request_.headers = {
          host: this.getHost(request.bucketName),
          date: this._getDate(),
          'user-agent': this._getUserAgent(),
        };
        if (this._notEmpty(token)) {
          request_.headers["x-oss-security-token"] = token;
        }
        request_.headers["authorization"] = this._getAuth(request_, request.bucketName);
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap = null;
        let bodyStr = await this._readAsString(response_);
        if (this._isFail(response_)) {
          respMap = this._parseXml(bodyStr, ServerError);
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

  async getBucketLifecycle(request: GetBucketLifecycleRequest, runtime: RuntimeObject): Promise<GetBucketLifecycleResponse> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: this._defaultNumber(runtime.readTimeout, this._readTimeout),
      connectTimeout: this._defaultNumber(runtime.connectTimeout, this._connectTimeout),
      localAddr: this._default(runtime.localAddr, this._localAddr),
      httpProxy: this._default(runtime.httpProxy, this._httpProxy),
      httpsProxy: this._default(runtime.httpsProxy, this._httpsProxy),
      noProxy: this._default(runtime.noProxy, this._noProxy),
      socks5Proxy: this._default(runtime.socks5Proxy, this._socks5Proxy),
      socks5NetWork: this._default(runtime.socks5NetWork, this._socks5NetWork),
      maxIdleConns: this._defaultNumber(runtime.maxIdleConns, this._maxIdleConns),
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: this._defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: this._default(runtime.backoffPolicy, "no"),
        period: this._defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
      logger: this._logger,
      listener: runtime.listener,
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
        let token = this._getSecurityToken();
        request_.protocol = this._protocol;
        request_.method = "GET";
        request_.pathname = `/?lifecycle`;
        request_.headers = {
          host: this.getHost(request.bucketName),
          date: this._getDate(),
          'user-agent': this._getUserAgent(),
        };
        if (this._notEmpty(token)) {
          request_.headers["x-oss-security-token"] = token;
        }
        request_.headers["authorization"] = this._getAuth(request_, request.bucketName);
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap = null;
        let bodyStr = await this._readAsString(response_);
        if (this._isFail(response_)) {
          respMap = this._parseXml(bodyStr, ServerError);
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

        respMap = this._parseXml(bodyStr, GetBucketLifecycleResponse);
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

  async putSymlink(request: PutSymlinkRequest, runtime: RuntimeObject): Promise<PutSymlinkResponse> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: this._defaultNumber(runtime.readTimeout, this._readTimeout),
      connectTimeout: this._defaultNumber(runtime.connectTimeout, this._connectTimeout),
      localAddr: this._default(runtime.localAddr, this._localAddr),
      httpProxy: this._default(runtime.httpProxy, this._httpProxy),
      httpsProxy: this._default(runtime.httpsProxy, this._httpsProxy),
      noProxy: this._default(runtime.noProxy, this._noProxy),
      socks5Proxy: this._default(runtime.socks5Proxy, this._socks5Proxy),
      socks5NetWork: this._default(runtime.socks5NetWork, this._socks5NetWork),
      maxIdleConns: this._defaultNumber(runtime.maxIdleConns, this._maxIdleConns),
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: this._defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: this._default(runtime.backoffPolicy, "no"),
        period: this._defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
      logger: this._logger,
      listener: runtime.listener,
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
        let token = this._getSecurityToken();
        request_.protocol = this._protocol;
        request_.method = "PUT";
        request_.pathname = `/${request.objectName}?symlink`;
        request_.headers = {
          host: this.getHost(request.bucketName),
          date: this._getDate(),
          'user-agent': this._getUserAgent(),
          ...this._toHeader(request.header),
        };
        if (this._notEmpty(token)) {
          request_.headers["x-oss-security-token"] = token;
        }
        request_.headers["authorization"] = this._getAuth(request_, request.bucketName);
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap = null;
        let bodyStr = await this._readAsString(response_);
        if (this._isFail(response_)) {
          respMap = this._parseXml(bodyStr, ServerError);
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

  async getBucketReferer(request: GetBucketRefererRequest, runtime: RuntimeObject): Promise<GetBucketRefererResponse> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: this._defaultNumber(runtime.readTimeout, this._readTimeout),
      connectTimeout: this._defaultNumber(runtime.connectTimeout, this._connectTimeout),
      localAddr: this._default(runtime.localAddr, this._localAddr),
      httpProxy: this._default(runtime.httpProxy, this._httpProxy),
      httpsProxy: this._default(runtime.httpsProxy, this._httpsProxy),
      noProxy: this._default(runtime.noProxy, this._noProxy),
      socks5Proxy: this._default(runtime.socks5Proxy, this._socks5Proxy),
      socks5NetWork: this._default(runtime.socks5NetWork, this._socks5NetWork),
      maxIdleConns: this._defaultNumber(runtime.maxIdleConns, this._maxIdleConns),
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: this._defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: this._default(runtime.backoffPolicy, "no"),
        period: this._defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
      logger: this._logger,
      listener: runtime.listener,
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
        let token = this._getSecurityToken();
        request_.protocol = this._protocol;
        request_.method = "GET";
        request_.pathname = `/?referer`;
        request_.headers = {
          host: this.getHost(request.bucketName),
          date: this._getDate(),
          'user-agent': this._getUserAgent(),
        };
        if (this._notEmpty(token)) {
          request_.headers["x-oss-security-token"] = token;
        }
        request_.headers["authorization"] = this._getAuth(request_, request.bucketName);
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap = null;
        let bodyStr = await this._readAsString(response_);
        if (this._isFail(response_)) {
          respMap = this._parseXml(bodyStr, ServerError);
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

        respMap = this._parseXml(bodyStr, GetBucketRefererResponse);
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

  async callback(request: CallbackRequest, runtime: RuntimeObject): Promise<CallbackResponse> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: this._defaultNumber(runtime.readTimeout, this._readTimeout),
      connectTimeout: this._defaultNumber(runtime.connectTimeout, this._connectTimeout),
      localAddr: this._default(runtime.localAddr, this._localAddr),
      httpProxy: this._default(runtime.httpProxy, this._httpProxy),
      httpsProxy: this._default(runtime.httpsProxy, this._httpsProxy),
      noProxy: this._default(runtime.noProxy, this._noProxy),
      socks5Proxy: this._default(runtime.socks5Proxy, this._socks5Proxy),
      socks5NetWork: this._default(runtime.socks5NetWork, this._socks5NetWork),
      maxIdleConns: this._defaultNumber(runtime.maxIdleConns, this._maxIdleConns),
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: this._defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: this._default(runtime.backoffPolicy, "no"),
        period: this._defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
      logger: this._logger,
      listener: runtime.listener,
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
        let token = this._getSecurityToken();
        request_.protocol = this._protocol;
        request_.method = "GET";
        request_.pathname = `/`;
        request_.headers = {
          host: this.getHost(request.bucketName),
          date: this._getDate(),
          'user-agent': this._getUserAgent(),
        };
        if (this._notEmpty(token)) {
          request_.headers["x-oss-security-token"] = token;
        }
        request_.headers["authorization"] = this._getAuth(request_, request.bucketName);
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap = null;
        let bodyStr = await this._readAsString(response_);
        if (this._isFail(response_)) {
          respMap = this._parseXml(bodyStr, ServerError);
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

  async getBucketLogging(request: GetBucketLoggingRequest, runtime: RuntimeObject): Promise<GetBucketLoggingResponse> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: this._defaultNumber(runtime.readTimeout, this._readTimeout),
      connectTimeout: this._defaultNumber(runtime.connectTimeout, this._connectTimeout),
      localAddr: this._default(runtime.localAddr, this._localAddr),
      httpProxy: this._default(runtime.httpProxy, this._httpProxy),
      httpsProxy: this._default(runtime.httpsProxy, this._httpsProxy),
      noProxy: this._default(runtime.noProxy, this._noProxy),
      socks5Proxy: this._default(runtime.socks5Proxy, this._socks5Proxy),
      socks5NetWork: this._default(runtime.socks5NetWork, this._socks5NetWork),
      maxIdleConns: this._defaultNumber(runtime.maxIdleConns, this._maxIdleConns),
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: this._defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: this._default(runtime.backoffPolicy, "no"),
        period: this._defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
      logger: this._logger,
      listener: runtime.listener,
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
        let token = this._getSecurityToken();
        request_.protocol = this._protocol;
        request_.method = "GET";
        request_.pathname = `/?logging`;
        request_.headers = {
          host: this.getHost(request.bucketName),
          date: this._getDate(),
          'user-agent': this._getUserAgent(),
        };
        if (this._notEmpty(token)) {
          request_.headers["x-oss-security-token"] = token;
        }
        request_.headers["authorization"] = this._getAuth(request_, request.bucketName);
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap = null;
        let bodyStr = await this._readAsString(response_);
        if (this._isFail(response_)) {
          respMap = this._parseXml(bodyStr, ServerError);
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

        respMap = this._parseXml(bodyStr, GetBucketLoggingResponse);
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

  async putObjectAcl(request: PutObjectAclRequest, runtime: RuntimeObject): Promise<PutObjectAclResponse> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: this._defaultNumber(runtime.readTimeout, this._readTimeout),
      connectTimeout: this._defaultNumber(runtime.connectTimeout, this._connectTimeout),
      localAddr: this._default(runtime.localAddr, this._localAddr),
      httpProxy: this._default(runtime.httpProxy, this._httpProxy),
      httpsProxy: this._default(runtime.httpsProxy, this._httpsProxy),
      noProxy: this._default(runtime.noProxy, this._noProxy),
      socks5Proxy: this._default(runtime.socks5Proxy, this._socks5Proxy),
      socks5NetWork: this._default(runtime.socks5NetWork, this._socks5NetWork),
      maxIdleConns: this._defaultNumber(runtime.maxIdleConns, this._maxIdleConns),
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: this._defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: this._default(runtime.backoffPolicy, "no"),
        period: this._defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
      logger: this._logger,
      listener: runtime.listener,
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
        let token = this._getSecurityToken();
        request_.protocol = this._protocol;
        request_.method = "PUT";
        request_.pathname = `/${request.objectName}?acl`;
        request_.headers = {
          host: this.getHost(request.bucketName),
          date: this._getDate(),
          'user-agent': this._getUserAgent(),
          ...this._toHeader(request.header),
        };
        if (this._notEmpty(token)) {
          request_.headers["x-oss-security-token"] = token;
        }
        request_.headers["authorization"] = this._getAuth(request_, request.bucketName);
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap = null;
        let bodyStr = await this._readAsString(response_);
        if (this._isFail(response_)) {
          respMap = this._parseXml(bodyStr, ServerError);
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

  async getBucketInfo(request: GetBucketInfoRequest, runtime: RuntimeObject): Promise<GetBucketInfoResponse> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: this._defaultNumber(runtime.readTimeout, this._readTimeout),
      connectTimeout: this._defaultNumber(runtime.connectTimeout, this._connectTimeout),
      localAddr: this._default(runtime.localAddr, this._localAddr),
      httpProxy: this._default(runtime.httpProxy, this._httpProxy),
      httpsProxy: this._default(runtime.httpsProxy, this._httpsProxy),
      noProxy: this._default(runtime.noProxy, this._noProxy),
      socks5Proxy: this._default(runtime.socks5Proxy, this._socks5Proxy),
      socks5NetWork: this._default(runtime.socks5NetWork, this._socks5NetWork),
      maxIdleConns: this._defaultNumber(runtime.maxIdleConns, this._maxIdleConns),
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: this._defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: this._default(runtime.backoffPolicy, "no"),
        period: this._defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
      logger: this._logger,
      listener: runtime.listener,
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
        let token = this._getSecurityToken();
        request_.protocol = this._protocol;
        request_.method = "GET";
        request_.pathname = `/?bucketInfo`;
        request_.headers = {
          host: this.getHost(request.bucketName),
          date: this._getDate(),
          'user-agent': this._getUserAgent(),
        };
        if (this._notEmpty(token)) {
          request_.headers["x-oss-security-token"] = token;
        }
        request_.headers["authorization"] = this._getAuth(request_, request.bucketName);
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap = null;
        let bodyStr = await this._readAsString(response_);
        if (this._isFail(response_)) {
          respMap = this._parseXml(bodyStr, ServerError);
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

        respMap = this._parseXml(bodyStr, GetBucketInfoResponse);
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

  async putLiveChannelStatus(request: PutLiveChannelStatusRequest, runtime: RuntimeObject): Promise<PutLiveChannelStatusResponse> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: this._defaultNumber(runtime.readTimeout, this._readTimeout),
      connectTimeout: this._defaultNumber(runtime.connectTimeout, this._connectTimeout),
      localAddr: this._default(runtime.localAddr, this._localAddr),
      httpProxy: this._default(runtime.httpProxy, this._httpProxy),
      httpsProxy: this._default(runtime.httpsProxy, this._httpsProxy),
      noProxy: this._default(runtime.noProxy, this._noProxy),
      socks5Proxy: this._default(runtime.socks5Proxy, this._socks5Proxy),
      socks5NetWork: this._default(runtime.socks5NetWork, this._socks5NetWork),
      maxIdleConns: this._defaultNumber(runtime.maxIdleConns, this._maxIdleConns),
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: this._defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: this._default(runtime.backoffPolicy, "no"),
        period: this._defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
      logger: this._logger,
      listener: runtime.listener,
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
        let token = this._getSecurityToken();
        request_.protocol = this._protocol;
        request_.method = "PUT";
        request_.pathname = `/${request.channelName}?live`;
        request_.headers = {
          host: this.getHost(request.bucketName),
          date: this._getDate(),
          'user-agent': this._getUserAgent(),
        };
        if (this._notEmpty(token)) {
          request_.headers["x-oss-security-token"] = token;
        }
        request_.query = this._toQuery(request.filter);
        request_.headers["authorization"] = this._getAuth(request_, request.bucketName);
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap = null;
        let bodyStr = await this._readAsString(response_);
        if (this._isFail(response_)) {
          respMap = this._parseXml(bodyStr, ServerError);
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

  async initiateMultipartUpload(request: InitiateMultipartUploadRequest, runtime: RuntimeObject): Promise<InitiateMultipartUploadResponse> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: this._defaultNumber(runtime.readTimeout, this._readTimeout),
      connectTimeout: this._defaultNumber(runtime.connectTimeout, this._connectTimeout),
      localAddr: this._default(runtime.localAddr, this._localAddr),
      httpProxy: this._default(runtime.httpProxy, this._httpProxy),
      httpsProxy: this._default(runtime.httpsProxy, this._httpsProxy),
      noProxy: this._default(runtime.noProxy, this._noProxy),
      socks5Proxy: this._default(runtime.socks5Proxy, this._socks5Proxy),
      socks5NetWork: this._default(runtime.socks5NetWork, this._socks5NetWork),
      maxIdleConns: this._defaultNumber(runtime.maxIdleConns, this._maxIdleConns),
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: this._defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: this._default(runtime.backoffPolicy, "no"),
        period: this._defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
      logger: this._logger,
      listener: runtime.listener,
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
        let token = this._getSecurityToken();
        request_.protocol = this._protocol;
        request_.method = "POST";
        request_.pathname = `/${request.objectName}?uploads`;
        request_.headers = {
          host: this.getHost(request.bucketName),
          date: this._getDate(),
          'user-agent': this._getUserAgent(),
          ...this._toHeader(request.header),
        };
        if (this._notEmpty(token)) {
          request_.headers["x-oss-security-token"] = token;
        }
        request_.query = this._toQuery(request.filter);
        request_.headers["content-type"] = this._default(this._getSpecialValue(request.header, "content-type"), this._getContentType(request.objectName));
        request_.headers["authorization"] = this._getAuth(request_, request.bucketName);
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap = null;
        let bodyStr = await this._readAsString(response_);
        if (this._isFail(response_)) {
          respMap = this._parseXml(bodyStr, ServerError);
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

        respMap = this._parseXml(bodyStr, InitiateMultipartUploadResponse);
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

  async optionObject(request: OptionObjectRequest, runtime: RuntimeObject): Promise<OptionObjectResponse> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: this._defaultNumber(runtime.readTimeout, this._readTimeout),
      connectTimeout: this._defaultNumber(runtime.connectTimeout, this._connectTimeout),
      localAddr: this._default(runtime.localAddr, this._localAddr),
      httpProxy: this._default(runtime.httpProxy, this._httpProxy),
      httpsProxy: this._default(runtime.httpsProxy, this._httpsProxy),
      noProxy: this._default(runtime.noProxy, this._noProxy),
      socks5Proxy: this._default(runtime.socks5Proxy, this._socks5Proxy),
      socks5NetWork: this._default(runtime.socks5NetWork, this._socks5NetWork),
      maxIdleConns: this._defaultNumber(runtime.maxIdleConns, this._maxIdleConns),
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: this._defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: this._default(runtime.backoffPolicy, "no"),
        period: this._defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
      logger: this._logger,
      listener: runtime.listener,
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
        let token = this._getSecurityToken();
        request_.protocol = this._protocol;
        request_.method = "OPTIONS";
        request_.pathname = `/${request.objectName}`;
        request_.headers = {
          host: this.getHost(request.bucketName),
          date: this._getDate(),
          'user-agent': this._getUserAgent(),
          ...this._toHeader(request.header),
        };
        if (this._notEmpty(token)) {
          request_.headers["x-oss-security-token"] = token;
        }
        request_.headers["authorization"] = this._getAuth(request_, request.bucketName);
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap = null;
        let bodyStr = await this._readAsString(response_);
        if (this._isFail(response_)) {
          respMap = this._parseXml(bodyStr, ServerError);
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

  async postVodPlaylist(request: PostVodPlaylistRequest, runtime: RuntimeObject): Promise<PostVodPlaylistResponse> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: this._defaultNumber(runtime.readTimeout, this._readTimeout),
      connectTimeout: this._defaultNumber(runtime.connectTimeout, this._connectTimeout),
      localAddr: this._default(runtime.localAddr, this._localAddr),
      httpProxy: this._default(runtime.httpProxy, this._httpProxy),
      httpsProxy: this._default(runtime.httpsProxy, this._httpsProxy),
      noProxy: this._default(runtime.noProxy, this._noProxy),
      socks5Proxy: this._default(runtime.socks5Proxy, this._socks5Proxy),
      socks5NetWork: this._default(runtime.socks5NetWork, this._socks5NetWork),
      maxIdleConns: this._defaultNumber(runtime.maxIdleConns, this._maxIdleConns),
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: this._defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: this._default(runtime.backoffPolicy, "no"),
        period: this._defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
      logger: this._logger,
      listener: runtime.listener,
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
        let token = this._getSecurityToken();
        request_.protocol = this._protocol;
        request_.method = "POST";
        request_.pathname = `/${request.channelName}/${request.playlistName}?vod`;
        request_.headers = {
          host: this.getHost(request.bucketName),
          date: this._getDate(),
          'user-agent': this._getUserAgent(),
        };
        if (this._notEmpty(token)) {
          request_.headers["x-oss-security-token"] = token;
        }
        request_.query = this._toQuery(request.filter);
        request_.headers["authorization"] = this._getAuth(request_, request.bucketName);
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap = null;
        let bodyStr = await this._readAsString(response_);
        if (this._isFail(response_)) {
          respMap = this._parseXml(bodyStr, ServerError);
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

  async postObject(request: PostObjectRequest, runtime: RuntimeObject): Promise<PostObjectResponse> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: this._defaultNumber(runtime.readTimeout, this._readTimeout),
      connectTimeout: this._defaultNumber(runtime.connectTimeout, this._connectTimeout),
      localAddr: this._default(runtime.localAddr, this._localAddr),
      httpProxy: this._default(runtime.httpProxy, this._httpProxy),
      httpsProxy: this._default(runtime.httpsProxy, this._httpsProxy),
      noProxy: this._default(runtime.noProxy, this._noProxy),
      socks5Proxy: this._default(runtime.socks5Proxy, this._socks5Proxy),
      socks5NetWork: this._default(runtime.socks5NetWork, this._socks5NetWork),
      maxIdleConns: this._defaultNumber(runtime.maxIdleConns, this._maxIdleConns),
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: this._defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: this._default(runtime.backoffPolicy, "no"),
        period: this._defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
      logger: this._logger,
      listener: runtime.listener,
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
        let token = this._getSecurityToken();
        request_.protocol = this._protocol;
        request_.method = "POST";
        request_.pathname = `/`;
        request_.headers = {
          host: this.getHost(request.bucketName),
          date: this._getDate(),
          'user-agent': this._getUserAgent(),
        };
        if (this._notEmpty(token)) {
          request_.headers["x-oss-security-token"] = token;
        }
        request_.headers["authorization"] = this._getAuth(request_, request.bucketName);
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap = null;
        let bodyStr = await this._readAsString(response_);
        if (this._isFail(response_)) {
          respMap = this._parseXml(bodyStr, ServerError);
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

        return $tea.cast<PostObjectResponse>({
          ...response_.headers,
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

  async headObject(request: HeadObjectRequest, runtime: RuntimeObject): Promise<HeadObjectResponse> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: this._defaultNumber(runtime.readTimeout, this._readTimeout),
      connectTimeout: this._defaultNumber(runtime.connectTimeout, this._connectTimeout),
      localAddr: this._default(runtime.localAddr, this._localAddr),
      httpProxy: this._default(runtime.httpProxy, this._httpProxy),
      httpsProxy: this._default(runtime.httpsProxy, this._httpsProxy),
      noProxy: this._default(runtime.noProxy, this._noProxy),
      socks5Proxy: this._default(runtime.socks5Proxy, this._socks5Proxy),
      socks5NetWork: this._default(runtime.socks5NetWork, this._socks5NetWork),
      maxIdleConns: this._defaultNumber(runtime.maxIdleConns, this._maxIdleConns),
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: this._defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: this._default(runtime.backoffPolicy, "no"),
        period: this._defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
      logger: this._logger,
      listener: runtime.listener,
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
        let token = this._getSecurityToken();
        request_.protocol = this._protocol;
        request_.method = "HEAD";
        request_.pathname = `/${request.objectName}`;
        request_.headers = {
          host: this.getHost(request.bucketName),
          date: this._getDate(),
          'user-agent': this._getUserAgent(),
          ...this._toHeader(request.header),
        };
        if (this._notEmpty(token)) {
          request_.headers["x-oss-security-token"] = token;
        }
        request_.headers["authorization"] = this._getAuth(request_, request.bucketName);
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap = null;
        let bodyStr = await this._readAsString(response_);
        if (this._isFail(response_)) {
          respMap = this._parseXml(bodyStr, ServerError);
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
          usermeta: this._toMeta(response_.headers, "x-oss-meta-"),
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

  async deleteObjectTagging(request: DeleteObjectTaggingRequest, runtime: RuntimeObject): Promise<DeleteObjectTaggingResponse> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: this._defaultNumber(runtime.readTimeout, this._readTimeout),
      connectTimeout: this._defaultNumber(runtime.connectTimeout, this._connectTimeout),
      localAddr: this._default(runtime.localAddr, this._localAddr),
      httpProxy: this._default(runtime.httpProxy, this._httpProxy),
      httpsProxy: this._default(runtime.httpsProxy, this._httpsProxy),
      noProxy: this._default(runtime.noProxy, this._noProxy),
      socks5Proxy: this._default(runtime.socks5Proxy, this._socks5Proxy),
      socks5NetWork: this._default(runtime.socks5NetWork, this._socks5NetWork),
      maxIdleConns: this._defaultNumber(runtime.maxIdleConns, this._maxIdleConns),
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: this._defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: this._default(runtime.backoffPolicy, "no"),
        period: this._defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
      logger: this._logger,
      listener: runtime.listener,
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
        let token = this._getSecurityToken();
        request_.protocol = this._protocol;
        request_.method = "DELETE";
        request_.pathname = `/${request.objectName}?tagging`;
        request_.headers = {
          host: this.getHost(request.bucketName),
          date: this._getDate(),
          'user-agent': this._getUserAgent(),
        };
        if (this._notEmpty(token)) {
          request_.headers["x-oss-security-token"] = token;
        }
        request_.headers["authorization"] = this._getAuth(request_, request.bucketName);
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap = null;
        let bodyStr = await this._readAsString(response_);
        if (this._isFail(response_)) {
          respMap = this._parseXml(bodyStr, ServerError);
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

  async restoreObject(request: RestoreObjectRequest, runtime: RuntimeObject): Promise<RestoreObjectResponse> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: this._defaultNumber(runtime.readTimeout, this._readTimeout),
      connectTimeout: this._defaultNumber(runtime.connectTimeout, this._connectTimeout),
      localAddr: this._default(runtime.localAddr, this._localAddr),
      httpProxy: this._default(runtime.httpProxy, this._httpProxy),
      httpsProxy: this._default(runtime.httpsProxy, this._httpsProxy),
      noProxy: this._default(runtime.noProxy, this._noProxy),
      socks5Proxy: this._default(runtime.socks5Proxy, this._socks5Proxy),
      socks5NetWork: this._default(runtime.socks5NetWork, this._socks5NetWork),
      maxIdleConns: this._defaultNumber(runtime.maxIdleConns, this._maxIdleConns),
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: this._defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: this._default(runtime.backoffPolicy, "no"),
        period: this._defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
      logger: this._logger,
      listener: runtime.listener,
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
        let token = this._getSecurityToken();
        request_.protocol = this._protocol;
        request_.method = "POST";
        request_.pathname = `/${request.objectName}?restore`;
        request_.headers = {
          host: this.getHost(request.bucketName),
          date: this._getDate(),
          'user-agent': this._getUserAgent(),
        };
        if (this._notEmpty(token)) {
          request_.headers["x-oss-security-token"] = token;
        }
        request_.headers["authorization"] = this._getAuth(request_, request.bucketName);
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap = null;
        let bodyStr = await this._readAsString(response_);
        if (this._isFail(response_)) {
          respMap = this._parseXml(bodyStr, ServerError);
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

  async getObjectAcl(request: GetObjectAclRequest, runtime: RuntimeObject): Promise<GetObjectAclResponse> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: this._defaultNumber(runtime.readTimeout, this._readTimeout),
      connectTimeout: this._defaultNumber(runtime.connectTimeout, this._connectTimeout),
      localAddr: this._default(runtime.localAddr, this._localAddr),
      httpProxy: this._default(runtime.httpProxy, this._httpProxy),
      httpsProxy: this._default(runtime.httpsProxy, this._httpsProxy),
      noProxy: this._default(runtime.noProxy, this._noProxy),
      socks5Proxy: this._default(runtime.socks5Proxy, this._socks5Proxy),
      socks5NetWork: this._default(runtime.socks5NetWork, this._socks5NetWork),
      maxIdleConns: this._defaultNumber(runtime.maxIdleConns, this._maxIdleConns),
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: this._defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: this._default(runtime.backoffPolicy, "no"),
        period: this._defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
      logger: this._logger,
      listener: runtime.listener,
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
        let token = this._getSecurityToken();
        request_.protocol = this._protocol;
        request_.method = "GET";
        request_.pathname = `/${request.objectName}?acl`;
        request_.headers = {
          host: this.getHost(request.bucketName),
          date: this._getDate(),
          'user-agent': this._getUserAgent(),
        };
        if (this._notEmpty(token)) {
          request_.headers["x-oss-security-token"] = token;
        }
        request_.headers["authorization"] = this._getAuth(request_, request.bucketName);
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap = null;
        let bodyStr = await this._readAsString(response_);
        if (this._isFail(response_)) {
          respMap = this._parseXml(bodyStr, ServerError);
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

        respMap = this._parseXml(bodyStr, GetObjectAclResponse);
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

  async putBucketAcl(request: PutBucketAclRequest, runtime: RuntimeObject): Promise<PutBucketAclResponse> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: this._defaultNumber(runtime.readTimeout, this._readTimeout),
      connectTimeout: this._defaultNumber(runtime.connectTimeout, this._connectTimeout),
      localAddr: this._default(runtime.localAddr, this._localAddr),
      httpProxy: this._default(runtime.httpProxy, this._httpProxy),
      httpsProxy: this._default(runtime.httpsProxy, this._httpsProxy),
      noProxy: this._default(runtime.noProxy, this._noProxy),
      socks5Proxy: this._default(runtime.socks5Proxy, this._socks5Proxy),
      socks5NetWork: this._default(runtime.socks5NetWork, this._socks5NetWork),
      maxIdleConns: this._defaultNumber(runtime.maxIdleConns, this._maxIdleConns),
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: this._defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: this._default(runtime.backoffPolicy, "no"),
        period: this._defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
      logger: this._logger,
      listener: runtime.listener,
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
        let token = this._getSecurityToken();
        request_.protocol = this._protocol;
        request_.method = "PUT";
        request_.pathname = `/?acl`;
        request_.headers = {
          host: this.getHost(request.bucketName),
          date: this._getDate(),
          'user-agent': this._getUserAgent(),
          ...this._toHeader(request.header),
        };
        if (this._notEmpty(token)) {
          request_.headers["x-oss-security-token"] = token;
        }
        request_.headers["authorization"] = this._getAuth(request_, request.bucketName);
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap = null;
        let bodyStr = await this._readAsString(response_);
        if (this._isFail(response_)) {
          respMap = this._parseXml(bodyStr, ServerError);
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

  async deleteBucket(request: DeleteBucketRequest, runtime: RuntimeObject): Promise<DeleteBucketResponse> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: this._defaultNumber(runtime.readTimeout, this._readTimeout),
      connectTimeout: this._defaultNumber(runtime.connectTimeout, this._connectTimeout),
      localAddr: this._default(runtime.localAddr, this._localAddr),
      httpProxy: this._default(runtime.httpProxy, this._httpProxy),
      httpsProxy: this._default(runtime.httpsProxy, this._httpsProxy),
      noProxy: this._default(runtime.noProxy, this._noProxy),
      socks5Proxy: this._default(runtime.socks5Proxy, this._socks5Proxy),
      socks5NetWork: this._default(runtime.socks5NetWork, this._socks5NetWork),
      maxIdleConns: this._defaultNumber(runtime.maxIdleConns, this._maxIdleConns),
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: this._defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: this._default(runtime.backoffPolicy, "no"),
        period: this._defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
      logger: this._logger,
      listener: runtime.listener,
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
        let token = this._getSecurityToken();
        request_.protocol = this._protocol;
        request_.method = "DELETE";
        request_.pathname = `/`;
        request_.headers = {
          host: this.getHost(request.bucketName),
          date: this._getDate(),
          'user-agent': this._getUserAgent(),
        };
        if (this._notEmpty(token)) {
          request_.headers["x-oss-security-token"] = token;
        }
        request_.headers["authorization"] = this._getAuth(request_, request.bucketName);
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap = null;
        let bodyStr = await this._readAsString(response_);
        if (this._isFail(response_)) {
          respMap = this._parseXml(bodyStr, ServerError);
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

  async putObject(request: PutObjectRequest, runtime: RuntimeObject): Promise<PutObjectResponse> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: this._defaultNumber(runtime.readTimeout, this._readTimeout),
      connectTimeout: this._defaultNumber(runtime.connectTimeout, this._connectTimeout),
      localAddr: this._default(runtime.localAddr, this._localAddr),
      httpProxy: this._default(runtime.httpProxy, this._httpProxy),
      httpsProxy: this._default(runtime.httpsProxy, this._httpsProxy),
      noProxy: this._default(runtime.noProxy, this._noProxy),
      socks5Proxy: this._default(runtime.socks5Proxy, this._socks5Proxy),
      socks5NetWork: this._default(runtime.socks5NetWork, this._socks5NetWork),
      maxIdleConns: this._defaultNumber(runtime.maxIdleConns, this._maxIdleConns),
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: this._defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: this._default(runtime.backoffPolicy, "no"),
        period: this._defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
      logger: this._logger,
      listener: runtime.listener,
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
        let token = this._getSecurityToken();
        request_.protocol = this._protocol;
        request_.method = "PUT";
        request_.pathname = `/${request.objectName}`;
        request_.headers = {
          host: this.getHost(request.bucketName),
          date: this._getDate(),
          'user-agent': this._getUserAgent(),
          ...this._toHeader(request.header),
          ...this._parseMeta(request.userMeta, "x-oss-meta-"),
        };
        if (this._notEmpty(token)) {
          request_.headers["x-oss-security-token"] = token;
        }
        request_.body = request.body;
        request_.headers["content-type"] = this._default(this._getSpecialValue(request.header, "content-type"), this._getContentType(request.objectName));
        request_.headers["authorization"] = this._getAuth(request_, request.bucketName);
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap = null;
        let bodyStr = await this._readAsString(response_);
        if (this._isFail(response_)) {
          respMap = this._parseXml(bodyStr, ServerError);
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

  getHost(bucketName: string): string {
    if (this._empty(this._endpoint)) {
      this._endpoint = `oss-${this._regionId}.aliyuncs.com`;
    }

    if (this._empty(bucketName)) {
      return this._endpoint;
    }

    let host = null;
    if (this._equal(this._hostModel, "ip")) {
      host = `${this._endpoint}/${bucketName}`;
    } else if (this._equal(this._hostModel, "cname")) {
      host = this._endpoint;
    } else {
      host = `${bucketName}.${this._endpoint}`;
    }

    return host;
  }

}
