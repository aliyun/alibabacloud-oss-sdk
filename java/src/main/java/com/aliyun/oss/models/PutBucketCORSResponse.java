// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class PutBucketCORSResponse extends TeaModel {
    // x-oss-request-id
    @NameInMap("x-oss-request-id")
    @Validation(required = true)
    public String requestId;

    public static PutBucketCORSResponse build(java.util.Map<String, ?> map) throws Exception {
        PutBucketCORSResponse self = new PutBucketCORSResponse();
        return TeaModel.build(map, self);
    }

    public PutBucketCORSResponse setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

}
