// This file is auto-generated, don't edit it. Thanks.
package com.oss.models;

import com.aliyun.tea.*;

public class InitiateMultipartUploadResponse extends TeaModel {
    @NameInMap("x-oss-request-id")
    @Validation(required = true)
    public String requestId;

    @NameInMap("InitiateMultipartUploadResult")
    @Validation(required = true)
    public InitiateMultipartUploadResponseInitiateMultipartUploadResult initiateMultipartUploadResult;

    public static class InitiateMultipartUploadResponseInitiateMultipartUploadResult extends TeaModel {
        @NameInMap("Bucket")
        @Validation(required = true)
        public String bucket;

        @NameInMap("Key")
        @Validation(required = true)
        public String key;

        @NameInMap("UploadId")
        @Validation(required = true)
        public String uploadId;

    }

}
