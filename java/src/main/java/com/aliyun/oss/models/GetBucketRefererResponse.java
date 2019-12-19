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

    public static class GetBucketRefererResponseRefererConfigurationRefererList extends TeaModel {
        @NameInMap("Referer")
        public String[] referer;

    }

    public static class GetBucketRefererResponseRefererConfiguration extends TeaModel {
        @NameInMap("AllowEmptyReferer")
        public boolean allowEmptyReferer;

        @NameInMap("RefererList")
        @Validation(required = true)
        public GetBucketRefererResponseRefererConfigurationRefererList refererList;

    }

}
