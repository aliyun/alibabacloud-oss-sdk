// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class DeleteBucketLifecycleResponse extends TeaModel {
    @NameInMap("x-oss-request-id")
    @Validation(required = true)
    public String requestId;

    public static DeleteBucketLifecycleResponse build(java.util.Map<String, ?> map) throws Exception {
        DeleteBucketLifecycleResponse self = new DeleteBucketLifecycleResponse();
        return TeaModel.build(map, self);
    }

}
