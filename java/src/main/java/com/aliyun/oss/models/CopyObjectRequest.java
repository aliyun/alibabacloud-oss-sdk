// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class CopyObjectRequest extends TeaModel {
    @NameInMap("BucketName")
    @Validation(required = true)
    public String bucketName;

    @NameInMap("DestObjectName")
    @Validation(required = true)
    public String destObjectName;

    @NameInMap("Header")
    @Validation(required = true)
    public CopyObjectRequestHeader header;

    public static CopyObjectRequest build(java.util.Map<String, ?> map) throws Exception {
        CopyObjectRequest self = new CopyObjectRequest();
        return TeaModel.build(map, self);
    }

    public static class CopyObjectRequestHeader extends TeaModel {
        @NameInMap("x-oss-copy-source")
        @Validation(required = true)
        public String copySource;

        @NameInMap("x-oss-copy-source-if-match")
        public String copySourceIfMatch;

        @NameInMap("x-oss-copy-source-if-none-match")
        public String copySourceIfNoneMatch;

        @NameInMap("x-oss-copy-source-if-unmodified-since")
        public String copySourceIfUnmodifiedSince;

        @NameInMap("x-oss-copy-source-if-modified-since")
        public String copySourceIfModifiedSince;

        @NameInMap("x-oss-metadata-directive")
        public String metadataDirective;

        @NameInMap("x-oss-server-side-encryption")
        public String serverSideEncryption;

        @NameInMap("x-oss-server-side-encryption-key-id")
        public String serverSideEncryptionKeyId;

        @NameInMap("x-oss-object-acl")
        public String objectAcl;

        @NameInMap("x-oss-storage-class")
        public String storageClass;

        @NameInMap("x-oss-tagging")
        public String tagging;

        @NameInMap("x-oss-tagging-directive")
        public String taggingDirective;

        public static CopyObjectRequestHeader build(java.util.Map<String, ?> map) throws Exception {
            CopyObjectRequestHeader self = new CopyObjectRequestHeader();
            return TeaModel.build(map, self);
        }

    }

}
