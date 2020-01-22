// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class CallbackRequest extends TeaModel {
    @NameInMap("BucketName")
    @Validation(required = true)
    public String bucketName;

    public static CallbackRequest build(java.util.Map<String, ?> map) throws Exception {
        CallbackRequest self = new CallbackRequest();
        return TeaModel.build(map, self);
    }

}
