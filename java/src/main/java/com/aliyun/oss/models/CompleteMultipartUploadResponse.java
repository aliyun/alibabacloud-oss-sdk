// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class CompleteMultipartUploadResponse extends TeaModel {
    @NameInMap("x-oss-request-id")
    @Validation(required = true)
    public String requestId;

    @NameInMap("CompleteMultipartUploadResult")
    @Validation(required = true)
    public CompleteMultipartUploadResponseCompleteMultipartUploadResult completeMultipartUploadResult;

    public static CompleteMultipartUploadResponse build(java.util.Map<String, ?> map) throws Exception {
        CompleteMultipartUploadResponse self = new CompleteMultipartUploadResponse();
        return TeaModel.build(map, self);
    }

    public static class CompleteMultipartUploadResponseCompleteMultipartUploadResult extends TeaModel {
        @NameInMap("Bucket")
        public String bucket;

        @NameInMap("ETag")
        public String eTag;

        @NameInMap("Location")
        public String location;

        @NameInMap("Key")
        public String key;

        @NameInMap("EncodingType")
        public String encodingType;

        public static CompleteMultipartUploadResponseCompleteMultipartUploadResult build(java.util.Map<String, ?> map) throws Exception {
            CompleteMultipartUploadResponseCompleteMultipartUploadResult self = new CompleteMultipartUploadResponseCompleteMultipartUploadResult();
            return TeaModel.build(map, self);
        }

    }

}
