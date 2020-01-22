// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class DeleteBucketWebsiteRequest extends TeaModel {
    @NameInMap("BucketName")
    @Validation(required = true)
    public String bucketName;

    public static DeleteBucketWebsiteRequest build(java.util.Map<String, ?> map) throws Exception {
        DeleteBucketWebsiteRequest self = new DeleteBucketWebsiteRequest();
        return TeaModel.build(map, self);
    }

}
