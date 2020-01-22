// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class GetBucketLoggingResponse extends TeaModel {
    @NameInMap("x-oss-request-id")
    @Validation(required = true)
    public String requestId;

    @NameInMap("BucketLoggingStatus")
    @Validation(required = true)
    public GetBucketLoggingResponseBucketLoggingStatus bucketLoggingStatus;

    public static GetBucketLoggingResponse build(java.util.Map<String, ?> map) throws Exception {
        GetBucketLoggingResponse self = new GetBucketLoggingResponse();
        return TeaModel.build(map, self);
    }

    public static class GetBucketLoggingResponseBucketLoggingStatusLoggingEnabled extends TeaModel {
        @NameInMap("TargetBucket")
        public String targetBucket;

        @NameInMap("TargetPrefix")
        public String targetPrefix;

        public static GetBucketLoggingResponseBucketLoggingStatusLoggingEnabled build(java.util.Map<String, ?> map) throws Exception {
            GetBucketLoggingResponseBucketLoggingStatusLoggingEnabled self = new GetBucketLoggingResponseBucketLoggingStatusLoggingEnabled();
            return TeaModel.build(map, self);
        }

    }

    public static class GetBucketLoggingResponseBucketLoggingStatus extends TeaModel {
        @NameInMap("LoggingEnabled")
        @Validation(required = true)
        public GetBucketLoggingResponseBucketLoggingStatusLoggingEnabled loggingEnabled;

        public static GetBucketLoggingResponseBucketLoggingStatus build(java.util.Map<String, ?> map) throws Exception {
            GetBucketLoggingResponseBucketLoggingStatus self = new GetBucketLoggingResponseBucketLoggingStatus();
            return TeaModel.build(map, self);
        }

    }

}
