// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.OSS.Models
{
    public class DeleteMultipleObjectsResponse : TeaModel {
        /// <summary>
        /// x-oss-request-id
        /// </summary>
        [NameInMap("x-oss-request-id")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        /// <summary>
        /// DeleteResult
        /// </summary>
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
            public List<DeleteMultipleObjectsResponseDeleteResultDeleted> Deleted { get; set; }
            public class DeleteMultipleObjectsResponseDeleteResultDeleted : TeaModel {
                public string Key { get; set; }
            }
        };

    }

}
