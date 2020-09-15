// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class CompleteMultipartUploadResponse extends TeaModel {
    // x-oss-request-id
    @NameInMap("x-oss-request-id")
    @Validation(required = true)
    public String requestId;

    // CompleteMultipartUploadResult
    @NameInMap("CompleteMultipartUploadResult")
    @Validation(required = true)
    public CompleteMultipartUploadResponseCompleteMultipartUploadResult completeMultipartUploadResult;

    public static CompleteMultipartUploadResponse build(java.util.Map<String, ?> map) {
        CompleteMultipartUploadResponse self = new CompleteMultipartUploadResponse();
        return TeaModel.build(map, self);
    }

    public CompleteMultipartUploadResponse setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public CompleteMultipartUploadResponse setCompleteMultipartUploadResult(CompleteMultipartUploadResponseCompleteMultipartUploadResult completeMultipartUploadResult) {
        this.completeMultipartUploadResult = completeMultipartUploadResult;
        return this;
    }
    public CompleteMultipartUploadResponseCompleteMultipartUploadResult getCompleteMultipartUploadResult() {
        return this.completeMultipartUploadResult;
    }

    public static class CompleteMultipartUploadResponseCompleteMultipartUploadResult extends TeaModel {
        // Bucket
        @NameInMap("Bucket")
        public String bucket;

        // ETag
        @NameInMap("ETag")
        public String eTag;

        // Location
        @NameInMap("Location")
        public String location;

        // Key
        @NameInMap("Key")
        public String key;

        // EncodingType
        @NameInMap("EncodingType")
        public String encodingType;

        public static CompleteMultipartUploadResponseCompleteMultipartUploadResult build(java.util.Map<String, ?> map) {
            CompleteMultipartUploadResponseCompleteMultipartUploadResult self = new CompleteMultipartUploadResponseCompleteMultipartUploadResult();
            return TeaModel.build(map, self);
        }

        public CompleteMultipartUploadResponseCompleteMultipartUploadResult setBucket(String bucket) {
            this.bucket = bucket;
            return this;
        }
        public String getBucket() {
            return this.bucket;
        }

        public CompleteMultipartUploadResponseCompleteMultipartUploadResult setETag(String eTag) {
            this.eTag = eTag;
            return this;
        }
        public String getETag() {
            return this.eTag;
        }

        public CompleteMultipartUploadResponseCompleteMultipartUploadResult setLocation(String location) {
            this.location = location;
            return this;
        }
        public String getLocation() {
            return this.location;
        }

        public CompleteMultipartUploadResponseCompleteMultipartUploadResult setKey(String key) {
            this.key = key;
            return this;
        }
        public String getKey() {
            return this.key;
        }

        public CompleteMultipartUploadResponseCompleteMultipartUploadResult setEncodingType(String encodingType) {
            this.encodingType = encodingType;
            return this;
        }
        public String getEncodingType() {
            return this.encodingType;
        }

    }

}
