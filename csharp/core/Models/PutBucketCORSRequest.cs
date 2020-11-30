// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.OSS.Models
{
    public class PutBucketCORSRequest : TeaModel {
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
        public PutBucketCORSRequestBody Body { get; set; }
        public class PutBucketCORSRequestBody : TeaModel {
            [NameInMap("CORSConfiguration")]
            [Validation(Required=true)]
            public PutBucketCORSRequestBodyCORSConfiguration CORSConfiguration { get; set; }
            public class PutBucketCORSRequestBodyCORSConfiguration : TeaModel {
                /// <summary>
                /// CORSRule
                /// </summary>
                [NameInMap("CORSRule")]
                [Validation(Required=false)]
                public List<PutBucketCORSRequestBodyCORSConfigurationCORSRule> CORSRule { get; set; }
                public class PutBucketCORSRequestBodyCORSConfigurationCORSRule : TeaModel {
                    /// <summary>
                    /// AllowedOrigin
                    /// </summary>
                    [NameInMap("AllowedOrigin")]
                    [Validation(Required=false)]
                    public List<string> AllowedOrigin { get; set; }

                    /// <summary>
                    /// AllowedMethod
                    /// </summary>
                    [NameInMap("AllowedMethod")]
                    [Validation(Required=false)]
                    public List<string> AllowedMethod { get; set; }

                    /// <summary>
                    /// AllowedHeader
                    /// </summary>
                    [NameInMap("AllowedHeader")]
                    [Validation(Required=false)]
                    public List<string> AllowedHeader { get; set; }

                    /// <summary>
                    /// ExposeHeader
                    /// </summary>
                    [NameInMap("ExposeHeader")]
                    [Validation(Required=false)]
                    public List<string> ExposeHeader { get; set; }

                    /// <summary>
                    /// MaxAgeSeconds
                    /// </summary>
                    [NameInMap("MaxAgeSeconds")]
                    [Validation(Required=false)]
                    public string MaxAgeSeconds { get; set; }

                }

            }
        };

    }

}
