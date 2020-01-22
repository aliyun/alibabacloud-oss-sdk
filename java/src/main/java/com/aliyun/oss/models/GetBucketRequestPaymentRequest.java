// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class GetBucketRequestPaymentRequest extends TeaModel {
    @NameInMap("BucketName")
    @Validation(required = true)
    public String bucketName;

    public static GetBucketRequestPaymentRequest build(java.util.Map<String, ?> map) throws Exception {
        GetBucketRequestPaymentRequest self = new GetBucketRequestPaymentRequest();
        return TeaModel.build(map, self);
    }

}
