// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class PutBucketRequestPaymentRequest extends TeaModel {
    @NameInMap("BucketName")
    @Validation(required = true)
    public String bucketName;

    @NameInMap("Body")
    public PutBucketRequestPaymentRequestBody body;

    public static class PutBucketRequestPaymentRequestBodyRequestPaymentConfiguration extends TeaModel {
        @NameInMap("Payer")
        public String payer;

    }

    public static class PutBucketRequestPaymentRequestBody extends TeaModel {
        @NameInMap("RequestPaymentConfiguration")
        @Validation(required = true)
        public PutBucketRequestPaymentRequestBodyRequestPaymentConfiguration requestPaymentConfiguration;

    }

}
