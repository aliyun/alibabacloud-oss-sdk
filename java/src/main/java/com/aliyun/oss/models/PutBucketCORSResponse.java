// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class PutBucketCORSResponse extends TeaModel {
    @NameInMap("x-oss-request-id")
    @Validation(required = true)
    public String requestId;

    public static PutBucketCORSResponse build(java.util.Map<String, ?> map) throws Exception {
        PutBucketCORSResponse self = new PutBucketCORSResponse();
        return TeaModel.build(map, self);
    }

}
