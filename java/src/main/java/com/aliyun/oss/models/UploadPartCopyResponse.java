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

    public static class UploadPartCopyResponseCopyPartResult extends TeaModel {
        @NameInMap("LastModified")
        public String lastModified;

        @NameInMap("ETag")
        public String eTag;

    }

}
