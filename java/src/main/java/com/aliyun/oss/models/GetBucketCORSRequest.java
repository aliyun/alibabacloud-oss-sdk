// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class GetBucketCORSRequest extends TeaModel {
    @NameInMap("BucketName")
    @Validation(required = true)
    public String bucketName;

    public static GetBucketCORSRequest build(java.util.Map<String, ?> map) throws Exception {
        GetBucketCORSRequest self = new GetBucketCORSRequest();
        return TeaModel.build(map, self);
    }

}
