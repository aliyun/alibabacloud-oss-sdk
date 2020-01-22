// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class PutBucketRequestPaymentResponse extends TeaModel {
    @NameInMap("x-oss-request-id")
    @Validation(required = true)
    public String requestId;

    public static PutBucketRequestPaymentResponse build(java.util.Map<String, ?> map) throws Exception {
        PutBucketRequestPaymentResponse self = new PutBucketRequestPaymentResponse();
        return TeaModel.build(map, self);
    }

}
