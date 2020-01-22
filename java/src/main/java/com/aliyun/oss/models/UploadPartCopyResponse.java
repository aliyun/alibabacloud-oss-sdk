// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class UploadPartCopyResponse extends TeaModel {
    @NameInMap("x-oss-request-id")
    @Validation(required = true)
    public String requestId;

    @NameInMap("CopyPartResult")
    @Validation(required = true)
    public UploadPartCopyResponseCopyPartResult copyPartResult;

    public static UploadPartCopyResponse build(java.util.Map<String, ?> map) throws Exception {
        UploadPartCopyResponse self = new UploadPartCopyResponse();
        return TeaModel.build(map, self);
    }

    public static class UploadPartCopyResponseCopyPartResult extends TeaModel {
        @NameInMap("LastModified")
        public String lastModified;

        @NameInMap("ETag")
        public String eTag;

        public static UploadPartCopyResponseCopyPartResult build(java.util.Map<String, ?> map) throws Exception {
            UploadPartCopyResponseCopyPartResult self = new UploadPartCopyResponseCopyPartResult();
            return TeaModel.build(map, self);
        }

    }

}
