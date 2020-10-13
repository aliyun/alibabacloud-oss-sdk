// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class PutObjectRequest extends TeaModel {
    // BucketName
    @NameInMap("BucketName")
    @Validation(required = true, pattern = "[a-zA-Z0-9\\-\\_]+")
    public String bucketName;

    // ObjectName
    @NameInMap("ObjectName")
    @Validation(required = true)
    public String objectName;

    // UserMeta
    @NameInMap("UserMeta")
    public java.util.Map<String, String> userMeta;

    // body
    @NameInMap("body")
    public java.io.InputStream body;

    // Header
    @NameInMap("Header")
    public PutObjectRequestHeader header;

    public static PutObjectRequest build(java.util.Map<String, ?> map) throws Exception {
        PutObjectRequest self = new PutObjectRequest();
        return TeaModel.build(map, self);
    }

    public PutObjectRequest setBucketName(String bucketName) {
        this.bucketName = bucketName;
        return this;
    }
    public String getBucketName() {
        return this.bucketName;
    }

    public PutObjectRequest setObjectName(String objectName) {
        this.objectName = objectName;
        return this;
    }
    public String getObjectName() {
        return this.objectName;
    }

    public PutObjectRequest setUserMeta(java.util.Map<String, String> userMeta) {
        this.userMeta = userMeta;
        return this;
    }
    public java.util.Map<String, String> getUserMeta() {
        return this.userMeta;
    }

    public PutObjectRequest setBody(java.io.InputStream body) {
        this.body = body;
        return this;
    }
    public java.io.InputStream getBody() {
        return this.body;
    }

    public PutObjectRequest setHeader(PutObjectRequestHeader header) {
        this.header = header;
        return this;
    }
    public PutObjectRequestHeader getHeader() {
        return this.header;
    }

    public static class PutObjectRequestHeader extends TeaModel {
        // Authorization
        @NameInMap("Authorization")
        public String authorization;

        // Cache-Control
        @NameInMap("Cache-Control")
        public String cacheControl;

        // Content-Disposition
        @NameInMap("Content-Disposition")
        public String contentDisposition;

        // Content-Encoding
        @NameInMap("Content-Encoding")
        public String contentEncoding;

        // Content-MD5
        @NameInMap("Content-MD5")
        public String contentMD5;

        // Content-Length
        @NameInMap("Content-Length")
        public String contentLength;

        // CETag
        @NameInMap("CETag")
        public String eTag;

        // Expires
        @NameInMap("Expires")
        public String expires;

        // x-oss-server-side-encryption
        @NameInMap("x-oss-server-side-encryption")
        public String serverSideEncryption;

        // x-oss-server-side-encryption-key-id
        @NameInMap("x-oss-server-side-encryption-key-id")
        public String serverSideEncryptionKeyId;

        // x-oss-object-acl
        @NameInMap("x-oss-object-acl")
        public String objectAcl;

        // x-oss-storage-class
        @NameInMap("x-oss-storage-class")
        public String storageClass;

        // x-oss-tagging
        @NameInMap("x-oss-tagging")
        public String tagging;

        // content-type
        @NameInMap("content-type")
        public String contentType;

        public static PutObjectRequestHeader build(java.util.Map<String, ?> map) throws Exception {
            PutObjectRequestHeader self = new PutObjectRequestHeader();
            return TeaModel.build(map, self);
        }

        public PutObjectRequestHeader setAuthorization(String authorization) {
            this.authorization = authorization;
            return this;
        }
        public String getAuthorization() {
            return this.authorization;
        }

        public PutObjectRequestHeader setCacheControl(String cacheControl) {
            this.cacheControl = cacheControl;
            return this;
        }
        public String getCacheControl() {
            return this.cacheControl;
        }

        public PutObjectRequestHeader setContentDisposition(String contentDisposition) {
            this.contentDisposition = contentDisposition;
            return this;
        }
        public String getContentDisposition() {
            return this.contentDisposition;
        }

        public PutObjectRequestHeader setContentEncoding(String contentEncoding) {
            this.contentEncoding = contentEncoding;
            return this;
        }
        public String getContentEncoding() {
            return this.contentEncoding;
        }

        public PutObjectRequestHeader setContentMD5(String contentMD5) {
            this.contentMD5 = contentMD5;
            return this;
        }
        public String getContentMD5() {
            return this.contentMD5;
        }

        public PutObjectRequestHeader setContentLength(String contentLength) {
            this.contentLength = contentLength;
            return this;
        }
        public String getContentLength() {
            return this.contentLength;
        }

        public PutObjectRequestHeader setETag(String eTag) {
            this.eTag = eTag;
            return this;
        }
        public String getETag() {
            return this.eTag;
        }

        public PutObjectRequestHeader setExpires(String expires) {
            this.expires = expires;
            return this;
        }
        public String getExpires() {
            return this.expires;
        }

        public PutObjectRequestHeader setServerSideEncryption(String serverSideEncryption) {
            this.serverSideEncryption = serverSideEncryption;
            return this;
        }
        public String getServerSideEncryption() {
            return this.serverSideEncryption;
        }

        public PutObjectRequestHeader setServerSideEncryptionKeyId(String serverSideEncryptionKeyId) {
            this.serverSideEncryptionKeyId = serverSideEncryptionKeyId;
            return this;
        }
        public String getServerSideEncryptionKeyId() {
            return this.serverSideEncryptionKeyId;
        }

        public PutObjectRequestHeader setObjectAcl(String objectAcl) {
            this.objectAcl = objectAcl;
            return this;
        }
        public String getObjectAcl() {
            return this.objectAcl;
        }

        public PutObjectRequestHeader setStorageClass(String storageClass) {
            this.storageClass = storageClass;
            return this;
        }
        public String getStorageClass() {
            return this.storageClass;
        }

        public PutObjectRequestHeader setTagging(String tagging) {
            this.tagging = tagging;
            return this;
        }
        public String getTagging() {
            return this.tagging;
        }

        public PutObjectRequestHeader setContentType(String contentType) {
            this.contentType = contentType;
            return this;
        }
        public String getContentType() {
            return this.contentType;
        }

    }

}
