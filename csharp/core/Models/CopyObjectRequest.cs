// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.OSS.Models
{
    public class CopyObjectRequest : TeaModel {
        /// <summary>
        /// BucketName
        /// </summary>
        [NameInMap("BucketName")]
        [Validation(Required=true, Pattern="[a-zA-Z0-9-_]+")]
        public string BucketName { get; set; }

        /// <summary>
        /// DestObjectName
        /// </summary>
        [NameInMap("DestObjectName")]
        [Validation(Required=true)]
        public string DestObjectName { get; set; }

        /// <summary>
        /// Header
        /// </summary>
        [NameInMap("Header")]
        [Validation(Required=true)]
        public CopyObjectRequestHeader Header { get; set; }
        public class CopyObjectRequestHeader : TeaModel {
            [NameInMap("x-oss-copy-source")]
            [Validation(Required=true)]
            public string CopySource { get; set; }
            [NameInMap("x-oss-copy-source-if-match")]
            [Validation(Required=false)]
            public string CopySourceIfMatch { get; set; }
            [NameInMap("x-oss-copy-source-if-none-match")]
            [Validation(Required=false)]
            public string CopySourceIfNoneMatch { get; set; }
            [NameInMap("x-oss-copy-source-if-unmodified-since")]
            [Validation(Required=false)]
            public string CopySourceIfUnmodifiedSince { get; set; }
            [NameInMap("x-oss-copy-source-if-modified-since")]
            [Validation(Required=false)]
            public string CopySourceIfModifiedSince { get; set; }
            [NameInMap("x-oss-metadata-directive")]
            [Validation(Required=false)]
            public string MetadataDirective { get; set; }
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
            [NameInMap("x-oss-tagging-directive")]
            [Validation(Required=false)]
            public string TaggingDirective { get; set; }
        };

    }

}
