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

    public static class GetBucketTagsResponseTaggingTagSetTag extends TeaModel {
        @NameInMap("Key")
        public String key;

        @NameInMap("Value")
        public String value;

    }

    public static class GetBucketTagsResponseTaggingTagSet extends TeaModel {
        @NameInMap("Tag")
        public GetBucketTagsResponseTaggingTagSetTag[] tag;

    }

    public static class GetBucketTagsResponseTagging extends TeaModel {
        @NameInMap("TagSet")
        @Validation(required = true)
        public GetBucketTagsResponseTaggingTagSet tagSet;

    }

}
