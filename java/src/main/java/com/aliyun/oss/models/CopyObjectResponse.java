// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

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
        public String lastModified;

        @NameInMap("ETag")
        public String eTag;

    }

}
