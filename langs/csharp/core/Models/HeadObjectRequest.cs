// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.OSS.Models
{
    public class HeadObjectRequest : TeaModel {
        [NameInMap("BucketName")]
        [Validation(Required=true)]
        public string BucketName { get; set; }

        [NameInMap("ObjectName")]
        [Validation(Required=true)]
        public string ObjectName { get; set; }

        [NameInMap("Header")]
        [Validation(Required=false)]
        public HeadObjectRequestHeader Header { get; set; }
        public class HeadObjectRequestHeader : TeaModel {
            [NameInMap("If-Modified-Since")]
            [Validation(Required=false)]
            public string IfModifiedSince { get; set; }
            [NameInMap("If-Unmodified-Since")]
            [Validation(Required=false)]
            public string IfUnmodifiedSince { get; set; }
            [NameInMap("If-Match")]
            [Validation(Required=false)]
            public string IfMatch { get; set; }
            [NameInMap("If-None-Match")]
            [Validation(Required=false)]
            public string IfNoneMatch { get; set; }
        };

    }

}
