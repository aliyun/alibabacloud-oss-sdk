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

    public static class PutLiveChannelResponseCreateLiveChannelResultPublishUrls extends TeaModel {
        @NameInMap("Url")
        public String url;

    }

    public static class PutLiveChannelResponseCreateLiveChannelResultPlayUrls extends TeaModel {
        @NameInMap("Url")
        public String url;

    }

    public static class PutLiveChannelResponseCreateLiveChannelResult extends TeaModel {
        @NameInMap("PublishUrls")
        @Validation(required = true)
        public PutLiveChannelResponseCreateLiveChannelResultPublishUrls publishUrls;

        @NameInMap("PlayUrls")
        @Validation(required = true)
        public PutLiveChannelResponseCreateLiveChannelResultPlayUrls playUrls;

    }

}
