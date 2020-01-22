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

    public static PostVodPlaylistRequest build(java.util.Map<String, ?> map) throws Exception {
        PostVodPlaylistRequest self = new PostVodPlaylistRequest();
        return TeaModel.build(map, self);
    }

    public static class PostVodPlaylistRequestFilter extends TeaModel {
        @NameInMap("endTime")
        @Validation(required = true)
        public String endTime;

        @NameInMap("startTime")
        @Validation(required = true)
        public String startTime;

        public static PostVodPlaylistRequestFilter build(java.util.Map<String, ?> map) throws Exception {
            PostVodPlaylistRequestFilter self = new PostVodPlaylistRequestFilter();
            return TeaModel.build(map, self);
        }

    }

}
