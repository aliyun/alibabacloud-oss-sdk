// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class PutObjectRequest extends TeaModel {
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

    @NameInMap("Header")
    public PutObjectRequestHeader header;

    public static class PutObjectRequestHeader extends TeaModel {
        @NameInMap("Authorization")
        public String authorization;

        @NameInMap("Cache-Control")
        public String cacheControl;

        @NameInMap("Content-Disposition")
        public String contentDisposition;

        @NameInMap("Content-Encoding")
        public String contentEncoding;

        @NameInMap("Content-MD5")
        public String contentMD5;

        @NameInMap("Content-Length")
        public String contentLength;

        @NameInMap("CETag")
        public String eTag;

        @NameInMap("Expires")
        public String expires;

        @NameInMap("x-oss-server-side-encryption")
        public String serverSideEncryption;

        @NameInMap("x-oss-server-side-encryption-key-id")
        public String serverSideEncryptionKeyId;

        @NameInMap("x-oss-object-acl")
        public String objectAcl;

        @NameInMap("x-oss-storage-class")
        public String storageClass;

        @NameInMap("x-oss-tagging")
        public String tagging;

        @NameInMap("content-type")
        public String contentType;

    }

}
