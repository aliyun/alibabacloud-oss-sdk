// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class GetObjectResponse extends TeaModel {
    @NameInMap("x-oss-request-id")
    @Validation(required = true)
    public String requestId;

    @NameInMap("x-oss-object-type")
    @Validation(required = true)
    public String objectType;

    @NameInMap("x-oss-server-side-encryption")
    @Validation(required = true)
    public String serverSideEncryption;

    @NameInMap("x-oss-tagging-count")
    @Validation(required = true)
    public String taggingCount;

    @NameInMap("x-oss-restore")
    @Validation(required = true)
    public String restore;

    @NameInMap("body")
    @Validation(required = true)
    public java.io.InputStream body;

    public static GetObjectResponse build(java.util.Map<String, ?> map) throws Exception {
        GetObjectResponse self = new GetObjectResponse();
        return TeaModel.build(map, self);
    }

}
