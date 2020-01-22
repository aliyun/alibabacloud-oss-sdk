// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

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

    public static PutSymlinkRequest build(java.util.Map<String, ?> map) throws Exception {
        PutSymlinkRequest self = new PutSymlinkRequest();
        return TeaModel.build(map, self);
    }

    public static class PutSymlinkRequestHeader extends TeaModel {
        @NameInMap("x-oss-symlink-target")
        @Validation(required = true)
        public String symlinkTarget;

        @NameInMap("x-oss-storage-class")
        public String storageClass;

        public static PutSymlinkRequestHeader build(java.util.Map<String, ?> map) throws Exception {
            PutSymlinkRequestHeader self = new PutSymlinkRequestHeader();
            return TeaModel.build(map, self);
        }

    }

}
