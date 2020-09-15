// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class PutBucketRefererRequest extends TeaModel {
    // BucketName
    @NameInMap("BucketName")
    @Validation(required = true)
    public String bucketName;

    // Body
    @NameInMap("Body")
    public PutBucketRefererRequestBody body;

    public static PutBucketRefererRequest build(java.util.Map<String, ?> map) {
        PutBucketRefererRequest self = new PutBucketRefererRequest();
        return TeaModel.build(map, self);
    }

    public PutBucketRefererRequest setBucketName(String bucketName) {
        this.bucketName = bucketName;
        return this;
    }
    public String getBucketName() {
        return this.bucketName;
    }

    public PutBucketRefererRequest setBody(PutBucketRefererRequestBody body) {
        this.body = body;
        return this;
    }
    public PutBucketRefererRequestBody getBody() {
        return this.body;
    }

    public static class PutBucketRefererRequestBodyRefererConfigurationRefererList extends TeaModel {
        // Referer
        @NameInMap("Referer")
        public java.util.List<String> referer;

        public static PutBucketRefererRequestBodyRefererConfigurationRefererList build(java.util.Map<String, ?> map) {
            PutBucketRefererRequestBodyRefererConfigurationRefererList self = new PutBucketRefererRequestBodyRefererConfigurationRefererList();
            return TeaModel.build(map, self);
        }

        public PutBucketRefererRequestBodyRefererConfigurationRefererList setReferer(java.util.List<String> referer) {
            this.referer = referer;
            return this;
        }
        public java.util.List<String> getReferer() {
            return this.referer;
        }

    }

    public static class PutBucketRefererRequestBodyRefererConfiguration extends TeaModel {
        // RefererList
        @NameInMap("RefererList")
        public PutBucketRefererRequestBodyRefererConfigurationRefererList refererList;

        // AllowEmptyReferer
        @NameInMap("AllowEmptyReferer")
        public Boolean allowEmptyReferer;

        public static PutBucketRefererRequestBodyRefererConfiguration build(java.util.Map<String, ?> map) {
            PutBucketRefererRequestBodyRefererConfiguration self = new PutBucketRefererRequestBodyRefererConfiguration();
            return TeaModel.build(map, self);
        }

        public PutBucketRefererRequestBodyRefererConfiguration setRefererList(PutBucketRefererRequestBodyRefererConfigurationRefererList refererList) {
            this.refererList = refererList;
            return this;
        }
        public PutBucketRefererRequestBodyRefererConfigurationRefererList getRefererList() {
            return this.refererList;
        }

        public PutBucketRefererRequestBodyRefererConfiguration setAllowEmptyReferer(Boolean allowEmptyReferer) {
            this.allowEmptyReferer = allowEmptyReferer;
            return this;
        }
        public Boolean getAllowEmptyReferer() {
            return this.allowEmptyReferer;
        }

    }

    public static class PutBucketRefererRequestBody extends TeaModel {
        // RefererConfiguration
        @NameInMap("RefererConfiguration")
        @Validation(required = true)
        public PutBucketRefererRequestBodyRefererConfiguration refererConfiguration;

        public static PutBucketRefererRequestBody build(java.util.Map<String, ?> map) {
            PutBucketRefererRequestBody self = new PutBucketRefererRequestBody();
            return TeaModel.build(map, self);
        }

        public PutBucketRefererRequestBody setRefererConfiguration(PutBucketRefererRequestBodyRefererConfiguration refererConfiguration) {
            this.refererConfiguration = refererConfiguration;
            return this;
        }
        public PutBucketRefererRequestBodyRefererConfiguration getRefererConfiguration() {
            return this.refererConfiguration;
        }

    }

}
