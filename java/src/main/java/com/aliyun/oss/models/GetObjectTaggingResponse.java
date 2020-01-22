// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class GetObjectTaggingResponse extends TeaModel {
    @NameInMap("x-oss-request-id")
    @Validation(required = true)
    public String requestId;

    @NameInMap("Tagging")
    @Validation(required = true)
    public GetObjectTaggingResponseTagging tagging;

    public static GetObjectTaggingResponse build(java.util.Map<String, ?> map) throws Exception {
        GetObjectTaggingResponse self = new GetObjectTaggingResponse();
        return TeaModel.build(map, self);
    }

    public static class GetObjectTaggingResponseTaggingTagSetTag extends TeaModel {
        @NameInMap("Key")
        public String key;

        @NameInMap("Value")
        public String value;

        public static GetObjectTaggingResponseTaggingTagSetTag build(java.util.Map<String, ?> map) throws Exception {
            GetObjectTaggingResponseTaggingTagSetTag self = new GetObjectTaggingResponseTaggingTagSetTag();
            return TeaModel.build(map, self);
        }

    }

    public static class GetObjectTaggingResponseTaggingTagSet extends TeaModel {
        @NameInMap("Tag")
        public GetObjectTaggingResponseTaggingTagSetTag[] tag;

        public static GetObjectTaggingResponseTaggingTagSet build(java.util.Map<String, ?> map) throws Exception {
            GetObjectTaggingResponseTaggingTagSet self = new GetObjectTaggingResponseTaggingTagSet();
            return TeaModel.build(map, self);
        }

    }

    public static class GetObjectTaggingResponseTagging extends TeaModel {
        @NameInMap("TagSet")
        @Validation(required = true)
        public GetObjectTaggingResponseTaggingTagSet tagSet;

        public static GetObjectTaggingResponseTagging build(java.util.Map<String, ?> map) throws Exception {
            GetObjectTaggingResponseTagging self = new GetObjectTaggingResponseTagging();
            return TeaModel.build(map, self);
        }

    }

}
