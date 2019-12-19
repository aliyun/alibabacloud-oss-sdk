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

    public static class PutObjectTaggingRequestBodyTaggingTagSetTag extends TeaModel {
        @NameInMap("Key")
        public String key;

        @NameInMap("Value")
        public String value;

    }

    public static class PutObjectTaggingRequestBodyTaggingTagSet extends TeaModel {
        @NameInMap("Tag")
        public PutObjectTaggingRequestBodyTaggingTagSetTag[] tag;

    }

    public static class PutObjectTaggingRequestBodyTagging extends TeaModel {
        @NameInMap("TagSet")
        public PutObjectTaggingRequestBodyTaggingTagSet tagSet;

    }

    public static class PutObjectTaggingRequestBody extends TeaModel {
        @NameInMap("Tagging")
        @Validation(required = true)
        public PutObjectTaggingRequestBodyTagging tagging;

    }

}
