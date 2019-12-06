// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.OSS.Models
{
    public class PutSymlinkRequest : TeaModel {
        [NameInMap("BucketName")]
        [Validation(Required=true)]
        public string BucketName { get; set; }

        [NameInMap("ObjectName")]
        [Validation(Required=true)]
        public string ObjectName { get; set; }

        [NameInMap("Header")]
        [Validation(Required=true)]
        public PutSymlinkRequestHeader Header { get; set; }
        public class PutSymlinkRequestHeader : TeaModel {
            [NameInMap("x-oss-symlink-target")]
            [Validation(Required=true)]
            public string SymlinkTarget { get; set; }
            [NameInMap("x-oss-storage-class")]
            [Validation(Required=false)]
            public string StorageClass { get; set; }
        };

    }

}
