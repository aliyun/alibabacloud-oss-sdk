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
            public PutObjectTaggingRequestTagging Tagging { get; set; }
            public class PutObjectTaggingRequestTagging : TeaModel {
                [NameInMap("TagSet")]
                [Validation(Required=false)]
                public PutObjectTaggingRequestTagSet TagSet { get; set; }
                public class PutObjectTaggingRequestTagSet : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<PutObjectTaggingRequestKey> Tag { get; set; }
                    public class PutObjectTaggingRequestKey : TeaModel {
                            public string Key { get; set; }
                            public string Value { get; set; }
                    }
                };

            }
        };

    }

}
