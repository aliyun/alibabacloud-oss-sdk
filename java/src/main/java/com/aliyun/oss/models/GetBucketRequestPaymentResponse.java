// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class GetBucketRequestPaymentResponse extends TeaModel {
    // x-oss-request-id
    @NameInMap("x-oss-request-id")
    @Validation(required = true)
    public String requestId;

    // RequestPaymentConfiguration
    @NameInMap("RequestPaymentConfiguration")
    @Validation(required = true)
    public GetBucketRequestPaymentResponseRequestPaymentConfiguration requestPaymentConfiguration;

    public static GetBucketRequestPaymentResponse build(java.util.Map<String, ?> map) {
        GetBucketRequestPaymentResponse self = new GetBucketRequestPaymentResponse();
        return TeaModel.build(map, self);
    }

    public GetBucketRequestPaymentResponse setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public GetBucketRequestPaymentResponse setRequestPaymentConfiguration(GetBucketRequestPaymentResponseRequestPaymentConfiguration requestPaymentConfiguration) {
        this.requestPaymentConfiguration = requestPaymentConfiguration;
        return this;
    }
    public GetBucketRequestPaymentResponseRequestPaymentConfiguration getRequestPaymentConfiguration() {
        return this.requestPaymentConfiguration;
    }

    public static class GetBucketRequestPaymentResponseRequestPaymentConfiguration extends TeaModel {
        // Payer
        @NameInMap("Payer")
        public String payer;

        public static GetBucketRequestPaymentResponseRequestPaymentConfiguration build(java.util.Map<String, ?> map) {
            GetBucketRequestPaymentResponseRequestPaymentConfiguration self = new GetBucketRequestPaymentResponseRequestPaymentConfiguration();
            return TeaModel.build(map, self);
        }

        public GetBucketRequestPaymentResponseRequestPaymentConfiguration setPayer(String payer) {
            this.payer = payer;
            return this;
        }
        public String getPayer() {
            return this.payer;
        }

    }

}
