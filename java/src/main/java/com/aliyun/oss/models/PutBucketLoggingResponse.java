// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class PutBucketLoggingResponse extends TeaModel {
    @NameInMap("x-oss-request-id")
    @Validation(required = true)
    public String requestId;

    public static PutBucketLoggingResponse build(java.util.Map<String, ?> map) throws Exception {
        PutBucketLoggingResponse self = new PutBucketLoggingResponse();
        return TeaModel.build(map, self);
    }

}
