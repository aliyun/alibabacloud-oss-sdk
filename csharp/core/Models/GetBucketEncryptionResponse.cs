// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.OSS.Models
{
    public class GetBucketEncryptionResponse : TeaModel {
        /// <summary>
        /// x-oss-request-id
        /// </summary>
        [NameInMap("x-oss-request-id")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        /// <summary>
        /// ServerSideEncryptionRule
        /// </summary>
        [NameInMap("ServerSideEncryptionRule")]
        [Validation(Required=true)]
        public GetBucketEncryptionResponseServerSideEncryptionRule ServerSideEncryptionRule { get; set; }
        public class GetBucketEncryptionResponseServerSideEncryptionRule : TeaModel {
            [NameInMap("ApplyServerSideEncryptionByDefault")]
            [Validation(Required=true)]
            public GetBucketEncryptionResponseServerSideEncryptionRuleApplyServerSideEncryptionByDefault ApplyServerSideEncryptionByDefault { get; set; }
            public class GetBucketEncryptionResponseServerSideEncryptionRuleApplyServerSideEncryptionByDefault : TeaModel {
                /// <summary>
                /// SSEAlgorithm
                /// </summary>
                [NameInMap("SSEAlgorithm")]
                [Validation(Required=false)]
                public string SSEAlgorithm { get; set; }

                /// <summary>
                /// KMSMasterKeyID
                /// </summary>
                [NameInMap("KMSMasterKeyID")]
                [Validation(Required=false)]
                public string KMSMasterKeyID { get; set; }

            }
        };

    }

}
