// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class PutLiveChannelStatusRequest extends TeaModel {
    @NameInMap("BucketName")
    @Validation(required = true)
    public String bucketName;

    @NameInMap("ChannelName")
    @Validation(required = true)
    public String channelName;

    @NameInMap("Filter")
    @Validation(required = true)
    public PutLiveChannelStatusRequestFilter filter;

    public static PutLiveChannelStatusRequest build(java.util.Map<String, ?> map) throws Exception {
        PutLiveChannelStatusRequest self = new PutLiveChannelStatusRequest();
        return TeaModel.build(map, self);
    }

    public static class PutLiveChannelStatusRequestFilter extends TeaModel {
        @NameInMap("status")
        @Validation(required = true)
        public String status;

        public static PutLiveChannelStatusRequestFilter build(java.util.Map<String, ?> map) throws Exception {
            PutLiveChannelStatusRequestFilter self = new PutLiveChannelStatusRequestFilter();
            return TeaModel.build(map, self);
        }

    }

}
