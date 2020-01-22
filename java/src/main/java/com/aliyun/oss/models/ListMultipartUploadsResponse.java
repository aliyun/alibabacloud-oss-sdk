// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class ListMultipartUploadsResponse extends TeaModel {
    @NameInMap("x-oss-request-id")
    @Validation(required = true)
    public String requestId;

    @NameInMap("ListMultipartUploadsResult")
    @Validation(required = true)
    public ListMultipartUploadsResponseListMultipartUploadsResult listMultipartUploadsResult;

    public static ListMultipartUploadsResponse build(java.util.Map<String, ?> map) throws Exception {
        ListMultipartUploadsResponse self = new ListMultipartUploadsResponse();
        return TeaModel.build(map, self);
    }

    public static class ListMultipartUploadsResponseListMultipartUploadsResultUpload extends TeaModel {
        @NameInMap("Key")
        public String key;

        @NameInMap("UploadId")
        public String uploadId;

        @NameInMap("Initiated")
        public String initiated;

        public static ListMultipartUploadsResponseListMultipartUploadsResultUpload build(java.util.Map<String, ?> map) throws Exception {
            ListMultipartUploadsResponseListMultipartUploadsResultUpload self = new ListMultipartUploadsResponseListMultipartUploadsResultUpload();
            return TeaModel.build(map, self);
        }

    }

    public static class ListMultipartUploadsResponseListMultipartUploadsResult extends TeaModel {
        @NameInMap("Bucket")
        public String bucket;

        @NameInMap("EncodingType")
        public String encodingType;

        @NameInMap("KeyMarker")
        public String keyMarker;

        @NameInMap("UploadIdMarker")
        public String uploadIdMarker;

        @NameInMap("NextKeyMarker")
        public String nextKeyMarker;

        @NameInMap("NextUploadIdMarker")
        public String nextUploadIdMarker;

        @NameInMap("Delimiter")
        public String delimiter;

        @NameInMap("MaxUploads")
        public String maxUploads;

        @NameInMap("IsTruncated")
        public String isTruncated;

        @NameInMap("Upload")
        public ListMultipartUploadsResponseListMultipartUploadsResultUpload[] upload;

        public static ListMultipartUploadsResponseListMultipartUploadsResult build(java.util.Map<String, ?> map) throws Exception {
            ListMultipartUploadsResponseListMultipartUploadsResult self = new ListMultipartUploadsResponseListMultipartUploadsResult();
            return TeaModel.build(map, self);
        }

    }

}
