// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class GetSymlinkResponse extends TeaModel {
    // x-oss-request-id
    @NameInMap("x-oss-request-id")
    @Validation(required = true)
    public String requestId;

    // x-oss-symlink-target
    @NameInMap("x-oss-symlink-target")
    @Validation(required = true)
    public String symlinkTarget;

    public static GetSymlinkResponse build(java.util.Map<String, ?> map) throws Exception {
        GetSymlinkResponse self = new GetSymlinkResponse();
        return TeaModel.build(map, self);
    }

    public GetSymlinkResponse setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public GetSymlinkResponse setSymlinkTarget(String symlinkTarget) {
        this.symlinkTarget = symlinkTarget;
        return this;
    }
    public String getSymlinkTarget() {
        return this.symlinkTarget;
    }

}
