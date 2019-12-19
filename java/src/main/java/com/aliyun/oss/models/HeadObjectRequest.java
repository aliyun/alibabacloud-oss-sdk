// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class HeadObjectRequest extends TeaModel {
    @NameInMap("BucketName")
    @Validation(required = true)
    public String bucketName;

    @NameInMap("ObjectName")
    @Validation(required = true)
    public String objectName;

    @NameInMap("Header")
    public HeadObjectRequestHeader header;

    public static class HeadObjectRequestHeader extends TeaModel {
        @NameInMap("If-Modified-Since")
        public String ifModifiedSince;

        @NameInMap("If-Unmodified-Since")
        public String ifUnmodifiedSince;

        @NameInMap("If-Match")
        public String ifMatch;

        @NameInMap("If-None-Match")
        public String ifNoneMatch;

    }

}
