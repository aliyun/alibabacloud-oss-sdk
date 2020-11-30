// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.OSS.Models
{
    public class PutBucketLoggingRequest : TeaModel {
        /// <summary>
        /// BucketName
        /// </summary>
        [NameInMap("BucketName")]
        [Validation(Required=true, Pattern="[a-zA-Z0-9-_]+")]
        public string BucketName { get; set; }

        /// <summary>
        /// Body
        /// </summary>
        [NameInMap("Body")]
        [Validation(Required=false)]
        public PutBucketLoggingRequestBody Body { get; set; }
        public class PutBucketLoggingRequestBody : TeaModel {
            [NameInMap("BucketLoggingStatus")]
            [Validation(Required=true)]
            public PutBucketLoggingRequestBodyBucketLoggingStatus BucketLoggingStatus { get; set; }
            public class PutBucketLoggingRequestBodyBucketLoggingStatus : TeaModel {
                /// <summary>
                /// LoggingEnabled
                /// </summary>
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
