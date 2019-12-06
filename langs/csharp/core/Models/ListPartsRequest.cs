// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.OSS.Models
{
    public class ListPartsRequest : TeaModel {
        [NameInMap("BucketName")]
        [Validation(Required=true)]
        public string BucketName { get; set; }

        [NameInMap("ObjectName")]
        [Validation(Required=true)]
        public string ObjectName { get; set; }

        [NameInMap("Filter")]
        [Validation(Required=true)]
        public ListPartsRequestFilter Filter { get; set; }
        public class ListPartsRequestFilter : TeaModel {
            [NameInMap("uploadId")]
            [Validation(Required=true)]
            public string UploadId { get; set; }
            [NameInMap("max-parts")]
            [Validation(Required=false)]
            public int? MaxParts { get; set; }
            [NameInMap("part-number-marker")]
            [Validation(Required=false)]
            public int? PartNumberMarker { get; set; }
            [NameInMap("Encoding-type")]
            [Validation(Required=false)]
            public string EncodingType { get; set; }
        };

    }

}
