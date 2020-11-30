// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class PutBucketRequest extends TeaModel {
    // BucketName
    @NameInMap("BucketName")
    @Validation(required = true, pattern = "[a-zA-Z0-9-_]+")
    public String bucketName;

    // Body
    @NameInMap("Body")
    public PutBucketRequestBody body;

    // Header
    @NameInMap("Header")
    public PutBucketRequestHeader header;

    public static PutBucketRequest build(java.util.Map<String, ?> map) throws Exception {
        PutBucketRequest self = new PutBucketRequest();
        return TeaModel.build(map, self);
    }

    public PutBucketRequest setBucketName(String bucketName) {
        this.bucketName = bucketName;
        return this;
    }
    public String getBucketName() {
        return this.bucketName;
    }

    public PutBucketRequest setBody(PutBucketRequestBody body) {
        this.body = body;
        return this;
    }
    public PutBucketRequestBody getBody() {
        return this.body;
    }

    public PutBucketRequest setHeader(PutBucketRequestHeader header) {
        this.header = header;
        return this;
    }
    public PutBucketRequestHeader getHeader() {
        return this.header;
    }

    public static class PutBucketRequestBodyCreateBucketConfiguration extends TeaModel {
        // StorageClass
        @NameInMap("StorageClass")
        public String storageClass;

        // DataRedundancyType
        @NameInMap("DataRedundancyType")
        public String dataRedundancyType;

        public static PutBucketRequestBodyCreateBucketConfiguration build(java.util.Map<String, ?> map) throws Exception {
            PutBucketRequestBodyCreateBucketConfiguration self = new PutBucketRequestBodyCreateBucketConfiguration();
            return TeaModel.build(map, self);
        }

        public PutBucketRequestBodyCreateBucketConfiguration setStorageClass(String storageClass) {
            this.storageClass = storageClass;
            return this;
        }
        public String getStorageClass() {
            return this.storageClass;
        }

        public PutBucketRequestBodyCreateBucketConfiguration setDataRedundancyType(String dataRedundancyType) {
            this.dataRedundancyType = dataRedundancyType;
            return this;
        }
        public String getDataRedundancyType() {
            return this.dataRedundancyType;
        }

    }

    public static class PutBucketRequestBody extends TeaModel {
        // CreateBucketConfiguration
        @NameInMap("CreateBucketConfiguration")
        @Validation(required = true)
        public PutBucketRequestBodyCreateBucketConfiguration createBucketConfiguration;

        public static PutBucketRequestBody build(java.util.Map<String, ?> map) throws Exception {
            PutBucketRequestBody self = new PutBucketRequestBody();
            return TeaModel.build(map, self);
        }

        public PutBucketRequestBody setCreateBucketConfiguration(PutBucketRequestBodyCreateBucketConfiguration createBucketConfiguration) {
            this.createBucketConfiguration = createBucketConfiguration;
            return this;
        }
        public PutBucketRequestBodyCreateBucketConfiguration getCreateBucketConfiguration() {
            return this.createBucketConfiguration;
        }

    }

    public static class PutBucketRequestHeader extends TeaModel {
        // x-oss-acl
        @NameInMap("x-oss-acl")
        public String acl;

        public static PutBucketRequestHeader build(java.util.Map<String, ?> map) throws Exception {
            PutBucketRequestHeader self = new PutBucketRequestHeader();
            return TeaModel.build(map, self);
        }

        public PutBucketRequestHeader setAcl(String acl) {
            this.acl = acl;
            return this;
        }
        public String getAcl() {
            return this.acl;
        }

    }

}
