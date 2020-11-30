// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.OSS.Models
{
    public class PutObjectTaggingRequest : TeaModel {
        /// <summary>
        /// BucketName
        /// </summary>
        [NameInMap("BucketName")]
        [Validation(Required=true, Pattern="[a-zA-Z0-9-_]+")]
        public string BucketName { get; set; }

        /// <summary>
        /// ObjectName
        /// </summary>
        [NameInMap("ObjectName")]
        [Validation(Required=true)]
        public string ObjectName { get; set; }

        /// <summary>
        /// Body
        /// </summary>
        [NameInMap("Body")]
        [Validation(Required=false)]
        public PutObjectTaggingRequestBody Body { get; set; }
        public class PutObjectTaggingRequestBody : TeaModel {
            [NameInMap("Tagging")]
            [Validation(Required=true)]
            public PutObjectTaggingRequestBodyTagging Tagging { get; set; }
            public class PutObjectTaggingRequestBodyTagging : TeaModel {
                /// <summary>
                /// TagSet
                /// </summary>
                [NameInMap("TagSet")]
                [Validation(Required=false)]
                public PutObjectTaggingRequestBodyTaggingTagSet TagSet { get; set; }
                public class PutObjectTaggingRequestBodyTaggingTagSet : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<PutObjectTaggingRequestBodyTaggingTagSetTag> Tag { get; set; }
                    public class PutObjectTaggingRequestBodyTaggingTagSetTag : TeaModel {
                        public string Key { get; set; }
                        public string Value { get; set; }
                    }
                };

            }
        };

    }

}
