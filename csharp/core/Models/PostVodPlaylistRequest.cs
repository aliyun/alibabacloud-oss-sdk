// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.OSS.Models
{
    public class PostVodPlaylistRequest : TeaModel {
        [NameInMap("BucketName")]
        [Validation(Required=true)]
        public string BucketName { get; set; }

        [NameInMap("ChannelName")]
        [Validation(Required=true)]
        public string ChannelName { get; set; }

        [NameInMap("PlaylistName")]
        [Validation(Required=true)]
        public string PlaylistName { get; set; }

        [NameInMap("Filter")]
        [Validation(Required=true)]
        public PostVodPlaylistRequestFilter Filter { get; set; }
        public class PostVodPlaylistRequestFilter : TeaModel {
            [NameInMap("endTime")]
            [Validation(Required=true)]
            public string EndTime { get; set; }
            [NameInMap("startTime")]
            [Validation(Required=true)]
            public string StartTime { get; set; }
        };

    }

}
