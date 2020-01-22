// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class PutLiveChannelResponse extends TeaModel {
    @NameInMap("x-oss-request-id")
    @Validation(required = true)
    public String requestId;

    @NameInMap("CreateLiveChannelResult")
    @Validation(required = true)
    public PutLiveChannelResponseCreateLiveChannelResult createLiveChannelResult;

    public static PutLiveChannelResponse build(java.util.Map<String, ?> map) throws Exception {
        PutLiveChannelResponse self = new PutLiveChannelResponse();
        return TeaModel.build(map, self);
    }

    public static class PutLiveChannelResponseCreateLiveChannelResultPublishUrls extends TeaModel {
        @NameInMap("Url")
        public String url;

        public static PutLiveChannelResponseCreateLiveChannelResultPublishUrls build(java.util.Map<String, ?> map) throws Exception {
            PutLiveChannelResponseCreateLiveChannelResultPublishUrls self = new PutLiveChannelResponseCreateLiveChannelResultPublishUrls();
            return TeaModel.build(map, self);
        }

    }

    public static class PutLiveChannelResponseCreateLiveChannelResultPlayUrls extends TeaModel {
        @NameInMap("Url")
        public String url;

        public static PutLiveChannelResponseCreateLiveChannelResultPlayUrls build(java.util.Map<String, ?> map) throws Exception {
            PutLiveChannelResponseCreateLiveChannelResultPlayUrls self = new PutLiveChannelResponseCreateLiveChannelResultPlayUrls();
            return TeaModel.build(map, self);
        }

    }

    public static class PutLiveChannelResponseCreateLiveChannelResult extends TeaModel {
        @NameInMap("PublishUrls")
        @Validation(required = true)
        public PutLiveChannelResponseCreateLiveChannelResultPublishUrls publishUrls;

        @NameInMap("PlayUrls")
        @Validation(required = true)
        public PutLiveChannelResponseCreateLiveChannelResultPlayUrls playUrls;

        public static PutLiveChannelResponseCreateLiveChannelResult build(java.util.Map<String, ?> map) throws Exception {
            PutLiveChannelResponseCreateLiveChannelResult self = new PutLiveChannelResponseCreateLiveChannelResult();
            return TeaModel.build(map, self);
        }

    }

}
