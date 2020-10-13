// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class GetBucketLocationRequest extends TeaModel {
    // BucketName
    @NameInMap("BucketName")
    @Validation(required = true, pattern = "[a-zA-Z0-9\\-\\_]+")
    public String bucketName;

    public static GetBucketLocationRequest build(java.util.Map<String, ?> map) throws Exception {
        GetBucketLocationRequest self = new GetBucketLocationRequest();
        return TeaModel.build(map, self);
    }

    public GetBucketLocationRequest setBucketName(String bucketName) {
        this.bucketName = bucketName;
        return this;
    }
    public String getBucketName() {
        return this.bucketName;
    }

}
