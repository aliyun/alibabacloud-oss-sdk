// This file is auto-generated, don't edit it. Thanks.
package com.oss.models;

import com.aliyun.tea.*;

public class PutObjectResponse extends TeaModel {
    @NameInMap("x-oss-request-id")
    @Validation(required = true)
    public String requestId;

    @NameInMap("x-oss-hash-crc64ecma")
    @Validation(required = true)
    public String hashCrc64ecma;

    @NameInMap("x-oss-server-time")
    @Validation(required = true)
    public String serverTime;

    @NameInMap("x-oss-bucket-version")
    @Validation(required = true)
    public String bucketVersion;

}
