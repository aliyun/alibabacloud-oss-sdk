// This file is auto-generated, don't edit it. Thanks.
package com.oss.models;

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
        @Validation(required = true)
        public String iD;

        @NameInMap("DisplayName")
        @Validation(required = true)
        public String displayName;

    }

    public static class GetBucketInfoResponseBucketInfoBucketAccessControlList extends TeaModel {
        @NameInMap("Grant")
        @Validation(required = true)
        public String grant;

    }

    public static class GetBucketInfoResponseBucketInfoBucket extends TeaModel {
        @NameInMap("CreationDate")
        @Validation(required = true)
        public String creationDate;

        @NameInMap("ExtranetEndpoint")
        @Validation(required = true)
        public String extranetEndpoint;

        @NameInMap("IntranetEndpoint")
        @Validation(required = true)
        public String intranetEndpoint;

        @NameInMap("Location")
        @Validation(required = true)
        public String location;

        @NameInMap("Name")
        @Validation(required = true)
        public String name;

        @NameInMap("DataRedundancyType")
        @Validation(required = true)
        public String dataRedundancyType;

        @NameInMap("StorageClass")
        @Validation(required = true)
        public String storageClass;

        @NameInMap("Comment")
        @Validation(required = true)
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
