// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class ListMultipartUploadsResponse extends TeaModel {
    // x-oss-request-id
    @NameInMap("x-oss-request-id")
    @Validation(required = true)
    public String requestId;

    // ListMultipartUploadsResult
    @NameInMap("ListMultipartUploadsResult")
    @Validation(required = true)
    public ListMultipartUploadsResponseListMultipartUploadsResult listMultipartUploadsResult;

    public static ListMultipartUploadsResponse build(java.util.Map<String, ?> map) throws Exception {
        ListMultipartUploadsResponse self = new ListMultipartUploadsResponse();
        return TeaModel.build(map, self);
    }

    public ListMultipartUploadsResponse setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public ListMultipartUploadsResponse setListMultipartUploadsResult(ListMultipartUploadsResponseListMultipartUploadsResult listMultipartUploadsResult) {
        this.listMultipartUploadsResult = listMultipartUploadsResult;
        return this;
    }
    public ListMultipartUploadsResponseListMultipartUploadsResult getListMultipartUploadsResult() {
        return this.listMultipartUploadsResult;
    }

    public static class ListMultipartUploadsResponseListMultipartUploadsResultUpload extends TeaModel {
        // Key
        @NameInMap("Key")
        public String key;

        // UploadId
        @NameInMap("UploadId")
        public String uploadId;

        // Initiated
        @NameInMap("Initiated")
        public String initiated;

        public static ListMultipartUploadsResponseListMultipartUploadsResultUpload build(java.util.Map<String, ?> map) throws Exception {
            ListMultipartUploadsResponseListMultipartUploadsResultUpload self = new ListMultipartUploadsResponseListMultipartUploadsResultUpload();
            return TeaModel.build(map, self);
        }

        public ListMultipartUploadsResponseListMultipartUploadsResultUpload setKey(String key) {
            this.key = key;
            return this;
        }
        public String getKey() {
            return this.key;
        }

        public ListMultipartUploadsResponseListMultipartUploadsResultUpload setUploadId(String uploadId) {
            this.uploadId = uploadId;
            return this;
        }
        public String getUploadId() {
            return this.uploadId;
        }

        public ListMultipartUploadsResponseListMultipartUploadsResultUpload setInitiated(String initiated) {
            this.initiated = initiated;
            return this;
        }
        public String getInitiated() {
            return this.initiated;
        }

    }

    public static class ListMultipartUploadsResponseListMultipartUploadsResult extends TeaModel {
        // Bucket
        @NameInMap("Bucket")
        public String bucket;

        // EncodingType
        @NameInMap("EncodingType")
        public String encodingType;

        // KeyMarker
        @NameInMap("KeyMarker")
        public String keyMarker;

        // UploadIdMarker
        @NameInMap("UploadIdMarker")
        public String uploadIdMarker;

        // NextKeyMarker
        @NameInMap("NextKeyMarker")
        public String nextKeyMarker;

        // NextUploadIdMarker
        @NameInMap("NextUploadIdMarker")
        public String nextUploadIdMarker;

        // Delimiter
        @NameInMap("Delimiter")
        public String delimiter;

        // MaxUploads
        @NameInMap("MaxUploads")
        public String maxUploads;

        // IsTruncated
        @NameInMap("IsTruncated")
        public String isTruncated;

        // Upload
        @NameInMap("Upload")
        public java.util.List<ListMultipartUploadsResponseListMultipartUploadsResultUpload> upload;

        public static ListMultipartUploadsResponseListMultipartUploadsResult build(java.util.Map<String, ?> map) throws Exception {
            ListMultipartUploadsResponseListMultipartUploadsResult self = new ListMultipartUploadsResponseListMultipartUploadsResult();
            return TeaModel.build(map, self);
        }

        public ListMultipartUploadsResponseListMultipartUploadsResult setBucket(String bucket) {
            this.bucket = bucket;
            return this;
        }
        public String getBucket() {
            return this.bucket;
        }

        public ListMultipartUploadsResponseListMultipartUploadsResult setEncodingType(String encodingType) {
            this.encodingType = encodingType;
            return this;
        }
        public String getEncodingType() {
            return this.encodingType;
        }

        public ListMultipartUploadsResponseListMultipartUploadsResult setKeyMarker(String keyMarker) {
            this.keyMarker = keyMarker;
            return this;
        }
        public String getKeyMarker() {
            return this.keyMarker;
        }

        public ListMultipartUploadsResponseListMultipartUploadsResult setUploadIdMarker(String uploadIdMarker) {
            this.uploadIdMarker = uploadIdMarker;
            return this;
        }
        public String getUploadIdMarker() {
            return this.uploadIdMarker;
        }

        public ListMultipartUploadsResponseListMultipartUploadsResult setNextKeyMarker(String nextKeyMarker) {
            this.nextKeyMarker = nextKeyMarker;
            return this;
        }
        public String getNextKeyMarker() {
            return this.nextKeyMarker;
        }

        public ListMultipartUploadsResponseListMultipartUploadsResult setNextUploadIdMarker(String nextUploadIdMarker) {
            this.nextUploadIdMarker = nextUploadIdMarker;
            return this;
        }
        public String getNextUploadIdMarker() {
            return this.nextUploadIdMarker;
        }

        public ListMultipartUploadsResponseListMultipartUploadsResult setDelimiter(String delimiter) {
            this.delimiter = delimiter;
            return this;
        }
        public String getDelimiter() {
            return this.delimiter;
        }

        public ListMultipartUploadsResponseListMultipartUploadsResult setMaxUploads(String maxUploads) {
            this.maxUploads = maxUploads;
            return this;
        }
        public String getMaxUploads() {
            return this.maxUploads;
        }

        public ListMultipartUploadsResponseListMultipartUploadsResult setIsTruncated(String isTruncated) {
            this.isTruncated = isTruncated;
            return this;
        }
        public String getIsTruncated() {
            return this.isTruncated;
        }

        public ListMultipartUploadsResponseListMultipartUploadsResult setUpload(java.util.List<ListMultipartUploadsResponseListMultipartUploadsResultUpload> upload) {
            this.upload = upload;
            return this;
        }
        public java.util.List<ListMultipartUploadsResponseListMultipartUploadsResultUpload> getUpload() {
            return this.upload;
        }

    }

}
