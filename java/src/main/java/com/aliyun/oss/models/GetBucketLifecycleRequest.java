// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class GetBucketLifecycleRequest extends TeaModel {
    @NameInMap("BucketName")
    @Validation(required = true)
    public String bucketName;

    public static GetBucketLifecycleRequest build(java.util.Map<String, ?> map) throws Exception {
        GetBucketLifecycleRequest self = new GetBucketLifecycleRequest();
        return TeaModel.build(map, self);
    }

}
