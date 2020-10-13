// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.OSS.Models
{
    public class InitiateMultipartUploadResponse : TeaModel {
        /// <summary>
        /// x-oss-request-id
        /// </summary>
        [NameInMap("x-oss-request-id")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        /// <summary>
        /// InitiateMultipartUploadResult
        /// </summary>
        [NameInMap("InitiateMultipartUploadResult")]
        [Validation(Required=true)]
        public InitiateMultipartUploadResponseInitiateMultipartUploadResult InitiateMultipartUploadResult { get; set; }
        public class InitiateMultipartUploadResponseInitiateMultipartUploadResult : TeaModel {
            [NameInMap("Bucket")]
            [Validation(Required=false)]
            public string Bucket { get; set; }
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }
            [NameInMap("UploadId")]
            [Validation(Required=false)]
            public string UploadId { get; set; }
        };

    }

}
