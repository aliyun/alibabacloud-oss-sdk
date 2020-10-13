// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class DeleteBucketWebsiteResponse extends TeaModel {
    // x-oss-request-id
    @NameInMap("x-oss-request-id")
    @Validation(required = true)
    public String requestId;

    public static DeleteBucketWebsiteResponse build(java.util.Map<String, ?> map) throws Exception {
        DeleteBucketWebsiteResponse self = new DeleteBucketWebsiteResponse();
        return TeaModel.build(map, self);
    }

    public DeleteBucketWebsiteResponse setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

}
