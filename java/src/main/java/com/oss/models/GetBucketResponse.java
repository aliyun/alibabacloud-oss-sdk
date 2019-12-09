// This file is auto-generated, don't edit it. Thanks.
package com.oss.models;

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
        @Validation(required = true)
        public String iD;

        @NameInMap("DisplayName")
        @Validation(required = true)
        public String displayName;

    }

    public static class GetBucketResponseListBucketResultContents extends TeaModel {
        @NameInMap("Key")
        @Validation(required = true)
        public String key;

        @NameInMap("ETag")
        @Validation(required = true)
        public String eTag;

        @NameInMap("LastModified")
        @Validation(required = true)
        public String lastModified;

        @NameInMap("Size")
        @Validation(required = true)
        public String size;

        @NameInMap("StorageClass")
        @Validation(required = true)
        public String storageClass;

        @NameInMap("Owner")
        @Validation(required = true)
        public GetBucketResponseListBucketResultContentsOwner owner;

    }

    public static class GetBucketResponseListBucketResult extends TeaModel {
        @NameInMap("Name")
        @Validation(required = true)
        public String name;

        @NameInMap("Prefix")
        @Validation(required = true)
        public String prefix;

        @NameInMap("Marker")
        @Validation(required = true)
        public String marker;

        @NameInMap("MaxKeys")
        @Validation(required = true)
        public String maxKeys;

        @NameInMap("Delimiter")
        @Validation(required = true)
        public String delimiter;

        @NameInMap("IsTruncated")
        @Validation(required = true)
        public String isTruncated;

        @NameInMap("EncodingType")
        @Validation(required = true)
        public String encodingType;

        @NameInMap("CommonPrefixes")
        @Validation(required = true)
        public String commonPrefixes;

        @NameInMap("Contents")
        @Validation(required = true)
        public GetBucketResponseListBucketResultContents[] contents;

    }

}
