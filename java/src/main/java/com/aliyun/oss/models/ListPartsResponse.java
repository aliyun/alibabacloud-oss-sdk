// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class ListPartsResponse extends TeaModel {
    @NameInMap("x-oss-request-id")
    @Validation(required = true)
    public String requestId;

    @NameInMap("ListPartsResult")
    @Validation(required = true)
    public ListPartsResponseListPartsResult listPartsResult;

    public static ListPartsResponse build(java.util.Map<String, ?> map) throws Exception {
        ListPartsResponse self = new ListPartsResponse();
        return TeaModel.build(map, self);
    }

    public static class ListPartsResponseListPartsResultPart extends TeaModel {
        @NameInMap("PartNumber")
        public String partNumber;

        @NameInMap("LastModified")
        public String lastModified;

        @NameInMap("ETag")
        public String eTag;

        @NameInMap("Size")
        public String size;

        public static ListPartsResponseListPartsResultPart build(java.util.Map<String, ?> map) throws Exception {
            ListPartsResponseListPartsResultPart self = new ListPartsResponseListPartsResultPart();
            return TeaModel.build(map, self);
        }

    }

    public static class ListPartsResponseListPartsResult extends TeaModel {
        @NameInMap("Bucket")
        public String bucket;

        @NameInMap("EncodingType")
        public String encodingType;

        @NameInMap("Key")
        public String key;

        @NameInMap("UploadId")
        public String uploadId;

        @NameInMap("PartNumberMarker")
        public String partNumberMarker;

        @NameInMap("NextPartNumberMarker")
        public String nextPartNumberMarker;

        @NameInMap("MaxParts")
        public String maxParts;

        @NameInMap("IsTruncated")
        public String isTruncated;

        @NameInMap("Part")
        public ListPartsResponseListPartsResultPart[] part;

        public static ListPartsResponseListPartsResult build(java.util.Map<String, ?> map) throws Exception {
            ListPartsResponseListPartsResult self = new ListPartsResponseListPartsResult();
            return TeaModel.build(map, self);
        }

    }

}
