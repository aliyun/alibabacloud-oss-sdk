// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class PutBucketLoggingRequest extends TeaModel {
    // BucketName
    @NameInMap("BucketName")
    @Validation(required = true, pattern = "[a-zA-Z0-9-_]+")
    public String bucketName;

    // Body
    @NameInMap("Body")
    public PutBucketLoggingRequestBody body;

    public static PutBucketLoggingRequest build(java.util.Map<String, ?> map) throws Exception {
        PutBucketLoggingRequest self = new PutBucketLoggingRequest();
        return TeaModel.build(map, self);
    }

    public PutBucketLoggingRequest setBucketName(String bucketName) {
        this.bucketName = bucketName;
        return this;
    }
    public String getBucketName() {
        return this.bucketName;
    }

    public PutBucketLoggingRequest setBody(PutBucketLoggingRequestBody body) {
        this.body = body;
        return this;
    }
    public PutBucketLoggingRequestBody getBody() {
        return this.body;
    }

    public static class PutBucketLoggingRequestBodyBucketLoggingStatusLoggingEnabled extends TeaModel {
        // TargetBucket
        @NameInMap("TargetBucket")
        public String targetBucket;

        // TargetPrefix
        @NameInMap("TargetPrefix")
        public String targetPrefix;

        public static PutBucketLoggingRequestBodyBucketLoggingStatusLoggingEnabled build(java.util.Map<String, ?> map) throws Exception {
            PutBucketLoggingRequestBodyBucketLoggingStatusLoggingEnabled self = new PutBucketLoggingRequestBodyBucketLoggingStatusLoggingEnabled();
            return TeaModel.build(map, self);
        }

        public PutBucketLoggingRequestBodyBucketLoggingStatusLoggingEnabled setTargetBucket(String targetBucket) {
            this.targetBucket = targetBucket;
            return this;
        }
        public String getTargetBucket() {
            return this.targetBucket;
        }

        public PutBucketLoggingRequestBodyBucketLoggingStatusLoggingEnabled setTargetPrefix(String targetPrefix) {
            this.targetPrefix = targetPrefix;
            return this;
        }
        public String getTargetPrefix() {
            return this.targetPrefix;
        }

    }

    public static class PutBucketLoggingRequestBodyBucketLoggingStatus extends TeaModel {
        // LoggingEnabled
        @NameInMap("LoggingEnabled")
        public PutBucketLoggingRequestBodyBucketLoggingStatusLoggingEnabled loggingEnabled;

        public static PutBucketLoggingRequestBodyBucketLoggingStatus build(java.util.Map<String, ?> map) throws Exception {
            PutBucketLoggingRequestBodyBucketLoggingStatus self = new PutBucketLoggingRequestBodyBucketLoggingStatus();
            return TeaModel.build(map, self);
        }

        public PutBucketLoggingRequestBodyBucketLoggingStatus setLoggingEnabled(PutBucketLoggingRequestBodyBucketLoggingStatusLoggingEnabled loggingEnabled) {
            this.loggingEnabled = loggingEnabled;
            return this;
        }
        public PutBucketLoggingRequestBodyBucketLoggingStatusLoggingEnabled getLoggingEnabled() {
            return this.loggingEnabled;
        }

    }

    public static class PutBucketLoggingRequestBody extends TeaModel {
        // BucketLoggingStatus
        @NameInMap("BucketLoggingStatus")
        @Validation(required = true)
        public PutBucketLoggingRequestBodyBucketLoggingStatus bucketLoggingStatus;

        public static PutBucketLoggingRequestBody build(java.util.Map<String, ?> map) throws Exception {
            PutBucketLoggingRequestBody self = new PutBucketLoggingRequestBody();
            return TeaModel.build(map, self);
        }

        public PutBucketLoggingRequestBody setBucketLoggingStatus(PutBucketLoggingRequestBodyBucketLoggingStatus bucketLoggingStatus) {
            this.bucketLoggingStatus = bucketLoggingStatus;
            return this;
        }
        public PutBucketLoggingRequestBodyBucketLoggingStatus getBucketLoggingStatus() {
            return this.bucketLoggingStatus;
        }

    }

}
