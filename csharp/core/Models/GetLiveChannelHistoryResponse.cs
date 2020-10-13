// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.OSS.Models
{
    public class GetLiveChannelHistoryResponse : TeaModel {
        /// <summary>
        /// x-oss-request-id
        /// </summary>
        [NameInMap("x-oss-request-id")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        /// <summary>
        /// LiveChannelHistory
        /// </summary>
        [NameInMap("LiveChannelHistory")]
        [Validation(Required=true)]
        public GetLiveChannelHistoryResponseLiveChannelHistory LiveChannelHistory { get; set; }
        public class GetLiveChannelHistoryResponseLiveChannelHistory : TeaModel {
            [NameInMap("LiveRecord")]
            [Validation(Required=false)]
            public List<GetLiveChannelHistoryResponseLiveChannelHistoryLiveRecord> LiveRecord { get; set; }
            public class GetLiveChannelHistoryResponseLiveChannelHistoryLiveRecord : TeaModel {
                public string StartTime { get; set; }
                public string EndTime { get; set; }
                public string RemoteAddr { get; set; }
            }
        };

    }

}
