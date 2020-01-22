// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class DeleteBucketWebsiteResponse extends TeaModel {
    @NameInMap("x-oss-request-id")
    @Validation(required = true)
    public String requestId;

    public static DeleteBucketWebsiteResponse build(java.util.Map<String, ?> map) throws Exception {
        DeleteBucketWebsiteResponse self = new DeleteBucketWebsiteResponse();
        return TeaModel.build(map, self);
    }

}
