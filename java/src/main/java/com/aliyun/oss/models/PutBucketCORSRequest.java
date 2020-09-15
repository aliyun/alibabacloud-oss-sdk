// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class PutBucketCORSRequest extends TeaModel {
    // BucketName
    @NameInMap("BucketName")
    @Validation(required = true)
    public String bucketName;

    // Body
    @NameInMap("Body")
    public PutBucketCORSRequestBody body;

    public static PutBucketCORSRequest build(java.util.Map<String, ?> map) {
        PutBucketCORSRequest self = new PutBucketCORSRequest();
        return TeaModel.build(map, self);
    }

    public PutBucketCORSRequest setBucketName(String bucketName) {
        this.bucketName = bucketName;
        return this;
    }
    public String getBucketName() {
        return this.bucketName;
    }

    public PutBucketCORSRequest setBody(PutBucketCORSRequestBody body) {
        this.body = body;
        return this;
    }
    public PutBucketCORSRequestBody getBody() {
        return this.body;
    }

    public static class PutBucketCORSRequestBodyCORSConfigurationCORSRule extends TeaModel {
        // AllowedOrigin
        @NameInMap("AllowedOrigin")
        public java.util.List<String> allowedOrigin;

        // AllowedMethod
        @NameInMap("AllowedMethod")
        public java.util.List<String> allowedMethod;

        // AllowedHeader
        @NameInMap("AllowedHeader")
        public java.util.List<String> allowedHeader;

        // ExposeHeader
        @NameInMap("ExposeHeader")
        public java.util.List<String> exposeHeader;

        // MaxAgeSeconds
        @NameInMap("MaxAgeSeconds")
        public String maxAgeSeconds;

        public static PutBucketCORSRequestBodyCORSConfigurationCORSRule build(java.util.Map<String, ?> map) {
            PutBucketCORSRequestBodyCORSConfigurationCORSRule self = new PutBucketCORSRequestBodyCORSConfigurationCORSRule();
            return TeaModel.build(map, self);
        }

        public PutBucketCORSRequestBodyCORSConfigurationCORSRule setAllowedOrigin(java.util.List<String> allowedOrigin) {
            this.allowedOrigin = allowedOrigin;
            return this;
        }
        public java.util.List<String> getAllowedOrigin() {
            return this.allowedOrigin;
        }

        public PutBucketCORSRequestBodyCORSConfigurationCORSRule setAllowedMethod(java.util.List<String> allowedMethod) {
            this.allowedMethod = allowedMethod;
            return this;
        }
        public java.util.List<String> getAllowedMethod() {
            return this.allowedMethod;
        }

        public PutBucketCORSRequestBodyCORSConfigurationCORSRule setAllowedHeader(java.util.List<String> allowedHeader) {
            this.allowedHeader = allowedHeader;
            return this;
        }
        public java.util.List<String> getAllowedHeader() {
            return this.allowedHeader;
        }

        public PutBucketCORSRequestBodyCORSConfigurationCORSRule setExposeHeader(java.util.List<String> exposeHeader) {
            this.exposeHeader = exposeHeader;
            return this;
        }
        public java.util.List<String> getExposeHeader() {
            return this.exposeHeader;
        }

        public PutBucketCORSRequestBodyCORSConfigurationCORSRule setMaxAgeSeconds(String maxAgeSeconds) {
            this.maxAgeSeconds = maxAgeSeconds;
            return this;
        }
        public String getMaxAgeSeconds() {
            return this.maxAgeSeconds;
        }

    }

    public static class PutBucketCORSRequestBodyCORSConfiguration extends TeaModel {
        // CORSRule
        @NameInMap("CORSRule")
        public java.util.List<PutBucketCORSRequestBodyCORSConfigurationCORSRule> cORSRule;

        public static PutBucketCORSRequestBodyCORSConfiguration build(java.util.Map<String, ?> map) {
            PutBucketCORSRequestBodyCORSConfiguration self = new PutBucketCORSRequestBodyCORSConfiguration();
            return TeaModel.build(map, self);
        }

        public PutBucketCORSRequestBodyCORSConfiguration setCORSRule(java.util.List<PutBucketCORSRequestBodyCORSConfigurationCORSRule> cORSRule) {
            this.cORSRule = cORSRule;
            return this;
        }
        public java.util.List<PutBucketCORSRequestBodyCORSConfigurationCORSRule> getCORSRule() {
            return this.cORSRule;
        }

    }

    public static class PutBucketCORSRequestBody extends TeaModel {
        // CORSConfiguration
        @NameInMap("CORSConfiguration")
        @Validation(required = true)
        public PutBucketCORSRequestBodyCORSConfiguration cORSConfiguration;

        public static PutBucketCORSRequestBody build(java.util.Map<String, ?> map) {
            PutBucketCORSRequestBody self = new PutBucketCORSRequestBody();
            return TeaModel.build(map, self);
        }

        public PutBucketCORSRequestBody setCORSConfiguration(PutBucketCORSRequestBodyCORSConfiguration cORSConfiguration) {
            this.cORSConfiguration = cORSConfiguration;
            return this;
        }
        public PutBucketCORSRequestBodyCORSConfiguration getCORSConfiguration() {
            return this.cORSConfiguration;
        }

    }

}
