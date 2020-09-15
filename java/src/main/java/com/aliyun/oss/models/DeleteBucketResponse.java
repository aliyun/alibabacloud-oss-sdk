// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class DeleteBucketResponse extends TeaModel {
    // x-oss-request-id
    @NameInMap("x-oss-request-id")
    @Validation(required = true)
    public String requestId;

    public static DeleteBucketResponse build(java.util.Map<String, ?> map) {
        DeleteBucketResponse self = new DeleteBucketResponse();
        return TeaModel.build(map, self);
    }

    public DeleteBucketResponse setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

}
