// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class PutObjectAclRequest extends TeaModel {
    // BucketName
    @NameInMap("BucketName")
    @Validation(required = true)
    public String bucketName;

    // ObjectName
    @NameInMap("ObjectName")
    @Validation(required = true)
    public String objectName;

    // Header
    @NameInMap("Header")
    @Validation(required = true)
    public PutObjectAclRequestHeader header;

    public static PutObjectAclRequest build(java.util.Map<String, ?> map) {
        PutObjectAclRequest self = new PutObjectAclRequest();
        return TeaModel.build(map, self);
    }

    public PutObjectAclRequest setBucketName(String bucketName) {
        this.bucketName = bucketName;
        return this;
    }
    public String getBucketName() {
        return this.bucketName;
    }

    public PutObjectAclRequest setObjectName(String objectName) {
        this.objectName = objectName;
        return this;
    }
    public String getObjectName() {
        return this.objectName;
    }

    public PutObjectAclRequest setHeader(PutObjectAclRequestHeader header) {
        this.header = header;
        return this;
    }
    public PutObjectAclRequestHeader getHeader() {
        return this.header;
    }

    public static class PutObjectAclRequestHeader extends TeaModel {
        // x-oss-object-acl
        @NameInMap("x-oss-object-acl")
        @Validation(required = true)
        public String objectAcl;

        public static PutObjectAclRequestHeader build(java.util.Map<String, ?> map) {
            PutObjectAclRequestHeader self = new PutObjectAclRequestHeader();
            return TeaModel.build(map, self);
        }

        public PutObjectAclRequestHeader setObjectAcl(String objectAcl) {
            this.objectAcl = objectAcl;
            return this;
        }
        public String getObjectAcl() {
            return this.objectAcl;
        }

    }

}
