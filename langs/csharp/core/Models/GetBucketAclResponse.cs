// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.OSS.Models
{
    public class GetBucketAclResponse : TeaModel {
        [NameInMap("x-oss-request-id")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("AccessControlPolicy")]
        [Validation(Required=true)]
        public GetBucketAclResponseAccessControlPolicy AccessControlPolicy { get; set; }
        public class GetBucketAclResponseAccessControlPolicy : TeaModel {
            [NameInMap("Owner")]
            [Validation(Required=true)]
            public GetBucketAclResponseOwner Owner { get; set; }
            public class GetBucketAclResponseOwner : TeaModel {
                [NameInMap("ID")]
                [Validation(Required=true)]
                public string ID { get; set; }

                [NameInMap("DisplayName")]
                [Validation(Required=true)]
                public string DisplayName { get; set; }

            }
            [NameInMap("AccessControlList")]
            [Validation(Required=true)]
            public GetBucketAclResponseAccessControlList AccessControlList { get; set; }
            public class GetBucketAclResponseAccessControlList : TeaModel {
                [NameInMap("Grant")]
                [Validation(Required=true)]
                public string Grant { get; set; }

            }
        };

    }

}
