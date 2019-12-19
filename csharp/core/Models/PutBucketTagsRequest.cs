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
            public PutBucketTagsRequestTagging Tagging { get; set; }
            public class PutBucketTagsRequestTagging : TeaModel {
                [NameInMap("TagSet")]
                [Validation(Required=false)]
                public PutBucketTagsRequestTagSet TagSet { get; set; }
                public class PutBucketTagsRequestTagSet : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<PutBucketTagsRequestKey> Tag { get; set; }
                    public class PutBucketTagsRequestKey : TeaModel {
                            public string Key { get; set; }
                            public string Value { get; set; }
                    }
                };

            }
        };

    }

}
