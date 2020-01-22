// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class PutBucketCORSRequest extends TeaModel {
    @NameInMap("BucketName")
    @Validation(required = true)
    public String bucketName;

    @NameInMap("Body")
    public PutBucketCORSRequestBody body;

    public static PutBucketCORSRequest build(java.util.Map<String, ?> map) throws Exception {
        PutBucketCORSRequest self = new PutBucketCORSRequest();
        return TeaModel.build(map, self);
    }

    public static class PutBucketCORSRequestBodyCORSConfigurationCORSRule extends TeaModel {
        @NameInMap("AllowedOrigin")
        public String[] allowedOrigin;

        @NameInMap("AllowedMethod")
        public String[] allowedMethod;

        @NameInMap("AllowedHeader")
        public String[] allowedHeader;

        @NameInMap("ExposeHeader")
        public String[] exposeHeader;

        @NameInMap("MaxAgeSeconds")
        public String maxAgeSeconds;

        public static PutBucketCORSRequestBodyCORSConfigurationCORSRule build(java.util.Map<String, ?> map) throws Exception {
            PutBucketCORSRequestBodyCORSConfigurationCORSRule self = new PutBucketCORSRequestBodyCORSConfigurationCORSRule();
            return TeaModel.build(map, self);
        }

    }

    public static class PutBucketCORSRequestBodyCORSConfiguration extends TeaModel {
        @NameInMap("CORSRule")
        public PutBucketCORSRequestBodyCORSConfigurationCORSRule[] cORSRule;

        public static PutBucketCORSRequestBodyCORSConfiguration build(java.util.Map<String, ?> map) throws Exception {
            PutBucketCORSRequestBodyCORSConfiguration self = new PutBucketCORSRequestBodyCORSConfiguration();
            return TeaModel.build(map, self);
        }

    }

    public static class PutBucketCORSRequestBody extends TeaModel {
        @NameInMap("CORSConfiguration")
        @Validation(required = true)
        public PutBucketCORSRequestBodyCORSConfiguration cORSConfiguration;

        public static PutBucketCORSRequestBody build(java.util.Map<String, ?> map) throws Exception {
            PutBucketCORSRequestBody self = new PutBucketCORSRequestBody();
            return TeaModel.build(map, self);
        }

    }

}
