// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.OSS.Models
{
    public class GetLiveChannelStatRequest : TeaModel {
        /// <summary>
        /// BucketName
        /// </summary>
        [NameInMap("BucketName")]
        [Validation(Required=true, Pattern="[a-zA-Z0-9-_]+")]
        public string BucketName { get; set; }

        /// <summary>
        /// ChannelName
        /// </summary>
        [NameInMap("ChannelName")]
        [Validation(Required=true)]
        public string ChannelName { get; set; }

        /// <summary>
        /// Filter
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public GetLiveChannelStatRequestFilter Filter { get; set; }
        public class GetLiveChannelStatRequestFilter : TeaModel {
            [NameInMap("comp")]
            [Validation(Required=false)]
            public string Comp { get; set; }
        };

    }

}
