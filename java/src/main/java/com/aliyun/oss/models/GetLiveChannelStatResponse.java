// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class GetLiveChannelStatResponse extends TeaModel {
    // x-oss-request-id
    @NameInMap("x-oss-request-id")
    @Validation(required = true)
    public String requestId;

    // LiveChannelStat
    @NameInMap("LiveChannelStat")
    @Validation(required = true)
    public GetLiveChannelStatResponseLiveChannelStat liveChannelStat;

    public static GetLiveChannelStatResponse build(java.util.Map<String, ?> map) {
        GetLiveChannelStatResponse self = new GetLiveChannelStatResponse();
        return TeaModel.build(map, self);
    }

    public GetLiveChannelStatResponse setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public GetLiveChannelStatResponse setLiveChannelStat(GetLiveChannelStatResponseLiveChannelStat liveChannelStat) {
        this.liveChannelStat = liveChannelStat;
        return this;
    }
    public GetLiveChannelStatResponseLiveChannelStat getLiveChannelStat() {
        return this.liveChannelStat;
    }

    public static class GetLiveChannelStatResponseLiveChannelStatVideo extends TeaModel {
        // Width
        @NameInMap("Width")
        public String width;

        // Height
        @NameInMap("Height")
        public String height;

        // FrameRate
        @NameInMap("FrameRate")
        public String frameRate;

        // Bandwidth
        @NameInMap("Bandwidth")
        public String bandwidth;

        // Codec
        @NameInMap("Codec")
        public String codec;

        public static GetLiveChannelStatResponseLiveChannelStatVideo build(java.util.Map<String, ?> map) {
            GetLiveChannelStatResponseLiveChannelStatVideo self = new GetLiveChannelStatResponseLiveChannelStatVideo();
            return TeaModel.build(map, self);
        }

        public GetLiveChannelStatResponseLiveChannelStatVideo setWidth(String width) {
            this.width = width;
            return this;
        }
        public String getWidth() {
            return this.width;
        }

        public GetLiveChannelStatResponseLiveChannelStatVideo setHeight(String height) {
            this.height = height;
            return this;
        }
        public String getHeight() {
            return this.height;
        }

        public GetLiveChannelStatResponseLiveChannelStatVideo setFrameRate(String frameRate) {
            this.frameRate = frameRate;
            return this;
        }
        public String getFrameRate() {
            return this.frameRate;
        }

        public GetLiveChannelStatResponseLiveChannelStatVideo setBandwidth(String bandwidth) {
            this.bandwidth = bandwidth;
            return this;
        }
        public String getBandwidth() {
            return this.bandwidth;
        }

        public GetLiveChannelStatResponseLiveChannelStatVideo setCodec(String codec) {
            this.codec = codec;
            return this;
        }
        public String getCodec() {
            return this.codec;
        }

    }

    public static class GetLiveChannelStatResponseLiveChannelStatAudio extends TeaModel {
        // Bandwidth
        @NameInMap("Bandwidth")
        public String bandwidth;

        // SampleRate
        @NameInMap("SampleRate")
        public String sampleRate;

        // Codec
        @NameInMap("Codec")
        public String codec;

        public static GetLiveChannelStatResponseLiveChannelStatAudio build(java.util.Map<String, ?> map) {
            GetLiveChannelStatResponseLiveChannelStatAudio self = new GetLiveChannelStatResponseLiveChannelStatAudio();
            return TeaModel.build(map, self);
        }

        public GetLiveChannelStatResponseLiveChannelStatAudio setBandwidth(String bandwidth) {
            this.bandwidth = bandwidth;
            return this;
        }
        public String getBandwidth() {
            return this.bandwidth;
        }

        public GetLiveChannelStatResponseLiveChannelStatAudio setSampleRate(String sampleRate) {
            this.sampleRate = sampleRate;
            return this;
        }
        public String getSampleRate() {
            return this.sampleRate;
        }

        public GetLiveChannelStatResponseLiveChannelStatAudio setCodec(String codec) {
            this.codec = codec;
            return this;
        }
        public String getCodec() {
            return this.codec;
        }

    }

    public static class GetLiveChannelStatResponseLiveChannelStat extends TeaModel {
        // Status
        @NameInMap("Status")
        public String status;

        // ConnectedTime
        @NameInMap("ConnectedTime")
        public String connectedTime;

        // RemoteAddr
        @NameInMap("RemoteAddr")
        public String remoteAddr;

        // Video
        @NameInMap("Video")
        @Validation(required = true)
        public GetLiveChannelStatResponseLiveChannelStatVideo video;

        // Audio
        @NameInMap("Audio")
        @Validation(required = true)
        public GetLiveChannelStatResponseLiveChannelStatAudio audio;

        public static GetLiveChannelStatResponseLiveChannelStat build(java.util.Map<String, ?> map) {
            GetLiveChannelStatResponseLiveChannelStat self = new GetLiveChannelStatResponseLiveChannelStat();
            return TeaModel.build(map, self);
        }

        public GetLiveChannelStatResponseLiveChannelStat setStatus(String status) {
            this.status = status;
            return this;
        }
        public String getStatus() {
            return this.status;
        }

        public GetLiveChannelStatResponseLiveChannelStat setConnectedTime(String connectedTime) {
            this.connectedTime = connectedTime;
            return this;
        }
        public String getConnectedTime() {
            return this.connectedTime;
        }

        public GetLiveChannelStatResponseLiveChannelStat setRemoteAddr(String remoteAddr) {
            this.remoteAddr = remoteAddr;
            return this;
        }
        public String getRemoteAddr() {
            return this.remoteAddr;
        }

        public GetLiveChannelStatResponseLiveChannelStat setVideo(GetLiveChannelStatResponseLiveChannelStatVideo video) {
            this.video = video;
            return this;
        }
        public GetLiveChannelStatResponseLiveChannelStatVideo getVideo() {
            return this.video;
        }

        public GetLiveChannelStatResponseLiveChannelStat setAudio(GetLiveChannelStatResponseLiveChannelStatAudio audio) {
            this.audio = audio;
            return this;
        }
        public GetLiveChannelStatResponseLiveChannelStatAudio getAudio() {
            return this.audio;
        }

    }

}
