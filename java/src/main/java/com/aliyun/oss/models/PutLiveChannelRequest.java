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

    public static PutLiveChannelRequest build(java.util.Map<String, ?> map) throws Exception {
        PutLiveChannelRequest self = new PutLiveChannelRequest();
        return TeaModel.build(map, self);
    }

    public static class PutLiveChannelRequestBodyLiveChannelConfigurationTarget extends TeaModel {
        @NameInMap("Type")
        public String type;

        @NameInMap("FragDuration")
        public String fragDuration;

        @NameInMap("FragCount")
        public String fragCount;

        @NameInMap("PlaylistName")
        public String playlistName;

        public static PutLiveChannelRequestBodyLiveChannelConfigurationTarget build(java.util.Map<String, ?> map) throws Exception {
            PutLiveChannelRequestBodyLiveChannelConfigurationTarget self = new PutLiveChannelRequestBodyLiveChannelConfigurationTarget();
            return TeaModel.build(map, self);
        }

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

        public static PutLiveChannelRequestBodyLiveChannelConfigurationSnapshot build(java.util.Map<String, ?> map) throws Exception {
            PutLiveChannelRequestBodyLiveChannelConfigurationSnapshot self = new PutLiveChannelRequestBodyLiveChannelConfigurationSnapshot();
            return TeaModel.build(map, self);
        }

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

        public static PutLiveChannelRequestBodyLiveChannelConfiguration build(java.util.Map<String, ?> map) throws Exception {
            PutLiveChannelRequestBodyLiveChannelConfiguration self = new PutLiveChannelRequestBodyLiveChannelConfiguration();
            return TeaModel.build(map, self);
        }

    }

    public static class PutLiveChannelRequestBody extends TeaModel {
        @NameInMap("LiveChannelConfiguration")
        @Validation(required = true)
        public PutLiveChannelRequestBodyLiveChannelConfiguration liveChannelConfiguration;

        public static PutLiveChannelRequestBody build(java.util.Map<String, ?> map) throws Exception {
            PutLiveChannelRequestBody self = new PutLiveChannelRequestBody();
            return TeaModel.build(map, self);
        }

    }

}
