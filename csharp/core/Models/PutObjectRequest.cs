// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.OSS.Models
{
    public class PutObjectRequest : TeaModel {
        /// <summary>
        /// BucketName
        /// </summary>
        [NameInMap("BucketName")]
        [Validation(Required=true, Pattern="[a-zA-Z0-9\\-\\_]+")]
        public string BucketName { get; set; }

        /// <summary>
        /// ObjectName
        /// </summary>
        [NameInMap("ObjectName")]
        [Validation(Required=true)]
        public string ObjectName { get; set; }

        /// <summary>
        /// UserMeta
        /// </summary>
        [NameInMap("UserMeta")]
        [Validation(Required=false)]
        public Dictionary<string, string> UserMeta { get; set; }

        /// <summary>
        /// body
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public Stream Body { get; set; }

        /// <summary>
        /// Header
        /// </summary>
        [NameInMap("Header")]
        [Validation(Required=false)]
        public PutObjectRequestHeader Header { get; set; }
        public class PutObjectRequestHeader : TeaModel {
            [NameInMap("Authorization")]
            [Validation(Required=false)]
            public string Authorization { get; set; }
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
            [NameInMap("Content-Length")]
            [Validation(Required=false)]
            public string ContentLength { get; set; }
            [NameInMap("CETag")]
            [Validation(Required=false)]
            public string ETag { get; set; }
            [NameInMap("Expires")]
            [Validation(Required=false)]
            public string Expires { get; set; }
            [NameInMap("x-oss-server-side-encryption")]
            [Validation(Required=false)]
            public string ServerSideEncryption { get; set; }
            [NameInMap("x-oss-server-side-encryption-key-id")]
            [Validation(Required=false)]
            public string ServerSideEncryptionKeyId { get; set; }
            [NameInMap("x-oss-object-acl")]
            [Validation(Required=false)]
            public string ObjectAcl { get; set; }
            [NameInMap("x-oss-storage-class")]
            [Validation(Required=false)]
            public string StorageClass { get; set; }
            [NameInMap("x-oss-tagging")]
            [Validation(Required=false)]
            public string Tagging { get; set; }
            [NameInMap("content-type")]
            [Validation(Required=false)]
            public string ContentType { get; set; }
        };

    }

}
