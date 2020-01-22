// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class GetBucketInfoResponse extends TeaModel {
    @NameInMap("x-oss-request-id")
    @Validation(required = true)
    public String requestId;

    @NameInMap("BucketInfo")
    @Validation(required = true)
    public GetBucketInfoResponseBucketInfo bucketInfo;

    public static GetBucketInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        GetBucketInfoResponse self = new GetBucketInfoResponse();
        return TeaModel.build(map, self);
    }

    public static class GetBucketInfoResponseBucketInfoBucketOwner extends TeaModel {
        @NameInMap("ID")
        public String iD;

        @NameInMap("DisplayName")
        public String displayName;

        public static GetBucketInfoResponseBucketInfoBucketOwner build(java.util.Map<String, ?> map) throws Exception {
            GetBucketInfoResponseBucketInfoBucketOwner self = new GetBucketInfoResponseBucketInfoBucketOwner();
            return TeaModel.build(map, self);
        }

    }

    public static class GetBucketInfoResponseBucketInfoBucketAccessControlList extends TeaModel {
        @NameInMap("Grant")
        public String grant;

        public static GetBucketInfoResponseBucketInfoBucketAccessControlList build(java.util.Map<String, ?> map) throws Exception {
            GetBucketInfoResponseBucketInfoBucketAccessControlList self = new GetBucketInfoResponseBucketInfoBucketAccessControlList();
            return TeaModel.build(map, self);
        }

    }

    public static class GetBucketInfoResponseBucketInfoBucket extends TeaModel {
        @NameInMap("CreationDate")
        public String creationDate;

        @NameInMap("ExtranetEndpoint")
        public String extranetEndpoint;

        @NameInMap("IntranetEndpoint")
        public String intranetEndpoint;

        @NameInMap("Location")
        public String location;

        @NameInMap("Name")
        public String name;

        @NameInMap("DataRedundancyType")
        public String dataRedundancyType;

        @NameInMap("StorageClass")
        public String storageClass;

        @NameInMap("Comment")
        public String comment;

        @NameInMap("Owner")
        @Validation(required = true)
        public GetBucketInfoResponseBucketInfoBucketOwner owner;

        @NameInMap("AccessControlList")
        @Validation(required = true)
        public GetBucketInfoResponseBucketInfoBucketAccessControlList accessControlList;

        public static GetBucketInfoResponseBucketInfoBucket build(java.util.Map<String, ?> map) throws Exception {
            GetBucketInfoResponseBucketInfoBucket self = new GetBucketInfoResponseBucketInfoBucket();
            return TeaModel.build(map, self);
        }

    }

    public static class GetBucketInfoResponseBucketInfo extends TeaModel {
        @NameInMap("Bucket")
        @Validation(required = true)
        public GetBucketInfoResponseBucketInfoBucket bucket;

        public static GetBucketInfoResponseBucketInfo build(java.util.Map<String, ?> map) throws Exception {
            GetBucketInfoResponseBucketInfo self = new GetBucketInfoResponseBucketInfo();
            return TeaModel.build(map, self);
        }

    }

}
