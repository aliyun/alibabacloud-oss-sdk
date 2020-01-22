// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class GetBucketTagsResponse extends TeaModel {
    @NameInMap("x-oss-request-id")
    @Validation(required = true)
    public String requestId;

    @NameInMap("Tagging")
    @Validation(required = true)
    public GetBucketTagsResponseTagging tagging;

    public static GetBucketTagsResponse build(java.util.Map<String, ?> map) throws Exception {
        GetBucketTagsResponse self = new GetBucketTagsResponse();
        return TeaModel.build(map, self);
    }

    public static class GetBucketTagsResponseTaggingTagSetTag extends TeaModel {
        @NameInMap("Key")
        public String key;

        @NameInMap("Value")
        public String value;

        public static GetBucketTagsResponseTaggingTagSetTag build(java.util.Map<String, ?> map) throws Exception {
            GetBucketTagsResponseTaggingTagSetTag self = new GetBucketTagsResponseTaggingTagSetTag();
            return TeaModel.build(map, self);
        }

    }

    public static class GetBucketTagsResponseTaggingTagSet extends TeaModel {
        @NameInMap("Tag")
        public GetBucketTagsResponseTaggingTagSetTag[] tag;

        public static GetBucketTagsResponseTaggingTagSet build(java.util.Map<String, ?> map) throws Exception {
            GetBucketTagsResponseTaggingTagSet self = new GetBucketTagsResponseTaggingTagSet();
            return TeaModel.build(map, self);
        }

    }

    public static class GetBucketTagsResponseTagging extends TeaModel {
        @NameInMap("TagSet")
        @Validation(required = true)
        public GetBucketTagsResponseTaggingTagSet tagSet;

        public static GetBucketTagsResponseTagging build(java.util.Map<String, ?> map) throws Exception {
            GetBucketTagsResponseTagging self = new GetBucketTagsResponseTagging();
            return TeaModel.build(map, self);
        }

    }

}
