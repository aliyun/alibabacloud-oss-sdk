// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.OSS.Models
{
    public class PutBucketEncryptionRequest : TeaModel {
        [NameInMap("BucketName")]
        [Validation(Required=true)]
        public string BucketName { get; set; }

        [NameInMap("Body")]
        [Validation(Required=false)]
        public PutBucketEncryptionRequestBody Body { get; set; }
        public class PutBucketEncryptionRequestBody : TeaModel {
            [NameInMap("ServerSideEncryptionRule")]
            [Validation(Required=true)]
            public PutBucketEncryptionRequestServerSideEncryptionRule ServerSideEncryptionRule { get; set; }
            public class PutBucketEncryptionRequestServerSideEncryptionRule : TeaModel {
                [NameInMap("ApplyServerSideEncryptionByDefault")]
                [Validation(Required=false)]
                public PutBucketEncryptionRequestApplyServerSideEncryptionByDefault ApplyServerSideEncryptionByDefault { get; set; }
                public class PutBucketEncryptionRequestApplyServerSideEncryptionByDefault : TeaModel {
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
