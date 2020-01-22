// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class AbortMultipartUploadRequest extends TeaModel {
    @NameInMap("BucketName")
    @Validation(required = true)
    public String bucketName;

    @NameInMap("ObjectName")
    @Validation(required = true)
    public String objectName;

    @NameInMap("Filter")
    @Validation(required = true)
    public AbortMultipartUploadRequestFilter filter;

    public static AbortMultipartUploadRequest build(java.util.Map<String, ?> map) throws Exception {
        AbortMultipartUploadRequest self = new AbortMultipartUploadRequest();
        return TeaModel.build(map, self);
    }

    public static class AbortMultipartUploadRequestFilter extends TeaModel {
        @NameInMap("uploadId")
        @Validation(required = true)
        public String uploadId;

        public static AbortMultipartUploadRequestFilter build(java.util.Map<String, ?> map) throws Exception {
            AbortMultipartUploadRequestFilter self = new AbortMultipartUploadRequestFilter();
            return TeaModel.build(map, self);
        }

    }

}
