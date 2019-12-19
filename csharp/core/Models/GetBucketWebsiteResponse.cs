// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.OSS.Models
{
    public class GetBucketWebsiteResponse : TeaModel {
        [NameInMap("x-oss-request-id")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("WebsiteConfiguration")]
        [Validation(Required=true)]
        public GetBucketWebsiteResponseWebsiteConfiguration WebsiteConfiguration { get; set; }
        public class GetBucketWebsiteResponseWebsiteConfiguration : TeaModel {
            [NameInMap("IndexDocument")]
            [Validation(Required=true)]
            public GetBucketWebsiteResponseIndexDocument IndexDocument { get; set; }
            public class GetBucketWebsiteResponseIndexDocument : TeaModel {
                [NameInMap("Suffix")]
                [Validation(Required=false)]
                public string Suffix { get; set; }

            }
            [NameInMap("ErrorDocument")]
            [Validation(Required=true)]
            public GetBucketWebsiteResponseErrorDocument ErrorDocument { get; set; }
            public class GetBucketWebsiteResponseErrorDocument : TeaModel {
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

            }
            [NameInMap("RoutingRules")]
            [Validation(Required=true)]
            public GetBucketWebsiteResponseRoutingRules RoutingRules { get; set; }
            public class GetBucketWebsiteResponseRoutingRules : TeaModel {
                [NameInMap("RoutingRule")]
                [Validation(Required=false)]
                public List<GetBucketWebsiteResponseRoutingRule> RoutingRule { get; set; }
                public class GetBucketWebsiteResponseRoutingRule : TeaModel {
                    [NameInMap("RuleNumber")]
                    [Validation(Required=false)]
                    public int? RuleNumber { get; set; }

                    [NameInMap("Condition")]
                    [Validation(Required=true)]
                    public GetBucketWebsiteResponseCondition Condition { get; set; }
                    public class GetBucketWebsiteResponseCondition : TeaModel {
                        [NameInMap("KeyPrefixEquals")]
                        [Validation(Required=false)]
                        public string KeyPrefixEquals { get; set; }
                        [NameInMap("HttpErrorCodeReturnedEquals")]
                        [Validation(Required=false)]
                        public string HttpErrorCodeReturnedEquals { get; set; }
                        [NameInMap("IncludeHeader")]
                        [Validation(Required=true)]
                        public GetBucketWebsiteResponseIncludeHeader IncludeHeader { get; set; }
                        public class GetBucketWebsiteResponseIncludeHeader : TeaModel {
                            [NameInMap("Key")]
                            [Validation(Required=false)]
                            public string Key { get; set; }

                            [NameInMap("Equals")]
                            [Validation(Required=false)]
                            public string Equals_ { get; set; }

                        }
                    };

                    [NameInMap("Redirect")]
                    [Validation(Required=true)]
                    public GetBucketWebsiteResponseRedirect Redirect { get; set; }
                    public class GetBucketWebsiteResponseRedirect : TeaModel {
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
                        public GetBucketWebsiteResponseMirrorHeaders MirrorHeaders { get; set; }
                        public class GetBucketWebsiteResponseMirrorHeaders : TeaModel {
                            [NameInMap("PassAll")]
                            [Validation(Required=false)]
                            public bool? PassAll { get; set; }

                            [NameInMap("Pass")]
                            [Validation(Required=false)]
                            public string Pass { get; set; }

                            [NameInMap("Remove")]
                            [Validation(Required=false)]
                            public string Remove { get; set; }

                            [NameInMap("Set")]
                            [Validation(Required=true)]
                            public GetBucketWebsiteResponseSet Set { get; set; }
                            public class GetBucketWebsiteResponseSet : TeaModel {
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
