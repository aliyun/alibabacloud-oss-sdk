// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class OptionObjectResponse extends TeaModel {
    // x-oss-request-id
    @NameInMap("x-oss-request-id")
    @Validation(required = true)
    public String requestId;

    // Access-Control-Allow-Origin
    @NameInMap("access-control-allow-origin")
    @Validation(required = true)
    public String accessControlAllowOrigin;

    // Access-Control-Allow-Methods
    @NameInMap("access-control-allow-methods")
    @Validation(required = true)
    public String accessControlAllowMethods;

    // Access-Control-Allow-Headers
    @NameInMap("access-control-allow-headers")
    @Validation(required = true)
    public String accessControlAllowHeaders;

    // Access-Control-Expose-Headers
    @NameInMap("access-control-expose-headers")
    @Validation(required = true)
    public String accessControlExposeHeaders;

    // Access-Control-Max-Age
    @NameInMap("access-control-max-age")
    @Validation(required = true)
    public String accessControlMaxAge;

    public static OptionObjectResponse build(java.util.Map<String, ?> map) throws Exception {
        OptionObjectResponse self = new OptionObjectResponse();
        return TeaModel.build(map, self);
    }

    public OptionObjectResponse setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public OptionObjectResponse setAccessControlAllowOrigin(String accessControlAllowOrigin) {
        this.accessControlAllowOrigin = accessControlAllowOrigin;
        return this;
    }
    public String getAccessControlAllowOrigin() {
        return this.accessControlAllowOrigin;
    }

    public OptionObjectResponse setAccessControlAllowMethods(String accessControlAllowMethods) {
        this.accessControlAllowMethods = accessControlAllowMethods;
        return this;
    }
    public String getAccessControlAllowMethods() {
        return this.accessControlAllowMethods;
    }

    public OptionObjectResponse setAccessControlAllowHeaders(String accessControlAllowHeaders) {
        this.accessControlAllowHeaders = accessControlAllowHeaders;
        return this;
    }
    public String getAccessControlAllowHeaders() {
        return this.accessControlAllowHeaders;
    }

    public OptionObjectResponse setAccessControlExposeHeaders(String accessControlExposeHeaders) {
        this.accessControlExposeHeaders = accessControlExposeHeaders;
        return this;
    }
    public String getAccessControlExposeHeaders() {
        return this.accessControlExposeHeaders;
    }

    public OptionObjectResponse setAccessControlMaxAge(String accessControlMaxAge) {
        this.accessControlMaxAge = accessControlMaxAge;
        return this;
    }
    public String getAccessControlMaxAge() {
        return this.accessControlMaxAge;
    }

}
