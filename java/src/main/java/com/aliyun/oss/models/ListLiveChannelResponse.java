// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

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
        public String url;

    }

    public static class ListLiveChannelResponseListLiveChannelResultLiveChannelPlayUrls extends TeaModel {
        @NameInMap("Url")
        public String url;

    }

    public static class ListLiveChannelResponseListLiveChannelResultLiveChannel extends TeaModel {
        @NameInMap("Name")
        public String name;

        @NameInMap("Description")
        public String description;

        @NameInMap("Status")
        public String status;

        @NameInMap("LastModified")
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
        public String prefix;

        @NameInMap("Marker")
        public String marker;

        @NameInMap("MaxKeys")
        public String maxKeys;

        @NameInMap("IsTruncated")
        public String isTruncated;

        @NameInMap("NextMarker")
        public String nextMarker;

        @NameInMap("LiveChannel")
        @Validation(required = true)
        public ListLiveChannelResponseListLiveChannelResultLiveChannel liveChannel;

    }

}
