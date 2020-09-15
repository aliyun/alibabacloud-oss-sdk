// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class GetObjectMetaResponse extends TeaModel {
    // x-oss-request-id
    @NameInMap("x-oss-request-id")
    @Validation(required = true)
    public String requestId;

    // ETag
    @NameInMap("etag")
    @Validation(required = true)
    public String eTag;

    // Content-Length
    @NameInMap("content-length")
    @Validation(required = true)
    public String contentLength;

    // Last-Modified
    @NameInMap("last-modified")
    @Validation(required = true)
    public String lastModified;

    public static GetObjectMetaResponse build(java.util.Map<String, ?> map) {
        GetObjectMetaResponse self = new GetObjectMetaResponse();
        return TeaModel.build(map, self);
    }

    public GetObjectMetaResponse setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public GetObjectMetaResponse setETag(String eTag) {
        this.eTag = eTag;
        return this;
    }
    public String getETag() {
        return this.eTag;
    }

    public GetObjectMetaResponse setContentLength(String contentLength) {
        this.contentLength = contentLength;
        return this;
    }
    public String getContentLength() {
        return this.contentLength;
    }

    public GetObjectMetaResponse setLastModified(String lastModified) {
        this.lastModified = lastModified;
        return this;
    }
    public String getLastModified() {
        return this.lastModified;
    }

}
