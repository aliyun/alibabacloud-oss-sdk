// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class DeleteBucketLifecycleRequest extends TeaModel {
    @NameInMap("BucketName")
    @Validation(required = true)
    public String bucketName;

    public static DeleteBucketLifecycleRequest build(java.util.Map<String, ?> map) throws Exception {
        DeleteBucketLifecycleRequest self = new DeleteBucketLifecycleRequest();
        return TeaModel.build(map, self);
    }

}
