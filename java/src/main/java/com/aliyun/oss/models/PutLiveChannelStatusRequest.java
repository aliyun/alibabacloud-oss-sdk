// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class PutLiveChannelStatusRequest extends TeaModel {
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
    public PutLiveChannelStatusRequestFilter filter;

    public static PutLiveChannelStatusRequest build(java.util.Map<String, ?> map) {
        PutLiveChannelStatusRequest self = new PutLiveChannelStatusRequest();
        return TeaModel.build(map, self);
    }

    public PutLiveChannelStatusRequest setBucketName(String bucketName) {
        this.bucketName = bucketName;
        return this;
    }
    public String getBucketName() {
        return this.bucketName;
    }

    public PutLiveChannelStatusRequest setChannelName(String channelName) {
        this.channelName = channelName;
        return this;
    }
    public String getChannelName() {
        return this.channelName;
    }

    public PutLiveChannelStatusRequest setFilter(PutLiveChannelStatusRequestFilter filter) {
        this.filter = filter;
        return this;
    }
    public PutLiveChannelStatusRequestFilter getFilter() {
        return this.filter;
    }

    public static class PutLiveChannelStatusRequestFilter extends TeaModel {
        // status
        @NameInMap("status")
        @Validation(required = true)
        public String status;

        public static PutLiveChannelStatusRequestFilter build(java.util.Map<String, ?> map) {
            PutLiveChannelStatusRequestFilter self = new PutLiveChannelStatusRequestFilter();
            return TeaModel.build(map, self);
        }

        public PutLiveChannelStatusRequestFilter setStatus(String status) {
            this.status = status;
            return this;
        }
        public String getStatus() {
            return this.status;
        }

    }

}
