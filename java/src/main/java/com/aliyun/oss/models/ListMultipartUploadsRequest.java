// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class ListMultipartUploadsRequest extends TeaModel {
    @NameInMap("BucketName")
    @Validation(required = true)
    public String bucketName;

    @NameInMap("Filter")
    public ListMultipartUploadsRequestFilter filter;

    public static class ListMultipartUploadsRequestFilter extends TeaModel {
        @NameInMap("delimiter")
        public String delimiter;

        @NameInMap("max-uploads")
        public String maxUploads;

        @NameInMap("key-marker")
        public String keyMarker;

        @NameInMap("prefix")
        public String prefix;

        @NameInMap("upload-id-marker")
        public String uploadIdMarker;

        @NameInMap("encoding-type")
        public String encodingType;

    }

}
