// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.OSS.Models
{
    public class InitiateMultipartUploadRequest : TeaModel {
        /// <summary>
        /// BucketName
        /// </summary>
        [NameInMap("BucketName")]
        [Validation(Required=true, Pattern="[a-zA-Z0-9-_]+")]
        public string BucketName { get; set; }

        /// <summary>
        /// ObjectName
        /// </summary>
        [NameInMap("ObjectName")]
        [Validation(Required=true)]
        public string ObjectName { get; set; }

        /// <summary>
        /// Filter
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public InitiateMultipartUploadRequestFilter Filter { get; set; }
        public class InitiateMultipartUploadRequestFilter : TeaModel {
            [NameInMap("encoding-type")]
            [Validation(Required=false)]
            public string EncodingType { get; set; }
        };

        /// <summary>
        /// Header
        /// </summary>
        [NameInMap("Header")]
        [Validation(Required=false)]
        public InitiateMultipartUploadRequestHeader Header { get; set; }
        public class InitiateMultipartUploadRequestHeader : TeaModel {
            [NameInMap("Cache-Control")]
            [Validation(Required=false)]
            public string CacheControl { get; set; }
            [NameInMap("Content-Disposition")]
            [Validation(Required=false)]
            public string ContentDisposition { get; set; }
            [NameInMap("Content-Encoding")]
            [Validation(Required=false)]
            public string ContentEncoding { get; set; }
            [NameInMap("Expires")]
            [Validation(Required=false)]
            public string Expires { get; set; }
            [NameInMap("x-oss-server-side-encryption")]
            [Validation(Required=false)]
            public string ServerSideEncryption { get; set; }
            [NameInMap("x-oss-server-side-encryption-key-id")]
            [Validation(Required=false)]
            public string ServerSideEncryptionKeyId { get; set; }
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
