// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.OSS.Models
{
    public class ListLiveChannelResponse : TeaModel {
        [NameInMap("x-oss-request-id")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("ListLiveChannelResult")]
        [Validation(Required=true)]
        public ListLiveChannelResponseListLiveChannelResult ListLiveChannelResult { get; set; }
        public class ListLiveChannelResponseListLiveChannelResult : TeaModel {
            [NameInMap("Prefix")]
            [Validation(Required=true)]
            public string Prefix { get; set; }
            [NameInMap("Marker")]
            [Validation(Required=true)]
            public string Marker { get; set; }
            [NameInMap("MaxKeys")]
            [Validation(Required=true)]
            public string MaxKeys { get; set; }
            [NameInMap("IsTruncated")]
            [Validation(Required=true)]
            public string IsTruncated { get; set; }
            [NameInMap("NextMarker")]
            [Validation(Required=true)]
            public string NextMarker { get; set; }
            [NameInMap("LiveChannel")]
            [Validation(Required=true)]
            public ListLiveChannelResponseLiveChannel LiveChannel { get; set; }
            public class ListLiveChannelResponseLiveChannel : TeaModel {
                [NameInMap("Name")]
                [Validation(Required=true)]
                public string Name { get; set; }

                [NameInMap("Description")]
                [Validation(Required=true)]
                public string Description { get; set; }

                [NameInMap("Status")]
                [Validation(Required=true)]
                public string Status { get; set; }

                [NameInMap("LastModified")]
                [Validation(Required=true)]
                public string LastModified { get; set; }

                [NameInMap("PublishUrls")]
                [Validation(Required=true)]
                public undefinedPublishUrls PublishUrls { get; set; }
                public class undefinedPublishUrls : TeaModel {
                    [NameInMap("Url")]
                    [Validation(Required=true)]
                    public string Url { get; set; }
                };

                [NameInMap("PlayUrls")]
                [Validation(Required=true)]
                public undefinedPlayUrls PlayUrls { get; set; }
                public class undefinedPlayUrls : TeaModel {
                    [NameInMap("Url")]
                    [Validation(Required=true)]
                    public string Url { get; set; }
                };

            }
        };

    }

}
