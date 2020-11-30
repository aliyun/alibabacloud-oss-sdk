// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.OSS.Models
{
    public class PutBucketTagsRequest : TeaModel {
        /// <summary>
        /// BucketName
        /// </summary>
        [NameInMap("BucketName")]
        [Validation(Required=true, Pattern="[a-zA-Z0-9-_]+")]
        public string BucketName { get; set; }

        /// <summary>
        /// Body
        /// </summary>
        [NameInMap("Body")]
        [Validation(Required=false)]
        public PutBucketTagsRequestBody Body { get; set; }
        public class PutBucketTagsRequestBody : TeaModel {
            [NameInMap("Tagging")]
            [Validation(Required=true)]
            public PutBucketTagsRequestBodyTagging Tagging { get; set; }
            public class PutBucketTagsRequestBodyTagging : TeaModel {
                /// <summary>
                /// TagSet
                /// </summary>
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
