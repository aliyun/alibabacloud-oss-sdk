// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class HeadObjectResponse extends TeaModel {
    // x-oss-request-id
    @NameInMap("x-oss-request-id")
    @Validation(required = true)
    public String requestId;

    // usermeta
    @NameInMap("usermeta")
    @Validation(required = true)
    public java.util.Map<String, String> userMeta;

    // x-oss-server-side-encryption
    @NameInMap("x-oss-server-side-encryption")
    @Validation(required = true)
    public String serverSideEncryption;

    // x-oss-server-side-encryption-key-id
    @NameInMap("x-oss-server-side-encryption-key-id")
    @Validation(required = true)
    public String serverSideEncryptionKeyId;

    // x-oss-storage-class
    @NameInMap("x-oss-storage-class")
    @Validation(required = true)
    public String storageClass;

    // x-oss-object-type
    @NameInMap("x-oss-object-type")
    @Validation(required = true)
    public String objectType;

    // x-oss-next-append-position
    @NameInMap("x-oss-next-append-position")
    @Validation(required = true)
    public String nextAppendPosition;

    // x-oss-hash-crc64ecma
    @NameInMap("x-oss-hash-crc64ecma")
    @Validation(required = true)
    public String hashCrc64ecma;

    // x-oss-expiration
    @NameInMap("x-oss-expiration")
    @Validation(required = true)
    public String expiration;

    // x-oss-restore
    @NameInMap("x-oss-restore")
    @Validation(required = true)
    public String restore;

    // x-oss-process-status
    @NameInMap("x-oss-process-status")
    @Validation(required = true)
    public String processStatus;

    // x-oss-request-charged
    @NameInMap("x-oss-request-charged")
    @Validation(required = true)
    public String requestCharged;

    // Content-Md5
    @NameInMap("content-md5")
    @Validation(required = true)
    public String contentMd5;

    // Last-Modified
    @NameInMap("last-modified")
    @Validation(required = true)
    public String lastModified;

    // Access-Control-Allow-Origin
    @NameInMap("access-control-allow-origin")
    @Validation(required = true)
    public String accessControlAllowOrigin;

    // Access-Control-Allow-Methods
    @NameInMap("access-control-allow-methods")
    @Validation(required = true)
    public String accessControlAllowMethods;

    // Access-Control-Max-Age
    @NameInMap("access-control-max-age")
    @Validation(required = true)
    public String accessControlMaxAge;

    // Access-Control-Allow-Headers
    @NameInMap("access-control-allow-headers")
    @Validation(required = true)
    public String accessControlAllowHeaders;

    // Access-Control-Expose-Headers
    @NameInMap("access-control-expose-headers")
    @Validation(required = true)
    public String accessControlExposeHeaders;

    // x-oss-tagging-count
    @NameInMap("x-oss-tagging-count")
    @Validation(required = true)
    public String taggingCount;

    public static HeadObjectResponse build(java.util.Map<String, ?> map) throws Exception {
        HeadObjectResponse self = new HeadObjectResponse();
        return TeaModel.build(map, self);
    }

    public HeadObjectResponse setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public HeadObjectResponse setUserMeta(java.util.Map<String, String> userMeta) {
        this.userMeta = userMeta;
        return this;
    }
    public java.util.Map<String, String> getUserMeta() {
        return this.userMeta;
    }

    public HeadObjectResponse setServerSideEncryption(String serverSideEncryption) {
        this.serverSideEncryption = serverSideEncryption;
        return this;
    }
    public String getServerSideEncryption() {
        return this.serverSideEncryption;
    }

    public HeadObjectResponse setServerSideEncryptionKeyId(String serverSideEncryptionKeyId) {
        this.serverSideEncryptionKeyId = serverSideEncryptionKeyId;
        return this;
    }
    public String getServerSideEncryptionKeyId() {
        return this.serverSideEncryptionKeyId;
    }

    public HeadObjectResponse setStorageClass(String storageClass) {
        this.storageClass = storageClass;
        return this;
    }
    public String getStorageClass() {
        return this.storageClass;
    }

    public HeadObjectResponse setObjectType(String objectType) {
        this.objectType = objectType;
        return this;
    }
    public String getObjectType() {
        return this.objectType;
    }

    public HeadObjectResponse setNextAppendPosition(String nextAppendPosition) {
        this.nextAppendPosition = nextAppendPosition;
        return this;
    }
    public String getNextAppendPosition() {
        return this.nextAppendPosition;
    }

    public HeadObjectResponse setHashCrc64ecma(String hashCrc64ecma) {
        this.hashCrc64ecma = hashCrc64ecma;
        return this;
    }
    public String getHashCrc64ecma() {
        return this.hashCrc64ecma;
    }

    public HeadObjectResponse setExpiration(String expiration) {
        this.expiration = expiration;
        return this;
    }
    public String getExpiration() {
        return this.expiration;
    }

    public HeadObjectResponse setRestore(String restore) {
        this.restore = restore;
        return this;
    }
    public String getRestore() {
        return this.restore;
    }

    public HeadObjectResponse setProcessStatus(String processStatus) {
        this.processStatus = processStatus;
        return this;
    }
    public String getProcessStatus() {
        return this.processStatus;
    }

    public HeadObjectResponse setRequestCharged(String requestCharged) {
        this.requestCharged = requestCharged;
        return this;
    }
    public String getRequestCharged() {
        return this.requestCharged;
    }

    public HeadObjectResponse setContentMd5(String contentMd5) {
        this.contentMd5 = contentMd5;
        return this;
    }
    public String getContentMd5() {
        return this.contentMd5;
    }

    public HeadObjectResponse setLastModified(String lastModified) {
        this.lastModified = lastModified;
        return this;
    }
    public String getLastModified() {
        return this.lastModified;
    }

    public HeadObjectResponse setAccessControlAllowOrigin(String accessControlAllowOrigin) {
        this.accessControlAllowOrigin = accessControlAllowOrigin;
        return this;
    }
    public String getAccessControlAllowOrigin() {
        return this.accessControlAllowOrigin;
    }

    public HeadObjectResponse setAccessControlAllowMethods(String accessControlAllowMethods) {
        this.accessControlAllowMethods = accessControlAllowMethods;
        return this;
    }
    public String getAccessControlAllowMethods() {
        return this.accessControlAllowMethods;
    }

    public HeadObjectResponse setAccessControlMaxAge(String accessControlMaxAge) {
        this.accessControlMaxAge = accessControlMaxAge;
        return this;
    }
    public String getAccessControlMaxAge() {
        return this.accessControlMaxAge;
    }

    public HeadObjectResponse setAccessControlAllowHeaders(String accessControlAllowHeaders) {
        this.accessControlAllowHeaders = accessControlAllowHeaders;
        return this;
    }
    public String getAccessControlAllowHeaders() {
        return this.accessControlAllowHeaders;
    }

    public HeadObjectResponse setAccessControlExposeHeaders(String accessControlExposeHeaders) {
        this.accessControlExposeHeaders = accessControlExposeHeaders;
        return this;
    }
    public String getAccessControlExposeHeaders() {
        return this.accessControlExposeHeaders;
    }

    public HeadObjectResponse setTaggingCount(String taggingCount) {
        this.taggingCount = taggingCount;
        return this;
    }
    public String getTaggingCount() {
        return this.taggingCount;
    }

}
