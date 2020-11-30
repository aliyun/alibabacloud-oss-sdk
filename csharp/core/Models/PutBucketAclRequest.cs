// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.OSS.Models
{
    public class PutBucketAclRequest : TeaModel {
        /// <summary>
        /// BucketName
        /// </summary>
        [NameInMap("BucketName")]
        [Validation(Required=true, Pattern="[a-zA-Z0-9-_]+")]
        public string BucketName { get; set; }

        /// <summary>
        /// Header
        /// </summary>
        [NameInMap("Header")]
        [Validation(Required=true)]
        public PutBucketAclRequestHeader Header { get; set; }
        public class PutBucketAclRequestHeader : TeaModel {
            [NameInMap("x-oss-acl")]
            [Validation(Required=true)]
            public string Acl { get; set; }
        };

    }

}
