// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class ListLiveChannelResponse extends TeaModel {
    // x-oss-request-id
    @NameInMap("x-oss-request-id")
    @Validation(required = true)
    public String requestId;

    // ListLiveChannelResult
    @NameInMap("ListLiveChannelResult")
    @Validation(required = true)
    public ListLiveChannelResponseListLiveChannelResult listLiveChannelResult;

    public static ListLiveChannelResponse build(java.util.Map<String, ?> map) throws Exception {
        ListLiveChannelResponse self = new ListLiveChannelResponse();
        return TeaModel.build(map, self);
    }

    public ListLiveChannelResponse setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public ListLiveChannelResponse setListLiveChannelResult(ListLiveChannelResponseListLiveChannelResult listLiveChannelResult) {
        this.listLiveChannelResult = listLiveChannelResult;
        return this;
    }
    public ListLiveChannelResponseListLiveChannelResult getListLiveChannelResult() {
        return this.listLiveChannelResult;
    }

    public static class ListLiveChannelResponseListLiveChannelResultLiveChannelPublishUrls extends TeaModel {
        // Url
        @NameInMap("Url")
        public String url;

        public static ListLiveChannelResponseListLiveChannelResultLiveChannelPublishUrls build(java.util.Map<String, ?> map) throws Exception {
            ListLiveChannelResponseListLiveChannelResultLiveChannelPublishUrls self = new ListLiveChannelResponseListLiveChannelResultLiveChannelPublishUrls();
            return TeaModel.build(map, self);
        }

        public ListLiveChannelResponseListLiveChannelResultLiveChannelPublishUrls setUrl(String url) {
            this.url = url;
            return this;
        }
        public String getUrl() {
            return this.url;
        }

    }

    public static class ListLiveChannelResponseListLiveChannelResultLiveChannelPlayUrls extends TeaModel {
        // Url
        @NameInMap("Url")
        public String url;

        public static ListLiveChannelResponseListLiveChannelResultLiveChannelPlayUrls build(java.util.Map<String, ?> map) throws Exception {
            ListLiveChannelResponseListLiveChannelResultLiveChannelPlayUrls self = new ListLiveChannelResponseListLiveChannelResultLiveChannelPlayUrls();
            return TeaModel.build(map, self);
        }

        public ListLiveChannelResponseListLiveChannelResultLiveChannelPlayUrls setUrl(String url) {
            this.url = url;
            return this;
        }
        public String getUrl() {
            return this.url;
        }

    }

    public static class ListLiveChannelResponseListLiveChannelResultLiveChannel extends TeaModel {
        // Name
        @NameInMap("Name")
        public String name;

        // Description
        @NameInMap("Description")
        public String description;

        // Status
        @NameInMap("Status")
        public String status;

        // LastModified
        @NameInMap("LastModified")
        public String lastModified;

        // PublishUrls
        @NameInMap("PublishUrls")
        @Validation(required = true)
        public ListLiveChannelResponseListLiveChannelResultLiveChannelPublishUrls publishUrls;

        // PlayUrls
        @NameInMap("PlayUrls")
        @Validation(required = true)
        public ListLiveChannelResponseListLiveChannelResultLiveChannelPlayUrls playUrls;

        public static ListLiveChannelResponseListLiveChannelResultLiveChannel build(java.util.Map<String, ?> map) throws Exception {
            ListLiveChannelResponseListLiveChannelResultLiveChannel self = new ListLiveChannelResponseListLiveChannelResultLiveChannel();
            return TeaModel.build(map, self);
        }

        public ListLiveChannelResponseListLiveChannelResultLiveChannel setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public ListLiveChannelResponseListLiveChannelResultLiveChannel setDescription(String description) {
            this.description = description;
            return this;
        }
        public String getDescription() {
            return this.description;
        }

        public ListLiveChannelResponseListLiveChannelResultLiveChannel setStatus(String status) {
            this.status = status;
            return this;
        }
        public String getStatus() {
            return this.status;
        }

        public ListLiveChannelResponseListLiveChannelResultLiveChannel setLastModified(String lastModified) {
            this.lastModified = lastModified;
            return this;
        }
        public String getLastModified() {
            return this.lastModified;
        }

        public ListLiveChannelResponseListLiveChannelResultLiveChannel setPublishUrls(ListLiveChannelResponseListLiveChannelResultLiveChannelPublishUrls publishUrls) {
            this.publishUrls = publishUrls;
            return this;
        }
        public ListLiveChannelResponseListLiveChannelResultLiveChannelPublishUrls getPublishUrls() {
            return this.publishUrls;
        }

        public ListLiveChannelResponseListLiveChannelResultLiveChannel setPlayUrls(ListLiveChannelResponseListLiveChannelResultLiveChannelPlayUrls playUrls) {
            this.playUrls = playUrls;
            return this;
        }
        public ListLiveChannelResponseListLiveChannelResultLiveChannelPlayUrls getPlayUrls() {
            return this.playUrls;
        }

    }

    public static class ListLiveChannelResponseListLiveChannelResult extends TeaModel {
        // Prefix
        @NameInMap("Prefix")
        public String prefix;

        // Marker
        @NameInMap("Marker")
        public String marker;

        // MaxKeys
        @NameInMap("MaxKeys")
        public String maxKeys;

        // IsTruncated
        @NameInMap("IsTruncated")
        public String isTruncated;

        // NextMarker
        @NameInMap("NextMarker")
        public String nextMarker;

        // LiveChannel
        @NameInMap("LiveChannel")
        @Validation(required = true)
        public ListLiveChannelResponseListLiveChannelResultLiveChannel liveChannel;

        public static ListLiveChannelResponseListLiveChannelResult build(java.util.Map<String, ?> map) throws Exception {
            ListLiveChannelResponseListLiveChannelResult self = new ListLiveChannelResponseListLiveChannelResult();
            return TeaModel.build(map, self);
        }

        public ListLiveChannelResponseListLiveChannelResult setPrefix(String prefix) {
            this.prefix = prefix;
            return this;
        }
        public String getPrefix() {
            return this.prefix;
        }

        public ListLiveChannelResponseListLiveChannelResult setMarker(String marker) {
            this.marker = marker;
            return this;
        }
        public String getMarker() {
            return this.marker;
        }

        public ListLiveChannelResponseListLiveChannelResult setMaxKeys(String maxKeys) {
            this.maxKeys = maxKeys;
            return this;
        }
        public String getMaxKeys() {
            return this.maxKeys;
        }

        public ListLiveChannelResponseListLiveChannelResult setIsTruncated(String isTruncated) {
            this.isTruncated = isTruncated;
            return this;
        }
        public String getIsTruncated() {
            return this.isTruncated;
        }

        public ListLiveChannelResponseListLiveChannelResult setNextMarker(String nextMarker) {
            this.nextMarker = nextMarker;
            return this;
        }
        public String getNextMarker() {
            return this.nextMarker;
        }

        public ListLiveChannelResponseListLiveChannelResult setLiveChannel(ListLiveChannelResponseListLiveChannelResultLiveChannel liveChannel) {
            this.liveChannel = liveChannel;
            return this;
        }
        public ListLiveChannelResponseListLiveChannelResultLiveChannel getLiveChannel() {
            return this.liveChannel;
        }

    }

}
