// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.OSS.Models
{
    public class PutBucketTagsRequest : TeaModel {
        [NameInMap("BucketName")]
        [Validation(Required=true)]
        public string BucketName { get; set; }

        [NameInMap("Body")]
        [Validation(Required=false)]
        public PutBucketTagsRequestBody Body { get; set; }
        public class PutBucketTagsRequestBody : TeaModel {
            [NameInMap("Tagging")]
            [Validation(Required=true)]
            public PutBucketTagsRequestBodyTagging Tagging { get; set; }
            public class PutBucketTagsRequestBodyTagging : TeaModel {
                [NameInMap("TagSet")]
                [Validation(Required=false)]
                public PutBucketTagsRequestBodyTaggingTagSet TagSet { get; set; }
                public class PutBucketTagsRequestBodyTaggingTagSet : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<PutBucketTagsRequestBodyTaggingTagSetTag> Tag { get; set; }
                    public class PutBucketTagsRequestBodyTaggingTagSetTag : TeaModel {
                            public string Key { get; set; }
                            public string Value { get; set; }
                    }
                };

            }
        };

    }

}
