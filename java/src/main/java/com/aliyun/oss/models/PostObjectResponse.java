// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class PostObjectResponse extends TeaModel {
    @NameInMap("PostResponse")
    @Validation(required = true)
    public PostObjectResponsePostResponse postResponse;

    public static PostObjectResponse build(java.util.Map<String, ?> map) throws Exception {
        PostObjectResponse self = new PostObjectResponse();
        return TeaModel.build(map, self);
    }

    public static class PostObjectResponsePostResponse extends TeaModel {
        @NameInMap("Bucket")
        @Validation(required = true)
        public String bucket;

        @NameInMap("ETag")
        @Validation(required = true)
        public String eTag;

        @NameInMap("Location")
        @Validation(required = true)
        public String location;

        public static PostObjectResponsePostResponse build(java.util.Map<String, ?> map) throws Exception {
            PostObjectResponsePostResponse self = new PostObjectResponsePostResponse();
            return TeaModel.build(map, self);
        }

    }

}
