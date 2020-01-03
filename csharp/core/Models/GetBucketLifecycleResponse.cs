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
            public List<GetBucketLifecycleResponseLifecycleConfigurationID> Rule { get; set; }
            public class GetBucketLifecycleResponseLifecycleConfigurationID : TeaModel {
                    public string ID { get; set; }
                    public string Prefix { get; set; }
                    public string Status { get; set; }
                    public GetBucketLifecycleResponseLifecycleConfigurationIDExpiration Expiration { get; set; }
                    public class GetBucketLifecycleResponseLifecycleConfigurationIDExpiration : TeaModel {
                        [NameInMap("Days")]
                        [Validation(Required=false)]
                        public int? Days { get; set; }

                        [NameInMap("CreatedBeforeDate")]
                        [Validation(Required=false)]
                        public string CreatedBeforeDate { get; set; }

                    }
                    public GetBucketLifecycleResponseLifecycleConfigurationIDTransition Transition { get; set; }
                    public class GetBucketLifecycleResponseLifecycleConfigurationIDTransition : TeaModel {
                        [NameInMap("Days")]
                        [Validation(Required=false)]
                        public int? Days { get; set; }

                        [NameInMap("StorageClass")]
                        [Validation(Required=false)]
                        public string StorageClass { get; set; }

                    }
                    public GetBucketLifecycleResponseLifecycleConfigurationIDAbortMultipartUpload AbortMultipartUpload { get; set; }
                    public class GetBucketLifecycleResponseLifecycleConfigurationIDAbortMultipartUpload : TeaModel {
                        [NameInMap("Days")]
                        [Validation(Required=false)]
                        public int? Days { get; set; }

                        [NameInMap("CreatedBeforeDate")]
                        [Validation(Required=false)]
                        public string CreatedBeforeDate { get; set; }

                    }
                    public GetBucketLifecycleResponseLifecycleConfigurationIDTag Tag { get; set; }
                    public class GetBucketLifecycleResponseLifecycleConfigurationIDTag : TeaModel {
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
