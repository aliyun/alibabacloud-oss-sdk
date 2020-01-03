// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.OSS.Models
{
    public class PutLiveChannelResponse : TeaModel {
        [NameInMap("x-oss-request-id")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("CreateLiveChannelResult")]
        [Validation(Required=true)]
        public PutLiveChannelResponseCreateLiveChannelResult CreateLiveChannelResult { get; set; }
        public class PutLiveChannelResponseCreateLiveChannelResult : TeaModel {
            [NameInMap("PublishUrls")]
            [Validation(Required=true)]
            public PutLiveChannelResponseCreateLiveChannelResultPublishUrls PublishUrls { get; set; }
            public class PutLiveChannelResponseCreateLiveChannelResultPublishUrls : TeaModel {
                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }
            [NameInMap("PlayUrls")]
            [Validation(Required=true)]
            public PutLiveChannelResponseCreateLiveChannelResultPlayUrls PlayUrls { get; set; }
            public class PutLiveChannelResponseCreateLiveChannelResultPlayUrls : TeaModel {
                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }
        };

    }

}
