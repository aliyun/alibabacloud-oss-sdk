// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.OSS.Models
{
    public class GetLiveChannelStatResponse : TeaModel {
        [NameInMap("x-oss-request-id")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

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
                [NameInMap("Width")]
                [Validation(Required=false)]
                public string Width { get; set; }

                [NameInMap("Height")]
                [Validation(Required=false)]
                public string Height { get; set; }

                [NameInMap("FrameRate")]
                [Validation(Required=false)]
                public string FrameRate { get; set; }

                [NameInMap("Bandwidth")]
                [Validation(Required=false)]
                public string Bandwidth { get; set; }

                [NameInMap("Codec")]
                [Validation(Required=false)]
                public string Codec { get; set; }

            }
            [NameInMap("Audio")]
            [Validation(Required=true)]
            public GetLiveChannelStatResponseLiveChannelStatAudio Audio { get; set; }
            public class GetLiveChannelStatResponseLiveChannelStatAudio : TeaModel {
                [NameInMap("Bandwidth")]
                [Validation(Required=false)]
                public string Bandwidth { get; set; }

                [NameInMap("SampleRate")]
                [Validation(Required=false)]
                public string SampleRate { get; set; }

                [NameInMap("Codec")]
                [Validation(Required=false)]
                public string Codec { get; set; }

            }
        };

    }

}
