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
            public PutBucketWebsiteRequestWebsiteConfiguration WebsiteConfiguration { get; set; }
            public class PutBucketWebsiteRequestWebsiteConfiguration : TeaModel {
                [NameInMap("IndexDocument")]
                [Validation(Required=false)]
                public PutBucketWebsiteRequestIndexDocument IndexDocument { get; set; }
                public class PutBucketWebsiteRequestIndexDocument : TeaModel {
                    [NameInMap("Suffix")]
                    [Validation(Required=false)]
                    public string Suffix { get; set; }
                };

                [NameInMap("ErrorDocument")]
                [Validation(Required=false)]
                public PutBucketWebsiteRequestErrorDocument ErrorDocument { get; set; }
                public class PutBucketWebsiteRequestErrorDocument : TeaModel {
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }
                };

                [NameInMap("RoutingRules")]
                [Validation(Required=false)]
                public PutBucketWebsiteRequestRoutingRules RoutingRules { get; set; }
                public class PutBucketWebsiteRequestRoutingRules : TeaModel {
                    [NameInMap("RoutingRule")]
                    [Validation(Required=false)]
                    public List<PutBucketWebsiteRequestCondition> RoutingRule { get; set; }
                    public class PutBucketWebsiteRequestCondition : TeaModel {
                        [NameInMap("IncludeHeader")]
                        [Validation(Required=false)]
                        public PutBucketWebsiteRequestIncludeHeader IncludeHeader { get; set; }
                        public class PutBucketWebsiteRequestIncludeHeader : TeaModel {
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
