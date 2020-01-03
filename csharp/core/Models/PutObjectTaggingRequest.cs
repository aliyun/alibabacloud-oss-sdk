// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.OSS.Models
{
    public class PutObjectTaggingRequest : TeaModel {
        [NameInMap("BucketName")]
        [Validation(Required=true)]
        public string BucketName { get; set; }

        [NameInMap("ObjectName")]
        [Validation(Required=true)]
        public string ObjectName { get; set; }

        [NameInMap("Body")]
        [Validation(Required=false)]
        public PutObjectTaggingRequestBody Body { get; set; }
        public class PutObjectTaggingRequestBody : TeaModel {
            [NameInMap("Tagging")]
            [Validation(Required=true)]
            public PutObjectTaggingRequestBodyTagging Tagging { get; set; }
            public class PutObjectTaggingRequestBodyTagging : TeaModel {
                [NameInMap("TagSet")]
                [Validation(Required=false)]
                public PutObjectTaggingRequestBodyTaggingTagSet TagSet { get; set; }
                public class PutObjectTaggingRequestBodyTaggingTagSet : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<PutObjectTaggingRequestBodyTaggingTagSetKey> Tag { get; set; }
                    public class PutObjectTaggingRequestBodyTaggingTagSetKey : TeaModel {
                            public string Key { get; set; }
                            public string Value { get; set; }
                    }
                };

            }
        };

    }

}
