// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.OSS.Models
{
    public class GetBucketLoggingResponse : TeaModel {
        /// <summary>
        /// x-oss-request-id
        /// </summary>
        [NameInMap("x-oss-request-id")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        /// <summary>
        /// BucketLoggingStatus
        /// </summary>
        [NameInMap("BucketLoggingStatus")]
        [Validation(Required=true)]
        public GetBucketLoggingResponseBucketLoggingStatus BucketLoggingStatus { get; set; }
        public class GetBucketLoggingResponseBucketLoggingStatus : TeaModel {
            [NameInMap("LoggingEnabled")]
            [Validation(Required=true)]
            public GetBucketLoggingResponseBucketLoggingStatusLoggingEnabled LoggingEnabled { get; set; }
            public class GetBucketLoggingResponseBucketLoggingStatusLoggingEnabled : TeaModel {
                /// <summary>
                /// TargetBucket
                /// </summary>
                [NameInMap("TargetBucket")]
                [Validation(Required=false)]
                public string TargetBucket { get; set; }

                /// <summary>
                /// TargetPrefix
                /// </summary>
                [NameInMap("TargetPrefix")]
                [Validation(Required=false)]
                public string TargetPrefix { get; set; }

            }
        };

    }

}
