// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class PutObjectResponse extends TeaModel {
    // x-oss-request-id
    @NameInMap("x-oss-request-id")
    @Validation(required = true)
    public String requestId;

    // x-oss-hash-crc64ecma
    @NameInMap("x-oss-hash-crc64ecma")
    @Validation(required = true)
    public String hashCrc64ecma;

    // x-oss-server-time
    @NameInMap("x-oss-server-time")
    @Validation(required = true)
    public String serverTime;

    // x-oss-bucket-version
    @NameInMap("x-oss-bucket-version")
    @Validation(required = true)
    public String bucketVersion;

    public static PutObjectResponse build(java.util.Map<String, ?> map) throws Exception {
        PutObjectResponse self = new PutObjectResponse();
        return TeaModel.build(map, self);
    }

    public PutObjectResponse setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public PutObjectResponse setHashCrc64ecma(String hashCrc64ecma) {
        this.hashCrc64ecma = hashCrc64ecma;
        return this;
    }
    public String getHashCrc64ecma() {
        return this.hashCrc64ecma;
    }

    public PutObjectResponse setServerTime(String serverTime) {
        this.serverTime = serverTime;
        return this;
    }
    public String getServerTime() {
        return this.serverTime;
    }

    public PutObjectResponse setBucketVersion(String bucketVersion) {
        this.bucketVersion = bucketVersion;
        return this;
    }
    public String getBucketVersion() {
        return this.bucketVersion;
    }

}
