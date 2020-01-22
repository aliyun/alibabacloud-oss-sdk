// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

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

    public static UploadPartCopyRequest build(java.util.Map<String, ?> map) throws Exception {
        UploadPartCopyRequest self = new UploadPartCopyRequest();
        return TeaModel.build(map, self);
    }

    public static class UploadPartCopyRequestFilter extends TeaModel {
        @NameInMap("partNumber")
        @Validation(required = true)
        public String partNumber;

        @NameInMap("uploadId")
        @Validation(required = true)
        public String uploadId;

        public static UploadPartCopyRequestFilter build(java.util.Map<String, ?> map) throws Exception {
            UploadPartCopyRequestFilter self = new UploadPartCopyRequestFilter();
            return TeaModel.build(map, self);
        }

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

        public static UploadPartCopyRequestHeader build(java.util.Map<String, ?> map) throws Exception {
            UploadPartCopyRequestHeader self = new UploadPartCopyRequestHeader();
            return TeaModel.build(map, self);
        }

    }

}
