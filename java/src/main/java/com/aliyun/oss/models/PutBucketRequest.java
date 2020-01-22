// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class PutBucketRequest extends TeaModel {
    @NameInMap("BucketName")
    @Validation(required = true)
    public String bucketName;

    @NameInMap("Body")
    public PutBucketRequestBody body;

    @NameInMap("Header")
    public PutBucketRequestHeader header;

    public static PutBucketRequest build(java.util.Map<String, ?> map) throws Exception {
        PutBucketRequest self = new PutBucketRequest();
        return TeaModel.build(map, self);
    }

    public static class PutBucketRequestBodyCreateBucketConfiguration extends TeaModel {
        @NameInMap("StorageClass")
        public String storageClass;

        @NameInMap("DataRedundancyType")
        public String dataRedundancyType;

        public static PutBucketRequestBodyCreateBucketConfiguration build(java.util.Map<String, ?> map) throws Exception {
            PutBucketRequestBodyCreateBucketConfiguration self = new PutBucketRequestBodyCreateBucketConfiguration();
            return TeaModel.build(map, self);
        }

    }

    public static class PutBucketRequestBody extends TeaModel {
        @NameInMap("CreateBucketConfiguration")
        @Validation(required = true)
        public PutBucketRequestBodyCreateBucketConfiguration createBucketConfiguration;

        public static PutBucketRequestBody build(java.util.Map<String, ?> map) throws Exception {
            PutBucketRequestBody self = new PutBucketRequestBody();
            return TeaModel.build(map, self);
        }

    }

    public static class PutBucketRequestHeader extends TeaModel {
        @NameInMap("x-oss-acl")
        public String acl;

        public static PutBucketRequestHeader build(java.util.Map<String, ?> map) throws Exception {
            PutBucketRequestHeader self = new PutBucketRequestHeader();
            return TeaModel.build(map, self);
        }

    }

}
