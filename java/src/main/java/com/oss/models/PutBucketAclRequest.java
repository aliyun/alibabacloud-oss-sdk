// This file is auto-generated, don't edit it. Thanks.
package com.oss.models;

import com.aliyun.tea.*;

public class PutBucketAclRequest extends TeaModel {
    @NameInMap("BucketName")
    @Validation(required = true)
    public String bucketName;

    @NameInMap("Header")
    @Validation(required = true)
    public PutBucketAclRequestHeader header;

    public static class PutBucketAclRequestHeader extends TeaModel {
        @NameInMap("x-oss-acl")
        @Validation(required = true)
        public String acl;

    }

}
