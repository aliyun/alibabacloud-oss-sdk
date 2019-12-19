// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.OSS.Models
{
    public class GetBucketCORSResponse : TeaModel {
        [NameInMap("x-oss-request-id")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("CORSConfiguration")]
        [Validation(Required=true)]
        public GetBucketCORSResponseCORSConfiguration CORSConfiguration { get; set; }
        public class GetBucketCORSResponseCORSConfiguration : TeaModel {
            [NameInMap("CORSRule")]
            [Validation(Required=false)]
            public List<GetBucketCORSResponseMaxAgeSeconds> CORSRule { get; set; }
            public class GetBucketCORSResponseMaxAgeSeconds : TeaModel {
                    public string MaxAgeSeconds { get; set; }
            }
        };

    }

}
