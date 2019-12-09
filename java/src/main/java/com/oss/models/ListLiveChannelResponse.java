// This file is auto-generated, don't edit it. Thanks.
package com.oss.models;

import com.aliyun.tea.*;

public class ListLiveChannelResponse extends TeaModel {
    @NameInMap("x-oss-request-id")
    @Validation(required = true)
    public String requestId;

    @NameInMap("ListLiveChannelResult")
    @Validation(required = true)
    public ListLiveChannelResponseListLiveChannelResult listLiveChannelResult;

    public static class ListLiveChannelResponseListLiveChannelResultLiveChannelPublishUrls extends TeaModel {
        @NameInMap("Url")
        @Validation(required = true)
        public String url;

    }

    public static class ListLiveChannelResponseListLiveChannelResultLiveChannelPlayUrls extends TeaModel {
        @NameInMap("Url")
        @Validation(required = true)
        public String url;

    }

    public static class ListLiveChannelResponseListLiveChannelResultLiveChannel extends TeaModel {
        @NameInMap("Name")
        @Validation(required = true)
        public String name;

        @NameInMap("Description")
        @Validation(required = true)
        public String description;

        @NameInMap("Status")
        @Validation(required = true)
        public String status;

        @NameInMap("LastModified")
        @Validation(required = true)
        public String lastModified;

        @NameInMap("PublishUrls")
        @Validation(required = true)
        public ListLiveChannelResponseListLiveChannelResultLiveChannelPublishUrls publishUrls;

        @NameInMap("PlayUrls")
        @Validation(required = true)
        public ListLiveChannelResponseListLiveChannelResultLiveChannelPlayUrls playUrls;

    }

    public static class ListLiveChannelResponseListLiveChannelResult extends TeaModel {
        @NameInMap("Prefix")
        @Validation(required = true)
        public String prefix;

        @NameInMap("Marker")
        @Validation(required = true)
        public String marker;

        @NameInMap("MaxKeys")
        @Validation(required = true)
        public String maxKeys;

        @NameInMap("IsTruncated")
        @Validation(required = true)
        public String isTruncated;

        @NameInMap("NextMarker")
        @Validation(required = true)
        public String nextMarker;

        @NameInMap("LiveChannel")
        @Validation(required = true)
        public ListLiveChannelResponseListLiveChannelResultLiveChannel liveChannel;

    }

}
