// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class GetServiceResponse extends TeaModel {
    // x-oss-request-id
    @NameInMap("x-oss-request-id")
    @Validation(required = true)
    public String requestId;

    // ListAllMyBucketsResult
    @NameInMap("ListAllMyBucketsResult")
    @Validation(required = true)
    public GetServiceResponseListAllMyBucketsResult listAllMyBucketsResult;

    public static GetServiceResponse build(java.util.Map<String, ?> map) {
        GetServiceResponse self = new GetServiceResponse();
        return TeaModel.build(map, self);
    }

    public GetServiceResponse setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public GetServiceResponse setListAllMyBucketsResult(GetServiceResponseListAllMyBucketsResult listAllMyBucketsResult) {
        this.listAllMyBucketsResult = listAllMyBucketsResult;
        return this;
    }
    public GetServiceResponseListAllMyBucketsResult getListAllMyBucketsResult() {
        return this.listAllMyBucketsResult;
    }

    public static class GetServiceResponseListAllMyBucketsResultOwner extends TeaModel {
        // ID
        @NameInMap("ID")
        public String iD;

        // DisplayName
        @NameInMap("DisplayName")
        public String displayName;

        public static GetServiceResponseListAllMyBucketsResultOwner build(java.util.Map<String, ?> map) {
            GetServiceResponseListAllMyBucketsResultOwner self = new GetServiceResponseListAllMyBucketsResultOwner();
            return TeaModel.build(map, self);
        }

        public GetServiceResponseListAllMyBucketsResultOwner setID(String iD) {
            this.iD = iD;
            return this;
        }
        public String getID() {
            return this.iD;
        }

        public GetServiceResponseListAllMyBucketsResultOwner setDisplayName(String displayName) {
            this.displayName = displayName;
            return this;
        }
        public String getDisplayName() {
            return this.displayName;
        }

    }

    public static class GetServiceResponseListAllMyBucketsResultBucketsBucket extends TeaModel {
        // Name
        @NameInMap("Name")
        public String name;

        // CreateDate
        @NameInMap("CreateDate")
        public String createDate;

        // Location
        @NameInMap("Location")
        public String location;

        // ExtranetEndpoint
        @NameInMap("ExtranetEndpoint")
        public String extranetEndpoint;

        // IntranetEndpoint
        @NameInMap("IntranetEndpoint")
        public String intranetEndpoint;

        // StorageClass
        @NameInMap("StorageClass")
        public String storageClass;

        public static GetServiceResponseListAllMyBucketsResultBucketsBucket build(java.util.Map<String, ?> map) {
            GetServiceResponseListAllMyBucketsResultBucketsBucket self = new GetServiceResponseListAllMyBucketsResultBucketsBucket();
            return TeaModel.build(map, self);
        }

        public GetServiceResponseListAllMyBucketsResultBucketsBucket setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public GetServiceResponseListAllMyBucketsResultBucketsBucket setCreateDate(String createDate) {
            this.createDate = createDate;
            return this;
        }
        public String getCreateDate() {
            return this.createDate;
        }

        public GetServiceResponseListAllMyBucketsResultBucketsBucket setLocation(String location) {
            this.location = location;
            return this;
        }
        public String getLocation() {
            return this.location;
        }

        public GetServiceResponseListAllMyBucketsResultBucketsBucket setExtranetEndpoint(String extranetEndpoint) {
            this.extranetEndpoint = extranetEndpoint;
            return this;
        }
        public String getExtranetEndpoint() {
            return this.extranetEndpoint;
        }

        public GetServiceResponseListAllMyBucketsResultBucketsBucket setIntranetEndpoint(String intranetEndpoint) {
            this.intranetEndpoint = intranetEndpoint;
            return this;
        }
        public String getIntranetEndpoint() {
            return this.intranetEndpoint;
        }

        public GetServiceResponseListAllMyBucketsResultBucketsBucket setStorageClass(String storageClass) {
            this.storageClass = storageClass;
            return this;
        }
        public String getStorageClass() {
            return this.storageClass;
        }

    }

    public static class GetServiceResponseListAllMyBucketsResultBuckets extends TeaModel {
        // Bucket
        @NameInMap("Bucket")
        public java.util.List<GetServiceResponseListAllMyBucketsResultBucketsBucket> bucket;

        public static GetServiceResponseListAllMyBucketsResultBuckets build(java.util.Map<String, ?> map) {
            GetServiceResponseListAllMyBucketsResultBuckets self = new GetServiceResponseListAllMyBucketsResultBuckets();
            return TeaModel.build(map, self);
        }

        public GetServiceResponseListAllMyBucketsResultBuckets setBucket(java.util.List<GetServiceResponseListAllMyBucketsResultBucketsBucket> bucket) {
            this.bucket = bucket;
            return this;
        }
        public java.util.List<GetServiceResponseListAllMyBucketsResultBucketsBucket> getBucket() {
            return this.bucket;
        }

    }

    public static class GetServiceResponseListAllMyBucketsResult extends TeaModel {
        // Prefix
        @NameInMap("Prefix")
        public String prefix;

        // Marker
        @NameInMap("Marker")
        public String marker;

        // MaxKeys
        @NameInMap("MaxKeys")
        public String maxKeys;

        // IsTruncated
        @NameInMap("IsTruncated")
        public String isTruncated;

        // NextMarker
        @NameInMap("NextMarker")
        public String nextMarker;

        // Owner
        @NameInMap("Owner")
        @Validation(required = true)
        public GetServiceResponseListAllMyBucketsResultOwner owner;

        // Buckets
        @NameInMap("Buckets")
        @Validation(required = true)
        public GetServiceResponseListAllMyBucketsResultBuckets buckets;

        public static GetServiceResponseListAllMyBucketsResult build(java.util.Map<String, ?> map) {
            GetServiceResponseListAllMyBucketsResult self = new GetServiceResponseListAllMyBucketsResult();
            return TeaModel.build(map, self);
        }

        public GetServiceResponseListAllMyBucketsResult setPrefix(String prefix) {
            this.prefix = prefix;
            return this;
        }
        public String getPrefix() {
            return this.prefix;
        }

        public GetServiceResponseListAllMyBucketsResult setMarker(String marker) {
            this.marker = marker;
            return this;
        }
        public String getMarker() {
            return this.marker;
        }

        public GetServiceResponseListAllMyBucketsResult setMaxKeys(String maxKeys) {
            this.maxKeys = maxKeys;
            return this;
        }
        public String getMaxKeys() {
            return this.maxKeys;
        }

        public GetServiceResponseListAllMyBucketsResult setIsTruncated(String isTruncated) {
            this.isTruncated = isTruncated;
            return this;
        }
        public String getIsTruncated() {
            return this.isTruncated;
        }

        public GetServiceResponseListAllMyBucketsResult setNextMarker(String nextMarker) {
            this.nextMarker = nextMarker;
            return this;
        }
        public String getNextMarker() {
            return this.nextMarker;
        }

        public GetServiceResponseListAllMyBucketsResult setOwner(GetServiceResponseListAllMyBucketsResultOwner owner) {
            this.owner = owner;
            return this;
        }
        public GetServiceResponseListAllMyBucketsResultOwner getOwner() {
            return this.owner;
        }

        public GetServiceResponseListAllMyBucketsResult setBuckets(GetServiceResponseListAllMyBucketsResultBuckets buckets) {
            this.buckets = buckets;
            return this;
        }
        public GetServiceResponseListAllMyBucketsResultBuckets getBuckets() {
            return this.buckets;
        }

    }

}
