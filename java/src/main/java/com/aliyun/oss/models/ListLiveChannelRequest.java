// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class ListLiveChannelRequest extends TeaModel {
    // BucketName
    @NameInMap("BucketName")
    @Validation(required = true)
    public String bucketName;

    // Filter
    @NameInMap("Filter")
    public ListLiveChannelRequestFilter filter;

    public static ListLiveChannelRequest build(java.util.Map<String, ?> map) {
        ListLiveChannelRequest self = new ListLiveChannelRequest();
        return TeaModel.build(map, self);
    }

    public ListLiveChannelRequest setBucketName(String bucketName) {
        this.bucketName = bucketName;
        return this;
    }
    public String getBucketName() {
        return this.bucketName;
    }

    public ListLiveChannelRequest setFilter(ListLiveChannelRequestFilter filter) {
        this.filter = filter;
        return this;
    }
    public ListLiveChannelRequestFilter getFilter() {
        return this.filter;
    }

    public static class ListLiveChannelRequestFilter extends TeaModel {
        // marker
        @NameInMap("marker")
        public String marker;

        // max-keys
        @NameInMap("max-keys")
        public String maxKeys;

        // prefix
        @NameInMap("prefix")
        public String prefix;

        public static ListLiveChannelRequestFilter build(java.util.Map<String, ?> map) {
            ListLiveChannelRequestFilter self = new ListLiveChannelRequestFilter();
            return TeaModel.build(map, self);
        }

        public ListLiveChannelRequestFilter setMarker(String marker) {
            this.marker = marker;
            return this;
        }
        public String getMarker() {
            return this.marker;
        }

        public ListLiveChannelRequestFilter setMaxKeys(String maxKeys) {
            this.maxKeys = maxKeys;
            return this;
        }
        public String getMaxKeys() {
            return this.maxKeys;
        }

        public ListLiveChannelRequestFilter setPrefix(String prefix) {
            this.prefix = prefix;
            return this;
        }
        public String getPrefix() {
            return this.prefix;
        }

    }

}
