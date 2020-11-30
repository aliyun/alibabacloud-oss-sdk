// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.OSS.Models
{
    public class ListLiveChannelRequest : TeaModel {
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
        [Validation(Required=false)]
        public ListLiveChannelRequestFilter Filter { get; set; }
        public class ListLiveChannelRequestFilter : TeaModel {
            [NameInMap("marker")]
            [Validation(Required=false)]
            public string Marker { get; set; }
            [NameInMap("max-keys")]
            [Validation(Required=false)]
            public string MaxKeys { get; set; }
            [NameInMap("prefix")]
            [Validation(Required=false)]
            public string Prefix { get; set; }
        };

    }

}
