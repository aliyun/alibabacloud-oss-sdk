// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.OSS.Models
{
    public class PostObjectRequest : TeaModel {
        [NameInMap("BucketName")]
        [Validation(Required=true)]
        public string BucketName { get; set; }

        [NameInMap("header")]
        [Validation(Required=true)]
        public PostObjectRequestHeader Header { get; set; }
        public class PostObjectRequestHeader : TeaModel {
            [NameInMap("OSSAccessKeyId")]
            [Validation(Required=true)]
            public string AccessKeyId { get; set; }
            [NameInMap("policy")]
            [Validation(Required=true)]
            public string Policy { get; set; }
            [NameInMap("Signature")]
            [Validation(Required=true)]
            public string Signature { get; set; }
            [NameInMap("success_action_status")]
            [Validation(Required=false)]
            public string SuccessActionStatus { get; set; }
            [NameInMap("file")]
            [Validation(Required=true)]
            public AlibabaCloud.SDK.TeaFileform.Models.FileField File { get; set; }
            [NameInMap("key")]
            [Validation(Required=true)]
            public string Key { get; set; }
            [NameInMap("UserMeta")]
            [Validation(Required=false)]
            public Dictionary<string, string> UserMeta { get; set; }
        };

    }

}
