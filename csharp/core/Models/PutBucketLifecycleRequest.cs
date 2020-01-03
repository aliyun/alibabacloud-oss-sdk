// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.OSS.Models
{
    public class PutBucketLifecycleRequest : TeaModel {
        [NameInMap("BucketName")]
        [Validation(Required=true)]
        public string BucketName { get; set; }

        [NameInMap("Body")]
        [Validation(Required=false)]
        public PutBucketLifecycleRequestBody Body { get; set; }
        public class PutBucketLifecycleRequestBody : TeaModel {
            [NameInMap("LifecycleConfiguration")]
            [Validation(Required=true)]
            public PutBucketLifecycleRequestBodyLifecycleConfiguration LifecycleConfiguration { get; set; }
            public class PutBucketLifecycleRequestBodyLifecycleConfiguration : TeaModel {
                [NameInMap("Rule")]
                [Validation(Required=false)]
                public List<PutBucketLifecycleRequestBodyLifecycleConfigurationRule> Rule { get; set; }
                public class PutBucketLifecycleRequestBodyLifecycleConfigurationRule : TeaModel {
                    [NameInMap("Expiration")]
                    [Validation(Required=false)]
                    public PutBucketLifecycleRequestBodyLifecycleConfigurationRuleExpiration Expiration { get; set; }
                    public class PutBucketLifecycleRequestBodyLifecycleConfigurationRuleExpiration : TeaModel {
                        [NameInMap("Days")]
                        [Validation(Required=false)]
                        public int? Days { get; set; }
                        [NameInMap("CreatedBeforeDate")]
                        [Validation(Required=false)]
                        public string CreatedBeforeDate { get; set; }
                    };

                    [NameInMap("Transition")]
                    [Validation(Required=false)]
                    public PutBucketLifecycleRequestBodyLifecycleConfigurationRuleTransition Transition { get; set; }
                    public class PutBucketLifecycleRequestBodyLifecycleConfigurationRuleTransition : TeaModel {
                        [NameInMap("Days")]
                        [Validation(Required=false)]
                        public int? Days { get; set; }
                        [NameInMap("StorageClass")]
                        [Validation(Required=false)]
                        public string StorageClass { get; set; }
                    };

                    [NameInMap("AbortMultipartUpload")]
                    [Validation(Required=false)]
                    public PutBucketLifecycleRequestBodyLifecycleConfigurationRuleAbortMultipartUpload AbortMultipartUpload { get; set; }
                    public class PutBucketLifecycleRequestBodyLifecycleConfigurationRuleAbortMultipartUpload : TeaModel {
                        [NameInMap("Days")]
                        [Validation(Required=false)]
                        public int? Days { get; set; }
                        [NameInMap("CreatedBeforeDate")]
                        [Validation(Required=false)]
                        public string CreatedBeforeDate { get; set; }
                    };

                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public PutBucketLifecycleRequestBodyLifecycleConfigurationRuleTag Tag { get; set; }
                    public class PutBucketLifecycleRequestBodyLifecycleConfigurationRuleTag : TeaModel {
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }
                    };

                    [NameInMap("ID")]
                    [Validation(Required=false)]
                    public string ID { get; set; }

                    [NameInMap("Prefix")]
                    [Validation(Required=false)]
                    public string Prefix { get; set; }

                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                }

            }
        };

    }

}
