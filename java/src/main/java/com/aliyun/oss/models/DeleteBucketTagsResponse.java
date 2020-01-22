// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class DeleteBucketTagsResponse extends TeaModel {
    @NameInMap("x-oss-request-id")
    @Validation(required = true)
    public String requestId;

    public static DeleteBucketTagsResponse build(java.util.Map<String, ?> map) throws Exception {
        DeleteBucketTagsResponse self = new DeleteBucketTagsResponse();
        return TeaModel.build(map, self);
    }

}
