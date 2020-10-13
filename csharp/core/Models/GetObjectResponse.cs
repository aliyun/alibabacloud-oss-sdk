// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.OSS.Models
{
    public class GetObjectResponse : TeaModel {
        /// <summary>
        /// x-oss-request-id
        /// </summary>
        [NameInMap("x-oss-request-id")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        /// <summary>
        /// x-oss-object-type
        /// </summary>
        [NameInMap("x-oss-object-type")]
        [Validation(Required=true)]
        public string ObjectType { get; set; }

        /// <summary>
        /// x-oss-server-side-encryption
        /// </summary>
        [NameInMap("x-oss-server-side-encryption")]
        [Validation(Required=true)]
        public string ServerSideEncryption { get; set; }

        /// <summary>
        /// x-oss-tagging-count
        /// </summary>
        [NameInMap("x-oss-tagging-count")]
        [Validation(Required=true)]
        public string TaggingCount { get; set; }

        /// <summary>
        /// x-oss-restore
        /// </summary>
        [NameInMap("x-oss-restore")]
        [Validation(Required=true)]
        public string Restore { get; set; }

        /// <summary>
        /// body
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=true)]
        public Stream Body { get; set; }

    }

}
