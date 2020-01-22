// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class PutBucketAclRequest extends TeaModel {
    @NameInMap("BucketName")
    @Validation(required = true)
    public String bucketName;

    @NameInMap("Header")
    @Validation(required = true)
    public PutBucketAclRequestHeader header;

    public static PutBucketAclRequest build(java.util.Map<String, ?> map) throws Exception {
        PutBucketAclRequest self = new PutBucketAclRequest();
        return TeaModel.build(map, self);
    }

    public static class PutBucketAclRequestHeader extends TeaModel {
        @NameInMap("x-oss-acl")
        @Validation(required = true)
        public String acl;

        public static PutBucketAclRequestHeader build(java.util.Map<String, ?> map) throws Exception {
            PutBucketAclRequestHeader self = new PutBucketAclRequestHeader();
            return TeaModel.build(map, self);
        }

    }

}
