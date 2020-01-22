// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class GetBucketInfoRequest extends TeaModel {
    @NameInMap("BucketName")
    @Validation(required = true)
    public String bucketName;

    public static GetBucketInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        GetBucketInfoRequest self = new GetBucketInfoRequest();
        return TeaModel.build(map, self);
    }

}
