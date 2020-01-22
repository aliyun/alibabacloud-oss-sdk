// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class PutObjectTaggingResponse extends TeaModel {
    @NameInMap("x-oss-request-id")
    @Validation(required = true)
    public String requestId;

    public static PutObjectTaggingResponse build(java.util.Map<String, ?> map) throws Exception {
        PutObjectTaggingResponse self = new PutObjectTaggingResponse();
        return TeaModel.build(map, self);
    }

}
