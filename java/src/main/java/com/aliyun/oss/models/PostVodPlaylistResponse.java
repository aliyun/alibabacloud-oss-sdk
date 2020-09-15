// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class PostVodPlaylistResponse extends TeaModel {
    // x-oss-request-id
    @NameInMap("x-oss-request-id")
    @Validation(required = true)
    public String requestId;

    public static PostVodPlaylistResponse build(java.util.Map<String, ?> map) {
        PostVodPlaylistResponse self = new PostVodPlaylistResponse();
        return TeaModel.build(map, self);
    }

    public PostVodPlaylistResponse setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

}
