// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.OSS.Models
{
    public class PutObjectResponse : TeaModel {
        [NameInMap("x-oss-request-id")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("x-oss-hash-crc64ecma")]
        [Validation(Required=true)]
        public string HashCrc64ecma { get; set; }

        [NameInMap("x-oss-server-time")]
        [Validation(Required=true)]
        public string ServerTime { get; set; }

        [NameInMap("x-oss-bucket-version")]
        [Validation(Required=true)]
        public string BucketVersion { get; set; }

    }

}
