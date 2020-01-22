// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.OSS.Models
{
    public class ListPartsResponse : TeaModel {
        [NameInMap("x-oss-request-id")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("ListPartsResult")]
        [Validation(Required=true)]
        public ListPartsResponseListPartsResult ListPartsResult { get; set; }
        public class ListPartsResponseListPartsResult : TeaModel {
            [NameInMap("Bucket")]
            [Validation(Required=false)]
            public string Bucket { get; set; }
            [NameInMap("EncodingType")]
            [Validation(Required=false)]
            public string EncodingType { get; set; }
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }
            [NameInMap("UploadId")]
            [Validation(Required=false)]
            public string UploadId { get; set; }
            [NameInMap("PartNumberMarker")]
            [Validation(Required=false)]
            public string PartNumberMarker { get; set; }
            [NameInMap("NextPartNumberMarker")]
            [Validation(Required=false)]
            public string NextPartNumberMarker { get; set; }
            [NameInMap("MaxParts")]
            [Validation(Required=false)]
            public string MaxParts { get; set; }
            [NameInMap("IsTruncated")]
            [Validation(Required=false)]
            public string IsTruncated { get; set; }
            [NameInMap("Part")]
            [Validation(Required=false)]
            public List<ListPartsResponseListPartsResultPart> Part { get; set; }
            public class ListPartsResponseListPartsResultPart : TeaModel {
                    public string PartNumber { get; set; }
                    public string LastModified { get; set; }
                    public string ETag { get; set; }
                    public string Size { get; set; }
            }
        };

    }

}
