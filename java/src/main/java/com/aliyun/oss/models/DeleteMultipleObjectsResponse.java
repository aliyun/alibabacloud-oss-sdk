// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class DeleteMultipleObjectsResponse extends TeaModel {
    // x-oss-request-id
    @NameInMap("x-oss-request-id")
    @Validation(required = true)
    public String requestId;

    // DeleteResult
    @NameInMap("DeleteResult")
    @Validation(required = true)
    public DeleteMultipleObjectsResponseDeleteResult deleteResult;

    public static DeleteMultipleObjectsResponse build(java.util.Map<String, ?> map) throws Exception {
        DeleteMultipleObjectsResponse self = new DeleteMultipleObjectsResponse();
        return TeaModel.build(map, self);
    }

    public DeleteMultipleObjectsResponse setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public DeleteMultipleObjectsResponse setDeleteResult(DeleteMultipleObjectsResponseDeleteResult deleteResult) {
        this.deleteResult = deleteResult;
        return this;
    }
    public DeleteMultipleObjectsResponseDeleteResult getDeleteResult() {
        return this.deleteResult;
    }

    public static class DeleteMultipleObjectsResponseDeleteResultDeleted extends TeaModel {
        // Key
        @NameInMap("Key")
        public String key;

        public static DeleteMultipleObjectsResponseDeleteResultDeleted build(java.util.Map<String, ?> map) throws Exception {
            DeleteMultipleObjectsResponseDeleteResultDeleted self = new DeleteMultipleObjectsResponseDeleteResultDeleted();
            return TeaModel.build(map, self);
        }

        public DeleteMultipleObjectsResponseDeleteResultDeleted setKey(String key) {
            this.key = key;
            return this;
        }
        public String getKey() {
            return this.key;
        }

    }

    public static class DeleteMultipleObjectsResponseDeleteResult extends TeaModel {
        // Quiet
        @NameInMap("Quiet")
        public String quiet;

        // EncodingType
        @NameInMap("EncodingType")
        public String encodingType;

        // Deleted
        @NameInMap("Deleted")
        public java.util.List<DeleteMultipleObjectsResponseDeleteResultDeleted> deleted;

        public static DeleteMultipleObjectsResponseDeleteResult build(java.util.Map<String, ?> map) throws Exception {
            DeleteMultipleObjectsResponseDeleteResult self = new DeleteMultipleObjectsResponseDeleteResult();
            return TeaModel.build(map, self);
        }

        public DeleteMultipleObjectsResponseDeleteResult setQuiet(String quiet) {
            this.quiet = quiet;
            return this;
        }
        public String getQuiet() {
            return this.quiet;
        }

        public DeleteMultipleObjectsResponseDeleteResult setEncodingType(String encodingType) {
            this.encodingType = encodingType;
            return this;
        }
        public String getEncodingType() {
            return this.encodingType;
        }

        public DeleteMultipleObjectsResponseDeleteResult setDeleted(java.util.List<DeleteMultipleObjectsResponseDeleteResultDeleted> deleted) {
            this.deleted = deleted;
            return this;
        }
        public java.util.List<DeleteMultipleObjectsResponseDeleteResultDeleted> getDeleted() {
            return this.deleted;
        }

    }

}
