// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.OSS.Models
{
    public class UploadPartRequest : TeaModel {
        [NameInMap("BucketName")]
        [Validation(Required=true)]
        public string BucketName { get; set; }

        [NameInMap("ObjectName")]
        [Validation(Required=true)]
        public string ObjectName { get; set; }

        [NameInMap("body")]
        [Validation(Required=false)]
        public Stream Body { get; set; }

        [NameInMap("Filter")]
        [Validation(Required=true)]
        public UploadPartRequestFilter Filter { get; set; }
        public class UploadPartRequestFilter : TeaModel {
            [NameInMap("partNumber")]
            [Validation(Required=true)]
            public string PartNumber { get; set; }
            [NameInMap("uploadId")]
            [Validation(Required=true)]
            public string UploadId { get; set; }
        };

    }

}
