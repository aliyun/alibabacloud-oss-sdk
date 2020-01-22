// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class CallbackResponse extends TeaModel {
    @NameInMap("x-oss-request-id")
    @Validation(required = true)
    public String requestId;

    public static CallbackResponse build(java.util.Map<String, ?> map) throws Exception {
        CallbackResponse self = new CallbackResponse();
        return TeaModel.build(map, self);
    }

}
