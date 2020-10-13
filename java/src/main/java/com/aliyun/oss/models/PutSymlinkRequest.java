// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class PutSymlinkRequest extends TeaModel {
    // BucketName
    @NameInMap("BucketName")
    @Validation(required = true, pattern = "[a-zA-Z0-9\\-\\_]+")
    public String bucketName;

    // ObjectName
    @NameInMap("ObjectName")
    @Validation(required = true)
    public String objectName;

    // Header
    @NameInMap("Header")
    @Validation(required = true)
    public PutSymlinkRequestHeader header;

    public static PutSymlinkRequest build(java.util.Map<String, ?> map) throws Exception {
        PutSymlinkRequest self = new PutSymlinkRequest();
        return TeaModel.build(map, self);
    }

    public PutSymlinkRequest setBucketName(String bucketName) {
        this.bucketName = bucketName;
        return this;
    }
    public String getBucketName() {
        return this.bucketName;
    }

    public PutSymlinkRequest setObjectName(String objectName) {
        this.objectName = objectName;
        return this;
    }
    public String getObjectName() {
        return this.objectName;
    }

    public PutSymlinkRequest setHeader(PutSymlinkRequestHeader header) {
        this.header = header;
        return this;
    }
    public PutSymlinkRequestHeader getHeader() {
        return this.header;
    }

    public static class PutSymlinkRequestHeader extends TeaModel {
        // x-oss-symlink-target
        @NameInMap("x-oss-symlink-target")
        @Validation(required = true)
        public String symlinkTarget;

        // x-oss-storage-class
        @NameInMap("x-oss-storage-class")
        public String storageClass;

        public static PutSymlinkRequestHeader build(java.util.Map<String, ?> map) throws Exception {
            PutSymlinkRequestHeader self = new PutSymlinkRequestHeader();
            return TeaModel.build(map, self);
        }

        public PutSymlinkRequestHeader setSymlinkTarget(String symlinkTarget) {
            this.symlinkTarget = symlinkTarget;
            return this;
        }
        public String getSymlinkTarget() {
            return this.symlinkTarget;
        }

        public PutSymlinkRequestHeader setStorageClass(String storageClass) {
            this.storageClass = storageClass;
            return this;
        }
        public String getStorageClass() {
            return this.storageClass;
        }

    }

}
