// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.OSS.Models
{
    public class GetBucketLoggingResponse : TeaModel {
        [NameInMap("x-oss-request-id")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("BucketLoggingStatus")]
        [Validation(Required=true)]
        public GetBucketLoggingResponseBucketLoggingStatus BucketLoggingStatus { get; set; }
        public class GetBucketLoggingResponseBucketLoggingStatus : TeaModel {
            [NameInMap("LoggingEnabled")]
            [Validation(Required=true)]
            public GetBucketLoggingResponseLoggingEnabled LoggingEnabled { get; set; }
            public class GetBucketLoggingResponseLoggingEnabled : TeaModel {
                [NameInMap("TargetBucket")]
                [Validation(Required=true)]
                public string TargetBucket { get; set; }

                [NameInMap("TargetPrefix")]
                [Validation(Required=true)]
                public string TargetPrefix { get; set; }

            }
        };

    }

}
