// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.OSS.Models
{
    public class GetObjectMetaResponse : TeaModel {
        [NameInMap("x-oss-request-id")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("etag")]
        [Validation(Required=true)]
        public string ETag { get; set; }

        [NameInMap("content-length")]
        [Validation(Required=true)]
        public string ContentLength { get; set; }

        [NameInMap("last-modified")]
        [Validation(Required=true)]
        public string LastModified { get; set; }

    }

}
