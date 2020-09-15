// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class GetBucketLocationResponse extends TeaModel {
    // x-oss-request-id
    @NameInMap("x-oss-request-id")
    @Validation(required = true)
    public String requestId;

    // LocationConstraint
    @NameInMap("LocationConstraint")
    @Validation(required = true)
    public String locationConstraint;

    public static GetBucketLocationResponse build(java.util.Map<String, ?> map) {
        GetBucketLocationResponse self = new GetBucketLocationResponse();
        return TeaModel.build(map, self);
    }

    public GetBucketLocationResponse setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public GetBucketLocationResponse setLocationConstraint(String locationConstraint) {
        this.locationConstraint = locationConstraint;
        return this;
    }
    public String getLocationConstraint() {
        return this.locationConstraint;
    }

}
