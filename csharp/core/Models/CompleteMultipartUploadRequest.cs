// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.OSS.Models
{
    public class CompleteMultipartUploadRequest : TeaModel {
        /// <summary>
        /// BucketName
        /// </summary>
        [NameInMap("BucketName")]
        [Validation(Required=true, Pattern="[a-zA-Z0-9-_]+")]
        public string BucketName { get; set; }

        /// <summary>
        /// ObjectName
        /// </summary>
        [NameInMap("ObjectName")]
        [Validation(Required=true)]
        public string ObjectName { get; set; }

        /// <summary>
        /// Filter
        /// </summary>
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

        /// <summary>
        /// Body
        /// </summary>
        [NameInMap("Body")]
        [Validation(Required=false)]
        public CompleteMultipartUploadRequestBody Body { get; set; }
        public class CompleteMultipartUploadRequestBody : TeaModel {
            [NameInMap("CompleteMultipartUpload")]
            [Validation(Required=true)]
            public CompleteMultipartUploadRequestBodyCompleteMultipartUpload CompleteMultipartUpload { get; set; }
            public class CompleteMultipartUploadRequestBodyCompleteMultipartUpload : TeaModel {
                /// <summary>
                /// Part
                /// </summary>
                [NameInMap("Part")]
                [Validation(Required=false)]
                public List<CompleteMultipartUploadRequestBodyCompleteMultipartUploadPart> Part { get; set; }
                public class CompleteMultipartUploadRequestBodyCompleteMultipartUploadPart : TeaModel {
                    /// <summary>
                    /// PartNumber
                    /// </summary>
                    [NameInMap("PartNumber")]
                    [Validation(Required=false)]
                    public string PartNumber { get; set; }

                    /// <summary>
                    /// ETag
                    /// </summary>
                    [NameInMap("ETag")]
                    [Validation(Required=false)]
                    public string ETag { get; set; }

                }

            }
        };

    }

}
