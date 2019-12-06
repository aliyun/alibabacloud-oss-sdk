// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.OSS.Models
{
    public class CopyObjectResponse : TeaModel {
        [NameInMap("x-oss-request-id")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("CopyObjectResult")]
        [Validation(Required=true)]
        public CopyObjectResponseCopyObjectResult CopyObjectResult { get; set; }
        public class CopyObjectResponseCopyObjectResult : TeaModel {
            [NameInMap("LastModified")]
            [Validation(Required=true)]
            public string LastModified { get; set; }
            [NameInMap("ETag")]
            [Validation(Required=true)]
            public string ETag { get; set; }
        };

    }

}
