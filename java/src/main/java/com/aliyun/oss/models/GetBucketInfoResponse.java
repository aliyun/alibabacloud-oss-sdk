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

    public static class GetBucketInfoResponseBucketInfoBucketOwner extends TeaModel {
        @NameInMap("ID")
        public String iD;

        @NameInMap("DisplayName")
        public String displayName;

    }

    public static class GetBucketInfoResponseBucketInfoBucketAccessControlList extends TeaModel {
        @NameInMap("Grant")
        public String grant;

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

    }

    public static class GetBucketInfoResponseBucketInfo extends TeaModel {
        @NameInMap("Bucket")
        @Validation(required = true)
        public GetBucketInfoResponseBucketInfoBucket bucket;

    }

}
