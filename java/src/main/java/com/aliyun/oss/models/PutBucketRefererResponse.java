// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class PutBucketRefererResponse extends TeaModel {
    // x-oss-request-id
    @NameInMap("x-oss-request-id")
    @Validation(required = true)
    public String requestId;

    public static PutBucketRefererResponse build(java.util.Map<String, ?> map) throws Exception {
        PutBucketRefererResponse self = new PutBucketRefererResponse();
        return TeaModel.build(map, self);
    }

    public PutBucketRefererResponse setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

}
