// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class PutBucketLoggingRequest extends TeaModel {
    @NameInMap("BucketName")
    @Validation(required = true)
    public String bucketName;

    @NameInMap("Body")
    public PutBucketLoggingRequestBody body;

    public static PutBucketLoggingRequest build(java.util.Map<String, ?> map) throws Exception {
        PutBucketLoggingRequest self = new PutBucketLoggingRequest();
        return TeaModel.build(map, self);
    }

    public static class PutBucketLoggingRequestBodyBucketLoggingStatusLoggingEnabled extends TeaModel {
        @NameInMap("TargetBucket")
        public String targetBucket;

        @NameInMap("TargetPrefix")
        public String targetPrefix;

        public static PutBucketLoggingRequestBodyBucketLoggingStatusLoggingEnabled build(java.util.Map<String, ?> map) throws Exception {
            PutBucketLoggingRequestBodyBucketLoggingStatusLoggingEnabled self = new PutBucketLoggingRequestBodyBucketLoggingStatusLoggingEnabled();
            return TeaModel.build(map, self);
        }

    }

    public static class PutBucketLoggingRequestBodyBucketLoggingStatus extends TeaModel {
        @NameInMap("LoggingEnabled")
        public PutBucketLoggingRequestBodyBucketLoggingStatusLoggingEnabled loggingEnabled;

        public static PutBucketLoggingRequestBodyBucketLoggingStatus build(java.util.Map<String, ?> map) throws Exception {
            PutBucketLoggingRequestBodyBucketLoggingStatus self = new PutBucketLoggingRequestBodyBucketLoggingStatus();
            return TeaModel.build(map, self);
        }

    }

    public static class PutBucketLoggingRequestBody extends TeaModel {
        @NameInMap("BucketLoggingStatus")
        @Validation(required = true)
        public PutBucketLoggingRequestBodyBucketLoggingStatus bucketLoggingStatus;

        public static PutBucketLoggingRequestBody build(java.util.Map<String, ?> map) throws Exception {
            PutBucketLoggingRequestBody self = new PutBucketLoggingRequestBody();
            return TeaModel.build(map, self);
        }

    }

}
