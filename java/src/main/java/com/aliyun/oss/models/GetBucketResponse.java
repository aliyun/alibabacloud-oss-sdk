// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class GetBucketResponse extends TeaModel {
    // x-oss-request-id
    @NameInMap("x-oss-request-id")
    @Validation(required = true)
    public String requestId;

    // ListBucketResult
    @NameInMap("ListBucketResult")
    @Validation(required = true)
    public GetBucketResponseListBucketResult listBucketResult;

    public static GetBucketResponse build(java.util.Map<String, ?> map) throws Exception {
        GetBucketResponse self = new GetBucketResponse();
        return TeaModel.build(map, self);
    }

    public GetBucketResponse setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public GetBucketResponse setListBucketResult(GetBucketResponseListBucketResult listBucketResult) {
        this.listBucketResult = listBucketResult;
        return this;
    }
    public GetBucketResponseListBucketResult getListBucketResult() {
        return this.listBucketResult;
    }

    public static class GetBucketResponseListBucketResultContentsOwner extends TeaModel {
        // ID
        @NameInMap("ID")
        public String iD;

        // DisplayName
        @NameInMap("DisplayName")
        public String displayName;

        public static GetBucketResponseListBucketResultContentsOwner build(java.util.Map<String, ?> map) throws Exception {
            GetBucketResponseListBucketResultContentsOwner self = new GetBucketResponseListBucketResultContentsOwner();
            return TeaModel.build(map, self);
        }

        public GetBucketResponseListBucketResultContentsOwner setID(String iD) {
            this.iD = iD;
            return this;
        }
        public String getID() {
            return this.iD;
        }

        public GetBucketResponseListBucketResultContentsOwner setDisplayName(String displayName) {
            this.displayName = displayName;
            return this;
        }
        public String getDisplayName() {
            return this.displayName;
        }

    }

    public static class GetBucketResponseListBucketResultContents extends TeaModel {
        // Key
        @NameInMap("Key")
        public String key;

        // ETag
        @NameInMap("ETag")
        public String eTag;

        // LastModified
        @NameInMap("LastModified")
        public String lastModified;

        // Size
        @NameInMap("Size")
        public String size;

        // StorageClass
        @NameInMap("StorageClass")
        public String storageClass;

        // Owner
        @NameInMap("Owner")
        @Validation(required = true)
        public GetBucketResponseListBucketResultContentsOwner owner;

        public static GetBucketResponseListBucketResultContents build(java.util.Map<String, ?> map) throws Exception {
            GetBucketResponseListBucketResultContents self = new GetBucketResponseListBucketResultContents();
            return TeaModel.build(map, self);
        }

        public GetBucketResponseListBucketResultContents setKey(String key) {
            this.key = key;
            return this;
        }
        public String getKey() {
            return this.key;
        }

        public GetBucketResponseListBucketResultContents setETag(String eTag) {
            this.eTag = eTag;
            return this;
        }
        public String getETag() {
            return this.eTag;
        }

        public GetBucketResponseListBucketResultContents setLastModified(String lastModified) {
            this.lastModified = lastModified;
            return this;
        }
        public String getLastModified() {
            return this.lastModified;
        }

        public GetBucketResponseListBucketResultContents setSize(String size) {
            this.size = size;
            return this;
        }
        public String getSize() {
            return this.size;
        }

        public GetBucketResponseListBucketResultContents setStorageClass(String storageClass) {
            this.storageClass = storageClass;
            return this;
        }
        public String getStorageClass() {
            return this.storageClass;
        }

        public GetBucketResponseListBucketResultContents setOwner(GetBucketResponseListBucketResultContentsOwner owner) {
            this.owner = owner;
            return this;
        }
        public GetBucketResponseListBucketResultContentsOwner getOwner() {
            return this.owner;
        }

    }

    public static class GetBucketResponseListBucketResult extends TeaModel {
        // Name
        @NameInMap("Name")
        public String name;

        // Prefix
        @NameInMap("Prefix")
        public String prefix;

        // Marker
        @NameInMap("Marker")
        public String marker;

        // MaxKeys
        @NameInMap("MaxKeys")
        public String maxKeys;

        // Delimiter
        @NameInMap("Delimiter")
        public String delimiter;

        // IsTruncated
        @NameInMap("IsTruncated")
        public String isTruncated;

        // EncodingType
        @NameInMap("EncodingType")
        public String encodingType;

        // CommonPrefixes
        @NameInMap("CommonPrefixes")
        public String commonPrefixes;

        // Contents
        @NameInMap("Contents")
        public java.util.List<GetBucketResponseListBucketResultContents> contents;

        public static GetBucketResponseListBucketResult build(java.util.Map<String, ?> map) throws Exception {
            GetBucketResponseListBucketResult self = new GetBucketResponseListBucketResult();
            return TeaModel.build(map, self);
        }

        public GetBucketResponseListBucketResult setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public GetBucketResponseListBucketResult setPrefix(String prefix) {
            this.prefix = prefix;
            return this;
        }
        public String getPrefix() {
            return this.prefix;
        }

        public GetBucketResponseListBucketResult setMarker(String marker) {
            this.marker = marker;
            return this;
        }
        public String getMarker() {
            return this.marker;
        }

        public GetBucketResponseListBucketResult setMaxKeys(String maxKeys) {
            this.maxKeys = maxKeys;
            return this;
        }
        public String getMaxKeys() {
            return this.maxKeys;
        }

        public GetBucketResponseListBucketResult setDelimiter(String delimiter) {
            this.delimiter = delimiter;
            return this;
        }
        public String getDelimiter() {
            return this.delimiter;
        }

        public GetBucketResponseListBucketResult setIsTruncated(String isTruncated) {
            this.isTruncated = isTruncated;
            return this;
        }
        public String getIsTruncated() {
            return this.isTruncated;
        }

        public GetBucketResponseListBucketResult setEncodingType(String encodingType) {
            this.encodingType = encodingType;
            return this;
        }
        public String getEncodingType() {
            return this.encodingType;
        }

        public GetBucketResponseListBucketResult setCommonPrefixes(String commonPrefixes) {
            this.commonPrefixes = commonPrefixes;
            return this;
        }
        public String getCommonPrefixes() {
            return this.commonPrefixes;
        }

        public GetBucketResponseListBucketResult setContents(java.util.List<GetBucketResponseListBucketResultContents> contents) {
            this.contents = contents;
            return this;
        }
        public java.util.List<GetBucketResponseListBucketResultContents> getContents() {
            return this.contents;
        }

    }

}
