// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.OSS.Models
{
    public class CompleteMultipartUploadResponse : TeaModel {
        /// <summary>
        /// x-oss-request-id
        /// </summary>
        [NameInMap("x-oss-request-id")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        /// <summary>
        /// CompleteMultipartUploadResult
        /// </summary>
        [NameInMap("CompleteMultipartUploadResult")]
        [Validation(Required=true)]
        public CompleteMultipartUploadResponseCompleteMultipartUploadResult CompleteMultipartUploadResult { get; set; }
        public class CompleteMultipartUploadResponseCompleteMultipartUploadResult : TeaModel {
            [NameInMap("Bucket")]
            [Validation(Required=false)]
            public string Bucket { get; set; }
            [NameInMap("ETag")]
            [Validation(Required=false)]
            public string ETag { get; set; }
            [NameInMap("Location")]
            [Validation(Required=false)]
            public string Location { get; set; }
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }
            [NameInMap("EncodingType")]
            [Validation(Required=false)]
            public string EncodingType { get; set; }
        };

    }

}
