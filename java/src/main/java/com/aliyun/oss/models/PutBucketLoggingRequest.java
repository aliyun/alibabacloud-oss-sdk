// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class PutBucketLoggingRequest extends TeaModel {
    @NameInMap("BucketName")
    @Validation(required = true)
    public String bucketName;

    @NameInMap("Body")
    public PutBucketLoggingRequestBody body;

    public static class PutBucketLoggingRequestBodyBucketLoggingStatusLoggingEnabled extends TeaModel {
        @NameInMap("TargetBucket")
        public String targetBucket;

        @NameInMap("TargetPrefix")
        public String targetPrefix;

    }

    public static class PutBucketLoggingRequestBodyBucketLoggingStatus extends TeaModel {
        @NameInMap("LoggingEnabled")
        public PutBucketLoggingRequestBodyBucketLoggingStatusLoggingEnabled loggingEnabled;

    }

    public static class PutBucketLoggingRequestBody extends TeaModel {
        @NameInMap("BucketLoggingStatus")
        @Validation(required = true)
        public PutBucketLoggingRequestBodyBucketLoggingStatus bucketLoggingStatus;

    }

}
