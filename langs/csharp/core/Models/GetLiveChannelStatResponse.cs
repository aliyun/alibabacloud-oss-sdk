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
            [Validation(Required=true)]
            public string Status { get; set; }
            [NameInMap("ConnectedTime")]
            [Validation(Required=true)]
            public string ConnectedTime { get; set; }
            [NameInMap("RemoteAddr")]
            [Validation(Required=true)]
            public string RemoteAddr { get; set; }
            [NameInMap("Video")]
            [Validation(Required=true)]
            public GetLiveChannelStatResponseVideo Video { get; set; }
            public class GetLiveChannelStatResponseVideo : TeaModel {
                [NameInMap("Width")]
                [Validation(Required=true)]
                public string Width { get; set; }

                [NameInMap("Height")]
                [Validation(Required=true)]
                public string Height { get; set; }

                [NameInMap("FrameRate")]
                [Validation(Required=true)]
                public string FrameRate { get; set; }

                [NameInMap("Bandwidth")]
                [Validation(Required=true)]
                public string Bandwidth { get; set; }

                [NameInMap("Codec")]
                [Validation(Required=true)]
                public string Codec { get; set; }

            }
            [NameInMap("Audio")]
            [Validation(Required=true)]
            public GetLiveChannelStatResponseAudio Audio { get; set; }
            public class GetLiveChannelStatResponseAudio : TeaModel {
                [NameInMap("Bandwidth")]
                [Validation(Required=true)]
                public string Bandwidth { get; set; }

                [NameInMap("SampleRate")]
                [Validation(Required=true)]
                public string SampleRate { get; set; }

                [NameInMap("Codec")]
                [Validation(Required=true)]
                public string Codec { get; set; }

            }
        };

    }

}
