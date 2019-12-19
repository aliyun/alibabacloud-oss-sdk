// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.OSS.Models
{
    public class GetObjectTaggingResponse : TeaModel {
        [NameInMap("x-oss-request-id")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Tagging")]
        [Validation(Required=true)]
        public GetObjectTaggingResponseTagging Tagging { get; set; }
        public class GetObjectTaggingResponseTagging : TeaModel {
            [NameInMap("TagSet")]
            [Validation(Required=true)]
            public GetObjectTaggingResponseTagSet TagSet { get; set; }
            public class GetObjectTaggingResponseTagSet : TeaModel {
                [NameInMap("Tag")]
                [Validation(Required=false)]
                public List<GetObjectTaggingResponseTag> Tag { get; set; }
                public class GetObjectTaggingResponseTag : TeaModel {
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

            }
        };

    }

}
