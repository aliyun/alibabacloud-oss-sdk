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

    public static CompleteMultipartUploadRequest build(java.util.Map<String, ?> map) throws Exception {
        CompleteMultipartUploadRequest self = new CompleteMultipartUploadRequest();
        return TeaModel.build(map, self);
    }

    public static class CompleteMultipartUploadRequestFilter extends TeaModel {
        @NameInMap("uploadId")
        @Validation(required = true)
        public String uploadId;

        @NameInMap("Encoding-type")
        public String encodingType;

        public static CompleteMultipartUploadRequestFilter build(java.util.Map<String, ?> map) throws Exception {
            CompleteMultipartUploadRequestFilter self = new CompleteMultipartUploadRequestFilter();
            return TeaModel.build(map, self);
        }

    }

    public static class CompleteMultipartUploadRequestBodyCompleteMultipartUploadPart extends TeaModel {
        @NameInMap("PartNumber")
        public String partNumber;

        @NameInMap("ETag")
        public String eTag;

        public static CompleteMultipartUploadRequestBodyCompleteMultipartUploadPart build(java.util.Map<String, ?> map) throws Exception {
            CompleteMultipartUploadRequestBodyCompleteMultipartUploadPart self = new CompleteMultipartUploadRequestBodyCompleteMultipartUploadPart();
            return TeaModel.build(map, self);
        }

    }

    public static class CompleteMultipartUploadRequestBodyCompleteMultipartUpload extends TeaModel {
        @NameInMap("Part")
        public CompleteMultipartUploadRequestBodyCompleteMultipartUploadPart[] part;

        public static CompleteMultipartUploadRequestBodyCompleteMultipartUpload build(java.util.Map<String, ?> map) throws Exception {
            CompleteMultipartUploadRequestBodyCompleteMultipartUpload self = new CompleteMultipartUploadRequestBodyCompleteMultipartUpload();
            return TeaModel.build(map, self);
        }

    }

    public static class CompleteMultipartUploadRequestBody extends TeaModel {
        @NameInMap("CompleteMultipartUpload")
        @Validation(required = true)
        public CompleteMultipartUploadRequestBodyCompleteMultipartUpload completeMultipartUpload;

        public static CompleteMultipartUploadRequestBody build(java.util.Map<String, ?> map) throws Exception {
            CompleteMultipartUploadRequestBody self = new CompleteMultipartUploadRequestBody();
            return TeaModel.build(map, self);
        }

    }

}
