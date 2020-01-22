// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class GetSymlinkResponse extends TeaModel {
    @NameInMap("x-oss-request-id")
    @Validation(required = true)
    public String requestId;

    @NameInMap("x-oss-symlink-target")
    @Validation(required = true)
    public String symlinkTarget;

    public static GetSymlinkResponse build(java.util.Map<String, ?> map) throws Exception {
        GetSymlinkResponse self = new GetSymlinkResponse();
        return TeaModel.build(map, self);
    }

}
