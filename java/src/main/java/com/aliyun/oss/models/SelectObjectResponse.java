// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class SelectObjectResponse extends TeaModel {
    @NameInMap("x-oss-request-id")
    @Validation(required = true)
    public String requestId;

    public static SelectObjectResponse build(java.util.Map<String, ?> map) throws Exception {
        SelectObjectResponse self = new SelectObjectResponse();
        return TeaModel.build(map, self);
    }

}
