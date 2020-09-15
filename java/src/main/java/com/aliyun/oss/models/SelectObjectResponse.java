// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class SelectObjectResponse extends TeaModel {
    // x-oss-request-id
    @NameInMap("x-oss-request-id")
    @Validation(required = true)
    public String requestId;

    public static SelectObjectResponse build(java.util.Map<String, ?> map) {
        SelectObjectResponse self = new SelectObjectResponse();
        return TeaModel.build(map, self);
    }

    public SelectObjectResponse setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

}
