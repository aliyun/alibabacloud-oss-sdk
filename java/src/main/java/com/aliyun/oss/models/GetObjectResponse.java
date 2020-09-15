// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class GetObjectResponse extends TeaModel {
    // x-oss-request-id
    @NameInMap("x-oss-request-id")
    @Validation(required = true)
    public String requestId;

    // x-oss-object-type
    @NameInMap("x-oss-object-type")
    @Validation(required = true)
    public String objectType;

    // x-oss-server-side-encryption
    @NameInMap("x-oss-server-side-encryption")
    @Validation(required = true)
    public String serverSideEncryption;

    // x-oss-tagging-count
    @NameInMap("x-oss-tagging-count")
    @Validation(required = true)
    public String taggingCount;

    // x-oss-restore
    @NameInMap("x-oss-restore")
    @Validation(required = true)
    public String restore;

    // body
    @NameInMap("body")
    @Validation(required = true)
    public java.io.InputStream body;

    public static GetObjectResponse build(java.util.Map<String, ?> map) {
        GetObjectResponse self = new GetObjectResponse();
        return TeaModel.build(map, self);
    }

    public GetObjectResponse setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public GetObjectResponse setObjectType(String objectType) {
        this.objectType = objectType;
        return this;
    }
    public String getObjectType() {
        return this.objectType;
    }

    public GetObjectResponse setServerSideEncryption(String serverSideEncryption) {
        this.serverSideEncryption = serverSideEncryption;
        return this;
    }
    public String getServerSideEncryption() {
        return this.serverSideEncryption;
    }

    public GetObjectResponse setTaggingCount(String taggingCount) {
        this.taggingCount = taggingCount;
        return this;
    }
    public String getTaggingCount() {
        return this.taggingCount;
    }

    public GetObjectResponse setRestore(String restore) {
        this.restore = restore;
        return this;
    }
    public String getRestore() {
        return this.restore;
    }

    public GetObjectResponse setBody(java.io.InputStream body) {
        this.body = body;
        return this;
    }
    public java.io.InputStream getBody() {
        return this.body;
    }

}
