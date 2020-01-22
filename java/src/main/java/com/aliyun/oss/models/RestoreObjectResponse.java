// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class RestoreObjectResponse extends TeaModel {
    @NameInMap("x-oss-request-id")
    @Validation(required = true)
    public String requestId;

    public static RestoreObjectResponse build(java.util.Map<String, ?> map) throws Exception {
        RestoreObjectResponse self = new RestoreObjectResponse();
        return TeaModel.build(map, self);
    }

}
