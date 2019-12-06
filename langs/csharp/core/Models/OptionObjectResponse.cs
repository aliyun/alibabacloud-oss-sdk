// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.OSS.Models
{
    public class OptionObjectResponse : TeaModel {
        [NameInMap("x-oss-request-id")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("access-control-allow-origin")]
        [Validation(Required=true)]
        public string AccessControlAllowOrigin { get; set; }

        [NameInMap("access-control-allow-methods")]
        [Validation(Required=true)]
        public string AccessControlAllowMethods { get; set; }

        [NameInMap("access-control-allow-headers")]
        [Validation(Required=true)]
        public string AccessControlAllowHeaders { get; set; }

        [NameInMap("access-control-expose-headers")]
        [Validation(Required=true)]
        public string AccessControlExposeHeaders { get; set; }

        [NameInMap("access-control-max-age")]
        [Validation(Required=true)]
        public string AccessControlMaxAge { get; set; }

    }

}
