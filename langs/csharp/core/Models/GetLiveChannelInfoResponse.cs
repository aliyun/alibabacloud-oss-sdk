// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.OSS.Models
{
    public class GetLiveChannelInfoResponse : TeaModel {
        [NameInMap("x-oss-request-id")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("LiveChannelConfiguration")]
        [Validation(Required=true)]
        public GetLiveChannelInfoResponseLiveChannelConfiguration LiveChannelConfiguration { get; set; }
        public class GetLiveChannelInfoResponseLiveChannelConfiguration : TeaModel {
            [NameInMap("Description")]
            [Validation(Required=true)]
            public string Description { get; set; }
            [NameInMap("Status")]
            [Validation(Required=true)]
            public string Status { get; set; }
            [NameInMap("Target")]
            [Validation(Required=true)]
            public GetLiveChannelInfoResponseTarget Target { get; set; }
            public class GetLiveChannelInfoResponseTarget : TeaModel {
                [NameInMap("Type")]
                [Validation(Required=true)]
                public string Type { get; set; }

                [NameInMap("FragDuration")]
                [Validation(Required=true)]
                public string FragDuration { get; set; }

                [NameInMap("FragCount")]
                [Validation(Required=true)]
                public string FragCount { get; set; }

                [NameInMap("PlaylistName")]
                [Validation(Required=true)]
                public string PlaylistName { get; set; }

            }
        };

    }

}
