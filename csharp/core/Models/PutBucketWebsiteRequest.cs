// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.OSS.Models
{
    public class PutBucketWebsiteRequest : TeaModel {
        [NameInMap("BucketName")]
        [Validation(Required=true)]
        public string BucketName { get; set; }

        [NameInMap("Body")]
        [Validation(Required=false)]
        public PutBucketWebsiteRequestBody Body { get; set; }
        public class PutBucketWebsiteRequestBody : TeaModel {
            [NameInMap("WebsiteConfiguration")]
            [Validation(Required=true)]
            public PutBucketWebsiteRequestBodyWebsiteConfiguration WebsiteConfiguration { get; set; }
            public class PutBucketWebsiteRequestBodyWebsiteConfiguration : TeaModel {
                [NameInMap("IndexDocument")]
                [Validation(Required=false)]
                public PutBucketWebsiteRequestBodyWebsiteConfigurationIndexDocument IndexDocument { get; set; }
                public class PutBucketWebsiteRequestBodyWebsiteConfigurationIndexDocument : TeaModel {
                    [NameInMap("Suffix")]
                    [Validation(Required=false)]
                    public string Suffix { get; set; }
                };

                [NameInMap("ErrorDocument")]
                [Validation(Required=false)]
                public PutBucketWebsiteRequestBodyWebsiteConfigurationErrorDocument ErrorDocument { get; set; }
                public class PutBucketWebsiteRequestBodyWebsiteConfigurationErrorDocument : TeaModel {
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }
                };

                [NameInMap("RoutingRules")]
                [Validation(Required=false)]
                public PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRules RoutingRules { get; set; }
                public class PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRules : TeaModel {
                    [NameInMap("RoutingRule")]
                    [Validation(Required=false)]
                    public List<PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRule> RoutingRule { get; set; }
                    public class PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRule : TeaModel {
                        [NameInMap("IncludeHeader")]
                        [Validation(Required=false)]
                        public PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleIncludeHeader IncludeHeader { get; set; }
                        public class PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleIncludeHeader : TeaModel {
                            [NameInMap("Key")]
                            [Validation(Required=false)]
                            public string Key { get; set; }
                            [NameInMap("Equals")]
                            [Validation(Required=false)]
                            public string Equals_ { get; set; }
                        };

                        [NameInMap("KeyPrefixEquals")]
                        [Validation(Required=false)]
                        public string KeyPrefixEquals { get; set; }

                        [NameInMap("HttpErrorCodeReturnedEquals")]
                        [Validation(Required=false)]
                        public string HttpErrorCodeReturnedEquals { get; set; }

                    }
                };

            }
        };

    }

}
