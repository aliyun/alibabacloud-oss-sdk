// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class GetBucketRefererRequest extends TeaModel {
    @NameInMap("BucketName")
    @Validation(required = true)
    public String bucketName;

    public static GetBucketRefererRequest build(java.util.Map<String, ?> map) throws Exception {
        GetBucketRefererRequest self = new GetBucketRefererRequest();
        return TeaModel.build(map, self);
    }

}
