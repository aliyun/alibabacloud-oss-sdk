// This file is auto-generated, don't edit it. Thanks.
package com.oss.models;

import com.aliyun.tea.*;

public class UploadPartCopyResponse extends TeaModel {
    @NameInMap("x-oss-request-id")
    @Validation(required = true)
    public String requestId;

    @NameInMap("CopyPartResult")
    @Validation(required = true)
    public UploadPartCopyResponseCopyPartResult copyPartResult;

    public static class UploadPartCopyResponseCopyPartResult extends TeaModel {
        @NameInMap("LastModified")
        @Validation(required = true)
        public String lastModified;

        @NameInMap("ETag")
        @Validation(required = true)
        public String eTag;

    }

}
