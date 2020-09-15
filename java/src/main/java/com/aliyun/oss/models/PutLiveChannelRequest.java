// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class PutLiveChannelRequest extends TeaModel {
    // BucketName
    @NameInMap("BucketName")
    @Validation(required = true)
    public String bucketName;

    // ChannelName
    @NameInMap("ChannelName")
    @Validation(required = true)
    public String channelName;

    // Body
    @NameInMap("Body")
    public PutLiveChannelRequestBody body;

    public static PutLiveChannelRequest build(java.util.Map<String, ?> map) {
        PutLiveChannelRequest self = new PutLiveChannelRequest();
        return TeaModel.build(map, self);
    }

    public PutLiveChannelRequest setBucketName(String bucketName) {
        this.bucketName = bucketName;
        return this;
    }
    public String getBucketName() {
        return this.bucketName;
    }

    public PutLiveChannelRequest setChannelName(String channelName) {
        this.channelName = channelName;
        return this;
    }
    public String getChannelName() {
        return this.channelName;
    }

    public PutLiveChannelRequest setBody(PutLiveChannelRequestBody body) {
        this.body = body;
        return this;
    }
    public PutLiveChannelRequestBody getBody() {
        return this.body;
    }

    public static class PutLiveChannelRequestBodyLiveChannelConfigurationTarget extends TeaModel {
        // Type
        @NameInMap("Type")
        public String type;

        // FragDuration
        @NameInMap("FragDuration")
        public String fragDuration;

        // FragCount
        @NameInMap("FragCount")
        public String fragCount;

        // PlaylistName
        @NameInMap("PlaylistName")
        public String playlistName;

        public static PutLiveChannelRequestBodyLiveChannelConfigurationTarget build(java.util.Map<String, ?> map) {
            PutLiveChannelRequestBodyLiveChannelConfigurationTarget self = new PutLiveChannelRequestBodyLiveChannelConfigurationTarget();
            return TeaModel.build(map, self);
        }

        public PutLiveChannelRequestBodyLiveChannelConfigurationTarget setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

        public PutLiveChannelRequestBodyLiveChannelConfigurationTarget setFragDuration(String fragDuration) {
            this.fragDuration = fragDuration;
            return this;
        }
        public String getFragDuration() {
            return this.fragDuration;
        }

        public PutLiveChannelRequestBodyLiveChannelConfigurationTarget setFragCount(String fragCount) {
            this.fragCount = fragCount;
            return this;
        }
        public String getFragCount() {
            return this.fragCount;
        }

        public PutLiveChannelRequestBodyLiveChannelConfigurationTarget setPlaylistName(String playlistName) {
            this.playlistName = playlistName;
            return this;
        }
        public String getPlaylistName() {
            return this.playlistName;
        }

    }

    public static class PutLiveChannelRequestBodyLiveChannelConfigurationSnapshot extends TeaModel {
        // RoleName
        @NameInMap("RoleName")
        public String roleName;

        // DestBucket
        @NameInMap("DestBucket")
        public String destBucket;

        // NotifyTopic
        @NameInMap("NotifyTopic")
        public String notifyTopic;

        // Interval
        @NameInMap("Interval")
        public String interval;

        public static PutLiveChannelRequestBodyLiveChannelConfigurationSnapshot build(java.util.Map<String, ?> map) {
            PutLiveChannelRequestBodyLiveChannelConfigurationSnapshot self = new PutLiveChannelRequestBodyLiveChannelConfigurationSnapshot();
            return TeaModel.build(map, self);
        }

        public PutLiveChannelRequestBodyLiveChannelConfigurationSnapshot setRoleName(String roleName) {
            this.roleName = roleName;
            return this;
        }
        public String getRoleName() {
            return this.roleName;
        }

        public PutLiveChannelRequestBodyLiveChannelConfigurationSnapshot setDestBucket(String destBucket) {
            this.destBucket = destBucket;
            return this;
        }
        public String getDestBucket() {
            return this.destBucket;
        }

        public PutLiveChannelRequestBodyLiveChannelConfigurationSnapshot setNotifyTopic(String notifyTopic) {
            this.notifyTopic = notifyTopic;
            return this;
        }
        public String getNotifyTopic() {
            return this.notifyTopic;
        }

        public PutLiveChannelRequestBodyLiveChannelConfigurationSnapshot setInterval(String interval) {
            this.interval = interval;
            return this;
        }
        public String getInterval() {
            return this.interval;
        }

    }

    public static class PutLiveChannelRequestBodyLiveChannelConfiguration extends TeaModel {
        // Target
        @NameInMap("Target")
        public PutLiveChannelRequestBodyLiveChannelConfigurationTarget target;

        // Snapshot
        @NameInMap("Snapshot")
        public PutLiveChannelRequestBodyLiveChannelConfigurationSnapshot snapshot;

        // Description
        @NameInMap("Description")
        public String description;

        // Status
        @NameInMap("Status")
        public String status;

        public static PutLiveChannelRequestBodyLiveChannelConfiguration build(java.util.Map<String, ?> map) {
            PutLiveChannelRequestBodyLiveChannelConfiguration self = new PutLiveChannelRequestBodyLiveChannelConfiguration();
            return TeaModel.build(map, self);
        }

        public PutLiveChannelRequestBodyLiveChannelConfiguration setTarget(PutLiveChannelRequestBodyLiveChannelConfigurationTarget target) {
            this.target = target;
            return this;
        }
        public PutLiveChannelRequestBodyLiveChannelConfigurationTarget getTarget() {
            return this.target;
        }

        public PutLiveChannelRequestBodyLiveChannelConfiguration setSnapshot(PutLiveChannelRequestBodyLiveChannelConfigurationSnapshot snapshot) {
            this.snapshot = snapshot;
            return this;
        }
        public PutLiveChannelRequestBodyLiveChannelConfigurationSnapshot getSnapshot() {
            return this.snapshot;
        }

        public PutLiveChannelRequestBodyLiveChannelConfiguration setDescription(String description) {
            this.description = description;
            return this;
        }
        public String getDescription() {
            return this.description;
        }

        public PutLiveChannelRequestBodyLiveChannelConfiguration setStatus(String status) {
            this.status = status;
            return this;
        }
        public String getStatus() {
            return this.status;
        }

    }

    public static class PutLiveChannelRequestBody extends TeaModel {
        // LiveChannelConfiguration
        @NameInMap("LiveChannelConfiguration")
        @Validation(required = true)
        public PutLiveChannelRequestBodyLiveChannelConfiguration liveChannelConfiguration;

        public static PutLiveChannelRequestBody build(java.util.Map<String, ?> map) {
            PutLiveChannelRequestBody self = new PutLiveChannelRequestBody();
            return TeaModel.build(map, self);
        }

        public PutLiveChannelRequestBody setLiveChannelConfiguration(PutLiveChannelRequestBodyLiveChannelConfiguration liveChannelConfiguration) {
            this.liveChannelConfiguration = liveChannelConfiguration;
            return this;
        }
        public PutLiveChannelRequestBodyLiveChannelConfiguration getLiveChannelConfiguration() {
            return this.liveChannelConfiguration;
        }

    }

}
