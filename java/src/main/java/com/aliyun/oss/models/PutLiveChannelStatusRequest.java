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

    public static class PutLiveChannelStatusRequestFilter extends TeaModel {
        @NameInMap("status")
        @Validation(required = true)
        public String status;

    }

}
