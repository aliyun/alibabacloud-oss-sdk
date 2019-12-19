// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class PostVodPlaylistRequest extends TeaModel {
    @NameInMap("BucketName")
    @Validation(required = true)
    public String bucketName;

    @NameInMap("ChannelName")
    @Validation(required = true)
    public String channelName;

    @NameInMap("PlaylistName")
    @Validation(required = true)
    public String playlistName;

    @NameInMap("Filter")
    @Validation(required = true)
    public PostVodPlaylistRequestFilter filter;

    public static class PostVodPlaylistRequestFilter extends TeaModel {
        @NameInMap("endTime")
        @Validation(required = true)
        public String endTime;

        @NameInMap("startTime")
        @Validation(required = true)
        public String startTime;

    }

}
