// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class DeleteBucketTagsRequest extends TeaModel {
    @NameInMap("BucketName")
    @Validation(required = true)
    public String bucketName;

    @NameInMap("Filter")
    @Validation(required = true)
    public DeleteBucketTagsRequestFilter filter;

    public static DeleteBucketTagsRequest build(java.util.Map<String, ?> map) throws Exception {
        DeleteBucketTagsRequest self = new DeleteBucketTagsRequest();
        return TeaModel.build(map, self);
    }

    public static class DeleteBucketTagsRequestFilter extends TeaModel {
        @NameInMap("tagging")
        @Validation(required = true)
        public String tagging;

        public static DeleteBucketTagsRequestFilter build(java.util.Map<String, ?> map) throws Exception {
            DeleteBucketTagsRequestFilter self = new DeleteBucketTagsRequestFilter();
            return TeaModel.build(map, self);
        }

    }

}
