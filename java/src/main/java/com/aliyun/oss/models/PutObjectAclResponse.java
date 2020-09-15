// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class PutObjectAclResponse extends TeaModel {
    // x-oss-request-id
    @NameInMap("x-oss-request-id")
    @Validation(required = true)
    public String requestId;

    public static PutObjectAclResponse build(java.util.Map<String, ?> map) {
        PutObjectAclResponse self = new PutObjectAclResponse();
        return TeaModel.build(map, self);
    }

    public PutObjectAclResponse setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

}
