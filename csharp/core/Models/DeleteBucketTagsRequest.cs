// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.OSS.Models
{
    public class DeleteBucketTagsRequest : TeaModel {
        /// <summary>
        /// BucketName
        /// </summary>
        [NameInMap("BucketName")]
        [Validation(Required=true, Pattern="[a-zA-Z0-9-_]+")]
        public string BucketName { get; set; }

        /// <summary>
        /// Filter
        /// </summary>
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
