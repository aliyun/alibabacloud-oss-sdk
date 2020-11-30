// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class PutObjectTaggingRequest extends TeaModel {
    // BucketName
    @NameInMap("BucketName")
    @Validation(required = true, pattern = "[a-zA-Z0-9-_]+")
    public String bucketName;

    // ObjectName
    @NameInMap("ObjectName")
    @Validation(required = true)
    public String objectName;

    // Body
    @NameInMap("Body")
    public PutObjectTaggingRequestBody body;

    public static PutObjectTaggingRequest build(java.util.Map<String, ?> map) throws Exception {
        PutObjectTaggingRequest self = new PutObjectTaggingRequest();
        return TeaModel.build(map, self);
    }

    public PutObjectTaggingRequest setBucketName(String bucketName) {
        this.bucketName = bucketName;
        return this;
    }
    public String getBucketName() {
        return this.bucketName;
    }

    public PutObjectTaggingRequest setObjectName(String objectName) {
        this.objectName = objectName;
        return this;
    }
    public String getObjectName() {
        return this.objectName;
    }

    public PutObjectTaggingRequest setBody(PutObjectTaggingRequestBody body) {
        this.body = body;
        return this;
    }
    public PutObjectTaggingRequestBody getBody() {
        return this.body;
    }

    public static class PutObjectTaggingRequestBodyTaggingTagSetTag extends TeaModel {
        // Key
        @NameInMap("Key")
        public String key;

        // Value
        @NameInMap("Value")
        public String value;

        public static PutObjectTaggingRequestBodyTaggingTagSetTag build(java.util.Map<String, ?> map) throws Exception {
            PutObjectTaggingRequestBodyTaggingTagSetTag self = new PutObjectTaggingRequestBodyTaggingTagSetTag();
            return TeaModel.build(map, self);
        }

        public PutObjectTaggingRequestBodyTaggingTagSetTag setKey(String key) {
            this.key = key;
            return this;
        }
        public String getKey() {
            return this.key;
        }

        public PutObjectTaggingRequestBodyTaggingTagSetTag setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

    public static class PutObjectTaggingRequestBodyTaggingTagSet extends TeaModel {
        // Tag
        @NameInMap("Tag")
        public java.util.List<PutObjectTaggingRequestBodyTaggingTagSetTag> tag;

        public static PutObjectTaggingRequestBodyTaggingTagSet build(java.util.Map<String, ?> map) throws Exception {
            PutObjectTaggingRequestBodyTaggingTagSet self = new PutObjectTaggingRequestBodyTaggingTagSet();
            return TeaModel.build(map, self);
        }

        public PutObjectTaggingRequestBodyTaggingTagSet setTag(java.util.List<PutObjectTaggingRequestBodyTaggingTagSetTag> tag) {
            this.tag = tag;
            return this;
        }
        public java.util.List<PutObjectTaggingRequestBodyTaggingTagSetTag> getTag() {
            return this.tag;
        }

    }

    public static class PutObjectTaggingRequestBodyTagging extends TeaModel {
        // TagSet
        @NameInMap("TagSet")
        public PutObjectTaggingRequestBodyTaggingTagSet tagSet;

        public static PutObjectTaggingRequestBodyTagging build(java.util.Map<String, ?> map) throws Exception {
            PutObjectTaggingRequestBodyTagging self = new PutObjectTaggingRequestBodyTagging();
            return TeaModel.build(map, self);
        }

        public PutObjectTaggingRequestBodyTagging setTagSet(PutObjectTaggingRequestBodyTaggingTagSet tagSet) {
            this.tagSet = tagSet;
            return this;
        }
        public PutObjectTaggingRequestBodyTaggingTagSet getTagSet() {
            return this.tagSet;
        }

    }

    public static class PutObjectTaggingRequestBody extends TeaModel {
        // Tagging
        @NameInMap("Tagging")
        @Validation(required = true)
        public PutObjectTaggingRequestBodyTagging tagging;

        public static PutObjectTaggingRequestBody build(java.util.Map<String, ?> map) throws Exception {
            PutObjectTaggingRequestBody self = new PutObjectTaggingRequestBody();
            return TeaModel.build(map, self);
        }

        public PutObjectTaggingRequestBody setTagging(PutObjectTaggingRequestBodyTagging tagging) {
            this.tagging = tagging;
            return this;
        }
        public PutObjectTaggingRequestBodyTagging getTagging() {
            return this.tagging;
        }

    }

}
