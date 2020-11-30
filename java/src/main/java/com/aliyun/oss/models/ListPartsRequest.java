// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class ListPartsRequest extends TeaModel {
    // BucketName
    @NameInMap("BucketName")
    @Validation(required = true, pattern = "[a-zA-Z0-9-_]+")
    public String bucketName;

    // ObjectName
    @NameInMap("ObjectName")
    @Validation(required = true)
    public String objectName;

    // Filter
    @NameInMap("Filter")
    @Validation(required = true)
    public ListPartsRequestFilter filter;

    public static ListPartsRequest build(java.util.Map<String, ?> map) throws Exception {
        ListPartsRequest self = new ListPartsRequest();
        return TeaModel.build(map, self);
    }

    public ListPartsRequest setBucketName(String bucketName) {
        this.bucketName = bucketName;
        return this;
    }
    public String getBucketName() {
        return this.bucketName;
    }

    public ListPartsRequest setObjectName(String objectName) {
        this.objectName = objectName;
        return this;
    }
    public String getObjectName() {
        return this.objectName;
    }

    public ListPartsRequest setFilter(ListPartsRequestFilter filter) {
        this.filter = filter;
        return this;
    }
    public ListPartsRequestFilter getFilter() {
        return this.filter;
    }

    public static class ListPartsRequestFilter extends TeaModel {
        // uploadId
        @NameInMap("uploadId")
        @Validation(required = true)
        public String uploadId;

        // max-parts
        @NameInMap("max-parts")
        public Integer maxParts;

        // part-number-marker
        @NameInMap("part-number-marker")
        public Integer partNumberMarker;

        // Encoding-type
        @NameInMap("Encoding-type")
        public String encodingType;

        public static ListPartsRequestFilter build(java.util.Map<String, ?> map) throws Exception {
            ListPartsRequestFilter self = new ListPartsRequestFilter();
            return TeaModel.build(map, self);
        }

        public ListPartsRequestFilter setUploadId(String uploadId) {
            this.uploadId = uploadId;
            return this;
        }
        public String getUploadId() {
            return this.uploadId;
        }

        public ListPartsRequestFilter setMaxParts(Integer maxParts) {
            this.maxParts = maxParts;
            return this;
        }
        public Integer getMaxParts() {
            return this.maxParts;
        }

        public ListPartsRequestFilter setPartNumberMarker(Integer partNumberMarker) {
            this.partNumberMarker = partNumberMarker;
            return this;
        }
        public Integer getPartNumberMarker() {
            return this.partNumberMarker;
        }

        public ListPartsRequestFilter setEncodingType(String encodingType) {
            this.encodingType = encodingType;
            return this;
        }
        public String getEncodingType() {
            return this.encodingType;
        }

    }

}
