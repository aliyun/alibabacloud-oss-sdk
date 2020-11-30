// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class GetBucketRequest extends TeaModel {
    // BucketName
    @NameInMap("BucketName")
    @Validation(required = true, pattern = "[a-zA-Z0-9-_]+")
    public String bucketName;

    // Filter
    @NameInMap("Filter")
    public GetBucketRequestFilter filter;

    public static GetBucketRequest build(java.util.Map<String, ?> map) throws Exception {
        GetBucketRequest self = new GetBucketRequest();
        return TeaModel.build(map, self);
    }

    public GetBucketRequest setBucketName(String bucketName) {
        this.bucketName = bucketName;
        return this;
    }
    public String getBucketName() {
        return this.bucketName;
    }

    public GetBucketRequest setFilter(GetBucketRequestFilter filter) {
        this.filter = filter;
        return this;
    }
    public GetBucketRequestFilter getFilter() {
        return this.filter;
    }

    public static class GetBucketRequestFilter extends TeaModel {
        // delimiter
        @NameInMap("delimiter")
        public String delimiter;

        // marker
        @NameInMap("marker")
        public String marker;

        // max-keys
        @NameInMap("max-keys")
        public String maxKeys;

        // prefix
        @NameInMap("prefix")
        public String prefix;

        // encoding-type
        @NameInMap("encoding-type")
        public String encodingType;

        public static GetBucketRequestFilter build(java.util.Map<String, ?> map) throws Exception {
            GetBucketRequestFilter self = new GetBucketRequestFilter();
            return TeaModel.build(map, self);
        }

        public GetBucketRequestFilter setDelimiter(String delimiter) {
            this.delimiter = delimiter;
            return this;
        }
        public String getDelimiter() {
            return this.delimiter;
        }

        public GetBucketRequestFilter setMarker(String marker) {
            this.marker = marker;
            return this;
        }
        public String getMarker() {
            return this.marker;
        }

        public GetBucketRequestFilter setMaxKeys(String maxKeys) {
            this.maxKeys = maxKeys;
            return this;
        }
        public String getMaxKeys() {
            return this.maxKeys;
        }

        public GetBucketRequestFilter setPrefix(String prefix) {
            this.prefix = prefix;
            return this;
        }
        public String getPrefix() {
            return this.prefix;
        }

        public GetBucketRequestFilter setEncodingType(String encodingType) {
            this.encodingType = encodingType;
            return this;
        }
        public String getEncodingType() {
            return this.encodingType;
        }

    }

}
