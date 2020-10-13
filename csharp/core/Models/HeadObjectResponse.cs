// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.OSS.Models
{
    public class HeadObjectResponse : TeaModel {
        /// <summary>
        /// x-oss-request-id
        /// </summary>
        [NameInMap("x-oss-request-id")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        /// <summary>
        /// usermeta
        /// </summary>
        [NameInMap("usermeta")]
        [Validation(Required=true)]
        public Dictionary<string, string> UserMeta { get; set; }

        /// <summary>
        /// x-oss-server-side-encryption
        /// </summary>
        [NameInMap("x-oss-server-side-encryption")]
        [Validation(Required=true)]
        public string ServerSideEncryption { get; set; }

        /// <summary>
        /// x-oss-server-side-encryption-key-id
        /// </summary>
        [NameInMap("x-oss-server-side-encryption-key-id")]
        [Validation(Required=true)]
        public string ServerSideEncryptionKeyId { get; set; }

        /// <summary>
        /// x-oss-storage-class
        /// </summary>
        [NameInMap("x-oss-storage-class")]
        [Validation(Required=true)]
        public string StorageClass { get; set; }

        /// <summary>
        /// x-oss-object-type
        /// </summary>
        [NameInMap("x-oss-object-type")]
        [Validation(Required=true)]
        public string ObjectType { get; set; }

        /// <summary>
        /// x-oss-next-append-position
        /// </summary>
        [NameInMap("x-oss-next-append-position")]
        [Validation(Required=true)]
        public string NextAppendPosition { get; set; }

        /// <summary>
        /// x-oss-hash-crc64ecma
        /// </summary>
        [NameInMap("x-oss-hash-crc64ecma")]
        [Validation(Required=true)]
        public string HashCrc64ecma { get; set; }

        /// <summary>
        /// x-oss-expiration
        /// </summary>
        [NameInMap("x-oss-expiration")]
        [Validation(Required=true)]
        public string Expiration { get; set; }

        /// <summary>
        /// x-oss-restore
        /// </summary>
        [NameInMap("x-oss-restore")]
        [Validation(Required=true)]
        public string Restore { get; set; }

        /// <summary>
        /// x-oss-process-status
        /// </summary>
        [NameInMap("x-oss-process-status")]
        [Validation(Required=true)]
        public string ProcessStatus { get; set; }

        /// <summary>
        /// x-oss-request-charged
        /// </summary>
        [NameInMap("x-oss-request-charged")]
        [Validation(Required=true)]
        public string RequestCharged { get; set; }

        /// <summary>
        /// Content-Md5
        /// </summary>
        [NameInMap("content-md5")]
        [Validation(Required=true)]
        public string ContentMd5 { get; set; }

        /// <summary>
        /// Last-Modified
        /// </summary>
        [NameInMap("last-modified")]
        [Validation(Required=true)]
        public string LastModified { get; set; }

        /// <summary>
        /// Access-Control-Allow-Origin
        /// </summary>
        [NameInMap("access-control-allow-origin")]
        [Validation(Required=true)]
        public string AccessControlAllowOrigin { get; set; }

        /// <summary>
        /// Access-Control-Allow-Methods
        /// </summary>
        [NameInMap("access-control-allow-methods")]
        [Validation(Required=true)]
        public string AccessControlAllowMethods { get; set; }

        /// <summary>
        /// Access-Control-Max-Age
        /// </summary>
        [NameInMap("access-control-max-age")]
        [Validation(Required=true)]
        public string AccessControlMaxAge { get; set; }

        /// <summary>
        /// Access-Control-Allow-Headers
        /// </summary>
        [NameInMap("access-control-allow-headers")]
        [Validation(Required=true)]
        public string AccessControlAllowHeaders { get; set; }

        /// <summary>
        /// Access-Control-Expose-Headers
        /// </summary>
        [NameInMap("access-control-expose-headers")]
        [Validation(Required=true)]
        public string AccessControlExposeHeaders { get; set; }

        /// <summary>
        /// x-oss-tagging-count
        /// </summary>
        [NameInMap("x-oss-tagging-count")]
        [Validation(Required=true)]
        public string TaggingCount { get; set; }

    }

}
