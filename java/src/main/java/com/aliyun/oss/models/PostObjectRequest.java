// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class PostObjectRequest extends TeaModel {
    @NameInMap("BucketName")
    @Validation(required = true)
    public String bucketName;

    @NameInMap("header")
    @Validation(required = true)
    public PostObjectRequestHeader header;

    public static PostObjectRequest build(java.util.Map<String, ?> map) throws Exception {
        PostObjectRequest self = new PostObjectRequest();
        return TeaModel.build(map, self);
    }

    public static class PostObjectRequestHeaderFile extends TeaModel {
        @NameInMap("filename")
        @Validation(required = true)
        public String fileName;

        @NameInMap("content")
        @Validation(required = true)
        public java.io.InputStream content;

        @NameInMap("content-type")
        @Validation(required = true)
        public String contentType;

        public static PostObjectRequestHeaderFile build(java.util.Map<String, ?> map) throws Exception {
            PostObjectRequestHeaderFile self = new PostObjectRequestHeaderFile();
            return TeaModel.build(map, self);
        }

    }

    public static class PostObjectRequestHeader extends TeaModel {
        @NameInMap("OSSAccessKeyId")
        @Validation(required = true)
        public String accessKeyId;

        @NameInMap("policy")
        @Validation(required = true)
        public String policy;

        @NameInMap("Signature")
        @Validation(required = true)
        public String signature;

        @NameInMap("success_action_status")
        public String successActionStatus;

        @NameInMap("file")
        @Validation(required = true)
        public PostObjectRequestHeaderFile file;

        @NameInMap("key")
        @Validation(required = true)
        public String key;

        public static PostObjectRequestHeader build(java.util.Map<String, ?> map) throws Exception {
            PostObjectRequestHeader self = new PostObjectRequestHeader();
            return TeaModel.build(map, self);
        }

    }

}
