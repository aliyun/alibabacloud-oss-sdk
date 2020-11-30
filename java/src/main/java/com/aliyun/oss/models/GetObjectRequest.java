// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class GetObjectRequest extends TeaModel {
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
    public GetObjectRequestHeader header;

    public static GetObjectRequest build(java.util.Map<String, ?> map) throws Exception {
        GetObjectRequest self = new GetObjectRequest();
        return TeaModel.build(map, self);
    }

    public GetObjectRequest setBucketName(String bucketName) {
        this.bucketName = bucketName;
        return this;
    }
    public String getBucketName() {
        return this.bucketName;
    }

    public GetObjectRequest setObjectName(String objectName) {
        this.objectName = objectName;
        return this;
    }
    public String getObjectName() {
        return this.objectName;
    }

    public GetObjectRequest setHeader(GetObjectRequestHeader header) {
        this.header = header;
        return this;
    }
    public GetObjectRequestHeader getHeader() {
        return this.header;
    }

    public static class GetObjectRequestHeader extends TeaModel {
        // response-content-type
        @NameInMap("response-content-type")
        public String responseContentType;

        // response-content-language
        @NameInMap("response-content-language")
        public String responseContentLanguage;

        // response-expires
        @NameInMap("response-expires")
        public String responseExpires;

        // response-cache-control
        @NameInMap("response-cache-control")
        public String responseCacheControl;

        // response-content-disposition
        @NameInMap("response-content-disposition")
        public String responseContentDisposition;

        // response-content-encoding
        @NameInMap("response-content-encoding")
        public String responseContentEncoding;

        // Range
        @NameInMap("Range")
        public String range;

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

        // Accept-Encoding
        @NameInMap("Accept-Encoding")
        public String acceptEncoding;

        public static GetObjectRequestHeader build(java.util.Map<String, ?> map) throws Exception {
            GetObjectRequestHeader self = new GetObjectRequestHeader();
            return TeaModel.build(map, self);
        }

        public GetObjectRequestHeader setResponseContentType(String responseContentType) {
            this.responseContentType = responseContentType;
            return this;
        }
        public String getResponseContentType() {
            return this.responseContentType;
        }

        public GetObjectRequestHeader setResponseContentLanguage(String responseContentLanguage) {
            this.responseContentLanguage = responseContentLanguage;
            return this;
        }
        public String getResponseContentLanguage() {
            return this.responseContentLanguage;
        }

        public GetObjectRequestHeader setResponseExpires(String responseExpires) {
            this.responseExpires = responseExpires;
            return this;
        }
        public String getResponseExpires() {
            return this.responseExpires;
        }

        public GetObjectRequestHeader setResponseCacheControl(String responseCacheControl) {
            this.responseCacheControl = responseCacheControl;
            return this;
        }
        public String getResponseCacheControl() {
            return this.responseCacheControl;
        }

        public GetObjectRequestHeader setResponseContentDisposition(String responseContentDisposition) {
            this.responseContentDisposition = responseContentDisposition;
            return this;
        }
        public String getResponseContentDisposition() {
            return this.responseContentDisposition;
        }

        public GetObjectRequestHeader setResponseContentEncoding(String responseContentEncoding) {
            this.responseContentEncoding = responseContentEncoding;
            return this;
        }
        public String getResponseContentEncoding() {
            return this.responseContentEncoding;
        }

        public GetObjectRequestHeader setRange(String range) {
            this.range = range;
            return this;
        }
        public String getRange() {
            return this.range;
        }

        public GetObjectRequestHeader setIfModifiedSince(String ifModifiedSince) {
            this.ifModifiedSince = ifModifiedSince;
            return this;
        }
        public String getIfModifiedSince() {
            return this.ifModifiedSince;
        }

        public GetObjectRequestHeader setIfUnmodifiedSince(String ifUnmodifiedSince) {
            this.ifUnmodifiedSince = ifUnmodifiedSince;
            return this;
        }
        public String getIfUnmodifiedSince() {
            return this.ifUnmodifiedSince;
        }

        public GetObjectRequestHeader setIfMatch(String ifMatch) {
            this.ifMatch = ifMatch;
            return this;
        }
        public String getIfMatch() {
            return this.ifMatch;
        }

        public GetObjectRequestHeader setIfNoneMatch(String ifNoneMatch) {
            this.ifNoneMatch = ifNoneMatch;
            return this;
        }
        public String getIfNoneMatch() {
            return this.ifNoneMatch;
        }

        public GetObjectRequestHeader setAcceptEncoding(String acceptEncoding) {
            this.acceptEncoding = acceptEncoding;
            return this;
        }
        public String getAcceptEncoding() {
            return this.acceptEncoding;
        }

    }

}
