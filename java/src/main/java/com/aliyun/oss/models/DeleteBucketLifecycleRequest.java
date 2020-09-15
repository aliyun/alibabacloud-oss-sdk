// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class DeleteBucketLifecycleRequest extends TeaModel {
    // BucketName
    @NameInMap("BucketName")
    @Validation(required = true)
    public String bucketName;

    public static DeleteBucketLifecycleRequest build(java.util.Map<String, ?> map) {
        DeleteBucketLifecycleRequest self = new DeleteBucketLifecycleRequest();
        return TeaModel.build(map, self);
    }

    public DeleteBucketLifecycleRequest setBucketName(String bucketName) {
        this.bucketName = bucketName;
        return this;
    }
    public String getBucketName() {
        return this.bucketName;
    }

}
