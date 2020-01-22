// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class GetBucketRequest extends TeaModel {
    @NameInMap("BucketName")
    @Validation(required = true)
    public String bucketName;

    @NameInMap("Filter")
    public GetBucketRequestFilter filter;

    public static GetBucketRequest build(java.util.Map<String, ?> map) throws Exception {
        GetBucketRequest self = new GetBucketRequest();
        return TeaModel.build(map, self);
    }

    public static class GetBucketRequestFilter extends TeaModel {
        @NameInMap("delimiter")
        public String delimiter;

        @NameInMap("marker")
        public String marker;

        @NameInMap("max-keys")
        public String maxKeys;

        @NameInMap("prefix")
        public String prefix;

        @NameInMap("encoding-type")
        public String encodingType;

        public static GetBucketRequestFilter build(java.util.Map<String, ?> map) throws Exception {
            GetBucketRequestFilter self = new GetBucketRequestFilter();
            return TeaModel.build(map, self);
        }

    }

}
