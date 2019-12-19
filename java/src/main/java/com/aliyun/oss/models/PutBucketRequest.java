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

    public static class PutBucketRequestBodyCreateBucketConfiguration extends TeaModel {
        @NameInMap("StorageClass")
        public String storageClass;

        @NameInMap("DataRedundancyType")
        public String dataRedundancyType;

    }

    public static class PutBucketRequestBody extends TeaModel {
        @NameInMap("CreateBucketConfiguration")
        @Validation(required = true)
        public PutBucketRequestBodyCreateBucketConfiguration createBucketConfiguration;

    }

    public static class PutBucketRequestHeader extends TeaModel {
        @NameInMap("x-oss-acl")
        public String acl;

    }

}
