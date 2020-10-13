// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.OSS.Models
{
    public class GetServiceRequest : TeaModel {
        /// <summary>
        /// Filter
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public GetServiceRequestFilter Filter { get; set; }
        public class GetServiceRequestFilter : TeaModel {
            [NameInMap("prefix")]
            [Validation(Required=false)]
            public string Prefix { get; set; }
            [NameInMap("marker")]
            [Validation(Required=false)]
            public string Marker { get; set; }
            [NameInMap("max-keys")]
            [Validation(Required=false)]
            public string MaxKeys { get; set; }
        };

    }

}
