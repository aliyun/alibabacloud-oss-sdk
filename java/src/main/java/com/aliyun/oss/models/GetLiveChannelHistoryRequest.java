// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class GetLiveChannelHistoryRequest extends TeaModel {
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
    public GetLiveChannelHistoryRequestFilter filter;

    public static GetLiveChannelHistoryRequest build(java.util.Map<String, ?> map) {
        GetLiveChannelHistoryRequest self = new GetLiveChannelHistoryRequest();
        return TeaModel.build(map, self);
    }

    public GetLiveChannelHistoryRequest setBucketName(String bucketName) {
        this.bucketName = bucketName;
        return this;
    }
    public String getBucketName() {
        return this.bucketName;
    }

    public GetLiveChannelHistoryRequest setChannelName(String channelName) {
        this.channelName = channelName;
        return this;
    }
    public String getChannelName() {
        return this.channelName;
    }

    public GetLiveChannelHistoryRequest setFilter(GetLiveChannelHistoryRequestFilter filter) {
        this.filter = filter;
        return this;
    }
    public GetLiveChannelHistoryRequestFilter getFilter() {
        return this.filter;
    }

    public static class GetLiveChannelHistoryRequestFilter extends TeaModel {
        // comp
        @NameInMap("comp")
        public String comp;

        public static GetLiveChannelHistoryRequestFilter build(java.util.Map<String, ?> map) {
            GetLiveChannelHistoryRequestFilter self = new GetLiveChannelHistoryRequestFilter();
            return TeaModel.build(map, self);
        }

        public GetLiveChannelHistoryRequestFilter setComp(String comp) {
            this.comp = comp;
            return this;
        }
        public String getComp() {
            return this.comp;
        }

    }

}
