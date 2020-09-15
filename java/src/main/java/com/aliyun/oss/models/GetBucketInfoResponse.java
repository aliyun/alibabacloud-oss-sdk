// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class GetBucketInfoResponse extends TeaModel {
    // x-oss-request-id
    @NameInMap("x-oss-request-id")
    @Validation(required = true)
    public String requestId;

    // BucketInfo
    @NameInMap("BucketInfo")
    @Validation(required = true)
    public GetBucketInfoResponseBucketInfo bucketInfo;

    public static GetBucketInfoResponse build(java.util.Map<String, ?> map) {
        GetBucketInfoResponse self = new GetBucketInfoResponse();
        return TeaModel.build(map, self);
    }

    public GetBucketInfoResponse setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public GetBucketInfoResponse setBucketInfo(GetBucketInfoResponseBucketInfo bucketInfo) {
        this.bucketInfo = bucketInfo;
        return this;
    }
    public GetBucketInfoResponseBucketInfo getBucketInfo() {
        return this.bucketInfo;
    }

    public static class GetBucketInfoResponseBucketInfoBucketOwner extends TeaModel {
        // ID
        @NameInMap("ID")
        public String iD;

        // DisplayName
        @NameInMap("DisplayName")
        public String displayName;

        public static GetBucketInfoResponseBucketInfoBucketOwner build(java.util.Map<String, ?> map) {
            GetBucketInfoResponseBucketInfoBucketOwner self = new GetBucketInfoResponseBucketInfoBucketOwner();
            return TeaModel.build(map, self);
        }

        public GetBucketInfoResponseBucketInfoBucketOwner setID(String iD) {
            this.iD = iD;
            return this;
        }
        public String getID() {
            return this.iD;
        }

        public GetBucketInfoResponseBucketInfoBucketOwner setDisplayName(String displayName) {
            this.displayName = displayName;
            return this;
        }
        public String getDisplayName() {
            return this.displayName;
        }

    }

    public static class GetBucketInfoResponseBucketInfoBucketAccessControlList extends TeaModel {
        // Grant
        @NameInMap("Grant")
        public String grant;

        public static GetBucketInfoResponseBucketInfoBucketAccessControlList build(java.util.Map<String, ?> map) {
            GetBucketInfoResponseBucketInfoBucketAccessControlList self = new GetBucketInfoResponseBucketInfoBucketAccessControlList();
            return TeaModel.build(map, self);
        }

        public GetBucketInfoResponseBucketInfoBucketAccessControlList setGrant(String grant) {
            this.grant = grant;
            return this;
        }
        public String getGrant() {
            return this.grant;
        }

    }

    public static class GetBucketInfoResponseBucketInfoBucket extends TeaModel {
        // CreationDate
        @NameInMap("CreationDate")
        public String creationDate;

        // ExtranetEndpoint
        @NameInMap("ExtranetEndpoint")
        public String extranetEndpoint;

        // IntranetEndpoint
        @NameInMap("IntranetEndpoint")
        public String intranetEndpoint;

        // Location
        @NameInMap("Location")
        public String location;

        // Name
        @NameInMap("Name")
        public String name;

        // DataRedundancyType
        @NameInMap("DataRedundancyType")
        public String dataRedundancyType;

        // StorageClass
        @NameInMap("StorageClass")
        public String storageClass;

        // Comment
        @NameInMap("Comment")
        public String comment;

        // Owner
        @NameInMap("Owner")
        @Validation(required = true)
        public GetBucketInfoResponseBucketInfoBucketOwner owner;

        // AccessControlList
        @NameInMap("AccessControlList")
        @Validation(required = true)
        public GetBucketInfoResponseBucketInfoBucketAccessControlList accessControlList;

        public static GetBucketInfoResponseBucketInfoBucket build(java.util.Map<String, ?> map) {
            GetBucketInfoResponseBucketInfoBucket self = new GetBucketInfoResponseBucketInfoBucket();
            return TeaModel.build(map, self);
        }

        public GetBucketInfoResponseBucketInfoBucket setCreationDate(String creationDate) {
            this.creationDate = creationDate;
            return this;
        }
        public String getCreationDate() {
            return this.creationDate;
        }

        public GetBucketInfoResponseBucketInfoBucket setExtranetEndpoint(String extranetEndpoint) {
            this.extranetEndpoint = extranetEndpoint;
            return this;
        }
        public String getExtranetEndpoint() {
            return this.extranetEndpoint;
        }

        public GetBucketInfoResponseBucketInfoBucket setIntranetEndpoint(String intranetEndpoint) {
            this.intranetEndpoint = intranetEndpoint;
            return this;
        }
        public String getIntranetEndpoint() {
            return this.intranetEndpoint;
        }

        public GetBucketInfoResponseBucketInfoBucket setLocation(String location) {
            this.location = location;
            return this;
        }
        public String getLocation() {
            return this.location;
        }

        public GetBucketInfoResponseBucketInfoBucket setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public GetBucketInfoResponseBucketInfoBucket setDataRedundancyType(String dataRedundancyType) {
            this.dataRedundancyType = dataRedundancyType;
            return this;
        }
        public String getDataRedundancyType() {
            return this.dataRedundancyType;
        }

        public GetBucketInfoResponseBucketInfoBucket setStorageClass(String storageClass) {
            this.storageClass = storageClass;
            return this;
        }
        public String getStorageClass() {
            return this.storageClass;
        }

        public GetBucketInfoResponseBucketInfoBucket setComment(String comment) {
            this.comment = comment;
            return this;
        }
        public String getComment() {
            return this.comment;
        }

        public GetBucketInfoResponseBucketInfoBucket setOwner(GetBucketInfoResponseBucketInfoBucketOwner owner) {
            this.owner = owner;
            return this;
        }
        public GetBucketInfoResponseBucketInfoBucketOwner getOwner() {
            return this.owner;
        }

        public GetBucketInfoResponseBucketInfoBucket setAccessControlList(GetBucketInfoResponseBucketInfoBucketAccessControlList accessControlList) {
            this.accessControlList = accessControlList;
            return this;
        }
        public GetBucketInfoResponseBucketInfoBucketAccessControlList getAccessControlList() {
            return this.accessControlList;
        }

    }

    public static class GetBucketInfoResponseBucketInfo extends TeaModel {
        // Bucket
        @NameInMap("Bucket")
        @Validation(required = true)
        public GetBucketInfoResponseBucketInfoBucket bucket;

        public static GetBucketInfoResponseBucketInfo build(java.util.Map<String, ?> map) {
            GetBucketInfoResponseBucketInfo self = new GetBucketInfoResponseBucketInfo();
            return TeaModel.build(map, self);
        }

        public GetBucketInfoResponseBucketInfo setBucket(GetBucketInfoResponseBucketInfoBucket bucket) {
            this.bucket = bucket;
            return this;
        }
        public GetBucketInfoResponseBucketInfoBucket getBucket() {
            return this.bucket;
        }

    }

}
