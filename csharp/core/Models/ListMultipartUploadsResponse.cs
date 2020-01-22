// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.OSS.Models
{
    public class ListMultipartUploadsResponse : TeaModel {
        [NameInMap("x-oss-request-id")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("ListMultipartUploadsResult")]
        [Validation(Required=true)]
        public ListMultipartUploadsResponseListMultipartUploadsResult ListMultipartUploadsResult { get; set; }
        public class ListMultipartUploadsResponseListMultipartUploadsResult : TeaModel {
            [NameInMap("Bucket")]
            [Validation(Required=false)]
            public string Bucket { get; set; }
            [NameInMap("EncodingType")]
            [Validation(Required=false)]
            public string EncodingType { get; set; }
            [NameInMap("KeyMarker")]
            [Validation(Required=false)]
            public string KeyMarker { get; set; }
            [NameInMap("UploadIdMarker")]
            [Validation(Required=false)]
            public string UploadIdMarker { get; set; }
            [NameInMap("NextKeyMarker")]
            [Validation(Required=false)]
            public string NextKeyMarker { get; set; }
            [NameInMap("NextUploadIdMarker")]
            [Validation(Required=false)]
            public string NextUploadIdMarker { get; set; }
            [NameInMap("Delimiter")]
            [Validation(Required=false)]
            public string Delimiter { get; set; }
            [NameInMap("MaxUploads")]
            [Validation(Required=false)]
            public string MaxUploads { get; set; }
            [NameInMap("IsTruncated")]
            [Validation(Required=false)]
            public string IsTruncated { get; set; }
            [NameInMap("Upload")]
            [Validation(Required=false)]
            public List<ListMultipartUploadsResponseListMultipartUploadsResultUpload> Upload { get; set; }
            public class ListMultipartUploadsResponseListMultipartUploadsResultUpload : TeaModel {
                    public string Key { get; set; }
                    public string UploadId { get; set; }
                    public string Initiated { get; set; }
            }
        };

    }

}
