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

    public static PutObjectAclRequest build(java.util.Map<String, ?> map) throws Exception {
        PutObjectAclRequest self = new PutObjectAclRequest();
        return TeaModel.build(map, self);
    }

    public static class PutObjectAclRequestHeader extends TeaModel {
        @NameInMap("x-oss-object-acl")
        @Validation(required = true)
        public String objectAcl;

        public static PutObjectAclRequestHeader build(java.util.Map<String, ?> map) throws Exception {
            PutObjectAclRequestHeader self = new PutObjectAclRequestHeader();
            return TeaModel.build(map, self);
        }

    }

}
