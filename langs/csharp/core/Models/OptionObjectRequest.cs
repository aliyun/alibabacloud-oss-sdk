// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.OSS.Models
{
    public class OptionObjectRequest : TeaModel {
        [NameInMap("BucketName")]
        [Validation(Required=true)]
        public string BucketName { get; set; }

        [NameInMap("ObjectName")]
        [Validation(Required=true)]
        public string ObjectName { get; set; }

        [NameInMap("Header")]
        [Validation(Required=true)]
        public OptionObjectRequestHeader Header { get; set; }
        public class OptionObjectRequestHeader : TeaModel {
            [NameInMap("Origin")]
            [Validation(Required=true)]
            public string Origin { get; set; }
            [NameInMap("Access-Control-Request-Method")]
            [Validation(Required=true)]
            public string AccessControlRequestMethod { get; set; }
            [NameInMap("Access-Control-Request-Headers")]
            [Validation(Required=true)]
            public string AccessControlRequestHeaders { get; set; }
        };

    }

}
