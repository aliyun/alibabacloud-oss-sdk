// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.OSS.Models
{
    public class GetLiveChannelStatRequest : TeaModel {
        [NameInMap("BucketName")]
        [Validation(Required=true)]
        public string BucketName { get; set; }

        [NameInMap("ChannelName")]
        [Validation(Required=true)]
        public string ChannelName { get; set; }

        [NameInMap("Filter")]
        [Validation(Required=false)]
        public GetLiveChannelStatRequestFilter Filter { get; set; }
        public class GetLiveChannelStatRequestFilter : TeaModel {
            [NameInMap("comp")]
            [Validation(Required=false)]
            public string Comp { get; set; }
        };

    }

}
