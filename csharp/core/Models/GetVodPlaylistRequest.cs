// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.OSS.Models
{
    public class GetVodPlaylistRequest : TeaModel {
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
        /// Filter
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=true)]
        public GetVodPlaylistRequestFilter Filter { get; set; }
        public class GetVodPlaylistRequestFilter : TeaModel {
            [NameInMap("endTime")]
            [Validation(Required=true)]
            public string EndTime { get; set; }
            [NameInMap("startTime")]
            [Validation(Required=true)]
            public string StartTime { get; set; }
        };

    }

}
