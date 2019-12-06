// This file is auto-generated, don't edit it. Thanks.
package com.oss.models;

import com.aliyun.tea.*;

public class ListPartsResponse extends TeaModel {
    @NameInMap("x-oss-request-id")
    @Validation(required = true)
    public String requestId;

    @NameInMap("ListPartsResult")
    @Validation(required = true)
    public ListPartsResponseListPartsResult listPartsResult;

    public static class ListPartsResponseListPartsResultPart extends TeaModel {
        @NameInMap("PartNumber")
        @Validation(required = true)
        public String partNumber;

        @NameInMap("LastModified")
        @Validation(required = true)
        public String lastModified;

        @NameInMap("ETag")
        @Validation(required = true)
        public String eTag;

        @NameInMap("Size")
        @Validation(required = true)
        public String size;

    }

    public static class ListPartsResponseListPartsResult extends TeaModel {
        @NameInMap("Bucket")
        @Validation(required = true)
        public String bucket;

        @NameInMap("EncodingType")
        @Validation(required = true)
        public String encodingType;

        @NameInMap("Key")
        @Validation(required = true)
        public String key;

        @NameInMap("UploadId")
        @Validation(required = true)
        public String uploadId;

        @NameInMap("PartNumberMarker")
        @Validation(required = true)
        public String partNumberMarker;

        @NameInMap("NextPartNumberMarker")
        @Validation(required = true)
        public String nextPartNumberMarker;

        @NameInMap("MaxParts")
        @Validation(required = true)
        public String maxParts;

        @NameInMap("IsTruncated")
        @Validation(required = true)
        public String isTruncated;

        @NameInMap("Part")
        @Validation(required = true)
        public ListPartsResponseListPartsResultPart[] part;

    }

}
