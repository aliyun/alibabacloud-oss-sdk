// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class DeleteMultipleObjectsRequest extends TeaModel {
    // BucketName
    @NameInMap("BucketName")
    @Validation(required = true, pattern = "[a-zA-Z0-9\\-\\_]+")
    public String bucketName;

    // Body
    @NameInMap("Body")
    public DeleteMultipleObjectsRequestBody body;

    // Header
    @NameInMap("Header")
    @Validation(required = true)
    public DeleteMultipleObjectsRequestHeader header;

    public static DeleteMultipleObjectsRequest build(java.util.Map<String, ?> map) throws Exception {
        DeleteMultipleObjectsRequest self = new DeleteMultipleObjectsRequest();
        return TeaModel.build(map, self);
    }

    public DeleteMultipleObjectsRequest setBucketName(String bucketName) {
        this.bucketName = bucketName;
        return this;
    }
    public String getBucketName() {
        return this.bucketName;
    }

    public DeleteMultipleObjectsRequest setBody(DeleteMultipleObjectsRequestBody body) {
        this.body = body;
        return this;
    }
    public DeleteMultipleObjectsRequestBody getBody() {
        return this.body;
    }

    public DeleteMultipleObjectsRequest setHeader(DeleteMultipleObjectsRequestHeader header) {
        this.header = header;
        return this;
    }
    public DeleteMultipleObjectsRequestHeader getHeader() {
        return this.header;
    }

    public static class DeleteMultipleObjectsRequestBodyDeleteObject extends TeaModel {
        // Key
        @NameInMap("Key")
        public String key;

        public static DeleteMultipleObjectsRequestBodyDeleteObject build(java.util.Map<String, ?> map) throws Exception {
            DeleteMultipleObjectsRequestBodyDeleteObject self = new DeleteMultipleObjectsRequestBodyDeleteObject();
            return TeaModel.build(map, self);
        }

        public DeleteMultipleObjectsRequestBodyDeleteObject setKey(String key) {
            this.key = key;
            return this;
        }
        public String getKey() {
            return this.key;
        }

    }

    public static class DeleteMultipleObjectsRequestBodyDelete extends TeaModel {
        // Object
        @NameInMap("Object")
        public java.util.List<DeleteMultipleObjectsRequestBodyDeleteObject> object;

        // Quiet
        @NameInMap("Quiet")
        public String quiet;

        public static DeleteMultipleObjectsRequestBodyDelete build(java.util.Map<String, ?> map) throws Exception {
            DeleteMultipleObjectsRequestBodyDelete self = new DeleteMultipleObjectsRequestBodyDelete();
            return TeaModel.build(map, self);
        }

        public DeleteMultipleObjectsRequestBodyDelete setObject(java.util.List<DeleteMultipleObjectsRequestBodyDeleteObject> object) {
            this.object = object;
            return this;
        }
        public java.util.List<DeleteMultipleObjectsRequestBodyDeleteObject> getObject() {
            return this.object;
        }

        public DeleteMultipleObjectsRequestBodyDelete setQuiet(String quiet) {
            this.quiet = quiet;
            return this;
        }
        public String getQuiet() {
            return this.quiet;
        }

    }

    public static class DeleteMultipleObjectsRequestBody extends TeaModel {
        // Delete
        @NameInMap("Delete")
        @Validation(required = true)
        public DeleteMultipleObjectsRequestBodyDelete delete;

        public static DeleteMultipleObjectsRequestBody build(java.util.Map<String, ?> map) throws Exception {
            DeleteMultipleObjectsRequestBody self = new DeleteMultipleObjectsRequestBody();
            return TeaModel.build(map, self);
        }

        public DeleteMultipleObjectsRequestBody setDelete(DeleteMultipleObjectsRequestBodyDelete delete) {
            this.delete = delete;
            return this;
        }
        public DeleteMultipleObjectsRequestBodyDelete getDelete() {
            return this.delete;
        }

    }

    public static class DeleteMultipleObjectsRequestHeader extends TeaModel {
        // Encoding-type
        @NameInMap("Encoding-type")
        public String encodingType;

        // Content-Length
        @NameInMap("Content-Length")
        @Validation(required = true)
        public String contentLength;

        // Content-MD5
        @NameInMap("Content-MD5")
        @Validation(required = true)
        public String contentMD5;

        public static DeleteMultipleObjectsRequestHeader build(java.util.Map<String, ?> map) throws Exception {
            DeleteMultipleObjectsRequestHeader self = new DeleteMultipleObjectsRequestHeader();
            return TeaModel.build(map, self);
        }

        public DeleteMultipleObjectsRequestHeader setEncodingType(String encodingType) {
            this.encodingType = encodingType;
            return this;
        }
        public String getEncodingType() {
            return this.encodingType;
        }

        public DeleteMultipleObjectsRequestHeader setContentLength(String contentLength) {
            this.contentLength = contentLength;
            return this;
        }
        public String getContentLength() {
            return this.contentLength;
        }

        public DeleteMultipleObjectsRequestHeader setContentMD5(String contentMD5) {
            this.contentMD5 = contentMD5;
            return this;
        }
        public String getContentMD5() {
            return this.contentMD5;
        }

    }

}
