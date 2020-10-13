// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class UploadPartRequest extends TeaModel {
    // BucketName
    @NameInMap("BucketName")
    @Validation(required = true, pattern = "[a-zA-Z0-9\\-\\_]+")
    public String bucketName;

    // ObjectName
    @NameInMap("ObjectName")
    @Validation(required = true)
    public String objectName;

    // body
    @NameInMap("body")
    public java.io.InputStream body;

    // Filter
    @NameInMap("Filter")
    @Validation(required = true)
    public UploadPartRequestFilter filter;

    public static UploadPartRequest build(java.util.Map<String, ?> map) throws Exception {
        UploadPartRequest self = new UploadPartRequest();
        return TeaModel.build(map, self);
    }

    public UploadPartRequest setBucketName(String bucketName) {
        this.bucketName = bucketName;
        return this;
    }
    public String getBucketName() {
        return this.bucketName;
    }

    public UploadPartRequest setObjectName(String objectName) {
        this.objectName = objectName;
        return this;
    }
    public String getObjectName() {
        return this.objectName;
    }

    public UploadPartRequest setBody(java.io.InputStream body) {
        this.body = body;
        return this;
    }
    public java.io.InputStream getBody() {
        return this.body;
    }

    public UploadPartRequest setFilter(UploadPartRequestFilter filter) {
        this.filter = filter;
        return this;
    }
    public UploadPartRequestFilter getFilter() {
        return this.filter;
    }

    public static class UploadPartRequestFilter extends TeaModel {
        // partNumber
        @NameInMap("partNumber")
        @Validation(required = true)
        public String partNumber;

        // uploadId
        @NameInMap("uploadId")
        @Validation(required = true)
        public String uploadId;

        public static UploadPartRequestFilter build(java.util.Map<String, ?> map) throws Exception {
            UploadPartRequestFilter self = new UploadPartRequestFilter();
            return TeaModel.build(map, self);
        }

        public UploadPartRequestFilter setPartNumber(String partNumber) {
            this.partNumber = partNumber;
            return this;
        }
        public String getPartNumber() {
            return this.partNumber;
        }

        public UploadPartRequestFilter setUploadId(String uploadId) {
            this.uploadId = uploadId;
            return this;
        }
        public String getUploadId() {
            return this.uploadId;
        }

    }

}
