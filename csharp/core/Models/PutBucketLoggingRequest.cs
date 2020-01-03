// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.OSS.Models
{
    public class PutBucketLoggingRequest : TeaModel {
        [NameInMap("BucketName")]
        [Validation(Required=true)]
        public string BucketName { get; set; }

        [NameInMap("Body")]
        [Validation(Required=false)]
        public PutBucketLoggingRequestBody Body { get; set; }
        public class PutBucketLoggingRequestBody : TeaModel {
            [NameInMap("BucketLoggingStatus")]
            [Validation(Required=true)]
            public PutBucketLoggingRequestBodyBucketLoggingStatus BucketLoggingStatus { get; set; }
            public class PutBucketLoggingRequestBodyBucketLoggingStatus : TeaModel {
                [NameInMap("LoggingEnabled")]
                [Validation(Required=false)]
                public PutBucketLoggingRequestBodyBucketLoggingStatusLoggingEnabled LoggingEnabled { get; set; }
                public class PutBucketLoggingRequestBodyBucketLoggingStatusLoggingEnabled : TeaModel {
                    [NameInMap("TargetBucket")]
                    [Validation(Required=false)]
                    public string TargetBucket { get; set; }
                    [NameInMap("TargetPrefix")]
                    [Validation(Required=false)]
                    public string TargetPrefix { get; set; }
                };

            }
        };

    }

}
