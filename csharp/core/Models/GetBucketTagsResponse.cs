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
            public GetBucketTagsResponseTaggingTagSet TagSet { get; set; }
            public class GetBucketTagsResponseTaggingTagSet : TeaModel {
                [NameInMap("Tag")]
                [Validation(Required=false)]
                public List<GetBucketTagsResponseTaggingTagSetTag> Tag { get; set; }
                public class GetBucketTagsResponseTaggingTagSetTag : TeaModel {
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
