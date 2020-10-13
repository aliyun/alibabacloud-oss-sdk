// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.OSS.Models
{
    public class PutObjectResponse : TeaModel {
        /// <summary>
        /// x-oss-request-id
        /// </summary>
        [NameInMap("x-oss-request-id")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        /// <summary>
        /// x-oss-hash-crc64ecma
        /// </summary>
        [NameInMap("x-oss-hash-crc64ecma")]
        [Validation(Required=true)]
        public string HashCrc64ecma { get; set; }

        /// <summary>
        /// x-oss-server-time
        /// </summary>
        [NameInMap("x-oss-server-time")]
        [Validation(Required=true)]
        public string ServerTime { get; set; }

        /// <summary>
        /// x-oss-bucket-version
        /// </summary>
        [NameInMap("x-oss-bucket-version")]
        [Validation(Required=true)]
        public string BucketVersion { get; set; }

    }

}
