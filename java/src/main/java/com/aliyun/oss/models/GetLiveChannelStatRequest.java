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

    public static class GetLiveChannelStatRequestFilter extends TeaModel {
        @NameInMap("comp")
        public String comp;

    }

}
