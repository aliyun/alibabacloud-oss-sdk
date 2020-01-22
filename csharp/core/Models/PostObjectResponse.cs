// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.OSS.Models
{
    public class PostObjectResponse : TeaModel {
        [NameInMap("PostResponse")]
        [Validation(Required=true)]
        public PostObjectResponsePostResponse PostResponse { get; set; }
        public class PostObjectResponsePostResponse : TeaModel {
            [NameInMap("Bucket")]
            [Validation(Required=true)]
            public string Bucket { get; set; }
            [NameInMap("ETag")]
            [Validation(Required=true)]
            public string ETag { get; set; }
            [NameInMap("Location")]
            [Validation(Required=true)]
            public string Location { get; set; }
        };

    }

}
