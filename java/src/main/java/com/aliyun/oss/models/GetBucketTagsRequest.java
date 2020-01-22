// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class GetBucketTagsRequest extends TeaModel {
    @NameInMap("BucketName")
    @Validation(required = true)
    public String bucketName;

    public static GetBucketTagsRequest build(java.util.Map<String, ?> map) throws Exception {
        GetBucketTagsRequest self = new GetBucketTagsRequest();
        return TeaModel.build(map, self);
    }

}
