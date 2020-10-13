// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.OSS.Models
{
    public class GetBucketInfoResponse : TeaModel {
        /// <summary>
        /// x-oss-request-id
        /// </summary>
        [NameInMap("x-oss-request-id")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        /// <summary>
        /// BucketInfo
        /// </summary>
        [NameInMap("BucketInfo")]
        [Validation(Required=true)]
        public GetBucketInfoResponseBucketInfo BucketInfo { get; set; }
        public class GetBucketInfoResponseBucketInfo : TeaModel {
            [NameInMap("Bucket")]
            [Validation(Required=true)]
            public GetBucketInfoResponseBucketInfoBucket Bucket { get; set; }
            public class GetBucketInfoResponseBucketInfoBucket : TeaModel {
                /// <summary>
                /// CreationDate
                /// </summary>
                [NameInMap("CreationDate")]
                [Validation(Required=false)]
                public string CreationDate { get; set; }

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
                /// Location
                /// </summary>
                [NameInMap("Location")]
                [Validation(Required=false)]
                public string Location { get; set; }

                /// <summary>
                /// Name
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// DataRedundancyType
                /// </summary>
                [NameInMap("DataRedundancyType")]
                [Validation(Required=false)]
                public string DataRedundancyType { get; set; }

                /// <summary>
                /// StorageClass
                /// </summary>
                [NameInMap("StorageClass")]
                [Validation(Required=false)]
                public string StorageClass { get; set; }

                /// <summary>
                /// Comment
                /// </summary>
                [NameInMap("Comment")]
                [Validation(Required=false)]
                public string Comment { get; set; }

                /// <summary>
                /// Owner
                /// </summary>
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

                /// <summary>
                /// AccessControlList
                /// </summary>
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
