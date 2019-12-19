// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.OSS.Models
{
    public class GetBucketTagsResponse : TeaModel {
        [NameInMap("x-oss-request-id")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Tagging")]
        [Validation(Required=true)]
        public GetBucketTagsResponseTagging Tagging { get; set; }
        public class GetBucketTagsResponseTagging : TeaModel {
            [NameInMap("TagSet")]
            [Validation(Required=true)]
            public GetBucketTagsResponseTagSet TagSet { get; set; }
            public class GetBucketTagsResponseTagSet : TeaModel {
                [NameInMap("Tag")]
                [Validation(Required=false)]
                public List<GetBucketTagsResponseTag> Tag { get; set; }
                public class GetBucketTagsResponseTag : TeaModel {
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
