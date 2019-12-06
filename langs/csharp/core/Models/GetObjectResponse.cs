// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.OSS.Models
{
    public class GetObjectResponse : TeaModel {
        [NameInMap("x-oss-request-id")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("x-oss-object-type")]
        [Validation(Required=true)]
        public string ObjectType { get; set; }

        [NameInMap("x-oss-server-side-encryption")]
        [Validation(Required=true)]
        public string ServerSideEncryption { get; set; }

        [NameInMap("x-oss-tagging-count")]
        [Validation(Required=true)]
        public string TaggingCount { get; set; }

        [NameInMap("x-oss-restore")]
        [Validation(Required=true)]
        public string Restore { get; set; }

        [NameInMap("body")]
        [Validation(Required=true)]
        public Stream Body { get; set; }

    }

}
