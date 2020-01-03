// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.OSS.Models
{
    public class PutBucketRequest : TeaModel {
        [NameInMap("BucketName")]
        [Validation(Required=true)]
        public string BucketName { get; set; }

        [NameInMap("Body")]
        [Validation(Required=false)]
        public PutBucketRequestBody Body { get; set; }
        public class PutBucketRequestBody : TeaModel {
            [NameInMap("CreateBucketConfiguration")]
            [Validation(Required=true)]
            public PutBucketRequestBodyCreateBucketConfiguration CreateBucketConfiguration { get; set; }
            public class PutBucketRequestBodyCreateBucketConfiguration : TeaModel {
                [NameInMap("StorageClass")]
                [Validation(Required=false)]
                public string StorageClass { get; set; }

                [NameInMap("DataRedundancyType")]
                [Validation(Required=false)]
                public string DataRedundancyType { get; set; }

            }
        };

        [NameInMap("Header")]
        [Validation(Required=false)]
        public PutBucketRequestHeader Header { get; set; }
        public class PutBucketRequestHeader : TeaModel {
            [NameInMap("x-oss-acl")]
            [Validation(Required=false)]
            public string Acl { get; set; }
        };

    }

}
