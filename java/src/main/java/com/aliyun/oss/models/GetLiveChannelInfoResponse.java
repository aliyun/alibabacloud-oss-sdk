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

    public static class GetLiveChannelInfoResponseLiveChannelConfigurationTarget extends TeaModel {
        @NameInMap("Type")
        public String type;

        @NameInMap("FragDuration")
        public String fragDuration;

        @NameInMap("FragCount")
        public String fragCount;

        @NameInMap("PlaylistName")
        public String playlistName;

    }

    public static class GetLiveChannelInfoResponseLiveChannelConfiguration extends TeaModel {
        @NameInMap("Description")
        public String description;

        @NameInMap("Status")
        public String status;

        @NameInMap("Target")
        @Validation(required = true)
        public GetLiveChannelInfoResponseLiveChannelConfigurationTarget target;

    }

}
