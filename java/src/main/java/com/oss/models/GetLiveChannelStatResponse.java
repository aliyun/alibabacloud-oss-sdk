// This file is auto-generated, don't edit it. Thanks.
package com.oss.models;

import com.aliyun.tea.*;

public class GetLiveChannelStatResponse extends TeaModel {
    @NameInMap("x-oss-request-id")
    @Validation(required = true)
    public String requestId;

    @NameInMap("LiveChannelStat")
    @Validation(required = true)
    public GetLiveChannelStatResponseLiveChannelStat liveChannelStat;

    public static class GetLiveChannelStatResponseLiveChannelStatVideo extends TeaModel {
        @NameInMap("Width")
        @Validation(required = true)
        public String width;

        @NameInMap("Height")
        @Validation(required = true)
        public String height;

        @NameInMap("FrameRate")
        @Validation(required = true)
        public String frameRate;

        @NameInMap("Bandwidth")
        @Validation(required = true)
        public String bandwidth;

        @NameInMap("Codec")
        @Validation(required = true)
        public String codec;

    }

    public static class GetLiveChannelStatResponseLiveChannelStatAudio extends TeaModel {
        @NameInMap("Bandwidth")
        @Validation(required = true)
        public String bandwidth;

        @NameInMap("SampleRate")
        @Validation(required = true)
        public String sampleRate;

        @NameInMap("Codec")
        @Validation(required = true)
        public String codec;

    }

    public static class GetLiveChannelStatResponseLiveChannelStat extends TeaModel {
        @NameInMap("Status")
        @Validation(required = true)
        public String status;

        @NameInMap("ConnectedTime")
        @Validation(required = true)
        public String connectedTime;

        @NameInMap("RemoteAddr")
        @Validation(required = true)
        public String remoteAddr;

        @NameInMap("Video")
        @Validation(required = true)
        public GetLiveChannelStatResponseLiveChannelStatVideo video;

        @NameInMap("Audio")
        @Validation(required = true)
        public GetLiveChannelStatResponseLiveChannelStatAudio audio;

    }

}
