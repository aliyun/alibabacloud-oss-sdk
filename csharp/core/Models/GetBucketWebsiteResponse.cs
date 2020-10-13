// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.OSS.Models
{
    public class GetBucketWebsiteResponse : TeaModel {
        /// <summary>
        /// x-oss-request-id
        /// </summary>
        [NameInMap("x-oss-request-id")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        /// <summary>
        /// WebsiteConfiguration
        /// </summary>
        [NameInMap("WebsiteConfiguration")]
        [Validation(Required=true)]
        public GetBucketWebsiteResponseWebsiteConfiguration WebsiteConfiguration { get; set; }
        public class GetBucketWebsiteResponseWebsiteConfiguration : TeaModel {
            [NameInMap("IndexDocument")]
            [Validation(Required=true)]
            public GetBucketWebsiteResponseWebsiteConfigurationIndexDocument IndexDocument { get; set; }
            public class GetBucketWebsiteResponseWebsiteConfigurationIndexDocument : TeaModel {
                /// <summary>
                /// Suffix
                /// </summary>
                [NameInMap("Suffix")]
                [Validation(Required=false)]
                public string Suffix { get; set; }

            }
            [NameInMap("ErrorDocument")]
            [Validation(Required=true)]
            public GetBucketWebsiteResponseWebsiteConfigurationErrorDocument ErrorDocument { get; set; }
            public class GetBucketWebsiteResponseWebsiteConfigurationErrorDocument : TeaModel {
                /// <summary>
                /// Key
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

            }
            [NameInMap("RoutingRules")]
            [Validation(Required=true)]
            public GetBucketWebsiteResponseWebsiteConfigurationRoutingRules RoutingRules { get; set; }
            public class GetBucketWebsiteResponseWebsiteConfigurationRoutingRules : TeaModel {
                /// <summary>
                /// RoutingRule
                /// </summary>
                [NameInMap("RoutingRule")]
                [Validation(Required=false)]
                public List<GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRule> RoutingRule { get; set; }
                public class GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRule : TeaModel {
                    /// <summary>
                    /// RuleNumber
                    /// </summary>
                    [NameInMap("RuleNumber")]
                    [Validation(Required=false)]
                    public int? RuleNumber { get; set; }

                    /// <summary>
                    /// Condition
                    /// </summary>
                    [NameInMap("Condition")]
                    [Validation(Required=true)]
                    public GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleCondition Condition { get; set; }
                    public class GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleCondition : TeaModel {
                        [NameInMap("KeyPrefixEquals")]
                        [Validation(Required=false)]
                        public string KeyPrefixEquals { get; set; }
                        [NameInMap("HttpErrorCodeReturnedEquals")]
                        [Validation(Required=false)]
                        public string HttpErrorCodeReturnedEquals { get; set; }
                        [NameInMap("IncludeHeader")]
                        [Validation(Required=true)]
                        public GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleConditionIncludeHeader IncludeHeader { get; set; }
                        public class GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleConditionIncludeHeader : TeaModel {
                            /// <summary>
                            /// Key
                            /// </summary>
                            [NameInMap("Key")]
                            [Validation(Required=false)]
                            public string Key { get; set; }

                            /// <summary>
                            /// Equals
                            /// </summary>
                            [NameInMap("Equals")]
                            [Validation(Required=false)]
                            public string Equals_ { get; set; }

                        }
                    };

                    /// <summary>
                    /// Redirect
                    /// </summary>
                    [NameInMap("Redirect")]
                    [Validation(Required=true)]
                    public GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirect Redirect { get; set; }
                    public class GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirect : TeaModel {
                        [NameInMap("RedirectType")]
                        [Validation(Required=false)]
                        public string RedirectType { get; set; }
                        [NameInMap("PassQueryString")]
                        [Validation(Required=false)]
                        public bool? PassQueryString { get; set; }
                        [NameInMap("MirrorURL")]
                        [Validation(Required=false)]
                        public string MirrorURL { get; set; }
                        [NameInMap("MirrorPassQueryString")]
                        [Validation(Required=false)]
                        public bool? MirrorPassQueryString { get; set; }
                        [NameInMap("MirrorFollowRedirect")]
                        [Validation(Required=false)]
                        public bool? MirrorFollowRedirect { get; set; }
                        [NameInMap("MirrorCheckMd5")]
                        [Validation(Required=false)]
                        public bool? MirrorCheckMd5 { get; set; }
                        [NameInMap("Protocol")]
                        [Validation(Required=false)]
                        public string Protocol { get; set; }
                        [NameInMap("HostName")]
                        [Validation(Required=false)]
                        public string HostName { get; set; }
                        [NameInMap("HttpRedirectCode")]
                        [Validation(Required=false)]
                        public string HttpRedirectCode { get; set; }
                        [NameInMap("ReplaceKeyPrefixWith")]
                        [Validation(Required=false)]
                        public string ReplaceKeyPrefixWith { get; set; }
                        [NameInMap("ReplaceKeyWith")]
                        [Validation(Required=false)]
                        public string ReplaceKeyWith { get; set; }
                        [NameInMap("MirrorHeaders")]
                        [Validation(Required=true)]
                        public GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeaders MirrorHeaders { get; set; }
                        public class GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeaders : TeaModel {
                            /// <summary>
                            /// PassAll
                            /// </summary>
                            [NameInMap("PassAll")]
                            [Validation(Required=false)]
                            public bool? PassAll { get; set; }

                            /// <summary>
                            /// Pass
                            /// </summary>
                            [NameInMap("Pass")]
                            [Validation(Required=false)]
                            public string Pass { get; set; }

                            /// <summary>
                            /// Remove
                            /// </summary>
                            [NameInMap("Remove")]
                            [Validation(Required=false)]
                            public string Remove { get; set; }

                            /// <summary>
                            /// Set
                            /// </summary>
                            [NameInMap("Set")]
                            [Validation(Required=true)]
                            public GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeadersSet Set { get; set; }
                            public class GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeadersSet : TeaModel {
                                [NameInMap("Key")]
                                [Validation(Required=false)]
                                public string Key { get; set; }
                                [NameInMap("Value")]
                                [Validation(Required=false)]
                                public string Value { get; set; }
                            };

                        }
                    };

                }

            }
        };

    }

}
