// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class GetBucketTagsRequest extends TeaModel {
    // BucketName
    @NameInMap("BucketName")
    @Validation(required = true, pattern = "[a-zA-Z0-9-_]+")
    public String bucketName;

    public static GetBucketTagsRequest build(java.util.Map<String, ?> map) throws Exception {
        GetBucketTagsRequest self = new GetBucketTagsRequest();
        return TeaModel.build(map, self);
    }

    public GetBucketTagsRequest setBucketName(String bucketName) {
        this.bucketName = bucketName;
        return this;
    }
    public String getBucketName() {
        return this.bucketName;
    }

}
