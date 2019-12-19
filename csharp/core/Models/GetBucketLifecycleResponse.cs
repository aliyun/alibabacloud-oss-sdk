// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.OSS.Models
{
    public class GetBucketLifecycleResponse : TeaModel {
        [NameInMap("x-oss-request-id")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("LifecycleConfiguration")]
        [Validation(Required=true)]
        public GetBucketLifecycleResponseLifecycleConfiguration LifecycleConfiguration { get; set; }
        public class GetBucketLifecycleResponseLifecycleConfiguration : TeaModel {
            [NameInMap("Rule")]
            [Validation(Required=false)]
            public List<GetBucketLifecycleResponseID> Rule { get; set; }
            public class GetBucketLifecycleResponseID : TeaModel {
                    public string ID { get; set; }
                    public string Prefix { get; set; }
                    public string Status { get; set; }
                    public GetBucketLifecycleResponseIDExpiration Expiration { get; set; }
                    public class GetBucketLifecycleResponseIDExpiration : TeaModel {
                        [NameInMap("Days")]
                        [Validation(Required=false)]
                        public int? Days { get; set; }

                        [NameInMap("CreatedBeforeDate")]
                        [Validation(Required=false)]
                        public string CreatedBeforeDate { get; set; }

                    }
                    public GetBucketLifecycleResponseIDTransition Transition { get; set; }
                    public class GetBucketLifecycleResponseIDTransition : TeaModel {
                        [NameInMap("Days")]
                        [Validation(Required=false)]
                        public int? Days { get; set; }

                        [NameInMap("StorageClass")]
                        [Validation(Required=false)]
                        public string StorageClass { get; set; }

                    }
                    public GetBucketLifecycleResponseIDAbortMultipartUpload AbortMultipartUpload { get; set; }
                    public class GetBucketLifecycleResponseIDAbortMultipartUpload : TeaModel {
                        [NameInMap("Days")]
                        [Validation(Required=false)]
                        public int? Days { get; set; }

                        [NameInMap("CreatedBeforeDate")]
                        [Validation(Required=false)]
                        public string CreatedBeforeDate { get; set; }

                    }
                    public GetBucketLifecycleResponseIDTag Tag { get; set; }
                    public class GetBucketLifecycleResponseIDTag : TeaModel {
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }
            }
        };

    }

}
