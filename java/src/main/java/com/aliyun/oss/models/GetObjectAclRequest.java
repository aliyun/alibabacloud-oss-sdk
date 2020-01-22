// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class GetObjectAclRequest extends TeaModel {
    @NameInMap("BucketName")
    @Validation(required = true)
    public String bucketName;

    @NameInMap("ObjectName")
    @Validation(required = true)
    public String objectName;

    public static GetObjectAclRequest build(java.util.Map<String, ?> map) throws Exception {
        GetObjectAclRequest self = new GetObjectAclRequest();
        return TeaModel.build(map, self);
    }

}
