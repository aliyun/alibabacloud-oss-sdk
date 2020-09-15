// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class PutLiveChannelResponse extends TeaModel {
    // x-oss-request-id
    @NameInMap("x-oss-request-id")
    @Validation(required = true)
    public String requestId;

    // CreateLiveChannelResult
    @NameInMap("CreateLiveChannelResult")
    @Validation(required = true)
    public PutLiveChannelResponseCreateLiveChannelResult createLiveChannelResult;

    public static PutLiveChannelResponse build(java.util.Map<String, ?> map) {
        PutLiveChannelResponse self = new PutLiveChannelResponse();
        return TeaModel.build(map, self);
    }

    public PutLiveChannelResponse setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public PutLiveChannelResponse setCreateLiveChannelResult(PutLiveChannelResponseCreateLiveChannelResult createLiveChannelResult) {
        this.createLiveChannelResult = createLiveChannelResult;
        return this;
    }
    public PutLiveChannelResponseCreateLiveChannelResult getCreateLiveChannelResult() {
        return this.createLiveChannelResult;
    }

    public static class PutLiveChannelResponseCreateLiveChannelResultPublishUrls extends TeaModel {
        // Url
        @NameInMap("Url")
        public String url;

        public static PutLiveChannelResponseCreateLiveChannelResultPublishUrls build(java.util.Map<String, ?> map) {
            PutLiveChannelResponseCreateLiveChannelResultPublishUrls self = new PutLiveChannelResponseCreateLiveChannelResultPublishUrls();
            return TeaModel.build(map, self);
        }

        public PutLiveChannelResponseCreateLiveChannelResultPublishUrls setUrl(String url) {
            this.url = url;
            return this;
        }
        public String getUrl() {
            return this.url;
        }

    }

    public static class PutLiveChannelResponseCreateLiveChannelResultPlayUrls extends TeaModel {
        // Url
        @NameInMap("Url")
        public String url;

        public static PutLiveChannelResponseCreateLiveChannelResultPlayUrls build(java.util.Map<String, ?> map) {
            PutLiveChannelResponseCreateLiveChannelResultPlayUrls self = new PutLiveChannelResponseCreateLiveChannelResultPlayUrls();
            return TeaModel.build(map, self);
        }

        public PutLiveChannelResponseCreateLiveChannelResultPlayUrls setUrl(String url) {
            this.url = url;
            return this;
        }
        public String getUrl() {
            return this.url;
        }

    }

    public static class PutLiveChannelResponseCreateLiveChannelResult extends TeaModel {
        // PublishUrls
        @NameInMap("PublishUrls")
        @Validation(required = true)
        public PutLiveChannelResponseCreateLiveChannelResultPublishUrls publishUrls;

        // PlayUrls
        @NameInMap("PlayUrls")
        @Validation(required = true)
        public PutLiveChannelResponseCreateLiveChannelResultPlayUrls playUrls;

        public static PutLiveChannelResponseCreateLiveChannelResult build(java.util.Map<String, ?> map) {
            PutLiveChannelResponseCreateLiveChannelResult self = new PutLiveChannelResponseCreateLiveChannelResult();
            return TeaModel.build(map, self);
        }

        public PutLiveChannelResponseCreateLiveChannelResult setPublishUrls(PutLiveChannelResponseCreateLiveChannelResultPublishUrls publishUrls) {
            this.publishUrls = publishUrls;
            return this;
        }
        public PutLiveChannelResponseCreateLiveChannelResultPublishUrls getPublishUrls() {
            return this.publishUrls;
        }

        public PutLiveChannelResponseCreateLiveChannelResult setPlayUrls(PutLiveChannelResponseCreateLiveChannelResultPlayUrls playUrls) {
            this.playUrls = playUrls;
            return this;
        }
        public PutLiveChannelResponseCreateLiveChannelResultPlayUrls getPlayUrls() {
            return this.playUrls;
        }

    }

}
