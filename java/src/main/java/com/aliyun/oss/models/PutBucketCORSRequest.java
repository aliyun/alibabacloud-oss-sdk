// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class PutBucketCORSRequest extends TeaModel {
    @NameInMap("BucketName")
    @Validation(required = true)
    public String bucketName;

    @NameInMap("Body")
    public PutBucketCORSRequestBody body;

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

    }

    public static class PutBucketCORSRequestBodyCORSConfiguration extends TeaModel {
        @NameInMap("CORSRule")
        public PutBucketCORSRequestBodyCORSConfigurationCORSRule[] cORSRule;

    }

    public static class PutBucketCORSRequestBody extends TeaModel {
        @NameInMap("CORSConfiguration")
        @Validation(required = true)
        public PutBucketCORSRequestBodyCORSConfiguration cORSConfiguration;

    }

}
