// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class AppendObjectRequest extends TeaModel {
    @NameInMap("BucketName")
    @Validation(required = true)
    public String bucketName;

    @NameInMap("ObjectName")
    @Validation(required = true)
    public String objectName;

    @NameInMap("UserMeta")
    public java.util.Map<String, String> userMeta;

    @NameInMap("body")
    public java.io.InputStream body;

    @NameInMap("Filter")
    @Validation(required = true)
    public AppendObjectRequestFilter filter;

    @NameInMap("Header")
    public AppendObjectRequestHeader header;

    public static AppendObjectRequest build(java.util.Map<String, ?> map) throws Exception {
        AppendObjectRequest self = new AppendObjectRequest();
        return TeaModel.build(map, self);
    }

    public static class AppendObjectRequestFilter extends TeaModel {
        @NameInMap("position")
        @Validation(required = true)
        public String position;

        public static AppendObjectRequestFilter build(java.util.Map<String, ?> map) throws Exception {
            AppendObjectRequestFilter self = new AppendObjectRequestFilter();
            return TeaModel.build(map, self);
        }

    }

    public static class AppendObjectRequestHeader extends TeaModel {
        @NameInMap("Cache-Control")
        public String cacheControl;

        @NameInMap("Content-Disposition")
        public String contentDisposition;

        @NameInMap("Content-Encoding")
        public String contentEncoding;

        @NameInMap("Content-MD5")
        public String contentMD5;

        @NameInMap("Expires")
        public String expires;

        @NameInMap("x-oss-server-side-encryption")
        public String serverSideEncryption;

        @NameInMap("x-oss-object-acl")
        public String objectAcl;

        @NameInMap("x-oss-storage-class")
        public String storageClass;

        @NameInMap("content-type")
        public String contentType;

        public static AppendObjectRequestHeader build(java.util.Map<String, ?> map) throws Exception {
            AppendObjectRequestHeader self = new AppendObjectRequestHeader();
            return TeaModel.build(map, self);
        }

    }

}
