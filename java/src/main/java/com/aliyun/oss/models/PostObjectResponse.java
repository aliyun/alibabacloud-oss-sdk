// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class PostObjectResponse extends TeaModel {
    // PostResponse
    @NameInMap("PostResponse")
    @Validation(required = true)
    public PostObjectResponsePostResponse postResponse;

    public static PostObjectResponse build(java.util.Map<String, ?> map) {
        PostObjectResponse self = new PostObjectResponse();
        return TeaModel.build(map, self);
    }

    public PostObjectResponse setPostResponse(PostObjectResponsePostResponse postResponse) {
        this.postResponse = postResponse;
        return this;
    }
    public PostObjectResponsePostResponse getPostResponse() {
        return this.postResponse;
    }

    public static class PostObjectResponsePostResponse extends TeaModel {
        // Bucket
        @NameInMap("Bucket")
        @Validation(required = true)
        public String bucket;

        // ETag
        @NameInMap("ETag")
        @Validation(required = true)
        public String eTag;

        // Location
        @NameInMap("Location")
        @Validation(required = true)
        public String location;

        public static PostObjectResponsePostResponse build(java.util.Map<String, ?> map) {
            PostObjectResponsePostResponse self = new PostObjectResponsePostResponse();
            return TeaModel.build(map, self);
        }

        public PostObjectResponsePostResponse setBucket(String bucket) {
            this.bucket = bucket;
            return this;
        }
        public String getBucket() {
            return this.bucket;
        }

        public PostObjectResponsePostResponse setETag(String eTag) {
            this.eTag = eTag;
            return this;
        }
        public String getETag() {
            return this.eTag;
        }

        public PostObjectResponsePostResponse setLocation(String location) {
            this.location = location;
            return this;
        }
        public String getLocation() {
            return this.location;
        }

    }

}
