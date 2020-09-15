// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class GetBucketWebsiteRequest extends TeaModel {
    // BucketName
    @NameInMap("BucketName")
    @Validation(required = true)
    public String bucketName;

    public static GetBucketWebsiteRequest build(java.util.Map<String, ?> map) {
        GetBucketWebsiteRequest self = new GetBucketWebsiteRequest();
        return TeaModel.build(map, self);
    }

    public GetBucketWebsiteRequest setBucketName(String bucketName) {
        this.bucketName = bucketName;
        return this;
    }
    public String getBucketName() {
        return this.bucketName;
    }

}
