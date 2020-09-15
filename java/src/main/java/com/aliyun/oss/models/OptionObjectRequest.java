// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class OptionObjectRequest extends TeaModel {
    // BucketName
    @NameInMap("BucketName")
    @Validation(required = true)
    public String bucketName;

    // ObjectName
    @NameInMap("ObjectName")
    @Validation(required = true)
    public String objectName;

    // Header
    @NameInMap("Header")
    @Validation(required = true)
    public OptionObjectRequestHeader header;

    public static OptionObjectRequest build(java.util.Map<String, ?> map) {
        OptionObjectRequest self = new OptionObjectRequest();
        return TeaModel.build(map, self);
    }

    public OptionObjectRequest setBucketName(String bucketName) {
        this.bucketName = bucketName;
        return this;
    }
    public String getBucketName() {
        return this.bucketName;
    }

    public OptionObjectRequest setObjectName(String objectName) {
        this.objectName = objectName;
        return this;
    }
    public String getObjectName() {
        return this.objectName;
    }

    public OptionObjectRequest setHeader(OptionObjectRequestHeader header) {
        this.header = header;
        return this;
    }
    public OptionObjectRequestHeader getHeader() {
        return this.header;
    }

    public static class OptionObjectRequestHeader extends TeaModel {
        // Origin
        @NameInMap("Origin")
        @Validation(required = true)
        public String origin;

        // Access-Control-Request-Method
        @NameInMap("Access-Control-Request-Method")
        @Validation(required = true)
        public String accessControlRequestMethod;

        // Access-Control-Request-Headers
        @NameInMap("Access-Control-Request-Headers")
        @Validation(required = true)
        public String accessControlRequestHeaders;

        public static OptionObjectRequestHeader build(java.util.Map<String, ?> map) {
            OptionObjectRequestHeader self = new OptionObjectRequestHeader();
            return TeaModel.build(map, self);
        }

        public OptionObjectRequestHeader setOrigin(String origin) {
            this.origin = origin;
            return this;
        }
        public String getOrigin() {
            return this.origin;
        }

        public OptionObjectRequestHeader setAccessControlRequestMethod(String accessControlRequestMethod) {
            this.accessControlRequestMethod = accessControlRequestMethod;
            return this;
        }
        public String getAccessControlRequestMethod() {
            return this.accessControlRequestMethod;
        }

        public OptionObjectRequestHeader setAccessControlRequestHeaders(String accessControlRequestHeaders) {
            this.accessControlRequestHeaders = accessControlRequestHeaders;
            return this;
        }
        public String getAccessControlRequestHeaders() {
            return this.accessControlRequestHeaders;
        }

    }

}
