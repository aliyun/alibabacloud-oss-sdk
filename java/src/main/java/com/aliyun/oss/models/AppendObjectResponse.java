// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class AppendObjectResponse extends TeaModel {
    @NameInMap("x-oss-request-id")
    @Validation(required = true)
    public String requestId;

    @NameInMap("x-oss-next-append-position")
    @Validation(required = true)
    public String nextAppendPosition;

    @NameInMap("x-oss-hash-crc64ecma")
    @Validation(required = true)
    public String hashCrc64ecma;

}
