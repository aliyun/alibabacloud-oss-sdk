// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class UploadPartRequest extends TeaModel {
    @NameInMap("BucketName")
    @Validation(required = true)
    public String bucketName;

    @NameInMap("ObjectName")
    @Validation(required = true)
    public String objectName;

    @NameInMap("body")
    public java.io.InputStream body;

    @NameInMap("Filter")
    @Validation(required = true)
    public UploadPartRequestFilter filter;

    public static UploadPartRequest build(java.util.Map<String, ?> map) throws Exception {
        UploadPartRequest self = new UploadPartRequest();
        return TeaModel.build(map, self);
    }

    public static class UploadPartRequestFilter extends TeaModel {
        @NameInMap("partNumber")
        @Validation(required = true)
        public String partNumber;

        @NameInMap("uploadId")
        @Validation(required = true)
        public String uploadId;

        public static UploadPartRequestFilter build(java.util.Map<String, ?> map) throws Exception {
            UploadPartRequestFilter self = new UploadPartRequestFilter();
            return TeaModel.build(map, self);
        }

    }

}
