// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class AppendObjectResponse extends TeaModel {
    // x-oss-request-id
    @NameInMap("x-oss-request-id")
    @Validation(required = true)
    public String requestId;

    // x-oss-next-append-position
    @NameInMap("x-oss-next-append-position")
    @Validation(required = true)
    public String nextAppendPosition;

    // x-oss-hash-crc64ecma
    @NameInMap("x-oss-hash-crc64ecma")
    @Validation(required = true)
    public String hashCrc64ecma;

    public static AppendObjectResponse build(java.util.Map<String, ?> map) throws Exception {
        AppendObjectResponse self = new AppendObjectResponse();
        return TeaModel.build(map, self);
    }

    public AppendObjectResponse setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public AppendObjectResponse setNextAppendPosition(String nextAppendPosition) {
        this.nextAppendPosition = nextAppendPosition;
        return this;
    }
    public String getNextAppendPosition() {
        return this.nextAppendPosition;
    }

    public AppendObjectResponse setHashCrc64ecma(String hashCrc64ecma) {
        this.hashCrc64ecma = hashCrc64ecma;
        return this;
    }
    public String getHashCrc64ecma() {
        return this.hashCrc64ecma;
    }

}
