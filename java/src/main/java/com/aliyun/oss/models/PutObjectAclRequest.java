// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class PutObjectAclRequest extends TeaModel {
    @NameInMap("BucketName")
    @Validation(required = true)
    public String bucketName;

    @NameInMap("ObjectName")
    @Validation(required = true)
    public String objectName;

    @NameInMap("Header")
    @Validation(required = true)
    public PutObjectAclRequestHeader header;

    public static class PutObjectAclRequestHeader extends TeaModel {
        @NameInMap("x-oss-object-acl")
        @Validation(required = true)
        public String objectAcl;

    }

}
