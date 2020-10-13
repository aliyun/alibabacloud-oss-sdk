// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class DeleteBucketLoggingRequest extends TeaModel {
    // BucketName
    @NameInMap("BucketName")
    @Validation(required = true, pattern = "[a-zA-Z0-9\\-\\_]+")
    public String bucketName;

    public static DeleteBucketLoggingRequest build(java.util.Map<String, ?> map) throws Exception {
        DeleteBucketLoggingRequest self = new DeleteBucketLoggingRequest();
        return TeaModel.build(map, self);
    }

    public DeleteBucketLoggingRequest setBucketName(String bucketName) {
        this.bucketName = bucketName;
        return this;
    }
    public String getBucketName() {
        return this.bucketName;
    }

}
