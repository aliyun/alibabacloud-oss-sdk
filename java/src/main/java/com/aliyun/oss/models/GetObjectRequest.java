// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class GetObjectRequest extends TeaModel {
    @NameInMap("BucketName")
    @Validation(required = true)
    public String bucketName;

    @NameInMap("ObjectName")
    @Validation(required = true)
    public String objectName;

    @NameInMap("Header")
    public GetObjectRequestHeader header;

    public static GetObjectRequest build(java.util.Map<String, ?> map) throws Exception {
        GetObjectRequest self = new GetObjectRequest();
        return TeaModel.build(map, self);
    }

    public static class GetObjectRequestHeader extends TeaModel {
        @NameInMap("response-content-type")
        public String responseContentType;

        @NameInMap("response-content-language")
        public String responseContentLanguage;

        @NameInMap("response-expires")
        public String responseExpires;

        @NameInMap("response-cache-control")
        public String responseCacheControl;

        @NameInMap("response-content-disposition")
        public String responseContentDisposition;

        @NameInMap("response-content-encoding")
        public String responseContentEncoding;

        @NameInMap("Range")
        public String range;

        @NameInMap("If-Modified-Since")
        public String ifModifiedSince;

        @NameInMap("If-Unmodified-Since")
        public String ifUnmodifiedSince;

        @NameInMap("If-Match")
        public String ifMatch;

        @NameInMap("If-None-Match")
        public String ifNoneMatch;

        @NameInMap("Accept-Encoding")
        public String acceptEncoding;

        public static GetObjectRequestHeader build(java.util.Map<String, ?> map) throws Exception {
            GetObjectRequestHeader self = new GetObjectRequestHeader();
            return TeaModel.build(map, self);
        }

    }

}
