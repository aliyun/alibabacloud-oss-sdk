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
            public GetBucketAclResponseAccessControlPolicyOwner Owner { get; set; }
            public class GetBucketAclResponseAccessControlPolicyOwner : TeaModel {
                [NameInMap("ID")]
                [Validation(Required=false)]
                public string ID { get; set; }

                [NameInMap("DisplayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

            }
            [NameInMap("AccessControlList")]
            [Validation(Required=true)]
            public GetBucketAclResponseAccessControlPolicyAccessControlList AccessControlList { get; set; }
            public class GetBucketAclResponseAccessControlPolicyAccessControlList : TeaModel {
                [NameInMap("Grant")]
                [Validation(Required=false)]
                public string Grant { get; set; }

            }
        };

    }

}
