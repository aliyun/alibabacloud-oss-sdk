// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.OSS.Models
{
    public class PutLiveChannelRequest : TeaModel {
        /// <summary>
        /// BucketName
        /// </summary>
        [NameInMap("BucketName")]
        [Validation(Required=true, Pattern="[a-zA-Z0-9-_]+")]
        public string BucketName { get; set; }

        /// <summary>
        /// ChannelName
        /// </summary>
        [NameInMap("ChannelName")]
        [Validation(Required=true)]
        public string ChannelName { get; set; }

        /// <summary>
        /// Body
        /// </summary>
        [NameInMap("Body")]
        [Validation(Required=false)]
        public PutLiveChannelRequestBody Body { get; set; }
        public class PutLiveChannelRequestBody : TeaModel {
            [NameInMap("LiveChannelConfiguration")]
            [Validation(Required=true)]
            public PutLiveChannelRequestBodyLiveChannelConfiguration LiveChannelConfiguration { get; set; }
            public class PutLiveChannelRequestBodyLiveChannelConfiguration : TeaModel {
                /// <summary>
                /// Target
                /// </summary>
                [NameInMap("Target")]
                [Validation(Required=false)]
                public PutLiveChannelRequestBodyLiveChannelConfigurationTarget Target { get; set; }
                public class PutLiveChannelRequestBodyLiveChannelConfigurationTarget : TeaModel {
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }
                    [NameInMap("FragDuration")]
                    [Validation(Required=false)]
                    public string FragDuration { get; set; }
                    [NameInMap("FragCount")]
                    [Validation(Required=false)]
                    public string FragCount { get; set; }
                    [NameInMap("PlaylistName")]
                    [Validation(Required=false)]
                    public string PlaylistName { get; set; }
                };

                /// <summary>
                /// Snapshot
                /// </summary>
                [NameInMap("Snapshot")]
                [Validation(Required=false)]
                public PutLiveChannelRequestBodyLiveChannelConfigurationSnapshot Snapshot { get; set; }
                public class PutLiveChannelRequestBodyLiveChannelConfigurationSnapshot : TeaModel {
                    [NameInMap("RoleName")]
                    [Validation(Required=false)]
                    public string RoleName { get; set; }
                    [NameInMap("DestBucket")]
                    [Validation(Required=false)]
                    public string DestBucket { get; set; }
                    [NameInMap("NotifyTopic")]
                    [Validation(Required=false)]
                    public string NotifyTopic { get; set; }
                    [NameInMap("Interval")]
                    [Validation(Required=false)]
                    public string Interval { get; set; }
                };

                /// <summary>
                /// Description
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// Status
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }
        };

    }

}
