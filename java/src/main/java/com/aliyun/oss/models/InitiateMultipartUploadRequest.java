// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class InitiateMultipartUploadRequest extends TeaModel {
    @NameInMap("BucketName")
    @Validation(required = true)
    public String bucketName;

    @NameInMap("ObjectName")
    @Validation(required = true)
    public String objectName;

    @NameInMap("Filter")
    public InitiateMultipartUploadRequestFilter filter;

    @NameInMap("Header")
    public InitiateMultipartUploadRequestHeader header;

    public static InitiateMultipartUploadRequest build(java.util.Map<String, ?> map) throws Exception {
        InitiateMultipartUploadRequest self = new InitiateMultipartUploadRequest();
        return TeaModel.build(map, self);
    }

    public static class InitiateMultipartUploadRequestFilter extends TeaModel {
        @NameInMap("encoding-type")
        public String encodingType;

        public static InitiateMultipartUploadRequestFilter build(java.util.Map<String, ?> map) throws Exception {
            InitiateMultipartUploadRequestFilter self = new InitiateMultipartUploadRequestFilter();
            return TeaModel.build(map, self);
        }

    }

    public static class InitiateMultipartUploadRequestHeader extends TeaModel {
        @NameInMap("Cache-Control")
        public String cacheControl;

        @NameInMap("Content-Disposition")
        public String contentDisposition;

        @NameInMap("Content-Encoding")
        public String contentEncoding;

        @NameInMap("Expires")
        public String expires;

        @NameInMap("x-oss-server-side-encryption")
        public String serverSideEncryption;

        @NameInMap("x-oss-server-side-encryption-key-id")
        public String serverSideEncryptionKeyId;

        @NameInMap("x-oss-storage-class")
        public String storageClass;

        @NameInMap("x-oss-tagging")
        public String tagging;

        @NameInMap("content-type")
        public String contentType;

        public static InitiateMultipartUploadRequestHeader build(java.util.Map<String, ?> map) throws Exception {
            InitiateMultipartUploadRequestHeader self = new InitiateMultipartUploadRequestHeader();
            return TeaModel.build(map, self);
        }

    }

}
