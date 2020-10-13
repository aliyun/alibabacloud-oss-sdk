// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.OSS.Models
{
    public class DeleteMultipleObjectsRequest : TeaModel {
        /// <summary>
        /// BucketName
        /// </summary>
        [NameInMap("BucketName")]
        [Validation(Required=true, Pattern="[a-zA-Z0-9\\-\\_]+")]
        public string BucketName { get; set; }

        /// <summary>
        /// Body
        /// </summary>
        [NameInMap("Body")]
        [Validation(Required=false)]
        public DeleteMultipleObjectsRequestBody Body { get; set; }
        public class DeleteMultipleObjectsRequestBody : TeaModel {
            [NameInMap("Delete")]
            [Validation(Required=true)]
            public DeleteMultipleObjectsRequestBodyDelete Delete { get; set; }
            public class DeleteMultipleObjectsRequestBodyDelete : TeaModel {
                /// <summary>
                /// Object
                /// </summary>
                [NameInMap("Object")]
                [Validation(Required=false)]
                public List<DeleteMultipleObjectsRequestBodyDeleteObject> Object { get; set; }
                public class DeleteMultipleObjectsRequestBodyDeleteObject : TeaModel {
                    /// <summary>
                    /// Key
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                }

                /// <summary>
                /// Quiet
                /// </summary>
                [NameInMap("Quiet")]
                [Validation(Required=false)]
                public string Quiet { get; set; }

            }
        };

        /// <summary>
        /// Header
        /// </summary>
        [NameInMap("Header")]
        [Validation(Required=true)]
        public DeleteMultipleObjectsRequestHeader Header { get; set; }
        public class DeleteMultipleObjectsRequestHeader : TeaModel {
            [NameInMap("Encoding-type")]
            [Validation(Required=false)]
            public string EncodingType { get; set; }
            [NameInMap("Content-Length")]
            [Validation(Required=true)]
            public string ContentLength { get; set; }
            [NameInMap("Content-MD5")]
            [Validation(Required=true)]
            public string ContentMD5 { get; set; }
        };

    }

}
