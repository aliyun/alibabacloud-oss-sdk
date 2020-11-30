// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class AbortMultipartUploadRequest extends TeaModel {
    // BucketName
    @NameInMap("BucketName")
    @Validation(required = true, pattern = "[a-zA-Z0-9-_]+")
    public String bucketName;

    // ObjectName
    @NameInMap("ObjectName")
    @Validation(required = true)
    public String objectName;

    // Filter
    @NameInMap("Filter")
    @Validation(required = true)
    public AbortMultipartUploadRequestFilter filter;

    public static AbortMultipartUploadRequest build(java.util.Map<String, ?> map) throws Exception {
        AbortMultipartUploadRequest self = new AbortMultipartUploadRequest();
        return TeaModel.build(map, self);
    }

    public AbortMultipartUploadRequest setBucketName(String bucketName) {
        this.bucketName = bucketName;
        return this;
    }
    public String getBucketName() {
        return this.bucketName;
    }

    public AbortMultipartUploadRequest setObjectName(String objectName) {
        this.objectName = objectName;
        return this;
    }
    public String getObjectName() {
        return this.objectName;
    }

    public AbortMultipartUploadRequest setFilter(AbortMultipartUploadRequestFilter filter) {
        this.filter = filter;
        return this;
    }
    public AbortMultipartUploadRequestFilter getFilter() {
        return this.filter;
    }

    public static class AbortMultipartUploadRequestFilter extends TeaModel {
        // uploadId
        @NameInMap("uploadId")
        @Validation(required = true)
        public String uploadId;

        public static AbortMultipartUploadRequestFilter build(java.util.Map<String, ?> map) throws Exception {
            AbortMultipartUploadRequestFilter self = new AbortMultipartUploadRequestFilter();
            return TeaModel.build(map, self);
        }

        public AbortMultipartUploadRequestFilter setUploadId(String uploadId) {
            this.uploadId = uploadId;
            return this;
        }
        public String getUploadId() {
            return this.uploadId;
        }

    }

}
