// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.OSS.Models
{
    public class PutBucketEncryptionRequest : TeaModel {
        /// <summary>
        /// BucketName
        /// </summary>
        [NameInMap("BucketName")]
        [Validation(Required=true, Pattern="[a-zA-Z0-9\\-\\_]+")]
        public string BucketName { get; set; }

        /// <summary>
        /// Body
        /// </summary>
        [NameInMap("Body")]
        [Validation(Required=false)]
        public PutBucketEncryptionRequestBody Body { get; set; }
        public class PutBucketEncryptionRequestBody : TeaModel {
            [NameInMap("ServerSideEncryptionRule")]
            [Validation(Required=true)]
            public PutBucketEncryptionRequestBodyServerSideEncryptionRule ServerSideEncryptionRule { get; set; }
            public class PutBucketEncryptionRequestBodyServerSideEncryptionRule : TeaModel {
                /// <summary>
                /// ApplyServerSideEncryptionByDefault
                /// </summary>
                [NameInMap("ApplyServerSideEncryptionByDefault")]
                [Validation(Required=false)]
                public PutBucketEncryptionRequestBodyServerSideEncryptionRuleApplyServerSideEncryptionByDefault ApplyServerSideEncryptionByDefault { get; set; }
                public class PutBucketEncryptionRequestBodyServerSideEncryptionRuleApplyServerSideEncryptionByDefault : TeaModel {
                    [NameInMap("SSEAlgorithm")]
                    [Validation(Required=false)]
                    public string SSEAlgorithm { get; set; }
                    [NameInMap("KMSMasterKeyID")]
                    [Validation(Required=false)]
                    public string KMSMasterKeyID { get; set; }
                };

            }
        };

    }

}
