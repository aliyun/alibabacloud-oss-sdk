// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class PutBucketRefererRequest extends TeaModel {
    @NameInMap("BucketName")
    @Validation(required = true)
    public String bucketName;

    @NameInMap("Body")
    public PutBucketRefererRequestBody body;

    public static PutBucketRefererRequest build(java.util.Map<String, ?> map) throws Exception {
        PutBucketRefererRequest self = new PutBucketRefererRequest();
        return TeaModel.build(map, self);
    }

    public static class PutBucketRefererRequestBodyRefererConfigurationRefererList extends TeaModel {
        @NameInMap("Referer")
        public String[] referer;

        public static PutBucketRefererRequestBodyRefererConfigurationRefererList build(java.util.Map<String, ?> map) throws Exception {
            PutBucketRefererRequestBodyRefererConfigurationRefererList self = new PutBucketRefererRequestBodyRefererConfigurationRefererList();
            return TeaModel.build(map, self);
        }

    }

    public static class PutBucketRefererRequestBodyRefererConfiguration extends TeaModel {
        @NameInMap("RefererList")
        public PutBucketRefererRequestBodyRefererConfigurationRefererList refererList;

        @NameInMap("AllowEmptyReferer")
        public boolean allowEmptyReferer;

        public static PutBucketRefererRequestBodyRefererConfiguration build(java.util.Map<String, ?> map) throws Exception {
            PutBucketRefererRequestBodyRefererConfiguration self = new PutBucketRefererRequestBodyRefererConfiguration();
            return TeaModel.build(map, self);
        }

    }

    public static class PutBucketRefererRequestBody extends TeaModel {
        @NameInMap("RefererConfiguration")
        @Validation(required = true)
        public PutBucketRefererRequestBodyRefererConfiguration refererConfiguration;

        public static PutBucketRefererRequestBody build(java.util.Map<String, ?> map) throws Exception {
            PutBucketRefererRequestBody self = new PutBucketRefererRequestBody();
            return TeaModel.build(map, self);
        }

    }

}
