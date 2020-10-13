// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class ListMultipartUploadsRequest extends TeaModel {
    // BucketName
    @NameInMap("BucketName")
    @Validation(required = true, pattern = "[a-zA-Z0-9\\-\\_]+")
    public String bucketName;

    // Filter
    @NameInMap("Filter")
    public ListMultipartUploadsRequestFilter filter;

    public static ListMultipartUploadsRequest build(java.util.Map<String, ?> map) throws Exception {
        ListMultipartUploadsRequest self = new ListMultipartUploadsRequest();
        return TeaModel.build(map, self);
    }

    public ListMultipartUploadsRequest setBucketName(String bucketName) {
        this.bucketName = bucketName;
        return this;
    }
    public String getBucketName() {
        return this.bucketName;
    }

    public ListMultipartUploadsRequest setFilter(ListMultipartUploadsRequestFilter filter) {
        this.filter = filter;
        return this;
    }
    public ListMultipartUploadsRequestFilter getFilter() {
        return this.filter;
    }

    public static class ListMultipartUploadsRequestFilter extends TeaModel {
        // delimiter
        @NameInMap("delimiter")
        public String delimiter;

        // max-uploads
        @NameInMap("max-uploads")
        public String maxUploads;

        // key-marker
        @NameInMap("key-marker")
        public String keyMarker;

        // prefix
        @NameInMap("prefix")
        public String prefix;

        // upload-id-marker
        @NameInMap("upload-id-marker")
        public String uploadIdMarker;

        // encoding-type
        @NameInMap("encoding-type")
        public String encodingType;

        public static ListMultipartUploadsRequestFilter build(java.util.Map<String, ?> map) throws Exception {
            ListMultipartUploadsRequestFilter self = new ListMultipartUploadsRequestFilter();
            return TeaModel.build(map, self);
        }

        public ListMultipartUploadsRequestFilter setDelimiter(String delimiter) {
            this.delimiter = delimiter;
            return this;
        }
        public String getDelimiter() {
            return this.delimiter;
        }

        public ListMultipartUploadsRequestFilter setMaxUploads(String maxUploads) {
            this.maxUploads = maxUploads;
            return this;
        }
        public String getMaxUploads() {
            return this.maxUploads;
        }

        public ListMultipartUploadsRequestFilter setKeyMarker(String keyMarker) {
            this.keyMarker = keyMarker;
            return this;
        }
        public String getKeyMarker() {
            return this.keyMarker;
        }

        public ListMultipartUploadsRequestFilter setPrefix(String prefix) {
            this.prefix = prefix;
            return this;
        }
        public String getPrefix() {
            return this.prefix;
        }

        public ListMultipartUploadsRequestFilter setUploadIdMarker(String uploadIdMarker) {
            this.uploadIdMarker = uploadIdMarker;
            return this;
        }
        public String getUploadIdMarker() {
            return this.uploadIdMarker;
        }

        public ListMultipartUploadsRequestFilter setEncodingType(String encodingType) {
            this.encodingType = encodingType;
            return this;
        }
        public String getEncodingType() {
            return this.encodingType;
        }

    }

}
