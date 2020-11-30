// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.OSS.Models
{
    public class PutBucketLifecycleRequest : TeaModel {
        /// <summary>
        /// BucketName
        /// </summary>
        [NameInMap("BucketName")]
        [Validation(Required=true, Pattern="[a-zA-Z0-9-_]+")]
        public string BucketName { get; set; }

        /// <summary>
        /// Body
        /// </summary>
        [NameInMap("Body")]
        [Validation(Required=false)]
        public PutBucketLifecycleRequestBody Body { get; set; }
        public class PutBucketLifecycleRequestBody : TeaModel {
            [NameInMap("LifecycleConfiguration")]
            [Validation(Required=true)]
            public PutBucketLifecycleRequestBodyLifecycleConfiguration LifecycleConfiguration { get; set; }
            public class PutBucketLifecycleRequestBodyLifecycleConfiguration : TeaModel {
                /// <summary>
                /// Rule
                /// </summary>
                [NameInMap("Rule")]
                [Validation(Required=false)]
                public List<PutBucketLifecycleRequestBodyLifecycleConfigurationRule> Rule { get; set; }
                public class PutBucketLifecycleRequestBodyLifecycleConfigurationRule : TeaModel {
                    /// <summary>
                    /// Expiration
                    /// </summary>
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

                    /// <summary>
                    /// Transition
                    /// </summary>
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

                    /// <summary>
                    /// AbortMultipartUpload
                    /// </summary>
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

                    /// <summary>
                    /// Tag
                    /// </summary>
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

                    /// <summary>
                    /// ID
                    /// </summary>
                    [NameInMap("ID")]
                    [Validation(Required=false)]
                    public string ID { get; set; }

                    /// <summary>
                    /// Prefix
                    /// </summary>
                    [NameInMap("Prefix")]
                    [Validation(Required=false)]
                    public string Prefix { get; set; }

                    /// <summary>
                    /// Status
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                }

            }
        };

    }

}
