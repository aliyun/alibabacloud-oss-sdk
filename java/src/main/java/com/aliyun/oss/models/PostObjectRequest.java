// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class PostObjectRequest extends TeaModel {
    // BucketName
    @NameInMap("BucketName")
    @Validation(required = true, pattern = "[a-zA-Z0-9\\-\\_]+")
    public String bucketName;

    // header
    @NameInMap("header")
    @Validation(required = true)
    public PostObjectRequestHeader header;

    public static PostObjectRequest build(java.util.Map<String, ?> map) throws Exception {
        PostObjectRequest self = new PostObjectRequest();
        return TeaModel.build(map, self);
    }

    public PostObjectRequest setBucketName(String bucketName) {
        this.bucketName = bucketName;
        return this;
    }
    public String getBucketName() {
        return this.bucketName;
    }

    public PostObjectRequest setHeader(PostObjectRequestHeader header) {
        this.header = header;
        return this;
    }
    public PostObjectRequestHeader getHeader() {
        return this.header;
    }

    public static class PostObjectRequestHeader extends TeaModel {
        // OSSAccessKeyId
        @NameInMap("OSSAccessKeyId")
        @Validation(required = true)
        public String accessKeyId;

        // policy
        @NameInMap("policy")
        @Validation(required = true)
        public String policy;

        // Signature
        @NameInMap("Signature")
        @Validation(required = true)
        public String signature;

        // success_action_status
        @NameInMap("success_action_status")
        public String successActionStatus;

        @NameInMap("file")
        @Validation(required = true)
        public com.aliyun.fileform.models.FileField file;

        // key
        @NameInMap("key")
        @Validation(required = true)
        public String key;

        // UserMeta
        @NameInMap("UserMeta")
        public java.util.Map<String, String> userMeta;

        public static PostObjectRequestHeader build(java.util.Map<String, ?> map) throws Exception {
            PostObjectRequestHeader self = new PostObjectRequestHeader();
            return TeaModel.build(map, self);
        }

        public PostObjectRequestHeader setAccessKeyId(String accessKeyId) {
            this.accessKeyId = accessKeyId;
            return this;
        }
        public String getAccessKeyId() {
            return this.accessKeyId;
        }

        public PostObjectRequestHeader setPolicy(String policy) {
            this.policy = policy;
            return this;
        }
        public String getPolicy() {
            return this.policy;
        }

        public PostObjectRequestHeader setSignature(String signature) {
            this.signature = signature;
            return this;
        }
        public String getSignature() {
            return this.signature;
        }

        public PostObjectRequestHeader setSuccessActionStatus(String successActionStatus) {
            this.successActionStatus = successActionStatus;
            return this;
        }
        public String getSuccessActionStatus() {
            return this.successActionStatus;
        }

        public PostObjectRequestHeader setFile(com.aliyun.fileform.models.FileField file) {
            this.file = file;
            return this;
        }
        public com.aliyun.fileform.models.FileField getFile() {
            return this.file;
        }

        public PostObjectRequestHeader setKey(String key) {
            this.key = key;
            return this;
        }
        public String getKey() {
            return this.key;
        }

        public PostObjectRequestHeader setUserMeta(java.util.Map<String, String> userMeta) {
            this.userMeta = userMeta;
            return this;
        }
        public java.util.Map<String, String> getUserMeta() {
            return this.userMeta;
        }

    }

}
