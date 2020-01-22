// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class DeleteBucketResponse extends TeaModel {
    @NameInMap("x-oss-request-id")
    @Validation(required = true)
    public String requestId;

    public static DeleteBucketResponse build(java.util.Map<String, ?> map) throws Exception {
        DeleteBucketResponse self = new DeleteBucketResponse();
        return TeaModel.build(map, self);
    }

}
