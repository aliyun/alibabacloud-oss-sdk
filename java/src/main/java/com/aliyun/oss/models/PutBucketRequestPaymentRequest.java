// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class PutBucketRequestPaymentRequest extends TeaModel {
    @NameInMap("BucketName")
    @Validation(required = true)
    public String bucketName;

    @NameInMap("Body")
    public PutBucketRequestPaymentRequestBody body;

    public static PutBucketRequestPaymentRequest build(java.util.Map<String, ?> map) throws Exception {
        PutBucketRequestPaymentRequest self = new PutBucketRequestPaymentRequest();
        return TeaModel.build(map, self);
    }

    public static class PutBucketRequestPaymentRequestBodyRequestPaymentConfiguration extends TeaModel {
        @NameInMap("Payer")
        public String payer;

        public static PutBucketRequestPaymentRequestBodyRequestPaymentConfiguration build(java.util.Map<String, ?> map) throws Exception {
            PutBucketRequestPaymentRequestBodyRequestPaymentConfiguration self = new PutBucketRequestPaymentRequestBodyRequestPaymentConfiguration();
            return TeaModel.build(map, self);
        }

    }

    public static class PutBucketRequestPaymentRequestBody extends TeaModel {
        @NameInMap("RequestPaymentConfiguration")
        @Validation(required = true)
        public PutBucketRequestPaymentRequestBodyRequestPaymentConfiguration requestPaymentConfiguration;

        public static PutBucketRequestPaymentRequestBody build(java.util.Map<String, ?> map) throws Exception {
            PutBucketRequestPaymentRequestBody self = new PutBucketRequestPaymentRequestBody();
            return TeaModel.build(map, self);
        }

    }

}
