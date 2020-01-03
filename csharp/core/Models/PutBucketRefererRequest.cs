// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.OSS.Models
{
    public class PutBucketRefererRequest : TeaModel {
        [NameInMap("BucketName")]
        [Validation(Required=true)]
        public string BucketName { get; set; }

        [NameInMap("Body")]
        [Validation(Required=false)]
        public PutBucketRefererRequestBody Body { get; set; }
        public class PutBucketRefererRequestBody : TeaModel {
            [NameInMap("RefererConfiguration")]
            [Validation(Required=true)]
            public PutBucketRefererRequestBodyRefererConfiguration RefererConfiguration { get; set; }
            public class PutBucketRefererRequestBodyRefererConfiguration : TeaModel {
                [NameInMap("RefererList")]
                [Validation(Required=false)]
                public PutBucketRefererRequestBodyRefererConfigurationRefererList RefererList { get; set; }
                public class PutBucketRefererRequestBodyRefererConfigurationRefererList : TeaModel {
                    [NameInMap("Referer")]
                    [Validation(Required=false)]
                    public List<string> Referer { get; set; }
                };

                [NameInMap("AllowEmptyReferer")]
                [Validation(Required=false)]
                public bool? AllowEmptyReferer { get; set; }

            }
        };

    }

}
