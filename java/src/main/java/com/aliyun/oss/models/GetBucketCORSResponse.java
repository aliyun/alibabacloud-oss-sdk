// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class GetBucketCORSResponse extends TeaModel {
    @NameInMap("x-oss-request-id")
    @Validation(required = true)
    public String requestId;

    @NameInMap("CORSConfiguration")
    @Validation(required = true)
    public GetBucketCORSResponseCORSConfiguration cORSConfiguration;

    public static GetBucketCORSResponse build(java.util.Map<String, ?> map) throws Exception {
        GetBucketCORSResponse self = new GetBucketCORSResponse();
        return TeaModel.build(map, self);
    }

    public static class GetBucketCORSResponseCORSConfigurationCORSRule extends TeaModel {
        @NameInMap("MaxAgeSeconds")
        public String maxAgeSeconds;

        public static GetBucketCORSResponseCORSConfigurationCORSRule build(java.util.Map<String, ?> map) throws Exception {
            GetBucketCORSResponseCORSConfigurationCORSRule self = new GetBucketCORSResponseCORSConfigurationCORSRule();
            return TeaModel.build(map, self);
        }

    }

    public static class GetBucketCORSResponseCORSConfiguration extends TeaModel {
        @NameInMap("CORSRule")
        public java.util.List<GetBucketCORSResponseCORSConfigurationCORSRule> cORSRule;

        public static GetBucketCORSResponseCORSConfiguration build(java.util.Map<String, ?> map) throws Exception {
            GetBucketCORSResponseCORSConfiguration self = new GetBucketCORSResponseCORSConfiguration();
            return TeaModel.build(map, self);
        }

    }

}
