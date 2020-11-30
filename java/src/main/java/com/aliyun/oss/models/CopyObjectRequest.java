// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class CopyObjectRequest extends TeaModel {
    // BucketName
    @NameInMap("BucketName")
    @Validation(required = true, pattern = "[a-zA-Z0-9-_]+")
    public String bucketName;

    // DestObjectName
    @NameInMap("DestObjectName")
    @Validation(required = true)
    public String destObjectName;

    // Header
    @NameInMap("Header")
    @Validation(required = true)
    public CopyObjectRequestHeader header;

    public static CopyObjectRequest build(java.util.Map<String, ?> map) throws Exception {
        CopyObjectRequest self = new CopyObjectRequest();
        return TeaModel.build(map, self);
    }

    public CopyObjectRequest setBucketName(String bucketName) {
        this.bucketName = bucketName;
        return this;
    }
    public String getBucketName() {
        return this.bucketName;
    }

    public CopyObjectRequest setDestObjectName(String destObjectName) {
        this.destObjectName = destObjectName;
        return this;
    }
    public String getDestObjectName() {
        return this.destObjectName;
    }

    public CopyObjectRequest setHeader(CopyObjectRequestHeader header) {
        this.header = header;
        return this;
    }
    public CopyObjectRequestHeader getHeader() {
        return this.header;
    }

    public static class CopyObjectRequestHeader extends TeaModel {
        // x-oss-copy-source
        @NameInMap("x-oss-copy-source")
        @Validation(required = true)
        public String copySource;

        // x-oss-copy-source-if-match
        @NameInMap("x-oss-copy-source-if-match")
        public String copySourceIfMatch;

        // x-oss-copy-source-if-none-match
        @NameInMap("x-oss-copy-source-if-none-match")
        public String copySourceIfNoneMatch;

        // x-oss-copy-source-if-unmodified-since
        @NameInMap("x-oss-copy-source-if-unmodified-since")
        public String copySourceIfUnmodifiedSince;

        // x-oss-copy-source-if-modified-since
        @NameInMap("x-oss-copy-source-if-modified-since")
        public String copySourceIfModifiedSince;

        // x-oss-metadata-directive
        @NameInMap("x-oss-metadata-directive")
        public String metadataDirective;

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

        // x-oss-tagging-directive
        @NameInMap("x-oss-tagging-directive")
        public String taggingDirective;

        public static CopyObjectRequestHeader build(java.util.Map<String, ?> map) throws Exception {
            CopyObjectRequestHeader self = new CopyObjectRequestHeader();
            return TeaModel.build(map, self);
        }

        public CopyObjectRequestHeader setCopySource(String copySource) {
            this.copySource = copySource;
            return this;
        }
        public String getCopySource() {
            return this.copySource;
        }

        public CopyObjectRequestHeader setCopySourceIfMatch(String copySourceIfMatch) {
            this.copySourceIfMatch = copySourceIfMatch;
            return this;
        }
        public String getCopySourceIfMatch() {
            return this.copySourceIfMatch;
        }

        public CopyObjectRequestHeader setCopySourceIfNoneMatch(String copySourceIfNoneMatch) {
            this.copySourceIfNoneMatch = copySourceIfNoneMatch;
            return this;
        }
        public String getCopySourceIfNoneMatch() {
            return this.copySourceIfNoneMatch;
        }

        public CopyObjectRequestHeader setCopySourceIfUnmodifiedSince(String copySourceIfUnmodifiedSince) {
            this.copySourceIfUnmodifiedSince = copySourceIfUnmodifiedSince;
            return this;
        }
        public String getCopySourceIfUnmodifiedSince() {
            return this.copySourceIfUnmodifiedSince;
        }

        public CopyObjectRequestHeader setCopySourceIfModifiedSince(String copySourceIfModifiedSince) {
            this.copySourceIfModifiedSince = copySourceIfModifiedSince;
            return this;
        }
        public String getCopySourceIfModifiedSince() {
            return this.copySourceIfModifiedSince;
        }

        public CopyObjectRequestHeader setMetadataDirective(String metadataDirective) {
            this.metadataDirective = metadataDirective;
            return this;
        }
        public String getMetadataDirective() {
            return this.metadataDirective;
        }

        public CopyObjectRequestHeader setServerSideEncryption(String serverSideEncryption) {
            this.serverSideEncryption = serverSideEncryption;
            return this;
        }
        public String getServerSideEncryption() {
            return this.serverSideEncryption;
        }

        public CopyObjectRequestHeader setServerSideEncryptionKeyId(String serverSideEncryptionKeyId) {
            this.serverSideEncryptionKeyId = serverSideEncryptionKeyId;
            return this;
        }
        public String getServerSideEncryptionKeyId() {
            return this.serverSideEncryptionKeyId;
        }

        public CopyObjectRequestHeader setObjectAcl(String objectAcl) {
            this.objectAcl = objectAcl;
            return this;
        }
        public String getObjectAcl() {
            return this.objectAcl;
        }

        public CopyObjectRequestHeader setStorageClass(String storageClass) {
            this.storageClass = storageClass;
            return this;
        }
        public String getStorageClass() {
            return this.storageClass;
        }

        public CopyObjectRequestHeader setTagging(String tagging) {
            this.tagging = tagging;
            return this;
        }
        public String getTagging() {
            return this.tagging;
        }

        public CopyObjectRequestHeader setTaggingDirective(String taggingDirective) {
            this.taggingDirective = taggingDirective;
            return this;
        }
        public String getTaggingDirective() {
            return this.taggingDirective;
        }

    }

}
