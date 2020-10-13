// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.OSS.Models
{
    public class GetObjectRequest : TeaModel {
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
        /// Header
        /// </summary>
        [NameInMap("Header")]
        [Validation(Required=false)]
        public GetObjectRequestHeader Header { get; set; }
        public class GetObjectRequestHeader : TeaModel {
            [NameInMap("response-content-type")]
            [Validation(Required=false)]
            public string ResponseContentType { get; set; }
            [NameInMap("response-content-language")]
            [Validation(Required=false)]
            public string ResponseContentLanguage { get; set; }
            [NameInMap("response-expires")]
            [Validation(Required=false)]
            public string ResponseExpires { get; set; }
            [NameInMap("response-cache-control")]
            [Validation(Required=false)]
            public string ResponseCacheControl { get; set; }
            [NameInMap("response-content-disposition")]
            [Validation(Required=false)]
            public string ResponseContentDisposition { get; set; }
            [NameInMap("response-content-encoding")]
            [Validation(Required=false)]
            public string ResponseContentEncoding { get; set; }
            [NameInMap("Range")]
            [Validation(Required=false)]
            public string Range { get; set; }
            [NameInMap("If-Modified-Since")]
            [Validation(Required=false)]
            public string IfModifiedSince { get; set; }
            [NameInMap("If-Unmodified-Since")]
            [Validation(Required=false)]
            public string IfUnmodifiedSince { get; set; }
            [NameInMap("If-Match")]
            [Validation(Required=false)]
            public string IfMatch { get; set; }
            [NameInMap("If-None-Match")]
            [Validation(Required=false)]
            public string IfNoneMatch { get; set; }
            [NameInMap("Accept-Encoding")]
            [Validation(Required=false)]
            public string AcceptEncoding { get; set; }
        };

    }

}
