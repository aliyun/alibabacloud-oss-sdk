// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.OSS.Models
{
    public class GetBucketAclResponse : TeaModel {
        /// <summary>
        /// x-oss-request-id
        /// </summary>
        [NameInMap("x-oss-request-id")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        /// <summary>
        /// AccessControlPolicy
        /// </summary>
        [NameInMap("AccessControlPolicy")]
        [Validation(Required=true)]
        public GetBucketAclResponseAccessControlPolicy AccessControlPolicy { get; set; }
        public class GetBucketAclResponseAccessControlPolicy : TeaModel {
            [NameInMap("Owner")]
            [Validation(Required=true)]
            public GetBucketAclResponseAccessControlPolicyOwner Owner { get; set; }
            public class GetBucketAclResponseAccessControlPolicyOwner : TeaModel {
                /// <summary>
                /// ID
                /// </summary>
                [NameInMap("ID")]
                [Validation(Required=false)]
                public string ID { get; set; }

                /// <summary>
                /// DisplayName
                /// </summary>
                [NameInMap("DisplayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

            }
            [NameInMap("AccessControlList")]
            [Validation(Required=true)]
            public GetBucketAclResponseAccessControlPolicyAccessControlList AccessControlList { get; set; }
            public class GetBucketAclResponseAccessControlPolicyAccessControlList : TeaModel {
                /// <summary>
                /// Grant
                /// </summary>
                [NameInMap("Grant")]
                [Validation(Required=false)]
                public string Grant { get; set; }

            }
        };

    }

}
