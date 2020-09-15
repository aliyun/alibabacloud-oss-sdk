// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class DeleteBucketTagsRequest extends TeaModel {
    // BucketName
    @NameInMap("BucketName")
    @Validation(required = true)
    public String bucketName;

    // Filter
    @NameInMap("Filter")
    @Validation(required = true)
    public DeleteBucketTagsRequestFilter filter;

    public static DeleteBucketTagsRequest build(java.util.Map<String, ?> map) {
        DeleteBucketTagsRequest self = new DeleteBucketTagsRequest();
        return TeaModel.build(map, self);
    }

    public DeleteBucketTagsRequest setBucketName(String bucketName) {
        this.bucketName = bucketName;
        return this;
    }
    public String getBucketName() {
        return this.bucketName;
    }

    public DeleteBucketTagsRequest setFilter(DeleteBucketTagsRequestFilter filter) {
        this.filter = filter;
        return this;
    }
    public DeleteBucketTagsRequestFilter getFilter() {
        return this.filter;
    }

    public static class DeleteBucketTagsRequestFilter extends TeaModel {
        // tagging
        @NameInMap("tagging")
        @Validation(required = true)
        public String tagging;

        public static DeleteBucketTagsRequestFilter build(java.util.Map<String, ?> map) {
            DeleteBucketTagsRequestFilter self = new DeleteBucketTagsRequestFilter();
            return TeaModel.build(map, self);
        }

        public DeleteBucketTagsRequestFilter setTagging(String tagging) {
            this.tagging = tagging;
            return this;
        }
        public String getTagging() {
            return this.tagging;
        }

    }

}
