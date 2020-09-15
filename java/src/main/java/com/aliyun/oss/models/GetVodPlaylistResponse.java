// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class GetVodPlaylistResponse extends TeaModel {
    // x-oss-request-id
    @NameInMap("x-oss-request-id")
    @Validation(required = true)
    public String requestId;

    public static GetVodPlaylistResponse build(java.util.Map<String, ?> map) {
        GetVodPlaylistResponse self = new GetVodPlaylistResponse();
        return TeaModel.build(map, self);
    }

    public GetVodPlaylistResponse setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

}
