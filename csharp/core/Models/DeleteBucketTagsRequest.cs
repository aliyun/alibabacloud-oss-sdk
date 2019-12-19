// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.OSS.Models
{
    public class DeleteBucketTagsRequest : TeaModel {
        [NameInMap("BucketName")]
        [Validation(Required=true)]
        public string BucketName { get; set; }

        [NameInMap("Filter")]
        [Validation(Required=true)]
        public DeleteBucketTagsRequestFilter Filter { get; set; }
        public class DeleteBucketTagsRequestFilter : TeaModel {
            [NameInMap("tagging")]
            [Validation(Required=true)]
            public string Tagging { get; set; }
        };

    }

}
