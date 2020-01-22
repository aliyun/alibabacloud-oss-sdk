// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class DeleteObjectRequest extends TeaModel {
    @NameInMap("BucketName")
    @Validation(required = true)
    public String bucketName;

    @NameInMap("ObjectName")
    @Validation(required = true)
    public String objectName;

    public static DeleteObjectRequest build(java.util.Map<String, ?> map) throws Exception {
        DeleteObjectRequest self = new DeleteObjectRequest();
        return TeaModel.build(map, self);
    }

}
