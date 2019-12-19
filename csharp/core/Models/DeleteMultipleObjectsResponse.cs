// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.OSS.Models
{
    public class DeleteMultipleObjectsResponse : TeaModel {
        [NameInMap("x-oss-request-id")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("DeleteResult")]
        [Validation(Required=true)]
        public DeleteMultipleObjectsResponseDeleteResult DeleteResult { get; set; }
        public class DeleteMultipleObjectsResponseDeleteResult : TeaModel {
            [NameInMap("Quiet")]
            [Validation(Required=false)]
            public string Quiet { get; set; }
            [NameInMap("EncodingType")]
            [Validation(Required=false)]
            public string EncodingType { get; set; }
            [NameInMap("Deleted")]
            [Validation(Required=false)]
            public List<DeleteMultipleObjectsResponseKey> Deleted { get; set; }
            public class DeleteMultipleObjectsResponseKey : TeaModel {
                    public string Key { get; set; }
            }
        };

    }

}
