// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class GetLiveChannelHistoryRequest extends TeaModel {
    @NameInMap("BucketName")
    @Validation(required = true)
    public String bucketName;

    @NameInMap("ChannelName")
    @Validation(required = true)
    public String channelName;

    @NameInMap("Filter")
    public GetLiveChannelHistoryRequestFilter filter;

    public static class GetLiveChannelHistoryRequestFilter extends TeaModel {
        @NameInMap("comp")
        public String comp;

    }

}
