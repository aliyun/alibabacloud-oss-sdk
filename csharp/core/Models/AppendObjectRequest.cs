// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.OSS.Models
{
    public class AppendObjectRequest : TeaModel {
        [NameInMap("BucketName")]
        [Validation(Required=true)]
        public string BucketName { get; set; }

        [NameInMap("ObjectName")]
        [Validation(Required=true)]
        public string ObjectName { get; set; }

        [NameInMap("UserMeta")]
        [Validation(Required=false)]
        public Dictionary<string, string> UserMeta { get; set; }

        [NameInMap("body")]
        [Validation(Required=false)]
        public Stream Body { get; set; }

        [NameInMap("Filter")]
        [Validation(Required=true)]
        public AppendObjectRequestFilter Filter { get; set; }
        public class AppendObjectRequestFilter : TeaModel {
            [NameInMap("position")]
            [Validation(Required=true)]
            public string Position { get; set; }
        };

        [NameInMap("Header")]
        [Validation(Required=false)]
        public AppendObjectRequestHeader Header { get; set; }
        public class AppendObjectRequestHeader : TeaModel {
            [NameInMap("Cache-Control")]
            [Validation(Required=false)]
            public string CacheControl { get; set; }
            [NameInMap("Content-Disposition")]
            [Validation(Required=false)]
            public string ContentDisposition { get; set; }
            [NameInMap("Content-Encoding")]
            [Validation(Required=false)]
            public string ContentEncoding { get; set; }
            [NameInMap("Content-MD5")]
            [Validation(Required=false)]
            public string ContentMD5 { get; set; }
            [NameInMap("Expires")]
            [Validation(Required=false)]
            public string Expires { get; set; }
            [NameInMap("x-oss-server-side-encryption")]
            [Validation(Required=false)]
            public string ServerSideEncryption { get; set; }
            [NameInMap("x-oss-object-acl")]
            [Validation(Required=false)]
            public string ObjectAcl { get; set; }
            [NameInMap("x-oss-storage-class")]
            [Validation(Required=false)]
            public string StorageClass { get; set; }
            [NameInMap("content-type")]
            [Validation(Required=false)]
            public string ContentType { get; set; }
        };

    }

}
