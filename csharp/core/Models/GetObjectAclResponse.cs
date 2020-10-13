// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.OSS.Models
{
    public class GetObjectAclResponse : TeaModel {
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
        public GetObjectAclResponseAccessControlPolicy AccessControlPolicy { get; set; }
        public class GetObjectAclResponseAccessControlPolicy : TeaModel {
            [NameInMap("Owner")]
            [Validation(Required=true)]
            public GetObjectAclResponseAccessControlPolicyOwner Owner { get; set; }
            public class GetObjectAclResponseAccessControlPolicyOwner : TeaModel {
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
            public GetObjectAclResponseAccessControlPolicyAccessControlList AccessControlList { get; set; }
            public class GetObjectAclResponseAccessControlPolicyAccessControlList : TeaModel {
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
