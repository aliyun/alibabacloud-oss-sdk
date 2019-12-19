// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class CompleteMultipartUploadRequest extends TeaModel {
    @NameInMap("BucketName")
    @Validation(required = true)
    public String bucketName;

    @NameInMap("ObjectName")
    @Validation(required = true)
    public String objectName;

    @NameInMap("Filter")
    @Validation(required = true)
    public CompleteMultipartUploadRequestFilter filter;

    @NameInMap("Body")
    public CompleteMultipartUploadRequestBody body;

    public static class CompleteMultipartUploadRequestFilter extends TeaModel {
        @NameInMap("uploadId")
        @Validation(required = true)
        public String uploadId;

        @NameInMap("Encoding-type")
        public String encodingType;

    }

    public static class CompleteMultipartUploadRequestBodyCompleteMultipartUploadPart extends TeaModel {
        @NameInMap("PartNumber")
        public String partNumber;

        @NameInMap("ETag")
        public String eTag;

    }

    public static class CompleteMultipartUploadRequestBodyCompleteMultipartUpload extends TeaModel {
        @NameInMap("Part")
        public CompleteMultipartUploadRequestBodyCompleteMultipartUploadPart[] part;

    }

    public static class CompleteMultipartUploadRequestBody extends TeaModel {
        @NameInMap("CompleteMultipartUpload")
        @Validation(required = true)
        public CompleteMultipartUploadRequestBodyCompleteMultipartUpload completeMultipartUpload;

    }

}
