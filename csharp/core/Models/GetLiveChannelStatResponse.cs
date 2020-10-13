// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.OSS.Models
{
    public class GetLiveChannelStatResponse : TeaModel {
        /// <summary>
        /// x-oss-request-id
        /// </summary>
        [NameInMap("x-oss-request-id")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        /// <summary>
        /// LiveChannelStat
        /// </summary>
        [NameInMap("LiveChannelStat")]
        [Validation(Required=true)]
        public GetLiveChannelStatResponseLiveChannelStat LiveChannelStat { get; set; }
        public class GetLiveChannelStatResponseLiveChannelStat : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }
            [NameInMap("ConnectedTime")]
            [Validation(Required=false)]
            public string ConnectedTime { get; set; }
            [NameInMap("RemoteAddr")]
            [Validation(Required=false)]
            public string RemoteAddr { get; set; }
            [NameInMap("Video")]
            [Validation(Required=true)]
            public GetLiveChannelStatResponseLiveChannelStatVideo Video { get; set; }
            public class GetLiveChannelStatResponseLiveChannelStatVideo : TeaModel {
                /// <summary>
                /// Width
                /// </summary>
                [NameInMap("Width")]
                [Validation(Required=false)]
                public string Width { get; set; }

                /// <summary>
                /// Height
                /// </summary>
                [NameInMap("Height")]
                [Validation(Required=false)]
                public string Height { get; set; }

                /// <summary>
                /// FrameRate
                /// </summary>
                [NameInMap("FrameRate")]
                [Validation(Required=false)]
                public string FrameRate { get; set; }

                /// <summary>
                /// Bandwidth
                /// </summary>
                [NameInMap("Bandwidth")]
                [Validation(Required=false)]
                public string Bandwidth { get; set; }

                /// <summary>
                /// Codec
                /// </summary>
                [NameInMap("Codec")]
                [Validation(Required=false)]
                public string Codec { get; set; }

            }
            [NameInMap("Audio")]
            [Validation(Required=true)]
            public GetLiveChannelStatResponseLiveChannelStatAudio Audio { get; set; }
            public class GetLiveChannelStatResponseLiveChannelStatAudio : TeaModel {
                /// <summary>
                /// Bandwidth
                /// </summary>
                [NameInMap("Bandwidth")]
                [Validation(Required=false)]
                public string Bandwidth { get; set; }

                /// <summary>
                /// SampleRate
                /// </summary>
                [NameInMap("SampleRate")]
                [Validation(Required=false)]
                public string SampleRate { get; set; }

                /// <summary>
                /// Codec
                /// </summary>
                [NameInMap("Codec")]
                [Validation(Required=false)]
                public string Codec { get; set; }

            }
        };

    }

}
