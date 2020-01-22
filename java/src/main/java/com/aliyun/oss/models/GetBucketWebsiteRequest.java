// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class GetBucketWebsiteRequest extends TeaModel {
    @NameInMap("BucketName")
    @Validation(required = true)
    public String bucketName;

    public static GetBucketWebsiteRequest build(java.util.Map<String, ?> map) throws Exception {
        GetBucketWebsiteRequest self = new GetBucketWebsiteRequest();
        return TeaModel.build(map, self);
    }

}
