// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class DeleteBucketLoggingRequest extends TeaModel {
    @NameInMap("BucketName")
    @Validation(required = true)
    public String bucketName;

    public static DeleteBucketLoggingRequest build(java.util.Map<String, ?> map) throws Exception {
        DeleteBucketLoggingRequest self = new DeleteBucketLoggingRequest();
        return TeaModel.build(map, self);
    }

}
