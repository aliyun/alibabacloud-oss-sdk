// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class PutBucketEncryptionResponse extends TeaModel {
    @NameInMap("x-oss-request-id")
    @Validation(required = true)
    public String requestId;

    public static PutBucketEncryptionResponse build(java.util.Map<String, ?> map) throws Exception {
        PutBucketEncryptionResponse self = new PutBucketEncryptionResponse();
        return TeaModel.build(map, self);
    }

}
