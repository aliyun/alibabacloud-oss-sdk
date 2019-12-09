// This file is auto-generated, don't edit it. Thanks.
package com.oss.models;

import com.aliyun.tea.*;

public class UploadPartCopyRequest extends TeaModel {
    @NameInMap("BucketName")
    @Validation(required = true)
    public String bucketName;

    @NameInMap("ObjectName")
    @Validation(required = true)
    public String objectName;

    @NameInMap("Filter")
    @Validation(required = true)
    public UploadPartCopyRequestFilter filter;

    @NameInMap("Header")
    @Validation(required = true)
    public UploadPartCopyRequestHeader header;

    public static class UploadPartCopyRequestFilter extends TeaModel {
        @NameInMap("partNumber")
        @Validation(required = true)
        public String partNumber;

        @NameInMap("uploadId")
        @Validation(required = true)
        public String uploadId;

    }

    public static class UploadPartCopyRequestHeader extends TeaModel {
        @NameInMap("x-oss-copy-source")
        @Validation(required = true)
        public String copySource;

        @NameInMap("x-oss-copy-source-range")
        @Validation(required = true)
        public String copySourceRange;

        @NameInMap("x-oss-copy-source-if-match")
        public String copySourceIfMatch;

        @NameInMap("x-oss-copy-source-if-none-match")
        public String copySourceIfNoneMatch;

        @NameInMap("x-oss-copy-source-if-unmodified-since")
        public String copySourceIfUnmodifiedSince;

        @NameInMap("x-oss-copy-source-if-modified-since")
        public String copySourceIfModifiedSince;

    }

}
