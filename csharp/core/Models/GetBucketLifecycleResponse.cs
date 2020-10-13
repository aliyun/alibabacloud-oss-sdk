// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.OSS.Models
{
    public class GetBucketLifecycleResponse : TeaModel {
        /// <summary>
        /// x-oss-request-id
        /// </summary>
        [NameInMap("x-oss-request-id")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        /// <summary>
        /// LifecycleConfiguration
        /// </summary>
        [NameInMap("LifecycleConfiguration")]
        [Validation(Required=true)]
        public GetBucketLifecycleResponseLifecycleConfiguration LifecycleConfiguration { get; set; }
        public class GetBucketLifecycleResponseLifecycleConfiguration : TeaModel {
            [NameInMap("Rule")]
            [Validation(Required=false)]
            public List<GetBucketLifecycleResponseLifecycleConfigurationRule> Rule { get; set; }
            public class GetBucketLifecycleResponseLifecycleConfigurationRule : TeaModel {
                public string ID { get; set; }
                public string Prefix { get; set; }
                public string Status { get; set; }
                public GetBucketLifecycleResponseLifecycleConfigurationRuleExpiration Expiration { get; set; }
                public class GetBucketLifecycleResponseLifecycleConfigurationRuleExpiration : TeaModel {
                    /// <summary>
                    /// Days
                    /// </summary>
                    [NameInMap("Days")]
                    [Validation(Required=false)]
                    public int? Days { get; set; }

                    /// <summary>
                    /// CreatedBeforeDate
                    /// </summary>
                    [NameInMap("CreatedBeforeDate")]
                    [Validation(Required=false)]
                    public string CreatedBeforeDate { get; set; }

                }
                public GetBucketLifecycleResponseLifecycleConfigurationRuleTransition Transition { get; set; }
                public class GetBucketLifecycleResponseLifecycleConfigurationRuleTransition : TeaModel {
                    /// <summary>
                    /// Days
                    /// </summary>
                    [NameInMap("Days")]
                    [Validation(Required=false)]
                    public int? Days { get; set; }

                    /// <summary>
                    /// StorageClass
                    /// </summary>
                    [NameInMap("StorageClass")]
                    [Validation(Required=false)]
                    public string StorageClass { get; set; }

                }
                public GetBucketLifecycleResponseLifecycleConfigurationRuleAbortMultipartUpload AbortMultipartUpload { get; set; }
                public class GetBucketLifecycleResponseLifecycleConfigurationRuleAbortMultipartUpload : TeaModel {
                    /// <summary>
                    /// Days
                    /// </summary>
                    [NameInMap("Days")]
                    [Validation(Required=false)]
                    public int? Days { get; set; }

                    /// <summary>
                    /// CreatedBeforeDate
                    /// </summary>
                    [NameInMap("CreatedBeforeDate")]
                    [Validation(Required=false)]
                    public string CreatedBeforeDate { get; set; }

                }
                public GetBucketLifecycleResponseLifecycleConfigurationRuleTag Tag { get; set; }
                public class GetBucketLifecycleResponseLifecycleConfigurationRuleTag : TeaModel {
                    /// <summary>
                    /// Key
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// Value
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }
            }
        };

    }

}
