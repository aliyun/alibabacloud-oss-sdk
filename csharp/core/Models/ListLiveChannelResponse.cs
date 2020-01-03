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
            [Validation(Required=false)]
            public string Prefix { get; set; }
            [NameInMap("Marker")]
            [Validation(Required=false)]
            public string Marker { get; set; }
            [NameInMap("MaxKeys")]
            [Validation(Required=false)]
            public string MaxKeys { get; set; }
            [NameInMap("IsTruncated")]
            [Validation(Required=false)]
            public string IsTruncated { get; set; }
            [NameInMap("NextMarker")]
            [Validation(Required=false)]
            public string NextMarker { get; set; }
            [NameInMap("LiveChannel")]
            [Validation(Required=true)]
            public ListLiveChannelResponseListLiveChannelResultLiveChannel LiveChannel { get; set; }
            public class ListLiveChannelResponseListLiveChannelResultLiveChannel : TeaModel {
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("LastModified")]
                [Validation(Required=false)]
                public string LastModified { get; set; }

                [NameInMap("PublishUrls")]
                [Validation(Required=true)]
                public ListLiveChannelResponseListLiveChannelResultLiveChannelPublishUrls PublishUrls { get; set; }
                public class ListLiveChannelResponseListLiveChannelResultLiveChannelPublishUrls : TeaModel {
                    [NameInMap("Url")]
                    [Validation(Required=false)]
                    public string Url { get; set; }
                };

                [NameInMap("PlayUrls")]
                [Validation(Required=true)]
                public ListLiveChannelResponseListLiveChannelResultLiveChannelPlayUrls PlayUrls { get; set; }
                public class ListLiveChannelResponseListLiveChannelResultLiveChannelPlayUrls : TeaModel {
                    [NameInMap("Url")]
                    [Validation(Required=false)]
                    public string Url { get; set; }
                };

            }
        };

    }

}
