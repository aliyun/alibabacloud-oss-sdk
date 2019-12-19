// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class GetBucketResponse extends TeaModel {
    @NameInMap("x-oss-request-id")
    @Validation(required = true)
    public String requestId;

    @NameInMap("ListBucketResult")
    @Validation(required = true)
    public GetBucketResponseListBucketResult listBucketResult;

    public static class GetBucketResponseListBucketResultContentsOwner extends TeaModel {
        @NameInMap("ID")
        public String iD;

        @NameInMap("DisplayName")
        public String displayName;

    }

    public static class GetBucketResponseListBucketResultContents extends TeaModel {
        @NameInMap("Key")
        public String key;

        @NameInMap("ETag")
        public String eTag;

        @NameInMap("LastModified")
        public String lastModified;

        @NameInMap("Size")
        public String size;

        @NameInMap("StorageClass")
        public String storageClass;

        @NameInMap("Owner")
        @Validation(required = true)
        public GetBucketResponseListBucketResultContentsOwner owner;

    }

    public static class GetBucketResponseListBucketResult extends TeaModel {
        @NameInMap("Name")
        public String name;

        @NameInMap("Prefix")
        public String prefix;

        @NameInMap("Marker")
        public String marker;

        @NameInMap("MaxKeys")
        public String maxKeys;

        @NameInMap("Delimiter")
        public String delimiter;

        @NameInMap("IsTruncated")
        public String isTruncated;

        @NameInMap("EncodingType")
        public String encodingType;

        @NameInMap("CommonPrefixes")
        public String commonPrefixes;

        @NameInMap("Contents")
        public GetBucketResponseListBucketResultContents[] contents;

    }

}
