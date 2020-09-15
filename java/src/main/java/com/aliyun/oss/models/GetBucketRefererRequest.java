// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class GetBucketRefererRequest extends TeaModel {
    // BucketName
    @NameInMap("BucketName")
    @Validation(required = true)
    public String bucketName;

    public static GetBucketRefererRequest build(java.util.Map<String, ?> map) {
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
