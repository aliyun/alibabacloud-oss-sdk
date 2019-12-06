// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.OSS.Models
{
    public class PutLiveChannelStatusRequest : TeaModel {
        [NameInMap("BucketName")]
        [Validation(Required=true)]
        public string BucketName { get; set; }

        [NameInMap("ChannelName")]
        [Validation(Required=true)]
        public string ChannelName { get; set; }

        [NameInMap("Filter")]
        [Validation(Required=true)]
        public PutLiveChannelStatusRequestFilter Filter { get; set; }
        public class PutLiveChannelStatusRequestFilter : TeaModel {
            [NameInMap("status")]
            [Validation(Required=true)]
            public string Status { get; set; }
        };

    }

}
