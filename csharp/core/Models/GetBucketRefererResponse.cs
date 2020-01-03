// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.OSS.Models
{
    public class GetBucketRefererResponse : TeaModel {
        [NameInMap("x-oss-request-id")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("RefererConfiguration")]
        [Validation(Required=true)]
        public GetBucketRefererResponseRefererConfiguration RefererConfiguration { get; set; }
        public class GetBucketRefererResponseRefererConfiguration : TeaModel {
            [NameInMap("AllowEmptyReferer")]
            [Validation(Required=false)]
            public bool? AllowEmptyReferer { get; set; }
            [NameInMap("RefererList")]
            [Validation(Required=true)]
            public GetBucketRefererResponseRefererConfigurationRefererList RefererList { get; set; }
            public class GetBucketRefererResponseRefererConfigurationRefererList : TeaModel {
                [NameInMap("Referer")]
                [Validation(Required=false)]
                public List<string> Referer { get; set; }

            }
        };

    }

}
