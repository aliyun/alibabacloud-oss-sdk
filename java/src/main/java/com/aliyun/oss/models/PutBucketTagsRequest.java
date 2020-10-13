// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class PutBucketTagsRequest extends TeaModel {
    // BucketName
    @NameInMap("BucketName")
    @Validation(required = true, pattern = "[a-zA-Z0-9\\-\\_]+")
    public String bucketName;

    // Body
    @NameInMap("Body")
    public PutBucketTagsRequestBody body;

    public static PutBucketTagsRequest build(java.util.Map<String, ?> map) throws Exception {
        PutBucketTagsRequest self = new PutBucketTagsRequest();
        return TeaModel.build(map, self);
    }

    public PutBucketTagsRequest setBucketName(String bucketName) {
        this.bucketName = bucketName;
        return this;
    }
    public String getBucketName() {
        return this.bucketName;
    }

    public PutBucketTagsRequest setBody(PutBucketTagsRequestBody body) {
        this.body = body;
        return this;
    }
    public PutBucketTagsRequestBody getBody() {
        return this.body;
    }

    public static class PutBucketTagsRequestBodyTaggingTagSetTag extends TeaModel {
        // Key
        @NameInMap("Key")
        public String key;

        // Value
        @NameInMap("Value")
        public String value;

        public static PutBucketTagsRequestBodyTaggingTagSetTag build(java.util.Map<String, ?> map) throws Exception {
            PutBucketTagsRequestBodyTaggingTagSetTag self = new PutBucketTagsRequestBodyTaggingTagSetTag();
            return TeaModel.build(map, self);
        }

        public PutBucketTagsRequestBodyTaggingTagSetTag setKey(String key) {
            this.key = key;
            return this;
        }
        public String getKey() {
            return this.key;
        }

        public PutBucketTagsRequestBodyTaggingTagSetTag setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

    public static class PutBucketTagsRequestBodyTaggingTagSet extends TeaModel {
        // Tag
        @NameInMap("Tag")
        public java.util.List<PutBucketTagsRequestBodyTaggingTagSetTag> tag;

        public static PutBucketTagsRequestBodyTaggingTagSet build(java.util.Map<String, ?> map) throws Exception {
            PutBucketTagsRequestBodyTaggingTagSet self = new PutBucketTagsRequestBodyTaggingTagSet();
            return TeaModel.build(map, self);
        }

        public PutBucketTagsRequestBodyTaggingTagSet setTag(java.util.List<PutBucketTagsRequestBodyTaggingTagSetTag> tag) {
            this.tag = tag;
            return this;
        }
        public java.util.List<PutBucketTagsRequestBodyTaggingTagSetTag> getTag() {
            return this.tag;
        }

    }

    public static class PutBucketTagsRequestBodyTagging extends TeaModel {
        // TagSet
        @NameInMap("TagSet")
        public PutBucketTagsRequestBodyTaggingTagSet tagSet;

        public static PutBucketTagsRequestBodyTagging build(java.util.Map<String, ?> map) throws Exception {
            PutBucketTagsRequestBodyTagging self = new PutBucketTagsRequestBodyTagging();
            return TeaModel.build(map, self);
        }

        public PutBucketTagsRequestBodyTagging setTagSet(PutBucketTagsRequestBodyTaggingTagSet tagSet) {
            this.tagSet = tagSet;
            return this;
        }
        public PutBucketTagsRequestBodyTaggingTagSet getTagSet() {
            return this.tagSet;
        }

    }

    public static class PutBucketTagsRequestBody extends TeaModel {
        // Tagging
        @NameInMap("Tagging")
        @Validation(required = true)
        public PutBucketTagsRequestBodyTagging tagging;

        public static PutBucketTagsRequestBody build(java.util.Map<String, ?> map) throws Exception {
            PutBucketTagsRequestBody self = new PutBucketTagsRequestBody();
            return TeaModel.build(map, self);
        }

        public PutBucketTagsRequestBody setTagging(PutBucketTagsRequestBodyTagging tagging) {
            this.tagging = tagging;
            return this;
        }
        public PutBucketTagsRequestBodyTagging getTagging() {
            return this.tagging;
        }

    }

}
