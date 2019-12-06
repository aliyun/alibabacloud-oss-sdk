// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.OSS.Models
{
    public class GetBucketRequest : TeaModel {
        [NameInMap("BucketName")]
        [Validation(Required=true)]
        public string BucketName { get; set; }

        [NameInMap("Filter")]
        [Validation(Required=false)]
        public GetBucketRequestFilter Filter { get; set; }
        public class GetBucketRequestFilter : TeaModel {
            [NameInMap("delimiter")]
            [Validation(Required=false)]
            public string Delimiter { get; set; }
            [NameInMap("marker")]
            [Validation(Required=false)]
            public string Marker { get; set; }
            [NameInMap("max-keys")]
            [Validation(Required=false)]
            public string MaxKeys { get; set; }
            [NameInMap("prefix")]
            [Validation(Required=false)]
            public string Prefix { get; set; }
            [NameInMap("encoding-type")]
            [Validation(Required=false)]
            public string EncodingType { get; set; }
        };

    }

}
