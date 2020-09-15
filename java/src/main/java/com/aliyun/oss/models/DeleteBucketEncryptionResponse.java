// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class DeleteBucketEncryptionResponse extends TeaModel {
    // x-oss-request-id
    @NameInMap("x-oss-request-id")
    @Validation(required = true)
    public String requestId;

    public static DeleteBucketEncryptionResponse build(java.util.Map<String, ?> map) {
        DeleteBucketEncryptionResponse self = new DeleteBucketEncryptionResponse();
        return TeaModel.build(map, self);
    }

    public DeleteBucketEncryptionResponse setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

}
