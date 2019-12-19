// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.OSS.Models
{
    public class CompleteMultipartUploadRequest : TeaModel {
        [NameInMap("BucketName")]
        [Validation(Required=true)]
        public string BucketName { get; set; }

        [NameInMap("ObjectName")]
        [Validation(Required=true)]
        public string ObjectName { get; set; }

        [NameInMap("Filter")]
        [Validation(Required=true)]
        public CompleteMultipartUploadRequestFilter Filter { get; set; }
        public class CompleteMultipartUploadRequestFilter : TeaModel {
            [NameInMap("uploadId")]
            [Validation(Required=true)]
            public string UploadId { get; set; }
            [NameInMap("Encoding-type")]
            [Validation(Required=false)]
            public string EncodingType { get; set; }
        };

        [NameInMap("Body")]
        [Validation(Required=false)]
        public CompleteMultipartUploadRequestBody Body { get; set; }
        public class CompleteMultipartUploadRequestBody : TeaModel {
            [NameInMap("CompleteMultipartUpload")]
            [Validation(Required=true)]
            public CompleteMultipartUploadRequestCompleteMultipartUpload CompleteMultipartUpload { get; set; }
            public class CompleteMultipartUploadRequestCompleteMultipartUpload : TeaModel {
                [NameInMap("Part")]
                [Validation(Required=false)]
                public List<CompleteMultipartUploadRequestPart> Part { get; set; }
                public class CompleteMultipartUploadRequestPart : TeaModel {
                    [NameInMap("PartNumber")]
                    [Validation(Required=false)]
                    public string PartNumber { get; set; }

                    [NameInMap("ETag")]
                    [Validation(Required=false)]
                    public string ETag { get; set; }

                }

            }
        };

    }

}
