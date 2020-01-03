// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.OSS.Models
{
    public class PutBucketRequestPaymentRequest : TeaModel {
        [NameInMap("BucketName")]
        [Validation(Required=true)]
        public string BucketName { get; set; }

        [NameInMap("Body")]
        [Validation(Required=false)]
        public PutBucketRequestPaymentRequestBody Body { get; set; }
        public class PutBucketRequestPaymentRequestBody : TeaModel {
            [NameInMap("RequestPaymentConfiguration")]
            [Validation(Required=true)]
            public PutBucketRequestPaymentRequestBodyRequestPaymentConfiguration RequestPaymentConfiguration { get; set; }
            public class PutBucketRequestPaymentRequestBodyRequestPaymentConfiguration : TeaModel {
                [NameInMap("Payer")]
                [Validation(Required=false)]
                public string Payer { get; set; }

            }
        };

    }

}
