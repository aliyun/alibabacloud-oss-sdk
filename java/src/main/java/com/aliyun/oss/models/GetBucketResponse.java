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

    public static GetBucketResponse build(java.util.Map<String, ?> map) throws Exception {
        GetBucketResponse self = new GetBucketResponse();
        return TeaModel.build(map, self);
    }

    public static class GetBucketResponseListBucketResultContentsOwner extends TeaModel {
        @NameInMap("ID")
        public String iD;

        @NameInMap("DisplayName")
        public String displayName;

        public static GetBucketResponseListBucketResultContentsOwner build(java.util.Map<String, ?> map) throws Exception {
            GetBucketResponseListBucketResultContentsOwner self = new GetBucketResponseListBucketResultContentsOwner();
            return TeaModel.build(map, self);
        }

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

        public static GetBucketResponseListBucketResultContents build(java.util.Map<String, ?> map) throws Exception {
            GetBucketResponseListBucketResultContents self = new GetBucketResponseListBucketResultContents();
            return TeaModel.build(map, self);
        }

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

        public static GetBucketResponseListBucketResult build(java.util.Map<String, ?> map) throws Exception {
            GetBucketResponseListBucketResult self = new GetBucketResponseListBucketResult();
            return TeaModel.build(map, self);
        }

    }

}
