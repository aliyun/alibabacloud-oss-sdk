// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class AbortMultipartUploadResponse extends TeaModel {
    // x-oss-request-id
    @NameInMap("x-oss-request-id")
    @Validation(required = true)
    public String requestId;

    public static AbortMultipartUploadResponse build(java.util.Map<String, ?> map) {
        AbortMultipartUploadResponse self = new AbortMultipartUploadResponse();
        return TeaModel.build(map, self);
    }

    public AbortMultipartUploadResponse setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

}
