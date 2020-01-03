// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.OSS.Models
{
    public class GetServiceResponse : TeaModel {
        [NameInMap("x-oss-request-id")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

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
                [NameInMap("ID")]
                [Validation(Required=false)]
                public string ID { get; set; }

                [NameInMap("DisplayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

            }
            [NameInMap("Buckets")]
            [Validation(Required=true)]
            public GetServiceResponseListAllMyBucketsResultBuckets Buckets { get; set; }
            public class GetServiceResponseListAllMyBucketsResultBuckets : TeaModel {
                [NameInMap("Bucket")]
                [Validation(Required=false)]
                public List<GetServiceResponseListAllMyBucketsResultBucketsBucket> Bucket { get; set; }
                public class GetServiceResponseListAllMyBucketsResultBucketsBucket : TeaModel {
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("CreateDate")]
                    [Validation(Required=false)]
                    public string CreateDate { get; set; }

                    [NameInMap("Location")]
                    [Validation(Required=false)]
                    public string Location { get; set; }

                    [NameInMap("ExtranetEndpoint")]
                    [Validation(Required=false)]
                    public string ExtranetEndpoint { get; set; }

                    [NameInMap("IntranetEndpoint")]
                    [Validation(Required=false)]
                    public string IntranetEndpoint { get; set; }

                    [NameInMap("StorageClass")]
                    [Validation(Required=false)]
                    public string StorageClass { get; set; }

                }

            }
        };

    }

}
