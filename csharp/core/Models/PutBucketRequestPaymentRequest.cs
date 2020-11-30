// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.OSS.Models
{
    public class PutBucketRequestPaymentRequest : TeaModel {
        /// <summary>
        /// BucketName
        /// </summary>
        [NameInMap("BucketName")]
        [Validation(Required=true, Pattern="[a-zA-Z0-9-_]+")]
        public string BucketName { get; set; }

        /// <summary>
        /// Body
        /// </summary>
        [NameInMap("Body")]
        [Validation(Required=false)]
        public PutBucketRequestPaymentRequestBody Body { get; set; }
        public class PutBucketRequestPaymentRequestBody : TeaModel {
            [NameInMap("RequestPaymentConfiguration")]
            [Validation(Required=true)]
            public PutBucketRequestPaymentRequestBodyRequestPaymentConfiguration RequestPaymentConfiguration { get; set; }
            public class PutBucketRequestPaymentRequestBodyRequestPaymentConfiguration : TeaModel {
                /// <summary>
                /// Payer
                /// </summary>
                [NameInMap("Payer")]
                [Validation(Required=false)]
                public string Payer { get; set; }

            }
        };

    }

}
