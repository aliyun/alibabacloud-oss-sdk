// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.OSS.Models
{
    public class UploadPartCopyResponse : TeaModel {
        [NameInMap("x-oss-request-id")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("CopyPartResult")]
        [Validation(Required=true)]
        public UploadPartCopyResponseCopyPartResult CopyPartResult { get; set; }
        public class UploadPartCopyResponseCopyPartResult : TeaModel {
            [NameInMap("LastModified")]
            [Validation(Required=false)]
            public string LastModified { get; set; }
            [NameInMap("ETag")]
            [Validation(Required=false)]
            public string ETag { get; set; }
        };

    }

}
