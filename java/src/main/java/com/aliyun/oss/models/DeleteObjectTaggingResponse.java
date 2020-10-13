// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class DeleteObjectTaggingResponse extends TeaModel {
    // x-oss-request-id
    @NameInMap("x-oss-request-id")
    @Validation(required = true)
    public String requestId;

    public static DeleteObjectTaggingResponse build(java.util.Map<String, ?> map) throws Exception {
        DeleteObjectTaggingResponse self = new DeleteObjectTaggingResponse();
        return TeaModel.build(map, self);
    }

    public DeleteObjectTaggingResponse setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

}
