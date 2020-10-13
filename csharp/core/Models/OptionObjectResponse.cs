// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.OSS.Models
{
    public class OptionObjectResponse : TeaModel {
        /// <summary>
        /// x-oss-request-id
        /// </summary>
        [NameInMap("x-oss-request-id")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        /// <summary>
        /// Access-Control-Allow-Origin
        /// </summary>
        [NameInMap("access-control-allow-origin")]
        [Validation(Required=true)]
        public string AccessControlAllowOrigin { get; set; }

        /// <summary>
        /// Access-Control-Allow-Methods
        /// </summary>
        [NameInMap("access-control-allow-methods")]
        [Validation(Required=true)]
        public string AccessControlAllowMethods { get; set; }

        /// <summary>
        /// Access-Control-Allow-Headers
        /// </summary>
        [NameInMap("access-control-allow-headers")]
        [Validation(Required=true)]
        public string AccessControlAllowHeaders { get; set; }

        /// <summary>
        /// Access-Control-Expose-Headers
        /// </summary>
        [NameInMap("access-control-expose-headers")]
        [Validation(Required=true)]
        public string AccessControlExposeHeaders { get; set; }

        /// <summary>
        /// Access-Control-Max-Age
        /// </summary>
        [NameInMap("access-control-max-age")]
        [Validation(Required=true)]
        public string AccessControlMaxAge { get; set; }

    }

}
