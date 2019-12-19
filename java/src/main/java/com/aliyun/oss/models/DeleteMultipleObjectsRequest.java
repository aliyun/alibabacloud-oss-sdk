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

    public static class DeleteMultipleObjectsRequestBodyDeleteObject extends TeaModel {
        @NameInMap("Key")
        public String key;

    }

    public static class DeleteMultipleObjectsRequestBodyDelete extends TeaModel {
        @NameInMap("Object")
        public DeleteMultipleObjectsRequestBodyDeleteObject[] object;

        @NameInMap("Quiet")
        public String quiet;

    }

    public static class DeleteMultipleObjectsRequestBody extends TeaModel {
        @NameInMap("Delete")
        @Validation(required = true)
        public DeleteMultipleObjectsRequestBodyDelete delete;

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

    }

}
