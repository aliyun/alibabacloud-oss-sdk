// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class CompleteMultipartUploadRequest extends TeaModel {
    // BucketName
    @NameInMap("BucketName")
    @Validation(required = true, pattern = "[a-zA-Z0-9\\-\\_]+")
    public String bucketName;

    // ObjectName
    @NameInMap("ObjectName")
    @Validation(required = true)
    public String objectName;

    // Filter
    @NameInMap("Filter")
    @Validation(required = true)
    public CompleteMultipartUploadRequestFilter filter;

    // Body
    @NameInMap("Body")
    public CompleteMultipartUploadRequestBody body;

    public static CompleteMultipartUploadRequest build(java.util.Map<String, ?> map) throws Exception {
        CompleteMultipartUploadRequest self = new CompleteMultipartUploadRequest();
        return TeaModel.build(map, self);
    }

    public CompleteMultipartUploadRequest setBucketName(String bucketName) {
        this.bucketName = bucketName;
        return this;
    }
    public String getBucketName() {
        return this.bucketName;
    }

    public CompleteMultipartUploadRequest setObjectName(String objectName) {
        this.objectName = objectName;
        return this;
    }
    public String getObjectName() {
        return this.objectName;
    }

    public CompleteMultipartUploadRequest setFilter(CompleteMultipartUploadRequestFilter filter) {
        this.filter = filter;
        return this;
    }
    public CompleteMultipartUploadRequestFilter getFilter() {
        return this.filter;
    }

    public CompleteMultipartUploadRequest setBody(CompleteMultipartUploadRequestBody body) {
        this.body = body;
        return this;
    }
    public CompleteMultipartUploadRequestBody getBody() {
        return this.body;
    }

    public static class CompleteMultipartUploadRequestFilter extends TeaModel {
        // uploadId
        @NameInMap("uploadId")
        @Validation(required = true)
        public String uploadId;

        // Encoding-type
        @NameInMap("Encoding-type")
        public String encodingType;

        public static CompleteMultipartUploadRequestFilter build(java.util.Map<String, ?> map) throws Exception {
            CompleteMultipartUploadRequestFilter self = new CompleteMultipartUploadRequestFilter();
            return TeaModel.build(map, self);
        }

        public CompleteMultipartUploadRequestFilter setUploadId(String uploadId) {
            this.uploadId = uploadId;
            return this;
        }
        public String getUploadId() {
            return this.uploadId;
        }

        public CompleteMultipartUploadRequestFilter setEncodingType(String encodingType) {
            this.encodingType = encodingType;
            return this;
        }
        public String getEncodingType() {
            return this.encodingType;
        }

    }

    public static class CompleteMultipartUploadRequestBodyCompleteMultipartUploadPart extends TeaModel {
        // PartNumber
        @NameInMap("PartNumber")
        public String partNumber;

        // ETag
        @NameInMap("ETag")
        public String eTag;

        public static CompleteMultipartUploadRequestBodyCompleteMultipartUploadPart build(java.util.Map<String, ?> map) throws Exception {
            CompleteMultipartUploadRequestBodyCompleteMultipartUploadPart self = new CompleteMultipartUploadRequestBodyCompleteMultipartUploadPart();
            return TeaModel.build(map, self);
        }

        public CompleteMultipartUploadRequestBodyCompleteMultipartUploadPart setPartNumber(String partNumber) {
            this.partNumber = partNumber;
            return this;
        }
        public String getPartNumber() {
            return this.partNumber;
        }

        public CompleteMultipartUploadRequestBodyCompleteMultipartUploadPart setETag(String eTag) {
            this.eTag = eTag;
            return this;
        }
        public String getETag() {
            return this.eTag;
        }

    }

    public static class CompleteMultipartUploadRequestBodyCompleteMultipartUpload extends TeaModel {
        // Part
        @NameInMap("Part")
        public java.util.List<CompleteMultipartUploadRequestBodyCompleteMultipartUploadPart> part;

        public static CompleteMultipartUploadRequestBodyCompleteMultipartUpload build(java.util.Map<String, ?> map) throws Exception {
            CompleteMultipartUploadRequestBodyCompleteMultipartUpload self = new CompleteMultipartUploadRequestBodyCompleteMultipartUpload();
            return TeaModel.build(map, self);
        }

        public CompleteMultipartUploadRequestBodyCompleteMultipartUpload setPart(java.util.List<CompleteMultipartUploadRequestBodyCompleteMultipartUploadPart> part) {
            this.part = part;
            return this;
        }
        public java.util.List<CompleteMultipartUploadRequestBodyCompleteMultipartUploadPart> getPart() {
            return this.part;
        }

    }

    public static class CompleteMultipartUploadRequestBody extends TeaModel {
        // CompleteMultipartUpload
        @NameInMap("CompleteMultipartUpload")
        @Validation(required = true)
        public CompleteMultipartUploadRequestBodyCompleteMultipartUpload completeMultipartUpload;

        public static CompleteMultipartUploadRequestBody build(java.util.Map<String, ?> map) throws Exception {
            CompleteMultipartUploadRequestBody self = new CompleteMultipartUploadRequestBody();
            return TeaModel.build(map, self);
        }

        public CompleteMultipartUploadRequestBody setCompleteMultipartUpload(CompleteMultipartUploadRequestBodyCompleteMultipartUpload completeMultipartUpload) {
            this.completeMultipartUpload = completeMultipartUpload;
            return this;
        }
        public CompleteMultipartUploadRequestBodyCompleteMultipartUpload getCompleteMultipartUpload() {
            return this.completeMultipartUpload;
        }

    }

}
