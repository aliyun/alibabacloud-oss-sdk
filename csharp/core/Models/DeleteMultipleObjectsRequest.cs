// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.OSS.Models
{
    public class DeleteMultipleObjectsRequest : TeaModel {
        [NameInMap("BucketName")]
        [Validation(Required=true)]
        public string BucketName { get; set; }

        [NameInMap("Body")]
        [Validation(Required=false)]
        public DeleteMultipleObjectsRequestBody Body { get; set; }
        public class DeleteMultipleObjectsRequestBody : TeaModel {
            [NameInMap("Delete")]
            [Validation(Required=true)]
            public DeleteMultipleObjectsRequestDelete Delete { get; set; }
            public class DeleteMultipleObjectsRequestDelete : TeaModel {
                [NameInMap("Object")]
                [Validation(Required=false)]
                public List<DeleteMultipleObjectsRequestObject> Object { get; set; }
                public class DeleteMultipleObjectsRequestObject : TeaModel {
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                }

                [NameInMap("Quiet")]
                [Validation(Required=false)]
                public string Quiet { get; set; }

            }
        };

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
