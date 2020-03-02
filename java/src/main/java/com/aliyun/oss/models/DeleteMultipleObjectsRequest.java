// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class DeleteMultipleObjectsRequest extends TeaModel {
    @NameInMap("BucketName")
    @Validation(required = true)
    public String bucketName;

    @NameInMap("Body")
    public DeleteMultipleObjectsRequestBody body;

    @NameInMap("Header")
    @Validation(required = true)
    public DeleteMultipleObjectsRequestHeader header;

    public static DeleteMultipleObjectsRequest build(java.util.Map<String, ?> map) throws Exception {
        DeleteMultipleObjectsRequest self = new DeleteMultipleObjectsRequest();
        return TeaModel.build(map, self);
    }

    public static class DeleteMultipleObjectsRequestBodyDeleteObject extends TeaModel {
        @NameInMap("Key")
        public String key;

        public static DeleteMultipleObjectsRequestBodyDeleteObject build(java.util.Map<String, ?> map) throws Exception {
            DeleteMultipleObjectsRequestBodyDeleteObject self = new DeleteMultipleObjectsRequestBodyDeleteObject();
            return TeaModel.build(map, self);
        }

    }

    public static class DeleteMultipleObjectsRequestBodyDelete extends TeaModel {
        @NameInMap("Object")
        public java.util.List<DeleteMultipleObjectsRequestBodyDeleteObject> object;

        @NameInMap("Quiet")
        public String quiet;

        public static DeleteMultipleObjectsRequestBodyDelete build(java.util.Map<String, ?> map) throws Exception {
            DeleteMultipleObjectsRequestBodyDelete self = new DeleteMultipleObjectsRequestBodyDelete();
            return TeaModel.build(map, self);
        }

    }

    public static class DeleteMultipleObjectsRequestBody extends TeaModel {
        @NameInMap("Delete")
        @Validation(required = true)
        public DeleteMultipleObjectsRequestBodyDelete delete;

        public static DeleteMultipleObjectsRequestBody build(java.util.Map<String, ?> map) throws Exception {
            DeleteMultipleObjectsRequestBody self = new DeleteMultipleObjectsRequestBody();
            return TeaModel.build(map, self);
        }

    }

    public static class DeleteMultipleObjectsRequestHeader extends TeaModel {
        @NameInMap("Encoding-type")
        public String encodingType;

        @NameInMap("Content-Length")
        @Validation(required = true)
        public String contentLength;

        @NameInMap("Content-MD5")
        @Validation(required = true)
        public String contentMD5;

        public static DeleteMultipleObjectsRequestHeader build(java.util.Map<String, ?> map) throws Exception {
            DeleteMultipleObjectsRequestHeader self = new DeleteMultipleObjectsRequestHeader();
            return TeaModel.build(map, self);
        }

    }

}
