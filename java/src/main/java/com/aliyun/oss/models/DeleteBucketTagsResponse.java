// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class DeleteBucketTagsResponse extends TeaModel {
    // x-oss-request-id
    @NameInMap("x-oss-request-id")
    @Validation(required = true)
    public String requestId;

    public static DeleteBucketTagsResponse build(java.util.Map<String, ?> map) throws Exception {
        DeleteBucketTagsResponse self = new DeleteBucketTagsResponse();
        return TeaModel.build(map, self);
    }

    public DeleteBucketTagsResponse setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

}
