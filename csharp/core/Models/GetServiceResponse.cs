// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.OSS.Models
{
    public class GetServiceResponse : TeaModel {
        /// <summary>
        /// x-oss-request-id
        /// </summary>
        [NameInMap("x-oss-request-id")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        /// <summary>
        /// ListAllMyBucketsResult
        /// </summary>
        [NameInMap("ListAllMyBucketsResult")]
        [Validation(Required=true)]
        public GetServiceResponseListAllMyBucketsResult ListAllMyBucketsResult { get; set; }
        public class GetServiceResponseListAllMyBucketsResult : TeaModel {
            [NameInMap("Prefix")]
            [Validation(Required=false)]
            public string Prefix { get; set; }
            [NameInMap("Marker")]
            [Validation(Required=false)]
            public string Marker { get; set; }
            [NameInMap("MaxKeys")]
            [Validation(Required=false)]
            public string MaxKeys { get; set; }
            [NameInMap("IsTruncated")]
            [Validation(Required=false)]
            public string IsTruncated { get; set; }
            [NameInMap("NextMarker")]
            [Validation(Required=false)]
            public string NextMarker { get; set; }
            [NameInMap("Owner")]
            [Validation(Required=true)]
            public GetServiceResponseListAllMyBucketsResultOwner Owner { get; set; }
            public class GetServiceResponseListAllMyBucketsResultOwner : TeaModel {
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
            [NameInMap("Buckets")]
            [Validation(Required=true)]
            public GetServiceResponseListAllMyBucketsResultBuckets Buckets { get; set; }
            public class GetServiceResponseListAllMyBucketsResultBuckets : TeaModel {
                /// <summary>
                /// Bucket
                /// </summary>
                [NameInMap("Bucket")]
                [Validation(Required=false)]
                public List<GetServiceResponseListAllMyBucketsResultBucketsBucket> Bucket { get; set; }
                public class GetServiceResponseListAllMyBucketsResultBucketsBucket : TeaModel {
                    /// <summary>
                    /// Name
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// CreateDate
                    /// </summary>
                    [NameInMap("CreateDate")]
                    [Validation(Required=false)]
                    public string CreateDate { get; set; }

                    /// <summary>
                    /// Location
                    /// </summary>
                    [NameInMap("Location")]
                    [Validation(Required=false)]
                    public string Location { get; set; }

                    /// <summary>
                    /// ExtranetEndpoint
                    /// </summary>
                    [NameInMap("ExtranetEndpoint")]
                    [Validation(Required=false)]
                    public string ExtranetEndpoint { get; set; }

                    /// <summary>
                    /// IntranetEndpoint
                    /// </summary>
                    [NameInMap("IntranetEndpoint")]
                    [Validation(Required=false)]
                    public string IntranetEndpoint { get; set; }

                    /// <summary>
                    /// StorageClass
                    /// </summary>
                    [NameInMap("StorageClass")]
                    [Validation(Required=false)]
                    public string StorageClass { get; set; }

                }

            }
        };

    }

}
