// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class PutSymlinkResponse extends TeaModel {
    @NameInMap("x-oss-request-id")
    @Validation(required = true)
    public String requestId;

    public static PutSymlinkResponse build(java.util.Map<String, ?> map) throws Exception {
        PutSymlinkResponse self = new PutSymlinkResponse();
        return TeaModel.build(map, self);
    }

}
