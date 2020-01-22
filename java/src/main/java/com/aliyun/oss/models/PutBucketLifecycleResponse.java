// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class PutBucketLifecycleResponse extends TeaModel {
    @NameInMap("x-oss-request-id")
    @Validation(required = true)
    public String requestId;

    public static PutBucketLifecycleResponse build(java.util.Map<String, ?> map) throws Exception {
        PutBucketLifecycleResponse self = new PutBucketLifecycleResponse();
        return TeaModel.build(map, self);
    }

}
