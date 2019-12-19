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
            public PutBucketLoggingRequestBucketLoggingStatus BucketLoggingStatus { get; set; }
            public class PutBucketLoggingRequestBucketLoggingStatus : TeaModel {
                [NameInMap("LoggingEnabled")]
                [Validation(Required=false)]
                public PutBucketLoggingRequestLoggingEnabled LoggingEnabled { get; set; }
                public class PutBucketLoggingRequestLoggingEnabled : TeaModel {
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
