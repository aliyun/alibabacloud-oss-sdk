// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.OSS.Models
{
    public class GetBucketInfoResponse : TeaModel {
        [NameInMap("x-oss-request-id")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("BucketInfo")]
        [Validation(Required=true)]
        public GetBucketInfoResponseBucketInfo BucketInfo { get; set; }
        public class GetBucketInfoResponseBucketInfo : TeaModel {
            [NameInMap("Bucket")]
            [Validation(Required=true)]
            public GetBucketInfoResponseBucketInfoBucket Bucket { get; set; }
            public class GetBucketInfoResponseBucketInfoBucket : TeaModel {
                [NameInMap("CreationDate")]
                [Validation(Required=false)]
                public string CreationDate { get; set; }

                [NameInMap("ExtranetEndpoint")]
                [Validation(Required=false)]
                public string ExtranetEndpoint { get; set; }

                [NameInMap("IntranetEndpoint")]
                [Validation(Required=false)]
                public string IntranetEndpoint { get; set; }

                [NameInMap("Location")]
                [Validation(Required=false)]
                public string Location { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("DataRedundancyType")]
                [Validation(Required=false)]
                public string DataRedundancyType { get; set; }

                [NameInMap("StorageClass")]
                [Validation(Required=false)]
                public string StorageClass { get; set; }

                [NameInMap("Comment")]
                [Validation(Required=false)]
                public string Comment { get; set; }

                [NameInMap("Owner")]
                [Validation(Required=true)]
                public GetBucketInfoResponseBucketInfoBucketOwner Owner { get; set; }
                public class GetBucketInfoResponseBucketInfoBucketOwner : TeaModel {
                    [NameInMap("ID")]
                    [Validation(Required=false)]
                    public string ID { get; set; }
                    [NameInMap("DisplayName")]
                    [Validation(Required=false)]
                    public string DisplayName { get; set; }
                };

                [NameInMap("AccessControlList")]
                [Validation(Required=true)]
                public GetBucketInfoResponseBucketInfoBucketAccessControlList AccessControlList { get; set; }
                public class GetBucketInfoResponseBucketInfoBucketAccessControlList : TeaModel {
                    [NameInMap("Grant")]
                    [Validation(Required=false)]
                    public string Grant { get; set; }
                };

            }
        };

    }

}
