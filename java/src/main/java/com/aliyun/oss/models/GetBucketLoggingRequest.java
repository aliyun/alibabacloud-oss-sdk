// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class GetBucketLoggingRequest extends TeaModel {
    @NameInMap("BucketName")
    @Validation(required = true)
    public String bucketName;

    public static GetBucketLoggingRequest build(java.util.Map<String, ?> map) throws Exception {
        GetBucketLoggingRequest self = new GetBucketLoggingRequest();
        return TeaModel.build(map, self);
    }

}
