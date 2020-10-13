// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class GetLiveChannelStatRequest extends TeaModel {
    // BucketName
    @NameInMap("BucketName")
    @Validation(required = true, pattern = "[a-zA-Z0-9\\-\\_]+")
    public String bucketName;

    // ChannelName
    @NameInMap("ChannelName")
    @Validation(required = true)
    public String channelName;

    // Filter
    @NameInMap("Filter")
    public GetLiveChannelStatRequestFilter filter;

    public static GetLiveChannelStatRequest build(java.util.Map<String, ?> map) throws Exception {
        GetLiveChannelStatRequest self = new GetLiveChannelStatRequest();
        return TeaModel.build(map, self);
    }

    public GetLiveChannelStatRequest setBucketName(String bucketName) {
        this.bucketName = bucketName;
        return this;
    }
    public String getBucketName() {
        return this.bucketName;
    }

    public GetLiveChannelStatRequest setChannelName(String channelName) {
        this.channelName = channelName;
        return this;
    }
    public String getChannelName() {
        return this.channelName;
    }

    public GetLiveChannelStatRequest setFilter(GetLiveChannelStatRequestFilter filter) {
        this.filter = filter;
        return this;
    }
    public GetLiveChannelStatRequestFilter getFilter() {
        return this.filter;
    }

    public static class GetLiveChannelStatRequestFilter extends TeaModel {
        // comp
        @NameInMap("comp")
        public String comp;

        public static GetLiveChannelStatRequestFilter build(java.util.Map<String, ?> map) throws Exception {
            GetLiveChannelStatRequestFilter self = new GetLiveChannelStatRequestFilter();
            return TeaModel.build(map, self);
        }

        public GetLiveChannelStatRequestFilter setComp(String comp) {
            this.comp = comp;
            return this;
        }
        public String getComp() {
            return this.comp;
        }

    }

}
