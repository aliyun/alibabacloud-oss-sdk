// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class GetLiveChannelInfoResponse extends TeaModel {
    @NameInMap("x-oss-request-id")
    @Validation(required = true)
    public String requestId;

    @NameInMap("LiveChannelConfiguration")
    @Validation(required = true)
    public GetLiveChannelInfoResponseLiveChannelConfiguration liveChannelConfiguration;

    public static GetLiveChannelInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        GetLiveChannelInfoResponse self = new GetLiveChannelInfoResponse();
        return TeaModel.build(map, self);
    }

    public static class GetLiveChannelInfoResponseLiveChannelConfigurationTarget extends TeaModel {
        @NameInMap("Type")
        public String type;

        @NameInMap("FragDuration")
        public String fragDuration;

        @NameInMap("FragCount")
        public String fragCount;

        @NameInMap("PlaylistName")
        public String playlistName;

        public static GetLiveChannelInfoResponseLiveChannelConfigurationTarget build(java.util.Map<String, ?> map) throws Exception {
            GetLiveChannelInfoResponseLiveChannelConfigurationTarget self = new GetLiveChannelInfoResponseLiveChannelConfigurationTarget();
            return TeaModel.build(map, self);
        }

    }

    public static class GetLiveChannelInfoResponseLiveChannelConfiguration extends TeaModel {
        @NameInMap("Description")
        public String description;

        @NameInMap("Status")
        public String status;

        @NameInMap("Target")
        @Validation(required = true)
        public GetLiveChannelInfoResponseLiveChannelConfigurationTarget target;

        public static GetLiveChannelInfoResponseLiveChannelConfiguration build(java.util.Map<String, ?> map) throws Exception {
            GetLiveChannelInfoResponseLiveChannelConfiguration self = new GetLiveChannelInfoResponseLiveChannelConfiguration();
            return TeaModel.build(map, self);
        }

    }

}
