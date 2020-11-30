// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class PostVodPlaylistRequest extends TeaModel {
    // BucketName
    @NameInMap("BucketName")
    @Validation(required = true, pattern = "[a-zA-Z0-9-_]+")
    public String bucketName;

    // ChannelName
    @NameInMap("ChannelName")
    @Validation(required = true)
    public String channelName;

    // PlaylistName
    @NameInMap("PlaylistName")
    @Validation(required = true)
    public String playlistName;

    // Filter
    @NameInMap("Filter")
    @Validation(required = true)
    public PostVodPlaylistRequestFilter filter;

    public static PostVodPlaylistRequest build(java.util.Map<String, ?> map) throws Exception {
        PostVodPlaylistRequest self = new PostVodPlaylistRequest();
        return TeaModel.build(map, self);
    }

    public PostVodPlaylistRequest setBucketName(String bucketName) {
        this.bucketName = bucketName;
        return this;
    }
    public String getBucketName() {
        return this.bucketName;
    }

    public PostVodPlaylistRequest setChannelName(String channelName) {
        this.channelName = channelName;
        return this;
    }
    public String getChannelName() {
        return this.channelName;
    }

    public PostVodPlaylistRequest setPlaylistName(String playlistName) {
        this.playlistName = playlistName;
        return this;
    }
    public String getPlaylistName() {
        return this.playlistName;
    }

    public PostVodPlaylistRequest setFilter(PostVodPlaylistRequestFilter filter) {
        this.filter = filter;
        return this;
    }
    public PostVodPlaylistRequestFilter getFilter() {
        return this.filter;
    }

    public static class PostVodPlaylistRequestFilter extends TeaModel {
        // endTime
        @NameInMap("endTime")
        @Validation(required = true)
        public String endTime;

        // startTime
        @NameInMap("startTime")
        @Validation(required = true)
        public String startTime;

        public static PostVodPlaylistRequestFilter build(java.util.Map<String, ?> map) throws Exception {
            PostVodPlaylistRequestFilter self = new PostVodPlaylistRequestFilter();
            return TeaModel.build(map, self);
        }

        public PostVodPlaylistRequestFilter setEndTime(String endTime) {
            this.endTime = endTime;
            return this;
        }
        public String getEndTime() {
            return this.endTime;
        }

        public PostVodPlaylistRequestFilter setStartTime(String startTime) {
            this.startTime = startTime;
            return this;
        }
        public String getStartTime() {
            return this.startTime;
        }

    }

}
