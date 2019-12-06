// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.OSS.Models
{
    public class HeadObjectResponse : TeaModel {
        [NameInMap("x-oss-request-id")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("usermeta")]
        [Validation(Required=true)]
        public Dictionary<string, string> UserMeta { get; set; }

        [NameInMap("x-oss-server-side-encryption")]
        [Validation(Required=true)]
        public string ServerSideEncryption { get; set; }

        [NameInMap("x-oss-server-side-encryption-key-id")]
        [Validation(Required=true)]
        public string ServerSideEncryptionKeyId { get; set; }

        [NameInMap("x-oss-storage-class")]
        [Validation(Required=true)]
        public string StorageClass { get; set; }

        [NameInMap("x-oss-object-type")]
        [Validation(Required=true)]
        public string ObjectType { get; set; }

        [NameInMap("x-oss-next-append-position")]
        [Validation(Required=true)]
        public string NextAppendPosition { get; set; }

        [NameInMap("x-oss-hash-crc64ecma")]
        [Validation(Required=true)]
        public string HashCrc64ecma { get; set; }

        [NameInMap("x-oss-expiration")]
        [Validation(Required=true)]
        public string Expiration { get; set; }

        [NameInMap("x-oss-restore")]
        [Validation(Required=true)]
        public string Restore { get; set; }

        [NameInMap("x-oss-process-status")]
        [Validation(Required=true)]
        public string ProcessStatus { get; set; }

        [NameInMap("x-oss-request-charged")]
        [Validation(Required=true)]
        public string RequestCharged { get; set; }

        [NameInMap("content-md5")]
        [Validation(Required=true)]
        public string ContentMd5 { get; set; }

        [NameInMap("last-modified")]
        [Validation(Required=true)]
        public string LastModified { get; set; }

        [NameInMap("access-control-allow-origin")]
        [Validation(Required=true)]
        public string AccessControlAllowOrigin { get; set; }

        [NameInMap("access-control-allow-methods")]
        [Validation(Required=true)]
        public string AccessControlAllowMethods { get; set; }

        [NameInMap("access-control-max-age")]
        [Validation(Required=true)]
        public string AccessControlMaxAge { get; set; }

        [NameInMap("access-control-allow-headers")]
        [Validation(Required=true)]
        public string AccessControlAllowHeaders { get; set; }

        [NameInMap("access-control-expose-headers")]
        [Validation(Required=true)]
        public string AccessControlExposeHeaders { get; set; }

        [NameInMap("x-oss-tagging-count")]
        [Validation(Required=true)]
        public string TaggingCount { get; set; }

    }

}
