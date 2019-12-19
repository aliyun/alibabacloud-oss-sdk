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

    public static class DeleteBucketTagsRequestFilter extends TeaModel {
        @NameInMap("tagging")
        @Validation(required = true)
        public String tagging;

    }

}
