// This file is auto-generated, don't edit it. Thanks.
package com.oss.models;

import com.aliyun.tea.*;

public class GetBucketLoggingResponse extends TeaModel {
    @NameInMap("x-oss-request-id")
    @Validation(required = true)
    public String requestId;

    @NameInMap("BucketLoggingStatus")
    @Validation(required = true)
    public GetBucketLoggingResponseBucketLoggingStatus bucketLoggingStatus;

    public static class GetBucketLoggingResponseBucketLoggingStatusLoggingEnabled extends TeaModel {
        @NameInMap("TargetBucket")
        @Validation(required = true)
        public String targetBucket;

        @NameInMap("TargetPrefix")
        @Validation(required = true)
        public String targetPrefix;

    }

    public static class GetBucketLoggingResponseBucketLoggingStatus extends TeaModel {
        @NameInMap("LoggingEnabled")
        @Validation(required = true)
        public GetBucketLoggingResponseBucketLoggingStatusLoggingEnabled loggingEnabled;

    }

}
