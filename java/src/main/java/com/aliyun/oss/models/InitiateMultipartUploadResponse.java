// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class InitiateMultipartUploadResponse extends TeaModel {
    // x-oss-request-id
    @NameInMap("x-oss-request-id")
    @Validation(required = true)
    public String requestId;

    // InitiateMultipartUploadResult
    @NameInMap("InitiateMultipartUploadResult")
    @Validation(required = true)
    public InitiateMultipartUploadResponseInitiateMultipartUploadResult initiateMultipartUploadResult;

    public static InitiateMultipartUploadResponse build(java.util.Map<String, ?> map) throws Exception {
        InitiateMultipartUploadResponse self = new InitiateMultipartUploadResponse();
        return TeaModel.build(map, self);
    }

    public InitiateMultipartUploadResponse setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public InitiateMultipartUploadResponse setInitiateMultipartUploadResult(InitiateMultipartUploadResponseInitiateMultipartUploadResult initiateMultipartUploadResult) {
        this.initiateMultipartUploadResult = initiateMultipartUploadResult;
        return this;
    }
    public InitiateMultipartUploadResponseInitiateMultipartUploadResult getInitiateMultipartUploadResult() {
        return this.initiateMultipartUploadResult;
    }

    public static class InitiateMultipartUploadResponseInitiateMultipartUploadResult extends TeaModel {
        // Bucket
        @NameInMap("Bucket")
        public String bucket;

        // Key
        @NameInMap("Key")
        public String key;

        // UploadId
        @NameInMap("UploadId")
        public String uploadId;

        public static InitiateMultipartUploadResponseInitiateMultipartUploadResult build(java.util.Map<String, ?> map) throws Exception {
            InitiateMultipartUploadResponseInitiateMultipartUploadResult self = new InitiateMultipartUploadResponseInitiateMultipartUploadResult();
            return TeaModel.build(map, self);
        }

        public InitiateMultipartUploadResponseInitiateMultipartUploadResult setBucket(String bucket) {
            this.bucket = bucket;
            return this;
        }
        public String getBucket() {
            return this.bucket;
        }

        public InitiateMultipartUploadResponseInitiateMultipartUploadResult setKey(String key) {
            this.key = key;
            return this;
        }
        public String getKey() {
            return this.key;
        }

        public InitiateMultipartUploadResponseInitiateMultipartUploadResult setUploadId(String uploadId) {
            this.uploadId = uploadId;
            return this;
        }
        public String getUploadId() {
            return this.uploadId;
        }

    }

}
