// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class InitiateMultipartUploadRequest extends TeaModel {
    // BucketName
    @NameInMap("BucketName")
    @Validation(required = true, pattern = "[a-zA-Z0-9\\-\\_]+")
    public String bucketName;

    // ObjectName
    @NameInMap("ObjectName")
    @Validation(required = true)
    public String objectName;

    // Filter
    @NameInMap("Filter")
    public InitiateMultipartUploadRequestFilter filter;

    // Header
    @NameInMap("Header")
    public InitiateMultipartUploadRequestHeader header;

    public static InitiateMultipartUploadRequest build(java.util.Map<String, ?> map) throws Exception {
        InitiateMultipartUploadRequest self = new InitiateMultipartUploadRequest();
        return TeaModel.build(map, self);
    }

    public InitiateMultipartUploadRequest setBucketName(String bucketName) {
        this.bucketName = bucketName;
        return this;
    }
    public String getBucketName() {
        return this.bucketName;
    }

    public InitiateMultipartUploadRequest setObjectName(String objectName) {
        this.objectName = objectName;
        return this;
    }
    public String getObjectName() {
        return this.objectName;
    }

    public InitiateMultipartUploadRequest setFilter(InitiateMultipartUploadRequestFilter filter) {
        this.filter = filter;
        return this;
    }
    public InitiateMultipartUploadRequestFilter getFilter() {
        return this.filter;
    }

    public InitiateMultipartUploadRequest setHeader(InitiateMultipartUploadRequestHeader header) {
        this.header = header;
        return this;
    }
    public InitiateMultipartUploadRequestHeader getHeader() {
        return this.header;
    }

    public static class InitiateMultipartUploadRequestFilter extends TeaModel {
        // encoding-type
        @NameInMap("encoding-type")
        public String encodingType;

        public static InitiateMultipartUploadRequestFilter build(java.util.Map<String, ?> map) throws Exception {
            InitiateMultipartUploadRequestFilter self = new InitiateMultipartUploadRequestFilter();
            return TeaModel.build(map, self);
        }

        public InitiateMultipartUploadRequestFilter setEncodingType(String encodingType) {
            this.encodingType = encodingType;
            return this;
        }
        public String getEncodingType() {
            return this.encodingType;
        }

    }

    public static class InitiateMultipartUploadRequestHeader extends TeaModel {
        // Cache-Control
        @NameInMap("Cache-Control")
        public String cacheControl;

        // Content-Disposition
        @NameInMap("Content-Disposition")
        public String contentDisposition;

        // Content-Encoding
        @NameInMap("Content-Encoding")
        public String contentEncoding;

        // Expires
        @NameInMap("Expires")
        public String expires;

        // x-oss-server-side-encryption
        @NameInMap("x-oss-server-side-encryption")
        public String serverSideEncryption;

        // x-oss-server-side-encryption-key-id
        @NameInMap("x-oss-server-side-encryption-key-id")
        public String serverSideEncryptionKeyId;

        // x-oss-storage-class
        @NameInMap("x-oss-storage-class")
        public String storageClass;

        // x-oss-tagging
        @NameInMap("x-oss-tagging")
        public String tagging;

        // content-type
        @NameInMap("content-type")
        public String contentType;

        public static InitiateMultipartUploadRequestHeader build(java.util.Map<String, ?> map) throws Exception {
            InitiateMultipartUploadRequestHeader self = new InitiateMultipartUploadRequestHeader();
            return TeaModel.build(map, self);
        }

        public InitiateMultipartUploadRequestHeader setCacheControl(String cacheControl) {
            this.cacheControl = cacheControl;
            return this;
        }
        public String getCacheControl() {
            return this.cacheControl;
        }

        public InitiateMultipartUploadRequestHeader setContentDisposition(String contentDisposition) {
            this.contentDisposition = contentDisposition;
            return this;
        }
        public String getContentDisposition() {
            return this.contentDisposition;
        }

        public InitiateMultipartUploadRequestHeader setContentEncoding(String contentEncoding) {
            this.contentEncoding = contentEncoding;
            return this;
        }
        public String getContentEncoding() {
            return this.contentEncoding;
        }

        public InitiateMultipartUploadRequestHeader setExpires(String expires) {
            this.expires = expires;
            return this;
        }
        public String getExpires() {
            return this.expires;
        }

        public InitiateMultipartUploadRequestHeader setServerSideEncryption(String serverSideEncryption) {
            this.serverSideEncryption = serverSideEncryption;
            return this;
        }
        public String getServerSideEncryption() {
            return this.serverSideEncryption;
        }

        public InitiateMultipartUploadRequestHeader setServerSideEncryptionKeyId(String serverSideEncryptionKeyId) {
            this.serverSideEncryptionKeyId = serverSideEncryptionKeyId;
            return this;
        }
        public String getServerSideEncryptionKeyId() {
            return this.serverSideEncryptionKeyId;
        }

        public InitiateMultipartUploadRequestHeader setStorageClass(String storageClass) {
            this.storageClass = storageClass;
            return this;
        }
        public String getStorageClass() {
            return this.storageClass;
        }

        public InitiateMultipartUploadRequestHeader setTagging(String tagging) {
            this.tagging = tagging;
            return this;
        }
        public String getTagging() {
            return this.tagging;
        }

        public InitiateMultipartUploadRequestHeader setContentType(String contentType) {
            this.contentType = contentType;
            return this;
        }
        public String getContentType() {
            return this.contentType;
        }

    }

}
