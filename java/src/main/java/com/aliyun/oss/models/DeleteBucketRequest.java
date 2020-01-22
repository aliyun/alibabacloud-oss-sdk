// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class DeleteBucketRequest extends TeaModel {
    @NameInMap("BucketName")
    @Validation(required = true)
    public String bucketName;

    public static DeleteBucketRequest build(java.util.Map<String, ?> map) throws Exception {
        DeleteBucketRequest self = new DeleteBucketRequest();
        return TeaModel.build(map, self);
    }

}
