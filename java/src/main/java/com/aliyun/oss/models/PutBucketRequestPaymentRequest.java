// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class PutBucketRequestPaymentRequest extends TeaModel {
    // BucketName
    @NameInMap("BucketName")
    @Validation(required = true, pattern = "[a-zA-Z0-9-_]+")
    public String bucketName;

    // Body
    @NameInMap("Body")
    public PutBucketRequestPaymentRequestBody body;

    public static PutBucketRequestPaymentRequest build(java.util.Map<String, ?> map) throws Exception {
        PutBucketRequestPaymentRequest self = new PutBucketRequestPaymentRequest();
        return TeaModel.build(map, self);
    }

    public PutBucketRequestPaymentRequest setBucketName(String bucketName) {
        this.bucketName = bucketName;
        return this;
    }
    public String getBucketName() {
        return this.bucketName;
    }

    public PutBucketRequestPaymentRequest setBody(PutBucketRequestPaymentRequestBody body) {
        this.body = body;
        return this;
    }
    public PutBucketRequestPaymentRequestBody getBody() {
        return this.body;
    }

    public static class PutBucketRequestPaymentRequestBodyRequestPaymentConfiguration extends TeaModel {
        // Payer
        @NameInMap("Payer")
        public String payer;

        public static PutBucketRequestPaymentRequestBodyRequestPaymentConfiguration build(java.util.Map<String, ?> map) throws Exception {
            PutBucketRequestPaymentRequestBodyRequestPaymentConfiguration self = new PutBucketRequestPaymentRequestBodyRequestPaymentConfiguration();
            return TeaModel.build(map, self);
        }

        public PutBucketRequestPaymentRequestBodyRequestPaymentConfiguration setPayer(String payer) {
            this.payer = payer;
            return this;
        }
        public String getPayer() {
            return this.payer;
        }

    }

    public static class PutBucketRequestPaymentRequestBody extends TeaModel {
        // RequestPaymentConfiguration
        @NameInMap("RequestPaymentConfiguration")
        @Validation(required = true)
        public PutBucketRequestPaymentRequestBodyRequestPaymentConfiguration requestPaymentConfiguration;

        public static PutBucketRequestPaymentRequestBody build(java.util.Map<String, ?> map) throws Exception {
            PutBucketRequestPaymentRequestBody self = new PutBucketRequestPaymentRequestBody();
            return TeaModel.build(map, self);
        }

        public PutBucketRequestPaymentRequestBody setRequestPaymentConfiguration(PutBucketRequestPaymentRequestBodyRequestPaymentConfiguration requestPaymentConfiguration) {
            this.requestPaymentConfiguration = requestPaymentConfiguration;
            return this;
        }
        public PutBucketRequestPaymentRequestBodyRequestPaymentConfiguration getRequestPaymentConfiguration() {
            return this.requestPaymentConfiguration;
        }

    }

}
