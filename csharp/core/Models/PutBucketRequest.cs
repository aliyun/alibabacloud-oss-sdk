// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.OSS.Models
{
    public class PutBucketRequest : TeaModel {
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
        public PutBucketRequestBody Body { get; set; }
        public class PutBucketRequestBody : TeaModel {
            [NameInMap("CreateBucketConfiguration")]
            [Validation(Required=true)]
            public PutBucketRequestBodyCreateBucketConfiguration CreateBucketConfiguration { get; set; }
            public class PutBucketRequestBodyCreateBucketConfiguration : TeaModel {
                /// <summary>
                /// StorageClass
                /// </summary>
                [NameInMap("StorageClass")]
                [Validation(Required=false)]
                public string StorageClass { get; set; }

                /// <summary>
                /// DataRedundancyType
                /// </summary>
                [NameInMap("DataRedundancyType")]
                [Validation(Required=false)]
                public string DataRedundancyType { get; set; }

            }
        };

        /// <summary>
        /// Header
        /// </summary>
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
