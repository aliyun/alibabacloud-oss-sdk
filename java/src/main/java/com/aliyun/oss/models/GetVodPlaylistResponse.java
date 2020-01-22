// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class GetVodPlaylistResponse extends TeaModel {
    @NameInMap("x-oss-request-id")
    @Validation(required = true)
    public String requestId;

    public static GetVodPlaylistResponse build(java.util.Map<String, ?> map) throws Exception {
        GetVodPlaylistResponse self = new GetVodPlaylistResponse();
        return TeaModel.build(map, self);
    }

}
