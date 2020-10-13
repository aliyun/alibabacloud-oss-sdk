// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class DeleteObjectRequest extends TeaModel {
    // BucketName
    @NameInMap("BucketName")
    @Validation(required = true, pattern = "[a-zA-Z0-9\\-\\_]+")
    public String bucketName;

    // ObjectName
    @NameInMap("ObjectName")
    @Validation(required = true)
    public String objectName;

    public static DeleteObjectRequest build(java.util.Map<String, ?> map) throws Exception {
        DeleteObjectRequest self = new DeleteObjectRequest();
        return TeaModel.build(map, self);
    }

    public DeleteObjectRequest setBucketName(String bucketName) {
        this.bucketName = bucketName;
        return this;
    }
    public String getBucketName() {
        return this.bucketName;
    }

    public DeleteObjectRequest setObjectName(String objectName) {
        this.objectName = objectName;
        return this;
    }
    public String getObjectName() {
        return this.objectName;
    }

}
