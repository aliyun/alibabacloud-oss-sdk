// This file is auto-generated, don't edit it. Thanks.
package com.oss.models;

import com.aliyun.tea.*;

public class CopyObjectResponse extends TeaModel {
    @NameInMap("x-oss-request-id")
    @Validation(required = true)
    public String requestId;

    @NameInMap("CopyObjectResult")
    @Validation(required = true)
    public CopyObjectResponseCopyObjectResult copyObjectResult;

    public static class CopyObjectResponseCopyObjectResult extends TeaModel {
        @NameInMap("LastModified")
        @Validation(required = true)
        public String lastModified;

        @NameInMap("ETag")
        @Validation(required = true)
        public String eTag;

    }

}
