// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class DeleteObjectResponse extends TeaModel {
    @NameInMap("x-oss-request-id")
    @Validation(required = true)
    public String requestId;

    public static DeleteObjectResponse build(java.util.Map<String, ?> map) throws Exception {
        DeleteObjectResponse self = new DeleteObjectResponse();
        return TeaModel.build(map, self);
    }

}
