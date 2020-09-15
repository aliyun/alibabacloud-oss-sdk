// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class GetLiveChannelInfoResponse extends TeaModel {
    // x-oss-request-id
    @NameInMap("x-oss-request-id")
    @Validation(required = true)
    public String requestId;

    // LiveChannelConfiguration
    @NameInMap("LiveChannelConfiguration")
    @Validation(required = true)
    public GetLiveChannelInfoResponseLiveChannelConfiguration liveChannelConfiguration;

    public static GetLiveChannelInfoResponse build(java.util.Map<String, ?> map) {
        GetLiveChannelInfoResponse self = new GetLiveChannelInfoResponse();
        return TeaModel.build(map, self);
    }

    public GetLiveChannelInfoResponse setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public GetLiveChannelInfoResponse setLiveChannelConfiguration(GetLiveChannelInfoResponseLiveChannelConfiguration liveChannelConfiguration) {
        this.liveChannelConfiguration = liveChannelConfiguration;
        return this;
    }
    public GetLiveChannelInfoResponseLiveChannelConfiguration getLiveChannelConfiguration() {
        return this.liveChannelConfiguration;
    }

    public static class GetLiveChannelInfoResponseLiveChannelConfigurationTarget extends TeaModel {
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

        public static GetLiveChannelInfoResponseLiveChannelConfigurationTarget build(java.util.Map<String, ?> map) {
            GetLiveChannelInfoResponseLiveChannelConfigurationTarget self = new GetLiveChannelInfoResponseLiveChannelConfigurationTarget();
            return TeaModel.build(map, self);
        }

        public GetLiveChannelInfoResponseLiveChannelConfigurationTarget setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

        public GetLiveChannelInfoResponseLiveChannelConfigurationTarget setFragDuration(String fragDuration) {
            this.fragDuration = fragDuration;
            return this;
        }
        public String getFragDuration() {
            return this.fragDuration;
        }

        public GetLiveChannelInfoResponseLiveChannelConfigurationTarget setFragCount(String fragCount) {
            this.fragCount = fragCount;
            return this;
        }
        public String getFragCount() {
            return this.fragCount;
        }

        public GetLiveChannelInfoResponseLiveChannelConfigurationTarget setPlaylistName(String playlistName) {
            this.playlistName = playlistName;
            return this;
        }
        public String getPlaylistName() {
            return this.playlistName;
        }

    }

    public static class GetLiveChannelInfoResponseLiveChannelConfiguration extends TeaModel {
        // Description
        @NameInMap("Description")
        public String description;

        // Status
        @NameInMap("Status")
        public String status;

        // Target
        @NameInMap("Target")
        @Validation(required = true)
        public GetLiveChannelInfoResponseLiveChannelConfigurationTarget target;

        public static GetLiveChannelInfoResponseLiveChannelConfiguration build(java.util.Map<String, ?> map) {
            GetLiveChannelInfoResponseLiveChannelConfiguration self = new GetLiveChannelInfoResponseLiveChannelConfiguration();
            return TeaModel.build(map, self);
        }

        public GetLiveChannelInfoResponseLiveChannelConfiguration setDescription(String description) {
            this.description = description;
            return this;
        }
        public String getDescription() {
            return this.description;
        }

        public GetLiveChannelInfoResponseLiveChannelConfiguration setStatus(String status) {
            this.status = status;
            return this;
        }
        public String getStatus() {
            return this.status;
        }

        public GetLiveChannelInfoResponseLiveChannelConfiguration setTarget(GetLiveChannelInfoResponseLiveChannelConfigurationTarget target) {
            this.target = target;
            return this;
        }
        public GetLiveChannelInfoResponseLiveChannelConfigurationTarget getTarget() {
            return this.target;
        }

    }

}
