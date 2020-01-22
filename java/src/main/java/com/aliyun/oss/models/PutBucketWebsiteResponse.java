// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class PutBucketWebsiteResponse extends TeaModel {
    @NameInMap("x-oss-request-id")
    @Validation(required = true)
    public String requestId;

    public static PutBucketWebsiteResponse build(java.util.Map<String, ?> map) throws Exception {
        PutBucketWebsiteResponse self = new PutBucketWebsiteResponse();
        return TeaModel.build(map, self);
    }

}
