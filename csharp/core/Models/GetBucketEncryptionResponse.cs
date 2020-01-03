// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.OSS.Models
{
    public class GetBucketEncryptionResponse : TeaModel {
        [NameInMap("x-oss-request-id")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("ServerSideEncryptionRule")]
        [Validation(Required=true)]
        public GetBucketEncryptionResponseServerSideEncryptionRule ServerSideEncryptionRule { get; set; }
        public class GetBucketEncryptionResponseServerSideEncryptionRule : TeaModel {
            [NameInMap("ApplyServerSideEncryptionByDefault")]
            [Validation(Required=true)]
            public GetBucketEncryptionResponseServerSideEncryptionRuleApplyServerSideEncryptionByDefault ApplyServerSideEncryptionByDefault { get; set; }
            public class GetBucketEncryptionResponseServerSideEncryptionRuleApplyServerSideEncryptionByDefault : TeaModel {
                [NameInMap("SSEAlgorithm")]
                [Validation(Required=false)]
                public string SSEAlgorithm { get; set; }

                [NameInMap("KMSMasterKeyID")]
                [Validation(Required=false)]
                public string KMSMasterKeyID { get; set; }

            }
        };

    }

}
