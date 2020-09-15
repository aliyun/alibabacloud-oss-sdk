// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class UploadPartCopyRequest extends TeaModel {
    // BucketName
    @NameInMap("BucketName")
    @Validation(required = true)
    public String bucketName;

    // ObjectName
    @NameInMap("ObjectName")
    @Validation(required = true)
    public String objectName;

    // Filter
    @NameInMap("Filter")
    @Validation(required = true)
    public UploadPartCopyRequestFilter filter;

    // Header
    @NameInMap("Header")
    @Validation(required = true)
    public UploadPartCopyRequestHeader header;

    public static UploadPartCopyRequest build(java.util.Map<String, ?> map) {
        UploadPartCopyRequest self = new UploadPartCopyRequest();
        return TeaModel.build(map, self);
    }

    public UploadPartCopyRequest setBucketName(String bucketName) {
        this.bucketName = bucketName;
        return this;
    }
    public String getBucketName() {
        return this.bucketName;
    }

    public UploadPartCopyRequest setObjectName(String objectName) {
        this.objectName = objectName;
        return this;
    }
    public String getObjectName() {
        return this.objectName;
    }

    public UploadPartCopyRequest setFilter(UploadPartCopyRequestFilter filter) {
        this.filter = filter;
        return this;
    }
    public UploadPartCopyRequestFilter getFilter() {
        return this.filter;
    }

    public UploadPartCopyRequest setHeader(UploadPartCopyRequestHeader header) {
        this.header = header;
        return this;
    }
    public UploadPartCopyRequestHeader getHeader() {
        return this.header;
    }

    public static class UploadPartCopyRequestFilter extends TeaModel {
        // partNumber
        @NameInMap("partNumber")
        @Validation(required = true)
        public String partNumber;

        // uploadId
        @NameInMap("uploadId")
        @Validation(required = true)
        public String uploadId;

        public static UploadPartCopyRequestFilter build(java.util.Map<String, ?> map) {
            UploadPartCopyRequestFilter self = new UploadPartCopyRequestFilter();
            return TeaModel.build(map, self);
        }

        public UploadPartCopyRequestFilter setPartNumber(String partNumber) {
            this.partNumber = partNumber;
            return this;
        }
        public String getPartNumber() {
            return this.partNumber;
        }

        public UploadPartCopyRequestFilter setUploadId(String uploadId) {
            this.uploadId = uploadId;
            return this;
        }
        public String getUploadId() {
            return this.uploadId;
        }

    }

    public static class UploadPartCopyRequestHeader extends TeaModel {
        // x-oss-copy-source
        @NameInMap("x-oss-copy-source")
        @Validation(required = true)
        public String copySource;

        // x-oss-copy-source-range
        @NameInMap("x-oss-copy-source-range")
        @Validation(required = true)
        public String copySourceRange;

        // x-oss-copy-source-if-match
        @NameInMap("x-oss-copy-source-if-match")
        public String copySourceIfMatch;

        // x-oss-copy-source-if-none-match
        @NameInMap("x-oss-copy-source-if-none-match")
        public String copySourceIfNoneMatch;

        // x-oss-copy-source-if-unmodified-since
        @NameInMap("x-oss-copy-source-if-unmodified-since")
        public String copySourceIfUnmodifiedSince;

        // x-oss-copy-source-if-modified-since
        @NameInMap("x-oss-copy-source-if-modified-since")
        public String copySourceIfModifiedSince;

        public static UploadPartCopyRequestHeader build(java.util.Map<String, ?> map) {
            UploadPartCopyRequestHeader self = new UploadPartCopyRequestHeader();
            return TeaModel.build(map, self);
        }

        public UploadPartCopyRequestHeader setCopySource(String copySource) {
            this.copySource = copySource;
            return this;
        }
        public String getCopySource() {
            return this.copySource;
        }

        public UploadPartCopyRequestHeader setCopySourceRange(String copySourceRange) {
            this.copySourceRange = copySourceRange;
            return this;
        }
        public String getCopySourceRange() {
            return this.copySourceRange;
        }

        public UploadPartCopyRequestHeader setCopySourceIfMatch(String copySourceIfMatch) {
            this.copySourceIfMatch = copySourceIfMatch;
            return this;
        }
        public String getCopySourceIfMatch() {
            return this.copySourceIfMatch;
        }

        public UploadPartCopyRequestHeader setCopySourceIfNoneMatch(String copySourceIfNoneMatch) {
            this.copySourceIfNoneMatch = copySourceIfNoneMatch;
            return this;
        }
        public String getCopySourceIfNoneMatch() {
            return this.copySourceIfNoneMatch;
        }

        public UploadPartCopyRequestHeader setCopySourceIfUnmodifiedSince(String copySourceIfUnmodifiedSince) {
            this.copySourceIfUnmodifiedSince = copySourceIfUnmodifiedSince;
            return this;
        }
        public String getCopySourceIfUnmodifiedSince() {
            return this.copySourceIfUnmodifiedSince;
        }

        public UploadPartCopyRequestHeader setCopySourceIfModifiedSince(String copySourceIfModifiedSince) {
            this.copySourceIfModifiedSince = copySourceIfModifiedSince;
            return this;
        }
        public String getCopySourceIfModifiedSince() {
            return this.copySourceIfModifiedSince;
        }

    }

}
