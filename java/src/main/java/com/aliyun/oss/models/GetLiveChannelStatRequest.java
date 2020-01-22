// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class GetLiveChannelStatRequest extends TeaModel {
    @NameInMap("BucketName")
    @Validation(required = true)
    public String bucketName;

    @NameInMap("ChannelName")
    @Validation(required = true)
    public String channelName;

    @NameInMap("Filter")
    public GetLiveChannelStatRequestFilter filter;

    public static GetLiveChannelStatRequest build(java.util.Map<String, ?> map) throws Exception {
        GetLiveChannelStatRequest self = new GetLiveChannelStatRequest();
        return TeaModel.build(map, self);
    }

    public static class GetLiveChannelStatRequestFilter extends TeaModel {
        @NameInMap("comp")
        public String comp;

        public static GetLiveChannelStatRequestFilter build(java.util.Map<String, ?> map) throws Exception {
            GetLiveChannelStatRequestFilter self = new GetLiveChannelStatRequestFilter();
            return TeaModel.build(map, self);
        }

    }

}
