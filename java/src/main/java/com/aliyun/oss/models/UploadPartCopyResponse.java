// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class UploadPartCopyResponse extends TeaModel {
    // x-oss-request-id
    @NameInMap("x-oss-request-id")
    @Validation(required = true)
    public String requestId;

    // CopyPartResult
    @NameInMap("CopyPartResult")
    @Validation(required = true)
    public UploadPartCopyResponseCopyPartResult copyPartResult;

    public static UploadPartCopyResponse build(java.util.Map<String, ?> map) throws Exception {
        UploadPartCopyResponse self = new UploadPartCopyResponse();
        return TeaModel.build(map, self);
    }

    public UploadPartCopyResponse setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public UploadPartCopyResponse setCopyPartResult(UploadPartCopyResponseCopyPartResult copyPartResult) {
        this.copyPartResult = copyPartResult;
        return this;
    }
    public UploadPartCopyResponseCopyPartResult getCopyPartResult() {
        return this.copyPartResult;
    }

    public static class UploadPartCopyResponseCopyPartResult extends TeaModel {
        // LastModified
        @NameInMap("LastModified")
        public String lastModified;

        // ETag
        @NameInMap("ETag")
        public String eTag;

        public static UploadPartCopyResponseCopyPartResult build(java.util.Map<String, ?> map) throws Exception {
            UploadPartCopyResponseCopyPartResult self = new UploadPartCopyResponseCopyPartResult();
            return TeaModel.build(map, self);
        }

        public UploadPartCopyResponseCopyPartResult setLastModified(String lastModified) {
            this.lastModified = lastModified;
            return this;
        }
        public String getLastModified() {
            return this.lastModified;
        }

        public UploadPartCopyResponseCopyPartResult setETag(String eTag) {
            this.eTag = eTag;
            return this;
        }
        public String getETag() {
            return this.eTag;
        }

    }

}
