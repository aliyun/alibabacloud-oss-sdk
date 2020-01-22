// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class DeleteBucketEncryptionRequest extends TeaModel {
    @NameInMap("BucketName")
    @Validation(required = true)
    public String bucketName;

    public static DeleteBucketEncryptionRequest build(java.util.Map<String, ?> map) throws Exception {
        DeleteBucketEncryptionRequest self = new DeleteBucketEncryptionRequest();
        return TeaModel.build(map, self);
    }

}
