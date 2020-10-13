// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class GetBucketRefererResponse extends TeaModel {
    // x-oss-request-id
    @NameInMap("x-oss-request-id")
    @Validation(required = true)
    public String requestId;

    // RefererConfiguration
    @NameInMap("RefererConfiguration")
    @Validation(required = true)
    public GetBucketRefererResponseRefererConfiguration refererConfiguration;

    public static GetBucketRefererResponse build(java.util.Map<String, ?> map) throws Exception {
        GetBucketRefererResponse self = new GetBucketRefererResponse();
        return TeaModel.build(map, self);
    }

    public GetBucketRefererResponse setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public GetBucketRefererResponse setRefererConfiguration(GetBucketRefererResponseRefererConfiguration refererConfiguration) {
        this.refererConfiguration = refererConfiguration;
        return this;
    }
    public GetBucketRefererResponseRefererConfiguration getRefererConfiguration() {
        return this.refererConfiguration;
    }

    public static class GetBucketRefererResponseRefererConfigurationRefererList extends TeaModel {
        // Referer
        @NameInMap("Referer")
        public java.util.List<String> referer;

        public static GetBucketRefererResponseRefererConfigurationRefererList build(java.util.Map<String, ?> map) throws Exception {
            GetBucketRefererResponseRefererConfigurationRefererList self = new GetBucketRefererResponseRefererConfigurationRefererList();
            return TeaModel.build(map, self);
        }

        public GetBucketRefererResponseRefererConfigurationRefererList setReferer(java.util.List<String> referer) {
            this.referer = referer;
            return this;
        }
        public java.util.List<String> getReferer() {
            return this.referer;
        }

    }

    public static class GetBucketRefererResponseRefererConfiguration extends TeaModel {
        // AllowEmptyReferer
        @NameInMap("AllowEmptyReferer")
        public Boolean allowEmptyReferer;

        // RefererList
        @NameInMap("RefererList")
        @Validation(required = true)
        public GetBucketRefererResponseRefererConfigurationRefererList refererList;

        public static GetBucketRefererResponseRefererConfiguration build(java.util.Map<String, ?> map) throws Exception {
            GetBucketRefererResponseRefererConfiguration self = new GetBucketRefererResponseRefererConfiguration();
            return TeaModel.build(map, self);
        }

        public GetBucketRefererResponseRefererConfiguration setAllowEmptyReferer(Boolean allowEmptyReferer) {
            this.allowEmptyReferer = allowEmptyReferer;
            return this;
        }
        public Boolean getAllowEmptyReferer() {
            return this.allowEmptyReferer;
        }

        public GetBucketRefererResponseRefererConfiguration setRefererList(GetBucketRefererResponseRefererConfigurationRefererList refererList) {
            this.refererList = refererList;
            return this;
        }
        public GetBucketRefererResponseRefererConfigurationRefererList getRefererList() {
            return this.refererList;
        }

    }

}
