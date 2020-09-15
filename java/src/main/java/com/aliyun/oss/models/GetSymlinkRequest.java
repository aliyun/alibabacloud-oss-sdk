// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class GetSymlinkRequest extends TeaModel {
    // BucketName
    @NameInMap("BucketName")
    @Validation(required = true)
    public String bucketName;

    // ObjectName
    @NameInMap("ObjectName")
    @Validation(required = true)
    public String objectName;

    public static GetSymlinkRequest build(java.util.Map<String, ?> map) {
        GetSymlinkRequest self = new GetSymlinkRequest();
        return TeaModel.build(map, self);
    }

    public GetSymlinkRequest setBucketName(String bucketName) {
        this.bucketName = bucketName;
        return this;
    }
    public String getBucketName() {
        return this.bucketName;
    }

    public GetSymlinkRequest setObjectName(String objectName) {
        this.objectName = objectName;
        return this;
    }
    public String getObjectName() {
        return this.objectName;
    }

}
