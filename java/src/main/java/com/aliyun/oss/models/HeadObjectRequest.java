// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class HeadObjectRequest extends TeaModel {
    // BucketName
    @NameInMap("BucketName")
    @Validation(required = true, pattern = "[a-zA-Z0-9-_]+")
    public String bucketName;

    // ObjectName
    @NameInMap("ObjectName")
    @Validation(required = true)
    public String objectName;

    // Header
    @NameInMap("Header")
    public HeadObjectRequestHeader header;

    public static HeadObjectRequest build(java.util.Map<String, ?> map) throws Exception {
        HeadObjectRequest self = new HeadObjectRequest();
        return TeaModel.build(map, self);
    }

    public HeadObjectRequest setBucketName(String bucketName) {
        this.bucketName = bucketName;
        return this;
    }
    public String getBucketName() {
        return this.bucketName;
    }

    public HeadObjectRequest setObjectName(String objectName) {
        this.objectName = objectName;
        return this;
    }
    public String getObjectName() {
        return this.objectName;
    }

    public HeadObjectRequest setHeader(HeadObjectRequestHeader header) {
        this.header = header;
        return this;
    }
    public HeadObjectRequestHeader getHeader() {
        return this.header;
    }

    public static class HeadObjectRequestHeader extends TeaModel {
        // If-Modified-Since
        @NameInMap("If-Modified-Since")
        public String ifModifiedSince;

        // If-Unmodified-Since
        @NameInMap("If-Unmodified-Since")
        public String ifUnmodifiedSince;

        // If-Match
        @NameInMap("If-Match")
        public String ifMatch;

        // If-None-Match
        @NameInMap("If-None-Match")
        public String ifNoneMatch;

        public static HeadObjectRequestHeader build(java.util.Map<String, ?> map) throws Exception {
            HeadObjectRequestHeader self = new HeadObjectRequestHeader();
            return TeaModel.build(map, self);
        }

        public HeadObjectRequestHeader setIfModifiedSince(String ifModifiedSince) {
            this.ifModifiedSince = ifModifiedSince;
            return this;
        }
        public String getIfModifiedSince() {
            return this.ifModifiedSince;
        }

        public HeadObjectRequestHeader setIfUnmodifiedSince(String ifUnmodifiedSince) {
            this.ifUnmodifiedSince = ifUnmodifiedSince;
            return this;
        }
        public String getIfUnmodifiedSince() {
            return this.ifUnmodifiedSince;
        }

        public HeadObjectRequestHeader setIfMatch(String ifMatch) {
            this.ifMatch = ifMatch;
            return this;
        }
        public String getIfMatch() {
            return this.ifMatch;
        }

        public HeadObjectRequestHeader setIfNoneMatch(String ifNoneMatch) {
            this.ifNoneMatch = ifNoneMatch;
            return this;
        }
        public String getIfNoneMatch() {
            return this.ifNoneMatch;
        }

    }

}
