// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.OSS.Models
{
    public class PutBucketCORSRequest : TeaModel {
        [NameInMap("BucketName")]
        [Validation(Required=true)]
        public string BucketName { get; set; }

        [NameInMap("Body")]
        [Validation(Required=false)]
        public PutBucketCORSRequestBody Body { get; set; }
        public class PutBucketCORSRequestBody : TeaModel {
            [NameInMap("CORSConfiguration")]
            [Validation(Required=true)]
            public PutBucketCORSRequestBodyCORSConfiguration CORSConfiguration { get; set; }
            public class PutBucketCORSRequestBodyCORSConfiguration : TeaModel {
                [NameInMap("CORSRule")]
                [Validation(Required=false)]
                public List<PutBucketCORSRequestBodyCORSConfigurationCORSRule> CORSRule { get; set; }
                public class PutBucketCORSRequestBodyCORSConfigurationCORSRule : TeaModel {
                    [NameInMap("AllowedOrigin")]
                    [Validation(Required=false)]
                    public List<string> AllowedOrigin { get; set; }

                    [NameInMap("AllowedMethod")]
                    [Validation(Required=false)]
                    public List<string> AllowedMethod { get; set; }

                    [NameInMap("AllowedHeader")]
                    [Validation(Required=false)]
                    public List<string> AllowedHeader { get; set; }

                    [NameInMap("ExposeHeader")]
                    [Validation(Required=false)]
                    public List<string> ExposeHeader { get; set; }

                    [NameInMap("MaxAgeSeconds")]
                    [Validation(Required=false)]
                    public string MaxAgeSeconds { get; set; }

                }

            }
        };

    }

}
