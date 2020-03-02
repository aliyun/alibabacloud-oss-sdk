// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class GetBucketRefererResponse extends TeaModel {
    @NameInMap("x-oss-request-id")
    @Validation(required = true)
    public String requestId;

    @NameInMap("RefererConfiguration")
    @Validation(required = true)
    public GetBucketRefererResponseRefererConfiguration refererConfiguration;

    public static GetBucketRefererResponse build(java.util.Map<String, ?> map) throws Exception {
        GetBucketRefererResponse self = new GetBucketRefererResponse();
        return TeaModel.build(map, self);
    }

    public static class GetBucketRefererResponseRefererConfigurationRefererList extends TeaModel {
        @NameInMap("Referer")
        public java.util.List<String> referer;

        public static GetBucketRefererResponseRefererConfigurationRefererList build(java.util.Map<String, ?> map) throws Exception {
            GetBucketRefererResponseRefererConfigurationRefererList self = new GetBucketRefererResponseRefererConfigurationRefererList();
            return TeaModel.build(map, self);
        }

    }

    public static class GetBucketRefererResponseRefererConfiguration extends TeaModel {
        @NameInMap("AllowEmptyReferer")
        public Boolean allowEmptyReferer;

        @NameInMap("RefererList")
        @Validation(required = true)
        public GetBucketRefererResponseRefererConfigurationRefererList refererList;

        public static GetBucketRefererResponseRefererConfiguration build(java.util.Map<String, ?> map) throws Exception {
            GetBucketRefererResponseRefererConfiguration self = new GetBucketRefererResponseRefererConfiguration();
            return TeaModel.build(map, self);
        }

    }

}
