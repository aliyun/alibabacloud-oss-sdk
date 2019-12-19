// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class PutBucketRefererRequest extends TeaModel {
    @NameInMap("BucketName")
    @Validation(required = true)
    public String bucketName;

    @NameInMap("Body")
    public PutBucketRefererRequestBody body;

    public static class PutBucketRefererRequestBodyRefererConfigurationRefererList extends TeaModel {
        @NameInMap("Referer")
        public String[] referer;

    }

    public static class PutBucketRefererRequestBodyRefererConfiguration extends TeaModel {
        @NameInMap("RefererList")
        public PutBucketRefererRequestBodyRefererConfigurationRefererList refererList;

        @NameInMap("AllowEmptyReferer")
        public boolean allowEmptyReferer;

    }

    public static class PutBucketRefererRequestBody extends TeaModel {
        @NameInMap("RefererConfiguration")
        @Validation(required = true)
        public PutBucketRefererRequestBodyRefererConfiguration refererConfiguration;

    }

}
