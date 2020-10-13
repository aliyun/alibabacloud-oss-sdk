// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class PutBucketLoggingResponse extends TeaModel {
    // x-oss-request-id
    @NameInMap("x-oss-request-id")
    @Validation(required = true)
    public String requestId;

    public static PutBucketLoggingResponse build(java.util.Map<String, ?> map) throws Exception {
        PutBucketLoggingResponse self = new PutBucketLoggingResponse();
        return TeaModel.build(map, self);
    }

    public PutBucketLoggingResponse setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

}
