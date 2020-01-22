// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class PutBucketRefererResponse extends TeaModel {
    @NameInMap("x-oss-request-id")
    @Validation(required = true)
    public String requestId;

    public static PutBucketRefererResponse build(java.util.Map<String, ?> map) throws Exception {
        PutBucketRefererResponse self = new PutBucketRefererResponse();
        return TeaModel.build(map, self);
    }

}
