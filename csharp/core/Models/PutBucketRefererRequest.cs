// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.OSS.Models
{
    public class PutBucketRefererRequest : TeaModel {
        /// <summary>
        /// BucketName
        /// </summary>
        [NameInMap("BucketName")]
        [Validation(Required=true, Pattern="[a-zA-Z0-9\\-\\_]+")]
        public string BucketName { get; set; }

        /// <summary>
        /// Body
        /// </summary>
        [NameInMap("Body")]
        [Validation(Required=false)]
        public PutBucketRefererRequestBody Body { get; set; }
        public class PutBucketRefererRequestBody : TeaModel {
            [NameInMap("RefererConfiguration")]
            [Validation(Required=true)]
            public PutBucketRefererRequestBodyRefererConfiguration RefererConfiguration { get; set; }
            public class PutBucketRefererRequestBodyRefererConfiguration : TeaModel {
                /// <summary>
                /// RefererList
                /// </summary>
                [NameInMap("RefererList")]
                [Validation(Required=false)]
                public PutBucketRefererRequestBodyRefererConfigurationRefererList RefererList { get; set; }
                public class PutBucketRefererRequestBodyRefererConfigurationRefererList : TeaModel {
                    [NameInMap("Referer")]
                    [Validation(Required=false)]
                    public List<string> Referer { get; set; }
                };

                /// <summary>
                /// AllowEmptyReferer
                /// </summary>
                [NameInMap("AllowEmptyReferer")]
                [Validation(Required=false)]
                public bool? AllowEmptyReferer { get; set; }

            }
        };

    }

}
