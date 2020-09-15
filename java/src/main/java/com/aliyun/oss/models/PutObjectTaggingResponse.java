// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class PutObjectTaggingResponse extends TeaModel {
    // x-oss-request-id
    @NameInMap("x-oss-request-id")
    @Validation(required = true)
    public String requestId;

    public static PutObjectTaggingResponse build(java.util.Map<String, ?> map) {
        PutObjectTaggingResponse self = new PutObjectTaggingResponse();
        return TeaModel.build(map, self);
    }

    public PutObjectTaggingResponse setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

}
