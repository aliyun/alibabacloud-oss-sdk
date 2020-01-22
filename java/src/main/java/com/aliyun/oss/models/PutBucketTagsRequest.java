// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class PutBucketTagsRequest extends TeaModel {
    @NameInMap("BucketName")
    @Validation(required = true)
    public String bucketName;

    @NameInMap("Body")
    public PutBucketTagsRequestBody body;

    public static PutBucketTagsRequest build(java.util.Map<String, ?> map) throws Exception {
        PutBucketTagsRequest self = new PutBucketTagsRequest();
        return TeaModel.build(map, self);
    }

    public static class PutBucketTagsRequestBodyTaggingTagSetTag extends TeaModel {
        @NameInMap("Key")
        public String key;

        @NameInMap("Value")
        public String value;

        public static PutBucketTagsRequestBodyTaggingTagSetTag build(java.util.Map<String, ?> map) throws Exception {
            PutBucketTagsRequestBodyTaggingTagSetTag self = new PutBucketTagsRequestBodyTaggingTagSetTag();
            return TeaModel.build(map, self);
        }

    }

    public static class PutBucketTagsRequestBodyTaggingTagSet extends TeaModel {
        @NameInMap("Tag")
        public PutBucketTagsRequestBodyTaggingTagSetTag[] tag;

        public static PutBucketTagsRequestBodyTaggingTagSet build(java.util.Map<String, ?> map) throws Exception {
            PutBucketTagsRequestBodyTaggingTagSet self = new PutBucketTagsRequestBodyTaggingTagSet();
            return TeaModel.build(map, self);
        }

    }

    public static class PutBucketTagsRequestBodyTagging extends TeaModel {
        @NameInMap("TagSet")
        public PutBucketTagsRequestBodyTaggingTagSet tagSet;

        public static PutBucketTagsRequestBodyTagging build(java.util.Map<String, ?> map) throws Exception {
            PutBucketTagsRequestBodyTagging self = new PutBucketTagsRequestBodyTagging();
            return TeaModel.build(map, self);
        }

    }

    public static class PutBucketTagsRequestBody extends TeaModel {
        @NameInMap("Tagging")
        @Validation(required = true)
        public PutBucketTagsRequestBodyTagging tagging;

        public static PutBucketTagsRequestBody build(java.util.Map<String, ?> map) throws Exception {
            PutBucketTagsRequestBody self = new PutBucketTagsRequestBody();
            return TeaModel.build(map, self);
        }

    }

}
