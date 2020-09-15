// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class GetBucketTagsResponse extends TeaModel {
    // x-oss-request-id
    @NameInMap("x-oss-request-id")
    @Validation(required = true)
    public String requestId;

    // Tagging
    @NameInMap("Tagging")
    @Validation(required = true)
    public GetBucketTagsResponseTagging tagging;

    public static GetBucketTagsResponse build(java.util.Map<String, ?> map) {
        GetBucketTagsResponse self = new GetBucketTagsResponse();
        return TeaModel.build(map, self);
    }

    public GetBucketTagsResponse setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public GetBucketTagsResponse setTagging(GetBucketTagsResponseTagging tagging) {
        this.tagging = tagging;
        return this;
    }
    public GetBucketTagsResponseTagging getTagging() {
        return this.tagging;
    }

    public static class GetBucketTagsResponseTaggingTagSetTag extends TeaModel {
        // Key
        @NameInMap("Key")
        public String key;

        // Value
        @NameInMap("Value")
        public String value;

        public static GetBucketTagsResponseTaggingTagSetTag build(java.util.Map<String, ?> map) {
            GetBucketTagsResponseTaggingTagSetTag self = new GetBucketTagsResponseTaggingTagSetTag();
            return TeaModel.build(map, self);
        }

        public GetBucketTagsResponseTaggingTagSetTag setKey(String key) {
            this.key = key;
            return this;
        }
        public String getKey() {
            return this.key;
        }

        public GetBucketTagsResponseTaggingTagSetTag setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

    public static class GetBucketTagsResponseTaggingTagSet extends TeaModel {
        // Tag
        @NameInMap("Tag")
        public java.util.List<GetBucketTagsResponseTaggingTagSetTag> tag;

        public static GetBucketTagsResponseTaggingTagSet build(java.util.Map<String, ?> map) {
            GetBucketTagsResponseTaggingTagSet self = new GetBucketTagsResponseTaggingTagSet();
            return TeaModel.build(map, self);
        }

        public GetBucketTagsResponseTaggingTagSet setTag(java.util.List<GetBucketTagsResponseTaggingTagSetTag> tag) {
            this.tag = tag;
            return this;
        }
        public java.util.List<GetBucketTagsResponseTaggingTagSetTag> getTag() {
            return this.tag;
        }

    }

    public static class GetBucketTagsResponseTagging extends TeaModel {
        // TagSet
        @NameInMap("TagSet")
        @Validation(required = true)
        public GetBucketTagsResponseTaggingTagSet tagSet;

        public static GetBucketTagsResponseTagging build(java.util.Map<String, ?> map) {
            GetBucketTagsResponseTagging self = new GetBucketTagsResponseTagging();
            return TeaModel.build(map, self);
        }

        public GetBucketTagsResponseTagging setTagSet(GetBucketTagsResponseTaggingTagSet tagSet) {
            this.tagSet = tagSet;
            return this;
        }
        public GetBucketTagsResponseTaggingTagSet getTagSet() {
            return this.tagSet;
        }

    }

}
