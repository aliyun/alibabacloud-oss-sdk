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

    public static OptionObjectRequest build(java.util.Map<String, ?> map) throws Exception {
        OptionObjectRequest self = new OptionObjectRequest();
        return TeaModel.build(map, self);
    }

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

        public static OptionObjectRequestHeader build(java.util.Map<String, ?> map) throws Exception {
            OptionObjectRequestHeader self = new OptionObjectRequestHeader();
            return TeaModel.build(map, self);
        }

    }

}
