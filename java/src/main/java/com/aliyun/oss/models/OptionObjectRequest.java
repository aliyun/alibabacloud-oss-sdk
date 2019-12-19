// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class OptionObjectRequest extends TeaModel {
    @NameInMap("BucketName")
    @Validation(required = true)
    public String bucketName;

    @NameInMap("ObjectName")
    @Validation(required = true)
    public String objectName;

    @NameInMap("Header")
    @Validation(required = true)
    public OptionObjectRequestHeader header;

    public static class OptionObjectRequestHeader extends TeaModel {
        @NameInMap("Origin")
        @Validation(required = true)
        public String origin;

        @NameInMap("Access-Control-Request-Method")
        @Validation(required = true)
        public String accessControlRequestMethod;

        @NameInMap("Access-Control-Request-Headers")
        @Validation(required = true)
        public String accessControlRequestHeaders;

    }

}
