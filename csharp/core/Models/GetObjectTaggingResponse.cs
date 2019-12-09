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
                [Validation(Required=true)]
                public List<undefinedTag> Tag { get; set; }
                public class undefinedTag : TeaModel {
                    [NameInMap("Key")]
                    [Validation(Required=true)]
                    public string Key { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=true)]
                    public string Value { get; set; }

                }

            }
        };

    }

}
