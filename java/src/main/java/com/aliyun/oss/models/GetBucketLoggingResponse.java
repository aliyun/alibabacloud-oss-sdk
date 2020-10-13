// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class GetBucketLoggingResponse extends TeaModel {
    // x-oss-request-id
    @NameInMap("x-oss-request-id")
    @Validation(required = true)
    public String requestId;

    // BucketLoggingStatus
    @NameInMap("BucketLoggingStatus")
    @Validation(required = true)
    public GetBucketLoggingResponseBucketLoggingStatus bucketLoggingStatus;

    public static GetBucketLoggingResponse build(java.util.Map<String, ?> map) throws Exception {
        GetBucketLoggingResponse self = new GetBucketLoggingResponse();
        return TeaModel.build(map, self);
    }

    public GetBucketLoggingResponse setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public GetBucketLoggingResponse setBucketLoggingStatus(GetBucketLoggingResponseBucketLoggingStatus bucketLoggingStatus) {
        this.bucketLoggingStatus = bucketLoggingStatus;
        return this;
    }
    public GetBucketLoggingResponseBucketLoggingStatus getBucketLoggingStatus() {
        return this.bucketLoggingStatus;
    }

    public static class GetBucketLoggingResponseBucketLoggingStatusLoggingEnabled extends TeaModel {
        // TargetBucket
        @NameInMap("TargetBucket")
        public String targetBucket;

        // TargetPrefix
        @NameInMap("TargetPrefix")
        public String targetPrefix;

        public static GetBucketLoggingResponseBucketLoggingStatusLoggingEnabled build(java.util.Map<String, ?> map) throws Exception {
            GetBucketLoggingResponseBucketLoggingStatusLoggingEnabled self = new GetBucketLoggingResponseBucketLoggingStatusLoggingEnabled();
            return TeaModel.build(map, self);
        }

        public GetBucketLoggingResponseBucketLoggingStatusLoggingEnabled setTargetBucket(String targetBucket) {
            this.targetBucket = targetBucket;
            return this;
        }
        public String getTargetBucket() {
            return this.targetBucket;
        }

        public GetBucketLoggingResponseBucketLoggingStatusLoggingEnabled setTargetPrefix(String targetPrefix) {
            this.targetPrefix = targetPrefix;
            return this;
        }
        public String getTargetPrefix() {
            return this.targetPrefix;
        }

    }

    public static class GetBucketLoggingResponseBucketLoggingStatus extends TeaModel {
        // LoggingEnabled
        @NameInMap("LoggingEnabled")
        @Validation(required = true)
        public GetBucketLoggingResponseBucketLoggingStatusLoggingEnabled loggingEnabled;

        public static GetBucketLoggingResponseBucketLoggingStatus build(java.util.Map<String, ?> map) throws Exception {
            GetBucketLoggingResponseBucketLoggingStatus self = new GetBucketLoggingResponseBucketLoggingStatus();
            return TeaModel.build(map, self);
        }

        public GetBucketLoggingResponseBucketLoggingStatus setLoggingEnabled(GetBucketLoggingResponseBucketLoggingStatusLoggingEnabled loggingEnabled) {
            this.loggingEnabled = loggingEnabled;
            return this;
        }
        public GetBucketLoggingResponseBucketLoggingStatusLoggingEnabled getLoggingEnabled() {
            return this.loggingEnabled;
        }

    }

}
