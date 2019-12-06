// This file is auto-generated, don't edit it. Thanks.
package com.oss.models;

import com.aliyun.tea.*;

public class PutSymlinkRequest extends TeaModel {
    @NameInMap("BucketName")
    @Validation(required = true)
    public String bucketName;

    @NameInMap("ObjectName")
    @Validation(required = true)
    public String objectName;

    @NameInMap("Header")
    @Validation(required = true)
    public PutSymlinkRequestHeader header;

    public static class PutSymlinkRequestHeader extends TeaModel {
        @NameInMap("x-oss-symlink-target")
        @Validation(required = true)
        public String symlinkTarget;

        @NameInMap("x-oss-storage-class")
        public String storageClass;

    }

}
