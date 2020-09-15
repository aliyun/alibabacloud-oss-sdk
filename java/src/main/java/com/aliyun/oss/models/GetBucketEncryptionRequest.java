// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class GetBucketEncryptionRequest extends TeaModel {
    // BucketName
    @NameInMap("BucketName")
    @Validation(required = true)
    public String bucketName;

    public static GetBucketEncryptionRequest build(java.util.Map<String, ?> map) {
        GetBucketEncryptionRequest self = new GetBucketEncryptionRequest();
        return TeaModel.build(map, self);
    }

    public GetBucketEncryptionRequest setBucketName(String bucketName) {
        this.bucketName = bucketName;
        return this;
    }
    public String getBucketName() {
        return this.bucketName;
    }

}
