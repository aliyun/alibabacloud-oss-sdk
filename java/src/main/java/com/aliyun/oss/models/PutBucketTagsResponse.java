// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class PutBucketTagsResponse extends TeaModel {
    @NameInMap("x-oss-request-id")
    @Validation(required = true)
    public String requestId;

    public static PutBucketTagsResponse build(java.util.Map<String, ?> map) throws Exception {
        PutBucketTagsResponse self = new PutBucketTagsResponse();
        return TeaModel.build(map, self);
    }

}
