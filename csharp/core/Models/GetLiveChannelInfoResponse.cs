// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.OSS.Models
{
    public class GetLiveChannelInfoResponse : TeaModel {
        /// <summary>
        /// x-oss-request-id
        /// </summary>
        [NameInMap("x-oss-request-id")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        /// <summary>
        /// LiveChannelConfiguration
        /// </summary>
        [NameInMap("LiveChannelConfiguration")]
        [Validation(Required=true)]
        public GetLiveChannelInfoResponseLiveChannelConfiguration LiveChannelConfiguration { get; set; }
        public class GetLiveChannelInfoResponseLiveChannelConfiguration : TeaModel {
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }
            [NameInMap("Target")]
            [Validation(Required=true)]
            public GetLiveChannelInfoResponseLiveChannelConfigurationTarget Target { get; set; }
            public class GetLiveChannelInfoResponseLiveChannelConfigurationTarget : TeaModel {
                /// <summary>
                /// Type
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// FragDuration
                /// </summary>
                [NameInMap("FragDuration")]
                [Validation(Required=false)]
                public string FragDuration { get; set; }

                /// <summary>
                /// FragCount
                /// </summary>
                [NameInMap("FragCount")]
                [Validation(Required=false)]
                public string FragCount { get; set; }

                /// <summary>
                /// PlaylistName
                /// </summary>
                [NameInMap("PlaylistName")]
                [Validation(Required=false)]
                public string PlaylistName { get; set; }

            }
        };

    }

}
