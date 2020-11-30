// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.OSS.Models
{
    public class UploadPartRequest : TeaModel {
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
        /// body
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public Stream Body { get; set; }

        /// <summary>
        /// Filter
        /// </summary>
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
