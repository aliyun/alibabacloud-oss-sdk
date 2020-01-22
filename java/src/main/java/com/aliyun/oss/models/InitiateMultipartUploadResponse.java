// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class InitiateMultipartUploadResponse extends TeaModel {
    @NameInMap("x-oss-request-id")
    @Validation(required = true)
    public String requestId;

    @NameInMap("InitiateMultipartUploadResult")
    @Validation(required = true)
    public InitiateMultipartUploadResponseInitiateMultipartUploadResult initiateMultipartUploadResult;

    public static InitiateMultipartUploadResponse build(java.util.Map<String, ?> map) throws Exception {
        InitiateMultipartUploadResponse self = new InitiateMultipartUploadResponse();
        return TeaModel.build(map, self);
    }

    public static class InitiateMultipartUploadResponseInitiateMultipartUploadResult extends TeaModel {
        @NameInMap("Bucket")
        public String bucket;

        @NameInMap("Key")
        public String key;

        @NameInMap("UploadId")
        public String uploadId;

        public static InitiateMultipartUploadResponseInitiateMultipartUploadResult build(java.util.Map<String, ?> map) throws Exception {
            InitiateMultipartUploadResponseInitiateMultipartUploadResult self = new InitiateMultipartUploadResponseInitiateMultipartUploadResult();
            return TeaModel.build(map, self);
        }

    }

}
