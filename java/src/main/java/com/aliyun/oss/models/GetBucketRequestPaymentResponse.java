// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class GetBucketRequestPaymentResponse extends TeaModel {
    @NameInMap("x-oss-request-id")
    @Validation(required = true)
    public String requestId;

    @NameInMap("RequestPaymentConfiguration")
    @Validation(required = true)
    public GetBucketRequestPaymentResponseRequestPaymentConfiguration requestPaymentConfiguration;

    public static GetBucketRequestPaymentResponse build(java.util.Map<String, ?> map) throws Exception {
        GetBucketRequestPaymentResponse self = new GetBucketRequestPaymentResponse();
        return TeaModel.build(map, self);
    }

    public static class GetBucketRequestPaymentResponseRequestPaymentConfiguration extends TeaModel {
        @NameInMap("Payer")
        public String payer;

        public static GetBucketRequestPaymentResponseRequestPaymentConfiguration build(java.util.Map<String, ?> map) throws Exception {
            GetBucketRequestPaymentResponseRequestPaymentConfiguration self = new GetBucketRequestPaymentResponseRequestPaymentConfiguration();
            return TeaModel.build(map, self);
        }

    }

}
