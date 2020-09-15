// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class GetObjectTaggingResponse extends TeaModel {
    // x-oss-request-id
    @NameInMap("x-oss-request-id")
    @Validation(required = true)
    public String requestId;

    // Tagging
    @NameInMap("Tagging")
    @Validation(required = true)
    public GetObjectTaggingResponseTagging tagging;

    public static GetObjectTaggingResponse build(java.util.Map<String, ?> map) {
        GetObjectTaggingResponse self = new GetObjectTaggingResponse();
        return TeaModel.build(map, self);
    }

    public GetObjectTaggingResponse setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public GetObjectTaggingResponse setTagging(GetObjectTaggingResponseTagging tagging) {
        this.tagging = tagging;
        return this;
    }
    public GetObjectTaggingResponseTagging getTagging() {
        return this.tagging;
    }

    public static class GetObjectTaggingResponseTaggingTagSetTag extends TeaModel {
        // Key
        @NameInMap("Key")
        public String key;

        // Value
        @NameInMap("Value")
        public String value;

        public static GetObjectTaggingResponseTaggingTagSetTag build(java.util.Map<String, ?> map) {
            GetObjectTaggingResponseTaggingTagSetTag self = new GetObjectTaggingResponseTaggingTagSetTag();
            return TeaModel.build(map, self);
        }

        public GetObjectTaggingResponseTaggingTagSetTag setKey(String key) {
            this.key = key;
            return this;
        }
        public String getKey() {
            return this.key;
        }

        public GetObjectTaggingResponseTaggingTagSetTag setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

    public static class GetObjectTaggingResponseTaggingTagSet extends TeaModel {
        // Tag
        @NameInMap("Tag")
        public java.util.List<GetObjectTaggingResponseTaggingTagSetTag> tag;

        public static GetObjectTaggingResponseTaggingTagSet build(java.util.Map<String, ?> map) {
            GetObjectTaggingResponseTaggingTagSet self = new GetObjectTaggingResponseTaggingTagSet();
            return TeaModel.build(map, self);
        }

        public GetObjectTaggingResponseTaggingTagSet setTag(java.util.List<GetObjectTaggingResponseTaggingTagSetTag> tag) {
            this.tag = tag;
            return this;
        }
        public java.util.List<GetObjectTaggingResponseTaggingTagSetTag> getTag() {
            return this.tag;
        }

    }

    public static class GetObjectTaggingResponseTagging extends TeaModel {
        // TagSet
        @NameInMap("TagSet")
        @Validation(required = true)
        public GetObjectTaggingResponseTaggingTagSet tagSet;

        public static GetObjectTaggingResponseTagging build(java.util.Map<String, ?> map) {
            GetObjectTaggingResponseTagging self = new GetObjectTaggingResponseTagging();
            return TeaModel.build(map, self);
        }

        public GetObjectTaggingResponseTagging setTagSet(GetObjectTaggingResponseTaggingTagSet tagSet) {
            this.tagSet = tagSet;
            return this;
        }
        public GetObjectTaggingResponseTaggingTagSet getTagSet() {
            return this.tagSet;
        }

    }

}
