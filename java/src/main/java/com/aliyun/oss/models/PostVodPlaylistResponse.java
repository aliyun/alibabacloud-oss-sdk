// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class PostVodPlaylistResponse extends TeaModel {
    @NameInMap("x-oss-request-id")
    @Validation(required = true)
    public String requestId;

    public static PostVodPlaylistResponse build(java.util.Map<String, ?> map) throws Exception {
        PostVodPlaylistResponse self = new PostVodPlaylistResponse();
        return TeaModel.build(map, self);
    }

}
