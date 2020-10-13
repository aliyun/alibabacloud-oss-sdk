// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.OSS.Models
{
    public class GetBucketCORSResponse : TeaModel {
        /// <summary>
        /// x-oss-request-id
        /// </summary>
        [NameInMap("x-oss-request-id")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        /// <summary>
        /// CORSConfiguration
        /// </summary>
        [NameInMap("CORSConfiguration")]
        [Validation(Required=true)]
        public GetBucketCORSResponseCORSConfiguration CORSConfiguration { get; set; }
        public class GetBucketCORSResponseCORSConfiguration : TeaModel {
            [NameInMap("CORSRule")]
            [Validation(Required=false)]
            public List<GetBucketCORSResponseCORSConfigurationCORSRule> CORSRule { get; set; }
            public class GetBucketCORSResponseCORSConfigurationCORSRule : TeaModel {
                public string MaxAgeSeconds { get; set; }
            }
        };

    }

}
