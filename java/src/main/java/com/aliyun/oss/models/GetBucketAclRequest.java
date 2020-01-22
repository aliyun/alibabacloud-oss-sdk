// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class GetBucketAclRequest extends TeaModel {
    @NameInMap("BucketName")
    @Validation(required = true)
    public String bucketName;

    public static GetBucketAclRequest build(java.util.Map<String, ?> map) throws Exception {
        GetBucketAclRequest self = new GetBucketAclRequest();
        return TeaModel.build(map, self);
    }

}
