// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class GetBucketRefererRequest extends TeaModel {
    // BucketName
    @NameInMap("BucketName")
    @Validation(required = true, pattern = "[a-zA-Z0-9-_]+")
    public String bucketName;

    public static GetBucketRefererRequest build(java.util.Map<String, ?> map) throws Exception {
        GetBucketRefererRequest self = new GetBucketRefererRequest();
        return TeaModel.build(map, self);
    }

    public GetBucketRefererRequest setBucketName(String bucketName) {
        this.bucketName = bucketName;
        return this;
    }
    public String getBucketName() {
        return this.bucketName;
    }

}
