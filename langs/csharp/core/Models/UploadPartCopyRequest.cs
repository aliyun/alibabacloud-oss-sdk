// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.OSS.Models
{
    public class UploadPartCopyRequest : TeaModel {
        [NameInMap("BucketName")]
        [Validation(Required=true)]
        public string BucketName { get; set; }

        [NameInMap("ObjectName")]
        [Validation(Required=true)]
        public string ObjectName { get; set; }

        [NameInMap("Filter")]
        [Validation(Required=true)]
        public UploadPartCopyRequestFilter Filter { get; set; }
        public class UploadPartCopyRequestFilter : TeaModel {
            [NameInMap("partNumber")]
            [Validation(Required=true)]
            public string PartNumber { get; set; }
            [NameInMap("uploadId")]
            [Validation(Required=true)]
            public string UploadId { get; set; }
        };

        [NameInMap("Header")]
        [Validation(Required=true)]
        public UploadPartCopyRequestHeader Header { get; set; }
        public class UploadPartCopyRequestHeader : TeaModel {
            [NameInMap("x-oss-copy-source")]
            [Validation(Required=true)]
            public string CopySource { get; set; }
            [NameInMap("x-oss-copy-source-range")]
            [Validation(Required=true)]
            public string CopySourceRange { get; set; }
            [NameInMap("x-oss-copy-source-if-match")]
            [Validation(Required=false)]
            public string CopySourceIfMatch { get; set; }
            [NameInMap("x-oss-copy-source-if-none-match")]
            [Validation(Required=false)]
            public string CopySourceIfNoneMatch { get; set; }
            [NameInMap("x-oss-copy-source-if-unmodified-since")]
            [Validation(Required=false)]
            public string CopySourceIfUnmodifiedSince { get; set; }
            [NameInMap("x-oss-copy-source-if-modified-since")]
            [Validation(Required=false)]
            public string CopySourceIfModifiedSince { get; set; }
        };

    }

}
