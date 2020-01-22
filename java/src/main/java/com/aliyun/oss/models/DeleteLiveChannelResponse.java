// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class DeleteLiveChannelResponse extends TeaModel {
    @NameInMap("x-oss-request-id")
    @Validation(required = true)
    public String requestId;

    public static DeleteLiveChannelResponse build(java.util.Map<String, ?> map) throws Exception {
        DeleteLiveChannelResponse self = new DeleteLiveChannelResponse();
        return TeaModel.build(map, self);
    }

}
