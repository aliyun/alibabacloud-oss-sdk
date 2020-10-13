// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class ListPartsResponse extends TeaModel {
    // x-oss-request-id
    @NameInMap("x-oss-request-id")
    @Validation(required = true)
    public String requestId;

    // ListPartsResult
    @NameInMap("ListPartsResult")
    @Validation(required = true)
    public ListPartsResponseListPartsResult listPartsResult;

    public static ListPartsResponse build(java.util.Map<String, ?> map) throws Exception {
        ListPartsResponse self = new ListPartsResponse();
        return TeaModel.build(map, self);
    }

    public ListPartsResponse setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public ListPartsResponse setListPartsResult(ListPartsResponseListPartsResult listPartsResult) {
        this.listPartsResult = listPartsResult;
        return this;
    }
    public ListPartsResponseListPartsResult getListPartsResult() {
        return this.listPartsResult;
    }

    public static class ListPartsResponseListPartsResultPart extends TeaModel {
        // PartNumber
        @NameInMap("PartNumber")
        public String partNumber;

        // LastModified
        @NameInMap("LastModified")
        public String lastModified;

        // ETag
        @NameInMap("ETag")
        public String eTag;

        // Size
        @NameInMap("Size")
        public String size;

        public static ListPartsResponseListPartsResultPart build(java.util.Map<String, ?> map) throws Exception {
            ListPartsResponseListPartsResultPart self = new ListPartsResponseListPartsResultPart();
            return TeaModel.build(map, self);
        }

        public ListPartsResponseListPartsResultPart setPartNumber(String partNumber) {
            this.partNumber = partNumber;
            return this;
        }
        public String getPartNumber() {
            return this.partNumber;
        }

        public ListPartsResponseListPartsResultPart setLastModified(String lastModified) {
            this.lastModified = lastModified;
            return this;
        }
        public String getLastModified() {
            return this.lastModified;
        }

        public ListPartsResponseListPartsResultPart setETag(String eTag) {
            this.eTag = eTag;
            return this;
        }
        public String getETag() {
            return this.eTag;
        }

        public ListPartsResponseListPartsResultPart setSize(String size) {
            this.size = size;
            return this;
        }
        public String getSize() {
            return this.size;
        }

    }

    public static class ListPartsResponseListPartsResult extends TeaModel {
        // Bucket
        @NameInMap("Bucket")
        public String bucket;

        // EncodingType
        @NameInMap("EncodingType")
        public String encodingType;

        // Key
        @NameInMap("Key")
        public String key;

        // UploadId
        @NameInMap("UploadId")
        public String uploadId;

        // PartNumberMarker
        @NameInMap("PartNumberMarker")
        public String partNumberMarker;

        // NextPartNumberMarker
        @NameInMap("NextPartNumberMarker")
        public String nextPartNumberMarker;

        // MaxParts
        @NameInMap("MaxParts")
        public String maxParts;

        // IsTruncated
        @NameInMap("IsTruncated")
        public String isTruncated;

        // Part
        @NameInMap("Part")
        public java.util.List<ListPartsResponseListPartsResultPart> part;

        public static ListPartsResponseListPartsResult build(java.util.Map<String, ?> map) throws Exception {
            ListPartsResponseListPartsResult self = new ListPartsResponseListPartsResult();
            return TeaModel.build(map, self);
        }

        public ListPartsResponseListPartsResult setBucket(String bucket) {
            this.bucket = bucket;
            return this;
        }
        public String getBucket() {
            return this.bucket;
        }

        public ListPartsResponseListPartsResult setEncodingType(String encodingType) {
            this.encodingType = encodingType;
            return this;
        }
        public String getEncodingType() {
            return this.encodingType;
        }

        public ListPartsResponseListPartsResult setKey(String key) {
            this.key = key;
            return this;
        }
        public String getKey() {
            return this.key;
        }

        public ListPartsResponseListPartsResult setUploadId(String uploadId) {
            this.uploadId = uploadId;
            return this;
        }
        public String getUploadId() {
            return this.uploadId;
        }

        public ListPartsResponseListPartsResult setPartNumberMarker(String partNumberMarker) {
            this.partNumberMarker = partNumberMarker;
            return this;
        }
        public String getPartNumberMarker() {
            return this.partNumberMarker;
        }

        public ListPartsResponseListPartsResult setNextPartNumberMarker(String nextPartNumberMarker) {
            this.nextPartNumberMarker = nextPartNumberMarker;
            return this;
        }
        public String getNextPartNumberMarker() {
            return this.nextPartNumberMarker;
        }

        public ListPartsResponseListPartsResult setMaxParts(String maxParts) {
            this.maxParts = maxParts;
            return this;
        }
        public String getMaxParts() {
            return this.maxParts;
        }

        public ListPartsResponseListPartsResult setIsTruncated(String isTruncated) {
            this.isTruncated = isTruncated;
            return this;
        }
        public String getIsTruncated() {
            return this.isTruncated;
        }

        public ListPartsResponseListPartsResult setPart(java.util.List<ListPartsResponseListPartsResultPart> part) {
            this.part = part;
            return this;
        }
        public java.util.List<ListPartsResponseListPartsResultPart> getPart() {
            return this.part;
        }

    }

}
