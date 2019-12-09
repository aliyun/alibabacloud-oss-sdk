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
            public GetBucketInfoResponseBucket Bucket { get; set; }
            public class GetBucketInfoResponseBucket : TeaModel {
                [NameInMap("CreationDate")]
                [Validation(Required=true)]
                public string CreationDate { get; set; }

                [NameInMap("ExtranetEndpoint")]
                [Validation(Required=true)]
                public string ExtranetEndpoint { get; set; }

                [NameInMap("IntranetEndpoint")]
                [Validation(Required=true)]
                public string IntranetEndpoint { get; set; }

                [NameInMap("Location")]
                [Validation(Required=true)]
                public string Location { get; set; }

                [NameInMap("Name")]
                [Validation(Required=true)]
                public string Name { get; set; }

                [NameInMap("DataRedundancyType")]
                [Validation(Required=true)]
                public string DataRedundancyType { get; set; }

                [NameInMap("StorageClass")]
                [Validation(Required=true)]
                public string StorageClass { get; set; }

                [NameInMap("Comment")]
                [Validation(Required=true)]
                public string Comment { get; set; }

                [NameInMap("Owner")]
                [Validation(Required=true)]
                public undefinedOwner Owner { get; set; }
                public class undefinedOwner : TeaModel {
                    [NameInMap("ID")]
                    [Validation(Required=true)]
                    public string ID { get; set; }
                    [NameInMap("DisplayName")]
                    [Validation(Required=true)]
                    public string DisplayName { get; set; }
                };

                [NameInMap("AccessControlList")]
                [Validation(Required=true)]
                public undefinedAccessControlList AccessControlList { get; set; }
                public class undefinedAccessControlList : TeaModel {
                    [NameInMap("Grant")]
                    [Validation(Required=true)]
                    public string Grant { get; set; }
                };

            }
        };

    }

}
