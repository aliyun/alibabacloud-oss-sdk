// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class PutBucketAclRequest extends TeaModel {
    // BucketName
    @NameInMap("BucketName")
    @Validation(required = true, pattern = "[a-zA-Z0-9\\-\\_]+")
    public String bucketName;

    // Header
    @NameInMap("Header")
    @Validation(required = true)
    public PutBucketAclRequestHeader header;

    public static PutBucketAclRequest build(java.util.Map<String, ?> map) throws Exception {
        PutBucketAclRequest self = new PutBucketAclRequest();
        return TeaModel.build(map, self);
    }

    public PutBucketAclRequest setBucketName(String bucketName) {
        this.bucketName = bucketName;
        return this;
    }
    public String getBucketName() {
        return this.bucketName;
    }

    public PutBucketAclRequest setHeader(PutBucketAclRequestHeader header) {
        this.header = header;
        return this;
    }
    public PutBucketAclRequestHeader getHeader() {
        return this.header;
    }

    public static class PutBucketAclRequestHeader extends TeaModel {
        // x-oss-acl
        @NameInMap("x-oss-acl")
        @Validation(required = true)
        public String acl;

        public static PutBucketAclRequestHeader build(java.util.Map<String, ?> map) throws Exception {
            PutBucketAclRequestHeader self = new PutBucketAclRequestHeader();
            return TeaModel.build(map, self);
        }

        public PutBucketAclRequestHeader setAcl(String acl) {
            this.acl = acl;
            return this;
        }
        public String getAcl() {
            return this.acl;
        }

    }

}
