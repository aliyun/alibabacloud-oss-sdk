// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.OSS.Models
{
    public class OptionObjectRequest : TeaModel {
        /// <summary>
        /// BucketName
        /// </summary>
        [NameInMap("BucketName")]
        [Validation(Required=true, Pattern="[a-zA-Z0-9-_]+")]
        public string BucketName { get; set; }

        /// <summary>
        /// ObjectName
        /// </summary>
        [NameInMap("ObjectName")]
        [Validation(Required=true)]
        public string ObjectName { get; set; }

        /// <summary>
        /// Header
        /// </summary>
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
