// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class PutBucketResponse extends TeaModel {
    @NameInMap("x-oss-request-id")
    @Validation(required = true)
    public String requestId;

    public static PutBucketResponse build(java.util.Map<String, ?> map) throws Exception {
        PutBucketResponse self = new PutBucketResponse();
        return TeaModel.build(map, self);
    }

}
