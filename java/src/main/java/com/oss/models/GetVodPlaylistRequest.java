// This file is auto-generated, don't edit it. Thanks.
package com.oss.models;

import com.aliyun.tea.*;

public class GetVodPlaylistRequest extends TeaModel {
    @NameInMap("BucketName")
    @Validation(required = true)
    public String bucketName;

    @NameInMap("ChannelName")
    @Validation(required = true)
    public String channelName;

    @NameInMap("Filter")
    @Validation(required = true)
    public GetVodPlaylistRequestFilter filter;

    public static class GetVodPlaylistRequestFilter extends TeaModel {
        @NameInMap("endTime")
        @Validation(required = true)
        public String endTime;

        @NameInMap("startTime")
        @Validation(required = true)
        public String startTime;

    }

}
