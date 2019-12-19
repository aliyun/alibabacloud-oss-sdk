// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.OSS.Models
{
    public class GetBucketRequestPaymentResponse : TeaModel {
        [NameInMap("x-oss-request-id")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("RequestPaymentConfiguration")]
        [Validation(Required=true)]
        public GetBucketRequestPaymentResponseRequestPaymentConfiguration RequestPaymentConfiguration { get; set; }
        public class GetBucketRequestPaymentResponseRequestPaymentConfiguration : TeaModel {
            [NameInMap("Payer")]
            [Validation(Required=false)]
            public string Payer { get; set; }
        };

    }

}
