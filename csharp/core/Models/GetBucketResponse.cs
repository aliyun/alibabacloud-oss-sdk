// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.OSS.Models
{
    public class GetBucketResponse : TeaModel {
        /// <summary>
        /// x-oss-request-id
        /// </summary>
        [NameInMap("x-oss-request-id")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        /// <summary>
        /// ListBucketResult
        /// </summary>
        [NameInMap("ListBucketResult")]
        [Validation(Required=true)]
        public GetBucketResponseListBucketResult ListBucketResult { get; set; }
        public class GetBucketResponseListBucketResult : TeaModel {
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("Prefix")]
            [Validation(Required=false)]
            public string Prefix { get; set; }
            [NameInMap("Marker")]
            [Validation(Required=false)]
            public string Marker { get; set; }
            [NameInMap("MaxKeys")]
            [Validation(Required=false)]
            public string MaxKeys { get; set; }
            [NameInMap("Delimiter")]
            [Validation(Required=false)]
            public string Delimiter { get; set; }
            [NameInMap("IsTruncated")]
            [Validation(Required=false)]
            public string IsTruncated { get; set; }
            [NameInMap("EncodingType")]
            [Validation(Required=false)]
            public string EncodingType { get; set; }
            [NameInMap("CommonPrefixes")]
            [Validation(Required=false)]
            public string CommonPrefixes { get; set; }
            [NameInMap("Contents")]
            [Validation(Required=false)]
            public List<GetBucketResponseListBucketResultContents> Contents { get; set; }
            public class GetBucketResponseListBucketResultContents : TeaModel {
                public string Key { get; set; }
                public string ETag { get; set; }
                public string LastModified { get; set; }
                public string Size { get; set; }
                public string StorageClass { get; set; }
                public GetBucketResponseListBucketResultContentsOwner Owner { get; set; }
                public class GetBucketResponseListBucketResultContentsOwner : TeaModel {
                    /// <summary>
                    /// ID
                    /// </summary>
                    [NameInMap("ID")]
                    [Validation(Required=false)]
                    public string ID { get; set; }

                    /// <summary>
                    /// DisplayName
                    /// </summary>
                    [NameInMap("DisplayName")]
                    [Validation(Required=false)]
                    public string DisplayName { get; set; }

                }
            }
        };

    }

}
