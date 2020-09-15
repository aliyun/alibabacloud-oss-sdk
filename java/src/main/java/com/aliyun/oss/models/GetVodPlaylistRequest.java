// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class GetVodPlaylistRequest extends TeaModel {
    // BucketName
    @NameInMap("BucketName")
    @Validation(required = true)
    public String bucketName;

    // ChannelName
    @NameInMap("ChannelName")
    @Validation(required = true)
    public String channelName;

    // Filter
    @NameInMap("Filter")
    @Validation(required = true)
    public GetVodPlaylistRequestFilter filter;

    public static GetVodPlaylistRequest build(java.util.Map<String, ?> map) {
        GetVodPlaylistRequest self = new GetVodPlaylistRequest();
        return TeaModel.build(map, self);
    }

    public GetVodPlaylistRequest setBucketName(String bucketName) {
        this.bucketName = bucketName;
        return this;
    }
    public String getBucketName() {
        return this.bucketName;
    }

    public GetVodPlaylistRequest setChannelName(String channelName) {
        this.channelName = channelName;
        return this;
    }
    public String getChannelName() {
        return this.channelName;
    }

    public GetVodPlaylistRequest setFilter(GetVodPlaylistRequestFilter filter) {
        this.filter = filter;
        return this;
    }
    public GetVodPlaylistRequestFilter getFilter() {
        return this.filter;
    }

    public static class GetVodPlaylistRequestFilter extends TeaModel {
        // endTime
        @NameInMap("endTime")
        @Validation(required = true)
        public String endTime;

        // startTime
        @NameInMap("startTime")
        @Validation(required = true)
        public String startTime;

        public static GetVodPlaylistRequestFilter build(java.util.Map<String, ?> map) {
            GetVodPlaylistRequestFilter self = new GetVodPlaylistRequestFilter();
            return TeaModel.build(map, self);
        }

        public GetVodPlaylistRequestFilter setEndTime(String endTime) {
            this.endTime = endTime;
            return this;
        }
        public String getEndTime() {
            return this.endTime;
        }

        public GetVodPlaylistRequestFilter setStartTime(String startTime) {
            this.startTime = startTime;
            return this;
        }
        public String getStartTime() {
            return this.startTime;
        }

    }

}
