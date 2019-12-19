// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class PutBucketTagsRequest extends TeaModel {
    @NameInMap("BucketName")
    @Validation(required = true)
    public String bucketName;

    @NameInMap("Body")
    public PutBucketTagsRequestBody body;

    public static class PutBucketTagsRequestBodyTaggingTagSetTag extends TeaModel {
        @NameInMap("Key")
        public String key;

        @NameInMap("Value")
        public String value;

    }

    public static class PutBucketTagsRequestBodyTaggingTagSet extends TeaModel {
        @NameInMap("Tag")
        public PutBucketTagsRequestBodyTaggingTagSetTag[] tag;

    }

    public static class PutBucketTagsRequestBodyTagging extends TeaModel {
        @NameInMap("TagSet")
        public PutBucketTagsRequestBodyTaggingTagSet tagSet;

    }

    public static class PutBucketTagsRequestBody extends TeaModel {
        @NameInMap("Tagging")
        @Validation(required = true)
        public PutBucketTagsRequestBodyTagging tagging;

    }

}
