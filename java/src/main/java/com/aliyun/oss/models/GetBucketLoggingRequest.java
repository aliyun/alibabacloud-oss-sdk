// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class GetBucketLoggingRequest extends TeaModel {
    // BucketName
    @NameInMap("BucketName")
    @Validation(required = true)
    public String bucketName;

    public static GetBucketLoggingRequest build(java.util.Map<String, ?> map) {
        GetBucketLoggingRequest self = new GetBucketLoggingRequest();
        return TeaModel.build(map, self);
    }

    public GetBucketLoggingRequest setBucketName(String bucketName) {
        this.bucketName = bucketName;
        return this;
    }
    public String getBucketName() {
        return this.bucketName;
    }

}
