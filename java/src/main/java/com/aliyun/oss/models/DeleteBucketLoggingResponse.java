// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class DeleteBucketLoggingResponse extends TeaModel {
    // x-oss-request-id
    @NameInMap("x-oss-request-id")
    @Validation(required = true)
    public String requestId;

    public static DeleteBucketLoggingResponse build(java.util.Map<String, ?> map) {
        DeleteBucketLoggingResponse self = new DeleteBucketLoggingResponse();
        return TeaModel.build(map, self);
    }

    public DeleteBucketLoggingResponse setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

}
