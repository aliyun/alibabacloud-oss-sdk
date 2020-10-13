// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.OSS.Models
{
    public class GetObjectMetaResponse : TeaModel {
        /// <summary>
        /// x-oss-request-id
        /// </summary>
        [NameInMap("x-oss-request-id")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        /// <summary>
        /// ETag
        /// </summary>
        [NameInMap("etag")]
        [Validation(Required=true)]
        public string ETag { get; set; }

        /// <summary>
        /// Content-Length
        /// </summary>
        [NameInMap("content-length")]
        [Validation(Required=true)]
        public string ContentLength { get; set; }

        /// <summary>
        /// Last-Modified
        /// </summary>
        [NameInMap("last-modified")]
        [Validation(Required=true)]
        public string LastModified { get; set; }

    }

}
