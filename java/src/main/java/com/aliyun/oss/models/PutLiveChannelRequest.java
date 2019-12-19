// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class PutLiveChannelRequest extends TeaModel {
    @NameInMap("BucketName")
    @Validation(required = true)
    public String bucketName;

    @NameInMap("ChannelName")
    @Validation(required = true)
    public String channelName;

    @NameInMap("Body")
    public PutLiveChannelRequestBody body;

    public static class PutLiveChannelRequestBodyLiveChannelConfigurationTarget extends TeaModel {
        @NameInMap("Type")
        public String type;

        @NameInMap("FragDuration")
        public String fragDuration;

        @NameInMap("FragCount")
        public String fragCount;

        @NameInMap("PlaylistName")
        public String playlistName;

    }

    public static class PutLiveChannelRequestBodyLiveChannelConfigurationSnapshot extends TeaModel {
        @NameInMap("RoleName")
        public String roleName;

        @NameInMap("DestBucket")
        public String destBucket;

        @NameInMap("NotifyTopic")
        public String notifyTopic;

        @NameInMap("Interval")
        public String interval;

    }

    public static class PutLiveChannelRequestBodyLiveChannelConfiguration extends TeaModel {
        @NameInMap("Target")
        public PutLiveChannelRequestBodyLiveChannelConfigurationTarget target;

        @NameInMap("Snapshot")
        public PutLiveChannelRequestBodyLiveChannelConfigurationSnapshot snapshot;

        @NameInMap("Description")
        public String description;

        @NameInMap("Status")
        public String status;

    }

    public static class PutLiveChannelRequestBody extends TeaModel {
        @NameInMap("LiveChannelConfiguration")
        @Validation(required = true)
        public PutLiveChannelRequestBodyLiveChannelConfiguration liveChannelConfiguration;

    }

}
