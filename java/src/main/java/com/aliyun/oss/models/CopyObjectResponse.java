// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class CopyObjectResponse extends TeaModel {
    // x-oss-request-id
    @NameInMap("x-oss-request-id")
    @Validation(required = true)
    public String requestId;

    // CopyObjectResult
    @NameInMap("CopyObjectResult")
    @Validation(required = true)
    public CopyObjectResponseCopyObjectResult copyObjectResult;

    public static CopyObjectResponse build(java.util.Map<String, ?> map) throws Exception {
        CopyObjectResponse self = new CopyObjectResponse();
        return TeaModel.build(map, self);
    }

    public CopyObjectResponse setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public CopyObjectResponse setCopyObjectResult(CopyObjectResponseCopyObjectResult copyObjectResult) {
        this.copyObjectResult = copyObjectResult;
        return this;
    }
    public CopyObjectResponseCopyObjectResult getCopyObjectResult() {
        return this.copyObjectResult;
    }

    public static class CopyObjectResponseCopyObjectResult extends TeaModel {
        // LastModified
        @NameInMap("LastModified")
        public String lastModified;

        // ETag
        @NameInMap("ETag")
        public String eTag;

        public static CopyObjectResponseCopyObjectResult build(java.util.Map<String, ?> map) throws Exception {
            CopyObjectResponseCopyObjectResult self = new CopyObjectResponseCopyObjectResult();
            return TeaModel.build(map, self);
        }

        public CopyObjectResponseCopyObjectResult setLastModified(String lastModified) {
            this.lastModified = lastModified;
            return this;
        }
        public String getLastModified() {
            return this.lastModified;
        }

        public CopyObjectResponseCopyObjectResult setETag(String eTag) {
            this.eTag = eTag;
            return this;
        }
        public String getETag() {
            return this.eTag;
        }

    }

}
