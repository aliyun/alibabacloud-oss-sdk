// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class GetBucketCORSResponse extends TeaModel {
    // x-oss-request-id
    @NameInMap("x-oss-request-id")
    @Validation(required = true)
    public String requestId;

    // CORSConfiguration
    @NameInMap("CORSConfiguration")
    @Validation(required = true)
    public GetBucketCORSResponseCORSConfiguration cORSConfiguration;

    public static GetBucketCORSResponse build(java.util.Map<String, ?> map) throws Exception {
        GetBucketCORSResponse self = new GetBucketCORSResponse();
        return TeaModel.build(map, self);
    }

    public GetBucketCORSResponse setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public GetBucketCORSResponse setCORSConfiguration(GetBucketCORSResponseCORSConfiguration cORSConfiguration) {
        this.cORSConfiguration = cORSConfiguration;
        return this;
    }
    public GetBucketCORSResponseCORSConfiguration getCORSConfiguration() {
        return this.cORSConfiguration;
    }

    public static class GetBucketCORSResponseCORSConfigurationCORSRule extends TeaModel {
        // MaxAgeSeconds
        @NameInMap("MaxAgeSeconds")
        public String maxAgeSeconds;

        public static GetBucketCORSResponseCORSConfigurationCORSRule build(java.util.Map<String, ?> map) throws Exception {
            GetBucketCORSResponseCORSConfigurationCORSRule self = new GetBucketCORSResponseCORSConfigurationCORSRule();
            return TeaModel.build(map, self);
        }

        public GetBucketCORSResponseCORSConfigurationCORSRule setMaxAgeSeconds(String maxAgeSeconds) {
            this.maxAgeSeconds = maxAgeSeconds;
            return this;
        }
        public String getMaxAgeSeconds() {
            return this.maxAgeSeconds;
        }

    }

    public static class GetBucketCORSResponseCORSConfiguration extends TeaModel {
        // CORSRule
        @NameInMap("CORSRule")
        public java.util.List<GetBucketCORSResponseCORSConfigurationCORSRule> cORSRule;

        public static GetBucketCORSResponseCORSConfiguration build(java.util.Map<String, ?> map) throws Exception {
            GetBucketCORSResponseCORSConfiguration self = new GetBucketCORSResponseCORSConfiguration();
            return TeaModel.build(map, self);
        }

        public GetBucketCORSResponseCORSConfiguration setCORSRule(java.util.List<GetBucketCORSResponseCORSConfigurationCORSRule> cORSRule) {
            this.cORSRule = cORSRule;
            return this;
        }
        public java.util.List<GetBucketCORSResponseCORSConfigurationCORSRule> getCORSRule() {
            return this.cORSRule;
        }

    }

}
