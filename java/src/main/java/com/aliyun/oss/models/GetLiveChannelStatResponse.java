// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class GetLiveChannelStatResponse extends TeaModel {
    @NameInMap("x-oss-request-id")
    @Validation(required = true)
    public String requestId;

    @NameInMap("LiveChannelStat")
    @Validation(required = true)
    public GetLiveChannelStatResponseLiveChannelStat liveChannelStat;

    public static GetLiveChannelStatResponse build(java.util.Map<String, ?> map) throws Exception {
        GetLiveChannelStatResponse self = new GetLiveChannelStatResponse();
        return TeaModel.build(map, self);
    }

    public static class GetLiveChannelStatResponseLiveChannelStatVideo extends TeaModel {
        @NameInMap("Width")
        public String width;

        @NameInMap("Height")
        public String height;

        @NameInMap("FrameRate")
        public String frameRate;

        @NameInMap("Bandwidth")
        public String bandwidth;

        @NameInMap("Codec")
        public String codec;

        public static GetLiveChannelStatResponseLiveChannelStatVideo build(java.util.Map<String, ?> map) throws Exception {
            GetLiveChannelStatResponseLiveChannelStatVideo self = new GetLiveChannelStatResponseLiveChannelStatVideo();
            return TeaModel.build(map, self);
        }

    }

    public static class GetLiveChannelStatResponseLiveChannelStatAudio extends TeaModel {
        @NameInMap("Bandwidth")
        public String bandwidth;

        @NameInMap("SampleRate")
        public String sampleRate;

        @NameInMap("Codec")
        public String codec;

        public static GetLiveChannelStatResponseLiveChannelStatAudio build(java.util.Map<String, ?> map) throws Exception {
            GetLiveChannelStatResponseLiveChannelStatAudio self = new GetLiveChannelStatResponseLiveChannelStatAudio();
            return TeaModel.build(map, self);
        }

    }

    public static class GetLiveChannelStatResponseLiveChannelStat extends TeaModel {
        @NameInMap("Status")
        public String status;

        @NameInMap("ConnectedTime")
        public String connectedTime;

        @NameInMap("RemoteAddr")
        public String remoteAddr;

        @NameInMap("Video")
        @Validation(required = true)
        public GetLiveChannelStatResponseLiveChannelStatVideo video;

        @NameInMap("Audio")
        @Validation(required = true)
        public GetLiveChannelStatResponseLiveChannelStatAudio audio;

        public static GetLiveChannelStatResponseLiveChannelStat build(java.util.Map<String, ?> map) throws Exception {
            GetLiveChannelStatResponseLiveChannelStat self = new GetLiveChannelStatResponseLiveChannelStat();
            return TeaModel.build(map, self);
        }

    }

}
