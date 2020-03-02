// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class PutObjectTaggingRequest extends TeaModel {
    @NameInMap("BucketName")
    @Validation(required = true)
    public String bucketName;

    @NameInMap("ObjectName")
    @Validation(required = true)
    public String objectName;

    @NameInMap("Body")
    public PutObjectTaggingRequestBody body;

    public static PutObjectTaggingRequest build(java.util.Map<String, ?> map) throws Exception {
        PutObjectTaggingRequest self = new PutObjectTaggingRequest();
        return TeaModel.build(map, self);
    }

    public static class PutObjectTaggingRequestBodyTaggingTagSetTag extends TeaModel {
        @NameInMap("Key")
        public String key;

        @NameInMap("Value")
        public String value;

        public static PutObjectTaggingRequestBodyTaggingTagSetTag build(java.util.Map<String, ?> map) throws Exception {
            PutObjectTaggingRequestBodyTaggingTagSetTag self = new PutObjectTaggingRequestBodyTaggingTagSetTag();
            return TeaModel.build(map, self);
        }

    }

    public static class PutObjectTaggingRequestBodyTaggingTagSet extends TeaModel {
        @NameInMap("Tag")
        public java.util.List<PutObjectTaggingRequestBodyTaggingTagSetTag> tag;

        public static PutObjectTaggingRequestBodyTaggingTagSet build(java.util.Map<String, ?> map) throws Exception {
            PutObjectTaggingRequestBodyTaggingTagSet self = new PutObjectTaggingRequestBodyTaggingTagSet();
            return TeaModel.build(map, self);
        }

    }

    public static class PutObjectTaggingRequestBodyTagging extends TeaModel {
        @NameInMap("TagSet")
        public PutObjectTaggingRequestBodyTaggingTagSet tagSet;

        public static PutObjectTaggingRequestBodyTagging build(java.util.Map<String, ?> map) throws Exception {
            PutObjectTaggingRequestBodyTagging self = new PutObjectTaggingRequestBodyTagging();
            return TeaModel.build(map, self);
        }

    }

    public static class PutObjectTaggingRequestBody extends TeaModel {
        @NameInMap("Tagging")
        @Validation(required = true)
        public PutObjectTaggingRequestBodyTagging tagging;

        public static PutObjectTaggingRequestBody build(java.util.Map<String, ?> map) throws Exception {
            PutObjectTaggingRequestBody self = new PutObjectTaggingRequestBody();
            return TeaModel.build(map, self);
        }

    }

}
