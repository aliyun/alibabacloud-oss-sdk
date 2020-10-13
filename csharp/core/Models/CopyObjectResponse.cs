// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.OSS.Models
{
    public class CopyObjectResponse : TeaModel {
        /// <summary>
        /// x-oss-request-id
        /// </summary>
        [NameInMap("x-oss-request-id")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        /// <summary>
        /// CopyObjectResult
        /// </summary>
        [NameInMap("CopyObjectResult")]
        [Validation(Required=true)]
        public CopyObjectResponseCopyObjectResult CopyObjectResult { get; set; }
        public class CopyObjectResponseCopyObjectResult : TeaModel {
            [NameInMap("LastModified")]
            [Validation(Required=false)]
            public string LastModified { get; set; }
            [NameInMap("ETag")]
            [Validation(Required=false)]
            public string ETag { get; set; }
        };

    }

}
