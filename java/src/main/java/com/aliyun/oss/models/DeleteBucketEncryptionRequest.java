// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class DeleteBucketEncryptionRequest extends TeaModel {
    // BucketName
    @NameInMap("BucketName")
    @Validation(required = true, pattern = "[a-zA-Z0-9-_]+")
    public String bucketName;

    public static DeleteBucketEncryptionRequest build(java.util.Map<String, ?> map) throws Exception {
        DeleteBucketEncryptionRequest self = new DeleteBucketEncryptionRequest();
        return TeaModel.build(map, self);
    }

    public DeleteBucketEncryptionRequest setBucketName(String bucketName) {
        this.bucketName = bucketName;
        return this;
    }
    public String getBucketName() {
        return this.bucketName;
    }

}
