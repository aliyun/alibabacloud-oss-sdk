// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class GetBucketLocationResponse extends TeaModel {
    @NameInMap("x-oss-request-id")
    @Validation(required = true)
    public String requestId;

    @NameInMap("LocationConstraint")
    @Validation(required = true)
    public String locationConstraint;

    public static GetBucketLocationResponse build(java.util.Map<String, ?> map) throws Exception {
        GetBucketLocationResponse self = new GetBucketLocationResponse();
        return TeaModel.build(map, self);
    }

}
