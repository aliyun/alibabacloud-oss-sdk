// This file is auto-generated, don't edit it. Thanks.
package com.oss.models;

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
        @Validation(required = true)
        public String type;

        @NameInMap("FragDuration")
        @Validation(required = true)
        public String fragDuration;

        @NameInMap("FragCount")
        @Validation(required = true)
        public String fragCount;

        @NameInMap("PlaylistName")
        @Validation(required = true)
        public String playlistName;

    }

    public static class GetLiveChannelInfoResponseLiveChannelConfiguration extends TeaModel {
        @NameInMap("Description")
        @Validation(required = true)
        public String description;

        @NameInMap("Status")
        @Validation(required = true)
        public String status;

        @NameInMap("Target")
        @Validation(required = true)
        public GetLiveChannelInfoResponseLiveChannelConfigurationTarget target;

    }

}
